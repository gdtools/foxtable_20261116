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
	/// 内联MRP统计工具
	/// </summary>
	// Token: 0x020000B2 RID: 178
	[ComVisible(true)]
	[oO0oooo("3365")]
	public class InlineMRPBuilder
	{
		/// <summary>
		/// BOM表设置
		/// </summary>
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00034B80 File Offset: 0x00032D80
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00034B88 File Offset: 0x00032D88
		public BomTable BOM { get; set; }

		/// <summary>
		/// 成品率表设置
		/// </summary>
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00034B91 File Offset: 0x00032D91
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00034B99 File Offset: 0x00032D99
		public YieldTable Yield { get; set; }

		/// <summary>
		/// 库存表设置
		/// </summary>
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00034BA2 File Offset: 0x00032DA2
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00034BAA File Offset: 0x00032DAA
		public StockTable Stock { get; set; }

		/// <summary>
		/// 价格表设置
		/// </summary>
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00034BB3 File Offset: 0x00032DB3
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x00034BBB File Offset: 0x00032DBB
		[oO0oooo("3731")]
		public PriceTable Purchase { get; set; }

		/// <summary>
		/// 委外加工表设置
		/// </summary>
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00034BC4 File Offset: 0x00032DC4
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00034BCC File Offset: 0x00032DCC
		[oO0oooo("3732")]
		public PriceTable Subcontract { get; set; }

		/// <summary>
		/// 设置生产计划
		/// </summary>
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00034BD5 File Offset: 0x00032DD5
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00034BDD File Offset: 0x00032DDD
		public mrpPlan Plan { get; set; }

		/// <summary>
		/// 扩展统计设置
		/// </summary>
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00034BE6 File Offset: 0x00032DE6
		[oO0oooo("3396")]
		public MRPExtendTables Extensions { get; }

		/// <summary>
		/// 附加数据列
		/// </summary>
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00034BEE File Offset: 0x00032DEE
		[oO0oooo("3698")]
		public MRPExtendTables Additions { get; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00034BF6 File Offset: 0x00032DF6
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00034BFE File Offset: 0x00032DFE
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Type QuantityType { get; set; }

		/// <param name="TableName">要生成的统计表名称</param>
		// Token: 0x0600075E RID: 1886 RVA: 0x00034C08 File Offset: 0x00032E08
		public InlineMRPBuilder(string A_0)
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
			this.o0oO._o_. = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
			this.o0oO._o_. = A_0;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00034C9C File Offset: 0x00032E9C
		public InlineMRPBuilder()
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
			this.o0oO._o_. = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00034D27 File Offset: 0x00032F27
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Build(params object[] args)
		{
			if (args.Length == 0)
			{
				this.Build();
				return;
			}
			if (args.Length == 1)
			{
				this.Build(Conversions.ToBoolean(args[0]));
			}
		}

		/// <summary>
		/// 生成统计表
		/// </summary>
		// Token: 0x06000761 RID: 1889 RVA: 0x00034D4B File Offset: 0x00032F4B
		public DataTable Build()
		{
			return this.Build(false);
		}

		/// <summary>
		/// 生成统计表
		/// </summary>
		/// <param name="OnlyDataTable">是否只生成DataTab,不生成Table</param>
		// Token: 0x06000762 RID: 1890 RVA: 0x00034D54 File Offset: 0x00032F54
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
				if (Operators.CompareString(this.o0oO._o_., "", true) != 0)
				{
					goto IL_2E;
				}
				IL_1C:
				num2 = 3;
				this.o0oO._o_. = Oo00.oo0o.O0O_0__.("MRP统计");
				IL_2E:
				num2 = 4;
				if (Operators.CompareString(this.BOM.MaterialCol, this.BOM.ParentCol, true) != 0)
				{
					goto IL_6C;
				}
				IL_4E:
				num2 = 5;
				MessageBox.Show("父列和子列不能相同!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_63:
				num2 = 6;
				result = null;
				goto IL_25B;
				IL_6C:
				num2 = 7;
				if (!OO_00oOO.DataTables.Contains(this.o0oO._o_.) || OnlyDataTable)
				{
					goto IL_F4;
				}
				IL_83:
				num2 = 8;
				if (!OO_00oOO.DataTables[this.o0oO._o_.].AddByCode)
				{
					goto IL_AF;
				}
				IL_9C:
				num2 = 9;
				OO_00oOO.DataTables.Delete(this.o0oO._o_.);
				IL_AF:
				num2 = 10;
				if (!OO_00oOO.DataTables.Contains(this.o0oO._o_.))
				{
					goto IL_F4;
				}
				IL_C4:
				num2 = 11;
				MessageBox.Show("表" + this.o0oO._o_. + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_EA:
				num2 = 12;
				result = null;
				goto IL_25B;
				IL_F4:
				num2 = 13;
				DataTable dataTable = this.BuildDataSource();
				IL_FF:
				num2 = 14;
				dataTable.TableName = this.o0oO._o_.;
				IL_10F:
				num2 = 15;
				if (!OnlyDataTable)
				{
					goto IL_142;
				}
				IL_115:
				num2 = 16;
				DataTable dataTable2 = new DataTable(dataTable, null, null, "", O_O0OO.OoO.0OO__0ooo.());
				IL_12D:
				num2 = 17;
				dataTable2.o.0O000_.();
				IL_137:
				num2 = 18;
				result = dataTable2;
				goto IL_25B;
				IL_142:
				num2 = 19;
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable);
				IL_156:
				num2 = 20;
				OO_00oOO.DataTables.OO0o00.0O_0o.(new DataTable(dataTable, null, null, this.o0oO._o_., O_O0OO.OoO.0OO__0ooo.()));
				IL_177:
				num2 = 21;
				OO_00oOO.DataTables[this.o0oO._o_.].o.0O000_.();
				IL_18F:
				num2 = 22;
				OO_00oOO.DataTables[this.o0oO._o_.].AddByCode = true;
				IL_1A8:
				num2 = 23;
				OO_00oOO.DataTables[this.o0oO._o_.].Caption = this.Oo0oO0oOO_.0_o.;
				IL_1C6:
				num2 = 24;
				new O_0(O_O0OO.o__.O.(), OO_00oOO.DataTables[this.o0oO._o_.].BaseTable);
				IL_1E9:
				num2 = 25;
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[this.o0oO._o_.]);
				IL_206:
				num2 = 26;
				Main.OO_O.o..o0_o_o_0.0O.(this.o0oO._o_., true, false);
				IL_21B:
				num2 = 27;
				OO_00oOO.Tables[this.o0oO._o_.].Sort = OO_00oOO.MRP.MaterialCol;
				IL_23D:
				num2 = 28;
				dataTable.AcceptChanges();
				IL_247:
				num2 = 29;
				result = OO_00oOO.DataTables[this.o0oO._o_.];
				IL_25B:
				goto IL_325;
				IL_260:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2E6:
				goto IL_31A;
				IL_2E8:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2F8:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2E8;
			}
			IL_31A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_325:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000350AC File Offset: 0x000332AC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public fxDataSource2 BuildDataSource2()
		{
			fxDataSource a_ = this.BuildDataSource();
			return new fxDataSource2(a_);
		}

		/// <summary>
		/// 生成一个可以直接绑定到Table的DataSource属性的对象
		/// </summary>
		// Token: 0x06000764 RID: 1892 RVA: 0x000350C6 File Offset: 0x000332C6
		public fxDataSource BuildDataSource()
		{
			return this.OO_Oo.0oO.();
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000350D0 File Offset: 0x000332D0
		private fxDataSource <<EMPTY_NAME>>()
		{
			int num;
			fxDataSource result;
			int num17;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.o0oO._o_..Clear();
				IL_14:
				num2 = 3;
				DataView dataView = new DataView(this.BOM.DataTable.BaseTable, "", this.BOM.MaterialCol, DataViewRowState.CurrentRows);
				IL_3F:
				num2 = 4;
				IEnumerator<string> enumerator = this.Plan.Keys.GetEnumerator();
				bool flag;
				while (enumerator.MoveNext())
				{
					string key = enumerator.Current;
					IL_5E:
					num2 = 5;
					if (dataView.Find(key) >= 0)
					{
						IL_6C:
						num2 = 6;
						flag = true;
						break;
					}
					IL_73:
					num2 = 8;
				}
				IL_7E:
				num2 = 9;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_8C:
				num2 = 10;
				Type dataType = this.BOM.DataTable.DataCols[this.BOM.QuantityCol].DataType;
				IL_B6:
				num2 = 11;
				if (dataType != typeof(float) && dataType != typeof(double) && dataType != typeof(decimal))
				{
					goto IL_F6;
				}
				IL_E3:
				num2 = 12;
				this.QuantityType = typeof(double);
				IL_F6:
				num2 = 13;
				fxDataSource fxDataSource = new fxDataSource();
				IL_100:
				num2 = 14;
				fxDataSource.Columns.Add(OO_00oOO.MRP.MaterialCol, typeof(string));
				IL_124:
				num2 = 15;
				fxDataSource.Columns[OO_00oOO.MRP.MaterialCol].MaxLength = this.BOM.DataTable.BaseTable.Columns[this.BOM.MaterialCol].MaxLength;
				IL_16C:
				num2 = 16;
				IEnumerator<o00_0__O> enumerator2 = this.Additions.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					o00_0__O o00_0__O = enumerator2.Current;
					IL_18A:
					num2 = 17;
					o00_0__O.oo__.0O00.(true);
					IL_195:
					num2 = 18;
					fxDataSource.Columns.Add(o00_0__O.o0o.OooOOo0__.(), o00_0__O.oo__.0O00.().BaseTable.Columns[o00_0__O.oooO00.o00O.()].DataType);
					IL_1CE:
					num2 = 19;
					fxDataSource.Columns[o00_0__O.o0o.OooOOo0__.()].MaxLength = o00_0__O.oo__.0O00.().BaseTable.Columns[o00_0__O.oooO00.o00O.()].MaxLength;
					IL_20B:
					num2 = 20;
				}
				IL_21A:
				num2 = 21;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_228:
				num2 = 22;
				if (this.Additions.Count <= 0)
				{
					goto IL_27C;
				}
				IL_239:
				num2 = 23;
				if (Operators.CompareString(OO_00oOO.MRP.MaterialCol, "物料", true) != 0)
				{
					goto IL_27C;
				}
				IL_253:
				num2 = 24;
				fxDataSource.Columns[OO_00oOO.MRP.MaterialCol].Caption = this.BOM.MaterialCol;
				IL_27C:
				num2 = 25;
				if (this.Stock.DataTable == null)
				{
					goto IL_2E8;
				}
				IL_28C:
				num2 = 26;
				fxDataSource.Columns.Add(OO_00oOO.MRP.StockCol, this.QuantityType);
				IL_2AC:
				num2 = 27;
				if (Operators.CompareString(this.Stock.MinimumCol, "", true) <= 0)
				{
					goto IL_2E8;
				}
				IL_2C8:
				num2 = 28;
				fxDataSource.Columns.Add(OO_00oOO.MRP.MinimumCol, this.QuantityType);
				IL_2E8:
				num2 = 29;
				fxDataSource.Columns.Add(OO_00oOO.MRP.QuantityCol, this.QuantityType);
				IL_308:
				num2 = 30;
				if (!flag)
				{
					goto IL_3AD;
				}
				IL_312:
				num2 = 31;
				fxDataSource.Columns.Add(OO_00oOO.MRP.AssembleCol, this.QuantityType);
				IL_332:
				num2 = 32;
				fxDataSource.Columns.Add(OO_00oOO.MRP.MaintenanceCol, this.QuantityType);
				IL_352:
				num2 = 33;
				fxDataSource.Columns[OO_00oOO.MRP.AssembleCol].Expression = string.Concat(new string[]
				{
					"[",
					OO_00oOO.MRP.QuantityCol,
					"] - IsNull([",
					OO_00oOO.MRP.MaintenanceCol,
					"],0)"
				});
				IL_3AD:
				num2 = 34;
				if (this.Stock.DataTable == null)
				{
					goto IL_3DD;
				}
				IL_3BD:
				num2 = 35;
				fxDataSource.Columns.Add(OO_00oOO.MRP.FromStockCol, this.QuantityType);
				IL_3DD:
				num2 = 36;
				IEnumerator<o00_0__O> enumerator3 = this.Extensions.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					o00_0__O o00_0__O2 = enumerator3.Current;
					IL_3F8:
					num2 = 37;
					fxDataSource.Columns.Add(o00_0__O2.o0o.OooOOo0__.(), this.QuantityType);
					IL_415:
					num2 = 38;
				}
				IL_421:
				num2 = 39;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_42F:
				num2 = 40;
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchaseCol, this.QuantityType);
				IL_44F:
				num2 = 41;
				if (this.Purchase.DataTable == null)
				{
					goto IL_4E7;
				}
				IL_462:
				num2 = 42;
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchasePriceCol, typeof(double));
				IL_486:
				num2 = 43;
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchaseCostCol, typeof(double), string.Concat(new string[]
				{
					"[",
					OO_00oOO.MRP.PurchasePriceCol,
					"] * [",
					OO_00oOO.MRP.PurchaseCol,
					"]"
				}));
				IL_4E7:
				num2 = 44;
				fxDataSource.Columns.Add(OO_00oOO.MRP.ProductionCol, this.QuantityType);
				IL_507:
				num2 = 45;
				if (this.Subcontract.DataTable == null)
				{
					goto IL_59F;
				}
				IL_51A:
				num2 = 46;
				fxDataSource.Columns.Add(OO_00oOO.MRP.SCPriceCol, typeof(double));
				IL_53E:
				num2 = 47;
				fxDataSource.Columns.Add(OO_00oOO.MRP.SCCostCol, typeof(double), string.Concat(new string[]
				{
					"[",
					OO_00oOO.MRP.ProductionCol,
					"] * [",
					OO_00oOO.MRP.SCPriceCol,
					"]"
				}));
				IL_59F:
				num2 = 48;
				if (this.Stock.DataTable == null)
				{
					goto IL_60B;
				}
				IL_5AF:
				num2 = 49;
				if (Operators.CompareString(this.Stock.MinimumCol, "", true) <= 0)
				{
					goto IL_5EB;
				}
				IL_5CB:
				num2 = 50;
				fxDataSource.Columns.Add(OO_00oOO.MRP.ReplenishCol, this.QuantityType);
				IL_5EB:
				num2 = 51;
				fxDataSource.Columns.Add(OO_00oOO.MRP.RemainingCol, this.QuantityType);
				IL_60B:
				num2 = 52;
				fxDataSource.PrimaryKey = new DataColumn[]
				{
					fxDataSource.Columns[OO_00oOO.MRP.MaterialCol]
				};
				IL_634:
				num2 = 53;
				DataView dataView2 = new DataView(this.BOM.DataTable.BaseTable, "", this.BOM.ParentCol, DataViewRowState.CurrentRows);
				IL_660:
				num2 = 54;
				DataView dataView3 = null;
				IL_666:
				num2 = 55;
				DataView dataView4 = null;
				IL_66C:
				num2 = 56;
				DataView dataView5 = null;
				IL_672:
				num2 = 57;
				DataView dataView6 = null;
				IL_678:
				num2 = 58;
				if (this.Yield.DataTable == null || this.Yield.MaterialCol == null || this.Yield.YieldCol == null)
				{
					goto IL_6CE;
				}
				IL_6A2:
				num2 = 59;
				dataView3 = new DataView(this.Yield.DataTable.BaseTable, "", this.Yield.MaterialCol, DataViewRowState.CurrentRows);
				IL_6CE:
				num2 = 60;
				if (this.Stock.DataTable == null || this.Stock.MaterialCol == null || this.Stock.QuantityCol == null)
				{
					goto IL_724;
				}
				IL_6F8:
				num2 = 61;
				dataView4 = new DataView(this.Stock.DataTable.BaseTable, "", this.Stock.MaterialCol, DataViewRowState.CurrentRows);
				IL_724:
				num2 = 62;
				if (this.Purchase.DataTable == null || Operators.CompareString(this.Purchase.MaterialCol, "", true) <= 0 || Operators.CompareString(this.Purchase.PriceCol, "", true) <= 0)
				{
					goto IL_792;
				}
				IL_766:
				num2 = 63;
				dataView5 = new DataView(this.Purchase.DataTable.BaseTable, "", this.Purchase.MaterialCol, DataViewRowState.CurrentRows);
				IL_792:
				num2 = 64;
				if (this.Subcontract.DataTable == null || Operators.CompareString(this.Subcontract.MaterialCol, "", true) <= 0 || Operators.CompareString(this.Subcontract.PriceCol, "", true) <= 0)
				{
					goto IL_800;
				}
				IL_7D4:
				num2 = 65;
				dataView6 = new DataView(this.Subcontract.DataTable.BaseTable, "", this.Subcontract.MaterialCol, DataViewRowState.CurrentRows);
				IL_800:
				num2 = 66;
				IEnumerator<string> enumerator4 = this.Plan.Keys.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					string text = enumerator4.Current;
					IL_820:
					num2 = 67;
					double a_ = this.OO_Oo.0oO.(dataView3, text, this.Plan[text]);
					IL_83C:
					num2 = 68;
					this.OO_Oo.0oO.(fxDataSource, dataView2, dataView, dataView3, text, a_, true);
					IL_853:
					num2 = 69;
				}
				IL_85F:
				num2 = 70;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
				IL_86D:
				num2 = 71;
				IEnumerator enumerator5 = fxDataSource.Rows.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					object obj = enumerator5.Current;
					DataRow dataRow = (DataRow)obj;
					IL_891:
					num2 = 72;
					string text2 = dataRow[OO_00oOO.MRP.MaterialCol].ToString();
					IL_8AC:
					num2 = 73;
					if (dataView2.Find(text2) >= 0)
					{
						IL_8BE:
						num2 = 74;
						int num3 = -1;
						IL_8C4:
						num2 = 75;
						if (dataView4 != null)
						{
							IL_8CB:
							num2 = 76;
							num3 = dataView4.Find(RuntimeHelpers.GetObjectValue(dataRow[OO_00oOO.MRP.MaterialCol]));
						}
						IL_8ED:
						num2 = 77;
						if (num3 > -1)
						{
							IL_8F8:
							num2 = 78;
							double num4 = 0.0;
							IL_906:
							num2 = 79;
							double num5 = 0.0;
							IL_914:
							num2 = 80;
							double num6 = Conversions.ToDouble(dataRow[OO_00oOO.MRP.QuantityCol]);
							IL_92F:
							num2 = 81;
							if (!dataView4[num3].Row.IsNull(this.Stock.QuantityCol))
							{
								IL_955:
								num2 = 82;
								num5 = Conversions.ToDouble(dataView4[num3][this.Stock.QuantityCol]);
								IL_978:
								num2 = 83;
								if (Operators.CompareString(this.Stock.MinimumCol, "", true) > 0 && !dataView4[num3].Row.IsNull(this.Stock.MinimumCol))
								{
									IL_9B4:
									num2 = 84;
									num4 = Math.Max(0.0, Conversions.ToDouble(dataView4[num3][this.Stock.MinimumCol]));
								}
							}
							IL_9E5:
							num2 = 85;
							IEnumerator<o00_0__O> enumerator6 = this.Extensions.GetEnumerator();
							while (enumerator6.MoveNext())
							{
								o00_0__O o00_0__O3 = enumerator6.Current;
								IL_A00:
								num2 = 86;
								if (!dataRow.IsNull(o00_0__O3.o0o.OooOOo0__.()))
								{
									IL_A13:
									num2 = 87;
									num5 += Conversions.ToDouble(dataRow[o00_0__O3.o0o.OooOOo0__.()]);
								}
								IL_A2E:
								num2 = 88;
							}
							IL_A3A:
							num2 = 89;
							if (enumerator6 != null)
							{
								enumerator6.Dispose();
							}
							IL_A48:
							num2 = 90;
							double num7;
							if (num4 > num5)
							{
								IL_A51:
								num2 = 91;
								num7 = num5 - num4;
							}
							else
							{
								IL_A5D:
								num2 = 93;
								if (num5 > num4)
								{
									IL_A66:
									num2 = 94;
									num7 = num5 - num4;
									IL_A70:
									num2 = 95;
									if (num7 > num6)
									{
										IL_A79:
										num2 = 96;
										num7 = num6;
									}
								}
							}
							IL_A80:
							num2 = 97;
							this.OO_Oo.0oO.(fxDataSource, dataView2, dataView, dataView3, text2, -num7, false);
						}
					}
					IL_A98:
					num2 = 98;
				}
				IL_AA7:
				num2 = 99;
				if (enumerator5 is IDisposable)
				{
					(enumerator5 as IDisposable).Dispose();
				}
				IL_ABF:
				num2 = 100;
				IEnumerator enumerator7 = fxDataSource.Rows.GetEnumerator();
				while (enumerator7.MoveNext())
				{
					object obj2 = enumerator7.Current;
					DataRow dataRow2 = (DataRow)obj2;
					IL_AE3:
					num2 = 101;
					double num8 = 0.0;
					IL_AF1:
					num2 = 102;
					IEnumerator<o00_0__O> enumerator8 = this.Extensions.GetEnumerator();
					while (enumerator8.MoveNext())
					{
						o00_0__O o00_0__O4 = enumerator8.Current;
						IL_B0C:
						num2 = 103;
						if (!dataRow2.IsNull(o00_0__O4.o0o.OooOOo0__.()))
						{
							IL_B1F:
							num2 = 104;
							num8 += Conversions.ToDouble(dataRow2[o00_0__O4.o0o.OooOOo0__.()]);
						}
						IL_B3A:
						num2 = 105;
					}
					IL_B46:
					num2 = 106;
					if (enumerator8 != null)
					{
						enumerator8.Dispose();
					}
					IL_B54:
					num2 = 107;
					int num9 = -1;
					IL_B5A:
					num2 = 108;
					if (dataView4 != null)
					{
						IL_B61:
						num2 = 109;
						num9 = dataView4.Find(RuntimeHelpers.GetObjectValue(dataRow2[OO_00oOO.MRP.MaterialCol]));
					}
					IL_B83:
					num2 = 110;
					double num10 = Conversions.ToDouble(dataRow2[OO_00oOO.MRP.QuantityCol]);
					IL_B9E:
					num2 = 111;
					if (num9 > -1)
					{
						IL_BA9:
						num2 = 112;
						double num11 = 0.0;
						IL_BB7:
						num2 = 113;
						double num12 = 0.0;
						IL_BC5:
						num2 = 114;
						if (!dataView4[num9].Row.IsNull(this.Stock.QuantityCol))
						{
							IL_BE8:
							num2 = 115;
							num11 = Conversions.ToDouble(dataView4[num9][this.Stock.QuantityCol]);
							IL_C0B:
							num2 = 116;
							dataRow2[OO_00oOO.MRP.StockCol] = num11;
						}
						IL_C26:
						num2 = 117;
						if (Operators.CompareString(this.Stock.MinimumCol, "", true) > 0 && !dataView4[num9].Row.IsNull(this.Stock.MinimumCol))
						{
							IL_C62:
							num2 = 118;
							num12 = Math.Max(0.0, Conversions.ToDouble(dataView4[num9][this.Stock.MinimumCol]));
							IL_C93:
							num2 = 119;
							dataRow2[OO_00oOO.MRP.MinimumCol] = num12;
						}
						IL_CAE:
						num2 = 120;
						if (num11 >= num12 && num12 > 0.0)
						{
							IL_CCA:
							num2 = 121;
							double num13 = Math.Min(num11 - num12, num10);
							IL_CDB:
							num2 = 122;
							num10 -= num13;
							IL_CE5:
							num2 = 123;
							dataRow2[OO_00oOO.MRP.FromStockCol] = num13;
							IL_D00:
							num2 = 124;
							num10 = Math.Max(0.0, num10 - num8);
							IL_D18:
							num2 = 125;
							if (dataView2.Find(dataRow2[OO_00oOO.MRP.MaterialCol].ToString()) >= 0)
							{
								IL_D3B:
								num2 = 126;
								dataRow2[OO_00oOO.MRP.ProductionCol] = num10;
							}
							else
							{
								IL_D58:
								num2 = 128;
								dataRow2[OO_00oOO.MRP.PurchaseCol] = num10;
							}
							IL_D76:
							num2 = 129;
							dataRow2[OO_00oOO.MRP.RemainingCol] = num11 - num13;
						}
						else
						{
							IL_D9C:
							num2 = 131;
							if (num11 < num12)
							{
								IL_DAB:
								num2 = 132;
								double num14 = num12 - num11;
								IL_DB8:
								num2 = 133;
								num10 += num14;
								IL_DC5:
								num2 = 134;
								dataRow2[OO_00oOO.MRP.ReplenishCol] = num14;
								IL_DE3:
								num2 = 135;
								dataRow2[OO_00oOO.MRP.FromStockCol] = 0;
								IL_E00:
								num2 = 136;
								num10 = Math.Max(0.0, num10 - num8);
								IL_E1B:
								num2 = 137;
								if (dataView2.Find(dataRow2[OO_00oOO.MRP.MaterialCol].ToString()) >= 0)
								{
									IL_E41:
									num2 = 138;
									dataRow2[OO_00oOO.MRP.ProductionCol] = num10;
								}
								else
								{
									IL_E61:
									num2 = 140;
									dataRow2[OO_00oOO.MRP.PurchaseCol] = num10;
								}
								IL_E7F:
								num2 = 141;
								dataRow2[OO_00oOO.MRP.RemainingCol] = num12;
							}
							else
							{
								IL_EA2:
								num2 = 143;
								double num15;
								if (num11 > num10)
								{
									IL_EAE:
									num2 = 144;
									num15 = num10;
									IL_EB8:
									num2 = 145;
									dataRow2[OO_00oOO.MRP.RemainingCol] = num11 - num10;
								}
								else
								{
									IL_EDB:
									num2 = 147;
									if (num11 > 0.0)
									{
										IL_EEE:
										num2 = 148;
										num15 = num11;
										IL_EF8:
										num2 = 149;
										dataRow2[OO_00oOO.MRP.RemainingCol] = 0;
									}
								}
								IL_F15:
								num2 = 150;
								num10 -= num15;
								IL_F22:
								num2 = 151;
								dataRow2[OO_00oOO.MRP.FromStockCol] = num15;
								IL_F40:
								num2 = 152;
								num10 = Math.Max(0.0, num10 - num8);
								IL_F5B:
								num2 = 153;
								if (dataView2.Find(dataRow2[OO_00oOO.MRP.MaterialCol].ToString()) >= 0)
								{
									IL_F81:
									num2 = 154;
									dataRow2[OO_00oOO.MRP.ProductionCol] = num10;
								}
								else
								{
									IL_FA4:
									num2 = 156;
									dataRow2[OO_00oOO.MRP.PurchaseCol] = num10;
								}
							}
						}
					}
					else
					{
						IL_FC4:
						num2 = 158;
						num10 = Math.Max(0.0, num10 - num8);
						IL_FDF:
						num2 = 159;
						if (dataView2.Find(dataRow2[OO_00oOO.MRP.MaterialCol].ToString()) >= 0)
						{
							IL_1005:
							num2 = 160;
							dataRow2[OO_00oOO.MRP.ProductionCol] = num10;
						}
						else
						{
							IL_1025:
							num2 = 162;
							dataRow2[OO_00oOO.MRP.PurchaseCol] = num10;
						}
					}
					IL_1043:
					num2 = 163;
					if (dataView5 != null)
					{
						IL_104D:
						num2 = 164;
						num9 = dataView5.Find(RuntimeHelpers.GetObjectValue(dataRow2[OO_00oOO.MRP.MaterialCol]));
						IL_1072:
						num2 = 165;
						if (num9 >= 0)
						{
							IL_107D:
							num2 = 166;
							dataRow2[OO_00oOO.MRP.PurchasePriceCol] = RuntimeHelpers.GetObjectValue(dataView5[num9][this.Purchase.PriceCol]);
						}
					}
					IL_10B2:
					num2 = 167;
					if (dataView6 != null)
					{
						IL_10BC:
						num2 = 168;
						num9 = dataView6.Find(RuntimeHelpers.GetObjectValue(dataRow2[OO_00oOO.MRP.MaterialCol]));
						IL_10E1:
						num2 = 169;
						if (num9 >= 0)
						{
							IL_10EC:
							num2 = 170;
							dataRow2[OO_00oOO.MRP.SCPriceCol] = RuntimeHelpers.GetObjectValue(dataView6[num9][this.Subcontract.PriceCol]);
						}
					}
					IL_1121:
					num2 = 171;
				}
				IL_1133:
				num2 = 172;
				if (enumerator7 is IDisposable)
				{
					(enumerator7 as IDisposable).Dispose();
				}
				IL_114E:
				num2 = 173;
				result = fxDataSource;
				IL_1157:
				goto IL_1461;
				IL_115C:
				int num16 = num17 + 1;
				num17 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num16);
				IL_1422:
				goto IL_1456;
				IL_1424:
				num17 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1434:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num17 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_1424;
			}
			IL_1456:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1461:
			if (num17 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00036564 File Offset: 0x00034764
		private bool <<EMPTY_NAME>>(DataTable A_0, DataView A_1, DataView A_2, DataView A_3, string A_4, double A_5, bool A_6)
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
				if (!A_6)
				{
					goto IL_119;
				}
				IL_10:
				num2 = 3;
				if (A_2.Find(A_4) < 0)
				{
					goto IL_119;
				}
				IL_20:
				num2 = 4;
				DataRow dataRow = A_0.Rows.Find(A_4);
				IL_31:
				num2 = 5;
				if (dataRow != null)
				{
					goto IL_82;
				}
				IL_37:
				num2 = 6;
				dataRow = A_0.NewRow();
				IL_41:
				num2 = 7;
				dataRow[OO_00oOO.MRP.MaterialCol] = A_4;
				IL_56:
				num2 = 8;
				dataRow[OO_00oOO.MRP.QuantityCol] = A_5;
				IL_70:
				num2 = 9;
				A_0.Rows.Add(dataRow);
				goto IL_B4;
				IL_82:
				num2 = 11;
				dataRow[OO_00oOO.MRP.QuantityCol] = Conversions.ToDouble(dataRow[OO_00oOO.MRP.QuantityCol]) + A_5;
				IL_B4:
				num2 = 12;
				if (!dataRow.IsNull(OO_00oOO.MRP.MaintenanceCol))
				{
					goto IL_E7;
				}
				IL_CA:
				num2 = 13;
				dataRow[OO_00oOO.MRP.MaintenanceCol] = A_5;
				goto IL_119;
				IL_E7:
				num2 = 15;
				dataRow[OO_00oOO.MRP.MaintenanceCol] = Conversions.ToDouble(dataRow[OO_00oOO.MRP.MaintenanceCol]) + A_5;
				IL_119:
				num2 = 16;
				DataRowView[] array = A_1.FindRows(A_4);
				IL_126:
				num2 = 17;
				foreach (DataRowView dataRowView in array)
				{
					IL_13C:
					num2 = 18;
					if (!dataRowView.Row.IsNull(this.BOM.MaterialCol) && !dataRowView.Row.IsNull(this.BOM.QuantityCol))
					{
						IL_177:
						num2 = 20;
						string text = dataRowView[this.BOM.MaterialCol].ToString();
						IL_193:
						num2 = 21;
						if (Operators.CompareString(text, A_4, true) != 0)
						{
							IL_1A5:
							num2 = 23;
							double num3 = this.OO_Oo.0oO.(A_3, text, Conversions.ToDouble(dataRowView[this.BOM.QuantityCol]) * A_5);
							IL_1CE:
							num2 = 24;
							DataRow dataRow2 = A_0.Rows.Find(text);
							IL_1E0:
							num2 = 25;
							if (dataRow2 == null)
							{
								IL_1EA:
								num2 = 26;
								dataRow2 = A_0.NewRow();
								IL_1F5:
								num2 = 27;
								dataRow2[OO_00oOO.MRP.MaterialCol] = text;
								IL_20B:
								num2 = 28;
								dataRow2[OO_00oOO.MRP.QuantityCol] = num3;
								IL_226:
								num2 = 29;
								A_0.Rows.Add(dataRow2);
								IL_236:
								num2 = 30;
								MRPExtendTables[] array3 = new MRPExtendTables[]
								{
									this.Extensions,
									this.Additions
								};
								IL_253:
								num2 = 31;
								foreach (MRPExtendTables mrpextendTables in array3)
								{
									IL_269:
									num2 = 32;
									IEnumerator<o00_0__O> enumerator = mrpextendTables.GetEnumerator();
									while (enumerator.MoveNext())
									{
										o00_0__O o00_0__O = enumerator.Current;
										IL_283:
										num2 = 33;
										int num4 = o00_0__O.oo__.0O00.().Find(text);
										IL_296:
										num2 = 34;
										if (num4 >= 0)
										{
											IL_2A1:
											num2 = 35;
											dataRow2[o00_0__O.o0o.OooOOo0__.()] = RuntimeHelpers.GetObjectValue(o00_0__O.oo__.0O00.()[num4][o00_0__O.oooO00.o00O.()]);
											IL_2D1:
											num2 = 36;
											if (array3 == this.Extensions && !o00_0__O.oo__.0O00.()[num4].Row.IsNull(o00_0__O.oooO00.o00O.()))
											{
												IL_305:
												num2 = 37;
												if (this.o0oO._o_..ContainsKey(text))
												{
													IL_317:
													num2 = 38;
													this.o0oO._o_.[text] = this.o0oO._o_.[text] + Conversions.ToDouble(o00_0__O.oo__.0O00.()[num4].Row[o00_0__O.oooO00.o00O.()]);
												}
												else
												{
													IL_35B:
													num2 = 40;
													this.o0oO._o_.[text] = Conversions.ToDouble(o00_0__O.oo__.0O00.()[num4].Row[o00_0__O.oooO00.o00O.()]);
												}
											}
										}
										IL_38F:
										num2 = 41;
									}
									IL_39E:
									num2 = 42;
									if (enumerator != null)
									{
										enumerator.Dispose();
									}
									IL_3AC:
									num2 = 43;
								}
							}
							else
							{
								IL_3C2:
								num2 = 45;
								dataRow2[OO_00oOO.MRP.QuantityCol] = Conversions.ToDouble(dataRow2[OO_00oOO.MRP.QuantityCol]) + num3;
							}
							IL_3F4:
							num2 = 46;
							if (this.o0oO._o_..ContainsKey(text))
							{
								IL_406:
								num2 = 47;
								double num5 = this.o0oO._o_.[text];
								IL_418:
								num2 = 48;
								if (num5 >= num3)
								{
									IL_421:
									num2 = 49;
									this.o0oO._o_.[text] = num5 - num3;
									goto IL_47F;
								}
								IL_438:
								num2 = 52;
								if (num5 > 0.0)
								{
									IL_448:
									num2 = 53;
									this.o0oO._o_.[text] = 0.0;
									IL_461:
									num2 = 54;
									num3 -= num5;
								}
							}
							IL_46B:
							num2 = 55;
							this.OO_Oo.0oO.(A_0, A_1, A_2, A_3, text, num3, false);
						}
					}
					IL_47F:
					num2 = 56;
				}
				IL_493:
				goto IL_5C9;
				IL_498:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_58A:
				goto IL_5BE;
				IL_58C:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_59C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_58C;
			}
			IL_5BE:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_5C9:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
			bool result;
			return result;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00036B60 File Offset: 0x00034D60
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

		// Token: 0x0400021C RID: 540
		[CompilerGenerated]
		private BomTable <<EMPTY_NAME>>;

		// Token: 0x0400021D RID: 541
		[CompilerGenerated]
		private YieldTable <<EMPTY_NAME>>;

		// Token: 0x0400021E RID: 542
		[CompilerGenerated]
		private StockTable <<EMPTY_NAME>>;

		// Token: 0x0400021F RID: 543
		[CompilerGenerated]
		private PriceTable <<EMPTY_NAME>>;

		// Token: 0x04000220 RID: 544
		[CompilerGenerated]
		private PriceTable <<EMPTY_NAME>>;

		// Token: 0x04000221 RID: 545
		[CompilerGenerated]
		private mrpPlan <<EMPTY_NAME>>;

		// Token: 0x04000222 RID: 546
		[CompilerGenerated]
		private MRPExtendTables <<EMPTY_NAME>>;

		// Token: 0x04000223 RID: 547
		[CompilerGenerated]
		private MRPExtendTables <<EMPTY_NAME>>;

		// Token: 0x04000224 RID: 548
		[CompilerGenerated]
		private Type <<EMPTY_NAME>>;

		// Token: 0x04000225 RID: 549
		private Dictionary<string, double> <<EMPTY_NAME>>;

		// Token: 0x04000226 RID: 550
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000227 RID: 551
		internal string <<EMPTY_NAME>>;
	}
}
