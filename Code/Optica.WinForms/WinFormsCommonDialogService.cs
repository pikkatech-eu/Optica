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


		public T GetValue<T>(string title, string label)
		{
			CommonValueDialog dialog = new CommonValueDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string stringValue = dialog.StringValue;

				Type type = typeof(T);
				object result;

				switch (type)
				{
					case Type _ when type == typeof(string):
						return (T)Convert.ChangeType(stringValue, typeof(T));

					case Type _ when type == typeof(int):
						return (T)Convert.ChangeType(stringValue, typeof(T));

					case Type _ when type == typeof(double):
						return (T)Convert.ChangeType(stringValue, typeof(T));

					default:
						throw new NotSupportedException("Type not supported");
				}
			}
			else
			{
				return default(T);
			}
		}

		public EntityRecord GetEntityRecord(EntityRecord entityRecord, string labelTitle = "Title", string labelDescription = "Description")
		{
			throw new NotImplementedException();
		}
	}
}
