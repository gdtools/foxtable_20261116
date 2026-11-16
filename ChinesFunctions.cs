using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001E2 RID: 482
	[StandardModule]
	public sealed class ChinesFunctions
	{
		/// <summary>
		///
		/// </summary>
		/// <param name="hzString">要转换的汉字字符串</param>
		/// <param name="Initial">可选参数，如果设为True，返回拼音缩写(由首字母组成)。</param>
		// Token: 0x060017FE RID: 6142 RVA: 0x000AA766 File Offset: 0x000A8966
		[oO0oooo("3240")]
		public static string GetPY(string hzString, bool Initial = false)
		{
			return ChinesFunctions.O_OO_0O.Oo0.(hzString, Initial);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000AA770 File Offset: 0x000A8970
		private static string <<EMPTY_NAME>>(string A_0, bool A_1 = false)
		{
			string text = "";
			string result;
			if (A_1)
			{
				result = ChinesFunctions.GetPY2(A_0);
			}
			else
			{
				foreach (char c in A_0)
				{
					if (char.IsLetter(c) && Strings.Asc(c) < 0)
					{
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += " ";
						}
						string text2 = chs2py.convert(Conversions.ToString(c));
						if (Operators.CompareString(text2, "", true) > 0)
						{
							text += text2;
						}
						else
						{
							text += Conversions.ToString(c);
						}
					}
					else
					{
						text += Conversions.ToString(c);
					}
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000AA82E File Offset: 0x000A8A2E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string GetPY2(string strWords)
		{
			return ChinesFunctions.o._0.(strWords);
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x000AA838 File Offset: 0x000A8A38
		private static string <<EMPTY_NAME>>(string A_0)
		{
			string text = "";
			int num = A_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string a_ = A_0.Substring(i, 1);
				text += ChinesFunctions.o.O_0_.(a_);
			}
			return text;
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x000AA880 File Offset: 0x000A8A80
		private static string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (A_0.CompareTo("吖") < 0)
			{
				result = A_0;
			}
			else if (A_0.CompareTo("八") < 0)
			{
				result = "A";
			}
			else if (A_0.CompareTo("嚓") < 0)
			{
				result = "B";
			}
			else if (A_0.CompareTo("咑") < 0)
			{
				result = "C";
			}
			else if (A_0.CompareTo("妸") < 0)
			{
				result = "D";
			}
			else if (A_0.CompareTo("发") < 0)
			{
				result = "E";
			}
			else if (A_0.CompareTo("旮") < 0)
			{
				result = "F";
			}
			else if (A_0.CompareTo("铪") < 0)
			{
				result = "G";
			}
			else if (A_0.CompareTo("讥") < 0)
			{
				result = "H";
			}
			else if (A_0.CompareTo("咔") < 0)
			{
				result = "J";
			}
			else if (A_0.CompareTo("垃") < 0)
			{
				result = "K";
			}
			else if (A_0.CompareTo("嘸") < 0)
			{
				result = "L";
			}
			else if (A_0.CompareTo("拏") < 0)
			{
				result = "M";
			}
			else if (A_0.CompareTo("噢") < 0)
			{
				result = "N";
			}
			else if (A_0.CompareTo("妑") < 0)
			{
				result = "O";
			}
			else if (A_0.CompareTo("七") < 0)
			{
				result = "P";
			}
			else if (A_0.CompareTo("亽") < 0)
			{
				result = "Q";
			}
			else if (A_0.CompareTo("仨") < 0)
			{
				result = "R";
			}
			else if (A_0.CompareTo("他") < 0)
			{
				result = "S";
			}
			else if (A_0.CompareTo("哇") < 0)
			{
				result = "T";
			}
			else if (A_0.CompareTo("夕") < 0)
			{
				result = "W";
			}
			else if (A_0.CompareTo("丫") < 0)
			{
				result = "X";
			}
			else if (A_0.CompareTo("帀") < 0)
			{
				result = "Y";
			}
			else if (A_0.CompareTo("咗") < 0)
			{
				result = "Z";
			}
			else
			{
				result = A_0;
			}
			return result;
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x000AAAD2 File Offset: 0x000A8CD2
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Fract(double V, double Precision = 0.001)
		{
			return ChinesFunctions.O_OO_0O.Oo0.(V, Precision);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x000AAADC File Offset: 0x000A8CDC
		private static string <<EMPTY_NAME>>(double A_0, double A_1 = 0.001)
		{
			long num = 30L;
			double num2 = 1E-06;
			double num3 = A_0;
			long num4 = 1L;
			long num5 = 0L;
			long num6 = 0L;
			long num7 = 1L;
			long num8 = num;
			long num11;
			long num12;
			for (long num9 = 0L; num9 <= num8; num9 += 1L)
			{
				long num10 = (long)Math.Floor(num3);
				num3 -= (double)num10;
				num11 = num4 * num10 + num6;
				num12 = num5 * num10 + num7;
				num6 = num4;
				num7 = num5;
				num4 = num11;
				num5 = num12;
				if (num3 < num2 || Math.Abs(A_0 - (double)num11 / (double)num12) < A_1)
				{
					break;
				}
				num3 = 1.0 / num3;
			}
			return Conversions.ToString(num11) + "/" + Conversions.ToString(num12);
		}

		/// <summary>
		/// 从身份证号码中读取出生日期
		/// </summary>
		/// <param name="PIN">身份证号码</param>
		// Token: 0x06001805 RID: 6149 RVA: 0x000AAB81 File Offset: 0x000A8D81
		[oO0oooo("0320")]
		public static DateTime ReadBirthDay(string PIN)
		{
			return ChinesFunctions.O_OO_0O.Oo0.(PIN);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x000AAB8C File Offset: 0x000A8D8C
		private static DateTime <<EMPTY_NAME>>(string A_0)
		{
			DateTime dateTime;
			if (Strings.Len(A_0) == 15)
			{
				if (Information.IsDate(string.Concat(new string[]
				{
					Strings.Mid(A_0, 7, 2),
					"-",
					Strings.Mid(A_0, 9, 2),
					"-",
					Strings.Mid(A_0, 11, 2)
				})))
				{
					dateTime = DateTime.Parse(string.Concat(new string[]
					{
						Strings.Mid(A_0, 7, 2),
						"-",
						Strings.Mid(A_0, 9, 2),
						"-",
						Strings.Mid(A_0, 11, 2)
					}));
				}
			}
			else if (Strings.Len(A_0) == 18 && Information.IsDate(string.Concat(new string[]
			{
				Strings.Mid(A_0, 7, 4),
				"-",
				Strings.Mid(A_0, 11, 2),
				"-",
				Strings.Mid(A_0, 13, 2)
			})))
			{
				dateTime = DateTime.Parse(string.Concat(new string[]
				{
					Strings.Mid(A_0, 7, 4),
					"-",
					Strings.Mid(A_0, 11, 2),
					"-",
					Strings.Mid(A_0, 13, 2)
				}));
			}
			if (DateTime.Compare(dateTime, DateTime.Today) > 0)
			{
				dateTime = dateTime.AddYears(-100);
			}
			return dateTime;
		}

		/// <summary>
		/// 用于校验身份证号码是否正确
		/// </summary>
		/// <param name="PIN">身份证号码</param>
		// Token: 0x06001807 RID: 6151 RVA: 0x000AACE6 File Offset: 0x000A8EE6
		[oO0oooo("2624")]
		public static bool ValidPIN(string PIN)
		{
			return ChinesFunctions.oOo___._0___0_.(PIN);
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x000AACF0 File Offset: 0x000A8EF0
		private static bool <<EMPTY_NAME>>(string A_0)
		{
			bool result;
			if (A_0.Length != 18)
			{
				result = false;
			}
			else
			{
				int[] array = new int[]
				{
					7,
					9,
					10,
					5,
					8,
					4,
					2,
					1,
					6,
					3,
					7,
					9,
					10,
					5,
					8,
					4,
					2
				};
				string text = "10X98765432";
				int num = 0;
				int num2;
				do
				{
					string value = Conversions.ToString(A_0[num]);
					num2 += Conversions.ToInteger(value) * array[num];
					num++;
				}
				while (num <= 16);
				num2 %= 11;
				result = (text[num2] == A_0[17]);
			}
			return result;
		}

		/// <summary>
		/// 从身份证号码中读取性别
		/// </summary>
		/// <param name="PIN">身份证号码</param>
		// Token: 0x06001809 RID: 6153 RVA: 0x000AAD69 File Offset: 0x000A8F69
		[oO0oooo("0321")]
		public static string ReadSex(string PIN)
		{
			return ChinesFunctions.OO__O__O_oo.0.(PIN);
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x000AAD74 File Offset: 0x000A8F74
		private static string <<EMPTY_NAME>>(string A_0)
		{
			if (Strings.Len(A_0) == 15)
			{
				if (Information.IsDate(string.Concat(new string[]
				{
					Strings.Mid(A_0, 7, 2),
					"-",
					Strings.Mid(A_0, 9, 2),
					"-",
					Strings.Mid(A_0, 11, 2)
				})))
				{
					return Interaction.IIf(int.Parse(Strings.Right(A_0, 1)) % 2 == 0, "女", "男").ToString();
				}
			}
			else if (Strings.Len(A_0) == 18 && Information.IsDate(string.Concat(new string[]
			{
				Strings.Mid(A_0, 7, 4),
				"-",
				Strings.Mid(A_0, 11, 2),
				"-",
				Strings.Mid(A_0, 13, 2)
			})))
			{
				return Interaction.IIf(int.Parse(Strings.Mid(A_0, 17, 1)) % 2 == 0, "女", "男").ToString();
			}
			return "";
		}

		/// <summary>
		/// 将日期转换为大写中文格式
		/// </summary>
		/// <param name="Value">要转换的日期</param>
		// Token: 0x0600180B RID: 6155 RVA: 0x000AAE7B File Offset: 0x000A907B
		[oO0oooo("0317")]
		public static string CUDate(DateTime Value)
		{
			return ChinesFunctions.oOo___._0___0_.(Value, "零壹贰叁肆伍陆柒捌玖拾");
		}

		/// <summary>
		/// 将日期转换为小写中文格式
		/// </summary>
		/// <param name="value"></param>
		// Token: 0x0600180C RID: 6156 RVA: 0x000AAE88 File Offset: 0x000A9088
		[oO0oooo("1578")]
		public static string CLDate(DateTime value)
		{
			return ChinesFunctions.oOo___._0___0_.(value, "○一二三四五六七八九十");
		}

		/// <summary>
		/// 将日期转换为大写中文格式，符合支票格式
		/// </summary>
		/// <param name="value">要转换的日期</param>
		// Token: 0x0600180D RID: 6157 RVA: 0x000AAE95 File Offset: 0x000A9095
		[oO0oooo("1581")]
		public static string CCDate(DateTime value)
		{
			return ChinesFunctions.O_.o_O0O_o__.(value);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000AAEA0 File Offset: 0x000A90A0
		private static string <<EMPTY_NAME>>(DateTime A_0)
		{
			string text = "零壹贰叁肆伍陆柒捌玖拾";
			int year = A_0.Year;
			int month = A_0.Month;
			int day = A_0.Day;
			string text2 = year.ToString();
			string text3 = "";
			int num = text2.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text3 += Conversions.ToString(text[int.Parse(Conversions.ToString(text2[i]))]);
			}
			string text4;
			if (month < 10)
			{
				text4 = "零" + Conversions.ToString(text[month]);
			}
			else if (month == 10)
			{
				text4 = "壹拾";
			}
			else
			{
				text4 = "壹拾" + Conversions.ToString(text[month % 10]);
			}
			string text5;
			if (day < 10)
			{
				text5 = "零" + Conversions.ToString(text[day]);
			}
			else if (day < 10)
			{
				text5 = "零" + Conversions.ToString(text[10]);
			}
			else
			{
				text5 = Strings.Mid(text, day / 10 + 1, 1) + "拾";
				if (day % 10 > 0)
				{
					text5 += Strings.Mid(text, day % 10 + 1, 1);
				}
			}
			return string.Concat(new string[]
			{
				text3,
				"年",
				text4,
				"月",
				text5,
				"日"
			});
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x000AB01C File Offset: 0x000A921C
		private static string <<EMPTY_NAME>>(DateTime A_0, string A_1)
		{
			int year = A_0.Year;
			int month = A_0.Month;
			int day = A_0.Day;
			string text = year.ToString();
			string text2 = "";
			int num = text.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text2 += Conversions.ToString(A_1[int.Parse(Conversions.ToString(text[i]))]);
			}
			string text3;
			if (month < 10)
			{
				text3 = Conversions.ToString(A_1[month]);
			}
			else if (month == 10)
			{
				text3 = Conversions.ToString(A_1[10]);
			}
			else
			{
				text3 = Conversions.ToString(A_1[10]) + Conversions.ToString(A_1[month % 10]);
			}
			string text4;
			if (day < 10)
			{
				text4 = Conversions.ToString(A_1[day]);
			}
			else
			{
				if (day / 10 == 1)
				{
					text4 = Conversions.ToString(A_1[10]);
				}
				else
				{
					text4 = Conversions.ToString(A_1[day / 10]) + Conversions.ToString(A_1[10]);
				}
				if (day % 10 > 0)
				{
					text4 += Conversions.ToString(A_1[day % 10]);
				}
			}
			return string.Concat(new string[]
			{
				text2,
				"年",
				text3,
				"月",
				text4,
				"日"
			});
		}

		/// <summary>
		/// 从一个数值中返回指定位的数字，可用于支票套打
		/// </summary>
		/// <param name="Value">准备取值的数值</param>
		/// <param name="Position">指定位,0表示个位,1表示十位,2表示百位,-1表示小数点后第一位,-2表示小数点后第二位,其余类推</param>
		/// <param name="Symbol">可选，用于指定货币符号，如果省略，则返回人民币符号</param>
		// Token: 0x06001810 RID: 6160 RVA: 0x000AB18E File Offset: 0x000A938E
		[oO0oooo("0319")]
		public static char GetDigit(string Value, int Position, char Symbol = '￥')
		{
			return ChinesFunctions.O_OO_0O.Oo0.(Value, Position, Symbol);
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x000AB198 File Offset: 0x000A9398
		private static char <<EMPTY_NAME>>(string A_0, int A_1, char A_2 = '￥')
		{
			char result;
			if (Operators.CompareString(A_0, "", true) == 0)
			{
				result = '\0';
			}
			else
			{
				string[] array = A_0.Split(new char[]
				{
					(new char[]
					{
						'.'
					})[0]
				});
				if (array[0].Length > 0 & A_1 >= 0)
				{
					array[0] = o_O_o_oOoo__.OOOO_OO._oo.(array[0]);
					if (array[0].Length > A_1)
					{
						result = array[0][A_1];
					}
					else if (array[0].Length == A_1)
					{
						result = A_2;
					}
					else
					{
						result = '\0';
					}
				}
				else if (array.Length > 1 & A_1 < 0)
				{
					if (array[1].Length >= Math.Abs(A_1))
					{
						result = array[1][Math.Abs(A_1) - 1];
					}
					else
					{
						result = '0';
					}
				}
				else if (A_1 < 0)
				{
					result = '0';
				}
				else
				{
					result = '\0';
				}
			}
			return result;
		}

		/// <summary>
		/// 将阿拉伯数字转换为中文格式，符合支票格式
		/// </summary>
		/// <param name="Value">要转换的阿拉伯数字</param>
		// Token: 0x06001812 RID: 6162 RVA: 0x000AB266 File Offset: 0x000A9466
		[oO0oooo("1582")]
		public static string CCNumber(string Value)
		{
			return ChinesFunctions.o_00o.OO00O.(Value);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x000AB270 File Offset: 0x000A9470
		private static string <<EMPTY_NAME>>(string A_0)
		{
			string text;
			if (Versioned.IsNumeric(A_0))
			{
				long num = Conversions.ToLong(A_0);
				text = ChinesFunctions.CUNumber(A_0);
				if (num > 0L & num < 10L)
				{
					text = "零" + text;
				}
			}
			else
			{
				text = A_0;
			}
			return text;
		}

		/// <summary>
		/// 将阿拉伯数字转换为大写中文货币格式
		/// </summary>
		/// <param name="Value">要转换的阿拉伯数字</param>
		// Token: 0x06001814 RID: 6164 RVA: 0x000AB2B2 File Offset: 0x000A94B2
		[oO0oooo("0316")]
		public static string CUMoney(string Value)
		{
			return ChinesFunctions.OO._.(Value);
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x000AB2BC File Offset: 0x000A94BC
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (A_0 == null)
			{
				result = null;
			}
			else
			{
				string[] array = A_0.Split(new char[]
				{
					(new char[]
					{
						'.'
					})[0]
				});
				if (array.Length == 1 || Conversion.Val(array[1]) == 0.0)
				{
					result = ChinesFunctions.CUNumber(array[0]) + "元整";
				}
				else
				{
					result = ChinesFunctions.CUNumber(array[0]) + "元" + ChinesFunctions.O.O0O0O.(array[1]);
				}
			}
			return result;
		}

		/// <summary>
		/// 将数值转换为中文格式
		/// </summary>
		/// <param name="value">要转换的数值</param>
		// Token: 0x06001816 RID: 6166 RVA: 0x000AB340 File Offset: 0x000A9540
		[oO0oooo("0318")]
		public static string CUNumber(string value)
		{
			return ChinesFunctions.O_0_._0__.(value);
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x000AB348 File Offset: 0x000A9548
		private static string <<EMPTY_NAME>>(string A_0)
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "万亿兆";
			A_0 = A_0.TrimEnd(new char[]
			{
				'.'
			});
			string result;
			if (!Versioned.IsNumeric(A_0))
			{
				result = "";
			}
			else if (Conversion.Val(A_0) == 0.0)
			{
				result = "零";
			}
			else
			{
				long num = (long)Math.Floor(Conversion.Val(A_0));
				if (A_0.IndexOf(".") >= 0)
				{
					text = A_0.Substring(A_0.IndexOf('.') + 1);
				}
				if (num > 0L)
				{
					if (num == 0L)
					{
						return "零";
					}
					A_0 = num.ToString();
					int num2 = 1;
					do
					{
						string text6 = Strings.Right(A_0, 4);
						num = long.Parse(text6);
						text6 = num.ToString();
						if (num2 == 1)
						{
							text4 = ChinesFunctions.o0O.o00O0_oOo.(text6);
						}
						else
						{
							if (num > 0L)
							{
								text3 = ChinesFunctions.o0O.o00O0_oOo.(text6) + Conversions.ToString(text5[num2 - 2]);
							}
							if (Operators.CompareString(text4, "", true) > 0)
							{
								if (num == 0L || text2.Length < 4 || text6.EndsWith("0"))
								{
									text4 = text3 + "零" + text4;
								}
								else
								{
									text4 = text3 + text4;
								}
							}
							else
							{
								text4 = text3;
							}
						}
						text2 = text6;
						if (A_0.Length <= 4)
						{
							break;
						}
						A_0 = A_0.Substring(0, A_0.Length - 4);
						num2++;
					}
					while (num2 <= 4);
					text4 = text4.Replace("零零", "零");
					text4 = text4.Replace("零零", "零");
				}
				if (Operators.CompareString(text, "", true) > 0)
				{
					if (Operators.CompareString(text4, "", true) == 0)
					{
						text4 = "零点";
					}
					else
					{
						text4 += "点";
					}
					int num3 = text.Length - text.TrimStart(new char[]
					{
						'0'
					}).Length;
					if (num3 > 0)
					{
						text4 += "零".PadLeft(num3, '零');
					}
					text4 += ChinesFunctions.CUNUM(Conversions.ToInteger(text));
				}
				result = text4;
			}
			return result;
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x000AB57E File Offset: 0x000A977E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string CUDigit(char x)
		{
			return ChinesFunctions.O_.o_O0O_o__.(x);
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x000AB588 File Offset: 0x000A9788
		private static string <<EMPTY_NAME>>(char A_0)
		{
			string result;
			if (!Versioned.IsNumeric(A_0))
			{
				result = null;
			}
			else
			{
				string text = "";
				switch (A_0)
				{
				case '0':
					text = "零";
					break;
				case '1':
					text = "壹";
					break;
				case '2':
					text = "贰";
					break;
				case '3':
					text = "叁";
					break;
				case '4':
					text = "肆";
					break;
				case '5':
					text = "伍";
					break;
				case '6':
					text = "陆";
					break;
				case '7':
					text = "柒";
					break;
				case '8':
					text = "捌";
					break;
				case '9':
					text = "玖";
					break;
				}
				result = text;
			}
			return result;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x000AB638 File Offset: 0x000A9838
		private static string <<EMPTY_NAME>>(string A_0)
		{
			A_0 = o_O_o_oOoo__.OOOO_OO._oo.(A_0);
			int length = A_0.Length;
			string text = "";
			int num = length - 1;
			for (int i = 0; i <= num; i++)
			{
				char expression = A_0[i];
				switch (i)
				{
				case 0:
					if (Conversion.Val(expression) > 0)
					{
						text = ChinesFunctions.CUDigit(A_0[i]);
					}
					break;
				case 1:
					if (Conversion.Val(expression) > 0)
					{
						text = ChinesFunctions.CUDigit(A_0[i]) + "拾" + text;
					}
					else if (Operators.CompareString(text, "", true) > 0)
					{
						text = "零" + text;
					}
					break;
				case 2:
					if (Conversion.Val(expression) > 0)
					{
						text = ChinesFunctions.CUDigit(A_0[i]) + "佰" + text;
					}
					else if (Operators.CompareString(text, "", true) > 0)
					{
						text = "零" + text;
					}
					break;
				case 3:
					text = ChinesFunctions.CUDigit(A_0[i]) + "仟" + text;
					break;
				}
				text = text.Replace("零零", "零");
			}
			return text;
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x000AB75C File Offset: 0x000A995C
		private static string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (A_0.Length == 1)
			{
				result = ChinesFunctions.CUDigit(A_0[0]) + "角整";
			}
			else
			{
				result = (ChinesFunctions.CUDigit(A_0[0]) + "角" + ChinesFunctions.CUDigit(A_0[1]) + "分").Replace("零分", "").Replace("零角", "零");
			}
			return result;
		}

		/// <summary>
		/// 将整数转换为英文大写
		/// </summary>
		/// <param name="Value">要转换的整数</param>
		// Token: 0x0600181C RID: 6172 RVA: 0x000AB7D7 File Offset: 0x000A99D7
		[oO0oooo("0322")]
		public static string EUNumber(string Value)
		{
			return ChinesFunctions.o._o.(Value);
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x000AB7E0 File Offset: 0x000A99E0
		private static string <<EMPTY_NAME>>(string A_0)
		{
			string text = "";
			string[] array = new string[10];
			array[2] = " Thousand ";
			array[3] = " Million ";
			array[4] = " Billion ";
			array[5] = " Trillion ";
			string result;
			if (A_0.Length > 16)
			{
				MessageBox.Show("EUNumber不能转换超过16个有效数字的整数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = "";
			}
			else
			{
				string s = A_0.Trim();
				long num = 0L;
				if (long.TryParse(s, out num))
				{
					num = long.Parse(A_0.Trim());
					A_0 = num.ToString();
					int num2 = 1;
					while (Operators.CompareString(A_0, "", true) != 0)
					{
						string text2 = ChinesFunctions.Oo0oO0_0O.o.(Strings.Right(A_0, 3));
						if (Operators.CompareString(text2, "", true) != 0)
						{
							text = text2 + array[num2] + text;
						}
						if (Strings.Len(A_0) > 3)
						{
							A_0 = Strings.Left(A_0, Strings.Len(A_0) - 3);
						}
						else
						{
							A_0 = "";
						}
						num2++;
					}
					result = text;
				}
				else
				{
					result = "";
				}
			}
			return result;
		}

		/// <summary>
		/// 将数值转换为英文货币格式
		/// </summary>
		/// <param name="Value">要转换的数值</param>
		// Token: 0x0600181E RID: 6174 RVA: 0x000AB8DD File Offset: 0x000A9ADD
		[oO0oooo("0323")]
		public static string EUMoney(string Value)
		{
			return ChinesFunctions.o0__._.(Value);
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000AB8E8 File Offset: 0x000A9AE8
		private static string <<EMPTY_NAME>>(string A_0)
		{
			string text = "";
			A_0 = Strings.Trim(A_0);
			int num = Strings.InStr(A_0, ".", CompareMethod.Text);
			if (num > 0)
			{
				text = ChinesFunctions.o.O_.(Strings.Left(Strings.Mid(A_0, num + 1) + "00", 2));
				A_0 = Strings.Trim(Strings.Left(A_0, num - 1));
			}
			string text2 = ChinesFunctions.EUNumber(A_0);
			string left = text2;
			if (Operators.CompareString(left, "", true) == 0)
			{
				text2 = "";
			}
			else if (Operators.CompareString(left, "One", true) == 0)
			{
				text2 = "One Dollar";
			}
			else
			{
				text2 += " Dollars";
			}
			string left2 = text;
			if (Operators.CompareString(left2, "", true) == 0)
			{
				text = "";
			}
			else if (Operators.CompareString(left2, "One", true) == 0)
			{
				text = "One Cent";
			}
			else
			{
				text += " Cents";
			}
			string result;
			if (Operators.CompareString(text2, "", true) > 0 & Operators.CompareString(text, "", true) > 0)
			{
				result = text2 + " And " + text;
			}
			else
			{
				result = text2 + text;
			}
			return result;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000ABA00 File Offset: 0x000A9C00
		private static string <<EMPTY_NAME>>(string A_0)
		{
			string text = "";
			string result;
			if (Conversion.Val(A_0) == 0.0)
			{
				result = "";
			}
			else
			{
				A_0 = Strings.Right("000" + A_0, 3);
				if (Operators.CompareString(Strings.Left(A_0, 1), "0", true) != 0)
				{
					text = ChinesFunctions.oOo___._0___0_.(Strings.Left(A_0, 1)) + " Hundred ";
					if (Operators.CompareString(Strings.Mid(A_0, 2), "00", true) != 0)
					{
						text += "And ";
					}
				}
				if (Operators.CompareString(Strings.Mid(A_0, 2, 1), "0", true) != 0)
				{
					text += ChinesFunctions.o.O_.(Strings.Mid(A_0, 2));
				}
				else
				{
					text += ChinesFunctions.oOo___._0___0_.(Strings.Mid(A_0, 3));
				}
				result = Strings.Trim(text);
			}
			return result;
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000ABAD4 File Offset: 0x000A9CD4
		private static string <<EMPTY_NAME>>(string A_0)
		{
			string text = "";
			if (Conversion.Val(Strings.Left(A_0, 1)) == 1.0)
			{
				double num = Conversion.Val(A_0);
				if (num == 10.0)
				{
					text = "Ten";
				}
				else if (num == 11.0)
				{
					text = "Eleven";
				}
				else if (num == 12.0)
				{
					text = "Twelve";
				}
				else if (num == 13.0)
				{
					text = "Thirteen";
				}
				else if (num == 14.0)
				{
					text = "Fourteen";
				}
				else if (num == 15.0)
				{
					text = "Fifteen";
				}
				else if (num == 16.0)
				{
					text = "Sixteen";
				}
				else if (num == 17.0)
				{
					text = "Seventeen";
				}
				else if (num == 18.0)
				{
					text = "Eighteen";
				}
				else if (num == 19.0)
				{
					text = "Nineteen";
				}
			}
			else
			{
				double num2 = Conversion.Val(Strings.Left(A_0, 1));
				if (num2 == 2.0)
				{
					text = "Twenty ";
				}
				else if (num2 == 3.0)
				{
					text = "Thirty ";
				}
				else if (num2 == 4.0)
				{
					text = "Forty ";
				}
				else if (num2 == 5.0)
				{
					text = "Fifty ";
				}
				else if (num2 == 6.0)
				{
					text = "Sixty ";
				}
				else if (num2 == 7.0)
				{
					text = "Seventy ";
				}
				else if (num2 == 8.0)
				{
					text = "Eighty ";
				}
				else if (num2 == 9.0)
				{
					text = "Ninety ";
				}
				text += ChinesFunctions.oOo___._0___0_.(Strings.Right(A_0, 1));
			}
			return text;
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000ABCB4 File Offset: 0x000A9EB4
		private static string <<EMPTY_NAME>>(string A_0)
		{
			double num = Conversion.Val(A_0);
			string result;
			if (num == 1.0)
			{
				result = "One";
			}
			else if (num == 2.0)
			{
				result = "Two";
			}
			else if (num == 3.0)
			{
				result = "Three";
			}
			else if (num == 4.0)
			{
				result = "Four";
			}
			else if (num == 5.0)
			{
				result = "Five";
			}
			else if (num == 6.0)
			{
				result = "Six";
			}
			else if (num == 7.0)
			{
				result = "Seven";
			}
			else if (num == 8.0)
			{
				result = "Eight";
			}
			else if (num == 9.0)
			{
				result = "Nine";
			}
			else
			{
				result = "";
			}
			return result;
		}

		/// <summary>
		/// 将字符串转换为全角
		/// </summary>
		/// <param name="str">要转换的字符串</param>
		// Token: 0x06001823 RID: 6179 RVA: 0x000ABD89 File Offset: 0x000A9F89
		[oO0oooo("1620")]
		public static string StrToWide(string str)
		{
			return Strings.StrConv(str, VbStrConv.Wide, 0);
		}

		/// <summary>
		/// 要转换的字符串
		/// </summary>
		/// <param name="str">要转换的字符串</param>
		// Token: 0x06001824 RID: 6180 RVA: 0x000ABD93 File Offset: 0x000A9F93
		[oO0oooo("1621")]
		public static string StrToNarrow(string str)
		{
			return Strings.StrConv(str, VbStrConv.Narrow, 0);
		}

		/// <summary>
		/// 将字符串转换为中文简体
		/// </summary>
		/// <param name="str">要转换的中文字符串</param>
		// Token: 0x06001825 RID: 6181 RVA: 0x000ABD9D File Offset: 0x000A9F9D
		[oO0oooo("1832")]
		public static string StrToSimplified(string str)
		{
			return Strings.StrConv(str, VbStrConv.SimplifiedChinese, 0);
		}

		/// <summary>
		/// 将字符串转换为中文繁体
		/// </summary>
		/// <param name="str">要转换的中文字符串</param>
		// Token: 0x06001826 RID: 6182 RVA: 0x000ABDAB File Offset: 0x000A9FAB
		[oO0oooo("1831")]
		public static string StrToTraditional(string str)
		{
			return Strings.StrConv(str, VbStrConv.TraditionalChinese, 0);
		}

		/// <summary>
		/// 将字符串转换为词首字母大写
		/// </summary>
		/// <param name="str">要转换的字符串</param>
		// Token: 0x06001827 RID: 6183 RVA: 0x000ABDB9 File Offset: 0x000A9FB9
		[oO0oooo("2364")]
		public static string StrToTitleCase(string str)
		{
			return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str);
		}

		/// <summary>
		/// 将10进制数转换为2进制
		/// </summary>
		/// <param name="Dec">要转换的10进制数字</param>
		// Token: 0x06001828 RID: 6184 RVA: 0x000ABDD0 File Offset: 0x000A9FD0
		[oO0oooo("1622")]
		public static string DecToBin(long Dec)
		{
			string text = "";
			while (Dec > 0L)
			{
				text = Conversions.ToString(Dec % 2L) + text;
				Dec /= 2L;
			}
			return text;
		}

		/// <summary>
		/// 将10进制数转换为16进制
		/// </summary>
		/// <param name="Dec">要转换的10进制数字</param>
		// Token: 0x06001829 RID: 6185 RVA: 0x000ABE01 File Offset: 0x000AA001
		[oO0oooo("1622")]
		public static string DecToHex(long Dec)
		{
			return Conversion.Hex(Dec);
		}

		/// <summary>
		/// 将10进制数转换为8进制
		/// </summary>
		/// <param name="Dec">要转换的10进制数字</param>
		// Token: 0x0600182A RID: 6186 RVA: 0x000ABE09 File Offset: 0x000AA009
		[oO0oooo("1622")]
		public static string DecToOct(long Dec)
		{
			return Conversion.Oct(Dec);
		}

		/// <summary>
		/// 将16进制数字转换为10进制
		/// </summary>
		/// <param name="value">要转换的16进制数字</param>
		// Token: 0x0600182B RID: 6187 RVA: 0x000ABE11 File Offset: 0x000AA011
		[oO0oooo("1622")]
		public static long HexToDec(string value)
		{
			return Convert.ToInt64(value, 16);
		}

		/// <summary>
		/// 将8进制数字转换为10进制
		/// </summary>
		/// <param name="value">要转换的8进制数字</param>
		// Token: 0x0600182C RID: 6188 RVA: 0x000ABE1B File Offset: 0x000AA01B
		[oO0oooo("1622")]
		public static long OctToDec(string value)
		{
			return Convert.ToInt64(value, 8);
		}

		/// <summary>
		/// 将2进制数字转换为10进制
		/// </summary>
		/// <param name="value">要转换的2进制数字</param>
		// Token: 0x0600182D RID: 6189 RVA: 0x000ABE24 File Offset: 0x000AA024
		[oO0oooo("1622")]
		public static long BinToDec(string value)
		{
			return Convert.ToInt64(value, 2);
		}

		/// <summary>
		/// 将阿拉伯数字转换为中文大写格式，只能处理整数
		/// </summary>
		/// <param name="value">要转换的阿拉伯数字</param>
		// Token: 0x0600182E RID: 6190 RVA: 0x000ABE30 File Offset: 0x000AA030
		[oO0oooo("2515")]
		public static string CUNUM(int value)
		{
			string text = value.ToString();
			string text2 = "";
			string text3 = "零壹贰叁肆伍陆柒捌玖拾";
			string text4 = text;
			checked
			{
				for (int i = 0; i < text4.Length; i++)
				{
					int index = int.Parse(Conversions.ToString(text4[i]));
					text2 += Conversions.ToString(text3[index]);
				}
				return text2;
			}
		}

		/// <summary>
		/// 将阿拉伯数字转换为中文小写格式，只能处理整数
		/// </summary>
		/// <param name="value">要转换的阿拉伯数字</param>
		// Token: 0x0600182F RID: 6191 RVA: 0x000ABE8C File Offset: 0x000AA08C
		[oO0oooo("2616")]
		public static string CLNUM(int value)
		{
			string text = value.ToString();
			string text2 = "";
			string text3 = "零一二三四五六七八九十";
			string text4 = text;
			checked
			{
				for (int i = 0; i < text4.Length; i++)
				{
					int index = int.Parse(Conversions.ToString(text4[i]));
					text2 += Conversions.ToString(text3[index]);
				}
				return text2;
			}
		}

		/// <summary>
		/// 用于计算两个日期之间相差的年月日
		/// </summary>
		/// <param name="dt1">第一个日期</param>
		/// <param name="dt2">第二个日期</param>
		/// <param name="y">整数型变量，用于保存两个日期之间相差的年数</param>
		/// <param name="m">整数型变量，用于保存两个日期之间相差的月数</param>
		/// <param name="d">整数型变量，用于保存两个日期之间相差的日数</param>
		// Token: 0x06001830 RID: 6192 RVA: 0x000ABEE8 File Offset: 0x000AA0E8
		[oO0oooo("2648")]
		public static void DateYMD(DateTime dt1, DateTime dt2, ref int y, ref int m, ref int d)
		{
			DateTime dateTime;
			if (DateTime.Compare(dt1, dt2) > 0)
			{
				dateTime = dt1;
				dt1 = dt2;
				dt2 = dateTime;
			}
			y = dt2.Year - dt1.Year;
			m = dt2.Month - dt1.Month;
			if (DateTime.Compare(dt1.AddMonths(y * 12), dt2) > 0)
			{
				y--;
				m += 12;
			}
			if (DateTime.Compare(dt1.AddMonths(y * 12 + m), dt2) > 0)
			{
				m--;
			}
			dateTime = dt1.AddMonths(y * 12 + m);
			d = (int)Math.Round((dt2 - dateTime).TotalDays);
		}
	}
}
