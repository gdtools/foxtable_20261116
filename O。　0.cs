using System;
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
	// Token: 0x020000D9 RID: 217
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal partial class O\u3002\u30000 : Form
	{
		// Token: 0x06000A1B RID: 2587 RVA: 0x0005375C File Offset: 0x0005195C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oO0Ooo.00O_. != null)
				{
					this.oO0Ooo.00O_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0005379C File Offset: 0x0005199C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Ooo_._o__00OO0.(new ListBox());
			this.Ooo_._o__00OO0.(new SplitContainer());
			this.O0OoOo0.__.(new C1Button());
			this.oOo0_O_0.O0O.(new C1Button());
			this.OO0_.00Oo__o_.(new C1Button());
			this.O0OoOo0.__.(new O_o00o_());
			this.O0O00.Oo00oo.(new C1Button());
			((ISupportInitialize)this.O0OoOo0.__.()).BeginInit();
			this.O0OoOo0.__.().Panel1.SuspendLayout();
			this.O0OoOo0.__.().Panel2.SuspendLayout();
			this.O0OoOo0.__.().SuspendLayout();
			((ISupportInitialize)this.OO_O0o.00.()).BeginInit();
			((ISupportInitialize)this.o.oo__.()).BeginInit();
			((ISupportInitialize)this.o.oOOoOO.()).BeginInit();
			((ISupportInitialize)this.Oo_._Ooooo00o.()).BeginInit();
			base.SuspendLayout();
			this.O0OoOo0.__.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O0OoOo0.__.().FormattingEnabled = true;
			this.O0OoOo0.__.().IntegralHeight = false;
			this.O0OoOo0.__.().ItemHeight = 12;
			this.O0OoOo0.__.().Location = new Point(3, 3);
			this.O0OoOo0.__.().Name = "ListBox1";
			this.O0OoOo0.__.().Size = new Size(215, 462);
			this.O0OoOo0.__.().TabIndex = 0;
			this.O0OoOo0.__.().Dock = DockStyle.Fill;
			this.O0OoOo0.__.().FixedPanel = FixedPanel.Panel1;
			this.O0OoOo0.__.().Location = new Point(0, 0);
			this.O0OoOo0.__.().Name = "SplitContainer1";
			this.O0OoOo0.__.().Panel1.Controls.Add(this.OO_O0o.00.());
			this.O0OoOo0.__.().Panel1.Controls.Add(this.o.oo__.());
			this.O0OoOo0.__.().Panel1.Controls.Add(this.o.oOOoOO.());
			this.O0OoOo0.__.().Panel1.Controls.Add(this.O0OoOo0.__.());
			this.O0OoOo0.__.().Panel2.Controls.Add(this.o.oo__.());
			this.O0OoOo0.__.().Panel2.Controls.Add(this.Oo_._Ooooo00o.());
			this.O0OoOo0.__.().Size = new Size(924, 502);
			this.O0OoOo0.__.().SplitterDistance = 219;
			this.O0OoOo0.__.().TabIndex = 1;
			this.OO_O0o.00.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.OO_O0o.00.().Location = new Point(145, 472);
			this.OO_O0o.00.().Name = "Button3";
			this.OO_O0o.00.().Size = new Size(65, 23);
			this.OO_O0o.00.().TabIndex = 3;
			this.OO_O0o.00.().Text = "重命名";
			this.OO_O0o.00.().UseVisualStyleBackColor = true;
			this.o.oo__.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o.oo__.().Location = new Point(74, 472);
			this.o.oo__.().Name = "Button2";
			this.o.oo__.().Size = new Size(65, 23);
			this.o.oo__.().TabIndex = 2;
			this.o.oo__.().Text = "删除";
			this.o.oo__.().UseVisualStyleBackColor = true;
			this.o.oOOoOO.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o.oOOoOO.().Location = new Point(3, 472);
			this.o.oOOoOO.().Name = "Button1";
			this.o.oOOoOO.().Size = new Size(65, 23);
			this.o.oOOoOO.().TabIndex = 1;
			this.o.oOOoOO.().Text = "增加";
			this.o.oOOoOO.().UseVisualStyleBackColor = true;
			this.o.oo__.().AllowDrop = true;
			this.o.oo__.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.o.oo__.().Location = new Point(0, 3);
			this.o.oo__.().Name = "FoxSyntaxEditor1";
			this.o.oo__.().PrintSettings.AreColumnGuidesVisible = false;
			this.o.oo__.().Size = new Size(698, 462);
			this.o.oo__.().TabIndex = 5;
			this.Oo_._Ooooo00o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.Oo_._Ooooo00o.().Location = new Point(624, 471);
			this.Oo_._Ooooo00o.().Name = "Button4";
			this.Oo_._Ooooo00o.().Size = new Size(74, 23);
			this.Oo_._Ooooo00o.().TabIndex = 4;
			this.Oo_._Ooooo00o.().Text = "编辑代码";
			this.Oo_._Ooooo00o.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(924, 502);
			base.Controls.Add(this.O0OoOo0.__.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O0o.o0..0.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "全局代码管理器";
			this.O0OoOo0.__.().Panel1.ResumeLayout(false);
			this.O0OoOo0.__.().Panel2.ResumeLayout(false);
			((ISupportInitialize)this.O0OoOo0.__.()).EndInit();
			this.O0OoOo0.__.().ResumeLayout(false);
			((ISupportInitialize)this.OO_O0o.00.()).EndInit();
			((ISupportInitialize)this.o.oo__.()).EndInit();
			((ISupportInitialize)this.o.oOOoOO.()).EndInit();
			((ISupportInitialize)this.Oo_._Ooooo00o.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00053D05 File Offset: 0x00051F05
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.Ooo_._o__00OO0.;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00053D10 File Offset: 0x00051F10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.O0O00.Oo00oo.);
			EventHandler value2 = new EventHandler(this.O0OoOo0.__.);
			ListBox ooo_._o__00OO0. = this.Ooo_._o__00OO0.;
			if (ooo_._o__00OO0. != null)
			{
				ooo_._o__00OO0..MouseDoubleClick -= value;
				ooo_._o__00OO0..SelectedValueChanged -= value2;
			}
			this.Ooo_._o__00OO0. = A_0;
			ooo_._o__00OO0. = this.Ooo_._o__00OO0.;
			if (ooo_._o__00OO0. != null)
			{
				ooo_._o__00OO0..MouseDoubleClick += value;
				ooo_._o__00OO0..SelectedValueChanged += value2;
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00053D6E File Offset: 0x00051F6E
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.Ooo_._o__00OO0.;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00053D76 File Offset: 0x00051F76
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.Ooo_._o__00OO0. = A_0;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00053D7F File Offset: 0x00051F7F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Ooo_._o__00OO0.;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00053D88 File Offset: 0x00051F88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO_O0o.00.);
			C1Button ooo_._o__00OO0. = this.Ooo_._o__00OO0.;
			if (ooo_._o__00OO0. != null)
			{
				ooo_._o__00OO0..Click -= value;
			}
			this.Ooo_._o__00OO0. = A_0;
			ooo_._o__00OO0. = this.Ooo_._o__00OO0.;
			if (ooo_._o__00OO0. != null)
			{
				ooo_._o__00OO0..Click += value;
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00053DCB File Offset: 0x00051FCB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0.OO_.;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00053DD4 File Offset: 0x00051FD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO.o0O0__.);
			C1Button c1Button = this.o0.OO_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0.OO_. = A_0;
			c1Button = this.o0.OO_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00053E17 File Offset: 0x00052017
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Ooo00o0_o000.O.;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00053E20 File Offset: 0x00052020
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_0o.O00Oo.);
			C1Button ooo00o0_o000.O. = this.Ooo00o0_o000.O.;
			if (ooo00o0_o000.O. != null)
			{
				ooo00o0_o000.O..Click -= value;
			}
			this.Ooo00o0_o000.O. = A_0;
			ooo00o0_o000.O. = this.Ooo00o0_o000.O.;
			if (ooo00o0_o000.O. != null)
			{
				ooo00o0_o000.O..Click += value;
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00053E63 File Offset: 0x00052063
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_o_0O00_0.Oo0.;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00053E6C File Offset: 0x0005206C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO_OOoo._o.);
			C1Button o_o_0O00_0.Oo0. = this.O_o_0O00_0.Oo0.;
			if (o_o_0O00_0.Oo0. != null)
			{
				o_o_0O00_0.Oo0..Click -= value;
			}
			this.O_o_0O00_0.Oo0. = A_0;
			o_o_0O00_0.Oo0. = this.O_o_0O00_0.Oo0.;
			if (o_o_0O00_0.Oo0. != null)
			{
				o_o_0O00_0.Oo0..Click += value;
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00053EAF File Offset: 0x000520AF
		[CompilerGenerated]
		internal virtual O_o00o_ <<EMPTY_NAME>>()
		{
			return this.Ooo_._o__00OO0.;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00053EB8 File Offset: 0x000520B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(O_o00o_ A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.o.oo__.);
			O_o00o_ ooo_._o__00OO0. = this.Ooo_._o__00OO0.;
			if (ooo_._o__00OO0. != null)
			{
				ooo_._o__00OO0..MouseWheel -= value;
			}
			this.Ooo_._o__00OO0. = A_0;
			ooo_._o__00OO0. = this.Ooo_._o__00OO0.;
			if (ooo_._o__00OO0. != null)
			{
				ooo_._o__00OO0..MouseWheel += value;
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00053EFC File Offset: 0x000520FC
		public O\u3002\u30000()
		{
			base.Load += this.o0O0_0_.OooO0.;
			base.FormClosed += this.o.oo__.;
			this.O0OoOo0.__.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o.oo__.().Document.IsReadOnly = true;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00053F60 File Offset: 0x00052160
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
				this.o.oo__.().o0o_O_._. = false;
				IL_15:
				num2 = 3;
				this.o.oo__.().o_.0ooOooOoo00.("Public Module UserCode");
				IL_27:
				num2 = 4;
				this.o.oo__.().OOoO.o.("End Module");
				IL_39:
				num2 = 5;
				this.o.oo__.().O0O._O_oOo0O_.();
				IL_46:
				num2 = 6;
				this.o.oo__.().Oo000.0O.();
				IL_53:
				num2 = 7;
				this.o.oo__.().Document.IsReadOnly = true;
				IL_66:
				num2 = 8;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"Default",
					o0_O.Oo0o0o.Oo_00_.
				});
				IL_9F:
				num2 = 9;
				if (dataRow != null)
				{
					goto IL_1B4;
				}
				IL_A8:
				num2 = 10;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"API",
					o0_O.Oo0o0o.Oo_00_.
				});
				IL_E2:
				num2 = 11;
				if (dataRow == null)
				{
					goto IL_11D;
				}
				IL_E8:
				num2 = 12;
				dataRow["Name"] = "Default";
				IL_FB:
				num2 = 13;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				goto IL_1B4;
				IL_11D:
				num2 = 15;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_13A:
				num2 = 16;
				dataRow["Name"] = "Default";
				IL_14D:
				num2 = 17;
				dataRow["Type"] = o0_O.Oo0o0o.Oo_00_.;
				IL_162:
				num2 = 18;
				dataRow["Config"] = "";
				IL_175:
				num2 = 19;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
				IL_197:
				num2 = 20;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_1B4:
				num2 = 21;
				DataView dataSource = new DataView(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], "[Type] = " + Conversions.ToString(19), "", DataViewRowState.CurrentRows);
				IL_1EA:
				num2 = 22;
				this.O0OoOo0.__.().DisplayMember = "Name";
				IL_1FD:
				num2 = 23;
				this.O0OoOo0.__.().ValueMember = "Name";
				IL_210:
				num2 = 24;
				this.O0OoOo0.__.().DataSource = dataSource;
				IL_220:
				goto IL_2D6;
				IL_225:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_297:
				goto IL_2CB;
				IL_299:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2A9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_299;
			}
			IL_2CB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2D6:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00054268 File Offset: 0x00052468
		internal void <<EMPTY_NAME>>(o\u3000\u3000 A_0, ValidateInputTextEventArgs A_1)
		{
			if (Operators.CompareString(A_1.Value, "", true) == 0)
			{
				MessageBox.Show("请输入全局模块名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
				return;
			}
			if (Operators.CompareString(A_1.Value, "API", true) == 0 || Operators.CompareString(A_1.Value, "Default", true) == 0)
			{
				MessageBox.Show("无效全局模块名称，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
				return;
			}
			if (Operators.CompareString(A_1.Value, A_1.OriginalValue, true) != 0 && O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
			{
				A_1.Value,
				o0_O.Oo0o0o.Oo_00_.
			}) != null)
			{
				MessageBox.Show("已经存在同名全局模块，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0005434C File Offset: 0x0005254C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o\u3000\u3000 o_u3000_u = new o\u3000\u3000("增加全局模块", "请输入全局模块名称:", "");
			o_u3000_u.Oo.__0o_0_Oo.(new o\u3000\u3000.ooOOO_O_Oo_0(this.Ooo_._o__00OO0.));
			if (o_u3000_u.ShowDialog() == DialogResult.OK)
			{
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				dataRow["Name"] = o_u3000_u.Value;
				dataRow["Type"] = o0_O.Oo0o0o.Oo_00_.;
				dataRow["Config"] = "";
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(dataRow);
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				this.O0OoOo0.__.().SelectedIndex = this.O0OoOo0.__.().Items.Count - 1;
				this.oO0Ooo.00O_. = true;
			}
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00054438 File Offset: 0x00052638
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0OoOo0.__.().SelectedItem != null)
			{
				if (Operators.CompareString(this.O0OoOo0.__.().SelectedValue.ToString(), "Default", true) == 0)
				{
					MessageBox.Show("不能删除Default全局模块!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (MessageBox.Show("确定要删除选定的全局模块吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					((DataRowView)this.O0OoOo0.__.().SelectedItem).Delete();
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
					this.oO0Ooo.00O_. = true;
				}
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000544D0 File Offset: 0x000526D0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0OoOo0.__.().SelectedItem != null)
			{
				if (Operators.CompareString(this.O0OoOo0.__.().SelectedValue.ToString(), "Default", true) == 0)
				{
					MessageBox.Show("不能重命名Default全局模块!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				DataRow row = ((DataRowView)this.O0OoOo0.__.().SelectedItem).Row;
				o\u3000\u3000 o_u3000_u = new o\u3000\u3000("重命名", "请输入全局模块名称:", this.O0OoOo0.__.().SelectedValue.ToString());
				o_u3000_u.Oo.__0o_0_Oo.(new o\u3000\u3000.ooOOO_O_Oo_0(this.Ooo_._o__00OO0.));
				if (o_u3000_u.ShowDialog() == DialogResult.OK)
				{
					row["Name"] = o_u3000_u.Value;
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
					this.oO0Ooo.00O_. = true;
				}
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000545A1 File Offset: 0x000527A1
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			this.Oo_._Ooooo00o.().PerformClick();
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000545B0 File Offset: 0x000527B0
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
				if (this.O0OoOo0.__.().SelectedItem == null)
				{
					goto IL_1D1;
				}
				IL_19:
				num2 = 4;
				DataRow row = ((DataRowView)this.O0OoOo0.__.().SelectedItem).Row;
				IL_31:
				num2 = 5;
				string text = row["Config"].ToString();
				IL_45:
				num2 = 6;
				string a_ = O_O0OO.O_O._Oo.();
				IL_4E:
				num2 = 7;
				if (!text.StartsWith("[") || !text.EndsWith("]"))
				{
					goto IL_B4;
				}
				IL_6C:
				num2 = 8;
				text = text.TrimStart(new char[]
				{
					'['
				}).TrimEnd(new char[]
				{
					']'
				});
				IL_92:
				num2 = 9;
				a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
				IL_B4:
				num2 = 10;
				text = O00.oO_.0o_oo_0O_.(text, "API", a_);
				IL_C7:
				num2 = 11;
				O\u3000\u3002\u3000\u3000 o_u3000_u3002_u3000_u = new O\u3000\u3002\u3000\u3000("Global", row["Name"].ToString(), null);
				IL_E7:
				num2 = 12;
				o_u3000_u3002_u3000_u.O0O0.0__o0.(text);
				IL_F3:
				num2 = 13;
				if (o_u3000_u3002_u3000_u.ShowDialog() != DialogResult.OK || Operators.CompareString(o_u3000_u3002_u3000_u.O.O_0o_Oo_.(), text, true) == 0)
				{
					goto IL_1D1;
				}
				IL_117:
				num2 = 14;
				a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
				IL_139:
				num2 = 15;
				if (Operators.CompareString(o_u3000_u3002_u3000_u.O.O_0o_Oo_.(), "", true) != 0)
				{
					goto IL_165;
				}
				IL_150:
				num2 = 16;
				row["Config"] = "";
				goto IL_195;
				IL_165:
				num2 = 18;
				row["Config"] = "[" + O00.ooo000o_0.00o0.(o_u3000_u3002_u3000_u.O.O_0o_Oo_.(), "API", a_) + "]";
				IL_195:
				num2 = 19;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_1B2:
				num2 = 20;
				this.oO0Ooo.00O_. = true;
				IL_1BC:
				num2 = 21;
				this.o.oo__.().Text = o_u3000_u3002_u3000_u.O.O_0o_Oo_.();
				IL_1D1:
				goto IL_27B;
				IL_1D6:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_23C:
				goto IL_270;
				IL_23E:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_24E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_23E;
			}
			IL_270:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_27B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0005485C File Offset: 0x00052A5C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0OoOo0.__.().SelectedItem == null)
			{
				this.o.oo__.().Text = "";
				return;
			}
			string text = ((DataRowView)this.O0OoOo0.__.().SelectedItem).Row["Config"].ToString();
			string a_ = O_O0OO.O_O._Oo.();
			if (text.StartsWith("[") && text.EndsWith("]"))
			{
				text = text.TrimStart(new char[]
				{
					'['
				}).TrimEnd(new char[]
				{
					']'
				});
				a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
			}
			text = O00.oO_.0o_oo_0O_.(text, "API", a_);
			this.o.oo__.().Text = text;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00054925 File Offset: 0x00052B25
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00054938 File Offset: 0x00052B38
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (OO_00oOO.ModifierKey == Keys.Control)
			{
				float num;
				if (A_1.Delta > 0)
				{
					num = this.o.oo__.().Font.Size + 1f;
				}
				else
				{
					num = this.o.oo__.().Font.Size - 1f;
				}
				num = Math.Min(Math.Max(6f, num), 30f);
				this.o.oo__.().Font = new Font(this.o.oo__.().Font.Name, num);
				this.o.oo__.().ActiveView.Scroller.ScrollToCaret();
			}
		}

		// Token: 0x040003B2 RID: 946
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040003B3 RID: 947
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x040003B4 RID: 948
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x040003B5 RID: 949
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003B6 RID: 950
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003B7 RID: 951
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003B8 RID: 952
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003B9 RID: 953
		[CompilerGenerated]
		private O_o00o_ <<EMPTY_NAME>>;

		// Token: 0x040003BA RID: 954
		internal bool <<EMPTY_NAME>>;
	}
}
