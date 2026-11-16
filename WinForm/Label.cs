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
	/// 标签
	/// </summary>
	// Token: 0x0200052B RID: 1323
	[ComVisible(true)]
	public class Label : Control, OoO_
	{
		// Token: 0x06005815 RID: 22549 RVA: 0x0025DFF5 File Offset: 0x0025C1F5
		public Label(OO_0o_O_O A_0) : base(A_0, ControlTypeEnum.Label)
		{
			this.o0_0oO.OooO. = A_0;
		}

		/// <summary>
		/// 文本内容
		/// </summary>
		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06005816 RID: 22550 RVA: 0x0025E006 File Offset: 0x0025C206
		// (set) Token: 0x06005817 RID: 22551 RVA: 0x0025E013 File Offset: 0x0025C213
		public string Text
		{
			get
			{
				return this.o0_0oO.OooO..Text;
			}
			set
			{
				this.o0_0oO.OooO..Value = value;
			}
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06005818 RID: 22552 RVA: 0x0025E021 File Offset: 0x0025C221
		// (set) Token: 0x06005819 RID: 22553 RVA: 0x0025E02C File Offset: 0x0025C22C
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.o0_0oO.OooO..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.Label, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.o0_0oO.OooO..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text);
								this.o0_0oO.OooO..DataType = OO_00oOO.Vars.VariableTable.Columns[text].DataType;
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value", value);
							if (binding != null)
							{
								this.o0_0oO.OooO..DataBindings.Add(binding);
								if (this.o0_0oO.OooO..DataBindings.Count > 0)
								{
									int num = value.LastIndexOf('.');
									string a_ = value.Substring(0, num);
									string name = value.Substring(num + 1);
									this.o0_0oO.OooO..DataType = OO_00oOO.Tables[a_].DataTable.BaseTable.Columns[name].DataType;
								}
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 是否自动调整大小
		/// </summary>
		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x0600581A RID: 22554 RVA: 0x0025E18D File Offset: 0x0025C38D
		// (set) Token: 0x0600581B RID: 22555 RVA: 0x0025E19C File Offset: 0x0025C39C
		public bool AutoSize
		{
			get
			{
				return this.o0_0oO.OooO..AutoSize;
			}
			set
			{
				int width = this.o0_0oO.OooO..Width;
				int height = this.o0_0oO.OooO..Height;
				this.o0_0oO.OooO..AutoSize = value;
				this.o0_0oO.OooO..Width = width;
				this.o0_0oO.OooO..Height = height;
			}
		}

		/// <summary>
		/// 宽度
		/// </summary>
		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x0600581C RID: 22556 RVA: 0x0025E1E5 File Offset: 0x0025C3E5
		// (set) Token: 0x0600581D RID: 22557 RVA: 0x0025E1F2 File Offset: 0x0025C3F2
		public override int Width
		{
			get
			{
				return this.o0_0oO.OooO..Width;
			}
			set
			{
				this.o0_0oO.OooO..Width = value;
			}
		}

		/// <summary>
		/// 高度
		/// </summary>
		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x0600581E RID: 22558 RVA: 0x0025E200 File Offset: 0x0025C400
		// (set) Token: 0x0600581F RID: 22559 RVA: 0x0025E20D File Offset: 0x0025C40D
		public override int Height
		{
			get
			{
				return this.o0_0oO.OooO..Height;
			}
			set
			{
				this.o0_0oO.OooO..Height = value;
			}
		}

		/// <summary>
		/// 边框样式
		/// </summary>
		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06005820 RID: 22560 RVA: 0x0025E21B File Offset: 0x0025C41B
		// (set) Token: 0x06005821 RID: 22561 RVA: 0x0025E228 File Offset: 0x0025C428
		[oO0oooo("3096")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.o0_0oO.OooO..BorderStyle;
			}
			set
			{
				if (this.o0_0oO.OooO..VisualStyleBaseStyle != VisualStyle.Office2010Blue)
				{
					Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
					{
						this.o0_0oO.OooO.
					});
					this.o0_0oO.OooO..VisualStyleBaseStyle = VisualStyle.Office2007Blue;
				}
				this.o0_0oO.OooO..BorderStyle = value;
			}
		}

		/// <summary>
		/// 边框颜色
		/// </summary>
		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06005822 RID: 22562 RVA: 0x0025E274 File Offset: 0x0025C474
		// (set) Token: 0x06005823 RID: 22563 RVA: 0x0025E284 File Offset: 0x0025C484
		[oO0oooo("3095")]
		public Color BorderColor
		{
			get
			{
				return this.o0_0oO.OooO..BorderColor;
			}
			set
			{
				if (this.o0_0oO.OooO..VisualStyleBaseStyle != VisualStyle.Office2010Blue)
				{
					Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
					{
						this.o0_0oO.OooO.
					});
					this.o0_0oO.OooO..VisualStyleBaseStyle = VisualStyle.Office2010Blue;
				}
				this.o0_0oO.OooO..BorderColor = value;
			}
		}

		/// <summary>
		/// 文本对其方式
		/// </summary>
		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06005824 RID: 22564 RVA: 0x0025E2D0 File Offset: 0x0025C4D0
		// (set) Token: 0x06005825 RID: 22565 RVA: 0x0025E2DD File Offset: 0x0025C4DD
		[oO0oooo("1859")]
		public ContentAlignment TextAlign
		{
			get
			{
				return this.o0_0oO.OooO..TextAlign;
			}
			set
			{
				this.o0_0oO.OooO..TextAlign = value;
			}
		}

		/// <summary>
		/// 格式符号
		/// </summary>
		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06005826 RID: 22566 RVA: 0x0025E2EB File Offset: 0x0025C4EB
		// (set) Token: 0x06005827 RID: 22567 RVA: 0x0025E2F8 File Offset: 0x0025C4F8
		[oO0oooo("3099")]
		public string FormatString
		{
			get
			{
				return this.o0_0oO.OooO..CustomFormat;
			}
			set
			{
				this.o0_0oO.OooO..CustomFormat = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.o0_0oO.OooO..FormatType = FormatTypeEnum.CustomFormat;
					return;
				}
				this.o0_0oO.OooO..FormatType = FormatTypeEnum.DefaultFormat;
			}
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x0025E32E File Offset: 0x0025C52E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x04002305 RID: 8965
		private OO_0o_O_O <<EMPTY_NAME>>;
	}
}
