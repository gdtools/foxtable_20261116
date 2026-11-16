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
	/// 复选组合框
	/// </summary>
	// Token: 0x0200051B RID: 1307
	[ComVisible(true)]
	public class CheckedComboBox : Control, OoO_
	{
		// Token: 0x060056BB RID: 22203 RVA: 0x0025B4C8 File Offset: 0x002596C8
		internal CheckedComboBox(O0oo000oO0oo_ A_0) : base(A_0, ControlTypeEnum.CheckedComboBox)
		{
			this.o0.00O. = A_0;
			this.o0.00O..InitialSelection = InitialSelectionEnum.CaretAtStart;
		}

		/// <summary>
		/// 文本内容
		/// </summary>
		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x060056BC RID: 22204 RVA: 0x0025B4E6 File Offset: 0x002596E6
		// (set) Token: 0x060056BD RID: 22205 RVA: 0x0025B4F3 File Offset: 0x002596F3
		[oO0oooo("0750")]
		public string Text
		{
			get
			{
				return this.o0.00O..Text;
			}
			set
			{
				this.o0.00O..Value = value;
			}
		}

		/// <summary>
		/// 返回或设置输入框的值
		/// </summary>
		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x060056BE RID: 22206 RVA: 0x0025B504 File Offset: 0x00259704
		// (set) Token: 0x060056BF RID: 22207 RVA: 0x0025B53F File Offset: 0x0025973F
		[oO0oooo("0751")]
		public object Value
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.o0.00O..Value);
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
				this.o0.00O..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x060056C0 RID: 22208 RVA: 0x0025B552 File Offset: 0x00259752
		// (set) Token: 0x060056C1 RID: 22209 RVA: 0x0025B55F File Offset: 0x0025975F
		[oO0oooo("0749")]
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.o0.00O..o_0Oo.o_.();
			}
			set
			{
				this.o0.00O..O.o00OOo_.(value);
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x060056C2 RID: 22210 RVA: 0x0025B56D File Offset: 0x0025976D
		// (set) Token: 0x060056C3 RID: 22211 RVA: 0x0025B578 File Offset: 0x00259778
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.o0.00O..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.CheckedComboBox, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.o0.00O..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text);
								this.o0.00O..DataType = OO_00oOO.Vars.VariableTable.Columns[text].DataType;
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value2", value);
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
							if (binding != null)
							{
								this.o0.00O..DataBindings.Add(binding);
							}
							this.o0.00O..DataType = base.BindCol.DataCol.BaseColumn.DataType;
						}
					}
				}
			}
		}

		/// <summary>
		/// 是否允许用户输入不在列表项目中的内容
		/// </summary>
		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x060056C4 RID: 22212 RVA: 0x0025B6A0 File Offset: 0x002598A0
		// (set) Token: 0x060056C5 RID: 22213 RVA: 0x0025B6AD File Offset: 0x002598AD
		public bool AllowEditValue
		{
			get
			{
				return this.o0.00O..OOo0_o.O00__.();
			}
			set
			{
				this.o0.00O..O00O.ooOO0.(value);
			}
		}

		/// <summary>
		/// 下拉宽度
		/// </summary>
		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x060056C6 RID: 22214 RVA: 0x0025B6BB File Offset: 0x002598BB
		// (set) Token: 0x060056C7 RID: 22215 RVA: 0x0025B6C8 File Offset: 0x002598C8
		public int DropDownWidth
		{
			get
			{
				return this.o0.00O..o__0o0o_.OO0O_.();
			}
			set
			{
				this.o0.00O..o_.0__Oo____O.(value);
			}
		}

		/// <summary>
		/// 下拉高度
		/// </summary>
		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x060056C8 RID: 22216 RVA: 0x0025B6D6 File Offset: 0x002598D6
		// (set) Token: 0x060056C9 RID: 22217 RVA: 0x0025B6E3 File Offset: 0x002598E3
		public int DropDownHeight
		{
			get
			{
				return this.o0.00O..O0O.o.();
			}
			set
			{
				this.o0.00O..o.oOOO_0_.(value);
			}
		}

		/// <summary>
		/// 下拉列表显示的最大项目数
		/// </summary>
		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x060056CA RID: 22218 RVA: 0x0025B6F1 File Offset: 0x002598F1
		// (set) Token: 0x060056CB RID: 22219 RVA: 0x0025B6FE File Offset: 0x002598FE
		public int MaxDropDownItems
		{
			get
			{
				return this.o0.00O..O_oOo.o0Oo.();
			}
			set
			{
				this.o0.00O..O.o00OOo_.(value);
			}
		}

		/// <summary>
		/// 用于设置自定义列表项目，项目之间用符号“|”隔开
		/// </summary>
		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x060056CC RID: 22220 RVA: 0x0025B70C File Offset: 0x0025990C
		// (set) Token: 0x060056CD RID: 22221 RVA: 0x0025B790 File Offset: 0x00259990
		[oO0oooo("0925")]
		public string ComboList
		{
			get
			{
				string text = "";
				try
				{
					foreach (object value in this.o0.00O..o_0Oo.o_.())
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
				if (this.o0.00O..O_.0.() == null)
				{
					this.o0.00O..o_0Oo.o_.().Clear();
				}
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.o0.00O..o_0Oo.o_.().AddRange(value.Split(new char[]
					{
						'\n',
						'\r',
						'|'
					}, StringSplitOptions.RemoveEmptyEntries));
				}
			}
		}

		/// <summary>
		/// 返回或设置显示列的名称
		/// </summary>
		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x060056CE RID: 22222 RVA: 0x0025B7F1 File Offset: 0x002599F1
		// (set) Token: 0x060056CF RID: 22223 RVA: 0x0025B7FE File Offset: 0x002599FE
		[oO0oooo("0927")]
		public string DisplayMember
		{
			get
			{
				return this.o0.00O..O0O.o.();
			}
			set
			{
				this.o0.00O..OoO.0oo_Oo_.(value);
			}
		}

		/// <summary>
		/// 返回或设置取值列的名称
		/// </summary>
		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x060056D0 RID: 22224 RVA: 0x0025B80C File Offset: 0x00259A0C
		// (set) Token: 0x060056D1 RID: 22225 RVA: 0x0025B81C File Offset: 0x00259A1C
		[oO0oooo("0928")]
		public string ValueMember
		{
			get
			{
				return this.o0.00O..OOooOOO.O0.();
			}
			set
			{
				if (this.o0.00O..O_.0.() != null)
				{
					DataView dataView = (DataView)this.o0.00O..O_.0.();
					if (dataView.Table.Columns.Contains(value))
					{
						dataView.Sort = value;
					}
				}
				this.o0.00O..o0OO.O.(value);
			}
		}

		/// <summary>
		/// 返回或设置列表项目来源表的名称
		/// </summary>
		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x060056D2 RID: 22226 RVA: 0x0025B870 File Offset: 0x00259A70
		// (set) Token: 0x060056D3 RID: 22227 RVA: 0x0025B8B0 File Offset: 0x00259AB0
		[oO0oooo("0926")]
		public string DataSource
		{
			get
			{
				string result;
				if (this.o0.00O..O_.0.() == null)
				{
					result = "";
				}
				else
				{
					result = ((DataView)this.o0.00O..O_.0.()).Table.TableName;
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
						this.o0.00O..OoO.0oo_Oo_.(null);
					}
					else
					{
						DataView a_ = new DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables[value], this.DataFilter, this.ValueMember, DataViewRowState.CurrentRows);
						this.o0.00O..OoO.0oo_Oo_.(a_);
					}
					return;
				}
				this.o0.00O..OoO.0oo_Oo_.(null);
			}
		}

		/// <summary>
		/// 列表项目来自于数据表时，可以用此属性返回或设置过滤条件
		/// </summary>
		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x060056D4 RID: 22228 RVA: 0x0025B968 File Offset: 0x00259B68
		// (set) Token: 0x060056D5 RID: 22229 RVA: 0x0025B99D File Offset: 0x00259B9D
		public string DataFilter
		{
			get
			{
				string result;
				if (this.o0.00O..O_.0.() != null)
				{
					result = ((DataView)this.o0.00O..O_.0.()).RowFilter;
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (this.o0.00O..O_.0.() != null)
				{
					((DataView)this.o0.00O..O_.0.()).RowFilter = value;
				}
			}
		}

		/// <summary>
		/// 是否多列显示
		/// </summary>
		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x060056D6 RID: 22230 RVA: 0x0025B9C2 File Offset: 0x00259BC2
		// (set) Token: 0x060056D7 RID: 22231 RVA: 0x0025B9CF File Offset: 0x00259BCF
		[oO0oooo("0946")]
		public bool MultiColumn
		{
			get
			{
				return this.o0.00O..oOO0_o._0O00.();
			}
			set
			{
				this.o0.00O..o_.0__Oo____O.(value);
			}
		}

		/// <summary>
		/// 多列显示时，用于设置每列宽度
		/// </summary>
		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x060056D8 RID: 22232 RVA: 0x0025B9DD File Offset: 0x00259BDD
		// (set) Token: 0x060056D9 RID: 22233 RVA: 0x0025B9EA File Offset: 0x00259BEA
		[oO0oooo("0946")]
		public int ColumnWidth
		{
			get
			{
				return this.o0.00O..O_.0.();
			}
			set
			{
				if (value > 0)
				{
					this.o0.00O..OOooOOO.O0.(value);
				}
			}
		}

		/// <summary>
		/// 首次单击某项目时，是否切换该项目的勾选状态
		/// </summary>
		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x060056DA RID: 22234 RVA: 0x0025B9FC File Offset: 0x00259BFC
		// (set) Token: 0x060056DB RID: 22235 RVA: 0x0025BA09 File Offset: 0x00259C09
		[oO0oooo("3103")]
		public bool CheckOnClick
		{
			get
			{
				return this.o0.00O..o__0o0o_.OO0O_.();
			}
			set
			{
				this.o0.00O..Oo.00_.(value);
			}
		}

		/// <summary>
		/// 值与值之间的分隔符号
		/// </summary>
		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x060056DC RID: 22236 RVA: 0x0025BA17 File Offset: 0x00259C17
		// (set) Token: 0x060056DD RID: 22237 RVA: 0x0025BA24 File Offset: 0x00259C24
		[oO0oooo("0945")]
		public char Separator
		{
			get
			{
				return this.o0.00O..o_0Oo.o_.();
			}
			set
			{
				if (Operators.CompareString(Conversions.ToString(value), "", true) == 0)
				{
					this.o0.00O..o0OO.O.(',');
					return;
				}
				this.o0.00O..o0OO.O.(value);
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x060056DE RID: 22238 RVA: 0x0025BA54 File Offset: 0x00259C54
		// (set) Token: 0x060056DF RID: 22239 RVA: 0x0025BA62 File Offset: 0x00259C62
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
		/// 文本对齐方式
		/// </summary>
		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x060056E0 RID: 22240 RVA: 0x0025BA64 File Offset: 0x00259C64
		// (set) Token: 0x060056E1 RID: 22241 RVA: 0x0025BA71 File Offset: 0x00259C71
		[oO0oooo("1861")]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.o0.00O..TextAlign;
			}
			set
			{
				this.o0.00O..TextAlign = value;
			}
		}

		/// <summary>
		/// 是否自动更改输入内容的大小写
		/// </summary>
		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x060056E2 RID: 22242 RVA: 0x0025BA7F File Offset: 0x00259C7F
		// (set) Token: 0x060056E3 RID: 22243 RVA: 0x0025BA8C File Offset: 0x00259C8C
		public CharacterCasing CharacterCasing
		{
			get
			{
				return this.o0.00O..CharacterCasing;
			}
			set
			{
				this.o0.00O..CharacterCasing = value;
			}
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x060056E4 RID: 22244 RVA: 0x0025BA9A File Offset: 0x00259C9A
		// (set) Token: 0x060056E5 RID: 22245 RVA: 0x0025BAA7 File Offset: 0x00259CA7
		public BorderStyle BorderStyle
		{
			get
			{
				return this.o0.00O..BorderStyle;
			}
			set
			{
				this.o0.00O..BorderStyle = value;
			}
		}

		/// <summary>
		/// 边框颜色
		/// </summary>
		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x060056E6 RID: 22246 RVA: 0x0025BAB5 File Offset: 0x00259CB5
		// (set) Token: 0x060056E7 RID: 22247 RVA: 0x0025BAC2 File Offset: 0x00259CC2
		public Color BorderColor
		{
			get
			{
				return this.o0.00O..BorderColor;
			}
			set
			{
				this.o0.00O..BorderColor = value;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x060056E8 RID: 22248 RVA: 0x0025BAD0 File Offset: 0x00259CD0
		// (set) Token: 0x060056E9 RID: 22249 RVA: 0x0025BADD File Offset: 0x00259CDD
		public override Color BackColor
		{
			get
			{
				return this.o0.00O..BackColor;
			}
			set
			{
				this.o0.00O..BackColor = value;
			}
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x060056EA RID: 22250 RVA: 0x0025BAEB File Offset: 0x00259CEB
		// (set) Token: 0x060056EB RID: 22251 RVA: 0x0025BAF8 File Offset: 0x00259CF8
		public override Color ForeColor
		{
			get
			{
				return this.o0.00O..ForeColor;
			}
			set
			{
				this.o0.00O..ForeColor = value;
			}
		}

		/// <summary>
		/// 可输入内容的最大长度
		/// </summary>
		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x060056EC RID: 22252 RVA: 0x0025BB06 File Offset: 0x00259D06
		// (set) Token: 0x060056ED RID: 22253 RVA: 0x0025BB13 File Offset: 0x00259D13
		public int MaxLength
		{
			get
			{
				return this.o0.00O..MaxLength;
			}
			set
			{
				this.o0.00O..MaxLength = value;
			}
		}

		/// <summary>
		/// 密码字符
		/// </summary>
		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x060056EE RID: 22254 RVA: 0x0025BB21 File Offset: 0x00259D21
		// (set) Token: 0x060056EF RID: 22255 RVA: 0x0025BB2E File Offset: 0x00259D2E
		[oO0oooo("1865")]
		public char PasswordChar
		{
			get
			{
				return this.o0.00O..PasswordChar;
			}
			set
			{
				this.o0.00O..PasswordChar = value;
			}
		}

		/// <summary>
		/// 输入掩码
		/// </summary>
		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x060056F0 RID: 22256 RVA: 0x0025BB3C File Offset: 0x00259D3C
		// (set) Token: 0x060056F1 RID: 22257 RVA: 0x0025BB49 File Offset: 0x00259D49
		[oO0oooo("1866")]
		public string EditMask
		{
			get
			{
				return this.o0.00O..EditMask;
			}
			set
			{
				this.o0.00O..EditMask = value;
			}
		}

		/// <summary>
		/// 格式符号
		/// </summary>
		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x060056F2 RID: 22258 RVA: 0x0025BB57 File Offset: 0x00259D57
		// (set) Token: 0x060056F3 RID: 22259 RVA: 0x0025BB64 File Offset: 0x00259D64
		[oO0oooo("1867")]
		public string FormatString
		{
			get
			{
				return this.o0.00O..CustomFormat;
			}
			set
			{
				this.o0.00O..CustomFormat = value;
				this.o0.00O..EditFormat.CustomFormat = null;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.o0.00O..FormatType = FormatTypeEnum.CustomFormat;
					return;
				}
				this.o0.00O..FormatType = FormatTypeEnum.DefaultFormat;
			}
		}

		/// <summary>
		/// 是否自动删除前导空格
		/// </summary>
		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x060056F4 RID: 22260 RVA: 0x0025BBB6 File Offset: 0x00259DB6
		// (set) Token: 0x060056F5 RID: 22261 RVA: 0x0025BBC3 File Offset: 0x00259DC3
		public bool TrimStart
		{
			get
			{
				return this.o0.00O..TrimStart;
			}
			set
			{
				this.o0.00O..TrimStart = value;
			}
		}

		/// <summary>
		/// 是否自动删除尾随空格
		/// </summary>
		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x060056F6 RID: 22262 RVA: 0x0025BBD1 File Offset: 0x00259DD1
		// (set) Token: 0x060056F7 RID: 22263 RVA: 0x0025BBDE File Offset: 0x00259DDE
		public bool TrimEnd
		{
			get
			{
				return this.o0.00O..TrimStart;
			}
			set
			{
				this.o0.00O..TrimEnd = value;
			}
		}

		/// <summary>
		/// 默认选中范围
		/// </summary>
		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x060056F8 RID: 22264 RVA: 0x0025BBEC File Offset: 0x00259DEC
		// (set) Token: 0x060056F9 RID: 22265 RVA: 0x0025BBF9 File Offset: 0x00259DF9
		public InitialSelectionEnum InitialSelection
		{
			get
			{
				return this.o0.00O..InitialSelection;
			}
			set
			{
				this.o0.00O..InitialSelection = value;
			}
		}

		/// <summary>
		/// 项目集合
		/// </summary>
		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x060056FA RID: 22266 RVA: 0x0025BC07 File Offset: 0x00259E07
		[oO0oooo("0934")]
		public CheckedListBox.ObjectCollection Items
		{
			get
			{
				return this.o0.00O..o_0Oo.o_.();
			}
		}

		/// <summary>
		/// 所输入或所选择的项目，在项目集合中的位置
		/// </summary>
		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x060056FB RID: 22267 RVA: 0x0025BC14 File Offset: 0x00259E14
		// (set) Token: 0x060056FC RID: 22268 RVA: 0x0025BC21 File Offset: 0x00259E21
		[oO0oooo("0930")]
		public int SelectedIndex
		{
			get
			{
				return this.o0.00O..o0.0.();
			}
			set
			{
				this.o0.00O..o0.O_O.(value);
			}
		}

		/// <summary>
		/// 所选择的项目
		/// </summary>
		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x060056FD RID: 22269 RVA: 0x0025BC2F File Offset: 0x00259E2F
		// (set) Token: 0x060056FE RID: 22270 RVA: 0x0025BC3C File Offset: 0x00259E3C
		[oO0oooo("0932")]
		public object SelectedItem
		{
			get
			{
				return this.o0.00O..o0.0.();
			}
			set
			{
				this.o0.00O..o.__.(RuntimeHelpers.GetObjectValue(value));
			}
		}

		/// <summary>
		/// 返回或设置输入框中选定的文本
		/// </summary>
		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x060056FF RID: 22271 RVA: 0x0025BC4F File Offset: 0x00259E4F
		// (set) Token: 0x06005700 RID: 22272 RVA: 0x0025BC5C File Offset: 0x00259E5C
		[oO0oooo("0740")]
		public string SelectedText
		{
			get
			{
				return this.o0.00O..SelectedText;
			}
			set
			{
				this.o0.00O..SelectedText = value;
			}
		}

		/// <summary>
		/// 返回或设置组合框选择的值
		/// </summary>
		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06005701 RID: 22273 RVA: 0x0025BC6A File Offset: 0x00259E6A
		// (set) Token: 0x06005702 RID: 22274 RVA: 0x0025BC77 File Offset: 0x00259E77
		[oO0oooo("0933")]
		public object SelectedValue
		{
			get
			{
				return this.o0.00O..o_0Oo.o_.();
			}
			set
			{
				this.o0.00O..o0OO.O.(RuntimeHelpers.GetObjectValue(value));
			}
		}

		/// <summary>
		/// 返回文本框中选定字符的起始位置
		/// </summary>
		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06005703 RID: 22275 RVA: 0x0025BC8A File Offset: 0x00259E8A
		// (set) Token: 0x06005704 RID: 22276 RVA: 0x0025BC97 File Offset: 0x00259E97
		public int SelectionStart
		{
			get
			{
				return this.o0.00O..SelectionStart;
			}
			set
			{
				this.o0.00O..SelectionStart = value;
			}
		}

		/// <summary>
		/// 返回或设置文本框中选定字符的长度
		/// </summary>
		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x06005705 RID: 22277 RVA: 0x0025BCA5 File Offset: 0x00259EA5
		// (set) Token: 0x06005706 RID: 22278 RVA: 0x0025BCB2 File Offset: 0x00259EB2
		public int SelectionLength
		{
			get
			{
				return this.o0.00O..SelectionLength;
			}
			set
			{
				this.o0.00O..SelectionLength = value;
			}
		}

		/// <summary>
		/// 选定输入框中的全部内容
		/// </summary>
		// Token: 0x06005707 RID: 22279 RVA: 0x0025BCC0 File Offset: 0x00259EC0
		public void SelectAll()
		{
			this.o0.00O..SelectAll();
		}

		/// <summary>
		/// 复制内容到剪贴板
		/// </summary>
		// Token: 0x06005708 RID: 22280 RVA: 0x0025BCCD File Offset: 0x00259ECD
		public void Copy()
		{
			this.o0.00O..Copy();
		}

		/// <summary>
		/// 剪切选定内容到剪贴板
		/// </summary>
		// Token: 0x06005709 RID: 22281 RVA: 0x0025BCDA File Offset: 0x00259EDA
		public void Cut()
		{
			this.o0.00O..Cut();
		}

		/// <summary>
		/// 用剪贴板内容替换输入框中的选定内容
		/// </summary>
		// Token: 0x0600570A RID: 22282 RVA: 0x0025BCE7 File Offset: 0x00259EE7
		public void Paste()
		{
			this.o0.00O..Paste();
		}

		/// <summary>
		/// 撤销上次操作
		/// </summary>
		// Token: 0x0600570B RID: 22283 RVA: 0x0025BCF4 File Offset: 0x00259EF4
		public void Undo()
		{
			this.o0.00O..Undo();
		}

		/// <summary>
		/// 重置文本内容
		/// </summary>
		// Token: 0x0600570C RID: 22284 RVA: 0x0025BD01 File Offset: 0x00259F01
		public void ResetText()
		{
			this.o0.00O..ResetText();
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x0600570D RID: 22285 RVA: 0x0025BD0E File Offset: 0x00259F0E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string[] Lines
		{
			get
			{
				return this.o0.00O..Lines;
			}
		}

		/// <summary>
		/// 打开下拉列表
		/// </summary>
		// Token: 0x0600570E RID: 22286 RVA: 0x0025BD1B File Offset: 0x00259F1B
		public void OpenDropDown()
		{
			this.o0.00O..OpenDropDown();
		}

		/// <summary>
		/// 关闭下拉列表
		/// </summary>
		// Token: 0x0600570F RID: 22287 RVA: 0x0025BD28 File Offset: 0x00259F28
		public void CloseDropDown()
		{
			this.o0.00O..CloseDropDown();
		}

		/// <summary>
		/// 下拉列表是否已经打开
		/// </summary>
		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06005710 RID: 22288 RVA: 0x0025BD35 File Offset: 0x00259F35
		public bool DroppedDown
		{
			get
			{
				return this.o0.00O..DroppedDown;
			}
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x0025BD42 File Offset: 0x00259F42
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x040022CC RID: 8908
		private O0oo000oO0oo_ <<EMPTY_NAME>>;
	}
}
