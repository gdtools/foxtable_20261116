using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020003DD RID: 989
	internal class CustomColorLabel : Label
	{
		// Token: 0x06004074 RID: 16500 RVA: 0x001D40E8 File Offset: 0x001D22E8
		public CustomColorLabel()
		{
			base.DoubleClick += this.O_o0oo._oO0.;
			this.AutoSize = false;
			this.Text = "";
			this.BackColor = Color.Red;
			this.BorderStyle = BorderStyle.Fixed3D;
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06004075 RID: 16501 RVA: 0x001D4126 File Offset: 0x001D2326
		// (set) Token: 0x06004076 RID: 16502 RVA: 0x001D4130 File Offset: 0x001D2330
		public object Value
		{
			get
			{
				return this.O_o0oo._oO0.;
			}
			set
			{
				this.O_o0oo._oO0. = RuntimeHelpers.GetObjectValue(value);
				int argb;
				if (value == DBNull.Value || value == null)
				{
					if (this.BackColor != Color.Empty)
					{
						this.BackColor = Color.Empty;
						return;
					}
				}
				else if (int.TryParse(value.ToString(), out argb))
				{
					if (this.BackColor != Color.FromArgb(argb))
					{
						this.BackColor = Color.FromArgb(argb);
						return;
					}
				}
				else if (this.BackColor != Color.Empty)
				{
					this.BackColor = Color.Empty;
				}
			}
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x001D41C0 File Offset: 0x001D23C0
		private bool <<EMPTY_NAME>>()
		{
			bool result;
			switch (this.ReadOnly)
			{
			case BooleanEnum.Default:
				if (base.DataBindings.Count == 0)
				{
					result = true;
				}
				else if (base.DataBindings.Count > 0)
				{
					BindingMemberInfo bindingMemberInfo = base.DataBindings[0].BindingMemberInfo;
					if (!(base.DataBindings[0].DataSource is O_0))
					{
						result = true;
					}
					else
					{
						string text = ((O_0)base.DataBindings[0].DataSource).Oo._Oo0OO.();
						if (OO_00oOO.Tables.get_Contains(text) && OO_00oOO.Tables[text].Cols.Contains(bindingMemberInfo.BindingField))
						{
							result = (OO_00oOO.Tables[text].Cols[bindingMemberInfo.BindingField].AllowEdit && (OO_00oOO.Tables[text].Current == null || !OO_00oOO.Tables[text].Current.Locked));
						}
						else
						{
							bindingMemberInfo = default(BindingMemberInfo);
						}
					}
				}
				break;
			case BooleanEnum.True:
				result = false;
				break;
			case BooleanEnum.False:
				result = true;
				break;
			}
			return result;
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x001D42F1 File Offset: 0x001D24F1
		// (set) Token: 0x06004079 RID: 16505 RVA: 0x001D42F9 File Offset: 0x001D24F9
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.O_o0oo._oO0.;
			}
			set
			{
				this.O_o0oo._oO0. = value;
			}
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x001D4304 File Offset: 0x001D2504
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = this.BackColor;
			colorDialog.AnyColor = true;
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				this.Value = colorDialog.Color.ToArgb();
				if (base.DataBindings.Count > 0)
				{
					base.DataBindings[0].WriteValue();
				}
				this.O_o0oo._oO0. = RuntimeHelpers.GetObjectValue(this.Value);
			}
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x001D437C File Offset: 0x001D257C
		protected virtual void <<EMPTY_NAME>>(ref Message A_0)
		{
			if ((A_0.Msg != 513 && A_0.Msg != 515) || this.Oo0oO0_.o00.())
			{
				base.WndProc(ref A_0);
			}
		}

		// Token: 0x04001A0C RID: 6668
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001A0D RID: 6669
		private object <<EMPTY_NAME>>;
	}
}
