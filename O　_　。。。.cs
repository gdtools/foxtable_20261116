using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200036D RID: 877
	[DesignerGenerated]
	internal partial class O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000 : Form
	{
		// Token: 0x060037CD RID: 14285 RVA: 0x0018C73C File Offset: 0x0018A93C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O.oO0_. != null)
				{
					this.O.oO0_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x0018C77C File Offset: 0x0018A97C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O.oO0_.(new PictureViewer());
			base.SuspendLayout();
			this.O.oO0_.().AutoScroll = true;
			this.O.oO0_.().BackColor = SystemColors.ControlLightLight;
			this.O.oO0_.().Dock = DockStyle.Fill;
			this.O.oO0_.().ImageFiles = null;
			this.O.oO0_.().Location = new Point(0, 0);
			this.O.oO0_.().Name = "PictureViewer1";
			this.O.oO0_.().ReadOnly = BooleanEnum.Default;
			this.O.oO0_.().Size = new Size(703, 471);
			this.O.oO0_.().SizeMode = PictureBoxSizeMode.Zoom;
			this.O.oO0_.().TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(703, 471);
			base.Controls.Add(this.O.oO0_.());
			base.Name = "O...oo..";
			base.ShowIcon = false;
			this.Text = "图片浏览";
			base.WindowState = FormWindowState.Maximized;
			base.ResumeLayout(false);
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x0018C89B File Offset: 0x0018AA9B
		public O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000()
		{
			base.FormClosing += this.O.oO0_.;
			base.Load += this.O.oO0_.;
			this.O.oO0_.();
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x0018C8CD File Offset: 0x0018AACD
		[CompilerGenerated]
		internal virtual PictureViewer <<EMPTY_NAME>>()
		{
			return this.O.oO0_.;
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x0018C8D5 File Offset: 0x0018AAD5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PictureViewer A_0)
		{
			this.O.oO0_. = A_0;
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x0018C8DE File Offset: 0x0018AADE
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			this.O.oO0_.().DataBindings[0].WriteValue();
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x0018C8F6 File Offset: 0x0018AAF6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.oO0_.().PrevRecord.Visible = true;
			this.O.oO0_.().NextRecord.Visible = true;
			this.O.oO0_.().Full.Visible = false;
		}

		// Token: 0x040016CD RID: 5837
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040016CE RID: 5838
		[CompilerGenerated]
		private PictureViewer <<EMPTY_NAME>>;
	}
}
