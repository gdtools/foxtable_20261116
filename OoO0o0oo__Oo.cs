using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000046 RID: 70
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OoO0o0oo__Oo : ExpandableObjectConverter
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x00005D01 File Offset: 0x00003F01
		public virtual bool <<EMPTY_NAME>>(ITypeDescriptorContext A_0)
		{
			return true;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00005D04 File Offset: 0x00003F04
		public virtual PropertyDescriptorCollection <<EMPTY_NAME>>(ITypeDescriptorContext A_0, object A_1, Attribute[] A_2)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(RuntimeHelpers.GetObjectValue(A_1), A_2);
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			try
			{
				foreach (object obj in properties)
				{
					PropertyDescriptor propertyDescriptor = (PropertyDescriptor)obj;
					Attribute attribute = propertyDescriptor.Attributes[typeof(O_Oo00Oo000O0)];
					if (attribute != null)
					{
						O_Oo00Oo000O0 o_Oo00Oo000O = (O_Oo00Oo000O0)attribute;
						arrayList.Add(new O0o_00oO__0_(propertyDescriptor.Name, o_Oo00Oo000O.o0oO__._Oo0O.()));
					}
					else
					{
						arrayList.Add(new O0o_00oO__0_(propertyDescriptor.Name, 0.0));
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			arrayList.Sort();
			try
			{
				foreach (object obj2 in arrayList)
				{
					O0o_00oO__0_ o0o_00oO__0_ = (O0o_00oO__0_)obj2;
					arrayList2.Add(o0o_00oO__0_.Name);
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			return properties.Sort((string[])arrayList2.ToArray(typeof(string)));
		}
	}
}
