using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 列表框
	/// </summary>
	// Token: 0x0200052D RID: 1325
	[ComVisible(true)]
	public class ListBox : Control, OoO_
	{
		// Token: 0x06005832 RID: 22578 RVA: 0x0025E3C0 File Offset: 0x0025C5C0
		internal ListBox(CustomListBox A_0) : base(A_0, ControlTypeEnum.TextBox)
		{
			this.O.oo_oO. = A_0;
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06005833 RID: 22579 RVA: 0x0025E3D1 File Offset: 0x0025C5D1
		// (set) Token: 0x06005834 RID: 22580 RVA: 0x0025E3DE File Offset: 0x0025C5DE
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O.oo_oO..BorderStyle;
			}
			set
			{
				this.O.oo_oO..BorderStyle = value;
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06005835 RID: 22581 RVA: 0x0025E3EC File Offset: 0x0025C5EC
		// (set) Token: 0x06005836 RID: 22582 RVA: 0x0025E3F9 File Offset: 0x0025C5F9
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.O.oo_oO..ReadOnly;
			}
			set
			{
				this.O.oo_oO..ReadOnly = value;
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06005837 RID: 22583 RVA: 0x0025E407 File Offset: 0x0025C607
		// (set) Token: 0x06005838 RID: 22584 RVA: 0x0025E410 File Offset: 0x0025C610
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.O.oo_oO..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.ListBox, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.O.oo_oO..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value", value);
							if (binding != null)
							{
								this.O.oo_oO..DataBindings.Add(binding);
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 用于设置自定义列表项目，项目之间用符号“|”隔开
		/// </summary>
		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06005839 RID: 22585 RVA: 0x0025E4E8 File Offset: 0x0025C6E8
		// (set) Token: 0x0600583A RID: 22586 RVA: 0x0025E56C File Offset: 0x0025C76C
		[oO0oooo("0953")]
		public string ComboList
		{
			get
			{
				string text = "";
				try
				{
					foreach (object value in this.O.oo_oO..Items)
					{
						string str = Conversions.ToString(value);
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += "|";
						}
						text += str;
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				return text;
			}
			set
			{
				this.O.oo_oO..Items.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.O.oo_oO..BeginUpdate();
					this.O.oo_oO..Items.AddRange(value.Split(new char[]
					{
						'\n',
						'\r',
						'|'
					}, StringSplitOptions.RemoveEmptyEntries));
					this.O.oo_oO..EndUpdate();
				}
			}
		}

		/// <summary>
		/// 返回或设置显示列的名称
		/// </summary>
		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x0600583B RID: 22587 RVA: 0x0025E5D6 File Offset: 0x0025C7D6
		// (set) Token: 0x0600583C RID: 22588 RVA: 0x0025E5E3 File Offset: 0x0025C7E3
		[oO0oooo("0956")]
		public string DisplayMember
		{
			get
			{
				return this.O.oo_oO..DisplayMember;
			}
			set
			{
				this.O.oo_oO..DisplayMember = value;
			}
		}

		/// <summary>
		/// 返回或设置取值列的名称
		/// </summary>
		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x0600583D RID: 22589 RVA: 0x0025E5F1 File Offset: 0x0025C7F1
		// (set) Token: 0x0600583E RID: 22590 RVA: 0x0025E5FE File Offset: 0x0025C7FE
		[oO0oooo("0957")]
		public string ValueMember
		{
			get
			{
				return this.O.oo_oO..ValueMember;
			}
			set
			{
				this.O.oo_oO..ValueMember = value;
			}
		}

		/// <summary>
		/// 返回或设置列表项目来源表的名称
		/// </summary>
		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x0600583F RID: 22591 RVA: 0x0025E60C File Offset: 0x0025C80C
		// (set) Token: 0x06005840 RID: 22592 RVA: 0x0025E64C File Offset: 0x0025C84C
		[oO0oooo("0955")]
		public string DataSource
		{
			get
			{
				string result;
				if (this.O.oo_oO..DataSource == null)
				{
					result = "";
				}
				else
				{
					result = ((DataView)this.O.oo_oO..DataSource).Table.TableName;
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) > 0 && O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(value))
				{
					DataTable dataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables[value];
					if (Operators.CompareString(this.ValueMember, "", true) == 0 || !dataTable.Columns.Contains(this.ValueMember))
					{
						this.O.oo_oO..DataSource = null;
					}
					else
					{
						DataView dataSource = new DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables[value], this.DataFilter, this.ValueMember, DataViewRowState.CurrentRows);
						this.O.oo_oO..DataSource = dataSource;
					}
					return;
				}
				this.O.oo_oO..DataSource = null;
			}
		}

		/// <summary>
		/// 列表项目来自于数据表时，可以用此属性返回或设置过滤条件
		/// </summary>
		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06005841 RID: 22593 RVA: 0x0025E704 File Offset: 0x0025C904
		// (set) Token: 0x06005842 RID: 22594 RVA: 0x0025E739 File Offset: 0x0025C939
		public string DataFilter
		{
			get
			{
				string result;
				if (this.O.oo_oO..DataSource != null)
				{
					result = ((DataView)this.O.oo_oO..DataSource).RowFilter;
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (this.O.oo_oO..DataSource != null)
				{
					((DataView)this.O.oo_oO..DataSource).RowFilter = value;
				}
			}
		}

		/// <summary>
		/// 列表项目来自于数据表时，可以用此属性返回或设置排序字段
		/// </summary>
		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06005843 RID: 22595 RVA: 0x0025E760 File Offset: 0x0025C960
		// (set) Token: 0x06005844 RID: 22596 RVA: 0x0025E795 File Offset: 0x0025C995
		public string DataSort
		{
			get
			{
				string result;
				if (this.O.oo_oO..DataSource != null)
				{
					result = ((DataView)this.O.oo_oO..DataSource).Sort;
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (this.O.oo_oO..DataSource != null)
				{
					((DataView)this.O.oo_oO..DataSource).Sort = value;
				}
			}
		}

		/// <summary>
		/// 是否多列显示
		/// </summary>
		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06005845 RID: 22597 RVA: 0x0025E7BA File Offset: 0x0025C9BA
		// (set) Token: 0x06005846 RID: 22598 RVA: 0x0025E7C7 File Offset: 0x0025C9C7
		public bool MultiColumn
		{
			get
			{
				return this.O.oo_oO..MultiColumn;
			}
			set
			{
				this.O.oo_oO..MultiColumn = value;
			}
		}

		/// <summary>
		/// 多列显示时，用于设置每列宽度
		/// </summary>
		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06005847 RID: 22599 RVA: 0x0025E7D5 File Offset: 0x0025C9D5
		// (set) Token: 0x06005848 RID: 22600 RVA: 0x0025E7E2 File Offset: 0x0025C9E2
		public int ColumnWidth
		{
			get
			{
				return this.O.oo_oO..ColumnWidth;
			}
			set
			{
				this.O.oo_oO..ColumnWidth = value;
			}
		}

		/// <summary>
		/// 项目间隔，单位为像素
		/// </summary>
		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06005849 RID: 22601 RVA: 0x0025E7F0 File Offset: 0x0025C9F0
		// (set) Token: 0x0600584A RID: 22602 RVA: 0x0025E7FD File Offset: 0x0025C9FD
		public int ItemSpacing
		{
			get
			{
				return this.O.oo_oO..ItemSpacing;
			}
			set
			{
				this.O.oo_oO..ItemSpacing = value;
			}
		}

		/// <summary>
		/// 自定义列表项目集合
		/// </summary>
		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x0600584B RID: 22603 RVA: 0x0025E80B File Offset: 0x0025CA0B
		[oO0oooo("0954")]
		public ListBox.ObjectCollection Items
		{
			get
			{
				return this.O.oo_oO..Items;
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x0600584C RID: 22604 RVA: 0x0025E818 File Offset: 0x0025CA18
		// (set) Token: 0x0600584D RID: 22605 RVA: 0x0025E825 File Offset: 0x0025CA25
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Value
		{
			get
			{
				return this.O.oo_oO..Value;
			}
			set
			{
				this.O.oo_oO..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 返回或设置选定项目的位置
		/// </summary>
		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x0600584E RID: 22606 RVA: 0x0025E838 File Offset: 0x0025CA38
		// (set) Token: 0x0600584F RID: 22607 RVA: 0x0025E845 File Offset: 0x0025CA45
		[oO0oooo("0958")]
		public int SelectedIndex
		{
			get
			{
				return this.O.oo_oO..SelectedIndex;
			}
			set
			{
				this.O.oo_oO..SelectedIndex = value;
			}
		}

		/// <summary>
		/// 返回或设置选定的项目
		/// </summary>
		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06005850 RID: 22608 RVA: 0x0025E854 File Offset: 0x0025CA54
		// (set) Token: 0x06005851 RID: 22609 RVA: 0x0025E8B8 File Offset: 0x0025CAB8
		[oO0oooo("0959")]
		public object SelectedItem
		{
			get
			{
				object result;
				if (this.O.oo_oO..DataSource == null)
				{
					result = this.Value;
				}
				else if (this.O.oo_oO..SelectedIndex < 0)
				{
					result = null;
				}
				else
				{
					result = new DataRow(((DataView)this.O.oo_oO..DataSource)[this.O.oo_oO..SelectedIndex].Row);
				}
				return result;
			}
			set
			{
				if (value == null)
				{
					this.O.oo_oO..SelectedIndex = -1;
					return;
				}
				if (this.O.oo_oO..DataSource == null)
				{
					this.Value = RuntimeHelpers.GetObjectValue(value);
					return;
				}
				DataRow dataRow = (DataRow)value;
				int selectedIndex = ((DataView)this.O.oo_oO..DataSource).Find(RuntimeHelpers.GetObjectValue(dataRow[this.ValueMember]));
				this.SelectedIndex = selectedIndex;
			}
		}

		/// <summary>
		/// 返回或设置选定的值
		/// </summary>
		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06005852 RID: 22610 RVA: 0x0025E926 File Offset: 0x0025CB26
		// (set) Token: 0x06005853 RID: 22611 RVA: 0x0025E92E File Offset: 0x0025CB2E
		[oO0oooo("0960")]
		public object SelectedValue
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

		// Token: 0x06005854 RID: 22612 RVA: 0x0025E93C File Offset: 0x0025CB3C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x04002307 RID: 8967
		private CustomListBox <<EMPTY_NAME>>;
	}
}
