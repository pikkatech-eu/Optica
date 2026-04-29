/***********************************************************************************
* File:         IListViewService.cs                                                *
* Contents:     Interface IListViewService                                         *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-26 19:28                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Opica.Contracts
{
	public interface IListViewService<T>
	{
		Func<T, string[]> Mapper	{get;set;}
		void Display(IEnumerable<T> items);
		T SelectedItem	{get;set;}
	}
}
