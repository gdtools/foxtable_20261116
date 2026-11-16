using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003E8 RID: 1000
	internal class oO00O0oO0o000 : RadioButton, O000O
	{
		// Token: 0x0600412B RID: 16683 RVA: 0x001D79E0 File Offset: 0x001D5BE0
		public oO00O0oO0o000()
		{
			base.Click += this.o._0_0.;
			base.Enter += this.O.0o00O.;
			base.GotFocus += this.O00_o0_.O__oo.;
			this.oo0oO_O.oooO0O. = BooleanEnum.Default;
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x001D7A30 File Offset: 0x001D5C30
		public BooleanEnum <<EMPTY_NAME>>()
		{
			return this.oo0oO_O.oooO0O.;
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x001D7A38 File Offset: 0x001D5C38
		public void <<EMPTY_NAME>>(BooleanEnum A_0)
		{
			this.oo0oO_O.oooO0O. = A_0;
			this.O00_o0_.O__oo.();
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x001D7A47 File Offset: 0x001D5C47
		// (set) Token: 0x0600412F RID: 16687 RVA: 0x001D7A54 File Offset: 0x001D5C54
		public new object Checked
		{
			get
			{
				return base.Checked;
			}
			set
			{
				if (value == DBNull.Value)
				{
					value = false;
				}
				base.Checked = Conversions.ToBoolean(value);
			}
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x001D7A74 File Offset: 0x001D5C74
		internal void <<EMPTY_NAME>>()
		{
			switch (this.O00_o0_.O__oo.())
			{
			case BooleanEnum.Default:
				if (base.DataBindings.Count == 0)
				{
					base.AutoCheck = true;
					return;
				}
				if (base.DataBindings.Count > 0)
				{
					BindingMemberInfo bindingMemberInfo = base.DataBindings[0].BindingMemberInfo;
					if (base.DataBindings[0].DataSource is O_0)
					{
						string text = ((O_0)base.DataBindings[0].DataSource).Oo._Oo0OO.();
						if (OO_00oOO.Tables.get_Contains(text) && OO_00oOO.Tables[text].Cols.Contains(bindingMemberInfo.BindingField))
						{
							if (!OO_00oOO.Tables[text].AllowEdit)
							{
								base.AutoCheck = false;
							}
							else if (!OO_00oOO.Tables[text].Cols[bindingMemberInfo.BindingField].AllowEdit)
							{
								base.AutoCheck = false;
							}
							else if (OO_00oOO.Tables[text].Current != null && OO_00oOO.Tables[text].Current.Locked)
							{
								base.AutoCheck = false;
							}
							else
							{
								base.AutoCheck = true;
							}
						}
						bindingMemberInfo = default(BindingMemberInfo);
						return;
					}
				}
				break;
			case BooleanEnum.True:
				base.AutoCheck = false;
				return;
			case BooleanEnum.False:
				base.AutoCheck = true;
				break;
			default:
				return;
			}
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x001D7BD3 File Offset: 0x001D5DD3
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.DataBindings.Count > 0)
			{
				base.DataBindings[0].WriteValue();
			}
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x001D7BF4 File Offset: 0x001D5DF4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O00_o0_.O__oo.();
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x001D7BFC File Offset: 0x001D5DFC
		public void <<EMPTY_NAME>>()
		{
			this.O00_o0_.O__oo.();
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x001D7C04 File Offset: 0x001D5E04
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O00_o0_.O__oo.();
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x001D7C0C File Offset: 0x001D5E0C
		public bool <<EMPTY_NAME>>()
		{
			return this.oo0oO_O.oooO0O.;
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x001D7C14 File Offset: 0x001D5E14
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.oo0oO_O.oooO0O. = A_0;
		}

		// Token: 0x04001A4C RID: 6732
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001A4D RID: 6733
		private bool <<EMPTY_NAME>>;
	}
}
