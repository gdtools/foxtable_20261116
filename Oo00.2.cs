using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ADODB;
using ADOX;
using C1.Win.C1FlexGrid;
using Foxtable.RibbonMenu;
using Foxtable.Syscmd;
using Foxtable.WinForm;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using MSScriptControl;

namespace Foxtable
{
	// Token: 0x02000445 RID: 1093
	[StandardModule]
	internal sealed class Oo00
	{
		// Token: 0x0600498F RID: 18831 RVA: 0x002025B8 File Offset: 0x002007B8
		public static void <<EMPTY_NAME>>()
		{
			try
			{
				new ScriptControlClass();
			}
			catch (Exception ex)
			{
				new Process
				{
					File = O_O0OO.o.00O_O.() + "\\regscript.bat",
					WaitForClose = true
				}.Start();
				new ScriptControlClass();
			}
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x00202618 File Offset: 0x00200818
		internal static bool <<EMPTY_NAME>>(string A_0)
		{
			bool result;
			if (O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(A_0))
			{
				MessageBox.Show("已经存在同名表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = o_O_o_oOoo__.O_o_._o0.(A_0);
			}
			return result;
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x00202658 File Offset: 0x00200858
		internal static void <<EMPTY_NAME>>(DataTable A_0, bool A_1 = true)
		{
			if (A_0.ExtendedProperties.ContainsKey("DataAdapter"))
			{
				((OleDbDataAdapter)A_0.ExtendedProperties["DataAdapter"]).Update(A_0);
				if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0 && A_1 && Main.OO_O.o. != null)
				{
					Main.OO_O.o..o._oOO0. = true;
					return;
				}
			}
			else if (A_0.ExtendedProperties.ContainsKey("WebUpdater"))
			{
				DataTable a_ = (DataTable)A_0.ExtendedProperties["WebUpdater"];
				DataRow[] array = A_0.Select("", "", DataViewRowState.ModifiedCurrent);
				if (array.Length > 0)
				{
					oOO0oO000_0_0.oOoOo_o.__.(a_, array);
				}
				array = A_0.Select("", "", DataViewRowState.Added);
				if (array.Length > 0)
				{
					oOO0oO000_0_0.o__o.OOO__.(a_, array);
				}
				array = A_0.Select("", "", DataViewRowState.Deleted);
				if (array.Length > 0)
				{
					oOO0oO000_0_0.OO.OoO0.(a_, array);
				}
			}
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x0020274D File Offset: 0x0020094D
		internal static void <<EMPTY_NAME>>(DataRow A_0)
		{
			((OleDbDataAdapter)A_0.Table.ExtendedProperties["DataAdapter"]).Update(new DataRow[]
			{
				A_0
			});
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x00202779 File Offset: 0x00200979
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password=" + O_O0OO.oO_00Ooo___0._.;
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x00202790 File Offset: 0x00200990
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password=" + O_O0OO.oO_00Ooo___0._.;
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x002027A8 File Offset: 0x002009A8
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (A_0.ToLower().EndsWith("accdb"))
			{
				result = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password=" + O_O0OO.oO_00Ooo___0._.;
			}
			else
			{
				result = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password=" + O_O0OO.oO_00Ooo___0._.;
			}
			return result;
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x002027F8 File Offset: 0x002009F8
		internal static bool <<EMPTY_NAME>>(o_oo0 A_0, DataTable A_1, string A_2, string A_3)
		{
			bool result;
			if (A_0.o0_oo0._.().oooO__O_0o_.o_.(A_2))
			{
				MessageBox.Show(A_2 + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				A_0.o0_oo0._.().O_.0_O__OOoOo.(A_2);
				A_0.o0_oo0._.().O.0_O.(A_2).ooo.O_0_O.(A_3);
				foreach (DataRow dataRow in A_1.Select("", "ID", DataViewRowState.CurrentRows))
				{
					if (!dataRow.IsNull("列名"))
					{
						string a_ = Conversions.ToString(dataRow["列名"]);
						ColumnDataTypeEnum columnDataTypeEnum = (ColumnDataTypeEnum)Conversions.ToInteger(dataRow["类型"]);
						int a_2;
						if (!dataRow.IsNull("长度"))
						{
							a_2 = Conversions.ToInteger(dataRow["长度"]);
						}
						A_0.o0_oo0._.().O.0_O.(A_2).o_O00_.00_.().O_o0.Oo00o0.(a_, columnDataTypeEnum, int.MinValue);
						if (columnDataTypeEnum == ColumnDataTypeEnum.String)
						{
							A_0.o0_oo0._.().O.0_O.(A_2).o_O00_.00_.().OO00o__OOO.o0_.(a_).O_o0.Oo00o0.(a_2);
						}
						if (!dataRow.IsNull("标题"))
						{
							A_0.o0_oo0._.().O.0_O.(A_2).o_O00_.00_.().OO00o__OOO.o0_.(a_).O.0_.(Conversions.ToString(dataRow["标题"]));
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x00202958 File Offset: 0x00200B58
		internal static void <<EMPTY_NAME>>(o\u3000\u3000 A_0, ValidateInputTextEventArgs A_1)
		{
			if (Operators.CompareString(A_1.Value, "", true) == 0)
			{
				MessageBox.Show("请输入关联名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
				return;
			}
			if (Operators.CompareString(A_1.Value, A_1.OriginalValue, true) != 0)
			{
				if (!o_O_o_oOoo__.O_o_._o0.(A_1.Value, "关联名称", 64, false))
				{
					A_1.Cancel = true;
				}
				if (o_O_o_oOoo__.oo.O0o0o.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()].Columns["Name"], A_1.Value))
				{
					MessageBox.Show("已经存在同名关联，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					A_1.Cancel = true;
				}
			}
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x00202A10 File Offset: 0x00200C10
		internal static bool <<EMPTY_NAME>>(string A_0, DataTable A_1, DataTable A_2)
		{
			string text = "关联名称不能和现有列的列名相同！";
			try
			{
				IEnumerator enumerator = A_1.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.CompareString(((DataColumn)enumerator.Current).ColumnName, A_0, true) == 0)
					{
						MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return false;
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
				IEnumerator enumerator2 = A_2.Columns.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					if (Operators.CompareString(((DataColumn)enumerator2.Current).ColumnName, A_0, true) == 0)
					{
						MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return false;
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
			return true;
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x00202AF4 File Offset: 0x00200CF4
		internal static bool <<EMPTY_NAME>>(string A_0, string A_1)
		{
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if ((dataRelation.ParentTable == O_O0OO.OOOo.oo_OOOO_0.().Tables[A_0] || dataRelation.ChildTable == O_O0OO.OOOo.oo_OOOO_0.().Tables[A_0]) && Operators.CompareString(dataRelation.RelationName, A_1, true) == 0)
					{
						MessageBox.Show("列名不能和关联名相同！", "提示", MessageBoxButtons.OK);
						return false;
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
			return true;
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x00202BA4 File Offset: 0x00200DA4
		internal static void <<EMPTY_NAME>>(o\u3000\u3000 A_0, ValidateInputTextEventArgs A_1)
		{
			if (string.IsNullOrWhiteSpace(A_1.Value))
			{
				MessageBox.Show("请输入窗口名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
				return;
			}
			if (Operators.CompareString(A_1.Value, A_1.OriginalValue, true) != 0)
			{
				OleDbCommand oleDbCommand = new OleDbCommand(string.Concat(new string[]
				{
					"select Count(*) From [",
					ooO0__OO.oo._O.(),
					"] Where ([Type] = ",
					Conversions.ToString(229),
					" Or [Type] = ",
					Conversions.ToString(233),
					") and [Name] = '",
					A_1.Value,
					"'"
				}), O_O0OO.OoO.0OO__0ooo.());
				O_O0OO.OoO.0OO__0ooo.().Open();
				if (Conversions.ToInteger(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())) > 0)
				{
					MessageBox.Show("已经存在同名窗口，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					A_1.Cancel = true;
				}
				O_O0OO.OoO.0OO__0ooo.().Close();
			}
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x00202C9C File Offset: 0x00200E9C
		internal static void <<EMPTY_NAME>>(o\u3000\u3000 A_0, ValidateInputTextEventArgs A_1)
		{
			if (string.IsNullOrWhiteSpace(A_1.Value))
			{
				MessageBox.Show("请输入函数名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
				return;
			}
			checked
			{
				if (Operators.CompareString(A_1.Value, A_1.OriginalValue, true) != 0)
				{
					DataRow[] array = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o.00_0o0__OoO.()].Select("[Type] = " + Conversions.ToString(9));
					for (int i = 0; i < array.Length; i++)
					{
						string text = array[i]["Name"].ToString();
						if (text.StartsWith("![") && text.EndsWith("]!"))
						{
							text = text.Trim(new char[]
							{
								'!'
							}).TrimStart(new char[]
							{
								'['
							}).TrimEnd(new char[]
							{
								']'
							});
						}
						if (Operators.CompareString(text, A_1.Value, true) == 0)
						{
							MessageBox.Show("已经存在同名函数，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							A_1.Cancel = true;
							return;
						}
					}
				}
			}
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x00202DB0 File Offset: 0x00200FB0
		internal static void <<EMPTY_NAME>>(o\u3000\u3000 A_0, ValidateInputTextEventArgs A_1)
		{
			if (string.IsNullOrWhiteSpace(A_1.Value))
			{
				MessageBox.Show("请输入目录名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
				return;
			}
			if (Operators.CompareString(A_1.Value, A_1.OriginalValue, true) != 0)
			{
				foreach (DataRow dataRow in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o.00_0o0__OoO.()].Select("[Type] = " + Conversions.ToString(43)))
				{
					string left = dataRow["Name"].ToString();
					string right = "";
					if (A_1.parentNode != null)
					{
						right = A_1.parentNode.FullPath;
					}
					if (Operators.CompareString(left, A_1.Value, true) == 0 && Operators.CompareString(dataRow["Path"].ToString(), right, true) == 0)
					{
						MessageBox.Show("已经存在同名目录，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						A_1.Cancel = true;
						return;
					}
				}
			}
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x00202EA8 File Offset: 0x002010A8
		internal static bool <<EMPTY_NAME>>(string A_0, string A_1, DataSet A_2 = null)
		{
			if (A_2 == null)
			{
				A_2 = O_O0OO.OOOo.oo_OOOO_0.();
			}
			try
			{
				foreach (object obj in A_2.Relations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (Operators.CompareString(dataRelation.ParentTable.TableName, A_0, true) == 0 && Operators.CompareString(dataRelation.ChildTable.TableName, A_1, true) == 0)
					{
						return true;
					}
					if (Operators.CompareString(dataRelation.ChildTable.TableName, A_0, true) == 0 && Operators.CompareString(dataRelation.ParentTable.TableName, A_1, true) == 0)
					{
						return true;
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
			return false;
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x00202F64 File Offset: 0x00201164
		internal static bool <<EMPTY_NAME>>(string A_0, string A_1, DataRow A_2)
		{
			bool result;
			if (Oo00.O____0O._0.(A_2["ParentTable"].ToString(), A_2["ChildTable"].ToString(), null) && A_2.RowState == DataRowState.Detached)
			{
				result = true;
			}
			else
			{
				try
				{
					foreach (object obj in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()].Rows)
					{
						DataRow dataRow = (DataRow)obj;
						if (dataRow != A_2)
						{
							if (Operators.CompareString(dataRow["ParentTable"].ToString(), A_0, true) == 0 && Operators.CompareString(dataRow["ChildTable"].ToString(), A_1, true) == 0)
							{
								return true;
							}
							if (Operators.CompareString(dataRow["ParentTable"].ToString(), A_1, true) == 0 && Operators.CompareString(dataRow["ChildTable"].ToString(), A_0, true) == 0)
							{
								return true;
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
				result = false;
			}
			return result;
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x0020307C File Offset: 0x0020127C
		internal static void <<EMPTY_NAME>>(string A_0)
		{
			DataRelation dataRelation = O_O0OO.OOOo.oo_OOOO_0.().Relations[A_0];
			DataTable parentTable = dataRelation.ParentTable;
			DataTable childTable = dataRelation.ChildTable;
			try
			{
				foreach (Foxtable.Table table in OO_00oOO.Tables)
				{
					if (table.DataTable.BaseTable == parentTable || table.DataTable.BaseTable == childTable)
					{
						table._frdTableLayout.OOooOOo_.0_0_o.();
					}
				}
			}
			finally
			{
				IEnumerator<Foxtable.Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			string value = string.Concat(new string[]
			{
				".",
				dataRelation.ParentTable.TableName,
				".",
				dataRelation.ChildTable.TableName,
				"."
			});
			string value2 = string.Concat(new string[]
			{
				".",
				dataRelation.ChildTable.TableName,
				".",
				dataRelation.ParentTable.TableName,
				"."
			});
			for (int i = OO_00oOO.Tables.Count - 1; i >= 0; i += -1)
			{
				Foxtable.Table table2 = OO_00oOO.Tables[i];
				if (table2.View.O0O_0_0__.0O.() != null)
				{
					string text = "." + table2.View.Oo._Oo0OO.() + ".";
					if (text.IndexOf(value) >= 0 || text.IndexOf(value2) >= 0)
					{
						bool a_ = OO_00oOO.SystemReady;
						OO_00oOO.SystemReady = false;
						table2.Filter = "";
						OO_00oOO.SystemReady = a_;
						O_O0OO.o__.O.().Remove(table2.View.Oo._Oo0OO.());
						OO_00oOO.Tables.OO._O_o__.(table2.Name);
						O_oOooO_O o_oOooO_O = table2.foxGrid;
						int @fixed = o_oOooO_O.Cols.Fixed;
						int num = o_oOooO_O.Cols.Count - 1;
						for (int j = @fixed; j <= num; j++)
						{
							o_oOooO_O.Cols[j].Editor = null;
						}
						O_0 o_ = o_oOooO_O.o.0O_O0o_..View;
						table2.foxGrid = null;
						o_oOooO_O.o.0O_O0o_. = null;
						if (o_oOooO_O.FindForm() != null)
						{
							System.Windows.Forms.Control parent = o_oOooO_O.Parent;
							while (!(parent is o_O0_0O0))
							{
								parent = parent.Parent;
							}
							((o_O0_0O0)parent).o_o.O___0o.(o_oOooO_O);
						}
						o_oOooO_O.SetDataBinding(null, null);
						o_.Dispose();
						o_oOooO_O.o.o0OO00oO_0.();
						o_oOooO_O.Dispose();
					}
				}
			}
			DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()];
			for (int k = dataTable.Rows.Count - 1; k >= 0; k += -1)
			{
				string text2 = "." + dataTable.Rows[k]["Table"].ToString() + ".";
				if (text2.IndexOf(value2) >= 0 || text2.IndexOf(value2) > 0)
				{
					dataTable.Rows[k].Delete();
				}
			}
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
			O_O0OO.OOOo.oo_OOOO_0.().Relations.Remove(A_0);
			List<Foxtable.Table> list = new List<Foxtable.Table>();
			try
			{
				foreach (Foxtable.Table table3 in OO_00oOO.Tables)
				{
					if (table3.foxGrid.FindForm() != null && table3.O.__O0o0.(false, false))
					{
						list.Add(table3);
					}
				}
			}
			finally
			{
				IEnumerator<Foxtable.Table> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			try
			{
				foreach (Foxtable.Table table4 in OO_00oOO.Tables)
				{
					if (table4.DataTable.BaseTable == parentTable || table4.DataTable.BaseTable == childTable)
					{
						table4._frdTableLayout.Oo_.oo_oOo_oO.();
					}
				}
			}
			finally
			{
				IEnumerator<Foxtable.Table> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			try
			{
				foreach (Foxtable.Table table5 in list)
				{
					TableEventArgs tableEventArgs = new TableEventArgs(table5);
					O_O0OO.OoO_o.oO0o0O.(table5.DataTable.o_0_00_.oo0O0., "AfterLoadTableSetting", new object[]
					{
						tableEventArgs
					}, true, table5.DataTable.Name, false);
				}
			}
			finally
			{
				List<Foxtable.Table>.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
			Main.OO_O.o..Refresh();
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00203504 File Offset: 0x00201704
		internal static void <<EMPTY_NAME>>(string A_0, bool A_1, bool A_2 = true)
		{
			List<O_0> list = new List<O_0>();
			List<O_0> list2 = new List<O_0>();
			if (O_O0OO.OOOo.oo_OOOO_0.().Relations.Contains(A_0))
			{
				O0Oo o0Oo = (O0Oo)O_O0OO.OOOo.oo_OOOO_0.().Relations[A_0];
				if (o0Oo.oo0__.0Oo0o_.() != RelationPathEnum.None)
				{
					if (o0Oo.ParentTable == o0Oo.ChildTable)
					{
						list.Add(OO_00oOO.Tables[o0Oo.ParentTable.TableName].View);
					}
					else
					{
						try
						{
							foreach (O_0 o_ in O_O0OO.o__.O.().Values)
							{
								if ((o_.O0O_0_0__.0O.() == null || o_.O0O_0_0__.0O.().ParentTable != o_.O0O_0_0__.0O.().ChildTable) && !o_.O0O.o__0.())
								{
									if (o_.o_o.O0ooOo.() == o0Oo.ParentTable)
									{
										list.Add(o_);
									}
									else if (o_.o_o.O0ooOo.() == o0Oo.ChildTable && o0Oo.oo0__.0Oo0o_.() == RelationPathEnum.Both)
									{
										list2.Add(o_);
									}
								}
							}
						}
						finally
						{
							Dictionary<string, O_0>.ValueCollection.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					try
					{
						foreach (O_0 o_2 in list)
						{
							if (o_2.o_oo._0Oo.())
							{
								o0OoOOoOOo0.o_OOo_0.0O.(O_O0OO.o__.O.(), o_2, O_O0OO.OOOo.oo_OOOO_0.(), o0Oo, false);
							}
							else
							{
								o0OoOOoOOo0.o_OOo_0.0O.(O_O0OO.o__.O.(), o_2, O_O0OO.OOOo.oo_OOOO_0.(), o0Oo, true);
							}
						}
					}
					finally
					{
						List<O_0>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					try
					{
						foreach (O_0 o_3 in list2)
						{
							if (o_3.o_oo._0Oo.())
							{
								o0OoOOoOOo0.O_0_Oo_00.O.(O_O0OO.o__.O.(), o_3, O_O0OO.OOOo.oo_OOOO_0.(), o0Oo, false);
							}
							else
							{
								o0OoOOoOOo0.O_0_Oo_00.O.(O_O0OO.o__.O.(), o_3, O_O0OO.OOOo.oo_OOOO_0.(), o0Oo, true);
							}
						}
					}
					finally
					{
						List<O_0>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				if (A_2)
				{
					List<Foxtable.Table> list3 = new List<Foxtable.Table>();
					try
					{
						foreach (Foxtable.Table table in OO_00oOO.Tables)
						{
							if (table.foxGrid.FindForm() != null && table.O.__O0o0.(false, false))
							{
								list3.Add(table);
							}
						}
					}
					finally
					{
						IEnumerator<Foxtable.Table> enumerator4;
						if (enumerator4 != null)
						{
							enumerator4.Dispose();
						}
					}
					OO_00oOO.Tables.OO._O_o__.();
					Main.OO_O.o..o0_o_o_0.0O.(o0Oo, A_1);
					OO_00oOO.Tables[o0Oo.ParentTable.TableName].View.o_._0O0o_OoO.();
					OO_00oOO.Tables[o0Oo.ChildTable.TableName].View.o_._0O0o_OoO.();
					try
					{
						foreach (Foxtable.Table table2 in list3)
						{
							TableEventArgs tableEventArgs = new TableEventArgs(table2);
							O_O0OO.OoO_o.oO0o0O.(table2.DataTable.o_0_00_.oo0O0., "AfterLoadTableSetting", new object[]
							{
								tableEventArgs
							}, true, table2.DataTable.Name, false);
						}
					}
					finally
					{
						List<Foxtable.Table>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
			}
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x00203834 File Offset: 0x00201A34
		internal static MultiColumnDictionary <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5)
		{
			int num;
			MultiColumnDictionary result;
			int num5;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(A_0))
				{
					goto IL_204;
				}
				IL_1E:
				num2 = 3;
				if (!O_O0OO.OOOo.oo_OOOO_0.().Tables[A_0].Columns.Contains(A_2))
				{
					goto IL_204;
				}
				IL_40:
				num2 = 4;
				if (!O_O0OO.OOOo.oo_OOOO_0.().Tables[A_0].Columns.Contains(A_3))
				{
					goto IL_204;
				}
				IL_62:
				num2 = 5;
				DataView dataView = new DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables[A_0]);
				IL_7B:
				num2 = 6;
				if (Operators.CompareString(A_4, "", true) <= 0)
				{
					goto IL_A5;
				}
				IL_8D:
				num2 = 7;
				A_4 = A_4 + " And " + A_2 + " Is Not Null";
				goto IL_B5;
				IL_A5:
				num2 = 9;
				A_4 = A_2 + " Is Not Null";
				IL_B5:
				num2 = 10;
				dataView.RowFilter = A_4;
				IL_C1:
				num2 = 11;
				dataView.Sort = A_5;
				IL_CD:
				num2 = 12;
				if (Operators.CompareString(A_1, "", true) <= 0)
				{
					goto IL_163;
				}
				IL_E2:
				num2 = 13;
				List<string> list = new List<string>();
				IL_EC:
				num2 = 14;
				list.AddRange(A_1.Split(new char[]
				{
					','
				}));
				IL_107:
				num2 = 15;
				int num3 = list.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_11A:
					num2 = 16;
					list[i] = list[i].Trim();
					IL_134:
					num2 = 17;
				}
				IL_143:
				num2 = 18;
				result = new MultiColumnDictionary(dataView, A_2, list.ToArray(), list.IndexOf(A_3));
				goto IL_209;
				IL_163:
				num2 = 20;
				List<string> list2 = new List<string>();
				IL_16D:
				num2 = 21;
				IEnumerator enumerator = O_O0OO.OOOo.oo_OOOO_0.().Tables[A_0].Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataColumn dataColumn = (DataColumn)obj;
					IL_19C:
					num2 = 22;
					if (!o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName))
					{
						IL_1B2:
						num2 = 23;
						list2.Add(dataColumn.ColumnName);
					}
					IL_1C3:
					num2 = 24;
				}
				IL_1CF:
				num2 = 25;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_1E7:
				num2 = 26;
				result = new MultiColumnDictionary(dataView, A_2, list2.ToArray(), list2.IndexOf(A_3));
				goto IL_209;
				IL_204:
				num2 = 27;
				result = null;
				IL_209:
				goto IL_2CB;
				IL_20E:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_28C:
				goto IL_2C0;
				IL_28E:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_29E:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_28E;
			}
			IL_2C0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2CB:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x00203B34 File Offset: 0x00201D34
		internal static void <<EMPTY_NAME>>(DataTable A_0)
		{
			string text = "一二三四五六七八九十";
			int num = 0;
			do
			{
				DataRow dataRow = A_0.NewRow();
				dataRow["列名"] = "第" + Conversions.ToString(text[num]) + "列";
				dataRow["类型"] = ColumnDataTypeEnum.String;
				dataRow["标题"] = "";
				dataRow["长度"] = "16";
				A_0.Rows.Add(dataRow);
				num++;
			}
			while (num <= 9);
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x00203BC0 File Offset: 0x00201DC0
		internal static void <<EMPTY_NAME>>(DataRow A_0)
		{
			if (A_0.HasVersion(DataRowVersion.Original) && A_0.Table.DataSet != null)
			{
				try
				{
					foreach (object obj in A_0.Table.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj;
						if ((!o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) || Operators.CompareString(dataColumn.ColumnName, "_SortKey", true) == 0 || (Operators.CompareString(dataColumn.ColumnName, "_Locked", true) == 0 && OO_00oOO.DataTables[A_0.Table.TableName].O000_00._0_o.)) && string.Compare(A_0[dataColumn, DataRowVersion.Current].ToString(), A_0[dataColumn, DataRowVersion.Original].ToString(), StringComparison.Ordinal) != 0)
						{
							return;
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
				A_0.AcceptChanges();
			}
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x00203CC8 File Offset: 0x00201EC8
		internal static bool <<EMPTY_NAME>>(C1FlexGrid A_0, string A_1)
		{
			string text = "_Identify";
			List<string> list = new List<string>();
			string text2 = "";
			bool result;
			if (A_0.Cols.Count - A_0.Cols.Fixed > 253)
			{
				MessageBox.Show("列数超过253,无法导入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (A_0.Cols.Fixed == A_0.Cols.Count)
			{
				MessageBox.Show("没有数据可导入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(A_1, "");
				o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(true);
				if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() == DialogResult.OK)
				{
					string text3 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
					string text4 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.();
					Foxtable.RibbonMenu.StatusBar.Message1 = "导入进程:";
					Foxtable.RibbonMenu.StatusBar.ProgressBar.Visible = true;
					Foxtable.RibbonMenu.StatusBar.ProgressBar.Value = 0;
					Foxtable.RibbonMenu.StatusBar.Message2 = "0%";
					Application.DoEvents();
					o_oo0 o_oo = new o_oo0(O_O0OO.OoO.0OO__0ooo.(), false, true);
					try
					{
						o_oo.o0_oo0._.().Open("", "", "", -1);
						o_oo.o0_oo0._.().ActiveConnection = o_oo.o0_oo0._.();
						ADOX.Table table = new TableClass();
						Index index = new IndexClass();
						table.Name = "~TMPCLP" + text3;
						table.Columns.Append("_Identify", ADOX.DataTypeEnum.adInteger, 0);
						table.Columns.Append("_Locked", ADOX.DataTypeEnum.adBoolean, 0);
						index.Name = "PrimaryKey";
						index.Columns.Append("_Identify", ADOX.DataTypeEnum.adVarWChar, 0);
						index.PrimaryKey = true;
						index.Unique = true;
						table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
						int @fixed = A_0.Cols.Fixed;
						int num = A_0.Cols.Count - 1;
						for (int i = @fixed; i <= num; i++)
						{
							string item = A_0[0, i].ToString();
							int num2 = 16;
							if (!o_O_o_oOoo__.oO.O_..Contains(item))
							{
								int fixed2 = A_0.Rows.Fixed;
								int num3 = A_0.Rows.Count - 1;
								for (int j = fixed2; j <= num3; j++)
								{
									if (A_0[j, i] != null)
									{
										num2 = Math.Max(num2, A_0[j, i].ToString().Length);
									}
								}
								if (num2 <= 255)
								{
									table.Columns.Append(A_0[0, i].ToString(), ADOX.DataTypeEnum.adVarWChar, num2);
								}
								else
								{
									table.Columns.Append(A_0[0, i].ToString(), ADOX.DataTypeEnum.adLongVarWChar, 0);
								}
								table.Columns[A_0[0, i].ToString()].Attributes = ColumnAttributesEnum.adColNullable;
								text += ",";
								text = text + "[" + A_0[0, i].ToString() + "]";
								list.Add(A_0[0, i].ToString());
							}
						}
						text = "(" + text + ")";
						o_oo.o0_oo0._.().Tables.Append(table);
						Foxtable.RibbonMenu.StatusBar.ProgressBar.Value = 5;
						Foxtable.RibbonMenu.StatusBar.Message2 = "50%";
						Application.DoEvents();
						int fixed3 = A_0.Rows.Fixed;
						int num4 = A_0.Rows.Count - 1;
						object objectValue;
						for (int k = fixed3; k <= num4; k++)
						{
							text2 = (k - A_0.Rows.Fixed + 1).ToString();
							try
							{
								foreach (string colName in list)
								{
									text2 += ",";
									if (A_0[k, colName] == null || A_0[k, colName] == DBNull.Value)
									{
										text2 += "Null";
									}
									else
									{
										text2 = text2 + "'" + A_0[k, colName].ToString() + "'";
									}
								}
							}
							finally
							{
								List<string>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							if (k % 100 == 0)
							{
								Foxtable.RibbonMenu.StatusBar.ProgressBar.Value = (int)Math.Round((double)(k - A_0.Rows.Fixed) / (double)(A_0.Rows.Count - A_0.Rows.Fixed) / 2.0 * 100.0) + 50;
								Foxtable.RibbonMenu.StatusBar.Message2 = Foxtable.RibbonMenu.StatusBar.ProgressBar.Value.ToString() + "%";
								Application.DoEvents();
							}
							_Connection connection = o_oo.o0_oo0._.();
							string commandText = string.Concat(new string[]
							{
								"Insert into [~TMPCLP",
								text3,
								"] ",
								text,
								" values (",
								text2,
								")"
							});
							objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
							connection.Execute(commandText, out objectValue, -1);
						}
						_Connection connection2 = o_oo.o0_oo0._.();
						string commandText2 = string.Concat(new string[]
						{
							"Delete * From [",
							ooO0__OO.O00.O__o.(),
							"] Where [Table]  = '",
							table.Name,
							"'"
						});
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						connection2.Execute(commandText2, out objectValue, -1);
						_Connection connection3 = o_oo.o0_oo0._.();
						string commandText3 = string.Concat(new string[]
						{
							"Insert into [",
							ooO0__OO.O00.O__o.(),
							"] ([Table],[Identify]) values ('",
							table.Name,
							"',",
							Conversions.ToString(A_0.Rows.Count - A_0.Rows.Fixed + 1),
							")"
						});
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						connection3.Execute(commandText3, out objectValue, -1);
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
					finally
					{
						if (o_oo.o0_oo0._.().State == 1)
						{
							o_oo.o0_oo0._.().Close();
						}
						o_oo.ooo.0.();
					}
					if (o_oo.o0_oo0._.().oooO__O_0o_.o_.(text3))
					{
						O_O0OO.OoO.0OO__0ooo.().Open();
						o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.DataTables, O_O0OO.OOOo.oo_OOOO_0.(), "~TMPCLP" + text3, true, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), false);
						OO_00oOO.DataTables[text3].Caption = text4;
						OO_00oOO.DataTables[text3].o.0O000_.();
						O_O0OO.OoO.0OO__0ooo.().Close();
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[text3]);
						Main.OO_O.o..o0_o_o_0.0O.(text3, true, false);
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
						MessageBox.Show("导入成功，新表中每一列的数据类型均默认为字符型，请重新设置为正确的类型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						if (Operators.CompareString(text4, "", true) > 0)
						{
							OO_00oOO.DataTables[text3].OO00_o.ooOO.(false);
						}
						O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
					}
					Foxtable.RibbonMenu.StatusBar.Message1 = "";
					Foxtable.RibbonMenu.StatusBar.ProgressBar.Visible = false;
					Foxtable.RibbonMenu.StatusBar.Message2 = "";
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x0020441C File Offset: 0x0020261C
		internal static bool <<EMPTY_NAME>>(C1FlexGrid A_0, string A_1, TableMergeTypeEnum A_2)
		{
			DataTable dataTable = OO_00oOO.MainTable.DataTable.BaseTable;
			bool flag = true;
			checked
			{
				if (OO_00oOO.MainTable.DataTable.frd_IsInnerTable)
				{
					if (!A_0.Cols.Contains("_Identify"))
					{
						flag = false;
					}
				}
				else
				{
					DataColumn[] primaryKey = dataTable.PrimaryKey;
					int i = 0;
					while (i < primaryKey.Length)
					{
						DataColumn dataColumn = primaryKey[i];
						if (!A_0.Cols.Contains(dataColumn.ColumnName))
						{
							flag = false;
							if (dataTable.PrimaryKey.Length != 1 || !dataTable.PrimaryKey[0].AutoIncrement)
							{
								MessageBox.Show("对于非兼容外部表，如果主键列不是自动增量型，则所有主键列必须在要合并的表中，有同名、同类型的对应列，否则无法合并。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								return false;
							}
							break;
						}
						else
						{
							i++;
						}
					}
				}
				Foxtable.RibbonMenu.StatusBar.Message1 = "正在合并...";
				Application.DoEvents();
			}
			try
			{
				OO_00oOO.MainTable.StopRedraw();
				Application.DoEvents();
				int @fixed = A_0.Rows.Fixed;
				int num = A_0.Rows.Count - 1;
				for (int j = @fixed; j <= num; j++)
				{
					DataRow dataRow = null;
					if (flag & A_2 != TableMergeTypeEnum.IgnorePrimaryKey)
					{
						object[] array = new object[dataTable.PrimaryKey.Length - 1 + 1];
						int num2 = dataTable.PrimaryKey.Length - 1;
						for (int k = 0; k <= num2; k++)
						{
							array[k] = RuntimeHelpers.GetObjectValue(A_0[j, dataTable.PrimaryKey[k].ColumnName]);
						}
						dataRow = dataTable.Rows.Find(array);
					}
					if (A_2 == TableMergeTypeEnum.UpdateExistRow || dataRow == null)
					{
						if (dataRow == null)
						{
							dataRow = dataTable.NewRow();
						}
						try
						{
							foreach (object obj in dataTable.Columns)
							{
								DataColumn dataColumn2 = (DataColumn)obj;
								if (A_0.Cols.Contains(dataColumn2.ColumnName) && A_0[j, dataColumn2.ColumnName] != null)
								{
									dataRow[dataColumn2] = RuntimeHelpers.GetObjectValue(A_0[j, dataColumn2.ColumnName]);
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
						if (dataRow.RowState == DataRowState.Detached)
						{
							dataTable.Rows.Add(dataRow);
						}
						int num3;
						num3++;
						if (num3 % 100 == 0)
						{
							Foxtable.RibbonMenu.StatusBar.Message1 = "正在合并，已经合并" + Conversions.ToString(num3) + "条记录";
							Application.DoEvents();
						}
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				return false;
			}
			finally
			{
				OO_00oOO.MainTable.ResumeRedraw();
				Foxtable.RibbonMenu.StatusBar.Message1 = "";
			}
			return true;
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x002046E4 File Offset: 0x002028E4
		internal static Type <<EMPTY_NAME>>(ColumnDataTypeEnum A_0)
		{
			if (A_0 <= ColumnDataTypeEnum.Byte)
			{
				switch (A_0)
				{
				case ColumnDataTypeEnum.Short:
					return typeof(short);
				case ColumnDataTypeEnum.Integer:
					return typeof(int);
				case ColumnDataTypeEnum.Single:
					return typeof(float);
				case ColumnDataTypeEnum.Double:
					return typeof(double);
				case (ColumnDataTypeEnum)6:
				case (ColumnDataTypeEnum)8:
				case (ColumnDataTypeEnum)9:
				case (ColumnDataTypeEnum)10:
					break;
				case ColumnDataTypeEnum.DateTime:
					return typeof(DateTime);
				case ColumnDataTypeEnum.Boolean:
					return typeof(bool);
				default:
					if (A_0 == ColumnDataTypeEnum.Byte)
					{
						return typeof(byte);
					}
					break;
				}
			}
			else
			{
				if (A_0 == ColumnDataTypeEnum.Long)
				{
					return typeof(long);
				}
				if (A_0 == ColumnDataTypeEnum.Decimal)
				{
					return typeof(decimal);
				}
				if (A_0 - ColumnDataTypeEnum.String <= 1)
				{
					return typeof(string);
				}
			}
			return typeof(object);
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x002047E0 File Offset: 0x002029E0
		internal static ColumnDataTypeEnum <<EMPTY_NAME>>(Type A_0, DataCol A_1)
		{
			ColumnDataTypeEnum result;
			if (A_0 == typeof(bool))
			{
				result = ColumnDataTypeEnum.Boolean;
			}
			else if (A_0 == typeof(byte))
			{
				result = ColumnDataTypeEnum.Byte;
			}
			else if (A_0 == typeof(DateTime))
			{
				result = ColumnDataTypeEnum.DateTime;
			}
			else if (A_0 == typeof(decimal))
			{
				result = ColumnDataTypeEnum.Decimal;
			}
			else if (A_0 == typeof(double))
			{
				result = ColumnDataTypeEnum.Double;
			}
			else if (A_0 == typeof(int))
			{
				result = ColumnDataTypeEnum.Integer;
			}
			else if (A_0 == typeof(long))
			{
				result = ColumnDataTypeEnum.Long;
			}
			else if (A_0 == typeof(short))
			{
				result = ColumnDataTypeEnum.Short;
			}
			else if (A_0 == typeof(float))
			{
				result = ColumnDataTypeEnum.Single;
			}
			else if (A_0 == typeof(string))
			{
				if (A_1.BaseColumn.MaxLength >= 1 && A_1.BaseColumn.MaxLength <= 255)
				{
					result = ColumnDataTypeEnum.String;
				}
				else
				{
					result = ColumnDataTypeEnum.Text;
				}
			}
			return result;
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x002048D8 File Offset: 0x00202AD8
		internal static ADOXType <<EMPTY_NAME>>(Type A_0, DataCol A_1)
		{
			ADOXType result;
			if (A_0 == typeof(bool))
			{
				result = ADOXType.Boolean;
			}
			else if (A_0 == typeof(byte))
			{
				result = ADOXType.Byte;
			}
			else if (A_0 == typeof(DateTime))
			{
				result = ADOXType.DateTime;
			}
			else if (A_0 == typeof(decimal))
			{
				result = ADOXType.Decimal;
			}
			else if (A_0 == typeof(double))
			{
				result = ADOXType.Double;
			}
			else if (A_0 == typeof(int))
			{
				result = ADOXType.Integer;
			}
			else if (A_0 == typeof(long))
			{
				result = ADOXType.Long;
			}
			else if (A_0 == typeof(short))
			{
				result = ADOXType.Short;
			}
			else if (A_0 == typeof(float))
			{
				result = ADOXType.Single;
			}
			else if (A_0 == typeof(string))
			{
				if (A_1.BaseColumn.MaxLength >= 1 && A_1.BaseColumn.MaxLength <= 255)
				{
					result = ADOXType.String;
				}
				else
				{
					result = ADOXType.Text;
				}
			}
			return result;
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x002049C0 File Offset: 0x00202BC0
		internal static bool <<EMPTY_NAME>>()
		{
			bool result;
			int num3;
			int num5;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				if (!O_O0OO.O_O00OOooo.O_.)
				{
					goto IL_27;
				}
				IL_09:
				num = 2;
				MessageBox.Show("正在加载数据的过程中，暂不能关闭项目!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_1E:
				num = 3;
				result = false;
				goto IL_7C0;
				IL_27:
				num = 4;
				if (OO_00oOO.CurrentTable == null)
				{
					goto IL_C8;
				}
				IL_33:
				num = 5;
				if (OO_00oOO.CurrentTable.foxGrid.Editor == null)
				{
					goto IL_74;
				}
				IL_46:
				num = 6;
				OO_00oOO.CurrentTable.foxGrid.FinishEditing();
				IL_58:
				num = 7;
				if (OO_00oOO.CurrentTable.foxGrid.Editor == null)
				{
					goto IL_74;
				}
				IL_6B:
				num = 8;
				result = false;
				goto IL_7C0;
				IL_74:
				num = 9;
				if (OO_00oOO.CurrentTable.o00oOO00_.ooOo. == null)
				{
					goto IL_C8;
				}
				IL_83:
				num = 10;
				if (OO_00oOO.CurrentTable.o00oOO00_.ooOo..Editor == null)
				{
					goto IL_C8;
				}
				IL_97:
				num = 11;
				OO_00oOO.CurrentTable.o00oOO00_.ooOo..FinishEditing();
				IL_AA:
				num = 12;
				if (OO_00oOO.CurrentTable.o00oOO00_.ooOo..Editor == null)
				{
					goto IL_C8;
				}
				IL_BE:
				num = 13;
				result = false;
				goto IL_7C0;
				IL_C8:
				num = 14;
				bool flag;
				switch (O_O0OO.O0_00o.o0__o..BackPeriod)
				{
				case PeriodEnum.天:
					IL_F9:
					num = 16;
					if (DateTime.Compare(DateTime.Today.AddDays(-1.0), O_O0OO.O0_00o.o0__o..LastBackUpdate) < 0)
					{
						break;
					}
					IL_128:
					num = 17;
					flag = true;
					break;
				case PeriodEnum.周:
					IL_165:
					num = 22;
					if (DateTime.Compare(DateTime.Today.AddDays(-7.0), O_O0OO.O0_00o.o0__o..LastBackUpdate) < 0)
					{
						break;
					}
					IL_191:
					num = 23;
					flag = true;
					break;
				case PeriodEnum.月:
					IL_133:
					num = 19;
					if (DateTime.Compare(DateTime.Today.AddMonths(-1), O_O0OO.O0_00o.o0__o..LastBackUpdate) < 0)
					{
						break;
					}
					IL_15A:
					num = 20;
					flag = true;
					break;
				case PeriodEnum.季:
					IL_199:
					num = 25;
					if (DateTime.Compare(DateTime.Today.AddMonths(-3), O_O0OO.O0_00o.o0__o..LastBackUpdate) < 0)
					{
						break;
					}
					IL_1BE:
					num = 26;
					flag = true;
					break;
				case PeriodEnum.年:
					IL_1C6:
					num = 28;
					if (DateTime.Compare(DateTime.Today.AddYears(-1), O_O0OO.O0_00o.o0__o..LastBackUpdate) < 0)
					{
						break;
					}
					IL_1EA:
					num = 29;
					flag = true;
					break;
				}
				IL_1F0:
				num = 31;
				if (!flag)
				{
					goto IL_205;
				}
				IL_1F7:
				num = 32;
				Project.Backup("", true);
				IL_205:
				num = 33;
				BeforeCloseProjectEventArgs beforeCloseProjectEventArgs = new BeforeCloseProjectEventArgs();
				IL_20F:
				num = 34;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeCloseProject", new object[]
				{
					beforeCloseProjectEventArgs
				}, false, "项目", false);
				IL_234:
				num = 35;
				if (!beforeCloseProjectEventArgs.Cancel)
				{
					goto IL_24A;
				}
				IL_240:
				num = 36;
				result = false;
				goto IL_7C0;
				IL_24A:
				num = 37;
				if (!OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "Bin\\TempFiles"))
				{
					goto IL_2BF;
				}
				IL_268:
				num = 38;
				IEnumerator<string> enumerator = OO_00oOO.FileSys.GetFiles(OO_00oOO.ProjectPath + "Bin\\TempFiles").GetEnumerator();
				while (enumerator.MoveNext())
				{
					string file = enumerator.Current;
					IL_296:
					num = 39;
					OO_00oOO.FileSys.DeleteFile(file);
					IL_2A5:
					num = 40;
				}
				IL_2B1:
				num = 41;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_2BF:
				num = 42;
				if (!OO_00oOO.FileSys.DirectoryExists(O_O0OO.o.00O_O.() + "Bin\\TempFiles"))
				{
					goto IL_334;
				}
				IL_2DD:
				num = 43;
				IEnumerator<string> enumerator2 = OO_00oOO.FileSys.GetFiles(O_O0OO.o.00O_O.() + "Bin\\TempFiles").GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string file2 = enumerator2.Current;
					IL_30B:
					num = 44;
					OO_00oOO.FileSys.DeleteFile(file2);
					IL_31A:
					num = 45;
				}
				IL_326:
				num = 46;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_334:
				num = 47;
				if (!OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "HttpTempFiles\\"))
				{
					goto IL_3A9;
				}
				IL_352:
				num = 48;
				IEnumerator<string> enumerator3 = OO_00oOO.FileSys.GetFiles(OO_00oOO.ProjectPath + "HttpTempFiles\\").GetEnumerator();
				while (enumerator3.MoveNext())
				{
					string file3 = enumerator3.Current;
					IL_380:
					num = 49;
					OO_00oOO.FileSys.DeleteFile(file3);
					IL_38F:
					num = 50;
				}
				IL_39B:
				num = 51;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_3A9:
				num = 52;
				Dictionary<string, IMServer>.ValueCollection.Enumerator enumerator4 = OO_00oOO.IMServers.Values.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					IMServer imserver = enumerator4.Current;
					IL_3C8:
					num = 53;
					if (!imserver.o0oo__0Oo_.o00.)
					{
						IL_3D4:
						num = 54;
						imserver.Stop();
					}
					IL_3DE:
					num = 55;
				}
				IL_3EA:
				num = 56;
				((IDisposable)enumerator4).Dispose();
				IL_3FA:
				num = 57;
				OO_00oOO.IMServers.Clear();
				IL_407:
				num = 58;
				Dictionary<string, IMClient>.ValueCollection.Enumerator enumerator5 = OO_00oOO.IMClients.Values.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					IMClient imclient = enumerator5.Current;
					IL_426:
					num = 59;
					if (!imclient.O0_OOo.O.)
					{
						IL_432:
						num = 60;
						imclient.Stop();
					}
					IL_43C:
					num = 61;
				}
				IL_448:
				num = 62;
				((IDisposable)enumerator5).Dispose();
				IL_458:
				num = 63;
				OO_00oOO.IMClients.Clear();
				IL_465:
				num = 64;
				Dictionary<string, UDPClient>.ValueCollection.Enumerator enumerator6 = OO_00oOO.UDPClients.Values.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					UDPClient udpclient = enumerator6.Current;
					IL_484:
					num = 65;
					if (!udpclient.O00ooo._.)
					{
						IL_490:
						num = 66;
						udpclient.Stop();
					}
					IL_49A:
					num = 67;
				}
				IL_4A6:
				num = 68;
				((IDisposable)enumerator6).Dispose();
				IL_4B6:
				num = 69;
				OO_00oOO.UDPClients.Clear();
				IL_4C3:
				num = 70;
				if (!OO_00oOO.HttpServer.IsRunning)
				{
					goto IL_4DF;
				}
				IL_4D2:
				num = 71;
				OO_00oOO.HttpServer.Close();
				IL_4DF:
				num = 72;
				IEnumerator<DataTable> enumerator7 = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator7.MoveNext())
				{
					DataTable dataTable = enumerator7.Current;
					IL_4F9:
					num = 73;
					if (dataTable.frd_IsTemporary || dataTable.frd_IsOuterQuery || dataTable.frd_IsInnerQuery)
					{
						IL_517:
						num = 74;
						dataTable.BaseTable.AcceptChanges();
					}
					IL_526:
					num = 75;
				}
				IL_532:
				num = 76;
				if (enumerator7 != null)
				{
					enumerator7.Dispose();
				}
				IL_540:
				num = 77;
				if (beforeCloseProjectEventArgs.SkipSave || Operators.CompareString(OO_00oOO.ProjectFile, "", true) <= 0 || (!O_O0OO.OoO.0OO__0ooo.().HasChanges() && !O_O0OO.OOOo.oo_OOOO_0.().HasChanges() && !Main.OO_O.o..o._oOO0. && !Oo00.o00O0O_.O.()))
				{
					goto IL_5DC;
				}
				IL_58D:
				num = 78;
				DialogResult dialogResult = MessageBox.Show("保存修改吗？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				IL_5A4:
				num = 79;
				if (dialogResult != DialogResult.Cancel)
				{
					if (dialogResult != DialogResult.Yes)
					{
						goto IL_5DC;
					}
					IL_5B1:
					num = 81;
					Project.Save();
					IL_5B9:
					num = 82;
					if (!O_O0OO.OOOo.oo_OOOO_0.().HasChanges())
					{
						goto IL_5DC;
					}
					IL_5C8:
					num = 83;
					result = false;
					goto IL_7C0;
				}
				IL_5D2:
				num = 85;
				result = false;
				goto IL_7C0;
				IL_5DC:
				num = 87;
				if (!Oo00.o.00.)
				{
					goto IL_6FB;
				}
				IL_5E9:
				num = 88;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"PublishConfigString",
					o0_O.O00__0OO_o.o0O.
				});
				IL_624:
				num = 89;
				if (dataRow != null)
				{
					goto IL_6A3;
				}
				IL_62B:
				num = 90;
				DataTable dataTable2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()];
				IL_644:
				num = 91;
				dataRow = dataTable2.NewRow();
				IL_650:
				num = 92;
				dataRow["Name"] = "PublishConfigString";
				IL_664:
				num = 93;
				dataRow["Type"] = o0_O.O00__0OO_o.o0O.;
				IL_67A:
				num = 94;
				dataRow["Config"] = 0;
				IL_68F:
				num = 95;
				dataTable2.Rows.Add(dataRow);
				IL_6A0:
				dataTable2 = null;
				IL_6A3:
				num = 97;
				string s = dataRow["Config"].ToString();
				IL_6B9:
				num = 98;
				int num2;
				int.TryParse(s, out num2);
				IL_6C6:
				num = 99;
				num2 += Oo00.o.00. / 2;
				IL_6D5:
				num = 100;
				dataRow["Config"] = num2;
				IL_6EB:
				num = 101;
				Oo00.o0_o._O_.(dataRow.Table, true);
				IL_6FB:
				num = 102;
				IEnumerator<Foxtable.WinForm.Form> enumerator8 = OO_00oOO.Forms.GetEnumerator();
				while (enumerator8.MoveNext())
				{
					Foxtable.WinForm.Form form = enumerator8.Current;
					IL_715:
					num = 103;
					form.Close();
					IL_71F:
					num = 104;
					if (form.Opened)
					{
						IL_72B:
						num = 105;
						result = false;
						goto IL_7C0;
					}
					IL_735:
					num = 106;
				}
				IL_741:
				num = 107;
				if (enumerator8 != null)
				{
					enumerator8.Dispose();
				}
				IL_74F:
				num = 108;
				IEnumerator<Foxtable.Table> enumerator9 = OO_00oOO.Tables.GetEnumerator();
				while (enumerator9.MoveNext())
				{
					Foxtable.Table table = enumerator9.Current;
					IL_769:
					num = 109;
					table.CloseRecordGrid();
					IL_773:
					num = 110;
				}
				IL_77F:
				num = 111;
				if (enumerator9 != null)
				{
					enumerator9.Dispose();
				}
				IL_78D:
				ProjectData.ClearProjectError();
				num3 = 1;
				IL_794:
				num = 113;
				if (!OO_00oOO.FileSys.DirectoryExists(O_O0OO.OoO__.0oO0oo.()))
				{
					goto IL_7BB;
				}
				IL_7A8:
				num = 114;
				OO_00oOO.FileSys.DeleteDirectory(O_O0OO.OoO__.0oO0oo.(), DeleteDirectoryOption.DeleteAllContents);
				IL_7BB:
				num = 115;
				result = true;
				IL_7C0:
				goto IL_9E2;
				IL_7C5:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_9A3:
				goto IL_9D7;
				IL_9A5:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_9B5:;
			}
			catch when (endfilter(obj is Exception & num3 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_9A5;
			}
			IL_9D7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_9E2:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x002053D4 File Offset: 0x002035D4
		internal static void <<EMPTY_NAME>>()
		{
			if (!O_O0OO.O0_00o.o0__o..HasUsers)
			{
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()];
				DataRow[] array = dataTable.Select("[Type] = " + Conversions.ToString(0));
				if (array == null || array.Length == 0)
				{
					DataRow dataRow = dataTable.NewRow();
					UserProperty userProperty = new UserProperty();
					userProperty.PassWord = O00.MD5Encrypt(O00.ooo000o_0.00o0.("888", O_O0OO.O_O._Oo.().Substring(0, 8), O_O0OO.O_O._Oo.().Substring(O_O0OO.O_O._Oo.().Length - 8)));
					userProperty.Type = UserTypeEnum.Developer;
					dataRow["Name"] = "开发者";
					dataRow["Type"] = UserTypeEnum.Developer;
					dataRow["Config"] = o_O_o_oOoo__.OOOO_OO._oo.(userProperty, false, '\v', false);
					dataTable.Rows.Add(dataRow);
				}
				array = dataTable.Select("[Type] = " + Conversions.ToString(1));
				if (array == null || array.Length == 0)
				{
					DataRow dataRow2 = dataTable.NewRow();
					UserProperty userProperty2 = new UserProperty();
					userProperty2.Type = UserTypeEnum.Administrator;
					userProperty2.PassWord = O00.MD5Encrypt(O00.ooo000o_0.00o0.("888", O_O0OO.O_O._Oo.().Substring(0, 8), O_O0OO.O_O._Oo.().Substring(O_O0OO.O_O._Oo.().Length - 8)));
					dataRow2["Name"] = "管理员";
					dataRow2["Type"] = UserTypeEnum.Administrator;
					dataRow2["Config"] = o_O_o_oOoo__.OOOO_OO._oo.(userProperty2, false, '\v', false);
					dataTable.Rows.Add(dataRow2);
				}
				Oo00.o0_o._O_.(dataTable, true);
			}
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x00205574 File Offset: 0x00203774
		internal static string <<EMPTY_NAME>>(Foxtable.Table A_0, bool A_1)
		{
			string text = "";
			if (Operators.CompareString(A_0.View.get_Filter(), "", true) > 0 && !A_1)
			{
				text = A_0.Filter;
			}
			if (A_0.IsChild)
			{
				DataRow row = A_0.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row;
				try
				{
					foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
					{
						DataRelation dataRelation = (DataRelation)obj;
						if (dataRelation.ParentTable == row.Table && dataRelation.ChildTable == A_0.View.o_o.O0ooOo.())
						{
							int num = dataRelation.ParentColumns.Length - 1;
							for (int i = 0; i <= num; i++)
							{
								if (Operators.CompareString(text, "", true) > 0)
								{
									text += " And ";
								}
								if (dataRelation.ParentColumns[i].DataType == typeof(string))
								{
									text = string.Concat(new string[]
									{
										text,
										"[",
										dataRelation.ChildColumns[i].ColumnName,
										"] = '",
										row[dataRelation.ParentColumns[i]].ToString(),
										"'"
									});
								}
								else if (dataRelation.ParentColumns[i].DataType == typeof(DateTime))
								{
									text = string.Concat(new string[]
									{
										text,
										"[",
										dataRelation.ChildColumns[i].ColumnName,
										"] = #",
										row[dataRelation.ParentColumns[i]].ToString(),
										"#"
									});
								}
								else
								{
									text = string.Concat(new string[]
									{
										text,
										"[",
										dataRelation.ChildColumns[i].ColumnName,
										"] = ",
										row[dataRelation.ParentColumns[i]].ToString()
									});
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
			return text;
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x002057B4 File Offset: 0x002039B4
		internal static bool <<EMPTY_NAME>>(string A_0)
		{
			string[] array = A_0.Split(new char[]
			{
				'.'
			});
			string key = array[array.Length - 2];
			string a_ = array[array.Length - 1];
			return OO_00oOO.DataTables[O_O0OO.o__.O.()[key].o_o.O0ooOo.().TableName].DataCols[a_].IsNumeric;
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x00205810 File Offset: 0x00203A10
		internal static bool <<EMPTY_NAME>>(string A_0)
		{
			string[] array = A_0.Split(new char[]
			{
				'.'
			});
			string key = array[array.Length - 2];
			string a_ = array[array.Length - 1];
			return OO_00oOO.DataTables[O_O0OO.o__.O.()[key].o_o.O0ooOo.().TableName].DataCols[a_].IsDate;
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x0020586C File Offset: 0x00203A6C
		internal static void <<EMPTY_NAME>>()
		{
			string[] array = new string[]
			{
				"Table",
				"ParentTable",
				"ChildTable"
			};
			List<DataRow> list = new List<DataRow>();
			List<string> dataTableNames = OO_00oOO.DataTables.GetDataTableNames();
			try
			{
				foreach (object obj in O_O0OO.OoO.0OO__0ooo.().Tables)
				{
					DataTable dataTable = (DataTable)obj;
					if (Operators.CompareString(dataTable.TableName, ooO0__OO.oo._O.(), true) != 0)
					{
						foreach (string text in array)
						{
							if (dataTable.Columns.Contains(text))
							{
								try
								{
									foreach (object obj2 in dataTable.Rows)
									{
										DataRow dataRow = (DataRow)obj2;
										if (dataRow.RowState != DataRowState.Deleted && dataRow.RowState != DataRowState.Detached)
										{
											foreach (string text2 in dataRow[text].ToString().Split(new char[]
											{
												'.'
											}))
											{
												text2 = text2.Trim(new char[]
												{
													'{',
													'}',
													'[',
													']'
												});
												bool flag = false;
												try
												{
													List<string>.Enumerator enumerator3 = dataTableNames.GetEnumerator();
													while (enumerator3.MoveNext())
													{
														if (Operators.CompareString(enumerator3.Current, text2, true) == 0)
														{
															flag = true;
														}
													}
												}
												finally
												{
													List<string>.Enumerator enumerator3;
													((IDisposable)enumerator3).Dispose();
												}
												if (Operators.CompareString(text2, "", true) > 0 && !flag && Operators.CompareString(text2, "(ProjectIdentify)", true) != 0)
												{
													list.Add(dataRow);
													break;
												}
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
				foreach (DataRow dataRow2 in list)
				{
					dataRow2.Delete();
				}
			}
			finally
			{
				List<DataRow>.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
			if (O_O0OO.OoO.0OO__0ooo.().HasChanges())
			{
				try
				{
					foreach (object obj3 in O_O0OO.OoO.0OO__0ooo.().Tables)
					{
						Oo00.o0_o._O_.((DataTable)obj3, true);
					}
				}
				finally
				{
					IEnumerator enumerator5;
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x00205B58 File Offset: 0x00203D58
		internal static Binding <<EMPTY_NAME>>(string A_0, string A_1)
		{
			int num = A_1.LastIndexOf('.');
			if (num > 0 && num < A_1.Length - 1)
			{
				string text = A_1.Substring(0, num);
				O_0 o_ = null;
				if (O_O0OO.o__.O.().ContainsKey(text))
				{
					o_ = O_O0OO.o__.O.()[text];
				}
				else
				{
					try
					{
						foreach (string text2 in O_O0OO.o__.O.().Keys)
						{
							if (Operators.CompareString(text2, text, true) == 0)
							{
								o_ = O_O0OO.o__.O.()[text2];
							}
						}
					}
					finally
					{
						Dictionary<string, O_0>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (o_ != null)
				{
					string text3 = A_1.Substring(num + 1);
					if (OO_00oOO.Tables[o_.Oo._Oo0OO.()].DataTable.DataCols.Contains(text3))
					{
						return new Binding(A_0, o_, text3);
					}
				}
			}
			return null;
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x00205C48 File Offset: 0x00203E48
		internal static string <<EMPTY_NAME>>(DataRow A_0, string A_1)
		{
			string text = "";
			string text2 = "";
			try
			{
				foreach (object obj in A_0.Table.DataSet.Relations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (Operators.CompareString(dataRelation.ParentTable.TableName, A_0.Table.TableName, true) == 0 && Operators.CompareString(dataRelation.ChildTable.TableName, A_1, true) == 0)
					{
						int num = dataRelation.ParentColumns.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							if (A_0.IsNull(dataRelation.ParentColumns[i]))
							{
								text = "False";
								break;
							}
							if (Operators.CompareString(text, "", true) > 0)
							{
								text += " And ";
							}
							if (dataRelation.ParentColumns[i].DataType == typeof(string))
							{
								text2 = "'";
							}
							else if (dataRelation.ParentColumns[i].DataType == typeof(DateTime))
							{
								text2 = "#";
							}
							text = string.Concat(new string[]
							{
								text,
								"[",
								dataRelation.ChildColumns[i].ColumnName,
								"] = ",
								text2,
								A_0[dataRelation.ParentColumns[i]].ToString(),
								text2
							});
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
			return text;
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x00205DEC File Offset: 0x00203FEC
		internal static void <<EMPTY_NAME>>(DataRow A_0, Foxtable.Table A_1)
		{
			string text = A_1.Name;
			int num = -1;
			bool flag = OO_00oOO.MainTable == A_1;
			List<DataRow> list = new List<DataRow>();
			int num2 = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (Operators.CompareString(Main.OO_O.o..OO_O_0Oo.___o.().TabPages[i].Name, text, true) == 0)
				{
					num = i;
				}
			}
			ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle);
			DataTable dataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables[text];
			for (int j = dataTable.DataSet.Relations.Count - 1; j >= 0; j += -1)
			{
				O0Oo o0Oo = (O0Oo)dataTable.DataSet.Relations[j];
				if (Operators.CompareString(o0Oo.ParentTable.TableName, text, true) == 0 || Operators.CompareString(o0Oo.ChildTable.TableName, text, true) == 0)
				{
					Oo00.OO.0O0o.(o0Oo.RelationName);
					if (o0Oo.oo0__.0Oo0o_.() != null)
					{
						list.Add(o0Oo.oo0__.0Oo0o_.());
					}
				}
			}
			if (num > -1)
			{
				Main.OO_O.o..OO_O_0Oo.___o.().TabPages.RemoveAt(num);
				OO_00oOO.Tables.OO._O_o__.(text);
				OO_00oOO.DataTables.OoO_00.O.(text);
				O_O0OO.o__.O.().Remove(text);
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(text);
			}
			o0OoOOoOOo0.OOOOO.o000.(A_0, O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), true, false, null);
			try
			{
				foreach (DataRow a_ in list)
				{
					o0OoOOoOOo0.OO0._Oo0o.(a_, O_O0OO.OOOo.oo_OOOO_0.());
				}
			}
			finally
			{
				List<DataRow>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Oo00.oO.OO.(OO_00oOO.DataTables[text].BaseTable);
			OO_00oOO.DataTables[text].o0O.ooO00.();
			OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[text]);
			Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(A_0["Name"]), true, true);
			try
			{
				foreach (DataRow dataRow in list)
				{
					Oo00.o00O0O_.O.(dataRow["Name"].ToString(), true, true);
				}
			}
			finally
			{
				List<DataRow>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			if (num > -1)
			{
				OO___OO0O_0 oo___OO0O_ = Main.OO_O.o..OO_O_0Oo.___o.();
				oo___OO0O_.TabPages.Insert(num, oo___OO0O_.TabPages[oo___OO0O_.TabPages.Count - 1]);
			}
			ShareLibriay.LockWindowUpdate(IntPtr.Zero);
			if (flag)
			{
				OO_00oOO.MainTable = OO_00oOO.Tables[text];
				OO_00oOO.CurrentTable = OO_00oOO.MainTable;
			}
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x002060D8 File Offset: 0x002042D8
		private static void <<EMPTY_NAME>>(DataTable A_0)
		{
			Dictionary<DataColumn, string> dictionary = new Dictionary<DataColumn, string>();
			try
			{
				foreach (object obj in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (Operators.CompareString(A_0.TableName, Conversions.ToString(dataRow["Table"]), true) == 0)
					{
						string text = Conversions.ToString(dataRow["Column"]);
						string value = Conversions.ToString(dataRow["Expression"]);
						ColumnDataTypeEnum columnDataTypeEnum = (ColumnDataTypeEnum)Conversions.ToInteger(dataRow["DataType"]);
						int maxLength;
						if (columnDataTypeEnum == ColumnDataTypeEnum.String && !dataRow.IsNull("Maxlength"))
						{
							maxLength = Conversions.ToInteger(dataRow["Maxlength"]);
						}
						else
						{
							maxLength = -1;
						}
						if (A_0.Columns.Contains(text))
						{
							dataRow.Delete();
						}
						else
						{
							Type type = Oo00.OO.0O0o.(columnDataTypeEnum);
							DataColumn dataColumn = A_0.Columns.Add(text, type);
							if (columnDataTypeEnum == ColumnDataTypeEnum.String)
							{
								dataColumn.MaxLength = maxLength;
							}
							dictionary.Add(dataColumn, value);
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
				foreach (DataColumn dataColumn2 in dictionary.Keys)
				{
					try
					{
						dataColumn2.Expression = dictionary[dataColumn2];
					}
					catch (Exception a_)
					{
						MessageBox.Show(string.Concat(new string[]
						{
							"无法[",
							dataColumn2.ColumnName,
							"]列的表达式设置为:\r\n",
							dictionary[dataColumn2],
							"\r\n如果确定表达式无语法错误，且参与运算的各列的名称准确无误，那么请检查各列的数据类型是否正确，例如只有数值列才能参与加、减、乘、除等数学运算！"
						}), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
						ooO.oOo0Oo.o.(a_, "");
					}
				}
			}
			finally
			{
				Dictionary<DataColumn, string>.KeyCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x00206308 File Offset: 0x00204508
		internal static string <<EMPTY_NAME>>(OleDbConnection A_0, string A_1, bool A_2 = false)
		{
			if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0))
			{
				A_1 = A_1.Replace("{", "").Replace("}", "");
			}
			else
			{
				if (A_0 == O_O0OO.OoO.0OO__0ooo.() || A_2)
				{
					A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "{", "[~TMPCLP");
				}
				else
				{
					A_1 = A_1.Replace("{", "[");
				}
				A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "}", "]");
			}
			A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "\r\nWhere ", "\r\n Where ");
			A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "\r\nOrder By ", "\r\n Order By ");
			return A_1;
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x002063A8 File Offset: 0x002045A8
		internal static string <<EMPTY_NAME>>(DataServerTypeEnum A_0, string A_1, bool A_2 = false)
		{
			if (A_0 == DataServerTypeEnum.Oracle)
			{
				A_1 = A_1.Replace("{", "").Replace("}", "");
			}
			else
			{
				if (A_0 == DataServerTypeEnum.Buildin || A_2)
				{
					A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "{", "[~TMPCLP");
				}
				else
				{
					A_1 = A_1.Replace("{", "[");
				}
				A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "}", "]");
			}
			A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "\r\nWhere ", "\r\n Where ");
			A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "\r\nOrder By ", "\r\n Order By ");
			return A_1;
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x00206440 File Offset: 0x00204640
		internal static string <<EMPTY_NAME>>(OleDbDataAdapter A_0)
		{
			string commandText = A_0.UpdateCommand.CommandText;
			int num;
			int num2;
			if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0.SelectCommand.Connection))
			{
				num = commandText.IndexOf("\"");
				num2 = commandText.IndexOf("\"", num + 1);
			}
			else
			{
				num = commandText.IndexOf("[");
				num2 = commandText.IndexOf("]");
			}
			return commandText.Substring(num + 1, num2 - num - 1);
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x002064B0 File Offset: 0x002046B0
		internal static string <<EMPTY_NAME>>()
		{
			return o_o_O0OO_0__.O.ooOo__o000OO.();
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x002064B7 File Offset: 0x002046B7
		internal static string <<EMPTY_NAME>>()
		{
			return o_o_O0OO_0__.O0_O_o.o_.();
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x002064C0 File Offset: 0x002046C0
		internal static void <<EMPTY_NAME>>(string A_0, ref string A_1, ref string A_2, ref string A_3, ref string A_4, ref string A_5)
		{
			A_0 = A_0.Trim();
			if (A_0.StartsWith("select ", StringComparison.CurrentCultureIgnoreCase))
			{
				string[] array = Regex.Split(A_0, "[\\s]+");
				int num;
				if (Operators.CompareString(array[1].ToLower(), "top", true) == 0)
				{
					num = 1;
				}
				else if (Operators.CompareString(array[2].ToLower(), "top", true) == 0)
				{
					num = 2;
				}
				if (num > 0)
				{
					A_2 = array[num + 1];
					if (Operators.CompareString(array[num + 2].ToLower(), "percent", true) == 0)
					{
						A_2 = A_2 + " " + array[num + 2];
					}
				}
				int num2 = -1;
				Match match = new Regex("[\\s]+from[\\s]+", RegexOptions.IgnoreCase).Match(A_0);
				if (match.Success)
				{
					A_0 = A_0.Substring(match.Index + match.Length);
				}
				if (A_0.StartsWith("("))
				{
					int num3 = 1;
					int num4 = A_0.Length - 1;
					for (int i = 1; i <= num4; i++)
					{
						if (Operators.CompareString(Conversions.ToString(A_0[i]), "(", true) == 0)
						{
							num3++;
						}
						if (Operators.CompareString(Conversions.ToString(A_0[i]), ")", true) == 0)
						{
							num3--;
						}
						if (num3 == 0)
						{
							num2 = i + 1;
							break;
						}
					}
				}
				if (num2 == -1)
				{
					match = new Regex("[\\s]*[\\S]+[\\s]*", RegexOptions.IgnoreCase).Match(A_0);
					if (match.Success)
					{
						num2 = match.Index + match.Length;
					}
				}
				if (num2 > -1)
				{
					A_0 = A_0.Substring(num2);
				}
				array = Regex.Split(A_0, "[\\s]+");
				int num5 = array.Length - 1;
				for (int j = array.Length - 1; j >= 0; j += -1)
				{
					if (Operators.CompareString(array[j].ToLower(), "by", true) == 0)
					{
						if (Operators.CompareString(array[j - 1], "order", true) == 0)
						{
							int num6 = j + 1;
							int num7 = num5;
							for (int k = num6; k <= num7; k++)
							{
								A_5 = A_5 + array[k] + " ";
							}
							A_5 = A_5.Trim();
							num5 = j - 2;
						}
						if (Operators.CompareString(array[j - 1].ToLower(), "group", true) == 0)
						{
							int num8 = j + 1;
							int num9 = num5;
							for (int l = num8; l <= num9; l++)
							{
								A_3 = A_3 + array[l] + " ";
							}
							A_3 = A_3.Trim();
							num5 = j - 2;
						}
					}
					else if (Operators.CompareString(array[j].ToLower(), "having", true) == 0)
					{
						int num10 = j + 1;
						int num11 = num5;
						for (int m = num10; m <= num11; m++)
						{
							A_4 = A_4 + array[m] + " ";
						}
						A_4 = A_4.Trim();
						num5 = j - 1;
					}
					else if (Operators.CompareString(array[j].ToLower(), "where", true) == 0)
					{
						int num12 = j + 1;
						int num13 = num5;
						for (int n = num12; n <= num13; n++)
						{
							A_1 = A_1 + array[n] + " ";
						}
						A_1 = A_1.Trim();
						num5 = j - 1;
					}
				}
			}
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x002067CC File Offset: 0x002049CC
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			string[] array = Regex.Split(A_0, "[\\s]+");
			A_0 = "";
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(array[i], "From", true) == 0)
				{
					return array[i + 1].TrimStart(new char[]
					{
						'('
					}).TrimEnd(new char[]
					{
						')'
					});
				}
			}
			return "";
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x00206840 File Offset: 0x00204A40
		internal static int <<EMPTY_NAME>>(string A_0)
		{
			int num = 0;
			Match match = new Regex("[\\s]+from[\\s]+", RegexOptions.IgnoreCase).Match(A_0, num);
			if (match.Success)
			{
				num = match.Index + match.Length;
			}
			if (A_0[num] == '(')
			{
				int num2 = 1;
				int num3 = num + 1;
				int num4 = A_0.Length - 1;
				for (int i = num3; i <= num4; i++)
				{
					if (Operators.CompareString(Conversions.ToString(A_0[i]), "(", true) == 0)
					{
						num2++;
					}
					if (Operators.CompareString(Conversions.ToString(A_0[i]), ")", true) == 0)
					{
						num2--;
					}
					if (num2 == 0)
					{
						return i + 1;
					}
				}
			}
			return num;
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x002068EC File Offset: 0x00204AEC
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			int startat = 0;
			Match match = new Regex("[\\s]+from[\\s]+", RegexOptions.IgnoreCase).Match(A_0, startat);
			if (match.Success)
			{
				A_0 = A_0.Substring(match.Index + match.Length);
			}
			startat = 0;
			if (A_0.StartsWith("("))
			{
				int num = 1;
				int num2 = A_0.Length - 1;
				for (int i = 1; i <= num2; i++)
				{
					if (Operators.CompareString(Conversions.ToString(A_0[i]), "(", true) == 0)
					{
						num++;
					}
					if (Operators.CompareString(Conversions.ToString(A_0[i]), ")", true) == 0)
					{
						num--;
					}
					if (num == 0)
					{
						startat = i;
						break;
					}
				}
			}
			match = new Regex("[\\s]+where[\\s]+", RegexOptions.IgnoreCase).Match(A_0, startat);
			if (match.Success)
			{
				A_0 = A_0.Substring(0, match.Index);
			}
			match = new Regex("[\\s]+order[\\s]+by[\\s]+", RegexOptions.IgnoreCase).Match(A_0, startat);
			string result;
			if (match.Success)
			{
				result = A_0.Substring(0, match.Index);
			}
			else
			{
				result = A_0;
			}
			return result;
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x002069F4 File Offset: 0x00204BF4
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			string text = Oo00.oo_0__0.o.(A_0).Trim();
			string result;
			if (text.StartsWith("(") && text.EndsWith(")"))
			{
				result = text;
			}
			else
			{
				string[] array = Regex.Split(text, "[\\s]+");
				if (array.Length >= 3 && Operators.CompareString(array[array.Length - 2], "as", true) == 0)
				{
					result = array[array.Length - 1];
				}
				else if (array.Length >= 2)
				{
					result = array[array.Length - 1];
				}
				else
				{
					result = text;
				}
			}
			return result;
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00206A70 File Offset: 0x00204C70
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			Regex regex = new Regex("[\\s]+from[\\s]+", RegexOptions.IgnoreCase);
			Match match = regex.Match(A_0);
			if (match.Success)
			{
				A_0 = A_0.Substring(match.Index + match.Length);
			}
			if (A_0.StartsWith("("))
			{
				int num = 1;
				int num2 = A_0.Length - 1;
				int i = 1;
				while (i <= num2)
				{
					if (Operators.CompareString(Conversions.ToString(A_0[i]), "(", true) == 0)
					{
						num++;
					}
					if (Operators.CompareString(Conversions.ToString(A_0[i]), ")", true) == 0)
					{
						num--;
					}
					if (num == 0)
					{
						match = regex.Match(A_0);
						if (match.Success)
						{
							A_0 = A_0.Substring(1, i - 1);
							return Oo00.o_OoO._0_00.(A_0);
						}
						return A_0;
					}
					else
					{
						i++;
					}
				}
			}
			return Regex.Split(A_0, "[\\s]+")[0];
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x00206B54 File Offset: 0x00204D54
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			int startat = 0;
			Match match = new Regex("[\\s]+from[\\s]+", RegexOptions.IgnoreCase).Match(A_0, startat);
			if (match.Success)
			{
				A_0 = A_0.Substring(match.Index + match.Length);
			}
			if (A_0.StartsWith("("))
			{
				int num = 1;
				int num2 = A_0.Length - 1;
				for (int i = 1; i <= num2; i++)
				{
					if (Operators.CompareString(Conversions.ToString(A_0[i]), "(", true) == 0)
					{
						num++;
					}
					if (Operators.CompareString(Conversions.ToString(A_0[i]), ")", true) == 0)
					{
						num--;
					}
					if (num == 0)
					{
						string text = A_0.Substring(0, i + 1);
						if (A_0.Length > i + 1)
						{
							A_0 = A_0.Substring(i + 1).Trim();
							string[] array = Regex.Split(A_0, "[\\s]+");
							if (array.Length > 1 && Operators.CompareString(array[0].ToLower(), "as", true) == 0)
							{
								return Oo00.o0oO.Oo__oOO0.(string.Concat(new string[]
								{
									text,
									" ",
									array[0],
									" ",
									array[1]
								}));
							}
							if (array.Length > 0)
							{
								string left = array[0].ToLower();
								if (Operators.CompareString(left, "where", true) != 0 && Operators.CompareString(left, "group", true) != 0 && Operators.CompareString(left, "order", true) != 0 && Operators.CompareString(left, "having", true) != 0 && Operators.CompareString(left, "inner", true) != 0 && Operators.CompareString(left, "left", true) != 0 && Operators.CompareString(left, "right", true) != 0 && Operators.CompareString(left, "full", true) != 0 && Operators.CompareString(left, "join", true) != 0)
								{
									return Oo00.o0oO.Oo__oOO0.(text + " " + array[0]);
								}
							}
						}
						return Oo00.o0oO.Oo__oOO0.(text.Trim());
					}
				}
			}
			if (A_0.StartsWith("["))
			{
				int num3 = 1;
				int num4 = A_0.Length - 1;
				for (int j = 1; j <= num4; j++)
				{
					if (Operators.CompareString(Conversions.ToString(A_0[j]), "[", true) == 0)
					{
						num3++;
					}
					if (Operators.CompareString(Conversions.ToString(A_0[j]), "]", true) == 0)
					{
						num3--;
					}
					if (num3 == 0)
					{
						return A_0.Substring(0, j + 1);
					}
				}
			}
			else
			{
				string[] array = Regex.Split(A_0, "[\\s]+");
				if (array.Length >= 3 && Operators.CompareString(array[1], "as", true) == 0)
				{
					return string.Concat(new string[]
					{
						array[0],
						" ",
						array[1],
						" ",
						array[2]
					});
				}
				if (array.Length >= 2)
				{
					string left2 = array[1];
					if (Operators.CompareString(left2, "where", true) == 0 || Operators.CompareString(left2, "group", true) == 0 || Operators.CompareString(left2, "order", true) == 0 || Operators.CompareString(left2, "having", true) == 0)
					{
						return array[0];
					}
					if (Operators.CompareString(left2, "inner", true) == 0 || Operators.CompareString(left2, "left", true) == 0 || Operators.CompareString(left2, "right", true) == 0 || Operators.CompareString(left2, "full", true) == 0 || Operators.CompareString(left2, "join", true) == 0)
					{
						return array[0];
					}
					return array[0] + " " + array[1];
				}
			}
			match = new Regex("[\\s]+join[\\s]+", RegexOptions.IgnoreCase).Match(A_0);
			if (match.Success)
			{
				match = new Regex("[\\s]+on[\\s]+", RegexOptions.IgnoreCase).Match(A_0, match.Index + 1);
				if (match.Success)
				{
					startat = match.Index;
				}
			}
			MatchCollection matchCollection = new Regex("[\\s]+where[\\s]+", RegexOptions.IgnoreCase).Matches(A_0, startat);
			if (matchCollection.Count > 0)
			{
				if (A_0.IndexOf("FoxTempaX", StringComparison.Ordinal) > matchCollection[matchCollection.Count - 1].Index)
				{
					A_0 = A_0.Substring(0, matchCollection[0].Index);
				}
				else
				{
					A_0 = A_0.Substring(0, matchCollection[matchCollection.Count - 1].Index);
				}
			}
			match = new Regex("[\\s]+group[\\s]+by[\\s]+", RegexOptions.IgnoreCase).Match(A_0, startat);
			if (match.Success)
			{
				A_0 = A_0.Substring(0, match.Index);
			}
			match = new Regex("[\\s]+order[\\s]+by[\\s]+", RegexOptions.IgnoreCase).Match(A_0, startat);
			if (match.Success)
			{
				A_0 = A_0.Substring(0, match.Index);
			}
			return A_0;
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x00207010 File Offset: 0x00205210
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			int startat = 0;
			Match match = new Regex("[\\s]+from[\\s]+", RegexOptions.IgnoreCase).Match(A_0, startat);
			if (match.Success)
			{
				A_0 = A_0.Substring(match.Index + match.Length);
			}
			string[] array;
			if (A_0.StartsWith("("))
			{
				int num = 1;
				int num2 = A_0.Length - 1;
				for (int i = 1; i <= num2; i++)
				{
					if (Operators.CompareString(Conversions.ToString(A_0[i]), "(", true) == 0)
					{
						num++;
					}
					if (Operators.CompareString(Conversions.ToString(A_0[i]), ")", true) == 0)
					{
						num--;
					}
					if (num == 0)
					{
						string text = A_0.Substring(0, i + 1);
						if (A_0.Length > i + 1)
						{
							A_0 = A_0.Substring(i + 1).Trim();
							array = Regex.Split(A_0, "[\\s]+");
							if (array.Length > 1 && Operators.CompareString(array[0].ToLower(), "as", true) == 0)
							{
								return Oo00.o0oO.Oo__oOO0.(string.Concat(new string[]
								{
									text,
									" ",
									array[0],
									" ",
									array[1]
								}));
							}
							if (array.Length > 0)
							{
								string left = array[0].ToLower();
								if (Operators.CompareString(left, "where", true) != 0 && Operators.CompareString(left, "group", true) != 0 && Operators.CompareString(left, "order", true) != 0 && Operators.CompareString(left, "having", true) != 0 && Operators.CompareString(left, "inner", true) != 0 && Operators.CompareString(left, "left", true) != 0 && Operators.CompareString(left, "right", true) != 0 && Operators.CompareString(left, "full", true) != 0 && Operators.CompareString(left, "join", true) != 0)
								{
									return Oo00.o0oO.Oo__oOO0.(text + " " + array[0]);
								}
							}
						}
						return Oo00.o0oO.Oo__oOO0.(text.Trim());
					}
				}
			}
			array = Regex.Split(A_0, "[\\s]+");
			string result;
			if (array.Length >= 3 && Operators.CompareString(array[1], "as", true) == 0)
			{
				result = string.Concat(new string[]
				{
					array[0],
					" ",
					array[1],
					" ",
					array[2]
				});
			}
			else
			{
				if (array.Length >= 2)
				{
					string left2 = array[1];
					if (Operators.CompareString(left2, "where", true) == 0 || Operators.CompareString(left2, "group", true) == 0 || Operators.CompareString(left2, "order", true) == 0 || Operators.CompareString(left2, "having", true) == 0)
					{
						return array[0];
					}
				}
				match = new Regex("[\\s]+join[\\s]+", RegexOptions.IgnoreCase).Match(A_0);
				if (match.Success)
				{
					match = new Regex("[\\s]+on[\\s]+", RegexOptions.IgnoreCase).Match(A_0, match.Index + 1);
					if (match.Success)
					{
						startat = match.Index;
					}
				}
				MatchCollection matchCollection = new Regex("[\\s]+where[\\s]+", RegexOptions.IgnoreCase).Matches(A_0, startat);
				if (matchCollection.Count > 0)
				{
					if (A_0.IndexOf("FoxTempaX", StringComparison.Ordinal) > matchCollection[matchCollection.Count - 1].Index)
					{
						A_0 = A_0.Substring(0, matchCollection[0].Index);
					}
					else
					{
						A_0 = A_0.Substring(0, matchCollection[matchCollection.Count - 1].Index);
					}
				}
				match = new Regex("[\\s]+group[\\s]+by[\\s]+", RegexOptions.IgnoreCase).Match(A_0, startat);
				if (match.Success)
				{
					A_0 = A_0.Substring(0, match.Index);
				}
				match = new Regex("[\\s]+order[\\s]+by[\\s]+", RegexOptions.IgnoreCase).Match(A_0, startat);
				if (match.Success)
				{
					A_0 = A_0.Substring(0, match.Index);
				}
				result = A_0;
			}
			return result;
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x002073D8 File Offset: 0x002055D8
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			if (A_0.StartsWith("("))
			{
				string[] array = Regex.Split(A_0, "[\\s]+");
				string text = "";
				if (Operators.CompareString(array[0], "(select", true) == 0 || (array.Length > 1 && Operators.CompareString(array[1], "select", true) == 0))
				{
					string[] array2 = array;
					int i = 0;
					while (i < array2.Length)
					{
						if (Operators.CompareString(array2[i], "Row_Number()", true) == 0)
						{
							MatchCollection matchCollection = new Regex("[\\s]+where[\\s]+", RegexOptions.IgnoreCase).Matches(A_0);
							if (matchCollection.Count <= 0)
							{
								break;
							}
							text = A_0.Substring(0, matchCollection[matchCollection.Count - 1].Index);
							int num = A_0.LastIndexOf(")");
							if (num > 0)
							{
								text += A_0.Substring(num);
								break;
							}
							text = "";
							break;
						}
						else
						{
							checked
							{
								i++;
							}
						}
					}
					if (Operators.CompareString(text, "", true) > 0)
					{
						A_0 = text;
					}
				}
			}
			return A_0;
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x002074CC File Offset: 0x002056CC
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			int num = Oo00.OoO_.__o.(A_0);
			Match match = new Regex("[\\s]+where[\\s]+", RegexOptions.IgnoreCase).Match(A_0, num);
			if (match.Success)
			{
				A_0 = A_0.Substring(0, match.Index);
			}
			match = new Regex("\\s+top\\s\\d+\\s+(percent\\s+)*", RegexOptions.IgnoreCase).Match(A_0);
			if (match.Index < num)
			{
				A_0 = A_0.Substring(0, match.Index) + " " + A_0.Substring(match.Index + match.Length);
			}
			return A_0;
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x00207554 File Offset: 0x00205754
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			Match match = new Regex("[\\s]+from[\\s]+", RegexOptions.IgnoreCase).Match(A_0);
			string result;
			if (match.Success)
			{
				int num = match.Index;
				match = new Regex("[\\s]+top[\\s]+", RegexOptions.IgnoreCase).Match(A_0);
				if (match.Success && match.Index < num)
				{
					result = A_0;
				}
				else
				{
					num = Oo00.OoO_.__o.(A_0);
					match = new Regex("[\\s]+order[\\s]+by[\\s]+", RegexOptions.IgnoreCase).Match(A_0, num);
					if (match.Success)
					{
						A_0 = A_0.Substring(0, match.Index) + A_0.Substring(match.Index);
					}
					result = A_0;
				}
			}
			else
			{
				result = A_0;
			}
			return result;
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x002075F4 File Offset: 0x002057F4
		internal static string <<EMPTY_NAME>>(string A_0, Foxtable.Table A_1)
		{
			return Oo00.OoOo_oo_.o_o.(A_0, A_1.DataTable);
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x00207604 File Offset: 0x00205804
		internal static string <<EMPTY_NAME>>(string A_0, DataTable A_1)
		{
			string text = Oo00.oo0o.O0O_0__.(A_0, A_1);
			bool flag;
			if (Operators.CompareString(A_1.DataServer, "", true) > 0)
			{
				flag = (A_1.DataServerType == DataServerTypeEnum.Oracle);
			}
			else
			{
				flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_1.frd_Connection);
			}
			if (flag)
			{
				text = text.Replace("[", "\"").Replace("]", "\"");
			}
			string result;
			if (Oo00.OO_O_0O0OO0_.o.(text.TrimStart(new char[]
			{
				'['
			}).TrimEnd(new char[]
			{
				']'
			})))
			{
				result = "(" + text + ")";
			}
			else if (text.StartsWith("[") && text.EndsWith("]"))
			{
				result = text;
			}
			else if (flag)
			{
				result = "\"" + text + "\"";
			}
			else if (text.IndexOf(".") >= 0)
			{
				result = text;
			}
			else
			{
				result = "[" + text + "]";
			}
			return result;
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x002076FC File Offset: 0x002058FC
		internal static bool <<EMPTY_NAME>>(string A_0)
		{
			foreach (string value in new string[]
			{
				"[",
				"]",
				"(",
				")",
				"+",
				"-",
				"*",
				"/",
				"%",
				"^",
				"&",
				"|",
				"=",
				"\"",
				"'"
			})
			{
				if (A_0.IndexOf(value) >= 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x002077B2 File Offset: 0x002059B2
		internal static string <<EMPTY_NAME>>(string A_0, Foxtable.Table A_1)
		{
			return Oo00.oo0o.O0O_0__.(A_0, A_1.DataTable);
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x002077C0 File Offset: 0x002059C0
		internal static string <<EMPTY_NAME>>(string A_0, DataTable A_1)
		{
			bool flag;
			if (Operators.CompareString(A_1.DataServer, "", true) > 0)
			{
				flag = (A_1.DataServerType == DataServerTypeEnum.Oracle);
			}
			else
			{
				flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_1.frd_Connection);
			}
			string result;
			if (A_1.DataCols.Contains(A_0) && Operators.CompareString(A_1.DataCols[A_0].Expression, "", true) > 0)
			{
				string text;
				Match match = Regex.Match(text = A_1.DataCols[A_0].Expression, "[[0-9a-zA-Z\\u4e00-\\u9fa5_]+]");
				while (Operators.CompareString(match.ToString(), "", true) != 0)
				{
					string text2 = match.ToString();
					string text3 = Oo00.oo0o.O0O_0__.(text2.Trim(new char[]
					{
						'['
					}).Trim(new char[]
					{
						']'
					}), A_1);
					if (!Oo00.OO_O_0O0OO0_.o.(text3))
					{
						text3 = "[" + text3 + "]";
					}
					else
					{
						text3 = "(" + text3 + ")";
					}
					text = text.Replace(text2, text3);
					match = match.NextMatch();
				}
				text = Oo00.ooO.ooo.(A_1, text);
				result = text;
			}
			else if (A_1.frd_IsInnerTable)
			{
				result = A_0;
			}
			else
			{
				string text4;
				if (Operators.CompareString(A_1.DataServer, "", true) > 0)
				{
					text4 = A_1.HttpSelect;
				}
				else
				{
					text4 = A_1.frd_SelectCommandString;
				}
				Match match2 = new Regex("[\\s]+from[\\s\\[\\{]+", RegexOptions.IgnoreCase).Match(text4);
				if (match2.Success)
				{
					text4 = text4.Substring(0, match2.Index);
				}
				List<string> list = new List<string>();
				list.AddRange(Regex.Split(text4, "[\\s]+"));
				list.RemoveAt(0);
				if (Operators.CompareString(list[0], "All", true) == 0 || Operators.CompareString(list[0], "DISTINCT", true) == 0 || Operators.CompareString(list[0], "DISTINCTROW", true) == 0)
				{
					list.RemoveAt(0);
				}
				if (Operators.CompareString(list[0], "Top", true) == 0)
				{
					list.RemoveAt(0);
					list.RemoveAt(0);
					if (Operators.CompareString(list[0], "PERCENT", true) == 0)
					{
						list.RemoveAt(0);
					}
				}
				text4 = string.Join(" ", list.ToArray());
				string[] array = text4.Split(new char[]
				{
					','
				});
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string text5 = array[i].Trim(new char[]
					{
						' '
					});
					if (text5.IndexOf(" as ", StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						string text6 = text5.Substring(0, text5.IndexOf(" as ", StringComparison.CurrentCultureIgnoreCase)).Trim();
						string text7 = text5.Substring(text5.IndexOf(" as ", StringComparison.CurrentCultureIgnoreCase) + 4).Trim();
						bool flag2;
						if (Operators.CompareString(text7.Trim(), A_0, true) == 0)
						{
							flag2 = true;
						}
						else if (flag)
						{
							if (text7.EndsWith("\"" + A_0 + "\"", StringComparison.CurrentCultureIgnoreCase))
							{
								flag2 = true;
							}
						}
						else if (text7.EndsWith("[" + A_0 + "]", StringComparison.CurrentCultureIgnoreCase))
						{
							flag2 = true;
						}
						if (flag2)
						{
							string text8 = text6;
							int num2 = A_1.BaseTable.Columns.IndexOf(A_0);
							if (num2 > 0)
							{
								string columnName = A_1.BaseTable.Columns[num2 - 1].ColumnName;
								flag2 = false;
								for (int j = i - 1; j >= 0; j += -1)
								{
									text7 = array[j].Trim();
									if (Operators.CompareString(text7, columnName, true) == 0 || Operators.CompareString(text7, "*", true) == 0 || text7.EndsWith(".*"))
									{
										flag2 = true;
									}
									else if (text7.IndexOf(" as ", StringComparison.CurrentCultureIgnoreCase) >= 0)
									{
										flag2 = true;
									}
									else if (Operators.CompareString(text7.Trim(), columnName, true) == 0)
									{
										flag2 = true;
									}
									else if (flag)
									{
										if (text7.EndsWith("\"" + columnName + "\"", StringComparison.CurrentCultureIgnoreCase))
										{
											flag2 = true;
										}
									}
									else if (text7.EndsWith("[" + columnName + "]", StringComparison.CurrentCultureIgnoreCase))
									{
										flag2 = true;
									}
									if (flag2)
									{
										break;
									}
									text8 = array[j] + "," + text8;
								}
							}
							return text8;
						}
					}
					else
					{
						if (Operators.CompareString(text5, A_0, true) == 0)
						{
							return A_0;
						}
						if (text5.EndsWith("." + A_0))
						{
							return text5;
						}
						if (flag)
						{
							if (text5.EndsWith(".\"" + A_0 + "\"", StringComparison.CurrentCultureIgnoreCase))
							{
								return text5;
							}
							if (text5.EndsWith("\"" + A_0 + "\"", StringComparison.CurrentCultureIgnoreCase))
							{
								return text5;
							}
						}
						else
						{
							if (text5.EndsWith(".[" + A_0 + "]", StringComparison.CurrentCultureIgnoreCase))
							{
								return text5;
							}
							if (text5.EndsWith("[" + A_0 + "]", StringComparison.CurrentCultureIgnoreCase))
							{
								return text5;
							}
						}
					}
				}
				result = A_0;
			}
			return result;
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x00207CCC File Offset: 0x00205ECC
		internal static Dictionary<DataColumn, string> <<EMPTY_NAME>>(DataTable A_0)
		{
			Dictionary<DataColumn, string> dictionary = new Dictionary<DataColumn, string>();
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (dataRelation.ParentTable == A_0)
					{
						try
						{
							foreach (object obj2 in dataRelation.ChildTable.Columns)
							{
								DataColumn dataColumn = (DataColumn)obj2;
								if (Operators.CompareString(dataColumn.Expression, "", true) > 0 && dataColumn.Expression.IndexOf("parent", StringComparison.CurrentCultureIgnoreCase) >= 0)
								{
									dictionary.Add(dataColumn, dataColumn.Expression);
									dataColumn.Expression = null;
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
			return dictionary;
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x00207DC8 File Offset: 0x00205FC8
		internal static void <<EMPTY_NAME>>(Dictionary<DataColumn, string> A_0)
		{
			try
			{
				foreach (DataColumn dataColumn in A_0.Keys)
				{
					dataColumn.Expression = A_0[dataColumn];
				}
			}
			finally
			{
				Dictionary<DataColumn, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x00207E24 File Offset: 0x00206024
		internal static List<string> <<EMPTY_NAME>>(DataTable A_0, string A_1, string A_2, string A_3)
		{
			return new List<string>(Oo00.O____0O._0.(A_0, A_1, A_2, A_3));
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x00207E34 File Offset: 0x00206034
		internal static HashSet<string> <<EMPTY_NAME>>(DataTable A_0, string A_1, string A_2, string A_3)
		{
			int ndx = A_0.Columns.IndexOf(A_3);
			HashSet<string> hashSet = new HashSet<string>();
			if (Operators.CompareString(A_2, "", true) == 0)
			{
				A_2 = A_3;
			}
			DataView dataView = new DataView(A_0, A_1, A_2, DataViewRowState.CurrentRows);
			HashSet<string> result;
			if (dataView.Count == 0)
			{
				result = hashSet;
			}
			else if (Operators.CompareString(A_2, A_3, true) == 0)
			{
				string text = dataView[0][ndx].ToString();
				hashSet.Add(text);
				int num = dataView.Count - 1;
				for (int i = 1; i <= num; i++)
				{
					string text2 = dataView[i][ndx].ToString();
					if (Operators.CompareString(text, text2, true) != 0)
					{
						hashSet.Add(text2);
						text = text2;
					}
				}
				result = hashSet;
			}
			else
			{
				int num2 = dataView.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					string text2 = dataView[j][ndx].ToString();
					hashSet.Add(text2);
				}
				result = hashSet;
			}
			return result;
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x00207F38 File Offset: 0x00206138
		internal static List<string[]> <<EMPTY_NAME>>(DataTable A_0, string A_1, string A_2, params string[] A_3)
		{
			Operators.CompareString(A_2, "", true);
			string text = A_2;
			if (Operators.CompareString(text, "", true) == 0)
			{
				foreach (string str in A_3)
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += ",";
					}
					text += str;
				}
			}
			List<string[]> list = new List<string[]>();
			DataView dataView = new DataView(A_0, A_1, text, DataViewRowState.CurrentRows);
			List<string[]> result;
			if (dataView.Count == 0)
			{
				result = list;
			}
			else
			{
				int num = A_3.Length - 1;
				int[] array = new int[num + 1];
				string[] array2 = new string[num + 1];
				int num2 = num;
				for (int j = 0; j <= num2; j++)
				{
					array[j] = A_0.Columns.IndexOf(A_3[j]);
				}
				HashSet<string> hashSet = new HashSet<string>();
				int num3 = dataView.Count - 1;
				for (int k = 0; k <= num3; k++)
				{
					string text2 = "";
					array2 = (string[])Array.CreateInstance(typeof(string), A_3.Length);
					int num4 = num;
					for (int l = 0; l <= num4; l++)
					{
						array2[l] = dataView[k][array[l]].ToString();
						text2 = text2 + "," + array2[l];
					}
					int count = hashSet.Count;
					hashSet.Add(text2);
					if (count < hashSet.Count)
					{
						list.Add(array2);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x002080BA File Offset: 0x002062BA
		public static void <<EMPTY_NAME>>(DataTable A_0, string A_1, DataTable A_2, string A_3)
		{
			Oo00.oO.OO.(A_0, new string[]
			{
				A_1
			}, A_2, new string[]
			{
				A_3
			});
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x002080D8 File Offset: 0x002062D8
		public static void <<EMPTY_NAME>>(DataTable A_0, string[] A_1, DataTable A_2, string[] A_3)
		{
			string text = "";
			int num = A_1.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text = text + ",[" + A_1[i] + "]";
			}
			text = text.Trim(new char[]
			{
				','
			});
			DataView dataView = new DataView(A_0, "", text, DataViewRowState.CurrentRows);
			object[] array = new object[A_1.Length - 1 + 1];
			Dictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			try
			{
				foreach (object obj in A_2.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					int num2 = A_3.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						array[j] = RuntimeHelpers.GetObjectValue(dataRow[A_3[j]]);
					}
					int num3 = dataView.Find(array);
					if (num3 < 0)
					{
						DataRow dataRow2 = A_0.NewRow();
						int num4 = A_1.Length - 1;
						for (int k = 0; k <= num4; k++)
						{
							dataRow2[A_1[k]] = RuntimeHelpers.GetObjectValue(array[k]);
						}
						A_0.Rows.Add(dataRow2);
						dictionary.Add(dataRow2, dataRow);
					}
					else
					{
						dictionary.Add(dataView[num3].Row, dataRow);
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
			List<string> list = new List<string>();
			try
			{
				foreach (object obj2 in A_2.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj2;
					bool flag = false;
					int num5 = A_3.Length - 1;
					for (int l = 0; l <= num5; l++)
					{
						if (Operators.CompareString(A_3[l], dataColumn.ColumnName, true) == 0)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						if (A_0.Columns.Contains(dataColumn.ColumnName))
						{
							int num6 = 0;
							do
							{
								num6++;
							}
							while (A_0.Columns.Contains(dataColumn.ColumnName + Conversions.ToString(num6)));
							dataColumn.ColumnName += Conversions.ToString(num6);
						}
						A_0.Columns.Add(dataColumn.ColumnName, dataColumn.DataType);
						if (dataColumn.DataType == typeof(string))
						{
							A_0.Columns[dataColumn.ColumnName].MaxLength = dataColumn.MaxLength;
						}
						A_0.Columns[dataColumn.ColumnName].Caption = dataColumn.Caption;
						list.Add(dataColumn.ColumnName);
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
			try
			{
				foreach (DataRow dataRow3 in dictionary.Keys)
				{
					DataRow dataRow4 = dictionary[dataRow3];
					try
					{
						foreach (string columnName in list)
						{
							dataRow3[columnName] = RuntimeHelpers.GetObjectValue(dataRow4[columnName]);
						}
					}
					finally
					{
						List<string>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
			}
			finally
			{
				Dictionary<DataRow, DataRow>.KeyCollection.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x00208468 File Offset: 0x00206668
		internal static bool <<EMPTY_NAME>>(string A_0, string A_1)
		{
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (dataRelation.ParentTable != dataRelation.ChildTable && Operators.CompareString(dataRelation.ChildTable.TableName, A_0, true) == 0)
					{
						Operators.CompareString(dataRelation.ParentTable.TableName, A_1, true);
						if (Oo00.OO.0O0o.(dataRelation, A_1))
						{
							return true;
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
			return false;
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x00208508 File Offset: 0x00206708
		private static bool <<EMPTY_NAME>>(DataRelation A_0, string A_1)
		{
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (dataRelation.ParentTable != dataRelation.ChildTable && dataRelation.ChildTable == A_0.ParentTable)
					{
						if (Operators.CompareString(dataRelation.ParentTable.TableName, A_1, true) == 0)
						{
							return true;
						}
						if (Oo00.OO.0O0o.(dataRelation, A_1))
						{
							return true;
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
			return false;
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x002085A8 File Offset: 0x002067A8
		internal static string <<EMPTY_NAME>>(JoinTableProperty A_0)
		{
			SQLJoinTableBuilder sqljoinTableBuilder = new SQLJoinTableBuilder("temptable", A_0.BaseTable);
			sqljoinTableBuilder.Filter = A_0.Filter;
			sqljoinTableBuilder.Order = A_0.Order;
			sqljoinTableBuilder.Top = A_0.Top;
			sqljoinTableBuilder.Distinct = A_0.Distinct;
			checked
			{
				if (Operators.CompareString(A_0.LinkTables, "", true) > 0)
				{
					string[] array = A_0.LinkTables.Split(new char[]
					{
						'\n'
					});
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(new char[]
						{
							'\t'
						});
						if (Operators.CompareString(array2[0], "", true) > 0 && Operators.CompareString(array2[1], "", true) > 0 && Operators.CompareString(array2[2], "", true) > 0 && Operators.CompareString(array2[3], "", true) > 0)
						{
							string[] leftCol = array2[1].Split(new char[]
							{
								','
							}, StringSplitOptions.RemoveEmptyEntries);
							string[] rightCol = array2[3].Split(new char[]
							{
								','
							}, StringSplitOptions.RemoveEmptyEntries);
							sqljoinTableBuilder.AddTable(array2[0], leftCol, array2[2], rightCol, (JoinModeEnum)Conversions.ToInteger(Enum.Parse(typeof(JoinModeEnum), array2[4])));
						}
					}
				}
				if (Operators.CompareString(A_0.Columns, "", true) > 0)
				{
					string[] array3 = A_0.Columns.Split(new char[]
					{
						'\n'
					});
					for (int j = 0; j < array3.Length; j++)
					{
						string[] array4 = array3[j].Split(new char[]
						{
							'\t'
						});
						if (Operators.CompareString(array4[1], "", true) > 0)
						{
							if (Operators.CompareString(array4[2], "1", true) == 0)
							{
								sqljoinTableBuilder.AddExp(array4[1], array4[0], true);
							}
							else
							{
								sqljoinTableBuilder.AddExp(array4[1], array4[0], false);
							}
						}
						else if (Operators.CompareString(array4[2], "1", true) == 0)
						{
							sqljoinTableBuilder.AddCols(new object[]
							{
								array4[0],
								true
							});
						}
						else
						{
							sqljoinTableBuilder.AddCols(new object[]
							{
								array4[0],
								false
							});
						}
					}
				}
				return sqljoinTableBuilder.BuildSql();
			}
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x002087DC File Offset: 0x002069DC
		internal static DataServerTypeEnum <<EMPTY_NAME>>(OleDbConnection A_0)
		{
			string provider = A_0.Provider;
			DataServerTypeEnum result;
			if (provider.StartsWith("Microsoft.Jet.OLEDB.4.0", StringComparison.CurrentCultureIgnoreCase) || provider.StartsWith("Microsoft.ACE.OLEDB.12.0", StringComparison.CurrentCultureIgnoreCase))
			{
				result = DataServerTypeEnum.Access;
			}
			else if (o_O_o_oOoo__.OOOO_OO._oo.(A_0))
			{
				result = DataServerTypeEnum.SqlServer;
			}
			else if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0))
			{
				result = DataServerTypeEnum.Oracle;
			}
			return result;
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x0020882C File Offset: 0x00206A2C
		internal static List<string> <<EMPTY_NAME>>(DataRow A_0, DataCol A_1, FTPClient A_2, string A_3)
		{
			List<string> list = new List<string>();
			BeforeAddFileEventArgs beforeAddFileEventArgs = new BeforeAddFileEventArgs(A_1.DataTable, A_0, A_1);
			string a_ = "BeforeAddFile";
			O_O0OO.OoO_o.oO0o0O.(A_1.DataTable.o_0_00_.oo0O0., a_, new object[]
			{
				beforeAddFileEventArgs
			}, false, A_1.DataTable.Name, false);
			List<string> result;
			if (beforeAddFileEventArgs.Cancel)
			{
				result = list;
			}
			else
			{
				if (A_1.DataTable.GlobalHandler.BeforeAddFile)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						beforeAddFileEventArgs
					}, false, "全局表事件", false);
				}
				if (beforeAddFileEventArgs.Cancel)
				{
					result = list;
				}
				else
				{
					if (A_2 == null)
					{
						OpenFileDialog openFileDialog = new OpenFileDialog();
						try
						{
							if (Operators.CompareString(beforeAddFileEventArgs.Path, "", true) > 0)
							{
								openFileDialog.InitialDirectory = beforeAddFileEventArgs.Path.Replace("/", "\\");
							}
							else if (Operators.CompareString(A_1.LastFolder, "", true) > 0 && OO_00oOO.FileSys.DirectoryExists(A_1.LastFolder))
							{
								openFileDialog.InitialDirectory = A_1.LastFolder;
							}
							else if (Operators.CompareString(A_1.SourceFolder, "", true) > 0 && OO_00oOO.FileSys.DirectoryExists(A_1.SourceFolder))
							{
								openFileDialog.InitialDirectory = A_1.SourceFolder;
							}
							else if (Operators.CompareString(A_1.DefaultFolder, "", true) > 0)
							{
								string text = A_1.DefaultFolder;
								if (Operators.CompareString(text.Substring(1, 1), ":", true) != 0 && !text.StartsWith("\\\\"))
								{
									text = OO_00oOO.ProjectPath + "Attachments\\" + text.Trim(new char[]
									{
										'\\'
									});
								}
								if (OO_00oOO.FileSys.DirectoryExists(text))
								{
									openFileDialog.InitialDirectory = text;
								}
							}
							openFileDialog.Multiselect = true;
							if (Operators.CompareString(A_3, "", true) == 0)
							{
								openFileDialog.Filter = A_1.FileFilter;
							}
							else
							{
								openFileDialog.Filter = A_3;
							}
						}
						catch (Exception a_2)
						{
							ooO.oOo0Oo.o.(a_2, "");
						}
						if (openFileDialog.ShowDialog() == DialogResult.OK)
						{
							A_1.LastFolder = OO_00oOO.FileSys.GetParentPath(openFileDialog.FileName);
							foreach (string text2 in openFileDialog.FileNames)
							{
								text2 = ooO.oO0__o.0o__.(text2, A_0, A_1);
								list.Add(text2);
							}
						}
					}
					else
					{
						List<string> list2;
						if (Operators.CompareString(beforeAddFileEventArgs.Path, "", true) > 0)
						{
							list2 = A_2.SelectFile(beforeAddFileEventArgs.Path.Replace("\\", "/"));
						}
						else
						{
							list2 = A_2.SelectFile();
						}
						if (list2 != null)
						{
							list = list2;
						}
					}
					result = list;
				}
			}
			return result;
		}

		// Token: 0x060049D4 RID: 18900 RVA: 0x00208AFC File Offset: 0x00206CFC
		internal static string <<EMPTY_NAME>>(DataRow A_0, DataCol A_1, FTPClient A_2, string A_3)
		{
			BeforeAddFileEventArgs beforeAddFileEventArgs = new BeforeAddFileEventArgs(A_1.DataTable, A_0, A_1, true);
			string a_ = "BeforeAddFile";
			O_O0OO.OoO_o.oO0o0O.(A_1.DataTable.o_0_00_.oo0O0., a_, new object[]
			{
				beforeAddFileEventArgs
			}, false, A_1.DataTable.Name, false);
			string result;
			if (beforeAddFileEventArgs.Cancel)
			{
				result = "";
			}
			else
			{
				if (A_1.DataTable.GlobalHandler.BeforeAddFile)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						beforeAddFileEventArgs
					}, false, "全局表事件", false);
				}
				if (beforeAddFileEventArgs.Cancel)
				{
					result = "";
				}
				else
				{
					if (A_2 == null)
					{
						FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
						if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
						{
							string text = folderBrowserDialog.SelectedPath;
							string text2;
							if (Operators.CompareString(A_1.DefaultFolder, "", true) > 0)
							{
								text2 = A_1.DefaultFolder;
								if (Operators.CompareString(text2.Substring(1, 1), ":", true) != 0 && !text2.StartsWith("\\\\"))
								{
									text2 = OO_00oOO.ProjectPath + "Attachments\\" + text2.Trim(new char[]
									{
										'\\'
									});
								}
							}
							else
							{
								text2 = OO_00oOO.ProjectPath + "Attachments\\";
							}
							if (Operators.CompareString(text.TrimEnd(new char[]
							{
								'\\'
							}) + "\\", text2.TrimEnd(new char[]
							{
								'\\'
							}) + "\\", true) == 0)
							{
								text = "\\";
							}
							else if (text.StartsWith(text2, StringComparison.CurrentCultureIgnoreCase))
							{
								text = text.Substring(text2.Length).Trim(new char[]
								{
									'\\'
								});
							}
							return "[" + text + "]";
						}
					}
					else
					{
						string text3;
						if (Operators.CompareString(beforeAddFileEventArgs.Path, "", true) > 0)
						{
							text3 = A_2.SelectFolder(beforeAddFileEventArgs.Path);
						}
						else
						{
							text3 = A_2.SelectFolder();
						}
						if (Operators.CompareString(text3, "", true) > 0)
						{
							return "[" + text3 + "]";
						}
					}
					result = "";
				}
			}
			return result;
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x00208D14 File Offset: 0x00206F14
		internal static bool <<EMPTY_NAME>>(DataRow A_0, DataCol A_1, string A_2)
		{
			BeforeDeleteFileEventArgs beforeDeleteFileEventArgs = new BeforeDeleteFileEventArgs(A_1.DataTable, A_0, A_1, A_2);
			string a_ = "BeforeDeleteFile";
			O_O0OO.OoO_o.oO0o0O.(A_1.DataTable.o_0_00_.oo0O0., a_, new object[]
			{
				beforeDeleteFileEventArgs
			}, false, A_1.DataTable.Name, false);
			bool result;
			if (beforeDeleteFileEventArgs.Cancel)
			{
				result = false;
			}
			else
			{
				if (A_1.DataTable.GlobalHandler.BeforeDeleteFile)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						beforeDeleteFileEventArgs
					}, false, "全局表事件", false);
				}
				if (beforeDeleteFileEventArgs.Cancel)
				{
					result = false;
				}
				else if (A_2.StartsWith("[") && A_2.EndsWith("]"))
				{
					result = true;
				}
				else
				{
					bool flag;
					if (beforeDeleteFileEventArgs.HaveSetDeleteMode)
					{
						flag = beforeDeleteFileEventArgs.DeleteLocalFile;
					}
					else
					{
						DialogResult dialogResult = ooO.o.O_0000_O.(A_1);
						if (dialogResult == DialogResult.Yes)
						{
							flag = true;
						}
						else if (dialogResult == DialogResult.Cancel)
						{
							return false;
						}
					}
					if (flag)
					{
						A_1.O_0o_O.ooOO.(A_2);
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x00208E04 File Offset: 0x00207004
		internal static void <<EMPTY_NAME>>(DataRow A_0, DataCol A_1, FTPClient A_2, string A_3, bool A_4)
		{
			string text = Oo00.ooO.ooo.(A_0, A_1, A_2, A_3, A_4);
			if (Operators.CompareString(text, "", true) > 0)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.FileName = OO_00oOO.FileSys.GetName(text);
				saveFileDialog.Filter = Path.GetExtension(text).Trim(new char[]
				{
					'.'
				}) + "|*" + Path.GetExtension(text);
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					OO_00oOO.FileSys.CopyFile(text, saveFileDialog.FileName, true);
				}
			}
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x00208E8C File Offset: 0x0020708C
		internal static bool <<EMPTY_NAME>>(DataRow A_0, DataCol A_1, FTPClient A_2, string A_3, bool A_4)
		{
			string text = Oo00.ooO.ooo.(A_0, A_1, A_2, A_3, A_4);
			if (Operators.CompareString(text, "", true) > 0)
			{
				try
				{
					Process.Start(text);
					return true;
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
			}
			return false;
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x00208EEC File Offset: 0x002070EC
		internal static string <<EMPTY_NAME>>(DataRow A_0, DataCol A_1, FTPClient A_2, string A_3, bool A_4)
		{
			BeforeOpenFileEventArgs beforeOpenFileEventArgs = new BeforeOpenFileEventArgs(A_1.DataTable, A_0, A_1, A_3, A_4);
			string a_ = "BeforeOpenFile";
			O_O0OO.OoO_o.oO0o0O.(A_1.DataTable.o_0_00_.oo0O0., a_, new object[]
			{
				beforeOpenFileEventArgs
			}, false, A_1.DataTable.Name, false);
			string result;
			if (beforeOpenFileEventArgs.Cancel)
			{
				result = "";
			}
			else
			{
				if (A_1.DataTable.GlobalHandler.BeforeOpenFile)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						beforeOpenFileEventArgs
					}, false, "全局表事件", false);
				}
				if (beforeOpenFileEventArgs.Cancel)
				{
					result = "";
				}
				else
				{
					A_3 = beforeOpenFileEventArgs.FileName;
					if (A_2 == null)
					{
						A_3 = A_3.Replace("/", "\\");
						if (A_3.StartsWith("[") && A_3.EndsWith("]"))
						{
							string text = A_3.Substring(1);
							text = text.Substring(0, text.Length - 1);
							text = text.Trim();
							if (Operators.CompareString(text, "", true) == 0 || text.Length == 1 || (!text.StartsWith("\\\\") && Operators.CompareString(text.Substring(1, 1), ":", true) != 0))
							{
								text = text.Trim(new char[]
								{
									'\\'
								});
								if (Operators.CompareString(text, "", true) == 0)
								{
									text = OO_00oOO.ProjectPath + "Attachments\\";
								}
								else if (Operators.CompareString(A_1.DefaultFolder, "", true) > 0)
								{
									text = A_1.DefaultFolder.Trim(new char[]
									{
										'\\'
									}) + "\\" + text;
									if (Operators.CompareString(text.Substring(1, 1), ":", true) != 0 && !text.StartsWith("\\\\"))
									{
										text = OO_00oOO.ProjectPath + "Attachments\\" + text;
									}
								}
								else
								{
									text = OO_00oOO.ProjectPath + "Attachments\\" + text;
								}
							}
							if (OO_00oOO.FileSys.DirectoryExists(text))
							{
								Process.Start(text);
							}
							else
							{
								MessageBox.Show("未找到以下目录:\r\n" + text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							}
							return "";
						}
						if (Operators.CompareString(A_3.Substring(1, 1), ":", true) != 0 && !A_3.StartsWith("\\\\"))
						{
							if (Operators.CompareString(A_1.DefaultFolder, "", true) > 0)
							{
								A_3 = A_1.DefaultFolder.TrimEnd(new char[]
								{
									'\\'
								}) + "\\" + A_3;
								if (Operators.CompareString(A_3.Substring(1, 1), ":", true) != 0 && !A_3.StartsWith("\\\\"))
								{
									A_3 = OO_00oOO.ProjectPath + "Attachments\\" + A_3.Trim(new char[]
									{
										'\\'
									});
								}
							}
							else
							{
								A_3 = ooO.OoO0o_o___.O.(A_3);
							}
						}
						if (OO_00oOO.FileSys.FileExists(A_3))
						{
							return A_3;
						}
						MessageBox.Show("未找到以下文件：\r\n" + beforeOpenFileEventArgs.FileName, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						A_3 = A_3.Replace("\\", "/");
						if (A_3.StartsWith("[") && A_3.EndsWith("]"))
						{
							string text2 = A_3.Substring(1);
							text2 = text2.Substring(0, text2.Length - 1);
							A_2.OpenManager(text2);
							return "";
						}
						string fileName = beforeOpenFileEventArgs.FileName;
						string text3 = OO_00oOO.ProjectPath + "RemoteFiles\\" + fileName.Replace("/", "\\").Trim(new char[]
						{
							'\\'
						});
						if (O_O0OO.oO_00Ooo___0._..Contains(fileName.ToLower()))
						{
							MessageBox.Show("其它进程正在下载此文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return "";
						}
						bool flag;
						if (A_2 != null && beforeOpenFileEventArgs.AutoUpdate && OO_00oOO.FileSys.FileExists(text3) && !A_2.O_O_0_O0.oOO.(fileName, text3))
						{
							flag = true;
						}
						if ((!OO_00oOO.FileSys.FileExists(text3) || flag) && new O\u3000O\u3000(A_2, fileName, text3).ShowDialog() == DialogResult.Cancel)
						{
							return "";
						}
						if (OO_00oOO.FileSys.FileExists(text3))
						{
							return text3;
						}
					}
					result = "";
				}
			}
			return result;
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x0020932C File Offset: 0x0020752C
		internal static string <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(Oo00.o0.__oO0_., O_O0OO.O_O._Oo.(), true) != 0)
			{
				Oo00.o0.__oO0_. = O_O0OO.O_O._Oo.();
				Oo00.o.OO0. = Oo00.o0.__oO0_.;
				Oo00.o.OO0. = o0OO__.O.0ooOoO_0_.(Oo00.o.OO0.);
				Oo00.o.OO0. = Oo00.o.OO0..Substring(0, 6);
			}
			return Oo00.o.OO0.;
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00209384 File Offset: 0x00207584
		internal static int <<EMPTY_NAME>>()
		{
			int result;
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) != 0)
			{
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()];
				o_o_O0OO_0__.O.ooOo__o000OO.().Substring(12, 16);
				int num = 1;
				DataRow dataRow = dataTable.Rows.Find(new object[]
				{
					"Logons",
					o0_O.OoOOO_._OoO.
				});
				if (dataRow != null)
				{
					string[] array = O00.oO_.0o_oo_0O_.(dataRow["Config"].ToString(), "log", "log").Split(new char[]
					{
						','
					});
					Array.Sort<string>(array);
					int num2 = array.Length - 1;
					for (int i = 1; i <= num2; i++)
					{
						if (Operators.CompareString(array[i], array[i - 1], true) != 0)
						{
							num++;
						}
					}
					if (num > 7)
					{
						dataRow["Config"] = O00.ooo000o_0.00o0.(array[0], "log", "log");
						Oo00.O0Oo_O.0O_0O.(dataRow);
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x00209484 File Offset: 0x00207684
		internal static DataCol <<EMPTY_NAME>>(string A_0)
		{
			int num = A_0.LastIndexOf(".");
			if (num > 0)
			{
				string text = A_0.Substring(0, num);
				string text2 = A_0.Substring(num + 1);
				if (Operators.CompareString(text, "", true) > 0 && Operators.CompareString(text2, "", true) > 0 && OO_00oOO.Tables.get_Contains(text) && OO_00oOO.Tables[text].Cols.Contains(text2))
				{
					return OO_00oOO.Tables[text].Cols[text2].DataCol;
				}
			}
			return null;
		}

		// Token: 0x060049DC RID: 18908 RVA: 0x00209518 File Offset: 0x00207718
		internal static bool <<EMPTY_NAME>>(string A_0)
		{
			string text = "";
			if (OO_00oOO.DataTables.Contains("DataTableName"))
			{
				text = OO_00oOO.DataTables[A_0].Developer;
			}
			else
			{
				O_O0OO.DeveloperValider developerValider = new O_O0OO.DeveloperValider();
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
				{
					A_0,
					""
				});
				if (dataRow != null)
				{
					o_O_o_oOoo__.OOOO_OO._oo.(developerValider, Conversions.ToString(dataRow["Config"]), '\v');
					text = developerValider.Developer;
				}
			}
			bool result;
			if (Operators.CompareString(text, "", true) > 0 && OO_00oOO.User.Type != UserTypeEnum.Developer && Operators.CompareString(OO_00oOO.User.Name, text, true) != 0)
			{
				MessageBox.Show("此表的责任设计者为\"" + text + "\", 请不要越权设计!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x002095FC File Offset: 0x002077FC
		internal static void <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3)
		{
			if (Oo00.o.00. == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Oo00.o.00., new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(Oo00.o.00., ref flag);
				if (Oo00.o.00..State == 0)
				{
					Oo00.o.00..State = 2;
					Oo00.o.00. = null;
				}
				else if (Oo00.o.00..State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Oo00.o.00..State = 1;
				if (flag)
				{
					Monitor.Exit(Oo00.o.00.);
				}
			}
			if (Oo00.OOooo0O_OO._. == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Oo00.OOooo0O_OO._., new StaticLocalInitFlag(), null);
			}
			bool flag2 = false;
			try
			{
				Monitor.Enter(Oo00.OOooo0O_OO._., ref flag2);
				if (Oo00.OOooo0O_OO._..State == 0)
				{
					Oo00.OOooo0O_OO._..State = 2;
					Oo00.o.00. = null;
				}
				else if (Oo00.OOooo0O_OO._..State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Oo00.OOooo0O_OO._..State = 1;
				if (flag2)
				{
					Monitor.Exit(Oo00.OOooo0O_OO._.);
				}
			}
			if (Operators.CompareString(Oo00.O_.oo00., OO_00oOO.ProjectFile, true) != 0)
			{
				Oo00.O_.oo00. = OO_00oOO.ProjectFile;
				string text = OO_00oOO.ProjectPath + "RemoteFiles\\_foxdownloadinfo.mdb";
				if (!OO_00oOO.FileSys.FileExists(text))
				{
					CatalogClass catalogClass = new CatalogClass();
					ADOX.Table table = new TableClass();
					Guid.NewGuid().ToString();
					((_Catalog)catalogClass).Create(Oo00.o00.0OO.(text));
					table = new TableClass();
					table.Name = "Files";
					table.Columns.Append("remfile", ADOX.DataTypeEnum.adVarWChar, 255);
					table.Columns.Append("remtime", ADOX.DataTypeEnum.adVarWChar, 24);
					table.Columns.Append("remsize", ADOX.DataTypeEnum.adVarWChar, 24);
					table.Columns.Append("loctime", ADOX.DataTypeEnum.adVarWChar, 24);
					((_Catalog)catalogClass).Tables.Append(table);
					((Connection)((_Catalog)catalogClass).ActiveConnection).Close();
				}
				Oo00.o.00. = new OleDbConnection(Oo00.o_._0OOo.(text));
				Oo00.o.00. = new OleDbCommand("", Oo00.o.00.);
			}
			Oo00.o.00..Open();
			Oo00.o.00..CommandText = "Select Count(*) From [Files] Where [remfile] = '" + A_0 + "'";
			if (Conversions.ToInteger(Oo00.o.00..ExecuteScalar()) == 0)
			{
				Oo00.o.00..CommandText = string.Concat(new string[]
				{
					"Insert Into [Files] ([remfile],[remtime],[remsize],[loctime]) Values('",
					A_0,
					"','",
					A_1,
					"','",
					A_2,
					"', '",
					A_3,
					"')"
				});
			}
			else
			{
				Oo00.o.00..CommandText = string.Concat(new string[]
				{
					"Update [Files] Set [remtime] = '",
					A_1,
					"', [remsize] = '",
					A_2,
					"',[locTime] = '",
					A_3,
					"' Where [remfile] = '",
					A_0,
					"'"
				});
			}
			Oo00.o.00..ExecuteNonQuery();
			Oo00.o.00..Close();
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x00209910 File Offset: 0x00207B10
		internal static bool <<EMPTY_NAME>>(Foxtable.Table A_0)
		{
			if (A_0.AllowBackEndFilter && !A_0.IsRelation && A_0.DataTable.SourceType > 0)
			{
				if (A_0.Cols[A_0.ColSel].DataCol.IsTemporary)
				{
					string expression = A_0.Cols[A_0.ColSel].DataCol.Expression;
					if (Operators.CompareString(expression, "", true) == 0)
					{
						return false;
					}
					if (expression.IndexOf("trim(", StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return false;
					}
					if (expression.IndexOf("convert", StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return false;
					}
					if (expression.IndexOf("Parent(", StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return false;
					}
					if (expression.IndexOf("Parent.", StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return false;
					}
					if (expression.IndexOf("Child(", StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return false;
					}
					if (expression.IndexOf("Child.", StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return false;
					}
					if ((o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0.DataTable.frd_Connection) || o_O_o_oOoo__.OOOO_OO._oo.(A_0.DataTable.frd_Connection)) && expression.IndexOf("iif(", StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return false;
					}
				}
				if (Operators.CompareString(A_0.DataTable.LoadTop, "", true) > 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x00209A74 File Offset: 0x00207C74
		internal static string <<EMPTY_NAME>>(DataTable A_0, string A_1)
		{
			if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0.frd_Connection))
			{
				for (;;)
				{
					int num = A_1.IndexOf("len(", StringComparison.CurrentCultureIgnoreCase);
					if (num < 0)
					{
						break;
					}
					A_1 = A_1.Substring(0, num) + "LENGTH(" + A_1.Substring(num + 4);
				}
				for (;;)
				{
					int num = A_1.IndexOf("isnull(", StringComparison.CurrentCultureIgnoreCase);
					if (num < 0)
					{
						break;
					}
					A_1 = A_1.Substring(0, num) + "NVL(" + A_1.Substring(num + 7);
				}
				for (;;)
				{
					int num = A_1.IndexOf("substring(", StringComparison.CurrentCultureIgnoreCase);
					if (num < 0)
					{
						break;
					}
					A_1 = A_1.Substring(0, num) + "SUBSTR(" + A_1.Substring(num + 10);
				}
			}
			else if (!o_O_o_oOoo__.OOOO_OO._oo.(A_0.frd_Connection))
			{
				for (;;)
				{
					int num = A_1.IndexOf("substring(", StringComparison.CurrentCultureIgnoreCase);
					if (num < 0)
					{
						break;
					}
					A_1 = A_1.Substring(0, num) + "MID(" + A_1.Substring(num + 10);
				}
			}
			return A_1;
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x00209B64 File Offset: 0x00207D64
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (A_0.StartsWith("[") && A_0.EndsWith("]"))
			{
				result = A_0;
			}
			else
			{
				result = "{" + A_0 + "}";
			}
			return result;
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x00209BA4 File Offset: 0x00207DA4
		public static string <<EMPTY_NAME>>(AggregateEnum A_0)
		{
			switch (A_0)
			{
			case AggregateEnum.Sum:
				return "合计";
			case AggregateEnum.Count:
				return "记录数";
			case AggregateEnum.Average:
				return "平均";
			case AggregateEnum.Max:
				return "最大";
			case AggregateEnum.Min:
				return "最小";
			}
			return "";
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x00209C08 File Offset: 0x00207E08
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			Oo00.oo_0__0.o.(A_0);
			A_0 = A_0.Replace("\r", " ");
			A_0 = A_0.Replace("\n", " ");
			A_0 = A_0.Replace("  ", " ");
			A_0 = A_0.Replace("  ", " ");
			string[] array = A_0.Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries);
			string str;
			if (Operators.CompareString(array[1], "Distinct", true) == 0)
			{
				str = "Select Distinct";
			}
			else
			{
				str = "Select";
			}
			int num;
			if (Operators.CompareString(array[1], "top", true) == 0)
			{
				if (Operators.CompareString(array[3], "PERCENT", true) == 0)
				{
					num = 4;
				}
				else
				{
					num = 3;
				}
			}
			else if (Operators.CompareString(array[2], "top", true) == 0)
			{
				if (Operators.CompareString(array[4], "PERCENT", true) == 0)
				{
					num = 5;
				}
				else
				{
					num = 4;
				}
			}
			else if (Operators.CompareString(array[1], "Distinct", true) == 0)
			{
				num = 2;
			}
			else
			{
				num = 1;
			}
			int startIndex = A_0.IndexOf(" " + array[num] + " ", StringComparison.CurrentCultureIgnoreCase) + 1;
			A_0 = str + " " + A_0.Substring(startIndex);
			return A_0;
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x00209D34 File Offset: 0x00207F34
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			bool flag;
			int num;
			do
			{
				flag = false;
				num++;
				string right = A_0 + Conversions.ToString(num);
				try
				{
					IEnumerator<DataTable> enumerator = OO_00oOO.DataTables.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(enumerator.Current.Name, right, true) == 0)
						{
							flag = true;
							break;
						}
					}
				}
				finally
				{
					IEnumerator<DataTable> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			while (flag);
			return A_0 + Conversions.ToString(num);
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x00209DAC File Offset: 0x00207FAC
		internal static bool <<EMPTY_NAME>>()
		{
			try
			{
				IEnumerator<Foxtable.Table> enumerator = OO_00oOO.Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.NeedSaveSetting)
					{
						return true;
					}
				}
			}
			finally
			{
				IEnumerator<Foxtable.Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return false;
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x00209E00 File Offset: 0x00208000
		internal static bool <<EMPTY_NAME>>(List<string> A_0, DataRow A_1, DataRow A_2)
		{
			try
			{
				foreach (string columnName in A_0)
				{
					if (Operators.CompareString(A_1[columnName].ToString(), A_2[columnName].ToString(), true) != 0)
					{
						return true;
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return false;
		}

		// Token: 0x04001DDF RID: 7647
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x04001DE0 RID: 7648
		private static int <<EMPTY_NAME>> = 2;

		// Token: 0x04001DE1 RID: 7649
		private static string <<EMPTY_NAME>>;

		// Token: 0x04001DE2 RID: 7650
		private static string <<EMPTY_NAME>>;

		// Token: 0x04001DE3 RID: 7651
		private static string <<EMPTY_NAME>>;

		// Token: 0x04001DE4 RID: 7652
		private static OleDbCommand <<EMPTY_NAME>>;

		// Token: 0x04001DE5 RID: 7653
		private static StaticLocalInitFlag <<EMPTY_NAME>>;

		// Token: 0x04001DE6 RID: 7654
		private static OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x04001DE7 RID: 7655
		private static StaticLocalInitFlag <<EMPTY_NAME>>;

		// Token: 0x02000446 RID: 1094
		internal class oo00Oo0O0O0
		{
			// Token: 0x060049E6 RID: 18918 RVA: 0x00209E70 File Offset: 0x00208070
			internal oo00Oo0O0O0()
			{
				this.oo__.Oo0o_O. = 21;
				this.Oo0._O. = 8;
				this.o.00. = Oo00.O_.0_0__o0.();
				this.OOooo0O_OO._. = Strings.Mid(this.o.00., this.oo__.Oo0o_O., this.Oo0._O.);
				this.o_0_0.o. = Strings.Mid(this.o.00., this.oo__.Oo0o_O. - 4, this.Oo0._O. / 2);
				this.OO_O000__._O. = Oo00.O_00O_o.0o_.();
				this.oO_.o0_OO_OO0. = "";
				this.O._0o_O00. = 9;
				this.o.00.();
			}

			// Token: 0x060049E7 RID: 18919 RVA: 0x00209F00 File Offset: 0x00208100
			internal bool <<EMPTY_NAME>>()
			{
				int num;
				bool result;
				int num5;
				object obj;
				try
				{
					IL_00:
					ProjectData.ClearProjectError();
					num = 1;
					IL_07:
					int num2 = 2;
					string text = Application.ProductVersion.Replace(".", "");
					IL_1F:
					num2 = 3;
					char value = '0';
					IL_25:
					num2 = 4;
					char[] array = new char[1];
					IL_2F:
					num2 = 5;
					string text2 = "";
					IL_38:
					num2 = 6;
					array[0] = '.';
					IL_40:
					num2 = 7;
					string[] array2 = null;
					IL_45:
					num2 = 8;
					array2 = text.Split(new char[]
					{
						array[0]
					});
					IL_5D:
					num2 = 9;
					int num3;
					if (!(array2[0].Length > 0 & num3 >= 0))
					{
						goto IL_D7;
					}
					IL_77:
					num2 = 10;
					array2[0] = o_O_o_oOoo__.OOOO_OO._oo.(array2[0]);
					IL_87:
					num2 = 11;
					if (array2[0].Length <= num3)
					{
						goto IL_B1;
					}
					IL_97:
					num2 = 12;
					text2 = Conversions.ToString(array2[0][num3]);
					goto IL_142;
					IL_B1:
					num2 = 14;
					if (array2[0].Length != num3)
					{
						goto IL_CF;
					}
					IL_C1:
					num2 = 15;
					text2 = Conversions.ToString(value);
					goto IL_142;
					IL_CF:
					num2 = 17;
					text2 = null;
					goto IL_142;
					IL_D7:
					num2 = 19;
					if (!(array2.Length > 1 & num3 < 0))
					{
						goto IL_128;
					}
					IL_E9:
					num2 = 20;
					if (array2[1].Length < Math.Abs(num3))
					{
						goto IL_11C;
					}
					IL_FE:
					num2 = 21;
					text2 = Conversions.ToString(array2[1][Math.Abs(num3) - 1]);
					goto IL_142;
					IL_11C:
					num2 = 23;
					text2 = "0";
					goto IL_142;
					IL_128:
					num2 = 25;
					if (num3 >= 0)
					{
						goto IL_13C;
					}
					IL_130:
					num2 = 26;
					text2 = "0";
					goto IL_142;
					IL_13C:
					num2 = 28;
					text2 = null;
					IL_142:
					num2 = 29;
					num3 = 0;
					IL_148:
					num2 = 30;
					if (Operators.CompareString(text2, "", true) <= 0)
					{
						goto IL_19A;
					}
					IL_15B:
					num2 = 31;
					string text3 = text2;
					for (int i = 0; i < text3.Length; i = checked(i + 1))
					{
						string @string = Conversions.ToString(text3[i]);
						IL_177:
						num2 = 32;
						num3 += Strings.Asc(@string);
						IL_186:
						num2 = 33;
					}
					IL_19A:
					num2 = 34;
					if (Operators.CompareString(this.OO_O000__._O., "", true) != 0)
					{
						goto IL_1BA;
					}
					IL_1B0:
					num2 = 35;
					result = false;
					goto IL_68F;
					IL_1BA:
					num2 = 36;
					string oo_O000__._O. = this.OO_O000__._O.;
					IL_1C5:
					num2 = 37;
					this.OO_O000__._O. = Strings.Mid(this.OO_O000__._O., this.oo__.Oo0o_O., this.Oo0._O.);
					IL_1E5:
					num2 = 38;
					this.OoO._0o0_. = Strings.Mid(this.o.00., this.oo__.Oo0o_O. - 4, this.Oo0._O. / 2);
					IL_209:
					num2 = 39;
					int.TryParse(this.OOooo0O_OO._., out this.o_0_0.o.);
					IL_21E:
					num2 = 40;
					int.TryParse(this.o_0_0.o., out this.OoO._0o0_.);
					IL_233:
					num2 = 41;
					this.o_0_0.o. += Conversions.ToInteger(oo_O000__._O..Substring(12, 4));
					IL_252:
					num2 = 42;
					this.OoO._0o0_. += Conversions.ToInteger(oo_O000__._O..Substring(16, 4));
					IL_271:
					num2 = 43;
					if (this.o_0_0.o. != 0)
					{
						goto IL_286;
					}
					IL_27C:
					num2 = 44;
					result = false;
					goto IL_68F;
					IL_286:
					num2 = 45;
					if (this.OoO._0o0_. != 0)
					{
						goto IL_29C;
					}
					IL_291:
					num2 = 46;
					this.OoO._0o0_. = 13;
					IL_29C:
					num2 = 47;
					this.o_0_0.o. = o0OO__.o_o.0OOoO0O0.(this.o_0_0.o.);
					IL_2B0:
					num2 = 48;
					this.o_0_0.o. = Foxtable.WinForm.Form.O_.O__Oo.(string.Concat(new string[]
					{
						O_O0OO.oO__._0_0O0o0.,
						"(",
						Conversions.ToString(this.o_0_0.o.),
						",",
						Conversions.ToString(this.OoO._0o0_.),
						")"
					})).ToString();
					IL_30A:
					num2 = 49;
					this.o_0_0.o. = Foxtable.WinForm.Form.O_.O__Oo.("EUNumber(" + this.o_0_0.o. + ")").ToString();
					IL_332:
					num2 = 50;
					this.o_0_0.o. = o_o_O0OO_0__.o000oOoo.0.(this.o_0_0.o.);
					IL_346:
					num2 = 51;
					this.OOooo0O_OO._. = O00.EncryptText(this.o_0_0.o., this.OoO._0o0_., this.OoO._0o0_.);
					IL_366:
					num2 = 52;
					this.OOooo0O_OO._. = O00.MD5Encrypt(this.OOooo0O_OO._.);
					IL_37A:
					num2 = 53;
					this.OOooo0O_OO._. = o0OO__.O.0ooOoO_0_.(this.OOooo0O_OO._.);
					IL_38E:
					num2 = 54;
					foreach (byte b in Encoding.ASCII.GetBytes(this.OOooo0O_OO._.))
					{
						IL_3AF:
						num2 = 55;
						this.oO_.o0_OO_OO0. += Conversions.ToString((int)b % this.O._0o_O00. + 1);
						IL_3D3:
						num2 = 56;
					}
					IL_3E4:
					num2 = 57;
					this.oO_.o0_OO_OO0. = Strings.Left(this.oO_.o0_OO_OO0., 8);
					IL_3F9:
					num2 = 58;
					int.TryParse(this.oO_.o0_OO_OO0., out this.o_0_0.o.);
					IL_40E:
					num2 = 59;
					int.TryParse(this.OO_O000__._O., out this.OO_O000__._O.);
					IL_423:
					num2 = 60;
					this.oO_.o0_OO_OO0. = this.o_0_0.o. + this.OO_O000__._O.;
					IL_439:
					num2 = 61;
					this.O.o0Ooo. = Math.Abs(this.o_0_0.o. - this.OO_O000__._O.);
					IL_454:
					num2 = 62;
					if (this.OO_O000__._O. != 0)
					{
						goto IL_467;
					}
					IL_45F:
					num2 = 63;
					bool flag = false;
					goto IL_4BD;
					IL_467:
					num2 = 65;
					if (Operators.CompareString(O00.MD5Encrypt(this.oO_.o0_OO_OO0..ToString()), O_O0OO.OO.o_., true) != 0)
					{
						goto IL_48F;
					}
					IL_487:
					num2 = 66;
					flag = true;
					goto IL_4BD;
					IL_48F:
					num2 = 68;
					if (Operators.CompareString(O00.MD5Encrypt(this.O.o0Ooo..ToString()), O_O0OO.OO.o_., true) != 0)
					{
						goto IL_4B7;
					}
					IL_4AF:
					num2 = 69;
					flag = true;
					goto IL_4BD;
					IL_4B7:
					num2 = 71;
					flag = false;
					IL_4BD:
					num2 = 72;
					Main.OO_O.o..oOO0.OOoo0oO. = (BooleanEnum)Conversions.ToInteger(Interaction.IIf(flag, BooleanEnum.True, BooleanEnum.False));
					IL_4E2:
					num2 = 73;
					text = Application.ProductVersion.Replace(".", "");
					IL_4FB:
					num2 = 74;
					num3 = 0;
					IL_501:
					num2 = 75;
					value = '0';
					IL_508:
					num2 = 76;
					array = new char[1];
					IL_513:
					num2 = 77;
					text2 = "";
					IL_51D:
					num2 = 78;
					array[0] = '.';
					IL_526:
					num2 = 79;
					array2 = null;
					IL_52C:
					num2 = 80;
					array2 = text.Split(new char[]
					{
						array[0]
					});
					IL_545:
					num2 = 81;
					if (!(array2[0].Length > 0 & num3 >= 0))
					{
						goto IL_5BF;
					}
					IL_55F:
					num2 = 82;
					array2[0] = o_O_o_oOoo__.OOOO_OO._oo.(array2[0]);
					IL_56F:
					num2 = 83;
					if (array2[0].Length <= num3)
					{
						goto IL_599;
					}
					IL_57F:
					num2 = 84;
					text2 = Conversions.ToString(array2[0][num3]);
					goto IL_62A;
					IL_599:
					num2 = 86;
					if (array2[0].Length != num3)
					{
						goto IL_5B7;
					}
					IL_5A9:
					num2 = 87;
					text2 = Conversions.ToString(value);
					goto IL_62A;
					IL_5B7:
					num2 = 89;
					text2 = null;
					goto IL_62A;
					IL_5BF:
					num2 = 91;
					if (!(array2.Length > 1 & num3 < 0))
					{
						goto IL_610;
					}
					IL_5D1:
					num2 = 92;
					if (array2[1].Length < Math.Abs(num3))
					{
						goto IL_604;
					}
					IL_5E6:
					num2 = 93;
					text2 = Conversions.ToString(array2[1][Math.Abs(num3) - 1]);
					goto IL_62A;
					IL_604:
					num2 = 95;
					text2 = "0";
					goto IL_62A;
					IL_610:
					num2 = 97;
					if (num3 >= 0)
					{
						goto IL_624;
					}
					IL_618:
					num2 = 98;
					text2 = "0";
					goto IL_62A;
					IL_624:
					num2 = 100;
					text2 = null;
					IL_62A:
					num2 = 101;
					num3 = 0;
					IL_630:
					num2 = 102;
					if (Operators.CompareString(text2, "", true) <= 0)
					{
						goto IL_68A;
					}
					IL_643:
					num2 = 103;
					string text4 = text2;
					for (int k = 0; k < text4.Length; k = checked(k + 1))
					{
						string string2 = Conversions.ToString(text4[k]);
						IL_65F:
						num2 = 104;
						num3 += Strings.Asc(string2);
						IL_66E:
						num2 = 105;
					}
					IL_682:
					num2 = 106;
					result = flag;
					goto IL_68F;
					IL_68A:
					num2 = 107;
					result = false;
					IL_68F:
					goto IL_891;
					IL_694:
					int num4 = num5 + 1;
					num5 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
					IL_852:
					goto IL_886;
					IL_854:
					num5 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_864:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_854;
				}
				IL_886:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_891:
				if (num5 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x04001DE8 RID: 7656
			private int <<EMPTY_NAME>>;

			// Token: 0x04001DE9 RID: 7657
			private int <<EMPTY_NAME>>;

			// Token: 0x04001DEA RID: 7658
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DEB RID: 7659
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DEC RID: 7660
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DED RID: 7661
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DEE RID: 7662
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DEF RID: 7663
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DF0 RID: 7664
			private int <<EMPTY_NAME>>;

			// Token: 0x04001DF1 RID: 7665
			private int <<EMPTY_NAME>>;

			// Token: 0x04001DF2 RID: 7666
			private int <<EMPTY_NAME>>;

			// Token: 0x04001DF3 RID: 7667
			private int <<EMPTY_NAME>>;

			// Token: 0x04001DF4 RID: 7668
			private int <<EMPTY_NAME>>;

			// Token: 0x04001DF5 RID: 7669
			private int <<EMPTY_NAME>>;
		}

		// Token: 0x02000447 RID: 1095
		internal class o0_o_o
		{
			// Token: 0x060049E8 RID: 18920 RVA: 0x0020A7C4 File Offset: 0x002089C4
			public o0_o_o()
			{
				this.O0.0_. = Oo00.O_.0_0__o0.();
				this.O0O.O000. = this.O0.0_..Substring(24, 4) + o0OO__.o_o.0OOoO0O0.();
				this.O_o.o_0oOo. = this.O0.0_..Substring(8, 4);
				this.O_O0_0_O.o_oo. = Oo00.O_00O_o.0o_.();
				this.OO0_.o_oOO00. = "";
				this.OoOO00o.oo. = "A8d5WJZGnluJO/h4uElNcg==";
				this.O._O_. = "my";
				this.o_O__0O.o. = "home";
				this.OOO.o0O0o0_O. = "2048";
				this.o___o0o._O. = "";
				this.oOo._. = "";
				this.OoO.oo0. = "";
				this.oO0_o0.O0o. = "";
				this.O0o_.OO0O0. = "";
				this.o.oO_Oo_0__0o. = "";
				this.O_oOo._0. = "htm";
			}

			// Token: 0x060049E9 RID: 18921 RVA: 0x0020A8A4 File Offset: 0x00208AA4
			internal bool <<EMPTY_NAME>>()
			{
				int num;
				bool result;
				int num8;
				object obj;
				try
				{
					IL_00:
					ProjectData.ClearProjectError();
					num = 1;
					IL_07:
					int num2 = 2;
					this.OOO.o0O0o0_O. = this.OOO.o0O0o0_O..TrimEnd(new char[]
					{
						'.'
					});
					IL_25:
					num2 = 3;
					if (Versioned.IsNumeric(this.OOO.o0O0o0_O.))
					{
						goto IL_41;
					}
					IL_34:
					num2 = 4;
					this.o.oO_Oo_0__0o. = "web";
					IL_41:
					num2 = 5;
					if (Conversion.Val(this.OOO.o0O0o0_O.) != 0.0)
					{
						goto IL_66;
					}
					IL_59:
					num2 = 6;
					this.o.oO_Oo_0__0o. = "http";
					IL_66:
					num2 = 7;
					if (Operators.CompareString(this.o.oO_Oo_0__0o., "", true) != 0)
					{
						goto IL_3A8;
					}
					IL_7E:
					num2 = 8;
					this.o_o0Ooo._O. = (long)((int)Math.Floor(Conversion.Val(this.OOO.o0O0o0_O.)));
					IL_98:
					num2 = 9;
					if (this.OOO.o0O0o0_O..IndexOf(".") < 0)
					{
						goto IL_D1;
					}
					IL_AE:
					num2 = 10;
					this.o___o0o._O. = this.OOO.o0O0o0_O..Substring(this.OOO.o0O0o0_O..IndexOf('.') + 1);
					IL_D1:
					num2 = 11;
					if (this.o_o0Ooo._O. <= 0L)
					{
						goto IL_2C4;
					}
					IL_E1:
					num2 = 12;
					if (this.o_o0Ooo._O. != 0L)
					{
						goto IL_FF;
					}
					IL_EC:
					num2 = 13;
					this.o.oO_Oo_0__0o. = "ssl";
					goto IL_2C4;
					IL_FF:
					num2 = 15;
					this.OOO.o0O0o0_O. = this.o_o0Ooo._O..ToString();
					IL_113:
					num2 = 16;
					int num3 = 1;
					do
					{
						IL_119:
						num2 = 17;
						this.oOo._. = Strings.Right(this.OOO.o0O0o0_O., 4);
						IL_12E:
						num2 = 18;
						this.o_o0Ooo._O. = long.Parse(this.oOo._.);
						IL_142:
						num2 = 19;
						this.oOo._. = this.o_o0Ooo._O..ToString();
						IL_156:
						num2 = 20;
						if (num3 == 1)
						{
							IL_15E:
							num2 = 21;
							this.O0o_.OO0O0. = this.oOo._.;
						}
						else
						{
							IL_172:
							num2 = 23;
							if (this.o_o0Ooo._O. > 0L)
							{
								IL_17F:
								num2 = 24;
								this.oO0_o0.O0o. = this.oOo._. + Conversions.ToString(this.O_oOo._0.[num3 - 2]);
							}
							IL_1A7:
							num2 = 25;
							if (Operators.CompareString(this.O0o_.OO0O0., "", true) > 0)
							{
								IL_1BE:
								num2 = 26;
								if (this.o_o0Ooo._O. == 0L || this.OoO.oo0..Length < 4 || this.oOo._..EndsWith("0"))
								{
									IL_1E9:
									num2 = 27;
									this.O0o_.OO0O0. = this.oO0_o0.O0o. + "z" + this.O0o_.OO0O0.;
								}
								else
								{
									IL_20A:
									num2 = 29;
									this.O0o_.OO0O0. = this.oO0_o0.O0o. + this.O0o_.OO0O0.;
								}
							}
							else
							{
								IL_226:
								num2 = 31;
								this.O0o_.OO0O0. = this.oO0_o0.O0o.;
							}
						}
						IL_235:
						num2 = 32;
						this.OoO.oo0. = this.oOo._.;
						IL_244:
						num2 = 33;
						if (this.OOO.o0O0o0_O..Length <= 4)
						{
							break;
						}
						IL_255:
						num2 = 36;
						this.OOO.o0O0o0_O. = this.OOO.o0O0o0_O..Substring(0, this.OOO.o0O0o0_O..Length - 4);
						IL_277:
						num2 = 37;
						num3++;
					}
					while (num3 <= 4);
					IL_288:
					num2 = 38;
					this.O0o_.OO0O0. = this.O0o_.OO0O0..Replace("ftp", "");
					IL_2A6:
					num2 = 39;
					this.O0o_.OO0O0. = this.O0o_.OO0O0..Replace("http", "d");
					IL_2C4:
					num2 = 40;
					if (Operators.CompareString(this.o___o0o._O., "", true) <= 0)
					{
						goto IL_397;
					}
					IL_2DE:
					num2 = 41;
					if (Operators.CompareString(this.O0o_.OO0O0., "", true) != 0)
					{
						goto IL_304;
					}
					IL_2F4:
					num2 = 42;
					this.O0o_.OO0O0. = "https";
					goto IL_31D;
					IL_304:
					num2 = 44;
					this.O0o_.OO0O0. += "sll";
					IL_31D:
					num2 = 45;
					int num4 = this.o___o0o._O..Length - this.o___o0o._O..TrimStart(new char[]
					{
						'0'
					}).Length;
					IL_349:
					num2 = 46;
					if (num4 <= 0)
					{
						goto IL_373;
					}
					IL_351:
					num2 = 47;
					this.O0o_.OO0O0. += "w".PadLeft(num4, 'w');
					IL_373:
					num2 = 48;
					this.O0o_.OO0O0. += Conversions.ToString(Conversions.ToInteger(this.o___o0o._O.));
					IL_397:
					num2 = 49;
					this.o.oO_Oo_0__0o. = this.O0o_.OO0O0.;
					goto IL_3B7;
					IL_3A8:
					num2 = 51;
					this.o.oO_Oo_0__0o. = this.O0o_.OO0O0.;
					IL_3B7:
					num2 = 52;
					if (Operators.CompareString(this.o.oO_Oo_0__0o., this.O0o_.OO0O0., true) != 0)
					{
						goto IL_655;
					}
					IL_3D1:
					num2 = 53;
					if (Operators.CompareString(this.O_O0_0_O.o_oo., "", true) != 0)
					{
						goto IL_3F1;
					}
					IL_3E7:
					num2 = 54;
					result = false;
					goto IL_655;
					IL_3F1:
					num2 = 55;
					string o_O0_0_O.o_oo. = this.O_O0_0_O.o_oo.;
					IL_3FC:
					num2 = 56;
					this.O_O0_0_O.o_oo. = o0OO__.oOO.o_.();
					IL_40A:
					num2 = 57;
					int.TryParse(this.O0O.O000., out this.O0.0_.);
					IL_41F:
					num2 = 58;
					int.TryParse(this.O_o.o_0oOo., out this.O_o.o_0oOo.);
					IL_434:
					num2 = 59;
					if (this.O_o.o_0oOo. != 0)
					{
						goto IL_44A;
					}
					IL_43F:
					num2 = 60;
					this.O_o.o_0oOo. = 17;
					IL_44A:
					num2 = 61;
					this.O00O.00_0_. = this.O0.0_.(this.O0.0_., this.O_o.o_0oOo.);
					IL_465:
					num2 = 62;
					this.O0O.O000. = O00.EncryptText(this.O00O.00_0_., "my", "home");
					IL_483:
					num2 = 63;
					this.oOO.o_O. = O00.ooo000o_0.00o0.(this.O0O.O000., this.O._O_., this.o_O__0O.o.);
					IL_4A3:
					num2 = 64;
					this.O0O.O000. = o_O_o_oOoo__.OOOO_OO._oo.(O00.MD5Encrypt(this.oOO.o_O.).Trim(new char[]
					{
						'='
					}));
					IL_4CC:
					num2 = 65;
					this.OO0_.o_oOO00. = "";
					IL_4DA:
					num2 = 66;
					int num5 = 0;
					do
					{
						IL_4E0:
						num2 = 67;
						this.OO0_.o_oOO00. += Conversions.ToString((int)(this.O0O.O000.[num5] % '\t' + '\u0001'));
						IL_50B:
						num2 = 68;
						num5++;
					}
					while (num5 <= 7);
					IL_519:
					num2 = 69;
					this.O.__OO_o0_o. = this.O0.0_.(Conversions.ToInteger(this.OO0_.o_oOO00.));
					IL_533:
					num2 = 70;
					string a_ = O00.ooo000o_0.00o0.(this.O.__OO_o0_o., o_O0_0_O.o_oo..Substring(4, 4), o_O0_0_O.o_oo..Substring(8, 4));
					IL_555:
					num2 = 71;
					this.O0O.O000. = o_o_O0OO_0__.o000oOoo.0.(a_);
					IL_565:
					num2 = 72;
					this.OO0_.o_oOO00. = "";
					IL_573:
					num2 = 73;
					int num6 = 0;
					do
					{
						IL_579:
						num2 = 74;
						this.OO0_.o_oOO00. += Conversions.ToString((int)(this.O0O.O000.[num6] % '\t' + '\u0001'));
						IL_5A4:
						num2 = 75;
						num6++;
					}
					while (num6 <= 3);
					IL_5B2:
					num2 = 76;
					int.TryParse(this.OO0_.o_oOO00., out this.O0.0_.);
					IL_5C7:
					num2 = 77;
					int.TryParse(this.O_O0_0_O.o_oo., out this.OO_0_0_O00.o.);
					IL_5DC:
					num2 = 78;
					if (Operators.CompareString(O00.EncryptText((this.O0.0_. + this.OO_0_0_O00.o.).ToString(), this.O._O_., this.o_O__0O.o.), this.OoOO00o.oo., true) != 0 && Operators.CompareString(O00.EncryptText((this.O0.0_. - this.OO_0_0_O00.o.).ToString(), this.O._O_., this.o_O__0O.o.), this.OoOO00o.oo., true) != 0)
					{
						goto IL_650;
					}
					IL_649:
					num2 = 79;
					result = true;
					goto IL_655;
					IL_650:
					num2 = 81;
					result = false;
					IL_655:
					goto IL_7EF;
					IL_65A:
					int num7 = num8 + 1;
					num8 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7);
					IL_7B0:
					goto IL_7E4;
					IL_7B2:
					num8 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_7C2:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num8 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_7B2;
				}
				IL_7E4:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_7EF:
				if (num8 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x060049EA RID: 18922 RVA: 0x0020B0C8 File Offset: 0x002092C8
			private string <<EMPTY_NAME>>(int A_0, int A_1)
			{
				int num;
				string result;
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
					A_0 += 1111;
					IL_1B:
					num2 = 4;
					if (A_0 % A_1 != 0)
					{
						goto IL_29;
					}
					IL_22:
					num2 = 5;
					A_0 += 7;
					IL_29:
					num2 = 6;
					int num3 = 1;
					do
					{
						IL_2E:
						num2 = 7;
						int num4 = A_0 / A_1;
						IL_35:
						num2 = 8;
						text += Conversions.ToString(num4);
						IL_47:
						num2 = 9;
						A_0 = (A_0 - A_1 * num4) * 10;
						IL_55:
						num2 = 10;
						num3++;
					}
					while (num3 <= 1000);
					IL_67:
					num2 = 11;
					text = text.Trim(new char[]
					{
						'0'
					});
					IL_7E:
					num2 = 12;
					if (text.Length > 8)
					{
						goto IL_94;
					}
					IL_8B:
					num2 = 13;
					string text2 = text;
					goto IL_AA;
					IL_94:
					num2 = 15;
					text2 = text.Substring(text.Length - 8, 8);
					IL_AA:
					num2 = 16;
					result = text2;
					IL_B0:
					goto IL_146;
					IL_B5:
					int num5 = num6 + 1;
					num6 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
					IL_107:
					goto IL_13B;
					IL_109:
					num6 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_119:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_109;
				}
				IL_13B:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_146:
				if (num6 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x060049EB RID: 18923 RVA: 0x0020B240 File Offset: 0x00209440
			private string <<EMPTY_NAME>>(int A_0)
			{
				int num;
				string result;
				int num5;
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
					string text2 = "lyeshwiqbjs";
					IL_19:
					num2 = 4;
					DateTime dateTime = new DateTime(598950720000000000L).AddDays((double)(A_0 % 9999));
					IL_3C:
					num2 = 5;
					int year = dateTime.Year;
					IL_47:
					num2 = 6;
					int month = dateTime.Month;
					IL_52:
					num2 = 7;
					int day = dateTime.Day;
					IL_5D:
					num2 = 8;
					string text3 = year.ToString();
					IL_68:
					num2 = 9;
					string text4 = "";
					IL_72:
					num2 = 10;
					string str = "";
					IL_7C:
					num2 = 11;
					string str2 = "";
					IL_86:
					num2 = 12;
					int num3 = text3.Length - 1;
					for (int i = 0; i <= num3; i++)
					{
						IL_99:
						num2 = 13;
						text4 += Conversions.ToString(text2[int.Parse(Conversions.ToString(text3[i]))]);
						IL_C4:
						num2 = 14;
					}
					IL_D3:
					num2 = 15;
					if (month >= 10)
					{
						goto IL_FB;
					}
					IL_DC:
					num2 = 16;
					str = "ling" + Conversions.ToString(text2[month]);
					goto IL_130;
					IL_FB:
					num2 = 18;
					if (month != 10)
					{
						goto IL_110;
					}
					IL_104:
					num2 = 19;
					str = "yishi";
					goto IL_130;
					IL_110:
					num2 = 21;
					str = "yishi" + Conversions.ToString(text2[month % 10]);
					IL_130:
					num2 = 22;
					if (day >= 10)
					{
						goto IL_158;
					}
					IL_139:
					num2 = 23;
					str2 = "ling" + Conversions.ToString(text2[day]);
					goto IL_1C4;
					IL_158:
					num2 = 25;
					if (day >= 10)
					{
						goto IL_180;
					}
					IL_161:
					num2 = 26;
					str2 = "ling" + Conversions.ToString(text2[10]);
					goto IL_1C4;
					IL_180:
					num2 = 28;
					str2 = Strings.Mid(text2, day / 10 + 1, 1) + "shi";
					IL_19E:
					num2 = 29;
					if (day % 10 <= 0)
					{
						goto IL_1C4;
					}
					IL_1A9:
					num2 = 30;
					str2 += Strings.Mid(text2, day % 10 + 1, 1);
					IL_1C4:
					num2 = 31;
					foreach (byte b in Encoding.Unicode.GetBytes(str2 + text4 + str))
					{
						IL_1EA:
						num2 = 32;
						text += b.ToString();
						IL_1FD:
						num2 = 33;
					}
					IL_20E:
					num2 = 34;
					result = text;
					IL_214:
					goto IL_2F2;
					IL_219:
					int num4 = num5 + 1;
					num5 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
					IL_2B3:
					goto IL_2E7;
					IL_2B5:
					num5 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_2C5:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_2B5;
				}
				IL_2E7:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_2F2:
				if (num5 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x04001DF6 RID: 7670
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DF7 RID: 7671
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DF8 RID: 7672
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DF9 RID: 7673
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DFA RID: 7674
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DFB RID: 7675
			private int <<EMPTY_NAME>>;

			// Token: 0x04001DFC RID: 7676
			private int <<EMPTY_NAME>>;

			// Token: 0x04001DFD RID: 7677
			private int <<EMPTY_NAME>>;

			// Token: 0x04001DFE RID: 7678
			private string <<EMPTY_NAME>>;

			// Token: 0x04001DFF RID: 7679
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E00 RID: 7680
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E01 RID: 7681
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E02 RID: 7682
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E03 RID: 7683
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E04 RID: 7684
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E05 RID: 7685
			private long <<EMPTY_NAME>>;

			// Token: 0x04001E06 RID: 7686
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E07 RID: 7687
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E08 RID: 7688
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E09 RID: 7689
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E0A RID: 7690
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E0B RID: 7691
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E0C RID: 7692
			private string <<EMPTY_NAME>>;
		}
	}
}
