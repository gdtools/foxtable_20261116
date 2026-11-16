using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Foxtable
{
	// Token: 0x0200003E RID: 62
	internal class o___o_O__ : StringConverter
	{
		// Token: 0x06000296 RID: 662 RVA: 0x00005C05 File Offset: 0x00003E05
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00005C08 File Offset: 0x00003E08
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00005C0C File Offset: 0x00003E0C
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			foreach (EncodingInfo encodingInfo in Encoding.GetEncodings())
			{
				list.Add(encodingInfo.Name);
			}
			list.Sort();
			return new TypeConverter.StandardValuesCollection(list);
		}
	}
}
