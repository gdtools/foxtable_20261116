using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003E1 RID: 993
	internal class O_0oOoOo : C1DropDownControl, O000O
	{
		// Token: 0x060040BF RID: 16575 RVA: 0x001D55B4 File Offset: 0x001D37B4
		internal O_0oOoOo()
		{
			base.DropDownClosed += this.O_o_.O.;
			base.KeyDown += this.O.o0O_.;
			base.Enter += this.o000.O0_O_o.;
			base.Leave += this.O_____0o0.__00.;
			base.PreviewKeyDown += this.O.o0O_.;
			base.GotFocus += this.o0ooO_O0_.O_.;
			base.Validated += this.O.o_O.;
			base.DropDownOpened += this.O_.o0.;
			base.KeyPress += this.O.o0O_.;
			base.MouseEnter += this.O.o0O_.;
			this.oO._0o_O__. = BooleanEnum.Default;
			this.oO._0o_O__. = new Size(1, 1);
			base.VisualStyle = VisualStyle.Custom;
			Main.OO_O.o..o.O000oo.(new object[]
			{
				this
			});
			this.DataType = typeof(DateTime);
			base.DisplayFormat.FormatType = FormatTypeEnum.CustomFormat;
			base.DisplayFormat.CustomFormat = "yyyy-MM-dd";
			base.EditFormat.FormatType = FormatTypeEnum.CustomFormat;
			base.EditFormat.CustomFormat = base.DisplayFormat.CustomFormat;
			base.VerticalAlign = VerticalAlignEnum.Middle;
			base.EmptyAsNull = true;
			this.DateTimeInput = false;
			base.MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			base.MaskInfo.AutoTabWhenFilled = true;
			base.MaskInfo.EmptyAsNull = true;
			base.Padding = new Padding(1, 2, 1, 1);
			this.O0O.O0.("0000-00-00");
			base.ErrorInfo.ShowErrorMessage = false;
			this.ShowUpDownButtons = false;
			base.ImeMode = ImeMode.Close;
			base.AutoSize = false;
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x001D576D File Offset: 0x001D396D
		public BooleanEnum <<EMPTY_NAME>>()
		{
			return this.oO._0o_O__.;
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x001D5775 File Offset: 0x001D3975
		public void <<EMPTY_NAME>>(BooleanEnum A_0)
		{
			this.oO._0o_O__. = A_0;
			ooO_0O.o_O0.O_.(this, this.O0O.O0.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x001D5796 File Offset: 0x001D3996
		public bool <<EMPTY_NAME>>()
		{
			return this.O.O0o0.;
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x001D579E File Offset: 0x001D399E
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.O.O0o0. = A_0;
			if (this.oO._0o_O__. != null)
			{
				this.oO._0o_O__..o.O_OO.().ShowWeekNumbers = true;
			}
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x001D57C0 File Offset: 0x001D39C0
		public Size <<EMPTY_NAME>>()
		{
			return this.oO._0o_O__.;
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x001D57C8 File Offset: 0x001D39C8
		public void <<EMPTY_NAME>>(Size A_0)
		{
			this.oO._0o_O__. = A_0;
			if (this.oO._0o_O__. != null)
			{
				this.oO._0o_O__..o.O_OO.().CalendarDimensions = A_0;
			}
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x001D57EA File Offset: 0x001D39EA
		private void <<EMPTY_NAME>>(object A_0, DropDownClosedEventArgs A_1)
		{
			base.UpdateValueWithCurrentText();
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x001D57F4 File Offset: 0x001D39F4
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Space && Operators.CompareString(this.Text, "", true) == 0 && !base.ReadOnly)
			{
				this.Value = Strings.Format(DateTime.Now, base.CustomFormat);
				base.SelectionStart = this.Text.Length;
			}
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x001D5852 File Offset: 0x001D3A52
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO_0O.o_O0.O_.(this, this.O0O.O0.());
			base.ReadOnly = base.ReadOnly;
			base.MaskInfo.EditMask = this.O0O.O0.();
			if (base.ReadOnly)
			{
				base.DisplayFormat.FormatType = FormatTypeEnum.CustomFormat;
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x001D5894 File Offset: 0x001D3A94
		// (set) Token: 0x060040CA RID: 16586 RVA: 0x001D58C6 File Offset: 0x001D3AC6
		public new object Value
		{
			get
			{
				object result;
				if (!base.UpdateValueWithCurrentText())
				{
					result = null;
				}
				else if (base.Value == DBNull.Value)
				{
					result = null;
				}
				else
				{
					result = base.Value;
				}
				return result;
			}
			set
			{
				base.Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x001D58D4 File Offset: 0x001D3AD4
		public void <<EMPTY_NAME>>()
		{
			ooO_0O.o_O0.O_.(this, this.O0O.O0.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x001D58EE File Offset: 0x001D3AEE
		internal string <<EMPTY_NAME>>()
		{
			return this.oO._0o_O__.;
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x001D58F6 File Offset: 0x001D3AF6
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.oO._0o_O__. = A_0;
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x001D58FF File Offset: 0x001D3AFF
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.MaskInfo.EditMask = "";
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x001D5911 File Offset: 0x001D3B11
		public DateTimeFormatEnum <<EMPTY_NAME>>()
		{
			return this.oO._0o_O__.;
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x001D591C File Offset: 0x001D3B1C
		public void <<EMPTY_NAME>>(DateTimeFormatEnum A_0)
		{
			this.oO._0o_O__. = A_0;
			switch (A_0)
			{
			case DateTimeFormatEnum.Date:
				base.DisplayFormat.CustomFormat = "yyyy-MM-dd";
				base.EditFormat.CustomFormat = "yyyy-MM-dd";
				this.O0O.O0.("0000-00-00");
				return;
			case DateTimeFormatEnum.Time:
				base.DisplayFormat.CustomFormat = "HH:mm";
				base.EditFormat.CustomFormat = "HH:mm";
				this.O0O.O0.("00:00");
				return;
			case DateTimeFormatEnum.LongTime:
				base.DisplayFormat.CustomFormat = "HH:mm:ss";
				base.EditFormat.CustomFormat = "HH:mm:ss";
				this.O0O.O0.("00:00:00");
				return;
			case DateTimeFormatEnum.DateTime:
				base.DisplayFormat.CustomFormat = "yyyy-MM-dd HH:mm";
				base.EditFormat.CustomFormat = "yyyy-MM-dd HH:mm";
				this.O0O.O0.("0000-00-00 00:00");
				return;
			case DateTimeFormatEnum.DateLongTime:
				base.DisplayFormat.CustomFormat = "yyyy-MM-dd HH:mm:ss";
				base.EditFormat.CustomFormat = "yyyy-MM-dd HH:mm:ss";
				this.O0O.O0.("0000-00-00 00:00:00");
				return;
			default:
				return;
			}
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x001D5A28 File Offset: 0x001D3C28
		private void <<EMPTY_NAME>>(object A_0, PreviewKeyDownEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Return || A_1.KeyCode == Keys.Tab)
			{
				DateTime dateTime;
				if (Operators.CompareString(this.Text, "", true) > 0 && this.Text.Length < 10 && DateTime.TryParse(this.Text, out dateTime))
				{
					this.Value = dateTime;
					return;
				}
			}
			else if (this.O0O.O0.() == DateTimeFormatEnum.Date)
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
								this.Value = dateTime2;
								SendKeys.Send("{TAB}");
								return;
							}
						}
						else if (array2[2].Length == 2)
						{
							SendKeys.Send("{TAB}");
						}
					}
				}
			}
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x001D5BE4 File Offset: 0x001D3DE4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.DataBindings.Count > 0 && base.DataBindings[0].BindingManagerBase.Count == 0)
			{
				base.ReadOnly = true;
				return;
			}
			ooO_0O.o_O0.O_.(this, this.O0O.O0.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x001D5C38 File Offset: 0x001D3E38
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string a_ = "DataFormat_" + Conversions.ToString(base.Tag);
			if (oOO0oo_o0.o.O0o000_.(this, a_))
			{
				base.DisplayFormat.FormatType = FormatTypeEnum.UseEvent;
				return;
			}
			if (Operators.CompareString(base.DisplayFormat.CustomFormat, "", true) > 0)
			{
				base.DisplayFormat.FormatType = FormatTypeEnum.CustomFormat;
				return;
			}
			base.DisplayFormat.FormatType = FormatTypeEnum.DefaultFormat;
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x001D5CA4 File Offset: 0x001D3EA4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oO._0o_O__..ClientSize = this.oO._0o_O__..Controls[0].ClientSize;
			if (this.Value == null)
			{
				this.oO._0o_O__..o.O_OO.().SetDate(DateTime.Today);
			}
			else
			{
				this.oO._0o_O__..o.O_OO.().SetDate(Conversions.ToDate(this.Value));
			}
			this.DropDownForm.Owner = null;
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x001D5D18 File Offset: 0x001D3F18
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (base.ReadOnly && ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back))
			{
				base.FindForm().SelectNextControl(this, true, false, true, true);
				base.Focus();
				return;
			}
			base.OnKeyDown(e);
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x001D5D74 File Offset: 0x001D3F74
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			if (base.ReadOnly)
			{
				A_1.Handled = true;
				A_1.KeyChar = '\0';
			}
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x001D5D8C File Offset: 0x001D3F8C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oO._0o_O__. == null)
			{
				this.oO._0o_O__. = new oOo0o0__0();
				this.DropDownForm = this.oO._0o_O__.;
				Main.OO_O.o..Oo.oOo_o0Oo0.(Main.OO_O.o..o0_o_o_0.0O.(this), new object[]
				{
					this.oO._0o_O__..o.O_OO.()
				});
				this.oO._0o_O__..BackColor = this.oO._0o_O__..o.O_OO.().TitleBackColor;
				this.oO._0o_O__..o.O_OO.().ShowWeekNumbers = this.O0O.O0.();
				this.oO._0o_O__..o.O_OO.().CalendarDimensions = this.O.o0O_.();
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x001D5E2B File Offset: 0x001D402B
		// (set) Token: 0x060040D9 RID: 16601 RVA: 0x001D5E33 File Offset: 0x001D4033
		public object Value2
		{
			get
			{
				return this.Value;
			}
			set
			{
				this.Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x001D5E41 File Offset: 0x001D4041
		public bool <<EMPTY_NAME>>()
		{
			return this.oo0_O_Ooo._.;
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x001D5E49 File Offset: 0x001D4049
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.oo0_O_Ooo._. = A_0;
		}

		// Token: 0x04001A27 RID: 6695
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001A28 RID: 6696
		private string <<EMPTY_NAME>>;

		// Token: 0x04001A29 RID: 6697
		private DateTimeFormatEnum <<EMPTY_NAME>>;

		// Token: 0x04001A2A RID: 6698
		internal oOo0o0__0 <<EMPTY_NAME>>;

		// Token: 0x04001A2B RID: 6699
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001A2C RID: 6700
		private Size <<EMPTY_NAME>>;

		// Token: 0x04001A2D RID: 6701
		private bool <<EMPTY_NAME>>;
	}
}
