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
	// Token: 0x02000357 RID: 855
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3002\u3002\u3000 : Form
	{
		// Token: 0x06003546 RID: 13638 RVA: 0x00170E78 File Offset: 0x0016F078
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o.o_o. != null)
				{
					this.o.o_o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x00170EB8 File Offset: 0x0016F0B8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O__ooooo.0.(new Label());
			this.O__ooooo.0.(new RadioButton());
			this.o00_oO.O_o.(new RadioButton());
			this.O__ooooo.0.(new C1CheckBox());
			this.O__ooooo.0.(new C1Button());
			this.o00_oO.O_o.(new C1Button());
			base.SuspendLayout();
			this.o_0._00O_0__O_.().AutoSize = true;
			this.o_0._00O_0__O_.().Location = new Point(21, 18);
			this.o_0._00O_0__O_.().Name = "Label1";
			this.o_0._00O_0__O_.().Size = new Size(47, 12);
			this.o_0._00O_0__O_.().TabIndex = 0;
			this.o_0._00O_0__O_.().Text = "请选择:";
			this.o00_oO.O_o.().AutoSize = true;
			this.o00_oO.O_o.().Checked = true;
			this.o00_oO.O_o.().Location = new Point(23, 55);
			this.o00_oO.O_o.().Name = "rdoRemain";
			this.o00_oO.O_o.().Size = new Size(95, 16);
			this.o00_oO.O_o.().TabIndex = 1;
			this.o00_oO.O_o.().TabStop = true;
			this.o00_oO.O_o.().Text = "保留本地附件";
			this.o00_oO.O_o.().UseVisualStyleBackColor = true;
			this.O__ooooo.0.().AutoSize = true;
			this.O__ooooo.0.().Location = new Point(23, 77);
			this.O__ooooo.0.().Name = "rdoDelete";
			this.O__ooooo.0.().Size = new Size(95, 16);
			this.O__ooooo.0.().TabIndex = 2;
			this.O__ooooo.0.().Text = "删除本地附件";
			this.O__ooooo.0.().UseVisualStyleBackColor = true;
			this.o_0._00O_0__O_.().AutoSize = true;
			this.o_0._00O_0__O_.().Location = new Point(237, 77);
			this.o_0._00O_0__O_.().Name = "chkAuto";
			this.o_0._00O_0__O_.().Size = new Size(96, 16);
			this.o_0._00O_0__O_.().TabIndex = 3;
			this.o_0._00O_0__O_.().Text = "以后不再提示";
			this.o_0._00O_0__O_.().UseVisualStyleBackColor = true;
			this.O0_00O.0_.().DialogResult = DialogResult.OK;
			this.O0_00O.0_.().Location = new Point(108, 121);
			this.O0_00O.0_.().Name = "Button1";
			this.O0_00O.0_.().Size = new Size(75, 23);
			this.O0_00O.0_.().TabIndex = 4;
			this.O0_00O.0_.().Text = "确定";
			this.O0_00O.0_.().UseVisualStyleBackColor = true;
			this.o_0._00O_0__O_.().DialogResult = DialogResult.Cancel;
			this.o_0._00O_0__O_.().Location = new Point(198, 121);
			this.o_0._00O_0__O_.().Name = "Button2";
			this.o_0._00O_0__O_.().Size = new Size(75, 23);
			this.o_0._00O_0__O_.().TabIndex = 5;
			this.o_0._00O_0__O_.().Text = "取消";
			this.o_0._00O_0__O_.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(380, 156);
			base.Controls.Add(this.o_0._00O_0__O_.());
			base.Controls.Add(this.O0_00O.0_.());
			base.Controls.Add(this.o_0._00O_0__O_.());
			base.Controls.Add(this.O__ooooo.0.());
			base.Controls.Add(this.o00_oO.O_o.());
			base.Controls.Add(this.o_0._00O_0__O_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o..o...O";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "确认";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x0017128B File Offset: 0x0016F48B
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.o_o.;
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00171293 File Offset: 0x0016F493
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.o_o. = A_0;
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x0017129C File Offset: 0x0016F49C
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o.o_o.;
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x001712A4 File Offset: 0x0016F4A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.o.o_o. = A_0;
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x001712AD File Offset: 0x0016F4AD
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O_.OoO0.;
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x001712B5 File Offset: 0x0016F4B5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O_.OoO0. = A_0;
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x001712BE File Offset: 0x0016F4BE
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o.o_o.;
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x001712C6 File Offset: 0x0016F4C6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o.o_o. = A_0;
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x001712CF File Offset: 0x0016F4CF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O__ooooo.0.;
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x001712D7 File Offset: 0x0016F4D7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O__ooooo.0. = A_0;
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x001712E0 File Offset: 0x0016F4E0
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_.OoO0.;
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x001712E8 File Offset: 0x0016F4E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O_.OoO0. = A_0;
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x001712F1 File Offset: 0x0016F4F1
		public O\u3002\u3002\u3002\u3002\u3000()
		{
			base.ControlAdded += this.o_0._00O_0__O_.;
			this.O__ooooo.0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x00171326 File Offset: 0x0016F526
		private void <<EMPTY_NAME>>(object A_0, ControlEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001575 RID: 5493
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001576 RID: 5494
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001577 RID: 5495
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001578 RID: 5496
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001579 RID: 5497
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400157A RID: 5498
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400157B RID: 5499
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
