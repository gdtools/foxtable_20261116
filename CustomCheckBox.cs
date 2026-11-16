using System;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003D7 RID: 983
	internal class CustomCheckBox : C1CheckBox, O000O
	{
		// Token: 0x0600400F RID: 16399 RVA: 0x001D2D40 File Offset: 0x001D0F40
		internal CustomCheckBox()
		{
			base.Click += this.O_._O0.;
			base.Enter += this.O.o0.;
			base.GotFocus += this.O.00o_O.;
			this.O.00o_O. = BooleanEnum.Default;
			base.VisualStyle = VisualStyle.Custom;
			Main.OO_O.o..o.O000oo.(new object[]
			{
				this
			});
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06004010 RID: 16400 RVA: 0x001D2DAB File Offset: 0x001D0FAB
		// (set) Token: 0x06004011 RID: 16401 RVA: 0x001D2DB3 File Offset: 0x001D0FB3
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.O.00o_O.;
			}
			set
			{
				this.O.00o_O. = value;
				this.O.00o_O.();
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06004012 RID: 16402 RVA: 0x001D2DC2 File Offset: 0x001D0FC2
		// (set) Token: 0x06004013 RID: 16403 RVA: 0x001D2DCF File Offset: 0x001D0FCF
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

		// Token: 0x06004014 RID: 16404 RVA: 0x001D2DF0 File Offset: 0x001D0FF0
		internal void <<EMPTY_NAME>>()
		{
			switch (this.ReadOnly)
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

		// Token: 0x06004015 RID: 16405 RVA: 0x001D2F4F File Offset: 0x001D114F
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.DataBindings.Count > 0)
			{
				base.DataBindings[0].WriteValue();
			}
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x001D2F70 File Offset: 0x001D1170
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.00o_O.();
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x001D2F78 File Offset: 0x001D1178
		public void <<EMPTY_NAME>>()
		{
			this.O.00o_O.();
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x001D2F80 File Offset: 0x001D1180
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.00o_O.();
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06004019 RID: 16409 RVA: 0x001D2F88 File Offset: 0x001D1188
		// (set) Token: 0x0600401A RID: 16410 RVA: 0x001D2F90 File Offset: 0x001D1190
		public bool isWritingValue
		{
			get
			{
				return this.O.00o_O.;
			}
			set
			{
				this.O.00o_O. = value;
			}
		}

		// Token: 0x040019F9 RID: 6649
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040019FA RID: 6650
		private bool <<EMPTY_NAME>>;
	}
}
