using System;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000082 RID: 130
	internal class O0OooO0_0O : C1TextBox
	{
		// Token: 0x060004DD RID: 1245 RVA: 0x00020C98 File Offset: 0x0001EE98
		public O0OooO0_0O()
		{
			base.KeyDown += this.Ooo._0oO.;
			base.PreviewKeyDown += this.Ooo._0oO.;
			base.VisualStyle = VisualStyle.System;
			this.DataType = typeof(DateTime);
			base.FormatType = FormatTypeEnum.CustomFormat;
			base.CustomFormat = "HH:mm:ss";
			base.EmptyAsNull = true;
			this.DateTimeInput = false;
			base.MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			base.MaskInfo.EmptyAsNull = true;
			base.MaskInfo.EditMask = "00:00:00";
			base.ErrorInfo.ShowErrorMessage = false;
			base.ImeMode = ImeMode.Close;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00020D44 File Offset: 0x0001EF44
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

		// Token: 0x060004DF RID: 1247 RVA: 0x00020DFC File Offset: 0x0001EFFC
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
