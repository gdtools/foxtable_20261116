using System;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.Text.Lexing;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200006A RID: 106
	internal class o_oO : VBAutoCaseCorrector
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x00013CCC File Offset: 0x00011ECC
		public override void AutoCorrect(TextSnapshotRange snapshotRange)
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
				ITextSnapshotReader reader = snapshotRange.Snapshot.GetReader(snapshotRange.StartOffset);
				IL_1D:
				num2 = 3;
				TextChangeOptions textChangeOptions = new TextChangeOptions();
				IL_26:
				num2 = 4;
				textChangeOptions.OffsetDelta = TextChangeOffsetDelta.SequentialOnly;
				IL_30:
				num2 = 5;
				textChangeOptions.RetainSelection = true;
				IL_3A:
				num2 = 6;
				ITextChange textChange = snapshotRange.Snapshot.CreateTextChange(TextChangeTypes.AutoCorrect, textChangeOptions);
				IL_51:
				num2 = 7;
				IToken token = null;
				IL_56:
				num2 = 8;
				IToken token2 = null;
				IL_5B:
				num2 = 9;
				IToken token3 = null;
				bool flag;
				for (;;)
				{
					IL_4DF:
					num2 = 11;
					if (reader.Offset >= snapshotRange.EndOffset)
					{
						break;
					}
					IL_66:
					num2 = 12;
					if (reader.IsAtSnapshotLineEnd)
					{
						IL_74:
						num2 = 13;
						if (token2 != null && token3 != null && (token2.Id == 11128 || token2.Id == 11108) && !flag)
						{
							IL_A5:
							num2 = 14;
							if (!O_ooO0.O__o.O000.(token3))
							{
								IL_B1:
								num2 = 15;
								int num3 = token3.EndOffset;
								IL_BD:
								num2 = 16;
								string substring = reader.Snapshot.GetSubstring(token3.EndOffset, reader.SnapshotLine.EndOffset - token3.EndOffset);
								IL_E7:
								num2 = 17;
								if (Operators.CompareString(substring.Trim(), "", true) > 0)
								{
									IL_FF:
									num2 = 18;
									num3++;
								}
								IL_108:
								num2 = 19;
								textChange.InsertText(num3, " Then");
							}
						}
						IL_119:
						num2 = 20;
						token2 = null;
						IL_11F:
						num2 = 21;
						token3 = null;
						IL_125:
						num2 = 22;
						flag = false;
					}
					IL_12B:
					num2 = 23;
					bool isAtSnapshotLineStart = reader.IsAtSnapshotLineStart;
					IL_136:
					num2 = 24;
					token = reader.ReadToken();
					IL_141:
					num2 = 25;
					if (token == null)
					{
						break;
					}
					IL_14B:
					num2 = 27;
					if (VBTokenId.IsOperatorClassificationType(token.Id))
					{
						IL_15F:
						num2 = 28;
						if (token.Id == 11219 || token.Id == 11220)
						{
							IL_17E:
							num2 = 29;
							if (token3 != null && VBTokenId.IsOperatorClassificationType(token3.Id))
							{
								continue;
							}
						}
						IL_196:
						num2 = 31;
						int offset = reader.Offset;
						IL_1A1:
						num2 = 32;
						reader.Offset = token.StartOffset;
						IL_1B1:
						num2 = 33;
						IToken token4 = reader.PeekTokenReverse();
						IL_1BC:
						num2 = 34;
						if (token4 != null && token4.Id != 11000)
						{
							IL_1D1:
							num2 = 35;
							textChange.InsertText(token.StartOffset, " ");
						}
						IL_1E7:
						num2 = 36;
						reader.Offset = token.EndOffset;
						IL_1F7:
						num2 = 37;
						token4 = reader.PeekToken();
						IL_202:
						num2 = 38;
						if (token4 != null && token4.Id != 11000)
						{
							IL_217:
							num2 = 39;
							textChange.InsertText(token.EndOffset, " ");
						}
						IL_22D:
						num2 = 40;
						reader.Offset = offset;
					}
					else
					{
						IL_23D:
						num2 = 42;
						if (token.Id == 11009)
						{
							IL_24E:
							num2 = 43;
							int offset2 = reader.Offset;
							IL_259:
							num2 = 44;
							IToken token5 = reader.PeekToken();
							IL_264:
							num2 = 45;
							if (token5 != null && token5.Id != 11000)
							{
								IL_279:
								num2 = 46;
								textChange.InsertText(token.EndOffset, " ");
							}
							IL_28F:
							num2 = 47;
							reader.Offset = offset2;
						}
						else
						{
							IL_29F:
							num2 = 49;
							if (token.Id == 11000 && !isAtSnapshotLineStart)
							{
								IL_2BA:
								num2 = 50;
								if (token.EndOffset == reader.SnapshotLine.EndOffset)
								{
									IL_2D1:
									num2 = 51;
									textChange.ReplaceText(token.TextRange, " ");
								}
								else
								{
									IL_2EC:
									num2 = 53;
									IToken token6 = reader.PeekToken();
									IL_2F7:
									num2 = 54;
									if (token6 != null && token6.Id == 11010)
									{
										IL_312:
										num2 = 55;
										reader.Offset = token.StartOffset;
										IL_322:
										num2 = 56;
										IToken token7 = reader.PeekTokenReverse();
										IL_32D:
										num2 = 57;
										reader.Offset = token.EndOffset;
										IL_33D:
										num2 = 58;
										if (token7 != null && (VBTokenId.IsKeywordClassificationType(token7.Id) || VBTokenId.IsOperatorClassificationType(token7.Id)))
										{
											IL_360:
											num2 = 59;
											textChange.ReplaceText(token.TextRange, " ");
										}
										else
										{
											IL_37B:
											num2 = 61;
											textChange.ReplaceText(token.TextRange, "");
										}
									}
									else
									{
										IL_396:
										num2 = 63;
										if (token6 != null && token6.Id == 11004)
										{
											IL_3AB:
											num2 = 64;
											textChange.ReplaceText(token.TextRange, "");
										}
										else
										{
											IL_3C3:
											num2 = 66;
											reader.Offset = token.StartOffset;
											IL_3D3:
											num2 = 67;
											token6 = reader.PeekTokenReverse();
											IL_3DE:
											num2 = 68;
											reader.Offset = token.EndOffset;
											IL_3EE:
											num2 = 69;
											if (token6 != null && token6.Id == 11010)
											{
												IL_403:
												num2 = 70;
												textChange.ReplaceText(token.TextRange, "");
											}
											else
											{
												IL_41B:
												num2 = 72;
												if (token.Length > 1)
												{
													IL_428:
													num2 = 73;
													textChange.ReplaceText(token.TextRange, " ");
												}
											}
										}
									}
								}
							}
						}
					}
					IL_43E:
					num2 = 74;
					if (token2 == null && token.Id != 11000 && token.Id != 11001)
					{
						IL_461:
						num2 = 75;
						token2 = token;
					}
					else
					{
						IL_46A:
						num2 = 77;
						if (token.Id == 11196)
						{
							IL_47B:
							num2 = 78;
							flag = true;
						}
						IL_481:
						num2 = 79;
						if (token.Id != 11000 && token.Id != 11001 && token.Id != 11017 && token.Id != 11019 && token.Id != 11021 && token.Id != 11020)
						{
							IL_4D8:
							num2 = 80;
							token3 = token;
						}
					}
				}
				IL_4F4:
				num2 = 82;
				if (token2 == null || token3 == null || (token2.Id != 11128 && token2.Id != 11108) || flag)
				{
					goto IL_5CA;
				}
				IL_52B:
				num2 = 83;
				if (O_ooO0.O__o.O000.(token3))
				{
					goto IL_5CA;
				}
				IL_53A:
				num2 = 84;
				if (snapshotRange.Text.Trim().EndsWith(" then", StringComparison.OrdinalIgnoreCase))
				{
					goto IL_5CA;
				}
				IL_556:
				num2 = 86;
				int num4 = Math.Min(token3.EndOffset, snapshotRange.EndOffset);
				IL_56E:
				num2 = 87;
				string substring2 = reader.Snapshot.GetSubstring(token3.EndOffset, reader.SnapshotLine.EndOffset - token3.EndOffset);
				IL_598:
				num2 = 88;
				if (Operators.CompareString(substring2.Trim(), "", true) <= 0)
				{
					goto IL_5B9;
				}
				IL_5B0:
				num2 = 89;
				num4++;
				IL_5B9:
				num2 = 90;
				textChange.InsertText(num4, " Then");
				IL_5CA:
				num2 = 91;
				if (textChange.Operations.Count <= 0)
				{
					goto IL_5E7;
				}
				IL_5DC:
				num2 = 92;
				textChange.Apply();
				IL_5E7:
				num2 = 93;
				base.AutoCorrect(snapshotRange);
				IL_5F1:
				goto IL_7BB;
				IL_5F6:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_77C:
				goto IL_7B0;
				IL_77E:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_78E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_77E;
			}
			IL_7B0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7BB:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000144B8 File Offset: 0x000126B8
		protected virtual string <<EMPTY_NAME>>(ITextSnapshot A_0, IToken A_1)
		{
			if (A_1.Id == 11033)
			{
				string text = new TextSnapshotRange(A_0, A_1.TextRange).Text;
				if (Operators.CompareString(text, "table", true) == 0)
				{
					return "Table";
				}
				if (Operators.CompareString(text, "row", true) == 0)
				{
					return "Row";
				}
				if (Operators.CompareString(text, "col", true) == 0)
				{
					return "Col";
				}
				if (Operators.CompareString(text, "tables", true) == 0)
				{
					return "Tables";
				}
				if (Operators.CompareString(text, "datatable", true) == 0)
				{
					return "DataTable";
				}
				if (Operators.CompareString(text, "datacol", true) == 0)
				{
					return "DataCol";
				}
				if (Operators.CompareString(text, "datarow", true) == 0)
				{
					return "DataRow";
				}
				if (Operators.CompareString(text, "datatables", true) == 0)
				{
					return "DataTables";
				}
				if (Operators.CompareString(text, "endif", true) == 0)
				{
					return "End If";
				}
			}
			else if (A_1.Id == 11110)
			{
				return "End if";
			}
			return base.GetCaseCorrectText(A_0, A_1);
		}
	}
}
