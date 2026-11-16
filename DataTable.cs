using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Foxtable.My.Resources;
using Foxtable.RibbonMenu;
using Foxtable.Syscmd;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002AC RID: 684
	[oO0oooo("1584")]
	[ComVisible(true)]
	public class DataTable
	{
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x000FD9E1 File Offset: 0x000FBBE1
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x000FD9EC File Offset: 0x000FBBEC
		internal virtual DataTable _DataTable
		{
			[CompilerGenerated]
			get
			{
				return this.O0O__o.00_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataColumnChangeEventHandler value2 = new DataColumnChangeEventHandler(this.o_oO.o.);
				DataColumnChangeEventHandler value3 = new DataColumnChangeEventHandler(this.oo__._.);
				DataTableNewRowEventHandler value4 = new DataTableNewRowEventHandler(this.oo__._.);
				DataRowChangeEventHandler value5 = new DataRowChangeEventHandler(this.O_0.O.);
				DataRowChangeEventHandler value6 = new DataRowChangeEventHandler(this.o_oO.o.);
				DataRowChangeEventHandler value7 = new DataRowChangeEventHandler(this.oo__._.);
				DataTable o0O__o.00_. = this.O0O__o.00_.;
				if (o0O__o.00_. != null)
				{
					o0O__o.00_..ColumnChanged -= value2;
					o0O__o.00_..ColumnChanging -= value3;
					o0O__o.00_..TableNewRow -= value4;
					o0O__o.00_..RowChanged -= value5;
					o0O__o.00_..RowDeleted -= value6;
					o0O__o.00_..RowDeleting -= value7;
				}
				this.O0O__o.00_. = value;
				o0O__o.00_. = this.O0O__o.00_.;
				if (o0O__o.00_. != null)
				{
					o0O__o.00_..ColumnChanged += value2;
					o0O__o.00_..ColumnChanging += value3;
					o0O__o.00_..TableNewRow += value4;
					o0O__o.00_..RowChanged += value5;
					o0O__o.00_..RowDeleted += value6;
					o0O__o.00_..RowDeleting += value7;
				}
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x000FDACC File Offset: 0x000FBCCC
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x000FDAD4 File Offset: 0x000FBCD4
		internal virtual OleDbDataAdapter _Adapter
		{
			[CompilerGenerated]
			get
			{
				return this.O0O__o.00_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				OleDbRowUpdatedEventHandler value2 = new OleDbRowUpdatedEventHandler(this.O._0O_O0O.);
				OleDbDataAdapter o0O__o.00_. = this.O0O__o.00_.;
				if (o0O__o.00_. != null)
				{
					o0O__o.00_..RowUpdated -= value2;
				}
				this.O0O__o.00_. = value;
				o0O__o.00_. = this.O0O__o.00_.;
				if (o0O__o.00_. != null)
				{
					o0O__o.00_..RowUpdated += value2;
				}
			}
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000FDB17 File Offset: 0x000FBD17
		internal DataTable(DataTable A_0, OleDbDataAdapter A_1, OleDbConnection A_2, string A_3, DataSet A_4) : this(A_0, A_1, A_2, A_3, A_4, null)
		{
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000FDB28 File Offset: 0x000FBD28
		internal DataTable(DataTable A_0, OleDbDataAdapter A_1, OleDbConnection A_2, string A_3, DataSet A_4, HttpClient A_5)
		{
			this.o_0_00_.oo0O0. = new GlobalEvents();
			this.o.O0O_0__OOo_. = null;
			this.o_oO0O_.O0. = null;
			this.o0__.Oo0o__O. = null;
			this.o_oO0O_.O0. = null;
			this.o._OOO0oOo0__. = null;
			this.o_oO0O_.O0. = new DataTableProperty(this);
			this.OO._Ooo0. = new LookAndFeelProperty();
			this.o._000. = true;
			this.o0O._ooo_o___. = false;
			this.oo0__.00_. = true;
			this.Ooo._O_0Oo___. = true;
			this.O_oo0o_O0._0o. = true;
			this.o_0._Ooo____OO. = true;
			this.Oo0.O__OO. = true;
			this.oO0oO._0_. = true;
			this.o.___. = true;
			this.o0O.O0o_OOOoo. = true;
			this.Oo0o00o.Oo0_O. = true;
			this.O_O._. = true;
			this.O0.oOO0_. = false;
			this.OOooo.0o_0O_O_. = true;
			this.Ooo00.oo. = true;
			this.oO.0o0O0oO. = true;
			this.o.o_O00O_O_0. = true;
			this.oo._O_o0_O. = true;
			this.O.__00_o0. = null;
			this.O_oo.__0_. = null;
			this.o_0o0o0oo0.O. = null;
			this.Oo0O00Ooo._. = null;
			this.o_oO0O_.O0. = 0;
			this.OO._0oo000_00. = 0;
			this.o0O._ooo_o___. = 0;
			this.o_o._OOoo0OOoO. = 0;
			this.O.oo. = 30;
			this.o_oO0O_.O0. = DockArrageTypeEnum.TabPage;
			this.O.00oo0oOoOOo0. = DockArrageTypeEnum.TabPage;
			this.O_Oo._. = null;
			this.O0___.O. = false;
			this.Oo0Oo_.O000. = false;
			this.o_O_0.0_O. = null;
			this.Ooo00._0_oO_. = null;
			this.OOoO._o. = null;
			this.O_.oO_O_. = -1;
			this.O_0o0._O0. = false;
			this.o0_oO00.0oO_. = null;
			this.O0o0__o.0000__. = null;
			this.Oo.OO0ooOOo_. = false;
			this.O000_00._0_o. = true;
			this.OO00.oO_. = null;
			this.o_0.0O0o__0. = null;
			this.Oo0O0.0. = null;
			this.oo.o0_oO__o. = null;
			this.Ooo.Oo0o0. = null;
			this.oOo0_oo.OOo_. = null;
			this.Oo0O00Ooo._. = null;
			this.Oo_.O_. = null;
			this.O0O00o_.0Oo. = null;
			this.o.__Oo_Oo_. = null;
			this.O_000o_.O. = null;
			this.O.oO0_00. = null;
			this.Oo0__O0.0. = null;
			this.O0__oo_0O_.__. = null;
			this.o.O_0. = null;
			this.O_.__0. = null;
			this.OOoOO0O_._0__. = null;
			this.O00.O. = null;
			this.O._O00000. = null;
			this.o_o._000_0_. = null;
			this.o0OOOo_.0_o_0o. = false;
			this.o00o.00oO___0. = new List<string>();
			this.O0O00ooOo.o_. = 200;
			this.O._O0__. = "";
			this.o_oO0O_.O0. = BooleanEnum.Default;
			this.O0__.00. = "(default)";
			this._DataTable = A_0;
			this._Adapter = A_1;
			this.o0__.Oo0o__O. = A_2;
			this.o._OOO0oOo0__. = A_3;
			this.o_oO0O_.O0. = new DataRowCollection(A_0);
			if (!this._DataTable.Columns.Contains("_Locked"))
			{
				this._DataTable.Columns.Add("_Locked", typeof(bool));
				this.O000_00._0_o. = false;
			}
			if (this._DataTable.PrimaryKey.Length == 1 && !this._DataTable.PrimaryKey[0].AutoIncrement && A_2 != null && o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_2) && o_O_o_oOoo__.OO_.O.(this._DataTable.PrimaryKey[0].DataType))
			{
				DataRow dataRow = A_4.Tables[ooO0__OO.Oo0o0.oo_0.()].Rows.Find(new object[]
				{
					this.Name,
					"SEQUENCE",
					ExtendTablePropertyTypeEnum.SEQUENCE
				});
				if (dataRow != null && !dataRow.IsNull("Property"))
				{
					this.SEQUENCE = dataRow["Property"].ToString();
					this._DataTable.PrimaryKey[0].AutoIncrement = true;
					if (this._DataTable.Rows.Count == 0)
					{
						this._DataTable.PrimaryKey[0].AutoIncrementSeed = 1L;
					}
					else
					{
						this._DataTable.PrimaryKey[0].AutoIncrementSeed = Convert.ToInt64(RuntimeHelpers.GetObjectValue(this._DataTable.Compute("Max([" + this._DataTable.PrimaryKey[0].ColumnName + "])", ""))) + 1L;
					}
				}
				else
				{
					this.SEQUENCE = "@@@";
				}
			}
			if (this._DataTable.PrimaryKey.Length == 1 && this._DataTable.PrimaryKey[0].AutoIncrement)
			{
				this.O_.__0. = this._DataTable.PrimaryKey[0].ColumnName;
			}
			if (this._DataTable.Columns.Contains("_SortKey"))
			{
				this.o0O.O_0.(A_5);
			}
			if (!this._DataTable.Columns.Contains("System_Sort_Temporary"))
			{
				this._DataTable.Columns.Add("System_Sort_Temporary", typeof(double));
				this._DataTable.Columns.Add("System_Filter_Temporary", typeof(int));
				this._DataTable.Columns.Add("System_Filter_Unique", typeof(int));
			}
			if (this._Adapter != null)
			{
				if (this._Adapter.UpdateCommand == null)
				{
					this.Ooo._O_0Oo___. = false;
				}
				string a_ = this.frd_SelectCommandString;
				string a_2 = this.LoadFilter;
				string a_3 = this.LoadTop;
				string a_4 = this.LoadOrder;
				Oo00.ooO.ooo.(a_, ref a_2, ref a_3, ref this.o0_oO00.0oO_., ref this.O0o0__o.0000__., ref a_4);
				this.LoadOrder = a_4;
				this.LoadTop = a_3;
				this.LoadFilter = a_2;
				this.ooO.oO0O0_oo. = false;
			}
			else
			{
				Operators.CompareString(this.DataServer, "", true);
			}
			if (this._DataTable.ExtendedProperties.ContainsKey("foxtable.datatable"))
			{
				this._DataTable.ExtendedProperties.Remove("foxtable.datatable");
			}
			this._DataTable.ExtendedProperties.Add("foxtable.datatable", this);
			if (this._DataTable.Columns.Contains("sys_Hierarchy_Level"))
			{
				this.oOOO.OOO_0ooO0. = true;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x000FE0D6 File Offset: 0x000FC2D6
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x000FE0DE File Offset: 0x000FC2DE
		internal bool IsDeletingRows { get; set; }

		/// <summary>
		/// 返回底层的Data.DataTable
		/// </summary>
		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x000FE0E7 File Offset: 0x000FC2E7
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x000FE0F0 File Offset: 0x000FC2F0
		public DataTable BaseTable
		{
			get
			{
				return this._DataTable;
			}
			set
			{
				this._DataTable = value;
				if (this.OO._0oo000_00. != null)
				{
					this.OO._0oo000_00..ExtendedProperties.Clear();
					this.OO._0oo000_00. = null;
				}
				this.o_oO0O_.O0. = null;
				this._Adapter = null;
				this.o0__.Oo0o__O. = null;
				this.o._OOO0oOo0__. = null;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x000FE13F File Offset: 0x000FC33F
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x000FE147 File Offset: 0x000FC347
		internal DataTableProperty frd_Setting
		{
			get
			{
				return this.o_oO0O_.O0.;
			}
			set
			{
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x000FE149 File Offset: 0x000FC349
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x000FE151 File Offset: 0x000FC351
		internal LookAndFeelProperty frd_LookAndFeel
		{
			get
			{
				return this.OO._Ooo0.;
			}
			set
			{
				this.OO._Ooo0. = value;
			}
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x000FE15A File Offset: 0x000FC35A
		internal void <<EMPTY_NAME>>()
		{
			this.o.O0O_0__OOo_. = new DataColCollection(this._DataTable);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x000FE170 File Offset: 0x000FC370
		internal void <<EMPTY_NAME>>()
		{
			this.o.O0O_0__OOo_. = new DataColCollection(this._DataTable);
			if (this._DataTable.DataSet != null)
			{
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
				{
					this._DataTable.TableName,
					""
				});
				if (dataRow != null)
				{
					o_O_o_oOoo__.OOOO_OO._oo.(this.o_oO0O_.O0., Conversions.ToString(dataRow["Config"]), '\v');
				}
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
				{
					"{" + this._DataTable.TableName + "}",
					""
				});
				if (dataRow != null && !dataRow.IsNull("Config"))
				{
					o_O_o_oOoo__.OOOO_OO._oo.(this.frd_LookAndFeel, Conversions.ToString(dataRow["Config"]), '\v');
				}
				if (OO_00oOO.User.Type == UserTypeEnum.Developer && OO_00oOO.ModifierKey == Keys.Control)
				{
					this.o_0_00_.oo0O0. = o0_.Oo_0.OOo0oO0.("", "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", true);
				}
				else
				{
					this.o0.0_0OO0o_0o.(false);
				}
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Rows.Find(new object[]
				{
					this.Name,
					"",
					ExtendTablePropertyTypeEnum.DockSetting
				});
				if (dataRow != null)
				{
					o_O_o_oOoo__.OOOO_OO._oo.(new DockSetting(this), Conversions.ToString(dataRow["Property"]), '\v');
				}
			}
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x000FE320 File Offset: 0x000FC520
		internal void <<EMPTY_NAME>>(bool A_0)
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
				string text = string.Concat(new string[]
				{
					OO_00oOO.ProjectPath,
					"Bin\\",
					o0OoOOoOOo0.oo00o.0OoO.(""),
					".DataTable.",
					o0OoOOoOOo0.OO0._Oo0o.(this.Name),
					".dll"
				});
				IL_50:
				num2 = 3;
				this.oOOO.0. = false;
				IL_59:
				num2 = 4;
				if (!A_0 && OO_00oOO.FileSys.FileExists(text))
				{
					goto IL_15E;
				}
				IL_6E:
				num2 = 5;
				if (!OO_00oOO.FileSys.FileExists(text))
				{
					goto IL_8A;
				}
				IL_7D:
				num2 = 6;
				OO_00oOO.FileSys.DeleteFile(text);
				IL_8A:
				num2 = 7;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
				{
					this._DataTable.TableName,
					""
				});
				IL_C8:
				num2 = 8;
				if (dataRow == null || dataRow.IsNull("Code"))
				{
					goto IL_152;
				}
				IL_DF:
				num2 = 9;
				string a_ = DataTable.o.o00O.(Conversions.ToString(dataRow["Code"]));
				IL_FA:
				num2 = 10;
				o_O_o_oOoo__.OOOO_OO._oo.(this.frd_Setting, a_, '\v');
				IL_10C:
				ProjectData.ClearProjectError();
				num = 1;
				IL_113:
				num2 = 12;
				this.OOo0.O. = true;
				IL_11D:
				num2 = 13;
				this.o_0_00_.oo0O0. = o0_.Oo_0.OOo0oO0.(this.frd_Setting, text, O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()]);
				IL_146:
				num2 = 14;
				this.OOo0.O. = false;
				goto IL_195;
				IL_152:
				num2 = 16;
				this.o_0_00_.oo0O0. = null;
				goto IL_195;
				IL_15E:
				num2 = 18;
				if (!OO_00oOO.FileSys.FileExists(text))
				{
					goto IL_18B;
				}
				IL_16E:
				num2 = 19;
				byte[] rawAssembly = File.ReadAllBytes(text);
				IL_179:
				num2 = 20;
				this.o_0_00_.oo0O0. = Assembly.Load(rawAssembly);
				goto IL_195;
				IL_18B:
				num2 = 22;
				this.o_0_00_.oo0O0. = null;
				IL_195:
				num2 = 23;
				this.o0O.O_0.(this.o_0_00_.oo0O0.);
				IL_1A4:
				goto IL_256;
				IL_1A9:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_217:
				goto IL_24B;
				IL_219:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_229:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_219;
			}
			IL_24B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_256:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x000FE5A8 File Offset: 0x000FC7A8
		internal void <<EMPTY_NAME>>(Assembly A_0)
		{
			Type type = null;
			if (A_0 != null)
			{
				type = A_0.GetType("UserCode");
			}
			if (type != null)
			{
				this.oOo0_oo.OOo_. = type.GetMethod("FilterRow");
				this.OO00.oO_. = type.GetMethod("DrawCell");
				this.o_0.0O0o__0. = type.GetMethod("MouseEnterCell");
				this.Oo0O0.0. = type.GetMethod("MouseLeaveCell");
				this.oo.o0_oO__o. = type.GetMethod("MouseHoverCell");
				this.Ooo.Oo0o0. = type.GetMethod("BeforeDrawRow");
				this.Oo0O00Ooo._. = type.GetMethod("PrepareEdit");
				this.Oo_.O_. = type.GetMethod("StartEdit");
				this.O0O00o_.0Oo. = type.GetMethod("AfterEdit");
				this.o.__Oo_Oo_. = type.GetMethod("BeforeSaveDataRow");
				this.O_000o_.O. = type.GetMethod("AfterSaveDataRow");
				this.O.oO0_00. = type.GetMethod("BeforeDeleteDataRow");
				this.Oo0__O0.0. = type.GetMethod("DataRowLockedChanging");
				this.O0__oo_0O_.__. = type.GetMethod("DataRowLockedChanged");
				this.o.O_0. = type.GetMethod("DataColChanged");
				this.O_.__0. = type.GetMethod("DataColChanging");
				this.OOoOO0O_._0__. = type.GetMethod("DataRowAdding");
				this.O00.O. = type.GetMethod("DataRowAdded");
				this.O._O00000. = type.GetMethod("DataRowDeleted");
				this.o_o._000_0_. = type.GetMethod("DataRowDeleting");
				return;
			}
			this.oOo0_oo.OOo_. = null;
			this.OO00.oO_. = null;
			this.o_0.0O0o__0. = null;
			this.Oo0O0.0. = null;
			this.oo.o0_oO__o. = null;
			this.Ooo.Oo0o0. = null;
			this.Oo0O00Ooo._. = null;
			this.Oo_.O_. = null;
			this.O0O00o_.0Oo. = null;
			this.o.__Oo_Oo_. = null;
			this.O_000o_.O. = null;
			this.O.oO0_00. = null;
			this.Oo0__O0.0. = null;
			this.O0__oo_0O_.__. = null;
			this.o.O_0. = null;
			this.O_.__0. = null;
			this.OOoOO0O_._0__. = null;
			this.O00.O. = null;
			this.O._O00000. = null;
			this.o_o._000_0_. = null;
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000FE7AD File Offset: 0x000FC9AD
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x000FE7B5 File Offset: 0x000FC9B5
		internal OleDbConnection frd_Connection
		{
			get
			{
				return this.o0__.Oo0o__O.;
			}
			set
			{
			}
		}

		/// <summary>
		/// 返回数据源的类型，1表示Access，2表示SQL Server，3表示Oracle。
		/// </summary>
		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000FE7B8 File Offset: 0x000FC9B8
		[oO0oooo("2343")]
		public int SourceType
		{
			get
			{
				int result;
				if (this.o0__.Oo0o__O. != null)
				{
					result = (int)Oo00.OoO_.__o.(this.o0__.Oo0o__O.);
				}
				else if (Operators.CompareString(this.DataServer, "", true) > 0)
				{
					int oo.OoO0. = (int)O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].OO.OoO0.;
					if (oo.OoO0. >= 1 && oo.OoO0. <= 3)
					{
						result = oo.OoO0.;
					}
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x000FE814 File Offset: 0x000FCA14
		// (set) Token: 0x060023BA RID: 9146 RVA: 0x000FE81C File Offset: 0x000FCA1C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string SEQUENCE
		{
			get
			{
				return this.o_oO0O_.O0.;
			}
			set
			{
				this.o_oO0O_.O0. = value;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x000FE825 File Offset: 0x000FCA25
		// (set) Token: 0x060023BC RID: 9148 RVA: 0x000FE830 File Offset: 0x000FCA30
		internal string frd_ActualName
		{
			get
			{
				return this.o._OOO0oOo0__.;
			}
			set
			{
				if (Operators.CompareString(this.o._OOO0oOo0__., value, true) != 0)
				{
					string text = this._Adapter.SelectCommand.CommandText;
					string text2;
					string str;
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection))
					{
						text2 = this.o._OOO0oOo0__.;
						str = value;
					}
					else
					{
						text2 = "[" + this.o._OOO0oOo0__..Trim(new char[]
						{
							'[',
							']'
						}) + "]";
						str = "[" + value + "]";
					}
					int num = text.LastIndexOf(text2);
					if (num + text2.Length < text.Length)
					{
						text = text.Substring(0, num) + str + text.Substring(num + text2.Length);
					}
					else
					{
						text = text.Substring(0, num) + str;
					}
					this.o._OOO0oOo0__. = value;
					this._Adapter.SelectCommand.CommandText = text;
					this.O_00_._.();
				}
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x000FE918 File Offset: 0x000FCB18
		// (set) Token: 0x060023BE RID: 9150 RVA: 0x000FE92A File Offset: 0x000FCB2A
		internal string frd_SelectCommandString
		{
			get
			{
				return this._Adapter.SelectCommand.CommandText;
			}
			set
			{
			}
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x000FE92C File Offset: 0x000FCB2C
		private void <<EMPTY_NAME>>()
		{
			if (OO_00oOO.Tables != null)
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.View.o_o.O0ooOo.() == this._DataTable)
						{
							table.Ooo0ooOOo.o.();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x000FE994 File Offset: 0x000FCB94
		internal void <<EMPTY_NAME>>(DataCol A_0)
		{
			object obj = this._DataTable;
			DataRow[] array;
			lock (obj)
			{
				array = this._DataTable.Select("", "", DataViewRowState.CurrentRows);
			}
			foreach (DataRow dataRow in array)
			{
				DataColEventArgs dataColEventArgs = new DataColEventArgs(this, new DataRow(dataRow), A_0, RuntimeHelpers.GetObjectValue(dataRow[A_0.Name]), RuntimeHelpers.GetObjectValue(dataRow[A_0.Name]));
				if (this.o.O_0. != null)
				{
					try
					{
						this.o.O_0..Invoke(null, new object[]
						{
							dataColEventArgs
						});
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "表，" + this.Name + "， DataColChanged");
						break;
					}
				}
				if (this.GlobalHandler.DataColChanged && O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O. != null)
				{
					try
					{
						O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O..Invoke(null, new object[]
						{
							dataColEventArgs
						});
					}
					catch (Exception a_2)
					{
						ooO.oOo0Oo.o.(a_2, "全局表事件, DataColChanged");
					}
				}
			}
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x000FEAF4 File Offset: 0x000FCCF4
		internal void <<EMPTY_NAME>>(DataCol A_0, DataRow A_1)
		{
			DataColEventArgs dataColEventArgs = new DataColEventArgs(this, A_1, A_0, RuntimeHelpers.GetObjectValue(A_1[A_0.Name]), RuntimeHelpers.GetObjectValue(A_1[A_0.Name]));
			if (this.o.O_0. != null)
			{
				try
				{
					this.o.O_0..Invoke(null, new object[]
					{
						dataColEventArgs
					});
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "表，" + this.Name + "， DataColChanged");
				}
			}
			if (this.GlobalHandler.DataColChanged && O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O. != null)
			{
				try
				{
					O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O..Invoke(null, new object[]
					{
						dataColEventArgs
					});
				}
				catch (Exception a_2)
				{
					ooO.oOo0Oo.o.(a_2, "全局表事件, DataColChanged");
				}
			}
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x000FEBE4 File Offset: 0x000FCDE4
		private void <<EMPTY_NAME>>(object A_0, DataColumnChangeEventArgs A_1)
		{
			if (Operators.CompareString(A_1.Column.ColumnName, this.OO_.OOo0o0., true) != 0 && this._DataTable.DataSet != null && !this.o.OOO_oO0_0O_o.)
			{
				object obj = null;
				this.o0._o_. = false;
				if (Operators.CompareString(A_1.Column.ColumnName, "_SortKey", true) != 0)
				{
					if (Operators.CompareString(A_1.Column.ColumnName, "_Locked", true) == 0 && A_1.Row.RowState != DataRowState.Detached)
					{
						if (!this.O000_00._0_o.)
						{
							if (A_1.Row.RowState == DataRowState.Unchanged)
							{
								this.o0._o_. = true;
								return;
							}
							return;
						}
						else
						{
							try
							{
								A_1.Row.EndEdit();
								return;
							}
							catch (Exception a_)
							{
								ooO.oOo0Oo.o.(a_, "");
								A_1.Row.CancelEdit();
								return;
							}
						}
					}
					if (o_O_o_oOoo__.oO.O_..Contains(A_1.Column.ColumnName))
					{
						if (A_1.Row.RowState == DataRowState.Unchanged)
						{
							this.o0._o_. = true;
							return;
						}
					}
					else
					{
						if (A_1.Column.ExtendedProperties.Contains("ov"))
						{
							Dictionary<DataRow, object> dictionary = (Dictionary<DataRow, object>)A_1.Column.ExtendedProperties["ov"];
							if (dictionary.ContainsKey(A_1.Row))
							{
								obj = RuntimeHelpers.GetObjectValue(dictionary[A_1.Row]);
								dictionary.Remove(A_1.Row);
							}
						}
						if (A_1.Row.HasVersion(DataRowVersion.Current) && string.Compare(A_1.ProposedValue.ToString(), A_1.Row[A_1.Column, DataRowVersion.Current].ToString(), false) == 0)
						{
							if (A_1.Row.RowState == DataRowState.Unchanged)
							{
								this.o0._o_. = true;
								return;
							}
						}
						else if (OO_00oOO.SystemReady)
						{
							if (this.DataCols[A_1.Column.ColumnName].IsTemporary && A_1.Row.RowState == DataRowState.Unchanged && (this.frd_IsOuterTable || this.frd_IsInnerTable))
							{
								this.o0._o_. = true;
							}
							try
							{
								A_1.Row.EndEdit();
							}
							catch (Exception a_2)
							{
								ooO.oOo0Oo.o.(a_2, "");
								A_1.Row.CancelEdit();
								return;
							}
							DataColEventArgs dataColEventArgs = new DataColEventArgs(this, new DataRow(A_1.Row), this.DataCols[A_1.Column.ColumnName], RuntimeHelpers.GetObjectValue(A_1.ProposedValue), RuntimeHelpers.GetObjectValue(obj));
							if (this.o.O_0. != null)
							{
								try
								{
									this.o.O_0..Invoke(null, new object[]
									{
										dataColEventArgs
									});
								}
								catch (Exception a_3)
								{
									ooO.oOo0Oo.o.(a_3, "表，" + this.Name + "，DataColChanged");
								}
							}
							if (this.GlobalHandler.DataColChanged && O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O. != null)
							{
								try
								{
									O_O0OO.O0_00o.o0__o..o.00O0_Oo0o__O..Invoke(null, new object[]
									{
										dataColEventArgs
									});
								}
								catch (Exception a_4)
								{
									ooO.oOo0Oo.o.(a_4, "全局表事件, DataColChanged");
								}
							}
							if (this.DataCols[A_1.Column.ColumnName].IsNumeric)
							{
								try
								{
									foreach (Table table in OO_00oOO.Tables)
									{
										if (table.DataTable.BaseTable == this.BaseTable)
										{
											if (table.GridTreeVisible && table.o.0ooOO_0__. != null)
											{
												try
												{
													foreach (string text in table.o.0ooOO_0__.)
													{
														if (Operators.CompareString(text, A_1.Column.ColumnName, true) == 0)
														{
															table.O0o._oo_.(A_1.Row, A_1.Column.ColumnName, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(A_1.ProposedValue));
														}
														else
														{
															DataColumn dataColumn = table.DataTable.BaseTable.Columns[text];
															if (Operators.CompareString(dataColumn.Expression, "", true) > 0 && dataColumn.Expression.IndexOf(A_1.Column.ColumnName, StringComparison.OrdinalIgnoreCase) >= 0)
															{
																table.O0o._oo_.(A_1.Row, text);
															}
														}
													}
													continue;
												}
												finally
												{
													HashSet<string>.Enumerator enumerator2;
													((IDisposable)enumerator2).Dispose();
												}
											}
											if (table.foxGrid.OO.o_o00o.())
											{
												try
												{
													foreach (string text2 in table.o.0ooOO_0__.)
													{
														if (Operators.CompareString(text2, A_1.Column.ColumnName, true) == 0)
														{
															table.O_0o__O0O0_0.0.(A_1.Row, A_1.Column.ColumnName, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(A_1.ProposedValue));
														}
														else
														{
															DataColumn dataColumn2 = table.DataTable.BaseTable.Columns[text2];
															if (Operators.CompareString(dataColumn2.Expression, "", true) > 0 && dataColumn2.Expression.IndexOf(A_1.Column.ColumnName, StringComparison.OrdinalIgnoreCase) >= 0)
															{
																table.O_0o__O0O0_0.0.(A_1.Row, text2);
															}
														}
													}
												}
												finally
												{
													HashSet<string>.Enumerator enumerator3;
													((IDisposable)enumerator3).Dispose();
												}
											}
										}
									}
								}
								finally
								{
									IEnumerator<Table> enumerator;
									if (enumerator != null)
									{
										enumerator.Dispose();
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x000FF1F4 File Offset: 0x000FD3F4
		private void <<EMPTY_NAME>>(object A_0, DataColumnChangeEventArgs A_1)
		{
			if (Operators.CompareString(A_1.Column.ColumnName, this.OO_.OOo0o0., true) != 0 && this._DataTable.DataSet != null && !this.o.OOO_oO0_0O_o.)
			{
				if (A_1.ProposedValue == null)
				{
					A_1.ProposedValue = DBNull.Value;
				}
				if (Operators.CompareString(A_1.Column.ColumnName, "_SortKey", true) != 0)
				{
					if (A_1.Column.DataType == typeof(bool) && A_1.ProposedValue == DBNull.Value)
					{
						A_1.ProposedValue = false;
					}
					if (Operators.CompareString(A_1.Column.ColumnName, "System_Sort_Temporary", true) != 0)
					{
						if (A_1.Column.DataType == typeof(string) && A_1.ProposedValue != DBNull.Value && A_1.ProposedValue != null)
						{
							string text = Conversions.ToString(A_1.ProposedValue).Trim();
							if (text.Length == 0)
							{
								A_1.ProposedValue = DBNull.Value;
							}
							else if (A_1.Column.MaxLength >= 0 && text.Length > A_1.Column.MaxLength)
							{
								MessageBox.Show(string.Concat(new string[]
								{
									"\"",
									A_1.ProposedValue.ToString(),
									"\" 的长度超出了[",
									A_1.Column.ColumnName,
									"]列允许的最大长度",
									Conversions.ToString(A_1.Column.MaxLength),
									"，将被自动截短！"
								}), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								A_1.ProposedValue = text.Substring(0, A_1.Column.MaxLength);
							}
						}
						else if (A_1.Column.DataType == typeof(float) || A_1.Column.DataType == typeof(double) || A_1.Column.DataType == typeof(decimal))
						{
							if (A_1.ProposedValue != DBNull.Value && A_1.Column.DataType != typeof(decimal))
							{
								double d = Conversion.Val(RuntimeHelpers.GetObjectValue(A_1.ProposedValue));
								if (double.IsInfinity(d) || double.IsNaN(d))
								{
									A_1.ProposedValue = DBNull.Value;
								}
							}
							if (A_1.ProposedValue != DBNull.Value)
							{
								int decimals = this.o.O0O_0__OOo_.[A_1.Column.ColumnName].Decimals;
								if (A_1.Column.DataType == typeof(decimal))
								{
									A_1.ProposedValue = Math.Round(Conversions.ToDecimal(A_1.ProposedValue), decimals);
								}
								else if (A_1.Column.DataType == typeof(double))
								{
									A_1.ProposedValue = Math.Round(Conversions.ToDouble(A_1.ProposedValue), decimals);
								}
								else if (A_1.Column.DataType == typeof(float))
								{
									A_1.ProposedValue = Math.Round((double)Conversions.ToSingle(A_1.ProposedValue), decimals);
								}
							}
						}
						else if (A_1.Column.DataType == typeof(DateTime) && A_1.ProposedValue != DBNull.Value)
						{
							DateTime dateTime = Conversions.ToDate(A_1.ProposedValue);
							if (DateTime.Compare(dateTime, DateTime.MinValue) == 0)
							{
								A_1.ProposedValue = DBNull.Value;
							}
							else
							{
								switch (this.DataCols[A_1.Column.ColumnName].DateTimeFormat)
								{
								case DateTimeFormatEnum.Date:
									A_1.ProposedValue = dateTime.Date;
									break;
								case DateTimeFormatEnum.Time:
									A_1.ProposedValue = new DateTime(599266080000000000L).AddHours((double)dateTime.Hour).AddMinutes((double)dateTime.Minute);
									break;
								case DateTimeFormatEnum.LongTime:
									A_1.ProposedValue = new DateTime(599266080000000000L).AddHours((double)dateTime.Hour).AddMinutes((double)dateTime.Minute).AddSeconds((double)dateTime.Second);
									break;
								case DateTimeFormatEnum.DateTime:
									A_1.ProposedValue = dateTime.AddSeconds((double)(-(double)dateTime.Second));
									break;
								case DateTimeFormatEnum.DateLongTime:
									A_1.ProposedValue = dateTime;
									break;
								}
								A_1.ProposedValue = Conversions.ToDate(A_1.ProposedValue);
							}
						}
					}
					if (OO_00oOO.SystemReady)
					{
						if (o_O_o_oOoo__.oO.O_..Contains(A_1.Column.ColumnName))
						{
							if (Operators.CompareString(A_1.Column.ColumnName, "_Identify", true) != 0)
							{
								if (Operators.CompareString(A_1.Column.ColumnName, "_Locked", true) != 0 || A_1.Row.RowState == DataRowState.Detached)
								{
									return;
								}
								DataRowEventArgs dataRowEventArgs = new DataRowEventArgs(this, new DataRow(A_1.Row));
								if (this.Oo0__O0.0. != null)
								{
									try
									{
										this.Oo0__O0.0..Invoke(null, new object[]
										{
											dataRowEventArgs
										});
									}
									catch (Exception a_)
									{
										ooO.oOo0Oo.o.(a_, "表，" + this.Name + "，DataRowLockedChanging");
									}
									if (dataRowEventArgs.Cancel)
									{
										A_1.ProposedValue = RuntimeHelpers.GetObjectValue(A_1.Row[A_1.Column]);
									}
								}
								if (dataRowEventArgs.Cancel || !this.GlobalHandler.DataRowLockedChanging)
								{
									return;
								}
								try
								{
									if (O_O0OO.O0_00o.o0__o..Ooo0000o.o0. != null)
									{
										O_O0OO.O0_00o.o0__o..Ooo0000o.o0..Invoke(null, new object[]
										{
											dataRowEventArgs
										});
									}
								}
								catch (Exception a_2)
								{
									ooO.oOo0Oo.o.(a_2, "全局表事件，DataRowLockedChanging");
								}
								if (dataRowEventArgs.Cancel)
								{
									A_1.ProposedValue = RuntimeHelpers.GetObjectValue(A_1.Row[A_1.Column]);
									return;
								}
								return;
							}
						}
						else
						{
							if (!A_1.Column.ExtendedProperties.Contains("ov"))
							{
								A_1.Column.ExtendedProperties.Add("ov", new Dictionary<DataRow, object>());
							}
							((Dictionary<DataRow, object>)A_1.Column.ExtendedProperties["ov"])[A_1.Row] = RuntimeHelpers.GetObjectValue(A_1.Row[A_1.Column]);
							if ((A_1.ProposedValue == DBNull.Value & A_1.Row.IsNull(A_1.Column)) || string.Compare(A_1.ProposedValue.ToString(), A_1.Row[A_1.Column].ToString(), false) == 0)
							{
								return;
							}
							DataColEventArgs dataColEventArgs = new DataColEventArgs(this, new DataRow(A_1.Row), this.DataCols[A_1.Column.ColumnName], RuntimeHelpers.GetObjectValue(A_1.ProposedValue), RuntimeHelpers.GetObjectValue(A_1.Row[A_1.Column]));
							if (this.O_.__0. != null)
							{
								try
								{
									this.O_.__0..Invoke(null, new object[]
									{
										dataColEventArgs
									});
								}
								catch (Exception a_3)
								{
									ooO.oOo0Oo.o.(a_3, "表，" + this.Name + "，DataColChanging");
								}
							}
							if (!dataColEventArgs.Cancel && this.GlobalHandler.DataColChanging && O_O0OO.O0_00o.o0__o..oOO0_O.o. != null)
							{
								try
								{
									O_O0OO.O0_00o.o0__o..oOO0_O.o..Invoke(null, new object[]
									{
										dataColEventArgs
									});
								}
								catch (Exception a_4)
								{
									ooO.oOo0Oo.o.(a_4, "全局表事件, DataColChanging");
								}
							}
							if (dataColEventArgs.Cancel)
							{
								if (A_1.Column.DataType != typeof(bool))
								{
									A_1.ProposedValue = RuntimeHelpers.GetObjectValue(A_1.Row[A_1.Column]);
									return;
								}
								if (A_1.Row.IsNull(A_1.Column))
								{
									A_1.ProposedValue = false;
									return;
								}
								A_1.ProposedValue = RuntimeHelpers.GetObjectValue(A_1.Row[A_1.Column]);
								return;
							}
							else
							{
								if (dataColEventArgs.NewValue == null)
								{
									dataColEventArgs.NewValue = DBNull.Value;
								}
								A_1.ProposedValue = RuntimeHelpers.GetObjectValue(dataColEventArgs.NewValue);
							}
						}
						try
						{
							foreach (object obj in this._DataTable.ChildRelations)
							{
								O0Oo o0Oo = (O0Oo)obj;
								if (o0Oo.oo0__.0Oo0o_.())
								{
									int num = o0Oo.ParentColumns.Length - 1;
									for (int i = 0; i <= num; i++)
									{
										checked
										{
											if (o0Oo.ParentColumns[i] == A_1.Column)
											{
												DataColumn column = o0Oo.ChildColumns[i];
												DataRow[] childRows = A_1.Row.GetChildRows(o0Oo);
												if (A_1.ProposedValue == DBNull.Value)
												{
													if (childRows.Length > 0)
													{
														A_1.ProposedValue = RuntimeHelpers.GetObjectValue(A_1.Row[A_1.Column]);
													}
												}
												else
												{
													DataRow[] array = childRows;
													for (int j = 0; j < array.Length; j++)
													{
														array[j][column] = RuntimeHelpers.GetObjectValue(A_1.ProposedValue);
													}
												}
											}
										}
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
					}
				}
			}
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x000FFBB0 File Offset: 0x000FDDB0
		private void <<EMPTY_NAME>>(object A_0, DataTableNewRowEventArgs A_1)
		{
			if (this._DataTable.DataSet == null)
			{
				if (this._DataTable.Columns.Contains("_SortKey"))
				{
					A_1.Row["_SortKey"] = this.OO00.oO_.;
					this.OO00.oO_. = decimal.Add(this.OO00.oO_., 1m);
					return;
				}
			}
			else if (!this.o.OOO_oO0_0O_o.)
			{
				A_1.Row["System_Filter_Temporary"] = 1;
				O_0 o_ = OO_00oOO.Tables[this.Name].View;
				if (o_.Count > 0 && !o_.O0O_0_0__.0O.(o_.Count - 1).Row.IsNull("System_Sort_Temporary"))
				{
					A_1.Row["System_Sort_Temporary"] = Conversion.Val(RuntimeHelpers.GetObjectValue(o_.O0O_0_0__.0O.(o_.Count - 1)["System_Sort_Temporary"])) + 1.0;
				}
				else
				{
					A_1.Row["System_Sort_Temporary"] = 1;
				}
				if (this._DataTable.Columns.Contains("_SortKey"))
				{
					A_1.Row["_SortKey"] = this.OO00.oO_.;
					this.OO00.oO_. = decimal.Add(this.OO00.oO_., 1m);
				}
				try
				{
					foreach (object obj in this._DataTable.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj;
						if (dataColumn.DataType == typeof(bool) && Operators.CompareString(dataColumn.ColumnName, "_Locked", true) == 0)
						{
							A_1.Row[dataColumn] = false;
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
				if (this.DataCols != null)
				{
					try
					{
						foreach (DataCol dataCol in this.DataCols)
						{
							if (Operators.CompareString(dataCol.DefaultValue, "", true) > 0)
							{
								try
								{
									A_1.Row[dataCol.Name] = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval(dataCol.DefaultValue, new DataRow(A_1.Row)));
								}
								catch (Exception a_)
								{
									ooO.oOo0Oo.o.(a_, string.Concat(new string[]
									{
										"[",
										this.Name,
										"]表的[",
										dataCol.Name,
										"]列的默认值计算错误。"
									}));
								}
							}
						}
					}
					finally
					{
						IEnumerator<DataCol> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
				DataRowEventArgs dataRowEventArgs = new DataRowEventArgs(this, new DataRow(A_1.Row));
				if (this.OOoOO0O_._0__. != null && OO_00oOO.SystemReady)
				{
					try
					{
						this.OOoOO0O_._0__..Invoke(null, new object[]
						{
							dataRowEventArgs
						});
					}
					catch (Exception a_2)
					{
						ooO.oOo0Oo.o.(a_2, "表，" + this.Name + "，DataRowAdding");
					}
				}
				if (this.GlobalHandler.DataRowAdding && O_O0OO.O0_00o.o0__o..OO0_0_._. != null && OO_00oOO.SystemReady)
				{
					try
					{
						O_O0OO.O0_00o.o0__o..OO0_0_._..Invoke(null, new object[]
						{
							dataRowEventArgs
						});
					}
					catch (Exception a_3)
					{
						ooO.oOo0Oo.o.(a_3, "全局事件, DataRowAdding");
					}
				}
			}
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x000FFF5C File Offset: 0x000FE15C
		private void <<EMPTY_NAME>>(object A_0, DataRowChangeEventArgs A_1)
		{
			if (A_1.Action == DataRowAction.Add)
			{
				try
				{
					foreach (object obj in this._DataTable.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj;
						if (dataColumn.DataType == typeof(bool) && A_1.Row.IsNull(dataColumn))
						{
							A_1.Row[dataColumn] = false;
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
			if (this._DataTable.DataSet == null)
			{
				if (A_1.Action == DataRowAction.Add)
				{
					this.o_oO0O_.O0. = null;
				}
				if (A_1.Action == DataRowAction.Rollback && A_1.Row.RowState == DataRowState.Detached)
				{
					this.o_oO0O_.O0. = null;
					return;
				}
			}
			else if (Operators.CompareString(A_1.Row.RowError, "", true) <= 0 && !this.o.OOO_oO0_0O_o.)
			{
				if (A_1.Action == DataRowAction.Change && this.o0._o_. && A_1.Row.RowState == DataRowState.Modified)
				{
					A_1.Row.AcceptChanges();
					return;
				}
				if (A_1.Action == DataRowAction.Add || (A_1.Action == DataRowAction.Rollback && A_1.Row.RowState == DataRowState.Detached))
				{
					this.o_oO0O_.O0. = null;
				}
				if (A_1.Action == DataRowAction.Add && OO_00oOO.SystemReady && this.DataCols != null)
				{
					DataRowEventArgs dataRowEventArgs = new DataRowEventArgs(this, new DataRow(A_1.Row));
					if (this.O00.O. != null)
					{
						try
						{
							this.O00.O..Invoke(null, new object[]
							{
								dataRowEventArgs
							});
						}
						catch (Exception a_)
						{
							ooO.oOo0Oo.o.(a_, "表，" + this.Name + "，DataRowAdded");
						}
					}
					if (this.GlobalHandler.DataRowAdded && O_O0OO.O0_00o.o0__o..Oo0.oo_o. != null)
					{
						try
						{
							O_O0OO.O0_00o.o0__o..Oo0.oo_o..Invoke(null, new object[]
							{
								dataRowEventArgs
							});
						}
						catch (Exception a_2)
						{
							ooO.oOo0Oo.o.(a_2, "全局事件, DataRowAdded");
						}
					}
				}
			}
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00100198 File Offset: 0x000FE398
		private void <<EMPTY_NAME>>(object A_0, DataRowChangeEventArgs A_1)
		{
			this.o_oO0O_.O0. = null;
			if (this._DataTable.DataSet != null && !this.o.OOO_oO0_0O_o. && Operators.CompareString(A_1.Row.RowError, "", true) <= 0)
			{
				if (this.O._O00000. != null && OO_00oOO.SystemReady)
				{
					DataRowEventArgs dataRowEventArgs = new DataRowEventArgs(this, new DataRow(A_1.Row));
					try
					{
						this.O._O00000..Invoke(null, new object[]
						{
							dataRowEventArgs
						});
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "表，" + this.Name + "，DataRowDeleted");
					}
				}
				if (this.GlobalHandler.DataRowDeleted && O_O0OO.O0_00o.o0__o..ooo._o000. != null && OO_00oOO.SystemReady)
				{
					DataRowEventArgs dataRowEventArgs2 = new DataRowEventArgs(this, new DataRow(A_1.Row));
					try
					{
						O_O0OO.O0_00o.o0__o..ooo._o000..Invoke(null, new object[]
						{
							dataRowEventArgs2
						});
					}
					catch (Exception a_2)
					{
						ooO.oOo0Oo.o.(a_2, "全局表事件, DataRowDeleted");
					}
				}
			}
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x001002CC File Offset: 0x000FE4CC
		private void <<EMPTY_NAME>>(object A_0, DataRowChangeEventArgs A_1)
		{
			if (Operators.CompareString(A_1.Row.RowError, "", true) <= 0 && !this.o.OOO_oO0_0O_o.)
			{
				if (this.o_o._000_0_. != null && OO_00oOO.SystemReady)
				{
					DataRowEventArgs dataRowEventArgs = new DataRowEventArgs(this, new DataRow(A_1.Row));
					try
					{
						this.o_o._000_0_..Invoke(null, new object[]
						{
							dataRowEventArgs
						});
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "表，" + this.Name + "，DataRowDeleting");
					}
				}
				if (this.GlobalHandler.DataRowDeleting && O_O0OO.O0_00o.o0__o..O.__0__O0O0oOo. != null && OO_00oOO.SystemReady)
				{
					DataRowEventArgs dataRowEventArgs2 = new DataRowEventArgs(this, new DataRow(A_1.Row));
					try
					{
						O_O0OO.O0_00o.o0__o..O.__0__O0O0oOo..Invoke(null, new object[]
						{
							dataRowEventArgs2
						});
					}
					catch (Exception a_2)
					{
						ooO.oOo0Oo.o.(a_2, "全局表事件, DataRowDeleting");
					}
				}
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable.BaseTable == this.BaseTable)
						{
							table.O0o._oo_.(A_1.Row, false);
							table.o.0oOoO__0_o0.(A_1.Row);
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				try
				{
					foreach (object obj in this.BaseTable.ChildRelations)
					{
						O0Oo o0Oo = (O0Oo)obj;
						if (o0Oo.o.O0_o.())
						{
							foreach (DataRow a_3 in A_1.Row.GetChildRows(o0Oo))
							{
								new DataRow(a_3).Delete();
							}
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
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x001004E0 File Offset: 0x000FE6E0
		internal void <<EMPTY_NAME>>(bool A_0 = false)
		{
			if (!this.AddByCode)
			{
				try
				{
					DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
					{
						this.Name,
						""
					});
					if (dataRow == null)
					{
						dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].NewRow();
						dataRow["Table"] = this.Name;
						dataRow["Column"] = "";
						O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Add(dataRow);
					}
					dataRow["Config"] = o_O_o_oOoo__.OOOO_OO._oo.(this.frd_Setting, false, '\v', false);
					if (A_0)
					{
						string text = o_O_o_oOoo__.OOOO_OO._oo.(this.frd_Setting, true, '\v', false);
						if (Operators.CompareString(text, "", true) > 0)
						{
							dataRow["Code"] = "[" + O00.ooo000o_0.00o0.(text, Oo00.ooO.ooo.(), ooO0__OO.o.0_0_ooO.()) + "]";
						}
						else
						{
							dataRow["Code"] = null;
						}
					}
					dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
					{
						"{" + this.Name + "}",
						""
					});
					if (dataRow == null)
					{
						dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].NewRow();
						dataRow["Table"] = "{" + this.Name + "}";
						dataRow["Column"] = "";
						O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Add(dataRow);
					}
					dataRow["Config"] = o_O_o_oOoo__.OOOO_OO._oo.(this.frd_LookAndFeel, false, '\v', false);
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
			}
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0010071C File Offset: 0x000FE91C
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (A_0.StartsWith("[") && A_0.EndsWith("]"))
			{
				A_0 = A_0.TrimStart(new char[]
				{
					'['
				}).TrimEnd(new char[]
				{
					']'
				});
				result = O00.oO_.0o_oo_0O_.(A_0, Oo00.ooO.ooo.(), ooO0__OO.o.0_0_ooO.());
			}
			else
			{
				result = O00.oO_.0o_oo_0O_.(A_0, O_O0OO.O_O._Oo.(), ooO0__OO.o.0_0_ooO.());
			}
			return result;
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x0010078B File Offset: 0x000FE98B
		// (set) Token: 0x060023CB RID: 9163 RVA: 0x001007B1 File Offset: 0x000FE9B1
		internal bool frd_AutoIncrement
		{
			get
			{
				return this.BaseTable.PrimaryKey.Length == 1 && this.BaseTable.PrimaryKey[0].AutoIncrement;
			}
			set
			{
			}
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x001007B4 File Offset: 0x000FE9B4
		internal void <<EMPTY_NAME>>(DataRow[] A_0)
		{
			if (!this.frd_IsTemporary && !this.frd_IsInnerQuery && !this.frd_IsOuterQuery && this._Adapter.InsertCommand != null)
			{
				this._Adapter.InsertCommand.CommandTimeout = this.FillLoadTimeOut;
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.View.o_o.O0ooOo.() == this._DataTable)
						{
							table.ClearEditInfos();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				ConnectionState state = this.o0__.Oo0o__O..State;
				OleDbCommand oleDbCommand = new OleDbCommand("", this.o0__.Oo0o__O.);
				if (A_0.Length == 0)
				{
					object obj = this._DataTable;
					lock (obj)
					{
						A_0 = this._DataTable.Select("", "", DataViewRowState.Added);
					}
				}
				if (A_0.Length > 0)
				{
					try
					{
						if (state != ConnectionState.Open)
						{
							this.o0__.Oo0o__O..Open();
						}
						this.StopRedraw();
						if (this.frd_IsOuterTable)
						{
							this.o00o.00oO___0. = null;
							this.O_0o._o0_0. = (A_0.Length == 1);
							if (this.frd_AutoIncrement)
							{
								string provider = this.o0__.Oo0o__O..Provider;
								if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.o0__.Oo0o__O.))
								{
									if (Operators.CompareString(this.SEQUENCE, "", true) > 0 && Operators.CompareString(this.SEQUENCE, "@@@", true) != 0)
									{
										OleDbCommand oleDbCommand2 = new OleDbCommand("SELECT " + this.SEQUENCE + ".NEXTVAl FROM DUAL", this.o0__.Oo0o__O.);
										string columnName = this.BaseTable.PrimaryKey[0].ColumnName;
										List<long> list = new List<long>();
										int num = A_0.Length - 1;
										for (int i = 0; i <= num; i++)
										{
											list.Add(Convert.ToInt64(RuntimeHelpers.GetObjectValue(oleDbCommand2.ExecuteScalar())));
										}
										for (int j = A_0.Length - 1; j >= 0; j += -1)
										{
											A_0[j][columnName] = list[j];
										}
									}
								}
								else
								{
									this.o00o.00oO___0. = new OleDbCommand("Select @@IDENTITY", this.o0__.Oo0o__O.);
									this.o00o.00oO___0..Transaction = this._Adapter.SelectCommand.Transaction;
								}
							}
							try
							{
								try
								{
									this._DataTable.BeginLoadData();
									this._Adapter.Update(A_0);
								}
								catch (Exception a_)
								{
									ooO.oOo0Oo.o.(a_, "");
								}
								goto IL_524;
							}
							finally
							{
								this._DataTable.EndLoadData();
							}
						}
						OleDbCommand oleDbCommand3 = new OleDbCommand(string.Concat(new string[]
						{
							"Select [Identify] From [",
							ooO0__OO.O00.O__o.(),
							"] Where [Table] = '",
							this.o._OOO0oOo0__.,
							"'"
						}), this.o0__.Oo0o__O.);
						OleDbCommand oleDbCommand4 = new OleDbCommand("Select Max([_Identify]) From [" + this.o._OOO0oOo0__..Trim(new char[]
						{
							'[',
							']'
						}) + "]", this.o0__.Oo0o__O.);
						int num3;
						for (;;)
						{
							int num2 = Conversions.ToInteger(oleDbCommand3.ExecuteScalar());
							object obj2 = RuntimeHelpers.GetObjectValue(oleDbCommand4.ExecuteScalar());
							if (obj2 == DBNull.Value)
							{
								obj2 = 0;
							}
							num3 = Math.Max(num2, Conversions.ToInteger(obj2) + 1);
							oleDbCommand.CommandText = string.Concat(new string[]
							{
								"Update [",
								ooO0__OO.O00.O__o.(),
								"] Set [Identify]  = ",
								Conversions.ToString(num3 + A_0.Length),
								" where [Table] = '",
								this.o._OOO0oOo0__.,
								"' And [Identify] = ",
								Conversions.ToString(num2)
							});
							if (oleDbCommand.ExecuteNonQuery() > 0)
							{
								break;
							}
							this.o0.O_o.();
						}
						this.O._0O_O0O.(num3);
						if (A_0.Length == 1)
						{
							DataRow dataRow = A_0[0];
							object obj3 = this._DataTable;
							DataRow[] array;
							lock (obj3)
							{
								array = this._DataTable.Select("", "", DataViewRowState.Added);
							}
							foreach (DataRow dataRow2 in array)
							{
								if (dataRow2 != dataRow && Conversions.ToInteger(dataRow2["_Identify"]) == num3)
								{
									dataRow2["_Identify"] = Conversions.ToInteger(this.BaseTable.Compute("Max([_Identify])", "")) + 1;
									break;
								}
							}
						}
						int num4 = num3;
						int num5 = Conversions.ToInteger(A_0[0]["_Identify"]);
						try
						{
							this._DataTable.BeginLoadData();
							if (num4 <= num5)
							{
								int num6 = A_0.Length - 1;
								for (int l = 0; l <= num6; l++)
								{
									A_0[l]["_Identify"] = num3 + l;
								}
							}
							else
							{
								for (int m = A_0.Length - 1; m >= 0; m += -1)
								{
									A_0[m]["_Identify"] = num3 + m;
								}
							}
							this._Adapter.Update(A_0);
						}
						catch (Exception a_2)
						{
							ooO.oOo0Oo.o.(a_2, "");
						}
						finally
						{
							this._DataTable.EndLoadData();
						}
						IL_524:;
					}
					catch (Exception a_3)
					{
						ooO.oOo0Oo.o.(a_3, "");
					}
					finally
					{
						this.ResumeRedraw();
						if (state != ConnectionState.Open)
						{
							this.o0__.Oo0o__O..Close();
						}
					}
				}
			}
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x00100DF4 File Offset: 0x000FEFF4
		private void <<EMPTY_NAME>>(int A_0)
		{
			object obj = this._DataTable;
			DataRow[] array;
			lock (obj)
			{
				array = this._DataTable.Select("[_Identify] >= " + Conversions.ToString(A_0));
			}
			if (array.Length > 0)
			{
				foreach (DataRow dataRow in array)
				{
					if (dataRow.RowState != DataRowState.Added)
					{
						dataRow.RowError = "a";
						this._DataTable.Rows.Remove(dataRow);
					}
				}
			}
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x00100E94 File Offset: 0x000FF094
		internal void <<EMPTY_NAME>>(DataRow[] A_0)
		{
			if (!this.frd_IsTemporary && !this.frd_IsInnerQuery && !this.frd_IsOuterQuery && this._Adapter.UpdateCommand != null)
			{
				this._Adapter.UpdateCommand.CommandTimeout = this.FillLoadTimeOut;
				ConnectionState state = this.o0__.Oo0o__O..State;
				if (A_0.Length == 0)
				{
					object obj = this._DataTable;
					lock (obj)
					{
						A_0 = this._DataTable.Select("", "", DataViewRowState.ModifiedCurrent);
					}
				}
				if (A_0.Length > 0)
				{
					int num;
					foreach (DataRow dataRow in A_0)
					{
						Oo00.o0_o._O_.(dataRow);
						if (dataRow.RowState == DataRowState.Modified)
						{
							num++;
						}
					}
					if (num != 0)
					{
						try
						{
							if (state != ConnectionState.Open)
							{
								this.o0__.Oo0o__O..Open();
							}
							this._Adapter.Update(A_0);
						}
						catch (Exception a_)
						{
							ooO.oOo0Oo.o.(a_, "");
						}
						finally
						{
							if (state != ConnectionState.Open)
							{
								this.o0__.Oo0o__O..Close();
							}
						}
					}
				}
			}
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x00100FD8 File Offset: 0x000FF1D8
		internal void <<EMPTY_NAME>>(DataRow[] A_0)
		{
			if (!this.frd_IsTemporary && !this.frd_IsInnerQuery && !this.frd_IsOuterQuery && this._Adapter.DeleteCommand != null)
			{
				this._Adapter.DeleteCommand.CommandTimeout = this.FillLoadTimeOut;
				ConnectionState state = this.o0__.Oo0o__O..State;
				if (A_0.Length == 0)
				{
					object obj = this._DataTable;
					lock (obj)
					{
						A_0 = this._DataTable.Select("", "", DataViewRowState.Deleted);
					}
				}
				if (A_0.Length > 0)
				{
					try
					{
						if (state != ConnectionState.Open)
						{
							this.o0__.Oo0o__O..Open();
						}
						this._Adapter.Update(A_0);
						if (this.frd_IsInnerTable)
						{
							this.o0_0.o_.();
						}
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
					finally
					{
						if (state != ConnectionState.Open)
						{
							this.o0__.Oo0o__O..Close();
						}
					}
				}
			}
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x001010F8 File Offset: 0x000FF2F8
		internal void <<EMPTY_NAME>>()
		{
			OleDbCommand oleDbCommand = new OleDbCommand("Select Max([_Identify]) From [" + this.o._OOO0oOo0__..Trim(new char[]
			{
				'[',
				']'
			}) + "]", this.o0__.Oo0o__O.);
			long num = (long)Conversions.ToInteger(new OleDbCommand(string.Concat(new string[]
			{
				"Select [Identify] From [",
				ooO0__OO.O00.O__o.(),
				"] Where [Table] = '",
				this.o._OOO0oOo0__.,
				"'"
			}), this.o0__.Oo0o__O.).ExecuteScalar());
			object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
			long num2;
			if (objectValue == DBNull.Value)
			{
				num2 = 1L;
			}
			else
			{
				num2 = (long)(Conversions.ToInteger(objectValue) + 1);
			}
			if (num > num2)
			{
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Update [",
					ooO0__OO.O00.O__o.(),
					"] Set [Identify]  = ",
					Conversions.ToString(num2),
					" Where [Table] = '",
					this.o._OOO0oOo0__.,
					"' And [Identify] = ",
					Conversions.ToString(num)
				});
				oleDbCommand.ExecuteNonQuery();
			}
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x00101208 File Offset: 0x000FF408
		internal void <<EMPTY_NAME>>()
		{
			OleDbCommand oleDbCommand = new OleDbCommand("", this.o0__.Oo0o__O.);
			OleDbCommand oleDbCommand2 = new OleDbCommand("", this.o0__.Oo0o__O.);
			oleDbCommand.CommandText = string.Concat(new string[]
			{
				"Select Count(*) From [",
				ooO0__OO.O00.O__o.(),
				"] Where [Table] = '",
				this.o._OOO0oOo0__.,
				"'"
			});
			oleDbCommand2.CommandText = "Select Max([_Identify]) From [" + this.o._OOO0oOo0__..Trim(new char[]
			{
				'[',
				']'
			}) + "]";
			int value;
			if (this.BaseTable.Rows.Count > 0)
			{
				value = Conversions.ToInteger(this.Compute("Max([_Identify])")) + 1;
			}
			else
			{
				value = 1;
			}
			oleDbCommand2.CommandText = string.Concat(new string[]
			{
				"Insert into [",
				ooO0__OO.O00.O__o.(),
				"] ([Table],[Identify]) values ('",
				this.o._OOO0oOo0__.,
				"',",
				Conversions.ToString(value),
				")"
			});
			int state = (int)this.o0__.Oo0o__O..State;
			if (this.o0__.Oo0o__O..State != ConnectionState.Open)
			{
				this.o0__.Oo0o__O..Open();
			}
			if (Conversions.ToInteger(oleDbCommand.ExecuteScalar()) == 0)
			{
				oleDbCommand2.ExecuteNonQuery();
			}
			if (state != 1)
			{
				this.o0__.Oo0o__O..Close();
			}
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0010135C File Offset: 0x000FF55C
		internal bool <<EMPTY_NAME>>(bool A_0, bool A_1)
		{
			bool result;
			if (this.frd_IsTemporary || this.frd_IsInnerQuery || this.frd_IsOuterQuery)
			{
				this._DataTable.AcceptChanges();
				result = true;
			}
			else if (A_1 && !this.o.o_O.())
			{
				result = false;
			}
			else
			{
				this.O0_0oOO.0.(new DataRow[0]);
				this.oO.o_0.(new DataRow[0]);
				this.oo_.0oo_.(new DataRow[0]);
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.View.o_o.O0ooOo.() == this._DataTable)
						{
							table.foxGrid.Invalidate();
							table.foxGrid.Refresh();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (A_0)
				{
					try
					{
						foreach (Table table2 in OO_00oOO.Tables)
						{
							if (table2.View.o_o.O0ooOo.() == this._DataTable)
							{
								table2.Oo._0oO.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00101480 File Offset: 0x000FF680
		internal void <<EMPTY_NAME>>()
		{
			if (!this.AddByCode)
			{
				DockSetting a_ = new DockSetting(this);
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
				DataRow dataRow = dataTable.Rows.Find(new object[]
				{
					this.Name,
					"",
					ExtendTablePropertyTypeEnum.DockSetting
				});
				if (dataRow == null)
				{
					dataRow = dataTable.NewRow();
					dataRow["Table"] = this.Name;
					dataRow["Type"] = ExtendTablePropertyTypeEnum.DockSetting;
					dataRow["Name"] = "";
					dataTable.Rows.Add(dataRow);
				}
				dataRow["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\v', false);
			}
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00101540 File Offset: 0x000FF740
		internal bool <<EMPTY_NAME>>()
		{
			DataRow[] array = this.BaseTable.Select("", "", DataViewRowState.ModifiedCurrent);
			List<DataRow> list = new List<DataRow>();
			int num = array.Length - 1;
			bool result;
			for (int i = 0; i <= num; i++)
			{
				list.Add(array[i]);
				if (list.Count >= this.BatchUpdateSize || i == array.Length - 1)
				{
					if (!oOO0oO000_0_0.oOoOo_o.__.(this, list.ToArray()))
					{
						result = false;
						return result;
					}
					list.Clear();
				}
			}
			array = this.BaseTable.Select("", "", DataViewRowState.Deleted);
			int num2 = array.Length - 1;
			for (int j = 0; j <= num2; j++)
			{
				list.Add(array[j]);
				if (list.Count >= this.BatchUpdateSize || j == array.Length - 1)
				{
					if (!oOO0oO000_0_0.OO.OoO0.(this, list.ToArray()))
					{
						return false;
					}
					list.Clear();
				}
			}
			try
			{
				this.StopRedraw();
				this.BaseTable.BeginLoadData();
				array = this.BaseTable.Select("", "", DataViewRowState.Added);
				int num3 = array.Length - 1;
				for (int k = 0; k <= num3; k++)
				{
					list.Add(array[k]);
					if (list.Count >= this.BatchUpdateSize || k == array.Length - 1)
					{
						if (!oOO0oO000_0_0.o__o.OOO__.(this, list.ToArray()))
						{
							return false;
						}
						list.Clear();
					}
				}
				result = true;
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				this.BaseTable.EndLoadData();
				this.ResumeRedraw();
			}
			return result;
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x001016F0 File Offset: 0x000FF8F0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Save(params object[] args)
		{
			if (args.Length == 0)
			{
				this.Save();
				return;
			}
			if (args.Length == 1)
			{
				this.Save(Conversions.ToBoolean(args[0]));
			}
		}

		/// <summary>
		/// 保存数据，但不保存设置
		/// </summary>
		// Token: 0x060023D6 RID: 9174 RVA: 0x00101714 File Offset: 0x000FF914
		[oO0oooo("0399")]
		public void Save()
		{
			if (Operators.CompareString(this.DataServer, "", true) > 0)
			{
				if (Operators.CompareString(this.UpdateServer, "", true) <= 0)
				{
					this._DataTable.AcceptChanges();
					return;
				}
				if (this.o.o_O.())
				{
					this.O0o0.O_0_.();
					return;
				}
			}
			else if (this.frd_IsTemporary || this.frd_IsInnerQuery || this.frd_IsOuterQuery)
			{
				if (this._DataTable.GetChanges() != null)
				{
					this._DataTable.AcceptChanges();
					return;
				}
			}
			else if (this.o.o_O.())
			{
				this.O0_0oOO.0.(new DataRow[0]);
				this.oO.o_0.(new DataRow[0]);
				this.oo_.0oo_.(new DataRow[0]);
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.View.o_o.O0ooOo.() == this._DataTable)
						{
							table.foxGrid.Invalidate();
							table.foxGrid.Refresh();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 保存数据和设置
		/// </summary>
		/// <param name="saveSetting">可选，设置为True同时保存设置，否则只保存数据</param>
		// Token: 0x060023D7 RID: 9175 RVA: 0x0010182C File Offset: 0x000FFA2C
		[oO0oooo("0399")]
		public void Save(bool saveSetting)
		{
			this.Save();
			if (saveSetting)
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.View.o_o.O0ooOo.() == this._DataTable)
						{
							table.oo0OO0Ooo._.(true);
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x00101894 File Offset: 0x000FFA94
		internal void <<EMPTY_NAME>>()
		{
			o_O_o_oOoo__.OO_O0oO0.oooO_.(this._Adapter);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x001018A4 File Offset: 0x000FFAA4
		internal StructureCompareResult <<EMPTY_NAME>>(DataTable A_0)
		{
			List<string> list = new List<string>();
			DataTable dataTable = new DataTable();
			StructureCompareResult structureCompareResult = new StructureCompareResult();
			if (this._Adapter != null)
			{
				this._Adapter.FillSchema(dataTable, SchemaType.Source);
			}
			else if (this.DataServer != null)
			{
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
				httpClient.Select = this.HttpSelect;
				httpClient.FormData["Action"] = 12.ToString();
				dataTable = httpClient.GetBaseDataTable();
			}
			if (dataTable.PrimaryKey.Length != A_0.PrimaryKey.Length || dataTable.PrimaryKey.Length == 0)
			{
				structureCompareResult.Ooo0.o. = false;
			}
			else
			{
				foreach (DataColumn dataColumn in dataTable.PrimaryKey)
				{
					bool flag;
					foreach (DataColumn dataColumn2 in A_0.PrimaryKey)
					{
						if (Operators.CompareString(dataColumn.ColumnName, dataColumn2.ColumnName, true) == 0 && dataColumn.DataType == dataColumn2.DataType)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						structureCompareResult.Ooo0.o. = false;
						break;
					}
				}
			}
			try
			{
				foreach (object obj in this._DataTable.Columns)
				{
					DataColumn dataColumn3 = (DataColumn)obj;
					if (dataTable.Columns.Contains(dataColumn3.ColumnName))
					{
						try
						{
							foreach (object obj2 in O_O0OO.OOOo.oo_OOOO_0.().Relations)
							{
								DataRelation dataRelation = (DataRelation)obj2;
								int num = dataRelation.ParentColumns.Length - 1;
								for (int k = 0; k <= num; k++)
								{
									if (dataRelation.ParentColumns[k] == dataColumn3 | dataRelation.ChildColumns[k] == dataColumn3)
									{
										list.Add(dataColumn3.ColumnName);
										break;
									}
								}
								if (list.Contains(dataColumn3.ColumnName))
								{
									break;
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
			try
			{
				foreach (string text in list)
				{
					if (!A_0.Columns.Contains(text) || dataTable.Columns[text].DataType != A_0.Columns[text].DataType)
					{
						MessageBox.Show(string.Concat(new string[]
						{
							"[",
							this.Name,
							"]通过列[",
							text,
							"]和其他表建立了关联，新的数据源必须包括此列！"
						}), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						structureCompareResult.o_O__.0O. = false;
						break;
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			return structureCompareResult;
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00101B9C File Offset: 0x000FFD9C
		internal string <<EMPTY_NAME>>(string A_0, bool A_1 = true)
		{
			DataColumn dataColumn = this._DataTable.Columns.Add();
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if ((table.Name.StartsWith(this.Name + ".") || table.View.o_o.O0ooOo.() == this._DataTable) && table.foxGrid.Cols.Contains(dataColumn.ColumnName))
					{
						table.foxGrid.Cols.Remove(dataColumn.ColumnName);
					}
					table.O.__O0o0.(true, false);
					if ((table.Name.StartsWith(this.Name + ".") || table.View.o_o.O0ooOo.() == this._DataTable) && table.foxGrid.FindForm() != null)
					{
						table._frdTableLayout.OOooOOo_.0_0_o.();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			string result;
			try
			{
				O\u3002o\u3002\u3002\u3000 o_u3002o_u3002_u3002_u = new O\u3002o\u3002\u3002\u3000(this._DataTable, dataColumn, A_0, A_1);
				if (o_u3002o_u3002_u3002_u.ShowDialog() == DialogResult.OK)
				{
					result = o_u3002o_u3002_u3002_u.oO.o0oOo_o__O.().Text;
				}
				else
				{
					result = A_0;
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				result = A_0;
			}
			finally
			{
				OO_00oOO.SystemReady = false;
				this._DataTable.Columns.Remove(dataColumn);
				OO_00oOO.SystemReady = true;
				try
				{
					foreach (Table table2 in OO_00oOO.Tables)
					{
						table2.O.__O0o0.(true, false);
						if ((table2.Name.StartsWith(this.Name + ".") || table2.View.o_o.O0ooOo.() == this._DataTable) && table2.foxGrid.FindForm() != null)
						{
							table2._frdTableLayout.Oo_.oo_oOo_oO.();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
			return result;
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00101DC4 File Offset: 0x000FFFC4
		private void <<EMPTY_NAME>>(object A_0, OleDbRowUpdatedEventArgs A_1)
		{
			if (this.o00o.00oO___0. != null && A_1.Status == UpdateStatus.Continue && A_1.StatementType == StatementType.Insert && A_1.RecordsAffected == 1)
			{
				if (this.O_0o._o0_0.)
				{
					this.O_0o._o0_0. = false;
					object objectValue = RuntimeHelpers.GetObjectValue(this.o00o.00oO___0..ExecuteScalar());
					DataRow dataRow = this._DataTable.Rows.Find(RuntimeHelpers.GetObjectValue(objectValue));
					if (dataRow != null && dataRow != A_1.Row)
					{
						dataRow[this._DataTable.PrimaryKey[0].ColumnName] = Conversions.ToInteger(this.BaseTable.Compute("Max([" + this._DataTable.PrimaryKey[0].ColumnName + "])", "")) + 1;
					}
					A_1.Row[this._DataTable.PrimaryKey[0].ColumnName] = RuntimeHelpers.GetObjectValue(objectValue);
				}
				else
				{
					A_1.Row[this._DataTable.PrimaryKey[0].ColumnName] = RuntimeHelpers.GetObjectValue(this.o00o.00oO___0..ExecuteScalar());
				}
			}
			UpdateRowEventArgs updateRowEventArgs = new UpdateRowEventArgs(this, new DataRow(A_1.Row), A_1);
			if (this.O_000o_.O. != null && OO_00oOO.SystemReady)
			{
				try
				{
					this.O_000o_.O..Invoke(null, new object[]
					{
						updateRowEventArgs
					});
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "表，" + this.Name + "，AfterSaveDataRow");
				}
			}
			if (!updateRowEventArgs.Cancel && this.GlobalHandler.AfterSaveDataRow && OO_00oOO.SystemReady && O_O0OO.O0_00o.o0__o..Oo.o0_O. != null)
			{
				try
				{
					O_O0OO.O0_00o.o0__o..Oo.o0_O..Invoke(null, new object[]
					{
						updateRowEventArgs
					});
				}
				catch (Exception a_2)
				{
					ooO.oOo0Oo.o.(a_2, "全局表事件, AfterSaveDataRow");
				}
			}
			if (A_1.RecordsAffected == 0)
			{
				if (A_1.StatementType == StatementType.Delete)
				{
					if (A_1.Errors is DBConcurrencyException)
					{
						A_1.Status = UpdateStatus.SkipCurrentRow;
					}
					else
					{
						ooO.oOo0Oo.o.(A_1.Errors, "");
						A_1.Status = UpdateStatus.SkipAllRemainingRows;
					}
					A_1.Row.AcceptChanges();
					return;
				}
				if (A_1.StatementType == StatementType.Update)
				{
					if (A_1.Errors is DBConcurrencyException)
					{
						A_1.Row.RowError = "a";
						A_1.Row.Delete();
						A_1.Row.AcceptChanges();
						A_1.Status = UpdateStatus.SkipCurrentRow;
						return;
					}
					ooO.oOo0Oo.o.(A_1.Errors, "");
					A_1.Status = UpdateStatus.SkipAllRemainingRows;
					return;
				}
				else if (A_1.StatementType == StatementType.Insert)
				{
					ooO.oOo0Oo.o.(A_1.Errors, "");
					if (this.frd_IsInnerTable)
					{
						A_1.Status = UpdateStatus.SkipCurrentRow;
						return;
					}
					A_1.Status = UpdateStatus.SkipAllRemainingRows;
				}
			}
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x001020A8 File Offset: 0x001002A8
		internal bool <<EMPTY_NAME>>()
		{
			object obj = this._DataTable;
			DataRow[] array;
			lock (obj)
			{
				array = this._DataTable.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
			}
			bool result;
			if (array.Length == 0)
			{
				result = true;
			}
			else
			{
				foreach (DataRow a_ in array)
				{
					DataRowEventArgs dataRowEventArgs = new DataRowEventArgs(this, new DataRow(a_));
					if (this.o.__Oo_Oo_. != null && OO_00oOO.SystemReady)
					{
						try
						{
							this.o.__Oo_Oo_..Invoke(null, new object[]
							{
								dataRowEventArgs
							});
						}
						catch (Exception a_2)
						{
							ooO.oOo0Oo.o.(a_2, "表，" + this.Name + "，BeforeSaveDataRow");
						}
					}
					if (!dataRowEventArgs.Cancel && this.GlobalHandler.BeforeSaveDataRow && OO_00oOO.SystemReady && O_O0OO.O0_00o.o0__o..O__0o._O_oo. != null)
					{
						try
						{
							O_O0OO.O0_00o.o0__o..O__0o._O_oo..Invoke(null, new object[]
							{
								dataRowEventArgs
							});
						}
						catch (Exception a_3)
						{
							ooO.oOo0Oo.o.(a_3, "全局表事件, BeforeSaveDataRow");
						}
					}
					if (dataRowEventArgs.Cancel)
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x00102218 File Offset: 0x00100418
		// (set) Token: 0x060023DE RID: 9182 RVA: 0x001022A8 File Offset: 0x001004A8
		internal string frd_RightDockOrder
		{
			get
			{
				try
				{
					foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
					{
						Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
						if (Operators.CompareString(oo0__Oo.O_000__.o.().Name, this.Name, true) == 0)
						{
							if (oo0__Oo.o.0O_O0o_.())
							{
								return oo0__Oo.o__0_.o0OoOOO.().OO_o0_oO.0.();
							}
							break;
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
				return null;
			}
			set
			{
				this.O.__00_o0. = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060023DF RID: 9183 RVA: 0x001022B4 File Offset: 0x001004B4
		// (set) Token: 0x060023E0 RID: 9184 RVA: 0x0010235C File Offset: 0x0010055C
		internal int frd_RightDockSize
		{
			get
			{
				try
				{
					foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
					{
						Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
						if (Operators.CompareString(oo0__Oo.O_000__.o.().Name, this.Name, true) == 0)
						{
							if (oo0__Oo.o.0O_O0o_.() && oo0__Oo.o__0_.o0OoOOO.().Controls.Count > 0)
							{
								return oo0__Oo.o__0_.o0OoOOO.().OO_o0_oO.0.();
							}
							break;
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
				return this.o_oO0O_.O0.;
			}
			set
			{
				this.o_oO0O_.O0. = value;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x00102368 File Offset: 0x00100568
		// (set) Token: 0x060023E2 RID: 9186 RVA: 0x001023F8 File Offset: 0x001005F8
		internal string frd_BottomDockOrder
		{
			get
			{
				try
				{
					foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
					{
						Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
						if (Operators.CompareString(oo0__Oo.O_000__.o.().Name, this.Name, true) == 0)
						{
							if (oo0__Oo.O_0.o0.())
							{
								return oo0__Oo.O._o_00__.().OO_o0_oO.0.();
							}
							break;
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
				return null;
			}
			set
			{
				this.O_oo.__0_. = value;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060023E3 RID: 9187 RVA: 0x00102404 File Offset: 0x00100604
		// (set) Token: 0x060023E4 RID: 9188 RVA: 0x001024AC File Offset: 0x001006AC
		internal int frd_BottomDockSize
		{
			get
			{
				try
				{
					foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
					{
						Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
						if (Operators.CompareString(oo0__Oo.O_000__.o.().Name, this.Name, true) == 0)
						{
							if (oo0__Oo.O_0.o0.() && oo0__Oo.O._o_00__.().Controls.Count > 0)
							{
								return oo0__Oo.O._o_00__.().OO_o0_oO.0.();
							}
							break;
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
				return this.o0O._ooo_o___.;
			}
			set
			{
				this.o0O._ooo_o___. = value;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x001024B8 File Offset: 0x001006B8
		// (set) Token: 0x060023E6 RID: 9190 RVA: 0x00102548 File Offset: 0x00100748
		internal string frd_TopDockOrder
		{
			get
			{
				try
				{
					foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
					{
						Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
						if (Operators.CompareString(oo0__Oo.O_000__.o.().Name, this.Name, true) == 0)
						{
							if (oo0__Oo.O.o__OO0oO_0.())
							{
								return oo0__Oo.O_000__.o.().OO_o0_oO.0.();
							}
							break;
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
				return null;
			}
			set
			{
				this.o_0o0o0oo0.O. = value;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x00102554 File Offset: 0x00100754
		// (set) Token: 0x060023E8 RID: 9192 RVA: 0x001025FC File Offset: 0x001007FC
		internal int frd_TopDockSize
		{
			get
			{
				try
				{
					foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
					{
						Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
						if (Operators.CompareString(oo0__Oo.O_000__.o.().Name, this.Name, true) == 0)
						{
							if (oo0__Oo.O.o__OO0oO_0.() && oo0__Oo.O_000__.o.().Controls.Count > 0)
							{
								return oo0__Oo.O_000__.o.().OO_o0_oO.0.();
							}
							break;
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
				return this.o_o._OOoo0OOoO.;
			}
			set
			{
				this.o_o._OOoo0OOoO. = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x00102608 File Offset: 0x00100808
		// (set) Token: 0x060023EA RID: 9194 RVA: 0x00102698 File Offset: 0x00100898
		internal string frd_LeftDockOrder
		{
			get
			{
				try
				{
					foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
					{
						Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
						if (Operators.CompareString(oo0__Oo.O_000__.o.().Name, this.Name, true) == 0)
						{
							if (oo0__Oo.O._o_00__.())
							{
								return oo0__Oo.O__O.o_oOO.().OO_o0_oO.0.();
							}
							break;
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
				return null;
			}
			set
			{
				this.Oo0O00Ooo._. = value;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x001026A4 File Offset: 0x001008A4
		// (set) Token: 0x060023EC RID: 9196 RVA: 0x0010275C File Offset: 0x0010095C
		internal int frd_LeftDockSize
		{
			get
			{
				try
				{
					foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
					{
						Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
						if (Operators.CompareString(oo0__Oo.O_000__.o.().Name, this.Name, true) == 0)
						{
							if (oo0__Oo.O._o_00__.() && oo0__Oo.O__O.o_oOO.().Controls.Count > 0)
							{
								return oo0__Oo.O__O.o_oOO.().OO_o0_oO.0.();
							}
							break;
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
				int result;
				if (this.OO._0oo000_00. == 0)
				{
					result = 200;
				}
				else
				{
					result = this.OO._0oo000_00.;
				}
				return result;
			}
			set
			{
				this.OO._0oo000_00. = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x00102765 File Offset: 0x00100965
		// (set) Token: 0x060023EE RID: 9198 RVA: 0x0010276D File Offset: 0x0010096D
		internal string frd_AsmCrcString
		{
			get
			{
				return this.OO0__o0o0O_O.0.;
			}
			set
			{
				this.OO0__o0o0O_O.0. = value;
			}
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00102778 File Offset: 0x00100978
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
				{
					Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
					if (Operators.CompareString(oo0__Oo.O_000__.o.().Name, this.Name, true) == 0)
					{
						if (oo0__Oo.o.0O_O0o_.())
						{
							oo0__Oo.o__0_.o0OoOOO.().OoOoo_O0o0.0O_.(this.O.__00_o0.);
							oo0__Oo.o__0_.o0OoOOO.().o_o.O___0o.();
						}
						if (oo0__Oo.O._o_00__.())
						{
							oo0__Oo.O__O.o_oOO.().OoOoo_O0o0.0O_.(this.Oo0O00Ooo._.);
							oo0__Oo.O__O.o_oOO.().o_o.O___0o.();
						}
						if (oo0__Oo.O_0.o0.())
						{
							oo0__Oo.O._o_00__.().OoOoo_O0o0.0O_.(this.O_oo.__0_.);
							oo0__Oo.O._o_00__.().o_o.O___0o.();
						}
						if (oo0__Oo.O.o__OO0oO_0.())
						{
							oo0__Oo.O_000__.o.().OoOoo_O0o0.0O_.(this.o_0o0o0oo0.O.);
							oo0__Oo.O_000__.o.().o_o.O___0o.();
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
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x00102888 File Offset: 0x00100A88
		// (set) Token: 0x060023F1 RID: 9201 RVA: 0x00102890 File Offset: 0x00100A90
		internal string frd_CustomImage
		{
			get
			{
				return this.O_Oo._.;
			}
			set
			{
				this.O_Oo._. = value;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x0010289C File Offset: 0x00100A9C
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x001028DA File Offset: 0x00100ADA
		internal Image frd_Icon
		{
			get
			{
				Image image = null;
				if (Operators.CompareString(this.frd_CustomImage, "", true) > 0)
				{
					image = OO_00oOO.GetImage(this.frd_CustomImage);
				}
				if (image == null)
				{
					image = a.oo.O00O.().ToBitmap();
				}
				return image;
			}
			set
			{
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x001028DC File Offset: 0x00100ADC
		// (set) Token: 0x060023F5 RID: 9205 RVA: 0x00102953 File Offset: 0x00100B53
		internal bool frd_IsOuterQuery
		{
			get
			{
				return !this.oOo.oO. && ((this._Adapter != null && this._Adapter.UpdateCommand == null && this._Adapter.SelectCommand.Connection != O_O0OO.OoO.0OO__0ooo.()) || (Operators.CompareString(this.DataServer, "", true) > 0 && Operators.CompareString(this.UpdateServer, "", true) == 0));
			}
			set
			{
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x00102958 File Offset: 0x00100B58
		// (set) Token: 0x060023F7 RID: 9207 RVA: 0x001029D0 File Offset: 0x00100BD0
		internal bool frd_IsOuterTable
		{
			get
			{
				return !this.oOo.oO. && ((this._Adapter != null && this._Adapter.UpdateCommand != null && this._Adapter.SelectCommand.Connection != O_O0OO.OoO.0OO__0ooo.()) || (Operators.CompareString(this.DataServer, "", true) > 0 && Operators.CompareString(this.UpdateServer, "", true) > 0));
			}
			set
			{
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x001029D4 File Offset: 0x00100BD4
		// (set) Token: 0x060023F9 RID: 9209 RVA: 0x00102A20 File Offset: 0x00100C20
		internal bool frd_IsInnerQuery
		{
			get
			{
				return !this.oOo.oO. && (this._Adapter != null && this._Adapter.UpdateCommand == null && this._Adapter.SelectCommand.Connection == O_O0OO.OoO.0OO__0ooo.());
			}
			set
			{
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060023FA RID: 9210 RVA: 0x00102A24 File Offset: 0x00100C24
		// (set) Token: 0x060023FB RID: 9211 RVA: 0x00102A70 File Offset: 0x00100C70
		internal bool frd_IsInnerTable
		{
			get
			{
				return this.oOo.oO. || (this._Adapter != null && this._Adapter.UpdateCommand != null && this._Adapter.SelectCommand.Connection == O_O0OO.OoO.0OO__0ooo.());
			}
			set
			{
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x00102A72 File Offset: 0x00100C72
		// (set) Token: 0x060023FD RID: 9213 RVA: 0x00102A92 File Offset: 0x00100C92
		internal bool frd_IsTemporary
		{
			get
			{
				return Operators.CompareString(this.DataServer, "", true) == 0 && this._Adapter == null;
			}
			set
			{
			}
		}

		/// <summary>
		/// 是否允许通过鼠标拖动列
		/// </summary>
		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x00102A94 File Offset: 0x00100C94
		// (set) Token: 0x060023FF RID: 9215 RVA: 0x00102A9C File Offset: 0x00100C9C
		[oO0oooo("0372")]
		public bool AllowDragColumn
		{
			get
			{
				return this.o_0._Ooo____OO.;
			}
			set
			{
				this.o_0._Ooo____OO. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.o_.Oooo000O.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		/// <summary>
		/// 是否允许冻结列
		/// </summary>
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x00102B08 File Offset: 0x00100D08
		// (set) Token: 0x06002401 RID: 9217 RVA: 0x00102B10 File Offset: 0x00100D10
		[oO0oooo("0373")]
		public bool AllowFreezeColumn
		{
			get
			{
				return this.o0O.O0o_OOOoo.;
			}
			set
			{
				this.o0O.O0o_OOOoo. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.o_o_o_0.O_OOo_.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				this.o.OO_00.();
			}
		}

		/// <summary>
		/// 是否允许调整列宽
		/// </summary>
		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x00102B84 File Offset: 0x00100D84
		// (set) Token: 0x06002403 RID: 9219 RVA: 0x00102B8C File Offset: 0x00100D8C
		[oO0oooo("0374")]
		public bool AllowResizeColumn
		{
			get
			{
				return this.oO0oO._0_.;
			}
			set
			{
				this.oO0oO._0_. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.OO_._o_0o_.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				this.o.OO_00.();
			}
		}

		/// <summary>
		/// 是否允许调整行高
		/// </summary>
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x00102C00 File Offset: 0x00100E00
		// (set) Token: 0x06002405 RID: 9221 RVA: 0x00102C08 File Offset: 0x00100E08
		[oO0oooo("0375")]
		public bool AllowResizeRow
		{
			get
			{
				return this.o.___.;
			}
			set
			{
				this.o.___. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.o.0o_oO0.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				this.o.OO_00.();
			}
		}

		/// <summary>
		/// 是否允许自动增加行
		/// </summary>
		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06002406 RID: 9222 RVA: 0x00102C7C File Offset: 0x00100E7C
		// (set) Token: 0x06002407 RID: 9223 RVA: 0x00102CA8 File Offset: 0x00100EA8
		[oO0oooo("0379")]
		public bool AutoAddNew
		{
			get
			{
				return !this.frd_IsOuterQuery && !this.frd_IsInnerQuery && this.o0O._ooo_o___.;
			}
			set
			{
				this.o0O._ooo_o___. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.O0o000_oo.00_.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x00102D14 File Offset: 0x00100F14
		// (set) Token: 0x06002409 RID: 9225 RVA: 0x00102D1C File Offset: 0x00100F1C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool SystemVisualStyle
		{
			get
			{
				return this.o._000.;
			}
			set
			{
				this.o._000. = value;
			}
		}

		/// <summary>
		/// 是否允许增加行
		/// </summary>
		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x00102D28 File Offset: 0x00100F28
		// (set) Token: 0x0600240B RID: 9227 RVA: 0x00102D54 File Offset: 0x00100F54
		[oO0oooo("0377")]
		public bool AllowAddNew
		{
			get
			{
				return !this.frd_IsOuterQuery && !this.frd_IsInnerQuery && this.oo0__.00_.;
			}
			set
			{
				this.oo0__.00_. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.O.oOO_OO0oo00.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		/// <summary>
		/// 是否允许编辑数据
		/// </summary>
		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x00102DC0 File Offset: 0x00100FC0
		// (set) Token: 0x0600240D RID: 9229 RVA: 0x00102DE8 File Offset: 0x00100FE8
		[oO0oooo("0378")]
		public bool AllowEdit
		{
			get
			{
				return OO_00oOO.DataTables.AllowEdit && this.Ooo._O_0Oo___.;
			}
			set
			{
				this.Ooo._O_0Oo___. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.OO_0_oo0_.oO__.();
								table.foxGrid.Rows[0].Invalidate();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				Main.OO_O.o..O.ooO0. = true;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x00102E78 File Offset: 0x00101078
		// (set) Token: 0x0600240F RID: 9231 RVA: 0x00102E80 File Offset: 0x00101080
		[EditorBrowsable(EditorBrowsableState.Never)]
		public BooleanEnum PreserveEditMode2
		{
			get
			{
				return this.o_oO0O_.O0.;
			}
			set
			{
				this.o_oO0O_.O0. = value;
			}
		}

		/// <summary>
		/// 是否保持编辑模式
		/// </summary>
		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x00102E8C File Offset: 0x0010108C
		// (set) Token: 0x06002411 RID: 9233 RVA: 0x00102EB9 File Offset: 0x001010B9
		[oO0oooo("3278")]
		public bool PreserveEditMode
		{
			get
			{
				bool result;
				if (this.o_oO0O_.O0. == BooleanEnum.Default)
				{
					result = OO_00oOO.DataTables.PreserveEditMode;
				}
				else
				{
					result = (this.o_oO0O_.O0. == BooleanEnum.True);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.o_oO0O_.O0. = BooleanEnum.True;
				}
				else
				{
					this.o_oO0O_.O0. = BooleanEnum.False;
				}
				this.o0.0o_0.();
			}
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00102ED8 File Offset: 0x001010D8
		internal bool <<EMPTY_NAME>>()
		{
			bool a_ = this.PreserveEditMode;
			if (OO_00oOO.Tables != null)
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.View.o_o.O0ooOo.() == this._DataTable)
						{
							table.oOoo_oOO0.O0.(a_);
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			bool result;
			return result;
		}

		/// <summary>
		/// 是否允许删除行
		/// </summary>
		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x00102F48 File Offset: 0x00101148
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x00102F74 File Offset: 0x00101174
		[oO0oooo("0380")]
		public bool AllowDelete
		{
			get
			{
				return !this.frd_IsOuterQuery && !this.frd_IsInnerQuery && this.O_oo0o_O0._0o.;
			}
			set
			{
				this.O_oo0o_O0._0o. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.o00O.0O.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		/// <summary>
		/// 删除行之前是否需要用户确认
		/// </summary>
		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x00102FE0 File Offset: 0x001011E0
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x00102FE8 File Offset: 0x001011E8
		[oO0oooo("0110")]
		public bool DeleteRowPrompt
		{
			get
			{
				return this.o.o_O00O_O_0.;
			}
			set
			{
				this.o.o_O00O_O_0. = value;
			}
		}

		/// <summary>
		/// 是否允许锁定行
		/// </summary>
		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x00102FF1 File Offset: 0x001011F1
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x00102FFC File Offset: 0x001011FC
		[oO0oooo("0381")]
		public bool AllowLockRow
		{
			get
			{
				return this.Oo0o00o.Oo0_O.;
			}
			set
			{
				this.Oo0o00o.Oo0_O. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.oO0oOo0_o00._O.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		/// <summary>
		/// 表样式名称
		/// </summary>
		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x00103068 File Offset: 0x00101268
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x001030A0 File Offset: 0x001012A0
		[oO0oooo("3305")]
		public string Theme
		{
			get
			{
				string result;
				if (Operators.CompareString(this.O0__.00., "(default)", true) == 0)
				{
					result = O_O0OO.O0_00o.o0__o..GridThemeName;
				}
				else
				{
					result = this.O0__.00.;
				}
				return result;
			}
			set
			{
				this.O0__.00. = value;
				if (this.BaseTable.DataSet == O_O0OO.OOOo.oo_OOOO_0.() && !O_O0OO.o0OoO00OO.00O.)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.DataTable == this)
							{
								Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
								{
									table.Grid
								});
								Main.OO_O.o..Oo.oOo_o0Oo0.(table.Theme, new object[]
								{
									table.Grid
								});
								table.foxGrid.Oo0._0.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00103154 File Offset: 0x00101354
		internal void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.O0__.00., "(default)", true) == 0)
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this && Operators.CompareString(table.ooo00.o0__OO0., "(default)", true) == 0)
						{
							table.Theme = table.ooo00.o0__OO0.;
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 是否允许解锁行
		/// </summary>
		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x001031D4 File Offset: 0x001013D4
		// (set) Token: 0x0600241D RID: 9245 RVA: 0x001031DC File Offset: 0x001013DC
		[oO0oooo("0382")]
		public bool AllowUnlockRow
		{
			get
			{
				return this.O_O._.;
			}
			set
			{
				this.O_O._. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.O0Oo000o0_O.o0.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		/// <summary>
		/// 是否允许分别调整每一行的高度
		/// </summary>
		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x00103248 File Offset: 0x00101448
		// (set) Token: 0x0600241F RID: 9247 RVA: 0x00103250 File Offset: 0x00101450
		[oO0oooo("0376")]
		public bool AllowResizeSingleRow
		{
			get
			{
				return this.O0.oOO0_.;
			}
			set
			{
				this.O0.oOO0_. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.OOo_.__Oo00o.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		/// <summary>
		/// 是否允许复制粘贴数据
		/// </summary>
		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06002420 RID: 9248 RVA: 0x001032BC File Offset: 0x001014BC
		// (set) Token: 0x06002421 RID: 9249 RVA: 0x001032C4 File Offset: 0x001014C4
		[oO0oooo("1515")]
		public bool AllowClipBoard
		{
			get
			{
				return this.OOooo.0o_0O_O_.;
			}
			set
			{
				this.OOooo.0o_0O_O_. = value;
			}
		}

		/// <summary>
		/// 复制数据时是否包括列标题
		/// </summary>
		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06002422 RID: 9250 RVA: 0x001032CD File Offset: 0x001014CD
		// (set) Token: 0x06002423 RID: 9251 RVA: 0x001032D5 File Offset: 0x001014D5
		[oO0oooo("2630")]
		public bool AllowCopyHeader
		{
			get
			{
				return this.o_.O_0_0_ooOo.;
			}
			set
			{
				this.o_.O_0_0_ooOo. = value;
			}
		}

		/// <summary>
		/// 是否允许初始化此表
		/// </summary>
		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x001032DE File Offset: 0x001014DE
		// (set) Token: 0x06002425 RID: 9253 RVA: 0x001032E6 File Offset: 0x001014E6
		[oO0oooo("1527")]
		public bool AllowInitialize
		{
			get
			{
				return this.Ooo00.oo.;
			}
			set
			{
				this.Ooo00.oo. = value;
			}
		}

		/// <summary>
		/// 是否允许重定向此表
		/// </summary>
		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06002426 RID: 9254 RVA: 0x001032EF File Offset: 0x001014EF
		// (set) Token: 0x06002427 RID: 9255 RVA: 0x001032F7 File Offset: 0x001014F7
		[oO0oooo("2297")]
		public bool AllowRedirect
		{
			get
			{
				return this.oO.0o0O0oO.;
			}
			set
			{
				this.oO.0o0O0oO. = value;
			}
		}

		/// <summary>
		/// 表标题
		/// </summary>
		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x00103300 File Offset: 0x00101500
		// (set) Token: 0x06002429 RID: 9257 RVA: 0x00103308 File Offset: 0x00101508
		[oO0oooo("0371")]
		public string Caption
		{
			get
			{
				return this.o0O._ooo_o___.;
			}
			internal set
			{
				this.o0O._ooo_o___. = value;
			}
		}

		/// <summary>
		/// 按Tab键是否向下移动焦点单元格
		/// </summary>
		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600242A RID: 9258 RVA: 0x00103311 File Offset: 0x00101511
		// (set) Token: 0x0600242B RID: 9259 RVA: 0x0010331C File Offset: 0x0010151C
		[oO0oooo("0386")]
		public bool TabKeyActionDown
		{
			get
			{
				return this.O0___.O.;
			}
			set
			{
				this.O0___.O. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.oo_.o_0o.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				this.o.OO_00.();
			}
		}

		/// <summary>
		/// 按回车键是否向下移动焦点单元格
		/// </summary>
		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600242C RID: 9260 RVA: 0x00103390 File Offset: 0x00101590
		// (set) Token: 0x0600242D RID: 9261 RVA: 0x00103398 File Offset: 0x00101598
		[oO0oooo("0385")]
		public bool EnterKeyActionDown
		{
			get
			{
				return this.Oo0Oo_.O000.;
			}
			set
			{
				this.Oo0Oo_.O000. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this._DataTable)
							{
								table.o_0.__0_.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				this.o.OO_00.();
			}
		}

		/// <summary>
		/// 列集合
		/// </summary>
		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x0010340C File Offset: 0x0010160C
		[oO0oooo("1428")]
		public DataColCollection DataCols
		{
			get
			{
				return this.o.O0O_0__OOo_.;
			}
		}

		/// <summary>
		/// 表名
		/// </summary>
		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x00103414 File Offset: 0x00101614
		[oO0oooo("0370")]
		public string Name
		{
			get
			{
				return this._DataTable.TableName;
			}
		}

		/// <summary>
		/// 行集合
		/// </summary>
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x00103421 File Offset: 0x00101621
		[oO0oooo("0419")]
		public DataRowCollection DataRows
		{
			get
			{
				if (this.o_oO0O_.O0. == null)
				{
					this.o_oO0O_.O0. = new DataRowCollection(this._DataTable);
				}
				return this.o_oO0O_.O0.;
			}
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00103444 File Offset: 0x00101644
		[oO0oooo("1579")]
		public void AddUserStyle(string Name, Color? BackColor = null, Color? Forecolor = null)
		{
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable == this && !table.foxGrid.Styles.Contains("User" + Name))
					{
						CellStyle cellStyle = table.foxGrid.Styles.Add("User" + Name);
						if (BackColor != null)
						{
							cellStyle.BackColor = BackColor.Value;
						}
						if (Forecolor != null)
						{
							cellStyle.ForeColor = Forecolor.Value;
						}
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		/// <summary>
		/// 样式集合
		/// </summary>
		/// <param name="StyleName"></param>
		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06002432 RID: 9266 RVA: 0x001034F8 File Offset: 0x001016F8
		[oO0oooo("0656")]
		public CellStyle Styles
		{
			get
			{
				return new CellStyle(this, "User" + A_0);
			}
		}

		/// <summary>
		/// 系统样式集合
		/// </summary>
		/// <param name="StyleName"></param>
		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x0010350B File Offset: 0x0010170B
		[oO0oooo("1577")]
		public CellStyle SysStyles
		{
			get
			{
				return new CellStyle(this, A_0);
			}
		}

		/// <summary>
		/// 数据是否已经被修改过
		/// </summary>
		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x00103514 File Offset: 0x00101714
		[oO0oooo("0387")]
		public bool HasChanges
		{
			get
			{
				object obj = this._DataTable;
				bool result;
				lock (obj)
				{
					result = (this._DataTable.Select("", "", DataViewRowState.Unchanged).Length != this._DataTable.Rows.Count);
				}
				return result;
			}
		}

		/// <summary>
		/// 表类型
		/// </summary>
		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x00103580 File Offset: 0x00101780
		[oO0oooo("0389")]
		public int Type
		{
			get
			{
				int result;
				if (this.frd_IsInnerTable)
				{
					result = 1;
				}
				else if (this.frd_IsInnerQuery)
				{
					result = 2;
				}
				else if (this.frd_IsOuterTable)
				{
					result = 3;
				}
				else if (this.frd_IsOuterQuery)
				{
					result = 4;
				}
				else if (this.frd_IsTemporary)
				{
					result = 5;
				}
				return result;
			}
		}

		/// <summary>
		/// 判断此表是否是通过代码动态增加的表
		/// </summary>
		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x001035C8 File Offset: 0x001017C8
		// (set) Token: 0x06002437 RID: 9271 RVA: 0x001035D0 File Offset: 0x001017D0
		public bool AddByCode
		{
			get
			{
				return this.Oo.OO0ooOOo_.;
			}
			internal set
			{
				this.Oo.OO0ooOOo_. = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (set) Token: 0x06002438 RID: 9272 RVA: 0x001035D9 File Offset: 0x001017D9
		internal string LoadFilter3
		{
			set
			{
				this.o_O_0.0_O. = value;
				this.ooO.oO0O0_oo. = true;
			}
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x001035E9 File Offset: 0x001017E9
		internal void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (Operators.CompareString(this.LoadFilter, this.OOOOO._., true) == 0)
			{
				this.o00o.00oO___0..Clear();
			}
			this.o_O_0.0_O. = A_0;
			this.ooO.oO0O0_oo. = true;
			this.o00o.00oO___0..Add(A_1);
		}

		/// <summary>
		/// 加载条件
		/// </summary>
		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x00103624 File Offset: 0x00101824
		// (set) Token: 0x0600243B RID: 9275 RVA: 0x0010362C File Offset: 0x0010182C
		[oO0oooo("1928")]
		public string LoadFilter
		{
			get
			{
				return this.o_O_0.0_O.;
			}
			set
			{
				this.o_O_0.0_O. = value;
				this.ooO.oO0O0_oo. = true;
				this.OOOOO._. = value;
			}
		}

		/// <summary>
		/// 加载行数
		/// </summary>
		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x00103643 File Offset: 0x00101843
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x0010364B File Offset: 0x0010184B
		[oO0oooo("1928")]
		public string LoadTop
		{
			get
			{
				return this.Ooo00._0_oO_.;
			}
			set
			{
				this.Ooo00._0_oO_. = value;
				this.ooO.oO0O0_oo. = true;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x0010365C File Offset: 0x0010185C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string LoadTop2
		{
			get
			{
				string result;
				if (Operators.CompareString(this.Ooo00._0_oO_., "", true) == 0 && Operators.CompareString(this.OOoO._o., "", true) > 0)
				{
					result = "100 PERCENT";
				}
				else
				{
					result = this.Ooo00._0_oO_.;
				}
				return result;
			}
		}

		/// <summary>
		/// 是否反向加载
		/// </summary>
		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x001036A0 File Offset: 0x001018A0
		// (set) Token: 0x06002440 RID: 9280 RVA: 0x001036A8 File Offset: 0x001018A8
		[oO0oooo("1928")]
		public bool LoadReverse
		{
			get
			{
				return this.O_0o0._O0.;
			}
			set
			{
				this.O_0o0._O0. = value;
				this.ooO.oO0O0_oo. = true;
			}
		}

		/// <summary>
		/// 加载顺序
		/// </summary>
		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x001036B8 File Offset: 0x001018B8
		// (set) Token: 0x06002442 RID: 9282 RVA: 0x001036C0 File Offset: 0x001018C0
		[oO0oooo("1928")]
		public string LoadOrder
		{
			get
			{
				return this.OOoO._o.;
			}
			set
			{
				this.OOoO._o. = value;
				this.ooO.oO0O0_oo. = true;
			}
		}

		/// <summary>
		/// 分页加载依据列
		/// </summary>
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x001036D0 File Offset: 0x001018D0
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x001036D8 File Offset: 0x001018D8
		[oO0oooo("1928")]
		public string LoadOver
		{
			get
			{
				return this.o_OOo0.o.;
			}
			set
			{
				this.o_OOo0.o. = value;
				this.ooO.oO0O0_oo. = true;
			}
		}

		/// <summary>
		/// 指定要加载第几页
		/// </summary>
		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x001036E8 File Offset: 0x001018E8
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x001036F0 File Offset: 0x001018F0
		[oO0oooo("1928")]
		public int LoadPage
		{
			get
			{
				return this.O_.oO_O_.;
			}
			set
			{
				this.O_.oO_O_. = value;
				this.ooO.oO0O0_oo. = true;
			}
		}

		/// <summary>
		/// 符合当前加载条件的总页数
		/// </summary>
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x00103700 File Offset: 0x00101900
		[oO0oooo("1928")]
		public double TotalPages
		{
			get
			{
				int num = this.TotalRows;
				double result;
				if (num >= 0)
				{
					result = Math.Ceiling((double)num / (double)Conversions.ToInteger(this.LoadTop));
				}
				else
				{
					result = -1.0;
				}
				return result;
			}
		}

		/// <summary>
		/// 符合当前加载条件的总行数
		/// </summary>
		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x0010373C File Offset: 0x0010193C
		[oO0oooo("1928")]
		public int TotalRows
		{
			get
			{
				bool flag;
				if (Operators.CompareString(this.DataServer, "", true) > 0)
				{
					flag = (this.DataServerType == DataServerTypeEnum.Oracle);
				}
				else
				{
					flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection);
				}
				int result;
				if (this._Adapter == null && Operators.CompareString(this.DataServer, "", true) == 0)
				{
					result = -1;
				}
				else
				{
					if (Operators.CompareString(this.LoadTop, "", true) > 0 && Versioned.IsNumeric(this.LoadTop) && (this.BaseTable.PrimaryKey.Length == 1 || Operators.CompareString(this.LoadOver, "", true) > 0 || this.BaseTable.Columns.Contains("_SortKey") || this.BaseTable.Columns.Contains("_Identify")))
					{
						string text = "";
						if (Operators.CompareString(this.LoadOver, "", true) > 0)
						{
							text = this.LoadOver;
						}
						else if (this.BaseTable.Columns.Contains("_SortKey"))
						{
							text = "_SortKey";
						}
						else if (this.BaseTable.Columns.Contains("_Identify"))
						{
							text = "_Identify";
						}
						else if (this.BaseTable.PrimaryKey.Length == 1)
						{
							text = this.BaseTable.PrimaryKey[0].ColumnName;
						}
						if (Operators.CompareString(text, "", true) > 0)
						{
							if (flag)
							{
								text = "\"" + text + "\"";
							}
							else if (!text.EndsWith("]"))
							{
								text = "[" + text + "]";
							}
						}
						string str;
						if (Operators.CompareString(this.o._OOO0oOo0__., "", true) > 0)
						{
							if (flag)
							{
								str = this.o._OOO0oOo0__.;
							}
							else
							{
								str = "[" + this.o._OOO0oOo0__..Trim(new char[]
								{
									'[',
									']'
								}) + "]";
							}
						}
						else if (Operators.CompareString(this.DataServer, "", true) > 0)
						{
							str = Oo00.O0__oo.__0o.(this.HttpSelect);
						}
						else
						{
							str = Oo00.O0__oo.__0o.(this.frd_SelectCommandString);
						}
						if (Operators.CompareString(text, "", true) > 0 && text.IndexOf(".") < 0)
						{
							text = str + "." + text;
						}
						string text2;
						if (Operators.CompareString(this.DataServer, "", true) > 0)
						{
							text2 = "Select Count(" + text + ") From " + Oo00.o_0o0O.0_O.(this.HttpSelect);
						}
						else
						{
							text2 = "Select Count(" + text + ") From " + Oo00.o_0o0O.0_O.(this._Adapter.SelectCommand.CommandText);
						}
						if (Operators.CompareString(this.LoadFilter, "", true) > 0)
						{
							if (Operators.CompareString(this.DataServer, "", true) == 0)
							{
								text2 = text2 + " Where " + Oo00.o0_o._O_.(this.o0__.Oo0o__O., this.LoadFilter, false);
							}
							else
							{
								text2 = text2 + " Where " + Oo00.o0_o._O_.(this.DataServerType, this.LoadFilter, false);
							}
						}
						object obj;
						if (Operators.CompareString(this.DataServer, "", true) > 0)
						{
							HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
							httpClient.FormData.Add("Action", 6.ToString());
							httpClient.Select = text2;
							obj = httpClient.GetData();
						}
						else
						{
							OleDbCommand oleDbCommand = new OleDbCommand(text2, this.frd_Connection);
							oleDbCommand.Transaction = this._Adapter.SelectCommand.Transaction;
							ConnectionState state = this.frd_Connection.State;
							if (state != ConnectionState.Open)
							{
								this.frd_Connection.Open();
							}
							obj = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
							if (state != ConnectionState.Open)
							{
								this.frd_Connection.Close();
							}
						}
						if (obj != null)
						{
							return Conversions.ToInteger(obj);
						}
					}
					result = -1;
				}
				return result;
			}
		}

		/// <summary>
		/// 直接使用Select语句加载数据
		/// </summary>
		/// <param name="SelectString">Select语句</param>
		/// <param name="SaveData">是否先保存数据</param>
		// Token: 0x06002449 RID: 9289 RVA: 0x00103B0C File Offset: 0x00101D0C
		[oO0oooo("2721")]
		public void SQLLoad(string SelectString, bool SaveData = true)
		{
			if (this._Adapter != null || Operators.CompareString(this.DataServer, "", true) > 0)
			{
				LoadEventArgs loadEventArgs = new LoadEventArgs(this);
				string a_ = "BeforeLoad";
				O_O0OO.OoO_o.oO0o0O.(this.o_0_00_.oo0O0., a_, new object[]
				{
					loadEventArgs
				}, false, this.BaseTable.TableName, false);
				if (!loadEventArgs.Cancel && OO_00oOO.DataTables[this.BaseTable.TableName].GlobalHandler.BeforeLoad)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						loadEventArgs
					}, false, "全局表事件", false);
				}
				if (loadEventArgs.Cancel)
				{
					return;
				}
				if (SaveData && (this.frd_IsInnerTable || this.frd_IsOuterTable))
				{
					if (Operators.CompareString(this.DataServer, "", true) > 0)
					{
						if (Operators.CompareString(this.UpdateServer, "", true) > 0)
						{
							if (!this.o.o_O.())
							{
								return;
							}
							if (!this.O0o0.O_0_.())
							{
								return;
							}
						}
					}
					else if (!this.oO.o_0.(false, true))
					{
						return;
					}
				}
			}
			if (this._Adapter != null)
			{
				this._Adapter.SelectCommand.CommandText = Oo00.o0_o._O_.(this.frd_Connection, SelectString, false);
				this.O._0O_O0O.(this._Adapter, null);
				return;
			}
			if (Operators.CompareString(this.DataServer, "", true) > 0)
			{
				SelectString = Oo00.o0_o._O_.(O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].OO.OoO0., SelectString, false);
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
				httpClient.FormData["Action"] = 2.ToString();
				httpClient.Select = SelectString;
				this.O._O0__. = SelectString;
				httpClient.FormData.Add("IgnoreSchema", "True");
				this.O._0O_O0O.(null, httpClient);
			}
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x00103CD5 File Offset: 0x00101ED5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void LoadAsync(bool SaveData = true)
		{
			if (SaveData)
			{
				new Thread(new ThreadStart(this.oOo0.OO0.)).Start();
				return;
			}
			new Thread(new ThreadStart(this.o0.o.)).Start();
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x00103D07 File Offset: 0x00101F07
		private void <<EMPTY_NAME>>()
		{
			this.o0.o.(true, this.Apapter2);
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x00103D16 File Offset: 0x00101F16
		private void <<EMPTY_NAME>>()
		{
			this.o0.o.(false, this.Apapter2);
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00103D25 File Offset: 0x00101F25
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AppendLoadAsync(string Filter, bool SaveBefore = true)
		{
			this.OOOo.O0_. = Filter;
			this.O0Oo0oo_._o_0O. = SaveBefore;
			new Thread(new ThreadStart(this.o0O.O_0.)).Start();
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00103D4B File Offset: 0x00101F4B
		private void <<EMPTY_NAME>>()
		{
			this.o0O.O_0.(this.OOOo.O0_., this.O0Oo0oo_._o_0O., this.Apapter2);
		}

		/// <summary>
		/// 加载数据
		/// </summary>
		/// <param name="SaveData">是否保存现有数据</param>
		// Token: 0x0600244F RID: 9295 RVA: 0x00103D66 File Offset: 0x00101F66
		[oO0oooo("1928")]
		public void Load(bool SaveData = true)
		{
			this.o0.o.(SaveData, null);
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00103D70 File Offset: 0x00101F70
		internal void <<EMPTY_NAME>>(bool A_0 = true, OleDbDataAdapter A_1 = null)
		{
			object oo_O.o. = Main.OO_O.o.;
			lock (oo_O.o.)
			{
				while (O_O0OO.O_O00OOooo.O_. | this.o00o.00oO___0.)
				{
					Thread.Sleep(1);
				}
				O_O0OO.O_O00OOooo.O_. = true;
				this.o00o.00oO___0. = true;
			}
			try
			{
				if (A_1 == null)
				{
					A_1 = this._Adapter;
				}
				this.o.o00O.(A_0, A_1);
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				O_O0OO.O_O00OOooo.O_. = false;
				this.o00o.00oO___0. = false;
			}
			if (OO_00oOO.Tables != null)
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this)
						{
							table.ResetCurrentItem();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x00103E70 File Offset: 0x00102070
		private void <<EMPTY_NAME>>(bool A_0, OleDbDataAdapter A_1)
		{
			int num;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this._Adapter == null && Operators.CompareString(this.DataServer, "", true) == 0)
				{
					goto IL_DAE;
				}
				IL_27:
				num2 = 4;
				if (Operators.CompareString(this.DataServer, "", true) <= 0)
				{
					goto IL_4B;
				}
				IL_3D:
				num2 = 5;
				bool flag = this.DataServerType == DataServerTypeEnum.Oracle;
				goto IL_59;
				IL_4B:
				num2 = 7;
				flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection);
				IL_59:
				num2 = 8;
				if (!A_0 || (!this.frd_IsInnerTable && !this.frd_IsOuterTable))
				{
					goto IL_CA;
				}
				IL_6E:
				num2 = 9;
				if (Operators.CompareString(this.DataServer, "", true) <= 0)
				{
					goto IL_BA;
				}
				IL_85:
				num2 = 10;
				if (Operators.CompareString(this.UpdateServer, "", true) <= 0)
				{
					goto IL_CA;
				}
				IL_9C:
				num2 = 11;
				if (!this.o.o_O.())
				{
					goto IL_DAE;
				}
				IL_AA:
				num2 = 13;
				if (!this.O0o0.O_0_.())
				{
					goto IL_DAE;
				}
				goto IL_CA;
				IL_BA:
				num2 = 16;
				if (!this.oO.o_0.(false, true))
				{
					goto IL_DAE;
				}
				IL_CA:
				num2 = 18;
				LoadEventArgs loadEventArgs = new LoadEventArgs(this);
				IL_D5:
				num2 = 19;
				string a_ = "BeforeLoad";
				IL_DF:
				num2 = 20;
				O_O0OO.OoO_o.oO0o0O.(this.o_0_00_.oo0O0., a_, new object[]
				{
					loadEventArgs
				}, false, this.BaseTable.TableName, false);
				IL_108:
				num2 = 21;
				if (this._DataTable.DataSet != O_O0OO.OOOo.oo_OOOO_0.() || loadEventArgs.Cancel)
				{
					goto IL_16C;
				}
				IL_126:
				num2 = 22;
				if (!OO_00oOO.DataTables[this.BaseTable.TableName].GlobalHandler.BeforeLoad)
				{
					goto IL_16C;
				}
				IL_14A:
				num2 = 23;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					loadEventArgs
				}, false, "全局表事件", false);
				IL_16C:
				num2 = 24;
				if (loadEventArgs.Cancel)
				{
					goto IL_DAE;
				}
				IL_17B:
				num2 = 26;
				if (this.ooO.oO0O0_oo. || Operators.CompareString(this.DataServer, "", true) != 0)
				{
					goto IL_1A9;
				}
				IL_199:
				num2 = 27;
				this.O._0O_O0O.(A_1, null);
				goto IL_DAE;
				IL_1A9:
				num2 = 29;
				if (Operators.CompareString(this.DataServer, "", true) <= 0)
				{
					goto IL_1CD;
				}
				IL_1C0:
				num2 = 30;
				string text = this.HttpSelect;
				goto IL_1E2;
				IL_1CD:
				num2 = 32;
				text = this._Adapter.SelectCommand.CommandText;
				IL_1E2:
				num2 = 33;
				text = text.Trim();
				IL_1EE:
				num2 = 34;
				string text2 = Oo00.o_0o0O.0_O.(text);
				IL_1FA:
				num2 = 35;
				string[] array = Regex.Split(text, "[\\s]+");
				IL_20B:
				num2 = 36;
				string text3 = "";
				IL_215:
				num2 = 37;
				string text4 = "";
				IL_21F:
				num2 = 38;
				if (Operators.CompareString(array[1], "Distinct", true) != 0)
				{
					goto IL_23F;
				}
				IL_233:
				num2 = 39;
				text3 = "Select Distinct";
				goto IL_249;
				IL_23F:
				num2 = 41;
				text3 = "Select";
				IL_249:
				num2 = 42;
				if (Operators.CompareString(array[1], "top", true) != 0)
				{
					goto IL_281;
				}
				IL_25D:
				num2 = 43;
				if (Operators.CompareString(array[3], "PERCENT", true) != 0)
				{
					goto IL_279;
				}
				IL_271:
				num2 = 44;
				int num3 = 4;
				goto IL_2DB;
				IL_279:
				num2 = 46;
				num3 = 3;
				goto IL_2DB;
				IL_281:
				num2 = 48;
				if (Operators.CompareString(array[2], "top", true) != 0)
				{
					goto IL_2B9;
				}
				IL_295:
				num2 = 49;
				if (Operators.CompareString(array[4], "PERCENT", true) != 0)
				{
					goto IL_2B1;
				}
				IL_2A9:
				num2 = 50;
				num3 = 5;
				goto IL_2DB;
				IL_2B1:
				num2 = 52;
				num3 = 4;
				goto IL_2DB;
				IL_2B9:
				num2 = 54;
				if (Operators.CompareString(array[1], "Distinct", true) != 0)
				{
					goto IL_2D5;
				}
				IL_2CD:
				num2 = 55;
				num3 = 2;
				goto IL_2DB;
				IL_2D5:
				num2 = 57;
				num3 = 1;
				IL_2DB:
				num2 = 58;
				string text5 = array[num3];
				IL_2E5:
				num2 = 59;
				foreach (char value in "\\$()*+.[]?^{}|")
				{
					IL_2FF:
					num2 = 60;
					text5 = text5.Replace(Conversions.ToString(value), "\\" + Conversions.ToString(value));
					IL_323:
					num2 = 61;
				}
				IL_337:
				num2 = 62;
				Regex regex = new Regex("[\\s]+" + text5 + "[\\s]+", RegexOptions.IgnoreCase);
				IL_353:
				num2 = 63;
				Match match = regex.Match(text);
				IL_361:
				num2 = 64;
				if (!match.Success)
				{
					goto IL_3EB;
				}
				IL_36D:
				num2 = 65;
				int startIndex = match.Index + 1;
				IL_37B:
				num2 = 66;
				if (Operators.CompareString(this.LoadTop2, "", true) <= 0 || flag)
				{
					goto IL_3D1;
				}
				IL_395:
				num2 = 67;
				text = string.Concat(new string[]
				{
					text3,
					" Top ",
					this.LoadTop2,
					" ",
					text.Substring(startIndex)
				});
				goto IL_3EB;
				IL_3D1:
				num2 = 69;
				text = text3 + " " + text.Substring(startIndex);
				IL_3EB:
				num2 = 70;
				int num4 = Oo00.OoO_.__o.(text);
				IL_3F7:
				num2 = 71;
				regex = new Regex("[\\s]+join[\\s]+", RegexOptions.IgnoreCase);
				IL_407:
				num2 = 72;
				match = regex.Match(text, num4);
				IL_417:
				num2 = 73;
				if (!match.Success)
				{
					goto IL_469;
				}
				IL_423:
				num2 = 74;
				regex = new Regex("[\\s]+on[\\s]+", RegexOptions.IgnoreCase);
				IL_433:
				num2 = 75;
				match = regex.Match(text, match.Index + 1);
				IL_44A:
				num2 = 76;
				if (!match.Success)
				{
					goto IL_469;
				}
				IL_456:
				num2 = 77;
				num4 = Math.Max(match.Index, num4);
				IL_469:
				num2 = 78;
				regex = new Regex("[\\s]+where[\\s]+", RegexOptions.IgnoreCase);
				IL_479:
				num2 = 79;
				match = regex.Match(text, num4);
				IL_489:
				num2 = 80;
				if (!match.Success)
				{
					goto IL_4A9;
				}
				IL_495:
				num2 = 81;
				text = text.Substring(0, match.Index);
				IL_4A9:
				num2 = 82;
				regex = new Regex("[\\s]+group[\\s]+by[\\s]+", RegexOptions.IgnoreCase);
				IL_4B9:
				num2 = 83;
				match = regex.Match(text, num4);
				IL_4C9:
				num2 = 84;
				if (!match.Success)
				{
					goto IL_4E9;
				}
				IL_4D5:
				num2 = 85;
				text = text.Substring(0, match.Index);
				IL_4E9:
				num2 = 86;
				regex = new Regex("[\\s]+order[\\s]+by[\\s]+", RegexOptions.IgnoreCase);
				IL_4F9:
				num2 = 87;
				match = regex.Match(text, num4);
				IL_509:
				num2 = 88;
				if (!match.Success)
				{
					goto IL_529;
				}
				IL_515:
				num2 = 89;
				text = text.Substring(0, match.Index);
				IL_529:
				num2 = 90;
				if (Operators.CompareString(this.LoadOver, "", true) <= 0)
				{
					goto IL_54D;
				}
				IL_540:
				num2 = 91;
				text4 = this.LoadOver;
				goto IL_5C3;
				IL_54D:
				num2 = 93;
				if (!this.BaseTable.Columns.Contains("_SortKey"))
				{
					goto IL_573;
				}
				IL_567:
				num2 = 94;
				text4 = "_SortKey";
				goto IL_5C3;
				IL_573:
				num2 = 96;
				if (!this.BaseTable.Columns.Contains("_Identify"))
				{
					goto IL_599;
				}
				IL_58D:
				num2 = 97;
				text4 = "_Identify";
				goto IL_5C3;
				IL_599:
				num2 = 99;
				if (this.BaseTable.PrimaryKey.Length != 1)
				{
					goto IL_5C3;
				}
				IL_5AC:
				num2 = 100;
				text4 = this.BaseTable.PrimaryKey[0].ColumnName;
				IL_5C3:
				num2 = 101;
				if (Operators.CompareString(text4, "", true) <= 0)
				{
					goto IL_61D;
				}
				IL_5D6:
				num2 = 102;
				if (!flag)
				{
					goto IL_5F4;
				}
				IL_5DC:
				num2 = 103;
				text4 = "\"" + text4 + "\"";
				goto IL_637;
				IL_5F4:
				num2 = 105;
				if (text4.EndsWith("]"))
				{
					goto IL_637;
				}
				IL_605:
				num2 = 106;
				text4 = "[" + text4 + "]";
				goto IL_637;
				IL_61D:
				num2 = 108;
				if (this.LoadPage <= 0)
				{
					goto IL_637;
				}
				IL_629:
				num2 = 109;
				MessageBox.Show("对于无主键的表，必须指定LoadOver属性才能分页加载!");
				IL_637:
				num2 = 110;
				string text7 = "";
				IL_641:
				num2 = 111;
				if (Operators.CompareString(this.o._OOO0oOo0__., "", true) <= 0)
				{
					goto IL_69C;
				}
				IL_658:
				num2 = 112;
				if (!flag)
				{
					goto IL_66B;
				}
				IL_65E:
				num2 = 113;
				text7 = this.o._OOO0oOo0__.;
				goto IL_6D5;
				IL_66B:
				num2 = 115;
				text7 = "[" + this.o._OOO0oOo0__..Trim(new char[]
				{
					'[',
					']'
				}) + "]";
				goto IL_6D5;
				IL_69C:
				num2 = 117;
				if (Operators.CompareString(this.DataServer, "", true) <= 0)
				{
					goto IL_6C5;
				}
				IL_6B3:
				num2 = 118;
				text7 = Oo00.O0__oo.__0o.(this.HttpSelect);
				goto IL_6D5;
				IL_6C5:
				num2 = 120;
				text7 = Oo00.O0__oo.__0o.(this.frd_SelectCommandString);
				IL_6D5:
				num2 = 121;
				string text8 = text4;
				IL_6DC:
				num2 = 122;
				if (Operators.CompareString(text4, "", true) <= 0 || text4.IndexOf(".") >= 0)
				{
					goto IL_730;
				}
				IL_6FE:
				num2 = 123;
				if (text7.StartsWith("(") && text7.EndsWith(")"))
				{
					goto IL_730;
				}
				IL_71D:
				num2 = 124;
				text4 = text7 + "." + text4;
				IL_730:
				num2 = 125;
				if (!(this.LoadPage > 0 & Operators.CompareString(this.LoadTop, "", true) > 0) || !Versioned.IsNumeric(this.LoadTop) || Operators.CompareString(text4, "", true) <= 0)
				{
					goto IL_AA5;
				}
				IL_779:
				num2 = 126;
				int num5 = Convert.ToInt32(this.LoadTop);
				IL_789:
				num2 = 127;
				string text9 = "";
				IL_793:
				num2 = 128;
				if (!flag)
				{
					goto IL_845;
				}
				IL_79F:
				num2 = 129;
				if (!this.LoadReverse)
				{
					goto IL_7F9;
				}
				IL_7AD:
				num2 = 130;
				text9 = string.Concat(new string[]
				{
					"(",
					text4,
					" < (Select Min(",
					text8,
					") From (Select ",
					text4,
					" From ",
					text2
				});
				goto IL_919;
				IL_7F9:
				num2 = 132;
				text9 = string.Concat(new string[]
				{
					"(",
					text4,
					" > (Select Max(",
					text8,
					") From (Select ",
					text4,
					" From ",
					text2
				});
				goto IL_919;
				IL_845:
				num2 = 134;
				if (!this.LoadReverse)
				{
					goto IL_8B7;
				}
				IL_853:
				num2 = 135;
				text9 = string.Concat(new string[]
				{
					"(",
					text4,
					" < (Select Min(",
					text8,
					") From (Select Top ",
					Conversions.ToString(num5 * this.LoadPage),
					" ",
					text4,
					" From ",
					text2
				});
				goto IL_919;
				IL_8B7:
				num2 = 137;
				text9 = string.Concat(new string[]
				{
					"(",
					text4,
					" > (Select Max(",
					text8,
					") From (Select Top ",
					Conversions.ToString(num5 * this.LoadPage),
					" ",
					text4,
					" From ",
					text2
				});
				IL_919:
				num2 = 138;
				if (Operators.CompareString(this.LoadFilter, "", true) <= 0)
				{
					goto IL_952;
				}
				IL_933:
				num2 = 139;
				text9 = text9 + " Where (" + this.LoadFilter + ")";
				IL_952:
				num2 = 140;
				if (!flag)
				{
					goto IL_9BB;
				}
				IL_95B:
				num2 = 141;
				if (Operators.CompareString(this.LoadFilter, "", true) <= 0)
				{
					goto IL_999;
				}
				IL_975:
				num2 = 142;
				text9 = text9 + " And ROWNUM <= " + Conversions.ToString(num5 * this.LoadPage);
				goto IL_9BB;
				IL_999:
				num2 = 144;
				text9 = text9 + " Where ROWNUM <= " + Conversions.ToString(num5 * this.LoadPage);
				IL_9BB:
				num2 = 145;
				text9 = text9 + " Order By " + text4;
				IL_9D1:
				num2 = 146;
				if (!this.LoadReverse)
				{
					goto IL_9F3;
				}
				IL_9DF:
				num2 = 147;
				text9 += " DESC";
				IL_9F3:
				num2 = 148;
				if (!flag)
				{
					goto IL_A12;
				}
				IL_9FC:
				num2 = 149;
				text9 += ")))";
				goto IL_A26;
				IL_A12:
				num2 = 151;
				text9 += ") As [fox_tmp] ))";
				IL_A26:
				num2 = 152;
				text = text + " Where (" + text9 + ")";
				IL_A41:
				num2 = 153;
				if (Operators.CompareString(this.LoadFilter, "", true) <= 0)
				{
					goto IL_A7A;
				}
				IL_A5B:
				num2 = 154;
				text = text + " And (" + this.LoadFilter + ")";
				IL_A7A:
				num2 = 155;
				if (!flag)
				{
					goto IL_B86;
				}
				IL_A86:
				num2 = 156;
				text = text + " And ROWNUM <=" + this.LoadTop;
				goto IL_B86;
				IL_AA5:
				num2 = 158;
				string text10 = this.LoadFilter;
				IL_AB3:
				num2 = 159;
				if (!(this.LoadPage <= 0 & Operators.CompareString(this.LoadTop, "", true) > 0) || !Versioned.IsNumeric(this.LoadTop))
				{
					goto IL_B55;
				}
				IL_AE9:
				num2 = 160;
				if (Operators.CompareString(this.DataServer, "", true) != 0 || !flag)
				{
					goto IL_B55;
				}
				IL_B05:
				num2 = 161;
				string text11 = "ROWNUM <= " + this.LoadTop;
				IL_B1D:
				num2 = 162;
				if (Operators.CompareString(text10, "", true) <= 0)
				{
					goto IL_B4B;
				}
				IL_B33:
				num2 = 163;
				text10 = text10 + " AND " + text11;
				goto IL_B55;
				IL_B4B:
				num2 = 165;
				text10 = text11;
				IL_B55:
				num2 = 166;
				if (Operators.CompareString(text10, "", true) <= 0)
				{
					goto IL_B86;
				}
				IL_B6B:
				num2 = 167;
				text = text + " Where (" + text10 + ")";
				IL_B86:
				num2 = 168;
				if (Operators.CompareString(this.o0_oO00.0oO_., "", true) <= 0)
				{
					goto IL_BBA;
				}
				IL_BA0:
				num2 = 169;
				text = text + " Group By " + this.o0_oO00.0oO_.;
				IL_BBA:
				num2 = 170;
				if (Operators.CompareString(this.O0o0__o.0000__., "", true) <= 0)
				{
					goto IL_BEE;
				}
				IL_BD4:
				num2 = 171;
				text = text + " having " + this.O0o0__o.0000__.;
				IL_BEE:
				num2 = 172;
				if (!(Operators.CompareString(this.LoadTop, "", true) > 0 & this.LoadPage >= 0) || Operators.CompareString(text4, "", true) <= 0)
				{
					goto IL_C61;
				}
				IL_C27:
				num2 = 173;
				text = text + " Order By " + text4;
				IL_C3D:
				num2 = 174;
				if (!this.LoadReverse)
				{
					goto IL_C95;
				}
				IL_C4B:
				num2 = 175;
				text += " DESC";
				goto IL_C95;
				IL_C61:
				num2 = 177;
				if (Operators.CompareString(this.LoadOrder, "", true) <= 0)
				{
					goto IL_C95;
				}
				IL_C7B:
				num2 = 178;
				text = text + " Order By " + this.LoadOrder;
				IL_C95:
				num2 = 179;
				OO_00oOO.LockBaseMainForm();
				IL_CA0:
				num2 = 180;
				if (Operators.CompareString(this.DataServer, "", true) <= 0)
				{
					goto IL_D45;
				}
				IL_CBD:
				num2 = 181;
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
				IL_CDA:
				num2 = 182;
				httpClient.FormData.Add("IgnoreSchema", "True");
				IL_CF6:
				num2 = 183;
				httpClient.Select = text;
				IL_D05:
				num2 = 184;
				this.O._O0__. = text;
				IL_D13:
				num2 = 185;
				httpClient.FormData["Action"] = 2.ToString();
				IL_D34:
				num2 = 186;
				this.O._0O_O0O.(null, httpClient);
				goto IL_DA3;
				IL_D45:
				num2 = 188;
				text = Oo00.o0_o._O_.(this.frd_Connection, text, false);
				IL_D5B:
				num2 = 189;
				A_1.SelectCommand.CommandText = text;
				IL_D6E:
				num2 = 190;
				if (A_1 == this._Adapter)
				{
					goto IL_D95;
				}
				IL_D7D:
				num2 = 191;
				this._Adapter.SelectCommand.CommandText = text;
				IL_D95:
				num2 = 192;
				this.O._0O_O0O.(A_1, null);
				IL_DA3:
				num2 = 193;
				OO_00oOO.UnlockBaseMainForm();
				IL_DAE:
				goto IL_1108;
				IL_DB3:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_10C9:
				goto IL_10FD;
				IL_10CB:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_10DB:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_10CB;
			}
			IL_10FD:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1108:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00104FAC File Offset: 0x001031AC
		private void <<EMPTY_NAME>>(OleDbDataAdapter A_0, HttpClient A_1 = null)
		{
			this.o_oO0O_.O0. = null;
			ConnectionState state;
			if (A_0 != null)
			{
				state = this.o0__.Oo0o__O..State;
				if (A_0 == this._Adapter && this.o0__.Oo0o__O..State != ConnectionState.Open)
				{
					this.o0__.Oo0o__O..Open();
				}
			}
			bool a_ = OO_00oOO.SystemReady;
			try
			{
				OO_00oOO.SystemReady = false;
				this.O.0_0O. = false;
				this.o0_OO.o00OO. = false;
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.Name.StartsWith(this.Name + "."))
						{
							table.StopRedraw();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				try
				{
					foreach (Table table2 in OO_00oOO.Tables)
					{
						if (table2.View.o_o.O0ooOo.() == this._DataTable)
						{
							table2.StopRedraw();
							string a_2 = table2._frdFilterString;
							table2.Filter = "False";
							table2._frdFilterString = a_2;
							table2.View.O00o0.0_0O_.(false);
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				if (A_0 != null)
				{
					this.BaseTable.Rows.Clear();
					A_0.Fill(this._DataTable);
				}
				else if (A_1 != null)
				{
					DataTable baseDataTable = A_1.GetBaseDataTable();
					this.BaseTable.Rows.Clear();
					this.BaseTable.Merge(baseDataTable, false, MissingSchemaAction.Ignore);
					this.BaseTable.AcceptChanges();
				}
				if (this._DataTable.Columns.Contains("_SortKey"))
				{
					this.FillSortKeyValue();
				}
				this.ooO.oO0O0_oo. = false;
				bool flag = true;
			}
			catch (Exception a_3)
			{
				ooO.oOo0Oo.o.(a_3, "加载[" + this.Name + "]失败!");
			}
			finally
			{
				if (A_0 != null && A_0 == this._Adapter && state != ConnectionState.Open)
				{
					this.o0__.Oo0o__O..Close();
				}
				try
				{
					foreach (Table table3 in OO_00oOO.Tables)
					{
						if (table3.View.o_o.O0ooOo.() == this._DataTable)
						{
							table3.ClearEditInfos();
							table3.View.O00o0.0_0O_.(true);
							table3.ApplyFilter = false;
							table3.StateFilter = StateFilterEnum.Default;
							table3.ResumeRedraw();
						}
						else if (table3.Name.StartsWith(this.Name + "."))
						{
							table3.ResumeRedraw();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
				OO_00oOO.SystemReady = a_;
				bool flag;
				if (flag && this._DataTable.DataSet == O_O0OO.OOOo.oo_OOOO_0.())
				{
					this.O.0_0O. = true;
					this.o0_OO.o00OO. = true;
				}
			}
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x001052D4 File Offset: 0x001034D4
		internal void <<EMPTY_NAME>>()
		{
			LoadEventArgs loadEventArgs = new LoadEventArgs(this);
			string a_ = "AfterLoad";
			O_O0OO.OoO_o.oO0o0O.(this.o_0_00_.oo0O0., a_, new object[]
			{
				loadEventArgs
			}, false, this.BaseTable.TableName, false);
			if (!loadEventArgs.Cancel && OO_00oOO.DataTables[this.BaseTable.TableName].GlobalHandler.AfterLoad)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					loadEventArgs
				}, false, "全局表事件", false);
			}
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00105358 File Offset: 0x00103558
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.View.o_o.O0ooOo.() == this._DataTable || table.Name.StartsWith(this.Name + "."))
					{
						table.RaiseCurrentChanged();
						table.RaisePositionChanged();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x001053DC File Offset: 0x001035DC
		internal void <<EMPTY_NAME>>(string A_0, OleDbConnection A_1, O0O A_2, bool A_3)
		{
			if (this._DataTable.ChildRelations.Count > 0 || this._DataTable.ParentRelations.Count > 0)
			{
				MessageBox.Show("当前表存在关联，不允许使用此方法加载数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			HttpClient httpClient = null;
			DataServerTypeEnum a_ = DataServerTypeEnum.Access;
			this.DataServer = "";
			this.UpdateServer = "";
			this.HttpSelect = "";
			this.UpdateColumns = null;
			this.o0__.Oo0o__O. = null;
			this.O._O0__. = null;
			if (A_2 != null)
			{
				httpClient = A_2.oO0_0.o.();
				a_ = A_2.OO.OoO0.;
			}
			else if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_1))
			{
				a_ = DataServerTypeEnum.Oracle;
			}
			else if (o_O_o_oOoo__.OOOO_OO._oo.(A_1))
			{
				a_ = DataServerTypeEnum.SqlServer;
			}
			this.o00o.00oO___0..Clear();
			if (httpClient == null)
			{
				A_0 = Oo00.o0_o._O_.(A_1, A_0, false);
				this._Adapter = new OleDbDataAdapter(A_0, A_1);
				this.o0__.Oo0o__O. = A_1;
				if (A_3)
				{
					this.o._OOO0oOo0__. = "";
				}
				else
				{
					o_O_o_oOoo__.OO_O0oO0.oooO_.(this._Adapter);
					this.o._OOO0oOo0__. = Oo00.ooO.ooo.(this._Adapter);
				}
				this._Adapter.SelectCommand.CommandTimeout = this.FillLoadTimeOut;
			}
			else
			{
				A_0 = Oo00.o0_o._O_.(a_, A_0, false);
				this.DataServer = httpClient.Oo_0oO0Oo0_.O_.;
				this.HttpSelect = A_0;
				if (A_3)
				{
					this.o._OOO0oOo0__. = "";
				}
				else
				{
					this.o._OOO0oOo0__. = Oo00.o.Oo0oO.(A_0);
					this.UpdateServer = httpClient.Oo_0oO0Oo0_.O_.;
				}
			}
			Form form = null;
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable == this && !table.IsRelation)
					{
						form = table.foxGrid.FindForm();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			bool a_2 = OO_00oOO.SystemReady;
			if (this.OO._0oo000_00. != null)
			{
				this.OO._0oo000_00..ExtendedProperties.Clear();
				this.OO._0oo000_00. = null;
			}
			try
			{
				if (form != null)
				{
					ShareLibriay.LockWindowUpdate(form.Handle);
				}
				OO_00oOO.SystemReady = false;
				this.o0O_ooo__.O0o_.();
				try
				{
					foreach (Table table2 in OO_00oOO.Tables)
					{
						if (table2.DataTable == this)
						{
							table2.CloseRecordGrid();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				try
				{
					foreach (Table table3 in OO_00oOO.Tables)
					{
						if (table3.DataTable == this)
						{
							table3.StopRedraw();
							table3.Sort = "";
							table3.Filter = "";
							table3.O_O__.ooOo..Clear();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
				this.BaseTable.Reset();
				try
				{
					if (httpClient == null)
					{
						if (!A_3)
						{
							this._Adapter.FillSchema(this._DataTable, SchemaType.Source);
						}
						this._Adapter.Fill(this._DataTable);
					}
					else
					{
						if (!A_3)
						{
							httpClient.FormData["Action"] = 1.ToString();
						}
						else
						{
							httpClient.FormData["Action"] = 2.ToString();
						}
						httpClient.Select = A_0;
						DataTable baseDataTable = httpClient.GetBaseDataTable();
						if (baseDataTable != null && baseDataTable.Columns.Count > 0)
						{
							if (!A_3)
							{
								this.UpdateColumns = (List<string>)baseDataTable.ExtendedProperties["UpdateColumns"];
							}
							this._DataTable.Reset();
							this._DataTable.Merge(baseDataTable, false, MissingSchemaAction.AddWithKey);
							baseDataTable.Dispose();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Select语句执行错误，请检查语法及数据源设置。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this._DataTable.Reset();
					string text = "一二三四五六七八九十";
					int num = 0;
					do
					{
						this._DataTable.Columns.Add("第" + Conversions.ToString(text[num]) + "列", typeof(string));
						num++;
					}
					while (num <= 9);
					this._DataTable.AcceptChanges();
					this.o0__.Oo0o__O. = null;
				}
				if (!this._DataTable.Columns.Contains("_Locked"))
				{
					this._DataTable.Columns.Add("_Locked", typeof(bool));
					this.O000_00._0_o. = false;
				}
				else
				{
					this.O000_00._0_o. = true;
				}
				if (this._DataTable.PrimaryKey.Length == 1 && this._DataTable.PrimaryKey[0].AutoIncrement)
				{
					this._DataTable.PrimaryKey[0].ReadOnly = false;
					this.O_.__0. = this._DataTable.PrimaryKey[0].ColumnName;
				}
				if (this._DataTable.Columns.Contains("_SortKey"))
				{
					this.FillSortKeyValue();
				}
				if (this.o0__.Oo0o__O. == O_O0OO.OoO.0OO__0ooo.() && this._DataTable.PrimaryKey.Length == 1 && Operators.CompareString(this._DataTable.PrimaryKey[0].ColumnName, "_Identify", true) == 0)
				{
					this._DataTable.Columns["_Identify"].AutoIncrement = true;
					this._DataTable.Columns["_Identify"].AutoIncrementStep = 1L;
					this._DataTable.Columns["_Identify"].AutoIncrementSeed = 1L;
					if (this._DataTable.Rows.Count > 0 && this._DataTable.Rows.Count > 0)
					{
						this._DataTable.Columns["_Identify"].AutoIncrementSeed = (long)(Conversions.ToInteger(this._DataTable.Compute("Max([_Identify])", "")) + 1);
					}
				}
				this._DataTable.Columns.Add("System_Sort_Temporary", typeof(double));
				this._DataTable.Columns.Add("System_Filter_Temporary", typeof(int));
				this._DataTable.Columns.Add("System_Filter_Unique", typeof(int));
				this.o_oO0O_.O0. = null;
				this.o.0O000_.();
				try
				{
					foreach (Table table4 in OO_00oOO.Tables)
					{
						if (table4.View.o_o.O0ooOo.() == this.BaseTable)
						{
							table4.View.oO0o0_.OoO_.("");
							table4.View.set_Filter("True");
							table4.View.set_Filter("");
							table4.Cols.Reset();
							table4.oO_o_0o._0oooo.(true);
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator4;
					if (enumerator4 != null)
					{
						enumerator4.Dispose();
					}
				}
				OO_00oOO.SystemReady = a_2;
				try
				{
					foreach (Table table5 in OO_00oOO.Tables)
					{
						if (table5.DataTable == this)
						{
							table5.ResumeRedraw();
							table5.RaiseCurrentChanged();
							table5.RaisePositionChanged();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator5;
					if (enumerator5 != null)
					{
						enumerator5.Dispose();
					}
				}
				if (A_3)
				{
					this.AllowEdit = false;
				}
				this.ooO.oO0O0_oo. = false;
			}
			catch (Exception a_3)
			{
				ooO.oOo0Oo.o.(a_3, "");
			}
			finally
			{
				if (form != null)
				{
					ShareLibriay.LockWindowUpdate(IntPtr.Zero);
				}
				OO_00oOO.SystemReady = a_2;
			}
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00105BD8 File Offset: 0x00103DD8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Fill(params object[] args)
		{
			if (args.Length == 2)
			{
				this.Fill(Conversions.ToString(args[0]), Conversions.ToBoolean(args[1]));
				return;
			}
			if (args.Length == 3)
			{
				this.Fill(Conversions.ToString(args[0]), Conversions.ToString(args[1]), Conversions.ToBoolean(args[2]));
			}
		}

		/// <summary>
		/// 根据指定的Select语句重新加载数据。
		/// </summary>
		/// <param name="selectString">Select语句</param>
		/// <param name="connName">数据源名称</param>
		/// <param name="isQuery">设为True，表示查询表，设为False，表示数据表。</param>
		// Token: 0x06002457 RID: 9303 RVA: 0x00105C28 File Offset: 0x00103E28
		[oO0oooo("1929")]
		public void Fill(string selectString, string connName, bool isQuery)
		{
			if (Operators.CompareString(connName, "", true) == 0)
			{
				this.o0O.O_0.(selectString, O_O0OO.OoO.0OO__0ooo.(), null, isQuery);
				return;
			}
			OleDbConnection oleDbConnection = null;
			O0O o0O = null;
			if (Operators.CompareString(connName, "", true) == 0)
			{
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.();
			}
			else if (O_O0OO.O._o_.().ContainsKey(connName))
			{
				oleDbConnection = O_O0OO.O._o_.()[connName];
			}
			else if (O_O0OO.OoO__.0oO0oo.().ContainsKey(connName))
			{
				o0O = O_O0OO.OoO__.0oO0oo.()[connName];
			}
			if (oleDbConnection == null && o0O == null)
			{
				MessageBox.Show("不存在名为\"" + connName + "\"的数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			this.o0O.O_0.(selectString, oleDbConnection, o0O, isQuery);
			this.ConnectionName = connName;
		}

		/// <summary>
		/// 根据指定的Select语句重新加载数据。
		/// </summary>
		/// <param name="SelectString">Select语句</param>
		/// <param name="isQuery">设为True，表示查询表，设为False，表示数据表</param>
		// Token: 0x06002458 RID: 9304 RVA: 0x00105CD6 File Offset: 0x00103ED6
		[oO0oooo("1929")]
		public void Fill(string SelectString, bool isQuery)
		{
			this.o0O.O_0.(SelectString, O_O0OO.OoO.0OO__0ooo.(), null, isQuery);
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x00105CE8 File Offset: 0x00103EE8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataRow NewRow()
		{
			DataRowEventArgs dataRowEventArgs = new DataRowEventArgs(this, null);
			string a_ = "BeforeAddDataRow";
			O_O0OO.OoO_o.oO0o0O.(this.o_0_00_.oo0O0., a_, new object[]
			{
				dataRowEventArgs
			}, false, this.Name, false);
			if (!dataRowEventArgs.Cancel && this.GlobalHandler.BeforeAddDataRow)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					dataRowEventArgs
				}, false, "全局表事件", false);
			}
			DataRow result;
			if (dataRowEventArgs.Cancel)
			{
				result = null;
			}
			else
			{
				result = new DataRow(this._DataTable.NewRow());
			}
			return result;
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00105D72 File Offset: 0x00103F72
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddRow(DataRow Row)
		{
			this._DataTable.Rows.Add(Row.BaseRow);
		}

		/// <summary>
		/// 新增一行或多行
		/// </summary>
		/// <param name="Count">要增加的行数，默认为1</param>
		// Token: 0x0600245B RID: 9307 RVA: 0x00105D8C File Offset: 0x00103F8C
		[oO0oooo("0421")]
		public DataRow AddNew(int Count = 1)
		{
			DataRow dataRow = null;
			List<Table> list = new List<Table>();
			if (Count > 5)
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this)
						{
							table.foxGrid.BeginUpdate();
							list.Add(table);
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			for (int i = 1; i <= Count; i++)
			{
				DataRow dataRow2 = this.NewRow();
				if (dataRow2 == null)
				{
					break;
				}
				this._DataTable.Rows.Add(dataRow2.BaseRow);
				if (dataRow == null)
				{
					dataRow = dataRow2;
				}
			}
			try
			{
				foreach (Table table2 in OO_00oOO.Tables)
				{
					if (table2.View.o_o.O0ooOo.() == this._DataTable)
					{
						O_oOooO_O o_oOooO_O = table2.foxGrid;
						if (o_oOooO_O.Row < o_oOooO_O.Rows.Fixed & o_oOooO_O.Rows.Count > o_oOooO_O.Rows.Fixed)
						{
							o_oOooO_O.Row = o_oOooO_O.Rows.Fixed;
							table2.View.o_._0O0o_OoO.();
							table2.View.Oo._Oo0OO.();
						}
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			try
			{
				foreach (Table table3 in list)
				{
					table3.foxGrid.EndUpdate();
				}
			}
			finally
			{
				List<Table>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			return dataRow;
		}

		/// <summary>
		/// 查找符合指定条件的行
		/// </summary>
		/// <param name="Filter">条件表达式</param>
		/// <param name="Sort">排序列</param>
		/// <param name="Index">返回第几个符合条件的行，默认返回第一行</param>
		// Token: 0x0600245C RID: 9308 RVA: 0x00105F38 File Offset: 0x00104138
		[oO0oooo("0396")]
		public DataRow Find(string Filter, string Sort = "", int Index = 0)
		{
			object obj = this._DataTable;
			DataRow[] array;
			lock (obj)
			{
				array = this._DataTable.Select(Filter, Sort);
			}
			DataRow result;
			if (array.Length > 0)
			{
				if (Index > array.Length - 1 || Index < 0)
				{
					result = null;
				}
				else
				{
					result = new DataRow(array[Index]);
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00105FA4 File Offset: 0x001041A4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Select(params object[] args)
		{
			List<DataRow> list = null;
			switch (args.Length)
			{
			case 1:
				list = this.Select(Conversions.ToString(args[0]));
				break;
			case 2:
				list = this.Select(Conversions.ToString(args[0]), Conversions.ToString(args[1]));
				break;
			case 3:
				list = this.Select(Conversions.ToString(args[0]), Conversions.ToString(args[1]), (DataViewRowState)Conversions.ToInteger(args[2]));
				break;
			}
			object result;
			if (ooO.o.O_0000_O.())
			{
				result = ((list != null) ? list.ToArray() : new DataRow[0]);
			}
			else
			{
				result = list;
			}
			return result;
		}

		/// <summary>
		/// 返回所有符合条件的行
		/// </summary>
		/// <param name="Filter">条件表达式</param>
		// Token: 0x0600245E RID: 9310 RVA: 0x00106034 File Offset: 0x00104234
		[oO0oooo("0400")]
		public List<DataRow> Select(string Filter)
		{
			return this.Select(Filter, "", DataViewRowState.CurrentRows);
		}

		/// <summary>
		/// 返回所有符合条件的行
		/// </summary>
		/// <param name="Filter">条件表达式</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x0600245F RID: 9311 RVA: 0x00106044 File Offset: 0x00104244
		[oO0oooo("0400")]
		public List<DataRow> Select(string Filter, string Sort)
		{
			return this.Select(Filter, Sort, DataViewRowState.CurrentRows);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00106050 File Offset: 0x00104250
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<DataRow> Select(string Filter, string Sort, DataViewRowState RowState)
		{
			List<DataRow> list = new List<DataRow>();
			object obj = this._DataTable;
			DataRow[] array;
			lock (obj)
			{
				array = this._DataTable.Select(Filter, Sort, RowState);
			}
			List<DataRow> result;
			if (array.Length == 0)
			{
				result = list;
			}
			else
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					list.Add(new DataRow(array[i]));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x001060D4 File Offset: 0x001042D4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Compute(params object[] Args)
		{
			object result;
			if (Args.Length == 1)
			{
				result = this.Compute(Conversions.ToString(Args[0]));
			}
			else if (Args.Length == 2)
			{
				result = this.Compute(Conversions.ToString(Args[0]), Conversions.ToString(Args[1]));
			}
			else
			{
				result = null;
			}
			return result;
		}

		/// <summary>
		/// 数据汇总
		/// </summary>
		/// <param name="Expression">聚合函数表达式</param>
		// Token: 0x06002462 RID: 9314 RVA: 0x0010611A File Offset: 0x0010431A
		[oO0oooo("0393")]
		public object Compute(string Expression)
		{
			return this.Compute(Expression, "");
		}

		/// <summary>
		/// 数据汇总
		/// </summary>
		/// <param name="Expression">聚合函数表达式</param>
		/// <param name="Filter">计算条件表达式</param>
		// Token: 0x06002463 RID: 9315 RVA: 0x00106128 File Offset: 0x00104328
		[oO0oooo("0393")]
		public object Compute(string Expression, string Filter)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(this._DataTable.Compute(Expression, Filter));
			object result;
			if (objectValue == DBNull.Value)
			{
				result = null;
			}
			else
			{
				result = objectValue;
			}
			return result;
		}

		/// <summary>
		/// 停止绘制表
		/// </summary>
		// Token: 0x06002464 RID: 9316 RVA: 0x00106158 File Offset: 0x00104358
		[oO0oooo("0401")]
		public void StopRedraw()
		{
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.View.o_o.O0ooOo.() == this._DataTable)
					{
						table.StopRedraw();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		/// <summary>
		/// 恢复绘制表
		/// </summary>
		// Token: 0x06002465 RID: 9317 RVA: 0x001061B8 File Offset: 0x001043B8
		[oO0oooo("0402")]
		public void ResumeRedraw()
		{
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.View.o_o.O0ooOo.() == this._DataTable)
					{
						table.ResumeRedraw();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		/// <summary>
		/// 从指定的列中提取不重复的值，用符号"|"将这些值连接成一个字符串，并返回这个字符串。
		/// </summary>
		/// <param name="ColumnName">列名</param>
		/// <param name="Filter">条件表达式</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x06002466 RID: 9318 RVA: 0x00106218 File Offset: 0x00104418
		[oO0oooo("1435")]
		public string GetComboListString(string ColumnName, string Filter = "", string Sort = "")
		{
			string result;
			if (Operators.CompareString(Sort, "", true) == 0)
			{
				List<string> uniqueValues = this.GetUniqueValues(Filter, ColumnName);
				result = string.Join("|", uniqueValues.ToArray());
			}
			else
			{
				List<string> list = new List<string>();
				int num = this._DataTable.Columns.IndexOf(ColumnName);
				DataView dataView = new DataView(this._DataTable, Filter, Sort, DataViewRowState.CurrentRows);
				int num2 = dataView.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (!dataView[i].Row.IsNull(num))
					{
						string item = dataView[i][num].ToString();
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
				result = string.Join("|", list.ToArray());
			}
			return result;
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x001062E7 File Offset: 0x001044E7
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string GetStrings(string ColumnName, string Filter = "", string sort = "")
		{
			return this.GetComboListString(ColumnName, Filter, sort);
		}

		/// <summary>
		/// 从指定的列中提取不重复值，并以集合形式返回
		/// </summary>
		/// <param name="ColumnNames">列名</param>
		/// <param name="Filter">条件表达式</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x06002468 RID: 9320 RVA: 0x001062F4 File Offset: 0x001044F4
		[oO0oooo("2747")]
		public object GetValues(string ColumnNames, string Filter = "", string Sort = "")
		{
			string[] array = ColumnNames.Split(new char[]
			{
				'|'
			});
			object result;
			if (array.Length == 1)
			{
				List<string> list = new List<string>();
				list = Oo00.O____0O._0.(this.BaseTable, Filter, Sort, array[0]);
				if (ooO.o.O_0000_O.())
				{
					result = list.ToArray();
				}
				else
				{
					result = list;
				}
			}
			else
			{
				List<string[]> list2 = new List<string[]>();
				list2 = Oo00.O____0O._0.(this.BaseTable, Filter, Sort, array);
				if (ooO.o.O_0000_O.())
				{
					ArrayList arrayList = new ArrayList();
					try
					{
						foreach (string[] value in list2)
						{
							arrayList.Add(value);
						}
					}
					finally
					{
						List<string[]>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = arrayList;
				}
				else
				{
					result = list2;
				}
			}
			return result;
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x001063B8 File Offset: 0x001045B8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<string> GetUniqueValues(string Filter, string ColumnName)
		{
			return Oo00.O____0O._0.(this.BaseTable, Filter, "", ColumnName);
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x001063CC File Offset: 0x001045CC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<string[]> GetUniqueValues(string Filter, params string[] ColumnNames)
		{
			return Oo00.O____0O._0.(this.BaseTable, Filter, "", ColumnNames);
		}

		/// <summary>
		/// 是否启用多层表头。
		/// </summary>
		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x001063E0 File Offset: 0x001045E0
		// (set) Token: 0x0600246C RID: 9324 RVA: 0x001063E8 File Offset: 0x001045E8
		[oO0oooo("1992")]
		public bool MultiRowHeader
		{
			get
			{
				return this.oo._O_o0_O.;
			}
			set
			{
				this.oo._O_o0_O. = value;
			}
		}

		/// <summary>
		/// 批量删除符合条件的行
		/// </summary>
		/// <param name="Filter">删除条件</param>
		// Token: 0x0600246D RID: 9325 RVA: 0x001063F4 File Offset: 0x001045F4
		[oO0oooo("0394")]
		public void DeleteFor(string Filter)
		{
			if (this._DataTable.DataSet == null)
			{
				object obj = this._DataTable;
				DataRow[] array;
				lock (obj)
				{
					array = this._DataTable.Select(Filter, "", DataViewRowState.CurrentRows);
				}
				for (int i = array.Length - 1; i >= 0; i += -1)
				{
					array[i].Delete();
				}
				return;
			}
			List<OoO_O00> list = new List<OoO_O00>();
			DataRow[] array2 = this.BaseTable.Select(Filter, "", DataViewRowState.CurrentRows);
			try
			{
				this.StopRedraw();
				List<DataTable> list2 = new List<DataTable>();
				Foxtable.Syscmd.Row.OO.OO_0o.(list2, this.BaseTable);
				if (array2.Length > 1)
				{
					try
					{
						foreach (DataTable dataTable in list2)
						{
							try
							{
								foreach (Table table in OO_00oOO.Tables)
								{
									if (table.View.o_o.O0ooOo.() == dataTable)
									{
										list.Add(new OoO_O00(table));
									}
								}
							}
							finally
							{
								IEnumerator<Table> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
						}
					}
					finally
					{
						List<DataTable>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				foreach (DataRow a_ in array2)
				{
					new DataRow(a_).Delete();
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			finally
			{
				Foxtable.RibbonMenu.StatusBar.Message1 = "";
				try
				{
					foreach (OoO_O00 ooO_O in list)
					{
						ooO_O.O._00000.(null);
					}
				}
				finally
				{
					List<OoO_O00>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				this.ResumeRedraw();
			}
			try
			{
				foreach (Table table2 in OO_00oOO.Tables)
				{
					if (table2.DataTable == this)
					{
						table2.ClearEditInfos();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator4;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
			}
		}

		/// <summary>
		/// 按条件批量更新某列内容
		/// </summary>
		/// <param name="ColumnName">列名</param>
		/// <param name="Value">新的值</param>
		/// <param name="Filter">条件表达式</param>
		// Token: 0x0600246E RID: 9326 RVA: 0x00106634 File Offset: 0x00104834
		[oO0oooo("1532")]
		public void ReplaceFor(string ColumnName, object Value, string Filter = "")
		{
			object obj = this._DataTable;
			DataRow[] array;
			lock (obj)
			{
				array = this.BaseTable.Select(Filter, "");
			}
			DataRow[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i][ColumnName] = RuntimeHelpers.GetObjectValue(Value);
				}
			}
		}

		/// <summary>
		/// 批量移除符合条件的行
		/// </summary>
		/// <param name="Filter">条件表达式</param>
		// Token: 0x0600246F RID: 9327 RVA: 0x001066A4 File Offset: 0x001048A4
		[oO0oooo("0408")]
		public void RemoveFor(string Filter)
		{
			if (this._DataTable.DataSet == null)
			{
				object obj = this._DataTable;
				DataRow[] array;
				lock (obj)
				{
					array = this._DataTable.Select(Filter, "", DataViewRowState.CurrentRows);
				}
				for (int i = array.Length - 1; i >= 0; i += -1)
				{
					array[i].RowError = "a";
					this._DataTable.Rows.Remove(array[i]);
				}
				return;
			}
			int num = -1;
			if (O_O0OO.o__.O.()[this.Name].Position > -1)
			{
				o_O_o_oOoo__.OO_O0oO0.oooO_.(O_O0OO.o__.O.()[this.Name].o_o.O0ooOo.().Row);
			}
			if (O_O0OO.o__.O.()[this.Name].Count > 0)
			{
				num = O_O0OO.o__.O.()[this.Name].Position;
			}
			if (OO_00oOO.Tables[this.Name].ApplySort)
			{
				OO_00oOO.Tables[this.Name].Sort;
			}
			try
			{
				OO_00oOO.Tables[this.Name].StopRedraw();
				object obj2 = this._DataTable;
				DataRow[] array2;
				lock (obj2)
				{
					array2 = this._DataTable.Select(Filter, OO_00oOO.Tables[this.Name].Sort, DataViewRowState.CurrentRows);
				}
				for (int j = array2.Length - 1; j >= 0; j += -1)
				{
					array2[j].RowError = "a";
					this._DataTable.Rows.Remove(array2[j]);
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				OO_00oOO.Tables[this.Name].ResumeRedraw();
			}
			if (num >= 0 && O_O0OO.o__.O.()[this.Name].Count > num)
			{
				O_O0OO.o__.O.()[this.Name].Position = num;
			}
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable == this)
					{
						table.ClearEditInfos();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		/// <summary>
		/// 切换数据源
		/// </summary>
		/// <param name="ConnectionName">新数据源的名称</param>
		// Token: 0x06002470 RID: 9328 RVA: 0x00106938 File Offset: 0x00104B38
		[oO0oooo("1932")]
		public void ChangeConnection(string ConnectionName)
		{
			if (this.frd_IsOuterTable || this.frd_IsOuterQuery)
			{
				try
				{
					foreach (string text in O_O0OO.O._o_.().Keys)
					{
						if (Operators.CompareString(text, ConnectionName, true) == 0)
						{
							bool flag = this.frd_IsOuterTable;
							this.o0__.Oo0o__O. = O_O0OO.O._o_.()[text];
							this._Adapter = new OleDbDataAdapter(this._Adapter.SelectCommand.CommandText, this.o0__.Oo0o__O.);
							if (flag)
							{
								this.O_00_._.();
							}
							this.o._OOO0oOo0__. = null;
							this.o0.o.(true, null);
						}
					}
					return;
				}
				finally
				{
					Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			MessageBox.Show("只有外部数据表和外部查询表才能切换数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		/// <summary>
		/// 接受此表所有修改结果，之前所做的修改将不会被保存。
		/// </summary>
		// Token: 0x06002471 RID: 9329 RVA: 0x00106A08 File Offset: 0x00104C08
		[oO0oooo("2365")]
		public void AcceptChanges()
		{
			this.BaseTable.AcceptChanges();
		}

		/// <summary>
		/// 撤销自打开文件或最近一次保存以来，对该表做出的修改。
		/// </summary>
		// Token: 0x06002472 RID: 9330 RVA: 0x00106A18 File Offset: 0x00104C18
		[oO0oooo("1538")]
		public void RejectChanges()
		{
			List<DataColumn> list = new List<DataColumn>();
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (dataRelation.ParentTable == this.BaseTable)
					{
						foreach (DataColumn item in dataRelation.ParentColumns)
						{
							if (!list.Contains(item))
							{
								list.Add(item);
							}
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
			try
			{
				foreach (object obj2 in this.BaseTable.Rows)
				{
					DataRow dataRow = (DataRow)obj2;
					if (dataRow.RowState == DataRowState.Modified)
					{
						try
						{
							foreach (DataColumn column in list)
							{
								dataRow[column] = RuntimeHelpers.GetObjectValue(dataRow[column, DataRowVersion.Original]);
							}
						}
						finally
						{
							List<DataColumn>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
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
			this.BaseTable.RejectChanges();
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable == this)
					{
						table.ClearEditInfos();
					}
					if (table.o00oOO00_.ooOo. != null && table.o00oOO00_.ooOo..FindForm() != null)
					{
						table.o00oOO00_.ooOo..Oo0o__.OO0o__O.();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator4;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
			}
			if (O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(this.BaseTable.TableName))
			{
				OO_00oOO.Tables[this.BaseTable.TableName].RefreshChildTables();
			}
		}

		/// <summary>
		/// 全局表事件开关器
		/// </summary>
		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x00106C14 File Offset: 0x00104E14
		[oO0oooo("0671")]
		public GlobalEvents GlobalHandler
		{
			get
			{
				return this.o_0_00_.oo0O0.;
			}
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00106C1C File Offset: 0x00104E1C
		private string <<EMPTY_NAME>>()
		{
			string result;
			if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection))
			{
				result = this.o._OOO0oOo0__.;
			}
			else
			{
				result = "[" + this.o._OOO0oOo0__..Trim(new char[]
				{
					'[',
					']'
				}) + "]";
			}
			return result;
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x00106C6C File Offset: 0x00104E6C
		internal void <<EMPTY_NAME>>()
		{
			if ((this.frd_IsInnerTable || this.frd_IsOuterTable) && !this.BaseTable.Columns.Contains("_SortKey"))
			{
				Type a_ = null;
				if (this.BaseTable.PrimaryKey.Length == 1)
				{
					a_ = this.BaseTable.PrimaryKey[0].DataType;
				}
				string text = this.o.o00O.();
				if (o_O_o_oOoo__.OO_.O.(a_))
				{
					if (Operators.CompareString(this.UpdateServer, "", true) == 0)
					{
						OleDbCommand oleDbCommand = new OleDbCommand("", this.frd_Connection);
						oleDbCommand.Transaction = this._Adapter.SelectCommand.Transaction;
						if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection))
						{
							oleDbCommand.CommandText = "Alter Table " + text + " ADD \"_SortKey\" Number(28,14)";
						}
						else
						{
							oleDbCommand.CommandText = "Alter Table " + text + " ADD [_SortKey] Decimal(28,14)";
						}
						this.frd_Connection.Open();
						oleDbCommand.ExecuteNonQuery();
						oleDbCommand.CommandText = string.Concat(new string[]
						{
							"UPDATE ",
							text,
							" Set [_SortKey]  = [",
							this.BaseTable.PrimaryKey[0].ColumnName,
							"]"
						});
						if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection))
						{
							oleDbCommand.CommandText = oleDbCommand.CommandText.Replace("[", "\"").Replace("]", "\"");
						}
						oleDbCommand.ExecuteNonQuery();
						this.frd_Connection.Close();
						return;
					}
					HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
					httpClient.Select = "Alter Table " + text + " ADD [_SortKey] Decimal(28,14)";
					httpClient.FormData.Add("Action", 7.ToString());
					httpClient.GetData();
					httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
					httpClient.Select = string.Concat(new string[]
					{
						"UPDATE ",
						text,
						" Set [_SortKey]  = [",
						this.BaseTable.PrimaryKey[0].ColumnName,
						"]"
					});
					httpClient.FormData.Add("Action", 7.ToString());
					httpClient.GetData();
					return;
				}
				else
				{
					MessageBox.Show("主键列必须是数值型，才可以添加排序标志列。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00106ED0 File Offset: 0x001050D0
		internal void <<EMPTY_NAME>>()
		{
			if ((this.frd_IsInnerTable || this.frd_IsOuterTable) && Operators.CompareString(this.O_.__0., "", true) > 0 && this.BaseTable.Columns.Contains("_SortKey"))
			{
				string str = this.o.o00O.();
				string text = "Alter Table " + str + " Drop COLUMN [_SortKey]";
				if (Operators.CompareString(this.UpdateServer, "", true) == 0)
				{
					OleDbCommand oleDbCommand = new OleDbCommand("", this.frd_Connection);
					oleDbCommand.Transaction = this._Adapter.SelectCommand.Transaction;
					oleDbCommand.CommandText = text;
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection))
					{
						oleDbCommand.CommandText = oleDbCommand.CommandText.Replace("[", "\"").Replace("]", "\"");
					}
					this.frd_Connection.Open();
					oleDbCommand.ExecuteNonQuery();
					this.frd_Connection.Close();
					return;
				}
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
				httpClient.Select = text;
				httpClient.FormData.Add("Action", 7.ToString());
				httpClient.GetData();
			}
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00107010 File Offset: 0x00105210
		internal void <<EMPTY_NAME>>()
		{
			if ((this.frd_IsInnerTable || this.frd_IsOuterTable) && !this.O000_00._0_o.)
			{
				string str = this.o.o00O.();
				string text;
				if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection))
				{
					text = "Alter Table " + str + " ADD \"_Locked\" NUMBER(1,0)";
				}
				else
				{
					text = "Alter Table " + str + " ADD [_Locked] bit";
				}
				if (Operators.CompareString(this.UpdateServer, "", true) == 0)
				{
					OleDbCommand oleDbCommand = new OleDbCommand(text, this.frd_Connection);
					oleDbCommand.Transaction = this._Adapter.SelectCommand.Transaction;
					this.frd_Connection.Open();
					oleDbCommand.ExecuteNonQuery();
					this.frd_Connection.Close();
					return;
				}
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
				httpClient.Select = text;
				httpClient.FormData.Add("Action", 7.ToString());
				httpClient.GetData();
			}
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00107108 File Offset: 0x00105308
		internal void <<EMPTY_NAME>>()
		{
			if (this.frd_IsInnerTable || this.frd_IsOuterTable)
			{
				string str = this.o.o00O.();
				string text = "Alter Table " + str + " Drop COLUMN [_Locked]";
				if (this.O000_00._0_o.)
				{
					if (Operators.CompareString(this.UpdateServer, "", true) == 0)
					{
						OleDbCommand oleDbCommand = new OleDbCommand("", this.frd_Connection);
						oleDbCommand.Transaction = this._Adapter.SelectCommand.Transaction;
						oleDbCommand.CommandText = text;
						if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection))
						{
							oleDbCommand.CommandText = oleDbCommand.CommandText.Replace("[", "\"").Replace("]", "\"");
						}
						this.frd_Connection.Open();
						oleDbCommand.ExecuteNonQuery();
						this.frd_Connection.Close();
						return;
					}
					HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
					httpClient.Select = text;
					httpClient.FormData.Add("Action", 7.ToString());
					httpClient.GetData();
				}
			}
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0010721F File Offset: 0x0010541F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void FillSortKeyValue()
		{
			this.o0O.O_0.(null);
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00107228 File Offset: 0x00105428
		private void <<EMPTY_NAME>>(HttpClient A_0)
		{
			if (this.BaseTable.PrimaryKey.Length == 1 && o_O_o_oOoo__.OO_.O.(this.BaseTable.PrimaryKey[0].DataType))
			{
				string columnName = this.BaseTable.PrimaryKey[0].ColumnName;
				object obj = this._DataTable;
				DataRow[] array;
				lock (obj)
				{
					array = this._DataTable.Select("[_SortKey] Is Null");
				}
				if (array.Length > 0)
				{
					foreach (DataRow dataRow in array)
					{
						dataRow["_SortKey"] = RuntimeHelpers.GetObjectValue(dataRow[columnName]);
					}
					if (Operators.CompareString(this.UpdateServer, "", true) > 0 && A_0 == null)
					{
						A_0 = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
					}
					string text = this.o.o00O.();
					string text2 = string.Concat(new string[]
					{
						"UPDATE ",
						text,
						" Set [_SortKey]  = [",
						columnName,
						"] Where [_SortKey] Is Null"
					});
					if (A_0 == null)
					{
						if (this._Adapter != null && this._Adapter.UpdateCommand != null)
						{
							OleDbCommand oleDbCommand = new OleDbCommand("", this.frd_Connection);
							oleDbCommand.Transaction = this._Adapter.SelectCommand.Transaction;
							oleDbCommand.CommandText = text2;
							if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection))
							{
								oleDbCommand.CommandText = oleDbCommand.CommandText.Replace("[", "\"").Replace("]", "\"");
							}
							ConnectionState state = this.frd_Connection.State;
							if (state != ConnectionState.Open)
							{
								this.frd_Connection.Open();
							}
							oleDbCommand.ExecuteNonQuery();
							if (state != ConnectionState.Open)
							{
								this.frd_Connection.Close();
							}
						}
					}
					else
					{
						HttpClient httpClient = A_0.o0.o0_o.();
						httpClient.Select = text2;
						httpClient.FormData["Action"] = 7.ToString();
						httpClient.GetData();
					}
					this._DataTable.AcceptChanges();
				}
				if (this._DataTable.Rows.Count > 0)
				{
					this.OO00.oO_. = decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this._DataTable.Compute("Max([_SortKey])", ""))), 1m);
					return;
				}
				this.OO00.oO_. = 1m;
			}
		}

		/// <summary>
		/// 重新生成表头
		/// </summary>
		// Token: 0x0600247B RID: 9339 RVA: 0x001074A0 File Offset: 0x001056A0
		[oO0oooo("1275")]
		public void BuildHeader()
		{
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable == this)
					{
						table.BuildHeader();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x001074F4 File Offset: 0x001056F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Refresh()
		{
			this.o_oO0O_.O0. = null;
		}

		/// <summary>
		/// 设置加载数据的超时时限,单位为秒,默认30秒
		/// </summary>
		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x001074FD File Offset: 0x001056FD
		// (set) Token: 0x0600247E RID: 9342 RVA: 0x00107505 File Offset: 0x00105705
		public int FillLoadTimeOut
		{
			get
			{
				return this.O.oo.;
			}
			set
			{
				this.O.oo. = value;
				this._Adapter.SelectCommand.CommandTimeout = value;
			}
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x00107520 File Offset: 0x00105720
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable == this)
					{
						O_oOooO_O o_oOooO_O = table.foxGrid;
						int @fixed = o_oOooO_O.Cols.Fixed;
						int num = o_oOooO_O.Cols.Count - 1;
						for (int i = @fixed; i <= num; i++)
						{
							if (o_oOooO_O.Cols[i].Editor != null && o_oOooO_O.Cols[i].Editor is OooO00O)
							{
								OooO00O oooO00O = (OooO00O)o_oOooO_O.Cols[i].Editor;
								if (oooO00O.DropDownForm != null)
								{
									oooO00O.DropDownForm.Controls.Clear();
								}
							}
						}
						try
						{
							foreach (Col col in table.Cols)
							{
								col.CloseWindow();
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
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		/// <summary>
		/// 追载符合条件的行
		/// </summary>
		/// <param name="Filter">追载条件</param>
		/// <param name="SaveData">是否先保存数据</param>
		// Token: 0x06002480 RID: 9344 RVA: 0x0010764C File Offset: 0x0010584C
		[oO0oooo("2276")]
		public List<DataRow> AppendLoad(string Filter, bool SaveData = true)
		{
			return this.o0O.O_0.(Filter, SaveData, null);
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00107658 File Offset: 0x00105858
		internal List<DataRow> <<EMPTY_NAME>>(string A_0, bool A_1 = true, OleDbDataAdapter A_2 = null)
		{
			object oo_O.o. = Main.OO_O.o.;
			lock (oo_O.o.)
			{
				while (O_O0OO.O_O00OOooo.O_.)
				{
					Thread.Sleep(1);
				}
				O_O0OO.O_O00OOooo.O_. = true;
				this.o00o.00oO___0. = true;
			}
			List<DataRow> result;
			try
			{
				string text;
				if (Operators.CompareString(this.DataServer, "", true) == 0)
				{
					if (A_2 == null)
					{
						A_2 = new OleDbDataAdapter(this._Adapter.SelectCommand.CommandText, this._Adapter.SelectCommand.Connection);
					}
					if (Operators.CompareString(A_0.Trim(), "", true) == 0)
					{
						MessageBox.Show("AppendLoad的条件不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return new List<DataRow>();
					}
					if (!this.frd_IsInnerTable && !this.frd_IsOuterTable)
					{
						MessageBox.Show("查询表或临时表不能执行AppendLoad!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return new List<DataRow>();
					}
					text = this._Adapter.SelectCommand.CommandText;
				}
				else
				{
					text = this.HttpSelect;
				}
				string[] array = text.Split(new char[]
				{
					' ',
					'\n',
					'\r',
					'\t'
				}, StringSplitOptions.RemoveEmptyEntries);
				text = "";
				foreach (string text2 in array)
				{
					if (Operators.CompareString(text2.ToLower(), "from", true) == 0)
					{
						break;
					}
					text = text + text2 + " ";
				}
				DataServerTypeEnum dataServerTypeEnum = DataServerTypeEnum.Access;
				if (Operators.CompareString(this.DataServer, "", true) > 0)
				{
					dataServerTypeEnum = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].OO.OoO0.;
				}
				else if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection))
				{
					dataServerTypeEnum = DataServerTypeEnum.Oracle;
				}
				else if (o_O_o_oOoo__.OOOO_OO._oo.(this.frd_Connection))
				{
					dataServerTypeEnum = DataServerTypeEnum.SqlServer;
				}
				string text3;
				if (Operators.CompareString(this.o._OOO0oOo0__., "", true) > 0)
				{
					if (dataServerTypeEnum == DataServerTypeEnum.Oracle)
					{
						text3 = this.o._OOO0oOo0__.;
					}
					else
					{
						text3 = "[" + this.o._OOO0oOo0__..Trim(new char[]
						{
							'[',
							']'
						}) + "]";
					}
				}
				else if (Operators.CompareString(this.DataServer, "", true) == 0)
				{
					text3 = Oo00.o.Oo0oO.(this.frd_SelectCommandString);
				}
				else
				{
					text3 = Oo00.o.Oo0oO.(this.HttpSelect);
				}
				A_0 = Oo00.o0_o._O_.(this.o0__.Oo0o__O., A_0, false);
				if (Operators.CompareString(this.DataServer, "", true) == 0)
				{
					if (A_2 == null)
					{
						new OleDbDataAdapter(string.Concat(new string[]
						{
							text,
							" From ",
							text3,
							" Where ",
							A_0
						}), this.frd_Connection);
					}
					else
					{
						A_2.SelectCommand.CommandText = string.Concat(new string[]
						{
							text,
							" From ",
							text3,
							" Where ",
							A_0
						});
					}
					result = this.o0O.O_0.(A_1, A_2);
				}
				else
				{
					result = this.o0O.O_0.(A_1, string.Concat(new string[]
					{
						text,
						" From ",
						text3,
						" Where ",
						A_0
					}));
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				result = new List<DataRow>();
			}
			finally
			{
				O_O0OO.O_O00OOooo.O_. = false;
				this.o00o.00oO___0. = false;
			}
			return result;
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x001079D4 File Offset: 0x00105BD4
		private List<DataRow> <<EMPTY_NAME>>(bool A_0, string A_1)
		{
			List<DataRow> list = new List<DataRow>();
			if (A_0 && Operators.CompareString(this.UpdateServer, "", true) > 0)
			{
				if (!this.o.o_O.())
				{
					return list;
				}
				if (!this.O0o0.O_0_.())
				{
					return list;
				}
			}
			bool a_ = OO_00oOO.SystemReady;
			try
			{
				int count = this.BaseTable.Rows.Count;
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
				httpClient.FormData.Add("IgnoreSchema", "True");
				httpClient.Select = A_1;
				httpClient.FormData["Action"] = 2.ToString();
				DataTable baseDataTable = httpClient.GetBaseDataTable();
				this.StopRedraw();
				OO_00oOO.SystemReady = false;
				this.O.0_0O. = false;
				try
				{
					foreach (object obj in baseDataTable.Rows)
					{
						DataRow row = (DataRow)obj;
						this.BaseTable.ImportRow(row);
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
				int num = count;
				int num2 = this.BaseTable.Rows.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					list.Add(new DataRow(this.BaseTable.Rows[i]));
					this.BaseTable.Rows[i].AcceptChanges();
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			finally
			{
				this.o_oO0O_.O0. = null;
				OO_00oOO.SystemReady = a_;
				this.ResumeRedraw();
			}
			if (list.Count > 0)
			{
				if (this._DataTable.Columns.Contains("_SortKey"))
				{
					this.FillSortKeyValue();
				}
				this.O.0_0O. = true;
			}
			return list;
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x00107BEC File Offset: 0x00105DEC
		private List<DataRow> <<EMPTY_NAME>>(bool A_0, OleDbDataAdapter A_1)
		{
			List<DataRow> list = new List<DataRow>();
			List<DataRow> result;
			if (A_0 && !this.oO.o_0.(false, true))
			{
				result = list;
			}
			else
			{
				bool a_ = OO_00oOO.SystemReady;
				try
				{
					DataTable dataTable = new DataTable();
					int count = this.BaseTable.Rows.Count;
					A_1.Fill(dataTable);
					this.StopRedraw();
					OO_00oOO.SystemReady = false;
					this.O.0_0O. = false;
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow row = (DataRow)obj;
							this.BaseTable.ImportRow(row);
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
					int num = count;
					int num2 = this.BaseTable.Rows.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						list.Add(new DataRow(this.BaseTable.Rows[i]));
						this.BaseTable.Rows[i].AcceptChanges();
					}
				}
				catch (Exception a_2)
				{
					ooO.oOo0Oo.o.(a_2, "");
				}
				finally
				{
					this.o_oO0O_.O0. = null;
					OO_00oOO.SystemReady = a_;
					this.ResumeRedraw();
				}
				if (list.Count > 0)
				{
					if (this._DataTable.Columns.Contains("_SortKey"))
					{
						this.FillSortKeyValue();
					}
					this.O.0_0O. = true;
				}
				result = list;
			}
			return result;
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x00107D7C File Offset: 0x00105F7C
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x00107D84 File Offset: 0x00105F84
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Developer
		{
			get
			{
				return this.O.___oo_0OoO.;
			}
			set
			{
				this.O.___oo_0OoO. = value;
			}
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x00107D8D File Offset: 0x00105F8D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Dispose()
		{
			this._DataTable = null;
			this._Adapter = null;
			this.o.O0O_0__OOo_. = null;
			this.o_oO0O_.O0. = null;
			this.o0__.Oo0o__O. = null;
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x00107DB4 File Offset: 0x00105FB4
		internal bool <<EMPTY_NAME>>()
		{
			bool result;
			if (OO_00oOO.User.Type == UserTypeEnum.Developer)
			{
				result = true;
			}
			else if (Operators.CompareString(this.Developer, "", true) > 0 && Operators.CompareString(this.Developer, OO_00oOO.User.Name, true) != 0)
			{
				MessageBox.Show("此表的责任设计者为\"" + this.Developer + "\", 请不要越权设计!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x00107E28 File Offset: 0x00106028
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x00107EAF File Offset: 0x001060AF
		internal bool CannBackEndFilter
		{
			get
			{
				return Operators.CompareString(this.LoadTop, "", true) > 0 && Versioned.IsNumeric(this.LoadTop) && (this.BaseTable.PrimaryKey.Length == 1 || Operators.CompareString(this.LoadOver, "", true) > 0 || this.BaseTable.Columns.Contains("_SortKey") || this.BaseTable.Columns.Contains("_Identify"));
			}
			set
			{
			}
		}

		/// <summary>
		/// 开启后台筛选
		/// </summary>
		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x00107EB4 File Offset: 0x001060B4
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x00107ED5 File Offset: 0x001060D5
		[oO0oooo("2892")]
		public bool AllowBackEndFilter
		{
			get
			{
				return this.CannBackEndFilter && this.o0OOOo_.0_o_0o.;
			}
			set
			{
				this.o0OOOo_.0_o_0o. = value;
			}
		}

		/// <summary>
		/// 是否已经开启后台筛选
		/// </summary>
		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x00107EDE File Offset: 0x001060DE
		[oO0oooo("2892")]
		public bool InBackEndFilterMode
		{
			get
			{
				return Operators.CompareString(this.OOOOO._., this.LoadFilter, true) != 0;
			}
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x00107EF8 File Offset: 0x001060F8
		internal void <<EMPTY_NAME>>()
		{
			if (this.InBackEndFilterMode)
			{
				this.o00o.00oO___0..Clear();
				this.LoadFilter = this.OOOOO._.;
				this.LoadPage = 0;
				this.o0.o.(true, null);
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this && table.O.OoOo_. != null && table.O.OoOo_..FindForm() != null)
						{
							table.O.OoOo_..oO.Oo0__O_.();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x00107F94 File Offset: 0x00106194
		internal void <<EMPTY_NAME>>()
		{
			checked
			{
				if (Operators.CompareString(this.LoadFilter, this.OOOOO._., true) == 0)
				{
					if (this.o00o.00oO___0..Count <= 0)
					{
						goto IL_20C;
					}
					string[] array = this.o00o.00oO___0..ToArray();
					this.o00o.00oO___0..Clear();
					try
					{
						OO_00oOO.LockBaseMainForm();
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							string[] array3 = array2[i].Split(new char[]
							{
								'\v'
							});
							string left = array3[0];
							if (Operators.CompareString(left, "RelationFilter3", true) == 0)
							{
								if (OO_00oOO.DataTables.Contains(array3[2]))
								{
									string a_ = array3[1];
									DataTable a_2 = OO_00oOO.DataTables[array3[2]];
									string a_3 = array3[3];
									bool a_4 = Conversions.ToBoolean(array3[4]);
									OO_00oOO.Tables[this.Name].o0O0oo.o.(a_, a_2, a_3, a_4);
								}
							}
							else if (Operators.CompareString(left, "ShowBackSameValues", true) == 0)
							{
								string a_5 = array3[1];
								int a_6 = Conversions.ToInteger(array3[2]);
								OO_00oOO.Tables[this.Name].o_0_O__o0O.oo.(a_5, a_6);
							}
							else if (Operators.CompareString(left, "BackSameValuesFilter", true) == 0)
							{
								string a_7 = array3[1];
								string a_8 = array3[2];
								OO_00oOO.Tables[this.Name].O____o.0.(a_7, a_8);
							}
							else if (Operators.CompareString(left, "FilterDateBetween", true) == 0)
							{
								Table a_9 = OO_00oOO.Tables[array3[1]];
								string a_10 = array3[2];
								DateTime a_11 = Conversions.ToDate(array3[3]);
								DateTime a_12 = Conversions.ToDate(array3[4]);
								bool a_13 = Conversions.ToBoolean(array3[5]);
								Filter.O0O0o.Oo0OO_oO.(a_9, a_10, a_11, a_12, a_13);
							}
							else if (Operators.CompareString(left, "FilterByExpression", true) == 0)
							{
								Table a_14 = OO_00oOO.Tables[array3[1]];
								string a_15 = array3[2];
								bool a_16 = Conversions.ToBoolean(array3[3]);
								Filter.O0O0o.Oo0OO_oO.(a_14, a_15, a_16);
							}
						}
						goto IL_20C;
					}
					catch (Exception a_17)
					{
						ooO.oOo0Oo.o.(a_17, "");
						goto IL_20C;
					}
					finally
					{
						OO_00oOO.UnlockBaseMainForm();
					}
				}
				this.LoadFilter3 = this.OOOOO._.;
				this.LoadPage = 0;
				this.o0.o.(true, null);
				IL_20C:
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this && table.O.OoOo_. != null && table.O.OoOo_..FindForm() != null)
						{
							table.O.OoOo_..oO.Oo0__O_.();
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 加载关联子表数据
		/// </summary>
		/// <param name="ChildName">关联子表名称</param>
		// Token: 0x0600248F RID: 9359 RVA: 0x00108258 File Offset: 0x00106458
		[oO0oooo("2894")]
		public void LoadChildren(string ChildName)
		{
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (dataRelation.ParentTable == this.BaseTable && Operators.CompareString(dataRelation.ChildTable.TableName, ChildName, true) == 0)
					{
						DataTable dataTable = OO_00oOO.DataTables[ChildName];
						if ((this.frd_Connection != null && dataTable.frd_Connection == this.frd_Connection) || (Operators.CompareString(this.DataServer, "", true) > 0 && Operators.CompareString(this.DataServer, OO_00oOO.DataTables[dataRelation.ChildTable.TableName].DataServer, true) == 0))
						{
							if (dataRelation.ParentColumns.Length == 1)
							{
								string text = dataRelation.ChildColumns[0].ColumnName;
								string text2 = dataRelation.ParentColumns[0].ColumnName;
								text = Oo00.OoOo_oo_.o_o.(text, OO_00oOO.DataTables[dataRelation.ChildTable.TableName]);
								if (this.DataServerType == DataServerTypeEnum.Oracle)
								{
									text2 = "\"" + text2 + "\"";
								}
								else
								{
									text2 = "[" + text2 + "]";
								}
								string a_;
								if (Operators.CompareString(this.DataServer, "", true) > 0)
								{
									if (Operators.CompareString(this.O._O0__., "", true) > 0)
									{
										a_ = string.Concat(new string[]
										{
											text,
											" in (Select ",
											text2,
											" From  (",
											Oo00.O0_._o0__.(this.O._O0__.),
											") FoxTempaX)"
										});
									}
									else
									{
										a_ = string.Concat(new string[]
										{
											text,
											" in (Select ",
											text2,
											" From  (",
											Oo00.O0_._o0__.(this.HttpSelect),
											") FoxTempaX)"
										});
									}
								}
								else
								{
									a_ = string.Concat(new string[]
									{
										text,
										" in (Select ",
										text2,
										" From  (",
										Oo00.O0_._o0__.(this._Adapter.SelectCommand.CommandText),
										") FoxTempaX)"
									});
								}
								OO_00oOO.DataTables[dataRelation.ChildTable.TableName].LoadFilter = a_;
								OO_00oOO.DataTables[dataRelation.ChildTable.TableName].o0.o.(true, null);
							}
							else
							{
								MessageBox.Show("多列关联的时候，不能使用LoadChildren方法同步加载子表数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							}
						}
						else
						{
							MessageBox.Show("父表和子表必须来自同一个数据源，才能同步加载！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00108524 File Offset: 0x00106724
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void LoadChildren(params object[] args)
		{
			if (args.Length == 1)
			{
				this.LoadChildren(Conversions.ToString(args[0]));
				return;
			}
			if (args.Length == 3)
			{
				this.LoadChildren(Conversions.ToString(args[0]), Conversions.ToString(args[1]), Conversions.ToString(args[2]));
			}
		}

		/// <summary>
		/// 加载关联子表数据
		/// </summary>
		/// <param name="ChildName">子表名称</param>
		/// <param name="ParentCol">父表关联列</param>
		/// <param name="ChildCol">子表关联列</param>
		// Token: 0x06002491 RID: 9361 RVA: 0x00108560 File Offset: 0x00106760
		[oO0oooo("2894")]
		public void LoadChildren(string ChildName, string ParentCol, string ChildCol)
		{
			DataTable dataTable = OO_00oOO.DataTables[ChildName];
			if ((this.frd_Connection != null && dataTable.frd_Connection == this.frd_Connection) || (Operators.CompareString(this.DataServer, "", true) > 0 && Operators.CompareString(this.DataServer, dataTable.DataServer, true) == 0))
			{
				ChildCol = Oo00.OoOo_oo_.o_o.(ChildCol, OO_00oOO.DataTables[ChildName]);
				if (this.DataServerType == DataServerTypeEnum.Oracle)
				{
					ParentCol = "\"" + ParentCol + "\"";
				}
				else
				{
					ParentCol = "[" + ParentCol + "]";
				}
				string a_;
				if (Operators.CompareString(this.DataServer, "", true) > 0)
				{
					if (Operators.CompareString(this.O._O0__., "", true) > 0)
					{
						a_ = string.Concat(new string[]
						{
							ChildCol,
							" in (Select DISTINCT ",
							ParentCol,
							" From  (",
							Oo00.O0_._o0__.(this.O._O0__.),
							") FoxTempaX)"
						});
					}
					else
					{
						a_ = string.Concat(new string[]
						{
							ChildCol,
							" in (Select DISTINCT ",
							ParentCol,
							" From  (",
							Oo00.O0_._o0__.(this.HttpSelect),
							") FoxTempaX)"
						});
					}
				}
				else
				{
					a_ = string.Concat(new string[]
					{
						ChildCol,
						" in (Select DISTINCT ",
						ParentCol,
						" From  (",
						Oo00.O0_._o0__.(this._Adapter.SelectCommand.CommandText),
						") FoxTempaX)"
					});
				}
				OO_00oOO.DataTables[ChildName].LoadFilter = a_;
				OO_00oOO.DataTables[ChildName].o0.o.(true, null);
			}
		}

		/// <summary>
		/// 从后台删除符合条件的行
		/// </summary>
		/// <param name="Filter">条件表达式</param>
		// Token: 0x06002492 RID: 9362 RVA: 0x0010870C File Offset: 0x0010690C
		[oO0oooo("2899")]
		public int SQLDeleteFor(string Filter)
		{
			int result;
			if (!this.frd_IsInnerTable && !this.frd_IsOuterTable && Operators.CompareString(this.UpdateServer, "", true) <= 0)
			{
				MessageBox.Show("查询表或临时表不能使用SQLReplaceFor更新后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = 0;
			}
			else
			{
				bool flag;
				if (Operators.CompareString(this.DataServer, "", true) > 0)
				{
					flag = (this.DataServerType == DataServerTypeEnum.Oracle);
				}
				else
				{
					flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection);
				}
				string text;
				if (flag)
				{
					if (this.o._OOO0oOo0__..IndexOf("\"") < 0)
					{
						text = "Delete From \"" + this.o._OOO0oOo0__. + "\"";
					}
					else
					{
						text = "Delete From " + this.o._OOO0oOo0__.;
					}
				}
				else
				{
					text = "Delete From [" + this.o._OOO0oOo0__. + "]";
				}
				if (Operators.CompareString(Filter, "", true) > 0)
				{
					text = text + " where " + Oo00.o0_o._O_.(this.o0__.Oo0o__O., Filter, false);
				}
				if (Operators.CompareString(this.DataServer, "", true) == 0)
				{
					OleDbCommand oleDbCommand = new OleDbCommand(text, this.o0__.Oo0o__O.);
					oleDbCommand.Transaction = this._Adapter.SelectCommand.Transaction;
					ConnectionState state = this.o0__.Oo0o__O..State;
					if (state != ConnectionState.Open)
					{
						this.o0__.Oo0o__O..Open();
					}
					try
					{
						return oleDbCommand.ExecuteNonQuery();
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
					finally
					{
						if (state != ConnectionState.Open)
						{
							this.o0__.Oo0o__O..Close();
						}
					}
					result = 0;
				}
				else
				{
					Oo00.o.Oo0oO.(this.HttpSelect);
					HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
					httpClient.Select = text;
					httpClient.FormData.Add("Action", 7.ToString());
					object data = httpClient.GetData();
					if (data != null && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(data)))
					{
						result = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(data)));
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00108924 File Offset: 0x00106B24
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object SQLCompute(params object[] args)
		{
			int num = args.Length;
			object result;
			if (num != 1)
			{
				if (num == 2)
				{
					result = this.SQLCompute(Conversions.ToString(args[0]), Conversions.ToString(args[1]));
				}
			}
			else
			{
				result = this.SQLCompute(Conversions.ToString(args[0]));
			}
			return result;
		}

		/// <summary>
		/// 统计后台数据
		/// </summary>
		/// <param name="Expression">聚合函数表达式</param>
		// Token: 0x06002494 RID: 9364 RVA: 0x00108968 File Offset: 0x00106B68
		[oO0oooo("2897")]
		public object SQLCompute(string Expression)
		{
			return this.SQLCompute(Expression, "");
		}

		/// <summary>
		/// 统计后台数据
		/// </summary>
		/// <param name="Expression">聚合函数表达式</param>
		/// <param name="Filter">统计条件</param>
		// Token: 0x06002495 RID: 9365 RVA: 0x00108978 File Offset: 0x00106B78
		[oO0oooo("2897")]
		public object SQLCompute(string Expression, string Filter)
		{
			object result;
			if (this.o0__.Oo0o__O. == null && Operators.CompareString(this.DataServer, "", true) == 0)
			{
				MessageBox.Show("临时表不能使用SQLCompute统计后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = null;
			}
			else
			{
				string text = "Select " + Expression;
				if (Operators.CompareString(this.DataServer, "", true) == 0)
				{
					text = text + " From " + Oo00.O__0oO_oo.Ooo.(this._Adapter.SelectCommand.CommandText);
					if (Operators.CompareString(Filter, "", true) > 0)
					{
						text = text + " Where " + Oo00.o0_o._O_.(this.o0__.Oo0o__O., Filter, false);
					}
					OleDbCommand oleDbCommand = new OleDbCommand(text, this.o0__.Oo0o__O.);
					oleDbCommand.Transaction = this._Adapter.SelectCommand.Transaction;
					ConnectionState state = this.o0__.Oo0o__O..State;
					if (state != ConnectionState.Open)
					{
						this.o0__.Oo0o__O..Open();
					}
					try
					{
						object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
						if (objectValue == DBNull.Value)
						{
							return null;
						}
						return objectValue;
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
					finally
					{
						if (state != ConnectionState.Open)
						{
							this.o0__.Oo0o__O..Close();
						}
					}
					result = null;
				}
				else
				{
					text = text + " From " + Oo00.oo_0__0.o.(this.HttpSelect);
					if (Operators.CompareString(Filter, "", true) > 0)
					{
						text = text + " Where " + Oo00.o0_o._O_.(this.DataServerType, Filter, false);
					}
					HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
					httpClient.FormData.Add("Action", 6.ToString());
					httpClient.Select = text;
					object data = httpClient.GetData();
					if (data != null && (string.IsNullOrEmpty(data.ToString()) || string.IsNullOrWhiteSpace(data.ToString())))
					{
						result = null;
					}
					else
					{
						result = data;
					}
				}
			}
			return result;
		}

		/// <summary>
		/// 批量更新后台数据
		/// </summary>
		/// <param name="ColumnName"></param>
		/// <param name="Value">新值</param>
		/// <param name="Filter">更新条件</param>
		/// <param name="IsExpression">新值(Value参数)是否是一个表达式，默认为False</param>
		// Token: 0x06002496 RID: 9366 RVA: 0x00108B7C File Offset: 0x00106D7C
		[oO0oooo("2898")]
		public int SQLReplaceFor(string ColumnName, object Value, string Filter = "", bool IsExpression = false)
		{
			int result;
			if (!this.frd_IsInnerTable && !this.frd_IsOuterTable && Operators.CompareString(this.UpdateServer, "", true) <= 0)
			{
				MessageBox.Show("查询表或临时表不能使用SQLReplaceFor更新后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = 0;
			}
			else
			{
				string text = "";
				bool flag;
				if (Operators.CompareString(this.DataServer, "", true) > 0)
				{
					flag = (this.DataServerType == DataServerTypeEnum.Oracle);
				}
				else
				{
					flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.frd_Connection);
				}
				bool flag2;
				if (Operators.CompareString(this.DataServer, "", true) > 0)
				{
					flag2 = (this.DataServerType == DataServerTypeEnum.SqlServer);
				}
				else
				{
					flag2 = o_O_o_oOoo__.OOOO_OO._oo.(this.frd_Connection);
				}
				if (!IsExpression)
				{
					if (this.DataCols.Contains(ColumnName))
					{
						if (this.DataCols[ColumnName].IsString)
						{
							text = "'";
						}
						else if (this.DataCols[ColumnName].IsDate)
						{
							if (flag || flag2)
							{
								text = "'";
							}
							else
							{
								text = "#";
							}
						}
					}
					else if (Value != null)
					{
						if (Value is string)
						{
							text = "'";
						}
						else if (Value is DateTime)
						{
							if (flag || flag2)
							{
								text = "'";
							}
							else
							{
								text = "#";
							}
						}
					}
				}
				ColumnName = ColumnName.Trim(new char[]
				{
					'['
				}).Trim(new char[]
				{
					']'
				});
				if (flag)
				{
					ColumnName = "\"" + ColumnName + "\"";
				}
				else
				{
					ColumnName = "[" + ColumnName + "]";
				}
				string text2;
				if (flag)
				{
					if (this.o._OOO0oOo0__..IndexOf("\"") < 0)
					{
						text2 = string.Concat(new string[]
						{
							"update \"",
							this.o._OOO0oOo0__.,
							"\" Set ",
							ColumnName,
							" = "
						});
					}
					else
					{
						text2 = string.Concat(new string[]
						{
							"update ",
							this.o._OOO0oOo0__.,
							" Set ",
							ColumnName,
							" = "
						});
					}
				}
				else
				{
					text2 = string.Concat(new string[]
					{
						"update [",
						this.o._OOO0oOo0__.,
						"] Set ",
						ColumnName,
						" = "
					});
				}
				if (Value == null)
				{
					text2 += "Null";
				}
				else
				{
					text2 = text2 + text + Value.ToString() + text;
				}
				if (Operators.CompareString(Filter, "", true) > 0)
				{
					text2 = text2 + " Where " + Oo00.o0_o._O_.(this.o0__.Oo0o__O., Filter, false);
				}
				if (Operators.CompareString(this.UpdateServer, "", true) == 0)
				{
					OleDbCommand oleDbCommand = new OleDbCommand(text2, this.o0__.Oo0o__O.);
					oleDbCommand.Transaction = this._Adapter.SelectCommand.Transaction;
					ConnectionState state = this.o0__.Oo0o__O..State;
					if (state != ConnectionState.Open)
					{
						this.o0__.Oo0o__O..Open();
					}
					try
					{
						return oleDbCommand.ExecuteNonQuery();
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
					finally
					{
						if (state != ConnectionState.Open)
						{
							this.o0__.Oo0o__O..Close();
						}
					}
					result = 0;
				}
				else
				{
					Oo00.o.Oo0oO.(this.HttpSelect);
					HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
					httpClient.Select = text2;
					httpClient.FormData["Action"] = 7.ToString();
					object data = httpClient.GetData();
					if (data != null && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(data)))
					{
						result = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(data)));
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		/// <summary>
		/// 从后台数据表的指定列中提取不重复值的值，并以集合形式返回
		/// </summary>
		/// <param name="ColumnName">列名</param>
		/// <param name="Filter">条件表达式</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x06002497 RID: 9367 RVA: 0x00108F18 File Offset: 0x00107118
		[oO0oooo("2909")]
		public object SQLGetValues(string ColumnName, string Filter = "", string Sort = "")
		{
			int num;
			object result;
			int num8;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				List<string> list = new List<string>();
				IL_10:
				num2 = 3;
				List<string[]> list2 = new List<string[]>();
				IL_19:
				num2 = 4;
				string text = "";
				IL_22:
				num2 = 5;
				string text2 = "";
				IL_2B:
				num2 = 6;
				string[] array = ColumnName.Split(new char[]
				{
					'|'
				});
				IL_40:
				num2 = 7;
				foreach (string text3 in array)
				{
					IL_52:
					num2 = 8;
					text3 = Oo00.OoOo_oo_.o_o.(text3, this);
					IL_5E:
					num2 = 9;
					if (Operators.CompareString(text, "", true) > 0)
					{
						IL_71:
						num2 = 10;
						text += ",";
					}
					IL_82:
					num2 = 11;
					text += text3;
					IL_90:
					num2 = 12;
				}
				IL_A1:
				num2 = 13;
				if (!text.StartsWith("(") || !text.EndsWith(")") || Operators.CompareString(Sort, "", true) <= 0)
				{
					goto IL_E4;
				}
				IL_CF:
				num2 = 14;
				text2 = " a_" + OoOo0O.OO_o.0o_O.(7);
				IL_E4:
				num2 = 15;
				if (this.o0__.Oo0o__O. != null || Operators.CompareString(this.DataServer, "", true) != 0)
				{
					goto IL_123;
				}
				IL_102:
				num2 = 16;
				MessageBox.Show("临时表不能使用SQLSelect查询后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_118:
				num2 = 17;
				result = list;
				goto IL_6F1;
				IL_123:
				num2 = 18;
				if (Operators.CompareString(Filter, "", true) <= 0)
				{
					goto IL_172;
				}
				IL_135:
				num2 = 19;
				if (Operators.CompareString(this.DataServer, "", true) <= 0)
				{
					goto IL_160;
				}
				IL_14C:
				num2 = 20;
				Filter = Oo00.o0_o._O_.(this.DataServerType, Filter, false);
				goto IL_172;
				IL_160:
				num2 = 22;
				Filter = Oo00.o0_o._O_.(this.o0__.Oo0o__O., Filter, false);
				IL_172:
				num2 = 23;
				if (Operators.CompareString(this.DataServer, "", true) <= 0)
				{
					goto IL_196;
				}
				IL_189:
				num2 = 24;
				string a_ = this.HttpSelect;
				goto IL_1AB;
				IL_196:
				num2 = 26;
				a_ = this._Adapter.SelectCommand.CommandText;
				IL_1AB:
				num2 = 27;
				if (Operators.CompareString(Sort, "", true) != 0)
				{
					goto IL_211;
				}
				IL_1BC:
				num2 = 28;
				string text4 = "Select Distinct " + text + " From " + Oo00.oo_0__0.o.(a_);
				IL_1D9:
				num2 = 29;
				if (Operators.CompareString(Filter, "", true) <= 0)
				{
					goto IL_4E5;
				}
				IL_1EE:
				num2 = 30;
				text4 = text4 + " Where " + Oo00.o0_o._O_.(this.o0__.Oo0o__O., Filter, false);
				goto IL_4E5;
				IL_211:
				num2 = 32;
				string[] array3 = Sort.Split(new char[]
				{
					','
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_228:
				num2 = 33;
				string[] array4 = new string[array3.Length - 1 + 1];
				IL_23A:
				num2 = 34;
				Sort = "";
				IL_244:
				num2 = 35;
				int num3 = array3.Length - 1;
				for (int j = 0; j <= num3; j++)
				{
					IL_257:
					num2 = 36;
					string text5 = Oo00.OoOo_oo_.o_o.(array3[j].Trim().Split(new char[]
					{
						' '
					})[0], this);
					IL_27E:
					num2 = 37;
					if (array3[j].EndsWith(" Desc", StringComparison.CurrentCultureIgnoreCase))
					{
						IL_293:
						num2 = 38;
						array4[j] = string.Concat(new string[]
						{
							"Max(",
							text5,
							") As [_temsortcol",
							Conversions.ToString(j),
							"]"
						});
						IL_2CD:
						num2 = 39;
						array3[j] = "d200ad3c.[_temsortcol" + Conversions.ToString(j) + "] Desc";
					}
					else
					{
						IL_2ED:
						num2 = 41;
						array4[j] = string.Concat(new string[]
						{
							"Min(",
							text5,
							") As [_temsortcol",
							Conversions.ToString(j),
							"]"
						});
						IL_327:
						num2 = 42;
						array3[j] = "d200ad3c.[_temsortcol" + Conversions.ToString(j) + "]";
					}
					IL_345:
					num2 = 43;
				}
				IL_357:
				num2 = 44;
				if (Operators.CompareString(text2, "", true) <= 0)
				{
					goto IL_3B9;
				}
				IL_36A:
				num2 = 45;
				text4 = "Select " + text2 + " From (";
				IL_380:
				num2 = 46;
				text4 = string.Concat(new string[]
				{
					text4,
					"Select  Top 100 PERCENT ",
					text,
					" As ",
					text2,
					","
				});
				goto IL_3E7;
				IL_3B9:
				num2 = 48;
				text4 = "Select " + text + " From (";
				IL_3CF:
				num2 = 49;
				text4 = text4 + "Select  Top 100 PERCENT " + text + ",";
				IL_3E7:
				num2 = 50;
				int num4 = array3.Length - 1;
				for (int k = 0; k <= num4; k++)
				{
					IL_3F7:
					num2 = 51;
					if (k > 0)
					{
						IL_3FF:
						num2 = 52;
						text4 += ",";
					}
					IL_410:
					num2 = 53;
					text4 += array4[k];
					IL_421:
					num2 = 54;
				}
				IL_430:
				num2 = 55;
				text4 = text4 + " From " + Oo00.oo_0__0.o.(a_);
				IL_448:
				num2 = 56;
				if (Operators.CompareString(Filter, "", true) <= 0)
				{
					goto IL_478;
				}
				IL_45A:
				num2 = 57;
				text4 = text4 + " Where " + Oo00.o0_o._O_.(this.o0__.Oo0o__O., Filter, false);
				IL_478:
				num2 = 58;
				text4 = text4 + " Group By " + text;
				IL_48B:
				num2 = 59;
				text4 += ") d200ad3c Order By ";
				IL_49C:
				num2 = 60;
				int num5 = array3.Length - 1;
				for (int l = 0; l <= num5; l++)
				{
					IL_4AC:
					num2 = 61;
					if (l > 0)
					{
						IL_4B4:
						num2 = 62;
						text4 += ",";
					}
					IL_4C5:
					num2 = 63;
					text4 += array3[l];
					IL_4D6:
					num2 = 64;
				}
				IL_4E5:
				num2 = 65;
				DataTable dataTable = new DataTable();
				IL_4EF:
				num2 = 66;
				if (Operators.CompareString(this.DataServer, "", true) != 0)
				{
					goto IL_54C;
				}
				IL_505:
				num2 = 67;
				OleDbCommand oleDbCommand = new OleDbCommand(text4, this.o0__.Oo0o__O.);
				IL_517:
				num2 = 68;
				oleDbCommand.Transaction = this._Adapter.SelectCommand.Transaction;
				IL_531:
				num2 = 69;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
				IL_53D:
				num2 = 70;
				oleDbDataAdapter.Fill(dataTable);
				goto IL_5B5;
				IL_54C:
				num2 = 72;
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
				IL_566:
				num2 = 73;
				httpClient.FormData.Add("IgnoreSchema", "True");
				IL_57F:
				num2 = 74;
				httpClient.Select = text4;
				IL_58B:
				num2 = 75;
				Dictionary<string, string> dictionary = httpClient.FormData;
				string key = "Action";
				int num6 = 2;
				dictionary[key] = num6.ToString();
				IL_5A9:
				num2 = 76;
				dataTable = httpClient.GetBaseDataTable();
				IL_5B5:
				num2 = 77;
				if (array.Length != 1)
				{
					goto IL_650;
				}
				IL_5C2:
				num2 = 78;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_5E3:
					num2 = 79;
					if (!dataRow.IsNull(0))
					{
						IL_5F0:
						num2 = 80;
						list.Add(dataRow[0].ToString());
					}
					IL_607:
					num2 = 81;
				}
				IL_613:
				num2 = 82;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_62B:
				num2 = 83;
				if (!ooO.o.O_0000_O.())
				{
					goto IL_645;
				}
				IL_635:
				num2 = 84;
				result = list.ToArray();
				goto IL_6F1;
				IL_645:
				num2 = 86;
				result = list;
				goto IL_6F1;
				IL_650:
				num2 = 88;
				IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					DataRow dataRow2 = (DataRow)obj2;
					IL_671:
					num2 = 89;
					string[] array5 = new string[array.Length - 1 + 1];
					IL_683:
					num2 = 90;
					num6 = array.Length - 1;
					for (int m = 0; m <= num6; m++)
					{
						IL_693:
						num2 = 91;
						array5[m] = dataRow2[array[m]].ToString();
						IL_6AC:
						num2 = 92;
					}
					IL_6BB:
					num2 = 93;
					list2.Add(array5);
					IL_6C7:
					num2 = 94;
				}
				IL_6D3:
				num2 = 95;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_6EB:
				num2 = 96;
				result = list2;
				IL_6F1:
				goto IL_8C7;
				IL_6F6:
				int num7 = num8 + 1;
				num8 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7);
				IL_888:
				goto IL_8BC;
				IL_88A:
				num8 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_89A:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num8 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_88A;
			}
			IL_8BC:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_8C7:
			if (num8 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 从后台表的指定列中提取不重复的值，用符号"|"将这些值连接成一个字符串，并返回这个字符串。
		/// </summary>
		/// <param name="ColumnName">列名</param>
		/// <param name="Filter">条件表达式</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x06002498 RID: 9368 RVA: 0x00109814 File Offset: 0x00107A14
		[oO0oooo("2910")]
		public string SQLGetComboListString(string ColumnName, string Filter = "", string Sort = "")
		{
			List<string> list = (List<string>)this.SQLGetValues(ColumnName, Filter, Sort);
			string result;
			if (list.Count == 0)
			{
				result = "";
			}
			else
			{
				string[] value = list.ToArray();
				result = string.Join("|", value);
			}
			return result;
		}

		/// <summary>
		/// 直接在后台表增加一行
		/// </summary>
		// Token: 0x06002499 RID: 9369 RVA: 0x00109854 File Offset: 0x00107A54
		[oO0oooo("3228")]
		public DataRow SQLAddNew()
		{
			if (this.OO._0oo000_00. == null)
			{
				this.OO._0oo000_00. = this.o0O.O_0.();
				this.OO._0oo000_00..ExtendedProperties.Add("DataAdapter", this._Adapter);
				this.OO._0oo000_00..ExtendedProperties.Add("Mirror", true);
				if (Operators.CompareString(this.UpdateServer, "", true) > 0)
				{
					this.OO._0oo000_00..ExtendedProperties.Add("MirrorFromDataTable", this);
				}
			}
			DataRow dataRow = this.OO._0oo000_00..NewRow();
			dataRow.RowError = "Mirror";
			return new DataRow(dataRow);
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x001098F4 File Offset: 0x00107AF4
		private DataTable <<EMPTY_NAME>>()
		{
			DataTable dataTable = new DataTable();
			try
			{
				foreach (object obj in this._DataTable.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					dataTable.Columns.Add(dataColumn.ColumnName, dataColumn.DataType);
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
			return dataTable;
		}

		/// <summary>
		/// 在后台表查找符合条件的行
		/// </summary>
		/// <param name="Filter">条件表达式</param>
		/// <param name="Sort">排序列</param>
		/// <param name="Index">返回第几个符合条件的行，默认返回第一行</param>
		// Token: 0x0600249B RID: 9371 RVA: 0x00109970 File Offset: 0x00107B70
		[oO0oooo("2911")]
		public DataRow SQLFind(string Filter, string Sort = "", int Index = 0)
		{
			string top = (Index + 1).ToString();
			List<DataRow> list = this.SQLSelect(Filter, top, Sort);
			DataRow result;
			if (list.Count > Index)
			{
				result = list[Index];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x001099AC File Offset: 0x00107BAC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object SQLSelect(params object[] args)
		{
			string filter = args[0].ToString();
			string top = "";
			string sort = "";
			if (args.Length > 1)
			{
				top = args[1].ToString();
			}
			if (args.Length > 2)
			{
				sort = args[2].ToString();
			}
			List<DataRow> list = this.SQLSelect(filter, top, sort);
			object result;
			if (ooO.o.O_0000_O.())
			{
				result = list.ToArray();
			}
			else
			{
				result = list;
			}
			return result;
		}

		/// <summary>
		/// 在后台表筛选符合条件的行，并以集合的形式返回
		/// </summary>
		/// <param name="Filter">条件表达式</param>
		/// <param name="Top">返回行数</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x0600249D RID: 9373 RVA: 0x00109A0C File Offset: 0x00107C0C
		[oO0oooo("2900")]
		public List<DataRow> SQLSelect(string Filter, string Top = "", string Sort = "")
		{
			int num;
			List<DataRow> result;
			int num7;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				List<DataRow> list = new List<DataRow>();
				IL_10:
				num2 = 3;
				if (this.o0__.Oo0o__O. != null || Operators.CompareString(this.DataServer, "", true) != 0)
				{
					goto IL_4C;
				}
				IL_2D:
				num2 = 4;
				MessageBox.Show("临时表不能使用SQLSelect查询后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_42:
				num2 = 5;
				result = list;
				goto IL_47D;
				IL_4C:
				num2 = 6;
				if (Operators.CompareString(this.DataServer, "", true) <= 0)
				{
					goto IL_6E;
				}
				IL_62:
				num2 = 7;
				string text = this.HttpSelect;
				goto IL_83;
				IL_6E:
				num2 = 9;
				text = this._Adapter.SelectCommand.CommandText;
				IL_83:
				num2 = 10;
				string text2 = "Select";
				IL_8D:
				num2 = 11;
				string text3 = Oo00.O__0oO_oo.Ooo.(text);
				IL_99:
				num2 = 12;
				text = text.Replace("\r", " ");
				IL_AF:
				num2 = 13;
				text = text.Replace("\n", " ");
				IL_C5:
				num2 = 14;
				text = text.Replace("  ", " ");
				IL_DB:
				num2 = 15;
				text = text.Replace("  ", " ");
				IL_F1:
				num2 = 16;
				string[] array = text.Split(new char[]
				{
					' '
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_109:
				num2 = 17;
				if (Operators.CompareString(array[1], "top", true) != 0)
				{
					goto IL_141;
				}
				IL_11D:
				num2 = 18;
				if (Operators.CompareString(array[3], "PERCENT", true) != 0)
				{
					goto IL_139;
				}
				IL_131:
				num2 = 19;
				int num3 = 4;
				goto IL_19B;
				IL_139:
				num2 = 21;
				num3 = 3;
				goto IL_19B;
				IL_141:
				num2 = 23;
				if (Operators.CompareString(array[2], "top", true) != 0)
				{
					goto IL_179;
				}
				IL_155:
				num2 = 24;
				if (Operators.CompareString(array[4], "PERCENT", true) != 0)
				{
					goto IL_171;
				}
				IL_169:
				num2 = 25;
				num3 = 5;
				goto IL_19B;
				IL_171:
				num2 = 27;
				num3 = 4;
				goto IL_19B;
				IL_179:
				num2 = 29;
				if (Operators.CompareString(array[1], "Distinct", true) != 0)
				{
					goto IL_195;
				}
				IL_18D:
				num2 = 30;
				num3 = 2;
				goto IL_19B;
				IL_195:
				num2 = 32;
				num3 = 1;
				IL_19B:
				num2 = 33;
				int num4 = text.IndexOf(" " + array[num3] + " ", StringComparison.CurrentCultureIgnoreCase);
				IL_1BC:
				num2 = 34;
				int num5 = text.IndexOf(" from ", StringComparison.CurrentCultureIgnoreCase);
				IL_1CE:
				num2 = 35;
				text = text.Substring(num4, num5 - num4);
				IL_1E1:
				num2 = 36;
				if (Operators.CompareString(Top, "", true) <= 0)
				{
					goto IL_207;
				}
				IL_1F3:
				num2 = 37;
				text2 = text2 + " Top " + Top;
				goto IL_22A;
				IL_207:
				num2 = 39;
				if (Operators.CompareString(Sort, "", true) <= 0)
				{
					goto IL_22A;
				}
				IL_219:
				num2 = 40;
				text2 += " Top 100 PERCENT ";
				IL_22A:
				num2 = 41;
				text2 = string.Concat(new string[]
				{
					text2,
					" ",
					text,
					" From ",
					text3
				});
				IL_259:
				num2 = 42;
				if (Operators.CompareString(Filter, "", true) <= 0)
				{
					goto IL_2BF;
				}
				IL_26B:
				num2 = 43;
				if (Operators.CompareString(this.DataServer, "", true) != 0)
				{
					goto IL_2A1;
				}
				IL_281:
				num2 = 44;
				text2 = text2 + " Where " + Oo00.o0_o._O_.(this.o0__.Oo0o__O., Filter, false);
				goto IL_2BF;
				IL_2A1:
				num2 = 46;
				text2 = text2 + " Where " + Oo00.o0_o._O_.(this.DataServerType, Filter, false);
				IL_2BF:
				num2 = 47;
				if (Operators.CompareString(Sort, "", true) <= 0)
				{
					goto IL_2E3;
				}
				IL_2D1:
				num2 = 48;
				text2 = text2 + " order by " + Sort;
				IL_2E3:
				num2 = 49;
				DataTable dataTable = new DataTable();
				IL_2ED:
				num2 = 50;
				if (Operators.CompareString(this.DataServer, "", true) != 0)
				{
					goto IL_364;
				}
				IL_303:
				num2 = 51;
				OleDbCommand oleDbCommand = new OleDbCommand(text2, this.o0__.Oo0o__O.);
				IL_315:
				num2 = 52;
				oleDbCommand.Transaction = this._Adapter.SelectCommand.Transaction;
				IL_32F:
				num2 = 53;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
				IL_33B:
				num2 = 54;
				oleDbDataAdapter.Fill(dataTable);
				IL_348:
				num2 = 55;
				dataTable.ExtendedProperties.Add("DataAdapter", this._Adapter);
				goto IL_3E3;
				IL_364:
				num2 = 57;
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
				IL_37E:
				num2 = 58;
				if (Operators.CompareString(this.UpdateServer, "", true) != 0)
				{
					goto IL_3AD;
				}
				IL_394:
				num2 = 59;
				httpClient.FormData.Add("IgnoreSchema", "True");
				IL_3AD:
				num2 = 60;
				httpClient.Select = text2;
				IL_3B9:
				num2 = 61;
				httpClient.FormData["Action"] = 2.ToString();
				IL_3D7:
				num2 = 62;
				dataTable = httpClient.GetBaseDataTable();
				IL_3E3:
				num2 = 63;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow a_ = (DataRow)obj;
					IL_404:
					num2 = 64;
					list.Add(new DataRow(a_));
					IL_415:
					num2 = 65;
				}
				IL_421:
				num2 = 66;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_439:
				num2 = 67;
				List<DataRow>.Enumerator enumerator2 = list.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow = enumerator2.Current;
					IL_450:
					num2 = 68;
					dataRow.OO0._o_00000. = this;
					IL_45B:
					num2 = 69;
				}
				IL_467:
				num2 = 70;
				((IDisposable)enumerator2).Dispose();
				IL_477:
				num2 = 71;
				result = list;
				IL_47D:
				goto IL_5EF;
				IL_482:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_5B0:
				goto IL_5E4;
				IL_5B2:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_5C2:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_5B2;
			}
			IL_5E4:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_5EF:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x0010A030 File Offset: 0x00108230
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SQLUpdate(object[] args)
		{
			List<DataRow> list = new List<DataRow>();
			checked
			{
				for (int i = 0; i < args.Length; i++)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(args[i]);
					list.Add((DataRow)objectValue);
				}
				this.SQLUpdate(list);
			}
		}

		/// <summary>
		/// 批量保存通过SQLSelect筛选出来的行
		/// </summary>
		/// <param name="lstRows">DataRow集合，集合中的行会被保存</param>
		// Token: 0x0600249F RID: 9375 RVA: 0x0010A070 File Offset: 0x00108270
		[oO0oooo("2901")]
		public void SQLUpdate(List<DataRow> lstRows)
		{
			if (Operators.CompareString(this.DataServer, "", true) > 0)
			{
				if (Operators.CompareString(this.UpdateServer, "", true) > 0)
				{
					List<DataRow> list = new List<DataRow>();
					List<DataRow> list2 = new List<DataRow>();
					try
					{
						foreach (DataRow dataRow in lstRows)
						{
							DataRowState rowState = dataRow.RowState;
							if (rowState != DataRowState.Deleted)
							{
								if (rowState == DataRowState.Modified)
								{
									list.Add(dataRow.BaseRow);
									if (list.Count >= this.BatchUpdateSize)
									{
										oOO0oO000_0_0.oOoOo_o.__.(this, list.ToArray());
										list.Clear();
									}
								}
							}
							else
							{
								list2.Add(dataRow.BaseRow);
								if (list2.Count >= this.BatchUpdateSize)
								{
									oOO0oO000_0_0.OO.OoO0.(this, list2.ToArray());
									list2.Clear();
								}
							}
						}
					}
					finally
					{
						List<DataRow>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (list.Count > 0)
					{
						oOO0oO000_0_0.oOoOo_o.__.(this, list.ToArray());
					}
					if (list2.Count > 0)
					{
						oOO0oO000_0_0.OO.OoO0.(this, list2.ToArray());
						return;
					}
				}
			}
			else
			{
				DataRow[] array = new DataRow[lstRows.Count - 1 + 1];
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array[i] = lstRows[i].BaseRow;
				}
				if (array.Length > 0)
				{
					if (array[0].Table.ExtendedProperties.Contains("DataAdapter") && array[0].Table.ExtendedProperties["DataAdapter"] == this._Adapter)
					{
						this._Adapter.Update(array);
						return;
					}
					MessageBox.Show("SQLUpdate更新后台数据失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x0010A230 File Offset: 0x00108430
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x0010A2F0 File Offset: 0x001084F0
		private OleDbDataAdapter Apapter2
		{
			get
			{
				OleDbDataAdapter result;
				if (this.o._OOO0oOo0__. != null)
				{
					result = this.o._OOO0oOo0__.;
				}
				else
				{
					OleDbConnection oleDbConnection = null;
					try
					{
						foreach (OleDbConnection oleDbConnection2 in DataTable.oO_.oOO0o_oo0_.)
						{
							if (Operators.CompareString(oleDbConnection2.ConnectionString, this.o0__.Oo0o__O..ConnectionString, true) == 0)
							{
								oleDbConnection = oleDbConnection2;
							}
						}
					}
					finally
					{
						List<OleDbConnection>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (oleDbConnection == null)
					{
						oleDbConnection = new OleDbConnection(this.o0__.Oo0o__O..ConnectionString);
						DataTable.oO_.oOO0o_oo0_..Add(oleDbConnection);
					}
					this.o._OOO0oOo0__. = new OleDbDataAdapter(this._Adapter.SelectCommand.CommandText, oleDbConnection);
					result = this.o._OOO0oOo0__.;
				}
				return result;
			}
			set
			{
			}
		}

		/// <summary>
		/// 数据源名称
		/// </summary>
		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x0010A2F4 File Offset: 0x001084F4
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x0010A380 File Offset: 0x00108580
		public string ConnectionName
		{
			get
			{
				string result;
				if (Operators.CompareString(this.o_oOo00.00ooo_., "", true) > 0)
				{
					result = this.o_oOo00.00ooo_.;
				}
				else
				{
					try
					{
						foreach (string text in O_O0OO.O._o_.().Keys)
						{
							if (O_O0OO.O._o_.()[text] == this.frd_Connection)
							{
								return text;
							}
						}
					}
					finally
					{
						Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = "";
				}
				return result;
			}
			internal set
			{
				this.o_oOo00.00ooo_. = value;
			}
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0010A38C File Offset: 0x0010858C
		internal void <<EMPTY_NAME>>(string A_0)
		{
			if (this._Adapter != null)
			{
				this._Adapter.SelectCommand.CommandText = this._Adapter.SelectCommand.CommandText.Replace(this.o._OOO0oOo0__., A_0);
				this.o._OOO0oOo0__. = A_0;
				this.o._OOO0oOo0__. = null;
				this.O_00_._.();
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x0010A3E1 File Offset: 0x001085E1
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x0010A3E9 File Offset: 0x001085E9
		internal string DataServer
		{
			get
			{
				return this.oO_.o.;
			}
			set
			{
				this.oO_.o. = value;
			}
		}

		/// <summary>
		/// 数据源类型
		/// </summary>
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x0010A3F4 File Offset: 0x001085F4
		public DataServerTypeEnum DataServerType
		{
			get
			{
				if (Operators.CompareString(this.ConnectionName, "", true) > 0)
				{
					if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.ConnectionName))
					{
						return O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].OO.OoO0.;
					}
					OleDbConnection a_ = O_O0OO.O._o_.()[this.ConnectionName];
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(a_))
					{
						return DataServerTypeEnum.Oracle;
					}
					if (o_O_o_oOoo__.OOOO_OO._oo.(a_))
					{
						return DataServerTypeEnum.SqlServer;
					}
				}
				return DataServerTypeEnum.Access;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x0010A46B File Offset: 0x0010866B
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x0010A473 File Offset: 0x00108673
		internal string UpdateServer
		{
			get
			{
				return this.OOo0Ooo_o.Oo.;
			}
			set
			{
				this.OOo0Ooo_o.Oo. = value;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x0010A47C File Offset: 0x0010867C
		// (set) Token: 0x060024AB RID: 9387 RVA: 0x0010A484 File Offset: 0x00108684
		internal string HttpSelect
		{
			get
			{
				return this.ooo0.0o0ooOo.;
			}
			set
			{
				this.ooo0.0o0ooOo. = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x0010A48D File Offset: 0x0010868D
		// (set) Token: 0x060024AD RID: 9389 RVA: 0x0010A495 File Offset: 0x00108695
		internal List<string> UpdateColumns
		{
			get
			{
				return this.O0o0_oo.0.;
			}
			set
			{
				this.O0o0_oo.0. = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x0010A49E File Offset: 0x0010869E
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x0010A4A6 File Offset: 0x001086A6
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int BatchUpdateSize
		{
			get
			{
				return this.O0O00ooOo.o_.;
			}
			set
			{
				this.O0O00ooOo.o_. = value;
			}
		}

		/// <summary>
		/// 如果锁定标记列(_Locked)是通过代码增加的，则此属性返回False
		/// </summary>
		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x0010A4AF File Offset: 0x001086AF
		public bool BuildinLock
		{
			get
			{
				return this.O000_00._0_o.;
			}
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x0010A4B8 File Offset: 0x001086B8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetQuikKey(params object[] args)
		{
			if (args.Length == 1)
			{
				this.SetQuikKey(Conversions.ToString(args[0]));
				return;
			}
			if (args.Length > 1)
			{
				string[] array = new string[args.Length - 1 + 1];
				int num = args.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array[i] = Conversions.ToString(args[i]);
				}
				this.SetQuikKey(array);
			}
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x0010A514 File Offset: 0x00108714
		public void SetQuikKey(string key)
		{
			if (Operators.CompareString(key, "", true) == 0)
			{
				if (this.o_oO0O_.O0. != null)
				{
					this.o_oO0O_.O0..Dispose();
					this.o_oO0O_.O0. = null;
					return;
				}
			}
			else
			{
				this.o_oO0O_.O0. = new DataView(this._DataTable, "", key, DataViewRowState.CurrentRows);
			}
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x0010A564 File Offset: 0x00108764
		public void SetQuikKey(params string[] keys)
		{
			if (keys.Length == 0)
			{
				if (this.o_oO0O_.O0. != null)
				{
					this.o_oO0O_.O0..Dispose();
					this.o_oO0O_.O0. = null;
					return;
				}
			}
			else
			{
				this.o_oO0O_.O0. = new DataView(this._DataTable, "", string.Join(",", keys), DataViewRowState.CurrentRows);
			}
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x0010A5B4 File Offset: 0x001087B4
		public DataRow QuikFind(params object[] Values)
		{
			DataRow result;
			if (Values.Length == 1)
			{
				result = this.QuikFind(RuntimeHelpers.GetObjectValue(Values[0]));
			}
			else
			{
				if (this.o_oO0O_.O0. != null)
				{
					int num = this.o_oO0O_.O0..Find(Values);
					if (num >= 0)
					{
						return new DataRow(this.o_oO0O_.O0.[num].Row);
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0010A610 File Offset: 0x00108810
		public DataRow QuikFind(object Value)
		{
			if (this.o_oO0O_.O0. != null)
			{
				int num = this.o_oO0O_.O0..Find(RuntimeHelpers.GetObjectValue(Value));
				if (num >= 0)
				{
					return new DataRow(this.o_oO0O_.O0.[num].Row);
				}
			}
			return null;
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x0010A658 File Offset: 0x00108858
		public List<DataRow> QuikSelect(params object[] Values)
		{
			List<DataRow> result;
			if (Values.Length == 1)
			{
				result = this.QuikSelect(RuntimeHelpers.GetObjectValue(Values[1]));
			}
			else
			{
				List<DataRow> list = new List<DataRow>();
				if (this.o_oO0O_.O0. != null)
				{
					foreach (DataRowView dataRowView in this.o_oO0O_.O0..FindRows(Values))
					{
						list.Add(new DataRow(dataRowView.Row));
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x0010A6C0 File Offset: 0x001088C0
		public List<DataRow> QuikSelect(object Value)
		{
			List<DataRow> list = new List<DataRow>();
			if (this.o_oO0O_.O0. != null)
			{
				foreach (DataRowView dataRowView in this.o_oO0O_.O0..FindRows(RuntimeHelpers.GetObjectValue(Value)))
				{
					list.Add(new DataRow(dataRowView.Row));
				}
			}
			return list;
		}

		// Token: 0x04000EBA RID: 3770
		[CompilerGenerated]
		[AccessedThroughProperty("_DataTable")]
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000EBB RID: 3771
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000EBC RID: 3772
		private static List<OleDbConnection> <<EMPTY_NAME>> = new List<OleDbConnection>();

		// Token: 0x04000EBD RID: 3773
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000EBE RID: 3774
		[CompilerGenerated]
		[AccessedThroughProperty("_Adapter")]
		private OleDbDataAdapter <<EMPTY_NAME>>;

		// Token: 0x04000EBF RID: 3775
		private OleDbDataAdapter <<EMPTY_NAME>>;

		// Token: 0x04000EC0 RID: 3776
		private GlobalEvents <<EMPTY_NAME>>;

		// Token: 0x04000EC1 RID: 3777
		internal DataColCollection <<EMPTY_NAME>>;

		// Token: 0x04000EC2 RID: 3778
		internal DataRowCollection <<EMPTY_NAME>>;

		// Token: 0x04000EC3 RID: 3779
		internal OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x04000EC4 RID: 3780
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EC5 RID: 3781
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000EC6 RID: 3782
		private DataTableProperty <<EMPTY_NAME>>;

		// Token: 0x04000EC7 RID: 3783
		private LookAndFeelProperty <<EMPTY_NAME>>;

		// Token: 0x04000EC8 RID: 3784
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EC9 RID: 3785
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ECA RID: 3786
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ECB RID: 3787
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ECC RID: 3788
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ECD RID: 3789
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ECE RID: 3790
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ECF RID: 3791
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ED0 RID: 3792
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ED1 RID: 3793
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ED2 RID: 3794
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ED3 RID: 3795
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ED4 RID: 3796
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ED5 RID: 3797
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ED6 RID: 3798
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ED7 RID: 3799
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ED8 RID: 3800
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ED9 RID: 3801
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EDA RID: 3802
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EDB RID: 3803
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EDC RID: 3804
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EDD RID: 3805
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EDE RID: 3806
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EDF RID: 3807
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EE0 RID: 3808
		private int <<EMPTY_NAME>>;

		// Token: 0x04000EE1 RID: 3809
		private int <<EMPTY_NAME>>;

		// Token: 0x04000EE2 RID: 3810
		private int <<EMPTY_NAME>>;

		// Token: 0x04000EE3 RID: 3811
		private int <<EMPTY_NAME>>;

		// Token: 0x04000EE4 RID: 3812
		private int <<EMPTY_NAME>>;

		// Token: 0x04000EE5 RID: 3813
		private DockArrageTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04000EE6 RID: 3814
		private DockArrageTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04000EE7 RID: 3815
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EE8 RID: 3816
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EE9 RID: 3817
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EEA RID: 3818
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EEB RID: 3819
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EEC RID: 3820
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EED RID: 3821
		private int <<EMPTY_NAME>>;

		// Token: 0x04000EEE RID: 3822
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EEF RID: 3823
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000EF0 RID: 3824
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000EF1 RID: 3825
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EF2 RID: 3826
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EF3 RID: 3827
		internal Assembly <<EMPTY_NAME>>;

		// Token: 0x04000EF4 RID: 3828
		internal long <<EMPTY_NAME>>;

		// Token: 0x04000EF5 RID: 3829
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000EF6 RID: 3830
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000EF7 RID: 3831
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000EF8 RID: 3832
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000EF9 RID: 3833
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000EFA RID: 3834
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000EFB RID: 3835
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000EFC RID: 3836
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000EFD RID: 3837
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000EFE RID: 3838
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000EFF RID: 3839
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000F00 RID: 3840
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000F01 RID: 3841
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000F02 RID: 3842
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000F03 RID: 3843
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000F04 RID: 3844
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000F05 RID: 3845
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000F06 RID: 3846
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000F07 RID: 3847
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000F08 RID: 3848
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000F09 RID: 3849
		internal MethodInfo <<EMPTY_NAME>>;

		// Token: 0x04000F0A RID: 3850
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000F0B RID: 3851
		private OleDbCommand <<EMPTY_NAME>>;

		// Token: 0x04000F0C RID: 3852
		private string <<EMPTY_NAME>>;

		// Token: 0x04000F0D RID: 3853
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000F0E RID: 3854
		internal decimal <<EMPTY_NAME>>;

		// Token: 0x04000F0F RID: 3855
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000F10 RID: 3856
		private string <<EMPTY_NAME>>;

		// Token: 0x04000F11 RID: 3857
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000F12 RID: 3858
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000F13 RID: 3859
		internal List<string> <<EMPTY_NAME>>;

		// Token: 0x04000F14 RID: 3860
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000F15 RID: 3861
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000F16 RID: 3862
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000F17 RID: 3863
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000F18 RID: 3864
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000F19 RID: 3865
		private string <<EMPTY_NAME>>;

		// Token: 0x04000F1A RID: 3866
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000F1B RID: 3867
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000F1C RID: 3868
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000F1D RID: 3869
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000F1E RID: 3870
		internal List<string> <<EMPTY_NAME>>;

		// Token: 0x04000F1F RID: 3871
		internal int <<EMPTY_NAME>>;

		// Token: 0x04000F20 RID: 3872
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000F21 RID: 3873
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000F22 RID: 3874
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000F23 RID: 3875
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000F24 RID: 3876
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000F25 RID: 3877
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000F26 RID: 3878
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000F27 RID: 3879
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000F28 RID: 3880
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000F29 RID: 3881
		private string <<EMPTY_NAME>>;

		// Token: 0x04000F2A RID: 3882
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000F2B RID: 3883
		private DataView <<EMPTY_NAME>>;
	}
}
