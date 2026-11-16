using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000313 RID: 787
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o0o_Oo_o : IEnumerator<Relation>
	{
		// Token: 0x06002A74 RID: 10868 RVA: 0x0012DA93 File Offset: 0x0012BC93
		public o0o_Oo_o()
		{
			this.index = -1;
			this.disposedValue = false;
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x0012DAA9 File Offset: 0x0012BCA9
		public Relation get_Current()
		{
			return new Relation(O_O0OO.OOOo.oo_OOOO_0.().Relations[this.index]);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x0012DAC5 File Offset: 0x0012BCC5
		public object get_Current1()
		{
			return new Relation(O_O0OO.OOOo.oo_OOOO_0.().Relations[this.index]);
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x0012DAE1 File Offset: 0x0012BCE1
		public bool MoveNext()
		{
			this.index++;
			return O_O0OO.OOOo.oo_OOOO_0.().Relations.Count > this.index;
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x0012DB08 File Offset: 0x0012BD08
		public void Reset()
		{
			this.index = -1;
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x0012DB11 File Offset: 0x0012BD11
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x0012DB24 File Offset: 0x0012BD24
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0400118A RID: 4490
		private int index;

		// Token: 0x0400118B RID: 4491
		private bool disposedValue;
	}
}
