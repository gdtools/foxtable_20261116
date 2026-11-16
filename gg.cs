using System;
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
	// Token: 0x02000382 RID: 898
	[DesignerGenerated]
	internal partial class gg : Form
	{
		// Token: 0x06003A05 RID: 14853 RVA: 0x0019FDE4 File Offset: 0x0019DFE4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.ooO0o.0o_. != null)
				{
					this.ooO0o.0o_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x0019FE24 File Offset: 0x0019E024
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(gg));
			this.O_O.0Ooo_.(new C1FlexGrid());
			this.O_O.0Ooo_.(new C1Button());
			this.ooO0o.0OO0oO_O.(new C1Button());
			this.o_ooo0O.OO.(new C1Button());
			((ISupportInitialize)this.O_O.0Ooo_.()).BeginInit();
			base.SuspendLayout();
			this.O_O.0Ooo_.().AllowDelete = true;
			this.O_O.0Ooo_.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo");
			this.O_O.0Ooo_.().ExtendLastCol = true;
			this.O_O.0Ooo_.().Location = new Point(13, 12);
			this.O_O.0Ooo_.().Name = "C1FlexGrid1";
			this.O_O.0Ooo_.().Rows.Count = 1;
			this.O_O.0Ooo_.().Rows.DefaultSize = 20;
			this.O_O.0Ooo_.().Size = new Size(380, 215);
			this.O_O.0Ooo_.().TabIndex = 0;
			this.O_O.0Ooo_.().DialogResult = DialogResult.OK;
			this.O_O.0Ooo_.().Location = new Point(237, 242);
			this.O_O.0Ooo_.().Name = "btnOK";
			this.O_O.0Ooo_.().Size = new Size(75, 23);
			this.O_O.0Ooo_.().TabIndex = 1;
			this.O_O.0Ooo_.().Text = "确定";
			this.O_O.0Ooo_.().UseVisualStyleBackColor = true;
			this.ooO0o.0OO0oO_O.().DialogResult = DialogResult.Cancel;
			this.ooO0o.0OO0oO_O.().Location = new Point(318, 242);
			this.ooO0o.0OO0oO_O.().Name = "btnCancel";
			this.ooO0o.0OO0oO_O.().Size = new Size(75, 23);
			this.ooO0o.0OO0oO_O.().TabIndex = 2;
			this.ooO0o.0OO0oO_O.().Text = "取消";
			this.ooO0o.0OO0oO_O.().UseVisualStyleBackColor = true;
			this.o_ooo0O.OO.().Location = new Point(13, 242);
			this.o_ooo0O.OO.().Name = "btnDel";
			this.o_ooo0O.OO.().Size = new Size(75, 23);
			this.o_ooo0O.OO.().TabIndex = 4;
			this.o_ooo0O.OO.().Text = "删除";
			this.o_ooo0O.OO.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(404, 277);
			base.Controls.Add(this.o_ooo0O.OO.());
			base.Controls.Add(this.ooO0o.0OO0oO_O.());
			base.Controls.Add(this.O_O.0Ooo_.());
			base.Controls.Add(this.O_O.0Ooo_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oOO0.0..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "全局变量";
			((ISupportInitialize)this.O_O.0Ooo_.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x001A0127 File Offset: 0x0019E327
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.ooO0o.0o_.;
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x001A012F File Offset: 0x0019E32F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.ooO0o.0o_. = A_0;
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x001A0138 File Offset: 0x0019E338
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooO0o.0o_.;
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x001A0140 File Offset: 0x0019E340
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_0_.oO_OoO.);
			C1Button c1Button = this.ooO0o.0o_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooO0o.0o_. = A_0;
			c1Button = this.ooO0o.0o_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x001A0183 File Offset: 0x0019E383
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_ooo0O.OO.;
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x001A018B File Offset: 0x0019E38B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o_ooo0O.OO. = A_0;
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x001A0194 File Offset: 0x0019E394
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OoOO.O_o_.;
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x001A019C File Offset: 0x0019E39C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0o_o.o0.);
			C1Button ooOO.O_o_. = this.OoOO.O_o_.;
			if (ooOO.O_o_. != null)
			{
				ooOO.O_o_..Click -= value;
			}
			this.OoOO.O_o_. = A_0;
			ooOO.O_o_. = this.OoOO.O_o_.;
			if (ooOO.O_o_. != null)
			{
				ooOO.O_o_..Click += value;
			}
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x001A01E0 File Offset: 0x0019E3E0
		public gg()
		{
			base.Load += this.o._OoOO_0.;
			base.FormClosed += this.O0o_o.o0.;
			this.O_O.0Ooo_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			C1FlexGrid c1FlexGrid = this.O_O.0Ooo_.();
			c1FlexGrid.Styles.SelectedColumnHeader.Clear();
			c1FlexGrid.Styles.Alternate.Clear();
			c1FlexGrid.Styles.Focus.Clear();
			c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal);
			c1FlexGrid.FocusRect = FocusRectEnum.Solid;
			c1FlexGrid.AllowSorting = AllowSortingEnum.None;
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x001A0294 File Offset: 0x0019E494
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.ooO0o.0o_. = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"Variables",
					o0_O.O0oO__._0OO00o.
				});
				IL_45:
				num2 = 3;
				if (this.ooO0o.0o_. != null)
				{
					goto IL_C6;
				}
				IL_4F:
				num2 = 4;
				this.ooO0o.0o_. = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_70:
				num2 = 5;
				this.ooO0o.0o_.["Name"] = "Variables";
				IL_87:
				num2 = 6;
				this.ooO0o.0o_.["Type"] = o0_O.O0oO__._0OO00o.;
				IL_A0:
				num2 = 7;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Add(this.ooO0o.0o_.);
				IL_C6:
				num2 = 8;
				if (this.ooO0o.0o_..IsNull("Config"))
				{
					goto IL_147;
				}
				IL_DA:
				num2 = 9;
				string[] array = Conversions.ToString(this.ooO0o.0o_.["Config"]).Split(new char[]
				{
					'\r',
					'\n'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_109:
				num2 = 10;
				foreach (string str in array)
				{
					IL_11B:
					num2 = 11;
					this.O_O.0Ooo_.().AddItem("\t" + str);
					IL_136:
					num2 = 12;
				}
				IL_147:
				num2 = 13;
				this.O_O.0Ooo_.().AllowAddNew = true;
				IL_156:
				goto IL_1E0;
				IL_15B:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1A1:
				goto IL_1D5;
				IL_1A3:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1B3:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1A3;
			}
			IL_1D5:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1E0:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x001A04A8 File Offset: 0x0019E6A8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.O_O.0Ooo_.();
			if (c1FlexGrid.Rows.Count > 2)
			{
				this.ooO0o.0o_.["Config"] = c1FlexGrid.GetCellRange(1, 1, c1FlexGrid.Rows.Count - 2, 3).Clip;
			}
			else
			{
				this.ooO0o.0o_.["Config"] = "";
			}
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
			OO_00oOO.Vars.Clear();
			ooO.O._oO_0O__o__o.();
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x001A053C File Offset: 0x0019E73C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O_O.0Ooo_.().Row >= 1 && this.O_O.0Ooo_.().Row < this.O_O.0Ooo_.().Rows.Count - 1)
			{
				this.O_O.0Ooo_.().Rows.Remove(this.O_O.0Ooo_.().Row);
			}
			this.O_O.0Ooo_.().Focus();
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x001A059E File Offset: 0x0019E79E
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040017C9 RID: 6089
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040017CA RID: 6090
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040017CB RID: 6091
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017CC RID: 6092
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017CD RID: 6093
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017CE RID: 6094
		private DataRow <<EMPTY_NAME>>;
	}
}
