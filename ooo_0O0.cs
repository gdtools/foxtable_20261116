using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000057 RID: 87
	internal class ooo_0O0 : StringConverter
	{
		// Token: 0x060002EC RID: 748 RVA: 0x00008C20 File Offset: 0x00006E20
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00008C23 File Offset: 0x00006E23
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00008C28 File Offset: 0x00006E28
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			list.Add("");
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					list.Add(table.Name);
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			list.Sort();
			return new TypeConverter.StandardValuesCollection(list);
		}
	}
}
