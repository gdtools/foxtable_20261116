using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 文件管理器
	/// </summary>
	// Token: 0x02000520 RID: 1312
	[ComVisible(true)]
	public class FileManager : Control, OoO_
	{
		// Token: 0x060057C2 RID: 22466 RVA: 0x0025D0F0 File Offset: 0x0025B2F0
		internal FileManager(FileManager A_0) : base(A_0, ControlTypeEnum.FileManager)
		{
			this.oo00.oo. = BooleanEnum.True;
			this.OOo_o.Oo. = BooleanEnum.False;
			this.oo00.oo. = 21;
			this.O.00oo_OO0O. = A_0;
		}

		/// <summary>
		/// 绑定字段
		/// </summary>
		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x060057C3 RID: 22467 RVA: 0x0025D118 File Offset: 0x0025B318
		// (set) Token: 0x060057C4 RID: 22468 RVA: 0x0025D120 File Offset: 0x0025B320
		[oO0oooo("1860")]
		public override string BindingField
		{
			get
			{
				return base.BindingField;
			}
			set
			{
				this.O.00oo_OO0O..DataBindings.Clear();
				this.O.00oo_OO0O..FileString = null;
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (ooO_0O.o_O0.O_.(ControlTypeEnum.FileManager, value, null))
					{
						if (value.StartsWith("全局变量."))
						{
							string text = value.Substring(value.IndexOf('.') + 1);
							if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
							{
								this.O.00oo_OO0O..DataBindings.Add("FileString", OO_00oOO.Vars.VariableTable, text);
								return;
							}
						}
						else
						{
							Binding binding = Oo00.OO.0O0o.("FileString", value);
							if (binding != null)
							{
								this.O.00oo_OO0O..DataBindings.Add(binding);
								if (this.O.00oo_OO0O..DataBindings.Count > 0)
								{
									this.O.00oo_OO0O..DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.Never;
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
		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x060057C5 RID: 22469 RVA: 0x0025D22F File Offset: 0x0025B42F
		// (set) Token: 0x060057C6 RID: 22470 RVA: 0x0025D23C File Offset: 0x0025B43C
		public override BooleanEnum ReadOnly
		{
			get
			{
				return this.O.00oo_OO0O..ReadOnly;
			}
			set
			{
				this.O.00oo_OO0O..ReadOnly = value;
			}
		}

		/// <summary>
		/// 是否在FileManager的底端显示增加、删除、清除、打开等命令
		/// </summary>
		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x060057C7 RID: 22471 RVA: 0x0025D24A File Offset: 0x0025B44A
		// (set) Token: 0x060057C8 RID: 22472 RVA: 0x0025D25F File Offset: 0x0025B45F
		public bool CommandVisible
		{
			get
			{
				return !this.O.00oo_OO0O..SplitContainer1.Panel2Collapsed;
			}
			set
			{
				this.O.00oo_OO0O..SplitContainer1.Panel2Collapsed = !value;
			}
		}

		/// <summary>
		/// 是否允许用户单击打开命令调用第三方程序来打开文件
		/// </summary>
		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x060057C9 RID: 22473 RVA: 0x0025D275 File Offset: 0x0025B475
		// (set) Token: 0x060057CA RID: 22474 RVA: 0x0025D287 File Offset: 0x0025B487
		public bool OpenEnabled
		{
			get
			{
				return this.O.00oo_OO0O..Open.Enabled;
			}
			set
			{
				this.O.00oo_OO0O..Open.Enabled = value;
			}
		}

		/// <summary>
		/// 是否允许用户双击打开文件
		/// </summary>
		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x060057CB RID: 22475 RVA: 0x0025D29A File Offset: 0x0025B49A
		// (set) Token: 0x060057CC RID: 22476 RVA: 0x0025D2A7 File Offset: 0x0025B4A7
		public bool DoubleClickOpen
		{
			get
			{
				return this.O.00oo_OO0O..DoubleClickOpen;
			}
			set
			{
				this.O.00oo_OO0O..DoubleClickOpen = value;
			}
		}

		/// <summary>
		/// 返回或设置用户在FileManager中选择的文件
		/// </summary>
		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x060057CD RID: 22477 RVA: 0x0025D2B8 File Offset: 0x0025B4B8
		// (set) Token: 0x060057CE RID: 22478 RVA: 0x0025D2F8 File Offset: 0x0025B4F8
		public string SelectedItem
		{
			get
			{
				string result;
				if (this.O.00oo_OO0O..ListBox1.SelectedItem == null)
				{
					result = "";
				}
				else
				{
					result = this.O.00oo_OO0O..ListBox1.SelectedItem.ToString();
				}
				return result;
			}
			set
			{
				int num = this.O.00oo_OO0O..ListBox1.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(this.O.00oo_OO0O..ListBox1.Items[i].ToString(), value, true) == 0)
					{
						this.O.00oo_OO0O..ListBox1.SelectedIndex = i;
						return;
					}
				}
			}
		}

		/// <summary>
		/// 一个集合，用于批量设置或返回FileManager中的所有文件
		/// </summary>
		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x060057CF RID: 22479 RVA: 0x0025D360 File Offset: 0x0025B560
		// (set) Token: 0x060057D0 RID: 22480 RVA: 0x0025D3BC File Offset: 0x0025B5BC
		public List<string> Files
		{
			get
			{
				List<string> list = new List<string>();
				int num = this.O.00oo_OO0O..ListBox1.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					list.Add(this.O.00oo_OO0O..ListBox1.Items[i].ToString());
				}
				return list;
			}
			set
			{
				string text = "";
				try
				{
					foreach (string str in value)
					{
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += "\r\n";
						}
						text += str;
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.O.00oo_OO0O..FileString = text;
			}
		}

		/// <summary>
		/// 增加命令
		/// </summary>
		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x060057D1 RID: 22481 RVA: 0x0025D438 File Offset: 0x0025B638
		[oO0oooo("2285")]
		public Label AddCommand
		{
			get
			{
				return this.O.00oo_OO0O..Add;
			}
		}

		/// <summary>
		/// 增加目录命令
		/// </summary>
		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x060057D2 RID: 22482 RVA: 0x0025D445 File Offset: 0x0025B645
		[oO0oooo("2285")]
		public Label AddFolderCommand
		{
			get
			{
				return this.O.00oo_OO0O..Folder;
			}
		}

		/// <summary>
		/// 清除命令
		/// </summary>
		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x060057D3 RID: 22483 RVA: 0x0025D452 File Offset: 0x0025B652
		[oO0oooo("2285")]
		public Label ClearCommand
		{
			get
			{
				return this.O.00oo_OO0O..Clear;
			}
		}

		/// <summary>
		/// 删除命令
		/// </summary>
		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x060057D4 RID: 22484 RVA: 0x0025D45F File Offset: 0x0025B65F
		[oO0oooo("2285")]
		public Label DeleteCommand
		{
			get
			{
				return this.O.00oo_OO0O..Delete;
			}
		}

		/// <summary>
		/// 打开命令
		/// </summary>
		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x060057D5 RID: 22485 RVA: 0x0025D46C File Offset: 0x0025B66C
		[oO0oooo("2285")]
		public Label OpenCommand
		{
			get
			{
				return this.O.00oo_OO0O..Open;
			}
		}

		/// <summary>
		/// 管理命令
		/// </summary>
		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x060057D6 RID: 22486 RVA: 0x0025D479 File Offset: 0x0025B679
		[oO0oooo("2285")]
		public Label ManagerCommand
		{
			get
			{
				return this.O.00oo_OO0O..Manager;
			}
		}

		/// <summary>
		/// 另存命令
		/// </summary>
		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x060057D7 RID: 22487 RVA: 0x0025D486 File Offset: 0x0025B686
		[oO0oooo("2285")]
		public Label SaveAsCommand
		{
			get
			{
				return this.O.00oo_OO0O..SaveAs;
			}
		}

		/// <summary>
		/// 全屏命令
		/// </summary>
		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x060057D8 RID: 22488 RVA: 0x0025D493 File Offset: 0x0025B693
		public Label FullViewCommand
		{
			get
			{
				return this.O.00oo_OO0O..FullView;
			}
		}

		/// <summary>
		/// 重连命令
		/// </summary>
		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x060057D9 RID: 22489 RVA: 0x0025D4A0 File Offset: 0x0025B6A0
		public Label ConnectCommand
		{
			get
			{
				return this.O.00oo_OO0O..Connect;
			}
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x0025D4AD File Offset: 0x0025B6AD
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		/// <summary>
		/// 如果FileManager用于远程文件管理，那么可以用此属性返回或设置其对应的FTPClient。
		/// </summary>
		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x060057DB RID: 22491 RVA: 0x0025D4B6 File Offset: 0x0025B6B6
		// (set) Token: 0x060057DC RID: 22492 RVA: 0x0025D4C3 File Offset: 0x0025B6C3
		[oO0oooo("1898")]
		public FTPClient FTPClient
		{
			get
			{
				return this.O.00oo_OO0O..FTPclient;
			}
			set
			{
				this.O.00oo_OO0O..FTPclient = value;
			}
		}

		/// <summary>
		/// 是否自动更新文件
		/// </summary>
		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x060057DD RID: 22493 RVA: 0x0025D4D1 File Offset: 0x0025B6D1
		// (set) Token: 0x060057DE RID: 22494 RVA: 0x0025D4DE File Offset: 0x0025B6DE
		public bool AutoUpdate
		{
			get
			{
				return this.O.00oo_OO0O..AutoUpdate;
			}
			set
			{
				this.O.00oo_OO0O..AutoUpdate = value;
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x060057DF RID: 22495 RVA: 0x0025D4EC File Offset: 0x0025B6EC
		// (set) Token: 0x060057E0 RID: 22496 RVA: 0x0025D4F4 File Offset: 0x0025B6F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Remote
		{
			get
			{
				return this.oo00.oo.;
			}
			set
			{
				this.oo00.oo. = value;
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x060057E1 RID: 22497 RVA: 0x0025D4FD File Offset: 0x0025B6FD
		// (set) Token: 0x060057E2 RID: 22498 RVA: 0x0025D505 File Offset: 0x0025B705
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Host
		{
			get
			{
				return this.oo00.oo.;
			}
			set
			{
				this.oo00.oo. = value;
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x060057E3 RID: 22499 RVA: 0x0025D50E File Offset: 0x0025B70E
		// (set) Token: 0x060057E4 RID: 22500 RVA: 0x0025D516 File Offset: 0x0025B716
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Account
		{
			get
			{
				return this.OOo_o.Oo.;
			}
			set
			{
				this.OOo_o.Oo. = value;
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x060057E5 RID: 22501 RVA: 0x0025D51F File Offset: 0x0025B71F
		// (set) Token: 0x060057E6 RID: 22502 RVA: 0x0025D527 File Offset: 0x0025B727
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Password
		{
			get
			{
				return this.o._0oo_O_o_.;
			}
			set
			{
				this.o._0oo_O_o_. = value;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x060057E7 RID: 22503 RVA: 0x0025D530 File Offset: 0x0025B730
		// (set) Token: 0x060057E8 RID: 22504 RVA: 0x0025D538 File Offset: 0x0025B738
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool UTF8
		{
			get
			{
				return this.o.oo0__o.;
			}
			set
			{
				this.o.oo0__o. = value;
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x060057E9 RID: 22505 RVA: 0x0025D541 File Offset: 0x0025B741
		// (set) Token: 0x060057EA RID: 22506 RVA: 0x0025D549 File Offset: 0x0025B749
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Port
		{
			get
			{
				return this.oo00.oo.;
			}
			set
			{
				this.oo00.oo. = value;
			}
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x060057EB RID: 22507 RVA: 0x0025D552 File Offset: 0x0025B752
		// (set) Token: 0x060057EC RID: 22508 RVA: 0x0025D55A File Offset: 0x0025B75A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string RootDir
		{
			get
			{
				return this.o0.O00o.;
			}
			set
			{
				this.o0.O00o. = value;
			}
		}

		/// <summary>
		/// 增加文件
		/// </summary>
		/// <param name="FileName">要增加的文件</param>
		// Token: 0x060057ED RID: 22509 RVA: 0x0025D563 File Offset: 0x0025B763
		[oO0oooo("2697")]
		public void AddFile(string FileName)
		{
			this.O.00oo_OO0O..O0oO_0._o_.(FileName);
		}

		/// <summary>
		/// 删除文件
		/// </summary>
		/// <param name="Filename">要删除的文件</param>
		// Token: 0x060057EE RID: 22510 RVA: 0x0025D572 File Offset: 0x0025B772
		[oO0oooo("2698")]
		public void DeleteFile(string Filename)
		{
			this.O.00oo_OO0O..o0O0o_O.O0.(Filename);
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x060057EF RID: 22511 RVA: 0x0025D580 File Offset: 0x0025B780
		// (set) Token: 0x060057F0 RID: 22512 RVA: 0x0025D588 File Offset: 0x0025B788
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string FolderName
		{
			get
			{
				return this.oO_.o_O___O.;
			}
			set
			{
				this.oO_.o_O___O. = value;
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x060057F1 RID: 22513 RVA: 0x0025D591 File Offset: 0x0025B791
		// (set) Token: 0x060057F2 RID: 22514 RVA: 0x0025D599 File Offset: 0x0025B799
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string SourceFolder
		{
			get
			{
				return this.oO.0oo_0_O_.;
			}
			set
			{
				this.oO.0oo_0_O_. = value;
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x060057F3 RID: 22515 RVA: 0x0025D5A2 File Offset: 0x0025B7A2
		// (set) Token: 0x060057F4 RID: 22516 RVA: 0x0025D5AA File Offset: 0x0025B7AA
		[EditorBrowsable(EditorBrowsableState.Never)]
		public BooleanEnum AutoCopyAttachFile
		{
			get
			{
				return this.oo00.oo.;
			}
			set
			{
				this.oo00.oo. = value;
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x060057F5 RID: 22517 RVA: 0x0025D5B3 File Offset: 0x0025B7B3
		// (set) Token: 0x060057F6 RID: 22518 RVA: 0x0025D5BB File Offset: 0x0025B7BB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public BooleanEnum AutoDeleteAttachFile
		{
			get
			{
				return this.OOo_o.Oo.;
			}
			set
			{
				this.OOo_o.Oo. = value;
			}
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x060057F7 RID: 22519 RVA: 0x0025D5C4 File Offset: 0x0025B7C4
		// (set) Token: 0x060057F8 RID: 22520 RVA: 0x0025D5CC File Offset: 0x0025B7CC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string FileFilter
		{
			get
			{
				return this.O0__0.0Oo.;
			}
			set
			{
				this.O0__0.0Oo. = value;
			}
		}

		// Token: 0x040022D1 RID: 8913
		private FileManager <<EMPTY_NAME>>;

		// Token: 0x040022D2 RID: 8914
		private bool <<EMPTY_NAME>>;

		// Token: 0x040022D3 RID: 8915
		private string <<EMPTY_NAME>>;

		// Token: 0x040022D4 RID: 8916
		private string <<EMPTY_NAME>>;

		// Token: 0x040022D5 RID: 8917
		private string <<EMPTY_NAME>>;

		// Token: 0x040022D6 RID: 8918
		private string <<EMPTY_NAME>>;

		// Token: 0x040022D7 RID: 8919
		private bool <<EMPTY_NAME>>;

		// Token: 0x040022D8 RID: 8920
		private string <<EMPTY_NAME>>;

		// Token: 0x040022D9 RID: 8921
		private string <<EMPTY_NAME>>;

		// Token: 0x040022DA RID: 8922
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040022DB RID: 8923
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040022DC RID: 8924
		private string <<EMPTY_NAME>>;

		// Token: 0x040022DD RID: 8925
		private int <<EMPTY_NAME>>;
	}
}
