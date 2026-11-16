using System;
using System.ComponentModel;
using JinDI_SmsComLib;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000265 RID: 613
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FoxSMSControl : SmsControlClass
	{
		// Token: 0x06001CFD RID: 7421 RVA: 0x000C6BB8 File Offset: 0x000C4DB8
		public FoxSMSControl()
		{
			base.ConnectModemResult += new _ISmsControlEvents_ConnectModemResultEventHandler(this, (UIntPtr)ldftn(oOo00O0._oO.));
			base.NewMessage += new _ISmsControlEvents_NewMessageEventHandler(this, (UIntPtr)ldftn(o0__o.O0.));
			base.ReceivedCall += new _ISmsControlEvents_ReceivedCallEventHandler(this, (UIntPtr)ldftn(o0__o.O0.));
			base.SentMsgStatus += new _ISmsControlEvents_SentMsgStatusEventHandler(this, (UIntPtr)ldftn(o0__o.O0.));
			base.SimCardNoMemory += new _ISmsControlEvents_SimCardNoMemoryEventHandler(this, (UIntPtr)ldftn(o__0oo.___o_.));
			base.SimCardNoMoney += new _ISmsControlEvents_SimCardNoMoneyEventHandler(this, (UIntPtr)ldftn(oOo00O0._oO.));
			this.AutoDelMsg = true;
			this.Settings = 0;
			this.CountryCode = "86";
			this.SyncWorkMode = false;
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x000C6C57 File Offset: 0x000C4E57
		public bool Ready
		{
			get
			{
				return !base.IsOpen;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x000C6C62 File Offset: 0x000C4E62
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x000C6C6A File Offset: 0x000C4E6A
		public int BaudRate
		{
			get
			{
				return base.Settings;
			}
			set
			{
				base.Settings = value;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x000C6C74 File Offset: 0x000C4E74
		public int SimMsgCount
		{
			get
			{
				short result = 0;
				OO_00oOO.FoxSMS.GetSimNum(out result);
				return (int)result;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x000C6C94 File Offset: 0x000C4E94
		public int SimMsgcapacity
		{
			get
			{
				short num = 0;
				return (int)OO_00oOO.FoxSMS.GetSimNum(out num);
			}
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000C6CB0 File Offset: 0x000C4EB0
		private void <<EMPTY_NAME>>(bool A_0)
		{
			ConnectModemResultEventArgs connectModemResultEventArgs = new ConnectModemResultEventArgs(A_0);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "ConnectModemResult", new object[]
			{
				connectModemResultEventArgs
			}, false, "项目", false);
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000C6CE8 File Offset: 0x000C4EE8
		private void <<EMPTY_NAME>>(short A_0, short A_1, string A_2, string A_3, DateTime A_4)
		{
			NewMessageEventArgs newMessageEventArgs = new NewMessageEventArgs(A_0, A_1, A_2, A_3, A_4);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "NewMessage", new object[]
			{
				newMessageEventArgs
			}, false, "项目", false);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x000C6D24 File Offset: 0x000C4F24
		private void <<EMPTY_NAME>>(string A_0)
		{
			if (Operators.CompareString(this.oOo00O0._oO., A_0, true) == 0 && (DateTime.Now - this.oOo00O0._oO.).TotalSeconds < 4.0)
			{
				this.oOo00O0._oO. = A_0;
				this.oOo00O0._oO. = DateTime.Now;
				return;
			}
			this.oOo00O0._oO. = A_0;
			this.oOo00O0._oO. = DateTime.Now;
			ReceivedCallEventArgs receivedCallEventArgs = new ReceivedCallEventArgs(A_0);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "ReceivedCall", new object[]
			{
				receivedCallEventArgs
			}, false, "项目", false);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000C6DB0 File Offset: 0x000C4FB0
		private void <<EMPTY_NAME>>(uint A_0, string A_1, string A_2, short A_3, bool A_4)
		{
			SentMsgStatusEventArgs sentMsgStatusEventArgs = new SentMsgStatusEventArgs(A_0, A_1, A_2, A_3, A_4);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "SentMsgStatus", new object[]
			{
				sentMsgStatusEventArgs
			}, false, "项目", false);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x000C6DEB File Offset: 0x000C4FEB
		private void <<EMPTY_NAME>>()
		{
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "SimCardNoMemory", null, false, "项目", false);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x000C6E05 File Offset: 0x000C5005
		private void <<EMPTY_NAME>>()
		{
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "SimCardNoMoney", null, false, "项目", false);
		}

		// Token: 0x04000C57 RID: 3159
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C58 RID: 3160
		private DateTime <<EMPTY_NAME>>;
	}
}
