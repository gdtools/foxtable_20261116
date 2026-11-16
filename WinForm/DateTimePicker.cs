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
	/// 日期输入框
	/// </summary>
	// Token: 0x0200051F RID: 1311
	[ComVisible(true)]
	public class DateTimePicker : Control, OoO_
	{
		// Token: 0x060057A1 RID: 22433 RVA: 0x0025CE32 File Offset: 0x0025B032
		internal DateTimePicker(O_0oOoOo A_0) : base(A_0, ControlTypeEnum.DateTimePicker)
		{
			this.o.__O0O. = A_0;
		}

		/// <summary>
		/// 文本内容
		/// </summary>
		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x060057A2 RID: 22434 RVA: 0x0025CE43 File Offset: 0x0025B043
		// (set) Token: 0x060057A3 RID: 22435 RVA: 0x0025CE50 File Offset: 0x0025B050
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
		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x060057A4 RID: 22436 RVA: 0x0025CE5E File Offset: 0x0025B05E
		// (set) Token: 0x060057A5 RID: 22437 RVA: 0x0025CE6C File Offset: 0x0025B06C
		public object Value
		{
			get
			{
				return this.o.__O0O..Value;
			}
			set
			{
				if (value == null)
				{
					this.o.__O0O..Value = null;
					return;
				}
				if (Operators.CompareString(value.ToString(), "0:00:00", true) == 0)
				{
					this.o.__O0O..Value = null;
					return;
				}
				this.o.__O0O..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x060057A6 RID: 22438 RVA: 0x0025CEBA File Offset: 0x0025B0BA
		// (set) Token: 0x060057A7 RID: 22439 RVA: 0x0025CEC7 File Offset: 0x0025B0C7
		[oO0oooo("0749")]
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.o.__O0O..O0O.O0.();
			}
			set
			{
				this.o.__O0O..oO._0o_O__.(value);
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x060057A8 RID: 22440 RVA: 0x0025CED5 File Offset: 0x0025B0D5
		// (set) Token: 0x060057A9 RID: 22441 RVA: 0x0025CEE0 File Offset: 0x0025B0E0
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
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.DateTimePicker, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.o.__O0O..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text);
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
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x060057AA RID: 22442 RVA: 0x0025CFBC File Offset: 0x0025B1BC
		// (set) Token: 0x060057AB RID: 22443 RVA: 0x0025CFCA File Offset: 0x0025B1CA
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
		/// 设置日期时间格式
		/// </summary>
		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x060057AC RID: 22444 RVA: 0x0025CFCC File Offset: 0x0025B1CC
		// (set) Token: 0x060057AD RID: 22445 RVA: 0x0025CFD9 File Offset: 0x0025B1D9
		[oO0oooo("2033")]
		public DateTimeFormatEnum DateTimeFormat
		{
			get
			{
				return this.o.__O0O..O0O.O0.();
			}
			set
			{
				this.o.__O0O..O0O.O0.(value);
			}
		}

		/// <summary>
		/// 文本对齐方式
		/// </summary>
		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x060057AE RID: 22446 RVA: 0x0025CFE7 File Offset: 0x0025B1E7
		// (set) Token: 0x060057AF RID: 22447 RVA: 0x0025CFF4 File Offset: 0x0025B1F4
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

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x060057B0 RID: 22448 RVA: 0x0025D002 File Offset: 0x0025B202
		// (set) Token: 0x060057B1 RID: 22449 RVA: 0x0025D00F File Offset: 0x0025B20F
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
		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x060057B2 RID: 22450 RVA: 0x0025D01D File Offset: 0x0025B21D
		// (set) Token: 0x060057B3 RID: 22451 RVA: 0x0025D02A File Offset: 0x0025B22A
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

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x060057B4 RID: 22452 RVA: 0x0025D038 File Offset: 0x0025B238
		// (set) Token: 0x060057B5 RID: 22453 RVA: 0x0025D045 File Offset: 0x0025B245
		[EditorBrowsable(EditorBrowsableState.Never)]
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
		/// 是否在下拉日历中显示周数
		/// </summary>
		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x060057B6 RID: 22454 RVA: 0x0025D053 File Offset: 0x0025B253
		// (set) Token: 0x060057B7 RID: 22455 RVA: 0x0025D060 File Offset: 0x0025B260
		public bool ShowWeekNumbers
		{
			get
			{
				return this.o.__O0O..O0O.O0.();
			}
			set
			{
				this.o.__O0O..oo0_O_Ooo._.(value);
			}
		}

		/// <summary>
		/// 是否显示下拉按钮
		/// </summary>
		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x0025D06E File Offset: 0x0025B26E
		// (set) Token: 0x060057B9 RID: 22457 RVA: 0x0025D07B File Offset: 0x0025B27B
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
		/// 下拉日历维数
		/// </summary>
		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x060057BA RID: 22458 RVA: 0x0025D089 File Offset: 0x0025B289
		// (set) Token: 0x060057BB RID: 22459 RVA: 0x0025D096 File Offset: 0x0025B296
		public Size CalendarDimensions
		{
			get
			{
				return this.o.__O0O..O.o0O_.();
			}
			set
			{
				this.o.__O0O..O0O.O0.(value);
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x060057BC RID: 22460 RVA: 0x0025D0A4 File Offset: 0x0025B2A4
		// (set) Token: 0x060057BD RID: 22461 RVA: 0x0025D0B1 File Offset: 0x0025B2B1
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
		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x060057BE RID: 22462 RVA: 0x0025D0BF File Offset: 0x0025B2BF
		// (set) Token: 0x060057BF RID: 22463 RVA: 0x0025D0CC File Offset: 0x0025B2CC
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
		/// 选定输入框中的全部内容
		/// </summary>
		// Token: 0x060057C0 RID: 22464 RVA: 0x0025D0DA File Offset: 0x0025B2DA
		public void SelectAll()
		{
			this.o.__O0O..SelectAll();
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x0025D0E7 File Offset: 0x0025B2E7
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x040022D0 RID: 8912
		private new O_0oOoOo <<EMPTY_NAME>>;
	}
}
