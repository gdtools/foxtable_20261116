using System;
using System.ComponentModel;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000471 RID: 1137
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Report
	{
		// Token: 0x06004D73 RID: 19827 RVA: 0x0022E9B9 File Offset: 0x0022CBB9
		public Report(DataRow A_0)
		{
			this.o.0OoO. = A_0;
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06004D74 RID: 19828 RVA: 0x0022E9C8 File Offset: 0x0022CBC8
		public string Name
		{
			get
			{
				return Conversions.ToString(this.o.0OoO.["Name"]);
			}
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x0022E9E0 File Offset: 0x0022CBE0
		public void Execute()
		{
			ReportProperty reportProperty = new ReportProperty();
			if (!this.o.0OoO..IsNull("Property"))
			{
				o_O_o_oOoo__.OOOO_OO._oo.(reportProperty, Conversions.ToString(this.o.0OoO.["Property"]), '\v');
				if (reportProperty.Code != null && Operators.CompareString(reportProperty.Code[0], "", true) > 0)
				{
					string text = reportProperty.Code[0];
					if (Operators.CompareString(text, "", true) > 0)
					{
						text = text.Trim(new char[]
						{
							' ',
							'\n',
							'\r',
							'\t',
							'\u3000'
						});
					}
					string text2;
					if (text.StartsWith("'''async", StringComparison.OrdinalIgnoreCase))
					{
						text2 = "Public Async Sub Build()";
					}
					else
					{
						text2 = "Public Sub Build()";
					}
					text2 += "\r\n";
					text2 += text;
					text2 += "\r\n";
					text2 += "End Sub";
					O_O0OO.OoO_o.oO0o0O.(o0_.Oo_0.OOo0oO0.(text2, "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", true), "Build", new object[0], false, "", false);
				}
			}
		}

		// Token: 0x04001FA2 RID: 8098
		private DataRow <<EMPTY_NAME>>;
	}
}
