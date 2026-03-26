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
	/// <summary>
	/// Format for the exchange with GetEntityRecord service.
	/// A string entity includes two components: Title and description.
	/// This pattern repeats in many collections.
	/// </summary>
	/// <param name="Title">The title of the entity.</param>
	/// <param name="Description">Thr description of the entity.</param>
	public record EntityRecord(string Title, string Description);

	/// <summary>
	/// Defines services occurring in common patterns.
	/// </summary>
	public interface ICommonDialogService
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
		/// <returns>The file name, if successful, otherwise null.</returns>
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

		/// <summary>
		/// Tries to get a value of supported type from a simple value dialog.
		/// </summary>
		/// <typeparam name="T">Type of input value.</typeparam>
		/// <param name="title">Dialog's Title.</param>
		/// <param name="label">The label at thr value field.</param>
		/// <param name="t">Resulting value supplied by dialog, if successful.</param>
		/// <returns>True, if the action was successful.</returns>
		bool TryGetValue<T>(string title, string label, out T t);

		/// <summary>
		/// Shows EntityRecord dialog, sers initial values on an EntityRecord
		/// and returns the EntityRecord as set / edited by user.
		/// </summary>
		/// <param name="entityRecord">Initial value of EntityRecord.</param>
		/// <param name="caption">The caption of the dislog.</param>
		/// <param name="labelTitle">The title label.</param>
		/// <param name="labelDescription">The decsription label.</param>
		/// <returns>The resulting value of EntityRecord.</returns>
		EntityRecord GetEntityRecord
									(
										EntityRecord entityRecord, 
										string caption = "Entity Properties",
										string labelTitle="Title", 
										string labelDescription="Description"
									);
	}
}
