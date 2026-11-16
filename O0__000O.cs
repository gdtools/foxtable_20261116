using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020004D7 RID: 1239
	internal class O0__000O : Oo0__O__O_0__
	{
		// Token: 0x06005181 RID: 20865 RVA: 0x00244C68 File Offset: 0x00242E68
		public O0__000O(Table A_0, string A_1)
		{
			this.Oo.__O0. = new List<DataRow>();
			this.Oo.__O0. = new List<object>();
			this.Oo.__O0. = A_0;
			this.Oo.__O0. = A_1;
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x00244C94 File Offset: 0x00242E94
		internal void <<EMPTY_NAME>>(DataRow A_0)
		{
			this.Oo.__O0..Add(A_0);
			this.Oo.__O0..Add(RuntimeHelpers.GetObjectValue(A_0[this.Oo.__O0.]));
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x00244CBE File Offset: 0x00242EBE
		internal void <<EMPTY_NAME>>()
		{
			this.Oo.__O0..RemoveAt(this.Oo.__O0..Count - 1);
			this.Oo.__O0..RemoveAt(this.Oo.__O0..Count - 1);
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x00244CF0 File Offset: 0x00242EF0
		internal int <<EMPTY_NAME>>()
		{
			return this.Oo.__O0..Count;
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x00244D00 File Offset: 0x00242F00
		public void <<EMPTY_NAME>>()
		{
			int num = this.Oo.__O0..Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = this.Oo.__O0.[i];
				object objectValue = RuntimeHelpers.GetObjectValue(dataRow[this.Oo.__O0.]);
				if (Operators.CompareString(objectValue.ToString(), this.Oo.__O0.[i].ToString(), true) != 0)
				{
					dataRow[this.Oo.__O0.] = RuntimeHelpers.GetObjectValue(this.Oo.__O0.[i]);
					this.Oo.__O0.[i] = RuntimeHelpers.GetObjectValue(objectValue);
					int a_ = this.Oo.__O0..View.o_o.O0ooOo.(dataRow);
					MethodInfo o0O00o_.0Oo. = this.Oo.__O0..DataTable.O0O00o_.0Oo.;
					if (o0O00o_.0Oo. != null && OO_00oOO.SystemReady)
					{
						RowColEventArgs rowColEventArgs = new RowColEventArgs(this.Oo.__O0., new Row(this.Oo.__O0., this.Oo.__O0..View.O0O_0_0__.0O.(a_)), this.Oo.__O0..Cols[this.Oo.__O0.], null);
						try
						{
							o0O00o_.0Oo..Invoke(null, new object[]
							{
								rowColEventArgs
							});
						}
						catch (Exception a_2)
						{
							ooO.oOo0Oo.o.(a_2, "表，" + this.Oo.__O0..DataTable.Name + "，AfterEdit");
						}
					}
					Oo00.o0_o._O_.(this.Oo.__O0.[i]);
				}
			}
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x00244E80 File Offset: 0x00243080
		public void <<EMPTY_NAME>>()
		{
			this.Oo.__O0.();
		}

		// Token: 0x0400217C RID: 8572
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400217D RID: 8573
		private string <<EMPTY_NAME>>;

		// Token: 0x0400217E RID: 8574
		private List<DataRow> <<EMPTY_NAME>>;

		// Token: 0x0400217F RID: 8575
		private List<object> <<EMPTY_NAME>>;
	}
}
