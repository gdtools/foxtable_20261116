using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000278 RID: 632
	internal class O0O_O0 : C1TextBox, O000O
	{
		// Token: 0x06001EC1 RID: 7873 RVA: 0x000D34D0 File Offset: 0x000D16D0
		public O0O_O0()
		{
			base.Enter += this.o_0.00o0.;
			base.GotFocus += this.O0.oooOo0_.;
			base.Validated += this.oO0_.o.;
			base.MultilineChanged += this.ooO.Oo000_.;
			base.KeyDown += this.ooO.Oo000_.;
			this.O0oO_OOOOo0o.o. = BooleanEnum.Default;
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
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000D35CF File Offset: 0x000D17CF
		public BooleanEnum <<EMPTY_NAME>>()
		{
			return this.O0oO_OOOOo0o.o.;
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x000D35D7 File Offset: 0x000D17D7
		public void <<EMPTY_NAME>>(BooleanEnum A_0)
		{
			base.UpdateValueWithCurrentText();
			this.O0oO_OOOOo0o.o. = A_0;
			ooO_0O.o_O0.O_.(this, this.O0oO_OOOOo0o.o.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x000D3600 File Offset: 0x000D1800
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO_0O.o_O0.O_.(this, this.O0oO_OOOOo0o.o.());
			base.ReadOnly = base.ReadOnly;
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

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x000D36DC File Offset: 0x000D18DC
		// (set) Token: 0x06001EC6 RID: 7878 RVA: 0x000D3702 File Offset: 0x000D1902
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

		// Token: 0x06001EC7 RID: 7879 RVA: 0x000D3710 File Offset: 0x000D1910
		public void <<EMPTY_NAME>>()
		{
			ooO_0O.o_O0.O_.(this, this.O0oO_OOOOo0o.o.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x000D372C File Offset: 0x000D192C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.DataBindings.Count > 0 && base.DataBindings[0].BindingManagerBase.Count == 0)
			{
				base.ReadOnly = true;
				return;
			}
			ooO_0O.o_O0.O_.(this, this.O0oO_OOOOo0o.o.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x000D3780 File Offset: 0x000D1980
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

		// Token: 0x06001ECA RID: 7882 RVA: 0x000D37EB File Offset: 0x000D19EB
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Multiline)
			{
				base.VerticalAlign = VerticalAlignEnum.Top;
				return;
			}
			base.VerticalAlign = VerticalAlignEnum.Middle;
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x000D3804 File Offset: 0x000D1A04
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (base.FindForm() != null && base.FindForm().GetType() == typeof(DropDownForm) && this.Multiline && A_1.KeyCode == Keys.Return)
			{
				this.SelectedText = "\r\n";
				A_1.Handled = true;
				A_1.SuppressKeyPress = true;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x000D385B File Offset: 0x000D1A5B
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x000D3863 File Offset: 0x000D1A63
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

		// Token: 0x06001ECE RID: 7886 RVA: 0x000D3871 File Offset: 0x000D1A71
		public bool <<EMPTY_NAME>>()
		{
			return this.O0oO_OOOOo0o.o.;
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x000D3879 File Offset: 0x000D1A79
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.O0oO_OOOOo0o.o. = A_0;
		}

		// Token: 0x04000CF4 RID: 3316
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000CF5 RID: 3317
		private bool <<EMPTY_NAME>>;
	}
}
