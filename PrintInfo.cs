using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000469 RID: 1129
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class PrintInfo
	{
		// Token: 0x06004CBB RID: 19643 RVA: 0x0022C574 File Offset: 0x0022A774
		public PrintInfo(Table A_0)
		{
			this.oO._0Oo_0000o0. = "[TableCaption]";
			this.oO_.O0o. = "||第[PageNo]页，共[PageCount]页";
			this.o00.o0. = false;
			this.oOoo.OOo_. = false;
			this.o00.o0. = new Font("宋体", 9f);
			this.oOoo.OOo_. = new Font("宋体", 9f);
			this.o_0OO0.O__O00o. = new Font("宋体", 16f, FontStyle.Bold);
			this.o_o0oO.__0. = new Font("宋体", 12f);
			this.oO__0_.O0_0O. = 3;
			this.oO._0Oo_0000o0. = 3;
			this.o_.__o0_O. = 3;
			this.ooo_oo0.Ooo0o0. = 3;
			this.O_O.O_00. = true;
			this.oO_.O0o. = 1;
			this.ooo_oo0.Ooo0o0. = true;
			this.o.ooo0_o_0O. = true;
			this.o0.0_o_O. = true;
			this.oo0o.OoO_0_Oo. = true;
			this.O._o0o. = false;
			this.O0.__o_O000O. = true;
			this.OOo._o0O__00_O. = true;
			this.O_oO.O. = true;
			this.O_oO0_O.0. = false;
			this.ooo0o_.__O. = true;
			this.oo_0O.__0o0O. = true;
			this.oOOo_o0oo.00. = true;
			this.OOo__._00oo. = true;
			this.oOo.oo. = true;
			this.oOo0_.OooOOo. = true;
			this.oO.OoO_. = true;
			this.OO_O_o0_O.o. = new Font("宋体", 9f);
			this.oo_._O0_oOooO. = A_0;
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06004CBC RID: 19644 RVA: 0x0022C6B6 File Offset: 0x0022A8B6
		internal Table Table
		{
			get
			{
				return this.oo_._O0_oOooO.;
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06004CBD RID: 19645 RVA: 0x0022C6C0 File Offset: 0x0022A8C0
		// (set) Token: 0x06004CBE RID: 19646 RVA: 0x0022C6EC File Offset: 0x0022A8EC
		public string PrinterName
		{
			get
			{
				string result;
				if (this.PrinterSettings.IsDefaultPrinter)
				{
					result = null;
				}
				else
				{
					result = this.PrinterSettings.PrinterName;
				}
				return result;
			}
			set
			{
				try
				{
					try
					{
						IEnumerator enumerator = PrinterSettings.InstalledPrinters.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (Operators.CompareString(Conversions.ToString(enumerator.Current), value, true) == 0)
							{
								this.PrinterSettings.PrinterName = value;
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06004CBF RID: 19647 RVA: 0x0022C770 File Offset: 0x0022A970
		internal PrinterSettings PrinterSettings
		{
			get
			{
				return this.oo_._O0_oOooO..foxGrid.PrintParameters.PrintDocument.PrinterSettings;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06004CC0 RID: 19648 RVA: 0x0022C78C File Offset: 0x0022A98C
		internal PageSettings PageSettings
		{
			get
			{
				return this.oo_._O0_oOooO..foxGrid.PrintParameters.PrintDocument.DefaultPageSettings;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06004CC1 RID: 19649 RVA: 0x0022C7A8 File Offset: 0x0022A9A8
		// (set) Token: 0x06004CC2 RID: 19650 RVA: 0x0022C7F8 File Offset: 0x0022A9F8
		internal PaperSize PaperSize
		{
			get
			{
				PaperSize result;
				try
				{
					if (PrinterSettings.InstalledPrinters.Count == 0)
					{
						result = new PaperSize();
					}
					else
					{
						result = this.PageSettings.PaperSize;
					}
				}
				catch (Exception ex)
				{
					result = null;
				}
				return result;
			}
			set
			{
				this.PageSettings.PaperSize = value;
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06004CC3 RID: 19651 RVA: 0x0022C808 File Offset: 0x0022AA08
		// (set) Token: 0x06004CC4 RID: 19652 RVA: 0x0022C840 File Offset: 0x0022AA40
		public string PaperSource
		{
			get
			{
				string result;
				if (this.PageSettings.PaperSource.Kind == PaperSourceKind.FormSource)
				{
					result = null;
				}
				else
				{
					result = this.PageSettings.PaperSource.SourceName;
				}
				return result;
			}
			set
			{
				try
				{
					try
					{
						foreach (object obj in this.PrinterSettings.PaperSources)
						{
							PaperSource paperSource = (PaperSource)obj;
							if (Operators.CompareString(paperSource.SourceName, value, true) == 0)
							{
								this.PageSettings.PaperSource = paperSource;
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06004CC5 RID: 19653 RVA: 0x0022C8D4 File Offset: 0x0022AAD4
		// (set) Token: 0x06004CC6 RID: 19654 RVA: 0x0022C924 File Offset: 0x0022AB24
		[DefaultValue(9)]
		public int PaperRawKind
		{
			get
			{
				int result;
				try
				{
					if (PrinterSettings.InstalledPrinters.Count == 0)
					{
						result = 9;
					}
					else
					{
						result = this.PaperSize.RawKind;
					}
				}
				catch (Exception ex)
				{
					result = 0;
				}
				return result;
			}
			set
			{
				try
				{
					if (PrinterSettings.InstalledPrinters.Count != 0)
					{
						this.PaperSize.RawKind = value;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06004CC7 RID: 19655 RVA: 0x0022C96C File Offset: 0x0022AB6C
		// (set) Token: 0x06004CC8 RID: 19656 RVA: 0x0022C974 File Offset: 0x0022AB74
		[OooO0(true)]
		public int PaperKind
		{
			get
			{
				return this.PaperRawKind;
			}
			set
			{
				this.PaperRawKind = value;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06004CC9 RID: 19657 RVA: 0x0022C980 File Offset: 0x0022AB80
		// (set) Token: 0x06004CCA RID: 19658 RVA: 0x0022C9B3 File Offset: 0x0022ABB3
		public double PaperWidth
		{
			get
			{
				double result;
				if (this.PaperSize != null)
				{
					result = Math.Round((double)this.PaperSize.Width * 0.254, 1);
				}
				return result;
			}
			set
			{
				if (this.PaperSize != null && this.PaperRawKind == 0)
				{
					this.PaperSize.Width = Convert.ToInt32(value / 0.254);
				}
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06004CCB RID: 19659 RVA: 0x0022C9E0 File Offset: 0x0022ABE0
		// (set) Token: 0x06004CCC RID: 19660 RVA: 0x0022CA13 File Offset: 0x0022AC13
		public double PaperHeight
		{
			get
			{
				double result;
				if (this.PaperSize != null)
				{
					result = Math.Round((double)this.PaperSize.Height * 0.254, 1);
				}
				return result;
			}
			set
			{
				if (this.PaperSize != null && this.PaperRawKind == 0)
				{
					this.PaperSize.Height = Convert.ToInt32(value / 0.254);
				}
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06004CCD RID: 19661 RVA: 0x0022CA40 File Offset: 0x0022AC40
		// (set) Token: 0x06004CCE RID: 19662 RVA: 0x0022CA63 File Offset: 0x0022AC63
		[DefaultValue(25.4)]
		public double LeftMargin
		{
			get
			{
				return Math.Round((double)this.PageSettings.Margins.Left * 0.254, 1);
			}
			set
			{
				this.PageSettings.Margins.Left = Convert.ToInt32(value / 0.254);
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06004CCF RID: 19663 RVA: 0x0022CA85 File Offset: 0x0022AC85
		// (set) Token: 0x06004CD0 RID: 19664 RVA: 0x0022CAA8 File Offset: 0x0022ACA8
		[DefaultValue(25.4)]
		public double TopMargin
		{
			get
			{
				return Math.Round((double)this.PageSettings.Margins.Top * 0.254, 1);
			}
			set
			{
				this.PageSettings.Margins.Top = Convert.ToInt32(value / 0.254);
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06004CD1 RID: 19665 RVA: 0x0022CACA File Offset: 0x0022ACCA
		// (set) Token: 0x06004CD2 RID: 19666 RVA: 0x0022CAED File Offset: 0x0022ACED
		[DefaultValue(25.4)]
		public double RightMargin
		{
			get
			{
				return Math.Round((double)this.PageSettings.Margins.Right * 0.254, 1);
			}
			set
			{
				this.PageSettings.Margins.Right = Convert.ToInt32(value / 0.254);
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06004CD3 RID: 19667 RVA: 0x0022CB0F File Offset: 0x0022AD0F
		// (set) Token: 0x06004CD4 RID: 19668 RVA: 0x0022CB32 File Offset: 0x0022AD32
		[DefaultValue(25.4)]
		public double BottomMargin
		{
			get
			{
				return Math.Round((double)this.PageSettings.Margins.Bottom * 0.254, 1);
			}
			set
			{
				this.PageSettings.Margins.Bottom = Convert.ToInt32(value / 0.254);
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06004CD5 RID: 19669 RVA: 0x0022CB54 File Offset: 0x0022AD54
		// (set) Token: 0x06004CD6 RID: 19670 RVA: 0x0022CB61 File Offset: 0x0022AD61
		[DefaultValue(false)]
		public bool LandScape
		{
			get
			{
				return this.PageSettings.Landscape;
			}
			set
			{
				this.PageSettings.Landscape = value;
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x0022CB6F File Offset: 0x0022AD6F
		// (set) Token: 0x06004CD8 RID: 19672 RVA: 0x0022CB77 File Offset: 0x0022AD77
		[DefaultValue("[TableCaption]")]
		public string Title
		{
			get
			{
				return this.oO._0Oo_0000o0.;
			}
			set
			{
				this.oO._0Oo_0000o0. = value;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06004CD9 RID: 19673 RVA: 0x0022CB80 File Offset: 0x0022AD80
		// (set) Token: 0x06004CDA RID: 19674 RVA: 0x0022CB88 File Offset: 0x0022AD88
		[DefaultValue("")]
		public string SubTitle
		{
			get
			{
				return this.o_0OO0.O__O00o.;
			}
			set
			{
				this.o_0OO0.O__O00o. = value;
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06004CDB RID: 19675 RVA: 0x0022CB91 File Offset: 0x0022AD91
		// (set) Token: 0x06004CDC RID: 19676 RVA: 0x0022CB99 File Offset: 0x0022AD99
		[DefaultValue("")]
		public string PageHeader
		{
			get
			{
				return this.o0O_0o.0O.;
			}
			set
			{
				this.o0O_0o.0O. = value;
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06004CDD RID: 19677 RVA: 0x0022CBA4 File Offset: 0x0022ADA4
		// (set) Token: 0x06004CDE RID: 19678 RVA: 0x0022CBC8 File Offset: 0x0022ADC8
		[DefaultValue("||第[PageNo]页，共[PageCount]页")]
		public string PageFooter
		{
			get
			{
				string result;
				if (O_O0OO.O00.00OO000___.())
				{
					result = "||www.foxtable.com";
				}
				else
				{
					result = this.oO_.O0o.;
				}
				return result;
			}
			set
			{
				this.oO_.O0o. = value;
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06004CDF RID: 19679 RVA: 0x0022CBD1 File Offset: 0x0022ADD1
		// (set) Token: 0x06004CE0 RID: 19680 RVA: 0x0022CBD9 File Offset: 0x0022ADD9
		[DefaultValue(false)]
		public bool PageHeaderLine
		{
			get
			{
				return this.o00.o0.;
			}
			set
			{
				this.o00.o0. = value;
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06004CE1 RID: 19681 RVA: 0x0022CBE2 File Offset: 0x0022ADE2
		// (set) Token: 0x06004CE2 RID: 19682 RVA: 0x0022CBEA File Offset: 0x0022ADEA
		[DefaultValue(false)]
		public bool PageFooterLine
		{
			get
			{
				return this.oOoo.OOo_.;
			}
			set
			{
				this.oOoo.OOo_. = value;
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06004CE3 RID: 19683 RVA: 0x0022CBF3 File Offset: 0x0022ADF3
		// (set) Token: 0x06004CE4 RID: 19684 RVA: 0x0022CBFB File Offset: 0x0022ADFB
		[DefaultValue(3)]
		public int SpaceAfterPagerHeader
		{
			get
			{
				return this.oO__0_.O0_0O.;
			}
			set
			{
				this.oO__0_.O0_0O. = value;
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x0022CC04 File Offset: 0x0022AE04
		// (set) Token: 0x06004CE6 RID: 19686 RVA: 0x0022CC0C File Offset: 0x0022AE0C
		[DefaultValue(3)]
		public int SpaceBeforePagerFooter
		{
			get
			{
				return this.oO._0Oo_0000o0.;
			}
			set
			{
				this.oO._0Oo_0000o0. = value;
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x0022CC15 File Offset: 0x0022AE15
		// (set) Token: 0x06004CE8 RID: 19688 RVA: 0x0022CC1D File Offset: 0x0022AE1D
		[DefaultValue(3)]
		public int SpaceAfterTitle
		{
			get
			{
				return this.o_.__o0_O.;
			}
			set
			{
				this.o_.__o0_O. = value;
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06004CE9 RID: 19689 RVA: 0x0022CC26 File Offset: 0x0022AE26
		// (set) Token: 0x06004CEA RID: 19690 RVA: 0x0022CC2E File Offset: 0x0022AE2E
		[DefaultValue(3)]
		public int SpaceAfterSubtitle
		{
			get
			{
				return this.ooo_oo0.Ooo0o0.;
			}
			set
			{
				this.ooo_oo0.Ooo0o0. = value;
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06004CEB RID: 19691 RVA: 0x0022CC37 File Offset: 0x0022AE37
		// (set) Token: 0x06004CEC RID: 19692 RVA: 0x0022CC3F File Offset: 0x0022AE3F
		[DefaultValue("宋体,9")]
		public Font PageHeaderFont
		{
			get
			{
				return this.o00.o0.;
			}
			set
			{
				this.o00.o0. = value;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06004CED RID: 19693 RVA: 0x0022CC48 File Offset: 0x0022AE48
		// (set) Token: 0x06004CEE RID: 19694 RVA: 0x0022CC50 File Offset: 0x0022AE50
		[DefaultValue("宋体,9")]
		public Font PageFooterFont
		{
			get
			{
				return this.oOoo.OOo_.;
			}
			set
			{
				this.oOoo.OOo_. = value;
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06004CEF RID: 19695 RVA: 0x0022CC59 File Offset: 0x0022AE59
		// (set) Token: 0x06004CF0 RID: 19696 RVA: 0x0022CC61 File Offset: 0x0022AE61
		[DefaultValue("宋体,16,Bold")]
		public Font TitleFont
		{
			get
			{
				return this.o_0OO0.O__O00o.;
			}
			set
			{
				this.o_0OO0.O__O00o. = value;
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06004CF1 RID: 19697 RVA: 0x0022CC6A File Offset: 0x0022AE6A
		// (set) Token: 0x06004CF2 RID: 19698 RVA: 0x0022CC72 File Offset: 0x0022AE72
		[DefaultValue("宋体,12")]
		public Font SubtitleFont
		{
			get
			{
				return this.o_o0oO.__0.;
			}
			set
			{
				this.o_o0oO.__0. = value;
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06004CF3 RID: 19699 RVA: 0x0022CC7B File Offset: 0x0022AE7B
		// (set) Token: 0x06004CF4 RID: 19700 RVA: 0x0022CC83 File Offset: 0x0022AE83
		[DefaultValue(1)]
		public int PageColumns
		{
			get
			{
				return this.oO_.O0o.;
			}
			set
			{
				this.oO_.O0o. = value;
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06004CF5 RID: 19701 RVA: 0x0022CC8C File Offset: 0x0022AE8C
		// (set) Token: 0x06004CF6 RID: 19702 RVA: 0x0022CC94 File Offset: 0x0022AE94
		[DefaultValue("")]
		public string WaterMark
		{
			get
			{
				return this.O__O.O0_O.;
			}
			set
			{
				this.O__O.O0_O. = value;
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06004CF7 RID: 19703 RVA: 0x0022CC9D File Offset: 0x0022AE9D
		// (set) Token: 0x06004CF8 RID: 19704 RVA: 0x0022CCA5 File Offset: 0x0022AEA5
		[DefaultValue(true)]
		public bool RepeatFixedRows
		{
			get
			{
				return this.o.ooo0_o_0O.;
			}
			set
			{
				this.o.ooo0_o_0O. = value;
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06004CF9 RID: 19705 RVA: 0x0022CCAE File Offset: 0x0022AEAE
		// (set) Token: 0x06004CFA RID: 19706 RVA: 0x0022CCB6 File Offset: 0x0022AEB6
		[DefaultValue(true)]
		public bool RepeatFixedCols
		{
			get
			{
				return this.o0.0_o_O.;
			}
			set
			{
				this.o0.0_o_O. = value;
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06004CFB RID: 19707 RVA: 0x0022CCBF File Offset: 0x0022AEBF
		// (set) Token: 0x06004CFC RID: 19708 RVA: 0x0022CCC7 File Offset: 0x0022AEC7
		[DefaultValue(true)]
		public bool PrintFixedCols
		{
			get
			{
				return this.ooo_oo0.Ooo0o0.;
			}
			set
			{
				this.ooo_oo0.Ooo0o0. = value;
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06004CFD RID: 19709 RVA: 0x0022CCD0 File Offset: 0x0022AED0
		// (set) Token: 0x06004CFE RID: 19710 RVA: 0x0022CCD8 File Offset: 0x0022AED8
		[DefaultValue(true)]
		public bool ExcuteDrawCell
		{
			get
			{
				return this.oo0o.OoO_0_Oo.;
			}
			set
			{
				this.oo0o.OoO_0_Oo. = value;
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06004CFF RID: 19711 RVA: 0x0022CCE1 File Offset: 0x0022AEE1
		// (set) Token: 0x06004D00 RID: 19712 RVA: 0x0022CCE9 File Offset: 0x0022AEE9
		[DefaultValue(false)]
		public bool FitIntoPage
		{
			get
			{
				return this.O._o0o.;
			}
			set
			{
				this.O._o0o. = value;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06004D01 RID: 19713 RVA: 0x0022CCF2 File Offset: 0x0022AEF2
		// (set) Token: 0x06004D02 RID: 19714 RVA: 0x0022CCFA File Offset: 0x0022AEFA
		[DefaultValue(true)]
		public bool WrapMemo
		{
			get
			{
				return this.O0.__o_O000O.;
			}
			set
			{
				this.O0.__o_O000O. = value;
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06004D03 RID: 19715 RVA: 0x0022CD03 File Offset: 0x0022AF03
		// (set) Token: 0x06004D04 RID: 19716 RVA: 0x0022CD0B File Offset: 0x0022AF0B
		[DefaultValue(true)]
		public bool ExtendMemoRow
		{
			get
			{
				return this.OOo._o0O__00_O.;
			}
			set
			{
				this.OOo._o0O__00_O. = value;
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06004D05 RID: 19717 RVA: 0x0022CD14 File Offset: 0x0022AF14
		// (set) Token: 0x06004D06 RID: 19718 RVA: 0x0022CD1C File Offset: 0x0022AF1C
		[DefaultValue(true)]
		public bool OnlyPrintTitleOnFirstPage
		{
			get
			{
				return this.O_O.O_00.;
			}
			set
			{
				this.O_O.O_00. = value;
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06004D07 RID: 19719 RVA: 0x0022CD25 File Offset: 0x0022AF25
		// (set) Token: 0x06004D08 RID: 19720 RVA: 0x0022CD2D File Offset: 0x0022AF2D
		[DefaultValue(true)]
		public bool AdjustFontSize
		{
			get
			{
				return this.O_oO.O.;
			}
			set
			{
				this.O_oO.O. = value;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06004D09 RID: 19721 RVA: 0x0022CD36 File Offset: 0x0022AF36
		// (set) Token: 0x06004D0A RID: 19722 RVA: 0x0022CD3E File Offset: 0x0022AF3E
		[DefaultValue(false)]
		public bool OnlySelectedRows
		{
			get
			{
				return this.O0OoO___.OO.;
			}
			set
			{
				this.O0OoO___.OO. = value;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06004D0B RID: 19723 RVA: 0x0022CD47 File Offset: 0x0022AF47
		// (set) Token: 0x06004D0C RID: 19724 RVA: 0x0022CD4F File Offset: 0x0022AF4F
		[DefaultValue(false)]
		public bool Renumber
		{
			get
			{
				return this.o._0_O__0.;
			}
			set
			{
				this.o._0_O__0. = value;
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06004D0D RID: 19725 RVA: 0x0022CD58 File Offset: 0x0022AF58
		// (set) Token: 0x06004D0E RID: 19726 RVA: 0x0022CD60 File Offset: 0x0022AF60
		[DefaultValue(true)]
		public bool EnableStyle
		{
			get
			{
				return this.ooo0o_.__O.;
			}
			set
			{
				this.ooo0o_.__O. = value;
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06004D0F RID: 19727 RVA: 0x0022CD69 File Offset: 0x0022AF69
		// (set) Token: 0x06004D10 RID: 19728 RVA: 0x0022CD71 File Offset: 0x0022AF71
		[DefaultValue(true)]
		public bool PrintTitle
		{
			get
			{
				return this.oo_0O.__0o0O.;
			}
			set
			{
				this.oo_0O.__0o0O. = value;
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06004D11 RID: 19729 RVA: 0x0022CD7A File Offset: 0x0022AF7A
		// (set) Token: 0x06004D12 RID: 19730 RVA: 0x0022CD82 File Offset: 0x0022AF82
		[DefaultValue(true)]
		public bool PrintHeader
		{
			get
			{
				return this.oOOo_o0oo.00.;
			}
			set
			{
				this.oOOo_o0oo.00. = value;
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06004D13 RID: 19731 RVA: 0x0022CD8B File Offset: 0x0022AF8B
		// (set) Token: 0x06004D14 RID: 19732 RVA: 0x0022CD93 File Offset: 0x0022AF93
		[DefaultValue(true)]
		public bool PrintFooter
		{
			get
			{
				return this.OOo__._00oo.;
			}
			set
			{
				this.OOo__._00oo. = value;
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06004D15 RID: 19733 RVA: 0x0022CD9C File Offset: 0x0022AF9C
		// (set) Token: 0x06004D16 RID: 19734 RVA: 0x0022CDA4 File Offset: 0x0022AFA4
		[DefaultValue(false)]
		public bool ExtendLastCol
		{
			get
			{
				return this.O_oO0_O.0.;
			}
			set
			{
				this.O_oO0_O.0. = value;
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06004D17 RID: 19735 RVA: 0x0022CDAD File Offset: 0x0022AFAD
		// (set) Token: 0x06004D18 RID: 19736 RVA: 0x0022CDB5 File Offset: 0x0022AFB5
		[DefaultValue(false)]
		public bool DirectFitIntoPage
		{
			get
			{
				return this.o__oO_.O.;
			}
			set
			{
				this.o__oO_.O. = value;
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06004D19 RID: 19737 RVA: 0x0022CDBE File Offset: 0x0022AFBE
		// (set) Token: 0x06004D1A RID: 19738 RVA: 0x0022CDC6 File Offset: 0x0022AFC6
		[DefaultValue(false)]
		public bool DirectFitIntoOnePage
		{
			get
			{
				return this.ooOooO0o0o.ooo.;
			}
			set
			{
				this.ooOooO0o0o.ooo. = value;
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06004D1B RID: 19739 RVA: 0x0022CDCF File Offset: 0x0022AFCF
		// (set) Token: 0x06004D1C RID: 19740 RVA: 0x0022CDD7 File Offset: 0x0022AFD7
		[DefaultValue(false)]
		public bool DirectExtendLastCol
		{
			get
			{
				return this.Oo_0O0_0.Oo.;
			}
			set
			{
				this.Oo_0O0_0.Oo. = value;
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06004D1D RID: 19741 RVA: 0x0022CDE0 File Offset: 0x0022AFE0
		// (set) Token: 0x06004D1E RID: 19742 RVA: 0x0022CDE8 File Offset: 0x0022AFE8
		[DefaultValue("")]
		public string DirectPageHeader
		{
			get
			{
				return this.o0OOO0_o.oO00_.;
			}
			set
			{
				this.o0OOO0_o.oO00_. = value;
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06004D1F RID: 19743 RVA: 0x0022CDF1 File Offset: 0x0022AFF1
		// (set) Token: 0x06004D20 RID: 19744 RVA: 0x0022CDF9 File Offset: 0x0022AFF9
		[DefaultValue("")]
		public string DirectPageFooter
		{
			get
			{
				return this.OO00__00_0.__0.;
			}
			set
			{
				this.OO00__00_0.__0. = value;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x0022CE02 File Offset: 0x0022B002
		// (set) Token: 0x06004D22 RID: 19746 RVA: 0x0022CE0A File Offset: 0x0022B00A
		[DefaultValue(true)]
		public bool DirectHighLight
		{
			get
			{
				return this.oO.OoO_.;
			}
			set
			{
				this.oO.OoO_. = value;
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06004D23 RID: 19747 RVA: 0x0022CE13 File Offset: 0x0022B013
		// (set) Token: 0x06004D24 RID: 19748 RVA: 0x0022CE1B File Offset: 0x0022B01B
		[DefaultValue("宋体,9")]
		public Font DirectPageHeaderFont
		{
			get
			{
				return this.OO_O_o0_O.o.;
			}
			set
			{
				this.OO_O_o0_O.o. = value;
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06004D25 RID: 19749 RVA: 0x0022CE24 File Offset: 0x0022B024
		// (set) Token: 0x06004D26 RID: 19750 RVA: 0x0022CE2C File Offset: 0x0022B02C
		[DefaultValue(true)]
		public bool DirectPrintHeader
		{
			get
			{
				return this.oOo.oo.;
			}
			set
			{
				this.oOo.oo. = value;
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06004D27 RID: 19751 RVA: 0x0022CE35 File Offset: 0x0022B035
		// (set) Token: 0x06004D28 RID: 19752 RVA: 0x0022CE3D File Offset: 0x0022B03D
		[DefaultValue(true)]
		public bool DirectPrintFooter
		{
			get
			{
				return this.oOo0_.OooOOo.;
			}
			set
			{
				this.oOo0_.OooOOo. = value;
			}
		}

		// Token: 0x04001F51 RID: 8017
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001F52 RID: 8018
		private const string <<EMPTY_NAME>> = "[TableCaption]";

		// Token: 0x04001F53 RID: 8019
		private string <<EMPTY_NAME>>;

		// Token: 0x04001F54 RID: 8020
		private string <<EMPTY_NAME>>;

		// Token: 0x04001F55 RID: 8021
		private const string <<EMPTY_NAME>> = "||第[PageNo]页，共[PageCount]页";

		// Token: 0x04001F56 RID: 8022
		private string <<EMPTY_NAME>>;

		// Token: 0x04001F57 RID: 8023
		private string <<EMPTY_NAME>>;

		// Token: 0x04001F58 RID: 8024
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F59 RID: 8025
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F5A RID: 8026
		private Font <<EMPTY_NAME>>;

		// Token: 0x04001F5B RID: 8027
		private Font <<EMPTY_NAME>>;

		// Token: 0x04001F5C RID: 8028
		private Font <<EMPTY_NAME>>;

		// Token: 0x04001F5D RID: 8029
		private Font <<EMPTY_NAME>>;

		// Token: 0x04001F5E RID: 8030
		private int <<EMPTY_NAME>>;

		// Token: 0x04001F5F RID: 8031
		private int <<EMPTY_NAME>>;

		// Token: 0x04001F60 RID: 8032
		private int <<EMPTY_NAME>>;

		// Token: 0x04001F61 RID: 8033
		private int <<EMPTY_NAME>>;

		// Token: 0x04001F62 RID: 8034
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F63 RID: 8035
		private int <<EMPTY_NAME>>;

		// Token: 0x04001F64 RID: 8036
		private string <<EMPTY_NAME>>;

		// Token: 0x04001F65 RID: 8037
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F66 RID: 8038
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F67 RID: 8039
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F68 RID: 8040
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F69 RID: 8041
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F6A RID: 8042
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F6B RID: 8043
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F6C RID: 8044
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F6D RID: 8045
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F6E RID: 8046
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F6F RID: 8047
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F70 RID: 8048
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F71 RID: 8049
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F72 RID: 8050
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F73 RID: 8051
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F74 RID: 8052
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F75 RID: 8053
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F76 RID: 8054
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F77 RID: 8055
		private string <<EMPTY_NAME>>;

		// Token: 0x04001F78 RID: 8056
		private string <<EMPTY_NAME>>;

		// Token: 0x04001F79 RID: 8057
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F7A RID: 8058
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F7B RID: 8059
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001F7C RID: 8060
		private Font <<EMPTY_NAME>>;
	}
}
