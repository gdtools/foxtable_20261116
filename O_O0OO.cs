using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Preview;
using C1.Win.C1Ribbon;
using Foxtable.My;
using Foxtable.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using Office2007Renderer;

namespace Foxtable
{
	// Token: 0x020004E2 RID: 1250
	[StandardModule]
	internal sealed class O_O0OO
	{
		// Token: 0x060051BD RID: 20925 RVA: 0x00246028 File Offset: 0x00244228
		internal static string <<EMPTY_NAME>>()
		{
			int a_ = 0;
			if (Operators.CompareString(O_O0OO.OoOO0oO00.00_o., "", true) == 0)
			{
				O_O0OO.OoOO0oO00.00_o. = O00.DecryptText(O_O0OO.o0O0o.Oo_o00o., O00OOOo_O0_O.b("藢諤鿦", a_), O00OOOo_O0_O.b("韢蓤藦藨軪", a_));
			}
			return O_O0OO.OoOO0oO00.00_o.;
		}

		// Token: 0x060051BE RID: 20926
		[DllImport("Interop.ADOSC.dll")]
		private static extern int FindPort_2(int A_0, int A_1, int A_2, StringBuilder A_3);

		// Token: 0x060051BF RID: 20927
		[DllImport("Interop.ADOSC.dll")]
		private static extern int EncString(string A_0, StringBuilder A_1, string A_2);

		// Token: 0x060051C0 RID: 20928
		[DllImport("Interop.ADOSC.dll")]
		private static extern int GetID(ref int A_0, ref int A_1, string A_2);

		// Token: 0x060051C1 RID: 20929
		[DllImport("Interop.ADOSC.dll")]
		private static extern int YRead(ref byte A_0, short A_1, short A_2, string A_3, string A_4, string A_5);

		// Token: 0x060051C2 RID: 20930 RVA: 0x00246080 File Offset: 0x00244280
		static O_O0OO()
		{
			int a_ = 12;
			O_O0OO.Oo0.OoOo. = new List<O_0>();
			O_O0OO.Oo0.OoOo. = new Dictionary<string, o__o_OO_o_>();
			O_O0OO.OOo_o.0o. = true;
			O_O0OO.O_OO.OO. = true;
			O_O0OO.O0_00o.o0__o. = new ProjectProperty();
			O_O0OO.o.0__0_O_. = Foxtable.My.Resources.a.ooO_.O0.().ToBitmap();
			O_O0OO.O_O00OOooo.O_. = Foxtable.My.Resources.a.ooO.Oo.().ToBitmap();
			O_O0OO.O0OO_.0. = false;
			O_O0OO.O0_00o.o0__o. = new DataTable();
			O_O0OO.o0OoO00OO.00O. = new List<string>();
			O_O0OO.o_Oo0_oOo.0. = true;
			O_O0OO.Oo_o000oO.oO. = O00OOOo_O0_O.b("ꫮ쓰쫲쏴돶샸췺쓼뫾㤀䔂㜄㜆㨈㼊伌㼎ℐ", a_);
			O_O0OO.oO_00Ooo___0._. = new List<string>();
			O_O0OO.o_Oo0_oOo.0. = O00OOOo_O0_O.b("ꃮ蓰蟲郴藶곸裺飼跾䔀戂焄昆崈樊漌挎琐", a_);
			O_O0OO.oO__._0_0O0o0. = O00OOOo_O0_O.b("苮闰웲", a_);
			O_O0OO.OO.o_. = O00OOOo_O0_O.b("问맰蟲ꗴ蛶샸꣺민퓾最䰂䄄⠆㠈䔊県導刐紒℔搖䠘☚“", a_);
			O_O0OO.O00O0o_O_._O. = true;
			O_O0OO.O0_00o.o0__o. = new Dictionary<string, Bitmap>();
			O_O0OO.O0_00o.o0__o. = Foxtable.My.Resources.a.o_OOo0O._0o.().ToBitmap();
			O_O0OO.O_oO_o0O.o__. = false;
			O_O0OO.O_.00. = O00OOOo_O0_O.b("ꃮ韰闲鳴银鳸짺췼컾㈀䐂眄戆氈攊", a_);
			O_O0OO.Oo._00O0_oO. = O00OOOo_O0_O.b("ꃮ韰闲鳴银鳸짺췼컾㈀䐂眄戆氈攊", a_);
			O_O0OO.o_.oO_O0. = O00OOOo_O0_O.b("맮ꋰ쇲열웶쫸볺迼髾搀洂", a_);
			O_O0OO.oo_oo_o._. = O00OOOo_O0_O.b("撵ꊿ", a_);
			O_O0OO.oO_00Ooo___0._. = 9;
			O_O0OO.O0_00o.o0__o. = Color.Transparent;
			O_O0OO.oo0_o_.o. = Color.Transparent;
			O_O0OO.o0O._O00o. = false;
			O_O0OO.o0OoO00OO.00O. = new oOo_00o0o00_0();
			O_O0OO.ooO0oO0O.o_O_. = O00OOOo_O0_O.b("鳮裰胲鋴藶鷸迺迼髾搀瀂樄甆紈", a_);
			O_O0OO.OoO._oO0. = O00OOOo_O0_O.b("ꫮ觰郲郴鯶꫸迺飼", a_);
			O_O0OO.o0O0o.Oo_o00o. = O00OOOo_O0_O.b("뗮뛰싲\udaf4ꏶ臸铺뗼탾唀樂欄䘆紈䘊㔌堎嘐甒瘔䴖弘业洜刞䘠刢氤縦ᰨ䘪樬", a_);
			O_O0OO.OoOO0oO00.00_o. = "";
			O_O0OO.oO_00Ooo___0._. = "";
			o_O_o_oOoo__.Oo_0.OOo0oO0..AddRange(new string[]
			{
				ooO0__OO.OOo0._00O_o00.(),
				ooO0__OO.o0O._ooo_O_.(),
				ooO0__OO.O_O00.0_.(),
				ooO0__OO.O0.ooO0O.(),
				ooO0__OO.o0o.o.(),
				ooO0__OO.O0O.0o0.(),
				ooO0__OO.oo._o.(),
				ooO0__OO.O0_.OOo0OO.(),
				ooO0__OO.o_0_000._O.(),
				ooO0__OO.O00.O__o.(),
				ooO0__OO.Oo0o0.oo_0.(),
				ooO0__OO.oo._O.(),
				ooO0__OO.o.00_0o0__OoO.()
			});
			o_O_o_oOoo__.oO.O_..AddRange(new string[]
			{
				O00OOOo_O0_O.b("냮룰韲郴駶跸鋺鯼蛾", a_),
				O00OOOo_O0_O.b("냮뷰鳲雴鳶鳸鿺", a_),
				O00OOOo_O0_O.b("볮裰胲致鋶铸ꓺ껼郾猀眂娄匆氈昊紌怎挐爒朔渖", a_),
				O00OOOo_O0_O.b("볮裰胲致鋶铸ꓺ민雾洀眂怄甆嘈弊栌戎愐簒朔瘖欘戚", a_),
				O00OOOo_O0_O.b("볮裰胲致鋶铸ꓺ민雾洀眂怄甆嘈帊挌明怐昒瀔", a_),
				O00OOOo_O0_O.b("냮ꋰ鳲蟴菶닸黺蓼", a_),
				O00OOOo_O0_O.b("鳮裰胲ꫴ뿶郸黺迼黾猀怂洄縆嘈䜊栌礎琐缒", a_)
			});
			O_O0OO.OOo_o.0o. = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + O00OOOo_O0_O.b("돮룰黲铴郶鳸裺ꇼ", a_);
			OO_00oOO.Vars.o.O0o_O.(O00OOOo_O0_O.b("볮裰胲ꃴ蟶鷸髺觼髾儀焂氄椆紈䈊挌椎縐", a_), typeof(bool), true);
			OO_00oOO.Vars.o.O0o_O.(O00OOOo_O0_O.b("볮裰胲ꃴ蟶鷸髺觼髾䀀搂戄甆氈氊氌笎琐", a_), typeof(bool), false);
			OO_00oOO.Vars.o.O0o_O.(O00OOOo_O0_O.b("볮裰胲뛴飶铸诺鳼课栀戂朄欆氈䈊怌樎尐簒焔爖", a_), typeof(bool), false);
			o0OoOOoOOo0.O_00o0.O0OO_0. = O00.oO_.0o_oo_0O_.(SysInfo.ConnectName, O00OOOo_O0_O.b("诮郰蟲铴", a_), O00OOOo_O0_O.b("鯮郰釲駴鋶", a_)).Split(new char[]
			{
				'.'
			});
			o0OoOOoOOo0.O_00o0.O0OO_0. = new object[]
			{
				0,
				888,
				Conversions.ToInteger(O00.oO_.0o_oo_0O_.(SysInfo.ConnectType, O00OOOo_O0_O.b("诮郰蟲铴", a_), O00OOOo_O0_O.b("鯮郰釲駴鋶", a_))),
				o0OoOOoOOo0.o0O.0_.
			};
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x0024647C File Offset: 0x0024467C
		internal static string <<EMPTY_NAME>>()
		{
			int a_ = 19;
			return c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + O00OOOo_O0_O.b("ꫵ请菹迻諽旿漁", a_) + ooO0__OO.o_0O._OO__.();
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x002464C0 File Offset: 0x002446C0
		internal static O0OO_oo0o <<EMPTY_NAME>>()
		{
			if (O_O0OO.o.O___o00o0O. == null)
			{
				O_O0OO.o.O___o00o0O. = new O0OO_oo0o();
			}
			else if (O_O0OO.o.O___o00o0O..Disposing || O_O0OO.o.O___o00o0O..IsDisposed)
			{
				O_O0OO.o.O___o00o0O. = new O0OO_oo0o();
			}
			return O_O0OO.o.O___o00o0O.;
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x002464FC File Offset: 0x002446FC
		internal static void <<EMPTY_NAME>>(O0OO_oo0o A_0)
		{
			O_O0OO.o.O___o00o0O. = A_0;
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x00246504 File Offset: 0x00244704
		internal static Oooo <<EMPTY_NAME>>()
		{
			if (O_O0OO.OoO_0.OoO. == null)
			{
				O_O0OO.OoO_0.OoO. = new Oooo();
			}
			else if (O_O0OO.OoO_0.OoO..Disposing || O_O0OO.OoO_0.OoO..IsDisposed)
			{
				O_O0OO.OoO_0.OoO. = new Oooo();
			}
			return O_O0OO.OoO_0.OoO.;
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x00246540 File Offset: 0x00244740
		internal static o__o_O_o0o0__ <<EMPTY_NAME>>()
		{
			if (O_O0OO.o.O___o00o0O. == null)
			{
				O_O0OO.o.O___o00o0O. = new o__o_O_o0o0__();
			}
			else if (O_O0OO.o.O___o00o0O..Disposing || O_O0OO.o.O___o00o0O..IsDisposed)
			{
				O_O0OO.o.O___o00o0O. = new o__o_O_o0o0__();
			}
			return O_O0OO.o.O___o00o0O.;
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x0024657C File Offset: 0x0024477C
		internal static void <<EMPTY_NAME>>(o__o_O_o0o0__ A_0)
		{
			O_O0OO.o.O___o00o0O. = A_0;
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x00246584 File Offset: 0x00244784
		internal static O0_oOoo <<EMPTY_NAME>>()
		{
			if (O_O0OO.OoO_0.OoO. == null)
			{
				O_O0OO.OoO_0.OoO. = new O0_oOoo();
			}
			else if (O_O0OO.OoO_0.OoO..Disposing || O_O0OO.OoO_0.OoO..IsDisposed)
			{
				O_O0OO.OoO_0.OoO. = new O0_oOoo();
			}
			return O_O0OO.OoO_0.OoO.;
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x002465C0 File Offset: 0x002447C0
		internal static OOoOO_00O00 <<EMPTY_NAME>>()
		{
			if (O_O0OO.o.O___o00o0O. == null)
			{
				O_O0OO.o.O___o00o0O. = new OOoOO_00O00();
			}
			else if (O_O0OO.o.O___o00o0O..Disposing || O_O0OO.o.O___o00o0O..IsDisposed)
			{
				O_O0OO.o.O___o00o0O. = new OOoOO_00O00();
			}
			return O_O0OO.o.O___o00o0O.;
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x002465FC File Offset: 0x002447FC
		internal static void <<EMPTY_NAME>>(OOoOO_00O00 A_0)
		{
			O_O0OO.o.O___o00o0O. = A_0;
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x00246604 File Offset: 0x00244804
		internal static Ooo0__ <<EMPTY_NAME>>()
		{
			if (O_O0OO.OoO_0.OoO. == null)
			{
				O_O0OO.OoO_0.OoO. = new Ooo0__();
			}
			else if (O_O0OO.OoO_0.OoO..Disposing || O_O0OO.OoO_0.OoO..IsDisposed)
			{
				O_O0OO.OoO_0.OoO. = new Ooo0__();
			}
			return O_O0OO.OoO_0.OoO.;
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x00246640 File Offset: 0x00244840
		internal static OO__oo_0ooo0_ <<EMPTY_NAME>>()
		{
			if (O_O0OO.o.O___o00o0O. == null)
			{
				O_O0OO.o.O___o00o0O. = new OO__oo_0ooo0_();
			}
			else if (O_O0OO.o.O___o00o0O..Disposing || O_O0OO.o.O___o00o0O..IsDisposed)
			{
				O_O0OO.o.O___o00o0O. = new OO__oo_0ooo0_();
			}
			return O_O0OO.o.O___o00o0O.;
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x0024667C File Offset: 0x0024487C
		internal static void <<EMPTY_NAME>>(OO__oo_0ooo0_ A_0)
		{
			O_O0OO.o.O___o00o0O. = A_0;
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x00246684 File Offset: 0x00244884
		internal static oo0O0o___O <<EMPTY_NAME>>()
		{
			if (O_O0OO.OoO_0.OoO. == null)
			{
				O_O0OO.OoO_0.OoO. = new oo0O0o___O();
			}
			else if (O_O0OO.OoO_0.OoO..Disposing || O_O0OO.OoO_0.OoO..IsDisposed)
			{
				O_O0OO.OoO_0.OoO. = new oo0O0o___O();
			}
			return O_O0OO.OoO_0.OoO.;
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x002466C0 File Offset: 0x002448C0
		internal static o0o0OO <<EMPTY_NAME>>()
		{
			if (O_O0OO.OoO_0.OoO. == null)
			{
				O_O0OO.OoO_0.OoO. = new o0o0OO();
			}
			else if (O_O0OO.OoO_0.OoO..Disposing || O_O0OO.OoO_0.OoO..IsDisposed)
			{
				O_O0OO.OoO_0.OoO. = new o0o0OO();
			}
			return O_O0OO.OoO_0.OoO.;
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x002466FC File Offset: 0x002448FC
		internal static O0OooO0_0O <<EMPTY_NAME>>()
		{
			if (O_O0OO.o.O___o00o0O. == null)
			{
				O_O0OO.o.O___o00o0O. = new O0OooO0_0O();
			}
			else if (O_O0OO.o.O___o00o0O..Disposing || O_O0OO.o.O___o00o0O..IsDisposed)
			{
				O_O0OO.o.O___o00o0O. = new O0OooO0_0O();
			}
			return O_O0OO.o.O___o00o0O.;
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x00246738 File Offset: 0x00244938
		internal static O0o__o0_o0 <<EMPTY_NAME>>()
		{
			if (O_O0OO.OoO_0.OoO. == null)
			{
				O_O0OO.OoO_0.OoO. = new O0o__o0_o0();
			}
			else if (O_O0OO.OoO_0.OoO..Disposing || O_O0OO.OoO_0.OoO..IsDisposed)
			{
				O_O0OO.OoO_0.OoO. = new O0o__o0_o0();
			}
			return O_O0OO.OoO_0.OoO.;
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x00246774 File Offset: 0x00244974
		internal static OleDbConnection <<EMPTY_NAME>>()
		{
			return O_O0OO.OoO_0.OoO.;
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x0024677B File Offset: 0x0024497B
		internal static void <<EMPTY_NAME>>(OleDbConnection A_0)
		{
			O_O0OO.OoO_0.OoO. = A_0;
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x00246783 File Offset: 0x00244983
		internal static DataSet <<EMPTY_NAME>>()
		{
			return O_O0OO.Oo0.OoOo.;
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x0024678A File Offset: 0x0024498A
		internal static void <<EMPTY_NAME>>(DataSet A_0)
		{
			O_O0OO.Oo0.OoOo. = A_0;
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x00246792 File Offset: 0x00244992
		internal static DataSet <<EMPTY_NAME>>()
		{
			return O_O0OO.O__O.oo.;
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x00246799 File Offset: 0x00244999
		internal static void <<EMPTY_NAME>>(DataSet A_0)
		{
			O_O0OO.O__O.oo. = A_0;
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x002467A1 File Offset: 0x002449A1
		internal static Dictionary<string, O_0> <<EMPTY_NAME>>()
		{
			return O_O0OO.OoO_0.OoO.;
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x002467A8 File Offset: 0x002449A8
		internal static void <<EMPTY_NAME>>(Dictionary<string, O_0> A_0)
		{
			O_O0OO.OoO_0.OoO. = A_0;
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x002467B0 File Offset: 0x002449B0
		internal static List<O_0> <<EMPTY_NAME>>()
		{
			return O_O0OO.Oo0.OoOo.;
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x002467B7 File Offset: 0x002449B7
		internal static void <<EMPTY_NAME>>(List<O_0> A_0)
		{
			O_O0OO.Oo0.OoOo. = A_0;
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x002467BF File Offset: 0x002449BF
		internal static Dictionary<string, OleDbConnection> <<EMPTY_NAME>>()
		{
			return O_O0OO.o.O___o00o0O.;
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x002467C6 File Offset: 0x002449C6
		internal static void <<EMPTY_NAME>>(Dictionary<string, OleDbConnection> A_0)
		{
			O_O0OO.o.O___o00o0O. = A_0;
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x002467CE File Offset: 0x002449CE
		internal static Dictionary<string, O_0oOo_OO> <<EMPTY_NAME>>()
		{
			return O_O0OO.o.O___o00o0O.;
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x002467D5 File Offset: 0x002449D5
		internal static void <<EMPTY_NAME>>(Dictionary<string, O_0oOo_OO> A_0)
		{
			O_O0OO.o.O___o00o0O. = A_0;
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x002467DD File Offset: 0x002449DD
		internal static Dictionary<string, O0O> <<EMPTY_NAME>>()
		{
			return O_O0OO.OoO_0.OoO.;
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x002467E4 File Offset: 0x002449E4
		internal static void <<EMPTY_NAME>>(Dictionary<string, O0O> A_0)
		{
			O_O0OO.OoO_0.OoO. = A_0;
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x002467EC File Offset: 0x002449EC
		internal static string <<EMPTY_NAME>>()
		{
			return O_O0OO.o0_OO.000.(O_O0OO.OoO.0OO__0ooo.());
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x002467F8 File Offset: 0x002449F8
		internal static string <<EMPTY_NAME>>(DataSet A_0)
		{
			int a_ = 18;
			DataRow dataRow = A_0.Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
			{
				O00OOOo_O0_O.b("ꗴ藶雸釺飼鳾甀䨂愄戆月缊搌椎栐", a_),
				o0_O.O_oo00.o0.
			});
			string result;
			if (dataRow != null)
			{
				result = Conversions.ToString(dataRow[O00OOOo_O0_O.b("뛴飶韸鷺铼飾", a_)]);
			}
			else
			{
				result = ooO0__OO.OOo0._00O_o00.();
			}
			return result;
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x0024686F File Offset: 0x00244A6F
		internal static Dictionary<string, o__o_OO_o_> <<EMPTY_NAME>>()
		{
			return O_O0OO.Oo0.OoOo.;
		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x00246878 File Offset: 0x00244A78
		internal static ImageList <<EMPTY_NAME>>()
		{
			int a_ = 2;
			if (O_O0OO.o.O___o00o0O. == null)
			{
				O_O0OO.o.O___o00o0O. = new ImageList();
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꧤ蛦诨軪臬", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꧤ蛦诨軪臬쇮飰郲髴", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦藨蓪鿬ꏮ郰釲郴鯶", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꛤ裦藨蓪鿬ꏮ郰釲郴鯶ퟸ鋺黼郾", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("꟤鋦鷨鿪苬臮", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("꟤鋦鷨鿪苬臮\udff0髲雴飶", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뇤苦釨鿪꿬胮觰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뇤苦釨鿪꿬胮觰\uddf2鳴银雸", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뇤軦蓨軪뻬鿮郰鷲럴飶臸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뇤軦蓨軪뻬鿮郰鷲럴飶臸헺铼鳾渀", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ迦賨裪蛬귮黰诲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꛤ迦賨裪蛬귮黰诲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("럤蛦跨苪苬귮蓰蟲致飶韸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("럤蛦跨苪苬귮蓰蟲致飶韸헺铼鳾渀", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨觪苬귮黰诲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꛤ裦蓨觪苬귮黰诲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ迦賨裪蛬諮闰냲髴髶鯸铺뿼郾礀", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꛤ迦賨裪蛬諮闰냲髴髶鯸铺뿼郾礀ⴂ氄搆昈", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꇤ闦蛨鯪ꧬ胮蛰鷲럴飶臸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꇤ闦蛨鯪ꧬ胮蛰鷲럴飶臸헺铼鳾渀", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꧤ軦髨鿪꿬胮觰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꧤ軦髨鿪꿬胮觰\uddf2鳴银雸", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꋤ闦蛨黪鷬귮黰诲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꋤ闦蛨黪鷬귮黰诲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뗤蛦蟨軪臬", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뗤蛦蟨軪臬쇮飰郲髴", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뇤蛦诨꣪苬臮藰臲髴鯶", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뇤蛦诨꣪苬臮藰臲髴鯶ퟸ鋺黼郾", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("곤諦裨質裬", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("곤諦裨質裬쇮飰郲髴", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뇤闦賨軪믬蛮铰蓲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뇤闦賨軪믬蛮铰蓲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뇤裦駨苪軬귮郰臲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뇤裦駨苪軬귮郰臲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꯤ蛦鿨ꧪ賬鷮", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꯤ蛦鿨ꧪ賬鷮\udff0髲雴飶", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ迦裨駪駬", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꛤ迦裨駪駬쇮飰郲髴", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꇤ蛦鷨軪맬蛮鳰雲뛴飶铸駺鋼뷾渀笂", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꇤ蛦鷨軪맬蛮鳰雲뛴飶铸駺鋼뷾渀笂⬄渆樈搊", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꇤ蛦鷨軪맬蛮鳰雲ꗴ黶髸郺飼跾", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꇤ蛦鷨軪맬蛮鳰雲ꗴ黶髸郺飼跾⼀樂昄栆", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꯤ鋦蓨軪鿬蛮鋰냲髴髶鯸铺뿼郾礀", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꯤ鋦蓨軪鿬蛮鋰냲髴髶鯸铺뿼郾礀ⴂ氄搆昈", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뗤闦蛨質鿬諮苰胲럴零诸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뗤闦蛨質鿬諮苰胲럴零诸헺铼鳾渀", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("꟤蛦鯨꣪苬诮铰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("꟤蛦鯨꣪苬诮铰\uddf2鳴银雸", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ迦賨裪蛬諮闰뿲鳴蓶跸맺鋼蟾", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꛤ迦賨裪蛬諮闰뿲鳴蓶跸맺鋼蟾⼀樂昄栆", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뇤闦裨裪蛬귮郰臲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뇤闦裨裪蛬귮郰臲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뛤韦藨苪駬곮黰鷲致零郸闺飼跾", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뛤韦藨苪駬곮黰鷲致零郸闺飼跾⼀樂昄栆", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뇤闦賨軪", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("釤闦賨軪쏬蛮鋰鳲", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꇤ蛦鷨諪ꇬ蛮苰蟲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꇤ蛦鷨諪ꇬ蛮苰蟲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뇤苦釨鿪", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뇤苦釨鿪쏬蛮鋰鳲", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뗤軦諨鿪飬鷮铰ꗲ鳴鋶軸黺迼", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뗤軦諨鿪飬鷮铰ꗲ鳴鋶軸黺迼퇾栀怂樄", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꏤ軦藨軪ꃬ軮鿰鋲鋴鋶诸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꏤ軦藨軪ꃬ軮鿰鋲鋴鋶诸헺铼鳾渀", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("다苦诨ꧪ鿬胮蛰胲郴藶", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("다苦诨ꧪ鿬胮蛰胲郴藶ퟸ鋺黼郾", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("다苦诨뷪蓬諮蛰雲蟴", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("다苦诨ꧪ鿬胮蛰胲郴藶ퟸ鋺黼郾", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뗤蛦胨藪駬諮菰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뗤蛦胨藪駬諮菰\uddf2鳴银雸", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("꟤蛦鯨꣪苬诮铰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("꟤蛦鯨꣪苬诮铰\uddf2鳴银雸", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ蛦藨軪菬诮郰臲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꛤ蛦藨軪菬诮郰臲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꋤ蛦鳨質裬", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꋤ蛦鳨質裬쇮飰郲髴", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꋤ蛦蟨鿪駬맮飰雲苴", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꋤ蛦蟨鿪駬맮飰雲苴\ud9f6郸飺鋼", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뗤ꏦ꿨뷪蓬諮蛰雲蟴", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뗤ꏦ꿨뷪蓬諮蛰雲蟴\ud9f6郸飺鋼", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("꣤蛦駨", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("裤蛦駨엪蓬賮黰", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("돤蛦鯨", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("돤蛦鯨엪蓬賮黰", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("鏤蛦", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("鏤蛦쟨苪軬胮", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰ꃲ铴臶鳸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뛤蛦鿨軪쏬蛮鋰鳲", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰럲郴鯶鳸迺飼", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꇤ苦藨軪駬諮\udff0髲雴飶", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰꛲鯴鏶雸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("냤触跨蓪쏬蛮鋰鳲", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰닲駴黶黸闺뇼髾最眂", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꓤ详胨質菬믮黰뿲郴釶跸헺铼鳾渀", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰닲駴黶黸闺꿼雾昀欂焄", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꓤ详胨質菬믮黰ꇲ鳴郶釸迺폼雾戀氂", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰닲駴黶黸闺ꧼ郾焀", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꓤ详胨質菬믮黰ꟲ髴蟶ퟸ鋺黼郾", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰닲駴黶黸闺뿼郾甀眂樄樆", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꓤ详胨質菬믮黰뇲髴菶跸铺郼퇾栀怂樄", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰ꃲ铴髶鳸곺铼鯾甀欂", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뛤蛦蓨軪뫬蛮闰蟲鷴\ud9f6郸飺鋼", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰ꃲ铴髶鳸돺飼雾昀欂焄", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뛤蛦蓨軪ꗬ諮飰铲鷴菶ퟸ鋺黼郾", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰ꃲ铴髶鳸꣺铼藾搀", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뛤蛦蓨軪뻬蛮诰雲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰ꃲ铴髶鳸돺鋼跾栀礂樄椆紈樊愌導愐爒瘔爖", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뛤蛦蓨軪ꗬ胮菰髲迴飶韸迺鳼鏾刀猂搄搆氈┊搌氎縐", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰ꃲ铴髶鳸귺飼跾甀樂昄昆攈堊紌渎爐瘒", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뛤蛦蓨軪믬諮菰蟲鳴银飸韺껼迾怀怂怄⤆怈栊戌", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰ꃲ郴菶그髺鿼뛾漀朂怄缆", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뇤蛦诨ꋪ菬诮铰诲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蓨蛪賬臮闰럲髴苶鯸韺飼", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꇤ裦鳨觪臬諮\udff0髲雴飶", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦藨黪胬臮", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꛤ裦藨黪胬臮\udff0髲雴飶", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뇤蛦诨蟪裬", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뇤蛦诨蟪裬쇮飰郲髴", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("럤苦諨蓪鿬诮뛰臲鳴鏶", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("럤苦諨蓪鿬诮꛰髲鯴鏶雸賺폼雾戀氂", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뇤裦蛨蟪黬", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뇤裦蛨蟪꿬胮觰\uddf2鳴银雸", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뗤闦蛨鯪裬鷮藰諲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뗤闦蛨鯪裬鷮藰諲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦跨軪", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꃤ釦賨藪駬쇮飰郲髴", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꏤ軦賨蟪觬", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꏤ軦賨蟪觬쇮飰郲髴", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꧤ軦蟨軪", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꧤ軦蟨軪\udcec\ud9ee\udff0髲雴飶", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꧤ軦髨鿪믬蛮铰蓲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꧤ軦髨鿪믬蛮铰蓲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꏤ裦蟨鿪뷬蛮鋰飲郴藶", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꏤ裦蟨鿪뷬蛮鋰飲郴藶ퟸ鋺黼郾", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦藨蓪鿬뿮飰郲黴鋶诸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꛤ裦藨蓪鿬뿮飰郲黴鋶诸헺铼鳾渀", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뛤鏦裨鿪飬鳮돰鋲蟴", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뛤鏦裨鿪飬鳮돰鋲蟴\ud9f6郸飺鋼", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뇤裦蛨蟪꿬軮菰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뇤裦蛨蟪꿬軮菰\uddf2鳴银雸", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("꣤蛦胨藪ꃬ諮鿰蛲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("꣤蛦胨藪ꃬ諮鿰蛲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("꣤苦蟨黪ꓬ鯮铰黲", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("꣤苦蟨黪ꓬ鯮铰黲\udbf4黶髸铺", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뛤韦藨苪駬귮蓰蟲致飶韸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뛤韦藨苪駬귮蓰蟲致飶韸헺铼鳾渀", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ꛤ裦蟨鿪裬臮藰뻲郴駶賸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ꛤ裦蟨鿪裬臮藰뻲郴駶賸헺铼鳾渀", a_)));
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("뛤苦駨諪鿬軮藰鳲蟴", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("뛤苦駨諪鿬軮藰鳲蟴\ud9f6郸飺鋼", a_)));
			}
			return O_O0OO.o.O___o00o0O.;
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x002476B8 File Offset: 0x002458B8
		internal static string <<EMPTY_NAME>>()
		{
			int a_ = 18;
			return O00OOOo_O0_O.b("보髶飸鳺飼\udffe䜀樂椄戆稈眊✌ℎ砐瀒稔Ⱆ㌘㔚缜爞儠ᠢ༤द丨䈪䬬ᐮᬰᴲ弴䜶常:᜼ᄾㅀⵂ≄籆捈敊㥌♎㝐桒≔㩖㽘❚ᑜᱞ⹠ⵢᥤ䵦䝨ɪ๬n൰ㅲ㡴❶ո兺卼ᵾ濾삆삈춊ꖎ뾐ﲔ톚출\uda9e\udfa2辤覦쎨\udbaa쪬펮ﶲ쮶鎸閺춼톾ꛀ뿂釄軆迈跊뇌￐꟒볔뇖ꗘ賚郜駞鷠짢쯤郦蓨跪", a_);
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x002476DC File Offset: 0x002458DC
		internal static ImageFormat <<EMPTY_NAME>>(string A_0)
		{
			int a_ = 18;
			string left = Path.GetExtension(A_0).Trim(new char[]
			{
				'.'
			});
			ImageFormat result;
			if (Operators.CompareString(left, O00OOOo_O0_O.b("韴髶觸", a_), true) == 0)
			{
				result = ImageFormat.Bmp;
			}
			else if (Operators.CompareString(left, O00OOOo_O0_O.b("郴髶鿸", a_), true) == 0)
			{
				result = ImageFormat.Emf;
			}
			else if (Operators.CompareString(left, O00OOOo_O0_O.b("鋴黶鿸", a_), true) == 0)
			{
				result = ImageFormat.Gif;
			}
			else if (Operators.CompareString(left, O00OOOo_O0_O.b("鿴蟶黸", a_), true) == 0)
			{
				result = ImageFormat.Jpeg;
			}
			else if (Operators.CompareString(left, O00OOOo_O0_O.b("藴駶黸", a_), true) == 0)
			{
				result = ImageFormat.Png;
			}
			else if (Operators.CompareString(left, O00OOOo_O0_O.b("致黶鿸", a_), true) == 0)
			{
				result = ImageFormat.Tiff;
			}
			else if (Operators.CompareString(left, O00OOOo_O0_O.b("苴髶鿸", a_), true) == 0)
			{
				result = ImageFormat.Wmf;
			}
			else
			{
				result = ImageFormat.Bmp;
			}
			return result;
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x002477F4 File Offset: 0x002459F4
		internal static bool <<EMPTY_NAME>>(string A_0, ref double A_1)
		{
			int a_ = 4;
			long num = 1L;
			if (A_0.StartsWith(O00OOOo_O0_O.b("쫦", a_)))
			{
				A_0 = A_0.Substring(1);
				num = -1L;
			}
			A_0 = A_0.Replace(O00OOOo_O0_O.b("ﴙ", a_), O00OOOo_O0_O.b("\udde6", a_));
			long num2;
			if (A_0.IndexOf(O00OOOo_O0_O.b("쟦", a_)) > 0)
			{
				if (!long.TryParse(A_0.Substring(A_0.IndexOf(O00OOOo_O0_O.b("쟦", a_)) + 1), out num2))
				{
					return false;
				}
				A_0 = A_0.Substring(0, A_0.IndexOf(O00OOOo_O0_O.b("쟦", a_)));
			}
			string[] array = A_0.Split(new char[]
			{
				':'
			});
			bool result;
			if (array.Length > 3)
			{
				result = false;
			}
			else
			{
				int num3 = array.Length - 1;
				long num4;
				long num5;
				long num6;
				for (int i = 0; i <= num3; i++)
				{
					if (i == 0)
					{
						if (!long.TryParse(array[i], out num4))
						{
							return false;
						}
					}
					else if (i == 1)
					{
						if (!long.TryParse(array[i], out num5))
						{
							return false;
						}
					}
					else if (i == 2 && !long.TryParse(array[i], out num6))
					{
						return false;
					}
				}
				A_1 = (double)(num4 * 3600L + num5 * 60L + num6) + (double)num2 / 1000.0;
				A_1 *= (double)num;
				result = true;
			}
			return result;
		}

		// Token: 0x060051EA RID: 20970 RVA: 0x00247960 File Offset: 0x00245B60
		internal static bool <<EMPTY_NAME>>(double A_0, ref string A_1)
		{
			int a_ = 14;
			string str = "";
			if (A_0 < 0.0)
			{
				str = O00OOOo_O0_O.b("\udcf0", a_);
			}
			A_0 = Math.Abs(A_0);
			TimeSpan timeSpan = TimeSpan.FromSeconds(A_0);
			int num = timeSpan.Days * 24 + timeSpan.Hours;
			A_1 = Microsoft.VisualBasic.Strings.Format(num, O00OOOo_O0_O.b("쇰쏲", a_));
			if (timeSpan.Minutes > 0 || timeSpan.Seconds > 0 || timeSpan.Milliseconds > 0)
			{
				A_1 = A_1 + O00OOOo_O0_O.b("쯰", a_) + Microsoft.VisualBasic.Strings.Format(timeSpan.Minutes, O00OOOo_O0_O.b("쇰쏲", a_));
			}
			if (timeSpan.Seconds > 0 || timeSpan.Milliseconds > 0)
			{
				A_1 = A_1 + O00OOOo_O0_O.b("쯰", a_) + Microsoft.VisualBasic.Strings.Format(timeSpan.Seconds, O00OOOo_O0_O.b("쇰쏲", a_));
			}
			if (timeSpan.Milliseconds > 0)
			{
				A_1 = A_1 + O00OOOo_O0_O.b("퇰", a_) + Microsoft.VisualBasic.Strings.Format(timeSpan.Milliseconds, O00OOOo_O0_O.b("쇰쏲열", a_));
			}
			A_1 = str + A_1;
			return true;
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x00247AC0 File Offset: 0x00245CC0
		internal static bool <<EMPTY_NAME>>()
		{
			return !o0OO__.O_0_O0_OO.0Ooo.() && OO_00oOO.OOO_.OO.;
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x00247ADF File Offset: 0x00245CDF
		internal static void <<EMPTY_NAME>>(bool A_0)
		{
			OO_00oOO.OOO_.OO. = A_0;
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x00247AE8 File Offset: 0x00245CE8
		internal static Image <<EMPTY_NAME>>()
		{
			int a_ = 11;
			if (O_O0OO.O_o.0_0ooOoO. == null && OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("苭鿯鏱郳鿵雷鷹틻駽槿搁", a_)))
			{
				O_O0OO.O_o.0_0ooOoO. = OO_00oOO.GetImage(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("苭鿯鏱郳鿵雷鷹틻駽槿搁", a_));
			}
			return O_O0OO.O_o.0_0ooOoO.;
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x00247B50 File Offset: 0x00245D50
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			int a_ = 14;
			string result;
			if (Operators.CompareString(A_0, "", true) == 0)
			{
				result = null;
			}
			else
			{
				A_0 = A_0.ToLower();
				if (Operators.CompareString(c.OOOOO.o.().FileSystem.GetParentPath(A_0), "", true) == 0)
				{
					if (OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + A_0))
					{
						A_0 = O_O0OO.OOo_o.0o. + A_0;
					}
					else
					{
						A_0 = ooO.OoO0o_o___.O.(A_0);
					}
				}
				if (!File.Exists(A_0))
				{
					A_0 = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + O00OOOo_O0_O.b("귰髲飴零黸黺軼ꏾ", a_) + c.OOOOO.o.().FileSystem.GetName(A_0);
					if (!File.Exists(A_0))
					{
						return null;
					}
				}
				result = A_0;
			}
			return result;
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00247C20 File Offset: 0x00245E20
		internal static string <<EMPTY_NAME>>(TimeSpan A_0)
		{
			int a_ = 18;
			string text = "";
			if (A_0.Hours > 0)
			{
				text = Conversions.ToString(A_0.Hours) + O00OOOo_O0_O.b("Α", a_);
			}
			if (A_0.Minutes > 0)
			{
				text = text + Conversions.ToString(A_0.Minutes) + O00OOOo_O0_O.b("", a_);
			}
			if (A_0.Seconds > 0 || A_0.Milliseconds > 0)
			{
				double num;
				if (A_0.Seconds > 0)
				{
					num = (double)A_0.Seconds;
				}
				if (A_0.Milliseconds > 0)
				{
					num += Math.Round((double)A_0.Milliseconds / 1000.0, 3);
				}
				text = text + Conversions.ToString(num) + O00OOOo_O0_O.b("➍", a_);
			}
			return text;
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x00247CFC File Offset: 0x00245EFC
		internal static void <<EMPTY_NAME>>(ref string A_0, ref string A_1)
		{
			int a_ = 6;
			int num;
			int num2;
			if (O_O0OO.oO.__0O0oooo.() && O_O0OO.GetID(ref num, ref num2, O_O0OO.oO0_o.o0o.) == 0)
			{
				num = Math.Abs(num);
				num2 = Math.Abs(num2);
			}
			else
			{
				num = Math.Abs(OoOo0O.Oo_oOO_._Oo_o.());
				num2 = Math.Abs(OoOo0O.Oo_oOO_._Oo_o.());
			}
			num = num % 99999999 + 1;
			num2 = num2 % 99999999 + 1;
			A_0 = Microsoft.VisualBasic.Strings.Format(num, O00OOOo_O0_O.b("\ud9e8\udbea\uddec\udfee쇰쏲열쟶", a_));
			A_1 = Microsoft.VisualBasic.Strings.Format(num2, O00OOOo_O0_O.b("\ud9e8\udbea\uddec\udfee쇰쏲열쟶", a_));
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x00247D9C File Offset: 0x00245F9C
		internal static string <<EMPTY_NAME>>(short A_0, short A_1, bool A_2)
		{
			int a_ = 17;
			string result;
			if (!O_O0OO.oO.__0O0oooo.())
			{
				result = "";
			}
			else
			{
				byte[] array = new byte[(int)(A_1 - 1 + 1)];
				if (O_O0OO.YRead(ref array[0], A_0, A_1, O00OOOo_O0_O.b("쇳쏵쇷쏹뷻볽䏿䘁", a_), O00OOOo_O0_O.b("닳돵볷맹쫻웽㏿㄁", a_), O_O0OO.oO0_o.o0o.) == 0)
				{
					if (A_2)
					{
						result = Encoding.Unicode.GetString(array);
					}
					else
					{
						result = Encoding.ASCII.GetString(array);
					}
				}
				else
				{
					result = "";
				}
			}
			return result;
		}

		// Token: 0x060051F2 RID: 20978 RVA: 0x00247E24 File Offset: 0x00246024
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			if (!O_O0OO.oO.__0O0oooo.())
			{
			}
			int num = Encoding.ASCII.GetBytes(A_0).Length;
			if (num < 8)
			{
				num = 8;
			}
			StringBuilder stringBuilder = new StringBuilder("", num * 4);
			string result;
			if (O_O0OO.EncString(A_0, stringBuilder, O_O0OO.oO0_o.o0o.) == 0)
			{
				result = stringBuilder.ToString();
			}
			else
			{
				result = A_0;
			}
			return result;
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x00247E78 File Offset: 0x00246078
		internal static bool <<EMPTY_NAME>>()
		{
			StringBuilder stringBuilder = new StringBuilder("", 260);
			bool result;
			if (O_O0OO.FindPort_2(0, 200, 1016130710, stringBuilder) == 0)
			{
				O_O0OO.oO0_o.o0o. = stringBuilder.ToString();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x00247EBC File Offset: 0x002460BC
		internal static bool <<EMPTY_NAME>>(Assembly A_0, string A_1, object[] A_2, bool A_3 = false, string A_4 = "", bool A_5 = false)
		{
			int a_ = 11;
			bool result;
			if (!OO_00oOO.SystemReady && !A_3)
			{
				result = true;
			}
			else if (A_0 == null)
			{
				result = true;
			}
			else
			{
				string text = A_1;
				if (A_0 == O_O0OO.o0OoO00OO.00O. || A_0 == O_O0OO.o0o.oO0. || A_5)
				{
					text = o0OoOOoOOo0.OO0._Oo0o.(text);
				}
				if (O_O0OO.O00O0o_O_._O. && A_0.FullName.IndexOf(O00OOOo_O0_O.b("샭뛯鷱蛳鯵훷", a_), StringComparison.CurrentCultureIgnoreCase) > 0)
				{
					text = o0OoOOoOOo0.OO0._Oo0o.(text);
				}
				MethodInfo method = A_0.GetType(O00OOOo_O0_O.b("믭華韱蛳뗵韷黹駻", a_)).GetMethod(text);
				if (Operators.CompareString(A_1, O00OOOo_O0_O.b("뷭觯臱胳鏵闷돹飻鋽旿", a_), true) == 0 && OoOo0O.Oo_oOO_._Oo_o.(1, 99) == OoOo0O.Oo_oOO_._Oo_o.(1, 99) && OO_00oOO.SystemReady && !o0OO__.oO0o00O._.() && !O_O0OO.O_oO_o0O.o__.)
				{
					ooO.oo__.O000_o_O.();
				}
				if (Operators.CompareString(A_1, O_O0OO.ooO000O.o.(), true) == 0 && !O_O0OO.o_0__.oOOo.)
				{
					O_O0OO.o_0__.oOOo. = o0OO__.OO0oO.o.();
					if (!O_O0OO.o_0__.oOOo.)
					{
						O_O0OO.oo0_o_.o. = null;
						return false;
					}
				}
				try
				{
					if (method != null)
					{
						method.Invoke(null, A_2);
					}
				}
				catch (Exception ex)
				{
					if (A_1.IndexOf(O00OOOo_O0_O.b("뇭", a_)) > 0)
					{
						A_1 = A_1.Substring(0, A_1.IndexOf(O00OOOo_O0_O.b("뇭", a_)));
					}
					if (Operators.CompareString(A_4, "", true) > 0)
					{
						A_1 = A_4 + O00OOOo_O0_O.b("십", a_) + A_1;
					}
					if (ex.InnerException != null)
					{
						ooO.oOo0Oo.o.(ex.InnerException, A_1);
					}
					else
					{
						ooO.oOo0Oo.o.(ex.InnerException, A_1);
					}
					return false;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x0024807C File Offset: 0x0024627C
		internal static string <<EMPTY_NAME>>(string A_0, DataSet A_1 = null)
		{
			int a_ = 0;
			string a_2;
			if (A_1 == null)
			{
				a_2 = O_O0OO.O_O._Oo.();
				A_1 = O_O0OO.OoO.0OO__0ooo.();
			}
			else
			{
				a_2 = O_O0OO.o0_OO.000.(A_1);
			}
			string result;
			if (A_0.StartsWith(O00OOOo_O0_O.b("飢", a_)) && A_0.EndsWith(O00OOOo_O0_O.b("뻢", a_)))
			{
				int num = A_0.LastIndexOf(O00OOOo_O0_O.b("룢", a_));
				string text = A_0.Substring(num);
				text = text.TrimStart(new char[]
				{
					'['
				}).TrimEnd(new char[]
				{
					']'
				});
				A_0 = A_0.Substring(0, num);
				A_0 = A_0.TrimStart(new char[]
				{
					'{'
				}).TrimEnd(new char[]
				{
					'}'
				});
				string a_3 = o0OO__.O.0ooOoO_0_.(text);
				result = O00.oO_.0o_oo_0O_.(A_0, a_2, a_3);
			}
			else
			{
				result = O00.oO_.0o_oo_0O_.(A_0, a_2, ooO0__OO.oO_0.o000O_.(A_1));
			}
			return result;
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x00248170 File Offset: 0x00246370
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			int a_ = 17;
			string a_2 = O_O0OO.O_O._Oo.();
			if (A_0.StartsWith(O00OOOo_O0_O.b("꿳", a_)) && A_0.EndsWith(O00OOOo_O0_O.b("꧳", a_)))
			{
				a_2 = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
				A_0 = A_0.TrimStart(new char[]
				{
					'['
				}).TrimEnd(new char[]
				{
					']'
				});
			}
			return O00.oO_.0o_oo_0O_.(A_0, O00OOOo_O0_O.b("ꇳ藵鷷裹뫻诽滿愁瀃漅朇搉", a_), a_2);
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x00248210 File Offset: 0x00246410
		internal static DataTable <<EMPTY_NAME>>()
		{
			int a_ = 3;
			DataTable dataTable = null;
			if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()].Rows.Count == 0)
			{
				Oo00.o_o_oo.0o.();
			}
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
			{
				O00OOOo_O0_O.b("돥鯧迩黫", a_),
				o0_O.o.0_O_O.
			});
			bool flag;
			if (dataRow != null && Operators.CompareString(dataRow[O00OOOo_O0_O.b("ꗥ蟧蓩諫蟭韯", a_)].ToString(), O00OOOo_O0_O.b("ퟥ", a_), true) == 0)
			{
				flag = true;
			}
			if (flag)
			{
				string text = "";
				string text2 = "";
				DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					O00OOOo_O0_O.b("돥鯧迩黫", a_),
					o0_O.Oo0_.o0.
				});
				if (dataRow2 != null)
				{
					text = dataRow2[O00OOOo_O0_O.b("ꗥ蟧蓩諫蟭韯", a_)].ToString();
				}
				dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					O00OOOo_O0_O.b("돥鯧迩黫", a_),
					o0_O.OO_O.O0ooO0O.
				});
				if (dataRow2 != null)
				{
					text2 = dataRow2[O00OOOo_O0_O.b("ꗥ蟧蓩諫蟭韯", a_)].ToString();
				}
				if (!text2.StartsWith(O00OOOo_O0_O.b("뷥", a_)))
				{
					text2 = O00OOOo_O0_O.b("뷥", a_) + text2 + O00OOOo_O0_O.b("믥", a_);
				}
				if (Operators.CompareString(text, "", true) > 0 && Operators.CompareString(text2, "", true) > 0)
				{
					if (O_O0OO.O._o_.().ContainsKey(text))
					{
						dataTable = new DataTable();
						OleDbDataAdapter oleDbDataAdapter;
						if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()[text]))
						{
							oleDbDataAdapter = new OleDbDataAdapter(O00OOOo_O0_O.b("뗥跧蛩觫跭蓯틱\udef3훵뻷裹鏻鏽⃿", a_) + text2, O_O0OO.O._o_.()[text]);
						}
						else
						{
							oleDbDataAdapter = new OleDbDataAdapter(O00OOOo_O0_O.b("뗥跧蛩觫跭蓯틱\udef3훵뻷裹鏻鏽⃿", a_) + text2, O_O0OO.O._o_.()[text]);
						}
						oleDbDataAdapter.Fill(dataTable);
						o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
						dataTable.ExtendedProperties.Add(O00OOOo_O0_O.b("ꋥ觧黩跫꿭铯鏱蓳苵鷷裹", a_), oleDbDataAdapter);
					}
					else if (Operators.CompareString(text, "", true) > 0 && Operators.CompareString(text2, "", true) > 0 && O_O0OO.OoO__.0oO0oo.().ContainsKey(text))
					{
						O0O o0O = O_O0OO.OoO__.0oO0oo.()[text];
						string a_2;
						if (o0O.OO.OoO0. == DataServerTypeEnum.Oracle)
						{
							a_2 = O00OOOo_O0_O.b("뗥跧蛩觫跭蓯틱\udef3훵뻷裹鏻鏽⃿", a_) + text2;
						}
						else
						{
							a_2 = O00OOOo_O0_O.b("뗥跧蛩觫跭蓯틱\udef3훵뻷裹鏻鏽⃿", a_) + text2;
						}
						HttpClient httpClient = o0O.oO0_0.o.();
						httpClient.FormData[O00OOOo_O0_O.b("꟥诧黩藫臭黯", a_)] = 1.ToString();
						httpClient.Select = a_2;
						dataTable = httpClient.GetBaseDataTable();
						DataTable dataTable2 = new DataTable(dataTable, null, null, text2, null);
						dataTable2.ConnectionName = text;
						dataTable2.DataServer = httpClient.Oo_0oO0Oo0_.O_.;
						dataTable2.UpdateServer = httpClient.Oo_0oO0Oo0_.O_.;
						dataTable2.UpdateColumns = (List<string>)dataTable.ExtendedProperties[O00OOOo_O0_O.b("돥飧軩跫髭闯뇱鯳髵跷韹鋻跽", a_)];
						dataTable.ExtendedProperties.Clear();
						dataTable.ExtendedProperties.Add(O00OOOo_O0_O.b("뇥跧裩맫黭铯鏱胳鏵諷", a_), dataTable2);
					}
					foreach (DataRow dataRow3 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()].Select(O00OOOo_O0_O.b("뷥볧鏩鳫语귯틱짳훵", a_) + Conversions.ToString(0) + O00OOOo_O0_O.b("웥꟧飩쳫뗭ꓯ诱蓳鏵ꗷ\udaf9쇻\udefd", a_) + Conversions.ToString(1)))
					{
						DataRow dataRow4 = dataTable.NewRow();
						dataRow4[O00OOOo_O0_O.b("꣥觧蟩觫", a_)] = RuntimeHelpers.GetObjectValue(dataRow3[O00OOOo_O0_O.b("꣥觧蟩觫", a_)]);
						dataRow4[O00OOOo_O0_O.b("닥釧髩觫", a_)] = RuntimeHelpers.GetObjectValue(dataRow3[O00OOOo_O0_O.b("닥釧髩觫", a_)]);
						dataRow4[O00OOOo_O0_O.b("ꗥ蟧蓩諫蟭韯", a_)] = RuntimeHelpers.GetObjectValue(dataRow3[O00OOOo_O0_O.b("ꗥ蟧蓩諫蟭韯", a_)]);
						dataTable.Rows.Add(dataRow4);
					}
					dataTable.AcceptChanges();
				}
				else
				{
					dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()];
				}
			}
			else
			{
				dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()];
			}
			return dataTable;
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x00248710 File Offset: 0x00246910
		internal static void <<EMPTY_NAME>>(string A_0, DataTable A_1)
		{
			int a_ = 4;
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
			{
				O00OOOo_O0_O.b("닦髨軪鿬", a_),
				o0_O.o.0_O_O.
			});
			if (dataRow != null && Operators.CompareString(dataRow[O00OOOo_O0_O.b("ꓦ蛨藪诬蛮雰", a_)].ToString(), O00OOOo_O0_O.b("훦", a_), true) == 0)
			{
				string text = "";
				string text2 = "";
				DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					O00OOOo_O0_O.b("닦髨軪鿬", a_),
					o0_O.Oo0_.o0.
				});
				if (dataRow2 != null)
				{
					text = dataRow2[O00OOOo_O0_O.b("ꓦ蛨藪诬蛮雰", a_)].ToString();
					if (O_O0OO.O._o_.().ContainsKey(text))
					{
						dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
						{
							O00OOOo_O0_O.b("닦髨軪鿬", a_),
							o0_O.OO_O.O0ooO0O.
						});
						if (dataRow2 != null)
						{
							text2 = dataRow2[O00OOOo_O0_O.b("ꓦ蛨藪诬蛮雰", a_)].ToString();
						}
					}
				}
				if (Operators.CompareString(text, "", true) > 0 && Operators.CompareString(text2, "", true) > 0)
				{
					DataTable dataTable = new DataTable();
					if (O_O0OO.O._o_.().ContainsKey(text))
					{
						OleDbDataAdapter oleDbDataAdapter;
						if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()[text]))
						{
							oleDbDataAdapter = new OleDbDataAdapter(string.Concat(new string[]
							{
								O00OOOo_O0_O.b("듦賨蟪裬賮藰폲\udff4ퟶ뿸觺鋼鋾℀", a_),
								text2,
								O00OOOo_O0_O.b("쟦黨菪裬鷮铰폲믴零铸黺\uddfc싾℀␂", a_),
								A_0,
								O00OOOo_O0_O.b("샦", a_)
							}), O_O0OO.O._o_.()[text]);
						}
						else
						{
							oleDbDataAdapter = new OleDbDataAdapter(string.Concat(new string[]
							{
								O00OOOo_O0_O.b("듦賨蟪裬賮藰폲\udff4ퟶ뿸觺鋼鋾℀堂", a_),
								text2,
								O00OOOo_O0_O.b("뫦짨볪藬諮菰雲헴곶럸髺郼髾尀⌂㠄✆⸈", a_),
								A_0,
								O00OOOo_O0_O.b("샦", a_)
							}), O_O0OO.O._o_.()[text]);
						}
						oleDbDataAdapter.Fill(dataTable);
					}
					else if (O_O0OO.OoO__.0oO0oo.().ContainsKey(text))
					{
						O0O o0O = O_O0OO.OoO__.0oO0oo.()[text];
						string a_2;
						if (o0O.OO.OoO0. == DataServerTypeEnum.Oracle)
						{
							a_2 = string.Concat(new string[]
							{
								O00OOOo_O0_O.b("듦賨蟪裬賮藰폲\udff4ퟶ뿸觺鋼鋾℀", a_),
								text2,
								O00OOOo_O0_O.b("쟦黨菪裬鷮铰폲믴零铸黺\uddfc싾℀␂", a_),
								A_0,
								O00OOOo_O0_O.b("샦", a_)
							});
						}
						else
						{
							a_2 = string.Concat(new string[]
							{
								O00OOOo_O0_O.b("듦賨蟪裬賮藰폲\udff4ퟶ뿸觺鋼鋾℀堂", a_),
								text2,
								O00OOOo_O0_O.b("뫦짨볪藬諮菰雲헴곶럸髺郼髾尀⌂㠄✆⸈", a_),
								A_0,
								O00OOOo_O0_O.b("샦", a_)
							});
						}
						HttpClient httpClient = o0O.oO0_0.o.();
						httpClient.Select = a_2;
						httpClient.FormData[O00OOOo_O0_O.b("ꛦ諨鿪蓬胮鿰", a_)] = 2.ToString();
						httpClient.FormData[O00OOOo_O0_O.b("껦軨藪苬鷮铰ꃲ雴鿶鳸雺鳼", a_)] = O00OOOo_O0_O.b("돦鯨黪裬", a_);
						dataTable = httpClient.GetBaseDataTable();
					}
					if (dataTable.Rows.Count > 0)
					{
						dataRow2 = dataTable.Rows[0];
						DataRow[] array = A_1.Select(O00OOOo_O0_O.b("볦꟨諪胬諮곰폲죴ퟶ\udef8", a_) + A_0 + O00OOOo_O0_O.b("샦", a_));
						if (array.Length == 0)
						{
							A_1.ImportRow(dataRow2);
							return;
						}
						array[0][O00OOOo_O0_O.b("ꓦ蛨藪诬蛮雰", a_)] = RuntimeHelpers.GetObjectValue(dataRow2[O00OOOo_O0_O.b("ꓦ蛨藪诬蛮雰", a_)]);
						if (OO_00oOO.Users.ooo___o_0.__..ContainsKey(array[0]))
						{
							OO_00oOO.Users.ooo___o_0.__..Remove(array[0]);
						}
					}
				}
			}
		}

		// Token: 0x060051F9 RID: 20985 RVA: 0x00248B4C File Offset: 0x00246D4C
		internal static string <<EMPTY_NAME>>()
		{
			byte[] array = new byte[31];
			array[0] = 229;
			array[1] = 138;
			array[2] = 160;
			array[3] = 229;
			array[4] = 175;
			array[5] = 134;
			array[6] = 231;
			array[7] = 139;
			array[8] = 151;
			array[9] = 228;
			array[10] = 191;
			array[11] = 161;
			array[12] = 230;
			array[13] = 129;
			array[14] = 175;
			array[15] = 232;
			array[16] = 175;
			array[17] = 187;
			array[18] = 229;
			array[19] = 143;
			array[20] = 150;
			array[21] = 233;
			array[22] = 148;
			array[23] = 153;
			array[24] = 232;
			array[25] = 175;
			array[26] = 175;
			array[27] = 239;
			array[28] = 188;
			array[29] = 129;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060051FA RID: 20986 RVA: 0x00248C74 File Offset: 0x00246E74
		internal static string <<EMPTY_NAME>>()
		{
			byte[] array = new byte[22];
			array[0] = 232;
			array[1] = 175;
			array[2] = 183;
			array[3] = 230;
			array[4] = 143;
			array[5] = 146;
			array[6] = 228;
			array[7] = 184;
			array[8] = 138;
			array[9] = 229;
			array[10] = 138;
			array[11] = 160;
			array[12] = 229;
			array[13] = 175;
			array[14] = 134;
			array[15] = 231;
			array[16] = 139;
			array[17] = 151;
			array[18] = 239;
			array[19] = 188;
			array[20] = 129;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x00248D48 File Offset: 0x00246F48
		internal static string <<EMPTY_NAME>>()
		{
			byte[] array = new byte[37];
			array[0] = 229;
			array[1] = 138;
			array[2] = 160;
			array[3] = 229;
			array[4] = 175;
			array[5] = 134;
			array[6] = 231;
			array[7] = 139;
			array[8] = 151;
			array[9] = 230;
			array[10] = 148;
			array[11] = 175;
			array[12] = 230;
			array[13] = 140;
			array[14] = 129;
			array[15] = 231;
			array[16] = 154;
			array[17] = 132;
			array[18] = 230;
			array[19] = 156;
			array[20] = 128;
			array[21] = 233;
			array[22] = 171;
			array[23] = 152;
			array[24] = 231;
			array[25] = 137;
			array[26] = 136;
			array[27] = 230;
			array[28] = 156;
			array[29] = 172;
			array[30] = 228;
			array[31] = 184;
			array[32] = 186;
			array[33] = 239;
			array[34] = 188;
			array[35] = 154;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x00248EA4 File Offset: 0x002470A4
		internal static string <<EMPTY_NAME>>()
		{
			byte[] array = new byte[34];
			array[0] = 232;
			array[1] = 175;
			array[2] = 183;
			array[3] = 230;
			array[4] = 143;
			array[5] = 146;
			array[6] = 229;
			array[7] = 133;
			array[8] = 165;
			array[9] = 229;
			array[10] = 188;
			array[11] = 128;
			array[12] = 229;
			array[13] = 143;
			array[14] = 145;
			array[15] = 231;
			array[16] = 137;
			array[17] = 136;
			array[18] = 231;
			array[19] = 154;
			array[20] = 132;
			array[21] = 229;
			array[22] = 138;
			array[23] = 160;
			array[24] = 229;
			array[25] = 175;
			array[26] = 134;
			array[27] = 231;
			array[28] = 139;
			array[29] = 151;
			array[30] = 239;
			array[31] = 188;
			array[32] = 129;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x00248FE4 File Offset: 0x002471E4
		internal static string <<EMPTY_NAME>>()
		{
			byte[] array = new byte[53];
			array[0] = 230;
			array[1] = 130;
			array[2] = 168;
			array[3] = 230;
			array[4] = 173;
			array[5] = 163;
			array[6] = 229;
			array[7] = 156;
			array[8] = 168;
			array[9] = 228;
			array[10] = 189;
			array[11] = 191;
			array[12] = 231;
			array[13] = 148;
			array[14] = 168;
			array[15] = 231;
			array[16] = 154;
			array[17] = 132;
			array[18] = 231;
			array[19] = 137;
			array[20] = 136;
			array[21] = 230;
			array[22] = 156;
			array[23] = 172;
			array[24] = 228;
			array[25] = 184;
			array[26] = 141;
			array[27] = 232;
			array[28] = 131;
			array[29] = 189;
			array[30] = 233;
			array[31] = 133;
			array[32] = 141;
			array[33] = 229;
			array[34] = 144;
			array[35] = 136;
			array[36] = 229;
			array[37] = 138;
			array[38] = 160;
			array[39] = 229;
			array[40] = 175;
			array[41] = 134;
			array[42] = 231;
			array[43] = 139;
			array[44] = 151;
			array[45] = 228;
			array[46] = 189;
			array[47] = 191;
			array[48] = 231;
			array[49] = 148;
			array[50] = 168;
			array[51] = 33;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x002491CC File Offset: 0x002473CC
		internal static bool <<EMPTY_NAME>>(ProjectProperty A_0)
		{
			return OO_00oOO.ModifierKey == Keys.Control;
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x002491DA File Offset: 0x002473DA
		internal static Office2007Renderer <<EMPTY_NAME>>()
		{
			if (O_O0OO.o.O___o00o0O. == null)
			{
				O_O0OO.o.O___o00o0O. = new Office2007Renderer();
			}
			return O_O0OO.o.O___o00o0O.;
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x002491F4 File Offset: 0x002473F4
		internal static string <<EMPTY_NAME>>()
		{
			byte[] array = new byte[29];
			array[0] = 230;
			array[1] = 130;
			array[2] = 168;
			array[3] = 230;
			array[4] = 151;
			array[5] = 160;
			array[6] = 230;
			array[7] = 157;
			array[8] = 131;
			array[9] = 232;
			array[10] = 191;
			array[11] = 155;
			array[12] = 232;
			array[13] = 161;
			array[14] = 140;
			array[15] = 230;
			array[16] = 173;
			array[17] = 164;
			array[18] = 233;
			array[19] = 161;
			array[20] = 185;
			array[21] = 230;
			array[22] = 147;
			array[23] = 141;
			array[24] = 228;
			array[25] = 189;
			array[26] = 156;
			array[27] = 33;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x00249304 File Offset: 0x00247504
		internal static void <<EMPTY_NAME>>(C1PrintPreviewDialog A_0)
		{
			int a_ = 3;
			try
			{
				foreach (object obj in A_0.Controls[0].Controls)
				{
					Control control = (Control)obj;
					if (control is ToolStripPanel)
					{
						try
						{
							foreach (object obj2 in control.Controls)
							{
								Control control2 = (Control)obj2;
								if (control2 is ToolStrip)
								{
									try
									{
										foreach (object obj3 in ((ToolStrip)control2).Items)
										{
											ToolStripItem toolStripItem = (ToolStripItem)obj3;
											if (Operators.CompareString(toolStripItem.Name, O00OOOo_O0_O.b("蓥鳧蓩ꫫ蟭鳯韱ꟳ韵軷鿹", a_), true) == 0 || Operators.CompareString(toolStripItem.Name, O00OOOo_O0_O.b("蓥鳧蓩볫鳭駯鳱胳", a_), true) == 0)
											{
												toolStripItem.Visible = false;
											}
										}
									}
									finally
									{
										IEnumerator enumerator3;
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
								}
							}
							continue;
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					if (control is ToolStripContentPanel)
					{
						try
						{
							foreach (object obj4 in control.Controls)
							{
								Control control3 = (Control)obj4;
								if (control3 is C1PreviewPane)
								{
									control3.ContextMenuStrip = null;
								}
							}
						}
						finally
						{
							IEnumerator enumerator4;
							if (enumerator4 is IDisposable)
							{
								(enumerator4 as IDisposable).Dispose();
							}
						}
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

		// Token: 0x06005202 RID: 20994 RVA: 0x002494F8 File Offset: 0x002476F8
		internal static void <<EMPTY_NAME>>(object A_0, PowerModeChangedEventArgs A_1)
		{
			PowerModes mode = A_1.Mode;
			if (mode != PowerModes.Resume)
			{
				if (mode == PowerModes.Suspend)
				{
					O_O0OO.O_oO_o0O.o__. = true;
					return;
				}
			}
			else
			{
				O_O0OO.O_oO_o0O.o__. = false;
			}
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x00249524 File Offset: 0x00247724
		internal static string <<EMPTY_NAME>>()
		{
			int a_ = 11;
			if (!OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + O00OOOo_O0_O.b("뫭闯鿱蓳ꓵ鷷諹鏻賽瓿䐁洃樅洇礉個", a_)))
			{
				OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + O00OOOo_O0_O.b("뫭闯鿱蓳ꓵ鷷諹鏻賽瓿䐁洃樅洇礉個", a_));
			}
			return OO_00oOO.ProjectPath + O00OOOo_O0_O.b("뫭闯鿱蓳ꓵ鷷諹鏻賽瓿䐁洃樅洇礉個", a_);
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x00249598 File Offset: 0x00247798
		internal static string <<EMPTY_NAME>>()
		{
			int a_ = 17;
			return c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + O00OOOo_O0_O.b("ꣳ", a_);
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x002495D8 File Offset: 0x002477D8
		public static void <<EMPTY_NAME>>()
		{
			int a_ = 8;
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
				if (!OO_00oOO.FileSys.DirectoryExists(O_O0OO.OoO__.0oO0oo.()))
				{
					goto IL_F2;
				}
				IL_26:
				num2 = 3;
				IEnumerator<string> enumerator = OO_00oOO.FileSys.GetFiles(O_O0OO.OoO__.0oO0oo.()).GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					IL_4A:
					num2 = 4;
					FileInfo fileInfo = new FileInfo(text);
					IL_55:
					num2 = 5;
					if ((DateTime.Now - fileInfo.CreationTime).TotalMinutes > 5.0)
					{
						IL_7C:
						num2 = 6;
						fileInfo.Delete();
						IL_85:
						num2 = 7;
						string directory = fileInfo.DirectoryName + O00OOOo_O0_O.b("럪", a_) + Path.GetFileNameWithoutExtension(text) + O00OOOo_O0_O.b("엪诬蛮鷰雲蛴", a_);
						IL_B8:
						num2 = 8;
						if (OO_00oOO.FileSys.DirectoryExists(directory))
						{
							IL_C8:
							num2 = 9;
							OO_00oOO.FileSys.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
						}
					}
					IL_D8:
					num2 = 10;
				}
				IL_E6:
				num2 = 11;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_F2:
				goto IL_171;
				IL_F4:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_132:
				goto IL_166;
				IL_134:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_144:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_134;
			}
			IL_166:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_171:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x0024977C File Offset: 0x0024797C
		internal static bool <<EMPTY_NAME>>()
		{
			return AppDomain.CurrentDomain.DomainManager != null;
		}

		// Token: 0x040021AF RID: 8623
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021B0 RID: 8624
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x040021B1 RID: 8625
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x040021B2 RID: 8626
		private static DataSet <<EMPTY_NAME>>;

		// Token: 0x040021B3 RID: 8627
		private static DataSet <<EMPTY_NAME>>;

		// Token: 0x040021B4 RID: 8628
		private static OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x040021B5 RID: 8629
		private static Dictionary<string, O_0> <<EMPTY_NAME>>;

		// Token: 0x040021B6 RID: 8630
		private static List<O_0> <<EMPTY_NAME>>;

		// Token: 0x040021B7 RID: 8631
		private static Dictionary<string, OleDbConnection> <<EMPTY_NAME>>;

		// Token: 0x040021B8 RID: 8632
		private static Dictionary<string, O_0oOo_OO> <<EMPTY_NAME>>;

		// Token: 0x040021B9 RID: 8633
		private static Dictionary<string, O0O> <<EMPTY_NAME>>;

		// Token: 0x040021BA RID: 8634
		private static Dictionary<string, o__o_OO_o_> <<EMPTY_NAME>>;

		// Token: 0x040021BB RID: 8635
		private static ImageList <<EMPTY_NAME>>;

		// Token: 0x040021BC RID: 8636
		private static Oooo <<EMPTY_NAME>>;

		// Token: 0x040021BD RID: 8637
		private static O0OO_oo0o <<EMPTY_NAME>>;

		// Token: 0x040021BE RID: 8638
		private static OO__oo_0ooo0_ <<EMPTY_NAME>>;

		// Token: 0x040021BF RID: 8639
		private static oo0O0o___O <<EMPTY_NAME>>;

		// Token: 0x040021C0 RID: 8640
		private static o0o0OO <<EMPTY_NAME>>;

		// Token: 0x040021C1 RID: 8641
		private static O0OooO0_0O <<EMPTY_NAME>>;

		// Token: 0x040021C2 RID: 8642
		private static o__o_O_o0o0__ <<EMPTY_NAME>>;

		// Token: 0x040021C3 RID: 8643
		private static OOoOO_00O00 <<EMPTY_NAME>>;

		// Token: 0x040021C4 RID: 8644
		private static O0o__o0_o0 <<EMPTY_NAME>>;

		// Token: 0x040021C5 RID: 8645
		private static O0_oOoo <<EMPTY_NAME>>;

		// Token: 0x040021C6 RID: 8646
		private static Ooo0__ <<EMPTY_NAME>>;

		// Token: 0x040021C7 RID: 8647
		internal static readonly string <<EMPTY_NAME>>;

		// Token: 0x040021C8 RID: 8648
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021C9 RID: 8649
		internal static Assembly <<EMPTY_NAME>>;

		// Token: 0x040021CA RID: 8650
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x040021CB RID: 8651
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x040021CC RID: 8652
		internal static ProjectProperty <<EMPTY_NAME>>;

		// Token: 0x040021CD RID: 8653
		internal static Assembly <<EMPTY_NAME>>;

		// Token: 0x040021CE RID: 8654
		internal static Image <<EMPTY_NAME>>;

		// Token: 0x040021CF RID: 8655
		internal static Image <<EMPTY_NAME>>;

		// Token: 0x040021D0 RID: 8656
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x040021D1 RID: 8657
		internal static DataTable <<EMPTY_NAME>>;

		// Token: 0x040021D2 RID: 8658
		internal static List<string> <<EMPTY_NAME>>;

		// Token: 0x040021D3 RID: 8659
		internal static int <<EMPTY_NAME>>;

		// Token: 0x040021D4 RID: 8660
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x040021D5 RID: 8661
		internal static RibbonButton <<EMPTY_NAME>>;

		// Token: 0x040021D6 RID: 8662
		private static string <<EMPTY_NAME>>;

		// Token: 0x040021D7 RID: 8663
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021D8 RID: 8664
		internal static List<string> <<EMPTY_NAME>>;

		// Token: 0x040021D9 RID: 8665
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021DA RID: 8666
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021DB RID: 8667
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021DC RID: 8668
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x040021DD RID: 8669
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x040021DE RID: 8670
		internal static Assembly <<EMPTY_NAME>>;

		// Token: 0x040021DF RID: 8671
		internal static O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002 <<EMPTY_NAME>>;

		// Token: 0x040021E0 RID: 8672
		internal static Office2007Renderer <<EMPTY_NAME>>;

		// Token: 0x040021E1 RID: 8673
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x040021E2 RID: 8674
		internal static Dictionary<string, Bitmap> <<EMPTY_NAME>>;

		// Token: 0x040021E3 RID: 8675
		internal static Bitmap <<EMPTY_NAME>>;

		// Token: 0x040021E4 RID: 8676
		internal static O\u3002\u3000\u3002_\u3002\u3000\u3000\u3002\u3000\u3002\u3000 <<EMPTY_NAME>>;

		// Token: 0x040021E5 RID: 8677
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x040021E6 RID: 8678
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021E7 RID: 8679
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021E8 RID: 8680
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021E9 RID: 8681
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021EA RID: 8682
		internal static int <<EMPTY_NAME>>;

		// Token: 0x040021EB RID: 8683
		internal static Color <<EMPTY_NAME>>;

		// Token: 0x040021EC RID: 8684
		internal static Color <<EMPTY_NAME>>;

		// Token: 0x040021ED RID: 8685
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x040021EE RID: 8686
		internal static oOo_00o0o00_0 <<EMPTY_NAME>>;

		// Token: 0x040021EF RID: 8687
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021F0 RID: 8688
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040021F1 RID: 8689
		private static string <<EMPTY_NAME>>;

		// Token: 0x040021F2 RID: 8690
		private static string <<EMPTY_NAME>>;

		// Token: 0x040021F3 RID: 8691
		private static Image <<EMPTY_NAME>>;

		// Token: 0x020004E3 RID: 1251
		[EditorBrowsable(EditorBrowsableState.Never)]
		public class DeveloperValider
		{
			// Token: 0x170011B3 RID: 4531
			// (get) Token: 0x06005208 RID: 21000 RVA: 0x002497A4 File Offset: 0x002479A4
			// (set) Token: 0x06005209 RID: 21001 RVA: 0x002497AC File Offset: 0x002479AC
			public string Developer
			{
				get
				{
					return this.OO._0OooO00.;
				}
				set
				{
					this.OO._0OooO00. = value;
				}
			}

			// Token: 0x040021F4 RID: 8692
			private string <<EMPTY_NAME>>;
		}
	}
}
