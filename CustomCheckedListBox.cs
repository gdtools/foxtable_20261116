using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003DC RID: 988
	internal class CustomCheckedListBox : CheckedListBox
	{
		// Token: 0x06004066 RID: 16486 RVA: 0x001D3BA4 File Offset: 0x001D1DA4
		public CustomCheckedListBox()
		{
			base.ItemCheck += this.OO_o_.o__.;
			base.MouseDown += this.OO_o_.o__.;
			base.SelectedIndexChanged += this.OO_o_.o__.;
			this.Oo0oO0_.o00. = BooleanEnum.Default;
			this.Oo0oO0_.o00. = ",";
			this.Oo0oO0_.o00. = new List<string>();
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06004067 RID: 16487 RVA: 0x001D3C0A File Offset: 0x001D1E0A
		// (set) Token: 0x06004068 RID: 16488 RVA: 0x001D3C12 File Offset: 0x001D1E12
		internal BooleanEnum ReadOnly
		{
			get
			{
				return this.Oo0oO0_.o00.;
			}
			set
			{
				this.Oo0oO0_.o00. = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06004069 RID: 16489 RVA: 0x001D3C1B File Offset: 0x001D1E1B
		// (set) Token: 0x0600406A RID: 16490 RVA: 0x001D3C23 File Offset: 0x001D1E23
		public string Separator
		{
			get
			{
				return this.Oo0oO0_.o00.;
			}
			set
			{
				this.Oo0oO0_.o00. = Conversions.ToString(value[0]);
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x0600406B RID: 16491 RVA: 0x001D3C37 File Offset: 0x001D1E37
		// (set) Token: 0x0600406C RID: 16492 RVA: 0x001D3C5C File Offset: 0x001D1E5C
		public string Value
		{
			get
			{
				return string.Join(Conversions.ToString(this.Separator[0]), this.Oo0oO0_.o00..ToArray());
			}
			set
			{
				this.Oo0oO0_.o00..Clear();
				int num = base.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					base.SetItemChecked(i, false);
				}
				if (Operators.CompareString(value, "", true) > 0)
				{
					List<string> list = new List<string>();
					DataView dataView = null;
					if (base.DataSource != null)
					{
						dataView = (DataView)base.DataSource;
					}
					list.AddRange(value.Split(new char[]
					{
						this.Separator[0]
					}));
					try
					{
						foreach (string right in list)
						{
							if (dataView == null)
							{
								int num2 = base.Items.Count - 1;
								for (int j = 0; j <= num2; j++)
								{
									if (Operators.CompareString(base.Items[j].ToString(), right, true) == 0)
									{
										base.SetItemChecked(j, true);
										break;
									}
								}
							}
							else
							{
								int num3 = dataView.Count - 1;
								for (int k = 0; k <= num3; k++)
								{
									if (Operators.CompareString(dataView[k][base.ValueMember].ToString(), right, true) == 0)
									{
										base.SetItemChecked(k, true);
										break;
									}
								}
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x0600406D RID: 16493 RVA: 0x001D3DBC File Offset: 0x001D1FBC
		// (set) Token: 0x0600406E RID: 16494 RVA: 0x001D3DF4 File Offset: 0x001D1FF4
		public object SelectedValue2
		{
			get
			{
				object result;
				if (this.SelectedIndex == -1)
				{
					result = null;
				}
				else if (base.DataSource == null)
				{
					result = base.SelectedItem.ToString();
				}
				else
				{
					result = base.SelectedValue;
				}
				return result;
			}
			set
			{
				if (value == null)
				{
					this.SelectedIndex = -1;
					return;
				}
				if (base.DataSource == null)
				{
					this.SelectedIndex = base.FindStringExact(value.ToString());
					return;
				}
				this.SelectedIndex = ((DataView)base.DataSource).Find(RuntimeHelpers.GetObjectValue(value));
			}
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x001D3E44 File Offset: 0x001D2044
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

		// Token: 0x06004070 RID: 16496 RVA: 0x001D3F75 File Offset: 0x001D2175
		protected virtual void <<EMPTY_NAME>>(ref Message A_0)
		{
			if ((A_0.Msg != 513 && A_0.Msg != 515) || this.OO_o_.o__.())
			{
				base.WndProc(ref A_0);
			}
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x001D3FA0 File Offset: 0x001D21A0
		private void <<EMPTY_NAME>>(object A_0, ItemCheckEventArgs A_1)
		{
			string text = null;
			if (base.DataSource == null)
			{
				text = base.Items[A_1.Index].ToString();
			}
			else if (base.ValueMember != null)
			{
				text = ((DataRowView)base.Items[A_1.Index])[base.ValueMember].ToString();
			}
			if (text != null)
			{
				if (A_1.NewValue == CheckState.Checked)
				{
					if (!this.Oo0oO0_.o00..Contains(text))
					{
						this.Oo0oO0_.o00..Add(text);
						return;
					}
				}
				else if (this.Oo0oO0_.o00..Contains(text))
				{
					this.Oo0oO0_.o00..Remove(text);
				}
			}
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x001D4044 File Offset: 0x001D2244
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (A_1.Button == MouseButtons.Left && this.SelectedIndex >= 0 && !base.CheckOnClick && this.SelectedIndex != this.Oo0oO0_.o00.)
			{
				this.Oo0oO0_.o00. = this.SelectedIndex;
				Point pt = base.PointToClient(Control.MousePosition);
				Rectangle itemRectangle = base.GetItemRectangle(this.SelectedIndex);
				if (itemRectangle.Contains(pt) && pt.X < itemRectangle.X + 16)
				{
					base.SetItemChecked(this.SelectedIndex, !base.GetItemChecked(this.SelectedIndex));
				}
			}
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x001D40DA File Offset: 0x001D22DA
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Oo0oO0_.o00. = this.SelectedIndex;
		}

		// Token: 0x04001A08 RID: 6664
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001A09 RID: 6665
		private string <<EMPTY_NAME>>;

		// Token: 0x04001A0A RID: 6666
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04001A0B RID: 6667
		private int <<EMPTY_NAME>>;
	}
}
