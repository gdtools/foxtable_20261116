using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 临时表生成器
	/// </summary>
	// Token: 0x02000294 RID: 660
	[ComVisible(true)]
	public class DataTableBuilder
	{
		/// <param name="TableName">表名</param>
		// Token: 0x06002127 RID: 8487 RVA: 0x000E93C7 File Offset: 0x000E75C7
		public DataTableBuilder(string A_0)
		{
			this.ooo.o__oO. = new List<DataColBuilder>();
			this.ooo.o__oO. = true;
			this.ooo.o__oO. = A_0;
		}

		/// <param name="TableName">表名</param>
		/// <param name="Caption">表标题</param>
		// Token: 0x06002128 RID: 8488 RVA: 0x000E93E8 File Offset: 0x000E75E8
		public DataTableBuilder(string A_0, string A_1)
		{
			this.ooo.o__oO. = new List<DataColBuilder>();
			this.ooo.o__oO. = true;
			this.ooo.o__oO. = A_0;
			this.OOO.00o_o_. = A_1;
		}

		/// <summary>
		/// 表名
		/// </summary>
		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x000E9410 File Offset: 0x000E7610
		// (set) Token: 0x0600212A RID: 8490 RVA: 0x000E9418 File Offset: 0x000E7618
		public string TableName
		{
			get
			{
				return this.ooo.o__oO.;
			}
			set
			{
				this.ooo.o__oO. = value;
			}
		}

		/// <summary>
		/// 设置生成的Table的Visible属性
		/// </summary>
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x000E9421 File Offset: 0x000E7621
		// (set) Token: 0x0600212C RID: 8492 RVA: 0x000E9429 File Offset: 0x000E7629
		public bool TableVisible
		{
			get
			{
				return this.ooo.o__oO.;
			}
			set
			{
				this.ooo.o__oO. = value;
			}
		}

		/// <summary>
		/// 表标题
		/// </summary>
		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x000E9432 File Offset: 0x000E7632
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x000E943A File Offset: 0x000E763A
		public string Caption
		{
			get
			{
				return this.OOO.00o_o_.;
			}
			set
			{
				this.OOO.00o_o_. = value;
			}
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000E9444 File Offset: 0x000E7644
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddDef(params object[] args)
		{
			switch (args.Length)
			{
			case 2:
			{
				string name = Conversions.ToString(args[0]);
				Type type = ooO.o.O_0000_O.(Conversions.ToString(args[1]));
				this.AddDef(name, type);
				return;
			}
			case 3:
			{
				string name2 = Conversions.ToString(args[0]);
				Type type2 = ooO.o.O_0000_O.(Conversions.ToString(args[1]));
				if (args[2] is string)
				{
					string expression = Conversions.ToString(args[2]);
					this.AddDef(name2, type2, expression);
					return;
				}
				if (args[2] is int)
				{
					int maxlength = Conversions.ToInteger(args[2]);
					this.AddDef(name2, type2, maxlength);
					return;
				}
				break;
			}
			case 4:
			{
				string name3 = Conversions.ToString(args[0]);
				Type type3 = ooO.o.O_0000_O.(Conversions.ToString(args[1]));
				if (args[2] is string && args[3] is string)
				{
					string expression2 = Conversions.ToString(args[2]);
					string caption = Conversions.ToString(args[3]);
					this.AddDef(name3, type3, expression2, caption);
					return;
				}
				if (args[2] is int && args[3] is string)
				{
					int maxlength2 = Conversions.ToInteger(args[2]);
					string expression3 = Conversions.ToString(args[3]);
					this.AddDef(name3, type3, maxlength2, expression3);
				}
				break;
			}
			default:
				return;
			}
		}

		/// <summary>
		/// 增加列
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="Type">数据类型</param>
		// Token: 0x06002130 RID: 8496 RVA: 0x000E956B File Offset: 0x000E776B
		public void AddDef(string Name, Type Type)
		{
			this.ooo.o__oO..Add(new DataColBuilder(Name, Type));
		}

		/// <summary>
		/// 增加列
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="Type">数据类型</param>
		/// <param name="Expression">表达式</param>
		// Token: 0x06002131 RID: 8497 RVA: 0x000E957F File Offset: 0x000E777F
		public void AddDef(string Name, Type Type, string Expression)
		{
			this.ooo.o__oO..Add(new DataColBuilder(Name, Type, Expression));
		}

		/// <summary>
		/// 增加列
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="Type">数据类型</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Caption">标题</param>
		// Token: 0x06002132 RID: 8498 RVA: 0x000E9594 File Offset: 0x000E7794
		public void AddDef(string Name, Type Type, string Expression, string Caption)
		{
			this.ooo.o__oO..Add(new DataColBuilder(Name, Type, Expression, Caption));
		}

		/// <summary>
		/// 增加列
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="Type">数据类型</param>
		/// <param name="Maxlength">如果是字符串列，用此属性之列最大长度</param>
		// Token: 0x06002133 RID: 8499 RVA: 0x000E95AB File Offset: 0x000E77AB
		public void AddDef(string Name, Type Type, int Maxlength)
		{
			this.ooo.o__oO..Add(new DataColBuilder(Name, Type, Maxlength));
		}

		/// <summary>
		/// 增加列
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="Type">数据类型</param>
		/// <param name="Maxlength">如果是字符串列，用此属性之列最大长度</param>
		/// <param name="Expression">表达式</param>
		// Token: 0x06002134 RID: 8500 RVA: 0x000E95C0 File Offset: 0x000E77C0
		public void AddDef(string Name, Type Type, int Maxlength, string Expression)
		{
			this.ooo.o__oO..Add(new DataColBuilder(Name, Type, Maxlength, Expression));
		}

		/// <summary>
		/// 增加列
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="Type">数据类型</param>
		/// <param name="Maxlength">最大长度</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Caption">标题</param>
		// Token: 0x06002135 RID: 8501 RVA: 0x000E95D7 File Offset: 0x000E77D7
		public void AddDef(string Name, Type Type, int Maxlength, string Expression, string Caption)
		{
			this.ooo.o__oO..Add(new DataColBuilder(Name, Type, Maxlength, Expression, Caption));
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x000E95F0 File Offset: 0x000E77F0
		internal bool Contains(string Name)
		{
			try
			{
				List<DataColBuilder>.Enumerator enumerator = this.ooo.o__oO..GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.CompareString(enumerator.Current.Name, Name, true) == 0)
					{
						return true;
					}
				}
			}
			finally
			{
				List<DataColBuilder>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return false;
		}

		/// <summary>
		/// 生成表
		/// </summary>
		/// <param name="OnlyDataTable">是否只生成DataTable，不生成Table</param>
		// Token: 0x06002137 RID: 8503 RVA: 0x000E9650 File Offset: 0x000E7850
		public DataTable Build(bool OnlyDataTable = false)
		{
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
			dataTable.TableName = this.TableName;
			DataTable result;
			if (OnlyDataTable)
			{
				DataTable dataTable2 = new DataTable(dataTable, null, null, "", O_O0OO.OoO.0OO__0ooo.());
				dataTable2.o.0O000_.();
				result = dataTable2;
			}
			else
			{
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable);
				OO_00oOO.DataTables.OO0o00.0O_0o.(new DataTable(dataTable, null, null, this.TableName, O_O0OO.OoO.0OO__0ooo.()));
				OO_00oOO.DataTables[this.TableName].o.0O000_.();
				OO_00oOO.DataTables[this.TableName].Caption = this.Caption;
				OO_00oOO.DataTables[this.TableName].AddByCode = true;
				try
				{
					foreach (DataCol dataCol in OO_00oOO.DataTables[this.TableName].DataCols)
					{
						dataCol.Caption = dataCol.BaseColumn.Caption;
						dataCol.BaseColumn.Caption = "";
					}
				}
				finally
				{
					IEnumerator<DataCol> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				new O_0(O_O0OO.o__.O.(), OO_00oOO.DataTables[this.TableName].BaseTable);
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[this.TableName]);
				Main.OO_O.o..o0_o_o_0.0O.(this.TableName, this.TableVisible, false);
				try
				{
					foreach (Col col in OO_00oOO.Tables[this.TableName].Cols)
					{
						col.o0.O.();
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
				result = OO_00oOO.DataTables[this.TableName];
			}
			return result;
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x000E9890 File Offset: 0x000E7A90
		[EditorBrowsable(EditorBrowsableState.Never)]
		public fxDataSource2 BuildDataSource2()
		{
			fxDataSource a_ = this.BuildDataSource();
			return new fxDataSource2(a_);
		}

		/// <summary>
		/// 生成一个可以直接绑定到Table的DataSource属性的对象
		/// </summary>
		// Token: 0x06002139 RID: 8505 RVA: 0x000E98AC File Offset: 0x000E7AAC
		public fxDataSource BuildDataSource()
		{
			fxDataSource fxDataSource = new fxDataSource();
			List<string> list = new List<string>();
			List<Type> list2 = new List<Type>();
			List<int> list3 = new List<int>();
			List<string> list4 = new List<string>();
			List<string> list5 = new List<string>();
			try
			{
				foreach (DataColBuilder dataColBuilder in this.ooo.o__oO.)
				{
					list.Add(dataColBuilder.Name);
					list2.Add(dataColBuilder.Type);
					list3.Add(dataColBuilder.Maxlength);
					list4.Add(dataColBuilder.Caption);
					list5.Add(dataColBuilder.Expression);
				}
			}
			finally
			{
				List<DataColBuilder>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			int num = list.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				fxDataSource.Columns.Add(list[i], list2[i]);
				if (list2[i] == typeof(string))
				{
					fxDataSource.Columns[list[i]].MaxLength = list3[i];
				}
			}
			int num2 = list.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				if (Operators.CompareString(list5[j], "", true) > 0)
				{
					try
					{
						fxDataSource.Columns[list[j]].Expression = list5[j];
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
						break;
					}
				}
			}
			try
			{
				foreach (object obj in fxDataSource.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					dataColumn.Caption = list4[list.IndexOf(dataColumn.ColumnName)];
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
			return fxDataSource;
		}

		// Token: 0x04000DE0 RID: 3552
		private List<DataColBuilder> <<EMPTY_NAME>>;

		// Token: 0x04000DE1 RID: 3553
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DE2 RID: 3554
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DE3 RID: 3555
		private bool <<EMPTY_NAME>>;
	}
}
