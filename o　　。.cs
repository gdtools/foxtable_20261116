using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000389 RID: 905
	[DesignerGenerated]
	internal partial class o\u3000\u3000\u3002\u3000\u3000 : Form
	{
		// Token: 0x06003AB6 RID: 15030 RVA: 0x001A6858 File Offset: 0x001A4A58
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.O_0__.O_ooo00O. != null)
			{
				this.O_0__.O_ooo00O..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x001A6878 File Offset: 0x001A4A78
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oO.o_.(new ListBox());
			this.O.__O0.(new C1Button());
			this.O.Oo_oo.(new C1Button());
			this.o.oO_0o_o.(new C1Button());
			this.oO.o_.(new C1Button());
			this.o00_o_OoO_o.O.(new C1Button());
			base.SuspendLayout();
			this.o00o.0oOoO_.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.o00o.0oOoO_.().FormattingEnabled = true;
			this.o00o.0oOoO_.().ItemHeight = 12;
			this.o00o.0oOoO_.().Location = new Point(12, 16);
			this.o00o.0oOoO_.().Name = "lstRelations";
			this.o00o.0oOoO_.().Size = new Size(308, 364);
			this.o00o.0oOoO_.().TabIndex = 0;
			this.O__.OOo0oo0o__.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O__.OOo0oo0o__.().Location = new Point(330, 16);
			this.O__.OOo0oo0o__.().Name = "btnAdd";
			this.O__.OOo0oo0o__.().Size = new Size(75, 23);
			this.O__.OOo0oo0o__.().TabIndex = 1;
			this.O__.OOo0oo0o__.().Text = "增加";
			this.O__.OOo0oo0o__.().UseVisualStyleBackColor = true;
			this.O0O00.__o_.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O0O00.__o_.().Location = new Point(330, 46);
			this.O0O00.__o_.().Name = "btnEdit";
			this.O0O00.__o_.().Size = new Size(75, 23);
			this.O0O00.__o_.().TabIndex = 2;
			this.O0O00.__o_.().Text = "编辑";
			this.O0O00.__o_.().UseVisualStyleBackColor = true;
			this.o00o.0oOoO_.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.o00o.0oOoO_.().Location = new Point(330, 75);
			this.o00o.0oOoO_.().Name = "btnDelete";
			this.o00o.0oOoO_.().Size = new Size(75, 23);
			this.o00o.0oOoO_.().TabIndex = 3;
			this.o00o.0oOoO_.().Text = "删除";
			this.o00o.0oOoO_.().UseVisualStyleBackColor = true;
			this.O.__O0.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O.__O0.().Location = new Point(330, 105);
			this.O.__O0.().Name = "btnRename";
			this.O.__O0.().Size = new Size(75, 23);
			this.O.__O0.().TabIndex = 5;
			this.O.__O0.().Text = "重命名";
			this.O.__O0.().UseVisualStyleBackColor = true;
			this.oO0oOOO.0__0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.oO0oOOO.0__0.().Location = new Point(330, 357);
			this.oO0oOOO.0__0.().Name = "btnClose";
			this.oO0oOOO.0__0.().Size = new Size(75, 23);
			this.oO0oOOO.0__0.().TabIndex = 7;
			this.oO0oOOO.0__0.().Text = "关闭";
			this.oO0oOOO.0__0.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(417, 397);
			base.Controls.Add(this.oO0oOOO.0__0.());
			base.Controls.Add(this.O.__O0.());
			base.Controls.Add(this.o00o.0oOoO_.());
			base.Controls.Add(this.O0O00.__o_.());
			base.Controls.Add(this.O__.OOo0oo0o__.());
			base.Controls.Add(this.o00o.0oOoO_.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o...Oo.o";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "表间关联";
			base.ResumeLayout(false);
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x001A6C47 File Offset: 0x001A4E47
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.O_0__.O_ooo00O.;
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x001A6C4F File Offset: 0x001A4E4F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.O_0__.O_ooo00O. = A_0;
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x001A6C58 File Offset: 0x001A4E58
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO.o_.;
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x001A6C60 File Offset: 0x001A4E60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0_o.O__o.);
			C1Button c1Button = this.oO.o_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO.o_. = A_0;
			c1Button = this.oO.o_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x001A6CA3 File Offset: 0x001A4EA3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o00_o_OoO_o.O.;
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x001A6CAC File Offset: 0x001A4EAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.__0o.);
			C1Button c1Button = this.o00_o_OoO_o.O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o00_o_OoO_o.O. = A_0;
			c1Button = this.o00_o_OoO_o.O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x001A6CEF File Offset: 0x001A4EEF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.Oo_oo.;
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x001A6CF8 File Offset: 0x001A4EF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo0.oO_OOoo.);
			C1Button o.Oo_oo. = this.O.Oo_oo.;
			if (o.Oo_oo. != null)
			{
				o.Oo_oo..Click -= value;
			}
			this.O.Oo_oo. = A_0;
			o.Oo_oo. = this.O.Oo_oo.;
			if (o.Oo_oo. != null)
			{
				o.Oo_oo..Click += value;
			}
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x001A6D3B File Offset: 0x001A4F3B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.oO_0o_o.;
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x001A6D44 File Offset: 0x001A4F44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.o0O_O0o0_O.);
			C1Button c1Button = this.o.oO_0o_o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.oO_0o_o. = A_0;
			c1Button = this.o.oO_0o_o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x001A6D87 File Offset: 0x001A4F87
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0.0_00_.;
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x001A6D90 File Offset: 0x001A4F90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO0oo0.O_OoOo_.);
			C1Button o0.0_00_. = this.O0.0_00_.;
			if (o0.0_00_. != null)
			{
				o0.0_00_..Click -= value;
			}
			this.O0.0_00_. = A_0;
			o0.0_00_. = this.O0.0_00_.;
			if (o0.0_00_. != null)
			{
				o0.0_00_..Click += value;
			}
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x001A6DD4 File Offset: 0x001A4FD4
		public o\u3000\u3000\u3002\u3000\u3000()
		{
			base.Load += this.O._0o__oo0Oo_o.;
			base.FormClosed += this.o00o.0oOoO_.;
			this.o00o.0oOoO_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x001A6E28 File Offset: 0x001A5028
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataTable dataSource = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()];
			this.o00o.0oOoO_.().DisplayMember = "Name";
			this.o00o.0oOoO_.().DataSource = dataSource;
			OO_00oOO.CurrentTable = OO_00oOO.MainTable;
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x001A6E70 File Offset: 0x001A5070
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()].NewRow();
			Form form = new O\u3000\u3000(dataRow);
			OO_00oOO.Forms.ooO0_o._o.();
			if (form.ShowDialog() == DialogResult.OK)
			{
				this.o00o.0oOoO_.().SelectedIndex = this.o00o.0oOoO_.().Items.Count - 1;
				o0OoOOoOOo0.OO0._Oo0o.(dataRow, O_O0OO.OOOo.oo_OOOO_0.());
				Oo00.o00O0O_.O.(Conversions.ToString(dataRow["Name"]), true, true);
			}
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x001A6EF0 File Offset: 0x001A50F0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OO_00oOO.Forms.ooO0_o._o.();
			if (this.o00o.0oOoO_.().SelectedItem != null)
			{
				DataRow row = ((DataRowView)this.o00o.0oOoO_.().SelectedItem).Row;
				string text = Conversions.ToString(row["Name"]);
				if (new O\u3000\u3000(row).ShowDialog() == DialogResult.OK)
				{
					if (O_O0OO.OOOo.oo_OOOO_0.().Relations.Contains(text))
					{
						Oo00.OO.0O0o.(text);
					}
					o0OoOOoOOo0.OO0._Oo0o.(row, O_O0OO.OOOo.oo_OOOO_0.());
					Oo00.o00O0O_.O.(text, true, true);
				}
			}
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x001A6F74 File Offset: 0x001A5174
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num4;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.o00o.0oOoO_.().SelectedItem == null)
				{
					goto IL_29E;
				}
				IL_19:
				num2 = 4;
				OO_00oOO.Forms.ooO0_o._o.();
				IL_25:
				num2 = 5;
				DataRowView dataRowView = (DataRowView)this.o00o.0oOoO_.().SelectedItem;
				IL_38:
				num2 = 6;
				string text = Conversions.ToString(dataRowView["Name"]);
				IL_4C:
				num2 = 7;
				if (!O_O0OO.OOOo.oo_OOOO_0.().Relations.Contains(text))
				{
					goto IL_273;
				}
				IL_64:
				num2 = 8;
				bool flag = false;
				IL_69:
				num2 = 9;
				string value = "Child(" + text + ").";
				IL_7F:
				num2 = 10;
				string value2 = "Child([" + text + "]).";
				IL_95:
				num2 = 11;
				string value3 = "Parent(" + text + ").";
				IL_AB:
				num2 = 12;
				string value4 = "Parent([" + text + "]).";
				IL_C1:
				num2 = 13;
				IEnumerator enumerator = O_O0OO.OOOo.oo_OOOO_0.().Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataTable dataTable = (DataTable)obj;
					IL_E8:
					num2 = 14;
					IEnumerator enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						object obj2 = enumerator2.Current;
						DataColumn dataColumn = (DataColumn)obj2;
						IL_10C:
						num2 = 15;
						if (Operators.CompareString(dataColumn.Expression, "", true) > 0)
						{
							IL_127:
							num2 = 16;
							string expression = dataColumn.Expression;
							IL_133:
							num2 = 17;
							if (expression.IndexOf(value, StringComparison.CurrentCultureIgnoreCase) >= 0 || expression.IndexOf(value2, StringComparison.CurrentCultureIgnoreCase) >= 0 || expression.IndexOf(value3, StringComparison.CurrentCultureIgnoreCase) >= 0 || expression.IndexOf(value4, StringComparison.CurrentCultureIgnoreCase) >= 0)
							{
								IL_16D:
								num2 = 18;
								if (!flag && MessageBox.Show("一些计算表达式引用了关联" + text + "，如果删除该关联，有关计算表达式将自动删除，确认要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
								{
									goto IL_29E;
								}
								IL_198:
								num2 = 21;
								flag = true;
								IL_19E:
								num2 = 22;
								dataColumn.Expression = string.Empty;
								IL_1AD:
								num2 = 23;
								DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
								{
									dataTable.TableName,
									dataColumn.ColumnName
								});
								IL_1EA:
								num2 = 24;
								dataRow["Expression"] = "";
							}
						}
						IL_1FE:
						num2 = 25;
					}
					IL_20D:
					num2 = 26;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
					IL_225:
					num2 = 27;
				}
				IL_234:
				num2 = 28;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_24C:
				num2 = 29;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
				IL_269:
				num2 = 30;
				Oo00.OO.0O0o.(text);
				IL_273:
				num2 = 31;
				dataRowView.Row.Delete();
				IL_281:
				num2 = 32;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()], true);
				IL_29E:
				goto IL_374;
				IL_2A3:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_335:
				goto IL_369;
				IL_337:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_347:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_337;
			}
			IL_369:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_374:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x001A731C File Offset: 0x001A551C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o00o.0oOoO_.().SelectedItem != null)
			{
				DataRow row = ((DataRowView)this.o00o.0oOoO_.().SelectedItem).Row;
				o\u3000\u3000 o_u3000_u = new o\u3000\u3000("重命名", "请输入关联名称:", Conversions.ToString(row["Name"]));
				o_u3000_u.Oo.__0o_0_Oo.(new o\u3000\u3000.ooOOO_O_Oo_0(Oo00.O0o._.));
				if (o_u3000_u.ShowDialog() == DialogResult.OK)
				{
					string text = Conversions.ToString(row["Name"]);
					if (Oo00.o0.__oO0_.(o_u3000_u.Value, O_O0OO.OOOo.oo_OOOO_0.().Relations[text].ParentTable, O_O0OO.OOOo.oo_OOOO_0.().Relations[text].ChildTable))
					{
						row["Name"] = o_u3000_u.Value;
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()], true);
						try
						{
							foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
							{
								DataRelation dataRelation = (DataRelation)obj;
								if (Operators.CompareString(dataRelation.RelationName, text, true) == 0)
								{
									dataRelation.RelationName = o_u3000_u.Value;
									string text2 = "Child(" + text + ").";
									string text3 = "Child([" + text + "]).";
									string newValue = "Child(" + dataRelation.RelationName + ").";
									string newValue2 = "Child([" + dataRelation.RelationName + "]).";
									try
									{
										foreach (object obj2 in dataRelation.ParentTable.Columns)
										{
											DataColumn dataColumn = (DataColumn)obj2;
											if (Operators.CompareString(dataColumn.Expression, "", true) > 0)
											{
												string text4 = dataColumn.Expression;
												if (text4.IndexOf(text2, StringComparison.CurrentCultureIgnoreCase) > 0 || text4.IndexOf(text3, StringComparison.CurrentCultureIgnoreCase) > 0)
												{
													text4 = ShareLibriay.ReplaceIgnoreCase(text4, text2, newValue);
													text4 = ShareLibriay.ReplaceIgnoreCase(text4, text3, newValue2);
													try
													{
														dataColumn.Expression = text4;
														DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
														{
															dataRelation.ParentTable.TableName,
															dataColumn.ColumnName
														});
														if (dataRow != null)
														{
															dataRow["Expression"] = text4;
														}
													}
													catch (Exception ex)
													{
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
									text2 = "Parent(" + text + ").";
									text3 = "Parent([" + text + "]).";
									newValue = "Parent(" + dataRelation.RelationName + ").";
									newValue2 = "Parent([" + dataRelation.RelationName + "]).";
									try
									{
										foreach (object obj3 in dataRelation.ChildTable.Columns)
										{
											DataColumn dataColumn2 = (DataColumn)obj3;
											if (Operators.CompareString(dataColumn2.Expression, "", true) > 0)
											{
												string text5 = dataColumn2.Expression;
												if (text5.IndexOf(text2, StringComparison.CurrentCultureIgnoreCase) >= 0 || text5.IndexOf(text3, StringComparison.CurrentCultureIgnoreCase) >= 0)
												{
													text5 = ShareLibriay.ReplaceIgnoreCase(text5, text2, newValue);
													text5 = ShareLibriay.ReplaceIgnoreCase(text5, text3, newValue2);
													try
													{
														dataColumn2.Expression = text5;
														DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
														{
															dataRelation.ChildTable.TableName,
															dataColumn2.ColumnName
														});
														if (dataRow2 != null)
														{
															dataRow2["Expression"] = text5;
														}
													}
													catch (Exception ex2)
													{
													}
												}
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
									Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
									try
									{
										foreach (Table table in OO_00oOO.Tables)
										{
											table.O.__O0o0.(true, false);
										}
										break;
									}
									finally
									{
										IEnumerator<Table> enumerator4;
										if (enumerator4 != null)
										{
											enumerator4.Dispose();
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
				}
			}
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x001A780C File Offset: 0x001A5A0C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Tables)
				{
					DataTable dataTable = (DataTable)obj;
					try
					{
						foreach (object obj2 in dataTable.Columns)
						{
							DataColumn dataColumn = (DataColumn)obj2;
							if (Operators.CompareString(dataColumn.Expression, "", true) > 0 && (dataColumn.Expression.IndexOf("parent", StringComparison.CurrentCultureIgnoreCase) >= 0 || dataColumn.Expression.IndexOf("child", StringComparison.CurrentCultureIgnoreCase) >= 0))
							{
								string expression = dataColumn.Expression;
								dataColumn.Expression = "";
								dataColumn.Expression = expression;
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
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x001A7910 File Offset: 0x001A5B10
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001818 RID: 6168
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001819 RID: 6169
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x0400181A RID: 6170
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400181B RID: 6171
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400181C RID: 6172
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400181D RID: 6173
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400181E RID: 6174
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
