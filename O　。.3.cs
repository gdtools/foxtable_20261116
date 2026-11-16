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
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200038F RID: 911
	[DesignerGenerated]
	internal partial class O\u3000\u3002 : Form
	{
		// Token: 0x06003B66 RID: 15206 RVA: 0x001AE58E File Offset: 0x001AC78E
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.o0oo_o_0OOo_.O. != null)
			{
				this.o0oo_o_0OOo_.O..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x001AE5B0 File Offset: 0x001AC7B0
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o00o.o_o__.(new ListBox());
			this.o.0oo0__O_.(new C1Button());
			this.oo.0oOoo_O0O.(new C1Button());
			this.o00o.o_o__.(new C1Button());
			this.oOooo.O.(new C1Button());
			this.O.0_Oo_0.(new C1Button());
			base.SuspendLayout();
			this.oOO.00O0_00Oo.().FormattingEnabled = true;
			this.oOO.00O0_00Oo.().ItemHeight = 12;
			this.oOO.00O0_00Oo.().Location = new Point(14, 16);
			this.oOO.00O0_00Oo.().Name = "DataSourceList";
			this.oOO.00O0_00Oo.().Size = new Size(222, 280);
			this.oOO.00O0_00Oo.().TabIndex = 0;
			this.oo._O__.().Location = new Point(255, 16);
			this.oo._O__.().Name = "Add";
			this.oo._O__.().Size = new Size(75, 23);
			this.oo._O__.().TabIndex = 1;
			this.oo._O__.().Text = "增加";
			this.oo._O__.().UseVisualStyleBackColor = true;
			this.oOO.00O0_00Oo.().Location = new Point(255, 74);
			this.oOO.00O0_00Oo.().Name = "btnDelete";
			this.oOO.00O0_00Oo.().Size = new Size(75, 23);
			this.oOO.00O0_00Oo.().TabIndex = 3;
			this.oOO.00O0_00Oo.().Text = "删除";
			this.oOO.00O0_00Oo.().UseVisualStyleBackColor = true;
			this.O0_0_00o0O._OO.().Location = new Point(255, 273);
			this.O0_0_00o0O._OO.().Name = "btnClose";
			this.O0_0_00o0O._OO.().Size = new Size(75, 23);
			this.O0_0_00o0O._OO.().TabIndex = 5;
			this.O0_0_00o0O._OO.().Text = "关闭";
			this.O0_0_00o0O._OO.().UseVisualStyleBackColor = true;
			this.o_O0.o00.().Location = new Point(255, 45);
			this.o_O0.o00.().Name = "btnEdit";
			this.o_O0.o00.().Size = new Size(75, 23);
			this.o_O0.o00.().TabIndex = 2;
			this.o_O0.o00.().Text = "设置";
			this.o_O0.o00.().UseVisualStyleBackColor = true;
			this.oo_0__OOO__0.o.().Location = new Point(255, 103);
			this.oo_0__OOO__0.o.().Name = "Button1";
			this.oo_0__OOO__0.o.().Size = new Size(75, 23);
			this.oo_0__OOO__0.o.().TabIndex = 4;
			this.oo_0__OOO__0.o.().Text = "预览";
			this.oo_0__OOO__0.o.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(342, 311);
			base.Controls.Add(this.oo_0__OOO__0.o.());
			base.Controls.Add(this.o_O0.o00.());
			base.Controls.Add(this.O0_0_00o0O._OO.());
			base.Controls.Add(this.oOO.00O0_00Oo.());
			base.Controls.Add(this.oo._O__.());
			base.Controls.Add(this.oOO.00O0_00Oo.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Oo.....O";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "外部数据源";
			base.ResumeLayout(false);
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x001AE938 File Offset: 0x001ACB38
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.o0oo_o_0OOo_.O.;
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x001AE940 File Offset: 0x001ACB40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.o0oo_o_0OOo_.O. = A_0;
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x001AE949 File Offset: 0x001ACB49
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o00o.o_o__.;
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x001AE954 File Offset: 0x001ACB54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0.oo0o.);
			C1Button c1Button = this.o00o.o_o__.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o00o.o_o__. = A_0;
			c1Button = this.o00o.o_o__.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x001AE997 File Offset: 0x001ACB97
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo.0oOoo_O0O.;
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x001AE9A0 File Offset: 0x001ACBA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0_0_00o0O._OO.);
			C1Button c1Button = this.oo.0oOoo_O0O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo.0oOoo_O0O. = A_0;
			c1Button = this.oo.0oOoo_O0O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x001AE9E3 File Offset: 0x001ACBE3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOooo.O.;
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x001AE9EC File Offset: 0x001ACBEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo_0__OOO__0.o.);
			C1Button c1Button = this.oOooo.O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOooo.O. = A_0;
			c1Button = this.oOooo.O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x001AEA2F File Offset: 0x001ACC2F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO0O_.o.;
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x001AEA38 File Offset: 0x001ACC38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo0_00O.0_.);
			C1Button c1Button = this.oO0O_.o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO0O_.o. = A_0;
			c1Button = this.oO0O_.o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x001AEA7B File Offset: 0x001ACC7B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_.___o_0.;
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x001AEA84 File Offset: 0x001ACC84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO.o_000o.);
			C1Button o_.___o_0. = this.O_.___o_0.;
			if (o_.___o_0. != null)
			{
				o_.___o_0..Click -= value;
			}
			this.O_.___o_0. = A_0;
			o_.___o_0. = this.O_.___o_0.;
			if (o_.___o_0. != null)
			{
				o_.___o_0..Click += value;
			}
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x001AEAC7 File Offset: 0x001ACCC7
		public O\u3000\u3002()
		{
			base.Load += this.o.000o000O0.;
			this.o00o.o_o__.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x001AEAFC File Offset: 0x001ACCFC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oOO.00O0_00Oo.().DataSource = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()];
			this.oOO.00O0_00Oo.().DisplayMember = "Name";
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x001AEB2D File Offset: 0x001ACD2D
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x001AEB38 File Offset: 0x001ACD38
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oOO.00O0_00Oo.().SelectedItem != null)
			{
				DataRow row = ((DataRowView)this.oOO.00O0_00Oo.().SelectedItem).Row;
				string right = Conversions.ToString(row["Name"]);
				bool flag;
				try
				{
					IEnumerator<DataTable> enumerator = OO_00oOO.DataTables.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(enumerator.Current.ConnectionName, right, true) == 0)
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
				if (row.GetChildRows("OuterDataSource").Length > 0)
				{
					flag = true;
				}
				if (flag)
				{
					MessageBox.Show("请在删除该数据源之前，先删除来自该数据源的外部表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (OO_00oOO.Connections.Contains(Conversions.ToString(row["Name"])))
				{
					OO_00oOO.Connections.Delete(Conversions.ToString(row["Name"]));
				}
				((DataRowView)this.oOO.00O0_00Oo.().SelectedItem).Delete();
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()], true);
			}
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x001AEC54 File Offset: 0x001ACE54
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (new O\u3002\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000\u3002(null)
			{
				Location = new Point(base.Left + 60, base.Top + 60),
				Text = "新建数据源"
			}.ShowDialog() == DialogResult.OK)
			{
				this.oOO.00O0_00Oo.().SelectedIndex = this.oOO.00O0_00Oo.().Items.Count - 1;
			}
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x001AECB4 File Offset: 0x001ACEB4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oOO.00O0_00Oo.().SelectedItem != null)
			{
				DataRow row = ((DataRowView)this.oOO.00O0_00Oo.().SelectedItem).Row;
				try
				{
					IEnumerator<DataTable> enumerator = OO_00oOO.DataTables.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(enumerator.Current.ConnectionName, Conversions.ToString(row["Name"]), true) == 0)
						{
							if (MessageBox.Show("因为已经载入该数据源中的表，修改数据源的设置会带来不可预知的后果，建议删除所有来自该数据源中的外部表，然后再修改该数据源；如果一定要现在修改，那么必须保证修改后的数据源包括所有已经加载的外部表，且表结构完全相同！\n确定要修改数据源吗?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
							{
								return;
							}
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
				O\u3002\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000\u3002 o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u = new O\u3002\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000\u3002(row);
				o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.Text = o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.Text + " - " + Conversions.ToString(row["Name"]);
				o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.OO.0O_.().Value = O00.oO_.0o_oo_0O_.(Conversions.ToString(row["ConnectionString"]), O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.());
				o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.Location = new Point(base.Left + 60, base.Top + 60);
				o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.ShowDialog();
				if (o_u3002_u3000_u3002_u3002_u3002_u3002_u3002_u3002_u3000_u3002_u3000_u.OO.o_000o.)
				{
					this.o0oo_o_0OOo_.O. = true;
				}
			}
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x001AEDE0 File Offset: 0x001ACFE0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oOO.00O0_00Oo.().SelectedIndex >= 0)
			{
				DataRow row = ((DataRowView)this.oOO.00O0_00Oo.().SelectedItem).Row;
				if (!row.IsNull("ConnectionString"))
				{
					string text = O00.oO_.0o_oo_0O_.(Conversions.ToString(row["ConnectionString"]), O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.());
					o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002 o_u3000_u3002_u3002_u3000_u3002_u3002_u3000_u3002_u3002_u;
					if (text.Trim().StartsWith("http://", StringComparison.OrdinalIgnoreCase) || text.Trim().StartsWith("https://", StringComparison.OrdinalIgnoreCase))
					{
						O0O a_ = new O0O(text);
						o_u3000_u3002_u3002_u3000_u3002_u3002_u3000_u3002_u3002_u = new o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002(null, a_, ((DataRowView)this.oOO.00O0_00Oo.().SelectedItem)["Name"].ToString());
					}
					else
					{
						OleDbConnection a_2 = new OleDbConnection(text);
						o_u3000_u3002_u3002_u3000_u3002_u3002_u3000_u3002_u3002_u = new o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002(a_2, null, ((DataRowView)this.oOO.00O0_00Oo.().SelectedItem)["Name"].ToString());
					}
					o_u3000_u3002_u3002_u3000_u3002_u3002_u3000_u3002_u3002_u.o.00_0_0.();
					if (o_u3000_u3002_u3002_u3000_u3002_u3002_u3000_u3002_u3002_u.O0O__O0oo_._.)
					{
						this.o0oo_o_0OOo_.O. = true;
					}
				}
			}
		}

		// Token: 0x0400186E RID: 6254
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400186F RID: 6255
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x04001870 RID: 6256
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001871 RID: 6257
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001872 RID: 6258
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001873 RID: 6259
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001874 RID: 6260
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001875 RID: 6261
		internal bool <<EMPTY_NAME>>;
	}
}
