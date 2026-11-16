using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Gauge.Design;

namespace Foxtable
{
	// Token: 0x02000168 RID: 360
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o__OO : GaugeCollectionEditor
	{
		// Token: 0x060010D2 RID: 4306 RVA: 0x0007E8EE File Offset: 0x0007CAEE
		public o__OO(Type A_0) : base(A_0)
		{
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0007E8F8 File Offset: 0x0007CAF8
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
