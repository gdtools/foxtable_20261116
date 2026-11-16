using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 层级BOM统计工具
	/// </summary>
	// Token: 0x020000B3 RID: 179
	[ComVisible(true)]
	[oO0oooo("3366")]
	public class LayersMRPBuilder
	{
		/// <summary>
		/// BOM表设置
		/// </summary>
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00036C26 File Offset: 0x00034E26
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00036C2E File Offset: 0x00034E2E
		public BomTable BOM { get; set; }

		/// <summary>
		/// 成品率表设置
		/// </summary>
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00036C37 File Offset: 0x00034E37
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00036C3F File Offset: 0x00034E3F
		public YieldTable Yield { get; set; }

		/// <summary>
		/// 库存表设置
		/// </summary>
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00036C48 File Offset: 0x00034E48
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00036C50 File Offset: 0x00034E50
		public StockTable Stock { get; set; }

		/// <summary>
		/// 价格表设置
		/// </summary>
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00036C59 File Offset: 0x00034E59
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00036C61 File Offset: 0x00034E61
		[oO0oooo("3731")]
		public PriceTable Purchase { get; set; }

		/// <summary>
		/// 委外加工表设置
		/// </summary>
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00036C6A File Offset: 0x00034E6A
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00036C72 File Offset: 0x00034E72
		[oO0oooo("3732")]
		public PriceTable Subcontract { get; set; }

		/// <summary>
		/// 设置生产计划
		/// </summary>
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00036C7B File Offset: 0x00034E7B
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00036C83 File Offset: 0x00034E83
		public mrpPlan Plan { get; set; }

		/// <summary>
		/// 扩展统计设置
		/// </summary>
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00036C8C File Offset: 0x00034E8C
		[oO0oooo("3396")]
		public MRPExtendTables Extensions { get; }

		/// <summary>
		/// 附加数据列
		/// </summary>
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x00036C94 File Offset: 0x00034E94
		[oO0oooo("3698")]
		public MRPExtendTables Additions { get; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00036C9C File Offset: 0x00034E9C
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00036CA4 File Offset: 0x00034EA4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Type QuantityType { get; set; }

		/// <param name="TableName">要生成的统计表名称</param>
		// Token: 0x06000778 RID: 1912 RVA: 0x00036CB0 File Offset: 0x00034EB0
		public LayersMRPBuilder(string A_0)
		{
			this.BOM = new BomTable();
			this.Yield = new YieldTable();
			this.Stock = new StockTable();
			this.Purchase = new PriceTable();
			this.Subcontract = new PriceTable();
			this.Plan = new mrpPlan();
			this.Extensions = new MRPExtendTables();
			this.Additions = new MRPExtendTables();
			this.QuantityType = typeof(long);
			this.o00.o_O_o__. = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
			this.o00.o_O_o__. = OoOo0O.OO_o.0o_O.(10);
			this.o00.o_O_o__. = new List<DataRow>();
			this.oO.O_0_o000_0. = A_0;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00036D5C File Offset: 0x00034F5C
		public LayersMRPBuilder()
		{
			this.BOM = new BomTable();
			this.Yield = new YieldTable();
			this.Stock = new StockTable();
			this.Purchase = new PriceTable();
			this.Subcontract = new PriceTable();
			this.Plan = new mrpPlan();
			this.Extensions = new MRPExtendTables();
			this.Additions = new MRPExtendTables();
			this.QuantityType = typeof(long);
			this.o00.o_O_o__. = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
			this.o00.o_O_o__. = OoOo0O.OO_o.0o_O.(10);
			this.o00.o_O_o__. = new List<DataRow>();
		}

		/// <summary>
		/// 生成统计表
		/// </summary>
		// Token: 0x0600077A RID: 1914 RVA: 0x00036DFF File Offset: 0x00034FFF
		public DataTable Build()
		{
			return this.Build(false);
		}

		/// <summary>
		/// 生成统计表
		/// </summary>
		/// <param name="OnlyDataTable">是否只生成DataTab,不生成Table</param>
		// Token: 0x0600077B RID: 1915 RVA: 0x00036E08 File Offset: 0x00035008
		public DataTable Build(bool OnlyDataTable)
		{
			int num;
			DataTable result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (Operators.CompareString(this.oO.O_0_o000_0., "", true) != 0)
				{
					goto IL_2E;
				}
				IL_1C:
				num2 = 3;
				this.oO.O_0_o000_0. = Oo00.oo0o.O0O_0__.("MRP统计");
				IL_2E:
				num2 = 4;
				if (!OO_00oOO.DataTables.Contains(this.oO.O_0_o000_0.) || OnlyDataTable)
				{
					goto IL_B3;
				}
				IL_45:
				num2 = 5;
				if (!OO_00oOO.DataTables[this.oO.O_0_o000_0.].AddByCode)
				{
					goto IL_70;
				}
				IL_5E:
				num2 = 6;
				OO_00oOO.DataTables.Delete(this.oO.O_0_o000_0.);
				IL_70:
				num2 = 7;
				if (!OO_00oOO.DataTables.Contains(this.oO.O_0_o000_0.))
				{
					goto IL_B3;
				}
				IL_84:
				num2 = 8;
				MessageBox.Show("表" + this.oO.O_0_o000_0. + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_A9:
				num2 = 9;
				result = null;
				goto IL_4AD;
				IL_B3:
				num2 = 10;
				OO_00oOO.SystemReady = false;
				IL_BC:
				num2 = 11;
				if (Operators.CompareString(this.BOM.MaterialCol, "", true) != 0 || Operators.CompareString(Conversions.ToString(this.BOM.Separator2), "", true) <= 0)
				{
					goto IL_25D;
				}
				IL_FB:
				num2 = 12;
				this.BOM.MaterialCol = this.o00.o_O_o__.;
				IL_10F:
				num2 = 13;
				this.BOM.DataTable.Save();
				IL_122:
				num2 = 14;
				IEnumerator<Table> enumerator = OO_00oOO.Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Table table = enumerator.Current;
					IL_13C:
					num2 = 15;
					if (table.DataTable.BaseTable == this.BOM.DataTable.BaseTable)
					{
						IL_15D:
						num2 = 16;
						table.foxGrid.AutoGenerateColumns = false;
					}
					IL_16D:
					num2 = 17;
				}
				IL_179:
				num2 = 18;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_187:
				num2 = 19;
				this.BOM.DataTable.BaseTable.Columns.Add(this.o00.o_O_o__., typeof(string));
				IL_1B5:
				num2 = 20;
				foreach (DataRow dataRow in this.BOM.DataTable.BaseTable.Select("", "", DataViewRowState.CurrentRows))
				{
					IL_1E7:
					num2 = 21;
					if (!dataRow.IsNull(this.BOM.PathCol))
					{
						IL_1FE:
						num2 = 23;
						string[] array2 = dataRow[this.BOM.PathCol].ToString().Split(new char[]
						{
							this.BOM.Separator2
						});
						IL_233:
						num2 = 24;
						dataRow[this.o00.o_O_o__.] = array2[array2.Length - 1];
					}
					IL_24C:
					num2 = 25;
				}
				IL_25D:
				num2 = 26;
				DataTable dataTable = this.BuildDataSource();
				IL_268:
				num2 = 27;
				if (Operators.CompareString(this.BOM.MaterialCol, this.o00.o_O_o__., true) != 0 || Operators.CompareString(Conversions.ToString(this.BOM.Separator2), "", true) <= 0)
				{
					goto IL_348;
				}
				IL_2A8:
				num2 = 28;
				this.BOM.DataTable.BaseTable.Columns.Remove(this.o00.o_O_o__.);
				IL_2CB:
				num2 = 29;
				IEnumerator<Table> enumerator2 = OO_00oOO.Tables.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Table table2 = enumerator2.Current;
					IL_2E5:
					num2 = 30;
					if (table2.DataTable.BaseTable == this.BOM.DataTable.BaseTable)
					{
						IL_306:
						num2 = 31;
						table2.foxGrid.AutoGenerateColumns = true;
					}
					IL_316:
					num2 = 32;
				}
				IL_322:
				num2 = 33;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_330:
				num2 = 34;
				this.BOM.DataTable.BaseTable.AcceptChanges();
				IL_348:
				num2 = 35;
				OO_00oOO.SystemReady = true;
				IL_351:
				num2 = 36;
				dataTable.TableName = this.oO.O_0_o000_0.;
				IL_361:
				num2 = 37;
				if (!OnlyDataTable)
				{
					goto IL_394;
				}
				IL_367:
				num2 = 38;
				DataTable dataTable2 = new DataTable(dataTable, null, null, "", O_O0OO.OoO.0OO__0ooo.());
				IL_37F:
				num2 = 39;
				dataTable2.o.0O000_.();
				IL_389:
				num2 = 40;
				result = dataTable2;
				goto IL_4AD;
				IL_394:
				num2 = 41;
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable);
				IL_3A8:
				num2 = 42;
				OO_00oOO.DataTables.OO0o00.0O_0o.(new DataTable(dataTable, null, null, this.oO.O_0_o000_0., O_O0OO.OoO.0OO__0ooo.()));
				IL_3C9:
				num2 = 43;
				OO_00oOO.DataTables[this.oO.O_0_o000_0.].o.0O000_.();
				IL_3E1:
				num2 = 44;
				OO_00oOO.DataTables[this.oO.O_0_o000_0.].AddByCode = true;
				IL_3FA:
				num2 = 45;
				OO_00oOO.DataTables[this.oO.O_0_o000_0.].Caption = this.o_oo_O0O.oO_.;
				IL_418:
				num2 = 46;
				new O_0(O_O0OO.o__.O.(), OO_00oOO.DataTables[this.oO.O_0_o000_0.].BaseTable);
				IL_43B:
				num2 = 47;
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[this.oO.O_0_o000_0.]);
				IL_458:
				num2 = 48;
				Main.OO_O.o..o0_o_o_0.0O.(this.oO.O_0_o000_0., true, false);
				IL_46D:
				num2 = 49;
				OO_00oOO.Tables[this.oO.O_0_o000_0.].Sort = OO_00oOO.MRP.MaterialCol;
				IL_48F:
				num2 = 50;
				dataTable.AcceptChanges();
				IL_499:
				num2 = 51;
				result = OO_00oOO.DataTables[this.oO.O_0_o000_0.];
				IL_4AD:
				goto IL_5CF;
				IL_4B2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_590:
				goto IL_5C4;
				IL_592:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_5A2:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_592;
			}
			IL_5C4:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_5CF:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0003740C File Offset: 0x0003560C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public fxDataSource2 BuildDataSource2()
		{
			fxDataSource a_ = this.BuildDataSource();
			return new fxDataSource2(a_);
		}

		/// <summary>
		/// 生成一个可以直接绑定到Table的DataSource属性的对象
		/// </summary>
		// Token: 0x0600077D RID: 1917 RVA: 0x00037426 File Offset: 0x00035626
		public fxDataSource BuildDataSource()
		{
			return this.o_.__OOO0.();
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00037430 File Offset: 0x00035630
		private fxDataSource <<EMPTY_NAME>>()
		{
			int num;
			fxDataSource result;
			int num19;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.o00.o_O_o__..Clear();
				IL_14:
				num2 = 3;
				Type dataType = this.BOM.DataTable.DataCols[this.BOM.QuantityCol].DataType;
				IL_3D:
				num2 = 4;
				if (dataType != typeof(float) && dataType != typeof(double) && dataType != typeof(decimal))
				{
					goto IL_7B;
				}
				IL_69:
				num2 = 5;
				this.QuantityType = typeof(double);
				IL_7B:
				num2 = 6;
				fxDataSource fxDataSource = new fxDataSource();
				IL_84:
				num2 = 7;
				fxDataSource.Columns.Add(OO_00oOO.MRP.MaterialCol, typeof(string));
				IL_A7:
				num2 = 8;
				fxDataSource.Columns[OO_00oOO.MRP.MaterialCol].MaxLength = this.BOM.DataTable.BaseTable.Columns[this.BOM.MaterialCol].MaxLength;
				IL_EE:
				num2 = 9;
				IEnumerator<o00_0__O> enumerator = this.Additions.GetEnumerator();
				while (enumerator.MoveNext())
				{
					o00_0__O o00_0__O = enumerator.Current;
					IL_10C:
					num2 = 10;
					o00_0__O.oo__.0O00.(true);
					IL_117:
					num2 = 11;
					fxDataSource.Columns.Add(o00_0__O.o0o.OooOOo0__.(), o00_0__O.oo__.0O00.().BaseTable.Columns[o00_0__O.oooO00.o00O.()].DataType);
					IL_150:
					num2 = 12;
					fxDataSource.Columns[o00_0__O.o0o.OooOOo0__.()].MaxLength = o00_0__O.oo__.0O00.().BaseTable.Columns[o00_0__O.oooO00.o00O.()].MaxLength;
					IL_18D:
					num2 = 13;
				}
				IL_19C:
				num2 = 14;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_1AA:
				num2 = 15;
				if (this.Additions.Count <= 0)
				{
					goto IL_1FE;
				}
				IL_1BB:
				num2 = 16;
				if (Operators.CompareString(OO_00oOO.MRP.MaterialCol, "物料", true) != 0)
				{
					goto IL_1FE;
				}
				IL_1D5:
				num2 = 17;
				fxDataSource.Columns[OO_00oOO.MRP.MaterialCol].Caption = this.BOM.MaterialCol;
				IL_1FE:
				num2 = 18;
				if (this.Stock.DataTable == null)
				{
					goto IL_24E;
				}
				IL_20E:
				num2 = 19;
				fxDataSource.Columns.Add(OO_00oOO.MRP.StockCol, this.QuantityType);
				IL_22E:
				num2 = 20;
				fxDataSource.Columns.Add(OO_00oOO.MRP.MinimumCol, this.QuantityType);
				IL_24E:
				num2 = 21;
				fxDataSource.Columns.Add(OO_00oOO.MRP.QuantityCol, this.QuantityType);
				IL_26E:
				num2 = 22;
				if (this.Stock.DataTable == null)
				{
					goto IL_29E;
				}
				IL_27E:
				num2 = 23;
				fxDataSource.Columns.Add(OO_00oOO.MRP.FromStockCol, this.QuantityType);
				IL_29E:
				num2 = 24;
				IEnumerator<o00_0__O> enumerator2 = this.Extensions.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					o00_0__O o00_0__O2 = enumerator2.Current;
					IL_2B9:
					num2 = 25;
					fxDataSource.Columns.Add(o00_0__O2.o0o.OooOOo0__.(), this.QuantityType);
					IL_2D6:
					num2 = 26;
				}
				IL_2E2:
				num2 = 27;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_2F0:
				num2 = 28;
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchaseCol, this.QuantityType);
				IL_310:
				num2 = 29;
				if (this.Purchase.DataTable == null)
				{
					goto IL_3A8;
				}
				IL_323:
				num2 = 30;
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchasePriceCol, typeof(double));
				IL_347:
				num2 = 31;
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchaseCostCol, typeof(double), string.Concat(new string[]
				{
					"[",
					OO_00oOO.MRP.PurchasePriceCol,
					"] * [",
					OO_00oOO.MRP.PurchaseCol,
					"]"
				}));
				IL_3A8:
				num2 = 32;
				fxDataSource.Columns.Add(OO_00oOO.MRP.ProductionCol, this.QuantityType);
				IL_3C8:
				num2 = 33;
				if (this.Subcontract.DataTable == null)
				{
					goto IL_460;
				}
				IL_3DB:
				num2 = 34;
				fxDataSource.Columns.Add(OO_00oOO.MRP.SCPriceCol, typeof(double));
				IL_3FF:
				num2 = 35;
				fxDataSource.Columns.Add(OO_00oOO.MRP.SCCostCol, typeof(double), string.Concat(new string[]
				{
					"[",
					OO_00oOO.MRP.ProductionCol,
					"] * [",
					OO_00oOO.MRP.SCPriceCol,
					"]"
				}));
				IL_460:
				num2 = 36;
				if (this.Stock.DataTable == null)
				{
					goto IL_4B0;
				}
				IL_470:
				num2 = 37;
				fxDataSource.Columns.Add(OO_00oOO.MRP.ReplenishCol, this.QuantityType);
				IL_490:
				num2 = 38;
				fxDataSource.Columns.Add(OO_00oOO.MRP.RemainingCol, this.QuantityType);
				IL_4B0:
				num2 = 39;
				fxDataSource.PrimaryKey = new DataColumn[]
				{
					fxDataSource.Columns[OO_00oOO.MRP.MaterialCol]
				};
				IL_4D9:
				num2 = 40;
				DataView dataView = new DataView(this.BOM.DataTable.BaseTable, "", this.BOM.MaterialCol, DataViewRowState.CurrentRows);
				IL_505:
				num2 = 41;
				DataView dataView2 = null;
				IL_50B:
				num2 = 42;
				DataView dataView3 = null;
				IL_511:
				num2 = 43;
				DataView dataView4 = null;
				IL_517:
				num2 = 44;
				DataView dataView5 = null;
				IL_51D:
				num2 = 45;
				if (this.Yield.DataTable == null || this.Yield.MaterialCol == null || this.Yield.YieldCol == null)
				{
					goto IL_573;
				}
				IL_547:
				num2 = 46;
				dataView2 = new DataView(this.Yield.DataTable.BaseTable, "", this.Yield.MaterialCol, DataViewRowState.CurrentRows);
				IL_573:
				num2 = 47;
				if (this.Stock.DataTable == null || this.Stock.MaterialCol == null || this.Stock.QuantityCol == null)
				{
					goto IL_5C9;
				}
				IL_59D:
				num2 = 48;
				dataView3 = new DataView(this.Stock.DataTable.BaseTable, "", this.Stock.MaterialCol, DataViewRowState.CurrentRows);
				IL_5C9:
				num2 = 49;
				if (this.Purchase.DataTable == null || Operators.CompareString(this.Purchase.MaterialCol, "", true) <= 0 || Operators.CompareString(this.Purchase.PriceCol, "", true) <= 0)
				{
					goto IL_637;
				}
				IL_60B:
				num2 = 50;
				dataView4 = new DataView(this.Purchase.DataTable.BaseTable, "", this.Purchase.MaterialCol, DataViewRowState.CurrentRows);
				IL_637:
				num2 = 51;
				if (this.Subcontract.DataTable == null || Operators.CompareString(this.Subcontract.MaterialCol, "", true) <= 0 || Operators.CompareString(this.Subcontract.PriceCol, "", true) <= 0)
				{
					goto IL_6A5;
				}
				IL_679:
				num2 = 52;
				dataView5 = new DataView(this.Subcontract.DataTable.BaseTable, "", this.Subcontract.MaterialCol, DataViewRowState.CurrentRows);
				IL_6A5:
				num2 = 53;
				Dictionary<string, double> dictionary = new Dictionary<string, double>();
				IL_6AF:
				num2 = 54;
				Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
				IL_6B9:
				num2 = 55;
				IEnumerator<string> enumerator3 = this.Plan.Keys.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					string text = enumerator3.Current;
					IL_6DC:
					num2 = 56;
					int num3 = dataView.Find(text);
					IL_6EA:
					num2 = 57;
					if (num3 > -1)
					{
						IL_6F5:
						num2 = 58;
						if (!dataView[num3].Row.IsNull(this.BOM.PathCol))
						{
							IL_71B:
							num2 = 59;
							dictionary.Add(dataView[num3][this.BOM.PathCol].ToString(), this.Plan[text]);
							IL_750:
							num2 = 60;
							dictionary2.Add(dataView[num3][this.BOM.PathCol].ToString(), text);
						}
					}
					else
					{
						IL_77C:
						num2 = 62;
						dictionary.Add(text, this.Plan[text]);
						IL_795:
						num2 = 63;
						dictionary2.Add(text, text);
					}
					IL_7A3:
					num2 = 64;
				}
				IL_7B2:
				num2 = 65;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_7C0:
				num2 = 66;
				dataView.Sort = this.BOM.PathCol;
				IL_7D5:
				num2 = 67;
				Dictionary<string, double>.KeyCollection.Enumerator enumerator4 = dictionary.Keys.GetEnumerator();
				bool flag;
				while (enumerator4.MoveNext())
				{
					string text2 = enumerator4.Current;
					IL_7F1:
					num2 = 68;
					if (this.BOM.Separator2 > '\0')
					{
						IL_802:
						num2 = 69;
						if (text2.IndexOf(this.BOM.Separator2) > 0)
						{
							IL_81A:
							num2 = 70;
							flag = true;
							break;
						}
					}
					else
					{
						IL_822:
						num2 = 73;
						if (this.BOM.lengths2 != null && this.BOM.lengths2.Length > 0)
						{
							IL_842:
							num2 = 74;
							if (text2.Length > this.BOM.lengths2[0])
							{
								IL_85B:
								num2 = 75;
								flag = true;
								break;
							}
						}
					}
					IL_863:
					num2 = 77;
				}
				IL_872:
				num2 = 78;
				((IDisposable)enumerator4).Dispose();
				IL_882:
				num2 = 79;
				if (!flag)
				{
					goto IL_99D;
				}
				IL_88C:
				num2 = 80;
				fxDataSource.Columns.Add(OO_00oOO.MRP.AssembleCol, this.QuantityType);
				IL_8AC:
				num2 = 81;
				fxDataSource.Columns.Add(OO_00oOO.MRP.MaintenanceCol, this.QuantityType);
				IL_8CC:
				num2 = 82;
				fxDataSource.Columns[OO_00oOO.MRP.AssembleCol].Expression = string.Concat(new string[]
				{
					"[",
					OO_00oOO.MRP.QuantityCol,
					"] - IsNull([",
					OO_00oOO.MRP.MaintenanceCol,
					"],0)"
				});
				IL_927:
				num2 = 83;
				fxDataSource.Columns[OO_00oOO.MRP.AssembleCol].SetOrdinal(fxDataSource.Columns[OO_00oOO.MRP.QuantityCol].Ordinal + 1);
				IL_962:
				num2 = 84;
				fxDataSource.Columns[OO_00oOO.MRP.MaintenanceCol].SetOrdinal(fxDataSource.Columns[OO_00oOO.MRP.QuantityCol].Ordinal + 2);
				IL_99D:
				num2 = 85;
				Dictionary<string, double>.KeyCollection.Enumerator enumerator5 = dictionary.Keys.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					string text3 = enumerator5.Current;
					IL_9B9:
					num2 = 86;
					double a_ = this.o_.__OOO0.(dataView2, dictionary2[text3], dictionary[text3]);
					IL_9D8:
					num2 = 87;
					this.o_.__OOO0.(fxDataSource, dataView, dataView2, text3, a_, dictionary2[text3]);
					IL_9F5:
					num2 = 88;
				}
				IL_A01:
				num2 = 89;
				((IDisposable)enumerator5).Dispose();
				IL_A11:
				num2 = 90;
				DataView dataView6 = new DataView(this.BOM.DataTable.BaseTable, "", this.BOM.MaterialCol, DataViewRowState.CurrentRows);
				IL_A3D:
				num2 = 91;
				IEnumerator enumerator6 = fxDataSource.Rows.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					object obj = enumerator6.Current;
					DataRow dataRow = (DataRow)obj;
					IL_A61:
					num2 = 92;
					if (this.o00.o_O_o__..Contains(dataRow))
					{
						IL_A76:
						num2 = 93;
						int num4 = dataView6.Find(RuntimeHelpers.GetObjectValue(dataRow[OO_00oOO.MRP.MaterialCol]));
						IL_A98:
						num2 = 94;
						if (num4 >= 0)
						{
							IL_AA3:
							num2 = 96;
							string a_2 = dataView6[num4][this.BOM.PathCol].ToString();
							IL_AC6:
							num2 = 97;
							int num5 = -1;
							IL_ACC:
							num2 = 98;
							if (dataView3 != null)
							{
								IL_AD3:
								num2 = 99;
								num5 = dataView3.Find(RuntimeHelpers.GetObjectValue(dataRow[OO_00oOO.MRP.MaterialCol]));
							}
							IL_AF5:
							num2 = 100;
							if (num5 > -1)
							{
								IL_B00:
								num2 = 101;
								double num6 = 0.0;
								IL_B0E:
								num2 = 102;
								double num7 = 0.0;
								IL_B1C:
								num2 = 103;
								double num8 = Conversions.ToDouble(dataRow[OO_00oOO.MRP.QuantityCol]);
								IL_B37:
								num2 = 104;
								if (!dataView3[num5].Row.IsNull(this.Stock.QuantityCol))
								{
									IL_B5D:
									num2 = 105;
									num7 = Conversions.ToDouble(dataView3[num5][this.Stock.QuantityCol]);
									IL_B80:
									num2 = 106;
									if (Operators.CompareString(this.Stock.MinimumCol, "", true) > 0 && !dataView3[num5].Row.IsNull(this.Stock.MinimumCol))
									{
										IL_BBC:
										num2 = 107;
										num6 = Math.Max(0.0, Conversions.ToDouble(dataView3[num5][this.Stock.MinimumCol]));
									}
								}
								IL_BED:
								num2 = 108;
								IEnumerator<o00_0__O> enumerator7 = this.Extensions.GetEnumerator();
								while (enumerator7.MoveNext())
								{
									o00_0__O o00_0__O3 = enumerator7.Current;
									IL_C08:
									num2 = 109;
									if (!dataRow.IsNull(o00_0__O3.o0o.OooOOo0__.()))
									{
										IL_C1B:
										num2 = 110;
										num7 += Conversions.ToDouble(dataRow[o00_0__O3.o0o.OooOOo0__.()]);
									}
									IL_C36:
									num2 = 111;
								}
								IL_C42:
								num2 = 112;
								if (enumerator7 != null)
								{
									enumerator7.Dispose();
								}
								IL_C50:
								num2 = 113;
								double num9;
								if (num6 > num7)
								{
									IL_C59:
									num2 = 114;
									num9 = num7 - num6;
								}
								else
								{
									IL_C65:
									num2 = 116;
									if (num7 > num6)
									{
										IL_C6E:
										num2 = 117;
										num9 = num7 - num6;
										IL_C78:
										num2 = 118;
										if (num9 > num8)
										{
											IL_C81:
											num2 = 119;
											num9 = num8;
										}
									}
								}
								IL_C88:
								num2 = 120;
								this.o_.__OOO0.(fxDataSource, dataView, dataView2, a_2, -num9, null);
							}
						}
					}
					IL_C9E:
					num2 = 121;
				}
				IL_CAD:
				num2 = 122;
				if (enumerator6 is IDisposable)
				{
					(enumerator6 as IDisposable).Dispose();
				}
				IL_CC5:
				num2 = 123;
				IEnumerator enumerator8 = fxDataSource.Rows.GetEnumerator();
				while (enumerator8.MoveNext())
				{
					object obj2 = enumerator8.Current;
					DataRow dataRow2 = (DataRow)obj2;
					IL_CE9:
					num2 = 124;
					double num10 = 0.0;
					IL_CF7:
					num2 = 125;
					IEnumerator<o00_0__O> enumerator9 = this.Extensions.GetEnumerator();
					while (enumerator9.MoveNext())
					{
						o00_0__O o00_0__O4 = enumerator9.Current;
						IL_D12:
						num2 = 126;
						if (!dataRow2.IsNull(o00_0__O4.o0o.OooOOo0__.()))
						{
							IL_D25:
							num2 = 127;
							num10 += Conversions.ToDouble(dataRow2[o00_0__O4.o0o.OooOOo0__.()]);
						}
						IL_D40:
						num2 = 128;
					}
					IL_D4F:
					num2 = 129;
					if (enumerator9 != null)
					{
						enumerator9.Dispose();
					}
					IL_D60:
					num2 = 130;
					int num11 = -1;
					IL_D69:
					num2 = 131;
					if (dataView3 != null)
					{
						IL_D73:
						num2 = 132;
						num11 = dataView3.Find(RuntimeHelpers.GetObjectValue(dataRow2[OO_00oOO.MRP.MaterialCol]));
					}
					IL_D98:
					num2 = 133;
					double num12 = Conversions.ToDouble(dataRow2[OO_00oOO.MRP.QuantityCol]);
					IL_DB6:
					num2 = 134;
					if (num11 > -1)
					{
						IL_DC4:
						num2 = 135;
						double num13 = 0.0;
						IL_DD5:
						num2 = 136;
						double num14 = 0.0;
						IL_DE6:
						num2 = 137;
						if (!dataView3[num11].Row.IsNull(this.Stock.QuantityCol))
						{
							IL_E0C:
							num2 = 138;
							num13 = Conversions.ToDouble(dataView3[num11][this.Stock.QuantityCol]);
							IL_E32:
							num2 = 139;
							dataRow2[OO_00oOO.MRP.StockCol] = num13;
						}
						IL_E50:
						num2 = 140;
						if (Operators.CompareString(this.Stock.MinimumCol, "", true) > 0 && !dataView3[num11].Row.IsNull(this.Stock.MinimumCol))
						{
							IL_E8F:
							num2 = 141;
							num14 = Math.Max(0.0, Conversions.ToDouble(dataView3[num11][this.Stock.MinimumCol]));
							IL_EC3:
							num2 = 142;
							dataRow2[OO_00oOO.MRP.MinimumCol] = num14;
						}
						IL_EE1:
						num2 = 143;
						if (num13 >= num14 && num14 > 0.0)
						{
							IL_F00:
							num2 = 144;
							double num15 = Math.Min(num13 - num14, num12);
							IL_F14:
							num2 = 145;
							num12 -= num15;
							IL_F21:
							num2 = 146;
							dataRow2[OO_00oOO.MRP.FromStockCol] = num15;
							IL_F3F:
							num2 = 147;
							num12 = Math.Max(0.0, num12 - num10);
							IL_F5A:
							num2 = 148;
							if (this.o00.o_O_o__..Contains(dataRow2))
							{
								IL_F6F:
								num2 = 149;
								dataRow2[OO_00oOO.MRP.ProductionCol] = num12;
							}
							else
							{
								IL_F8F:
								num2 = 151;
								dataRow2[OO_00oOO.MRP.PurchaseCol] = num12;
							}
							IL_FAD:
							num2 = 152;
							dataRow2[OO_00oOO.MRP.RemainingCol] = num13 - num15;
						}
						else
						{
							IL_FD3:
							num2 = 154;
							if (num13 < num14)
							{
								IL_FE2:
								num2 = 155;
								double num16 = num14 - num13;
								IL_FEF:
								num2 = 156;
								num12 += num16;
								IL_FFC:
								num2 = 157;
								dataRow2[OO_00oOO.MRP.ReplenishCol] = num16;
								IL_101A:
								num2 = 158;
								dataRow2[OO_00oOO.MRP.FromStockCol] = 0;
								IL_1037:
								num2 = 159;
								num12 = Math.Max(0.0, num12 - num10);
								IL_1052:
								num2 = 160;
								if (this.o00.o_O_o__..Contains(dataRow2))
								{
									IL_1067:
									num2 = 161;
									dataRow2[OO_00oOO.MRP.ProductionCol] = num12;
								}
								else
								{
									IL_1087:
									num2 = 163;
									dataRow2[OO_00oOO.MRP.PurchaseCol] = num12;
								}
								IL_10A5:
								num2 = 164;
								dataRow2[OO_00oOO.MRP.RemainingCol] = num14;
							}
							else
							{
								IL_10C8:
								num2 = 166;
								double num17;
								if (num13 > num12)
								{
									IL_10D4:
									num2 = 167;
									num17 = num12;
									IL_10DE:
									num2 = 168;
									dataRow2[OO_00oOO.MRP.RemainingCol] = num13 - num12;
								}
								else
								{
									IL_1101:
									num2 = 170;
									if (num13 > 0.0)
									{
										IL_1114:
										num2 = 171;
										num17 = num13;
										IL_111E:
										num2 = 172;
										dataRow2[OO_00oOO.MRP.RemainingCol] = 0;
									}
								}
								IL_113B:
								num2 = 173;
								num12 -= num17;
								IL_1148:
								num2 = 174;
								dataRow2[OO_00oOO.MRP.FromStockCol] = num17;
								IL_1166:
								num2 = 175;
								num12 = Math.Max(0.0, num12 - num10);
								IL_1181:
								num2 = 176;
								if (this.o00.o_O_o__..Contains(dataRow2))
								{
									IL_1196:
									num2 = 177;
									dataRow2[OO_00oOO.MRP.ProductionCol] = num12;
								}
								else
								{
									IL_11B9:
									num2 = 179;
									dataRow2[OO_00oOO.MRP.PurchaseCol] = num12;
								}
							}
						}
					}
					else
					{
						IL_11D9:
						num2 = 181;
						num12 = Math.Max(0.0, num12 - num10);
						IL_11F4:
						num2 = 182;
						if (this.o00.o_O_o__..Contains(dataRow2))
						{
							IL_1209:
							num2 = 183;
							dataRow2[OO_00oOO.MRP.ProductionCol] = num12;
						}
						else
						{
							IL_1229:
							num2 = 185;
							dataRow2[OO_00oOO.MRP.PurchaseCol] = num12;
						}
					}
					IL_1247:
					num2 = 186;
					if (dataView4 != null)
					{
						IL_1251:
						num2 = 187;
						num11 = dataView4.Find(RuntimeHelpers.GetObjectValue(dataRow2[OO_00oOO.MRP.MaterialCol]));
						IL_1276:
						num2 = 188;
						if (num11 >= 0)
						{
							IL_1281:
							num2 = 189;
							dataRow2[OO_00oOO.MRP.PurchasePriceCol] = RuntimeHelpers.GetObjectValue(dataView4[num11][this.Purchase.PriceCol]);
						}
					}
					IL_12B6:
					num2 = 190;
					if (dataView5 != null)
					{
						IL_12C0:
						num2 = 191;
						num11 = dataView5.Find(RuntimeHelpers.GetObjectValue(dataRow2[OO_00oOO.MRP.MaterialCol]));
						IL_12E5:
						num2 = 192;
						if (num11 >= 0)
						{
							IL_12F0:
							num2 = 193;
							dataRow2[OO_00oOO.MRP.SCPriceCol] = RuntimeHelpers.GetObjectValue(dataView5[num11][this.Subcontract.PriceCol]);
						}
					}
					IL_1325:
					num2 = 194;
				}
				IL_1337:
				num2 = 195;
				if (enumerator8 is IDisposable)
				{
					(enumerator8 as IDisposable).Dispose();
				}
				IL_1352:
				num2 = 196;
				result = fxDataSource;
				IL_135B:
				goto IL_16C1;
				IL_1360:
				int num18 = num19 + 1;
				num19 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num18);
				IL_1682:
				goto IL_16B6;
				IL_1684:
				num19 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1694:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num19 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_1684;
			}
			IL_16B6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_16C1:
			if (num19 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00038B24 File Offset: 0x00036D24
		private int <<EMPTY_NAME>>(DataTable A_0, DataView A_1, DataView A_2, string A_3, double A_4, string A_5)
		{
			int num;
			int result;
			int num15;
			object obj;
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
				int i = A_1.Find(A_3);
				IL_1C:
				num2 = 4;
				if (i >= 0 || Operators.CompareString(Conversions.ToString(this.BOM.Separator2), "", true) <= 0)
				{
					goto IL_CB;
				}
				IL_47:
				num2 = 5;
				string value = A_3 + Conversions.ToString(this.BOM.Separator2);
				IL_62:
				num2 = 6;
				int num3 = A_1.Count - 1;
				for (i = 0; i <= num3; i++)
				{
					IL_73:
					num2 = 7;
					if (A_1[i][this.BOM.PathCol].ToString().StartsWith(value, StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					IL_9C:
					num2 = 9;
				}
				IL_AB:
				num2 = 10;
				if (i < A_1.Count)
				{
					goto IL_C2;
				}
				IL_B8:
				num2 = 11;
				result = -1;
				goto IL_7CF;
				IL_C2:
				num2 = 13;
				i--;
				IL_CB:
				num2 = 14;
				if (Operators.CompareString(Conversions.ToString(this.BOM.Separator2), "", true) <= 0)
				{
					goto IL_1CA;
				}
				IL_EF:
				num2 = 15;
				if (Operators.CompareString(A_5, "", true) <= 0 || A_3.IndexOf(this.BOM.Separator2) <= 0)
				{
					goto IL_11D;
				}
				IL_117:
				num2 = 16;
				bool flag = true;
				IL_11D:
				num2 = 17;
				int num4 = i + 1;
				int num5 = A_1.Count - 1;
				for (int j = num4; j <= num5; j++)
				{
					IL_135:
					num2 = 18;
					string text = A_1[j][this.BOM.PathCol].ToString();
					IL_157:
					num2 = 19;
					if (!text.StartsWith(A_3 + Conversions.ToString(this.BOM.Separator2), StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					IL_17E:
					num2 = 20;
					if (text.LastIndexOf(this.BOM.Separator2) == A_3.Length)
					{
						IL_19C:
						num2 = 21;
						list.Add(A_1[j].Row);
					}
					IL_1B3:
					num2 = 24;
				}
				goto IL_317;
				IL_1CA:
				num2 = 26;
				if (this.BOM.lengths2 == null || this.BOM.lengths2.Length <= 0)
				{
					goto IL_317;
				}
				IL_1F0:
				num2 = 27;
				if (Operators.CompareString(A_5, "", true) <= 0 || A_3.Length <= this.BOM.lengths2[0])
				{
					goto IL_21F;
				}
				IL_219:
				num2 = 28;
				flag = true;
				IL_21F:
				num2 = 29;
				int num6 = 0;
				IL_225:
				num2 = 30;
				if (this.BOM.lengths2.Length != 1)
				{
					goto IL_254;
				}
				IL_238:
				num2 = 31;
				num6 = A_3.Length + this.BOM.lengths2[0];
				goto IL_29F;
				IL_254:
				num2 = 33;
				int num7 = 0;
				for (;;)
				{
					IL_291:
					num2 = 35;
					if (num6 > A_3.Length)
					{
						break;
					}
					IL_25C:
					num2 = 36;
					num6 += this.BOM.lengths2[num7];
					IL_272:
					num2 = 37;
					if (num7 < this.BOM.lengths2.Length - 1)
					{
						IL_288:
						num2 = 38;
						num7++;
					}
				}
				IL_29F:
				num2 = 40;
				int num8 = i;
				int num9 = A_1.Count - 1;
				for (int k = num8; k <= num9; k++)
				{
					IL_2B2:
					num2 = 41;
					string text2 = A_1[k][this.BOM.PathCol].ToString();
					IL_2D4:
					num2 = 42;
					if (!text2.StartsWith(A_3, StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					IL_2E3:
					num2 = 43;
					if (text2.Length == num6)
					{
						IL_2F1:
						num2 = 44;
						list.Add(A_1[k].Row);
					}
					IL_308:
					num2 = 47;
				}
				IL_317:
				num2 = 48;
				if (!flag || Operators.CompareString(A_5, "", true) <= 0)
				{
					goto IL_432;
				}
				IL_334:
				num2 = 49;
				DataRow dataRow = A_0.Rows.Find(A_5);
				IL_346:
				num2 = 50;
				if (dataRow != null)
				{
					goto IL_39B;
				}
				IL_34D:
				num2 = 51;
				dataRow = A_0.NewRow();
				IL_358:
				num2 = 52;
				dataRow[OO_00oOO.MRP.MaterialCol] = A_5;
				IL_36E:
				num2 = 53;
				dataRow[OO_00oOO.MRP.QuantityCol] = A_4;
				IL_389:
				num2 = 54;
				A_0.Rows.Add(dataRow);
				goto IL_3CD;
				IL_39B:
				num2 = 56;
				dataRow[OO_00oOO.MRP.QuantityCol] = Conversions.ToDouble(dataRow[OO_00oOO.MRP.QuantityCol]) + A_4;
				IL_3CD:
				num2 = 57;
				if (!dataRow.IsNull(OO_00oOO.MRP.MaintenanceCol))
				{
					goto IL_400;
				}
				IL_3E3:
				num2 = 58;
				dataRow[OO_00oOO.MRP.MaintenanceCol] = A_4;
				goto IL_432;
				IL_400:
				num2 = 60;
				dataRow[OO_00oOO.MRP.MaintenanceCol] = Conversions.ToDouble(dataRow[OO_00oOO.MRP.MaintenanceCol]) + A_4;
				IL_432:
				num2 = 61;
				List<DataRow>.Enumerator enumerator = list.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow2 = enumerator.Current;
					IL_44C:
					num2 = 62;
					if (!dataRow2.IsNull(this.BOM.MaterialCol) && !dataRow2.IsNull(this.BOM.QuantityCol))
					{
						IL_47D:
						num2 = 64;
						string a_ = dataRow2[this.BOM.PathCol].ToString();
						IL_499:
						num2 = 65;
						string text3 = dataRow2[this.BOM.MaterialCol].ToString();
						IL_4B5:
						num2 = 66;
						double num10 = this.o_.__OOO0.(A_2, text3, Conversions.ToDouble(dataRow2[this.BOM.QuantityCol]) * A_4);
						IL_4DD:
						num2 = 67;
						DataRow dataRow3 = A_0.Rows.Find(text3);
						IL_4EF:
						num2 = 68;
						if (dataRow3 == null)
						{
							IL_4F9:
							num2 = 69;
							dataRow3 = A_0.NewRow();
							IL_504:
							num2 = 70;
							dataRow3[OO_00oOO.MRP.MaterialCol] = text3;
							IL_51A:
							num2 = 71;
							dataRow3[OO_00oOO.MRP.QuantityCol] = num10;
							IL_535:
							num2 = 72;
							A_0.Rows.Add(dataRow3);
							IL_545:
							num2 = 73;
							MRPExtendTables[] array = new MRPExtendTables[]
							{
								this.Extensions,
								this.Additions
							};
							IL_562:
							num2 = 74;
							foreach (MRPExtendTables mrpextendTables in array)
							{
								IL_578:
								num2 = 75;
								IEnumerator<o00_0__O> enumerator2 = mrpextendTables.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									o00_0__O o00_0__O = enumerator2.Current;
									IL_592:
									num2 = 76;
									int num11 = o00_0__O.oo__.0O00.().Find(text3);
									IL_5A5:
									num2 = 77;
									if (num11 >= 0)
									{
										IL_5B0:
										num2 = 78;
										dataRow3[o00_0__O.o0o.OooOOo0__.()] = RuntimeHelpers.GetObjectValue(o00_0__O.oo__.0O00.()[num11][o00_0__O.oooO00.o00O.()]);
										IL_5E0:
										num2 = 79;
										if (mrpextendTables == this.Extensions && !o00_0__O.oo__.0O00.()[num11].Row.IsNull(o00_0__O.oooO00.o00O.()))
										{
											IL_614:
											num2 = 80;
											if (this.o00.o_O_o__..ContainsKey(text3))
											{
												IL_626:
												num2 = 81;
												this.o00.o_O_o__.[text3] = this.o00.o_O_o__.[text3] + Conversions.ToDouble(o00_0__O.oo__.0O00.()[num11].Row[o00_0__O.oooO00.o00O.()]);
											}
											else
											{
												IL_66A:
												num2 = 83;
												this.o00.o_O_o__.[text3] = Conversions.ToDouble(o00_0__O.oo__.0O00.()[num11].Row[o00_0__O.oooO00.o00O.()]);
											}
										}
									}
									IL_69E:
									num2 = 84;
								}
								IL_6AD:
								num2 = 85;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
								IL_6BB:
								num2 = 86;
							}
						}
						else
						{
							IL_6D1:
							num2 = 88;
							dataRow3[OO_00oOO.MRP.QuantityCol] = Conversions.ToDouble(dataRow3[OO_00oOO.MRP.QuantityCol]) + num10;
						}
						IL_703:
						num2 = 89;
						if (this.o00.o_O_o__..ContainsKey(text3))
						{
							IL_715:
							num2 = 90;
							double num12 = this.o00.o_O_o__.[text3];
							IL_727:
							num2 = 91;
							if (num12 >= num10)
							{
								IL_730:
								num2 = 92;
								this.o00.o_O_o__.[text3] = num12 - num10;
								goto IL_7A5;
							}
							IL_747:
							num2 = 95;
							if (num12 > 0.0)
							{
								IL_757:
								num2 = 96;
								this.o00.o_O_o__.[text3] = 0.0;
								IL_770:
								num2 = 97;
								num10 -= num12;
							}
						}
						IL_77A:
						num2 = 98;
						int num13 = this.o_.__OOO0.(A_0, A_1, A_2, a_, num10, null);
						IL_78D:
						num2 = 99;
						if (num13 > 0)
						{
							IL_795:
							num2 = 100;
							this.o00.o_O_o__..Add(dataRow3);
						}
					}
					IL_7A5:
					num2 = 101;
				}
				IL_7B4:
				num2 = 102;
				((IDisposable)enumerator).Dispose();
				IL_7C4:
				num2 = 103;
				result = list.Count;
				IL_7CF:
				goto IL_9C1;
				IL_7D4:
				int num14 = num15 + 1;
				num15 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num14);
				IL_982:
				goto IL_9B6;
				IL_984:
				num15 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_994:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num15 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_984;
			}
			IL_9B6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_9C1:
			if (num15 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00039518 File Offset: 0x00037718
		private double <<EMPTY_NAME>>(DataView A_0, string A_1, double A_2)
		{
			if (A_0 != null)
			{
				int num = A_0.Find(A_1);
				if (num >= 0 && !A_0[num].Row.IsNull(this.Yield.YieldCol) && Conversions.ToDouble(A_0[num][this.Yield.YieldCol]) > 0.0)
				{
					if (this.QuantityType == typeof(long))
					{
						A_2 = (double)((long)Math.Ceiling(A_2 / Conversions.ToDouble(A_0[num][this.Yield.YieldCol])));
					}
					else
					{
						A_2 /= Conversions.ToDouble(A_0[num][this.Yield.YieldCol]);
					}
				}
			}
			return A_2;
		}

		// Token: 0x04000228 RID: 552
		[CompilerGenerated]
		private BomTable <<EMPTY_NAME>>;

		// Token: 0x04000229 RID: 553
		[CompilerGenerated]
		private YieldTable <<EMPTY_NAME>>;

		// Token: 0x0400022A RID: 554
		[CompilerGenerated]
		private StockTable <<EMPTY_NAME>>;

		// Token: 0x0400022B RID: 555
		[CompilerGenerated]
		private PriceTable <<EMPTY_NAME>>;

		// Token: 0x0400022C RID: 556
		[CompilerGenerated]
		private PriceTable <<EMPTY_NAME>>;

		// Token: 0x0400022D RID: 557
		[CompilerGenerated]
		private mrpPlan <<EMPTY_NAME>>;

		// Token: 0x0400022E RID: 558
		[CompilerGenerated]
		private MRPExtendTables <<EMPTY_NAME>>;

		// Token: 0x0400022F RID: 559
		[CompilerGenerated]
		private MRPExtendTables <<EMPTY_NAME>>;

		// Token: 0x04000230 RID: 560
		[CompilerGenerated]
		private Type <<EMPTY_NAME>>;

		// Token: 0x04000231 RID: 561
		private Dictionary<string, double> <<EMPTY_NAME>>;

		// Token: 0x04000232 RID: 562
		private string <<EMPTY_NAME>>;

		// Token: 0x04000233 RID: 563
		private List<DataRow> <<EMPTY_NAME>>;

		// Token: 0x04000234 RID: 564
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000235 RID: 565
		internal string <<EMPTY_NAME>>;
	}
}
