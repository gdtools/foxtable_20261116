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
	/// 复选列表框
	/// </summary>
	// Token: 0x0200051C RID: 1308
	[ComVisible(true)]
	public class CheckedListBox : Control, OoO_
	{
		// Token: 0x06005712 RID: 22290 RVA: 0x0025BD4B File Offset: 0x00259F4B
		internal CheckedListBox(CustomCheckedListBox A_0) : base(A_0, ControlTypeEnum.CheckedListBox)
		{
			this.O00O.0OOO00. = A_0;
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x06005713 RID: 22291 RVA: 0x0025BD5D File Offset: 0x00259F5D
		// (set) Token: 0x06005714 RID: 22292 RVA: 0x0025BD6A File Offset: 0x00259F6A
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O00O.0OOO00..BorderStyle;
			}
			set
			{
				this.O00O.0OOO00..BorderStyle = value;
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x06005715 RID: 22293 RVA: 0x0025BD78 File Offset: 0x00259F78
		// (set) Token: 0x06005716 RID: 22294 RVA: 0x0025BD85 File Offset: 0x00259F85
		public virtual BooleanEnum ReadOnly
		{
			get
			{
				return this.O00O.0OOO00..ReadOnly;
			}
			set
			{
				this.O00O.0OOO00..ReadOnly = value;
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x06005717 RID: 22295 RVA: 0x0025BD93 File Offset: 0x00259F93
		// (set) Token: 0x06005718 RID: 22296 RVA: 0x0025BD9C File Offset: 0x00259F9C
		[oO0oooo("1860")]
		public virtual string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.O00O.0OOO00..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.CheckedListBox, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.O00O.0OOO00..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value", value);
							if (binding != null)
							{
								this.O00O.0OOO00..DataBindings.Add(binding);
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 用于设置自定义列表项目，项目之间用符号“|”隔开
		/// </summary>
		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x06005719 RID: 22297 RVA: 0x0025BE74 File Offset: 0x0025A074
		// (set) Token: 0x0600571A RID: 22298 RVA: 0x0025BEF8 File Offset: 0x0025A0F8
		[oO0oooo("0953")]
		public string ComboList
		{
			get
			{
				string text = "";
				try
				{
					foreach (object value in this.O00O.0OOO00..Items)
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
				if (this.O00O.0OOO00..DataSource == null)
				{
					this.O00O.0OOO00..Items.Clear();
				}
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.O00O.0OOO00..BeginUpdate();
					this.O00O.0OOO00..Items.AddRange(value.Split(new char[]
					{
						'\n',
						'\r',
						'|'
					}, StringSplitOptions.RemoveEmptyEntries));
					this.O00O.0OOO00..EndUpdate();
				}
			}
		}

		/// <summary>
		/// 返回或设置显示列的名称
		/// </summary>
		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x0600571B RID: 22299 RVA: 0x0025BF6F File Offset: 0x0025A16F
		// (set) Token: 0x0600571C RID: 22300 RVA: 0x0025BF7C File Offset: 0x0025A17C
		[oO0oooo("0956")]
		public string DisplayMember
		{
			get
			{
				return this.O00O.0OOO00..DisplayMember;
			}
			set
			{
				this.O00O.0OOO00..DisplayMember = value;
			}
		}

		/// <summary>
		/// 返回或设置取值列的名称
		/// </summary>
		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x0600571D RID: 22301 RVA: 0x0025BF8A File Offset: 0x0025A18A
		// (set) Token: 0x0600571E RID: 22302 RVA: 0x0025BF97 File Offset: 0x0025A197
		[oO0oooo("0957")]
		public string ValueMember
		{
			get
			{
				return this.O00O.0OOO00..ValueMember;
			}
			set
			{
				this.O00O.0OOO00..ValueMember = value;
			}
		}

		/// <summary>
		/// 返回或设置列表项目来源表的名称
		/// </summary>
		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x0600571F RID: 22303 RVA: 0x0025BFA8 File Offset: 0x0025A1A8
		// (set) Token: 0x06005720 RID: 22304 RVA: 0x0025BFE8 File Offset: 0x0025A1E8
		[oO0oooo("0955")]
		public string DataSource
		{
			get
			{
				string result;
				if (this.O00O.0OOO00..DataSource == null)
				{
					result = "";
				}
				else
				{
					result = ((DataView)this.O00O.0OOO00..DataSource).Table.TableName;
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
						this.O00O.0OOO00..DataSource = null;
					}
					else
					{
						DataView dataSource = new DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables[value], this.DataFilter, "", DataViewRowState.CurrentRows);
						string displayMember = this.DisplayMember;
						this.O00O.0OOO00..DataSource = dataSource;
						this.O00O.0OOO00..DisplayMember = displayMember;
					}
					return;
				}
				this.O00O.0OOO00..DataSource = null;
			}
		}

		/// <summary>
		/// 列表项目来自于数据表时，可以用此属性返回或设置过滤条件
		/// </summary>
		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06005721 RID: 22305 RVA: 0x0025C0B4 File Offset: 0x0025A2B4
		// (set) Token: 0x06005722 RID: 22306 RVA: 0x0025C0E9 File Offset: 0x0025A2E9
		public string DataFilter
		{
			get
			{
				string result;
				if (this.O00O.0OOO00..DataSource != null)
				{
					result = ((DataView)this.O00O.0OOO00..DataSource).RowFilter;
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (this.O00O.0OOO00..DataSource != null)
				{
					((DataView)this.O00O.0OOO00..DataSource).RowFilter = value;
				}
			}
		}

		/// <summary>
		/// 列表项目来自于数据表时，可以用此属性返回或设置排序字段
		/// </summary>
		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06005723 RID: 22307 RVA: 0x0025C110 File Offset: 0x0025A310
		// (set) Token: 0x06005724 RID: 22308 RVA: 0x0025C145 File Offset: 0x0025A345
		public string DataSort
		{
			get
			{
				string result;
				if (this.O00O.0OOO00..DataSource != null)
				{
					result = ((DataView)this.O00O.0OOO00..DataSource).Sort;
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (this.O00O.0OOO00..DataSource != null)
				{
					((DataView)this.O00O.0OOO00..DataSource).Sort = value;
				}
			}
		}

		/// <summary>
		/// 是否多列显示
		/// </summary>
		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x06005725 RID: 22309 RVA: 0x0025C16A File Offset: 0x0025A36A
		// (set) Token: 0x06005726 RID: 22310 RVA: 0x0025C177 File Offset: 0x0025A377
		public bool MultiColumn
		{
			get
			{
				return this.O00O.0OOO00..MultiColumn;
			}
			set
			{
				this.O00O.0OOO00..MultiColumn = value;
			}
		}

		/// <summary>
		/// 多列显示时，用于设置每列宽度
		/// </summary>
		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x06005727 RID: 22311 RVA: 0x0025C185 File Offset: 0x0025A385
		// (set) Token: 0x06005728 RID: 22312 RVA: 0x0025C192 File Offset: 0x0025A392
		public int ColumnWidth
		{
			get
			{
				return this.O00O.0OOO00..ColumnWidth;
			}
			set
			{
				this.O00O.0OOO00..ColumnWidth = value;
			}
		}

		/// <summary>
		/// 首次单击某项目时，是否切换该项目的勾选状态
		/// </summary>
		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06005729 RID: 22313 RVA: 0x0025C1A0 File Offset: 0x0025A3A0
		// (set) Token: 0x0600572A RID: 22314 RVA: 0x0025C1AD File Offset: 0x0025A3AD
		[oO0oooo("3103")]
		public bool CheckOnClick
		{
			get
			{
				return this.O00O.0OOO00..CheckOnClick;
			}
			set
			{
				this.O00O.0OOO00..CheckOnClick = value;
			}
		}

		/// <summary>
		/// 值与值之间的分隔符号
		/// </summary>
		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x0600572B RID: 22315 RVA: 0x0025C1BB File Offset: 0x0025A3BB
		// (set) Token: 0x0600572C RID: 22316 RVA: 0x0025C1C8 File Offset: 0x0025A3C8
		public string Separator
		{
			get
			{
				return this.O00O.0OOO00..Separator;
			}
			set
			{
				if (value != null && value.Length == 1)
				{
					this.O00O.0OOO00..Separator = value;
				}
			}
		}

		/// <summary>
		/// 返回或设置列表框已经勾选的值，可用逗号分割多个值
		/// </summary>
		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x0600572D RID: 22317 RVA: 0x0025C1E2 File Offset: 0x0025A3E2
		// (set) Token: 0x0600572E RID: 22318 RVA: 0x0025C1EF File Offset: 0x0025A3EF
		[oO0oooo("0949")]
		public string Value
		{
			get
			{
				return this.O00O.0OOO00..Value;
			}
			set
			{
				this.O00O.0OOO00..Value = value;
			}
		}

		/// <summary>
		/// 自定义列表项目集合
		/// </summary>
		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x0600572F RID: 22319 RVA: 0x0025C1FD File Offset: 0x0025A3FD
		[oO0oooo("0954")]
		public CheckedListBox.ObjectCollection Items
		{
			get
			{
				return this.O00O.0OOO00..Items;
			}
		}

		/// <summary>
		/// 一个集合，包括所有已经勾选的项目
		/// </summary>
		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x06005730 RID: 22320 RVA: 0x0025C20A File Offset: 0x0025A40A
		public CheckedListBox.CheckedItemCollection CheckedItems
		{
			get
			{
				return this.O00O.0OOO00..CheckedItems;
			}
		}

		/// <summary>
		/// 一个集合，包括所有已勾选项目的位置
		/// </summary>
		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x06005731 RID: 22321 RVA: 0x0025C217 File Offset: 0x0025A417
		[oO0oooo("0950")]
		public CheckedListBox.CheckedIndexCollection CheckedIndices
		{
			get
			{
				return this.O00O.0OOO00..CheckedIndices;
			}
		}

		/// <summary>
		/// 返回或设置选定项目的位置
		/// </summary>
		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x06005732 RID: 22322 RVA: 0x0025C224 File Offset: 0x0025A424
		// (set) Token: 0x06005733 RID: 22323 RVA: 0x0025C231 File Offset: 0x0025A431
		[oO0oooo("0958")]
		public int SelectedIndex
		{
			get
			{
				return this.O00O.0OOO00..SelectedIndex;
			}
			set
			{
				this.O00O.0OOO00..SelectedIndex = value;
			}
		}

		/// <summary>
		/// 返回或设置选定项目
		/// </summary>
		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x06005734 RID: 22324 RVA: 0x0025C240 File Offset: 0x0025A440
		// (set) Token: 0x06005735 RID: 22325 RVA: 0x0025C2A8 File Offset: 0x0025A4A8
		[oO0oooo("0959")]
		public object SelectedItem
		{
			get
			{
				object result;
				if (this.O00O.0OOO00..DataSource == null)
				{
					result = this.O00O.0OOO00..SelectedItem;
				}
				else if (this.O00O.0OOO00..SelectedIndex < 0)
				{
					result = null;
				}
				else
				{
					result = new DataRow(((DataView)this.O00O.0OOO00..DataSource)[this.O00O.0OOO00..SelectedIndex].Row);
				}
				return result;
			}
			set
			{
				if (value == null)
				{
					this.O00O.0OOO00..SelectedIndex = -1;
					return;
				}
				if (this.O00O.0OOO00..DataSource == null)
				{
					this.O00O.0OOO00..SelectedItem = RuntimeHelpers.GetObjectValue(value);
					return;
				}
				DataRow dataRow = (DataRow)value;
				int num = ((DataView)this.O00O.0OOO00..DataSource).Find(RuntimeHelpers.GetObjectValue(dataRow[this.ValueMember]));
				if (num >= 0)
				{
					this.SelectedIndex = num;
				}
			}
		}

		/// <summary>
		/// 返回或设置选定的值
		/// </summary>
		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x06005736 RID: 22326 RVA: 0x0025C31F File Offset: 0x0025A51F
		// (set) Token: 0x06005737 RID: 22327 RVA: 0x0025C32C File Offset: 0x0025A52C
		[oO0oooo("0960")]
		public object SelectedValue
		{
			get
			{
				return this.O00O.0OOO00..SelectedValue2;
			}
			set
			{
				this.O00O.0OOO00..SelectedValue2 = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 设置指定项目的勾选状态
		/// </summary>
		/// <param name="Index">项目位置</param>
		/// <param name="Checked">是否勾选</param>
		// Token: 0x06005738 RID: 22328 RVA: 0x0025C33F File Offset: 0x0025A53F
		[oO0oooo("0951")]
		public void SetItemChecked(int Index, bool Checked)
		{
			this.O00O.0OOO00..SetItemChecked(Index, Checked);
		}

		/// <summary>
		/// 获取选定项目的勾选状态
		/// </summary>
		/// <param name="Index">项目位置</param>
		// Token: 0x06005739 RID: 22329 RVA: 0x0025C34E File Offset: 0x0025A54E
		[oO0oooo("0952")]
		public bool GetItemChecked(int Index)
		{
			return this.O00O.0OOO00..GetItemChecked(Index);
		}

		// Token: 0x0600573A RID: 22330 RVA: 0x0025C35C File Offset: 0x0025A55C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x040022CD RID: 8909
		private CustomCheckedListBox <<EMPTY_NAME>>;
	}
}
