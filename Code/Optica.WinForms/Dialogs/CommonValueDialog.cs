/***********************************************************************************
* File:         PikkaCoreDialog1.cs                                                  *
* Contents:     Class PikkaCoreDialog1                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Optica.WinForms.Dialogs
{
	public partial class CommonValueDialog : Form
	{
		public CommonValueDialog()
		{
			InitializeComponent();
		}

		internal string StringValue
		{
			get
			{
				return this._txValue.Text;
			}
		}
	}
}
