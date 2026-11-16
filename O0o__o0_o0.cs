using System;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace Foxtable
{
	// Token: 0x02000085 RID: 133
	internal class O0o__o0_o0 : C1TextBox
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x00021334 File Offset: 0x0001F534
		public O0o__o0_o0()
		{
			base.KeyPress += this.oo.o_Oo.;
			base.VisualStyle = VisualStyle.System;
			base.EmptyAsNull = true;
			base.MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			base.ErrorInfo.ShowErrorMessage = false;
			this.Multiline = true;
			base.InitialSelection = InitialSelectionEnum.SelectAll;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00021390 File Offset: 0x0001F590
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			if (A_1.KeyChar == '。' && (this.DataType == typeof(double) || this.DataType == typeof(float) || this.DataType == typeof(decimal)))
			{
				A_1.KeyChar = '.';
			}
		}
	}
}
