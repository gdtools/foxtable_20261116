using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 滑动条
	/// </summary>
	// Token: 0x02000513 RID: 1299
	[ComVisible(true)]
	[oO0oooo("2268")]
	public class TrackBar : Control, OoO_
	{
		// Token: 0x06005533 RID: 21811 RVA: 0x00259369 File Offset: 0x00257569
		public TrackBar(TrackBar A_0) : base(A_0, ControlTypeEnum.TrackBar)
		{
			this.oO_0o_.0__O. = A_0;
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06005534 RID: 21812 RVA: 0x0025937B File Offset: 0x0025757B
		// (set) Token: 0x06005535 RID: 21813 RVA: 0x00259384 File Offset: 0x00257584
		[oO0oooo("1860")]
		public virtual string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.oO_0o_.0__O..DataBindings.Clear();
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.TrackBar, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.oO_0o_.0__O..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("Value", value);
							if (binding != null)
							{
								this.oO_0o_.0__O..DataBindings.Add(binding);
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 返回或设置滑动条的最大值
		/// </summary>
		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06005536 RID: 21814 RVA: 0x0025945A File Offset: 0x0025765A
		// (set) Token: 0x06005537 RID: 21815 RVA: 0x00259467 File Offset: 0x00257667
		public int Maximum
		{
			get
			{
				return this.oO_0o_.0__O..Maximum;
			}
			set
			{
				this.oO_0o_.0__O..Maximum = value;
			}
		}

		/// <summary>
		/// 返回或设置滑动条的最小值
		/// </summary>
		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06005538 RID: 21816 RVA: 0x00259475 File Offset: 0x00257675
		// (set) Token: 0x06005539 RID: 21817 RVA: 0x00259482 File Offset: 0x00257682
		public int Minimum
		{
			get
			{
				return this.oO_0o_.0__O..Minimum;
			}
			set
			{
				this.oO_0o_.0__O..Minimum = value;
			}
		}

		/// <summary>
		/// 返回或设置滑动条的当前值
		/// </summary>
		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x0600553A RID: 21818 RVA: 0x00259490 File Offset: 0x00257690
		// (set) Token: 0x0600553B RID: 21819 RVA: 0x0025949D File Offset: 0x0025769D
		public int Value
		{
			get
			{
				return this.oO_0o_.0__O..Value;
			}
			set
			{
				this.oO_0o_.0__O..Value = value;
			}
		}

		/// <summary>
		/// "按下PageUp、PageDown时，滑块移动的位置数
		/// </summary>
		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x0600553C RID: 21820 RVA: 0x002594AB File Offset: 0x002576AB
		// (set) Token: 0x0600553D RID: 21821 RVA: 0x002594B8 File Offset: 0x002576B8
		public int LargeChange
		{
			get
			{
				return this.oO_0o_.0__O..LargeChange;
			}
			set
			{
				this.oO_0o_.0__O..LargeChange = value;
			}
		}

		/// <summary>
		/// 按下箭头键时，滑块移动的位置数
		/// </summary>
		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x0600553E RID: 21822 RVA: 0x002594C6 File Offset: 0x002576C6
		// (set) Token: 0x0600553F RID: 21823 RVA: 0x002594D3 File Offset: 0x002576D3
		public int SmallChange
		{
			get
			{
				return this.oO_0o_.0__O..SmallChange;
			}
			set
			{
				this.oO_0o_.0__O..SmallChange = value;
			}
		}

		/// <summary>
		/// 刻度间隔
		/// </summary>
		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06005540 RID: 21824 RVA: 0x002594E1 File Offset: 0x002576E1
		// (set) Token: 0x06005541 RID: 21825 RVA: 0x002594EE File Offset: 0x002576EE
		public int TickFrequency
		{
			get
			{
				return this.oO_0o_.0__O..TickFrequency;
			}
			set
			{
				this.oO_0o_.0__O..TickFrequency = value;
			}
		}

		/// <summary>
		/// 刻度样式
		/// </summary>
		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06005542 RID: 21826 RVA: 0x002594FC File Offset: 0x002576FC
		// (set) Token: 0x06005543 RID: 21827 RVA: 0x00259509 File Offset: 0x00257709
		public TickStyle TickStyle
		{
			get
			{
				return this.oO_0o_.0__O..TickStyle;
			}
			set
			{
				this.oO_0o_.0__O..TickStyle = value;
			}
		}

		/// <summary>
		/// 方向
		/// </summary>
		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06005544 RID: 21828 RVA: 0x00259517 File Offset: 0x00257717
		// (set) Token: 0x06005545 RID: 21829 RVA: 0x00259524 File Offset: 0x00257724
		public Orientation Orientation
		{
			get
			{
				return this.oO_0o_.0__O..Orientation;
			}
			set
			{
				this.oO_0o_.0__O..Orientation = value;
			}
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00259532 File Offset: 0x00257732
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x040022BD RID: 8893
		private TrackBar <<EMPTY_NAME>>;
	}
}
