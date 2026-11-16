using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace Foxtable
{
	// Token: 0x02000174 RID: 372
	[OoO0___o("Control")]
	internal class ControlPropertyBase : PropertyBase
	{
		// Token: 0x0600113D RID: 4413 RVA: 0x0007F2C4 File Offset: 0x0007D4C4
		public ControlPropertyBase(ControlHolder A_0) : base(A_0)
		{
			this.OO.00. = true;
			this.o0o____._o. = true;
			this.Oo.OO0. = true;
			this.oO_oOo_.O_Oo0. = Cursors.Default;
			this.o0O0.O. = true;
			this.O._o. = false;
			this.o_O0.O_. = A_0.ChildControl;
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x0007F314 File Offset: 0x0007D514
		[MergableProperty(false)]
		[DisplayName("类型")]
		[O_Oo00Oo000O0(1.00001)]
		[Category("基本")]
		public string ControlType
		{
			get
			{
				return base.Type.ToString();
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0007F335 File Offset: 0x0007D535
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x0007F342 File Offset: 0x0007D542
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("左")]
		[Category("位置")]
		[MergableProperty(true)]
		public int Left
		{
			get
			{
				return this.o_0_.Oo..Left;
			}
			set
			{
				this.o_0_.Oo..Left = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x0007F350 File Offset: 0x0007D550
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x0007F35D File Offset: 0x0007D55D
		[MergableProperty(true)]
		[Category("位置")]
		[DisplayName("上")]
		[O_Oo00Oo000O0(2.0)]
		public int Top
		{
			get
			{
				return this.o_0_.Oo..Top;
			}
			set
			{
				this.o_0_.Oo..Top = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x0007F36B File Offset: 0x0007D56B
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x0007F37D File Offset: 0x0007D57D
		[DisplayName("字体")]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue("宋体,9")]
		[O_Oo00Oo000O0(3.0)]
		public virtual Font Font
		{
			get
			{
				return this.o_0_.Oo..ChildControl.Font;
			}
			set
			{
				this.o_0_.Oo..ChildControl.Font = (Font)value.Clone();
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0007F39A File Offset: 0x0007D59A
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x0007F3A7 File Offset: 0x0007D5A7
		[Category("位置")]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("宽")]
		[MergableProperty(true)]
		public int Width
		{
			get
			{
				return this.o_0_.Oo..Width;
			}
			set
			{
				if (!this.o_0_.Oo..IsFixedWidth)
				{
					this.o_0_.Oo..Width = value;
				}
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0007F3C2 File Offset: 0x0007D5C2
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x0007F3CF File Offset: 0x0007D5CF
		[DisplayName("高")]
		[O_Oo00Oo000O0(4.0)]
		[Category("位置")]
		[MergableProperty(true)]
		public int Height
		{
			get
			{
				return this.o_0_.Oo..Height;
			}
			set
			{
				if (!this.o_0_.Oo..IsFixedHeight || !(this.o_0_.Oo..ChildControl is C1Label))
				{
					this.o_0_.Oo..Height = value;
				}
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x0007F3FC File Offset: 0x0007D5FC
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x0007F409 File Offset: 0x0007D609
		[Description("在调整容器大小时，使控件的指定边缘和容器边缘的距离保持不变。")]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("锚定")]
		[Category("位置")]
		[MergableProperty(true)]
		[DefaultValue(5)]
		public AnchorStyles Anchor
		{
			get
			{
				return this.o_0_.Oo..Anchor;
			}
			set
			{
				this.o_0_.Oo..Anchor = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0007F417 File Offset: 0x0007D617
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x0007F424 File Offset: 0x0007D624
		[MergableProperty(false)]
		[O_Oo00Oo000O0(5.1)]
		[Category("位置")]
		[DefaultValue(0)]
		[DisplayName("停靠")]
		[Description("停靠到容器的指定边框。")]
		public DockStyle Dock
		{
			get
			{
				return this.o_0_.Oo..Dock;
			}
			set
			{
				this.o_0_.Oo..Dock = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0007F432 File Offset: 0x0007D632
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x0007F43A File Offset: 0x0007D63A
		[Category("外观")]
		[O_Oo00Oo000O0(9.0)]
		[DisplayName("鼠标形状")]
		[MergableProperty(true)]
		[OooO0(true)]
		public Cursor Cursor
		{
			get
			{
				return this.oO_oOo_.O_Oo0.;
			}
			set
			{
				this.oO_oOo_.O_Oo0. = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x0007F443 File Offset: 0x0007D643
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x0007F450 File Offset: 0x0007D650
		[Browsable(false)]
		[DefaultValue(1)]
		public CursorEnum CursorType
		{
			get
			{
				return ooO.OO_oOO0O.O00.(this.Cursor);
			}
			set
			{
				this.Cursor = ooO.OO_oOO0O.O00.(value);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x0007F45E File Offset: 0x0007D65E
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0007F470 File Offset: 0x0007D670
		[DisplayName("背景颜色")]
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[Category("外观")]
		public virtual Color BackColor
		{
			get
			{
				return this.o_0_.Oo..ChildControl.BackColor;
			}
			set
			{
				if (this.o_0_.Oo..ChildControl is C1TextBox)
				{
					((C1TextBox)this.o_0_.Oo..ChildControl).BackColor = Color.White;
					((C1TextBox)this.o_0_.Oo..ChildControl).BackColor = value;
				}
				else
				{
					this.o_0_.Oo..ChildControl.BackColor = value;
				}
				if (this.o_0_.Oo..ControlType == ControlTypeEnum.Button)
				{
					((Button)this.o_0_.Oo..ChildControl).UseVisualStyleBackColor = true;
				}
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x0007F4F6 File Offset: 0x0007D6F6
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x0007F508 File Offset: 0x0007D708
		[Category("外观")]
		[DefaultValue(-16777216)]
		[O_Oo00Oo000O0(1.01)]
		[DisplayName("字体颜色")]
		[MergableProperty(true)]
		public virtual Color ForeColor
		{
			get
			{
				return this.o_0_.Oo..ChildControl.ForeColor;
			}
			set
			{
				if (this.o_0_.Oo..ChildControl is C1TextBox)
				{
					((C1TextBox)this.o_0_.Oo..ChildControl).ForeColor = value;
					return;
				}
				this.o_0_.Oo..ChildControl.ForeColor = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0007F544 File Offset: 0x0007D744
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x0007F54C File Offset: 0x0007D74C
		[Category("杂项")]
		[O_Oo00Oo000O0(1.9)]
		[DisplayName("提示")]
		[MergableProperty(true)]
		public string ToolTip
		{
			get
			{
				return this.o000.0o.;
			}
			set
			{
				this.o000.0o. = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0007F555 File Offset: 0x0007D755
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x0007F55D File Offset: 0x0007D75D
		[Category("杂项")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("可见")]
		[DefaultValue(true)]
		[MergableProperty(true)]
		public bool Visible
		{
			get
			{
				return this.o0o____._o.;
			}
			set
			{
				this.o0o____._o. = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x0007F566 File Offset: 0x0007D766
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x0007F56E File Offset: 0x0007D76E
		[DisplayName("可用")]
		[Category("杂项")]
		[MergableProperty(true)]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(2.01)]
		public bool Enabled
		{
			get
			{
				return this.OO.00.;
			}
			set
			{
				this.OO.00. = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x0007F577 File Offset: 0x0007D777
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x0007F57F File Offset: 0x0007D77F
		[DisplayName("执行验证")]
		[O_Oo00Oo000O0(2.1)]
		[Category("杂项")]
		[MergableProperty(true)]
		[Description("是否触发和执行Validating事件。")]
		[DefaultValue(true)]
		public bool CausesValidation
		{
			get
			{
				return this.Oo.OO0.;
			}
			set
			{
				this.Oo.OO0. = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0007F588 File Offset: 0x0007D788
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x0007F595 File Offset: 0x0007D795
		[O_Oo00Oo000O0(3.0)]
		[Description("确定用户按Tab键时，该控件获得焦点的顺序。")]
		[Category("杂项")]
		[MergableProperty(false)]
		[DisplayName("Tab键顺序")]
		public int TabIndex
		{
			get
			{
				return this.o_0_.Oo..TabIndex;
			}
			set
			{
				this.o_0_.Oo..TabIndex = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x0007F5A3 File Offset: 0x0007D7A3
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x0007F5AB File Offset: 0x0007D7AB
		[Description("确定用户能否使用TAB键将焦点移到该控件上。")]
		[O_Oo00Oo000O0(4.0)]
		[MergableProperty(true)]
		[DisplayName("跳过Tab键")]
		[DefaultValue(false)]
		[Category("杂项")]
		public bool TabStop
		{
			get
			{
				return this.o__0._oO_O_.;
			}
			set
			{
				this.o__0._oO_O_. = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x0007F5B4 File Offset: 0x0007D7B4
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x0007F5BC File Offset: 0x0007D7BC
		[MergableProperty(true)]
		[Category("杂项")]
		[DisplayName("最顶层")]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(4.001)]
		[Description("设置控件是否位于其它控件之上。")]
		public bool TopMost
		{
			get
			{
				return this.o.0O_0_O_.;
			}
			set
			{
				this.o.0O_0_O_. = value;
				if (value)
				{
					this.BackMost = false;
					base.Holder.BringToFront();
				}
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0007F5DA File Offset: 0x0007D7DA
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0007F5E2 File Offset: 0x0007D7E2
		[O_Oo00Oo000O0(4.002)]
		[DefaultValue(false)]
		[DisplayName("最底层")]
		[Description("设置控件是否位于其它控件之下。")]
		[Category("杂项")]
		[MergableProperty(true)]
		public bool BackMost
		{
			get
			{
				return this.O___.O_OO_o0O.;
			}
			set
			{
				this.O___.O_OO_o0O. = value;
				if (value)
				{
					this.TopMost = false;
					base.Holder.SendToBack();
				}
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x0007F600 File Offset: 0x0007D800
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x0007F608 File Offset: 0x0007D808
		[Description("打印窗口时是否打印此控件。")]
		[Category("输出")]
		[MergableProperty(true)]
		[DisplayName("允许打印")]
		[O_Oo00Oo000O0(10.0)]
		[DefaultValue(true)]
		public bool Printable
		{
			get
			{
				return this.o0O0.O.;
			}
			set
			{
				this.o0O0.O. = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x0007F611 File Offset: 0x0007D811
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x0007F619 File Offset: 0x0007D819
		[O_Oo00Oo000O0(10.1)]
		[MergableProperty(true)]
		[Description("打印时是否从此控件开始另起一页。")]
		[DisplayName("另起一页")]
		[DefaultValue(false)]
		[Category("输出")]
		public bool NewPage
		{
			get
			{
				return this.ooo_._0.;
			}
			set
			{
				this.ooo_._0. = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0007F622 File Offset: 0x0007D822
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0007F62A File Offset: 0x0007D82A
		[Description("打印此控件时是否打印边框。")]
		[MergableProperty(true)]
		[Category("输出")]
		[DisplayName("边框打印")]
		[O_Oo00Oo000O0(12.0)]
		[DefaultValue(false)]
		public bool PrintBorder
		{
			get
			{
				return this.O._o.;
			}
			set
			{
				this.O._o. = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0007F633 File Offset: 0x0007D833
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0007F63B File Offset: 0x0007D83B
		[oO0oooo("0732")]
		[Category("事件")]
		[Description("单击控件后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.0)]
		public EventString Click
		{
			get
			{
				return this.o0O._.;
			}
			set
			{
				this.o0O._. = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x0007F644 File Offset: 0x0007D844
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x0007F64C File Offset: 0x0007D84C
		[Category("事件")]
		[oO0oooo("0732")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(8.9)]
		[Description("用鼠标单击控件后执行")]
		[O0O0oOO00_0OO(true)]
		public EventString MouseClick
		{
			get
			{
				return this.O_O_O_.___OO.;
			}
			set
			{
				this.O_O_O_.___OO. = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0007F655 File Offset: 0x0007D855
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x0007F65D File Offset: 0x0007D85D
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(1.1)]
		[Description("双击控件后执行")]
		[oO0oooo("0733")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString DoubleClick
		{
			get
			{
				return this.OOoOoOO0O.O_o.;
			}
			set
			{
				this.OOoOoOO0O.O_o. = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0007F666 File Offset: 0x0007D866
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x0007F66E File Offset: 0x0007D86E
		[Description("选择控件后执行")]
		[oO0oooo("0734")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(2.0)]
		[Category("事件")]
		public EventString Enter
		{
			get
			{
				return this.OO.00.;
			}
			set
			{
				this.OO.00. = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0007F677 File Offset: 0x0007D877
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x0007F67F File Offset: 0x0007D87F
		[oO0oooo("0735")]
		[O_Oo00Oo000O0(3.0)]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("离开控件后执行")]
		public EventString Leave
		{
			get
			{
				return this.oOO_._OO_0_.;
			}
			set
			{
				this.oOO_._OO_0_. = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0007F688 File Offset: 0x0007D888
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x0007F690 File Offset: 0x0007D890
		[oO0oooo("0736")]
		[O_Oo00Oo000O0(4.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Category("事件")]
		[Description("离开控件前执行，通常用来对输入内容进行校对。")]
		public EventString Validating
		{
			get
			{
				return this.O.oO00O.;
			}
			set
			{
				this.O.oO00O. = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x0007F699 File Offset: 0x0007D899
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x0007F6A1 File Offset: 0x0007D8A1
		[oO0oooo("0737")]
		[Category("事件")]
		[O_Oo00Oo000O0(4.1)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("从绑定字段读取数据的时候发生。")]
		[O0O0oOO00_0OO(true)]
		public EventString DataFormat
		{
			get
			{
				return this.o_.__000.;
			}
			set
			{
				this.o_.__000. = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x0007F6AA File Offset: 0x0007D8AA
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x0007F6B2 File Offset: 0x0007D8B2
		[oO0oooo("0738")]
		[O_Oo00Oo000O0(4.2)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("向绑定字段写入数据的时候发生。")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString DataParse
		{
			get
			{
				return this.O0o_0_0_0.00.;
			}
			set
			{
				this.O0o_0_0_0.00. = value;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x0007F6BB File Offset: 0x0007D8BB
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x0007F6C3 File Offset: 0x0007D8C3
		[oO0oooo("0739")]
		[O_Oo00Oo000O0(6.0)]
		[Description("输入字符时执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString KeyPress
		{
			get
			{
				return this.OO.0.;
			}
			set
			{
				this.OO.0. = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x0007F6CC File Offset: 0x0007D8CC
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x0007F6D4 File Offset: 0x0007D8D4
		[oO0oooo("0741")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("压下按键时执行")]
		[O_Oo00Oo000O0(7.0)]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString KeyDown
		{
			get
			{
				return this.o0.O0_oOoOooOo.;
			}
			set
			{
				this.o0.O0_oOoOooOo. = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x0007F6DD File Offset: 0x0007D8DD
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x0007F6E5 File Offset: 0x0007D8E5
		[oO0oooo("0741")]
		[O_Oo00Oo000O0(8.0)]
		[O0O0oOO00_0OO(true)]
		[Description("松开按键执行")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString KeyUp
		{
			get
			{
				return this.O_0._oOOo_0_O0.;
			}
			set
			{
				this.O_0._oOOo_0_O0. = value;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x0007F6EE File Offset: 0x0007D8EE
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x0007F6F6 File Offset: 0x0007D8F6
		[oO0oooo("0743")]
		[Description("鼠标进入控件后执行")]
		[O0O0oOO00_0OO(true)]
		[Category("事件")]
		[O_Oo00Oo000O0(9.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString MouseEnter
		{
			get
			{
				return this.o_0.___.;
			}
			set
			{
				this.o_0.___. = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x0007F6FF File Offset: 0x0007D8FF
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x0007F707 File Offset: 0x0007D907
		[oO0oooo("0744")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[Description("鼠标离开控件后执行")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(10.0)]
		public EventString MouseLeave
		{
			get
			{
				return this.OO_.o__OO0O0O.;
			}
			set
			{
				this.OO_.o__OO0O0O. = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x0007F710 File Offset: 0x0007D910
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x0007F718 File Offset: 0x0007D918
		[oO0oooo("1320")]
		[Description("在控件上移动鼠标的时候执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(11.0)]
		[O0O0oOO00_0OO(true)]
		[Category("事件")]
		public EventString MouseMove
		{
			get
			{
				return this.O0_00.0.;
			}
			set
			{
				this.O0_00.0. = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x0007F721 File Offset: 0x0007D921
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x0007F729 File Offset: 0x0007D929
		[oO0oooo("0745")]
		[Description("鼠标停留在控件上的时候执行")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(12.0)]
		public EventString MouseHover
		{
			get
			{
				return this.OOoo.ooO_o0_O.;
			}
			set
			{
				this.OOoo.ooO_o0_O. = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0007F732 File Offset: 0x0007D932
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x0007F73A File Offset: 0x0007D93A
		[oO0oooo("0746")]
		[O_Oo00Oo000O0(13.0)]
		[Description("按下鼠标后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Category("事件")]
		public EventString MouseDown
		{
			get
			{
				return this.Oo_._0OOoo_o.;
			}
			set
			{
				this.Oo_._0OOoo_o. = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x0007F743 File Offset: 0x0007D943
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x0007F74B File Offset: 0x0007D94B
		[Description("松开鼠标后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(14.0)]
		[Category("事件")]
		[oO0oooo("0747")]
		[O0O0oOO00_0OO(true)]
		public EventString MouseUp
		{
			get
			{
				return this.oOO_oo._O_0.;
			}
			set
			{
				this.oOO_oo._O_0. = value;
			}
		}

		// Token: 0x0400069E RID: 1694
		internal Control <<EMPTY_NAME>>;

		// Token: 0x0400069F RID: 1695
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006A0 RID: 1696
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006A1 RID: 1697
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006A2 RID: 1698
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006A3 RID: 1699
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006A4 RID: 1700
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006A5 RID: 1701
		private string <<EMPTY_NAME>>;

		// Token: 0x040006A6 RID: 1702
		private Cursor <<EMPTY_NAME>>;

		// Token: 0x040006A7 RID: 1703
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006A8 RID: 1704
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006A9 RID: 1705
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006AA RID: 1706
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006AB RID: 1707
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006AC RID: 1708
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006AD RID: 1709
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006AE RID: 1710
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006AF RID: 1711
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006B0 RID: 1712
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006B1 RID: 1713
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006B2 RID: 1714
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006B3 RID: 1715
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006B4 RID: 1716
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006B5 RID: 1717
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006B6 RID: 1718
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006B7 RID: 1719
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006B8 RID: 1720
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006B9 RID: 1721
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006BA RID: 1722
		private EventString <<EMPTY_NAME>>;
	}
}
