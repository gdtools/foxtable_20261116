using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000150 RID: 336
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class oOo0o0__0 : DropDownForm
	{
		// Token: 0x06001060 RID: 4192 RVA: 0x0007DBFB File Offset: 0x0007BDFB
		public oOo0o0__0()
		{
			this.o.O_OO.();
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0007DC0C File Offset: 0x0007BE0C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o.O_OO. != null)
				{
					this.o.O_OO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0007DC4C File Offset: 0x0007BE4C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o.O_OO.(new DateEditMonthCalendar());
			base.SuspendLayout();
			this.o.O_OO.().ClearText = "清空（&C）";
			this.o.O_OO.().Font = new Font("Tahoma", 8f);
			this.o.O_OO.().RightToLeft = RightToLeft.Inherit;
			this.o.O_OO.().ShowClearButton = false;
			this.o.O_OO.().ShowTodayCircle = false;
			this.o.O_OO.().TodayText = "今日（&T）";
			this.o.O_OO.().VisualStyleBaseStyle = VisualStyle.Office2010Blue;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(296, 292);
			base.Controls.Add(this.o.O_OO.());
			base.Name = "oI1I_.O.";
			this.Text = "DropCalendar";
			base.ResumeLayout(false);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0007DD33 File Offset: 0x0007BF33
		[CompilerGenerated]
		internal virtual DateEditMonthCalendar <<EMPTY_NAME>>()
		{
			return this.o.O_OO.;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0007DD3C File Offset: 0x0007BF3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(DateEditMonthCalendar A_0)
		{
			NullableDateTimeEventHandler value = new NullableDateTimeEventHandler(this.ooo_OOO.O0O.);
			DateEditMonthCalendar dateEditMonthCalendar = this.o.O_OO.;
			if (dateEditMonthCalendar != null)
			{
				dateEditMonthCalendar.DateValueSelected -= value;
			}
			this.o.O_OO. = A_0;
			dateEditMonthCalendar = this.o.O_OO.;
			if (dateEditMonthCalendar != null)
			{
				dateEditMonthCalendar.DateValueSelected += value;
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0007DD7F File Offset: 0x0007BF7F
		private void <<EMPTY_NAME>>(object A_0, NullableDateTimeEventArgs A_1)
		{
			base.OwnerControl.Value = A_1.Date;
			base.OwnerControl.CloseDropDown();
		}

		// Token: 0x04000655 RID: 1621
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000656 RID: 1622
		[CompilerGenerated]
		private DateEditMonthCalendar <<EMPTY_NAME>>;
	}
}
