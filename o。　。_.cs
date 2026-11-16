using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000380 RID: 896
	[DesignerGenerated]
	internal partial class o\u3002\u3000\u3002_ : Form
	{
		// Token: 0x060039C2 RID: 14786 RVA: 0x0019D750 File Offset: 0x0019B950
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oooO_.o. != null)
				{
					this.oooO_.o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x0019D790 File Offset: 0x0019B990
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O.00oOoo0___00.(new C1Button());
			this.O._ooOoo0__o_0.(new C1Button());
			this.oOOOoO0.0o0.(new C1Button());
			this.o0.o__0o.(new C1Button());
			this.O.00oOoo0___00.(new C1FlexGrid());
			this.oO._O0.(new C1Button());
			this.Oo.O_O0__0O_0.(new C1Button());
			this.OOooOoO_.O.(new C1Button());
			this.oo000_o__.O.(new C1Button());
			this.o___0oO.0Oo0_0.(new C1Button());
			((ISupportInitialize)this.OOoO_O_0_.O0o0.()).BeginInit();
			base.SuspendLayout();
			this.O0___O.O.().Location = new Point(322, 15);
			this.O0___O.O.().Name = "btnAdd";
			this.O0___O.O.().Size = new Size(82, 23);
			this.O0___O.O.().TabIndex = 1;
			this.O0___O.O.().Text = "增加";
			this.O0___O.O.().UseVisualStyleBackColor = true;
			this.O0oo_OO_.oO_oO.().Location = new Point(322, 44);
			this.O0oo_OO_.oO_oO.().Name = "btnDelete";
			this.O0oo_OO_.oO_oO.().Size = new Size(82, 23);
			this.O0oo_OO_.oO_oO.().TabIndex = 2;
			this.O0oo_OO_.oO_oO.().Text = "删除";
			this.O0oo_OO_.oO_oO.().UseVisualStyleBackColor = true;
			this.oo._ooO.().Location = new Point(322, 73);
			this.oo._ooO.().Name = "btnEdit";
			this.oo._ooO.().Size = new Size(82, 23);
			this.oo._ooO.().TabIndex = 3;
			this.oo._ooO.().Text = "修改";
			this.oo._ooO.().UseVisualStyleBackColor = true;
			this.O__.Oo.().Location = new Point(322, 160);
			this.O__.Oo.().Name = "btnGroup";
			this.O__.Oo.().Size = new Size(82, 23);
			this.O__.Oo.().TabIndex = 6;
			this.O__.Oo.().Text = "组定义";
			this.O__.Oo.().UseVisualStyleBackColor = true;
			this.OOoO_O_0_.O0o0.().AllowDragging = AllowDraggingEnum.None;
			this.OOoO_O_0_.O0o0.().AllowResizing = AllowResizingEnum.None;
			this.OOoO_O_0_.O0o0.().AllowSorting = AllowSortingEnum.None;
			this.OOoO_O_0_.O0o0.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.OOoO_O_0_.O0o0.().ColumnInfo = "1,0,0,20,0,0,Columns:";
			this.OOoO_O_0_.O0o0.().ExtendLastCol = true;
			this.OOoO_O_0_.O0o0.().FocusRect = FocusRectEnum.None;
			this.OOoO_O_0_.O0o0.().Location = new Point(13, 15);
			this.OOoO_O_0_.O0o0.().Name = "lstUsers";
			this.OOoO_O_0_.O0o0.().Rows.Count = 1;
			this.OOoO_O_0_.O0o0.().Rows.DefaultSize = 19;
			this.OOoO_O_0_.O0o0.().Rows.Fixed = 0;
			this.OOoO_O_0_.O0o0.().SelectionMode = SelectionModeEnum.Row;
			this.OOoO_O_0_.O0o0.().Size = new Size(292, 363);
			this.OOoO_O_0_.O0o0.().TabIndex = 0;
			this.OOoO_O_0_.O0o0.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
			this.oO0O.O_o000Oo0.().Location = new Point(322, 102);
			this.oO0O.O_o000Oo0.().Name = "btnDefault";
			this.oO0O.O_o000Oo0.().Size = new Size(82, 23);
			this.oO0O.O_o000Oo0.().TabIndex = 4;
			this.oO0O.O_o000Oo0.().Text = "默认用户";
			this.oO0O.O_o000Oo0.().UseVisualStyleBackColor = true;
			this.OOoO_O_0_.O0o0.().Location = new Point(322, 131);
			this.OOoO_O_0_.O0o0.().Name = "btnExtProperty";
			this.OOoO_O_0_.O0o0.().Size = new Size(82, 23);
			this.OOoO_O_0_.O0o0.().TabIndex = 5;
			this.OOoO_O_0_.O0o0.().Text = "扩展属性";
			this.OOoO_O_0_.O0o0.().UseVisualStyleBackColor = true;
			this.oO_0oO._o.().Location = new Point(322, 189);
			this.oO_0oO._o.().Name = "btnRole";
			this.oO_0oO._o.().Size = new Size(82, 23);
			this.oO_0oO._o.().TabIndex = 7;
			this.oO_0oO._o.().Text = "角色定义";
			this.oO_0oO._o.().UseVisualStyleBackColor = true;
			this.OO0_OO0O0.00Oo.().Location = new Point(322, 218);
			this.OO0_OO0O0.00Oo.().Name = "btnUserTable";
			this.OO0_OO0O0.00Oo.().Size = new Size(82, 23);
			this.OO0_OO0O0.00Oo.().TabIndex = 9;
			this.OO0_OO0O0.00Oo.().Text = "用户数据表";
			this.OO0_OO0O0.00Oo.().UseVisualStyleBackColor = true;
			this.oo00__oo._o_O.().Location = new Point(322, 355);
			this.oo00__oo._o_O.().Name = "Button2";
			this.oo00__oo._o_O.().Size = new Size(82, 23);
			this.oo00__oo._o_O.().TabIndex = 10;
			this.oo00__oo._o_O.().Text = "关闭";
			this.oo00__oo._o_O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(418, 393);
			base.Controls.Add(this.oo00__oo._o_O.());
			base.Controls.Add(this.OO0_OO0O0.00Oo.());
			base.Controls.Add(this.oO_0oO._o.());
			base.Controls.Add(this.OOoO_O_0_.O0o0.());
			base.Controls.Add(this.oO0O.O_o000Oo0.());
			base.Controls.Add(this.OOoO_O_0_.O0o0.());
			base.Controls.Add(this.O__.Oo.());
			base.Controls.Add(this.oo._ooO.());
			base.Controls.Add(this.O0oo_OO_.oO_oO.());
			base.Controls.Add(this.O0___O.O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.O.o...";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "用户管理";
			((ISupportInitialize)this.OOoO_O_0_.O0o0.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x0019DDC3 File Offset: 0x0019BFC3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OoO.0O.;
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x0019DDCC File Offset: 0x0019BFCC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoO_o_ooo.0.);
			C1Button ooO.0O. = this.OoO.0O.;
			if (ooO.0O. != null)
			{
				ooO.0O..Click -= value;
			}
			this.OoO.0O. = A_0;
			ooO.0O. = this.OoO.0O.;
			if (ooO.0O. != null)
			{
				ooO.0O..Click += value;
			}
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x0019DE0F File Offset: 0x0019C00F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOo_oo._O.;
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x0019DE18 File Offset: 0x0019C018
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o00O_._ooOo.);
			C1Button c1Button = this.oOo_oo._O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOo_oo._O. = A_0;
			c1Button = this.oOo_oo._O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x0019DE5B File Offset: 0x0019C05B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0O.0OOOOoO0.;
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x0019DE64 File Offset: 0x0019C064
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OooO.O_0o0.);
			C1Button o0O.0OOOOoO0. = this.O0O.0OOOOoO0.;
			if (o0O.0OOOOoO0. != null)
			{
				o0O.0OOOOoO0..Click -= value;
			}
			this.O0O.0OOOOoO0. = A_0;
			o0O.0OOOOoO0. = this.O0O.0OOOOoO0.;
			if (o0O.0OOOOoO0. != null)
			{
				o0O.0OOOOoO0..Click += value;
			}
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x0019DEA7 File Offset: 0x0019C0A7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO_OoO.O.;
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x0019DEB0 File Offset: 0x0019C0B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_O0Oo_0_Oo.o.);
			C1Button c1Button = this.oO_OoO.O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO_OoO.O. = A_0;
			c1Button = this.oO_OoO.O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x0019DEF3 File Offset: 0x0019C0F3
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.OoO.0O.;
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x0019DEFC File Offset: 0x0019C0FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			OwnerDrawCellEventHandler value = new OwnerDrawCellEventHandler(this.OOoO_O_0_.O0o0.);
			C1FlexGrid ooO.0O. = this.OoO.0O.;
			if (ooO.0O. != null)
			{
				ooO.0O..OwnerDrawCell -= value;
			}
			this.OoO.0O. = A_0;
			ooO.0O. = this.OoO.0O.;
			if (ooO.0O. != null)
			{
				ooO.0O..OwnerDrawCell += value;
			}
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x0019DF3F File Offset: 0x0019C13F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.OOO0.;
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x0019DF48 File Offset: 0x0019C148
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo.O0_0.);
			C1Button c1Button = this.o.OOO0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.OOO0. = A_0;
			c1Button = this.o.OOO0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x0019DF8B File Offset: 0x0019C18B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.OoO__O0o.;
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x0019DF94 File Offset: 0x0019C194
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0._O____OO_.);
			C1Button c1Button = this.o.OoO__O0o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.OoO__O0o. = A_0;
			c1Button = this.o.OoO__O0o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x0019DFD7 File Offset: 0x0019C1D7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_.0o0OOO_0.;
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x0019DFE0 File Offset: 0x0019C1E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO0O.O_o000Oo0.);
			C1Button c1Button = this.o_.0o0OOO_0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_.0o0OOO_0. = A_0;
			c1Button = this.o_.0o0OOO_0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x0019E023 File Offset: 0x0019C223
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.0o0.;
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x0019E02C File Offset: 0x0019C22C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.O0Oo0_.);
			C1Button o.0o0. = this.O.0o0.;
			if (o.0o0. != null)
			{
				o.0o0..Click -= value;
			}
			this.O.0o0. = A_0;
			o.0o0. = this.O.0o0.;
			if (o.0o0. != null)
			{
				o.0o0..Click += value;
			}
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x0019E06F File Offset: 0x0019C26F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.0O00oO.;
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x0019E078 File Offset: 0x0019C278
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_.0_00oO_0.);
			C1Button c1Button = this.o.0O00oO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.0O00oO. = A_0;
			c1Button = this.o.0O00oO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x0019E0BC File Offset: 0x0019C2BC
		public o\u3002\u3000\u3002_()
		{
			base.FormClosed += this.O_.0_00oO_0.;
			base.Load += this.o_OO.o__.;
			this.O__.Oo.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x0019E110 File Offset: 0x0019C310
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
			OO_00oOO.Users.ooo___o_0.__.();
			if (this.oooO_.o. != O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()])
			{
				this.oooO_.o..ExtendedProperties.Clear();
				this.oooO_.o..Reset();
				this.oooO_.o..Dispose();
			}
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x0019E179 File Offset: 0x0019C379
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OOoO_O_0_.O0o0.();
			if (OO_00oOO.User.Type != UserTypeEnum.Developer && OO_00oOO.User.Type != UserTypeEnum.Administrator)
			{
				this.OO0_OO0O0.00Oo.().Enabled = false;
			}
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x0019E1A8 File Offset: 0x0019C3A8
		private void <<EMPTY_NAME>>()
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.oooO_.o. = null;
				IL_10:
				num2 = 3;
				this.oooO_.o. = null;
				IL_19:
				num2 = 4;
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()];
				IL_30:
				num2 = 5;
				if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()].Rows.Count != 0)
				{
					goto IL_59;
				}
				IL_52:
				num2 = 6;
				Oo00.o_o_oo.0o.();
				IL_59:
				num2 = 7;
				DataRow dataRow = dataTable.Rows.Find(new object[]
				{
					"User",
					o0_O.o.0_O_O.
				});
				IL_80:
				num2 = 8;
				if (dataRow == null || Operators.CompareString(dataRow["Config"].ToString(), "1", true) != 0)
				{
					goto IL_AE;
				}
				IL_A4:
				num2 = 9;
				this.oooO_.o. = true;
				IL_AE:
				num2 = 10;
				if (!this.oooO_.o.)
				{
					goto IL_550;
				}
				IL_BC:
				num2 = 11;
				string text = "";
				IL_C6:
				num2 = 12;
				string text2 = "";
				IL_D0:
				num2 = 13;
				DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.Oo0_.o0.
				});
				IL_10B:
				num2 = 14;
				if (dataRow2 == null)
				{
					goto IL_128;
				}
				IL_112:
				num2 = 15;
				text = dataRow2["Config"].ToString();
				IL_128:
				num2 = 16;
				dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"User",
					o0_O.OO_O.O0ooO0O.
				});
				IL_163:
				num2 = 17;
				if (dataRow2 == null)
				{
					goto IL_180;
				}
				IL_16A:
				num2 = 18;
				text2 = dataRow2["Config"].ToString();
				IL_180:
				num2 = 19;
				if (Operators.CompareString(text, "", true) <= 0 || Operators.CompareString(text2, "", true) <= 0)
				{
					goto IL_531;
				}
				IL_1A9:
				num2 = 20;
				if (!O_O0OO.O._o_.().ContainsKey(text))
				{
					goto IL_291;
				}
				IL_1BD:
				num2 = 21;
				this.oooO_.o. = O_O0OO.O._o_.()[text];
				IL_1D2:
				num2 = 22;
				this.oooO_.o. = new DataTable();
				IL_1E0:
				num2 = 23;
				if (!o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()[text]))
				{
					goto IL_214;
				}
				IL_1F6:
				num2 = 24;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From " + text2, this.oooO_.o.);
				goto IL_257;
				IL_214:
				num2 = 26;
				if (text2.StartsWith("["))
				{
					goto IL_23B;
				}
				IL_225:
				num2 = 27;
				text2 = "[" + text2 + "]";
				IL_23B:
				num2 = 28;
				oleDbDataAdapter = new OleDbDataAdapter("Select * From " + text2, this.oooO_.o.);
				IL_257:
				num2 = 29;
				oleDbDataAdapter.Fill(this.oooO_.o.);
				IL_268:
				num2 = 30;
				o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
				IL_272:
				num2 = 31;
				this.oooO_.o..ExtendedProperties.Add("DataAdapter", oleDbDataAdapter);
				goto IL_400;
				IL_291:
				num2 = 33;
				if (!O_O0OO.OoO__.0oO0oo.().ContainsKey(text))
				{
					goto IL_400;
				}
				IL_2A5:
				num2 = 34;
				this.oooO_.o. = O_O0OO.OoO__.0oO0oo.()[text];
				IL_2BA:
				num2 = 35;
				if (this.oooO_.o..OO.OoO0. != DataServerTypeEnum.Oracle)
				{
					goto IL_2DE;
				}
				IL_2CB:
				num2 = 36;
				string a_ = "Select * From " + text2;
				goto IL_316;
				IL_2DE:
				num2 = 38;
				if (text2.StartsWith("["))
				{
					goto IL_305;
				}
				IL_2EF:
				num2 = 39;
				text2 = "[" + text2 + "]";
				IL_305:
				num2 = 40;
				a_ = "Select * From " + text2;
				IL_316:
				num2 = 41;
				HttpClient httpClient = this.oooO_.o..oO0_0.o.();
				IL_326:
				num2 = 42;
				Dictionary<string, string> dictionary = httpClient.FormData;
				string key = "Action";
				int num3 = 1;
				dictionary[key] = num3.ToString();
				IL_344:
				num2 = 43;
				httpClient.Select = a_;
				IL_350:
				num2 = 44;
				this.oooO_.o. = httpClient.GetBaseDataTable();
				IL_360:
				num2 = 45;
				DataTable dataTable2 = new DataTable(this.oooO_.o., null, null, text2, null);
				IL_375:
				num2 = 46;
				dataTable2.ConnectionName = text;
				IL_381:
				num2 = 47;
				dataTable2.DataServer = httpClient.Oo_0oO0Oo0_.O_.;
				IL_392:
				num2 = 48;
				dataTable2.UpdateServer = httpClient.Oo_0oO0Oo0_.O_.;
				IL_3A3:
				num2 = 49;
				dataTable2.HttpSelect = a_;
				IL_3AF:
				num2 = 50;
				dataTable2.UpdateColumns = (List<string>)this.oooO_.o..ExtendedProperties["UpdateColumns"];
				IL_3D3:
				num2 = 51;
				this.oooO_.o..ExtendedProperties.Clear();
				IL_3E6:
				num2 = 52;
				this.oooO_.o..ExtendedProperties.Add("WebUpdater", dataTable2);
				IL_400:
				num2 = 53;
				this.oooO_.o..Columns.Add("Row", typeof(DataRow));
				IL_423:
				num2 = 54;
				DataRow[] array = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()].Select("[Type] = " + Conversions.ToString(0) + " Or [Type] = " + Conversions.ToString(1));
				IL_45C:
				num2 = 55;
				num3 = array.Length - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_46F:
					num2 = 56;
					DataRow dataRow3 = array[i];
					IL_479:
					num2 = 57;
					DataRow dataRow4 = this.oooO_.o..NewRow();
					IL_489:
					num2 = 58;
					dataRow4["Name"] = RuntimeHelpers.GetObjectValue(dataRow3["Name"]);
					IL_4A9:
					num2 = 59;
					dataRow4["Type"] = RuntimeHelpers.GetObjectValue(dataRow3["Type"]);
					IL_4C9:
					num2 = 60;
					dataRow4["Config"] = RuntimeHelpers.GetObjectValue(dataRow3["Config"]);
					IL_4E9:
					num2 = 61;
					dataRow4["Row"] = dataRow3;
					IL_4FA:
					num2 = 62;
					this.oooO_.o..Rows.Add(dataRow4);
					IL_50F:
					num2 = 63;
				}
				IL_521:
				num2 = 64;
				this.oooO_.o..AcceptChanges();
				goto IL_56D;
				IL_531:
				num2 = 66;
				this.oooO_.o. = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()];
				goto IL_56D;
				IL_550:
				num2 = 68;
				this.oooO_.o. = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()];
				IL_56D:
				num2 = 69;
				DataView dataView = new DataView(this.oooO_.o., "[Type] <= " + Conversions.ToString(4), "[Type]", DataViewRowState.CurrentRows);
				IL_594:
				num2 = 70;
				if (OO_00oOO.User.Type != UserTypeEnum.User && OO_00oOO.User.Type != UserTypeEnum.Default)
				{
					goto IL_5FA;
				}
				IL_5B1:
				num2 = 71;
				dataView.RowFilter = "[Name] = '" + OO_00oOO.User.Name + "' And [Type] <= " + Conversions.ToString(4);
				IL_5DA:
				num2 = 72;
				this.O0___O.O.().Enabled = false;
				IL_5E9:
				num2 = 73;
				this.O0oo_OO_.oO_oO.().Enabled = false;
				goto IL_628;
				IL_5FA:
				num2 = 75;
				dataView.RowFilter = "[Type] >= " + Conversions.ToString((int)OO_00oOO.User.Type) + " And [Type] <= " + Conversions.ToString(4);
				IL_628:
				num2 = 76;
				this.oO0O.O_o000Oo0.().Enabled = (OO_00oOO.User.Type == UserTypeEnum.Developer);
				IL_643:
				num2 = 77;
				this.OOoO_O_0_.O0o0.().Enabled = (OO_00oOO.User.Type == UserTypeEnum.Developer);
				IL_65E:
				num2 = 78;
				this.oO_0oO._o.().Enabled = (OO_00oOO.User.Type == UserTypeEnum.Developer);
				IL_679:
				num2 = 79;
				this.O__.Oo.().Enabled = (OO_00oOO.User.Type == UserTypeEnum.Developer);
				IL_694:
				num2 = 80;
				this.OO0_OO0O0.00Oo.().Enabled = (OO_00oOO.User.Type == UserTypeEnum.Developer);
				IL_6AF:
				num2 = 81;
				this.OOoO_O_0_.O0o0.().DataSource = dataView;
				IL_6BF:
				num2 = 82;
				this.OOoO_O_0_.O0o0.().Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None;
				IL_6DD:
				num2 = 83;
				for (int j = this.OOoO_O_0_.O0o0.().Cols.Count - 1; j >= 0; j += -1)
				{
					IL_6F6:
					num2 = 84;
					if (Operators.CompareString(this.OOoO_O_0_.O0o0.().Cols[j].Name, "Name", true) != 0)
					{
						IL_71D:
						num2 = 85;
						this.OOoO_O_0_.O0o0.().Cols.Remove(j);
					}
					else
					{
						IL_735:
						num2 = 87;
						this.OOoO_O_0_.O0o0.().AllowEditing = false;
					}
					IL_744:
					num2 = 88;
				}
				IL_752:
				num2 = 89;
				this.OOoO_O_0_.O0o0.().DrawMode = DrawModeEnum.OwnerDraw;
				IL_761:
				goto IL_91B;
				IL_766:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_8DC:
				goto IL_910;
				IL_8DE:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_8EE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_8DE;
			}
			IL_910:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_91B:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x0019EAF4 File Offset: 0x0019CCF4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new O\u3000\u3002O(UserTypeEnum.Groups, this.oooO_.o.).ShowDialog();
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x0019EB08 File Offset: 0x0019CD08
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new O\u3000o\u3000\u300200\u3002\u3000\u3000(null, this.oooO_.o.)
			{
				Text = "新增用户"
			}.ShowDialog();
			OO_00oOO.Users.ooo___o_0.__.();
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x0019EB34 File Offset: 0x0019CD34
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OOoO_O_0_.O0o0.().Row >= 0)
			{
				DataRowView dataRowView = (DataRowView)this.OOoO_O_0_.O0o0.().Rows[this.OOoO_O_0_.O0o0.().Row].DataSource;
				UserTypeEnum userTypeEnum = (UserTypeEnum)Conversions.ToInteger(dataRowView["Type"]);
				if (userTypeEnum == UserTypeEnum.Administrator || userTypeEnum == UserTypeEnum.Developer)
				{
					MessageBox.Show("不能删除系统用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (OO_00oOO.Users.ooo___o_0.__..ContainsKey(dataRowView.Row))
				{
					OO_00oOO.Users.ooo___o_0.__..Remove(dataRowView.Row);
				}
				dataRowView.Delete();
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()], true);
				if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()] != this.oooO_.o. && this.oooO_.o. != null)
				{
					Oo00.o0_o._O_.(this.oooO_.o., true);
				}
			}
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x0019EC24 File Offset: 0x0019CE24
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OOoO_O_0_.O0o0.().Row >= 0)
			{
				DataRow row = ((DataRowView)this.OOoO_O_0_.O0o0.().Rows[this.OOoO_O_0_.O0o0.().Row].DataSource).Row;
				new O\u3000o\u3000\u300200\u3002\u3000\u3000(row, this.oooO_.o.).ShowDialog();
				if (OO_00oOO.Users.ooo___o_0.__..ContainsKey(row))
				{
					OO_00oOO.Users.ooo___o_0.__..Remove(row);
				}
			}
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x0019ECA0 File Offset: 0x0019CEA0
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
				if (this.OOoO_O_0_.O0o0.().Row < 0)
				{
					goto IL_1CC;
				}
				IL_1A:
				num2 = 3;
				DataRow row = ((DataRowView)this.OOoO_O_0_.O0o0.().Rows[this.OOoO_O_0_.O0o0.().Row].DataSource).Row;
				IL_47:
				num2 = 4;
				UserTypeEnum userTypeEnum = (UserTypeEnum)Conversions.ToInteger(row["Type"]);
				IL_5B:
				num2 = 5;
				if (userTypeEnum != UserTypeEnum.Administrator && userTypeEnum != UserTypeEnum.Developer)
				{
					goto IL_80;
				}
				IL_66:
				num2 = 6;
				MessageBox.Show("开发者和管理员不能作为默认用户使用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_1CC;
				IL_80:
				num2 = 8;
				if (userTypeEnum != UserTypeEnum.Default)
				{
					goto IL_A0;
				}
				IL_87:
				num2 = 9;
				row["Type"] = UserTypeEnum.User;
				goto IL_16B;
				IL_A0:
				num2 = 11;
				if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()] == this.oooO_.o. || this.oooO_.o. == null)
				{
					goto IL_E2;
				}
				IL_C7:
				num2 = 12;
				MessageBox.Show("使用外部数据表存储用户信息时，不能设置默认用户!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_16B;
				IL_E2:
				num2 = 14;
				IEnumerator enumerator = row.Table.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_107:
					num2 = 15;
					if (Conversions.ToInteger(dataRow["Type"]) == 4)
					{
						IL_11E:
						num2 = 16;
						dataRow["Type"] = UserTypeEnum.User;
					}
					IL_133:
					num2 = 17;
				}
				IL_13F:
				num2 = 18;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_157:
				num2 = 19;
				row["Type"] = UserTypeEnum.Default;
				IL_16B:
				num2 = 20;
				this.OOoO_O_0_.O0o0.().Refresh();
				IL_179:
				num2 = 21;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()], true);
				IL_196:
				num2 = 22;
				if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()] == this.oooO_.o. || this.oooO_.o. == null)
				{
					goto IL_1CC;
				}
				IL_1BD:
				num2 = 23;
				Oo00.o0_o._O_.(this.oooO_.o., true);
				IL_1CC:
				goto IL_27E;
				IL_1D1:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_23F:
				goto IL_273;
				IL_241:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_251:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_241;
			}
			IL_273:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_27E:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x0019EF50 File Offset: 0x0019D150
		private void <<EMPTY_NAME>>(object A_0, OwnerDrawCellEventArgs A_1)
		{
			if (A_1.Row >= 0 && this.OOoO_O_0_.O0o0.().Rows[A_1.Row].DataSource != null)
			{
				DataRow row = ((DataRowView)this.OOoO_O_0_.O0o0.().Rows[A_1.Row].DataSource).Row;
				if (Conversions.ToInteger(row["Type"]) == 4)
				{
					A_1.Text = row["Name"].ToString() + "(默认)";
				}
			}
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x0019EFDC File Offset: 0x0019D1DC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new o\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3000(this.oooO_.o.).ShowDialog();
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x0019EFEF File Offset: 0x0019D1EF
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new O\u3000\u3002O(UserTypeEnum.Roles, this.oooO_.o.).ShowDialog();
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x0019F003 File Offset: 0x0019D203
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (new o\u30000\u3002\u3000\u3000\u3000().ShowDialog() == DialogResult.OK)
			{
				this.OOoO_O_0_.O0o0.();
			}
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x0019F018 File Offset: 0x0019D218
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x040017AD RID: 6061
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040017AE RID: 6062
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017AF RID: 6063
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017B0 RID: 6064
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017B1 RID: 6065
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017B2 RID: 6066
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040017B3 RID: 6067
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017B4 RID: 6068
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017B5 RID: 6069
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017B6 RID: 6070
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017B7 RID: 6071
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017B8 RID: 6072
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x040017B9 RID: 6073
		private bool <<EMPTY_NAME>>;

		// Token: 0x040017BA RID: 6074
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x040017BB RID: 6075
		private OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x040017BC RID: 6076
		private O0O <<EMPTY_NAME>>;
	}
}
