using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.WinForm;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000157 RID: 343
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FormattingEventArgs : ControlEventArgs
	{
		// Token: 0x0600107F RID: 4223 RVA: 0x0007E084 File Offset: 0x0007C284
		public FormattingEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, FormatEventArgs A_2) : base(A_0, A_1)
		{
			this.O0o.O_O0. = A_2;
			if (A_2.Value != null)
			{
				if (Operators.CompareString(A_2.FormatInfo.CustomFormat, "", true) > 0)
				{
					A_2.Text = Strings.Format(RuntimeHelpers.GetObjectValue(A_2.Value), A_2.FormatInfo.CustomFormat);
					return;
				}
				A_2.Text = A_2.Value.ToString();
			}
		}

		/// <summary>
		/// 返回或设置控件要显示的内容
		/// </summary>
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x0007E0F4 File Offset: 0x0007C2F4
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x0007E101 File Offset: 0x0007C301
		public string Text
		{
			get
			{
				return this.O0o.O_O0..Text;
			}
			set
			{
				this.O0o.O_O0..Text = value;
			}
		}

		/// <summary>
		/// 返回控件的值
		/// </summary>
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x0007E110 File Offset: 0x0007C310
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x0007E140 File Offset: 0x0007C340
		public object Value
		{
			get
			{
				object result;
				if (this.O0o.O_O0..Value == DBNull.Value)
				{
					result = null;
				}
				else
				{
					result = this.O0o.O_O0..Value;
				}
				return result;
			}
			set
			{
				this.O0o.O_O0..Text = value.ToString();
			}
		}

		// Token: 0x04000665 RID: 1637
		private FormatEventArgs <<EMPTY_NAME>>;
	}
}
