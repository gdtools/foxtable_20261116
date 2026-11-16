using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using C1.C1Excel;

namespace Foxtable.XLS
{
	// Token: 0x020004F1 RID: 1265
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ColColection : IEnumerable<Col>
	{
		// Token: 0x060052FC RID: 21244 RVA: 0x00255793 File Offset: 0x00253993
		public ColColection(XLColumnCollection A_0)
		{
			this.o0_.O_o. = A_0;
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060052FD RID: 21245 RVA: 0x002557A2 File Offset: 0x002539A2
		public int Count
		{
			get
			{
				return this.o0_.O_o..Count;
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060052FE RID: 21246 RVA: 0x002557AF File Offset: 0x002539AF
		// (set) Token: 0x060052FF RID: 21247 RVA: 0x002557BC File Offset: 0x002539BC
		public int Frozen
		{
			get
			{
				return this.o0_.O_o..Frozen;
			}
			set
			{
				this.o0_.O_o..Frozen = value;
			}
		}

		// Token: 0x1700120E RID: 4622
		public Col this[int Index]
		{
			get
			{
				return new Col(this.o0_.O_o.[Index]);
			}
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x002557DD File Offset: 0x002539DD
		public void Clear()
		{
			this.o0_.O_o..Clear();
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x002557EA File Offset: 0x002539EA
		public Col Add()
		{
			return new Col(this.o0_.O_o..Add());
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x002557FC File Offset: 0x002539FC
		public Col Insert(int Index)
		{
			return new Col(this.o0_.O_o..Insert(Index));
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x0025580F File Offset: 0x00253A0F
		public void Remove(Col Col)
		{
			this.o0_.O_o..Remove(Col.o0_.O_o.);
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x00255823 File Offset: 0x00253A23
		public void RemoveAt(int Index)
		{
			this.o0_.O_o..RemoveAt(Index);
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x00255832 File Offset: 0x00253A32
		public IEnumerator<Col> GetEnumerator()
		{
			return new a(this.o0_.O_o.);
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x0025583F File Offset: 0x00253A3F
		public IEnumerator GetEnumerator1()
		{
			return new a(this.o0_.O_o.);
		}

		// Token: 0x04002279 RID: 8825
		private XLColumnCollection <<EMPTY_NAME>>;
	}
}
