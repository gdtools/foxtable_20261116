using System;
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
	// Token: 0x020000E0 RID: 224
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class o\u3002\u3000\u3000\u3002\u3002\u30020\u3002 : Form
	{
		// Token: 0x06000C09 RID: 3081 RVA: 0x000644F8 File Offset: 0x000626F8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O0.0o_0_o0. != null)
				{
					this.O0.0o_0_o0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00064538 File Offset: 0x00062738
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0.0o_0_o0.(new PropertyGrid());
			this.oo0O.o.(new C1Button());
			this.OO00__.oo__00.(new C1Button());
			this.O0.0o_0_o0.(new C1Button());
			((ISupportInitialize)this.O_o0.O.()).BeginInit();
			((ISupportInitialize)this.O_0.O_.()).BeginInit();
			((ISupportInitialize)this.OO00__.oo__00.()).BeginInit();
			base.SuspendLayout();
			this.O_o0.O.().Location = new Point(12, 13);
			this.O_o0.O.().Name = "PropertyGrid1";
			this.O_o0.O.().Size = new Size(388, 388);
			this.O_o0.O.().TabIndex = 0;
			this.O_o0.O.().ToolbarVisible = false;
			this.O_o0.O.().Location = new Point(224, 420);
			this.O_o0.O.().Name = "C1Button1";
			this.O_o0.O.().Size = new Size(85, 25);
			this.O_o0.O.().TabIndex = 1;
			this.O_o0.O.().Text = "确定";
			this.O_o0.O.().UseVisualStyleBackColor = true;
			this.O_0.O_.().Location = new Point(315, 420);
			this.O_0.O_.().Name = "btnCancel";
			this.O_0.O_.().Size = new Size(85, 25);
			this.O_0.O_.().TabIndex = 2;
			this.O_0.O_.().Text = "取消";
			this.O_0.O_.().UseVisualStyleBackColor = true;
			this.OO00__.oo__00.().Location = new Point(12, 420);
			this.OO00__.oo__00.().Name = "btnRestore";
			this.OO00__.oo__00.().Size = new Size(113, 25);
			this.OO00__.oo__00.().TabIndex = 3;
			this.OO00__.oo__00.().Text = "还原初始值";
			this.OO00__.oo__00.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(412, 457);
			base.Controls.Add(this.OO00__.oo__00.());
			base.Controls.Add(this.O_0.O_.());
			base.Controls.Add(this.O_o0.O.());
			base.Controls.Add(this.O_o0.O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oO...o..";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "环境选项";
			((ISupportInitialize)this.O_o0.O.()).EndInit();
			((ISupportInitialize)this.O_0.O_.()).EndInit();
			((ISupportInitialize)this.OO00__.oo__00.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000647F3 File Offset: 0x000629F3
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.O0.0o_0_o0.;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000647FC File Offset: 0x000629FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.O_o0.O.);
			PropertyGrid o0.0o_0_o0. = this.O0.0o_0_o0.;
			if (o0.0o_0_o0. != null)
			{
				o0.0o_0_o0..PropertyValueChanged -= value;
			}
			this.O0.0o_0_o0. = A_0;
			o0.0o_0_o0. = this.O0.0o_0_o0.;
			if (o0.0o_0_o0. != null)
			{
				o0.0o_0_o0..PropertyValueChanged += value;
			}
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0006483F File Offset: 0x00062A3F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0.0o_0_o0.;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00064848 File Offset: 0x00062A48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO00__.oo__00.);
			C1Button o0.0o_0_o0. = this.O0.0o_0_o0.;
			if (o0.0o_0_o0. != null)
			{
				o0.0o_0_o0..Click -= value;
			}
			this.O0.0o_0_o0. = A_0;
			o0.0o_0_o0. = this.O0.0o_0_o0.;
			if (o0.0o_0_o0. != null)
			{
				o0.0o_0_o0..Click += value;
			}
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0006488B File Offset: 0x00062A8B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.OoOoo_O.;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00064894 File Offset: 0x00062A94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOoo__O0_.oO_.);
			C1Button o.OoOoo_O. = this.O.OoOoo_O.;
			if (o.OoOoo_O. != null)
			{
				o.OoOoo_O..Click -= value;
			}
			this.O.OoOoo_O. = A_0;
			o.OoOoo_O. = this.O.OoOoo_O.;
			if (o.OoOoo_O. != null)
			{
				o.OoOoo_O..Click += value;
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x000648D7 File Offset: 0x00062AD7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo0O.o.;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000648E0 File Offset: 0x00062AE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0o.o0oO_.);
			C1Button c1Button = this.oo0O.o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo0O.o. = A_0;
			c1Button = this.oo0O.o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00064924 File Offset: 0x00062B24
		public o\u3002\u3000\u3000\u3002\u3002\u30020\u3002()
		{
			base.FormClosed += this.O_o0.O.;
			this.oo_0oooo.00O_O. = new ooo00oO();
			this.oo_0oooo.00O_O. = O_O0OO.Oo._00O0_oO.;
			this.O.o00. = O_O0OO.o_.oO_O0.;
			this.o0_._0O_0. = O_O0OO.O_.00.;
			this.o__.Oo. = O_O0OO.oo_oo_o._.;
			this.oo_0oooo.00O_O. = O_O0OO.oO_00Ooo___0._.;
			this.O.o00. = O_O0OO.o0O._O00o.;
			this.O0.0o_0_o0. = O_O0OO.O0_00o.o0__o.;
			this.O.o00. = O_O0OO.oo0_o_.o.;
			this.O_o0.O.();
			this.O_o0.O.().SelectedObject = new o_0oooo_OO(this.oo_0oooo.00O_O., new string[0], false, false);
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000649E8 File Offset: 0x00062BE8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(O_O0OO.O_.00., this.o0_._0O_0., true) != 0)
			{
				O_O0OO.O_.00. = this.o0_._0O_0.;
				Main.OO_O.o..OoO_oo00o0.Oo.(O_O0OO.O0_00o.o0__o..RibbonTheme);
			}
			if (Operators.CompareString(O_O0OO.Oo._00O0_oO., this.oo_0oooo.00O_O., true) != 0 || O_O0OO.o0O._O00o. != this.O.o00. || O_O0OO.O0_00o.o0__o. != this.O0.0o_0_o0. || O_O0OO.oo0_o_.o. != this.O.o00.)
			{
				O_O0OO.Oo._00O0_oO. = this.oo_0oooo.00O_O.;
				O_O0OO.o0O._O00o. = this.O.o00.;
				O_O0OO.O0_00o.o0__o. = this.O0.0o_0_o0.;
				O_O0OO.oo0_o_.o. = this.O.o00.;
				try
				{
					foreach (DataTable dataTable in OO_00oOO.DataTables)
					{
						dataTable.oOoOO0_o.O0_0.();
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
			}
			if (Operators.CompareString(O_O0OO.o_.oO_O0., this.O.o00., true) != 0)
			{
				O_O0OO.o_.oO_O0. = this.O.o00.;
				Main.OO_O.o..O0.0000oO.(O_O0OO.O0_00o.o0__o..ControlTheme);
			}
			if (Operators.CompareString(O_O0OO.oo_oo_o._., this.o__.Oo., true) != 0 || O_O0OO.oO_00Ooo___0._. != this.oo_0oooo.00O_O.)
			{
				O_O0OO.oo_oo_o._. = this.o__.Oo.;
				O_O0OO.oO_00Ooo___0._. = this.oo_0oooo.00O_O.;
				Main.OO_O.o..O.OOO0_OOo.().Font = new Font(O_O0OO.oo_oo_o._., (float)O_O0OO.oO_00Ooo___0._., Main.OO_O.o..O.OOO0_OOo.().Font.Style);
			}
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00064B7C File Offset: 0x00062D7C
		private void <<EMPTY_NAME>>(object A_0, PropertyValueChangedEventArgs A_1)
		{
			if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "ControlTheme", true) == 0)
			{
				O_O0OO.o_.oO_O0. = this.oo_0oooo.00O_O..ControlTheme;
				Main.OO_O.o..O0.0000oO.(O_O0OO.O0_00o.o0__o..ControlTheme);
			}
			else if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "RibbonTheme", true) == 0)
			{
				O_O0OO.O_.00. = this.oo_0oooo.00O_O..RibbonTheme;
				Main.OO_O.o..OoO_oo00o0.Oo.(O_O0OO.O0_00o.o0__o..RibbonTheme);
				base.TopMost = true;
			}
			else if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "RibbonFontName", true) == 0 || Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "RibbonFontSize", true) == 0)
			{
				O_O0OO.oo_oo_o._. = this.oo_0oooo.00O_O..RibbonFontName;
				O_O0OO.oO_00Ooo___0._. = this.oo_0oooo.00O_O..RibbonFontSize;
				Main.OO_O.o..O.OOO0_OOo.().Font = new Font(O_O0OO.O0_00o.o0__o..GetRibbonFontName, (float)O_O0OO.O0_00o.o0__o..GetRibbonFontSize, Main.OO_O.o..O.OOO0_OOo.().Font.Style);
			}
			else if ((Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "GridTheme", true) == 0 | Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "DisableAlterRowMode", true) == 0) || Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "AlterRowBackColor", true) == 0 || Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "AlterRowForeColor", true) == 0)
			{
				O_O0OO.Oo._00O0_oO. = this.oo_0oooo.00O_O..GridTheme;
				O_O0OO.o0O._O00o. = this.oo_0oooo.00O_O..DisableAlterRowMode;
				O_O0OO.O0_00o.o0__o. = this.oo_0oooo.00O_O..AlterRowBackColor;
				O_O0OO.oo0_o_.o. = this.oo_0oooo.00O_O..AlterRowForeColor;
				try
				{
					foreach (DataTable dataTable in OO_00oOO.DataTables)
					{
						dataTable.oOoOO0_o.O0_0.();
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
			}
			this.O0.0o_0_o0. = true;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00064DB4 File Offset: 0x00062FB4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0.0o_0_o0. && this.O0.0o_0_o0.)
			{
				ColorConverter colorConverter = new ColorConverter();
				DataRow dataRow = O_O0OO.O0_00o.o0__o..Rows.Find("ThemeOptions");
				if (dataRow == null)
				{
					dataRow = O_O0OO.O0_00o.o0__o..NewRow();
					dataRow["Name"] = "ThemeOptions";
				}
				dataRow["Config"] = string.Concat(new string[]
				{
					O_O0OO.O_.00.,
					"\v",
					O_O0OO.Oo._00O0_oO.,
					"\v",
					O_O0OO.o_.oO_O0.,
					"\v",
					O_O0OO.oo_oo_o._.,
					"\v",
					Conversions.ToString(O_O0OO.oO_00Ooo___0._.),
					"\v",
					Conversions.ToString(O_O0OO.o0O._O00o.),
					"\v",
					colorConverter.ConvertTo(O_O0OO.O0_00o.o0__o., typeof(string)).ToString(),
					"\v",
					colorConverter.ConvertTo(O_O0OO.oo0_o_.o., typeof(string)).ToString()
				});
				if (dataRow.RowState == DataRowState.Detached)
				{
					O_O0OO.O0_00o.o0__o..Rows.Add(dataRow);
				}
				Oo00.o0_o._O_.(O_O0OO.O0_00o.o0__o., true);
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00064F14 File Offset: 0x00063114
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			O_O0OO.O_.00. = "Office2013Green";
			O_O0OO.Oo._00O0_oO. = "Office2013Green";
			O_O0OO.o_.oO_O0. = "VS2013Green";
			O_O0OO.oo_oo_o._. = "宋体";
			O_O0OO.oO_00Ooo___0._. = 9;
			O_O0OO.O0_00o.o0__o. = Color.Transparent;
			O_O0OO.oo0_o_.o. = Color.Transparent;
			O_O0OO.o0O._O00o. = false;
			this.oo_0oooo.00O_O. = new ooo00oO();
			this.O_o0.O.().SelectedObject = new o_0oooo_OO(this.oo_0oooo.00O_O., new string[0], false, false);
			Main.OO_O.o..O0.0000oO.(O_O0OO.O0_00o.o0__o..ControlTheme);
			Main.OO_O.o..OoO_oo00o0.Oo.(O_O0OO.O0_00o.o0__o..RibbonTheme);
			Main.OO_O.o..O.OOO0_OOo.().Font = new Font(O_O0OO.O0_00o.o0__o..GetRibbonFontName, (float)O_O0OO.O0_00o.o0__o..GetRibbonFontSize, Main.OO_O.o..O.OOO0_OOo.().Font.Style);
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					dataTable.oOoOO0_o.O0_0.();
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
			this.O0.0o_0_o0. = true;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0006503C File Offset: 0x0006323C
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400048E RID: 1166
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400048F RID: 1167
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x04000490 RID: 1168
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000491 RID: 1169
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000492 RID: 1170
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000493 RID: 1171
		private ooo00oO <<EMPTY_NAME>>;

		// Token: 0x04000494 RID: 1172
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000495 RID: 1173
		private string <<EMPTY_NAME>>;

		// Token: 0x04000496 RID: 1174
		private string <<EMPTY_NAME>>;

		// Token: 0x04000497 RID: 1175
		private string <<EMPTY_NAME>>;

		// Token: 0x04000498 RID: 1176
		private string <<EMPTY_NAME>>;

		// Token: 0x04000499 RID: 1177
		private int <<EMPTY_NAME>>;

		// Token: 0x0400049A RID: 1178
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400049B RID: 1179
		private Color <<EMPTY_NAME>>;

		// Token: 0x0400049C RID: 1180
		private Color <<EMPTY_NAME>>;
	}
}
