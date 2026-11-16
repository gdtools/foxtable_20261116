using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200034E RID: 846
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3002\u3002\u3000\u3000 : Form
	{
		// Token: 0x060033E1 RID: 13281 RVA: 0x00163014 File Offset: 0x00161214
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OO.O0O__0oOO0o. != null)
				{
					this.OO.O0O__0oOO0o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x00163054 File Offset: 0x00161254
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o.OOoO_Ooo.(new C1Button());
			this.O_0___O00.00.(new C1Button());
			this.OO.O0O__0oOO0o.(new C1TextBox());
			this.oOOo.O_0.(new Label());
			this.o.OOoO_Ooo.(new Label());
			this.oOOo.O_0.(new C1Button());
			((ISupportInitialize)this.O0_00O_o.__o.()).BeginInit();
			((ISupportInitialize)this.oOOo.O_0.()).BeginInit();
			((ISupportInitialize)this.o.OOoO_Ooo.()).BeginInit();
			((ISupportInitialize)this.Oo_0_0.oo.()).BeginInit();
			base.SuspendLayout();
			this.O0_00O_o.__o.().DialogResult = DialogResult.OK;
			this.O0_00O_o.__o.().Location = new Point(273, 24);
			this.O0_00O_o.__o.().Margin = new Padding(4, 4, 4, 4);
			this.O0_00O_o.__o.().Name = "btnOK";
			this.O0_00O_o.__o.().Size = new Size(112, 34);
			this.O0_00O_o.__o.().TabIndex = 5;
			this.O0_00O_o.__o.().Text = "确定";
			this.O0_00O_o.__o.().UseVisualStyleBackColor = true;
			this.oOOo.O_0.().DialogResult = DialogResult.Cancel;
			this.oOOo.O_0.().Location = new Point(273, 63);
			this.oOOo.O_0.().Margin = new Padding(4, 4, 4, 4);
			this.oOOo.O_0.().Name = "Button2";
			this.oOOo.O_0.().Size = new Size(112, 34);
			this.oOOo.O_0.().TabIndex = 6;
			this.oOOo.O_0.().Text = "取消";
			this.oOOo.O_0.().UseVisualStyleBackColor = true;
			this.o.OOoO_Ooo.().DataType = typeof(int);
			this.o.OOoO_Ooo.().Location = new Point(28, 72);
			this.o.OOoO_Ooo.().Margin = new Padding(4, 4, 4, 4);
			this.o.OOoO_Ooo.().Name = "txtColWidth";
			this.o.OOoO_Ooo.().Size = new Size(150, 26);
			this.o.OOoO_Ooo.().TabIndex = 2;
			this.o.OOoO_Ooo.().Tag = null;
			this.o.OOoO_Ooo.().AutoSize = true;
			this.o.OOoO_Ooo.().Location = new Point(26, 32);
			this.o.OOoO_Ooo.().Margin = new Padding(4, 0, 4, 0);
			this.o.OOoO_Ooo.().Name = "Label1";
			this.o.OOoO_Ooo.().Size = new Size(53, 18);
			this.o.OOoO_Ooo.().TabIndex = 7;
			this.o.OOoO_Ooo.().Text = "列宽:";
			this.oOOo.O_0.().AutoSize = true;
			this.oOOo.O_0.().Location = new Point(188, 76);
			this.oOOo.O_0.().Margin = new Padding(4, 0, 4, 0);
			this.oOOo.O_0.().Name = "Label2";
			this.oOOo.O_0.().Size = new Size(62, 18);
			this.oOOo.O_0.().TabIndex = 8;
			this.oOOo.O_0.().Text = "(像素)";
			this.Oo_0_0.oo.().DialogResult = DialogResult.OK;
			this.Oo_0_0.oo.().Location = new Point(273, 102);
			this.Oo_0_0.oo.().Margin = new Padding(4, 4, 4, 4);
			this.Oo_0_0.oo.().Name = "Button1";
			this.Oo_0_0.oo.().Size = new Size(112, 34);
			this.Oo_0_0.oo.().TabIndex = 9;
			this.Oo_0_0.oo.().Text = "最佳列宽";
			this.Oo_0_0.oo.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(412, 159);
			base.Controls.Add(this.Oo_0_0.oo.());
			base.Controls.Add(this.oOOo.O_0.());
			base.Controls.Add(this.o.OOoO_Ooo.());
			base.Controls.Add(this.o.OOoO_Ooo.());
			base.Controls.Add(this.oOOo.O_0.());
			base.Controls.Add(this.O0_00O_o.__o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(4, 4, 4, 4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oI0.0.l.";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "列宽";
			((ISupportInitialize)this.O0_00O_o.__o.()).EndInit();
			((ISupportInitialize)this.oOOo.O_0.()).EndInit();
			((ISupportInitialize)this.o.OOoO_Ooo.()).EndInit();
			((ISupportInitialize)this.Oo_0_0.oo.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x001634DE File Offset: 0x001616DE
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO.O0O__0oOO0o.;
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x001634E8 File Offset: 0x001616E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO.oooOOo.);
			C1Button oo.O0O__0oOO0o. = this.OO.O0O__0oOO0o.;
			if (oo.O0O__0oOO0o. != null)
			{
				oo.O0O__0oOO0o..Click -= value;
			}
			this.OO.O0O__0oOO0o. = A_0;
			oo.O0O__0oOO0o. = this.OO.O0O__0oOO0o.;
			if (oo.O0O__0oOO0o. != null)
			{
				oo.O0O__0oOO0o..Click += value;
			}
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x0016352B File Offset: 0x0016172B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO_.oOO.;
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00163533 File Offset: 0x00161733
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oO_.oOO. = A_0;
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x0016353C File Offset: 0x0016173C
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.OO.O0O__0oOO0o.;
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x00163544 File Offset: 0x00161744
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.OO.O0O__0oOO0o. = A_0;
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x0016354D File Offset: 0x0016174D
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OO.O0O__0oOO0o.;
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x00163555 File Offset: 0x00161755
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OO.O0O__0oOO0o. = A_0;
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x0016355E File Offset: 0x0016175E
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oO_.oOO.;
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x00163566 File Offset: 0x00161766
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oO_.oOO. = A_0;
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x0016356F File Offset: 0x0016176F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo_.0ooO.;
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00163578 File Offset: 0x00161778
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0_00O_o.__o.);
			C1Button c1Button = this.oo_.0ooO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo_.0ooO. = A_0;
			c1Button = this.oo_.0ooO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x001635BC File Offset: 0x001617BC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.OOoO_Ooo.().Value = this.OO.O0O__0oOO0o..Cols[this.OO.O0O__0oOO0o..Col].WidthDisplay.ToString();
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x001635FC File Offset: 0x001617FC
		public O\u3002\u3002\u3002\u3002\u3000\u3000(Table A_0)
		{
			base.Load += this.Oo_0_0.oo.;
			base.FormClosed += this.O0_00O_o.__o.;
			this.o.OOoO_Ooo.();
			this.OO.O0O__0oOO0o. = A_0.foxGrid;
			this.OO.O0O__0oOO0o. = A_0;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x00163664 File Offset: 0x00161864
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int leftCol = this.OO.O0O__0oOO0o..Selection.LeftCol;
			int rightCol = this.OO.O0O__0oOO0o..Selection.RightCol;
			this.OO.O0O__0oOO0o..O_o0OOo_.o0..O__00.__0_O.(new OoO_oO(this.OO.O0O__0oOO0o.));
			int num = (int)Math.Round(Conversion.Val(this.o.OOoO_Ooo.().Text));
			if (num > 0)
			{
				int num2 = leftCol;
				int num3 = rightCol;
				for (int i = num2; i <= num3; i++)
				{
					if (this.OO.O0O__0oOO0o..Cols[i].Visible)
					{
						this.OO.O0O__0oOO0o..Cols[i].Width = num;
					}
				}
			}
			this.OO.O0O__0oOO0o..NeedSaveSetting = true;
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x00163720 File Offset: 0x00161920
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int leftCol = this.OO.O0O__0oOO0o..Selection.LeftCol;
			int rightCol = this.OO.O0O__0oOO0o..Selection.RightCol;
			this.OO.O0O__0oOO0o..O_o0OOo_.o0..O__00.__0_O.(new OoO_oO(this.OO.O0O__0oOO0o.));
			int num = rightCol;
			for (int i = leftCol; i <= num; i++)
			{
				if (this.OO.O0O__0oOO0o..Cols[i].Visible)
				{
					this.OO.O0O__0oOO0o..AutoSizeCol(i, 2);
				}
			}
			this.OO.O0O__0oOO0o..NeedSaveSetting = true;
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x001637AD File Offset: 0x001619AD
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040014D6 RID: 5334
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040014D7 RID: 5335
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014D8 RID: 5336
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014D9 RID: 5337
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040014DA RID: 5338
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040014DB RID: 5339
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040014DC RID: 5340
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014DD RID: 5341
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040014DE RID: 5342
		private Table <<EMPTY_NAME>>;
	}
}
