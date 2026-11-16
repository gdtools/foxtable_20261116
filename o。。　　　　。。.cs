using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.XLS;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000461 RID: 1121
	[DesignerGenerated]
	internal partial class o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000 : Form
	{
		// Token: 0x06004B4F RID: 19279 RVA: 0x002212F4 File Offset: 0x0021F4F4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oo._0. != null)
				{
					this.oo._0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x00221334 File Offset: 0x0021F534
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oo._0. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000));
			this.o_o00OO_.oo.(new C1Button());
			this.oO0_O0OO_.o.(new C1ComboBox());
			this.o_O__00o_0O.oo.(new System.Windows.Forms.ListBox());
			this.oO0_O0OO_.o.(new System.Windows.Forms.ListBox());
			this.oO0_O0OO_.o.(new C1CheckBox());
			this.o0_.Oo.(new Timer(this.oo._0.));
			this.o_.oOoO0Ooooo0.(new C1Button());
			this.OoOoo_0.0_o.(new C1Button());
			this.OoO0o.0O0__.(new C1Button());
			this.o_O__00o_0O.oo.(new C1Button());
			this.oO0_O0OO_.o.(new C1Button());
			this.OO.000oo_O00o.(new C1Button());
			this.oOo0O0O.oO.(new C1Button());
			this.O_00OO0._o.(new C1Button());
			this.oO_o.00O.(new C1Button());
			this.OOO__.oo0ooO_.(new C1Button());
			this.O0o_ooO.__.(new C1Button());
			((ISupportInitialize)this.O.0_OO0ooo0O0.()).BeginInit();
			((ISupportInitialize)this.O_Ooo_0Oo.00Oo.()).BeginInit();
			((ISupportInitialize)this.O_Ooo_0Oo.00Oo.()).BeginInit();
			((ISupportInitialize)this.o_o_.OOO0_Oo0.()).BeginInit();
			((ISupportInitialize)this.O0O0.0.()).BeginInit();
			((ISupportInitialize)this.O_Oo00._.()).BeginInit();
			((ISupportInitialize)this.o_o.O00OO0O0_.()).BeginInit();
			((ISupportInitialize)this.OoO__O_0_._.()).BeginInit();
			((ISupportInitialize)this.oO0oO0_0_O.oo.()).BeginInit();
			((ISupportInitialize)this.oo0__0.00.()).BeginInit();
			((ISupportInitialize)this.o0_o0oO.__.()).BeginInit();
			((ISupportInitialize)this.oOOoOO.O00OO_0.()).BeginInit();
			((ISupportInitialize)this.o_0.00o.()).BeginInit();
			((ISupportInitialize)this.o0.oO0O_OO.()).BeginInit();
			base.SuspendLayout();
			this.O.0_OO0ooo0O0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O.0_OO0ooo0O0.().Location = new System.Drawing.Point(176, 492);
			this.O.0_OO0ooo0O0.().Name = "Button3";
			this.O.0_OO0ooo0O0.().Size = new Size(98, 23);
			this.O.0_OO0ooo0O0.().TabIndex = 4;
			this.O.0_OO0ooo0O0.().Text = "预览报表";
			this.O.0_OO0ooo0O0.().UseVisualStyleBackColor = true;
			this.O_Ooo_0Oo.00Oo.().AllowSpinLoop = false;
			this.O_Ooo_0Oo.00Oo.().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.O_Ooo_0Oo.00Oo.().Cursor = Cursors.Arrow;
			this.O_Ooo_0Oo.00Oo.().DropDownStyle = DropDownStyle.DropDownList;
			this.O_Ooo_0Oo.00Oo.().GapHeight = 0;
			this.O_Ooo_0Oo.00Oo.().ImagePadding = new Padding(0);
			this.O_Ooo_0Oo.00Oo.().ItemsDisplayMember = "";
			this.O_Ooo_0Oo.00Oo.().ItemsValueMember = "";
			this.O_Ooo_0Oo.00Oo.().Location = new System.Drawing.Point(7, 6);
			this.O_Ooo_0Oo.00Oo.().Name = "cmbTables";
			this.O_Ooo_0Oo.00Oo.().Size = new Size(267, 19);
			this.O_Ooo_0Oo.00Oo.().TabIndex = 5;
			this.O_Ooo_0Oo.00Oo.().Tag = null;
			this.O_Ooo_0Oo.00Oo.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O_Ooo_0Oo.00Oo.().FormattingEnabled = true;
			this.O_Ooo_0Oo.00Oo.().IntegralHeight = false;
			this.O_Ooo_0Oo.00Oo.().ItemHeight = 12;
			this.O_Ooo_0Oo.00Oo.().Location = new System.Drawing.Point(7, 29);
			this.O_Ooo_0Oo.00Oo.().Name = "lstCols";
			this.O_Ooo_0Oo.00Oo.().Size = new Size(267, 217);
			this.O_Ooo_0Oo.00Oo.().TabIndex = 6;
			this.oO.O_0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.oO.O_0.().FormattingEnabled = true;
			this.oO.O_0.().IntegralHeight = false;
			this.oO.O_0.().ItemHeight = 12;
			this.oO.O_0.().Items.AddRange(new object[]
			{
				"<表名>",
				"<ALL>",
				"<End>",
				"<Index>",
				"<GroupHeader>",
				"<GroupFooter>",
				"<HeaderRow>",
				"<FooterRow>",
				"[%Sum(列名)] - 分页或分组统计",
				"[%表名,Sum(列名)] - 统计关联表",
				"[#表名,Sum(列名)] - 统计已打印行",
				"[$表名,Sum(列名)] - 直接统计",
				"[&列名,X,Y,Width,Height] - 图片列",
				"[&&图片文件, X, Y, Width, Height]"
			});
			this.oO.O_0.().Location = new System.Drawing.Point(7, 276);
			this.oO.O_0.().Name = "ListBox2";
			this.oO.O_0.().Size = new Size(267, 176);
			this.oO.O_0.().TabIndex = 7;
			this.O_Ooo_0Oo.00Oo.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O_Ooo_0Oo.00Oo.().AutoSize = true;
			this.O_Ooo_0Oo.00Oo.().BorderStyle = BorderStyle.None;
			this.O_Ooo_0Oo.00Oo.().Location = new System.Drawing.Point(7, 252);
			this.O_Ooo_0Oo.00Oo.().Name = "CheckBox1";
			this.O_Ooo_0Oo.00Oo.().Size = new Size(60, 16);
			this.O_Ooo_0Oo.00Oo.().TabIndex = 8;
			this.O_Ooo_0Oo.00Oo.().Text = "方括号";
			this.O_Ooo_0Oo.00Oo.().UseVisualStyleBackColor = true;
			this.O_Ooo_0Oo.00Oo.().Value = null;
			this.o_o_.OOO0_Oo0.().Anchor = AnchorStyles.Bottom;
			this.o_o_.OOO0_Oo0.().Location = new System.Drawing.Point(220, 458);
			this.o_o_.OOO0_Oo0.().Name = "btnsym9";
			this.o_o_.OOO0_Oo0.().Size = new Size(25, 23);
			this.o_o_.OOO0_Oo0.().TabIndex = 24;
			this.o_o_.OOO0_Oo0.().Text = ",";
			this.o_o_.OOO0_Oo0.().UseVisualStyleBackColor = true;
			this.O0O0.0.().Anchor = AnchorStyles.Bottom;
			this.O0O0.0.().Location = new System.Drawing.Point(193, 458);
			this.O0O0.0.().Name = "btnsym8";
			this.O0O0.0.().Size = new Size(25, 23);
			this.O0O0.0.().TabIndex = 23;
			this.O0O0.0.().Text = "=";
			this.O0O0.0.().UseVisualStyleBackColor = true;
			this.O_Oo00._.().Anchor = AnchorStyles.Bottom;
			this.O_Oo00._.().Location = new System.Drawing.Point(60, 458);
			this.O_Oo00._.().Name = "btnsym3";
			this.O_Oo00._.().Size = new Size(25, 23);
			this.O_Oo00._.().TabIndex = 18;
			this.O_Oo00._.().Text = "[]";
			this.O_Oo00._.().UseVisualStyleBackColor = true;
			this.o_o.O00OO0O0_.().Anchor = AnchorStyles.Bottom;
			this.o_o.O00OO0O0_.().Location = new System.Drawing.Point(167, 458);
			this.o_o.O00OO0O0_.().Name = "btnsym7";
			this.o_o.O00OO0O0_.().Size = new Size(25, 23);
			this.o_o.O00OO0O0_.().TabIndex = 22;
			this.o_o.O00OO0O0_.().Text = "/";
			this.o_o.O00OO0O0_.().UseVisualStyleBackColor = true;
			this.OoO__O_0_._.().Anchor = AnchorStyles.Bottom;
			this.OoO__O_0_._.().Location = new System.Drawing.Point(140, 458);
			this.OoO__O_0_._.().Name = "btnsym6";
			this.OoO__O_0_._.().Size = new Size(25, 23);
			this.OoO__O_0_._.().TabIndex = 21;
			this.OoO__O_0_._.().Text = "*";
			this.OoO__O_0_._.().UseVisualStyleBackColor = true;
			this.oO0oO0_0_O.oo.().Anchor = AnchorStyles.Bottom;
			this.oO0oO0_0_O.oo.().Location = new System.Drawing.Point(113, 458);
			this.oO0oO0_0_O.oo.().Name = "btnsym4";
			this.oO0oO0_0_O.oo.().Size = new Size(25, 23);
			this.oO0oO0_0_O.oo.().TabIndex = 20;
			this.oO0oO0_0_O.oo.().Text = "-";
			this.oO0oO0_0_O.oo.().UseVisualStyleBackColor = true;
			this.oo0__0.00.().Anchor = AnchorStyles.Bottom;
			this.oo0__0.00.().Location = new System.Drawing.Point(87, 458);
			this.oo0__0.00.().Name = "btnsym5";
			this.oo0__0.00.().Size = new Size(25, 23);
			this.oo0__0.00.().TabIndex = 19;
			this.oo0__0.00.().Text = "+";
			this.oo0__0.00.().UseVisualStyleBackColor = true;
			this.o0_o0oO.__.().Anchor = AnchorStyles.Bottom;
			this.o0_o0oO.__.().Location = new System.Drawing.Point(33, 458);
			this.o0_o0oO.__.().Name = "btnsym2";
			this.o0_o0oO.__.().Size = new Size(25, 23);
			this.o0_o0oO.__.().TabIndex = 17;
			this.o0_o0oO.__.().Text = "<>";
			this.o0_o0oO.__.().UseVisualStyleBackColor = true;
			this.oOOoOO.O00OO_0.().Anchor = AnchorStyles.Bottom;
			this.oOOoOO.O00OO_0.().Location = new System.Drawing.Point(7, 458);
			this.oOOoOO.O00OO_0.().Name = "btnsym1";
			this.oOOoOO.O00OO_0.().Size = new Size(25, 23);
			this.oOOoOO.O00OO_0.().TabIndex = 16;
			this.oOOoOO.O00OO_0.().Text = "\"\"";
			this.oOOoOO.O00OO_0.().UseVisualStyleBackColor = true;
			this.o_0.00o.().Anchor = AnchorStyles.Bottom;
			this.o_0.00o.().Location = new System.Drawing.Point(247, 458);
			this.o_0.00o.().Name = "btnsym10";
			this.o_0.00o.().Size = new Size(25, 23);
			this.o_0.00o.().TabIndex = 25;
			this.o_0.00o.().Text = "&&";
			this.o_0.00o.().UseVisualStyleBackColor = true;
			this.o0.oO0O_OO.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o0.oO0O_OO.().Location = new System.Drawing.Point(7, 492);
			this.o0.oO0O_OO.().Name = "Button1";
			this.o0.oO0O_OO.().Size = new Size(57, 23);
			this.o0.oO0O_OO.().TabIndex = 26;
			this.o0.oO0O_OO.().Text = "转半角";
			this.o0.oO0O_OO.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(280, 517);
			base.Controls.Add(this.o0.oO0O_OO.());
			base.Controls.Add(this.o_0.00o.());
			base.Controls.Add(this.o_o_.OOO0_Oo0.());
			base.Controls.Add(this.O0O0.0.());
			base.Controls.Add(this.O_Oo00._.());
			base.Controls.Add(this.o_o.O00OO0O0_.());
			base.Controls.Add(this.OoO__O_0_._.());
			base.Controls.Add(this.oO0oO0_0_O.oo.());
			base.Controls.Add(this.oo0__0.00.());
			base.Controls.Add(this.o0_o0oO.__.());
			base.Controls.Add(this.oOOoOO.O00OO_0.());
			base.Controls.Add(this.O_Ooo_0Oo.00Oo.());
			base.Controls.Add(this.oO.O_0.());
			base.Controls.Add(this.O_Ooo_0Oo.00Oo.());
			base.Controls.Add(this.O_Ooo_0Oo.00Oo.());
			base.Controls.Add(this.O.0_OO0ooo0O0.());
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.o00.OO.";
			base.ShowInTaskbar = false;
			this.Text = "Excel报表模版辅助设计器";
			((ISupportInitialize)this.O.0_OO0ooo0O0.()).EndInit();
			((ISupportInitialize)this.O_Ooo_0Oo.00Oo.()).EndInit();
			((ISupportInitialize)this.O_Ooo_0Oo.00Oo.()).EndInit();
			((ISupportInitialize)this.o_o_.OOO0_Oo0.()).EndInit();
			((ISupportInitialize)this.O0O0.0.()).EndInit();
			((ISupportInitialize)this.O_Oo00._.()).EndInit();
			((ISupportInitialize)this.o_o.O00OO0O0_.()).EndInit();
			((ISupportInitialize)this.OoO__O_0_._.()).EndInit();
			((ISupportInitialize)this.oO0oO0_0_O.oo.()).EndInit();
			((ISupportInitialize)this.oo0__0.00.()).EndInit();
			((ISupportInitialize)this.o0_o0oO.__.()).EndInit();
			((ISupportInitialize)this.oOOoOO.O00OO_0.()).EndInit();
			((ISupportInitialize)this.o_0.00o.()).EndInit();
			((ISupportInitialize)this.o0.oO0O_OO.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x00221F10 File Offset: 0x00220110
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0O0_0_o.O_O.;
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x00221F18 File Offset: 0x00220118
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.0O0__00O.);
			C1Button c1Button = this.o0O0_0_o.O_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0O0_0_o.O_O. = A_0;
			c1Button = this.o0O0_0_o.O_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x00221F5B File Offset: 0x0022015B
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o0O0_0_o.O_O.;
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x00221F64 File Offset: 0x00220164
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.oO___0.Oo.);
			C1ComboBox c1ComboBox = this.o0O0_0_o.O_O.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.o0O0_0_o.O_O. = A_0;
			c1ComboBox = this.o0O0_0_o.O_O.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x00221FA7 File Offset: 0x002201A7
		[CompilerGenerated]
		internal virtual System.Windows.Forms.ListBox <<EMPTY_NAME>>()
		{
			return this.o0O0_0_o.O_O.;
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x00221FB0 File Offset: 0x002201B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.ListBox A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.O_0_O00OO_.00.);
			System.Windows.Forms.ListBox listBox = this.o0O0_0_o.O_O.;
			if (listBox != null)
			{
				listBox.MouseDoubleClick -= value;
			}
			this.o0O0_0_o.O_O. = A_0;
			listBox = this.o0O0_0_o.O_O.;
			if (listBox != null)
			{
				listBox.MouseDoubleClick += value;
			}
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x00221FF3 File Offset: 0x002201F3
		[CompilerGenerated]
		internal virtual System.Windows.Forms.ListBox <<EMPTY_NAME>>()
		{
			return this.Oo_oo._.;
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x00221FFC File Offset: 0x002201FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.ListBox A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.O._o00.);
			System.Windows.Forms.ListBox oo_oo._. = this.Oo_oo._.;
			if (oo_oo._. != null)
			{
				oo_oo._..MouseDoubleClick -= value;
			}
			this.Oo_oo._. = A_0;
			oo_oo._. = this.Oo_oo._.;
			if (oo_oo._. != null)
			{
				oo_oo._..MouseDoubleClick += value;
			}
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x0022203F File Offset: 0x0022023F
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o0O0_0_o.O_O.;
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x00222047 File Offset: 0x00220247
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o0O0_0_o.O_O. = A_0;
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x00222050 File Offset: 0x00220250
		[CompilerGenerated]
		internal virtual Timer <<EMPTY_NAME>>()
		{
			return this.o0O0_0_o.O_O.;
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x00222058 File Offset: 0x00220258
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Timer A_0)
		{
			EventHandler value = new EventHandler(this.Oo.o0O.);
			Timer timer = this.o0O0_0_o.O_O.;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.o0O0_0_o.O_O. = A_0;
			timer = this.o0O0_0_o.O_O.;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x0022209B File Offset: 0x0022029B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_oo._.;
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x002220A4 File Offset: 0x002202A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOooOO0O0.O.);
			C1Button oo_oo._. = this.Oo_oo._.;
			if (oo_oo._. != null)
			{
				oo_oo._..Click -= value;
			}
			this.Oo_oo._. = A_0;
			oo_oo._. = this.Oo_oo._.;
			if (oo_oo._. != null)
			{
				oo_oo._..Click += value;
			}
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x002220E7 File Offset: 0x002202E7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.o___O.;
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x002220F0 File Offset: 0x002202F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOooOO0O0.O.);
			C1Button o.o___O. = this.O.o___O.;
			if (o.o___O. != null)
			{
				o.o___O..Click -= value;
			}
			this.O.o___O. = A_0;
			o.o___O. = this.O.o___O.;
			if (o.o___O. != null)
			{
				o.o___O..Click += value;
			}
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x00222133 File Offset: 0x00220333
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.00_O0o__O_.;
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x0022213C File Offset: 0x0022033C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOooOO0O0.O.);
			C1Button o.00_O0o__O_. = this.O.00_O0o__O_.;
			if (o.00_O0o__O_. != null)
			{
				o.00_O0o__O_..Click -= value;
			}
			this.O.00_O0o__O_. = A_0;
			o.00_O0o__O_. = this.O.00_O0o__O_.;
			if (o.00_O0o__O_. != null)
			{
				o.00_O0o__O_..Click += value;
			}
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x0022217F File Offset: 0x0022037F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo.o0O.;
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x00222188 File Offset: 0x00220388
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOooOO0O0.O.);
			C1Button oo.o0O. = this.Oo.o0O.;
			if (oo.o0O. != null)
			{
				oo.o0O..Click -= value;
			}
			this.Oo.o0O. = A_0;
			oo.o0O. = this.Oo.o0O.;
			if (oo.o0O. != null)
			{
				oo.o0O..Click += value;
			}
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x002221CB File Offset: 0x002203CB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.O0o_.;
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x002221D4 File Offset: 0x002203D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOooOO0O0.O.);
			C1Button o.O0o_. = this.O.O0o_.;
			if (o.O0o_. != null)
			{
				o.O0o_..Click -= value;
			}
			this.O.O0o_. = A_0;
			o.O0o_. = this.O.O0o_.;
			if (o.O0o_. != null)
			{
				o.O0o_..Click += value;
			}
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x00222217 File Offset: 0x00220417
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_.OO0oOOOoo_.;
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x00222220 File Offset: 0x00220420
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOooOO0O0.O.);
			C1Button o_.OO0oOOOoo_. = this.O_.OO0oOOOoo_.;
			if (o_.OO0oOOOoo_. != null)
			{
				o_.OO0oOOOoo_..Click -= value;
			}
			this.O_.OO0oOOOoo_. = A_0;
			o_.OO0oOOOoo_. = this.O_.OO0oOOOoo_.;
			if (o_.OO0oOOOoo_. != null)
			{
				o_.OO0oOOOoo_..Click += value;
			}
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x00222263 File Offset: 0x00220463
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOo_O_0o.O0_O0.;
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x0022226C File Offset: 0x0022046C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOooOO0O0.O.);
			C1Button c1Button = this.oOo_O_0o.O0_O0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOo_O_0o.O0_O0. = A_0;
			c1Button = this.oOo_O_0o.O0_O0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x002222AF File Offset: 0x002204AF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_.__O0O00_.;
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x002222B8 File Offset: 0x002204B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOooOO0O0.O.);
			C1Button oo_.__O0O00_. = this.Oo_.__O0O00_.;
			if (oo_.__O0O00_. != null)
			{
				oo_.__O0O00_..Click -= value;
			}
			this.Oo_.__O0O00_. = A_0;
			oo_.__O0O00_. = this.Oo_.__O0O00_.;
			if (oo_.__O0O00_. != null)
			{
				oo_.__O0O00_..Click += value;
			}
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x002222FB File Offset: 0x002204FB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_o0._o.;
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x00222304 File Offset: 0x00220504
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOooOO0O0.O.);
			C1Button c1Button = this.o_o0._o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_o0._o. = A_0;
			c1Button = this.o_o0._o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004B6F RID: 19311 RVA: 0x00222347 File Offset: 0x00220547
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o__OOO_0_0.o_o.;
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x00222350 File Offset: 0x00220550
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOooOO0O0.O.);
			C1Button c1Button = this.o__OOO_0_0.o_o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o__OOO_0_0.o_o. = A_0;
			c1Button = this.o__OOO_0_0.o_o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x00222393 File Offset: 0x00220593
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_Oo.0Oo0.;
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x0022239C File Offset: 0x0022059C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO.oo__0O.);
			C1Button o_Oo.0Oo0. = this.O_Oo.0Oo0.;
			if (o_Oo.0Oo0. != null)
			{
				o_Oo.0Oo0..Click -= value;
			}
			this.O_Oo.0Oo0. = A_0;
			o_Oo.0Oo0. = this.O_Oo.0Oo0.;
			if (o_Oo.0Oo0. != null)
			{
				o_Oo.0Oo0..Click += value;
			}
		}

		// Token: 0x06004B73 RID: 19315
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetForegroundWindow(int A_0);

		// Token: 0x06004B74 RID: 19316 RVA: 0x002223E0 File Offset: 0x002205E0
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			try
			{
				if (this.o0O0_0_o.O_O. != null && (this.o0O0_0_o.O_O..Visible || !this.o0O0_0_o.O_O..Visible))
				{
					try
					{
						foreach (object obj in this.o0O0_0_o.O_O..Workbooks)
						{
							((Workbook)obj).Save();
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
					if (this.o0O0_0_o.O_O..Workbooks.Count > 0)
					{
						this.o0O0_0_o.O_O..Workbooks.Close();
					}
					this.o0O0_0_o.O_O..Quit();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x002224B0 File Offset: 0x002206B0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.TopMost = true;
			base.Location = new System.Drawing.Point((int)(SysInfo.ScreenWidth - (long)base.Width - 30L), 60);
			this.o0O0_0_o.O_O. = new ApplicationClass();
			this.o0O0_0_o.O_O..WindowState = XlWindowState.xlMaximized;
			this.o0O0_0_o.O_O..Visible = true;
			this.o0O0_0_o.O_O..Workbooks.Open(this.oo0O.Oo_0., RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(this.o0O0_0_o.O_O..Hwnd);
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					this.O_Ooo_0Oo.00Oo.().Items.Add(dataTable.Name);
					if (Operators.CompareString(dataTable.Name, OO_00oOO.MainTable.DataTable.Name, true) == 0)
					{
						this.O_Ooo_0Oo.00Oo.().SelectedIndex = this.O_Ooo_0Oo.00Oo.().Items.Count - 1;
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
			if (this.O_Ooo_0Oo.00Oo.().SelectedIndex == -1)
			{
				this.O_Ooo_0Oo.00Oo.().SelectedIndex = 0;
			}
			this.O._o00.().Enabled = true;
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x00222670 File Offset: 0x00220870
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				if (!this.o0O0_0_o.O_O..Visible)
				{
					base.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x002226B0 File Offset: 0x002208B0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = OO_00oOO.ProjectPath + "Reports\\";
			if (!OO_00oOO.FileSys.DirectoryExists(text))
			{
				OO_00oOO.FileSys.CreateDirectory(text);
			}
			string text2 = text + "_" + OO_00oOO.FileSys.GetName(this.oo0O.Oo_0.);
			if (this.o0O0_0_o.O_O..Workbooks.Count > 1)
			{
				try
				{
					foreach (object obj in this.o0O0_0_o.O_O..Workbooks)
					{
						Workbook workbook = (Workbook)obj;
						if (Operators.CompareString(workbook.FullName, text2, true) == 0)
						{
							workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
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
			this.O.0_OO0ooo0O0.().Enabled = false;
			this.o0O0_0_o.O_O..Workbooks[1].Save();
			Book book = new Book(this.o0O0_0_o.O_O..Workbooks[1].FullName);
			book.Build(new int[0]);
			book.Save(text2);
			this.o0O0_0_o.O_O..Workbooks.Open(text2, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(this.o0O0_0_o.O_O..Hwnd);
			this.O.0_OO0ooo0O0.().Enabled = true;
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x002228B0 File Offset: 0x00220AB0
		public o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000(string A_0)
		{
			base.FormClosing += this.oOOoOO.O00OO_0.;
			base.Load += this.oO_OOOO.0OO_.;
			base.FormClosed += this.oOOoOO.O00OO_0.;
			this.oo._0. = Path.GetTempFileName();
			this.O._o00.();
			this.oo0O.Oo_0. = A_0;
			Main.OO_O.o..OOoo___.0.(base.Controls, "Office2016White");
			Main.OO_O.o..Oo.oOo_o0Oo0.("MacBlue", new object[]
			{
				this.O.0_OO0ooo0O0.()
			});
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x00222944 File Offset: 0x00220B44
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_Ooo_0Oo.00Oo.().Items.Clear();
			try
			{
				foreach (DataCol dataCol in OO_00oOO.DataTables[this.O_Ooo_0Oo.00Oo.().SelectedItem.ToString()].DataCols)
				{
					this.O_Ooo_0Oo.00Oo.().Items.Add(dataCol.Name);
				}
			}
			finally
			{
				IEnumerator<DataCol> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.O_Ooo_0Oo.00Oo.().SelectedIndex = 0;
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x002229D8 File Offset: 0x00220BD8
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(this.o0O0_0_o.O_O..Hwnd);
			this.o0O0_0_o.O_O..SendKeys("{ESC}", Missing.Value);
			if (this.O_Ooo_0Oo.00Oo.().SelectedItem != null && this.o0O0_0_o.O_O..ActiveCell != null)
			{
				if (!this.O_Ooo_0Oo.00Oo.().Checked)
				{
					this.o0O0_0_o.O_O..ActiveCell.set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), this.O_Ooo_0Oo.00Oo.().SelectedItem.ToString());
					return;
				}
				this.o0O0_0_o.O_O..ActiveCell.set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), "[" + this.O_Ooo_0Oo.00Oo.().SelectedItem.ToString() + "]");
			}
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x00222A98 File Offset: 0x00220C98
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(this.o0O0_0_o.O_O..Hwnd);
			this.o0O0_0_o.O_O..SendKeys("{ESC}", Missing.Value);
			if (this.oO.O_0.().SelectedItem != null)
			{
				string text = this.oO.O_0.().SelectedItem.ToString();
				string text2 = this.O_Ooo_0Oo.00Oo.().Text;
				string text3 = "";
				if (text.IndexOf("-") > 0)
				{
					text = text.Substring(0, text.IndexOf("-") - 2) + "]";
				}
				if (this.O_Ooo_0Oo.00Oo.().SelectedIndex > -1)
				{
					text3 = this.O_Ooo_0Oo.00Oo.().SelectedItem.ToString();
				}
				text = text.Replace("表名", text2);
				if (Operators.CompareString(text3, "", true) > 0)
				{
					text = text.Replace("列名", text3);
				}
				if (this.o0O0_0_o.O_O..ActiveCell != null)
				{
					this.o0O0_0_o.O_O..ActiveCell.set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), text);
				}
			}
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x00222B9C File Offset: 0x00220D9C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(this.o0O0_0_o.O_O..Hwnd);
			this.o0O0_0_o.O_O..SendKeys("{ESC}", Missing.Value);
			if (this.o0O0_0_o.O_O..ActiveCell != null)
			{
				this.o0O0_0_o.O_O..ActiveCell.set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), ((System.Windows.Forms.Button)A_0).Text);
			}
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x00222C04 File Offset: 0x00220E04
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(this.o0O0_0_o.O_O..Hwnd);
			this.o0O0_0_o.O_O..SendKeys("{ESC}", Missing.Value);
			if (this.o0O0_0_o.O_O..ActiveCell != null && Operators.CompareString(this.o0O0_0_o.O_O..ActiveCell.Text.ToString(), "", true) > 0)
			{
				this.o0O0_0_o.O_O..ActiveCell.set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), Strings.StrConv(this.o0O0_0_o.O_O..ActiveCell.Text.ToString(), VbStrConv.Narrow, 0));
			}
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x00222C9D File Offset: 0x00220E9D
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001E99 RID: 7833
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001E9A RID: 7834
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E9B RID: 7835
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001E9C RID: 7836
		[CompilerGenerated]
		private System.Windows.Forms.ListBox <<EMPTY_NAME>>;

		// Token: 0x04001E9D RID: 7837
		[CompilerGenerated]
		private System.Windows.Forms.ListBox <<EMPTY_NAME>>;

		// Token: 0x04001E9E RID: 7838
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001E9F RID: 7839
		[CompilerGenerated]
		private Timer <<EMPTY_NAME>>;

		// Token: 0x04001EA0 RID: 7840
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001EA1 RID: 7841
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001EA2 RID: 7842
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001EA3 RID: 7843
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001EA4 RID: 7844
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001EA5 RID: 7845
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001EA6 RID: 7846
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001EA7 RID: 7847
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001EA8 RID: 7848
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001EA9 RID: 7849
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001EAA RID: 7850
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001EAB RID: 7851
		private Microsoft.Office.Interop.Excel.Application <<EMPTY_NAME>>;

		// Token: 0x04001EAC RID: 7852
		private string <<EMPTY_NAME>>;

		// Token: 0x04001EAD RID: 7853
		private string <<EMPTY_NAME>>;
	}
}
