using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using O0o0.00;

namespace Foxtable
{
	// Token: 0x02000117 RID: 279
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FontDialogJs
	{
		// Token: 0x06000EB9 RID: 3769 RVA: 0x000752FA File Offset: 0x000734FA
		public FontDialogJs(WebViewer A_0)
		{
			this.O.Oo0. = null;
			this.O.Oo0. = null;
			this.O.Oo0. = new Font("微软雅黑", 12f);
			this.O.Oo0. = A_0;
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0007532C File Offset: 0x0007352C
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x00075334 File Offset: 0x00073534
		public string CallBack { get; set; }

		// Token: 0x06000EBC RID: 3772 RVA: 0x00075340 File Offset: 0x00073540
		public void ShowDialog()
		{
			FontDialogJs.oO0oo__O0 oO0oo__O = default(FontDialogJs.oO0oo__O0);
			oO0oo__O.O0_o0.o__. = this;
			oO0oo__O.O0_o0.o__. = -1;
			oO0oo__O.O0_o0.o__. = AsyncVoidMethodBuilder.Create();
			oO0oo__O.O0_o0.o__..Start<FontDialogJs.oO0oo__O0>(ref oO0oo__O);
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x0007537F File Offset: 0x0007357F
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x00075387 File Offset: 0x00073587
		public Font Font
		{
			get
			{
				return this.O.Oo0.;
			}
			set
			{
				this.O.Oo0. = value;
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00075390 File Offset: 0x00073590
		[CompilerGenerated]
		private void <<EMPTY_NAME>>()
		{
			FontDialogJs.oO00 oO = new FontDialogJs.oO00();
			oO.O.Oo0. = this;
			oO.O.Oo0. = DialogResult.Cancel;
			if (OO_00oOO.BaseMainForm != null)
			{
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(oO.O.Oo0.));
			}
		}

		// Token: 0x040005BC RID: 1468
		private FontDialog <<EMPTY_NAME>>;

		// Token: 0x040005BD RID: 1469
		private WebViewer <<EMPTY_NAME>>;

		// Token: 0x040005BE RID: 1470
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040005BF RID: 1471
		private Font <<EMPTY_NAME>>;

		// Token: 0x02000118 RID: 280
		[CompilerGenerated]
		internal sealed class oO00
		{
			// Token: 0x06000EC1 RID: 3777 RVA: 0x000753D8 File Offset: 0x000735D8
			internal void <<EMPTY_NAME>>()
			{
				this.O.Oo0..O.Oo0. = new FontDialog();
				if (this.O.Oo0..O.Oo0. != null)
				{
					this.O.Oo0..O.Oo0..Font = this.O.Oo0..O.Oo0.;
				}
				this.O.Oo0. = this.O.Oo0..O.Oo0..ShowDialog(OO_00oOO.BaseMainForm);
				if (this.O.Oo0. == DialogResult.OK && Operators.CompareString(this.O.Oo0..CallBack, "", true) > 0)
				{
					this.O.Oo0..O.Oo0. = this.O.Oo0..O.Oo0..Font;
					JObject jobject = new JObject();
					jobject["name"] = this.O.Oo0..O.Oo0..Font.Name;
					jobject["size"] = this.O.Oo0..O.Oo0..Font.Size;
					jobject["bold"] = this.O.Oo0..O.Oo0..Font.Bold;
					jobject["italic"] = this.O.Oo0..O.Oo0..Font.Italic;
					string arg = JsonConvert.ToString(jobject.ToString());
					string script = string.Format("{0}({1})", this.O.Oo0..CallBack, arg);
					this.O.Oo0..O.Oo0..ExecuteScriptAsync(script);
				}
				this.O.Oo0..O.Oo0..Dispose();
			}

			// Token: 0x040005C0 RID: 1472
			public DialogResult <<EMPTY_NAME>>;

			// Token: 0x040005C1 RID: 1473
			public FontDialogJs <<EMPTY_NAME>>;
		}
	}
}
