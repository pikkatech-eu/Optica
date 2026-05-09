/***********************************************************************************
* File:         ClipboardService.cs                                                *
* Contents:     Class ClipboardService                                             *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-09 11:28                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Opica.Contracts;
using System.Globalization;
using System.Text.Json;

namespace Opica.WinForms
{
	public class ClipboardService : IClipboardService
	{
		/// <summary>
		/// Generates the format string serving a the key in Windows' clipboard internal dictionary for custom formats.
		/// </summary>
		/// <typeparam name="T">Type of data object.</typeparam>
		/// <returns></returns>
		private static string FormatName<T>() => $"json::{typeof(T).FullName}";

		/// <summary>
		/// Sets an object to clipboard.
		/// </summary>
		/// <typeparam name="T">Type of the object.</typeparam>
		/// <param name="value">Object to set</param>
		public void Set<T>(T value)
		{
			switch (value)
			{
				case string s:
					Clipboard.SetText(s);
					break;

				case double d:
					Clipboard.SetText(d.ToString(CultureInfo.InvariantCulture));
					break;

				case DateTime dt:
					Clipboard.SetText(dt.ToString("O")); // ISO 8601 round-trip format
					break;

				default:
					var json = JsonSerializer.Serialize(value);
					var data = new DataObject();
					data.SetData(FormatName<T>(), json);
					Clipboard.SetDataObject(data);
					break;
			}
		}

		/// <summary>
		/// Gets an object from clipboard.
		/// </summary>
		/// <typeparam name="T">Type of the object.</typeparam>
		/// <returns>The value of the object, if successful, otherwise null.</returns>
		public T? Get<T>()
		{
			Type type = typeof(T);

			try
			{
				switch (type)
				{
					case Type _ when type == typeof(string):
						return (T)(object)Clipboard.GetText();

					case Type _ when type == typeof(double):
						return (T)(object)double.Parse(Clipboard.GetText(), CultureInfo.InvariantCulture);

					case Type _ when type == typeof(DateTime):
						return (T)(object)DateTime.Parse(Clipboard.GetText(), CultureInfo.InvariantCulture);

					default:
						var data = Clipboard.GetDataObject();

						if (data == null)
						{
							return default;
						}

						string format = FormatName<T>();

						if (data.GetDataPresent(format))
						{
							string json = (string)data.GetData(format);
							return JsonSerializer.Deserialize<T>(json);
						}
						else
						{
							return default(T);
						}
				}
			}
			catch
			{
				return default;
			}
		}

		/// <summary>
		/// Useful to check before attempting a paste.
		/// </summary>
		/// <typeparam name="T">Type of the object.</typeparam>
		/// <returns>True, if the object can be retrieved.</returns>
		public bool CanGet<T>()
		{
			if (typeof(T) == typeof(string))
			{
				return Clipboard.ContainsText();
			}

			return Clipboard.GetDataObject()?.GetDataPresent(FormatName<T>()) ?? false;
		}

		/// <summary>
		/// Clears the clipboard.
		/// </summary>
		public void Clear()
		{
			Clipboard.Clear();
		}
	}
}
