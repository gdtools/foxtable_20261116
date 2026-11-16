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
	/// 字体选择框
	/// </summary>
	// Token: 0x02000508 RID: 1288
	[ComVisible(true)]
	[oO0oooo("3104")]
	public class FontPicker : Control, OoO_
	{
		// Token: 0x060053FE RID: 21502 RVA: 0x00256F72 File Offset: 0x00255172
		public FontPicker(O00o A_0) : base(A_0, ControlTypeEnum.FontPicker)
		{
			this.O.00oo_OO0O. = A_0;
		}

		/// <summary>
		/// 文本内容
		/// </summary>
		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060053FF RID: 21503 RVA: 0x00256F84 File Offset: 0x00255184
		public string Text
		{
			get
			{
				return this.O.00oo_OO0O..Text;
			}
		}

		/// <summary>
		/// 返回或设置字体名称
		/// </summary>
		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x00256F91 File Offset: 0x00255191
		// (set) Token: 0x06005401 RID: 21505 RVA: 0x00256F9E File Offset: 0x0025519E
		public object Value
		{
			get
			{
				return this.O.00oo_OO0O..Value;
			}
			set
			{
				this.O.00oo_OO0O..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x00256FB1 File Offset: 0x002551B1
		// (set) Token: 0x06005403 RID: 21507 RVA: 0x00256FBE File Offset: 0x002551BE
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.O.00oo_OO0O..OoO0O0.0O_oo.();
			}
			set
			{
				this.O.00oo_OO0O..OoO0O0.0O_oo.(value);
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06005404 RID: 21508 RVA: 0x00256FCC File Offset: 0x002551CC
		// (set) Token: 0x06005405 RID: 21509 RVA: 0x00256FD4 File Offset: 0x002551D4
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.O.00oo_OO0O..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.FontPicker, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.O.00oo_OO0O..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value", value);
							if (binding != null)
							{
								this.O.00oo_OO0O..DataBindings.Add(binding);
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x06005406 RID: 21510 RVA: 0x002570AC File Offset: 0x002552AC
		// (set) Token: 0x06005407 RID: 21511 RVA: 0x002570BA File Offset: 0x002552BA
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
		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x06005408 RID: 21512 RVA: 0x002570BC File Offset: 0x002552BC
		// (set) Token: 0x06005409 RID: 21513 RVA: 0x002570C9 File Offset: 0x002552C9
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O.00oo_OO0O..BorderStyle;
			}
			set
			{
				this.O.00oo_OO0O..BorderStyle = value;
			}
		}

		/// <summary>
		/// 边框颜色
		/// </summary>
		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x0600540A RID: 21514 RVA: 0x002570D7 File Offset: 0x002552D7
		// (set) Token: 0x0600540B RID: 21515 RVA: 0x002570E4 File Offset: 0x002552E4
		public Color BorderColor
		{
			get
			{
				return this.O.00oo_OO0O..BorderColor;
			}
			set
			{
				this.O.00oo_OO0O..BorderColor = value;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x0600540C RID: 21516 RVA: 0x002570F2 File Offset: 0x002552F2
		// (set) Token: 0x0600540D RID: 21517 RVA: 0x002570FF File Offset: 0x002552FF
		public override Color BackColor
		{
			get
			{
				return this.O.00oo_OO0O..BackColor;
			}
			set
			{
				this.O.00oo_OO0O..BackColor = value;
			}
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x0600540E RID: 21518 RVA: 0x0025710D File Offset: 0x0025530D
		// (set) Token: 0x0600540F RID: 21519 RVA: 0x0025711A File Offset: 0x0025531A
		public override Color ForeColor
		{
			get
			{
				return this.O.00oo_OO0O..ForeColor;
			}
			set
			{
				this.O.00oo_OO0O..ForeColor = value;
			}
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x00257128 File Offset: 0x00255328
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x040022B0 RID: 8880
		private O00o <<EMPTY_NAME>>;
	}
}
