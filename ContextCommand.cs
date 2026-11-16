using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000479 RID: 1145
	[OoO0___o("ContextCommand")]
	internal class ContextCommand : RibbonBase
	{
		// Token: 0x06004E2F RID: 20015 RVA: 0x00237444 File Offset: 0x00235644
		public ContextCommand(DataRow A_0) : base(A_0)
		{
			this.oOO_._0_00ooo. = true;
			this.Oo.oo. = true;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06004E30 RID: 20016 RVA: 0x00237463 File Offset: 0x00235663
		// (set) Token: 0x06004E31 RID: 20017 RVA: 0x0023746B File Offset: 0x0023566B
		[O_Oo00Oo000O0(2.0)]
		[Category("属性")]
		[DisplayName("标题")]
		public string Text
		{
			get
			{
				return this.oOO_._0_00ooo.;
			}
			set
			{
				this.oOO_._0_00ooo. = value;
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06004E32 RID: 20018 RVA: 0x00237474 File Offset: 0x00235674
		// (set) Token: 0x06004E33 RID: 20019 RVA: 0x0023747C File Offset: 0x0023567C
		[DisplayName("图标")]
		[O_Oo00Oo000O0(3.0)]
		[Description("一个16*16尺寸的图标，或者对应大小的图片。")]
		[Category("属性")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		public string Image
		{
			get
			{
				return this.Oo.oo.;
			}
			set
			{
				this.Oo.oo. = value;
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06004E34 RID: 20020 RVA: 0x00237485 File Offset: 0x00235685
		// (set) Token: 0x06004E35 RID: 20021 RVA: 0x0023748D File Offset: 0x0023568D
		[DisplayName("提示")]
		[O_Oo00Oo000O0(4.0)]
		[Category("属性")]
		public string ToolTip
		{
			get
			{
				return this.Oo00O.O.;
			}
			set
			{
				this.Oo00O.O. = value;
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06004E36 RID: 20022 RVA: 0x00237496 File Offset: 0x00235696
		// (set) Token: 0x06004E37 RID: 20023 RVA: 0x0023749E File Offset: 0x0023569E
		[O_Oo00Oo000O0(7.0)]
		[Category("属性")]
		[DisplayName("可用")]
		[DefaultValue(true)]
		public bool Enabled
		{
			get
			{
				return this.oOO_._0_00ooo.;
			}
			set
			{
				this.oOO_._0_00ooo. = value;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06004E38 RID: 20024 RVA: 0x002374A7 File Offset: 0x002356A7
		// (set) Token: 0x06004E39 RID: 20025 RVA: 0x002374AF File Offset: 0x002356AF
		[Category("属性")]
		[O_Oo00Oo000O0(8.0)]
		[DisplayName("可见")]
		[DefaultValue(true)]
		public bool Visible
		{
			get
			{
				return this.Oo.oo.;
			}
			set
			{
				this.Oo.oo. = value;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06004E3A RID: 20026 RVA: 0x002374B8 File Offset: 0x002356B8
		// (set) Token: 0x06004E3B RID: 20027 RVA: 0x002374C0 File Offset: 0x002356C0
		[O_Oo00Oo000O0(9.0)]
		[DisplayName("选中")]
		[Description("是否在菜单项目左侧显示选中标记。")]
		[Category("属性")]
		[DefaultValue(false)]
		public bool Checked
		{
			get
			{
				return this.Oo00O.O.;
			}
			set
			{
				this.Oo00O.O. = value;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06004E3C RID: 20028 RVA: 0x002374C9 File Offset: 0x002356C9
		// (set) Token: 0x06004E3D RID: 20029 RVA: 0x002374D1 File Offset: 0x002356D1
		[Description("单击菜单项目，是否自动切换其选中状态。")]
		[DefaultValue(false)]
		[DisplayName("自动选中")]
		[O_Oo00Oo000O0(10.0)]
		[Category("属性")]
		public bool CheckAutoToggle
		{
			get
			{
				return this.OoO.OO0.;
			}
			set
			{
				this.OoO.OO0. = value;
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06004E3E RID: 20030 RVA: 0x002374DA File Offset: 0x002356DA
		// (set) Token: 0x06004E3F RID: 20031 RVA: 0x002374E2 File Offset: 0x002356E2
		[Category("属性")]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(11.0)]
		[DisplayName("显示分割线")]
		public bool Delimiter
		{
			get
			{
				return this.O0_0.O.;
			}
			set
			{
				this.O0_0.O. = value;
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06004E40 RID: 20032 RVA: 0x002374EB File Offset: 0x002356EB
		// (set) Token: 0x06004E41 RID: 20033 RVA: 0x002374F3 File Offset: 0x002356F3
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("单击菜单项目后执行。")]
		[Category("事件")]
		[oO0oooo("1331")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.1)]
		public EventString Click
		{
			get
			{
				return this.Oo.oo.;
			}
			set
			{
				this.Oo.oo. = value;
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x002374FC File Offset: 0x002356FC
		// (set) Token: 0x06004E43 RID: 20035 RVA: 0x00237504 File Offset: 0x00235704
		[Category("事件")]
		[oO0oooo("1332")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("选中状态改变后执行。")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.2)]
		public EventString CheckedChanged
		{
			get
			{
				return this.oOO_._0_00ooo.;
			}
			set
			{
				this.oOO_._0_00ooo. = value;
			}
		}

		// Token: 0x04001FEF RID: 8175
		private string <<EMPTY_NAME>>;

		// Token: 0x04001FF0 RID: 8176
		private string <<EMPTY_NAME>>;

		// Token: 0x04001FF1 RID: 8177
		private string <<EMPTY_NAME>>;

		// Token: 0x04001FF2 RID: 8178
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001FF3 RID: 8179
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001FF4 RID: 8180
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001FF5 RID: 8181
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001FF6 RID: 8182
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001FF7 RID: 8183
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001FF8 RID: 8184
		private EventString <<EMPTY_NAME>>;
	}
}
