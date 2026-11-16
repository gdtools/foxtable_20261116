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
	// Token: 0x02000387 RID: 903
	[DesignerGenerated]
	internal partial class o\u3002\u3000\u3002 : Form
	{
		// Token: 0x06003A7A RID: 14970 RVA: 0x001A3F30 File Offset: 0x001A2130
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oOo__.oO0. != null)
				{
					this.oOo__.oO0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x001A3F70 File Offset: 0x001A2170
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OoOo_o.0.(new Label());
			this.O0O.__O0.(new C1TextBox());
			this.o.o0o__o0_.(new RadioButton());
			this.o.OooOO.(new RadioButton());
			this.o.o0o__o0_.(new Label());
			this.O0.OO.(new C1TextBox());
			this.OoOo_o.0.(new C1Button());
			this.o.o0o__o0_.(new C1Button());
			this.o.OooOO.(new C1Button());
			this.OoOo_o.0.(new C1TextBox());
			this.o.OooOO.(new Label());
			((ISupportInitialize)this.oO.__0_OOO00.()).BeginInit();
			((ISupportInitialize)this.o0O.0O0O_0O_.()).BeginInit();
			((ISupportInitialize)this.oO.__0_OOO00.()).BeginInit();
			((ISupportInitialize)this.oo0o00O0oo0.O.()).BeginInit();
			((ISupportInitialize)this.O0OOoO_.__o_0.()).BeginInit();
			((ISupportInitialize)this.oo0o00O0oo0.O.()).BeginInit();
			base.SuspendLayout();
			this.oo0o00O0oo0.O.().AutoSize = true;
			this.oo0o00O0oo0.O.().Location = new Point(16, 30);
			this.oo0o00O0oo0.O.().Margin = new Padding(4, 0, 4, 0);
			this.oo0o00O0oo0.O.().Name = "Label1";
			this.oo0o00O0oo0.O.().Size = new Size(62, 18);
			this.oo0o00O0oo0.O.().TabIndex = 0;
			this.oo0o00O0oo0.O.().Text = "表名：";
			this.oO.__0_OOO00.().Location = new Point(16, 56);
			this.oO.__0_OOO00.().Margin = new Padding(4, 4, 4, 4);
			this.oO.__0_OOO00.().Name = "txtName";
			this.oO.__0_OOO00.().Size = new Size(346, 26);
			this.oO.__0_OOO00.().TabIndex = 0;
			this.oO.__0_OOO00.().Tag = null;
			this.o0O.0O0O_0O_.().AutoSize = true;
			this.o0O.0O0O_0O_.().Location = new Point(16, 216);
			this.o0O.0O0O_0O_.().Margin = new Padding(4, 4, 4, 4);
			this.o0O.0O0O_0O_.().Name = "RadioButton1";
			this.o0O.0O0O_0O_.().Size = new Size(105, 22);
			this.o0O.0O0O_0O_.().TabIndex = 4;
			this.o0O.0O0O_0O_.().Text = "包括数据";
			this.o0O.0O0O_0O_.().UseVisualStyleBackColor = true;
			this.oo0o00O0oo0.O.().AutoSize = true;
			this.oo0o00O0oo0.O.().Checked = true;
			this.oo0o00O0oo0.O.().Location = new Point(16, 183);
			this.oo0o00O0oo0.O.().Margin = new Padding(4, 4, 4, 4);
			this.oo0o00O0oo0.O.().Name = "rdoOnlyStructure";
			this.oo0o00O0oo0.O.().Size = new Size(123, 22);
			this.oo0o00O0oo0.O.().TabIndex = 3;
			this.oo0o00O0oo0.O.().TabStop = true;
			this.oo0o00O0oo0.O.().Text = "仅复制结构";
			this.oo0o00O0oo0.O.().UseVisualStyleBackColor = true;
			this.o0O.0O0O_0O_.().AutoSize = true;
			this.o0O.0O0O_0O_.().Location = new Point(16, 262);
			this.o0O.0O0O_0O_.().Margin = new Padding(4, 0, 4, 0);
			this.o0O.0O0O_0O_.().Name = "Label2";
			this.o0O.0O0O_0O_.().Size = new Size(98, 18);
			this.o0O.0O0O_0O_.().TabIndex = 5;
			this.o0O.0O0O_0O_.().Text = "复制条件：";
			this.o0O.0O0O_0O_.().BackColor = Color.White;
			this.o0O.0O0O_0O_.().Location = new Point(16, 288);
			this.o0O.0O0O_0O_.().Margin = new Padding(4, 4, 4, 4);
			this.o0O.0O0O_0O_.().Name = "txtExpression";
			this.o0O.0O0O_0O_.().ReadOnly = true;
			this.o0O.0O0O_0O_.().Size = new Size(506, 26);
			this.o0O.0O0O_0O_.().TabIndex = 6;
			this.o0O.0O0O_0O_.().Tag = null;
			this.oO.__0_OOO00.().Location = new Point(526, 288);
			this.oO.__0_OOO00.().Margin = new Padding(4, 4, 4, 4);
			this.oO.__0_OOO00.().Name = "Button1";
			this.oO.__0_OOO00.().Size = new Size(66, 28);
			this.oO.__0_OOO00.().TabIndex = 7;
			this.oO.__0_OOO00.().Text = "...";
			this.oO.__0_OOO00.().UseVisualStyleBackColor = true;
			this.oo0o00O0oo0.O.().Location = new Point(183, 351);
			this.oo0o00O0oo0.O.().Margin = new Padding(4, 4, 4, 4);
			this.oo0o00O0oo0.O.().Name = "btnOK";
			this.oo0o00O0oo0.O.().Size = new Size(112, 34);
			this.oo0o00O0oo0.O.().TabIndex = 8;
			this.oo0o00O0oo0.O.().Text = "确定";
			this.oo0o00O0oo0.O.().UseVisualStyleBackColor = true;
			this.O0OOoO_.__o_0.().DialogResult = DialogResult.Cancel;
			this.O0OOoO_.__o_0.().Location = new Point(320, 351);
			this.O0OOoO_.__o_0.().Margin = new Padding(4, 4, 4, 4);
			this.O0OOoO_.__o_0.().Name = "btnCancel";
			this.O0OOoO_.__o_0.().Size = new Size(112, 34);
			this.O0OOoO_.__o_0.().TabIndex = 9;
			this.O0OOoO_.__o_0.().Text = "取消";
			this.O0OOoO_.__o_0.().UseVisualStyleBackColor = true;
			this.oo0o00O0oo0.O.().Location = new Point(16, 128);
			this.oo0o00O0oo0.O.().Margin = new Padding(4, 4, 4, 4);
			this.oo0o00O0oo0.O.().Name = "txtCaption";
			this.oo0o00O0oo0.O.().Size = new Size(346, 26);
			this.oo0o00O0oo0.O.().TabIndex = 2;
			this.oo0o00O0oo0.O.().Tag = null;
			this.oO.__0_OOO00.().AutoSize = true;
			this.oO.__0_OOO00.().Location = new Point(16, 102);
			this.oO.__0_OOO00.().Margin = new Padding(4, 0, 4, 0);
			this.oO.__0_OOO00.().Name = "Label3";
			this.oO.__0_OOO00.().Size = new Size(62, 18);
			this.oO.__0_OOO00.().TabIndex = 1;
			this.oO.__0_OOO00.().Text = "标题：";
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(610, 393);
			base.Controls.Add(this.oo0o00O0oo0.O.());
			base.Controls.Add(this.oO.__0_OOO00.());
			base.Controls.Add(this.O0OOoO_.__o_0.());
			base.Controls.Add(this.oo0o00O0oo0.O.());
			base.Controls.Add(this.oO.__0_OOO00.());
			base.Controls.Add(this.o0O.0O0O_0O_.());
			base.Controls.Add(this.o0O.0O0O_0O_.());
			base.Controls.Add(this.oo0o00O0oo0.O.());
			base.Controls.Add(this.o0O.0O0O_0O_.());
			base.Controls.Add(this.oO.__0_OOO00.());
			base.Controls.Add(this.oo0o00O0oo0.O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(4, 4, 4, 4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o000._.1.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "复制表";
			((ISupportInitialize)this.oO.__0_OOO00.()).EndInit();
			((ISupportInitialize)this.o0O.0O0O_0O_.()).EndInit();
			((ISupportInitialize)this.oO.__0_OOO00.()).EndInit();
			((ISupportInitialize)this.oo0o00O0oo0.O.()).EndInit();
			((ISupportInitialize)this.O0OOoO_.__o_0.()).EndInit();
			((ISupportInitialize)this.oo0o00O0oo0.O.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x001A4710 File Offset: 0x001A2910
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0.OO.;
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x001A4718 File Offset: 0x001A2918
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0.OO. = A_0;
		}

		// Token: 0x06003A7E RID: 14974 RVA: 0x001A4721 File Offset: 0x001A2921
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oOo__.oO0.;
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x001A4729 File Offset: 0x001A2929
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oOo__.oO0. = A_0;
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x001A4732 File Offset: 0x001A2932
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O0.OO.;
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x001A473A File Offset: 0x001A293A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O0.OO. = A_0;
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x001A4743 File Offset: 0x001A2943
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O0O.__O0.;
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x001A474B File Offset: 0x001A294B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O0O.__O0. = A_0;
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x001A4754 File Offset: 0x001A2954
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0O.__O0.;
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x001A475C File Offset: 0x001A295C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0O.__O0. = A_0;
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x001A4765 File Offset: 0x001A2965
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oo_oO.o_0_.;
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x001A476D File Offset: 0x001A296D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oo_oO.o_0_. = A_0;
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x001A4776 File Offset: 0x001A2976
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0.OO.;
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x001A4780 File Offset: 0x001A2980
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0OOoO_.__o_0.);
			C1Button o0.OO. = this.O0.OO.;
			if (o0.OO. != null)
			{
				o0.OO..Click -= value;
			}
			this.O0.OO. = A_0;
			o0.OO. = this.O0.OO.;
			if (o0.OO. != null)
			{
				o0.OO..Click += value;
			}
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x001A47C3 File Offset: 0x001A29C3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0O.__O0.;
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x001A47CC File Offset: 0x001A29CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO_ooO.00o.);
			C1Button o0O.__O0. = this.O0O.__O0.;
			if (o0O.__O0. != null)
			{
				o0O.__O0..Click -= value;
			}
			this.O0O.__O0. = A_0;
			o0O.__O0. = this.O0O.__O0.;
			if (o0O.__O0. != null)
			{
				o0O.__O0..Click += value;
			}
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x001A480F File Offset: 0x001A2A0F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo0OoOo_o.0o_.;
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x001A4817 File Offset: 0x001A2A17
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oo0OoOo_o.0o_. = A_0;
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x001A4820 File Offset: 0x001A2A20
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O.0o_.;
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x001A4828 File Offset: 0x001A2A28
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O.0o_. = A_0;
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x001A4831 File Offset: 0x001A2A31
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo0OoOo_o.0o_.;
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x001A4839 File Offset: 0x001A2A39
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo0OoOo_o.0o_. = A_0;
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x001A4842 File Offset: 0x001A2A42
		public o\u3002\u3000\u3002()
		{
			base.FormClosed += this.OO_ooO.00o.;
			this.o.o0o__o0_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x001A4877 File Offset: 0x001A2A77
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0O.0O0O_0O_.().Value = OO_00oOO.MainTable.DataTable.OOoo__00O_.o_O.(this.o0O.0O0O_0O_.().Text, false);
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x001A48A0 File Offset: 0x001A2AA0
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
				Information.Err().Clear();
				IL_13:
				num2 = 3;
				OleDbConnection oleDbConnection = OO_00oOO.MainTable.DataTable.frd_Connection;
				IL_25:
				num2 = 4;
				string text = this.oO.__0_OOO00.().Text.Trim();
				IL_39:
				num2 = 5;
				string text2 = "";
				IL_42:
				num2 = 6;
				if (!Oo00.o.O0_O0.(text))
				{
					goto IL_585;
				}
				IL_50:
				num2 = 8;
				if (oleDbConnection != O_O0OO.OoO.0OO__0ooo.())
				{
					goto IL_86;
				}
				IL_5A:
				num2 = 9;
				string text3 = "~TMPCLP" + OO_00oOO.MainTable.Name;
				IL_73:
				num2 = 10;
				string text4 = "~TMPCLP" + text;
				goto IL_9C;
				IL_86:
				num2 = 12;
				text3 = OO_00oOO.MainTable.Name;
				IL_95:
				num2 = 13;
				text4 = text;
				IL_9C:
				num2 = 14;
				foreach (DataColumn dataColumn in OO_00oOO.MainTable.DataTable.BaseTable.PrimaryKey)
				{
					IL_C1:
					num2 = 15;
					text2 = text2 + ",[" + dataColumn.ColumnName + "]";
					IL_DE:
					num2 = 16;
				}
				IL_EF:
				num2 = 17;
				text2 = text2.Trim(new char[]
				{
					','
				});
				IL_106:
				num2 = 18;
				OleDbCommand oleDbCommand = new OleDbCommand("", oleDbConnection);
				IL_116:
				num2 = 19;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Select * Into [",
					text4,
					"] From [",
					text3,
					"]"
				});
				IL_14D:
				num2 = 20;
				if (!this.oo0o00O0oo0.O.().Checked)
				{
					goto IL_17A;
				}
				IL_15D:
				num2 = 21;
				oleDbCommand.CommandText += " Where 1 is Null";
				goto IL_1BC;
				IL_17A:
				num2 = 23;
				if (Operators.CompareString(this.o0O.0O0O_0O_.().Text, "", true) <= 0)
				{
					goto IL_1BC;
				}
				IL_196:
				num2 = 24;
				oleDbCommand.CommandText = oleDbCommand.CommandText + " Where " + this.o0O.0O0O_0O_.().Text;
				IL_1BC:
				num2 = 25;
				OO_00oOO.MainTable.DataTable.Save();
				IL_1CE:
				num2 = 26;
				oleDbConnection.Open();
				IL_1D7:
				num2 = 27;
				oleDbCommand.ExecuteNonQuery();
				IL_1E2:
				num2 = 28;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Alter Table [",
					text4,
					"] ADD PRIMARY KEY (",
					text2,
					")"
				});
				IL_219:
				num2 = 29;
				oleDbCommand.ExecuteNonQuery();
				IL_224:
				num2 = 30;
				oleDbConnection.Close();
				IL_22D:
				num2 = 31;
				if (Information.Err().Number != 0)
				{
					goto IL_585;
				}
				IL_23F:
				num2 = 33;
				if (oleDbConnection != O_O0OO.OoO.0OO__0ooo.())
				{
					goto IL_2A1;
				}
				IL_24A:
				num2 = 34;
				o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.DataTables, O_O0OO.OOOo.oo_OOOO_0.(), text4, true, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), false);
				IL_274:
				num2 = 35;
				OO_00oOO.DataTables[text].o.0O000_.();
				IL_288:
				num2 = 36;
				OO_00oOO.DataTables[text].o0.O_o.();
				goto IL_418;
				IL_2A1:
				num2 = 38;
				string value = "";
				IL_2AB:
				num2 = 39;
				Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator = O_O0OO.O._o_.().Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text5 = enumerator.Current;
					IL_2CA:
					num2 = 40;
					if (O_O0OO.O._o_.()[text5] == oleDbConnection)
					{
						IL_2DC:
						num2 = 41;
						value = text5;
						break;
					}
					IL_2E5:
					num2 = 43;
				}
				IL_2F1:
				num2 = 44;
				((IDisposable)enumerator).Dispose();
				IL_301:
				num2 = 45;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].NewRow();
				IL_31F:
				num2 = 46;
				dataRow["Type"] = OtherTableTypeEnum.Table;
				IL_334:
				num2 = 47;
				dataRow["Name"] = text;
				IL_345:
				num2 = 48;
				OuterTableSetting outerTableSetting = new OuterTableSetting();
				IL_34F:
				num2 = 49;
				outerTableSetting.SourceTable = text;
				IL_35B:
				num2 = 50;
				outerTableSetting.AllRows = false;
				IL_366:
				num2 = 51;
				outerTableSetting.Top = 10;
				IL_372:
				num2 = 52;
				dataRow["DataSource"] = value;
				IL_383:
				num2 = 53;
				dataRow["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, false, '\v', false);
				IL_39D:
				num2 = 54;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows.Add(dataRow);
				IL_3C0:
				num2 = 55;
				Oo00.O0Oo_O.0O_0O.(dataRow);
				IL_3CA:
				num2 = 56;
				o0OoOOoOOo0.OOOOO.o000.(dataRow, O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), true, false, null);
				IL_404:
				num2 = 57;
				OO_00oOO.DataTables[text].o.0O000_.();
				IL_418:
				num2 = 58;
				OO_00oOO.DataTables[text].Caption = this.oo0o00O0oo0.O.().Text;
				IL_437:
				num2 = 59;
				IEnumerator<DataCol> enumerator2 = OO_00oOO.DataTables[text].DataCols.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataCol dataCol = enumerator2.Current;
					IL_45D:
					num2 = 60;
					if (OO_00oOO.MainTable.DataTable.DataCols.Contains(dataCol.Name))
					{
						IL_47D:
						num2 = 61;
						dataCol.Caption = OO_00oOO.MainTable.DataTable.DataCols[dataCol.Name].Caption;
						IL_4A7:
						num2 = 62;
						dataCol.O.O_OO.(false);
					}
					IL_4B2:
					num2 = 63;
				}
				IL_4BE:
				num2 = 64;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_4CC:
				num2 = 65;
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[text]);
				IL_4E5:
				num2 = 66;
				Main.OO_O.o..o0_o_o_0.0O.(text, true, false);
				IL_4F6:
				num2 = 67;
				Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
				IL_51E:
				num2 = 68;
				if (Operators.CompareString(this.oo0o00O0oo0.O.().Text, "", true) <= 0)
				{
					goto IL_54F;
				}
				IL_53A:
				num2 = 69;
				OO_00oOO.DataTables[text].OO00_o.ooOO.(false);
				IL_54F:
				num2 = 70;
				O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
				IL_55E:
				num2 = 71;
				base.DialogResult = DialogResult.OK;
				IL_568:
				num2 = 72;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
				IL_585:
				goto IL_6FB;
				IL_58A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_6BC:
				goto IL_6F0;
				IL_6BE:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_6CE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_6BE;
			}
			IL_6F0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_6FB:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x001A4FCC File Offset: 0x001A31CC
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040017FF RID: 6143
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001800 RID: 6144
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001801 RID: 6145
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001802 RID: 6146
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001803 RID: 6147
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001804 RID: 6148
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001805 RID: 6149
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001806 RID: 6150
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001807 RID: 6151
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001808 RID: 6152
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001809 RID: 6153
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400180A RID: 6154
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;
	}
}
