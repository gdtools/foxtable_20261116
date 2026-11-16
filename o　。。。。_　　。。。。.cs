using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.Syscmd;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200035F RID: 863
	[DesignerGenerated]
	internal partial class o\u3000\u3002\u3002\u3002\u3002_\u3000\u3000\u3002\u3002\u3002\u3002 : Form
	{
		// Token: 0x060035D0 RID: 13776 RVA: 0x001758FC File Offset: 0x00173AFC
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.Oo0O.OO_. != null)
				{
					this.Oo0O.OO_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x0017593C File Offset: 0x00173B3C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OoO__o_.o_O_.(new C1DateEdit());
			this.O.OO0_.(new C1Button());
			this.OoO__o_.o_O_.(new C1Button());
			this.O.OO0_.(new Label());
			this.O.OO0_.(new C1DateEdit());
			this.OoO__o_.o_O_.(new Label());
			((ISupportInitialize)this.oo_o.0000.()).BeginInit();
			((ISupportInitialize)this.O_O0_OO0.0__.()).BeginInit();
			base.SuspendLayout();
			this.oo_o.0000.().Calendar.AnnuallyBoldedDates = new DateTime[0];
			this.oo_o.0000.().Calendar.BoldedDates = new DateTime[0];
			this.oo_o.0000.().Calendar.ClearText = "&Clear";
			this.oo_o.0000.().Calendar.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.oo_o.0000.().Calendar.Margin = new Padding(0);
			this.oo_o.0000.().Calendar.MonthlyBoldedDates = new DateTime[0];
			this.oo_o.0000.().Calendar.SelectedDate = new DateTime(2007, 11, 5, 0, 0, 0, 0);
			this.oo_o.0000.().Calendar.TodayText = "&Today";
			this.oo_o.0000.().Calendar.VisualStyle = VisualStyle.System;
			this.oo_o.0000.().Calendar.VisualStyleBaseStyle = VisualStyle.System;
			this.oo_o.0000.().DateTimeInput = false;
			this.oo_o.0000.().FormatType = FormatTypeEnum.CustomFormat;
			this.oo_o.0000.().Location = new Point(19, 34);
			this.oo_o.0000.().MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			this.oo_o.0000.().Name = "C1DateEdit1";
			this.oo_o.0000.().Size = new Size(132, 21);
			this.oo_o.0000.().TabIndex = 0;
			this.oo_o.0000.().Tag = null;
			this.O_O0_OO0.0__.().DialogResult = DialogResult.Cancel;
			this.O_O0_OO0.0__.().Location = new Point(167, 71);
			this.O_O0_OO0.0__.().Name = "Button2";
			this.O_O0_OO0.0__.().Size = new Size(75, 23);
			this.O_O0_OO0.0__.().TabIndex = 3;
			this.O_O0_OO0.0__.().Text = "取消";
			this.O_O0_OO0.0__.().UseVisualStyleBackColor = true;
			this.oo_o.0000.().Location = new Point(86, 71);
			this.oo_o.0000.().Name = "Button1";
			this.oo_o.0000.().Size = new Size(75, 23);
			this.oo_o.0000.().TabIndex = 2;
			this.oo_o.0000.().Text = "确定";
			this.oo_o.0000.().UseVisualStyleBackColor = true;
			this.OoO__o_.o_O_.().AutoSize = true;
			this.OoO__o_.o_O_.().Location = new Point(17, 12);
			this.OoO__o_.o_O_.().Name = "Label1";
			this.OoO__o_.o_O_.().Size = new Size(41, 12);
			this.OoO__o_.o_O_.().TabIndex = 13;
			this.OoO__o_.o_O_.().Text = "Label1";
			this.O_O0_OO0.0__.().Calendar.AnnuallyBoldedDates = new DateTime[0];
			this.O_O0_OO0.0__.().Calendar.BoldedDates = new DateTime[0];
			this.O_O0_OO0.0__.().Calendar.ClearText = "&Clear";
			this.O_O0_OO0.0__.().Calendar.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.O_O0_OO0.0__.().Calendar.Margin = new Padding(0);
			this.O_O0_OO0.0__.().Calendar.MonthlyBoldedDates = new DateTime[0];
			this.O_O0_OO0.0__.().Calendar.SelectedDate = new DateTime(2007, 11, 5, 0, 0, 0, 0);
			this.O_O0_OO0.0__.().Calendar.TodayText = "&Today";
			this.O_O0_OO0.0__.().Calendar.VisualStyle = VisualStyle.System;
			this.O_O0_OO0.0__.().Calendar.VisualStyleBaseStyle = VisualStyle.System;
			this.O_O0_OO0.0__.().DateTimeInput = false;
			this.O_O0_OO0.0__.().FormatType = FormatTypeEnum.CustomFormat;
			this.O_O0_OO0.0__.().Location = new Point(180, 34);
			this.O_O0_OO0.0__.().MaskInfo.ShowLiterals = ShowLiteralsEnum.WhenPrevFilled;
			this.O_O0_OO0.0__.().Name = "C1DateEdit2";
			this.O_O0_OO0.0__.().Size = new Size(132, 21);
			this.O_O0_OO0.0__.().TabIndex = 1;
			this.O_O0_OO0.0__.().Tag = null;
			this.O.OO0_.().AutoSize = true;
			this.O.OO0_.().Location = new Point(157, 37);
			this.O.OO0_.().Name = "Label2";
			this.O.OO0_.().Size = new Size(17, 12);
			this.O.OO0_.().TabIndex = 18;
			this.O.OO0_.().Text = "至";
			base.AcceptButton = this.oo_o.0000.();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.O_O0_OO0.0__.();
			base.ClientSize = new Size(328, 104);
			base.Controls.Add(this.O.OO0_.());
			base.Controls.Add(this.O_O0_OO0.0__.());
			base.Controls.Add(this.oo_o.0000.());
			base.Controls.Add(this.O_O0_OO0.0__.());
			base.Controls.Add(this.oo_o.0000.());
			base.Controls.Add(this.OoO__o_.o_O_.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.o0..0.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "日期筛选";
			((ISupportInitialize)this.oo_o.0000.()).EndInit();
			((ISupportInitialize)this.O_O0_OO0.0__.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x00175F14 File Offset: 0x00174114
		[CompilerGenerated]
		internal virtual C1DateEdit <<EMPTY_NAME>>()
		{
			return this.Oo0O.OO_.;
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x00175F1C File Offset: 0x0017411C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DateEdit A_0)
		{
			this.Oo0O.OO_. = A_0;
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x00175F25 File Offset: 0x00174125
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo0O.OO_.;
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x00175F2D File Offset: 0x0017412D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.Oo0O.OO_. = A_0;
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x00175F36 File Offset: 0x00174136
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.OO0_.;
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x00175F40 File Offset: 0x00174140
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_O0_OO0.0__.);
			C1Button o.OO0_. = this.O.OO0_.;
			if (o.OO0_. != null)
			{
				o.OO0_..Click -= value;
			}
			this.O.OO0_. = A_0;
			o.OO0_. = this.O.OO0_.;
			if (o.OO0_. != null)
			{
				o.OO0_..Click += value;
			}
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x00175F83 File Offset: 0x00174183
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo0O.OO_.;
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00175F8B File Offset: 0x0017418B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo0O.OO_. = A_0;
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x00175F94 File Offset: 0x00174194
		[CompilerGenerated]
		internal virtual C1DateEdit <<EMPTY_NAME>>()
		{
			return this.oo_o_Oo_.oo0.;
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x00175F9C File Offset: 0x0017419C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DateEdit A_0)
		{
			this.oo_o_Oo_.oo0. = A_0;
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x00175FA5 File Offset: 0x001741A5
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo_o_Oo_.oo0.;
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x00175FAD File Offset: 0x001741AD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo_o_Oo_.oo0. = A_0;
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x00175FB8 File Offset: 0x001741B8
		public o\u3000\u3002\u3002\u3002\u3002_\u3000\u3000\u3002\u3002\u3002\u3002(Table A_0, Col A_1, bool A_2)
		{
			base.FormClosed += this.O_O0_OO0.0__.;
			int num2;
			int num4;
			object obj;
			try
			{
				IL_18:
				int num = 1;
				this.OoO__o_.o_O_.();
				IL_20:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_37:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_3E:
				num = 4;
				this.Oo0O.OO_. = A_0;
				IL_47:
				num = 5;
				this.Oo0O.OO_. = A_1;
				IL_50:
				num = 6;
				this.Oo0O.OO_. = A_2;
				IL_59:
				num = 7;
				if (!A_2)
				{
					goto IL_7D;
				}
				IL_5E:
				num = 8;
				this.OoO__o_.o_O_.().Text = A_1.Name + " 在以下范围之外:";
				goto IL_9B;
				IL_7D:
				num = 10;
				this.OoO__o_.o_O_.().Text = A_1.Name + " 在以下范围之内:";
				IL_9B:
				num = 11;
				this.oo_o.0000.().EditMask = A_0.foxGrid.Cols[A_1.Name].EditMask;
				IL_C4:
				num = 12;
				this.oo_o.0000.().CustomFormat = A_0.foxGrid.Cols[A_1.Name].Format;
				IL_ED:
				num = 13;
				if (A_1.DataCol.DateTimeFormat == DateTimeFormatEnum.Date)
				{
					goto IL_10C;
				}
				IL_FD:
				num = 14;
				this.oo_o.0000.().VisibleButtons = DropDownControlButtonFlags.None;
				IL_10C:
				num = 15;
				this.O_O0_OO0.0__.().EditMask = A_0.foxGrid.Cols[A_1.Name].EditMask;
				IL_135:
				num = 16;
				this.O_O0_OO0.0__.().CustomFormat = A_0.foxGrid.Cols[A_1.Name].Format;
				IL_15E:
				num = 17;
				if (A_1.DataCol.DateTimeFormat == DateTimeFormatEnum.Date)
				{
					goto IL_17D;
				}
				IL_16E:
				num = 18;
				this.O_O0_OO0.0__.().VisibleButtons = DropDownControlButtonFlags.None;
				IL_17D:
				goto IL_21B;
				IL_182:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1DC:
				goto IL_210;
				IL_1DE:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_1EE:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1DE;
			}
			IL_210:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_21B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x00176204 File Offset: 0x00174404
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oo_o.0000.().Value != DBNull.Value && this.O_O0_OO0.0__.().Value != DBNull.Value)
			{
				DateTime a_ = Conversions.ToDate(this.oo_o.0000.().Value);
				DateTime a_2 = Conversions.ToDate(this.O_O0_OO0.0__.().Value);
				Filter.O0O0o.Oo0OO_oO.(this.Oo0O.OO_., this.Oo0O.OO_..Name, a_, a_2, this.Oo0O.OO_.);
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x0017627C File Offset: 0x0017447C
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040015BA RID: 5562
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040015BB RID: 5563
		[CompilerGenerated]
		private C1DateEdit <<EMPTY_NAME>>;

		// Token: 0x040015BC RID: 5564
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015BD RID: 5565
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015BE RID: 5566
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040015BF RID: 5567
		[CompilerGenerated]
		private C1DateEdit <<EMPTY_NAME>>;

		// Token: 0x040015C0 RID: 5568
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040015C1 RID: 5569
		private Table <<EMPTY_NAME>>;

		// Token: 0x040015C2 RID: 5570
		private Col <<EMPTY_NAME>>;

		// Token: 0x040015C3 RID: 5571
		private bool <<EMPTY_NAME>>;
	}
}
