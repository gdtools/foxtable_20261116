using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using C1.Win.C1Chart;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x020003BA RID: 954
	[ComVisible(true)]
	public class Chart : Control
	{
		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x001BF3D9 File Offset: 0x001BD5D9
		// (set) Token: 0x06003DBB RID: 15803 RVA: 0x001BF3E1 File Offset: 0x001BD5E1
		protected virtual C1Chart C1Chart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06003DBC RID: 15804 RVA: 0x001BF3EC File Offset: 0x001BD5EC
		internal void <<EMPTY_NAME>>()
		{
			this.C1Chart.ToolTip.Enabled = true;
			this.C1Chart.ChartArea.AxisX.AnnoFormat = FormatEnum.NumericManual;
			this.C1Chart.ChartArea.AxisY.AnnoFormat = FormatEnum.NumericManual;
			this.C1Chart.ChartArea.AxisY2.AnnoFormat = FormatEnum.NumericManual;
			this.C1Chart.ChartArea.Style.BackColor = Color.White;
			this.C1Chart.Style.Border.Color = SystemColors.ControlDark;
			this.C1Chart.Style.Border.Thickness = 1;
			this.C1Chart.Style.Border.BorderStyle = BorderStyleEnum.Solid;
			this.C1Chart.ChartArea.Style.Border.BorderStyle = BorderStyleEnum.Solid;
			this.C1Chart.ChartArea.Style.Border.Rounding.All = 10;
			this.C1Chart.ChartArea.Style.Border.Thickness = 1;
			this.C1Chart.ChartArea.Style.Border.Color = SystemColors.ControlDarkDark;
			this.C1Chart.Header.Visible = false;
			this.C1Chart.Footer.Visible = false;
			this.C1Chart.ChartArea.AxisX.GridMajor.Visible = true;
			this.C1Chart.ChartArea.AxisX.ForeColor = SystemColors.ControlDarkDark;
			this.C1Chart.ChartArea.AxisY.GridMajor.Visible = true;
			this.C1Chart.ChartArea.AxisY.ForeColor = SystemColors.ControlDarkDark;
			this.C1Chart.ChartArea.AxisY2.GridMajor.Visible = true;
			this.C1Chart.ChartArea.AxisY2.ForeColor = SystemColors.ControlDarkDark;
			this.C1Chart.ColorGeneration = ColorGeneration.Median;
			this.C1Chart.UseAntiAliasedGraphics = true;
			this.C1Chart.UseDoubleBuffer = true;
			this.C1Chart.ChartGroups[0].Radar.Filled = true;
			this.C1Chart.ChartGroups[1].Radar.Filled = true;
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x001BF640 File Offset: 0x001BD840
		public Chart(C1Chart A_0) : base(A_0, ControlTypeEnum.Chart)
		{
			this.C1Chart = A_0;
			this.o__0oo0o_O.o. = new ChartAxis(this.C1Chart.ChartArea.AxisX);
			this.o._0OooO_0. = new ChartAxis(this.C1Chart.ChartArea.AxisY);
			this.oOo.O00o0OOoo. = new ChartAxis(this.C1Chart.ChartArea.AxisY2);
			this.oOOO_.__oO0O. = new ChartSerialCollection(this.C1Chart.ChartGroups[0].ChartData.SeriesList, this.C1Chart);
			this.OOoOO_.0. = new ChartSerialCollection(this.C1Chart.ChartGroups[1].ChartData.SeriesList, this.C1Chart);
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06003DBE RID: 15806 RVA: 0x001BF706 File Offset: 0x001BD906
		// (set) Token: 0x06003DBF RID: 15807 RVA: 0x001BF710 File Offset: 0x001BD910
		[oO0oooo("0967")]
		public string DataSource
		{
			get
			{
				return this.o__0oo0o_O.o.;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0)
				{
					this.o__0oo0o_O.o. = "";
					this.C1Chart.DataSource = "";
					return;
				}
				if (O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(value))
				{
					DataView dataSource = new DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables[value], this.DataFilter, "", DataViewRowState.CurrentRows);
					this.C1Chart.DataSource = dataSource;
				}
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06003DC0 RID: 15808 RVA: 0x001BF788 File Offset: 0x001BD988
		// (set) Token: 0x06003DC1 RID: 15809 RVA: 0x001BF7E8 File Offset: 0x001BD9E8
		[oO0oooo("0967")]
		public DataTable DataTable
		{
			get
			{
				DataTable result;
				if (this.oOOO_.__oO0O. != null)
				{
					result = this.oOOO_.__oO0O.;
				}
				else if (Operators.CompareString(this.DataSource, "", true) > 0)
				{
					if (OO_00oOO.DataTables.Contains(this.DataSource))
					{
						result = OO_00oOO.DataTables[this.DataSource];
					}
					else
					{
						result = null;
					}
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				this.oOOO_.__oO0O. = value;
				DataView dataSource = new DataView(value.BaseTable, this.DataFilter, "", DataViewRowState.CurrentRows);
				this.C1Chart.DataSource = dataSource;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06003DC2 RID: 15810 RVA: 0x001BF821 File Offset: 0x001BDA21
		// (set) Token: 0x06003DC3 RID: 15811 RVA: 0x001BF829 File Offset: 0x001BDA29
		[oO0oooo("0967")]
		public string DataFilter
		{
			get
			{
				return this.o._0OooO_0.;
			}
			set
			{
				this.o._0OooO_0. = value;
				if (this.C1Chart.DataSource != null)
				{
					((DataView)this.C1Chart.DataSource).RowFilter = value;
				}
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06003DC4 RID: 15812 RVA: 0x001BF855 File Offset: 0x001BDA55
		// (set) Token: 0x06003DC5 RID: 15813 RVA: 0x001BF86D File Offset: 0x001BDA6D
		public bool VisualEffect
		{
			get
			{
				return this.C1Chart.VisualEffects[0].Enabled;
			}
			set
			{
				this.C1Chart.VisualEffects[0].Enabled = value;
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06003DC6 RID: 15814 RVA: 0x001BF886 File Offset: 0x001BDA86
		public ChartAxis AxisX
		{
			get
			{
				return this.o__0oo0o_O.o.;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06003DC7 RID: 15815 RVA: 0x001BF88E File Offset: 0x001BDA8E
		public ChartAxis AxisY
		{
			get
			{
				return this.o._0OooO_0.;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x001BF896 File Offset: 0x001BDA96
		public ChartAxis AxisY2
		{
			get
			{
				return this.oOo.O00o0OOoo.;
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x001BF89E File Offset: 0x001BDA9E
		// (set) Token: 0x06003DCA RID: 15818 RVA: 0x001BF8B0 File Offset: 0x001BDAB0
		[oO0oooo("0987")]
		public bool InVerted
		{
			get
			{
				return this.C1Chart.ChartArea.Inverted;
			}
			set
			{
				this.C1Chart.ChartArea.Inverted = value;
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06003DCB RID: 15819 RVA: 0x001BF8C3 File Offset: 0x001BDAC3
		[oO0oooo("0999")]
		public ChartSerialCollection SeriesList
		{
			get
			{
				return this.oOOO_.__oO0O.;
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06003DCC RID: 15820 RVA: 0x001BF8CB File Offset: 0x001BDACB
		[oO0oooo("1005")]
		public ChartSerialCollection SeriesList2
		{
			get
			{
				return this.OOoOO_.0.;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06003DCD RID: 15821 RVA: 0x001BF8D3 File Offset: 0x001BDAD3
		// (set) Token: 0x06003DCE RID: 15822 RVA: 0x001BF8EB File Offset: 0x001BDAEB
		[oO0oooo("0988")]
		public bool Stacked
		{
			get
			{
				return this.C1Chart.ChartGroups[0].Stacked;
			}
			set
			{
				this.C1Chart.ChartGroups[0].Stacked = value;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06003DCF RID: 15823 RVA: 0x001BF904 File Offset: 0x001BDB04
		// (set) Token: 0x06003DD0 RID: 15824 RVA: 0x001BF91C File Offset: 0x001BDB1C
		[oO0oooo("0988")]
		public bool Is100Percent
		{
			get
			{
				return this.C1Chart.ChartGroups[0].Is100Percent;
			}
			set
			{
				this.C1Chart.ChartGroups[0].Is100Percent = value;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06003DD1 RID: 15825 RVA: 0x001BF935 File Offset: 0x001BDB35
		// (set) Token: 0x06003DD2 RID: 15826 RVA: 0x001BF952 File Offset: 0x001BDB52
		[oO0oooo("0988")]
		public bool BarLines
		{
			get
			{
				return this.C1Chart.ChartGroups[0].Bar.BarLines;
			}
			set
			{
				this.C1Chart.ChartGroups[0].Bar.BarLines = value;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06003DD3 RID: 15827 RVA: 0x001BF970 File Offset: 0x001BDB70
		// (set) Token: 0x06003DD4 RID: 15828 RVA: 0x001BF98D File Offset: 0x001BDB8D
		[oO0oooo("1004")]
		public bool BarLines2
		{
			get
			{
				return this.C1Chart.ChartGroups[1].Bar.BarLines;
			}
			set
			{
				this.C1Chart.ChartGroups[1].Bar.BarLines = value;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x001BF9AB File Offset: 0x001BDBAB
		// (set) Token: 0x06003DD6 RID: 15830 RVA: 0x001BF9C3 File Offset: 0x001BDBC3
		[oO0oooo("1004")]
		public bool Stacked2
		{
			get
			{
				return this.C1Chart.ChartGroups[1].Stacked;
			}
			set
			{
				this.C1Chart.ChartGroups[1].Stacked = value;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06003DD7 RID: 15831 RVA: 0x001BF9DC File Offset: 0x001BDBDC
		// (set) Token: 0x06003DD8 RID: 15832 RVA: 0x001BF9F4 File Offset: 0x001BDBF4
		[oO0oooo("1004")]
		public bool Is100Percent2
		{
			get
			{
				return this.C1Chart.ChartGroups[1].Is100Percent;
			}
			set
			{
				this.C1Chart.ChartGroups[1].Is100Percent = value;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06003DD9 RID: 15833 RVA: 0x001BFA0D File Offset: 0x001BDC0D
		// (set) Token: 0x06003DDA RID: 15834 RVA: 0x001BFA2A File Offset: 0x001BDC2A
		[oO0oooo("6008")]
		public int PieInnerRadius
		{
			get
			{
				return this.C1Chart.ChartGroups[0].Pie.InnerRadius;
			}
			set
			{
				this.C1Chart.ChartGroups[0].Pie.InnerRadius = value;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06003DDB RID: 15835 RVA: 0x001BFA48 File Offset: 0x001BDC48
		// (set) Token: 0x06003DDC RID: 15836 RVA: 0x001BFA65 File Offset: 0x001BDC65
		[oO0oooo("6009")]
		public int PieInnerRadius2
		{
			get
			{
				return this.C1Chart.ChartGroups[1].Pie.InnerRadius;
			}
			set
			{
				this.C1Chart.ChartGroups[1].Pie.InnerRadius = value;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06003DDD RID: 15837 RVA: 0x001BFA83 File Offset: 0x001BDC83
		// (set) Token: 0x06003DDE RID: 15838 RVA: 0x001BFA9B File Offset: 0x001BDC9B
		[oO0oooo("0990.htm")]
		public ChartTypeEnum ChartType
		{
			get
			{
				return (ChartTypeEnum)this.C1Chart.ChartGroups[0].ChartType;
			}
			set
			{
				this.C1Chart.ChartGroups[0].ChartType = (Chart2DTypeEnum)value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06003DDF RID: 15839 RVA: 0x001BFAB4 File Offset: 0x001BDCB4
		// (set) Token: 0x06003DE0 RID: 15840 RVA: 0x001BFACC File Offset: 0x001BDCCC
		[oO0oooo("01003")]
		public ChartTypeEnum ChartType2
		{
			get
			{
				return (ChartTypeEnum)this.C1Chart.ChartGroups[1].ChartType;
			}
			set
			{
				this.C1Chart.ChartGroups[1].ChartType = (Chart2DTypeEnum)value;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06003DE1 RID: 15841 RVA: 0x001BFAE5 File Offset: 0x001BDCE5
		// (set) Token: 0x06003DE2 RID: 15842 RVA: 0x001BFB02 File Offset: 0x001BDD02
		[oO0oooo("01003")]
		public int BarClusterWidth
		{
			get
			{
				return this.C1Chart.ChartGroups[0].Bar.ClusterWidth;
			}
			set
			{
				this.C1Chart.ChartGroups[0].Bar.ClusterWidth = value;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06003DE3 RID: 15843 RVA: 0x001BFB20 File Offset: 0x001BDD20
		// (set) Token: 0x06003DE4 RID: 15844 RVA: 0x001BFB3D File Offset: 0x001BDD3D
		[oO0oooo("1006")]
		public int BarClusterWidth2
		{
			get
			{
				return this.C1Chart.ChartGroups[1].Bar.ClusterWidth;
			}
			set
			{
				this.C1Chart.ChartGroups[1].Bar.ClusterWidth = value;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06003DE5 RID: 15845 RVA: 0x001BFB5B File Offset: 0x001BDD5B
		// (set) Token: 0x06003DE6 RID: 15846 RVA: 0x001BFB6D File Offset: 0x001BDD6D
		[oO0oooo("0991")]
		public bool LegendVisible
		{
			get
			{
				return this.C1Chart.Legend.Visible;
			}
			set
			{
				this.C1Chart.Legend.Visible = value;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06003DE7 RID: 15847 RVA: 0x001BFB80 File Offset: 0x001BDD80
		// (set) Token: 0x06003DE8 RID: 15848 RVA: 0x001BFB92 File Offset: 0x001BDD92
		[oO0oooo("0992")]
		public CompassEnum LegendCompass
		{
			get
			{
				return (CompassEnum)this.C1Chart.Legend.Compass;
			}
			set
			{
				this.C1Chart.Legend.Compass = (CompassEnum)value;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06003DE9 RID: 15849 RVA: 0x001BFBA5 File Offset: 0x001BDDA5
		// (set) Token: 0x06003DEA RID: 15850 RVA: 0x001BFBB7 File Offset: 0x001BDDB7
		public string LegendText
		{
			get
			{
				return this.C1Chart.Legend.Text;
			}
			set
			{
				this.C1Chart.Legend.Text = value;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06003DEB RID: 15851 RVA: 0x001BFBCA File Offset: 0x001BDDCA
		// (set) Token: 0x06003DEC RID: 15852 RVA: 0x001BFBE1 File Offset: 0x001BDDE1
		public Font LegendFont
		{
			get
			{
				return this.C1Chart.Legend.Style.Font;
			}
			set
			{
				this.C1Chart.Legend.Style.Font = value;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06003DED RID: 15853 RVA: 0x001BFBF9 File Offset: 0x001BDDF9
		// (set) Token: 0x06003DEE RID: 15854 RVA: 0x001BFC0B File Offset: 0x001BDE0B
		public string HeaderText
		{
			get
			{
				return this.C1Chart.Header.Text;
			}
			set
			{
				this.C1Chart.Header.Text = value;
				this.C1Chart.Header.Visible = (Operators.CompareString(value, "", true) > 0);
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06003DEF RID: 15855 RVA: 0x001BFC3D File Offset: 0x001BDE3D
		// (set) Token: 0x06003DF0 RID: 15856 RVA: 0x001BFC54 File Offset: 0x001BDE54
		public Font HeaderFont
		{
			get
			{
				return this.C1Chart.Header.Style.Font;
			}
			set
			{
				this.C1Chart.Header.Style.Font = value;
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06003DF1 RID: 15857 RVA: 0x001BFC6C File Offset: 0x001BDE6C
		// (set) Token: 0x06003DF2 RID: 15858 RVA: 0x001BFC7E File Offset: 0x001BDE7E
		public string FooterText
		{
			get
			{
				return this.C1Chart.Footer.Text;
			}
			set
			{
				this.C1Chart.Footer.Text = value;
				this.C1Chart.Footer.Visible = (Operators.CompareString(value, "", true) > 0);
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x001BFCB0 File Offset: 0x001BDEB0
		// (set) Token: 0x06003DF4 RID: 15860 RVA: 0x001BFCC7 File Offset: 0x001BDEC7
		public Font FooterFont
		{
			get
			{
				return this.C1Chart.Footer.Style.Font;
			}
			set
			{
				this.C1Chart.Footer.Style.Font = value;
			}
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x001BFCE0 File Offset: 0x001BDEE0
		[oO0oooo("1008")]
		public void Print(bool ScaleToPage, bool ShowPrintDialog)
		{
			PrintScaleEnum scaling;
			if (ScaleToPage)
			{
				scaling = PrintScaleEnum.ScaleToMax;
			}
			this.C1Chart.PrintDialogUsage = ShowPrintDialog;
			this.C1Chart.PrintChart(scaling);
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x001BFD0A File Offset: 0x001BDF0A
		[oO0oooo("1009")]
		public void PageSetup()
		{
			this.C1Chart.PageSetup();
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x001BFD17 File Offset: 0x001BDF17
		[oO0oooo("1010")]
		public void SaveImage(string FileName)
		{
			this.SaveImage(FileName, O_O0OO.OoO_00._.(FileName));
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x001BFD28 File Offset: 0x001BDF28
		[oO0oooo("1010")]
		public void SaveImage(string FileName, ImageFormat ImageFormat)
		{
			if (!c.OOOOO.o.().FileSystem.DirectoryExists(c.OOOOO.o.().FileSystem.GetParentPath(FileName)))
			{
				c.OOOOO.o.().FileSystem.CreateDirectory(c.OOOOO.o.().FileSystem.GetParentPath(FileName));
			}
			this.C1Chart.SaveImage(FileName, ImageFormat);
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x001BFD82 File Offset: 0x001BDF82
		public void SaveImage(Stream stream, ImageFormat ImageFormat)
		{
			this.C1Chart.SaveImage(stream, ImageFormat);
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x001BFD91 File Offset: 0x001BDF91
		public void SaveImage(Stream stream, ImageFormat ImageFormat, Size sz)
		{
			this.C1Chart.SaveImage(stream, ImageFormat, sz);
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x001BFDA1 File Offset: 0x001BDFA1
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Image GetImage(ImageFormat ImageFormat)
		{
			this.C1Chart.Style.Border.BorderStyle = BorderStyleEnum.None;
			Image image = this.C1Chart.GetImage(ImageFormat);
			this.C1Chart.Style.Border.BorderStyle = BorderStyleEnum.Solid;
			return image;
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x001BFDDB File Offset: 0x001BDFDB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Image GetImage()
		{
			return this.GetImage(ImageFormat.Bmp);
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x001BFDE8 File Offset: 0x001BDFE8
		public Image Image
		{
			get
			{
				return this.GetImage(ImageFormat.Wmf);
			}
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x001BFDF5 File Offset: 0x001BDFF5
		public void CopyImage()
		{
			c.OOOOO.o.().Clipboard.SetImage(this.GetImage(ImageFormat.Bmp));
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x001BFE14 File Offset: 0x001BE014
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool CoordToDataIndex(int CoodX, int CoodY, ref int SeriesIndex, ref int PointIndex)
		{
			int num;
			bool flag = this.C1Chart.ChartGroups[0].CoordToDataIndex(CoodX, CoodY, CoordinateFocusEnum.XandYCoord, ref SeriesIndex, ref PointIndex, ref num);
			return ((double)num <= Math.Ceiling((double)this.C1Chart.ChartGroups[0].ChartData.SeriesList[SeriesIndex].SymbolStyle.Size / 2.0) || num <= 2) && flag;
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x001BFE8C File Offset: 0x001BE08C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool CoordToDataIndex2(int CoodX, int CoodY, ref int SeriesIndex, ref int PointIndex)
		{
			int num;
			bool flag = this.C1Chart.ChartGroups[1].CoordToDataIndex(CoodX, CoodY, CoordinateFocusEnum.XandYCoord, ref SeriesIndex, ref PointIndex, ref num);
			return ((double)num <= Math.Ceiling((double)this.C1Chart.ChartGroups[1].ChartData.SeriesList[SeriesIndex].SymbolStyle.Size / 2.0) || num <= 2) && flag;
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06003E01 RID: 15873 RVA: 0x001BFF03 File Offset: 0x001BE103
		// (set) Token: 0x06003E02 RID: 15874 RVA: 0x001BFF22 File Offset: 0x001BE122
		[oO0oooo("1242")]
		public double PrintWidth
		{
			get
			{
				return (double)((float)this.C1Chart.Width / SysInfo.ScreenDpiX) * 25.4;
			}
			set
			{
				this.C1Chart.Width = (int)Math.Round(value / 25.4 * (double)SysInfo.ScreenDpiX);
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x001BFF47 File Offset: 0x001BE147
		// (set) Token: 0x06003E04 RID: 15876 RVA: 0x001BFF66 File Offset: 0x001BE166
		[oO0oooo("1242")]
		public double PrintHeight
		{
			get
			{
				return (double)((float)this.C1Chart.Height / SysInfo.ScreenDpiY) * 25.4;
			}
			set
			{
				this.C1Chart.Height = (int)Math.Round(value / 25.4 * (double)SysInfo.ScreenDpiY);
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06003E05 RID: 15877 RVA: 0x001BFF8B File Offset: 0x001BE18B
		// (set) Token: 0x06003E06 RID: 15878 RVA: 0x001BFFAC File Offset: 0x001BE1AC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ColorName
		{
			get
			{
				return Enum.GetName(typeof(ColorGeneration), this.C1Chart.ColorGeneration);
			}
			set
			{
				ColorGeneration colorGeneration;
				if (Enum.TryParse<ColorGeneration>(value, out colorGeneration))
				{
					this.C1Chart.ColorGeneration = colorGeneration;
				}
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06003E07 RID: 15879 RVA: 0x001BFFCF File Offset: 0x001BE1CF
		[oO0oooo("6002")]
		public Style ChartAreaStyle
		{
			get
			{
				return this.C1Chart.ChartArea.Style;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x001BFFE1 File Offset: 0x001BE1E1
		[oO0oooo("6002")]
		public PlotArea PlotAreaStyle
		{
			get
			{
				return this.C1Chart.ChartArea.PlotArea;
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06003E09 RID: 15881 RVA: 0x001BFFF3 File Offset: 0x001BE1F3
		[oO0oooo("6002")]
		public Style Style
		{
			get
			{
				return this.C1Chart.Style;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06003E0A RID: 15882 RVA: 0x001C0000 File Offset: 0x001BE200
		// (set) Token: 0x06003E0B RID: 15883 RVA: 0x001C0018 File Offset: 0x001BE218
		[oO0oooo("6007")]
		public bool ShowOutLine
		{
			get
			{
				return this.C1Chart.ChartGroups[0].ShowOutline;
			}
			set
			{
				this.C1Chart.ChartGroups[0].ShowOutline = value;
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06003E0C RID: 15884 RVA: 0x001C0031 File Offset: 0x001BE231
		// (set) Token: 0x06003E0D RID: 15885 RVA: 0x001C0049 File Offset: 0x001BE249
		[oO0oooo("6007")]
		public bool ShowOutLine2
		{
			get
			{
				return this.C1Chart.ChartGroups[1].ShowOutline;
			}
			set
			{
				this.C1Chart.ChartGroups[1].ShowOutline = value;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06003E0E RID: 15886 RVA: 0x001C0062 File Offset: 0x001BE262
		// (set) Token: 0x06003E0F RID: 15887 RVA: 0x001C007A File Offset: 0x001BE27A
		[oO0oooo("6007")]
		public Color OutLineColor
		{
			get
			{
				return this.C1Chart.ChartGroups[0].OutlineColor;
			}
			set
			{
				this.C1Chart.ChartGroups[0].OutlineColor = value;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x001C0093 File Offset: 0x001BE293
		// (set) Token: 0x06003E11 RID: 15889 RVA: 0x001C00AB File Offset: 0x001BE2AB
		[oO0oooo("6007")]
		public Color OutLineColor2
		{
			get
			{
				return this.C1Chart.ChartGroups[1].OutlineColor;
			}
			set
			{
				this.C1Chart.ChartGroups[1].OutlineColor = value;
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x001C00C4 File Offset: 0x001BE2C4
		public Style LegendStyle
		{
			get
			{
				return this.C1Chart.Legend.Style;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06003E13 RID: 15891 RVA: 0x001C00D6 File Offset: 0x001BE2D6
		public Style HeaderStyle
		{
			get
			{
				return this.C1Chart.Header.Style;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06003E14 RID: 15892 RVA: 0x001C00E8 File Offset: 0x001BE2E8
		public Style FooterStyle
		{
			get
			{
				return this.C1Chart.Footer.Style;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06003E15 RID: 15893 RVA: 0x001C00FA File Offset: 0x001BE2FA
		// (set) Token: 0x06003E16 RID: 15894 RVA: 0x001C0107 File Offset: 0x001BE307
		public ColorGeneration ColorGeneration
		{
			get
			{
				return this.C1Chart.ColorGeneration;
			}
			set
			{
				this.C1Chart.ColorGeneration = value;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06003E17 RID: 15895 RVA: 0x001C0115 File Offset: 0x001BE315
		[EditorBrowsable(EditorBrowsableState.Never)]
		public PointStylesCollection PointStyles1
		{
			get
			{
				return this.C1Chart.ChartGroups[0].ChartData.PointStylesList;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06003E18 RID: 15896 RVA: 0x001C0132 File Offset: 0x001BE332
		[EditorBrowsable(EditorBrowsableState.Never)]
		public PointStylesCollection PointStyles2
		{
			get
			{
				return this.C1Chart.ChartGroups[0].ChartData.PointStylesList;
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (set) Token: 0x06003E19 RID: 15897 RVA: 0x001C0150 File Offset: 0x001BE350
		public bool Transparent
		{
			set
			{
				if (value)
				{
					this.Style.Border.BorderStyle = BorderStyleEnum.None;
					this.ChartAreaStyle.Border.BorderStyle = BorderStyleEnum.None;
					this.Style.BackColor = Color.Transparent;
					this.ChartAreaStyle.BackColor = Color.Transparent;
					this.PlotAreaStyle.BackColor = Color.Transparent;
				}
			}
		}

		// Token: 0x0400194C RID: 6476
		[CompilerGenerated]
		[AccessedThroughProperty("C1Chart")]
		private C1Chart <<EMPTY_NAME>>;

		// Token: 0x0400194D RID: 6477
		private ChartAxis <<EMPTY_NAME>>;

		// Token: 0x0400194E RID: 6478
		private ChartAxis <<EMPTY_NAME>>;

		// Token: 0x0400194F RID: 6479
		private ChartAxis <<EMPTY_NAME>>;

		// Token: 0x04001950 RID: 6480
		private ChartSerialCollection <<EMPTY_NAME>>;

		// Token: 0x04001951 RID: 6481
		private ChartSerialCollection <<EMPTY_NAME>>;

		// Token: 0x04001952 RID: 6482
		private string <<EMPTY_NAME>>;

		// Token: 0x04001953 RID: 6483
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04001954 RID: 6484
		private string <<EMPTY_NAME>>;
	}
}
