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
	// Token: 0x0200037D RID: 893
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3002 : Form
	{
		// Token: 0x0600396E RID: 14702 RVA: 0x0019AE8C File Offset: 0x0019908C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o.O_0_0. != null)
				{
					this.o.O_0_0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x0019AECC File Offset: 0x001990CC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oo00O.oO.(new Label());
			this.OOoO0.OO0ooo00.(new C1Button());
			this.oo0.0O0O_Oo.(new C1Button());
			this.O_.Ooo0_OOo.(new Label());
			this.O_.Ooo0_OOo.(new CheckedListBox());
			this.o.o_O00.(new C1Button());
			this.o_oO00.0_o0o.(new C1Button());
			this.OOo0O.o_o_0.(new C1Button());
			this.OO_0OO0O_0._.(new C1Button());
			base.SuspendLayout();
			this.o.o_O00.().AutoSize = true;
			this.o.o_O00.().Location = new Point(11, 11);
			this.o.o_O00.().Name = "Label1";
			this.o.o_O00.().Size = new Size(23, 12);
			this.o.o_O00.().TabIndex = 1;
			this.o.o_O00.().Text = "列:";
			this.OO0_O.00O.().Location = new Point(296, 299);
			this.OO0_O.00O.().Name = "Button1";
			this.OO0_O.00O.().Size = new Size(75, 23);
			this.OO0_O.00O.().TabIndex = 5;
			this.OO0_O.00O.().Text = "确定";
			this.OO0_O.00O.().UseVisualStyleBackColor = true;
			this.O_.0oO0.().Location = new Point(296, 328);
			this.O_.0oO0.().Name = "Button2";
			this.O_.0oO0.().Size = new Size(75, 23);
			this.O_.0oO0.().TabIndex = 6;
			this.O_.0oO0.().Text = "取消";
			this.O_.0oO0.().UseVisualStyleBackColor = true;
			this.OOo0O.o_o_0.().AutoSize = true;
			this.OOo0O.o_o_0.().Location = new Point(11, 362);
			this.OOo0O.o_o_0.().Name = "Label2";
			this.OOo0O.o_o_0.().Size = new Size(143, 12);
			this.OOo0O.o_o_0.().TabIndex = 4;
			this.OOo0O.o_o_0.().Text = "提示:未选中的列将被隐藏";
			this.o.o_O00.().FormattingEnabled = true;
			this.o.o_O00.().Location = new Point(13, 28);
			this.o.o_O00.().Name = "CheckedListBox1";
			this.o.o_O00.().Size = new Size(266, 324);
			this.o.o_O00.().TabIndex = 0;
			this.O.0o0__.().Location = new Point(296, 86);
			this.O.0o0__.().Name = "Button3";
			this.O.0o0__.().Size = new Size(75, 23);
			this.O.0o0__.().TabIndex = 3;
			this.O.0o0__.().Text = "全选";
			this.O.0o0__.().UseVisualStyleBackColor = true;
			this.oO0000._.().Location = new Point(296, 115);
			this.oO0000._.().Name = "Button4";
			this.oO0000._.().Size = new Size(75, 23);
			this.oO0000._.().TabIndex = 4;
			this.oO0000._.().Text = "反选";
			this.oO0000._.().UseVisualStyleBackColor = true;
			this.oO0oo_O.O0O_O_.().Location = new Point(296, 28);
			this.oO0oo_O.O0O_O_.().Name = "btnMoveup";
			this.oO0oo_O.O0O_O_.().Size = new Size(75, 23);
			this.oO0oo_O.O0O_O_.().TabIndex = 1;
			this.oO0oo_O.O0O_O_.().Text = "上移";
			this.oO0oo_O.O0O_O_.().UseVisualStyleBackColor = true;
			this.O.O00__0.().Location = new Point(296, 57);
			this.O.O00__0.().Name = "btnMoveDown";
			this.O.O00__0.().Size = new Size(75, 23);
			this.O.O00__0.().TabIndex = 2;
			this.O.O00__0.().Text = "下移";
			this.O.O00__0.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(383, 385);
			base.Controls.Add(this.O.O00__0.());
			base.Controls.Add(this.oO0oo_O.O0O_O_.());
			base.Controls.Add(this.oO0000._.());
			base.Controls.Add(this.O.0o0__.());
			base.Controls.Add(this.o.o_O00.());
			base.Controls.Add(this.OOo0O.o_o_0.());
			base.Controls.Add(this.O_.0oO0.());
			base.Controls.Add(this.OO0_O.00O.());
			base.Controls.Add(this.o.o_O00.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oO..Oo..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "取消隐藏列";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x0019B3CD File Offset: 0x001995CD
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.O_0_0.;
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x0019B3D5 File Offset: 0x001995D5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.O_0_0. = A_0;
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x0019B3DE File Offset: 0x001995DE
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_.Ooo0_OOo.;
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x0019B3E8 File Offset: 0x001995E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoO_.Oo.);
			C1Button o_.Ooo0_OOo. = this.O_.Ooo0_OOo.;
			if (o_.Ooo0_OOo. != null)
			{
				o_.Ooo0_OOo..Click -= value;
			}
			this.O_.Ooo0_OOo. = A_0;
			o_.Ooo0_OOo. = this.O_.Ooo0_OOo.;
			if (o_.Ooo0_OOo. != null)
			{
				o_.Ooo0_OOo..Click += value;
			}
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x0019B42B File Offset: 0x0019962B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo00O.oO.;
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x0019B434 File Offset: 0x00199634
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_oO_.__O000o.);
			C1Button c1Button = this.oo00O.oO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo00O.oO. = A_0;
			c1Button = this.oo00O.oO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x0019B477 File Offset: 0x00199677
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_.OO_.;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x0019B47F File Offset: 0x0019967F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_.OO_. = A_0;
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x0019B488 File Offset: 0x00199688
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.O_.Ooo0_OOo.;
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x0019B490 File Offset: 0x00199690
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.ooO00.0o0.);
			EventHandler value2 = new EventHandler(this.O_.0oO0.);
			CheckedListBox o_.Ooo0_OOo. = this.O_.Ooo0_OOo.;
			if (o_.Ooo0_OOo. != null)
			{
				o_.Ooo0_OOo..MouseDown -= value;
				o_.Ooo0_OOo..SelectedIndexChanged -= value2;
			}
			this.O_.Ooo0_OOo. = A_0;
			o_.Ooo0_OOo. = this.O_.Ooo0_OOo.;
			if (o_.Ooo0_OOo. != null)
			{
				o_.Ooo0_OOo..MouseDown += value;
				o_.Ooo0_OOo..SelectedIndexChanged += value2;
			}
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x0019B4EE File Offset: 0x001996EE
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0_O0O__o._.;
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x0019B4F8 File Offset: 0x001996F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.ooooo_.o.);
			C1Button o0_O0O__o._. = this.O0_O0O__o._.;
			if (o0_O0O__o._. != null)
			{
				o0_O0O__o._..Click -= value;
			}
			this.O0_O0O__o._. = A_0;
			o0_O0O__o._. = this.O0_O0O__o._.;
			if (o0_O0O__o._. != null)
			{
				o0_O0O__o._..Click += value;
			}
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x0019B53B File Offset: 0x0019973B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOo.oO0OOO.;
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x0019B544 File Offset: 0x00199744
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oooo_oO.0OOOO.);
			C1Button c1Button = this.oOo.oO0OOO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOo.oO0OOO. = A_0;
			c1Button = this.oOo.oO0OOO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x0019B587 File Offset: 0x00199787
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.000_.;
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x0019B590 File Offset: 0x00199790
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O000._O_o_0Oo.);
			C1Button o.000_. = this.O.000_.;
			if (o.000_. != null)
			{
				o.000_..Click -= value;
			}
			this.O.000_. = A_0;
			o.000_. = this.O.000_.;
			if (o.000_. != null)
			{
				o.000_..Click += value;
			}
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x0019B5D3 File Offset: 0x001997D3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_O_oo.0Oo_o.;
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x0019B5DC File Offset: 0x001997DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_._O_o.);
			C1Button o_O_oo.0Oo_o. = this.O_O_oo.0Oo_o.;
			if (o_O_oo.0Oo_o. != null)
			{
				o_O_oo.0Oo_o..Click -= value;
			}
			this.O_O_oo.0Oo_o. = A_0;
			o_O_oo.0Oo_o. = this.O_O_oo.0Oo_o.;
			if (o_O_oo.0Oo_o. != null)
			{
				o_O_oo.0Oo_o..Click += value;
			}
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x0019B620 File Offset: 0x00199820
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num = this.o.o_O00.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				this.o.o_O00.().SetItemChecked(i, true);
			}
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x0019B65C File Offset: 0x0019985C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num = this.o.o_O00.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				this.o.o_O00.().SetItemChecked(i, !this.o.o_O00.().GetItemChecked(i));
			}
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x0019B6A3 File Offset: 0x001998A3
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x0019B6AC File Offset: 0x001998AC
		public O\u3002\u3000\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3002(Table A_0)
		{
			base.Load += this.O.O00__0.;
			base.FormClosed += this.O_.0oO0.;
			this.o.o_O00.();
			this.o.O_0_0. = A_0;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x0019B708 File Offset: 0x00199908
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int @fixed = this.o.O_0_0..foxGrid.Cols.Fixed;
			int num = this.o.O_0_0..foxGrid.Cols.Count - 1;
			for (int i = @fixed; i <= num; i++)
			{
				if (!o_O_o_oOoo__.oO.O_..Contains(this.o.O_0_0..foxGrid.Cols[i].Name))
				{
					this.o.o_O00.().Items.Add(this.o.O_0_0..foxGrid.Cols[i].Name);
					this.o.o_O00.().SetItemChecked(this.o.o_O00.().Items.Count - 1, this.o.O_0_0..foxGrid.Cols[i].Visible);
				}
			}
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x0019B7E0 File Offset: 0x001999E0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.O_0_0..O_o0OOo_.o0..O__00.__0_O.(new ooO0O__o_o_O_(this.o.O_0_0.));
			this.o.O_0_0..NeedSaveSetting = true;
			int num = this.o.o_O00.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string columnName = this.o.o_O00.().Items[i].ToString();
				if (this.o.O_0_0..foxGrid.Cols[columnName].Index != i + 1)
				{
					this.o.O_0_0..foxGrid.Cols[columnName].Move(i + 1);
				}
				this.o.O_0_0..foxGrid.Cols[columnName].Visible = this.o.o_O00.().GetItemChecked(i);
			}
			base.Close();
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x0019B8BC File Offset: 0x00199ABC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.o_O00.().SelectedIndex > 0)
			{
				bool itemChecked = this.o.o_O00.().GetItemChecked(this.o.o_O00.().SelectedIndex);
				string item = this.o.o_O00.().SelectedItem.ToString();
				int num = this.o.o_O00.().SelectedIndex;
				this.o.o_O00.().Items.RemoveAt(num);
				num--;
				this.o.o_O00.().Items.Insert(num, item);
				this.o.o_O00.().SetItemChecked(num, itemChecked);
				this.o.o_O00.().SelectedIndex = num;
			}
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x0019B94C File Offset: 0x00199B4C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.o_O00.().SelectedIndex < this.o.o_O00.().Items.Count - 1)
			{
				bool itemChecked = this.o.o_O00.().GetItemChecked(this.o.o_O00.().SelectedIndex);
				string item = this.o.o_O00.().SelectedItem.ToString();
				int num = this.o.o_O00.().SelectedIndex;
				this.o.o_O00.().Items.RemoveAt(num);
				num++;
				this.o.o_O00.().Items.Insert(num, item);
				this.o.o_O00.().SetItemChecked(num, itemChecked);
				this.o.o_O00.().SelectedIndex = num;
			}
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x0019B9EC File Offset: 0x00199BEC
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (A_1.Button == MouseButtons.Left && this.o.o_O00.().SelectedIndex >= 0 && this.o.o_O00.().SelectedIndex != this.o.O_0_0.)
			{
				this.o.O_0_0. = this.o.o_O00.().SelectedIndex;
				Point pt = this.o.o_O00.().PointToClient(Control.MousePosition);
				Rectangle itemRectangle = this.o.o_O00.().GetItemRectangle(this.o.o_O00.().SelectedIndex);
				if (itemRectangle.Contains(pt) && pt.X < itemRectangle.X + 16)
				{
					this.o.o_O00.().SetItemChecked(this.o.o_O00.().SelectedIndex, !this.o.o_O00.().GetItemChecked(this.o.o_O00.().SelectedIndex));
				}
			}
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x0019BAB5 File Offset: 0x00199CB5
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.O_0_0. = this.o.o_O00.().SelectedIndex;
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x0019BAC8 File Offset: 0x00199CC8
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001785 RID: 6021
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001786 RID: 6022
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001787 RID: 6023
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001788 RID: 6024
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001789 RID: 6025
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400178A RID: 6026
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x0400178B RID: 6027
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400178C RID: 6028
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400178D RID: 6029
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400178E RID: 6030
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400178F RID: 6031
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001790 RID: 6032
		private int <<EMPTY_NAME>>;
	}
}
