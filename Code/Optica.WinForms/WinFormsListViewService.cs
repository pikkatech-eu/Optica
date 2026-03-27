/***********************************************************************************
* File:         WinFormsListViewService.cs                                         *
* Contents:     Class WinFormsListViewService                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-26 19:30                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Optica.Contracts;

namespace Optica.WinForms
{
	public class WinFormsListViewService<T> : IListViewService<T>
	{
		// Cludge?
		public object ListViewControl	{get;set;}

		public Func<T, string[]> Mapper	{get;set;}

		public void Display(IEnumerable<T> items)
		{
			ListView listView = (ListView)this.ListViewControl;

			listView.Items.Clear();

			foreach (T item in items)
			{
				ListViewItem lvi	= new ListViewItem(this.Mapper(item));
				lvi.Tag				= item;

				listView.Items.Add(lvi);
			}

			listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		public T SelectedItem
		{
			get
			{
				ListView listView = (ListView)this.ListViewControl;

				if (listView.SelectedItems.Count == 1)
				{
					return (T)listView.SelectedItems[0].Tag;
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
