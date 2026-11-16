using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000CD RID: 205
	internal class oooO0o000O
	{
		// Token: 0x06000926 RID: 2342 RVA: 0x0004BDD2 File Offset: 0x00049FD2
		[CompilerGenerated]
		internal DataSet <<EMPTY_NAME>>()
		{
			return this.oo___O0.O.;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0004BDDA File Offset: 0x00049FDA
		[CompilerGenerated]
		internal void <<EMPTY_NAME>>(DataSet A_0)
		{
			this.oo___O0.O. = A_0;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0004BDE3 File Offset: 0x00049FE3
		[CompilerGenerated]
		internal DataSet <<EMPTY_NAME>>()
		{
			return this.Ooo.0O.;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0004BDEB File Offset: 0x00049FEB
		[CompilerGenerated]
		internal void <<EMPTY_NAME>>(DataSet A_0)
		{
			this.Ooo.0O. = A_0;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0004BDF4 File Offset: 0x00049FF4
		[CompilerGenerated]
		internal TableCollection <<EMPTY_NAME>>()
		{
			return this.oo___O0.O.;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0004BDFC File Offset: 0x00049FFC
		[CompilerGenerated]
		internal void <<EMPTY_NAME>>(TableCollection A_0)
		{
			this.oo___O0.O. = A_0;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0004BE05 File Offset: 0x0004A005
		[CompilerGenerated]
		internal DataTableCollection <<EMPTY_NAME>>()
		{
			return this.oo___O0.O.;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0004BE0D File Offset: 0x0004A00D
		[CompilerGenerated]
		internal void <<EMPTY_NAME>>(DataTableCollection A_0)
		{
			this.oo___O0.O. = A_0;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0004BE16 File Offset: 0x0004A016
		[CompilerGenerated]
		internal Dictionary<string, O_0> <<EMPTY_NAME>>()
		{
			return this.oo___O0.O.;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0004BE1E File Offset: 0x0004A01E
		[CompilerGenerated]
		internal void <<EMPTY_NAME>>(Dictionary<string, O_0> A_0)
		{
			this.oo___O0.O. = A_0;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0004BE27 File Offset: 0x0004A027
		internal void <<EMPTY_NAME>>()
		{
			this.oo___O0.O.(O_O0OO.OoO.0OO__0ooo.());
			this.o.o_0O00o0_.(O_O0OO.OOOo.oo_OOOO_0.());
			this.oo___O0.O.(OO_00oOO.Tables);
			this.O0oo_0_.__0__.(OO_00oOO.DataTables);
			this.oo___O0.O.(O_O0OO.o__.O.());
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0004BE60 File Offset: 0x0004A060
		internal void <<EMPTY_NAME>>()
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				DataSet[] array = new DataSet[]
				{
					this.o.o_0O00o0_.(),
					this.O0oo_0_.__0__.()
				};
				IL_22:
				num2 = 3;
				foreach (DataSet dataSet in array)
				{
					IL_33:
					num2 = 4;
					if (dataSet != null)
					{
						IL_39:
						num2 = 6;
						if (dataSet != O_O0OO.OoO.0OO__0ooo.())
						{
							IL_44:
							num2 = 8;
							dataSet.Reset();
							IL_4D:
							num2 = 9;
							dataSet.Dispose();
						}
					}
					IL_57:
					num2 = 10;
				}
				IL_68:
				num2 = 11;
				this.oo___O0.O.(null);
				IL_72:
				num2 = 12;
				this.o.o_0O00o0_.(null);
				IL_7C:
				num2 = 13;
				if (this.O0oo_0_.__0__.() == null)
				{
					goto IL_14C;
				}
				IL_8A:
				num2 = 14;
				IEnumerator<DataTable> enumerator = this.O0oo_0_.__0__.().GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataTable dataTable = enumerator.Current;
					IL_A5:
					num2 = 15;
					if (dataTable.o_oO0O_.O0. != null)
					{
						IL_B1:
						num2 = 16;
						dataTable.o_oO0O_.O0.._Rows = null;
						IL_C1:
						num2 = 17;
						dataTable.o_oO0O_.O0. = null;
						IL_CC:
						num2 = 18;
						dataTable.o.O0O_0__OOo_..O_0__o.o_0o..Clear();
						IL_E0:
						num2 = 19;
						dataTable.o.O0O_0__OOo_..O_0__o.o_0o. = null;
						IL_F0:
						num2 = 20;
						dataTable.o.O0O_0__OOo_. = null;
						IL_FB:
						num2 = 21;
						dataTable._DataTable = null;
					}
					IL_106:
					num2 = 22;
				}
				IL_112:
				num2 = 23;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_120:
				num2 = 24;
				this.O0oo_0_.__0__.().OO0o00.0O_0o..Clear();
				IL_133:
				num2 = 25;
				this.O0oo_0_.__0__.().OO0o00.0O_0o. = null;
				IL_142:
				num2 = 26;
				this.O0oo_0_.__0__.(null);
				IL_14C:
				num2 = 27;
				if (this.O0oo_0_.__0__.() == null)
				{
					goto IL_1A1;
				}
				IL_157:
				num2 = 28;
				IEnumerator<Table> enumerator2 = this.O0oo_0_.__0__.().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Table table = enumerator2.Current;
					IL_172:
					num2 = 29;
					table.o.0ooOO_0__. = null;
					IL_17D:
					num2 = 30;
				}
				IL_189:
				num2 = 31;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_197:
				num2 = 32;
				this.oo___O0.O.(null);
				IL_1A1:
				num2 = 33;
				if (this.O0oo_0_.__0__.() == null)
				{
					goto IL_1C4;
				}
				IL_1AC:
				num2 = 34;
				this.O0oo_0_.__0__.().Clear();
				IL_1BA:
				num2 = 35;
				this.oo___O0.O.(null);
				IL_1C4:
				goto IL_2A6;
				IL_1C9:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_267:
				goto IL_29B;
				IL_269:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_279:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_269;
			}
			IL_29B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2A6:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x04000341 RID: 833
		[CompilerGenerated]
		private DataSet <<EMPTY_NAME>>;

		// Token: 0x04000342 RID: 834
		[CompilerGenerated]
		private DataSet <<EMPTY_NAME>>;

		// Token: 0x04000343 RID: 835
		[CompilerGenerated]
		private TableCollection <<EMPTY_NAME>>;

		// Token: 0x04000344 RID: 836
		[CompilerGenerated]
		private DataTableCollection <<EMPTY_NAME>>;

		// Token: 0x04000345 RID: 837
		[CompilerGenerated]
		private Dictionary<string, O_0> <<EMPTY_NAME>>;
	}
}
