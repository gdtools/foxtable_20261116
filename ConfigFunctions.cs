using System;
using System.ComponentModel;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000448 RID: 1096
	[StandardModule]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class ConfigFunctions
	{
		// Token: 0x060049EC RID: 18924 RVA: 0x0020B564 File Offset: 0x00209764
		public static void SaveValue(string Name, object Value, DataTable dt, string ProjectIdentify)
		{
			if (Value == null)
			{
				Value = "";
			}
			DataRow dataRow = dt.Rows.Find(new object[]
			{
				O00.EncryptText(Name, "Config", ProjectIdentify.Substring(6)),
				o0_O.o0OOOo0_Oo.__0.
			});
			if (dataRow == null)
			{
				dataRow = dt.NewRow();
				dataRow["Name"] = O00.EncryptText(Name, "Config", ProjectIdentify.Substring(6));
				dataRow["Type"] = o0_O.o0OOOo0_Oo.__0.;
				dt.Rows.Add(dataRow);
			}
			dataRow["Config"] = O00.EncryptText(Value.ToString(), Name, ProjectIdentify.Substring(6));
			Oo00.O0Oo_O.0O_0O.(dataRow);
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x0020B618 File Offset: 0x00209818
		public static object GetValue(string Name, object DefaultValue, DataTable dt, string ProjectIdentify)
		{
			DataRow dataRow = dt.Rows.Find(new object[]
			{
				O00.EncryptText(Name, "Config", ProjectIdentify.Substring(6)),
				o0_O.o0OOOo0_Oo.__0.
			});
			object result;
			if (dataRow == null || dataRow.IsNull("Config"))
			{
				result = DefaultValue;
			}
			else
			{
				result = O00.DecryptText(dataRow["Config"].ToString(), Name, ProjectIdentify.Substring(6));
			}
			return result;
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x0020B68C File Offset: 0x0020988C
		public static void RemoveItem(string Name, DataTable dt, string ProjectIdentify)
		{
			DataRow dataRow = dt.Rows.Find(new object[]
			{
				O00.EncryptText(Name, "Config", ProjectIdentify.Substring(6)),
				o0_O.o0OOOo0_Oo.__0.
			});
			if (dataRow != null)
			{
				dataRow.Delete();
				Oo00.O0Oo_O.0O_0O.(dataRow);
			}
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x0020B6DC File Offset: 0x002098DC
		public static void ClearItmes(DataTable dt)
		{
			foreach (DataRow dataRow in dt.Select("[Type] = " + Conversions.ToString(16), "", DataViewRowState.CurrentRows))
			{
				dataRow.Delete();
				Oo00.O0Oo_O.0O_0O.(dataRow);
			}
		}
	}
}
