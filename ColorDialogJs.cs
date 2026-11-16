using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using O0o0.00;

namespace Foxtable
{
	// Token: 0x02000109 RID: 265
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class ColorDialogJs
	{
		// Token: 0x06000E80 RID: 3712 RVA: 0x000748AA File Offset: 0x00072AAA
		public ColorDialogJs(WebViewer A_0)
		{
			this.Oo.o. = null;
			this.Oo.o. = null;
			this.Oo.o. = Color.Black;
			this.Oo.o. = A_0;
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x000748D2 File Offset: 0x00072AD2
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x000748DA File Offset: 0x00072ADA
		public string CallBack { get; set; }

		// Token: 0x06000E83 RID: 3715 RVA: 0x000748E4 File Offset: 0x00072AE4
		public void ShowDialog()
		{
			ColorDialogJs.O_00 o_ = default(ColorDialogJs.O_00);
			o_.oOO._O0OOO_o. = this;
			o_.oOO._O0OOO_o. = -1;
			o_.oOO._O0OOO_o. = AsyncVoidMethodBuilder.Create();
			o_.oOO._O0OOO_o..Start<ColorDialogJs.O_00>(ref o_);
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00074923 File Offset: 0x00072B23
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x0007492B File Offset: 0x00072B2B
		public Color Color
		{
			get
			{
				return this.Oo.o.;
			}
			set
			{
				this.Oo.o. = value;
			}
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00074934 File Offset: 0x00072B34
		[CompilerGenerated]
		private void <<EMPTY_NAME>>()
		{
			ColorDialogJs.O0O_00__O o0O_00__O = new ColorDialogJs.O0O_00__O();
			o0O_00__O.Oo.o. = this;
			o0O_00__O.Oo.o. = DialogResult.Cancel;
			if (OO_00oOO.BaseMainForm != null)
			{
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(o0O_00__O.Oo.o.));
			}
		}

		// Token: 0x04000596 RID: 1430
		private ColorDialog <<EMPTY_NAME>>;

		// Token: 0x04000597 RID: 1431
		private WebViewer <<EMPTY_NAME>>;

		// Token: 0x04000598 RID: 1432
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000599 RID: 1433
		private Color <<EMPTY_NAME>>;

		// Token: 0x0200010A RID: 266
		[CompilerGenerated]
		internal sealed class O0O_00__O
		{
			// Token: 0x06000E88 RID: 3720 RVA: 0x0007497C File Offset: 0x00072B7C
			internal void <<EMPTY_NAME>>()
			{
				this.Oo.o..Oo.o. = new ColorDialog();
				this.Oo.o..Oo.o..Color = this.Oo.o..Oo.o.;
				this.Oo.o. = this.Oo.o..Oo.o..ShowDialog(OO_00oOO.BaseMainForm);
				if (this.Oo.o. == DialogResult.OK && this.Oo.o. == DialogResult.OK && Operators.CompareString(this.Oo.o..CallBack, "", true) > 0)
				{
					this.Oo.o..Oo.o..ExecuteScriptAsync(this.Oo.o..CallBack + "(" + Conversions.ToString(this.Oo.o..Oo.o..Color.ToArgb()) + ")");
				}
				this.Oo.o..Oo.o..Dispose();
			}

			// Token: 0x0400059A RID: 1434
			public DialogResult <<EMPTY_NAME>>;

			// Token: 0x0400059B RID: 1435
			public ColorDialogJs <<EMPTY_NAME>>;
		}
	}
}
