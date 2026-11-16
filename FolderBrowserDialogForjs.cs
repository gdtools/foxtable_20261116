using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using O0o0.00;

namespace Foxtable
{
	// Token: 0x02000111 RID: 273
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class FolderBrowserDialogForjs
	{
		// Token: 0x06000EA3 RID: 3747 RVA: 0x00074DFE File Offset: 0x00072FFE
		public FolderBrowserDialogForjs(WebViewer A_0)
		{
			this.O_o.oOO000oO. = null;
			this.O_o.oOO000oO. = null;
			this.O_o.oOO000oO. = A_0;
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x00074E1B File Offset: 0x0007301B
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x00074E23 File Offset: 0x00073023
		public string CallBack { get; set; }

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00074E2C File Offset: 0x0007302C
		public void ShowDialog()
		{
			FolderBrowserDialogForjs.o00OoO o00OoO = default(FolderBrowserDialogForjs.o00OoO);
			o00OoO.Oo_o00oO_.O. = this;
			o00OoO.Oo_o00oO_.O. = -1;
			o00OoO.Oo_o00oO_.O. = AsyncVoidMethodBuilder.Create();
			o00OoO.Oo_o00oO_.O..Start<FolderBrowserDialogForjs.o00OoO>(ref o00OoO);
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00074E6B File Offset: 0x0007306B
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x00074E73 File Offset: 0x00073073
		public string Description
		{
			get
			{
				return this.ooOo_O00o0.ooo.;
			}
			set
			{
				this.ooOo_O00o0.ooo. = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00074E7C File Offset: 0x0007307C
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x00074E84 File Offset: 0x00073084
		public string SelectedPath
		{
			get
			{
				return this.OO.Oo0.;
			}
			set
			{
				this.OO.Oo0. = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00074E8D File Offset: 0x0007308D
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00074E95 File Offset: 0x00073095
		public bool ShowNewFolderButton
		{
			get
			{
				return this.O_o.oOO000oO.;
			}
			set
			{
				this.O_o.oOO000oO. = value;
			}
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00074EA0 File Offset: 0x000730A0
		[CompilerGenerated]
		private void <<EMPTY_NAME>>()
		{
			FolderBrowserDialogForjs.ooOoO00__O ooOoO00__O = new FolderBrowserDialogForjs.ooOoO00__O();
			ooOoO00__O.Oo_o00oO_.O. = this;
			ooOoO00__O.O_o.oOO000oO. = DialogResult.Cancel;
			if (OO_00oOO.BaseMainForm != null)
			{
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(ooOoO00__O.O_o.oOO000oO.));
			}
		}

		// Token: 0x040005AA RID: 1450
		private FolderBrowserDialog <<EMPTY_NAME>>;

		// Token: 0x040005AB RID: 1451
		private WebViewer <<EMPTY_NAME>>;

		// Token: 0x040005AC RID: 1452
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040005AD RID: 1453
		private string <<EMPTY_NAME>>;

		// Token: 0x040005AE RID: 1454
		private string <<EMPTY_NAME>>;

		// Token: 0x040005AF RID: 1455
		private bool <<EMPTY_NAME>>;

		// Token: 0x02000112 RID: 274
		[CompilerGenerated]
		internal sealed class ooOoO00__O
		{
			// Token: 0x06000EAF RID: 3759 RVA: 0x00074EE8 File Offset: 0x000730E8
			internal void <<EMPTY_NAME>>()
			{
				this.Oo_o00oO_.O..O_o.oOO000oO. = new FolderBrowserDialog();
				if (!string.IsNullOrEmpty(this.Oo_o00oO_.O..Description))
				{
					this.Oo_o00oO_.O..O_o.oOO000oO..Description = this.Oo_o00oO_.O..Description;
				}
				if (!string.IsNullOrEmpty(this.Oo_o00oO_.O..SelectedPath))
				{
					this.Oo_o00oO_.O..O_o.oOO000oO..SelectedPath = this.Oo_o00oO_.O..SelectedPath;
				}
				this.Oo_o00oO_.O..O_o.oOO000oO..ShowNewFolderButton = this.Oo_o00oO_.O..ShowNewFolderButton;
				this.O_o.oOO000oO. = this.Oo_o00oO_.O..O_o.oOO000oO..ShowDialog(OO_00oOO.BaseMainForm);
				if (this.O_o.oOO000oO. == DialogResult.OK && Operators.CompareString(this.Oo_o00oO_.O..CallBack, "", true) > 0)
				{
					this.Oo_o00oO_.O..SelectedPath = JsonConvert.ToString(this.Oo_o00oO_.O..O_o.oOO000oO..SelectedPath);
					string script = string.Format("{0}({1})", this.Oo_o00oO_.O..CallBack, this.Oo_o00oO_.O..SelectedPath);
					this.Oo_o00oO_.O..O_o.oOO000oO..ExecuteScriptAsync(script);
				}
				else if (Operators.CompareString(this.Oo_o00oO_.O..CallBack, "", true) > 0)
				{
					string script2 = string.Format("{0}()", this.Oo_o00oO_.O..CallBack);
					this.Oo_o00oO_.O..O_o.oOO000oO..ExecuteScriptAsync(script2);
				}
				this.Oo_o00oO_.O..O_o.oOO000oO..Dispose();
			}

			// Token: 0x040005B0 RID: 1456
			public DialogResult <<EMPTY_NAME>>;

			// Token: 0x040005B1 RID: 1457
			public FolderBrowserDialogForjs <<EMPTY_NAME>>;
		}
	}
}
