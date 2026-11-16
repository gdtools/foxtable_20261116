using System;
using System.ComponentModel;
using System.Drawing.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.XLS
{
	// Token: 0x020004F9 RID: 1273
	[TypeConverter(typeof(OoO0o0oo__Oo))]
	[OoO0___o("ExcelReport")]
	internal class ReportProperty
	{
		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06005349 RID: 21321 RVA: 0x00255ECF File Offset: 0x002540CF
		// (set) Token: 0x0600534A RID: 21322 RVA: 0x00255ED7 File Offset: 0x002540D7
		[DisplayName("模板文件")]
		[Editor(typeof(O0_000oo), typeof(UITypeEditor))]
		[Category("属性")]
		[Ooo0___("Excel文件(*.xls;.xlsx)|*.xls;*.xlsx")]
		[O_Oo00Oo000O0(1.0)]
		public string Template
		{
			get
			{
				return this.OoOoo.o.;
			}
			set
			{
				this.OoOoo.o. = value;
				if (Operators.CompareString(this.O__0oO_OO__.0o., "", true) == 0)
				{
					this.O__0oO_OO__.0o. = value;
				}
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x0600534B RID: 21323 RVA: 0x00255EFA File Offset: 0x002540FA
		// (set) Token: 0x0600534C RID: 21324 RVA: 0x00255F02 File Offset: 0x00254102
		[DisplayName("目标文件")]
		[Category("属性")]
		[Ooo0___("Excel文件(*.xls;.xlsx)|*.xls;*.xlsx")]
		[Editor(typeof(OO0o_o_Oo__o), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(2.0)]
		public string FileName
		{
			get
			{
				return this.O__0oO_OO__.0o.;
			}
			set
			{
				this.O__0oO_OO__.0o. = value;
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x0600534D RID: 21325 RVA: 0x00255F0B File Offset: 0x0025410B
		// (set) Token: 0x0600534E RID: 21326 RVA: 0x00255F13 File Offset: 0x00254113
		[DisplayName("自由合并")]
		[Description("如果报表模板中设置了合并列，可以用此属性指定合并类型。")]
		[Category("属性")]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(4.0)]
		public bool MergeFree
		{
			get
			{
				return this.OoOoo.o.;
			}
			set
			{
				this.OoOoo.o. = value;
			}
		}

		// Token: 0x04002298 RID: 8856
		private string <<EMPTY_NAME>>;

		// Token: 0x04002299 RID: 8857
		private string <<EMPTY_NAME>>;

		// Token: 0x0400229A RID: 8858
		private bool <<EMPTY_NAME>>;
	}
}
