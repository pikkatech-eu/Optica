/***********************************************************************************
* File:         WinFormsCommonDialogService.cs                                     *
* Contents:     Class WinFormsCommonDialogService                                  *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-26 10:42                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Optica.Contracts;
using Optica.Contracts.Enumerations;
using Optica.WinForms.Dialogs;

namespace Optica.WinForms
{
	public class WinFormsCommonDialogService : ICommonDialogService
	{
		/// <summary>
		/// Shows a MessageBox with given parameters and returns its return value.
		/// </summary>
		/// <param name="title">The title of the message box.</param>
		/// <param name="message">The message text.</param>
		/// <param name="buttons">Defines which buttons to display.</param>
		/// <param name="icon">Defines which icon to display.</param>
		/// <returns>
		///		If buttons is OkCancel, returns true if the user clicked on OK, otherwise false.
		///		If buttons is Ok, returns true (irrelevant).
		///	</returns>
		public bool ShowMessageBox
									(
										string caption, 
										string message, 
										MessageDialogButtons buttons = MessageDialogButtons.Ok, 
										MessageDialogIcons icon = MessageDialogIcons.None
									)
		{
			MessageBoxButtons mbButtons;
			switch (buttons)
			{
				case MessageDialogButtons.Ok:
					mbButtons = MessageBoxButtons.OK;
					break;

				case MessageDialogButtons.OkCancel:
				default:
					mbButtons = MessageBoxButtons.OKCancel;
					break;
			}

			MessageBoxIcon mbIcon;
			switch (icon)
			{
				case MessageDialogIcons.Error:
					mbIcon = MessageBoxIcon.Error;
					break;

				case MessageDialogIcons.Warning:
					mbIcon = MessageBoxIcon.Warning;
					break;

				case MessageDialogIcons.Question:
					mbIcon = MessageBoxIcon.Question;
					break;

				case MessageDialogIcons.Information:
					mbIcon = MessageBoxIcon.Information;
					break;

				case MessageDialogIcons.None:
				default:
					mbIcon = MessageBoxIcon.None;
					break;
			}

			DialogResult result = MessageBox.Show(message, caption, mbButtons, mbIcon);

			if (buttons == MessageDialogButtons.Ok)
			{
				return true;
			}
			else
			{
				return result == DialogResult.OK;
			}
		}

		/// <summary>
		/// Shows a FileDialog to select the file namr for load or save.
		/// </summary>
		/// <param name="options">The options.</param>
		/// <returns>The file name, if successful, otherwise null.</returns>
		public string GetFileName(FileDialogOptions options)
		{
			switch (options.FileDialogKind)
			{
				case FileDialogKind.Save:
					SaveFileDialog sfd = new SaveFileDialog();
					sfd.Filter = options.Filter;

					if (sfd.ShowDialog() == DialogResult.OK)
					{
						return sfd.FileName;
					}
					else
					{
						return null;
					}

				case FileDialogKind.Load:
					OpenFileDialog ofd = new OpenFileDialog();
					ofd.Filter = options.Filter;

					if (ofd.ShowDialog() == DialogResult.OK)
					{
						return ofd.FileName;
					}
					else
					{
						return null;
					}

				default:
					return null;
			}
		}

		/// <summary>
		/// Simple value dialog.
		/// To input values of a number of supported value types.
		/// </summary>
		/// <typeparam name="T">
		///		Type of input value.
		///		Supported are:
		///			String
		///			Int
		///			Double
		///			DateTime		
		///	</typeparam>
		/// <param name="title">Dialog's Title.</param>
		/// <param name="label">The label at thr value field.</param>
		/// <returns>Ther value of the type user inputted.</returns>
		/// <exception cref="NotSupportedException">Thrown if the value type is not supported.</exception>
		public T GetValue<T>(string title, string label)
		{
			CommonValueDialog dialog = new CommonValueDialog();
			dialog.Text	= title;
			dialog.ValueLabel = label;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string stringValue = dialog.StringValue;

				Type type = typeof(T);
				object result;

				switch (type)
				{
					case Type _ when type == typeof(string):
					case Type _ when type == typeof(int):
					case Type _ when type == typeof(double):
					case Type _ when type == typeof(DateTime):
						try
						{
							return (T)Convert.ChangeType(stringValue, typeof(T));
						}
						catch (FormatException fe)
						{
							throw;
						}

					default:
						throw new NotSupportedException($"Type {type.Name} is not supported");
				}
			}
			else
			{
				return default(T);
			}
		}

		/// <summary>
		/// Tries to get a value of supported type from a simple value dialog.
		/// </summary>
		/// <typeparam name="T">Type of input value.</typeparam>
		/// <param name="title">Dialog's Title.</param>
		/// <param name="label">The label at thr value field.</param>
		/// <param name="t">Resulting value supplied by dialog, if successful.</param>
		/// <returns>True, if the action was successful.</returns>
		public bool TryGetValue<T>(string title, string label, out T t)
		{
			try
			{
				t = this.GetValue<T>(title, label);
				return true;
			}
			catch (Exception)
			{
				t = default(T);
				return false;
			}
		}

		/// <summary>
		/// Shows EntityRecord dialog, sers initial values on an EntityRecord
		/// and returns the EntityRecord as set / edited by user.
		/// </summary>
		/// <param name="entityRecord">Initial value of EntityRecord.</param>
		/// <param name="caption">The caption of the dislog.</param>
		/// <param name="labelTitle">The title label.</param>
		/// <param name="labelDescription">The decsription label.</param>
		/// <returns>The resulting value of EntityRecord.</returns>
		public EntityRecord GetEntityRecord
											(
												EntityRecord entityRecord, 
												string caption			= "Entity Properties", 
												string labelTitle		= "Title", 
												string labelDescription = "Description"
											)
		{
			EntityDialog dialog		= new EntityDialog();

			dialog.Text				= caption;
			dialog.TitleLabel		= labelTitle;
			dialog.DescriptionLabel	= labelDescription;
			dialog.TitelValue		= entityRecord.Title;
			dialog.DescriptionValue	= entityRecord.Description;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				return new EntityRecord(dialog.TitelValue, dialog.DescriptionValue);
			}
			else
			{
				return null;
			}
		}
	}
}
