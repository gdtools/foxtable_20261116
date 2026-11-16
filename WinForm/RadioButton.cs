using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 单选框
	/// </summary>
	// Token: 0x02000535 RID: 1333
	[ComVisible(true)]
	public class RadioButton : Control, OoO_
	{
		// Token: 0x06005911 RID: 22801 RVA: 0x0025FADE File Offset: 0x0025DCDE
		internal RadioButton(oO00O0oO0o000 A_0) : base(A_0, ControlTypeEnum.RadioButton)
		{
			this.Oooo.Oo_0O. = A_0;
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06005912 RID: 22802 RVA: 0x0025FAEF File Offset: 0x0025DCEF
		// (set) Token: 0x06005913 RID: 22803 RVA: 0x0025FAF8 File Offset: 0x0025DCF8
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.Oooo.Oo_0O..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.RadioButton, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.Oooo.Oo_0O..DataBindings.Add("Checked", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Checked", value);
							if (binding != null)
							{
								this.Oooo.Oo_0O..DataBindings.Add(binding);
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 单选框的标题
		/// </summary>
		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06005914 RID: 22804 RVA: 0x0025FBCD File Offset: 0x0025DDCD
		// (set) Token: 0x06005915 RID: 22805 RVA: 0x0025FBDA File Offset: 0x0025DDDA
		public string Text
		{
			get
			{
				return this.Oooo.Oo_0O..Text;
			}
			set
			{
				this.Oooo.Oo_0O..Text = value;
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06005916 RID: 22806 RVA: 0x0025FBE8 File Offset: 0x0025DDE8
		// (set) Token: 0x06005917 RID: 22807 RVA: 0x0025FBF5 File Offset: 0x0025DDF5
		[oO0oooo("0749")]
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.Oooo.Oo_0O..O00_o0_.O__oo.();
			}
			set
			{
				this.Oooo.Oo_0O..O00_o0_.O__oo.(value);
			}
		}

		/// <summary>
		/// 设置单选框的外观样式
		/// </summary>
		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x06005918 RID: 22808 RVA: 0x0025FC03 File Offset: 0x0025DE03
		// (set) Token: 0x06005919 RID: 22809 RVA: 0x0025FC10 File Offset: 0x0025DE10
		[oO0oooo("1883")]
		public Appearance Appearance
		{
			get
			{
				return this.Oooo.Oo_0O..Appearance;
			}
			set
			{
				this.Oooo.Oo_0O..Appearance = value;
			}
		}

		/// <summary>
		/// 返回或设置单选框的选中状态
		/// </summary>
		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x0600591A RID: 22810 RVA: 0x0025FC1E File Offset: 0x0025DE1E
		// (set) Token: 0x0600591B RID: 22811 RVA: 0x0025FC30 File Offset: 0x0025DE30
		public bool Checked
		{
			get
			{
				return Conversions.ToBoolean(this.Oooo.Oo_0O..Checked);
			}
			set
			{
				this.Oooo.Oo_0O..Checked = value;
			}
		}

		/// <summary>
		/// 标题对齐方式
		/// </summary>
		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x0600591C RID: 22812 RVA: 0x0025FC43 File Offset: 0x0025DE43
		// (set) Token: 0x0600591D RID: 22813 RVA: 0x0025FC50 File Offset: 0x0025DE50
		[oO0oooo("1884")]
		public ContentAlignment TextAlign
		{
			get
			{
				return this.Oooo.Oo_0O..TextAlign;
			}
			set
			{
				this.Oooo.Oo_0O..TextAlign = value;
			}
		}

		/// <summary>
		/// 单选框的对齐方式
		/// </summary>
		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x0600591E RID: 22814 RVA: 0x0025FC5E File Offset: 0x0025DE5E
		// (set) Token: 0x0600591F RID: 22815 RVA: 0x0025FC6B File Offset: 0x0025DE6B
		[oO0oooo("1885")]
		public ContentAlignment CheckAlign
		{
			get
			{
				return this.Oooo.Oo_0O..CheckAlign;
			}
			set
			{
				this.Oooo.Oo_0O..CheckAlign = value;
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06005920 RID: 22816 RVA: 0x0025FC79 File Offset: 0x0025DE79
		// (set) Token: 0x06005921 RID: 22817 RVA: 0x0025FC7C File Offset: 0x0025DE7C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ImageFile
		{
			get
			{
				return null;
			}
			set
			{
				this.Oooo.Oo_0O..Image = OO_00oOO.GetImage(value);
			}
		}

		/// <summary>
		/// 图片对齐方式
		/// </summary>
		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06005922 RID: 22818 RVA: 0x0025FC8F File Offset: 0x0025DE8F
		// (set) Token: 0x06005923 RID: 22819 RVA: 0x0025FC9C File Offset: 0x0025DE9C
		[oO0oooo("1886")]
		public ContentAlignment ImageAlign
		{
			get
			{
				return this.Oooo.Oo_0O..ImageAlign;
			}
			set
			{
				this.Oooo.Oo_0O..ImageAlign = value;
			}
		}

		/// <summary>
		/// 标题和图片的相对位置
		/// </summary>
		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06005924 RID: 22820 RVA: 0x0025FCAA File Offset: 0x0025DEAA
		// (set) Token: 0x06005925 RID: 22821 RVA: 0x0025FCB7 File Offset: 0x0025DEB7
		[oO0oooo("1887")]
		public TextImageRelation TextImageRelation
		{
			get
			{
				return this.Oooo.Oo_0O..TextImageRelation;
			}
			set
			{
				this.Oooo.Oo_0O..TextImageRelation = value;
			}
		}

		/// <summary>
		/// 返回或设置单选框的图标
		/// </summary>
		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06005926 RID: 22822 RVA: 0x0025FCC5 File Offset: 0x0025DEC5
		// (set) Token: 0x06005927 RID: 22823 RVA: 0x0025FCD2 File Offset: 0x0025DED2
		[oO0oooo("0786")]
		public Image Image
		{
			get
			{
				return this.Oooo.Oo_0O..Image;
			}
			set
			{
				this.Oooo.Oo_0O..Image = value;
			}
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x0025FCE0 File Offset: 0x0025DEE0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x04002325 RID: 8997
		private oO00O0oO0o000 <<EMPTY_NAME>>;
	}
}
