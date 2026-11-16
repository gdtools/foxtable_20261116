using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using O0o0.00;

namespace Foxtable
{
	// Token: 0x02000121 RID: 289
	public class OpenFileDialogA
	{
		// Token: 0x06000ED8 RID: 3800 RVA: 0x00075B62 File Offset: 0x00073D62
		public OpenFileDialogA()
		{
			this.o_.oOO_. = new OpenFileDialog();
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00075B78 File Offset: 0x00073D78
		public Task<DialogResult> ShowDialog()
		{
			OpenFileDialogA.O__00oO00oo o__00oO00oo = default(OpenFileDialogA.O__00oO00oo);
			o__00oO00oo.Ooo0o0._0O_. = this;
			o__00oO00oo.Ooo0o0._0O_. = -1;
			o__00oO00oo.Ooo0o0._0O_. = AsyncTaskMethodBuilder<DialogResult>.Create();
			o__00oO00oo.Ooo0o0._0O_..Start<OpenFileDialogA.O__00oO00oo>(ref o__00oO00oo);
			return o__00oO00oo.Ooo0o0._0O_..Task;
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00075BC3 File Offset: 0x00073DC3
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x00075BD0 File Offset: 0x00073DD0
		public string Title
		{
			get
			{
				return this.o_.oOO_..Title;
			}
			set
			{
				this.o_.oOO_..Title = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x00075BDE File Offset: 0x00073DDE
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x00075BEB File Offset: 0x00073DEB
		public string InitialDirectory
		{
			get
			{
				return this.o_.oOO_..InitialDirectory;
			}
			set
			{
				this.o_.oOO_..InitialDirectory = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x00075BF9 File Offset: 0x00073DF9
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x00075C06 File Offset: 0x00073E06
		public string FileName
		{
			get
			{
				return this.o_.oOO_..FileName;
			}
			set
			{
				this.o_.oOO_..FileName = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00075C14 File Offset: 0x00073E14
		public string[] FileNames
		{
			get
			{
				return this.o_.oOO_..FileNames;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00075C21 File Offset: 0x00073E21
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00075C2E File Offset: 0x00073E2E
		public string Filter
		{
			get
			{
				return this.o_.oOO_..Filter;
			}
			set
			{
				this.o_.oOO_..Filter = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00075C3C File Offset: 0x00073E3C
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00075C49 File Offset: 0x00073E49
		public bool MultiSelect
		{
			get
			{
				return this.o_.oOO_..Multiselect;
			}
			set
			{
				this.o_.oOO_..Multiselect = value;
			}
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00075C58 File Offset: 0x00073E58
		[CompilerGenerated]
		private DialogResult <<EMPTY_NAME>>()
		{
			OpenFileDialogA.Oo__ooO_0_0oO oo__ooO_0_0oO = new OpenFileDialogA.Oo__ooO_0_0oO();
			oo__ooO_0_0oO.o_.oOO_. = this;
			oo__ooO_0_0oO.o_.oOO_. = DialogResult.Cancel;
			if (OO_00oOO.BaseMainForm != null)
			{
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(oo__ooO_0_0oO.o_.oOO_.));
			}
			return oo__ooO_0_0oO.o_.oOO_.;
		}

		// Token: 0x040005D7 RID: 1495
		private OpenFileDialog <<EMPTY_NAME>>;

		// Token: 0x02000122 RID: 290
		[CompilerGenerated]
		internal sealed class Oo__ooO_0_0oO
		{
			// Token: 0x06000EE7 RID: 3815 RVA: 0x00075CA5 File Offset: 0x00073EA5
			internal void <<EMPTY_NAME>>()
			{
				this.o_.oOO_. = this.o_.oOO_..o_.oOO_..ShowDialog();
			}

			// Token: 0x040005D8 RID: 1496
			public DialogResult <<EMPTY_NAME>>;

			// Token: 0x040005D9 RID: 1497
			public OpenFileDialogA <<EMPTY_NAME>>;
		}
	}
}
