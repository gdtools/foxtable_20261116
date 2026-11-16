using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using C1.Win.C1FlexGrid;

namespace Foxtable
{
	/// <summary>
	/// 用于生成多列数据字典
	/// </summary>
	// Token: 0x02000324 RID: 804
	[ComVisible(true)]
	[oO0oooo("0581")]
	public class MultiDataMap
	{
		// Token: 0x06002D01 RID: 11521 RVA: 0x0014CECC File Offset: 0x0014B0CC
		public MultiDataMap()
		{
			this.Oo.__O0. = new List<string>();
		}

		/// <summary>
		/// 增加项目
		/// </summary>
		/// <param name="Item">要增加的项目，每一列的内容用符号“|”隔开</param>
		// Token: 0x06002D02 RID: 11522 RVA: 0x0014CEDF File Offset: 0x0014B0DF
		public void Add(string Item)
		{
			this.Oo.__O0..Add(Item);
		}

		/// <summary>
		/// 显示列序号
		/// </summary>
		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002D03 RID: 11523 RVA: 0x0014CEED File Offset: 0x0014B0ED
		// (set) Token: 0x06002D04 RID: 11524 RVA: 0x0014CEF5 File Offset: 0x0014B0F5
		public int DisplayCol
		{
			get
			{
				return this.Oo.__O0.;
			}
			set
			{
				this.Oo.__O0. = value;
			}
		}

		/// <summary>
		/// 取值列序号
		/// </summary>
		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x0014CEFE File Offset: 0x0014B0FE
		// (set) Token: 0x06002D06 RID: 11526 RVA: 0x0014CF06 File Offset: 0x0014B106
		public int ValueCol
		{
			get
			{
				return this.O_.0_ooO_oo.;
			}
			set
			{
				this.O_.0_ooO_oo. = value;
			}
		}

		/// <summary>
		/// 生成多列数据字典
		/// </summary>
		// Token: 0x06002D07 RID: 11527 RVA: 0x0014CF10 File Offset: 0x0014B110
		public IDictionary CreateDataMap()
		{
			IDictionary result;
			if (this.Oo.__O0..Count == 0)
			{
				result = null;
			}
			else
			{
				DataTable dataTable = new DataTable();
				int num = this.Oo.__O0.[0].Split(new char[]
				{
					'|'
				}).Length - 1;
				for (int i = 0; i <= num; i++)
				{
					dataTable.Columns.Add("C" + i.ToString(), typeof(string));
				}
				try
				{
					foreach (string text in this.Oo.__O0.)
					{
						string[] array = text.Split(new char[]
						{
							'|'
						});
						DataRow dataRow = dataTable.NewRow();
						int num2 = Math.Min(dataTable.Columns.Count - 1, array.Length - 1);
						for (int j = 0; j <= num2; j++)
						{
							dataRow[j] = array[j];
						}
						dataTable.Rows.Add(dataRow);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = new MultiColumnDictionary(dataTable, "C" + this.ValueCol.ToString(), null, this.DisplayCol);
			}
			return result;
		}

		// Token: 0x04001243 RID: 4675
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04001244 RID: 4676
		private int <<EMPTY_NAME>>;

		// Token: 0x04001245 RID: 4677
		private int <<EMPTY_NAME>>;
	}
}
