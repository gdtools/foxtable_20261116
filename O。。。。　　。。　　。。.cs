using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace Foxtable
{
	// Token: 0x020000D7 RID: 215
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002 : Form
	{
		// Token: 0x060009F4 RID: 2548 RVA: 0x000520A0 File Offset: 0x000502A0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oOo_0.0. != null)
				{
					this.oOo_0.0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000520E0 File Offset: 0x000502E0
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oOo_0.0. = new Container();
			this.oOOO_oo.o0_0.(new C1Button());
			this.oOOO_oo.o0_0.(new Label());
			this.oOo_0.0.(new TreeView());
			this.oOOO_oo.o0_0.(new ImageList(this.oOo_0.0.));
			((ISupportInitialize)this.oOOO_oo.o0_0.()).BeginInit();
			base.SuspendLayout();
			this.oOOO_oo.o0_0.().Location = new Point(337, 594);
			this.oOOO_oo.o0_0.().Name = "btnEncrypt";
			this.oOOO_oo.o0_0.().Size = new Size(95, 24);
			this.oOOO_oo.o0_0.().TabIndex = 1;
			this.oOOO_oo.o0_0.().Text = "开始加密";
			this.oOOO_oo.o0_0.().UseVisualStyleBackColor = true;
			this.oOOO_oo.o0_0.().AutoSize = true;
			this.oOOO_oo.o0_0.().Location = new Point(15, 13);
			this.oOOO_oo.o0_0.().Name = "Label1";
			this.oOOO_oo.o0_0.().Size = new Size(119, 12);
			this.oOOO_oo.o0_0.().TabIndex = 4;
			this.oOOO_oo.o0_0.().Text = "请选择要加密的函数:";
			this.oOOO_oo.o0_0.().Location = new Point(17, 41);
			this.oOOO_oo.o0_0.().Name = "TreeView1";
			this.oOOO_oo.o0_0.().Size = new Size(415, 533);
			this.oOOO_oo.o0_0.().TabIndex = 6;
			this.oOOO_oo.o0_0.().ColorDepth = ColorDepth.Depth8Bit;
			this.oOOO_oo.o0_0.().ImageSize = new Size(16, 16);
			this.oOOO_oo.o0_0.().TransparentColor = Color.Transparent;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(446, 631);
			base.Controls.Add(this.oOOO_oo.o0_0.());
			base.Controls.Add(this.oOOO_oo.o0_0.());
			base.Controls.Add(this.oOOO_oo.o0_0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o0.0o...0o";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "自定义函数加密";
			((ISupportInitialize)this.oOOO_oo.o0_0.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00052329 File Offset: 0x00050529
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOo_0.0.;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00052334 File Offset: 0x00050534
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.o__.);
			C1Button c1Button = this.oOo_0.0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOo_0.0. = A_0;
			c1Button = this.oOo_0.0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00052377 File Offset: 0x00050577
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOo_0.0.;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0005237F File Offset: 0x0005057F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOo_0.0. = A_0;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00052388 File Offset: 0x00050588
		[CompilerGenerated]
		internal virtual TreeView <<EMPTY_NAME>>()
		{
			return this.oOo_0.0.;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00052390 File Offset: 0x00050590
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TreeView A_0)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.oOo_0.0.);
			TreeView treeView = this.oOo_0.0.;
			if (treeView != null)
			{
				treeView.AfterCheck -= value;
			}
			this.oOo_0.0. = A_0;
			treeView = this.oOo_0.0.;
			if (treeView != null)
			{
				treeView.AfterCheck += value;
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000523D3 File Offset: 0x000505D3
		[CompilerGenerated]
		internal virtual ImageList <<EMPTY_NAME>>()
		{
			return this.oOo_0.0.;
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000523DB File Offset: 0x000505DB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ImageList A_0)
		{
			this.oOo_0.0. = A_0;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000523E4 File Offset: 0x000505E4
		public O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002()
		{
			base.Load += this.o._O_o.;
			base.FormClosed += this.oOOO_oo.o0_0.;
			base.Activated += this.oOOO_oo.o0_0.;
			this.oOOO_oo.o0_0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oOOO_oo.o0_0.().PathSeparator = "\t";
			this.oOOO_oo.o0_0.().Images.Add(a.oO0O_O.__oo.());
			this.oOOO_oo.o0_0.().Images.Add(a.O.o_oo0O_.());
			this.oOOO_oo.o0_0.().ImageList = this.oOOO_oo.o0_0.();
			this.oOOO_oo.o0_0.().CheckBoxes = true;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000524A0 File Offset: 0x000506A0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o0\u3000\u3000\u3000\u3000\u3002\u3002.O0Oo_o_._O0o_O.(this.oOOO_oo.o0_0.(), "", null);
			if (this.oOOO_oo.o0_0.().Nodes.Count > 0)
			{
				this.oOOO_oo.o0_0.().SelectedNode = this.oOOO_oo.o0_0.().Nodes[0];
				this.oOOO_oo.o0_0.().Select();
			}
			this.oOOO_oo.o0_0.().ExpandAll();
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00052504 File Offset: 0x00050704
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			if (A_1.Action != TreeViewAction.Unknown)
			{
				List<TreeNode> list = new List<TreeNode>();
				o_O_o_oOoo__.oo.O0o0o.(A_1.Node.Nodes, list);
				try
				{
					foreach (TreeNode treeNode in list)
					{
						treeNode.Checked = A_1.Node.Checked;
					}
				}
				finally
				{
					List<TreeNode>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0005257C File Offset: 0x0005077C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = OO_00oOO.FileSys.GetName(OO_00oOO.ProjectFile);
			text = text.Substring(0, text.LastIndexOf("."));
			text = OO_00oOO.ProjectPath + text + "_Encrypt" + ooO0__OO.oo.Ooo_00.();
			if (!OO_00oOO.FileSys.FileExists(text) || MessageBox.Show("目标文件\r\n\r\n" + text + "\r\n\r\n已经存在,是否覆盖？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				List<DataRow> list = new List<DataRow>();
				List<TreeNode> list2 = new List<TreeNode>();
				o_O_o_oOoo__.oo.O0o0o.(this.oOOO_oo.o0_0.().Nodes, list2);
				try
				{
					foreach (TreeNode treeNode in list2)
					{
						if (treeNode.Checked && treeNode.Tag != null)
						{
							DataRow dataRow = (DataRow)treeNode.Tag;
							if (Conversions.ToInteger(dataRow["Type"]) == 9)
							{
								list.Add(dataRow);
							}
						}
					}
				}
				finally
				{
					List<TreeNode>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (list.Count == 0)
				{
					MessageBox.Show("请先选择要加密的函数!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				string a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
				string text2 = O_O0OO.O_O._Oo.();
				string a_2 = text2.Substring(text2.Length - 5, 5);
				a_2 = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., a_2).Substring(0, 5);
				try
				{
					foreach (DataRow dataRow2 in list)
					{
						string a_3 = dataRow2["Name"].ToString();
						dataRow2["Name"] = "![" + o0OoOOoOOo0.OO0._Oo0o.(a_3) + "]!";
						if (!dataRow2.IsNull("config"))
						{
							string text3 = dataRow2["Config"].ToString();
							if (text3.StartsWith("[") && text3.EndsWith("]"))
							{
								text3 = text3.TrimStart(new char[]
								{
									'['
								}).TrimEnd(new char[]
								{
									']'
								});
								text3 = O00.oO_.0o_oo_0O_.(text3, "UserFunction", a_);
							}
							else
							{
								text3 = O00.oO_.0o_oo_0O_.(text3, "UserFunction", text2);
							}
							dataRow2["config"] = "![" + O00.ooo000o_0.00o0.(text3, a_2, "UserFunction") + "]!";
						}
					}
				}
				finally
				{
					List<DataRow>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				OO_00oOO.FileSys.CopyFile(OO_00oOO.ProjectFile, text, true);
				OleDbConnectionStringBuilder oleDbConnectionStringBuilder = new OleDbConnectionStringBuilder(O_O0OO.OoO.0OO__0ooo.().ConnectionString);
				oleDbConnectionStringBuilder.DataSource = text;
				O_O0OO.OoO.0OO__0ooo.().ConnectionString = oleDbConnectionStringBuilder.ConnectionString;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o.00_0o0__OoO.()], true);
				oleDbConnectionStringBuilder.DataSource = OO_00oOO.ProjectFile;
				O_O0OO.OoO.0OO__0ooo.().ConnectionString = oleDbConnectionStringBuilder.ConnectionString;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o.00_0o0__OoO.()].Clear();
				((OleDbDataAdapter)O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o.00_0o0__OoO.()].ExtendedProperties["DataAdapter"]).Fill(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o.00_0o0__OoO.()]);
				MessageBox.Show("已经成功生成加密项目\r\n\r\n" + OO_00oOO.FileSys.GetName(text), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				text = OO_00oOO.FileSys.GetName(text);
				text = text.Substring(0, text.LastIndexOf(".") + 1);
				try
				{
					foreach (string text4 in OO_00oOO.FileSys.GetFiles(OO_00oOO.ProjectPath + "bin", SearchOption.SearchTopLevelOnly, new string[0]))
					{
						if (OO_00oOO.FileSys.GetName(text4).StartsWith(text, StringComparison.CurrentCultureIgnoreCase))
						{
							OO_00oOO.FileSys.DeleteFile(text4);
						}
					}
				}
				finally
				{
					IEnumerator<string> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
				base.Close();
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000529C4 File Offset: 0x00050BC4
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000529D6 File Offset: 0x00050BD6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oOOO_oo.o0_0.().SelectedNode != null)
			{
				this.oOOO_oo.o0_0.().SelectedNode.EnsureVisible();
			}
		}

		// Token: 0x040003A3 RID: 931
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040003A4 RID: 932
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003A5 RID: 933
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040003A6 RID: 934
		[CompilerGenerated]
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x040003A7 RID: 935
		[CompilerGenerated]
		private ImageList <<EMPTY_NAME>>;
	}
}
