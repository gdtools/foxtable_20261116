using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000DB RID: 219
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal partial class O\u3000\u3002\u3000o\u3002\u3000\u3000\u3000 : Form
	{
		// Token: 0x06000A80 RID: 2688 RVA: 0x0005734C File Offset: 0x0005554C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o000__OO._. != null)
				{
					this.o000__OO._..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0005738C File Offset: 0x0005558C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o000__OO._. = new Container();
			this.o00__o.o00__oO.(new C1CheckBox());
			this.o00__o.o00__oO.(new Label());
			this.ooo.O.(new C1Button());
			this.o00__o.o00__oO.(new C1Button());
			this.o00__o.o00__oO.(new TreeView());
			this.o00__o.o00__oO.(new ImageList(this.o000__OO._.));
			((ISupportInitialize)this.O_ooO_oo.O0.()).BeginInit();
			((ISupportInitialize)this.O_ooO_oo.O0.()).BeginInit();
			((ISupportInitialize)this.O._Ooo.()).BeginInit();
			base.SuspendLayout();
			this.O_ooO_oo.O0.().AutoSize = true;
			this.O_ooO_oo.O0.().BorderStyle = BorderStyle.None;
			this.O_ooO_oo.O0.().Location = new Point(248, 19);
			this.O_ooO_oo.O0.().Name = "CheckBox1";
			this.O_ooO_oo.O0.().Size = new Size(96, 16);
			this.O_ooO_oo.O0.().TabIndex = 6;
			this.O_ooO_oo.O0.().Text = "选择所有函数";
			this.O_ooO_oo.O0.().UseVisualStyleBackColor = true;
			this.O_ooO_oo.O0.().Value = null;
			this.O_ooO_oo.O0.().AutoSize = true;
			this.O_ooO_oo.O0.().Location = new Point(12, 19);
			this.O_ooO_oo.O0.().Name = "Label1";
			this.O_ooO_oo.O0.().Size = new Size(107, 12);
			this.O_ooO_oo.O0.().TabIndex = 9;
			this.O_ooO_oo.O0.().Text = "选择要导入的函数:";
			this.O_ooO_oo.O0.().Location = new Point(189, 483);
			this.O_ooO_oo.O0.().Name = "Button2";
			this.O_ooO_oo.O0.().Size = new Size(75, 23);
			this.O_ooO_oo.O0.().TabIndex = 8;
			this.O_ooO_oo.O0.().Text = "取消";
			this.O_ooO_oo.O0.().UseVisualStyleBackColor = true;
			this.O._Ooo.().Location = new Point(97, 483);
			this.O._Ooo.().Name = "Button1";
			this.O._Ooo.().Size = new Size(75, 23);
			this.O._Ooo.().TabIndex = 7;
			this.O._Ooo.().Text = "确定";
			this.O._Ooo.().UseVisualStyleBackColor = true;
			this.O_ooO_oo.O0.().Location = new Point(15, 50);
			this.O_ooO_oo.O0.().Name = "TreeView1";
			this.O_ooO_oo.O0.().Size = new Size(330, 417);
			this.O_ooO_oo.O0.().TabIndex = 10;
			this.O_ooO_oo.O0.().ColorDepth = ColorDepth.Depth8Bit;
			this.O_ooO_oo.O0.().ImageSize = new Size(16, 16);
			this.O_ooO_oo.O0.().TransparentColor = Color.Transparent;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(361, 517);
			base.Controls.Add(this.O_ooO_oo.O0.());
			base.Controls.Add(this.O_ooO_oo.O0.());
			base.Controls.Add(this.O_ooO_oo.O0.());
			base.Controls.Add(this.O_ooO_oo.O0.());
			base.Controls.Add(this.O._Ooo.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.o0..0_0..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "导入函数";
			((ISupportInitialize)this.O_ooO_oo.O0.()).EndInit();
			((ISupportInitialize)this.O_ooO_oo.O0.()).EndInit();
			((ISupportInitialize)this.O._Ooo.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00057733 File Offset: 0x00055933
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o000__OO._.;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0005773C File Offset: 0x0005593C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.o._Oo0o_.);
			C1CheckBox c1CheckBox = this.o000__OO._.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged -= value;
			}
			this.o000__OO._. = A_0;
			c1CheckBox = this.o000__OO._.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged += value;
			}
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0005777F File Offset: 0x0005597F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o000__OO._.;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00057787 File Offset: 0x00055987
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o000__OO._. = A_0;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00057790 File Offset: 0x00055990
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o000__OO._.;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00057798 File Offset: 0x00055998
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOoo.oO_.);
			C1Button c1Button = this.o000__OO._.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o000__OO._. = A_0;
			c1Button = this.o000__OO._.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000577DB File Offset: 0x000559DB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooo.O.;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000577E4 File Offset: 0x000559E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO_O_oO._Ooo0_.);
			C1Button c1Button = this.ooo.O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooo.O. = A_0;
			c1Button = this.ooo.O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00057827 File Offset: 0x00055A27
		[CompilerGenerated]
		internal virtual TreeView <<EMPTY_NAME>>()
		{
			return this.o000__OO._.;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00057830 File Offset: 0x00055A30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TreeView A_0)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.o00__o.o00__oO.);
			TreeView treeView = this.o000__OO._.;
			if (treeView != null)
			{
				treeView.AfterCheck -= value;
			}
			this.o000__OO._. = A_0;
			treeView = this.o000__OO._.;
			if (treeView != null)
			{
				treeView.AfterCheck += value;
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00057873 File Offset: 0x00055A73
		[CompilerGenerated]
		internal virtual ImageList <<EMPTY_NAME>>()
		{
			return this.o000__OO._.;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0005787B File Offset: 0x00055A7B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ImageList A_0)
		{
			this.o000__OO._. = A_0;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00057884 File Offset: 0x00055A84
		public O\u3000\u3002\u3000o\u3002\u3000\u3000\u3000(string A_0)
		{
			base.Load += this.O.OOo.;
			base.FormClosed += this.O_ooO_oo.O0.;
			base.Activated += this.O_ooO_oo.O0.;
			this.o000__OO._. = new HashSet<TreeNode>();
			this.ooo.O.();
			this.o000__OO._. = A_0;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			OleDbConnection selectConnection = new OleDbConnection(Oo00.o_._0OOo.(this.o000__OO._.));
			DbDataAdapter dbDataAdapter = new OleDbDataAdapter("Select * From [Functions]", selectConnection);
			this.o000__OO._. = new DataTable();
			dbDataAdapter.Fill(this.o000__OO._.);
			this.O_ooO_oo.O0.().PathSeparator = "\t";
			this.O_ooO_oo.O0.().Images.Add(a.oO0O_O.__oo.());
			this.O_ooO_oo.O0.().Images.Add(a.O.o_oo0O_.());
			this.O_ooO_oo.O0.().ImageList = this.O_ooO_oo.O0.();
			this.O_ooO_oo.O0.().CheckBoxes = true;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00057984 File Offset: 0x00055B84
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o0\u3000\u3000\u3000\u3000\u3002\u3002.O0Oo_o_._O0o_O.(this.O_ooO_oo.O0.(), "", this.o000__OO._.);
			if (this.O_ooO_oo.O0.().Nodes.Count > 0)
			{
				this.O_ooO_oo.O0.().SelectedNode = this.O_ooO_oo.O0.().Nodes[0];
				this.O_ooO_oo.O0.().Select();
			}
			this.O_ooO_oo.O0.().ExpandAll();
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x000579EC File Offset: 0x00055BEC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000579F8 File Offset: 0x00055BF8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.o00__o.o00__oO.();
				IL_0F:
				num2 = 3;
				List<TreeNode> list = new List<TreeNode>();
				IL_17:
				num2 = 4;
				o_O_o_oOoo__.oo.O0o0o.(this.O_ooO_oo.O0.().Nodes, list);
				IL_2A:
				num2 = 5;
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o.00_0o0__OoO.()];
				IL_42:
				num2 = 6;
				string a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
				IL_63:
				num2 = 7;
				List<TreeNode>.Enumerator enumerator = list.GetEnumerator();
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = enumerator.Current;
					IL_7B:
					num2 = 8;
					if (treeNode.Checked || this.o000__OO._..Contains(treeNode))
					{
						IL_98:
						num2 = 9;
						if (treeNode.Tag != null)
						{
							IL_A7:
							num2 = 11;
							DataRow dataRow = (DataRow)treeNode.Tag;
							IL_B8:
							num2 = 12;
							DataRow dataRow2 = null;
							IL_BE:
							num2 = 13;
							o0_O o0_O = (o0_O)Conversions.ToInteger(dataRow["Type"]);
							IL_D4:
							num2 = 14;
							string text = dataRow["Name"].ToString();
							IL_EA:
							num2 = 15;
							string text2 = dataRow["Path"].ToString();
							IL_100:
							num2 = 16;
							dataRow["Name"].ToString().Split(new char[]
							{
								'\t'
							});
							IL_125:
							num2 = 17;
							if (o0_O == o0_O.ooooo0._OOOo_.)
							{
								IL_131:
								num2 = 18;
								DataRow[] array = dataTable.Select(string.Concat(new string[]
								{
									"[Type] = ",
									Conversions.ToString(9),
									" And [Name] = '",
									text,
									"'"
								}));
								IL_16F:
								num2 = 19;
								if (array.Length > 0)
								{
									IL_17C:
									num2 = 20;
									if (MessageBox.Show("函数\"" + text + "\"已经存在，是否覆盖？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
									{
										goto IL_373;
									}
									IL_1A3:
									num2 = 23;
									foreach (DataRow dataRow3 in array)
									{
										IL_1B6:
										num2 = 24;
										dataRow3.Delete();
										IL_1C0:
										num2 = 25;
									}
								}
							}
							else
							{
								IL_1D6:
								num2 = 27;
								if (dataRow.IsNull("Path"))
								{
									IL_1E7:
									num2 = 28;
									if (dataTable.Select(string.Concat(new string[]
									{
										"[Type] = ",
										Conversions.ToString(43),
										" And [Name] = '",
										text,
										"' And [Path] Is null"
									})).Length > 0)
									{
										goto IL_373;
									}
								}
								else
								{
									IL_22D:
									num2 = 31;
									if (dataTable.Select(string.Concat(new string[]
									{
										"[Type] = ",
										Conversions.ToString(43),
										" And [Name] = '",
										text,
										"' And [Path] ='",
										text2,
										"'"
									})).Length > 0)
									{
										goto IL_373;
									}
								}
							}
							IL_27E:
							num2 = 33;
							dataRow2 = dataTable.NewRow();
							IL_28A:
							num2 = 34;
							dataRow2 = dataTable.NewRow();
							IL_296:
							num2 = 35;
							dataRow2["Path"] = RuntimeHelpers.GetObjectValue(dataRow["Path"]);
							IL_2B6:
							num2 = 36;
							dataRow2["Name"] = RuntimeHelpers.GetObjectValue(dataRow["Name"]);
							IL_2D6:
							num2 = 37;
							dataRow2["srt"] = RuntimeHelpers.GetObjectValue(dataRow["srt"]);
							IL_2F6:
							num2 = 38;
							dataRow2["Type"] = RuntimeHelpers.GetObjectValue(dataRow["Type"]);
							IL_316:
							num2 = 39;
							if (!dataRow.IsNull("Code"))
							{
								IL_327:
								num2 = 40;
								dataRow2["Config"] = "[" + O00.ooo000o_0.00o0.(dataRow["Code"].ToString(), "UserFunction", a_) + "]";
							}
							IL_362:
							num2 = 41;
							dataTable.Rows.Add(dataRow2);
						}
					}
					IL_373:
					num2 = 42;
				}
				IL_382:
				num2 = 43;
				((IDisposable)enumerator).Dispose();
				IL_392:
				num2 = 44;
				Oo00.o0_o._O_.(dataTable, true);
				IL_39D:
				num2 = 45;
				base.DialogResult = DialogResult.OK;
				IL_3A7:
				goto IL_4B1;
				IL_3AC:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_472:
				goto IL_4A6;
				IL_474:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_484:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_474;
			}
			IL_4A6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_4B1:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00057EDC File Offset: 0x000560DC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			List<TreeNode> list = o_O_o_oOoo__.OO_O0oO0.oooO_.(this.O_ooO_oo.O0.());
			try
			{
				foreach (TreeNode treeNode in list)
				{
					treeNode.Checked = this.O_ooO_oo.O0.().Checked;
				}
			}
			finally
			{
				List<TreeNode>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00057F40 File Offset: 0x00056140
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

		// Token: 0x06000A94 RID: 2708 RVA: 0x00057FB8 File Offset: 0x000561B8
		private void <<EMPTY_NAME>>()
		{
			this.o000__OO._..Clear();
			List<TreeNode> list = new List<TreeNode>();
			o_O_o_oOoo__.oo.O0o0o.(this.O_ooO_oo.O0.().Nodes, list);
			try
			{
				foreach (TreeNode treeNode in list)
				{
					if (treeNode.Nodes.Count == 0 && treeNode.Checked && (treeNode.Tag == null || Conversions.ToInteger(((DataRow)treeNode.Tag)["Type"]) == 9))
					{
						for (TreeNode parent = treeNode.Parent; parent != null; parent = parent.Parent)
						{
							if (!parent.Checked)
							{
								this.o000__OO._..Add(parent);
							}
						}
					}
				}
			}
			finally
			{
				List<TreeNode>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00058084 File Offset: 0x00056284
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00058096 File Offset: 0x00056296
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O_ooO_oo.O0.().SelectedNode != null)
			{
				this.O_ooO_oo.O0.().SelectedNode.EnsureVisible();
			}
		}

		// Token: 0x040003D9 RID: 985
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040003DA RID: 986
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003DB RID: 987
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040003DC RID: 988
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003DD RID: 989
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003DE RID: 990
		[CompilerGenerated]
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x040003DF RID: 991
		[CompilerGenerated]
		private ImageList <<EMPTY_NAME>>;

		// Token: 0x040003E0 RID: 992
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x040003E1 RID: 993
		private string <<EMPTY_NAME>>;

		// Token: 0x040003E2 RID: 994
		private HashSet<TreeNode> <<EMPTY_NAME>>;
	}
}
