using System;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003E3 RID: 995
	internal class CustomListBox : System.Windows.Forms.ListBox
	{
		// Token: 0x060040E3 RID: 16611 RVA: 0x001D5FC4 File Offset: 0x001D41C4
		public CustomListBox()
		{
			base.DrawItem += this.OOo.0_0.;
			base.FontChanged += this.OOo.0_0.;
			this.O.00_Oo. = BooleanEnum.Default;
			this.O.00_Oo. = 3;
			this.O.00_Oo. = new StringFormat();
			base.IntegralHeight = false;
			this.DrawMode = DrawMode.OwnerDrawFixed;
			this.O.00_Oo..LineAlignment = StringAlignment.Center;
			this.O.00_Oo..Alignment = StringAlignment.Near;
			this.O.00_Oo..FormatFlags = (this.O.00_Oo..FormatFlags | StringFormatFlags.NoWrap);
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x060040E4 RID: 16612 RVA: 0x001D6056 File Offset: 0x001D4256
		// (set) Token: 0x060040E5 RID: 16613 RVA: 0x001D605E File Offset: 0x001D425E
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.O.00_Oo.;
			}
			set
			{
				this.O.00_Oo. = value;
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x060040E6 RID: 16614 RVA: 0x001D6068 File Offset: 0x001D4268
		// (set) Token: 0x060040E7 RID: 16615 RVA: 0x001D60A0 File Offset: 0x001D42A0
		public object Value
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

		// Token: 0x060040E8 RID: 16616 RVA: 0x001D60F0 File Offset: 0x001D42F0
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

		// Token: 0x060040E9 RID: 16617 RVA: 0x001D6221 File Offset: 0x001D4421
		protected virtual void <<EMPTY_NAME>>(ref Message A_0)
		{
			if ((A_0.Msg != 513 && A_0.Msg != 515) || this.OOo.0_0.())
			{
				base.WndProc(ref A_0);
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x060040EA RID: 16618 RVA: 0x001D624C File Offset: 0x001D444C
		// (set) Token: 0x060040EB RID: 16619 RVA: 0x001D6254 File Offset: 0x001D4454
		internal int ItemSpacing
		{
			get
			{
				return this.O.00_Oo.;
			}
			set
			{
				this.O.00_Oo. = value;
				this.ItemHeight = (int)Math.Ceiling((double)(this.Font.Size / 9f * 12f)) + value;
			}
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x001D6284 File Offset: 0x001D4484
		private void <<EMPTY_NAME>>(object A_0, DrawItemEventArgs A_1)
		{
			if (A_1.Index >= 0)
			{
				A_1.DrawBackground();
				A_1.DrawFocusRectangle();
				string s;
				if (base.DataSource != null)
				{
					ListItemFormatEventArgs listItemFormatEventArgs = new ListItemFormatEventArgs(this, this.O.00_Oo., (DataRowView)base.Items[A_1.Index]);
					string a_ = "ListItemFormat_" + Conversions.ToString(base.Tag);
					O_O0OO.OoO_o.oO0o0O.(this.O.00_Oo..O_0.O00o_00_O., a_, new object[]
					{
						listItemFormatEventArgs
					}, false, this.O.00_Oo..mmname + "," + base.Name, false);
					if (Operators.CompareString(listItemFormatEventArgs.Text, "", true) > 0)
					{
						s = listItemFormatEventArgs.Text;
					}
					else
					{
						DataRowView dataRowView = (DataRowView)base.Items[A_1.Index];
						if (Operators.CompareString(base.DisplayMember, "", true) > 0)
						{
							s = dataRowView[base.DisplayMember].ToString();
						}
						else
						{
							s = dataRowView.ToString();
						}
					}
				}
				else
				{
					s = base.Items[A_1.Index].ToString();
				}
				A_1.Graphics.DrawString(s, A_1.Font, new SolidBrush(A_1.ForeColor), A_1.Bounds, this.O.00_Oo.);
			}
		}

		// Token: 0x060040ED RID: 16621 RVA: 0x001D63D0 File Offset: 0x001D45D0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.ItemHeight = (int)Math.Ceiling((double)(this.Font.Size / 9f * 12f)) + this.ItemSpacing;
		}

		// Token: 0x04001A30 RID: 6704
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001A31 RID: 6705
		internal int <<EMPTY_NAME>>;

		// Token: 0x04001A32 RID: 6706
		private StringFormat <<EMPTY_NAME>>;

		// Token: 0x04001A33 RID: 6707
		internal Foxtable.WinForm.Form <<EMPTY_NAME>>;
	}
}
