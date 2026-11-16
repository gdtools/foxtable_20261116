using System;
using System.Collections;
using System.Collections.Generic;
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
	// Token: 0x02000367 RID: 871
	[DesignerGenerated]
	internal partial class o0o\u3002 : Form
	{
		// Token: 0x06003662 RID: 13922 RVA: 0x0017A694 File Offset: 0x00178894
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OooO_ooo0_.___. != null)
				{
					this.OooO_ooo0_.___..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x0017A6D4 File Offset: 0x001788D4
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O_0.0O0.(new Label());
			this.Oo__o._o_O.(new C1ComboBox());
			this.oo._0O.(new C1Button());
			this.o_o___.OOOO.(new C1Button());
			this.o.0___.(new C1ComboBox());
			this.oo._0O.(new C1CheckBox());
			this.oo._0O.(new Label());
			this.o0O0.o0o.(new Label());
			this.OOOo0__.0o.(new C1ComboBox());
			this.o_Oo._.(new C1Button());
			this.oo._0O.(new C1ComboBox());
			this.O_o0oo._.(new C1ComboBox());
			this.O_o0oo._.(new Label());
			this.oO_._O0_oO_o_O.(new Label());
			this.o.0___.(new C1Button());
			base.SuspendLayout();
			this.O_0o0.OOO0.().AutoSize = true;
			this.O_0o0.OOO0.().Location = new Point(12, 16);
			this.O_0o0.OOO0.().Name = "Label1";
			this.O_0o0.OOO0.().Size = new Size(59, 12);
			this.O_0o0.OOO0.().TabIndex = 0;
			this.O_0o0.OOO0.().Text = "查找内容:";
			this.O_0o0.OOO0.().Location = new Point(77, 12);
			this.O_0o0.OOO0.().Name = "ContentFind";
			this.O_0o0.OOO0.().Size = new Size(319, 20);
			this.O_0o0.OOO0.().TabIndex = 0;
			this.ooO_o_._o.().Location = new Point(413, 12);
			this.ooO_o_._o.().Name = "FindNext";
			this.ooO_o_._o.().Size = new Size(98, 23);
			this.ooO_o_._o.().TabIndex = 6;
			this.ooO_o_._o.().Text = "查找下一个";
			this.ooO_o_._o.().UseVisualStyleBackColor = true;
			this.O_0o0.OOO0.().Location = new Point(413, 42);
			this.O_0o0.OOO0.().Name = "Button2";
			this.O_0o0.OOO0.().Size = new Size(98, 23);
			this.O_0o0.OOO0.().TabIndex = 7;
			this.O_0o0.OOO0.().Text = "替换";
			this.O_0o0.OOO0.().UseVisualStyleBackColor = true;
			this.o0Ooo_.oO0.().DropDownStyle = DropDownStyle.DropDownList;
			this.o0Ooo_.oO0.().Location = new Point(77, 39);
			this.o0Ooo_.oO0.().Name = "ColList";
			this.o0Ooo_.oO0.().Size = new Size(203, 20);
			this.o0Ooo_.oO0.().TabIndex = 1;
			this.ooO_o_._o.().AutoSize = true;
			this.ooO_o_._o.().Checked = true;
			this.ooO_o_._o.().CheckState = CheckState.Checked;
			this.ooO_o_._o.().Location = new Point(77, 93);
			this.ooO_o_._o.().Name = "CaseSensitive";
			this.ooO_o_._o.().Size = new Size(84, 16);
			this.ooO_o_._o.().TabIndex = 3;
			this.ooO_o_._o.().Text = "区分大小写";
			this.ooO_o_._o.().UseVisualStyleBackColor = true;
			this.o_o___.OOOO.().AutoSize = true;
			this.o_o___.OOOO.().Location = new Point(12, 43);
			this.o_o___.OOOO.().Name = "Label2";
			this.o_o___.OOOO.().Size = new Size(59, 12);
			this.o_o___.OOOO.().TabIndex = 10;
			this.o_o___.OOOO.().Text = "查找位置:";
			this.O00O0.0o_ooOOo.().AutoSize = true;
			this.O00O0.0o_ooOOo.().Location = new Point(12, 70);
			this.O00O0.0o_ooOOo.().Name = "Label3";
			this.O00O0.0o_ooOOo.().Size = new Size(59, 12);
			this.O00O0.0o_ooOOo.().TabIndex = 11;
			this.O00O0.0o_ooOOo.().Text = "匹配方式:";
			this.o_o___.OOOO.().AccessibleRole = AccessibleRole.None;
			this.o_o___.OOOO.().DropDownStyle = DropDownStyle.DropDownList;
			this.o_o___.OOOO.().Items.AddRange(new object[]
			{
				"完全匹配",
				"开始位置",
				"结束位置",
				"任意位置"
			});
			this.o_o___.OOOO.().Location = new Point(77, 66);
			this.o_o___.OOOO.().Name = "MatchMode";
			this.o_o___.OOOO.().Size = new Size(121, 20);
			this.o_o___.OOOO.().TabIndex = 2;
			this.O_.oo_oo0ooOo.().AccessibleRole = AccessibleRole.None;
			this.O_.oo_oo0ooOo.().Location = new Point(413, 131);
			this.O_.oo_oo0ooOo.().Name = "cmdReplace";
			this.O_.oo_oo0ooOo.().Size = new Size(97, 23);
			this.O_.oo_oo0ooOo.().TabIndex = 8;
			this.O_.oo_oo0ooOo.().Text = "替换";
			this.O_.oo_oo0ooOo.().UseVisualStyleBackColor = true;
			this.ooO_o_._o.().Location = new Point(77, 133);
			this.ooO_o_._o.().Name = "ContentReplace";
			this.ooO_o_._o.().Size = new Size(319, 20);
			this.ooO_o_._o.().TabIndex = 4;
			this.O00O0.0o_ooOOo.().DropDownStyle = DropDownStyle.DropDownList;
			this.O00O0.0o_ooOOo.().Items.AddRange(new object[]
			{
				"全部内容",
				"匹配内容"
			});
			this.O00O0.0o_ooOOo.().Location = new Point(77, 161);
			this.O00O0.0o_ooOOo.().Name = "ReplaceMode";
			this.O00O0.0o_ooOOo.().Size = new Size(121, 20);
			this.O00O0.0o_ooOOo.().TabIndex = 5;
			this.oO.o_o_0.().AutoSize = true;
			this.oO.o_o_0.().Location = new Point(12, 137);
			this.oO.o_o_0.().Name = "Label4";
			this.oO.o_o_0.().Size = new Size(47, 12);
			this.oO.o_o_0.().TabIndex = 19;
			this.oO.o_o_0.().Text = "替换为:";
			this.OOoOo0.oo___oo.().AutoSize = true;
			this.OOoOo0.oo___oo.().Location = new Point(12, 165);
			this.OOoOo0.oo___oo.().Name = "Label5";
			this.OOoOo0.oo___oo.().Size = new Size(59, 12);
			this.OOoOo0.oo___oo.().TabIndex = 21;
			this.OOoOo0.oo___oo.().Text = "替换方式:";
			this.o0Ooo_.oO0.().Location = new Point(413, 160);
			this.o0Ooo_.oO0.().Name = "cmdReplaceAll";
			this.o0Ooo_.oO0.().Size = new Size(98, 23);
			this.o0Ooo_.oO0.().TabIndex = 9;
			this.o0Ooo_.oO0.().Text = "全部替换";
			this.o0Ooo_.oO0.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(522, 194);
			base.Controls.Add(this.O_.oo_oo0ooOo.());
			base.Controls.Add(this.ooO_o_._o.());
			base.Controls.Add(this.O00O0.0o_ooOOo.());
			base.Controls.Add(this.oO.o_o_0.());
			base.Controls.Add(this.OOoOo0.oo___oo.());
			base.Controls.Add(this.o0Ooo_.oO0.());
			base.Controls.Add(this.o_o___.OOOO.());
			base.Controls.Add(this.O00O0.0o_ooOOo.());
			base.Controls.Add(this.o_o___.OOOO.());
			base.Controls.Add(this.ooO_o_._o.());
			base.Controls.Add(this.o0Ooo_.oO0.());
			base.Controls.Add(this.O_0o0.OOO0.());
			base.Controls.Add(this.ooO_o_._o.());
			base.Controls.Add(this.O_0o0.OOO0.());
			base.Controls.Add(this.O_0o0.OOO0.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "OO0...Oo";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "查找";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x0017AEFE File Offset: 0x001790FE
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.ooOOO.0.;
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x0017AF06 File Offset: 0x00179106
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.ooOOO.0. = A_0;
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x0017AF0F File Offset: 0x0017910F
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.ooOOO.0.;
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x0017AF18 File Offset: 0x00179118
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.oo_.000o000.);
			C1ComboBox c1ComboBox = this.ooOOO.0.;
			if (c1ComboBox != null)
			{
				c1ComboBox.TextChanged -= value;
			}
			this.ooOOO.0. = A_0;
			c1ComboBox = this.ooOOO.0.;
			if (c1ComboBox != null)
			{
				c1ComboBox.TextChanged += value;
			}
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x0017AF5B File Offset: 0x0017915B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooOOO.0.;
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x0017AF64 File Offset: 0x00179164
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_.O_.);
			C1Button c1Button = this.ooOOO.0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooOOO.0. = A_0;
			c1Button = this.ooOOO.0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0017AFA7 File Offset: 0x001791A7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0O0.o0o.;
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x0017AFB0 File Offset: 0x001791B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_Oo_Oo.0_0.);
			C1Button c1Button = this.o0O0.o0o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0O0.o0o. = A_0;
			c1Button = this.o0O0.o0o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x0017AFF3 File Offset: 0x001791F3
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o0O0.o0o.;
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x0017AFFC File Offset: 0x001791FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O.oo0O_Ooo_o.);
			C1ComboBox c1ComboBox = this.o0O0.o0o.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.o0O0.o0o. = A_0;
			c1ComboBox = this.o0O0.o0o.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x0017B03F File Offset: 0x0017923F
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O0O0Oo.000o0.;
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x0017B048 File Offset: 0x00179248
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.OoOO.O__o0o_O0.);
			C1CheckBox o0O0Oo.000o0. = this.O0O0Oo.000o0.;
			if (o0O0Oo.000o0. != null)
			{
				o0O0Oo.000o0..CheckedChanged -= value;
			}
			this.O0O0Oo.000o0. = A_0;
			o0O0Oo.000o0. = this.O0O0Oo.000o0.;
			if (o0O0Oo.000o0. != null)
			{
				o0O0Oo.000o0..CheckedChanged += value;
			}
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x0017B08B File Offset: 0x0017928B
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.___.;
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x0017B093 File Offset: 0x00179293
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.___. = A_0;
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x0017B09C File Offset: 0x0017929C
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0_0_O__._O.;
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x0017B0A4 File Offset: 0x001792A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0_0_O__._O. = A_0;
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x0017B0AD File Offset: 0x001792AD
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O0_0_O__._O.;
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x0017B0B8 File Offset: 0x001792B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.o_o___.OOOO.);
			C1ComboBox o0_0_O__._O. = this.O0_0_O__._O.;
			if (o0_0_O__._O. != null)
			{
				o0_0_O__._O..SelectedIndexChanged -= value;
			}
			this.O0_0_O__._O. = A_0;
			o0_0_O__._O. = this.O0_0_O__._O.;
			if (o0_0_O__._O. != null)
			{
				o0_0_O__._O..SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x0017B0FB File Offset: 0x001792FB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_o0oo._.;
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x0017B104 File Offset: 0x00179304
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.ooo0O.O0OO_.);
			C1Button o_o0oo._. = this.O_o0oo._.;
			if (o_o0oo._. != null)
			{
				o_o0oo._..Click -= value;
			}
			this.O_o0oo._. = A_0;
			o_o0oo._. = this.O_o0oo._.;
			if (o_o0oo._. != null)
			{
				o_o0oo._..Click += value;
			}
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x0017B147 File Offset: 0x00179347
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O.O__OOoO0Oo0.;
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x0017B14F File Offset: 0x0017934F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.O.O__OOoO0Oo0. = A_0;
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x0017B158 File Offset: 0x00179358
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.oo._o00o_o_0_O.;
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x0017B160 File Offset: 0x00179360
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.oo._o00o_o_0_O. = A_0;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x0017B169 File Offset: 0x00179369
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.O__OOoO0Oo0.;
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x0017B171 File Offset: 0x00179371
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.O__OOoO0Oo0. = A_0;
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x0017B17A File Offset: 0x0017937A
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo._o00o_o_0_O.;
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x0017B182 File Offset: 0x00179382
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo._o00o_o_0_O. = A_0;
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x0017B18B File Offset: 0x0017938B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOOo0__.0o.;
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x0017B194 File Offset: 0x00179394
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O._0_O0O_.);
			C1Button oooo0__.0o. = this.OOOo0__.0o.;
			if (oooo0__.0o. != null)
			{
				oooo0__.0o..Click -= value;
			}
			this.OOOo0__.0o. = A_0;
			oooo0__.0o. = this.OOOo0__.0o.;
			if (oooo0__.0o. != null)
			{
				oooo0__.0o..Click += value;
			}
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x0017B1D8 File Offset: 0x001793D8
		public o0o\u3002()
		{
			base.FormClosed += this.O._0_O0O_.;
			base.Load += this.o_00_0.0.;
			this.OooO_ooo0_.___. = -1;
			this.OooO_ooo0_.___. = new Dictionary<string, string>();
			this.o0oO00.__0__.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x0017B23C File Offset: 0x0017943C
		public void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0)
			{
				base.Size = new Size(base.Width, (int)Math.Round((double)(228f * SysInfo.ScreenDpiY / 96f)));
				this.O_0o0.OOO0.().Visible = false;
			}
			else
			{
				base.Size = new Size(base.Width, 156);
			}
			try
			{
				foreach (object obj in base.Controls)
				{
					Control control = (Control)obj;
					if (control.Top > this.ooO_o_._o.().Top)
					{
						control.Visible = A_0;
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

		// Token: 0x06003684 RID: 13956 RVA: 0x0017B2FC File Offset: 0x001794FC
		private void <<EMPTY_NAME>>()
		{
			if (!base.DesignMode)
			{
				this.OooO_ooo0_.___. = OO_00oOO.CurrentTable;
				this.o0Ooo_.oO0.().Items.Clear();
				this.OooO_ooo0_.___..Clear();
				int num = this.OooO_ooo0_.___..Cols.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = this.OooO_ooo0_.___..Cols[i].Caption;
					if (this.OooO_ooo0_.___..Cols.Contains(text) || this.OooO_ooo0_.___..ContainsKey(text))
					{
						text = this.OooO_ooo0_.___..Cols[i].Name;
					}
					this.o0Ooo_.oO0.().Items.Add(text);
					this.OooO_ooo0_.___..Add(text, this.OooO_ooo0_.___..Cols[i].Name);
					if (this.OooO_ooo0_.___..foxGrid.Col - 1 == i)
					{
						this.o0Ooo_.oO0.().SelectedIndex = this.o0Ooo_.oO0.().Items.Count - 1;
					}
				}
				if (this.o0Ooo_.oO0.().SelectedIndex < 0)
				{
					this.o0Ooo_.oO0.().SelectedIndex = 0;
				}
				this.O_0o0.OOO0.().Items.Clear();
				try
				{
					foreach (string value in this.OooO_ooo0_.___..o.0o00ooo_.)
					{
						this.O_0o0.OOO0.().Items.Add(value);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.O_0o0.OOO0.().Items.Count > 0)
				{
					this.O_0o0.OOO0.().SelectedIndex = 0;
				}
				this.ooO_o_._o.().Items.Clear();
				try
				{
					foreach (string value2 in this.OooO_ooo0_.___..o.OOoo_o.)
					{
						this.ooO_o_._o.().Items.Add(value2);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				this.OooO_ooo0_.___. = -1;
			}
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x0017B530 File Offset: 0x00179730
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			OO_00oOO.CurrentTableChanged -= this.O._0_O0O_.;
			o0o\u3002.OooO_ooo0_.___. = this.ooO_o_._o.().Checked;
			o0o\u3002.o00__.O_. = this.o_o___.OOOO.().SelectedIndex;
			o0o\u3002.Oo._o_. = this.O00O0.0o_ooOOo.().SelectedIndex;
			this.OooO_ooo0_.___. = -1;
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x0017B598 File Offset: 0x00179798
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OO_00oOO.CurrentTableChanged += this.O._0_O0O_.;
			this.O._0_O0O_.();
			this.ooO_o_._o.().Checked = o0o\u3002.OooO_ooo0_.___.;
			this.o_o___.OOOO.().SelectedIndex = o0o\u3002.o00__.O_.;
			this.O00O0.0o_ooOOo.().SelectedIndex = o0o\u3002.Oo._o_.;
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x0017B5EC File Offset: 0x001797EC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.0___.(true);
			this.Text = "替换";
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x0017B600 File Offset: 0x00179800
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.O_0o0.OOO0.().Text, "", true) > 0 && (this.OooO_ooo0_.___..o.0o00ooo_..Count <= 0 || Operators.CompareString(this.OooO_ooo0_.___..o.0o00ooo_.[0], this.O_0o0.OOO0.().Text, true) != 0))
			{
				this.OooO_ooo0_.___..o.0o00ooo_..Remove(this.O_0o0.OOO0.().Text);
				this.OooO_ooo0_.___..o.0o00ooo_..Insert(0, this.O_0o0.OOO0.().Text);
				this.O_0o0.OOO0.().Items.Clear();
				try
				{
					foreach (string value in this.OooO_ooo0_.___..o.0o00ooo_.)
					{
						this.O_0o0.OOO0.().Items.Add(value);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			int num = this.O._0_O0O_.(this.OooO_ooo0_.___..foxGrid.Row + 1, this.OooO_ooo0_.___..foxGrid.Rows.Count - 1);
			if (num == -1)
			{
				num = this.O._0_O0O_.(this.OooO_ooo0_.___..foxGrid.Rows.Fixed, this.OooO_ooo0_.___..foxGrid.Row - 1);
			}
			if (num > -1)
			{
				this.OooO_ooo0_.___..foxGrid.Row = num;
			}
			else
			{
				MessageBox.Show("没有找到符合条件的行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.OooO_ooo0_.___. = num;
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x0017B798 File Offset: 0x00179998
		private int <<EMPTY_NAME>>(int A_0, int A_1)
		{
			int num;
			int result;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = this.O_0o0.OOO0.().Text;
				IL_16:
				num2 = 3;
				int col = this.OooO_ooo0_.___..foxGrid.Cols.IndexOf(this.OooO_ooo0_.___.[this.o0Ooo_.oO0.().Text]);
				IL_45:
				num2 = 4;
				int num3 = -1;
				IL_4A:
				num2 = 5;
				o0o\u3002.OooO_ooo0_.___. = this.ooO_o_._o.().Checked;
				IL_5C:
				num2 = 6;
				o0o\u3002.o00__.O_. = this.o_o___.OOOO.().SelectedIndex;
				IL_6E:
				num2 = 7;
				for (int i = A_0; i <= A_1; i++)
				{
					IL_7B:
					num2 = 8;
					if (this.OooO_ooo0_.___..foxGrid.Rows[i].DataIndex != -1)
					{
						IL_9F:
						num2 = 10;
						if (Operators.CompareString(text, "", true) == 0 && this.OooO_ooo0_.___..foxGrid.GetData(i, col) == DBNull.Value)
						{
							IL_CC:
							num2 = 11;
							num3 = i;
							break;
						}
						IL_D8:
						num2 = 13;
						string text2 = this.OooO_ooo0_.___..foxGrid.GetData(i, col).ToString();
						IL_F6:
						num2 = 14;
						switch (o0o\u3002.o00__.O_.)
						{
						case 0:
							IL_11C:
							num2 = 16;
							if (string.Compare(text2, text, !o0o\u3002.OooO_ooo0_.___.) == 0)
							{
								IL_135:
								num2 = 17;
								num3 = i;
								goto IL_248;
							}
							break;
						case 1:
							IL_141:
							num2 = 20;
							if (Operators.CompareString(text, "", true) == 0)
							{
								goto IL_248;
							}
							IL_156:
							num2 = 23;
							if (o0o\u3002.OooO_ooo0_.___.)
							{
								IL_160:
								num2 = 24;
								if (text2.StartsWith(text))
								{
									IL_171:
									num2 = 25;
									num3 = i;
									goto IL_248;
								}
							}
							else
							{
								IL_17D:
								num2 = 28;
								if (text2.StartsWith(text, StringComparison.CurrentCultureIgnoreCase))
								{
									IL_18F:
									num2 = 29;
									num3 = i;
									goto IL_248;
								}
							}
							break;
						case 2:
							IL_19B:
							num2 = 32;
							if (Operators.CompareString(text, "", true) == 0)
							{
								goto IL_248;
							}
							IL_1B0:
							num2 = 35;
							if (o0o\u3002.OooO_ooo0_.___.)
							{
								IL_1BA:
								num2 = 36;
								if (text2.EndsWith(text))
								{
									IL_1C8:
									num2 = 37;
									num3 = i;
									goto IL_248;
								}
							}
							else
							{
								IL_1D1:
								num2 = 40;
								if (text2.EndsWith(text, StringComparison.CurrentCultureIgnoreCase))
								{
									IL_1E0:
									num2 = 41;
									num3 = i;
									goto IL_248;
								}
							}
							break;
						case 3:
							IL_1E9:
							num2 = 44;
							if (Operators.CompareString(text, "", true) == 0)
							{
								goto IL_248;
							}
							IL_1FB:
							num2 = 47;
							if (o0o\u3002.OooO_ooo0_.___.)
							{
								IL_205:
								num2 = 48;
								if (text2.IndexOf(text) >= 0)
								{
									IL_214:
									num2 = 49;
									num3 = i;
									goto IL_248;
								}
							}
							else
							{
								IL_21D:
								num2 = 52;
								if (text2.IndexOf(text, StringComparison.CurrentCultureIgnoreCase) >= 0)
								{
									IL_22D:
									num2 = 53;
									num3 = i;
									goto IL_248;
								}
							}
							break;
						}
					}
					IL_236:
					num2 = 56;
				}
				IL_248:
				num2 = 57;
				this.OooO_ooo0_.___..foxGrid.Col = col;
				IL_25D:
				num2 = 58;
				result = num3;
				IL_263:
				goto IL_3A1;
				IL_268:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_362:
				goto IL_396;
				IL_364:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_374:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_364;
			}
			IL_396:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3A1:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x0017BB6C File Offset: 0x00179D6C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OooO_ooo0_.___. = -1;
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x0017BB75 File Offset: 0x00179D75
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OooO_ooo0_.___. = -1;
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x0017BB7E File Offset: 0x00179D7E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OooO_ooo0_.___. = -1;
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x0017BB87 File Offset: 0x00179D87
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OooO_ooo0_.___. = -1;
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x0017BB90 File Offset: 0x00179D90
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OooO_ooo0_.___. == this.OooO_ooo0_.___..foxGrid.Row)
			{
				this.oO.o_o_0.(null);
			}
			this.ooO_o_._o.().PerformClick();
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x0017BBC0 File Offset: 0x00179DC0
		private bool <<EMPTY_NAME>>(O0__000O A_0 = null)
		{
			o0o\u3002.Oo._o_. = this.O00O0.0o_ooOOo.().SelectedIndex;
			if (Operators.CompareString(this.ooO_o_._o.().Text, "", true) > 0 && (this.OooO_ooo0_.___..o.OOoo_o..Count <= 0 || Operators.CompareString(this.OooO_ooo0_.___..o.OOoo_o.[0], this.ooO_o_._o.().Text, true) != 0))
			{
				this.OooO_ooo0_.___..o.OOoo_o..Remove(this.ooO_o_._o.().Text);
				this.OooO_ooo0_.___..o.OOoo_o..Insert(0, this.ooO_o_._o.().Text);
				this.ooO_o_._o.().Items.Clear();
				try
				{
					foreach (string value in this.OooO_ooo0_.___..o.OOoo_o.)
					{
						this.ooO_o_._o.().Items.Add(value);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			int num = this.OooO_ooo0_.___..foxGrid.Cols.IndexOf(this.OooO_ooo0_.___.[this.o0Ooo_.oO0.().Text]);
			bool result;
			if (this.OooO_ooo0_.___. == -1 || this.OooO_ooo0_.___..foxGrid.Rows[this.OooO_ooo0_.___.].DataIndex == -1)
			{
				result = false;
			}
			else if (!this.OooO_ooo0_.___..foxGrid.o000OOo.OO.(this.OooO_ooo0_.___., num))
			{
				result = false;
			}
			else
			{
				if (A_0 == null)
				{
					this.OooO_ooo0_.___..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.OooO_ooo0_.___., this.OooO_ooo0_.___..View.O0O_0_0__.0O.(this.OooO_ooo0_.___..foxGrid.Rows[this.OooO_ooo0_.___.].DataIndex).Row, this.OooO_ooo0_.___..foxGrid.Cols[num].Name));
				}
				else
				{
					A_0.Ooo._O.(this.OooO_ooo0_.___..View.O0O_0_0__.0O.(this.OooO_ooo0_.___..foxGrid.Rows[this.OooO_ooo0_.___.].DataIndex).Row);
				}
				DataRow row = ((DataRowView)this.OooO_ooo0_.___..foxGrid.Rows[this.OooO_ooo0_.___.].DataSource).Row;
				DataColumn column = row.Table.Columns[this.OooO_ooo0_.___..foxGrid.Cols[num].Name];
				try
				{
					if (o0o\u3002.Oo._o_. == 0)
					{
						row[column] = this.ooO_o_._o.().Text;
					}
					else
					{
						string text = this.OooO_ooo0_.___..foxGrid[this.OooO_ooo0_.___., num].ToString();
						string text2 = this.O_0o0.OOO0.().Text;
						string text3 = this.ooO_o_._o.().Text;
						switch (this.o_o___.OOOO.().SelectedIndex)
						{
						case 0:
							row[column] = text3;
							break;
						case 1:
							row[column] = text3 + text.Substring(text2.Length);
							break;
						case 2:
							row[column] = text.Substring(0, text.Length - text2.Length) + text3;
							break;
						case 3:
							row[column] = text.Replace(text2, text3);
							break;
						}
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
					A_0.o_ooo.OO0ooo_.();
					return false;
				}
				this.OooO_ooo0_.___..foxGrid.O.O0_0.(this.OooO_ooo0_.___., num, null);
				result = true;
			}
			return result;
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x0017BF80 File Offset: 0x0017A180
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			O0__000O o0__000O = new O0__000O(this.OooO_ooo0_.___., this.OooO_ooo0_.___.[this.o0Ooo_.oO0.().Text]);
			this.OooO_ooo0_.___. = this.O._0_O0O_.(this.OooO_ooo0_.___..foxGrid.Rows.Fixed, this.OooO_ooo0_.___..foxGrid.Rows.Count - 1);
			int num;
			while (this.OooO_ooo0_.___. > -1)
			{
				if (!this.oO.o_o_0.(o0__000O))
				{
					return;
				}
				num++;
				this.OooO_ooo0_.___. = this.O._0_O0O_.(this.OooO_ooo0_.___. + 1, this.OooO_ooo0_.___..foxGrid.Rows.Count - 1);
			}
			if (o0__000O.Ooo._O.() > 0)
			{
				this.OooO_ooo0_.___..O_o0OOo_.o0..O__00.__0_O.(o0__000O);
			}
			MessageBox.Show("总共替换" + Conversions.ToString(num) + "处！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x04001617 RID: 5655
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001618 RID: 5656
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001619 RID: 5657
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x0400161A RID: 5658
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400161B RID: 5659
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400161C RID: 5660
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x0400161D RID: 5661
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400161E RID: 5662
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400161F RID: 5663
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001620 RID: 5664
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001621 RID: 5665
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001622 RID: 5666
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001623 RID: 5667
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001624 RID: 5668
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001625 RID: 5669
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001626 RID: 5670
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001627 RID: 5671
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001628 RID: 5672
		private int <<EMPTY_NAME>>;

		// Token: 0x04001629 RID: 5673
		private static int <<EMPTY_NAME>> = 0;

		// Token: 0x0400162A RID: 5674
		private static int <<EMPTY_NAME>> = 0;

		// Token: 0x0400162B RID: 5675
		private static bool <<EMPTY_NAME>> = true;

		// Token: 0x0400162C RID: 5676
		private Dictionary<string, string> <<EMPTY_NAME>>;
	}
}
