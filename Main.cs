using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;
using ActiproSoftware.Products;
using ActiproSoftware.Text.Languages.DotNet.Reflection;
using ActiproSoftware.Text.Languages.DotNet.Reflection.Implementation;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.Text.Parsing;
using ActiproSoftware.Text.Parsing.Implementation;
using ADODB;
using ADOX;
using C1.Win.C1Ribbon;
using Foxtable.My;
using Foxtable.My.Resources;
using Foxtable.Syscmd;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

namespace Foxtable
{
	// Token: 0x02000450 RID: 1104
	[StandardModule]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class Main
	{
		// Token: 0x06004A52 RID: 19026 RVA: 0x0020E038 File Offset: 0x0020C238
		static Main()
		{
			// Note: this type is marked as 'beforefieldinit'.
			int a_ = 12;
			Foxtable.Main.OO_O.o. = SplashFormStateEnum.Normal;
			Foxtable.Main.OO_O.o. = new o\u3000\u3002\u3002\u3002\u3002();
			Foxtable.Main.oo0.o0_o. = 85;
			Foxtable.Main.O__Ooo_00O.ooO. = 90;
			Foxtable.Main.oo0.o0_o. = O00OOOo_O0_O.b("諮诰鳲뻴菶韸쳺闼귾夀攂椄挆焈㸊尌砎吐礒搔⌖弘稚䤜焞眠ఢ䈤戦稨䜪听圮堰ᠲ嬴簶爸䠺爼朾橀あང罆ൈ╊㽌ॎ♐⭒㩔㑖Řၚ๜቞⭠ୢ⥤≦╨䑪๬㙮䑰ᑲʹᕶ䩸ᅺ╼᝾ﲄ삈늊떌\udb8eﺐꖒ횔ﲘﾜ즞캢钤쾦骨쪪肮\ud8b2膴솶\uddba\udcbc욾鏀胂ꋄ﷈車ﻌ軎뫐ꃒ뻔釖뻘", a_);
		}

		// Token: 0x06004A53 RID: 19027
		[DllImport("Foxtable.IO.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetValue([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0);

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06004A54 RID: 19028 RVA: 0x0020E07F File Offset: 0x0020C27F
		internal static o\u3000\u3002\u3002\u3002\u3002 ProcessForm
		{
			get
			{
				if (Foxtable.Main.OO_O.o. == null || Foxtable.Main.OO_O.o..IsDisposed)
				{
					Foxtable.Main.OO_O.o. = new o\u3000\u3002\u3002\u3002\u3002();
				}
				return Foxtable.Main.OO_O.o.;
			}
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x0020E0A4 File Offset: 0x0020C2A4
		private static void <<EMPTY_NAME>>()
		{
			int a_ = 9;
			MessageBox.Show(O00OOOo_O0_O.b("삌풊璙\udcf1뫳돵곷\udaf9뫻賽懿漁愃焅朇砉朋⸍∏㰑␓幧㑰\udd96剔ዢ쁺䝈ṻ暡L╗뽱㻎쎸煦齉੫ሻ瀽Կᙁ摃E㩇⭉⅋⭍❏㵑♓㵕硗桙牛湝䁟ㅡ㑣呥橗", a_), O00OOOo_O0_O.b("Ŧ", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			string text = O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("裫臭蟯鳱飳駵駷黹鋻鯽瓿焁球㐅☇戉砋挍", a_);
			if (OO_00oOO.FileSys.FileExists(text))
			{
				new Process
				{
					File = text
				}.Start();
			}
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x0020E118 File Offset: 0x0020C318
		[STAThread]
		public static void Main()
		{
			int a_ = 16;
			int num;
			int num4;
			object obj;
			try
			{
				IL_09:
				ProjectData.ClearProjectError();
				num = 1;
				IL_10:
				int num2 = 2;
				if (AmbientParseRequestDispatcherProvider.Dispatcher != null)
				{
					goto IL_64;
				}
				IL_19:
				num2 = 3;
				AmbientParseRequestDispatcherProvider.Dispatcher = new ThreadedParseRequestDispatcher();
				IL_25:
				num2 = 4;
				string cachePath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), O00OOOo_O0_O.b("뗲髴迶跸髺鿼鏾搀⌂䘄栆洈渊希笎搐眒簔砖", a_)), O00OOOo_O0_O.b("닲蛴蓶鳸雺鿼鏾砀⌂圄戆礈搊縌明攐簒朔渖", a_));
				IL_56:
				num2 = 5;
				AmbientAssemblyRepositoryProvider.Repository = new FileBasedAssemblyRepository(cachePath);
				IL_64:
				num2 = 6;
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				IL_6C:
				num2 = 7;
				backgroundWorker.DoWork += Foxtable.Main.o_0Oo0__.oooO0.;
				IL_80:
				num2 = 8;
				backgroundWorker.RunWorkerAsync();
				IL_88:
				num2 = 9;
				ActiproLicenseManager.RegisterLicense(O00OOOo_O0_O.b("뗲髴迶跸髺鿼鏾搀", a_), O00OOOo_O0_O.b("ꓲ보맶쯸짺쳼틾嘀唂䘄䤆伈☊㸌㸎┐崒䐔㨖刘䰚嘜䴞ᔠย簤氦樨氪", a_));
				IL_AC:
				num2 = 10;
				if (OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("鯲鳴鏶ퟸ鿺釼鏾", a_)) || OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("胲郴菶賸诺鳼迾栀ⴂ愄欆攈", a_)))
				{
					goto IL_614;
				}
				IL_FD:
				num2 = 12;
				if (OO_00oOO.FileSys.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + O00OOOo_O0_O.b("꿲돴飶臸迺鳼鷾洀昂粜", a_)))
				{
					goto IL_14B;
				}
				IL_125:
				num2 = 13;
				OO_00oOO.FileSys.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + O00OOOo_O0_O.b("꿲돴飶臸迺鳼鷾洀昂粜", a_));
				IL_14B:
				num2 = 14;
				OoO0o.LoadRuntime();
				IL_154:
				num2 = 15;
				string a_2 = "";
				IL_15E:
				num2 = 16;
				if (Operators.CompareString(OO_00oOO.IssueName(), "", true) != 0)
				{
					goto IL_18A;
				}
				IL_173:
				num2 = 17;
				throw new Exception(O00OOOo_O0_O.b("᩿웶째쯺", a_));
				IL_18A:
				num2 = 18;
				if (!SystemInformation.TerminalServerSession)
				{
					goto IL_1D9;
				}
				IL_194:
				num2 = 19;
				MessageBox.Show(O00.DecryptText(Foxtable.Main.oo0.o0_o., O00OOOo_O0_O.b("싲", a_), O00OOOo_O0_O.b("쇲", a_)), O00OOOo_O0_O.b("⎑쾍", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_614;
				IL_1D9:
				num2 = 21;
				if (c.Oo.__O0.().CommandLineArgs.Count <= 0 || !c.OOOOO.o.().FileSystem.FileExists(c.Oo.__O0.().CommandLineArgs[0]))
				{
					goto IL_229;
				}
				IL_20F:
				num2 = 22;
				a_2 = c.Oo.__O0.().CommandLineArgs[0].Trim();
				IL_229:
				num2 = 23;
				Application.CurrentCulture = new CultureInfo(O00OOOo_O0_O.b("觲鷴\udaf6뫸뗺", a_));
				IL_244:
				num2 = 24;
				Foxtable.Main.OO_O.o. = Application.ExecutablePath.Substring(0, Application.ExecutablePath.Length - 3) + O00OOOo_O0_O.b("郲鷴髶", a_);
				IL_276:
				num2 = 25;
				if (!o_O_o_oOoo__.OOOO_OO._oo.())
				{
					goto IL_28D;
				}
				IL_280:
				num2 = 26;
				Foxtable.Main.oOOoo_.0__.();
				goto IL_614;
				IL_28D:
				num2 = 28;
				if (o0OO__.O_0_O0_OO.0Ooo.())
				{
					goto IL_2BB;
				}
				IL_297:
				num2 = 29;
				MessageBox.Show(O_O0OO.o0o__._.(), O00OOOo_O0_O.b("⎑쾍", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_614;
				IL_2BB:
				num2 = 32;
				if (DateTime.Compare(o0OO__.oOO.o_.(), Conversions.ToDate(OO_00oOO.ApplicationVertion())) >= 0)
				{
					goto IL_313;
				}
				IL_2D5:
				num2 = 33;
				MessageBox.Show(O_O0OO.OO_0.0o_.().Trim(new char[1]) + Conversions.ToString(o0OO__.oOO.o_.()), O00OOOo_O0_O.b("⎑쾍", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_614;
				IL_313:
				num2 = 35;
				if (o0OO__.Oo_o.O_ooo.())
				{
					goto IL_352;
				}
				IL_31D:
				num2 = 36;
				Foxtable.Main.OO_O.o. = SplashFormStateEnum.Hide;
				IL_326:
				num2 = 37;
				Application.DoEvents();
				IL_32E:
				num2 = 38;
				MessageBox.Show(O_O0OO.O.ooo.(), O00OOOo_O0_O.b("⎑쾍", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_614;
				IL_352:
				num2 = 40;
				ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(Foxtable.Main.oO0.o0_o0o.);
				IL_366:
				num2 = 41;
				SystemEvents.PowerModeChanged += O_O0OO.Oo0.OoOo.;
				IL_37A:
				num2 = 42;
				Application.EnableVisualStyles();
				IL_382:
				num2 = 43;
				Thread thread = new Thread(new ThreadStart(Foxtable.Main.o_0.O0oO_O0_.));
				IL_398:
				num2 = 44;
				thread.Start();
				IL_3A2:
				num2 = 45;
				Application.DoEvents();
				IL_3AA:
				num2 = 46;
				string text = Foxtable.My.Resources.a.o0oO_0.O_oOO_.();
				Foxtable.Main.SetValue(ref text);
				IL_3BC:
				num2 = 47;
				AppDomain.CurrentDomain.AssemblyResolve += Foxtable.Main.o_0Oo0__.oooO0.;
				IL_3D5:
				num2 = 48;
				Foxtable.Main.o_0Oo0__.oooO0.(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("뇲鳴駶ꗸ", a_));
				IL_3F5:
				num2 = 49;
				if (!OO_00oOO.FileSys.DirectoryExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("뇲鳴駶", a_)))
				{
					goto IL_4CD;
				}
				IL_41F:
				num2 = 50;
				if (OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("꿲럴黶韸ꟺ꯼髾猀瀂氄栆月┊礌眎攐", a_)))
				{
					goto IL_46E;
				}
				IL_446:
				num2 = 51;
				OO_00oOO.FileSys.DeleteDirectory(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("뇲鳴駶", a_), DeleteDirectoryOption.DeleteAllContents);
				goto IL_4CD;
				IL_46E:
				num2 = 53;
				string right = OO_00oOO.FileSys.ReadAllText(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("꿲럴黶韸ꟺ꯼髾猀瀂氄栆月┊礌眎攐", a_));
				IL_495:
				num2 = 54;
				if (Operators.CompareString(OO_00oOO.ApplicationVertion(), right, true) == 0)
				{
					goto IL_4CD;
				}
				IL_4A7:
				num2 = 55;
				OO_00oOO.FileSys.DeleteDirectory(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("뇲鳴駶", a_), DeleteDirectoryOption.DeleteAllContents);
				IL_4CD:
				num2 = 56;
				if (OO_00oOO.FileSys.DirectoryExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("뇲鳴駶", a_)))
				{
					goto IL_544;
				}
				IL_4F4:
				num2 = 57;
				OO_00oOO.FileSys.CreateDirectory(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("뇲鳴駶", a_));
				IL_519:
				num2 = 58;
				OO_00oOO.FileSys.WriteAllText(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("꿲럴黶韸ꟺ꯼髾猀瀂氄栆月┊礌眎攐", a_), OO_00oOO.ApplicationVertion(), false);
				IL_544:
				num2 = 59;
				DateTimeFormatInfo dateTimeFormatInfo = Application.CurrentCulture.DateTimeFormat;
				IL_553:
				num2 = 60;
				dateTimeFormatInfo.DateSeparator = O00OOOo_O0_O.b("\udef2", a_);
				IL_56B:
				num2 = 61;
				dateTimeFormatInfo.TimeSeparator = O00OOOo_O0_O.b("짲", a_);
				IL_583:
				num2 = 62;
				dateTimeFormatInfo.ShortDatePattern = O00OOOo_O0_O.b("諲賴軶胸훺냼닾Ⰰ朂愄", a_);
				IL_59B:
				num2 = 63;
				dateTimeFormatInfo.LongDatePattern = O00OOOo_O0_O.b("諲賴軶胸훺냼닾Ⰰ朂愄", a_);
				IL_5B3:
				num2 = 64;
				dateTimeFormatInfo.ShortTimePattern = O00OOOo_O0_O.b("믲쿴髶铸", a_);
				IL_5CB:
				num2 = 65;
				dateTimeFormatInfo.LongTimePattern = O00OOOo_O0_O.b("믲뷴췶铸雺쟼賾爀", a_);
				IL_5E3:
				dateTimeFormatInfo = null;
				IL_5E6:
				num2 = 67;
				Foxtable.Main.OO_O.o. = Thread.CurrentThread.ManagedThreadId;
				IL_5F8:
				num2 = 68;
				Foxtable.Main.Oo00OoO0_.o_oo.(a_2);
				IL_602:
				num2 = 69;
				Foxtable.Main.OO_O.o. = SplashFormStateEnum.Close;
				IL_60B:
				num2 = 70;
				OO_00oOO.SystemReady = true;
				IL_614:
				goto IL_782;
				IL_619:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_743:
				goto IL_777;
				IL_745:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_755:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_745;
			}
			IL_777:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_782:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x0020E8CC File Offset: 0x0020CACC
		private static void <<EMPTY_NAME>>(string A_0)
		{
			int a_ = 2;
			Control.CheckForIllegalCrossThreadCalls = false;
			Foxtable.Main.o_O.O0O0_o0_.();
			Foxtable.Main.OO_O.o. = new jk();
			Thread thread = new Thread(new ThreadStart(Foxtable.Main.OO.oo_0o0O.));
			thread.Start();
			if (Operators.CompareString(A_0, "", true) == 0)
			{
				A_0 = Foxtable.Main.o_0Oo0__.oooO0.();
				O_O0OO.o0OoO00OO.00O. = A_0;
			}
			if (Project.Open(A_0, new string[0]))
			{
				Foxtable.Main.OO_O.o. = SplashFormStateEnum.Hide;
				if (thread.ThreadState != System.Threading.ThreadState.Stopped)
				{
					thread.Abort();
				}
				if (!Foxtable.Main.OO_O.o..IsDisposed)
				{
					OO_oo0_0oo00 oo_oo0_0oo = new OO_oo0_0oo00();
					Foxtable.Main.o__O0O.0_. = oo_oo0_0oo.o00O.o0oo.();
					if ((Foxtable.Main.o__O0O.0_. <= Foxtable.Main.oo0.o0_o. && !o0OO__.O_0_O0_OO.0Ooo.()) || (oo_oo0_0oo.o00O.o0oo.() || (o_o_O0OO_0__.O0_O_o.o_.() && oo_oo0_0oo.o00O.o0oo.())) || (Foxtable.Main.o__O0O.0_. <= Foxtable.Main.O__Ooo_00O.ooO. && !o0OO__.O_0_O0_OO.0Ooo.()))
					{
						NetworkChange.NetworkAvailabilityChanged += Foxtable.Main.oO0.o0_o0o.;
						NetworkChange.NetworkAddressChanged += Foxtable.Main.oO0.o0_o0o.;
						Application.Run(Foxtable.Main.OO_O.o.);
						if (OO_00oOO.OO._ooO. != null)
						{
							OO_00oOO.OO._ooO..CloseCom();
						}
						NetworkChange.NetworkAvailabilityChanged -= Foxtable.Main.oO0.o0_o0o.;
						NetworkChange.NetworkAddressChanged -= Foxtable.Main.oO0.o0_o0o.;
						Foxtable.Main.Oo00OoO0_.o_oo.();
						if (Operators.CompareString(O_O0OO.o0OoO00OO.00O., "", true) > 0 && c.OOOOO.o.().FileSystem.FileExists(O_O0OO.o0OoO00OO.00O.))
						{
							try
							{
								c.OOOOO.o.().FileSystem.DeleteDirectory(c.OOOOO.o.().FileSystem.GetParentPath(O_O0OO.o0OoO00OO.00O.), DeleteDirectoryOption.DeleteAllContents);
							}
							catch (Exception ex)
							{
							}
						}
						OO_00oOO.Ports.Clear();
						OO_00oOO.FileWatcher.Enabled = false;
						if (Foxtable.Main.OO_O.o.)
						{
							Process.Start(Application.ExecutablePath, O00OOOo_O0_O.b("쟤", a_) + OO_00oOO.ProjectFile + O00OOOo_O0_O.b("쟤", a_));
						}
					}
				}
			}
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x0020EAD4 File Offset: 0x0020CCD4
		private static string <<EMPTY_NAME>>()
		{
			int a_ = 11;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + O00OOOo_O0_O.b("닭뛯鷱賳苵駷飹郻鯽忿嘁愃欅砇攉縋漍戏欑䠓", a_) + ShareLibriay.GetRandString(6) + O00OOOo_O0_O.b("닭", a_);
			string text2 = text + ShareLibriay.GetRandString(6) + ooO0__OO.oo.Ooo_00.();
			string text3 = O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("곭駯鳱ꣳ냵韷苹裻鿽拿渁愃⠅䨇昉洋怍笏", a_) + ooO0__OO.oo.Ooo_00.();
			c.OOOOO.o.().FileSystem.CreateDirectory(text);
			if (!OO_00oOO.FileSys.DirectoryExists(OO_00oOO.FileSys.GetParentPath(text3)))
			{
				OO_00oOO.FileSys.CreateDirectory(OO_00oOO.FileSys.GetParentPath(text3));
			}
			string text4 = O00OOOo_O0_O.b("粡﮿⾥抻閦醴鞪ꎳ䆬", a_);
			if (!OO_00oOO.FileSys.FileExists(text3))
			{
				if (!o0OoOOoOOo0.O_0_Oo_00.O.(text3))
				{
					return "";
				}
				OleDbConnection a_2 = new OleDbConnection(Oo00.o_._0OOo.(text3));
				o_oo0 o_oo = new o_oo0(a_2, false, true);
				int num = 0;
				do
				{
					if (!o_oo.o0_oo0._.().oooO__O_0o_.o_.(O00OOOo_O0_O.b("虥", a_) + Conversions.ToString(Strings.Chr(65 + num))))
					{
						o_oo.o0_oo0._.().O_.0_O__OOoOo.(O00OOOo_O0_O.b("虥", a_) + Conversions.ToString(Strings.Chr(65 + num)));
					}
					O_0O_ o_0O_ = o_oo.o0_oo0._.().O.0_O.(O00OOOo_O0_O.b("虥", a_) + Conversions.ToString(Strings.Chr(65 + num)));
					int num2 = 0;
					do
					{
						o_0O_.o_O00_.00_.().O_o0.Oo00o0.(O00OOOo_O0_O.b("슖", a_) + Conversions.ToString(text4[num2]) + O00OOOo_O0_O.b("樂", a_), ColumnDataTypeEnum.String, int.MinValue);
						num2++;
					}
					while (num2 <= 9);
					num++;
				}
				while (num <= 2);
				o_oo.o0_oo0._.(false, false);
			}
			OO_00oOO.FileSys.CopyFile(text3, text2);
			return text2;
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x0020ECE4 File Offset: 0x0020CEE4
		private static void <<EMPTY_NAME>>()
		{
			CodeDomProvider codeDomProvider = new VBCodeProvider();
			CompilerParameters options = new CompilerParameters();
			codeDomProvider.CompileAssemblyFromSource(options, new string[]
			{
				""
			});
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x0020ED14 File Offset: 0x0020CF14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void <<EMPTY_NAME>>()
		{
			int a_ = 14;
			if (Foxtable.Main.O00._O__0. != 1)
			{
				Foxtable.Main.O00._O__0. = 1;
				string text = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + O00OOOo_O0_O.b("귰냲髴駶鿸鋺髼퇾攀戂焄", a_);
				if (!c.OOOOO.o.().FileSystem.FileExists(text))
				{
					Foxtable.Main.OO_O.o. = SplashFormStateEnum.Close;
					MessageBox.Show(O00OOOo_O0_O.b("뱡鶍犑Ƹ髸铺鏼駾栀搂⬄挆栈缊B坕㥇῭Ͷኖ푤뚔㽌䖶⋝", a_), O00OOOo_O0_O.b("↓즋", a_), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.EndApp();
				}
				OleDbConnection selectConnection = new OleDbConnection(Oo00.o_._0OOo.(text));
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(O00OOOo_O0_O.b("ꋰ雲駴鋶髸迺\uddfc헾℀䔂眄栆搈⬊嘌焎䔐帒䔔吖唘䬚帜瀞传䔢䰤䀦琨", a_), selectConnection);
				oleDbDataAdapter.FillSchema(O_O0OO.O0_00o.o0__o., SchemaType.Source);
				oleDbDataAdapter.Fill(O_O0OO.O0_00o.o0__o.);
				o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
				O_O0OO.O0_00o.o0__o..ExtendedProperties.Add(O00OOOo_O0_O.b("뗰鋲致零룸鿺鳼迾甀昂眄", a_), oleDbDataAdapter);
				DataRow dataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("ꏰ雲雴鋶韸迺민雾洀昂瘄", a_));
				if (dataRow != null)
				{
					if (dataRow.IsNull(O00OOOo_O0_O.b("닰鳲鯴釶郸鳺", a_)))
					{
						return;
					}
					foreach (string item in Conversions.ToString(dataRow[O00OOOo_O0_O.b("닰鳲鯴釶郸鳺", a_)]).Split(new char[]
					{
						'\t'
					}, StringSplitOptions.RemoveEmptyEntries))
					{
						O_O0OO.o0OoO00OO.00O..Add(item);
					}
				}
				if (O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("런鳲跴菶飸駺釼髾", a_)) == null)
				{
					Foxtable.Main.OO_O.o. = SplashFormStateEnum.Close;
					MessageBox.Show(O00OOOo_O0_O.b("ᆕ뮗롥馉纝පﰃ", a_), O00OOOo_O0_O.b("↓즋", a_), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				string right = O00OOOo_O0_O.b("쏰\udff2", a_) + OO_00oOO.ApplicationVertion();
				dataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("뗰鳲髴郶闸黺", a_));
				if (Operators.CompareString(dataRow[O00OOOo_O0_O.b("닰鳲鯴釶郸鳺", a_)].ToString(), right, true) != 0)
				{
					Foxtable.Main.OO_O.o. = SplashFormStateEnum.Hide;
					MessageBox.Show(O00OOOo_O0_O.b("ᆕ뮗롥馉纝පﰃ", a_), O00OOOo_O0_O.b("↓즋", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					ProjectData.EndApp();
				}
				dataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("ꗰ鯲郴髶鳸듺跼课栀氂欄理", a_));
				if (dataRow != null && !dataRow.IsNull(O00OOOo_O0_O.b("닰鳲鯴釶郸鳺", a_)))
				{
					string[] array2 = dataRow[O00OOOo_O0_O.b("닰鳲鯴釶郸鳺", a_)].ToString().Split(new char[]
					{
						'\v'
					});
					if (array2.Length >= 5)
					{
						O_O0OO.O_.00. = array2[0];
						O_O0OO.Oo._00O0_oO. = array2[1];
						O_O0OO.o_.oO_O0. = array2[2];
						O_O0OO.oo_oo_o._. = array2[3];
						if (!int.TryParse(array2[4], out O_O0OO.oO_00Ooo___0._.))
						{
							O_O0OO.oO_00Ooo___0._. = 9;
						}
					}
					if (array2.Length >= 8)
					{
						ColorConverter colorConverter = new ColorConverter();
						O_O0OO.o0O._O00o. = Conversions.ToBoolean(array2[5]);
						object obj = colorConverter.ConvertFrom(array2[6]);
						O_O0OO.O0_00o.o0__o. = ((obj != null) ? ((Color)obj) : default(Color));
						object obj2 = colorConverter.ConvertFrom(array2[7]);
						O_O0OO.oo0_o_.o. = ((obj2 != null) ? ((Color)obj2) : default(Color));
					}
				}
			}
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x0020F074 File Offset: 0x0020D274
		internal static void <<EMPTY_NAME>>(string A_0)
		{
			int a_ = 17;
			CatalogClass catalogClass = new CatalogClass();
			((_Catalog)catalogClass).Create(Oo00.o00.0OO.(A_0));
			ADOX.Table table = new TableClass();
			Index index = new IndexClass();
			table.Name = O00OOOo_O0_O.b("諳ꋵ뗷꫹뿻닽僿䄁欃栅渇按欋", a_);
			table.Columns.Append(O00OOOo_O0_O.b("뫳韵闷鿹", a_), ADOX.DataTypeEnum.adVarWChar, 64);
			table.Columns.Append(O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
			table.Columns[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].Attributes = ColumnAttributesEnum.adColNullable;
			index.Name = O00OOOo_O0_O.b("ꓳ蓵釷韹鷻賽秿䤁愃缅", a_);
			index.Columns.Append(O00OOOo_O0_O.b("뫳韵闷鿹", a_), ADOX.DataTypeEnum.adVarWChar, 0);
			index.PrimaryKey = true;
			index.Unique = true;
			table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
			((_Catalog)catalogClass).Tables.Append(table);
			((Connection)((_Catalog)catalogClass).ActiveConnection).Close();
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x0020F18C File Offset: 0x0020D38C
		internal static void <<EMPTY_NAME>>()
		{
			int a_ = 2;
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) != 0)
			{
				if (O_O0OO.o0OoO00OO.00O..Contains(OO_00oOO.ProjectFile))
				{
					O_O0OO.o0OoO00OO.00O..Remove(OO_00oOO.ProjectFile);
				}
				O_O0OO.o0OoO00OO.00O..Insert(0, OO_00oOO.ProjectFile);
			}
			RibbonItemCollection rightPaneItems = Foxtable.Main.OO_O.o..O.OOO0_OOo.().ApplicationMenu.RightPaneItems;
			for (int i = rightPaneItems.Count - 1; i >= 0; i += -1)
			{
				if (rightPaneItems[i].Tag != null && Operators.CompareString(Conversions.ToString(rightPaneItems[i].Tag), O00OOOo_O0_O.b("럤苦諨軪菬鯮런髲駴鋶", a_), true) == 0)
				{
					rightPaneItems.RemoveAt(i);
				}
			}
			int num = Math.Min(O_O0OO.o0OoO00OO.00O., O_O0OO.o0OoO00OO.00O..Count) - 1;
			for (int j = 0; j <= num; j++)
			{
				RibbonListItem ribbonListItem = new RibbonListItem();
				RibbonButton ribbonButton = new RibbonButton();
				ribbonButton.Name = O00OOOo_O0_O.b("럤苦諨軪菬鯮런髲駴鋶", a_) + Conversions.ToString(j);
				ribbonButton.Text = Conversions.ToString(j + 1) + O00OOOo_O0_O.b("쯤쟦", a_) + c.OOOOO.o.().FileSystem.GetName(O_O0OO.o0OoO00OO.00O.[j]);
				ribbonButton.ToolTip = O_O0OO.o0OoO00OO.00O.[j];
				ribbonListItem.Tag = O00OOOo_O0_O.b("럤苦諨軪菬鯮런髲駴鋶", a_);
				ribbonListItem.Items.Add(ribbonButton);
				ribbonListItem.Click += Foxtable.Main.o_0.O0oO_O0_.;
				Foxtable.Main.OO_O.o..O.OOO0_OOo.().ApplicationMenu.RightPaneItems.Add(ribbonListItem);
			}
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x0020F344 File Offset: 0x0020D544
		private static void <<EMPTY_NAME>>()
		{
			int a_ = 19;
			string text = "";
			DataRow dataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("ꓵ鷷駹駻都瓿䐁洃樅洇礉", a_));
			if (dataRow == null)
			{
				dataRow = O_O0OO.O0_00o.o0__o..NewRow();
				dataRow[O00OOOo_O0_O.b("룵駷韹駻", a_)] = O00OOOo_O0_O.b("ꓵ鷷駹駻都瓿䐁洃樅洇礉", a_);
				O_O0OO.O0_00o.o0__o..Rows.Add(dataRow);
			}
			try
			{
				foreach (string str in O_O0OO.o0OoO00OO.00O.)
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += O00OOOo_O0_O.b("￵", a_);
					}
					text += str;
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			dataRow[O00OOOo_O0_O.b("뗵韷铹髻韽柿", a_)] = text;
			Oo00.o0_o._O_.(O_O0OO.O0_00o.o0__o., true);
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x0020F44C File Offset: 0x0020D64C
		private static void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int a_ = 7;
			RibbonButton ribbonButton = (RibbonButton)((RibbonListItem)A_0).Items[0];
			if (c.OOOOO.o.().FileSystem.FileExists(ribbonButton.ToolTip))
			{
				Project.Open(ribbonButton.ToolTip, new string[0]);
			}
			else
			{
				MessageBox.Show(O00OOOo_O0_O.b("涌᪥ꢴ\udaa6", a_), O00OOOo_O0_O.b("㪊횒", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				O_O0OO.o0OoO00OO.00O..Remove(ribbonButton.ToolTip);
				Foxtable.Main.O0O_.00_O0Oo_.();
			}
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x0020F4E3 File Offset: 0x0020D6E3
		private static void <<EMPTY_NAME>>()
		{
			new o\u30000\u3000\u3000\u3002O().ShowDialog();
			do
			{
				Thread.Sleep(500);
			}
			while (!OO_00oOO.SystemReady);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x0020F504 File Offset: 0x0020D704
		internal static void <<EMPTY_NAME>>(string A_0)
		{
			int a_ = 12;
			if (OO_00oOO.FileSys.DirectoryExists(A_0))
			{
				if (!OO_00oOO.FileSys.FileExists(A_0 + O00OOOo_O0_O.b("맮铰臲蛴黶雸闺폼课礀眂", a_)))
				{
					OO_00oOO.FileSys.DeleteDirectory(A_0, DeleteDirectoryOption.DeleteAllContents);
				}
				else
				{
					string right = OO_00oOO.FileSys.ReadAllText(A_0 + O00OOOo_O0_O.b("맮铰臲蛴黶雸闺폼课礀眂", a_));
					if (Operators.CompareString(OO_00oOO.ApplicationVertion(), right, true) != 0)
					{
						OO_00oOO.FileSys.DeleteDirectory(A_0, DeleteDirectoryOption.DeleteAllContents);
					}
				}
			}
			if (!OO_00oOO.FileSys.DirectoryExists(A_0))
			{
				OO_00oOO.FileSys.CreateDirectory(A_0);
				OO_00oOO.FileSys.WriteAllText(A_0 + O00OOOo_O0_O.b("맮铰臲蛴黶雸闺폼课礀眂", a_), OO_00oOO.ApplicationVertion(), false);
			}
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x0020F5CC File Offset: 0x0020D7CC
		private static Assembly <<EMPTY_NAME>>(object A_0, ResolveEventArgs A_1)
		{
			int a_ = 7;
			if (O_O0OO.OoO.0OO__0ooo.() != null && Operators.CompareString(O_O0OO.O_O._Oo.(), "", true) > 0 && A_1.Name.StartsWith(o0OoOOoOOo0.oo00o.0OoO.("") + O00OOOo_O0_O.b("쓩볫鯭鋯黱鷳闵퓷", a_), StringComparison.CurrentCultureIgnoreCase))
			{
				string text = OO_00oOO.ProjectPath + O00OOOo_O0_O.b("뛩껫蟭黯껱", a_) + o0OoOOoOOo0.oo00o.0OoO.("") + O00OOOo_O0_O.b("쓩볫鯭鋯黱鷳闵훷黹郻鋽", a_);
				if (OO_00oOO.FileSys.FileExists(text))
				{
					return Assembly.Load(File.ReadAllBytes(text));
				}
			}
			else if (Operators.CompareString(o0OoOOoOOo0.o___O0.O00., "", true) > 0 && A_1.Name.StartsWith(o0OoOOoOOo0.oo00o.0OoO.(o0OoOOoOOo0.O.0_0ooo0O.) + O00OOOo_O0_O.b("쓩볫鯭鋯黱鷳闵퓷", a_), StringComparison.CurrentCultureIgnoreCase))
			{
				string text2 = OO_00oOO.FileSys.GetParentPath(o0OoOOoOOo0.O.0_0ooo0O.) + O00OOOo_O0_O.b("뛩껫蟭黯껱", a_) + o0OoOOoOOo0.oo00o.0OoO.(o0OoOOoOOo0.O.0_0ooo0O.) + O00OOOo_O0_O.b("쓩볫鯭鋯黱鷳闵훷黹郻鋽", a_);
				if (OO_00oOO.FileSys.FileExists(text2))
				{
					return Assembly.Load(File.ReadAllBytes(text2));
				}
			}
			if (o0OoOOoOOo0.o00__oo.O0Oo0o. == null)
			{
				o0OoOOoOOo0.o00__oo.O0Oo0o. = RuntimeHelpers.GetObjectValue(A_0);
			}
			return null;
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x0020F728 File Offset: 0x0020D928
		private static void <<EMPTY_NAME>>(object A_0, NetworkAvailabilityEventArgs A_1)
		{
			if (OO_00oOO.SystemReady && Foxtable.Main.OO_O.o. != null && !Foxtable.Main.OO_O.o..IsDisposed)
			{
				Foxtable.Main.OO_O.o..Invoke(new Main.O0OoooO0Oo_O_(Foxtable.Main.o_0Oo0__.oooO0.), new object[]
				{
					A_1.IsAvailable
				});
			}
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x0020F77A File Offset: 0x0020D97A
		private static void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.SystemReady && OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				Foxtable.Main.OO_O.o..Invoke(new Main.O0_00__(Foxtable.Main.o_0Oo0__.oooO0.));
			}
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x0020F7B0 File Offset: 0x0020D9B0
		private static void <<EMPTY_NAME>>(bool A_0)
		{
			int a_ = 13;
			try
			{
				foreach (IMClient imclient in OO_00oOO.IMClients.Values)
				{
					if (!imclient.O0_OOo.O. && imclient.Ready)
					{
						Control control = new oO\u3000\u3002\u3002\u3000O\u3000(imclient, imclient.ooOo.oO0.);
						imclient.Stop();
						control.Show();
					}
				}
			}
			finally
			{
				Dictionary<string, IMClient>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			NetworkAvailabilityEventArgs networkAvailabilityEventArgs = new NetworkAvailabilityEventArgs(A_0);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., O00OOOo_O0_O.b("뻯韱胳臵韷裹韻뿽盿持洃樅椇栉攋戍礏昑洓唕瀗笙爛礝䔟䘡", a_), new object[]
			{
				networkAvailabilityEventArgs
			}, false, O00OOOo_O0_O.b("襷ᲇ", a_), false);
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x0020F86C File Offset: 0x0020DA6C
		private static void <<EMPTY_NAME>>()
		{
			int a_ = 14;
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., O00OOOo_O0_O.b("뿰雲致胶雸觺雼뻾攀朂眄戆稈砊丌朎瀐紒爔爖紘", a_), null, false, O00OOOo_O0_O.b("表ᶄ", a_), false);
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x0020F8AC File Offset: 0x0020DAAC
		internal static bool <<EMPTY_NAME>>(object A_0, X509Certificate A_1, X509Chain A_2, SslPolicyErrors A_3)
		{
			return true;
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x0020F8B0 File Offset: 0x0020DAB0
		private static void <<EMPTY_NAME>>(object A_0, DoWorkEventArgs A_1)
		{
			int a_ = 19;
			IProjectAssembly service = new VBSyntaxLanguage().GetService<IProjectAssembly>();
			service.AssemblyReferences.AddMsCorLib();
			service.AssemblyReferences.Add(O00OOOo_O0_O.b("ꗵ臷觹裻鯽淿", a_));
			foreach (string text in SysInfo.referFiles.Split(new char[]
			{
				'\n',
				'\r'
			}, StringSplitOptions.RemoveEmptyEntries))
			{
				text = Path.GetFileNameWithoutExtension(text);
				if (service.AssemblyReferences.Add(text) == null)
				{
					service.AssemblyReferences.Add(Assembly.LoadWithPartialName(text));
				}
			}
			service.AssemblyReferences.Clear();
			GC.Collect();
			GC.Collect();
		}

		// Token: 0x04001E30 RID: 7728
		internal static jk <<EMPTY_NAME>>;

		// Token: 0x04001E31 RID: 7729
		internal static string <<EMPTY_NAME>>;

		// Token: 0x04001E32 RID: 7730
		internal static SplashFormStateEnum <<EMPTY_NAME>>;

		// Token: 0x04001E33 RID: 7731
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x04001E34 RID: 7732
		internal static int <<EMPTY_NAME>>;

		// Token: 0x04001E35 RID: 7733
		private static o\u3000\u3002\u3002\u3002\u3002 <<EMPTY_NAME>>;

		// Token: 0x04001E36 RID: 7734
		private static int <<EMPTY_NAME>>;

		// Token: 0x04001E37 RID: 7735
		private static int <<EMPTY_NAME>>;

		// Token: 0x04001E38 RID: 7736
		private static int <<EMPTY_NAME>>;

		// Token: 0x04001E39 RID: 7737
		private static string <<EMPTY_NAME>>;

		// Token: 0x04001E3A RID: 7738
		private static int <<EMPTY_NAME>>;

		// Token: 0x02000451 RID: 1105
		// (Invoke) Token: 0x06004A6B RID: 19051
		public delegate void O0OoooO0Oo_O_(bool A_0);

		// Token: 0x02000452 RID: 1106
		// (Invoke) Token: 0x06004A6F RID: 19055
		public delegate void O0_00__();
	}
}
