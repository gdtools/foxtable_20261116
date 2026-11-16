using System;
using System.Runtime.CompilerServices;
using C1.Win.C1Command;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000092 RID: 146
	internal class OO0_O_0O : C1DockingTabPage
	{
		// Token: 0x060005A6 RID: 1446 RVA: 0x0002E468 File Offset: 0x0002C668
		[CompilerGenerated]
		internal virtual Table <<EMPTY_NAME>>()
		{
			return this.O_.o_O0O_o__.;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0002E470 File Offset: 0x0002C670
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Table A_0)
		{
			Table.oO00_O_O a_ = new Table.oO00_O_O(this.O_.o_O0O_o__.);
			Table o_.o_O0O_o__. = this.O_.o_O0O_o__.;
			if (o_.o_O0O_o__. != null)
			{
				o_.o_O0O_o__..NameChanged -= a_;
			}
			this.O_.o_O0O_o__. = A_0;
			o_.o_O0O_o__. = this.O_.o_O0O_o__.;
			if (o_.o_O0O_o__. != null)
			{
				o_.o_O0O_o__..NameChanged += a_;
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0002E4B3 File Offset: 0x0002C6B3
		public OO0_O_0O(Table A_0)
		{
			base.GotFocus += this.O_.o_O0O_o__.;
			base.Controls.Add(A_0.foxGrid);
			this.O_.o_O0O_o__.(A_0);
			this.O.O0o.();
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0002E4EB File Offset: 0x0002C6EB
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_.o_O0O_o__.().foxGrid.Focus();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0002E500 File Offset: 0x0002C700
		private void <<EMPTY_NAME>>()
		{
			base.Name = this.O_.o_O0O_o__.().Name;
			if (Operators.CompareString(OO_00oOO.DataTables[this.O_.o_O0O_o__.().View.o_o.O0ooOo.().TableName].Caption, "", true) > 0)
			{
				this.Text = OO_00oOO.DataTables[this.O_.o_O0O_o__.().View.o_o.O0ooOo.().TableName].Caption;
			}
			else
			{
				this.Text = this.O_.o_O0O_o__.().View.o_o.O0ooOo.().TableName;
			}
			string text = this.Text;
			for (O_0 o_ = this.O_.o_O0O_o__.().View.O0O_0_0__.0O.(); o_ != null; o_ = o_.O0O_0_0__.0O.())
			{
				if (Operators.CompareString(OO_00oOO.DataTables[o_.o_o.O0ooOo.().TableName].Caption, "", true) > 0)
				{
					text = OO_00oOO.DataTables[o_.o_o.O0ooOo.().TableName].Caption + "." + text;
				}
				else
				{
					text = o_.o_o.O0ooOo.().TableName + "." + text;
				}
			}
			base.CaptionText = text;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0002E629 File Offset: 0x0002C829
		private void <<EMPTY_NAME>>()
		{
			this.O.O0o.();
		}

		// Token: 0x0400016D RID: 365
		[CompilerGenerated]
		private Table <<EMPTY_NAME>>;
	}
}
