using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200034A RID: 842
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3000\u3002\u3002\u3000\u3000_ : Form
	{
		// Token: 0x06003391 RID: 13201 RVA: 0x00160980 File Offset: 0x0015EB80
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O__.__O_. != null)
				{
					this.O__.__O_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x001609C0 File Offset: 0x0015EBC0
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_OoOo00o0.ooO.(new C1CheckBox());
			this.oO_O._.(new C1CheckBox());
			this.oO_O0.0o.(new C1CheckBox());
			this.oO_O0.0o.(new GroupBox());
			this.O._oO__OOOO.(new C1CheckBox());
			this.oO_O0.0o.(new C1Button());
			this.O._oO__OOOO.(new C1Button());
			this.o_O0Ooo0O_.O.(new Label());
			this.o_O0Ooo0O_.O.(new C1TextBox());
			this.o__o.OOo0oO.().SuspendLayout();
			base.SuspendLayout();
			this.o__o.OOo0oO.().AutoSize = true;
			this.o__o.OOo0oO.().Checked = true;
			this.o__o.OOo0oO.().CheckState = CheckState.Checked;
			this.o__o.OOo0oO.().Location = new Point(13, 42);
			this.o__o.OOo0oO.().Name = "chkVisibleOnly";
			this.o__o.OOo0oO.().Size = new Size(72, 16);
			this.o__o.OOo0oO.().TabIndex = 1;
			this.o__o.OOo0oO.().Text = "仅可见列";
			this.o__o.OOo0oO.().UseVisualStyleBackColor = true;
			this.Oo_O.oO_0.().AutoSize = true;
			this.Oo_O.oO_0.().Location = new Point(13, 65);
			this.Oo_O.oO_0.().Name = "chkSaveMergedRanges";
			this.Oo_O.oO_0.().Size = new Size(96, 16);
			this.Oo_O.oO_0.().TabIndex = 3;
			this.Oo_O.oO_0.().Text = "保存合并设置";
			this.Oo_O.oO_0.().UseVisualStyleBackColor = true;
			this.OOO.oO.().AutoSize = true;
			this.OOO.oO.().Location = new Point(13, 88);
			this.OOO.oO.().Name = "chkAsDisplayed";
			this.OOO.oO.().Size = new Size(96, 16);
			this.OOO.oO.().TabIndex = 4;
			this.OOO.oO.().Text = "保存格式设置";
			this.OOO.oO.().UseVisualStyleBackColor = true;
			this.o__o.OOo0oO.().Controls.Add(this.O0O0OOo_o0.o00.());
			this.o__o.OOo0oO.().Controls.Add(this.OOO.oO.());
			this.o__o.OOo0oO.().Controls.Add(this.o__o.OOo0oO.());
			this.o__o.OOo0oO.().Controls.Add(this.Oo_O.oO_0.());
			this.o__o.OOo0oO.().Location = new Point(10, 12);
			this.o__o.OOo0oO.().Name = "GroupBox1";
			this.o__o.OOo0oO.().Size = new Size(186, 123);
			this.o__o.OOo0oO.().TabIndex = 5;
			this.o__o.OOo0oO.().TabStop = false;
			this.o__o.OOo0oO.().Text = "选项";
			this.O0O0OOo_o0.o00.().AutoSize = true;
			this.O0O0OOo_o0.o00.().Location = new Point(13, 19);
			this.O0O0OOo_o0.o00.().Name = "chkIncludeRowNumber";
			this.O0O0OOo_o0.o00.().Size = new Size(84, 16);
			this.O0O0OOo_o0.o00.().TabIndex = 5;
			this.O0O0OOo_o0.o00.().Text = "包括行号列";
			this.O0O0OOo_o0.o00.().UseVisualStyleBackColor = true;
			this.OOO.oO.().Location = new Point(23, 212);
			this.OOO.oO.().Name = "Button1";
			this.OOO.oO.().Size = new Size(75, 23);
			this.OOO.oO.().TabIndex = 6;
			this.OOO.oO.().Text = "确定";
			this.OOO.oO.().UseVisualStyleBackColor = true;
			this.o__o.OOo0oO.().DialogResult = DialogResult.Cancel;
			this.o__o.OOo0oO.().Location = new Point(104, 212);
			this.o__o.OOo0oO.().Name = "Button2";
			this.o__o.OOo0oO.().Size = new Size(75, 23);
			this.o__o.OOo0oO.().TabIndex = 7;
			this.o__o.OOo0oO.().Text = "取消";
			this.o__o.OOo0oO.().UseVisualStyleBackColor = true;
			this.oO_O0.0o.().AutoSize = true;
			this.oO_O0.0o.().Location = new Point(8, 152);
			this.oO_O0.0o.().Name = "Label1";
			this.oO_O0.0o.().Size = new Size(59, 12);
			this.oO_O0.0o.().TabIndex = 8;
			this.oO_O0.0o.().Text = "目标表名:";
			this.oO_O0.0o.().Location = new Point(11, 171);
			this.oO_O0.0o.().Name = "txtName";
			this.oO_O0.0o.().Size = new Size(181, 21);
			this.oO_O0.0o.().TabIndex = 9;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(212, 255);
			base.Controls.Add(this.oO_O0.0o.());
			base.Controls.Add(this.oO_O0.0o.());
			base.Controls.Add(this.o__o.OOo0oO.());
			base.Controls.Add(this.OOO.oO.());
			base.Controls.Add(this.o__o.OOo0oO.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.o....o";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "导出Excel";
			this.o__o.OOo0oO.().ResumeLayout(false);
			this.o__o.OOo0oO.().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x00160F2D File Offset: 0x0015F12D
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o_O0Ooo0O_.O.;
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00160F35 File Offset: 0x0015F135
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o_O0Ooo0O_.O. = A_0;
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00160F3E File Offset: 0x0015F13E
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.OO.0o0.;
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00160F46 File Offset: 0x0015F146
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.OO.0o0. = A_0;
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00160F4F File Offset: 0x0015F14F
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.oO00o._.;
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00160F57 File Offset: 0x0015F157
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.oO00o._. = A_0;
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00160F60 File Offset: 0x0015F160
		[CompilerGenerated]
		internal virtual GroupBox <<EMPTY_NAME>>()
		{
			return this.o_O0Ooo0O_.O.;
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x00160F68 File Offset: 0x0015F168
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(GroupBox A_0)
		{
			this.o_O0Ooo0O_.O. = A_0;
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x00160F71 File Offset: 0x0015F171
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_O0Ooo0O_.O.;
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x00160F7C File Offset: 0x0015F17C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o__o.OOo0oO.);
			C1Button c1Button = this.o_O0Ooo0O_.O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_O0Ooo0O_.O. = A_0;
			c1Button = this.o_O0Ooo0O_.O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x00160FBF File Offset: 0x0015F1BF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO.0o0.;
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00160FC7 File Offset: 0x0015F1C7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.OO.0o0. = A_0;
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00160FD0 File Offset: 0x0015F1D0
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_O0Ooo0O_.O.;
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00160FD8 File Offset: 0x0015F1D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_O0Ooo0O_.O. = A_0;
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x00160FE1 File Offset: 0x0015F1E1
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O__.__O_.;
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x00160FE9 File Offset: 0x0015F1E9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O__.__O_. = A_0;
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x00160FF2 File Offset: 0x0015F1F2
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.ooO.oOo.;
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x00160FFA File Offset: 0x0015F1FA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.ooO.oOo. = A_0;
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00161004 File Offset: 0x0015F204
		public O\u3002\u3002\u3000\u3002\u3002\u3000\u3000_(string A_0)
		{
			base.FormClosed += this.o__o.OOo0oO.;
			this.oO_O0.0o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.O__.__O_. = A_0;
			this.oO_O0.0o.().Value = OO_00oOO.CurrentTable.DataTable.BaseTable.TableName;
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x0016106C File Offset: 0x0015F26C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			SaveExcelFlags saveExcelFlags = new SaveExcelFlags();
			saveExcelFlags.CellStyle = this.OOO.oO.().Checked;
			saveExcelFlags.MergedRanges = this.Oo_O.oO_0.().Checked;
			saveExcelFlags.VisibleOnly = this.o__o.OOo0oO.().Checked;
			saveExcelFlags.RowNumber = this.O0O0OOo_o0.o00.().Checked;
			OO_00oOO.CurrentTable.SaveExcel(this.O__.__O_., this.oO_O0.0o.().Text, saveExcelFlags);
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x001610E6 File Offset: 0x0015F2E6
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040014B2 RID: 5298
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040014B3 RID: 5299
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040014B4 RID: 5300
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040014B5 RID: 5301
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040014B6 RID: 5302
		[CompilerGenerated]
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x040014B7 RID: 5303
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014B8 RID: 5304
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014B9 RID: 5305
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040014BA RID: 5306
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040014BB RID: 5307
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040014BC RID: 5308
		private string <<EMPTY_NAME>>;
	}
}
