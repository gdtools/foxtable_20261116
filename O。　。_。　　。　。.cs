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
	// Token: 0x020004C8 RID: 1224
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class O\u3002\u3000\u3002_\u3002\u3000\u3000\u3002\u3000\u3002\u3000 : Form
	{
		// Token: 0x0600507C RID: 20604 RVA: 0x00239A3C File Offset: 0x00237C3C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.Ooo_oo._o. != null)
				{
					this.Ooo_oo._o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x00239A7C File Offset: 0x00237C7C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0O__.OO.(new C1Button());
			this.oOooOoOo._0Oo.(new C1Button());
			base.SuspendLayout();
			this.o.oo_0OOOooo_.().Location = new Point(6, 5);
			this.o.oo_0OOOooo_.().Name = "btnSave";
			this.o.oo_0OOOooo_.().Size = new Size(147, 24);
			this.o.oo_0OOOooo_.().TabIndex = 0;
			this.o.oo_0OOOooo_.().Text = "保存菜单";
			this.o.oo_0OOOooo_.().UseVisualStyleBackColor = true;
			this.oOooOoOo._0Oo.().Location = new Point(6, 35);
			this.oOooOoOo._0Oo.().Name = "btnModify";
			this.oOooOoOo._0Oo.().Size = new Size(147, 24);
			this.oOooOoOo._0Oo.().TabIndex = 1;
			this.oOooOoOo._0Oo.().Text = "修改菜单";
			this.oOooOoOo._0Oo.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(158, 68);
			base.ControlBox = false;
			base.Controls.Add(this.oOooOoOo._0Oo.());
			base.Controls.Add(this.o.oo_0OOOooo_.());
			base.Location = new Point(500, 300);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CurrentTable";
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "菜单预览";
			base.ResumeLayout(false);
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x00239C06 File Offset: 0x00237E06
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Ooo_oo._o.;
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x00239C10 File Offset: 0x00237E10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0_OO0o.OO0O0.);
			C1Button ooo_oo._o. = this.Ooo_oo._o.;
			if (ooo_oo._o. != null)
			{
				ooo_oo._o..Click -= value;
			}
			this.Ooo_oo._o. = A_0;
			ooo_oo._o. = this.Ooo_oo._o.;
			if (ooo_oo._o. != null)
			{
				ooo_oo._o..Click += value;
			}
		}

		// Token: 0x06005080 RID: 20608 RVA: 0x00239C53 File Offset: 0x00237E53
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0O__.OO.;
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x00239C5C File Offset: 0x00237E5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.oo_0OOOooo_.);
			C1Button c1Button = this.o0O__.OO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0O__.OO. = A_0;
			c1Button = this.o0O__.OO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x00239CA0 File Offset: 0x00237EA0
		internal O\u3002\u3000\u3002_\u3002\u3000\u3000\u3002\u3000\u3002\u3000(o_\u3002\u3002\u3000\u3000\u3002 A_0)
		{
			base.Click += this.oOooOoOo._0Oo.;
			base.FormClosed += this.oOooOoOo._0Oo.;
			this.oOooOoOo._0Oo.();
			this.Ooo_oo._o. = A_0;
			O_O0OO.o0OoO00OO.00O. = this;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x00239D00 File Offset: 0x00237F00
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			O_O0OO.o0OoO00OO.00O. = null;
			Stack<o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000> stack = new Stack<o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000>();
			for (o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000 o_u3002__u3000_u3002__u3002_u3002_u3002O_u = (o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)this.Ooo_oo._o..oOoo_0O.oo00oO.; o_u3002__u3000_u3002__u3002_u3002_u3002O_u != null; o_u3002__u3000_u3002__u3002_u3002_u3002O_u = (o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)o_u3002__u3000_u3002__u3002_u3002_u3002O_u.ooO.Oo_.)
			{
				stack.Push(o_u3002__u3000_u3002__u3002_u3002_u3002O_u);
				if (o_u3002__u3000_u3002__u3002_u3002_u3002O_u.ooO.Oo_. == null)
				{
					break;
				}
			}
			this.Ooo_oo._o..oOoo_0O.oo00oO. = null;
			try
			{
				foreach (o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000 o_u3002__u3000_u3002__u3002_u3002_u3002O_u in stack)
				{
					o_u3002__u3000_u3002__u3002_u3002_u3002O_u.oO.o00o00Oo_O. = null;
					o_u3002__u3000_u3002__u3002_u3002_u3002O_u.ooO.Oo_. = null;
				}
			}
			finally
			{
				Stack<o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			while (stack.Count != 0)
			{
				o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000 o_u3002__u3000_u3002__u3002_u3002_u3002O_u = stack.Pop();
				o_u3002__u3000_u3002__u3002_u3002_u3002O_u.OOoO__Oo_oo.O_.();
				o_u3002__u3000_u3002__u3002_u3002_u3002O_u.Dispose();
			}
			this.Ooo_oo._o..Ooo_o._.();
			this.Ooo_oo._o..Dispose();
			this.Ooo_oo._o. = null;
			base.Close();
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x00239DE0 File Offset: 0x00237FE0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			O_O0OO.o0OoO00OO.00O. = null;
			base.Hide();
			Main.OO_O.o..OOoo___.0.(this.Ooo_oo._o..Controls, "(default)");
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.Ooo_oo._o..O_o0._00oOO.()
			});
			this.Ooo_oo._o..O0.0000OOO0_oo. = true;
			this.Ooo_oo._o..ShowDialog();
			this.Ooo_oo._o. = null;
			base.Close();
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x00239E5B File Offset: 0x0023805B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00239E5D File Offset: 0x0023805D
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04002120 RID: 8480
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04002121 RID: 8481
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002122 RID: 8482
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002123 RID: 8483
		private o_\u3002\u3002\u3000\u3000\u3002 <<EMPTY_NAME>>;
	}
}
