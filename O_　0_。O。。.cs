using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000393 RID: 915
	[DesignerGenerated]
	internal partial class O_\u30000_\u3002O\u3002\u3002\u3000\u3000 : Form
	{
		// Token: 0x06003BF4 RID: 15348 RVA: 0x001B3652 File Offset: 0x001B1852
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.OOo0_0o00_0.O. != null)
			{
				this.OOo0_0o00_0.O..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x001B3674 File Offset: 0x001B1874
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O_00.0.(new C1FlexGrid());
			this.O_00.0.(new C1Button());
			this.OOo0_0o00_0.O.(new oO_oO000oo());
			this.OOo0_0o00_0.O.(new SplitContainer());
			((ISupportInitialize)this.O_00.0.()).BeginInit();
			((ISupportInitialize)this.O_00.0.()).BeginInit();
			((ISupportInitialize)this.O_00.0.()).BeginInit();
			this.O_00.0.().Panel1.SuspendLayout();
			this.O_00.0.().Panel2.SuspendLayout();
			this.O_00.0.().SuspendLayout();
			base.SuspendLayout();
			this.O_00.0.().ColumnInfo = "10,1,0,0,0,0,Columns:";
			this.O_00.0.().Dock = DockStyle.Fill;
			this.O_00.0.().Location = new Point(0, 0);
			this.O_00.0.().Name = "C1FlexGrid1";
			this.O_00.0.().Rows.DefaultSize = 19;
			this.O_00.0.().Size = new Size(712, 373);
			this.O_00.0.().TabIndex = 0;
			this.O_00.0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O_00.0.().Location = new Point(639, 552);
			this.O_00.0.().Name = "btnRefresh";
			this.O_00.0.().Size = new Size(75, 23);
			this.O_00.0.().TabIndex = 2;
			this.O_00.0.().Text = "刷新";
			this.O_00.0.().UseVisualStyleBackColor = true;
			this.O_00.0.().AllowDrop = true;
			this.O_00.0.().Dock = DockStyle.Fill;
			this.O_00.0.().Location = new Point(0, 0);
			this.O_00.0.().Name = "TextBox1";
			this.O_00.0.().Size = new Size(712, 147);
			this.O_00.0.().TabIndex = 3;
			this.O_00.0.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O_00.0.().FixedPanel = FixedPanel.Panel2;
			this.O_00.0.().Location = new Point(7, 12);
			this.O_00.0.().Name = "SplitContainer1";
			this.O_00.0.().Orientation = Orientation.Horizontal;
			this.O_00.0.().Panel1.Controls.Add(this.O_00.0.());
			this.O_00.0.().Panel2.Controls.Add(this.O_00.0.());
			this.O_00.0.().Size = new Size(712, 524);
			this.O_00.0.().SplitterDistance = 373;
			this.O_00.0.().TabIndex = 4;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(726, 587);
			base.Controls.Add(this.O_00.0.());
			base.Controls.Add(this.O_00.0.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmOuterTablePreview";
			base.ShowIcon = false;
			this.Text = "预览";
			((ISupportInitialize)this.O_00.0.()).EndInit();
			((ISupportInitialize)this.O_00.0.()).EndInit();
			this.O_00.0.().Panel1.ResumeLayout(false);
			this.O_00.0.().Panel2.ResumeLayout(false);
			((ISupportInitialize)this.O_00.0.()).EndInit();
			this.O_00.0.().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x001B39D0 File Offset: 0x001B1BD0
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.OOo0_0o00_0.O.;
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x001B39D8 File Offset: 0x001B1BD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.OOo0_0o00_0.O. = A_0;
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x001B39E1 File Offset: 0x001B1BE1
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOo0_0o00_0.O.;
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x001B39EC File Offset: 0x001B1BEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O._O_O.);
			C1Button ooo0_0o00_0.O. = this.OOo0_0o00_0.O.;
			if (ooo0_0o00_0.O. != null)
			{
				ooo0_0o00_0.O..Click -= value;
			}
			this.OOo0_0o00_0.O. = A_0;
			ooo0_0o00_0.O. = this.OOo0_0o00_0.O.;
			if (ooo0_0o00_0.O. != null)
			{
				ooo0_0o00_0.O..Click += value;
			}
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x001B3A2F File Offset: 0x001B1C2F
		[CompilerGenerated]
		internal virtual oO_oO000oo <<EMPTY_NAME>>()
		{
			return this.OOo0_0o00_0.O.;
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x001B3A37 File Offset: 0x001B1C37
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(oO_oO000oo A_0)
		{
			this.OOo0_0o00_0.O. = A_0;
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x001B3A40 File Offset: 0x001B1C40
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.OOo0_0o00_0.O.;
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x001B3A48 File Offset: 0x001B1C48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.OOo0_0o00_0.O. = A_0;
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x001B3A54 File Offset: 0x001B1C54
		public O_\u30000_\u3002O\u3002\u3002\u3000\u3000(OleDbConnection A_0, string A_1, O0O A_2 = null)
		{
			base.FormClosed += this.O_00.0.;
			this.o.o_0oo_o_.();
			this.O_00.0.().oO.O_oo_o_O.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.OOo0_0o00_0.O. = A_0;
			this.OOo0_0o00_0.O. = A_2;
			this.O_00.0.().Text = A_1;
			this.O_00.0.();
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x001B3AC0 File Offset: 0x001B1CC0
		private void <<EMPTY_NAME>>()
		{
			DataTable dataTable = new DataTable();
			try
			{
				if (this.OOo0_0o00_0.O. != null)
				{
					string selectCommandText = Oo00.o0_o._O_.(this.OOo0_0o00_0.O., this.O_00.0.().Text, false);
					new OleDbDataAdapter(selectCommandText, this.OOo0_0o00_0.O.).Fill(dataTable);
					try
					{
						foreach (object obj in dataTable.Columns)
						{
							DataColumn dataColumn = (DataColumn)obj;
							if (dataColumn.ColumnName.StartsWith("~TMPCLP"))
							{
								dataColumn.Caption = dataColumn.ColumnName.Substring(7);
							}
						}
						goto IL_100;
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				HttpClient httpClient = this.OOo0_0o00_0.O..oO0_0.o.();
				httpClient.FormData["Action"] = 2.ToString();
				httpClient.Select = Oo00.o0_o._O_.(this.OOo0_0o00_0.O..OO.OoO0., this.O_00.0.().Text, false);
				httpClient.FormData["IgnoreSchema"] = "True";
				dataTable = httpClient.GetBaseDataTable();
				httpClient.Reset();
				IL_100:
				C1FlexGrid c1FlexGrid = this.O_00.0.();
				c1FlexGrid.AutoResize = true;
				c1FlexGrid.DataSource = dataTable;
				int num = c1FlexGrid.Cols.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (c1FlexGrid.Cols[i].DataType == typeof(double) || c1FlexGrid.Cols[i].DataType == typeof(decimal) || c1FlexGrid.Cols[i].DataType == typeof(decimal))
					{
						c1FlexGrid.Cols[i].Format = "#0.####";
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				if (this.OOo0_0o00_0.O..State != ConnectionState.Closed)
				{
					this.OOo0_0o00_0.O..Close();
				}
			}
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x001B3CEC File Offset: 0x001B1EEC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_00.0.();
		}

		// Token: 0x06003C01 RID: 15361 RVA: 0x001B3CF4 File Offset: 0x001B1EF4
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040018AF RID: 6319
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040018B0 RID: 6320
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040018B1 RID: 6321
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018B2 RID: 6322
		[CompilerGenerated]
		private oO_oO000oo <<EMPTY_NAME>>;

		// Token: 0x040018B3 RID: 6323
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x040018B4 RID: 6324
		private OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x040018B5 RID: 6325
		private O0O <<EMPTY_NAME>>;
	}
}
