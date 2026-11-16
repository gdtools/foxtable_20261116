using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using O0o0.00;

namespace Foxtable
{
	// Token: 0x02000114 RID: 276
	public class FontDialgA : FontDialog
	{
		// Token: 0x06000EB3 RID: 3763 RVA: 0x0007516C File Offset: 0x0007336C
		public new Task<DialogResult> ShowDialog()
		{
			FontDialgA.OOo0_ooo ooo0_ooo = default(FontDialgA.OOo0_ooo);
			ooo0_ooo.O0.O_o_O_O__O. = this;
			ooo0_ooo.O0.O_o_O_O__O. = -1;
			ooo0_ooo.O0.O_o_O_O__O. = AsyncTaskMethodBuilder<DialogResult>.Create();
			ooo0_ooo.O0.O_o_O_O__O..Start<FontDialgA.OOo0_ooo>(ref ooo0_ooo);
			return ooo0_ooo.O0.O_o_O_O__O..Task;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x000751B8 File Offset: 0x000733B8
		[CompilerGenerated]
		private DialogResult <<EMPTY_NAME>>()
		{
			FontDialgA.OO_o oo_o = new FontDialgA.OO_o();
			oo_o.O0.O_o_O_O__O. = this;
			oo_o.Oo_o00oO_.O. = DialogResult.Cancel;
			if (OO_00oOO.BaseMainForm != null)
			{
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(oo_o.Oo_o00oO_.O.));
			}
			return oo_o.Oo_o00oO_.O.;
		}

		// Token: 0x02000115 RID: 277
		[CompilerGenerated]
		internal sealed class OO_o
		{
			// Token: 0x06000EB6 RID: 3766 RVA: 0x00075205 File Offset: 0x00073405
			internal void <<EMPTY_NAME>>()
			{
				this.Oo_o00oO_.O. = this.O0.O_o_O_O__O..ShowDialog();
			}

			// Token: 0x040005B6 RID: 1462
			public DialogResult <<EMPTY_NAME>>;

			// Token: 0x040005B7 RID: 1463
			public FontDialgA <<EMPTY_NAME>>;
		}
	}
}
