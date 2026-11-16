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
	// Token: 0x02000344 RID: 836
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3000\u3000 : Form
	{
		// Token: 0x06003302 RID: 13058 RVA: 0x0015C6D0 File Offset: 0x0015A8D0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_o_O.0. != null)
				{
					this.O_o_O.0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x0015C710 File Offset: 0x0015A910
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0O.Oo.(new OpenFileDialog());
			this.oo__.0o0_Oo.(new C1Button());
			this.O0O.Oo.(new C1FlexGrid());
			this.O0O.Oo.(new C1ComboBox());
			this.O0O.Oo.(new C1Button());
			this.O_.0__.(new C1Button());
			((ISupportInitialize)this.o0.OO_OOO0oOO.()).BeginInit();
			base.SuspendLayout();
			this.o0.OO_OOO0oOO.().Filter = "XML文件(*.xml)|*.XML";
			this.Oo._o0oo_o0_O0.().Location = new Point(21, 422);
			this.Oo._o0oo_o0_O0.().Name = "Button1";
			this.Oo._o0oo_o0_O0.().Size = new Size(75, 23);
			this.Oo._o0oo_o0_O0.().TabIndex = 2;
			this.Oo._o0oo_o0_O0.().Text = "删除列";
			this.Oo._o0oo_o0_O0.().UseVisualStyleBackColor = true;
			this.o0.OO_OOO0oOO.().AllowDragging = AllowDraggingEnum.None;
			this.o0.OO_OOO0oOO.().AllowEditing = false;
			this.o0.OO_OOO0oOO.().AllowSorting = AllowSortingEnum.None;
			this.o0.OO_OOO0oOO.().ColumnInfo = "10,1,0,0,0,0,Columns:";
			this.o0.OO_OOO0oOO.().Location = new Point(21, 57);
			this.o0.OO_OOO0oOO.().Name = "Grid";
			this.o0.OO_OOO0oOO.().Rows.Count = 1;
			this.o0.OO_OOO0oOO.().Rows.DefaultSize = 20;
			this.o0.OO_OOO0oOO.().SelectionMode = SelectionModeEnum.ColumnRange;
			this.o0.OO_OOO0oOO.().Size = new Size(646, 345);
			this.o0.OO_OOO0oOO.().TabIndex = 1;
			this.o0.OO_OOO0oOO.().DropDownStyle = DropDownStyle.DropDownList;
			this.o0.OO_OOO0oOO.().Location = new Point(21, 21);
			this.o0.OO_OOO0oOO.().Name = "lstTables";
			this.o0.OO_OOO0oOO.().Size = new Size(374, 20);
			this.o0.OO_OOO0oOO.().TabIndex = 0;
			this.o0o_OooO0.oO.().DialogResult = DialogResult.Cancel;
			this.o0o_OooO0.oO.().Location = new Point(592, 422);
			this.o0o_OooO0.oO.().Name = "Button3";
			this.o0o_OooO0.oO.().Size = new Size(75, 23);
			this.o0o_OooO0.oO.().TabIndex = 4;
			this.o0o_OooO0.oO.().Text = "取消";
			this.o0o_OooO0.oO.().UseVisualStyleBackColor = true;
			this.o0.OO_OOO0oOO.().Location = new Point(507, 422);
			this.o0.OO_OOO0oOO.().Name = "Button2";
			this.o0.OO_OOO0oOO.().Size = new Size(75, 23);
			this.o0.OO_OOO0oOO.().TabIndex = 3;
			this.o0.OO_OOO0oOO.().Text = "确定";
			this.o0.OO_OOO0oOO.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(694, 464);
			base.Controls.Add(this.Oo._o0oo_o0_O0.());
			base.Controls.Add(this.o0.OO_OOO0oOO.());
			base.Controls.Add(this.o0.OO_OOO0oOO.());
			base.Controls.Add(this.o0o_OooO0.oO.());
			base.Controls.Add(this.o0.OO_OOO0oOO.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O....ooo";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "导入";
			((ISupportInitialize)this.o0.OO_OOO0oOO.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x0015CA8C File Offset: 0x0015AC8C
		[CompilerGenerated]
		internal virtual OpenFileDialog <<EMPTY_NAME>>()
		{
			return this.O_o_O.0.;
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x0015CA94 File Offset: 0x0015AC94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(OpenFileDialog A_0)
		{
			this.O_o_O.0. = A_0;
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x0015CA9D File Offset: 0x0015AC9D
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0O.Oo.;
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x0015CAA8 File Offset: 0x0015ACA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.OOo_0oO__.);
			C1Button o0O.Oo. = this.O0O.Oo.;
			if (o0O.Oo. != null)
			{
				o0O.Oo..Click -= value;
			}
			this.O0O.Oo. = A_0;
			o0O.Oo. = this.O0O.Oo.;
			if (o0O.Oo. != null)
			{
				o0O.Oo..Click += value;
			}
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x0015CAEB File Offset: 0x0015ACEB
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O_o_O.0.;
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x0015CAF3 File Offset: 0x0015ACF3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.O_o_O.0. = A_0;
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x0015CAFC File Offset: 0x0015ACFC
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O_o_O.0.;
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x0015CB04 File Offset: 0x0015AD04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O_.0__.);
			C1ComboBox o_o_O.0. = this.O_o_O.0.;
			if (o_o_O.0. != null)
			{
				o_o_O.0..SelectedIndexChanged -= value;
			}
			this.O_o_O.0. = A_0;
			o_o_O.0. = this.O_o_O.0.;
			if (o_o_O.0. != null)
			{
				o_o_O.0..SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x0015CB47 File Offset: 0x0015AD47
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o._Oo0o_.;
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x0015CB4F File Offset: 0x0015AD4F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o._Oo0o_. = A_0;
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x0015CB58 File Offset: 0x0015AD58
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_.0__.;
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x0015CB60 File Offset: 0x0015AD60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0.OO_OOO0oOO.);
			C1Button o_.0__. = this.O_.0__.;
			if (o_.0__. != null)
			{
				o_.0__..Click -= value;
			}
			this.O_.0__. = A_0;
			o_.0__. = this.O_.0__.;
			if (o_.0__. != null)
			{
				o_.0__..Click += value;
			}
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x0015CBA3 File Offset: 0x0015ADA3
		public O\u3002\u3002\u3000\u3000()
		{
			base.FormClosed += this.o0.OO_OOO0oOO.;
			this.o0.OO_OOO0oOO.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x0015CBD8 File Offset: 0x0015ADD8
		internal bool <<EMPTY_NAME>>()
		{
			this.O_o_O.0. = new DataSet();
			this.O_o_O.0..ReadXml(this.O_o_O.0.);
			bool result;
			if (this.O_o_O.0..Tables.Count > 0)
			{
				this.o0.OO_OOO0oOO.().Items.Add("请选择要导入的表...");
				try
				{
					foreach (object obj in this.O_o_O.0..Tables)
					{
						DataTable dataTable = (DataTable)obj;
						this.o0.OO_OOO0oOO.().Items.Add(dataTable.TableName);
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
				if (this.o0.OO_OOO0oOO.().Items.Count == 2)
				{
					this.o0.OO_OOO0oOO.().SelectedIndex = 1;
				}
				else
				{
					this.o0.OO_OOO0oOO.().SelectedIndex = 0;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x0015CCC4 File Offset: 0x0015AEC4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0.OO_OOO0oOO.().SelectedIndex == 0)
			{
				this.o0.OO_OOO0oOO.().DataSource = null;
				return;
			}
			this.o0.OO_OOO0oOO.().DataSource = this.O_o_O.0..Tables[this.o0.OO_OOO0oOO.().SelectedItem.ToString()];
			for (int i = this.o0.OO_OOO0oOO.().Cols.Count - 1; i >= 1; i += -1)
			{
				if (o_O_o_oOoo__.oO.O_..Contains(this.o0.OO_OOO0oOO.().Cols[i].Name))
				{
					this.o0.OO_OOO0oOO.().Cols.Remove(i);
				}
			}
			this.o0.OO_OOO0oOO.().AutoSizeCols();
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x0015CD74 File Offset: 0x0015AF74
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0.OO_OOO0oOO.().Col >= this.o0.OO_OOO0oOO.().Cols.Fixed)
			{
				int leftCol = this.o0.OO_OOO0oOO.().Selection.LeftCol;
				int rightCol = this.o0.OO_OOO0oOO.().Selection.RightCol;
				int num = leftCol;
				int num2 = rightCol;
				for (int i = num; i <= num2; i++)
				{
					this.o0.OO_OOO0oOO.().Cols.Remove(leftCol);
				}
			}
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x0015CDEC File Offset: 0x0015AFEC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0.OO_OOO0oOO.().SelectedIndex >= 1)
			{
				try
				{
					this.Cursor = Cursors.WaitCursor;
					if (Oo00.O____0O._0.(this.o0.OO_OOO0oOO.(), this.o0.OO_OOO0oOO.().SelectedItem.ToString()))
					{
						base.DialogResult = DialogResult.OK;
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
				finally
				{
					this.Cursor = Cursors.Default;
				}
			}
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x0015CE7C File Offset: 0x0015B07C
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001474 RID: 5236
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001475 RID: 5237
		[CompilerGenerated]
		private OpenFileDialog <<EMPTY_NAME>>;

		// Token: 0x04001476 RID: 5238
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001477 RID: 5239
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001478 RID: 5240
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001479 RID: 5241
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400147A RID: 5242
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400147B RID: 5243
		internal string <<EMPTY_NAME>>;

		// Token: 0x0400147C RID: 5244
		internal DataSet <<EMPTY_NAME>>;
	}
}
