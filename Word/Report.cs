using System;
using System.ComponentModel;
using System.Data;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.Word
{
	// Token: 0x02000004 RID: 4
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Report
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002258 File Offset: 0x00000458
		public Report(DataRow A_0)
		{
			this.O0oOOO._OOO. = new ReportProperty();
			this.O0oOOO._OOO. = A_0;
			if (!A_0.IsNull("Property"))
			{
				o_O_o_oOoo__.OOOO_OO._oo.(this.O0oOOO._OOO., Conversions.ToString(A_0["Property"]), '\v');
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000022A7 File Offset: 0x000004A7
		public string Name
		{
			get
			{
				return Conversions.ToString(this.O0oOOO._OOO.["Name"]);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000022BE File Offset: 0x000004BE
		public string TempLate
		{
			get
			{
				return this.O0oOOO._OOO..Template;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000022CB File Offset: 0x000004CB
		public string FileName
		{
			get
			{
				return this.O0oOOO._OOO..FileName;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000022D8 File Offset: 0x000004D8
		public string TableName
		{
			get
			{
				return Conversions.ToString(this.O0oOOO._OOO.["Table"]);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000022EF File Offset: 0x000004EF
		public int RecordsOnEachPage
		{
			get
			{
				return this.O0oOOO._OOO..RecordsOnEachPage;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022FC File Offset: 0x000004FC
		public void Build()
		{
			if (Operators.CompareString(this.TempLate, "", true) != 0 && Operators.CompareString(this.FileName, "", true) != 0)
			{
				string text = OO_00oOO.ProjectPath + "Attachments\\" + this.TempLate;
				string a_ = OO_00oOO.ProjectPath + "\\Reports\\" + this.FileName;
				if (c.OOOOO.o.().FileSystem.FileExists(text))
				{
					Table a_2;
					if (OO_00oOO.CurrentTable != null && Operators.CompareString(OO_00oOO.CurrentTable.DataTable.Name, this.TableName, true) == 0)
					{
						a_2 = OO_00oOO.CurrentTable;
					}
					else
					{
						a_2 = OO_00oOO.Tables[this.TableName];
					}
					WordReport wordReport = new WordReport(a_2, text, a_);
					wordReport.RecordsOnEachPage = this.RecordsOnEachPage;
					if (!c.OOOOO.o.().FileSystem.DirectoryExists(OO_00oOO.ProjectPath + "\\Reports\\"))
					{
						c.OOOOO.o.().FileSystem.CreateDirectory(OO_00oOO.ProjectPath + "\\Reports\\");
					}
					wordReport.Build();
					wordReport.Show();
				}
			}
		}

		// Token: 0x04000004 RID: 4
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04000005 RID: 5
		private ReportProperty <<EMPTY_NAME>>;
	}
}
