using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000050 RID: 80
	internal class OoO_O0_OO0 : StringConverter
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x00008084 File Offset: 0x00006284
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00008087 File Offset: 0x00006287
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000808C File Offset: 0x0000628C
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			list.Add("");
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (!table.IsRelation)
					{
						list.Add(table.Name);
					}
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
