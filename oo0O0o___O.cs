using System;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000084 RID: 132
	internal class oo0O0o___O : C1TextBox
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x00021020 File Offset: 0x0001F220
		public oo0O0o___O()
		{
			base.KeyDown += this.oo.o_Oo.;
			base.PreviewKeyDown += this.oo.o_Oo.;
			base.VisualStyle = VisualStyle.System;
			this.DataType = typeof(DateTime);
			base.FormatType = FormatTypeEnum.CustomFormat;
			base.CustomFormat = "yyyy-MM-dd";
			base.EmptyAsNull = true;
			this.DateTimeInput = false;
			base.MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			base.MaskInfo.EmptyAsNull = true;
			base.MaskInfo.EditMask = "0000-00-00";
			base.ErrorInfo.ShowErrorMessage = false;
			base.ImeMode = ImeMode.Close;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000210CC File Offset: 0x0001F2CC
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
				base.Value = DateTime.Today;
				base.SelectionStart = this.Text.Length;
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00021184 File Offset: 0x0001F384
		private void <<EMPTY_NAME>>(object A_0, PreviewKeyDownEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Return || A_1.KeyCode == Keys.Tab)
			{
				DateTime dateTime;
				if (Operators.CompareString(this.Text, "", true) > 0 && this.Text.Length < 10 && DateTime.TryParse(this.Text, out dateTime))
				{
					base.Value = dateTime;
					return;
				}
			}
			else
			{
				if (this.Text.Length == 5 && A_1.KeyCode >= Keys.D2 && A_1.KeyCode <= Keys.D9 && base.SelectionStart == 5)
				{
					this.SelectedText = "0";
					return;
				}
				if (this.Text.Length == 6 && base.SelectionStart == 6 && A_1.KeyCode == Keys.OemMinus)
				{
					string[] array = this.Text.Split(new char[]
					{
						'-'
					});
					SendKeys.Send("{BS}");
					SendKeys.Send("0");
					SendKeys.Send(array[1]);
					return;
				}
				if (this.Text.Length == 8 && A_1.KeyCode >= Keys.D4 && A_1.KeyCode <= Keys.D9 && base.SelectionStart == 8)
				{
					this.SelectedText = "0";
					return;
				}
				if (A_1.KeyCode == Keys.Right && Operators.CompareString(this.Text, "", true) > 0)
				{
					string[] array2 = this.Text.Split(new char[]
					{
						'-'
					});
					if (array2.Length == 3)
					{
						if (array2[2].Length >= 1)
						{
							DateTime dateTime2;
							if (DateTime.TryParse(this.Text, out dateTime2))
							{
								base.Value = dateTime2;
								if (array2[2].Length == 1)
								{
									SendKeys.Send("{TAB}");
									return;
								}
							}
						}
						else
						{
							int length = array2[2].Length;
						}
					}
				}
			}
		}
	}
}
