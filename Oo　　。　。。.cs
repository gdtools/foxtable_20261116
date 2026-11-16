using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000269 RID: 617
	[DesignerGenerated]
	internal partial class Oo\u3000\u3000\u3002\u3000\u3002\u3002 : O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000
	{
		// Token: 0x06001D76 RID: 7542 RVA: 0x000CA664 File Offset: 0x000C8864
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O0o_o.o0. != null)
				{
					this.O0o_o.o0..Dispose();
				}
			}
			finally
			{
				base.O0oO.0o_0O0_O.(A_0);
			}
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x000CA6A4 File Offset: 0x000C88A4
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0o_o.o0.(new C1Button());
			this.O.0oOO.(new C1Button());
			this.O_o__00._ooOoO.(new C1Button());
			base.SuspendLayout();
			this.O.0oOO.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O.0oOO.().Location = new Point(283, 383);
			this.O.0oOO.().Name = "btnSaveAs";
			this.O.0oOO.().Size = new Size(90, 23);
			this.O.0oOO.().TabIndex = 16;
			this.O.0oOO.().Text = "另存为";
			this.O.0oOO.().UseVisualStyleBackColor = true;
			this.O_o__00._ooOoO.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O_o__00._ooOoO.().Location = new Point(283, 327);
			this.O_o__00._ooOoO.().Name = "btnOpen";
			this.O_o__00._ooOoO.().Size = new Size(90, 23);
			this.O_o__00._ooOoO.().TabIndex = 14;
			this.O_o__00._ooOoO.().Text = "打开";
			this.O_o__00._ooOoO.().UseVisualStyleBackColor = true;
			this.o_o0O0o00_0._.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.o_o0O0o00_0._.().Location = new Point(282, 355);
			this.o_o0O0o00_0._.().Name = "btnSave";
			this.o_o0O0o00_0._.().Size = new Size(91, 23);
			this.o_o0O0o00_0._.().TabIndex = 15;
			this.o_o0O0o00_0._.().Text = "保存";
			this.o_o0O0o00_0._.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(384, 418);
			base.Controls.Add(this.O.0oOO.());
			base.Controls.Add(this.O_o__00._ooOoO.());
			base.Controls.Add(this.o_o0O0o00_0._.());
			base.Name = "o00.o...";
			this.Text = "目录树编辑器";
			base.Controls.SetChildIndex(this.o_o0O0o00_0._.(), 0);
			base.Controls.SetChildIndex(this.O_o__00._ooOoO.(), 0);
			base.Controls.SetChildIndex(this.O.0oOO.(), 0);
			base.ResumeLayout(false);
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x000CA8EB File Offset: 0x000C8AEB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0o_o.o0.;
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x000CA8F4 File Offset: 0x000C8AF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_o0O0o00_0._.);
			C1Button o0o_o.o0. = this.O0o_o.o0.;
			if (o0o_o.o0. != null)
			{
				o0o_o.o0..Click -= value;
			}
			this.O0o_o.o0. = A_0;
			o0o_o.o0. = this.O0o_o.o0.;
			if (o0o_o.o0. != null)
			{
				o0o_o.o0..Click += value;
			}
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x000CA937 File Offset: 0x000C8B37
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_0_.oO_OoO.;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x000CA940 File Offset: 0x000C8B40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o00._OO000.);
			C1Button c1Button = this.o_0_.oO_OoO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_0_.oO_OoO. = A_0;
			c1Button = this.o_0_.oO_OoO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x000CA983 File Offset: 0x000C8B83
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o._OoOO_0.;
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x000CA98C File Offset: 0x000C8B8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O._0Oo_0.);
			C1Button c1Button = this.o._OoOO_0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o._OoOO_0. = A_0;
			c1Button = this.o._OoOO_0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000CA9D0 File Offset: 0x000C8BD0
		public Oo\u3000\u3000\u3002\u3000\u3002\u3002()
		{
			base.FormClosing += this.o_o0O0o00_0._.;
			base.FormClosed += this.o_o0O0o00_0._.;
			this.o_o0O0o00_0._.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "Office2013Green");
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x000CAA24 File Offset: 0x000C8C24
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			if (this.o0Oo_O.0.)
			{
				DialogResult dialogResult = MessageBox.Show("是否保存修改?", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					this.o_o0O0o00_0._.().PerformClick();
					if (this.o0Oo_O.0.)
					{
						A_1.Cancel = true;
						return;
					}
					base.DialogResult = DialogResult.OK;
					return;
				}
				else if (dialogResult == DialogResult.Cancel)
				{
					A_1.Cancel = true;
				}
			}
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x000CAA80 File Offset: 0x000C8C80
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0Oo_O.0.)
			{
				DialogResult dialogResult = MessageBox.Show("是否保存修改?", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					this.o_o0O0o00_0._.().PerformClick();
					if (this.o0Oo_O.0.)
					{
						return;
					}
				}
				else if (dialogResult == DialogResult.Cancel)
				{
					return;
				}
			}
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
			this.o0Oo_O.0. = false;
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x000CAB68 File Offset: 0x000C8D68
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.o0Oo_O.0., "", true) == 0)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "目录树文件(*.foxtr)|*.foxtr";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.o0Oo_O.0. = saveFileDialog.FileName;
				}
			}
			if (Operators.CompareString(this.o0Oo_O.0., "", true) > 0)
			{
				this.oOO00_Ooo.Oo..Save(this.o0Oo_O.0., false);
				this.o0Oo_O.0. = false;
			}
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x000CABDC File Offset: 0x000C8DDC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "目录树文件(*.foxtr)|*.foxtr";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.o0Oo_O.0. = saveFileDialog.FileName;
				this.oOO00_Ooo.Oo..Save(this.o0Oo_O.0., false);
				this.o0Oo_O.0. = false;
			}
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000CAC28 File Offset: 0x000C8E28
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000C8D RID: 3213
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000C8E RID: 3214
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000C8F RID: 3215
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000C90 RID: 3216
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
