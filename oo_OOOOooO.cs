using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Gauge.Design;

namespace Foxtable
{
	// Token: 0x02000179 RID: 377
	public class oo_OOOOooO : ShapeCollectionEditor
	{
		// Token: 0x0600120E RID: 4622 RVA: 0x000800F5 File Offset: 0x0007E2F5
		public oo_OOOOooO(Type A_0) : base(A_0)
		{
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00080100 File Offset: 0x0007E300
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			try
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					if (form is o\u3000\u3002)
					{
						((o\u3000\u3002)form).OO_._oOo. = true;
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
			return base.EditValue(context, provider, RuntimeHelpers.GetObjectValue(value));
		}
	}
}
