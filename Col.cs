using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000316 RID: 790
	[ComVisible(true)]
	[oO0oooo("1375")]
	public class Col
	{
		// Token: 0x06002A89 RID: 10889 RVA: 0x0012DD07 File Offset: 0x0012BF07
		internal Col(Table A_0, string A_1)
		{
			this.O_00_o.__. = BooleanEnum.Default;
			this.O0o0._O. = 1;
			this.o0O0oO.0. = BooleanEnum.Default;
			this.o0OO_.O00___. = BooleanEnum.Default;
			this.oOoO00.o. = BooleanEnum.Default;
			this.ooO_o.o___o. = BooleanEnum.Default;
			this.o_o_O.0000_O. = A_0;
			this.o_o_O.0000_O. = A_1;
		}

		/// <summary>
		/// 列名
		/// </summary>
		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x0012DD47 File Offset: 0x0012BF47
		[oO0oooo("0568")]
		public string Name
		{
			get
			{
				return this.o_o_O.0000_O.;
			}
		}

		/// <summary>
		/// 标题
		/// </summary>
		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x0012DD50 File Offset: 0x0012BF50
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x0012DDE4 File Offset: 0x0012BFE4
		[oO0oooo("0570")]
		public string Caption
		{
			get
			{
				string caption;
				if (Operators.CompareString(this.o0O0oO.0., "", true) > 0)
				{
					caption = this.o0O0oO.0.;
				}
				else if (Operators.CompareString(this.DataCol.Setting.Caption, "", true) > 0)
				{
					caption = this.DataCol.Setting.Caption;
				}
				else if (Operators.CompareString(this.DataCol.BaseColumn.Caption, "", true) > 0)
				{
					caption = this.DataCol.BaseColumn.Caption;
				}
				else
				{
					caption = this.o_o_O.0000_O.;
				}
				return caption;
			}
			set
			{
				this.o0O0oO.0. = value;
			}
		}

		/// <summary>
		/// 在记录窗口显示的缩写标题
		/// </summary>
		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x0012DDF0 File Offset: 0x0012BFF0
		// (set) Token: 0x06002A8E RID: 10894 RVA: 0x0012DE49 File Offset: 0x0012C049
		[oO0oooo("2201")]
		public string ShortCaption
		{
			get
			{
				string result;
				if (Operators.CompareString(this.oo_.OoOO0., "", true) > 0)
				{
					result = this.oo_.OoOO0.;
				}
				else if (Operators.CompareString(this.DataCol.ShortCaption, "", true) > 0)
				{
					result = this.DataCol.ShortCaption;
				}
				else
				{
					result = this.Caption;
				}
				return result;
			}
			set
			{
				this.oo_.OoOO0. = value;
				if (this.Table.RecordGridVisible)
				{
					this.Table.o00oOO00_.ooOo..O0_00O.0__.();
				}
			}
		}

		/// <summary>
		/// 在记录窗口显示的行高倍数，默认为1
		/// </summary>
		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x0012DE70 File Offset: 0x0012C070
		// (set) Token: 0x06002A90 RID: 10896 RVA: 0x0012DE9C File Offset: 0x0012C09C
		[oO0oooo("2201")]
		public int RecordRowHeight
		{
			get
			{
				int result;
				if (this.O0o0._O. != 1)
				{
					result = this.O0o0._O.;
				}
				else
				{
					result = this.DataCol.RecordRowHeight;
				}
				return result;
			}
			set
			{
				this.O0o0._O. = value;
				if (this.Table.RecordGridVisible)
				{
					this.Table.o00oOO00_.ooOo..O0_00O.0__.();
				}
			}
		}

		/// <summary>
		/// 是否在记录窗口显示此列
		/// </summary>
		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x0012DEC4 File Offset: 0x0012C0C4
		// (set) Token: 0x06002A92 RID: 10898 RVA: 0x0012DF0B File Offset: 0x0012C10B
		[oO0oooo("2201")]
		public bool ShowInRecordGrid
		{
			get
			{
				bool result;
				if (this.ooO_o.o___o. == BooleanEnum.Default)
				{
					if (this.DataCol.ShowInRecordGrid == BooleanEnum.Default)
					{
						result = this.Visible;
					}
					else
					{
						result = (this.DataCol.ShowInRecordGrid == BooleanEnum.True);
					}
				}
				else
				{
					result = (this.ooO_o.o___o. == BooleanEnum.True);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.ooO_o.o___o. = BooleanEnum.True;
				}
				else
				{
					this.ooO_o.o___o. = BooleanEnum.False;
				}
				if (this.Table.RecordGridVisible)
				{
					this.Table.o00oOO00_.ooOo..O0_00O.0__.();
				}
			}
		}

		/// <summary>
		/// 此Col对应的Datacol
		/// </summary>
		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x0012DF3D File Offset: 0x0012C13D
		[oO0oooo("0571")]
		public DataCol DataCol
		{
			get
			{
				return this.Table.DataTable.DataCols[this.o_o_O.0000_O.];
			}
		}

		/// <summary>
		/// Table所属的DataTable
		/// </summary>
		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x0012DF5A File Offset: 0x0012C15A
		public DataTable DataTable
		{
			get
			{
				return this.Table.DataTable;
			}
		}

		/// <summary>
		/// 此Col所属的Table
		/// </summary>
		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x0012DF67 File Offset: 0x0012C167
		public Table Table
		{
			get
			{
				return this.o_o_O.0000_O.;
			}
		}

		/// <summary>
		/// 列位置
		/// </summary>
		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06002A96 RID: 10902 RVA: 0x0012DF70 File Offset: 0x0012C170
		[oO0oooo("0569")]
		public int Index
		{
			get
			{
				int result;
				if (this.o_o_O.0000_O..foxGrid.Cols.Contains(this.o_o_O.0000_O.))
				{
					result = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].Index - this.o_o_O.0000_O..foxGrid.Cols.Fixed;
				}
				else
				{
					result = -1;
				}
				return result;
			}
		}

		/// <summary>
		/// 是否可见
		/// </summary>
		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x0012DFD6 File Offset: 0x0012C1D6
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x0012DFF8 File Offset: 0x0012C1F8
		[oO0oooo("0572")]
		public bool Visible
		{
			get
			{
				return this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].Visible;
			}
			set
			{
				this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].Visible = value;
			}
		}

		/// <summary>
		/// 移动列
		/// </summary>
		/// <param name="Position">新的列位置</param>
		// Token: 0x06002A99 RID: 10905 RVA: 0x0012E01B File Offset: 0x0012C21B
		[oO0oooo("0587")]
		public void Move(int Position)
		{
			this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].Move(Position + this.o_o_O.0000_O..foxGrid.Cols.Fixed);
		}

		/// <summary>
		/// 是否允许编辑列
		/// </summary>
		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06002A9A RID: 10906 RVA: 0x0012E054 File Offset: 0x0012C254
		// (set) Token: 0x06002A9B RID: 10907 RVA: 0x0012E087 File Offset: 0x0012C287
		[oO0oooo("0573")]
		public bool AllowEdit
		{
			get
			{
				bool result;
				if (this.O_00_o.__. == BooleanEnum.Default)
				{
					result = this.DataCol.AllowEdit;
				}
				else
				{
					result = (this.O_00_o.__. == BooleanEnum.True);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.O_00_o.__. = BooleanEnum.True;
				}
				else
				{
					this.O_00_o.__. = BooleanEnum.False;
				}
				Main.OO_O.o..O.ooO0. = true;
			}
		}

		/// <summary>
		/// 是否在合计模式下显示此列的合计
		/// </summary>
		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x0012E0A7 File Offset: 0x0012C2A7
		// (set) Token: 0x06002A9D RID: 10909 RVA: 0x0012E0AF File Offset: 0x0012C2AF
		[oO0oooo("2750")]
		public bool GrandTotal
		{
			get
			{
				return this.O0o0._O.;
			}
			set
			{
				this.O0o0._O. = value;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x0012E0B8 File Offset: 0x0012C2B8
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x0012E0C0 File Offset: 0x0012C2C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dictionary<string, string> CodeDictonary
		{
			get
			{
				return this.O0o0._O.;
			}
			set
			{
				this.O0o0._O. = value;
			}
		}

		/// <summary>
		/// 代码项目
		/// </summary>
		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x0012E0C9 File Offset: 0x0012C2C9
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x0012E0D1 File Offset: 0x0012C2D1
		[oO0oooo("2125")]
		public Dictionary<string, string> CodeDictionary
		{
			get
			{
				return this.O0o0._O.;
			}
			set
			{
				this.O0o0._O. = value;
			}
		}

		/// <summary>
		/// 数据字典
		/// </summary>
		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x0012E0DA File Offset: 0x0012C2DA
		// (set) Token: 0x06002AA3 RID: 10915 RVA: 0x0012E0FC File Offset: 0x0012C2FC
		[oO0oooo("1836")]
		public IDictionary DataMap
		{
			get
			{
				return this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].DataMap;
			}
			set
			{
				if (value != null)
				{
					this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].Editor = null;
				}
				else if (this.ImageMap == null & Operators.CompareString(this.ComboList, "", true) == 0)
				{
					this.oo_0_oO._.();
				}
				this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].DataMap = value;
			}
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x0012E178 File Offset: 0x0012C378
		public void SetDataMap(object dataMap)
		{
			if (dataMap is MultiDataMap)
			{
				this.DataMap = ((MultiDataMap)dataMap).CreateDataMap();
				return;
			}
			if (dataMap is TableDataMap)
			{
				this.DataMap = ((TableDataMap)dataMap).CreateDataMap();
				return;
			}
			if (dataMap is DataMapJs)
			{
				this.DataMap = ((DataMapJs)dataMap).oo._Oo0.;
			}
		}

		/// <summary>
		/// 图形字典
		/// </summary>
		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x0012E1D2 File Offset: 0x0012C3D2
		// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x0012E1F4 File Offset: 0x0012C3F4
		[oO0oooo("0583")]
		public IDictionary ImageMap
		{
			get
			{
				return this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].ImageMap;
			}
			set
			{
				if (value != null && value is ImageMap)
				{
					this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].Editor = null;
					this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].ImageMap = ((ImageMap)value).o0oo.Oo.();
					if (Operators.CompareString(this.ComboList, "", true) == 0 & this.DataMap == null)
					{
						this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].ComboList = ((ImageMap)value).ImageKeys;
						return;
					}
				}
				else
				{
					this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].ImageMap = null;
					if (this.DataMap == null & Operators.CompareString(this.ComboList, "", true) == 0)
					{
						this.oo_0_oO._.();
					}
				}
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x0012E2F1 File Offset: 0x0012C4F1
		// (set) Token: 0x06002AA8 RID: 10920 RVA: 0x0012E2FC File Offset: 0x0012C4FC
		internal string DisplayMember
		{
			get
			{
				return this.Oo_O.00o.;
			}
			set
			{
				this.Oo_O.00o. = value;
				Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
				if (column.Editor != null && column.Editor is o0_o_o_0)
				{
					((o0_o_o_0)column.Editor).OoO00_0_._0.(null);
					return;
				}
				if (column.Editor != null && column.Editor is O0_0_0_Oo_o)
				{
					((O0_0_0_Oo_o)column.Editor).oO_0.__oO0_000.(null);
				}
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x0012E379 File Offset: 0x0012C579
		// (set) Token: 0x06002AAA RID: 10922 RVA: 0x0012E384 File Offset: 0x0012C584
		internal string ValueMember
		{
			get
			{
				return this.o__0_O.o_.;
			}
			set
			{
				this.o__0_O.o_. = value;
				Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
				if (column.Editor != null && column.Editor is o0_o_o_0)
				{
					((o0_o_o_0)column.Editor).o_.O_.(null);
					return;
				}
				if (column.Editor != null && column.Editor is O0_0_0_Oo_o)
				{
					((O0_0_0_Oo_o)column.Editor).O.00o0o_.(null);
				}
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x0012E401 File Offset: 0x0012C601
		// (set) Token: 0x06002AAC RID: 10924 RVA: 0x0012E40C File Offset: 0x0012C60C
		internal string DataFilter
		{
			get
			{
				return this.o0.OO.;
			}
			set
			{
				this.o0.OO. = value;
				Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
				if (column.Editor != null && column.Editor is o0_o_o_0)
				{
					((DataView)((o0_o_o_0)column.Editor).o.O0.()).RowFilter = value;
					return;
				}
				if (column.Editor != null && column.Editor is O0_0_0_Oo_o)
				{
					((DataView)((O0_0_0_Oo_o)column.Editor).O___0oO__.0oO.()).RowFilter = value;
				}
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06002AAD RID: 10925 RVA: 0x0012E49D File Offset: 0x0012C69D
		// (set) Token: 0x06002AAE RID: 10926 RVA: 0x0012E4A8 File Offset: 0x0012C6A8
		internal string DataSort
		{
			get
			{
				return this.o0._O_Oo_ooOO.;
			}
			set
			{
				this.o0._O_Oo_ooOO. = value;
				Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
				if (column.Editor != null && column.Editor is o0_o_o_0)
				{
					((DataView)((o0_o_o_0)column.Editor).o.O0.()).Sort = value;
					return;
				}
				if (column.Editor != null && column.Editor is O0_0_0_Oo_o)
				{
					((DataView)((O0_0_0_Oo_o)column.Editor).O___0oO__.0oO.()).Sort = value;
				}
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x0012E539 File Offset: 0x0012C739
		// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x0012E544 File Offset: 0x0012C744
		internal string DataSource
		{
			get
			{
				return this.oO0OO.oO.;
			}
			set
			{
				this.oO0OO.oO. = value;
				Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
				if (Operators.CompareString(value, "", true) == 0)
				{
					if (column.Editor != null && column.Editor is o0_o_o_0)
					{
						if (((o0_o_o_0)column.Editor).o.O0.() != null)
						{
							column.Editor = O_O0OO.OoO.0OO__0ooo.();
							return;
						}
					}
					else if (column.Editor != null && column.Editor is O0_0_0_Oo_o && ((O0_0_0_Oo_o)column.Editor).O___0oO__.0oO.() != null)
					{
						column.Editor = O_O0OO.OoO.0OO__0ooo.();
						return;
					}
				}
				else if (this.DataCol.ExtendColumnType == ExtendColumnTypeEnum.多值字段)
				{
					o0_o_o_0 o0_o_o_ = new o0_o_o_0();
					o0_o_o_.Oo_o0_O00_00.O.(this.DataCol.Separator);
					if (Operators.CompareString(this.DataSource, "", true) > 0 && O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(this.DataSource))
					{
						DataTable dataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables[this.DataSource];
						if (Operators.CompareString(this.ValueMember, "", true) != 0 && dataTable.Columns.Contains(this.ValueMember) && Operators.CompareString(this.DisplayMember, "", true) != 0 && dataTable.Columns.Contains(this.DisplayMember))
						{
							DataView dataView = new DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables[this.DataSource], "", "", DataViewRowState.CurrentRows);
							try
							{
								dataView.Sort = this.DataSort;
								dataView.RowFilter = this.DataFilter;
								if (Operators.CompareString(this.DataSort, "", true) == 0)
								{
									dataView.Sort = this.ValueMember;
								}
								o0_o_o_.o_.O_.(this.ValueMember);
								o0_o_o_.OoO00_0_._0.(this.DisplayMember);
								o0_o_o_.O.0o0O.(dataView);
							}
							catch (Exception ex)
							{
								MessageBox.Show(string.Concat(new string[]
								{
									this.Table.Name,
									".",
									this.Name,
									"的列表项目设置出错，原因：",
									ex.Message
								}), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							}
						}
					}
					if (o0_o_o_.o.O0.() != null)
					{
						o0_o_o_.O.0o0O.(this.AllowDirectType);
						o0_o_o_.Oo_o0_O00_00.O.(this.DataCol.MultiColumn);
						o0_o_o_.o_0.0_.(this.DataCol.ColumnWidth);
						o0_o_o_.Oo.0oO0__O.(this.DataCol.DropDownWidth);
						o0_o_o_.OoO00_0_._0.(this.DataCol.DropDownHeight);
						o0_o_o_.o_.O_.(this.DataCol.MaxDropDownItems);
						column.Editor = o0_o_o_;
						return;
					}
				}
				else
				{
					O0_0_0_Oo_o o0_0_0_Oo_o = new O0_0_0_Oo_o();
					if (Operators.CompareString(this.DataSource, "", true) > 0 && O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(this.DataSource))
					{
						DataTable dataTable2 = O_O0OO.OOOo.oo_OOOO_0.().Tables[this.DataSource];
						if (Operators.CompareString(this.ValueMember, "", true) == 0 || !dataTable2.Columns.Contains(this.ValueMember) || Operators.CompareString(this.DisplayMember, "", true) == 0 || !dataTable2.Columns.Contains(this.DisplayMember))
						{
							o0_0_0_Oo_o.oO_0.__oO0_000.(null);
						}
						else
						{
							DataView dataView2 = new DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables[this.DataSource], "", "", DataViewRowState.CurrentRows);
							try
							{
								dataView2.RowFilter = this.DataFilter;
								if (Operators.CompareString(dataView2.RowFilter, "", true) > 0)
								{
									dataView2.RowFilter = dataView2.RowFilter + " And [" + this.ValueMember + "] Is Not Null";
								}
								else
								{
									dataView2.RowFilter = "[" + this.ValueMember + "] Is Not Null";
								}
								if (Operators.CompareString(this.DataSort, "", true) == 0)
								{
									dataView2.Sort = this.ValueMember;
								}
								else
								{
									dataView2.Sort = this.DataSort;
								}
								o0_0_0_Oo_o.O.00o0o_.(this.ValueMember);
								o0_0_0_Oo_o.oO_0.__oO0_000.(this.DisplayMember);
								o0_0_0_Oo_o.oO_0.__oO0_000.(dataView2);
							}
							catch (Exception ex2)
							{
								MessageBox.Show(string.Concat(new string[]
								{
									this.Table.Name,
									".",
									this.Name,
									"的列表项目设置出错，原因：",
									ex2.Message
								}), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							}
						}
					}
					if (o0_0_0_Oo_o.O___0oO__.0oO.() != null)
					{
						o0_0_0_Oo_o.oO_0.__oO0_000.(this.AllowDirectType);
						o0_0_0_Oo_o.OO00_.O_.(this.DataCol.MultiColumn);
						o0_0_0_Oo_o.oO_0.__oO0_000.(this.DataCol.ColumnWidth);
						o0_0_0_Oo_o.o.ooo.(this.DataCol.DropDownWidth);
						o0_0_0_Oo_o.O.0_0_.(this.DataCol.DropDownHeight);
						o0_0_0_Oo_o.O.00o0o_.(this.DataCol.MaxDropDownItems);
						o0_0_0_Oo_o.OoOo__.o.(this.DataCol.ItemSpacing);
						column.Editor = o0_0_0_Oo_o;
						if (this.AllowTypeAssistant && this.AllowDirectType)
						{
							o0_0_0_Oo_o.AutoCompleteSource = AutoCompleteSource.CustomSource;
							o0_0_0_Oo_o.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
							this.ResetAutoCompleteSource();
						}
					}
				}
			}
		}

		/// <summary>
		/// 列表项目
		/// </summary>
		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x0012EAC0 File Offset: 0x0012CCC0
		// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x0012EC38 File Offset: 0x0012CE38
		[oO0oooo("0578")]
		public string ComboList
		{
			get
			{
				Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
				if (column.Editor is o0_o_o_0)
				{
					o0_o_o_0 o0_o_o_ = (o0_o_o_0)column.Editor;
					if (o0_o_o_.o.O0.() == null)
					{
						string text = "";
						try
						{
							foreach (object value in o0_o_o_.o.O0.())
							{
								string str = Conversions.ToString(value);
								if (Operators.CompareString(text, "", true) > 0)
								{
									text += "|";
								}
								text += str;
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
						return text;
					}
				}
				else if (column.Editor is O0_0_0_Oo_o)
				{
					O0_0_0_Oo_o o0_0_0_Oo_o = (O0_0_0_Oo_o)column.Editor;
					if (o0_0_0_Oo_o.O___0oO__.0oO.() == null)
					{
						string text2 = "";
						try
						{
							foreach (object value2 in o0_0_0_Oo_o.OO.0oo.())
							{
								string str2 = Conversions.ToString(value2);
								if (Operators.CompareString(text2, "", true) > 0)
								{
									text2 += "|";
								}
								text2 += str2;
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
						return text2;
					}
				}
				return null;
			}
			set
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
					this.o_0.oo. = value;
					IL_10:
					num2 = 3;
					Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
					IL_2E:
					num2 = 4;
					if (Operators.CompareString(value, "", true) != 0)
					{
						goto IL_E0;
					}
					IL_41:
					num2 = 5;
					if (column.Editor == null || !(column.Editor is o0_o_o_0))
					{
						goto IL_79;
					}
					IL_58:
					num2 = 6;
					if (((o0_o_o_0)column.Editor).o.O0.() != null)
					{
						goto IL_79;
					}
					IL_6C:
					num2 = 7;
					column.Editor = O_O0OO.OoO.0OO__0ooo.();
					IL_79:
					num2 = 8;
					if (column.Editor == null || !(column.Editor is O0_0_0_Oo_o))
					{
						goto IL_B3;
					}
					IL_90:
					num2 = 9;
					if (((O0_0_0_Oo_o)column.Editor).O___0oO__.0oO.() != null)
					{
						goto IL_B3;
					}
					IL_A5:
					num2 = 10;
					column.Editor = O_O0OO.OoO.0OO__0ooo.();
					IL_B3:
					num2 = 11;
					if (Operators.CompareString(column.ComboList, "", true) <= 0)
					{
						goto IL_3E1;
					}
					IL_CD:
					num2 = 12;
					column.ComboList = "";
					goto IL_3E1;
					IL_E0:
					num2 = 15;
					if (Operators.CompareString(value, "...", true) != 0)
					{
						goto IL_10E;
					}
					IL_F1:
					num2 = 16;
					column.Editor = null;
					IL_FB:
					num2 = 17;
					column.ComboList = "...";
					goto IL_3E1;
					IL_10E:
					num2 = 20;
					if (Operators.CompareString(value, "|...", true) != 0)
					{
						goto IL_13C;
					}
					IL_11F:
					num2 = 21;
					column.Editor = null;
					IL_129:
					num2 = 22;
					column.ComboList = "|...";
					goto IL_3E1;
					IL_13C:
					num2 = 24;
					if (this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.多值字段)
					{
						goto IL_257;
					}
					IL_150:
					num2 = 25;
					if (!(column.Editor is o0_o_o_0))
					{
						goto IL_181;
					}
					IL_160:
					num2 = 26;
					o0_o_o_0 o0_o_o_ = (o0_o_o_0)column.Editor;
					IL_170:
					num2 = 27;
					o0_o_o_.o.O0.().Clear();
					goto IL_18B;
					IL_181:
					num2 = 29;
					o0_o_o_ = new o0_o_o_0();
					IL_18B:
					num2 = 30;
					o0_o_o_.Oo_o0_O00_00.O.(this.DataCol.Separator);
					IL_1A0:
					num2 = 31;
					string[] items = value.Split(new char[]
					{
						'\n',
						'\r',
						'|'
					}, StringSplitOptions.RemoveEmptyEntries);
					IL_1BD:
					num2 = 32;
					o0_o_o_.o.O0.().AddRange(items);
					IL_1CE:
					num2 = 33;
					o0_o_o_.O.0o0O.(this.AllowDirectType);
					IL_1DE:
					num2 = 34;
					o0_o_o_.Oo_o0_O00_00.O.(this.DataCol.MultiColumn);
					IL_1F3:
					num2 = 35;
					o0_o_o_.o_0.0_.(this.DataCol.ColumnWidth);
					IL_208:
					num2 = 36;
					o0_o_o_.Oo.0oO0__O.(this.DataCol.DropDownWidth);
					IL_21D:
					num2 = 37;
					o0_o_o_.OoO00_0_._0.(this.DataCol.DropDownHeight);
					IL_232:
					num2 = 38;
					o0_o_o_.o_.O_.(this.DataCol.MaxDropDownItems);
					IL_247:
					num2 = 39;
					column.Editor = o0_o_o_;
					goto IL_3E1;
					IL_257:
					num2 = 41;
					if (Operators.CompareString(value, "", true) != 0)
					{
						goto IL_295;
					}
					IL_268:
					num2 = 42;
					if (column.Editor == null || !(column.Editor is O0_0_0_Oo_o))
					{
						goto IL_3E1;
					}
					IL_286:
					num2 = 43;
					column.Editor = null;
					goto IL_3E1;
					IL_295:
					num2 = 45;
					if (!(column.Editor is O0_0_0_Oo_o))
					{
						goto IL_2C6;
					}
					IL_2A5:
					num2 = 46;
					O0_0_0_Oo_o o0_0_0_Oo_o = (O0_0_0_Oo_o)column.Editor;
					IL_2B5:
					num2 = 47;
					o0_0_0_Oo_o.OO.0oo.().Clear();
					goto IL_2D0;
					IL_2C6:
					num2 = 49;
					o0_0_0_Oo_o = new O0_0_0_Oo_o();
					IL_2D0:
					num2 = 50;
					string[] array = value.Split(new char[]
					{
						'\n',
						'\r',
						'|'
					}, StringSplitOptions.RemoveEmptyEntries);
					IL_2ED:
					num2 = 51;
					o0_0_0_Oo_o.OO.0oo.().AddRange(array);
					IL_2FE:
					num2 = 52;
					if (!this.AllowTypeAssistant || !this.AllowDirectType)
					{
						goto IL_348;
					}
					IL_311:
					num2 = 53;
					o0_0_0_Oo_o.AutoCompleteSource = AutoCompleteSource.CustomSource;
					IL_31D:
					num2 = 54;
					o0_0_0_Oo_o.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
					IL_328:
					num2 = 55;
					o0_0_0_Oo_o.AutoCompleteCustomSource.Clear();
					IL_337:
					num2 = 56;
					o0_0_0_Oo_o.AutoCompleteCustomSource.AddRange(array);
					IL_348:
					num2 = 57;
					o0_0_0_Oo_o.oO_0.__oO0_000.(this.AllowDirectType);
					IL_358:
					num2 = 58;
					o0_0_0_Oo_o.OO00_.O_.(this.DataCol.MultiColumn);
					IL_36D:
					num2 = 59;
					o0_0_0_Oo_o.oO_0.__oO0_000.(this.DataCol.ColumnWidth);
					IL_382:
					num2 = 60;
					o0_0_0_Oo_o.o.ooo.(this.DataCol.DropDownWidth);
					IL_397:
					num2 = 61;
					o0_0_0_Oo_o.O.0_0_.(this.DataCol.DropDownHeight);
					IL_3AC:
					num2 = 62;
					o0_0_0_Oo_o.O.00o0o_.(this.DataCol.MaxDropDownItems);
					IL_3C1:
					num2 = 63;
					o0_0_0_Oo_o.OoOo__.o.(this.DataCol.ItemSpacing);
					IL_3D6:
					num2 = 64;
					column.Editor = o0_0_0_Oo_o;
					IL_3E1:
					goto IL_537;
					IL_3E6:
					int num3 = num4 + 1;
					num4 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
					IL_4F8:
					goto IL_52C;
					IL_4FA:
					num4 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_50A:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_4FA;
				}
				IL_52C:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_537:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		/// <summary>
		/// 是否允许用户输入非列表项目中的内容
		/// </summary>
		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x0012F1A0 File Offset: 0x0012D3A0
		// (set) Token: 0x06002AB4 RID: 10932 RVA: 0x0012F1D3 File Offset: 0x0012D3D3
		[oO0oooo("1784")]
		public bool AllowDirectType
		{
			get
			{
				bool result;
				if (this.o0O0oO.0. == BooleanEnum.Default)
				{
					result = this.DataCol.AllowEditValue;
				}
				else
				{
					result = (this.o0O0oO.0. == BooleanEnum.True);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.o0O0oO.0. = BooleanEnum.True;
					return;
				}
				this.o0O0oO.0. = BooleanEnum.False;
			}
		}

		/// <summary>
		/// 是否开启输入助手
		/// </summary>
		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x0012F1E8 File Offset: 0x0012D3E8
		// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x0012F21B File Offset: 0x0012D41B
		[oO0oooo("1785")]
		public bool AllowTypeAssistant
		{
			get
			{
				bool result;
				if (this.o0OO_.O00___. == BooleanEnum.Default)
				{
					result = this.DataCol.AutoComplete;
				}
				else
				{
					result = (this.o0OO_.O00___. == BooleanEnum.True);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.o0OO_.O00___. = BooleanEnum.True;
					return;
				}
				this.o0OO_.O00___. = BooleanEnum.False;
			}
		}

		/// <summary>
		/// 是否使用内置输入器
		/// </summary>
		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x0012F230 File Offset: 0x0012D430
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x0012F263 File Offset: 0x0012D463
		[oO0oooo("1783")]
		public bool UsetBuildInEditor
		{
			get
			{
				bool result;
				if (this.oOoO00.o. == BooleanEnum.Default)
				{
					result = this.DataCol.UsetBuildInEditor;
				}
				else
				{
					result = (this.oOoO00.o. == BooleanEnum.True);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.oOoO00.o. = BooleanEnum.True;
				}
				else
				{
					this.oOoO00.o. = BooleanEnum.False;
				}
				this.oo_0_oO._.();
			}
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0012F280 File Offset: 0x0012D480
		public void ResetAutoCompleteSource()
		{
			Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
			if (column.Editor != null && column.Editor is O0_0_0_Oo_o)
			{
				O0_0_0_Oo_o o0_0_0_Oo_o = (O0_0_0_Oo_o)column.Editor;
				if (o0_0_0_Oo_o.AutoCompleteMode != AutoCompleteMode.None)
				{
					List<string> list = new List<string>();
					o0_0_0_Oo_o.AutoCompleteCustomSource.Clear();
					if (o0_0_0_Oo_o.O___0oO__.0oO.() != null)
					{
						DataView dataView = (DataView)o0_0_0_Oo_o.O___0oO__.0oO.();
						int num = dataView.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							if (!dataView[i].Row.IsNull(o0_0_0_Oo_o.oO_0.__oO0_000.()))
							{
								list.Add(dataView[i][o0_0_0_Oo_o.oO_0.__oO0_000.()].ToString());
							}
						}
					}
					else
					{
						try
						{
							foreach (object value in o0_0_0_Oo_o.OO.0oo.())
							{
								string item = Conversions.ToString(value);
								list.Add(item);
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
					o0_0_0_Oo_o.AutoCompleteCustomSource.AddRange(list.ToArray());
				}
			}
		}

		/// <summary>
		/// 打开列窗口
		/// </summary>
		/// <param name="size">列窗口宽度</param>
		// Token: 0x06002ABA RID: 10938 RVA: 0x0012F3C0 File Offset: 0x0012D5C0
		[oO0oooo("0585")]
		public void OpenWindow(int size = 0)
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
				if (this.Name.StartsWith("~") || this.Name.IndexOf(".") >= 0)
				{
					goto IL_1AC;
				}
				IL_34:
				num2 = 4;
				if (this.o_o_O.0000_O. == null)
				{
					goto IL_58;
				}
				IL_3E:
				num2 = 5;
				if (this.o_o_O.0000_O..FindForm() != null)
				{
					goto IL_1AC;
				}
				IL_50:
				num2 = 8;
				this.CloseWindow();
				IL_58:
				num2 = 9;
				this.o_o_O.0000_O. = this.oo_0_oO._.();
				IL_67:
				num2 = 10;
				if (this.o_o_O.0000_O. == null)
				{
					goto IL_1AC;
				}
				IL_75:
				num2 = 12;
				string text = this.Table.Name;
				IL_85:
				num2 = 13;
				if (text.IndexOf(".") <= 0)
				{
					goto IL_B0;
				}
				IL_97:
				num2 = 14;
				text = text.Substring(0, text.IndexOf("."));
				IL_B0:
				num2 = 15;
				o_O0_0O0 o_O0_0O;
				switch (this.DataCol.DockArea)
				{
				case DockAreaEnum.底:
					IL_D7:
					num2 = 17;
					o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[text]).O._o_00__.();
					break;
				case DockAreaEnum.左:
					IL_FD:
					num2 = 19;
					o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[text]).O__O.o_oOO.();
					break;
				case DockAreaEnum.上:
					IL_123:
					num2 = 21;
					o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[text]).O_000__.o.();
					break;
				default:
					IL_149:
					num2 = 23;
					o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[text]).o__0_.o0OoOOO.();
					break;
				}
				IL_16D:
				num2 = 25;
				if (size <= 0)
				{
					goto IL_17E;
				}
				IL_174:
				num2 = 26;
				o_O0_0O.OoOoo_O0o0.0O_.(size);
				IL_17E:
				num2 = 27;
				o_O0_0O.OO_o0_oO.0.(this.o_o_O.0000_O., this.Caption, this.DataCol.DockTitle, this.Icon, this.DataCol, true);
				IL_1AC:
				goto IL_26E;
				IL_1B1:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_22F:
				goto IL_263;
				IL_231:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_241:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_231;
			}
			IL_263:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_26E:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 关闭列窗口
		/// </summary>
		// Token: 0x06002ABB RID: 10939 RVA: 0x0012F660 File Offset: 0x0012D860
		[oO0oooo("0586")]
		public void CloseWindow()
		{
			if (this.o_o_O.0000_O. != null)
			{
				System.Windows.Forms.Control parent = this.o_o_O.0000_O..Parent;
				this.o_o_O.0000_O..DataBindings.Clear();
				while (parent != null && !(parent is FormPanel))
				{
					if (parent is o_O0_0O0)
					{
						((o_O0_0O0)parent).o_o.O___0o.(this.o_o_O.0000_O.);
						break;
					}
					parent = parent.Parent;
				}
				this.o_o_O.0000_O..Dispose();
			}
		}

		/// <summary>
		/// 是否是日期时间列
		/// </summary>
		// Token: 0x06002ABC RID: 10940 RVA: 0x0012F6CB File Offset: 0x0012D8CB
		public bool IsDate()
		{
			return this.DataCol.IsDate;
		}

		/// <summary>
		/// 是否是数值列
		/// </summary>
		// Token: 0x06002ABD RID: 10941 RVA: 0x0012F6D8 File Offset: 0x0012D8D8
		public bool IsNumeric()
		{
			return this.DataCol.IsNumeric;
		}

		/// <summary>
		/// 是否是逻辑列
		/// </summary>
		// Token: 0x06002ABE RID: 10942 RVA: 0x0012F6E5 File Offset: 0x0012D8E5
		public bool IsBoolean()
		{
			return this.DataCol.IsBoolean;
		}

		/// <summary>
		/// 是否是字符串列
		/// </summary>
		// Token: 0x06002ABF RID: 10943 RVA: 0x0012F6F2 File Offset: 0x0012D8F2
		public bool IsString()
		{
			return this.DataCol.IsString;
		}

		/// <summary>
		/// 设置图形字典后，是否同时显示图片和文本
		/// </summary>
		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x0012F6FF File Offset: 0x0012D8FF
		// (set) Token: 0x06002AC1 RID: 10945 RVA: 0x0012F721 File Offset: 0x0012D921
		[oO0oooo("0584")]
		public bool ImageAndText
		{
			get
			{
				return this.Table.foxGrid.Cols[this.o_o_O.0000_O.].ImageAndText;
			}
			set
			{
				this.Table.foxGrid.Cols[this.o_o_O.0000_O.].ImageAndText = value;
			}
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x0012F744 File Offset: 0x0012D944
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.o_o_O.0000_O. = A_0;
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x0012F74D File Offset: 0x0012D94D
		internal string DataTableName
		{
			get
			{
				return this.o_o_O.0000_O..View.o_o.O0ooOo.().TableName;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x0012F764 File Offset: 0x0012D964
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x0012F786 File Offset: 0x0012D986
		internal bool AllowMerging
		{
			get
			{
				return this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].AllowMerging;
			}
			set
			{
				this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].AllowMerging = value;
			}
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x0012F7AC File Offset: 0x0012D9AC
		internal bool <<EMPTY_NAME>>()
		{
			bool result;
			if (this.Table.TableType == TableTypeEnum.Normal && !this.Table.IsCopy)
			{
				if (this.o_o_O.0000_O..Cols[this.o_o_O.0000_O.].IsString() && this.DataCol.ExtendColumnType == ExtendColumnTypeEnum.无 && (this.o_o_O.0000_O..View.o_o.O0ooOo.().Columns[this.o_o_O.0000_O.].MaxLength > 255 || this.o_o_O.0000_O..View.o_o.O0ooOo.().Columns[this.o_o_O.0000_O.].MaxLength == -1))
				{
					result = true;
				}
				else if (this.o_o_O.0000_O..Cols[this.o_o_O.0000_O.].IsString() && this.DataCol.ExtendColumnType == ExtendColumnTypeEnum.图片)
				{
					result = true;
				}
				else if (this.o_o_O.0000_O..Cols[this.o_o_O.0000_O.].IsString() && this.DataCol.ExtendColumnType == ExtendColumnTypeEnum.多文件)
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x0012F8B8 File Offset: 0x0012DAB8
		internal System.Windows.Forms.Control <<EMPTY_NAME>>()
		{
			int num2;
			System.Windows.Forms.Control result;
			int num4;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				if (this.o_o_O.0000_O..TableType != TableTypeEnum.Normal || this.o_o_O.0000_O..IsCopy)
				{
					goto IL_2AD;
				}
				IL_22:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_29:
				num = 3;
				if (!this.IsString() || this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.无 || (this.o_o_O.0000_O..View.o_o.O0ooOo.().Columns[this.o_o_O.0000_O.].MaxLength <= 255 && this.o_o_O.0000_O..View.o_o.O0ooOo.().Columns[this.o_o_O.0000_O.].MaxLength != -1))
				{
					goto IL_F6;
				}
				IL_9A:
				num = 4;
				O__o o__o = new O__o();
				IL_A3:
				num = 5;
				Font font = this.Table.Grid.Font;
				IL_B7:
				num = 6;
				o__o.Font = new Font("微软雅黑", font.Size + 1f);
				IL_D7:
				num = 7;
				o__o.o__0_o0.OOO_.(this.Table, this.o_o_O.0000_O.);
				IL_EC:
				num = 8;
				result = o__o;
				goto IL_2B2;
				IL_F6:
				num = 9;
				if (!this.IsString() || this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.图片)
				{
					goto IL_1D3;
				}
				IL_115:
				num = 10;
				PictureViewer pictureViewer = new PictureViewer();
				IL_11F:
				num = 11;
				pictureViewer.DataBindings.Add("ImageFiles", this.Table.View, this.o_o_O.0000_O.);
				IL_145:
				num = 12;
				pictureViewer.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.Never;
				IL_15B:
				num = 13;
				pictureViewer.AutoDownLoad = this.DataCol.AutoDownload;
				IL_170:
				num = 14;
				pictureViewer.AutoUpdate = this.DataCol.AutoUpdate;
				IL_185:
				num = 15;
				if (!this.DataCol.Remote)
				{
					goto IL_1B3;
				}
				IL_195:
				num = 16;
				if (this.DataCol.FTPClient != null)
				{
					goto IL_1B3;
				}
				IL_1A5:
				num = 17;
				this.DataCol.o_.Oo00_O_00_.();
				IL_1B3:
				num = 18;
				pictureViewer.FTPclient = this.DataCol.FTPClient;
				IL_1C8:
				num = 19;
				result = pictureViewer;
				goto IL_2B2;
				IL_1D3:
				num = 20;
				if (!this.o_o_O.0000_O..Cols[this.o_o_O.0000_O.].IsString() || this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.多文件)
				{
					goto IL_2AD;
				}
				IL_207:
				num = 21;
				FileManager fileManager = new FileManager();
				IL_211:
				num = 22;
				fileManager.DataBindings.Add("FileString", this.Table.View, this.o_o_O.0000_O.);
				IL_237:
				num = 23;
				fileManager.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.Never;
				IL_24D:
				num = 24;
				if (!this.DataCol.Remote)
				{
					goto IL_27B;
				}
				IL_25D:
				num = 25;
				if (this.DataCol.FTPClient != null)
				{
					goto IL_27B;
				}
				IL_26D:
				num = 26;
				this.DataCol.o_.Oo00_O_00_.();
				IL_27B:
				num = 27;
				fileManager.FTPclient = this.DataCol.FTPClient;
				IL_290:
				num = 28;
				fileManager.AutoUpdate = this.DataCol.AutoUpdate;
				IL_2A5:
				num = 29;
				result = fileManager;
				goto IL_2B2;
				IL_2AD:
				num = 30;
				result = null;
				IL_2B2:
				goto IL_380;
				IL_2B7:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_341:
				goto IL_375;
				IL_343:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_353:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_343;
			}
			IL_375:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_380:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 设置下拉目录树
		/// </summary>
		// Token: 0x17000980 RID: 2432
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x0012FC6C File Offset: 0x0012DE6C
		[oO0oooo("2031")]
		public BuildInDropTree DropTree
		{
			set
			{
				Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
				if (value == null)
				{
					if (column.Editor is BuildInDropTree)
					{
						column.Editor = null;
						this.oo_0_oO._.();
						return;
					}
				}
				else
				{
					column.Editor = value;
					value.AllowEditValue = this.AllowDirectType;
				}
			}
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x0012FCC8 File Offset: 0x0012DEC8
		internal void <<EMPTY_NAME>>()
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
				IL_25:
				num2 = 3;
				this.O_00_o.__. = BooleanEnum.Default;
				IL_2E:
				num2 = 4;
				column.DataMap = null;
				IL_37:
				num2 = 5;
				column.ImageMap = null;
				IL_40:
				num2 = 6;
				column.Editor = null;
				IL_49:
				num2 = 7;
				column.EditMask = null;
				IL_52:
				num2 = 8;
				column.Format = null;
				IL_5B:
				num2 = 9;
				column.Editor = null;
				IL_65:
				num2 = 10;
				this.CodeDictonary = this.DataCol.oO0._00o_0.;
				IL_79:
				num2 = 11;
				if (this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.时段)
				{
					goto IL_9D;
				}
				IL_8A:
				num2 = 12;
				column.Editor = O_O0OO.OoO.0OO__0ooo.();
				goto IL_4A0;
				IL_9D:
				num2 = 14;
				if (this.DataCol.oO0._00o_0. != null)
				{
					goto IL_42E;
				}
				IL_B0:
				num2 = 15;
				this.DisplayMember = this.DataCol.DisplayMember;
				IL_C4:
				num2 = 16;
				this.ValueMember = this.DataCol.ValueMember;
				IL_D8:
				num2 = 17;
				this.DataFilter = this.DataCol.DataFilter;
				IL_EC:
				num2 = 18;
				this.DataSort = this.DataCol.DataSort;
				IL_100:
				num2 = 19;
				this.oO0OO.oO. = "";
				IL_10E:
				num2 = 20;
				if (Operators.CompareString(this.DataCol.DataSource, "", true) <= 0)
				{
					goto IL_13E;
				}
				IL_12A:
				num2 = 21;
				this.DataSource = this.DataCol.DataSource;
				IL_13E:
				num2 = 22;
				if (column.Editor != null)
				{
					goto IL_3CF;
				}
				IL_14C:
				num2 = 23;
				BuildInDropTree buildInDropTree = null;
				IL_152:
				num2 = 24;
				if (Operators.CompareString(this.DataCol.TreeFile, "", true) <= 0 || Operators.CompareString(this.DataCol.TreeReceiveCols, "", true) <= 0)
				{
					goto IL_24A;
				}
				IL_18D:
				num2 = 25;
				string text = ooO.OoO0o_o___.O.(this.DataCol.TreeFile);
				IL_1A2:
				num2 = 26;
				if (OO_00oOO.FileSys.FileExists(text))
				{
					goto IL_21F;
				}
				IL_1B3:
				num2 = 27;
				MessageBox.Show(string.Concat(new string[]
				{
					"[",
					this.Table.DataTable.Name,
					"]的[",
					this.Name,
					"]调用的目录树文件\"",
					OO_00oOO.FileSys.GetName(text),
					"\"不存在！"
				}), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_2EC;
				IL_21F:
				num2 = 29;
				buildInDropTree = new BuildInDropTree(ooO.OoO0o_o___.O.(this.DataCol.TreeFile), this.DataCol.TreeReceiveCols, true);
				goto IL_2EC;
				IL_24A:
				num2 = 31;
				if (Operators.CompareString(this.DataCol.TreeSourceTable, "", true) <= 0 || Operators.CompareString(this.DataCol.TreeReceiveCols, "", true) <= 0 || Operators.CompareString(this.DataCol.TreeBuildCols, "", true) <= 0)
				{
					goto IL_2EC;
				}
				IL_29B:
				num2 = 32;
				buildInDropTree = new BuildInDropTree(this.DataCol.TreeSourceTable, this.DataCol.TreeBuildCols, this.DataCol.TreeSourceCols, this.DataCol.TreeReceiveCols, this.DataCol.TreePathSeparator, this.DataCol.TreeFilter, "");
				IL_2EC:
				num2 = 33;
				if (buildInDropTree == null)
				{
					goto IL_3CF;
				}
				IL_2F6:
				num2 = 34;
				if (this.DataCol.DropDownWidth <= 0)
				{
					goto IL_321;
				}
				IL_307:
				num2 = 35;
				buildInDropTree.Ooo._0oO..Width = this.DataCol.DropDownWidth;
				IL_321:
				num2 = 36;
				if (this.DataCol.DropDownHeight <= 0)
				{
					goto IL_34C;
				}
				IL_332:
				num2 = 37;
				buildInDropTree.Ooo._0oO..Height = this.DataCol.DropDownHeight;
				IL_34C:
				num2 = 38;
				buildInDropTree.Ooo._0oO..OooOoOo_.o. = this.DataCol.TreePathSeparator;
				IL_366:
				num2 = 39;
				buildInDropTree.Ooo._0oO..O0ooOO_o0.00. = this.DataCol.TreeContentSeparator;
				IL_380:
				num2 = 40;
				buildInDropTree.Ooo._0oO..OooOoOo_.o. = this.DataCol.TreeSeparateContent;
				IL_39A:
				num2 = 41;
				buildInDropTree.AllowEditValue = this.AllowDirectType;
				IL_3AA:
				num2 = 42;
				buildInDropTree.Font = this.Table.Grid.Font;
				IL_3C4:
				num2 = 43;
				column.Editor = buildInDropTree;
				IL_3CF:
				num2 = 44;
				if (column.Editor != null)
				{
					goto IL_40A;
				}
				IL_3DA:
				num2 = 45;
				if (Operators.CompareString(this.DataCol.ComboList, "", true) <= 0)
				{
					goto IL_40A;
				}
				IL_3F6:
				num2 = 46;
				this.ComboList = this.DataCol.ComboList;
				IL_40A:
				num2 = 47;
				if (column.Editor == null)
				{
					goto IL_4A0;
				}
				IL_418:
				num2 = 48;
				this.DataCol.oO0._00o_0. = column.Editor;
				goto IL_4A0;
				IL_42E:
				num2 = 50;
				this.Oo_O.00o. = this.DataCol.DisplayMember;
				IL_442:
				num2 = 51;
				this.o__0_O.o_. = this.DataCol.ValueMember;
				IL_456:
				num2 = 52;
				this.o0.OO. = this.DataCol.DataFilter;
				IL_46A:
				num2 = 53;
				this.o0._O_Oo_ooOO. = this.DataCol.DataSort;
				IL_47E:
				num2 = 54;
				this.oO0OO.oO. = "";
				IL_48C:
				num2 = 55;
				column.Editor = this.DataCol.oO0._00o_0.;
				IL_4A0:
				num2 = 56;
				if (!this.o_o_O.0000_O..Cols[this.o_o_O.0000_O.].IsBoolean())
				{
					goto IL_4D9;
				}
				IL_4C0:
				num2 = 57;
				column.Format = this.DataCol.BooleanFormat;
				goto IL_8D2;
				IL_4D9:
				num2 = 59;
				if (!this.o_o_O.0000_O..Cols[this.o_o_O.0000_O.].IsDate())
				{
					goto IL_512;
				}
				IL_4F9:
				num2 = 60;
				this.SetDateTimeFormat(this.DataCol.DateTimeFormat);
				goto IL_8D2;
				IL_512:
				num2 = 62;
				if ((this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.图片 && this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.文件 && this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.多文件) || this.o_o_O.0000_O..View.o_o.O0ooOo.().Columns[this.o_o_O.0000_O.].DataType != typeof(string))
				{
					goto IL_583;
				}
				IL_570:
				num2 = 63;
				column.ComboList = "|...";
				goto IL_8D2;
				IL_583:
				num2 = 65;
				if (this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.色彩 || this.o_o_O.0000_O..View.o_o.O0ooOo.().Columns[this.o_o_O.0000_O.].DataType != typeof(int))
				{
					goto IL_5D8;
				}
				IL_5C5:
				num2 = 66;
				column.ComboList = "...";
				goto IL_8D2;
				IL_5D8:
				num2 = 68;
				if ((this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.邮件 && this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.网址 && this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.QQ && this.DataCol.ExtendColumnType != ExtendColumnTypeEnum.旺旺) || this.o_o_O.0000_O..View.o_o.O0ooOo.().Columns[this.o_o_O.0000_O.].DataType != typeof(string))
				{
					goto IL_659;
				}
				IL_646:
				num2 = 69;
				column.ComboList = "|...";
				goto IL_8D2;
				IL_659:
				num2 = 71;
				if (!this.o_o_O.0000_O..Cols[this.o_o_O.0000_O.].IsNumeric() || this.DataCol.ExtendColumnType == ExtendColumnTypeEnum.时段)
				{
					goto IL_8BE;
				}
				IL_68D:
				num2 = 72;
				string text2 = "";
				IL_697:
				num2 = 73;
				if (!this.DataCol.ShowCurrencySymbol)
				{
					goto IL_6D3;
				}
				IL_6A7:
				num2 = 74;
				text2 = this.DataCol.CurrencySymbol;
				IL_6B7:
				num2 = 75;
				if (Operators.CompareString(text2, "", true) != 0)
				{
					goto IL_6D3;
				}
				IL_6C9:
				num2 = 76;
				text2 = "￥";
				IL_6D3:
				num2 = 77;
				if (!this.DataCol.ThousandSeparator)
				{
					goto IL_72D;
				}
				IL_6E3:
				num2 = 78;
				if (this.DataCol.FixedDigits != 0)
				{
					goto IL_706;
				}
				IL_6F3:
				num2 = 79;
				text2 += "#,0";
				goto IL_76E;
				IL_706:
				num2 = 81;
				text2 = text2 + new string('0', this.DataCol.FixedDigits - 1) + ",0)";
				goto IL_76E;
				IL_72D:
				num2 = 83;
				if (this.DataCol.FixedDigits != 0)
				{
					goto IL_750;
				}
				IL_73D:
				num2 = 84;
				text2 += "#0";
				goto IL_76E;
				IL_750:
				num2 = 86;
				text2 += new string('0', this.DataCol.FixedDigits);
				IL_76E:
				num2 = 87;
				if (!(column.DataType == typeof(float) | column.DataType == typeof(double)) && column.DataType != typeof(decimal))
				{
					goto IL_85F;
				}
				IL_7AD:
				num2 = 88;
				if (this.DataCol.Decimals <= 0)
				{
					goto IL_85F;
				}
				IL_7C1:
				num2 = 89;
				if (!this.DataCol.FixedDecimals)
				{
					goto IL_83C;
				}
				IL_7D1:
				num2 = 90;
				if (!this.DataCol.PercentStyle)
				{
					goto IL_817;
				}
				IL_7E1:
				num2 = 91;
				int num3 = this.DataCol.Decimals - 2;
				IL_7F3:
				num2 = 92;
				if (num3 <= 0)
				{
					goto IL_85F;
				}
				IL_7FB:
				num2 = 93;
				text2 = text2 + "." + new string('0', num3);
				goto IL_85F;
				IL_817:
				num2 = 95;
				text2 = text2 + "." + new string('0', this.DataCol.Decimals);
				goto IL_85F;
				IL_83C:
				num2 = 97;
				text2 = text2 + "." + new string('#', this.DataCol.Decimals);
				IL_85F:
				num2 = 98;
				if (!this.DataCol.PercentStyle)
				{
					goto IL_880;
				}
				IL_86F:
				num2 = 99;
				text2 += "%";
				IL_880:
				num2 = 100;
				if (!this.UsetBuildInEditor)
				{
					goto IL_8B1;
				}
				IL_88B:
				num2 = 101;
				column.Editor = O_O0OO.OoO.0OO__0ooo.();
				IL_899:
				num2 = 102;
				((OO__oo_0ooo0_)column.Editor).CustomFormat = "";
				IL_8B1:
				num2 = 103;
				column.Format = text2;
				goto IL_8D2;
				IL_8BE:
				num2 = 105;
				column.EditMask = this.DataCol.EditMask;
				IL_8D2:
				num2 = 106;
				if (this.DataCol.ExtendColumnType == ExtendColumnTypeEnum.多值字段)
				{
					goto IL_947;
				}
				IL_8E3:
				num2 = 107;
				column.DataMap = this.DataCol.DataDictionary;
				IL_8F7:
				num2 = 108;
				column.ImageMap = this.DataCol.imageDictionary;
				IL_90B:
				num2 = 109;
				if (!(Operators.CompareString(this.DataCol.ComboList, "", true) == 0 & column.ImageMap != null))
				{
					goto IL_947;
				}
				IL_933:
				num2 = 110;
				column.ComboList = this.DataCol.imageValues;
				IL_947:
				num2 = 111;
				this.TextAlign = this.DataCol.TextAlign;
				IL_95B:
				num2 = 112;
				this.TextAlignFixed = this.DataCol.TextAlignFixed;
				IL_96F:
				num2 = 113;
				if (column.Editor != null || Operators.CompareString(column.ComboList, "", true) != 0 || column.DataMap != null || column.ImageMap != null || column.DataType == typeof(bool))
				{
					goto IL_9BD;
				}
				IL_9AF:
				num2 = 114;
				column.Editor = O_O0OO.OoO.0OO__0ooo.();
				IL_9BD:
				num2 = 115;
				if (column.ImageMap == null)
				{
					goto IL_9DE;
				}
				IL_9C8:
				num2 = 116;
				column.ImageAndText = this.DataCol.ImageAndText;
				goto IL_9E8;
				IL_9DE:
				num2 = 118;
				column.ImageAndText = true;
				IL_9E8:
				goto IL_C16;
				IL_9ED:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_BD7:
				goto IL_C0B;
				IL_BD9:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_BE9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_BD9;
			}
			IL_C0B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_C16:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 设置列中数据对齐方式
		/// </summary>
		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x00130910 File Offset: 0x0012EB10
		// (set) Token: 0x06002ACB RID: 10955 RVA: 0x0013095C File Offset: 0x0012EB5C
		[oO0oooo("1786")]
		public TextAlignEnum TextAlign
		{
			get
			{
				TextAlignEnum textAlign = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].TextAlign;
				TextAlignEnum result;
				if (textAlign != TextAlignEnum.LeftCenter)
				{
					if (textAlign != TextAlignEnum.CenterCenter)
					{
						if (textAlign != TextAlignEnum.RightCenter)
						{
							result = TextAlignEnum.Default;
						}
						else
						{
							result = TextAlignEnum.Right;
						}
					}
					else
					{
						result = TextAlignEnum.Center;
					}
				}
				else
				{
					result = TextAlignEnum.Left;
				}
				return result;
			}
			set
			{
				if (!this.Table.GridTreeVisible || Operators.CompareString(this.Table.OO0o_o0.0oOo0o., this.o_o_O.0000_O., true) != 0 || value == TextAlignEnum.Left)
				{
					Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
					switch (value)
					{
					case TextAlignEnum.Default:
						if (column.DataType == typeof(string) || column.DataType == typeof(DateTime) || column.DataType == typeof(bool))
						{
							column.TextAlign = TextAlignEnum.LeftCenter;
							return;
						}
						if (this.DataCol.ExtendColumnType == ExtendColumnTypeEnum.时段)
						{
							column.TextAlign = TextAlignEnum.LeftCenter;
							return;
						}
						column.TextAlign = TextAlignEnum.RightCenter;
						return;
					case TextAlignEnum.Left:
						column.TextAlign = TextAlignEnum.LeftCenter;
						return;
					case TextAlignEnum.Center:
						column.TextAlign = TextAlignEnum.CenterCenter;
						return;
					case TextAlignEnum.Right:
						column.TextAlign = TextAlignEnum.RightCenter;
						break;
					default:
						return;
					}
				}
			}
		}

		/// <summary>
		/// 设置列标题对齐方式
		/// </summary>
		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06002ACC RID: 10956 RVA: 0x00130A40 File Offset: 0x0012EC40
		// (set) Token: 0x06002ACD RID: 10957 RVA: 0x00130A8C File Offset: 0x0012EC8C
		[oO0oooo("1787")]
		public TextAlignEnum TextAlignFixed
		{
			get
			{
				TextAlignEnum textAlignFixed = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].TextAlignFixed;
				TextAlignEnum result;
				if (textAlignFixed != TextAlignEnum.LeftCenter)
				{
					if (textAlignFixed != TextAlignEnum.CenterCenter)
					{
						if (textAlignFixed != TextAlignEnum.RightCenter)
						{
							result = TextAlignEnum.Default;
						}
						else
						{
							result = TextAlignEnum.Right;
						}
					}
					else
					{
						result = TextAlignEnum.Center;
					}
				}
				else
				{
					result = TextAlignEnum.Left;
				}
				return result;
			}
			set
			{
				Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
				switch (value)
				{
				case TextAlignEnum.Default:
				case TextAlignEnum.Center:
					column.TextAlignFixed = TextAlignEnum.CenterCenter;
					return;
				case TextAlignEnum.Left:
					column.TextAlignFixed = TextAlignEnum.LeftCenter;
					return;
				case TextAlignEnum.Right:
					column.TextAlignFixed = TextAlignEnum.RightCenter;
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x00130AE8 File Offset: 0x0012ECE8
		private void <<EMPTY_NAME>>()
		{
			Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
			if (this.o_o_O.0000_O..Cols[this.o_o_O.0000_O.].IsDate())
			{
				switch (this.DataCol.DateTimeFormat)
				{
				case DateTimeFormatEnum.Date:
					if (this.UsetBuildInEditor)
					{
						column.Editor = O_O0OO.o0_OO.000.();
					}
					else
					{
						column.Editor = O_O0OO.OoO.0OO__0ooo.();
					}
					break;
				case DateTimeFormatEnum.Time:
					column.Editor = O_O0OO.OoO.0OO__0ooo.();
					break;
				case DateTimeFormatEnum.LongTime:
					column.Editor = O_O0OO.o0_OO.000.();
					break;
				}
			}
			else if (this.o_o_O.0000_O..Cols[this.o_o_O.0000_O.].IsNumeric() && this.UsetBuildInEditor)
			{
				column.Editor = O_O0OO.OoO.0OO__0ooo.();
			}
			if (column.Editor == null && Operators.CompareString(column.ComboList, "", true) == 0 && column.DataType != typeof(bool))
			{
				column.Editor = O_O0OO.OoO.0OO__0ooo.();
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x00130BF4 File Offset: 0x0012EDF4
		private Image Icon
		{
			get
			{
				Image image = null;
				if (Operators.CompareString(this.DataCol.CustomImage, "", true) > 0)
				{
					image = OO_00oOO.GetImage(this.DataCol.CustomImage);
				}
				Image result;
				if (image != null)
				{
					result = image;
				}
				else
				{
					if (this.o_o_O.0000_O. != null)
					{
						if (this.o_o_O.0000_O. is O__o)
						{
							return a.Text.ToBitmap();
						}
						if (this.o_o_O.0000_O. is PictureViewer)
						{
							return a.o_O00_0.oooO.().ToBitmap();
						}
						if (this.o_o_O.0000_O. is FileManager)
						{
							return a.O0oOo._.().ToBitmap();
						}
					}
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 列宽
		/// </summary>
		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x00130C8D File Offset: 0x0012EE8D
		// (set) Token: 0x06002AD1 RID: 10961 RVA: 0x00130CAF File Offset: 0x0012EEAF
		[oO0oooo("0566")]
		public int Width
		{
			get
			{
				return this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].Width;
			}
			set
			{
				this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].Width = value;
			}
		}

		/// <summary>
		/// 以毫米为单位的列宽
		/// </summary>
		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x00130CD4 File Offset: 0x0012EED4
		// (set) Token: 0x06002AD3 RID: 10963 RVA: 0x00130D52 File Offset: 0x0012EF52
		[oO0oooo("0567")]
		public double PrintWidth
		{
			get
			{
				double result;
				if (this.Visible)
				{
					result = (double)((float)this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].WidthDisplay / SysInfo.ScreenDpiX) * 25.4;
				}
				else
				{
					result = (double)((float)this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].Width / SysInfo.ScreenDpiX) * 25.4;
				}
				return result;
			}
			set
			{
				this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.].Width = (int)Math.Round((double)SysInfo.ScreenDpiX / 25.4 * value);
			}
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00130D8C File Offset: 0x0012EF8C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetDateTimeFormat(DateTimeFormatEnum format)
		{
			Column column = this.o_o_O.0000_O..foxGrid.Cols[this.o_o_O.0000_O.];
			switch (format)
			{
			case DateTimeFormatEnum.Date:
				column.Format = "yyyy-MM-dd";
				column.EditMask = "0000-00-00";
				if (Operators.CompareString(column.ComboList, "", true) == 0)
				{
					if (this.UsetBuildInEditor)
					{
						column.Editor = O_O0OO.o0_OO.000.();
						return;
					}
					column.Editor = O_O0OO.OoO.0OO__0ooo.();
					return;
				}
				break;
			case DateTimeFormatEnum.Time:
				column.Format = "HH:mm";
				column.EditMask = "00:00";
				if (Operators.CompareString(column.ComboList, "", true) == 0)
				{
					column.Editor = O_O0OO.OoO.0OO__0ooo.();
					return;
				}
				break;
			case DateTimeFormatEnum.LongTime:
				column.Format = "HH:mm:ss";
				column.EditMask = "00:00:00";
				if (Operators.CompareString(column.ComboList, "", true) == 0)
				{
					column.Editor = O_O0OO.o0_OO.000.();
					return;
				}
				break;
			case DateTimeFormatEnum.DateTime:
				column.Format = "yyyy-MM-dd HH:mm";
				column.EditMask = "0000-00-00 00:00";
				if (Operators.CompareString(column.ComboList, "", true) == 0)
				{
					if (this.UsetBuildInEditor)
					{
						column.Editor = O_O0OO.o0_OO.000.();
						return;
					}
					column.Editor = O_O0OO.OoO.0OO__0ooo.();
					return;
				}
				break;
			case DateTimeFormatEnum.DateLongTime:
				column.Format = "yyyy-MM-dd HH:mm:ss";
				column.EditMask = "0000-00-00 00:00:00";
				if (Operators.CompareString(column.ComboList, "", true) == 0)
				{
					if (this.UsetBuildInEditor)
					{
						column.Editor = O_O0OO.o0_OO.000.();
						return;
					}
					column.Editor = O_O0OO.OoO.0OO__0ooo.();
				}
				break;
			default:
				return;
			}
		}

		/// <summary>
		/// 下拉窗口
		/// </summary>
		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x00130F1F File Offset: 0x0012F11F
		// (set) Token: 0x06002AD6 RID: 10966 RVA: 0x00130F28 File Offset: 0x0012F128
		[oO0oooo("2115")]
		public string DropForm
		{
			get
			{
				return this.OO_0._O00_O_o0.;
			}
			set
			{
				this.OO_0._O00_O_o0. = value;
				if (Operators.CompareString(value, "", true) == 0)
				{
					Column column = this.Table.foxGrid.Cols[this.Name];
					if (column.Editor != null && column.Editor is OooO00O)
					{
						((OooO00O)column.Editor).DropDownForm.Controls.Clear();
						column.Editor = null;
					}
					this.oo_0_oO._.();
					return;
				}
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (Conversions.ToInteger(OO_00oOO.Forms[value].O_o_.0o0__o0O.["Type"]) != 233)
					{
						MessageBox.Show(value + "\"不能作为下拉窗口使用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					Column column2 = this.Table.foxGrid.Cols[this.Name];
					OooO00O oooO00O = null;
					if (column2.Editor != null && column2.Editor is OooO00O)
					{
						oooO00O = (OooO00O)column2.Editor;
					}
					if (oooO00O == null)
					{
						oooO00O = new OooO00O();
					}
					oooO00O.OO.o.(value);
					column2.Editor = oooO00O;
					oooO00O.o0O.0___0_.(this.AllowDirectType);
				}
			}
		}

		/// <summary>
		/// 打开下拉列表或下拉窗口
		/// </summary>
		// Token: 0x06002AD7 RID: 10967 RVA: 0x00131058 File Offset: 0x0012F258
		public void OpenDropDown()
		{
			Column column = this.Table.foxGrid.Cols[this.Name];
			if (column.Editor != null && column.Editor is C1DropDownControl && column.Editor.Focused)
			{
				((C1DropDownControl)column.Editor).OpenDropDown();
			}
		}

		/// <summary>
		/// 关闭下拉列表或下拉窗口
		/// </summary>
		// Token: 0x06002AD8 RID: 10968 RVA: 0x001310B4 File Offset: 0x0012F2B4
		public void CloseDropDown()
		{
			Column column = this.Table.foxGrid.Cols[this.Name];
			if (column.Editor != null && column.Editor is C1DropDownControl && this.Table.foxGrid.Editor == column.Editor)
			{
				((C1DropDownControl)column.Editor).CloseDropDown();
			}
		}

		/// <summary>
		/// 下拉列表或下拉窗口是否已经显示
		/// </summary>
		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x0013111C File Offset: 0x0012F31C
		public bool DroppedDown
		{
			get
			{
				Column column = this.Table.foxGrid.Cols[this.Name];
				bool droppedDown;
				if (column.Editor != null && column.Editor is C1DropDownControl)
				{
					droppedDown = ((C1DropDownControl)column.Editor).DroppedDown;
				}
				return droppedDown;
			}
		}

		/// <summary>
		/// 返回此列的文件管理器
		/// </summary>
		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06002ADA RID: 10970 RVA: 0x0013116C File Offset: 0x0012F36C
		[oO0oooo("2469")]
		public FileManager FileManager
		{
			get
			{
				FileManager result;
				if (this.o_o_O.0000_O. != null && this.o_o_O.0000_O. is FileManager)
				{
					result = new FileManager((FileManager)this.o_o_O.0000_O.);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 返回此列的图片管理器
		/// </summary>
		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x001311A4 File Offset: 0x0012F3A4
		[oO0oooo("2470")]
		public PictureViewer PictureViewer
		{
			get
			{
				PictureViewer result;
				if (this.o_o_O.0000_O. != null && this.o_o_O.0000_O. is PictureViewer)
				{
					result = new PictureViewer((PictureViewer)this.o_o_O.0000_O.);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 重新绘制列
		/// </summary>
		// Token: 0x06002ADC RID: 10972 RVA: 0x001311DC File Offset: 0x0012F3DC
		public void Refresh()
		{
			if (this.Table.foxGrid.Cols.Contains(this.Name))
			{
				this.Table.foxGrid.Cols[this.Name].Invalidate();
			}
		}

		// Token: 0x04001190 RID: 4496
		private string <<EMPTY_NAME>>;

		// Token: 0x04001191 RID: 4497
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001192 RID: 4498
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001193 RID: 4499
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001194 RID: 4500
		private string <<EMPTY_NAME>>;

		// Token: 0x04001195 RID: 4501
		private string <<EMPTY_NAME>>;

		// Token: 0x04001196 RID: 4502
		private int <<EMPTY_NAME>>;

		// Token: 0x04001197 RID: 4503
		internal string <<EMPTY_NAME>>;

		// Token: 0x04001198 RID: 4504
		private string <<EMPTY_NAME>>;

		// Token: 0x04001199 RID: 4505
		private string <<EMPTY_NAME>>;

		// Token: 0x0400119A RID: 4506
		private string <<EMPTY_NAME>>;

		// Token: 0x0400119B RID: 4507
		private string <<EMPTY_NAME>>;

		// Token: 0x0400119C RID: 4508
		private string <<EMPTY_NAME>>;

		// Token: 0x0400119D RID: 4509
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x0400119E RID: 4510
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x0400119F RID: 4511
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011A0 RID: 4512
		private string <<EMPTY_NAME>>;

		// Token: 0x040011A1 RID: 4513
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011A2 RID: 4514
		internal System.Windows.Forms.Control <<EMPTY_NAME>>;

		// Token: 0x040011A3 RID: 4515
		internal Dictionary<string, string> <<EMPTY_NAME>>;
	}
}
