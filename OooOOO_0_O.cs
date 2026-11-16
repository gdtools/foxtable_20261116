using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Text.Parsing;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.Outlining.Implementation;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200006F RID: 111
	internal class OooOOO_0_O : RangeOutliningSourceBase, IParseData
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x00017278 File Offset: 0x00015478
		static OooOOO_0_O()
		{
			OooOOO_0_O.Oo_O.0_0o0_..Add(11128, "if");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11211, "while");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11118, "for");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11104, "do");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11183, "select");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11213, "with");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11107, "else");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11108, "elseif");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11074, "case");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11250, "#Region");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11251, "Region");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11194, "sub");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11120, "function");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11084, "class");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11144, "module");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11111, "enum");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11193, "structure");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11161, "operator");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11134, "interface");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11172, "property");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11184, "set");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11121, "get");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11150, "namespace");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11153, "next");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11141, "loop");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11200, "try");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11075, "catch");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11117, "finally");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11207, "using");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11244, "#if");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11245, "#elseif");
			OooOOO_0_O.Oo_O.0_0o0_..Add(11246, "#else");
			OooOOO_0_O.Oo_O.0_0o0_. = new OutliningNodeDefinition("Region");
			OooOOO_0_O.Oo_O.0_0o0_..IsImplementation = true;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00017550 File Offset: 0x00015750
		private void <<EMPTY_NAME>>(o0Ooo0_O_ A_0)
		{
			A_0.oOo.OooOO0.(true);
			try
			{
				foreach (o0Ooo0_O_ o0Ooo0_O_ in OooOOO_0_O.Oo_O.0_0o0_.)
				{
					if (o0Ooo0_O_.oo.00O0__o.() == A_0 && !o0Ooo0_O_.oo.00O0__o.())
					{
						this.Oo_O.0_0o0_.(o0Ooo0_O_);
					}
				}
			}
			finally
			{
				List<o0Ooo0_O_>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000175BC File Offset: 0x000157BC
		private bool <<EMPTY_NAME>>(ITextSnapshotReader A_0, int A_1)
		{
			for (int i = OooOOO_0_O.Oo_O.0_0o0_..Count - 1; i >= 0; i += -1)
			{
				o0Ooo0_O_ o0Ooo0_O_ = OooOOO_0_O.Oo_O.0_0o0_.[i];
				if (!o0Ooo0_O_.oo.00O0__o.())
				{
					bool result;
					if ((A_1 == 11107 || A_1 == 11108) && o0Ooo0_O_.oo.00O0__o.() == 11128)
					{
						result = false;
					}
					else if ((A_1 == 11075 || A_1 == 11117) && o0Ooo0_O_.oo.00O0__o.() == 11200)
					{
						result = false;
					}
					else if (A_1 == 11074 && o0Ooo0_O_.oo.00O0__o.() == 11183)
					{
						result = false;
					}
					else
					{
						if (o0Ooo0_O_.oo.00O0__o.() != A_1)
						{
							goto IL_137;
						}
						this.Oo_O.0_0o0_.(o0Ooo0_O_);
						A_0.GoToCurrentSnapshotLineEnd();
						oo0o0O_oO_0_o oo0o0O_oO_0_o = new oo0o0O_oO_0_o(A_1, o0Ooo0_O_.O.0_O0O.(), A_0.Offset);
						if (OooOOO_0_O.Oo_O.0_0o0_..Count > 0 && OooOOO_0_O.Oo_O.0_0o0_.[OooOOO_0_O.Oo_O.0_0o0_..Count - 1].O0o_0o0O.0_O.() == oo0o0O_oO_0_o.O0o_0o0O.0_O.())
						{
							OooOOO_0_O.Oo_O.0_0o0_.[OooOOO_0_O.Oo_O.0_0o0_..Count - 1].OoOO._Ooo.(OooOOO_0_O.Oo_O.0_0o0_.[OooOOO_0_O.Oo_O.0_0o0_..Count - 1].O0o_0o0O.0_O.() - 1);
						}
						oo0o0O_oO_0_o.O.OoO00O.(o0Ooo0_O_);
						OooOOO_0_O.Oo_O.0_0o0_..Add(oo0o0O_oO_0_o);
						result = true;
					}
					return result;
				}
				IL_137:;
			}
			return false;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00017710 File Offset: 0x00015910
		internal OooOOO_0_O(ITextSnapshot A_0) : base(A_0)
		{
			this.oOo.0.(A_0);
			try
			{
				foreach (oo0o0O_oO_0_o oo0o0O_oO_0_o in OooOOO_0_O.Oo_O.0_0o0_.)
				{
					this.AddNode(new TextRange(oo0o0O_oO_0_o.OoOO._Ooo.(), oo0o0O_oO_0_o.O0o_0o0O.0_O.()), OooOOO_0_O.Oo_O.0_0o0_.);
				}
			}
			finally
			{
				List<oo0o0O_oO_0_o>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00017788 File Offset: 0x00015988
		internal void <<EMPTY_NAME>>(ITextSnapshot A_0)
		{
			int num;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				OooOOO_0_O.Oo_O.0_0o0_..Clear();
				IL_13:
				num2 = 3;
				OooOOO_0_O.Oo_O.0_0o0_..Clear();
				IL_1F:
				num2 = 4;
				ITextSnapshotReader reader = A_0.GetReader(0);
				for (;;)
				{
					IL_C6B:
					num2 = 6;
					if (reader.IsAtSnapshotEnd)
					{
						break;
					}
					IL_2F:
					num2 = 7;
					IToken token = reader.ReadToken();
					IL_39:
					num2 = 8;
					if (token == null)
					{
						break;
					}
					IL_41:
					num2 = 10;
					int offset = reader.Offset;
					IL_4D:
					num2 = 11;
					int id = token.Id;
					if (id <= 11134)
					{
						if (id <= 11075)
						{
							if (id <= 11017)
							{
								if (id == 11000)
								{
									continue;
								}
								if (id != 11010)
								{
									if (id != 11017)
									{
										continue;
									}
									IL_265:
									num2 = 13;
									if (O_ooO0.O__o.O000.(reader, token))
									{
										IL_275:
										num2 = 14;
										ITextSnapshotLine snapshotLine = reader.SnapshotLine;
										IL_281:
										num2 = 15;
										ITextSnapshotLine textSnapshotLine = null;
										for (;;)
										{
											IL_2DF:
											num2 = 17;
											if (reader.IsAtSnapshotEnd)
											{
												break;
											}
											IL_289:
											num2 = 18;
											IToken token2 = reader.ReadToken();
											IL_295:
											num2 = 19;
											if (token2.Id != 11000 && token2.Id != 11001)
											{
												IL_2B4:
												num2 = 21;
												if (token2.Id != 11017)
												{
													goto IL_2D3;
												}
												IL_2C5:
												num2 = 22;
												textSnapshotLine = reader.SnapshotLine;
											}
										}
										IL_2EB:
										num2 = 27;
										if (textSnapshotLine != null && textSnapshotLine.StartOffset != snapshotLine.StartOffset)
										{
											IL_308:
											num2 = 28;
											o0Ooo0_O_ o0Ooo0_O_ = new o0Ooo0_O_(11017, snapshotLine.StartOffset, OooOOO_0_O.Oo_O.0_0o0_.);
											IL_323:
											num2 = 29;
											o0Ooo0_O_.oOo.OooOO0.(true);
											IL_32E:
											num2 = 30;
											OooOOO_0_O.Oo_O.0_0o0_..Add(o0Ooo0_O_);
											IL_33D:
											num2 = 31;
											oo0o0O_oO_0_o oo0o0O_oO_0_o = new oo0o0O_oO_0_o(11017, snapshotLine.EndOffset, textSnapshotLine.EndOffset);
											IL_35A:
											num2 = 32;
											oo0o0O_oO_0_o.O.OoO00O.(o0Ooo0_O_);
											IL_366:
											num2 = 33;
											OooOOO_0_O.Oo_O.0_0o0_..Add(oo0o0O_oO_0_o);
											continue;
										}
										continue;
										IL_2D3:
										num2 = 24;
										reader.GoToCurrentSnapshotLineStart();
										goto IL_2EB;
									}
									continue;
								}
							}
							else if (id != 11019)
							{
								if (id != 11033)
								{
									if (id - 11074 > 1)
									{
										continue;
									}
									goto IL_49B;
								}
							}
							else
							{
								IL_37A:
								num2 = 35;
								if (O_ooO0.O__o.O000.(reader, token))
								{
									IL_38A:
									num2 = 36;
									ITextSnapshotLine snapshotLine2 = reader.SnapshotLine;
									IL_396:
									num2 = 37;
									ITextSnapshotLine textSnapshotLine2 = null;
									for (;;)
									{
										IL_3F1:
										num2 = 39;
										if (reader.IsAtSnapshotEnd)
										{
											break;
										}
										IL_39E:
										num2 = 40;
										IToken token3 = reader.ReadToken();
										IL_3AA:
										num2 = 41;
										int id2 = token3.Id;
										if (id2 - 11000 > 1)
										{
											if (id2 != 11019)
											{
												if (id2 - 11020 > 1)
												{
													goto Block_37;
												}
											}
											else
											{
												IL_3D7:
												num2 = 44;
												textSnapshotLine2 = reader.SnapshotLine;
											}
										}
									}
									IL_3FD:
									num2 = 50;
									if (textSnapshotLine2 != null && textSnapshotLine2.StartOffset != snapshotLine2.StartOffset)
									{
										IL_41A:
										num2 = 51;
										o0Ooo0_O_ o0Ooo0_O_2 = new o0Ooo0_O_(11019, snapshotLine2.StartOffset, OooOOO_0_O.Oo_O.0_0o0_.);
										IL_435:
										num2 = 52;
										o0Ooo0_O_2.oOo.OooOO0.(true);
										IL_440:
										num2 = 53;
										OooOOO_0_O.Oo_O.0_0o0_..Add(o0Ooo0_O_2);
										IL_44F:
										num2 = 54;
										oo0o0O_oO_0_o oo0o0O_oO_0_o2 = new oo0o0O_oO_0_o(11019, snapshotLine2.EndOffset, textSnapshotLine2.EndOffset);
										IL_46C:
										num2 = 55;
										oo0o0O_oO_0_o2.O.OoO00O.(o0Ooo0_O_2);
										IL_478:
										num2 = 56;
										OooOOO_0_O.Oo_O.0_0o0_..Add(oo0o0O_oO_0_o2);
										continue;
									}
									continue;
									Block_37:
									IL_3E5:
									num2 = 46;
									reader.GoToCurrentSnapshotLineStart();
									goto IL_3FD;
								}
								continue;
							}
						}
						else if (id <= 11118)
						{
							if (id == 11084)
							{
								goto IL_6C2;
							}
							switch (id)
							{
							case 11102:
								break;
							case 11103:
							case 11105:
							case 11106:
							case 11110:
								continue;
							case 11104:
							case 11107:
							case 11108:
								goto IL_49B;
							case 11109:
							{
								IL_900:
								num2 = 139;
								string input = reader.SnapshotLine.Text.Trim();
								IL_919:
								num2 = 140;
								string[] array = OooOOO_0_O.Oo_O.0_0o0_..Split(input);
								IL_92D:
								num2 = 141;
								if (array.Length < 2 || Operators.CompareString(array[0], "end", true) != 0)
								{
									continue;
								}
								IL_951:
								num2 = 142;
								string left = array[1];
								IL_95D:
								num2 = 144;
								if (Operators.CompareString(left, "if", true) == 0)
								{
									IL_972:
									num2 = 145;
									reader.GoToPreviousSnapshotLineEnd();
									IL_97F:
									num2 = 146;
									if (!this.OoOo.0oo.(reader, 11107))
									{
										IL_994:
										num2 = 147;
										reader.Offset = offset;
										IL_9A3:
										num2 = 148;
										reader.GoToPreviousSnapshotLineEnd();
										IL_9B0:
										num2 = 149;
										this.OoOo.0oo.(reader, 11108);
									}
									IL_9C4:
									num2 = 150;
									reader.Offset = offset;
									IL_9D3:
									num2 = 151;
									this.OoOo.0oo.(reader, 11128);
									continue;
								}
								IL_9EC:
								num2 = 153;
								if (Operators.CompareString(left, "select", true) == 0)
								{
									IL_A01:
									num2 = 154;
									reader.GoToPreviousSnapshotLineEnd();
									IL_A0E:
									num2 = 155;
									this.OoOo.0oo.(reader, 11074);
									IL_A22:
									num2 = 156;
									reader.Offset = offset;
									IL_A31:
									num2 = 157;
									this.OoOo.0oo.(reader, 11183);
									continue;
								}
								IL_A4A:
								num2 = 159;
								if (Operators.CompareString(left, "while", true) == 0 || Operators.CompareString(left, "with", true) == 0 || Operators.CompareString(left, "sub", true) == 0 || Operators.CompareString(left, "function", true) == 0 || Operators.CompareString(left, "class", true) == 0 || Operators.CompareString(left, "module", true) == 0 || Operators.CompareString(left, "enum", true) == 0 || Operators.CompareString(left, "structure", true) == 0 || Operators.CompareString(left, "enum", true) == 0 || Operators.CompareString(left, "structure", true) == 0 || Operators.CompareString(left, "operator", true) == 0 || Operators.CompareString(left, "interface", true) == 0 || Operators.CompareString(left, "property", true) == 0 || Operators.CompareString(left, "set", true) == 0 || Operators.CompareString(left, "get", true) == 0 || Operators.CompareString(left, "namespace", true) == 0 || Operators.CompareString(left, "using", true) == 0)
								{
									IL_B67:
									num2 = 160;
									Dictionary<int, string>.KeyCollection.Enumerator enumerator = OooOOO_0_O.Oo_O.0_0o0_..Keys.GetEnumerator();
									while (enumerator.MoveNext())
									{
										int num3 = enumerator.Current;
										IL_B89:
										num2 = 161;
										if (Operators.CompareString(OooOOO_0_O.Oo_O.0_0o0_.[num3], array[1], true) == 0)
										{
											IL_BA7:
											num2 = 162;
											this.OoOo.0oo.(reader, num3);
											break;
										}
										IL_BBA:
										num2 = 164;
									}
									IL_BC9:
									num2 = 165;
									((IDisposable)enumerator).Dispose();
									continue;
								}
								IL_BE1:
								num2 = 167;
								if (Operators.CompareString(left, "try", true) == 0)
								{
									IL_BF6:
									num2 = 168;
									reader.GoToPreviousSnapshotLineEnd();
									IL_C03:
									num2 = 169;
									if (!this.OoOo.0oo.(reader, 11117))
									{
										IL_C18:
										num2 = 170;
										reader.Offset = offset;
										IL_C27:
										num2 = 171;
										reader.GoToPreviousSnapshotLineEnd();
										IL_C34:
										num2 = 172;
										this.OoOo.0oo.(reader, 11075);
									}
									IL_C48:
									num2 = 173;
									reader.Offset = offset;
									IL_C57:
									num2 = 174;
									this.OoOo.0oo.(reader, 11200);
									continue;
								}
								continue;
							}
							case 11111:
								goto IL_6C2;
							default:
								if (id - 11117 > 1)
								{
									continue;
								}
								goto IL_49B;
							}
						}
						else
						{
							if (id - 11120 <= 1)
							{
								goto IL_6C2;
							}
							if (id == 11128)
							{
								goto IL_49B;
							}
							if (id != 11134)
							{
								continue;
							}
							goto IL_6C2;
						}
					}
					else if (id <= 11184)
					{
						if (id <= 11153)
						{
							switch (id)
							{
							case 11141:
								break;
							case 11142:
							case 11147:
								goto IL_48C;
							case 11143:
							case 11145:
							case 11146:
								continue;
							case 11144:
								goto IL_6C2;
							default:
								if (id == 11150)
								{
									goto IL_6C2;
								}
								if (id != 11153)
								{
									continue;
								}
								break;
							}
							IL_859:
							num2 = 129;
							string input2 = reader.SnapshotLine.Text.Trim();
							IL_872:
							num2 = 130;
							string[] array2 = OooOOO_0_O.Oo_O.0_0o0_..Split(input2);
							IL_886:
							num2 = 131;
							if (Operators.CompareString(array2[0], OooOOO_0_O.Oo_O.0_0o0_.[token.Id], true) != 0)
							{
								continue;
							}
							IL_8AB:
							num2 = 132;
							int id3 = token.Id;
							if (id3 == 11141)
							{
								IL_8E7:
								num2 = 136;
								this.OoOo.0oo.(reader, 11104);
								continue;
							}
							if (id3 == 11153)
							{
								IL_8CE:
								num2 = 134;
								this.OoOo.0oo.(reader, 11118);
								continue;
							}
							continue;
						}
						else
						{
							if (id == 11161 || id == 11172)
							{
								goto IL_6C2;
							}
							switch (id)
							{
							case 11181:
								break;
							case 11182:
								continue;
							case 11183:
								goto IL_49B;
							case 11184:
								goto IL_6C2;
							default:
								continue;
							}
						}
					}
					else if (id <= 11207)
					{
						if (id - 11193 <= 1)
						{
							goto IL_6C2;
						}
						if (id == 11200)
						{
							goto IL_49B;
						}
						if (id != 11207)
						{
							continue;
						}
						goto IL_6C2;
					}
					else
					{
						if (id == 11211 || id == 11213)
						{
							goto IL_49B;
						}
						switch (id)
						{
						case 11244:
						case 11245:
						case 11246:
						case 11250:
							goto IL_49B;
						case 11247:
							IL_7F4:
							num2 = 121;
							reader.GoToPreviousSnapshotLineEnd();
							IL_7FE:
							num2 = 122;
							if (!this.OoOo.0oo.(reader, 11246))
							{
								IL_810:
								num2 = 123;
								reader.Offset = offset;
								IL_81C:
								num2 = 124;
								reader.GoToPreviousSnapshotLineEnd();
								IL_826:
								num2 = 125;
								this.OoOo.0oo.(reader, 11245);
							}
							IL_837:
							num2 = 126;
							reader.Offset = offset;
							IL_843:
							num2 = 127;
							this.OoOo.0oo.(reader, 11244);
							continue;
						case 11248:
						case 11249:
							continue;
						case 11251:
						{
							IL_7B8:
							num2 = 117;
							string input3 = reader.SnapshotLine.Text.Trim();
							IL_7CE:
							num2 = 118;
							OooOOO_0_O.Oo_O.0_0o0_..Split(input3);
							IL_7DE:
							num2 = 119;
							this.OoOo.0oo.(reader, 11250);
							continue;
						}
						default:
							continue;
						}
					}
					IL_48C:
					num2 = 59;
					reader.GoToNextSnapshotLineStart();
					continue;
					IL_49B:
					num2 = 61;
					string input4 = reader.SnapshotLine.Text.Trim();
					IL_4B1:
					num2 = 62;
					string[] array3 = OooOOO_0_O.Oo_O.0_0o0_..Split(input4);
					IL_4C2:
					num2 = 63;
					if (Operators.CompareString(array3[0], OooOOO_0_O.Oo_O.0_0o0_.[token.Id], true) != 0)
					{
						continue;
					}
					IL_4E4:
					num2 = 64;
					int id4 = token.Id;
					if (id4 <= 11108)
					{
						if (id4 != 11074)
						{
							if (id4 - 11107 <= 1)
							{
								IL_52D:
								num2 = 66;
								reader.GoToPreviousSnapshotLineEnd();
								IL_537:
								num2 = 67;
								this.OoOo.0oo.(reader, 11108);
								IL_548:
								num2 = 68;
								reader.Offset = offset;
							}
						}
						else
						{
							IL_556:
							num2 = 70;
							reader.GoToPreviousSnapshotLineEnd();
							IL_560:
							num2 = 71;
							this.OoOo.0oo.(reader, 11074);
							IL_571:
							num2 = 72;
							reader.Offset = offset;
						}
					}
					else if (id4 != 11117)
					{
						if (id4 - 11245 <= 1)
						{
							IL_57F:
							num2 = 74;
							reader.GoToPreviousSnapshotLineEnd();
							IL_589:
							num2 = 75;
							this.OoOo.0oo.(reader, 11245);
							IL_59A:
							num2 = 76;
							reader.Offset = offset;
						}
					}
					else
					{
						IL_5A8:
						num2 = 78;
						reader.GoToPreviousSnapshotLineEnd();
						IL_5B2:
						num2 = 79;
						this.OoOo.0oo.(reader, 11075);
						IL_5C3:
						num2 = 80;
						reader.Offset = offset;
					}
					IL_5CF:
					num2 = 82;
					if (token.Id == 11128)
					{
						IL_5E2:
						num2 = 83;
						IToken token4 = null;
						IL_5E8:
						num2 = 84;
						bool flag = false;
						IL_5EE:
						num2 = 85;
						bool flag2 = false;
						for (;;)
						{
							IL_646:
							num2 = 87;
							if (reader.IsAtSnapshotLineEnd)
							{
								break;
							}
							IL_5F6:
							num2 = 88;
							token4 = reader.ReadToken();
							IL_602:
							num2 = 89;
							if (token4.Id == 11196)
							{
								IL_613:
								num2 = 90;
								flag = true;
							}
							else
							{
								IL_61B:
								num2 = 92;
								if (flag && (VBTokenId.IsKeywordClassificationType(token4.Id) || VBTokenId.IsIdentifierClassificationType(token4.Id)))
								{
									goto IL_63E;
								}
							}
						}
						IL_652:
						num2 = 96;
						if (!flag2)
						{
							IL_65C:
							num2 = 97;
							reader.GoToCurrentSnapshotLineEnd();
							IL_666:
							num2 = 98;
							OooOOO_0_O.Oo_O.0_0o0_..Add(new o0Ooo0_O_(token.Id, reader.Offset, OooOOO_0_O.Oo_O.0_0o0_.));
							continue;
						}
						continue;
						IL_63E:
						num2 = 93;
						flag2 = true;
						goto IL_652;
					}
					IL_68F:
					num2 = 100;
					reader.GoToCurrentSnapshotLineEnd();
					IL_699:
					num2 = 101;
					OooOOO_0_O.Oo_O.0_0o0_..Add(new o0Ooo0_O_(token.Id, reader.Offset, OooOOO_0_O.Oo_O.0_0o0_.));
					continue;
					IL_6C2:
					num2 = 103;
					reader.GoToCurrentSnapshotLineEnd();
					IL_6CC:
					num2 = 104;
					if (token.Id == 11194 || token.Id == 11120 || token.Id == 11207)
					{
						IL_6F9:
						num2 = 105;
						int offset2 = reader.Offset;
						IL_705:
						num2 = 106;
						reader.Offset = token.StartOffset;
						IL_715:
						num2 = 107;
						IToken token5 = reader.ReadTokenReverse();
						IL_721:
						num2 = 108;
						if (token5 != null && token5.Id == 11000)
						{
							IL_736:
							num2 = 109;
							token5 = reader.ReadTokenReverse();
						}
						IL_742:
						num2 = 110;
						reader.Offset = offset2;
						IL_74E:
						num2 = 111;
						if (token5 == null || token5.Id != 11115)
						{
							IL_766:
							num2 = 113;
							OooOOO_0_O.Oo_O.0_0o0_..Add(new o0Ooo0_O_(token.Id, reader.Offset, OooOOO_0_O.Oo_O.0_0o0_.));
						}
					}
					else
					{
						IL_78F:
						num2 = 115;
						OooOOO_0_O.Oo_O.0_0o0_..Add(new o0Ooo0_O_(token.Id, reader.Offset, OooOOO_0_O.Oo_O.0_0o0_.));
					}
				}
				IL_C79:
				num2 = 177;
				List<o0Ooo0_O_>.Enumerator enumerator2 = OooOOO_0_O.Oo_O.0_0o0_..GetEnumerator();
				while (enumerator2.MoveNext())
				{
					o0Ooo0_O_ o0Ooo0_O_3 = enumerator2.Current;
					IL_C99:
					num2 = 178;
					int num4 = o0Ooo0_O_3.oo.00O0__o.();
					if (num4 <= 11128)
					{
						if (num4 == 11104 || num4 == 11118 || num4 == 11128)
						{
							goto IL_CEF;
						}
					}
					else if (num4 == 11183 || num4 == 11211 || num4 == 11213)
					{
						goto IL_CEF;
					}
					IL_E40:
					num2 = 197;
					continue;
					IL_CEF:
					num2 = 180;
					if (!o0Ooo0_O_3.oo.00O0__o.())
					{
						IL_D01:
						num2 = 181;
						reader.Offset = o0Ooo0_O_3.O.0_O0O.();
						IL_D15:
						num2 = 182;
						int indentAmount = reader.SnapshotLine.IndentAmount;
						IL_D29:
						num2 = 183;
						List<oo0o0O_oO_0_o>.Enumerator enumerator3 = OooOOO_0_O.Oo_O.0_0o0_..GetEnumerator();
						while (enumerator3.MoveNext())
						{
							oo0o0O_oO_0_o oo0o0O_oO_0_o3 = enumerator3.Current;
							IL_D49:
							num2 = 184;
							if (oo0o0O_oO_0_o3.OoOO._Ooo.() > o0Ooo0_O_3.O.0_O0O.() && oo0o0O_oO_0_o3.O.OoO00O.() == o0Ooo0_O_3.oo.00O0__o.())
							{
								IL_D75:
								num2 = 185;
								reader.Offset = oo0o0O_oO_0_o3.OoOO._Ooo.();
								IL_D89:
								num2 = 186;
								int indentAmount2 = reader.SnapshotLine.IndentAmount;
								IL_D9D:
								num2 = 187;
								reader.Offset = oo0o0O_oO_0_o3.O0o_0o0O.0_O.();
								IL_DB1:
								num2 = 188;
								int indentAmount3 = reader.SnapshotLine.IndentAmount;
								IL_DC5:
								num2 = 189;
								if (indentAmount2 != indentAmount3 && indentAmount == indentAmount3)
								{
									IL_DD7:
									num2 = 190;
									oo0o0O_oO_0_o3.oOO.000o____0.(o0Ooo0_O_3.O.0_O0O.());
									IL_DEB:
									num2 = 191;
									oo0o0O_oO_0_o3.oOo.OooOO0.().oOo.OooOO0.(false);
									IL_DFE:
									num2 = 192;
									oo0o0O_oO_0_o3.O.OoO00O.(o0Ooo0_O_3);
									IL_E0D:
									num2 = 193;
									o0Ooo0_O_3.oOo.OooOO0.(true);
								}
							}
							IL_E1B:
							num2 = 194;
						}
						IL_E2D:
						num2 = 195;
						((IDisposable)enumerator3).Dispose();
						goto IL_E40;
					}
					goto IL_E40;
				}
				IL_E52:
				num2 = 198;
				((IDisposable)enumerator2).Dispose();
				IL_E65:
				goto IL_11D3;
				IL_E6A:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_1194:
				goto IL_11C8;
				IL_1196:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_11A6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1196;
			}
			IL_11C8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_11D3:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0001898C File Offset: 0x00016B8C
		internal void <<EMPTY_NAME>>(ITextSnapshot A_0)
		{
			int[] array = new int[A_0.Lines.Count - 1 + 1];
			try
			{
				foreach (o0Ooo0_O_ o0Ooo0_O_ in OooOOO_0_O.Oo_O.0_0o0_.)
				{
					if (o0Ooo0_O_.oo.00O0__o.() != 11019 && o0Ooo0_O_.oo.00O0__o.() != 11017 && !o0Ooo0_O_.oo.00O0__o.())
					{
						o0Ooo0_O_ o0Ooo0_O_2 = this.Oo_O.0_0o0_.(o0Ooo0_O_);
						int num = A_0.OffsetToPosition(o0Ooo0_O_.O.0_O0O.()).Line + 1;
						int num2 = A_0.Lines.Count - 1;
						if (o0Ooo0_O_2 != null)
						{
							num2 = A_0.OffsetToPosition(o0Ooo0_O_2.O.0_O0O.()).Line - 1;
						}
						int num3 = num2;
						for (int i = num; i <= num3; i++)
						{
							array[i] += 4;
						}
					}
				}
			}
			finally
			{
				List<o0Ooo0_O_>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (oo0o0O_oO_0_o oo0o0O_oO_0_o in OooOOO_0_O.Oo_O.0_0o0_.)
				{
					if (oo0o0O_oO_0_o.O.OoO00O.() != 11019 && oo0o0O_oO_0_o.O.OoO00O.() != 11017)
					{
						int num4 = A_0.OffsetToPosition(oo0o0O_oO_0_o.OoOO._Ooo.()).Line + 1;
						o0Ooo0_O_ o0Ooo0_O_3 = this.Oo_O.0_0o0_.(oo0o0O_oO_0_o.oOo.OooOO0.());
						int num5 = A_0.OffsetToPosition(oo0o0O_oO_0_o.O0o_0o0O.0_O.()).Line;
						if (o0Ooo0_O_3 == null)
						{
							int num6 = oo0o0O_oO_0_o.O.OoO00O.();
							if (num6 - 11074 > 1 && num6 - 11107 > 1 && num6 != 11117)
							{
								num5--;
							}
						}
						else
						{
							num5 = A_0.OffsetToPosition(o0Ooo0_O_3.O.0_O0O.()).Line - 1;
						}
						int num7 = num4;
						int num8 = num5;
						for (int j = num7; j <= num8; j++)
						{
							array[j] += 4;
						}
					}
				}
			}
			finally
			{
				List<oo0o0O_oO_0_o>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			TextChangeOptions textChangeOptions = new TextChangeOptions();
			textChangeOptions.OffsetDelta = TextChangeOffsetDelta.SequentialOnly;
			textChangeOptions.RetainSelection = true;
			ITextChange textChange = A_0.CreateTextChange(TextChangeTypes.AutoFormat, textChangeOptions);
			int num9 = A_0.Lines.Count - 1;
			for (int k = 0; k <= num9; k++)
			{
				ITextSnapshotLine textSnapshotLine = A_0.Lines[k];
				if (textSnapshotLine.IndentAmount != array[k])
				{
					int firstNonWhitespaceCharacterOffset = textSnapshotLine.FirstNonWhitespaceCharacterOffset;
					textChange.ReplaceText(new TextRange(textSnapshotLine.StartOffset, firstNonWhitespaceCharacterOffset), new string(' ', array[k]));
				}
			}
			textChange.Apply();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00018C28 File Offset: 0x00016E28
		private o0Ooo0_O_ <<EMPTY_NAME>>(o0Ooo0_O_ A_0)
		{
			int num = OooOOO_0_O.Oo_O.0_0o0_..Count - 1;
			for (int i = 0; i <= num; i++)
			{
				o0Ooo0_O_ o0Ooo0_O_ = OooOOO_0_O.Oo_O.0_0o0_.[i];
				if (o0Ooo0_O_.oo.00O0__o.() == A_0)
				{
					int num2 = A_0.oo.00O0__o.();
					o0Ooo0_O_ result;
					if (num2 != 11128)
					{
						if (num2 != 11200)
						{
							goto IL_71;
						}
						if (o0Ooo0_O_.oo.00O0__o.() != 11075)
						{
							goto IL_71;
						}
						result = o0Ooo0_O_;
					}
					else
					{
						if (o0Ooo0_O_.oo.00O0__o.() != 11107 && o0Ooo0_O_.oo.00O0__o.() != 11108)
						{
							goto IL_71;
						}
						result = o0Ooo0_O_;
					}
					return result;
				}
				IL_71:;
			}
			return null;
		}

		// Token: 0x04000104 RID: 260
		private static OutliningNodeDefinition <<EMPTY_NAME>>;

		// Token: 0x04000105 RID: 261
		private static Regex <<EMPTY_NAME>> = new Regex("[\\s]+", RegexOptions.Compiled);

		// Token: 0x04000106 RID: 262
		private static Dictionary<int, string> <<EMPTY_NAME>> = new Dictionary<int, string>();

		// Token: 0x04000107 RID: 263
		private static List<o0Ooo0_O_> <<EMPTY_NAME>> = new List<o0Ooo0_O_>();

		// Token: 0x04000108 RID: 264
		private static List<oo0o0O_oO_0_o> <<EMPTY_NAME>> = new List<oo0o0O_oO_0_o>();
	}
}
