/***********************************************************************************
* File:         ICommonDialogService.cs                                            *
* Contents:     Interface ICommonDialogService                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-26 09:39                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Optica.Contracts.Enumerations;

namespace Optica.Contracts
{
	public record EntityRecord(string Title, string Description);

	public interface ICommonDialogService
	{
		/// <summary>
		/// Shows a messageBox with given parameters and returns its return value.
		/// </summary>
		/// <param name="title">The title of the message box.</param>
		/// <param name="message">The message text.</param>
		/// <param name="buttons">Defines which buttons to display.</param>
		/// <param name="icon">Defines which icon to display.</param>
		/// <returns>
		///		If buttons is OkCancel, returns true if the user clicked on OK, otherwise false.
		///		If buttons is Ok, returns true (irrelevant).
		///	</returns>
		bool ShowMessageBox
							(
								string title, 
								string message, 
								MessageDialogButtons buttons=MessageDialogButtons.Ok, 
								MessageDialogIcons icon =MessageDialogIcons.None
							);

		/// <summary>
		/// Shows a FileDialog to select the file namr for load or save.
		/// </summary>
		/// <param name="options">The options.</param>
		/// <returns></returns>
		string GetFileName(FileDialogOptions options);

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
		T GetValue<T>(string title, string label);

		EntityRecord GetEntityRecord
									(
										EntityRecord entityRecord, 
										string labelTitle="Title", 
										string labelDescription="Description"
									);
	}
}
