using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000149 RID: 329
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class oOO : C1ColorPicker, O000O
	{
		// Token: 0x06001040 RID: 4160 RVA: 0x0007D584 File Offset: 0x0007B784
		internal oOO()
		{
			base.ColorChanged += this.o0.o_0.;
			base.Enter += this.o__0._Ooo00.;
			base.GotFocus += this.o00.Oo0.;
			base.TextChanged += this.O_o0oo._oO0.;
			this.o.Oo. = BooleanEnum.Default;
			base.VisualStyle = VisualStyle.Custom;
			Main.OO_O.o..o.O000oo.(new object[]
			{
				this
			});
			base.EmptyAsNull = true;
			base.MaskInfo.EmptyAsNull = true;
			base.ErrorInfo.ShowErrorMessage = false;
			base.AutoSize = false;
			base.VerticalAlign = VerticalAlignEnum.Middle;
			base.Padding = new Padding(1, 2, 1, 1);
			base.Color = Color.Empty;
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0007D648 File Offset: 0x0007B848
		public BooleanEnum <<EMPTY_NAME>>()
		{
			return this.o.Oo.;
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0007D650 File Offset: 0x0007B850
		public void <<EMPTY_NAME>>(BooleanEnum A_0)
		{
			this.o.Oo. = A_0;
			ooO_0O.o_O0.O_.(this, this.o.Oo.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0007D671 File Offset: 0x0007B871
		public void <<EMPTY_NAME>>()
		{
			ooO_0O.o_O0.O_.(this, this.o.Oo.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0007D68B File Offset: 0x0007B88B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Value = base.Color;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0007D69E File Offset: 0x0007B89E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO_0O.o_O0.O_.(this, this.o.Oo.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0007D6B8 File Offset: 0x0007B8B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO_0O.o_O0.O_.(this, this.o.Oo.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x0007D6D4 File Offset: 0x0007B8D4
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x0007D6F4 File Offset: 0x0007B8F4
		public object Value2
		{
			get
			{
				return base.Color.ToArgb();
			}
			set
			{
				if (value == DBNull.Value || value == null)
				{
					base.Color = Color.Empty;
					return;
				}
				int argb;
				if (int.TryParse(value.ToString(), out argb))
				{
					if (base.Color != Color.FromArgb(argb))
					{
						base.Color = Color.FromArgb(argb);
						return;
					}
				}
				else if (base.Color != Color.Empty)
				{
					base.Color = Color.Empty;
				}
			}
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0007D764 File Offset: 0x0007B964
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.Text, "", true) == 0)
			{
				base.Value = Color.Transparent;
			}
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0007D789 File Offset: 0x0007B989
		public bool <<EMPTY_NAME>>()
		{
			return this.o.Oo.;
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0007D791 File Offset: 0x0007B991
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.o.Oo. = A_0;
		}

		// Token: 0x04000651 RID: 1617
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000652 RID: 1618
		private bool <<EMPTY_NAME>>;
	}
}
