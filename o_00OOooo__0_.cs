using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.C1Preview;
using C1.C1Preview.Export;
using C1.Win.C1FlexGrid;
using C1.Win.C1Preview;
using Foxtable.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000468 RID: 1128
	internal class o_00OOooo__0_
	{
		// Token: 0x06004C9D RID: 19613 RVA: 0x002295FF File Offset: 0x002277FF
		[CompilerGenerated]
		private virtual C1PrintDocument <<EMPTY_NAME>>()
		{
			return this.oOO_0o_.oOo_o0.;
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x00229608 File Offset: 0x00227808
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(C1PrintDocument A_0)
		{
			PageEventHandler value = new PageEventHandler(this.OoO0000.0.);
			C1PrintDocument c1PrintDocument = this.oOO_0o_.oOo_o0.;
			if (c1PrintDocument != null)
			{
				c1PrintDocument.PageAdded -= value;
			}
			this.oOO_0o_.oOo_o0. = A_0;
			c1PrintDocument = this.oOO_0o_.oOo_o0.;
			if (c1PrintDocument != null)
			{
				c1PrintDocument.PageAdded += value;
			}
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x0022964C File Offset: 0x0022784C
		internal o_00OOooo__0_(PrintInfo A_0, bool A_1 = false)
		{
			this.O0Oo.Oooo0. = null;
			this.o.o0o__0o0. = 0.0;
			this.OooO.00. = 0.0;
			this.O0.o___. = 0.0;
			this.oOOO0.O_O_o_0o. = 1.0;
			this.O_oo000._. = 0.0;
			this.oOO_0o_.oOo_o0. = 0;
			this.OooO.00. = -1;
			this.o.o0o__0o0. = new List<string>();
			try
			{
				this.O0Oo.Oooo0. = new o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000();
				if (A_1)
				{
					this.O0Oo.Oooo0..Text = "生成进度";
				}
				this.O0Oo.Oooo0..Show(Main.OO_O.o.);
				Application.DoEvents();
				this.O0Oo.Oooo0. = A_0;
				this.o.o0o__0o0. = A_0.Table.foxGrid;
				this.oOO_0o_.oOo_o0.(new C1PrintDocument());
				this.oo0.__0Oo.().DefaultUnit = UnitTypeEnum.Mm;
				if (Operators.CompareString(this.O0Oo.Oooo0..WaterMark, "", true) > 0)
				{
					Image image = OO_00oOO.GetImage(this.O0Oo.Oooo0..WaterMark);
					if (image != null)
					{
						RenderImage renderImage = new RenderImage(image);
						renderImage.Style.ImageAlign.AlignHorz = ImageAlignHorzEnum.Center;
						renderImage.Style.ImageAlign.AlignVert = ImageAlignVertEnum.Center;
						this.oo0.__0Oo.().PageLayout.Watermark = renderImage;
					}
				}
				this.o.o0o__0o0. = Graphics.FromHwnd(IntPtr.Zero);
				if (this.O0Oo.Oooo0..ExtendMemoRow || this.O0Oo.Oooo0..WrapMemo)
				{
					try
					{
						foreach (object obj in A_0.Table.DataTable.BaseTable.Columns)
						{
							DataColumn dataColumn = (DataColumn)obj;
							if (this.o.o0o__0o0..Cols.Contains(dataColumn.ColumnName) && this.o.o0o__0o0..Cols[dataColumn.ColumnName].Visible && (dataColumn.DataType == typeof(string) & (dataColumn.MaxLength == -1 | dataColumn.MaxLength > 255)))
							{
								this.o.o0o__0o0..Add(dataColumn.ColumnName);
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
				C1PageSettings pageSettings = this.oo0.__0Oo.().PageLayout.PageSettings;
				pageSettings.PaperKind = this.o.o0o__0o0..PrintParameters.PrintDocument.DefaultPageSettings.PaperSize.Kind;
				pageSettings.Landscape = A_0.LandScape;
				if (pageSettings.PaperKind == PaperKind.Custom)
				{
					this.oo0.__0Oo.().PageLayout.PageSettings.Width = A_0.PaperWidth;
					this.oo0.__0Oo.().PageLayout.PageSettings.Height = A_0.PaperHeight;
				}
				pageSettings.LeftMargin = A_0.LeftMargin;
				pageSettings.RightMargin = A_0.RightMargin;
				pageSettings.TopMargin = A_0.TopMargin;
				pageSettings.BottomMargin = A_0.BottomMargin;
				if (Operators.CompareString(A_0.PaperSource, "", true) > 0)
				{
					try
					{
						foreach (object obj2 in pageSettings.PageLayout.PageSettings.ToPageSettings().PrinterSettings.PaperSources)
						{
							PaperSource paperSource = (PaperSource)obj2;
							if (Operators.CompareString(paperSource.SourceName, A_0.PaperSource, true) == 0)
							{
								pageSettings.PaperSourceKind = paperSource.Kind;
							}
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
				this.O0Oo.Oooo0. = new StringFormat();
				this.O0Oo.Oooo0..Alignment = StringAlignment.Near;
				this.O0Oo.Oooo0..LineAlignment = StringAlignment.Near;
				this.o.o0o__0o0. = this.o.o0o__0o0..DpiX;
				this.o.OO__0. = (float)this.O0Oo.Oooo0..PageSettings.PrinterResolution.X;
				C1PageSettings pageSettings2 = this.oo0.__0Oo.().PageLayout.PageSettings;
				this.OooO.00. = pageSettings2.Width.Value - pageSettings2.LeftMargin.Value - pageSettings2.RightMargin.Value;
				this.o.o0o__0o0. = pageSettings2.Height.Value - pageSettings2.TopMargin.Value - pageSettings2.BottomMargin.Value;
				this.O0.o___. = this.OooO.00. - C1.C1Preview.Utils.ConvertUnits(LineDef.Default.Width.Value * 2.0, LineDef.Default.Width.Units, UnitTypeEnum.Mm, this.o.OO__0., this.o.OO__0.);
				this.O0.o___. = C1.C1Preview.Utils.ConvertUnits(this.O0.o___., UnitTypeEnum.Mm, UnitTypeEnum.Pixel, this.o.OO__0., this.o.o0o__0o0.);
				Color color = this.o.o0o__0o0..Styles.Normal.Border.Color;
				BorderStyleEnum style = this.o.o0o__0o0..Styles.Normal.Border.Style;
				if (style == BorderStyleEnum.Dotted)
				{
					this.oOO_0o_.oOo_o0. = new LineDef(LineDef.Default.Width, color, DashStyle.Dot);
				}
				else
				{
					this.oOO_0o_.oOo_o0. = new LineDef(LineDef.Default.Width, color, DashStyle.Solid);
				}
				this.o0000_Ooo.O_.();
				this.O0Oo.Oooo0..Oo0._.("创建表格中...");
				Application.DoEvents();
				this.o____._O000.();
				this.O__0ooo_o._.();
				this.o0_.oO_O0.();
				this.O_o.Oo___.();
				this.O_0O0_o_._0_0.();
				if (!this.O0Oo.Oooo0..Ooo_oo._o.())
				{
					this.oo0.__0Oo.();
				}
				if (this.O0Oo.Oooo0..Ooo_oo._o.())
				{
					this.O0Oo.Oooo0..Close();
					this.O0Oo.Oooo0. = true;
				}
				else
				{
					if (this.O0Oo.Oooo0..RepeatFixedRows && this.o.o0o__0o0..Rows.Fixed > 0)
					{
						this.O0Oo.Oooo0..RowGroups[0, this.o.o0o__0o0..Rows.Fixed].PageHeader = true;
					}
					if (this.O0Oo.Oooo0..PrintFixedCols && this.O0Oo.Oooo0..RepeatFixedCols && this.o.o0o__0o0..Cols.Fixed > 0)
					{
						this.O0Oo.Oooo0..ColGroups[0, this.o.o0o__0o0..Cols.Fixed].PageHeader = true;
					}
					this.oo0.__0Oo.().Body.Children.Add(this.O0Oo.Oooo0.);
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x00229D2C File Offset: 0x00227F2C
		internal void <<EMPTY_NAME>>()
		{
			if (!this.O0Oo.Oooo0.)
			{
				this.O0Oo.Oooo0..Oo0._.("准备生成页面...");
				Application.DoEvents();
				this.oo0.__0Oo.().Generate();
				if (!this.oo0.__0Oo.().Cancel)
				{
					this.O0Oo.Oooo0..Oo0._.("准备预览...");
					this.O0Oo.Oooo0..Ooo_oo._o.().Enabled = false;
					Application.DoEvents();
					C1PrintPreviewDialog c1PrintPreviewDialog = new C1PrintPreviewDialog();
					c1PrintPreviewDialog.PreviewPane.ZoomMode = ZoomModeEnum.ActualSize;
					c1PrintPreviewDialog.ShowInTaskbar = false;
					c1PrintPreviewDialog.Text = "打印预览";
					c1PrintPreviewDialog.Icon = a.O_.o_0oo_000_.();
					c1PrintPreviewDialog.Document = this.oo0.__0Oo.();
					c1PrintPreviewDialog.WindowState = FormWindowState.Maximized;
					Application.DoEvents();
					c1PrintPreviewDialog.PreviewPane.PrinterSettings = this.O0Oo.Oooo0..PrinterSettings;
					this.O0Oo.Oooo0..Close();
					c1PrintPreviewDialog.ShowDialog();
					this.oo0.__0Oo.().Body.Children.Clear();
					this.oo0.__0Oo.().Dispose();
					this.oOO_0o_.oOo_o0.(null);
					this.O0Oo.Oooo0..Dispose();
					this.O0Oo.Oooo0. = null;
					c1PrintPreviewDialog.Dispose();
					this.o.o0o__0o0..Dispose();
					this.o.o0o__0o0. = null;
					GC.Collect();
				}
			}
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x00229E60 File Offset: 0x00228060
		internal void <<EMPTY_NAME>>(string A_0)
		{
			if (!this.O0Oo.Oooo0.)
			{
				this.O0Oo.Oooo0..Oo0._.("准备生成页面...");
				Application.DoEvents();
				this.oo0.__0Oo.().Generate();
				if (!this.oo0.__0Oo.().Cancel)
				{
					this.O0Oo.Oooo0..Oo0._.("正在保存...");
					this.O0Oo.Oooo0..Ooo_oo._o.().Enabled = false;
					Application.DoEvents();
					new PdfExporter
					{
						Document = this.oo0.__0Oo.(),
						ShowOptions = false,
						Preview = false
					}.Export(A_0);
					this.O0Oo.Oooo0..Close();
					this.oo0.__0Oo.().Body.Children.Clear();
					this.oo0.__0Oo.().Dispose();
					this.oOO_0o_.oOo_o0.(null);
					this.O0Oo.Oooo0..Dispose();
					this.O0Oo.Oooo0. = null;
					this.o.o0o__0o0..Dispose();
					this.o.o0o__0o0. = null;
					GC.Collect();
				}
			}
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x00229F50 File Offset: 0x00228150
		internal void <<EMPTY_NAME>>(string A_0)
		{
			if (!this.O0Oo.Oooo0.)
			{
				this.O0Oo.Oooo0..Oo0._.("准备生成页面...");
				Application.DoEvents();
				this.oo0.__0Oo.().Generate();
				if (!this.oo0.__0Oo.().Cancel)
				{
					this.O0Oo.Oooo0..Oo0._.("正在保存...");
					this.O0Oo.Oooo0..Ooo_oo._o.().Enabled = false;
					Application.DoEvents();
					new HtmlExporter
					{
						Document = this.oo0.__0Oo.(),
						ShowOptions = false,
						Preview = false
					}.Export(A_0);
					this.O0Oo.Oooo0..Close();
					this.oo0.__0Oo.().Body.Children.Clear();
					this.oo0.__0Oo.().Dispose();
					this.oOO_0o_.oOo_o0.(null);
					this.O0Oo.Oooo0..Dispose();
					this.O0Oo.Oooo0. = null;
					this.o.o0o__0o0..Dispose();
					this.o.o0o__0o0. = null;
					GC.Collect();
				}
			}
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x0022A040 File Offset: 0x00228240
		internal void <<EMPTY_NAME>>(PrinterSettings A_0)
		{
			if (!this.O0Oo.Oooo0.)
			{
				this.O0Oo.Oooo0..Oo0._.("准备生成页面...");
				Application.DoEvents();
				this.oo0.__0Oo.().Generate();
				if (!this.oo0.__0Oo.().Cancel)
				{
					this.O0Oo.Oooo0..Close();
					Application.DoEvents();
					this.oo0.__0Oo.().Print(A_0, true);
					this.oo0.__0Oo.().Body.Children.Clear();
					this.oo0.__0Oo.().Dispose();
					this.oOO_0o_.oOo_o0.(null);
					this.O0Oo.Oooo0..Dispose();
					this.O0Oo.Oooo0. = null;
					this.o.o0o__0o0..Dispose();
					this.o.o0o__0o0. = null;
					GC.Collect();
				}
			}
		}

		// Token: 0x06004CA4 RID: 19620 RVA: 0x0022A0F3 File Offset: 0x002282F3
		internal int <<EMPTY_NAME>>()
		{
			return this.oOO_0o_.oOo_o0.;
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x0022A0FB File Offset: 0x002282FB
		internal void <<EMPTY_NAME>>(int A_0)
		{
			this.oOO_0o_.oOo_o0. = A_0;
			if (this.oOO_0o_.oOo_o0. % 20 == 0)
			{
				this.O0Oo.Oooo0..Oo0._.("已处理数据" + Conversions.ToString(this.oOO_0o_.oOo_o0.) + "行...");
				Application.DoEvents();
			}
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x0022A139 File Offset: 0x00228339
		public RenderTable <<EMPTY_NAME>>()
		{
			return this.O0Oo.Oooo0.;
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x0022A144 File Offset: 0x00228344
		internal void <<EMPTY_NAME>>()
		{
			this.O0Oo.Oooo0. = new RenderTable(this.oo0.__0Oo.());
			this.O0Oo.Oooo0..Height = Unit.Auto;
			if (this.O0Oo.Oooo0..FitIntoPage || this.O0Oo.Oooo0..ExtendLastCol)
			{
				this.O0Oo.Oooo0..Width = new Unit("100%parent");
				this.O0Oo.Oooo0..SplitHorzBehavior = SplitBehaviorEnum.Never;
			}
			else
			{
				this.O0Oo.Oooo0..Width = Unit.Auto;
				this.O0Oo.Oooo0..SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded;
			}
			this.O0Oo.Oooo0..Style.GridLines.All = this.oOO_0o_.oOo_o0.;
			BorderDirEnum direction = this.o.o0o__0o0..Styles.Normal.Border.Direction;
			if (direction != BorderDirEnum.Horizontal)
			{
				if (direction == BorderDirEnum.Vertical)
				{
					this.O0Oo.Oooo0..Style.GridLines.Horz = LineDef.Empty;
				}
			}
			else
			{
				this.O0Oo.Oooo0..Style.GridLines.Vert = LineDef.Empty;
			}
			CellStyle normal = this.o.o0o__0o0..Styles.Normal;
			if ((normal.BackColor.IsEmpty || normal.BackColor.Equals(Color.Transparent)) && !this.O0o.__.(this.o.o0o__0o0..BackColor))
			{
				normal.BackColor = this.o.o0o__0o0..BackColor;
			}
			this.OoO0000.0.(this.O0Oo.Oooo0..CellStyle, normal, false);
			this.OoO0000.0.(this.O0Oo.Oooo0..Style, normal, false);
			if (this.O0Oo.Oooo0..AdjustFontSize)
			{
				this.O0Oo.Oooo0..CellStyle.Font = new Font(normal.Font.Name, (float)((double)normal.Font.Size / this.oOOO0.O_O_o_0o.), normal.Font.Style, normal.Font.Unit);
				this.O0Oo.Oooo0..Style.Font = new Font(normal.Font.Name, (float)((double)normal.Font.Size / this.oOOO0.O_O_o_0o.), normal.Font.Style, normal.Font.Unit);
			}
			else
			{
				this.O0Oo.Oooo0..CellStyle.Font = (Font)normal.Font.Clone();
				this.O0Oo.Oooo0..Style.Font = (Font)normal.Font.Clone();
			}
			this.O0Oo.Oooo0..Style.TextAlignVert = AlignVertEnum.Center;
			this.O0Oo.Oooo0..CellStyle.TextAlignVert = AlignVertEnum.Center;
			if (this.o.o0o__0o0..BackgroundImage != null)
			{
				normal.BackgroundImage = this.o.o0o__0o0..BackgroundImage;
				normal.BackgroundImageLayout = ImageAlignEnum.Tile;
			}
			this.O0Oo.Oooo0..CellStyle.Padding.All = "1pt";
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x0022A41C File Offset: 0x0022861C
		private void <<EMPTY_NAME>>(Style A_0, CellStyle A_1, bool A_2)
		{
			if (A_0 != null && A_1 != null)
			{
				if (this.O0Oo.Oooo0..CellStyle.TextColor != A_1.ForeColor && !A_1.ForeColor.IsEmpty && !A_1.ForeColor.Equals(Color.Transparent))
				{
					A_0.TextColor = A_1.ForeColor;
				}
				if (this.O0Oo.Oooo0..CellStyle.BackColor != A_1.BackColor && !this.O0o.__.(A_1.BackColor))
				{
					A_0.BackColor = A_1.BackColor;
				}
				if (A_2)
				{
					A_0.FontBold = A_1.Font.Bold;
					A_0.FontItalic = A_1.Font.Italic;
					A_0.FontUnderline = A_1.Font.Underline;
					A_0.FontStrikeout = A_1.Font.Strikeout;
				}
			}
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x0022A50C File Offset: 0x0022870C
		private bool <<EMPTY_NAME>>(Color A_0)
		{
			return A_0.Equals(SystemColors.Window) || A_0.Equals(Color.White) || A_0.IsEmpty || A_0.Equals(Color.Transparent);
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x0022A570 File Offset: 0x00228770
		private void <<EMPTY_NAME>>()
		{
			this.oOOO0.O_O_o_0o. = 1.0;
			bool count = this.o.o0o__0o0..Cols.Count != 0;
			int count2 = this.o.o0o__0o0..Rows.Count;
			if (count && count2 != 0)
			{
				this.o.o0o__0o0..BeginUpdate();
				int width = this.o.o0o__0o0..Cols[0].Width;
				this.o.o0o__0o0..AutoSizeCols(0, 0, this.o.o0o__0o0..Rows.Count - 1, 0, 0, AutoSizeFlags.None);
				if (this.o.o0o__0o0..Cols[0].Width > width & (double)this.o.o0o__0o0..Cols[0].Width < this.O0.o___.)
				{
					this.O0.o___. = this.o.o0o__0o0..Cols[0].Width;
				}
				else
				{
					this.O0.o___. = width;
				}
				this.o.o0o__0o0..Cols[0].Width = width;
				this.o.o0o__0o0..EndUpdate();
				if (this.O0Oo.Oooo0..FitIntoPage || this.O0Oo.Oooo0..ExtendLastCol)
				{
					double num = 0.0;
					try
					{
						foreach (object obj in ((IEnumerable)this.o.o0o__0o0..Cols))
						{
							Column column = (Column)obj;
							if (column.Visible && !(column.Index < this.o.o0o__0o0..Cols.Fixed & !this.O0Oo.Oooo0..PrintFixedCols))
							{
								this.OooO.00.++;
								if (column.Index == 0)
								{
									num += (double)this.O0.o___.;
								}
								else
								{
									num += Math.Min(this.O0.o___., (double)column.WidthDisplay);
								}
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
					num = C1.C1Preview.Utils.ConvertUnits(num, UnitTypeEnum.Pixel, UnitTypeEnum.Mm, this.o.o0o__0o0., this.o.OO__0.);
					this.oOOO0.O_O_o_0o. = num / this.OooO.00.;
					if (this.oOOO0.O_O_o_0o. < 1.0 && this.O0Oo.Oooo0..ExtendLastCol)
					{
						this.oOOO0.O_O_o_0o. = 1.0;
					}
				}
			}
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x0022A7B0 File Offset: 0x002289B0
		private RenderText <<EMPTY_NAME>>(string A_0)
		{
			return new RenderText
			{
				Text = this.oOO_0o_.oOo_o0.(A_0),
				Width = new Unit("100%parent"),
				Height = new Unit("100%parent"),
				Style = 
				{
					TextAlignVert = AlignVertEnum.Center
				},
				X = 0,
				Y = 0
			};
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x0022A814 File Offset: 0x00228A14
		private string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (string.IsNullOrEmpty(A_0))
			{
				result = "";
			}
			else
			{
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Today]", Microsoft.VisualBasic.Strings.Format(DateTime.Today, "yyyy-MM-dd"));
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Time]", Microsoft.VisualBasic.Strings.Format(DateTime.Now, "HH:mm:ss"));
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[ShortTime]", Microsoft.VisualBasic.Strings.Format(DateTime.Now, "HH:mm"));
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Year]", DateTime.Today.Year.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Month]", DateTime.Today.Month.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Day]", DateTime.Today.Day.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Hour]", DateTime.Now.Hour.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Minute]", DateTime.Now.Minute.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Second]", DateTime.Now.Second.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[WeekDay]", DateTime.Today.DayOfWeek.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[TableName]", this.O0Oo.Oooo0..Table.DataTable.Name);
				if (Operators.CompareString(this.O0Oo.Oooo0..Table.DataTable.Caption, "", true) > 0)
				{
					A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[TableCaption]", this.O0Oo.Oooo0..Table.DataTable.Caption);
				}
				else
				{
					A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[TableCaption]", this.O0Oo.Oooo0..Table.DataTable.Name);
				}
				result = A_0;
			}
			return result;
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x0022AA1C File Offset: 0x00228C1C
		private void <<EMPTY_NAME>>()
		{
			RenderArea renderArea = new RenderArea();
			if (Operators.CompareString(this.O0Oo.Oooo0..PageHeader, "", true) > 0)
			{
				RenderArea renderArea2 = new RenderArea();
				renderArea2.Style.Font = this.O0Oo.Oooo0..PageHeaderFont;
				string[] array = this.O0Oo.Oooo0..PageHeader.Split(new char[]
				{
					'|'
				});
				if (array.Length > 0 && array[0].Length > 0)
				{
					RenderText renderText = this.oo0.__0Oo.(array[0]);
					renderText.Height = Unit.Auto;
					renderText.Style.TextAlignHorz = AlignHorzEnum.Left;
					if (this.O0Oo.Oooo0..PageHeaderLine)
					{
						renderText.Style.Borders.Bottom = LineDef.Default;
						renderText.Style.Padding.Bottom = "0.3mm";
					}
					renderArea2.Children.Add(renderText);
				}
				if (array.Length > 1 && array[1].Length > 0)
				{
					RenderText renderText2 = this.oo0.__0Oo.(array[1]);
					renderText2.Height = Unit.Auto;
					renderText2.Style.TextAlignHorz = AlignHorzEnum.Center;
					if (this.O0Oo.Oooo0..PageHeaderLine)
					{
						renderText2.Style.Borders.Bottom = LineDef.Default;
						renderText2.Style.Padding.Bottom = "0.3mm";
					}
					renderArea2.Children.Add(renderText2);
				}
				if (array.Length > 2 && array[2].Length > 0)
				{
					RenderText renderText3 = this.oo0.__0Oo.(array[2]);
					renderText3.Height = Unit.Auto;
					renderText3.Style.TextAlignHorz = AlignHorzEnum.Right;
					if (this.O0Oo.Oooo0..PageHeaderLine)
					{
						renderText3.Style.Borders.Bottom = LineDef.Default;
						renderText3.Style.Padding.Bottom = "0.3mm";
					}
					renderArea2.Children.Add(renderText3);
				}
				renderArea.Children.Add(renderArea2);
			}
			if ((Operators.CompareString(this.O0Oo.Oooo0..Title, "", true) > 0 || Operators.CompareString(this.O0Oo.Oooo0..SubTitle, "", true) > 0) & this.O0Oo.Oooo0..PrintTitle)
			{
				RenderText renderText4 = null;
				RenderArea renderArea3 = null;
				if (Operators.CompareString(this.O0Oo.Oooo0..Title, "", true) > 0)
				{
					renderText4 = this.oo0.__0Oo.(this.O0Oo.Oooo0..Title);
					renderText4.Style.TextAlignHorz = AlignHorzEnum.Center;
					renderText4.Height = Unit.Auto;
					renderText4.Style.Font = this.O0Oo.Oooo0..TitleFont;
					renderText4.BreakBefore = BreakEnum.Line;
					renderText4.BreakAfter = BreakEnum.Line;
					if (renderArea.Children.Count > 0)
					{
						renderText4.Y = "prev.bottom";
						renderText4.Style.Spacing.Top = Conversions.ToString(this.O0Oo.Oooo0..SpaceAfterPagerHeader) + "mm";
					}
					renderText4.Style.Spacing.Bottom = this.O0Oo.Oooo0..SpaceAfterTitle;
				}
				if (Operators.CompareString(this.O0Oo.Oooo0..SubTitle, "", true) > 0)
				{
					renderArea3 = new RenderArea();
					renderArea3.Style.Font = this.O0Oo.Oooo0..SubtitleFont;
					string[] array2 = this.O0Oo.Oooo0..SubTitle.Split(new char[]
					{
						'|'
					});
					if (array2.Length > 0 && array2[0].Length > 0)
					{
						RenderText renderText5 = this.oo0.__0Oo.(array2[0]);
						renderText5.Height = Unit.Auto;
						renderText5.Style.TextAlignHorz = AlignHorzEnum.Left;
						renderArea3.Children.Add(renderText5);
					}
					if (array2.Length > 1 && array2[1].Length > 0)
					{
						RenderText renderText6 = this.oo0.__0Oo.(array2[1]);
						renderText6.Height = Unit.Auto;
						renderText6.Style.TextAlignHorz = AlignHorzEnum.Center;
						renderArea3.Children.Add(renderText6);
					}
					if (array2.Length > 2 && array2[2].Length > 0)
					{
						RenderText renderText7 = this.oo0.__0Oo.(array2[2]);
						renderText7.Height = Unit.Auto;
						renderText7.Style.TextAlignHorz = AlignHorzEnum.Right;
						renderArea3.Children.Add(renderText7);
					}
					renderArea3.Y = "prev.bottom";
					if (renderArea.Children.Count > 0 && renderText4 == null)
					{
						renderArea3.Style.Spacing.Top = Conversions.ToString(this.O0Oo.Oooo0..SpaceAfterPagerHeader) + "mm";
					}
					renderArea3.Style.Spacing.Bottom = Conversions.ToString(this.O0Oo.Oooo0..SpaceAfterSubtitle) + "mm";
				}
				if (this.O0Oo.Oooo0..OnlyPrintTitleOnFirstPage)
				{
					RenderArea renderArea4 = (RenderArea)renderArea.Clone(false, true);
					if (renderText4 != null)
					{
						renderArea4.Children.Add(renderText4);
					}
					if (renderArea3 != null)
					{
						renderArea4.Children.Add(renderArea3);
					}
					PageLayout pageLayout = this.oo0.__0Oo.().PageLayout.Clone();
					pageLayout.PageSettings = this.oo0.__0Oo.().PageLayout.PageSettings;
					pageLayout.PageHeader = renderArea4;
					this.oo0.__0Oo.().PageLayouts.FirstPage = pageLayout;
					renderArea.Style.Spacing.Bottom = Conversions.ToString(this.O0Oo.Oooo0..SpaceAfterPagerHeader) + "mm";
				}
				else
				{
					if (renderText4 != null)
					{
						renderArea.Children.Add(renderText4);
					}
					if (renderArea3 != null)
					{
						renderArea.Children.Add(renderArea3);
					}
				}
			}
			else
			{
				renderArea.Style.Spacing.Bottom = Conversions.ToString(this.O0Oo.Oooo0..SpaceAfterPagerHeader) + "mm";
			}
			if (renderArea.Children.Count > 0)
			{
				this.oo0.__0Oo.().PageLayout.PageHeader = renderArea;
			}
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x0022B018 File Offset: 0x00229218
		private void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.O0Oo.Oooo0..PageFooter, "", true) > 0)
			{
				RenderArea renderArea = new RenderArea();
				renderArea.Style.Font = this.O0Oo.Oooo0..PageFooterFont;
				string[] array = this.O0Oo.Oooo0..PageFooter.Split(new char[]
				{
					'|'
				});
				if (array.Length > 0 && array[0].Length > 0)
				{
					RenderText renderText = this.oo0.__0Oo.(array[0]);
					renderText.Height = Unit.Auto;
					renderText.Style.TextAlignHorz = AlignHorzEnum.Left;
					if (this.O0Oo.Oooo0..PageFooterLine)
					{
						renderText.Style.Borders.Top = LineDef.Default;
						renderText.Style.Padding.Top = "0.3mm";
					}
					renderArea.Children.Add(renderText);
				}
				if (array.Length > 1 && array[1].Length > 0)
				{
					RenderText renderText2 = this.oo0.__0Oo.(array[1]);
					renderText2.Height = Unit.Auto;
					renderText2.Style.TextAlignHorz = AlignHorzEnum.Center;
					if (this.O0Oo.Oooo0..PageFooterLine)
					{
						renderText2.Style.Borders.Top = LineDef.Default;
						renderText2.Style.Padding.Top = "0.3mm";
					}
					renderArea.Children.Add(renderText2);
				}
				if (array.Length > 2 && array[2].Length > 0)
				{
					RenderText renderText3 = this.oo0.__0Oo.(array[2]);
					renderText3.Height = Unit.Auto;
					renderText3.Style.TextAlignHorz = AlignHorzEnum.Right;
					if (this.O0Oo.Oooo0..PageFooterLine)
					{
						renderText3.Style.Borders.Top = LineDef.Default;
						renderText3.Style.Padding.Top = "0.3mm";
					}
					renderArea.Children.Add(renderText3);
				}
				renderArea.Style.Spacing.Top = Conversions.ToString(this.O0Oo.Oooo0..SpaceBeforePagerFooter) + "mm";
				this.oo0.__0Oo.().PageLayout.PageFooter = renderArea;
			}
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x0022B230 File Offset: 0x00229430
		private void <<EMPTY_NAME>>()
		{
			this.O0Oo.Oooo0..Cols.Count = 0;
			int num = 0;
			this.O_oo000._. = 0.0;
			try
			{
				foreach (object obj in ((IEnumerable)this.o.o0o__0o0..Cols))
				{
					Column column = (Column)obj;
					if (column.Visible && !(column.Index < this.o.o0o__0o0..Cols.Fixed & !this.O0Oo.Oooo0..PrintFixedCols))
					{
						this.oo0.__0Oo.(num, column.Index);
						num++;
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

		// Token: 0x06004CB0 RID: 19632 RVA: 0x0022B2F0 File Offset: 0x002294F0
		private TableCol <<EMPTY_NAME>>(int A_0, int A_1)
		{
			TableCol tableCol = this.O0Oo.Oooo0..Cols[A_0];
			Column column = this.o.o0o__0o0..Cols[A_1];
			double num = Math.Min((double)this.o.o0o__0o0..Cols[A_1].WidthDisplay, this.O0.o___.);
			if (A_1 == 0)
			{
				num = (double)this.O0.o___.;
			}
			num = C1.C1Preview.Utils.ConvertUnits(num, UnitTypeEnum.Pixel, UnitTypeEnum.Mm, this.o.o0o__0o0., this.o.OO__0.);
			if (this.O0Oo.Oooo0..FitIntoPage || this.O0Oo.Oooo0..ExtendLastCol)
			{
				num = num / this.OooO.00. / this.oOOO0.O_O_o_0o. * 100.0;
				if (this.O_oo000._. + num > 99.0 || A_0 == this.OooO.00.)
				{
					num = Math.Round(100.0 - this.O_oo000._., 2);
				}
				this.O_oo000._. += num;
				string text = num.ToString() + "%parent.width";
				text = text.Replace(",", ".");
				tableCol.Width = text;
			}
			else
			{
				tableCol.Width = num;
			}
			if (A_1 < this.o.o0o__0o0..Cols.Fixed)
			{
				this.OoO0000.0.(tableCol.CellStyle, column.StyleFixedDisplay, false);
			}
			if (A_1 > this.o.o0o__0o0..Cols.Fixed && this.o.o0o__0o0..Contains(this.o.o0o__0o0..Cols[A_1].Name))
			{
				tableCol.CellStyle.Padding.All = "2pt";
			}
			tableCol.Style.TextAlignVert = AlignVertEnum.Center;
			if (A_1 < this.o.o0o__0o0..Cols.Fixed)
			{
				tableCol.Style.TextAlignHorz = AlignHorzEnum.Center;
			}
			else
			{
				TextAlignEnum textAlign = column.StyleDisplay.TextAlign;
				if (textAlign != TextAlignEnum.LeftCenter)
				{
					if (textAlign != TextAlignEnum.RightCenter)
					{
						if (textAlign == TextAlignEnum.GeneralCenter)
						{
							tableCol.Style.TextAlignHorz = AlignHorzEnum.Center;
						}
					}
					else
					{
						tableCol.Style.TextAlignHorz = AlignHorzEnum.Right;
					}
				}
				else
				{
					tableCol.Style.TextAlignHorz = AlignHorzEnum.Left;
				}
			}
			return tableCol;
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x0022B508 File Offset: 0x00229708
		private void <<EMPTY_NAME>>()
		{
			this.O0Oo.Oooo0..Rows.Count = 0;
			int num = 0;
			int num2 = this.o.o0o__0o0..Rows.Fixed - 1;
			for (int i = 0; i <= num2; i++)
			{
				Row row = this.o.o0o__0o0..Rows[i];
				if (row.Visible)
				{
					this.oo0.__0Oo.(num, row.Index);
					num++;
					if (num % 100 == 0)
					{
						Application.DoEvents();
						if (this.O0Oo.Oooo0..Ooo_oo._o.())
						{
							this.O0Oo.Oooo0. = true;
							return;
						}
					}
				}
			}
			int num3 = this.o.o0o__0o0..Rows.Fixed;
			int num4 = this.o.o0o__0o0..Rows.Count - 1;
			if (this.O0Oo.Oooo0..OnlySelectedRows)
			{
				num3 = this.o.o0o__0o0..Selection.TopRow;
				num4 = this.o.o0o__0o0..Selection.BottomRow;
			}
			int num5 = num3;
			int num6 = num4;
			for (int j = num5; j <= num6; j++)
			{
				Row row = this.o.o0o__0o0..Rows[j];
				if (row.Visible)
				{
					this.oo0.__0Oo.(num, row.Index);
					num++;
					if (num % 100 == 0)
					{
						Application.DoEvents();
						if (this.O0Oo.Oooo0..Ooo_oo._o.())
						{
							this.O0Oo.Oooo0. = true;
							return;
						}
					}
				}
			}
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x0022B658 File Offset: 0x00229858
		private TableRow <<EMPTY_NAME>>(int A_0, int A_1)
		{
			TableRow tableRow = this.O0Oo.Oooo0..Rows[A_0];
			Row row = this.o.o0o__0o0..Rows[A_1];
			if (A_1 < this.o.o0o__0o0..Rows.Fixed)
			{
				this.OoO0000.0.(tableRow.CellStyle, row.StyleFixedDisplay, false);
			}
			double num = (double)row.HeightDisplay;
			int num2 = 0;
			if (A_1 >= this.o.o0o__0o0..Rows.Fixed && this.O0Oo.Oooo0..ExtendMemoRow)
			{
				num2 = this.OoO0000.0.(A_1);
			}
			if (num >= (double)num2)
			{
				if (this.O0Oo.Oooo0..FitIntoPage && this.O0Oo.Oooo0..AdjustFontSize)
				{
					num /= this.oOOO0.O_O_o_0o.;
				}
				tableRow.Height = C1.C1Preview.Utils.ConvertUnits(num, UnitTypeEnum.Pixel, UnitTypeEnum.Mm, this.o.o0o__0o0..DpiY, this.o.OO__0.);
				this.o.o0o__0o0..Rows[A_1].UserData = null;
			}
			else
			{
				tableRow.Height = Unit.Auto;
			}
			if (A_1 < this.o.o0o__0o0..Rows.Fixed)
			{
				tableRow.Style.GridLines.All = this.oOO_0o_.oOo_o0.;
			}
			return tableRow;
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x0022B77C File Offset: 0x0022997C
		private void <<EMPTY_NAME>>()
		{
			int num = 0;
			int num2 = this.o.o0o__0o0..Rows.Fixed - 1;
			for (int i = 0; i <= num2; i++)
			{
				Row row = this.o.o0o__0o0..Rows[i];
				if (row.Visible)
				{
					int num3 = 0;
					try
					{
						foreach (object obj in ((IEnumerable)this.o.o0o__0o0..Cols))
						{
							Column column = (Column)obj;
							if (column.Visible && !(column.Index < this.o.o0o__0o0..Cols.Fixed & !this.O0Oo.Oooo0..PrintFixedCols))
							{
								this.O_0O0_o_._0_0.(num, num3, row.Index, column.Index);
								num3++;
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
					num++;
					this.oOO_0o_.oOo_o0.(num);
					if (this.O0Oo.Oooo0..Ooo_oo._o.())
					{
						this.O0Oo.Oooo0. = true;
						break;
					}
				}
			}
			int num4 = this.o.o0o__0o0..Rows.Fixed;
			int num5 = this.o.o0o__0o0..Rows.Count - 1;
			if (this.O0Oo.Oooo0..OnlySelectedRows)
			{
				num4 = this.o.o0o__0o0..Selection.TopRow;
				num5 = this.o.o0o__0o0..Selection.BottomRow;
			}
			int num6 = num4;
			int num7 = num5;
			for (int j = num6; j <= num7; j++)
			{
				Row row = this.o.o0o__0o0..Rows[j];
				if (row.Visible)
				{
					int num8 = 0;
					try
					{
						foreach (object obj2 in ((IEnumerable)this.o.o0o__0o0..Cols))
						{
							Column column2 = (Column)obj2;
							if (column2.Visible && !(column2.Index < this.o.o0o__0o0..Cols.Fixed & !this.O0Oo.Oooo0..PrintFixedCols))
							{
								this.O_0O0_o_._0_0.(num, num8, row.Index, column2.Index);
								num8++;
							}
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					num++;
					this.oOO_0o_.oOo_o0.(num);
					if (this.O0Oo.Oooo0..Ooo_oo._o.())
					{
						this.O0Oo.Oooo0. = true;
						return;
					}
				}
			}
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x0022B9F0 File Offset: 0x00229BF0
		private bool <<EMPTY_NAME>>(int A_0, int A_1)
		{
			AllowMergingEnum allowMerging = this.o.o0o__0o0..AllowMerging;
			bool result;
			if (allowMerging != AllowMergingEnum.None)
			{
				if (allowMerging != AllowMergingEnum.Spill)
				{
					if (allowMerging != AllowMergingEnum.Nodes)
					{
						result = (this.o.o0o__0o0..Rows[A_0].AllowMerging || this.o.o0o__0o0..Cols[A_1].AllowMerging);
					}
					else
					{
						result = (this.o.o0o__0o0..Rows[A_0].IsNode || A_0 < this.o.o0o__0o0..Rows.Fixed);
					}
				}
				else
				{
					result = true;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x0022BA84 File Offset: 0x00229C84
		private TableCell <<EMPTY_NAME>>(int A_0, int A_1, int A_2, int A_3)
		{
			TableCell result;
			if (!this.O0o.__.(A_2, A_3))
			{
				result = this.oo0.__0Oo.(A_0, A_1, A_2, A_3);
			}
			else
			{
				CellRange cellRange = this.o.o0o__0o0..OO_.00oO0Oo.(A_2, A_3, false);
				while (cellRange.r1 < cellRange.r2)
				{
					if (this.o.o0o__0o0..Rows[cellRange.r1].Visible)
					{
						break;
					}
					cellRange.r1++;
				}
				while (cellRange.c1 < cellRange.c2 && !this.o.o0o__0o0..Cols[cellRange.c1].Visible)
				{
					cellRange.c1++;
				}
				int num = cellRange.r1 + 1;
				int r = cellRange.r2;
				int num2;
				for (int i = num; i <= r; i++)
				{
					if (!this.o.o0o__0o0..Rows[i].Visible)
					{
						num2++;
					}
				}
				int num3 = cellRange.c1 + 1;
				int c = cellRange.c2;
				int num4;
				for (int j = num3; j <= c; j++)
				{
					if (!this.o.o0o__0o0..Cols[j].Visible)
					{
						num4++;
					}
				}
				cellRange.r2 -= num2;
				cellRange.c2 -= num4;
				if (cellRange.IsSingleCell)
				{
					result = this.oo0.__0Oo.(A_0, A_1, A_2, A_3);
				}
				else if (A_2 > cellRange.r1)
				{
					result = null;
				}
				else if (A_3 > cellRange.c1)
				{
					result = null;
				}
				else
				{
					TableCell tableCell = this.oo0.__0Oo.(A_0, A_1, A_2, A_3);
					tableCell.SpanCols = Math.Abs(cellRange.c2 - cellRange.c1) + 1;
					tableCell.SpanRows = Math.Abs(cellRange.r2 - cellRange.r1) + 1;
					tableCell.VertSplitBehavior = CellSplitBehaviorEnum.Copy;
					result = tableCell;
				}
			}
			return result;
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x0022BC5C File Offset: 0x00229E5C
		private TableCell <<EMPTY_NAME>>(int A_0, int A_1, int A_2, int A_3)
		{
			Image image = null;
			CheckEnum a_ = CheckEnum.None;
			string text = this.o.o0o__0o0..GetDataDisplay(A_2, A_3, out image, out a_);
			Image image2 = ooO.oO0__o.0o__.(this.o.o0o__0o0., a_);
			bool flag = false;
			if (image2 != null)
			{
				image = image2;
				text = null;
			}
			CellStyle cellStyle;
			if (A_2 >= this.o.o0o__0o0..Rows.Fixed & A_3 >= this.o.o0o__0o0..Cols.Fixed)
			{
				cellStyle = this.o.o0o__0o0..Cols[A_3].StyleDisplay;
			}
			else
			{
				cellStyle = this.o.o0o__0o0..GetCellStyleDisplay(A_2, A_3);
			}
			CellStyle styleDisplay = this.o.o0o__0o0..Cols[A_3].StyleDisplay;
			Bitmap bitmap = null;
			if (this.o.o0o__0o0..Cols[A_3].WidthDisplay > 0 && this.o.o0o__0o0..Rows[A_2].HeightDisplay > 0)
			{
				bitmap = new Bitmap(this.o.o0o__0o0..Cols[A_3].WidthDisplay, this.o.o0o__0o0..Rows[A_2].HeightDisplay);
				Graphics graphics = Graphics.FromImage(bitmap);
				OwnerDrawCellEventArgs ownerDrawCellEventArgs = new OwnerDrawCellEventArgs(null, graphics, A_2, A_3, null, new Rectangle(0, 0, bitmap.Width, bitmap.Height), text, image);
				this.o.o0o__0o0..OO_.00oO0Oo.(this.o.o0o__0o0., ownerDrawCellEventArgs, this.O0Oo.Oooo0..ExcuteDrawCell, true, ref flag);
				graphics.Dispose();
				if (Operators.CompareString(ownerDrawCellEventArgs.Text, "", true) > 0 && image2 == null)
				{
					text = ownerDrawCellEventArgs.Text;
				}
				if (Operators.CompareString(text, " ", true) == 0)
				{
					text = "";
				}
				if (ownerDrawCellEventArgs.Image != null)
				{
					image = ownerDrawCellEventArgs.Image;
				}
				if (ownerDrawCellEventArgs.Style != null && this.O0Oo.Oooo0..EnableStyle)
				{
					cellStyle = ownerDrawCellEventArgs.Style;
				}
				if (A_1 == 0 && A_0 >= this.o.o0o__0o0..Rows.Fixed && this.O0Oo.Oooo0..PrintFixedCols && this.O0Oo.Oooo0..Renumber)
				{
					text = (A_0 - this.o.o0o__0o0..Rows.Fixed + 1).ToString();
				}
			}
			flag = (flag || image != null || image2 != null);
			TableCell tableCell = this.O0Oo.Oooo0..Cells[A_0, A_1];
			if (A_0 >= this.o.o0o__0o0..Rows.Fixed && flag)
			{
				if (image == null)
				{
					tableCell.Style.BackgroundImage = bitmap;
				}
				tableCell.Style.BackgroundImageAlign.AlignVert = ImageAlignVertEnum.Center;
				tableCell.Style.BackgroundImageAlign.AlignHorz = ImageAlignHorzEnum.Center;
				RenderObject renderObject = this.O0o.__.(A_0, A_1, A_2, A_3, cellStyle, text, image, image2 != null);
				if (renderObject != null)
				{
					renderObject.Style.Parents = tableCell.CellStyle;
					tableCell.RenderObject = renderObject;
				}
			}
			else
			{
				tableCell.Text = text;
				if (cellStyle.BackColor != styleDisplay.BackColor)
				{
					tableCell.Style.BackColor = cellStyle.BackColor;
				}
				if (cellStyle.ForeColor != styleDisplay.ForeColor)
				{
					tableCell.Style.TextColor = cellStyle.ForeColor;
				}
				if (A_2 < this.o.o0o__0o0..Rows.Fixed)
				{
					tableCell.Style.TextAlignHorz = AlignHorzEnum.Center;
				}
				else if (cellStyle.TextAlign != styleDisplay.TextAlign)
				{
					TextAlignEnum textAlign = cellStyle.TextAlign;
					if (textAlign != TextAlignEnum.LeftCenter)
					{
						if (textAlign != TextAlignEnum.RightCenter)
						{
							if (textAlign == TextAlignEnum.GeneralCenter)
							{
								tableCell.Style.TextAlignHorz = AlignHorzEnum.Center;
							}
						}
						else
						{
							tableCell.Style.TextAlignHorz = AlignHorzEnum.Right;
						}
					}
					else
					{
						tableCell.Style.TextAlignHorz = AlignHorzEnum.Left;
					}
				}
			}
			return tableCell;
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x0022C004 File Offset: 0x0022A204
		private RenderObject <<EMPTY_NAME>>(int A_0, int A_1, int A_2, int A_3, CellStyle A_4, string A_5, Image A_6, bool A_7)
		{
			RenderObject renderObject = null;
			if (!this.o.o0o__0o0..Cols[A_3].ImageAndText)
			{
				A_5 = null;
			}
			bool flag = A_6 != null;
			bool flag2 = !string.IsNullOrEmpty(A_5);
			RenderObject result;
			if (!flag && !flag2)
			{
				result = null;
			}
			else
			{
				if (flag2 && (!flag || A_2 < this.o.o0o__0o0..Rows.Fixed))
				{
					RenderText renderText = new RenderText();
					renderText.Text = A_5;
					renderObject = renderText;
					renderText.Style.WordWrap = true;
					if (!this.O0Oo.Oooo0..Rows[A_0].Height.IsAuto || Operators.CompareString(Conversions.ToString(this.o.o0o__0o0..Rows[A_2].UserData), this.o.o0o__0o0..Cols[A_3].Name, true) != 0)
					{
						renderText.Height = "parent.height";
						if (A_2 < this.o.o0o__0o0..Rows.Fixed)
						{
							TextAlignEnum textAlignFixed = this.o.o0o__0o0..Cols[A_3].TextAlignFixed;
							if (textAlignFixed != TextAlignEnum.LeftCenter)
							{
								if (textAlignFixed != TextAlignEnum.RightCenter)
								{
									renderText.Style.TextAlignHorz = AlignHorzEnum.Center;
								}
								else
								{
									renderText.Style.TextAlignHorz = AlignHorzEnum.Right;
								}
							}
							else
							{
								renderText.Style.TextAlignHorz = AlignHorzEnum.Left;
							}
						}
						else
						{
							TextAlignEnum textAlign = this.o.o0o__0o0..Cols[A_3].TextAlign;
							if (textAlign != TextAlignEnum.LeftCenter)
							{
								if (textAlign != TextAlignEnum.CenterCenter)
								{
									if (textAlign != TextAlignEnum.RightCenter)
									{
										if (Versioned.IsNumeric(A_5))
										{
											renderText.Style.TextAlignHorz = AlignHorzEnum.Right;
										}
										else
										{
											renderText.Style.TextAlignHorz = AlignHorzEnum.Left;
										}
									}
									else
									{
										renderText.Style.TextAlignHorz = AlignHorzEnum.Right;
									}
								}
								else
								{
									renderText.Style.TextAlignHorz = AlignHorzEnum.Center;
								}
							}
							else
							{
								renderText.Style.TextAlignHorz = AlignHorzEnum.Left;
							}
						}
						if (renderText.Style.TextAlignHorz == AlignHorzEnum.Left)
						{
							renderText.Style.Spacing.Left = (double)(2f / this.o.o0o__0o0.) * 25.4;
						}
						else if (renderText.Style.TextAlignHorz == AlignHorzEnum.Right)
						{
							renderText.Style.Spacing.Right = (double)(2f / this.o.o0o__0o0.) * 25.4;
						}
						if (A_2 < this.o.o0o__0o0..Rows.Fixed)
						{
						}
					}
				}
				else if (flag)
				{
					RenderImage renderImage = new RenderImage(A_6);
					if (A_7)
					{
						renderImage.Style.ImageAlign.AlignHorz = ImageAlignHorzEnum.Center;
					}
					else
					{
						renderImage.Style.ImageAlign.AlignHorz = ImageAlignHorzEnum.Left;
					}
					renderImage.Style.ImageAlign.AlignVert = ImageAlignVertEnum.Center;
					renderImage.Style.ImageAlign.StretchHorz = false;
					renderImage.Style.ImageAlign.StretchVert = false;
					renderImage.Style.Spacing.Left = (double)(2f / this.o.o0o__0o0.) * 25.4;
					renderImage.Style.Spacing.Right = (double)(2f / this.o.o0o__0o0.) * 25.4;
					renderImage.Height = "parent.height";
					if (flag2)
					{
						RenderArea renderArea = new RenderArea();
						renderArea.Height = "parent.height";
						renderArea.Stacking = StackingRulesEnum.BlockLeftToRight;
						RenderText renderText = new RenderText();
						renderText.Height = "parent.height";
						renderText.Text = A_5;
						renderArea.Children.Add(renderImage);
						renderArea.Children.Add(renderText);
						renderObject = renderArea;
					}
					else
					{
						renderObject = renderImage;
					}
				}
				if (renderObject != null && A_4 != null)
				{
					this.OoO0000.0.(renderObject.Style, A_4, true);
				}
				result = renderObject;
			}
			return result;
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x0022C3BC File Offset: 0x0022A5BC
		private int <<EMPTY_NAME>>(int A_0)
		{
			int num = 0;
			try
			{
				foreach (object obj in ((IEnumerable)this.o.o0o__0o0..Cols))
				{
					Column column = (Column)obj;
					if (column.Index >= this.o.o0o__0o0..Cols.Fixed && this.o.o0o__0o0..Contains(column.Name))
					{
						int a_ = (int)Math.Round(Math.Min((double)column.WidthDisplay, this.O0.o___.) - C1.C1Preview.Utils.ConvertUnits(2.0, UnitTypeEnum.Point, UnitTypeEnum.Pixel, this.o.OO__0., this.o.o0o__0o0.));
						string dataDisplay = this.o.o0o__0o0..GetDataDisplay(A_0, column.Name);
						int num2 = this.O0o.__.(dataDisplay, this.o.o0o__0o0..Font, a_) + 2;
						if (num2 > num)
						{
							num = num2;
							this.o.o0o__0o0..Rows[A_0].UserData = column.Name;
						}
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
			return num;
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x0022C4D8 File Offset: 0x0022A6D8
		private int <<EMPTY_NAME>>(string A_0, Font A_1, int A_2)
		{
			SizeF layoutArea = new SizeF((float)A_2, 0f);
			return (int)Math.Round((double)this.o.o0o__0o0..MeasureString(A_0, A_1, layoutArea, this.O0Oo.Oooo0.).Height);
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x0022C518 File Offset: 0x0022A718
		private void <<EMPTY_NAME>>(C1PrintDocument A_0, PageEventArgs A_1)
		{
			this.O0Oo.Oooo0..Oo0._.("正在生成第" + Conversions.ToString(this.oo0.__0Oo.().Pages.Count) + "页...");
			Application.DoEvents();
			if (this.O0Oo.Oooo0..Ooo_oo._o.())
			{
				this.oo0.__0Oo.().Cancel = true;
			}
		}

		// Token: 0x04001F3D RID: 7997
		private PrintInfo <<EMPTY_NAME>>;

		// Token: 0x04001F3E RID: 7998
		private O_oOooO_O <<EMPTY_NAME>>;

		// Token: 0x04001F3F RID: 7999
		[CompilerGenerated]
		private C1PrintDocument <<EMPTY_NAME>>;

		// Token: 0x04001F40 RID: 8000
		private RenderTable <<EMPTY_NAME>>;

		// Token: 0x04001F41 RID: 8001
		private float <<EMPTY_NAME>>;

		// Token: 0x04001F42 RID: 8002
		private float <<EMPTY_NAME>>;

		// Token: 0x04001F43 RID: 8003
		private StringFormat <<EMPTY_NAME>>;

		// Token: 0x04001F44 RID: 8004
		private double <<EMPTY_NAME>>;

		// Token: 0x04001F45 RID: 8005
		private double <<EMPTY_NAME>>;

		// Token: 0x04001F46 RID: 8006
		private double <<EMPTY_NAME>>;

		// Token: 0x04001F47 RID: 8007
		private double <<EMPTY_NAME>>;

		// Token: 0x04001F48 RID: 8008
		private double <<EMPTY_NAME>>;

		// Token: 0x04001F49 RID: 8009
		private int <<EMPTY_NAME>>;

		// Token: 0x04001F4A RID: 8010
		private Graphics <<EMPTY_NAME>>;

		// Token: 0x04001F4B RID: 8011
		private int <<EMPTY_NAME>>;

		// Token: 0x04001F4C RID: 8012
		private int <<EMPTY_NAME>>;

		// Token: 0x04001F4D RID: 8013
		private LineDef <<EMPTY_NAME>>;

		// Token: 0x04001F4E RID: 8014
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04001F4F RID: 8015
		private o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000 <<EMPTY_NAME>>;

		// Token: 0x04001F50 RID: 8016
		private bool <<EMPTY_NAME>>;
	}
}
