using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000051 RID: 81
	internal class oO0O_O : StringConverter
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x0000810C File Offset: 0x0000630C
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000810F File Offset: 0x0000630F
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00008114 File Offset: 0x00006314
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			list.Add("");
			try
			{
				foreach (UserInfo userInfo in OO_00oOO.Users)
				{
					list.Add(userInfo.Name);
				}
			}
			finally
			{
				IEnumerator<UserInfo> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return new TypeConverter.StandardValuesCollection(list);
		}
	}
}
