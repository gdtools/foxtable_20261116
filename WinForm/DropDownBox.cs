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
	/// 自定义下拉列表框
	/// </summary>
	// Token: 0x02000510 RID: 1296
	[ComVisible(true)]
	public class DropDownBox : Control, OoO_
	{
		// Token: 0x060054B8 RID: 21688 RVA: 0x002588DF File Offset: 0x00256ADF
		internal DropDownBox(OooO00O A_0) : base(A_0, ControlTypeEnum.TextBox)
		{
			this.o.__O0O. = A_0;
		}

		/// <summary>
		/// 设置下拉窗口名
		/// </summary>
		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x060054B9 RID: 21689 RVA: 0x002588F0 File Offset: 0x00256AF0
		// (set) Token: 0x060054BA RID: 21690 RVA: 0x00258900 File Offset: 0x00256B00
		[oO0oooo("2102")]
		public string DropFormName
		{
			get
			{
				return this.o.__O0O..o.oooOOooo.();
			}
			set
			{
				if (Operators.CompareString(value, "", true) > 0 && OO_00oOO.Forms.Contains(value) && Conversions.ToInteger(OO_00oOO.Forms[value].O_o_.0o0__o0O.["Type"]) != 233)
				{
					MessageBox.Show(value + "\"不能作为下拉窗口使用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				this.o.__O0O..OO.o.(value);
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x060054BB RID: 21691 RVA: 0x00258978 File Offset: 0x00256B78
		// (set) Token: 0x060054BC RID: 21692 RVA: 0x00258986 File Offset: 0x00256B86
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
		/// 是否显示下拉按钮
		/// </summary>
		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060054BD RID: 21693 RVA: 0x00258988 File Offset: 0x00256B88
		// (set) Token: 0x060054BE RID: 21694 RVA: 0x00258995 File Offset: 0x00256B95
		[oO0oooo("2103")]
		public bool ShowDropDownButton
		{
			get
			{
				return this.o.__O0O..ShowDropDownButton;
			}
			set
			{
				this.o.__O0O..ShowDropDownButton = value;
			}
		}

		/// <summary>
		/// 是否显示微调按钮
		/// </summary>
		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060054BF RID: 21695 RVA: 0x002589A3 File Offset: 0x00256BA3
		// (set) Token: 0x060054C0 RID: 21696 RVA: 0x002589B0 File Offset: 0x00256BB0
		[oO0oooo("2104")]
		public bool ShowUpDownButtons
		{
			get
			{
				return this.o.__O0O..ShowUpDownButtons;
			}
			set
			{
				this.o.__O0O..ShowUpDownButtons = value;
			}
		}

		/// <summary>
		/// 是否显示命令按钮
		/// </summary>
		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x060054C1 RID: 21697 RVA: 0x002589BE File Offset: 0x00256BBE
		// (set) Token: 0x060054C2 RID: 21698 RVA: 0x002589CB File Offset: 0x00256BCB
		[oO0oooo("2105")]
		public bool ShowModalButton
		{
			get
			{
				return this.o.__O0O..ShowModalButton;
			}
			set
			{
				this.o.__O0O..ShowModalButton = value;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x060054C3 RID: 21699 RVA: 0x002589D9 File Offset: 0x00256BD9
		// (set) Token: 0x060054C4 RID: 21700 RVA: 0x002589E6 File Offset: 0x00256BE6
		public InitialSelectionEnum InitialSelection
		{
			get
			{
				return this.o.__O0O..InitialSelection;
			}
			set
			{
				this.o.__O0O..InitialSelection = value;
			}
		}

		/// <summary>
		/// 文本内容
		/// </summary>
		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x060054C5 RID: 21701 RVA: 0x002589F4 File Offset: 0x00256BF4
		// (set) Token: 0x060054C6 RID: 21702 RVA: 0x00258A01 File Offset: 0x00256C01
		[oO0oooo("0750")]
		public string Text
		{
			get
			{
				return this.o.__O0O..Text;
			}
			set
			{
				this.o.__O0O..Value = value;
			}
		}

		/// <summary>
		/// 返回或设置输入框的值
		/// </summary>
		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x060054C7 RID: 21703 RVA: 0x00258A0F File Offset: 0x00256C0F
		// (set) Token: 0x060054C8 RID: 21704 RVA: 0x00258A1C File Offset: 0x00256C1C
		[oO0oooo("0751")]
		public object Value
		{
			get
			{
				return this.o.__O0O..Value;
			}
			set
			{
				this.o.__O0O..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x060054C9 RID: 21705 RVA: 0x00258A2F File Offset: 0x00256C2F
		// (set) Token: 0x060054CA RID: 21706 RVA: 0x00258A3C File Offset: 0x00256C3C
		[oO0oooo("0749")]
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.o.__O0O..OO.o.();
			}
			set
			{
				this.o.__O0O..OO.o.(value);
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x060054CB RID: 21707 RVA: 0x00258A4A File Offset: 0x00256C4A
		// (set) Token: 0x060054CC RID: 21708 RVA: 0x00258A54 File Offset: 0x00256C54
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.o.__O0O..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.DropDownBox, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.o.__O0O..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text);
								this.o.__O0O..DataType = OO_00oOO.Vars.VariableTable.Columns[text].DataType;
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value2", value);
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
							if (binding != null)
							{
								this.o.__O0O..DataBindings.Add(binding);
								if (this.o.__O0O..DataBindings.Count > 0)
								{
									int num = value.LastIndexOf('.');
									string a_ = value.Substring(0, num);
									string name = value.Substring(num + 1);
									this.o.__O0O..DataType = OO_00oOO.Tables[a_].DataTable.BaseTable.Columns[name].DataType;
								}
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 文本水平对齐方式
		/// </summary>
		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x060054CD RID: 21709 RVA: 0x00258BBD File Offset: 0x00256DBD
		// (set) Token: 0x060054CE RID: 21710 RVA: 0x00258BCA File Offset: 0x00256DCA
		[oO0oooo("1861")]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.o.__O0O..TextAlign;
			}
			set
			{
				this.o.__O0O..TextAlign = value;
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x060054CF RID: 21711 RVA: 0x00258BD8 File Offset: 0x00256DD8
		// (set) Token: 0x060054D0 RID: 21712 RVA: 0x00258BE5 File Offset: 0x00256DE5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool MultiLine
		{
			get
			{
				return this.o.__O0O..Multiline;
			}
			set
			{
				this.o.__O0O..Multiline = value;
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x060054D1 RID: 21713 RVA: 0x00258BF3 File Offset: 0x00256DF3
		// (set) Token: 0x060054D2 RID: 21714 RVA: 0x00258C00 File Offset: 0x00256E00
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool WordWrap
		{
			get
			{
				return this.o.__O0O..WordWrap;
			}
			set
			{
				this.o.__O0O..WordWrap = value;
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x060054D3 RID: 21715 RVA: 0x00258C0E File Offset: 0x00256E0E
		// (set) Token: 0x060054D4 RID: 21716 RVA: 0x00258C1B File Offset: 0x00256E1B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ScrollBars ScrollBars
		{
			get
			{
				return this.o.__O0O..ScrollBars;
			}
			set
			{
				this.o.__O0O..ScrollBars = value;
			}
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x060054D5 RID: 21717 RVA: 0x00258C29 File Offset: 0x00256E29
		// (set) Token: 0x060054D6 RID: 21718 RVA: 0x00258C36 File Offset: 0x00256E36
		public BorderStyle BorderStyle
		{
			get
			{
				return this.o.__O0O..BorderStyle;
			}
			set
			{
				this.o.__O0O..BorderStyle = value;
			}
		}

		/// <summary>
		/// 边框颜色
		/// </summary>
		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060054D7 RID: 21719 RVA: 0x00258C44 File Offset: 0x00256E44
		// (set) Token: 0x060054D8 RID: 21720 RVA: 0x00258C51 File Offset: 0x00256E51
		public Color BorderColor
		{
			get
			{
				return this.o.__O0O..BorderColor;
			}
			set
			{
				this.o.__O0O..BorderColor = value;
			}
		}

		/// <summary>
		/// 是否自动更改输入内容的大小写
		/// </summary>
		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x060054D9 RID: 21721 RVA: 0x00258C5F File Offset: 0x00256E5F
		// (set) Token: 0x060054DA RID: 21722 RVA: 0x00258C6C File Offset: 0x00256E6C
		public CharacterCasing CharacterCasing
		{
			get
			{
				return this.o.__O0O..CharacterCasing;
			}
			set
			{
				this.o.__O0O..CharacterCasing = value;
			}
		}

		/// <summary>
		/// 可输入内容的最大长度
		/// </summary>
		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x060054DB RID: 21723 RVA: 0x00258C7A File Offset: 0x00256E7A
		// (set) Token: 0x060054DC RID: 21724 RVA: 0x00258C87 File Offset: 0x00256E87
		public int MaxLength
		{
			get
			{
				return this.o.__O0O..MaxLength;
			}
			set
			{
				this.o.__O0O..MaxLength = value;
			}
		}

		/// <summary>
		/// 密码字符
		/// </summary>
		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x060054DD RID: 21725 RVA: 0x00258C95 File Offset: 0x00256E95
		// (set) Token: 0x060054DE RID: 21726 RVA: 0x00258CA2 File Offset: 0x00256EA2
		[oO0oooo("1865")]
		public char PasswordChar
		{
			get
			{
				return this.o.__O0O..PasswordChar;
			}
			set
			{
				this.o.__O0O..PasswordChar = value;
			}
		}

		/// <summary>
		/// 输入掩码
		/// </summary>
		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x060054DF RID: 21727 RVA: 0x00258CB0 File Offset: 0x00256EB0
		// (set) Token: 0x060054E0 RID: 21728 RVA: 0x00258CBD File Offset: 0x00256EBD
		[oO0oooo("1866")]
		public string EditMask
		{
			get
			{
				return this.o.__O0O..EditMask;
			}
			set
			{
				this.o.__O0O..EditMask = value;
			}
		}

		/// <summary>
		/// 格式符号
		/// </summary>
		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x060054E1 RID: 21729 RVA: 0x00258CCB File Offset: 0x00256ECB
		// (set) Token: 0x060054E2 RID: 21730 RVA: 0x00258CD8 File Offset: 0x00256ED8
		[oO0oooo("1867")]
		public string FormatString
		{
			get
			{
				return this.o.__O0O..CustomFormat;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0)
				{
					value = this.o.__O0O.;
				}
				this.o.__O0O..CustomFormat = value;
				this.o.__O0O..EditFormat.CustomFormat = null;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.o.__O0O..FormatType = FormatTypeEnum.CustomFormat;
					return;
				}
				this.o.__O0O..FormatType = FormatTypeEnum.DefaultFormat;
			}
		}

		/// <summary>
		/// 是否删除前导空格
		/// </summary>
		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x060054E3 RID: 21731 RVA: 0x00258D40 File Offset: 0x00256F40
		// (set) Token: 0x060054E4 RID: 21732 RVA: 0x00258D4D File Offset: 0x00256F4D
		public bool TrimStart
		{
			get
			{
				return this.o.__O0O..TrimStart;
			}
			set
			{
				this.o.__O0O..TrimStart = value;
			}
		}

		/// <summary>
		/// 是否删除尾随空格
		/// </summary>
		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x060054E5 RID: 21733 RVA: 0x00258D5B File Offset: 0x00256F5B
		// (set) Token: 0x060054E6 RID: 21734 RVA: 0x00258D68 File Offset: 0x00256F68
		public bool TrimEnd
		{
			get
			{
				return this.o.__O0O..TrimStart;
			}
			set
			{
				this.o.__O0O..TrimEnd = value;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x060054E7 RID: 21735 RVA: 0x00258D76 File Offset: 0x00256F76
		// (set) Token: 0x060054E8 RID: 21736 RVA: 0x00258D83 File Offset: 0x00256F83
		[oO0oooo("0720")]
		public override Color BackColor
		{
			get
			{
				return this.o.__O0O..BackColor;
			}
			set
			{
				this.o.__O0O..BackColor = value;
			}
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x060054E9 RID: 21737 RVA: 0x00258D91 File Offset: 0x00256F91
		// (set) Token: 0x060054EA RID: 21738 RVA: 0x00258D9E File Offset: 0x00256F9E
		[oO0oooo("0721")]
		public override Color ForeColor
		{
			get
			{
				return this.o.__O0O..ForeColor;
			}
			set
			{
				this.o.__O0O..ForeColor = value;
			}
		}

		/// <summary>
		/// 返回或设置输入框中选定的文本
		/// </summary>
		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x060054EB RID: 21739 RVA: 0x00258DAC File Offset: 0x00256FAC
		// (set) Token: 0x060054EC RID: 21740 RVA: 0x00258DB9 File Offset: 0x00256FB9
		[oO0oooo("0740")]
		public string SelectedText
		{
			get
			{
				return this.o.__O0O..SelectedText;
			}
			set
			{
				this.o.__O0O..SelectedText = value;
			}
		}

		/// <summary>
		/// 返回文本框中选定字符的起始位置
		/// </summary>
		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x060054ED RID: 21741 RVA: 0x00258DC7 File Offset: 0x00256FC7
		// (set) Token: 0x060054EE RID: 21742 RVA: 0x00258DD4 File Offset: 0x00256FD4
		public int SelectionStart
		{
			get
			{
				return this.o.__O0O..SelectionStart;
			}
			set
			{
				this.o.__O0O..SelectionStart = value;
			}
		}

		/// <summary>
		/// 返回或设置文本框中选定字符的长度
		/// </summary>
		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x060054EF RID: 21743 RVA: 0x00258DE2 File Offset: 0x00256FE2
		// (set) Token: 0x060054F0 RID: 21744 RVA: 0x00258DEF File Offset: 0x00256FEF
		public int SelectionLength
		{
			get
			{
				return this.o.__O0O..SelectionLength;
			}
			set
			{
				this.o.__O0O..SelectionLength = value;
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x00258DFD File Offset: 0x00256FFD
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string[] Lines
		{
			get
			{
				return this.o.__O0O..Lines;
			}
		}

		/// <summary>
		/// 选定输入框中的全部内容
		/// </summary>
		// Token: 0x060054F2 RID: 21746 RVA: 0x00258E0A File Offset: 0x0025700A
		public void SelectAll()
		{
			this.o.__O0O..SelectAll();
		}

		/// <summary>
		/// 复制选定内容到剪贴板
		/// </summary>
		// Token: 0x060054F3 RID: 21747 RVA: 0x00258E17 File Offset: 0x00257017
		public void Copy()
		{
			this.o.__O0O..Copy();
		}

		/// <summary>
		/// 剪切选定内容到剪贴板
		/// </summary>
		// Token: 0x060054F4 RID: 21748 RVA: 0x00258E24 File Offset: 0x00257024
		public void Cut()
		{
			this.o.__O0O..Cut();
		}

		/// <summary>
		/// 用剪贴板内容替换输入框中的选定内容
		/// </summary>
		// Token: 0x060054F5 RID: 21749 RVA: 0x00258E31 File Offset: 0x00257031
		public void Paste()
		{
			this.o.__O0O..Paste();
		}

		/// <summary>
		/// 撤销上次操作
		/// </summary>
		// Token: 0x060054F6 RID: 21750 RVA: 0x00258E3E File Offset: 0x0025703E
		public void Undo()
		{
			this.o.__O0O..Undo();
		}

		/// <summary>
		/// 重置文本内容
		/// </summary>
		// Token: 0x060054F7 RID: 21751 RVA: 0x00258E4B File Offset: 0x0025704B
		public void ResetText()
		{
			this.o.__O0O..ResetText();
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x00258E58 File Offset: 0x00257058
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void CloseDropdown()
		{
			this.o.__O0O..CloseDropDown();
		}

		/// <summary>
		/// 关闭下拉列表
		/// </summary>
		// Token: 0x060054F9 RID: 21753 RVA: 0x00258E65 File Offset: 0x00257065
		public void CloseDropdown(bool doPost)
		{
			this.o.__O0O..CloseDropDown(doPost);
		}

		/// <summary>
		/// 打开下拉列表
		/// </summary>
		// Token: 0x060054FA RID: 21754 RVA: 0x00258E73 File Offset: 0x00257073
		public void OpenDropDown()
		{
			this.o.__O0O..OpenDropDown();
		}

		/// <summary>
		/// 下拉列表是否已经打开
		/// </summary>
		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x060054FB RID: 21755 RVA: 0x00258E80 File Offset: 0x00257080
		public bool DroppedDown
		{
			get
			{
				return this.o.__O0O..DroppedDown;
			}
		}

		/// <summary>
		/// 是否允许用户直接输入内容
		/// </summary>
		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x060054FC RID: 21756 RVA: 0x00258E8D File Offset: 0x0025708D
		// (set) Token: 0x060054FD RID: 21757 RVA: 0x00258E9A File Offset: 0x0025709A
		public bool AllowEditValue
		{
			get
			{
				return this.o.__O0O..O.0oo0_.();
			}
			set
			{
				this.o.__O0O..o0O.0___0_.(value);
			}
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x00258EA8 File Offset: 0x002570A8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x040022B8 RID: 8888
		private new OooO00O <<EMPTY_NAME>>;

		// Token: 0x040022B9 RID: 8889
		private new string <<EMPTY_NAME>>;
	}
}
