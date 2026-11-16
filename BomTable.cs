using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000098 RID: 152
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class BomTable
	{
		/// <summary>
		/// 物料表
		/// </summary>
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0002F8A7 File Offset: 0x0002DAA7
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x0002F8AF File Offset: 0x0002DAAF
		public DataTable DataTable { get; set; }

		/// <summary>
		/// 父列
		/// </summary>
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0002F8B8 File Offset: 0x0002DAB8
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x0002F8C0 File Offset: 0x0002DAC0
		public string ParentCol { get; set; }

		/// <summary>
		/// 层级列
		/// </summary>
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0002F8C9 File Offset: 0x0002DAC9
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x0002F8D1 File Offset: 0x0002DAD1
		public string PathCol { get; set; }

		/// <summary>
		/// 分隔符
		/// </summary>
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0002F8DA File Offset: 0x0002DADA
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x0002F8E7 File Offset: 0x0002DAE7
		public string Separator
		{
			get
			{
				return Conversions.ToString(this.Separator2);
			}
			set
			{
				if (value.Length > 0)
				{
					this.Separator2 = value[0];
				}
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0002F8FF File Offset: 0x0002DAFF
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x0002F907 File Offset: 0x0002DB07
		internal char Separator2 { get; set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0002F910 File Offset: 0x0002DB10
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x0002F964 File Offset: 0x0002DB64
		public object[] Lengths
		{
			get
			{
				List<object> list = new List<object>();
				if (this.lengths2 != null && this.lengths2.Length > 0)
				{
					foreach (int num in this.lengths2)
					{
						list.Add(num);
					}
				}
				return list.ToArray();
			}
			set
			{
				List<int> list = new List<int>();
				checked
				{
					for (int i = 0; i < value.Length; i++)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(value[i]);
						if (objectValue is int)
						{
							list.Add(Conversions.ToInteger(objectValue));
						}
					}
					this.lengths2 = list.ToArray();
				}
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0002F9B0 File Offset: 0x0002DBB0
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x0002F9B8 File Offset: 0x0002DBB8
		internal int[] lengths2 { get; set; }

		/// <summary>
		/// 物料列
		/// </summary>
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0002F9C1 File Offset: 0x0002DBC1
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x0002F9C9 File Offset: 0x0002DBC9
		public string MaterialCol { get; set; }

		/// <summary>
		/// 用量列
		/// </summary>
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0002F9D2 File Offset: 0x0002DBD2
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x0002F9DA File Offset: 0x0002DBDA
		public string QuantityCol { get; set; }

		// Token: 0x04000182 RID: 386
		[CompilerGenerated]
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000183 RID: 387
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000184 RID: 388
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000185 RID: 389
		[CompilerGenerated]
		private char <<EMPTY_NAME>>;

		// Token: 0x04000186 RID: 390
		[CompilerGenerated]
		private int[] <<EMPTY_NAME>>;

		// Token: 0x04000187 RID: 391
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000188 RID: 392
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;
	}
}
