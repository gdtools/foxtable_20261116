using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using O0o0.00;

namespace Foxtable
{
	// Token: 0x02000124 RID: 292
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OpenFileDialogForjs
	{
		// Token: 0x06000EEA RID: 3818 RVA: 0x00075DA2 File Offset: 0x00073FA2
		public OpenFileDialogForjs(WebViewer A_0)
		{
			this.OoOo00o.o00_0O. = null;
			this.OoOo00o.o00_0O. = null;
			this.OoOo00o.o00_0O. = false;
			this.OoOo00o.o00_0O. = A_0;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00075DC6 File Offset: 0x00073FC6
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x00075DCE File Offset: 0x00073FCE
		public string CallBack { get; set; }

		// Token: 0x06000EED RID: 3821 RVA: 0x00075DD8 File Offset: 0x00073FD8
		public void ShowDialog()
		{
			OpenFileDialogForjs.oo_O0o oo_O0o = default(OpenFileDialogForjs.oo_O0o);
			oo_O0o.OOoo.00O_0. = this;
			oo_O0o.OOoo.00O_0. = -1;
			oo_O0o.OOoo.00O_0. = AsyncVoidMethodBuilder.Create();
			oo_O0o.OOoo.00O_0..Start<OpenFileDialogForjs.oo_O0o>(ref oo_O0o);
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00075E17 File Offset: 0x00074017
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x00075E1F File Offset: 0x0007401F
		public string Title
		{
			get
			{
				return this.oo_OO.O000.;
			}
			set
			{
				this.oo_OO.O000. = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x00075E28 File Offset: 0x00074028
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x00075E30 File Offset: 0x00074030
		public string InitialDirectory
		{
			get
			{
				return this.O0O_O.0_0OO.;
			}
			set
			{
				this.O0O_O.0_0OO. = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x00075E39 File Offset: 0x00074039
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x00075E41 File Offset: 0x00074041
		public string FileName
		{
			get
			{
				return this.oooOoo0._Oo000.;
			}
			set
			{
				this.oooOoo0._Oo000. = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00075E4A File Offset: 0x0007404A
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x00075E52 File Offset: 0x00074052
		public string[] FileNames
		{
			get
			{
				return this.OoOo00o.o00_0O.;
			}
			private set
			{
				this.OoOo00o.o00_0O. = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00075E5B File Offset: 0x0007405B
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00075E63 File Offset: 0x00074063
		public string Filter
		{
			get
			{
				return this.O0.O_0OOO0_.;
			}
			set
			{
				this.O0.O_0OOO0_. = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00075E6C File Offset: 0x0007406C
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x00075E74 File Offset: 0x00074074
		public bool MultiSelect
		{
			get
			{
				return this.OoOo00o.o00_0O.;
			}
			set
			{
				this.OoOo00o.o00_0O. = value;
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00075E80 File Offset: 0x00074080
		[CompilerGenerated]
		private void <<EMPTY_NAME>>()
		{
			OpenFileDialogForjs.O_0_ o_0_ = new OpenFileDialogForjs.O_0_(o_0_);
			o_0_.OOoo.00O_0. = this;
			o_0_.OOoo.00O_0. = DialogResult.Cancel;
			if (OO_00oOO.BaseMainForm != null)
			{
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(o_0_.OOoo.00O_0.));
			}
		}

		// Token: 0x040005DE RID: 1502
		internal OpenFileDialog <<EMPTY_NAME>>;

		// Token: 0x040005DF RID: 1503
		private WebViewer <<EMPTY_NAME>>;

		// Token: 0x040005E0 RID: 1504
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040005E1 RID: 1505
		private string <<EMPTY_NAME>>;

		// Token: 0x040005E2 RID: 1506
		private string <<EMPTY_NAME>>;

		// Token: 0x040005E3 RID: 1507
		private string <<EMPTY_NAME>>;

		// Token: 0x040005E4 RID: 1508
		private string[] <<EMPTY_NAME>>;

		// Token: 0x040005E5 RID: 1509
		private string <<EMPTY_NAME>>;

		// Token: 0x040005E6 RID: 1510
		private bool <<EMPTY_NAME>>;

		// Token: 0x02000125 RID: 293
		[CompilerGenerated]
		internal sealed class O_0_
		{
			// Token: 0x06000EFB RID: 3835 RVA: 0x00075EC0 File Offset: 0x000740C0
			public O_0_(OpenFileDialogForjs.O_0_ A_0)
			{
				if (A_0 != null)
				{
					this.OOoo.00O_0. = A_0.OOoo.00O_0.;
				}
			}

			// Token: 0x06000EFC RID: 3836 RVA: 0x00075ED8 File Offset: 0x000740D8
			internal void <<EMPTY_NAME>>()
			{
				this.OOoo.00O_0..OoOo00o.o00_0O. = new OpenFileDialog();
				if (!string.IsNullOrEmpty(this.OOoo.00O_0..Filter))
				{
					this.OOoo.00O_0..OoOo00o.o00_0O..Filter = this.OOoo.00O_0..Filter;
				}
				if (!string.IsNullOrEmpty(this.OOoo.00O_0..FileName))
				{
					this.OOoo.00O_0..OoOo00o.o00_0O..FileName = this.OOoo.00O_0..FileName;
				}
				if (!string.IsNullOrEmpty(this.OOoo.00O_0..Title))
				{
					this.OOoo.00O_0..OoOo00o.o00_0O..Title = this.OOoo.00O_0..Title;
				}
				if (!string.IsNullOrEmpty(this.OOoo.00O_0..InitialDirectory))
				{
					this.OOoo.00O_0..OoOo00o.o00_0O..InitialDirectory = this.OOoo.00O_0..InitialDirectory;
				}
				this.OOoo.00O_0..OoOo00o.o00_0O..Multiselect = this.OOoo.00O_0..MultiSelect;
				this.OOoo.00O_0. = this.OOoo.00O_0..OoOo00o.o00_0O..ShowDialog(OO_00oOO.BaseMainForm);
				if (this.OOoo.00O_0. == DialogResult.OK && Operators.CompareString(this.OOoo.00O_0..CallBack, "", true) > 0)
				{
					this.OOoo.00O_0..FileName = JsonConvert.ToString(this.OOoo.00O_0..OoOo00o.o00_0O..FileName);
					List<string> list = new List<string>();
					foreach (string value in this.OOoo.00O_0..OoOo00o.o00_0O..FileNames)
					{
						list.Add(JsonConvert.ToString(value));
					}
					this.OOoo.00O_0..FileNames = list.ToArray();
					string script = string.Format("{0}({1})", this.OOoo.00O_0..CallBack, this.OOoo.00O_0..FileName);
					this.OOoo.00O_0..OoOo00o.o00_0O..ExecuteScriptAsync(script);
				}
				else if (Operators.CompareString(this.OOoo.00O_0..CallBack, "", true) > 0)
				{
					string script2 = string.Format("{0}()", this.OOoo.00O_0..CallBack);
					this.OOoo.00O_0..OoOo00o.o00_0O..ExecuteScriptAsync(script2);
				}
				this.OOoo.00O_0..OoOo00o.o00_0O..Dispose();
			}

			// Token: 0x040005E7 RID: 1511
			public DialogResult <<EMPTY_NAME>>;

			// Token: 0x040005E8 RID: 1512
			public OpenFileDialogForjs <<EMPTY_NAME>>;
		}
	}
}
