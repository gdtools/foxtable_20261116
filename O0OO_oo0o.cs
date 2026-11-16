using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200007C RID: 124
	internal class O0OO_oo0o : C1DateEdit
	{
		// Token: 0x060004C4 RID: 1220 RVA: 0x00020677 File Offset: 0x0001E877
		[CompilerGenerated]
		private virtual DropDownCalendar <<EMPTY_NAME>>()
		{
			return this.OOo0_._0_0o.;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0002067F File Offset: 0x0001E87F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(DropDownCalendar A_0)
		{
			this.OOo0_._0_0o. = A_0;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00020688 File Offset: 0x0001E888
		public O0OO_oo0o()
		{
			base.DropDownOpened += this.OOo0_._0_0o.;
			base.KeyDown += this.OOo0_._0_0o.;
			base.PreviewKeyDown += this.OOo0_._0_0o.;
			this.OOo0_._0_0o.((DropDownCalendar)this.DropDownForm);
			base.VisualStyle = VisualStyle.System;
			base.FormatType = FormatTypeEnum.CustomFormat;
			base.CustomFormat = "yyyy-MM-dd";
			base.EmptyAsNull = true;
			this.DateTimeInput = false;
			base.MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			base.MaskInfo.EmptyAsNull = true;
			base.MaskInfo.EditMask = "0000-00-00";
			base.ErrorInfo.ShowErrorMessage = false;
			this.ShowUpDownButtons = false;
			base.ImeMode = ImeMode.Close;
			base.Calendar.TodayText = "今日";
			base.Calendar.ClearText = "清除";
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0002076C File Offset: 0x0001E96C
		public bool <<EMPTY_NAME>>()
		{
			return base.Calendar.ShowWeekNumbers;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00020779 File Offset: 0x0001E979
		public void <<EMPTY_NAME>>(bool A_0)
		{
			base.Calendar.ShowWeekNumbers = A_0;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00020787 File Offset: 0x0001E987
		public Size <<EMPTY_NAME>>()
		{
			return base.Calendar.CalendarDimensions;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00020794 File Offset: 0x0001E994
		public void <<EMPTY_NAME>>(Size A_0)
		{
			base.Calendar.CalendarDimensions = A_0;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000207A2 File Offset: 0x0001E9A2
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.DropDownForm.Owner = null;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000207B0 File Offset: 0x0001E9B0
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
			else if (A_1.KeyCode == Keys.Space && Operators.CompareString(base.Text, "", true) == 0)
			{
				base.Value = Strings.Format(DateTime.Now, base.CustomFormat);
				base.SelectionStart = base.Text.Length;
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00020874 File Offset: 0x0001EA74
		private void <<EMPTY_NAME>>(object A_0, PreviewKeyDownEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Return || A_1.KeyCode == Keys.Tab)
			{
				DateTime dateTime;
				if (Operators.CompareString(base.Text, "", true) > 0 && base.Text.Length < 10 && DateTime.TryParse(base.Text, out dateTime))
				{
					base.Value = dateTime;
					return;
				}
			}
			else
			{
				if (base.Text.Length == 5 && A_1.KeyCode >= Keys.D2 && A_1.KeyCode <= Keys.D9 && base.SelectionStart == 5)
				{
					this.SelectedText = "0";
					return;
				}
				if (base.Text.Length == 6 && base.SelectionStart == 6 && A_1.KeyCode == Keys.OemMinus)
				{
					string[] array = base.Text.Split(new char[]
					{
						'-'
					});
					SendKeys.Send("{BS}");
					SendKeys.Send("0");
					SendKeys.Send(array[1]);
					return;
				}
				if (base.Text.Length == 8 && A_1.KeyCode >= Keys.D4 && A_1.KeyCode <= Keys.D9 && base.SelectionStart == 8)
				{
					this.SelectedText = "0";
					return;
				}
				if (A_1.KeyCode == Keys.Right && Operators.CompareString(base.Text, "", true) > 0)
				{
					string[] array2 = base.Text.Split(new char[]
					{
						'-'
					});
					if (array2.Length == 3)
					{
						if (array2[2].Length >= 1)
						{
							DateTime dateTime2;
							if (DateTime.TryParse(base.Text, out dateTime2))
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

		// Token: 0x04000143 RID: 323
		[CompilerGenerated]
		private DropDownCalendar <<EMPTY_NAME>>;
	}
}
