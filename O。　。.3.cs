using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000376 RID: 886
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3002\u3000 : Form
	{
		// Token: 0x060038C0 RID: 14528 RVA: 0x00194580 File Offset: 0x00192780
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oO.0_0. != null)
				{
					this.oO.0_0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x001945C0 File Offset: 0x001927C0
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OooO_O0o.o.(new CheckedListBox());
			this.O00_0.OO_oOoOo.(new C1Button());
			this.O0.0__oO0.(new C1Button());
			this.OooO_O0o.o.(new C1Button());
			this.OO_.ooo_OO0.(new C1Button());
			base.SuspendLayout();
			this.OO.OO000oO.().CheckOnClick = true;
			this.OO.OO000oO.().FormattingEnabled = true;
			this.OO.OO000oO.().Location = new Point(12, 12);
			this.OO.OO000oO.().Name = "CList";
			this.OO.OO000oO.().Size = new Size(265, 324);
			this.OO.OO000oO.().TabIndex = 0;
			this.Ooo0_.OO.().DialogResult = DialogResult.OK;
			this.Ooo0_.OO.().Location = new Point(292, 12);
			this.Ooo0_.OO.().Name = "Button1";
			this.Ooo0_.OO.().Size = new Size(75, 23);
			this.Ooo0_.OO.().TabIndex = 1;
			this.Ooo0_.OO.().Text = "确定";
			this.Ooo0_.OO.().UseVisualStyleBackColor = true;
			this.OO.OO000oO.().DialogResult = DialogResult.Cancel;
			this.OO.OO000oO.().Location = new Point(292, 42);
			this.OO.OO000oO.().Name = "Button2";
			this.OO.OO000oO.().Size = new Size(75, 23);
			this.OO.OO000oO.().TabIndex = 2;
			this.OO.OO000oO.().Text = "取消";
			this.OO.OO000oO.().UseVisualStyleBackColor = true;
			this.OoOo.0__O.().Location = new Point(292, 281);
			this.OoOo.0__O.().Name = "Button3";
			this.OoOo.0__O.().Size = new Size(75, 23);
			this.OoOo.0__O.().TabIndex = 3;
			this.OoOo.0__O.().Text = "全选";
			this.OoOo.0__O.().UseVisualStyleBackColor = true;
			this.O_o.0_Oo0OoO.().Location = new Point(292, 313);
			this.O_o.0_Oo0OoO.().Name = "Button4";
			this.O_o.0_Oo0OoO.().Size = new Size(75, 23);
			this.O_o.0_Oo0OoO.().TabIndex = 4;
			this.O_o.0_Oo0OoO.().Text = "清除";
			this.O_o.0_Oo0OoO.().UseVisualStyleBackColor = true;
			base.AcceptButton = this.Ooo0_.OO.();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.OO.OO000oO.();
			base.ClientSize = new Size(380, 350);
			base.Controls.Add(this.O_o.0_Oo0OoO.());
			base.Controls.Add(this.OoOo.0__O.());
			base.Controls.Add(this.OO.OO000oO.());
			base.Controls.Add(this.Ooo0_.OO.());
			base.Controls.Add(this.OO.OO000oO.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O...o000";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "选择统计列";
			base.ResumeLayout(false);
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x001948F4 File Offset: 0x00192AF4
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.oO.0_0.;
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x001948FC File Offset: 0x00192AFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			ListControlConvertEventHandler value = new ListControlConvertEventHandler(this.OO.OO000oO.);
			CheckedListBox checkedListBox = this.oO.0_0.;
			if (checkedListBox != null)
			{
				checkedListBox.Format -= value;
			}
			this.oO.0_0. = A_0;
			checkedListBox = this.oO.0_0.;
			if (checkedListBox != null)
			{
				checkedListBox.Format += value;
			}
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x0019493F File Offset: 0x00192B3F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OooO_O0o.o.;
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x00194948 File Offset: 0x00192B48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOoooO.O.);
			C1Button oooO_O0o.o. = this.OooO_O0o.o.;
			if (oooO_O0o.o. != null)
			{
				oooO_O0o.o..Click -= value;
			}
			this.OooO_O0o.o. = A_0;
			oooO_O0o.o. = this.OooO_O0o.o.;
			if (oooO_O0o.o. != null)
			{
				oooO_O0o.o..Click += value;
			}
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x0019498B File Offset: 0x00192B8B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO_.ooo_OO0.;
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x00194993 File Offset: 0x00192B93
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.OO_.ooo_OO0. = A_0;
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x0019499C File Offset: 0x00192B9C
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O00_0.OO_oOoOo.;
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x001949A4 File Offset: 0x00192BA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_Oo0.0o.);
			C1Button o00_0.OO_oOoOo. = this.O00_0.OO_oOoOo.;
			if (o00_0.OO_oOoOo. != null)
			{
				o00_0.OO_oOoOo..Click -= value;
			}
			this.O00_0.OO_oOoOo. = A_0;
			o00_0.OO_oOoOo. = this.O00_0.OO_oOoOo.;
			if (o00_0.OO_oOoOo. != null)
			{
				o00_0.OO_oOoOo..Click += value;
			}
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x001949E7 File Offset: 0x00192BE7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO.oO.;
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x001949F0 File Offset: 0x00192BF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.0_OoooOo0O.);
			C1Button c1Button = this.oO.oO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO.oO. = A_0;
			c1Button = this.oO.oO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x00194A34 File Offset: 0x00192C34
		public O\u3002\u3000\u3002\u3000(Table A_0, string A_1, AggregateEnum A_2)
		{
			base.Activated += this.O_._OoOo0o0oO.;
			base.Load += this.Ooo0_.OO.;
			base.FormClosed += this.OO.OO000oO.;
			this.OooO_O0o.o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oO.0_0. = A_0;
			this.oO.0_0. = A_1;
			this.oO.0_0. = A_2;
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x00194AAD File Offset: 0x00192CAD
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OooO_O0o.o. == 0)
			{
				this.OooO_O0o.o. = 1;
				this.oO.0_0..Oo0Oo___.o0o.();
			}
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x00194ACC File Offset: 0x00192CCC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
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
				string[] collection = new string[0];
				IL_10:
				num2 = 3;
				if (Operators.CompareString(this.oO.0_0., "", true) <= 0)
				{
					goto IL_3F;
				}
				IL_26:
				num2 = 4;
				collection = this.oO.0_0..Split(new char[]
				{
					','
				});
				IL_3F:
				num2 = 5;
				List<string> list = new List<string>();
				IL_48:
				num2 = 6;
				list.AddRange(collection);
				IL_52:
				num2 = 7;
				int @fixed = this.oO.0_0..foxGrid.Cols.Fixed;
				int num3 = this.oO.0_0..foxGrid.Cols.Count - 1;
				int i = @fixed;
				while (i <= num3)
				{
					IL_89:
					num2 = 8;
					if (this.oO.0_0..foxGrid.Cols[i].DataType == typeof(string))
					{
						IL_B3:
						num2 = 9;
						if (this.oO.0_0. == AggregateEnum.Count)
						{
							goto IL_155;
						}
					}
					else
					{
						IL_C7:
						num2 = 12;
						if (this.oO.0_0..foxGrid.Cols[i].DataType == typeof(bool))
						{
							IL_F2:
							num2 = 13;
							if (this.oO.0_0. == AggregateEnum.Count || this.oO.0_0. == AggregateEnum.Sum)
							{
								goto IL_155;
							}
						}
						else
						{
							IL_10C:
							num2 = 16;
							if (this.oO.0_0..foxGrid.Cols[i].DataType != typeof(DateTime))
							{
								goto IL_155;
							}
							IL_137:
							num2 = 17;
							if (this.oO.0_0. == AggregateEnum.Count || this.oO.0_0. == AggregateEnum.Max || this.oO.0_0. == AggregateEnum.Min)
							{
								goto IL_155;
							}
						}
					}
					IL_1CE:
					num2 = 22;
					i++;
					continue;
					IL_155:
					num2 = 19;
					this.OO.OO000oO.().Items.Add(this.oO.0_0..foxGrid.Cols[i].Name);
					IL_185:
					num2 = 20;
					if (list.Contains(this.oO.0_0..foxGrid.Cols[i].Name))
					{
						IL_1AD:
						num2 = 21;
						this.OO.OO000oO.().SetItemChecked(this.OO.OO000oO.().Items.Count - 1, true);
						goto IL_1CE;
					}
					goto IL_1CE;
				}
				IL_1E0:
				goto IL_28E;
				IL_1E5:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_24F:
				goto IL_283;
				IL_251:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_261:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_251;
			}
			IL_283:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_28E:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x00194D8C File Offset: 0x00192F8C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oO.0_0. = "";
			int num = this.OO.OO000oO.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (this.OO.OO000oO.().GetItemChecked(i))
				{
					if (Operators.CompareString(this.oO.0_0., "", true) > 0)
					{
						this.oO.0_0. += ",";
					}
					this.oO.0_0. += this.OO.OO000oO.().Items[i].ToString();
				}
			}
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x00194E24 File Offset: 0x00193024
		private void <<EMPTY_NAME>>(object A_0, ListControlConvertEventArgs A_1)
		{
			if (this.oO.0_0..Cols.Contains(A_1.Value.ToString()))
			{
				A_1.Value = this.oO.0_0..Cols[A_1.Value.ToString()].Caption;
			}
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00194E74 File Offset: 0x00193074
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num = this.OO.OO000oO.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				this.OO.OO000oO.().SetItemChecked(i, true);
			}
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x00194EB0 File Offset: 0x001930B0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num = this.OO.OO000oO.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				this.OO.OO000oO.().SetItemChecked(i, false);
			}
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x00194EE9 File Offset: 0x001930E9
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400173E RID: 5950
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400173F RID: 5951
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x04001740 RID: 5952
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001741 RID: 5953
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001742 RID: 5954
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001743 RID: 5955
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001744 RID: 5956
		internal string <<EMPTY_NAME>>;

		// Token: 0x04001745 RID: 5957
		private AggregateEnum <<EMPTY_NAME>>;

		// Token: 0x04001746 RID: 5958
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001747 RID: 5959
		private int <<EMPTY_NAME>>;
	}
}
