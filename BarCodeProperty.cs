using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Neodynamic.WinControls.BarcodeProfessional;

namespace Foxtable
{
	// Token: 0x02000408 RID: 1032
	internal class BarCodeProperty : ControlPropertyBase
	{
		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x001EFBE8 File Offset: 0x001EDDE8
		// (set) Token: 0x06004381 RID: 17281 RVA: 0x001EFBF0 File Offset: 0x001EDDF0
		private virtual OOo00o_0o0_ Bar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06004382 RID: 17282 RVA: 0x001EFBF9 File Offset: 0x001EDDF9
		public BarCodeProperty(ControlHolder A_0) : base(A_0)
		{
			this.Bar = (OOo00o_0o0_)A_0.ChildControl;
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x001EFC13 File Offset: 0x001EDE13
		// (set) Token: 0x06004384 RID: 17284 RVA: 0x001EFC1B File Offset: 0x001EDE1B
		[DefaultValue("")]
		[DisplayName("条码内容")]
		[Category("数据绑定")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		public string BindingField
		{
			get
			{
				return this.O.0o_0_o.;
			}
			set
			{
				this.O.0o_0_o. = value;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x001EFC24 File Offset: 0x001EDE24
		// (set) Token: 0x06004386 RID: 17286 RVA: 0x001EFC2C File Offset: 0x001EDE2C
		[DisplayName("替换文本")]
		[O_Oo00Oo000O0(2.0)]
		[Category("数据绑定")]
		[DefaultValue("")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(true)]
		public string BindingHumanReadableText
		{
			get
			{
				return this.Oo_O._oOoo.;
			}
			set
			{
				this.Oo_O._oOoo. = value;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06004387 RID: 17287 RVA: 0x001EFC35 File Offset: 0x001EDE35
		// (set) Token: 0x06004388 RID: 17288 RVA: 0x001EFC3D File Offset: 0x001EDE3D
		[DisplayName("说明文本")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		[Category("数据绑定")]
		[DefaultValue("")]
		public string BindingText
		{
			get
			{
				return this.O___.O.;
			}
			set
			{
				this.O___.O. = value;
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06004389 RID: 17289 RVA: 0x001EFC46 File Offset: 0x001EDE46
		// (set) Token: 0x0600438A RID: 17290 RVA: 0x001EFC53 File Offset: 0x001EDE53
		[Browsable(false)]
		public Symbology Symbology
		{
			get
			{
				return this.Bar.Symbology;
			}
			set
			{
				this.Bar.Symbology = value;
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x0600438B RID: 17291 RVA: 0x001EFC61 File Offset: 0x001EDE61
		// (set) Token: 0x0600438C RID: 17292 RVA: 0x001EFC82 File Offset: 0x001EDE82
		[DisplayName("条码类型")]
		[MergableProperty(true)]
		[TypeConverter(typeof(OoOO___oo))]
		[OooO0(true)]
		[Category("条码设置")]
		[O_Oo00Oo000O0(1.0)]
		public string CodeType
		{
			get
			{
				return Enum.GetName(typeof(Symbology), this.Bar.Symbology);
			}
			set
			{
				this.Bar.Symbology = (Symbology)Conversions.ToInteger(Enum.Parse(typeof(Symbology), value));
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x0600438D RID: 17293 RVA: 0x001EFCA4 File Offset: 0x001EDEA4
		// (set) Token: 0x0600438E RID: 17294 RVA: 0x001EFCB1 File Offset: 0x001EDEB1
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("条码内容")]
		[Category("条码设置")]
		public virtual string Code
		{
			get
			{
				return this.Bar.Code;
			}
			set
			{
				this.Bar.Code = value;
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x0600438F RID: 17295 RVA: 0x001EFCBF File Offset: 0x001EDEBF
		// (set) Token: 0x06004390 RID: 17296 RVA: 0x001EFCCC File Offset: 0x001EDECC
		[MergableProperty(true)]
		[Category("条码设置")]
		[O_Oo00Oo000O0(3.0)]
		[DefaultValue(0.2642)]
		[DisplayName("窄条宽度")]
		public double BarWidth
		{
			get
			{
				return this.Bar.BarWidth;
			}
			set
			{
				this.Bar.BarWidth = value;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06004391 RID: 17297 RVA: 0x001EFCDA File Offset: 0x001EDEDA
		// (set) Token: 0x06004392 RID: 17298 RVA: 0x001EFCE7 File Offset: 0x001EDEE7
		[Category("条码设置")]
		[O_Oo00Oo000O0(4.0)]
		[MergableProperty(true)]
		[DisplayName("宽窄比例")]
		[DefaultValue(2.0)]
		public double BarRatio
		{
			get
			{
				return this.Bar.BarRatio;
			}
			set
			{
				this.Bar.BarRatio = value;
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06004393 RID: 17299 RVA: 0x001EFCF5 File Offset: 0x001EDEF5
		// (set) Token: 0x06004394 RID: 17300 RVA: 0x001EFD02 File Offset: 0x001EDF02
		[DisplayName("条码高度")]
		[O_Oo00Oo000O0(5.0)]
		[DefaultValue(5.08)]
		[Category("条码设置")]
		[MergableProperty(true)]
		public double BarHeight
		{
			get
			{
				return this.Bar.BarHeight;
			}
			set
			{
				this.Bar.BarHeight = value;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06004395 RID: 17301 RVA: 0x001EFD10 File Offset: 0x001EDF10
		// (set) Token: 0x06004396 RID: 17302 RVA: 0x001EFD1D File Offset: 0x001EDF1D
		[Category("条码设置")]
		[O_Oo00Oo000O0(5.1)]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("静区宽度")]
		public double QuietZoneWidth
		{
			get
			{
				return this.Bar.QuietZoneWidth;
			}
			set
			{
				this.Bar.QuietZoneWidth = value;
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x001EFD2B File Offset: 0x001EDF2B
		// (set) Token: 0x06004398 RID: 17304 RVA: 0x001EFD38 File Offset: 0x001EDF38
		[DefaultValue(0)]
		[Category("条码设置")]
		[MergableProperty(true)]
		[DisplayName("旋转角度")]
		[O_Oo00Oo000O0(6.0)]
		public Rotate Rotate
		{
			get
			{
				return this.Bar.Rotate;
			}
			set
			{
				this.Bar.Rotate = value;
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06004399 RID: 17305 RVA: 0x001EFD46 File Offset: 0x001EDF46
		// (set) Token: 0x0600439A RID: 17306 RVA: 0x001EFD53 File Offset: 0x001EDF53
		[DisplayName("增加校验")]
		[O_Oo00Oo000O0(7.0)]
		[DefaultValue(true)]
		[Category("条码设置")]
		[MergableProperty(true)]
		public bool AddCheckSum
		{
			get
			{
				return this.Bar.AddChecksum;
			}
			set
			{
				this.Bar.AddChecksum = value;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x001EFD61 File Offset: 0x001EDF61
		// (set) Token: 0x0600439C RID: 17308 RVA: 0x001EFD6E File Offset: 0x001EDF6E
		[O_Oo00Oo000O0(8.0)]
		[DefaultValue(0)]
		[Category("条码设置")]
		[MergableProperty(true)]
		[DisplayName("保护框")]
		public BearerBarStyle BearBarStyle
		{
			get
			{
				return this.Bar.BearerBarStyle;
			}
			set
			{
				this.Bar.BearerBarStyle = value;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x001EFD7C File Offset: 0x001EDF7C
		// (set) Token: 0x0600439E RID: 17310 RVA: 0x001EFD89 File Offset: 0x001EDF89
		[DisplayName("保护框宽度")]
		[O_Oo00Oo000O0(9.0)]
		[Category("条码设置")]
		[MergableProperty(true)]
		[DefaultValue(1.27)]
		public double BearerBarWidth
		{
			get
			{
				return this.Bar.BearerBarWidth;
			}
			set
			{
				this.Bar.BearerBarWidth = value;
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x0600439F RID: 17311 RVA: 0x001EFD97 File Offset: 0x001EDF97
		// (set) Token: 0x060043A0 RID: 17312 RVA: 0x001EFDA4 File Offset: 0x001EDFA4
		[DefaultValue(true)]
		[Category("条码设置 - 文本")]
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[DisplayName("显示文本")]
		public bool DisplayCode
		{
			get
			{
				return this.Bar.DisplayCode;
			}
			set
			{
				this.Bar.DisplayCode = value;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x060043A1 RID: 17313 RVA: 0x001EFDB2 File Offset: 0x001EDFB2
		// (set) Token: 0x060043A2 RID: 17314 RVA: 0x001EFDBF File Offset: 0x001EDFBF
		[O_Oo00Oo000O0(2.0)]
		[MergableProperty(true)]
		[DisplayName("显示校验符")]
		[DefaultValue(true)]
		[Category("条码设置 - 文本")]
		public bool DisplayChecksum
		{
			get
			{
				return this.Bar.DisplayChecksum;
			}
			set
			{
				this.Bar.DisplayChecksum = value;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x060043A3 RID: 17315 RVA: 0x001EFDCD File Offset: 0x001EDFCD
		// (set) Token: 0x060043A4 RID: 17316 RVA: 0x001EFDDA File Offset: 0x001EDFDA
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("显示起止符")]
		[DefaultValue(true)]
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		public bool DisplayStartStopChar
		{
			get
			{
				return this.Bar.DisplayStartStopChar;
			}
			set
			{
				this.Bar.DisplayStartStopChar = value;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x060043A5 RID: 17317 RVA: 0x001EFDE8 File Offset: 0x001EDFE8
		// (set) Token: 0x060043A6 RID: 17318 RVA: 0x001EFDF5 File Offset: 0x001EDFF5
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[Category("条码设置 - 文本")]
		[DefaultValue("")]
		[DisplayName("替换文本")]
		public virtual string HumanReadableText
		{
			get
			{
				return this.Bar.HumanReadableText;
			}
			set
			{
				this.Bar.HumanReadableText = value;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x060043A7 RID: 17319 RVA: 0x001EFE03 File Offset: 0x001EE003
		// (set) Token: 0x060043A8 RID: 17320 RVA: 0x001EFE10 File Offset: 0x001EE010
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		[DisplayName("文本位置")]
		[O_Oo00Oo000O0(5.0)]
		[DefaultValue(4)]
		public Alignment CodeAlignment
		{
			get
			{
				return this.Bar.CodeAlignment;
			}
			set
			{
				this.Bar.CodeAlignment = value;
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x060043A9 RID: 17321 RVA: 0x001EFE1E File Offset: 0x001EE01E
		// (set) Token: 0x060043AA RID: 17322 RVA: 0x001EFE2B File Offset: 0x001EE02B
		[DefaultValue("")]
		[MergableProperty(true)]
		[DisplayName("说明文本")]
		[Category("条码设置 - 文本")]
		[O_Oo00Oo000O0(6.0)]
		public virtual string Text
		{
			get
			{
				return this.Bar.Text;
			}
			set
			{
				this.Bar.Text = value;
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x060043AB RID: 17323 RVA: 0x001EFE39 File Offset: 0x001EE039
		// (set) Token: 0x060043AC RID: 17324 RVA: 0x001EFE46 File Offset: 0x001EE046
		[MergableProperty(true)]
		[O_Oo00Oo000O0(7.0)]
		[DisplayName("说明位置")]
		[DefaultValue(0)]
		[Category("条码设置 - 文本")]
		public Alignment TextAlignment
		{
			get
			{
				return this.Bar.TextAlignment;
			}
			set
			{
				this.Bar.TextAlignment = value;
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x060043AD RID: 17325 RVA: 0x001EFE54 File Offset: 0x001EE054
		// (set) Token: 0x060043AE RID: 17326 RVA: 0x001EFE61 File Offset: 0x001EE061
		[DefaultValue(0)]
		[O_Oo00Oo000O0(8.0)]
		[MergableProperty(true)]
		[DisplayName("上文本间距")]
		[Category("条码设置 - 文本")]
		public double TopMargin
		{
			get
			{
				return this.Bar.TopMargin;
			}
			set
			{
				this.Bar.TopMargin = value;
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x060043AF RID: 17327 RVA: 0x001EFE6F File Offset: 0x001EE06F
		// (set) Token: 0x060043B0 RID: 17328 RVA: 0x001EFE7C File Offset: 0x001EE07C
		[O_Oo00Oo000O0(9.0)]
		[DisplayName("下文本间距")]
		[DefaultValue(0)]
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		public double BottomMargin
		{
			get
			{
				return this.Bar.BottomMargin;
			}
			set
			{
				this.Bar.BottomMargin = value;
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x060043B1 RID: 17329 RVA: 0x001EFE8A File Offset: 0x001EE08A
		// (set) Token: 0x060043B2 RID: 17330 RVA: 0x001EFE97 File Offset: 0x001EE097
		[DefaultValue("宋体,9")]
		[O_Oo00Oo000O0(10.0)]
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		[DisplayName("文本字体")]
		public override Font Font
		{
			get
			{
				return this.Bar.Font;
			}
			set
			{
				this.Bar.Font = (Font)value.Clone();
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x060043B3 RID: 17331 RVA: 0x001EFEAF File Offset: 0x001EE0AF
		// (set) Token: 0x060043B4 RID: 17332 RVA: 0x001EFEBC File Offset: 0x001EE0BC
		[DefaultValue(-16777216)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(11.0)]
		[DisplayName("文本颜色")]
		[Category("条码设置 - 文本")]
		public override Color ForeColor
		{
			get
			{
				return this.Bar.ForeColor;
			}
			set
			{
				this.Bar.ForeColor = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x060043B5 RID: 17333 RVA: 0x001EFECA File Offset: 0x001EE0CA
		// (set) Token: 0x060043B6 RID: 17334 RVA: 0x001EFED7 File Offset: 0x001EE0D7
		[DisplayName("说明字体")]
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(12.0)]
		[DefaultValue("宋体,9")]
		public Font TextFont
		{
			get
			{
				return this.Bar.TextFont;
			}
			set
			{
				this.Bar.TextFont = (Font)value.Clone();
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x060043B7 RID: 17335 RVA: 0x001EFEEF File Offset: 0x001EE0EF
		// (set) Token: 0x060043B8 RID: 17336 RVA: 0x001EFEFC File Offset: 0x001EE0FC
		[O_Oo00Oo000O0(13.0)]
		[DefaultValue(-16777216)]
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		[DisplayName("说明颜色")]
		public Color TextForeColor
		{
			get
			{
				return this.Bar.TextForeColor;
			}
			set
			{
				this.Bar.TextForeColor = value;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x060043B9 RID: 17337 RVA: 0x001EFF0A File Offset: 0x001EE10A
		// (set) Token: 0x060043BA RID: 17338 RVA: 0x001EFF17 File Offset: 0x001EE117
		[Category("条码设置 - AztecCode")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("编码格式")]
		[DefaultValue(0)]
		public AztecCodeFormat AztecCodeFormat
		{
			get
			{
				return this.Bar.AztecCodeFormat;
			}
			set
			{
				this.Bar.AztecCodeFormat = value;
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x060043BB RID: 17339 RVA: 0x001EFF25 File Offset: 0x001EE125
		// (set) Token: 0x060043BC RID: 17340 RVA: 0x001EFF32 File Offset: 0x001EE132
		[Category("条码设置 - AztecCode")]
		[DisplayName("模组尺寸")]
		[DefaultValue(1.0592)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		public double AztecCodeModuleSize
		{
			get
			{
				return this.Bar.AztecCodeModuleSize;
			}
			set
			{
				this.Bar.AztecCodeModuleSize = value;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060043BD RID: 17341 RVA: 0x001EFF40 File Offset: 0x001EE140
		// (set) Token: 0x060043BE RID: 17342 RVA: 0x001EFF4D File Offset: 0x001EE14D
		[DefaultValue(23)]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("容错比例")]
		[Category("条码设置 - AztecCode")]
		[MergableProperty(true)]
		public int AztecCodeErrorCorrection
		{
			get
			{
				return this.Bar.AztecCodeErrorCorrection;
			}
			set
			{
				this.Bar.AztecCodeErrorCorrection = value;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060043BF RID: 17343 RVA: 0x001EFF5B File Offset: 0x001EE15B
		// (set) Token: 0x060043C0 RID: 17344 RVA: 0x001EFF68 File Offset: 0x001EE168
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[Category("条码设置 - AztecCode")]
		[DefaultValue(-1)]
		public int AztecCodeRune
		{
			get
			{
				return this.Bar.AztecCodeRune;
			}
			set
			{
				this.Bar.AztecCodeRune = value;
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060043C1 RID: 17345 RVA: 0x001EFF76 File Offset: 0x001EE176
		// (set) Token: 0x060043C2 RID: 17346 RVA: 0x001EFF83 File Offset: 0x001EE183
		[DefaultValue(0)]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("起始字符")]
		[Category("条码设置 - Codabar")]
		[MergableProperty(true)]
		public CodabarStartStopChar CodabarStartChar
		{
			get
			{
				return this.Bar.CodabarStartChar;
			}
			set
			{
				this.Bar.CodabarStartChar = value;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x001EFF91 File Offset: 0x001EE191
		// (set) Token: 0x060043C4 RID: 17348 RVA: 0x001EFF9E File Offset: 0x001EE19E
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("结束字符")]
		[DefaultValue(0)]
		[Category("条码设置 - Codabar")]
		public CodabarStartStopChar CodabarStopChar
		{
			get
			{
				return this.Bar.CodabarStopChar;
			}
			set
			{
				this.Bar.CodabarStopChar = value;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060043C5 RID: 17349 RVA: 0x001EFFAC File Offset: 0x001EE1AC
		// (set) Token: 0x060043C6 RID: 17350 RVA: 0x001EFFB9 File Offset: 0x001EE1B9
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[Category("条码设置 - Code128")]
		[DisplayName("字符集")]
		public Code128 Code128CharSet
		{
			get
			{
				return this.Bar.Code128CharSet;
			}
			set
			{
				this.Bar.Code128CharSet = value;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060043C7 RID: 17351 RVA: 0x001EFFC7 File Offset: 0x001EE1C7
		// (set) Token: 0x060043C8 RID: 17352 RVA: 0x001EFFD4 File Offset: 0x001EE1D4
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(0)]
		[Category("条码设置 - Code16K")]
		[MergableProperty(true)]
		[DisplayName("编码模式")]
		public Code16k Code16kMode
		{
			get
			{
				return this.Bar.Code16kMode;
			}
			set
			{
				this.Bar.Code16kMode = value;
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x001EFFE2 File Offset: 0x001EE1E2
		// (set) Token: 0x060043CA RID: 17354 RVA: 0x001EFFEF File Offset: 0x001EE1EF
		[MergableProperty(true)]
		[Category("条码设置 - DataMatrix")]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(0)]
		[DisplayName("编码方式")]
		public DataMatrixEncoding DataMatrixEncoding
		{
			get
			{
				return this.Bar.DataMatrixEncoding;
			}
			set
			{
				this.Bar.DataMatrixEncoding = value;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060043CB RID: 17355 RVA: 0x001EFFFD File Offset: 0x001EE1FD
		// (set) Token: 0x060043CC RID: 17356 RVA: 0x001F000A File Offset: 0x001EE20A
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("编码格式")]
		[DefaultValue(0)]
		[Category("条码设置 - DataMatrix")]
		public DataMatrixFormat DataMatrixFormat
		{
			get
			{
				return this.Bar.DataMatrixFormat;
			}
			set
			{
				this.Bar.DataMatrixFormat = value;
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060043CD RID: 17357 RVA: 0x001F0018 File Offset: 0x001EE218
		// (set) Token: 0x060043CE RID: 17358 RVA: 0x001F0025 File Offset: 0x001EE225
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("模组尺寸")]
		[DefaultValue(1.0592)]
		[Category("条码设置 - DataMatrix")]
		public double DataMatrixModuleSize
		{
			get
			{
				return this.Bar.DataMatrixModuleSize;
			}
			set
			{
				this.Bar.DataMatrixModuleSize = value;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x060043CF RID: 17359 RVA: 0x001F0033 File Offset: 0x001EE233
		// (set) Token: 0x060043D0 RID: 17360 RVA: 0x001F0040 File Offset: 0x001EE240
		[O_Oo00Oo000O0(4.0)]
		[DefaultValue(false)]
		[Category("条码设置 - DataMatrix")]
		[MergableProperty(true)]
		[DisplayName("处理波形符")]
		public bool DataMatrixProcessTilde
		{
			get
			{
				return this.Bar.DataMatrixProcessTilde;
			}
			set
			{
				this.Bar.DataMatrixProcessTilde = value;
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x001F004E File Offset: 0x001EE24E
		// (set) Token: 0x060043D2 RID: 17362 RVA: 0x001F005B File Offset: 0x001EE25B
		[DefaultValue(0)]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("附加码数")]
		[Category("条码设置 - Ean And Upc")]
		[MergableProperty(true)]
		public Supplement EanUpcSupplement
		{
			get
			{
				return this.Bar.EanUpcSupplement;
			}
			set
			{
				this.Bar.EanUpcSupplement = value;
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x001F0069 File Offset: 0x001EE269
		// (set) Token: 0x060043D4 RID: 17364 RVA: 0x001F0076 File Offset: 0x001EE276
		[Category("条码设置 - Ean And Upc")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("附加码值")]
		[DefaultValue("0")]
		[MergableProperty(true)]
		public string EanUpcSupplementCode
		{
			get
			{
				return this.Bar.EanUpcSupplementCode;
			}
			set
			{
				this.Bar.EanUpcSupplementCode = value;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x001F0084 File Offset: 0x001EE284
		// (set) Token: 0x060043D6 RID: 17366 RVA: 0x001F0091 File Offset: 0x001EE291
		[DisplayName("附加码左距")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		[DefaultValue(3.81)]
		[Category("条码设置 - Ean And Upc")]
		public double EanUpcSupplementSeparation
		{
			get
			{
				return this.Bar.EanUpcSupplementSeparation;
			}
			set
			{
				this.Bar.EanUpcSupplementSeparation = value;
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x001F009F File Offset: 0x001EE29F
		// (set) Token: 0x060043D8 RID: 17368 RVA: 0x001F00AC File Offset: 0x001EE2AC
		[O_Oo00Oo000O0(4.0)]
		[DefaultValue(3.81)]
		[Category("条码设置 - Ean And Upc")]
		[MergableProperty(true)]
		[DisplayName("附加码上距")]
		public double EanUpcSupplementTopMargin
		{
			get
			{
				return this.Bar.EanUpcSupplementTopMargin;
			}
			set
			{
				this.Bar.EanUpcSupplementTopMargin = value;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x001F00BA File Offset: 0x001EE2BA
		// (set) Token: 0x060043DA RID: 17370 RVA: 0x001F00C7 File Offset: 0x001EE2C7
		[DisplayName("显示防护条")]
		[O_Oo00Oo000O0(5.0)]
		[DefaultValue(true)]
		[Category("条码设置 - Ean And Upc")]
		[MergableProperty(true)]
		public bool GuardBar
		{
			get
			{
				return this.Bar.GuardBar;
			}
			set
			{
				this.Bar.GuardBar = value;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x001F00D5 File Offset: 0x001EE2D5
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x001F00E2 File Offset: 0x001EE2E2
		[DisplayName("防护条高度")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(6.0)]
		[DefaultValue(6.35)]
		[Category("条码设置 - Ean And Upc")]
		public double GuardBarHeight
		{
			get
			{
				return this.Bar.GuardBarHeight;
			}
			set
			{
				this.Bar.GuardBarHeight = value;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060043DD RID: 17373 RVA: 0x001F00F0 File Offset: 0x001EE2F0
		// (set) Token: 0x060043DE RID: 17374 RVA: 0x001F00FD File Offset: 0x001EE2FD
		[DefaultValue(0)]
		[Category("条码设置 - Ean And Upc")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(7.0)]
		[DisplayName("编码方式")]
		public UpcE UpcESystem
		{
			get
			{
				return this.Bar.UpcESystem;
			}
			set
			{
				this.Bar.UpcESystem = value;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x001F010B File Offset: 0x001EE30B
		// (set) Token: 0x060043E0 RID: 17376 RVA: 0x001F0118 File Offset: 0x001EE318
		[DisplayName("每行段数")]
		[MergableProperty(true)]
		[Category("条码设置 - ExpandedStacked")]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(4)]
		public int SegmentsPerRow
		{
			get
			{
				return this.Bar.SegmentsPerRow;
			}
			set
			{
				this.Bar.SegmentsPerRow = value;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x001F0126 File Offset: 0x001EE326
		// (set) Token: 0x060043E2 RID: 17378 RVA: 0x001F0133 File Offset: 0x001EE333
		[Category("条码设置 - HIBC")]
		[DisplayName("格式化替换文本")]
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[DefaultValue(true)]
		public bool HibcFormatHumanReadableText
		{
			get
			{
				return this.Bar.HibcFormatHumanReadableText;
			}
			set
			{
				this.Bar.HibcFormatHumanReadableText = value;
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x060043E3 RID: 17379 RVA: 0x001F0141 File Offset: 0x001EE341
		// (set) Token: 0x060043E4 RID: 17380 RVA: 0x001F014E File Offset: 0x001EE34E
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[Category("条码设置 - ISBT")]
		[DisplayName("数据结构")]
		[DefaultValue(0)]
		public Isbt128DataStructure Isbt128DataStructure
		{
			get
			{
				return this.Bar.Isbt128DataStructure;
			}
			set
			{
				this.Bar.Isbt128DataStructure = value;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x060043E5 RID: 17381 RVA: 0x001F015C File Offset: 0x001EE35C
		// (set) Token: 0x060043E6 RID: 17382 RVA: 0x001F0169 File Offset: 0x001EE369
		[MergableProperty(true)]
		[Category("条码设置 - MaxiCode")]
		[DisplayName("编码模式")]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(4)]
		public MaxiCodeModes MaxiCodeMode
		{
			get
			{
				return this.Bar.MaxiCodeMode;
			}
			set
			{
				this.Bar.MaxiCodeMode = value;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x001F0177 File Offset: 0x001EE377
		// (set) Token: 0x060043E8 RID: 17384 RVA: 0x001F0184 File Offset: 0x001EE384
		[DefaultValue(1)]
		[Category("条码设置 - MaxiCode")]
		[DisplayName("模式字符数量")]
		[O_Oo00Oo000O0(2.0)]
		[MergableProperty(true)]
		public int MaxiCodeSymbolCount
		{
			get
			{
				return this.Bar.MaxiCodeSymbolCount;
			}
			set
			{
				this.Bar.MaxiCodeSymbolCount = value;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x060043E9 RID: 17385 RVA: 0x001F0192 File Offset: 0x001EE392
		// (set) Token: 0x060043EA RID: 17386 RVA: 0x001F019F File Offset: 0x001EE39F
		[DisplayName("模式字符位置")]
		[O_Oo00Oo000O0(3.0)]
		[MergableProperty(true)]
		[DefaultValue(1)]
		[Category("条码设置 - MaxiCode")]
		public int MaxiCodeSymbolIndex
		{
			get
			{
				return this.Bar.MaxiCodeSymbolIndex;
			}
			set
			{
				this.Bar.MaxiCodeSymbolIndex = value;
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x001F01AD File Offset: 0x001EE3AD
		// (set) Token: 0x060043EC RID: 17388 RVA: 0x001F01BA File Offset: 0x001EE3BA
		[MergableProperty(true)]
		[DisplayName("处理波浪符")]
		[DefaultValue(false)]
		[Category("条码设置 - MaxiCode")]
		[O_Oo00Oo000O0(4.0)]
		public bool MaxiCodeProcessTilde
		{
			get
			{
				return this.Bar.MaxiCodeProcessTilde;
			}
			set
			{
				this.Bar.MaxiCodeProcessTilde = value;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x060043ED RID: 17389 RVA: 0x001F01C8 File Offset: 0x001EE3C8
		// (set) Token: 0x060043EE RID: 17390 RVA: 0x001F01D5 File Offset: 0x001EE3D5
		[DefaultValue(0)]
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[Category("条码设置 - MSI")]
		[DisplayName("校验模式")]
		public MsiChecksum MsiChecksum
		{
			get
			{
				return this.Bar.MsiChecksum;
			}
			set
			{
				this.Bar.MsiChecksum = value;
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x060043EF RID: 17391 RVA: 0x001F01E3 File Offset: 0x001EE3E3
		// (set) Token: 0x060043F0 RID: 17392 RVA: 0x001F01F0 File Offset: 0x001EE3F0
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[DisplayName("编码类型")]
		[DefaultValue(0)]
		[Category("条码设置 - PDF417")]
		public Pdf417CompactionType Pdf417CompactionType
		{
			get
			{
				return this.Bar.Pdf417CompactionType;
			}
			set
			{
				this.Bar.Pdf417CompactionType = value;
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x001F01FE File Offset: 0x001EE3FE
		// (set) Token: 0x060043F2 RID: 17394 RVA: 0x001F020B File Offset: 0x001EE40B
		[MergableProperty(true)]
		[DisplayName("编码版号")]
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(0)]
		[Category("条码设置 - PDF417")]
		public MicroPdf417Version MicroPdf417Version
		{
			get
			{
				return this.Bar.MicroPdf417Version;
			}
			set
			{
				this.Bar.MicroPdf417Version = value;
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x001F0219 File Offset: 0x001EE419
		// (set) Token: 0x060043F4 RID: 17396 RVA: 0x001F0226 File Offset: 0x001EE426
		[DefaultValue(2)]
		[Category("条码设置 - PDF417")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.1)]
		[DisplayName("容错级别")]
		public Pdf417ErrorCorrection Pdf417ErrorCorrectionLevel
		{
			get
			{
				return this.Bar.Pdf417ErrorCorrectionLevel;
			}
			set
			{
				this.Bar.Pdf417ErrorCorrectionLevel = value;
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x001F0234 File Offset: 0x001EE434
		// (set) Token: 0x060043F6 RID: 17398 RVA: 0x001F0241 File Offset: 0x001EE441
		[DisplayName("高度比例")]
		[Category("条码设置 - PDF417")]
		[O_Oo00Oo000O0(3.0)]
		[DefaultValue(0)]
		[MergableProperty(true)]
		public double Pdf417AspectRatio
		{
			get
			{
				return this.Bar.Pdf417AspectRatio;
			}
			set
			{
				this.Bar.Pdf417AspectRatio = value;
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x001F024F File Offset: 0x001EE44F
		// (set) Token: 0x060043F8 RID: 17400 RVA: 0x001F025C File Offset: 0x001EE45C
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("列数")]
		[DefaultValue(0)]
		[Category("条码设置 - PDF417")]
		public int Pdf417Columns
		{
			get
			{
				return this.Bar.Pdf417Columns;
			}
			set
			{
				this.Bar.Pdf417Columns = value;
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x001F026A File Offset: 0x001EE46A
		// (set) Token: 0x060043FA RID: 17402 RVA: 0x001F0277 File Offset: 0x001EE477
		[Category("条码设置 - PDF417")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("行数")]
		[MergableProperty(true)]
		public int Pdf417Rows
		{
			get
			{
				return this.Bar.Pdf417Rows;
			}
			set
			{
				this.Bar.Pdf417Rows = value;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x001F0285 File Offset: 0x001EE485
		// (set) Token: 0x060043FC RID: 17404 RVA: 0x001F0292 File Offset: 0x001EE492
		[O_Oo00Oo000O0(6.0)]
		[DefaultValue(false)]
		[Category("条码设置 - PDF417")]
		[MergableProperty(true)]
		[DisplayName("右侧截断")]
		public bool Pdf417Truncated
		{
			get
			{
				return this.Bar.Pdf417Truncated;
			}
			set
			{
				this.Bar.Pdf417Truncated = value;
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x060043FD RID: 17405 RVA: 0x001F02A0 File Offset: 0x001EE4A0
		// (set) Token: 0x060043FE RID: 17406 RVA: 0x001F02AD File Offset: 0x001EE4AD
		[DefaultValue("000")]
		[O_Oo00Oo000O0(7.0)]
		[MergableProperty(true)]
		[Category("条码设置 - PDF417")]
		[DisplayName("文件ID")]
		public string Pdf417FileId
		{
			get
			{
				return this.Bar.Pdf417FileId;
			}
			set
			{
				this.Bar.Pdf417FileId = value;
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x060043FF RID: 17407 RVA: 0x001F02BB File Offset: 0x001EE4BB
		// (set) Token: 0x06004400 RID: 17408 RVA: 0x001F02C8 File Offset: 0x001EE4C8
		[O_Oo00Oo000O0(8.0)]
		[MergableProperty(true)]
		[DisplayName("分段总数")]
		[DefaultValue(0)]
		[Category("条码设置 - PDF417")]
		public int Pdf417SegmentCount
		{
			get
			{
				return this.Bar.Pdf417SegmentCount;
			}
			set
			{
				this.Bar.Pdf417SegmentCount = value;
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06004401 RID: 17409 RVA: 0x001F02D6 File Offset: 0x001EE4D6
		// (set) Token: 0x06004402 RID: 17410 RVA: 0x001F02E3 File Offset: 0x001EE4E3
		[Category("条码设置 - PDF417")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(9.0)]
		[DisplayName("分段位置")]
		public int Pdf417SegmentIndex
		{
			get
			{
				return this.Bar.Pdf417SegmentIndex;
			}
			set
			{
				this.Bar.Pdf417SegmentIndex = value;
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06004403 RID: 17411 RVA: 0x001F02F1 File Offset: 0x001EE4F1
		// (set) Token: 0x06004404 RID: 17412 RVA: 0x001F02FE File Offset: 0x001EE4FE
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(1.0592)]
		[Category("条码设置 - Pharmacode")]
		[DisplayName("条间距")]
		public double PharmacodeBarsSpacing
		{
			get
			{
				return this.Bar.PharmacodeBarsSpacing;
			}
			set
			{
				this.Bar.PharmacodeBarsSpacing = value;
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x001F030C File Offset: 0x001EE50C
		// (set) Token: 0x06004406 RID: 17414 RVA: 0x001F0319 File Offset: 0x001EE519
		[DisplayName("宽条尺寸")]
		[DefaultValue(1.5875)]
		[Category("条码设置 - Pharmacode")]
		[O_Oo00Oo000O0(2.0)]
		[MergableProperty(true)]
		public double PharmacodeThickBarWidth
		{
			get
			{
				return this.Bar.PharmacodeThickBarWidth;
			}
			set
			{
				this.Bar.PharmacodeThickBarWidth = value;
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x001F0327 File Offset: 0x001EE527
		// (set) Token: 0x06004408 RID: 17416 RVA: 0x001F0334 File Offset: 0x001EE534
		[Category("条码设置 - Pharmacode")]
		[DisplayName("窄条尺寸")]
		[DefaultValue(0.5283)]
		[O_Oo00Oo000O0(3.0)]
		[MergableProperty(true)]
		public double PharmacodeThinBarWidth
		{
			get
			{
				return this.Bar.PharmacodeThinBarWidth;
			}
			set
			{
				this.Bar.PharmacodeThinBarWidth = value;
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06004409 RID: 17417 RVA: 0x001F0342 File Offset: 0x001EE542
		// (set) Token: 0x0600440A RID: 17418 RVA: 0x001F034F File Offset: 0x001EE54F
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[DefaultValue(5.0)]
		[Category("条码设置 - Planet")]
		[DisplayName("短条高度")]
		public double PlanetHeightShortBar
		{
			get
			{
				return this.Bar.PlanetHeightShortBar;
			}
			set
			{
				this.Bar.PlanetHeightShortBar = value;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x0600440B RID: 17419 RVA: 0x001F035D File Offset: 0x001EE55D
		// (set) Token: 0x0600440C RID: 17420 RVA: 0x001F036A File Offset: 0x001EE56A
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(10.0)]
		[Category("条码设置 - Planet")]
		[MergableProperty(true)]
		[DisplayName("长条高度")]
		public double PlanetHeightTallBar
		{
			get
			{
				return this.Bar.PlanetHeightTallBar;
			}
			set
			{
				this.Bar.PlanetHeightTallBar = value;
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x001F0378 File Offset: 0x001EE578
		// (set) Token: 0x0600440E RID: 17422 RVA: 0x001F0385 File Offset: 0x001EE585
		[Category("条码设置 - Postal 4-State")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("起止标记")]
		[DefaultValue(true)]
		[MergableProperty(true)]
		public bool Postal4StateAddStartStopChar
		{
			get
			{
				return this.Bar.Postal4StateAddStartStopChar;
			}
			set
			{
				this.Bar.Postal4StateAddStartStopChar = value;
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x0600440F RID: 17423 RVA: 0x001F0393 File Offset: 0x001EE593
		// (set) Token: 0x06004410 RID: 17424 RVA: 0x001F03A0 File Offset: 0x001EE5A0
		[DefaultValue(0.795)]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("条间距")]
		[Category("条码设置 - Postal 4-State")]
		[MergableProperty(true)]
		public double Postal4StateBarsSpacing
		{
			get
			{
				return this.Bar.Postal4StateBarsSpacing;
			}
			set
			{
				this.Bar.Postal4StateBarsSpacing = value;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x001F03AE File Offset: 0x001EE5AE
		// (set) Token: 0x06004412 RID: 17426 RVA: 0x001F03BB File Offset: 0x001EE5BB
		[DisplayName("条高度")]
		[Category("条码设置 - Postal 4-State")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		[DefaultValue(2.032)]
		public double Postal4StateTrackerBarHeight
		{
			get
			{
				return this.Bar.Postal4StateTrackerBarHeight;
			}
			set
			{
				this.Bar.Postal4StateTrackerBarHeight = value;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06004413 RID: 17427 RVA: 0x001F03C9 File Offset: 0x001EE5C9
		// (set) Token: 0x06004414 RID: 17428 RVA: 0x001F03D6 File Offset: 0x001EE5D6
		[DefaultValue(0.5283)]
		[Category("条码设置 - Postal 4-State")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("条宽度")]
		public double Postal4StateTrackerBarWidth
		{
			get
			{
				return this.Bar.Postal4StateTrackerBarWidth;
			}
			set
			{
				this.Bar.Postal4StateTrackerBarWidth = value;
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06004415 RID: 17429 RVA: 0x001F03E4 File Offset: 0x001EE5E4
		// (set) Token: 0x06004416 RID: 17430 RVA: 0x001F03F1 File Offset: 0x001EE5F1
		[O_Oo00Oo000O0(1.0)]
		[Category("条码设置 - Postnet")]
		[MergableProperty(true)]
		[DisplayName("短条高度")]
		[DefaultValue(5.0)]
		public double PostnetHeightShortBar
		{
			get
			{
				return this.Bar.PostnetHeightShortBar;
			}
			set
			{
				this.Bar.PostnetHeightShortBar = value;
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06004417 RID: 17431 RVA: 0x001F03FF File Offset: 0x001EE5FF
		// (set) Token: 0x06004418 RID: 17432 RVA: 0x001F040C File Offset: 0x001EE60C
		[MergableProperty(true)]
		[DisplayName("长条高度")]
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(10.0)]
		[Category("条码设置 - Postnet")]
		public double PostnetHeightTallBar
		{
			get
			{
				return this.Bar.PostnetHeightTallBar;
			}
			set
			{
				this.Bar.PostnetHeightTallBar = value;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x001F041A File Offset: 0x001EE61A
		// (set) Token: 0x0600441A RID: 17434 RVA: 0x001F0427 File Offset: 0x001EE627
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(0)]
		[DisplayName("编码版号")]
		[MergableProperty(true)]
		[Category("条码设置 - QR Code")]
		public MicroQRCodeVersion MicroQRCodeVersion
		{
			get
			{
				return this.Bar.MicroQRCodeVersion;
			}
			set
			{
				this.Bar.MicroQRCodeVersion = value;
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x0600441B RID: 17435 RVA: 0x001F0435 File Offset: 0x001EE635
		// (set) Token: 0x0600441C RID: 17436 RVA: 0x001F0442 File Offset: 0x001EE642
		[O_Oo00Oo000O0(2.0)]
		[MergableProperty(true)]
		[DisplayName("编码方式")]
		[Category("条码设置 - QR Code")]
		[DefaultValue(0)]
		public QRCodeEncoding QRCodeEncoding
		{
			get
			{
				return this.Bar.QRCodeEncoding;
			}
			set
			{
				this.Bar.QRCodeEncoding = value;
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x001F0450 File Offset: 0x001EE650
		// (set) Token: 0x0600441E RID: 17438 RVA: 0x001F045D File Offset: 0x001EE65D
		[DefaultValue(0)]
		[Category("条码设置 - QR Code")]
		[MergableProperty(true)]
		[DisplayName("编码版号")]
		[O_Oo00Oo000O0(3.0)]
		public QRCodeVersion QRCodeVersion
		{
			get
			{
				return this.Bar.QRCodeVersion;
			}
			set
			{
				this.Bar.QRCodeVersion = value;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x0600441F RID: 17439 RVA: 0x001F046B File Offset: 0x001EE66B
		// (set) Token: 0x06004420 RID: 17440 RVA: 0x001F0478 File Offset: 0x001EE678
		[Category("条码设置 - QR Code")]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("容错级别")]
		[DefaultValue(1)]
		[MergableProperty(true)]
		public QRCodeErrorCorrectionLevel QRCodeErrorCorrectionLevel
		{
			get
			{
				return this.Bar.QRCodeErrorCorrectionLevel;
			}
			set
			{
				this.Bar.QRCodeErrorCorrectionLevel = value;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06004421 RID: 17441 RVA: 0x001F0486 File Offset: 0x001EE686
		// (set) Token: 0x06004422 RID: 17442 RVA: 0x001F0493 File Offset: 0x001EE693
		[O_Oo00Oo000O0(5.0)]
		[DefaultValue("gb2312")]
		[Category("条码设置 - QR Code")]
		[TypeConverter(typeof(o___o_O__))]
		[MergableProperty(true)]
		[DisplayName("字符编码")]
		public string QRCodeByteEncodingName
		{
			get
			{
				return this.Bar.QRCodeByteEncodingName;
			}
			set
			{
				this.Bar.QRCodeByteEncodingName = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06004423 RID: 17443 RVA: 0x001F04A1 File Offset: 0x001EE6A1
		// (set) Token: 0x06004424 RID: 17444 RVA: 0x001F04AE File Offset: 0x001EE6AE
		[DisplayName("模组尺寸")]
		[O_Oo00Oo000O0(7.0)]
		[DefaultValue(1.0592)]
		[Category("条码设置 - QR Code")]
		[MergableProperty(true)]
		public double QRCodeModuleSize
		{
			get
			{
				return this.Bar.QRCodeModuleSize;
			}
			set
			{
				this.Bar.QRCodeModuleSize = value;
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06004425 RID: 17445 RVA: 0x001F04BC File Offset: 0x001EE6BC
		// (set) Token: 0x06004426 RID: 17446 RVA: 0x001F04C9 File Offset: 0x001EE6C9
		[Category("条码设置 - Telepen")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("编码方式")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		public TelepenEncoding TelepenEncoding
		{
			get
			{
				return this.Bar.TelepenEncoding;
			}
			set
			{
				this.Bar.TelepenEncoding = value;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06004427 RID: 17447 RVA: 0x001F04D7 File Offset: 0x001EE6D7
		// (set) Token: 0x06004428 RID: 17448 RVA: 0x001F04E4 File Offset: 0x001EE6E4
		[DisplayName("编码方式")]
		[MergableProperty(true)]
		[Category("条码设置 - USPS FIM")]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(0)]
		public FIM UspsFimPattern
		{
			get
			{
				return this.Bar.UspsFimPattern;
			}
			set
			{
				this.Bar.UspsFimPattern = value;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x001F04F2 File Offset: 0x001EE6F2
		// (set) Token: 0x0600442A RID: 17450 RVA: 0x001F04FF File Offset: 0x001EE6FF
		[O_Oo00Oo000O0(1.0)]
		[Category("条码设置 - USPS Horizontal Bars")]
		[DefaultValue(10)]
		[MergableProperty(true)]
		public int UspsHorizontalBarsCount
		{
			get
			{
				return this.Bar.UspsHorizontalBarsCount;
			}
			set
			{
				this.Bar.UspsHorizontalBarsCount = value;
			}
		}

		// Token: 0x04001BC3 RID: 7107
		[CompilerGenerated]
		[AccessedThroughProperty("Bar")]
		private OOo00o_0o0_ <<EMPTY_NAME>>;

		// Token: 0x04001BC4 RID: 7108
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BC5 RID: 7109
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BC6 RID: 7110
		private string <<EMPTY_NAME>>;
	}
}
