using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200041E RID: 1054
	internal class PictureBoxProperty : ControlPropertyBase
	{
		// Token: 0x060046C5 RID: 18117 RVA: 0x001F303A File Offset: 0x001F123A
		public PictureBoxProperty(ControlHolder A_0) : base(A_0)
		{
			this.o__o_0.0_. = true;
			this.OO0.___. = 21;
			this.OO0.___. = (CustomPictureBox)A_0.ChildControl;
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x060046C6 RID: 18118 RVA: 0x001F3063 File Offset: 0x001F1263
		// (set) Token: 0x060046C7 RID: 18119 RVA: 0x001F306B File Offset: 0x001F126B
		[DisplayName("图片")]
		[Category("基本")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		public string ImageFile
		{
			get
			{
				return this.OO0.___.;
			}
			set
			{
				this.OO0.___. = value;
				this.OO0.___..Image = OO_00oOO.GetImage(value);
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x001F3085 File Offset: 0x001F1285
		// (set) Token: 0x060046C9 RID: 18121 RVA: 0x001F308D File Offset: 0x001F128D
		[O_Oo00Oo000O0(5.0)]
		[Category("基本")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[DisplayName("绑定到")]
		[DefaultValue("")]
		[MergableProperty(true)]
		public string BindingField
		{
			get
			{
				return this.o_._O_oO0O.;
			}
			set
			{
				this.o_._O_oO0O. = value;
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x001F3096 File Offset: 0x001F1296
		// (set) Token: 0x060046CB RID: 18123 RVA: 0x001F30A3 File Offset: 0x001F12A3
		[DefaultValue(0)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("缩放")]
		[Category("基本")]
		public ImageSizeMode SizeMode
		{
			get
			{
				return this.OO0.___..SizeMode;
			}
			set
			{
				this.OO0.___..SizeMode = value;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x001F30B1 File Offset: 0x001F12B1
		// (set) Token: 0x060046CD RID: 18125 RVA: 0x001F30BE File Offset: 0x001F12BE
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("边框")]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.OO0.___..BorderStyle;
			}
			set
			{
				this.OO0.___..BorderStyle = value;
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x001F30CC File Offset: 0x001F12CC
		// (set) Token: 0x060046CF RID: 18127 RVA: 0x001F30D9 File Offset: 0x001F12D9
		[DefaultValue(true)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("滚动条")]
		[Category("外观")]
		[Description("对于超出范围的图片，是否显示滚动条来查看。")]
		public bool AutoScroll
		{
			get
			{
				return this.OO0.___..AutoScroll;
			}
			set
			{
				this.OO0.___..AutoScroll = value;
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x060046D0 RID: 18128 RVA: 0x001F30E7 File Offset: 0x001F12E7
		// (set) Token: 0x060046D1 RID: 18129 RVA: 0x001F30EF File Offset: 0x001F12EF
		[Category("设置")]
		[DisplayName("存放目录")]
		[Description("指定文件或者图片列附件的存放目录名称。")]
		[O_Oo00Oo000O0(8.21)]
		[Editor(typeof(OOo__O), typeof(UITypeEditor))]
		public string FolderName
		{
			get
			{
				return this.o_Oo.OO0_0_o0.;
			}
			set
			{
				this.o_Oo.OO0_0_o0. = value;
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x060046D2 RID: 18130 RVA: 0x001F30F8 File Offset: 0x001F12F8
		// (set) Token: 0x060046D3 RID: 18131 RVA: 0x001F3100 File Offset: 0x001F1300
		[DisplayName("远程文件")]
		[O_Oo00Oo000O0(8.11)]
		[DefaultValue(false)]
		[Category("设置")]
		public bool Remote
		{
			get
			{
				return this.OO0.___.;
			}
			set
			{
				this.OO0.___. = value;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x060046D4 RID: 18132 RVA: 0x001F3109 File Offset: 0x001F1309
		// (set) Token: 0x060046D5 RID: 18133 RVA: 0x001F3111 File Offset: 0x001F1311
		[O_Oo00Oo000O0(8.12)]
		[Category("设置")]
		[DisplayName("服务器地址")]
		public string Host
		{
			get
			{
				return this.O.O_OO0oO_O.;
			}
			set
			{
				this.O.O_OO0oO_O. = value;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x060046D6 RID: 18134 RVA: 0x001F311A File Offset: 0x001F131A
		// (set) Token: 0x060046D7 RID: 18135 RVA: 0x001F3122 File Offset: 0x001F1322
		[O_Oo00Oo000O0(8.13)]
		[DisplayName("用户名")]
		[Category("设置")]
		public string Account
		{
			get
			{
				return this.o_o0o_.o.;
			}
			set
			{
				this.o_o0o_.o. = value;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x060046D8 RID: 18136 RVA: 0x001F312B File Offset: 0x001F132B
		// (set) Token: 0x060046D9 RID: 18137 RVA: 0x001F3133 File Offset: 0x001F1333
		[Category("设置")]
		[DisplayName("用户密码")]
		[O_Oo00Oo000O0(8.14)]
		public string Password
		{
			get
			{
				return this.OoO.000o__O00.;
			}
			set
			{
				this.OoO.000o__O00. = value;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x001F313C File Offset: 0x001F133C
		// (set) Token: 0x060046DB RID: 18139 RVA: 0x001F3144 File Offset: 0x001F1344
		[DisplayName("UTF8编码")]
		[O_Oo00Oo000O0(8.141)]
		[Category("设置")]
		[DefaultValue(false)]
		public bool UTF8
		{
			get
			{
				return this.o_._O_oO0O.;
			}
			set
			{
				this.o_._O_oO0O. = value;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x060046DC RID: 18140 RVA: 0x001F314D File Offset: 0x001F134D
		// (set) Token: 0x060046DD RID: 18141 RVA: 0x001F3155 File Offset: 0x001F1355
		[O_Oo00Oo000O0(8.142)]
		[Category("设置")]
		[DefaultValue(21)]
		[DisplayName("端口号")]
		public int Port
		{
			get
			{
				return this.OO0.___.;
			}
			set
			{
				this.OO0.___. = value;
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x001F315E File Offset: 0x001F135E
		// (set) Token: 0x060046DF RID: 18143 RVA: 0x001F3166 File Offset: 0x001F1366
		[DefaultValue(true)]
		[Category("设置")]
		[DisplayName("自动更新文件")]
		[O_Oo00Oo000O0(8.6)]
		[Description("是否自动更新远程文件")]
		public bool AutoUpdate
		{
			get
			{
				return this.o__o_0.0_.;
			}
			set
			{
				this.o__o_0.0_. = value;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x060046E0 RID: 18144 RVA: 0x001F316F File Offset: 0x001F136F
		// (set) Token: 0x060046E1 RID: 18145 RVA: 0x001F3177 File Offset: 0x001F1377
		[oO0oooo("2514")]
		[O_Oo00Oo000O0(0.0)]
		[Description("显示图片文件之前执行")]
		[O0O0oOO00_0OO(true)]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString BeforeGetImage
		{
			get
			{
				return this.O00oO_00O._.;
			}
			set
			{
				this.O00oO_00O._. = value;
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x060046E2 RID: 18146 RVA: 0x001F3180 File Offset: 0x001F1380
		// (set) Token: 0x060046E3 RID: 18147 RVA: 0x001F3187 File Offset: 0x001F1387
		[Browsable(false)]
		public new string ToolTip
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		// Token: 0x04001C97 RID: 7319
		private CustomPictureBox <<EMPTY_NAME>>;

		// Token: 0x04001C98 RID: 7320
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C99 RID: 7321
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C9A RID: 7322
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C9B RID: 7323
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C9C RID: 7324
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C9D RID: 7325
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C9E RID: 7326
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C9F RID: 7327
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CA0 RID: 7328
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CA1 RID: 7329
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CA2 RID: 7330
		private int <<EMPTY_NAME>>;
	}
}
