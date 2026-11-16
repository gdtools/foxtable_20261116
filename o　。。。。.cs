using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200036E RID: 878
	[DesignerGenerated]
	internal partial class o\u3000\u3002\u3002\u3002\u3002 : Form
	{
		// Token: 0x060037D4 RID: 14292 RVA: 0x0018C92C File Offset: 0x0018AB2C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o0__.Oo0O_O0O_. != null)
				{
					this.o0__.Oo0O_O0O_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x0018C96C File Offset: 0x0018AB6C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0__.Oo0O_O0O_.(new Label());
			base.SuspendLayout();
			this.o0__.Oo0O_O0O_.().Location = new Point(29, 24);
			this.o0__.Oo0O_O0O_.().Name = "Label1";
			this.o0__.Oo0O_O0O_.().Size = new Size(196, 16);
			this.o0__.Oo0O_O0O_.().TabIndex = 0;
			this.o0__.Oo0O_O0O_.().Text = "正在打开文件，请稍候...";
			this.o0__.Oo0O_O0O_.().TextAlign = ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Azure;
			base.ClientSize = new Size(254, 58);
			base.ControlBox = false;
			base.Controls.Add(this.o0__.Oo0O_O0O_.());
			base.FormBorderStyle = FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O....0..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			base.TopMost = true;
			base.ResumeLayout(false);
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x0018CA82 File Offset: 0x0018AC82
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0__.Oo0O_O0O_.;
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x0018CA8A File Offset: 0x0018AC8A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0__.Oo0O_O0O_. = A_0;
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x0018CA94 File Offset: 0x0018AC94
		public o\u3000\u3002\u3002\u3002\u3002()
		{
			base.FormClosed += this.o0__.Oo0O_O0O_.;
			this.o0__.Oo0O_O0O_.();
			if (Main.OO_O.o. != null)
			{
				Main.OO_O.o..o.O000oo.(new object[]
				{
					this
				});
				return;
			}
			this.BackColor = Color.FromArgb(207, 221, 208);
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x0018CAF5 File Offset: 0x0018ACF5
		internal string <<EMPTY_NAME>>()
		{
			return this.o0__.Oo0O_O0O_.().Text;
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x0018CB02 File Offset: 0x0018AD02
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.o0__.Oo0O_O0O_.().Text = A_0;
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x0018CB10 File Offset: 0x0018AD10
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			if (Main.OO_O.o. != null)
			{
				Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
				{
					this
				});
			}
		}

		// Token: 0x040016CF RID: 5839
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040016D0 RID: 5840
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;
	}
}
