using System;
using System.Collections.Generic;
using System.ComponentModel;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000052 RID: 82
	internal class O__000__Oo0 : StringConverter
	{
		// Token: 0x060002DA RID: 730 RVA: 0x00008184 File Offset: 0x00006384
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00008187 File Offset: 0x00006387
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000818C File Offset: 0x0000638C
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			list.Add("");
			try
			{
				foreach (Form form in OO_00oOO.Forms)
				{
					if (Conversions.ToInteger(form.O_o_.0o0__o0O.["Type"]) == 233)
					{
						list.Add(form.Name);
					}
				}
			}
			finally
			{
				IEnumerator<Form> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return new TypeConverter.StandardValuesCollection(list);
		}
	}
}
