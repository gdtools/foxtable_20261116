using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 颜色标签
	/// </summary>
	// Token: 0x0200051D RID: 1309
	[ComVisible(true)]
	public class ColorLabel : Control, OoO_
	{
		// Token: 0x0600573B RID: 22331 RVA: 0x0025C365 File Offset: 0x0025A565
		internal ColorLabel(CustomColorLabel A_0) : base(A_0, ControlTypeEnum.ColorLabel)
		{
			this.O00O.0OOO00. = A_0;
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x0600573C RID: 22332 RVA: 0x0025C377 File Offset: 0x0025A577
		// (set) Token: 0x0600573D RID: 22333 RVA: 0x0025C380 File Offset: 0x0025A580
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.O00O.0OOO00..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.ColorLabel, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.O00O.0OOO00..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value", value);
							if (binding != null)
							{
								this.O00O.0OOO00..DataBindings.Add(binding);
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 返回或者设置ColorLabel的颜色
		/// </summary>
		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x0600573E RID: 22334 RVA: 0x0025C456 File Offset: 0x0025A656
		// (set) Token: 0x0600573F RID: 22335 RVA: 0x0025C463 File Offset: 0x0025A663
		[oO0oooo("0789")]
		public object Value
		{
			get
			{
				return this.O00O.0OOO00..Value;
			}
			set
			{
				this.O00O.0OOO00..Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 返回或者设置ColorLabel的颜色
		/// </summary>
		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x06005740 RID: 22336 RVA: 0x0025C476 File Offset: 0x0025A676
		// (set) Token: 0x06005741 RID: 22337 RVA: 0x0025C483 File Offset: 0x0025A683
		[oO0oooo("0790")]
		public Color Color
		{
			get
			{
				return this.O00O.0OOO00..BackColor;
			}
			set
			{
				this.O00O.0OOO00..BackColor = value;
			}
		}

		/// <summary>
		/// 边框颜色
		/// </summary>
		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x06005742 RID: 22338 RVA: 0x0025C491 File Offset: 0x0025A691
		// (set) Token: 0x06005743 RID: 22339 RVA: 0x0025C49E File Offset: 0x0025A69E
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O00O.0OOO00..BorderStyle;
			}
			set
			{
				this.O00O.0OOO00..BorderStyle = value;
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x06005744 RID: 22340 RVA: 0x0025C4AC File Offset: 0x0025A6AC
		// (set) Token: 0x06005745 RID: 22341 RVA: 0x0025C4B9 File Offset: 0x0025A6B9
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ContentAlignment TextAlign
		{
			get
			{
				return this.O00O.0OOO00..TextAlign;
			}
			set
			{
				this.O00O.0OOO00..TextAlign = value;
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x06005746 RID: 22342 RVA: 0x0025C4C7 File Offset: 0x0025A6C7
		// (set) Token: 0x06005747 RID: 22343 RVA: 0x0025C4D4 File Offset: 0x0025A6D4
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.O00O.0OOO00..ReadOnly;
			}
			set
			{
				this.O00O.0OOO00..ReadOnly = value;
			}
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x0025C4E2 File Offset: 0x0025A6E2
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x040022CE RID: 8910
		private CustomColorLabel <<EMPTY_NAME>>;
	}
}
