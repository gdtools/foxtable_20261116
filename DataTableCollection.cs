using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using Foxtable.RibbonMenu;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002AD RID: 685
	[ComVisible(true)]
	[oO0oooo("0365")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DataTableCollection : IEnumerable<DataTable>
	{
		// Token: 0x060024B8 RID: 9400 RVA: 0x0010A711 File Offset: 0x00108911
		public DataTableCollection()
		{
			this.OO0o00.0O_0o. = new Dictionary<string, DataTable>();
			this.OO0o00.0O_0o. = true;
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x0010A72B File Offset: 0x0010892B
		internal void <<EMPTY_NAME>>(DataTable A_0)
		{
			this.OO0o00.0O_0o..Add(A_0.Name, A_0);
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x0010A73F File Offset: 0x0010893F
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.OO0o00.0O_0o..Remove(A_0);
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x0010A750 File Offset: 0x00108950
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataTable Item
		{
			get
			{
				DataTable result;
				if (this.OO0o00.0O_0o..ContainsKey(TableName))
				{
					result = this.OO0o00.0O_0o.[TableName];
				}
				else
				{
					try
					{
						foreach (string text in this.OO0o00.0O_0o..Keys)
						{
							if (Operators.CompareString(text, TableName, true) == 0)
							{
								return this.OO0o00.0O_0o.[text];
							}
						}
					}
					finally
					{
						Dictionary<string, DataTable>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					MessageBox.Show("不存在名称为\"" + TableName + "\"的DataTable！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x0010A7FC File Offset: 0x001089FC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataTable Item
		{
			get
			{
				return this.OO0o00.0O_0o.[O_O0OO.OOOo.oo_OOOO_0.().Tables[Index].TableName];
			}
		}

		// Token: 0x1700082C RID: 2092
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataTable this[object A_0]
		{
			get
			{
				int index = -1;
				DataTable result;
				if (int.TryParse(A_0.ToString(), out index))
				{
					result = this.get_Item(index);
				}
				else
				{
					result = this.get_Item(A_0.ToString());
				}
				return result;
			}
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x0010A856 File Offset: 0x00108A56
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<DataTable> GetEnumerator()
		{
			return (IEnumerator<DataTable>)this.OO0o00.0O_0o..Values.GetEnumerator();
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x0010A872 File Offset: 0x00108A72
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return (IEnumerator)this.OO0o00.0O_0o..Values.GetEnumerator();
		}

		/// <summary>
		/// 是否包含指定名称的DataTable
		/// </summary>
		/// <param name="DataTableName">表名</param>
		// Token: 0x060024C0 RID: 9408 RVA: 0x0010A890 File Offset: 0x00108A90
		public bool Contains(string DataTableName)
		{
			bool result;
			if (this.OO0o00.0O_0o..ContainsKey(DataTableName))
			{
				result = true;
			}
			else
			{
				try
				{
					Dictionary<string, DataTable>.KeyCollection.Enumerator enumerator = this.OO0o00.0O_0o..Keys.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(enumerator.Current, DataTableName, true) == 0)
						{
							return true;
						}
					}
				}
				finally
				{
					Dictionary<string, DataTable>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = false;
			}
			return result;
		}

		/// <summary>
		/// 返回表DataTable的数量
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x0010A904 File Offset: 0x00108B04
		public int Count
		{
			get
			{
				return this.OO0o00.0O_0o..Count;
			}
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x0010A914 File Offset: 0x00108B14
		internal void <<EMPTY_NAME>>(string A_0, string A_1, List<string> A_2, List<Type> A_3, List<int> A_4, List<string> A_5, List<string> A_6)
		{
			DataTable dataTable = new DataTable();
			if (OO_00oOO.DataTables.Contains(A_0))
			{
				MessageBox.Show("表" + A_0 + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (Oo00.o.O0_O0.(A_0) && A_2.Count != 0 && A_2.Count == A_3.Count && A_2.Count == A_4.Count && A_2.Count == A_5.Count)
			{
				dataTable.TableName = A_0;
				int num = A_2.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (!o_O_o_oOoo__.O_o_._o0.(A_2[i], "列名", 64, false))
					{
						return;
					}
					dataTable.Columns.Add(A_2[i], A_3[i]);
					if (A_3[i] == typeof(string))
					{
						dataTable.Columns[A_2[i]].MaxLength = A_4[i];
					}
				}
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable);
				int num2 = A_2.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (Operators.CompareString(A_6[j], "", true) > 0)
					{
						try
						{
							dataTable.Columns[A_2[j]].Expression = A_6[j];
						}
						catch (Exception a_)
						{
							ooO.oOo0Oo.o.(a_, "");
							break;
						}
					}
				}
				this.OO0o00.0O_0o..Add(A_0, new DataTable(dataTable, null, null, A_0, O_O0OO.OoO.0OO__0ooo.()));
				OO_00oOO.DataTables[A_0].o.0O000_.();
				OO_00oOO.DataTables[A_0].Caption = A_1;
				OO_00oOO.DataTables[A_0].AddByCode = true;
				try
				{
					foreach (DataCol dataCol in OO_00oOO.DataTables[A_0].DataCols)
					{
						dataCol.Caption = A_5[A_2.IndexOf(dataCol.Name)];
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
			}
		}

		/// <summary>
		/// 删除指定名称的DataTable
		/// </summary>
		/// <param name="DataTableName">表名</param>
		// Token: 0x060024C3 RID: 9411 RVA: 0x0010AB5C File Offset: 0x00108D5C
		public void Delete(string DataTableName)
		{
			if (!this.OO0o00.0O_0o..ContainsKey(DataTableName))
			{
				MessageBox.Show("找不到你要删除的表[" + DataTableName + "]！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (!this.OO0o00.0O_0o.[DataTableName].AddByCode)
			{
				MessageBox.Show("只能删除用代码增加的表，其余表请通过菜单删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			this.Remove(DataTableName);
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x0010ABC4 File Offset: 0x00108DC4
		private void Remove(string TableName)
		{
			int num2;
			int num4;
			object obj2;
			try
			{
				IL_00:
				int num = 1;
				Dictionary<string, DataTable>.ValueCollection.Enumerator enumerator = this.OO0o00.0O_0o..Values.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataTable dataTable = enumerator.Current;
					IL_1E:
					num = 2;
					if (Operators.CompareString(dataTable.Name, TableName, true) == 0)
					{
						IL_30:
						num = 3;
						TableName = dataTable.Name;
						break;
					}
					IL_3D:
					num = 5;
				}
				IL_48:
				num = 6;
				((IDisposable)enumerator).Dispose();
				IL_57:
				num = 7;
				if (!this.OO0o00.0O_0o..ContainsKey(TableName))
				{
					goto IL_342;
				}
				IL_6A:
				num = 8;
				IEnumerator<Foxtable.WinForm.Form> enumerator2 = OO_00oOO.Forms.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Foxtable.WinForm.Form form = enumerator2.Current;
					IL_83:
					num = 9;
					if (form.Opened && Operators.CompareString(form.o_o0__00._., TableName, true) == 0 && (form.FormStyle == FormStyleEnum.主窗口 || form.FormStyle == FormStyleEnum.停靠 || form.FormStyle == FormStyleEnum.并列))
					{
						IL_BC:
						num = 10;
						form.Close();
					}
					IL_C6:
					num = 11;
				}
				IL_D2:
				num = 12;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_E0:
				num = 13;
				IEnumerator<Table> enumerator3 = OO_00oOO.Tables.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					Table table = enumerator3.Current;
					IL_FA:
					num = 14;
					if (table.IsCopy && Operators.CompareString(table.DataTable.Name, TableName, true) == 0)
					{
						IL_11B:
						num = 15;
						table.foxGrid.Enabled = false;
						IL_12B:
						num = 16;
						table.StopRedraw();
					}
					IL_135:
					num = 17;
				}
				IL_141:
				num = 18;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_14F:
				num = 19;
				IEnumerator enumerator4 = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					object obj = enumerator4.Current;
					C1DockingTabPage c1DockingTabPage = (C1DockingTabPage)obj;
					IL_178:
					num = 20;
					if (Operators.CompareString(c1DockingTabPage.Name, TableName, true) == 0)
					{
						IL_18B:
						num = 21;
						Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Remove(c1DockingTabPage);
						IL_1A4:
						num = 22;
						Oo0__Oo oo0__Oo = (Oo0__Oo)c1DockingTabPage;
						IL_1B0:
						num = 23;
						oo0__Oo.O_000__.o.(null);
						IL_1BB:
						num = 24;
						oo0__Oo.O_000__.o.(null);
						IL_1C6:
						oo0__Oo = null;
						IL_1C9:
						num = 26;
						c1DockingTabPage.Controls.Clear();
						IL_1D8:
						num = 27;
						c1DockingTabPage.Dispose();
						break;
					}
					IL_1E4:
					num = 29;
				}
				IL_1F3:
				num = 30;
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
				IL_20B:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_212:
				num = 32;
				bool a_ = OO_00oOO.SystemReady;
				IL_21C:
				num = 33;
				OO_00oOO.SystemReady = false;
				IL_225:
				num = 34;
				DataTable dataTable2 = OO_00oOO.DataTables[TableName].BaseTable;
				IL_23A:
				num = 35;
				O_oOooO_O o_oOooO_O = OO_00oOO.Tables[TableName].foxGrid;
				IL_24F:
				num = 36;
				O_0 o_ = OO_00oOO.Tables[TableName].View;
				IL_264:
				num = 37;
				o_O_o_oOoo__.oo.O0o0o.(OO_00oOO.Tables[TableName]);
				IL_277:
				num = 38;
				OO_00oOO.Tables[TableName].foxGrid = null;
				IL_28B:
				num = 39;
				OO_00oOO.Tables.OO._O_o__.(TableName);
				IL_299:
				num = 40;
				OO_00oOO.DataTables.OoO_00.O.(TableName);
				IL_2A7:
				num = 41;
				O_O0OO.o__.O.().Remove(O_O0OO.o__.O.()[TableName].Oo._Oo0OO.());
				IL_2C5:
				num = 42;
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(TableName);
				IL_2D8:
				num = 43;
				o_oOooO_O.o.0O_O0o_. = null;
				IL_2E3:
				num = 44;
				o_oOooO_O.SetDataBinding(null, null);
				IL_2EF:
				num = 45;
				o_.Dispose();
				IL_2F9:
				num = 46;
				dataTable2.Reset();
				IL_303:
				num = 47;
				dataTable2.Dispose();
				IL_30D:
				num = 48;
				o_oOooO_O.o.o0OO00oO_0.();
				IL_317:
				num = 49;
				o_oOooO_O.Controls.Clear();
				IL_326:
				num = 50;
				o_oOooO_O.Dispose();
				IL_330:
				num = 51;
				OO_00oOO.SystemReady = a_;
				IL_33A:
				num = 52;
				GC.Collect();
				IL_342:
				goto IL_468;
				IL_347:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_429:
				goto IL_45D;
				IL_42B:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_43B:;
			}
			catch when (endfilter(obj2 is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_42B;
			}
			IL_45D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_468:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x0010B060 File Offset: 0x00109260
		internal bool <<EMPTY_NAME>>(string A_0, bool A_1)
		{
			bool result;
			if (this.Count == 1)
			{
				MessageBox.Show("至少要保留一个表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				try
				{
					foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
					{
						DataRelation dataRelation = (DataRelation)obj;
						if (Operators.CompareString(dataRelation.ParentTable.TableName, A_0, true) == 0 | Operators.CompareString(dataRelation.ChildTable.TableName, A_0, true) == 0)
						{
							MessageBox.Show("请在删除表[" + A_0 + "]之前，先删除有关的表间关联！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
				if (!OO_00oOO.MainTable.DataTable.AddByCode && MessageBox.Show("表删除操作是不可撤销的，确定要删除表[" + A_0 + "]吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					result = false;
				}
				else
				{
					if (!OO_00oOO.DataTables[A_0].AddByCode)
					{
						if (OO_00oOO.DataTables[A_0].frd_IsTemporary)
						{
							try
							{
								foreach (object obj2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o_0_000._O.()].Rows)
								{
									DataRow dataRow = (DataRow)obj2;
									if (Operators.CompareString(Conversions.ToString(dataRow["Name"]), A_0, true) == 0)
									{
										dataRow.Delete();
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
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o_0_000._O.()], true);
						}
						else if (OO_00oOO.DataTables[A_0].frd_IsInnerTable)
						{
							o_oo0 o_oo = new o_oo0(O_O0OO.OoO.0OO__0ooo.(), false, true);
							o_oo.o0_oo0._.().oooO__O_0o_.o_.(A_0);
							o_oo.o0_oo0._.(true, false);
							OleDbCommand oleDbCommand = new OleDbCommand(string.Concat(new string[]
							{
								"Delete * From [",
								ooO0__OO.O00.O__o.(),
								"] Where [Table] = '~TMPCLP",
								A_0,
								"'"
							}), OO_00oOO.DataTables[A_0].frd_Connection);
							OO_00oOO.DataTables[A_0].frd_Connection.Open();
							oleDbCommand.ExecuteNonQuery();
							OO_00oOO.DataTables[A_0].frd_Connection.Close();
						}
						else
						{
							try
							{
								foreach (object obj3 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows)
								{
									DataRow dataRow2 = (DataRow)obj3;
									if (Operators.CompareString(Conversions.ToString(dataRow2["Name"]), A_0, true) == 0)
									{
										dataRow2.Delete();
									}
								}
							}
							finally
							{
								IEnumerator enumerator3;
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
						}
					}
					int num = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						C1DockingTabPage c1DockingTabPage = Main.OO_O.o..OO_O_0Oo.___o.().TabPages[i];
						if (Operators.CompareString(c1DockingTabPage.Name, A_0, true) == 0)
						{
							if (i > 0)
							{
								Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = i - 1;
							}
							else
							{
								Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = i + 1;
							}
							Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Remove(c1DockingTabPage);
							break;
						}
					}
					Table table = OO_00oOO.Tables[A_0];
					DataTable dataTable = OO_00oOO.Tables[A_0].DataTable.BaseTable;
					OO_00oOO.Tables.OO._O_o__.(A_0);
					OO_00oOO.DataTables.OoO_00.O.(A_0);
					O_O0OO.o__.O.().Remove(O_O0OO.o__.O.()[A_0].Oo._Oo0OO.());
					O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(A_0);
					table.OO0_.__.();
					dataTable.Reset();
					dataTable.Dispose();
					this.OO0o00.0O_0o.(A_0);
					GC.Collect();
					GC.Collect();
					GC.Collect();
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x0010B498 File Offset: 0x00109698
		internal void <<EMPTY_NAME>>(string A_0)
		{
			try
			{
				foreach (object obj in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (Operators.CompareString(Conversions.ToString(dataRow["Table"]), A_0, true) == 0)
					{
						dataRow.Delete();
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
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
			try
			{
				foreach (object obj2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows)
				{
					DataRow dataRow2 = (DataRow)obj2;
					if (Operators.CompareString(Conversions.ToString(dataRow2["Table"]), A_0, true) == 0 || Operators.CompareString(Conversions.ToString(dataRow2["Table"]), "{" + A_0 + "}", true) == 0 || Operators.CompareString(Conversions.ToString(dataRow2["Table"]), "[" + A_0 + "]", true) == 0)
					{
						dataRow2.Delete();
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
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
			try
			{
				foreach (object obj3 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Rows)
				{
					DataRow dataRow3 = (DataRow)obj3;
					if (Operators.CompareString(Conversions.ToString(dataRow3["Table"]), A_0, true) == 0)
					{
						dataRow3.Delete();
					}
				}
			}
			finally
			{
				IEnumerator enumerator3;
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()], true);
			string file = string.Concat(new string[]
			{
				OO_00oOO.ProjectPath,
				"Bin\\",
				o0OoOOoOOo0.oo00o.0OoO.(""),
				".DataTable.",
				A_0,
				".dll"
			});
			if (OO_00oOO.FileSys.FileExists(file))
			{
				OO_00oOO.FileSys.DeleteFile(file);
			}
		}

		/// <summary>
		/// 保存所有DataTable
		/// </summary>
		/// <returns></returns>
		// Token: 0x060024C7 RID: 9415 RVA: 0x0010B714 File Offset: 0x00109914
		public bool Save()
		{
			List<string> list = new List<string>();
			if (OO_00oOO.CurrentTable != null)
			{
				O_oOooO_O o_oOooO_O = OO_00oOO.CurrentTable.foxGrid;
				if (o_oOooO_O.Editor != null)
				{
					o_oOooO_O.FinishEditing();
				}
			}
			CancelEventArgs cancelEventArgs = new CancelEventArgs();
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeSaveProject", new object[]
			{
				cancelEventArgs
			}, false, "项目", false);
			bool result;
			if (cancelEventArgs.Cancel)
			{
				result = false;
			}
			else
			{
				try
				{
					Foxtable.RibbonMenu.StatusBar.Message1 = "正在保存，请稍候...";
					Application.DoEvents();
					try
					{
						foreach (DataTable dataTable in this.OO0o00.0O_0o..Values)
						{
							if (Operators.CompareString(dataTable.DataServer, "", true) > 0)
							{
								if (Operators.CompareString(dataTable.UpdateServer, "", true) > 0)
								{
									if (!dataTable.o.o_O.())
									{
										return false;
									}
									try
									{
										foreach (Table table in OO_00oOO.Tables)
										{
											if (table.View.o_o.O0ooOo.() == dataTable.BaseTable)
											{
												table.Oo._0oO.();
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
									dataTable.O0o0.O_0_.();
								}
							}
							else if (dataTable.frd_IsTemporary || dataTable.frd_IsInnerQuery || dataTable.frd_IsOuterQuery)
							{
								dataTable.BaseTable.AcceptChanges();
							}
							else if (!dataTable.o.o_O.())
							{
								return false;
							}
						}
					}
					finally
					{
						Dictionary<string, DataTable>.ValueCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					O_O0OO.OoO.0OO__0ooo.().Open();
					try
					{
						foreach (OleDbConnection oleDbConnection in O_O0OO.O._o_.().Values)
						{
							oleDbConnection.Open();
						}
					}
					finally
					{
						Dictionary<string, OleDbConnection>.ValueCollection.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					try
					{
						foreach (DataTable dataTable2 in this.OO0o00.0O_0o..Values)
						{
							if (Operators.CompareString(dataTable2.UpdateServer, "", true) <= 0)
							{
								dataTable2.oo_o0.0_.();
								if (dataTable2.frd_IsInnerTable)
								{
									dataTable2.oO.o_0.(true, false);
								}
								else
								{
									if (!dataTable2.AddByCode)
									{
										try
										{
											foreach (Table table2 in OO_00oOO.Tables)
											{
												if (table2.View.o_o.O0ooOo.() == dataTable2.BaseTable)
												{
													table2.Oo._0oO.();
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
									}
									if (dataTable2.frd_IsOuterTable)
									{
										list.Add(dataTable2.Name);
									}
								}
							}
						}
					}
					finally
					{
						Dictionary<string, DataTable>.ValueCollection.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					if (list.Count > 0)
					{
						int num = O_O0OO.OOOo.oo_OOOO_0.().Relations.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							try
							{
								foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
								{
									DataRelation dataRelation = (DataRelation)obj;
									if (OO_00oOO.DataTables[dataRelation.ParentTable.TableName].frd_IsOuterTable && OO_00oOO.DataTables[dataRelation.ChildTable.TableName].frd_IsOuterTable)
									{
										int num2 = list.IndexOf(dataRelation.ParentTable.TableName);
										int num3 = list.IndexOf(dataRelation.ChildTable.TableName);
										if (num2 > num3)
										{
											list.Remove(dataRelation.ChildTable.TableName);
											list.Remove(dataRelation.ParentTable.TableName);
											list.Insert(num3, dataRelation.ParentTable.TableName);
											list.Insert(num2, dataRelation.ChildTable.TableName);
										}
									}
								}
							}
							finally
							{
								IEnumerator enumerator6;
								if (enumerator6 is IDisposable)
								{
									(enumerator6 as IDisposable).Dispose();
								}
							}
						}
						if (O_O0OO.OOOo.oo_OOOO_0.().HasChanges())
						{
							int num4 = list.Count - 1;
							for (int j = 0; j <= num4; j++)
							{
								string a_ = list[j];
								OO_00oOO.DataTables[a_].oo_.0oo_.(new DataRow[0]);
								OO_00oOO.DataTables[a_].O0_0oOO.0.(new DataRow[0]);
							}
							for (int k = list.Count - 1; k >= 0; k += -1)
							{
								string a_2 = list[k];
								OO_00oOO.DataTables[a_2].oO.o_0.(new DataRow[0]);
							}
						}
					}
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()], true);
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterSaveProject", null, false, "项目", false);
					Main.OO_O.o..o._oOO0. = false;
					try
					{
						foreach (Table table3 in OO_00oOO.Tables)
						{
							if (table3.IsChild)
							{
								table3.Refresh();
							}
							table3.foxGrid.Invalidate();
						}
					}
					finally
					{
						IEnumerator<Table> enumerator7;
						if (enumerator7 != null)
						{
							enumerator7.Dispose();
						}
					}
					result = !O_O0OO.OOOo.oo_OOOO_0.().HasChanges();
				}
				catch (Exception ex)
				{
					result = false;
				}
				finally
				{
					Foxtable.RibbonMenu.StatusBar.Message1 = "";
					O_O0OO.OoO.0OO__0ooo.().Close();
					try
					{
						foreach (OleDbConnection oleDbConnection2 in O_O0OO.O._o_.().Values)
						{
							oleDbConnection2.Close();
						}
					}
					finally
					{
						Dictionary<string, OleDbConnection>.ValueCollection.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
				}
			}
			return result;
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x0010BD8C File Offset: 0x00109F8C
		private string GetTopParentName(DataRelation re1)
		{
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (dataRelation.ChildTable == re1.ParentTable)
					{
						return this.GetTopParentName(dataRelation);
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
			return re1.ParentTable.TableName;
		}

		/// <summary>
		/// 是否允许编辑数据
		/// </summary>
		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060024C9 RID: 9417 RVA: 0x0010BE0C File Offset: 0x0010A00C
		// (set) Token: 0x060024CA RID: 9418 RVA: 0x0010BE14 File Offset: 0x0010A014
		public bool AllowEdit
		{
			get
			{
				return this.OO0o00.0O_0o.;
			}
			set
			{
				this.OO0o00.0O_0o. = value;
				Main.OO_O.o..Refresh();
			}
		}

		/// <summary>
		/// 是否保持编辑模式
		/// </summary>
		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x0010BE28 File Offset: 0x0010A028
		// (set) Token: 0x060024CC RID: 9420 RVA: 0x0010BE48 File Offset: 0x0010A048
		public bool PreserveEditMode
		{
			get
			{
				BooleanEnum oo0o00.0O_0o. = this.OO0o00.0O_0o.;
				return this.OO0o00.0O_0o. == BooleanEnum.True;
			}
			set
			{
				if (value)
				{
					this.OO0o00.0O_0o. = BooleanEnum.True;
				}
				else
				{
					this.OO0o00.0O_0o. = BooleanEnum.False;
				}
				try
				{
					foreach (DataTable dataTable in OO_00oOO.DataTables)
					{
						dataTable.o0.0o_0.();
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
		}

		/// <summary>
		/// 撤销自打开文件或最近一次保存以来的全部修改
		/// </summary>
		// Token: 0x060024CD RID: 9421 RVA: 0x0010BEA8 File Offset: 0x0010A0A8
		public void RejectChanges()
		{
			O_O0OO.OOOo.oo_OOOO_0.().RejectChanges();
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					table.ClearEditInfos();
					if (!table.IsRelation)
					{
						table.RefreshChildTables();
					}
					table.NeedSaveSetting = false;
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
		/// 加载表
		/// </summary>
		/// <param name="DataTableNames">要加载的表，表名和表名之间用符号“|”隔开</param>
		// Token: 0x060024CE RID: 9422 RVA: 0x0010BF14 File Offset: 0x0010A114
		[oO0oooo("2755")]
		public void Load(string DataTableNames)
		{
			int num;
			int num6;
			object obj5;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string[] array = DataTableNames.Split(new char[]
				{
					'|'
				});
				IL_1B:
				num2 = 3;
				string[] array2 = array;
				int i = 0;
				checked
				{
					while (i < array2.Length)
					{
						string text = array2[i];
						IL_2F:
						num2 = 4;
						bool flag = false;
						IL_34:
						num2 = 5;
						if (OO_00oOO.DataTables.Contains(text))
						{
							IL_44:
							num2 = 6;
							MessageBox.Show("[" + text + "]已经加载!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else
						{
							IL_6A:
							num2 = 8;
							DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()];
							IL_82:
							num2 = 9;
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								object obj = enumerator.Current;
								DataRow dataRow = (DataRow)obj;
								IL_A3:
								num2 = 10;
								if (Operators.CompareString(Conversions.ToString(dataRow["Name"]), text, true) == 0)
								{
									IL_C1:
									num2 = 11;
									flag = true;
									IL_C7:
									num2 = 12;
									o0OoOOoOOo0.OOOOO.o000.(dataRow, O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), true, false, null);
								}
								IL_101:
								num2 = 13;
							}
							IL_10D:
							num2 = 14;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
							IL_125:
							dataTable = null;
							IL_128:
							num2 = 16;
							if (!flag)
							{
								IL_12F:
								num2 = 17;
								o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), this, O_O0OO.OOOo.oo_OOOO_0.(), "~TMPCLP" + text, true, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), false);
							}
							IL_15F:
							num2 = 18;
							if (OO_00oOO.DataTables.Contains(text))
							{
								IL_173:
								num2 = 20;
								i++;
								continue;
							}
						}
						IL_8AD:
						goto IL_AD7;
					}
					IL_187:
					num2 = 21;
					IEnumerator enumerator2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()].Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						object obj2 = enumerator2.Current;
						DataRow dataRow2 = (DataRow)obj2;
						IL_1BD:
						num2 = 22;
						string right = Conversions.ToString(dataRow2["ParentTable"]);
						IL_1D3:
						num2 = 23;
						string left = Conversions.ToString(dataRow2["ChildTable"]);
						IL_1E9:
						num2 = 24;
						bool flag2 = false;
						IL_1EF:
						num2 = 25;
						foreach (string text2 in array)
						{
							IL_201:
							num2 = 26;
							if (Operators.CompareString(text2, right, true) == 0 || Operators.CompareString(left, text2, true) == 0)
							{
								IL_21C:
								num2 = 27;
								flag2 = true;
							}
							IL_222:
							num2 = 28;
						}
						IL_233:
						num2 = 29;
						if (flag2)
						{
							IL_23A:
							num2 = 30;
							o0OoOOoOOo0.OO0._Oo0o.(dataRow2, O_O0OO.OOOo.oo_OOOO_0.());
							IL_249:
							num2 = 31;
							Oo00.o00O0O_.O.(Conversions.ToString(dataRow2["Name"]), false, false);
						}
						IL_264:
						num2 = 32;
					}
					IL_273:
					num2 = 33;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
					IL_28B:
					num2 = 34;
					IEnumerator enumerator3 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						object obj3 = enumerator3.Current;
						DataRow dataRow3 = (DataRow)obj3;
						IL_2C1:
						num2 = 35;
						string text3 = Conversions.ToString(dataRow3["Table"]);
						IL_2D7:
						num2 = 36;
						bool flag3 = false;
						IL_2DD:
						num2 = 37;
						foreach (string left2 in array)
						{
							IL_2EF:
							num2 = 38;
							if (Operators.CompareString(left2, text3, true) == 0)
							{
								IL_2FE:
								num2 = 39;
								flag3 = true;
							}
							IL_304:
							num2 = 40;
						}
						IL_315:
						num2 = 41;
						if (flag3)
						{
							IL_31F:
							num2 = 42;
							string a_ = Conversions.ToString(dataRow3["Column"]);
							IL_335:
							num2 = 43;
							ColumnDataTypeEnum columnDataTypeEnum = (ColumnDataTypeEnum)Conversions.ToInteger(dataRow3["DataType"]);
							IL_34B:
							num2 = 44;
							int a_2;
							if (columnDataTypeEnum == ColumnDataTypeEnum.String && !dataRow3.IsNull("Maxlength"))
							{
								IL_365:
								num2 = 45;
								a_2 = Conversions.ToInteger(dataRow3["Maxlength"]);
							}
							else
							{
								IL_37D:
								num2 = 47;
								a_2 = -1;
							}
							IL_383:
							num2 = 48;
							o0OoOOoOOo0.O0OoO_0o.O.(O_O0OO.OOOo.oo_OOOO_0.().Tables[text3], a_, columnDataTypeEnum, string.Empty, a_2);
						}
						IL_3A7:
						num2 = 49;
					}
					IL_3B6:
					num2 = 50;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
					IL_3CE:
					num2 = 51;
					foreach (string a_3 in array)
					{
						IL_3E3:
						num2 = 52;
						OO_00oOO.DataTables[a_3].o.0O000_.();
						IL_3F7:
						num2 = 53;
						OO_00oOO.DataTables[a_3].o0O.ooO00.();
						IL_40B:
						num2 = 54;
						IEnumerator<DataCol> enumerator4 = OO_00oOO.DataTables[a_3].DataCols.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							DataCol dataCol = enumerator4.Current;
							IL_431:
							num2 = 55;
							dataCol.o_.Oo00_O_00_.();
							IL_43B:
							num2 = 56;
						}
						IL_447:
						num2 = 57;
						if (enumerator4 != null)
						{
							enumerator4.Dispose();
						}
						IL_455:
						num2 = 58;
					}
					IL_469:
					num2 = 59;
					IEnumerator enumerator5 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.GetEnumerator();
					while (enumerator5.MoveNext())
					{
						object obj4 = enumerator5.Current;
						DataRow dataRow4 = (DataRow)obj4;
						IL_49F:
						num2 = 60;
						string text4 = Conversions.ToString(dataRow4["Table"]);
						IL_4B5:
						num2 = 61;
						bool flag4 = false;
						IL_4BB:
						num2 = 62;
						foreach (string left3 in array)
						{
							IL_4CD:
							num2 = 63;
							if (Operators.CompareString(left3, text4, true) == 0)
							{
								IL_4DC:
								num2 = 64;
								flag4 = true;
							}
							IL_4E2:
							num2 = 65;
						}
						IL_4F3:
						num2 = 66;
						if (flag4)
						{
							IL_4FA:
							num2 = 67;
							string name = Conversions.ToString(dataRow4["Column"]);
							IL_510:
							num2 = 68;
							string text5 = Conversions.ToString(dataRow4["Expression"]);
							IL_526:
							num2 = 69;
							if (Operators.CompareString(text5, "", true) == 0)
							{
								IL_538:
								num2 = 70;
								text5 = string.Empty;
							}
							IL_542:
							num2 = 71;
							this.OO0o00.0O_0o.(OO_00oOO.DataTables[text4].BaseTable.Columns[name], text5);
						}
						IL_56A:
						num2 = 72;
					}
					IL_579:
					num2 = 73;
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
					IL_591:
					num2 = 74;
					OO_00oOO.Tables.OO._O_o__.();
					IL_59E:
					num2 = 75;
					foreach (string a_4 in array)
					{
						IL_5B0:
						num2 = 76;
						Main.OO_O.o..o0_o_o_0.0O.(a_4, true, true);
						IL_5C1:
						num2 = 77;
					}
					IL_5D2:
					num2 = 78;
					IEnumerator<Table> enumerator6 = OO_00oOO.Tables.GetEnumerator();
					while (enumerator6.MoveNext())
					{
						Table table = enumerator6.Current;
						IL_5EF:
						num2 = 79;
						bool flag5 = false;
						IL_5F5:
						num2 = 80;
						foreach (string left4 in array)
						{
							IL_607:
							num2 = 81;
							if (Operators.CompareString(left4, table.DataTable.Name, true) == 0)
							{
								IL_620:
								num2 = 82;
								flag5 = true;
							}
							IL_626:
							num2 = 83;
						}
						IL_637:
						num2 = 84;
						if (flag5)
						{
							IL_641:
							num2 = 85;
							if (table.IsRelation)
							{
								IL_650:
								num2 = 86;
								if (table.foxGrid.FindForm() == null)
								{
									IL_664:
									num2 = 88;
									table.foxGrid.Visible = false;
									IL_674:
									num2 = 89;
									Main.OO_O.o..Controls.Add(table.foxGrid);
									IL_68D:
									num2 = 90;
									table.O.__O0o0.(true);
									IL_699:
									num2 = 91;
									Main.OO_O.o..Controls.Remove(table.foxGrid);
									IL_6B2:
									num2 = 92;
									table.foxGrid.Visible = true;
									IL_6C2:
									num2 = 93;
									if (table._frdAutoOpen)
									{
										IL_6CE:
										num2 = 94;
										table.Visible = true;
									}
									IL_6D9:
									num2 = 95;
									table.foxGrid.o_.o. = table.foxGrid.BottomRow;
								}
							}
							else
							{
								IL_6F9:
								num2 = 97;
								if (table.TableType == TableTypeEnum.Normal && !table.View.O0O.o__0.())
								{
									IL_719:
									num2 = 98;
									IEnumerator<Col> enumerator7 = table.Cols.GetEnumerator();
									while (enumerator7.MoveNext())
									{
										Col col = enumerator7.Current;
										IL_735:
										num2 = 99;
										if (col.DataCol.ExtendType == ExtendTypeEnum.Images || col.DataCol.ExtendType == ExtendTypeEnum.Files || (col.DataCol.IsString && (col.DataCol.MaxLength == -1 || col.DataCol.MaxLength > 2048)))
										{
											IL_786:
											num2 = 100;
											if (col.DataCol.AutoOpen)
											{
												IL_797:
												num2 = 101;
												col.OpenWindow(0);
											}
										}
										IL_7A2:
										num2 = 102;
									}
									IL_7B1:
									num2 = 103;
									if (enumerator7 != null)
									{
										enumerator7.Dispose();
									}
								}
							}
						}
						IL_7BF:
						num2 = 104;
					}
					IL_7CE:
					num2 = 105;
					if (enumerator6 != null)
					{
						enumerator6.Dispose();
					}
					IL_7DC:
					num2 = 106;
					IEnumerator<Foxtable.WinForm.Form> enumerator8 = OO_00oOO.Forms.GetEnumerator();
					while (enumerator8.MoveNext())
					{
						Foxtable.WinForm.Form form = enumerator8.Current;
						IL_7F9:
						num2 = 107;
						if (form.AutoOpen && form.FormStyle != FormStyleEnum.模式)
						{
							IL_812:
							num2 = 108;
							if (form.FormStyle == FormStyleEnum.主窗口 || form.FormStyle == FormStyleEnum.停靠 || form.FormStyle == FormStyleEnum.并列)
							{
								IL_832:
								num2 = 109;
								bool flag6 = false;
								IL_838:
								num2 = 110;
								foreach (string left5 in array)
								{
									IL_84A:
									num2 = 111;
									if (Operators.CompareString(left5, form.TableName, true) == 0)
									{
										IL_85E:
										num2 = 112;
										flag6 = true;
									}
									IL_864:
									num2 = 113;
								}
								IL_875:
								num2 = 114;
								if (flag6)
								{
									IL_87C:
									num2 = 115;
									form.Open(int.MaxValue, int.MaxValue);
								}
							}
						}
						IL_890:
						num2 = 116;
					}
					IL_89F:
					num2 = 117;
					if (enumerator8 != null)
					{
						enumerator8.Dispose();
						goto IL_8AD;
					}
					goto IL_8AD;
					IL_8B2:;
				}
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_A98:
				goto IL_ACC;
				IL_A9A:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_AAA:;
			}
			catch when (endfilter(obj5 is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj6;
				goto IL_A9A;
			}
			IL_ACC:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_AD7:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0010CA1C File Offset: 0x0010AC1C
		private void <<EMPTY_NAME>>(DataColumn A_0, string A_1)
		{
			try
			{
				A_0.Expression = A_1;
			}
			catch (Exception a_)
			{
				MessageBox.Show(string.Concat(new string[]
				{
					"无法将[",
					A_0.Table.TableName,
					"]表的[",
					A_0.ColumnName,
					"]列的表达式设置为:\r\n",
					A_1,
					"\r\n如果确定表达式无语法错误，且参与运算的各列的名称准确无误，那么请检查各列的数据类型是否正确，例如只有数值列才能参与加、减、乘、除等数学运算！"
				}), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		/// <summary>
		/// 卸载表
		/// </summary>
		/// <param name="DataTableNames">要卸载的表名，表名和表名之间用符号“|”隔开</param>
		// Token: 0x060024D0 RID: 9424 RVA: 0x0010CAB0 File Offset: 0x0010ACB0
		[oO0oooo("2756")]
		public void Unload(string DataTableNames)
		{
			try
			{
				OO_00oOO.LockBaseMainForm();
				string[] array = DataTableNames.Split(new char[]
				{
					'|'
				});
				try
				{
					foreach (Relation relation in OO_00oOO.Relations)
					{
						string right = relation.ParentTable.Name;
						string right2 = relation.ChildTable.Name;
						bool flag;
						bool flag2;
						foreach (string left in array)
						{
							if (Operators.CompareString(left, right, true) == 0)
							{
								flag = true;
							}
							if (Operators.CompareString(left, right2, true) == 0)
							{
								flag2 = true;
							}
						}
						if (flag ^ flag2)
						{
							MessageBox.Show("关联表必须同步卸载！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
					}
				}
				finally
				{
					IEnumerator<Relation> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				foreach (string a_ in array)
				{
					try
					{
						foreach (DataCol dataCol in OO_00oOO.DataTables[a_].DataCols)
						{
							if (Operators.CompareString(dataCol.Expression, "", true) > 0)
							{
								dataCol.Expression = string.Empty;
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
				for (int k = OO_00oOO.Relations.Count - 1; k >= 0; k += -1)
				{
					Relation relation2 = OO_00oOO.Relations[k];
					string right3 = relation2.ParentTable.Name;
					string right4 = relation2.ChildTable.Name;
					bool flag3 = false;
					bool flag4 = false;
					foreach (string left2 in array)
					{
						if (Operators.CompareString(left2, right3, true) == 0)
						{
							flag3 = true;
						}
						if (Operators.CompareString(left2, right4, true) == 0)
						{
							flag4 = true;
						}
					}
					if (flag3 && flag4)
					{
						Oo00.OO.0O0o.(relation2.Name);
					}
				}
				foreach (string tableName in array)
				{
					this.Remove(tableName);
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			finally
			{
				OO_00oOO.UnlockBaseMainForm();
			}
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x0010CD24 File Offset: 0x0010AF24
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<string> GetDetailNames()
		{
			List<string> list = new List<string>();
			O_O0OO.OoO.0OO__0ooo.().Open();
			DataRow[] array = O_O0OO.OoO.0OO__0ooo.().GetSchema("Tables").Select("[TABLE_TYPE]='TABLE' ");
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = Conversions.ToString(array[i]["TABLE_NAME"]);
					if (!o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) && text.StartsWith("~TMPCLP"))
					{
						list.Add(text.Substring(7) + ".1");
					}
				}
				O_O0OO.OoO.0OO__0ooo.().Close();
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()];
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						OtherTableTypeEnum otherTableTypeEnum = (OtherTableTypeEnum)Conversions.ToInteger(dataRow["Type"]);
						string text2 = Conversions.ToString(dataRow["Name"]);
						if (otherTableTypeEnum == OtherTableTypeEnum.InnerQuery)
						{
							text2 += ".2";
						}
						else if (otherTableTypeEnum == OtherTableTypeEnum.Table)
						{
							text2 = text2 + ".3." + dataRow["DataSource"].ToString();
						}
						else if (otherTableTypeEnum == OtherTableTypeEnum.Query)
						{
							text2 = text2 + ".4." + dataRow["DataSource"].ToString();
						}
						list.Add(text2);
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
					foreach (object obj2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o_0_000._O.()].Rows)
					{
						DataRow dataRow2 = (DataRow)obj2;
						list.Add(Conversions.ToString(dataRow2["Name"]) + ".5");
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
				return list;
			}
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x0010CF30 File Offset: 0x0010B130
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<string> GetDataTableNames()
		{
			List<string> list = new List<string>();
			O_O0OO.OoO.0OO__0ooo.().Open();
			DataRow[] array = O_O0OO.OoO.0OO__0ooo.().GetSchema("Tables").Select("[TABLE_TYPE]='TABLE' ");
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = Conversions.ToString(array[i]["TABLE_NAME"]);
					if (!o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) && text.StartsWith("~TMPCLP"))
					{
						list.Add(text.Substring(7));
					}
				}
				O_O0OO.OoO.0OO__0ooo.().Close();
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()];
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						list.Add(Conversions.ToString(dataRow["Name"]));
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
					foreach (object obj2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o_0_000._O.()].Rows)
					{
						DataRow dataRow2 = (DataRow)obj2;
						list.Add(Conversions.ToString(dataRow2["Name"]));
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
				return list;
			}
		}

		// Token: 0x04000F2C RID: 3884
		internal Dictionary<string, DataTable> <<EMPTY_NAME>>;

		// Token: 0x04000F2D RID: 3885
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000F2E RID: 3886
		private BooleanEnum <<EMPTY_NAME>>;
	}
}
