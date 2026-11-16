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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000381 RID: 897
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3000\u3000\u3000\u3000 : Form
	{
		// Token: 0x060039E6 RID: 14822 RVA: 0x0019F020 File Offset: 0x0019D220
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.Oo.0OOoooO. != null)
				{
					this.Oo.0OOoooO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x0019F060 File Offset: 0x0019D260
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Oooo_.oo0oO.(new SplitContainer());
			this.Oooo_.oo0oO.(new ListBox());
			this.Oooo_.oo0oO.(new PropertyGrid());
			this.oO_oO_.__.(new C1Button());
			this.oo__0.00_00O0_.(new C1Button());
			this.O.__0OO_O.(new C1Button());
			this.oo_0.o__o00__0.(new C1Button());
			this.Oooo_.oo0oO.(new C1Button());
			this.oOo.Oo.().Panel1.SuspendLayout();
			this.oOo.Oo.().Panel2.SuspendLayout();
			this.oOo.Oo.().SuspendLayout();
			base.SuspendLayout();
			this.oOo.Oo.().Location = new Point(12, 12);
			this.oOo.Oo.().Name = "SplitContainer1";
			this.oOo.Oo.().Panel1.Controls.Add(this.oOo.Oo.());
			this.oOo.Oo.().Panel2.Controls.Add(this.oOo.Oo.());
			this.oOo.Oo.().Size = new Size(571, 305);
			this.oOo.Oo.().SplitterDistance = 190;
			this.oOo.Oo.().TabIndex = 0;
			this.oOo.Oo.().Dock = DockStyle.Fill;
			this.oOo.Oo.().FormattingEnabled = true;
			this.oOo.Oo.().ItemHeight = 12;
			this.oOo.Oo.().Location = new Point(0, 0);
			this.oOo.Oo.().Name = "ListBox1";
			this.oOo.Oo.().Size = new Size(190, 304);
			this.oOo.Oo.().TabIndex = 0;
			this.oOo.Oo.().Dock = DockStyle.Fill;
			this.oOo.Oo.().Location = new Point(0, 0);
			this.oOo.Oo.().Name = "PropertyGrid1";
			this.oOo.Oo.().Size = new Size(377, 305);
			this.oOo.Oo.().TabIndex = 0;
			this.oOo.Oo.().ToolbarVisible = false;
			this.o.O_00O.().Location = new Point(93, 336);
			this.o.O_00O.().Name = "btnDelete";
			this.o.O_00O.().Size = new Size(75, 23);
			this.o.O_00O.().TabIndex = 1;
			this.o.O_00O.().Text = "删除";
			this.o.O_00O.().UseVisualStyleBackColor = true;
			this.o0.oo_0o0oO0O.().Location = new Point(12, 336);
			this.o0.oo_0o0oO0O.().Name = "btnAdd";
			this.o0.oo_0o0oO0O.().Size = new Size(75, 23);
			this.o0.oo_0o0oO0O.().TabIndex = 0;
			this.o0.oo_0o0oO0O.().Text = "增加";
			this.o0.oo_0o0oO0O.().UseVisualStyleBackColor = true;
			this.oO0_.o__.().Location = new Point(425, 336);
			this.oO0_.o__.().Name = "btnAccept";
			this.oO0_.o__.().Size = new Size(75, 23);
			this.oO0_.o__.().TabIndex = 3;
			this.oO0_.o__.().Text = "确定";
			this.oO0_.o__.().UseVisualStyleBackColor = true;
			this.o.00o.().AllowDrop = true;
			this.o.00o.().Location = new Point(506, 336);
			this.o.00o.().Name = "btnCancel";
			this.o.00o.().Size = new Size(75, 23);
			this.o.00o.().TabIndex = 4;
			this.o.00o.().Text = "取消";
			this.o.00o.().UseVisualStyleBackColor = true;
			this.ooO0_._O_o_oO0.().Location = new Point(174, 336);
			this.ooO0_._O_o_oO0.().Name = "btnRestore";
			this.ooO0_._O_o_oO0.().Size = new Size(127, 23);
			this.ooO0_._O_o_oO0.().TabIndex = 2;
			this.ooO0_._O_o_oO0.().Text = "还原为默认值";
			this.ooO0_._O_o_oO0.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(595, 371);
			base.Controls.Add(this.ooO0_._O_o_oO0.());
			base.Controls.Add(this.o0.oo_0o0oO0O.());
			base.Controls.Add(this.o.O_00O.());
			base.Controls.Add(this.o.00o.());
			base.Controls.Add(this.oO0_.o__.());
			base.Controls.Add(this.oOo.Oo.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Oo.oO0o.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "自定义单元格样式";
			this.oOo.Oo.().Panel1.ResumeLayout(false);
			this.oOo.Oo.().Panel2.ResumeLayout(false);
			this.oOo.Oo.().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x0019F563 File Offset: 0x0019D763
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.Oo.0OOoooO.;
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x0019F56B File Offset: 0x0019D76B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.Oo.0OOoooO. = A_0;
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x0019F574 File Offset: 0x0019D774
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.Oo.0OOoooO.;
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x0019F57C File Offset: 0x0019D77C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.Oo.0OOoooO. = A_0;
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x0019F585 File Offset: 0x0019D785
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oooo_.oo0oO.;
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x0019F590 File Offset: 0x0019D790
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.ooO_O.OoO0O.);
			C1Button oooo_.oo0oO. = this.Oooo_.oo0oO.;
			if (oooo_.oo0oO. != null)
			{
				oooo_.oo0oO..Click -= value;
			}
			this.Oooo_.oo0oO. = A_0;
			oooo_.oo0oO. = this.Oooo_.oo0oO.;
			if (oooo_.oo0oO. != null)
			{
				oooo_.oo0oO..Click += value;
			}
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x0019F5D3 File Offset: 0x0019D7D3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o__OO_o0.oO__o.;
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x0019F5DC File Offset: 0x0019D7DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O__Ooooo.0o00.);
			C1Button c1Button = this.o__OO_o0.oO__o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o__OO_o0.oO__o. = A_0;
			c1Button = this.o__OO_o0.oO__o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x0019F61F File Offset: 0x0019D81F
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.Oo.0OOoooO.;
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x0019F628 File Offset: 0x0019D828
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.oOo.Oo.);
			PropertyGrid oo.0OOoooO. = this.Oo.0OOoooO.;
			if (oo.0OOoooO. != null)
			{
				oo.0OOoooO..PropertyValueChanged -= value;
			}
			this.Oo.0OOoooO. = A_0;
			oo.0OOoooO. = this.Oo.0OOoooO.;
			if (oo.0OOoooO. != null)
			{
				oo.0OOoooO..PropertyValueChanged += value;
			}
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x0019F66B File Offset: 0x0019D86B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO_oO_.__.;
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x0019F674 File Offset: 0x0019D874
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO._O_OO_.);
			C1Button c1Button = this.oO_oO_.__.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO_oO_.__. = A_0;
			c1Button = this.oO_oO_.__.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x0019F6B7 File Offset: 0x0019D8B7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_o_.O_0o0.;
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x0019F6C0 File Offset: 0x0019D8C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Ooo__.0.);
			C1Button o_o_.O_0o0. = this.O_o_.O_0o0.;
			if (o_o_.O_0o0. != null)
			{
				o_o_.O_0o0..Click -= value;
			}
			this.O_o_.O_0o0. = A_0;
			o_o_.O_0o0. = this.O_o_.O_0o0.;
			if (o_o_.O_0o0. != null)
			{
				o_o_.O_0o0..Click += value;
			}
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x0019F703 File Offset: 0x0019D903
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0oo.o0_0.;
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x0019F70C File Offset: 0x0019D90C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.O_00O.);
			C1Button c1Button = this.o0oo.o0_0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0oo.o0_0. = A_0;
			c1Button = this.o0oo.o0_0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x0019F74F File Offset: 0x0019D94F
		[CompilerGenerated]
		private virtual CurrencyManager <<EMPTY_NAME>>()
		{
			return this.Oo.0OOoooO.;
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x0019F758 File Offset: 0x0019D958
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(CurrencyManager A_0)
		{
			EventHandler value = new EventHandler(this.o0.oo_0o0oO0O.);
			CurrencyManager oo.0OOoooO. = this.Oo.0OOoooO.;
			if (oo.0OOoooO. != null)
			{
				oo.0OOoooO..CurrentChanged -= value;
			}
			this.Oo.0OOoooO. = A_0;
			oo.0OOoooO. = this.Oo.0OOoooO.;
			if (oo.0OOoooO. != null)
			{
				oo.0OOoooO..CurrentChanged += value;
			}
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x0019F79C File Offset: 0x0019D99C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Oooo_.oo0oO.((CurrencyManager)this.BindingContext[this.Oo.0OOoooO.]);
			this.oOo.Oo.().DisplayMember = "Name";
			this.oOo.Oo.().DataSource = this.Oo.0OOoooO.;
			this.oOo.Oo.().ValueMember = "Name";
			if (this.oOo.Oo.().Count > 0)
			{
				this.oOo.Oo.().Position = 0;
				this.oOo.Oo.();
			}
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x0019F818 File Offset: 0x0019DA18
		public O\u3002\u3002\u3000\u3000\u3000\u3000(DataTable A_0)
		{
			base.Load += this.O.0_o_0o_O.;
			base.FormClosed += this.o.O_00O.;
			this.oo_0.o__o00__0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.Oo.0OOoooO. = A_0;
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Name", typeof(string));
			dataTable.Columns.Add("Config", typeof(string));
			dataTable.PrimaryKey = new DataColumn[]
			{
				dataTable.Columns["Name"]
			};
			if (Operators.CompareString(A_0.frd_LookAndFeel.UserStyle, "", true) > 0)
			{
				foreach (string text in A_0.frd_LookAndFeel.UserStyle.Split(new char[]
				{
					'\r'
				}))
				{
					CellStyleProperty cellStyleProperty = new CellStyleProperty();
					o_O_o_oOoo__.OOOO_OO._oo.(cellStyleProperty, text, '\n');
					DataRow dataRow = dataTable.NewRow();
					dataRow["Name"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(cellStyleProperty.Name, "", true) == 0, "", cellStyleProperty.Name));
					dataRow["Config"] = text;
					dataTable.Rows.Add(dataRow);
				}
			}
			dataTable.AcceptChanges();
			this.Oo.0OOoooO. = new DataView(dataTable);
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x0019F994 File Offset: 0x0019DB94
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			CellStyleProperty cellStyleProperty = new CellStyleProperty();
			DataRow dataRow = this.Oo.0OOoooO..Table.NewRow();
			cellStyleProperty.Name = o_O_o_oOoo__.OO_O0oO0.oooO_.(this.Oo.0OOoooO..Table, this.Oo.0OOoooO..Table.Columns["Name"], "样式");
			dataRow["Name"] = cellStyleProperty.Name;
			dataRow["Config"] = o_O_o_oOoo__.OOOO_OO._oo.(cellStyleProperty, false, '\n', false);
			this.Oo.0OOoooO..Table.Rows.Add(dataRow);
			if (this.oOo.Oo.().Count > 0)
			{
				this.oOo.Oo.().Position = this.oOo.Oo.().Count - 1;
			}
		}

		// Token: 0x060039FD RID: 14845 RVA: 0x0019FA4F File Offset: 0x0019DC4F
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oOo.Oo.().SelectedItem != null)
			{
				((DataRowView)this.oOo.Oo.().SelectedItem).Delete();
			}
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x0019FA74 File Offset: 0x0019DC74
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = "";
			try
			{
				foreach (object obj in this.Oo.0OOoooO.)
				{
					DataRowView dataRowView = (DataRowView)obj;
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += "\r";
					}
					text += dataRowView["Config"].ToString();
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
			this.Oo.0OOoooO..frd_LookAndFeel.UserStyle = text;
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (Operators.CompareString(table.View.o_o.O0ooOo.().TableName, this.Oo.0OOoooO..Name, true) == 0)
					{
						table.foxGrid.O._0ooo00o.();
						table.foxGrid.Invalidate();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			this.Oo.0OOoooO..OO00_o.ooOO.(false);
			base.Close();
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x0019FB98 File Offset: 0x0019DD98
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x0019FBA0 File Offset: 0x0019DDA0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oOo.Oo.();
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x0019FBA8 File Offset: 0x0019DDA8
		private void <<EMPTY_NAME>>()
		{
			if (this.oOo.Oo.().Position < 0)
			{
				this.oOo.Oo.().SelectedObject = null;
				return;
			}
			DataRow row = ((DataRowView)this.oOo.Oo.().Current).Row;
			CellStyleProperty cellStyleProperty = new CellStyleProperty();
			if (!row.IsNull("Config"))
			{
				o_O_o_oOoo__.OOOO_OO._oo.(cellStyleProperty, Conversions.ToString(row["Config"]), '\n');
			}
			this.oOo.Oo.().SelectedObject = cellStyleProperty;
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x0019FC20 File Offset: 0x0019DE20
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oOo.Oo.().SelectedObject != null)
			{
				CellStyleProperty cellStyleProperty = new CellStyleProperty();
				cellStyleProperty.Name = ((CellStyleProperty)this.oOo.Oo.().SelectedObject).Name;
				this.oOo.Oo.().SelectedObject = cellStyleProperty;
				((DataRowView)this.oOo.Oo.().Current)["Config"] = o_O_o_oOoo__.OOOO_OO._oo.(cellStyleProperty, false, '\n', false);
			}
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x0019FC8C File Offset: 0x0019DE8C
		private void <<EMPTY_NAME>>(object A_0, PropertyValueChangedEventArgs A_1)
		{
			if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "Name", true) == 0)
			{
				if (Operators.CompareString(Conversions.ToString(A_1.ChangedItem.Value), Conversions.ToString(A_1.OldValue), true) != 0 && this.Oo.0OOoooO..Table.Rows.Find(new object[]
				{
					A_1.ChangedItem.Value
				}) != null)
				{
					MessageBox.Show("重命名无效，相同名称的样式已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					((CellStyleProperty)this.oOo.Oo.().SelectedObject).Name = Conversions.ToString(A_1.OldValue);
					return;
				}
				CellStyleProperty cellStyleProperty = (CellStyleProperty)this.oOo.Oo.().SelectedObject;
				cellStyleProperty.Name = cellStyleProperty.Name.Replace("\r", "");
				((DataRowView)this.oOo.Oo.().Current)["Name"] = RuntimeHelpers.GetObjectValue(A_1.ChangedItem.Value);
			}
			((DataRowView)this.oOo.Oo.().Current)["Config"] = o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(this.oOo.Oo.().SelectedObject), false, '\n', false);
			this.oOo.Oo.().EndCurrentEdit();
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x0019FDCF File Offset: 0x0019DFCF
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040017BD RID: 6077
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040017BE RID: 6078
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x040017BF RID: 6079
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x040017C0 RID: 6080
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017C1 RID: 6081
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017C2 RID: 6082
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x040017C3 RID: 6083
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017C4 RID: 6084
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017C5 RID: 6085
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017C6 RID: 6086
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x040017C7 RID: 6087
		private DataView <<EMPTY_NAME>>;

		// Token: 0x040017C8 RID: 6088
		[CompilerGenerated]
		private CurrencyManager <<EMPTY_NAME>>;
	}
}
