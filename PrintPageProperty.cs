using System;
using System.ComponentModel;
using System.Drawing.Printing;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000420 RID: 1056
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class PrintPageProperty
	{
		// Token: 0x06004721 RID: 18209 RVA: 0x001F34F8 File Offset: 0x001F16F8
		public PrintPageProperty()
		{
			this.O_O_oO0_00o.0. = PaperKind.A4;
			this.O_O_oO0_00o.0. = PaperSourceKind.FormSource;
			this.OO.OOO. = 25.4;
			this.o_00o.O0_0. = 25.4;
			this.o_.0OOO. = 25.4;
			this.ooOO0oO.0_oO. = 25.4;
			this.O0O.o____o00. = new PrinterSettings();
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06004722 RID: 18210 RVA: 0x001F3564 File Offset: 0x001F1764
		// (set) Token: 0x06004723 RID: 18211 RVA: 0x001F35A9 File Offset: 0x001F17A9
		public string PrinterName
		{
			get
			{
				if (this.O0O.o____o00. == null)
				{
					this.O0O.o____o00. = new PrinterSettings();
					if (Operators.CompareString(this.O0O.o____o00..PrinterName, this.O_O_oO0_00o.0., true) == 0)
					{
						return null;
					}
				}
				return this.O_O_oO0_00o.0.;
			}
			set
			{
				this.O_O_oO0_00o.0. = value;
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06004724 RID: 18212 RVA: 0x001F35B2 File Offset: 0x001F17B2
		// (set) Token: 0x06004725 RID: 18213 RVA: 0x001F35BA File Offset: 0x001F17BA
		[DefaultValue(9)]
		public PaperKind PaperKind
		{
			get
			{
				return this.O_O_oO0_00o.0.;
			}
			set
			{
				this.O_O_oO0_00o.0. = value;
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06004726 RID: 18214 RVA: 0x001F35C3 File Offset: 0x001F17C3
		// (set) Token: 0x06004727 RID: 18215 RVA: 0x001F35CB File Offset: 0x001F17CB
		[DefaultValue(15)]
		public PaperSourceKind PaperSourceKind
		{
			get
			{
				return this.O_O_oO0_00o.0.;
			}
			set
			{
				this.O_O_oO0_00o.0. = value;
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06004728 RID: 18216 RVA: 0x001F35D4 File Offset: 0x001F17D4
		// (set) Token: 0x06004729 RID: 18217 RVA: 0x001F35DC File Offset: 0x001F17DC
		[DefaultValue(false)]
		public bool Landscape
		{
			get
			{
				return this.O_O_oO0_00o.0.;
			}
			set
			{
				this.O_O_oO0_00o.0. = value;
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x0600472A RID: 18218 RVA: 0x001F35E5 File Offset: 0x001F17E5
		// (set) Token: 0x0600472B RID: 18219 RVA: 0x001F35ED File Offset: 0x001F17ED
		public double Width
		{
			get
			{
				return this.O_O_oO0_00o.0.;
			}
			set
			{
				this.O_O_oO0_00o.0. = value;
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x0600472C RID: 18220 RVA: 0x001F35F6 File Offset: 0x001F17F6
		// (set) Token: 0x0600472D RID: 18221 RVA: 0x001F35FE File Offset: 0x001F17FE
		public double Height
		{
			get
			{
				return this.O.OO00o.;
			}
			set
			{
				this.O.OO00o. = value;
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x0600472E RID: 18222 RVA: 0x001F3607 File Offset: 0x001F1807
		// (set) Token: 0x0600472F RID: 18223 RVA: 0x001F360F File Offset: 0x001F180F
		[DefaultValue(25.4)]
		public double LeftMargin
		{
			get
			{
				return this.OO.OOO.;
			}
			set
			{
				this.OO.OOO. = value;
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06004730 RID: 18224 RVA: 0x001F3618 File Offset: 0x001F1818
		// (set) Token: 0x06004731 RID: 18225 RVA: 0x001F3620 File Offset: 0x001F1820
		[DefaultValue(25.4)]
		public double RightMargin
		{
			get
			{
				return this.o_00o.O0_0.;
			}
			set
			{
				this.o_00o.O0_0. = value;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06004732 RID: 18226 RVA: 0x001F3629 File Offset: 0x001F1829
		// (set) Token: 0x06004733 RID: 18227 RVA: 0x001F3631 File Offset: 0x001F1831
		[DefaultValue(25.4)]
		public double TopMargin
		{
			get
			{
				return this.o_.0OOO.;
			}
			set
			{
				this.o_.0OOO. = value;
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06004734 RID: 18228 RVA: 0x001F363A File Offset: 0x001F183A
		// (set) Token: 0x06004735 RID: 18229 RVA: 0x001F3642 File Offset: 0x001F1842
		[DefaultValue(25.4)]
		public double BottomMargin
		{
			get
			{
				return this.ooOO0oO.0_oO.;
			}
			set
			{
				this.ooOO0oO.0_oO. = value;
			}
		}

		// Token: 0x04001CB9 RID: 7353
		private PaperKind <<EMPTY_NAME>>;

		// Token: 0x04001CBA RID: 7354
		private PaperSourceKind <<EMPTY_NAME>>;

		// Token: 0x04001CBB RID: 7355
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CBC RID: 7356
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CBD RID: 7357
		private double <<EMPTY_NAME>>;

		// Token: 0x04001CBE RID: 7358
		private double <<EMPTY_NAME>>;

		// Token: 0x04001CBF RID: 7359
		private double <<EMPTY_NAME>>;

		// Token: 0x04001CC0 RID: 7360
		private double <<EMPTY_NAME>>;

		// Token: 0x04001CC1 RID: 7361
		private double <<EMPTY_NAME>>;

		// Token: 0x04001CC2 RID: 7362
		private double <<EMPTY_NAME>>;

		// Token: 0x04001CC3 RID: 7363
		private PrinterSettings <<EMPTY_NAME>>;
	}
}
