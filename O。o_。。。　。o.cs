using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200035A RID: 858
	[DesignerGenerated]
	internal partial class O\u3002o_\u3002\u3002\u3002\u3000\u3002o : Form
	{
		// Token: 0x06003578 RID: 13688 RVA: 0x00172324 File Offset: 0x00170524
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o_.0o. != null)
				{
					this.o_.0o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x00172364 File Offset: 0x00170564
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oO_._0o0.(new C1ComboBox());
			this.OoooO0O0._o0_O.(new Label());
			this.oO_._0o0.(new C1Button());
			this.o_.0o.(new Label());
			this.o.Oo0o0oo__.(new Label());
			this.o_.0o.(new oO_oO000oo());
			((ISupportInitialize)this.oO_._0o0.()).BeginInit();
			((ISupportInitialize)this.oO_._0o0.()).BeginInit();
			base.SuspendLayout();
			this.oO_._0o0.().AllowSpinLoop = false;
			this.oO_._0o0.().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.oO_._0o0.().Cursor = Cursors.Arrow;
			this.oO_._0o0.().DropDownStyle = DropDownStyle.DropDownList;
			this.oO_._0o0.().GapHeight = 0;
			this.oO_._0o0.().ImagePadding = new Padding(0);
			this.oO_._0o0.().ItemsDisplayMember = "";
			this.oO_._0o0.().ItemsValueMember = "";
			this.oO_._0o0.().Location = new Point(12, 30);
			this.oO_._0o0.().Name = "cmbDataSource";
			this.oO_._0o0.().Size = new Size(503, 19);
			this.oO_._0o0.().TabIndex = 1;
			this.oO_._0o0.().Tag = null;
			this.oO_._0o0.().AutoSize = true;
			this.oO_._0o0.().Location = new Point(12, 9);
			this.oO_._0o0.().Name = "Label1";
			this.oO_._0o0.().Size = new Size(83, 12);
			this.oO_._0o0.().TabIndex = 11;
			this.oO_._0o0.().Text = "请选择数据源:";
			this.oO_._0o0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.oO_._0o0.().Location = new Point(440, 322);
			this.oO_._0o0.().Name = "btnPreview";
			this.oO_._0o0.().Size = new Size(75, 24);
			this.oO_._0o0.().TabIndex = 2;
			this.oO_._0o0.().Text = "执行";
			this.oO_._0o0.().UseVisualStyleBackColor = true;
			this.o_oOO__oO._.().AutoSize = true;
			this.o_oOO__oO._.().Location = new Point(12, 59);
			this.o_oOO__oO._.().Name = "Label2";
			this.o_oOO__oO._.().Size = new Size(89, 12);
			this.o_oOO__oO._.().TabIndex = 9;
			this.o_oOO__oO._.().Text = "请输入SQL语句:";
			this.OoooO0O0._o0_O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.OoooO0O0._o0_O.().Location = new Point(12, 317);
			this.OoooO0O0._o0_O.().Name = "Label3";
			this.OoooO0O0._o0_O.().Size = new Size(410, 23);
			this.OoooO0O0._o0_O.().TabIndex = 13;
			this.OoooO0O0._o0_O.().Text = "提示：表的名称必须用大括号括起来，例如：Select * From {订单}";
			this.oO_._0o0.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.oO_._0o0.().Location = new Point(12, 80);
			this.oO_._0o0.().Name = "txtSql";
			this.oO_._0o0.().Size = new Size(503, 230);
			this.oO_._0o0.().TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(527, 357);
			base.Controls.Add(this.oO_._0o0.());
			base.Controls.Add(this.OoooO0O0._o0_O.());
			base.Controls.Add(this.oO_._0o0.());
			base.Controls.Add(this.oO_._0o0.());
			base.Controls.Add(this.oO_._0o0.());
			base.Controls.Add(this.o_oOO__oO._.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o0.0_...o";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "SQL Excuter";
			((ISupportInitialize)this.oO_._0o0.()).EndInit();
			((ISupportInitialize)this.oO_._0o0.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x0017277A File Offset: 0x0017097A
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o_.0o.;
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x00172782 File Offset: 0x00170982
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.o_.0o. = A_0;
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x0017278B File Offset: 0x0017098B
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_.0o.;
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x00172793 File Offset: 0x00170993
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_.0o. = A_0;
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x0017279C File Offset: 0x0017099C
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_.0o.;
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x001727A4 File Offset: 0x001709A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o__00.ooOo.);
			C1Button c1Button = this.o_.0o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_.0o. = A_0;
			c1Button = this.o_.0o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x001727E7 File Offset: 0x001709E7
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.Oo0o0oo__.;
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x001727EF File Offset: 0x001709EF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.Oo0o0oo__. = A_0;
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x001727F8 File Offset: 0x001709F8
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOoOo_O.OO.;
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x00172800 File Offset: 0x00170A00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOoOo_O.OO. = A_0;
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x00172809 File Offset: 0x00170A09
		[CompilerGenerated]
		internal virtual oO_oO000oo <<EMPTY_NAME>>()
		{
			return this.o_.0o.;
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x00172811 File Offset: 0x00170A11
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(oO_oO000oo A_0)
		{
			this.o_.0o. = A_0;
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x0017281C File Offset: 0x00170A1C
		public O\u3002o_\u3002\u3002\u3002\u3000\u3002o()
		{
			base.Load += this.O.0oOO0o00Oo.;
			base.FormClosed += this.o__00.ooOo.;
			this.oO_._0o0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oO_._0o0.().oO.O_oo_o_O.();
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x0017287C File Offset: 0x00170A7C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oO_._0o0.().Items.Add("内部数据源");
			try
			{
				foreach (object obj in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()].Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (!dataRow.IsNull("Name") && Operators.CompareString(Conversions.ToString(dataRow["Name"]), "", true) > 0)
					{
						this.oO_._0o0.().Items.Add(Conversions.ToString(dataRow["Name"]));
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
			this.oO_._0o0.().SelectedIndex = 0;
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x00172954 File Offset: 0x00170B54
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.oO_._0o0.().Text, "", true) > 0)
			{
				this.oO_._0o0.().Text = this.oO_._0o0.().Text.Trim(new char[]
				{
					' ',
					'\r',
					'\n'
				});
			}
			if (!this.oO_._0o0.().Text.ToLower().StartsWith("select") && !this.oO_._0o0.().Text.ToLower().StartsWith("transform") && !this.oO_._0o0.().Text.ToLower().StartsWith("exec"))
			{
				SQLCommand sqlcommand = new SQLCommand();
				if (this.oO_._0o0.().SelectedIndex > 0)
				{
					sqlcommand.ConnectionName = this.oO_._0o0.().SelectedItem.ToString();
				}
				sqlcommand.CommandText = this.oO_._0o0.().Text;
				sqlcommand.ExecuteNonQuery();
				return;
			}
			if (this.oO_._0o0.().SelectedIndex == 0)
			{
				new O_\u30000_\u3002O\u3002\u3002\u3000\u3000(O_O0OO.OoO.0OO__0ooo.(), this.oO_._0o0.().Text, null).ShowDialog();
				return;
			}
			OleDbConnection a_ = null;
			O0O a_2 = null;
			if (O_O0OO.O._o_.().ContainsKey(this.oO_._0o0.().Text))
			{
				a_ = O_O0OO.O._o_.()[this.oO_._0o0.().Text];
			}
			else
			{
				a_2 = O_O0OO.OoO__.0oO0oo.()[this.oO_._0o0.().Text];
			}
			new O_\u30000_\u3002O\u3002\u3002\u3000\u3000(a_, this.oO_._0o0.().Text, a_2).ShowDialog();
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x00172ACB File Offset: 0x00170CCB
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400158B RID: 5515
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400158C RID: 5516
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x0400158D RID: 5517
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400158E RID: 5518
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400158F RID: 5519
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001590 RID: 5520
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001591 RID: 5521
		[CompilerGenerated]
		private oO_oO000oo <<EMPTY_NAME>>;
	}
}
