using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200019E RID: 414
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class o\u3000\u3002o\u3000\u3002\u3002\u3002\u3002\u3000 : Form
	{
		// Token: 0x06001381 RID: 4993 RVA: 0x00085ED4 File Offset: 0x000840D4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oo.ooOOoo. != null)
				{
					this.oo.ooOOoo..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00085F14 File Offset: 0x00084114
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_OOo.O_O.(new C1Button());
			this.o0.o_0Oo_OO0o.(new C1Button());
			this.o0.o_0Oo_OO0o.(new Label());
			this.o0.o_0Oo_OO0o.(new TreeView());
			base.SuspendLayout();
			this.O0_00._O.().Location = new Point(242, 473);
			this.O0_00._O.().Name = "btnCancel";
			this.O0_00._O.().Size = new Size(75, 23);
			this.O0_00._O.().TabIndex = 8;
			this.O0_00._O.().Text = "取消";
			this.O0_00._O.().UseVisualStyleBackColor = true;
			this.oO_o_0_o.0_.().Location = new Point(161, 473);
			this.oO_o_0_o.0_.().Name = "btnOK";
			this.oO_o_0_o.0_.().Size = new Size(75, 23);
			this.oO_o_0_o.0_.().TabIndex = 7;
			this.oO_o_0_o.0_.().Text = "确定";
			this.oO_o_0_o.0_.().UseVisualStyleBackColor = true;
			this.oO_o_0_o.0_.().AutoSize = true;
			this.oO_o_0_o.0_.().Location = new Point(14, 12);
			this.oO_o_0_o.0_.().Name = "Label2";
			this.oO_o_0_o.0_.().Size = new Size(95, 12);
			this.oO_o_0_o.0_.().TabIndex = 6;
			this.oO_o_0_o.0_.().Text = "选择会议参与者:";
			this.o0.o_0Oo_OO0o.().CheckBoxes = true;
			this.o0.o_0Oo_OO0o.().Location = new Point(16, 35);
			this.o0.o_0Oo_OO0o.().Name = "trvUsers";
			this.o0.o_0Oo_OO0o.().Size = new Size(449, 419);
			this.o0.o_0Oo_OO0o.().TabIndex = 5;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(479, 508);
			base.Controls.Add(this.O0_00._O.());
			base.Controls.Add(this.oO_o_0_o.0_.());
			base.Controls.Add(this.oO_o_0_o.0_.());
			base.Controls.Add(this.o0.o_0Oo_OO0o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.....0.";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "选择会议参与者";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00086190 File Offset: 0x00084390
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0.o_0Oo_OO0o.;
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00086198 File Offset: 0x00084398
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0_00._O.);
			C1Button c1Button = this.o0.o_0Oo_OO0o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0.o_0Oo_OO0o. = A_0;
			c1Button = this.o0.o_0Oo_OO0o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x000861DB File Offset: 0x000843DB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_OOo.O_O.;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x000861E4 File Offset: 0x000843E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO_o_0_o.0_.);
			C1Button c1Button = this.o_OOo.O_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_OOo.O_O. = A_0;
			c1Button = this.o_OOo.O_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00086227 File Offset: 0x00084427
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0.o_0Oo_OO0o.;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0008622F File Offset: 0x0008442F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0.o_0Oo_OO0o. = A_0;
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00086238 File Offset: 0x00084438
		[CompilerGenerated]
		internal virtual TreeView <<EMPTY_NAME>>()
		{
			return this.oo.ooOOoo.;
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00086240 File Offset: 0x00084440
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TreeView A_0)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.o0.o_0Oo_OO0o.);
			TreeView treeView = this.oo.ooOOoo.;
			if (treeView != null)
			{
				treeView.AfterCheck -= value;
			}
			this.oo.ooOOoo. = A_0;
			treeView = this.oo.ooOOoo.;
			if (treeView != null)
			{
				treeView.AfterCheck += value;
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00086284 File Offset: 0x00084484
		public o\u3000\u3002o\u3000\u3002\u3002\u3002\u3002\u3000(IMClient A_0, ImageList A_1, List<IMBuddy> A_2)
		{
			base.FormClosed += this.oO_o_0_o.0_.;
			this.o0.o_0Oo_OO0o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oo.ooOOoo. = A_0;
			TreeView treeView = this.o0.o_0Oo_OO0o.();
			treeView.ImageList = A_1;
			try
			{
				foreach (IMBuddy imbuddy in this.oo.ooOOoo..Buddies)
				{
					if (!imbuddy.FromWeChat)
					{
						string text = imbuddy.UserGroup;
						string text2 = imbuddy.SimpleName;
						if (!treeView.Nodes.ContainsKey(text))
						{
							TreeNode treeNode = treeView.Nodes.Add(text, text);
							treeNode.ImageKey = "group";
							treeNode.SelectedImageKey = "group";
						}
						TreeNode treeNode2 = treeView.Nodes[text].Nodes.Add(text2, text2);
						treeNode2.Tag = imbuddy;
						if (imbuddy.OnLine)
						{
							treeNode2.ImageKey = "online2";
							treeNode2.SelectedImageKey = "online2";
						}
						else
						{
							treeNode2.ImageKey = "offline2";
							treeNode2.SelectedImageKey = "offline2";
						}
						if (A_2.Contains(imbuddy))
						{
							treeNode2.Checked = true;
						}
					}
				}
			}
			finally
			{
				IEnumerator<IMBuddy> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (object obj in this.o0.o_0Oo_OO0o.().Nodes)
				{
					TreeNode treeNode3 = (TreeNode)obj;
					int num = 0;
					try
					{
						IEnumerator enumerator3 = treeNode3.Nodes.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							if (((TreeNode)enumerator3.Current).Checked)
							{
								num++;
							}
						}
					}
					finally
					{
						IEnumerator enumerator3;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					if (num == treeNode3.Nodes.Count)
					{
						treeNode3.Checked = true;
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0008649C File Offset: 0x0008469C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x000864A8 File Offset: 0x000846A8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			List<IMBuddy> list = new List<IMBuddy>();
			try
			{
				foreach (object obj in this.o0.o_0Oo_OO0o.().Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					try
					{
						foreach (object obj2 in treeNode.Nodes)
						{
							TreeNode treeNode2 = (TreeNode)obj2;
							if (treeNode2.Checked)
							{
								list.Add((IMBuddy)treeNode2.Tag);
							}
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
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
			if (list.Count < 2)
			{
				MessageBox.Show("请至少选择两个以上的好友参与会议!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (list.Count > 50)
			{
				MessageBox.Show("参与会议的好友不能超过50!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			this.oo.ooOOoo. = list;
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x000865B4 File Offset: 0x000847B4
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			if (A_1.Node.Level == 0 && (A_1.Action == TreeViewAction.ByMouse || A_1.Action == TreeViewAction.ByKeyboard))
			{
				try
				{
					foreach (object obj in A_1.Node.Nodes)
					{
						((TreeNode)obj).Checked = A_1.Node.Checked;
					}
					return;
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
			if (A_1.Node.Level == 1 && !A_1.Node.Checked)
			{
				A_1.Node.Parent.Checked = false;
			}
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0008666C File Offset: 0x0008486C
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040007C8 RID: 1992
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040007C9 RID: 1993
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007CA RID: 1994
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007CB RID: 1995
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040007CC RID: 1996
		[CompilerGenerated]
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x040007CD RID: 1997
		private IMClient <<EMPTY_NAME>>;

		// Token: 0x040007CE RID: 1998
		internal List<IMBuddy> <<EMPTY_NAME>>;
	}
}
