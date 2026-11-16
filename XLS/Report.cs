using System;
using System.Data;
using System.Diagnostics;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.XLS
{
	// Token: 0x020004F7 RID: 1271
	public class Report
	{
		// Token: 0x0600533D RID: 21309 RVA: 0x00255C50 File Offset: 0x00253E50
		public Report(DataRow A_0)
		{
			this.o0_.O_o. = new ReportProperty();
			this.o0_.O_o. = A_0;
			if (!A_0.IsNull("Property"))
			{
				o_O_o_oOoo__.OOOO_OO._oo.(this.o0_.O_o., Conversions.ToString(A_0["Property"]), '\v');
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x0600533E RID: 21310 RVA: 0x00255C9F File Offset: 0x00253E9F
		public string Name
		{
			get
			{
				return Conversions.ToString(this.o0_.O_o.["Name"]);
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x0600533F RID: 21311 RVA: 0x00255CB6 File Offset: 0x00253EB6
		public string TempLate
		{
			get
			{
				return this.o0_.O_o..Template;
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06005340 RID: 21312 RVA: 0x00255CC3 File Offset: 0x00253EC3
		public string FileName
		{
			get
			{
				return this.o0_.O_o..FileName;
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06005341 RID: 21313 RVA: 0x00255CD0 File Offset: 0x00253ED0
		public string TableName
		{
			get
			{
				return Conversions.ToString(this.o0_.O_o.["Table"]);
			}
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x00255CE8 File Offset: 0x00253EE8
		public void Build()
		{
			if (Operators.CompareString(this.TempLate, "", true) != 0 && c.OOOOO.o.().FileSystem.FileExists(ooO.OoO0o_o___.O.(this.TempLate)))
			{
				Book book = new Book(ooO.OoO0o_o___.O.(this.TempLate));
				book.MergeFree = this.o0_.O_o..MergeFree;
				if (Operators.CompareString(this.FileName, "", true) > 0)
				{
					string fileName = OO_00oOO.ProjectPath + "\\Reports\\" + this.FileName;
					if (!c.OOOOO.o.().FileSystem.DirectoryExists(OO_00oOO.ProjectPath + "\\Reports\\"))
					{
						c.OOOOO.o.().FileSystem.CreateDirectory(OO_00oOO.ProjectPath + "\\Reports\\");
					}
					if (book.Build(new int[0]) && book.Save(fileName))
					{
						new Process
						{
							StartInfo = 
							{
								FileName = fileName,
								WindowStyle = ProcessWindowStyle.Maximized
							}
						}.Start();
					}
				}
			}
		}

		// Token: 0x04002292 RID: 8850
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04002293 RID: 8851
		private ReportProperty <<EMPTY_NAME>>;
	}
}
