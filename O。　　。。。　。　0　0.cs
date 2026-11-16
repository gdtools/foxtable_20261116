using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000394 RID: 916
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u30000\u30000 : Form
	{
		// Token: 0x06003C02 RID: 15362 RVA: 0x001B3D08 File Offset: 0x001B1F08
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O00.OO_0_. != null)
				{
					this.O00.OO_0_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x001B3D48 File Offset: 0x001B1F48
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Ooo_.0__O_o_.(new Label());
			this.o_.0O0.(new C1Button());
			this.o_Ooo._Oooo_0.(new C1Button());
			this.o_oo0.o_.(new C1Button());
			this.O0._Oo.(new Label());
			this.Ooo_.0__O_o_.(new C1ComboBox());
			this.o0OOo0oo._O_.(new Label());
			this.Ooo_.0__O_o_.(new oO_oO000oo());
			((ISupportInitialize)this.O.O0000.()).BeginInit();
			((ISupportInitialize)this.O0.0O0.()).BeginInit();
			((ISupportInitialize)this.o_oo0.o_.()).BeginInit();
			((ISupportInitialize)this.o_oo0.o_.()).BeginInit();
			base.SuspendLayout();
			this.o_Ooo._Oooo_0.().AutoSize = true;
			this.o_Ooo._Oooo_0.().Location = new Point(14, 63);
			this.o_Ooo._Oooo_0.().Name = "Label2";
			this.o_Ooo._Oooo_0.().Size = new Size(95, 12);
			this.o_Ooo._Oooo_0.().TabIndex = 3;
			this.o_Ooo._Oooo_0.().Text = "请输入查询语句:";
			this.O.O0000.().Location = new Point(291, 353);
			this.O.O0000.().Name = "btnOk";
			this.O.O0000.().Size = new Size(75, 23);
			this.O.O0000.().TabIndex = 2;
			this.O.O0000.().Text = "确定";
			this.O.O0000.().UseVisualStyleBackColor = true;
			this.O0.0O0.().DialogResult = DialogResult.Cancel;
			this.O0.0O0.().Location = new Point(372, 353);
			this.O0.0O0.().Name = "btnCancel";
			this.O0.0O0.().Size = new Size(75, 23);
			this.O0.0O0.().TabIndex = 3;
			this.O0.0O0.().Text = "取消";
			this.O0.0O0.().UseVisualStyleBackColor = true;
			this.o_oo0.o_.().Location = new Point(12, 352);
			this.o_oo0.o_.().Name = "btnPreview";
			this.o_oo0.o_.().Size = new Size(75, 23);
			this.o_oo0.o_.().TabIndex = 4;
			this.o_oo0.o_.().Text = "预览";
			this.o_oo0.o_.().UseVisualStyleBackColor = true;
			this.o_oo0.o_.().AutoSize = true;
			this.o_oo0.o_.().Location = new Point(14, 13);
			this.o_oo0.o_.().Name = "Label1";
			this.o_oo0.o_.().Size = new Size(83, 12);
			this.o_oo0.o_.().TabIndex = 1;
			this.o_oo0.o_.().Text = "请选择数据源:";
			this.o_oo0.o_.().AllowSpinLoop = false;
			this.o_oo0.o_.().Cursor = Cursors.Arrow;
			this.o_oo0.o_.().DropDownStyle = DropDownStyle.DropDownList;
			this.o_oo0.o_.().GapHeight = 0;
			this.o_oo0.o_.().ImagePadding = new Padding(0, 0, 0, 0);
			this.o_oo0.o_.().ItemsDisplayMember = "";
			this.o_oo0.o_.().ItemsValueMember = "";
			this.o_oo0.o_.().Location = new Point(14, 34);
			this.o_oo0.o_.().Name = "cmbDataSource";
			this.o_oo0.o_.().Size = new Size(433, 19);
			this.o_oo0.o_.().TabIndex = 5;
			this.o_oo0.o_.().Tag = null;
			this.o_.0O0.().Location = new Point(12, 326);
			this.o_.0O0.().Name = "Label3";
			this.o_.0O0.().Size = new Size(410, 23);
			this.o_.0O0.().TabIndex = 14;
			this.o_.0O0.().Text = "提示：表的名称必须用大括号括起来，例如：Select * From {订单}";
			this.o_oo0.o_.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.o_oo0.o_.().Location = new Point(14, 84);
			this.o_oo0.o_.().Name = "txtSQL";
			this.o_oo0.o_.().Size = new Size(433, 230);
			this.o_oo0.o_.().TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(463, 387);
			base.Controls.Add(this.o_oo0.o_.());
			base.Controls.Add(this.o_.0O0.());
			base.Controls.Add(this.o_oo0.o_.());
			base.Controls.Add(this.o_oo0.o_.());
			base.Controls.Add(this.o_oo0.o_.());
			base.Controls.Add(this.O0.0O0.());
			base.Controls.Add(this.O.O0000.());
			base.Controls.Add(this.o_Ooo._Oooo_0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.oO0.O.O.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "查询表";
			((ISupportInitialize)this.O.O0000.()).EndInit();
			((ISupportInitialize)this.O0.0O0.()).EndInit();
			((ISupportInitialize)this.o_oo0.o_.()).EndInit();
			((ISupportInitialize)this.o_oo0.o_.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x001B4279 File Offset: 0x001B2479
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O00.OO_0_.;
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x001B4281 File Offset: 0x001B2481
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O00.OO_0_. = A_0;
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x001B428A File Offset: 0x001B248A
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Ooo_.0__O_o_.;
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x001B4294 File Offset: 0x001B2494
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0.0O0.);
			C1Button ooo_.0__O_o_. = this.Ooo_.0__O_o_.;
			if (ooo_.0__O_o_. != null)
			{
				ooo_.0__O_o_..Click -= value;
			}
			this.Ooo_.0__O_o_. = A_0;
			ooo_.0__O_o_. = this.Ooo_.0__O_o_.;
			if (ooo_.0__O_o_. != null)
			{
				ooo_.0__O_o_..Click += value;
			}
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x001B42D7 File Offset: 0x001B24D7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0OOo0oo._O_.;
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x001B42DF File Offset: 0x001B24DF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o0OOo0oo._O_. = A_0;
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x001B42E8 File Offset: 0x001B24E8
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0._Oo.;
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x001B42F0 File Offset: 0x001B24F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0_0.Ooo0.);
			C1Button o0._Oo. = this.O0._Oo.;
			if (o0._Oo. != null)
			{
				o0._Oo..Click -= value;
			}
			this.O0._Oo. = A_0;
			o0._Oo. = this.O0._Oo.;
			if (o0._Oo. != null)
			{
				o0._Oo..Click += value;
			}
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x001B4333 File Offset: 0x001B2533
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0OOo0oo._O_.;
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x001B433B File Offset: 0x001B253B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0OOo0oo._O_. = A_0;
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x001B4344 File Offset: 0x001B2544
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.Ooo_.0__O_o_.;
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x001B434C File Offset: 0x001B254C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.Ooo_.0__O_o_. = A_0;
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x001B4355 File Offset: 0x001B2555
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.Oo_o_0O_OO.;
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x001B435D File Offset: 0x001B255D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.Oo_o_0O_OO. = A_0;
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x001B4366 File Offset: 0x001B2566
		[CompilerGenerated]
		internal virtual oO_oO000oo <<EMPTY_NAME>>()
		{
			return this.O00.OO_0_.;
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x001B436E File Offset: 0x001B256E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(oO_oO000oo A_0)
		{
			this.O00.OO_0_. = A_0;
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x001B4378 File Offset: 0x001B2578
		public O\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u30000\u30000(DataRow A_0)
		{
			base.Load += this.O.O0000.;
			base.FormClosed += this.o0_0.Ooo0.;
			this.o_oo0.o_.();
			this.o_oo0.o_.().oO.O_oo_o_O.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.O00.OO_0_. = A_0;
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x001B43DC File Offset: 0x001B25DC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_oo0.o_.().Items.Add("内部数据源");
			try
			{
				foreach (object obj in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()].Rows)
				{
					DataRow dataRow = (DataRow)obj;
					this.o_oo0.o_.().Items.Add(Conversions.ToString(dataRow["Name"]));
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
			this.o_oo0.o_.().SelectedIndex = 0;
			if (this.O00.OO_0_..RowState != DataRowState.Detached)
			{
				if (!this.O00.OO_0_..IsNull("DataSource") && Operators.CompareString(Conversions.ToString(this.O00.OO_0_.["DataSource"]), "", true) > 0)
				{
					int num = this.o_oo0.o_.().Items.Count - 1;
					for (int i = 1; i <= num; i++)
					{
						if (Operators.CompareString(Conversions.ToString(this.o_oo0.o_.().Items[i]), Conversions.ToString(this.O00.OO_0_.["DataSource"]), true) == 0)
						{
							this.o_oo0.o_.().SelectedIndex = i;
						}
					}
				}
				if (!this.O00.OO_0_..IsNull("Property") && Operators.CompareString(Conversions.ToString(this.O00.OO_0_.["Property"]), "", true) > 0)
				{
					this.o_oo0.o_.().Text = Conversions.ToString(this.O00.OO_0_.["Property"]);
				}
				this.Text = this.Text + " - " + Conversions.ToString(this.O00.OO_0_.["Name"]);
				return;
			}
			this.Text += " - 新建";
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x001B45C8 File Offset: 0x001B27C8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.o_oo0.o_.().Text.Trim(), "", true) != 0)
			{
				DataTable dataTable = new DataTable();
				string text = this.o_oo0.o_.().Text;
				OleDbConnection oleDbConnection = null;
				HttpClient httpClient = null;
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.o_oo0.o_.().Text))
				{
					O0O o0O = O_O0OO.OoO__.0oO0oo.()[this.o_oo0.o_.().Text];
					text = Oo00.o0_o._O_.(o0O.OO.OoO0., text, false);
					dataTable = o0O.O_0_O_0_o_.0.(text, true);
					httpClient = o0O.oO0_0.o.();
					httpClient.Select = text;
					httpClient.FormData["Action"] = 2.ToString();
				}
				else
				{
					if (this.o_oo0.o_.().SelectedIndex == 0)
					{
						oleDbConnection = O_O0OO.OoO.0OO__0ooo.();
					}
					else
					{
						oleDbConnection = O_O0OO.O._o_.()[this.o_oo0.o_.().Text];
					}
					text = Oo00.o0_o._O_.(oleDbConnection, text, false);
					OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text, oleDbConnection);
					try
					{
						oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
						return;
					}
				}
				if (dataTable == null && dataTable.Columns.Count == 0)
				{
					MessageBox.Show("语句执行后没有返回数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (this.O00.OO_0_..RowState == DataRowState.Detached)
				{
					o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000("", "");
					o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(true);
					if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() == DialogResult.OK)
					{
						string text2 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
						string text3 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.();
						this.O00.OO_0_.["Name"] = text2;
						if (this.o_oo0.o_.().SelectedIndex > 0)
						{
							this.O00.OO_0_.["DataSource"] = this.o_oo0.o_.().Text;
						}
						this.O00.OO_0_.["Property"] = this.o_oo0.o_.().Text.Trim();
						O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows.Add(this.O00.OO_0_.);
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
						o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text, text2, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, "", true, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, null, this.o_oo0.o_.().Text, httpClient);
						if (!OO_00oOO.DataTables.Contains(text2))
						{
							return;
						}
						OO_00oOO.DataTables[text2].o.0O000_.();
						OO_00oOO.DataTables[text2].Caption = text3;
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[text2]);
						Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(this.O00.OO_0_.["Name"]), true, false);
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
						if (Operators.CompareString(text3, "", true) > 0 || O_O0OO.O0_00o.o0__o..DevelopByCreater)
						{
							OO_00oOO.DataTables[text2].Developer = OO_00oOO.User.Name;
							OO_00oOO.DataTables[text2].OO00_o.ooOO.(false);
						}
						O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
					}
				}
				else
				{
					string text4 = Conversions.ToString(this.O00.OO_0_.["Name"]);
					if (this.o_oo0.o_.().SelectedIndex == 0)
					{
						this.O00.OO_0_.["DataSource"] = DBNull.Value;
					}
					else
					{
						this.O00.OO_0_.["DataSource"] = this.o_oo0.o_.().Text;
					}
					this.O00.OO_0_.["Property"] = this.o_oo0.o_.().Text.Trim();
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
					if (OO_00oOO.DataTables.Contains(text4))
					{
						Oo00.o00O0O_.O.(this.O00.OO_0_., OO_00oOO.Tables[text4]);
					}
					else
					{
						o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text, text4, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, "", true, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, null, this.o_oo0.o_.().Text, httpClient);
						if (!OO_00oOO.DataTables.Contains(text4))
						{
							return;
						}
						OO_00oOO.DataTables[text4].o.0O000_.();
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[text4]);
						Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(this.O00.OO_0_.["Name"]), true, true);
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
					}
				}
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x001B4A8C File Offset: 0x001B2C8C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = this.o_oo0.o_.().Text.Trim();
			OleDbConnection a_ = null;
			O0O a_2 = null;
			if (this.o_oo0.o_.().SelectedIndex == 0)
			{
				a_ = O_O0OO.OoO.0OO__0ooo.();
			}
			else if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.o_oo0.o_.().Text))
			{
				a_2 = O_O0OO.OoO__.0oO0oo.()[this.o_oo0.o_.().Text];
			}
			else
			{
				a_ = O_O0OO.O._o_.()[this.o_oo0.o_.().Text];
			}
			if (Operators.CompareString(text, "", true) != 0)
			{
				new O_\u30000_\u3002O\u3002\u3002\u3000\u3000(a_, text, a_2).ShowDialog();
			}
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x001B4B24 File Offset: 0x001B2D24
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040018B6 RID: 6326
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040018B7 RID: 6327
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040018B8 RID: 6328
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018B9 RID: 6329
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018BA RID: 6330
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018BB RID: 6331
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040018BC RID: 6332
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040018BD RID: 6333
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040018BE RID: 6334
		[CompilerGenerated]
		private oO_oO000oo <<EMPTY_NAME>>;

		// Token: 0x040018BF RID: 6335
		private DataRow <<EMPTY_NAME>>;
	}
}
