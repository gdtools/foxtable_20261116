using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using Foxtable.My;

namespace Foxtable
{
	// Token: 0x020004D0 RID: 1232
	[oO0oooo("1968")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MyPortCollections : Dictionary<string, Port>
	{
		// Token: 0x06005161 RID: 20833 RVA: 0x00244688 File Offset: 0x00242888
		public void Add(string PortName)
		{
			if (!base.ContainsKey(PortName))
			{
				Port port = new Port();
				port.PortName = PortName;
				port.ReadTimeout = 500;
				port.WriteTimeout = 500;
				port.DataReceived += this.O0_Oo0.0o_o0.;
				base.Add(PortName, port);
			}
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x002446DC File Offset: 0x002428DC
		public new void Remove(string PortName)
		{
			if (base.ContainsKey(PortName))
			{
				Port port = base[PortName];
				port.DataReceived -= this.O0_Oo0.0o_o0.;
				if (port.IsOpen)
				{
					port.Close();
				}
				base.Remove(PortName);
			}
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x00244724 File Offset: 0x00242924
		public new void Clear()
		{
			try
			{
				foreach (string key in base.Keys)
				{
					Port port = base[key];
					port.DataReceived -= this.O0_Oo0.0o_o0.;
					if (port.IsOpen)
					{
						port.Close();
					}
				}
			}
			finally
			{
				Dictionary<string, Port>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			base.Clear();
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x002447A0 File Offset: 0x002429A0
		public bool Contains(string PortName)
		{
			return base.ContainsKey(PortName);
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x002447AC File Offset: 0x002429AC
		private void <<EMPTY_NAME>>(object A_0, SerialDataReceivedEventArgs A_1)
		{
			MyPortCollections.ReceiveDataMethod method = new MyPortCollections.ReceiveDataMethod(this.oO_o.0_o0_.);
			if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				Main.OO_O.o..Invoke(method, new object[]
				{
					(Port)A_0
				});
			}
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x002447F4 File Offset: 0x002429F4
		private void <<EMPTY_NAME>>(Port A_0)
		{
			DataReceivedEventArgs dataReceivedEventArgs = new DataReceivedEventArgs(A_0);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "DataReceived", new object[]
			{
				dataReceivedEventArgs
			}, false, "串口监视器", false);
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x06005167 RID: 20839 RVA: 0x00244829 File Offset: 0x00242A29
		public List<string> PortNames
		{
			get
			{
				List<string> list = new List<string>();
				list.AddRange(c.OOOOO.o.().Ports.SerialPortNames);
				return list;
			}
		}

		// Token: 0x020004D2 RID: 1234
		// (Invoke) Token: 0x06005171 RID: 20849
		public delegate void ReceiveDataMethod(Port A_0);
	}
}
