using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 组合框
	/// </summary>
	// Token: 0x0200051E RID: 1310
	[ComVisible(true)]
	public class ComboBox : Control, OoO_
	{
		// Token: 0x06005749 RID: 22345 RVA: 0x0025C4EB File Offset: 0x0025A6EB
		internal ComboBox(OoOO0Oo_oo0oO A_0) : base(A_0, ControlTypeEnum.ComboBox)
		{
			this.o_Oo._O_00000_. = A_0;
		}

		/// <summary>
		/// 文本内容
		/// </summary>
		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x0600574A RID: 22346 RVA: 0x0025C4FC File Offset: 0x0025A6FC
		// (set) Token: 0x0600574B RID: 22347 RVA: 0x0025C509 File Offset: 0x0025A709
		[oO0oooo("0750")]
		public string Text
		{
			get
			{
				return this.o_Oo._O_00000_..Text;
			}
			set
			{
				this.o_Oo._O_00000_..Value = value;
			}
		}

		/// <summary>
		/// 返回或设置输入框的值
		/// </summary>
		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x0600574C RID: 22348 RVA: 0x0025C518 File Offset: 0x0025A718
		// (set) Token: 0x0600574D RID: 22349 RVA: 0x0025C553 File Offset: 0x0025A753
		[oO0oooo("0751")]
		public object Value
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.o_Oo._O_00000_..Value);
				object result;
				if (objectValue != null && Operators.CompareString(objectValue.ToString(), "", true) == 0)
				{
					result = null;
				}
				else
				{
					result = objectValue;
				}
				return result;
			}
			set
			{
				this.o_Oo._O_00000_..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x0600574E RID: 22350 RVA: 0x0025C566 File Offset: 0x0025A766
		// (set) Token: 0x0600574F RID: 22351 RVA: 0x0025C573 File Offset: 0x0025A773
		[oO0oooo("0749")]
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.o_Oo._O_00000_..O__oo_OO.O_.();
			}
			set
			{
				this.o_Oo._O_00000_..o__0_OooO0._.(value);
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x06005750 RID: 22352 RVA: 0x0025C581 File Offset: 0x0025A781
		// (set) Token: 0x06005751 RID: 22353 RVA: 0x0025C58C File Offset: 0x0025A78C
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.o_Oo._O_00000_..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.ComboBox, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.o_Oo._O_00000_..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text);
								this.o_Oo._O_00000_..DataType = OO_00oOO.Vars.VariableTable.Columns[text].DataType;
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value2", value);
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
							if (binding != null)
							{
								this.o_Oo._O_00000_..DataBindings.Add(binding);
								if (this.o_Oo._O_00000_..DataBindings.Count > 0)
								{
									int num = value.LastIndexOf('.');
									string a_ = value.Substring(0, num);
									string name = value.Substring(num + 1);
									this.o_Oo._O_00000_..DataType = OO_00oOO.Tables[a_].DataTable.BaseTable.Columns[name].DataType;
								}
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 文本对齐方式
		/// </summary>
		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x06005752 RID: 22354 RVA: 0x0025C6F4 File Offset: 0x0025A8F4
		// (set) Token: 0x06005753 RID: 22355 RVA: 0x0025C701 File Offset: 0x0025A901
		[oO0oooo("1861")]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.o_Oo._O_00000_..TextAlign;
			}
			set
			{
				this.o_Oo._O_00000_..TextAlign = value;
			}
		}

		/// <summary>
		/// 是否自动更改输入内容的大小写
		/// </summary>
		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x06005754 RID: 22356 RVA: 0x0025C70F File Offset: 0x0025A90F
		// (set) Token: 0x06005755 RID: 22357 RVA: 0x0025C71C File Offset: 0x0025A91C
		public CharacterCasing CharacterCasing
		{
			get
			{
				return this.o_Oo._O_00000_..CharacterCasing;
			}
			set
			{
				this.o_Oo._O_00000_..CharacterCasing = value;
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x0025C72C File Offset: 0x0025A92C
		// (set) Token: 0x06005757 RID: 22359 RVA: 0x0025C73A File Offset: 0x0025A93A
		public VisualStyle VisualStyle
		{
			get
			{
				VisualStyle result;
				return result;
			}
			set
			{
			}
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06005758 RID: 22360 RVA: 0x0025C73C File Offset: 0x0025A93C
		// (set) Token: 0x06005759 RID: 22361 RVA: 0x0025C749 File Offset: 0x0025A949
		public BorderStyle BorderStyle
		{
			get
			{
				return this.o_Oo._O_00000_..BorderStyle;
			}
			set
			{
				this.o_Oo._O_00000_..BorderStyle = value;
			}
		}

		/// <summary>
		/// 边框颜色
		/// </summary>
		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x0600575A RID: 22362 RVA: 0x0025C757 File Offset: 0x0025A957
		// (set) Token: 0x0600575B RID: 22363 RVA: 0x0025C764 File Offset: 0x0025A964
		public Color BorderColor
		{
			get
			{
				return this.o_Oo._O_00000_..BorderColor;
			}
			set
			{
				this.o_Oo._O_00000_..BorderColor = value;
			}
		}

		/// <summary>
		/// 可输入内容的最大长度
		/// </summary>
		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x0600575C RID: 22364 RVA: 0x0025C772 File Offset: 0x0025A972
		// (set) Token: 0x0600575D RID: 22365 RVA: 0x0025C77F File Offset: 0x0025A97F
		public int MaxLength
		{
			get
			{
				return this.o_Oo._O_00000_..MaxLength;
			}
			set
			{
				this.o_Oo._O_00000_..MaxLength = value;
			}
		}

		/// <summary>
		/// 密码字符
		/// </summary>
		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x0600575E RID: 22366 RVA: 0x0025C78D File Offset: 0x0025A98D
		// (set) Token: 0x0600575F RID: 22367 RVA: 0x0025C79A File Offset: 0x0025A99A
		[oO0oooo("1865")]
		public char PasswordChar
		{
			get
			{
				return this.o_Oo._O_00000_..PasswordChar;
			}
			set
			{
				this.o_Oo._O_00000_..PasswordChar = value;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06005760 RID: 22368 RVA: 0x0025C7A8 File Offset: 0x0025A9A8
		// (set) Token: 0x06005761 RID: 22369 RVA: 0x0025C7B5 File Offset: 0x0025A9B5
		public override Color BackColor
		{
			get
			{
				return this.o_Oo._O_00000_..BackColor;
			}
			set
			{
				this.o_Oo._O_00000_..BackColor = value;
			}
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06005762 RID: 22370 RVA: 0x0025C7C3 File Offset: 0x0025A9C3
		// (set) Token: 0x06005763 RID: 22371 RVA: 0x0025C7D0 File Offset: 0x0025A9D0
		public override Color ForeColor
		{
			get
			{
				return this.o_Oo._O_00000_..ForeColor;
			}
			set
			{
				this.o_Oo._O_00000_..ForeColor = value;
			}
		}

		/// <summary>
		/// 输入掩码
		/// </summary>
		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06005764 RID: 22372 RVA: 0x0025C7DE File Offset: 0x0025A9DE
		// (set) Token: 0x06005765 RID: 22373 RVA: 0x0025C7EB File Offset: 0x0025A9EB
		[oO0oooo("1866")]
		public string EditMask
		{
			get
			{
				return this.o_Oo._O_00000_..EditMask;
			}
			set
			{
				this.o_Oo._O_00000_..EditMask = value;
			}
		}

		/// <summary>
		/// 格式符号
		/// </summary>
		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x0025C7F9 File Offset: 0x0025A9F9
		// (set) Token: 0x06005767 RID: 22375 RVA: 0x0025C80C File Offset: 0x0025AA0C
		[oO0oooo("1867")]
		public string FormatString
		{
			get
			{
				return this.o_Oo._O_00000_..DisplayFormat.CustomFormat;
			}
			set
			{
				this.o_Oo._O_00000_..DisplayFormat.CustomFormat = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.o_Oo._O_00000_..DisplayFormat.FormatType = FormatTypeEnum.CustomFormat;
					return;
				}
				this.o_Oo._O_00000_..DisplayFormat.FormatType = FormatTypeEnum.DefaultFormat;
			}
		}

		/// <summary>
		/// 是否自动删除前导空格
		/// </summary>
		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06005768 RID: 22376 RVA: 0x0025C85C File Offset: 0x0025AA5C
		// (set) Token: 0x06005769 RID: 22377 RVA: 0x0025C869 File Offset: 0x0025AA69
		public bool TrimStart
		{
			get
			{
				return this.o_Oo._O_00000_..TrimStart;
			}
			set
			{
				this.o_Oo._O_00000_..TrimStart = value;
			}
		}

		/// <summary>
		/// 是否自动删除尾随空格
		/// </summary>
		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x0600576A RID: 22378 RVA: 0x0025C877 File Offset: 0x0025AA77
		// (set) Token: 0x0600576B RID: 22379 RVA: 0x0025C884 File Offset: 0x0025AA84
		public bool TrimEnd
		{
			get
			{
				return this.o_Oo._O_00000_..TrimStart;
			}
			set
			{
				this.o_Oo._O_00000_..TrimEnd = value;
			}
		}

		/// <summary>
		/// 是否允许用户输入不在列表项目中的内容
		/// </summary>
		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x0600576C RID: 22380 RVA: 0x0025C892 File Offset: 0x0025AA92
		// (set) Token: 0x0600576D RID: 22381 RVA: 0x0025C89F File Offset: 0x0025AA9F
		public bool AllowEditValue
		{
			get
			{
				return this.o_Oo._O_00000_..oo0.ooo.();
			}
			set
			{
				this.o_Oo._O_00000_..o.Oo0.(value);
			}
		}

		/// <summary>
		/// 是否启用输入助手
		/// </summary>
		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x0600576E RID: 22382 RVA: 0x0025C8AD File Offset: 0x0025AAAD
		// (set) Token: 0x0600576F RID: 22383 RVA: 0x0025C8BD File Offset: 0x0025AABD
		[oO0oooo("0943")]
		public bool AutoComplete
		{
			get
			{
				return this.o_Oo._O_00000_..AutoCompleteMode == AutoCompleteMode.SuggestAppend;
			}
			set
			{
				if (value)
				{
					this.o_Oo._O_00000_..AutoCompleteMode = AutoCompleteMode.SuggestAppend;
					return;
				}
				this.o_Oo._O_00000_..AutoCompleteMode = AutoCompleteMode.None;
			}
		}

		/// <summary>
		/// 下拉宽度
		/// </summary>
		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06005770 RID: 22384 RVA: 0x0025C8DB File Offset: 0x0025AADB
		// (set) Token: 0x06005771 RID: 22385 RVA: 0x0025C8E8 File Offset: 0x0025AAE8
		public int DropDownWidth
		{
			get
			{
				return this.o_Oo._O_00000_..O.oOo.();
			}
			set
			{
				this.o_Oo._O_00000_..O_.oO_O0.(value);
			}
		}

		/// <summary>
		/// 下拉高度
		/// </summary>
		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06005772 RID: 22386 RVA: 0x0025C8F6 File Offset: 0x0025AAF6
		// (set) Token: 0x06005773 RID: 22387 RVA: 0x0025C903 File Offset: 0x0025AB03
		public int DropDownHeight
		{
			get
			{
				return this.o_Oo._O_00000_..O_o0o0_Oo.0.();
			}
			set
			{
				this.o_Oo._O_00000_..o.Oo0.(value);
			}
		}

		/// <summary>
		/// 下拉列表显示的最大项目数
		/// </summary>
		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06005774 RID: 22388 RVA: 0x0025C911 File Offset: 0x0025AB11
		// (set) Token: 0x06005775 RID: 22389 RVA: 0x0025C91E File Offset: 0x0025AB1E
		public int MaxDropDownItems
		{
			get
			{
				return this.o_Oo._O_00000_..o0Oo_.o_.();
			}
			set
			{
				this.o_Oo._O_00000_..o__0_OooO0._.(value);
			}
		}

		/// <summary>
		/// 用于设置自定义列表项目，项目之间用符号“|”隔开
		/// </summary>
		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06005776 RID: 22390 RVA: 0x0025C92C File Offset: 0x0025AB2C
		// (set) Token: 0x06005777 RID: 22391 RVA: 0x0025C9B0 File Offset: 0x0025ABB0
		[oO0oooo("0925")]
		public string ComboList
		{
			get
			{
				string text = "";
				try
				{
					foreach (object value in this.o_Oo._O_00000_..O_o0o0_Oo.0.())
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
				this.o_Oo._O_00000_..O_o0o0_Oo.0.().Clear();
				this.o_Oo._O_00000_..o_0.__. = false;
				if (Operators.CompareString(value, "", true) > 0)
				{
					string[] array = value.Split(new char[]
					{
						'\n',
						'\r',
						'|'
					}, StringSplitOptions.RemoveEmptyEntries);
					this.o_Oo._O_00000_..O_o0o0_Oo.0.().AddRange(array);
					if (this.AutoComplete && this.AllowEditValue)
					{
						this.o_Oo._O_00000_..AutoCompleteSource = AutoCompleteSource.CustomSource;
						this.o_Oo._O_00000_..AutoCompleteMode = AutoCompleteMode.SuggestAppend;
						this.o_Oo._O_00000_..AutoCompleteCustomSource.Clear();
						this.o_Oo._O_00000_..AutoCompleteCustomSource.AddRange(array);
					}
				}
			}
		}

		/// <summary>
		/// 返回或设置显示列的名称
		/// </summary>
		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x0025CA5C File Offset: 0x0025AC5C
		// (set) Token: 0x06005779 RID: 22393 RVA: 0x0025CA69 File Offset: 0x0025AC69
		[oO0oooo("0927")]
		public string DisplayMember
		{
			get
			{
				return this.o_Oo._O_00000_..O_o0o0_Oo.0.();
			}
			set
			{
				this.o_Oo._O_00000_..o_O0.OO0o0O0o.(value);
			}
		}

		/// <summary>
		/// 返回或设置取值列的名称
		/// </summary>
		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x0600577A RID: 22394 RVA: 0x0025CA77 File Offset: 0x0025AC77
		// (set) Token: 0x0600577B RID: 22395 RVA: 0x0025CA84 File Offset: 0x0025AC84
		[oO0oooo("0928")]
		public string ValueMember
		{
			get
			{
				return this.o_Oo._O_00000_..Ooo_O__.0o.();
			}
			set
			{
				if (this.o_Oo._O_00000_..OO0._0O.() != null)
				{
					DataView dataView = (DataView)this.o_Oo._O_00000_..OO0._0O.();
					if (dataView.Table.Columns.Contains(value))
					{
						dataView.Sort = value;
					}
				}
				this.o_Oo._O_00000_..O.__.(value);
			}
		}

		/// <summary>
		/// 返回或设置列表项目来源表的名称
		/// </summary>
		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x0600577C RID: 22396 RVA: 0x0025CAD8 File Offset: 0x0025ACD8
		// (set) Token: 0x0600577D RID: 22397 RVA: 0x0025CB18 File Offset: 0x0025AD18
		[oO0oooo("0926")]
		public string DataSource
		{
			get
			{
				string result;
				if (this.o_Oo._O_00000_..OO0._0O.() != null)
				{
					result = ((DataView)this.o_Oo._O_00000_..OO0._0O.()).Table.TableName;
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				this.o_Oo._O_00000_..o_0.__. = false;
				if (Operators.CompareString(value, "", true) > 0 && O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(value))
				{
					DataTable dataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables[value];
					if (Operators.CompareString(this.ValueMember, "", true) == 0 || !dataTable.Columns.Contains(this.ValueMember))
					{
						this.o_Oo._O_00000_..o_O0.OO0o0O0o.(null);
					}
					else
					{
						DataView a_ = new DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables[value], this.DataFilter, this.ValueMember, DataViewRowState.CurrentRows);
						this.o_Oo._O_00000_..o_O0.OO0o0O0o.(a_);
						if (this.AutoComplete && this.AllowEditValue)
						{
							this.o_Oo._O_00000_..AutoCompleteSource = AutoCompleteSource.CustomSource;
							this.o_Oo._O_00000_..AutoCompleteMode = AutoCompleteMode.SuggestAppend;
							this.o_Oo._O_00000_..o_0.__. = true;
						}
					}
					return;
				}
				this.o_Oo._O_00000_..o_O0.OO0o0O0o.(null);
			}
		}

		/// <summary>
		/// 列表项目来自于数据表时，可以用此属性返回或设置过滤条件
		/// </summary>
		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x0600577E RID: 22398 RVA: 0x0025CC14 File Offset: 0x0025AE14
		// (set) Token: 0x0600577F RID: 22399 RVA: 0x0025CC49 File Offset: 0x0025AE49
		public string DataFilter
		{
			get
			{
				string result;
				if (this.o_Oo._O_00000_..OO0._0O.() != null)
				{
					result = ((DataView)this.o_Oo._O_00000_..OO0._0O.()).RowFilter;
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (this.o_Oo._O_00000_..OO0._0O.() != null)
				{
					((DataView)this.o_Oo._O_00000_..OO0._0O.()).RowFilter = value;
				}
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06005780 RID: 22400 RVA: 0x0025CC6E File Offset: 0x0025AE6E
		// (set) Token: 0x06005781 RID: 22401 RVA: 0x0025CC7D File Offset: 0x0025AE7D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string DataSort
		{
			get
			{
				this.o_Oo._O_00000_..OO0._0O.();
				return null;
			}
			set
			{
				this.o_Oo._O_00000_..OO0._0O.();
			}
		}

		/// <summary>
		/// 是否多列显示
		/// </summary>
		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06005782 RID: 22402 RVA: 0x0025CC8B File Offset: 0x0025AE8B
		// (set) Token: 0x06005783 RID: 22403 RVA: 0x0025CC98 File Offset: 0x0025AE98
		[oO0oooo("0946")]
		public bool MultiColumn
		{
			get
			{
				return this.o_Oo._O_00000_..o0Oo_.o_.();
			}
			set
			{
				this.o_Oo._O_00000_..O_.oOO00.(value);
			}
		}

		/// <summary>
		/// 多列显示时，用于设置每列宽度
		/// </summary>
		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06005784 RID: 22404 RVA: 0x0025CCA6 File Offset: 0x0025AEA6
		// (set) Token: 0x06005785 RID: 22405 RVA: 0x0025CCB3 File Offset: 0x0025AEB3
		[oO0oooo("0946")]
		public int ColumnWidth
		{
			get
			{
				return this.o_Oo._O_00000_..o.ooO.();
			}
			set
			{
				if (value > 0)
				{
					this.o_Oo._O_00000_..o_O0.OO0o0O0o.(value);
				}
			}
		}

		/// <summary>
		/// 默认选中范围
		/// </summary>
		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06005786 RID: 22406 RVA: 0x0025CCC5 File Offset: 0x0025AEC5
		// (set) Token: 0x06005787 RID: 22407 RVA: 0x0025CCD2 File Offset: 0x0025AED2
		public InitialSelectionEnum InitialSelection
		{
			get
			{
				return this.o_Oo._O_00000_..InitialSelection;
			}
			set
			{
				this.o_Oo._O_00000_..InitialSelection = value;
			}
		}

		/// <summary>
		/// 项目集合
		/// </summary>
		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06005788 RID: 22408 RVA: 0x0025CCE0 File Offset: 0x0025AEE0
		[oO0oooo("0934")]
		public ListBox.ObjectCollection Items
		{
			get
			{
				return this.o_Oo._O_00000_..O_o0o0_Oo.0.();
			}
		}

		/// <summary>
		/// 所输入或所选择的项目，在项目集合中的位置
		/// </summary>
		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06005789 RID: 22409 RVA: 0x0025CCED File Offset: 0x0025AEED
		// (set) Token: 0x0600578A RID: 22410 RVA: 0x0025CCFA File Offset: 0x0025AEFA
		[oO0oooo("0930")]
		public int SelectedIndex
		{
			get
			{
				return this.o_Oo._O_00000_..Ooo_O__.0o.();
			}
			set
			{
				this.o_Oo._O_00000_..O_.oOO00.(value);
			}
		}

		/// <summary>
		/// 所选择的项目
		/// </summary>
		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600578B RID: 22411 RVA: 0x0025CD08 File Offset: 0x0025AF08
		// (set) Token: 0x0600578C RID: 22412 RVA: 0x0025CD15 File Offset: 0x0025AF15
		[oO0oooo("0932")]
		public object SelectedItem
		{
			get
			{
				return this.o_Oo._O_00000_..Ooo_O__.0o.();
			}
			set
			{
				this.o_Oo._O_00000_..o.OOoOo_00O.(RuntimeHelpers.GetObjectValue(value));
			}
		}

		/// <summary>
		/// 返回或设置组合框的值
		/// </summary>
		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x0600578D RID: 22413 RVA: 0x0025CD28 File Offset: 0x0025AF28
		// (set) Token: 0x0600578E RID: 22414 RVA: 0x0025CD35 File Offset: 0x0025AF35
		[oO0oooo("0933")]
		public object SelectedValue
		{
			get
			{
				return this.o_Oo._O_00000_..O__oo_OO.O_.();
			}
			set
			{
				this.o_Oo._O_00000_..o__0_OooO0._.(RuntimeHelpers.GetObjectValue(value));
			}
		}

		/// <summary>
		/// 返回或设置输入框中选定的文本
		/// </summary>
		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x0600578F RID: 22415 RVA: 0x0025CD48 File Offset: 0x0025AF48
		// (set) Token: 0x06005790 RID: 22416 RVA: 0x0025CD55 File Offset: 0x0025AF55
		[oO0oooo("0740")]
		public string SelectedText
		{
			get
			{
				return this.o_Oo._O_00000_..SelectedText;
			}
			set
			{
				this.o_Oo._O_00000_..SelectedText = value;
			}
		}

		/// <summary>
		/// 返回文本框中选定字符的起始位置
		/// </summary>
		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06005791 RID: 22417 RVA: 0x0025CD63 File Offset: 0x0025AF63
		// (set) Token: 0x06005792 RID: 22418 RVA: 0x0025CD70 File Offset: 0x0025AF70
		public int SelectionStart
		{
			get
			{
				return this.o_Oo._O_00000_..SelectionStart;
			}
			set
			{
				this.o_Oo._O_00000_..SelectionStart = value;
			}
		}

		/// <summary>
		/// 返回或设置输入框中选定字符的长度
		/// </summary>
		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06005793 RID: 22419 RVA: 0x0025CD7E File Offset: 0x0025AF7E
		// (set) Token: 0x06005794 RID: 22420 RVA: 0x0025CD8B File Offset: 0x0025AF8B
		public int SelectionLength
		{
			get
			{
				return this.o_Oo._O_00000_..SelectionLength;
			}
			set
			{
				this.o_Oo._O_00000_..SelectionLength = value;
			}
		}

		/// <summary>
		/// 选定输入框中的全部内容
		/// </summary>
		// Token: 0x06005795 RID: 22421 RVA: 0x0025CD99 File Offset: 0x0025AF99
		public void SelectAll()
		{
			this.o_Oo._O_00000_..SelectAll();
		}

		/// <summary>
		/// 复制选定内容到剪贴板
		/// </summary>
		// Token: 0x06005796 RID: 22422 RVA: 0x0025CDA6 File Offset: 0x0025AFA6
		public void Copy()
		{
			this.o_Oo._O_00000_..Copy();
		}

		/// <summary>
		/// 剪切选定内容到剪贴板
		/// </summary>
		// Token: 0x06005797 RID: 22423 RVA: 0x0025CDB3 File Offset: 0x0025AFB3
		public void Cut()
		{
			this.o_Oo._O_00000_..Cut();
		}

		/// <summary>
		/// 用剪贴板内容替换输入框中的选定内容
		/// </summary>
		// Token: 0x06005798 RID: 22424 RVA: 0x0025CDC0 File Offset: 0x0025AFC0
		public void Paste()
		{
			this.o_Oo._O_00000_..Paste();
		}

		/// <summary>
		/// 撤销上次操作
		/// </summary>
		// Token: 0x06005799 RID: 22425 RVA: 0x0025CDCD File Offset: 0x0025AFCD
		public void Undo()
		{
			this.o_Oo._O_00000_..Undo();
		}

		/// <summary>
		/// 重置文本内容
		/// </summary>
		// Token: 0x0600579A RID: 22426 RVA: 0x0025CDDA File Offset: 0x0025AFDA
		public void ResetText()
		{
			this.o_Oo._O_00000_..ResetText();
		}

		/// <summary>
		/// 打开下拉列表
		/// </summary>
		// Token: 0x0600579B RID: 22427 RVA: 0x0025CDE7 File Offset: 0x0025AFE7
		public void OpenDropDown()
		{
			this.o_Oo._O_00000_..OpenDropDown();
		}

		/// <summary>
		/// 下拉列表是否已经打开
		/// </summary>
		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x0600579C RID: 22428 RVA: 0x0025CDF4 File Offset: 0x0025AFF4
		public bool DroppedDown
		{
			get
			{
				return this.o_Oo._O_00000_..DroppedDown;
			}
		}

		/// <summary>
		/// 关闭下拉列表
		/// </summary>
		// Token: 0x0600579D RID: 22429 RVA: 0x0025CE01 File Offset: 0x0025B001
		public void CloseDropDown()
		{
			this.o_Oo._O_00000_..CloseDropDown();
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x0025CE0E File Offset: 0x0025B00E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		/// <summary>
		/// 设置项目间隔，单位为像素
		/// </summary>
		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x0025CE17 File Offset: 0x0025B017
		// (set) Token: 0x060057A0 RID: 22432 RVA: 0x0025CE24 File Offset: 0x0025B024
		public int ItemSpacing
		{
			get
			{
				return this.o_Oo._O_00000_..oo_OO_oo.oO_.();
			}
			set
			{
				this.o_Oo._O_00000_..O_o0O.O_O.(value);
			}
		}

		// Token: 0x040022CF RID: 8911
		private OoOO0Oo_oo0oO <<EMPTY_NAME>>;
	}
}
