using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000331 RID: 817
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class VarsCollection
	{
		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002D80 RID: 11648 RVA: 0x0014F468 File Offset: 0x0014D668
		// (set) Token: 0x06002D81 RID: 11649 RVA: 0x0014F470 File Offset: 0x0014D670
		internal virtual DataTable VariableTable
		{
			[CompilerGenerated]
			get
			{
				return this.o0.oooO.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataColumnChangeEventHandler value2 = new DataColumnChangeEventHandler(this.o0.oooO.);
				DataTable dataTable = this.o0.oooO.;
				if (dataTable != null)
				{
					dataTable.ColumnChanged -= value2;
				}
				this.o0.oooO. = value;
				dataTable = this.o0.oooO.;
				if (dataTable != null)
				{
					dataTable.ColumnChanged += value2;
				}
			}
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x0014F4B3 File Offset: 0x0014D6B3
		public VarsCollection()
		{
			this.VariableTable = new DataTable();
			this.VariableTable.Rows.Add(this.VariableTable.NewRow());
		}

		// Token: 0x17000A46 RID: 2630
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string VarName]
		{
			get
			{
				if (this.VariableTable.Columns.Contains(VarName))
				{
					if (!this.VariableTable.Rows[0].IsNull(VarName))
					{
						return this.VariableTable.Rows[0][VarName];
					}
				}
				else if (O_O0OO.O0_00o.o0__o..DeclareVar)
				{
					MessageBox.Show("未定义变量" + VarName + "！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				return null;
			}
			set
			{
				bool flag;
				if (!this.VariableTable.Columns.Contains(VarName))
				{
					if (O_O0OO.O0_00o.o0__o..DeclareVar)
					{
						MessageBox.Show("未定义变量" + VarName + "！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					flag = true;
					this.Add(VarName, value.GetType());
				}
				if (flag || ((value != null || (this.VariableTable.Rows[0][VarName] != null && !this.VariableTable.Rows[0].IsNull(VarName))) && (value == null || this.VariableTable.Rows[0][VarName] == null || (!value.GetType().IsValueType && !(value is string)) || Operators.CompareString(value.ToString(), this.VariableTable.Rows[0][VarName].ToString(), true) != 0)))
				{
					if (value == null)
					{
						value = DBNull.Value;
					}
					this.VariableTable.Rows[0][VarName] = RuntimeHelpers.GetObjectValue(value);
					this.VariableTable.Rows[0].EndEdit();
				}
			}
		}

		/// <summary>
		/// 清除所有Var变量
		/// </summary>
		// Token: 0x06002D85 RID: 11653 RVA: 0x0014F69C File Offset: 0x0014D89C
		public void Clear()
		{
			for (int i = this.VariableTable.Columns.Count - 1; i >= 0; i += -1)
			{
				if (!this.VariableTable.Columns[i].ColumnName.ToLower().StartsWith("sys"))
				{
					this.VariableTable.Columns.RemoveAt(i);
				}
			}
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x0014F700 File Offset: 0x0014D900
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Add(params object[] args)
		{
			if (args.Length >= 2)
			{
				string varName = Conversions.ToString(args[0]);
				Type type = ooO.o.O_0000_O.(Conversions.ToString(args[1]));
				if (args.Length == 2)
				{
					this.Add(varName, type);
					return;
				}
				if (args.Length == 3)
				{
					this.Add(varName, type, RuntimeHelpers.GetObjectValue(args[2]));
				}
			}
		}

		/// <summary>
		/// 增加Var变量
		/// </summary>
		/// <param name="VarName">变量名</param>
		/// <param name="Type">变量类型</param>
		// Token: 0x06002D87 RID: 11655 RVA: 0x0014F74F File Offset: 0x0014D94F
		public void Add(string VarName, Type Type)
		{
			this.Add(VarName, Type, null);
		}

		/// <summary>
		/// 增加Var变量
		/// </summary>
		/// <param name="VarName">变量名</param>
		/// <param name="Type">变量类型</param>
		/// <param name="Value">初始值</param>
		// Token: 0x06002D88 RID: 11656 RVA: 0x0014F75C File Offset: 0x0014D95C
		public void Add(string VarName, Type Type, object Value)
		{
			if (VarName.ToLower().StartsWith("sys"))
			{
				MessageBox.Show("全局变量名不能以sys开头！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (Operators.CompareString(VarName, "", true) > 0 && Type != null)
			{
				this.o.O0o_O.(VarName, Type, RuntimeHelpers.GetObjectValue(Value));
			}
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x0014F7B0 File Offset: 0x0014D9B0
		internal void <<EMPTY_NAME>>(string A_0, Type A_1, object A_2)
		{
			if (this.VariableTable.Columns.Contains(A_0))
			{
				if (this.VariableTable.Columns[A_0].DataType != A_1)
				{
					this.VariableTable.Columns.Remove(A_0);
					this.VariableTable.Columns.Add(A_0, A_1);
				}
			}
			else
			{
				this.VariableTable.Columns.Add(A_0, A_1);
			}
			if (A_2 != null && Operators.CompareString(A_2.ToString(), "", true) != 0)
			{
				if (o_O_o_oOoo__.OO_.O.(this.VariableTable.Columns[A_0].DataType))
				{
					double num;
					if (double.TryParse(A_2.ToString(), out num))
					{
						this.VariableTable.Rows[0][A_0] = num;
					}
				}
				else if (this.VariableTable.Columns[A_0].DataType == typeof(DateTime))
				{
					DateTime dateTime;
					if (DateTime.TryParse(A_2.ToString(), out dateTime))
					{
						this.VariableTable.Rows[0][A_0] = dateTime;
					}
				}
				else if (this.VariableTable.Columns[A_0].DataType == typeof(bool))
				{
					bool flag;
					if (bool.TryParse(A_2.ToString(), out flag))
					{
						this.VariableTable.Rows[0][A_0] = flag;
					}
				}
				else
				{
					this.VariableTable.Rows[0][A_0] = RuntimeHelpers.GetObjectValue(A_2);
				}
			}
			try
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					if (form is O\u3000\u3002\u3000\u3000)
					{
						((O\u3000\u3002\u3000\u3000)form).O.O_0o_Oo_.().OO0o.__0_Oo.();
					}
					else if (form is oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000)
					{
						((oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000)form).oo._OoO.().OO0o.__0_Oo.();
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

		// Token: 0x06002D8A RID: 11658 RVA: 0x0014F9D0 File Offset: 0x0014DBD0
		private void <<EMPTY_NAME>>(object A_0, DataColumnChangeEventArgs A_1)
		{
			if (!A_1.Column.ColumnName.ToLower().StartsWith("sys"))
			{
				GlobalVariableChangedEventArgs globalVariableChangedEventArgs = new GlobalVariableChangedEventArgs(A_1.Column.ColumnName);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "GlobalVariableChanged", new object[]
				{
					globalVariableChangedEventArgs
				}, false, "项目", false);
			}
		}

		// Token: 0x0400126D RID: 4717
		[CompilerGenerated]
		[AccessedThroughProperty("VariableTable")]
		private DataTable <<EMPTY_NAME>>;
	}
}
