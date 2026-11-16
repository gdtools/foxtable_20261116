using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003EC RID: 1004
	[DesignerGenerated]
	internal partial class O\u30000\u3002\u3002O : DropDownForm
	{
		// Token: 0x06004145 RID: 16709 RVA: 0x001D7D94 File Offset: 0x001D5F94
		public O\u30000\u3002\u3002O()
		{
			base.Activated += this.Oo.o_oOo0_o.;
			base.Load += this.oo.00O0_.;
			this.o_0_0__.o_. = new StringFormat();
			this.OOOO.0. = 6;
			this.OOOO.0.();
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x001D7DE4 File Offset: 0x001D5FE4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o_0_0__.o_. != null)
				{
					this.o_0_0__.o_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x001D7E24 File Offset: 0x001D6024
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OOOO.0.(new System.Windows.Forms.ListBox());
			base.SuspendLayout();
			this.OOOO.0.().Dock = DockStyle.Top;
			this.OOOO.0.().DrawMode = DrawMode.OwnerDrawFixed;
			this.OOOO.0.().FormattingEnabled = true;
			this.OOOO.0.().IntegralHeight = false;
			this.OOOO.0.().ItemHeight = 18;
			this.OOOO.0.().Location = new Point(0, 0);
			this.OOOO.0.().Name = "ListBox";
			this.OOOO.0.().Size = new Size(148, 220);
			this.OOOO.0.().TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.BorderStyle = BorderStyle.None;
			base.ClientSize = new Size(148, 220);
			base.Controls.Add(this.OOOO.0.());
			base.Name = "o....o.O";
			this.Text = "frmListBox";
			base.ResumeLayout(false);
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x001D7F2D File Offset: 0x001D612D
		[CompilerGenerated]
		internal virtual System.Windows.Forms.ListBox <<EMPTY_NAME>>()
		{
			return this.o_0_0__.o_.;
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x001D7F38 File Offset: 0x001D6138
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.ListBox A_0)
		{
			EventHandler value = new EventHandler(this.O_.oOO_0_.);
			KeyEventHandler value2 = new KeyEventHandler(this.OOOO.0.);
			DrawItemEventHandler value3 = new DrawItemEventHandler(this.OOOO.0.);
			EventHandler value4 = new EventHandler(this.OOOO.0.);
			System.Windows.Forms.ListBox listBox = this.o_0_0__.o_.;
			if (listBox != null)
			{
				listBox.Click -= value;
				listBox.KeyDown -= value2;
				listBox.DrawItem -= value3;
				listBox.FontChanged -= value4;
			}
			this.o_0_0__.o_. = A_0;
			listBox = this.o_0_0__.o_.;
			if (listBox != null)
			{
				listBox.Click += value;
				listBox.KeyDown += value2;
				listBox.DrawItem += value3;
				listBox.FontChanged += value4;
			}
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x001D7FD8 File Offset: 0x001D61D8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OOOO.0.().SelectedIndex >= 0)
			{
				base.OwnerControl.Value = RuntimeHelpers.GetObjectValue(this.Value);
			}
			base.CloseDropDown();
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x001D8004 File Offset: 0x001D6204
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Return || A_1.KeyCode == Keys.Space)
			{
				if (this.OOOO.0.().SelectedIndex >= 0)
				{
					base.OwnerControl.Value = RuntimeHelpers.GetObjectValue(this.Value);
				}
				A_1.SuppressKeyPress = true;
				A_1.Handled = true;
				base.CloseDropDown();
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x0600414C RID: 16716 RVA: 0x001D8060 File Offset: 0x001D6260
		private object Value
		{
			get
			{
				object result;
				if (this.OOOO.0.().DataSource == null)
				{
					result = this.OOOO.0.().SelectedItem;
				}
				else
				{
					result = this.OOOO.0.().SelectedValue;
				}
				return result;
			}
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x001D8095 File Offset: 0x001D6295
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OOOO.0.().Focus();
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x001D80A3 File Offset: 0x001D62A3
		internal int <<EMPTY_NAME>>()
		{
			return this.OOOO.0.;
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x001D80AB File Offset: 0x001D62AB
		internal void <<EMPTY_NAME>>(int A_0)
		{
			this.OOOO.0. = A_0;
			this.OOOO.0.().ItemHeight = (int)Math.Ceiling((double)(this.OOOO.0.().Font.Size / 9f * 12f)) + A_0;
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x001D80E4 File Offset: 0x001D62E4
		private void <<EMPTY_NAME>>(object A_0, DrawItemEventArgs A_1)
		{
			if (A_1.Index >= 0)
			{
				A_1.DrawBackground();
				A_1.DrawFocusRectangle();
				string text = "";
				if (this.OOOO.0.().DataSource != null)
				{
					if (base.OwnerControl is OoOO0Oo_oo0oO)
					{
						Foxtable.WinForm.Form o.oO. = ((OoOO0Oo_oo0oO)base.OwnerControl).O.oO.;
						System.Windows.Forms.Control ownerControl = base.OwnerControl;
						ListItemFormatEventArgs listItemFormatEventArgs = new ListItemFormatEventArgs(ownerControl, o.oO., (DataRowView)this.OOOO.0.().Items[A_1.Index]);
						string a_ = "ListItemFormat_" + Conversions.ToString(ownerControl.Tag);
						O_O0OO.OoO_o.oO0o0O.(o.oO..O_0.O00o_00_O., a_, new object[]
						{
							listItemFormatEventArgs
						}, false, o.oO..mmname + "," + ownerControl.Name, false);
						if (Operators.CompareString(listItemFormatEventArgs.Text, "", true) > 0)
						{
							text = listItemFormatEventArgs.Text;
						}
					}
					if (Operators.CompareString(text, "", true) == 0)
					{
						DataRowView dataRowView = (DataRowView)this.OOOO.0.().Items[A_1.Index];
						if (Operators.CompareString(this.OOOO.0.().DisplayMember, "", true) > 0)
						{
							text = dataRowView[this.OOOO.0.().DisplayMember].ToString();
						}
						else
						{
							text = dataRowView.ToString();
						}
					}
				}
				else
				{
					text = this.OOOO.0.().Items[A_1.Index].ToString();
				}
				A_1.Graphics.DrawString(text, A_1.Font, new SolidBrush(A_1.ForeColor), A_1.Bounds, this.o_0_0__.o_.);
			}
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x001D8280 File Offset: 0x001D6480
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_0_0__.o_..LineAlignment = StringAlignment.Center;
			this.o_0_0__.o_..Alignment = StringAlignment.Near;
			this.o_0_0__.o_..FormatFlags = (this.o_0_0__.o_..FormatFlags | StringFormatFlags.NoWrap);
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x001D82B6 File Offset: 0x001D64B6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OOOO.0.().ItemHeight = (int)Math.Ceiling((double)(this.OOOO.0.().Font.Size / 9f * 12f)) + this.O0o0o.o.();
		}

		// Token: 0x04001A58 RID: 6744
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001A59 RID: 6745
		[CompilerGenerated]
		private System.Windows.Forms.ListBox <<EMPTY_NAME>>;

		// Token: 0x04001A5A RID: 6746
		private StringFormat <<EMPTY_NAME>>;

		// Token: 0x04001A5B RID: 6747
		internal int <<EMPTY_NAME>>;
	}
}
