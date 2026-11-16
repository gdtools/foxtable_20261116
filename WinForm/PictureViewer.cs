using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 图片浏览器
	/// </summary>
	// Token: 0x02000533 RID: 1331
	[ComVisible(true)]
	public class PictureViewer : Control, OoO_
	{
		// Token: 0x060058CC RID: 22732 RVA: 0x0025F595 File Offset: 0x0025D795
		internal PictureViewer(PictureViewer A_0) : base(A_0, ControlTypeEnum.PictureViewer)
		{
			this.oOoo._0o0. = BooleanEnum.True;
			this.o_O0__._. = BooleanEnum.False;
			this.oOoo._0o0. = 21;
			this.Oooo.Oo_0O. = A_0;
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x060058CD RID: 22733 RVA: 0x0025F5BD File Offset: 0x0025D7BD
		// (set) Token: 0x060058CE RID: 22734 RVA: 0x0025F5C8 File Offset: 0x0025D7C8
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
				this.Oooo.Oo_0O..ImageFiles = "";
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.PictureViewer, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.Oooo.Oo_0O..DataBindings.Add("ImageFiles", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("ImageFiles", value);
							if (binding != null)
							{
								this.Oooo.Oo_0O..DataBindings.Add(binding);
								if (this.Oooo.Oo_0O..DataBindings.Count > 0)
								{
									this.Oooo.Oo_0O..DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.Never;
								}
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x060058CF RID: 22735 RVA: 0x0025F6DB File Offset: 0x0025D8DB
		// (set) Token: 0x060058D0 RID: 22736 RVA: 0x0025F6E8 File Offset: 0x0025D8E8
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.Oooo.Oo_0O..ReadOnly;
			}
			set
			{
				this.Oooo.Oo_0O..ReadOnly = value;
			}
		}

		/// <summary>
		/// 是否在PictureViewer的底端显示增加、删除、清除、打开等命令
		/// </summary>
		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x060058D1 RID: 22737 RVA: 0x0025F6F6 File Offset: 0x0025D8F6
		// (set) Token: 0x060058D2 RID: 22738 RVA: 0x0025F70B File Offset: 0x0025D90B
		public bool CommandVisible
		{
			get
			{
				return !this.Oooo.Oo_0O..SplitContainer.Panel2Collapsed;
			}
			set
			{
				this.Oooo.Oo_0O..SplitContainer.Panel2Collapsed = !value;
			}
		}

		/// <summary>
		/// 是否允许用户单击打开命令调用第三方程序来打开图片
		/// </summary>
		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x060058D3 RID: 22739 RVA: 0x0025F721 File Offset: 0x0025D921
		// (set) Token: 0x060058D4 RID: 22740 RVA: 0x0025F733 File Offset: 0x0025D933
		public bool OpenEnabled
		{
			get
			{
				return this.Oooo.Oo_0O..Open.Enabled;
			}
			set
			{
				this.Oooo.Oo_0O..Open.Enabled = value;
			}
		}

		/// <summary>
		/// 是否自动缩放图片
		/// </summary>
		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x060058D5 RID: 22741 RVA: 0x0025F746 File Offset: 0x0025D946
		// (set) Token: 0x060058D6 RID: 22742 RVA: 0x0025F756 File Offset: 0x0025D956
		public bool AutoSize
		{
			get
			{
				return this.Oooo.Oo_0O..SizeMode == PictureBoxSizeMode.Zoom;
			}
			set
			{
				if (value)
				{
					this.Oooo.Oo_0O..SizeMode = PictureBoxSizeMode.Zoom;
					return;
				}
				this.Oooo.Oo_0O..SizeMode = PictureBoxSizeMode.AutoSize;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x060058D7 RID: 22743 RVA: 0x0025F774 File Offset: 0x0025D974
		// (set) Token: 0x060058D8 RID: 22744 RVA: 0x0025F786 File Offset: 0x0025D986
		public override Color BackColor
		{
			get
			{
				return this.Oooo.Oo_0O..C1PictureBox1.BackColor;
			}
			set
			{
				this.Oooo.Oo_0O..C1PictureBox1.BackColor = value;
				this.Oooo.Oo_0O..Panel2.BackColor = value;
			}
		}

		/// <summary>
		/// 返回用户在PictureViewer中选择的图片文件
		/// </summary>
		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x060058D9 RID: 22745 RVA: 0x0025F7AA File Offset: 0x0025D9AA
		public string SelectedItem
		{
			get
			{
				return this.Oooo.Oo_0O..SelectedItem;
			}
		}

		/// <summary>
		/// 增加命令
		/// </summary>
		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x060058DA RID: 22746 RVA: 0x0025F7B7 File Offset: 0x0025D9B7
		[oO0oooo("2286")]
		public Label AddCommand
		{
			get
			{
				return this.Oooo.Oo_0O..Add;
			}
		}

		/// <summary>
		/// 清除命令
		/// </summary>
		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x060058DB RID: 22747 RVA: 0x0025F7C4 File Offset: 0x0025D9C4
		[oO0oooo("2286")]
		public Label ClearCommand
		{
			get
			{
				return this.Oooo.Oo_0O..Clear;
			}
		}

		/// <summary>
		/// 删除命令
		/// </summary>
		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x060058DC RID: 22748 RVA: 0x0025F7D1 File Offset: 0x0025D9D1
		[oO0oooo("2286")]
		public Label DeleteCommand
		{
			get
			{
				return this.Oooo.Oo_0O..Delete;
			}
		}

		/// <summary>
		/// 打开命令
		/// </summary>
		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x060058DD RID: 22749 RVA: 0x0025F7DE File Offset: 0x0025D9DE
		[oO0oooo("2286")]
		public Label OpenCommand
		{
			get
			{
				return this.Oooo.Oo_0O..Open;
			}
		}

		/// <summary>
		/// 全屏命令
		/// </summary>
		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x060058DE RID: 22750 RVA: 0x0025F7EB File Offset: 0x0025D9EB
		[oO0oooo("2286")]
		public Label FullViewCommand
		{
			get
			{
				return this.Oooo.Oo_0O..Full;
			}
		}

		/// <summary>
		/// 管理命令
		/// </summary>
		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x060058DF RID: 22751 RVA: 0x0025F7F8 File Offset: 0x0025D9F8
		[oO0oooo("2286")]
		public Label ManagerCommand
		{
			get
			{
				return this.Oooo.Oo_0O..Manager;
			}
		}

		/// <summary>
		/// 另存命令
		/// </summary>
		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x060058E0 RID: 22752 RVA: 0x0025F805 File Offset: 0x0025DA05
		[oO0oooo("2286")]
		public Label SaveAsCommand
		{
			get
			{
				return this.Oooo.Oo_0O..SaveAs;
			}
		}

		/// <summary>
		/// 缩放命令
		/// </summary>
		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x060058E1 RID: 22753 RVA: 0x0025F812 File Offset: 0x0025DA12
		[oO0oooo("2286")]
		public Label StretchCommand
		{
			get
			{
				return this.Oooo.Oo_0O..Stretch;
			}
		}

		/// <summary>
		/// 重连命令
		/// </summary>
		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x060058E2 RID: 22754 RVA: 0x0025F81F File Offset: 0x0025DA1F
		[oO0oooo("2286")]
		public Label ConnectCommand
		{
			get
			{
				return this.Oooo.Oo_0O..lblConnect;
			}
		}

		/// <summary>
		/// 更新命令
		/// </summary>
		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x060058E3 RID: 22755 RVA: 0x0025F82C File Offset: 0x0025DA2C
		[oO0oooo("2286")]
		public Label UpdateCommand
		{
			get
			{
				return this.Oooo.Oo_0O..lblUpdate;
			}
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x0025F839 File Offset: 0x0025DA39
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		/// <summary>
		/// 是否自动下载图片
		/// </summary>
		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x060058E5 RID: 22757 RVA: 0x0025F842 File Offset: 0x0025DA42
		// (set) Token: 0x060058E6 RID: 22758 RVA: 0x0025F84F File Offset: 0x0025DA4F
		public bool AutoDownload
		{
			get
			{
				return this.Oooo.Oo_0O..AutoDownLoad;
			}
			set
			{
				this.Oooo.Oo_0O..AutoDownLoad = value;
			}
		}

		/// <summary>
		/// 是否自动更新图片
		/// </summary>
		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x060058E7 RID: 22759 RVA: 0x0025F85D File Offset: 0x0025DA5D
		// (set) Token: 0x060058E8 RID: 22760 RVA: 0x0025F86A File Offset: 0x0025DA6A
		public bool AutoUpdate
		{
			get
			{
				return this.Oooo.Oo_0O..AutoUpdate;
			}
			set
			{
				this.Oooo.Oo_0O..AutoUpdate = value;
			}
		}

		/// <summary>
		/// 用于远程图片管理时，可用此属性设置FTPClient
		/// </summary>
		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x060058E9 RID: 22761 RVA: 0x0025F878 File Offset: 0x0025DA78
		// (set) Token: 0x060058EA RID: 22762 RVA: 0x0025F885 File Offset: 0x0025DA85
		[oO0oooo("2696")]
		public FTPClient FTPClient
		{
			get
			{
				return this.Oooo.Oo_0O..FTPclient;
			}
			set
			{
				this.Oooo.Oo_0O..FTPclient = value;
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x060058EB RID: 22763 RVA: 0x0025F893 File Offset: 0x0025DA93
		// (set) Token: 0x060058EC RID: 22764 RVA: 0x0025F89B File Offset: 0x0025DA9B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Remote
		{
			get
			{
				return this.oOoo._0o0.;
			}
			set
			{
				this.oOoo._0o0. = value;
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x060058ED RID: 22765 RVA: 0x0025F8A4 File Offset: 0x0025DAA4
		// (set) Token: 0x060058EE RID: 22766 RVA: 0x0025F8AC File Offset: 0x0025DAAC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Host
		{
			get
			{
				return this.oOoo._0o0.;
			}
			set
			{
				this.oOoo._0o0. = value;
			}
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x060058EF RID: 22767 RVA: 0x0025F8B5 File Offset: 0x0025DAB5
		// (set) Token: 0x060058F0 RID: 22768 RVA: 0x0025F8BD File Offset: 0x0025DABD
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Account
		{
			get
			{
				return this.o_O0__._.;
			}
			set
			{
				this.o_O0__._. = value;
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x060058F1 RID: 22769 RVA: 0x0025F8C6 File Offset: 0x0025DAC6
		// (set) Token: 0x060058F2 RID: 22770 RVA: 0x0025F8CE File Offset: 0x0025DACE
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Password
		{
			get
			{
				return this.O_OO0.0oO0oo_.;
			}
			set
			{
				this.O_OO0.0oO0oo_. = value;
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x060058F3 RID: 22771 RVA: 0x0025F8D7 File Offset: 0x0025DAD7
		// (set) Token: 0x060058F4 RID: 22772 RVA: 0x0025F8DF File Offset: 0x0025DADF
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool UTF8
		{
			get
			{
				return this.o_Oo00_0_o.oOo.;
			}
			set
			{
				this.o_Oo00_0_o.oOo. = value;
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x060058F5 RID: 22773 RVA: 0x0025F8E8 File Offset: 0x0025DAE8
		// (set) Token: 0x060058F6 RID: 22774 RVA: 0x0025F8F0 File Offset: 0x0025DAF0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Port
		{
			get
			{
				return this.oOoo._0o0.;
			}
			set
			{
				this.oOoo._0o0. = value;
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x060058F7 RID: 22775 RVA: 0x0025F8F9 File Offset: 0x0025DAF9
		// (set) Token: 0x060058F8 RID: 22776 RVA: 0x0025F901 File Offset: 0x0025DB01
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string RootDir
		{
			get
			{
				return this.O___.0oo_Oo.;
			}
			set
			{
				this.O___.0oo_Oo. = value;
			}
		}

		/// <summary>
		/// 向PictureViewer中添加图片
		/// </summary>
		/// <param name="FileName"> 要添加的图片文件名</param>
		// Token: 0x060058F9 RID: 22777 RVA: 0x0025F90A File Offset: 0x0025DB0A
		[oO0oooo("2699")]
		public void AddFile(string FileName)
		{
			this.Oooo.Oo_0O..oOo.o0Oo_.(FileName);
		}

		/// <summary>
		/// 从PictureViewer中删除指定的图片文件
		/// </summary>
		/// <param name="FileName">要删除的图片文件名</param>
		// Token: 0x060058FA RID: 22778 RVA: 0x0025F919 File Offset: 0x0025DB19
		[oO0oooo("2700")]
		public void DeleteFile(string FileName)
		{
			this.Oooo.Oo_0O..oO0__0O0o00._.(FileName);
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x060058FB RID: 22779 RVA: 0x0025F927 File Offset: 0x0025DB27
		// (set) Token: 0x060058FC RID: 22780 RVA: 0x0025F92F File Offset: 0x0025DB2F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string FolderName
		{
			get
			{
				return this.o.OOO_.;
			}
			set
			{
				this.o.OOO_. = value;
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x060058FD RID: 22781 RVA: 0x0025F938 File Offset: 0x0025DB38
		// (set) Token: 0x060058FE RID: 22782 RVA: 0x0025F940 File Offset: 0x0025DB40
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string SourceFolder
		{
			get
			{
				return this.Oo000.ooO.;
			}
			set
			{
				this.Oo000.ooO. = value;
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x060058FF RID: 22783 RVA: 0x0025F949 File Offset: 0x0025DB49
		// (set) Token: 0x06005900 RID: 22784 RVA: 0x0025F951 File Offset: 0x0025DB51
		[EditorBrowsable(EditorBrowsableState.Never)]
		public BooleanEnum AutoCopyAttachFile
		{
			get
			{
				return this.oOoo._0o0.;
			}
			set
			{
				this.oOoo._0o0. = value;
			}
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06005901 RID: 22785 RVA: 0x0025F95A File Offset: 0x0025DB5A
		// (set) Token: 0x06005902 RID: 22786 RVA: 0x0025F962 File Offset: 0x0025DB62
		[EditorBrowsable(EditorBrowsableState.Never)]
		public BooleanEnum AutoDeleteAttachFile
		{
			get
			{
				return this.o_O0__._.;
			}
			set
			{
				this.o_O0__._. = value;
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06005903 RID: 22787 RVA: 0x0025F96B File Offset: 0x0025DB6B
		// (set) Token: 0x06005904 RID: 22788 RVA: 0x0025F973 File Offset: 0x0025DB73
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string FileFilter
		{
			get
			{
				return this.OO0O_00._.;
			}
			set
			{
				this.OO0O_00._. = value;
			}
		}

		// Token: 0x04002317 RID: 8983
		private PictureViewer <<EMPTY_NAME>>;

		// Token: 0x04002318 RID: 8984
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002319 RID: 8985
		private string <<EMPTY_NAME>>;

		// Token: 0x0400231A RID: 8986
		private string <<EMPTY_NAME>>;

		// Token: 0x0400231B RID: 8987
		private string <<EMPTY_NAME>>;

		// Token: 0x0400231C RID: 8988
		private string <<EMPTY_NAME>>;

		// Token: 0x0400231D RID: 8989
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400231E RID: 8990
		private string <<EMPTY_NAME>>;

		// Token: 0x0400231F RID: 8991
		private string <<EMPTY_NAME>>;

		// Token: 0x04002320 RID: 8992
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04002321 RID: 8993
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04002322 RID: 8994
		private string <<EMPTY_NAME>>;

		// Token: 0x04002323 RID: 8995
		private int <<EMPTY_NAME>>;
	}
}
