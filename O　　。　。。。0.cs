using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000397 RID: 919
	[DesignerGenerated]
	internal partial class O\u3000\u3000\u3002\u3000\u3002\u3002\u30020 : Form
	{
		// Token: 0x06003C57 RID: 15447 RVA: 0x001B6219 File Offset: 0x001B4419
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.o0.Oo__0Ooo0__. != null)
			{
				this.o0.Oo__0Ooo0__..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x001B6238 File Offset: 0x001B4438
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0Oo.O.(new C1FlexGrid());
			this.O0Oo.O.(new C1Button());
			this.O.o_0_OO00o0O.(new C1Button());
			this.o_O._0.(new C1Button());
			((ISupportInitialize)this.O0Oo.O.()).BeginInit();
			base.SuspendLayout();
			this.O0Oo.O.().ColumnInfo = "2,1,0,20,0,0,Columns:";
			this.O0Oo.O.().ExtendLastCol = true;
			this.O0Oo.O.().Location = new Point(12, 12);
			this.O0Oo.O.().Name = "C1FlexGrid1";
			this.O0Oo.O.().Rows.Count = 1;
			this.O0Oo.O.().Rows.DefaultSize = 19;
			this.O0Oo.O.().Rows.Fixed = 0;
			this.O0Oo.O.().Size = new Size(260, 342);
			this.O0Oo.O.().TabIndex = 0;
			this.O0Oo.O.().SelectionMode = SelectionModeEnum.Row;
			this.O0Oo.O.().FocusRect = FocusRectEnum.None;
			this.oo.ooOOoo.().DialogResult = DialogResult.OK;
			this.oo.ooOOoo.().Location = new Point(278, 301);
			this.oo.ooOOoo.().Name = "btnOK";
			this.oo.ooOOoo.().Size = new Size(75, 23);
			this.oo.ooOOoo.().TabIndex = 2;
			this.oo.ooOOoo.().Text = "确定";
			this.oo.ooOOoo.().UseVisualStyleBackColor = true;
			this.Oo_O.OO.().DialogResult = DialogResult.Cancel;
			this.Oo_O.OO.().Location = new Point(278, 331);
			this.Oo_O.OO.().Name = "btnCancel";
			this.Oo_O.OO.().Size = new Size(75, 23);
			this.Oo_O.OO.().TabIndex = 3;
			this.Oo_O.OO.().Text = "取消";
			this.Oo_O.OO.().UseVisualStyleBackColor = true;
			this.o_0.0oO0_0O.().Location = new Point(278, 12);
			this.o_0.0oO0_0O.().Name = "Button1";
			this.o_0.0oO0_0O.().Size = new Size(75, 23);
			this.o_0.0oO0_0O.().TabIndex = 1;
			this.o_0.0oO0_0O.().Text = "全选";
			this.o_0.0oO0_0O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(363, 367);
			base.Controls.Add(this.o_0.0oO0_0O.());
			base.Controls.Add(this.Oo_O.OO.());
			base.Controls.Add(this.oo.ooOOoo.());
			base.Controls.Add(this.O0Oo.O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O0..o...";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "选择列";
			((ISupportInitialize)this.O0Oo.O.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x001B6542 File Offset: 0x001B4742
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.o0.Oo__0Ooo0__.;
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x001B654A File Offset: 0x001B474A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.o0.Oo__0Ooo0__. = A_0;
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x001B6553 File Offset: 0x001B4753
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0Oo.O.;
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x001B655B File Offset: 0x001B475B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O0Oo.O. = A_0;
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x001B6564 File Offset: 0x001B4764
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.o_0_OO00o0O.;
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x001B656C File Offset: 0x001B476C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O.o_0_OO00o0O. = A_0;
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x001B6575 File Offset: 0x001B4775
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_O._0.;
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x001B6580 File Offset: 0x001B4780
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo.ooOOoo.);
			C1Button c1Button = this.o_O._0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_O._0. = A_0;
			c1Button = this.o_O._0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x001B65C4 File Offset: 0x001B47C4
		public O\u3000\u3000\u3002\u3000\u3002\u3002\u30020(OleDbConnection A_0, O0O A_1, string A_2, string A_3)
		{
			base.FormClosed += this.oo.ooOOoo.;
			this.o0.Oo__0Ooo0__. = a.Oooo_Oo_0__.0.().ToBitmap();
			int num2;
			int num5;
			object obj3;
			try
			{
				IL_28:
				int num = 1;
				this.O0Oo.O.();
				IL_30:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_47:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_4E:
				num = 4;
				if ((A_0 == null || !o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0)) && (A_1 == null || A_1.OO.OoO0. != DataServerTypeEnum.Oracle))
				{
					goto IL_B8;
				}
				IL_67:
				num = 5;
				string[] array = A_2.Split(new char[]
				{
					'"',
					'.'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_82:
				num = 6;
				string text = string.Concat(new string[]
				{
					"select column_name from all_tab_columns Where  table_name = '",
					array[1],
					"' And owner = '",
					array[0],
					"'"
				});
				goto IL_107;
				IL_B8:
				num = 8;
				if (A_2.IndexOf("].[") <= 0 || !A_2.StartsWith("[") || !A_2.EndsWith("]"))
				{
					goto IL_F3;
				}
				IL_E2:
				num = 9;
				text = "Select * from " + A_2;
				goto IL_107;
				IL_F3:
				num = 11;
				text = "Select * from [" + A_2 + "]";
				IL_107:
				num = 12;
				ArrayList arrayList = new ArrayList();
				IL_111:
				num = 13;
				ArrayList arrayList2 = new ArrayList();
				IL_11B:
				num = 14;
				string[] array2 = A_3.Split(new char[]
				{
					','
				});
				IL_132:
				num = 15;
				foreach (string value in array2)
				{
					IL_145:
					num = 16;
					arrayList.Add(value);
					IL_152:
					num = 17;
				}
				IL_163:
				num = 18;
				this.O0Oo.O.().Rows.Count = 0;
				IL_177:
				num = 19;
				DataTable dataTable = new DataTable();
				IL_181:
				num = 20;
				if (A_0 == null)
				{
					goto IL_1BB;
				}
				IL_187:
				num = 21;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text, A_0);
				IL_193:
				num = 22;
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				IL_1A1:
				num = 23;
				if (!o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0))
				{
					goto IL_1C8;
				}
				IL_1AC:
				num = 24;
				oleDbDataAdapter.Fill(dataTable);
				goto IL_1C8;
				IL_1BB:
				num = 26;
				dataTable = A_1.O_0_O_0_o_.0.(text, true);
				IL_1C8:
				num = 27;
				if (dataTable.Rows.Count != 0)
				{
					goto IL_219;
				}
				IL_1D9:
				num = 28;
				foreach (DataColumn dataColumn in dataTable.PrimaryKey)
				{
					IL_1F1:
					num = 29;
					arrayList2.Add(dataColumn.ColumnName.ToLower());
					IL_208:
					num = 30;
				}
				IL_219:
				num = 31;
				if (A_0 == null || !o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0))
				{
					goto IL_29E;
				}
				IL_227:
				num = 32;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_248:
					num = 33;
					this.O0Oo.O.().AddItem("\t" + dataRow["COLUMN_NAME"].ToString());
					IL_272:
					num = 34;
				}
				IL_27E:
				num = 35;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
					goto IL_344;
				}
				goto IL_344;
				IL_29E:
				num = 37;
				C1FlexGrid c1FlexGrid = this.O0Oo.O.();
				IL_2A9:
				num = 38;
				IEnumerator enumerator2 = dataTable.Columns.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					DataColumn dataColumn2 = (DataColumn)obj2;
					IL_2CA:
					num = 39;
					c1FlexGrid.AddItem("\t" + dataColumn2.ColumnName);
					IL_2E6:
					num = 40;
					if (arrayList2.Contains(dataColumn2.ColumnName.ToLower()))
					{
						IL_2FE:
						num = 41;
						c1FlexGrid.SetCellImage(c1FlexGrid.Rows.Count - 1, 0, this.o0.Oo__0Ooo0__.);
					}
					IL_31D:
					num = 42;
				}
				IL_329:
				num = 43;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_341:
				c1FlexGrid = null;
				IL_344:
				num = 45;
				C1FlexGrid c1FlexGrid2 = this.O0Oo.O.();
				IL_34F:
				num = 46;
				int num3 = c1FlexGrid2.Rows.Count - 1;
				for (int k = 0; k <= num3; k++)
				{
					IL_367:
					num = 47;
					string str = c1FlexGrid2.Rows[k][1].ToString();
					IL_385:
					num = 48;
					if (arrayList.Contains("[" + str + "]"))
					{
						IL_3A2:
						num = 49;
						c1FlexGrid2.SetCellCheck(k, 1, CheckEnum.Checked);
					}
					else
					{
						IL_3B2:
						num = 51;
						c1FlexGrid2.SetCellCheck(k, 1, CheckEnum.Unchecked);
					}
					IL_3C0:
					num = 52;
				}
				IL_3CF:
				c1FlexGrid2 = null;
				IL_3D2:
				goto IL_4FC;
				IL_3D7:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_4BD:
				goto IL_4F1;
				IL_4BF:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_4CF:;
			}
			catch when (endfilter(obj3 is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_4BF;
			}
			IL_4F1:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_4FC:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x001B6AF4 File Offset: 0x001B4CF4
		internal string <<EMPTY_NAME>>()
		{
			StringBuilder stringBuilder = new StringBuilder();
			C1FlexGrid c1FlexGrid = this.O0Oo.O.();
			int num = c1FlexGrid.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (c1FlexGrid.GetCellCheck(i, 1) == CheckEnum.Checked)
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(",");
					}
					stringBuilder.Append("[" + c1FlexGrid[i, 1].ToString() + "]");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x001B6B74 File Offset: 0x001B4D74
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new StringBuilder();
			C1FlexGrid c1FlexGrid = this.O0Oo.O.();
			int num = c1FlexGrid.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				c1FlexGrid.SetCellCheck(i, 1, CheckEnum.Checked);
			}
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x001B6BB3 File Offset: 0x001B4DB3
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040018D8 RID: 6360
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040018D9 RID: 6361
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040018DA RID: 6362
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018DB RID: 6363
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018DC RID: 6364
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018DD RID: 6365
		private string <<EMPTY_NAME>>;

		// Token: 0x040018DE RID: 6366
		private Image <<EMPTY_NAME>>;
	}
}
