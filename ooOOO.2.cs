using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003E4 RID: 996
	internal class ooOOO : C1NumericEdit, O000O
	{
		// Token: 0x060040EE RID: 16622 RVA: 0x001D6400 File Offset: 0x001D4600
		internal ooOOO()
		{
			base.DropDownOpened += this.OoOoo.0_.;
			base.Enter += this.o__o00o___O.oO.;
			base.GotFocus += this.o_0_0_._.;
			base.PreviewKeyDown += this.OO_o_O_.o.;
			base.Validated += this.OO_o_O_.o.;
			this.o00.Oo_OO0. = BooleanEnum.Default;
			base.VisualStyle = VisualStyle.Custom;
			Main.OO_O.o..o.O000oo.(new object[]
			{
				this
			});
			base.AutoSize = false;
			base.EmptyAsNull = true;
			base.MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			base.MaskInfo.EmptyAsNull = true;
			base.MaskInfo.AutoTabWhenFilled = true;
			base.ErrorInfo.ShowErrorMessage = false;
			base.ExitOnLeftRightKey = ExitOnLeftRightKey.Both;
			base.ExitOnLastChar = true;
			base.VerticalAlign = VerticalAlignEnum.Middle;
			base.Padding = new Padding(1, 2, 1, 1);
			base.ImeMode = ImeMode.Close;
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x001D64F9 File Offset: 0x001D46F9
		public BooleanEnum <<EMPTY_NAME>>()
		{
			return this.o00.Oo_OO0.;
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x001D6501 File Offset: 0x001D4701
		public void <<EMPTY_NAME>>(BooleanEnum A_0)
		{
			this.o00.Oo_OO0. = A_0;
			ooO_0O.o_O0.O_.(this, this.o00.Oo_OO0.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x001D6522 File Offset: 0x001D4722
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.DropDownForm.Owner = null;
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x001D6530 File Offset: 0x001D4730
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO_0O.o_O0.O_.(this, this.o00.Oo_OO0.());
			base.ReadOnly = base.ReadOnly;
			if (base.ReadOnly)
			{
				base.DisplayFormat.FormatType = FormatTypeEnum.DefaultFormat;
				return;
			}
			base.EditFormat.FormatType = FormatTypeEnum.DefaultFormat;
			base.EditFormat.CustomFormat = "";
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x060040F3 RID: 16627 RVA: 0x001D6588 File Offset: 0x001D4788
		// (set) Token: 0x060040F4 RID: 16628 RVA: 0x001D65AE File Offset: 0x001D47AE
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

		// Token: 0x060040F5 RID: 16629 RVA: 0x001D65BC File Offset: 0x001D47BC
		public void <<EMPTY_NAME>>()
		{
			ooO_0O.o_O0.O_.(this, this.o00.Oo_OO0.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x001D65D8 File Offset: 0x001D47D8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.DataBindings.Count > 0 && base.DataBindings[0].BindingManagerBase.Count == 0)
			{
				base.ReadOnly = true;
				return;
			}
			ooO_0O.o_O0.O_.(this, this.o00.Oo_OO0.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x001D662C File Offset: 0x001D482C
		private void <<EMPTY_NAME>>(object A_0, PreviewKeyDownEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Right && base.SelectionStart == base.Text.Length)
			{
				SendKeys.Send("{TAB}");
				return;
			}
			if (A_1.KeyCode == Keys.Left && base.SelectionStart == 0 && this.SelectionLength == 0)
			{
				SendKeys.Send("+{TAB}");
			}
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x001D6688 File Offset: 0x001D4888
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

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x060040F9 RID: 16633 RVA: 0x001D66F3 File Offset: 0x001D48F3
		// (set) Token: 0x060040FA RID: 16634 RVA: 0x001D66FB File Offset: 0x001D48FB
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

		// Token: 0x060040FB RID: 16635 RVA: 0x001D6709 File Offset: 0x001D4909
		public bool <<EMPTY_NAME>>()
		{
			return this.o00.Oo_OO0.;
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x001D6711 File Offset: 0x001D4911
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.o00.Oo_OO0. = A_0;
		}

		// Token: 0x04001A34 RID: 6708
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001A35 RID: 6709
		private bool <<EMPTY_NAME>>;
	}
}
