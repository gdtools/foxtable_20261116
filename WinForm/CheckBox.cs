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
	/// 复选框
	/// </summary>
	// Token: 0x0200051A RID: 1306
	[ComVisible(true)]
	public class CheckBox : Control, OoO_
	{
		// Token: 0x060056A1 RID: 22177 RVA: 0x0025B296 File Offset: 0x00259496
		internal CheckBox(CustomCheckBox A_0) : base(A_0, ControlTypeEnum.CheckBox)
		{
			this.o0.00O. = A_0;
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x060056A2 RID: 22178 RVA: 0x0025B2A7 File Offset: 0x002594A7
		// (set) Token: 0x060056A3 RID: 22179 RVA: 0x0025B2B0 File Offset: 0x002594B0
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
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.CheckBox, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.o0.00O..DataBindings.Add("Checked", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Checked", value);
							if (binding != null)
							{
								this.o0.00O..DataBindings.Add(binding);
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 返回或设置复选框的标题
		/// </summary>
		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x060056A4 RID: 22180 RVA: 0x0025B385 File Offset: 0x00259585
		// (set) Token: 0x060056A5 RID: 22181 RVA: 0x0025B392 File Offset: 0x00259592
		public string Text
		{
			get
			{
				return this.o0.00O..Text;
			}
			set
			{
				this.o0.00O..Text = value;
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x060056A6 RID: 22182 RVA: 0x0025B3A0 File Offset: 0x002595A0
		// (set) Token: 0x060056A7 RID: 22183 RVA: 0x0025B3AD File Offset: 0x002595AD
		[oO0oooo("0749")]
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.o0.00O..ReadOnly;
			}
			set
			{
				this.o0.00O..ReadOnly = value;
			}
		}

		/// <summary>
		/// 设置复选框的外观样式
		/// </summary>
		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x060056A8 RID: 22184 RVA: 0x0025B3BB File Offset: 0x002595BB
		// (set) Token: 0x060056A9 RID: 22185 RVA: 0x0025B3C8 File Offset: 0x002595C8
		[oO0oooo("1882")]
		public Appearance Appearance
		{
			get
			{
				return this.o0.00O..Appearance;
			}
			set
			{
				this.o0.00O..Appearance = value;
			}
		}

		/// <summary>
		/// 是否已经勾选
		/// </summary>
		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x060056AA RID: 22186 RVA: 0x0025B3D6 File Offset: 0x002595D6
		// (set) Token: 0x060056AB RID: 22187 RVA: 0x0025B3E8 File Offset: 0x002595E8
		[oO0oooo("0777")]
		public bool Checked
		{
			get
			{
				return Conversions.ToBoolean(this.o0.00O..Checked);
			}
			set
			{
				this.o0.00O..Checked = value;
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x060056AC RID: 22188 RVA: 0x0025B3FB File Offset: 0x002595FB
		// (set) Token: 0x060056AD RID: 22189 RVA: 0x0025B408 File Offset: 0x00259608
		public VisualStyle VisualStyle
		{
			get
			{
				return this.o0.00O..VisualStyleBaseStyle;
			}
			set
			{
				this.o0.00O..VisualStyle = value;
				this.o0.00O..VisualStyleBaseStyle = value;
			}
		}

		/// <summary>
		/// 复选框标题的对齐方式
		/// </summary>
		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x060056AE RID: 22190 RVA: 0x0025B422 File Offset: 0x00259622
		// (set) Token: 0x060056AF RID: 22191 RVA: 0x0025B42F File Offset: 0x0025962F
		[oO0oooo("1878")]
		public ContentAlignment TextAlign
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
		/// 复选框的对齐方式
		/// </summary>
		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x060056B0 RID: 22192 RVA: 0x0025B43D File Offset: 0x0025963D
		// (set) Token: 0x060056B1 RID: 22193 RVA: 0x0025B44A File Offset: 0x0025964A
		[oO0oooo("1879")]
		public ContentAlignment CheckAlign
		{
			get
			{
				return this.o0.00O..CheckAlign;
			}
			set
			{
				this.o0.00O..CheckAlign = value;
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x060056B2 RID: 22194 RVA: 0x0025B458 File Offset: 0x00259658
		// (set) Token: 0x060056B3 RID: 22195 RVA: 0x0025B45B File Offset: 0x0025965B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ImageFile
		{
			get
			{
				return null;
			}
			set
			{
				this.o0.00O..Image = OO_00oOO.GetImage(value);
			}
		}

		/// <summary>
		/// 复选框图标的对齐方式
		/// </summary>
		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x060056B4 RID: 22196 RVA: 0x0025B46E File Offset: 0x0025966E
		// (set) Token: 0x060056B5 RID: 22197 RVA: 0x0025B47B File Offset: 0x0025967B
		[oO0oooo("1880")]
		public ContentAlignment ImageAlign
		{
			get
			{
				return this.o0.00O..ImageAlign;
			}
			set
			{
				this.o0.00O..ImageAlign = value;
			}
		}

		/// <summary>
		/// 设置文本和图标的相对位置
		/// </summary>
		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x060056B6 RID: 22198 RVA: 0x0025B489 File Offset: 0x00259689
		// (set) Token: 0x060056B7 RID: 22199 RVA: 0x0025B496 File Offset: 0x00259696
		[oO0oooo("1881")]
		public TextImageRelation TextImageRelation
		{
			get
			{
				return this.o0.00O..TextImageRelation;
			}
			set
			{
				this.o0.00O..TextImageRelation = value;
			}
		}

		/// <summary>
		/// 设置复选框的图标
		/// </summary>
		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x060056B8 RID: 22200 RVA: 0x0025B4A4 File Offset: 0x002596A4
		// (set) Token: 0x060056B9 RID: 22201 RVA: 0x0025B4B1 File Offset: 0x002596B1
		[oO0oooo("0780")]
		public Image Image
		{
			get
			{
				return this.o0.00O..Image;
			}
			set
			{
				this.o0.00O..Image = value;
			}
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x0025B4BF File Offset: 0x002596BF
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x040022CB RID: 8907
		private CustomCheckBox <<EMPTY_NAME>>;
	}
}
