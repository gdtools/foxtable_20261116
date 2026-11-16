using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using C1.C1Excel;

namespace Foxtable.XLS
{
	// Token: 0x020004FB RID: 1275
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RowCollection : IEnumerable<Row>
	{
		// Token: 0x06005358 RID: 21336 RVA: 0x00255FBD File Offset: 0x002541BD
		public RowCollection(XLRowCollection A_0)
		{
			this.OoOoo.o. = A_0;
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06005359 RID: 21337 RVA: 0x00255FCC File Offset: 0x002541CC
		public int Count
		{
			get
			{
				return this.OoOoo.o..Count;
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600535A RID: 21338 RVA: 0x00255FD9 File Offset: 0x002541D9
		// (set) Token: 0x0600535B RID: 21339 RVA: 0x00255FE6 File Offset: 0x002541E6
		public int Frozen
		{
			get
			{
				return this.OoOoo.o..Frozen;
			}
			set
			{
				this.OoOoo.o..Frozen = value;
			}
		}

		// Token: 0x17001232 RID: 4658
		public Row this[int Index]
		{
			get
			{
				return new Row(this.OoOoo.o.[Index]);
			}
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x00256007 File Offset: 0x00254207
		public void Clear()
		{
			this.OoOoo.o..Clear();
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x00256014 File Offset: 0x00254214
		public Row Add()
		{
			return new Row(this.OoOoo.o..Add());
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x00256026 File Offset: 0x00254226
		public Row Insert(int Index)
		{
			return new Row(this.OoOoo.o..Insert(Index));
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x00256039 File Offset: 0x00254239
		public void Remove(Row Row)
		{
			this.OoOoo.o..Remove(Row.OoOoo.o.);
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x0025604D File Offset: 0x0025424D
		public void RemoveAt(int Index)
		{
			this.OoOoo.o..RemoveAt(Index);
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x0025605C File Offset: 0x0025425C
		public IEnumerator<Row> GetEnumerator()
		{
			return new c(this.OoOoo.o.);
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x00256069 File Offset: 0x00254269
		public IEnumerator GetEnumerator1()
		{
			return new c(this.OoOoo.o.);
		}

		// Token: 0x0400229C RID: 8860
		private XLRowCollection <<EMPTY_NAME>>;
	}
}
