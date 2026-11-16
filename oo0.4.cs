using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003B8 RID: 952
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class oo0 : IEnumerator<Foxtable.WinForm.Control>
	{
		// Token: 0x06003DB1 RID: 15793 RVA: 0x001BF26A File Offset: 0x001BD46A
		public oo0(Foxtable.WinForm.Form A_0, System.Windows.Forms.Control.ControlCollection A_1)
		{
			this.lst = new List<Foxtable.WinForm.Control>();
			this._Index = -1;
			this.disposedValue = false;
			this._frm = A_0;
			this._controls = A_1;
			this.CreateList(this._controls);
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x001BF2A8 File Offset: 0x001BD4A8
		private void CreateList(System.Windows.Forms.Control.ControlCollection Controls)
		{
			try
			{
				foreach (object obj in Controls)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					Foxtable.WinForm.Control control2 = ooO_0O.o_O0.O_.(control);
					if (control2 != null)
					{
						control2.o.__O0O. = this._frm;
						this.lst.Add(control2);
					}
					if (control.Controls.Count > 0)
					{
						this.CreateList(control.Controls);
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
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x001BF334 File Offset: 0x001BD534
		public Foxtable.WinForm.Control get_Current()
		{
			return this.lst[this._Index];
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x001BF347 File Offset: 0x001BD547
		public object get_Current1()
		{
			return this.lst[this._Index];
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x001BF35C File Offset: 0x001BD55C
		public bool MoveNext()
		{
			this._Index++;
			return this._Index < this.lst.Count;
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x001BF391 File Offset: 0x001BD591
		public void Reset()
		{
			this._Index = -1;
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x001BF39A File Offset: 0x001BD59A
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x001BF3AD File Offset: 0x001BD5AD
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04001947 RID: 6471
		private Foxtable.WinForm.Form _frm;

		// Token: 0x04001948 RID: 6472
		private System.Windows.Forms.Control.ControlCollection _controls;

		// Token: 0x04001949 RID: 6473
		private List<Foxtable.WinForm.Control> lst;

		// Token: 0x0400194A RID: 6474
		private int _Index;

		// Token: 0x0400194B RID: 6475
		private bool disposedValue;
	}
}
