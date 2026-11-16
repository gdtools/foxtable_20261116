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
	// Token: 0x02000385 RID: 901
	[DesignerGenerated]
	internal partial class O\u3002\u3002 : Form
	{
		// Token: 0x06003A3A RID: 14906 RVA: 0x001A1ABB File Offset: 0x0019FCBB
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.O_oOO.0o__O0. != null)
			{
				this.O_oOO.0o__O0..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x001A1ADC File Offset: 0x0019FCDC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o.0_ooooo0.(new C1Button());
			this.O.oo_.(new C1Button());
			this.OoOO_o.__O_0.(new oo0_o0o_0o__());
			this.o.0o_Oo_oOo0.(new C1Button());
			this.OoOO_o.__O_0.(new C1Button());
			this.OOo.0o.(new C1Button());
			this.OoOO_o.__O_0.(new Label());
			this.OoOO_o.__O_0.(new C1ComboBox());
			base.SuspendLayout();
			this.oooOo0OO0.o0_0.().Location = new Point(411, 400);
			this.oooOo0OO0.o0_0.().Name = "Button1";
			this.oooOo0OO0.o0_0.().Size = new Size(75, 23);
			this.oooOo0OO0.o0_0.().TabIndex = 5;
			this.oooOo0OO0.o0_0.().Text = "确定";
			this.oooOo0OO0.o0_0.().UseVisualStyleBackColor = true;
			this.ooO__o_O_O.o_.().DialogResult = DialogResult.Cancel;
			this.ooO__o_O_O.o_.().Location = new Point(492, 400);
			this.ooO__o_O_O.o_.().Name = "Button2";
			this.ooO__o_O_O.o_.().Size = new Size(75, 23);
			this.ooO__o_O_O.o_.().TabIndex = 6;
			this.ooO__o_O_O.o_.().Text = "取消";
			this.ooO__o_O_O.o_.().UseVisualStyleBackColor = true;
			this.OoOO_o.__O_0.().Location = new Point(15, 41);
			this.OoOO_o.__O_0.().Name = "StructureEditor1";
			this.OoOO_o.__O_0.().Size = new Size(552, 337);
			this.OoOO_o.__O_0.().TabIndex = 1;
			this.O__.o0.().Location = new Point(15, 400);
			this.O__.o0.().Name = "btnMoveUp";
			this.O__.o0.().Size = new Size(75, 23);
			this.O__.o0.().TabIndex = 2;
			this.O__.o0.().Text = "上移行";
			this.O__.o0.().UseVisualStyleBackColor = true;
			this.OO0000.o.().Location = new Point(97, 400);
			this.OO0000.o.().Name = "btnMoveDown";
			this.OO0000.o.().Size = new Size(75, 23);
			this.OO0000.o.().TabIndex = 3;
			this.OO0000.o.().Text = "下移行";
			this.OO0000.o.().UseVisualStyleBackColor = true;
			this.o__._.().Location = new Point(179, 400);
			this.o__._.().Name = "btnDelete";
			this.o__._.().Size = new Size(75, 23);
			this.o__._.().TabIndex = 4;
			this.o__._.().Text = "删除行";
			this.o__._.().UseVisualStyleBackColor = true;
			this.ooO__o_O_O.o_.().AutoSize = true;
			this.ooO__o_O_O.o_.().Location = new Point(15, 13);
			this.ooO__o_O_O.o_.().Name = "Label1";
			this.ooO__o_O_O.o_.().Size = new Size(71, 12);
			this.ooO__o_O_O.o_.().TabIndex = 6;
			this.ooO__o_O_O.o_.().Text = "选择数据源:";
			this.ooO__o_O_O.o_.().DropDownStyle = DropDownStyle.DropDownList;
			this.ooO__o_O_O.o_.().Location = new Point(97, 10);
			this.ooO__o_O_O.o_.().Name = "cmbDatasource";
			this.ooO__o_O_O.o_.().Size = new Size(201, 20);
			this.ooO__o_O_O.o_.().TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(583, 435);
			base.Controls.Add(this.ooO__o_O_O.o_.());
			base.Controls.Add(this.ooO__o_O_O.o_.());
			base.Controls.Add(this.o__._.());
			base.Controls.Add(this.OO0000.o.());
			base.Controls.Add(this.O__.o0.());
			base.Controls.Add(this.OoOO_o.__O_0.());
			base.Controls.Add(this.ooO__o_O_O.o_.());
			base.Controls.Add(this.oooOo0OO0.o0_0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ooo.O.O.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "增加表";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x001A1F4E File Offset: 0x001A014E
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_oOO.0o__O0.;
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x001A1F58 File Offset: 0x001A0158
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0O_.oOO_.);
			C1Button o_oOO.0o__O0. = this.O_oOO.0o__O0.;
			if (o_oOO.0o__O0. != null)
			{
				o_oOO.0o__O0..Click -= value;
			}
			this.O_oOO.0o__O0. = A_0;
			o_oOO.0o__O0. = this.O_oOO.0o__O0.;
			if (o_oOO.0o__O0. != null)
			{
				o_oOO.0o__O0..Click += value;
			}
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x001A1F9B File Offset: 0x001A019B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOoo.O00oo0.;
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x001A1FA3 File Offset: 0x001A01A3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oOoo.O00oo0. = A_0;
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x001A1FAC File Offset: 0x001A01AC
		[CompilerGenerated]
		internal virtual oo0_o0o_0o__ <<EMPTY_NAME>>()
		{
			return this.O_oOO.0o__O0.;
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x001A1FB4 File Offset: 0x001A01B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(oo0_o0o_0o__ A_0)
		{
			this.O_oOO.0o__O0. = A_0;
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x001A1FBD File Offset: 0x001A01BD
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_O0o0.Oo00.;
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x001A1FC8 File Offset: 0x001A01C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0o.o_.);
			C1Button o_O0o0.Oo00. = this.O_O0o0.Oo00.;
			if (o_O0o0.Oo00. != null)
			{
				o_O0o0.Oo00..Click -= value;
			}
			this.O_O0o0.Oo00. = A_0;
			o_O0o0.Oo00. = this.O_O0o0.Oo00.;
			if (o_O0o0.Oo00. != null)
			{
				o_O0o0.Oo00..Click += value;
			}
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x001A200B File Offset: 0x001A020B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.o_0.;
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x001A2014 File Offset: 0x001A0214
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_O_Oo._OO00o.);
			C1Button c1Button = this.o.o_0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.o_0. = A_0;
			c1Button = this.o.o_0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x001A2057 File Offset: 0x001A0257
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo0O0_ooo.O.;
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x001A2060 File Offset: 0x001A0260
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0O.o0.);
			C1Button c1Button = this.oo0O0_ooo.O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo0O0_ooo.O. = A_0;
			c1Button = this.oo0O0_ooo.O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x001A20A3 File Offset: 0x001A02A3
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_oOO.0o__O0.;
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x001A20AB File Offset: 0x001A02AB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_oOO.0o__O0. = A_0;
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x001A20B4 File Offset: 0x001A02B4
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O_oOO.0o__O0.;
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x001A20BC File Offset: 0x001A02BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O_.O0.);
			C1ComboBox o_oOO.0o__O0. = this.O_oOO.0o__O0.;
			if (o_oOO.0o__O0. != null)
			{
				o_oOO.0o__O0..SelectedIndexChanged -= value;
			}
			this.O_oOO.0o__O0. = A_0;
			o_oOO.0o__O0. = this.O_oOO.0o__O0.;
			if (o_oOO.0o__O0. != null)
			{
				o_oOO.0o__O0..SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x001A2100 File Offset: 0x001A0300
		public O\u3002\u3002()
		{
			base.Load += this.oooOo0OO0.o0_0.;
			base.FormClosed += this.ooO__o_O_O.o_.;
			this.OoOO_o.__O_0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x001A2154 File Offset: 0x001A0354
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = "";
				IL_0F:
				num2 = 3;
				if (this.OoOO_o.__O_0.().O_oo.0oOO..Rows.Count != 0)
				{
					goto IL_36;
				}
				IL_28:
				num2 = 4;
				base.DialogResult = DialogResult.OK;
				goto IL_6A3;
				IL_36:
				num2 = 6;
				IEnumerator enumerator = this.OoOO_o.__O_0.().O_oo.0oOO..Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_5F:
					num2 = 7;
					if (dataRow.IsNull("列名") || Operators.CompareString(Conversions.ToString(dataRow["列名"]), "", true) == 0)
					{
						IL_8D:
						num2 = 8;
						MessageBox.Show("请输入列名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						goto IL_6A3;
					}
					IL_A7:
					num2 = 10;
				}
				IL_B3:
				num2 = 11;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_CB:
				num2 = 12;
				o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000("", "");
				IL_DF:
				num2 = 13;
				o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(true);
				IL_EA:
				num2 = 14;
				if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() != DialogResult.OK)
				{
					goto IL_6A3;
				}
				IL_FA:
				num2 = 15;
				text = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
				IL_105:
				num2 = 16;
				string text2 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.();
				IL_111:
				num2 = 19;
				if (!this.O_oOO.0o__O0.)
				{
					goto IL_3FF;
				}
				IL_11F:
				num2 = 20;
				foreach (DataRow dataRow2 in this.OoOO_o.__O_0.().O_oo.0oOO..Select("", "ID", DataViewRowState.CurrentRows))
				{
					IL_14F:
					num2 = 21;
					DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()];
					IL_168:
					num2 = 22;
					DataRow dataRow3 = dataTable.NewRow();
					IL_174:
					num2 = 23;
					dataRow3["Table"] = text;
					IL_184:
					num2 = 24;
					dataRow3["Column"] = RuntimeHelpers.GetObjectValue(dataRow2["列名"]);
					IL_1A4:
					num2 = 25;
					dataRow3["DataType"] = (ColumnDataTypeEnum)Conversions.ToInteger(dataRow2["类型"]);
					IL_1C9:
					num2 = 26;
					if (!dataRow2.IsNull("长度"))
					{
						IL_1DA:
						num2 = 27;
						dataRow3["MaxLength"] = Conversions.ToInteger(dataRow2["长度"]);
					}
					IL_1FF:
					num2 = 28;
					dataRow3["Expression"] = "";
					IL_213:
					num2 = 29;
					if (!dataRow2.IsNull("标题"))
					{
						IL_227:
						num2 = 30;
						DataRow dataRow4 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
						{
							text,
							dataRow2["列名"]
						});
						IL_263:
						num2 = 31;
						if (dataRow4 == null)
						{
							IL_26A:
							num2 = 32;
							dataRow4 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].NewRow();
							IL_288:
							num2 = 33;
							dataRow4["Table"] = text;
							IL_298:
							num2 = 34;
							dataRow4["Column"] = RuntimeHelpers.GetObjectValue(dataRow2["列名"]);
							IL_2B8:
							num2 = 35;
							O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Add(dataRow4);
						}
						IL_2DB:
						num2 = 36;
						dataRow4["Config"] = "Caption\v" + Conversions.ToString(dataRow2["标题"]);
					}
					IL_305:
					num2 = 37;
					dataTable.Rows.Add(dataRow3);
					IL_316:
					dataTable = null;
					IL_319:
					num2 = 39;
				}
				IL_32D:
				num2 = 40;
				DataTable dataTable2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o_0_000._O.()];
				IL_346:
				num2 = 41;
				DataRow dataRow5 = dataTable2.NewRow();
				IL_352:
				num2 = 42;
				dataRow5["Name"] = text;
				IL_362:
				num2 = 43;
				dataTable2.Rows.Add(dataRow5);
				IL_373:
				num2 = 44;
				o0OoOOoOOo0.OOOOO.o000.(dataRow5, O_O0OO.OoO.0OO__0ooo.(), O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, true);
				IL_38D:
				num2 = 45;
				OO_00oOO.DataTables[text].o.0O000_.();
				IL_3A0:
				dataTable2 = null;
				IL_3A3:
				num2 = 47;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
				IL_3C0:
				num2 = 48;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o_0_000._O.()], true);
				IL_3DD:
				num2 = 49;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
				goto IL_5D5;
				IL_3FF:
				num2 = 51;
				if (this.ooO__o_O_O.o_.().SelectedIndex != 0)
				{
					goto IL_422;
				}
				IL_40F:
				num2 = 52;
				o_oo0 o_oo = new o_oo0(O_O0OO.OoO.0OO__0ooo.(), false, true);
				goto IL_455;
				IL_422:
				num2 = 54;
				OleDbConnection a_ = O_O0OO.O._o_.()[this.ooO__o_O_O.o_.().SelectedItem.ToString()];
				IL_441:
				num2 = 55;
				o_oo = new o_oo0(a_, o_O_o_oOoo__.OOOO_OO._oo.(a_), false);
				IL_455:
				num2 = 56;
				if (!Oo00.OO.0O0o.(o_oo, this.OoOO_o.__O_0.().O_oo.0oOO., text, ""))
				{
					goto IL_6A3;
				}
				IL_475:
				num2 = 58;
				o_oo.o0_oo0._.(true, false);
				IL_482:
				num2 = 59;
				if (this.ooO__o_O_O.o_.().SelectedIndex != 0)
				{
					goto IL_4CA;
				}
				IL_492:
				num2 = 60;
				o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.DataTables, O_O0OO.OOOo.oo_OOOO_0.(), "~TMPCLP" + text, true, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), false);
				goto IL_5C2;
				IL_4CA:
				num2 = 62;
				DataRow dataRow6 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].NewRow();
				IL_4E8:
				num2 = 63;
				dataRow6["Type"] = OtherTableTypeEnum.Table;
				IL_4FD:
				num2 = 64;
				dataRow6["Name"] = text;
				IL_50D:
				num2 = 65;
				OuterTableSetting outerTableSetting = new OuterTableSetting();
				IL_517:
				num2 = 66;
				outerTableSetting.SourceTable = text;
				IL_522:
				num2 = 67;
				dataRow6["DataSource"] = this.ooO__o_O_O.o_.().SelectedItem.ToString();
				IL_541:
				num2 = 68;
				dataRow6["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, false, '\v', false);
				IL_55B:
				num2 = 69;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows.Add(dataRow6);
				IL_57E:
				num2 = 70;
				Oo00.O0Oo_O.0O_0O.(dataRow6);
				IL_588:
				num2 = 71;
				o0OoOOoOOo0.OOOOO.o000.(dataRow6, O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), true, false, null);
				IL_5C2:
				num2 = 72;
				OO_00oOO.DataTables[text].o.0O000_.();
				IL_5D5:
				num2 = 73;
				OO_00oOO.DataTables[text].Caption = text2;
				IL_5EA:
				num2 = 74;
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[text]);
				IL_602:
				num2 = 75;
				Main.OO_O.o..o0_o_o_0.0O.(text, true, false);
				IL_612:
				num2 = 76;
				Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
				IL_63A:
				num2 = 77;
				if (Operators.CompareString(text2, "", true) <= 0 && !O_O0OO.O0_00o.o0__o..DevelopByCreater)
				{
					goto IL_68A;
				}
				IL_659:
				num2 = 78;
				OO_00oOO.DataTables[text].Developer = OO_00oOO.User.Name;
				IL_676:
				num2 = 79;
				OO_00oOO.DataTables[text].OO00_o.ooOO.(false);
				IL_68A:
				num2 = 80;
				O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
				IL_699:
				num2 = 81;
				base.DialogResult = DialogResult.OK;
				IL_6A3:
				goto IL_83D;
				IL_6A8:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_7FE:
				goto IL_832;
				IL_800:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_810:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_800;
			}
			IL_832:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_83D:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x001A29C4 File Offset: 0x001A0BC4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O_oOO.0o__O0.)
			{
				this.OoOO_o.__O_0.().O_oo.0oOO. = false;
			}
			else
			{
				this.OoOO_o.__O_0.().O_oo.0oOO. = true;
			}
			this.OoOO_o.__O_0.().o00_0O0.0O_.();
			Oo00.o_o_oo.0o.(this.OoOO_o.__O_0.().O_oo.0oOO.);
			this.ooO__o_O_O.o_.().Items.Add("内部数据源");
			DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()];
			try
			{
				foreach (object obj in dataTable.Rows)
				{
					string text = ((DataRow)obj)["Name"].ToString();
					if (O_O0OO.O._o_.().ContainsKey(text) && (OO_00oOO.Connections[text].SourceType == 1 || OO_00oOO.Connections[text].SourceType == 2))
					{
						this.ooO__o_O_O.o_.().Items.Add(text);
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
			this.ooO__o_O_O.o_.().SelectedIndex = 0;
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x001A2AE4 File Offset: 0x001A0CE4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OoOO_o.__O_0.().OoO_Oo._o.();
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x001A2AF1 File Offset: 0x001A0CF1
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OoOO_o.__O_0.().O_._O0Oo_o.();
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x001A2AFE File Offset: 0x001A0CFE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OoOO_o.__O_0.().O0o.OOoo.();
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x001A2B0C File Offset: 0x001A0D0C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.ooO__o_O_O.o_.().SelectedIndex == 0)
			{
				this.OoOO_o.__O_0.().O_oo.0oOO. = true;
			}
			else
			{
				OleDbConnection a_ = O_O0OO.O._o_.()[this.ooO__o_O_O.o_.().SelectedItem.ToString()];
				this.OoOO_o.__O_0.().O_oo.0oOO. = !o_O_o_oOoo__.OOOO_OO._oo.(a_);
			}
			this.OoOO_o.__O_0.().O_0Oo_._00oo0.();
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x001A2B6E File Offset: 0x001A0D6E
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040017E2 RID: 6114
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040017E3 RID: 6115
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017E4 RID: 6116
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017E5 RID: 6117
		[CompilerGenerated]
		private oo0_o0o_0o__ <<EMPTY_NAME>>;

		// Token: 0x040017E6 RID: 6118
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017E7 RID: 6119
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017E8 RID: 6120
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017E9 RID: 6121
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040017EA RID: 6122
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040017EB RID: 6123
		internal bool <<EMPTY_NAME>>;
	}
}
