using System;
using System.ComponentModel;
using System.Drawing.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.Word
{
	// Token: 0x02000006 RID: 6
	[OoO0___o("ExcelReport")]
	[TypeConverter(typeof(OoO0o0oo__Oo))]
	internal class ReportProperty
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000024E0 File Offset: 0x000006E0
		public ReportProperty()
		{
			this.O0oOOO._OOO. = 1;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000024EF File Offset: 0x000006EF
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000024F7 File Offset: 0x000006F7
		[Ooo0___("Word文件(*.doc;.docx)|*.doc;*.docx")]
		[O_Oo00Oo000O0(1.0)]
		[Editor(typeof(O0_000oo), typeof(UITypeEditor))]
		[Category("属性")]
		[DisplayName("模板文件")]
		public string Template
		{
			get
			{
				return this.O0oOOO._OOO.;
			}
			set
			{
				this.O0oOOO._OOO. = value;
				if (Operators.CompareString(this.o0.0o0O_., "", true) == 0)
				{
					this.o0.0o0O_. = value;
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000251A File Offset: 0x0000071A
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002522 File Offset: 0x00000722
		[Ooo0___("Word文件(*.doc;.docx)|*.doc;*.docx")]
		[Category("属性")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("目标文件")]
		[Editor(typeof(OO0o_o_Oo__o), typeof(UITypeEditor))]
		public string FileName
		{
			get
			{
				return this.o0.0o0O_.;
			}
			set
			{
				this.o0.0o0O_. = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000252B File Offset: 0x0000072B
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002533 File Offset: 0x00000733
		[DisplayName("每页记录数")]
		[O_Oo00Oo000O0(2.1)]
		[Category("属性")]
		[Description("指定每页打印多少条记录后换页，如果设为0，则自动换页。")]
		public int RecordsOnEachPage
		{
			get
			{
				return this.O0oOOO._OOO.;
			}
			set
			{
				this.O0oOOO._OOO. = value;
			}
		}

		// Token: 0x0400000A RID: 10
		private string <<EMPTY_NAME>>;

		// Token: 0x0400000B RID: 11
		private string <<EMPTY_NAME>>;

		// Token: 0x0400000C RID: 12
		private int <<EMPTY_NAME>>;
	}
}
