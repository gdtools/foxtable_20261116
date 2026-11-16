using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using ADOX;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Foxtable.My;
using Foxtable.Syscmd;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200038D RID: 909
	[DesignerGenerated]
	internal partial class O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002 : Form
	{
		// Token: 0x06003B41 RID: 15169 RVA: 0x001AB784 File Offset: 0x001A9984
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_0.O_000_. != null)
				{
					this.O_0.O_000_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x001AB7C4 File Offset: 0x001A99C4
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0Oo0o0__o.Oo_.(new C1Button());
			this.OO.0O000o_O_0.(new C1Button());
			this.OO.0O000o_O_0.(new Label());
			this.o0Oo0o0__o.Oo_.(new Label());
			this.o0Oo0o0__o.Oo_.(new C1FlexGrid());
			((ISupportInitialize)this.o0Oo0o0__o.Oo_.()).BeginInit();
			base.SuspendLayout();
			this.OOo_O0_o._0.().Location = new Point(171, 337);
			this.OOo_O0_o._0.().Name = "btnOK";
			this.OOo_O0_o._0.().Size = new Size(75, 23);
			this.OOo_O0_o._0.().TabIndex = 1;
			this.OOo_O0_o._0.().Text = "确定";
			this.OOo_O0_o._0.().UseVisualStyleBackColor = true;
			this.OO.0O000o_O_0.().DialogResult = DialogResult.Cancel;
			this.OO.0O000o_O_0.().Location = new Point(266, 337);
			this.OO.0O000o_O_0.().Name = "Button2";
			this.OO.0O000o_O_0.().Size = new Size(75, 23);
			this.OO.0O000o_O_0.().TabIndex = 2;
			this.OO.0O000o_O_0.().Text = "取消";
			this.OO.0O000o_O_0.().UseVisualStyleBackColor = true;
			this.o0Oo0o0__o.Oo_.().AutoSize = true;
			this.o0Oo0o0__o.Oo_.().ForeColor = Color.Red;
			this.o0Oo0o0__o.Oo_.().Location = new Point(12, 285);
			this.o0Oo0o0__o.Oo_.().Name = "Label1";
			this.o0Oo0o0__o.Oo_.().Size = new Size(227, 12);
			this.o0Oo0o0__o.Oo_.().TabIndex = 3;
			this.o0Oo0o0__o.Oo_.().Text = "1、迁移前请备份自己的项目，以防万一。";
			this.OO.0O000o_O_0.().AutoSize = true;
			this.OO.0O000o_O_0.().ForeColor = Color.Red;
			this.OO.0O000o_O_0.().Location = new Point(12, 301);
			this.OO.0O000o_O_0.().Name = "Label2";
			this.OO.0O000o_O_0.().Size = new Size(263, 12);
			this.OO.0O000o_O_0.().TabIndex = 4;
			this.OO.0O000o_O_0.().Text = "2、内部表迁移到外部数据源后，会被自动删除。";
			this.o0Oo0o0__o.Oo_.().ColumnInfo = "10,0,0,0,0,0,Columns:";
			this.o0Oo0o0__o.Oo_.().Location = new Point(14, 12);
			this.o0Oo0o0__o.Oo_.().Name = "C1FlexGrid1";
			this.o0Oo0o0__o.Oo_.().Rows.DefaultSize = 19;
			this.o0Oo0o0__o.Oo_.().Size = new Size(485, 257);
			this.o0Oo0o0__o.Oo_.().TabIndex = 5;
			this.o0Oo0o0__o.Oo_.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(511, 372);
			base.Controls.Add(this.o0Oo0o0__o.Oo_.());
			base.Controls.Add(this.OO.0O000o_O_0.());
			base.Controls.Add(this.o0Oo0o0__o.Oo_.());
			base.Controls.Add(this.OO.0O000o_O_0.());
			base.Controls.Add(this.OOo_O0_o._0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.O.O...";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Redirect";
			((ISupportInitialize)this.o0Oo0o0__o.Oo_.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x001ABB33 File Offset: 0x001A9D33
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_0.O_000_.;
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x001ABB3C File Offset: 0x001A9D3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OOo_O0_o._0.);
			C1Button o_0.O_000_. = this.O_0.O_000_.;
			if (o_0.O_000_. != null)
			{
				o_0.O_000_..Click -= value;
			}
			this.O_0.O_000_. = A_0;
			o_0.O_000_. = this.O_0.O_000_.;
			if (o_0.O_000_. != null)
			{
				o_0.O_000_..Click += value;
			}
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x001ABB7F File Offset: 0x001A9D7F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO__.00000_o.;
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x001ABB87 File Offset: 0x001A9D87
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.OO__.00000_o. = A_0;
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x001ABB90 File Offset: 0x001A9D90
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_0.O_000_.;
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x001ABB98 File Offset: 0x001A9D98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_0.O_000_. = A_0;
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x001ABBA1 File Offset: 0x001A9DA1
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OO__.00000_o.;
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x001ABBA9 File Offset: 0x001A9DA9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OO__.00000_o. = A_0;
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x001ABBB2 File Offset: 0x001A9DB2
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O_0.O_000_.;
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x001ABBBC File Offset: 0x001A9DBC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.OOo_O0_o._0.);
			C1FlexGrid o_0.O_000_. = this.O_0.O_000_.;
			if (o_0.O_000_. != null)
			{
				o_0.O_000_..BeforeEdit -= value;
			}
			this.O_0.O_000_. = A_0;
			o_0.O_000_. = this.O_0.O_000_.;
			if (o_0.O_000_. != null)
			{
				o_0.O_000_..BeforeEdit += value;
			}
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x001ABC00 File Offset: 0x001A9E00
		public O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002()
		{
			base.FormClosed += this.OOo_O0_o._0.;
			this.O_0.O_000_. = new List<string>();
			int num2;
			int num5;
			object obj;
			try
			{
				IL_23:
				int num = 1;
				this.o0Oo0o0__o.Oo_.();
				IL_2B:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_42:
				num = 3;
				C1FlexGrid c1FlexGrid = this.o0Oo0o0__o.Oo_.();
				IL_4B:
				num = 4;
				c1FlexGrid.Styles.SelectedColumnHeader.Clear();
				IL_5D:
				num = 5;
				c1FlexGrid.Styles.Alternate.Clear();
				IL_6F:
				num = 6;
				c1FlexGrid.Styles.Focus.Clear();
				IL_81:
				num = 7;
				c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal);
				IL_9E:
				num = 8;
				c1FlexGrid.FocusRect = FocusRectEnum.Solid;
				IL_A7:
				num = 9;
				c1FlexGrid.AllowSorting = AllowSortingEnum.None;
				IL_B1:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_B8:
				num = 11;
				this.O_0.O_000_..Add("内部数据源");
				IL_CB:
				num = 12;
				this.O_0.O_000_. = new DataTable();
				IL_D9:
				num = 13;
				this.O_0.O_000_..Columns.Add("表", typeof(string));
				IL_FC:
				num = 14;
				this.O_0.O_000_..Columns.Add("数据源", typeof(string));
				IL_11F:
				num = 15;
				this.O_0.O_000_..Columns.Add("定向到", typeof(string));
				IL_142:
				num = 16;
				this.O_0.O_000_..Columns.Add("目标名称", typeof(string));
				IL_165:
				num = 17;
				IEnumerator<DataTable> enumerator = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataTable dataTable = enumerator.Current;
					IL_182:
					num = 18;
					if (dataTable.AllowRedirect)
					{
						IL_191:
						num = 20;
						if (!dataTable.frd_IsTemporary && !dataTable.AddByCode)
						{
							IL_1AC:
							num = 22;
							if (!o_O_o_oOoo__.OO0O_0.0O0o0_o.(dataTable.frd_Connection))
							{
								IL_1C0:
								num = 24;
								DataRow dataRow = this.O_0.O_000_..NewRow();
								IL_1D0:
								num = 25;
								dataRow["表"] = dataTable.Name;
								IL_1E6:
								num = 26;
								if (dataTable.frd_IsInnerTable || dataTable.frd_IsInnerQuery)
								{
									IL_1FB:
									num = 27;
									dataRow["数据源"] = this.O_0.O_000_.[0];
								}
								else
								{
									IL_218:
									num = 29;
									if (dataTable.frd_IsOuterTable || dataTable.frd_IsOuterQuery)
									{
										IL_22D:
										num = 30;
										Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator2 = O_O0OO.O._o_.().Keys.GetEnumerator();
										while (enumerator2.MoveNext())
										{
											string text = enumerator2.Current;
											IL_24C:
											num = 31;
											if (O_O0OO.O._o_.()[text] == dataTable.frd_Connection)
											{
												IL_264:
												num = 32;
												dataRow["数据源"] = text;
											}
											IL_275:
											num = 33;
										}
										IL_281:
										num = 34;
										((IDisposable)enumerator2).Dispose();
									}
								}
								IL_291:
								num = 35;
								this.O_0.O_000_..Rows.Add(dataRow);
							}
						}
					}
					IL_2A6:
					num = 36;
				}
				IL_2B5:
				num = 37;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_2C3:
				num = 38;
				C1FlexGrid c1FlexGrid2 = this.o0Oo0o0__o.Oo_.();
				IL_2CE:
				num = 39;
				c1FlexGrid2.DataSource = this.O_0.O_000_.;
				IL_2DE:
				num = 40;
				c1FlexGrid2.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
				IL_2F3:
				num = 41;
				int num3 = c1FlexGrid2.Cols.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_30B:
					num = 42;
					c1FlexGrid2.Cols[i].Width = this.o0Oo0o0__o.Oo_.().ClientSize.Width / 3 - 1;
					IL_339:
					num = 43;
				}
				IL_348:
				num = 44;
				c1FlexGrid2.ExtendLastCol = true;
				IL_353:
				c1FlexGrid2 = null;
				IL_356:
				num = 46;
				Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator3 = O_O0OO.O._o_.().Keys.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					string text2 = enumerator3.Current;
					IL_375:
					num = 47;
					if (!o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()[text2]))
					{
						IL_38B:
						num = 49;
						this.O_0.O_000_..Add(text2);
					}
					IL_39B:
					num = 50;
				}
				IL_3A7:
				num = 51;
				((IDisposable)enumerator3).Dispose();
				IL_3B7:
				num = 52;
				this.o0Oo0o0__o.Oo_.().Cols[0].AllowEditing = false;
				IL_3D1:
				num = 53;
				this.o0Oo0o0__o.Oo_.().Cols[1].AllowEditing = false;
				IL_3EB:
				num = 54;
				this.o0Oo0o0__o.Oo_.().Cols.Remove(3);
				IL_400:
				num = 55;
				this.o0Oo0o0__o.Oo_.().AutoGenerateColumns = false;
				IL_40F:
				num = 56;
				this.O_0.O_000_..Columns.Add("Mode", typeof(int));
				IL_432:
				goto IL_568;
				IL_437:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_529:
				goto IL_55D;
				IL_52B:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_53B:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_52B;
			}
			IL_55D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_568:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x001AC19C File Offset: 0x001AA39C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num6;
			object obj4;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				c.OOOOO.o.().FileSystem.CopyFile(OO_00oOO.ProjectFile, OO_00oOO.ProjectFile + ".bak", true);
				IL_2D:
				num2 = 3;
				OO_00oOO.Forms.ooO0_o._o.();
				IL_39:
				num2 = 4;
				Application.DoEvents();
				IL_40:
				num2 = 5;
				IEnumerator enumerator = this.O_0.O_000_..Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_65:
					num2 = 6;
					dataRow["Mode"] = DBNull.Value;
					IL_78:
					num2 = 7;
					if (!dataRow.IsNull("定向到") && Operators.CompareString(dataRow["定向到"].ToString(), "", true) > 0)
					{
						IL_AD:
						num2 = 8;
						if (Operators.CompareString(dataRow["定向到"].ToString(), dataRow["数据源"].ToString(), true) != 0)
						{
							IL_DC:
							num2 = 9;
							string a_ = dataRow["表"].ToString();
							IL_F2:
							num2 = 10;
							string text = "";
							IL_FC:
							num2 = 11;
							OleDbConnection a_2 = OO_00oOO.DataTables[a_].frd_Connection;
							IL_112:
							num2 = 12;
							OleDbConnection a_3;
							if (Operators.CompareString(dataRow["定向到"].ToString(), "内部数据源", true) == 0)
							{
								IL_133:
								num2 = 13;
								a_3 = O_O0OO.OoO.0OO__0ooo.();
							}
							else
							{
								IL_13F:
								num2 = 15;
								a_3 = O_O0OO.O._o_.()[dataRow["定向到"].ToString()];
							}
							IL_15F:
							num2 = 16;
							if (OO_00oOO.DataTables[a_].frd_IsOuterQuery || OO_00oOO.DataTables[a_].frd_IsInnerQuery)
							{
								IL_188:
								num2 = 17;
								dataRow["Mode"] = 2;
							}
							else
							{
								IL_19F:
								num2 = 19;
								int num3 = this.OOo_O0_o._0.(a_2, a_3, OO_00oOO.DataTables[a_], ref text);
								IL_1BC:
								num2 = 20;
								if (num3 == 0)
								{
									IL_C44:
									goto IL_F42;
								}
								IL_1C6:
								num2 = 23;
								dataRow["Mode"] = num3;
								IL_1DC:
								num2 = 24;
								if (Operators.CompareString(text, "", true) > 0)
								{
									IL_1EF:
									num2 = 25;
									dataRow["目标名称"] = text;
								}
							}
						}
					}
					IL_200:
					num2 = 26;
				}
				IL_20E:
				num2 = 27;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_224:
				num2 = 28;
				IEnumerator enumerator2 = this.O_0.O_000_..Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					DataRow dataRow2 = (DataRow)obj2;
					IL_24C:
					num2 = 29;
					if (!dataRow2.IsNull("Mode"))
					{
						IL_260:
						num2 = 31;
						string text2 = dataRow2["表"].ToString();
						IL_276:
						num2 = 32;
						int num4 = Conversions.ToInteger(dataRow2["Mode"]);
						IL_28C:
						num2 = 33;
						OleDbConnection oleDbConnection = OO_00oOO.DataTables[text2].frd_Connection;
						IL_2A2:
						num2 = 34;
						OleDbConnection oleDbConnection2;
						if (Operators.CompareString(dataRow2["定向到"].ToString(), "内部数据源", true) == 0)
						{
							IL_2C3:
							num2 = 35;
							oleDbConnection2 = O_O0OO.OoO.0OO__0ooo.();
						}
						else
						{
							IL_2CF:
							num2 = 37;
							oleDbConnection2 = O_O0OO.O._o_.()[dataRow2["定向到"].ToString()];
						}
						IL_2EF:
						num2 = 38;
						if (num4 == 1)
						{
							IL_2FA:
							num2 = 39;
							string selectCommandText;
							if (OO_00oOO.DataTables[text2].o._OOO0oOo0__..IndexOf("].[") > 0 && OO_00oOO.DataTables[text2].o._OOO0oOo0__..StartsWith("[") && OO_00oOO.DataTables[text2].o._OOO0oOo0__..EndsWith("]"))
							{
								IL_355:
								num2 = 40;
								selectCommandText = "Select * From " + OO_00oOO.DataTables[text2].o._OOO0oOo0__.;
							}
							else
							{
								IL_377:
								num2 = 42;
								selectCommandText = "Select * From [" + OO_00oOO.DataTables[text2].o._OOO0oOo0__..Trim(new char[]
								{
									'[',
									']'
								}) + "]";
							}
							IL_3B1:
							num2 = 43;
							DataTable dataTable = new DataTable();
							IL_3BB:
							num2 = 44;
							OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, oleDbConnection);
							IL_3C9:
							num2 = 45;
							oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
							IL_3D7:
							num2 = 46;
							Index index = new IndexClass();
							IL_3E1:
							num2 = 47;
							Catalog catalog = new CatalogClass();
							IL_3EB:
							num2 = 48;
							Connection connection = new ConnectionClass();
							IL_3F5:
							num2 = 49;
							bool flag = o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection2);
							IL_401:
							num2 = 50;
							connection.ConnectionString = oleDbConnection2.ConnectionString;
							IL_412:
							num2 = 51;
							ADOX.Table table = new TableClass();
							IL_41C:
							num2 = 52;
							connection.Open("", "", "", -1);
							IL_436:
							num2 = 53;
							catalog.ActiveConnection = connection;
							IL_442:
							num2 = 54;
							if (oleDbConnection2 == O_O0OO.OoO.0OO__0ooo.())
							{
								IL_44E:
								num2 = 55;
								table.Name = "~TMPCLP" + text2;
							}
							else
							{
								IL_466:
								num2 = 57;
								table.Name = text2;
							}
							IL_472:
							num2 = 58;
							table.ParentCatalog = catalog;
							IL_47E:
							num2 = 59;
							IEnumerator enumerator3 = dataTable.Columns.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								object obj3 = enumerator3.Current;
								DataColumn dataColumn = (DataColumn)obj3;
								IL_4A2:
								num2 = 60;
								string text3 = dataColumn.ColumnName;
								IL_4AE:
								num2 = 61;
								if (!o_O_o_oOoo__.oO.O_..Contains(text3))
								{
									IL_4BF:
									num2 = 62;
									if (flag)
									{
										IL_4C6:
										num2 = 63;
										text3 = "[" + text3 + "]";
									}
								}
								IL_4DC:
								num2 = 64;
								string name = dataColumn.DataType.Name;
								IL_4ED:
								num2 = 66;
								if (Operators.CompareString(name, "String", true) == 0)
								{
									IL_4FF:
									num2 = 67;
									if (dataColumn.MaxLength < 0 || dataColumn.MaxLength > 255)
									{
										IL_51A:
										num2 = 68;
										table.Columns.Append(text3, ADOX.DataTypeEnum.adLongVarWChar, 0);
										goto IL_710;
									}
									IL_536:
									num2 = 70;
									table.Columns.Append(text3, ADOX.DataTypeEnum.adVarWChar, dataColumn.MaxLength);
									goto IL_710;
								}
								else
								{
									IL_558:
									num2 = 72;
									if (Operators.CompareString(name, "DateTime", true) == 0)
									{
										IL_56A:
										num2 = 73;
										if (flag)
										{
											IL_571:
											num2 = 74;
											table.Columns.Append(text3, ADOX.DataTypeEnum.adDBTimeStamp, 0);
											goto IL_710;
										}
										IL_58D:
										num2 = 76;
										table.Columns.Append(text3, ADOX.DataTypeEnum.adDate, 0);
										goto IL_710;
									}
									else
									{
										IL_5A5:
										num2 = 78;
										if (Operators.CompareString(name, "Boolean", true) == 0)
										{
											IL_5B7:
											num2 = 79;
											table.Columns.Append(text3, ADOX.DataTypeEnum.adBoolean, 0);
											goto IL_710;
										}
										IL_5D0:
										num2 = 81;
										if (Operators.CompareString(name, "Double", true) == 0)
										{
											IL_5E2:
											num2 = 82;
											table.Columns.Append(text3, ADOX.DataTypeEnum.adDouble, 0);
											goto IL_710;
										}
										IL_5FA:
										num2 = 84;
										if (Operators.CompareString(name, "Single", true) == 0)
										{
											IL_60C:
											num2 = 85;
											table.Columns.Append(text3, ADOX.DataTypeEnum.adSingle, 0);
											goto IL_710;
										}
										IL_624:
										num2 = 87;
										if (Operators.CompareString(name, "Decimal", true) == 0)
										{
											IL_636:
											num2 = 88;
											table.Columns.Append(text3, ADOX.DataTypeEnum.adNumeric, 0);
											goto IL_710;
										}
										IL_652:
										num2 = 90;
										if (Operators.CompareString(name, "Int64", true) == 0)
										{
											IL_664:
											num2 = 91;
											if (flag)
											{
												IL_66B:
												num2 = 92;
												table.Columns.Append(text3, ADOX.DataTypeEnum.adBigInt, 0);
												goto IL_710;
											}
											IL_684:
											num2 = 94;
											table.Columns.Append(text3, ADOX.DataTypeEnum.adInteger, 0);
											goto IL_710;
										}
										else
										{
											IL_699:
											num2 = 96;
											if (Operators.CompareString(name, "Int32", true) == 0)
											{
												IL_6AB:
												num2 = 97;
												table.Columns.Append(text3, ADOX.DataTypeEnum.adInteger, 0);
												goto IL_710;
											}
											IL_6C0:
											num2 = 99;
											if (Operators.CompareString(name, "Int16", true) == 0)
											{
												IL_6D2:
												num2 = 100;
												table.Columns.Append(text3, ADOX.DataTypeEnum.adSmallInt, 0);
												goto IL_710;
											}
											IL_6E7:
											num2 = 102;
											if (Operators.CompareString(name, "Byte", true) == 0)
											{
												IL_6FC:
												num2 = 103;
												table.Columns.Append(text3, ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
												goto IL_710;
											}
										}
									}
								}
								IL_7C7:
								num2 = 114;
								continue;
								IL_710:
								num2 = 106;
								ADOX.Column column = table.Columns[text3];
								IL_723:
								num2 = 107;
								if (column.Type == ADOX.DataTypeEnum.adNumeric)
								{
									IL_734:
									num2 = 108;
									column.Precision = 28;
									IL_740:
									num2 = 109;
									column.NumericScale = 14;
									IL_74C:
									num2 = 110;
									if (OO_00oOO.DataTables[text2].DataCols.Contains(text3))
									{
										IL_769:
										num2 = 111;
										column.NumericScale = (byte)OO_00oOO.DataTables[text2].DataCols[text3].Decimals;
									}
								}
								IL_791:
								num2 = 112;
								if ((column.Type != ADOX.DataTypeEnum.adBoolean || o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection2)) && Operators.CompareString(column.Name, "_Identify", true) != 0)
								{
									IL_7BC:
									num2 = 113;
									column.Attributes = ColumnAttributesEnum.adColNullable;
									goto IL_7C7;
								}
								goto IL_7C7;
							}
							IL_7D6:
							num2 = 115;
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
							}
							IL_7EE:
							num2 = 116;
							if (oleDbConnection2 != O_O0OO.OoO.0OO__0ooo.())
							{
								IL_7FA:
								num2 = 117;
								table.Columns["_Identify"].Properties["AutoIncrement"].Value = true;
							}
							IL_828:
							num2 = 118;
							index.Name = text2 + "_PrimaryKey";
							IL_83E:
							num2 = 119;
							index.Columns.Append("_Identify", ADOX.DataTypeEnum.adVarWChar, 0);
							IL_858:
							num2 = 120;
							index.PrimaryKey = true;
							IL_863:
							num2 = 121;
							index.Unique = true;
							IL_86E:
							num2 = 122;
							table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
							IL_889:
							num2 = 123;
							catalog.Tables.Append(table);
							IL_89A:
							num2 = 124;
							connection.Close();
							IL_8A4:
							num2 = 125;
							catalog = null;
						}
						IL_8AA:
						num2 = 126;
						if (oleDbConnection == O_O0OO.OoO.0OO__0ooo.())
						{
							IL_8B9:
							num2 = 127;
							if (OO_00oOO.DataTables[text2].frd_IsInnerTable)
							{
								IL_8D2:
								num2 = 128;
								o_oo0 o_oo = new o_oo0(O_O0OO.OoO.0OO__0ooo.(), false, true);
								IL_8E6:
								num2 = 129;
								o_oo.o0_oo0._.().oooO__O_0o_.o_.(text2);
								IL_8FA:
								num2 = 130;
								o_oo.o0_oo0._.(false, false);
								IL_90A:
								num2 = 131;
								DataTable dataTable2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()];
								IL_926:
								num2 = 132;
								DataRow dataRow3 = dataTable2.NewRow();
								IL_935:
								num2 = 133;
								dataRow3["Name"] = text2;
								IL_949:
								num2 = 134;
								dataRow3["DataSource"] = dataRow2["定向到"].ToString();
								IL_96C:
								num2 = 135;
								dataRow3["Type"] = OtherTableTypeEnum.Table;
								IL_984:
								num2 = 136;
								OuterTableSetting outerTableSetting = new OuterTableSetting();
								IL_991:
								num2 = 137;
								if (!dataRow2.IsNull("目标名称"))
								{
									IL_9A5:
									num2 = 138;
									outerTableSetting.SourceTable = dataRow2["目标名称"].ToString();
								}
								else
								{
									IL_9C5:
									num2 = 140;
									outerTableSetting.SourceTable = text2;
								}
								IL_9D4:
								num2 = 141;
								dataRow3["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, false, '\v', false);
								IL_9F1:
								num2 = 142;
								dataTable2.Rows.Add(dataRow3);
								IL_A05:
								dataTable2 = null;
							}
							else
							{
								IL_A0D:
								num2 = 145;
								DataRow dataRow4 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows.Find(text2);
								IL_A35:
								num2 = 146;
								dataRow4["Type"] = OtherTableTypeEnum.Query;
								IL_A4D:
								num2 = 147;
								dataRow4["DataSource"] = dataRow2["定向到"].ToString();
							}
						}
						else
						{
							IL_A75:
							num2 = 149;
							DataRow dataRow5 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows.Find(text2);
							IL_A9D:
							num2 = 150;
							if (oleDbConnection2 == O_O0OO.OoO.0OO__0ooo.())
							{
								IL_AAC:
								num2 = 151;
								if (OO_00oOO.DataTables[text2].frd_IsOuterTable)
								{
									IL_AC5:
									num2 = 152;
									dataRow5.Delete();
								}
								else
								{
									IL_AD7:
									num2 = 154;
									dataRow5["Type"] = OtherTableTypeEnum.Query;
									IL_AEF:
									num2 = 155;
									dataRow5["DataSource"] = DBNull.Value;
								}
							}
							else
							{
								IL_B0B:
								num2 = 157;
								dataRow5["DataSource"] = dataRow2["定向到"].ToString();
								IL_B2E:
								num2 = 158;
								OuterTableSetting outerTableSetting2 = new OuterTableSetting();
								IL_B3B:
								num2 = 159;
								o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting2, dataRow5["property"].ToString(), '\v');
								IL_B5B:
								num2 = 160;
								if (!dataRow2.IsNull("目标名称"))
								{
									IL_B6F:
									num2 = 161;
									outerTableSetting2.SourceTable = dataRow2["目标名称"].ToString();
								}
								else
								{
									IL_B8F:
									num2 = 163;
									outerTableSetting2.SourceTable = text2;
								}
								IL_B9E:
								num2 = 164;
								dataRow5["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting2, false, '\v', false);
							}
						}
						IL_BBB:
						num2 = 165;
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
					}
					IL_BDB:
					num2 = 166;
				}
				IL_BED:
				num2 = 167;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_C08:
				num2 = 168;
				base.Close();
				IL_C14:
				num2 = 169;
				MessageBox.Show("定向结束，即将重新打开项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_C2D:
				num2 = 170;
				Project.Open(OO_00oOO.ProjectFile, new string[0]);
				goto IL_C44;
				IL_C49:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_F03:
				goto IL_F37;
				IL_F05:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_F15:;
			}
			catch when (endfilter(obj4 is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj5;
				goto IL_F05;
			}
			IL_F37:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_F42:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x001AD110 File Offset: 0x001AB310
		private int <<EMPTY_NAME>>(OleDbConnection A_0, OleDbConnection A_1, DataTable A_2, ref string A_3)
		{
			int num;
			int result;
			int num4;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				A_3 = "";
				IL_11:
				num2 = 3;
				A_1.Open();
				IL_19:
				num2 = 4;
				DataTable schema = A_1.GetSchema("Tables");
				IL_28:
				num2 = 5;
				A_1.Close();
				IL_30:
				num2 = 6;
				IEnumerator enumerator = schema.Rows.GetEnumerator();
				bool flag;
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_53:
					num2 = 7;
					if (A_1 == O_O0OO.OoO.0OO__0ooo.())
					{
						IL_60:
						num2 = 8;
						if ((dataRow["TABLE_NAME"].ToString().Length > 7 && Operators.CompareString(dataRow["TABLE_NAME"].ToString().Substring(7), A_2.Name, true) == 0) || Operators.CompareString(dataRow["TABLE_NAME"].ToString(), A_2.Name, true) == 0)
						{
							IL_C2:
							num2 = 9;
							MessageBox.Show("无法定向表\"" + A_2.Name + "，内部数据源存已经存在同名数据表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							IL_E8:
							num2 = 10;
							result = 0;
							goto IL_68D;
						}
					}
					else
					{
						IL_F2:
						num2 = 12;
						if (Operators.CompareString(dataRow["TABLE_NAME"].ToString(), A_2.Name, true) == 0)
						{
							IL_117:
							num2 = 13;
							if (Operators.CompareString(dataRow["TABLE_TYPE"].ToString(), "TABLE", true) != 0)
							{
								IL_138:
								num2 = 14;
								MessageBox.Show("无法定向表\"" + A_2.Name + "，目标外部数据源存在类型不匹配的同名表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								IL_15E:
								num2 = 15;
								result = 0;
								goto IL_68D;
							}
							IL_168:
							num2 = 16;
							flag = true;
							IL_16E:
							num2 = 17;
							if (dataRow.IsNull("TABLE_SCHEMA") || Operators.CompareString(dataRow["TABLE_SCHEMA"].ToString(), "dbo", true) == 0)
							{
								IL_19D:
								num2 = 18;
								A_3 = dataRow["TABLE_NAME"].ToString();
								break;
							}
							IL_1B6:
							num2 = 20;
							A_3 = string.Concat(new string[]
							{
								"[",
								dataRow["TABLE_SCHEMA"].ToString(),
								"].[",
								dataRow["TABLE_NAME"].ToString(),
								"]"
							});
							break;
						}
					}
					IL_209:
					num2 = 22;
					continue;
					IL_68D:
					goto IL_83F;
				}
				IL_218:
				num2 = 23;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_230:
				num2 = 24;
				if (A_2.o._OOO0oOo0__..IndexOf("].[") <= 0 || !A_2.o._OOO0oOo0__..StartsWith("[") || !A_2.o._OOO0oOo0__..EndsWith("]"))
				{
					goto IL_281;
				}
				IL_26A:
				num2 = 25;
				string selectCommandText = "Select * From " + A_2.o._OOO0oOo0__.;
				goto IL_2B0;
				IL_281:
				num2 = 27;
				selectCommandText = "Select * From [" + A_2.o._OOO0oOo0__..Trim(new char[]
				{
					'[',
					']'
				}) + "]";
				IL_2B0:
				num2 = 28;
				A_0.Open();
				IL_2B9:
				num2 = 29;
				DataTable dataTable = new DataTable();
				IL_2C3:
				num2 = 30;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, A_0);
				IL_2D0:
				num2 = 31;
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				IL_2DE:
				num2 = 32;
				A_0.Close();
				IL_2E7:
				num2 = 33;
				if (Information.Err().Number == 0)
				{
					goto IL_31B;
				}
				IL_2F6:
				num2 = 34;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_311:
				num2 = 35;
				result = 0;
				goto IL_68D;
				IL_31B:
				num2 = 36;
				if (A_0 == O_O0OO.OoO.0OO__0ooo.())
				{
					goto IL_40E;
				}
				IL_329:
				num2 = 37;
				if (dataTable.PrimaryKey.Length != 0)
				{
					goto IL_342;
				}
				IL_337:
				num2 = 38;
				bool flag2 = true;
				goto IL_3D7;
				IL_342:
				num2 = 40;
				DataColumn dataColumn = dataTable.PrimaryKey[0];
				IL_350:
				num2 = 41;
				if (dataTable.PrimaryKey.Length == 1 && Operators.CompareString(dataColumn.ColumnName, "_Identify", true) == 0 && (dataColumn.DataType == typeof(int) || dataColumn.DataType == typeof(long)) && dataTable.Columns.Contains("_Locked") && dataTable.Columns["_Locked"].DataType == typeof(bool))
				{
					goto IL_3D4;
				}
				IL_3CE:
				num2 = 42;
				flag2 = true;
				IL_3D4:
				dataColumn = null;
				IL_3D7:
				num2 = 44;
				if (!flag2)
				{
					goto IL_40E;
				}
				IL_3DE:
				num2 = 45;
				MessageBox.Show("无法定向表\"" + A_2.Name + "，没有找到可用的关键列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_404:
				num2 = 46;
				result = 0;
				goto IL_68D;
				IL_40E:
				num2 = 47;
				if (flag)
				{
					goto IL_41F;
				}
				IL_415:
				num2 = 48;
				result = 1;
				goto IL_68D;
				IL_41F:
				num2 = 50;
				A_1.Open();
				IL_428:
				num2 = 51;
				DataTable dataTable2 = new DataTable();
				IL_432:
				num2 = 52;
				OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("Select * from " + A_3, A_1);
				IL_44A:
				num2 = 53;
				bool flag3 = true;
				IL_450:
				num2 = 54;
				oleDbDataAdapter2.FillSchema(dataTable2, SchemaType.Source);
				IL_45E:
				num2 = 55;
				A_1.Close();
				IL_467:
				num2 = 56;
				if (Information.Err().Number == 0)
				{
					goto IL_49B;
				}
				IL_476:
				num2 = 57;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_491:
				num2 = 58;
				result = 0;
				goto IL_68D;
				IL_49B:
				num2 = 59;
				if (dataTable.Columns.Count != dataTable2.Columns.Count)
				{
					goto IL_596;
				}
				IL_4BB:
				num2 = 60;
				IEnumerator enumerator2 = dataTable.Columns.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					DataColumn dataColumn2 = (DataColumn)obj2;
					IL_4DF:
					num2 = 61;
					if (dataTable2.Columns.Contains(dataColumn2.ColumnName))
					{
						IL_4F7:
						num2 = 62;
						DataColumn dataColumn3 = dataTable2.Columns[dataColumn2.ColumnName];
						IL_50F:
						num2 = 63;
						if (dataColumn2.DataType != typeof(string) || dataColumn3.DataType != dataColumn2.GetType() || dataColumn3.MaxLength != dataColumn2.MaxLength)
						{
							IL_545:
							num2 = 65;
							if (dataColumn2.DataType != dataColumn3.DataType)
							{
								IL_558:
								num2 = 67;
								flag3 = false;
							}
						}
					}
					else
					{
						IL_560:
						num2 = 69;
						flag3 = false;
					}
					IL_566:
					num2 = 70;
					if (!flag3)
					{
						break;
					}
					IL_56D:
					num2 = 72;
				}
				IL_57C:
				num2 = 73;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
					goto IL_59C;
				}
				goto IL_59C;
				IL_596:
				num2 = 75;
				flag3 = false;
				IL_59C:
				num2 = 76;
				if (!flag3)
				{
					goto IL_654;
				}
				IL_5A6:
				num2 = 77;
				if (dataTable2.PrimaryKey.Length != 0)
				{
					goto IL_5BF;
				}
				IL_5B4:
				num2 = 78;
				flag3 = false;
				goto IL_654;
				IL_5BF:
				num2 = 80;
				DataColumn dataColumn4 = dataTable2.PrimaryKey[0];
				IL_5CD:
				num2 = 81;
				if (dataTable2.PrimaryKey.Length == 1 && Operators.CompareString(dataColumn4.ColumnName, "_Identify", true) == 0 && (dataColumn4.DataType == typeof(int) || dataColumn4.DataType == typeof(long)) && dataTable2.Columns.Contains("_Locked") && dataTable2.Columns["_Locked"].DataType == typeof(bool))
				{
					goto IL_651;
				}
				IL_64B:
				num2 = 82;
				flag3 = false;
				IL_651:
				dataColumn4 = null;
				IL_654:
				num2 = 84;
				if (flag3)
				{
					goto IL_688;
				}
				IL_65B:
				num2 = 85;
				MessageBox.Show("无法定向表\"" + A_2.Name + "，目标数据源存在结构或主键不匹配的同名表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_681:
				num2 = 86;
				result = 0;
				goto IL_68D;
				IL_688:
				num2 = 87;
				result = 2;
				goto IL_68D;
				IL_692:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_800:
				goto IL_834;
				IL_802:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_812:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_802;
			}
			IL_834:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_83F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x001AD984 File Offset: 0x001ABB84
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Col == 2)
			{
				string right = this.o0Oo0o0__o.Oo_.().GetData(A_1.Row, "数据源").ToString();
				string text = "";
				try
				{
					foreach (string text2 in this.O_0.O_000_.)
					{
						if (Operators.CompareString(text2, right, true) != 0)
						{
							text = text + "|" + text2;
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.o0Oo0o0__o.Oo_.().Cols[A_1.Col].ComboList = text;
				if (Operators.CompareString(text, "", true) == 0)
				{
					A_1.Cancel = true;
				}
			}
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x001ADA48 File Offset: 0x001ABC48
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400185C RID: 6236
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400185D RID: 6237
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400185E RID: 6238
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400185F RID: 6239
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001860 RID: 6240
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001861 RID: 6241
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001862 RID: 6242
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04001863 RID: 6243
		private List<string> <<EMPTY_NAME>>;
	}
}
