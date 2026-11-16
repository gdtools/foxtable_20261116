using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000077 RID: 119
	internal class o0o : StringConverter
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x0001EBCA File Offset: 0x0001CDCA
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0001EBCD File Offset: 0x0001CDCD
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0001EBD0 File Offset: 0x0001CDD0
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			list.Add("");
			DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()];
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Select("[Type] = " + Conversions.ToString(37), "Index", DataViewRowState.CurrentRows))
				{
					list.Add(dataRow["Name"].ToString());
				}
			}
			return new TypeConverter.StandardValuesCollection(list);
		}
	}
}
