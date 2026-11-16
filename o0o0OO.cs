using System;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000083 RID: 131
	internal class o0o0OO : C1TextBox
	{
		// Token: 0x060004E0 RID: 1248 RVA: 0x00020E5C File Offset: 0x0001F05C
		public o0o0OO()
		{
			base.KeyDown += this.oo.o_Oo.;
			base.PreviewKeyDown += this.oo.o_Oo.;
			base.VisualStyle = VisualStyle.System;
			this.DataType = typeof(DateTime);
			base.FormatType = FormatTypeEnum.CustomFormat;
			base.CustomFormat = "HH:mm";
			base.EmptyAsNull = true;
			this.DateTimeInput = false;
			base.MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			base.MaskInfo.EmptyAsNull = true;
			base.MaskInfo.EditMask = "00:00";
			base.ErrorInfo.ShowErrorMessage = false;
			base.ImeMode = ImeMode.Close;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00020F08 File Offset: 0x0001F108
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
			else if (A_1.KeyCode == Keys.Up)
			{
				if (base.Parent is O_oOooO_O && ((O_oOooO_O)base.Parent).FinishEditing())
				{
					SendKeys.Send("{UP}");
					return;
				}
			}
			else if (A_1.KeyCode == Keys.Space && Operators.CompareString(this.Text, "", true) == 0)
			{
				base.Value = DateTime.Now;
				base.SelectionStart = this.Text.Length;
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00020FC0 File Offset: 0x0001F1C0
		private void <<EMPTY_NAME>>(object A_0, PreviewKeyDownEventArgs A_1)
		{
			DateTime dateTime;
			if ((A_1.KeyCode == Keys.Return || A_1.KeyCode == Keys.Tab) && Operators.CompareString(this.Text, "", true) > 0 && this.Text.Length < 10 && DateTime.TryParse(this.Text, out dateTime))
			{
				base.Value = dateTime;
			}
		}
	}
}
