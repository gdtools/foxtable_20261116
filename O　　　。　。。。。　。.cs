using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200037A RID: 890
	[DesignerGenerated]
	internal partial class O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002 : Form
	{
		// Token: 0x06003931 RID: 14641 RVA: 0x00198D1C File Offset: 0x00196F1C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oO000O_Ooo.oo0. != null)
				{
					this.oO000O_Ooo.oo0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x00198D5C File Offset: 0x00196F5C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002));
			this.O.OO__0O.(new C1FlexGrid());
			this.O.OO__0O.(new C1Button());
			((ISupportInitialize)this.O.OO__0O.()).BeginInit();
			base.SuspendLayout();
			this.O.OO__0O.().AllowDragging = AllowDraggingEnum.None;
			this.O.OO__0O.().AllowEditing = false;
			this.O.OO__0O.().AllowResizing = AllowResizingEnum.None;
			this.O.OO__0O.().ColumnInfo = "9,0,0,20,0,115,Columns:";
			this.O.OO__0O.().FocusRect = FocusRectEnum.Solid;
			this.O.OO__0O.().Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.O.OO__0O.().Location = new Point(12, 10);
			this.O.OO__0O.().Name = "C1FlexGrid1";
			this.O.OO__0O.().Rows.Count = 9;
			this.O.OO__0O.().Rows.DefaultSize = 23;
			this.O.OO__0O.().Rows.Fixed = 0;
			this.O.OO__0O.().ScrollBars = ScrollBars.None;
			this.O.OO__0O.().Size = new Size(285, 285);
			this.O.OO__0O.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo");
			this.O.OO__0O.().TabIndex = 0;
			this.O.OO__0O.().Location = new Point(232, 301);
			this.O.OO__0O.().Name = "btnMore";
			this.O.OO__0O.().Size = new Size(64, 23);
			this.O.OO__0O.().TabIndex = 3;
			this.O.OO__0O.().Text = "更多...";
			this.O.OO__0O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(308, 332);
			base.Controls.Add(this.O.OO__0O.());
			base.Controls.Add(this.O.OO__0O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O......0";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "常用符号";
			((ISupportInitialize)this.O.OO__0O.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x00198FAD File Offset: 0x001971AD
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O.OO__0O.;
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x00198FB8 File Offset: 0x001971B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			EventHandler value = new EventHandler(this.oo.Oo0.);
			C1FlexGrid o.OO__0O. = this.O.OO__0O.;
			if (o.OO__0O. != null)
			{
				o.OO__0O..DoubleClick -= value;
			}
			this.O.OO__0O. = A_0;
			o.OO__0O. = this.O.OO__0O.;
			if (o.OO__0O. != null)
			{
				o.OO__0O..DoubleClick += value;
			}
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x00198FFB File Offset: 0x001971FB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.OO__0O.;
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x00199004 File Offset: 0x00197204
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOoO_OOo._.);
			C1Button o.OO__0O. = this.O.OO__0O.;
			if (o.OO__0O. != null)
			{
				o.OO__0O..Click -= value;
			}
			this.O.OO__0O. = A_0;
			o.OO__0O. = this.O.OO__0O.;
			if (o.OO__0O. != null)
			{
				o.OO__0O..Click += value;
			}
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x00199048 File Offset: 0x00197248
		public O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002()
		{
			base.Load += this.O_oo.0o_O_o0.;
			base.FormClosed += this.O.OO__0O.;
			this.O.OO__0O.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x0019909C File Offset: 0x0019729C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				C1FlexGrid c1FlexGrid = this.O.OO__0O.();
				IL_11:
				num2 = 3;
				c1FlexGrid.Cols.DefaultSize = (int)Math.Round((double)c1FlexGrid.ClientSize.Width / (double)c1FlexGrid.Cols.Count);
				IL_44:
				num2 = 4;
				c1FlexGrid.Rows.DefaultSize = c1FlexGrid.Cols.DefaultSize;
				IL_5E:
				c1FlexGrid = null;
				IL_61:
				num2 = 6;
				string file = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\\symbol.txt";
				IL_82:
				num2 = 7;
				if (!c.OOOOO.o.().FileSystem.FileExists(file))
				{
					goto IL_145;
				}
				IL_99:
				num2 = 8;
				string text = c.OOOOO.o.().FileSystem.ReadAllText(file, Encoding.Default);
				IL_B2:
				num2 = 9;
				C1FlexGrid c1FlexGrid2 = this.O.OO__0O.();
				IL_BD:
				num2 = 10;
				int num3 = c1FlexGrid2.Rows.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_D5:
					num2 = 11;
					int num4 = c1FlexGrid2.Cols.Count - 1;
					for (int j = 0; j <= num4; j++)
					{
						IL_ED:
						num2 = 12;
						int num5;
						c1FlexGrid2[i, j] = text[num5];
						IL_109:
						num2 = 13;
						num5++;
						IL_112:
						num2 = 14;
						if (num5 > text.Length - 1)
						{
							goto IL_15B;
						}
						IL_122:
						num2 = 16;
					}
					IL_131:
					num2 = 17;
				}
				IL_140:
				c1FlexGrid2 = null;
				goto IL_15B;
				IL_145:
				num2 = 20;
				MessageBox.Show("找不到文件Symbol.Txt", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_15B:
				goto IL_201;
				IL_160:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_1C2:
				goto IL_1F6;
				IL_1C4:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1D4:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1C4;
			}
			IL_1F6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_201:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x001992D0 File Offset: 0x001974D0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.O.OO__0O.();
			if (c1FlexGrid.MouseCol >= 0 & c1FlexGrid.MouseRow >= 0)
			{
				this.O.OO__0O.(c1FlexGrid[c1FlexGrid.MouseRow, c1FlexGrid.MouseCol].ToString());
			}
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x00199320 File Offset: 0x00197520
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				Process.Start("charmap.exe");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			base.Close();
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x00199374 File Offset: 0x00197574
		private void <<EMPTY_NAME>>(string A_0)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				int num3 = OO_00oOO.CurrentTable.foxGrid.Col;
				IL_19:
				num2 = 3;
				if (!(Main.OO_O.o..ActiveControl is OooOo0___oO))
				{
					goto IL_9B;
				}
				IL_2C:
				num2 = 4;
				OooOo0___oO oooOo0___oO = (OooOo0___oO)Main.OO_O.o..ActiveControl;
				IL_3F:
				num2 = 5;
				string columnName = oooOo0___oO.Rows[oooOo0___oO.Row].UserData.ToString();
				IL_60:
				num2 = 6;
				if (!OO_00oOO.CurrentTable.foxGrid.Cols.Contains(columnName))
				{
					goto IL_98;
				}
				IL_7A:
				num2 = 7;
				num3 = OO_00oOO.CurrentTable.foxGrid.Cols[columnName].Index;
				IL_98:
				oooOo0___oO = null;
				IL_9B:
				num2 = 9;
				O_oOooO_O o_oOooO_O = OO_00oOO.CurrentTable.foxGrid;
				IL_AA:
				num2 = 10;
				if (o_oOooO_O.Row == -1 || o_oOooO_O.Rows[o_oOooO_O.Row].DataIndex == -1)
				{
					goto IL_278;
				}
				IL_D8:
				num2 = 12;
				if (o_oOooO_O.Cols[num3].DataType != typeof(string))
				{
					goto IL_278;
				}
				IL_FC:
				num2 = 15;
				if (!o_oOooO_O.o000OOo.OO.(o_oOooO_O.Row, num3))
				{
					goto IL_278;
				}
				IL_113:
				o_oOooO_O = null;
				IL_116:
				num2 = 18;
				DataRow row = OO_00oOO.CurrentTable.View.o_o.O0ooOo.().Row;
				IL_12F:
				num2 = 19;
				DataColumn dataColumn = OO_00oOO.CurrentTable.DataTable.DataCols[OO_00oOO.CurrentTable.foxGrid.Cols[num3].Name].BaseColumn;
				IL_167:
				num2 = 20;
				if (row.IsNull(dataColumn))
				{
					goto IL_197;
				}
				IL_175:
				num2 = 21;
				if (row[dataColumn].ToString().Length == dataColumn.MaxLength)
				{
					goto IL_278;
				}
				IL_197:
				num2 = 23;
				OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(OO_00oOO.CurrentTable, row, dataColumn.ColumnName));
				IL_1BC:
				num2 = 24;
				if (!row.IsNull(dataColumn))
				{
					goto IL_1D9;
				}
				IL_1CA:
				num2 = 25;
				row[dataColumn] = A_0;
				goto IL_1F9;
				IL_1D9:
				num2 = 27;
				row[dataColumn] = row[dataColumn].ToString() + A_0;
				IL_1F9:
				num2 = 28;
				RowColEventArgs rowColEventArgs = new RowColEventArgs(OO_00oOO.CurrentTable, new Row(OO_00oOO.CurrentTable, OO_00oOO.CurrentTable.View.o_o.O0ooOo.()), OO_00oOO.CurrentTable.Cols[dataColumn.ColumnName], null);
				IL_238:
				num2 = 29;
				string a_ = "AfterEdit";
				IL_242:
				num2 = 30;
				O_O0OO.OoO_o.oO0o0O.(OO_00oOO.CurrentTable.DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					rowColEventArgs
				}, false, OO_00oOO.CurrentTable.DataTable.Name, false);
				IL_278:
				goto IL_346;
				IL_27D:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_307:
				goto IL_33B;
				IL_309:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_319:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_309;
			}
			IL_33B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_346:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x001996EC File Offset: 0x001978EC
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400176C RID: 5996
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400176D RID: 5997
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400176E RID: 5998
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
