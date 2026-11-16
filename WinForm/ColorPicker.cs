using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 颜色选择框
	/// </summary>
	// Token: 0x02000503 RID: 1283
	[oO0oooo("3105")]
	[ComVisible(true)]
	public class ColorPicker : Control, OoO_
	{
		// Token: 0x060053DD RID: 21469 RVA: 0x0025699F File Offset: 0x00254B9F
		public ColorPicker(oOO A_0) : base(A_0, ControlTypeEnum.ColorPicker)
		{
			this.o_Oo._O_00000_. = A_0;
		}

		/// <summary>
		/// 颜色
		/// </summary>
		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x002569B1 File Offset: 0x00254BB1
		// (set) Token: 0x060053DF RID: 21471 RVA: 0x002569BE File Offset: 0x00254BBE
		public Color Color
		{
			get
			{
				return this.o_Oo._O_00000_..Color;
			}
			set
			{
				this.o_Oo._O_00000_..Color = value;
			}
		}

		/// <summary>
		/// 文本内容
		/// </summary>
		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x002569CC File Offset: 0x00254BCC
		public string Text
		{
			get
			{
				return this.o_Oo._O_00000_..Text;
			}
		}

		/// <summary>
		/// 颜色
		/// </summary>
		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x060053E1 RID: 21473 RVA: 0x002569D9 File Offset: 0x00254BD9
		// (set) Token: 0x060053E2 RID: 21474 RVA: 0x002569E6 File Offset: 0x00254BE6
		public Color Value
		{
			get
			{
				return this.o_Oo._O_00000_..Color;
			}
			set
			{
				this.o_Oo._O_00000_..Color = value;
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060053E3 RID: 21475 RVA: 0x002569F4 File Offset: 0x00254BF4
		// (set) Token: 0x060053E4 RID: 21476 RVA: 0x00256A01 File Offset: 0x00254C01
		public virtual BooleanEnum ReadOnly
		{
			get
			{
				return this.o_Oo._O_00000_..o.Oo.();
			}
			set
			{
				this.o_Oo._O_00000_..o.Oo.(value);
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060053E5 RID: 21477 RVA: 0x00256A0F File Offset: 0x00254C0F
		// (set) Token: 0x060053E6 RID: 21478 RVA: 0x00256A18 File Offset: 0x00254C18
		[oO0oooo("1860")]
		public virtual string BindingField
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
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.ColorPicker, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.o_Oo._O_00000_..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value2", value);
							if (binding != null)
							{
								this.o_Oo._O_00000_..DataBindings.Add(binding);
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060053E7 RID: 21479 RVA: 0x00256AF0 File Offset: 0x00254CF0
		// (set) Token: 0x060053E8 RID: 21480 RVA: 0x00256AFE File Offset: 0x00254CFE
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
		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060053E9 RID: 21481 RVA: 0x00256B00 File Offset: 0x00254D00
		// (set) Token: 0x060053EA RID: 21482 RVA: 0x00256B0D File Offset: 0x00254D0D
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
		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060053EB RID: 21483 RVA: 0x00256B1B File Offset: 0x00254D1B
		// (set) Token: 0x060053EC RID: 21484 RVA: 0x00256B28 File Offset: 0x00254D28
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
		/// 背景颜色
		/// </summary>
		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060053ED RID: 21485 RVA: 0x00256B36 File Offset: 0x00254D36
		// (set) Token: 0x060053EE RID: 21486 RVA: 0x00256B43 File Offset: 0x00254D43
		public virtual Color BackColor
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
		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060053EF RID: 21487 RVA: 0x00256B51 File Offset: 0x00254D51
		// (set) Token: 0x060053F0 RID: 21488 RVA: 0x00256B5E File Offset: 0x00254D5E
		public virtual Color ForeColor
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

		// Token: 0x060053F1 RID: 21489 RVA: 0x00256B6C File Offset: 0x00254D6C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x040022AB RID: 8875
		private oOO <<EMPTY_NAME>>;
	}
}
