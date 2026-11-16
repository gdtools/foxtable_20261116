using System;
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
	// Token: 0x0200046F RID: 1135
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class o0\u3002 : Form
	{
		// Token: 0x06004D39 RID: 19769 RVA: 0x0022D34C File Offset: 0x0022B54C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OO00o0_.O0. != null)
				{
					this.OO00o0_.O0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x0022D38C File Offset: 0x0022B58C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oOOOO0_0._0.(new C1Button());
			this.oOOOO0_0._0.(new ListBox());
			this.oo.O0_0oO_Oo.(new C1Button());
			this.OO0ooOo.O0Oo_.(new C1Button());
			this.o_.Oo0.(new C1Button());
			this.oOOOO0_0._0.(new PropertyGrid());
			this.OO0O00._O_O0_o.(new C1Button());
			this.OO00._0.(new C1Button());
			base.SuspendLayout();
			this.o.0_o_.().Location = new Point(248, 250);
			this.o.0_o_.().Name = "btnRename";
			this.o.0_o_.().Size = new Size(75, 23);
			this.o.0_o_.().TabIndex = 13;
			this.o.0_o_.().Text = "重命名";
			this.o.0_o_.().UseVisualStyleBackColor = true;
			this.O0._o0_O0oO00_.().FormattingEnabled = true;
			this.O0._o0_O0oO00_.().IntegralHeight = false;
			this.O0._o0_O0oO00_.().ItemHeight = 12;
			this.O0._o0_O0oO00_.().Location = new Point(14, 11);
			this.O0._o0_O0oO00_.().Name = "ListBox1";
			this.O0._o0_O0oO00_.().Size = new Size(184, 223);
			this.O0._o0_O0oO00_.().TabIndex = 8;
			this.OO00._0.().Location = new Point(170, 250);
			this.OO00._0.().Name = "btnPreview";
			this.OO00._0.().Size = new Size(75, 23);
			this.OO00._0.().TabIndex = 12;
			this.OO00._0.().Text = "预览";
			this.OO00._0.().UseVisualStyleBackColor = true;
			this.OOOoO_0.000.().Location = new Point(404, 250);
			this.OOOoO_0.000.().Name = "btnCancel";
			this.OOOoO_0.000.().Size = new Size(75, 23);
			this.OOOoO_0.000.().TabIndex = 15;
			this.OOOoO_0.000.().Text = "取消";
			this.OOOoO_0.000.().UseVisualStyleBackColor = true;
			this.o.oO0oO_o0o0.().Location = new Point(326, 250);
			this.o.oO0oO_o0o0.().Name = "btnOk";
			this.o.oO0oO_o0o0.().Size = new Size(75, 23);
			this.o.oO0oO_o0o0.().TabIndex = 14;
			this.o.oO0oO_o0o0.().Text = "确定";
			this.o.oO0oO_o0o0.().UseVisualStyleBackColor = true;
			this.O0._o0_O0oO00_.().Location = new Point(204, 11);
			this.O0._o0_O0oO00_.().Name = "PropertyGrid1";
			this.O0._o0_O0oO00_.().Size = new Size(275, 223);
			this.O0._o0_O0oO00_.().TabIndex = 9;
			this.O0._o0_O0oO00_.().ToolbarVisible = false;
			this.Oo.o00.().Location = new Point(92, 250);
			this.Oo.o00.().Name = "btnDelete";
			this.Oo.o00.().Size = new Size(75, 23);
			this.Oo.o00.().TabIndex = 11;
			this.Oo.o00.().Text = "删除";
			this.Oo.o00.().UseVisualStyleBackColor = true;
			this.Oo0oo.OO_.().Location = new Point(14, 250);
			this.Oo0oo.OO_.().Name = "btnAdd";
			this.Oo0oo.OO_.().Size = new Size(75, 23);
			this.Oo0oo.OO_.().TabIndex = 10;
			this.Oo0oo.OO_.().Text = "增加";
			this.Oo0oo.OO_.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(492, 284);
			base.Controls.Add(this.o.0_o_.());
			base.Controls.Add(this.O0._o0_O0oO00_.());
			base.Controls.Add(this.OO00._0.());
			base.Controls.Add(this.OOOoO_0.000.());
			base.Controls.Add(this.o.oO0oO_o0o0.());
			base.Controls.Add(this.O0._o0_O0oO00_.());
			base.Controls.Add(this.Oo.o00.());
			base.Controls.Add(this.Oo0oo.OO_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O..oo..O";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "专业报表";
			base.ResumeLayout(false);
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x0022D824 File Offset: 0x0022BA24
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO00o0_.O0.;
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x0022D82C File Offset: 0x0022BA2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_Oo_0.0_0o.);
			C1Button oo00o0_.O0. = this.OO00o0_.O0.;
			if (oo00o0_.O0. != null)
			{
				oo00o0_.O0..Click -= value;
			}
			this.OO00o0_.O0. = A_0;
			oo00o0_.O0. = this.OO00o0_.O0.;
			if (oo00o0_.O0. != null)
			{
				oo00o0_.O0..Click += value;
			}
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x0022D86F File Offset: 0x0022BA6F
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.OO00o0_.O0.;
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x0022D877 File Offset: 0x0022BA77
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.OO00o0_.O0. = A_0;
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x0022D880 File Offset: 0x0022BA80
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO___.o000_.;
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x0022D888 File Offset: 0x0022BA88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo.o00.);
			C1Button oo___.o000_. = this.OO___.o000_.;
			if (oo___.o000_. != null)
			{
				oo___.o000_..Click -= value;
			}
			this.OO___.o000_. = A_0;
			oo___.o000_. = this.OO___.o000_.;
			if (oo___.o000_. != null)
			{
				oo___.o000_..Click += value;
			}
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x0022D8CB File Offset: 0x0022BACB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.Ooo__.;
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x0022D8D4 File Offset: 0x0022BAD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.o_OOO000000.);
			C1Button o.Ooo__. = this.O.Ooo__.;
			if (o.Ooo__. != null)
			{
				o.Ooo__..Click -= value;
			}
			this.O.Ooo__. = A_0;
			o.Ooo__. = this.O.Ooo__.;
			if (o.Ooo__. != null)
			{
				o.Ooo__..Click += value;
			}
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x0022D917 File Offset: 0x0022BB17
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooO._o0O0o__o.;
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x0022D920 File Offset: 0x0022BB20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O._OO_0o.);
			C1Button c1Button = this.ooO._o0O0o__o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooO._o0O0o__o. = A_0;
			c1Button = this.ooO._o0O0o__o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x0022D963 File Offset: 0x0022BB63
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.OO00o0_.O0.;
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x0022D96C File Offset: 0x0022BB6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.O0._o0_O0oO00_.);
			PropertyGrid oo00o0_.O0. = this.OO00o0_.O0.;
			if (oo00o0_.O0. != null)
			{
				oo00o0_.O0..PropertyValueChanged -= value;
			}
			this.OO00o0_.O0. = A_0;
			oo00o0_.O0. = this.OO00o0_.O0.;
			if (oo00o0_.O0. != null)
			{
				oo00o0_.O0..PropertyValueChanged += value;
			}
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x0022D9AF File Offset: 0x0022BBAF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo0o_.ooo.;
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x0022D9B8 File Offset: 0x0022BBB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOo__.O0o.);
			C1Button c1Button = this.oo0o_.ooo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo0o_.ooo. = A_0;
			c1Button = this.oo0o_.ooo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x0022D9FB File Offset: 0x0022BBFB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_.Oo0.;
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x0022DA04 File Offset: 0x0022BC04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0O_.0OO__o.);
			C1Button c1Button = this.o_.Oo0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_.Oo0. = A_0;
			c1Button = this.o_.Oo0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x0022DA47 File Offset: 0x0022BC47
		[CompilerGenerated]
		private virtual CurrencyManager <<EMPTY_NAME>>()
		{
			return this.OO00o0_.O0.;
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x0022DA50 File Offset: 0x0022BC50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(CurrencyManager A_0)
		{
			EventHandler value = new EventHandler(this.Oo0oo.OO_.);
			CurrencyManager oo00o0_.O0. = this.OO00o0_.O0.;
			if (oo00o0_.O0. != null)
			{
				oo00o0_.O0..CurrentChanged -= value;
			}
			this.OO00o0_.O0. = A_0;
			oo00o0_.O0. = this.OO00o0_.O0.;
			if (oo00o0_.O0. != null)
			{
				oo00o0_.O0..CurrentChanged += value;
			}
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x0022DA94 File Offset: 0x0022BC94
		public o0\u3002()
		{
			base.FormClosed += this.Oo.o00.;
			base.Load += this.Oo0_0OO0.ooO_0.;
			this.OO00o0_.O0. = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
			this.O0._o0_O0oO00_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x0022DB00 File Offset: 0x0022BD00
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Oo00.o0_o._O_.(this.OO00o0_.O0., true);
			OO_00oOO.Reports.o.0OoO.();
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x0022DB18 File Offset: 0x0022BD18
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO00o0_.O0. = new DataView(this.OO00o0_.O0., "[Table] = '" + OO_00oOO.MainTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(6), "", DataViewRowState.CurrentRows);
			this.O0._o0_O0oO00_.().DisplayMember = "Name";
			this.O0._o0_O0oO00_.().DataSource = this.OO00o0_.O0.;
			this.oOOOO0_0._0.((CurrencyManager)this.BindingContext[this.OO00o0_.O0.]);
			this.Oo0oo.OO_.(this.O0._o0_O0oO00_.(), null);
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x0022DBAB File Offset: 0x0022BDAB
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
			Oo00.o0_o._O_.(this.OO00o0_.O0., true);
			OO_00oOO.Reports.o.0OoO.();
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x0022DBDA File Offset: 0x0022BDDA
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO00o0_.O0..RejectChanges();
			OO_00oOO.Reports.o.0OoO.();
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x0022DBF8 File Offset: 0x0022BDF8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0._o0_O0oO00_.().Position >= 0 && MessageBox.Show("确定要删除选定的报表吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				((DataRowView)this.O0._o0_O0oO00_.().Current).Delete();
				OO_00oOO.Reports.o.0OoO.();
			}
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x0022DC48 File Offset: 0x0022BE48
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataRow dataRow = this.OO00o0_.O0..NewRow();
			dataRow["Table"] = OO_00oOO.MainTable.Name;
			dataRow["Type"] = ExtendTablePropertyTypeEnum.CodeReport;
			dataRow["Name"] = o_O_o_oOoo__.OO_O0oO0.oooO_.(this.OO00o0_.O0., this.OO00o0_.O0..Columns["Name"], "报表");
			this.OO00o0_.O0..Rows.Add(dataRow);
			this.O0._o0_O0oO00_.().Position = this.O0._o0_O0oO00_.().Count - 1;
			OO_00oOO.Reports.o.0OoO.();
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x0022DCEC File Offset: 0x0022BEEC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0._o0_O0oO00_.().Position >= 0)
			{
				o\u3000\u3000 o_u3000_u = new o\u3000\u3000("重命名", "请输入报表名称:", Conversions.ToString(((DataRowView)this.O0._o0_O0oO00_.().Current)["Name"]));
				o_u3000_u.Oo.__0o_0_Oo.(new o\u3000\u3000.ooOOO_O_Oo_0(this.oOOOO0_0._0.));
				if (o_u3000_u.ShowDialog() == DialogResult.OK)
				{
					((DataRowView)this.O0._o0_O0oO00_.().Current)["Name"] = o_u3000_u.Value;
					((DataRowView)this.O0._o0_O0oO00_.().Current).EndEdit();
				}
			}
			OO_00oOO.Reports.o.0OoO.();
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x0022DD90 File Offset: 0x0022BF90
		private void <<EMPTY_NAME>>(o\u3000\u3000 A_0, ValidateInputTextEventArgs A_1)
		{
			if (Operators.CompareString(A_1.Value, "", true) == 0)
			{
				MessageBox.Show("请输入报表名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
				return;
			}
			if (Operators.CompareString(A_1.Value, A_1.OriginalValue, true) != 0)
			{
				foreach (DataRow dataRow in this.OO00o0_.O0..Select("", "", DataViewRowState.CurrentRows))
				{
					if (Operators.CompareString(Conversions.ToString(dataRow["Name"]), A_1.Value, true) == 0 && Conversions.ToInteger(dataRow["Type"]) == 6)
					{
						MessageBox.Show("已经存在同名报表，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						A_1.Cancel = true;
					}
				}
			}
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x0022DE54 File Offset: 0x0022C054
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0._o0_O0oO00_.().Position < 0)
			{
				this.O0._o0_O0oO00_.().SelectedObject = null;
				return;
			}
			DataRowView dataRowView = (DataRowView)this.O0._o0_O0oO00_.().Current;
			ReportProperty reportProperty = new ReportProperty();
			if (!dataRowView.Row.IsNull("Property"))
			{
				o_O_o_oOoo__.OOOO_OO._oo.(reportProperty, Conversions.ToString(dataRowView["Property"]), '\v');
			}
			this.O0._o0_O0oO00_.().SelectedObject = reportProperty;
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x0022DEC9 File Offset: 0x0022C0C9
		private void <<EMPTY_NAME>>(object A_0, PropertyValueChangedEventArgs A_1)
		{
			((DataRowView)this.O0._o0_O0oO00_.().Current).Row["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(this.O0._o0_O0oO00_.().SelectedObject), false, '\v', false);
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x0022DF04 File Offset: 0x0022C104
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OO_00oOO.Reports.o.0OoO.();
			if (this.O0._o0_O0oO00_.().Position >= 0)
			{
				DataRowView dataRowView = (DataRowView)this.O0._o0_O0oO00_.().Current;
				OO_00oOO.Reports[Conversions.ToString(dataRowView["Name"])].Execute();
			}
		}

		// Token: 0x04001F91 RID: 8081
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001F92 RID: 8082
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001F93 RID: 8083
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x04001F94 RID: 8084
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001F95 RID: 8085
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001F96 RID: 8086
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001F97 RID: 8087
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x04001F98 RID: 8088
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001F99 RID: 8089
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001F9A RID: 8090
		private DataView <<EMPTY_NAME>>;

		// Token: 0x04001F9B RID: 8091
		[CompilerGenerated]
		private CurrencyManager <<EMPTY_NAME>>;

		// Token: 0x04001F9C RID: 8092
		private DataTable <<EMPTY_NAME>>;
	}
}
