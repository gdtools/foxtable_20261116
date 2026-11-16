using System;
using System.ComponentModel;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;
using Neodynamic.WinControls.BarcodeProfessional;

namespace Foxtable
{
	// Token: 0x0200003A RID: 58
	internal class BarcodeProfessionalProperty
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x00005292 File Offset: 0x00003492
		public BarcodeProfessionalProperty(BarcodeProfessional A_0)
		{
			this.O.0o_0_o. = A_0;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000052A1 File Offset: 0x000034A1
		// (set) Token: 0x060001EB RID: 491 RVA: 0x000052AE File Offset: 0x000034AE
		[Browsable(false)]
		public Symbology Symbology
		{
			get
			{
				return this.O.0o_0_o..Symbology;
			}
			set
			{
				this.O.0o_0_o..Symbology = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000052BC File Offset: 0x000034BC
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000052DD File Offset: 0x000034DD
		[TypeConverter(typeof(OoOO___oo))]
		[OooO0(true)]
		[DisplayName("条码类型")]
		[Category("条码设置")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		public string CodeType
		{
			get
			{
				return Enum.GetName(typeof(Symbology), this.O.0o_0_o..Symbology);
			}
			set
			{
				this.O.0o_0_o..Symbology = (Symbology)Conversions.ToInteger(Enum.Parse(typeof(Symbology), value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000052FF File Offset: 0x000034FF
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0000530C File Offset: 0x0000350C
		[O_Oo00Oo000O0(2.0)]
		[MergableProperty(true)]
		[Category("条码设置")]
		[DisplayName("条码内容")]
		[Browsable(false)]
		public virtual string Code
		{
			get
			{
				return this.O.0o_0_o..Code;
			}
			set
			{
				this.O.0o_0_o..Code = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000531A File Offset: 0x0000351A
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00005327 File Offset: 0x00003527
		[DefaultValue(0.2642)]
		[O_Oo00Oo000O0(3.0)]
		[MergableProperty(true)]
		[Category("条码设置")]
		[DisplayName("窄条宽度")]
		public double BarWidth
		{
			get
			{
				return this.O.0o_0_o..BarWidth;
			}
			set
			{
				this.O.0o_0_o..BarWidth = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00005335 File Offset: 0x00003535
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00005342 File Offset: 0x00003542
		[Category("条码设置")]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("宽窄比例")]
		[DefaultValue(2.0)]
		[MergableProperty(true)]
		public double BarRatio
		{
			get
			{
				return this.O.0o_0_o..BarRatio;
			}
			set
			{
				this.O.0o_0_o..BarRatio = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00005350 File Offset: 0x00003550
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000535D File Offset: 0x0000355D
		[Category("条码设置")]
		[DisplayName("条码高度")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(5.0)]
		[DefaultValue(5.08)]
		public double BarHeight
		{
			get
			{
				return this.O.0o_0_o..BarHeight;
			}
			set
			{
				this.O.0o_0_o..BarHeight = value;
				this.O.0o_0_o..GuardBarHeight = value * 1.25;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00005381 File Offset: 0x00003581
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000538E File Offset: 0x0000358E
		[Category("条码设置")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(5.1)]
		[DisplayName("静区宽度")]
		[DefaultValue(0)]
		public double QuietZoneWidth
		{
			get
			{
				return this.O.0o_0_o..QuietZoneWidth;
			}
			set
			{
				this.O.0o_0_o..QuietZoneWidth = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000539C File Offset: 0x0000359C
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x000053A9 File Offset: 0x000035A9
		[DisplayName("旋转角度")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(6.0)]
		[Category("条码设置")]
		[DefaultValue(0)]
		public Rotate Rotate
		{
			get
			{
				return this.O.0o_0_o..Rotate;
			}
			set
			{
				this.O.0o_0_o..Rotate = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001FA RID: 506 RVA: 0x000053B7 File Offset: 0x000035B7
		// (set) Token: 0x060001FB RID: 507 RVA: 0x000053C4 File Offset: 0x000035C4
		[DisplayName("增加校验")]
		[DefaultValue(true)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(7.0)]
		[Category("条码设置")]
		public bool AddCheckSum
		{
			get
			{
				return this.O.0o_0_o..AddChecksum;
			}
			set
			{
				this.O.0o_0_o..AddChecksum = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001FC RID: 508 RVA: 0x000053D2 File Offset: 0x000035D2
		// (set) Token: 0x060001FD RID: 509 RVA: 0x000053DF File Offset: 0x000035DF
		[MergableProperty(true)]
		[Category("条码设置")]
		[DisplayName("保护框")]
		[O_Oo00Oo000O0(8.0)]
		[DefaultValue(0)]
		public BearerBarStyle BearBarStyle
		{
			get
			{
				return this.O.0o_0_o..BearerBarStyle;
			}
			set
			{
				this.O.0o_0_o..BearerBarStyle = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000053ED File Offset: 0x000035ED
		// (set) Token: 0x060001FF RID: 511 RVA: 0x000053FA File Offset: 0x000035FA
		[DefaultValue(1.27)]
		[O_Oo00Oo000O0(9.0)]
		[DisplayName("保护框宽度")]
		[Category("条码设置")]
		[MergableProperty(true)]
		public double BearerBarWidth
		{
			get
			{
				return this.O.0o_0_o..BearerBarWidth;
			}
			set
			{
				this.O.0o_0_o..BearerBarWidth = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00005408 File Offset: 0x00003608
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00005415 File Offset: 0x00003615
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		[Category("条码设置 - 文本")]
		[DisplayName("显示文本")]
		[DefaultValue(true)]
		public bool DisplayCode
		{
			get
			{
				return this.O.0o_0_o..DisplayCode;
			}
			set
			{
				this.O.0o_0_o..DisplayCode = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00005423 File Offset: 0x00003623
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00005430 File Offset: 0x00003630
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		[Category("条码设置 - 文本")]
		[DefaultValue(true)]
		[DisplayName("显示校验符")]
		public bool DisplayChecksum
		{
			get
			{
				return this.O.0o_0_o..DisplayChecksum;
			}
			set
			{
				this.O.0o_0_o..DisplayChecksum = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000543E File Offset: 0x0000363E
		// (set) Token: 0x06000205 RID: 517 RVA: 0x0000544B File Offset: 0x0000364B
		[DefaultValue(true)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("显示起止符")]
		[Category("条码设置 - 文本")]
		public bool DisplayStartStopChar
		{
			get
			{
				return this.O.0o_0_o..DisplayStartStopChar;
			}
			set
			{
				this.O.0o_0_o..DisplayStartStopChar = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00005459 File Offset: 0x00003659
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00005466 File Offset: 0x00003666
		[DisplayName("替换文本")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[DefaultValue("")]
		[Category("条码设置 - 文本")]
		public virtual string HumanReadableText
		{
			get
			{
				return this.O.0o_0_o..HumanReadableText;
			}
			set
			{
				this.O.0o_0_o..HumanReadableText = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00005474 File Offset: 0x00003674
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00005481 File Offset: 0x00003681
		[DisplayName("文本位置")]
		[O_Oo00Oo000O0(5.0)]
		[DefaultValue(4)]
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		public Alignment CodeAlignment
		{
			get
			{
				return this.O.0o_0_o..CodeAlignment;
			}
			set
			{
				this.O.0o_0_o..CodeAlignment = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000548F File Offset: 0x0000368F
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000549C File Offset: 0x0000369C
		[DisplayName("说明文本")]
		[DefaultValue("")]
		[O_Oo00Oo000O0(6.0)]
		[MergableProperty(true)]
		[Category("条码设置 - 文本")]
		public virtual string Text
		{
			get
			{
				return this.O.0o_0_o..Text;
			}
			set
			{
				this.O.0o_0_o..Text = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000054AA File Offset: 0x000036AA
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000054B7 File Offset: 0x000036B7
		[DefaultValue(0)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(7.0)]
		[DisplayName("说明位置")]
		[Category("条码设置 - 文本")]
		public Alignment TextAlignment
		{
			get
			{
				return this.O.0o_0_o..TextAlignment;
			}
			set
			{
				this.O.0o_0_o..TextAlignment = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000054C5 File Offset: 0x000036C5
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000054D2 File Offset: 0x000036D2
		[O_Oo00Oo000O0(8.0)]
		[DisplayName("上文本间距")]
		[DefaultValue(0)]
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		public double TopMargin
		{
			get
			{
				return this.O.0o_0_o..TopMargin;
			}
			set
			{
				this.O.0o_0_o..TopMargin = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000054E0 File Offset: 0x000036E0
		// (set) Token: 0x06000211 RID: 529 RVA: 0x000054ED File Offset: 0x000036ED
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		[DisplayName("下文本间距")]
		[O_Oo00Oo000O0(9.0)]
		[DefaultValue(0)]
		public double BottomMargin
		{
			get
			{
				return this.O.0o_0_o..BottomMargin;
			}
			set
			{
				this.O.0o_0_o..BottomMargin = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000054FB File Offset: 0x000036FB
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00005508 File Offset: 0x00003708
		[MergableProperty(true)]
		[DefaultValue("宋体,9")]
		[DisplayName("文本字体")]
		[Category("条码设置 - 文本")]
		[O_Oo00Oo000O0(10.0)]
		public Font Font
		{
			get
			{
				return this.O.0o_0_o..Font;
			}
			set
			{
				this.O.0o_0_o..Font = (Font)value.Clone();
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00005520 File Offset: 0x00003720
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0000552D File Offset: 0x0000372D
		[DisplayName("文本颜色")]
		[O_Oo00Oo000O0(11.0)]
		[DefaultValue(-16777216)]
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		public Color ForeColor
		{
			get
			{
				return this.O.0o_0_o..ForeColor;
			}
			set
			{
				this.O.0o_0_o..ForeColor = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000553B File Offset: 0x0000373B
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00005548 File Offset: 0x00003748
		[O_Oo00Oo000O0(12.0)]
		[DefaultValue("宋体,9")]
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		[DisplayName("说明字体")]
		public Font TextFont
		{
			get
			{
				return this.O.0o_0_o..TextFont;
			}
			set
			{
				this.O.0o_0_o..TextFont = (Font)value.Clone();
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00005560 File Offset: 0x00003760
		// (set) Token: 0x06000219 RID: 537 RVA: 0x0000556D File Offset: 0x0000376D
		[O_Oo00Oo000O0(13.0)]
		[DefaultValue(-16777216)]
		[Category("条码设置 - 文本")]
		[MergableProperty(true)]
		[DisplayName("说明颜色")]
		public Color TextForeColor
		{
			get
			{
				return this.O.0o_0_o..TextForeColor;
			}
			set
			{
				this.O.0o_0_o..TextForeColor = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000557B File Offset: 0x0000377B
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00005588 File Offset: 0x00003788
		[Category("条码设置 - AztecCode")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("编码格式")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		public AztecCodeFormat AztecCodeFormat
		{
			get
			{
				return this.O.0o_0_o..AztecCodeFormat;
			}
			set
			{
				this.O.0o_0_o..AztecCodeFormat = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00005596 File Offset: 0x00003796
		// (set) Token: 0x0600021D RID: 541 RVA: 0x000055A3 File Offset: 0x000037A3
		[MergableProperty(true)]
		[Category("条码设置 - AztecCode")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("模组尺寸")]
		[DefaultValue(1.0592)]
		public double AztecCodeModuleSize
		{
			get
			{
				return this.O.0o_0_o..AztecCodeModuleSize;
			}
			set
			{
				this.O.0o_0_o..AztecCodeModuleSize = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000055B1 File Offset: 0x000037B1
		// (set) Token: 0x0600021F RID: 543 RVA: 0x000055BE File Offset: 0x000037BE
		[O_Oo00Oo000O0(3.0)]
		[DefaultValue(23)]
		[DisplayName("容错比例")]
		[MergableProperty(true)]
		[Category("条码设置 - AztecCode")]
		public int AztecCodeErrorCorrection
		{
			get
			{
				return this.O.0o_0_o..AztecCodeErrorCorrection;
			}
			set
			{
				this.O.0o_0_o..AztecCodeErrorCorrection = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000055CC File Offset: 0x000037CC
		// (set) Token: 0x06000221 RID: 545 RVA: 0x000055D9 File Offset: 0x000037D9
		[DefaultValue(-1)]
		[O_Oo00Oo000O0(4.0)]
		[Category("条码设置 - AztecCode")]
		[MergableProperty(true)]
		public int AztecCodeRune
		{
			get
			{
				return this.O.0o_0_o..AztecCodeRune;
			}
			set
			{
				this.O.0o_0_o..AztecCodeRune = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000055E7 File Offset: 0x000037E7
		// (set) Token: 0x06000223 RID: 547 RVA: 0x000055F4 File Offset: 0x000037F4
		[DefaultValue(0)]
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[DisplayName("起始字符")]
		[Category("条码设置 - Codabar")]
		public CodabarStartStopChar CodabarStartChar
		{
			get
			{
				return this.O.0o_0_o..CodabarStartChar;
			}
			set
			{
				this.O.0o_0_o..CodabarStartChar = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00005602 File Offset: 0x00003802
		// (set) Token: 0x06000225 RID: 549 RVA: 0x0000560F File Offset: 0x0000380F
		[Category("条码设置 - Codabar")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(2.0)]
		[MergableProperty(true)]
		[DisplayName("结束字符")]
		public CodabarStartStopChar CodabarStopChar
		{
			get
			{
				return this.O.0o_0_o..CodabarStopChar;
			}
			set
			{
				this.O.0o_0_o..CodabarStopChar = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000561D File Offset: 0x0000381D
		// (set) Token: 0x06000227 RID: 551 RVA: 0x0000562A File Offset: 0x0000382A
		[MergableProperty(true)]
		[DefaultValue(0)]
		[Category("条码设置 - Code128")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("字符集")]
		public Code128 Code128CharSet
		{
			get
			{
				return this.O.0o_0_o..Code128CharSet;
			}
			set
			{
				this.O.0o_0_o..Code128CharSet = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00005638 File Offset: 0x00003838
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00005645 File Offset: 0x00003845
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("编码模式")]
		[DefaultValue(0)]
		[Category("条码设置 - Code16K")]
		[MergableProperty(true)]
		public Code16k Code16kMode
		{
			get
			{
				return this.O.0o_0_o..Code16kMode;
			}
			set
			{
				this.O.0o_0_o..Code16kMode = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00005653 File Offset: 0x00003853
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00005660 File Offset: 0x00003860
		[DisplayName("编码方式")]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(0)]
		[Category("条码设置 - DataMatrix")]
		[MergableProperty(true)]
		public DataMatrixEncoding DataMatrixEncoding
		{
			get
			{
				return this.O.0o_0_o..DataMatrixEncoding;
			}
			set
			{
				this.O.0o_0_o..DataMatrixEncoding = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000566E File Offset: 0x0000386E
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0000567B File Offset: 0x0000387B
		[DisplayName("编码格式")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(0)]
		[Category("条码设置 - DataMatrix")]
		public DataMatrixFormat DataMatrixFormat
		{
			get
			{
				return this.O.0o_0_o..DataMatrixFormat;
			}
			set
			{
				this.O.0o_0_o..DataMatrixFormat = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00005689 File Offset: 0x00003889
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00005696 File Offset: 0x00003896
		[O_Oo00Oo000O0(3.0)]
		[DefaultValue(1.0592)]
		[Category("条码设置 - DataMatrix")]
		[MergableProperty(true)]
		[DisplayName("模组尺寸")]
		public double DataMatrixModuleSize
		{
			get
			{
				return this.O.0o_0_o..DataMatrixModuleSize;
			}
			set
			{
				this.O.0o_0_o..DataMatrixModuleSize = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000056A4 File Offset: 0x000038A4
		// (set) Token: 0x06000231 RID: 561 RVA: 0x000056B1 File Offset: 0x000038B1
		[DefaultValue(false)]
		[Category("条码设置 - DataMatrix")]
		[O_Oo00Oo000O0(4.0)]
		[MergableProperty(true)]
		[DisplayName("处理波形符")]
		public bool DataMatrixProcessTilde
		{
			get
			{
				return this.O.0o_0_o..DataMatrixProcessTilde;
			}
			set
			{
				this.O.0o_0_o..DataMatrixProcessTilde = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000232 RID: 562 RVA: 0x000056BF File Offset: 0x000038BF
		// (set) Token: 0x06000233 RID: 563 RVA: 0x000056CC File Offset: 0x000038CC
		[Category("条码设置 - Ean And Upc")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("附加码数")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		public Supplement EanUpcSupplement
		{
			get
			{
				return this.O.0o_0_o..EanUpcSupplement;
			}
			set
			{
				this.O.0o_0_o..EanUpcSupplement = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000056DA File Offset: 0x000038DA
		// (set) Token: 0x06000235 RID: 565 RVA: 0x000056E7 File Offset: 0x000038E7
		[DefaultValue("0")]
		[O_Oo00Oo000O0(2.0)]
		[Category("条码设置 - Ean And Upc")]
		[DisplayName("附加码值")]
		[MergableProperty(true)]
		public string EanUpcSupplementCode
		{
			get
			{
				return this.O.0o_0_o..EanUpcSupplementCode;
			}
			set
			{
				this.O.0o_0_o..EanUpcSupplementCode = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000236 RID: 566 RVA: 0x000056F5 File Offset: 0x000038F5
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00005702 File Offset: 0x00003902
		[DisplayName("附加码左距")]
		[Category("条码设置 - Ean And Upc")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		[DefaultValue(3.81)]
		public double EanUpcSupplementSeparation
		{
			get
			{
				return this.O.0o_0_o..EanUpcSupplementSeparation;
			}
			set
			{
				this.O.0o_0_o..EanUpcSupplementSeparation = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00005710 File Offset: 0x00003910
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0000571D File Offset: 0x0000391D
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("附加码上距")]
		[DefaultValue(3.81)]
		[Category("条码设置 - Ean And Upc")]
		[MergableProperty(true)]
		public double EanUpcSupplementTopMargin
		{
			get
			{
				return this.O.0o_0_o..EanUpcSupplementTopMargin;
			}
			set
			{
				this.O.0o_0_o..EanUpcSupplementTopMargin = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0000572B File Offset: 0x0000392B
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00005738 File Offset: 0x00003938
		[Category("条码设置 - Ean And Upc")]
		[DefaultValue(true)]
		[MergableProperty(true)]
		[DisplayName("显示防护条")]
		[O_Oo00Oo000O0(5.0)]
		public bool GuardBar
		{
			get
			{
				return this.O.0o_0_o..GuardBar;
			}
			set
			{
				this.O.0o_0_o..GuardBar = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00005746 File Offset: 0x00003946
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00005753 File Offset: 0x00003953
		[DefaultValue(6.35)]
		[Category("条码设置 - Ean And Upc")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("防护条高度")]
		public double GuardBarHeight
		{
			get
			{
				return this.O.0o_0_o..GuardBarHeight;
			}
			set
			{
				this.O.0o_0_o..GuardBarHeight = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00005761 File Offset: 0x00003961
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0000576E File Offset: 0x0000396E
		[MergableProperty(true)]
		[Category("条码设置 - Ean And Upc")]
		[O_Oo00Oo000O0(7.0)]
		[DisplayName("编码方式")]
		[DefaultValue(0)]
		public UpcE UpcESystem
		{
			get
			{
				return this.O.0o_0_o..UpcESystem;
			}
			set
			{
				this.O.0o_0_o..UpcESystem = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0000577C File Offset: 0x0000397C
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00005789 File Offset: 0x00003989
		[DefaultValue(4)]
		[O_Oo00Oo000O0(1.0)]
		[Category("条码设置 - ExpandedStacked")]
		[DisplayName("每行段数")]
		[MergableProperty(true)]
		public int SegmentsPerRow
		{
			get
			{
				return this.O.0o_0_o..SegmentsPerRow;
			}
			set
			{
				this.O.0o_0_o..SegmentsPerRow = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00005797 File Offset: 0x00003997
		// (set) Token: 0x06000243 RID: 579 RVA: 0x000057A4 File Offset: 0x000039A4
		[DisplayName("格式化替换文本")]
		[O_Oo00Oo000O0(1.0)]
		[Category("条码设置 - HIBC")]
		[MergableProperty(true)]
		[DefaultValue(true)]
		public bool HibcFormatHumanReadableText
		{
			get
			{
				return this.O.0o_0_o..HibcFormatHumanReadableText;
			}
			set
			{
				this.O.0o_0_o..HibcFormatHumanReadableText = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000244 RID: 580 RVA: 0x000057B2 File Offset: 0x000039B2
		// (set) Token: 0x06000245 RID: 581 RVA: 0x000057BF File Offset: 0x000039BF
		[DisplayName("数据结构")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[Category("条码设置 - ISBT")]
		public Isbt128DataStructure Isbt128DataStructure
		{
			get
			{
				return this.O.0o_0_o..Isbt128DataStructure;
			}
			set
			{
				this.O.0o_0_o..Isbt128DataStructure = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000057CD File Offset: 0x000039CD
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000057DA File Offset: 0x000039DA
		[DisplayName("编码模式")]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(4)]
		[Category("条码设置 - MaxiCode")]
		[MergableProperty(true)]
		public MaxiCodeModes MaxiCodeMode
		{
			get
			{
				return this.O.0o_0_o..MaxiCodeMode;
			}
			set
			{
				this.O.0o_0_o..MaxiCodeMode = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000057E8 File Offset: 0x000039E8
		// (set) Token: 0x06000249 RID: 585 RVA: 0x000057F5 File Offset: 0x000039F5
		[DefaultValue(1)]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("模式字符数量")]
		[Category("条码设置 - MaxiCode")]
		[MergableProperty(true)]
		public int MaxiCodeSymbolCount
		{
			get
			{
				return this.O.0o_0_o..MaxiCodeSymbolCount;
			}
			set
			{
				this.O.0o_0_o..MaxiCodeSymbolCount = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00005803 File Offset: 0x00003A03
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00005810 File Offset: 0x00003A10
		[DisplayName("模式字符位置")]
		[DefaultValue(1)]
		[Category("条码设置 - MaxiCode")]
		[O_Oo00Oo000O0(3.0)]
		[MergableProperty(true)]
		public int MaxiCodeSymbolIndex
		{
			get
			{
				return this.O.0o_0_o..MaxiCodeSymbolIndex;
			}
			set
			{
				this.O.0o_0_o..MaxiCodeSymbolIndex = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000581E File Offset: 0x00003A1E
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0000582B File Offset: 0x00003A2B
		[Category("条码设置 - MaxiCode")]
		[DefaultValue(false)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("处理波浪符")]
		public bool MaxiCodeProcessTilde
		{
			get
			{
				return this.O.0o_0_o..MaxiCodeProcessTilde;
			}
			set
			{
				this.O.0o_0_o..MaxiCodeProcessTilde = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00005839 File Offset: 0x00003A39
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00005846 File Offset: 0x00003A46
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[DisplayName("校验模式")]
		[DefaultValue(0)]
		[Category("条码设置 - MSI")]
		public MsiChecksum MsiChecksum
		{
			get
			{
				return this.O.0o_0_o..MsiChecksum;
			}
			set
			{
				this.O.0o_0_o..MsiChecksum = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00005854 File Offset: 0x00003A54
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00005861 File Offset: 0x00003A61
		[MergableProperty(true)]
		[Category("条码设置 - PDF417")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("编码类型")]
		[DefaultValue(0)]
		public Pdf417CompactionType Pdf417CompactionType
		{
			get
			{
				return this.O.0o_0_o..Pdf417CompactionType;
			}
			set
			{
				this.O.0o_0_o..Pdf417CompactionType = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000586F File Offset: 0x00003A6F
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0000587C File Offset: 0x00003A7C
		[DefaultValue(0)]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("编码版号")]
		[Category("条码设置 - PDF417")]
		[MergableProperty(true)]
		public MicroPdf417Version MicroPdf417Version
		{
			get
			{
				return this.O.0o_0_o..MicroPdf417Version;
			}
			set
			{
				this.O.0o_0_o..MicroPdf417Version = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000588A File Offset: 0x00003A8A
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00005897 File Offset: 0x00003A97
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.1)]
		[Category("条码设置 - PDF417")]
		[DisplayName("容错级别")]
		[DefaultValue(2)]
		public Pdf417ErrorCorrection Pdf417ErrorCorrectionLevel
		{
			get
			{
				return this.O.0o_0_o..Pdf417ErrorCorrectionLevel;
			}
			set
			{
				this.O.0o_0_o..Pdf417ErrorCorrectionLevel = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000058A5 File Offset: 0x00003AA5
		// (set) Token: 0x06000257 RID: 599 RVA: 0x000058B2 File Offset: 0x00003AB2
		[Category("条码设置 - PDF417")]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("高度比例")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		public double Pdf417AspectRatio
		{
			get
			{
				return this.O.0o_0_o..Pdf417AspectRatio;
			}
			set
			{
				this.O.0o_0_o..Pdf417AspectRatio = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000058C0 File Offset: 0x00003AC0
		// (set) Token: 0x06000259 RID: 601 RVA: 0x000058CD File Offset: 0x00003ACD
		[Category("条码设置 - PDF417")]
		[DisplayName("列数")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[DefaultValue(0)]
		public int Pdf417Columns
		{
			get
			{
				return this.O.0o_0_o..Pdf417Columns;
			}
			set
			{
				this.O.0o_0_o..Pdf417Columns = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600025A RID: 602 RVA: 0x000058DB File Offset: 0x00003ADB
		// (set) Token: 0x0600025B RID: 603 RVA: 0x000058E8 File Offset: 0x00003AE8
		[Category("条码设置 - PDF417")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("行数")]
		public int Pdf417Rows
		{
			get
			{
				return this.O.0o_0_o..Pdf417Rows;
			}
			set
			{
				this.O.0o_0_o..Pdf417Rows = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600025C RID: 604 RVA: 0x000058F6 File Offset: 0x00003AF6
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00005903 File Offset: 0x00003B03
		[Category("条码设置 - PDF417")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("右侧截断")]
		[DefaultValue(false)]
		public bool Pdf417Truncated
		{
			get
			{
				return this.O.0o_0_o..Pdf417Truncated;
			}
			set
			{
				this.O.0o_0_o..Pdf417Truncated = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00005911 File Offset: 0x00003B11
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000591E File Offset: 0x00003B1E
		[DefaultValue("000")]
		[MergableProperty(true)]
		[DisplayName("文件ID")]
		[O_Oo00Oo000O0(7.0)]
		[Category("条码设置 - PDF417")]
		public string Pdf417FileId
		{
			get
			{
				return this.O.0o_0_o..Pdf417FileId;
			}
			set
			{
				this.O.0o_0_o..Pdf417FileId = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000592C File Offset: 0x00003B2C
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00005939 File Offset: 0x00003B39
		[MergableProperty(true)]
		[DisplayName("分段总数")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(8.0)]
		[Category("条码设置 - PDF417")]
		public int Pdf417SegmentCount
		{
			get
			{
				return this.O.0o_0_o..Pdf417SegmentCount;
			}
			set
			{
				this.O.0o_0_o..Pdf417SegmentCount = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00005947 File Offset: 0x00003B47
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00005954 File Offset: 0x00003B54
		[Category("条码设置 - PDF417")]
		[O_Oo00Oo000O0(9.0)]
		[DisplayName("分段位置")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		public int Pdf417SegmentIndex
		{
			get
			{
				return this.O.0o_0_o..Pdf417SegmentIndex;
			}
			set
			{
				this.O.0o_0_o..Pdf417SegmentIndex = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00005962 File Offset: 0x00003B62
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0000596F File Offset: 0x00003B6F
		[Category("条码设置 - Pharmacode")]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(1.0592)]
		[MergableProperty(true)]
		[DisplayName("条间距")]
		public double PharmacodeBarsSpacing
		{
			get
			{
				return this.O.0o_0_o..PharmacodeBarsSpacing;
			}
			set
			{
				this.O.0o_0_o..PharmacodeBarsSpacing = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000597D File Offset: 0x00003B7D
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0000598A File Offset: 0x00003B8A
		[DisplayName("宽条尺寸")]
		[Category("条码设置 - Pharmacode")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(1.5875)]
		public double PharmacodeThickBarWidth
		{
			get
			{
				return this.O.0o_0_o..PharmacodeThickBarWidth;
			}
			set
			{
				this.O.0o_0_o..PharmacodeThickBarWidth = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00005998 File Offset: 0x00003B98
		// (set) Token: 0x06000269 RID: 617 RVA: 0x000059A5 File Offset: 0x00003BA5
		[O_Oo00Oo000O0(3.0)]
		[Category("条码设置 - Pharmacode")]
		[MergableProperty(true)]
		[DefaultValue(0.5283)]
		[DisplayName("窄条尺寸")]
		public double PharmacodeThinBarWidth
		{
			get
			{
				return this.O.0o_0_o..PharmacodeThinBarWidth;
			}
			set
			{
				this.O.0o_0_o..PharmacodeThinBarWidth = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000059B3 File Offset: 0x00003BB3
		// (set) Token: 0x0600026B RID: 619 RVA: 0x000059C0 File Offset: 0x00003BC0
		[Category("条码设置 - Planet")]
		[MergableProperty(true)]
		[DisplayName("短条高度")]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(5.0)]
		public double PlanetHeightShortBar
		{
			get
			{
				return this.O.0o_0_o..PlanetHeightShortBar;
			}
			set
			{
				this.O.0o_0_o..PlanetHeightShortBar = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600026C RID: 620 RVA: 0x000059CE File Offset: 0x00003BCE
		// (set) Token: 0x0600026D RID: 621 RVA: 0x000059DB File Offset: 0x00003BDB
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("长条高度")]
		[DefaultValue(10.0)]
		[Category("条码设置 - Planet")]
		public double PlanetHeightTallBar
		{
			get
			{
				return this.O.0o_0_o..PlanetHeightTallBar;
			}
			set
			{
				this.O.0o_0_o..PlanetHeightTallBar = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000059E9 File Offset: 0x00003BE9
		// (set) Token: 0x0600026F RID: 623 RVA: 0x000059F6 File Offset: 0x00003BF6
		[Category("条码设置 - Postal 4-State")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("起止标记")]
		[DefaultValue(true)]
		[MergableProperty(true)]
		public bool Postal4StateAddStartStopChar
		{
			get
			{
				return this.O.0o_0_o..Postal4StateAddStartStopChar;
			}
			set
			{
				this.O.0o_0_o..Postal4StateAddStartStopChar = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00005A04 File Offset: 0x00003C04
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00005A11 File Offset: 0x00003C11
		[DefaultValue(0.795)]
		[MergableProperty(true)]
		[Category("条码设置 - Postal 4-State")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("条间距")]
		public double Postal4StateBarsSpacing
		{
			get
			{
				return this.O.0o_0_o..Postal4StateBarsSpacing;
			}
			set
			{
				this.O.0o_0_o..Postal4StateBarsSpacing = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00005A1F File Offset: 0x00003C1F
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00005A2C File Offset: 0x00003C2C
		[DisplayName("条高度")]
		[Category("条码设置 - Postal 4-State")]
		[MergableProperty(true)]
		[DefaultValue(2.032)]
		[O_Oo00Oo000O0(3.0)]
		public double Postal4StateTrackerBarHeight
		{
			get
			{
				return this.O.0o_0_o..Postal4StateTrackerBarHeight;
			}
			set
			{
				this.O.0o_0_o..Postal4StateTrackerBarHeight = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00005A3A File Offset: 0x00003C3A
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00005A47 File Offset: 0x00003C47
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[DefaultValue(0.5283)]
		[Category("条码设置 - Postal 4-State")]
		[DisplayName("条宽度")]
		public double Postal4StateTrackerBarWidth
		{
			get
			{
				return this.O.0o_0_o..Postal4StateTrackerBarWidth;
			}
			set
			{
				this.O.0o_0_o..Postal4StateTrackerBarWidth = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00005A55 File Offset: 0x00003C55
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00005A62 File Offset: 0x00003C62
		[DefaultValue(5.0)]
		[O_Oo00Oo000O0(1.0)]
		[Category("条码设置 - Postnet")]
		[MergableProperty(true)]
		[DisplayName("短条高度")]
		public double PostnetHeightShortBar
		{
			get
			{
				return this.O.0o_0_o..PostnetHeightShortBar;
			}
			set
			{
				this.O.0o_0_o..PostnetHeightShortBar = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00005A70 File Offset: 0x00003C70
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00005A7D File Offset: 0x00003C7D
		[DefaultValue(10.0)]
		[DisplayName("长条高度")]
		[MergableProperty(true)]
		[Category("条码设置 - Postnet")]
		[O_Oo00Oo000O0(2.0)]
		public double PostnetHeightTallBar
		{
			get
			{
				return this.O.0o_0_o..PostnetHeightTallBar;
			}
			set
			{
				this.O.0o_0_o..PostnetHeightTallBar = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00005A8B File Offset: 0x00003C8B
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00005A98 File Offset: 0x00003C98
		[DisplayName("编码版号")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(0)]
		[Category("条码设置 - QR Code")]
		public MicroQRCodeVersion MicroQRCodeVersion
		{
			get
			{
				return this.O.0o_0_o..MicroQRCodeVersion;
			}
			set
			{
				this.O.0o_0_o..MicroQRCodeVersion = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00005AA6 File Offset: 0x00003CA6
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00005AB3 File Offset: 0x00003CB3
		[DisplayName("编码方式")]
		[Category("条码设置 - QR Code")]
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(0)]
		[MergableProperty(true)]
		public QRCodeEncoding QRCodeEncoding
		{
			get
			{
				return this.O.0o_0_o..QRCodeEncoding;
			}
			set
			{
				this.O.0o_0_o..QRCodeEncoding = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00005AC1 File Offset: 0x00003CC1
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00005ACE File Offset: 0x00003CCE
		[MergableProperty(true)]
		[DefaultValue(0)]
		[Category("条码设置 - QR Code")]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("编码版号")]
		public QRCodeVersion QRCodeVersion
		{
			get
			{
				return this.O.0o_0_o..QRCodeVersion;
			}
			set
			{
				this.O.0o_0_o..QRCodeVersion = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00005ADC File Offset: 0x00003CDC
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00005AE9 File Offset: 0x00003CE9
		[O_Oo00Oo000O0(4.0)]
		[DefaultValue(1)]
		[DisplayName("容错级别")]
		[Category("条码设置 - QR Code")]
		[MergableProperty(true)]
		public QRCodeErrorCorrectionLevel QRCodeErrorCorrectionLevel
		{
			get
			{
				return this.O.0o_0_o..QRCodeErrorCorrectionLevel;
			}
			set
			{
				this.O.0o_0_o..QRCodeErrorCorrectionLevel = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00005AF7 File Offset: 0x00003CF7
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00005B04 File Offset: 0x00003D04
		[DefaultValue("gb2312")]
		[MergableProperty(true)]
		[DisplayName("字符编码")]
		[TypeConverter(typeof(o___o_O__))]
		[O_Oo00Oo000O0(5.0)]
		[Category("条码设置 - QR Code")]
		public string QRCodeByteEncodingName
		{
			get
			{
				return this.O.0o_0_o..QRCodeByteEncodingName;
			}
			set
			{
				this.O.0o_0_o..QRCodeByteEncodingName = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00005B12 File Offset: 0x00003D12
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00005B1F File Offset: 0x00003D1F
		[Category("条码设置 - QR Code")]
		[O_Oo00Oo000O0(7.0)]
		[DefaultValue(1.0592)]
		[DisplayName("模组尺寸")]
		[MergableProperty(true)]
		public double QRCodeModuleSize
		{
			get
			{
				return this.O.0o_0_o..QRCodeModuleSize;
			}
			set
			{
				this.O.0o_0_o..QRCodeModuleSize = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00005B2D File Offset: 0x00003D2D
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00005B3A File Offset: 0x00003D3A
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("编码方式")]
		[DefaultValue(0)]
		[Category("条码设置 - Telepen")]
		public TelepenEncoding TelepenEncoding
		{
			get
			{
				return this.O.0o_0_o..TelepenEncoding;
			}
			set
			{
				this.O.0o_0_o..TelepenEncoding = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00005B48 File Offset: 0x00003D48
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00005B55 File Offset: 0x00003D55
		[Category("条码设置 - USPS FIM")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("编码方式")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		public FIM UspsFimPattern
		{
			get
			{
				return this.O.0o_0_o..UspsFimPattern;
			}
			set
			{
				this.O.0o_0_o..UspsFimPattern = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00005B63 File Offset: 0x00003D63
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00005B70 File Offset: 0x00003D70
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[DefaultValue(10)]
		[Category("条码设置 - USPS Horizontal Bars")]
		public int UspsHorizontalBarsCount
		{
			get
			{
				return this.O.0o_0_o..UspsHorizontalBarsCount;
			}
			set
			{
				this.O.0o_0_o..UspsHorizontalBarsCount = value;
			}
		}

		// Token: 0x0400005B RID: 91
		private BarcodeProfessional <<EMPTY_NAME>>;
	}
}
