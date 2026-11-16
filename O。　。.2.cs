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
	// Token: 0x020000DC RID: 220
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3002 : Form
	{
		// Token: 0x06000A97 RID: 2711 RVA: 0x000580B8 File Offset: 0x000562B8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.Oo.__0o_0_Oo. != null)
				{
					this.Oo.__0o_0_Oo..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000580F8 File Offset: 0x000562F8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oOoO._o0.(new Label());
			this.oOoO._o0.(new C1NumericEdit());
			this.oOoO._o0.(new C1Button());
			this.O_o_.O_o_.(new C1Button());
			((ISupportInitialize)this.oOoO._o0.()).BeginInit();
			base.SuspendLayout();
			this.oOoO._o0.().AutoSize = true;
			this.oOoO._o0.().Location = new Point(14, 13);
			this.oOoO._o0.().Name = "Label1";
			this.oOoO._o0.().Size = new Size(41, 12);
			this.oOoO._o0.().TabIndex = 0;
			this.oOoO._o0.().Text = "Label1";
			this.oOoO._o0.().DataType = typeof(int);
			this.oOoO._o0.().Location = new Point(16, 30);
			this.oOoO._o0.().Name = "C1NumericEdit1";
			this.oOoO._o0.().Size = new Size(176, 21);
			this.oOoO._o0.().TabIndex = 1;
			this.oOoO._o0.().Tag = null;
			this.oOoO._o0.().Value = 2;
			this.oOoO._o0.().VisibleButtons = DropDownControlButtonFlags.UpDown;
			this.O_o000._o_.().Location = new Point(25, 71);
			this.O_o000._o_.().Name = "Button1";
			this.O_o000._o_.().Size = new Size(75, 23);
			this.O_o000._o_.().TabIndex = 2;
			this.O_o000._o_.().Text = "确定";
			this.O_o000._o_.().UseVisualStyleBackColor = true;
			this.oo_OOoOoo.OO.().DialogResult = DialogResult.Cancel;
			this.oo_OOoOoo.OO.().Location = new Point(106, 71);
			this.oo_OOoOoo.OO.().Name = "Button2";
			this.oo_OOoOoo.OO.().Size = new Size(75, 23);
			this.oo_OOoOoo.OO.().TabIndex = 3;
			this.oo_OOoOoo.OO.().Text = "取消";
			this.oo_OOoOoo.OO.().UseVisualStyleBackColor = true;
			base.AcceptButton = this.O_o000._o_.();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.oo_OOoOoo.OO.();
			base.ClientSize = new Size(206, 106);
			base.Controls.Add(this.oo_OOoOoo.OO.());
			base.Controls.Add(this.O_o000._o_.());
			base.Controls.Add(this.oOoO._o0.());
			base.Controls.Add(this.oOoO._o0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O...oO0.";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "frmInputInteger";
			((ISupportInitialize)this.oOoO._o0.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000583CE File Offset: 0x000565CE
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo.__0o_0_Oo.;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000583D6 File Offset: 0x000565D6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo.__0o_0_Oo. = A_0;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x000583DF File Offset: 0x000565DF
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.Oo.__0o_0_Oo.;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x000583E7 File Offset: 0x000565E7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.Oo.__0o_0_Oo. = A_0;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000583F0 File Offset: 0x000565F0
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo.__0o_0_Oo.;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000583F8 File Offset: 0x000565F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo_OOoOoo.OO.);
			C1Button oo.__0o_0_Oo. = this.Oo.__0o_0_Oo.;
			if (oo.__0o_0_Oo. != null)
			{
				oo.__0o_0_Oo..Click -= value;
			}
			this.Oo.__0o_0_Oo. = A_0;
			oo.__0o_0_Oo. = this.Oo.__0o_0_Oo.;
			if (oo.__0o_0_Oo. != null)
			{
				oo.__0o_0_Oo..Click += value;
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0005843B File Offset: 0x0005663B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_0o0OoOoO._.;
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00058443 File Offset: 0x00056643
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.Oo_0o0OoOoO._. = A_0;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0005844C File Offset: 0x0005664C
		public int <<EMPTY_NAME>>()
		{
			return this.Oo.__0o_0_Oo.;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00058454 File Offset: 0x00056654
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x00058466 File Offset: 0x00056666
		public int Value
		{
			get
			{
				return Conversions.ToInteger(this.oOoO._o0.().Value);
			}
			set
			{
				this.oOoO._o0.().Value = value;
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0005847C File Offset: 0x0005667C
		public O\u3002\u3000\u3002(string A_0, string A_1, int A_2, int A_3, int A_4, string A_5)
		{
			base.FormClosed += this.oo_OOoOoo.OO.;
			this.oOoO._o0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.Text = A_0;
			this.oOoO._o0.().Text = A_1;
			this.O00.__0OOO. = A_4;
			this.Oo_0o0OoOoO._. = A_3;
			this.Oo.__0o_0_Oo. = A_2;
			this.oOoO._o0.().Value = A_2;
			this.Oo.__0o_0_Oo. = A_5;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000584FF File Offset: 0x000566FF
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Value < this.Oo_0o0OoOoO._. || this.Value > this.O00.__0OOO.)
			{
				MessageBox.Show(this.Oo.__0o_0_Oo., "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00058539 File Offset: 0x00056739
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040003E3 RID: 995
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040003E4 RID: 996
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040003E5 RID: 997
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x040003E6 RID: 998
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003E7 RID: 999
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003E8 RID: 1000
		private int <<EMPTY_NAME>>;

		// Token: 0x040003E9 RID: 1001
		private int <<EMPTY_NAME>>;

		// Token: 0x040003EA RID: 1002
		private int <<EMPTY_NAME>>;

		// Token: 0x040003EB RID: 1003
		private string <<EMPTY_NAME>>;
	}
}
