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
	/// 时段输入框
	/// </summary>
	// Token: 0x02000512 RID: 1298
	[ComVisible(true)]
	public class TimeSpanBox : Control, OoO_
	{
		// Token: 0x0600550C RID: 21772 RVA: 0x00258FDB File Offset: 0x002571DB
		internal TimeSpanBox(o__0OoO_ A_0) : base(A_0, ControlTypeEnum.TimeSpanBox)
		{
			this.o.OOoo. = A_0;
		}

		/// <summary>
		/// 文本内容
		/// </summary>
		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x0600550D RID: 21773 RVA: 0x00258FED File Offset: 0x002571ED
		// (set) Token: 0x0600550E RID: 21774 RVA: 0x00258FFA File Offset: 0x002571FA
		[oO0oooo("0750")]
		public string Text
		{
			get
			{
				return this.o.OOoo..Text;
			}
			set
			{
				this.o.OOoo..Value = value;
			}
		}

		/// <summary>
		/// 返回TimeSpanBox的值，以秒为单位
		/// </summary>
		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x0600550F RID: 21775 RVA: 0x00259008 File Offset: 0x00257208
		// (set) Token: 0x06005510 RID: 21776 RVA: 0x00259043 File Offset: 0x00257243
		public object Value
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.o.OOoo..Value);
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
				this.o.OOoo..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06005511 RID: 21777 RVA: 0x00259056 File Offset: 0x00257256
		// (set) Token: 0x06005512 RID: 21778 RVA: 0x00259063 File Offset: 0x00257263
		[oO0oooo("0749")]
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.o.OOoo..O_o.0.();
			}
			set
			{
				this.o.OOoo..O_o.0.(value);
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06005513 RID: 21779 RVA: 0x00259071 File Offset: 0x00257271
		// (set) Token: 0x06005514 RID: 21780 RVA: 0x0025907C File Offset: 0x0025727C
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.o.OOoo..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.TimeSpanBox, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.o.OOoo..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text);
								this.o.OOoo..DataType = OO_00oOO.Vars.VariableTable.Columns[text].DataType;
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value2", value);
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
							if (binding != null)
							{
								this.o.OOoo..DataBindings.Add(binding);
								if (this.o.OOoo..DataBindings.Count > 0)
								{
									int num = value.LastIndexOf('.');
									string a_ = value.Substring(0, num);
									string name = value.Substring(num + 1);
									this.o.OOoo..DataType = OO_00oOO.Tables[a_].DataTable.BaseTable.Columns[name].DataType;
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
		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06005515 RID: 21781 RVA: 0x002591E5 File Offset: 0x002573E5
		// (set) Token: 0x06005516 RID: 21782 RVA: 0x002591F2 File Offset: 0x002573F2
		[oO0oooo("1861")]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.o.OOoo..TextAlign;
			}
			set
			{
				this.o.OOoo..TextAlign = value;
			}
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06005517 RID: 21783 RVA: 0x00259200 File Offset: 0x00257400
		// (set) Token: 0x06005518 RID: 21784 RVA: 0x0025920D File Offset: 0x0025740D
		public BorderStyle BorderStyle
		{
			get
			{
				return this.o.OOoo..BorderStyle;
			}
			set
			{
				this.o.OOoo..BorderStyle = value;
			}
		}

		/// <summary>
		/// 边框颜色
		/// </summary>
		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06005519 RID: 21785 RVA: 0x0025921B File Offset: 0x0025741B
		// (set) Token: 0x0600551A RID: 21786 RVA: 0x00259228 File Offset: 0x00257428
		public Color BorderColor
		{
			get
			{
				return this.o.OOoo..BorderColor;
			}
			set
			{
				this.o.OOoo..BorderColor = value;
			}
		}

		/// <summary>
		/// 输入掩码
		/// </summary>
		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x0600551B RID: 21787 RVA: 0x00259236 File Offset: 0x00257436
		// (set) Token: 0x0600551C RID: 21788 RVA: 0x00259243 File Offset: 0x00257443
		[oO0oooo("1866")]
		public string EditMask
		{
			get
			{
				return this.o.OOoo..EditMask;
			}
			set
			{
				this.o.OOoo..EditMask = value;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x0600551D RID: 21789 RVA: 0x00259251 File Offset: 0x00257451
		// (set) Token: 0x0600551E RID: 21790 RVA: 0x0025925E File Offset: 0x0025745E
		[oO0oooo("0720")]
		public override Color BackColor
		{
			get
			{
				return this.o.OOoo..BackColor;
			}
			set
			{
				this.o.OOoo..BackColor = value;
			}
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x0600551F RID: 21791 RVA: 0x0025926C File Offset: 0x0025746C
		// (set) Token: 0x06005520 RID: 21792 RVA: 0x00259279 File Offset: 0x00257479
		[oO0oooo("0721")]
		public override Color ForeColor
		{
			get
			{
				return this.o.OOoo..ForeColor;
			}
			set
			{
				this.o.OOoo..ForeColor = value;
			}
		}

		/// <summary>
		/// 输入框获得焦点后，内容的初始选定范围
		/// </summary>
		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06005521 RID: 21793 RVA: 0x00259287 File Offset: 0x00257487
		// (set) Token: 0x06005522 RID: 21794 RVA: 0x00259294 File Offset: 0x00257494
		public InitialSelectionEnum InitialSelection
		{
			get
			{
				return this.o.OOoo..InitialSelection;
			}
			set
			{
				this.o.OOoo..InitialSelection = value;
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06005523 RID: 21795 RVA: 0x002592A4 File Offset: 0x002574A4
		// (set) Token: 0x06005524 RID: 21796 RVA: 0x002592B2 File Offset: 0x002574B2
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
		/// 返回或设置输入框中选定的文本
		/// </summary>
		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06005525 RID: 21797 RVA: 0x002592B4 File Offset: 0x002574B4
		// (set) Token: 0x06005526 RID: 21798 RVA: 0x002592C1 File Offset: 0x002574C1
		[oO0oooo("0740")]
		public string SelectedText
		{
			get
			{
				return this.o.OOoo..SelectedText;
			}
			set
			{
				this.o.OOoo..SelectedText = value;
			}
		}

		/// <summary>
		/// 返回文本框中选定字符的起始位置
		/// </summary>
		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06005527 RID: 21799 RVA: 0x002592CF File Offset: 0x002574CF
		// (set) Token: 0x06005528 RID: 21800 RVA: 0x002592DC File Offset: 0x002574DC
		public int SelectionStart
		{
			get
			{
				return this.o.OOoo..SelectionStart;
			}
			set
			{
				this.o.OOoo..SelectionStart = value;
			}
		}

		/// <summary>
		/// 返回或设置文本框中选定字符的长度
		/// </summary>
		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06005529 RID: 21801 RVA: 0x002592EA File Offset: 0x002574EA
		// (set) Token: 0x0600552A RID: 21802 RVA: 0x002592F7 File Offset: 0x002574F7
		public int SelectionLength
		{
			get
			{
				return this.o.OOoo..SelectionLength;
			}
			set
			{
				this.o.OOoo..SelectionLength = value;
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x0600552B RID: 21803 RVA: 0x00259305 File Offset: 0x00257505
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string[] Lines
		{
			get
			{
				return this.o.OOoo..Lines;
			}
		}

		/// <summary>
		/// 选定输入框中的全部内容
		/// </summary>
		// Token: 0x0600552C RID: 21804 RVA: 0x00259312 File Offset: 0x00257512
		public void SelectAll()
		{
			this.o.OOoo..SelectAll();
		}

		/// <summary>
		/// 复制选定内容到剪贴板
		/// </summary>
		// Token: 0x0600552D RID: 21805 RVA: 0x0025931F File Offset: 0x0025751F
		public void Copy()
		{
			this.o.OOoo..Copy();
		}

		/// <summary>
		/// 剪切选定内容到剪贴板
		/// </summary>
		// Token: 0x0600552E RID: 21806 RVA: 0x0025932C File Offset: 0x0025752C
		public void Cut()
		{
			this.o.OOoo..Cut();
		}

		/// <summary>
		/// 用剪贴板内容替换输入框中的选定内容
		/// </summary>
		// Token: 0x0600552F RID: 21807 RVA: 0x00259339 File Offset: 0x00257539
		public void Paste()
		{
			this.o.OOoo..Paste();
		}

		/// <summary>
		/// 撤销上次操作
		/// </summary>
		// Token: 0x06005530 RID: 21808 RVA: 0x00259346 File Offset: 0x00257546
		public void Undo()
		{
			this.o.OOoo..Undo();
		}

		/// <summary>
		/// 重置文本内容
		/// </summary>
		// Token: 0x06005531 RID: 21809 RVA: 0x00259353 File Offset: 0x00257553
		public void ResetText()
		{
			this.o.OOoo..ResetText();
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x00259360 File Offset: 0x00257560
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x040022BB RID: 8891
		private o__0OoO_ <<EMPTY_NAME>>;

		// Token: 0x040022BC RID: 8892
		private string <<EMPTY_NAME>>;
	}
}
