using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000414 RID: 1044
	[OoO0___o("Control")]
	internal class FileManagerProperty : PropertyBase
	{
		// Token: 0x0600456E RID: 17774 RVA: 0x001F1AA4 File Offset: 0x001EFCA4
		public FileManagerProperty(ControlHolder A_0) : base(A_0)
		{
			this.O___o.o. = true;
			this.o_o0.0o. = true;
			this.oO_.0o. = true;
			this.o_o0.0o. = BooleanEnum.True;
			this.oO_.0o. = BooleanEnum.False;
			this.O___o.o. = 21;
			this.O___o.o. = (FileManager)A_0.ChildControl;
			try
			{
				foreach (object obj in this.O___o.o..Controls)
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

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x0600456F RID: 17775 RVA: 0x001F1B48 File Offset: 0x001EFD48
		// (set) Token: 0x06004570 RID: 17776 RVA: 0x001F1B50 File Offset: 0x001EFD50
		[Category("基本")]
		[O_Oo00Oo000O0(2.1)]
		[DisplayName("绑定到")]
		[DefaultValue("")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(false)]
		public string BindingField
		{
			get
			{
				return this.O.0OoOOOoO0o.;
			}
			set
			{
				this.O.0OoOOOoO0o. = value;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06004571 RID: 17777 RVA: 0x001F1B59 File Offset: 0x001EFD59
		// (set) Token: 0x06004572 RID: 17778 RVA: 0x001F1B61 File Offset: 0x001EFD61
		[Category("基本")]
		[Description("是否禁止用户修改。")]
		[O_Oo00Oo000O0(2.3)]
		[MergableProperty(true)]
		[DisplayName("只读")]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.O___o.o.;
			}
			set
			{
				this.O___o.o. = value;
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06004573 RID: 17779 RVA: 0x001F1B6A File Offset: 0x001EFD6A
		// (set) Token: 0x06004574 RID: 17780 RVA: 0x001F1B72 File Offset: 0x001EFD72
		[Category("杂项")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(true)]
		[DisplayName("可见")]
		public bool Visible
		{
			get
			{
				return this.O___o.o.;
			}
			set
			{
				this.O___o.o. = value;
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06004575 RID: 17781 RVA: 0x001F1B7B File Offset: 0x001EFD7B
		// (set) Token: 0x06004576 RID: 17782 RVA: 0x001F1B90 File Offset: 0x001EFD90
		[MergableProperty(true)]
		[Description("是否显示操作命令")]
		[DisplayName("显示命令")]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(2.1)]
		[Category("杂项")]
		public bool CommandVisible
		{
			get
			{
				return !this.O___o.o..SplitContainer1.Panel2Collapsed;
			}
			set
			{
				this.O___o.o..SplitContainer1.Panel2Collapsed = !value;
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06004577 RID: 17783 RVA: 0x001F1BA6 File Offset: 0x001EFDA6
		// (set) Token: 0x06004578 RID: 17784 RVA: 0x001F1BAE File Offset: 0x001EFDAE
		[MergableProperty(true)]
		[DisplayName("允许打开")]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(2.5)]
		[Description("是否允许打开文件")]
		[Category("杂项")]
		public bool OpenEnabled
		{
			get
			{
				return this.o_o0.0o.;
			}
			set
			{
				this.o_o0.0o. = value;
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x001F1BB7 File Offset: 0x001EFDB7
		// (set) Token: 0x0600457A RID: 17786 RVA: 0x001F1BBF File Offset: 0x001EFDBF
		[DisplayName("存放目录")]
		[Description("指定文件或者图片列附件的存放目录名称。")]
		[O_Oo00Oo000O0(8.21)]
		[Editor(typeof(OOo__O), typeof(UITypeEditor))]
		[Category("设置")]
		public string FolderName
		{
			get
			{
				return this.Oo0.O0oo00O0o.;
			}
			set
			{
				this.Oo0.O0oo00O0o. = value;
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x001F1BC8 File Offset: 0x001EFDC8
		// (set) Token: 0x0600457C RID: 17788 RVA: 0x001F1BD0 File Offset: 0x001EFDD0
		[O_Oo00Oo000O0(8.22)]
		[DisplayName("来源目录")]
		[Description("指定增加文件时，默认从什么目录选择文件。")]
		[Editor(typeof(OOo__O), typeof(UITypeEditor))]
		[Category("设置")]
		public string SourceFolder
		{
			get
			{
				return this.O___o0o.O.;
			}
			set
			{
				this.O___o0o.O. = value;
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x0600457D RID: 17789 RVA: 0x001F1BD9 File Offset: 0x001EFDD9
		// (set) Token: 0x0600457E RID: 17790 RVA: 0x001F1BE1 File Offset: 0x001EFDE1
		[Description("在文件列或者图片列中，增加项目的时候，是否自动将该项目对应的文件复制到本地。")]
		[O_Oo00Oo000O0(8.3)]
		[Category("设置")]
		[DisplayName("自动复制附件")]
		[DefaultValue(1)]
		public BooleanEnum AutoCopyAttachFile
		{
			get
			{
				return this.o_o0.0o.;
			}
			set
			{
				this.o_o0.0o. = value;
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x001F1BEA File Offset: 0x001EFDEA
		// (set) Token: 0x06004580 RID: 17792 RVA: 0x001F1BF2 File Offset: 0x001EFDF2
		[Description("在文件列或者图片列中，删除某项目的时候，是否自动删除该项目对应的文件，该属性仅对复制到本地的文件有效")]
		[O_Oo00Oo000O0(8.3)]
		[DisplayName("自动删除附件")]
		[DefaultValue(2)]
		[Category("设置")]
		public BooleanEnum AutoDeleteAttachFile
		{
			get
			{
				return this.oO_.0o.;
			}
			set
			{
				this.oO_.0o. = value;
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06004581 RID: 17793 RVA: 0x001F1BFB File Offset: 0x001EFDFB
		// (set) Token: 0x06004582 RID: 17794 RVA: 0x001F1C03 File Offset: 0x001EFE03
		[Description("例如文本文件：Text files (*.txt)|*.txt|All files (*.*)|*.*\r\n筛选图片文件：Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*")]
		[Category("设置")]
		[DisplayName("文件类型筛选")]
		[O_Oo00Oo000O0(8.4)]
		public string FileFilter
		{
			get
			{
				return this.oO_.0oOOo.;
			}
			set
			{
				this.oO_.0oOOo. = value;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06004583 RID: 17795 RVA: 0x001F1C0C File Offset: 0x001EFE0C
		// (set) Token: 0x06004584 RID: 17796 RVA: 0x001F1C14 File Offset: 0x001EFE14
		[DefaultValue(false)]
		[O_Oo00Oo000O0(8.11)]
		[Category("设置")]
		[DisplayName("远程文件")]
		public bool Remote
		{
			get
			{
				return this.OO._0Oo_OOOo0.;
			}
			set
			{
				this.OO._0Oo_OOOo0. = value;
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06004585 RID: 17797 RVA: 0x001F1C1D File Offset: 0x001EFE1D
		// (set) Token: 0x06004586 RID: 17798 RVA: 0x001F1C25 File Offset: 0x001EFE25
		[O_Oo00Oo000O0(8.12)]
		[Category("设置")]
		[DisplayName("服务器地址")]
		public string Host
		{
			get
			{
				return this.o_o0.0o.;
			}
			set
			{
				this.o_o0.0o. = value;
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06004587 RID: 17799 RVA: 0x001F1C2E File Offset: 0x001EFE2E
		// (set) Token: 0x06004588 RID: 17800 RVA: 0x001F1C36 File Offset: 0x001EFE36
		[O_Oo00Oo000O0(8.13)]
		[DisplayName("用户名")]
		[Category("设置")]
		public string Account
		{
			get
			{
				return this.oO_.0o.;
			}
			set
			{
				this.oO_.0o. = value;
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06004589 RID: 17801 RVA: 0x001F1C3F File Offset: 0x001EFE3F
		// (set) Token: 0x0600458A RID: 17802 RVA: 0x001F1C47 File Offset: 0x001EFE47
		[O_Oo00Oo000O0(8.14)]
		[DisplayName("用户密码")]
		[Category("设置")]
		public string Password
		{
			get
			{
				return this.OoO0._oo_O.;
			}
			set
			{
				this.OoO0._oo_O. = value;
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x0600458B RID: 17803 RVA: 0x001F1C50 File Offset: 0x001EFE50
		// (set) Token: 0x0600458C RID: 17804 RVA: 0x001F1C58 File Offset: 0x001EFE58
		[O_Oo00Oo000O0(8.141)]
		[Category("设置")]
		[DisplayName("UTF8编码")]
		[DefaultValue(false)]
		public bool UTF8
		{
			get
			{
				return this.oo.OO0O_.;
			}
			set
			{
				this.oo.OO0O_. = value;
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x0600458D RID: 17805 RVA: 0x001F1C61 File Offset: 0x001EFE61
		// (set) Token: 0x0600458E RID: 17806 RVA: 0x001F1C69 File Offset: 0x001EFE69
		[Category("设置")]
		[DefaultValue(21)]
		[O_Oo00Oo000O0(8.142)]
		[DisplayName("端口号")]
		public int Port
		{
			get
			{
				return this.O___o.o.;
			}
			set
			{
				this.O___o.o. = value;
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x0600458F RID: 17807 RVA: 0x001F1C72 File Offset: 0x001EFE72
		// (set) Token: 0x06004590 RID: 17808 RVA: 0x001F1C7A File Offset: 0x001EFE7A
		[Category("设置")]
		[DisplayName("根目录")]
		[O_Oo00Oo000O0(8.15)]
		public string RootDir
		{
			get
			{
				return this.oo.OO0O_.;
			}
			set
			{
				this.oo.OO0O_. = value;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x001F1C83 File Offset: 0x001EFE83
		// (set) Token: 0x06004592 RID: 17810 RVA: 0x001F1C8B File Offset: 0x001EFE8B
		[O_Oo00Oo000O0(8.6)]
		[Description("是否自动更新远程文件")]
		[DefaultValue(true)]
		[Category("设置")]
		[DisplayName("自动更新文件")]
		public bool AutoUpdate
		{
			get
			{
				return this.oO_.0o.;
			}
			set
			{
				this.oO_.0o. = value;
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x001F1C94 File Offset: 0x001EFE94
		// (set) Token: 0x06004594 RID: 17812 RVA: 0x001F1CA1 File Offset: 0x001EFEA1
		[MergableProperty(false)]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("Tab键顺序")]
		[Description("确定用户按Tab键时，该控件获得焦点的顺序。")]
		[Category("杂项")]
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

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x001F1CAF File Offset: 0x001EFEAF
		// (set) Token: 0x06004596 RID: 17814 RVA: 0x001F1CBC File Offset: 0x001EFEBC
		[DisplayName("左")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		[Category("位置")]
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

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x001F1CCA File Offset: 0x001EFECA
		// (set) Token: 0x06004598 RID: 17816 RVA: 0x001F1CD7 File Offset: 0x001EFED7
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("上")]
		[Category("位置")]
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

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06004599 RID: 17817 RVA: 0x001F1CE5 File Offset: 0x001EFEE5
		// (set) Token: 0x0600459A RID: 17818 RVA: 0x001F1CF2 File Offset: 0x001EFEF2
		[DisplayName("宽")]
		[O_Oo00Oo000O0(3.0)]
		[Category("位置")]
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

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x0600459B RID: 17819 RVA: 0x001F1D0D File Offset: 0x001EFF0D
		// (set) Token: 0x0600459C RID: 17820 RVA: 0x001F1D1A File Offset: 0x001EFF1A
		[MergableProperty(true)]
		[Category("位置")]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("高")]
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

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x001F1D35 File Offset: 0x001EFF35
		// (set) Token: 0x0600459E RID: 17822 RVA: 0x001F1D42 File Offset: 0x001EFF42
		[DisplayName("锚定")]
		[Category("位置")]
		[Description("在调整容器大小时，使控件的指定边缘和容器边缘的距离保持不变。")]
		[O_Oo00Oo000O0(5.0)]
		[MergableProperty(true)]
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

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x001F1D50 File Offset: 0x001EFF50
		// (set) Token: 0x060045A0 RID: 17824 RVA: 0x001F1D5D File Offset: 0x001EFF5D
		[MergableProperty(false)]
		[DisplayName("停靠")]
		[Category("位置")]
		[O_Oo00Oo000O0(5.1)]
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

		// Token: 0x04001C28 RID: 7208
		private FileManager <<EMPTY_NAME>>;

		// Token: 0x04001C29 RID: 7209
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001C2A RID: 7210
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C2B RID: 7211
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C2C RID: 7212
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C2D RID: 7213
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C2E RID: 7214
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C2F RID: 7215
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C30 RID: 7216
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C31 RID: 7217
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C32 RID: 7218
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C33 RID: 7219
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C34 RID: 7220
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C35 RID: 7221
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C36 RID: 7222
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C37 RID: 7223
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001C38 RID: 7224
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001C39 RID: 7225
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C3A RID: 7226
		private int <<EMPTY_NAME>>;
	}
}
