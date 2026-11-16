using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace Foxtable
{
	// Token: 0x02000087 RID: 135
	internal class OO__oo_0ooo0_ : C1NumericEdit
	{
		// Token: 0x060004EB RID: 1259 RVA: 0x000214E0 File Offset: 0x0001F6E0
		[CompilerGenerated]
		private virtual DropDownCalculator <<EMPTY_NAME>>()
		{
			return this.OO_o0_oO.0.;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000214E8 File Offset: 0x0001F6E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(DropDownCalculator A_0)
		{
			this.OO_o0_oO.0. = A_0;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000214F4 File Offset: 0x0001F6F4
		public OO__oo_0ooo0_()
		{
			base.DropDownOpened += this.oo.o_Oo.;
			base.KeyDown += this.oo.o_Oo.;
			this.OO_o0_oO.0.((DropDownCalculator)this.DropDownForm);
			base.VisualStyle = VisualStyle.System;
			base.EmptyAsNull = true;
			base.ErrorInfo.ShowErrorMessage = false;
			base.ImeMode = ImeMode.Close;
			base.InitialSelection = InitialSelectionEnum.SelectAll;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00021565 File Offset: 0x0001F765
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.DropDownForm.Owner = null;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00021574 File Offset: 0x0001F774
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Down)
			{
				if (base.Parent is O_oOooO_O && ((O_oOooO_O)base.Parent).FinishEditing())
				{
					SendKeys.Send("{DOWN}");
					return;
				}
			}
			else if (A_1.KeyCode == Keys.Up && base.Parent is O_oOooO_O && ((O_oOooO_O)base.Parent).FinishEditing())
			{
				SendKeys.Send("{UP}");
			}
		}

		// Token: 0x04000146 RID: 326
		[CompilerGenerated]
		private DropDownCalculator <<EMPTY_NAME>>;
	}
}
