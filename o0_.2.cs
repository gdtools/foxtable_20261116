using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000443 RID: 1091
	[StandardModule]
	internal sealed class o0_
	{
		// Token: 0x0600497A RID: 18810 RVA: 0x001FE0E4 File Offset: 0x001FC2E4
		private static void <<EMPTY_NAME>>(List<DataRow> A_0, DataRow A_1)
		{
			A_0.Add(A_1);
			foreach (DataRow a_ in A_1.GetChildRows("Component"))
			{
				o0_.o_000Oo0O_.00o.(A_0, a_);
			}
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x001FE120 File Offset: 0x001FC320
		public static void <<EMPTY_NAME>>(DataTable A_0, string A_1)
		{
			Regex regex = new Regex("(\\b)(?<!System.)(Windows\\.Forms\\.)", RegexOptions.IgnoreCase);
			foreach (DataRow dataRow in A_0.Select("[Type] = " + Conversions.ToString(19)))
			{
				if (!dataRow.IsNull("Config"))
				{
					string text = dataRow["Config"].ToString();
					string a_ = A_1;
					if (text.StartsWith("[") && text.EndsWith("]"))
					{
						text = text.TrimStart(new char[]
						{
							'['
						}).TrimEnd(new char[]
						{
							']'
						});
						a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., A_1.Substring(0, 5)).Substring(0, 5);
					}
					text = O00.oO_.0o_oo_0O_.(text, "API", a_);
					string text2 = regex.Replace(text, "$1System.$2");
					if (text.Length != text2.Length)
					{
						a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., A_1.Substring(0, 5)).Substring(0, 5);
						dataRow["Config"] = "[" + O00.ooo000o_0.00o0.(text2, "API", a_) + "]";
					}
				}
			}
			Oo00.o0_o._O_.(A_0, false);
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x001FE264 File Offset: 0x001FC464
		internal static void <<EMPTY_NAME>>(DataTable A_0)
		{
			Regex regex = new Regex("(\\b)(?<!System.)(Windows\\.Forms\\.)", RegexOptions.IgnoreCase);
			string a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
			foreach (DataRow dataRow in A_0.Select("[Type] = " + Conversions.ToString(9) + " And (SubString([name],1,2) = '![' And SubString([name],len([Name])-1,2) = ']!') = False"))
			{
				if (!dataRow.IsNull("Config"))
				{
					string text = O_O0OO.OoO_00._.(dataRow["Config"].ToString());
					if (!string.IsNullOrEmpty(text))
					{
						string text2 = regex.Replace(text, "$1System.$2");
						if (text.Length != text2.Length)
						{
							dataRow["Config"] = "[" + O00.ooo000o_0.00o0.(text2, "UserFunction", a_) + "]";
						}
					}
				}
			}
			Oo00.o0_o._O_.(A_0, false);
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x001FE34C File Offset: 0x001FC54C
		internal static void <<EMPTY_NAME>>(DataTable A_0)
		{
			Regex regex = new Regex("(\\b)(?<!System.)(Windows\\.Forms\\.)", RegexOptions.IgnoreCase);
			foreach (DataRow dataRow in A_0.Select("[Column] = '' And [Code] Is Not Null"))
			{
				new DataTableProperty();
				string text = DataTable.o.o00O.(Conversions.ToString(dataRow["Code"]));
				if (!string.IsNullOrEmpty(text))
				{
					string text2 = regex.Replace(text, "$1System.$2");
					if (text.Length != text2.Length)
					{
						dataRow["Code"] = "[" + O00.ooo000o_0.00o0.(text2, Oo00.ooO.ooo.(), ooO0__OO.o.0_0_ooO.()) + "]";
					}
				}
			}
			Oo00.o0_o._O_.(A_0, false);
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x001FE3FC File Offset: 0x001FC5FC
		internal static void <<EMPTY_NAME>>(DataTable A_0)
		{
			Regex regex = new Regex("(\\b)(?<!System.)(Windows\\.Forms\\.)", RegexOptions.IgnoreCase);
			string text = ooO0__OO.O_Oo00oO.Ooo.();
			try
			{
				foreach (object obj in A_0.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (!dataRow.IsNull("Code"))
					{
						string text2 = Conversions.ToString(dataRow["Code"]);
						string a_ = text;
						bool flag = false;
						if (text2.StartsWith("{") && text2.EndsWith("}"))
						{
							text2 = text2.TrimStart(new char[]
							{
								'{'
							}).TrimEnd(new char[]
							{
								'}'
							});
							a_ = Oo00.ooO.ooo.();
							flag = true;
						}
						text2 = O00.oO_.0o_oo_0O_.(text2, text, a_);
						if (!string.IsNullOrEmpty(text2))
						{
							string text3 = regex.Replace(text2, "$1System.$2");
							if (text2.Length != text3.Length)
							{
								text2 = O00.ooo000o_0.00o0.(text3, text, a_);
								if (flag)
								{
									text2 = "{" + text2 + "}";
								}
								dataRow["Code"] = text2;
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
			Oo00.o0_o._O_.(A_0, false);
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x001FE554 File Offset: 0x001FC754
		internal static Assembly <<EMPTY_NAME>>(DataTable A_0, string A_1, string A_2, string[] A_3, string A_4, string A_5, DataTable A_6, DataRow A_7 = null)
		{
			int num;
			Assembly result;
			int num6;
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
				if (Operators.CompareString(A_2, "", true) <= 0)
				{
					goto IL_36;
				}
				IL_21:
				num2 = 4;
				stringBuilder.Append(A_2 + "\r\n");
				IL_36:
				num2 = 5;
				if (A_7 != null)
				{
					goto IL_50;
				}
				IL_3C:
				num2 = 6;
				DataRow[] array = A_0.Select(A_1, "", DataViewRowState.CurrentRows);
				goto IL_71;
				IL_50:
				num2 = 8;
				List<DataRow> list = new List<DataRow>();
				IL_59:
				num2 = 9;
				o0_.o_000Oo0O_.00o.(list, A_7);
				IL_65:
				num2 = 10;
				array = list.ToArray();
				IL_71:
				num2 = 11;
				DataRow[] array2 = array;
				int i = 0;
				while (i < array2.Length)
				{
					DataRow dataRow = array2[i];
					IL_87:
					num2 = 12;
					if (Conversions.ToInteger(dataRow["Type"]) != 231)
					{
						goto IL_196;
					}
					IL_A5:
					num2 = 13;
					if (Operators.CompareString(A_4, "WinForm", true) != 0)
					{
						goto IL_196;
					}
					IL_BA:
					num2 = 14;
					string text = string.Concat(new string[]
					{
						OO_00oOO.FileSys.GetParentPath(A_5),
						"\\",
						o0OoOOoOOo0.oo00o.0OoO.(""),
						".Table.",
						Conversions.ToString(dataRow["Key"]),
						".dll"
					});
					IL_112:
					num2 = 15;
					if (dataRow.IsNull("Code"))
					{
						IL_123:
						num2 = 16;
						if (OO_00oOO.FileSys.FileExists(text))
						{
							IL_137:
							num2 = 17;
							OO_00oOO.FileSys.DeleteFile(text);
						}
					}
					else
					{
						IL_14B:
						num2 = 19;
						if (OO_00oOO.FileSys.FileExists(text))
						{
							IL_15C:
							num2 = 20;
							OO_00oOO.FileSys.DeleteFile(text);
						}
						IL_16B:
						num2 = 21;
						DataTableProperty a_ = new DataTableProperty();
						IL_175:
						num2 = 22;
						o_O_o_oOoo__.OOOO_OO._oo.(a_, dataRow, true);
						IL_182:
						num2 = 23;
						o0_.Oo_0.OOo0oO0.(a_, text, A_6);
					}
					IL_90E:
					num2 = 130;
					string text2;
					checked
					{
						i++;
						continue;
						IL_196:
						num2 = 25;
						text2 = "";
						IL_1A0:
						num2 = 26;
						string a_2 = ooO0__OO.O_Oo00oO.Ooo.();
						IL_1AA:
						num2 = 27;
						if (!dataRow.IsNull("Code"))
						{
							IL_1BB:
							num2 = 28;
							text2 = Conversions.ToString(dataRow["Code"]);
							IL_1D1:
							num2 = 29;
							if (text2.StartsWith("{") && text2.EndsWith("}"))
							{
								IL_1F0:
								num2 = 30;
								text2 = text2.TrimStart(new char[]
								{
									'{'
								}).TrimEnd(new char[]
								{
									'}'
								});
								IL_217:
								num2 = 31;
								a_2 = Oo00.ooO.ooo.();
							}
							IL_221:
							num2 = 32;
							text2 = O00.oO_.0o_oo_0O_.(text2, ooO0__OO.O_Oo00oO.Ooo.(), a_2);
						}
						IL_234:
						num2 = 33;
					}
					if (Operators.CompareString(text2, "", true) != 0)
					{
						IL_249:
						num2 = 35;
						string[] array3 = text2.Split(new char[]
						{
							'\v'
						});
						IL_260:
						num2 = 36;
						int num3 = array3.Length - 2;
						for (int j = 0; j <= num3; j += 2)
						{
							IL_273:
							num2 = 37;
							string text3 = "";
							IL_27D:
							num2 = 38;
							string text4 = "";
							IL_287:
							num2 = 39;
							string text5 = array3[j + 1];
							IL_293:
							num2 = 40;
							if (Operators.CompareString(text5, "", true) > 0)
							{
								IL_2A6:
								num2 = 41;
								text5 = text5.Trim(new char[]
								{
									' ',
									'\n',
									'\r',
									'\t',
									'\u3000'
								});
							}
							IL_2C3:
							num2 = 42;
							if (Operators.CompareString(text5, "", true) != 0)
							{
								IL_2D8:
								num2 = 44;
								bool flag = false;
								IL_2DE:
								num2 = 45;
								if (text5.StartsWith("'''async", StringComparison.OrdinalIgnoreCase))
								{
									IL_2F0:
									num2 = 46;
									flag = true;
								}
								IL_2F6:
								num2 = 47;
								if (Operators.CompareString(A_4, "Ribbon", true) == 0)
								{
									IL_30B:
									num2 = 48;
									RibbonItemTypeEnum ribbonItemTypeEnum = (RibbonItemTypeEnum)Conversions.ToInteger(dataRow["Type"]);
									switch (ribbonItemTypeEnum)
									{
									case RibbonItemTypeEnum.Ribbon:
										IL_3D2:
										num2 = 50;
										text4 = o0_.o_000Oo0O_.00o.("Ribbon", array3[j], false);
										break;
									case RibbonItemTypeEnum.ApplicationMenu:
									case RibbonItemTypeEnum.QAT:
									case RibbonItemTypeEnum.ConfigBar:
									case RibbonItemTypeEnum.PaperList:
									case RibbonItemTypeEnum.WindowList:
									case RibbonItemTypeEnum.TableViewList:
									case RibbonItemTypeEnum.GroupTableList:
									case RibbonItemTypeEnum.CrossTableList:
									case RibbonItemTypeEnum.SubtotalModeList:
									case RibbonItemTypeEnum.ExcelReportList:
									case RibbonItemTypeEnum.CodeReportList:
									case RibbonItemTypeEnum.WordReportList:
									case RibbonItemTypeEnum.GalleryItem:
										break;
									case RibbonItemTypeEnum.Tab:
										IL_58C:
										num2 = 84;
										text4 = o0_.o_000Oo0O_.00o.("RibbonTab", array3[j], false);
										break;
									case RibbonItemTypeEnum.Group:
										IL_50A:
										num2 = 74;
										text4 = o0_.o_000Oo0O_.00o.("RibbonGroup", array3[j], false);
										break;
									case RibbonItemTypeEnum.ToggleGroup:
										IL_5C0:
										num2 = 88;
										text4 = o0_.o_000Oo0O_.00o.("RibbonToggleGroup", array3[j], false);
										break;
									case RibbonItemTypeEnum.ToolBar:
										IL_5DA:
										num2 = 90;
										text4 = o0_.o_000Oo0O_.00o.("RibbonToolBar", array3[j], false);
										break;
									case RibbonItemTypeEnum.Button:
										IL_3EC:
										num2 = 52;
										text4 = o0_.o_000Oo0O_.00o.("RibbonButton", array3[j], false);
										break;
									case RibbonItemTypeEnum.CheckBox:
										IL_406:
										num2 = 54;
										text4 = o0_.o_000Oo0O_.00o.("RibbonCheckBox", array3[j], false);
										break;
									case RibbonItemTypeEnum.ColorPicker:
										IL_420:
										num2 = 56;
										text4 = o0_.o_000Oo0O_.00o.("RibbonColorPicker", array3[j], false);
										break;
									case RibbonItemTypeEnum.ComboBox:
										IL_43A:
										num2 = 58;
										text4 = o0_.o_000Oo0O_.00o.("RibbonComboBox", array3[j], false);
										break;
									case RibbonItemTypeEnum.TextBox:
										IL_454:
										num2 = 60;
										text4 = o0_.o_000Oo0O_.00o.("RibbonTextBox", array3[j], false);
										break;
									case RibbonItemTypeEnum.FontComboBox:
										IL_4F0:
										num2 = 72;
										text4 = o0_.o_000Oo0O_.00o.("RibbonFontComboBox", array3[j], false);
										break;
									case RibbonItemTypeEnum.Label:
										IL_524:
										num2 = 76;
										text4 = o0_.o_000Oo0O_.00o.("RibbonLabel", array3[j], false);
										break;
									case RibbonItemTypeEnum.MenuButton:
										IL_53E:
										num2 = 78;
										text4 = o0_.o_000Oo0O_.00o.("RibbonMenuButton", array3[j], false);
										break;
									case RibbonItemTypeEnum.Separator:
										IL_558:
										num2 = 80;
										text4 = o0_.o_000Oo0O_.00o.("RibbonSeparator", array3[j], false);
										break;
									case RibbonItemTypeEnum.SplitButton:
										IL_572:
										num2 = 82;
										text4 = o0_.o_000Oo0O_.00o.("RibbonSplitButton", array3[j], false);
										break;
									case RibbonItemTypeEnum.ToggleButton:
										IL_5A6:
										num2 = 86;
										text4 = o0_.o_000Oo0O_.00o.("RibbonToggleButton", array3[j], false);
										break;
									case RibbonItemTypeEnum.DatePicker:
										IL_4A2:
										num2 = 66;
										text4 = o0_.o_000Oo0O_.00o.("RibbonDatePicker", array3[j], false);
										break;
									case RibbonItemTypeEnum.NumericBox:
										IL_4BC:
										num2 = 68;
										text4 = o0_.o_000Oo0O_.00o.("RibbonNumericBox", array3[j], false);
										break;
									case RibbonItemTypeEnum.ProgressBar:
										IL_4D6:
										num2 = 70;
										text4 = o0_.o_000Oo0O_.00o.("RibbonProgressBar", array3[j], false);
										break;
									case RibbonItemTypeEnum.Gallery:
										IL_5F4:
										num2 = 92;
										text4 = o0_.o_000Oo0O_.00o.("RibbonGallery", array3[j], false);
										break;
									case RibbonItemTypeEnum.TimePicker:
										IL_46E:
										num2 = 62;
										text4 = o0_.o_000Oo0O_.00o.("RibbonTimePicker", array3[j], false);
										break;
									case RibbonItemTypeEnum.TrackBar:
										IL_488:
										num2 = 64;
										text4 = o0_.o_000Oo0O_.00o.("RibbonTrackBar", array3[j], false);
										break;
									default:
										switch (ribbonItemTypeEnum)
										{
										case RibbonItemTypeEnum.ContextMenu:
											IL_60E:
											num2 = 94;
											text4 = o0_.o_000Oo0O_.00o.("ContextMenu", array3[j], false);
											break;
										case RibbonItemTypeEnum.ContextCommand:
											IL_628:
											num2 = 96;
											text4 = o0_.o_000Oo0O_.00o.("ContextCommand", array3[j], false);
											break;
										case RibbonItemTypeEnum.ContextCommandMenu:
											IL_642:
											num2 = 98;
											text4 = o0_.o_000Oo0O_.00o.("ContextCommandMenu", array3[j], false);
											break;
										}
										break;
									}
								}
								else
								{
									IL_65C:
									num2 = 101;
									if (Operators.CompareString(A_4, "WinForm", true) == 0)
									{
										IL_66E:
										num2 = 102;
										if (Conversions.ToInteger(dataRow["Type"]) == 229 || Conversions.ToInteger(dataRow["Type"]) == 233)
										{
											IL_6A1:
											num2 = 103;
											text4 = o0_.o_000Oo0O_.00o.("Form", array3[j], false);
										}
										else
										{
											IL_6B8:
											num2 = 105;
											text4 = o0_.o_000Oo0O_.00o.("Control", array3[j], false);
										}
									}
									else
									{
										IL_6CF:
										num2 = 107;
										text4 = o0_.o_000Oo0O_.00o.(A_4, array3[j], false);
									}
								}
								IL_6E1:
								num2 = 108;
								int num4 = A_3.Length - 1;
								for (int k = 0; k <= num4; k++)
								{
									IL_6F0:
									num2 = 109;
									if (!dataRow.IsNull(A_3[k]))
									{
										IL_700:
										num2 = 110;
										if (Operators.CompareString(text3, "", true) > 0)
										{
											IL_713:
											num2 = 111;
											text3 += "_";
										}
										IL_724:
										num2 = 112;
										text3 += Conversions.ToString(dataRow[A_3[k]]);
									}
									IL_740:
									num2 = 113;
								}
								IL_74F:
								num2 = 114;
								if (Operators.CompareString(text3, "", true) > 0)
								{
									IL_765:
									num2 = 115;
									if (O_O0OO.o_O0.oo_o0oo.)
									{
										IL_76F:
										num2 = 116;
										if (O_O0OO.O0_00o.o0__o..CompileCode && OoOo0O.Oo_oOO_._Oo_o.(1, 6) == 3)
										{
											IL_788:
											num2 = 117;
											text3 += text3.Substring(1, 1);
										}
									}
									IL_79D:
									num2 = 118;
									if (flag)
									{
										IL_7A4:
										num2 = 119;
										stringBuilder.Append(string.Concat(new string[]
										{
											"Public Async Sub ",
											o0OoOOoOOo0.OO0._Oo0o.(array3[j] + "_" + text3),
											"(",
											text4,
											")\r\n"
										}));
									}
									else
									{
										IL_7F5:
										num2 = 121;
										stringBuilder.Append(string.Concat(new string[]
										{
											"Public Sub ",
											o0OoOOoOOo0.OO0._Oo0o.(array3[j] + "_" + text3),
											"(",
											text4,
											")\r\n"
										}));
									}
								}
								else
								{
									IL_846:
									num2 = 123;
									if (flag)
									{
										IL_84D:
										num2 = 124;
										stringBuilder.Append(string.Concat(new string[]
										{
											"Public Async Sub ",
											o0OoOOoOOo0.OO0._Oo0o.(array3[j]),
											"(",
											text4,
											")\r\n"
										}));
									}
									else
									{
										IL_88F:
										num2 = 126;
										stringBuilder.Append(string.Concat(new string[]
										{
											"Public Sub ",
											o0OoOOoOOo0.OO0._Oo0o.(array3[j]),
											"(",
											text4,
											")\r\n"
										}));
									}
								}
								IL_8CF:
								num2 = 127;
								stringBuilder.Append(text5 + "\r\n");
								IL_8E6:
								num2 = 128;
								stringBuilder.Append("End Sub\r\n");
							}
							IL_8F9:
							num2 = 129;
						}
						goto IL_90E;
					}
					goto IL_90E;
				}
				IL_925:
				num2 = 131;
				if (Operators.CompareString(A_4, "WinForm", true) != 0 || !O_O0OO.OoO.0OO__0ooo.().HasChanges())
				{
					goto IL_966;
				}
				IL_946:
				num2 = 132;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false);
				IL_966:
				num2 = 133;
				string left = stringBuilder.ToString();
				IL_975:
				num2 = 134;
				if (!O_O0OO.o_O0.oo_o0oo.)
				{
					goto IL_9A1;
				}
				IL_982:
				num2 = 135;
				if (Operators.CompareString(left, "", true) != 0)
				{
					goto IL_9A1;
				}
				IL_997:
				num2 = 136;
				result = null;
				goto IL_9BF;
				IL_9A1:
				num2 = 137;
				result = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), A_5, A_6, false, "", true);
				IL_9BF:
				goto IL_C39;
				IL_9C4:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_BFA:
				goto IL_C2E;
				IL_BFC:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_C0C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_BFC;
			}
			IL_C2E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_C39:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x001FF1C0 File Offset: 0x001FD3C0
		internal static Assembly <<EMPTY_NAME>>(DataTableProperty A_0, string A_1, DataTable A_2)
		{
			int num;
			Assembly result;
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
				PropertyInfo[] properties = A_0.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
				IL_21:
				num2 = 4;
				foreach (PropertyInfo propertyInfo in properties)
				{
					IL_36:
					num2 = 5;
					if (propertyInfo.GetSetMethod() != null && !O00OOOo_O0_O.O.0o_0_o.(propertyInfo))
					{
						IL_50:
						num2 = 6;
						if (O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo))
						{
							IL_5E:
							num2 = 7;
							string text = "";
							IL_67:
							num2 = 8;
							EventString eventString = (EventString)propertyInfo.GetValue(A_0, null);
							IL_79:
							num2 = 9;
							if (eventString != null && eventString.Count > 0)
							{
								IL_8A:
								num2 = 10;
								text = eventString[0].Trim();
							}
							IL_9C:
							num2 = 11;
							if (Operators.CompareString(text, "", true) != 0)
							{
								IL_B1:
								num2 = 14;
								string text2 = o0_.o_000Oo0O_.00o.("Table", propertyInfo.Name, false);
								IL_C8:
								num2 = 15;
								if (Operators.CompareString(text, "", true) > 0)
								{
									IL_DB:
									num2 = 16;
									text = text.Trim(new char[]
									{
										' ',
										'\n',
										'\r',
										'\t',
										'\u3000'
									});
								}
								IL_F8:
								num2 = 17;
								if (text.StartsWith("'''async", StringComparison.OrdinalIgnoreCase))
								{
									IL_10A:
									num2 = 18;
									stringBuilder.Append(string.Concat(new string[]
									{
										"Public Async Sub ",
										propertyInfo.Name,
										"(",
										text2,
										")\r\n"
									}));
								}
								else
								{
									IL_149:
									num2 = 20;
									stringBuilder.Append(string.Concat(new string[]
									{
										"Public Sub ",
										propertyInfo.Name,
										"(",
										text2,
										")\r\n"
									}));
								}
								IL_186:
								num2 = 21;
								stringBuilder.Append(text + "\r\n");
								IL_19D:
								num2 = 22;
								stringBuilder.Append("End Sub\r\n");
							}
						}
					}
					IL_1AD:
					num2 = 23;
				}
				IL_1C1:
				num2 = 24;
				result = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), A_1, A_2, false, "", true);
				IL_1DA:
				goto IL_290;
				IL_1DF:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_251:
				goto IL_285;
				IL_253:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_263:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_253;
			}
			IL_285:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_290:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x001FF484 File Offset: 0x001FD684
		internal static Assembly <<EMPTY_NAME>>(ProjectProperty A_0, DataTable A_1, string A_2, string A_3, DataTable A_4)
		{
			int num;
			Assembly result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				o0_.O0.oO. = true;
				IL_0F:
				num2 = 3;
				StringBuilder stringBuilder = new StringBuilder();
				IL_18:
				num2 = 4;
				PropertyInfo[] properties = A_0.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
				IL_29:
				num2 = 5;
				foreach (PropertyInfo propertyInfo in properties)
				{
					IL_3E:
					num2 = 6;
					if (propertyInfo.GetSetMethod() != null && !O00OOOo_O0_O.O.0o_0_o.(propertyInfo))
					{
						IL_58:
						num2 = 7;
						if (O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo))
						{
							IL_66:
							num2 = 8;
							string text = "";
							IL_6F:
							num2 = 9;
							EventString eventString = (EventString)propertyInfo.GetValue(A_0, null);
							IL_82:
							num2 = 10;
							if (eventString != null && eventString.Count > 0)
							{
								IL_93:
								num2 = 11;
								text = eventString[0].Trim();
								IL_A5:
								num2 = 12;
								string name = propertyInfo.Name;
								IL_B1:
								num2 = 14;
								if (Operators.CompareString(name, "AfterOpenProject", true) != 0)
								{
									Operators.CompareString(name, "LoadUserSetting", true);
								}
							}
							IL_D1:
							num2 = 15;
							if (Operators.CompareString(O00.O0o.__O.(propertyInfo.Name), o0_.o_000Oo0O_.00o.(), true) == 0)
							{
								IL_ED:
								num2 = 16;
								text = o0OoOOoOOo0.OO0._Oo0o.() + "\r\n" + text;
							}
							IL_103:
							num2 = 17;
							if (Operators.CompareString(text, "", true) != 0)
							{
								IL_118:
								num2 = 20;
								string text2 = o0_.o_000Oo0O_.00o.("Project", propertyInfo.Name, false);
								IL_12F:
								num2 = 21;
								text = text.Trim(new char[]
								{
									' ',
									'\n',
									'\r',
									'\t',
									'\u3000'
								});
								IL_14C:
								num2 = 22;
								string text3 = propertyInfo.Name;
								IL_158:
								num2 = 23;
								string left = text3;
								IL_15F:
								num2 = 25;
								if (Operators.CompareString(left, "BeforeConnectOuterDataSource", true) == 0 || Operators.CompareString(left, "BeforeLoadInnerTable", true) == 0 || Operators.CompareString(left, "BeforeLoadOuterTable", true) == 0 || Operators.CompareString(left, "Initialize", true) == 0 || Operators.CompareString(left, "AfterOpenProject", true) == 0 || Operators.CompareString(left, "BeforeOpenProject", true) == 0 || Operators.CompareString(left, "LoadUserSetting", true) == 0)
								{
									IL_1CB:
									num2 = 26;
									text3 = o0OoOOoOOo0.OO0._Oo0o.(text3);
								}
								else
								{
									IL_1D9:
									num2 = 28;
									if (Operators.CompareString(left, o0_.O0.oO., true) == 0)
									{
										IL_1EB:
										num2 = 29;
										if (!o0OO__.OO0oO.o.())
										{
											goto IL_2A3;
										}
									}
								}
								IL_1F8:
								num2 = 31;
								if (text.StartsWith("'''async", StringComparison.OrdinalIgnoreCase))
								{
									IL_20A:
									num2 = 32;
									stringBuilder.Append(string.Concat(new string[]
									{
										"Public Async Sub ",
										text3,
										"(",
										text2,
										")\r\n"
									}));
								}
								else
								{
									IL_244:
									num2 = 34;
									stringBuilder.Append(string.Concat(new string[]
									{
										"Public Sub ",
										text3,
										"(",
										text2,
										")\r\n"
									}));
								}
								IL_27C:
								num2 = 35;
								stringBuilder.Append(text + "\r\n");
								IL_293:
								num2 = 36;
								stringBuilder.Append("End Sub\r\n");
							}
						}
					}
					IL_2A3:
					num2 = 37;
				}
				IL_2B7:
				num2 = 38;
				OO_00oOO.MyTimers.Clear();
				IL_2C4:
				num2 = 39;
				if (stringBuilder.Length <= 0)
				{
					goto IL_2E1;
				}
				IL_2D1:
				num2 = 40;
				stringBuilder.Append("\r\n");
				IL_2E1:
				num2 = 41;
				DataRow[] array2 = A_1.Select("[Type] = " + Conversions.ToString(3));
				IL_2FC:
				num2 = 42;
				foreach (DataRow dataRow in array2)
				{
					IL_312:
					num2 = 43;
					TimerProperty timerProperty = new TimerProperty();
					IL_31C:
					num2 = 44;
					Timer timer = new Timer();
					IL_326:
					num2 = 45;
					if (!dataRow.IsNull("Config"))
					{
						IL_337:
						num2 = 46;
						o_O_o_oOoo__.OOOO_OO._oo.(timerProperty, O00.oO_.0o_oo_0O_.(Conversions.ToString(dataRow["Config"]), "Timer", A_2), '\v');
					}
					IL_35F:
					num2 = 47;
					timer.Name = Conversions.ToString(dataRow["Name"]);
					IL_37A:
					num2 = 48;
					string text4 = "Timer_" + timer.Name;
					IL_390:
					num2 = 49;
					timer.Tag = text4;
					IL_39C:
					num2 = 50;
					timer.Interval = timerProperty.Interval;
					IL_3AD:
					num2 = 51;
					timer.Enabled = timerProperty.Enabled;
					IL_3BE:
					num2 = 52;
					timer.CanPause = timerProperty.CanPause;
					IL_3CF:
					num2 = 53;
					if (timerProperty.Tick != null && timerProperty.Tick.Count > 0)
					{
						IL_3F0:
						num2 = 54;
						string text5 = timerProperty.Tick[0];
						IL_402:
						num2 = 55;
						if (Operators.CompareString(text5, "", true) > 0)
						{
							IL_415:
							num2 = 56;
							text5 = text5.Trim(new char[]
							{
								' ',
								'\n',
								'\r',
								'\t',
								'\u3000'
							});
						}
						IL_432:
						num2 = 57;
						if (text5.StartsWith("'''async", StringComparison.OrdinalIgnoreCase))
						{
							IL_444:
							num2 = 58;
							stringBuilder.Append("Public Async Sub " + text4 + "()\r\n");
						}
						else
						{
							IL_462:
							num2 = 60;
							stringBuilder.Append("Public Sub " + text4 + "()\r\n");
						}
						IL_47E:
						num2 = 61;
						stringBuilder.Append(text5 + "\r\n");
						IL_495:
						num2 = 62;
						stringBuilder.Append("End Sub\r\n");
					}
					IL_4A5:
					num2 = 63;
					OO_00oOO.MyTimers.Add(Conversions.ToString(dataRow["Name"]), timer);
					IL_4C5:
					num2 = 64;
				}
				IL_4D9:
				num2 = 65;
				Assembly assembly = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), A_3, A_4, false, A_2, true);
				IL_4F0:
				num2 = 66;
				o0_.O0.oO. = false;
				IL_4F9:
				num2 = 67;
				result = assembly;
				IL_4FF:
				goto IL_661;
				IL_504:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_622:
				goto IL_656;
				IL_624:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_634:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_624;
			}
			IL_656:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_661:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x001FFB18 File Offset: 0x001FDD18
		private static Assembly <<EMPTY_NAME>>(string A_0)
		{
			Assembly result;
			return result;
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x001FFB28 File Offset: 0x001FDD28
		static o0_()
		{
			int a_ = 19;
			o0_.O0.oO. = O00.DecryptText(O00OOOo_O0_O.b("공뿷쯹폻꫽磿洁䰃⤅將按戋伍搏弑Ⱃ䄕弗簙缛䐝星眡吣欥伧嬩攫眭ԯ弱猳", a_), O00OOOo_O0_O.b("郵韷苹", a_), O00OOOo_O0_O.b("苵駷飹郻鯽", a_));
			o0_.oO.0_O. = O00OOOo_O0_O.b("苵ꣷ迹闻볽盿昁⬃儅㠇䈉㸋嘍␏稑䘓尕娗洙眛⨝感ἡᤣ", a_);
			o0_.O0.oO. = RuntimeHelpers.GetObjectValue(new object());
			o0_.OoOOoO.O_o. = O00OOOo_O0_O.b("믵鷷軹铻釽擿崁㘃", a_);
			int num;
			int num17;
			object obj;
			try
			{
				IL_72:
				ProjectData.ClearProjectError();
				num = 1;
				IL_79:
				int num2 = 2;
				byte[] array = new byte[]
				{
					1,
					2,
					3,
					4,
					5
				};
				IL_8D:
				num2 = 3;
				int num3 = array.Length;
				IL_94:
				num2 = 4;
				int num4 = Environment.TickCount ^ num3;
				IL_A0:
				num2 = 5;
				uint num5 = (uint)num4;
				IL_A6:
				num2 = 6;
				byte[] array2 = new byte[256];
				IL_B4:
				num2 = 7;
				int num6 = 0;
				do
				{
					IL_B9:
					num2 = 8;
					uint num7 = (uint)num6;
					IL_BF:
					num2 = 9;
					num7 = num7 * 1103515245u + 12345u;
					IL_D2:
					num2 = 10;
					array2[num6] = (byte)(num7 >> 16 & 255u);
					IL_E6:
					num2 = 11;
					num6++;
				}
				while (num6 <= 255);
				IL_F8:
				num2 = 12;
				int num8 = num3 - 1;
				for (int i = 0; i <= num8; i++)
				{
					IL_106:
					num2 = 13;
					byte b = array[i];
					IL_10F:
					num2 = 14;
					byte b2 = (byte)((uint)b >> 4) & 15;
					IL_11D:
					num2 = 15;
					byte b3 = b & 15;
					IL_128:
					num2 = 16;
					byte b4 = (byte)(b3 << 4) | b2;
					IL_135:
					num2 = 17;
					byte b5 = array2[(int)b4];
					byte b6 = array2[(int)b];
					IL_144:
					num2 = 18;
					array[i] = b;
					IL_14D:
					num2 = 19;
				}
				IL_15C:
				num2 = 20;
				uint num9 = uint.MaxValue;
				IL_162:
				num2 = 21;
				int num10 = num3 - 1;
				for (int j = 0; j <= num10; j++)
				{
					IL_170:
					num2 = 22;
					num9 ^= (uint)array[j];
					IL_17C:
					num2 = 23;
					int num11 = 0;
					do
					{
						IL_182:
						num2 = 24;
						if (((ulong)num9 & 1UL) != 0UL)
						{
							IL_18D:
							num2 = 25;
							num9 = (num9 >> 1 ^ 3988292384u);
						}
						else
						{
							IL_19E:
							num2 = 27;
							num9 >>= 1;
						}
						IL_1A7:
						num2 = 28;
						num11++;
					}
					while (num11 <= 7);
					IL_1B5:
					num2 = 29;
				}
				IL_1C4:
				num2 = 30;
				GC.KeepAlive(num9);
				IL_1D3:
				num2 = 31;
				int num12 = num3 / 2 - 1;
				for (int k = 0; k <= num12; k++)
				{
					IL_1E3:
					num2 = 32;
					int num13 = num3 - 1 - k;
					IL_1EF:
					num2 = 33;
					byte b7 = array[k];
					IL_1F8:
					num2 = 34;
					array[k] = array[num13];
					IL_203:
					num2 = 35;
					array[num13] = b7;
					IL_20C:
					num2 = 36;
					b7 = array[k];
					IL_215:
					num2 = 37;
					array[k] = array[num13];
					IL_220:
					num2 = 38;
					array[num13] = b7;
					IL_229:
					num2 = 39;
				}
				IL_238:
				num2 = 40;
				long num14 = 0L;
				IL_23F:
				num2 = 41;
				int num15 = num3 - 1;
				for (int l = 0; l <= num15; l++)
				{
					IL_24D:
					num2 = 42;
					num5 = num5 * 1664525u + 1013904223u;
					IL_260:
					num2 = 43;
					byte b8 = (byte)((ulong)(num5 >> 24) & 255UL);
					IL_273:
					num2 = 44;
					num14 += (long)((ulong)(array[l] ^ b8));
					IL_283:
					num2 = 45;
				}
				IL_292:
				num2 = 46;
				GC.KeepAlive(num14);
				IL_2A1:
				num2 = 47;
				o0_.O0.oO. = 500;
				IL_2AE:
				num2 = 48;
				o0_.o0o___.Ooo__Oo. = 500;
				IL_2BB:
				num2 = 49;
				o0_.oO.0_O. = 12;
				IL_2C5:
				num2 = 50;
				o0_.o0o___.Ooo__Oo. = o_o_O0OO_0__.O.ooOo__o000OO.().Substring(0, 12);
				IL_2DA:
				num2 = 51;
				o0OO__.OO0oO.o.(o_o_O0OO_0__.O.ooOo__o000OO.(), 1000, false);
				IL_2EE:
				goto IL_410;
				IL_2F3:
				int num16 = num17 + 1;
				num17 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num16);
				IL_3D1:
				goto IL_405;
				IL_3D3:
				num17 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_3E3:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num17 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3D3;
			}
			IL_405:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_410:
			if (num17 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x001FFF6C File Offset: 0x001FE16C
		internal static Assembly <<EMPTY_NAME>>(string A_0, string A_1, DataTable A_2, bool A_3 = false, string A_4 = "", bool A_5 = true)
		{
			int num;
			Assembly result;
			int num21;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (Operators.CompareString(A_0, "", true) != 0)
				{
					goto IL_AD;
				}
				IL_1A:
				num2 = 3;
				string text = O_O0OO.o.00O_O.() + "Bin\\Foxtable.Blank.dll";
				IL_2D:
				num2 = 4;
				if (!OO_00oOO.FileSys.FileExists(A_1))
				{
					goto IL_49;
				}
				IL_3C:
				num2 = 5;
				OO_00oOO.FileSys.DeleteFile(A_1);
				IL_49:
				num2 = 6;
				if (OO_00oOO.FileSys.FileExists(text))
				{
					goto IL_70;
				}
				IL_59:
				num2 = 7;
				o0_.Oo_0.OOo0oO0.("    ", text, null, false, "", true);
				IL_70:
				num2 = 8;
				if (Operators.CompareString(A_1, "", true) <= 0)
				{
					goto IL_91;
				}
				IL_81:
				num2 = 9;
				OO_00oOO.FileSys.CopyFile(text, A_1);
				IL_91:
				num2 = 10;
				byte[] rawAssembly = File.ReadAllBytes(text);
				IL_9D:
				num2 = 11;
				result = Assembly.Load(rawAssembly);
				goto IL_DCD;
				IL_AD:
				num2 = 13;
				if (Operators.CompareString(A_0, "", true) <= 0)
				{
					goto IL_35C;
				}
				IL_C2:
				ProjectData.ClearProjectError();
				num = 1;
				IL_C9:
				num2 = 15;
				byte[] array = new byte[]
				{
					1,
					2,
					3,
					4,
					5
				};
				IL_DF:
				num2 = 16;
				int num3 = array.Length;
				IL_E8:
				num2 = 17;
				int num4 = Environment.TickCount ^ num3;
				IL_F5:
				num2 = 18;
				uint num5 = (uint)num4;
				IL_FC:
				num2 = 19;
				byte[] array2 = new byte[256];
				IL_10B:
				num2 = 20;
				int num6 = 0;
				do
				{
					IL_111:
					num2 = 21;
					uint num7 = (uint)num6;
					IL_118:
					num2 = 22;
					num7 = num7 * 1103515245u + 12345u;
					IL_12B:
					num2 = 23;
					array2[num6] = (byte)(num7 >> 16 & 255u);
					IL_13F:
					num2 = 24;
					num6++;
				}
				while (num6 <= 255);
				IL_151:
				num2 = 25;
				int num8 = num3 - 1;
				for (int i = 0; i <= num8; i++)
				{
					IL_15F:
					num2 = 26;
					byte b = array[i];
					IL_169:
					num2 = 27;
					byte b2 = (byte)((uint)b >> 4) & 15;
					IL_177:
					num2 = 28;
					byte b3 = b & 15;
					IL_182:
					num2 = 29;
					byte b4 = (byte)(b3 << 4) | b2;
					IL_18F:
					num2 = 30;
					byte b5 = array2[(int)b4];
					byte b6 = array2[(int)b];
					IL_19E:
					num2 = 31;
					array[i] = b;
					IL_1A8:
					num2 = 32;
				}
				IL_1B7:
				num2 = 33;
				uint num9 = uint.MaxValue;
				IL_1BD:
				num2 = 34;
				int num10 = num3 - 1;
				for (int j = 0; j <= num10; j++)
				{
					IL_1CB:
					num2 = 35;
					num9 ^= (uint)array[j];
					IL_1D8:
					num2 = 36;
					int num11 = 0;
					do
					{
						IL_1DE:
						num2 = 37;
						if (((ulong)num9 & 1UL) != 0UL)
						{
							IL_1E9:
							num2 = 38;
							num9 = (num9 >> 1 ^ 3988292384u);
						}
						else
						{
							IL_1FA:
							num2 = 40;
							num9 >>= 1;
						}
						IL_203:
						num2 = 41;
						num11++;
					}
					while (num11 <= 7);
					IL_211:
					num2 = 42;
				}
				IL_220:
				num2 = 43;
				GC.KeepAlive(num9);
				IL_22F:
				num2 = 44;
				int num12 = num3 / 2 - 1;
				for (int k = 0; k <= num12; k++)
				{
					IL_23F:
					num2 = 45;
					int num13 = num3 - 1 - k;
					IL_24B:
					num2 = 46;
					byte b7 = array[k];
					IL_255:
					num2 = 47;
					array[k] = array[num13];
					IL_262:
					num2 = 48;
					array[num13] = b7;
					IL_26C:
					num2 = 49;
					b7 = array[k];
					IL_276:
					num2 = 50;
					array[k] = array[num13];
					IL_283:
					num2 = 51;
					array[num13] = b7;
					IL_28D:
					num2 = 52;
				}
				IL_29C:
				num2 = 53;
				long num14 = 0L;
				IL_2A3:
				num2 = 54;
				int num15 = num3 - 1;
				for (int l = 0; l <= num15; l++)
				{
					IL_2B1:
					num2 = 55;
					num5 = num5 * 1664525u + 1013904223u;
					IL_2C4:
					num2 = 56;
					byte b8 = (byte)((ulong)(num5 >> 24) & 255UL);
					IL_2D7:
					num2 = 57;
					num14 += (long)((ulong)(array[l] ^ b8));
					IL_2E8:
					num2 = 58;
				}
				IL_2F7:
				num2 = 59;
				GC.KeepAlive(num14);
				IL_306:
				num2 = 60;
				string left = o0OO__.OO0oO.o.(o0_.O0.oO. + o0_.o0o___.Ooo__Oo., o0_.oO.0_O., false).Trim();
				IL_326:
				num2 = 61;
				if (Operators.CompareString(left, o0_.o0o___.Ooo__Oo., true) == 0)
				{
					goto IL_35C;
				}
				IL_338:
				num2 = 62;
				A_0 = O00.DecryptText(o0_.oO.0_O., "foxtable", "foxtable") + "\r\n" + A_0;
				IL_35C:
				num2 = 63;
				if (Operators.CompareString(A_4, "", true) != 0 || Operators.CompareString(A_0.Trim(), "", true) <= 0 || A_3)
				{
					goto IL_38F;
				}
				IL_385:
				num2 = 64;
				A_4 = O_O0OO.O_O._Oo.();
				IL_38F:
				num2 = 65;
				VBCodeProvider vbcodeProvider = new VBCodeProvider();
				IL_399:
				num2 = 66;
				CompilerParameters compilerParameters = new CompilerParameters();
				IL_3A3:
				num2 = 67;
				StringBuilder stringBuilder = new StringBuilder();
				IL_3AD:
				num2 = 68;
				stringBuilder.Append("Option Strict Off\r\n");
				IL_3BD:
				num2 = 69;
				stringBuilder.Append("Option Compare Text\r\n");
				IL_3CD:
				num2 = 70;
				if (OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "Bin\\TempFiles"))
				{
					goto IL_407;
				}
				IL_3EB:
				num2 = 71;
				OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + "Bin\\TempFiles");
				IL_407:
				num2 = 72;
				compilerParameters.TempFiles = new TempFileCollection(OO_00oOO.ProjectPath + "Bin\\TempFiles", true);
				IL_426:
				num2 = 73;
				foreach (string text2 in SysInfo.spaceNames.Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					IL_455:
					num2 = 74;
					string[] array4 = text2.Split(new char[]
					{
						'(',
						')'
					}, StringSplitOptions.RemoveEmptyEntries);
					IL_472:
					num2 = 75;
					if (!array4[0].StartsWith("'"))
					{
						IL_485:
						num2 = 77;
						if (array4.Length == 1)
						{
							IL_48F:
							num2 = 78;
							stringBuilder.Append("Imports " + array4[0] + "\r\n");
						}
						else
						{
							IL_4AF:
							num2 = 80;
							stringBuilder.Append(string.Concat(new string[]
							{
								"Imports ",
								array4[1],
								" = ",
								array4[0],
								"\r\n"
							}));
						}
					}
					IL_4EB:
					num2 = 81;
				}
				IL_4FF:
				num2 = 82;
				if (A_2 == null)
				{
					goto IL_622;
				}
				IL_508:
				num2 = 83;
				DataRow dataRow = A_2.Rows.Find(new object[]
				{
					"Space",
					o0_O.oo0o_OoO_.Oo.
				});
				IL_530:
				num2 = 84;
				if (dataRow == null || dataRow.IsNull("Config"))
				{
					goto IL_622;
				}
				IL_54B:
				num2 = 85;
				string[] array5 = dataRow["Config"].ToString().Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_577:
				num2 = 86;
				int num16 = array5.Length - 1;
				for (int n = 0; n <= num16; n++)
				{
					IL_58A:
					num2 = 87;
					string[] array6 = array5[n].Split(new char[]
					{
						'(',
						')'
					}, StringSplitOptions.RemoveEmptyEntries);
					IL_5AA:
					num2 = 88;
					if (array6.Length == 1)
					{
						IL_5B4:
						num2 = 89;
						stringBuilder.Append("Imports " + array6[0] + "\r\n");
					}
					else
					{
						IL_5D4:
						num2 = 91;
						stringBuilder.Append(string.Concat(new string[]
						{
							"Imports ",
							array6[1],
							" = ",
							array6[0],
							"\r\n"
						}));
					}
					IL_610:
					num2 = 92;
				}
				IL_622:
				num2 = 93;
				stringBuilder.Append(SysInfo.ImportsStrings + "\r\n");
				IL_63C:
				num2 = 94;
				stringBuilder.Append("Public Module UserCode\r\n");
				IL_64C:
				num2 = 95;
				stringBuilder.Append(A_0 + "\r\n");
				IL_662:
				num2 = 96;
				stringBuilder.Append("End Module");
				IL_672:
				num2 = 97;
				CompilerParameters compilerParameters2 = compilerParameters;
				IL_679:
				num2 = 98;
				compilerParameters2.GenerateExecutable = false;
				IL_684:
				num2 = 99;
				compilerParameters2.IncludeDebugInformation = false;
				IL_68F:
				num2 = 100;
				foreach (string text3 in SysInfo.referFiles.Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					IL_6BE:
					num2 = 101;
					if (text3.StartsWith("System.", StringComparison.CurrentCultureIgnoreCase))
					{
						IL_6D0:
						num2 = 102;
						compilerParameters2.ReferencedAssemblies.Add(text3);
					}
					else
					{
						IL_6E4:
						num2 = 104;
						if (Operators.CompareString(text3, "Office.dll", true) == 0 || Operators.CompareString(text3, "Neodynamic.WinControls.BarcodeProfessional.dll", true) == 0 || Operators.CompareString(text3, "Microsoft.Office.Interop.Excel.dll", true) == 0)
						{
							IL_714:
							num2 = 105;
							if (!o_O_o_oOoo__.OOOO_OO._oo.())
							{
								IL_71E:
								num2 = 106;
								compilerParameters2.ReferencedAssemblies.Add(O_O0OO.o.00O_O.() + text3);
							}
						}
						else
						{
							IL_73C:
							num2 = 108;
							compilerParameters2.ReferencedAssemblies.Add(O_O0OO.o.00O_O.() + text3);
						}
					}
					IL_758:
					num2 = 109;
				}
				IL_76C:
				num2 = 110;
				if (A_3 || Operators.CompareString(A_4, "", true) <= 0)
				{
					goto IL_8E0;
				}
				IL_788:
				num2 = 111;
				if (Operators.CompareString(A_1, "", true) <= 0)
				{
					goto IL_7B6;
				}
				IL_79A:
				num2 = 112;
				string text4 = OO_00oOO.FileSys.GetParentPath(A_1) + "\\";
				goto IL_7CA;
				IL_7B6:
				num2 = 114;
				text4 = OO_00oOO.ProjectPath + "Bin\\";
				IL_7CA:
				num2 = 115;
				if (Operators.CompareString(text4, O_O0OO.o.00O_O.() + "Bin\\", true) == 0)
				{
					goto IL_8E0;
				}
				IL_7E9:
				num2 = 116;
				if (Operators.CompareString(A_1, "", true) != 0)
				{
					goto IL_810;
				}
				IL_7FA:
				num2 = 117;
				string text5 = OO_00oOO.FileSys.GetName(OO_00oOO.ProjectFile);
				goto IL_820;
				IL_810:
				num2 = 119;
				text5 = OO_00oOO.FileSys.GetName(A_1);
				IL_820:
				num2 = 120;
				text5 = text5.Substring(0, text5.IndexOf("."));
				IL_839:
				num2 = 121;
				text5 = text4 + text5 + ".Public.dll";
				IL_84C:
				num2 = 122;
				if (OO_00oOO.FileSys.FileExists(text5))
				{
					goto IL_8CB;
				}
				IL_85D:
				num2 = 123;
				string a_ = o0_.o_000Oo0O_.00o.(A_2, "");
				IL_86D:
				num2 = 124;
				o0_.Oo_0.OOo0oO0.(a_, text5, null, true, "", true);
				IL_882:
				num2 = 125;
				O_O0OO.O0_00o.o0__o..AsmAPICrcString = O00.CRCCheckFile(text5);
				IL_896:
				num2 = 126;
				if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
				{
					goto IL_8CB;
				}
				IL_8AB:
				num2 = 127;
				O_O0OO.O0_00o.o0__o..o0Oo.Oo_0oO0o. = true;
				IL_8B9:
				num2 = 128;
				O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
				IL_8CB:
				num2 = 129;
				compilerParameters2.ReferencedAssemblies.Add(text5);
				IL_8E0:
				num2 = 130;
				if (A_2 == null)
				{
					goto IL_A04;
				}
				IL_8EC:
				num2 = 131;
				DataRow dataRow2 = A_2.Rows.Find(new object[]
				{
					"Refrence",
					o0_O.oOO0.oO0O0__.
				});
				IL_917:
				num2 = 132;
				if (dataRow2 == null || dataRow2.IsNull("Config"))
				{
					goto IL_A04;
				}
				IL_935:
				num2 = 133;
				string[] array8 = dataRow2["Config"].ToString().Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_964:
				num2 = 134;
				int num18 = array8.Length - 1;
				for (int num19 = 0; num19 <= num18; num19++)
				{
					IL_97A:
					num2 = 135;
					if (array8[num19].StartsWith("System.", StringComparison.CurrentCultureIgnoreCase))
					{
						IL_992:
						num2 = 136;
						compilerParameters2.ReferencedAssemblies.Add(array8[num19]);
					}
					else
					{
						IL_9AC:
						num2 = 138;
						if (OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + array8[num19]))
						{
							IL_9CD:
							num2 = 139;
							compilerParameters2.ReferencedAssemblies.Add(O_O0OO.o.00O_O.() + array8[num19]);
						}
					}
					IL_9EF:
					num2 = 140;
				}
				IL_A04:
				num2 = 141;
				if (Operators.CompareString(A_1, "", true) <= 0)
				{
					goto IL_A6F;
				}
				IL_A19:
				num2 = 142;
				compilerParameters2.OutputAssembly = A_1;
				IL_A27:
				num2 = 143;
				compilerParameters2.GenerateInMemory = false;
				IL_A35:
				num2 = 144;
				if (OO_00oOO.FileSys.DirectoryExists(OO_00oOO.FileSys.GetParentPath(A_1)))
				{
					goto IL_A7D;
				}
				IL_A52:
				num2 = 145;
				OO_00oOO.FileSys.CreateDirectory(OO_00oOO.FileSys.GetParentPath(A_1));
				goto IL_A7D;
				IL_A6F:
				num2 = 147;
				compilerParameters2.GenerateInMemory = true;
				IL_A7D:
				compilerParameters2 = null;
				IL_A80:
				num2 = 149;
				object o0.oO. = o0_.O0.oO.;
				ObjectFlowControl.CheckForSyncLockOnValueType(o0.oO.);
				CompilerResults compilerResults;
				lock (o0.oO.)
				{
					bool a_2 = OO_00oOO.SystemReady;
					OO_00oOO.SystemReady = false;
					compilerResults = vbcodeProvider.CompileAssemblyFromSource(compilerParameters, new string[]
					{
						stringBuilder.ToString()
					});
					OO_00oOO.SystemReady = a_2;
				}
				IL_ADD:
				num2 = 150;
				if (!compilerResults.Errors.HasErrors)
				{
					goto IL_D07;
				}
				IL_AF4:
				num2 = 151;
				if (A_5)
				{
					goto IL_B34;
				}
				IL_AFE:
				num2 = 152;
				result = o0_.Oo_0.OOo0oO0.("", "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", true);
				goto IL_DCD;
				IL_B34:
				num2 = 153;
				string text6 = "";
				IL_B41:
				num2 = 154;
				IEnumerator enumerator = compilerResults.Errors.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					CompilerError compilerError = (CompilerError)obj;
					IL_B68:
					num2 = 155;
					if (!compilerError.IsWarning)
					{
						IL_B77:
						num2 = 157;
						text6 = text6 + "编译错误:" + compilerError.ErrorText + "\r\n\r\n";
						IL_B97:
						num2 = 158;
						TextBox textBox = new TextBox();
						IL_BA4:
						num2 = 159;
						textBox.Text = stringBuilder.ToString();
						IL_BB8:
						num2 = 160;
						text6 = "\r\n" + text6 + "错误代码：" + textBox.Lines[compilerError.Line - 1].Trim();
						break;
					}
					IL_BE9:
					num2 = 162;
				}
				IL_BFB:
				num2 = 163;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_C16:
				num2 = 164;
				text6 = text6.Replace("Foxtable.", "").Trim();
				IL_C34:
				num2 = 165;
				if (Operators.CompareString(text6, "", true) <= 0)
				{
					goto IL_C65;
				}
				IL_C4A:
				num2 = 166;
				MessageBox.Show(text6, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				goto IL_CFA;
				IL_C65:
				num2 = 168;
				if (!o_O_o_oOoo__.OOOO_OO._oo.())
				{
					goto IL_CE1;
				}
				IL_C72:
				num2 = 169;
				MessageBox.Show("本机的.NET Framework 2.0版本过低，无法正常编译代码，建议升级到.NET Framework 2.0 SP2。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_C8B:
				num2 = 170;
				string text7 = O_O0OO.o.00O_O.() + "downloadnetsp2.htm";
				IL_CA2:
				num2 = 171;
				if (!OO_00oOO.FileSys.FileExists(text7))
				{
					goto IL_CFA;
				}
				IL_CB6:
				num2 = 172;
				Process process = new Process();
				IL_CC3:
				num2 = 173;
				process.File = text7;
				IL_CD2:
				num2 = 174;
				process.Start();
				goto IL_CFA;
				IL_CE1:
				num2 = 176;
				MessageBox.Show("未知编译错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				IL_CFA:
				num2 = 177;
				result = null;
				goto IL_DCD;
				IL_D07:
				num2 = 178;
				IEnumerator enumerator2 = compilerResults.TempFiles.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object value = enumerator2.Current;
					string text8 = Conversions.ToString(value);
					IL_D2B:
					num2 = 179;
					if (Operators.CompareString(Path.GetExtension(text8), ".vb", true) == 0)
					{
						IL_D45:
						num2 = 180;
						OO_00oOO.FileSys.DeleteFile(text8);
					}
					IL_D57:
					num2 = 181;
				}
				IL_D66:
				num2 = 182;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_D81:
				num2 = 183;
				if (Operators.CompareString(A_1, "", true) <= 0)
				{
					goto IL_DB5;
				}
				IL_D96:
				num2 = 184;
				byte[] rawAssembly2 = File.ReadAllBytes(A_1);
				IL_DA4:
				num2 = 185;
				Assembly assembly = Assembly.Load(rawAssembly2);
				goto IL_DC4;
				IL_DB5:
				num2 = 187;
				assembly = compilerResults.CompiledAssembly;
				IL_DC4:
				num2 = 188;
				result = assembly;
				IL_DCD:
				goto IL_1113;
				IL_DD2:
				int num20 = num21 + 1;
				num21 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num20);
				IL_10D4:
				goto IL_1108;
				IL_10D6:
				num21 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_10E6:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num21 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_10D6;
			}
			IL_1108:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1113:
			if (num21 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x002010CC File Offset: 0x001FF2CC
		internal static string <<EMPTY_NAME>>(DataTable A_0, string A_1 = "")
		{
			string text = "";
			foreach (DataRow dataRow in A_0.Select("[Type] = " + Conversions.ToString(19)))
			{
				if (!dataRow.IsNull("Config") && Operators.CompareString(dataRow["Name"].ToString(), A_1, true) != 0)
				{
					string text2 = O_O0OO.o0_OO.000.(A_0.DataSet);
					string text3 = dataRow["Config"].ToString();
					if (text3.StartsWith("[") && text3.EndsWith("]"))
					{
						text3 = text3.TrimStart(new char[]
						{
							'['
						}).TrimEnd(new char[]
						{
							']'
						});
						text2 = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., text2.Substring(0, 5)).Substring(0, 5);
					}
					text3 = O00.oO_.0o_oo_0O_.(text3, "API", text2);
					text = text + "\r\n" + text3;
				}
			}
			return text;
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x002011D8 File Offset: 0x001FF3D8
		internal static string <<EMPTY_NAME>>(string A_0, string A_1, bool A_2 = false)
		{
			string text = o0_.o_000Oo0O_.00o.(A_0, A_1);
			string result;
			if (Operators.CompareString(text, "", true) > 0)
			{
				if (A_2)
				{
					result = text;
				}
				else
				{
					result = "ByVal e As " + text;
				}
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x00201218 File Offset: 0x001FF418
		internal static string <<EMPTY_NAME>>(string A_0, string A_1)
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
				if (Operators.CompareString(A_0, "Form", true) != 0 || (Operators.CompareString(A_1, "SizeChanged", true) != 0 && Operators.CompareString(A_1, "AfterShow", true) != 0))
				{
					goto IL_3C;
				}
				IL_33:
				num2 = 3;
				A_1 = "AfterLoad";
				IL_3C:
				num2 = 4;
				if (Operators.CompareString(A_0, "Control", true) != 0)
				{
					goto IL_738;
				}
				IL_4F:
				num2 = 5;
				string left = A_1;
				IL_54:
				num2 = 7;
				if (Operators.CompareString(left, "RetrieveVirtualRow", true) != 0 && Operators.CompareString(left, "BeforeDragRow", true) != 0 && Operators.CompareString(left, "RowSelectionChanged", true) != 0 && Operators.CompareString(left, "RowChecking", true) != 0 && Operators.CompareString(left, "RowChecked", true) != 0)
				{
					goto IL_AE;
				}
				IL_A1:
				num2 = 8;
				result = "ListViewRowEventArgs";
				goto IL_E7C;
				IL_AE:
				num2 = 10;
				if (Operators.CompareString(left, "BeforeDropRow", true) != 0)
				{
					goto IL_CE;
				}
				IL_C0:
				num2 = 11;
				result = "DropListViewRowEventArgs";
				goto IL_E7C;
				IL_CE:
				num2 = 13;
				if (Operators.CompareString(left, "RowActivate", true) != 0)
				{
					goto IL_EE;
				}
				IL_E0:
				num2 = 14;
				result = "ControlEventArgs";
				goto IL_E7C;
				IL_EE:
				num2 = 16;
				if (Operators.CompareString(left, "BeforeEdit", true) != 0 && Operators.CompareString(left, "AfterEdit", true) != 0)
				{
					goto IL_11D;
				}
				IL_10F:
				num2 = 17;
				result = "ListViewEditEventArgs";
				goto IL_E7C;
				IL_11D:
				num2 = 19;
				if (Operators.CompareString(left, "DrawViewCell", true) != 0)
				{
					goto IL_13D;
				}
				IL_12F:
				num2 = 20;
				result = "ListViewDrawCellEventArgs";
				goto IL_E7C;
				IL_13D:
				num2 = 22;
				if (Operators.CompareString(left, "DataFormat", true) != 0)
				{
					goto IL_15D;
				}
				IL_14F:
				num2 = 23;
				result = "FormattingEventArgs";
				goto IL_E7C;
				IL_15D:
				num2 = 25;
				if (Operators.CompareString(left, "DataParse", true) != 0)
				{
					goto IL_17D;
				}
				IL_16F:
				num2 = 26;
				result = "ParsingEventArgs";
				goto IL_E7C;
				IL_17D:
				num2 = 28;
				if (Operators.CompareString(left, "AfterCollapseNode", true) != 0)
				{
					goto IL_19D;
				}
				IL_18F:
				num2 = 29;
				result = "TreeViewEventArgs";
				goto IL_E7C;
				IL_19D:
				num2 = 31;
				if (Operators.CompareString(left, "GaugeItemClick", true) != 0 && Operators.CompareString(left, "GaugeItemDoubleClick", true) != 0 && Operators.CompareString(left, "GaugeItemStateChanged", true) != 0 && Operators.CompareString(left, "GaugeItemMouseEnter", true) != 0 && Operators.CompareString(left, "GaugeItemMouseLeave", true) != 0)
				{
					goto IL_1F9;
				}
				IL_1EB:
				num2 = 32;
				result = "GaugeItemEventArgs";
				goto IL_E7C;
				IL_1F9:
				num2 = 34;
				if (Operators.CompareString(left, "GaugeItemMouseMove", true) != 0 && Operators.CompareString(left, "GaugeItemMouseDown", true) != 0 && Operators.CompareString(left, "GaugeItemMouseUp", true) != 0)
				{
					goto IL_237;
				}
				IL_229:
				num2 = 35;
				result = "GaugeItemMouseEventArgs";
				goto IL_E7C;
				IL_237:
				num2 = 37;
				if (Operators.CompareString(left, "PointerDragMove", true) != 0 && Operators.CompareString(left, "PointerDragCancel", true) != 0 && Operators.CompareString(left, "PointerDragBegin", true) != 0 && Operators.CompareString(left, "PointerDragEnd", true) != 0)
				{
					goto IL_284;
				}
				IL_276:
				num2 = 38;
				result = "GaugePointerDragEventArgs";
				goto IL_E7C;
				IL_284:
				num2 = 40;
				if (Operators.CompareString(left, "GaugeFormatLabel", true) != 0)
				{
					goto IL_2A4;
				}
				IL_296:
				num2 = 41;
				result = "GaugeFormatLabelEventArgs";
				goto IL_E7C;
				IL_2A4:
				num2 = 43;
				if (Operators.CompareString(left, "GaugePointerValueChanged", true) != 0)
				{
					goto IL_2C4;
				}
				IL_2B6:
				num2 = 44;
				result = "GaugePointerValueChangedEventArgs";
				goto IL_E7C;
				IL_2C4:
				num2 = 46;
				if (Operators.CompareString(left, "GannttStripItemClik", true) != 0)
				{
					goto IL_2E4;
				}
				IL_2D6:
				num2 = 47;
				result = "GannttStripItemClikEventArgs";
				goto IL_E7C;
				IL_2E4:
				num2 = 49;
				if (Operators.CompareString(left, "BeforeEditTask", true) != 0 && Operators.CompareString(left, "AfterEditTask", true) != 0 && Operators.CompareString(left, "BeforeRemoveTask", true) != 0 && Operators.CompareString(left, "BeforeAddTask", true) != 0)
				{
					goto IL_331;
				}
				IL_323:
				num2 = 50;
				result = "GanttTaskEventArgs";
				goto IL_E7C;
				IL_331:
				num2 = 52;
				if (Operators.CompareString(left, "BeforeMoveTasks", true) != 0)
				{
					goto IL_351;
				}
				IL_343:
				num2 = 53;
				result = "GanttTasksEventArgs";
				goto IL_E7C;
				IL_351:
				num2 = 55;
				if (Operators.CompareString(left, "TaskBarTooltip", true) != 0)
				{
					goto IL_371;
				}
				IL_363:
				num2 = 56;
				result = "GanttTaskBarTooltipEventArgs";
				goto IL_E7C;
				IL_371:
				num2 = 58;
				if (Operators.CompareString(left, "TaskBarClick", true) != 0)
				{
					goto IL_391;
				}
				IL_383:
				num2 = 59;
				result = "GanttTaskBarClickEventArgs";
				goto IL_E7C;
				IL_391:
				num2 = 61;
				if (Operators.CompareString(left, "PaintDay", true) != 0)
				{
					goto IL_3B1;
				}
				IL_3A3:
				num2 = 62;
				result = "GanttPaintDayEventArgs";
				goto IL_E7C;
				IL_3B1:
				num2 = 64;
				if (Operators.CompareString(left, "ChartClick", true) != 0 && Operators.CompareString(left, "ChartDoubleClick", true) != 0 && Operators.CompareString(left, "ChartMouseHover", true) != 0)
				{
					goto IL_3EF;
				}
				IL_3E1:
				num2 = 65;
				result = "ChartEventArgs";
				goto IL_E7C;
				IL_3EF:
				num2 = 67;
				if (Operators.CompareString(left, "GetMapTile", true) != 0)
				{
					goto IL_40F;
				}
				IL_401:
				num2 = 68;
				result = "GetMapTileEventArgs";
				goto IL_E7C;
				IL_40F:
				num2 = 70;
				if (Operators.CompareString(left, "GetVirtualItems", true) != 0)
				{
					goto IL_42F;
				}
				IL_421:
				num2 = 71;
				result = "GetVirtualItemsEventArgs";
				goto IL_E7C;
				IL_42F:
				num2 = 73;
				if (Operators.CompareString(left, "OwerDrawMark", true) != 0 && Operators.CompareString(left, "GetDrawingBounds", true) != 0)
				{
					goto IL_45E;
				}
				IL_450:
				num2 = 74;
				result = "OwerDrawMarkEventArgs";
				goto IL_E7C;
				IL_45E:
				num2 = 76;
				if (Operators.CompareString(left, "ChartMouseDown", true) != 0 && Operators.CompareString(left, "ChartMouseUp", true) != 0 && Operators.CompareString(left, "ChartMouseMove", true) != 0)
				{
					goto IL_49C;
				}
				IL_48E:
				num2 = 77;
				result = "ChartMouseEventArgs";
				goto IL_E7C;
				IL_49C:
				num2 = 79;
				if (Operators.CompareString(left, "ChartShowTooltip", true) != 0)
				{
					goto IL_4BC;
				}
				IL_4AE:
				num2 = 80;
				result = "ChartToolTipEventArgs";
				goto IL_E7C;
				IL_4BC:
				num2 = 82;
				if (Operators.CompareString(left, "MouseClick", true) != 0)
				{
					goto IL_4DC;
				}
				IL_4CE:
				num2 = 83;
				result = "ControlMouseEventArgs";
				goto IL_E7C;
				IL_4DC:
				num2 = 85;
				if (Operators.CompareString(left, "CenterChanged", true) != 0 && Operators.CompareString(left, "ZoomChanged", true) != 0)
				{
					goto IL_50B;
				}
				IL_4FD:
				num2 = 86;
				result = "ControlEventArgs";
				goto IL_E7C;
				IL_50B:
				num2 = 88;
				if (Operators.CompareString(left, "InitializationCompleted", true) != 0)
				{
					goto IL_52B;
				}
				IL_51D:
				num2 = 89;
				result = "InitializationCompletedEventArgs";
				goto IL_E7C;
				IL_52B:
				num2 = 91;
				if (Operators.CompareString(left, "NavigationStarting", true) != 0)
				{
					goto IL_54B;
				}
				IL_53D:
				num2 = 92;
				result = "NavigationStartingEventArgs";
				goto IL_E7C;
				IL_54B:
				num2 = 94;
				if (Operators.CompareString(left, "NavigationCompleted", true) != 0)
				{
					goto IL_56B;
				}
				IL_55D:
				num2 = 95;
				result = "NavigationCompletedEventArgs";
				goto IL_E7C;
				IL_56B:
				num2 = 97;
				if (Operators.CompareString(left, "SourceChanged", true) != 0)
				{
					goto IL_58B;
				}
				IL_57D:
				num2 = 98;
				result = "SourceChangedEventArgs";
				goto IL_E7C;
				IL_58B:
				num2 = 100;
				if (Operators.CompareString(left, "ContextMenuRequested", true) != 0)
				{
					goto IL_5AB;
				}
				IL_59D:
				num2 = 101;
				result = "ContextMenuRequestedEventArgs";
				goto IL_E7C;
				IL_5AB:
				num2 = 103;
				if (Operators.CompareString(left, "DOMContentLoaded", true) != 0)
				{
					goto IL_5CB;
				}
				IL_5BD:
				num2 = 104;
				result = "DOMContentLoadedEventArgs";
				goto IL_E7C;
				IL_5CB:
				num2 = 106;
				if (Operators.CompareString(left, "ContentLoading", true) != 0)
				{
					goto IL_5EB;
				}
				IL_5DD:
				num2 = 107;
				result = "ContentLoadingEventArgs";
				goto IL_E7C;
				IL_5EB:
				num2 = 109;
				if (Operators.CompareString(left, "ZoomFactorChanged", true) != 0 && Operators.CompareString(left, "HistoryChanged", true) != 0)
				{
					goto IL_61A;
				}
				IL_60C:
				num2 = 110;
				result = "ControlEventArgs";
				goto IL_E7C;
				IL_61A:
				num2 = 112;
				if (Operators.CompareString(left, "WebMessageReceived", true) != 0)
				{
					goto IL_63A;
				}
				IL_62C:
				num2 = 113;
				result = "WebMessageReceivedEventArgs";
				goto IL_E7C;
				IL_63A:
				num2 = 115;
				if (Operators.CompareString(left, "NewWindowRequested", true) != 0)
				{
					goto IL_65A;
				}
				IL_64C:
				num2 = 116;
				result = "NewWindowRequestedEventArgs";
				goto IL_E7C;
				IL_65A:
				num2 = 118;
				if (Operators.CompareString(left, "WebResourceRequested", true) != 0)
				{
					goto IL_67A;
				}
				IL_66C:
				num2 = 119;
				result = "WebResourceRequestedEventArgs";
				goto IL_E7C;
				IL_67A:
				num2 = 121;
				if (Operators.CompareString(left, "WebResourceResponseReceived", true) != 0)
				{
					goto IL_69A;
				}
				IL_68C:
				num2 = 122;
				result = "WebResourceResponseReceivedEventArgs";
				goto IL_E7C;
				IL_69A:
				num2 = 124;
				if (Operators.CompareString(left, "StatusBarTextChanged", true) != 0)
				{
					goto IL_6BA;
				}
				IL_6AC:
				num2 = 125;
				result = "ControlEventArgs";
				goto IL_E7C;
				IL_6BA:
				num2 = 127;
				if (Operators.CompareString(left, "ScriptDialogOpening", true) != 0)
				{
					goto IL_6DD;
				}
				IL_6CC:
				num2 = 128;
				result = "ScriptDialogOpeningEventArgs";
				goto IL_E7C;
				IL_6DD:
				num2 = 130;
				if (Operators.CompareString(left, "DownloadStarting", true) != 0)
				{
					goto IL_703;
				}
				IL_6F2:
				num2 = 131;
				result = "DownloadStartingEventArgs";
				goto IL_E7C;
				IL_703:
				num2 = 133;
				if (Operators.CompareString(left, "DownloadStateChanged", true) != 0 && Operators.CompareString(left, "DownloadProgressChanged", true) != 0)
				{
					goto IL_738;
				}
				IL_727:
				num2 = 134;
				result = "DownloadStateChangedEventArgs";
				goto IL_E7C;
				IL_738:
				num2 = 135;
				if (Operators.CompareString(A_0, "Project", true) != 0)
				{
					goto IL_BBB;
				}
				IL_74F:
				num2 = 136;
				string left2 = A_1;
				IL_758:
				num2 = 138;
				if (Operators.CompareString(left2, "Server_UserLogging", true) != 0)
				{
					goto IL_77E;
				}
				IL_76D:
				num2 = 139;
				result = "Server_UserLoggingEventArgs";
				goto IL_E7C;
				IL_77E:
				num2 = 141;
				if (Operators.CompareString(left2, "Server_UserLogged", true) != 0)
				{
					goto IL_7A4;
				}
				IL_793:
				num2 = 142;
				result = "Server_UserEventArgs";
				goto IL_E7C;
				IL_7A4:
				num2 = 144;
				if (Operators.CompareString(left2, "Server_UserLogout", true) != 0)
				{
					goto IL_7CA;
				}
				IL_7B9:
				num2 = 145;
				result = "Server_UserLogoutEventArgs";
				goto IL_E7C;
				IL_7CA:
				num2 = 147;
				if (Operators.CompareString(left2, "Server_ReceivedMessage", true) != 0)
				{
					goto IL_7F0;
				}
				IL_7DF:
				num2 = 148;
				result = "Server_MessageEventargs";
				goto IL_E7C;
				IL_7F0:
				num2 = 150;
				if (Operators.CompareString(left2, "Server_UserChangePassword", true) != 0)
				{
					goto IL_816;
				}
				IL_805:
				num2 = 151;
				result = "Server_ChangeUserPasswordEventArgs";
				goto IL_E7C;
				IL_816:
				num2 = 153;
				if (Operators.CompareString(left2, "Server_WeMessageReceived", true) != 0)
				{
					goto IL_83C;
				}
				IL_82B:
				num2 = 154;
				result = "WeChatMessageReceived";
				goto IL_E7C;
				IL_83C:
				num2 = 156;
				if (Operators.CompareString(left2, "Client_BuddyLogin", true) != 0)
				{
					goto IL_862;
				}
				IL_851:
				num2 = 157;
				result = "Client_BuddyLoginEventArgs";
				goto IL_E7C;
				IL_862:
				num2 = 159;
				if (Operators.CompareString(left2, "Client_BuddyLogout", true) != 0)
				{
					goto IL_888;
				}
				IL_877:
				num2 = 160;
				result = "Client_BuddyLogoutEventArgs";
				goto IL_E7C;
				IL_888:
				num2 = 162;
				if (Operators.CompareString(left2, "Client_ReceivedMessage", true) != 0)
				{
					goto IL_8AE;
				}
				IL_89D:
				num2 = 163;
				result = "Client_MessageEventargs";
				goto IL_E7C;
				IL_8AE:
				num2 = 165;
				if (Operators.CompareString(left2, "Disconnected", true) != 0)
				{
					goto IL_8D4;
				}
				IL_8C3:
				num2 = 166;
				result = "Client_LogoutEventArgs";
				goto IL_E7C;
				IL_8D4:
				num2 = 168;
				if (Operators.CompareString(left2, "Client_UserChangePassword", true) != 0)
				{
					goto IL_8FA;
				}
				IL_8E9:
				num2 = 169;
				result = "Client_ChangeUserPasswordEventArgs";
				goto IL_E7C;
				IL_8FA:
				num2 = 171;
				if (Operators.CompareString(left2, "Connected", true) != 0)
				{
					goto IL_920;
				}
				IL_90F:
				num2 = 172;
				result = "Client_UserEventArgs";
				goto IL_E7C;
				IL_920:
				num2 = 174;
				if (Operators.CompareString(left2, "Client_AfterSendFile", true) != 0 && Operators.CompareString(left2, "Server_AfterSendFile", true) != 0)
				{
					goto IL_955;
				}
				IL_944:
				num2 = 175;
				result = "AfterSendFileEventArgs";
				goto IL_E7C;
				IL_955:
				num2 = 177;
				if (Operators.CompareString(left2, "Client_AfterReveiveFile", true) != 0 && Operators.CompareString(left2, "Server_AfterReveiveFile", true) != 0)
				{
					goto IL_98A;
				}
				IL_979:
				num2 = 178;
				result = "AfterReceiveFileEventArgs";
				goto IL_E7C;
				IL_98A:
				num2 = 180;
				if (Operators.CompareString(left2, "Client_WeMessageReceived", true) != 0)
				{
					goto IL_9B0;
				}
				IL_99F:
				num2 = 181;
				result = "weMessageReceived";
				goto IL_E7C;
				IL_9B0:
				num2 = 183;
				if (Operators.CompareString(left2, "Client_NewWeChatUser", true) != 0)
				{
					goto IL_9D6;
				}
				IL_9C5:
				num2 = 184;
				result = "NewWeChatUser";
				goto IL_E7C;
				IL_9D6:
				num2 = 186;
				if (Operators.CompareString(left2, "BeforeShowMenu", true) != 0)
				{
					goto IL_9FC;
				}
				IL_9EB:
				num2 = 187;
				result = "OpenQQMenuEventArgs";
				goto IL_E7C;
				IL_9FC:
				num2 = 189;
				if (Operators.CompareString(left2, "CustomMenuClick", true) != 0)
				{
					goto IL_A22;
				}
				IL_A11:
				num2 = 190;
				result = "CustomMenuClickEventArgs";
				goto IL_E7C;
				IL_A22:
				num2 = 192;
				if (Operators.CompareString(left2, "UDPClient_ReceivedMessage", true) != 0)
				{
					goto IL_A48;
				}
				IL_A37:
				num2 = 193;
				result = "UDPClient_MessageReceived";
				goto IL_E7C;
				IL_A48:
				num2 = 195;
				if (Operators.CompareString(left2, "HttpRequest", true) != 0 && Operators.CompareString(left2, "BeforeHttpRequest", true) != 0)
				{
					goto IL_A7D;
				}
				IL_A6C:
				num2 = 196;
				result = "RequestEventArgs";
				goto IL_E7C;
				IL_A7D:
				num2 = 198;
				if (Operators.CompareString(left2, "BeforeRename", true) != 0 && Operators.CompareString(left2, "AfterRename", true) != 0)
				{
					goto IL_AB2;
				}
				IL_AA1:
				num2 = 199;
				result = "FTPRenameEventArgs";
				goto IL_E7C;
				IL_AB2:
				num2 = 201;
				if (Operators.CompareString(left2, "BeforeDelete", true) != 0 && Operators.CompareString(left2, "AfterDelete", true) != 0)
				{
					goto IL_AE7;
				}
				IL_AD6:
				num2 = 202;
				result = "FTPDeleteEventargs";
				goto IL_E7C;
				IL_AE7:
				num2 = 204;
				if (Operators.CompareString(left2, "BeforeEnterFolder", true) != 0 && Operators.CompareString(left2, "BeforeCreateFolder", true) != 0 && Operators.CompareString(left2, "AfterCreateFolder", true) != 0)
				{
					goto IL_B2B;
				}
				IL_B1A:
				num2 = 205;
				result = "FTPFolderEventArgs";
				goto IL_E7C;
				IL_B2B:
				num2 = 207;
				if (Operators.CompareString(left2, "BeforeDownload", true) != 0 && Operators.CompareString(left2, "AfterDownload", true) != 0)
				{
					goto IL_B60;
				}
				IL_B4F:
				num2 = 208;
				result = "FTPDownloadEventArgs";
				goto IL_E7C;
				IL_B60:
				num2 = 210;
				if (Operators.CompareString(left2, "BeforeUpload", true) != 0 && Operators.CompareString(left2, "AfterUpload", true) != 0)
				{
					goto IL_B95;
				}
				IL_B84:
				num2 = 211;
				result = "FTPUploadEventArgs";
				goto IL_E7C;
				IL_B95:
				num2 = 213;
				if (Operators.CompareString(left2, "BeforeListDetails", true) != 0)
				{
					goto IL_BBB;
				}
				IL_BAA:
				num2 = 214;
				result = "FTPBeforeListDetailsEventArgs";
				goto IL_E7C;
				IL_BBB:
				num2 = 215;
				if (Operators.CompareString(A_0, "Table", true) != 0 && Operators.CompareString(A_0, "Project", true) != 0)
				{
					goto IL_C9E;
				}
				IL_BE0:
				num2 = 216;
				if (Operators.CompareString(A_1, "TableAllowEditChanged", true) != 0 && Operators.CompareString(A_1, "BeforeUnhideColumn", true) != 0)
				{
					goto IL_C13;
				}
				IL_C02:
				num2 = 217;
				result = "TableEventArgs";
				goto IL_E7C;
				IL_C13:
				num2 = 218;
				if (Operators.CompareString(A_1, "Click", true) != 0 && Operators.CompareString(A_1, "DoubleClick", true) != 0 && Operators.CompareString(A_1, "DoubleClickRowHeader", true) != 0)
				{
					goto IL_C54;
				}
				IL_C43:
				num2 = 219;
				result = "CellClickEventArgs";
				goto IL_E7C;
				IL_C54:
				num2 = 220;
				if (Operators.CompareString(A_1, "MouseHoverCell", true) != 0)
				{
					goto IL_C79;
				}
				IL_C68:
				num2 = 221;
				result = "MouseHoverCellEventArgs";
				goto IL_E7C;
				IL_C79:
				num2 = 222;
				if (Operators.CompareString(A_1, "AfterSaveDataRow", true) != 0)
				{
					goto IL_C9E;
				}
				IL_C8D:
				num2 = 223;
				result = "UpdateRowEventArgs";
				goto IL_E7C;
				IL_C9E:
				num2 = 224;
				if (Operators.CompareString(A_0, "RibbonGallery", true) != 0)
				{
					goto IL_CC3;
				}
				IL_CB2:
				num2 = 225;
				result = "RibbonGalleryEventArgs";
				goto IL_E7C;
				IL_CC3:
				num2 = 227;
				if (Operators.CompareString(A_0, "RibbonTrackBar", true) != 0)
				{
					goto IL_CE8;
				}
				IL_CD7:
				num2 = 228;
				result = "RibbonTrackBarEventArgs";
				goto IL_E7C;
				IL_CE8:
				num2 = 230;
				if (Operators.CompareString(A_0, "RibbonTimePicker", true) != 0)
				{
					goto IL_D0D;
				}
				IL_CFC:
				num2 = 231;
				result = "RibbonTimePickerEventArgs";
				goto IL_E7C;
				IL_D0D:
				num2 = 232;
				if (Operators.CompareString(A_0, "Form", true) != 0)
				{
					goto IL_E2B;
				}
				IL_D24:
				num2 = 233;
				string left3 = A_1;
				IL_D2D:
				num2 = 235;
				if (Operators.CompareString(left3, "ItemClick", true) != 0 && Operators.CompareString(left3, "ItemSelectedIndexChanged", true) != 0 && Operators.CompareString(left3, "ItemEnter", true) != 0 && Operators.CompareString(left3, "ItemLeave", true) != 0 && Operators.CompareString(left3, "ItemMouseEnter", true) != 0 && Operators.CompareString(left3, "ItemMouseLeave", true) != 0 && Operators.CompareString(left3, "ItemMouseHover", true) != 0)
				{
					goto IL_DAD;
				}
				IL_D9C:
				num2 = 236;
				result = "StripItemEventArgs";
				goto IL_E7C;
				IL_DAD:
				num2 = 238;
				if (Operators.CompareString(left3, "DataFormat", true) != 0)
				{
					goto IL_DD3;
				}
				IL_DC2:
				num2 = 239;
				result = "FormattingEventArgs";
				goto IL_E7C;
				IL_DD3:
				num2 = 241;
				if (Operators.CompareString(left3, "DataParse", true) != 0)
				{
					goto IL_DF9;
				}
				IL_DE8:
				num2 = 242;
				result = "ParsingEventArgs";
				goto IL_E7C;
				IL_DF9:
				num2 = 244;
				if (Operators.CompareString(left3, "ResizingControl", true) != 0 && Operators.CompareString(left3, "ResizingFont", true) != 0)
				{
					goto IL_E2B;
				}
				IL_E1D:
				num2 = 245;
				result = "ControlEventArgs";
				goto IL_E7C;
				IL_E2B:
				num2 = 246;
				if (o0_.o_000Oo0O_.00o. != null)
				{
					goto IL_E59;
				}
				IL_E38:
				num2 = 247;
				o0_.o_000Oo0O_.00o. = new Table.Oo_0O0o_();
				IL_E48:
				num2 = 248;
				o0_.o_000Oo0O_.00o..o_Oo.0o0oo__o.();
				IL_E59:
				num2 = 249;
				result = o0_.o_000Oo0O_.00o..o_Oo.0o0oo__o.(A_0, A_1).Trim(new char[1]).Trim();
				IL_E7C:
				goto IL_12B6;
				IL_E81:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1277:
				goto IL_12AB;
				IL_1279:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1289:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1279;
			}
			IL_12AB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_12B6:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x00202500 File Offset: 0x00200700
		private static string <<EMPTY_NAME>>()
		{
			return "1ZU9/5j/Mx7bGNZYTZuqfg==";
		}

		// Token: 0x04001DD4 RID: 7636
		internal static Table.Oo_0O0o_ <<EMPTY_NAME>>;

		// Token: 0x04001DD5 RID: 7637
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x04001DD6 RID: 7638
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x04001DD7 RID: 7639
		internal static string <<EMPTY_NAME>>;

		// Token: 0x04001DD8 RID: 7640
		private static readonly string <<EMPTY_NAME>>;

		// Token: 0x04001DD9 RID: 7641
		private static readonly string <<EMPTY_NAME>>;

		// Token: 0x04001DDA RID: 7642
		private static object <<EMPTY_NAME>>;

		// Token: 0x04001DDB RID: 7643
		private static string <<EMPTY_NAME>>;

		// Token: 0x04001DDC RID: 7644
		private static readonly int <<EMPTY_NAME>>;

		// Token: 0x04001DDD RID: 7645
		private static readonly int <<EMPTY_NAME>>;

		// Token: 0x04001DDE RID: 7646
		private static readonly int <<EMPTY_NAME>>;
	}
}
