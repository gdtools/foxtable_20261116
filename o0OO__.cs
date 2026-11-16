using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Foxtable.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000449 RID: 1097
	[StandardModule]
	internal sealed class o0OO__
	{
		// Token: 0x060049F1 RID: 18929 RVA: 0x0020B748 File Offset: 0x00209948
		internal static bool <<EMPTY_NAME>>()
		{
			string oo0oO.o. = null;
			bool result;
			if (Oo0OO_oo.OO.OO0oO0__.(0, 123, 1011412005, ref oo0oO.o.) == 0)
			{
				o0OO__.OO0oO.o. = oo0oO.o.;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x0020B778 File Offset: 0x00209978
		internal static bool <<EMPTY_NAME>>(string A_0, int A_1, bool A_2)
		{
			bool result;
			if (!o0OO__.O_0_O0_OO.0Ooo.())
			{
				result = false;
			}
			else
			{
				byte[] bytes;
				if (A_2)
				{
					bytes = Encoding.Unicode.GetBytes(A_0);
				}
				else
				{
					bytes = Encoding.ASCII.GetBytes(A_0);
				}
				result = (Oo0OO_oo.O0_Oo0._oO.(ref bytes, (short)A_1, (short)bytes.Length, "20020317", "91730521", o0OO__.OO0oO.o.) == 0);
			}
			return result;
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x0020B7D0 File Offset: 0x002099D0
		internal static string <<EMPTY_NAME>>(int A_0, int A_1, bool A_2)
		{
			string result;
			if (!o0OO__.O_0_O0_OO.0Ooo.())
			{
				result = "";
			}
			else
			{
				byte[] bytes = new byte[A_1 - 1 + 1];
				if (Oo0OO_oo.o.O_O00o0o_.(ref bytes, (short)A_0, (short)A_1, "5599ABCD", "FEDC6833", o0OO__.OO0oO.o.) == 0)
				{
					if (A_2)
					{
						result = Encoding.Unicode.GetString(bytes);
					}
					else
					{
						result = Encoding.ASCII.GetString(bytes);
					}
				}
				else
				{
					result = "";
				}
			}
			return result;
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x0020B83C File Offset: 0x00209A3C
		internal static int <<EMPTY_NAME>>(int A_0)
		{
			int result;
			int num;
			if (!o0OO__.O_0_O0_OO.0Ooo.())
			{
				result = A_0;
			}
			else if (Oo0OO_oo.o_OOoo.O_0o_O.(A_0, ref num, o0OO__.OO0oO.o.) == 0)
			{
				result = num;
			}
			else
			{
				result = OoOo0O.Oo_oOO_._Oo_o.(10000, 99999);
			}
			return result;
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x0020B878 File Offset: 0x00209A78
		internal static int <<EMPTY_NAME>>(int A_0)
		{
			int result;
			int num;
			if (!o0OO__.O_0_O0_OO.0Ooo.())
			{
				result = A_0;
			}
			else if (Oo0OO_oo.Ooo0OOo.oO0oO.(A_0, ref num, o0OO__.OO0oO.o.) == 0)
			{
				result = num;
			}
			else
			{
				result = OoOo0O.Oo_oOO_._Oo_o.(10000, 99999);
			}
			return result;
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x0020B8B4 File Offset: 0x00209AB4
		internal static void <<EMPTY_NAME>>(ref string A_0, ref string A_1)
		{
			int num;
			int num2;
			if (o0OO__.O_0_O0_OO.0Ooo.() && Oo0OO_oo.o0___0O._0.(ref num, ref num2, o0OO__.OO0oO.o.) == 0)
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
			A_0 = Strings.Format(num, "00000000");
			A_1 = Strings.Format(num2, "00000000");
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x0020B938 File Offset: 0x00209B38
		internal static DateTime <<EMPTY_NAME>>()
		{
			if (o0OO__.O_0_O0_OO.0Ooo.())
			{
				try
				{
					string a_ = "";
					string a_2 = "";
					string text = o0OO__.OO0oO.o.(1800, 50, false).Trim();
					o0OO__.oOO.o_.(ref a_, ref a_2);
					text = O00.oO_.0o_oo_0O_.(text, a_, a_2);
					return new DateTime(Conversions.ToInteger(text.Substring(0, 4)), Conversions.ToInteger(text.Substring(4, 2)), Conversions.ToInteger(text.Substring(6, 2)));
				}
				catch (Exception ex)
				{
					MessageBox.Show(O_O0OO.o0O0000_0.0.(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return DateTime.Today.AddDays(-100.0);
				}
			}
			return DateTime.Today.AddDays(-100.0);
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x0020BA14 File Offset: 0x00209C14
		internal static bool <<EMPTY_NAME>>()
		{
			string text = "";
			string text2 = "";
			o0OO__.oOO.o_.(ref text, ref text2);
			string text3 = o0OO__.OO0oO.o.(1850, 75, false).Trim();
			if (Operators.CompareString(text3, "", true) > 0)
			{
				text3 = O00.oO_.0o_oo_0O_.(text3, text, text2);
			}
			string text4 = text + text2;
			text4 = O00.MD5Encrypt(text4).Substring(0, 16);
			return Operators.CompareString(text3, text4, true) == 0;
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x0020BA84 File Offset: 0x00209C84
		internal static bool <<EMPTY_NAME>>()
		{
			string text = "integer";
			if (!o0OO__.O_0_O0_OO.0Ooo.())
			{
			}
			string text2 = null;
			string strToHash;
			if (Oo0OO_oo.OO.OO0oO0__.(text, ref text2, o0OO__.OO0oO.o.) == 0)
			{
				strToHash = text2.ToString();
			}
			else
			{
				strToHash = text;
			}
			return Operators.CompareString(O00.MD5Encrypt(strToHash), "tyr4CJXAlbeZlLvWONeM0g==", true) == 0;
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x0020BAD0 File Offset: 0x00209CD0
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			if (!o0OO__.O_0_O0_OO.0Ooo.())
			{
			}
			string text = null;
			string result;
			if (Oo0OO_oo.OO.OO0oO0__.(A_0, ref text, o0OO__.OO0oO.o.) == 0)
			{
				result = text;
			}
			else
			{
				result = OoOo0O.OO_o.0o_O.(A_0.Length);
			}
			return result;
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x0020BB08 File Offset: 0x00209D08
		internal static string <<EMPTY_NAME>>()
		{
			string str = null;
			string str2 = null;
			o0OO__.oOO.o_.(ref str, ref str2);
			string text = str + str2;
			return Strings.Format(Conversions.ToLong((Conversions.ToLong(o_O_o_oOoo__.OOOO_OO._oo.(text)) ^ Conversions.ToLong(text)).ToString().PadRight(16, '0').Substring(0, 16)), "0000-0000-0000-0000");
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x0020BB6C File Offset: 0x00209D6C
		internal static bool <<EMPTY_NAME>>(int A_0)
		{
			bool result;
			if (!o0OO__.O_0_O0_OO.0Ooo.())
			{
				try
				{
					string tempFileName = OO_00oOO.FileSys.GetTempFileName();
					OO_00oOO.FileSys.DeleteFile(tempFileName);
					ShareLibriay.Network.DownloadFile("http://www.foxtable.com/update/eval.txt", tempFileName, "", "", false, 5000, false);
					if (OO_00oOO.FileSys.FileExists(tempFileName))
					{
						string text = OO_00oOO.FileSys.ReadAllText(tempFileName, Encoding.Default);
						OO_00oOO.FileSys.DeleteFile(tempFileName);
						string[] array = text.Split(new char[]
						{
							'|'
						});
						if (array.Length == 3)
						{
							DateTime dateTime;
							DateTime.TryParse(array[0], out dateTime);
							DateTime t = Conversions.ToDate(OO_00oOO.ApplicationVertion());
							if (DateTime.Compare(dateTime, t) <= 0)
							{
								if (A_0 != 4)
								{
									MessageBox.Show("您正在使用的Foxtable已经是最新版本！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								}
								return true;
							}
							if (MessageBox.Show(array[1].Replace("{0}", Strings.Format(dateTime, "yyyy-MM-dd")), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
							{
								Process.Start("iexplore.exe", array[2]);
								return true;
							}
						}
					}
				}
				catch (Exception a_)
				{
					if (A_0 == 1)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
				}
				result = false;
			}
			else
			{
				DateTime dateTime2 = Conversions.ToDate(OO_00oOO.ApplicationVertion());
				new Process();
				int value = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(OO_00oOO.IssueName(), "开发版", true) == 0, 1, 0));
				string text2 = o_o_O0OO_0__.O.ooOo__o000OO.();
				string text3 = o_o_O0OO_0__.O0_O_o.o_.();
				string str = null;
				string str2 = null;
				o0OO__.oOO.o_.(ref str, ref str2);
				string text4 = str + str2;
				string text5;
				if (Operators.CompareString(o0OO__.O.0ooOoO_0_.("hubiao2012"), "F330056DB66FD827313200", true) == 0)
				{
					text5 = (Conversions.ToLong(o_O_o_oOoo__.OOOO_OO._oo.(text4)) ^ Conversions.ToLong(text4)).ToString();
					text5 = text5.PadRight(16, '0').Substring(0, 16);
					text5 = Strings.Format(Conversions.ToLong(text5), "0000-0000-0000-0000");
				}
				else
				{
					text5 = "{" + Strings.Format(Conversions.ToLong(text4), "0000-0000-0000-0000") + "}";
				}
				if (A_0 == 2)
				{
					text3 = "$" + text3;
				}
				else if (A_0 == 3)
				{
					text3 = "$$" + text3;
				}
				else if (A_0 == 4)
				{
					text3 = "$$$" + text3;
				}
				try
				{
					string text6 = string.Concat(new string[]
					{
						"http://www.foxtable.com/verify/Verify.aspx?lx=",
						Conversions.ToString(value),
						"&bh=",
						text5,
						"&jqm=",
						text2,
						"&zcm=",
						text3,
						"&bb=",
						Conversions.ToString(dateTime2),
						"&rt=4"
					});
					DateTime dateTime3;
					if (DateTime.TryParse(new HttpClient(text6).GetData(true), out dateTime3))
					{
						if (DateTime.Compare(dateTime2, dateTime3) >= 0)
						{
							if (A_0 == 1)
							{
								MessageBox.Show("您正在使用的Foxtable已经是最新版本！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							}
							return true;
						}
						if (MessageBox.Show("Foxtable的最新版本" + Strings.Format(dateTime3, "yyyy-MM-dd") + "已经发布, 是否现在下载？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
						{
							text6 = string.Concat(new string[]
							{
								"http://www.foxtable.com/verify/Verify.aspx?lx=",
								Conversions.ToString(value),
								"&bh=",
								text5,
								"&jqm=",
								text2,
								"&zcm=",
								text3,
								"&bb=",
								Conversions.ToString(dateTime2),
								"&rt=1"
							});
							Process.Start("iexplore.exe", text6);
							return true;
						}
					}
				}
				catch (Exception a_2)
				{
					if (A_0 == 1)
					{
						ooO.oOo0Oo.o.(a_2, "");
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x0020BF80 File Offset: 0x0020A180
		internal static int <<EMPTY_NAME>>()
		{
			int num2;
			short num = (short)num2;
			bool flag = Oo0OO_oo.O.__00O0.(ref num, o0OO__.OO0oO.o.) != 0;
			num2 = (int)num;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				result = num2;
			}
			return result;
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x0020BFA8 File Offset: 0x0020A1A8
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			if (!o0OO__.O_0_O0_OO.0Ooo.())
			{
			}
			string text = null;
			string result;
			if (Oo0OO_oo.o_o0oO000.0_.(A_0, ref text, o0OO__.OO0oO.o.) == 0)
			{
				result = text;
			}
			else
			{
				result = A_0;
			}
			return result;
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x0020BFD8 File Offset: 0x0020A1D8
		internal static bool <<EMPTY_NAME>>()
		{
			int num;
			bool result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = o0OO__.OO0oO.o.(1600, 50, false).Trim();
				IL_1D:
				num2 = 3;
				string text2 = "";
				IL_26:
				num2 = 4;
				string text3 = "";
				IL_2F:
				num2 = 5;
				o0OO__.oOO.o_.(ref text2, ref text3);
				IL_3A:
				num2 = 6;
				text = text.Replace("?", "").Trim();
				IL_54:
				num2 = 7;
				if (Operators.CompareString(text, "", true) <= 0 || text.Length != 34 || text.IndexOf('\0') >= 0)
				{
					goto IL_B7;
				}
				IL_7C:
				num2 = 8;
				if (Operators.CompareString(text, o0OO__.O.0ooOoO_0_.(text2 + text3), true) == 0 && Operators.CompareString(o0OO__.O.0ooOoO_0_.("datasoft"), "E89F1CD11523466200", true) == 0)
				{
					goto IL_DB;
				}
				IL_AD:
				num2 = 9;
				result = false;
				goto IL_21F;
				IL_B7:
				num2 = 11;
				if (Operators.CompareString(o0OO__.O.0ooOoO_0_.("datasoft"), "E89F1CD11523466200", true) == 0)
				{
					goto IL_DB;
				}
				IL_D1:
				num2 = 12;
				result = false;
				goto IL_21F;
				IL_DB:
				num2 = 13;
				text = o0OO__.OO0oO.o.(1650, 50, false).Trim();
				IL_F2:
				num2 = 14;
				text = text.Replace("?", "").Trim();
				IL_10D:
				num2 = 15;
				if (Operators.CompareString(text, "", true) <= 0 || text.Length != 18 || text.IndexOf('\0') >= 0)
				{
					goto IL_17E;
				}
				IL_136:
				num2 = 16;
				DateTime dateTime = o0OO__.oOO.o_.();
				IL_140:
				num2 = 17;
				string text4 = Strings.Format(dateTime, "yyyyMMdd");
				IL_156:
				num2 = 18;
				text4 = o0OO__.O.0ooOoO_0_.(text4);
				IL_162:
				num2 = 19;
				if (Operators.CompareString(text, text4, true) == 0)
				{
					goto IL_21A;
				}
				IL_174:
				num2 = 20;
				result = false;
				goto IL_21F;
				IL_17E:
				num2 = 22;
				string text5 = o0OO__.OO0oO.o.(1800, 50, false).Trim();
				IL_195:
				num2 = 23;
				text5 = O00.oO_.0o_oo_0O_.(text5, text2, text3);
				IL_1A5:
				num2 = 24;
				DateTime dateTime2 = new DateTime(Conversions.ToInteger(text5.Substring(0, 4)), Conversions.ToInteger(text5.Substring(4, 2)), Conversions.ToInteger(text5.Substring(6, 2)));
				IL_1D9:
				num2 = 25;
				string text6 = Strings.Format(dateTime2, "yyyyMMdd");
				IL_1EF:
				num2 = 26;
				text6 = o0OO__.O.0ooOoO_0_.(text6);
				IL_1FB:
				num2 = 27;
				text6 = text6.PadRight(50);
				IL_209:
				num2 = 28;
				o0OO__.OO0oO.o.(text6, 1650, false);
				IL_21A:
				num2 = 29;
				result = true;
				IL_21F:
				goto IL_2E9;
				IL_224:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2AA:
				goto IL_2DE;
				IL_2AC:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2BC:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2AC;
			}
			IL_2DE:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2E9:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x0020C2F4 File Offset: 0x0020A4F4
		internal static bool <<EMPTY_NAME>>()
		{
			int num;
			bool result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (o0OO__.OO0oO.o. != BooleanEnum.Default)
				{
					goto IL_13F;
				}
				IL_13:
				num2 = 3;
				o0OO__.OO0oO.o. = BooleanEnum.False;
				IL_1B:
				num2 = 4;
				string left = o0OO__.OO0oO.o.(o0OO__.O0o.__O. + 225, o0OO__.oO_.0o_oo_0O_. - 25, false).Trim();
				IL_3D:
				num2 = 5;
				string text = "";
				IL_46:
				num2 = 6;
				string text2 = "";
				IL_4F:
				num2 = 7;
				o0OO__.oOO.o_.(ref text, ref text2);
				IL_5A:
				num2 = 8;
				string text3 = text + text2;
				IL_67:
				num2 = 9;
				text3 = O00.ooo000o_0.00o0.(text3, text2, text);
				IL_77:
				num2 = 10;
				text3 = Strings.Left(O00.MD5Encrypt(text3), o0OO__.ooo000o_0.00o0. - 25);
				IL_90:
				num2 = 11;
				if (Operators.CompareString(left, text3, true) != 0)
				{
					goto IL_A8;
				}
				IL_9F:
				num2 = 12;
				o0OO__.OO0oO.o. = BooleanEnum.True;
				IL_A8:
				num2 = 13;
				if (o0OO__.OO0oO.o. != BooleanEnum.False)
				{
					goto IL_13F;
				}
				IL_B6:
				num2 = 14;
				DateTime d = o0OO__.oOO.o_.();
				IL_C0:
				num2 = 15;
				Version version = c.Oo.__O0.().Info.Version;
				IL_D4:
				num2 = 16;
				DateTime dateTime = new DateTime(version.Major, version.Minor, version.Build);
				IL_F3:
				version = null;
				IL_F6:
				num2 = 18;
				if (DateTime.Compare(DateTime.Today, dateTime.AddDays(-15.0)) < 0 || (d - DateTime.Today).TotalDays <= (double)(10 * o0OO__.o.O0o00o0.))
				{
					goto IL_13F;
				}
				IL_136:
				num2 = 19;
				o0OO__.OO0oO.o. = BooleanEnum.True;
				IL_13F:
				num2 = 20;
				result = (o0OO__.OO0oO.o. == BooleanEnum.True);
				IL_14B:
				goto IL_1F1;
				IL_150:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1B2:
				goto IL_1E6;
				IL_1B4:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1C4:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1B4;
			}
			IL_1E6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1F1:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x0020C518 File Offset: 0x0020A718
		internal static string <<EMPTY_NAME>>()
		{
			string text = "";
			string text2 = "";
			o0OO__.oOO.o_.(ref text, ref text2);
			string text3 = O00.EncryptText(o0OO__.O.0ooOoO_0_.(text + text2), text, text2);
			int num = 4096;
			foreach (char @string in text3)
			{
				num += Strings.Asc(@string);
			}
			return Strings.Format(num % 10000, "").PadLeft(4, '0');
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x0020C59C File Offset: 0x0020A79C
		internal static string <<EMPTY_NAME>>()
		{
			int num = Conversions.ToInteger(c.OOOOO.o.().Registry.GetValue("HKEY_CURRENT_USER\\Software\\FoxTable", "RegisterCode", 1));
			num = 500 + (Math.Min(Math.Max(1, num), 3) - 1) * 10;
			string result;
			if (Operators.CompareString(o0OO__.OO0oO.o.(num, 1, false), "Y", true) == 0)
			{
				result = o0OO__.OO0oO.o.(num + 1, 4, false);
			}
			else
			{
				result = "0000";
			}
			return result;
		}

		// Token: 0x04001E0D RID: 7693
		internal static string <<EMPTY_NAME>>;

		// Token: 0x04001E0E RID: 7694
		private static int <<EMPTY_NAME>> = 1700;

		// Token: 0x04001E0F RID: 7695
		private static int <<EMPTY_NAME>> = 100;

		// Token: 0x04001E10 RID: 7696
		private static int <<EMPTY_NAME>> = 100;

		// Token: 0x04001E11 RID: 7697
		private static int <<EMPTY_NAME>> = 512;

		// Token: 0x04001E12 RID: 7698
		private static BooleanEnum <<EMPTY_NAME>>;
	}
}
