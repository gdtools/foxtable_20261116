using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000320 RID: 800
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class TableCollection : IEnumerable<Table>
	{
		// Token: 0x06002CEB RID: 11499 RVA: 0x0014C9F4 File Offset: 0x0014ABF4
		internal TableCollection(Dictionary<string, O_0> A_0)
		{
			this.o0O0Oo.OoO_. = new Dictionary<string, Table>();
			try
			{
				foreach (O_0 o_ in A_0.Values)
				{
					this.o0O0Oo.OoO_..Add(o_.Oo._Oo0OO.(), new Table(o_));
				}
			}
			finally
			{
				Dictionary<string, O_0>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x0014CA68 File Offset: 0x0014AC68
		internal void <<EMPTY_NAME>>(Table A_0)
		{
			this.o0O0Oo.OoO_..Add(A_0.View.Oo._Oo0OO.(), A_0);
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x0014CA81 File Offset: 0x0014AC81
		internal void <<EMPTY_NAME>>(O_0 A_0)
		{
			this.o0O0Oo.OoO_..Add(A_0.Oo._Oo0OO.(), new Table(A_0));
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x0014CA9A File Offset: 0x0014AC9A
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.o0O0Oo.OoO_..Remove(A_0);
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x0014CAAC File Offset: 0x0014ACAC
		internal void <<EMPTY_NAME>>(Table A_0)
		{
			try
			{
				foreach (string key in this.o0O0Oo.OoO_..Keys)
				{
					if (this.o0O0Oo.OoO_.[key] == A_0)
					{
						this.o0O0Oo.OoO_..Remove(key);
						break;
					}
				}
			}
			finally
			{
				Dictionary<string, Table>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x0014CB1C File Offset: 0x0014AD1C
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (O_0 o_ in O_O0OO.o__.O.().Values)
				{
					if (!this.o0O0Oo.OoO_..ContainsKey(o_.Oo._Oo0OO.()))
					{
						this.o0O0Oo.OoO_..Add(o_.Oo._Oo0OO.(), new Table(o_));
					}
				}
			}
			finally
			{
				Dictionary<string, O_0>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x0014CB98 File Offset: 0x0014AD98
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Table Item
		{
			get
			{
				Table result;
				if (this.o0O0Oo.OoO_..ContainsKey(Name))
				{
					result = this.o0O0Oo.OoO_.[Name];
				}
				else
				{
					try
					{
						foreach (string text in this.o0O0Oo.OoO_..Keys)
						{
							if (Operators.CompareString(text, Name, true) == 0)
							{
								return this.o0O0Oo.OoO_.[text];
							}
						}
					}
					finally
					{
						Dictionary<string, Table>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					MessageBox.Show("不存在名称为\"" + Name + "\"的Table！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x0014CC44 File Offset: 0x0014AE44
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Table Item
		{
			get
			{
				int num = 0;
				try
				{
					foreach (Table result in this.o0O0Oo.OoO_..Values)
					{
						if (num == A_0)
						{
							return result;
						}
						num++;
					}
				}
				finally
				{
					Dictionary<string, Table>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return null;
			}
		}

		// Token: 0x17000A18 RID: 2584
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Table this[object A_0]
		{
			get
			{
				int a_ = -1;
				Table result;
				if (int.TryParse(A_0.ToString(), out a_))
				{
					result = this.OO._O_o__.(a_);
				}
				else
				{
					result = this.get_Item(A_0.ToString());
				}
				return result;
			}
		}

		/// <summary>
		/// 返回Table数量
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x0014CCDE File Offset: 0x0014AEDE
		public int Count
		{
			get
			{
				return this.o0O0Oo.OoO_..Count;
			}
		}

		/// <summary>
		/// 判断是否存在指定名称的Table
		/// </summary>
		/// <param name="TableName">表名</param>
		/// <returns></returns>
		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x0014CCEC File Offset: 0x0014AEEC
		public bool Contains
		{
			get
			{
				bool result;
				if (this.o0O0Oo.OoO_..ContainsKey(TableName))
				{
					result = true;
				}
				else
				{
					try
					{
						Dictionary<string, Table>.KeyCollection.Enumerator enumerator = this.o0O0Oo.OoO_..Keys.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (Operators.CompareString(enumerator.Current, TableName, true) == 0)
							{
								return true;
							}
						}
					}
					finally
					{
						Dictionary<string, Table>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x0014CD60 File Offset: 0x0014AF60
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<Table> GetEnumerator()
		{
			return (IEnumerator<Table>)this.o0O0Oo.OoO_..Values.GetEnumerator();
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x0014CD7C File Offset: 0x0014AF7C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return (IEnumerator)this.o0O0Oo.OoO_..Values.GetEnumerator();
		}

		// Token: 0x04001232 RID: 4658
		internal Dictionary<string, Table> <<EMPTY_NAME>>;
	}
}
