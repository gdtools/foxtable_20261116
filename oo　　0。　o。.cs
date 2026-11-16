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
using C1.Win.C1Input;
using Foxtable.Syscmd;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000364 RID: 868
	[DesignerGenerated]
	internal partial class oo\u3000\u30000\u3002\u3000o\u3002 : Form
	{
		// Token: 0x06003643 RID: 13891 RVA: 0x00178FE0 File Offset: 0x001771E0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O._oOo_O0O0O_. != null)
				{
					this.O._oOo_O0O0O_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x00179020 File Offset: 0x00177220
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Oo__.o_o___0.(new C1Button());
			this.O.0___oO.(new C1Button());
			this.Oo__.o_o___0.(new CheckedListBox());
			this.Oo__.o_o___0.(new C1CheckBox());
			base.SuspendLayout();
			this.oO.OOo0_Ooo_0.().Anchor = AnchorStyles.Bottom;
			this.oO.OOo0_Ooo_0.().DialogResult = DialogResult.OK;
			this.oO.OOo0_Ooo_0.().Location = new Point(50, 312);
			this.oO.OOo0_Ooo_0.().Name = "Button1";
			this.oO.OOo0_Ooo_0.().Size = new Size(75, 23);
			this.oO.OOo0_Ooo_0.().TabIndex = 1;
			this.oO.OOo0_Ooo_0.().Text = "确定";
			this.oO.OOo0_Ooo_0.().UseVisualStyleBackColor = true;
			this.Oo__.o_o___0.().Anchor = AnchorStyles.Bottom;
			this.Oo__.o_o___0.().DialogResult = DialogResult.Cancel;
			this.Oo__.o_o___0.().Location = new Point(131, 312);
			this.Oo__.o_o___0.().Name = "Button2";
			this.Oo__.o_o___0.().Size = new Size(75, 23);
			this.Oo__.o_o___0.().TabIndex = 2;
			this.Oo__.o_o___0.().Text = "取消";
			this.Oo__.o_o___0.().UseVisualStyleBackColor = true;
			this.Oo__.o_o___0.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.Oo__.o_o___0.().CheckOnClick = true;
			this.Oo__.o_o___0.().FormattingEnabled = true;
			this.Oo__.o_o___0.().Location = new Point(12, 13);
			this.Oo__.o_o___0.().Name = "CheckedListBox1";
			this.Oo__.o_o___0.().Size = new Size(233, 260);
			this.Oo__.o_o___0.().TabIndex = 0;
			this.Oo__.o_o___0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Oo__.o_o___0.().AutoSize = true;
			this.Oo__.o_o___0.().Location = new Point(13, 280);
			this.Oo__.o_o___0.().Name = "CheckBox1";
			this.Oo__.o_o___0.().Size = new Size(84, 16);
			this.Oo__.o_o___0.().TabIndex = 3;
			this.Oo__.o_o___0.().Text = "排除所选值";
			this.Oo__.o_o___0.().UseVisualStyleBackColor = true;
			base.AcceptButton = this.oO.OOo0_Ooo_0.();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.Oo__.o_o___0.();
			base.ClientSize = new Size(257, 349);
			base.Controls.Add(this.Oo__.o_o___0.());
			base.Controls.Add(this.Oo__.o_o___0.());
			base.Controls.Add(this.Oo__.o_o___0.());
			base.Controls.Add(this.oO.OOo0_Ooo_0.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oO....O.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "选择值";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x00179315 File Offset: 0x00177515
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo__.o_o___0.;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x00179320 File Offset: 0x00177520
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0._0O0O.);
			C1Button oo__.o_o___0. = this.Oo__.o_o___0.;
			if (oo__.o_o___0. != null)
			{
				oo__.o_o___0..Click -= value;
			}
			this.Oo__.o_o___0. = A_0;
			oo__.o_o___0. = this.Oo__.o_o___0.;
			if (oo__.o_o___0. != null)
			{
				oo__.o_o___0..Click += value;
			}
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x00179363 File Offset: 0x00177563
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.0___oO.;
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x0017936B File Offset: 0x0017756B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O.0___oO. = A_0;
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00179374 File Offset: 0x00177574
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.O._oOo_O0O0O_.;
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x0017937C File Offset: 0x0017757C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			ItemCheckEventHandler value = new ItemCheckEventHandler(this.O0._0O0O.);
			CheckedListBox o._oOo_O0O0O_. = this.O._oOo_O0O0O_.;
			if (o._oOo_O0O0O_. != null)
			{
				o._oOo_O0O0O_..ItemCheck -= value;
			}
			this.O._oOo_O0O0O_. = A_0;
			o._oOo_O0O0O_. = this.O._oOo_O0O0O_.;
			if (o._oOo_O0O0O_. != null)
			{
				o._oOo_O0O0O_..ItemCheck += value;
			}
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x001793BF File Offset: 0x001775BF
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O._oOo_O0O0O_.;
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x001793C7 File Offset: 0x001775C7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O._oOo_O0O0O_. = A_0;
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x001793D0 File Offset: 0x001775D0
		public oo\u3000\u30000\u3002\u3000o\u3002(Table A_0, Col A_1)
		{
			base.FormClosed += this.O0._0O0O.;
			int num2;
			int num4;
			object obj3;
			try
			{
				IL_18:
				int num = 1;
				bool flag = Oo00.O____0O._0.(A_0);
				IL_21:
				num = 2;
				this.Oo__.o_o___0.();
				IL_29:
				num = 3;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_40:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_47:
				num = 5;
				this.O._oOo_O0O0O_. = A_0;
				IL_50:
				num = 6;
				this.O._oOo_O0O0O_. = A_1;
				IL_59:
				num = 7;
				this.Oo__.o_o___0.().Items.Add("全选", false);
				IL_72:
				num = 8;
				this.Oo__.o_o___0.().Items.Add("空白", false);
				IL_8B:
				num = 9;
				string name = A_1.Name;
				IL_96:
				num = 10;
				if (flag)
				{
					goto IL_F4;
				}
				IL_9C:
				num = 11;
				DataView dataView = new DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables[A_0.DataTable.Name], A_0.View.get_Filter(), A_1.Name, DataViewRowState.CurrentRows);
				IL_D3:
				num = 12;
				DataTable dataTable = dataView.ToTable(true, new string[]
				{
					A_1.Name
				});
				goto IL_19B;
				IL_F4:
				num = 14;
				string str = Oo00.oo_0__0.o.(A_0.DataTable._Adapter.SelectCommand.CommandText);
				IL_113:
				num = 15;
				string text = "Select Distinct [" + name + "] From " + str;
				IL_12B:
				num = 16;
				if (Operators.CompareString(A_0.DataTable.OOOOO._., "", true) <= 0)
				{
					goto IL_163;
				}
				IL_147:
				num = 17;
				text = text + " Where " + A_0.DataTable.OOOOO._.;
				IL_163:
				num = 18;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text, A_0.DataTable._Adapter.SelectCommand.Connection);
				IL_184:
				num = 19;
				dataTable = new DataTable();
				IL_18E:
				num = 20;
				oleDbDataAdapter.Fill(dataTable);
				IL_19B:
				num = 21;
				if (!A_1.IsDate())
				{
					goto IL_251;
				}
				IL_1A9:
				num = 22;
				string format = A_0.foxGrid.Cols[name].Format;
				IL_1C5:
				num = 23;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_1E6:
					num = 24;
					if (!dataRow.IsNull(name))
					{
						IL_1F4:
						num = 25;
						this.Oo__.o_o___0.().Items.Add(Strings.Format(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataRow[name])), format), false);
					}
					IL_228:
					num = 26;
				}
				IL_234:
				num = 27;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
					goto IL_2C7;
				}
				goto IL_2C7;
				IL_251:
				num = 29;
				IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					DataRow dataRow2 = (DataRow)obj2;
					IL_272:
					num = 30;
					if (!dataRow2.IsNull(name))
					{
						IL_280:
						num = 31;
						this.Oo__.o_o___0.().Items.Add(dataRow2[name].ToString(), false);
					}
					IL_2A3:
					num = 32;
				}
				IL_2AF:
				num = 33;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_2C7:
				num = 34;
				this.Text = this.Text + " - " + A_1.Caption;
				IL_2E6:
				goto IL_3C4;
				IL_2EB:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_385:
				goto IL_3B9;
				IL_387:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_397:;
			}
			catch when (endfilter(obj3 is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_387;
			}
			IL_3B9:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3C4:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x001797C8 File Offset: 0x001779C8
		private void <<EMPTY_NAME>>(object A_0, ItemCheckEventArgs A_1)
		{
			if (A_1.Index == 0)
			{
				bool value;
				if (A_1.NewValue == CheckState.Checked)
				{
					value = true;
				}
				int num = this.Oo__.o_o___0.().Items.Count - 1;
				for (int i = 1; i <= num; i++)
				{
					this.Oo__.o_o___0.().SetItemChecked(i, value);
				}
			}
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00179814 File Offset: 0x00177A14
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
				int num3 = this.Oo__.o_o___0.().Items.Count - 1;
				int num4;
				for (int i = 1; i <= num3; i++)
				{
					IL_22:
					num2 = 3;
					if (this.Oo__.o_o___0.().GetItemChecked(i))
					{
						IL_33:
						num2 = 4;
						num4++;
					}
					IL_39:
					num2 = 5;
				}
				IL_47:
				num2 = 6;
				if (num4 == 0 || num4 == this.Oo__.o_o___0.().Items.Count - 1)
				{
					goto IL_30E;
				}
				IL_67:
				num2 = 8;
				if (!this.Oo__.o_o___0.().GetItemChecked(1))
				{
					goto IL_7E;
				}
				IL_77:
				num2 = 9;
				num4--;
				IL_7E:
				num2 = 10;
				string value = "";
				IL_88:
				num2 = 11;
				string text = "";
				IL_92:
				num2 = 12;
				bool flag = Oo00.O____0O._0.(this.O._oOo_O0O0O_.);
				IL_A2:
				num2 = 13;
				if (!flag)
				{
					goto IL_C6;
				}
				IL_A9:
				num2 = 14;
				string text2 = Oo00.OoOo_oo_.o_o.(this.O._oOo_O0O0O_..Name, this.O._oOo_O0O0O_.);
				goto IL_E5;
				IL_C6:
				num2 = 16;
				text2 = "[" + this.O._oOo_O0O0O_..Name + "]";
				IL_E5:
				num2 = 17;
				StringBuilder stringBuilder = new StringBuilder();
				IL_EF:
				num2 = 18;
				if (!this.O._oOo_O0O0O_..IsDate())
				{
					goto IL_10B;
				}
				IL_FF:
				num2 = 19;
				value = "#";
				goto IL_125;
				IL_10B:
				num2 = 21;
				if (!this.O._oOo_O0O0O_..IsString())
				{
					goto IL_125;
				}
				IL_11B:
				num2 = 22;
				value = "'";
				IL_125:
				num2 = 23;
				int num5 = this.Oo__.o_o___0.().Items.Count - 1;
				for (int j = 2; j <= num5; j++)
				{
					IL_141:
					num2 = 24;
					if (this.Oo__.o_o___0.().GetItemChecked(j))
					{
						IL_153:
						num2 = 25;
						if (stringBuilder.Length > 0)
						{
							IL_160:
							num2 = 26;
							stringBuilder.Append(",");
						}
						IL_170:
						num2 = 27;
						stringBuilder.Append(value);
						IL_17D:
						num2 = 28;
						stringBuilder.Append(this.Oo__.o_o___0.().Items[j].ToString());
						IL_19F:
						num2 = 29;
						stringBuilder.Append(value);
					}
					IL_1AC:
					num2 = 30;
				}
				IL_1BB:
				num2 = 31;
				if (!this.Oo__.o_o___0.().Checked)
				{
					goto IL_280;
				}
				IL_1CE:
				num2 = 32;
				if (Operators.CompareString(stringBuilder.ToString(), "", true) <= 0)
				{
					goto IL_203;
				}
				IL_1E6:
				num2 = 33;
				text = text2 + " Not In (" + stringBuilder.ToString() + ")";
				IL_203:
				num2 = 34;
				if (!this.Oo__.o_o___0.().GetItemChecked(1))
				{
					goto IL_250;
				}
				IL_214:
				num2 = 35;
				if (Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_238;
				}
				IL_227:
				num2 = 36;
				text += " And ";
				IL_238:
				num2 = 37;
				text = text + text2 + " Is Not Null";
				goto IL_2FD;
				IL_250:
				num2 = 39;
				if (Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_2FD;
				}
				IL_266:
				num2 = 40;
				text = text + " Or " + text2 + " Is Null";
				goto IL_2FD;
				IL_280:
				num2 = 42;
				if (Operators.CompareString(stringBuilder.ToString(), "", true) <= 0)
				{
					goto IL_2B5;
				}
				IL_298:
				num2 = 43;
				text = text2 + " In (" + stringBuilder.ToString() + ")";
				IL_2B5:
				num2 = 44;
				if (!this.Oo__.o_o___0.().GetItemChecked(1))
				{
					goto IL_2FD;
				}
				IL_2C6:
				num2 = 45;
				if (Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_2EA;
				}
				IL_2D9:
				num2 = 46;
				text += " Or ";
				IL_2EA:
				num2 = 47;
				text = text + text2 + " Is Null";
				IL_2FD:
				num2 = 48;
				Filter.O0O0o.Oo0OO_oO.(this.O._oOo_O0O0O_., text, true);
				IL_30E:
				goto IL_424;
				IL_313:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_3E5:
				goto IL_419;
				IL_3E7:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_3F7:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3E7;
			}
			IL_419:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_424:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00179C6C File Offset: 0x00177E6C
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040015FC RID: 5628
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040015FD RID: 5629
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015FE RID: 5630
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015FF RID: 5631
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x04001600 RID: 5632
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001601 RID: 5633
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001602 RID: 5634
		private Col <<EMPTY_NAME>>;
	}
}
