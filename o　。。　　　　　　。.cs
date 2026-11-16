using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000347 RID: 839
	[DesignerGenerated]
	internal partial class o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002 : Form
	{
		// Token: 0x0600334E RID: 13134 RVA: 0x0015EAC8 File Offset: 0x0015CCC8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O0.__O0O. != null)
				{
					this.O0.__O0O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x0015EB08 File Offset: 0x0015CD08
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O_o_00.00O0.(new C1FlexGrid());
			this.O_o_00.00O0.(new C1ComboBox());
			this.O0.00_0_.(new C1Button());
			this.o_oO.oo0OoO_O.(new C1Button());
			this.O0.00_0_.(new OpenFileDialog());
			this.O_._OoOOOo__o_.(new RadioButton());
			this.O_o_00.00O0.(new RadioButton());
			this.OO._OOO.(new RadioButton());
			((ISupportInitialize)this.OoO_.O.()).BeginInit();
			base.SuspendLayout();
			this.OoO_.O.().AllowEditing = false;
			this.OoO_.O.().ColumnInfo = "10,1,0,0,0,0,Columns:";
			this.OoO_.O.().Location = new Point(12, 48);
			this.OoO_.O.().Name = "Grid";
			this.OoO_.O.().Rows.Count = 1;
			this.OoO_.O.().Rows.DefaultSize = 20;
			this.OoO_.O.().SelectionMode = SelectionModeEnum.Column;
			this.OoO_.O.().Size = new Size(646, 345);
			this.OoO_.O.().TabIndex = 1;
			this.O0.00_0_.().DropDownStyle = DropDownStyle.DropDownList;
			this.O0.00_0_.().Location = new Point(12, 12);
			this.O0.00_0_.().Name = "lstTables";
			this.O0.00_0_.().Size = new Size(374, 20);
			this.O0.00_0_.().TabIndex = 0;
			this.o_Oo_o.OoO_o.().DialogResult = DialogResult.Cancel;
			this.o_Oo_o.OoO_o.().Location = new Point(333, 442);
			this.o_Oo_o.OoO_o.().Name = "Button3";
			this.o_Oo_o.OoO_o.().Size = new Size(75, 23);
			this.o_Oo_o.OoO_o.().TabIndex = 6;
			this.o_Oo_o.OoO_o.().Text = "取消";
			this.o_Oo_o.OoO_o.().UseVisualStyleBackColor = true;
			this.OoO_.O.().Location = new Point(252, 442);
			this.OoO_.O.().Name = "Button2";
			this.OoO_.O.().Size = new Size(75, 23);
			this.OoO_.O.().TabIndex = 5;
			this.OoO_.O.().Text = "确定";
			this.OoO_.O.().UseVisualStyleBackColor = true;
			this.OoO_.O.().Filter = "XML文件(*.xml)|*.xml";
			this.o_oO.oo0OoO_O.().AutoSize = true;
			this.o_oO.oo0OoO_O.().Location = new Point(272, 408);
			this.o_oO.oo0OoO_O.().Name = "IgnorePrimaryKey";
			this.o_oO.oo0OoO_O.().Size = new Size(203, 16);
			this.o_oO.oo0OoO_O.().TabIndex = 4;
			this.o_oO.oo0OoO_O.().Text = "合并过程不比较主键(无条件合并)";
			this.o_oO.oo0OoO_O.().UseVisualStyleBackColor = true;
			this.OO0O.o_oOO.().AutoSize = true;
			this.OO0O.o_oOO.().Checked = true;
			this.OO0O.o_oOO.().Location = new Point(142, 408);
			this.OO0O.o_oOO.().Name = "SkipExistRow";
			this.OO0O.o_oOO.().Size = new Size(107, 16);
			this.OO0O.o_oOO.().TabIndex = 3;
			this.OO0O.o_oOO.().TabStop = true;
			this.OO0O.o_oOO.().Text = "跳过同主键记录";
			this.OO0O.o_oOO.().UseVisualStyleBackColor = true;
			this.O0.00_0_.().AutoSize = true;
			this.O0.00_0_.().Location = new Point(12, 408);
			this.O0.00_0_.().Name = "UpdateExistRow";
			this.O0.00_0_.().Size = new Size(107, 16);
			this.O0.00_0_.().TabIndex = 2;
			this.O0.00_0_.().Text = "更新同主键记录";
			this.O0.00_0_.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(673, 477);
			base.Controls.Add(this.o_oO.oo0OoO_O.());
			base.Controls.Add(this.OO0O.o_oOO.());
			base.Controls.Add(this.O0.00_0_.());
			base.Controls.Add(this.OoO_.O.());
			base.Controls.Add(this.O0.00_0_.());
			base.Controls.Add(this.o_Oo_o.OoO_o.());
			base.Controls.Add(this.OoO_.O.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o....O0.";
			base.ShowIcon = false;
			this.Text = "合并";
			((ISupportInitialize)this.OoO_.O.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x0015EFA7 File Offset: 0x0015D1A7
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O_o_00.00O0.;
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x0015EFAF File Offset: 0x0015D1AF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.O_o_00.00O0. = A_0;
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x0015EFB8 File Offset: 0x0015D1B8
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O0.__O0O.;
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x0015EFC0 File Offset: 0x0015D1C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.o_oO.oo0OoO_O.);
			C1ComboBox o0.__O0O. = this.O0.__O0O.;
			if (o0.__O0O. != null)
			{
				o0.__O0O..SelectedIndexChanged -= value;
			}
			this.O0.__O0O. = A_0;
			o0.__O0O. = this.O0.__O0O.;
			if (o0.__O0O. != null)
			{
				o0.__O0O..SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x0015F003 File Offset: 0x0015D203
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_o_00.00O0.;
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x0015F00B File Offset: 0x0015D20B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O_o_00.00O0. = A_0;
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x0015F014 File Offset: 0x0015D214
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_._OoOOOo__o_.;
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x0015F01C File Offset: 0x0015D21C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoO_.O.);
			C1Button o_._OoOOOo__o_. = this.O_._OoOOOo__o_.;
			if (o_._OoOOOo__o_. != null)
			{
				o_._OoOOOo__o_..Click -= value;
			}
			this.O_._OoOOOo__o_. = A_0;
			o_._OoOOOo__o_. = this.O_._OoOOOo__o_.;
			if (o_._OoOOOo__o_. != null)
			{
				o_._OoOOOo__o_..Click += value;
			}
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x0015F05F File Offset: 0x0015D25F
		[CompilerGenerated]
		internal virtual OpenFileDialog <<EMPTY_NAME>>()
		{
			return this.O_o_00.00O0.;
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x0015F067 File Offset: 0x0015D267
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(OpenFileDialog A_0)
		{
			this.O_o_00.00O0. = A_0;
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x0015F070 File Offset: 0x0015D270
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O_o_00.00O0.;
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x0015F078 File Offset: 0x0015D278
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O_o_00.00O0. = A_0;
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x0015F081 File Offset: 0x0015D281
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O0O.O.;
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x0015F089 File Offset: 0x0015D289
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O0O.O. = A_0;
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x0015F092 File Offset: 0x0015D292
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O0__oo__0_O.0_.;
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x0015F09A File Offset: 0x0015D29A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O0__oo__0_O.0_. = A_0;
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x0015F0A3 File Offset: 0x0015D2A3
		public o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002()
		{
			base.FormClosed += this.OoO_.O.;
			this.O0.00_0_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x0015F0D8 File Offset: 0x0015D2D8
		internal bool <<EMPTY_NAME>>()
		{
			this.O0.__O0O. = new DataSet();
			this.O0.__O0O..ReadXml(this.O0.__O0O.);
			bool result;
			if (this.O0.__O0O..Tables.Count > 0)
			{
				this.O0.00_0_.().Items.Add("请选择要合并的表...");
				try
				{
					foreach (object obj in this.O0.__O0O..Tables)
					{
						DataTable dataTable = (DataTable)obj;
						this.O0.00_0_.().Items.Add(dataTable.TableName);
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
				if (this.O0.00_0_.().Items.Count == 2)
				{
					this.O0.00_0_.().SelectedIndex = 1;
				}
				else
				{
					this.O0.00_0_.().SelectedIndex = 0;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x0015F1C4 File Offset: 0x0015D3C4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OoO_.O.().AutoResize = true;
			if (this.O0.00_0_.().SelectedIndex == 0)
			{
				this.OoO_.O.().DataSource = null;
				return;
			}
			this.OoO_.O.().DataSource = this.O0.__O0O..Tables[this.O0.00_0_.().SelectedItem.ToString()];
			for (int i = this.OoO_.O.().Cols.Count - 1; i >= 1; i += -1)
			{
				if (o_O_o_oOoo__.oO.O_..Contains(this.OoO_.O.().Cols[i].Name))
				{
					this.OoO_.O.().Cols.Remove(i);
				}
			}
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x0015F274 File Offset: 0x0015D474
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0.00_0_.().SelectedIndex >= 1)
			{
				try
				{
					TableMergeTypeEnum a_;
					if (this.O0.00_0_.().Checked)
					{
						a_ = TableMergeTypeEnum.UpdateExistRow;
					}
					else if (this.o_oO.oo0OoO_O.().Checked)
					{
						a_ = TableMergeTypeEnum.IgnorePrimaryKey;
					}
					else
					{
						a_ = TableMergeTypeEnum.UpdateExistRow;
					}
					this.Cursor = Cursors.WaitCursor;
					if (Oo00.o00O0O_.O.(this.OoO_.O.(), this.O0.00_0_.().SelectedItem.ToString(), a_))
					{
						base.DialogResult = DialogResult.OK;
					}
				}
				catch (Exception a_2)
				{
					ooO.oOo0Oo.o.(a_2, "");
					this.Cursor = Cursors.Default;
				}
			}
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x0015F31C File Offset: 0x0015D51C
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001493 RID: 5267
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001494 RID: 5268
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001495 RID: 5269
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001496 RID: 5270
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001497 RID: 5271
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001498 RID: 5272
		[CompilerGenerated]
		private OpenFileDialog <<EMPTY_NAME>>;

		// Token: 0x04001499 RID: 5273
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400149A RID: 5274
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400149B RID: 5275
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400149C RID: 5276
		internal string <<EMPTY_NAME>>;

		// Token: 0x0400149D RID: 5277
		internal DataSet <<EMPTY_NAME>>;
	}
}
