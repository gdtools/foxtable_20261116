using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200026D RID: 621
	[oO0oooo("2442")]
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ChildrenCollection : List<Foxtable.WinForm.Control>
	{
		// Token: 0x17000651 RID: 1617
		public Foxtable.WinForm.Control this[string Name]
		{
			get
			{
				try
				{
					foreach (Foxtable.WinForm.Control control in this)
					{
						if (Operators.CompareString(control.Name, Name, true) == 0)
						{
							return control;
						}
					}
				}
				finally
				{
					List<Foxtable.WinForm.Control>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				MessageBox.Show("找不到名称为\"" + Name + "\"的子控件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return null;
			}
		}

		// Token: 0x17000652 RID: 1618
		public new Foxtable.WinForm.Control this[int index]
		{
			get
			{
				return base[index];
			}
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x000CF290 File Offset: 0x000CD490
		public bool Contains(string Name)
		{
			try
			{
				List<Foxtable.WinForm.Control>.Enumerator enumerator = base.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.CompareString(enumerator.Current.Name, Name, true) == 0)
					{
						return true;
					}
				}
			}
			finally
			{
				List<Foxtable.WinForm.Control>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return false;
		}
	}
}
