using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000319 RID: 793
	[oO0oooo("0593")]
	[ComVisible(true)]
	public class Row
	{
		// Token: 0x06002AF2 RID: 10994 RVA: 0x001316EC File Offset: 0x0012F8EC
		internal Row(Table A_0, int A_1)
		{
			this.oo_.o_O_OO0. = -1;
			this.Table = A_0;
			this.oo_.o_O_OO0. = A_1;
			O_oOooO_O o_oOooO_O = A_0.foxGrid;
			if (o_oOooO_O.Rows[o_oOooO_O.Rows.Fixed + A_1].DataIndex > -1)
			{
				this.oo_.o_O_OO0. = A_0.View.O0O_0_0__.0O.(o_oOooO_O.Rows[o_oOooO_O.Rows.Fixed + A_1].DataIndex);
				this.oo_.o_O_OO0. = this.oo_.o_O_OO0..Row;
			}
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x0013177C File Offset: 0x0012F97C
		internal Row(Table A_0, DataRowView A_1)
		{
			this.oo_.o_O_OO0. = -1;
			this.Table = A_0;
			this.oo_.o_O_OO0. = A_1;
			if (this.oo_.o_O_OO0. != null)
			{
				this.oo_.o_O_OO0. = this.oo_.o_O_OO0..Row;
			}
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x001317B2 File Offset: 0x0012F9B2
		internal Row(Table A_0, DataRow A_1)
		{
			this.oo_.o_O_OO0. = -1;
			this.Table = A_0;
			this.oo_.o_O_OO0. = A_1;
		}

		/// <summary>
		/// 返回该行所属的Table
		/// </summary>
		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x001317CF File Offset: 0x0012F9CF
		// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x001317D7 File Offset: 0x0012F9D7
		[oO0oooo("1585")]
		public Table Table
		{
			get
			{
				return this.oo_.o_O_OO0.;
			}
			private set
			{
				this.oo_.o_O_OO0. = value;
			}
		}

		/// <summary>
		/// 获得Row所对应的DataRow
		/// </summary>
		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x001317E0 File Offset: 0x0012F9E0
		[oO0oooo("0594")]
		public DataRow DataRow
		{
			get
			{
				DataRow result;
				if (this.oo_.o_O_OO0. == null)
				{
					result = null;
				}
				else
				{
					result = new DataRow(this.oo_.o_O_OO0.);
				}
				return result;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x00131806 File Offset: 0x0012FA06
		internal DataRow BaseDataRow
		{
			get
			{
				return this.oo_.o_O_OO0.;
			}
		}

		// Token: 0x17000992 RID: 2450
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string ColumnName]
		{
			get
			{
				object result;
				if (this.oo_.o_O_OO0. == null)
				{
					int row = this.Table.foxGrid.Rows.Fixed + this.oo_.o_O_OO0.;
					object objectValue = RuntimeHelpers.GetObjectValue(this.Table.foxGrid[row, ColumnName]);
					if (objectValue == DBNull.Value)
					{
						result = null;
					}
					else
					{
						result = objectValue;
					}
				}
				else if (this.oo_.o_O_OO0..IsNull(ColumnName))
				{
					Type dataType = this.oo_.o_O_OO0..Table.Columns[ColumnName].DataType;
					if (dataType == typeof(string))
					{
						result = "";
					}
					else if (dataType == typeof(bool))
					{
						result = false;
					}
					else if (dataType == typeof(DateTime))
					{
						result = default(DateTime);
					}
					else
					{
						result = 0;
					}
				}
				else
				{
					if (this.oo_.o_O_OO0..Table.Columns[ColumnName].DataType == typeof(DateTime))
					{
						DateTime dateTime = Conversions.ToDate(this.oo_.o_O_OO0.[ColumnName]);
						switch (OO_00oOO.DataTables[this.oo_.o_O_OO0..Table.TableName].DataCols[ColumnName].DateTimeFormat)
						{
						case DateTimeFormatEnum.Date:
							return dateTime.Date;
						case DateTimeFormatEnum.Time:
							dateTime = new DateTime(dateTime.Ticks - dateTime.Date.Ticks);
							return dateTime.AddSeconds((double)(-(double)dateTime.Second));
						case DateTimeFormatEnum.LongTime:
							return new DateTime(dateTime.Ticks - dateTime.Date.Ticks);
						case DateTimeFormatEnum.DateTime:
							return dateTime.AddSeconds((double)(-(double)dateTime.Second));
						case DateTimeFormatEnum.DateLongTime:
							return dateTime;
						}
					}
					result = this.oo_.o_O_OO0.[ColumnName];
				}
				return result;
			}
			set
			{
				if (value != null && value.GetType() == typeof(DateTime) && DateTime.Compare(Conversions.ToDate(value), DateTime.MinValue) == 0)
				{
					value = null;
				}
				if (!o_O_o_oOoo__.oO.O_..Contains(ColumnName))
				{
					if (this.oo_.o_O_OO0. == null)
					{
						this.Table.foxGrid.SetData(this.oo_.o_O_OO0. + this.Table.foxGrid.Rows.Fixed, ColumnName, RuntimeHelpers.GetObjectValue(value), false);
						return;
					}
					if (value == null)
					{
						value = DBNull.Value;
					}
					if (this.oo_.o_O_OO0..Table.DataSet != O_O0OO.OOOo.oo_OOOO_0.() || Operators.CompareString(ColumnName, OO_00oOO.DataTables[this.oo_.o_O_OO0..Table.TableName].O_.__0., true) != 0)
					{
						if (this.oo_.o_O_OO0..HasVersion(DataRowVersion.Proposed))
						{
							this.oo_.o_O_OO0..EndEdit();
							if (this.oo_.o_O_OO0..HasVersion(DataRowVersion.Proposed))
							{
								return;
							}
						}
						if (string.Compare(this.oo_.o_O_OO0.[ColumnName].ToString(), value.ToString(), false) != 0)
						{
							this.oo_.o_O_OO0.[ColumnName] = RuntimeHelpers.GetObjectValue(value);
						}
					}
				}
			}
		}

		// Token: 0x17000993 RID: 2451
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[Col Column]
		{
			get
			{
				return this[Column.Name];
			}
			set
			{
				this[Column.Name] = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x17000994 RID: 2452
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[int Col]
		{
			get
			{
				O_oOooO_O o_oOooO_O = this.Table.foxGrid;
				return this[o_oOooO_O.Cols[Col + o_oOooO_O.Cols.Fixed].Name];
			}
			set
			{
				O_oOooO_O o_oOooO_O = this.Table.foxGrid;
				this[o_oOooO_O.Cols[Col + o_oOooO_O.Cols.Fixed].Name] = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 判断某列类容是否为空
		/// </summary>
		/// <param name="ColumnName">列名</param>
		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x00131BF4 File Offset: 0x0012FDF4
		[oO0oooo("0595")]
		public bool IsNull
		{
			get
			{
				bool result;
				if (this.oo_.o_O_OO0. == null)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(this.Table.foxGrid[this.Table.foxGrid.Rows.Fixed + this.oo_.o_O_OO0., ColumnName]);
					result = (objectValue == DBNull.Value || objectValue == null);
				}
				else
				{
					result = this.oo_.o_O_OO0..IsNull(ColumnName);
				}
				return result;
			}
		}

		/// <summary>
		/// 判断某列类容是否为空
		/// </summary>
		/// <param name="Col">列位置</param>
		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06002B00 RID: 11008 RVA: 0x00131C5C File Offset: 0x0012FE5C
		[oO0oooo("0595")]
		public bool IsNull
		{
			get
			{
				O_oOooO_O o_oOooO_O = this.Table.foxGrid;
				return this.get_IsNull(o_oOooO_O.Cols[Col + o_oOooO_O.Cols.Fixed].Name);
			}
		}

		/// <summary>
		/// 判断某列类容是否为空
		/// </summary>
		/// <param name="Col">列</param>
		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x00131C98 File Offset: 0x0012FE98
		[oO0oooo("0595")]
		public bool IsNull
		{
			get
			{
				return this.get_IsNull(Col.Name);
			}
		}

		/// <summary>
		/// 判断此行是否是汇总模式下的分组行
		/// </summary>
		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06002B02 RID: 11010 RVA: 0x00131CA6 File Offset: 0x0012FEA6
		[oO0oooo("0596")]
		public bool IsGroup
		{
			get
			{
				return this.oo_.o_O_OO0. == null;
			}
		}

		/// <summary>
		/// 在返回汇总模式下，返回分组行的级别。
		/// </summary>
		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x00131CB4 File Offset: 0x0012FEB4
		[oO0oooo("0598")]
		public int Level
		{
			get
			{
				int result;
				if (this.oo_.o_O_OO0. != null)
				{
					result = int.MinValue;
				}
				else
				{
					int index = this.Table.foxGrid.Rows.Fixed + this.oo_.o_O_OO0.;
					if (this.Table.foxGrid.Rows[index].Node != null)
					{
						result = this.Table.foxGrid.Rows[index].Node.Level;
					}
					else
					{
						result = int.MinValue;
					}
				}
				return result;
			}
		}

		/// <summary>
		/// 在折叠模式下，返回此行的层级
		/// </summary>
		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x00131D38 File Offset: 0x0012FF38
		[oO0oooo("3386")]
		public int Hierarchy
		{
			get
			{
				int result;
				if (!this.Table.GridTreeVisible)
				{
					result = -1;
				}
				else if (this.Table.DataTable.BaseTable.Columns.Contains("sys_Hierarchy_Level"))
				{
					if (!this.oo_.o_O_OO0..IsNull("sys_Hierarchy_Level"))
					{
						result = Conversions.ToInteger(this.oo_.o_O_OO0.["sys_Hierarchy_Level"]);
					}
					else
					{
						result = -1;
					}
				}
				return result;
			}
		}

		/// <summary>
		/// 在折叠模式下，返回或设置此行的折叠状态
		/// </summary>
		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x00131DA4 File Offset: 0x0012FFA4
		// (set) Token: 0x06002B06 RID: 11014 RVA: 0x00131DFC File Offset: 0x0012FFFC
		[oO0oooo("3386")]
		public bool Collapsed
		{
			get
			{
				int row = this.Table.foxGrid.Rows.Fixed + this.Index;
				return this.Table.Grid.GetUserData(row, this.Table.Grid.Cols.Fixed - 1) != null;
			}
			set
			{
				int num = this.Table.foxGrid.Rows.Fixed + this.Index;
				bool flag = this.Table.Grid.GetUserData(num, this.Table.Grid.Cols.Fixed - 1) == null;
				if (value != !flag)
				{
					this.Table.foxGrid.O_._.(num, false, false);
				}
			}
		}

		/// <summary>
		/// 在折叠模式下，判断此行是否有子行
		/// </summary>
		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x00131E6C File Offset: 0x0013006C
		[oO0oooo("3386")]
		public bool HasChild
		{
			get
			{
				if (this.Table.HierarchyData && this.Index < this.Table.View.Count - 1)
				{
					Row row = this.Table.Rows[this.Index + 1];
					if (Conversions.ToInteger(this["sys_Hierarchy_Level"]) < Conversions.ToInteger(row["sys_Hierarchy_Level"]))
					{
						return true;
					}
				}
				return false;
			}
		}

		/// <summary>
		/// 在折叠模式下，获取该行的所有子行。
		/// </summary>
		/// <param name="IncludeSub">默认包括所有直属下级行，如果要包括所有下级行，可将此参数设置为True</param>
		// Token: 0x06002B08 RID: 11016 RVA: 0x00131EE4 File Offset: 0x001300E4
		[oO0oooo("3386")]
		public List<Row> GetChildren(bool IncludeSub = false)
		{
			int num = this.Index + 1;
			int num2 = this.Table.Rows.Count - 1;
			List<Row> list = new List<Row>();
			int num3 = this.Hierarchy + 1;
			if (this.Table.HierarchyData)
			{
				int num4 = num;
				int num5 = num2;
				for (int i = num4; i <= num5; i++)
				{
					int hierarchy = this.Table.Rows[i].Hierarchy;
					if (hierarchy == num3 || (IncludeSub && hierarchy > num3))
					{
						list.Add(this.Table.Rows[i]);
					}
					else if (hierarchy < num3)
					{
						break;
					}
				}
			}
			return list;
		}

		/// <summary>
		/// 在折叠模式下，返回此行对应的父行。
		/// </summary>
		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x00131F84 File Offset: 0x00130184
		[oO0oooo("3386")]
		public Row Parent
		{
			get
			{
				int num = this.Index - 1;
				int num2 = this.Hierarchy - 1;
				for (int i = num; i >= 0; i += -1)
				{
					if (this.Table.Rows[i].Hierarchy == num2)
					{
						return this.Table.Rows[i];
					}
				}
				return null;
			}
		}

		/// <summary>
		/// 在折叠模式下，返回同一级别的上一行。
		/// </summary>
		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06002B0A RID: 11018 RVA: 0x00131FE0 File Offset: 0x001301E0
		[oO0oooo("3386")]
		public Row PrevSlibing
		{
			get
			{
				int index = this.Index;
				int hierarchy = this.Hierarchy;
				for (int i = index - 1; i >= 0; i += -1)
				{
					int hierarchy2 = this.Table.Rows[i].Hierarchy;
					if (hierarchy2 == this.Hierarchy)
					{
						return this.Table.Rows[i];
					}
					if (hierarchy2 < this.Hierarchy)
					{
						break;
					}
				}
				return null;
			}
		}

		/// <summary>
		/// 在折叠模式下，返回同一级别的下一行。
		/// </summary>
		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x00132048 File Offset: 0x00130248
		[oO0oooo("3386")]
		public Row NextSlibing
		{
			get
			{
				int index = this.Index;
				int hierarchy = this.Hierarchy;
				int num = index + 1;
				int num2 = this.Table.Rows.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					int hierarchy2 = this.Table.Rows[i].Hierarchy;
					if (hierarchy2 == this.Hierarchy)
					{
						return this.Table.Rows[i];
					}
					if (hierarchy2 < this.Hierarchy)
					{
						break;
					}
				}
				return null;
			}
		}

		/// <summary>
		/// 在折叠模式下，判断此行是否可见。
		/// </summary>
		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06002B0C RID: 11020 RVA: 0x001320C4 File Offset: 0x001302C4
		[oO0oooo("3386")]
		public bool Visible
		{
			get
			{
				bool result;
				if (!this.Table.GridTreeVisible)
				{
					result = true;
				}
				else
				{
					int num = 1;
					if (this.oo_.o_O_OO0. >= 0)
					{
						num = this.Table.foxGrid.Rows.Fixed + this.oo_.o_O_OO0.;
					}
					else if (this.oo_.o_O_OO0. != null)
					{
						num = this.Table.foxGrid.Rows.Fixed + ((IList)this.oo_.o_O_OO0..DataView).IndexOf(this.oo_.o_O_OO0.);
					}
					if (num >= 0)
					{
						result = this.Table.foxGrid.Rows[num].Visible;
					}
				}
				return result;
			}
		}

		/// <summary>
		/// 设置或者返回行的锁定状态
		/// </summary>
		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x00132164 File Offset: 0x00130364
		// (set) Token: 0x06002B0E RID: 11022 RVA: 0x001321A7 File Offset: 0x001303A7
		[oO0oooo("0597")]
		public bool Locked
		{
			get
			{
				bool result;
				if (this.oo_.o_O_OO0. == null)
				{
					result = false;
				}
				else
				{
					DataRow dataRow = this.oo_.o_O_OO0.;
					result = (!dataRow.IsNull("_Locked") && Conversions.ToBoolean(dataRow["_Locked"]));
				}
				return result;
			}
			set
			{
				if (this.oo_.o_O_OO0. != null)
				{
					new DataRow(this.oo_.o_O_OO0.).Locked = value;
					Main.OO_O.o..O.ooO0. = true;
				}
			}
		}

		/// <summary>
		/// 删除行
		/// </summary>
		// Token: 0x06002B0F RID: 11023 RVA: 0x001321D0 File Offset: 0x001303D0
		[oO0oooo("0599")]
		public bool Delete()
		{
			return this.oo_.o_O_OO0. != null && this.DataRow.Delete();
		}

		/// <summary>
		/// 移除行
		/// </summary>
		// Token: 0x06002B10 RID: 11024 RVA: 0x001321F6 File Offset: 0x001303F6
		[oO0oooo("2736")]
		public void Remove()
		{
			if (this.DataRow != null)
			{
				this.DataRow.Remove();
			}
		}

		/// <summary>
		/// 克隆行
		/// </summary>
		// Token: 0x06002B11 RID: 11025 RVA: 0x0013220C File Offset: 0x0013040C
		[oO0oooo("0600")]
		public Row Clone()
		{
			Row result;
			if (this.oo_.o_O_OO0. == null)
			{
				result = null;
			}
			else
			{
				DataRow dataRow = this.Table.DataTable.NewRow();
				if (dataRow != null)
				{
					try
					{
						foreach (object obj in this.oo_.o_O_OO0..Table.Columns)
						{
							DataColumn dataColumn = (DataColumn)obj;
							if (!o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) && dataRow.get_IsNull(dataColumn.ColumnName))
							{
								dataRow[dataColumn.ColumnName] = RuntimeHelpers.GetObjectValue(this.oo_.o_O_OO0.[dataColumn]);
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
					this.oo_.o_O_OO0..Table.Rows.Add(dataRow.BaseRow);
					if (this.Table.IsCopy)
					{
						int num = this.Table.View.o_o.O0ooOo.(dataRow.BaseRow);
						if (num >= 0)
						{
							this.Table.View.Position = num;
						}
					}
					else
					{
						this.Table.View.Position = this.Table.View.Count - 1;
					}
					result = new Row(this.Table, dataRow.BaseRow);
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00132360 File Offset: 0x00130560
		public bool Equals(Row r1)
		{
			bool result;
			if (r1 == null)
			{
				result = false;
			}
			else if (this.oo_.o_O_OO0. != null)
			{
				result = (this.oo_.o_O_OO0. == r1.oo_.o_O_OO0.);
			}
			else
			{
				result = (r1.oo_.o_O_OO0. == null && this.Table == r1.Table && this.oo_.o_O_OO0. == r1.oo_.o_O_OO0.);
			}
			return result;
		}

		/// <summary>
		/// 返回该行(Row)在表(Table)中的位置
		/// </summary>
		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06002B13 RID: 11027 RVA: 0x001323BC File Offset: 0x001305BC
		[oO0oooo("1539")]
		public int Index
		{
			get
			{
				int result;
				if (this.oo_.o_O_OO0. != null)
				{
					result = ((IList)this.oo_.o_O_OO0..DataView).IndexOf(this.oo_.o_O_OO0.);
				}
				else if (this.oo_.o_O_OO0. >= 0)
				{
					result = this.oo_.o_O_OO0.;
				}
				else if (this.oo_.o_O_OO0. != null)
				{
					result = this.Table.View.o_o.O0ooOo.(this.oo_.o_O_OO0.);
				}
				else
				{
					result = -1;
				}
				return result;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x00132420 File Offset: 0x00130620
		private int GetPosition
		{
			get
			{
				int index = this.Index;
				C1FlexGrid c1FlexGrid = this.Table.foxGrid;
				int @fixed = c1FlexGrid.Rows.Fixed;
				int num = c1FlexGrid.Rows.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					if (c1FlexGrid.Rows[i].DataIndex == index)
					{
						return i;
					}
				}
				return -1;
			}
		}

		/// <summary>
		/// 返回或设置行的复选框是否选中
		/// </summary>
		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x00132488 File Offset: 0x00130688
		// (set) Token: 0x06002B16 RID: 11030 RVA: 0x001324D0 File Offset: 0x001306D0
		[oO0oooo("1638")]
		public bool Checked
		{
			get
			{
				int num = this.GetPosition;
				return num >= this.Table.foxGrid.Rows.Fixed && this.Table.foxGrid.GetCellCheck(num, 0) == CheckEnum.Checked;
			}
			set
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
					if (this.Checked == value)
					{
						goto IL_25A;
					}
					IL_15:
					num2 = 4;
					RowColEventArgs rowColEventArgs = new RowColEventArgs(this.Table, this, null, null);
					IL_26:
					num2 = 5;
					if (this.oo_.o_O_OO0. == null)
					{
						goto IL_25A;
					}
					IL_33:
					num2 = 7;
					string a_ = "BeforeCheckRow";
					IL_3C:
					num2 = 8;
					if (this.Table.o0__OOo0._oO. != null)
					{
						goto IL_84;
					}
					IL_4B:
					num2 = 9;
					O_O0OO.OoO_o.oO0o0O.(this.Table.DataTable.o_0_00_.oo0O0., a_, new object[]
					{
						rowColEventArgs
					}, false, this.Table.DataTable.Name, false);
					goto IL_B6;
					IL_84:
					num2 = 11;
					O_O0OO.OoO_o.oO0o0O.(this.Table.o0__OOo0._oO., a_, new object[]
					{
						rowColEventArgs
					}, false, this.Table.DataTable.Name, false);
					IL_B6:
					num2 = 12;
					if (rowColEventArgs.Cancel || this.Table.foxGrid.FindForm() == null || !this.Table.DataTable.GlobalHandler.BeforeCheckRow)
					{
						goto IL_10B;
					}
					IL_EA:
					num2 = 13;
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						rowColEventArgs
					}, false, "全局表事件", false);
					IL_10B:
					num2 = 14;
					if (rowColEventArgs.Cancel)
					{
						goto IL_25A;
					}
					IL_119:
					num2 = 16;
					int num3 = this.GetPosition;
					IL_124:
					num2 = 17;
					if (num3 < this.Table.foxGrid.Rows.Fixed)
					{
						goto IL_176;
					}
					IL_140:
					num2 = 18;
					if (!value)
					{
						goto IL_15F;
					}
					IL_146:
					num2 = 19;
					this.Table.foxGrid.SetCellCheck(num3, 0, CheckEnum.Checked);
					goto IL_176;
					IL_15F:
					num2 = 21;
					this.Table.foxGrid.SetCellCheck(num3, 0, CheckEnum.Unchecked);
					IL_176:
					num2 = 22;
					rowColEventArgs = new RowColEventArgs(this.Table, this, null, null);
					IL_188:
					num2 = 23;
					a_ = "AfterCheckRow";
					IL_192:
					num2 = 24;
					if (this.Table.o0__OOo0._oO. != null)
					{
						goto IL_1DB;
					}
					IL_1A2:
					num2 = 25;
					O_O0OO.OoO_o.oO0o0O.(this.Table.DataTable.o_0_00_.oo0O0., a_, new object[]
					{
						rowColEventArgs
					}, false, this.Table.DataTable.Name, false);
					goto IL_20D;
					IL_1DB:
					num2 = 27;
					O_O0OO.OoO_o.oO0o0O.(this.Table.o0__OOo0._oO., a_, new object[]
					{
						rowColEventArgs
					}, false, this.Table.DataTable.Name, false);
					IL_20D:
					num2 = 28;
					if (this.Table.foxGrid.FindForm() == null || !this.Table.DataTable.GlobalHandler.AfterCheckRow)
					{
						goto IL_25A;
					}
					IL_239:
					num2 = 29;
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						rowColEventArgs
					}, false, "全局表事件", false);
					IL_25A:
					goto IL_324;
					IL_25F:
					int num4 = num5 + 1;
					num5 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
					IL_2E5:
					goto IL_319;
					IL_2E7:
					num5 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_2F7:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_2E7;
				}
				IL_319:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_324:
				if (num5 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		/// <summary>
		/// 移动行
		/// </summary>
		/// <param name="Position">新的位置</param>
		// Token: 0x06002B17 RID: 11031 RVA: 0x00132828 File Offset: 0x00130A28
		[oO0oooo("1846")]
		public bool Move(int Position)
		{
			int num;
			bool result;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				int index = this.Index;
				IL_11:
				num2 = 3;
				if (this.Table.DataTable.BaseTable.Columns.Contains("_SortKey"))
				{
					goto IL_52;
				}
				IL_34:
				num2 = 4;
				MessageBox.Show("此表不支持移动行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_49:
				num2 = 5;
				result = false;
				goto IL_4C0;
				IL_52:
				num2 = 6;
				if (Operators.CompareString(this.Table.Sort, "", true) <= 0)
				{
					goto IL_8B;
				}
				IL_6D:
				num2 = 7;
				MessageBox.Show("不能在排序状态下移动行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_82:
				num2 = 8;
				result = false;
				goto IL_4C0;
				IL_8B:
				num2 = 9;
				if (Position >= 0 && Position <= this.Table.ooO__oo0O.0.(false) - 1 && Position != this.Index)
				{
					goto IL_B6;
				}
				IL_AC:
				num2 = 10;
				result = false;
				goto IL_4C0;
				IL_B6:
				num2 = 11;
				MoveRowEventArgs moveRowEventArgs = new MoveRowEventArgs(this.Table, index, Position);
				IL_C9:
				num2 = 12;
				O_O0OO.OoO_o.oO0o0O.(this.Table.DataTable.o_0_00_.oo0O0., "BeforeMoveRow", new object[]
				{
					moveRowEventArgs
				}, false, this.Table.DataTable.Name, false);
				IL_104:
				num2 = 13;
				if (!moveRowEventArgs.Cancel)
				{
					goto IL_11A;
				}
				IL_110:
				num2 = 14;
				result = false;
				goto IL_4C0;
				IL_11A:
				num2 = 15;
				if (this.Table.foxGrid.FindForm() == null || !this.Table.DataTable.GlobalHandler.BeforeMoveRow)
				{
					goto IL_16B;
				}
				IL_146:
				num2 = 16;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeMoveRow", new object[]
				{
					moveRowEventArgs
				}, false, "全局表事件", false);
				IL_16B:
				num2 = 17;
				if (!moveRowEventArgs.Cancel)
				{
					goto IL_181;
				}
				IL_177:
				num2 = 18;
				result = false;
				goto IL_4C0;
				IL_181:
				num2 = 19;
				if (Position != 0)
				{
					goto IL_1ED;
				}
				IL_187:
				num2 = 20;
				if (this.Table.ooO__oo0O.0.(false) <= 0)
				{
					goto IL_1DE;
				}
				IL_199:
				num2 = 21;
				DataRow row = this.Table.View.O0O_0_0__.0O.(0).Row;
				IL_1B4:
				num2 = 22;
				decimal num3 = decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row["_SortKey"])), 1m);
				goto IL_339;
				IL_1DE:
				num2 = 24;
				num3 = 1m;
				goto IL_339;
				IL_1ED:
				num2 = 26;
				if (Position != this.Table.ooO__oo0O.0.(false) - 1)
				{
					goto IL_257;
				}
				IL_201:
				num2 = 27;
				DataRow row2 = this.Table.View.O0O_0_0__.0O.(this.Table.View.Count - 1).Row;
				IL_22D:
				num2 = 28;
				num3 = decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row2["_SortKey"])), 1m);
				goto IL_339;
				IL_257:
				num2 = 30;
				if (Position <= this.Index)
				{
					goto IL_29D;
				}
				IL_263:
				num2 = 31;
				DataRow row3 = this.Table.View.O0O_0_0__.0O.(Position).Row;
				IL_27E:
				num2 = 32;
				DataRow row4 = this.Table.View.O0O_0_0__.0O.(Position + 1).Row;
				goto IL_2D5;
				IL_29D:
				num2 = 34;
				row3 = this.Table.View.O0O_0_0__.0O.(Position - 1).Row;
				IL_2BA:
				num2 = 35;
				row4 = this.Table.View.O0O_0_0__.0O.(Position).Row;
				IL_2D5:
				num2 = 36;
				decimal num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row3["_SortKey"]));
				IL_2F0:
				num2 = 37;
				decimal num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row4["_SortKey"]));
				IL_30B:
				num2 = 38;
				num3 = this.Table.O.__O0o0.(this.oo_.o_O_OO0., new decimal[]
				{
					num4,
					num5
				});
				IL_339:
				num2 = 39;
				IEnumerator<Table> enumerator = OO_00oOO.Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Table table = enumerator.Current;
					IL_353:
					num2 = 40;
					if (table.DataTable.BaseTable == this.oo_.o_O_OO0..Table)
					{
						IL_36F:
						num2 = 41;
						table.View.SuspendBinding();
					}
					IL_37E:
					num2 = 42;
				}
				IL_38A:
				num2 = 43;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_398:
				num2 = 44;
				this.oo_.o_O_OO0.["_SortKey"] = num3;
				IL_3B2:
				num2 = 45;
				IEnumerator<Table> enumerator2 = OO_00oOO.Tables.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Table table2 = enumerator2.Current;
					IL_3CC:
					num2 = 46;
					if (table2.DataTable.BaseTable == this.oo_.o_O_OO0..Table)
					{
						IL_3E8:
						num2 = 47;
						table2.View.ResumeBinding();
						IL_3F7:
						num2 = 48;
						table2.ResetCurrentItem();
					}
					IL_401:
					num2 = 49;
				}
				IL_40D:
				num2 = 50;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_41B:
				num2 = 51;
				this.Table.View.Position = Position;
				IL_42F:
				num2 = 52;
				O_O0OO.OoO_o.oO0o0O.(this.Table.DataTable.o_0_00_.oo0O0., "AfterMoveRow", new object[]
				{
					moveRowEventArgs
				}, false, this.Table.DataTable.Name, false);
				IL_46A:
				num2 = 53;
				if (this.Table.foxGrid.FindForm() == null || !this.Table.DataTable.GlobalHandler.AfterMoveRow)
				{
					goto IL_4BB;
				}
				IL_496:
				num2 = 54;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterMoveRow", new object[]
				{
					moveRowEventArgs
				}, false, "全局表事件", false);
				IL_4BB:
				num2 = 55;
				result = true;
				IL_4C0:
				goto IL_5F2;
				IL_4C5:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_5B3:
				goto IL_5E7;
				IL_5B5:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_5C5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_5B5;
			}
			IL_5E7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_5F2:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 保存行
		/// </summary>
		// Token: 0x06002B18 RID: 11032 RVA: 0x00132E4C File Offset: 0x0013104C
		public void Save()
		{
			if (this.DataRow != null)
			{
				this.DataRow.Save();
			}
		}

		/// <summary>
		/// 撤销自打开文件或最近一次保存以来，对该行做出的修改
		/// </summary>
		// Token: 0x06002B19 RID: 11033 RVA: 0x00132E61 File Offset: 0x00131061
		[oO0oooo("2643")]
		public void Reject()
		{
			if (this.DataRow != null)
			{
				this.DataRow.RejectChanges();
			}
		}

		/// <summary>
		/// 接受此行的所有修改,在此之前做的任何修改都不会保存
		/// </summary>
		// Token: 0x06002B1A RID: 11034 RVA: 0x00132E76 File Offset: 0x00131076
		public void Accept()
		{
			if (this.DataRow != null)
			{
				this.DataRow.Accept();
			}
		}

		/// <summary>
		/// 重新加载行
		/// </summary>
		/// <param name="blnSave">加载前是否先保存此行</param>
		// Token: 0x06002B1B RID: 11035 RVA: 0x00132E8B File Offset: 0x0013108B
		[oO0oooo("2895")]
		public void Load(bool blnSave = true)
		{
			if (this.DataRow != null)
			{
				this.DataRow.Load(blnSave);
			}
		}

		/// <summary>
		/// 重新绘制此行
		/// </summary>
		// Token: 0x06002B1C RID: 11036 RVA: 0x00132EA4 File Offset: 0x001310A4
		public void Refresh()
		{
			int index = this.Index + this.Table.foxGrid.Rows.Fixed;
			this.Table.foxGrid.Rows[index].Invalidate();
		}

		/// <summary>
		/// 重新绘制此行的指定列
		/// </summary>
		/// <param name="ColName">列名</param>
		// Token: 0x06002B1D RID: 11037 RVA: 0x00132EEC File Offset: 0x001310EC
		public void Refresh(string ColName)
		{
			int row = this.Index + this.Table.foxGrid.Rows.Fixed;
			if (this.Table.foxGrid.Cols.Contains(ColName))
			{
				int index = this.Table.foxGrid.Cols[ColName].Index;
				this.Table.foxGrid.Invalidate(row, index);
			}
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00132F5C File Offset: 0x0013115C
		public void EndEdit()
		{
			if (this.DataRow != null)
			{
				this.DataRow.BaseRow.EndEdit();
			}
		}

		/// <summary>
		/// 在折叠模式下返回分组行某列的实际显示值
		/// </summary>
		/// <param name="colName">列名</param>
		// Token: 0x06002B1F RID: 11039 RVA: 0x00132F78 File Offset: 0x00131178
		[oO0oooo("3386")]
		public object GetValue(string colName)
		{
			DataRow dataRow = this.oo_.o_O_OO0.;
			object result;
			if (dataRow == null)
			{
				result = null;
			}
			else if (this.Table.GridTreeVisible && this.Table.o.0ooOO_0__..Contains(colName))
			{
				if (this.Table.o.0ooOO_0__..ContainsKey(dataRow))
				{
					result = this.Table.o.0ooOO_0__.[dataRow][colName];
				}
				else
				{
					result = dataRow[colName];
				}
			}
			else
			{
				result = dataRow[colName];
			}
			return result;
		}

		// Token: 0x040011A9 RID: 4521
		private Table <<EMPTY_NAME>>;

		// Token: 0x040011AA RID: 4522
		private DataRowView <<EMPTY_NAME>>;

		// Token: 0x040011AB RID: 4523
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x040011AC RID: 4524
		private int <<EMPTY_NAME>>;
	}
}
