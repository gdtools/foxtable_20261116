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
	// Token: 0x0200012B RID: 299
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class SaveFileDialogForjs
	{
		// Token: 0x06000F26 RID: 3878 RVA: 0x000764D2 File Offset: 0x000746D2
		public SaveFileDialogForjs(WebViewer A_0)
		{
			this.OoO0.000O__O_. = null;
			this.OoO0.000O__O_. = null;
			this.OoO0.000O__O_. = A_0;
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x000764EF File Offset: 0x000746EF
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x000764F7 File Offset: 0x000746F7
		public string CallBack { get; set; }

		// Token: 0x06000F29 RID: 3881 RVA: 0x00076500 File Offset: 0x00074700
		public void ShowDialog()
		{
			SaveFileDialogForjs.ooo_ ooo_ = default(SaveFileDialogForjs.ooo_);
			ooo_.O.o0Oo_0Oo. = this;
			ooo_.O.o0Oo_0Oo. = -1;
			ooo_.O.o0Oo_0Oo. = AsyncVoidMethodBuilder.Create();
			ooo_.O.o0Oo_0Oo..Start<SaveFileDialogForjs.ooo_>(ref ooo_);
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x0007653F File Offset: 0x0007473F
		// (set) Token: 0x06000F2B RID: 3883 RVA: 0x00076547 File Offset: 0x00074747
		public string Title
		{
			get
			{
				return this.O0.0Oo_.;
			}
			set
			{
				this.O0.0Oo_. = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x00076550 File Offset: 0x00074750
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x00076558 File Offset: 0x00074758
		public string InitialDirectory
		{
			get
			{
				return this.O_OO.0OOOo0.;
			}
			set
			{
				this.O_OO.0OOOo0. = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00076561 File Offset: 0x00074761
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00076569 File Offset: 0x00074769
		public string FileName
		{
			get
			{
				return this.o__o00_OoO.o_o.;
			}
			set
			{
				this.o__o00_OoO.o_o. = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00076572 File Offset: 0x00074772
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x0007657A File Offset: 0x0007477A
		public string Filter
		{
			get
			{
				return this.o_o0OO0_.0O_.;
			}
			set
			{
				this.o_o0OO0_.0O_. = value;
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00076584 File Offset: 0x00074784
		[CompilerGenerated]
		private void <<EMPTY_NAME>>()
		{
			SaveFileDialogForjs.oO_oO_O oO_oO_O = new SaveFileDialogForjs.oO_oO_O();
			oO_oO_O.OoO0.000O__O_. = this;
			oO_oO_O.OoO0.000O__O_. = DialogResult.Cancel;
			if (OO_00oOO.BaseMainForm != null)
			{
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(oO_oO_O.OoO0.000O__O_.));
			}
		}

		// Token: 0x040005F4 RID: 1524
		private SaveFileDialog <<EMPTY_NAME>>;

		// Token: 0x040005F5 RID: 1525
		private WebViewer <<EMPTY_NAME>>;

		// Token: 0x040005F6 RID: 1526
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040005F7 RID: 1527
		private string <<EMPTY_NAME>>;

		// Token: 0x040005F8 RID: 1528
		private string <<EMPTY_NAME>>;

		// Token: 0x040005F9 RID: 1529
		private string <<EMPTY_NAME>>;

		// Token: 0x040005FA RID: 1530
		private string <<EMPTY_NAME>>;

		// Token: 0x0200012C RID: 300
		[CompilerGenerated]
		internal sealed class oO_oO_O
		{
			// Token: 0x06000F34 RID: 3892 RVA: 0x000765CC File Offset: 0x000747CC
			internal void <<EMPTY_NAME>>()
			{
				this.OoO0.000O__O_..OoO0.000O__O_. = new SaveFileDialog();
				if (!string.IsNullOrEmpty(this.OoO0.000O__O_..Filter))
				{
					this.OoO0.000O__O_..OoO0.000O__O_..Filter = this.OoO0.000O__O_..Filter;
				}
				if (!string.IsNullOrEmpty(this.OoO0.000O__O_..FileName))
				{
					this.OoO0.000O__O_..OoO0.000O__O_..FileName = this.OoO0.000O__O_..FileName;
				}
				if (!string.IsNullOrEmpty(this.OoO0.000O__O_..Title))
				{
					this.OoO0.000O__O_..OoO0.000O__O_..Title = this.OoO0.000O__O_..Title;
				}
				if (!string.IsNullOrEmpty(this.OoO0.000O__O_..InitialDirectory))
				{
					this.OoO0.000O__O_..OoO0.000O__O_..InitialDirectory = this.OoO0.000O__O_..InitialDirectory;
				}
				this.OoO0.000O__O_. = this.OoO0.000O__O_..OoO0.000O__O_..ShowDialog(OO_00oOO.BaseMainForm);
				if (this.OoO0.000O__O_. == DialogResult.OK && Operators.CompareString(this.OoO0.000O__O_..CallBack, "", true) > 0)
				{
					this.OoO0.000O__O_..FileName = JsonConvert.ToString(this.OoO0.000O__O_..OoO0.000O__O_..FileName);
					string script = string.Format("{0}({1})", this.OoO0.000O__O_..CallBack, this.OoO0.000O__O_..FileName);
					this.OoO0.000O__O_..OoO0.000O__O_..ExecuteScriptAsync(script);
				}
				else if (Operators.CompareString(this.OoO0.000O__O_..CallBack, "", true) > 0)
				{
					string script2 = string.Format("{0}()", this.OoO0.000O__O_..CallBack);
					this.OoO0.000O__O_..OoO0.000O__O_..ExecuteScriptAsync(script2);
				}
				this.OoO0.000O__O_..OoO0.000O__O_..Dispose();
			}

			// Token: 0x040005FB RID: 1531
			public DialogResult <<EMPTY_NAME>>;

			// Token: 0x040005FC RID: 1532
			public SaveFileDialogForjs <<EMPTY_NAME>>;
		}
	}
}
