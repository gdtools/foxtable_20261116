using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003B7 RID: 951
	[ComVisible(true)]
	[oO0oooo("0706")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ControlCollection : IEnumerable<Foxtable.WinForm.Control>
	{
		// Token: 0x06003DAC RID: 15788 RVA: 0x001BF179 File Offset: 0x001BD379
		public ControlCollection(Foxtable.WinForm.Form A_0, System.Windows.Forms.Control.ControlCollection A_1)
		{
			this.O.OOO0000_0. = A_0;
			this.O.OOO0000_0. = A_1;
		}

		// Token: 0x17000CDC RID: 3292
		public object this[string Name]
		{
			get
			{
				Foxtable.WinForm.Control control = null;
				if (this.O.OOO0000_0..Pane != null && !this.O.OOO0000_0..Pane.IsDisposed)
				{
					control = this.O.OOO0000_0..o_._o000O.(this.O.OOO0000_0., Name);
					if (control == null)
					{
						MessageBox.Show("找不到名称为\"" + Name + "\"的控件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					MessageBox.Show(this.O.OOO0000_0..Name + "已经关闭，不能调用其中的控件\"" + Name + "\" ！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				if (control != null)
				{
					control.o.__O0O. = this.O.OOO0000_0.;
				}
				return control;
			}
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x001BF22D File Offset: 0x001BD42D
		public bool Contains(string Name)
		{
			return this.O.OOO0000_0..o_._o000O.(this.O.OOO0000_0., Name) != null;
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x001BF244 File Offset: 0x001BD444
		public IEnumerator<Foxtable.WinForm.Control> GetEnumerator()
		{
			return new oo0(this.O.OOO0000_0., this.O.OOO0000_0.);
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x001BF257 File Offset: 0x001BD457
		public IEnumerator GetEnumerator1()
		{
			return new oo0(this.O.OOO0000_0., this.O.OOO0000_0.);
		}

		// Token: 0x04001945 RID: 6469
		private Foxtable.WinForm.Form <<EMPTY_NAME>>;

		// Token: 0x04001946 RID: 6470
		private System.Windows.Forms.Control.ControlCollection <<EMPTY_NAME>>;
	}
}
