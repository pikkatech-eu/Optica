/***********************************************************************************
* File:         IClipboardService.cs                                               *
* Contents:     Interface IClipboardService                                        *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-09 11:24                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Opica.Contracts
{
	/// <summary>
	/// Definition of universal clipboard service.
	/// </summary>
	public interface IClipboardService
	{
		/// <summary>
		/// Sets an object to clipboard.
		/// </summary>
		/// <typeparam name="T">Type of the object.</typeparam>
		/// <param name="value">Object to set</param>
		void Set<T>(T value);

		/// <summary>
		/// Gets an object from clipboard.
		/// </summary>
		/// <typeparam name="T">Type of the object.</typeparam>
		/// <returns>The value of the object, if successful, otherwise null.</returns>
		T? Get<T>();

		/// <summary>
		/// Useful to check before attempting a paste.
		/// </summary>
		/// <typeparam name="T">Type of the object.</typeparam>
		/// <returns>True, if the object can be retrieved.</returns>
		bool CanGet<T>(); 

		/// <summary>
		/// Clears the clipboard.
		/// </summary>
		void Clear();
	}
}
