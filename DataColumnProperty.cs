using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000334 RID: 820
	[TypeConverter(typeof(OoO0o0oo__Oo))]
	internal class DataColumnProperty
	{
		// Token: 0x06002DBE RID: 11710 RVA: 0x0014FFE0 File Offset: 0x0014E1E0
		public DataColumnProperty(DataCol A_0)
		{
			this.oO.OO. = A_0;
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002DBF RID: 11711 RVA: 0x0014FFF0 File Offset: 0x0014E1F0
		// (set) Token: 0x06002DC0 RID: 11712 RVA: 0x0015001B File Offset: 0x0014E21B
		[Browsable(false)]
		public string Caption
		{
			get
			{
				string caption;
				if (this.oO.OO. != null)
				{
					caption = this.oO.OO..Caption;
				}
				else
				{
					caption = this.o.0OoOo.;
				}
				return caption;
			}
			set
			{
				if (this.oO.OO. != null)
				{
					this.oO.OO..Caption = value;
					return;
				}
				this.o.0OoOo. = value;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x00150039 File Offset: 0x0014E239
		// (set) Token: 0x06002DC2 RID: 11714 RVA: 0x00150046 File Offset: 0x0014E246
		[DefaultValue(true)]
		[O_Oo00Oo000O0(0.0)]
		[Category("基本属性")]
		[DisplayName("允许编辑")]
		public bool AllowEdit
		{
			get
			{
				return this.oO.OO..AllowEdit;
			}
			set
			{
				this.oO.OO..AllowEdit = value;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x00150054 File Offset: 0x0014E254
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x00150061 File Offset: 0x0014E261
		[DefaultValue(false)]
		[O_Oo00Oo000O0(0.1)]
		[Category("基本属性")]
		[DisplayName("禁止重复")]
		public bool Unique
		{
			get
			{
				return this.oO.OO..Unique;
			}
			set
			{
				this.oO.OO..Unique = value;
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x0015006F File Offset: 0x0014E26F
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x0015007C File Offset: 0x0014E27C
		[Category("基本属性")]
		[O_Oo00Oo000O0(0.11)]
		[DisplayName("默认值")]
		public string DefaultValue
		{
			get
			{
				return this.oO.OO..DefaultValue;
			}
			set
			{
				this.oO.OO..DefaultValue = value;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x0015008A File Offset: 0x0014E28A
		// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x00150097 File Offset: 0x0014E297
		[Category("基本属性")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(0.2)]
		[Description("选择本列时，是否自动关闭或打开中文输入模式，等于模拟Shift健。")]
		[DisplayName("中文输入")]
		public BooleanEnum ImeMode
		{
			get
			{
				return this.oO.OO..ImeMode;
			}
			set
			{
				this.oO.OO..ImeMode = value;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x001500A5 File Offset: 0x0014E2A5
		// (set) Token: 0x06002DCA RID: 11722 RVA: 0x001500B2 File Offset: 0x0014E2B2
		[DisplayName("输入掩码")]
		[O_Oo00Oo000O0(2.0)]
		[Category("基本属性")]
		public string EditMask
		{
			get
			{
				return this.oO.OO..EditMask;
			}
			set
			{
				this.oO.OO..EditMask = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x001500C0 File Offset: 0x0014E2C0
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x001500CD File Offset: 0x0014E2CD
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("数据对齐")]
		[DefaultValue(0)]
		[Category("基本属性")]
		public TextAlignEnum TextAlign
		{
			get
			{
				return this.oO.OO..TextAlign;
			}
			set
			{
				this.oO.OO..TextAlign = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x001500DB File Offset: 0x0014E2DB
		// (set) Token: 0x06002DCE RID: 11726 RVA: 0x001500E8 File Offset: 0x0014E2E8
		[DisplayName("标题对齐")]
		[O_Oo00Oo000O0(5.0)]
		[DefaultValue(0)]
		[Category("基本属性")]
		public TextAlignEnum TextAlignFixed
		{
			get
			{
				return this.oO.OO..TextAlignFixed;
			}
			set
			{
				this.oO.OO..TextAlignFixed = value;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x001500F6 File Offset: 0x0014E2F6
		// (set) Token: 0x06002DD0 RID: 11728 RVA: 0x00150103 File Offset: 0x0014E303
		[Category("记录窗口")]
		[DisplayName("缩写标题")]
		[O_Oo00Oo000O0(6.0)]
		[Description("在记录窗口显示的缩写标题。")]
		public string ShortCaption
		{
			get
			{
				return this.oO.OO..ShortCaption;
			}
			set
			{
				this.oO.OO..ShortCaption = value;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x00150111 File Offset: 0x0014E311
		// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x0015011E File Offset: 0x0014E31E
		[Category("记录窗口")]
		[DisplayName("行高倍数")]
		[O_Oo00Oo000O0(6.1)]
		public int RecordRowHeight
		{
			get
			{
				return this.oO.OO..RecordRowHeight;
			}
			set
			{
				this.oO.OO..RecordRowHeight = Math.Max(1, Math.Min(value, 20));
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x00150139 File Offset: 0x0014E339
		// (set) Token: 0x06002DD4 RID: 11732 RVA: 0x00150146 File Offset: 0x0014E346
		[O_Oo00Oo000O0(7.0)]
		[Description("是否在记录窗口显示此列。")]
		[DefaultValue(0)]
		[Category("记录窗口")]
		[DisplayName("在记录窗口显示")]
		public BooleanEnum ShowInRecordGrid
		{
			get
			{
				return this.oO.OO..ShowInRecordGrid;
			}
			set
			{
				this.oO.OO..ShowInRecordGrid = value;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x00150154 File Offset: 0x0014E354
		// (set) Token: 0x06002DD6 RID: 11734 RVA: 0x00150161 File Offset: 0x0014E361
		[DisplayName("使用内置输入器")]
		[O_Oo00Oo000O0(9.0)]
		[DefaultValue(false)]
		[Description("对于日期列或者数值列，是否自动显示下拉日历或下拉计算器来输入数据。")]
		[Category("基本属性")]
		public bool UsetBuildInEditor
		{
			get
			{
				return this.oO.OO..UsetBuildInEditor;
			}
			set
			{
				this.oO.OO..UsetBuildInEditor = value;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x0015016F File Offset: 0x0014E36F
		// (set) Token: 0x06002DD8 RID: 11736 RVA: 0x0015017C File Offset: 0x0014E37C
		[DefaultValue(0)]
		[DisplayName("日期时间格式")]
		[Category("基本属性")]
		[O_Oo00Oo000O0(20.0)]
		public DateTimeFormatEnum DateTimeFormat
		{
			get
			{
				return this.oO.OO..DateTimeFormat;
			}
			set
			{
				this.oO.OO..DateTimeFormat = value;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x0015018A File Offset: 0x0014E38A
		// (set) Token: 0x06002DDA RID: 11738 RVA: 0x00150197 File Offset: 0x0014E397
		[O_Oo00Oo000O0(21.0)]
		[Category("基本属性")]
		[DisplayName("逻辑格式")]
		[Description("设置逻辑值的字符显示，例如：男;女")]
		public string BooleanFormat
		{
			get
			{
				return this.oO.OO..BooleanFormat;
			}
			set
			{
				this.oO.OO..BooleanFormat = value;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x001501A5 File Offset: 0x0014E3A5
		// (set) Token: 0x06002DDC RID: 11740 RVA: 0x001501B2 File Offset: 0x0014E3B2
		[DisplayName("扩展列类型")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(8.1)]
		[Category("扩展")]
		public ExtendColumnTypeEnum ExtendColumnType
		{
			get
			{
				return this.oO.OO..ExtendColumnType;
			}
			set
			{
				this.oO.OO..ExtendColumnType = value;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002DDD RID: 11741 RVA: 0x001501C0 File Offset: 0x0014E3C0
		// (set) Token: 0x06002DDE RID: 11742 RVA: 0x001501CD File Offset: 0x0014E3CD
		[Category("扩展")]
		[DisplayName("远程文件")]
		[O_Oo00Oo000O0(8.11)]
		[DefaultValue(false)]
		public bool Remote
		{
			get
			{
				return this.oO.OO..Remote;
			}
			set
			{
				this.oO.OO..Remote = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002DDF RID: 11743 RVA: 0x001501DB File Offset: 0x0014E3DB
		// (set) Token: 0x06002DE0 RID: 11744 RVA: 0x001501E8 File Offset: 0x0014E3E8
		[O_Oo00Oo000O0(8.12)]
		[Category("扩展")]
		[DisplayName("服务器地址")]
		public string Host
		{
			get
			{
				return this.oO.OO..Host;
			}
			set
			{
				this.oO.OO..Host = value;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002DE1 RID: 11745 RVA: 0x001501F6 File Offset: 0x0014E3F6
		// (set) Token: 0x06002DE2 RID: 11746 RVA: 0x00150203 File Offset: 0x0014E403
		[DisplayName("用户名")]
		[Category("扩展")]
		[O_Oo00Oo000O0(8.13)]
		public string Account
		{
			get
			{
				return this.oO.OO..Account;
			}
			set
			{
				this.oO.OO..Account = value;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002DE3 RID: 11747 RVA: 0x00150211 File Offset: 0x0014E411
		// (set) Token: 0x06002DE4 RID: 11748 RVA: 0x0015021E File Offset: 0x0014E41E
		[DisplayName("用户密码")]
		[O_Oo00Oo000O0(8.14)]
		[Category("扩展")]
		public string Password
		{
			get
			{
				return this.oO.OO..Password;
			}
			set
			{
				this.oO.OO..Password = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x0015022C File Offset: 0x0014E42C
		// (set) Token: 0x06002DE6 RID: 11750 RVA: 0x00150239 File Offset: 0x0014E439
		[DefaultValue(false)]
		[O_Oo00Oo000O0(8.141)]
		[DisplayName("UTF8编码")]
		[Category("扩展")]
		public bool UTF8
		{
			get
			{
				return this.oO.OO..UTF8;
			}
			set
			{
				this.oO.OO..UTF8 = value;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x00150247 File Offset: 0x0014E447
		// (set) Token: 0x06002DE8 RID: 11752 RVA: 0x00150254 File Offset: 0x0014E454
		[DisplayName("端口号")]
		[DefaultValue(21)]
		[Category("扩展")]
		[O_Oo00Oo000O0(8.142)]
		public int Port
		{
			get
			{
				return this.oO.OO..Port;
			}
			set
			{
				this.oO.OO..Port = value;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x00150262 File Offset: 0x0014E462
		// (set) Token: 0x06002DEA RID: 11754 RVA: 0x0015026F File Offset: 0x0014E46F
		[Category("扩展")]
		[O_Oo00Oo000O0(8.15)]
		[DisplayName("根目录")]
		public string RootDir
		{
			get
			{
				return this.oO.OO..RootDir;
			}
			set
			{
				this.oO.OO..RootDir = value;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x0015027D File Offset: 0x0014E47D
		// (set) Token: 0x06002DEC RID: 11756 RVA: 0x0015028A File Offset: 0x0014E48A
		[DisplayName("多值分隔符")]
		[DefaultValue(",")]
		[Category("扩展")]
		[O_Oo00Oo000O0(8.2)]
		public string Separator
		{
			get
			{
				return this.oO.OO..Separator;
			}
			set
			{
				if (value != null && value.Length == 1)
				{
					this.oO.OO..Separator = value;
				}
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x001502A4 File Offset: 0x0014E4A4
		// (set) Token: 0x06002DEE RID: 11758 RVA: 0x001502B1 File Offset: 0x0014E4B1
		[DisplayName("存放目录")]
		[O_Oo00Oo000O0(8.21)]
		[Description("指定文件或者图片列附件的存放目录名称。")]
		[Editor(typeof(OOo__O), typeof(UITypeEditor))]
		[Category("扩展")]
		public string FolderName
		{
			get
			{
				return this.oO.OO..DefaultFolder;
			}
			set
			{
				this.oO.OO..DefaultFolder = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x001502BF File Offset: 0x0014E4BF
		// (set) Token: 0x06002DF0 RID: 11760 RVA: 0x001502CC File Offset: 0x0014E4CC
		[O_Oo00Oo000O0(8.22)]
		[Description("指定增加文件时，默认从什么目录选择文件。")]
		[Editor(typeof(OOo__O), typeof(UITypeEditor))]
		[Category("扩展")]
		[DisplayName("来源目录")]
		public string SourceFolder
		{
			get
			{
				return this.oO.OO..SourceFolder;
			}
			set
			{
				this.oO.OO..SourceFolder = value;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x001502DA File Offset: 0x0014E4DA
		// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x001502E7 File Offset: 0x0014E4E7
		[Description("在文件列或者图片列中，增加项目的时候，是否自动将该项目对应的文件复制到本地。")]
		[O_Oo00Oo000O0(8.3)]
		[Category("扩展")]
		[DisplayName("自动复制附件")]
		[DefaultValue(1)]
		public BooleanEnum AutoCopyAttachFile
		{
			get
			{
				return this.oO.OO..AutoCopyAttachFile;
			}
			set
			{
				this.oO.OO..AutoCopyAttachFile = value;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x001502F5 File Offset: 0x0014E4F5
		// (set) Token: 0x06002DF4 RID: 11764 RVA: 0x00150302 File Offset: 0x0014E502
		[Description("在文件列或者图片列中，删除某项目的时候，是否自动删除该项目对应的文件，该属性仅对复制到本地的文件有效")]
		[O_Oo00Oo000O0(8.3)]
		[DisplayName("自动删除附件")]
		[DefaultValue(2)]
		[Category("扩展")]
		public BooleanEnum AutoDeleteAttachFile
		{
			get
			{
				return this.oO.OO..AutoDeleteAttachFile;
			}
			set
			{
				this.oO.OO..AutoDeleteAttachFile = value;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x00150310 File Offset: 0x0014E510
		// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x0015031D File Offset: 0x0014E51D
		[DisplayName("文件类型筛选")]
		[O_Oo00Oo000O0(8.4)]
		[Description("例如文本文件：Text files (*.txt)|*.txt|All files (*.*)|*.*\r\n筛选图片文件：Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*")]
		[Category("扩展")]
		public string FileFilter
		{
			get
			{
				return this.oO.OO..FileFilter;
			}
			set
			{
				this.oO.OO..FileFilter = value;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x0015032B File Offset: 0x0014E52B
		// (set) Token: 0x06002DF8 RID: 11768 RVA: 0x00150338 File Offset: 0x0014E538
		[O_Oo00Oo000O0(8.5)]
		[DisplayName("自动下载图片")]
		[Category("扩展")]
		[DefaultValue(true)]
		[Description("是否自动下载远程图片。")]
		public bool AutoDownload
		{
			get
			{
				return this.oO.OO..AutoDownload;
			}
			set
			{
				this.oO.OO..AutoDownload = value;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x00150346 File Offset: 0x0014E546
		// (set) Token: 0x06002DFA RID: 11770 RVA: 0x00150353 File Offset: 0x0014E553
		[O_Oo00Oo000O0(8.6)]
		[DisplayName("自动更新文件")]
		[Description("是否自动更新远程文件")]
		[DefaultValue(true)]
		[Category("扩展")]
		public bool AutoUpdate
		{
			get
			{
				return this.oO.OO..AutoUpdate;
			}
			set
			{
				this.oO.OO..AutoUpdate = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x00150361 File Offset: 0x0014E561
		// (set) Token: 0x06002DFC RID: 11772 RVA: 0x0015036E File Offset: 0x0014E56E
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(4)]
		[Description("表中允许显示的最大小数位数，此设置不会影响现有数据的值，而对于新输入的数据，将删除多余的小数部分。")]
		[Category("数值格式")]
		[DisplayName("最大小数位数")]
		public int Decimals
		{
			get
			{
				return this.oO.OO..Decimals;
			}
			set
			{
				this.oO.OO..Decimals = value;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x0015037C File Offset: 0x0014E57C
		// (set) Token: 0x06002DFE RID: 11774 RVA: 0x00150389 File Offset: 0x0014E589
		[Description("当数据的实际小数位数小于\"最大小数位数\"的设置值时，是否用0补充。")]
		[O_Oo00Oo000O0(1.1)]
		[DisplayName("固定小数位数")]
		[DefaultValue(false)]
		[Category("数值格式")]
		public bool FixedDecimals
		{
			get
			{
				return this.oO.OO..FixedDecimals;
			}
			set
			{
				this.oO.OO..FixedDecimals = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x00150397 File Offset: 0x0014E597
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x001503A4 File Offset: 0x0014E5A4
		[Category("数值格式")]
		[DisplayName("固定整数位数")]
		[DefaultValue(0)]
		[Description("设置在小数点左边固定显示的整数位数，例如此属性设为3，数值1将显示为\"001\"。默认值为0，表示不固定。")]
		[O_Oo00Oo000O0(1.2)]
		public int FixedDigits
		{
			get
			{
				return this.oO.OO..FixedDigits;
			}
			set
			{
				this.oO.OO..FixedDigits = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x001503B2 File Offset: 0x0014E5B2
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x001503BF File Offset: 0x0014E5BF
		[DefaultValue(false)]
		[Category("数值格式")]
		[DisplayName("显示千位分隔符")]
		[O_Oo00Oo000O0(2.0)]
		public bool ThousandSeparator
		{
			get
			{
				return this.oO.OO..ThousandSeparator;
			}
			set
			{
				this.oO.OO..ThousandSeparator = value;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x001503CD File Offset: 0x0014E5CD
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x001503DA File Offset: 0x0014E5DA
		[Category("数值格式")]
		[DisplayName("按百分比格式显示")]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(3.0)]
		public bool PercentStyle
		{
			get
			{
				return this.oO.OO..PercentStyle;
			}
			set
			{
				this.oO.OO..PercentStyle = value;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x001503E8 File Offset: 0x0014E5E8
		// (set) Token: 0x06002E06 RID: 11782 RVA: 0x001503F5 File Offset: 0x0014E5F5
		[DisplayName("显示货币符号")]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(4.0)]
		[Category("数值格式")]
		public bool ShowCurrencySymbol
		{
			get
			{
				return this.oO.OO..ShowCurrencySymbol;
			}
			set
			{
				this.oO.OO..ShowCurrencySymbol = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002E07 RID: 11783 RVA: 0x00150403 File Offset: 0x0014E603
		// (set) Token: 0x06002E08 RID: 11784 RVA: 0x00150410 File Offset: 0x0014E610
		[DisplayName("自定义货币符号")]
		[Description("货币符号默认为人民币符号，可利用此属性设置为其他货币符号。")]
		[Category("数值格式")]
		[O_Oo00Oo000O0(5.0)]
		public string CurrencySymbol
		{
			get
			{
				return this.oO.OO..CurrencySymbol;
			}
			set
			{
				this.oO.OO..CurrencySymbol = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x0015041E File Offset: 0x0014E61E
		// (set) Token: 0x06002E0A RID: 11786 RVA: 0x0015042B File Offset: 0x0014E62B
		[O_Oo00Oo000O0(15.0)]
		[Category("列窗口")]
		[DisplayName("停靠位置")]
		[DefaultValue(0)]
		public DockAreaEnum DockArea
		{
			get
			{
				return this.oO.OO..DockArea;
			}
			set
			{
				this.oO.OO..DockArea = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002E0B RID: 11787 RVA: 0x00150439 File Offset: 0x0014E639
		// (set) Token: 0x06002E0C RID: 11788 RVA: 0x00150446 File Offset: 0x0014E646
		[DisplayName("独立停靠")]
		[O_Oo00Oo000O0(16.0)]
		[Category("列窗口")]
		[DefaultValue(false)]
		public bool DockTitle
		{
			get
			{
				return this.oO.OO..DockTitle;
			}
			set
			{
				this.oO.OO..DockTitle = value;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x00150454 File Offset: 0x0014E654
		// (set) Token: 0x06002E0E RID: 11790 RVA: 0x00150461 File Offset: 0x0014E661
		[DefaultValue(true)]
		[O_Oo00Oo000O0(17.0)]
		[Description("打开项目的时候，是否自动打开此列窗口！")]
		[Category("列窗口")]
		[DisplayName("自动打开")]
		public bool AutoOpen
		{
			get
			{
				return this.oO.OO..AutoOpen;
			}
			set
			{
				this.oO.OO..AutoOpen = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x0015046F File Offset: 0x0014E66F
		// (set) Token: 0x06002E10 RID: 11792 RVA: 0x0015047C File Offset: 0x0014E67C
		[DisplayName("自动隐藏")]
		[O_Oo00Oo000O0(18.0)]
		[DefaultValue(false)]
		[Category("列窗口")]
		public bool AutoHide
		{
			get
			{
				return this.oO.OO..AutoHide;
			}
			set
			{
				this.oO.OO..AutoHide = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x0015048A File Offset: 0x0014E68A
		// (set) Token: 0x06002E12 RID: 11794 RVA: 0x00150497 File Offset: 0x0014E697
		[Category("列窗口")]
		[O_Oo00Oo000O0(19.0)]
		[DisplayName("显示标题")]
		[DefaultValue(true)]
		public bool ShowCaption
		{
			get
			{
				return this.oO.OO..ShowCaption;
			}
			set
			{
				this.oO.OO..ShowCaption = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x001504A5 File Offset: 0x0014E6A5
		// (set) Token: 0x06002E14 RID: 11796 RVA: 0x001504B2 File Offset: 0x0014E6B2
		[O_Oo00Oo000O0(20.0)]
		[DisplayName("允许关闭")]
		[Category("列窗口")]
		[DefaultValue(true)]
		public bool AllowClose
		{
			get
			{
				return this.oO.OO..AllowClose;
			}
			set
			{
				this.oO.OO..AllowClose = value;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x001504C0 File Offset: 0x0014E6C0
		// (set) Token: 0x06002E16 RID: 11798 RVA: 0x001504CD File Offset: 0x0014E6CD
		[Description("此属性需要重新打开窗口才会生效！")]
		[O_Oo00Oo000O0(21.0)]
		[Category("列窗口")]
		[DisplayName("自定义图标")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		public string DockImage
		{
			get
			{
				return this.oO.OO..CustomImage;
			}
			set
			{
				this.oO.OO..CustomImage = value;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x001504DB File Offset: 0x0014E6DB
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x001504E8 File Offset: 0x0014E6E8
		[DefaultValue(true)]
		[O_Oo00Oo000O0(6.0)]
		[Category("列表项目")]
		[MergableProperty(false)]
		[DisplayName("允许直接输入")]
		[Description("允许用户直接输入不在列表项目中的值")]
		public bool AllowEditValue
		{
			get
			{
				return this.oO.OO..AllowEditValue;
			}
			set
			{
				this.oO.OO..AllowEditValue = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x001504F6 File Offset: 0x0014E6F6
		// (set) Token: 0x06002E1A RID: 11802 RVA: 0x00150503 File Offset: 0x0014E703
		[Category("列表项目")]
		[O_Oo00Oo000O0(6.1)]
		[DisplayName("启用输入助手")]
		[Description("在手工输入的时候，是否提供相似项目协助用户完成输入。")]
		[DefaultValue(false)]
		[MergableProperty(false)]
		public bool AutoComplete
		{
			get
			{
				return this.oO.OO..AutoComplete;
			}
			set
			{
				this.oO.OO..AutoComplete = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x00150511 File Offset: 0x0014E711
		// (set) Token: 0x06002E1C RID: 11804 RVA: 0x0015051E File Offset: 0x0014E71E
		[Category("列表项目")]
		[Description("可将常见值设置在列表项目中，输入的时候会自动出现一个下拉列表框，供用户选择，不同的值之间用符号|隔开，例如：博士|硕士|本科")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("自定义项目")]
		[Editor(typeof(ooO0o0_oO0_0), typeof(UITypeEditor))]
		public string ComboList
		{
			get
			{
				return this.oO.OO..ComboList;
			}
			set
			{
				this.oO.OO..ComboList = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x0015052C File Offset: 0x0014E72C
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x00150539 File Offset: 0x0014E739
		[DisplayName("显示列")]
		[Category("列表项目")]
		[O_Oo00Oo000O0(3.0)]
		[MergableProperty(false)]
		[TypeConverter(typeof(oo0OOO_0__))]
		public string DisplayMember
		{
			get
			{
				return this.oO.OO..DisplayMember;
			}
			set
			{
				this.oO.OO..DisplayMember = value;
				if (Operators.CompareString(this.oO.OO..ValueMember, "", true) == 0)
				{
					this.oO.OO..ValueMember = value;
				}
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x0015056B File Offset: 0x0014E76B
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x00150578 File Offset: 0x0014E778
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("取值列")]
		[MergableProperty(false)]
		[Category("列表项目")]
		[TypeConverter(typeof(oo0OOO_0__))]
		public string ValueMember
		{
			get
			{
				return this.oO.OO..ValueMember;
			}
			set
			{
				this.oO.OO..ValueMember = value;
				if (Operators.CompareString(this.oO.OO..DisplayMember, "", true) == 0)
				{
					this.oO.OO..DisplayMember = value;
				}
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x001505AA File Offset: 0x0014E7AA
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x001505B7 File Offset: 0x0014E7B7
		[Editor(typeof(O0_000oo), typeof(UITypeEditor))]
		[Ooo0___("目录树文件(*.foxtr)|*.foxtr")]
		[Category("目录树列表")]
		[DisplayName("目录树文件")]
		[O_Oo00Oo000O0(1.0)]
		public string TreeFile
		{
			get
			{
				return this.oO.OO..TreeFile;
			}
			set
			{
				this.oO.OO..TreeFile = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x001505C5 File Offset: 0x0014E7C5
		// (set) Token: 0x06002E24 RID: 11812 RVA: 0x001505D2 File Offset: 0x0014E7D2
		[Category("目录树列表")]
		[TypeConverter(typeof(OoO_O0_OO0))]
		[O_Oo00Oo000O0(2.0)]
		[Description("根据此表数据生成目录树")]
		[DisplayName("目录树表")]
		public string TreeDataTable
		{
			get
			{
				return this.oO.OO..TreeSourceTable;
			}
			set
			{
				this.oO.OO..TreeSourceTable = value;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x001505E0 File Offset: 0x0014E7E0
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x001505ED File Offset: 0x0014E7ED
		[O_Oo00Oo000O0(3.0)]
		[Description("指定用于生成目录树的列，不同的列用符号\"|\"隔开，例如: 产品|客户")]
		[Editor(typeof(O00_), typeof(UITypeEditor))]
		[Category("目录树列表")]
		[DisplayName("目录树列")]
		public string TreeBuildCols
		{
			get
			{
				return this.oO.OO..TreeBuildCols;
			}
			set
			{
				this.oO.OO..TreeBuildCols = value;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x001505FB File Offset: 0x0014E7FB
		// (set) Token: 0x06002E28 RID: 11816 RVA: 0x00150608 File Offset: 0x0014E808
		[O_Oo00Oo000O0(4.0)]
		[Editor(typeof(O00_), typeof(UITypeEditor))]
		[Category("目录树列表")]
		[DisplayName("数据来源列")]
		[Description("指定用于提交数据的列，不同的列用符号\"|\"隔开，例如: 产品|客户")]
		public string TreeSourceCols
		{
			get
			{
				return this.oO.OO..TreeSourceCols;
			}
			set
			{
				this.oO.OO..TreeSourceCols = value;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x00150616 File Offset: 0x0014E816
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x00150623 File Offset: 0x0014E823
		[O_Oo00Oo000O0(5.0)]
		[Category("目录树列表")]
		[DisplayName("数据接收列")]
		[Description("指定用于接收数据的列，不同的列用符号\"|\"隔开，例如: 产品|客户")]
		[Editor(typeof(O00_), typeof(UITypeEditor))]
		public string TreeReceiveCols
		{
			get
			{
				return this.oO.OO..TreeReceiveCols;
			}
			set
			{
				this.oO.OO..TreeReceiveCols = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x00150631 File Offset: 0x0014E831
		// (set) Token: 0x06002E2C RID: 11820 RVA: 0x0015063E File Offset: 0x0014E83E
		[Category("目录树列表")]
		[O_Oo00Oo000O0(5.1)]
		[DisplayName("过滤条件")]
		public string TreeFilter
		{
			get
			{
				return this.oO.OO..TreeFilter;
			}
			set
			{
				this.oO.OO..TreeFilter = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x0015064C File Offset: 0x0014E84C
		// (set) Token: 0x06002E2E RID: 11822 RVA: 0x00150659 File Offset: 0x0014E859
		[Category("目录树列表")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("目录树宽度")]
		[OooO0(true)]
		public int TreeWidth
		{
			get
			{
				return this.oO.OO..DropDownWidth;
			}
			set
			{
				this.oO.OO..DropDownWidth = value;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x00150667 File Offset: 0x0014E867
		// (set) Token: 0x06002E30 RID: 11824 RVA: 0x00150674 File Offset: 0x0014E874
		[DisplayName("目录树高度")]
		[OooO0(true)]
		[Category("目录树列表")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(7.0)]
		public int TreeHeight
		{
			get
			{
				return this.oO.OO..DropDownHeight;
			}
			set
			{
				this.oO.OO..DropDownHeight = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x00150682 File Offset: 0x0014E882
		// (set) Token: 0x06002E32 RID: 11826 RVA: 0x0015068F File Offset: 0x0014E88F
		[DisplayName("路径分割符")]
		[Category("目录树列表")]
		[O_Oo00Oo000O0(8.0)]
		[DefaultValue('\\')]
		public char TreePathSeparator
		{
			get
			{
				return this.oO.OO..TreePathSeparator;
			}
			set
			{
				this.oO.OO..TreePathSeparator = value;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x0015069D File Offset: 0x0014E89D
		// (set) Token: 0x06002E34 RID: 11828 RVA: 0x001506AA File Offset: 0x0014E8AA
		[Category("目录树列表")]
		[DisplayName("分割内容")]
		[O_Oo00Oo000O0(9.0)]
		[DefaultValue(false)]
		public bool TreeSeparateContent
		{
			get
			{
				return this.oO.OO..TreeSeparateContent;
			}
			set
			{
				this.oO.OO..TreeSeparateContent = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x001506B8 File Offset: 0x0014E8B8
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x001506C5 File Offset: 0x0014E8C5
		[DisplayName("内容分割符")]
		[DefaultValue('|')]
		[Category("目录树列表")]
		[O_Oo00Oo000O0(10.0)]
		public char TreeContentSeparator
		{
			get
			{
				return this.oO.OO..TreeContentSeparator;
			}
			set
			{
				this.oO.OO..TreeContentSeparator = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x001506D3 File Offset: 0x0014E8D3
		// (set) Token: 0x06002E38 RID: 11832 RVA: 0x001506E0 File Offset: 0x0014E8E0
		[Category("列表项目")]
		[O_Oo00Oo000O0(2.0)]
		[Description("候选项目来源表")]
		[TypeConverter(typeof(OoO_O0_OO0))]
		[DisplayName("数据表")]
		[MergableProperty(false)]
		public string DataSource
		{
			get
			{
				return this.oO.OO..DataSource;
			}
			set
			{
				this.oO.OO..DataSource = value;
				if (Operators.CompareString(value, "", true) == 0)
				{
					this.ValueMember = "";
					this.DisplayMember = "";
					return;
				}
				DataSet dataSet = this.oO.OO..BaseColumn.Table.DataSet;
				if (dataSet != null && dataSet.Tables.Contains(value))
				{
					if (Operators.CompareString(this.DisplayMember, "", true) > 0 && !dataSet.Tables[value].Columns.Contains(this.DisplayMember))
					{
						this.DisplayMember = "";
					}
					if (Operators.CompareString(this.ValueMember, "", true) > 0 && !dataSet.Tables[value].Columns.Contains(this.ValueMember))
					{
						this.ValueMember = "";
					}
				}
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x001507C2 File Offset: 0x0014E9C2
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x001507CF File Offset: 0x0014E9CF
		[Category("列表项目")]
		[MergableProperty(false)]
		[Description("下拉列表来自于数据表时，可用此属性设置过滤条件！")]
		[Editor(typeof(O0O00), typeof(UITypeEditor))]
		[DisplayName("过滤条件")]
		[O_Oo00Oo000O0(5.0)]
		public string DataFilter
		{
			get
			{
				return this.oO.OO..DataFilter;
			}
			set
			{
				this.oO.OO..DataFilter = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x001507DD File Offset: 0x0014E9DD
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x001507EA File Offset: 0x0014E9EA
		[Category("列表项目")]
		[Description("用于设置下拉列表行的排序方式！")]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(5.1)]
		[DisplayName("排序方式")]
		[TypeConverter(typeof(oo0OOO_0__))]
		public string DataSort
		{
			get
			{
				return this.oO.OO..DataSort;
			}
			set
			{
				this.oO.OO..DataSort = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x001507F8 File Offset: 0x0014E9F8
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x00150805 File Offset: 0x0014EA05
		[DisplayName("多列显示")]
		[Description("是否分多列显示项目。")]
		[Category("列表项目")]
		[DefaultValue(false)]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(7.0)]
		public bool MultiColumn
		{
			get
			{
				return this.oO.OO..MultiColumn;
			}
			set
			{
				this.oO.OO..MultiColumn = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x00150813 File Offset: 0x0014EA13
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x00150820 File Offset: 0x0014EA20
		[MergableProperty(false)]
		[O_Oo00Oo000O0(8.0)]
		[DefaultValue(0)]
		[DisplayName("每列宽度")]
		[Description("设置多列显示时，各列的宽度。")]
		[Category("列表项目")]
		public int ColumnWidth
		{
			get
			{
				return this.oO.OO..ColumnWidth;
			}
			set
			{
				this.oO.OO..ColumnWidth = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x0015082E File Offset: 0x0014EA2E
		// (set) Token: 0x06002E42 RID: 11842 RVA: 0x0015083B File Offset: 0x0014EA3B
		[DisplayName("下拉宽度")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(10.0)]
		[Category("列表项目")]
		[Description("指定下拉列表的宽度，设为0使用默认宽度")]
		[MergableProperty(false)]
		public int DropDownWidth
		{
			get
			{
				return this.oO.OO..DropDownWidth;
			}
			set
			{
				if (value != 0)
				{
					value = Math.Max(60, value);
				}
				this.oO.OO..DropDownWidth = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x00150856 File Offset: 0x0014EA56
		// (set) Token: 0x06002E44 RID: 11844 RVA: 0x00150863 File Offset: 0x0014EA63
		[DisplayName("下拉高度")]
		[Description("指定下拉列表的高度，设为0使用默认高度")]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(11.0)]
		[Category("列表项目")]
		[DefaultValue(0)]
		public int DropDownHeight
		{
			get
			{
				return this.oO.OO..DropDownHeight;
			}
			set
			{
				if (value != 0)
				{
					value = Math.Max(28, value);
				}
				this.oO.OO..DropDownHeight = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x0015087E File Offset: 0x0014EA7E
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x0015088B File Offset: 0x0014EA8B
		[Description("每次最多显示的下拉项目数，超出范围的项目需要滚动才能显示")]
		[DefaultValue(11)]
		[O_Oo00Oo000O0(12.0)]
		[DisplayName("最多显示项目数")]
		[Category("列表项目")]
		[MergableProperty(false)]
		public int MaxDropDownItems
		{
			get
			{
				return this.oO.OO..MaxDropDownItems;
			}
			set
			{
				value = Math.Max(1, value);
				this.oO.OO..MaxDropDownItems = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x001508A2 File Offset: 0x0014EAA2
		// (set) Token: 0x06002E48 RID: 11848 RVA: 0x001508AF File Offset: 0x0014EAAF
		[DisplayName("项目间距")]
		[Description("列表项目间距，单位为像素")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(13.0)]
		[Category("列表项目")]
		[DefaultValue(6)]
		public int ItemSpacing
		{
			get
			{
				return this.oO.OO..ItemSpacing;
			}
			set
			{
				this.oO.OO..ItemSpacing = value;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x001508BD File Offset: 0x0014EABD
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x001508CA File Offset: 0x0014EACA
		[Category("字典")]
		[Description("通过数据字典，可将数据显示为描述性的文本。")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(7.0)]
		[DisplayName("数据字典")]
		public DataMapTypeEnum DataMapType
		{
			get
			{
				return this.oO.OO..DataMapType;
			}
			set
			{
				this.oO.OO..DataMapType = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x001508D8 File Offset: 0x0014EAD8
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x001508E5 File Offset: 0x0014EAE5
		[DefaultValue(0)]
		[Category("字典")]
		[Description("通过图片字典，可将数据显示为图形")]
		[O_Oo00Oo000O0(8.0)]
		[DisplayName("图形字典")]
		public ImageMapTypeEnum ImageMapType
		{
			get
			{
				return this.oO.OO..ImageMapType;
			}
			set
			{
				this.oO.OO..ImageMapType = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x001508F3 File Offset: 0x0014EAF3
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x00150900 File Offset: 0x0014EB00
		[O_Oo00Oo000O0(9.0)]
		[DisplayName("文本和图形")]
		[DefaultValue(true)]
		[Category("字典")]
		[Description("如果设置了图形字典，在单元格中是同时显示文字和图形，还是仅仅显示图形。")]
		public bool ImageAndText
		{
			get
			{
				return this.oO.OO..ImageAndText;
			}
			set
			{
				this.oO.OO..ImageAndText = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x0015090E File Offset: 0x0014EB0E
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x0015091B File Offset: 0x0014EB1B
		[DefaultValue("")]
		[Browsable(false)]
		public string DataMap
		{
			get
			{
				return this.oO.OO..DataMap;
			}
			set
			{
				this.oO.OO..DataMap = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x00150929 File Offset: 0x0014EB29
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x00150936 File Offset: 0x0014EB36
		[DefaultValue("")]
		[Browsable(false)]
		public string ImageMap
		{
			get
			{
				return this.oO.OO..ImageMap;
			}
			set
			{
				this.oO.OO..ImageMap = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x00150944 File Offset: 0x0014EB44
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x00150951 File Offset: 0x0014EB51
		[Browsable(false)]
		[DefaultValue("")]
		public string DataMapTable
		{
			get
			{
				return this.oO.OO..DataMapTable;
			}
			set
			{
				this.oO.OO..DataMapTable = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x0015095F File Offset: 0x0014EB5F
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x0015096C File Offset: 0x0014EB6C
		[Browsable(false)]
		[DefaultValue("")]
		public string DataMapListColumns
		{
			get
			{
				return this.oO.OO..DataMapListColumns;
			}
			set
			{
				this.oO.OO..DataMapListColumns = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x0015097A File Offset: 0x0014EB7A
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x00150987 File Offset: 0x0014EB87
		[DefaultValue("")]
		[Browsable(false)]
		public string DataMapValueColumn
		{
			get
			{
				return this.oO.OO..DataMapValueColumn;
			}
			set
			{
				this.oO.OO..DataMapValueColumn = value;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x00150995 File Offset: 0x0014EB95
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x001509A2 File Offset: 0x0014EBA2
		[Browsable(false)]
		[DefaultValue("")]
		public string DataMapListColumn
		{
			get
			{
				return this.oO.OO..DataMapListColumn;
			}
			set
			{
				this.oO.OO..DataMapListColumn = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x001509B0 File Offset: 0x0014EBB0
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x001509BD File Offset: 0x0014EBBD
		[Browsable(false)]
		[DefaultValue("")]
		public string DataMapFilter
		{
			get
			{
				return this.oO.OO..DataMapFilter;
			}
			set
			{
				this.oO.OO..DataMapFilter = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x001509CB File Offset: 0x0014EBCB
		// (set) Token: 0x06002E5E RID: 11870 RVA: 0x001509D8 File Offset: 0x0014EBD8
		[Browsable(false)]
		[DefaultValue("")]
		public string DataMapSort
		{
			get
			{
				return this.oO.OO..DataMapSort;
			}
			set
			{
				this.oO.OO..DataMapSort = value;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x001509E6 File Offset: 0x0014EBE6
		// (set) Token: 0x06002E60 RID: 11872 RVA: 0x001509F3 File Offset: 0x0014EBF3
		[DefaultValue("")]
		[Browsable(false)]
		public string MultiDataMap
		{
			get
			{
				return this.oO.OO..MultiDataMap;
			}
			set
			{
				this.oO.OO..MultiDataMap = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x00150A01 File Offset: 0x0014EC01
		// (set) Token: 0x06002E62 RID: 11874 RVA: 0x00150A0E File Offset: 0x0014EC0E
		[DefaultValue(false)]
		[Browsable(false)]
		public bool MultiDataMapAutoKeys
		{
			get
			{
				return this.oO.OO..MultiDataMapAutoKeys;
			}
			set
			{
				this.oO.OO..MultiDataMapAutoKeys = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x00150A1C File Offset: 0x0014EC1C
		// (set) Token: 0x06002E64 RID: 11876 RVA: 0x00150A29 File Offset: 0x0014EC29
		[Browsable(false)]
		[DefaultValue(0)]
		public int MultiDataMapDisplayCol
		{
			get
			{
				return this.oO.OO..MultiDataMapDisplayCol;
			}
			set
			{
				this.oO.OO..MultiDataMapDisplayCol = value;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x00150A37 File Offset: 0x0014EC37
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x00150A44 File Offset: 0x0014EC44
		[Browsable(false)]
		[DefaultValue(0)]
		public int MultiDataMapValueCol
		{
			get
			{
				return this.oO.OO..MultiDataMapValueCol;
			}
			set
			{
				this.oO.OO..MultiDataMapValueCol = value;
			}
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00150A54 File Offset: 0x0014EC54
		internal void Apply()
		{
			this.oO.OO..oO0._00o_0. = null;
			this.oO.OO..o_.Oo00_O_00_.();
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable == this.oO.OO..DataTable)
					{
						try
						{
							foreach (Col col in table.Cols)
							{
								if (col.DataCol == this.oO.OO.)
								{
									col.o0.O.();
								}
							}
						}
						finally
						{
							IEnumerator<Col> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x04001285 RID: 4741
		internal DataCol <<EMPTY_NAME>>;

		// Token: 0x04001286 RID: 4742
		private string <<EMPTY_NAME>>;
	}
}
