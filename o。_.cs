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
	// Token: 0x02000065 RID: 101
	[DesignerGenerated]
	internal partial class o\u3002_\u3000\u3000\u3000 : Form
	{
		// Token: 0x06000375 RID: 885 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OoOO._. != null)
				{
					this.OoOO._..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000C93C File Offset: 0x0000AB3C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O._o00o_0oO_O.(new C1Button());
			this.O.0oo0O0_o.(new C1Button());
			this.O.0oo0O0_o.(new CheckedListBox());
			this.O.0oo0O0_o.(new C1TextBox());
			((ISupportInitialize)this.oO000O_Ooo.oo0.()).BeginInit();
			((ISupportInitialize)this.O_Ooo0o0._o_.()).BeginInit();
			((ISupportInitialize)this.oO000O_Ooo.oo0.()).BeginInit();
			base.SuspendLayout();
			this.oO000O_Ooo.oo0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.oO000O_Ooo.oo0.().Location = new Point(421, 414);
			this.oO000O_Ooo.oo0.().Name = "Button2";
			this.oO000O_Ooo.oo0.().Size = new Size(75, 23);
			this.oO000O_Ooo.oo0.().TabIndex = 2;
			this.oO000O_Ooo.oo0.().Text = "取消";
			this.oO000O_Ooo.oo0.().UseVisualStyleBackColor = true;
			this.O_Ooo0o0._o_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O_Ooo0o0._o_.().Location = new Point(340, 414);
			this.O_Ooo0o0._o_.().Name = "Button1";
			this.O_Ooo0o0._o_.().Size = new Size(75, 23);
			this.O_Ooo0o0._o_.().TabIndex = 1;
			this.O_Ooo0o0._o_.().Text = "确定";
			this.O_Ooo0o0._o_.().UseVisualStyleBackColor = true;
			this.oO000O_Ooo.oo0.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.oO000O_Ooo.oo0.().CheckOnClick = true;
			this.oO000O_Ooo.oo0.().FormattingEnabled = true;
			this.oO000O_Ooo.oo0.().IntegralHeight = false;
			this.oO000O_Ooo.oo0.().Location = new Point(14, 102);
			this.oO000O_Ooo.oo0.().Name = "CheckedListBox1";
			this.oO000O_Ooo.oo0.().Size = new Size(482, 300);
			this.oO000O_Ooo.oo0.().TabIndex = 0;
			this.oO000O_Ooo.oo0.().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.oO000O_Ooo.oo0.().Location = new Point(14, 14);
			this.oO000O_Ooo.oo0.().Multiline = true;
			this.oO000O_Ooo.oo0.().Name = "TextBox1";
			this.oO000O_Ooo.oo0.().ScrollBars = ScrollBars.Vertical;
			this.oO000O_Ooo.oo0.().Size = new Size(482, 74);
			this.oO000O_Ooo.oo0.().TabIndex = 3;
			this.oO000O_Ooo.oo0.().Tag = null;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(508, 449);
			base.Controls.Add(this.oO000O_Ooo.oo0.());
			base.Controls.Add(this.O_Ooo0o0._o_.());
			base.Controls.Add(this.oO000O_Ooo.oo0.());
			base.Controls.Add(this.oO000O_Ooo.oo0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmTableColumnSlector";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "选择列";
			((ISupportInitialize)this.oO000O_Ooo.oo0.()).EndInit();
			((ISupportInitialize)this.O_Ooo0o0._o_.()).EndInit();
			((ISupportInitialize)this.oO000O_Ooo.oo0.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000CC4B File Offset: 0x0000AE4B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.0oo0O0_o.;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000CC54 File Offset: 0x0000AE54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_Ooo0o0._o_.);
			C1Button o.0oo0O0_o. = this.O.0oo0O0_o.;
			if (o.0oo0O0_o. != null)
			{
				o.0oo0O0_o..Click -= value;
			}
			this.O.0oo0O0_o. = A_0;
			o.0oo0O0_o. = this.O.0oo0O0_o.;
			if (o.0oo0O0_o. != null)
			{
				o.0oo0O0_o..Click += value;
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000CC97 File Offset: 0x0000AE97
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O._o00o_0oO_O.;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO000O_Ooo.oo0.);
			C1Button o._o00o_0oO_O. = this.O._o00o_0oO_O.;
			if (o._o00o_0oO_O. != null)
			{
				o._o00o_0oO_O..Click -= value;
			}
			this.O._o00o_0oO_O. = A_0;
			o._o00o_0oO_O. = this.O._o00o_0oO_O.;
			if (o._o00o_0oO_O. != null)
			{
				o._o00o_0oO_O..Click += value;
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000CCE3 File Offset: 0x0000AEE3
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.O.0oo0O0_o.;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000CCEC File Offset: 0x0000AEEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			ItemCheckEventHandler value = new ItemCheckEventHandler(this.oO000O_Ooo.oo0.);
			CheckedListBox o.0oo0O0_o. = this.O.0oo0O0_o.;
			if (o.0oo0O0_o. != null)
			{
				o.0oo0O0_o..ItemCheck -= value;
			}
			this.O.0oo0O0_o. = A_0;
			o.0oo0O0_o. = this.O.0oo0O0_o.;
			if (o.0oo0O0_o. != null)
			{
				o.0oo0O0_o..ItemCheck += value;
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000CD2F File Offset: 0x0000AF2F
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O.0oo0O0_o.;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000CD37 File Offset: 0x0000AF37
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O.0oo0O0_o. = A_0;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000CD40 File Offset: 0x0000AF40
		public o\u3002_\u3000\u3000\u3000(Table A_0, string A_1)
		{
			base.FormClosed += this.oO000O_Ooo.oo0.;
			int num2;
			int num6;
			object obj;
			try
			{
				IL_18:
				int num = 1;
				this.O.0oo0O0_o.();
				IL_20:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_37:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_3E:
				num = 4;
				this.OoOO._. = A_0;
				IL_47:
				num = 5;
				IEnumerator<Col> enumerator = A_0.Cols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Col col = enumerator.Current;
					IL_5F:
					num = 6;
					this.oO000O_Ooo.oo0.().Items.Add(col.Name);
					IL_79:
					num = 7;
				}
				IL_83:
				num = 8;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_8E:
				num = 9;
				if (Operators.CompareString(A_1, "", true) <= 0)
				{
					goto IL_1F4;
				}
				IL_A3:
				num = 10;
				string[] array = A_1.Split(new char[]
				{
					'|'
				});
				IL_B9:
				num = 11;
				string text = "";
				IL_C3:
				num = 12;
				int num3 = array.Length - 2;
				for (int i = 0; i <= num3; i += 2)
				{
					IL_D6:
					num = 13;
					string text2 = array[i];
					IL_E0:
					num = 14;
					if (A_0.Cols.Contains(text2))
					{
						IL_F5:
						num = 15;
						int width;
						if (!int.TryParse(array[i + 1], out width))
						{
							IL_108:
							num = 16;
							width = A_0.Cols[text2].Width;
						}
						IL_11F:
						num = 17;
						text = string.Concat(new string[]
						{
							text,
							text2,
							"|",
							Conversions.ToString(width),
							"|"
						});
						IL_153:
						num = 18;
						int num4 = this.oO000O_Ooo.oo0.().Items.Count - 1;
						for (int j = 0; j <= num4; j++)
						{
							IL_16F:
							num = 19;
							if (Operators.CompareString(this.oO000O_Ooo.oo0.().Items[j].ToString(), text2, true) == 0)
							{
								IL_193:
								num = 20;
								this.oO000O_Ooo.oo0.().SetItemChecked(j, true);
							}
							IL_1A4:
							num = 21;
						}
					}
					IL_1B3:
					num = 22;
				}
				IL_1C5:
				num = 23;
				this.O.0oo0O0_o. = text.Trim(new char[]
				{
					'|'
				});
				IL_1E0:
				num = 24;
				this.oO000O_Ooo.oo0.().Value = this.O.0oo0O0_o.;
				IL_1F4:
				num = 25;
				this.OoOO._. = true;
				IL_1FE:
				goto IL_2B8;
				IL_203:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_279:
				goto IL_2AD;
				IL_27B:
				num6 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_28B:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_27B;
			}
			IL_2AD:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2B8:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000D02C File Offset: 0x0000B22C
		public o\u3002_\u3000\u3000\u3000(DataTable A_0, string A_1)
		{
			base.FormClosed += this.oO000O_Ooo.oo0.;
			int num2;
			int num6;
			object obj;
			try
			{
				IL_18:
				int num = 1;
				this.O.0oo0O0_o.();
				IL_20:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_27:
				num = 3;
				this.OoOO._. = A_0;
				IL_30:
				num = 4;
				IEnumerator<DataCol> enumerator = A_0.DataCols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataCol dataCol = enumerator.Current;
					IL_48:
					num = 5;
					this.oO000O_Ooo.oo0.().Items.Add(dataCol.Name);
					IL_62:
					num = 6;
				}
				IL_6C:
				num = 7;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_77:
				num = 8;
				if (Operators.CompareString(A_1, "", true) <= 0)
				{
					goto IL_1CB;
				}
				IL_8B:
				num = 9;
				string[] array = A_1.Split(new char[]
				{
					'|'
				});
				IL_A1:
				num = 10;
				string text = "";
				IL_AB:
				num = 11;
				int num3 = array.Length - 2;
				for (int i = 0; i <= num3; i += 2)
				{
					IL_BE:
					num = 12;
					string text2 = array[i];
					IL_C8:
					num = 13;
					if (A_0.DataCols.Contains(text2))
					{
						IL_DD:
						num = 14;
						int value;
						if (!int.TryParse(array[i + 1], out value))
						{
							IL_F0:
							num = 15;
							value = -1;
						}
						IL_F6:
						num = 16;
						text = string.Concat(new string[]
						{
							text,
							text2,
							"|",
							Conversions.ToString(value),
							"|"
						});
						IL_12A:
						num = 17;
						int num4 = this.oO000O_Ooo.oo0.().Items.Count - 1;
						for (int j = 0; j <= num4; j++)
						{
							IL_146:
							num = 18;
							if (Operators.CompareString(this.oO000O_Ooo.oo0.().Items[j].ToString(), text2, true) == 0)
							{
								IL_16A:
								num = 19;
								this.oO000O_Ooo.oo0.().SetItemChecked(j, true);
							}
							IL_17B:
							num = 20;
						}
					}
					IL_18A:
					num = 21;
				}
				IL_19C:
				num = 22;
				this.O.0oo0O0_o. = text.Trim(new char[]
				{
					'|'
				});
				IL_1B7:
				num = 23;
				this.oO000O_Ooo.oo0.().Value = this.O.0oo0O0_o.;
				IL_1CB:
				num = 24;
				this.OoOO._. = true;
				IL_1D5:
				goto IL_28B;
				IL_1DA:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_24C:
				goto IL_280;
				IL_24E:
				num6 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_25E:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_24E;
			}
			IL_280:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_28B:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000D2F1 File Offset: 0x0000B4F1
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.0oo0O0_o. = this.oO000O_Ooo.oo0.().Text;
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000D30C File Offset: 0x0000B50C
		private void <<EMPTY_NAME>>(object A_0, ItemCheckEventArgs A_1)
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
				if (!this.OoOO._.)
				{
					goto IL_147;
				}
				IL_14:
				num2 = 4;
				List<string> list = new List<string>();
				IL_1C:
				num2 = 5;
				if (Operators.CompareString(this.oO000O_Ooo.oo0.().Text, "", true) <= 0)
				{
					goto IL_5A;
				}
				IL_37:
				num2 = 6;
				list.AddRange(this.oO000O_Ooo.oo0.().Text.Split(new char[]
				{
					'|'
				}));
				IL_5A:
				num2 = 7;
				string text = this.oO000O_Ooo.oo0.().Items[A_1.Index].ToString();
				IL_79:
				num2 = 8;
				if (A_1.NewValue != CheckState.Checked)
				{
					goto IL_EA;
				}
				IL_84:
				num2 = 9;
				if (list.Contains(text))
				{
					goto IL_129;
				}
				IL_94:
				num2 = 10;
				list.Add(text);
				IL_9F:
				num2 = 11;
				if (this.OoOO._. == null)
				{
					goto IL_DA;
				}
				IL_AA:
				num2 = 12;
				list.Add(this.OoOO._..Grid.Cols[text].WidthDisplay.ToString());
				goto IL_129;
				IL_DA:
				num2 = 14;
				list.Add("-1");
				goto IL_129;
				IL_EA:
				num2 = 16;
				if (!list.Contains(text))
				{
					goto IL_129;
				}
				IL_F7:
				num2 = 17;
				int num3 = list.IndexOf(text);
				IL_104:
				num2 = 18;
				if (num3 >= list.Count - 1)
				{
					goto IL_129;
				}
				IL_113:
				num2 = 19;
				list.RemoveAt(num3);
				IL_11E:
				num2 = 20;
				list.RemoveAt(num3);
				IL_129:
				num2 = 21;
				this.oO000O_Ooo.oo0.().Value = string.Join("|", list.ToArray());
				IL_147:
				goto IL_1F1;
				IL_14C:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_1B2:
				goto IL_1E6;
				IL_1B4:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1C4:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1B4;
			}
			IL_1E6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1F1:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000D530 File Offset: 0x0000B730
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040000B2 RID: 178
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040000B3 RID: 179
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040000B4 RID: 180
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040000B5 RID: 181
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x040000B6 RID: 182
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040000B7 RID: 183
		private Table <<EMPTY_NAME>>;

		// Token: 0x040000B8 RID: 184
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x040000B9 RID: 185
		internal string <<EMPTY_NAME>>;

		// Token: 0x040000BA RID: 186
		private bool <<EMPTY_NAME>>;
	}
}
