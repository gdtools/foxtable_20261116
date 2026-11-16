using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 后台分组统计工具
	/// </summary>
	// Token: 0x0200029F RID: 671
	[oO0oooo("1626")]
	[ComVisible(true)]
	public class SQLGroupTableBuilder : GroupTableBuilder
	{
		// Token: 0x06002218 RID: 8728 RVA: 0x000F3550 File Offset: 0x000F1750
		public SQLGroupTableBuilder()
		{
			this.oOo0OO._Ooo0_o. = new List<oo0O__O0>();
			this.O0__o_ooo0.O0O. = new Dictionary<string, string>();
			this.oOo0OO._Ooo0_o. = DataServerTypeEnum.Access;
			this.FromServer = true;
		}

		/// <param name="TableName">即将生成的统计表的名称</param>
		/// <param name="BaseTable">基表名称</param>
		// Token: 0x06002219 RID: 8729 RVA: 0x000F357C File Offset: 0x000F177C
		public SQLGroupTableBuilder(string A_0, string A_1)
		{
			this.oOo0OO._Ooo0_o. = new List<oo0O__O0>();
			this.O0__o_ooo0.O0O. = new Dictionary<string, string>();
			this.oOo0OO._Ooo0_o. = DataServerTypeEnum.Access;
			this.FromServer = true;
			base.TableName = A_0;
			this.BaseTable = A_1;
		}

		/// <param name="TableName">即将生成的统计表的名称</param>
		/// <param name="SelectString">Select语句</param>
		/// <param name="ConnectionName">数据源名称</param>
		// Token: 0x0600221A RID: 8730 RVA: 0x000F35B8 File Offset: 0x000F17B8
		public SQLGroupTableBuilder(string A_0, string A_1, string A_2)
		{
			this.oOo0OO._Ooo0_o. = new List<oo0O__O0>();
			this.O0__o_ooo0.O0O. = new Dictionary<string, string>();
			this.oOo0OO._Ooo0_o. = DataServerTypeEnum.Access;
			this.FromServer = true;
			base.TableName = A_0;
			base.SelectString = A_1;
			base.ConnectionName = A_2;
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x000F3604 File Offset: 0x000F1804
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<ExpressionTotal> Exprs
		{
			get
			{
				return base.Totals.Exprs;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x000F3611 File Offset: 0x000F1811
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x000F3619 File Offset: 0x000F1819
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string BaseTable
		{
			get
			{
				return this.O0__o_ooo0.O0O.;
			}
			set
			{
				this.O0__o_ooo0.O0O. = value;
			}
		}

		/// <summary>
		/// 数据源名称
		/// </summary>
		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x000F3622 File Offset: 0x000F1822
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x000F362A File Offset: 0x000F182A
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

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x000F3633 File Offset: 0x000F1833
		internal bool AsyncExecute
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId != Main.OO_O.o.;
			}
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x000F364C File Offset: 0x000F184C
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

		/// <summary>
		/// 添加数据表
		/// </summary>
		/// <param name="LeftTable">基表，或者已经添加的数据表，称之为左表</param>
		/// <param name="LeftCol">左表关联列</param>
		/// <param name="RightTable">要添加的统计表，称为右表</param>
		/// <param name="RightCol">右表关联列</param>
		/// <param name="JoinMode">连接方式</param>
		// Token: 0x06002222 RID: 8738 RVA: 0x000F3768 File Offset: 0x000F1968
		public void AddTable(string LeftTable, string LeftCol, string RightTable, string RightCol, JoinModeEnum JoinMode = JoinModeEnum.Inner)
		{
			oo0O__O0 item = new oo0O__O0(LeftTable, new string[]
			{
				LeftCol
			}, RightTable, new string[]
			{
				RightCol
			}, JoinMode);
			this.oOo0OO._Ooo0_o..Add(item);
		}

		/// <summary>
		/// 添加数据表
		/// </summary>
		/// <param name="LeftTable">基表，或者已经添加的数据表，称之为左表</param>
		/// <param name="LeftCol">左表关联列数组</param>
		/// <param name="RightTable">要添加的统计表，称为右表</param>
		/// <param name="RightCol">右表关联列数组</param>
		/// <param name="JoinMode">连接方式</param>
		// Token: 0x06002223 RID: 8739 RVA: 0x000F37A0 File Offset: 0x000F19A0
		public void AddTable(string LeftTable, string[] LeftCol, string RightTable, string[] RightCol, JoinModeEnum JoinMode = JoinModeEnum.Inner)
		{
			oo0O__O0 item = new oo0O__O0(LeftTable, LeftCol, RightTable, RightCol, JoinMode);
			this.oOo0OO._Ooo0_o..Add(item);
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x000F37C8 File Offset: 0x000F19C8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddCols(string Table, params string[] Cols)
		{
			foreach (string key in Cols)
			{
				this.O0__o_ooo0.O0O..Add(key, Table);
			}
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x000F37F8 File Offset: 0x000F19F8
		internal DataTable <<EMPTY_NAME>>()
		{
			this.O0__o_ooo0.O0O.();
			DataTable a_ = this.o0_._00OOOoo0O.();
			return this.O0__o_ooo0.O0O.(a_);
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x000F381C File Offset: 0x000F1A1C
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

		/// <summary>
		/// 生成统计表
		/// </summary>
		// Token: 0x06002227 RID: 8743 RVA: 0x000F385D File Offset: 0x000F1A5D
		public override DataTable Build()
		{
			return this.Build(false);
		}

		/// <summary>
		/// 生成统计表
		/// </summary>
		/// <param name="OnlyDataTable">是否只生成DataTable，不生成Table</param>
		// Token: 0x06002228 RID: 8744 RVA: 0x000F3868 File Offset: 0x000F1A68
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
			DataTable dataTable = this.BuildDataSource();
			DataTable dataTable2 = base.oO_oO._O__O.(dataTable, OnlyDataTable, a_);
			if (base.Subtotal && !OnlyDataTable)
			{
				base.oO0.O00oO.(dataTable2.Name, dataTable);
			}
			return dataTable2;
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x000F3924 File Offset: 0x000F1B24
		private void <<EMPTY_NAME>>()
		{
			if (base.SourceDataTable != null)
			{
				if (Operators.CompareString(base.SourceDataTable.DataServer, "", true) > 0)
				{
					this.oOo0OO._Ooo0_o. = O_O0OO.OoO__.0oO0oo.()[base.SourceDataTable.ConnectionName].OO.OoO0.;
					this.o.O0__OO. = O_O0OO.OoO__.0oO0oo.()[base.SourceDataTable.ConnectionName].oO0_0.o.();
					return;
				}
				if (o_O_o_oOoo__.OOOO_OO._oo.(base.SourceDataTable.frd_Connection))
				{
					this.oOo0OO._Ooo0_o. = DataServerTypeEnum.SqlServer;
					return;
				}
				if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(base.SourceDataTable.frd_Connection))
				{
					this.oOo0OO._Ooo0_o. = DataServerTypeEnum.Oracle;
					return;
				}
			}
			else if (Operators.CompareString(this.ConnectionName, "", true) > 0)
			{
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.ConnectionName))
				{
					this.oOo0OO._Ooo0_o. = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].OO.OoO0.;
					this.o.O0__OO. = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].oO0_0.o.();
					return;
				}
				if (O_O0OO.O._o_.().ContainsKey(this.ConnectionName))
				{
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()[this.ConnectionName]))
					{
						this.oOo0OO._Ooo0_o. = DataServerTypeEnum.Oracle;
						return;
					}
					if (o_O_o_oOoo__.OOOO_OO._oo.(O_O0OO.O._o_.()[this.ConnectionName]))
					{
						this.oOo0OO._Ooo0_o. = DataServerTypeEnum.SqlServer;
					}
				}
			}
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x000F3A7C File Offset: 0x000F1C7C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new fxDataSource2 BuildDataSource2()
		{
			fxDataSource a_ = this.BuildDataSource();
			return new fxDataSource2(a_);
		}

		/// <summary>
		/// 生成一个可以直接绑定到Table的DataSource属性的对象
		/// </summary>
		// Token: 0x0600222B RID: 8747 RVA: 0x000F3A98 File Offset: 0x000F1C98
		public new fxDataSource BuildDataSource()
		{
			this.O0__o_ooo0.O0O.();
			DataTable dataTable = this.o0_._00OOOoo0O.();
			fxDataSource fxDataSource = this.O0__o_ooo0.O0O.(dataTable);
			try
			{
				foreach (ExpressionGroup expressionGroup in base.Groups.Exprs)
				{
					fxDataSource.Columns[expressionGroup.Name].Caption = expressionGroup.Caption;
					GroupOn groupOn = new GroupOn();
					groupOn.Name = expressionGroup.Name;
					groupOn.NewCaption = expressionGroup.Caption;
					base.Groups.Add(groupOn);
				}
			}
			finally
			{
				List<ExpressionGroup>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (ExpressionTotal expressionTotal in base.Totals.Exprs)
				{
					fxDataSource.Columns[expressionTotal.Name].Caption = expressionTotal.Caption;
					TotalOn totalOn = new TotalOn();
					totalOn.Name = expressionTotal.Name;
					totalOn.NewName = expressionTotal.Name;
					totalOn.NewCaption = expressionTotal.Caption;
					totalOn.Aggregate = expressionTotal.Aggregate;
					totalOn.upto = expressionTotal.upto;
					base.Totals.Add(totalOn);
				}
			}
			finally
			{
				List<ExpressionTotal>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			base.oO0O.__o_OO_oo.(fxDataSource, dataTable);
			fxDataSource.O_O_O.00. = this;
			return fxDataSource;
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x000F3C1C File Offset: 0x000F1E1C
		private DataTable <<EMPTY_NAME>>()
		{
			int num;
			DataTable result;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = "";
				IL_10:
				num2 = 3;
				DataTable dataTable = new DataTable();
				IL_19:
				num2 = 4;
				if (!this.BaseTable.StartsWith("[") || !this.BaseTable.EndsWith("]"))
				{
					goto IL_4B;
				}
				IL_3F:
				num2 = 5;
				string text2 = this.BaseTable;
				goto IL_64;
				IL_4B:
				num2 = 7;
				text2 = "{" + this.BaseTable + "}";
				IL_64:
				num2 = 8;
				if (Operators.CompareString(base.SelectString, "", true) <= 0)
				{
					goto IL_94;
				}
				IL_7A:
				num2 = 9;
				text2 = "(" + base.SelectString + ") tmptbl";
				IL_94:
				num2 = 10;
				IEnumerator<GroupOn> enumerator = base.Groups.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GroupOn groupOn = enumerator.Current;
					IL_B2:
					num2 = 11;
					if (this.O0__o_ooo0.O0O..ContainsKey(groupOn.Name))
					{
						IL_C9:
						num2 = 12;
						text = string.Concat(new string[]
						{
							text,
							"{",
							this.O0__o_ooo0.O0O.[groupOn.Name],
							"}.[",
							groupOn.Name,
							"],"
						});
					}
					else
					{
						IL_117:
						num2 = 14;
						if (groupOn.Name.IndexOf(".") > 0)
						{
							IL_12E:
							num2 = 15;
							text = text + groupOn.Name + ",";
						}
						else
						{
							IL_148:
							num2 = 17;
							text = text + "[" + groupOn.Name + "],";
						}
					}
					IL_165:
					num2 = 18;
				}
				IL_174:
				num2 = 19;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_182:
				num2 = 20;
				List<ExpressionGroup>.Enumerator enumerator2 = base.Groups.Exprs.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ExpressionGroup expressionGroup = enumerator2.Current;
					IL_1A2:
					num2 = 21;
					text = string.Concat(new string[]
					{
						text,
						"(",
						expressionGroup.Expression,
						") As [",
						expressionGroup.Name,
						"],"
					});
					IL_1E3:
					num2 = 22;
				}
				IL_1EF:
				num2 = 23;
				((IDisposable)enumerator2).Dispose();
				IL_1FF:
				num2 = 24;
				IEnumerator<TotalOn> enumerator3 = base.Totals.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					TotalOn totalOn = enumerator3.Current;
					IL_21D:
					num2 = 25;
					if (this.O0__o_ooo0.O0O..ContainsKey(totalOn.Name))
					{
						IL_234:
						num2 = 26;
						text = string.Concat(new string[]
						{
							text,
							"{",
							this.O0__o_ooo0.O0O.[totalOn.Name],
							"}.[",
							totalOn.Name,
							"],"
						});
					}
					else
					{
						IL_282:
						num2 = 28;
						if (totalOn.Name.IndexOf(".") > 0)
						{
							IL_299:
							num2 = 29;
							text = text + totalOn.Name + ",";
						}
						else
						{
							IL_2B3:
							num2 = 31;
							text = text + "[" + totalOn.Name + "],";
						}
					}
					IL_2D0:
					num2 = 32;
				}
				IL_2DF:
				num2 = 33;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_2ED:
				num2 = 34;
				List<ExpressionTotal>.Enumerator enumerator4 = base.Totals.Exprs.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					ExpressionTotal expressionTotal = enumerator4.Current;
					IL_30D:
					num2 = 35;
					text = string.Concat(new string[]
					{
						text,
						"(",
						expressionTotal.Expression,
						") As [",
						expressionTotal.Name,
						"],"
					});
					IL_34E:
					num2 = 36;
				}
				IL_35A:
				num2 = 37;
				((IDisposable)enumerator4).Dispose();
				IL_36A:
				num2 = 38;
				text = text.Trim(new char[]
				{
					','
				});
				IL_381:
				num2 = 39;
				int num3 = this.oOo0OO._Ooo0_o..Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_39B:
					num2 = 40;
					oo0O__O0 oo0O__O = this.oOo0OO._Ooo0_o.[i];
					IL_3AD:
					num2 = 41;
					string name = Enum.GetName(typeof(JoinModeEnum), oo0O__O.oO_0o_.oOO0.);
					IL_3CD:
					num2 = 42;
					text2 = string.Concat(new string[]
					{
						text2,
						" ",
						name,
						" JOIN {",
						oo0O__O.o0O___o_o_0o.o.,
						"} ON {",
						oo0O__O.o0O___o_o_0o.o.,
						"}.[",
						oo0O__O.oO_0o_.oOO0.[0],
						"] = {",
						oo0O__O.O_o.O00Oo.,
						"}.[",
						oo0O__O.Column[0],
						"]"
					});
					IL_45B:
					num2 = 43;
					if (oo0O__O.Column.Length > 1)
					{
						IL_46D:
						num2 = 44;
						int num4 = oo0O__O.Column.Length - 1;
						for (int j = 1; j <= num4; j++)
						{
							IL_482:
							num2 = 45;
							text2 = string.Concat(new string[]
							{
								text2,
								" And {",
								oo0O__O.o0O___o_o_0o.o.,
								"}.[",
								oo0O__O.oO_0o_.oOO0.[j],
								"] = {",
								oo0O__O.O_o.O00Oo.,
								"}.[",
								oo0O__O.Column[j],
								"]"
							});
							IL_4EF:
							num2 = 46;
						}
					}
					IL_4FE:
					num2 = 47;
					if (i < this.oOo0OO._Ooo0_o..Count - 1)
					{
						IL_512:
						num2 = 48;
						text2 = "(" + text2 + ")";
					}
					IL_528:
					num2 = 49;
				}
				IL_53A:
				num2 = 50;
				string text3 = "Select " + text + " From " + text2;
				IL_552:
				num2 = 51;
				if (this.o.O0__OO. != null)
				{
					goto IL_750;
				}
				IL_560:
				num2 = 52;
				OleDbConnection oleDbConnection = null;
				IL_566:
				num2 = 53;
				if (Operators.CompareString(this.ConnectionName, "", true) <= 0)
				{
					goto IL_642;
				}
				IL_580:
				num2 = 54;
				if (!O_O0OO.O._o_.().ContainsKey(this.ConnectionName))
				{
					goto IL_5AC;
				}
				IL_595:
				num2 = 55;
				oleDbConnection = O_O0OO.O._o_.()[this.ConnectionName];
				goto IL_60B;
				IL_5AC:
				num2 = 57;
				Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator5 = O_O0OO.O._o_.().Keys.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					string text4 = enumerator5.Current;
					IL_5CB:
					num2 = 58;
					if (Operators.CompareString(text4, this.ConnectionName, true) == 0)
					{
						IL_5DE:
						num2 = 59;
						oleDbConnection = O_O0OO.O._o_.()[text4];
					}
					IL_5EF:
					num2 = 60;
				}
				IL_5FB:
				num2 = 61;
				((IDisposable)enumerator5).Dispose();
				IL_60B:
				num2 = 62;
				if (oleDbConnection != null)
				{
					goto IL_657;
				}
				IL_612:
				num2 = 63;
				MessageBox.Show("不存在名为\"" + this.ConnectionName + "\"的数据源!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_638:
				num2 = 64;
				result = null;
				goto IL_7D7;
				IL_642:
				num2 = 66;
				if (this.o.O0__OO. != null)
				{
					goto IL_657;
				}
				IL_64D:
				num2 = 67;
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.();
				IL_657:
				num2 = 68;
				text3 = Oo00.o0_o._O_.(oleDbConnection, text3, false);
				IL_666:
				num2 = 69;
				if (!this.AsyncExecute)
				{
					goto IL_682;
				}
				IL_671:
				num2 = 70;
				oleDbConnection = new OleDbConnection(oleDbConnection.ConnectionString);
				IL_682:
				num2 = 71;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text3, oleDbConnection);
				IL_690:
				num2 = 72;
				oleDbDataAdapter.SelectCommand.CommandTimeout = base.CommandTimeOut;
				IL_6A5:
				num2 = 73;
				Information.Err().Clear();
				IL_6B2:
				num2 = 74;
				if (!this.AsyncExecute)
				{
					goto IL_6C7;
				}
				IL_6BD:
				num2 = 75;
				oleDbConnection.Open();
				IL_6C7:
				num2 = 76;
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				IL_6D5:
				num2 = 77;
				if (!this.AsyncExecute)
				{
					goto IL_6EA;
				}
				IL_6E0:
				num2 = 78;
				oleDbConnection.Close();
				IL_6EA:
				num2 = 79;
				if (Information.Err().Number == 0)
				{
					goto IL_71E;
				}
				IL_6F9:
				num2 = 80;
				MessageBox.Show("统计错误，错误提示：\r\n" + Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				IL_71E:
				num2 = 81;
				if (dataTable.Columns.Count != 0)
				{
					goto IL_745;
				}
				IL_72F:
				num2 = 82;
				MessageBox.Show("生成的SQL语句错误，无法继续统计！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_745:
				num2 = 83;
				result = dataTable;
				goto IL_7D7;
				IL_750:
				num2 = 85;
				text3 = Oo00.o0_o._O_.(this.oOo0OO._Ooo0_o., text3, false);
				IL_763:
				num2 = 86;
				this.o.O0__OO..FormData["IgnoreSchema"] = "True";
				IL_780:
				num2 = 87;
				this.o.O0__OO..FormData["Action"] = 12.ToString();
				IL_7A3:
				num2 = 88;
				this.o.O0__OO..Select = text3;
				IL_7B3:
				num2 = 89;
				dataTable = this.o.O0__OO..GetBaseDataTable();
				IL_7C3:
				num2 = 90;
				this.o.O0__OO..Reset();
				IL_7D1:
				num2 = 91;
				result = dataTable;
				IL_7D7:
				goto IL_999;
				IL_7DC:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_95A:
				goto IL_98E;
				IL_95C:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_96C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_95C;
			}
			IL_98E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_999:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x000F45E8 File Offset: 0x000F27E8
		private fxDataSource <<EMPTY_NAME>>(DataTable A_0)
		{
			int num;
			fxDataSource result;
			int num6;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				fxDataSource fxDataSource = new fxDataSource();
				IL_10:
				num2 = 3;
				string text = "";
				IL_19:
				num2 = 4;
				string text2 = "";
				IL_22:
				num2 = 5;
				if (!this.BaseTable.StartsWith("[") || !this.BaseTable.EndsWith("]"))
				{
					goto IL_54;
				}
				IL_48:
				num2 = 6;
				string text3 = this.BaseTable;
				goto IL_6D;
				IL_54:
				num2 = 8;
				text3 = "{" + this.BaseTable + "}";
				IL_6D:
				num2 = 9;
				OleDbConnection oleDbConnection = null;
				IL_73:
				num2 = 10;
				if (Operators.CompareString(base.SelectString, "", true) <= 0)
				{
					goto IL_A4;
				}
				IL_8A:
				num2 = 11;
				text3 = "(" + base.SelectString + ") tmptbl";
				IL_A4:
				num2 = 12;
				IEnumerator<GroupOn> enumerator = base.Groups.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GroupOn groupOn = enumerator.Current;
					IL_C2:
					num2 = 13;
					if (Operators.CompareString(text, "", true) > 0)
					{
						IL_D5:
						num2 = 14;
						text += ",";
					}
					IL_E6:
					num2 = 15;
					if (Operators.CompareString(text2, "", true) > 0)
					{
						IL_F9:
						num2 = 16;
						text2 += ",";
					}
					IL_10A:
					num2 = 17;
					if (A_0.Columns[groupOn.SourceName].DataType == typeof(DateTime) && groupOn.DateGroup != DateGroupEnum.None)
					{
						IL_13F:
						num2 = 18;
						groupOn.IsDate = true;
						IL_14A:
						num2 = 19;
						string text4;
						if (this.O0__o_ooo0.O0O..ContainsKey(groupOn.Name))
						{
							IL_161:
							num2 = 20;
							text4 = this.O0__o_ooo0.O0O.[groupOn.Name];
						}
						else
						{
							IL_17A:
							num2 = 22;
							if (groupOn.Name.IndexOf(".") > 0)
							{
								IL_191:
								num2 = 23;
								text4 = groupOn.Name.Substring(0, groupOn.Name.IndexOf("."));
								IL_1B4:
								num2 = 24;
								text4 = text4.Trim(new char[]
								{
									'{',
									'}'
								});
							}
							else
							{
								IL_1D2:
								num2 = 26;
								text4 = "";
							}
						}
						IL_1DC:
						num2 = 27;
						string str = o_O_o_oOoo__.OO_O0oO0.oooO_.(text4, groupOn.SourceName, groupOn.DateGroup, this.oOo0OO._Ooo0_o.);
						IL_1FC:
						num2 = 28;
						text += str;
						IL_20A:
						num2 = 29;
						text2 += str;
						IL_218:
						num2 = 30;
						text = text + " As [" + groupOn.NewName + "]";
					}
					else
					{
						IL_23A:
						num2 = 32;
						string str2;
						if (this.O0__o_ooo0.O0O..ContainsKey(groupOn.Name))
						{
							IL_251:
							num2 = 33;
							str2 = string.Concat(new string[]
							{
								"{",
								this.O0__o_ooo0.O0O.[groupOn.Name],
								"}.[",
								groupOn.Name,
								"]"
							});
						}
						else
						{
							IL_29A:
							num2 = 35;
							if (groupOn.Name.IndexOf(".") > 0)
							{
								IL_2B1:
								num2 = 36;
								str2 = groupOn.Name;
							}
							else
							{
								IL_2BF:
								num2 = 38;
								str2 = "[" + groupOn.Name + "]";
							}
						}
						IL_2DA:
						num2 = 39;
						text += str2;
						IL_2E8:
						num2 = 40;
						text2 += str2;
						IL_2F6:
						num2 = 41;
						if (Operators.CompareString(groupOn.Name, groupOn.NewName, true) != 0)
						{
							IL_30F:
							num2 = 42;
							text = text + " As [" + groupOn.NewName + "]";
						}
					}
					IL_32C:
					num2 = 43;
				}
				IL_33B:
				num2 = 44;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_349:
				num2 = 45;
				List<ExpressionGroup>.Enumerator enumerator2 = base.Groups.Exprs.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ExpressionGroup expressionGroup = enumerator2.Current;
					IL_36C:
					num2 = 46;
					if (Operators.CompareString(text, "", true) > 0)
					{
						IL_37F:
						num2 = 47;
						text += ",";
					}
					IL_390:
					num2 = 48;
					if (Operators.CompareString(text2, "", true) > 0)
					{
						IL_3A3:
						num2 = 49;
						text2 += ",";
					}
					IL_3B4:
					num2 = 50;
					text = string.Concat(new string[]
					{
						text,
						"(",
						expressionGroup.Expression,
						") As [",
						expressionGroup.Name,
						"]"
					});
					IL_3F5:
					num2 = 51;
					text2 = text2 + "(" + expressionGroup.Expression + ")";
					IL_412:
					num2 = 52;
				}
				IL_421:
				num2 = 53;
				((IDisposable)enumerator2).Dispose();
				IL_431:
				num2 = 54;
				IEnumerator<TotalOn> enumerator3 = base.Totals.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					TotalOn totalOn = enumerator3.Current;
					IL_44F:
					num2 = 55;
					string text5 = "";
					IL_459:
					num2 = 56;
					if (this.O0__o_ooo0.O0O..ContainsKey(totalOn.Name))
					{
						IL_470:
						num2 = 57;
						text5 = string.Concat(new string[]
						{
							"({",
							this.O0__o_ooo0.O0O.[totalOn.Name],
							"}.[",
							totalOn.Name,
							"]) As [",
							totalOn.NewName,
							"]"
						});
					}
					else
					{
						IL_4CE:
						num2 = 59;
						if (totalOn.Name.IndexOf(".") > 0)
						{
							IL_4E8:
							num2 = 60;
							if (Operators.CompareString(totalOn.Name, totalOn.NewName, true) != 0)
							{
								IL_501:
								num2 = 61;
								text5 = string.Concat(new string[]
								{
									"(",
									totalOn.Name,
									") As [",
									totalOn.NewName,
									"]"
								});
							}
							else
							{
								IL_542:
								num2 = 63;
								string[] array = totalOn.Name.Split(new char[]
								{
									'.'
								});
								IL_55E:
								num2 = 64;
								array[1] = array[1].Trim(new char[]
								{
									'[',
									']'
								});
								IL_57E:
								num2 = 65;
								text5 = string.Concat(new string[]
								{
									"(",
									totalOn.Name,
									") As [",
									array[1],
									"]"
								});
							}
						}
						else
						{
							IL_5B9:
							num2 = 67;
							text5 = string.Concat(new string[]
							{
								"([",
								totalOn.Name,
								"]) As [",
								totalOn.NewName,
								"]"
							});
						}
					}
					IL_5F5:
					num2 = 68;
					switch (totalOn.Aggregate)
					{
					case AggregateEnum.Sum:
						IL_628:
						num2 = 70;
						text5 = "Sum" + text5;
						break;
					case AggregateEnum.Count:
						IL_64E:
						num2 = 74;
						text5 = "Count" + text5;
						break;
					case AggregateEnum.Average:
						IL_63B:
						num2 = 72;
						text5 = "Avg" + text5;
						break;
					case AggregateEnum.Max:
						IL_661:
						num2 = 76;
						text5 = "Max" + text5;
						break;
					case AggregateEnum.Min:
						IL_674:
						num2 = 78;
						text5 = "Min" + text5;
						break;
					}
					IL_685:
					num2 = 80;
					text = text + "," + text5;
					IL_698:
					num2 = 81;
				}
				IL_6A7:
				num2 = 82;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_6B5:
				num2 = 83;
				List<ExpressionTotal>.Enumerator enumerator4 = base.Totals.Exprs.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					ExpressionTotal expressionTotal = enumerator4.Current;
					IL_6D8:
					num2 = 84;
					string text6 = string.Concat(new string[]
					{
						"(",
						expressionTotal.Expression,
						") As [",
						expressionTotal.Name,
						"]"
					});
					IL_714:
					num2 = 85;
					switch (expressionTotal.Aggregate)
					{
					case AggregateEnum.Sum:
						IL_747:
						num2 = 87;
						text6 = "Sum" + text6;
						break;
					case AggregateEnum.Count:
						IL_76D:
						num2 = 91;
						text6 = "Count" + text6;
						break;
					case AggregateEnum.Average:
						IL_75A:
						num2 = 89;
						text6 = "Avg" + text6;
						break;
					case AggregateEnum.Max:
						IL_780:
						num2 = 93;
						text6 = "Max" + text6;
						break;
					case AggregateEnum.Min:
						IL_793:
						num2 = 95;
						text6 = "Min" + text6;
						break;
					}
					IL_7A4:
					num2 = 97;
					text = text + "," + text6;
					IL_7B7:
					num2 = 98;
				}
				IL_7C6:
				num2 = 99;
				((IDisposable)enumerator4).Dispose();
				IL_7D6:
				num2 = 100;
				int num3 = this.oOo0OO._Ooo0_o..Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_7F0:
					num2 = 101;
					oo0O__O0 oo0O__O = this.oOo0OO._Ooo0_o.[i];
					IL_802:
					num2 = 102;
					string name = Enum.GetName(typeof(JoinModeEnum), oo0O__O.oO_0o_.oOO0.);
					IL_822:
					num2 = 103;
					text3 = string.Concat(new string[]
					{
						text3,
						" ",
						name,
						" JOIN {",
						oo0O__O.o0O___o_o_0o.o.,
						"} ON {",
						oo0O__O.o0O___o_o_0o.o.,
						"}.[",
						oo0O__O.oO_0o_.oOO0.[0],
						"] = {",
						oo0O__O.O_o.O00Oo.,
						"}.[",
						oo0O__O.Column[0],
						"]"
					});
					IL_8B0:
					num2 = 104;
					if (oo0O__O.Column.Length > 1)
					{
						IL_8C2:
						num2 = 105;
						int num4 = oo0O__O.Column.Length - 1;
						for (int j = 1; j <= num4; j++)
						{
							IL_8D7:
							num2 = 106;
							text3 = string.Concat(new string[]
							{
								text3,
								" And {",
								oo0O__O.o0O___o_o_0o.o.,
								"}.[",
								oo0O__O.oO_0o_.oOO0.[j],
								"] = {",
								oo0O__O.O_o.O00Oo.,
								"}.[",
								oo0O__O.Column[j],
								"]"
							});
							IL_944:
							num2 = 107;
						}
					}
					IL_953:
					num2 = 108;
					if (i < this.oOo0OO._Ooo0_o..Count - 1)
					{
						IL_967:
						num2 = 109;
						text3 = "(" + text3 + ")";
					}
					IL_97D:
					num2 = 110;
				}
				IL_98F:
				num2 = 111;
				string text7 = "Select " + text + " From " + text3;
				IL_9A7:
				num2 = 112;
				if (Operators.CompareString(base.Filter, "", true) <= 0)
				{
					goto IL_9D5;
				}
				IL_9BE:
				num2 = 113;
				text7 = text7 + " Where " + base.Filter;
				IL_9D5:
				num2 = 114;
				text7 = text7 + " Group By " + text2;
				IL_9E8:
				num2 = 115;
				text7 = text7 + " ORDER BY " + text2;
				IL_9FB:
				num2 = 116;
				if (this.o.O0__OO. != null)
				{
					goto IL_BAF;
				}
				IL_A09:
				num2 = 117;
				if (Operators.CompareString(this.ConnectionName, "", true) <= 0)
				{
					goto IL_AB0;
				}
				IL_A23:
				num2 = 118;
				if (!O_O0OO.O._o_.().ContainsKey(this.ConnectionName))
				{
					goto IL_A4F;
				}
				IL_A38:
				num2 = 119;
				oleDbConnection = O_O0OO.O._o_.()[this.ConnectionName];
				goto IL_ABA;
				IL_A4F:
				num2 = 121;
				Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator5 = O_O0OO.O._o_.().Keys.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					string text8 = enumerator5.Current;
					IL_A6E:
					num2 = 122;
					if (Operators.CompareString(text8, this.ConnectionName, true) == 0)
					{
						IL_A81:
						num2 = 123;
						oleDbConnection = O_O0OO.O._o_.()[text8];
					}
					IL_A92:
					num2 = 124;
				}
				IL_A9E:
				num2 = 125;
				((IDisposable)enumerator5).Dispose();
				goto IL_ABA;
				IL_AB0:
				num2 = 127;
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.();
				IL_ABA:
				num2 = 128;
				text7 = Oo00.o0_o._O_.(oleDbConnection, text7, false);
				IL_ACC:
				num2 = 129;
				if (!this.AsyncExecute)
				{
					goto IL_AEE;
				}
				IL_ADA:
				num2 = 130;
				oleDbConnection = new OleDbConnection(oleDbConnection.ConnectionString);
				IL_AEE:
				num2 = 131;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text7, oleDbConnection);
				IL_AFF:
				num2 = 132;
				oleDbDataAdapter.SelectCommand.CommandTimeout = base.CommandTimeOut;
				IL_B17:
				num2 = 133;
				Information.Err().Clear();
				IL_B27:
				num2 = 134;
				if (!this.AsyncExecute)
				{
					goto IL_B42;
				}
				IL_B35:
				num2 = 135;
				oleDbConnection.Open();
				IL_B42:
				num2 = 136;
				oleDbDataAdapter.Fill(fxDataSource);
				IL_B52:
				num2 = 137;
				if (!this.AsyncExecute)
				{
					goto IL_B6D;
				}
				IL_B60:
				num2 = 138;
				oleDbConnection.Close();
				IL_B6D:
				num2 = 139;
				if (Information.Err().Number == 0)
				{
					goto IL_C5A;
				}
				IL_B82:
				num2 = 140;
				MessageBox.Show("统计错误，错误原因：\r\n" + Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				goto IL_C5A;
				IL_BAF:
				num2 = 142;
				text7 = Oo00.o0_o._O_.(this.oOo0OO._Ooo0_o., text7, false);
				IL_BC5:
				num2 = 143;
				this.o.O0__OO..Select = text7;
				IL_BD8:
				num2 = 144;
				this.o.O0__OO..FormData["IgnoreSchema"] = "True";
				IL_BF8:
				num2 = 145;
				this.o.O0__OO..FormData["Action"] = 2.ToString();
				IL_C1D:
				num2 = 146;
				DataTable baseDataTable = this.o.O0__OO..GetBaseDataTable();
				IL_C30:
				num2 = 147;
				if (baseDataTable == null || baseDataTable.Columns.Count <= 0)
				{
					goto IL_C5A;
				}
				IL_C49:
				num2 = 148;
				fxDataSource.Merge(baseDataTable, false, MissingSchemaAction.Add);
				IL_C5A:
				num2 = 149;
				IEnumerator enumerator6 = fxDataSource.Columns.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					object obj = enumerator6.Current;
					DataColumn dataColumn = (DataColumn)obj;
					IL_C81:
					num2 = 150;
					if (dataColumn.DataType == typeof(double) || dataColumn.DataType == typeof(float) || dataColumn.DataType == typeof(decimal))
					{
						IL_CC3:
						num2 = 151;
						IEnumerator enumerator7 = fxDataSource.Rows.GetEnumerator();
						while (enumerator7.MoveNext())
						{
							object obj2 = enumerator7.Current;
							DataRow dataRow = (DataRow)obj2;
							IL_CE7:
							num2 = 152;
							if (!dataRow.IsNull(dataColumn))
							{
								IL_CF8:
								num2 = 153;
								dataRow[dataColumn] = Math.Round(Conversions.ToDecimal(dataRow[dataColumn]), base.Decimals);
							}
							IL_D25:
							num2 = 154;
						}
						IL_D34:
						num2 = 155;
						if (enumerator7 is IDisposable)
						{
							(enumerator7 as IDisposable).Dispose();
						}
					}
					IL_D4F:
					num2 = 156;
				}
				IL_D61:
				num2 = 157;
				if (enumerator6 is IDisposable)
				{
					(enumerator6 as IDisposable).Dispose();
				}
				IL_D7C:
				num2 = 158;
				IEnumerator<GroupOn> enumerator8 = base.Groups.GetEnumerator();
				while (enumerator8.MoveNext())
				{
					GroupOn groupOn2 = enumerator8.Current;
					IL_D9A:
					num2 = 159;
					groupOn2.Name = groupOn2.SourceName;
					IL_DAE:
					num2 = 160;
				}
				IL_DBD:
				num2 = 161;
				if (enumerator8 != null)
				{
					enumerator8.Dispose();
				}
				IL_DCE:
				num2 = 162;
				result = fxDataSource;
				IL_DD7:
				goto IL_10B5;
				IL_DDC:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_1076:
				goto IL_10AA;
				IL_1078:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1088:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_1078;
			}
			IL_10AA:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_10B5:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x000F56D0 File Offset: 0x000F38D0
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x000F56D8 File Offset: 0x000F38D8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new bool FromServer { get; set; }

		// Token: 0x04000E32 RID: 3634
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E33 RID: 3635
		internal List<oo0O__O0> <<EMPTY_NAME>>;

		// Token: 0x04000E34 RID: 3636
		internal Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000E35 RID: 3637
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E36 RID: 3638
		private DataServerTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04000E37 RID: 3639
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;
	}
}
