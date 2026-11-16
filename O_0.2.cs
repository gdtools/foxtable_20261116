using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200030F RID: 783
	[DefaultMember("Item")]
	internal class O_0 : BindingSource
	{
		// Token: 0x06002A2B RID: 10795 RVA: 0x0012BB48 File Offset: 0x00129D48
		internal O_0(Dictionary<string, O_0> A_0, DataTable A_1)
		{
			base.CurrentChanged += this.o_._0O0o_OoO.;
			base.PositionChanged += this.Oo._Oo0OO.;
			if (A_1.DataSet == null)
			{
				base.DataSource = A_1;
			}
			else
			{
				base.DataSource = A_1.DataSet;
				base.DataMember = A_1.TableName;
			}
			this.O0_Oo0.0o_o0. = A_1.TableName;
			this.Oo0_.O. = true;
			if (A_0 != null)
			{
				A_0.Add(this.Oo._Oo0OO.(), this);
			}
			if (A_1.PrimaryKey.Length == 1)
			{
				bool autoIncrement = A_1.PrimaryKey[0].AutoIncrement;
			}
			this.O00o0.0_0O_.(true);
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x0012BBEC File Offset: 0x00129DEC
		internal O_0(DataTable A_0, string A_1)
		{
			base.CurrentChanged += this.o_._0O0o_OoO.;
			base.PositionChanged += this.Oo._Oo0OO.;
			lock (A_0)
			{
				DataView dataSource = new DataView(A_0);
				base.DataSource = dataSource;
				this.O0_Oo0.0o_o0. = A_1;
				O_O0OO.o__.O.().Add(this.Oo._Oo0OO.(), this);
				if (A_0.PrimaryKey.Length == 1)
				{
					bool autoIncrement = A_0.PrimaryKey[0].AutoIncrement;
				}
				this.O00o0.0_0O_.(true);
			}
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x0012BC94 File Offset: 0x00129E94
		internal O_0(Dictionary<string, O_0> A_0, O_0 A_1, DataRelation A_2)
		{
			base.CurrentChanged += this.o_._0O0o_OoO.;
			base.PositionChanged += this.Oo._Oo0OO.;
			this.O0_Oo0.0o_o0. = A_1;
			this.O0_Oo0.0o_o0. = A_2;
			if (A_1.o_o.O0ooOo.() == A_2.ParentTable)
			{
				base.DataSource = A_1;
				base.DataMember = A_2.RelationName;
				this.O0_Oo0.0o_o0. = true;
				this.O0_Oo0.0o_o0. = A_1.Oo._Oo0OO.() + "." + A_2.ChildTable.TableName;
			}
			else
			{
				base.DataSource = A_2.DataSet;
				base.DataMember = A_2.ParentTable.TableName;
				this.oo0_Oo.00__. = true;
				this.O0_Oo0.0o_o0. = A_1.Oo._Oo0OO.() + "." + A_2.ParentTable.TableName;
			}
			if (A_0 != null)
			{
				if (A_0.ContainsKey(this.Oo._Oo0OO.()))
				{
					return;
				}
				A_0.Add(this.Oo._Oo0OO.(), this);
			}
			DataTable table = this.o_o.O0ooOo.().Table;
			if (table.PrimaryKey.Length == 1)
			{
				bool autoIncrement = table.PrimaryKey[0].AutoIncrement;
			}
			this.O00o0.0_0O_.(true);
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x0012BDB5 File Offset: 0x00129FB5
		internal bool <<EMPTY_NAME>>()
		{
			return this.O_o.o_0.;
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x0012BDBD File Offset: 0x00129FBD
		internal void <<EMPTY_NAME>>(bool A_0)
		{
			this.O_o.o_0. = A_0;
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x0012BDC8 File Offset: 0x00129FC8
		internal void <<EMPTY_NAME>>()
		{
			if (this.O0OOO_0.o.())
			{
				base.Sort = "";
				return;
			}
			if (this.o_o.O0ooOo.().Columns.Contains("_SortKey"))
			{
				base.Sort = "_SortKey";
				return;
			}
			base.Sort = "";
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x0012BE17 File Offset: 0x0012A017
		internal bool <<EMPTY_NAME>>()
		{
			return Operators.CompareString(base.DataMember, "", true) == 0;
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x0012BE2D File Offset: 0x0012A02D
		internal bool <<EMPTY_NAME>>()
		{
			return this.O0_Oo0.0o_o0.;
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0012BE35 File Offset: 0x0012A035
		internal bool <<EMPTY_NAME>>()
		{
			return this.oo0_Oo.00__.;
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x0012BE3D File Offset: 0x0012A03D
		internal bool <<EMPTY_NAME>>()
		{
			return this.Oo0_.O.;
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x0012BE48 File Offset: 0x0012A048
		internal DataView <<EMPTY_NAME>>()
		{
			DataView result;
			if (this.O0O_0_0__.0O.() != null && this.O0O_0_0__.0O.().Count == 0)
			{
				result = new DataView(this.o_o.O0ooOo.(), "", "", DataViewRowState.None);
			}
			else if (base.List is DataView)
			{
				result = (DataView)base.List;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x0012BEA4 File Offset: 0x0012A0A4
		internal DataTable <<EMPTY_NAME>>()
		{
			DataTable result;
			if (this.O0O_0_0__.0O.() != null)
			{
				if (this.O0OOO_0.o.())
				{
					result = this.O0O_0_0__.0O.().ParentTable;
				}
				else
				{
					result = this.O0O_0_0__.0O.().ChildTable;
				}
			}
			else
			{
				result = this.o_o.O0ooOo.().Table;
			}
			return result;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x0012BEEA File Offset: 0x0012A0EA
		internal O_0 <<EMPTY_NAME>>()
		{
			return this.O0_Oo0.0o_o0.;
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x0012BEF2 File Offset: 0x0012A0F2
		internal string <<EMPTY_NAME>>()
		{
			return this.O0_Oo0.0o_o0.;
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x0012BEFA File Offset: 0x0012A0FA
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.O0_Oo0.0o_o0. = A_0;
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x0012BF03 File Offset: 0x0012A103
		internal DataRelation <<EMPTY_NAME>>()
		{
			return this.O0_Oo0.0o_o0.;
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x0012BF0C File Offset: 0x0012A10C
		internal DataRowView <<EMPTY_NAME>>()
		{
			DataRowView result;
			if (base.Position < 0 || base.Current == null)
			{
				result = null;
			}
			else
			{
				result = (DataRowView)base.Current;
			}
			return result;
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x0012BF3C File Offset: 0x0012A13C
		internal int <<EMPTY_NAME>>(DataRow A_0)
		{
			DataView dataView = this.o_o.O0ooOo.();
			if (A_0.Table == this.o_o.O0ooOo.())
			{
				for (int i = base.Position; i >= 0; i += -1)
				{
					if (dataView[i].Row == A_0)
					{
						return i;
					}
				}
				int num = base.Position + 1;
				int num2 = dataView.Count - 1;
				for (int j = num; j <= num2; j++)
				{
					if (dataView[j].Row == A_0)
					{
						return j;
					}
				}
			}
			else
			{
				int num3 = dataView.Count - 1;
				for (int k = 0; k <= num3; k++)
				{
					bool flag = true;
					foreach (DataColumn dataColumn in this.o_o.O0ooOo.().PrimaryKey)
					{
						if (Operators.CompareString(dataView[k][dataColumn.ColumnName].ToString(), A_0[dataColumn.ColumnName].ToString(), true) != 0)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						return k;
					}
				}
			}
			return -1;
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x0012C04B File Offset: 0x0012A24B
		internal string <<EMPTY_NAME>>()
		{
			return base.Filter;
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x0012C053 File Offset: 0x0012A253
		internal void <<EMPTY_NAME>>(string A_0)
		{
			base.Filter = A_0;
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x0012C05C File Offset: 0x0012A25C
		internal string <<EMPTY_NAME>>()
		{
			return this.o_O_.00o.;
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x0012C064 File Offset: 0x0012A264
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.o_O_.00o. = A_0;
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x0012C070 File Offset: 0x0012A270
		public override string get_Filter()
		{
			string result;
			if (this.o__0.O.())
			{
				result = this.o0.O0.();
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x0012C098 File Offset: 0x0012A298
		public override void set_Filter(string value)
		{
			if (this.o_o.O0ooOo.() != null && this.o_o.O0ooOo.().IsEdit)
			{
				this.o_o.O0ooOo.().EndEdit();
			}
			FilterEventArgs filterEventArgs = new FilterEventArgs(OO_00oOO.Tables[this.Oo._Oo0OO.()], value);
			string a_ = "BeforeFilter";
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].o_0_00_.oo0O0., a_, new object[]
			{
				filterEventArgs
			}, false, this.o_o.O0ooOo.().TableName, false);
			if (!filterEventArgs.Cancel && OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].GlobalHandler.BeforeFilter)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					filterEventArgs
				}, false, "全局表事件", false);
			}
			if (!filterEventArgs.Cancel)
			{
				OO_00oOO.Tables[this.Oo._Oo0OO.()].o.oO000Ooo_.();
				value = filterEventArgs.Filter;
				if (Operators.CompareString(filterEventArgs.Filter, "", true) > 0)
				{
					this.Oo._Oo0OO.(filterEventArgs.Filter);
				}
				this.o_O_.00o.(Operators.CompareString(value, "", true) > 0);
				DataRow dataRow = null;
				int position = base.Position;
				if (this.o_o.O0ooOo.() != null)
				{
					dataRow = this.o_o.O0ooOo.().Row;
				}
				if (this.O0O.o__0.() || this.O.o_OOOo_OoO.())
				{
					this.O00o0.0_0O_.(false);
					try
					{
						base.Filter = value;
						OO_00oOO.Tables[this.Oo._Oo0OO.()].foxGrid.O.O00O_oO_OO00.(true);
						goto IL_4D5;
					}
					catch (Exception a_2)
					{
						ooO.oOo0Oo.o.(a_2, "");
						goto IL_4D5;
					}
					finally
					{
						this.O00o0.0_0O_.(true);
						if ((this.o_o.O0ooOo.() != null && this.o_o.O0ooOo.().Row != dataRow) || (this.o_o.O0ooOo.() == null && dataRow != null))
						{
							this.o_._0O0o_OoO.();
						}
						if (base.Position != position)
						{
							this.Oo._Oo0OO.();
						}
					}
				}
				if (!this.O0OOO_0.o.())
				{
					try
					{
						this.O00o0.0_0O_.(false);
						try
						{
							foreach (Table table in OO_00oOO.Tables)
							{
								if (table.Name.StartsWith(this.Oo._Oo0OO.() + "."))
								{
									table.View.O00o0.0_0O_.(false);
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
						OO_00oOO.Tables[this.Oo._Oo0OO.()].StopRedraw();
						base.Filter = "False";
						Dictionary<DataColumn, string> a_3 = Oo00.ooO.ooo.(this.o_o.O0ooOo.());
						DataRow[] array = this.o_o.O0ooOo.().Select("[System_Filter_Temporary] Is Not Null");
						checked
						{
							for (int i = 0; i < array.Length; i++)
							{
								array[i]["System_Filter_Temporary"] = DBNull.Value;
							}
							if (Operators.CompareString(value, "", true) > 0)
							{
								DataRow[] array2 = this.o_o.O0ooOo.().Select(value);
								for (int j = 0; j < array2.Length; j++)
								{
									array2[j]["System_Filter_Temporary"] = 1;
								}
								value = "[System_Filter_Temporary] = 1";
							}
							Oo00.o0_o._O_.(a_3);
							base.Filter = value;
						}
						base.Position = Math.Max(0, Math.Min(position, this.Count - 1));
						OO_00oOO.Tables[this.Oo._Oo0OO.()].foxGrid.O.O00O_oO_OO00.(true);
						goto IL_4D5;
					}
					catch (Exception a_4)
					{
						ooO.oOo0Oo.o.(a_4, "");
						goto IL_4D5;
					}
					finally
					{
						OO_00oOO.Tables[this.Oo._Oo0OO.()].ResumeRedraw();
						this.O00o0.0_0O_.(true);
						try
						{
							foreach (Table table2 in OO_00oOO.Tables)
							{
								if (table2.Name.StartsWith(this.Oo._Oo0OO.() + "."))
								{
									table2.ResumeRedraw();
									table2.View.O00o0.0_0O_.(true);
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
						if ((this.o_o.O0ooOo.() != null && this.o_o.O0ooOo.().Row != dataRow) || (this.o_o.O0ooOo.() == null && dataRow != null))
						{
							this.o_._0O0o_OoO.();
							try
							{
								foreach (Table table3 in OO_00oOO.Tables)
								{
									if (table3.Name.StartsWith(this.Oo._Oo0OO.() + "."))
									{
										table3.View.o_._0O0o_OoO.();
										table3.View.Oo._Oo0OO.();
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
						}
						if (base.Position != position)
						{
							this.Oo._Oo0OO.();
						}
					}
				}
				if (this.O0O_0_0__.0O.().o_o.O0ooOo.() == null)
				{
					base.Filter = "False";
				}
				else
				{
					DataRow row = this.O0O_0_0__.0O.().o_o.O0ooOo.().Row;
					string text = this.Oo._Oo0OO.(row, this.O0O_0_0__.0O.());
					if (Operators.CompareString(value, "", true) > 0)
					{
						text = text + " And " + value;
					}
					base.Filter = text;
				}
				IL_4D5:
				a_ = "AfterFilter";
				O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].o_0_00_.oo0O0., a_, new object[]
				{
					filterEventArgs
				}, false, this.o_o.O0ooOo.().TableName, false);
				if (OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].GlobalHandler.AfterFilter)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						filterEventArgs
					}, false, "全局表事件", false);
				}
			}
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x0012C6A4 File Offset: 0x0012A8A4
		internal bool <<EMPTY_NAME>>()
		{
			return this.oO0o0_.OoO_.;
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x0012C6AC File Offset: 0x0012A8AC
		private void <<EMPTY_NAME>>(bool A_0)
		{
			this.oO0o0_.OoO_. = A_0;
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x0012C6B8 File Offset: 0x0012A8B8
		private string <<EMPTY_NAME>>(DataRow A_0, DataRelation A_1)
		{
			string text = "";
			int num = A_1.ChildColumns.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(text, "", true) > 0)
				{
					text += " And ";
				}
				if (A_0.IsNull(A_1.ChildColumns[i]))
				{
					text = text + "[" + A_1.ParentColumns[i].ColumnName + "] is null";
				}
				else
				{
					string text2;
					if (A_1.ChildColumns[i].DataType == typeof(string))
					{
						text2 = "'";
					}
					else if (A_1.ChildColumns[i].DataType == typeof(DateTime))
					{
						text2 = "#";
					}
					else
					{
						text2 = "";
					}
					text = string.Concat(new string[]
					{
						text,
						"[",
						A_1.ParentColumns[i].ColumnName,
						"] = ",
						text2,
						A_0[A_1.ChildColumns[i]].ToString(),
						text2
					});
				}
			}
			return text;
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x0012C7D3 File Offset: 0x0012A9D3
		public string <<EMPTY_NAME>>()
		{
			return this.Oo0_.O.;
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x0012C7DB File Offset: 0x0012A9DB
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.Oo0_.O. = A_0;
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x0012C7E4 File Offset: 0x0012A9E4
		public string <<EMPTY_NAME>>()
		{
			string result;
			if (this.OO.___OO0O.())
			{
				result = this.o_._0O0o_OoO.();
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x0012C80C File Offset: 0x0012AA0C
		public void <<EMPTY_NAME>>(string A_0)
		{
			if (this.o_o.O0ooOo.() != null && this.o_o.O0ooOo.().IsEdit)
			{
				this.o_o.O0ooOo.().EndEdit();
			}
			SortEventArgs sortEventArgs = new SortEventArgs(OO_00oOO.Tables[this.Oo._Oo0OO.()], A_0);
			string a_ = "BeforeSort";
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].o_0_00_.oo0O0., a_, new object[]
			{
				sortEventArgs
			}, false, this.o_o.O0ooOo.().TableName, false);
			if (!sortEventArgs.Cancel && OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].GlobalHandler.BeforeSort)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					sortEventArgs
				}, false, "全局表事件", false);
			}
			if (!sortEventArgs.Cancel)
			{
				OO_00oOO.Tables[this.Oo._Oo0OO.()].ClearCheckedRows();
				OO_00oOO.Tables[this.Oo._Oo0OO.()].o.oO000Ooo_.();
				if (Operators.CompareString(sortEventArgs.Sort, "", true) > 0)
				{
					this.o_O_.00o.(sortEventArgs.Sort);
				}
				A_0 = sortEventArgs.Sort;
				this.o_o00.0_o0.(Operators.CompareString(A_0, "", true) > 0);
				if (Operators.CompareString(A_0, "", true) == 0)
				{
					this.O00o0.0_0O_.();
					OO_00oOO.Tables[this.Oo._Oo0OO.()].foxGrid.O.O00O_oO_OO00.(true);
				}
				else if (this.O0O.o__0.() || this.O.o_OOOo_OoO.() || this.O0OOO_0.o.() || Operators.CompareString(A_0.Trim(new char[]
				{
					'[',
					']'
				}), "System_Sort_Temporary", true) == 0)
				{
					base.Sort = A_0;
					OO_00oOO.Tables[this.Oo._Oo0OO.()].foxGrid.O.O00O_oO_OO00.(true);
				}
				else
				{
					string filter = base.Filter;
					int position = base.Position;
					DataRow dataRow = null;
					if (this.o_o.O0ooOo.() != null)
					{
						dataRow = this.o_o.O0ooOo.().Row;
					}
					DataRow[] array = this.o_o.O0ooOo.().Select(this.oo_0._o.(), A_0);
					try
					{
						this.O00o0.0_0O_.(false);
						try
						{
							foreach (Table table in OO_00oOO.Tables)
							{
								if (table.Name.StartsWith(this.Oo._Oo0OO.() + "."))
								{
									table.View.O00o0.0_0O_.(false);
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
						OO_00oOO.Tables[this.Oo._Oo0OO.()].StopRedraw();
						base.Filter = "False";
						Dictionary<DataColumn, string> a_2 = Oo00.ooO.ooo.(this.o_o.O0ooOo.());
						int num = array.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							array[i]["System_Sort_Temporary"] = i;
						}
						Oo00.o0_o._O_.(a_2);
						base.Filter = filter;
						base.Sort = "[System_Sort_Temporary]," + this.o_._0O0o_OoO.();
						base.Position = Math.Max(0, Math.Min(position, this.Count - 1));
						OO_00oOO.Tables[this.Oo._Oo0OO.()].foxGrid.O.O00O_oO_OO00.(true);
					}
					catch (Exception a_3)
					{
						ooO.oOo0Oo.o.(a_3, "");
					}
					finally
					{
						OO_00oOO.Tables[this.Oo._Oo0OO.()].ResumeRedraw();
						this.O00o0.0_0O_.(true);
						try
						{
							foreach (Table table2 in OO_00oOO.Tables)
							{
								if (table2.Name.StartsWith(this.Oo._Oo0OO.() + "."))
								{
									table2.ResumeRedraw();
									table2.View.O00o0.0_0O_.(true);
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
						if ((this.o_o.O0ooOo.() != null && this.o_o.O0ooOo.().Row != dataRow) || (this.o_o.O0ooOo.() == null && dataRow != null))
						{
							this.o_._0O0o_OoO.();
							try
							{
								foreach (Table table3 in OO_00oOO.Tables)
								{
									if (table3.Name.StartsWith(this.Oo._Oo0OO.() + "."))
									{
										table3.View.o_._0O0o_OoO.();
										table3.View.Oo._Oo0OO.();
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
						}
						if (base.Position != position)
						{
							this.Oo._Oo0OO.();
						}
					}
				}
				a_ = "AfterSort";
				O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].o_0_00_.oo0O0., a_, new object[]
				{
					sortEventArgs
				}, false, this.o_o.O0ooOo.().TableName, false);
				if (OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].GlobalHandler.AfterSort)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						sortEventArgs
					}, false, "全局表事件", false);
				}
			}
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x0012CD68 File Offset: 0x0012AF68
		internal bool <<EMPTY_NAME>>()
		{
			return this.O00o000.0000.;
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x0012CD70 File Offset: 0x0012AF70
		private void <<EMPTY_NAME>>(bool A_0)
		{
			this.O00o000.0000. = A_0;
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x0012CD7C File Offset: 0x0012AF7C
		internal DataRowView <<EMPTY_NAME>>(int A_0)
		{
			DataRowView result;
			if (A_0 < 0 || A_0 > base.List.Count - 1)
			{
				result = null;
			}
			else
			{
				result = (DataRowView)base.List[A_0];
			}
			return result;
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x0012CDB4 File Offset: 0x0012AFB4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if ((this.O0O_0_0__.0O.() & OO_00oOO.SystemReady) && OO_00oOO.Tables.get_Contains(this.Oo._Oo0OO.()) && base.List != null && O_O0OO.OOOo.oo_OOOO_0.() != null && O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(this.o_o.O0ooOo.().TableName) && O_O0OO.OOOo.oo_OOOO_0.().Tables[this.o_o.O0ooOo.().TableName] == this.o_o.O0ooOo.())
			{
				this.o_._0O0o_OoO.();
			}
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x0012CE34 File Offset: 0x0012B034
		internal void <<EMPTY_NAME>>()
		{
			if (!OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].IsDeletingRows)
			{
				Main.OO_O.o..O.ooO0. = true;
				TableEventArgs tableEventArgs = new TableEventArgs(OO_00oOO.Tables[this.Oo._Oo0OO.()]);
				string a_ = "CurrentChanged";
				if (OO_00oOO.Tables[this.Oo._Oo0OO.()].o0__OOo0._oO. == null)
				{
					O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].o_0_00_.oo0O0., a_, new object[]
					{
						tableEventArgs
					}, false, this.o_o.O0ooOo.().TableName, false);
				}
				else
				{
					O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Tables[this.Oo._Oo0OO.()].o0__OOo0._oO., a_, new object[]
					{
						tableEventArgs
					}, false, this.o_o.O0ooOo.().TableName, false);
				}
				if (OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].GlobalHandler.CurrentChanged)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						tableEventArgs
					}, false, "全局表事件", false);
				}
				a_ = "CurrentChanged_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, new object[]
				{
					tableEventArgs
				}, false, "菜单", false);
				try
				{
					foreach (O_0 o_ in O_O0OO.o__.O.().Values)
					{
						if (o_.O0O_0_0__.0O.() == this && o_.O0OOO_0.o.())
						{
							o_.set_Filter(o_.get_Filter());
						}
					}
				}
				finally
				{
					Dictionary<string, O_0>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x0012CFE8 File Offset: 0x0012B1E8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if ((this.O0O_0_0__.0O.() & OO_00oOO.SystemReady) && OO_00oOO.Tables.get_Contains(this.Oo._Oo0OO.()) && base.List != null && O_O0OO.OOOo.oo_OOOO_0.() != null && O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(this.o_o.O0ooOo.().TableName) && O_O0OO.OOOo.oo_OOOO_0.().Tables[this.o_o.O0ooOo.().TableName] == this.o_o.O0ooOo.())
			{
				this.Oo._Oo0OO.();
			}
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x0012D068 File Offset: 0x0012B268
		internal void <<EMPTY_NAME>>()
		{
			if (!OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].IsDeletingRows)
			{
				TableEventArgs tableEventArgs = new TableEventArgs(OO_00oOO.Tables[this.Oo._Oo0OO.()]);
				string a_ = "PositionChanged";
				if (OO_00oOO.Tables[this.Oo._Oo0OO.()].o0__OOo0._oO. == null)
				{
					O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].o_0_00_.oo0O0., a_, new object[]
					{
						tableEventArgs
					}, false, this.o_o.O0ooOo.().TableName, false);
				}
				else
				{
					O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Tables[this.Oo._Oo0OO.()].o0__OOo0._oO., a_, new object[]
					{
						tableEventArgs
					}, false, this.o_o.O0ooOo.().TableName, false);
				}
				if (OO_00oOO.DataTables[this.o_o.O0ooOo.().TableName].GlobalHandler.PositionChanged)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
					{
						tableEventArgs
					}, false, "全局表事件", false);
				}
				a_ = "PositionChanged_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, new object[]
				{
					tableEventArgs
				}, false, "菜单", false);
			}
		}

		// Token: 0x0400117A RID: 4474
		private O_0 <<EMPTY_NAME>>;

		// Token: 0x0400117B RID: 4475
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400117C RID: 4476
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400117D RID: 4477
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400117E RID: 4478
		private string <<EMPTY_NAME>>;

		// Token: 0x0400117F RID: 4479
		private DataView <<EMPTY_NAME>>;

		// Token: 0x04001180 RID: 4480
		private DataRelation <<EMPTY_NAME>>;

		// Token: 0x04001181 RID: 4481
		private string <<EMPTY_NAME>>;

		// Token: 0x04001182 RID: 4482
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001183 RID: 4483
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001184 RID: 4484
		private string <<EMPTY_NAME>>;

		// Token: 0x04001185 RID: 4485
		internal bool <<EMPTY_NAME>>;
	}
}
