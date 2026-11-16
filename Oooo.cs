using System;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000086 RID: 134
	internal class Oooo : C1TextBox
	{
		// Token: 0x060004E8 RID: 1256 RVA: 0x000213E8 File Offset: 0x0001F5E8
		public Oooo()
		{
			base.Formatting += this.oo.o_Oo.;
			base.Parsing += this.oo.o_Oo.;
			base.VisualStyle = VisualStyle.System;
			base.EmptyAsNull = true;
			base.ErrorInfo.ShowErrorMessage = false;
			this.Multiline = true;
			base.InitialSelection = InitialSelectionEnum.SelectAll;
			this.DataType = typeof(string);
			this.DateTimeInput = false;
			this.NumericInput = false;
			base.ParseInfo.FormatType = FormatTypeEnum.UseEvent;
			base.FormatType = FormatTypeEnum.UseEvent;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00021478 File Offset: 0x0001F678
		private void <<EMPTY_NAME>>(object A_0, FormatEventArgs A_1)
		{
			if (A_1.Value != null)
			{
				string text = "";
				if (O_O0OO.o.00O_O.(Conversions.ToDouble(A_1.Value), ref text))
				{
					A_1.Text = text;
				}
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000214B0 File Offset: 0x0001F6B0
		private void <<EMPTY_NAME>>(object A_0, ParseEventArgs A_1)
		{
			double num;
			if (A_1.Text != null && O_O0OO.Oo0.OoOo.(this.Text, ref num))
			{
				A_1.Value = num;
			}
		}
	}
}
