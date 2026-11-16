using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.Syscmd;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000392 RID: 914
	[DesignerGenerated]
	internal partial class O\u3000\u3002\u3000\u3002\u3000\u3002 : System.Windows.Forms.Form
	{
		// Token: 0x06003BD7 RID: 15319 RVA: 0x001B2978 File Offset: 0x001B0B78
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.O._O_O. != null)
			{
				this.O._O_O..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x001B2998 File Offset: 0x001B0B98
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0._O.(new C1Button());
			this.ooO.Oo_ooo___.(new C1Button());
			this.o._O___.(new C1Button());
			this.OO_O.0OoO0.(new C1Button());
			this.Oo0_0o0.Ooo.(new C1Button());
			this.o0._O.(new System.Windows.Forms.ListBox());
			this.O_OO.0_0O0.(new C1Button());
			this.o0._O.(new oOOoo_0_0o_());
			((ISupportInitialize)this.OoO_o.oo00O.()).BeginInit();
			((ISupportInitialize)this.O000O0Oo0__.o.()).BeginInit();
			((ISupportInitialize)this.O__00_._o.()).BeginInit();
			((ISupportInitialize)this.O0._oo0O_0.()).BeginInit();
			((ISupportInitialize)this.O___O_._0o_O_O.()).BeginInit();
			((ISupportInitialize)this.OoOo.__OO__o0.()).BeginInit();
			base.SuspendLayout();
			this.OoO_o.oo00O.().Location = new Point(348, 401);
			this.OoO_o.oo00O.().Name = "btnClose";
			this.OoO_o.oo00O.().Size = new Size(75, 23);
			this.OoO_o.oo00O.().TabIndex = 19;
			this.OoO_o.oo00O.().Text = "关闭";
			this.OoO_o.oo00O.().UseVisualStyleBackColor = true;
			this.O000O0Oo0__.o.().Location = new Point(348, 105);
			this.O000O0Oo0__.o.().Name = "btnRename";
			this.O000O0Oo0__.o.().Size = new Size(75, 23);
			this.O000O0Oo0__.o.().TabIndex = 18;
			this.O000O0Oo0__.o.().Text = "重命名";
			this.O000O0Oo0__.o.().UseVisualStyleBackColor = true;
			this.O__00_._o.().Location = new Point(348, 74);
			this.O__00_._o.().Name = "btnDelete";
			this.O__00_._o.().Size = new Size(75, 23);
			this.O__00_._o.().TabIndex = 17;
			this.O__00_._o.().Text = "删除";
			this.O__00_._o.().UseVisualStyleBackColor = true;
			this.O0._oo0O_0.().Location = new Point(348, 43);
			this.O0._oo0O_0.().Name = "btnEdit";
			this.O0._oo0O_0.().Size = new Size(75, 23);
			this.O0._oo0O_0.().TabIndex = 16;
			this.O0._oo0O_0.().Text = "编辑";
			this.O0._oo0O_0.().UseVisualStyleBackColor = true;
			this.O___O_._0o_O_O.().Location = new Point(348, 12);
			this.O___O_._0o_O_O.().Name = "btnAdd";
			this.O___O_._0o_O_O.().Size = new Size(75, 23);
			this.O___O_._0o_O_O.().TabIndex = 15;
			this.O___O_._0o_O_O.().Text = "增加";
			this.O___O_._0o_O_O.().UseVisualStyleBackColor = true;
			this.O__00_._o.().DrawMode = DrawMode.OwnerDrawFixed;
			this.O__00_._o.().FormattingEnabled = true;
			this.O__00_._o.().IntegralHeight = false;
			this.O__00_._o.().ItemHeight = 15;
			this.O__00_._o.().Location = new Point(14, 12);
			this.O__00_._o.().Name = "lstTables";
			this.O__00_._o.().Size = new Size(315, 412);
			this.O__00_._o.().TabIndex = 14;
			this.OoOo.__OO__o0.().Location = new Point(348, 136);
			this.OoOo.__OO__o0.().Name = "btnFilter";
			this.OoOo.__OO__o0.().Size = new Size(75, 23);
			this.OoOo.__OO__o0.().TabIndex = 21;
			this.OoOo.__OO__o0.().Text = "查找";
			this.OoOo.__OO__o0.().UseVisualStyleBackColor = true;
			this.O__00_._o.().o0_OOo___o.0O.(500);
			this.O__00_._o.().Location = new Point(14, 435);
			this.O__00_._o.().Name = "SearchBox1";
			this.O__00_._o.().Size = new Size(315, 24);
			this.O__00_._o.().TabIndex = 20;
			this.O__00_._o.().Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(436, 436);
			base.Controls.Add(this.OoOo.__OO__o0.());
			base.Controls.Add(this.O__00_._o.());
			base.Controls.Add(this.OoO_o.oo00O.());
			base.Controls.Add(this.O000O0Oo0__.o.());
			base.Controls.Add(this.O__00_._o.());
			base.Controls.Add(this.O0._oo0O_0.());
			base.Controls.Add(this.O___O_._0o_O_O.());
			base.Controls.Add(this.O__00_._o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.o0O.0.OO.";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "外部表管理";
			((ISupportInitialize)this.OoO_o.oo00O.()).EndInit();
			((ISupportInitialize)this.O000O0Oo0__.o.()).EndInit();
			((ISupportInitialize)this.O__00_._o.()).EndInit();
			((ISupportInitialize)this.O0._oo0O_0.()).EndInit();
			((ISupportInitialize)this.O___O_._0o_O_O.()).EndInit();
			((ISupportInitialize)this.OoOo.__OO__o0.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x001B2EC1 File Offset: 0x001B10C1
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O._O_O.;
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x001B2ECC File Offset: 0x001B10CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO.0O0o_.);
			C1Button o._O_O. = this.O._O_O.;
			if (o._O_O. != null)
			{
				o._O_O..Click -= value;
			}
			this.O._O_O. = A_0;
			o._O_O. = this.O._O_O.;
			if (o._O_O. != null)
			{
				o._O_O..Click += value;
			}
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x001B2F0F File Offset: 0x001B110F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o000Oo.oo0_0.;
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x001B2F18 File Offset: 0x001B1118
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo_._0.);
			C1Button c1Button = this.o000Oo.oo0_0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o000Oo.oo0_0. = A_0;
			c1Button = this.o000Oo.oo0_0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x001B2F5B File Offset: 0x001B115B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo000_0.ooo0.;
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x001B2F64 File Offset: 0x001B1164
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo0oO00._o_00_.);
			C1Button c1Button = this.oo000_0.ooo0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo000_0.ooo0. = A_0;
			c1Button = this.oo000_0.ooo0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x001B2FA7 File Offset: 0x001B11A7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0OOo._0oO_O.;
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x001B2FB0 File Offset: 0x001B11B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_o.oo0_0.);
			C1Button c1Button = this.o0OOo._0oO_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0OOo._0oO_O. = A_0;
			c1Button = this.o0OOo._0oO_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x001B2FF3 File Offset: 0x001B11F3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOooO00o0.O_.;
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x001B2FFC File Offset: 0x001B11FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0O_00.0OO0.);
			C1Button ooooO00o0.O_. = this.OOooO00o0.O_.;
			if (ooooO00o0.O_. != null)
			{
				ooooO00o0.O_..Click -= value;
			}
			this.OOooO00o0.O_. = A_0;
			ooooO00o0.O_. = this.OOooO00o0.O_.;
			if (ooooO00o0.O_. != null)
			{
				ooooO00o0.O_..Click += value;
			}
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x001B303F File Offset: 0x001B123F
		[CompilerGenerated]
		internal virtual System.Windows.Forms.ListBox <<EMPTY_NAME>>()
		{
			return this.O._O_O.;
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x001B3048 File Offset: 0x001B1248
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.ListBox A_0)
		{
			DrawItemEventHandler value = new DrawItemEventHandler(this.O__00_._o.);
			System.Windows.Forms.ListBox o._O_O. = this.O._O_O.;
			if (o._O_O. != null)
			{
				o._O_O..DrawItem -= value;
			}
			this.O._O_O. = A_0;
			o._O_O. = this.O._O_O.;
			if (o._O_O. != null)
			{
				o._O_O..DrawItem += value;
			}
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x001B308B File Offset: 0x001B128B
		[CompilerGenerated]
		internal virtual oOOoo_0_0o_ <<EMPTY_NAME>>()
		{
			return this.O._O_O.;
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x001B3094 File Offset: 0x001B1294
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(oOOoo_0_0o_ A_0)
		{
			EventHandler a_ = new EventHandler(this.o0._O.);
			oOOoo_0_0o_ o._O_O. = this.O._O_O.;
			if (o._O_O. != null)
			{
				o._O_O..o0_OOo___o.0O.(a_);
			}
			this.O._O_O. = A_0;
			o._O_O. = this.O._O_O.;
			if (o._O_O. != null)
			{
				o._O_O..o.oOO_O.(a_);
			}
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x001B30D7 File Offset: 0x001B12D7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO_O0Oo.O_.;
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x001B30E0 File Offset: 0x001B12E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.ooOo0oo__0.);
			C1Button c1Button = this.oO_O0Oo.O_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO_O0Oo.O_. = A_0;
			c1Button = this.oO_O0Oo.O_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x001B3124 File Offset: 0x001B1324
		public O\u3000\u3002\u3000\u3002\u3000\u3002()
		{
			base.Load += this.OO.0__O0.;
			base.FormClosed += this.OoO.Oo.;
			this.O__00_._o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x001B3178 File Offset: 0x001B1378
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O__00_._o.().DataSource = new DataView(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], "[Type] = " + Conversions.ToString(0), "", DataViewRowState.CurrentRows);
			this.O__00_._o.().DisplayMember = "Name";
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x001B31D0 File Offset: 0x001B13D0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Foxtable.Syscmd.Table.OO__OO.0.())
			{
				if (this.O__00_._o.().Visible && Operators.CompareString(this.O__00_._o.().Text, "", true) > 0)
				{
					this.O__00_._o.().Text = "";
					this.O__00_._o.().O_o_.O0o00o__0.(EventArgs.Empty);
				}
				int count = this.O__00_._o.().Items.Count;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].NewRow();
				dataRow["Type"] = OtherTableTypeEnum.Table;
				new o\u3002\u30000_\u3002\u3002\u3002\u3002(dataRow).ShowDialog();
				if (this.O__00_._o.().Items.Count > count)
				{
					this.O__00_._o.().SelectedIndex = this.O__00_._o.().Items.Count - 1;
					OO_00oOO.MainTable = OO_00oOO.Tables[dataRow["Name"].ToString()];
				}
			}
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x001B32C4 File Offset: 0x001B14C4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O__00_._o.().SelectedItem != null)
			{
				DataRowView dataRowView = (DataRowView)this.O__00_._o.().SelectedItem;
				string text = Conversions.ToString(dataRowView["Name"]);
				if (Oo00.o0.__oO0_.(text))
				{
					try
					{
						IEnumerator<Foxtable.WinForm.Form> enumerator = OO_00oOO.Forms.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (Operators.CompareString(enumerator.Current.TableName, text, true) == 0)
							{
								MessageBox.Show("请在删除表之前，先删除此表的窗口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								return;
							}
						}
					}
					finally
					{
						IEnumerator<Foxtable.WinForm.Form> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					if (O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(text))
					{
						OO_00oOO.DataTables.OO0o00.0O_0o.(text, true);
						return;
					}
					dataRowView.Row.Delete();
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
					OO_00oOO.DataTables.OO0o00.0O_0o.(text);
				}
			}
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x001B33BC File Offset: 0x001B15BC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x001B33C4 File Offset: 0x001B15C4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O__00_._o.().SelectedItem != null)
			{
				DataRow row = ((DataRowView)this.O__00_._o.().SelectedItem).Row;
				if (Oo00.o0.__oO0_.(row["Name"].ToString()))
				{
					new o\u3002\u30000_\u3002\u3002\u3002\u3002(row).ShowDialog();
				}
			}
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x001B3418 File Offset: 0x001B1618
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O__00_._o.().SelectedItem != null)
			{
				DataRow row = ((DataRowView)this.O__00_._o.().SelectedItem).Row;
				string text = row["Name"].ToString();
				if (Oo00.o0.__oO0_.(text))
				{
					if (OO_00oOO.DataTables.Contains(text))
					{
						Foxtable.Syscmd.Table.OO.OO_0o.(OO_00oOO.DataTables[text]);
						return;
					}
					o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(text, "");
					if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() == DialogResult.OK)
					{
						row["Name"] = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
						Foxtable.Syscmd.Table.OO.OO_0o.(text, o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.());
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
					}
				}
			}
		}

		// Token: 0x06003BF0 RID: 15344 RVA: 0x001B34CE File Offset: 0x001B16CE
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x001B34E0 File Offset: 0x001B16E0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!this.O__00_._o.().Visible)
			{
				this.o0._O. = base.Height;
				base.Height = this.O__00_._o.().Bottom + 44;
				this.O__00_._o.().Visible = true;
				this.O__00_._o.().ooO00_0.0.().Select();
				return;
			}
			base.Height = this.o0._O.;
			this.O__00_._o.().Visible = false;
			this.O__00_._o.().Text = "";
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x001B3560 File Offset: 0x001B1760
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataView dataView = this.O__00_._o.().DataSource as DataView;
			if (string.IsNullOrWhiteSpace(this.O__00_._o.().Text))
			{
				dataView.RowFilter = "[Type] = " + Conversions.ToString(0);
				return;
			}
			dataView.RowFilter = "name like '%" + this.O__00_._o.().Text.Trim() + "%' And [Type] = " + Conversions.ToString(0);
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x001B35D4 File Offset: 0x001B17D4
		private void <<EMPTY_NAME>>(object A_0, DrawItemEventArgs A_1)
		{
			if (A_1.Index >= 0)
			{
				A_1.DrawBackground();
				A_1.DrawFocusRectangle();
				A_1.Graphics.DrawString(((DataRowView)this.O__00_._o.().Items[A_1.Index])[this.O__00_._o.().DisplayMember].ToString(), A_1.Font, new SolidBrush(A_1.ForeColor), A_1.Bounds, StringFormat.GenericDefault);
			}
		}

		// Token: 0x040018A5 RID: 6309
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040018A6 RID: 6310
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018A7 RID: 6311
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018A8 RID: 6312
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018A9 RID: 6313
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018AA RID: 6314
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018AB RID: 6315
		[CompilerGenerated]
		private System.Windows.Forms.ListBox <<EMPTY_NAME>>;

		// Token: 0x040018AC RID: 6316
		[CompilerGenerated]
		private oOOoo_0_0o_ <<EMPTY_NAME>>;

		// Token: 0x040018AD RID: 6317
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018AE RID: 6318
		private int <<EMPTY_NAME>>;
	}
}
