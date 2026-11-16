using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using O0o0.00;

namespace Foxtable
{
	// Token: 0x02000106 RID: 262
	public class ColorDialogA : ColorDialog
	{
		// Token: 0x06000E7A RID: 3706 RVA: 0x0007471C File Offset: 0x0007291C
		public new Task<DialogResult> ShowDialog()
		{
			ColorDialogA.O0o_ o0o_ = default(ColorDialogA.O0o_);
			o0o_.OOo.o0o. = this;
			o0o_.OOo.o0o. = -1;
			o0o_.OOo.o0o. = AsyncTaskMethodBuilder<DialogResult>.Create();
			o0o_.OOo.o0o..Start<ColorDialogA.O0o_>(ref o0o_);
			return o0o_.OOo.o0o..Task;
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00074768 File Offset: 0x00072968
		[CompilerGenerated]
		private DialogResult <<EMPTY_NAME>>()
		{
			ColorDialogA.Oo0_0000_0 oo0_0000_ = new ColorDialogA.Oo0_0000_0();
			oo0_0000_.OOo.o0o. = this;
			oo0_0000_.o_o_O.0000_O. = DialogResult.Cancel;
			if (OO_00oOO.BaseMainForm != null)
			{
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(oo0_0000_.o_o_O.0000_O.));
			}
			return oo0_0000_.o_o_O.0000_O.;
		}

		// Token: 0x02000107 RID: 263
		[CompilerGenerated]
		internal sealed class Oo0_0000_0
		{
			// Token: 0x06000E7D RID: 3709 RVA: 0x000747B5 File Offset: 0x000729B5
			internal void <<EMPTY_NAME>>()
			{
				this.o_o_O.0000_O. = this.OOo.o0o..ShowDialog();
			}

			// Token: 0x04000590 RID: 1424
			public DialogResult <<EMPTY_NAME>>;

			// Token: 0x04000591 RID: 1425
			public ColorDialogA <<EMPTY_NAME>>;
		}
	}
}
