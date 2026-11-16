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
	/// 数值输入组合框
	/// </summary>
	// Token: 0x0200052F RID: 1327
	[ComVisible(true)]
	public class NumericComboBox : Control, OoO_
	{
		// Token: 0x0600586C RID: 22636 RVA: 0x0025EADC File Offset: 0x0025CCDC
		internal NumericComboBox(ooOOO A_0) : base(A_0, ControlTypeEnum.NumericComboBox)
		{
			this.o.oO_oo_O. = A_0;
		}

		/// <summary>
		/// 文本内容
		/// </summary>
		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x0600586D RID: 22637 RVA: 0x0025EAED File Offset: 0x0025CCED
		// (set) Token: 0x0600586E RID: 22638 RVA: 0x0025EAFA File Offset: 0x0025CCFA
		public string Text
		{
			get
			{
				return this.o.oO_oo_O..Text;
			}
			set
			{
				this.o.oO_oo_O..Value = value;
			}
		}

		/// <summary>
		/// 返回或设置输入框的值
		/// </summary>
		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x0600586F RID: 22639 RVA: 0x0025EB08 File Offset: 0x0025CD08
		// (set) Token: 0x06005870 RID: 22640 RVA: 0x0025EB15 File Offset: 0x0025CD15
		public object Value
		{
			get
			{
				return this.o.oO_oo_O..Value;
			}
			set
			{
				this.o.oO_oo_O..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06005871 RID: 22641 RVA: 0x0025EB28 File Offset: 0x0025CD28
		// (set) Token: 0x06005872 RID: 22642 RVA: 0x0025EB35 File Offset: 0x0025CD35
		[oO0oooo("0749")]
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.o.oO_oo_O..o00.Oo_OO0.();
			}
			set
			{
				this.o.oO_oo_O..o00.Oo_OO0.(value);
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06005873 RID: 22643 RVA: 0x0025EB43 File Offset: 0x0025CD43
		// (set) Token: 0x06005874 RID: 22644 RVA: 0x0025EB4C File Offset: 0x0025CD4C
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.o.oO_oo_O..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.NumericComboBox, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.o.oO_oo_O..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value2", value);
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
							if (binding != null)
							{
								this.o.oO_oo_O..DataBindings.Add(binding);
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06005875 RID: 22645 RVA: 0x0025EC28 File Offset: 0x0025CE28
		// (set) Token: 0x06005876 RID: 22646 RVA: 0x0025EC36 File Offset: 0x0025CE36
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
		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06005877 RID: 22647 RVA: 0x0025EC38 File Offset: 0x0025CE38
		// (set) Token: 0x06005878 RID: 22648 RVA: 0x0025EC45 File Offset: 0x0025CE45
		[oO0oooo("1861")]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.o.oO_oo_O..TextAlign;
			}
			set
			{
				this.o.oO_oo_O..TextAlign = value;
			}
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06005879 RID: 22649 RVA: 0x0025EC53 File Offset: 0x0025CE53
		// (set) Token: 0x0600587A RID: 22650 RVA: 0x0025EC60 File Offset: 0x0025CE60
		public BorderStyle BorderStyle
		{
			get
			{
				return this.o.oO_oo_O..BorderStyle;
			}
			set
			{
				this.o.oO_oo_O..BorderStyle = value;
			}
		}

		/// <summary>
		/// 边框颜色
		/// </summary>
		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x0600587B RID: 22651 RVA: 0x0025EC6E File Offset: 0x0025CE6E
		// (set) Token: 0x0600587C RID: 22652 RVA: 0x0025EC7B File Offset: 0x0025CE7B
		public Color BorderColor
		{
			get
			{
				return this.o.oO_oo_O..BorderColor;
			}
			set
			{
				this.o.oO_oo_O..BorderColor = value;
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x0600587D RID: 22653 RVA: 0x0025EC89 File Offset: 0x0025CE89
		// (set) Token: 0x0600587E RID: 22654 RVA: 0x0025EC96 File Offset: 0x0025CE96
		[EditorBrowsable(EditorBrowsableState.Never)]
		public char PasswordChar
		{
			get
			{
				return this.o.oO_oo_O..PasswordChar;
			}
			set
			{
				this.o.oO_oo_O..PasswordChar = value;
			}
		}

		/// <summary>
		/// 格式符号
		/// </summary>
		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x0600587F RID: 22655 RVA: 0x0025ECA4 File Offset: 0x0025CEA4
		// (set) Token: 0x06005880 RID: 22656 RVA: 0x0025ECB8 File Offset: 0x0025CEB8
		[oO0oooo("1873")]
		public string FormatString
		{
			get
			{
				return this.o.oO_oo_O..DisplayFormat.CustomFormat;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0)
				{
					value = this.o.oO_oo_O.;
				}
				this.o.oO_oo_O..DisplayFormat.CustomFormat = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.o.oO_oo_O..DisplayFormat.FormatType = FormatTypeEnum.CustomFormat;
					return;
				}
				this.o.oO_oo_O..DisplayFormat.FormatType = FormatTypeEnum.DefaultFormat;
			}
		}

		/// <summary>
		/// 是否显示数值输入框的上下微调按钮
		/// </summary>
		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06005881 RID: 22657 RVA: 0x0025ED1E File Offset: 0x0025CF1E
		// (set) Token: 0x06005882 RID: 22658 RVA: 0x0025ED2B File Offset: 0x0025CF2B
		public bool ShowUpDownButtons
		{
			get
			{
				return this.o.oO_oo_O..ShowUpDownButtons;
			}
			set
			{
				this.o.oO_oo_O..ShowUpDownButtons = value;
			}
		}

		/// <summary>
		/// 是否显示数值输入框的下拉计算器按钮
		/// </summary>
		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06005883 RID: 22659 RVA: 0x0025ED39 File Offset: 0x0025CF39
		// (set) Token: 0x06005884 RID: 22660 RVA: 0x0025ED46 File Offset: 0x0025CF46
		public bool ShowDropDownButton
		{
			get
			{
				return this.o.oO_oo_O..ShowDropDownButton;
			}
			set
			{
				this.o.oO_oo_O..ShowDropDownButton = value;
			}
		}

		/// <summary>
		/// 置单击上下微调按钮的时候，数值改变的幅度
		/// </summary>
		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06005885 RID: 22661 RVA: 0x0025ED54 File Offset: 0x0025CF54
		// (set) Token: 0x06005886 RID: 22662 RVA: 0x0025ED92 File Offset: 0x0025CF92
		public double Increment
		{
			get
			{
				double result;
				if (this.o.oO_oo_O..Increment != null)
				{
					result = (double)Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.o.oO_oo_O..Increment));
				}
				else
				{
					result = 0.0;
				}
				return result;
			}
			set
			{
				this.o.oO_oo_O..Increment = value;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06005887 RID: 22663 RVA: 0x0025EDA5 File Offset: 0x0025CFA5
		// (set) Token: 0x06005888 RID: 22664 RVA: 0x0025EDB2 File Offset: 0x0025CFB2
		public override Color BackColor
		{
			get
			{
				return this.o.oO_oo_O..BackColor;
			}
			set
			{
				this.o.oO_oo_O..BackColor = value;
			}
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06005889 RID: 22665 RVA: 0x0025EDC0 File Offset: 0x0025CFC0
		// (set) Token: 0x0600588A RID: 22666 RVA: 0x0025EDCD File Offset: 0x0025CFCD
		public override Color ForeColor
		{
			get
			{
				return this.o.oO_oo_O..ForeColor;
			}
			set
			{
				this.o.oO_oo_O..ForeColor = value;
				this.o.oO_oo_O..NegativeForeColor = value;
			}
		}

		/// <summary>
		/// 选定输入框中的全部内容
		/// </summary>
		// Token: 0x0600588B RID: 22667 RVA: 0x0025EDE7 File Offset: 0x0025CFE7
		public void SelectAll()
		{
			this.o.oO_oo_O..SelectAll();
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x0025EDF4 File Offset: 0x0025CFF4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x04002309 RID: 8969
		private ooOOO <<EMPTY_NAME>>;

		// Token: 0x0400230A RID: 8970
		private string <<EMPTY_NAME>>;
	}
}
