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
	// Token: 0x0200019D RID: 413
	[DesignerGenerated]
	internal partial class o\u3002\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000 : Form
	{
		// Token: 0x0600136A RID: 4970 RVA: 0x0008559C File Offset: 0x0008379C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o0o.o0oO_. != null)
				{
					this.o0o.o0oO_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x000855DC File Offset: 0x000837DC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o.OO_0.(new TreeView());
			this.O__.oO_0.(new Label());
			this.ooO0o0O.0.(new C1TextBox());
			this.o.OO_0.(new Label());
			this.o.00oOo_.(new C1Button());
			this.oo00O._.(new C1Button());
			this.o.OO_0.(new C1TextBox());
			this.ooO0o0O.0.(new Label());
			base.SuspendLayout();
			this.o.00oOo_.().CheckBoxes = true;
			this.o.00oOo_.().Location = new Point(14, 138);
			this.o.00oOo_.().Name = "trvUsers";
			this.o.00oOo_.().Size = new Size(449, 388);
			this.o.00oOo_.().TabIndex = 2;
			this.o.00oOo_.().AutoSize = true;
			this.o.00oOo_.().Location = new Point(14, 15);
			this.o.00oOo_.().Name = "Label1";
			this.o.00oOo_.().Size = new Size(59, 12);
			this.o.00oOo_.().TabIndex = 1;
			this.o.00oOo_.().Text = "会议名称:";
			this.o.00oOo_.().Location = new Point(14, 36);
			this.o.00oOo_.().Name = "txtMeetingName";
			this.o.00oOo_.().Size = new Size(449, 21);
			this.o.00oOo_.().TabIndex = 0;
			this.oo00O._.().AutoSize = true;
			this.oo00O._.().Location = new Point(14, 117);
			this.oo00O._.().Name = "Label2";
			this.oo00O._.().Size = new Size(95, 12);
			this.oo00O._.().TabIndex = 3;
			this.oo00O._.().Text = "选择会议参与者:";
			this.o.00oOo_.().Location = new Point(159, 540);
			this.o.00oOo_.().Name = "btnOK";
			this.o.00oOo_.().Size = new Size(75, 23);
			this.o.00oOo_.().TabIndex = 3;
			this.o.00oOo_.().Text = "确定";
			this.o.00oOo_.().UseVisualStyleBackColor = true;
			this.o__00oOo.OOo__.().Location = new Point(240, 540);
			this.o__00oOo.OOo__.().Name = "btnCancel";
			this.o__00oOo.OOo__.().Size = new Size(75, 23);
			this.o__00oOo.OOo__.().TabIndex = 4;
			this.o__00oOo.OOo__.().Text = "取消";
			this.o__00oOo.OOo__.().UseVisualStyleBackColor = true;
			this.oo00O._.().Location = new Point(14, 87);
			this.oo00O._.().Name = "txtDescription";
			this.oo00O._.().Size = new Size(449, 21);
			this.oo00O._.().TabIndex = 1;
			this.o0.0O0o.().AutoSize = true;
			this.o0.0O0o.().Location = new Point(14, 66);
			this.o0.0O0o.().Name = "Label3";
			this.o0.0O0o.().Size = new Size(59, 12);
			this.o0.0O0o.().TabIndex = 5;
			this.o0.0O0o.().Text = "会议主题:";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(475, 575);
			base.Controls.Add(this.oo00O._.());
			base.Controls.Add(this.o0.0O0o.());
			base.Controls.Add(this.o__00oOo.OOo__.());
			base.Controls.Add(this.o.00oOo_.());
			base.Controls.Add(this.oo00O._.());
			base.Controls.Add(this.o.00oOo_.());
			base.Controls.Add(this.o.00oOo_.());
			base.Controls.Add(this.o.00oOo_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Oo00..o.";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "新建会议";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00085A19 File Offset: 0x00083C19
		[CompilerGenerated]
		internal virtual TreeView <<EMPTY_NAME>>()
		{
			return this.o0o.o0oO_.;
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00085A24 File Offset: 0x00083C24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TreeView A_0)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.o.OO_0.);
			TreeView treeView = this.o0o.o0oO_.;
			if (treeView != null)
			{
				treeView.AfterCheck -= value;
			}
			this.o0o.o0oO_. = A_0;
			treeView = this.o0o.o0oO_.;
			if (treeView != null)
			{
				treeView.AfterCheck += value;
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00085A67 File Offset: 0x00083C67
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.OO_0.;
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00085A6F File Offset: 0x00083C6F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.OO_0. = A_0;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00085A78 File Offset: 0x00083C78
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o0o.o0oO_.;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00085A80 File Offset: 0x00083C80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o0o.o0oO_. = A_0;
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00085A89 File Offset: 0x00083C89
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.ooOo_O0O._o.;
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00085A91 File Offset: 0x00083C91
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.ooOo_O0O._o. = A_0;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00085A9A File Offset: 0x00083C9A
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.OO_0.;
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00085AA4 File Offset: 0x00083CA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o__00oOo.OOo__.);
			C1Button c1Button = this.o.OO_0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.OO_0. = A_0;
			c1Button = this.o.OO_0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00085AE7 File Offset: 0x00083CE7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooO0o0O.0.;
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00085AF0 File Offset: 0x00083CF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o._0ooO.);
			C1Button c1Button = this.ooO0o0O.0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooO0o0O.0. = A_0;
			c1Button = this.ooO0o0O.0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00085B33 File Offset: 0x00083D33
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.ooOo_O0O._o.;
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00085B3B File Offset: 0x00083D3B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.ooOo_O0O._o. = A_0;
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00085B44 File Offset: 0x00083D44
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOoo__O0_.oO_.;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00085B4C File Offset: 0x00083D4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOoo__O0_.oO_. = A_0;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00085B58 File Offset: 0x00083D58
		internal o\u3002\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000(IMClient A_0, ImageList A_1)
		{
			base.Closed += this.Oo00oO0_O0.O0.;
			this.o.00oOo_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o0o.o0oO_. = A_0;
			TreeView treeView = this.o.00oOo_.();
			treeView.ImageList = A_1;
			try
			{
				foreach (IMBuddy imbuddy in this.o0o.o0oO_..Buddies)
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
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00085CA0 File Offset: 0x00083EA0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00085CAC File Offset: 0x00083EAC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.o.00oOo_.().Text.Trim(), "", true) == 0 || Operators.CompareString(this.oo00O._.().Text.Trim(), "", true) == 0)
			{
				MessageBox.Show("请输入会议名称和描述！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			List<IMBuddy> list = new List<IMBuddy>();
			try
			{
				foreach (object obj in this.o.00oOo_.().Nodes)
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
			this.o0o.o0oO_. = list;
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00085E04 File Offset: 0x00084004
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			if (A_1.Action == TreeViewAction.ByKeyboard || A_1.Action == TreeViewAction.ByMouse)
			{
				if (A_1.Node.Level == 0)
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
				if (!A_1.Node.Checked && A_1.Node.Parent.Checked)
				{
					A_1.Node.Parent.Checked = false;
				}
			}
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00085EC0 File Offset: 0x000840C0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040007BD RID: 1981
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040007BE RID: 1982
		[CompilerGenerated]
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x040007BF RID: 1983
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040007C0 RID: 1984
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040007C1 RID: 1985
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040007C2 RID: 1986
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007C3 RID: 1987
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007C4 RID: 1988
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040007C5 RID: 1989
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040007C6 RID: 1990
		private IMClient <<EMPTY_NAME>>;

		// Token: 0x040007C7 RID: 1991
		internal List<IMBuddy> <<EMPTY_NAME>>;
	}
}
