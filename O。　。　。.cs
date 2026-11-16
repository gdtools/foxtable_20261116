using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.Syscmd;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200035D RID: 861
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3002\u3000\u3002\u3000\u3000 : Form
	{
		// Token: 0x060035C0 RID: 13760 RVA: 0x00174E94 File Offset: 0x00173094
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_O0_OO0.0__. != null)
				{
					this.O_O0_OO0.0__..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00174ED4 File Offset: 0x001730D4
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0oOOO0OO000.O.(new C1Button());
			this.Oo0_.o_o0oo00O.(new C1Button());
			this.o0_OOOOo_oo.__.(new Label());
			this.o0_OOOOo_oo.__.(new C1DateEdit());
			this.o0_OOOOo_oo.__.(new C1ComboBox());
			((ISupportInitialize)this.Oo0_.o_o0oo00O.()).BeginInit();
			base.SuspendLayout();
			this.Oo0_.o_o0oo00O.().DialogResult = DialogResult.Cancel;
			this.Oo0_.o_o0oo00O.().Location = new Point(240, 121);
			this.Oo0_.o_o0oo00O.().Margin = new Padding(4, 5, 4, 5);
			this.Oo0_.o_o0oo00O.().Name = "Button2";
			this.Oo0_.o_o0oo00O.().Size = new Size(112, 35);
			this.Oo0_.o_o0oo00O.().TabIndex = 2;
			this.Oo0_.o_o0oo00O.().Text = "取消";
			this.Oo0_.o_o0oo00O.().UseVisualStyleBackColor = true;
			this.o_OOO0.0O.().Location = new Point(102, 121);
			this.o_OOO0.0O.().Margin = new Padding(4, 5, 4, 5);
			this.o_OOO0.0O.().Name = "Button1";
			this.o_OOO0.0O.().Size = new Size(112, 35);
			this.o_OOO0.0O.().TabIndex = 1;
			this.o_OOO0.0O.().Text = "确定";
			this.o_OOO0.0O.().UseVisualStyleBackColor = true;
			this.Oo0_.o_o0oo00O.().AutoSize = true;
			this.Oo0_.o_o0oo00O.().Location = new Point(19, 18);
			this.Oo0_.o_o0oo00O.().Margin = new Padding(4, 0, 4, 0);
			this.Oo0_.o_o0oo00O.().Name = "Label1";
			this.Oo0_.o_o0oo00O.().Size = new Size(62, 18);
			this.Oo0_.o_o0oo00O.().TabIndex = 9;
			this.Oo0_.o_o0oo00O.().Text = "Label1";
			this.Oo0_.o_o0oo00O.().AllowSpinLoop = false;
			this.Oo0_.o_o0oo00O.().BorderStyle = BorderStyle.FixedSingle;
			this.Oo0_.o_o0oo00O.().Calendar.Font = new Font("Tahoma", 8f);
			this.Oo0_.o_o0oo00O.().Calendar.VisualStyle = VisualStyle.Office2007Silver;
			this.Oo0_.o_o0oo00O.().Calendar.VisualStyleBaseStyle = VisualStyle.Office2007Silver;
			this.Oo0_.o_o0oo00O.().DateTimeInput = false;
			this.Oo0_.o_o0oo00O.().EmptyAsNull = true;
			this.Oo0_.o_o0oo00O.().Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Oo0_.o_o0oo00O.().FormatType = FormatTypeEnum.CustomFormat;
			this.Oo0_.o_o0oo00O.().ImagePadding = new Padding(0);
			this.Oo0_.o_o0oo00O.().Location = new Point(166, 59);
			this.Oo0_.o_o0oo00O.().Margin = new Padding(4, 5, 4, 5);
			this.Oo0_.o_o0oo00O.().MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			this.Oo0_.o_o0oo00O.().Name = "C1DateEdit1";
			this.Oo0_.o_o0oo00O.().Size = new Size(266, 28);
			this.Oo0_.o_o0oo00O.().TabIndex = 0;
			this.Oo0_.o_o0oo00O.().Tag = null;
			this.Oo0_.o_o0oo00O.().VisibleButtons = DropDownControlButtonFlags.DropDown;
			this.Oo0_.o_o0oo00O.().VisualStyle = VisualStyle.Office2007Silver;
			this.Oo0_.o_o0oo00O.().VisualStyleBaseStyle = VisualStyle.Office2007Silver;
			this.Oo0_.o_o0oo00O.().Location = new Point(22, 60);
			this.Oo0_.o_o0oo00O.().Margin = new Padding(3, 4, 3, 4);
			this.Oo0_.o_o0oo00O.().Name = "ComboBox1";
			this.Oo0_.o_o0oo00O.().Size = new Size(136, 26);
			this.Oo0_.o_o0oo00O.().TabIndex = 10;
			base.AcceptButton = this.o_OOO0.0O.();
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.Oo0_.o_o0oo00O.();
			base.ClientSize = new Size(454, 175);
			base.Controls.Add(this.Oo0_.o_o0oo00O.());
			base.Controls.Add(this.Oo0_.o_o0oo00O.());
			base.Controls.Add(this.Oo0_.o_o0oo00O.());
			base.Controls.Add(this.o_OOO0.0O.());
			base.Controls.Add(this.Oo0_.o_o0oo00O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.o.o.l.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "日期筛选";
			((ISupportInitialize)this.Oo0_.o_o0oo00O.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00175344 File Offset: 0x00173544
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0_OOOOo_oo.__.;
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x0017534C File Offset: 0x0017354C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o0_OOOOo_oo.__. = A_0;
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00175355 File Offset: 0x00173555
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0oOOO0OO000.O.;
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00175360 File Offset: 0x00173560
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo0__oO_o0O.Oo.);
			C1Button o0oOOO0OO000.O. = this.O0oOOO0OO000.O.;
			if (o0oOOO0OO000.O. != null)
			{
				o0oOOO0OO000.O..Click -= value;
			}
			this.O0oOOO0OO000.O. = A_0;
			o0oOOO0OO000.O. = this.O0oOOO0OO000.O.;
			if (o0oOOO0OO000.O. != null)
			{
				o0oOOO0OO000.O..Click += value;
			}
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x001753A3 File Offset: 0x001735A3
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0_OOOOo_oo.__.;
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x001753AB File Offset: 0x001735AB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0_OOOOo_oo.__. = A_0;
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x001753B4 File Offset: 0x001735B4
		[CompilerGenerated]
		internal virtual C1DateEdit <<EMPTY_NAME>>()
		{
			return this.o0_OOOOo_oo.__.;
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x001753BC File Offset: 0x001735BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DateEdit A_0)
		{
			this.o0_OOOOo_oo.__. = A_0;
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x001753C5 File Offset: 0x001735C5
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o0_OOOOo_oo.__.;
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x001753D0 File Offset: 0x001735D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.Oo0_.o_o0oo00O.);
			C1ComboBox c1ComboBox = this.o0_OOOOo_oo.__.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.o0_OOOOo_oo.__. = A_0;
			c1ComboBox = this.o0_OOOOo_oo.__.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x00175414 File Offset: 0x00173614
		public O\u3002\u3000\u3002\u3000\u3002\u3000\u3000(Table A_0, Col A_1, O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum A_2)
		{
			base.FormClosed += this.Oo0_.o_o0oo00O.;
			this.Oo0_.o_o0oo00O.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.O_O0_OO0.0__. = A_0;
			this.o0_OOOOo_oo.__. = A_1;
			this.O_O0_OO0.0__. = A_2;
			this.Oo0_.o_o0oo00O.().Text = A_1.Name + ":";
			this.Oo0_.o_o0oo00O.().EditMask = A_0.foxGrid.Cols[A_1.Name].EditMask;
			this.Oo0_.o_o0oo00O.().CustomFormat = A_0.foxGrid.Cols[A_1.Name].Format;
			if (A_1.DataCol.DateTimeFormat != DateTimeFormatEnum.Date)
			{
				this.Oo0_.o_o0oo00O.().VisibleButtons = DropDownControlButtonFlags.None;
			}
			this.Oo0_.o_o0oo00O.().Items.AddRange(Enum.GetNames(typeof(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum)));
			this.Oo0_.o_o0oo00O.().MaxDropDownItems = this.Oo0_.o_o0oo00O.().Items.Count;
			this.Oo0_.o_o0oo00O.().SelectedIndex = (int)this.O_O0_OO0.0__.;
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x00175534 File Offset: 0x00173734
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
				bool flag = Oo00.O____0O._0.(this.O_O0_OO0.0__.);
				IL_15:
				num2 = 3;
				if (!flag)
				{
					goto IL_36;
				}
				IL_1A:
				num2 = 4;
				string text = Oo00.OoOo_oo_.o_o.(this.o0_OOOOo_oo.__..Name, this.O_O0_OO0.0__.);
				goto IL_54;
				IL_36:
				num2 = 6;
				text = "[" + this.o0_OOOOo_oo.__..Name + "]";
				IL_54:
				num2 = 7;
				if (this.Oo0_.o_o0oo00O.().Value != DBNull.Value)
				{
					goto IL_AC;
				}
				IL_68:
				num2 = 8;
				O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum o_O0_OO0.0__. = this.O_O0_OO0.0__.;
				if (o_O0_OO0.0__. != O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.等于)
				{
					if (o_O0_OO0.0__. != O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不等于)
					{
						goto IL_266;
					}
					IL_96:
					num2 = 12;
					text += " Is Not Null";
					goto IL_24B;
				}
				IL_80:
				num2 = 10;
				text += " Is Null";
				goto IL_24B;
				IL_AC:
				num2 = 17;
				string text2 = Strings.Format(Conversions.ToDate(this.Oo0_.o_o0oo00O.().Value), "MM/dd/yyyy HH:mm:ss");
				IL_D0:
				num2 = 18;
				if (!flag)
				{
					goto IL_163;
				}
				IL_D9:
				num2 = 19;
				if (this.O_O0_OO0.0__..DataTable.SourceType != 1)
				{
					goto IL_107;
				}
				IL_EF:
				num2 = 20;
				text2 = "#" + text2 + "#";
				goto IL_179;
				IL_107:
				num2 = 22;
				if (this.O_O0_OO0.0__..DataTable.SourceType != 2)
				{
					goto IL_135;
				}
				IL_11D:
				num2 = 23;
				text2 = "'" + text2 + "'";
				goto IL_179;
				IL_135:
				num2 = 25;
				if (this.O_O0_OO0.0__..DataTable.SourceType != 3)
				{
					goto IL_179;
				}
				IL_14B:
				num2 = 26;
				text2 = "TO_DATE('" + text2 + "', 'MM/DD/YYYY HH24:MI:SS')";
				goto IL_179;
				IL_163:
				num2 = 28;
				text2 = "#" + text2 + "#";
				IL_179:
				num2 = 29;
				switch (this.O_O0_OO0.0__.)
				{
				case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.等于:
					IL_1A8:
					num2 = 31;
					text = text + " = " + text2;
					break;
				case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.早于:
					IL_223:
					num2 = 39;
					text = text + " < " + text2;
					break;
				case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.晚于:
					IL_1F9:
					num2 = 35;
					text = text + " > " + text2;
					break;
				case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不等于:
					IL_1C0:
					num2 = 33;
					text = string.Concat(new string[]
					{
						text,
						" <> ",
						text2,
						" Or ",
						text,
						"Is Null"
					});
					break;
				case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不早于:
					IL_238:
					num2 = 41;
					text = text + " >= " + text2;
					break;
				case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不晚于:
					IL_20E:
					num2 = 37;
					text = text + " <= " + text2;
					break;
				}
				IL_24B:
				num2 = 43;
				Filter.O0O0o.Oo0OO_oO.(this.O_O0_OO0.0__., text, true);
				IL_25C:
				num2 = 44;
				base.DialogResult = DialogResult.OK;
				IL_266:
				goto IL_36C;
				IL_26B:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_32D:
				goto IL_361;
				IL_32F:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_33F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_32F;
			}
			IL_361:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_36C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x001758D4 File Offset: 0x00173AD4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_O0_OO0.0__. = (O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum)this.Oo0_.o_o0oo00O.().SelectedIndex;
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x001758E7 File Offset: 0x00173AE7
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040015AA RID: 5546
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040015AB RID: 5547
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015AC RID: 5548
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015AD RID: 5549
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040015AE RID: 5550
		[CompilerGenerated]
		private C1DateEdit <<EMPTY_NAME>>;

		// Token: 0x040015AF RID: 5551
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040015B0 RID: 5552
		private Table <<EMPTY_NAME>>;

		// Token: 0x040015B1 RID: 5553
		private Col <<EMPTY_NAME>>;

		// Token: 0x040015B2 RID: 5554
		private O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum <<EMPTY_NAME>>;

		// Token: 0x0200035E RID: 862
		internal enum FilterModeEnum
		{
			// Token: 0x040015B4 RID: 5556
			等于,
			// Token: 0x040015B5 RID: 5557
			早于,
			// Token: 0x040015B6 RID: 5558
			晚于,
			// Token: 0x040015B7 RID: 5559
			不等于,
			// Token: 0x040015B8 RID: 5560
			不早于,
			// Token: 0x040015B9 RID: 5561
			不晚于
		}
	}
}
