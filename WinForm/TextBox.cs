using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 文本输入框
	/// </summary>
	// Token: 0x0200053A RID: 1338
	[ComVisible(true)]
	public class TextBox : Control, OoO_
	{
		// Token: 0x06005996 RID: 22934 RVA: 0x00260726 File Offset: 0x0025E926
		internal TextBox(O0O_O0 A_0) : base(A_0, ControlTypeEnum.TextBox)
		{
			this.OooO.OO0O_. = A_0;
		}

		/// <summary>
		/// 文本内容
		/// </summary>
		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06005997 RID: 22935 RVA: 0x00260737 File Offset: 0x0025E937
		// (set) Token: 0x06005998 RID: 22936 RVA: 0x00260744 File Offset: 0x0025E944
		[oO0oooo("0750")]
		public string Text
		{
			get
			{
				return this.OooO.OO0O_..Text;
			}
			set
			{
				this.OooO.OO0O_..Value = value;
			}
		}

		/// <summary>
		/// 返回或设置输入框的值
		/// </summary>
		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06005999 RID: 22937 RVA: 0x00260754 File Offset: 0x0025E954
		// (set) Token: 0x0600599A RID: 22938 RVA: 0x0026078F File Offset: 0x0025E98F
		[oO0oooo("0751")]
		public object Value
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.OooO.OO0O_..Value);
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
				this.OooO.OO0O_..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x0600599B RID: 22939 RVA: 0x002607A2 File Offset: 0x0025E9A2
		// (set) Token: 0x0600599C RID: 22940 RVA: 0x002607AF File Offset: 0x0025E9AF
		[oO0oooo("0749")]
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.OooO.OO0O_..O0oO_OOOOo0o.o.();
			}
			set
			{
				this.OooO.OO0O_..O0oO_OOOOo0o.o.(value);
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x0600599D RID: 22941 RVA: 0x002607BD File Offset: 0x0025E9BD
		// (set) Token: 0x0600599E RID: 22942 RVA: 0x002607C8 File Offset: 0x0025E9C8
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.OooO.OO0O_..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.TextBox, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.OooO.OO0O_..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text);
								this.OooO.OO0O_..DataType = OO_00oOO.Vars.VariableTable.Columns[text].DataType;
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value2", value);
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
							if (binding != null)
							{
								this.OooO.OO0O_..DataBindings.Add(binding);
								if (this.OooO.OO0O_..DataBindings.Count > 0)
								{
									int num = value.LastIndexOf('.');
									string a_ = value.Substring(0, num);
									string name = value.Substring(num + 1);
									if (this.OooO.OO0O_..DataType != OO_00oOO.Tables[a_].DataTable.BaseTable.Columns[name].DataType)
									{
										this.OooO.OO0O_..DataType = OO_00oOO.Tables[a_].DataTable.BaseTable.Columns[name].DataType;
										base.ReadValue();
									}
								}
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x0600599F RID: 22943 RVA: 0x00260970 File Offset: 0x0025EB70
		// (set) Token: 0x060059A0 RID: 22944 RVA: 0x0026097E File Offset: 0x0025EB7E
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
		/// 文本水平对齐方式
		/// </summary>
		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x060059A1 RID: 22945 RVA: 0x00260980 File Offset: 0x0025EB80
		// (set) Token: 0x060059A2 RID: 22946 RVA: 0x0026098D File Offset: 0x0025EB8D
		[oO0oooo("1861")]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.OooO.OO0O_..TextAlign;
			}
			set
			{
				this.OooO.OO0O_..TextAlign = value;
			}
		}

		/// <summary>
		/// 文本垂直对齐方式
		/// </summary>
		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x060059A3 RID: 22947 RVA: 0x0026099B File Offset: 0x0025EB9B
		// (set) Token: 0x060059A4 RID: 22948 RVA: 0x002609A8 File Offset: 0x0025EBA8
		public VerticalAlignEnum VeticalAlign
		{
			get
			{
				return this.OooO.OO0O_..VerticalAlign;
			}
			set
			{
				this.OooO.OO0O_..VerticalAlign = value;
			}
		}

		/// <summary>
		/// 是否为多行文本框
		/// </summary>
		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x060059A5 RID: 22949 RVA: 0x002609B6 File Offset: 0x0025EBB6
		// (set) Token: 0x060059A6 RID: 22950 RVA: 0x002609C4 File Offset: 0x0025EBC4
		[oO0oooo("1862")]
		public bool MultiLine
		{
			get
			{
				return this.OooO.OO0O_..Multiline;
			}
			set
			{
				this.OooO.OO0O_..Multiline = value;
				if (value)
				{
					this.OooO.OO0O_..VerticalAlign = VerticalAlignEnum.Top;
				}
				else
				{
					this.OooO.OO0O_..VerticalAlign = VerticalAlignEnum.Top;
				}
				this.OooO.OO0O_..AcceptsReturn = value;
				this.OooO.OO0O_..TrimEnd = false;
			}
		}

		/// <summary>
		/// 是否自动换行
		/// </summary>
		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060059A7 RID: 22951 RVA: 0x00260A12 File Offset: 0x0025EC12
		// (set) Token: 0x060059A8 RID: 22952 RVA: 0x00260A1F File Offset: 0x0025EC1F
		public bool WordWrap
		{
			get
			{
				return this.OooO.OO0O_..WordWrap;
			}
			set
			{
				this.OooO.OO0O_..WordWrap = value;
			}
		}

		/// <summary>
		/// 设置如何显示滚动条
		/// </summary>
		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060059A9 RID: 22953 RVA: 0x00260A2D File Offset: 0x0025EC2D
		// (set) Token: 0x060059AA RID: 22954 RVA: 0x00260A3A File Offset: 0x0025EC3A
		public ScrollBars ScrollBars
		{
			get
			{
				return this.OooO.OO0O_..ScrollBars;
			}
			set
			{
				this.OooO.OO0O_..ScrollBars = value;
			}
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x060059AB RID: 22955 RVA: 0x00260A48 File Offset: 0x0025EC48
		// (set) Token: 0x060059AC RID: 22956 RVA: 0x00260A55 File Offset: 0x0025EC55
		[oO0oooo("3098")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.OooO.OO0O_..BorderStyle;
			}
			set
			{
				this.OooO.OO0O_..BorderStyle = value;
			}
		}

		/// <summary>
		/// 边框颜色
		/// </summary>
		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060059AD RID: 22957 RVA: 0x00260A63 File Offset: 0x0025EC63
		// (set) Token: 0x060059AE RID: 22958 RVA: 0x00260A70 File Offset: 0x0025EC70
		[oO0oooo("3097")]
		public Color BorderColor
		{
			get
			{
				return this.OooO.OO0O_..BorderColor;
			}
			set
			{
				this.OooO.OO0O_..BorderColor = value;
			}
		}

		/// <summary>
		/// 是否自动更改输入内容的大小写
		/// </summary>
		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x060059AF RID: 22959 RVA: 0x00260A7E File Offset: 0x0025EC7E
		// (set) Token: 0x060059B0 RID: 22960 RVA: 0x00260A8B File Offset: 0x0025EC8B
		public CharacterCasing CharacterCasing
		{
			get
			{
				return this.OooO.OO0O_..CharacterCasing;
			}
			set
			{
				this.OooO.OO0O_..CharacterCasing = value;
			}
		}

		/// <summary>
		/// 可输入内容的最大长度
		/// </summary>
		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x060059B1 RID: 22961 RVA: 0x00260A99 File Offset: 0x0025EC99
		// (set) Token: 0x060059B2 RID: 22962 RVA: 0x00260AA6 File Offset: 0x0025ECA6
		public int MaxLength
		{
			get
			{
				return this.OooO.OO0O_..MaxLength;
			}
			set
			{
				this.OooO.OO0O_..MaxLength = value;
			}
		}

		/// <summary>
		/// 密码字符
		/// </summary>
		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x060059B3 RID: 22963 RVA: 0x00260AB4 File Offset: 0x0025ECB4
		// (set) Token: 0x060059B4 RID: 22964 RVA: 0x00260AC1 File Offset: 0x0025ECC1
		[oO0oooo("1865")]
		public char PasswordChar
		{
			get
			{
				return this.OooO.OO0O_..PasswordChar;
			}
			set
			{
				this.OooO.OO0O_..PasswordChar = value;
			}
		}

		/// <summary>
		/// 输入掩码
		/// </summary>
		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x060059B5 RID: 22965 RVA: 0x00260ACF File Offset: 0x0025ECCF
		// (set) Token: 0x060059B6 RID: 22966 RVA: 0x00260ADC File Offset: 0x0025ECDC
		[oO0oooo("1866")]
		public string EditMask
		{
			get
			{
				return this.OooO.OO0O_..EditMask;
			}
			set
			{
				this.OooO.OO0O_..EditMask = value;
			}
		}

		/// <summary>
		/// 格式符号
		/// </summary>
		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x060059B7 RID: 22967 RVA: 0x00260AEA File Offset: 0x0025ECEA
		// (set) Token: 0x060059B8 RID: 22968 RVA: 0x00260AFC File Offset: 0x0025ECFC
		[oO0oooo("1867")]
		public string FormatString
		{
			get
			{
				return this.OooO.OO0O_..DisplayFormat.CustomFormat;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0)
				{
					value = this.OooO.OO0O_.;
				}
				this.OooO.OO0O_..DisplayFormat.CustomFormat = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.OooO.OO0O_..DisplayFormat.FormatType = FormatTypeEnum.CustomFormat;
					return;
				}
				this.OooO.OO0O_..DisplayFormat.FormatType = FormatTypeEnum.DefaultFormat;
			}
		}

		/// <summary>
		/// 是否自动删除前导空格
		/// </summary>
		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x060059B9 RID: 22969 RVA: 0x00260B62 File Offset: 0x0025ED62
		// (set) Token: 0x060059BA RID: 22970 RVA: 0x00260B6F File Offset: 0x0025ED6F
		public bool TrimStart
		{
			get
			{
				return this.OooO.OO0O_..TrimStart;
			}
			set
			{
				this.OooO.OO0O_..TrimStart = value;
			}
		}

		/// <summary>
		/// 是否自动删除尾随空格
		/// </summary>
		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x060059BB RID: 22971 RVA: 0x00260B7D File Offset: 0x0025ED7D
		// (set) Token: 0x060059BC RID: 22972 RVA: 0x00260B8A File Offset: 0x0025ED8A
		public bool TrimEnd
		{
			get
			{
				return this.OooO.OO0O_..TrimStart;
			}
			set
			{
				this.OooO.OO0O_..TrimEnd = value;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x060059BD RID: 22973 RVA: 0x00260B98 File Offset: 0x0025ED98
		// (set) Token: 0x060059BE RID: 22974 RVA: 0x00260BA5 File Offset: 0x0025EDA5
		[oO0oooo("0720")]
		public override Color BackColor
		{
			get
			{
				return this.OooO.OO0O_..BackColor;
			}
			set
			{
				this.OooO.OO0O_..BackColor = value;
			}
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x060059BF RID: 22975 RVA: 0x00260BB3 File Offset: 0x0025EDB3
		// (set) Token: 0x060059C0 RID: 22976 RVA: 0x00260BC0 File Offset: 0x0025EDC0
		[oO0oooo("0721")]
		public override Color ForeColor
		{
			get
			{
				return this.OooO.OO0O_..ForeColor;
			}
			set
			{
				this.OooO.OO0O_..ForeColor = value;
				this.OooO.OO0O_..NegativeForeColor = value;
			}
		}

		/// <summary>
		/// 输入框获得焦点后，内容的初始选定范围
		/// </summary>
		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x060059C1 RID: 22977 RVA: 0x00260BDA File Offset: 0x0025EDDA
		// (set) Token: 0x060059C2 RID: 22978 RVA: 0x00260BE7 File Offset: 0x0025EDE7
		public InitialSelectionEnum InitialSelection
		{
			get
			{
				return this.OooO.OO0O_..InitialSelection;
			}
			set
			{
				this.OooO.OO0O_..InitialSelection = value;
			}
		}

		/// <summary>
		/// 返回或设置输入框中选定的文本
		/// </summary>
		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x060059C3 RID: 22979 RVA: 0x00260BF5 File Offset: 0x0025EDF5
		// (set) Token: 0x060059C4 RID: 22980 RVA: 0x00260C02 File Offset: 0x0025EE02
		[oO0oooo("0740")]
		public string SelectedText
		{
			get
			{
				return this.OooO.OO0O_..SelectedText;
			}
			set
			{
				this.OooO.OO0O_..SelectedText = value;
			}
		}

		/// <summary>
		/// 返回文本框中选定字符的起始位置
		/// </summary>
		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x060059C5 RID: 22981 RVA: 0x00260C10 File Offset: 0x0025EE10
		// (set) Token: 0x060059C6 RID: 22982 RVA: 0x00260C1D File Offset: 0x0025EE1D
		public int SelectionStart
		{
			get
			{
				return this.OooO.OO0O_..SelectionStart;
			}
			set
			{
				this.OooO.OO0O_..SelectionStart = value;
			}
		}

		/// <summary>
		/// 返回或设置文本框中选定字符的长度
		/// </summary>
		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x060059C7 RID: 22983 RVA: 0x00260C2B File Offset: 0x0025EE2B
		// (set) Token: 0x060059C8 RID: 22984 RVA: 0x00260C38 File Offset: 0x0025EE38
		public int SelectionLength
		{
			get
			{
				return this.OooO.OO0O_..SelectionLength;
			}
			set
			{
				this.OooO.OO0O_..SelectionLength = value;
			}
		}

		/// <summary>
		/// 一个字符型数组，可以返回文本框中指定行号的内容
		/// </summary>
		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x060059C9 RID: 22985 RVA: 0x00260C46 File Offset: 0x0025EE46
		[oO0oooo("0760")]
		public string[] Lines
		{
			get
			{
				return this.OooO.OO0O_..Lines;
			}
		}

		/// <summary>
		/// 选定输入框中的全部内容
		/// </summary>
		// Token: 0x060059CA RID: 22986 RVA: 0x00260C53 File Offset: 0x0025EE53
		public void SelectAll()
		{
			this.OooO.OO0O_..SelectAll();
		}

		/// <summary>
		/// 复制选定内容到剪贴板
		/// </summary>
		// Token: 0x060059CB RID: 22987 RVA: 0x00260C60 File Offset: 0x0025EE60
		public void Copy()
		{
			this.OooO.OO0O_..Copy();
		}

		/// <summary>
		/// 剪切选定内容到剪贴板
		/// </summary>
		// Token: 0x060059CC RID: 22988 RVA: 0x00260C6D File Offset: 0x0025EE6D
		public void Cut()
		{
			this.OooO.OO0O_..Cut();
			this.OooO.OO0O_..UpdateValueWithCurrentText();
		}

		/// <summary>
		/// 用剪贴板内容替换输入框中的选定内容
		/// </summary>
		// Token: 0x060059CD RID: 22989 RVA: 0x00260C86 File Offset: 0x0025EE86
		public void Paste()
		{
			this.OooO.OO0O_..Paste();
			this.OooO.OO0O_..UpdateValueWithCurrentText();
		}

		/// <summary>
		/// 撤销上次操作
		/// </summary>
		// Token: 0x060059CE RID: 22990 RVA: 0x00260C9F File Offset: 0x0025EE9F
		public void Undo()
		{
			this.OooO.OO0O_..Undo();
			this.OooO.OO0O_..UpdateValueWithCurrentText();
		}

		/// <summary>
		/// 重置文本内容
		/// </summary>
		// Token: 0x060059CF RID: 22991 RVA: 0x00260CB8 File Offset: 0x0025EEB8
		public void ResetText()
		{
			this.OooO.OO0O_..ResetText();
		}

		// Token: 0x060059D0 RID: 22992 RVA: 0x00260CC5 File Offset: 0x0025EEC5
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x060059D1 RID: 22993 RVA: 0x00260CCE File Offset: 0x0025EECE
		public void AppendText(string text)
		{
			this.OooO.OO0O_..AppendText(text);
		}

		// Token: 0x0400232F RID: 9007
		private O0O_O0 <<EMPTY_NAME>>;

		// Token: 0x04002330 RID: 9008
		private string <<EMPTY_NAME>>;
	}
}
