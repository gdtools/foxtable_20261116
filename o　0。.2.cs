using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001A4 RID: 420
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class o\u30000\u3002\u3000\u3000\u3000 : Form
	{
		// Token: 0x060014AF RID: 5295 RVA: 0x00095D10 File Offset: 0x00093F10
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oOooooo.OO00. != null)
				{
					this.oOooooo.OO00..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00095D50 File Offset: 0x00093F50
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Oo__.o.(new Label());
			this.O_.O0o.(new C1ComboBox());
			this.oOO0OOo._OO.(new Label());
			this.oOO0OOo._OO.(new C1ComboBox());
			this.oOO0OOo._OO.(new C1Button());
			this.O_.O0o.(new C1Button());
			this.oOO0OOo._OO.(new C1CheckBox());
			base.SuspendLayout();
			this.oOO0OOo._OO.().AutoSize = true;
			this.oOO0OOo._OO.().Location = new Point(23, 56);
			this.oOO0OOo._OO.().Name = "Label2";
			this.oOO0OOo._OO.().Size = new Size(47, 12);
			this.oOO0OOo._OO.().TabIndex = 1;
			this.oOO0OOo._OO.().Text = "数据源:";
			this.Oo.0o_0__oOOo.().DropDownStyle = DropDownStyle.DropDownList;
			this.Oo.0o_0__oOOo.().Enabled = false;
			this.Oo.0o_0__oOOo.().Location = new Point(25, 77);
			this.Oo.0o_0__oOOo.().Name = "cmbDataSource";
			this.Oo.0o_0__oOOo.().Size = new Size(262, 20);
			this.Oo.0o_0__oOOo.().TabIndex = 2;
			this.O_.O0o.().AutoSize = true;
			this.O_.O0o.().Location = new Point(23, 113);
			this.O_.O0o.().Name = "Label10";
			this.O_.O0o.().Size = new Size(47, 12);
			this.O_.O0o.().TabIndex = 3;
			this.O_.O0o.().Text = "数据表:";
			this.oOO0OOo._OO.().DropDownStyle = DropDownStyle.DropDownList;
			this.oOO0OOo._OO.().Enabled = false;
			this.oOO0OOo._OO.().Location = new Point(25, 134);
			this.oOO0OOo._OO.().Name = "cmbDataTable";
			this.oOO0OOo._OO.().Size = new Size(262, 20);
			this.oOO0OOo._OO.().TabIndex = 4;
			this.O.OoOO_OO.().Location = new Point(67, 176);
			this.O.OoOO_OO.().Name = "btnOK";
			this.O.OoOO_OO.().Size = new Size(75, 23);
			this.O.OoOO_OO.().TabIndex = 5;
			this.O.OoOO_OO.().Text = "确定";
			this.O.OoOO_OO.().UseVisualStyleBackColor = true;
			this.Oo.0o_0__oOOo.().Location = new Point(158, 176);
			this.Oo.0o_0__oOOo.().Name = "btnCancel";
			this.Oo.0o_0__oOOo.().Size = new Size(75, 23);
			this.Oo.0o_0__oOOo.().TabIndex = 6;
			this.Oo.0o_0__oOOo.().Text = "取消";
			this.Oo.0o_0__oOOo.().UseVisualStyleBackColor = true;
			this.O.OoOO_OO.().AutoSize = true;
			this.O.OoOO_OO.().Location = new Point(25, 23);
			this.O.OoOO_OO.().Name = "CheckBox1";
			this.O.OoOO_OO.().Size = new Size(180, 16);
			this.O.OoOO_OO.().TabIndex = 0;
			this.O.OoOO_OO.().Text = "使用外部数据表存储用户信息";
			this.O.OoOO_OO.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(307, 211);
			base.Controls.Add(this.O.OoOO_OO.());
			base.Controls.Add(this.Oo.0o_0__oOOo.());
			base.Controls.Add(this.O.OoOO_OO.());
			base.Controls.Add(this.oOO0OOo._OO.());
			base.Controls.Add(this.Oo.0o_0__oOOo.());
			base.Controls.Add(this.O_.O0o.());
			base.Controls.Add(this.oOO0OOo._OO.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o..00o..";
			this.Text = "选择用户数据表";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00096149 File Offset: 0x00094349
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOooooo.OO00.;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00096151 File Offset: 0x00094351
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOooooo.OO00. = A_0;
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0009615A File Offset: 0x0009435A
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.oOooooo.OO00.;
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00096164 File Offset: 0x00094364
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O0ooo0._.);
			C1ComboBox c1ComboBox = this.oOooooo.OO00.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.oOooooo.OO00. = A_0;
			c1ComboBox = this.oOooooo.OO00.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000961A7 File Offset: 0x000943A7
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo__.o.;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x000961AF File Offset: 0x000943AF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo__.o. = A_0;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x000961B8 File Offset: 0x000943B8
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.Oo__.o.;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000961C0 File Offset: 0x000943C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.Oo__.o. = A_0;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x000961C9 File Offset: 0x000943C9
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOooooo.OO00.;
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000961D4 File Offset: 0x000943D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo.0o_0__oOOo.);
			C1Button c1Button = this.oOooooo.OO00.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOooooo.OO00. = A_0;
			c1Button = this.oOooooo.OO00.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00096217 File Offset: 0x00094417
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo__.o.;
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00096220 File Offset: 0x00094420
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.0O0_O00.);
			C1Button oo__.o. = this.Oo__.o.;
			if (oo__.o. != null)
			{
				oo__.o..Click -= value;
			}
			this.Oo__.o. = A_0;
			oo__.o. = this.Oo__.o.;
			if (oo__.o. != null)
			{
				oo__.o..Click += value;
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00096263 File Offset: 0x00094463
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.oOooooo.OO00.;
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0009626C File Offset: 0x0009446C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.O.OoOO_OO.);
			C1CheckBox c1CheckBox = this.oOooooo.OO00.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged -= value;
			}
			this.oOooooo.OO00. = A_0;
			c1CheckBox = this.oOooooo.OO00.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged += value;
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x000962B0 File Offset: 0x000944B0
		public o\u30000\u3002\u3000\u3000\u3000()
		{
			base.Load += this.oo_oOO._.;
			base.FormClosed += this.O.OoOO_OO.;
			this.OoO_O0o.O0__O. = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()];
			this.oOO0OOo._OO.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0009631C File Offset: 0x0009451C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.Oo.0o_0__oOOo.().ItemsDataSource = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()];
				IL_28:
				num2 = 3;
				this.Oo.0o_0__oOOo.().ItemsDisplayMember = "Name";
				IL_3A:
				num2 = 4;
				this.Oo.0o_0__oOOo.().TranslateValue = true;
				IL_48:
				num2 = 5;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.o.0_O_O.
				});
				IL_81:
				num2 = 6;
				if (dataRow == null || Operators.CompareString(dataRow["Config"].ToString(), "1", true) != 0)
				{
					goto IL_234;
				}
				IL_A9:
				num2 = 7;
				this.O.OoOO_OO.().Checked = true;
				IL_B7:
				num2 = 8;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.Oo0_.o0.
				});
				IL_F0:
				num2 = 9;
				if (dataRow == null)
				{
					goto IL_17E;
				}
				IL_F9:
				num2 = 10;
				string right = dataRow["Config"].ToString();
				IL_10E:
				num2 = 11;
				int num3 = this.Oo.0o_0__oOOo.().Items.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_12A:
					num2 = 12;
					if (Operators.CompareString(((DataRowView)this.Oo.0o_0__oOOo.().Items[i])["Name"].ToString(), right, true) == 0)
					{
						IL_15D:
						num2 = 13;
						this.Oo.0o_0__oOOo.().SelectedIndex = i;
						break;
					}
					IL_16F:
					num2 = 15;
				}
				IL_17E:
				num2 = 16;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.OO_O.O0ooO0O.
				});
				IL_1B8:
				num2 = 17;
				if (dataRow == null)
				{
					goto IL_234;
				}
				IL_1BE:
				num2 = 18;
				string right2 = dataRow["Config"].ToString();
				IL_1D3:
				num2 = 19;
				int num4 = this.oOO0OOo._OO.().Items.Count - 1;
				for (int j = 0; j <= num4; j++)
				{
					IL_1EF:
					num2 = 20;
					if (Operators.CompareString(this.oOO0OOo._OO.().Items[j].ToString(), right2, true) == 0)
					{
						IL_213:
						num2 = 21;
						this.oOO0OOo._OO.().SelectedIndex = j;
						break;
					}
					IL_225:
					num2 = 23;
				}
				IL_234:
				goto IL_2E6;
				IL_239:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_2A7:
				goto IL_2DB;
				IL_2A9:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2B9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2A9;
			}
			IL_2DB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2E6:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00096634 File Offset: 0x00094834
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Oo.0o_0__oOOo.().SelectedItem == null)
			{
				this.oOO0OOo._OO.().Items.Clear();
				return;
			}
			DataRow row = ((DataRowView)this.Oo.0o_0__oOOo.().SelectedItem).Row;
			this.oOO0OOo._OO.().Items.Clear();
			if (!row.IsNull("ConnectionString"))
			{
				try
				{
					List<string> list = (List<string>)OO_00oOO.Connections[Conversions.ToString(row["Name"])].GetTableNames();
					try
					{
						foreach (string value in list)
						{
							if (!base.Name.StartsWith("~"))
							{
								this.oOO0OOo._OO.().Items.Add(value);
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00096744 File Offset: 0x00094944
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00096750 File Offset: 0x00094950
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!this.O.OoOO_OO.().Checked || (Operators.CompareString(this.Oo.0o_0__oOOo.().Text, "", true) != 0 && Operators.CompareString(this.oOO0OOo._OO.().Text, "", true) != 0))
				{
					goto IL_60;
				}
				IL_46:
				num2 = 3;
				MessageBox.Show("请选择数据源和数据表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_6C4;
				IL_60:
				num2 = 5;
				if (!this.O.OoOO_OO.().Checked)
				{
					goto IL_5B9;
				}
				IL_72:
				num2 = 6;
				DataTable dataTable = new DataTable();
				IL_7A:
				num2 = 7;
				if (!O_O0OO.O._o_.().ContainsKey(this.Oo.0o_0__oOOo.().Text))
				{
					goto IL_15C;
				}
				IL_96:
				num2 = 8;
				this.oOooooo.OO00. = O_O0OO.O._o_.()[this.Oo.0o_0__oOOo.().Text];
				IL_B3:
				num2 = 9;
				string text = this.oOO0OOo._OO.().Text;
				IL_C3:
				num2 = 10;
				if (text.StartsWith("[") || text.EndsWith("]"))
				{
					goto IL_101;
				}
				IL_E2:
				num2 = 12;
				text = "[" + this.oOO0OOo._OO.().Text + "]";
				IL_101:
				num2 = 13;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From " + text, this.oOooooo.OO00.);
				IL_11D:
				num2 = 14;
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				IL_12A:
				num2 = 15;
				if (Information.Err().Number == 0 && dataTable != null)
				{
					goto IL_1A0;
				}
				IL_13C:
				num2 = 16;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_6C4;
				IL_15C:
				num2 = 19;
				if (!O_O0OO.OoO__.0oO0oo.().ContainsKey(this.Oo.0o_0__oOOo.().Text))
				{
					goto IL_1A0;
				}
				IL_176:
				num2 = 20;
				dataTable = O_O0OO.OoO__.0oO0oo.()[this.Oo.0o_0__oOOo.().Text].O_0_O_0_o_.0.(this.oOO0OOo._OO.().Text, false);
				IL_1A0:
				num2 = 21;
				if (!dataTable.Columns.Contains("Name") || !dataTable.Columns.Contains("Type") || !dataTable.Columns.Contains("Config"))
				{
					goto IL_59E;
				}
				IL_1E2:
				num2 = 22;
				if (dataTable.PrimaryKey.Length != 1 || ((dataTable.PrimaryKey[0].DataType != typeof(string) || Operators.CompareString(dataTable.PrimaryKey[0].ColumnName, "Name", true) != 0) && !dataTable.PrimaryKey[0].AutoIncrement))
				{
					goto IL_59E;
				}
				IL_238:
				num2 = 23;
				if (dataTable.Columns["Type"].DataType != typeof(int) && dataTable.Columns["Type"].DataType != typeof(short) && dataTable.Columns["Type"].DataType != typeof(long))
				{
					goto IL_59E;
				}
				IL_2A1:
				num2 = 24;
				if (dataTable.Columns["Name"].DataType != typeof(string) || dataTable.Columns["Config"].DataType != typeof(string) || (dataTable.Columns["Config"].MaxLength != -1 && dataTable.Columns["Config"].MaxLength <= 255))
				{
					goto IL_59E;
				}
				IL_323:
				num2 = 25;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.o.0_O_O.
				});
				IL_35E:
				num2 = 26;
				if (dataRow != null)
				{
					goto IL_3D0;
				}
				IL_365:
				num2 = 27;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_383:
				num2 = 28;
				dataRow["Name"] = "User";
				IL_397:
				num2 = 29;
				dataRow["Type"] = o0_O.o.0_O_O.;
				IL_3AD:
				num2 = 30;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
				IL_3D0:
				num2 = 31;
				dataRow["Config"] = "1";
				IL_3E4:
				num2 = 32;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.Oo0_.o0.
				});
				IL_41F:
				num2 = 33;
				if (dataRow != null)
				{
					goto IL_491;
				}
				IL_426:
				num2 = 34;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_444:
				num2 = 35;
				dataRow["Name"] = "User";
				IL_458:
				num2 = 36;
				dataRow["Type"] = o0_O.Oo0_.o0.;
				IL_46E:
				num2 = 37;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
				IL_491:
				num2 = 38;
				dataRow["Config"] = this.Oo.0o_0__oOOo.().Text;
				IL_4AB:
				num2 = 39;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.OO_O.O0ooO0O.
				});
				IL_4E6:
				num2 = 40;
				if (dataRow != null)
				{
					goto IL_558;
				}
				IL_4ED:
				num2 = 41;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_50B:
				num2 = 42;
				dataRow["Name"] = "User";
				IL_51F:
				num2 = 43;
				dataRow["Type"] = o0_O.OO_O.O0ooO0O.;
				IL_535:
				num2 = 44;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
				IL_558:
				num2 = 45;
				dataRow["Config"] = this.oOO0OOo._OO.().Text;
				IL_572:
				num2 = 46;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_58F:
				num2 = 47;
				base.DialogResult = DialogResult.OK;
				goto IL_6C4;
				IL_59E:
				num2 = 49;
				MessageBox.Show("所有用户表的结构不符合规范！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_6C4;
				IL_5B9:
				num2 = 51;
				DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.o.0_O_O.
				});
				IL_5F4:
				num2 = 52;
				if (dataRow2 == null)
				{
					goto IL_605;
				}
				IL_5FB:
				num2 = 53;
				dataRow2.Delete();
				IL_605:
				num2 = 54;
				dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.Oo0_.o0.
				});
				IL_640:
				num2 = 55;
				if (dataRow2 == null)
				{
					goto IL_651;
				}
				IL_647:
				num2 = 56;
				dataRow2.Delete();
				IL_651:
				num2 = 57;
				dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.OO_O.O0ooO0O.
				});
				IL_68C:
				num2 = 58;
				if (dataRow2 == null)
				{
					goto IL_69D;
				}
				IL_693:
				num2 = 59;
				dataRow2.Delete();
				IL_69D:
				num2 = 60;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_6BA:
				num2 = 61;
				base.DialogResult = DialogResult.OK;
				IL_6C4:
				goto IL_80E;
				IL_6C9:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_7CF:
				goto IL_803;
				IL_7D1:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_7E1:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_7D1;
			}
			IL_803:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_80E:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00096F90 File Offset: 0x00095190
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Oo.0o_0__oOOo.().Enabled = this.O.OoOO_OO.().Checked;
			this.oOO0OOo._OO.().Enabled = this.O.OoOO_OO.().Checked;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00096FBE File Offset: 0x000951BE
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000830 RID: 2096
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000831 RID: 2097
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000832 RID: 2098
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000833 RID: 2099
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000834 RID: 2100
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000835 RID: 2101
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000836 RID: 2102
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000837 RID: 2103
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04000838 RID: 2104
		private OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x04000839 RID: 2105
		private DataTable <<EMPTY_NAME>>;
	}
}
