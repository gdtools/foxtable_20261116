using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000475 RID: 1141
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002 : Form
	{
		// Token: 0x06004DA4 RID: 19876 RVA: 0x0022FD4C File Offset: 0x0022DF4C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o_.Oo0oo. != null)
				{
					this.o_.Oo0oo..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x0022FD8C File Offset: 0x0022DF8C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_.Oo0oo. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002));
			this.o_0_O_Oo_.o0.(new C1Button());
			this.OoO_0.o0.(new C1ComboBox());
			this.OoO_0.o0.(new ListBox());
			this.OoO_0.o0.(new C1CheckBox());
			this.O_OO0._o0oo0.(new Timer(this.o_.Oo0oo.));
			this.O_OO0._o0oo0.(new C1NumericEdit());
			this.O.__oO.(new C1Button());
			this.O0oO_oO._oOo.(new C1CheckBox());
			this.OOO.0O0_oo.(new Label());
			this.OoO_0.o0.(new Label());
			this.O0oO_oO._oOo.(new Label());
			this.O_0._0o__o_OO.(new C1Button());
			this.o.oOo_.(new C1Button());
			this.O_00._OO__OOo.(new C1Button());
			this.o_Oo00_O_.oo.(new C1Button());
			this.oo._O00__0__O0.(new C1Button());
			this.o._o_ooo_O0.(new C1Button());
			this.OO_.0oOo.(new C1Button());
			this.OOO.0O0_oo.(new C1Button());
			this.oO0_.O_o_00Oo0.(new C1Button());
			this.OO_OO0O0.Oo00.(new C1Button());
			this.oooO0O_0.o_o.(new C1Button());
			((ISupportInitialize)this.OOo0_0o.o.()).BeginInit();
			((ISupportInitialize)this.OO_.0o.()).BeginInit();
			((ISupportInitialize)this.oooO._.()).BeginInit();
			((ISupportInitialize)this.OO_.0o.()).BeginInit();
			((ISupportInitialize)this.Oooo.0.()).BeginInit();
			((ISupportInitialize)this.OOO_.0o0oo_.()).BeginInit();
			((ISupportInitialize)this.O.__o_o0_.()).BeginInit();
			((ISupportInitialize)this.o.___0_0000.()).BeginInit();
			((ISupportInitialize)this.o_00_Oo_.00_0_.()).BeginInit();
			((ISupportInitialize)this.O_O_oO00.0o.()).BeginInit();
			((ISupportInitialize)this.o0__0O.00O.()).BeginInit();
			((ISupportInitialize)this.ooO0._0O0_.()).BeginInit();
			((ISupportInitialize)this.o_O0_O_o0O0O.O.()).BeginInit();
			((ISupportInitialize)this.oOoO.O0.()).BeginInit();
			((ISupportInitialize)this.Oo.oo0_0.()).BeginInit();
			((ISupportInitialize)this.o_o0_0.oO__oo.()).BeginInit();
			((ISupportInitialize)this.o0__.O.()).BeginInit();
			base.SuspendLayout();
			this.OOo0_0o.o.().Anchor = AnchorStyles.Bottom;
			this.OOo0_0o.o.().Location = new System.Drawing.Point(171, 502);
			this.OOo0_0o.o.().Name = "btnPreview";
			this.OOo0_0o.o.().Size = new Size(115, 23);
			this.OOo0_0o.o.().TabIndex = 0;
			this.OOo0_0o.o.().Text = "预览报表";
			this.OOo0_0o.o.().UseVisualStyleBackColor = true;
			this.OO_.0o.().AllowSpinLoop = false;
			this.OO_.0o.().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.OO_.0o.().Cursor = Cursors.Arrow;
			this.OO_.0o.().DropDownStyle = DropDownStyle.DropDownList;
			this.OO_.0o.().GapHeight = 0;
			this.OO_.0o.().ImagePadding = new Padding(0);
			this.OO_.0o.().ItemsDisplayMember = "";
			this.OO_.0o.().ItemsValueMember = "";
			this.OO_.0o.().Location = new System.Drawing.Point(11, 9);
			this.OO_.0o.().Name = "cmbTables";
			this.OO_.0o.().Size = new Size(272, 19);
			this.OO_.0o.().TabIndex = 1;
			this.OO_.0o.().Tag = null;
			this.OO_.0o.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.OO_.0o.().FormattingEnabled = true;
			this.OO_.0o.().IntegralHeight = false;
			this.OO_.0o.().ItemHeight = 12;
			this.OO_.0o.().Location = new System.Drawing.Point(11, 32);
			this.OO_.0o.().Name = "lstCols";
			this.OO_.0o.().Size = new Size(272, 304);
			this.OO_.0o.().TabIndex = 2;
			this.oooO._.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.oooO._.().AutoSize = true;
			this.oooO._.().BorderStyle = BorderStyle.None;
			this.oooO._.().Location = new System.Drawing.Point(11, 368);
			this.oooO._.().Name = "CheckBox1";
			this.oooO._.().Size = new Size(60, 16);
			this.oooO._.().TabIndex = 3;
			this.oooO._.().Text = "方括号";
			this.oooO._.().UseVisualStyleBackColor = true;
			this.oooO._.().Value = null;
			this.OO_.0o.().Interval = 500;
			this.OO_.0o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.OO_.0o.().ImagePadding = new Padding(0);
			this.OO_.0o.().Location = new System.Drawing.Point(112, 390);
			this.OO_.0o.().Name = "NumericUpDown1";
			this.OO_.0o.().Size = new Size(65, 19);
			this.OO_.0o.().TabIndex = 5;
			this.OO_.0o.().Tag = null;
			C1TextBox c1TextBox = this.OO_.0o.();
			int[] array = new int[4];
			array[0] = 1;
			c1TextBox.Value = new decimal(array);
			this.OO_.0o.().VisibleButtons = DropDownControlButtonFlags.UpDown;
			this.Oooo.0.().AllowDrop = true;
			this.Oooo.0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.Oooo.0.().Location = new System.Drawing.Point(185, 338);
			this.Oooo.0.().Name = "btnInsertTable";
			this.Oooo.0.().Size = new Size(98, 23);
			this.Oooo.0.().TabIndex = 4;
			this.Oooo.0.().Text = "插入关联子表";
			this.Oooo.0.().UseVisualStyleBackColor = true;
			this.OOO_.0o0oo_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.OOO_.0o0oo_.().AutoSize = true;
			this.OOO_.0o0oo_.().BorderStyle = BorderStyle.None;
			this.OOO_.0o0oo_.().Location = new System.Drawing.Point(11, 342);
			this.OOO_.0o0oo_.().Name = "CheckBox2";
			this.OOO_.0o0oo_.().Size = new Size(60, 16);
			this.OOO_.0o0oo_.().TabIndex = 2;
			this.OOO_.0o0oo_.().Text = "带标签";
			this.OOO_.0o0oo_.().UseVisualStyleBackColor = true;
			this.OOO_.0o0oo_.().Value = null;
			this.OO_.0o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.OO_.0o.().AutoSize = true;
			this.OO_.0o.().Location = new System.Drawing.Point(11, 438);
			this.OO_.0o.().Name = "Label1";
			this.OO_.0o.().Size = new Size(197, 12);
			this.OO_.0o.().TabIndex = 9;
			this.OO_.0o.().Text = "提示2： 按Ctrl双击，插入统计标记";
			this.Oo0.Oo0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Oo0.Oo0.().AutoSize = true;
			this.Oo0.Oo0.().Location = new System.Drawing.Point(11, 416);
			this.Oo0.Oo0.().Name = "Label2";
			this.Oo0.Oo0.().Size = new Size(203, 12);
			this.Oo0.Oo0.().TabIndex = 8;
			this.Oo0.Oo0.().Text = "提示1： 按Shift双击，插入图片标记";
			this.O_Oo0o0.0O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O_Oo0o0.0O.().AutoSize = true;
			this.O_Oo0o0.0O.().Location = new System.Drawing.Point(11, 394);
			this.O_Oo0o0.0O.().Name = "Label3";
			this.O_Oo0o0.0O.().Size = new Size(95, 12);
			this.O_Oo0o0.0O.().TabIndex = 7;
			this.O_Oo0o0.0O.().Text = "关联子表行位置:";
			this.O.__o_o0_.().Anchor = AnchorStyles.Bottom;
			this.O.__o_o0_.().Location = new System.Drawing.Point(6, 462);
			this.O.__o_o0_.().Name = "btnsym1";
			this.O.__o_o0_.().Size = new Size(27, 23);
			this.O.__o_o0_.().TabIndex = 6;
			this.O.__o_o0_.().Text = "\"\"";
			this.O.__o_o0_.().UseVisualStyleBackColor = true;
			this.o.___0_0000.().Anchor = AnchorStyles.Bottom;
			this.o.___0_0000.().Location = new System.Drawing.Point(34, 462);
			this.o.___0_0000.().Name = "btnsym2";
			this.o.___0_0000.().Size = new Size(27, 23);
			this.o.___0_0000.().TabIndex = 7;
			this.o.___0_0000.().Text = "<>";
			this.o.___0_0000.().UseVisualStyleBackColor = true;
			this.o_00_Oo_.00_0_.().Anchor = AnchorStyles.Bottom;
			this.o_00_Oo_.00_0_.().Location = new System.Drawing.Point(90, 462);
			this.o_00_Oo_.00_0_.().Name = "btnsym5";
			this.o_00_Oo_.00_0_.().Size = new Size(27, 23);
			this.o_00_Oo_.00_0_.().TabIndex = 9;
			this.o_00_Oo_.00_0_.().Text = "+";
			this.o_00_Oo_.00_0_.().UseVisualStyleBackColor = true;
			this.O_O_oO00.0o.().Anchor = AnchorStyles.Bottom;
			this.O_O_oO00.0o.().Location = new System.Drawing.Point(118, 462);
			this.O_O_oO00.0o.().Name = "btnsym4";
			this.O_O_oO00.0o.().Size = new Size(27, 23);
			this.O_O_oO00.0o.().TabIndex = 10;
			this.O_O_oO00.0o.().Text = "-";
			this.O_O_oO00.0o.().UseVisualStyleBackColor = true;
			this.o0__0O.00O.().Anchor = AnchorStyles.Bottom;
			this.o0__0O.00O.().Location = new System.Drawing.Point(146, 462);
			this.o0__0O.00O.().Name = "btnsym6";
			this.o0__0O.00O.().Size = new Size(27, 23);
			this.o0__0O.00O.().TabIndex = 11;
			this.o0__0O.00O.().Text = "*";
			this.o0__0O.00O.().UseVisualStyleBackColor = true;
			this.ooO0._0O0_.().Anchor = AnchorStyles.Bottom;
			this.ooO0._0O0_.().Location = new System.Drawing.Point(174, 462);
			this.ooO0._0O0_.().Name = "btnsym7";
			this.ooO0._0O0_.().Size = new Size(27, 23);
			this.ooO0._0O0_.().TabIndex = 12;
			this.ooO0._0O0_.().Text = "/";
			this.ooO0._0O0_.().UseVisualStyleBackColor = true;
			this.o_O0_O_o0O0O.O.().Anchor = AnchorStyles.Bottom;
			this.o_O0_O_o0O0O.O.().Location = new System.Drawing.Point(62, 462);
			this.o_O0_O_o0O0O.O.().Name = "btnsym3";
			this.o_O0_O_o0O0O.O.().Size = new Size(27, 23);
			this.o_O0_O_o0O0O.O.().TabIndex = 8;
			this.o_O0_O_o0O0O.O.().Text = "[]";
			this.o_O0_O_o0O0O.O.().UseVisualStyleBackColor = true;
			this.oOoO.O0.().Anchor = AnchorStyles.Bottom;
			this.oOoO.O0.().Location = new System.Drawing.Point(202, 462);
			this.oOoO.O0.().Name = "btnsym8";
			this.oOoO.O0.().Size = new Size(27, 23);
			this.oOoO.O0.().TabIndex = 13;
			this.oOoO.O0.().Text = "=";
			this.oOoO.O0.().UseVisualStyleBackColor = true;
			this.Oo.oo0_0.().Anchor = AnchorStyles.Bottom;
			this.Oo.oo0_0.().Location = new System.Drawing.Point(230, 462);
			this.Oo.oo0_0.().Name = "btnsym9";
			this.Oo.oo0_0.().Size = new Size(27, 23);
			this.Oo.oo0_0.().TabIndex = 15;
			this.Oo.oo0_0.().Text = ",";
			this.Oo.oo0_0.().UseVisualStyleBackColor = true;
			this.o_o0_0.oO__oo.().Anchor = AnchorStyles.Bottom;
			this.o_o0_0.oO__oo.().Location = new System.Drawing.Point(258, 462);
			this.o_o0_0.oO__oo.().Name = "btnsym10";
			this.o_o0_0.oO__oo.().Size = new Size(27, 23);
			this.o_o0_0.oO__oo.().TabIndex = 16;
			this.o_o0_0.oO__oo.().Text = "\\";
			this.o_o0_0.oO__oo.().UseVisualStyleBackColor = true;
			this.o0__.O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o0__.O.().Location = new System.Drawing.Point(8, 502);
			this.o0__.O.().Name = "Button1";
			this.o0__.O.().Size = new Size(60, 23);
			this.o0__.O.().TabIndex = 17;
			this.o0__.O.().Text = "转半角";
			this.o0__.O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(294, 528);
			base.Controls.Add(this.o0__.O.());
			base.Controls.Add(this.o_o0_0.oO__oo.());
			base.Controls.Add(this.Oo.oo0_0.());
			base.Controls.Add(this.oOoO.O0.());
			base.Controls.Add(this.o_O0_O_o0O0O.O.());
			base.Controls.Add(this.ooO0._0O0_.());
			base.Controls.Add(this.o0__0O.00O.());
			base.Controls.Add(this.O_O_oO00.0o.());
			base.Controls.Add(this.o_00_Oo_.00_0_.());
			base.Controls.Add(this.o.___0_0000.());
			base.Controls.Add(this.O.__o_o0_.());
			base.Controls.Add(this.O_Oo0o0.0O.());
			base.Controls.Add(this.Oo0.Oo0.());
			base.Controls.Add(this.OO_.0o.());
			base.Controls.Add(this.OOO_.0o0oo_.());
			base.Controls.Add(this.Oooo.0.());
			base.Controls.Add(this.OO_.0o.());
			base.Controls.Add(this.oooO._.());
			base.Controls.Add(this.OO_.0o.());
			base.Controls.Add(this.OO_.0o.());
			base.Controls.Add(this.OOo0_0o.o.());
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.oO.0.OO.";
			base.ShowInTaskbar = false;
			this.Text = "Word报表模版辅助设计器";
			((ISupportInitialize)this.OOo0_0o.o.()).EndInit();
			((ISupportInitialize)this.OO_.0o.()).EndInit();
			((ISupportInitialize)this.oooO._.()).EndInit();
			((ISupportInitialize)this.OO_.0o.()).EndInit();
			((ISupportInitialize)this.Oooo.0.()).EndInit();
			((ISupportInitialize)this.OOO_.0o0oo_.()).EndInit();
			((ISupportInitialize)this.O.__o_o0_.()).EndInit();
			((ISupportInitialize)this.o.___0_0000.()).EndInit();
			((ISupportInitialize)this.o_00_Oo_.00_0_.()).EndInit();
			((ISupportInitialize)this.O_O_oO00.0o.()).EndInit();
			((ISupportInitialize)this.o0__0O.00O.()).EndInit();
			((ISupportInitialize)this.ooO0._0O0_.()).EndInit();
			((ISupportInitialize)this.o_O0_O_o0O0O.O.()).EndInit();
			((ISupportInitialize)this.oOoO.O0.()).EndInit();
			((ISupportInitialize)this.Oo.oo0_0.()).EndInit();
			((ISupportInitialize)this.o_o0_0.oO__oo.()).EndInit();
			((ISupportInitialize)this.o0__.O.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x00230C3D File Offset: 0x0022EE3D
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_OO0._o0oo0.;
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00230C48 File Offset: 0x0022EE48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.OOoO0oO.);
			C1Button o_OO0._o0oo0. = this.O_OO0._o0oo0.;
			if (o_OO0._o0oo0. != null)
			{
				o_OO0._o0oo0..Click -= value;
			}
			this.O_OO0._o0oo0. = A_0;
			o_OO0._o0oo0. = this.O_OO0._o0oo0.;
			if (o_OO0._o0oo0. != null)
			{
				o_OO0._o0oo0..Click += value;
			}
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x00230C8B File Offset: 0x0022EE8B
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o_.Oo0oo.;
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x00230C94 File Offset: 0x0022EE94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O.O_o0.);
			C1ComboBox c1ComboBox = this.o_.Oo0oo.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.o_.Oo0oo. = A_0;
			c1ComboBox = this.o_.Oo0oo.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x00230CD7 File Offset: 0x0022EED7
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.o_.Oo0oo.;
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x00230CE0 File Offset: 0x0022EEE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.OO_.0o.);
			ListBox listBox = this.o_.Oo0oo.;
			if (listBox != null)
			{
				listBox.MouseDoubleClick -= value;
			}
			this.o_.Oo0oo. = A_0;
			listBox = this.o_.Oo0oo.;
			if (listBox != null)
			{
				listBox.MouseDoubleClick += value;
			}
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x00230D23 File Offset: 0x0022EF23
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O_oo.o0____.;
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x00230D2B File Offset: 0x0022EF2B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O_oo.o0____. = A_0;
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x00230D34 File Offset: 0x0022EF34
		[CompilerGenerated]
		internal virtual Timer <<EMPTY_NAME>>()
		{
			return this.o_.Oo0oo.;
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x00230D3C File Offset: 0x0022EF3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Timer A_0)
		{
			EventHandler value = new EventHandler(this.o_ooOoOO_.ooO0.);
			Timer timer = this.o_.Oo0oo.;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.o_.Oo0oo. = A_0;
			timer = this.o_.Oo0oo.;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x00230D7F File Offset: 0x0022EF7F
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.o_.Oo0oo.;
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x00230D87 File Offset: 0x0022EF87
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.o_.Oo0oo. = A_0;
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x00230D90 File Offset: 0x0022EF90
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO_O_.oO0_O.;
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x00230D98 File Offset: 0x0022EF98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O00O0o0o._0o.);
			C1Button oo_O_.oO0_O. = this.OO_O_.oO0_O.;
			if (oo_O_.oO0_O. != null)
			{
				oo_O_.oO0_O..Click -= value;
			}
			this.OO_O_.oO0_O. = A_0;
			oo_O_.oO0_O. = this.OO_O_.oO0_O.;
			if (oo_O_.oO0_O. != null)
			{
				oo_O_.oO0_O..Click += value;
			}
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x00230DDB File Offset: 0x0022EFDB
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O_0o_0._o.;
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x00230DE3 File Offset: 0x0022EFE3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O_0o_0._o. = A_0;
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x00230DEC File Offset: 0x0022EFEC
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_.Oo0oo.;
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x00230DF4 File Offset: 0x0022EFF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_.Oo0oo. = A_0;
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x00230DFD File Offset: 0x0022EFFD
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o._o_0o0.;
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x00230E05 File Offset: 0x0022F005
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o._o_0o0. = A_0;
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x00230E0E File Offset: 0x0022F00E
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oO0_._00.;
		}

		// Token: 0x06004DBB RID: 19899 RVA: 0x00230E16 File Offset: 0x0022F016
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oO0_._00. = A_0;
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x00230E1F File Offset: 0x0022F01F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0_0OO.o_o.;
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x00230E28 File Offset: 0x0022F028
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0oOO_0_.___0.);
			C1Button o0_0OO.o_o. = this.O0_0OO.o_o.;
			if (o0_0OO.o_o. != null)
			{
				o0_0OO.o_o..Click -= value;
			}
			this.O0_0OO.o_o. = A_0;
			o0_0OO.o_o. = this.O0_0OO.o_o.;
			if (o0_0OO.o_o. != null)
			{
				o0_0OO.o_o..Click += value;
			}
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x00230E6B File Offset: 0x0022F06B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOoO.0O0o_0OOO.;
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x00230E74 File Offset: 0x0022F074
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0oOO_0_.___0.);
			C1Button c1Button = this.oOoO.0O0o_0OOO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOoO.0O0o_0OOO. = A_0;
			c1Button = this.oOoO.0O0o_0OOO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004DC0 RID: 19904 RVA: 0x00230EB7 File Offset: 0x0022F0B7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O__.o0oooO0.;
		}

		// Token: 0x06004DC1 RID: 19905 RVA: 0x00230EC0 File Offset: 0x0022F0C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0oOO_0_.___0.);
			C1Button o__.o0oooO0. = this.O__.o0oooO0.;
			if (o__.o0oooO0. != null)
			{
				o__.o0oooO0..Click -= value;
			}
			this.O__.o0oooO0. = A_0;
			o__.o0oooO0. = this.O__.o0oooO0.;
			if (o__.o0oooO0. != null)
			{
				o__.o0oooO0..Click += value;
			}
		}

		// Token: 0x06004DC2 RID: 19906 RVA: 0x00230F03 File Offset: 0x0022F103
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo_.OoO0_o.;
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x00230F0C File Offset: 0x0022F10C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0oOO_0_.___0.);
			C1Button c1Button = this.oo_.OoO0_o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo_.OoO0_o. = A_0;
			c1Button = this.oo_.OoO0_o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x00230F4F File Offset: 0x0022F14F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0_0oo.OO.;
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x00230F58 File Offset: 0x0022F158
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0oOO_0_.___0.);
			C1Button o0_0oo.OO. = this.O0_0oo.OO.;
			if (o0_0oo.OO. != null)
			{
				o0_0oo.OO..Click -= value;
			}
			this.O0_0oo.OO. = A_0;
			o0_0oo.OO. = this.O0_0oo.OO.;
			if (o0_0oo.OO. != null)
			{
				o0_0oo.OO..Click += value;
			}
		}

		// Token: 0x06004DC6 RID: 19910 RVA: 0x00230F9B File Offset: 0x0022F19B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo0.o_o_0o.;
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x00230FA4 File Offset: 0x0022F1A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0oOO_0_.___0.);
			C1Button oo0.o_o_0o. = this.Oo0.o_o_0o.;
			if (oo0.o_o_0o. != null)
			{
				oo0.o_o_0o..Click -= value;
			}
			this.Oo0.o_o_0o. = A_0;
			oo0.o_o_0o. = this.Oo0.o_o_0o.;
			if (oo0.o_o_0o. != null)
			{
				oo0.o_o_0o..Click += value;
			}
		}

		// Token: 0x06004DC8 RID: 19912 RVA: 0x00230FE7 File Offset: 0x0022F1E7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.0_ooO.;
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x00230FF0 File Offset: 0x0022F1F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0oOO_0_.___0.);
			C1Button c1Button = this.o.0_ooO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.0_ooO. = A_0;
			c1Button = this.o.0_ooO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x00231033 File Offset: 0x0022F233
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0O_.O000__o.;
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x0023103C File Offset: 0x0022F23C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0oOO_0_.___0.);
			C1Button c1Button = this.o0O_.O000__o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0O_.O000__o. = A_0;
			c1Button = this.o0O_.O000__o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x0023107F File Offset: 0x0022F27F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_0O.___Oo00_O.;
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x00231088 File Offset: 0x0022F288
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0oOO_0_.___0.);
			C1Button c1Button = this.o_0O.___Oo00_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_0O.___Oo00_O. = A_0;
			c1Button = this.o_0O.___Oo00_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004DCE RID: 19918 RVA: 0x002310CB File Offset: 0x0022F2CB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0.o0Oo0o0O.;
		}

		// Token: 0x06004DCF RID: 19919 RVA: 0x002310D4 File Offset: 0x0022F2D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0oOO_0_.___0.);
			C1Button o0.o0Oo0o0O. = this.O0.o0Oo0o0O.;
			if (o0.o0Oo0o0O. != null)
			{
				o0.o0Oo0o0O..Click -= value;
			}
			this.O0.o0Oo0o0O. = A_0;
			o0.o0Oo0o0O. = this.O0.o0Oo0o0O.;
			if (o0.o0Oo0o0O. != null)
			{
				o0.o0Oo0o0O..Click += value;
			}
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x00231117 File Offset: 0x0022F317
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0O._oOO_.;
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x00231120 File Offset: 0x0022F320
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0.OO_o__00o0_.);
			C1Button o0O._oOO_. = this.O0O._oOO_.;
			if (o0O._oOO_. != null)
			{
				o0O._oOO_..Click -= value;
			}
			this.O0O._oOO_. = A_0;
			o0O._oOO_. = this.O0O._oOO_.;
			if (o0O._oOO_. != null)
			{
				o0O._oOO_..Click += value;
			}
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x00231163 File Offset: 0x0022F363
		[CompilerGenerated]
		private static Microsoft.Office.Interop.Word.Application <<EMPTY_NAME>>()
		{
			return O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O_OO0._o0oo0.;
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x0023116C File Offset: 0x0022F36C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void <<EMPTY_NAME>>(Microsoft.Office.Interop.Word.Application A_0)
		{
			ApplicationEvents4_QuitEventHandler applicationEvents4_QuitEventHandler = new ApplicationEvents4_QuitEventHandler(null, (UIntPtr)ldftn(o0.OO_o__00o0_.));
			Microsoft.Office.Interop.Word.Application o_OO0._o0oo0. = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O_OO0._o0oo0.;
			if (o_OO0._o0oo0. != null)
			{
				o_OO0._o0oo0..Quit -= applicationEvents4_QuitEventHandler;
			}
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O_OO0._o0oo0. = A_0;
			o_OO0._o0oo0. = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O_OO0._o0oo0.;
			if (o_OO0._o0oo0. != null)
			{
				o_OO0._o0oo0..Quit += applicationEvents4_QuitEventHandler;
			}
		}

		// Token: 0x06004DD4 RID: 19924
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetForegroundWindow(int A_0);

		// Token: 0x06004DD5 RID: 19925
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetActiveWindow(int A_0);

		// Token: 0x06004DD6 RID: 19926 RVA: 0x002311AC File Offset: 0x0022F3AC
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			try
			{
				if (O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.() != null && (O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible || !O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible))
				{
					try
					{
						foreach (object obj in O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents)
						{
							((Document)obj).Save();
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
					object objectValue;
					object objectValue2;
					object objectValue3;
					if (O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents.Count > 0)
					{
						Documents documents = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents;
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
						objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
						documents.Close(ref objectValue, ref objectValue2, ref objectValue3);
					}
					_Application application = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.();
					objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					application.Quit(ref objectValue3, ref objectValue2, ref objectValue);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x002312C8 File Offset: 0x0022F4C8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			object objectValue;
			object objectValue2;
			object objectValue3;
			try
			{
				if (O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.() != null && (O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible || !O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible))
				{
					try
					{
						foreach (object obj in O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents)
						{
							((Document)obj).Saved = true;
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
					if (O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents.Count > 0)
					{
						Documents documents = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents;
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
						objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
						documents.Close(ref objectValue, ref objectValue2, ref objectValue3);
					}
					_Application application = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.();
					objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
					objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
					objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					application.Quit(ref objectValue3, ref objectValue2, ref objectValue);
					System.Windows.Forms.Application.DoEvents();
					System.Windows.Forms.Application.DoEvents();
					System.Windows.Forms.Application.DoEvents();
					O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.OO_.0o.(null);
					GC.Collect();
					GC.Collect();
					GC.Collect();
					GC.Collect();
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			this.oo.oOOO0. = OO_00oOO.MainTable;
			base.TopMost = true;
			base.Location = new System.Drawing.Point((int)(SysInfo.ScreenWidth - (long)base.Width - 30L), 60);
			this.OO_.0o.().Items.Add(OO_00oOO.MainTable.Name);
			this.OO_.0o.().SelectedIndex = 0;
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.OO_.0o.(new ApplicationClass());
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().WindowState = WdWindowState.wdWindowStateMaximize;
			Documents documents2 = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents;
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
			objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue14 = RuntimeHelpers.GetObjectValue(Missing.Value);
			object objectValue15 = RuntimeHelpers.GetObjectValue(Missing.Value);
			documents2.Open(ref this.o_.Oo0oo., ref objectValue, ref objectValue2, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref objectValue14, ref objectValue15);
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible = true;
			System.Windows.Forms.Application.DoEvents();
			try
			{
				foreach (object obj2 in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation = (DataRelation)obj2;
					if (Operators.CompareString(dataRelation.ParentTable.TableName, OO_00oOO.MainTable.Name, true) == 0)
					{
						if (!this.OO_.0o.().Items.Contains(dataRelation.ChildTable.TableName))
						{
							this.OO_.0o.().Items.Add(dataRelation.ChildTable.TableName);
							this.o_.Oo0oo..Add(dataRelation.ChildTable.TableName);
						}
					}
					else if (Operators.CompareString(dataRelation.ChildTable.TableName, OO_00oOO.MainTable.Name, true) == 0 && !this.OO_.0o.().Items.Contains(dataRelation.ParentTable.TableName))
					{
						this.OO_.0o.().Items.Add(dataRelation.ParentTable.TableName);
						this.oOOo000o_._O__..Add(dataRelation.ParentTable.TableName);
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
			if (this.OO_.0o.().SelectedIndex == -1)
			{
				this.OO_.0o.().SelectedIndex = 0;
			}
			if (this.o_.Oo0oo..Count == 0)
			{
				this.Oooo.0.().Enabled = false;
			}
			this.OO_O_.oO0_O.();
			this.OO_.0o.().Enabled = true;
		}

		// Token: 0x06004DD8 RID: 19928 RVA: 0x0023171C File Offset: 0x0022F91C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				if (!O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible)
				{
					base.Close();
					this.OO_.0o.().Enabled = false;
				}
			}
			catch (Exception ex)
			{
				base.Close();
				this.OO_.0o.().Enabled = false;
			}
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x0023177C File Offset: 0x0022F97C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = OO_00oOO.ProjectPath + "Reports\\";
			if (!OO_00oOO.FileSys.DirectoryExists(text))
			{
				OO_00oOO.FileSys.CreateDirectory(text);
			}
			string text2 = text + OO_00oOO.FileSys.GetName(this.o_.Oo0oo..ToString());
			object obj2;
			if (O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents.Count > 1)
			{
				try
				{
					foreach (object obj in O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents)
					{
						Document document = (Document)obj;
						if (Operators.CompareString(document.FullName, text2, true) == 0)
						{
							_Document document2 = document;
							object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
							object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
							obj2 = RuntimeHelpers.GetObjectValue(Missing.Value);
							document2.Close(ref objectValue, ref objectValue2, ref obj2);
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
			if (OO_00oOO.FileSys.FileExists(text2) && OO_00oOO.FileIsOpened(text2))
			{
				MessageBox.Show("目标报表文件已经被其它进程打开，生成的报表将存为一个临时文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				text2 = Path.GetTempFileName();
			}
			this.OOo0_0o.o.().Enabled = false;
			Documents documents = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents;
			obj2 = 1;
			documents[ref obj2].Save();
			WordReport wordReport = new WordReport(OO_00oOO.MainTable, RuntimeHelpers.GetObjectValue(this.o_.Oo0oo.), text2);
			wordReport.Build();
			wordReport.Quit();
			object obj3 = text2;
			if (O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.() != null)
			{
				Documents documents2 = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents;
				obj2 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue4 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue5 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue6 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue7 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue8 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue9 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue10 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue11 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue14 = RuntimeHelpers.GetObjectValue(Missing.Value);
				documents2.Open(ref obj3, ref obj2, ref objectValue2, ref objectValue, ref objectValue3, ref objectValue4, ref objectValue5, ref objectValue6, ref objectValue7, ref objectValue8, ref objectValue9, ref objectValue10, ref objectValue11, ref objectValue12, ref objectValue13, ref objectValue14);
				this.OOo0_0o.o.().Enabled = true;
				return;
			}
			base.Close();
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x002319EC File Offset: 0x0022FBEC
		public O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002(string A_0)
		{
			base.FormClosing += this.O.__o_o0_.;
			base.Load += this.OOo0_0o.o.;
			base.FormClosed += this.O.__o_o0_.;
			this.o_.Oo0oo. = new List<string>();
			this.oOOo000o_._O__. = new List<string>();
			this.O_Oo0o0.0O.();
			this.o_.Oo0oo. = A_0;
			Main.OO_O.o..OOoo___.0.(base.Controls, "Office2016White");
			Main.OO_O.o..Oo.oOo_o0Oo0.("MacBlue", new object[]
			{
				this.OOo0_0o.o.()
			});
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x00231A8C File Offset: 0x0022FC8C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO_.0o.().Items.Clear();
			try
			{
				foreach (DataCol dataCol in OO_00oOO.DataTables[this.OO_.0o.().SelectedItem.ToString()].DataCols)
				{
					this.OO_.0o.().Items.Add(dataCol.Name);
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
			this.OO_.0o.().SelectedIndex = 0;
			if (Operators.CompareString(this.OO_.0o.().Text, this.oo.oOOO0..Name, true) == 0)
			{
				this.OO_.0o.().Items.Add("<Index>");
			}
		}

		// Token: 0x06004DDC RID: 19932 RVA: 0x00231B54 File Offset: 0x0022FD54
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (this.OO_.0o.().SelectedItem != null)
			{
				string text = "";
				if (this.OOO_.0o0oo_.().Checked)
				{
					text = this.OO_.0o.().SelectedItem.ToString() + ": ";
				}
				if (Operators.CompareString(this.OO_.0o.().Text, this.oo.oOOO0..Name, true) == 0)
				{
					if (Control.ModifierKeys == Keys.Control)
					{
						MessageBox.Show("只有子表才能插入统计标记!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else if (Control.ModifierKeys == Keys.Shift)
					{
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = "[&" + this.OO_.0o.().SelectedItem.ToString() + ",48,48]";
					}
					else if (!this.oooO._.().Checked)
					{
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = this.OO_.0o.().SelectedItem.ToString();
					}
					else
					{
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = text + "[" + this.OO_.0o.().SelectedItem.ToString() + "]";
					}
				}
				else if (this.o_.Oo0oo..Contains(this.OO_.0o.().Text))
				{
					if (Control.ModifierKeys == Keys.Control)
					{
						if (OO_00oOO.Tables[this.OO_.0o.().Text].Cols[this.OO_.0o.().SelectedItem.ToString()].IsNumeric())
						{
							O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = string.Concat(new string[]
							{
								"[%",
								this.OO_.0o.().Text,
								",Sum(",
								this.OO_.0o.().SelectedItem.ToString(),
								")]"
							});
						}
						else
						{
							O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = string.Concat(new string[]
							{
								"[%",
								this.OO_.0o.().Text,
								",Count(",
								this.OO_.0o.().SelectedItem.ToString(),
								")]"
							});
						}
					}
					else if (Control.ModifierKeys == Keys.Shift)
					{
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = string.Concat(new string[]
						{
							text,
							"[@&",
							this.OO_.0o.().Text,
							",",
							this.OO_.0o.().SelectedItem.ToString(),
							",",
							Conversions.ToString(Conversions.ToInteger(this.OO_.0o.().Value)),
							",48,48]"
						});
					}
					else if (!this.oooO._.().Checked)
					{
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = this.OO_.0o.().SelectedItem.ToString();
					}
					else
					{
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = string.Concat(new string[]
						{
							text,
							"[@",
							this.OO_.0o.().Text,
							",",
							this.OO_.0o.().SelectedItem.ToString(),
							",",
							Conversions.ToString(Conversions.ToInteger(this.OO_.0o.().Value)),
							"]"
						});
					}
				}
				else if (this.oOOo000o_._O__..Contains(this.OO_.0o.().Text))
				{
					if (Control.ModifierKeys == Keys.Control)
					{
						MessageBox.Show("只有子表才能插入统计标记!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else if (Control.ModifierKeys == Keys.Shift)
					{
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = string.Concat(new string[]
						{
							text,
							"[@&",
							this.OO_.0o.().Text,
							",",
							this.OO_.0o.().SelectedItem.ToString(),
							",48,48]"
						});
					}
					else if (!this.oooO._.().Checked)
					{
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = this.OO_.0o.().SelectedItem.ToString();
					}
					else
					{
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = string.Concat(new string[]
						{
							text,
							"[@",
							this.OO_.0o.().Text,
							",",
							this.OO_.0o.().SelectedItem.ToString(),
							"]"
						});
					}
				}
				this.OO_O_.oO0_O.();
			}
		}

		// Token: 0x06004DDD RID: 19933 RVA: 0x00232000 File Offset: 0x00230200
		private void <<EMPTY_NAME>>()
		{
			int num = OO_00oOO.FindAppWindow(OO_00oOO.FileSys.GetName(this.o_.Oo0oo..ToString()));
			if (num > 0)
			{
				O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.SetForegroundWindow(num);
				O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.SetActiveWindow(num);
			}
		}

		// Token: 0x06004DDE RID: 19934 RVA: 0x0023203A File Offset: 0x0023023A
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new o\u3002\u3000(O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.(), this.oo.oOOO0.).ShowDialog();
		}

		// Token: 0x06004DDF RID: 19935 RVA: 0x00232052 File Offset: 0x00230252
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = ((Button)A_0).Text;
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x0023206E File Offset: 0x0023026E
		private static void <<EMPTY_NAME>>()
		{
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.OO_.0o.(null);
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x00232078 File Offset: 0x00230278
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text, "", true) > 0)
			{
				O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = Strings.StrConv(O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text, VbStrConv.Narrow, 0);
			}
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x002320C7 File Offset: 0x002302C7
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001FB5 RID: 8117
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001FB6 RID: 8118
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FB7 RID: 8119
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001FB8 RID: 8120
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x04001FB9 RID: 8121
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001FBA RID: 8122
		[CompilerGenerated]
		private Timer <<EMPTY_NAME>>;

		// Token: 0x04001FBB RID: 8123
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x04001FBC RID: 8124
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FBD RID: 8125
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001FBE RID: 8126
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001FBF RID: 8127
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001FC0 RID: 8128
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001FC1 RID: 8129
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FC2 RID: 8130
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FC3 RID: 8131
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FC4 RID: 8132
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FC5 RID: 8133
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FC6 RID: 8134
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FC7 RID: 8135
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FC8 RID: 8136
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FC9 RID: 8137
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FCA RID: 8138
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FCB RID: 8139
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FCC RID: 8140
		[CompilerGenerated]
		private static Microsoft.Office.Interop.Word.Application <<EMPTY_NAME>>;

		// Token: 0x04001FCD RID: 8141
		private object <<EMPTY_NAME>>;

		// Token: 0x04001FCE RID: 8142
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001FCF RID: 8143
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04001FD0 RID: 8144
		private List<string> <<EMPTY_NAME>>;
	}
}
