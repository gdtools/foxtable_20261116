using System;
using System.Collections;
using System.Collections.Generic;
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
	// Token: 0x02000370 RID: 880
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal partial class O_\u3002\u3000\u3002\u3000 : Form
	{
		// Token: 0x06003837 RID: 14391 RVA: 0x0018FDCC File Offset: 0x0018DFCC
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o0__0._. != null)
				{
					this.o0__0._..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x0018FE0C File Offset: 0x0018E00C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0__0._.(new C1FlexGrid());
			this.o0__0._.(new C1Button());
			((ISupportInitialize)this.O_OooO.0oOOO0.()).BeginInit();
			base.SuspendLayout();
			this.O_OooO.0oOOO0.().AllowEditing = false;
			this.O_OooO.0oOOO0.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O_OooO.0oOOO0.().ColumnInfo = "10,1,0,0,0,0,Columns:";
			this.O_OooO.0oOOO0.().Location = new Point(12, 16);
			this.O_OooO.0oOOO0.().Name = "C1FlexGrid1";
			this.O_OooO.0oOOO0.().Rows.DefaultSize = 20;
			this.O_OooO.0oOOO0.().Size = new Size(566, 340);
			this.O_OooO.0oOOO0.().TabIndex = 0;
			this.O_OooO.0oOOO0.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
			this.O_OooO.0oOOO0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O_OooO.0oOOO0.().Location = new Point(460, 367);
			this.O_OooO.0oOOO0.().Name = "Button1";
			this.O_OooO.0oOOO0.().Size = new Size(118, 23);
			this.O_OooO.0oOOO0.().TabIndex = 1;
			this.O_OooO.0oOOO0.().Text = "回收选定行";
			this.O_OooO.0oOOO0.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(590, 401);
			base.Controls.Add(this.O_OooO.0oOOO0.());
			base.Controls.Add(this.O_OooO.0oOOO0.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o......0";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "回收站";
			((ISupportInitialize)this.O_OooO.0oOOO0.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x0018FFE2 File Offset: 0x0018E1E2
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.o0__0._.;
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x0018FFEA File Offset: 0x0018E1EA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.o0__0._. = A_0;
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x0018FFF3 File Offset: 0x0018E1F3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0__0._.;
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x0018FFFC File Offset: 0x0018E1FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_OooO.0oOOO0.);
			C1Button c1Button = this.o0__0._.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0__0._. = A_0;
			c1Button = this.o0__0._.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x00190040 File Offset: 0x0018E240
		public O_\u3002\u3000\u3002\u3000(DataTable A_0)
		{
			base.FormClosed += this.O_OooO.0oOOO0.;
			int num2;
			int num5;
			object obj2;
			try
			{
				IL_18:
				int num = 1;
				this.o0__0._.();
				IL_20:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_37:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_3E:
				num = 4;
				this.o0__0._. = new DataView(A_0.BaseTable, "", "", DataViewRowState.Deleted);
				IL_5C:
				num = 5;
				this.O_OooO.0oOOO0.().AutoResize = true;
				IL_6A:
				num = 6;
				this.O_OooO.0oOOO0.().DataSource = this.o0__0._.;
				IL_7D:
				num = 7;
				this.O_OooO.0oOOO0.().AllowMergingFixed = AllowMergingEnum.FixedOnly;
				IL_8B:
				num = 8;
				this.o0__0._. = A_0;
				IL_94:
				num = 9;
				List<string>.Enumerator enumerator = o_O_o_oOoo__.oO.O_..GetEnumerator();
				while (enumerator.MoveNext())
				{
					string columnName = enumerator.Current;
					IL_AD:
					num = 10;
					if (this.O_OooO.0oOOO0.().Cols.Contains(columnName))
					{
						IL_C4:
						num = 11;
						this.O_OooO.0oOOO0.().Cols.Remove(columnName);
					}
					IL_DA:
					num = 12;
				}
				IL_E6:
				num = 13;
				((IDisposable)enumerator).Dispose();
				IL_F6:
				num = 14;
				IEnumerator enumerator2 = this.o0__0._..BaseTable.ChildRelations.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj = enumerator2.Current;
					DataRelation dataRelation = (DataRelation)obj;
					IL_120:
					num = 15;
					if (this.O_OooO.0oOOO0.().Cols.Contains(dataRelation.RelationName))
					{
						IL_13C:
						num = 16;
						this.O_OooO.0oOOO0.().Cols.Remove(dataRelation.RelationName);
					}
					IL_157:
					num = 17;
				}
				IL_163:
				num = 18;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_17B:
				num = 19;
				if (OO_00oOO.User.Type == UserTypeEnum.Developer)
				{
					goto IL_201;
				}
				IL_18A:
				num = 20;
				int num3 = this.O_OooO.0oOOO0.().Cols.Count - 1;
				int @fixed = this.O_OooO.0oOOO0.().Cols.Fixed;
				for (int i = num3; i >= @fixed; i += -1)
				{
					IL_1B5:
					num = 21;
					if (this.O_OooO.0oOOO0.().Cols[i].Name.StartsWith("sys_", StringComparison.CurrentCultureIgnoreCase))
					{
						IL_1DC:
						num = 22;
						this.O_OooO.0oOOO0.().Cols.Remove(i);
					}
					IL_1F2:
					num = 23;
				}
				IL_201:
				num = 24;
				this.O_.0o_o0o.();
				IL_20A:
				num = 25;
				this.O_OooO.0oOOO0.().Cols[0].Width = 25;
				IL_225:
				goto IL_2DF;
				IL_22A:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_2A0:
				goto IL_2D4;
				IL_2A2:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_2B2:;
			}
			catch when (endfilter(obj2 is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_2A2;
			}
			IL_2D4:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2DF:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00190350 File Offset: 0x0018E550
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num2;
			int num4;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				OO_00oOO.SystemReady = false;
				IL_08:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_0F:
				num = 3;
				List<DataRow> list = new List<DataRow>();
				IL_17:
				num = 4;
				C1FlexGrid c1FlexGrid = this.O_OooO.0oOOO0.();
				IL_21:
				num = 5;
				if (c1FlexGrid.Row < c1FlexGrid.Rows.Fixed)
				{
					goto IL_95;
				}
				IL_38:
				num = 6;
				int topRow = c1FlexGrid.Selection.TopRow;
				int bottomRow = c1FlexGrid.Selection.BottomRow;
				for (int i = topRow; i <= bottomRow; i++)
				{
					IL_60:
					num = 7;
					list.Add(this.o0__0._.[i - c1FlexGrid.Rows.Fixed].Row);
					IL_87:
					num = 8;
				}
				IL_95:
				c1FlexGrid = null;
				IL_98:
				num = 10;
				List<DataRow>.Enumerator enumerator = list.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = enumerator.Current;
					IL_AE:
					num = 11;
					dataRow.RejectChanges();
					IL_B8:
					num = 12;
				}
				IL_C4:
				num = 13;
				((IDisposable)enumerator).Dispose();
				IL_D4:
				num = 14;
				OO_00oOO.SystemReady = true;
				IL_DD:
				num = 15;
				IEnumerator<Table> enumerator2 = OO_00oOO.Tables.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Table table = enumerator2.Current;
					IL_F7:
					num = 16;
					if (table.View.o_o.O0ooOo.() == this.o0__0._..Table)
					{
						IL_113:
						num = 17;
						table.View.o_._0O0o_OoO.();
						IL_122:
						num = 18;
						table.View.Oo._Oo0OO.();
						IL_131:
						num = 19;
						table.ClearEditInfos();
					}
					IL_13B:
					num = 20;
				}
				IL_147:
				num = 21;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_155:
				goto IL_1FF;
				IL_15A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1C0:
				goto IL_1F4;
				IL_1C2:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_1D2:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1C2;
			}
			IL_1F4:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1FF:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00190580 File Offset: 0x0018E780
		internal void <<EMPTY_NAME>>()
		{
			int num;
			int num10;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				int num3 = 1;
				IL_0B:
				num2 = 3;
				C1FlexGrid c1FlexGrid = this.O_OooO.0oOOO0.();
				IL_15:
				num2 = 4;
				int @fixed = c1FlexGrid.Cols.Fixed;
				int num4 = c1FlexGrid.Cols.Count - 1;
				for (int i = @fixed; i <= num4; i++)
				{
					IL_3A:
					num2 = 5;
					string caption = this.o0__0._..DataCols[c1FlexGrid.Cols[i].Name].Caption;
					IL_66:
					num2 = 6;
					if (Operators.CompareString(caption, "", true) > 0)
					{
						IL_78:
						num2 = 7;
						c1FlexGrid.Cols[i].Caption = caption;
					}
					else
					{
						IL_91:
						num2 = 9;
						c1FlexGrid.Cols[i].Caption = c1FlexGrid.Cols[i].Name;
					}
					IL_BA:
					num2 = 10;
					c1FlexGrid.Cols[i].AllowMerging = true;
					IL_D1:
					num2 = 11;
					num3 = Math.Max(num3, c1FlexGrid.Cols[i].Caption.ToString().Split(new char[]
					{
						'_'
					}).Length);
					IL_105:
					num2 = 12;
				}
				IL_117:
				num2 = 13;
				c1FlexGrid.Rows.Fixed = num3;
				IL_127:
				num2 = 14;
				if (num3 <= 1)
				{
					goto IL_1F8;
				}
				IL_131:
				num2 = 15;
				int num5 = num3 - 1;
				for (int j = 0; j <= num5; j++)
				{
					IL_13E:
					num2 = 16;
					c1FlexGrid.Rows[j].AllowMerging = true;
					IL_155:
					num2 = 17;
				}
				IL_164:
				num2 = 18;
				int fixed2 = c1FlexGrid.Cols.Fixed;
				int num6 = c1FlexGrid.Cols.Count - 1;
				for (int k = fixed2; k <= num6; k++)
				{
					IL_187:
					num2 = 19;
					string[] array = c1FlexGrid.Cols[k].Caption.Split(new char[]
					{
						'_'
					});
					IL_1AF:
					num2 = 20;
					int num7 = num3 - 1;
					for (int l = 0; l <= num7; l++)
					{
						IL_1BC:
						num2 = 21;
						c1FlexGrid[l, k] = array[Math.Min(l, array.Length - 1)];
						IL_1DA:
						num2 = 22;
					}
					IL_1E9:
					num2 = 23;
				}
				IL_1F8:
				num2 = 24;
				IEnumerator<DataTable> enumerator = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataTable dataTable = enumerator.Current;
					IL_212:
					num2 = 25;
					if (dataTable == this.o0__0._.)
					{
						IL_21F:
						num2 = 26;
						int num8 = num3 - 1;
						for (int m = 0; m <= num8; m++)
						{
							IL_22C:
							num2 = 27;
							c1FlexGrid.Rows[m].Height = OO_00oOO.Tables[dataTable.Name].foxGrid.Rows[m].Height;
							IL_269:
							num2 = 28;
						}
					}
					IL_278:
					num2 = 29;
				}
				IL_284:
				num2 = 30;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_292:
				goto IL_360;
				IL_297:
				int num9 = num10 + 1;
				num10 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9);
				IL_321:
				goto IL_355;
				IL_323:
				num10 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_333:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num10 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_323;
			}
			IL_355:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_360:
			if (num10 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00190914 File Offset: 0x0018EB14
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040016FF RID: 5887
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001700 RID: 5888
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001701 RID: 5889
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001702 RID: 5890
		private DataView <<EMPTY_NAME>>;

		// Token: 0x04001703 RID: 5891
		private DataTable <<EMPTY_NAME>>;
	}
}
