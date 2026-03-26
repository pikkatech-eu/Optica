/***********************************************************************************
* File:         FileDialogOptions.cs                                               *
* Contents:     Class FileDialogOptions                                            *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-26 10:04                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Optica.Contracts.Enumerations;

namespace Optica.Contracts
{
	public class FileDialogOptions
	{
		public FileDialogKind FileDialogKind	{get;set;}
		public string Title						{get;set;}	= "";
		public string Filter					{get;set;}	= "";
		public string DefaultExtension			{get;set;}	= "";
	}
}
