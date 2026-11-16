using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000402 RID: 1026
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class o\u3002\u3002\u3002\u3000\u3002 : Form
	{
		// Token: 0x06004205 RID: 16901 RVA: 0x001E68E8 File Offset: 0x001E4AE8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o._O0o_. != null)
				{
					this.o._O0o_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x001E6928 File Offset: 0x001E4B28
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oOo_O__.o0oO.(new C1Button());
			this.o_o0.__.(new C1Button());
			this.OO0OO_o.OOOo.(new GroupBox());
			this.o0.oo0oO00_O_.(new Label());
			this.OO0OO_o.OOOo.(new C1ComboBox());
			this.O0O_oOO.OOO.(new Label());
			this.o_o0.__.(new C1ComboBox());
			this.ooo00_OOOO._0O.(new Label());
			this.oOo_O__.o0oO.(new C1ComboBox());
			this.oOo_O__.o0oO.(new GroupBox());
			this.ooo0O0Oo_.O0OO.(new C1TextBox());
			this.OO.O_OO_o.(new Label());
			this.O0__._O__O_oo.(new C1TextBox());
			this.O0_.__OOO_.(new Label());
			this.Oooo0.OOO.(new C1TextBox());
			this.O._O_o.(new Label());
			this.O._0O0Oo.(new C1TextBox());
			this.o00OOOooO0.0__.(new Label());
			this.O0.oo_oo0_o_0_.(new GroupBox());
			this.OO.O_OO_o.(new RadioButton());
			this.o.o__O0.(new RadioButton());
			this.o_o0.__.(new GroupBox());
			this.oooO0.0.(new C1TextBox());
			this.OOooOoo.0.(new Label());
			this.oooo.0.(new C1TextBox());
			this.o.o__O0.(new Label());
			this.O.O_o_0_oo_0_O.().SuspendLayout();
			this.Oo.O_0__oOo_.().SuspendLayout();
			this.ooo__0oO_._O_.().SuspendLayout();
			this.OO00_0_0_.O.().SuspendLayout();
			base.SuspendLayout();
			this.ooo__0oO_._O_.().Location = new Point(114, 328);
			this.ooo__0oO_._O_.().Name = "btnOK";
			this.ooo__0oO_._O_.().Size = new Size(75, 23);
			this.ooo__0oO_._O_.().TabIndex = 8;
			this.ooo__0oO_._O_.().Text = "确定";
			this.ooo__0oO_._O_.().UseVisualStyleBackColor = true;
			this.ooo0Oo__.0_o_o.().DialogResult = DialogResult.Cancel;
			this.ooo0Oo__.0_o_o.().Location = new Point(195, 328);
			this.ooo0Oo__.0_o_o.().Name = "Button2";
			this.ooo0Oo__.0_o_o.().Size = new Size(75, 23);
			this.ooo0Oo__.0_o_o.().TabIndex = 9;
			this.ooo0Oo__.0_o_o.().Text = "取消";
			this.ooo0Oo__.0_o_o.().UseVisualStyleBackColor = true;
			this.O.O_o_0_oo_0_O.().Controls.Add(this.oO.o0_O0_.());
			this.O.O_o_0_oo_0_O.().Controls.Add(this.ooo__0oO_._O_.());
			this.O.O_o_0_oo_0_O.().Controls.Add(this.o_0O_0_oOoo.OO.());
			this.O.O_o_0_oo_0_O.().Controls.Add(this.ooo0Oo__.0_o_o.());
			this.O.O_o_0_oo_0_O.().Controls.Add(this.o0o.0O0o0.());
			this.O.O_o_0_oo_0_O.().Controls.Add(this.OO00_0_0_.O.());
			this.O.O_o_0_oo_0_O.().Location = new Point(16, 12);
			this.O.O_o_0_oo_0_O.().Name = "GroupBox8";
			this.O.O_o_0_oo_0_O.().Size = new Size(353, 112);
			this.O.O_o_0_oo_0_O.().TabIndex = 10;
			this.O.O_o_0_oo_0_O.().TabStop = false;
			this.O.O_o_0_oo_0_O.().Text = "纸张";
			this.oO.o0_O0_.().AutoSize = true;
			this.oO.o0_O0_.().Location = new Point(19, 24);
			this.oO.o0_O0_.().Name = "Label9";
			this.oO.o0_O0_.().Size = new Size(47, 12);
			this.oO.o0_O0_.().TabIndex = 6;
			this.oO.o0_O0_.().Text = "打印机:";
			this.ooo__0oO_._O_.().DropDownStyle = DropDownStyle.DropDownList;
			this.ooo__0oO_._O_.().Location = new Point(72, 20);
			this.ooo__0oO_._O_.().Name = "cmbPrinters";
			this.ooo__0oO_._O_.().Size = new Size(245, 20);
			this.ooo__0oO_._O_.().TabIndex = 0;
			this.o_0O_0_oOoo.OO.().AutoSize = true;
			this.o_0O_0_oOoo.OO.().Location = new Point(19, 53);
			this.o_0O_0_oOoo.OO.().Name = "Label1";
			this.o_0O_0_oOoo.OO.().Size = new Size(47, 12);
			this.o_0O_0_oOoo.OO.().TabIndex = 4;
			this.o_0O_0_oOoo.OO.().Text = "进纸盒:";
			this.ooo0Oo__.0_o_o.().DropDownStyle = DropDownStyle.DropDownList;
			this.ooo0Oo__.0_o_o.().Location = new Point(72, 49);
			this.ooo0Oo__.0_o_o.().Name = "cmbPaperSource";
			this.ooo0Oo__.0_o_o.().Size = new Size(245, 20);
			this.ooo0Oo__.0_o_o.().TabIndex = 1;
			this.o0o.0O0o0.().AutoSize = true;
			this.o0o.0O0o0.().Location = new Point(19, 82);
			this.o0o.0O0o0.().Name = "Label2";
			this.o0o.0O0o0.().Size = new Size(47, 12);
			this.o0o.0O0o0.().TabIndex = 2;
			this.o0o.0O0o0.().Text = "纸  张:";
			this.OO00_0_0_.O.().DropDownStyle = DropDownStyle.DropDownList;
			this.OO00_0_0_.O.().Location = new Point(72, 78);
			this.OO00_0_0_.O.().Name = "cmbPaperSize";
			this.OO00_0_0_.O.().Size = new Size(245, 20);
			this.OO00_0_0_.O.().TabIndex = 2;
			this.Oo.O_0__oOo_.().Controls.Add(this.Oo_0.o_0oO_0o.());
			this.Oo.O_0__oOo_.().Controls.Add(this.oo.000_.());
			this.Oo.O_0__oOo_.().Controls.Add(this.O.OOoO0_.());
			this.Oo.O_0__oOo_.().Controls.Add(this.O_.oo___.());
			this.Oo.O_0__oOo_.().Controls.Add(this.o0O0O.0OOO.());
			this.Oo.O_0__oOo_.().Controls.Add(this.Oo.O_0__oOo_.());
			this.Oo.O_0__oOo_.().Controls.Add(this.oO.o0_O0_.());
			this.Oo.O_0__oOo_.().Controls.Add(this.O.O_o_0_oo_0_O.());
			this.Oo.O_0__oOo_.().Location = new Point(136, 222);
			this.Oo.O_0__oOo_.().Name = "GroupBox3";
			this.Oo.O_0__oOo_.().Size = new Size(233, 86);
			this.Oo.O_0__oOo_.().TabIndex = 13;
			this.Oo.O_0__oOo_.().TabStop = false;
			this.Oo.O_0__oOo_.().Text = "页边距(毫米)";
			this.Oo_0.o_0oO_0o.().Location = new Point(145, 50);
			this.Oo_0.o_0oO_0o.().Name = "txtBottomMargin";
			this.Oo_0.o_0oO_0o.().Size = new Size(52, 21);
			this.Oo_0.o_0oO_0o.().TabIndex = 3;
			this.oo.000_.().AutoSize = true;
			this.oo.000_.().Location = new Point(116, 54);
			this.oo.000_.().Name = "Label7";
			this.oo.000_.().Size = new Size(23, 12);
			this.oo.000_.().TabIndex = 6;
			this.oo.000_.().Text = "下:";
			this.O.OOoO0_.().Location = new Point(50, 50);
			this.O.OOoO0_.().Name = "txtTopMargin";
			this.O.OOoO0_.().Size = new Size(52, 21);
			this.O.OOoO0_.().TabIndex = 2;
			this.O_.oo___.().AutoSize = true;
			this.O_.oo___.().Location = new Point(21, 54);
			this.O_.oo___.().Name = "Label8";
			this.O_.oo___.().Size = new Size(23, 12);
			this.O_.oo___.().TabIndex = 4;
			this.O_.oo___.().Text = "上:";
			this.o0O0O.0OOO.().Location = new Point(145, 23);
			this.o0O0O.0OOO.().Name = "txtRightMargin";
			this.o0O0O.0OOO.().Size = new Size(52, 21);
			this.o0O0O.0OOO.().TabIndex = 1;
			this.Oo.O_0__oOo_.().AutoSize = true;
			this.Oo.O_0__oOo_.().Location = new Point(116, 27);
			this.Oo.O_0__oOo_.().Name = "Label6";
			this.Oo.O_0__oOo_.().Size = new Size(23, 12);
			this.Oo.O_0__oOo_.().TabIndex = 2;
			this.Oo.O_0__oOo_.().Text = "右:";
			this.oO.o0_O0_.().Location = new Point(50, 23);
			this.oO.o0_O0_.().Name = "txtLeftMargin";
			this.oO.o0_O0_.().Size = new Size(52, 21);
			this.oO.o0_O0_.().TabIndex = 0;
			this.O.O_o_0_oo_0_O.().AutoSize = true;
			this.O.O_o_0_oo_0_O.().Location = new Point(21, 27);
			this.O.O_o_0_oo_0_O.().Name = "Label5";
			this.O.O_o_0_oo_0_O.().Size = new Size(23, 12);
			this.O.O_o_0_oo_0_O.().TabIndex = 0;
			this.O.O_o_0_oo_0_O.().Text = "左:";
			this.ooo__0oO_._O_.().Controls.Add(this.o0O0O.0OOO.());
			this.ooo__0oO_._O_.().Controls.Add(this.Oo_0.o_0oO_0o.());
			this.ooo__0oO_._O_.().Location = new Point(16, 222);
			this.ooo__0oO_._O_.().Name = "GroupBox2";
			this.ooo__0oO_._O_.().Size = new Size(100, 86);
			this.ooo__0oO_._O_.().TabIndex = 12;
			this.ooo__0oO_._O_.().TabStop = false;
			this.ooo__0oO_._O_.().Text = "方向";
			this.o0O0O.0OOO.().AutoSize = true;
			this.o0O0O.0OOO.().Location = new Point(19, 50);
			this.o0O0O.0OOO.().Name = "rdoLandScape";
			this.o0O0O.0OOO.().Size = new Size(47, 16);
			this.o0O0O.0OOO.().TabIndex = 1;
			this.o0O0O.0OOO.().Text = "横向";
			this.o0O0O.0OOO.().UseVisualStyleBackColor = true;
			this.Oo_0.o_0oO_0o.().AutoSize = true;
			this.Oo_0.o_0oO_0o.().Checked = true;
			this.Oo_0.o_0oO_0o.().Location = new Point(19, 21);
			this.Oo_0.o_0oO_0o.().Name = "RadioButton1";
			this.Oo_0.o_0oO_0o.().Size = new Size(47, 16);
			this.Oo_0.o_0oO_0o.().TabIndex = 0;
			this.Oo_0.o_0oO_0o.().TabStop = true;
			this.Oo_0.o_0oO_0o.().Text = "纵向";
			this.Oo_0.o_0oO_0o.().UseVisualStyleBackColor = true;
			this.OO00_0_0_.O.().Controls.Add(this.O.____0o.());
			this.OO00_0_0_.O.().Controls.Add(this.OoO0O._o0.());
			this.OO00_0_0_.O.().Controls.Add(this.o0.0O_0_.());
			this.OO00_0_0_.O.().Controls.Add(this.o0_o__O_oo.0O.());
			this.OO00_0_0_.O.().Location = new Point(16, 144);
			this.OO00_0_0_.O.().Name = "GroupBox1";
			this.OO00_0_0_.O.().Size = new Size(353, 59);
			this.OO00_0_0_.O.().TabIndex = 11;
			this.OO00_0_0_.O.().TabStop = false;
			this.OO00_0_0_.O.().Text = "自定义尺寸(毫米)";
			this.O.____0o.().Location = new Point(231, 24);
			this.O.____0o.().Name = "txtPaperHeight";
			this.O.____0o.().ReadOnly = true;
			this.O.____0o.().Size = new Size(100, 21);
			this.O.____0o.().TabIndex = 1;
			this.OoO0O._o0.().AutoSize = true;
			this.OoO0O._o0.().Location = new Point(189, 28);
			this.OoO0O._o0.().Name = "Label4";
			this.OoO0O._o0.().Size = new Size(35, 12);
			this.OoO0O._o0.().TabIndex = 2;
			this.OoO0O._o0.().Text = "高度:";
			this.o0.0O_0_.().Location = new Point(56, 24);
			this.o0.0O_0_.().Name = "txtPaperWidth";
			this.o0.0O_0_.().ReadOnly = true;
			this.o0.0O_0_.().Size = new Size(100, 21);
			this.o0.0O_0_.().TabIndex = 0;
			this.o0_o__O_oo.0O.().AutoSize = true;
			this.o0_o__O_oo.0O.().Location = new Point(15, 28);
			this.o0_o__O_oo.0O.().Name = "Label3";
			this.o0_o__O_oo.0O.().Size = new Size(35, 12);
			this.o0_o__O_oo.0O.().TabIndex = 0;
			this.o0_o__O_oo.0O.().Text = "宽度:";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(384, 363);
			base.Controls.Add(this.O.O_o_0_oo_0_O.());
			base.Controls.Add(this.Oo.O_0__oOo_.());
			base.Controls.Add(this.ooo__0oO_._O_.());
			base.Controls.Add(this.OO00_0_0_.O.());
			base.Controls.Add(this.ooo0Oo__.0_o_o.());
			base.Controls.Add(this.ooo__0oO_._O_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o...00..";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "页面设置";
			this.O.O_o_0_oo_0_O.().ResumeLayout(false);
			this.O.O_o_0_oo_0_O.().PerformLayout();
			this.Oo.O_0__oOo_.().ResumeLayout(false);
			this.Oo.O_0__oOo_.().PerformLayout();
			this.ooo__0oO_._O_.().ResumeLayout(false);
			this.ooo__0oO_._O_.().PerformLayout();
			this.OO00_0_0_.O.().ResumeLayout(false);
			this.OO00_0_0_.O.().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x001E76E4 File Offset: 0x001E58E4
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oooO0.0.;
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x001E76EC File Offset: 0x001E58EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o00__.O_.);
			C1Button c1Button = this.oooO0.0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oooO0.0. = A_0;
			c1Button = this.oooO0.0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x001E772F File Offset: 0x001E592F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O._0O0Oo.;
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x001E7737 File Offset: 0x001E5937
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O._0O0Oo. = A_0;
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x001E7740 File Offset: 0x001E5940
		[CompilerGenerated]
		internal virtual GroupBox <<EMPTY_NAME>>()
		{
			return this.oo.o_O.;
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x001E7748 File Offset: 0x001E5948
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(GroupBox A_0)
		{
			this.oo.o_O. = A_0;
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x001E7751 File Offset: 0x001E5951
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo.o_O.;
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x001E7759 File Offset: 0x001E5959
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo.o_O. = A_0;
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x001E7762 File Offset: 0x001E5962
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.oo.o_O.;
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x001E776A File Offset: 0x001E596A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.oo.o_O. = A_0;
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x001E7773 File Offset: 0x001E5973
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_OOO._Oo0.;
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x001E777B File Offset: 0x001E597B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_OOO._Oo0. = A_0;
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x001E7784 File Offset: 0x001E5984
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O._0O0Oo.;
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x001E778C File Offset: 0x001E598C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.Oo._o_.);
			C1ComboBox o._0O0Oo. = this.O._0O0Oo.;
			if (o._0O0Oo. != null)
			{
				o._0O0Oo..SelectedIndexChanged -= value;
			}
			this.O._0O0Oo. = A_0;
			o._0O0Oo. = this.O._0O0Oo.;
			if (o._0O0Oo. != null)
			{
				o._0O0Oo..SelectedIndexChanged += value;
			}
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x001E77CF File Offset: 0x001E59CF
		[CompilerGenerated]
		internal virtual GroupBox <<EMPTY_NAME>>()
		{
			return this.o_OOO._Oo0.;
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x001E77D7 File Offset: 0x001E59D7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(GroupBox A_0)
		{
			this.o_OOO._Oo0. = A_0;
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x001E77E0 File Offset: 0x001E59E0
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.OoO0__00.0OO__.;
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x001E77E8 File Offset: 0x001E59E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.OoO0__00.0OO__. = A_0;
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x001E77F1 File Offset: 0x001E59F1
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOO0.___Oo_o_O.;
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x001E77F9 File Offset: 0x001E59F9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOO0.___Oo_o_O. = A_0;
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x001E7802 File Offset: 0x001E5A02
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_0.0__O.;
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x001E780A File Offset: 0x001E5A0A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_0.0__O. = A_0;
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x001E7813 File Offset: 0x001E5A13
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.__0O_0_0.;
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x001E781B File Offset: 0x001E5A1B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.__0O_0_0. = A_0;
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x001E7824 File Offset: 0x001E5A24
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O0.O00.;
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x001E782C File Offset: 0x001E5A2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O0.O00. = A_0;
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x001E7835 File Offset: 0x001E5A35
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo._0_o.;
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x001E783D File Offset: 0x001E5A3D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo._0_o. = A_0;
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x001E7846 File Offset: 0x001E5A46
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O.__0O_0_0.;
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x001E784E File Offset: 0x001E5A4E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O.__0O_0_0. = A_0;
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x001E7857 File Offset: 0x001E5A57
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OO0_.O.;
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x001E785F File Offset: 0x001E5A5F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OO0_.O. = A_0;
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x001E7868 File Offset: 0x001E5A68
		[CompilerGenerated]
		internal virtual GroupBox <<EMPTY_NAME>>()
		{
			return this.Oo0o.o_.;
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x001E7870 File Offset: 0x001E5A70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(GroupBox A_0)
		{
			this.Oo0o.o_. = A_0;
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x001E7879 File Offset: 0x001E5A79
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.OoO0__00.0OO__.;
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x001E7881 File Offset: 0x001E5A81
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.OoO0__00.0OO__. = A_0;
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x001E788A File Offset: 0x001E5A8A
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.Oo0OO0_.0_o_.;
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x001E7892 File Offset: 0x001E5A92
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.Oo0OO0_.0_o_. = A_0;
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x001E789B File Offset: 0x001E5A9B
		[CompilerGenerated]
		internal virtual GroupBox <<EMPTY_NAME>>()
		{
			return this.o_.__o_Oo_0.;
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x001E78A3 File Offset: 0x001E5AA3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(GroupBox A_0)
		{
			this.o_.__o_Oo_0. = A_0;
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x001E78AC File Offset: 0x001E5AAC
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.Oo._0_o.;
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x001E78B4 File Offset: 0x001E5AB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.Oo._0_o. = A_0;
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x001E78BD File Offset: 0x001E5ABD
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_OO0O._0O0OO_.;
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x001E78C5 File Offset: 0x001E5AC5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_OO0O._0O0OO_. = A_0;
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x001E78CE File Offset: 0x001E5ACE
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O.0_o_0.;
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x001E78D6 File Offset: 0x001E5AD6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O.0_o_0. = A_0;
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x001E78DF File Offset: 0x001E5ADF
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.ooOo0_.0o.;
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x001E78E7 File Offset: 0x001E5AE7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.ooOo0_.0o. = A_0;
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x001E78F0 File Offset: 0x001E5AF0
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OOOOo.__0o__0_.;
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x001E78F8 File Offset: 0x001E5AF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OOOOo.__0o__0_. = A_0;
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x001E7901 File Offset: 0x001E5B01
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.Oo0o.o_.;
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x001E790C File Offset: 0x001E5B0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.OooO_ooo0_.___.);
			C1ComboBox oo0o.o_. = this.Oo0o.o_.;
			if (oo0o.o_. != null)
			{
				oo0o.o_..SelectedIndexChanged -= value;
			}
			this.Oo0o.o_. = A_0;
			oo0o.o_. = this.Oo0o.o_.;
			if (oo0o.o_. != null)
			{
				oo0o.o_..SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x001E7950 File Offset: 0x001E5B50
		public o\u3002\u3002\u3002\u3000\u3002(PrintPageProperty A_0)
		{
			base.Load += this.O0O._oo.;
			base.FormClosed += this.ooo__0oO_._O_.;
			this.o._O0o_. = new PrinterSettings();
			this.o0O0O.0OOO.();
			this.o._O0o_. = A_0;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x001E79B4 File Offset: 0x001E5BB4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (string text in OO_00oOO.InstalledPrinters)
				{
					this.ooo__0oO_._O_.().Items.Add(text);
					if (Operators.CompareString(text, this.o._O0o_..PrinterName, true) == 0)
					{
						this.ooo__0oO_._O_.().SelectedIndex = this.ooo__0oO_._O_.().Items.Count - 1;
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (this.ooo__0oO_._O_.().SelectedIndex == -1)
			{
				int num = this.ooo__0oO_._O_.().Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(this.ooo__0oO_._O_.().Items[i].ToString(), this.o._O0o_..PrinterName, true) == 0)
					{
						this.ooo__0oO_._O_.().SelectedIndex = i;
					}
				}
			}
			PrintPageProperty printPageProperty = this.o._O0o_.;
			this.o0.0O_0_.().ReadOnly = (this.o._O0o_..PaperKind > PaperKind.Custom);
			this.O.____0o.().ReadOnly = (this.o._O0o_..PaperKind > PaperKind.Custom);
			this.oO.o0_O0_.().Value = this.o._O0o_..LeftMargin.ToString();
			this.o0O0O.0OOO.().Value = this.o._O0o_..RightMargin.ToString();
			this.O.OOoO0_.().Value = this.o._O0o_..TopMargin.ToString();
			this.Oo_0.o_0oO_0o.().Value = this.o._O0o_..BottomMargin.ToString();
			this.o0O0O.0OOO.().Checked = printPageProperty.Landscape;
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x001E7B70 File Offset: 0x001E5D70
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (object obj in this.o._O0o_..PaperSizes)
				{
					PaperSize paperSize = (PaperSize)obj;
					if (Operators.CompareString(paperSize.PaperName, this.OO00_0_0_.O.().SelectedItem.ToString(), true) == 0)
					{
						this.oooO0.0.(paperSize);
						break;
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
			this.O.____0o.().ReadOnly = (this.OO00_0_0_.O.().SelectedIndex != this.OO00_0_0_.O.().Items.Count - 1 || Operators.CompareString(this.OO00_0_0_.O.().SelectedItem.ToString(), "自定义", true) != 0);
			this.o0.0O_0_.().ReadOnly = this.O.____0o.().ReadOnly;
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x001E7C54 File Offset: 0x001E5E54
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o._O0o_..PrinterName = this.ooo__0oO_._O_.().SelectedItem.ToString();
			if (this.OO00_0_0_.O.().SelectedIndex == this.OO00_0_0_.O.().Items.Count - 1)
			{
				this.o._O0o_..PaperKind = PaperKind.Custom;
				if (this.o._O0o_..PaperKind == PaperKind.Custom)
				{
					this.o._O0o_..Width = Convert.ToDouble(Conversion.Val(this.o0.0O_0_.().Text));
					this.o._O0o_..Height = Convert.ToDouble(Conversion.Val(this.O.____0o.().Text));
				}
			}
			else
			{
				try
				{
					foreach (object obj in this.o._O0o_..PaperSizes)
					{
						PaperSize paperSize = (PaperSize)obj;
						if (Operators.CompareString(paperSize.PaperName, this.OO00_0_0_.O.().SelectedItem.ToString(), true) == 0)
						{
							this.o._O0o_..PaperKind = paperSize.Kind;
							break;
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
			}
			if (this.ooo0Oo__.0_o_o.().SelectedItem != null)
			{
				try
				{
					foreach (object obj2 in this.o._O0o_..PaperSources)
					{
						PaperSource paperSource = (PaperSource)obj2;
						if (Operators.CompareString(paperSource.SourceName, this.ooo0Oo__.0_o_o.().SelectedItem.ToString(), true) == 0)
						{
							this.o._O0o_..PaperSourceKind = paperSource.Kind;
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
			PrintPageProperty printPageProperty = this.o._O0o_.;
			printPageProperty.LeftMargin = Convert.ToDouble(Conversion.Val(this.oO.o0_O0_.().Text));
			printPageProperty.RightMargin = Convert.ToDouble(Conversion.Val(this.o0O0O.0OOO.().Text));
			printPageProperty.TopMargin = Convert.ToDouble(Conversion.Val(this.O.OOoO0_.().Text));
			printPageProperty.BottomMargin = Convert.ToDouble(Conversion.Val(this.Oo_0.o_0oO_0o.().Text));
			printPageProperty.Landscape = this.o0O0O.0OOO.().Checked;
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x001E7E88 File Offset: 0x001E6088
		private void <<EMPTY_NAME>>(PaperSize A_0)
		{
			if (A_0.Kind != PaperKind.Custom)
			{
				this.o0.0O_0_.().Value = Math.Round((double)A_0.Width * 0.254, 2).ToString();
				this.O.____0o.().Value = Math.Round((double)A_0.Height * 0.254, 2).ToString();
			}
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x001E7EF4 File Offset: 0x001E60F4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o._O0o_..PrinterName = this.ooo__0oO_._O_.().SelectedItem.ToString();
			this.OO00_0_0_.O.().Items.Clear();
			this.ooo0Oo__.0_o_o.().Items.Clear();
			try
			{
				foreach (object obj in this.o._O0o_..PaperSizes)
				{
					PaperSize paperSize = (PaperSize)obj;
					this.OO00_0_0_.O.().Items.Add(paperSize.PaperName);
					if (paperSize.Kind == this.o._O0o_..PaperKind)
					{
						this.OO00_0_0_.O.().SelectedIndex = this.OO00_0_0_.O.().Items.Count - 1;
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
			this.OO00_0_0_.O.().Items.Add("自定义");
			if (this.o._O0o_..PaperKind == PaperKind.Custom)
			{
				this.OO00_0_0_.O.().SelectedIndex = this.OO00_0_0_.O.().Items.Count - 1;
				this.o0.0O_0_.().Value = this.o._O0o_..Width.ToString();
				this.O.____0o.().Value = this.o._O0o_..Height.ToString();
			}
			try
			{
				foreach (object obj2 in this.o._O0o_..PaperSources)
				{
					PaperSource paperSource = (PaperSource)obj2;
					this.ooo0Oo__.0_o_o.().Items.Add(paperSource.SourceName);
					if (paperSource.Kind == this.o._O0o_..PaperSourceKind)
					{
						this.ooo0Oo__.0_o_o.().SelectedIndex = this.ooo0Oo__.0_o_o.().Items.Count - 1;
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			if (this.ooo0Oo__.0_o_o.().SelectedIndex == -1)
			{
				int num = this.ooo0Oo__.0_o_o.().Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(this.ooo0Oo__.0_o_o.().Items[i].ToString(), this.o._O0o_..DefaultPageSettings.PaperSource.SourceName, true) == 0)
					{
						this.ooo0Oo__.0_o_o.().SelectedIndex = i;
					}
				}
			}
			if (this.OO00_0_0_.O.().SelectedIndex == -1)
			{
				int num2 = this.OO00_0_0_.O.().Items.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (Operators.CompareString(this.OO00_0_0_.O.().Items[j].ToString(), this.o._O0o_..DefaultPageSettings.PaperSize.PaperName, true) == 0)
					{
						this.OO00_0_0_.O.().SelectedIndex = j;
					}
				}
			}
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x001E81C8 File Offset: 0x001E63C8
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001B1E RID: 6942
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001B1F RID: 6943
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001B20 RID: 6944
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001B21 RID: 6945
		[CompilerGenerated]
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x04001B22 RID: 6946
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001B23 RID: 6947
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001B24 RID: 6948
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001B25 RID: 6949
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001B26 RID: 6950
		[CompilerGenerated]
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x04001B27 RID: 6951
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001B28 RID: 6952
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001B29 RID: 6953
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001B2A RID: 6954
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001B2B RID: 6955
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001B2C RID: 6956
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001B2D RID: 6957
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001B2E RID: 6958
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001B2F RID: 6959
		[CompilerGenerated]
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x04001B30 RID: 6960
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001B31 RID: 6961
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001B32 RID: 6962
		[CompilerGenerated]
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x04001B33 RID: 6963
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001B34 RID: 6964
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001B35 RID: 6965
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001B36 RID: 6966
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001B37 RID: 6967
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001B38 RID: 6968
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001B39 RID: 6969
		private PrintPageProperty <<EMPTY_NAME>>;

		// Token: 0x04001B3A RID: 6970
		private PrinterSettings <<EMPTY_NAME>>;
	}
}
