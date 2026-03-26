/***********************************************************************************
* File:         GazetteerDialog.cs                                                 *
* Contents:     Class GazetteerDialog                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;

namespace Optica.WinForms.Dialogs
{
	public partial class EntityDialog : Form
	{
		public EntityDialog()
		{
			InitializeComponent();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string TitleLabel
		{
			get	{return this._lblTitle.Text;}

			set	{this._lblTitle.Text = value;}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string DescriptionLabel
		{
			get	{return this._lblDescription.Text;}

			set	{this._lblDescription.Text = value;}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string TitelValue
		{
			get	{return this._txTitle.Text;}

			set	{this._txTitle.Text = value;}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string DescriptionValue
		{
			get	{return this._txDescription.Text;}

			set	{this._txDescription.Text = value;}
		}
	}
}
