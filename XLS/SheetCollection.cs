using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using C1.C1Excel;

namespace Foxtable.XLS
{
	// Token: 0x020004FE RID: 1278
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class SheetCollection : IEnumerable<Sheet>
	{
		// Token: 0x06005383 RID: 21379 RVA: 0x002562CE File Offset: 0x002544CE
		public SheetCollection(XLSheetCollection A_0)
		{
			this.Ooo_O__.0. = A_0;
		}

		// Token: 0x17001240 RID: 4672
		public Sheet this[int Index]
		{
			get
			{
				return new Sheet(this.Ooo_O__.0.[Index]);
			}
		}

		// Token: 0x17001241 RID: 4673
		public Sheet this[string Name]
		{
			get
			{
				return new Sheet(this.Ooo_O__.0.[Name]);
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06005386 RID: 21382 RVA: 0x00256303 File Offset: 0x00254503
		public int Count
		{
			get
			{
				return this.Ooo_O__.0..Count;
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x06005387 RID: 21383 RVA: 0x00256310 File Offset: 0x00254510
		// (set) Token: 0x06005388 RID: 21384 RVA: 0x0025631D File Offset: 0x0025451D
		public int SelectedIndex
		{
			get
			{
				return this.Ooo_O__.0..SelectedIndex;
			}
			set
			{
				this.Ooo_O__.0..SelectedIndex = value;
			}
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x0025632B File Offset: 0x0025452B
		public Sheet Add()
		{
			return new Sheet(this.Ooo_O__.0..Add());
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x0025633D File Offset: 0x0025453D
		public Sheet Add(string Name)
		{
			return new Sheet(this.Ooo_O__.0..Add(Name));
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x00256350 File Offset: 0x00254550
		public void Add(Sheet Sheet)
		{
			this.Ooo_O__.0..Add(Sheet.Ooo_O__.0.);
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x00256364 File Offset: 0x00254564
		public Sheet Insert(int Index)
		{
			return new Sheet(this.Ooo_O__.0..Insert(Index));
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x00256378 File Offset: 0x00254578
		public Sheet Insert(int Index, string Name)
		{
			XLSheet xlsheet = this.Ooo_O__.0..Add(Name);
			this.Ooo_O__.0..Remove(xlsheet);
			this.Ooo_O__.0..Insert(Index, xlsheet);
			return new Sheet(xlsheet);
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x002563B2 File Offset: 0x002545B2
		public void Insert(int Index, Sheet Sheet)
		{
			this.Ooo_O__.0..Insert(Index, Sheet.Ooo_O__.0.);
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x002563C7 File Offset: 0x002545C7
		public void Clear()
		{
			this.Ooo_O__.0..Clear();
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x002563D4 File Offset: 0x002545D4
		public void Remove(Sheet Sheet)
		{
			this.Ooo_O__.0..Remove(Sheet.Ooo_O__.0.);
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x002563E7 File Offset: 0x002545E7
		public void RemoveAt(int Index)
		{
			this.Ooo_O__.0..RemoveAt(Index);
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x002563F5 File Offset: 0x002545F5
		public void Remove(string Name)
		{
			this.Ooo_O__.0..Remove(Name);
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00256403 File Offset: 0x00254603
		public IEnumerator<Sheet> GetEnumerator()
		{
			return new b(this.Ooo_O__.0.);
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00256410 File Offset: 0x00254610
		public IEnumerator GetEnumerator1()
		{
			return new b(this.Ooo_O__.0.);
		}

		// Token: 0x040022A4 RID: 8868
		private XLSheetCollection <<EMPTY_NAME>>;
	}
}
