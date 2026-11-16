using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Foxtable.Syscmd;
using Foxtable.WinForm;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using TSF;

namespace Foxtable
{
	// Token: 0x0200008B RID: 139
	internal class O_oOooO_O : C1FlexGrid
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x0002287D File Offset: 0x00020A7D
		internal void <<EMPTY_NAME>>()
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
			{
				this
			});
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00022894 File Offset: 0x00020A94
		public O_oOooO_O(Foxtable.Table A_0)
		{
			int a_ = 18;
			base..ctor();
			base.AfterEdit += this.o__.o0oOO_O.;
			base.AfterFreezeColumn += this.O0._0O00oO0o0O.;
			base.AfterResizeColumn += this.Oo0oO0O.O_oo_.;
			base.AfterResizeRow += this.o_.o00_.;
			base.AfterRowColChange += this.o.O_0o.;
			base.AfterScroll += this.oO__O.o00O.;
			base.AfterSelChange += this.oO.o_o0O.;
			base.BeforeDoubleClick += this.O.O0_0.;
			base.BeforeDragColumn += this.OoO._OOo__.;
			base.BeforeEdit += this.oo_o_.o.;
			base.BeforeFreezeColumn += this.oOO0___._.;
			base.BeforeMouseDown += this.o0.OO00.;
			base.BeforeResizeColumn += this.oOO0_0oo_0.O.;
			base.BeforeResizeRow += this.oo_Oo.0oo__.;
			base.BeforeRowColChange += this.oo0O.0.;
			base.BeforeSelChange += this.o0.OO00.;
			base.CellButtonClick += this.o00OO.Oo.;
			base.ChangeEdit += this.oo_o_.o.;
			base.Click += this.O_oO0._.;
			base.DoubleClick += this.OoOooO_._0_0o.;
			base.Enter += this.oo_Oo.0oo__.;
			base.FontChanged += this.ooO._00000O00_.;
			base.GotFocus += this.O_.__oo0.;
			base.KeyDown += this.OO.o_o00o.;
			base.KeyDownEdit += this.OO.o_o00o.;
			base.KeyPressEdit += this.o._O00___.;
			base.KeyUp += this.o000OOo.OO.;
			base.KeyUpEdit += this.o._O00___.;
			base.MouseDown += this.oo.0.;
			base.MouseEnterCell += this.O_.__oo0.;
			base.MouseLeaveCell += this.o0.Oo.;
			base.OwnerDrawCell += this.o._O00___.;
			base.ParentChanged += this.o0.Oo.;
			base.SetupEditor += this.OO.o_o00o.;
			base.StartEdit += this.o._O00___.;
			base.ValidateEdit += this.o._O00___.;
			base.PreviewKeyDown += this.o000OOo.OO.;
			base.MouseClick += this.o000OOo.OO.;
			base.MouseMove += new MouseEventHandler(this.o000OOo.OO.);
			this.o_.o. = new Dictionary<C1.Win.C1FlexGrid.Column, int>();
			this.o_.o. = new Dictionary<string, string>();
			this.O_._. = BooleanEnum.Default;
			this.O_._. = -1f;
			base.ShowErrors = true;
			base.Rows.DefaultSize = 19;
			base.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom;
			Main.OO_O.o..Oo.oOo_o0Oo0.(A_0.Theme, new object[]
			{
				this
			});
			this.Font = new Font(O00OOOo_O0_O.b("纯꒹", a_), 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.AutoResize = false;
			if (Environment.OSVersion.Version.Major >= 6)
			{
				this.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			}
			else
			{
				this.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			}
			base.Glyphs[GlyphEnum.DBAdd] = O_oOooO_O.o_.o.;
			base.Styles.Normal.WordWrap = true;
			base.FocusRect = FocusRectEnum.Solid;
			base.AllowResizing = AllowResizingEnum.Both;
			base.Cols.DefaultSize = 70;
			base.AllowSorting = AllowSortingEnum.None;
			base.AllowMerging = AllowMergingEnum.Nodes;
			base.AllowMergingFixed = AllowMergingEnum.FixedOnly;
			base.EditOptions = (EditFlags.AutoSearch | EditFlags.CycleOnDoubleClick | EditFlags.ExitOnLeftRightKeys | EditFlags.EditOnRequest);
			base.Styles.Normal.BackColor = Color.White;
			base.ShowSort = false;
			this.o.0O_O0o_. = A_0;
			base.DataSource = A_0.View;
			base.Cols.MinSize = 16;
			base.DrawMode = DrawModeEnum.OwnerDraw;
			this.CellButtonImage = a.O0__0.Oo0oo_.().ToBitmap();
			this.Oo0._0.();
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00022CCC File Offset: 0x00020ECC
		internal LookAndFeelProperty <<EMPTY_NAME>>()
		{
			return this.O_._.;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00022CD4 File Offset: 0x00020ED4
		internal void <<EMPTY_NAME>>(LookAndFeelProperty A_0)
		{
			this.O_._. = A_0;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00022CDD File Offset: 0x00020EDD
		internal void <<EMPTY_NAME>>()
		{
			this.o.0O_O0o_. = null;
			Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
			{
				this
			});
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00022CFC File Offset: 0x00020EFC
		internal bool <<EMPTY_NAME>>()
		{
			if (this.O0._0O.)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.GetUserData(base.Rows.Fixed, 0));
				if (objectValue != null)
				{
					return Operators.CompareString(objectValue.ToString(), "GridTreeMode", true) == 0;
				}
			}
			return false;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00022D46 File Offset: 0x00020F46
		internal void <<EMPTY_NAME>>(bool A_0)
		{
			this.O0._0O. = A_0;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00022D50 File Offset: 0x00020F50
		internal void <<EMPTY_NAME>>()
		{
			this.OO0o_o_OO.O_O.(this.o.0O_O0o_..DataTable.frd_LookAndFeel);
			this.BeginUpdate();
			base.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
			base.Styles.SelectedRowHeader.TextAlign = TextAlignEnum.CenterCenter;
			switch (this.OO_.00oO0Oo.().GridStyle)
			{
			case GridStyleEnum.Dotted:
				base.Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted;
				break;
			case GridStyleEnum.Double:
				base.Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Double;
				break;
			case GridStyleEnum.Fillet:
				base.Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Fillet;
				break;
			case GridStyleEnum.Flat:
				base.Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Flat;
				break;
			case GridStyleEnum.Groove:
				base.Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Groove;
				break;
			case GridStyleEnum.Inset:
				base.Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Inset;
				break;
			case GridStyleEnum.None:
				base.Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None;
				break;
			case GridStyleEnum.Raised:
				base.Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Raised;
				break;
			}
			switch (this.OO_.00oO0Oo.().GridWidth)
			{
			case GridWidthEnum.Zero:
				base.Styles.Normal.Border.Width = 0;
				break;
			case GridWidthEnum.One:
				base.Styles.Normal.Border.Width = 1;
				break;
			case GridWidthEnum.Two:
				base.Styles.Normal.Border.Width = 2;
				break;
			case GridWidthEnum.Three:
				base.Styles.Normal.Border.Width = 3;
				break;
			}
			switch (this.OO_.00oO0Oo.().GridLineDirection)
			{
			case GridLineDirectionEnum.Both:
				base.Styles.Normal.Border.Direction = BorderDirEnum.Both;
				break;
			case GridLineDirectionEnum.Horizontal:
				base.Styles.Normal.Border.Direction = BorderDirEnum.Horizontal;
				break;
			case GridLineDirectionEnum.Vertical:
				base.Styles.Normal.Border.Direction = BorderDirEnum.Vertical;
				break;
			}
			if (this.OO_.00oO0Oo.().GridColor != Color.Transparent)
			{
				base.Styles.Normal.Border.Color = this.OO_.00oO0Oo.().GridColor;
			}
			base.Styles.EmptyArea.Border.Width = 0;
			if (this.OO_.00oO0Oo.().BackColor != Color.Transparent)
			{
				base.Styles.Normal.BackColor = this.OO_.00oO0Oo.().BackColor;
			}
			if (this.OO_.00oO0Oo.().ForeColor != Color.Transparent)
			{
				base.Styles.Normal.ForeColor = this.OO_.00oO0Oo.().ForeColor;
			}
			if (this.OO_.00oO0Oo.().FixedForeColor != Color.Transparent)
			{
				base.Styles.Fixed.ForeColor = this.OO_.00oO0Oo.().FixedForeColor;
			}
			if (this.OO_.00oO0Oo.().FixedBackColor != Color.Transparent)
			{
				base.Styles.Fixed.BackColor = this.OO_.00oO0Oo.().FixedBackColor;
			}
			if (this.OO_.00oO0Oo.().HighlightBackColor != Color.Transparent)
			{
				base.Styles.Highlight.BackColor = this.OO_.00oO0Oo.().HighlightBackColor;
			}
			if (this.OO_.00oO0Oo.().HighlightForeColor != Color.Transparent)
			{
				base.Styles.Highlight.ForeColor = this.OO_.00oO0Oo.().HighlightForeColor;
			}
			if (this.OO_.00oO0Oo.().FrozenBackColor != Color.Transparent)
			{
				base.Styles.Frozen.BackColor = this.OO_.00oO0Oo.().FrozenBackColor;
			}
			if (this.OO_.00oO0Oo.().frozenForeColor != Color.Transparent)
			{
				base.Styles.Frozen.ForeColor = this.OO_.00oO0Oo.().frozenForeColor;
			}
			if (!this.OO_.00oO0Oo.())
			{
				Color color = this.OooO_0_o0Oo0.0.();
				if (color != Color.Transparent)
				{
					base.Styles.Alternate.BackColor = color;
				}
				color = this.OO_.00oO0Oo.();
				if (color != Color.Transparent)
				{
					base.Styles.Alternate.ForeColor = color;
				}
				base.Styles.Alternate.Clear(StyleElementFlags.Font);
			}
			else
			{
				base.Styles.Alternate.Clear();
			}
			if (this.OO_.00oO0Oo.().SelectedHeaderBackColor != Color.Transparent)
			{
				base.Styles.SelectedRowHeader.BackColor = this.OO_.00oO0Oo.().SelectedHeaderBackColor;
				base.Styles.SelectedColumnHeader.BackColor = this.OO_.00oO0Oo.().SelectedHeaderBackColor;
			}
			if (this.OO_.00oO0Oo.().SelectedHeaderForeColor != Color.Transparent)
			{
				base.Styles.SelectedRowHeader.ForeColor = this.OO_.00oO0Oo.().SelectedHeaderForeColor;
				base.Styles.SelectedColumnHeader.ForeColor = this.OO_.00oO0Oo.().SelectedHeaderForeColor;
			}
			if (this.OO_.00oO0Oo.().EmptyBackColor != Color.Transparent)
			{
				base.Styles.EmptyArea.BackColor = this.OO_.00oO0Oo.().EmptyBackColor;
			}
			if (this.OO_.00oO0Oo.().GrandTotalBackColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.GrandTotal].BackColor = this.OO_.00oO0Oo.().GrandTotalBackColor;
			}
			if (this.OO_.00oO0Oo.().GrandTotalForeColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.GrandTotal].ForeColor = this.OO_.00oO0Oo.().GrandTotalForeColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal0BackColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal0].BackColor = this.OO_.00oO0Oo.().Subtotal0BackColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal0ForeColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal0].ForeColor = this.OO_.00oO0Oo.().Subtotal0ForeColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal1BackColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal1].BackColor = this.OO_.00oO0Oo.().Subtotal1BackColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal1ForeColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal1].ForeColor = this.OO_.00oO0Oo.().Subtotal1ForeColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal2BackColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal2].BackColor = this.OO_.00oO0Oo.().Subtotal2BackColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal2ForeColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal2].ForeColor = this.OO_.00oO0Oo.().Subtotal2ForeColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal3BackColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal3].BackColor = this.OO_.00oO0Oo.().Subtotal3BackColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal3ForeColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal3].ForeColor = this.OO_.00oO0Oo.().Subtotal3ForeColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal4BackColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal4].BackColor = this.OO_.00oO0Oo.().Subtotal4BackColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal4ForeColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal4].ForeColor = this.OO_.00oO0Oo.().Subtotal4ForeColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal5BackColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal5].BackColor = this.OO_.00oO0Oo.().Subtotal5BackColor;
			}
			if (this.OO_.00oO0Oo.().Subtotal5ForeColor != Color.Transparent)
			{
				base.Styles[CellStyleEnum.Subtotal5].ForeColor = this.OO_.00oO0Oo.().Subtotal5ForeColor;
			}
			base.Styles.Fixed.WordWrap = true;
			base.Styles.Normal.Trimming = StringTrimming.Character;
			base.Styles.Fixed.Trimming = StringTrimming.Character;
			this.o.0o_O.();
			this.O._0ooo00o.();
			if (this.OO_.00oO0Oo.().FocusBackColor != Color.Transparent)
			{
				base.Styles.Focus.BackColor = this.OO_.00oO0Oo.().FocusBackColor;
			}
			else if (this.o.0O_O0o_..ListMode)
			{
				base.Styles.Focus.BackColor = base.Styles["CurrentRow"].BackColor;
			}
			else
			{
				base.Styles.Focus.BackColor = base.Styles.Normal.BackColor;
			}
			if (this.OO_.00oO0Oo.().FocusForeColor != Color.Transparent)
			{
				base.Styles.Focus.ForeColor = this.OO_.00oO0Oo.().FocusForeColor;
			}
			base.Invalidate();
			this.EndUpdate();
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00023684 File Offset: 0x00021884
		private bool <<EMPTY_NAME>>()
		{
			bool result;
			switch (this.OO_.00oO0Oo.().DisableAlterRowMode)
			{
			case BooleanEnum.Default:
				result = (O_O0OO.O0_00o.o0__o..DisableAlterRowMode == BooleanEnum.True || (O_O0OO.O0_00o.o0__o..DisableAlterRowMode != BooleanEnum.False && O_O0OO.o0O._O00o.));
				break;
			case BooleanEnum.True:
				result = true;
				break;
			case BooleanEnum.False:
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000236E4 File Offset: 0x000218E4
		private Color <<EMPTY_NAME>>()
		{
			Color result;
			if (this.OO_.00oO0Oo.().AlterRowBackColor == Color.Transparent)
			{
				if (O_O0OO.O0_00o.o0__o..AlterRowBackColor == Color.Transparent)
				{
					result = O_O0OO.O0_00o.o0__o.;
				}
				else
				{
					result = O_O0OO.O0_00o.o0__o..AlterRowBackColor;
				}
			}
			else
			{
				result = this.OO_.00oO0Oo.().AlterRowBackColor;
			}
			return result;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00023740 File Offset: 0x00021940
		private Color <<EMPTY_NAME>>()
		{
			Color result;
			if (this.OO_.00oO0Oo.().AlterRowForeColor == Color.Transparent)
			{
				if (O_O0OO.O0_00o.o0__o..AlterRowForeColor == Color.Transparent)
				{
					result = O_O0OO.oo0_o_.o.;
				}
				else
				{
					result = O_O0OO.O0_00o.o0__o..AlterRowForeColor;
				}
			}
			else
			{
				result = this.OO_.00oO0Oo.().AlterRowForeColor;
			}
			return result;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0002379C File Offset: 0x0002199C
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (object obj in ((IEnumerable)base.Styles))
				{
					CellStyle cellStyle = (CellStyle)obj;
					if (Operators.CompareString(Conversions.ToString(cellStyle.UserData), "Row", true) == 0)
					{
						base.Styles.Remove(cellStyle);
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
			CellStyle cellStyle2 = base.Styles.Add("LockedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.Fixed);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().LockedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("SelectedLockedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.SelectedRowHeader);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().LockedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("UnchangedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.Fixed);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().UnchangedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("SelectedUnchangedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.SelectedRowHeader);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().UnchangedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("ModifiedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.Fixed);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().ModifiedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("SelectedModifiedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.SelectedRowHeader);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().ModifiedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("LockedModifiedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.Fixed);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().LockedModifiedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("SelectedLockedModifiedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.SelectedRowHeader);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().LockedModifiedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("AddedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.Fixed);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().AddedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("SelectedAddedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.SelectedRowHeader);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().AddedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("LockedAddedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.Fixed);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().LockedAddedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("SelectedLockedAddedRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.SelectedRowHeader);
			cellStyle2.ForeColor = this.OO_.00oO0Oo.().LockedAddedRowHeaderForeColor;
			cellStyle2 = base.Styles.Add("ModifiedCell");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.Normal);
			if (this.OO_.00oO0Oo.().ModifiedCellBackColor == Color.Transparent)
			{
				cellStyle2.BackColor = Color.Red;
			}
			else
			{
				cellStyle2.BackColor = this.OO_.00oO0Oo.().ModifiedCellBackColor;
			}
			if (this.OO_.00oO0Oo.().ModifiedCellForeColor == Color.Transparent)
			{
				cellStyle2.ForeColor = Color.White;
			}
			else
			{
				cellStyle2.ForeColor = this.OO_.00oO0Oo.().ModifiedCellForeColor;
			}
			cellStyle2.Clear(StyleElementFlags.Font);
			cellStyle2 = base.Styles.Add("CurrentRow");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.Normal);
			if (this.OO_.00oO0Oo.().CurrentRowBackColor == Color.Transparent)
			{
				cellStyle2.BackColor = Color.FloralWhite;
			}
			else
			{
				cellStyle2.BackColor = this.OO_.00oO0Oo.().CurrentRowBackColor;
			}
			if (this.OO_.00oO0Oo.().CurrentRowForeColor == Color.Transparent)
			{
				cellStyle2.ForeColor = SystemColors.ControlText;
			}
			else
			{
				cellStyle2.ForeColor = this.OO_.00oO0Oo.().CurrentRowForeColor;
			}
			cellStyle2.Clear(StyleElementFlags.Font);
			cellStyle2 = base.Styles.Add("GrandTotalRowHeader");
			cellStyle2.UserData = "Row";
			cellStyle2.MergeWith(base.Styles.Fixed);
			cellStyle2.ImageAlign = ImageAlignEnum.Hide;
			base.Styles.Fixed.ImageAlign = ImageAlignEnum.RightCenter;
			base.Cols[0].TextAlign = TextAlignEnum.CenterCenter;
			base.Cols[0].ImageAlign = ImageAlignEnum.CenterCenter;
			base.GetCellRange(0, 0).StyleNew.ImageAlign = ImageAlignEnum.CenterCenter;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00023CBC File Offset: 0x00021EBC
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (object obj in ((IEnumerable)base.Styles))
				{
					CellStyle cellStyle = (CellStyle)obj;
					if (Operators.CompareString(Conversions.ToString(cellStyle.UserData), "User", true) == 0)
					{
						base.Styles.Remove(cellStyle);
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
			if (Operators.CompareString(this.o.0O_O0o_..DataTable.frd_LookAndFeel.UserStyle, "", true) != 0)
			{
				foreach (string a_ in this.o.0O_O0o_..DataTable.frd_LookAndFeel.UserStyle.Split(new char[]
				{
					'\r'
				}))
				{
					CellStyleProperty cellStyleProperty = new CellStyleProperty();
					o_O_o_oOoo__.OOOO_OO._oo.(cellStyleProperty, a_, '\n');
					CellStyle cellStyle2 = base.Styles.Add("User" + cellStyleProperty.Name);
					cellStyle2.UserData = "User";
					if (cellStyleProperty.BackColor != Color.Empty)
					{
						cellStyle2.BackColor = cellStyleProperty.BackColor;
					}
					if (cellStyleProperty.ForeColor != Color.Empty)
					{
						cellStyle2.ForeColor = cellStyleProperty.ForeColor;
					}
					if (cellStyleProperty.FontBold || cellStyleProperty.FontStrikeout || cellStyleProperty.FontUnderLine)
					{
						FontStyle fontStyle;
						if (cellStyleProperty.FontBold)
						{
							fontStyle = FontStyle.Bold;
						}
						if (cellStyleProperty.FontStrikeout)
						{
							fontStyle |= FontStyle.Strikeout;
						}
						if (cellStyleProperty.FontUnderLine)
						{
							fontStyle |= FontStyle.Underline;
						}
						cellStyle2.Font = new Font(cellStyle2.Font, fontStyle);
					}
				}
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00023E74 File Offset: 0x00022074
		public virtual CellRange <<EMPTY_NAME>>(int A_0, int A_1, bool A_2)
		{
			CellRange result;
			if (base.Disposing || base.IsDisposed || base.FindForm() == null || this.o.0O_O0o_. == null)
			{
				result = default(CellRange);
			}
			else if (A_0 < 0 || A_0 > base.Rows.Count - 1)
			{
				result = default(CellRange);
			}
			else if (A_0 >= base.Rows.Fixed && base.Rows[A_0].DataIndex < 0 && A_1 >= 1)
			{
				CellRange cellRange = base.GetCellRange(A_0, A_1);
				CellRange cellRange2 = base.GetCellRange(A_0, 1);
				if (this.o.0O_O0o_..SpillNode && base.Rows[A_0].IsNode)
				{
					int num = base.Cols.Count - 1;
					if (base.Cols.Frozen > 0)
					{
						num = Math.Min(num, base.Cols.Frozen);
					}
					int num2 = cellRange2.c2 + 1;
					int num3 = num;
					int num4 = num2;
					while (num4 <= num3 && Operators.CompareString(this.GetDataDisplay(A_0, num4), "", true) == 0)
					{
						cellRange2.c2 = num4;
						num4++;
					}
				}
				if (cellRange2.Contains(A_0, A_1))
				{
					result = cellRange2;
				}
				else
				{
					result = cellRange;
				}
			}
			else if (A_1 < base.Cols.Fixed || A_0 > base.Rows.Fixed - 1)
			{
				result = base.GetMergedRange(A_0, A_1, A_2);
			}
			else if (A_0 > base.Rows.Count - 1 || A_1 > base.Cols.Count - 1)
			{
				result = base.GetMergedRange(A_0, A_1, A_2);
			}
			else if (A_0 < 0)
			{
				result = base.GetMergedRange(A_0, A_1, A_2);
			}
			else
			{
				CellRange cellRange3 = base.GetCellRange(A_0, A_1);
				string dataDisplay = this.GetDataDisplay(A_0, A_1);
				if (Operators.CompareString(dataDisplay, "", true) == 0)
				{
					result = cellRange3;
				}
				else
				{
					int num5 = cellRange3.r2 + 1;
					int num6 = base.Rows.Fixed - 1;
					int num7 = num5;
					while (num7 <= num6 && Operators.CompareString(this.GetDataDisplay(num7, A_1), dataDisplay, true) == 0)
					{
						cellRange3.r2 = num7;
						num7++;
					}
					int num8 = cellRange3.r1 - 1;
					while (num8 >= 0 && Operators.CompareString(this.GetDataDisplay(num8, A_1), dataDisplay, true) == 0)
					{
						cellRange3.r1 = num8;
						num8 += -1;
					}
					string clip = cellRange3.Clip;
					int num9 = cellRange3.c2 + 1;
					int num10 = base.Cols.Count - 1;
					int num11 = num9;
					while (num11 <= num10 && Operators.CompareString(this.OO_.00oO0Oo.(base.GetCellRange(cellRange3.r1, num11, cellRange3.r2, num11)), clip, true) == 0 && (cellRange3.r1 == 0 || Operators.CompareString(this.GetDataDisplay(cellRange3.r1 - 1, num11), dataDisplay, true) != 0) && (cellRange3.r2 == base.Rows.Fixed - 1 || Operators.CompareString(this.GetDataDisplay(cellRange3.r2 + 1, num11), dataDisplay, true) != 0) && (cellRange3.r1 <= 0 || Operators.CompareString(this.GetDataDisplay(cellRange3.r1 - 1, cellRange3.c2), this.GetDataDisplay(cellRange3.r1 - 1, num11), true) == 0))
					{
						cellRange3.c2 = num11;
						num11++;
					}
					int num12 = cellRange3.c1 - 1;
					int @fixed = base.Cols.Fixed;
					int num13 = num12;
					while (num13 >= @fixed && Operators.CompareString(this.OO_.00oO0Oo.(base.GetCellRange(cellRange3.r1, num13, cellRange3.r2, num13)), clip, true) == 0 && (cellRange3.r1 == 0 || Operators.CompareString(this.GetDataDisplay(cellRange3.r1 - 1, num13), dataDisplay, true) != 0) && (cellRange3.r2 == base.Rows.Fixed - 1 || Operators.CompareString(this.GetDataDisplay(cellRange3.r2 + 1, num13), dataDisplay, true) != 0) && (cellRange3.r1 <= 0 || Operators.CompareString(this.GetDataDisplay(cellRange3.r1 - 1, cellRange3.c1), this.GetDataDisplay(cellRange3.r1 - 1, num13), true) == 0))
					{
						cellRange3.c1 = num13;
						num13 += -1;
					}
					result = cellRange3;
				}
			}
			return result;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000242B8 File Offset: 0x000224B8
		internal void <<EMPTY_NAME>>(int A_0, int A_1, RecordGrid A_2)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (base.Rows[A_0].DataIndex == -1)
				{
					goto IL_CEE;
				}
				IL_20:
				num2 = 4;
				RowColEventArgs rowColEventArgs = new RowColEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_0].DataIndex)), this.o.0O_O0o_..Cols[base.Cols[A_1].Name], null);
				IL_7C:
				num2 = 5;
				string a_ = "CellButtonClick";
				IL_85:
				num2 = 6;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					rowColEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				IL_BB:
				num2 = 7;
				if (base.Disposing || base.IsDisposed || this.o.0O_O0o_..foxGrid.FindForm() == null || !this.o.0O_O0o_..DataTable.GlobalHandler.CellButtonClick || rowColEventArgs.Cancel)
				{
					goto IL_11E;
				}
				IL_FE:
				num2 = 8;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					rowColEventArgs
				}, false, "全局表事件", false);
				IL_11E:
				num2 = 9;
				if (rowColEventArgs.Cancel)
				{
					goto IL_CEE;
				}
				IL_12C:
				num2 = 11;
				string name = base.Cols[A_1].Name;
				IL_142:
				num2 = 12;
				if (this.o.0O_O0o_..Cols[name].DataCol.ExtendColumnType != ExtendColumnTypeEnum.色彩 || base.Cols[A_1].DataType != typeof(int))
				{
					goto IL_265;
				}
				IL_187:
				num2 = 13;
				if (base[A_0, A_1] == null || base[A_0, A_1] == DBNull.Value)
				{
					goto IL_1B5;
				}
				IL_1A3:
				num2 = 14;
				int argb = Conversions.ToInteger(base[A_0, A_1]);
				IL_1B5:
				num2 = 15;
				ColorDialog colorDialog = new ColorDialog();
				IL_1BF:
				num2 = 16;
				colorDialog.Color = Color.FromArgb(argb);
				IL_1D0:
				num2 = 17;
				colorDialog.FullOpen = true;
				IL_1DB:
				num2 = 18;
				if (colorDialog.ShowDialog() != DialogResult.OK)
				{
					goto IL_CEE;
				}
				IL_1EB:
				num2 = 19;
				this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_0].DataIndex).Row, base.Cols[A_1].Name));
				IL_240:
				num2 = 20;
				base[A_0, A_1] = colorDialog.Color.ToArgb();
				goto IL_CEE;
				IL_265:
				num2 = 22;
				if (this.o.0O_O0o_..Cols[name].DataCol.ExtendColumnType != ExtendColumnTypeEnum.邮件 || base.Cols[A_1].DataType != typeof(string))
				{
					goto IL_38F;
				}
				IL_2AA:
				num2 = 23;
				string text = "";
				IL_2B4:
				num2 = 24;
				int topRow = this.Selection.TopRow;
				int bottomRow = this.Selection.BottomRow;
				for (int i = topRow; i <= bottomRow; i++)
				{
					IL_2DB:
					num2 = 25;
					if (base.Rows[i].DataIndex != -1)
					{
						IL_2F3:
						num2 = 27;
						string text2 = base[i, A_1].ToString().ToLower();
						IL_30B:
						num2 = 28;
						if (LikeOperator.LikeString(text2, "*@*.*[a-z]", CompareMethod.Text))
						{
							IL_31D:
							num2 = 29;
							if (Operators.CompareString(text, "", true) == 0)
							{
								IL_32F:
								num2 = 30;
								text = text2;
							}
							else
							{
								IL_338:
								num2 = 32;
								text = text + ";" + text2;
							}
						}
					}
					IL_34B:
					num2 = 33;
				}
				IL_35A:
				num2 = 34;
				if (Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_CEE;
				}
				IL_370:
				num2 = 35;
				this.OO0o_o_OO.O_O.("mailto:" + text, "无效邮件地址！");
				goto IL_CEE;
				IL_38F:
				num2 = 37;
				if (this.o.0O_O0o_..Cols[name].DataCol.ExtendColumnType != ExtendColumnTypeEnum.多文件 || base.Cols[A_1].DataType != typeof(string))
				{
					goto IL_52E;
				}
				IL_3D4:
				num2 = 38;
				System.Windows.Forms.Form form = new System.Windows.Forms.Form();
				IL_3DE:
				num2 = 39;
				form.Text = "文件管理器";
				IL_3ED:
				num2 = 40;
				form.MinimizeBox = false;
				IL_3F8:
				num2 = 41;
				form.MaximizeBox = false;
				IL_403:
				num2 = 42;
				form.FormBorderStyle = FormBorderStyle.FixedDialog;
				IL_40E:
				num2 = 43;
				form.StartPosition = FormStartPosition.CenterScreen;
				IL_419:
				num2 = 44;
				form.ShowInTaskbar = false;
				IL_424:
				num2 = 45;
				form.Size = new Size(350, 500);
				IL_43D:
				num2 = 46;
				form.FormBorderStyle = FormBorderStyle.Sizable;
				IL_448:
				num2 = 47;
				FileManager fileManager = new FileManager();
				IL_452:
				num2 = 48;
				DataCol dataCol = this.o.0O_O0o_..Cols[name].DataCol;
				IL_46E:
				num2 = 49;
				fileManager.Dock = DockStyle.Fill;
				IL_479:
				num2 = 50;
				fileManager.FTPclient = dataCol.FTPClient;
				IL_48A:
				num2 = 51;
				fileManager.DataBindings.Add("FileString", this.o.0O_O0o_..View, name);
				IL_4AC:
				num2 = 52;
				fileManager.AutoUpdate = dataCol.AutoUpdate;
				IL_4BD:
				num2 = 53;
				form.Controls.Add(fileManager);
				IL_4CE:
				num2 = 54;
				form.ShowDialog();
				IL_4D9:
				num2 = 55;
				if (fileManager.FTPclient == null)
				{
					goto IL_510;
				}
				IL_4E5:
				num2 = 56;
				if (!fileManager.FTPclient.Connected)
				{
					goto IL_505;
				}
				IL_4F6:
				num2 = 57;
				fileManager.FTPclient.Close();
				IL_505:
				num2 = 58;
				fileManager.FTPclient = null;
				IL_510:
				num2 = 59;
				fileManager.DataBindings.Clear();
				IL_51F:
				num2 = 60;
				fileManager.Dispose();
				goto IL_CEE;
				IL_52E:
				num2 = 62;
				if (this.o.0O_O0o_..Cols[name].DataCol.ExtendColumnType != ExtendColumnTypeEnum.图片 || base.Cols[A_1].DataType != typeof(string))
				{
					goto IL_6DE;
				}
				IL_573:
				num2 = 63;
				System.Windows.Forms.Form form2 = new System.Windows.Forms.Form();
				IL_57D:
				num2 = 64;
				form2.Text = "图片管理器";
				IL_58C:
				num2 = 65;
				form2.MinimizeBox = false;
				IL_597:
				num2 = 66;
				form2.MaximizeBox = false;
				IL_5A2:
				num2 = 67;
				form2.FormBorderStyle = FormBorderStyle.FixedDialog;
				IL_5AD:
				num2 = 68;
				form2.StartPosition = FormStartPosition.CenterScreen;
				IL_5B8:
				num2 = 69;
				form2.ShowInTaskbar = false;
				IL_5C3:
				num2 = 70;
				form2.Size = new Size(350, 500);
				IL_5DC:
				num2 = 71;
				form2.FormBorderStyle = FormBorderStyle.Sizable;
				IL_5E7:
				num2 = 72;
				DataCol dataCol2 = this.o.0O_O0o_..Cols[name].DataCol;
				IL_603:
				num2 = 73;
				PictureViewer pictureViewer = new PictureViewer();
				IL_60D:
				num2 = 74;
				pictureViewer.FTPclient = dataCol2.FTPClient;
				IL_61E:
				num2 = 75;
				pictureViewer.Dock = DockStyle.Fill;
				IL_629:
				num2 = 76;
				pictureViewer.DataBindings.Add("ImageFiles", this.o.0O_O0o_..View, name);
				IL_64B:
				num2 = 77;
				pictureViewer.AutoDownLoad = dataCol2.AutoDownload;
				IL_65C:
				num2 = 78;
				pictureViewer.AutoUpdate = dataCol2.AutoUpdate;
				IL_66D:
				num2 = 79;
				form2.Controls.Add(pictureViewer);
				IL_67E:
				num2 = 80;
				form2.ShowDialog();
				IL_689:
				num2 = 81;
				if (pictureViewer.FTPclient == null)
				{
					goto IL_6C0;
				}
				IL_695:
				num2 = 82;
				if (!pictureViewer.FTPclient.Connected)
				{
					goto IL_6B5;
				}
				IL_6A6:
				num2 = 83;
				pictureViewer.FTPclient.Close();
				IL_6B5:
				num2 = 84;
				pictureViewer.FTPclient = null;
				IL_6C0:
				num2 = 85;
				pictureViewer.DataBindings.Clear();
				IL_6CF:
				num2 = 86;
				pictureViewer.Dispose();
				goto IL_CEE;
				IL_6DE:
				num2 = 88;
				if (this.o.0O_O0o_..Cols[name].DataCol.ExtendColumnType != ExtendColumnTypeEnum.网址 || base.Cols[A_1].DataType != typeof(string))
				{
					goto IL_7BE;
				}
				IL_723:
				num2 = 89;
				if (base[A_0, A_1] == null || base[A_0, A_1] == DBNull.Value)
				{
					goto IL_CEE;
				}
				IL_745:
				num2 = 90;
				string text3 = base[A_0, A_1].ToString().ToLower();
				IL_75C:
				num2 = 91;
				if (!text3.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) && !text3.StartsWith("www.", StringComparison.CurrentCultureIgnoreCase) && !text3.StartsWith("ftp.", StringComparison.CurrentCultureIgnoreCase) && !text3.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase))
				{
					goto IL_CEE;
				}
				IL_79E:
				num2 = 92;
				this.OO0o_o_OO.O_O.(base[A_0, A_1].ToString(), "无效网址！");
				goto IL_CEE;
				IL_7BE:
				num2 = 94;
				if (this.o.0O_O0o_..Cols[name].DataCol.ExtendColumnType != ExtendColumnTypeEnum.QQ || base.Cols[A_1].DataType != typeof(string))
				{
					goto IL_868;
				}
				IL_801:
				num2 = 95;
				if (base[A_0, A_1] == null || base[A_0, A_1] == DBNull.Value)
				{
					goto IL_CEE;
				}
				IL_823:
				num2 = 96;
				string text4 = base[A_0, A_1].ToString().ToLower();
				IL_83A:
				num2 = 97;
				if (!Versioned.IsNumeric(text4))
				{
					goto IL_CEE;
				}
				IL_849:
				num2 = 98;
				this.OO0o_o_OO.O_O.("tencent://message/?uin=" + text4, "无效QQ号！");
				goto IL_CEE;
				IL_868:
				num2 = 100;
				if (this.o.0O_O0o_..Cols[name].DataCol.ExtendColumnType != ExtendColumnTypeEnum.旺旺 || base.Cols[A_1].DataType != typeof(string))
				{
					goto IL_900;
				}
				IL_8A8:
				num2 = 101;
				if (base[A_0, A_1] == null || base[A_0, A_1] == DBNull.Value)
				{
					goto IL_CEE;
				}
				IL_8CA:
				num2 = 102;
				string str = base[A_0, A_1].ToString().ToLower();
				IL_8E1:
				num2 = 103;
				this.OO0o_o_OO.O_O.("aliim:sendmsg?touid=cntaobao" + str, "无效旺旺号！");
				goto IL_CEE;
				IL_900:
				num2 = 105;
				if (this.o.0O_O0o_..Cols[name].DataCol.ExtendColumnType != ExtendColumnTypeEnum.文件 || base.Cols[A_1].DataType != typeof(string))
				{
					goto IL_BD8;
				}
				IL_945:
				num2 = 106;
				ContextMenu contextMenu = new ContextMenu();
				IL_94F:
				num2 = 107;
				string text5 = null;
				IL_955:
				num2 = 108;
				if (base[A_0, A_1] == null || base[A_0, A_1] == DBNull.Value)
				{
					goto IL_983;
				}
				IL_971:
				num2 = 109;
				text5 = base[A_0, A_1].ToString();
				IL_983:
				num2 = 110;
				if (Operators.CompareString(text5, "", true) <= 0)
				{
					goto IL_A41;
				}
				IL_999:
				num2 = 111;
				if (!text5.StartsWith("[") || !text5.EndsWith("]"))
				{
					goto IL_9E7;
				}
				IL_9B8:
				num2 = 112;
				MenuItem item = new MenuItem("打开目录(&O)", new EventHandler(this.O__.0_O.));
				IL_9D3:
				num2 = 113;
				contextMenu.MenuItems.Add(item);
				goto IL_A41;
				IL_9E7:
				num2 = 115;
				item = new MenuItem("打开文件(&O)", new EventHandler(this.O__.0_O.));
				IL_A02:
				num2 = 116;
				contextMenu.MenuItems.Add(item);
				IL_A14:
				num2 = 117;
				item = new MenuItem("另存文件(&S)", new EventHandler(this.o.o0OO00oO_0.));
				IL_A2F:
				num2 = 118;
				contextMenu.MenuItems.Add(item);
				IL_A41:
				num2 = 119;
				item = new MenuItem("插入文件(&F)", new EventHandler(this.o0o0o0.oooOO0.));
				IL_A5C:
				num2 = 120;
				contextMenu.MenuItems.Add(item);
				IL_A6E:
				num2 = 121;
				item = new MenuItem("插入目录(&D)", new EventHandler(this.o0o0__.o.));
				IL_A89:
				num2 = 122;
				contextMenu.MenuItems.Add(item);
				IL_A9B:
				num2 = 123;
				if (Operators.CompareString(text5, "", true) <= 0)
				{
					goto IL_AFC;
				}
				IL_AAE:
				num2 = 124;
				item = new MenuItem("-");
				IL_ABD:
				num2 = 125;
				contextMenu.MenuItems.Add(item);
				IL_ACF:
				num2 = 126;
				item = new MenuItem("清除内容(&C)", new EventHandler(this.oO0O00o0o.O.));
				IL_AEA:
				num2 = 127;
				contextMenu.MenuItems.Add(item);
				IL_AFC:
				num2 = 128;
				if (A_2 != null)
				{
					goto IL_B62;
				}
				IL_B05:
				num2 = 129;
				contextMenu.Show(this, new Point(base.Cols[A_1].Right - 16 + base.ScrollPosition.X, base.Rows[A_0].Bottom + base.ScrollPosition.Y));
				goto IL_CEE;
				IL_B62:
				num2 = 131;
				C1FlexGrid baseGrid = A_2.BaseGrid;
				IL_B70:
				num2 = 132;
				contextMenu.Show(baseGrid, new Point(baseGrid.Cols[1].Right - 16 + baseGrid.ScrollPosition.X, baseGrid.Rows[baseGrid.Row].Bottom + baseGrid.ScrollPosition.Y));
				goto IL_CEE;
				IL_BD8:
				num2 = 134;
				if (base.Cols[A_1].DataType != typeof(string))
				{
					goto IL_CEE;
				}
				IL_BFE:
				num2 = 135;
				O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000 o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u = new O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000();
				IL_C0B:
				num2 = 136;
				if (base.Rows[base.Row].DataIndex < 0)
				{
					goto IL_CEE;
				}
				IL_C2D:
				num2 = 138;
				DataRow row = this.o.0O_O0o_..View.o_o.O0ooOo.().Row;
				IL_C4A:
				num2 = 139;
				if (row.IsNull(name))
				{
					goto IL_C7B;
				}
				IL_C5B:
				num2 = 140;
				o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.O0.00o__OO.().Value = row[name].ToString();
				IL_C7B:
				num2 = 141;
				o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.Text = o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.Text + " - " + name;
				IL_C9B:
				num2 = 142;
				if (o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.ShowDialog() != DialogResult.OK)
				{
					goto IL_CEE;
				}
				IL_CAB:
				num2 = 143;
				if (Operators.CompareString(o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.O0.00o__OO.().Text, row[name].ToString(), true) == 0)
				{
					goto IL_CEE;
				}
				IL_CD3:
				num2 = 144;
				row[name] = o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.O0.00o__OO.().Text;
				IL_CEE:
				goto IL_F84;
				IL_CF3:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_F45:
				goto IL_F79;
				IL_F47:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_F57:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_F47;
			}
			IL_F79:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_F84:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00025270 File Offset: 0x00023470
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			try
			{
				Process.Start(A_0);
			}
			catch (Exception ex)
			{
				MessageBox.Show(A_1, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000252B4 File Offset: 0x000234B4
		internal void <<EMPTY_NAME>>(int A_0, int A_1, RecordGrid A_2)
		{
			if (base.FindForm() != null && this.o.0O_O0o_. != null && A_0 >= 0 && A_1 != 0 && A_0 < base.Rows.Count && base.Rows[A_0].DataIndex != -1)
			{
				DataRow row = this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_0].DataIndex).Row;
				if (row.RowState != DataRowState.Detached && row.HasVersion(DataRowVersion.Proposed))
				{
					row.CancelEdit();
					return;
				}
				RowColEventArgs rowColEventArgs = new RowColEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_0].DataIndex)), this.o.0O_O0o_..Cols[base.Cols[A_1].Name], A_2);
				MethodInfo methodInfo = this.o.0O_O0o_..DataTable.O0O00o_.0Oo.;
				if (methodInfo != null && OO_00oOO.SystemReady)
				{
					try
					{
						methodInfo.Invoke(null, new object[]
						{
							rowColEventArgs
						});
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "表，" + this.o.0O_O0o_..DataTable.Name + "，AfterEdit");
					}
				}
				if (this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.AfterEdit && OO_00oOO.SystemReady)
				{
					methodInfo = O_O0OO.O0_00o.o0__o..o0Oo.Oo_0oO0o.;
					if (methodInfo != null)
					{
						try
						{
							methodInfo.Invoke(null, new object[]
							{
								rowColEventArgs
							});
						}
						catch (Exception a_2)
						{
							ooO.oOo0Oo.o.(a_2, "全局表事件，AfterEdit");
						}
					}
				}
				if (this.o_.o. != null)
				{
					this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(this.o_.o.);
					this.o_.o. = null;
				}
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000254BC File Offset: 0x000236BC
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			this.O.O0_0.(A_1.Row, A_1.Col, null);
			if (base.Row != A_1.Row && this.o.0O_O0o_..Name.Length - this.o.0O_O0o_..Name.Replace(".", "").Length >= 2)
			{
				base.Row = A_1.Row;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0002552C File Offset: 0x0002372C
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			RowColPositionEventArgs rowColPositionEventArgs = new RowColPositionEventArgs(this.o.0O_O0o_., A_1.Col - base.Cols.Fixed);
			string a_ = "AfterFreezeColumn";
			O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
			{
				rowColPositionEventArgs
			}, false, this.o.0O_O0o_..DataTable.Name, false);
			if (!base.Disposing && !base.IsDisposed && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.AfterFreezeColumn)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					rowColPositionEventArgs
				}, false, "全局表事件", false);
			}
			if (this.o.0O_O0o_. != null)
			{
				this.o.0O_O0o_..NeedSaveSetting = true;
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000255FC File Offset: 0x000237FC
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			RowColPositionEventArgs rowColPositionEventArgs = new RowColPositionEventArgs(this.o.0O_O0o_., A_1.Col - base.Cols.Fixed);
			string a_ = "AfterResizeColumn";
			O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
			{
				rowColPositionEventArgs
			}, false, this.o.0O_O0o_..DataTable.Name, false);
			if (!base.Disposing && !base.IsDisposed && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.AfterResizeColumn)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					rowColPositionEventArgs
				}, false, "全局表事件", false);
			}
			if (this.o.0O_O0o_. != null)
			{
				this.o.0O_O0o_..NeedSaveSetting = true;
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000256CC File Offset: 0x000238CC
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Row >= base.Rows.Fixed)
			{
				this.BeginUpdate();
				if (!this.o.0O_O0o_..AllowResizeSingleRow)
				{
					base.Rows.DefaultSize = base.Rows[A_1.Row].HeightDisplay;
					int @fixed = base.Rows.Fixed;
					int num = base.Rows.Count - 1;
					for (int i = @fixed; i <= num; i++)
					{
						base.Rows[i].Height = -1;
					}
				}
				this.EndUpdate();
			}
			RowColPositionEventArgs rowColPositionEventArgs = new RowColPositionEventArgs(this.o.0O_O0o_., A_1.Row - base.Rows.Fixed);
			string a_ = "AfterResizeRow";
			O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
			{
				rowColPositionEventArgs
			}, false, this.o.0O_O0o_..DataTable.Name, false);
			if (!base.Disposing && !base.IsDisposed && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.AfterResizeRow)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					rowColPositionEventArgs
				}, false, "全局表事件", false);
			}
			if (this.o.0O_O0o_. != null)
			{
				this.o.0O_O0o_..NeedSaveSetting = true;
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0002581D File Offset: 0x00023A1D
		internal void <<EMPTY_NAME>>()
		{
			if (base.FindForm() != null)
			{
				this.o.O_0o.(this, new RangeEventArgs(this.Selection, this.Selection));
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00025840 File Offset: 0x00023A40
		private void <<EMPTY_NAME>>(object A_0, RangeEventArgs A_1)
		{
			if (OO_00oOO.SystemReady && OO_00oOO.Tables.get_Contains(this.o.0O_O0o_..Name))
			{
				CellRangeChangeEventArgs cellRangeChangeEventArgs = new CellRangeChangeEventArgs(this.o.0O_O0o_., new CellRange(this.o.0O_O0o_., A_1.OldRange), new CellRange(this.o.0O_O0o_., A_1.NewRange));
				string a_ = "AfterSelChange";
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					cellRangeChangeEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				if (!base.Disposing && !base.IsDisposed && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.AfterSelChange)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						cellRangeChangeEventArgs
					}, false, "全局表事件", false);
				}
				a_ = "AfterSelChange_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag);
				TableEventArgs tableEventArgs = new TableEventArgs(this.o.0O_O0o_.);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, new object[]
				{
					tableEventArgs
				}, false, "菜单", false);
				if (A_1.NewRange.r1 != A_1.OldRange.r1)
				{
					base.Invalidate(A_1.NewRange.r1, 0, A_1.NewRange.r2, base.Cols.Count - 1);
					base.Invalidate(A_1.OldRange.r1, 0, A_1.OldRange.r2, base.Cols.Count - 1);
				}
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000259F4 File Offset: 0x00023BF4
		internal void <<EMPTY_NAME>>(bool A_0 = false)
		{
			if (base.Cols[0].DataType != typeof(bool) && base.Rows.Count > base.Rows.Fixed && !base.Rows[base.Rows.Fixed].IsNode && !base.Rows[base.Rows.Count - 1].IsNode && ((base.BottomRow >= base.Rows.Fixed && base.TopRow >= base.Rows.Fixed) || this.o_.o. == 0) && (this.o_.o..ToString().Length != base.BottomRow.ToString().Length || this.o_.o. == 0 || A_0))
			{
				this.oo0_oo0.ooo_o.();
			}
			this.o_.o. = base.BottomRow;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00025AEC File Offset: 0x00023CEC
		internal void <<EMPTY_NAME>>()
		{
			Graphics graphics = base.CreateGraphics();
			int count = Math.Max(3, base.BottomRow.ToString().Length);
			base.Cols[0].Width = (int)Math.Round((double)graphics.MeasureString(new string('0', count), this.Font, 100).Width) + 5;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00025B54 File Offset: 0x00023D54
		private void <<EMPTY_NAME>>(object A_0, RangeEventArgs A_1)
		{
			this.O.O00O_oO_OO00.(false);
			if (base.Rows.Fixed > 1 && A_1.OldRange.TopRow == A_1.NewRange.TopRow)
			{
				int num = base.Rows.Fixed - 1;
				for (int i = 0; i <= num; i++)
				{
					base.Rows[i].Invalidate();
				}
			}
			TableEventArgs tableEventArgs = new TableEventArgs(this.o.0O_O0o_.);
			string a_ = "AfterScroll";
			if (OO_00oOO.SystemReady && base.FindForm() != null)
			{
				if (this.o.0O_O0o_..o0__OOo0._oO. == null)
				{
					O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
					{
						tableEventArgs
					}, false, this.o.0O_O0o_..DataTable.Name, false);
				}
				else
				{
					O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..o0__OOo0._oO., a_, new object[]
					{
						tableEventArgs
					}, false, this.o.0O_O0o_..DataTable.Name, false);
				}
				if (!base.Disposing && !base.IsDisposed && this.o.0O_O0o_..DataTable.GlobalHandler.AfterScroll)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						tableEventArgs
					}, false, "全局表事件", false);
				}
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00025C9F File Offset: 0x00023E9F
		internal void <<EMPTY_NAME>>()
		{
			if (base.FindForm() != null)
			{
				this.oO.o_o0O.(this, new RangeEventArgs(this.Selection, this.Selection));
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00025CC4 File Offset: 0x00023EC4
		private void <<EMPTY_NAME>>(object A_0, RangeEventArgs A_1)
		{
			if (OO_00oOO.SystemReady && OO_00oOO.Tables.get_Contains(this.o.0O_O0o_..Name) && base.Cols.Count > base.Cols.Fixed && A_1.NewRange.LeftCol >= base.Cols.Fixed)
			{
				int @fixed = base.Cols.Fixed;
				int num = base.Cols.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					if (Operators.CompareString(base.Cols[i].Name, "", true) == 0)
					{
						return;
					}
				}
				CellRangeChangeEventArgs cellRangeChangeEventArgs = new CellRangeChangeEventArgs(this.o.0O_O0o_., new CellRange(this.o.0O_O0o_., A_1.OldRange), new CellRange(this.o.0O_O0o_., A_1.NewRange));
				string a_ = "AfterSelRangeChange";
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					cellRangeChangeEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				if (!base.Disposing && !base.IsDisposed && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.AfterSelRangeChange)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						cellRangeChangeEventArgs
					}, false, "全局表事件", false);
				}
				a_ = "AfterSelRangeChange_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag);
				TableEventArgs tableEventArgs = new TableEventArgs(this.o.0O_O0o_.);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, new object[]
				{
					tableEventArgs
				}, false, "菜单", false);
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00025E80 File Offset: 0x00024080
		private void <<EMPTY_NAME>>(object A_0, BeforeMouseDownEventArgs A_1)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (base.Row < 0 || base.Rows[base.Row].DataIndex < 0)
				{
					goto IL_3C0;
				}
				IL_31:
				num2 = 4;
				if (base.Editor != null)
				{
					goto IL_3C0;
				}
				IL_3E:
				num2 = 5;
				if (this.MouseRow < base.Rows.Fixed || this.MouseCol < base.Cols.Fixed)
				{
					goto IL_206;
				}
				IL_6C:
				num2 = 6;
				CellClickEventArgs cellClickEventArgs = new CellClickEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[base.Row].DataIndex)), this.o.0O_O0o_..Cols[base.Cols[base.Col].Name], null, A_1.Button.ToString());
				IL_E7:
				num2 = 7;
				string a_ = "DoubleClick";
				IL_F0:
				num2 = 8;
				if (this.o.0O_O0o_..o0__OOo0._oO. != null)
				{
					goto IL_138;
				}
				IL_FF:
				num2 = 9;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					cellClickEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				goto IL_16A;
				IL_138:
				num2 = 11;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..o0__OOo0._oO., a_, new object[]
				{
					cellClickEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				IL_16A:
				num2 = 12;
				if (cellClickEventArgs.Cancel || base.Disposing || base.IsDisposed)
				{
					goto IL_1D2;
				}
				IL_185:
				num2 = 13;
				if (this.o.0O_O0o_..foxGrid.FindForm() == null || !this.o.0O_O0o_..DataTable.GlobalHandler.DoubleClick)
				{
					goto IL_1D2;
				}
				IL_1B1:
				num2 = 14;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					cellClickEventArgs
				}, false, "全局表事件", false);
				IL_1D2:
				num2 = 15;
				A_1.Cancel = cellClickEventArgs.Cancel;
				IL_1E1:
				num2 = 16;
				if (!base.Disposing && !base.IsDisposed)
				{
					goto IL_3C0;
				}
				IL_1F7:
				num2 = 17;
				A_1.Cancel = true;
				goto IL_3C0;
				IL_206:
				num2 = 19;
				if (this.MouseRow < base.Rows.Fixed || this.MouseCol >= base.Cols.Fixed)
				{
					goto IL_3C0;
				}
				IL_235:
				num2 = 20;
				CellClickEventArgs cellClickEventArgs2 = new CellClickEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[base.Row].DataIndex)), this.o.0O_O0o_..Cols[base.Cols[base.Col].Name], null, A_1.Button.ToString());
				IL_2B2:
				num2 = 21;
				string a_2 = "DoubleClickRowHeader";
				IL_2BC:
				num2 = 22;
				if (this.o.0O_O0o_..o0__OOo0._oO. != null)
				{
					goto IL_306;
				}
				IL_2CC:
				num2 = 23;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_2, new object[]
				{
					cellClickEventArgs2
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				goto IL_339;
				IL_306:
				num2 = 25;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..o0__OOo0._oO., a_2, new object[]
				{
					cellClickEventArgs2
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				IL_339:
				num2 = 26;
				if (cellClickEventArgs2.Cancel || base.Disposing || base.IsDisposed)
				{
					goto IL_3A3;
				}
				IL_355:
				num2 = 27;
				if (this.o.0O_O0o_..foxGrid.FindForm() == null || !this.o.0O_O0o_..DataTable.GlobalHandler.DoubleClickRowHeader)
				{
					goto IL_3A3;
				}
				IL_381:
				num2 = 28;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_2, new object[]
				{
					cellClickEventArgs2
				}, false, "全局表事件", false);
				IL_3A3:
				num2 = 29;
				if (!base.Disposing && !base.IsDisposed)
				{
					goto IL_3C0;
				}
				IL_3B6:
				num2 = 30;
				A_1.Cancel = true;
				IL_3C0:
				goto IL_48E;
				IL_3C5:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_44F:
				goto IL_483;
				IL_451:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_461:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_451;
			}
			IL_483:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_48E:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00026340 File Offset: 0x00024540
		private void <<EMPTY_NAME>>(object A_0, DragRowColEventArgs A_1)
		{
			int leftCol = this.Selection.LeftCol;
			int rightCol = this.Selection.RightCol;
			A_1.Cancel = true;
			this.o.0O_O0o_..O.__O0o0.(leftCol, rightCol, A_1.Position, true);
			this.o.0O_O0o_..NeedSaveSetting = true;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00026394 File Offset: 0x00024594
		internal bool <<EMPTY_NAME>>(int A_0, int A_1)
		{
			RowColEventArgs rowColEventArgs = new RowColEventArgs(A_0, A_1);
			this.O.O0_0.(this, rowColEventArgs, null);
			bool result;
			if (rowColEventArgs.Cancel)
			{
				result = false;
			}
			else
			{
				this.OOOo_oO_O.O.(this, rowColEventArgs, null);
				result = !rowColEventArgs.Cancel;
			}
			return result;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000263D8 File Offset: 0x000245D8
		internal void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1, RecordGrid A_2)
		{
			this.oo_OOo0.O___oo. = true;
			if (this.O_._. == BooleanEnum.False)
			{
				A_1.Cancel = true;
				this.O_._. = BooleanEnum.Default;
				return;
			}
			this.O_._. = BooleanEnum.Default;
			checked
			{
				if (A_1.Col != 0 || base.Cols[0].DataType != typeof(bool))
				{
					string name = base.Cols[A_1.Col].Name;
					if (this.o.0O_O0o_..IsSubtotal || !OO_00oOO.SystemReady || this.o.0O_O0o_..Position < 0)
					{
						A_1.Cancel = true;
						return;
					}
					if (Operators.CompareString(name, "", true) == 0 || base.Rows[A_1.Row].DataIndex == -1 || (!base.Cols[A_1.Col].Visible & A_2 == null))
					{
						A_1.Cancel = true;
					}
					else if (!this.o.0O_O0o_..AllowEdit)
					{
						A_1.Cancel = true;
					}
					else if (!this.o.0O_O0o_..Cols[name].AllowEdit)
					{
						A_1.Cancel = true;
					}
					else if (new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex)).Locked)
					{
						A_1.Cancel = true;
					}
					else if (A_1.Col < base.Cols.Fixed & A_1.Row < base.Rows.Fixed)
					{
						A_1.Cancel = true;
					}
					else if (this.o.0O_O0o_..DataTable.BaseTable.Columns[name].AutoIncrement)
					{
						A_1.Cancel = true;
					}
					else if (O_O0OO.O0OO_.0.)
					{
						DataColumn[] primaryKey = this.o.0O_O0o_..DataTable.BaseTable.PrimaryKey;
						for (int i = 0; i < primaryKey.Length; i++)
						{
							if (Operators.CompareString(primaryKey[i].ColumnName, name, true) == 0)
							{
								A_1.Cancel = true;
								break;
							}
						}
					}
					if (!A_1.Cancel)
					{
						RowColEventArgs rowColEventArgs = new RowColEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex)), this.o.0O_O0o_..Cols[base.Cols[A_1.Col].Name], A_2);
						if (A_0 != this)
						{
							rowColEventArgs.IsFocusCell = true;
						}
						else
						{
							rowColEventArgs.IsFocusCell = (A_1.Row == base.Row && base.Col == A_1.Col);
						}
						MethodInfo methodInfo = this.o.0O_O0o_..DataTable.Oo0O00Ooo._.;
						string text = "PrepareEdit事件执行错误，在您修正代码之前，将暂停执行该事件代码！";
						if (methodInfo != null && OO_00oOO.SystemReady)
						{
							try
							{
								methodInfo.Invoke(null, new object[]
								{
									rowColEventArgs
								});
							}
							catch (Exception a_)
							{
								this.o.0O_O0o_..DataTable.Oo0O00Ooo._. = null;
								ooO.oOo0Oo.o.(a_, "表，" + this.o.0O_O0o_..DataTable.Name + "，PrepareEdit");
								MessageBox.Show(text, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							}
						}
						if (this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.PrepareEdit && !rowColEventArgs.Cancel && OO_00oOO.SystemReady)
						{
							methodInfo = O_O0OO.O0_00o.o0__o..OO00_oo0o_._O.;
							if (methodInfo != null)
							{
								try
								{
									methodInfo.Invoke(null, new object[]
									{
										rowColEventArgs
									});
								}
								catch (Exception a_2)
								{
									O_O0OO.O0_00o.o0__o..OO00_oo0o_._O. = null;
									ooO.oOo0Oo.o.(a_2, "全局表事件，PrepareEdit");
									MessageBox.Show(text, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								}
							}
						}
						A_1.Cancel = rowColEventArgs.Cancel;
						this.oo_OOo0.O___oo. = rowColEventArgs.Continue;
						C1FlexGrid c1FlexGrid = (C1FlexGrid)A_0;
						if (!this.o.0O_O0o_..Cols[name].DataCol.IsString || Operators.CompareString(base.Cols[A_1.Col].EditMask, "", true) > 0)
						{
							c1FlexGrid.ImeMode = ImeMode.Close;
							return;
						}
						if (this.o.0O_O0o_..Cols[name].DataCol.ImeMode == BooleanEnum.True)
						{
							c1FlexGrid.ImeMode = ImeMode.On;
							return;
						}
						if (this.o.0O_O0o_..Cols[name].DataCol.ImeMode == BooleanEnum.False)
						{
							c1FlexGrid.ImeMode = ImeMode.Close;
							return;
						}
						c1FlexGrid.ImeMode = ImeMode.NoControl;
					}
				}
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0002688C File Offset: 0x00024A8C
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Col == 0 && base.Rows[A_1.Row].DataIndex < 0)
			{
				A_1.Cancel = true;
				return;
			}
			if (!base.GetMergedRange(A_1.Row, A_1.Col).IsSingleCell)
			{
				A_1.Cancel = true;
				return;
			}
			System.Windows.Forms.Control editor = base.Cols[A_1.Col].Editor;
			if (editor != null && editor is BuildInDropTree && ((BuildInDropTree)editor).Ooo._0oO..IsDisposed)
			{
				DataCol dataCol = this.o.0O_O0o_..Cols[base.Cols[A_1.Col].Name].DataCol;
				DataTable dataTable = dataCol.DataTable;
				dataCol.oO0._00o_0. = null;
				try
				{
					foreach (Foxtable.Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == dataCol.DataTable)
						{
							try
							{
								foreach (Col col in table.Cols)
								{
									if (col.DataCol == dataCol)
									{
										col.o0.O.();
									}
								}
							}
							finally
							{
								IEnumerator<Col> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator<Foxtable.Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			this.O.O0_0.(RuntimeHelpers.GetObjectValue(A_0), A_1, null);
			this.o_O.Oo. = !A_1.Cancel;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00026A10 File Offset: 0x00024C10
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			RowColPositionEventArgs rowColPositionEventArgs = new RowColPositionEventArgs(this.o.0O_O0o_., A_1.Col - base.Cols.Fixed);
			string a_ = "BeforeFreezeColumn";
			O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
			{
				rowColPositionEventArgs
			}, false, this.o.0O_O0o_..DataTable.Name, false);
			if (!base.Disposing && !base.IsDisposed && !rowColPositionEventArgs.Cancel && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.BeforeFreezeColumn)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					rowColPositionEventArgs
				}, false, "全局表事件", false);
			}
			A_1.Cancel = rowColPositionEventArgs.Cancel;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00026AE0 File Offset: 0x00024CE0
		private void <<EMPTY_NAME>>(object A_0, BeforeMouseDownEventArgs A_1)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.Focused || !base.CanFocus || base.Editor != null)
				{
					goto IL_8A;
				}
				IL_21:
				num2 = 3;
				base.Focus();
				IL_2A:
				num2 = 4;
				if (!this.Focused || this.MouseRow < base.Rows.Fixed || this.MouseRow > base.Rows.Count - 1 || this.Selection.ContainsRow(this.MouseRow) || this.MouseCol <= 0)
				{
					goto IL_8A;
				}
				IL_7C:
				num2 = 5;
				base.Row = this.MouseRow;
				IL_8A:
				num2 = 6;
				HitTestInfo hitTestInfo = base.HitTest(A_1.X, A_1.Y);
				IL_9F:
				num2 = 7;
				if (hitTestInfo.Type == HitTestTypeEnum.None)
				{
					goto IL_5E5;
				}
				IL_AD:
				num2 = 9;
				if (A_1.Button != MouseButtons.Left || System.Windows.Forms.Control.ModifierKeys != Keys.Shift || hitTestInfo.Type != HitTestTypeEnum.RowHeader)
				{
					goto IL_138;
				}
				IL_D3:
				num2 = 10;
				if (this.MouseRow < base.Rows.Fixed || base.Row < base.Rows.Fixed)
				{
					goto IL_138;
				}
				IL_FC:
				num2 = 11;
				base.Select(base.Row, base.Cols.Fixed, this.MouseRow, base.Cols.Count - 1);
				IL_129:
				num2 = 12;
				A_1.Cancel = true;
				goto IL_5E5;
				IL_138:
				num2 = 14;
				if (A_1.Button != MouseButtons.Left || (System.Windows.Forms.Control.ModifierKeys != Keys.Control && !this.o.0O_O0o_..AllowClickSort))
				{
					goto IL_238;
				}
				IL_167:
				num2 = 15;
				if (hitTestInfo.Type != HitTestTypeEnum.ColumnHeader)
				{
					goto IL_238;
				}
				IL_177:
				num2 = 16;
				int column = hitTestInfo.Column;
				IL_182:
				num2 = 17;
				if (hitTestInfo.Column < base.Cols.Fixed)
				{
					goto IL_238;
				}
				IL_19C:
				num2 = 18;
				if (Operators.CompareString(this.o.0O_O0o_..Sort, "", true) != 0 && !this.o.0O_O0o_..Sort.ToLower().EndsWith(" desc"))
				{
					goto IL_1FA;
				}
				IL_1D3:
				num2 = 19;
				this.o.0O_O0o_..Sort = base.Cols[hitTestInfo.Column].Name;
				goto IL_229;
				IL_1FA:
				num2 = 21;
				this.o.0O_O0o_..Sort = base.Cols[hitTestInfo.Column].Name + " desc";
				IL_229:
				num2 = 22;
				A_1.Cancel = true;
				goto IL_5E5;
				IL_238:
				num2 = 24;
				if (!(hitTestInfo.Type == HitTestTypeEnum.ColumnHeader & hitTestInfo.Column >= base.Cols.Fixed))
				{
					goto IL_2D7;
				}
				IL_25F:
				num2 = 25;
				if (!this.o.0O_O0o_..AllowDragColumn || this.Selection.TopRow != base.Rows.Fixed || this.Selection.BottomRow != base.Rows.Count - 1 || !this.Selection.ContainsCol(hitTestInfo.Column))
				{
					goto IL_2CD;
				}
				IL_2C1:
				num2 = 26;
				base.AllowDragging = AllowDraggingEnum.Columns;
				goto IL_2D7;
				IL_2CD:
				num2 = 28;
				base.AllowDragging = AllowDraggingEnum.None;
				IL_2D7:
				num2 = 29;
				if (this.o.0O_O0o_..View.Count == 0 | base.Col < base.Cols.Fixed)
				{
					goto IL_5E5;
				}
				IL_306:
				num2 = 31;
				if (this.Selection.Contains(this.MouseRow, this.MouseCol) || A_1.Button == MouseButtons.Left)
				{
					goto IL_5E5;
				}
				IL_339:
				num2 = 34;
				if (this.MouseCol >= base.Cols.Fixed || this.MouseRow >= base.Rows.Fixed)
				{
					goto IL_3A1;
				}
				IL_362:
				num2 = 35;
				base.Select(base.Rows.Fixed, base.Cols.Fixed, base.Rows.Count - 1, base.Cols.Count - 1, false);
				goto IL_5E5;
				IL_3A1:
				num2 = 37;
				if (this.MouseRow >= base.Rows.Fixed || this.MouseCol < base.Cols.Fixed)
				{
					goto IL_4A7;
				}
				IL_3D0:
				num2 = 38;
				if (this.Selection.TopRow == base.Rows.Fixed && this.Selection.BottomRow == base.Rows.Count - 1)
				{
					goto IL_440;
				}
				IL_40D:
				num2 = 39;
				base.Select(base.Rows.Fixed, this.MouseCol, base.Rows.Count - 1, this.MouseCol, false);
				goto IL_5E5;
				IL_440:
				num2 = 41;
				if (this.MouseCol >= this.Selection.LeftCol && this.MouseCol <= this.Selection.RightCol)
				{
					goto IL_5E5;
				}
				IL_474:
				num2 = 42;
				base.Select(base.Rows.Fixed, this.MouseCol, base.Rows.Count - 1, this.MouseCol, false);
				goto IL_5E5;
				IL_4A7:
				num2 = 44;
				if (this.MouseCol >= base.Cols.Fixed || this.MouseRow < base.Rows.Fixed)
				{
					goto IL_5A7;
				}
				IL_4D6:
				num2 = 45;
				if (this.Selection.LeftCol == base.Cols.Fixed && this.Selection.RightCol == base.Cols.Count - 1)
				{
					goto IL_546;
				}
				IL_513:
				num2 = 46;
				base.Select(this.MouseRow, base.Cols.Fixed, this.MouseRow, base.Cols.Count - 1, false);
				goto IL_5E5;
				IL_546:
				num2 = 48;
				if (this.MouseRow >= this.Selection.TopRow && this.MouseRow <= this.Selection.BottomRow)
				{
					goto IL_5E5;
				}
				IL_577:
				num2 = 49;
				base.Select(this.MouseRow, base.Cols.Fixed, this.MouseRow, base.Cols.Count - 1, false);
				goto IL_5E5;
				IL_5A7:
				num2 = 51;
				if (this.MouseRow < base.Rows.Fixed || this.MouseCol < base.Cols.Fixed)
				{
					goto IL_5E5;
				}
				IL_5D0:
				num2 = 52;
				base.Select(this.MouseRow, this.MouseCol);
				IL_5E5:
				goto IL_70B;
				IL_5EA:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_6CC:
				goto IL_700;
				IL_6CE:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_6DE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_6CE;
			}
			IL_700:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_70B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0002721C File Offset: 0x0002541C
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			RowColPositionEventArgs rowColPositionEventArgs = new RowColPositionEventArgs(this.o.0O_O0o_., A_1.Col - base.Cols.Fixed);
			string a_ = "BeforeResizeColumn";
			O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
			{
				rowColPositionEventArgs
			}, false, this.o.0O_O0o_..DataTable.Name, false);
			if (!base.Disposing && !base.IsDisposed && !rowColPositionEventArgs.Cancel && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.BeforeResizeColumn)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					rowColPositionEventArgs
				}, false, "全局表事件", false);
			}
			A_1.Cancel = rowColPositionEventArgs.Cancel;
			if (!A_1.Cancel)
			{
				this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(new OoO_oO(this.o.0O_O0o_.));
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00027310 File Offset: 0x00025510
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			int num = base.Rows.Fixed - 1;
			for (int i = 0; i <= num; i++)
			{
				base.Rows[i].Height = base.Rows[i].HeightDisplay;
			}
			RowColPositionEventArgs rowColPositionEventArgs = new RowColPositionEventArgs(this.o.0O_O0o_., A_1.Row - base.Rows.Fixed);
			string a_ = "BeforeResizeRow";
			O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
			{
				rowColPositionEventArgs
			}, false, this.o.0O_O0o_..DataTable.Name, false);
			if (!base.Disposing && !base.IsDisposed && !rowColPositionEventArgs.Cancel && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.BeforeResizeRow)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					rowColPositionEventArgs
				}, false, "全局表事件", false);
			}
			A_1.Cancel = rowColPositionEventArgs.Cancel;
			if (!A_1.Cancel)
			{
				if (A_1.Row < base.Rows.Fixed)
				{
					this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(new O00OOO0o_00o(this.o.0O_O0o_., A_1.Row, base.Rows[A_1.Row].Height));
					return;
				}
				this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(new o_o0_(this.o.0O_O0o_., A_1.Row, base.Rows[A_1.Row].Height));
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000274A8 File Offset: 0x000256A8
		private void <<EMPTY_NAME>>(object A_0, RangeEventArgs A_1)
		{
			if (OO_00oOO.SystemReady)
			{
				CellRangeChangeEventArgs cellRangeChangeEventArgs = new CellRangeChangeEventArgs(this.o.0O_O0o_., new CellRange(this.o.0O_O0o_., A_1.OldRange), new CellRange(this.o.0O_O0o_., A_1.NewRange));
				if (OO_00oOO.Tables.get_Contains(this.o.0O_O0o_..Name))
				{
					string a_ = "BeforeSelChange";
					O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
					{
						cellRangeChangeEventArgs
					}, false, this.o.0O_O0o_..DataTable.Name, false);
					if (!base.Disposing && !base.IsDisposed && !cellRangeChangeEventArgs.Cancel && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.BeforeSelChange)
					{
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
						{
							cellRangeChangeEventArgs
						}, false, "全局表事件", false);
					}
					A_1.Cancel = cellRangeChangeEventArgs.Cancel;
				}
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000275AC File Offset: 0x000257AC
		private void <<EMPTY_NAME>>(object A_0, RangeEventArgs A_1)
		{
			if (OO_00oOO.SystemReady)
			{
				CellRangeChangeEventArgs cellRangeChangeEventArgs = new CellRangeChangeEventArgs(this.o.0O_O0o_., new CellRange(this.o.0O_O0o_., A_1.OldRange), new CellRange(this.o.0O_O0o_., A_1.NewRange));
				string a_ = "BeforeSelRangeChange";
				if (OO_00oOO.Tables.get_Contains(this.o.0O_O0o_..Name))
				{
					O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
					{
						cellRangeChangeEventArgs
					}, false, this.o.0O_O0o_..DataTable.Name, false);
					if (!base.Disposing && !base.IsDisposed && !cellRangeChangeEventArgs.Cancel && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.BeforeSelRangeChange)
					{
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
						{
							cellRangeChangeEventArgs
						}, false, "全局表事件", false);
					}
					A_1.Cancel = cellRangeChangeEventArgs.Cancel;
				}
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000276AE File Offset: 0x000258AE
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			this.o_.OO.(A_1.Row, A_1.Col, null);
			A_1.Cancel = true;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000276CC File Offset: 0x000258CC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataCol dataCol = this.o.0O_O0o_..DataTable.DataCols[base.Cols[base.Col].Name];
			DataRow dataRow = this.o.0O_O0o_..Current.DataRow;
			if (base[base.Row, base.Col] != null && base[base.Row, base.Col] != DBNull.Value)
			{
				string a_ = base[base.Row, base.Col].ToString();
				Oo00.o00O0O_.O.(dataRow, dataCol, dataCol.FTPClient, a_, dataCol.AutoUpdate);
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00027774 File Offset: 0x00025974
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataCol dataCol = this.o.0O_O0o_..DataTable.DataCols[base.Cols[base.Col].Name];
			DataRow dataRow = this.o.0O_O0o_..Current.DataRow;
			if (base[base.Row, base.Col] != null && base[base.Row, base.Col] != DBNull.Value)
			{
				string text = base[base.Row, base.Col].ToString();
				if (!text.StartsWith("[") || !text.EndsWith("]"))
				{
					Oo00.o0_o._O_.(dataRow, dataCol, dataCol.FTPClient, text, dataCol.AutoUpdate);
				}
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00027834 File Offset: 0x00025A34
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataCol dataCol = this.o.0O_O0o_..DataTable.DataCols[base.Cols[base.Col].Name];
			DataRow dataRow = this.o.0O_O0o_..Current.DataRow;
			List<string> list = new List<string>();
			list = Oo00.O____0O._0.(dataRow, dataCol, dataCol.FTPClient, "");
			if (list != null && list.Count > 0)
			{
				string text = list[0];
				int maxLength = dataCol.MaxLength;
				if (maxLength < text.Length && maxLength > 0)
				{
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行\"更改列\"命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.o.0O_O0o_., this.o.0O_O0o_..View.o_o.O0ooOo.().Row, dataCol.Name));
				base[base.Row, base.Col] = text;
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00027920 File Offset: 0x00025B20
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataCol dataCol = this.o.0O_O0o_..DataTable.DataCols[base.Cols[base.Col].Name];
			string text = Oo00.O____0O._0.(this.o.0O_O0o_..Current.DataRow, dataCol, dataCol.FTPClient, "");
			if (Operators.CompareString(text, "", true) > 0)
			{
				int maxLength = dataCol.MaxLength;
				if (maxLength < text.Length && maxLength > 0)
				{
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行\"更改列\"命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.o.0O_O0o_., this.o.0O_O0o_..View.o_o.O0ooOo.().Row, dataCol.Name));
				base[base.Row, base.Col] = text;
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000279FC File Offset: 0x00025BFC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[base.Row].DataIndex).Row, base.Cols[base.Col].Name));
			string dataDisplay = this.GetDataDisplay(base.Row, base.Col);
			if (Operators.CompareString(dataDisplay, "", true) > 0)
			{
				DataRow dataRow = this.o.0O_O0o_..Current.DataRow;
				DataCol a_ = this.o.0O_O0o_..DataTable.DataCols[base.Cols[base.Col].Name];
				if (!Oo00.OO.0O0o.(dataRow, a_, dataDisplay))
				{
					return;
				}
			}
			base[base.Row, base.Col] = DBNull.Value;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00027AE4 File Offset: 0x00025CE4
		internal void <<EMPTY_NAME>>(object A_0, string A_1, RecordGrid A_2)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				C1TextBox c1TextBox = null;
				IL_0B:
				num2 = 3;
				System.Windows.Forms.Control editor = ((C1FlexGrid)A_0).Editor;
				IL_1A:
				num2 = 4;
				this.O__o._oOOoO.++;
				IL_2A:
				num2 = 5;
				if (!(editor is O0o__o0_o0) && !(editor is O0_0_0_Oo_o) && !(editor is o0_o_o_0))
				{
					goto IL_97;
				}
				IL_47:
				num2 = 6;
				c1TextBox = (C1TextBox)editor;
				IL_51:
				num2 = 7;
				if (!((this.O__o._oOOoO. == 1 && c1TextBox.SelectionStart == 0 && c1TextBox.Text.Length >= 1) & !this.o_.o.))
				{
					goto IL_97;
				}
				IL_84:
				num2 = 8;
				c1TextBox.SelectionStart = c1TextBox.Text.Length;
				IL_97:
				num2 = 9;
				if (this.O__o._oOOoO. != 2 || this.o_.o.)
				{
					goto IL_195;
				}
				IL_B1:
				num2 = 10;
				if (c1TextBox == null)
				{
					goto IL_195;
				}
				IL_BA:
				num2 = 11;
				C1TextBox c1TextBox2 = c1TextBox;
				IL_C0:
				num2 = 12;
				if (c1TextBox2.Text.Length <= 1 || c1TextBox2.Text[c1TextBox2.Text.Length - 2] != c1TextBox2.Text[c1TextBox2.Text.Length - 1] || (DateTime.Now - this.o_.o.).TotalSeconds >= 0.05)
				{
					goto IL_192;
				}
				IL_132:
				num2 = 13;
				if (c1TextBox2.Text[c1TextBox2.Text.Length - 1] == ' ')
				{
					goto IL_192;
				}
				IL_153:
				num2 = 14;
				c1TextBox2.Value = c1TextBox2.Text[c1TextBox2.Text.Length - 1];
				IL_17C:
				num2 = 15;
				c1TextBox2.SelectionStart = c1TextBox2.Text.Length;
				IL_192:
				c1TextBox2 = null;
				IL_195:
				num2 = 17;
				if (base.Rows[base.Row].DataIndex == -1)
				{
					goto IL_2AE;
				}
				IL_1B4:
				num2 = 19;
				ChangeEditEventArgs changeEditEventArgs = new ChangeEditEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[base.Row].DataIndex)), this.o.0O_O0o_..Cols[A_1], editor.Text, A_2);
				IL_20E:
				num2 = 20;
				string a_ = "ChangeEdit";
				IL_218:
				num2 = 21;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					changeEditEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				IL_250:
				num2 = 22;
				if (base.Disposing || base.IsDisposed || this.o.0O_O0o_..foxGrid.FindForm() == null || !this.o.0O_O0o_..DataTable.GlobalHandler.ChangeEdit)
				{
					goto IL_2AE;
				}
				IL_28C:
				num2 = 23;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					changeEditEventArgs
				}, false, "全局表事件", false);
				IL_2AE:
				goto IL_360;
				IL_2B3:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_321:
				goto IL_355;
				IL_323:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_333:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_323;
			}
			IL_355:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_360:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00027E78 File Offset: 0x00026078
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), base.Cols[base.Col].Name, null);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00027EA0 File Offset: 0x000260A0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.Row >= 0 && base.Rows[base.Row].DataIndex >= 0 && base.Editor == null && this.MouseRow >= base.Rows.Fixed && this.MouseCol >= base.Cols.Fixed)
			{
				MouseEventArgs mouseEventArgs = (MouseEventArgs)A_1;
				CellClickEventArgs cellClickEventArgs = new CellClickEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[base.Row].DataIndex)), this.o.0O_O0o_..Cols[base.Cols[base.Col].Name], null, mouseEventArgs.Button.ToString());
				string a_ = "Click";
				if (this.o.0O_O0o_..o0__OOo0._oO. == null)
				{
					O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
					{
						cellClickEventArgs
					}, false, this.o.0O_O0o_..DataTable.Name, false);
				}
				else
				{
					O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..o0__OOo0._oO., a_, new object[]
					{
						cellClickEventArgs
					}, false, this.o.0O_O0o_..DataTable.Name, false);
				}
				if (!base.Disposing && !base.IsDisposed && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.Click)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						cellClickEventArgs
					}, false, "全局表事件", false);
				}
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00028057 File Offset: 0x00026257
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0002805C File Offset: 0x0002625C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.SystemReady && base.FindForm() != null && OO_00oOO.CurrentTable != this.o.0O_O0o_.)
			{
				OO_00oOO.CurrentTable = this.o.0O_O0o_.;
				Foxtable.Table table = this.o.0O_O0o_.;
				SystemEventTypeEnum[] array = new SystemEventTypeEnum[3];
				RuntimeHelpers.InitializeArray(array, fieldof(b.o00_.oO_.).FieldHandle);
				OO_00oOO.RaiseSystemEvent(table, array);
				if (OO_00oOO.SystemReady)
				{
					this.o.0O_O0o_..View.o_._0O0o_OoO.();
					this.o.0O_O0o_..View.Oo._Oo0OO.();
				}
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000280D4 File Offset: 0x000262D4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_._. = -1f;
			if (base.FindForm() != null)
			{
				this.O.O00O_oO_OO00.(false);
				if (base.Cols.Count > base.Cols.Fixed)
				{
					this.AutoSizeRows(0, base.Cols.Fixed, base.Rows.Fixed - 1, base.Cols.Fixed, 0, AutoSizeFlags.SameSize);
				}
				try
				{
					foreach (Col col in this.o.0O_O0o_..Cols)
					{
						System.Windows.Forms.Control o_o_O.0000_O. = col.o_o_O.0000_O.;
						if (o_o_O.0000_O. != null && !o_o_O.0000_O..Disposing && !o_o_O.0000_O..IsDisposed && o_o_O.0000_O. is O__o)
						{
							o_o_O.0000_O..Font = (Font)this.Font.Clone();
						}
					}
				}
				finally
				{
					IEnumerator<Col> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (this.o.0O_O0o_..o00oOO00_.ooOo. != null && !this.o.0O_O0o_..o00oOO00_.ooOo..Disposing && !this.o.0O_O0o_..o00oOO00_.ooOo..IsDisposed)
				{
					this.o.0O_O0o_..o00oOO00_.ooOo..Font = (Font)this.Font.Clone();
					this.o.0O_O0o_..o00oOO00_.ooOo..AutoSizeRows(0, 0, this.o.0O_O0o_..o00oOO00_.ooOo..Rows.Count - 1, 0, 0, AutoSizeFlags.SameSize);
					this.o.0O_O0o_..o00oOO00_.ooOo..AutoSizeCol(0, 10);
				}
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0002824C File Offset: 0x0002644C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oo_Oo.0oo__.(RuntimeHelpers.GetObjectValue(A_0), A_1);
			base.Invalidate();
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00028264 File Offset: 0x00026464
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			int num;
			int num10;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				KeyEventArgs keyEventArgs = new KeyEventArgs(this.o.0O_O0o_., A_1.KeyData);
				IL_1B:
				num2 = 3;
				string a_ = "KeyDown";
				IL_24:
				num2 = 4;
				if (!OO_00oOO.SystemReady)
				{
					goto IL_A5;
				}
				IL_2D:
				num2 = 5;
				if (this.o.0O_O0o_..o0__OOo0._oO. != null)
				{
					goto IL_74;
				}
				IL_3C:
				num2 = 6;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					keyEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				goto IL_A5;
				IL_74:
				num2 = 8;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..o0__OOo0._oO., a_, new object[]
				{
					keyEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				IL_A5:
				num2 = 9;
				if (keyEventArgs.Handled)
				{
					goto IL_10D;
				}
				IL_B0:
				num2 = 10;
				if (base.Disposing || base.IsDisposed || this.o.0O_O0o_..foxGrid.FindForm() == null || !this.o.0O_O0o_..DataTable.GlobalHandler.KeyDown)
				{
					goto IL_10D;
				}
				IL_EC:
				num2 = 11;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					keyEventArgs
				}, false, "全局表事件", false);
				IL_10D:
				num2 = 12;
				if (!keyEventArgs.Handled)
				{
					goto IL_136;
				}
				IL_118:
				num2 = 13;
				A_1.Handled = keyEventArgs.Handled;
				IL_127:
				num2 = 14;
				A_1.SuppressKeyPress = true;
				goto IL_6DB;
				IL_136:
				num2 = 16;
				bool flag = true;
				IL_13C:
				num2 = 17;
				bool flag2 = false;
				IL_142:
				num2 = 18;
				int num3 = base.Col + 1;
				int num4 = base.Cols.Count - 1;
				for (int i = num3; i <= num4; i++)
				{
					IL_160:
					num2 = 19;
					if (base.Cols[i].Visible)
					{
						IL_177:
						num2 = 20;
						flag = false;
						break;
					}
					IL_17F:
					num2 = 22;
				}
				IL_18E:
				num2 = 23;
				if (base.Row != base.Rows.Count - 1 && (base.Row != base.Rows.Count - 2 || !this.o.0O_O0o_..GrandTotal))
				{
					goto IL_20E;
				}
				IL_1C8:
				num2 = 24;
				if (this.o.0O_O0o_..IsSubtotal || !this.o.0O_O0o_..AutoAddNew || !this.o.0O_O0o_..AllowAddNew)
				{
					goto IL_20E;
				}
				IL_1F2:
				num2 = 25;
				flag2 = true;
				IL_1F8:
				num2 = 26;
				if (base.KeyActionEnter != KeyActionEnum.MoveAcross || flag)
				{
					goto IL_20E;
				}
				IL_208:
				num2 = 27;
				flag2 = false;
				IL_20E:
				num2 = 28;
				if (A_1.KeyCode != Keys.Tab || !flag2)
				{
					goto IL_245;
				}
				IL_21F:
				num2 = 29;
				A_1.Handled = true;
				IL_229:
				num2 = 30;
				A_1.SuppressKeyPress = true;
				IL_233:
				num2 = 31;
				SendKeys.SendWait("{ENTER}");
				goto IL_6DB;
				IL_245:
				num2 = 33;
				if (A_1.KeyCode != Keys.Return)
				{
					goto IL_2ED;
				}
				IL_255:
				num2 = 34;
				if (base.Editor != null)
				{
					goto IL_6DB;
				}
				IL_263:
				num2 = 35;
				A_1.Handled = true;
				IL_26D:
				num2 = 36;
				A_1.SuppressKeyPress = true;
				IL_277:
				num2 = 37;
				if (!flag2)
				{
					goto IL_2AD;
				}
				IL_27E:
				num2 = 38;
				Foxtable.Syscmd.Row.AddNew();
				IL_286:
				num2 = 39;
				if (base.KeyActionEnter != KeyActionEnum.MoveAcross)
				{
					goto IL_29B;
				}
				IL_292:
				num2 = 40;
				this.O_o.O_O__O.();
				IL_29B:
				num2 = 41;
				SendKeys.SendWait("{F2}");
				goto IL_6DB;
				IL_2AD:
				num2 = 43;
				if (base.KeyActionEnter != KeyActionEnum.MoveDown)
				{
					goto IL_2C8;
				}
				IL_2B9:
				num2 = 44;
				this.o.Ooo_0o_oO.(false);
				goto IL_6DB;
				IL_2C8:
				num2 = 46;
				if (!flag)
				{
					goto IL_2DE;
				}
				IL_2CF:
				num2 = 47;
				this.O_o.O_O__O.(false);
				goto IL_6DB;
				IL_2DE:
				num2 = 49;
				this.OOOo_oO_O.O.(false);
				goto IL_6DB;
				IL_2ED:
				num2 = 51;
				if (base.Row < base.Rows.Fixed)
				{
					goto IL_6DB;
				}
				IL_306:
				num2 = 53;
				if ((!A_1.Control || (A_1.KeyCode != Keys.X && A_1.KeyCode != Keys.C && A_1.KeyCode != Keys.Insert)) && (!A_1.Shift || A_1.KeyCode != Keys.Delete))
				{
					goto IL_34A;
				}
				IL_341:
				num2 = 54;
				this.Oo.O_.();
				IL_34A:
				num2 = 55;
				if (this.o.0O_O0o_..IsSubtotal)
				{
					goto IL_6DB;
				}
				IL_35D:
				num2 = 57;
				if (!this.o.0O_O0o_..GrandTotal)
				{
					goto IL_391;
				}
				IL_36D:
				num2 = 58;
				if (this.Selection.BottomRow == base.Rows.Count - 1)
				{
					goto IL_6DB;
				}
				IL_391:
				num2 = 60;
				if ((!A_1.Control || A_1.KeyCode != Keys.X) && (!A_1.Shift || A_1.KeyCode != Keys.Delete) && A_1.KeyCode != Keys.Delete)
				{
					goto IL_4A7;
				}
				IL_3C5:
				num2 = 61;
				if (this.Selection.LeftCol != this.Selection.RightCol || this.Selection.TopRow != this.Selection.BottomRow)
				{
					goto IL_46C;
				}
				IL_40B:
				num2 = 62;
				this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[base.Row].DataIndex).Row, base.Cols[base.Col].Name));
				goto IL_499;
				IL_46C:
				num2 = 64;
				this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(new oOOOo0oOOOO_(this.o.0O_O0o_., this.Selection));
				IL_490:
				num2 = 65;
				O_O0OO.O0OO_.0. = true;
				IL_499:
				num2 = 66;
				this.oO0O00o0o.O.();
				goto IL_6DB;
				IL_4A7:
				num2 = 68;
				if ((!A_1.Control || A_1.KeyCode != Keys.V) && (!A_1.Shift || A_1.KeyCode != Keys.Insert))
				{
					goto IL_6DB;
				}
				IL_4D4:
				num2 = 69;
				A_1.Handled = true;
				IL_4DE:
				num2 = 70;
				A_1.SuppressKeyPress = true;
				IL_4E8:
				num2 = 71;
				string text = Clipboard.GetText();
				IL_4F2:
				num2 = 72;
				text = text.TrimEnd(new char[]
				{
					'\r',
					'\n'
				});
				IL_50E:
				num2 = 73;
				if (string.IsNullOrEmpty(text))
				{
					goto IL_6DB;
				}
				IL_51D:
				num2 = 75;
				string[] array = text.Split(new char[]
				{
					base.ClipSeparators[1]
				});
				IL_53E:
				num2 = 76;
				int num5 = array.Length;
				IL_547:
				num2 = 77;
				if (array.Length == 0)
				{
					goto IL_6DB;
				}
				IL_553:
				num2 = 79;
				int num6 = array[0].Split(new char[]
				{
					base.ClipSeparators[0]
				}).Length;
				IL_578:
				num2 = 80;
				int num7 = num6;
				IL_57F:
				num2 = 81;
				int leftCol = this.Selection.LeftCol;
				int num8 = base.Cols.Count - 1;
				for (int j = leftCol; j <= num8; j++)
				{
					IL_5A4:
					num2 = 82;
					if (base.Cols[j].Visible)
					{
						IL_5BB:
						num2 = 83;
						num7--;
					}
					else
					{
						IL_5C6:
						num2 = 85;
						num6++;
					}
					IL_5CF:
					num2 = 86;
					if (num7 == 0)
					{
						break;
					}
					IL_5D6:
					num2 = 88;
				}
				IL_5E5:
				num2 = 89;
				if (!(num5 == 1 & num6 == 1))
				{
					goto IL_656;
				}
				IL_5F5:
				num2 = 90;
				this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[base.Row].DataIndex).Row, base.Cols[base.Col].Name));
				goto IL_6D2;
				IL_656:
				num2 = 92;
				base.Select(base.Row, base.Col, Math.Min(base.Row + num5 - 1, base.Rows.Count - 1), Math.Min(base.Col + num6 - 1, base.Cols.Count - 1));
				IL_6A5:
				num2 = 93;
				this.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(new oOOOo0oOOOO_(this.o.0O_O0o_., this.Selection));
				IL_6C9:
				num2 = 94;
				O_O0OO.O0OO_.0. = true;
				IL_6D2:
				num2 = 95;
				this.o0o0__.o.();
				IL_6DB:
				goto IL_8AD;
				IL_6E0:
				int num9 = num10 + 1;
				num10 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9);
				IL_86E:
				goto IL_8A2;
				IL_870:
				num10 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_880:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num10 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_870;
			}
			IL_8A2:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_8AD:
			if (num10 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00028B44 File Offset: 0x00026D44
		internal void <<EMPTY_NAME>>()
		{
			this.oo_OOo0.O___oo. = true;
			string[] array = Clipboard.GetText().TrimEnd(new char[]
			{
				'\r',
				'\n'
			}).Split(new char[]
			{
				base.ClipSeparators[1]
			});
			CellRange selection = this.Selection;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = selection.TopRow + i;
				if (num2 > base.Rows.Count - 1)
				{
					break;
				}
				string[] array2 = array[i].Split(new char[]
				{
					base.ClipSeparators[0]
				});
				int j = selection.LeftCol - 1;
				int num3 = array2.Length - 1;
				int k = 0;
				IL_1B2:
				while (k <= num3)
				{
					j++;
					while (j <= base.Cols.Count - 1)
					{
						if (!base.Cols[j].Visible)
						{
							j++;
						}
						else
						{
							if (!this.o000OOo.OO.(num2, j))
							{
								goto IL_1A4;
							}
							string name = base.Cols[j].Name;
							if (Operators.CompareString(name, "", true) <= 0 || !this.o.0O_O0o_..Cols.Contains(name) || this.o.0O_O0o_..Cols[name].AllowDirectType)
							{
								string text = array2[k];
								text = text.Replace("\r\n", "\n");
								text = text.Replace("\r", "\n");
								text = text.Replace("\n", "\r\n");
								base[num2, j] = text.Trim(new char[]
								{
									' ',
									'\n',
									'\r'
								});
								this.O.O0_0.(num2, j, null);
								goto IL_1A4;
							}
							IL_1AC:
							k++;
							goto IL_1B2;
							IL_1A4:
							if (this.oo_OOo0.O___oo.)
							{
								goto IL_1AC;
							}
							return;
						}
					}
					break;
				}
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00028D1C File Offset: 0x00026F1C
		internal void <<EMPTY_NAME>>()
		{
			CellRange selection = this.Selection;
			this.oo_OOo0.O___oo. = true;
			int topRow = selection.TopRow;
			int bottomRow = selection.BottomRow;
			for (int i = topRow; i <= bottomRow; i++)
			{
				int leftCol = selection.LeftCol;
				int rightCol = selection.RightCol;
				for (int j = leftCol; j <= rightCol; j++)
				{
					if (base.Cols[j].Visible)
					{
						if (this.o000OOo.OO.(i, j))
						{
							base[i, j] = null;
							this.O.O0_0.(i, j, null);
						}
						if (!this.oo_OOo0.O___oo.)
						{
							return;
						}
					}
				}
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00028DAC File Offset: 0x00026FAC
		internal void <<EMPTY_NAME>>()
		{
			if (this.o.0O_O0o_..DataTable.AllowClipBoard)
			{
				char value = base.ClipSeparators[0];
				char value2 = base.ClipSeparators[1];
				StringBuilder stringBuilder = new StringBuilder();
				bool flag;
				if (this.o.0O_O0o_..GridTreeVisible && this.o.0O_O0o_..o.0ooOO_0__. != null)
				{
					flag = true;
				}
				if (this.o.0O_O0o_..DataTable.AllowCopyHeader)
				{
					int leftCol = this.Selection.LeftCol;
					int rightCol = this.Selection.RightCol;
					for (int i = leftCol; i <= rightCol; i++)
					{
						if (base.Cols[i].Visible)
						{
							stringBuilder.Append(base.Cols[i].Name);
							if (i < this.Selection.RightCol)
							{
								stringBuilder.Append(value);
							}
						}
					}
					stringBuilder.Append(value2);
				}
				int topRow = this.Selection.TopRow;
				int bottomRow = this.Selection.BottomRow;
				for (int j = topRow; j <= bottomRow; j++)
				{
					int leftCol2 = this.Selection.LeftCol;
					int rightCol2 = this.Selection.RightCol;
					for (int k = leftCol2; k <= rightCol2; k++)
					{
						if (base.Cols[k].Visible)
						{
							if (base.Rows[j].DataIndex == -1 && !base.Rows[j].IsNode)
							{
								string name = base.Cols[k].Name;
								if (this.o_.o..ContainsKey(name))
								{
									stringBuilder.Append(this.o_.o.[name]);
								}
								else
								{
									stringBuilder.Append("");
								}
							}
							else
							{
								object obj = null;
								if (flag)
								{
									string name2 = base.Cols[k].Name;
									if (this.o.0O_O0o_..o.0ooOO_0__..Contains(name2))
									{
										DataRow key = this.o.0O_O0o_..Rows[base.Rows[j].DataIndex].BaseDataRow;
										Dictionary<string, double> dictionary = null;
										if (this.o.0O_O0o_..o.0ooOO_0__..TryGetValue(key, out dictionary))
										{
											double num = 0.0;
											if (dictionary.TryGetValue(name2, out num))
											{
												obj = num;
											}
										}
									}
								}
								if (obj == null)
								{
									obj = RuntimeHelpers.GetObjectValue(this.GetData(j, k));
								}
								if (obj == null)
								{
									stringBuilder.Append("");
								}
								else
								{
									stringBuilder.Append(obj.ToString().Replace("\r\n", "\n"));
								}
							}
							if (k < this.Selection.RightCol)
							{
								stringBuilder.Append(value);
							}
						}
					}
					if (j < this.Selection.BottomRow)
					{
						stringBuilder.Append(value2);
					}
				}
				if (stringBuilder.Length > 0)
				{
					try
					{
						Clipboard.SetText(stringBuilder.ToString());
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000290DC File Offset: 0x000272DC
		internal string <<EMPTY_NAME>>(CellRange A_0)
		{
			char value = base.ClipSeparators[0];
			char value2 = base.ClipSeparators[1];
			StringBuilder stringBuilder = new StringBuilder();
			int topRow = A_0.TopRow;
			int bottomRow = A_0.BottomRow;
			for (int i = topRow; i <= bottomRow; i++)
			{
				int leftCol = A_0.LeftCol;
				int rightCol = A_0.RightCol;
				for (int j = leftCol; j <= rightCol; j++)
				{
					if (this.GetData(i, j) == null)
					{
						stringBuilder.Append("");
					}
					else
					{
						stringBuilder.Append(this.GetData(i, j).ToString());
					}
					if (j < A_0.RightCol)
					{
						stringBuilder.Append(value);
					}
				}
				if (i < A_0.BottomRow)
				{
					stringBuilder.Append(value2);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000291A6 File Offset: 0x000273A6
		internal void <<EMPTY_NAME>>(object A_0, KeyEditEventArgs A_1, string A_2, System.Windows.Forms.Control A_3, RecordGrid A_4)
		{
			this.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), A_1, A_2, A_3, A_4);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x000291BC File Offset: 0x000273BC
		internal void <<EMPTY_NAME>>(object A_0, KeyEditEventArgs A_1, string A_2, System.Windows.Forms.Control A_3, RecordGrid A_4, bool A_5)
		{
			if (A_1.KeyCode != Keys.ControlKey)
			{
				this.o_.o. = true;
				if (base.Rows[A_1.Row].DataIndex != -1)
				{
					if (A_4 != null)
					{
						if (!(A_4.BaseGrid.Editor is System.Windows.Forms.TextBox))
						{
							return;
						}
					}
					else if (!(base.Editor is System.Windows.Forms.TextBox))
					{
						return;
					}
					KeyEditEventArgs keyEditEventArgs = new KeyEditEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex)), this.o.0O_O0o_..Cols[A_2], A_1.KeyData, A_3, A_4);
					string a_ = "KeyDownEdit";
					O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
					{
						keyEditEventArgs
					}, false, this.o.0O_O0o_..DataTable.Name, false);
					if (!base.Disposing && !base.IsDisposed && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.KeyDownEdit && !keyEditEventArgs.Handled)
					{
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
						{
							keyEditEventArgs
						}, false, "全局表事件", false);
					}
					A_1.Handled = keyEditEventArgs.Handled;
					if (!A_1.Handled)
					{
						bool flag = true;
						int num = base.Col + 1;
						int num2 = base.Cols.Count - 1;
						for (int i = num; i <= num2; i++)
						{
							if (base.Cols[i].Visible)
							{
								flag = false;
								break;
							}
						}
						if (A_1.KeyCode == Keys.Return)
						{
							if ((!flag || A_1.Row != base.Rows.Count - 1) && (base.KeyActionEnter != KeyActionEnum.MoveDown || A_1.Row != base.Rows.Count - 1))
							{
								A_1.Handled = true;
								if (base.Editor is O0_0_0_Oo_o)
								{
									O0_0_0_Oo_o o0_0_0_Oo_o = (O0_0_0_Oo_o)base.Editor;
									if (o0_0_0_Oo_o.AutoCompleteMode == AutoCompleteMode.SuggestAppend && o0_0_0_Oo_o.AutoCompleteSource == AutoCompleteSource.CustomSource)
									{
										base.FinishEditing();
									}
								}
								if (A_1.Modifiers != Keys.Control)
								{
									base.FinishEditing();
								}
								if (base.Editor == null)
								{
									if (base.KeyActionEnter == KeyActionEnum.MoveAcross)
									{
										if (A_5)
										{
											this.OOOo_oO_O.O.(true);
											return;
										}
									}
									else if (A_5)
									{
										this.o.Ooo_0o_oO.(true);
										return;
									}
								}
							}
						}
						else if (A_1.KeyCode == Keys.Tab && (flag || base.KeyActionTab == KeyActionEnum.MoveDown) && A_1.Row == base.Rows.Count - 1)
						{
							base.FinishEditing();
						}
					}
				}
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0002945E File Offset: 0x0002765E
		private void <<EMPTY_NAME>>(object A_0, KeyEditEventArgs A_1)
		{
			this.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), A_1, base.Cols[A_1.Col].Name, base.Editor, null, true);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0002948C File Offset: 0x0002768C
		internal void <<EMPTY_NAME>>(object A_0, KeyPressEditEventArgs A_1, System.Windows.Forms.Control A_2, RecordGrid A_3)
		{
			if (base.Rows[A_1.Row].DataIndex != -1)
			{
				if (A_3 != null)
				{
					if (!(A_3.BaseGrid.Editor is System.Windows.Forms.TextBox))
					{
						return;
					}
				}
				else if (!(base.Editor is System.Windows.Forms.TextBox))
				{
					return;
				}
				KeyPressEditEventArgs keyPressEditEventArgs = new KeyPressEditEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex)), this.o.0O_O0o_..Cols[base.Cols[A_1.Col].Name], A_1.KeyChar, A_2, A_3);
				string a_ = "KeyPressEdit";
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					keyPressEditEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				if (!base.Disposing && !base.IsDisposed && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.KeyPressEdit && !keyPressEditEventArgs.Cancel)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						keyPressEditEventArgs
					}, false, "全局表事件", false);
				}
				A_1.Handled = keyPressEditEventArgs.Cancel;
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000295EC File Offset: 0x000277EC
		private void <<EMPTY_NAME>>(object A_0, KeyPressEditEventArgs A_1)
		{
			this.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), A_1, base.Editor, null);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00029604 File Offset: 0x00027804
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			KeyEventArgs keyEventArgs = new KeyEventArgs(this.o.0O_O0o_., A_1.KeyData);
			string a_ = "KeyUp";
			if (OO_00oOO.SystemReady)
			{
				if (this.o.0O_O0o_..o0__OOo0._oO. == null)
				{
					O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
					{
						keyEventArgs
					}, false, this.o.0O_O0o_..DataTable.Name, false);
				}
				else
				{
					O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..o0__OOo0._oO., a_, new object[]
					{
						keyEventArgs
					}, false, this.o.0O_O0o_..DataTable.Name, false);
				}
			}
			if (!keyEventArgs.Handled && !base.Disposing && !base.IsDisposed && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.KeyUp)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					keyEventArgs
				}, false, "全局表事件", false);
			}
			if (keyEventArgs.Handled)
			{
				A_1.Handled = keyEventArgs.Handled;
				A_1.SuppressKeyPress = true;
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0002971C File Offset: 0x0002791C
		internal void <<EMPTY_NAME>>(object A_0, KeyEditEventArgs A_1, string A_2, System.Windows.Forms.Control A_3, RecordGrid A_4)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (base.Rows[A_1.Row].DataIndex == -1)
				{
					goto IL_167;
				}
				IL_25:
				num2 = 4;
				if (A_4 == null)
				{
					goto IL_45;
				}
				IL_2B:
				num2 = 5;
				if (!(A_4.BaseGrid.Editor is System.Windows.Forms.TextBox))
				{
					goto IL_167;
				}
				goto IL_57;
				IL_45:
				num2 = 8;
				if (!(base.Editor is System.Windows.Forms.TextBox))
				{
					goto IL_167;
				}
				IL_57:
				num2 = 10;
				KeyEditEventArgs keyEditEventArgs = new KeyEditEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex)), this.o.0O_O0o_..Cols[A_2], A_1.KeyData, A_3, A_4);
				IL_B2:
				num2 = 11;
				string a_ = "KeyUpEdit";
				IL_BC:
				num2 = 12;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					keyEditEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				IL_F3:
				num2 = 13;
				if (base.Disposing || base.IsDisposed || this.o.0O_O0o_..foxGrid.FindForm() == null || !this.o.0O_O0o_..DataTable.GlobalHandler.KeyUpEdit || keyEditEventArgs.Handled)
				{
					goto IL_158;
				}
				IL_137:
				num2 = 14;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					keyEditEventArgs
				}, false, "全局表事件", false);
				IL_158:
				num2 = 15;
				A_1.Handled = keyEditEventArgs.Handled;
				IL_167:
				goto IL_1F9;
				IL_16C:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1BA:
				goto IL_1EE;
				IL_1BC:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1CC:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1BC;
			}
			IL_1EE:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1F9:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00029948 File Offset: 0x00027B48
		private void <<EMPTY_NAME>>(object A_0, KeyEditEventArgs A_1)
		{
			this.O._o0O0o0o0.(RuntimeHelpers.GetObjectValue(A_0), A_1, base.Cols[A_1.Col].Name, base.Editor, null);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00029974 File Offset: 0x00027B74
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (A_1.Button != MouseButtons.Right)
				{
					goto IL_298;
				}
				IL_19:
				num2 = 3;
				HitTestInfo hitTestInfo = base.HitTest(A_1.X, A_1.Y);
				IL_2F:
				num2 = 4;
				if (this.o.0O_O0o_..View.Count != 0)
				{
					goto IL_4C;
				}
				IL_43:
				num2 = 5;
				HitTypeEnum hitTypeEnum = HitTypeEnum.Empty;
				goto IL_FA;
				IL_4C:
				num2 = 7;
				if (hitTestInfo.Type != HitTestTypeEnum.ColumnHeader || this.MouseCol < base.Cols.Fixed)
				{
					goto IL_74;
				}
				IL_6B:
				num2 = 8;
				hitTypeEnum = HitTypeEnum.Column;
				goto IL_FA;
				IL_74:
				num2 = 10;
				if (hitTestInfo.Type != HitTestTypeEnum.RowHeader || this.MouseRow < base.Rows.Fixed)
				{
					goto IL_9B;
				}
				IL_94:
				num2 = 11;
				hitTypeEnum = HitTypeEnum.Row;
				goto IL_FA;
				IL_9B:
				num2 = 13;
				if (hitTestInfo.Type != HitTestTypeEnum.None)
				{
					goto IL_AE;
				}
				IL_A7:
				num2 = 14;
				hitTypeEnum = HitTypeEnum.Empty;
				goto IL_FA;
				IL_AE:
				num2 = 16;
				if (!this.Selection.IsSingleCell)
				{
					goto IL_C9;
				}
				IL_C2:
				num2 = 17;
				hitTypeEnum = HitTypeEnum.Cell;
				goto IL_FA;
				IL_C9:
				num2 = 19;
				if (this.MouseRow < base.Rows.Fixed && this.MouseCol < base.Cols.Fixed)
				{
					goto IL_298;
				}
				IL_F5:
				num2 = 21;
				hitTypeEnum = HitTypeEnum.Range;
				IL_FA:
				num2 = 22;
				BeforeShowContextMenuEventArgs beforeShowContextMenuEventArgs = new BeforeShowContextMenuEventArgs(this.o.0O_O0o_., hitTypeEnum);
				IL_10B:
				num2 = 23;
				string a_ = "BeforeShowContextMenu";
				IL_115:
				num2 = 24;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					beforeShowContextMenuEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				IL_14D:
				num2 = 25;
				if (beforeShowContextMenuEventArgs.Cancel || this.o.0O_O0o_..foxGrid.FindForm() == null || !this.o.0O_O0o_..DataTable.GlobalHandler.BeforeShowContextMenu)
				{
					goto IL_1AF;
				}
				IL_182:
				num2 = 26;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					beforeShowContextMenuEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				IL_1AF:
				num2 = 27;
				if (beforeShowContextMenuEventArgs.Cancel)
				{
					goto IL_298;
				}
				IL_1BE:
				num2 = 30;
				if (beforeShowContextMenuEventArgs.ContextMenu == null)
				{
					goto IL_21A;
				}
				IL_1CA:
				num2 = 31;
				Main.OO_O.o..Oo.oOo_o0Oo0.(Main.OO_O.o..o0_o_o_0.0O.(this), new object[]
				{
					beforeShowContextMenuEventArgs.ContextMenu.BaseMenu
				});
				IL_1F7:
				num2 = 32;
				beforeShowContextMenuEventArgs.ContextMenu.Show(this, new Point(A_1.X, A_1.Y));
				goto IL_298;
				IL_21A:
				num2 = 34;
				string name = Enum.GetName(typeof(HitTypeEnum), hitTypeEnum);
				IL_234:
				num2 = 35;
				if (!O_O0OO.o.00O_O.().ContainsKey(name))
				{
					goto IL_298;
				}
				IL_245:
				num2 = 36;
				Main.OO_O.o..Oo.oOo_o0Oo0.(Main.OO_O.o..o0_o_o_0.0O.(this), new object[]
				{
					O_O0OO.o.00O_O.()[name]
				});
				IL_272:
				num2 = 37;
				O_O0OO.o.00O_O.()[name].ShowContextMenu(this, new Point(A_1.X, A_1.Y));
				IL_298:
				goto IL_382;
				IL_29D:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_343:
				goto IL_377;
				IL_345:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_355:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_345;
			}
			IL_377:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_382:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00029D28 File Offset: 0x00027F28
		internal void <<EMPTY_NAME>>(object A_0, OwnerDrawCellEventArgs A_1, bool A_2, bool A_3, ref bool A_4 = false)
		{
			if (!base.Disposing && !base.IsDisposed && base.FindForm() != null && this.o.0O_O0o_. != null)
			{
				string name;
				if (A_1.Style != null)
				{
					name = A_1.Style.Name;
				}
				bool flag = this.Selection.ContainsRow(A_1.Row);
				if (A_1.Col == 0 & A_1.Row == 0)
				{
					if (this.OO_.00oO0Oo.().ShowLockTableIcon && !this.o.0O_O0o_..AllowEdit)
					{
						A_1.Image = O_O0OO.O_O00OOooo.O_.;
						return;
					}
				}
				else if (A_1.Col <= base.Cols.Fixed - 1 || Operators.CompareString(base.Cols[A_1.Col].Name, null, true) != 0)
				{
					if (A_1.Col >= base.Cols.Fixed & A_1.Row < base.Rows.Fixed)
					{
						Image image = null;
						if (this.OO_.00oO0Oo.().ShowLockColumnIcon && !this.o.0O_O0o_..Cols[base.Cols[A_1.Col].Name].AllowEdit)
						{
							image = a.ooO.Oo.().ToBitmap();
						}
						else if (this.OO_.00oO0Oo.().ShowSortIcon && this.o.0O_O0o_..O_O__.ooOo..ContainsKey(base.Cols[A_1.Col].Name.ToLower()))
						{
							if (this.o.0O_O0o_..O_O__.ooOo.[base.Cols[A_1.Col].Name.ToLower()] == ListSortDirection.Ascending)
							{
								A_1.Image = a.o0Oo_0o._00Oo_.().ToBitmap();
							}
							else
							{
								A_1.Image = a.ooO.OooOoOO.().ToBitmap();
							}
						}
						if (image != null)
						{
							if (A_1.Row == base.Rows.Fixed - 1)
							{
								A_1.Image = image;
								return;
							}
							int row = A_1.Row;
							int num = base.Rows.Fixed - 1;
							for (int i = row; i <= num; i++)
							{
								if (Operators.CompareString(this.GetDataDisplay(i, A_1.Col), this.GetDataDisplay(A_1.Row, A_1.Col), true) != 0)
								{
									return;
								}
							}
							A_1.Image = image;
							return;
						}
					}
					else if ((A_1.Col == 0 & this.o.0O_O0o_..View.Count > 0) && A_1.Row >= base.Rows.Fixed)
					{
						MethodInfo methodInfo = this.o.0O_O0o_..DataTable.Ooo.Oo0o0.;
						if (methodInfo == null && this.o.0O_O0o_..DataTable.GlobalHandler.BeforeDrawRow && O_O0OO.O0_00o.o0__o..OO.OOOO. != null)
						{
							methodInfo = O_O0OO.O0_00o.o0__o..OO.OOOO.;
						}
						if (methodInfo != null)
						{
							DrawRowEventArgs drawRowEventArgs;
							if (base.Rows[A_1.Row].DataIndex > -1)
							{
								drawRowEventArgs = new DrawRowEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex)), base.Rows[A_1.Row].Height);
							}
							else
							{
								drawRowEventArgs = new DrawRowEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., A_1.Row - base.Rows.Fixed), base.Rows[A_1.Row].Height);
							}
							try
							{
								methodInfo.Invoke(null, new object[]
								{
									drawRowEventArgs
								});
								if (base.Rows[A_1.Row].Height != drawRowEventArgs.Height)
								{
									base.Rows[A_1.Row].Height = drawRowEventArgs.Height;
									return;
								}
							}
							catch (Exception a_)
							{
								if (methodInfo == O_O0OO.O0_00o.o0__o..OO.OOOO.)
								{
									O_O0OO.O0_00o.o0__o..OO.OOOO. = null;
									ooO.oOo0Oo.o.(a_, "全局表事件,BeforeDrawRow");
								}
								else
								{
									this.o.0O_O0o_..DataTable.Ooo.Oo0o0. = null;
									ooO.oOo0Oo.o.(a_, "表，" + this.o.0O_O0o_..DataTable.Name + "，BeforeDrawRow");
								}
								MessageBox.Show("BeforeDrawRow事件执行错误，在您修正代码之前，将暂停执行该事件代码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							}
						}
						if (base.Rows[A_1.Row].DataIndex > -1)
						{
							if (base.Cols[0].DataType == typeof(bool))
							{
								return;
							}
							DataRowView dataRowView = this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex);
							if (dataRowView == null)
							{
								return;
							}
							DataRow row2 = dataRowView.Row;
							if (row2 != null && (row2.RowState == DataRowState.Deleted || row2.RowState == DataRowState.Detached))
							{
								return;
							}
							if (this.OO_.00oO0Oo.().ShowLineNumber)
							{
								A_1.Text = (base.Rows[A_1.Row].DataIndex + 1).ToString();
								if (row2 == null)
								{
									if (flag)
									{
										A_1.Style = base.Styles["SelectedAddedRowHeader"];
									}
									else
									{
										A_1.Style = base.Styles["AddedRowHeader"];
									}
								}
								else if (row2.IsNull("_Locked") || !Conversions.ToBoolean(row2["_Locked"]))
								{
									DataRowState rowState = row2.RowState;
									if (rowState != DataRowState.Unchanged)
									{
										if (rowState != DataRowState.Added)
										{
											if (rowState == DataRowState.Modified)
											{
												if (flag)
												{
													A_1.Style = base.Styles["SelectedModifiedRowHeader"];
												}
												else
												{
													A_1.Style = base.Styles["ModifiedRowHeader"];
												}
											}
										}
										else if (flag)
										{
											A_1.Style = base.Styles["SelectedAddedRowHeader"];
										}
										else
										{
											A_1.Style = base.Styles["AddedRowHeader"];
										}
									}
									else if (flag)
									{
										A_1.Style = base.Styles["SelectedUnchangedRowHeader"];
									}
									else
									{
										A_1.Style = base.Styles["UnchangedRowHeader"];
									}
								}
								else
								{
									DataRowState rowState2 = row2.RowState;
									if (rowState2 != DataRowState.Unchanged)
									{
										if (rowState2 != DataRowState.Added)
										{
											if (rowState2 == DataRowState.Modified)
											{
												if (flag)
												{
													A_1.Style = base.Styles["SelectedLockedModifiedRowHeader"];
												}
												else
												{
													A_1.Style = base.Styles["LockedModifiedRowHeader"];
												}
											}
										}
										else if (flag)
										{
											A_1.Style = base.Styles["SelectedLockedAddedRowHeader"];
										}
										else
										{
											A_1.Style = base.Styles["LockedAddedRowHeader"];
										}
									}
									else if (flag)
									{
										A_1.Style = base.Styles["SelectedLockedRowHeader"];
									}
									else
									{
										A_1.Style = base.Styles["LockedRowHeader"];
									}
								}
							}
							else if (this.OO_.00oO0Oo.().ShowLockRowIcon && !row2.IsNull("_Locked") && Conversions.ToBoolean(row2["_Locked"]))
							{
								A_1.Image = O_O0OO.o.0__0_O_.;
							}
						}
						if (base.Rows[A_1.Row].DataIndex == -1 && !base.Rows[A_1.Row].IsNode)
						{
							A_1.Style = base.Styles["GrandTotalRowHeader"];
							return;
						}
					}
					else if (A_1.Col >= base.Cols.Fixed && A_1.Row >= base.Rows.Fixed && base.Rows[A_1.Row].DataIndex == -1 && !base.Rows[A_1.Row].IsNode)
					{
						A_1.Style = base.Styles[CellStyleEnum.GrandTotal];
						string columnName = this.o.0O_O0o_..View.o_o.O0ooOo.().Columns[base.Cols[A_1.Col].Name].ColumnName;
						if (base.Cols.Fixed == A_1.Col)
						{
							A_1.Text = "合计";
							if (A_1.Image != null)
							{
								A_1.Image = null;
							}
						}
						else
						{
							Col col = this.o.0O_O0o_..Cols[columnName];
							if (col.IsNumeric() && col.GrandTotal)
							{
								double num2 = base.Aggregate(AggregateEnum.Sum, base.Rows.Fixed, A_1.Col, base.Rows.Count - 1, A_1.Col, AggregateFlags.ExcludeNodes);
								num2 = Math.Round(num2, col.DataCol.Decimals);
								string text = "";
								if (base.Cols[A_1.Col].DataType == typeof(double) && this.o.0O_O0o_..Cols[columnName].DataCol.ExtendColumnType == ExtendColumnTypeEnum.时段)
								{
									O_O0OO.o.00O_O.(num2, ref text);
								}
								else if (Operators.CompareString(base.Cols[A_1.Col].Format, "", true) > 0)
								{
									text = Strings.Format(num2, base.Cols[A_1.Col].Format);
								}
								else
								{
									text = num2.ToString();
								}
								A_1.Text = text;
							}
						}
						if (this.o_.o..ContainsKey(columnName))
						{
							this.o_.o.[columnName] = A_1.Text;
							return;
						}
						this.o_.o..Add(columnName, A_1.Text);
						return;
					}
					else if (A_1.Col >= base.Cols.Fixed && A_1.Row >= base.Rows.Fixed)
					{
						string columnName2 = this.o.0O_O0o_..View.o_o.O0ooOo.().Columns[base.Cols[A_1.Col].Name].ColumnName;
						if (base.Cols[A_1.Col].DataType == typeof(double) && this.o.0O_O0o_..Cols[columnName2].DataCol.ExtendColumnType == ExtendColumnTypeEnum.时段 && base[A_1.Row, A_1.Col] != null && base[A_1.Row, A_1.Col] != DBNull.Value)
						{
							double a_2 = Conversions.ToDouble(base[A_1.Row, A_1.Col]);
							string text2 = "";
							if (O_O0OO.o.00O_O.(a_2, ref text2))
							{
								A_1.Text = text2;
							}
						}
						if (base.Rows[A_1.Row].DataIndex > -1)
						{
							if (base.Cols[A_1.Col].DataType == typeof(int) && this.o.0O_O0o_..Cols[columnName2].DataCol.ExtendColumnType == ExtendColumnTypeEnum.色彩)
							{
								Rectangle bounds = A_1.Bounds;
								if (this.Selection.Contains(A_1.Row, A_1.Col))
								{
									bounds = new Rectangle(bounds.X + 1, bounds.Y + 1, bounds.Width - 4, bounds.Height - 4);
									A_1.Graphics.DrawRectangle(Pens.Gray, bounds);
									bounds = new Rectangle(bounds.X + 2, bounds.Y + 2, bounds.Width - 3, bounds.Height - 3);
								}
								else
								{
									bounds = new Rectangle(bounds.X + 2, bounds.Y + 2, bounds.Width - 5, bounds.Height - 5);
								}
								if (base[A_1.Row, A_1.Col] != null && base[A_1.Row, A_1.Col] != DBNull.Value)
								{
									A_1.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(Conversions.ToInteger(base[A_1.Row, A_1.Col]))), bounds);
								}
								if (!A_3)
								{
									A_1.DrawCell(DrawCellFlags.Border);
								}
								else
								{
									A_1.Text = " ";
								}
								A_1.Handled = true;
							}
							if (OO_00oOO.MarkModifedCell && !A_1.Handled && base.Rows[A_1.Row].DataIndex > -1)
							{
								DataRow row3 = this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex).Row;
								if (row3.RowState == DataRowState.Modified && string.Compare(row3[columnName2].ToString(), row3[columnName2, DataRowVersion.Original].ToString(), false) != 0)
								{
									A_1.Style = base.Styles["ModifiedCell"];
								}
							}
							if ((this.o.0O_O0o_..ListMode & !A_1.Handled) && A_1.Row == base.Row && base.Rows[A_1.Row].DataIndex > -1 && !this.Selection.Contains(A_1.Row, A_1.Col))
							{
								A_1.Style = base.Styles["CurrentRow"];
							}
							if (base.Rows[A_1.Row].DataIndex > -1 && A_1.Col >= base.Cols.Fixed && this.o.0O_O0o_..HierarchyData && this.o.0O_O0o_..o.0ooOO_0__. != null)
							{
								DataRow row4 = this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex).Row;
								Dictionary<string, double> dictionary = null;
								double num3;
								if (this.o.0O_O0o_..o.0ooOO_0__..TryGetValue(row4, out dictionary) && dictionary.TryGetValue(columnName2, out num3))
								{
									if (Operators.CompareString(base.Cols[A_1.Col].Format, "", true) > 0)
									{
										A_1.Text = Strings.Format(num3, base.Cols[A_1.Col].Format);
									}
									else
									{
										A_1.Text = num3.ToString();
									}
								}
							}
						}
						if (O_O0OO.O0_00o.o0__o..OO_O00O.O_.(O_O0OO.O0_00o.o0__o.) && !A_1.Handled && A_2)
						{
							MethodInfo methodInfo2 = this.o.0O_O0o_..DataTable.OO00.oO_.;
							if (methodInfo2 == null && this.o.0O_O0o_..DataTable.GlobalHandler.DrawCell && O_O0OO.O0_00o.o0__o..oO0o_.__O0. != null)
							{
								methodInfo2 = O_O0OO.O0_00o.o0__o..oO0o_.__O0.;
							}
							if (methodInfo2 != null)
							{
								DrawCellEventArgs drawCellEventArgs;
								if (base.Rows[A_1.Row].DataIndex > -1)
								{
									drawCellEventArgs = new DrawCellEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex)), this.o.0O_O0o_..Cols[base.Cols[A_1.Col].Name], A_1, this, A_3);
								}
								else
								{
									drawCellEventArgs = new DrawCellEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., A_1.Row - base.Rows.Fixed), this.o.0O_O0o_..Cols[base.Cols[A_1.Col].Name], A_1, this, A_3);
								}
								A_4 = drawCellEventArgs.O0O__O._0.;
								try
								{
									methodInfo2.Invoke(null, new object[]
									{
										drawCellEventArgs
									});
									if (!A_1.Handled && Operators.CompareString(drawCellEventArgs.Style, "", true) > 0 && base.Styles.Contains("User" + drawCellEventArgs.Style))
									{
										if (this.Selection.ContainsRow(A_1.Row) && this.Selection.ContainsCol(A_1.Col) && !this.Selection.IsSingleCell)
										{
											if (!base.Styles.Contains("^^User" + drawCellEventArgs.Style))
											{
												base.Styles.Add("^^User" + drawCellEventArgs.Style).MergeWith(base.Styles["User" + drawCellEventArgs.Style]);
											}
											CellStyle cellStyle = base.Styles["^^User" + drawCellEventArgs.Style];
											Color color = base.Styles["User" + drawCellEventArgs.Style].BackColor;
											Color color2 = base.Styles.Highlight.BackColor;
											Color color3 = Color.FromArgb((int)Math.Round(((double)color.R * 0.7 + (double)color2.R) / 2.0), (int)Math.Round(((double)color.G * 0.7 + (double)color2.G) / 2.0), (int)Math.Round(((double)color.B * 0.7 + (double)color2.B) / 2.0));
											if (cellStyle.BackColor != color3)
											{
												cellStyle.BackColor = color3;
											}
											color = base.Styles["User" + drawCellEventArgs.Style].ForeColor;
											color2 = base.Styles.Highlight.ForeColor;
											color3 = Color.FromArgb((int)Math.Round(((double)color.R * 0.7 + (double)color2.R) / 2.0), (int)Math.Round(((double)color.G * 0.7 + (double)color2.G) / 2.0), (int)Math.Round(((double)color.B * 0.7 + (double)color2.B) / 2.0));
											if (cellStyle.ForeColor != color3)
											{
												cellStyle.ForeColor = color3;
											}
											A_1.Style = cellStyle;
										}
										else
										{
											A_1.Style = base.Styles["User" + drawCellEventArgs.Style];
										}
									}
								}
								catch (Exception a_3)
								{
									if (methodInfo2 == O_O0OO.O0_00o.o0__o..oO0o_.__O0.)
									{
										O_O0OO.O0_00o.o0__o..oO0o_.__O0. = null;
										ooO.oOo0Oo.o.(a_3, "全局表事件,DrawCell");
									}
									else
									{
										this.o.0O_O0o_..DataTable.OO00.oO_. = null;
										ooO.oOo0Oo.o.(a_3, "表，" + this.o.0O_O0o_..DataTable.Name + "，DrawCell");
									}
									MessageBox.Show("DrawCell事件执行错误，在您修正代码之前，将暂停执行该事件代码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								}
							}
						}
						if (base.Rows[A_1.Row].DataIndex > -1)
						{
							if (this.o.0O_O0o_..GridTreeVisible && A_1.Col >= base.Cols.Fixed && Operators.CompareString(name, A_1.Style.Name, true) == 0 && this.o.0O_O0o_..oO._o.)
							{
								int dataIndex = base.Rows[A_1.Row].DataIndex;
								Foxtable.Row row5 = this.o.0O_O0o_..Rows[dataIndex];
								if (row5.HasChild)
								{
									int hierarchy = row5.Hierarchy;
									int index = 14 + hierarchy % 6;
									CellStyle style = base.Styles[(CellStyleEnum)index];
									if (!this.Selection.ContainsRow(A_1.Row) || !this.Selection.ContainsCol(A_1.Col) || this.Selection.IsSingleCell)
									{
										A_1.Style = style;
									}
								}
							}
							if (A_1.Col >= base.Cols.Fixed && this.o.0O_O0o_..HierarchyData && Operators.CompareString(base.Cols[A_1.Col].Name, this.o.0O_O0o_..OO0o_o0.0oOo0o., true) == 0)
							{
								int dataIndex2 = base.Rows[A_1.Row].DataIndex;
								DataRowView dataRowView2 = this.o.0O_O0o_..View.O0O_0_0__.0O.(dataIndex2);
								DataRowView dataRowView3 = null;
								if (dataIndex2 < this.o.0O_O0o_..View.Count - 1)
								{
									dataRowView3 = this.o.0O_O0o_..View.O0O_0_0__.0O.(dataIndex2 + 1);
								}
								if (!dataRowView2.Row.IsNull("sys_Hierarchy_Level"))
								{
									int num4 = Conversions.ToInteger(dataRowView2["sys_Hierarchy_Level"]);
									bool flag2 = this.GetUserData(A_1.Row, base.Cols.Fixed - 1) == null;
									A_1.Text = new string('\u3000', num4 + 1) + " " + A_1.Text;
									if (dataRowView3 != null && !dataRowView3.Row.IsNull("sys_Hierarchy_Level") && num4 < Conversions.ToInteger(dataRowView3["sys_Hierarchy_Level"]))
									{
										Image image2;
										if (flag2)
										{
											image2 = base.Glyphs[GlyphEnum.Expanded];
										}
										else
										{
											image2 = base.Glyphs[GlyphEnum.Collapsed];
										}
										A_1.DrawCell(DrawCellFlags.All);
										int num5 = (int)Math.Ceiling((double)(this.OO_.00oO0Oo.(A_1) * (float)(num4 + 1)) - (double)image2.Width * 1.5) + 4;
										A_1.Graphics.DrawImageUnscaled(image2, A_1.Bounds.X + num5, (int)Math.Round((double)A_1.Bounds.Y + (double)(A_1.Bounds.Height - image2.Height) / 2.0));
										A_1.Handled = true;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0002B3B0 File Offset: 0x000295B0
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (OO_00oOO.SystemReady && this.Focused && A_1.Row <= base.Rows.Count - 1 && A_1.Col <= base.Cols.Count - 1)
			{
				C1.Win.C1FlexGrid.Row row = base.Rows[A_1.Row];
				C1.Win.C1FlexGrid.Column column = base.Cols[A_1.Col];
				if (row.DataIndex >= 0)
				{
					base.Invalidate(A_1.Row, A_1.Col);
					if ((this.o.0O_O0o_..DataTable.o_0.0O0o__0. != null || O_O0OO.O0_00o.o0__o..oO00_.0. != null) && base.Editor == null && A_1.Row >= base.Rows.Fixed && A_1.Col >= base.Cols.Fixed)
					{
						MethodInfo methodInfo = this.o.0O_O0o_..DataTable.o_0.0O0o__0.;
						RowColEventArgs rowColEventArgs = new RowColEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(row.DataIndex)), this.o.0O_O0o_..Cols[column.Name], null);
						if (methodInfo != null)
						{
							try
							{
								methodInfo.Invoke(null, new object[]
								{
									rowColEventArgs
								});
							}
							catch (Exception a_)
							{
								ooO.oOo0Oo.o.(a_, "表，" + base.Name + "，MouseEnterCell");
							}
						}
						if (this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.MouseEnterCell)
						{
							methodInfo = O_O0OO.O0_00o.o0__o..oO00_.0.;
							if (methodInfo != null)
							{
								try
								{
									methodInfo.Invoke(null, new object[]
									{
										rowColEventArgs
									});
								}
								catch (Exception a_2)
								{
									ooO.oOo0Oo.o.(a_2, "全局事件, MouseEnterCell");
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0002B5B8 File Offset: 0x000297B8
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (OO_00oOO.SystemReady && !O_O0OO.o0OoO00OO.00O. && this.Focused && A_1.Row <= base.Rows.Count - 1 && A_1.Col <= base.Cols.Count - 1)
			{
				C1.Win.C1FlexGrid.Row row = base.Rows[A_1.Row];
				C1.Win.C1FlexGrid.Column column = base.Cols[A_1.Col];
				if (row.DataIndex >= 0)
				{
					base.Invalidate(A_1.Row, A_1.Col);
					if ((this.o.0O_O0o_..DataTable.Oo0O0.0. != null || O_O0OO.O0_00o.o0__o..O0OO.OoOOoo_. != null) && base.Editor == null && A_1.Row >= base.Rows.Fixed && A_1.Col >= base.Cols.Fixed)
					{
						MethodInfo methodInfo = this.o.0O_O0o_..DataTable.Oo0O0.0.;
						RowColEventArgs rowColEventArgs = new RowColEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(row.DataIndex)), this.o.0O_O0o_..Cols[column.Name], null);
						if (methodInfo != null)
						{
							try
							{
								methodInfo.Invoke(null, new object[]
								{
									rowColEventArgs
								});
							}
							catch (Exception a_)
							{
								ooO.oOo0Oo.o.(a_, "表，" + base.Name + "，MouseLeaveCell");
							}
						}
						if (this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.MouseLeaveCell)
						{
							methodInfo = O_O0OO.O0_00o.o0__o..O0OO.OoOOoo_.;
							if (methodInfo != null)
							{
								try
								{
									methodInfo.Invoke(null, new object[]
									{
										rowColEventArgs
									});
								}
								catch (Exception a_2)
								{
									ooO.oOo0Oo.o.(a_2, "全局事件, MouseLeaveCell");
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0002B7C8 File Offset: 0x000299C8
		private void <<EMPTY_NAME>>(object A_0, OwnerDrawCellEventArgs A_1)
		{
			if (OO_00oOO.SystemReady)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(A_0);
				bool a_ = true;
				bool a_2 = false;
				bool flag = false;
				this.OO_.00oO0Oo.(objectValue, A_1, a_, a_2, ref flag);
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0002B7EF File Offset: 0x000299EF
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!base.Disposing && !base.IsDisposed && base.FindForm() != null)
			{
				this.O.O00O_oO_OO00.(false);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0002B810 File Offset: 0x00029A10
		internal void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1, RecordGrid A_2)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (A_0 != this || (A_1.Row == base.Row && A_1.Col == base.Col))
				{
					goto IL_37;
				}
				IL_29:
				num2 = 3;
				base.FinishEditing();
				goto IL_2FF;
				IL_37:
				num2 = 5;
				System.Windows.Forms.Control editor = ((C1FlexGrid)A_0).Editor;
				IL_45:
				num2 = 6;
				if (base.Rows[A_1.Row].DataIndex == -1)
				{
					goto IL_2FF;
				}
				IL_63:
				num2 = 8;
				if (!(editor is O0o__o0_o0))
				{
					goto IL_F6;
				}
				IL_70:
				num2 = 9;
				O0o__o0_o0 o0o__o0_o = (O0o__o0_o0)editor;
				IL_7B:
				num2 = 10;
				o0o__o0_o.DataType = base.Cols[A_1.Col].DataType;
				IL_9B:
				num2 = 11;
				o0o__o0_o.EditMask = base.Cols[A_1.Col].EditMask;
				IL_BB:
				num2 = 12;
				o0o__o0_o.CustomFormat = "";
				IL_CA:
				num2 = 13;
				o0o__o0_o.EditFormat.FormatType = FormatTypeEnum.CustomFormat;
				IL_DA:
				num2 = 14;
				o0o__o0_o.EditFormat.CustomFormat = "";
				IL_EE:
				o0o__o0_o = null;
				goto IL_254;
				IL_F6:
				num2 = 17;
				if (!(editor is OO__oo_0ooo0_))
				{
					goto IL_18A;
				}
				IL_104:
				num2 = 18;
				OO__oo_0ooo0_ oo__oo_0ooo0_ = (OO__oo_0ooo0_)editor;
				IL_10F:
				num2 = 19;
				oo__oo_0ooo0_.DataType = base.Cols[A_1.Col].DataType;
				IL_12F:
				num2 = 20;
				oo__oo_0ooo0_.EditMask = base.Cols[A_1.Col].EditMask;
				IL_14F:
				num2 = 21;
				oo__oo_0ooo0_.CustomFormat = "";
				IL_15E:
				num2 = 22;
				oo__oo_0ooo0_.EditFormat.FormatType = FormatTypeEnum.CustomFormat;
				IL_16E:
				num2 = 23;
				oo__oo_0ooo0_.EditFormat.CustomFormat = "";
				IL_182:
				oo__oo_0ooo0_ = null;
				goto IL_254;
				IL_18A:
				num2 = 26;
				if (!(editor is O0_0_0_Oo_o))
				{
					goto IL_21B;
				}
				IL_198:
				num2 = 27;
				O0_0_0_Oo_o o0_0_0_Oo_o = (O0_0_0_Oo_o)editor;
				IL_1A3:
				num2 = 28;
				o0_0_0_Oo_o.DataType = base.Cols[A_1.Col].DataType;
				IL_1C3:
				num2 = 29;
				o0_0_0_Oo_o.EditMask = base.Cols[A_1.Col].EditMask;
				IL_1E3:
				num2 = 30;
				o0_0_0_Oo_o.CustomFormat = "";
				IL_1F2:
				num2 = 31;
				o0_0_0_Oo_o.EditFormat.FormatType = FormatTypeEnum.CustomFormat;
				IL_202:
				num2 = 32;
				o0_0_0_Oo_o.EditFormat.CustomFormat = "";
				IL_216:
				o0_0_0_Oo_o = null;
				goto IL_254;
				IL_21B:
				num2 = 35;
				if (editor is o0_o_o_0)
				{
					goto IL_254;
				}
				IL_226:
				num2 = 37;
				if (!(editor is BuildInDropTree))
				{
					goto IL_254;
				}
				IL_231:
				num2 = 38;
				BuildInDropTree buildInDropTree = (BuildInDropTree)editor;
				IL_23C:
				num2 = 39;
				buildInDropTree.Row = this.o.0O_O0o_..Current;
				IL_251:
				buildInDropTree = null;
				IL_254:
				num2 = 41;
				SetupEditorEventArgs setupEditorEventArgs = new SetupEditorEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex)), this.o.0O_O0o_..Cols[base.Cols[A_1.Col].Name], editor, A_2);
				IL_2BD:
				num2 = 42;
				string a_ = "SetupEditor";
				IL_2C7:
				num2 = 43;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					setupEditorEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				IL_2FF:
				goto IL_401;
				IL_304:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_3C2:
				goto IL_3F6;
				IL_3C4:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_3D4:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3C4;
			}
			IL_3F6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_401:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002BC44 File Offset: 0x00029E44
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (base.Editor is Oooo)
			{
				((Oooo)base.Editor).DataType = typeof(string);
			}
			this.OO0o_o_OO.O_O.(RuntimeHelpers.GetObjectValue(A_0), A_1, null);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0002BC80 File Offset: 0x00029E80
		internal void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1, RecordGrid A_2)
		{
			this.oo_OOo0.O___oo. = true;
			if (A_1.Col == 0 && A_0 == this)
			{
				if (!this.Selection.ContainsRow(A_1.Row))
				{
					base.Row = A_1.Row;
				}
				int topRow = this.Selection.TopRow;
				int bottomRow = this.Selection.BottomRow;
				for (int i = topRow; i <= bottomRow; i++)
				{
					int dataIndex = base.Rows[i].DataIndex;
					if (dataIndex >= 0)
					{
						Foxtable.Row row = this.o.0O_O0o_..Rows[dataIndex];
						row.Checked = !row.Checked;
					}
				}
				A_1.Cancel = true;
				return;
			}
			this.O__o._oOOoO. = 0;
			this.o_.o. = false;
			this.o_.o. = DateTime.Now;
			int dataIndex2 = base.Rows[A_1.Row].DataIndex;
			DataRow row2 = this.o.0O_O0o_..View.O0O_0_0__.0O.(dataIndex2).Row;
			RowColEventArgs rowColEventArgs = new RowColEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(dataIndex2)), this.o.0O_O0o_..Cols[base.Cols[A_1.Col].Name], A_2);
			if (A_0 != this)
			{
				rowColEventArgs.IsFocusCell = true;
			}
			else
			{
				rowColEventArgs.IsFocusCell = (A_1.Row == base.Row && base.Col == A_1.Col);
			}
			MethodInfo methodInfo = this.o.0O_O0o_..DataTable.Oo_.O_.;
			if (methodInfo != null && OO_00oOO.SystemReady)
			{
				try
				{
					methodInfo.Invoke(null, new object[]
					{
						rowColEventArgs
					});
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "表，" + this.o.0O_O0o_..DataTable.Name + "，StartEdit");
				}
			}
			if (!rowColEventArgs.Cancel && this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.StartEdit && OO_00oOO.SystemReady)
			{
				methodInfo = O_O0OO.O0_00o.o0__o..oo_00_0._.;
				if (methodInfo != null)
				{
					try
					{
						methodInfo.Invoke(null, new object[]
						{
							rowColEventArgs
						});
					}
					catch (Exception a_2)
					{
						ooO.oOo0Oo.o.(a_2, "全局表事件，StartEdit");
					}
				}
			}
			A_1.Cancel = rowColEventArgs.Cancel;
			this.oo_OOo0.O___oo. = rowColEventArgs.Continue;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0002BF18 File Offset: 0x0002A118
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (this.O_._. == BooleanEnum.Default)
			{
				this.OOOo_oO_O.O.(RuntimeHelpers.GetObjectValue(A_0), A_1, null);
				return;
			}
			if (this.O_._. == BooleanEnum.False)
			{
				A_1.Cancel = true;
			}
			this.O_._. = BooleanEnum.Default;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0002BF48 File Offset: 0x0002A148
		internal void <<EMPTY_NAME>>(object A_0, ValidateEditEventArgs A_1, RecordGrid A_2)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				C1FlexGrid c1FlexGrid = (C1FlexGrid)A_0;
				IL_10:
				num2 = 3;
				System.Windows.Forms.Control editor = ((C1FlexGrid)A_0).Editor;
				IL_1E:
				num2 = 4;
				if (A_1.Col == 0)
				{
					goto IL_691;
				}
				IL_2B:
				num2 = 6;
				this.o_.o. = null;
				IL_34:
				num2 = 7;
				if (base.Rows[A_1.Row].DataIndex == -1)
				{
					goto IL_691;
				}
				IL_52:
				num2 = 9;
				if (!OO_00oOO.Tables.get_Contains(this.o.0O_O0o_..Name))
				{
					goto IL_691;
				}
				IL_6F:
				num2 = 11;
				Col col = this.o.0O_O0o_..Cols[base.Cols[A_1.Col].Name];
				IL_9A:
				num2 = 12;
				if (col.CodeDictonary == null || !(editor is C1TextBox) || Operators.CompareString(editor.Text, "", true) <= 0)
				{
					goto IL_F9;
				}
				IL_C2:
				num2 = 13;
				if (!col.CodeDictonary.ContainsKey(editor.Text))
				{
					goto IL_F9;
				}
				IL_D9:
				num2 = 14;
				((C1TextBox)editor).Value = col.CodeDictonary[editor.Text];
				IL_F9:
				num2 = 15;
				if (!(editor is C1TextBox))
				{
					goto IL_194;
				}
				IL_107:
				num2 = 16;
				C1TextBox c1TextBox = (C1TextBox)editor;
				IL_112:
				num2 = 17;
				C1TextBox c1TextBox2 = c1TextBox;
				object text = c1TextBox.Text;
				if (c1TextBox2.ParseContent(out text, c1TextBox.ErrorInfo) != ErrorReasonEnum.NoErrors)
				{
					goto IL_17D;
				}
				IL_130:
				num2 = 18;
				ValidateEditEventArgs validateEditEventArgs = new ValidateEditEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex)), col, c1TextBox.Text, A_2);
				IL_18C:
				c1TextBox = null;
				goto IL_287;
				IL_17D:
				num2 = 20;
				A_1.Cancel = true;
				goto IL_691;
				IL_194:
				num2 = 24;
				if (!(editor is System.Windows.Forms.TextBox) && !(editor is System.Windows.Forms.ComboBox))
				{
					goto IL_1F6;
				}
				IL_1A7:
				num2 = 25;
				validateEditEventArgs = new ValidateEditEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex)), col, editor.Text, A_2);
				goto IL_287;
				IL_1F6:
				num2 = 27;
				if (editor != null || base.Cols[A_1.Col].DataType != typeof(bool))
				{
					goto IL_691;
				}
				IL_224:
				num2 = 28;
				validateEditEventArgs = new ValidateEditEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex)), col, Interaction.IIf(A_1.Checkbox == CheckEnum.Checked, true, false).ToString(), A_2);
				IL_287:
				num2 = 31;
				if (Operators.CompareString(validateEditEventArgs.Text, "", true) <= 0 || Operators.CompareString(validateEditEventArgs.Text, this.GetData(A_1.Row, A_1.Col).ToString(), true) == 0)
				{
					goto IL_443;
				}
				IL_2CB:
				num2 = 32;
				DataCol dataCol = this.o.0O_O0o_..Cols[base.Cols[A_1.Col].Name].DataCol;
				IL_2FB:
				num2 = 33;
				if (!dataCol.Unique)
				{
					goto IL_443;
				}
				IL_30A:
				num2 = 34;
				string text2 = "";
				IL_314:
				num2 = 35;
				if (!dataCol.IsString)
				{
					goto IL_35E;
				}
				IL_320:
				num2 = 36;
				text2 = string.Concat(new string[]
				{
					"[",
					dataCol.Name,
					"] = '",
					validateEditEventArgs.Text,
					"'"
				});
				goto IL_3D6;
				IL_35E:
				num2 = 38;
				if (!dataCol.IsDate)
				{
					goto IL_3A8;
				}
				IL_36A:
				num2 = 39;
				text2 = string.Concat(new string[]
				{
					"[",
					dataCol.Name,
					"] = #",
					validateEditEventArgs.Text,
					"#"
				});
				goto IL_3D6;
				IL_3A8:
				num2 = 41;
				if (!dataCol.IsNumeric)
				{
					goto IL_3D6;
				}
				IL_3B4:
				num2 = 42;
				text2 = "[" + dataCol.Name + "] = " + validateEditEventArgs.Text;
				IL_3D6:
				num2 = 43;
				if (Operators.CompareString(text2, "", true) <= 0)
				{
					goto IL_443;
				}
				IL_3E9:
				num2 = 44;
				if (this.o.0O_O0o_..DataTable.BaseTable.Select(text2).Length <= 0)
				{
					goto IL_443;
				}
				IL_408:
				num2 = 45;
				MessageBox.Show(dataCol.Name + "禁止重复，您输入的值已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_42A:
				num2 = 46;
				editor.Focus();
				IL_434:
				num2 = 47;
				A_1.Cancel = true;
				goto IL_691;
				IL_443:
				num2 = 49;
				if (string.Compare(validateEditEventArgs.Text, this.GetData(A_1.Row, A_1.Col).ToString(), false) == 0)
				{
					goto IL_4C1;
				}
				IL_46C:
				num2 = 50;
				this.o_.o. = new o0o0o00(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[A_1.Row].DataIndex).Row, base.Cols[A_1.Col].Name);
				IL_4C1:
				num2 = 51;
				if (editor == null)
				{
					goto IL_691;
				}
				IL_4CA:
				num2 = 53;
				string a_ = "ValidateEdit";
				IL_4D4:
				num2 = 54;
				O_O0OO.OoO_o.oO0o0O.(this.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					validateEditEventArgs
				}, false, this.o.0O_O0o_..DataTable.Name, false);
				IL_50C:
				num2 = 55;
				if (base.Disposing || base.IsDisposed || validateEditEventArgs.Cancel || this.o.0O_O0o_..foxGrid.FindForm() == null || !this.o.0O_O0o_..DataTable.GlobalHandler.ValidateEdit)
				{
					goto IL_573;
				}
				IL_551:
				num2 = 56;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					validateEditEventArgs
				}, false, "全局表事件", false);
				IL_573:
				num2 = 57;
				A_1.Cancel = validateEditEventArgs.Cancel;
				IL_583:
				num2 = 58;
				if (A_1.Cancel)
				{
					goto IL_67C;
				}
				IL_591:
				num2 = 59;
				if (Operators.CompareString(validateEditEventArgs.Text, "", true) <= 0)
				{
					goto IL_5CA;
				}
				IL_5A9:
				num2 = 60;
				validateEditEventArgs.Text = validateEditEventArgs.Text.TrimEnd(new char[]
				{
					' '
				});
				IL_5CA:
				num2 = 61;
				if (editor is Oooo)
				{
					goto IL_691;
				}
				IL_5D8:
				num2 = 63;
				if (!(editor is C1TextBox))
				{
					goto IL_648;
				}
				IL_5E3:
				num2 = 64;
				C1TextBox c1TextBox3 = (C1TextBox)editor;
				IL_5EE:
				num2 = 65;
				if (Operators.CompareString(validateEditEventArgs.Text, "", true) > 0)
				{
					C1TextBox c1TextBox4 = c1TextBox3;
					text = validateEditEventArgs.Text;
					if (c1TextBox4.ParseContent(out text, c1TextBox3.ErrorInfo) != ErrorReasonEnum.NoErrors)
					{
						goto IL_634;
					}
					IL_621:
					num2 = 66;
					c1TextBox3.Value = validateEditEventArgs.Text;
					goto IL_643;
				}
				IL_634:
				num2 = 68;
				c1TextBox3.Value = DBNull.Value;
				IL_643:
				c1TextBox3 = null;
				goto IL_691;
				IL_648:
				num2 = 71;
				if (Operators.CompareString(editor.Text, validateEditEventArgs.Text.ToString(), true) == 0)
				{
					goto IL_691;
				}
				IL_665:
				num2 = 72;
				editor.Text = validateEditEventArgs.Text.ToString();
				goto IL_691;
				IL_67C:
				num2 = 74;
				if (!editor.CanFocus)
				{
					goto IL_691;
				}
				IL_687:
				num2 = 75;
				editor.Focus();
				IL_691:
				goto IL_813;
				IL_696:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_7D4:
				goto IL_808;
				IL_7D6:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_7E6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_7D6;
			}
			IL_808:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_813:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0002C78C File Offset: 0x0002A98C
		private void <<EMPTY_NAME>>(object A_0, ValidateEditEventArgs A_1)
		{
			this.O_._.(RuntimeHelpers.GetObjectValue(A_0), A_1, null);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0002C79C File Offset: 0x0002A99C
		internal void <<EMPTY_NAME>>()
		{
			MethodInfo methodInfo = this.o.0O_O0o_..DataTable.Ooo.Oo0o0.;
			if (methodInfo == null && this.o.0O_O0o_..DataTable.GlobalHandler.BeforeDrawRow && O_O0OO.O0_00o.o0__o..OO.OOOO. != null)
			{
				methodInfo = O_O0OO.O0_00o.o0__o..OO.OOOO.;
			}
			if (methodInfo != null)
			{
				int @fixed = base.Rows.Fixed;
				int num = base.Rows.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					if (base.Rows[i].DataIndex > 0)
					{
						DrawRowEventArgs drawRowEventArgs = new DrawRowEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(base.Rows[i].DataIndex)), base.Rows[i].Height);
						try
						{
							methodInfo.Invoke(null, new object[]
							{
								drawRowEventArgs
							});
							if (base.Rows[i].Height != drawRowEventArgs.Height)
							{
								base.Rows[i].Height = drawRowEventArgs.Height;
							}
						}
						catch (Exception a_)
						{
							if (methodInfo == O_O0OO.O0_00o.o0__o..OO.OOOO.)
							{
								O_O0OO.O0_00o.o0__o..OO.OOOO. = null;
								ooO.oOo0Oo.o.(a_, "全局表事件,BeforeDrawRow");
							}
							else
							{
								this.o.0O_O0o_..DataTable.Ooo.Oo0o0. = null;
								ooO.oOo0Oo.o.(a_, "表，" + this.o.0O_O0o_..DataTable.Name + "，BeforeDrawRow");
							}
							MessageBox.Show("BeforeDrawRow事件执行错误，在您修正代码之前，将暂停执行该事件代码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
				}
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0002C950 File Offset: 0x0002AB50
		private void <<EMPTY_NAME>>(object A_0, PreviewKeyDownEventArgs A_1)
		{
			if (InputLanguage.CurrentInputLanguage.Culture.LCID == 2052 && ((this.o_O.Oo. && OO_00oOO.OSVersion() == 10 && base.Row >= base.Rows.Fixed) & base.Col >= base.Cols.Fixed) && base.Editor == null && A_1.KeyCode == Keys.ProcessKey && base.Cols[base.Col].DataType == typeof(string) && Operators.CompareString(base.Cols[base.Col].ComboList, "...", true) != 0)
			{
				string currentInputMethodDesc = TSFWrapper.GetCurrentInputMethodDesc(2052);
				if (Environment.OSVersion.Version.Build < 19042 || ((currentInputMethodDesc == null || currentInputMethodDesc.IndexOf("微软") < 0) && currentInputMethodDesc.IndexOf("QQ") < 0 && currentInputMethodDesc.IndexOf("搜狗") < 0))
				{
					RowColEventArgs rowColEventArgs = new RowColEventArgs(base.Row, base.Col);
					this.OOOo_oO_O.O.(RuntimeHelpers.GetObjectValue(A_0), rowColEventArgs, null);
					if (rowColEventArgs.Cancel)
					{
						this.O_._. = BooleanEnum.False;
					}
					else
					{
						this.O_._. = BooleanEnum.True;
					}
					if (!rowColEventArgs.Cancel)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(this.GetData(base.Row, base.Col));
						string text = "";
						if (objectValue != null)
						{
							text = objectValue.ToString();
						}
						base.StartEditing();
						Application.DoEvents();
						if (base.Editor != null && Operators.CompareString(base.Editor.Text, text, true) != 0)
						{
							text = base.Editor.Text;
							base.Editor.Text = "";
							SendKeys.Send(text);
						}
					}
				}
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0002CB2C File Offset: 0x0002AD2C
		private void <<EMPTY_NAME>>()
		{
			int @fixed = base.Cols.Fixed;
			int num = base.Col - 1;
			for (int i = @fixed; i <= num; i++)
			{
				if (base.Cols[i].Visible)
				{
					base.Select(base.Row, i, true);
					return;
				}
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0002CB7C File Offset: 0x0002AD7C
		private void <<EMPTY_NAME>>(bool A_0 = false)
		{
			int num = base.Col + 1;
			int num2 = base.Cols.Count - 1;
			int i = num;
			while (i <= num2)
			{
				if (base.Cols[i].Visible)
				{
					base.Select(base.Row, i, true);
					if (A_0 && base.PreserveEditMode && this.o000OOo.OO.(base.Row, base.Col))
					{
						base.StartEditing();
						return;
					}
					return;
				}
				else
				{
					i++;
				}
			}
			this.O_o.O_O__O.(A_0);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0002CBFC File Offset: 0x0002ADFC
		private void <<EMPTY_NAME>>(bool A_0 = false)
		{
			int num = base.Row + 1;
			int num2 = base.Rows.Count - 1;
			int i = num;
			while (i <= num2)
			{
				if (base.Rows[i].Visible)
				{
					base.Select(i, base.Col, true);
					if (A_0 && base.PreserveEditMode && this.o000OOo.OO.(base.Row, base.Col))
					{
						base.StartEditing();
						return;
					}
					break;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0002CC74 File Offset: 0x0002AE74
		private void <<EMPTY_NAME>>(bool A_0 = false)
		{
			int @fixed = base.Cols.Fixed;
			int col = base.Col;
			for (int i = @fixed; i <= col; i++)
			{
				if (base.Cols[i].Visible)
				{
					int num = base.Row + 1;
					int num2 = base.Rows.Count - 1;
					int j = num;
					while (j <= num2)
					{
						if (base.Rows[j].Visible)
						{
							base.Select(j, i, true);
							if (A_0 && base.PreserveEditMode && this.o000OOo.OO.(base.Row, base.Col))
							{
								base.StartEditing();
								return;
							}
							return;
						}
						else
						{
							j++;
						}
					}
					return;
				}
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0002CD18 File Offset: 0x0002AF18
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (this.o.0O_O0o_. != null && A_1.Button == MouseButtons.Left)
			{
				Point p = System.Windows.Forms.Control.MousePosition;
				bool a_ = System.Windows.Forms.Control.ModifierKeys == Keys.Control;
				bool a_2 = System.Windows.Forms.Control.ModifierKeys == (Keys.Control | Keys.Alt);
				int mouseRow = this.MouseRow;
				if (mouseRow >= base.Rows.Fixed)
				{
					int mouseCol = this.MouseCol;
					if (mouseCol >= base.Cols.Fixed && this.o.0O_O0o_..HierarchyData && Operators.CompareString(base.Cols[mouseCol].Name, this.o.0O_O0o_..OO0o_o0.0oOo0o., true) == 0 && base.Rows[mouseRow].DataIndex >= 0)
					{
						O_0 o_ = this.o.0O_O0o_..View;
						if (!o_.O0O_0_0__.0O.(base.Rows[mouseRow].DataIndex).Row.IsNull("sys_Hierarchy_Level"))
						{
							int num = Conversions.ToInteger(o_.O0O_0_0__.0O.(base.Rows[mouseRow].DataIndex)["sys_Hierarchy_Level"]);
							p = base.PointToClient(p);
							int left = base.Cols[mouseCol].Left;
							double num2 = (double)left + (double)this.OO_.00oO0Oo.(null) * ((double)num + 1.5);
							double num3 = (double)((float)left + this.OO_.00oO0Oo.(null) * (float)num);
							if ((double)(p.X - base.ScrollPosition.X) > num3 && (double)(p.X - base.ScrollPosition.X) < num2)
							{
								this.O_._.(mouseRow, a_2, a_);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0002CECC File Offset: 0x0002B0CC
		internal void <<EMPTY_NAME>>(int A_0, bool A_1, bool A_2)
		{
			O_0 o_ = this.o.0O_O0o_..View;
			if (!o_.O0O_0_0__.0O.(base.Rows[A_0].DataIndex).Row.IsNull("sys_Hierarchy_Level"))
			{
				int num = Conversions.ToInteger(o_.O0O_0_0__.0O.(base.Rows[A_0].DataIndex)["sys_Hierarchy_Level"]);
				bool flag = this.GetUserData(A_0, base.Cols.Fixed - 1) == null;
				flag = !flag;
				if (A_1)
				{
					if (flag)
					{
						this.OoO._OOo__.(num + 1);
						return;
					}
					this.OoO._OOo__.(num);
					return;
				}
				else
				{
					if (A_2)
					{
						for (int i = A_0 - 1; i >= 0; i += -1)
						{
							if (base.Rows[i].DataIndex > -1)
							{
								int num2;
								if (o_.O0O_0_0__.0O.(base.Rows[i].DataIndex).Row.IsNull("sys_Hierarchy_Level"))
								{
									num2 = 0;
								}
								else
								{
									num2 = Conversions.ToInteger(o_.O0O_0_0__.0O.(base.Rows[i].DataIndex)["sys_Hierarchy_Level"]);
								}
								if (num2 == num)
								{
									A_0 = i;
								}
								else if (num2 < num)
								{
									break;
								}
							}
						}
					}
					try
					{
						this.BeginUpdate();
						while (A_0 < base.Rows.Count - 1)
						{
							int j = A_0;
							if (base.Rows[j].DataIndex < 0)
							{
								A_0++;
							}
							else
							{
								int num3 = Conversions.ToInteger(o_.O0O_0_0__.0O.(base.Rows[j].DataIndex)["sys_Hierarchy_Level"]);
								if (num3 < num)
								{
									break;
								}
								if (num3 > num)
								{
									A_0++;
								}
								else
								{
									if (flag)
									{
										this.SetUserData(j, base.Cols.Fixed - 1, null);
									}
									else
									{
										this.SetUserData(j, base.Cols.Fixed - 1, "1");
									}
									for (j++; j < base.Rows.Count; j++)
									{
										if (base.Rows[j].DataIndex >= 0 && !o_.O0O_0_0__.0O.(base.Rows[j].DataIndex).Row.IsNull("sys_Hierarchy_Level"))
										{
											int num4 = Conversions.ToInteger(o_.O0O_0_0__.0O.(base.Rows[j].DataIndex)["sys_Hierarchy_Level"]);
											if (num4 <= num)
											{
												break;
											}
											if (num4 == num + 1)
											{
												this.o_.OO.(j, flag);
											}
										}
									}
									if (!A_2)
									{
										break;
									}
									A_0++;
								}
							}
						}
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
					finally
					{
						this.EndUpdate();
					}
				}
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0002D1AC File Offset: 0x0002B3AC
		internal void <<EMPTY_NAME>>(int A_0)
		{
			this.BeginUpdate();
			if (A_0 == -1)
			{
				int num = base.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					base.Rows[i].Visible = true;
					this.SetUserData(i, base.Cols.Fixed - 1, null);
				}
			}
			else
			{
				O_0 o_ = this.o.0O_O0o_..View;
				int @fixed = base.Rows.Fixed;
				int num2 = base.Rows.Count - 1;
				for (int j = @fixed; j <= num2; j++)
				{
					if (base.Rows[j].DataIndex >= 0 && !o_.O0O_0_0__.0O.(base.Rows[j].DataIndex).Row.IsNull("sys_Hierarchy_Level"))
					{
						int num3 = Conversions.ToInteger(o_.O0O_0_0__.0O.(base.Rows[j].DataIndex)["sys_Hierarchy_Level"]);
						if (num3 < A_0)
						{
							base.Rows[j].Visible = true;
							this.SetUserData(j, base.Cols.Fixed - 1, null);
						}
						else if (num3 == A_0)
						{
							base.Rows[j].Visible = true;
							this.SetUserData(j, base.Cols.Fixed - 1, 1);
						}
						else
						{
							base.Rows[j].Visible = false;
							this.SetUserData(j, base.Cols.Fixed - 1, 1);
						}
					}
				}
			}
			this.EndUpdate();
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0002D34C File Offset: 0x0002B54C
		private void <<EMPTY_NAME>>(int A_0, bool A_1)
		{
			base.Rows[A_0].Visible = A_1;
			O_0 o_ = this.o.0O_O0o_..View;
			int dataIndex = base.Rows[A_0].DataIndex;
			int num = Conversions.ToInteger(o_.O0O_0_0__.0O.(dataIndex)["sys_Hierarchy_Level"]);
			if (this.GetUserData(A_0, base.Cols.Fixed - 1) == null)
			{
				A_0++;
				while (A_0 < base.Rows.Count)
				{
					int dataIndex2 = base.Rows[A_0].DataIndex;
					if (dataIndex < 0)
					{
						A_0++;
					}
					else
					{
						if (dataIndex2 >= 0 && !o_.O0O_0_0__.0O.(dataIndex2).Row.IsNull("sys_Hierarchy_Level"))
						{
							int num2 = Conversions.ToInteger(o_.O0O_0_0__.0O.(dataIndex2)["sys_Hierarchy_Level"]);
							if (num2 <= num)
							{
								break;
							}
							if (num2 == num + 1)
							{
								this.o_.OO.(A_0, A_1);
							}
						}
						A_0++;
					}
				}
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0002D438 File Offset: 0x0002B638
		[CompilerGenerated]
		private virtual Timer <<EMPTY_NAME>>()
		{
			return this.O_._.;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0002D440 File Offset: 0x0002B640
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(Timer A_0)
		{
			EventHandler value = new EventHandler(this.O.O0_0.);
			Timer o_._. = this.O_._.;
			if (o_._. != null)
			{
				o_._..Tick -= value;
			}
			this.O_._. = A_0;
			o_._. = this.O_._.;
			if (o_._. != null)
			{
				o_._..Tick += value;
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0002D483 File Offset: 0x0002B683
		private Timer <<EMPTY_NAME>>()
		{
			if (this.OO.o_o00o.() == null)
			{
				this.OO0o_o_OO.O_O.(new Timer());
			}
			return this.OO.o_o00o.();
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0002D4A0 File Offset: 0x0002B6A0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO_.00oO0Oo.().Enabled = false;
			if (this.Focused)
			{
				int mouseRow = this.MouseRow;
				int mouseCol = this.MouseCol;
				if (mouseRow <= base.Rows.Count - 1 && mouseRow >= base.Rows.Fixed && mouseCol <= base.Cols.Count - 1 && mouseCol >= base.Cols.Fixed)
				{
					C1.Win.C1FlexGrid.Row row = base.Rows[mouseRow];
					C1.Win.C1FlexGrid.Column column = base.Cols[mouseCol];
					if (row.DataIndex >= 0 && (this.o.0O_O0o_..DataTable.oo.o0_oO__o. != null || O_O0OO.O0_00o.o0__o..OOO0_.o__OO. != null) && base.Editor == null)
					{
						this.OOOOOO.o0Oo0. = true;
						this.O.o__OO0oO_0. = mouseRow;
						this.OOOOOO.o0Oo0. = mouseCol;
						MethodInfo methodInfo = this.o.0O_O0o_..DataTable.oo.o0_oO__o.;
						MouseHoverCellEventArgs mouseHoverCellEventArgs = new MouseHoverCellEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(row.DataIndex)), this.o.0O_O0o_..Cols[column.Name], null, true);
						if (methodInfo != null)
						{
							try
							{
								methodInfo.Invoke(null, new object[]
								{
									mouseHoverCellEventArgs
								});
							}
							catch (Exception a_)
							{
								ooO.oOo0Oo.o.(a_, "表，" + base.Name + "，MouseHoverCell");
							}
						}
						if (this.o.0O_O0o_..foxGrid.FindForm() != null && this.o.0O_O0o_..DataTable.GlobalHandler.MouseHoverCell)
						{
							methodInfo = O_O0OO.O0_00o.o0__o..OOO0_.o__OO.;
							if (methodInfo != null)
							{
								try
								{
									methodInfo.Invoke(null, new object[]
									{
										mouseHoverCellEventArgs
									});
								}
								catch (Exception a_2)
								{
									ooO.oOo0Oo.o.(a_2, "全局事件, MouseHoverCell");
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0002D6A4 File Offset: 0x0002B8A4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0O_O0o_..DataTable.oo.o0_oO__o. != null || O_O0OO.O0_00o.o0__o..OOO0_.o__OO. != null)
			{
				if (this.OOOOOO.o0Oo0.)
				{
					this.OOOOOO.o0Oo0. = false;
					int o.o__OO0oO_0. = this.O.o__OO0oO_0.;
					int oooooo.o0Oo0. = this.OOOOOO.o0Oo0.;
					if (o.o__OO0oO_0. > base.Rows.Count - 1 || o.o__OO0oO_0. < base.Rows.Fixed || o.o__OO0oO_0. > base.Cols.Count - 1 || oooooo.o0Oo0. < base.Cols.Fixed)
					{
						return;
					}
					C1.Win.C1FlexGrid.Row row = base.Rows[o.o__OO0oO_0.];
					C1.Win.C1FlexGrid.Column column = base.Cols[oooooo.o0Oo0.];
					if (row.DataIndex < 0)
					{
						return;
					}
					MethodInfo methodInfo = this.o.0O_O0o_..DataTable.oo.o0_oO__o.;
					MouseHoverCellEventArgs mouseHoverCellEventArgs = new MouseHoverCellEventArgs(this.o.0O_O0o_., new Foxtable.Row(this.o.0O_O0o_., this.o.0O_O0o_..View.O0O_0_0__.0O.(row.DataIndex)), this.o.0O_O0o_..Cols[column.Name], null, false);
					if (methodInfo != null)
					{
						try
						{
							methodInfo.Invoke(null, new object[]
							{
								mouseHoverCellEventArgs
							});
						}
						catch (Exception a_)
						{
							ooO.oOo0Oo.o.(a_, "表，" + base.Name + "，MouseHoverCell");
						}
					}
					if (this.o.0O_O0o_..foxGrid.FindForm() == null || !this.o.0O_O0o_..DataTable.GlobalHandler.MouseHoverCell)
					{
						return;
					}
					methodInfo = O_O0OO.O0_00o.o0__o..OOO0_.o__OO.;
					if (methodInfo == null)
					{
						return;
					}
					try
					{
						methodInfo.Invoke(null, new object[]
						{
							mouseHoverCellEventArgs
						});
						return;
					}
					catch (Exception a_2)
					{
						ooO.oOo0Oo.o.(a_2, "全局事件, MouseHoverCell");
						return;
					}
				}
				this.OO_.00oO0Oo.().Enabled = false;
				this.OO_.00oO0Oo.().Interval = 500;
				this.OO_.00oO0Oo.().Enabled = true;
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0002D8B0 File Offset: 0x0002BAB0
		protected override void Dispose(bool disposing)
		{
			if (this.OO.o_o00o.() != null)
			{
				this.OO.o_o00o.().Enabled = false;
				this.OO.o_o00o.().Dispose();
				this.OO0o_o_OO.O_O.(null);
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0002D8E0 File Offset: 0x0002BAE0
		public float <<EMPTY_NAME>>(OwnerDrawCellEventArgs A_0)
		{
			if (this.O_._. <= 0f)
			{
				if (A_0 == null)
				{
					return 12.342f;
				}
				this.O_._. = (A_0.Graphics.MeasureString("w\u3000w", A_0.Style.Font).Width - A_0.Graphics.MeasureString("ww", A_0.Style.Font).Width) * A_0.Graphics.DpiX / 96f;
			}
			return this.O_._.;
		}

		// Token: 0x0400014B RID: 331
		internal Foxtable.Table <<EMPTY_NAME>>;

		// Token: 0x0400014C RID: 332
		internal int <<EMPTY_NAME>>;

		// Token: 0x0400014D RID: 333
		private int[] <<EMPTY_NAME>>;

		// Token: 0x0400014E RID: 334
		private LookAndFeelProperty <<EMPTY_NAME>>;

		// Token: 0x0400014F RID: 335
		private Dictionary<C1.Win.C1FlexGrid.Column, int> <<EMPTY_NAME>>;

		// Token: 0x04000150 RID: 336
		private o0o0o00 <<EMPTY_NAME>>;

		// Token: 0x04000151 RID: 337
		private int <<EMPTY_NAME>>;

		// Token: 0x04000152 RID: 338
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000153 RID: 339
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x04000154 RID: 340
		private static int <<EMPTY_NAME>>;

		// Token: 0x04000155 RID: 341
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000156 RID: 342
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000157 RID: 343
		private static Image <<EMPTY_NAME>> = a.oO000_0.O_0.().ToBitmap();

		// Token: 0x04000158 RID: 344
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000159 RID: 345
		internal BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x0400015A RID: 346
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400015B RID: 347
		[CompilerGenerated]
		private Timer <<EMPTY_NAME>>;

		// Token: 0x0400015C RID: 348
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400015D RID: 349
		private int <<EMPTY_NAME>>;

		// Token: 0x0400015E RID: 350
		private int <<EMPTY_NAME>>;

		// Token: 0x0400015F RID: 351
		private float <<EMPTY_NAME>>;
	}
}
