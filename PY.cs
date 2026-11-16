using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 用于获取汉字的拼音
	/// </summary>
	// Token: 0x020000D0 RID: 208
	[oO0oooo("3279")]
	public class PY
	{
		// Token: 0x06000944 RID: 2372 RVA: 0x0004C234 File Offset: 0x0004A434
		static PY()
		{
			if (OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "pydb.mdb"))
			{
				PY.O0OOo0_._. = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + O_O0OO.o.00O_O.() + "pydb.mdb;Persist Security Info=False");
				PY.Oo_O.0o0_. = new OleDbCommand("select py+yd from 汉字 where hz = ?", PY.O0OOo0_._.);
				PY.Oo_O.0o0_..Parameters.AddWithValue("#hz", ' ');
				PY.OO.o_Oo. = new OleDbCommand("select py+yd from 姓氏 where hz = ?", PY.O0OOo0_._.);
				PY.OO.o_Oo..Parameters.AddWithValue("#hz", ' ');
				PY.O0OOo0_._..Open();
			}
		}

		/// <summary>
		/// 用于判断给定的字符是否是汉字
		/// </summary>
		/// <param name="[char]">要判断的字符</param>
		// Token: 0x06000945 RID: 2373 RVA: 0x0004C2FB File Offset: 0x0004A4FB
		public static bool IsHanzi(char @char)
		{
			return Regex.IsMatch(@char.ToString(), "[\\u4e00-\\u9fbb]");
		}

		/// <summary>
		/// 用于获取汉字姓名的拼音
		/// </summary>
		/// <param name="Input">姓名字符串</param>
		// Token: 0x06000946 RID: 2374 RVA: 0x0004C310 File Offset: 0x0004A510
		public static string GetNamePY(string Input)
		{
			string text = PY.O0OOo0_._.(Conversions.ToString(Input[0]), false, 0, PY.OO.o_Oo.);
			if (string.IsNullOrEmpty(text))
			{
				text = PY.O0OOo0_._.(Conversions.ToString(Input[0]), false, 0, PY.Oo_O.0o0_.);
			}
			if (Input.Length > 1)
			{
				text = text + " " + PY.O0OOo0_._.(Input.Substring(1), false, 0, PY.Oo_O.0o0_.);
			}
			return text;
		}

		/// <summary>
		/// 用于获取汉字姓名的拼音
		/// </summary>
		/// <param name="Input">姓名字符串</param>
		/// <param name="TitleCase">是否返回首字母大写的拼音</param>
		// Token: 0x06000947 RID: 2375 RVA: 0x0004C380 File Offset: 0x0004A580
		public static string GetNamePY(string Input, bool TitleCase)
		{
			string text = PY.O0OOo0_._.(Conversions.ToString(Input[0]), TitleCase, 0, PY.OO.o_Oo.);
			if (string.IsNullOrEmpty(text))
			{
				text = PY.O0OOo0_._.(Conversions.ToString(Input[0]), TitleCase, 0, PY.Oo_O.0o0_.);
			}
			if (Input.Length > 1)
			{
				text = text + " " + PY.O0OOo0_._.(Input.Substring(1), TitleCase, 0, PY.Oo_O.0o0_.);
			}
			return text;
		}

		/// <summary>
		/// 用于获取汉字姓名的拼音
		/// </summary>
		/// <param name="Input">姓名字符串</param>
		/// <param name="TitleCase">是否返回首字母大写的拼音</param>
		/// <param name="mode">用于设置返回拼音的格式</param>
		// Token: 0x06000948 RID: 2376 RVA: 0x0004C3F0 File Offset: 0x0004A5F0
		public static string GetNamePY(string Input, bool TitleCase, int mode)
		{
			string text = PY.O0OOo0_._.(Conversions.ToString(Input[0]), TitleCase, mode, PY.OO.o_Oo.);
			if (string.IsNullOrEmpty(text))
			{
				text = PY.O0OOo0_._.(Conversions.ToString(Input[0]), TitleCase, mode, PY.Oo_O.0o0_.);
			}
			if (Input.Length > 1)
			{
				text = text + Interaction.IIf(mode == 3, "", " ").ToString() + PY.O0OOo0_._.(Input.Substring(1), TitleCase, mode, PY.Oo_O.0o0_.);
			}
			return text;
		}

		/// <summary>
		/// 用于获取汉字的拼音
		/// </summary>
		/// <param name="Input">汉字字符串</param>
		// Token: 0x06000949 RID: 2377 RVA: 0x0004C473 File Offset: 0x0004A673
		public static string GetPY(string Input)
		{
			return PY.O0OOo0_._.(Input, false, 0, PY.Oo_O.0o0_.);
		}

		/// <summary>
		/// 用于获取汉字的拼音
		/// </summary>
		/// <param name="Input">汉字字符串</param>
		/// <param name="TitleCase">是否返回首字母大写的拼音</param>
		// Token: 0x0600094A RID: 2378 RVA: 0x0004C482 File Offset: 0x0004A682
		public static string GetPY(string Input, bool TitleCase)
		{
			return PY.O0OOo0_._.(Input, TitleCase, 0, PY.Oo_O.0o0_.);
		}

		/// <summary>
		/// 用于获取汉字的拼音
		/// </summary>
		/// <param name="Input">汉字字符串</param>
		/// <param name="TitleCase">是否返回首字母大写的拼音</param>
		/// <param name="Mode">用于设置返回拼音的格式</param>
		// Token: 0x0600094B RID: 2379 RVA: 0x0004C491 File Offset: 0x0004A691
		public static string GetPY(string Input, bool TitleCase, int Mode)
		{
			return PY.O0OOo0_._.(Input, TitleCase, Mode, PY.Oo_O.0o0_.);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0004C4A0 File Offset: 0x0004A6A0
		private static string <<EMPTY_NAME>>(string A_0, bool A_1, int A_2, OleDbCommand A_3)
		{
			int num;
			string result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				StringBuilder stringBuilder = new StringBuilder();
				IL_10:
				num2 = 3;
				foreach (char c in A_0)
				{
					IL_28:
					num2 = 4;
					if (!PY.IsHanzi(c))
					{
						IL_33:
						num2 = 5;
						stringBuilder.Append(c);
					}
					else
					{
						IL_44:
						num2 = 7;
						string text = "";
						IL_4D:
						num2 = 8;
						if (A_3 != PY.Oo_O.0o0_. || !PY.Oo_O.0o0_..TryGetValue(c, out text))
						{
							IL_6A:
							num2 = 10;
							if (A_3 != PY.OO.o_Oo. || !PY.OO.o_Oo..TryGetValue(c, out text))
							{
								IL_85:
								num2 = 12;
								A_3.Parameters[0].Value = c;
								IL_A0:
								num2 = 13;
								object objectValue = RuntimeHelpers.GetObjectValue(A_3.ExecuteScalar());
								IL_B0:
								num2 = 14;
								if (objectValue != null)
								{
									IL_B7:
									num2 = 15;
									text = objectValue.ToString();
									IL_C3:
									num2 = 16;
									if (A_3 == PY.Oo_O.0o0_.)
									{
										IL_CE:
										num2 = 17;
										PY.Oo_O.0o0_..Add(c, text);
									}
									else
									{
										IL_E1:
										num2 = 19;
										PY.OO.o_Oo..Add(c, text);
									}
								}
							}
						}
						IL_F2:
						num2 = 20;
						if (Operators.CompareString(text, "", true) > 0)
						{
							IL_108:
							num2 = 21;
							if (A_2 == 2)
							{
								IL_10F:
								num2 = 22;
								text = PY.O0OOo0_._.(text);
							}
							IL_11B:
							num2 = 23;
							if (A_1)
							{
								IL_121:
								num2 = 24;
								text = text.Substring(0, 1).ToUpper() + text.Substring(1);
							}
							IL_141:
							num2 = 25;
							if (A_2 == 0)
							{
								IL_147:
								num2 = 26;
								stringBuilder.Append(text.Substring(0, text.Length - 1) + " ");
							}
							else
							{
								IL_16F:
								num2 = 28;
								if (A_2 == 1 || A_2 == 2)
								{
									IL_17A:
									num2 = 29;
									stringBuilder.Append(text + " ");
								}
								else
								{
									IL_193:
									num2 = 31;
									if (A_2 == 3)
									{
										IL_19A:
										num2 = 32;
										stringBuilder.Append(text.Substring(0, 1));
									}
								}
							}
						}
					}
					IL_1AE:
					num2 = 33;
				}
				IL_1C5:
				num2 = 34;
				result = stringBuilder.ToString().Trim(new char[]
				{
					' '
				});
				IL_1E0:
				goto IL_2BE;
				IL_1E5:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_27F:
				goto IL_2B3;
				IL_281:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_291:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_281;
			}
			IL_2B3:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2BE:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0004C790 File Offset: 0x0004A990
		private static string <<EMPTY_NAME>>(string A_0)
		{
			int num;
			string result;
			int num10;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string[] array = new string[]
				{
					"ua",
					"ue",
					"ui",
					"uo",
					"ia",
					"ie",
					"iu",
					"iong"
				};
				IL_51:
				num2 = 3;
				string text = A_0.ToLower();
				IL_5B:
				num2 = 4;
				int num3 = (int)Math.Round(char.GetNumericValue(text[text.Length - 1]));
				IL_7A:
				num2 = 5;
				if (num3 > 0)
				{
					goto IL_8B;
				}
				IL_81:
				num2 = 6;
				result = text;
				goto IL_27F;
				IL_8B:
				num2 = 7;
				StringBuilder stringBuilder = new StringBuilder();
				IL_94:
				num2 = 8;
				text = text.Substring(0, text.Length - 1);
				IL_A9:
				num2 = 9;
				int num4 = array.Length - 1;
				for (int i = 0; i <= num4; i++)
				{
					IL_BC:
					num2 = 10;
					int num5 = text.IndexOf(array[i]);
					IL_CD:
					num2 = 11;
					if (num5 >= 0)
					{
						IL_D8:
						num2 = 12;
						stringBuilder.Append(text.Substring(0, num5));
						IL_ED:
						num2 = 13;
						char value = array[i][1];
						IL_FD:
						num2 = 14;
						int num6 = "aeiou".IndexOf(value);
						IL_10E:
						num2 = 15;
						value = "āáăàaēéĕèeīíĭìiōóŏòoūúŭùu"[num6 * 5 + num3 - 1];
						IL_126:
						num2 = 16;
						stringBuilder.Append(Conversions.ToString(array[i][0]) + Conversions.ToString(value));
						IL_14D:
						num2 = 17;
						if (array[i].Length > 2)
						{
							IL_15D:
							num2 = 18;
							stringBuilder.Append(array[i].Substring(2));
						}
						IL_173:
						num2 = 19;
						if (num5 + array[i].Length < text.Length)
						{
							IL_18C:
							num2 = 20;
							stringBuilder.Append(text.Substring(num5 + array[i].Length));
						}
						IL_1AB:
						num2 = 21;
						result = stringBuilder.ToString();
						goto IL_27F;
					}
					IL_1BB:
					num2 = 22;
				}
				IL_1CD:
				num2 = 23;
				int num7 = text.Length - 1;
				int j = 0;
				while (j <= num7)
				{
					IL_1E3:
					num2 = 24;
					string value2 = Conversions.ToString(text[j]);
					IL_1F6:
					num2 = 25;
					int num8 = "aeiou".IndexOf(value2);
					IL_207:
					num2 = 26;
					if (num8 >= 0)
					{
						IL_20F:
						num2 = 27;
						stringBuilder.Append("āáăàaēéĕèeīíĭìiōóŏòoūúŭùu"[num8 * 5 + num3 - 1]);
						IL_22D:
						num2 = 28;
						if (j < text.Length - 1)
						{
							IL_23D:
							num2 = 29;
							stringBuilder.Append(text.Substring(j + 1));
							break;
						}
						break;
					}
					else
					{
						IL_255:
						num2 = 32;
						stringBuilder.Append(value2);
						IL_262:
						num2 = 33;
						j++;
					}
				}
				IL_274:
				num2 = 34;
				result = stringBuilder.ToString();
				IL_27F:
				goto IL_35D;
				IL_284:
				int num9 = num10 + 1;
				num10 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9);
				IL_31E:
				goto IL_352;
				IL_320:
				num10 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_330:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num10 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_320;
			}
			IL_352:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_35D:
			if (num10 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04000354 RID: 852
		private static OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x04000355 RID: 853
		private static OleDbCommand <<EMPTY_NAME>>;

		// Token: 0x04000356 RID: 854
		private static OleDbCommand <<EMPTY_NAME>>;

		// Token: 0x04000357 RID: 855
		private static Dictionary<char, string> <<EMPTY_NAME>> = new Dictionary<char, string>();

		// Token: 0x04000358 RID: 856
		private static Dictionary<char, string> <<EMPTY_NAME>> = new Dictionary<char, string>();
	}
}
