using System;
using System.Collections.Generic;
using System.ComponentModel;
using Neodynamic.WinControls.BarcodeProfessional;

namespace Foxtable
{
	// Token: 0x0200003B RID: 59
	internal class OoOO___oo : StringConverter
	{
		// Token: 0x0600028D RID: 653 RVA: 0x00005B86 File Offset: 0x00003D86
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00005B89 File Offset: 0x00003D89
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00005B8C File Offset: 0x00003D8C
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			list.AddRange(Enum.GetNames(typeof(Symbology)));
			list.Sort();
			return new TypeConverter.StandardValuesCollection(list);
		}
	}
}
