using System;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x020004D6 RID: 1238
	internal class o0o0o00 : Oo0__O__O_0__
	{
		// Token: 0x0600517E RID: 20862 RVA: 0x00244A98 File Offset: 0x00242C98
		public o0o0o00(Table A_0, DataRow A_1, string A_2)
		{
			this.o.0000OOo_. = A_0;
			this.o.0000OOo_. = A_1;
			this.o.0000OOo_. = A_2;
			this.o.0000OOo_. = RuntimeHelpers.GetObjectValue(A_1[A_2]);
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x00244AC8 File Offset: 0x00242CC8
		internal void <<EMPTY_NAME>>()
		{
			object objectValue = RuntimeHelpers.GetObjectValue(this.o.0000OOo_.[this.o.0000OOo_.]);
			this.o.0000OOo_..foxGrid.Col = this.o.0000OOo_..foxGrid.Cols.IndexOf(this.o.0000OOo_.);
			if (string.Compare(this.o.0000OOo_..ToString(), objectValue.ToString(), false) != 0)
			{
				this.o.0000OOo_.[this.o.0000OOo_.] = RuntimeHelpers.GetObjectValue(this.o.0000OOo_.);
				if (this.o.0000OOo_..View.o_o.O0ooOo.().Row != this.o.0000OOo_.)
				{
					this.o.0000OOo_..View.Position = this.o.0000OOo_..View.o_o.O0ooOo.(this.o.0000OOo_.);
				}
				MethodInfo o0O00o_.0Oo. = this.o.0000OOo_..DataTable.O0O00o_.0Oo.;
				if (o0O00o_.0Oo. != null && OO_00oOO.SystemReady)
				{
					RowColEventArgs rowColEventArgs = new RowColEventArgs(this.o.0000OOo_., new Row(this.o.0000OOo_., this.o.0000OOo_..View.o_o.O0ooOo.()), this.o.0000OOo_..Cols[this.o.0000OOo_.], null);
					try
					{
						o0O00o_.0Oo..Invoke(null, new object[]
						{
							rowColEventArgs
						});
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "表，" + this.o.0000OOo_..DataTable.Name + "，AfterEdit");
					}
				}
			}
			Oo00.o0_o._O_.(this.o.0000OOo_.);
			this.o.0000OOo_. = RuntimeHelpers.GetObjectValue(objectValue);
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x00244C60 File Offset: 0x00242E60
		public void <<EMPTY_NAME>>()
		{
			this.o.0000OOo_.();
		}

		// Token: 0x04002178 RID: 8568
		private Table <<EMPTY_NAME>>;

		// Token: 0x04002179 RID: 8569
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x0400217A RID: 8570
		private string <<EMPTY_NAME>>;

		// Token: 0x0400217B RID: 8571
		private object <<EMPTY_NAME>>;
	}
}
