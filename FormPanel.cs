using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003EA RID: 1002
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FormPanel : UserControl
	{
		// Token: 0x06004138 RID: 16696 RVA: 0x001D7C50 File Offset: 0x001D5E50
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.ooOo.o_. != null)
				{
					this.ooOo.o_..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x001D7C90 File Offset: 0x001D5E90
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.ooOo.o_. = new Container();
			this.ToolTip1 = new ToolTip(this.ooOo.o_.);
			this.PrintPropExtender1 = new OoOO0ooo();
			this.ErrorProvider1 = new ErrorProvider(this.ooOo.o_.);
			((ISupportInitialize)this.ErrorProvider1).BeginInit();
			base.SuspendLayout();
			this.ToolTip1.ToolTipIcon = ToolTipIcon.Info;
			this.ErrorProvider1.ContainerControl = this;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "o..0.Oo.";
			base.Size = new Size(345, 311);
			((ISupportInitialize)this.ErrorProvider1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x001D7D4C File Offset: 0x001D5F4C
		// (set) Token: 0x0600413B RID: 16699 RVA: 0x001D7D54 File Offset: 0x001D5F54
		internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x001D7D5D File Offset: 0x001D5F5D
		// (set) Token: 0x0600413D RID: 16701 RVA: 0x001D7D65 File Offset: 0x001D5F65
		internal virtual OoOO0ooo PrintPropExtender1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x0600413E RID: 16702 RVA: 0x001D7D6E File Offset: 0x001D5F6E
		// (set) Token: 0x0600413F RID: 16703 RVA: 0x001D7D76 File Offset: 0x001D5F76
		internal virtual ErrorProvider ErrorProvider1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06004140 RID: 16704 RVA: 0x001D7D7F File Offset: 0x001D5F7F
		public FormPanel()
		{
			this.O00O00o_oOo.o_.();
			this.DoubleBuffered = true;
		}

		// Token: 0x04001A4E RID: 6734
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001A4F RID: 6735
		[AccessedThroughProperty("ToolTip1")]
		[CompilerGenerated]
		private ToolTip <<EMPTY_NAME>>;

		// Token: 0x04001A50 RID: 6736
		[CompilerGenerated]
		[AccessedThroughProperty("PrintPropExtender1")]
		private OoOO0ooo <<EMPTY_NAME>>;

		// Token: 0x04001A51 RID: 6737
		[CompilerGenerated]
		[AccessedThroughProperty("ErrorProvider1")]
		private ErrorProvider <<EMPTY_NAME>>;

		// Token: 0x04001A52 RID: 6738
		internal OooO00O <<EMPTY_NAME>>;

		// Token: 0x04001A53 RID: 6739
		internal Table <<EMPTY_NAME>>;

		// Token: 0x04001A54 RID: 6740
		internal Col <<EMPTY_NAME>>;

		// Token: 0x04001A55 RID: 6741
		internal int <<EMPTY_NAME>>;

		// Token: 0x04001A56 RID: 6742
		internal System.Windows.Forms.Control <<EMPTY_NAME>>;

		// Token: 0x04001A57 RID: 6743
		internal string <<EMPTY_NAME>>;

		// Token: 0x020003EB RID: 1003
		// (Invoke) Token: 0x06004144 RID: 16708
		public delegate void O0_00(Foxtable.WinForm.Form A_0);
	}
}
