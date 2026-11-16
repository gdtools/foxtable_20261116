using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002BD RID: 701
	[DesignerGenerated]
	internal partial class O\u3002o : O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000
	{
		// Token: 0x06002624 RID: 9764 RVA: 0x0011A1B8 File Offset: 0x001183B8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.ooO00.0o0. != null)
				{
					this.ooO00.0o0..Dispose();
				}
			}
			finally
			{
				base.O0oO.0o_0O0_O.(A_0);
			}
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x0011A1F8 File Offset: 0x001183F8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o.OOooOO.(new C1Button());
			this.oO__.OOO_0OO_O.(new C1Button());
			this.O._oO0O.(new C1Button());
			this.oO000.0_Oo.(new C1Button());
			base.SuspendLayout();
			this.oO__.OOO_0OO_O.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.oO__.OOO_0OO_O.().Location = new Point(282, 292);
			this.oO__.OOO_0OO_O.().Name = "btnSaveAs";
			this.oO__.OOO_0OO_O.().Size = new Size(91, 23);
			this.oO__.OOO_0OO_O.().TabIndex = 11;
			this.oO__.OOO_0OO_O.().Text = "保存为文件";
			this.oO__.OOO_0OO_O.().UseVisualStyleBackColor = true;
			this.oO000.0_Oo.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.oO000.0_Oo.().Location = new Point(282, 321);
			this.oO000.0_Oo.().Name = "btnOpen";
			this.oO000.0_Oo.().Size = new Size(91, 23);
			this.oO000.0_Oo.().TabIndex = 12;
			this.oO000.0_Oo.().Text = "从文件生成";
			this.oO000.0_Oo.().UseVisualStyleBackColor = true;
			this.O._0o0_00OOo.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O._0o0_00OOo.().Location = new Point(293, 420);
			this.O._0o0_00OOo.().Name = "btnCancel";
			this.O._0o0_00OOo.().Size = new Size(80, 23);
			this.O._0o0_00OOo.().TabIndex = 13;
			this.O._0o0_00OOo.().Text = "取消";
			this.O._0o0_00OOo.().UseVisualStyleBackColor = true;
			this.oOO00_Ooo.Oo.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.oOO00_Ooo.Oo.().Location = new Point(210, 420);
			this.oOO00_Ooo.Oo.().Name = "btnOK";
			this.oOO00_Ooo.Oo.().Size = new Size(77, 23);
			this.oOO00_Ooo.Oo.().TabIndex = 14;
			this.oOO00_Ooo.Oo.().Text = "确定";
			this.oOO00_Ooo.Oo.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(384, 455);
			base.Controls.Add(this.oOO00_Ooo.Oo.());
			base.Controls.Add(this.O._0o0_00OOo.());
			base.Controls.Add(this.oO__.OOO_0OO_O.());
			base.Controls.Add(this.oO000.0_Oo.());
			base.Name = "O0O.o...";
			base.Controls.SetChildIndex(this.oO000.0_Oo.(), 0);
			base.Controls.SetChildIndex(this.oO__.OOO_0OO_O.(), 0);
			base.Controls.SetChildIndex(this.O._0o0_00OOo.(), 0);
			base.Controls.SetChildIndex(this.oOO00_Ooo.Oo.(), 0);
			base.ResumeLayout(false);
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x0011A4D6 File Offset: 0x001186D6
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooO00.0o0.;
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x0011A4E0 File Offset: 0x001186E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O._0o0_00OOo.);
			C1Button c1Button = this.ooO00.0o0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooO00.0o0. = A_0;
			c1Button = this.ooO00.0o0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x0011A523 File Offset: 0x00118723
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O._oO0O.;
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x0011A52C File Offset: 0x0011872C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOO00_Ooo.Oo.);
			C1Button o._oO0O. = this.O._oO0O.;
			if (o._oO0O. != null)
			{
				o._oO0O..Click -= value;
			}
			this.O._oO0O. = A_0;
			o._oO0O. = this.O._oO0O.;
			if (o._oO0O. != null)
			{
				o._oO0O..Click += value;
			}
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x0011A56F File Offset: 0x0011876F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO000.0_Oo.;
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x0011A578 File Offset: 0x00118778
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OOOOo00_.__O.);
			C1Button c1Button = this.oO000.0_Oo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO000.0_Oo. = A_0;
			c1Button = this.oO000.0_Oo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x0011A5BB File Offset: 0x001187BB
		[CompilerGenerated]
		internal new virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO__.OOO_0OO_O.;
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x0011A5C4 File Offset: 0x001187C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_.o_o.);
			C1Button c1Button = this.oO__.OOO_0OO_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO__.OOO_0OO_O. = A_0;
			c1Button = this.oO__.OOO_0OO_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x0011A608 File Offset: 0x00118808
		private new void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			if (this.o0Oo_O.0.)
			{
				DialogResult dialogResult = MessageBox.Show("是否保存修改?", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					this.oOO00_Ooo.Oo.().PerformClick();
					return;
				}
				if (dialogResult == DialogResult.Cancel)
				{
					A_1.Cancel = true;
				}
			}
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x0011A64C File Offset: 0x0011884C
		public O\u3002o(System.Windows.Forms.TreeView A_0)
		{
			base.FormClosing += this.oOO00_Ooo.Oo.;
			base.FormClosed += this.oOO00_Ooo.Oo.;
			this.o.OOooOO.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "Office2013Green");
			this.ooO00.0o0. = A_0;
			this.OOo_Oo.oooo.().CheckBoxes = A_0.CheckBoxes;
			Foxtable.WinForm.TreeView treeView = new Foxtable.WinForm.TreeView(this.OOo_Oo.oooo.());
			string nodesSettingString = null;
			oOO0oo_o0.O__o0o0O0O_.0.(A_0.Nodes, ref nodesSettingString);
			treeView.NodesSettingString = nodesSettingString;
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x0011A6D6 File Offset: 0x001188D6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0Oo_O.0. = false;
			base.Close();
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x0011A6E8 File Offset: 0x001188E8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Foxtable.WinForm.TreeView treeView = new Foxtable.WinForm.TreeView(this.ooO00.0o0.);
			string nodesSettingString = null;
			oOO0oo_o0.O__o0o0O0O_.0.(this.OOo_Oo.oooo.().Nodes, ref nodesSettingString);
			treeView.Nodes.Clear();
			treeView.NodesSettingString = nodesSettingString;
			this.o0Oo_O.0. = false;
			base.Close();
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x0011A734 File Offset: 0x00118934
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "目录树文件(*.foxtr)|*.foxtr";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.o0Oo_O.0. = saveFileDialog.FileName;
				this.oOO00_Ooo.Oo..Save(this.o0Oo_O.0., false);
			}
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x0011A77C File Offset: 0x0011897C
		private new void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "目录树文件(*.foxtr)|*.foxtr";
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) != 0)
			{
				openFileDialog.InitialDirectory = OO_00oOO.ProjectPath + "\\Attachments";
			}
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.oOO00_Ooo.Oo..Load(openFileDialog.FileName);
				this.o0Oo_O.0. = openFileDialog.FileName;
				if (this.OOo_Oo.oooo.().Nodes.Count > 0)
				{
					this.OOo_Oo.oooo.().SelectedNode = this.OOo_Oo.oooo.().Nodes[0];
					this.OOo_Oo.oooo.().Focus();
				}
			}
			this.o0Oo_O.0. = true;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x0011A829 File Offset: 0x00118A29
		private new void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000FD2 RID: 4050
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000FD3 RID: 4051
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000FD4 RID: 4052
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000FD5 RID: 4053
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000FD6 RID: 4054
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000FD7 RID: 4055
		private System.Windows.Forms.TreeView <<EMPTY_NAME>>;
	}
}
