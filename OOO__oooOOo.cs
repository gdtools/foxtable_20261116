using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;

namespace Foxtable
{
	// Token: 0x0200004C RID: 76
	internal class OOO__oooOOo : StringConverter
	{
		// Token: 0x060002C4 RID: 708 RVA: 0x00007824 File Offset: 0x00005A24
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00007827 File Offset: 0x00005A27
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000782C File Offset: 0x00005A2C
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			list.Add("");
			try
			{
				foreach (string item in O_O0OO.O._o_.().Keys)
				{
					list.Add(item);
				}
			}
			finally
			{
				Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (string item2 in O_O0OO.OoO__.0oO0oo.().Keys)
				{
					list.Add(item2);
				}
			}
			finally
			{
				Dictionary<string, O0O>.KeyCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			return new TypeConverter.StandardValuesCollection(list);
		}
	}
}
