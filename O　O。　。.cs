using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000061 RID: 97
	[DesignerGenerated]
	internal partial class O\u3000O\u3002\u3000\u3002\u3000\u3000\u3000 : Form
	{
		// Token: 0x06000338 RID: 824 RVA: 0x0000B2E8 File Offset: 0x000094E8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O0_00O_o.__o. != null)
				{
					this.O0_00O_o.__o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000B328 File Offset: 0x00009528
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O00OOo_o.O.(new C1TextBox());
			this.O00OOo_o.O.(new CheckedListBox());
			this.O00OOo_o.O.(new C1Button());
			this.oo_O0000o.00.(new C1Button());
			((ISupportInitialize)this.O00OOo_o.O.()).BeginInit();
			((ISupportInitialize)this.OO_0._Oo.()).BeginInit();
			((ISupportInitialize)this.o._Oo0o_Oo_O_o.()).BeginInit();
			base.SuspendLayout();
			this.O00OOo_o.O.().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.O00OOo_o.O.().Location = new Point(12, 16);
			this.O00OOo_o.O.().Name = "TextBox1";
			this.O00OOo_o.O.().Size = new Size(415, 19);
			this.O00OOo_o.O.().TabIndex = 0;
			this.O00OOo_o.O.().Tag = null;
			this.o._Oo0o_Oo_O_o.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.o._Oo0o_Oo_O_o.().CheckOnClick = true;
			this.o._Oo0o_Oo_O_o.().FormattingEnabled = true;
			this.o._Oo0o_Oo_O_o.().IntegralHeight = false;
			this.o._Oo0o_Oo_O_o.().Location = new Point(12, 43);
			this.o._Oo0o_Oo_O_o.().Name = "CheckedListBox1";
			this.o._Oo0o_Oo_O_o.().Size = new Size(415, 268);
			this.o._Oo0o_Oo_O_o.().TabIndex = 1;
			this.OO_0._Oo.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.OO_0._Oo.().Location = new Point(271, 324);
			this.OO_0._Oo.().Name = "Button1";
			this.OO_0._Oo.().Size = new Size(75, 23);
			this.OO_0._Oo.().TabIndex = 2;
			this.OO_0._Oo.().Text = "确定";
			this.OO_0._Oo.().UseVisualStyleBackColor = true;
			this.o._Oo0o_Oo_O_o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.o._Oo0o_Oo_O_o.().Location = new Point(352, 324);
			this.o._Oo0o_Oo_O_o.().Name = "Button2";
			this.o._Oo0o_Oo_O_o.().Size = new Size(75, 23);
			this.o._Oo0o_Oo_O_o.().TabIndex = 3;
			this.o._Oo0o_Oo_O_o.().Text = "取消";
			this.o._Oo0o_Oo_O_o.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(439, 355);
			base.Controls.Add(this.o._Oo0o_Oo_O_o.());
			base.Controls.Add(this.OO_0._Oo.());
			base.Controls.Add(this.o._Oo0o_Oo_O_o.());
			base.Controls.Add(this.O00OOo_o.O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmColumnsSelector";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "选择列";
			((ISupportInitialize)this.O00OOo_o.O.()).EndInit();
			((ISupportInitialize)this.OO_0._Oo.()).EndInit();
			((ISupportInitialize)this.o._Oo0o_Oo_O_o.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000B61F File Offset: 0x0000981F
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O00OOo_o.O.;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000B627 File Offset: 0x00009827
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O00OOo_o.O. = A_0;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000B630 File Offset: 0x00009830
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.O00OOo_o.O.;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000B638 File Offset: 0x00009838
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			ItemCheckEventHandler value = new ItemCheckEventHandler(this.o._Oo0o_Oo_O_o.);
			CheckedListBox o00OOo_o.O. = this.O00OOo_o.O.;
			if (o00OOo_o.O. != null)
			{
				o00OOo_o.O..ItemCheck -= value;
			}
			this.O00OOo_o.O. = A_0;
			o00OOo_o.O. = this.O00OOo_o.O.;
			if (o00OOo_o.O. != null)
			{
				o00OOo_o.O..ItemCheck += value;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000B67B File Offset: 0x0000987B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O00OOo_o.O.;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000B684 File Offset: 0x00009884
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o._Oo0o_Oo_O_o.);
			C1Button o00OOo_o.O. = this.O00OOo_o.O.;
			if (o00OOo_o.O. != null)
			{
				o00OOo_o.O..Click -= value;
			}
			this.O00OOo_o.O. = A_0;
			o00OOo_o.O. = this.O00OOo_o.O.;
			if (o00OOo_o.O. != null)
			{
				o00OOo_o.O..Click += value;
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000B6C7 File Offset: 0x000098C7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo_O0000o.00.;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO_0._Oo.);
			C1Button c1Button = this.oo_O0000o.00.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo_O0000o.00. = A_0;
			c1Button = this.oo_O0000o.00.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000B714 File Offset: 0x00009914
		public O\u3000O\u3002\u3000\u3002\u3000\u3000\u3000(Table A_0, string A_1)
		{
			base.FormClosed += this.o._Oo0o_Oo_O_o.;
			this.O00OOo_o.O.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			List<string> list = new List<string>();
			this.O0_00O_o.__o. = A_0;
			if (Operators.CompareString(A_1, "", true) > 0)
			{
				list.AddRange(A_1.Split(new char[]
				{
					'|'
				}));
			}
			try
			{
				foreach (Col col in A_0.Cols)
				{
					this.o._Oo0o_Oo_O_o.().Items.Add(col.Name);
					if (list.Contains(col.Name))
					{
						this.o._Oo0o_Oo_O_o.().SetItemChecked(this.o._Oo0o_Oo_O_o.().Items.Count - 1, true);
					}
				}
			}
			finally
			{
				IEnumerator<Col> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			for (int i = list.Count - 1; i >= 0; i += -1)
			{
				if (!A_0.Cols.Contains(list[i]))
				{
					list.RemoveAt(i);
				}
			}
			if (list.Count > 0)
			{
				string text = string.Join("|", list.ToArray());
				this.O0_00O_o.__o. = text.Trim(new char[]
				{
					'|'
				});
				this.O00OOo_o.O.().Value = this.O0_00O_o.__o.;
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000B880 File Offset: 0x00009A80
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000B889 File Offset: 0x00009A89
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O0_00O_o.__o. = this.O00OOo_o.O.().Text;
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000B8A4 File Offset: 0x00009AA4
		private void <<EMPTY_NAME>>(object A_0, ItemCheckEventArgs A_1)
		{
			List<string> list = new List<string>();
			if (Operators.CompareString(this.O00OOo_o.O.().Text, "", true) > 0)
			{
				list.AddRange(this.O00OOo_o.O.().Text.Split(new char[]
				{
					'|'
				}));
			}
			string item = this.o._Oo0o_Oo_O_o.().Items[A_1.Index].ToString();
			if (A_1.NewValue == CheckState.Checked)
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
			else if (list.Contains(item))
			{
				list.Remove(item);
			}
			this.O00OOo_o.O.().Value = string.Join("|", list.ToArray());
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000B954 File Offset: 0x00009B54
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400009A RID: 154
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400009B RID: 155
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400009C RID: 156
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x0400009D RID: 157
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400009E RID: 158
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400009F RID: 159
		private Table <<EMPTY_NAME>>;

		// Token: 0x040000A0 RID: 160
		internal string <<EMPTY_NAME>>;
	}
}
