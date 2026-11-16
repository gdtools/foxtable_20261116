using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200029E RID: 670
	[oO0oooo("1627")]
	[ComVisible(true)]
	public class SQLCrossTableBuilder : CrossTableBuilder
	{
		// Token: 0x06002207 RID: 8711 RVA: 0x000F2B1F File Offset: 0x000F0D1F
		public SQLCrossTableBuilder(string A_0, string A_1)
		{
			this.oo0.OoO0. = new List<oo0O__O0>();
			this.oo0.OoO0. = new Dictionary<string, string>();
			this.oo0.OoO0. = new Dictionary<string, DataTable>();
			base.TableName = A_0;
			this.BaseTable = A_1;
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x000F2B56 File Offset: 0x000F0D56
		public SQLCrossTableBuilder(string A_0, string A_1, string A_2)
		{
			this.oo0.OoO0. = new List<oo0O__O0>();
			this.oo0.OoO0. = new Dictionary<string, string>();
			this.oo0.OoO0. = new Dictionary<string, DataTable>();
			base.TableName = A_0;
			base.SelectString = A_1;
			base.ConnectionName = A_2;
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x000F2B94 File Offset: 0x000F0D94
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<ExpressionTotal> Exprs
		{
			get
			{
				return base.Totals.Exprs;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x000F2BA1 File Offset: 0x000F0DA1
		// (set) Token: 0x0600220B RID: 8715 RVA: 0x000F2BA9 File Offset: 0x000F0DA9
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string BaseTable
		{
			get
			{
				return this.oo0.OoO0.;
			}
			set
			{
				this.oo0.OoO0. = value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x000F2BB2 File Offset: 0x000F0DB2
		// (set) Token: 0x0600220D RID: 8717 RVA: 0x000F2BBA File Offset: 0x000F0DBA
		public override string ConnectionName
		{
			get
			{
				return base.ConnectionName;
			}
			set
			{
				base.ConnectionName = value;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x000F2BC3 File Offset: 0x000F0DC3
		internal bool AsyncExecute
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId != Main.OO_O.o.;
			}
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x000F2BDC File Offset: 0x000F0DDC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddTable(params object[] args)
		{
			if (args.Length >= 4)
			{
				string leftTable = Conversions.ToString(args[0]);
				string rightTable = Conversions.ToString(args[2]);
				int num = args.Length;
				if (num != 4)
				{
					if (num != 5)
					{
						return;
					}
					JoinModeEnum joinMode = (JoinModeEnum)Conversions.ToInteger(args[4]);
					if (args[1] is string && args[3] is string)
					{
						string leftCol = Conversions.ToString(args[1]);
						string rightCol = Conversions.ToString(args[3]);
						this.AddTable(leftTable, leftCol, rightTable, rightCol, joinMode);
						return;
					}
					if (args[1] is string[] && args[3] is string[])
					{
						string[] leftCol2 = (string[])args[1];
						string[] rightCol2 = (string[])args[3];
						this.AddTable(leftTable, leftCol2, rightTable, rightCol2, joinMode);
					}
				}
				else
				{
					if (args[1] is string && args[3] is string)
					{
						string leftCol3 = Conversions.ToString(args[1]);
						string rightCol3 = Conversions.ToString(args[3]);
						this.AddTable(leftTable, leftCol3, rightTable, rightCol3, JoinModeEnum.Inner);
						return;
					}
					if (args[1] is string[] && args[3] is string[])
					{
						string[] leftCol4 = (string[])args[1];
						string[] rightCol4 = (string[])args[3];
						this.AddTable(leftTable, leftCol4, rightTable, rightCol4, JoinModeEnum.Inner);
						return;
					}
				}
			}
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x000F2CF8 File Offset: 0x000F0EF8
		public void AddTable(string LeftTable, string[] LeftCol, string RightTable, string[] RightCol, JoinModeEnum JoinMode = JoinModeEnum.Inner)
		{
			oo0O__O0 item = new oo0O__O0(LeftTable, LeftCol, RightTable, RightCol, JoinMode);
			this.oo0.OoO0..Add(item);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x000F2D20 File Offset: 0x000F0F20
		public void AddTable(string LeftTable, string LeftCol, string RightTable, string RightCol, JoinModeEnum JoinMode = JoinModeEnum.Inner)
		{
			oo0O__O0 item = new oo0O__O0(LeftTable, new string[]
			{
				LeftCol
			}, RightTable, new string[]
			{
				RightCol
			}, JoinMode);
			this.oo0.OoO0..Add(item);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x000F2D58 File Offset: 0x000F0F58
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddCols(string Table, params string[] Cols)
		{
			foreach (string key in Cols)
			{
				this.oo0.OoO0..Add(key, Table);
			}
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x000F2D88 File Offset: 0x000F0F88
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override DataTable Build(params object[] args)
		{
			DataTable result;
			if (args.Length == 0)
			{
				result = this.Build();
			}
			else if (args.Length == 1 && args[1] is bool)
			{
				bool onlyDataTable = Conversions.ToBoolean(args[1]);
				result = this.Build(onlyDataTable);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x000F2DC9 File Offset: 0x000F0FC9
		public override DataTable Build()
		{
			return this.Build(false);
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x000F2DD4 File Offset: 0x000F0FD4
		public override DataTable Build(bool OnlyDataTable)
		{
			string a_ = OO_00oOO.MainTable.Name;
			if (OO_00oOO.DataTables.Contains(base.TableName) && !OnlyDataTable)
			{
				if (OO_00oOO.DataTables[base.TableName].AddByCode)
				{
					OO_00oOO.DataTables.Delete(base.TableName);
				}
				if (OO_00oOO.DataTables.Contains(base.TableName))
				{
					MessageBox.Show("表" + base.TableName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return null;
				}
			}
			DataTable result;
			if ((base.HGroups.Count == 0 && base.HGroups.Exprs.Count == 0) || (base.VGroups.Count == 0 && base.VGroups.Exprs.Count == 0) || (base.Totals.Count == 0 && base.Totals.Exprs.Count == 0))
			{
				result = null;
			}
			else
			{
				DataTable dataTable = this.BuildDataSource();
				DataTable dataTable2 = base.O0oo00.0O_oO_.(dataTable, OnlyDataTable, a_);
				if (base.Subtotal && !OnlyDataTable)
				{
					base.o_o00_O.0_oo.(dataTable2.Name, dataTable);
				}
				result = dataTable2;
			}
			return result;
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x000F2EF4 File Offset: 0x000F10F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new fxDataSource2 BuildDataSource2()
		{
			fxDataSource a_ = this.BuildDataSource();
			return new fxDataSource2(a_);
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x000F2F10 File Offset: 0x000F1110
		public override fxDataSource BuildDataSource()
		{
			int num;
			fxDataSource result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				SQLGroupTableBuilder sqlgroupTableBuilder = new SQLGroupTableBuilder();
				IL_10:
				num2 = 3;
				new List<GroupOn>();
				IL_18:
				num2 = 4;
				sqlgroupTableBuilder.TableName = OoOo0O.OO_o.0o_O.(6);
				IL_27:
				num2 = 5;
				sqlgroupTableBuilder.BaseTable = this.BaseTable;
				IL_36:
				num2 = 6;
				sqlgroupTableBuilder.Filter = base.Filter;
				IL_45:
				num2 = 7;
				sqlgroupTableBuilder.Decimals = base.Decimals;
				IL_54:
				num2 = 8;
				sqlgroupTableBuilder.ConnectionName = this.ConnectionName;
				IL_63:
				num2 = 9;
				sqlgroupTableBuilder.Groups.AddRange(base.HGroups);
				IL_78:
				num2 = 10;
				sqlgroupTableBuilder.Groups.Exprs.AddRange(base.HGroups.Exprs);
				IL_97:
				num2 = 11;
				sqlgroupTableBuilder.Totals.Exprs.AddRange(base.Totals.Exprs);
				IL_B6:
				num2 = 12;
				sqlgroupTableBuilder.oOo0OO._Ooo0_o. = this.oo0.OoO0.;
				IL_C6:
				num2 = 13;
				sqlgroupTableBuilder.O0__o_ooo0.O0O. = this.oo0.OoO0.;
				IL_D6:
				num2 = 14;
				sqlgroupTableBuilder.CommandTimeOut = base.CommandTimeOut;
				IL_E6:
				num2 = 15;
				List<CrossExpressionGroup>.Enumerator enumerator = base.VGroups.Exprs.GetEnumerator();
				while (enumerator.MoveNext())
				{
					CrossExpressionGroup crossExpressionGroup = enumerator.Current;
					IL_106:
					num2 = 16;
					ExpressionGroup item = new ExpressionGroup(crossExpressionGroup.Name, crossExpressionGroup.Expression, "");
					IL_123:
					num2 = 17;
					sqlgroupTableBuilder.Groups.Exprs.Add(item);
					IL_139:
					num2 = 18;
				}
				IL_145:
				num2 = 19;
				((IDisposable)enumerator).Dispose();
				IL_155:
				num2 = 20;
				IEnumerator<CrossGroupOn> enumerator2 = base.VGroups.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					CrossGroupOn crossGroupOn = enumerator2.Current;
					IL_170:
					num2 = 21;
					GroupOn groupOn = new GroupOn();
					IL_17A:
					num2 = 22;
					groupOn.Name = crossGroupOn.Name;
					IL_18B:
					num2 = 23;
					groupOn.NewName = crossGroupOn.NewName;
					IL_19C:
					num2 = 24;
					groupOn.DateGroup = crossGroupOn.DateGroup;
					IL_1AD:
					num2 = 25;
					groupOn.Pattern = crossGroupOn.Pattern;
					IL_1BE:
					num2 = 26;
					groupOn.Vertical = true;
					IL_1C9:
					num2 = 27;
					sqlgroupTableBuilder.Groups.Add(groupOn);
					IL_1DA:
					num2 = 28;
				}
				IL_1E6:
				num2 = 29;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_1F4:
				num2 = 30;
				IEnumerator<CrossTotalOn> enumerator3 = base.Totals.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					CrossTotalOn crossTotalOn = enumerator3.Current;
					IL_212:
					num2 = 31;
					TotalOn totalOn = new TotalOn();
					IL_21C:
					num2 = 32;
					totalOn.Name = crossTotalOn.Name;
					IL_22D:
					num2 = 33;
					totalOn.Aggregate = crossTotalOn.Aggregate;
					IL_23E:
					num2 = 34;
					totalOn.NewCaption = crossTotalOn.Caption;
					IL_24F:
					num2 = 35;
					totalOn.upto = crossTotalOn.upto;
					IL_260:
					num2 = 36;
					if (totalOn.upto)
					{
						IL_26C:
						num2 = 37;
						totalOn.NewName = totalOn.Name + "_up";
					}
					IL_287:
					num2 = 38;
					sqlgroupTableBuilder.Totals.Add(totalOn);
					IL_298:
					num2 = 39;
				}
				IL_2A7:
				num2 = 40;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_2B5:
				num2 = 41;
				DataTable a_ = sqlgroupTableBuilder.oo0Oo0.0Oo_.();
				IL_2C1:
				num2 = 42;
				List<ExpressionGroup>.Enumerator enumerator4 = base.HGroups.Exprs.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					ExpressionGroup expressionGroup = enumerator4.Current;
					IL_2E1:
					num2 = 43;
					GroupOn groupOn2 = new GroupOn();
					IL_2EB:
					num2 = 44;
					groupOn2.Name = expressionGroup.Name;
					IL_2FC:
					num2 = 45;
					groupOn2.NewCaption = expressionGroup.Caption;
					IL_30D:
					num2 = 46;
					sqlgroupTableBuilder.Groups.Add(groupOn2);
					IL_31E:
					num2 = 47;
				}
				IL_32A:
				num2 = 48;
				((IDisposable)enumerator4).Dispose();
				IL_33A:
				num2 = 49;
				List<CrossExpressionGroup>.Enumerator enumerator5 = base.VGroups.Exprs.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					CrossExpressionGroup crossExpressionGroup2 = enumerator5.Current;
					IL_35A:
					num2 = 50;
					GroupOn groupOn3 = new GroupOn();
					IL_364:
					num2 = 51;
					groupOn3.Name = crossExpressionGroup2.Name;
					IL_375:
					num2 = 52;
					groupOn3.Pattern = crossExpressionGroup2.Pattern;
					IL_386:
					num2 = 53;
					groupOn3.Vertical = true;
					IL_391:
					num2 = 54;
					sqlgroupTableBuilder.Groups.Add(groupOn3);
					IL_3A2:
					num2 = 55;
				}
				IL_3AE:
				num2 = 56;
				((IDisposable)enumerator5).Dispose();
				IL_3BE:
				num2 = 57;
				List<ExpressionTotal>.Enumerator enumerator6 = base.Totals.Exprs.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					ExpressionTotal expressionTotal = enumerator6.Current;
					IL_3E1:
					num2 = 58;
					TotalOn totalOn2 = new TotalOn();
					IL_3EB:
					num2 = 59;
					totalOn2.Name = expressionTotal.Name;
					IL_3FC:
					num2 = 60;
					totalOn2.NewCaption = Interaction.IIf(Operators.CompareString(expressionTotal.Caption, "", true) == 0, expressionTotal.Name, expressionTotal.Caption).ToString();
					IL_433:
					num2 = 61;
					totalOn2.Aggregate = expressionTotal.Aggregate;
					IL_444:
					num2 = 62;
					totalOn2.upto = expressionTotal.upto;
					IL_455:
					num2 = 63;
					sqlgroupTableBuilder.Totals.Add(totalOn2);
					IL_466:
					num2 = 64;
				}
				IL_475:
				num2 = 65;
				((IDisposable)enumerator6).Dispose();
				IL_485:
				num2 = 66;
				fxDataSource fxDataSource = base.o__.Ooo.(a_, sqlgroupTableBuilder);
				IL_494:
				num2 = 67;
				fxDataSource.O_O_O.00. = this;
				IL_49F:
				num2 = 68;
				result = fxDataSource;
				IL_4A5:
				goto IL_60B;
				IL_4AA:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_5CC:
				goto IL_600;
				IL_5CE:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_5DE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_5CE;
			}
			IL_600:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_60B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04000E2D RID: 3629
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E2E RID: 3630
		private List<oo0O__O0> <<EMPTY_NAME>>;

		// Token: 0x04000E2F RID: 3631
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000E30 RID: 3632
		private Dictionary<string, DataTable> <<EMPTY_NAME>>;

		// Token: 0x04000E31 RID: 3633
		private bool <<EMPTY_NAME>>;
	}
}
