using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000272 RID: 626
	internal class OooO00O : C1DropDownControl, O000O
	{
		// Token: 0x06001E4E RID: 7758 RVA: 0x000D042C File Offset: 0x000CE62C
		internal OooO00O()
		{
			base.DropDownClosed += this.o.oO00_.;
			base.DropDownOpened += this.O0o____O_oO0.0.;
			base.DropDownOpening += this.Oo0_.oO.;
			base.Enter += this.O_oO.0__00.;
			base.GotFocus += this.O.0oo0_.;
			base.KeyDown += this.o.oooOOooo.;
			base.KeyPress += this.o.oooOOooo.;
			base.Validated += this.o.oooOOooo.;
			this.O__00_Oo0.00__. = BooleanEnum.Default;
			this.O__00_Oo0.00__. = true;
			base.VisualStyle = VisualStyle.Custom;
			Main.OO_O.o..o.O000oo.(new object[]
			{
				this
			});
			base.EmptyAsNull = true;
			base.MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			base.MaskInfo.AutoTabWhenFilled = true;
			base.MaskInfo.EmptyAsNull = true;
			base.ErrorInfo.ShowErrorMessage = false;
			base.AutoSize = false;
			base.VerticalAlign = VerticalAlignEnum.Middle;
			base.Padding = new Padding(1, 2, 1, 1);
			this.DateTimeInput = false;
			this.NumericInput = false;
			base.ExitOnLeftRightKey = ExitOnLeftRightKey.Both;
			base.ExitOnLastChar = true;
			this.ShowUpDownButtons = false;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000D056F File Offset: 0x000CE76F
		public BooleanEnum <<EMPTY_NAME>>()
		{
			return this.O__00_Oo0.00__.;
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000D0577 File Offset: 0x000CE777
		public void <<EMPTY_NAME>>(BooleanEnum A_0)
		{
			this.O__00_Oo0.00__. = A_0;
			ooO_0O.o_O0.O_.(this, this.OO.o.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x000D0598 File Offset: 0x000CE798
		public bool <<EMPTY_NAME>>()
		{
			return this.O__00_Oo0.00__.;
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x000D05A0 File Offset: 0x000CE7A0
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.O__00_Oo0.00__. = A_0;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x000D05A9 File Offset: 0x000CE7A9
		public bool <<EMPTY_NAME>>()
		{
			return this.OO.0O00.;
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000D05B1 File Offset: 0x000CE7B1
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.OO.0O00. = A_0;
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x000D05BC File Offset: 0x000CE7BC
		private void <<EMPTY_NAME>>(object A_0, DropDownClosedEventArgs A_1)
		{
			Foxtable.WinForm.Form form = OO_00oOO.Forms[this.o.oooOOooo.()];
			if (form.Pane.ActiveControl != null && form.Pane.ActiveControl is C1TextBox)
			{
				((C1TextBox)form.Pane.ActiveControl).UpdateValueWithCurrentText();
			}
			form.Pane.Enabled = false;
			if (this.O_oO.0__00.())
			{
				this.DropDownForm.Controls.Clear();
			}
			DropDownClosedEventArgs dropDownClosedEventArgs = new DropDownClosedEventArgs(form, A_1.Selected);
			string a_ = "DropDownClosed_" + Conversions.ToString(form.O_o_.0o0__o0O.["Key"]);
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms[this.o.oooOOooo.()].O_0.O00o_00_O., a_, new object[]
			{
				dropDownClosedEventArgs
			}, true, base.Name, false);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x000D0690 File Offset: 0x000CE890
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Foxtable.WinForm.Form form = OO_00oOO.Forms[this.o.oooOOooo.()];
			FormEventArgs formEventArgs = new FormEventArgs(form);
			string a_ = "DropDownOpened_" + Conversions.ToString(form.O_o_.0o0__o0O.["Key"]);
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms[this.o.oooOOooo.()].O_0.O00o_00_O., a_, new object[]
			{
				formEventArgs
			}, true, base.Name, false);
			if (this.DropDownForm != null)
			{
				this.DropDownForm.Owner = null;
			}
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000D0718 File Offset: 0x000CE918
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.DropDownForm.Controls.Count > 0 && Operators.CompareString(this.o.oooOOooo.(), this.OO.0O00., true) != 0)
			{
				this.DropDownForm.Controls.Clear();
			}
			if (this.DropDownForm.Controls.Count == 0)
			{
				Foxtable.WinForm.Form form = OO_00oOO.Forms[this.o.oooOOooo.()];
				if (form.Pane == null || form.Pane.IsDisposed)
				{
					form.o.0_o00O.();
				}
				else if (form.Pane.FindForm() != this.DropDownForm)
				{
					form.Close();
					form.o.0_o00O.();
				}
				form.Pane.ooOo.o_. = this;
				form.Pane.ooOo.o_. = null;
				form.Pane.O00O00o_oOo.o_. = null;
				if (base.Parent is O_oOooO_O)
				{
					O_oOooO_O o_oOooO_O = (O_oOooO_O)base.Parent;
					form.Pane.ooOo.o_. = o_oOooO_O.o.0O_O0o_.;
					form.Pane.O00O00o_oOo.o_. = o_oOooO_O.o.0O_O0o_..Cols[o_oOooO_O.Cols[o_oOooO_O.Col].Name];
				}
				if (base.Parent is OooOo0___oO)
				{
					OooOo0___oO oooOo0___oO = (OooOo0___oO)base.Parent;
					form.Pane.ooOo.o_. = oooOo0___oO.O.OOoo_o0.;
					string text = oooOo0___oO.Rows[oooOo0___oO.Row].UserData.ToString();
					if (oooOo0___oO.O.OOoo_o0..Cols.Contains(text))
					{
						form.Pane.O00O00o_oOo.o_. = oooOo0___oO.O.OOoo_o0..Cols[text];
					}
				}
				this.DropDownForm.Size = form.Pane.Size;
				this.DropDownForm.Controls.Add(form.Pane);
				form.Pane.Dock = DockStyle.Fill;
				this.OO.0O00. = this.o.oooOOooo.();
				FormEventArgs formEventArgs = new FormEventArgs(OO_00oOO.Forms[this.o.oooOOooo.()]);
				string a_ = "AfterLoad_" + Conversions.ToString(form.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms[this.o.oooOOooo.()].O_0.O00o_00_O., a_, new object[]
				{
					formEventArgs
				}, true, base.Name, false);
			}
			Foxtable.WinForm.Form form2 = OO_00oOO.Forms[this.o.oooOOooo.()];
			form2.Pane.Enabled = true;
			FormEventArgs formEventArgs2 = new FormEventArgs(form2);
			string a_2 = "DropDownOpening_" + Conversions.ToString(form2.O_o_.0o0__o0O.["Key"]);
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms[this.o.oooOOooo.()].O_0.O00o_00_O., a_2, new object[]
			{
				formEventArgs2
			}, true, base.Name, false);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x000D09E0 File Offset: 0x000CEBE0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO_0O.o_O0.O_.(this, this.OO.o.());
			base.ReadOnly = base.ReadOnly;
			if (this.DropDownForm != null && this.DropDownForm.IsDisposed)
			{
				this.DropDownForm = null;
				this.OO.o.(this.o.oooOOooo.());
			}
			if (base.ReadOnly)
			{
				if (Operators.CompareString(base.DisplayFormat.CustomFormat, "", true) > 0 && this.DataType == typeof(DateTime))
				{
					base.DisplayFormat.FormatType = FormatTypeEnum.CustomFormat;
					return;
				}
				base.DisplayFormat.FormatType = FormatTypeEnum.DefaultFormat;
				return;
			}
			else
			{
				if (Operators.CompareString(base.DisplayFormat.CustomFormat, "", true) > 0 && this.DataType == typeof(DateTime))
				{
					base.EditFormat.FormatType = FormatTypeEnum.CustomFormat;
					base.EditFormat.CustomFormat = base.DisplayFormat.CustomFormat;
					return;
				}
				base.EditFormat.FormatType = FormatTypeEnum.DefaultFormat;
				base.EditFormat.CustomFormat = "";
				return;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x000D0AE4 File Offset: 0x000CECE4
		// (set) Token: 0x06001E5A RID: 7770 RVA: 0x000D0B0A File Offset: 0x000CED0A
		public new object Value
		{
			get
			{
				object result;
				if (base.Value == DBNull.Value)
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

		// Token: 0x06001E5B RID: 7771 RVA: 0x000D0B18 File Offset: 0x000CED18
		public void <<EMPTY_NAME>>()
		{
			ooO_0O.o_O0.O_.(this, this.OO.o.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000D0B32 File Offset: 0x000CED32
		internal string <<EMPTY_NAME>>()
		{
			return this.O__00_Oo0.00__.;
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x000D0B3C File Offset: 0x000CED3C
		internal void <<EMPTY_NAME>>(string A_0)
		{
			if (Operators.CompareString(A_0, this.O__00_Oo0.00__., true) != 0 || this.DropDownForm == null)
			{
				if (this.DropDownForm != null && this.DropDownForm.Controls.Count > 0)
				{
					this.DropDownForm.Controls.Clear();
				}
				this.O__00_Oo0.00__. = A_0;
				if (Operators.CompareString(A_0, "", true) > 0 && OO_00oOO.Forms.Contains(A_0))
				{
					if (this.DropDownForm == null)
					{
						this.DropDownForm = new DropDownForm();
						return;
					}
				}
				else if (this.DropDownForm != null)
				{
					Component dropDownForm = this.DropDownForm;
					this.DropDownForm = null;
					dropDownForm.Dispose();
				}
			}
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x000D0BDC File Offset: 0x000CEDDC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.DataBindings.Count > 0 && base.DataBindings[0].BindingManagerBase.Count == 0)
			{
				base.ReadOnly = true;
				return;
			}
			ooO_0O.o_O0.O_.(this, this.OO.o.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000D0C30 File Offset: 0x000CEE30
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Space && (Operators.CompareString(this.Text, "", true) == 0 || !this.O.0oo0_.()))
			{
				A_1.Handled = true;
				A_1.SuppressKeyPress = true;
				this.OpenDropDown();
				return;
			}
			if (A_1.KeyCode == Keys.Down || A_1.KeyCode == Keys.Up)
			{
				if (base.Parent is O_oOooO_O && !base.DroppedDown && ((O_oOooO_O)base.Parent).FinishEditing())
				{
					if (A_1.KeyCode == Keys.Down)
					{
						SendKeys.Send("{DOWN}");
						return;
					}
					SendKeys.Send("{UP}");
					return;
				}
			}
			else if (!this.O.0oo0_.() && A_1.KeyCode == Keys.Delete)
			{
				A_1.Handled = true;
				A_1.SuppressKeyPress = true;
			}
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000D0CF2 File Offset: 0x000CEEF2
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			if (!this.O.0oo0_.())
			{
				A_1.Handled = true;
				A_1.KeyChar = '\0';
			}
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000D0D0C File Offset: 0x000CEF0C
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

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x000D0D77 File Offset: 0x000CEF77
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x000D0D7F File Offset: 0x000CEF7F
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

		// Token: 0x06001E64 RID: 7780 RVA: 0x000D0D8D File Offset: 0x000CEF8D
		public bool <<EMPTY_NAME>>()
		{
			return this.oo0O_o.ooo0.;
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x000D0D95 File Offset: 0x000CEF95
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.oo0O_o.ooo0. = A_0;
		}

		// Token: 0x04000CC6 RID: 3270
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000CC7 RID: 3271
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000CC8 RID: 3272
		private string <<EMPTY_NAME>>;

		// Token: 0x04000CC9 RID: 3273
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000CCA RID: 3274
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000CCB RID: 3275
		private string <<EMPTY_NAME>>;
	}
}
