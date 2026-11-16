using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// FTP客户端
	/// </summary>
	// Token: 0x020002DB RID: 731
	[oO0oooo("1410")]
	[ComVisible(true)]
	public class FTPClient
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06002834 RID: 10292 RVA: 0x00122D44 File Offset: 0x00120F44
		// (remove) Token: 0x06002835 RID: 10293 RVA: 0x00122D7C File Offset: 0x00120F7C
		internal event FTPClient.o0O_O00o_0_o DownloadProgressChanged
		{
			[CompilerGenerated]
			add
			{
				FTPClient.o0O_O00o_0_o o0O_O00o_0_o = this.Ooo_Oo_O0.00O.;
				FTPClient.o0O_O00o_0_o o0O_O00o_0_o2;
				do
				{
					o0O_O00o_0_o2 = o0O_O00o_0_o;
					FTPClient.o0O_O00o_0_o value2 = (FTPClient.o0O_O00o_0_o)Delegate.Combine(o0O_O00o_0_o2, value);
					o0O_O00o_0_o = Interlocked.CompareExchange<FTPClient.o0O_O00o_0_o>(ref this.Ooo_Oo_O0.00O., value2, o0O_O00o_0_o2);
				}
				while (o0O_O00o_0_o != o0O_O00o_0_o2);
			}
			[CompilerGenerated]
			remove
			{
				FTPClient.o0O_O00o_0_o o0O_O00o_0_o = this.Ooo_Oo_O0.00O.;
				FTPClient.o0O_O00o_0_o o0O_O00o_0_o2;
				do
				{
					o0O_O00o_0_o2 = o0O_O00o_0_o;
					FTPClient.o0O_O00o_0_o value2 = (FTPClient.o0O_O00o_0_o)Delegate.Remove(o0O_O00o_0_o2, value);
					o0O_O00o_0_o = Interlocked.CompareExchange<FTPClient.o0O_O00o_0_o>(ref this.Ooo_Oo_O0.00O., value2, o0O_O00o_0_o2);
				}
				while (o0O_O00o_0_o != o0O_O00o_0_o2);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06002836 RID: 10294 RVA: 0x00122DB4 File Offset: 0x00120FB4
		// (remove) Token: 0x06002837 RID: 10295 RVA: 0x00122DEC File Offset: 0x00120FEC
		internal event FTPClient.oO_o_0OOo__0 DownloadCompleted
		{
			[CompilerGenerated]
			add
			{
				FTPClient.oO_o_0OOo__0 oO_o_0OOo__ = this.Ooo_Oo_O0.00O.;
				FTPClient.oO_o_0OOo__0 oO_o_0OOo__2;
				do
				{
					oO_o_0OOo__2 = oO_o_0OOo__;
					FTPClient.oO_o_0OOo__0 value2 = (FTPClient.oO_o_0OOo__0)Delegate.Combine(oO_o_0OOo__2, value);
					oO_o_0OOo__ = Interlocked.CompareExchange<FTPClient.oO_o_0OOo__0>(ref this.Ooo_Oo_O0.00O., value2, oO_o_0OOo__2);
				}
				while (oO_o_0OOo__ != oO_o_0OOo__2);
			}
			[CompilerGenerated]
			remove
			{
				FTPClient.oO_o_0OOo__0 oO_o_0OOo__ = this.Ooo_Oo_O0.00O.;
				FTPClient.oO_o_0OOo__0 oO_o_0OOo__2;
				do
				{
					oO_o_0OOo__2 = oO_o_0OOo__;
					FTPClient.oO_o_0OOo__0 value2 = (FTPClient.oO_o_0OOo__0)Delegate.Remove(oO_o_0OOo__2, value);
					oO_o_0OOo__ = Interlocked.CompareExchange<FTPClient.oO_o_0OOo__0>(ref this.Ooo_Oo_O0.00O., value2, oO_o_0OOo__2);
				}
				while (oO_o_0OOo__ != oO_o_0OOo__2);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06002838 RID: 10296 RVA: 0x00122E24 File Offset: 0x00121024
		// (remove) Token: 0x06002839 RID: 10297 RVA: 0x00122E5C File Offset: 0x0012105C
		internal event FTPClient.O__0O000__Oo DownloadError
		{
			[CompilerGenerated]
			add
			{
				FTPClient.O__0O000__Oo o__0O000__Oo = this.Ooo_Oo_O0.00O.;
				FTPClient.O__0O000__Oo o__0O000__Oo2;
				do
				{
					o__0O000__Oo2 = o__0O000__Oo;
					FTPClient.O__0O000__Oo value2 = (FTPClient.O__0O000__Oo)Delegate.Combine(o__0O000__Oo2, value);
					o__0O000__Oo = Interlocked.CompareExchange<FTPClient.O__0O000__Oo>(ref this.Ooo_Oo_O0.00O., value2, o__0O000__Oo2);
				}
				while (o__0O000__Oo != o__0O000__Oo2);
			}
			[CompilerGenerated]
			remove
			{
				FTPClient.O__0O000__Oo o__0O000__Oo = this.Ooo_Oo_O0.00O.;
				FTPClient.O__0O000__Oo o__0O000__Oo2;
				do
				{
					o__0O000__Oo2 = o__0O000__Oo;
					FTPClient.O__0O000__Oo value2 = (FTPClient.O__0O000__Oo)Delegate.Remove(o__0O000__Oo2, value);
					o__0O000__Oo = Interlocked.CompareExchange<FTPClient.O__0O000__Oo>(ref this.Ooo_Oo_O0.00O., value2, o__0O000__Oo2);
				}
				while (o__0O000__Oo != o__0O000__Oo2);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600283A RID: 10298 RVA: 0x00122E94 File Offset: 0x00121094
		// (remove) Token: 0x0600283B RID: 10299 RVA: 0x00122ECC File Offset: 0x001210CC
		internal event FTPClient.o0_O_0_0 UploadProgressChanged
		{
			[CompilerGenerated]
			add
			{
				FTPClient.o0_O_0_0 o0_O_0_ = this.O0OO._0OO.;
				FTPClient.o0_O_0_0 o0_O_0_2;
				do
				{
					o0_O_0_2 = o0_O_0_;
					FTPClient.o0_O_0_0 value2 = (FTPClient.o0_O_0_0)Delegate.Combine(o0_O_0_2, value);
					o0_O_0_ = Interlocked.CompareExchange<FTPClient.o0_O_0_0>(ref this.O0OO._0OO., value2, o0_O_0_2);
				}
				while (o0_O_0_ != o0_O_0_2);
			}
			[CompilerGenerated]
			remove
			{
				FTPClient.o0_O_0_0 o0_O_0_ = this.O0OO._0OO.;
				FTPClient.o0_O_0_0 o0_O_0_2;
				do
				{
					o0_O_0_2 = o0_O_0_;
					FTPClient.o0_O_0_0 value2 = (FTPClient.o0_O_0_0)Delegate.Remove(o0_O_0_2, value);
					o0_O_0_ = Interlocked.CompareExchange<FTPClient.o0_O_0_0>(ref this.O0OO._0OO., value2, o0_O_0_2);
				}
				while (o0_O_0_ != o0_O_0_2);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600283C RID: 10300 RVA: 0x00122F04 File Offset: 0x00121104
		// (remove) Token: 0x0600283D RID: 10301 RVA: 0x00122F3C File Offset: 0x0012113C
		internal event FTPClient.oO___ UploadCompleted
		{
			[CompilerGenerated]
			add
			{
				FTPClient.oO___ oO___ = this.O0OO._0OO.;
				FTPClient.oO___ oO___2;
				do
				{
					oO___2 = oO___;
					FTPClient.oO___ value2 = (FTPClient.oO___)Delegate.Combine(oO___2, value);
					oO___ = Interlocked.CompareExchange<FTPClient.oO___>(ref this.O0OO._0OO., value2, oO___2);
				}
				while (oO___ != oO___2);
			}
			[CompilerGenerated]
			remove
			{
				FTPClient.oO___ oO___ = this.O0OO._0OO.;
				FTPClient.oO___ oO___2;
				do
				{
					oO___2 = oO___;
					FTPClient.oO___ value2 = (FTPClient.oO___)Delegate.Remove(oO___2, value);
					oO___ = Interlocked.CompareExchange<FTPClient.oO___>(ref this.O0OO._0OO., value2, oO___2);
				}
				while (oO___ != oO___2);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600283E RID: 10302 RVA: 0x00122F74 File Offset: 0x00121174
		// (remove) Token: 0x0600283F RID: 10303 RVA: 0x00122FAC File Offset: 0x001211AC
		internal event FTPClient.ooo__O UploadError
		{
			[CompilerGenerated]
			add
			{
				FTPClient.ooo__O ooo__O = this.O0OO._0OO.;
				FTPClient.ooo__O ooo__O2;
				do
				{
					ooo__O2 = ooo__O;
					FTPClient.ooo__O value2 = (FTPClient.ooo__O)Delegate.Combine(ooo__O2, value);
					ooo__O = Interlocked.CompareExchange<FTPClient.ooo__O>(ref this.O0OO._0OO., value2, ooo__O2);
				}
				while (ooo__O != ooo__O2);
			}
			[CompilerGenerated]
			remove
			{
				FTPClient.ooo__O ooo__O = this.O0OO._0OO.;
				FTPClient.ooo__O ooo__O2;
				do
				{
					ooo__O2 = ooo__O;
					FTPClient.ooo__O value2 = (FTPClient.ooo__O)Delegate.Remove(ooo__O2, value);
					ooo__O = Interlocked.CompareExchange<FTPClient.ooo__O>(ref this.O0OO._0OO., value2, ooo__O2);
				}
				while (ooo__O != ooo__O2);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06002840 RID: 10304 RVA: 0x00122FE4 File Offset: 0x001211E4
		// (remove) Token: 0x06002841 RID: 10305 RVA: 0x0012301C File Offset: 0x0012121C
		internal event FTPClient.OooO_O0O_0_O ServerConnected
		{
			[CompilerGenerated]
			add
			{
				FTPClient.OooO_O0O_0_O oooO_O0O_0_O = this.o_O.o_Oo0O_o0O.;
				FTPClient.OooO_O0O_0_O oooO_O0O_0_O2;
				do
				{
					oooO_O0O_0_O2 = oooO_O0O_0_O;
					FTPClient.OooO_O0O_0_O value2 = (FTPClient.OooO_O0O_0_O)Delegate.Combine(oooO_O0O_0_O2, value);
					oooO_O0O_0_O = Interlocked.CompareExchange<FTPClient.OooO_O0O_0_O>(ref this.o_O.o_Oo0O_o0O., value2, oooO_O0O_0_O2);
				}
				while (oooO_O0O_0_O != oooO_O0O_0_O2);
			}
			[CompilerGenerated]
			remove
			{
				FTPClient.OooO_O0O_0_O oooO_O0O_0_O = this.o_O.o_Oo0O_o0O.;
				FTPClient.OooO_O0O_0_O oooO_O0O_0_O2;
				do
				{
					oooO_O0O_0_O2 = oooO_O0O_0_O;
					FTPClient.OooO_O0O_0_O value2 = (FTPClient.OooO_O0O_0_O)Delegate.Remove(oooO_O0O_0_O2, value);
					oooO_O0O_0_O = Interlocked.CompareExchange<FTPClient.OooO_O0O_0_O>(ref this.o_O.o_Oo0O_o0O., value2, oooO_O0O_0_O2);
				}
				while (oooO_O0O_0_O != oooO_O0O_0_O2);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06002842 RID: 10306 RVA: 0x00123054 File Offset: 0x00121254
		// (remove) Token: 0x06002843 RID: 10307 RVA: 0x0012308C File Offset: 0x0012128C
		internal event FTPClient.OOOOO00OoOOo ShowMessage
		{
			[CompilerGenerated]
			add
			{
				FTPClient.OOOOO00OoOOo ooooo00OoOOo = this.O0OO._0OO.;
				FTPClient.OOOOO00OoOOo ooooo00OoOOo2;
				do
				{
					ooooo00OoOOo2 = ooooo00OoOOo;
					FTPClient.OOOOO00OoOOo value2 = (FTPClient.OOOOO00OoOOo)Delegate.Combine(ooooo00OoOOo2, value);
					ooooo00OoOOo = Interlocked.CompareExchange<FTPClient.OOOOO00OoOOo>(ref this.O0OO._0OO., value2, ooooo00OoOOo2);
				}
				while (ooooo00OoOOo != ooooo00OoOOo2);
			}
			[CompilerGenerated]
			remove
			{
				FTPClient.OOOOO00OoOOo ooooo00OoOOo = this.O0OO._0OO.;
				FTPClient.OOOOO00OoOOo ooooo00OoOOo2;
				do
				{
					ooooo00OoOOo2 = ooooo00OoOOo;
					FTPClient.OOOOO00OoOOo value2 = (FTPClient.OOOOO00OoOOo)Delegate.Remove(ooooo00OoOOo2, value);
					ooooo00OoOOo = Interlocked.CompareExchange<FTPClient.OOOOO00OoOOo>(ref this.O0OO._0OO., value2, ooooo00OoOOo2);
				}
				while (ooooo00OoOOo != ooooo00OoOOo2);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06002844 RID: 10308 RVA: 0x001230C4 File Offset: 0x001212C4
		// (remove) Token: 0x06002845 RID: 10309 RVA: 0x001230FC File Offset: 0x001212FC
		internal event FTPClient.OoO_00_o ShowError
		{
			[CompilerGenerated]
			add
			{
				FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
				FTPClient.OoO_00_o ooO_00_o2;
				do
				{
					ooO_00_o2 = ooO_00_o;
					FTPClient.OoO_00_o value2 = (FTPClient.OoO_00_o)Delegate.Combine(ooO_00_o2, value);
					ooO_00_o = Interlocked.CompareExchange<FTPClient.OoO_00_o>(ref this.o_O.o_Oo0O_o0O., value2, ooO_00_o2);
				}
				while (ooO_00_o != ooO_00_o2);
			}
			[CompilerGenerated]
			remove
			{
				FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
				FTPClient.OoO_00_o ooO_00_o2;
				do
				{
					ooO_00_o2 = ooO_00_o;
					FTPClient.OoO_00_o value2 = (FTPClient.OoO_00_o)Delegate.Remove(ooO_00_o2, value);
					ooO_00_o = Interlocked.CompareExchange<FTPClient.OoO_00_o>(ref this.o_O.o_Oo0O_o0O., value2, ooO_00_o2);
				}
				while (ooO_00_o != ooO_00_o2);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06002846 RID: 10310 RVA: 0x00123134 File Offset: 0x00121334
		// (remove) Token: 0x06002847 RID: 10311 RVA: 0x0012316C File Offset: 0x0012136C
		internal event FTPClient.Oo__ FileCompared
		{
			[CompilerGenerated]
			add
			{
				FTPClient.Oo__ oo__ = this.o_O.o_Oo0O_o0O.;
				FTPClient.Oo__ oo__2;
				do
				{
					oo__2 = oo__;
					FTPClient.Oo__ value2 = (FTPClient.Oo__)Delegate.Combine(oo__2, value);
					oo__ = Interlocked.CompareExchange<FTPClient.Oo__>(ref this.o_O.o_Oo0O_o0O., value2, oo__2);
				}
				while (oo__ != oo__2);
			}
			[CompilerGenerated]
			remove
			{
				FTPClient.Oo__ oo__ = this.o_O.o_Oo0O_o0O.;
				FTPClient.Oo__ oo__2;
				do
				{
					oo__2 = oo__;
					FTPClient.Oo__ value2 = (FTPClient.Oo__)Delegate.Remove(oo__2, value);
					oo__ = Interlocked.CompareExchange<FTPClient.Oo__>(ref this.o_O.o_Oo0O_o0O., value2, oo__2);
				}
				while (oo__ != oo__2);
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x001231A1 File Offset: 0x001213A1
		// (set) Token: 0x06002849 RID: 10313 RVA: 0x001231AC File Offset: 0x001213AC
		private virtual System.Timers.Timer Timer
		{
			[CompilerGenerated]
			get
			{
				return this.O_O.O0oO.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ElapsedEventHandler value2 = new ElapsedEventHandler(this.o0O_0_.00_oooo.);
				System.Timers.Timer o_O.O0oO. = this.O_O.O0oO.;
				if (o_O.O0oO. != null)
				{
					o_O.O0oO..Elapsed -= value2;
				}
				this.O_O.O0oO. = value;
				o_O.O0oO. = this.O_O.O0oO.;
				if (o_O.O0oO. != null)
				{
					o_O.O0oO..Elapsed += value2;
				}
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x001231EF File Offset: 0x001213EF
		// (set) Token: 0x0600284B RID: 10315 RVA: 0x001231F8 File Offset: 0x001213F8
		private virtual Form MainForm
		{
			[CompilerGenerated]
			get
			{
				return this.o_O_.00_00.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				FormClosedEventHandler value2 = new FormClosedEventHandler(this.oo0000O.Oo0OO.);
				Form form = this.o_O_.00_00.;
				if (form != null)
				{
					form.FormClosed -= value2;
				}
				this.o_O_.00_00. = value;
				form = this.o_O_.00_00.;
				if (form != null)
				{
					form.FormClosed += value2;
				}
			}
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x0012323C File Offset: 0x0012143C
		public FTPClient()
		{
			this.Ooo_Oo_O0.00O. = 512;
			this.OO0O00_0_._0. = 51200;
			this.o__0.0. = 21;
			this.o.oo000oOoo. = 0;
			this.oOo0_Oo.O_. = 0;
			this.oOo.O00O__oO_. = false;
			this.OOO00.ooo0. = false;
			this.Ooo_Oo_O0.00O. = new byte[this.Ooo_Oo_O0.00O. + 1];
			this.OO0O00_0_._0. = new byte[this.OO0O00_0_._0. + 1];
			this.Ooo_Oo_O0.00O. = null;
			this.oO0_O._. = 20;
			this.o0O0.oo0O0. = true;
			this.ooo_.O0___oO00. = true;
			this.o_.O0. = true;
			this.oOO0oOOO.0_o0o. = true;
			this.o_.0OOOo_O00o. = true;
			this.o_00_o.OoO. = true;
			this.Timer = new System.Timers.Timer();
			this.O_OO.OOO_OOO. = true;
			this.Ooo_Oo_O0.00O. = new Dictionary<string, List<string>>();
			this.Ooo_Oo_O0.00O. = new List<string>();
			this.O0.o0. = false;
			this.Timer.Interval = 1000.0;
			this.Timer.Enabled = false;
			this.MainForm = OO_00oOO.BaseMainForm;
			this.o_O_.00_00. = Encoding.GetEncoding("gb2312");
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00123352 File Offset: 0x00121552
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FTPClient(string A_0, string A_1, string A_2, Encoding A_3 = null) : this()
		{
			this.O_O.O0oO. = A_0;
			this.o__0.0. = A_1;
			this.Oo_.00. = A_2;
			if (A_3 == null)
			{
				this.o_O_.00_00. = Encoding.GetEncoding("gb2312");
				return;
			}
			this.o_O_.00_00. = A_3;
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x0012338C File Offset: 0x0012158C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FTPClient(string A_0, string A_1, string A_2, int A_3, int A_4, Encoding A_5 = null) : this()
		{
			this.O_O.O0oO. = A_0;
			this.o__0.0. = A_1;
			this.Oo_.00. = A_2;
			this.oO0_O._. = A_3;
			this.o__0.0. = A_4;
			if (A_5 == null)
			{
				this.o_O_.00_00. = Encoding.GetEncoding("gb2312");
				return;
			}
			this.o_O_.00_00. = A_5;
		}

		/// <summary>
		/// 逻辑型，判断FTP是否已经连接成功
		/// </summary>
		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x001233E1 File Offset: 0x001215E1
		// (set) Token: 0x06002850 RID: 10320 RVA: 0x001233EC File Offset: 0x001215EC
		public bool Connected
		{
			get
			{
				return this.oOo.O00O__oO_.;
			}
			internal set
			{
				lock (this)
				{
					if (this.oOo.O00O__oO_. != value)
					{
						this.oOo.O00O__oO_. = value;
						this.Timer.Enabled = value;
						if (!value && this.AsyncState != Oo_0.OOoo0_OO__._o. && this.Ooo_Oo_O0.00O. != null && this.Ooo_Oo_O0.00O..IsAlive)
						{
							this.Ooo_Oo_O0.00O..Abort();
						}
					}
				}
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x00123468 File Offset: 0x00121668
		// (set) Token: 0x06002852 RID: 10322 RVA: 0x00123496 File Offset: 0x00121696
		internal Oo_0 AsyncState
		{
			get
			{
				Oo_0 result;
				if (this.Ooo_Oo_O0.00O. != null && this.Ooo_Oo_O0.00O..IsAlive)
				{
					result = Oo_0.Oo_o_o.__oo.;
				}
				else
				{
					result = this.oOo.O00O__oO_.;
				}
				return result;
			}
			set
			{
				this.oOo.O00O__oO_. = value;
			}
		}

		/// <summary>
		/// 整数型，默认为21，用于指定FTP端口号
		/// </summary>
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x0012349F File Offset: 0x0012169F
		// (set) Token: 0x06002854 RID: 10324 RVA: 0x001234A7 File Offset: 0x001216A7
		public int Port
		{
			get
			{
				return this.o__0.0.;
			}
			set
			{
				this.o__0.0. = value;
			}
		}

		/// <summary>
		/// 整数型，用于设置尝试操作的毫秒数，默认为10000，也就是10秒
		/// </summary>
		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x001234B0 File Offset: 0x001216B0
		// (set) Token: 0x06002856 RID: 10326 RVA: 0x001234B8 File Offset: 0x001216B8
		public int Timeout
		{
			get
			{
				return this.oO0_O._.;
			}
			set
			{
				this.oO0_O._. = value;
			}
		}

		/// <summary>
		/// 返回或设置FTP服务器地址，可以是域名或IP地址
		/// </summary>
		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x001234C1 File Offset: 0x001216C1
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x001234C9 File Offset: 0x001216C9
		public string Host
		{
			get
			{
				return this.O_O.O0oO.;
			}
			set
			{
				this.O_O.O0oO. = value;
			}
		}

		/// <summary>
		/// 返回或设置登录用户名
		/// </summary>
		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x001234D2 File Offset: 0x001216D2
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x001234DA File Offset: 0x001216DA
		public string Account
		{
			get
			{
				return this.o__0.0.;
			}
			set
			{
				this.o__0.0. = value;
			}
		}

		/// <summary>
		/// 返回或设置登录密码
		/// </summary>
		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x001234E3 File Offset: 0x001216E3
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x001234EB File Offset: 0x001216EB
		public string Password
		{
			get
			{
				return this.Oo_.00.;
			}
			set
			{
				this.Oo_.00. = value;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x001234F4 File Offset: 0x001216F4
		// (set) Token: 0x0600285E RID: 10334 RVA: 0x001234FC File Offset: 0x001216FC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool BinaryMode
		{
			get
			{
				return this.OOO00.ooo0.;
			}
			set
			{
				if (this.OOO00.ooo0. != value)
				{
					if (value)
					{
						this.o0O_0_.00_oooo.("TYPE I");
					}
					else
					{
						this.o0O_0_.00_oooo.("TYPE A");
					}
					if (this.oOo0_Oo.O_. != 200)
					{
						FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
						if (ooO_00_o != null)
						{
							ooO_00_o("二进制模式设置失败", this.o.0OoOooo__.);
						}
					}
				}
			}
		}

		/// <summary>
		/// 逻辑型，是否使用UTF8编码
		/// </summary>
		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x00123555 File Offset: 0x00121755
		// (set) Token: 0x06002860 RID: 10336 RVA: 0x00123564 File Offset: 0x00121764
		public bool UTF8
		{
			get
			{
				return this.o_O_.00_00. == Encoding.UTF8;
			}
			set
			{
				if (value)
				{
					this.o_O_.00_00. = Encoding.UTF8;
					return;
				}
				this.o_O_.00_00. = Encoding.GetEncoding("gb2312");
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x00123585 File Offset: 0x00121785
		// (set) Token: 0x06002862 RID: 10338 RVA: 0x0012358D File Offset: 0x0012178D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int BufferSize
		{
			get
			{
				return this.Ooo_Oo_O0.00O.;
			}
			set
			{
				if (value < 512)
				{
					value = 512;
				}
				this.Ooo_Oo_O0.00O. = value;
				this.Ooo_Oo_O0.00O. = new byte[this.Ooo_Oo_O0.00O. + 1];
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x001235B8 File Offset: 0x001217B8
		// (set) Token: 0x06002864 RID: 10340 RVA: 0x001235C0 File Offset: 0x001217C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int UploadBufferSize
		{
			get
			{
				return this.OO0O00_0_._0.;
			}
			set
			{
				if (value < 512)
				{
					value = 512;
				}
				this.OO0O00_0_._0. = value;
				this.OO0O00_0_._0. = new byte[this.OO0O00_0_._0. + 1];
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x001235EB File Offset: 0x001217EB
		// (set) Token: 0x06002866 RID: 10342 RVA: 0x001235F3 File Offset: 0x001217F3
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShowUI
		{
			get
			{
				return this.Oo_.00.;
			}
			set
			{
				this.Oo_.00. = value;
			}
		}

		/// <summary>
		/// 返回或设置根目录
		/// </summary>
		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x001235FC File Offset: 0x001217FC
		// (set) Token: 0x06002868 RID: 10344 RVA: 0x00123604 File Offset: 0x00121804
		public string RootDir
		{
			get
			{
				return this.O_O._oO_O_0oOo.;
			}
			set
			{
				if (Operators.CompareString(value, "", true) > 0)
				{
					value = "/" + value.Trim(new char[]
					{
						'/'
					}).Trim(new char[]
					{
						'\\'
					}) + "/";
					value = value.Replace("\\", "/");
				}
				this.O_O._oO_O_0oOo. = value;
				if (this.Connected)
				{
					this.ChangeDir(value);
				}
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x0012367A File Offset: 0x0012187A
		// (set) Token: 0x0600286A RID: 10346 RVA: 0x00123682 File Offset: 0x00121882
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string LocalDir
		{
			get
			{
				return this.o_00_o.OoO.;
			}
			set
			{
				this.o_00_o.OoO. = value;
			}
		}

		/// <summary>
		/// 逻辑型，用于决定Ftp管理器中的上传按钮是否可用
		/// </summary>
		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x0012368B File Offset: 0x0012188B
		// (set) Token: 0x0600286C RID: 10348 RVA: 0x00123693 File Offset: 0x00121893
		public bool UploadEnabled
		{
			get
			{
				return this.o0O0.oo0O0.;
			}
			set
			{
				this.o0O0.oo0O0. = value;
			}
		}

		/// <summary>
		/// 逻辑型，用于决定Ftp管理器中的下载按钮是否可用
		/// </summary>
		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x0012369C File Offset: 0x0012189C
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x001236A4 File Offset: 0x001218A4
		public bool DownloadEnabled
		{
			get
			{
				return this.ooo_.O0___oO00.;
			}
			set
			{
				this.ooo_.O0___oO00. = value;
			}
		}

		/// <summary>
		/// 逻辑型，用于决定Ftp管理器中的重命名按钮是否可用
		/// </summary>
		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x001236AD File Offset: 0x001218AD
		// (set) Token: 0x06002870 RID: 10352 RVA: 0x001236B5 File Offset: 0x001218B5
		public bool RenameEnabled
		{
			get
			{
				return this.o_.O0.;
			}
			set
			{
				this.o_.O0. = value;
			}
		}

		/// <summary>
		/// 逻辑型，用于决定Ftp管理器中的删除按钮是否可用
		/// </summary>
		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x001236BE File Offset: 0x001218BE
		// (set) Token: 0x06002872 RID: 10354 RVA: 0x001236C6 File Offset: 0x001218C6
		public bool DeleteEnabled
		{
			get
			{
				return this.oOO0oOOO.0_o0o.;
			}
			set
			{
				this.oOO0oOOO.0_o0o. = value;
			}
		}

		/// <summary>
		/// 逻辑型，用于决定Ftp管理器中的新建文件夹按钮是否可用
		/// </summary>
		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x001236CF File Offset: 0x001218CF
		// (set) Token: 0x06002874 RID: 10356 RVA: 0x001236D7 File Offset: 0x001218D7
		public bool MakerDirEnabled
		{
			get
			{
				return this.o_.0OOOo_O00o.;
			}
			set
			{
				this.o_.0OOOo_O00o. = value;
			}
		}

		/// <summary>
		/// 逻辑型，用于决定Ftp管理器中的打开文件按钮是否可用
		/// </summary>
		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06002875 RID: 10357 RVA: 0x001236E0 File Offset: 0x001218E0
		// (set) Token: 0x06002876 RID: 10358 RVA: 0x001236E8 File Offset: 0x001218E8
		public bool OpenFileEnabled
		{
			get
			{
				return this.o_00_o.OoO.;
			}
			set
			{
				this.o_00_o.OoO. = value;
			}
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x001236F4 File Offset: 0x001218F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void OpenManager(params object[] args)
		{
			k2 k;
			if (args.Length == 0)
			{
				k = new k2(this, this.RootDir);
			}
			else
			{
				if (args.Length != 1)
				{
					return;
				}
				k = new k2(this, Conversions.ToString(args[0]));
			}
			k.Owner = OO_00oOO.BaseMainForm;
			k.Show();
		}

		/// <summary>
		/// 打开FTP管理器
		/// </summary>
		// Token: 0x06002878 RID: 10360 RVA: 0x0012373B File Offset: 0x0012193B
		public void OpenManager()
		{
			new k2(this, this.RootDir).ShowDialog();
		}

		/// <summary>
		/// 打开FTP管理器
		/// </summary>
		/// <param name="Curdir">指定一个目录，管理器打开后会自动定位到这个目录</param>
		// Token: 0x06002879 RID: 10361 RVA: 0x0012374F File Offset: 0x0012194F
		public void OpenManager(string Curdir)
		{
			new k2(this, Curdir).ShowDialog();
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x00123760 File Offset: 0x00121960
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object <<EMPTY_NAME>>(params string[] A_0)
		{
			List<string> list = new List<string>();
			if (A_0.Length == 0)
			{
				list = this.SelectFile();
			}
			else if (A_0.Length == 1)
			{
				list = this.SelectFile(A_0[0]);
			}
			object result;
			if (ooO.o.O_0000_O.())
			{
				result = list.ToArray();
			}
			else
			{
				result = list;
			}
			return result;
		}

		/// <summary>
		/// 打开一个对话框，用于从ftp上选择文件，返回一个字符串集合，返回选择的一个或多个文件
		/// </summary>
		// Token: 0x0600287B RID: 10363 RVA: 0x001237A4 File Offset: 0x001219A4
		public List<string> SelectFile()
		{
			lz lz = new lz(this, "");
			List<string> result;
			if (lz.ShowDialog() == DialogResult.OK)
			{
				result = lz.OOOOo.o000.;
			}
			else
			{
				result = new List<string>();
			}
			return result;
		}

		/// <summary>
		/// 打开一个对话框，用于从ftp上选择文件，返回一个字符串集合，返回选择的一个或多个文件
		/// </summary>
		/// <param name="Curdir">指定一个目录，对话框打开后会自动定位到这个目录</param>
		// Token: 0x0600287C RID: 10364 RVA: 0x001237D8 File Offset: 0x001219D8
		public List<string> SelectFile(string Curdir)
		{
			lz lz = new lz(this, Curdir);
			List<string> result;
			if (lz.ShowDialog() == DialogResult.OK)
			{
				result = lz.OOOOo.o000.;
			}
			else
			{
				result = new List<string>();
			}
			return result;
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x00123808 File Offset: 0x00121A08
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string <<EMPTY_NAME>>(params string[] A_0)
		{
			string result;
			if (A_0.Length == 0)
			{
				result = this.SelectFolder();
			}
			else if (A_0.Length == 1)
			{
				result = this.SelectFolder(A_0[0]);
			}
			return result;
		}

		/// <summary>
		/// 打开一个对话框，用于从ftp上选择一个目录，返回选择的目录
		/// </summary>
		// Token: 0x0600287E RID: 10366 RVA: 0x00123834 File Offset: 0x00121A34
		public string SelectFolder()
		{
			d0 d = new d0(this, "");
			string result;
			if (d.ShowDialog() == DialogResult.OK)
			{
				result = d.O0OO.o00O00o.;
			}
			else
			{
				result = "";
			}
			return result;
		}

		/// <summary>
		/// 打开一个对话框，用于从ftp上选择一个目录，返回选择的目录
		/// </summary>
		/// <param name="Curdir">指定一个目录，对话框打开后会自动定位到这个目录</param>
		// Token: 0x0600287F RID: 10367 RVA: 0x00123868 File Offset: 0x00121A68
		public string SelectFolder(string Curdir)
		{
			d0 d = new d0(this, Curdir);
			string result;
			if (d.ShowDialog() == DialogResult.OK)
			{
				result = d.O0OO.o00O00o.;
			}
			else
			{
				result = "";
			}
			return result;
		}

		/// <summary>
		/// 连接FTP，如果连接成功，返回True，否则返回False。
		/// </summary>
		// Token: 0x06002880 RID: 10368 RVA: 0x00123898 File Offset: 0x00121A98
		public bool Connect()
		{
			bool result;
			if (this.Connected)
			{
				result = true;
			}
			else
			{
				DateTime now = DateTime.Now;
				if (this.O_OO.OOO_OOO.)
				{
					FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
					if (o0OO._0OO. != null)
					{
						o0OO._0OO.("正在连接服务器");
					}
				}
				try
				{
					this.Ooo_Oo_O0.00O. = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					this.o_O.o_Oo0O_o0O. = Dns.GetHostAddresses(this.O_O.O0oO.)[0];
					this.o_O.o_Oo0O_o0O. = new IPEndPoint(this.o_O.o_Oo0O_o0O., this.o__0.0.);
					this.Ooo_Oo_O0.00O..Connect(this.o_O.o_Oo0O_o0O.);
					this.Ooo_Oo_O0.00O..Blocking = true;
					this.Ooo_Oo_O0.00O..SendTimeout = 100000;
					this.Ooo_Oo_O0.00O..ReceiveTimeout = 10000;
				}
				catch (Exception ex)
				{
					if (this.Ooo_Oo_O0.00O. != null && this.Ooo_Oo_O0.00O..Connected)
					{
						this.Ooo_Oo_O0.00O..Close();
					}
					if (this.O_OO.OOO_OOO.)
					{
						FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
						if (ooO_00_o != null)
						{
							ooO_00_o("连接服务器失败", "");
						}
					}
					return false;
				}
				this.Oo__O0._ooo0_o.();
				if (this.oOo0_Oo.O_. != 220)
				{
					this.Close();
					if (this.O_OO.OOO_OOO.)
					{
						FTPClient.OoO_00_o ooO_00_o2 = this.o_O.o_Oo0O_o0O.;
						if (ooO_00_o2 != null)
						{
							ooO_00_o2("连接服务器失败", this.o.0OoOooo__.);
						}
					}
					result = false;
				}
				else
				{
					if (this.O_OO.OOO_OOO.)
					{
						FTPClient.OOOOO00OoOOo o0OO._0OO.2 = this.O0OO._0OO.;
						if (o0OO._0OO.2 != null)
						{
							o0OO._0OO.2("传递用户名:" + this.Account);
						}
					}
					this.o0O_0_.00_oooo.("USER " + this.o__0.0.);
					if (this.oOo0_Oo.O_. != 331 && this.oOo0_Oo.O_. != 230)
					{
						this.O_O0Ooo_00.o.();
						if (this.O_OO.OOO_OOO.)
						{
							FTPClient.OoO_00_o ooO_00_o3 = this.o_O.o_Oo0O_o0O.;
							if (ooO_00_o3 != null)
							{
								ooO_00_o3("用户名无效", this.o.0OoOooo__.);
							}
						}
						result = false;
					}
					else
					{
						if (this.O_OO.OOO_OOO.)
						{
							FTPClient.OOOOO00OoOOo o0OO._0OO.3 = this.O0OO._0OO.;
							if (o0OO._0OO.3 != null)
							{
								o0OO._0OO.3("传递用户密码:******");
							}
						}
						if (this.oOo0_Oo.O_. != 230)
						{
							this.o0O_0_.00_oooo.("PASS " + this.Oo_.00., true);
							if (this.oOo0_Oo.O_. != 230 && this.oOo0_Oo.O_. != 202)
							{
								this.O_O0Ooo_00.o.();
								if (this.O_OO.OOO_OOO.)
								{
									FTPClient.OoO_00_o ooO_00_o4 = this.o_O.o_Oo0O_o0O.;
									if (ooO_00_o4 != null)
									{
										ooO_00_o4("用户密码错误", this.o.0OoOooo__.);
									}
								}
								return false;
							}
						}
						this.o0O_0_.00_oooo.("TYPE I");
						if (this.oOo0_Oo.O_. != 200)
						{
							FTPClient.OoO_00_o ooO_00_o5 = this.o_O.o_Oo0O_o0O.;
							if (ooO_00_o5 != null)
							{
								ooO_00_o5("设置二进制传输模式失败", this.o.0OoOooo__.);
							}
							result = false;
						}
						else
						{
							FTPClient.OOOOO00OoOOo o0OO._0OO.4 = this.O0OO._0OO.;
							if (o0OO._0OO.4 != null)
							{
								o0OO._0OO.4("设置二进制传输模式成功");
							}
							this.OOO00.ooo0. = true;
							this.Connected = true;
							if (Operators.CompareString(this.RootDir, "", true) > 0)
							{
								this.ChangeDir(this.RootDir);
							}
							if (this.O_OO.OOO_OOO.)
							{
								FTPClient.OOOOO00OoOOo o0OO._0OO.5 = this.O0OO._0OO.;
								if (o0OO._0OO.5 != null)
								{
									o0OO._0OO.5("服务器连接成功,用时:" + O_O0OO.OoO_00._.(DateTime.Now - now));
								}
							}
							FTPClient.OooO_O0O_0_O oooO_O0O_0_O = this.o_O.o_Oo0O_o0O.;
							if (oooO_O0O_0_O != null)
							{
								oooO_O0O_0_O();
							}
							result = true;
						}
					}
				}
			}
			return result;
		}

		/// <summary>
		/// 断开FTP连接
		/// </summary>
		// Token: 0x06002881 RID: 10369 RVA: 0x00123BEC File Offset: 0x00121DEC
		public void Close()
		{
			this.Connected = false;
			if (this.O_OO.OOO_OOO.)
			{
				FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
				if (o0OO._0OO. != null)
				{
					o0OO._0OO.("正在断开服务器");
				}
			}
			if (this.Ooo_Oo_O0.00O. != null)
			{
				this.o0O_0_.00_oooo.("QUIT");
			}
			this.O_O0Ooo_00.o.();
		}

		/// <summary>
		/// 用于返回FTP服务器指定目录下的全部文件名，以字符串集合的形式返回
		/// </summary>
		/// <param name="path">可选参数，用于指定目录，如果省略，则返回当前目录下的全部文件名</param>
		// Token: 0x06002882 RID: 10370 RVA: 0x00123C38 File Offset: 0x00121E38
		public List<string> GetFileList(string path = "*.*")
		{
			List<string> list = new List<string>();
			List<string> result;
			if (!this.Connect())
			{
				result = list;
			}
			else
			{
				DateTime now = DateTime.Now;
				byte[] array = null;
				FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
				if (o0OO._0OO. != null)
				{
					o0OO._0OO.("正在列表文件");
				}
				Socket socket = this.O_O_0_O0.oOO.();
				this.o0O_0_.00_oooo.("NLST " + path);
				if (this.oOo0_Oo.O_. != 150 && this.oOo0_Oo.O_. != 125)
				{
					FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
					if (ooO_00_o != null)
					{
						ooO_00_o("列表文件失败", this.o.0OoOooo__.);
					}
					result = list;
				}
				else
				{
					this.OOOoO___.O0ooo. = "";
					DateTime t = DateTime.Now.AddSeconds((double)this.oO0_O._.);
					while (DateTime.Compare(t, DateTime.Now) > 0)
					{
						int num = socket.Receive(this.Ooo_Oo_O0.00O., this.Ooo_Oo_O0.00O..Length, SocketFlags.None);
						if (num > 0)
						{
							if (array == null)
							{
								array = new byte[num - 1 + 1];
								Array.Copy(this.Ooo_Oo_O0.00O., 0, array, 0, num);
							}
							else
							{
								int destinationIndex = array.Length;
								array = (byte[])Utils.CopyArray(array, new byte[array.Length - 1 + num + 1]);
								Array.Copy(this.Ooo_Oo_O0.00O., 0, array, destinationIndex, num);
							}
						}
						if (num <= 0)
						{
							break;
						}
					}
					if (array != null)
					{
						this.OOOoO___.O0ooo. = this.o_O_.00_00..GetString(array);
					}
					string[] collection = this.OOOoO___.O0ooo..Replace("\r", "").Split(new char[]
					{
						'\n'
					}, StringSplitOptions.RemoveEmptyEntries);
					socket.Close();
					this.Oo__O0._ooo0_o.();
					if (this.oOo0_Oo.O_. != 226 || Operators.CompareString(this.OOOoO___.O0ooo., "", true) == 0)
					{
						collection = new string[0];
					}
					FTPClient.OOOOO00OoOOo o0OO._0OO.2 = this.O0OO._0OO.;
					if (o0OO._0OO.2 != null)
					{
						o0OO._0OO.2("列表文件完成,用时:" + O_O0OO.OoO_00._.(DateTime.Now - now) + "...");
					}
					list.AddRange(collection);
					for (int i = list.Count - 1; i >= 0; i += -1)
					{
						if (list[i].IndexOf(".") < 0)
						{
							list.RemoveAt(i);
						}
					}
					result = list;
				}
			}
			return result;
		}

		/// <summary>
		/// 于返回FTP服务器指定目录下的全部子目录，以字符串集合的形式返回
		/// </summary>
		/// <param name="path">可选参数，用于指定目录，如果省略，则返回当前目录下的全部子目录名</param>
		// Token: 0x06002883 RID: 10371 RVA: 0x00123E5C File Offset: 0x0012205C
		public List<string> GetDirList(string path = "")
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			list = this.GetDetailList(path);
			try
			{
				foreach (string text in list)
				{
					if (text.EndsWith("*D"))
					{
						text = text.Substring(0, text.IndexOf("*"));
						list2.Add(text);
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return list2;
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x00123EE0 File Offset: 0x001220E0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<string> GetDirectoryList(string pth = "")
		{
			return this.GetDirList(pth);
		}

		/// <summary>
		/// 返回FTP服务器指定目录下的全部文件和子目录，包括文件的名称、修改时间和大小，各项之间用符号*分隔
		/// </summary>
		/// <param name="path">可选参数，用于指定目录，如果省略，则返回当前目录下的全部子目录名</param>
		// Token: 0x06002885 RID: 10373 RVA: 0x00123EEC File Offset: 0x001220EC
		public List<string> GetDetailList(string path = "")
		{
			List<string> list = new List<string>();
			List<string> result;
			if (!this.Connect())
			{
				result = list;
			}
			else
			{
				DateTime now = DateTime.Now;
				byte[] array = null;
				FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
				if (o0OO._0OO. != null)
				{
					o0OO._0OO.("正在列表");
				}
				Socket socket = this.O_O_0_O0.oOO.();
				if (Operators.CompareString(path, "", true) == 0)
				{
					this.o0O_0_.00_oooo.("LIST");
				}
				else
				{
					this.o0O_0_.00_oooo.("LIST " + path);
				}
				if (this.oOo0_Oo.O_. != 150 && this.oOo0_Oo.O_. != 125)
				{
					FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
					if (ooO_00_o != null)
					{
						ooO_00_o("列表失败", this.o.0OoOooo__.);
					}
					result = list;
				}
				else
				{
					this.OOOoO___.O0ooo. = "";
					DateTime t = DateTime.Now.AddSeconds((double)this.oO0_O._.);
					while (DateTime.Compare(t, DateTime.Now) > 0)
					{
						int num = socket.Receive(this.Ooo_Oo_O0.00O., this.Ooo_Oo_O0.00O..Length, SocketFlags.None);
						if (num > 0)
						{
							if (array == null)
							{
								array = new byte[num - 1 + 1];
								Array.Copy(this.Ooo_Oo_O0.00O., 0, array, 0, num);
							}
							else
							{
								int destinationIndex = array.Length;
								array = (byte[])Utils.CopyArray(array, new byte[array.Length - 1 + num + 1]);
								Array.Copy(this.Ooo_Oo_O0.00O., 0, array, destinationIndex, num);
							}
						}
						if (num <= 0)
						{
							break;
						}
					}
					if (array != null)
					{
						this.OOOoO___.O0ooo. = this.o_O_.00_00..GetString(array);
					}
					string[] array2 = this.OOOoO___.O0ooo..Split(new char[]
					{
						'\n'
					});
					socket.Close();
					this.Oo__O0._ooo0_o.();
					if (this.oOo0_Oo.O_. != 226)
					{
						array2 = new string[0];
					}
					FTPClient.OOOOO00OoOOo o0OO._0OO.2 = this.O0OO._0OO.;
					if (o0OO._0OO.2 != null)
					{
						o0OO._0OO.2("列表结束,用时:" + O_O0OO.OoO_00._.(DateTime.Now - now) + "...");
					}
					foreach (string text in array2)
					{
						text = text.Trim(new char[]
						{
							'\n',
							'\r'
						});
						if (text.Length >= 5)
						{
							string[] array4 = text.Split(new char[]
							{
								' '
							}, StringSplitOptions.RemoveEmptyEntries);
							if (Versioned.IsNumeric(text.Substring(0, 2)))
							{
								if (array4.Length >= 4)
								{
									char c = array4[0].Substring(2, 1)[0];
									string[] array5 = array4[0].Split(new char[]
									{
										c
									});
									int num2 = Conversions.ToInteger(array5[2]);
									if (num2 <= 29)
									{
										num2 += 2000;
									}
									else if (num2 < 100)
									{
										num2 += 1900;
									}
									array4[0] = string.Concat(new string[]
									{
										array5[0],
										"/",
										array5[1],
										"/",
										Conversions.ToString(num2)
									});
									DateTime value;
									DateTime.TryParse(array4[0] + " " + array4[1], out value);
									if (array4.Length > 4)
									{
										int num3 = text.LastIndexOf(array4[2]) + array4[2].Length;
										array4[3] = text.Substring(num3 + 1).Trim();
									}
									list.Add(string.Concat(new string[]
									{
										array4[3],
										"*",
										Conversions.ToString(value),
										"*",
										Interaction.IIf(Operators.CompareString(array4[2], "<DIR>", true) == 0, "D", array4[2]).ToString()
									}));
								}
							}
							else if (array4.Length >= 8)
							{
								array4[8] = array4[8].Trim(new char[]
								{
									'\r'
								});
								if (Operators.CompareString(array4[8], ".", true) != 0 && Operators.CompareString(array4[8], "..", true) != 0)
								{
									if (array4.Length > 9)
									{
										int num4 = text.LastIndexOf(array4[7]) + array4[7].Length;
										array4[8] = text.Substring(num4 + 1).Trim();
									}
									string text2 = "";
									DateTime dateTime;
									if (!Versioned.IsNumeric(array4[7]))
									{
										text2 = " " + array4[7];
										array4[7] = DateTime.Today.Year.ToString();
										DateTime.TryParse(string.Concat(new string[]
										{
											array4[5],
											",",
											array4[6],
											",",
											array4[7],
											text2
										}), out dateTime);
										if (DateTime.Compare(dateTime, DateTime.Now) > 0)
										{
											dateTime = dateTime.AddYears(-1);
										}
									}
									else
									{
										DateTime.TryParse(string.Concat(new string[]
										{
											array4[5],
											",",
											array4[6],
											",",
											array4[7],
											text2
										}), out dateTime);
									}
									list.Add(string.Concat(new string[]
									{
										array4[8],
										"*",
										Conversions.ToString(dateTime),
										"*",
										Interaction.IIf(Operators.CompareString(array4[0].Substring(0, 1), "D", true) == 0, "D", array4[4]).ToString()
									}));
								}
							}
						}
					}
					if (this.Ooo_Oo_O0.00O..ContainsKey(this.CurrentDir))
					{
						this.Ooo_Oo_O0.00O..Remove(this.CurrentDir);
					}
					this.Ooo_Oo_O0.00O..Add(this.CurrentDir, list);
					result = list;
				}
			}
			return result;
		}

		/// <summary>
		/// 返回ftp上指定文件的大小，以字节为单位
		/// </summary>
		/// <param name="fileName">文件名，含相对路径</param>
		// Token: 0x06002886 RID: 10374 RVA: 0x0012446C File Offset: 0x0012266C
		public long GetFileSize(string fileName)
		{
			long result;
			if (!this.Connect())
			{
				result = 0L;
			}
			else
			{
				this.o0O_0_.00_oooo.("SIZE " + fileName);
				long num = 0L;
				if (this.oOo0_Oo.O_. == 213)
				{
					num = long.Parse(this.o.0OoOooo__..Split(new char[]
					{
						' '
					})[1]);
				}
				else
				{
					FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
					if (ooO_00_o != null)
					{
						ooO_00_o("获取文件大小失败", this.o.0OoOooo__.);
					}
				}
				result = num;
			}
			return result;
		}

		/// <summary>
		/// 返回ftp上指定文件最后一次修改的日期时间
		/// </summary>
		/// <param name="fileName">文件名，含相对路径</param>
		// Token: 0x06002887 RID: 10375 RVA: 0x001244E8 File Offset: 0x001226E8
		public DateTime GetFileTime(string fileName)
		{
			DateTime result;
			if (!this.Connect())
			{
				result = default(DateTime);
			}
			else
			{
				this.o0O_0_.00_oooo.("MDTM " + fileName);
				if (this.oOo0_Oo.O_. != 213)
				{
					FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
					if (ooO_00_o != null)
					{
						ooO_00_o("获取文件时间失败", this.o.0OoOooo__.);
					}
					result = default(DateTime);
				}
				else
				{
					string text = this.o.0OoOooo__.;
					if (text.IndexOf(" ") > 0)
					{
						text = text.Substring(text.IndexOf(" ") + 1);
					}
					if (text.IndexOf(".") > 0)
					{
						text.Substring(0, text.IndexOf("."));
					}
					text = text.Trim(new char[]
					{
						'\r',
						'\n'
					});
					if (text.Length >= 14)
					{
						text = string.Concat(new string[]
						{
							text.Substring(4, 2),
							"/",
							text.Substring(6, 2),
							"/",
							text.Substring(0, 4),
							" ",
							text.Substring(8, 2),
							":",
							text.Substring(10, 2),
							":",
							text.Substring(12, 2)
						});
					}
					DateTime dateTime;
					DateTime.TryParse(text, out dateTime);
					dateTime = dateTime.AddHours((double)TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours);
					result = dateTime;
				}
			}
			return result;
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00124663 File Offset: 0x00122863
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DateTime GetFileDate(string fileName)
		{
			return this.GetFileTime(fileName);
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x0012466C File Offset: 0x0012286C
		internal void <<EMPTY_NAME>>()
		{
			if (this.AsyncState == Oo_0.Oo_o_o.__oo.)
			{
				this.AsyncState = Oo_0.oO00o0._OoO00o.;
			}
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x00124680 File Offset: 0x00122880
		public bool Download(params object[] args)
		{
			bool result;
			if (args.Length == 2)
			{
				result = this.Download(Conversions.ToString(args[0]), Conversions.ToString(args[1]), false);
			}
			else
			{
				result = (args.Length == 3 && this.Download(Conversions.ToString(args[0]), Conversions.ToString(args[1]), Conversions.ToBoolean(args[2])));
			}
			return result;
		}

		/// <summary>
		/// 从FTP上下载文件
		/// </summary>
		/// <param name="remFileName">要下载的文件，含路径</param>
		/// <param name="locFileName">保存下载文件的文件名和路径</param>
		/// <param name="ShowUI">可选参数，逻辑型，是否显示下载进度，默认为False</param>
		// Token: 0x0600288B RID: 10379 RVA: 0x001246D8 File Offset: 0x001228D8
		public bool Download(string remFileName, string locFileName, bool ShowUI = false)
		{
			bool result;
			if (O_O0OO.oO_00Ooo___0._..Contains(remFileName.ToLower()))
			{
				MessageBox.Show("其它进程正在下载此文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				string parentPath = OO_00oOO.FileSys.GetParentPath(locFileName);
				if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
				{
					OO_00oOO.FileSys.CreateDirectory(parentPath);
				}
				if (!ShowUI)
				{
					result = this.oo0000O.Oo0OO.(remFileName, locFileName, false);
				}
				else
				{
					result = (new O\u3000O\u3000(this, remFileName, locFileName).ShowDialog() == DialogResult.OK);
				}
			}
			return result;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x00124758 File Offset: 0x00122958
		internal void <<EMPTY_NAME>>(string A_0, string A_1, bool A_2)
		{
			FTPClient.oO__oo_00O0o_ parameter = new FTPClient.oO__oo_00O0o_(A_0, A_1, A_2);
			this.Ooo_Oo_O0.00O. = new Thread(new ParameterizedThreadStart(this.O_O0Ooo_00.o.));
			this.Ooo_Oo_O0.00O..Start(parameter);
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x00124794 File Offset: 0x00122994
		private void <<EMPTY_NAME>>(object A_0)
		{
			FTPClient.oO__oo_00O0o_ oO__oo_00O0o_ = (FTPClient.oO__oo_00O0o_)A_0;
			this.oo0000O.Oo0OO.(oO__oo_00O0o_.oo_o0.ooo_oO., oO__oo_00O0o_.OO0O00_0_._0., oO__oo_00O0o_.oo_o0.ooo_oO.);
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x001247C4 File Offset: 0x001229C4
		private void UpLoadAsync1(object p)
		{
			FTPClient.o_o_oo0 o_o_oo = (FTPClient.o_o_oo0)p;
			this.OOO00.ooo0.(o_o_oo.oo_o0.ooo_oO., o_o_oo.oO.o___., o_o_oo.oo_o0.ooo_oO.);
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x001247F4 File Offset: 0x001229F4
		internal void <<EMPTY_NAME>>(string A_0, string A_1, bool A_2)
		{
			FTPClient.o_o_oo0 parameter = new FTPClient.o_o_oo0(A_0, A_1, A_2);
			this.Ooo_Oo_O0.00O. = new Thread(new ParameterizedThreadStart(this.UpLoadAsync1));
			this.Ooo_Oo_O0.00O..Start(parameter);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x00124830 File Offset: 0x00122A30
		private bool <<EMPTY_NAME>>(string A_0, string A_1, bool A_2)
		{
			bool flag;
			if (!this.Connect())
			{
				flag = false;
			}
			else
			{
				this.AsyncState = Oo_0.Oo_o_o.__oo.;
				FileStream fileStream = null;
				Socket socket = null;
				string text = A_1 + ".fxdlif";
				bool a_ = false;
				try
				{
					if (!A_2 && OO_00oOO.FileSys.FileExists(text))
					{
						if (this.Ooo_Oo_O0.00O..Contains(A_0.ToLower()))
						{
							A_2 = true;
						}
						else
						{
							OO_00oOO.FileSys.DeleteFile(text);
						}
					}
					DateTime now = DateTime.Now;
					long fileSize = this.GetFileSize(A_0);
					long num = 0L;
					bool flag2 = false;
					if (fileSize == 0L)
					{
						this.GetFileSize(A_0);
						if (fileSize == 0L)
						{
							using (File.Create(A_1))
							{
							}
							FTPClient.oO_o_0OOo__0 ooo_Oo_O0.00O. = this.Ooo_Oo_O0.00O.;
							if (ooo_Oo_O0.00O. != null)
							{
								ooo_Oo_O0.00O.(A_0);
							}
							return true;
						}
					}
					FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
					if (o0OO._0OO. != null)
					{
						o0OO._0OO.("正在下载文件[" + OO_00oOO.FileSys.GetName(A_0) + "]...");
					}
					this.BinaryMode = true;
					if (!File.Exists(text))
					{
						fileStream = File.Create(text);
					}
					else
					{
						FileInfo fileInfo = new FileInfo(text);
						if (fileInfo.Length > fileSize && A_2)
						{
							OO_00oOO.FileSys.DeleteFile(text);
							fileStream = File.Create(text);
						}
						else
						{
							if (fileInfo.Length == fileSize && A_2)
							{
								if (OO_00oOO.FileSys.FileExists(A_1))
								{
									OO_00oOO.FileSys.DeleteFile(A_1);
								}
								OO_00oOO.FileSys.RenameFile(text, OO_00oOO.FileSys.GetName(A_1));
								FTPClient.OOOOO00OoOOo o0OO._0OO.2 = this.O0OO._0OO.;
								if (o0OO._0OO.2 != null)
								{
									o0OO._0OO.2("[" + OO_00oOO.FileSys.GetName(A_0) + "]下载完成，用时" + O_O0OO.OoO_00._.(DateTime.Now - now));
								}
								FTPClient.oO_o_0OOo__0 ooo_Oo_O0.00O.2 = this.Ooo_Oo_O0.00O.;
								if (ooo_Oo_O0.00O.2 != null)
								{
									ooo_Oo_O0.00O.2(A_0);
								}
								return true;
							}
							fileStream = new FileStream(text, FileMode.Open);
						}
					}
					socket = this.O_O_0_O0.oOO.();
					socket.ReceiveTimeout = 15000;
					socket.SendTimeout = 15000;
					socket.Blocking = true;
					long num2 = 0L;
					if (A_2)
					{
						num2 = fileStream.Length;
						if (num2 > 0L)
						{
							this.o0O_0_.00_oooo.("REST " + Conversions.ToString(num2));
							if (this.oOo0_Oo.O_. != 350)
							{
								num2 = 0L;
							}
							else
							{
								fileStream.Seek(num2, SeekOrigin.Begin);
							}
						}
					}
					this.o0O_0_.00_oooo.("RETR " + A_0);
					if (this.oOo0_Oo.O_. != 150 && this.oOo0_Oo.O_. != 125)
					{
						FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
						if (ooO_00_o != null)
						{
							ooO_00_o("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]下载失败", this.o.0OoOooo__.);
						}
						if (this.oOo0_Oo.O_. == 550)
						{
							this.GetFileList("*.xxx");
						}
						flag = false;
					}
					else
					{
						if (!this.Ooo_Oo_O0.00O..Contains(A_0.ToLower()))
						{
							this.Ooo_Oo_O0.00O..Add(A_0.ToLower());
						}
						for (;;)
						{
							this.o.oo000oOoo. = socket.Receive(this.Ooo_Oo_O0.00O., this.Ooo_Oo_O0.00O..Length, SocketFlags.None);
							fileStream.Write(this.Ooo_Oo_O0.00O., 0, this.o.oo000oOoo.);
							this.o_O.o_Oo0O_o0O. = DateTime.Now;
							a_ = true;
							if (this.o.oo000oOoo. <= 0)
							{
								break;
							}
							num += (long)this.o.oo000oOoo.;
							DateTime now2;
							if ((DateTime.Now - now2).TotalSeconds >= 0.5)
							{
								FTPClient.o0O_O00o_0_o ooo_Oo_O0.00O.3 = this.Ooo_Oo_O0.00O.;
								if (ooo_Oo_O0.00O.3 != null)
								{
									ooo_Oo_O0.00O.3(A_0, fileSize, num2, num, DateTime.Now - now);
								}
								now2 = DateTime.Now;
							}
							if (this.oOo.O00O__oO_. == Oo_0.oO00o0._OoO00o.)
							{
								goto IL_38A;
							}
						}
						flag2 = true;
						a_ = false;
						IL_38A:
						fileStream.Close();
						if (socket.Connected)
						{
							socket.Close();
						}
						if (!flag2)
						{
							this.Oo__O0._ooo0_o.();
							FTPClient.OOOOO00OoOOo o0OO._0OO.3 = this.O0OO._0OO.;
							if (o0OO._0OO.3 != null)
							{
								o0OO._0OO.3("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]下载失败，用户取消...");
							}
							flag = false;
						}
						else
						{
							this.Oo__O0._ooo0_o.();
							if (this.oOo0_Oo.O_. != 226 && this.oOo0_Oo.O_. != 250)
							{
								FTPClient.OoO_00_o ooO_00_o2 = this.o_O.o_Oo0O_o0O.;
								if (ooO_00_o2 != null)
								{
									ooO_00_o2("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]下载失败", this.o.0OoOooo__.);
								}
								flag = false;
							}
							else
							{
								flag = true;
								if (this.Ooo_Oo_O0.00O..Contains(A_0.ToLower()))
								{
									this.Ooo_Oo_O0.00O..Remove(A_0.ToLower());
								}
								FTPClient.OOOOO00OoOOo o0OO._0OO.4 = this.O0OO._0OO.;
								if (o0OO._0OO.4 != null)
								{
									o0OO._0OO.4("[" + OO_00oOO.FileSys.GetName(A_0) + "]下载完成，用时" + O_O0OO.OoO_00._.(DateTime.Now - now));
								}
								if (OO_00oOO.FileSys.FileExists(A_1))
								{
									OO_00oOO.FileSys.DeleteFile(A_1);
								}
								OO_00oOO.FileSys.RenameFile(text, OO_00oOO.FileSys.GetName(A_1));
								FTPClient.oO_o_0OOo__0 ooo_Oo_O0.00O.4 = this.Ooo_Oo_O0.00O.;
								if (ooo_Oo_O0.00O.4 != null)
								{
									ooo_Oo_O0.00O.4(A_0);
								}
								if (A_1.StartsWith(OO_00oOO.ProjectPath + "RemoteFiles\\", StringComparison.InvariantCulture))
								{
									this.o0O_0_.00_oooo.("MDTM " + A_0);
									if (this.oOo0_Oo.O_. == 213)
									{
										string text2 = this.o.0OoOooo__.;
										if (text2.IndexOf(" ") > 0)
										{
											text2 = text2.Substring(text2.IndexOf(" ") + 1);
											text2 = text2.Trim(new char[]
											{
												'\r',
												'\n'
											});
											FileInfo fileInfo2 = new FileInfo(A_1);
											Oo00.o0_o._O_.(A_0, text2, fileSize.ToString(), fileInfo2.LastWriteTime.Ticks.ToString());
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					if (ex is SocketException || ex is ThreadAbortException)
					{
						if (socket != null && socket.Connected)
						{
							socket.Close();
						}
						if (!this.Ooo_Oo_O0.00O..Contains(A_0.ToLower()))
						{
							this.Ooo_Oo_O0.00O..Add(A_0.ToLower());
						}
					}
					else
					{
						this.Connected = false;
					}
					FTPClient.OOOOO00OoOOo o0OO._0OO.5 = this.O0OO._0OO.;
					if (o0OO._0OO.5 != null)
					{
						o0OO._0OO.5(ex.Message);
					}
					flag = false;
				}
				finally
				{
					if (fileStream != null)
					{
						fileStream.Close();
					}
					this.AsyncState = Oo_0.OOoo0_OO__._o.;
					if (!flag)
					{
						FTPClient.O__0O000__Oo ooo_Oo_O0.00O.5 = this.Ooo_Oo_O0.00O.;
						if (ooo_Oo_O0.00O.5 != null)
						{
							ooo_Oo_O0.00O.5(A_0, a_);
						}
					}
				}
			}
			return flag;
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00124EC4 File Offset: 0x001230C4
		internal void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			FTPClient.Oo___Ooo_ parameter = new FTPClient.Oo___Ooo_(A_0, A_1);
			this.Ooo_Oo_O0.00O. = new Thread(new ParameterizedThreadStart(this.O_O_0_O0.oOO.));
			this.Ooo_Oo_O0.00O..Start(parameter);
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x00124EFC File Offset: 0x001230FC
		private void <<EMPTY_NAME>>(object A_0)
		{
			FTPClient.Oo___Ooo_ oo___Ooo_ = (FTPClient.Oo___Ooo_)A_0;
			this.O_O_0_O0.oOO.(oo___Ooo_.O0OO._0OO., oo___Ooo_.OO0O00_0_._0.);
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00124F28 File Offset: 0x00123128
		internal bool <<EMPTY_NAME>>(string A_0, string A_1)
		{
			try
			{
				this.AsyncState = Oo_0.Oo_o_o.__oo.;
				if (this.oOo.O00O__oO_. == null)
				{
					Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.oOo.O00O__oO_., new StaticLocalInitFlag(), null);
				}
				bool flag = false;
				try
				{
					Monitor.Enter(this.oOo.O00O__oO_., ref flag);
					if (this.oOo.O00O__oO_..State == 0)
					{
						this.oOo.O00O__oO_..State = 2;
						this.oOo.O00O__oO_. = null;
					}
					else if (this.oOo.O00O__oO_..State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.oOo.O00O__oO_..State = 1;
					if (flag)
					{
						Monitor.Exit(this.oOo.O00O__oO_.);
					}
				}
				DataTable dataTable = new DataTable();
				FileInfo fileInfo = new FileInfo(A_1);
				if (Operators.CompareString(this.O00.O_oo., OO_00oOO.ProjectFile, true) != 0 || this.oOo.O00O__oO_. == null)
				{
					this.O00.O_oo. = OO_00oOO.ProjectFile;
					string text = OO_00oOO.ProjectPath + "RemoteFiles\\_foxdownloadinfo.mdb";
					if (!OO_00oOO.FileSys.FileExists(text))
					{
						FTPClient.Oo__ oo__ = this.o_O.o_Oo0O_o0O.;
						if (oo__ != null)
						{
							oo__(A_0, A_1, false);
						}
						return false;
					}
					this.oOo.O00O__oO_. = new OleDbConnection(Oo00.o_._0OOo.(text));
					this.oOo.O00O__oO_. = new OleDbDataAdapter("", this.oOo.O00O__oO_.);
				}
				this.oOo.O00O__oO_..SelectCommand.CommandText = "Select * From [Files] Where [remfile] = '" + A_0 + "'";
				this.oOo.O00O__oO_..Fill(dataTable);
				if (dataTable.Rows.Count == 0)
				{
					FTPClient.Oo__ oo__2 = this.o_O.o_Oo0O_o0O.;
					if (oo__2 != null)
					{
						oo__2(A_0, A_1, false);
					}
					return false;
				}
				DataRow dataRow = dataTable.Rows[0];
				string text2 = "";
				string right = this.GetFileSize(A_0).ToString();
				this.o0O_0_.00_oooo.("MDTM " + A_0);
				if (this.oOo0_Oo.O_. == 213)
				{
					text2 = this.o.0OoOooo__.;
					if (text2.IndexOf(" ") > 0)
					{
						text2 = text2.Substring(text2.IndexOf(" ") + 1);
						text2 = text2.Trim(new char[]
						{
							'\r',
							'\n'
						});
					}
				}
				if (Operators.CompareString(dataRow["remtime"].ToString(), text2, true) == 0 && Operators.CompareString(dataRow["remsize"].ToString(), right, true) == 0 && Operators.CompareString(fileInfo.Length.ToString(), right, true) == 0 && Operators.CompareString(dataRow["loctime"].ToString(), fileInfo.LastWriteTime.Ticks.ToString(), true) == 0)
				{
					FTPClient.Oo__ oo__3 = this.o_O.o_Oo0O_o0O.;
					if (oo__3 != null)
					{
						oo__3(A_0, A_1, true);
					}
					return true;
				}
			}
			catch (Exception ex)
			{
				FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
				if (o0OO._0OO. != null)
				{
					o0OO._0OO.(ex.Message);
				}
			}
			finally
			{
				this.AsyncState = Oo_0.OOoo0_OO__._o.;
			}
			FTPClient.Oo__ oo__4 = this.o_O.o_Oo0O_o0O.;
			if (oo__4 != null)
			{
				oo__4(A_0, A_1, false);
			}
			return false;
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x00125264 File Offset: 0x00123464
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Upload(params object[] args)
		{
			bool result;
			if (args.Length == 1)
			{
				result = this.Upload(Conversions.ToString(args[0]));
			}
			else if (args.Length == 2)
			{
				result = this.Upload(Conversions.ToString(args[0]), Conversions.ToString(args[1]), false);
			}
			else
			{
				result = (args.Length == 3 && this.Upload(Conversions.ToString(args[0]), Conversions.ToString(args[1]), Conversions.ToBoolean(args[2])));
			}
			return result;
		}

		/// <summary>
		/// 上传文件到当前目录
		/// </summary>
		/// <param name="locfileName">要上传的本地文件，含路径</param>
		// Token: 0x06002895 RID: 10389 RVA: 0x001252D2 File Offset: 0x001234D2
		public bool Upload(string locfileName)
		{
			return this.oOo.O00O__oO_.(locfileName, false);
		}

		/// <summary>
		/// 上传文件到指定目录
		/// </summary>
		/// <param name="locfileName">要上传的本地文件，含路径</param>
		/// <param name="remFileName">目标文件，含路径</param>
		/// <param name="ShowUI">逻辑型，是否显示上传进度，默认为False</param>
		// Token: 0x06002896 RID: 10390 RVA: 0x001252DC File Offset: 0x001234DC
		public bool Upload(string locfileName, string remFileName, bool ShowUI = false)
		{
			bool result;
			if (!ShowUI)
			{
				result = this.OOO00.ooo0.(locfileName, remFileName, false);
			}
			else
			{
				result = (new o\u3002\u3000\u3002\u3002\u3000(this, locfileName, remFileName).ShowDialog() == DialogResult.OK);
			}
			return result;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x00125310 File Offset: 0x00123510
		internal bool <<EMPTY_NAME>>(string A_0, bool A_1)
		{
			string a_ = this.CurrentDir.TrimEnd(new char[]
			{
				'/'
			}) + "/" + OO_00oOO.FileSys.GetName(A_0);
			return this.OOO00.ooo0.(A_0, a_, A_1);
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x00125354 File Offset: 0x00123554
		internal bool <<EMPTY_NAME>>(string A_0, string A_1, bool A_2)
		{
			bool flag;
			if (!this.Connect())
			{
				flag = false;
			}
			else if (OO_00oOO.FileIsOpened(A_0))
			{
				MessageBox.Show("文件已经被打开，无法上传！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				flag = false;
			}
			else
			{
				this.AsyncState = Oo_0.Oo_o_o.__oo.;
				FileStream fileStream = new FileStream(A_0, FileMode.Open, FileAccess.Read);
				Socket socket = null;
				try
				{
					long num = 0L;
					long num2 = 0L;
					if (A_2)
					{
						try
						{
							this.BinaryMode = true;
							if (this.FileExists(A_1))
							{
								num = this.GetFileSize(A_1);
							}
						}
						catch (Exception ex)
						{
							num = 0L;
						}
					}
					if (A_2 && fileStream.Length < num)
					{
						num = 0L;
					}
					else if (A_2 && fileStream.Length == num)
					{
						fileStream.Close();
						return false;
					}
					DateTime now = DateTime.Now;
					FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
					if (o0OO._0OO. != null)
					{
						o0OO._0OO.("正在上传文件[" + OO_00oOO.FileSys.GetName(A_0) + "]");
					}
					socket = this.O_O_0_O0.oOO.();
					socket.ReceiveTimeout = 15000;
					socket.SendTimeout = 15000;
					socket.Blocking = true;
					if (num > 0L)
					{
						this.o0O_0_.00_oooo.("REST " + Conversions.ToString(num));
						if (this.oOo0_Oo.O_. != 350)
						{
							num = 0L;
						}
					}
					this.o0O_0_.00_oooo.("STOR " + A_1);
					if (this.oOo0_Oo.O_. != 125 && this.oOo0_Oo.O_. != 150)
					{
						FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
						if (ooO_00_o != null)
						{
							ooO_00_o("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]上传失败", this.o.0OoOooo__.);
						}
						if (this.oOo0_Oo.O_. == 550)
						{
							this.GetFileList("*.xxx");
						}
						flag = false;
					}
					else
					{
						if (num != 0L)
						{
							fileStream.Seek(num, SeekOrigin.Begin);
						}
						this.o.oo000oOoo. = fileStream.Read(this.OO0O00_0_._0., 0, this.OO0O00_0_._0..Length);
						while (this.o.oo000oOoo. > 0)
						{
							socket.Send(this.OO0O00_0_._0., this.o.oo000oOoo., SocketFlags.None);
							this.o.oo000oOoo. = fileStream.Read(this.OO0O00_0_._0., 0, this.OO0O00_0_._0..Length);
							this.o_O.o_Oo0O_o0O. = DateTime.Now;
							if (this.oOo.O00O__oO_. == Oo_0.oO00o0._OoO00o.)
							{
								break;
							}
							num2 += (long)this.o.oo000oOoo.;
							DateTime now2;
							if ((DateTime.Now - now2).TotalSeconds >= 0.5)
							{
								FTPClient.o0_O_0_0 o0OO._0OO.2 = this.O0OO._0OO.;
								if (o0OO._0OO.2 != null)
								{
									o0OO._0OO.2(A_0, fileStream.Length, num, num2, DateTime.Now - now);
								}
								now2 = DateTime.Now;
							}
						}
						fileStream.Close();
						if (socket.Connected)
						{
							socket.Close();
						}
						if (this.AsyncState == Oo_0.oO00o0._OoO00o.)
						{
							this.Oo__O0._ooo0_o.();
							FTPClient.OoO_00_o ooO_00_o2 = this.o_O.o_Oo0O_o0O.;
							if (ooO_00_o2 != null)
							{
								ooO_00_o2("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]上传失败，用户取消...", this.o.0OoOooo__.);
							}
							flag = false;
						}
						else
						{
							this.Oo__O0._ooo0_o.();
							if (this.oOo0_Oo.O_. != 226 && this.oOo0_Oo.O_. != 250)
							{
								FTPClient.OoO_00_o ooO_00_o3 = this.o_O.o_Oo0O_o0O.;
								if (ooO_00_o3 != null)
								{
									ooO_00_o3("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]上传失败", this.o.0OoOooo__.);
								}
								flag = false;
							}
							else
							{
								FTPClient.OOOOO00OoOOo o0OO._0OO.3 = this.O0OO._0OO.;
								if (o0OO._0OO.3 != null)
								{
									o0OO._0OO.3(OO_00oOO.FileSys.GetName(A_0) + " 上传完成，用时" + O_O0OO.OoO_00._.(DateTime.Now - now));
								}
								FTPClient.oO___ o0OO._0OO.4 = this.O0OO._0OO.;
								if (o0OO._0OO.4 != null)
								{
									o0OO._0OO.4(A_0, A_1);
								}
								flag = true;
							}
						}
					}
				}
				catch (Exception ex2)
				{
					if ((ex2 is SocketException || ex2 is ThreadAbortException) && socket != null && socket.Connected)
					{
						socket.Close();
					}
					FTPClient.OOOOO00OoOOo o0OO._0OO.5 = this.O0OO._0OO.;
					if (o0OO._0OO.5 != null)
					{
						o0OO._0OO.5(ex2.Message);
					}
					flag = false;
				}
				finally
				{
					if (fileStream != null)
					{
						fileStream.Close();
					}
					if (!flag)
					{
						FTPClient.ooo__O o0OO._0OO.6 = this.O0OO._0OO.;
						if (o0OO._0OO.6 != null)
						{
							o0OO._0OO.6(A_0);
						}
					}
					this.AsyncState = Oo_0.OOoo0_OO__._o.;
				}
			}
			return flag;
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x001257A8 File Offset: 0x001239A8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void UploadDirectory(params object[] args)
		{
			if (args.Length == 2)
			{
				this.UploadDirectory(Conversions.ToString(args[0]), Conversions.ToBoolean(args[1]));
				return;
			}
			if (args.Length == 3)
			{
				this.UploadDirectory(Conversions.ToString(args[0]), Conversions.ToBoolean(args[1]), Conversions.ToString(args[2]));
			}
		}

		/// <summary>
		/// 上传整个目录中的文件
		/// </summary>
		/// <param name="path">目录名，含路径</param>
		/// <param name="recurse">是否上传子目录中的文件</param>
		// Token: 0x0600289A RID: 10394 RVA: 0x001257F6 File Offset: 0x001239F6
		public void UploadDirectory(string path, bool recurse)
		{
			this.UploadDirectory(path, recurse, "*.*");
		}

		/// <summary>
		/// 上传整个目录中的文件
		/// </summary>
		/// <param name="path">目录，含路径</param>
		/// <param name="recurse">是否上传子目录中的文件</param>
		/// <param name="mask">文件名筛选器,例如只上传文本文件，可以将此属性设置为"*.txt"</param>
		// Token: 0x0600289B RID: 10395 RVA: 0x00125808 File Offset: 0x00123A08
		public void UploadDirectory(string path, bool recurse, string mask)
		{
			string[] array = path.Replace("/", "\\").Split(new char[]
			{
				'\\'
			});
			string dirName = array[array.Length - 1];
			if (!this.DirExists(dirName))
			{
				this.MakeDir(dirName);
			}
			this.ChangeDir(dirName);
			foreach (string a_ in Directory.GetFiles(path, mask))
			{
				this.oOo.O00O__oO_.(a_, true);
			}
			if (recurse)
			{
				foreach (string path2 in Directory.GetDirectories(path))
				{
					this.UploadDirectory(path2, recurse, mask);
				}
			}
			this.ChangeDir("..");
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x001258B1 File Offset: 0x00123AB1
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Delete(string fileName)
		{
			return this.DeleteFile(fileName);
		}

		/// <summary>
		/// 删除文件
		/// </summary>
		/// <param name="fileName">要删除的文件名，含相对路径</param>
		// Token: 0x0600289D RID: 10397 RVA: 0x001258BC File Offset: 0x00123ABC
		public bool DeleteFile(string fileName)
		{
			bool result;
			if (!this.Connect())
			{
				result = false;
			}
			else
			{
				DateTime now = DateTime.Now;
				FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
				if (o0OO._0OO. != null)
				{
					o0OO._0OO.("正在删除文件[" + fileName + "]");
				}
				this.o0O_0_.00_oooo.("DELE " + fileName);
				if (this.oOo0_Oo.O_. != 250)
				{
					FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
					if (ooO_00_o != null)
					{
						ooO_00_o("删除文件失败", this.o.0OoOooo__.);
					}
					result = false;
				}
				else
				{
					FTPClient.OOOOO00OoOOo o0OO._0OO.2 = this.O0OO._0OO.;
					if (o0OO._0OO.2 != null)
					{
						o0OO._0OO.2("成功删除文件[" + fileName + "],用时:" + O_O0OO.OoO_00._.(DateTime.Now - now));
					}
					result = true;
				}
			}
			return result;
		}

		/// <summary>
		/// 重命名文件
		/// </summary>
		/// <param name="oldFileName">原文件名，含路径</param>
		/// <param name="newFileName">新文件名，含路径</param>
		// Token: 0x0600289E RID: 10398 RVA: 0x00125974 File Offset: 0x00123B74
		public bool Rename(string oldFileName, string newFileName)
		{
			bool result;
			if (!this.Connect())
			{
				result = false;
			}
			else
			{
				DateTime now = DateTime.Now;
				FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
				if (o0OO._0OO. != null)
				{
					o0OO._0OO.("正在重命名[" + oldFileName + "]");
				}
				this.o0O_0_.00_oooo.("RNFR " + oldFileName);
				if (this.oOo0_Oo.O_. != 350)
				{
					FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
					if (ooO_00_o != null)
					{
						ooO_00_o("重命名[" + oldFileName + "]失败", this.o.0OoOooo__.);
					}
					result = false;
				}
				else
				{
					this.o0O_0_.00_oooo.("RNTO " + newFileName);
					if (this.oOo0_Oo.O_. != 250)
					{
						FTPClient.OoO_00_o ooO_00_o2 = this.o_O.o_Oo0O_o0O.;
						if (ooO_00_o2 != null)
						{
							ooO_00_o2("重命名[" + oldFileName + "]失败", this.o.0OoOooo__.);
						}
						result = false;
					}
					else
					{
						FTPClient.OOOOO00OoOOo o0OO._0OO.2 = this.O0OO._0OO.;
						if (o0OO._0OO.2 != null)
						{
							o0OO._0OO.2(string.Concat(new string[]
							{
								"[",
								oldFileName,
								"]已经重命名至[",
								newFileName,
								"] ,用时:",
								O_O0OO.OoO_00._.(DateTime.Now - now)
							}));
						}
						result = true;
					}
				}
			}
			return result;
		}

		/// <summary>
		/// 判断是否存在指定名称的文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		// Token: 0x0600289F RID: 10399 RVA: 0x00125AA0 File Offset: 0x00123CA0
		public bool FileExists(string FileName)
		{
			return this.GetFileList(FileName).Count > 0;
		}

		/// <summary>
		/// 判断是否存在指定名称的目录
		/// </summary>
		/// <param name="dirName">目录名，含路径</param>
		// Token: 0x060028A0 RID: 10400 RVA: 0x00125AC4 File Offset: 0x00123CC4
		public bool DirExists(string dirName)
		{
			string currentDir = this.CurrentDir;
			bool result;
			if (Operators.CompareString(currentDir, dirName, true) == 0)
			{
				result = true;
			}
			else
			{
				this.ChangeDir(dirName);
				if (Operators.CompareString(this.CurrentDir, currentDir, true) != 0)
				{
					this.ChangeDir(currentDir);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		/// <summary>
		/// 创建目录
		/// </summary>
		/// <param name="dirName">目录名，含路径</param>
		// Token: 0x060028A1 RID: 10401 RVA: 0x00125B0C File Offset: 0x00123D0C
		public bool MakeDir(string dirName)
		{
			bool result;
			if (!this.Connect())
			{
				result = false;
			}
			else
			{
				DateTime now = DateTime.Now;
				FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
				if (o0OO._0OO. != null)
				{
					o0OO._0OO.("正在创建目录[" + dirName + "]");
				}
				this.o0O_0_.00_oooo.("MKD " + dirName);
				if (this.oOo0_Oo.O_. != 250 && this.oOo0_Oo.O_. != 257)
				{
					FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
					if (ooO_00_o != null)
					{
						ooO_00_o("创建目录[" + dirName + "]失败", this.o.0OoOooo__.);
					}
					result = false;
				}
				else
				{
					FTPClient.OOOOO00OoOOo o0OO._0OO.2 = this.O0OO._0OO.;
					if (o0OO._0OO.2 != null)
					{
						o0OO._0OO.2("成功创建目录[" + dirName + "],用时:" + O_O0OO.OoO_00._.(DateTime.Now - now));
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x00125BDC File Offset: 0x00123DDC
		private bool <<EMPTY_NAME>>(string A_0)
		{
			bool result;
			if (!this.Connect())
			{
				result = false;
			}
			else
			{
				DateTime now = DateTime.Now;
				FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
				if (o0OO._0OO. != null)
				{
					o0OO._0OO.("正在删除目录[" + A_0 + "]");
				}
				this.o0O_0_.00_oooo.("RMD " + A_0);
				if (this.oOo0_Oo.O_. != 250)
				{
					FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
					if (ooO_00_o != null)
					{
						ooO_00_o("[" + A_0 + "]删除失败", this.o.0OoOooo__.);
					}
					result = false;
				}
				else
				{
					FTPClient.OOOOO00OoOOo o0OO._0OO.2 = this.O0OO._0OO.;
					if (o0OO._0OO.2 != null)
					{
						o0OO._0OO.2("成功删除目录[" + A_0 + "],用时:" + O_O0OO.OoO_00._.(DateTime.Now - now));
					}
					result = true;
				}
			}
			return result;
		}

		/// <summary>
		/// 返回或设置FTP的名称
		/// </summary>
		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x00125C9C File Offset: 0x00123E9C
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x00125CA4 File Offset: 0x00123EA4
		public string FTPName
		{
			get
			{
				return this.o_._ooo_OO.;
			}
			set
			{
				this.o_._ooo_OO. = value;
			}
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00125CB0 File Offset: 0x00123EB0
		private bool <<EMPTY_NAME>>(string A_0)
		{
			bool result;
			if (!this.Connect())
			{
				result = false;
			}
			else
			{
				this.ChangeDir(A_0);
				List<string> detailList = this.GetDetailList("");
				try
				{
					foreach (string text in detailList)
					{
						if (text.EndsWith("*D"))
						{
							if (!this.ooO000Oo.oO.(text.Substring(0, text.IndexOf("*"))))
							{
								break;
							}
						}
						else if (!this.DeleteFile(text.Substring(0, text.IndexOf("*"))))
						{
							break;
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.ChangeDir("..");
				result = this.Oooo0_.0O_0.(A_0);
			}
			return result;
		}

		/// <summary>
		/// 删除目录
		/// </summary>
		/// <param name="dirName">目录名，含路径</param>
		/// <param name="anyway">可选参数，如果设为True，将删除目录下的文件及其子目录，如果省略此参数，则只有此目录为空的时候，才能删除</param>
		// Token: 0x060028A6 RID: 10406 RVA: 0x00125D74 File Offset: 0x00123F74
		public bool DeleteDir(string dirName, bool anyway = false)
		{
			bool result;
			if (!this.DirExists(dirName))
			{
				result = false;
			}
			else if (anyway)
			{
				result = this.ooO000Oo.oO.(dirName);
			}
			else
			{
				result = this.Oooo0_.0O_0.(dirName);
			}
			return result;
		}

		/// <summary>
		/// 将指定目录设置为当前目录
		/// </summary>
		/// <param name="dirName">目录名，含路径</param>
		// Token: 0x060028A7 RID: 10407 RVA: 0x00125DA4 File Offset: 0x00123FA4
		public void ChangeDir(string dirName)
		{
			if (Operators.CompareString(dirName, null, true) != 0 && !dirName.Equals(".") && dirName.Length != 0 && this.Connect())
			{
				DateTime now = DateTime.Now;
				FTPClient.OOOOO00OoOOo o0OO._0OO. = this.O0OO._0OO.;
				if (o0OO._0OO. != null)
				{
					o0OO._0OO.("正在进入目录[" + dirName + "]");
				}
				this.o0O_0_.00_oooo.("CWD " + dirName);
				if (this.oOo0_Oo.O_. != 250)
				{
					FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
					if (ooO_00_o != null)
					{
						ooO_00_o("[" + dirName + "]进入失败", this.o.0OoOooo__.);
						return;
					}
				}
				else
				{
					this.o0O_0_.00_oooo.("PWD");
					if (this.oOo0_Oo.O_. != 257)
					{
						FTPClient.OoO_00_o ooO_00_o2 = this.o_O.o_Oo0O_o0O.;
						if (ooO_00_o2 != null)
						{
							ooO_00_o2("[" + dirName + "]进入失败", this.o.0OoOooo__.);
							return;
						}
					}
					else
					{
						this.OOO00.ooo0. = this.OOOoO___.O0ooo..Split(new char[]
						{
							'"'
						})[1];
						FTPClient.OOOOO00OoOOo o0OO._0OO.2 = this.O0OO._0OO.;
						if (o0OO._0OO.2 != null)
						{
							o0OO._0OO.2("已经进入目录[" + this.OOO00.ooo0. + "],用时:" + O_O0OO.OoO_00._.(DateTime.Now - now));
						}
					}
				}
			}
		}

		/// <summary>
		/// 字符型，返回FTP的当前目录
		/// </summary>
		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x00125EE8 File Offset: 0x001240E8
		public string CurrentDir
		{
			get
			{
				if (Operators.CompareString(this.OOO00.ooo0., "", true) == 0)
				{
					if (!this.Connect())
					{
						return "";
					}
					this.o0O_0_.00_oooo.("PWD");
					if (this.oOo0_Oo.O_. != 257)
					{
						FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
						if (ooO_00_o != null)
						{
							ooO_00_o("获取当前目录失败！", this.o.0OoOooo__.);
						}
						return "/";
					}
					this.OOO00.ooo0. = this.OOOoO___.O0ooo..Split(new char[]
					{
						'"'
					})[1];
				}
				return this.OOO00.ooo0.;
			}
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x00125F7C File Offset: 0x0012417C
		internal bool <<EMPTY_NAME>>(string A_0)
		{
			if (A_0.Split(new char[]
			{
				'/'
			}, StringSplitOptions.RemoveEmptyEntries).Length > 0)
			{
				A_0 = A_0.Substring(0, A_0.LastIndexOf("/") + 1);
				if (Operators.CompareString(this.RootDir, "", true) > 0 && A_0.Length < this.RootDir.Length && this.RootDir.StartsWith(A_0))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00125FF4 File Offset: 0x001241F4
		private void <<EMPTY_NAME>>()
		{
			this.OOOoO___.O0ooo. = "";
			this.o.0OoOooo__. = this.oo0000O.Oo0OO.();
			if (this.o.0OoOooo__..Length > 3)
			{
				this.oOo0_Oo.O_. = int.Parse(this.o.0OoOooo__..Substring(0, 3));
				return;
			}
			this.o.0OoOooo__. = null;
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x00126048 File Offset: 0x00124248
		private string <<EMPTY_NAME>>()
		{
			string result;
			try
			{
				byte[] array = null;
				do
				{
					this.o.oo000oOoo. = this.Ooo_Oo_O0.00O..Receive(this.Ooo_Oo_O0.00O., this.Ooo_Oo_O0.00O..Length, SocketFlags.None);
					if (this.o.oo000oOoo. > 0)
					{
						if (array == null)
						{
							array = new byte[this.o.oo000oOoo. - 1 + 1];
							Array.Copy(this.Ooo_Oo_O0.00O., 0, array, 0, this.o.oo000oOoo.);
						}
						else
						{
							int destinationIndex = array.Length;
							array = (byte[])Utils.CopyArray(array, new byte[array.Length - 1 + this.o.oo000oOoo. + 1]);
							Array.Copy(this.Ooo_Oo_O0.00O., 0, array, destinationIndex, this.o.oo000oOoo.);
						}
					}
				}
				while (this.o.oo000oOoo. >= this.Ooo_Oo_O0.00O..Length);
				if (array != null)
				{
					this.OOOoO___.O0ooo. = this.o_O_.00_00..GetString(array);
				}
				string[] array2 = this.OOOoO___.O0ooo..Split(new char[]
				{
					'\n'
				});
				if (this.OOOoO___.O0ooo..Length > 2)
				{
					this.OOOoO___.O0ooo. = array2[array2.Length - 2];
				}
				else
				{
					this.OOOoO___.O0ooo. = array2[0];
				}
				int num;
				if (this.OOOoO___.O0ooo..Length > 4 && !this.OOOoO___.O0ooo..Substring(3, 1).Equals(" "))
				{
					result = this.oo0000O.Oo0OO.();
				}
				else if (this.OOOoO___.O0ooo..Length > 4 && !int.TryParse(this.OOOoO___.O0ooo..Substring(0, 3), out num))
				{
					result = this.oo0000O.Oo0OO.();
				}
				else
				{
					result = this.OOOoO___.O0ooo.;
				}
			}
			catch (Exception ex)
			{
				FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
				if (ooO_00_o != null)
				{
					ooO_00_o("FTP错误", ex.ToString());
				}
				this.Connected = false;
				result = "";
			}
			return result;
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x00126208 File Offset: 0x00124408
		private void <<EMPTY_NAME>>(string A_0)
		{
			this.o0O_0_.00_oooo.(A_0, false);
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x00126214 File Offset: 0x00124414
		private void <<EMPTY_NAME>>(string A_0, bool A_1)
		{
			try
			{
				byte[] bytes = this.o_O_.00_00..GetBytes((A_0 + "\r\n").ToCharArray());
				this.Ooo_Oo_O0.00O..Send(bytes, bytes.Length, SocketFlags.None);
				if (A_1)
				{
					Thread.Sleep(100);
				}
				this.Oo__O0._ooo0_o.();
				this.o_O.o_Oo0O_o0O. = DateTime.Now;
			}
			catch (Exception ex)
			{
				FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
				if (ooO_00_o != null)
				{
					ooO_00_o("FTP错误", ex.ToString());
				}
				this.Connected = false;
			}
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x001262AC File Offset: 0x001244AC
		private Socket <<EMPTY_NAME>>()
		{
			this.o0O_0_.00_oooo.("PASV");
			Socket result;
			if (this.oOo0_Oo.O_. != 227)
			{
				FTPClient.OoO_00_o ooO_00_o = this.o_O.o_Oo0O_o0O.;
				if (ooO_00_o != null)
				{
					ooO_00_o("进入PASV模式失败", this.o.0OoOooo__.);
				}
				result = null;
			}
			else
			{
				int num = this.o.0OoOooo__..IndexOf('(');
				int num2 = this.o.0OoOooo__..IndexOf(')');
				string text = this.o.0OoOooo__..Substring(num + 1, num2 - num - 1);
				int[] array = new int[7];
				int length = text.Length;
				int num3 = 0;
				string text2 = "";
				int num4 = 0;
				while (num4 < length && num3 <= 6)
				{
					char c = char.Parse(text.Substring(num4, 1));
					if (char.IsDigit(c))
					{
						text2 += Conversions.ToString(c);
					}
					else if (c != ',')
					{
						FTPClient.OoO_00_o ooO_00_o2 = this.o_O.o_Oo0O_o0O.;
						if (ooO_00_o2 != null)
						{
							ooO_00_o2("PASV 格式不正确", this.o.0OoOooo__.);
						}
						return null;
					}
					if (c == ',' || num4 + 1 == length)
					{
						try
						{
							array[num3] = int.Parse(text2);
							num3++;
							text2 = "";
						}
						catch (Exception ex)
						{
							FTPClient.OoO_00_o ooO_00_o3 = this.o_O.o_Oo0O_o0O.;
							if (ooO_00_o3 != null)
							{
								ooO_00_o3("PASV 格式不正确(不支持吗?)", this.o.0OoOooo__.);
							}
							return null;
						}
					}
					num4++;
				}
				string.Concat(new string[]
				{
					Conversions.ToString(array[0]),
					".",
					Conversions.ToString(array[1]),
					".",
					Conversions.ToString(array[2]),
					".",
					Conversions.ToString(array[3])
				});
				int port = (array[4] << 8) + array[5];
				Socket socket = null;
				try
				{
					socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					IPEndPoint remoteEP = new IPEndPoint(this.o_O.o_Oo0O_o0O., port);
					socket.Connect(remoteEP);
				}
				catch (Exception ex2)
				{
					if (socket == null && socket.Connected)
					{
						socket.Close();
					}
					FTPClient.OoO_00_o ooO_00_o4 = this.o_O.o_Oo0O_o0O.;
					if (ooO_00_o4 != null)
					{
						ooO_00_o4("不能连接到服务器", ex2.Message);
					}
					return null;
				}
				result = socket;
			}
			return result;
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x00126500 File Offset: 0x00124700
		private void <<EMPTY_NAME>>()
		{
			if (this.Ooo_Oo_O0.00O. != null)
			{
				this.Ooo_Oo_O0.00O..Close();
				this.Ooo_Oo_O0.00O. = null;
			}
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x0012651C File Offset: 0x0012471C
		private void <<EMPTY_NAME>>(object A_0, ElapsedEventArgs A_1)
		{
			if (this.Connected && this.AsyncState == Oo_0.OOoo0_OO__._o. && (DateTime.Now - this.o_O.o_Oo0O_o0O.).TotalSeconds > 30.0)
			{
				this.o_O.o_Oo0O_o0O. = DateTime.Now;
				new Thread(new ThreadStart(this.oo0000O.Oo0OO.)).Start();
			}
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x00126580 File Offset: 0x00124780
		private void <<EMPTY_NAME>>()
		{
			try
			{
				this.o0O_0_.00_oooo.("PWD");
				if (this.oOo0_Oo.O_. != 257)
				{
					this.Connected = false;
				}
				else
				{
					this.OOO00.ooo0. = this.OOOoO___.O0ooo..Split(new char[]
					{
						'"'
					})[1];
				}
			}
			catch (Exception ex)
			{
				this.Connected = false;
			}
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x001265F4 File Offset: 0x001247F4
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			this.O0.o0. = true;
			this.Connected = false;
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x00126604 File Offset: 0x00124804
		public static bool Ping()
		{
			return NetworkInterface.GetIsNetworkAvailable() && ShareLibriay.Network.Ping("www.baidu.com");
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x00126630 File Offset: 0x00124830
		internal FTPClient <<EMPTY_NAME>>()
		{
			return new FTPClient
			{
				Host = this.Host,
				Account = this.Account,
				Password = this.Password,
				Port = this.Port,
				UTF8 = this.UTF8,
				RootDir = this.RootDir,
				UploadEnabled = this.UploadEnabled,
				DownloadEnabled = this.DownloadEnabled,
				RenameEnabled = this.RenameEnabled,
				DeleteEnabled = this.DeleteEnabled,
				MakerDirEnabled = this.MakerDirEnabled,
				OpenFileEnabled = this.OpenFileEnabled,
				FTPName = this.FTPName
			};
		}

		// Token: 0x040010A1 RID: 4257
		private int <<EMPTY_NAME>>;

		// Token: 0x040010A2 RID: 4258
		private int <<EMPTY_NAME>>;

		// Token: 0x040010A3 RID: 4259
		private Encoding <<EMPTY_NAME>>;

		// Token: 0x040010A4 RID: 4260
		private string <<EMPTY_NAME>>;

		// Token: 0x040010A5 RID: 4261
		private string <<EMPTY_NAME>>;

		// Token: 0x040010A6 RID: 4262
		private string <<EMPTY_NAME>>;

		// Token: 0x040010A7 RID: 4263
		private string <<EMPTY_NAME>>;

		// Token: 0x040010A8 RID: 4264
		private string <<EMPTY_NAME>>;

		// Token: 0x040010A9 RID: 4265
		private string <<EMPTY_NAME>>;

		// Token: 0x040010AA RID: 4266
		private IPAddress <<EMPTY_NAME>>;

		// Token: 0x040010AB RID: 4267
		private IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x040010AC RID: 4268
		private string <<EMPTY_NAME>>;

		// Token: 0x040010AD RID: 4269
		private int <<EMPTY_NAME>>;

		// Token: 0x040010AE RID: 4270
		private int <<EMPTY_NAME>>;

		// Token: 0x040010AF RID: 4271
		private int <<EMPTY_NAME>>;

		// Token: 0x040010B0 RID: 4272
		private bool <<EMPTY_NAME>>;

		// Token: 0x040010B1 RID: 4273
		private bool <<EMPTY_NAME>>;

		// Token: 0x040010B2 RID: 4274
		private string <<EMPTY_NAME>>;

		// Token: 0x040010B3 RID: 4275
		private byte[] <<EMPTY_NAME>>;

		// Token: 0x040010B4 RID: 4276
		private byte[] <<EMPTY_NAME>>;

		// Token: 0x040010B5 RID: 4277
		private Socket <<EMPTY_NAME>>;

		// Token: 0x040010B6 RID: 4278
		private int <<EMPTY_NAME>>;

		// Token: 0x040010B7 RID: 4279
		private Oo_0 <<EMPTY_NAME>>;

		// Token: 0x040010B8 RID: 4280
		private bool <<EMPTY_NAME>>;

		// Token: 0x040010B9 RID: 4281
		private string <<EMPTY_NAME>>;

		// Token: 0x040010BA RID: 4282
		private string <<EMPTY_NAME>>;

		// Token: 0x040010BB RID: 4283
		private bool <<EMPTY_NAME>>;

		// Token: 0x040010BC RID: 4284
		private bool <<EMPTY_NAME>>;

		// Token: 0x040010BD RID: 4285
		private bool <<EMPTY_NAME>>;

		// Token: 0x040010BE RID: 4286
		private bool <<EMPTY_NAME>>;

		// Token: 0x040010BF RID: 4287
		private bool <<EMPTY_NAME>>;

		// Token: 0x040010C0 RID: 4288
		private bool <<EMPTY_NAME>>;

		// Token: 0x040010C1 RID: 4289
		private bool <<EMPTY_NAME>>;

		// Token: 0x040010C2 RID: 4290
		[CompilerGenerated]
		private FTPClient.o0O_O00o_0_o <<EMPTY_NAME>>;

		// Token: 0x040010C3 RID: 4291
		[CompilerGenerated]
		private FTPClient.oO_o_0OOo__0 <<EMPTY_NAME>>;

		// Token: 0x040010C4 RID: 4292
		[CompilerGenerated]
		private FTPClient.O__0O000__Oo <<EMPTY_NAME>>;

		// Token: 0x040010C5 RID: 4293
		[CompilerGenerated]
		private FTPClient.o0_O_0_0 <<EMPTY_NAME>>;

		// Token: 0x040010C6 RID: 4294
		[CompilerGenerated]
		private FTPClient.oO___ <<EMPTY_NAME>>;

		// Token: 0x040010C7 RID: 4295
		[CompilerGenerated]
		private FTPClient.ooo__O <<EMPTY_NAME>>;

		// Token: 0x040010C8 RID: 4296
		[CompilerGenerated]
		private FTPClient.OooO_O0O_0_O <<EMPTY_NAME>>;

		// Token: 0x040010C9 RID: 4297
		[CompilerGenerated]
		private FTPClient.OOOOO00OoOOo <<EMPTY_NAME>>;

		// Token: 0x040010CA RID: 4298
		[CompilerGenerated]
		private FTPClient.OoO_00_o <<EMPTY_NAME>>;

		// Token: 0x040010CB RID: 4299
		[CompilerGenerated]
		private FTPClient.Oo__ <<EMPTY_NAME>>;

		// Token: 0x040010CC RID: 4300
		[CompilerGenerated]
		[AccessedThroughProperty("Timer")]
		private System.Timers.Timer <<EMPTY_NAME>>;

		// Token: 0x040010CD RID: 4301
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x040010CE RID: 4302
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040010CF RID: 4303
		internal Dictionary<string, List<string>> <<EMPTY_NAME>>;

		// Token: 0x040010D0 RID: 4304
		private Thread <<EMPTY_NAME>>;

		// Token: 0x040010D1 RID: 4305
		internal List<string> <<EMPTY_NAME>>;

		// Token: 0x040010D2 RID: 4306
		[CompilerGenerated]
		[AccessedThroughProperty("MainForm")]
		private Form <<EMPTY_NAME>>;

		// Token: 0x040010D3 RID: 4307
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040010D4 RID: 4308
		private string <<EMPTY_NAME>>;

		// Token: 0x040010D5 RID: 4309
		private OleDbDataAdapter <<EMPTY_NAME>>;

		// Token: 0x040010D6 RID: 4310
		private OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x040010D7 RID: 4311
		private StaticLocalInitFlag <<EMPTY_NAME>>;

		// Token: 0x020002DC RID: 732
		[EditorBrowsable(EditorBrowsableState.Never)]
		public class OOO_o00_OO_ : Exception
		{
			// Token: 0x060028B5 RID: 10421 RVA: 0x001266DE File Offset: 0x001248DE
			public OOO_o00_OO_(string A_0) : base(A_0)
			{
			}

			// Token: 0x060028B6 RID: 10422 RVA: 0x001266E7 File Offset: 0x001248E7
			public OOO_o00_OO_(string A_0, Exception A_1) : base(A_0, A_1)
			{
			}
		}

		// Token: 0x020002DD RID: 733
		// (Invoke) Token: 0x060028BA RID: 10426
		internal delegate void o0O_O00o_0_o(string A_0, long A_1, long A_2, long A_3, TimeSpan A_4);

		// Token: 0x020002DE RID: 734
		// (Invoke) Token: 0x060028BE RID: 10430
		internal delegate void oO_o_0OOo__0(string A_0);

		// Token: 0x020002DF RID: 735
		// (Invoke) Token: 0x060028C2 RID: 10434
		internal delegate void O__0O000__Oo(string A_0, bool A_1);

		// Token: 0x020002E0 RID: 736
		// (Invoke) Token: 0x060028C6 RID: 10438
		internal delegate void o0_O_0_0(string A_0, long A_1, long A_2, long A_3, TimeSpan A_4);

		// Token: 0x020002E1 RID: 737
		// (Invoke) Token: 0x060028CA RID: 10442
		internal delegate void oO___(string A_0, string A_1);

		// Token: 0x020002E2 RID: 738
		// (Invoke) Token: 0x060028CE RID: 10446
		internal delegate void ooo__O(string A_0);

		// Token: 0x020002E3 RID: 739
		// (Invoke) Token: 0x060028D2 RID: 10450
		internal delegate void OooO_O0O_0_O();

		// Token: 0x020002E4 RID: 740
		// (Invoke) Token: 0x060028D6 RID: 10454
		internal delegate void OOOOO00OoOOo(string A_0);

		// Token: 0x020002E5 RID: 741
		// (Invoke) Token: 0x060028DA RID: 10458
		internal delegate void OoO_00_o(string A_0, string A_1);

		// Token: 0x020002E6 RID: 742
		// (Invoke) Token: 0x060028DE RID: 10462
		internal delegate void Oo__(string A_0, string A_1, bool A_2);

		// Token: 0x020002E7 RID: 743
		private class oO__oo_00O0o_
		{
			// Token: 0x060028DF RID: 10463 RVA: 0x001266F1 File Offset: 0x001248F1
			internal oO__oo_00O0o_(string A_0, string A_1, bool A_2)
			{
				this.oo_o0.ooo_oO. = A_0;
				this.OO0O00_0_._0. = A_1;
				this.oo_o0.ooo_oO. = A_2;
			}

			// Token: 0x040010D8 RID: 4312
			internal string <<EMPTY_NAME>>;

			// Token: 0x040010D9 RID: 4313
			internal string <<EMPTY_NAME>>;

			// Token: 0x040010DA RID: 4314
			internal bool <<EMPTY_NAME>>;
		}

		// Token: 0x020002E8 RID: 744
		private class o_o_oo0
		{
			// Token: 0x060028E0 RID: 10464 RVA: 0x0012670E File Offset: 0x0012490E
			internal o_o_oo0(string A_0, string A_1, bool A_2)
			{
				this.oo_o0.ooo_oO. = A_0;
				this.oO.o___. = A_1;
				this.oo_o0.ooo_oO. = A_2;
			}

			// Token: 0x040010DB RID: 4315
			internal string <<EMPTY_NAME>>;

			// Token: 0x040010DC RID: 4316
			internal string <<EMPTY_NAME>>;

			// Token: 0x040010DD RID: 4317
			internal bool <<EMPTY_NAME>>;
		}

		// Token: 0x020002E9 RID: 745
		private class Oo___Ooo_
		{
			// Token: 0x060028E1 RID: 10465 RVA: 0x0012672B File Offset: 0x0012492B
			internal Oo___Ooo_(string A_0, string A_1)
			{
				this.O0OO._0OO. = A_0;
				this.OO0O00_0_._0. = A_1;
			}

			// Token: 0x040010DE RID: 4318
			internal string <<EMPTY_NAME>>;

			// Token: 0x040010DF RID: 4319
			internal string <<EMPTY_NAME>>;
		}
	}
}
