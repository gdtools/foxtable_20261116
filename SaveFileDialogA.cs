using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using O0o0.00;

namespace Foxtable
{
	// Token: 0x02000128 RID: 296
	public class SaveFileDialogA
	{
		// Token: 0x06000F17 RID: 3863 RVA: 0x000762BA File Offset: 0x000744BA
		public SaveFileDialogA()
		{
			this.o0o_oO_OOoO.0O. = new SaveFileDialog();
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000762D0 File Offset: 0x000744D0
		public Task<DialogResult> ShowDialog()
		{
			SaveFileDialogA.o_0OOO o_0OOO = default(SaveFileDialogA.o_0OOO);
			o_0OOO.Oo.00O0oO. = this;
			o_0OOO.Oo.00O0oO. = -1;
			o_0OOO.Oo.00O0oO. = AsyncTaskMethodBuilder<DialogResult>.Create();
			o_0OOO.Oo.00O0oO..Start<SaveFileDialogA.o_0OOO>(ref o_0OOO);
			return o_0OOO.Oo.00O0oO..Task;
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0007631B File Offset: 0x0007451B
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00076328 File Offset: 0x00074528
		public string Title
		{
			get
			{
				return this.o0o_oO_OOoO.0O..Title;
			}
			set
			{
				this.o0o_oO_OOoO.0O..Title = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x00076336 File Offset: 0x00074536
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00076343 File Offset: 0x00074543
		public string InitialDirectory
		{
			get
			{
				return this.o0o_oO_OOoO.0O..InitialDirectory;
			}
			set
			{
				this.o0o_oO_OOoO.0O..InitialDirectory = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x00076351 File Offset: 0x00074551
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x0007635E File Offset: 0x0007455E
		public string FileName
		{
			get
			{
				return this.o0o_oO_OOoO.0O..FileName;
			}
			set
			{
				this.o0o_oO_OOoO.0O..FileName = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x0007636C File Offset: 0x0007456C
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x00076379 File Offset: 0x00074579
		public string Filter
		{
			get
			{
				return this.o0o_oO_OOoO.0O..Filter;
			}
			set
			{
				this.o0o_oO_OOoO.0O..Filter = value;
			}
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00076388 File Offset: 0x00074588
		[CompilerGenerated]
		private DialogResult <<EMPTY_NAME>>()
		{
			SaveFileDialogA.o000OO o000OO = new SaveFileDialogA.o000OO();
			o000OO.Oo.00O0oO. = this;
			o000OO.o0o_oO_OOoO.0O. = DialogResult.Cancel;
			if (OO_00oOO.BaseMainForm != null)
			{
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(o000OO.o0o_oO_OOoO.0O.));
			}
			return o000OO.o0o_oO_OOoO.0O.;
		}

		// Token: 0x040005ED RID: 1517
		private SaveFileDialog <<EMPTY_NAME>>;

		// Token: 0x02000129 RID: 297
		[CompilerGenerated]
		internal sealed class o000OO
		{
			// Token: 0x06000F23 RID: 3875 RVA: 0x000763D5 File Offset: 0x000745D5
			internal void <<EMPTY_NAME>>()
			{
				this.o0o_oO_OOoO.0O. = this.Oo.00O0oO..o0o_oO_OOoO.0O..ShowDialog();
			}

			// Token: 0x040005EE RID: 1518
			public DialogResult <<EMPTY_NAME>>;

			// Token: 0x040005EF RID: 1519
			public SaveFileDialogA <<EMPTY_NAME>>;
		}
	}
}
