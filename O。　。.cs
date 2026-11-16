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
	// Token: 0x02000064 RID: 100
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3002\u3000\u3000 : Form
	{
		// Token: 0x0600036B RID: 875 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O.Oo0OO. != null)
				{
					this.O.Oo0OO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000C620 File Offset: 0x0000A820
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Oo_.o___.(new C1Button());
			this.o__O_0.o0OOO0.(new C1Button());
			this.Oo_.o___.(new oO_oO000oo());
			((ISupportInitialize)this.o__O_0.o0OOO0.()).BeginInit();
			((ISupportInitialize)this.Oo_.o___.()).BeginInit();
			base.SuspendLayout();
			this.o__O_0.o0OOO0.().Anchor = AnchorStyles.Bottom;
			this.o__O_0.o0OOO0.().DialogResult = DialogResult.Cancel;
			this.o__O_0.o0OOO0.().Location = new Point(259, 244);
			this.o__O_0.o0OOO0.().Name = "btnCancel";
			this.o__O_0.o0OOO0.().Size = new Size(75, 24);
			this.o__O_0.o0OOO0.().TabIndex = 2;
			this.o__O_0.o0OOO0.().Text = "取消";
			this.o__O_0.o0OOO0.().UseVisualStyleBackColor = true;
			this.Oo_.o___.().Anchor = AnchorStyles.Bottom;
			this.Oo_.o___.().DialogResult = DialogResult.OK;
			this.Oo_.o___.().Location = new Point(167, 244);
			this.Oo_.o___.().Name = "btnAccept";
			this.Oo_.o___.().Size = new Size(75, 24);
			this.Oo_.o___.().TabIndex = 1;
			this.Oo_.o___.().Text = "确定";
			this.Oo_.o___.().UseVisualStyleBackColor = true;
			this.Oo_.o___.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.Oo_.o___.().Location = new Point(12, 12);
			this.Oo_.o___.().Name = "txtSQL";
			this.Oo_.o___.().Size = new Size(477, 214);
			this.Oo_.o___.().TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(501, 281);
			base.Controls.Add(this.Oo_.o___.());
			base.Controls.Add(this.o__O_0.o0OOO0.());
			base.Controls.Add(this.Oo_.o___.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.....O0.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "属性";
			((ISupportInitialize)this.o__O_0.o0OOO0.()).EndInit();
			((ISupportInitialize)this.Oo_.o___.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000C877 File Offset: 0x0000AA77
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_.o___.;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000C87F File Offset: 0x0000AA7F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.Oo_.o___. = A_0;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000C888 File Offset: 0x0000AA88
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o__O_0.o0OOO0.;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000C890 File Offset: 0x0000AA90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o__O_0.o0OOO0. = A_0;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000C899 File Offset: 0x0000AA99
		[CompilerGenerated]
		internal virtual oO_oO000oo <<EMPTY_NAME>>()
		{
			return this.O.Oo0OO.;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000C8A1 File Offset: 0x0000AAA1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(oO_oO000oo A_0)
		{
			this.O.Oo0OO. = A_0;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000C8AA File Offset: 0x0000AAAA
		public O\u3002\u3000\u3002\u3000\u3000()
		{
			base.Closed += this.Oo_.o___.;
			this.Oo_.o___.();
			this.Oo_.o___.().oO.O_oo_o_O.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000C8EA File Offset: 0x0000AAEA
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040000AE RID: 174
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040000AF RID: 175
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040000B0 RID: 176
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040000B1 RID: 177
		[CompilerGenerated]
		private oO_oO000oo <<EMPTY_NAME>>;
	}
}
