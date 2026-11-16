using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000AF RID: 175
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class o\u3002\u3000\u3002\u3000\u3000\u3002_ : Form
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x000327C0 File Offset: 0x000309C0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oo_OOoOoo.OO. != null)
				{
					this.oo_OOoOoo.OO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00032800 File Offset: 0x00030A00
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_._O__0OO0O.(new Label());
			this.Oo_oO._OoO.(new Label());
			this.o_._O__0OO0O.(new C1TextBox());
			this.Oo_oO._OoO.(new C1TextBox());
			this.o_._O__0OO0O.(new C1Button());
			this.Oo_oO._OoO.(new C1Button());
			this.ooOO.oOoOOOOO0.(new C1TextBox());
			this.o_.O_0oO.(new Label());
			((ISupportInitialize)this.oOooOO0.oo_oO.()).BeginInit();
			((ISupportInitialize)this.O_00OO.o_0o_.()).BeginInit();
			((ISupportInitialize)this.oOo_0OoO_.O00O.()).BeginInit();
			((ISupportInitialize)this.O_.oo0oO.()).BeginInit();
			((ISupportInitialize)this.OO._O0_0oo.()).BeginInit();
			base.SuspendLayout();
			this.OO._O0_0oo.().AutoSize = true;
			this.OO._O0_0oo.().Location = new Point(28, 21);
			this.OO._O0_0oo.().Name = "lblKey";
			this.OO._O0_0oo.().Size = new Size(47, 12);
			this.OO._O0_0oo.().TabIndex = 0;
			this.OO._O0_0oo.().Text = "键值列:";
			this.O_00OO.o_0o_.().AutoSize = true;
			this.O_00OO.o_0o_.().Location = new Point(28, 86);
			this.O_00OO.o_0o_.().Name = "lblCapttion";
			this.O_00OO.o_0o_.().Size = new Size(47, 12);
			this.O_00OO.o_0o_.().TabIndex = 1;
			this.O_00OO.o_0o_.().Text = "标题列:";
			this.oOooOO0.oo_oO.().Location = new Point(30, 45);
			this.oOooOO0.oo_oO.().Name = "txtKey";
			this.oOooOO0.oo_oO.().Size = new Size(270, 19);
			this.oOooOO0.oo_oO.().TabIndex = 0;
			this.oOooOO0.oo_oO.().Tag = null;
			this.O_00OO.o_0o_.().Location = new Point(30, 110);
			this.O_00OO.o_0o_.().Name = "txtCaption";
			this.O_00OO.o_0o_.().Size = new Size(270, 19);
			this.O_00OO.o_0o_.().TabIndex = 1;
			this.O_00OO.o_0o_.().Tag = null;
			this.oOo_0OoO_.O00O.().Location = new Point(78, 218);
			this.oOo_0OoO_.O00O.().Name = "C1Button1";
			this.oOo_0OoO_.O00O.().Size = new Size(75, 24);
			this.oOo_0OoO_.O00O.().TabIndex = 3;
			this.oOo_0OoO_.O00O.().Text = "确定";
			this.oOo_0OoO_.O00O.().UseVisualStyleBackColor = true;
			this.O_.oo0oO.().DialogResult = DialogResult.Cancel;
			this.O_.oo0oO.().Location = new Point(176, 218);
			this.O_.oo0oO.().Name = "C1Button2";
			this.O_.oo0oO.().Size = new Size(75, 24);
			this.O_.oo0oO.().TabIndex = 4;
			this.O_.oo0oO.().Text = "取消";
			this.O_.oo0oO.().UseVisualStyleBackColor = true;
			this.OO._O0_0oo.().DataType = typeof(double);
			this.OO._O0_0oo.().Location = new Point(30, 175);
			this.OO._O0_0oo.().Name = "txtValue";
			this.OO._O0_0oo.().Size = new Size(270, 19);
			this.OO._O0_0oo.().TabIndex = 2;
			this.OO._O0_0oo.().Tag = null;
			this.oOooOO0.oo_oO.().AutoSize = true;
			this.oOooOO0.oo_oO.().Location = new Point(28, 151);
			this.oOooOO0.oo_oO.().Name = "lblValue";
			this.oOooOO0.oo_oO.().Size = new Size(47, 12);
			this.oOooOO0.oo_oO.().TabIndex = 6;
			this.oOooOO0.oo_oO.().Text = "取值列:";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(328, 262);
			base.Controls.Add(this.OO._O0_0oo.());
			base.Controls.Add(this.oOooOO0.oo_oO.());
			base.Controls.Add(this.O_.oo0oO.());
			base.Controls.Add(this.oOo_0OoO_.O00O.());
			base.Controls.Add(this.O_00OO.o_0o_.());
			base.Controls.Add(this.oOooOO0.oo_oO.());
			base.Controls.Add(this.O_00OO.o_0o_.());
			base.Controls.Add(this.OO._O0_0oo.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o...o...o";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "编辑节点";
			((ISupportInitialize)this.oOooOO0.oo_oO.()).EndInit();
			((ISupportInitialize)this.O_00OO.o_0o_.()).EndInit();
			((ISupportInitialize)this.oOo_0OoO_.O00O.()).EndInit();
			((ISupportInitialize)this.O_.oo0oO.()).EndInit();
			((ISupportInitialize)this.OO._O0_0oo.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00032CE1 File Offset: 0x00030EE1
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0___00O.o0.;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00032CE9 File Offset: 0x00030EE9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0___00O.o0. = A_0;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00032CF2 File Offset: 0x00030EF2
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o__Oo._0O0Oo.;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00032CFA File Offset: 0x00030EFA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o__Oo._0O0Oo. = A_0;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00032D03 File Offset: 0x00030F03
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oo_OOoOoo.OO.;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00032D0C File Offset: 0x00030F0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			EventHandler value = new EventHandler(this.O0___00O.o0.);
			C1TextBox c1TextBox = this.oo_OOoOoo.OO.;
			if (c1TextBox != null)
			{
				c1TextBox.Leave -= value;
			}
			this.oo_OOoOoo.OO. = A_0;
			c1TextBox = this.oo_OOoOoo.OO.;
			if (c1TextBox != null)
			{
				c1TextBox.Leave += value;
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00032D4F File Offset: 0x00030F4F
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_o000._o_.;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00032D57 File Offset: 0x00030F57
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_o000._o_. = A_0;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00032D60 File Offset: 0x00030F60
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0___00O.o0.;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00032D68 File Offset: 0x00030F68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_.oo0oO.);
			C1Button o0___00O.o0. = this.O0___00O.o0.;
			if (o0___00O.o0. != null)
			{
				o0___00O.o0..Click -= value;
			}
			this.O0___00O.o0. = A_0;
			o0___00O.o0. = this.O0___00O.o0.;
			if (o0___00O.o0. != null)
			{
				o0___00O.o0..Click += value;
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00032DAB File Offset: 0x00030FAB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o__Oo._0O0Oo.;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00032DB3 File Offset: 0x00030FB3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o__Oo._0O0Oo. = A_0;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00032DBC File Offset: 0x00030FBC
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O____O.0.;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00032DC4 File Offset: 0x00030FC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O____O.0. = A_0;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00032DCD File Offset: 0x00030FCD
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.ooOO.oOoOOOOO0.;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00032DD5 File Offset: 0x00030FD5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.ooOO.oOoOOOOO0. = A_0;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00032DDE File Offset: 0x00030FDE
		[CompilerGenerated]
		public TreeNode <<EMPTY_NAME>>()
		{
			return this.O0___00O.o0.;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00032DE6 File Offset: 0x00030FE6
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(TreeNode A_0)
		{
			this.O0___00O.o0. = A_0;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00032DEF File Offset: 0x00030FEF
		[CompilerGenerated]
		public TreeNode <<EMPTY_NAME>>()
		{
			return this.o__Oo._0O0Oo.;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00032DF7 File Offset: 0x00030FF7
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(TreeNode A_0)
		{
			this.o__Oo._0O0Oo. = A_0;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00032E00 File Offset: 0x00031000
		[CompilerGenerated]
		public oo__ <<EMPTY_NAME>>()
		{
			return this.O0___00O.o0.;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00032E08 File Offset: 0x00031008
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(oo__ A_0)
		{
			this.O0___00O.o0. = A_0;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00032E11 File Offset: 0x00031011
		public o\u3002\u3000\u3002\u3000\u3000\u3002_(oo__ A_0, TreeNode A_1, TreeNode A_2)
		{
			base.Load += this.oOO_0O__o0._O.;
			this.oo_OOoOoo.OO. = false;
			this.OO._O0_0oo.();
			this.Oo_oO._OoO.(A_0);
			this.Oo_oO._OoO.(A_1);
			this.o_._O__0OO0O.(A_2);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00032E4D File Offset: 0x0003104D
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00032E64 File Offset: 0x00031064
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = this.oOooOO0.oo_oO.().Text.Trim();
			string text2 = this.O_00OO.o_0o_.().Text.Trim();
			if (Operators.CompareString(text, "", true) != 0 && Operators.CompareString(text2, "", true) != 0)
			{
				string text3 = "";
				if (this.oOooOO0.oo_oO.() != null)
				{
					text3 = this.oOooOO0.oo_oO.().Name;
				}
				if (this.OO._O0_0oo.().oO_.o_o_. == O_O_o_oO0.OOOO.Oo_o__O.)
				{
					if (Operators.CompareString(text3, text, true) != 0)
					{
						if (this.OO._O0_0oo.().oO_.o_o_..Contains(this.oOooOO0.oo_oO.()))
						{
							this.OO._O0_0oo.().oO_.o_o_. = O_O_o_oO0.O0O_O_00.O0.;
							if (this.oOooOO0.oo_oO.().Nodes.Count > 0)
							{
								this.oo_OOoOoo.OO. = true;
							}
						}
						else if (this.oOooOO0.oo_oO.().Nodes.Count > 0)
						{
							if (this.OO._O0_0oo.().oOoO.O0o.().FindRows(text3).Length > 1)
							{
								this.OO._O0_0oo.().oO_.o_o_. = O_O_o_oO0.O.o0OO__o0O0.;
							}
							else if (this.OO._O0_0oo.().Nodes.ContainsKey(this.oOooOO0.oo_oO.().Name) && this.oOooOO0.oo_oO.().Level > 0)
							{
								this.OO._O0_0oo.().oO_.o_o_. = O_O_o_oO0.O.o0OO__o0O0.;
							}
						}
					}
					else if (Operators.CompareString(text3, text, true) == 0 && string.Compare(text3, text, false) != 0)
					{
						this.OO._O0_0oo.().oO_.o_o_. = O_O_o_oO0.O.o0OO__o0O0.;
					}
				}
				if (Operators.CompareString(text3, text, true) != 0)
				{
					string text4 = "";
					if (this.OO._O0_0oo.().oO_.o_o_. == O_O_o_oO0.O.o0OO__o0O0.)
					{
						text4 = this.OO._O0_0oo.().OOO0oO.0OO0.(text3, text, null);
					}
					else if (this.OO._O0_0oo.().oO_.o_o_. == O_O_o_oO0.OOOO.Oo_o__O.)
					{
						text4 = this.OO._O0_0oo.().OOO0oO.0OO0.(text3, text, this.oOooOO0.oo_oO.());
					}
					else if (this.OO._O0_0oo.() != null)
					{
						text4 = this.OO._O0_0oo.().OOO0oO.0OO0.(this.OO._O0_0oo.().Name, text, text2);
					}
					if (Operators.CompareString(text4, "", true) > 0)
					{
						MessageBox.Show("节点名无效，会导致循环引用:" + text4, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
					if (this.OO._O0_0oo.() != null && this.OO._O0_0oo.().FirstNode != null && this.OO._O0_0oo.().o0_0O0.ooo.(this.OO._O0_0oo.().FirstNode, text))
					{
						MessageBox.Show("节点名无效，已经存在同名的同级节点!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
					if (this.OO._O0_0oo.().oO_.o_o_. == O_O_o_oO0.O.o0OO__o0O0.)
					{
						TreeNode treeNode = this.OO._O0_0oo.().oO0o0.OO.(text, text3);
						if (treeNode != null)
						{
							MessageBox.Show("命名冲突，\"" + treeNode.Parent.FullPath + "\"下同时存在新旧名称的节点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
					}
					if ((this.OO._O0_0oo.().oO_.o_o_. == O_O_o_oO0.O.o0OO__o0O0. || this.OO._O0_0oo.().oO_.o_o_. == O_O_o_oO0.O.ooo00oo0o. || (this.OO._O0_0oo.().oO_.o_o_. == O_O_o_oO0.OOOO.Oo_o__O. && this.oOooOO0.oo_oO.().Nodes.Count > 0)) && this.OO._O0_0oo.().ooo.Oo_o0.(this.oOooOO0.oo_oO.(), text))
					{
						MessageBox.Show("节点名无效，已经存在同名节点!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
				}
				if (this.oo_OOoOoo.OO.)
				{
					List<TreeNode> list = new List<TreeNode>();
					o_O_o_oOoo__.oo.O0o0o.(this.oOooOO0.oo_oO.().Nodes, list);
					for (int i = list.Count - 1; i >= 0; i += -1)
					{
						TreeNode treeNode2 = list[i];
						if (this.OO._O0_0oo.().oO_.o_o_..Contains(treeNode2))
						{
							this.OO._O0_0oo.().oO_.o_o_..Remove(treeNode2);
						}
						int num = this.OO._O0_0oo.().OOO0oO.0OO0.().Find(new object[]
						{
							treeNode2.Parent.Name,
							treeNode2.Name
						});
						if (this.OO._O0_0oo.().oOoO.O0o.().FindRows(treeNode2.Parent.Name).Length <= 1 && this.OO._O0_0oo.().OOO0oO.0OO0.()[num].Row.RowState == DataRowState.Added && num == 0)
						{
							this.OO._O0_0oo.().OOO0oO.0OO0.()[num].Row.Delete();
						}
					}
					this.oOooOO0.oo_oO.().Nodes.Clear();
					if (this.oOooOO0.oo_oO.().Level > 0)
					{
						try
						{
							foreach (TreeNode treeNode3 in o_O_o_oOoo__.OO_O0oO0.oooO_.(this.OO._O0_0oo.()))
							{
								if (treeNode3.Level > 0 && treeNode3 != this.oOooOO0.oo_oO.() && Operators.CompareString(treeNode3.Name, this.oOooOO0.oo_oO.().Name, true) == 0 && Operators.CompareString(treeNode3.Parent.Name, this.oOooOO0.oo_oO.().Parent.Name, true) == 0)
								{
									treeNode3.Nodes.Clear();
								}
							}
						}
						finally
						{
							List<TreeNode>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
				}
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00033328 File Offset: 0x00031528
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.oOooOO0.oo_oO.().Text.Trim(), "", true) > 0)
			{
				string key = this.oOooOO0.oo_oO.().Text.Trim();
				int num = this.OO._O0_0oo.().oOoO.O0o.().Find(key);
				if (num >= 0)
				{
					this.O_00OO.o_0o_.().Value = RuntimeHelpers.GetObjectValue(this.OO._O0_0oo.().oOoO.O0o.()[num][this.OO._O0_0oo.().o0O_Oo0_O._.]);
				}
			}
		}

		// Token: 0x040001EF RID: 495
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040001F0 RID: 496
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040001F1 RID: 497
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040001F2 RID: 498
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040001F3 RID: 499
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040001F4 RID: 500
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040001F5 RID: 501
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040001F6 RID: 502
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040001F7 RID: 503
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040001F8 RID: 504
		[CompilerGenerated]
		private TreeNode <<EMPTY_NAME>>;

		// Token: 0x040001F9 RID: 505
		[CompilerGenerated]
		private TreeNode <<EMPTY_NAME>>;

		// Token: 0x040001FA RID: 506
		[CompilerGenerated]
		private oo__ <<EMPTY_NAME>>;

		// Token: 0x040001FB RID: 507
		internal bool <<EMPTY_NAME>>;
	}
}
