/***********************************************************************************
* File:         WinFormsListViewService.cs                                         *
* Contents:     Class WinFormsListViewService                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-26 19:30                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Opica.Contracts;

namespace Opica.WinForms
{
	public class WinFormsListViewService<T> : IListViewService<T>
	{
		private readonly  ListView  _listView;

		public Func<T, string[]> Mapper	{get;set;}

		public WinFormsListViewService(ListView listView)
		{
			this._listView = listView;
		}

		public void Display(IEnumerable<T> items)
		{
			this._listView.Items.Clear();

			foreach (T item in items)
			{
				ListViewItem lvi	= new ListViewItem(this.Mapper(item));
				lvi.Tag				= item;

				this._listView.Items.Add(lvi);
			}

			this._listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this._listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		public T SelectedItem
		{
			get
			{
				if (this._listView.SelectedItems.Count == 1)
				{
					return (T)this._listView.SelectedItems[0].Tag;
				}
				else
				{
					return default(T);
				}
			}

			set
			{
				// not yet implemented
			}
		}
	}
}
