using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000274 RID: 628
	internal class o__0OoO_ : C1TextBox, O000O
	{
		// Token: 0x06001E69 RID: 7785 RVA: 0x000D0E34 File Offset: 0x000CF034
		public o__0OoO_()
		{
			base.Enter += this.Oo_oO._0_.;
			base.PreviewKeyDown += this.O0oo_oo.0.;
			base.Formatting += this.O0oo_oo.0.;
			base.Parsing += this.O0oo_oo.0.;
			base.GotFocus += this.O0oo_oo.0.;
			this.O_o.0. = BooleanEnum.Default;
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
			this.DataType = typeof(string);
			base.ParseInfo.FormatType = FormatTypeEnum.UseEvent;
			base.FormatType = FormatTypeEnum.UseEvent;
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x000D0F56 File Offset: 0x000CF156
		public BooleanEnum <<EMPTY_NAME>>()
		{
			return this.O_o.0.;
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x000D0F5E File Offset: 0x000CF15E
		public void <<EMPTY_NAME>>(BooleanEnum A_0)
		{
			this.O_o.0. = A_0;
			ooO_0O.o_O0.O_.(this, this.O_o.0.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x000D0F7F File Offset: 0x000CF17F
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO_0O.o_O0.O_.(this, this.O_o.0.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x000D0F9C File Offset: 0x000CF19C
		// (set) Token: 0x06001E6E RID: 7790 RVA: 0x000D1000 File Offset: 0x000CF200
		public new object Value
		{
			get
			{
				object result;
				double num;
				if (base.Value == DBNull.Value)
				{
					result = null;
				}
				else if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(base.Value)))
				{
					result = Conversions.ToDouble(base.Value);
				}
				else if (O_O0OO.Oo0.OoOo.(base.Value.ToString(), ref num))
				{
					result = num;
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (value == null || Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(value)))
				{
					base.Value = RuntimeHelpers.GetObjectValue(value);
					return;
				}
				double num;
				if (O_O0OO.Oo0.OoOo.(value.ToString(), ref num))
				{
					base.Value = num;
				}
			}
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000D1045 File Offset: 0x000CF245
		public void <<EMPTY_NAME>>()
		{
			ooO_0O.o_O0.O_.(this, this.O_o.0.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000D1060 File Offset: 0x000CF260
		private void <<EMPTY_NAME>>(object A_0, PreviewKeyDownEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Right && base.SelectionStart == this.Text.Length)
			{
				SendKeys.Send("{TAB}");
				return;
			}
			if (A_1.KeyCode == Keys.Left && base.SelectionStart == 0 && this.SelectionLength == 0)
			{
				SendKeys.Send("+{TAB}");
			}
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x000D10BC File Offset: 0x000CF2BC
		private void <<EMPTY_NAME>>(object A_0, FormatEventArgs A_1)
		{
			if (A_1.Value != null)
			{
				string text = "";
				if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(A_1.Value)) && O_O0OO.o.00O_O.(Conversions.ToDouble(A_1.Value), ref text))
				{
					A_1.Text = text;
					return;
				}
				double num;
				if (A_1.Value != null && A_1.Value is string && O_O0OO.Oo0.OoOo.(A_1.Value.ToString(), ref num))
				{
					A_1.Text = A_1.Value.ToString();
				}
			}
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x000D1140 File Offset: 0x000CF340
		private void <<EMPTY_NAME>>(object A_0, ParseEventArgs A_1)
		{
			double num;
			if (A_1.Text != null && O_O0OO.Oo0.OoOo.(this.Text, ref num))
			{
				A_1.Value = num;
			}
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x000D1170 File Offset: 0x000CF370
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.DataBindings.Count > 0 && base.DataBindings[0].BindingManagerBase.Count == 0)
			{
				base.ReadOnly = true;
				return;
			}
			ooO_0O.o_O0.O_.(this, this.O_o.0.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x000D11C3 File Offset: 0x000CF3C3
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x000D11CB File Offset: 0x000CF3CB
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

		// Token: 0x06001E76 RID: 7798 RVA: 0x000D11D9 File Offset: 0x000CF3D9
		public bool <<EMPTY_NAME>>()
		{
			return this.O_o.0.;
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x000D11E1 File Offset: 0x000CF3E1
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.O_o.0. = A_0;
		}

		// Token: 0x04000CCD RID: 3277
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000CCE RID: 3278
		private bool <<EMPTY_NAME>>;
	}
}
