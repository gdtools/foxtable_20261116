using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using O0o0.00;

namespace Foxtable
{
	// Token: 0x0200010E RID: 270
	public class FolderBrowserDialogA
	{
		// Token: 0x06000E96 RID: 3734 RVA: 0x00074C03 File Offset: 0x00072E03
		public FolderBrowserDialogA()
		{
			this.Oo000o.O_OOO. = new FolderBrowserDialog();
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00074C18 File Offset: 0x00072E18
		public Task<DialogResult> ShowDialog()
		{
			FolderBrowserDialogA.O_OOO0 o_OOO = default(FolderBrowserDialogA.O_OOO0);
			o_OOO.oO_O__OO.___O. = this;
			o_OOO.oO_O__OO.___O. = -1;
			o_OOO.oO_O__OO.___O. = AsyncTaskMethodBuilder<DialogResult>.Create();
			o_OOO.oO_O__OO.___O..Start<FolderBrowserDialogA.O_OOO0>(ref o_OOO);
			return o_OOO.oO_O__OO.___O..Task;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00074C63 File Offset: 0x00072E63
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x00074C70 File Offset: 0x00072E70
		public string Description
		{
			get
			{
				return this.Oo000o.O_OOO..Description;
			}
			set
			{
				this.Oo000o.O_OOO..Description = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00074C7E File Offset: 0x00072E7E
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x00074C8B File Offset: 0x00072E8B
		public string SelectedPath
		{
			get
			{
				return this.Oo000o.O_OOO..SelectedPath;
			}
			set
			{
				this.Oo000o.O_OOO..SelectedPath = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x00074C99 File Offset: 0x00072E99
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x00074CA6 File Offset: 0x00072EA6
		public bool ShowNewFolderButton
		{
			get
			{
				return this.Oo000o.O_OOO..ShowNewFolderButton;
			}
			set
			{
				this.Oo000o.O_OOO..ShowNewFolderButton = value;
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00074CB4 File Offset: 0x00072EB4
		[CompilerGenerated]
		private DialogResult <<EMPTY_NAME>>()
		{
			FolderBrowserDialogA.OO0Oo_oO0o oo0Oo_oO0o = new FolderBrowserDialogA.OO0Oo_oO0o();
			oo0Oo_oO0o.Oo000o.O_OOO. = this;
			oo0Oo_oO0o.Oo000o.O_OOO. = DialogResult.Cancel;
			if (OO_00oOO.BaseMainForm != null)
			{
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(oo0Oo_oO0o.Oo000o.O_OOO.));
			}
			return oo0Oo_oO0o.Oo000o.O_OOO.;
		}

		// Token: 0x040005A3 RID: 1443
		private FolderBrowserDialog <<EMPTY_NAME>>;

		// Token: 0x0200010F RID: 271
		[CompilerGenerated]
		internal sealed class OO0Oo_oO0o
		{
			// Token: 0x06000EA0 RID: 3744 RVA: 0x00074D01 File Offset: 0x00072F01
			internal void <<EMPTY_NAME>>()
			{
				this.Oo000o.O_OOO. = this.Oo000o.O_OOO..Oo000o.O_OOO..ShowDialog();
			}

			// Token: 0x040005A4 RID: 1444
			public DialogResult <<EMPTY_NAME>>;

			// Token: 0x040005A5 RID: 1445
			public FolderBrowserDialogA <<EMPTY_NAME>>;
		}
	}
}
