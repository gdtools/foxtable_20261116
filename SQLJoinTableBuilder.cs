using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 查询表生成器
	/// </summary>
	// Token: 0x02000249 RID: 585
	[oO0oooo("2314")]
	[ComVisible(true)]
	public class SQLJoinTableBuilder
	{
		/// <param name="TableName">即将生成的查询表的名称</param>
		/// <param name="BaseTable">基表，用于生成查询表的第一个数据表</param>
		// Token: 0x06001BDA RID: 7130 RVA: 0x000C34B0 File Offset: 0x000C16B0
		public SQLJoinTableBuilder(string A_0, string A_1)
		{
			this.oOo0OO._Ooo0_o. = 30;
			this.Oo.Oo__00. = true;
			this.Oo.Oo__00. = new List<SQLJoinTableBuilder>();
			this.oO._00OO0. = new List<SQLJoinTableBuilder>();
			this.OoO0_ooO_.ooO0. = new List<SQLJoinTableBuilder>();
			this.oO_0o_.oOO0. = new List<oo0O__O0>();
			this.Oo.Oo__00. = new Dictionary<string, string[]>();
			this.oO_0o_.oOO0. = DataServerTypeEnum.Access;
			this.TableName = A_0;
			this.BaseTable = A_1;
		}

		/// <summary>
		/// 数据源名称
		/// </summary>
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x000C351E File Offset: 0x000C171E
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x000C3526 File Offset: 0x000C1726
		public string ConnectionName
		{
			get
			{
				return this.oOo0OO._Ooo0_o.;
			}
			set
			{
				this.oOo0OO._Ooo0_o. = value;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x000C352F File Offset: 0x000C172F
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x000C3537 File Offset: 0x000C1737
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string BaseTable
		{
			get
			{
				return this.O._0000.;
			}
			set
			{
				this.O._0000. = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x000C3540 File Offset: 0x000C1740
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x000C3548 File Offset: 0x000C1748
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string TableName
		{
			get
			{
				return this.OoO0_ooO_.ooO0.;
			}
			set
			{
				this.OoO0_ooO_.ooO0. = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x000C3551 File Offset: 0x000C1751
		internal bool AsyncExecute
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId != Main.OO_O.o.;
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000C3568 File Offset: 0x000C1768
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
		/// <param name="LeftCol">左表关联列数组</param>
		/// <param name="RightTable">要添加的统计表，称为右表</param>
		/// <param name="RightCol">右表关联列数组</param>
		/// <param name="JoinMode">连接方式</param>
		// Token: 0x06001BE3 RID: 7139 RVA: 0x000C3684 File Offset: 0x000C1884
		public void AddTable(string LeftTable, string LeftCol, string RightTable, string RightCol, JoinModeEnum JoinMode = JoinModeEnum.Inner)
		{
			oo0O__O0 item = new oo0O__O0(LeftTable, new string[]
			{
				LeftCol
			}, RightTable, new string[]
			{
				RightCol
			}, JoinMode);
			this.oO_0o_.oOO0..Add(item);
		}

		/// <summary>
		/// 添加数据表
		/// </summary>
		/// <param name="LeftTable">基表，或者已经添加的数据表，称之为左表</param>
		/// <param name="LeftCol">左表关联列</param>
		/// <param name="RightTable">要添加的统计表，称为右表</param>
		/// <param name="RightCol">右表关联列</param>
		/// <param name="JoinMode">连接方式</param>
		// Token: 0x06001BE4 RID: 7140 RVA: 0x000C36BC File Offset: 0x000C18BC
		public void AddTable(string LeftTable, string[] LeftCol, string RightTable, string[] RightCol, JoinModeEnum JoinMode = JoinModeEnum.Inner)
		{
			oo0O__O0 item = new oo0O__O0(LeftTable, LeftCol, RightTable, RightCol, JoinMode);
			this.oO_0o_.oOO0..Add(item);
		}

		/// <summary>
		/// 添加列
		/// </summary>
		/// <param name="Names">要添加的列,可以在所有列名后再加一个参数True，表示这是分组列</param>
		// Token: 0x06001BE5 RID: 7141 RVA: 0x000C36E4 File Offset: 0x000C18E4
		public void AddCols(params object[] Names)
		{
			if (!(Names[Names.Length - 1] is bool))
			{
				checked
				{
					for (int i = 0; i < Names.Length; i++)
					{
						string text = Conversions.ToString(Names[i]);
						this.Oo.Oo__00..Add(text, new string[]
						{
							text,
							"0"
						});
					}
					return;
				}
			}
			int num = Names.Length - 2;
			if (!Conversions.ToBoolean(Names[Names.Length - 1]))
			{
				int num2 = num;
				for (int j = 0; j <= num2; j++)
				{
					this.Oo.Oo__00..Add(Names[j].ToString(), new string[]
					{
						Names[j].ToString(),
						"0"
					});
				}
				return;
			}
			int num3 = num;
			for (int k = 0; k <= num3; k++)
			{
				this.Oo.Oo__00..Add(Names[k].ToString(), new string[]
				{
					Names[k].ToString(),
					"1"
				});
			}
		}

		/// <summary>
		/// 添加表达式列
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Group">是否是分组列</param>
		// Token: 0x06001BE6 RID: 7142 RVA: 0x000C37D4 File Offset: 0x000C19D4
		public void AddExp(string Name, string Expression, bool Group = false)
		{
			if (!Group)
			{
				this.Oo.Oo__00..Add(Name, new string[]
				{
					Expression,
					"0"
				});
				return;
			}
			this.Oo.Oo__00..Add(Name, new string[]
			{
				Expression,
				"1"
			});
		}

		/// <summary>
		/// 查询条件
		/// </summary>
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x000C3821 File Offset: 0x000C1A21
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x000C3829 File Offset: 0x000C1A29
		public string Filter
		{
			get
			{
				return this.o_OOOO0O.O0.;
			}
			set
			{
				this.o_OOOO0O.O0. = value;
			}
		}

		/// <summary>
		/// 加载顺序
		/// </summary>
		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x000C3832 File Offset: 0x000C1A32
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x000C383A File Offset: 0x000C1A3A
		public string Order
		{
			get
			{
				return this.O.o__OOo0_O_.;
			}
			set
			{
				this.O.o__OOo0_O_. = value;
			}
		}

		/// <summary>
		/// 要加载的行数
		/// </summary>
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x000C3843 File Offset: 0x000C1A43
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x000C384B File Offset: 0x000C1A4B
		public string Top
		{
			get
			{
				return this.oo.___OOoO00_.;
			}
			set
			{
				this.oo.___OOoO00_. = value;
			}
		}

		/// <summary>
		/// 超时时限，默认为30秒
		/// </summary>
		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x000C3854 File Offset: 0x000C1A54
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x000C385C File Offset: 0x000C1A5C
		public int CommandTimeOut
		{
			get
			{
				return this.oOo0OO._Ooo0_o.;
			}
			set
			{
				this.oOo0OO._Ooo0_o. = value;
			}
		}

		/// <summary>
		/// 设置生成的Table的Visible属性
		/// </summary>
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x000C3865 File Offset: 0x000C1A65
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x000C386D File Offset: 0x000C1A6D
		public bool TableVisible
		{
			get
			{
				return this.Oo.Oo__00.;
			}
			set
			{
				this.Oo.Oo__00. = value;
			}
		}

		/// <summary>
		/// 表标题
		/// </summary>
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x000C3876 File Offset: 0x000C1A76
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x000C387E File Offset: 0x000C1A7E
		public string Caption
		{
			get
			{
				return this.OOO0.0OO__.;
			}
			set
			{
				this.OOO0.0OO__. = value;
			}
		}

		/// <summary>
		/// 是否排除重复值
		/// </summary>
		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x000C3887 File Offset: 0x000C1A87
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x000C388F File Offset: 0x000C1A8F
		public bool Distinct
		{
			get
			{
				return this.oO._00OO0.;
			}
			set
			{
				this.oO._00OO0. = value;
			}
		}

		/// <summary>
		/// 合并查询结果
		/// </summary>
		/// <param name="Builder">被组合的另一个SQLJoinTableBuilder</param>
		/// <param name="All">合的时候默认是排除重复值的，如果需要组合所有数据，请将此参数设置为True</param>
		// Token: 0x06001BF5 RID: 7157 RVA: 0x000C3898 File Offset: 0x000C1A98
		public void Union(SQLJoinTableBuilder Builder, bool All = false)
		{
			if (All)
			{
				this.oO._00OO0..Add(Builder);
				return;
			}
			this.Oo.Oo__00..Add(Builder);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000C38B8 File Offset: 0x000C1AB8
		private void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.ConnectionName, "", true) > 0)
			{
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.ConnectionName))
				{
					this.oO_0o_.oOO0. = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName].OO.OoO0.;
					return;
				}
				if (O_O0OO.O._o_.().ContainsKey(this.ConnectionName))
				{
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()[this.ConnectionName]))
					{
						this.oO_0o_.oOO0. = DataServerTypeEnum.Oracle;
						return;
					}
					if (o_O_o_oOoo__.OOOO_OO._oo.(O_O0OO.O._o_.()[this.ConnectionName]))
					{
						this.oO_0o_.oOO0. = DataServerTypeEnum.SqlServer;
					}
				}
			}
		}

		/// <summary>
		/// 如果查询结果来自于不同的数据源，需要采用Merge方法组合，Merge方法不如Union方法高效
		/// </summary>
		/// <param name="Builder"></param>
		// Token: 0x06001BF7 RID: 7159 RVA: 0x000C3956 File Offset: 0x000C1B56
		public void Merge(SQLJoinTableBuilder Builder)
		{
			this.OoO0_ooO_.ooO0..Add(Builder);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x000C3964 File Offset: 0x000C1B64
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataTable Build(params object[] args)
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
		/// 生成查询表
		/// </summary>
		// Token: 0x06001BF9 RID: 7161 RVA: 0x000C39A5 File Offset: 0x000C1BA5
		public DataTable Build()
		{
			return this.Build(false);
		}

		/// <summary>
		/// 生成查询表
		/// </summary>
		/// <param name="OnlyDataTable">是否只生成DataTable,不生成Table</param>
		// Token: 0x06001BFA RID: 7162 RVA: 0x000C39B0 File Offset: 0x000C1BB0
		public DataTable Build(bool OnlyDataTable)
		{
			string a_ = OO_00oOO.MainTable.Name;
			if (OO_00oOO.DataTables.Contains(this.TableName) && !OnlyDataTable)
			{
				if (OO_00oOO.DataTables[this.TableName].AddByCode)
				{
					OO_00oOO.DataTables.Delete(this.TableName);
				}
				if (OO_00oOO.DataTables.Contains(this.TableName))
				{
					MessageBox.Show("表" + this.TableName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return null;
				}
			}
			DataTable dataTable = this.BuildDataSource();
			try
			{
				foreach (SQLJoinTableBuilder sqljoinTableBuilder in this.OoO0_ooO_.ooO0.)
				{
					DataTable table = sqljoinTableBuilder.BuildDataSource();
					dataTable.Merge(table, false, MissingSchemaAction.Ignore);
				}
			}
			finally
			{
				List<SQLJoinTableBuilder>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return this.oOo0OO._Ooo0_o.(dataTable, OnlyDataTable, a_);
		}

		/// <summary>
		/// 生成查询语句
		/// </summary>
		// Token: 0x06001BFB RID: 7163 RVA: 0x000C3AA0 File Offset: 0x000C1CA0
		public string BuildSql()
		{
			int num2;
			string result;
			int num6;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				this.oOo0OO._Ooo0_o.();
				IL_08:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_0F:
				num = 3;
				string text = "";
				IL_18:
				num = 4;
				string text2 = Oo00.o.oo_0.(this.BaseTable);
				IL_27:
				num = 5;
				string text3 = "";
				IL_30:
				num = 6;
				string text4 = "";
				IL_39:
				num = 7;
				string text5 = this.Filter;
				IL_43:
				num = 8;
				Dictionary<string, string[]>.KeyCollection.Enumerator enumerator = this.Oo.Oo__00..Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text6 = enumerator.Current;
					IL_65:
					num = 9;
					if (Operators.CompareString(text, "", true) > 0)
					{
						IL_78:
						num = 10;
						text += ",";
					}
					IL_89:
					num = 11;
					string[] array = this.Oo.Oo__00.[text6];
					IL_9B:
					num = 12;
					text += array[0];
					IL_AB:
					num = 13;
					if (Operators.CompareString(text6, array[0], true) != 0)
					{
						IL_BC:
						num = 14;
						text = text + " As [" + text6 + "]";
					}
					IL_D4:
					num = 15;
					if (Operators.CompareString(array[1], "1", true) == 0)
					{
						IL_E8:
						num = 16;
						if (Operators.CompareString(text3, "", true) > 0)
						{
							IL_FB:
							num = 17;
							text3 += ",";
						}
						IL_10C:
						num = 18;
						text3 += array[0];
					}
					IL_11C:
					num = 19;
				}
				IL_12B:
				num = 20;
				((IDisposable)enumerator).Dispose();
				IL_13B:
				num = 21;
				int num3 = this.oO_0o_.oOO0..Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_155:
					num = 22;
					oo0O__O0 oo0O__O = this.oO_0o_.oOO0.[i];
					IL_167:
					num = 23;
					string name = Enum.GetName(typeof(JoinModeEnum), oo0O__O.oO_0o_.oOO0.);
					IL_187:
					num = 24;
					text2 = string.Concat(new string[]
					{
						text2,
						" ",
						name,
						" JOIN ",
						Oo00.o.oo_0.(oo0O__O.o0O___o_o_0o.o.),
						" ON ",
						Oo00.o.oo_0.(oo0O__O.o0O___o_o_0o.o.),
						".[",
						oo0O__O.oO_0o_.oOO0.[0],
						"] = ",
						Oo00.o.oo_0.(oo0O__O.O_o.O00Oo.),
						".[",
						oo0O__O.Column[0],
						"]"
					});
					IL_224:
					num = 25;
					if (oo0O__O.Column.Length > 1)
					{
						IL_236:
						num = 26;
						int num4 = oo0O__O.Column.Length - 1;
						for (int j = 1; j <= num4; j++)
						{
							IL_24E:
							num = 27;
							text2 = string.Concat(new string[]
							{
								text2,
								" And ",
								Oo00.o.oo_0.(oo0O__O.o0O___o_o_0o.o.),
								".[",
								oo0O__O.oO_0o_.oOO0.[j],
								"] = ",
								Oo00.o.oo_0.(oo0O__O.O_o.O00Oo.),
								".[",
								oo0O__O.Column[j],
								"]"
							});
							IL_2C5:
							num = 28;
						}
					}
					IL_2D7:
					num = 29;
					text2 = "(" + text2 + ")";
					IL_2ED:
					num = 30;
				}
				IL_2FF:
				num = 31;
				if (Operators.CompareString(this.Top, "", true) <= 0)
				{
					goto IL_37F;
				}
				IL_316:
				num = 32;
				if (this.oO_0o_.oOO0. != DataServerTypeEnum.Oracle)
				{
					goto IL_365;
				}
				IL_322:
				num = 33;
				if (Operators.CompareString(text5, "", true) <= 0)
				{
					goto IL_34E;
				}
				IL_335:
				num = 34;
				text5 = text5 + " And ROWNUM <= " + this.Top;
				goto IL_37F;
				IL_34E:
				num = 36;
				text5 = "ROWNUM <= " + this.Top;
				goto IL_37F;
				IL_365:
				num = 38;
				text4 = "Top " + this.Top.ToString();
				IL_37F:
				num = 39;
				if (!this.Distinct)
				{
					goto IL_3C3;
				}
				IL_38A:
				num = 40;
				text = string.Concat(new string[]
				{
					"Select Distinct ",
					text4,
					" ",
					text,
					" From ",
					text2
				});
				goto IL_3FA;
				IL_3C3:
				num = 42;
				text = string.Concat(new string[]
				{
					"Select ",
					text4,
					" ",
					text,
					" From ",
					text2
				});
				IL_3FA:
				num = 43;
				if (Operators.CompareString(text5, "", true) <= 0)
				{
					goto IL_420;
				}
				IL_40D:
				num = 44;
				text = text + " Where " + text5;
				IL_420:
				num = 45;
				if (Operators.CompareString(text3, "", true) <= 0)
				{
					goto IL_446;
				}
				IL_433:
				num = 46;
				text = text + " Group By " + text3;
				IL_446:
				num = 47;
				if (Operators.CompareString(this.Order, "", true) <= 0)
				{
					goto IL_474;
				}
				IL_45D:
				num = 48;
				text = text + " Order By " + this.Order;
				IL_474:
				num = 49;
				List<SQLJoinTableBuilder>.Enumerator enumerator2 = this.Oo.Oo__00..GetEnumerator();
				while (enumerator2.MoveNext())
				{
					SQLJoinTableBuilder sqljoinTableBuilder = enumerator2.Current;
					IL_48F:
					num = 50;
					text = text + " UNION " + sqljoinTableBuilder.BuildSql();
					IL_4A7:
					num = 51;
				}
				IL_4B3:
				num = 52;
				((IDisposable)enumerator2).Dispose();
				IL_4C3:
				num = 53;
				List<SQLJoinTableBuilder>.Enumerator enumerator3 = this.oO._00OO0..GetEnumerator();
				while (enumerator3.MoveNext())
				{
					SQLJoinTableBuilder sqljoinTableBuilder2 = enumerator3.Current;
					IL_4DE:
					num = 54;
					text = text + " UNION All " + sqljoinTableBuilder2.BuildSql();
					IL_4F6:
					num = 55;
				}
				IL_502:
				num = 56;
				((IDisposable)enumerator3).Dispose();
				IL_512:
				num = 57;
				result = text;
				IL_518:
				goto IL_652;
				IL_51D:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_613:
				goto IL_647;
				IL_615:
				num6 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_625:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_615;
			}
			IL_647:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_652:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x000C4124 File Offset: 0x000C2324
		[EditorBrowsable(EditorBrowsableState.Never)]
		public fxDataSource2 BuildDataSource2()
		{
			fxDataSource a_ = this.BuildDataSource();
			return new fxDataSource2(a_);
		}

		/// <summary>
		/// 生成一个可以直接绑定到Table的DataSource属性的对象
		/// </summary>
		// Token: 0x06001BFD RID: 7165 RVA: 0x000C4140 File Offset: 0x000C2340
		public fxDataSource BuildDataSource()
		{
			fxDataSource fxDataSource = new fxDataSource();
			string text = this.BuildSql();
			OleDbConnection oleDbConnection = null;
			O0O o0O = null;
			if (Operators.CompareString(this.ConnectionName, "", true) > 0)
			{
				if (O_O0OO.O._o_.().ContainsKey(this.ConnectionName))
				{
					oleDbConnection = O_O0OO.O._o_.()[this.ConnectionName];
				}
				else if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.ConnectionName))
				{
					o0O = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName];
				}
				if (oleDbConnection == null && o0O == null)
				{
					MessageBox.Show("不存在名为\"" + this.ConnectionName + "\"的数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return null;
				}
			}
			else
			{
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.();
			}
			if (oleDbConnection != null)
			{
				text = Oo00.o0_o._O_.(oleDbConnection, text, false);
				if (this.AsyncExecute)
				{
					oleDbConnection = new OleDbConnection(oleDbConnection.ConnectionString);
				}
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text, oleDbConnection);
				oleDbDataAdapter.SelectCommand.CommandTimeout = this.CommandTimeOut;
				if (this.AsyncExecute)
				{
					oleDbConnection.Open();
				}
				try
				{
					oleDbDataAdapter.Fill(fxDataSource);
					goto IL_1AC;
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
					goto IL_1AC;
				}
				finally
				{
					if (this.AsyncExecute)
					{
						oleDbConnection.Close();
					}
				}
			}
			text = Oo00.o0_o._O_.(this.oO_0o_.oOO0., text, false);
			HttpClient httpClient = o0O.oO0_0.o.();
			httpClient.Select = text;
			httpClient.FormData["Action"] = 2.ToString();
			httpClient.FormData["IgnoreSchema"] = "True";
			DataTable baseDataTable = httpClient.GetBaseDataTable();
			if (baseDataTable != null && baseDataTable.Columns.Count > 0)
			{
				fxDataSource.Merge(baseDataTable, false, MissingSchemaAction.AddWithKey);
				baseDataTable.Dispose();
			}
			IL_1AC:
			try
			{
				foreach (object obj in fxDataSource.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (dataColumn.ColumnName.StartsWith("~TMPCLP"))
					{
						dataColumn.Caption = dataColumn.ColumnName.Substring(7);
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
			return fxDataSource;
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x000C438C File Offset: 0x000C258C
		private DataTable <<EMPTY_NAME>>(DataTable A_0, bool A_1, string A_2)
		{
			A_0.TableName = this.TableName;
			DataTable dataTable;
			if (A_1)
			{
				dataTable = new DataTable(A_0, null, null, "", O_O0OO.OoO.0OO__0ooo.());
				dataTable.o.0O000_.();
			}
			else
			{
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(A_0);
				OO_00oOO.DataTables.OO0o00.0O_0o.(new DataTable(A_0, null, null, this.TableName, O_O0OO.OoO.0OO__0ooo.()));
				OO_00oOO.DataTables[this.TableName].o.0O000_.();
				OO_00oOO.DataTables[this.TableName].AddByCode = true;
				OO_00oOO.DataTables[this.TableName].Caption = this.Caption;
				dataTable = OO_00oOO.DataTables[this.TableName];
			}
			DataTable result;
			if (A_1)
			{
				result = dataTable;
			}
			else
			{
				new O_0(O_O0OO.o__.O.(), A_0);
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[this.TableName]);
				Main.OO_O.o..o0_o_o_0.0O.(this.TableName, this.TableVisible, false);
				if (Operators.CompareString(A_2, this.TableName, true) == 0)
				{
					OO_00oOO.MainTable = OO_00oOO.Tables[this.TableName];
				}
				result = dataTable;
			}
			return result;
		}

		// Token: 0x04000BC6 RID: 3014
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BC7 RID: 3015
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BC8 RID: 3016
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BC9 RID: 3017
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BCA RID: 3018
		private int <<EMPTY_NAME>>;

		// Token: 0x04000BCB RID: 3019
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BCC RID: 3020
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BCD RID: 3021
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BCE RID: 3022
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BCF RID: 3023
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BD0 RID: 3024
		private List<SQLJoinTableBuilder> <<EMPTY_NAME>>;

		// Token: 0x04000BD1 RID: 3025
		private List<SQLJoinTableBuilder> <<EMPTY_NAME>>;

		// Token: 0x04000BD2 RID: 3026
		private List<SQLJoinTableBuilder> <<EMPTY_NAME>>;

		// Token: 0x04000BD3 RID: 3027
		private List<oo0O__O0> <<EMPTY_NAME>>;

		// Token: 0x04000BD4 RID: 3028
		private Dictionary<string, string[]> <<EMPTY_NAME>>;

		// Token: 0x04000BD5 RID: 3029
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BD6 RID: 3030
		private DataServerTypeEnum <<EMPTY_NAME>>;
	}
}
