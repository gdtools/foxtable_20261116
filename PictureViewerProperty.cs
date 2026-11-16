using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200041F RID: 1055
	[OoO0___o("Control")]
	internal class PictureViewerProperty : PropertyBase
	{
		// Token: 0x060046E4 RID: 18148 RVA: 0x001F318C File Offset: 0x001F138C
		public PictureViewerProperty(ControlHolder A_0) : base(A_0)
		{
			this.OooO.o. = true;
			this.oo_o.O. = true;
			this.Ooo_O.oO. = true;
			this.O.oOOO_00O0. = true;
			this.o0O__.oO0. = true;
			this.oo_o.O. = BooleanEnum.True;
			this.O0.0OOoo_00o_O. = BooleanEnum.False;
			this.OooO.o. = 21;
			this.Ooo0Oo_.ooO. = (PictureViewer)A_0.ChildControl;
			try
			{
				foreach (object obj in this.Ooo0Oo_.ooO..Controls)
				{
					((Control)obj).Enabled = false;
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x060046E5 RID: 18149 RVA: 0x001F323C File Offset: 0x001F143C
		// (set) Token: 0x060046E6 RID: 18150 RVA: 0x001F3244 File Offset: 0x001F1444
		[DisplayName("绑定到")]
		[O_Oo00Oo000O0(2.1)]
		[DefaultValue("")]
		[Category("基本")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(false)]
		public string BindingField
		{
			get
			{
				return this.o.o0oo_.;
			}
			set
			{
				this.o.o0oo_. = value;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x060046E7 RID: 18151 RVA: 0x001F324D File Offset: 0x001F144D
		// (set) Token: 0x060046E8 RID: 18152 RVA: 0x001F3255 File Offset: 0x001F1455
		[MergableProperty(true)]
		[DisplayName("只读")]
		[O_Oo00Oo000O0(2.3)]
		[Description("是否禁止用户修改。")]
		[Category("基本")]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.OooO.o.;
			}
			set
			{
				this.OooO.o. = value;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x060046E9 RID: 18153 RVA: 0x001F325E File Offset: 0x001F145E
		// (set) Token: 0x060046EA RID: 18154 RVA: 0x001F3266 File Offset: 0x001F1466
		[MergableProperty(true)]
		[Category("输出")]
		[DefaultValue(true)]
		[Description("打印窗口时是否打印此控件。")]
		[O_Oo00Oo000O0(10.0)]
		[DisplayName("允许打印")]
		public bool Printable
		{
			get
			{
				return this.Ooo_O.oO.;
			}
			set
			{
				this.Ooo_O.oO. = value;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x060046EB RID: 18155 RVA: 0x001F326F File Offset: 0x001F146F
		// (set) Token: 0x060046EC RID: 18156 RVA: 0x001F3277 File Offset: 0x001F1477
		[DisplayName("另起一页")]
		[DefaultValue(false)]
		[Category("输出")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(10.1)]
		[Description("打印时是否从此控件开始另起一页。")]
		public bool NewPage
		{
			get
			{
				return this.Ooo._0o0OOO_.;
			}
			set
			{
				this.Ooo._0o0OOO_. = value;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x060046ED RID: 18157 RVA: 0x001F3280 File Offset: 0x001F1480
		// (set) Token: 0x060046EE RID: 18158 RVA: 0x001F3290 File Offset: 0x001F1490
		[O_Oo00Oo000O0(0.1)]
		[DefaultValue(true)]
		[MergableProperty(true)]
		[DisplayName("自动缩放")]
		[Category("杂项")]
		public bool AutoSize
		{
			get
			{
				return this.Ooo0Oo_.ooO..SizeMode == PictureBoxSizeMode.Zoom;
			}
			set
			{
				if (value)
				{
					this.Ooo0Oo_.ooO..SizeMode = PictureBoxSizeMode.Zoom;
					return;
				}
				this.Ooo0Oo_.ooO..SizeMode = PictureBoxSizeMode.AutoSize;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x001F32AE File Offset: 0x001F14AE
		// (set) Token: 0x060046F0 RID: 18160 RVA: 0x001F32C0 File Offset: 0x001F14C0
		[MergableProperty(true)]
		[DisplayName("背景颜色")]
		[O_Oo00Oo000O0(0.2)]
		[Category("杂项")]
		public Color BackColor
		{
			get
			{
				return this.Ooo0Oo_.ooO..C1PictureBox1.BackColor;
			}
			set
			{
				this.Ooo0Oo_.ooO..C1PictureBox1.BackColor = value;
				this.Ooo0Oo_.ooO..Panel2.BackColor = value;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x060046F1 RID: 18161 RVA: 0x001F32E4 File Offset: 0x001F14E4
		// (set) Token: 0x060046F2 RID: 18162 RVA: 0x001F32EC File Offset: 0x001F14EC
		[MergableProperty(true)]
		[Category("杂项")]
		[DisplayName("可见")]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(2.0)]
		public bool Visible
		{
			get
			{
				return this.OooO.o.;
			}
			set
			{
				this.OooO.o. = value;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x060046F3 RID: 18163 RVA: 0x001F32F5 File Offset: 0x001F14F5
		// (set) Token: 0x060046F4 RID: 18164 RVA: 0x001F3302 File Offset: 0x001F1502
		[DisplayName("Tab键顺序")]
		[O_Oo00Oo000O0(3.0)]
		[Description("确定用户按Tab键时，该控件获得焦点的顺序。")]
		[Category("杂项")]
		[MergableProperty(false)]
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

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x001F3310 File Offset: 0x001F1510
		// (set) Token: 0x060046F6 RID: 18166 RVA: 0x001F3325 File Offset: 0x001F1525
		[DisplayName("显示命令")]
		[DefaultValue(true)]
		[Category("杂项")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.1)]
		[Description("是否显示操作命令")]
		public bool CommandVisible
		{
			get
			{
				return !this.Ooo0Oo_.ooO..SplitContainer.Panel2Collapsed;
			}
			set
			{
				this.Ooo0Oo_.ooO..SplitContainer.Panel2Collapsed = !value;
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x060046F7 RID: 18167 RVA: 0x001F333B File Offset: 0x001F153B
		// (set) Token: 0x060046F8 RID: 18168 RVA: 0x001F3343 File Offset: 0x001F1543
		[Category("杂项")]
		[O_Oo00Oo000O0(2.5)]
		[DisplayName("允许打开")]
		[DefaultValue(true)]
		[MergableProperty(true)]
		[Description("是否允许打开图片")]
		public bool OpenEnabled
		{
			get
			{
				return this.oo_o.O.;
			}
			set
			{
				this.oo_o.O. = value;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x060046F9 RID: 18169 RVA: 0x001F334C File Offset: 0x001F154C
		// (set) Token: 0x060046FA RID: 18170 RVA: 0x001F3354 File Offset: 0x001F1554
		[Editor(typeof(OOo__O), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(8.21)]
		[Description("指定文件或者图片列附件的存放目录名称。")]
		[DisplayName("存放目录")]
		[Category("设置")]
		public string FolderName
		{
			get
			{
				return this.O0Oo0._.;
			}
			set
			{
				this.O0Oo0._. = value;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x001F335D File Offset: 0x001F155D
		// (set) Token: 0x060046FC RID: 18172 RVA: 0x001F3365 File Offset: 0x001F1565
		[Editor(typeof(OOo__O), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(8.22)]
		[DisplayName("来源目录")]
		[Category("设置")]
		[Description("指定增加文件时，默认从什么目录选择文件。")]
		public string SourceFolder
		{
			get
			{
				return this.Ooo.0_o.;
			}
			set
			{
				this.Ooo.0_o. = value;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x001F336E File Offset: 0x001F156E
		// (set) Token: 0x060046FE RID: 18174 RVA: 0x001F3376 File Offset: 0x001F1576
		[DefaultValue(1)]
		[Description("在文件列或者图片列中，增加项目的时候，是否自动将该项目对应的文件复制到本地。")]
		[O_Oo00Oo000O0(8.3)]
		[Category("设置")]
		[DisplayName("自动复制附件")]
		public BooleanEnum AutoCopyAttachFile
		{
			get
			{
				return this.oo_o.O.;
			}
			set
			{
				this.oo_o.O. = value;
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x001F337F File Offset: 0x001F157F
		// (set) Token: 0x06004700 RID: 18176 RVA: 0x001F3387 File Offset: 0x001F1587
		[DefaultValue(2)]
		[DisplayName("自动删除附件")]
		[Description("在文件列或者图片列中，删除某项目的时候，是否自动删除该项目对应的文件，该属性仅对复制到本地的文件有效")]
		[O_Oo00Oo000O0(8.3)]
		[Category("设置")]
		public BooleanEnum AutoDeleteAttachFile
		{
			get
			{
				return this.O0.0OOoo_00o_O.;
			}
			set
			{
				this.O0.0OOoo_00o_O. = value;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06004701 RID: 18177 RVA: 0x001F3390 File Offset: 0x001F1590
		// (set) Token: 0x06004702 RID: 18178 RVA: 0x001F3398 File Offset: 0x001F1598
		[DisplayName("文件类型筛选")]
		[O_Oo00Oo000O0(8.4)]
		[Category("设置")]
		[Description("例如文本文件：Text files (*.txt)|*.txt|All files (*.*)|*.*\r\n筛选图片文件：Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*")]
		public string FileFilter
		{
			get
			{
				return this.o0O__.oO0.;
			}
			set
			{
				this.o0O__.oO0. = value;
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06004703 RID: 18179 RVA: 0x001F33A1 File Offset: 0x001F15A1
		// (set) Token: 0x06004704 RID: 18180 RVA: 0x001F33A9 File Offset: 0x001F15A9
		[DefaultValue(false)]
		[DisplayName("远程文件")]
		[O_Oo00Oo000O0(8.11)]
		[Category("设置")]
		public bool Remote
		{
			get
			{
				return this.OooO._.;
			}
			set
			{
				this.OooO._. = value;
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06004705 RID: 18181 RVA: 0x001F33B2 File Offset: 0x001F15B2
		// (set) Token: 0x06004706 RID: 18182 RVA: 0x001F33BA File Offset: 0x001F15BA
		[Category("设置")]
		[DisplayName("服务器地址")]
		[O_Oo00Oo000O0(8.12)]
		public string Host
		{
			get
			{
				return this.oo_o.O.;
			}
			set
			{
				this.oo_o.O. = value;
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06004707 RID: 18183 RVA: 0x001F33C3 File Offset: 0x001F15C3
		// (set) Token: 0x06004708 RID: 18184 RVA: 0x001F33CB File Offset: 0x001F15CB
		[O_Oo00Oo000O0(8.13)]
		[Category("设置")]
		[DisplayName("用户名")]
		public string Account
		{
			get
			{
				return this.O_O0.OO.;
			}
			set
			{
				this.O_O0.OO. = value;
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06004709 RID: 18185 RVA: 0x001F33D4 File Offset: 0x001F15D4
		// (set) Token: 0x0600470A RID: 18186 RVA: 0x001F33DC File Offset: 0x001F15DC
		[Category("设置")]
		[DisplayName("用户密码")]
		[O_Oo00Oo000O0(8.14)]
		public string Password
		{
			get
			{
				return this.ooO0_Oo.o_0.;
			}
			set
			{
				this.ooO0_Oo.o_0. = value;
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x0600470B RID: 18187 RVA: 0x001F33E5 File Offset: 0x001F15E5
		// (set) Token: 0x0600470C RID: 18188 RVA: 0x001F33ED File Offset: 0x001F15ED
		[Category("设置")]
		[DisplayName("UTF8编码")]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(8.141)]
		public bool UTF8
		{
			get
			{
				return this.OOoo.O.;
			}
			set
			{
				this.OOoo.O. = value;
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x0600470D RID: 18189 RVA: 0x001F33F6 File Offset: 0x001F15F6
		// (set) Token: 0x0600470E RID: 18190 RVA: 0x001F33FE File Offset: 0x001F15FE
		[DefaultValue(21)]
		[Category("设置")]
		[DisplayName("端口号")]
		[O_Oo00Oo000O0(8.142)]
		public int Port
		{
			get
			{
				return this.OooO.o.;
			}
			set
			{
				this.OooO.o. = value;
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x0600470F RID: 18191 RVA: 0x001F3407 File Offset: 0x001F1607
		// (set) Token: 0x06004710 RID: 18192 RVA: 0x001F340F File Offset: 0x001F160F
		[Category("设置")]
		[DisplayName("根目录")]
		[O_Oo00Oo000O0(8.15)]
		public string RootDir
		{
			get
			{
				return this.OooO._.;
			}
			set
			{
				this.OooO._. = value;
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06004711 RID: 18193 RVA: 0x001F3418 File Offset: 0x001F1618
		// (set) Token: 0x06004712 RID: 18194 RVA: 0x001F3420 File Offset: 0x001F1620
		[Description("是否自动下载远程图片。")]
		[O_Oo00Oo000O0(8.5)]
		[Category("设置")]
		[DisplayName("自动下载图片")]
		[DefaultValue(true)]
		public bool AutoDownload
		{
			get
			{
				return this.O.oOOO_00O0.;
			}
			set
			{
				this.O.oOOO_00O0. = value;
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06004713 RID: 18195 RVA: 0x001F3429 File Offset: 0x001F1629
		// (set) Token: 0x06004714 RID: 18196 RVA: 0x001F3431 File Offset: 0x001F1631
		[Description("是否自动更新远程文件")]
		[O_Oo00Oo000O0(8.6)]
		[Category("设置")]
		[DisplayName("自动更新文件")]
		[DefaultValue(true)]
		public bool AutoUpdate
		{
			get
			{
				return this.o0O__.oO0.;
			}
			set
			{
				this.o0O__.oO0. = value;
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06004715 RID: 18197 RVA: 0x001F343A File Offset: 0x001F163A
		// (set) Token: 0x06004716 RID: 18198 RVA: 0x001F3447 File Offset: 0x001F1647
		[Category("位置")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("左")]
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

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06004717 RID: 18199 RVA: 0x001F3455 File Offset: 0x001F1655
		// (set) Token: 0x06004718 RID: 18200 RVA: 0x001F3462 File Offset: 0x001F1662
		[Category("位置")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("上")]
		[MergableProperty(true)]
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

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06004719 RID: 18201 RVA: 0x001F3470 File Offset: 0x001F1670
		// (set) Token: 0x0600471A RID: 18202 RVA: 0x001F347D File Offset: 0x001F167D
		[Category("位置")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("宽")]
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

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x0600471B RID: 18203 RVA: 0x001F3498 File Offset: 0x001F1698
		// (set) Token: 0x0600471C RID: 18204 RVA: 0x001F34A5 File Offset: 0x001F16A5
		[Category("位置")]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("高")]
		[MergableProperty(true)]
		public int Height
		{
			get
			{
				return this.o_0_.Oo..Height;
			}
			set
			{
				if (!this.o_0_.Oo..IsFixedHeight)
				{
					this.o_0_.Oo..Height = value;
				}
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x0600471D RID: 18205 RVA: 0x001F34C0 File Offset: 0x001F16C0
		// (set) Token: 0x0600471E RID: 18206 RVA: 0x001F34CD File Offset: 0x001F16CD
		[Description("在调整容器大小时，使控件的指定边缘和容器边缘的距离保持不变。")]
		[Category("位置")]
		[MergableProperty(true)]
		[DisplayName("锚定")]
		[O_Oo00Oo000O0(5.0)]
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

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x0600471F RID: 18207 RVA: 0x001F34DB File Offset: 0x001F16DB
		// (set) Token: 0x06004720 RID: 18208 RVA: 0x001F34E8 File Offset: 0x001F16E8
		[O_Oo00Oo000O0(5.1)]
		[DisplayName("停靠")]
		[MergableProperty(true)]
		[Category("位置")]
		[Description("停靠到容器的指定边框。")]
		[DefaultValue(0)]
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

		// Token: 0x04001CA3 RID: 7331
		private PictureViewer <<EMPTY_NAME>>;

		// Token: 0x04001CA4 RID: 7332
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001CA5 RID: 7333
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CA6 RID: 7334
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CA7 RID: 7335
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CA8 RID: 7336
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CA9 RID: 7337
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CAA RID: 7338
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CAB RID: 7339
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CAC RID: 7340
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CAD RID: 7341
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CAE RID: 7342
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CAF RID: 7343
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CB0 RID: 7344
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CB1 RID: 7345
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CB2 RID: 7346
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CB3 RID: 7347
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CB4 RID: 7348
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CB5 RID: 7349
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001CB6 RID: 7350
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001CB7 RID: 7351
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CB8 RID: 7352
		private int <<EMPTY_NAME>>;
	}
}
