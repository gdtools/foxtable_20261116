using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Text;

namespace Foxtable
{
	// Token: 0x020004D1 RID: 1233
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Port : SerialPort
	{
		// Token: 0x06005168 RID: 20840 RVA: 0x00244845 File Offset: 0x00242A45
		public Port()
		{
			this.Ooo0Oo_.ooO. = Encoding.Unicode;
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x00244858 File Offset: 0x00242A58
		public new void Open()
		{
			if (!base.IsOpen)
			{
				try
				{
					base.Open();
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x0600516A RID: 20842 RVA: 0x002448A0 File Offset: 0x00242AA0
		// (set) Token: 0x0600516B RID: 20843 RVA: 0x002448A8 File Offset: 0x00242AA8
		public new string PortName
		{
			get
			{
				return base.PortName;
			}
			internal set
			{
				base.PortName = value;
			}
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x002448B1 File Offset: 0x00242AB1
		public byte[] GetBytes(string val)
		{
			return Encoding.Unicode.GetBytes(val);
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x002448BE File Offset: 0x00242ABE
		public string GetString(byte[] val)
		{
			return Encoding.Unicode.GetString(val);
		}

		// Token: 0x04002173 RID: 8563
		private Encoding <<EMPTY_NAME>>;
	}
}
