using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Languages.DotNet;
using ActiproSoftware.Text.Languages.DotNet.Reflection;
using ActiproSoftware.Text.Languages.DotNet.Resolution;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.IntelliPrompt.Implementation;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200006B RID: 107
	internal class oO0O_oO_0O_ : VBCompletionProvider
	{
		// Token: 0x060003F4 RID: 1012 RVA: 0x000145DB File Offset: 0x000127DB
		[CompilerGenerated]
		internal static CompletionSession <<EMPTY_NAME>>()
		{
			return oO0O_oO_0O_.o_0.O0__OO.;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000145E4 File Offset: 0x000127E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal static void <<EMPTY_NAME>>(CompletionSession A_0)
		{
			EventHandler value = new EventHandler(oO0O_oO_0O_.o_0.O0__OO.);
			EventHandler<CancelEventArgs> value2 = new EventHandler<CancelEventArgs>(oO0O_oO_0O_.o_0.O0__OO.);
			CompletionSession completionSession = oO0O_oO_0O_.o_0.O0__OO.;
			if (completionSession != null)
			{
				completionSession.Committed -= value;
				completionSession.Closed -= value2;
			}
			oO0O_oO_0O_.o_0.O0__OO. = A_0;
			completionSession = oO0O_oO_0O_.o_0.O0__OO.;
			if (completionSession != null)
			{
				completionSession.Committed += value;
				completionSession.Closed += value2;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00014640 File Offset: 0x00012840
		static oO0O_oO_0O_()
		{
			int a_ = 19;
			oO0O_oO_0O_.o_0.O0__OO.(new CompletionSession());
			oO0O_oO_0O_.OoOo.0oo. = new Dictionary<string, CompletionItem>();
			oO0O_oO_0O_.o0_o0O.0. = new Dictionary<string, CompletionItem>();
			oO0O_oO_0O_.o0_o0O.0. = O00OOOo_O0_O.b("쟵", a_);
			oO0O_oO_0O_.o_0.O0__OO.().CanCommitWithoutPopup = false;
			oO0O_oO_0O_.o_0.O0__OO.().MatchOptions = (CompletionMatchOptions.TargetsDisplayText | CompletionMatchOptions.UseAcronyms | CompletionMatchOptions.UseShorthand);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000146A0 File Offset: 0x000128A0
		public oO0O_oO_0O_()
		{
			int a_ = 8;
			base..ctor();
			string text = O00OOOo_O0_O.b("\udbea", a_);
			try
			{
				foreach (Foxtable.WinForm.Form form in OO_00oOO.Forms)
				{
					text = (Conversions.ToInteger(text) + Conversions.ToInteger(oO0O_oO_0O_.o0_o0O.0.)).ToString();
				}
			}
			finally
			{
				IEnumerator<Foxtable.WinForm.Form> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			oO0O_oO_0O_.OoOo.0oo. = text;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00014724 File Offset: 0x00012924
		protected override bool OnSessionOpening(ICompletionSession session)
		{
			int num;
			bool result;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				IDotNetContext dotNetContext = (IDotNetContext)session.Context;
				IL_16:
				num2 = 3;
				if (!(session is CompletionSession))
				{
					goto IL_42;
				}
				IL_20:
				num2 = 4;
				CompletionSession completionSession = (CompletionSession)session;
				IL_2A:
				num2 = 5;
				completionSession.CanCommitWithoutPopup = false;
				IL_34:
				num2 = 6;
				completionSession.MatchOptions = (CompletionMatchOptions.TargetsDisplayText | CompletionMatchOptions.UseAcronyms | CompletionMatchOptions.UseShorthand);
				IL_3F:
				completionSession = null;
				IL_42:
				num2 = 8;
				if (dotNetContext.TargetExpression != null || dotNetContext.TargetSnapshotOffset == null)
				{
					goto IL_11E;
				}
				IL_65:
				num2 = 9;
				ITextSnapshotReader reader = dotNetContext.TargetSnapshotOffset.Value.Snapshot.GetReader(dotNetContext.TargetSnapshotOffset.Value.Offset);
				IToken token;
				do
				{
					IL_112:
					num2 = 11;
					if (reader.IsAtSnapshotLineStart)
					{
						goto IL_11E;
					}
					IL_A3:
					num2 = 12;
					token = reader.ReadTokenReverse();
					IL_AF:
					num2 = 13;
					if (token == null)
					{
						goto IL_11E;
					}
					IL_B6:
					num2 = 15;
					if (token.Id != 11000)
					{
						IL_C7:
						num2 = 16;
					}
					IL_CA:
					num2 = 17;
					if (token.Id == 11068 || token.Id == 11131)
					{
						goto IL_11E;
					}
					IL_E9:
					num2 = 20;
				}
				while (token.Id != 11118 && token.Id != 11183);
				IL_108:
				num2 = 21;
				result = false;
				goto IL_12A7;
				IL_11E:
				num2 = 23;
				if (dotNetContext.TargetExpression != null)
				{
					goto IL_912;
				}
				IL_12D:
				num2 = 24;
				for (int i = session.Items.Count - 1; i >= 0; i += -1)
				{
					IL_144:
					num2 = 25;
					object objectValue = RuntimeHelpers.GetObjectValue(session.Items[i].Tag);
					IL_160:
					num2 = 26;
					string autoCompletePreText = session.Items[i].AutoCompletePreText;
					IL_177:
					num2 = 27;
					string left = autoCompletePreText;
					IL_17E:
					num2 = 29;
					if (Operators.CompareString(left, "MSExcel", true) != 0 && Operators.CompareString(left, "MSWord", true) != 0 && Operators.CompareString(left, "prt", true) != 0 && Operators.CompareString(left, "Word", true) != 0 && Operators.CompareString(left, "Point", true) != 0 && Operators.CompareString(left, "RectangleF", true) != 0 && Operators.CompareString(left, "RectangleF", true) != 0 && Operators.CompareString(left, "StringFormat", true) != 0 && Operators.CompareString(left, "StringFormatFlags", true) != 0 && Operators.CompareString(left, "ExpandoObject", true) != 0 && Operators.CompareString(left, "Pen", true) != 0 && Operators.CompareString(left, "Brushs", true) != 0 && Operators.CompareString(left, "Brush", true) != 0 && Operators.CompareString(left, "Pens", true) != 0 && Operators.CompareString(left, "Brushs", true) != 0 && Operators.CompareString(left, "SizeF", true) != 0 && Operators.CompareString(left, "Size", true) != 0 && Operators.CompareString(left, "PointF", true) != 0 && Operators.CompareString(left, "PDF", true) != 0 && Operators.CompareString(left, "X509Certificate2", true) != 0 && Operators.CompareString(left, "PDFActions", true) != 0 && Operators.CompareString(left, "Uri", true) != 0)
					{
						IL_30D:
						num2 = 31;
						if (Operators.CompareString(autoCompletePreText, "OO_00oOO", true) == 0)
						{
							IL_31F:
							num2 = 32;
							if (i < 0 || i > session.Items.Count - 1)
							{
								break;
							}
							IL_33E:
							num2 = 33;
							session.Items.RemoveAt(i);
						}
						else
						{
							IL_353:
							num2 = 38;
							if (Operators.CompareString(autoCompletePreText, "Me", true) == 0)
							{
								IL_368:
								num2 = 39;
								IEnumerator enumerator = Application.OpenForms.GetEnumerator();
								bool flag;
								while (enumerator.MoveNext())
								{
									object obj = enumerator.Current;
									System.Windows.Forms.Form form = (System.Windows.Forms.Form)obj;
									IL_387:
									num2 = 40;
									if (form is O\u3002\u30000)
									{
										IL_393:
										num2 = 41;
										flag = true;
										break;
									}
									IL_39B:
									num2 = 43;
								}
								IL_3A7:
								num2 = 44;
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
								IL_3BF:
								num2 = 45;
								if (!flag)
								{
									IL_3C6:
									num2 = 46;
									if (i >= 0 && i <= session.Items.Count - 1)
									{
										IL_3E5:
										num2 = 47;
										session.Items.RemoveAt(i);
										goto IL_89C;
									}
									break;
								}
							}
							else
							{
								IL_3FA:
								num2 = 52;
								if (Operators.CompareString(autoCompletePreText, "System", true) == 0)
								{
									goto IL_89C;
								}
								IL_40F:
								num2 = 55;
								if (autoCompletePreText.StartsWith("Gauge", StringComparison.OrdinalIgnoreCase))
								{
									goto IL_89C;
								}
							}
							IL_424:
							num2 = 57;
							string left2 = autoCompletePreText;
							IL_42B:
							num2 = 59;
							if (Operators.CompareString(left2, "SingleMark", true) != 0 && Operators.CompareString(left2, "SingleLabel", true) != 0 && Operators.CompareString(left2, "LinearGauge", true) != 0 && Operators.CompareString(left2, "RadialGauge", true) != 0 && Operators.CompareString(left2, "Gantt", true) != 0 && Operators.CompareString(left2, "GanttView", true) != 0 && Operators.CompareString(left2, "Else", true) != 0 && Operators.CompareString(left2, "Color", true) != 0 && Operators.CompareString(left2, "SystemColors", true) != 0 && Operators.CompareString(left2, "isNumeric", true) != 0)
							{
								IL_4E2:
								num2 = 62;
								if (Operators.CompareString(left2, "VectorPlacemark", true) != 0 && Operators.CompareString(left2, "VectorPolyline", true) != 0 && Operators.CompareString(left2, "VectorLayer", true) != 0 && Operators.CompareString(left2, "VectorPolygon", true) != 0 && Operators.CompareString(left2, "VectorItem", true) != 0 && Operators.CompareString(left2, "GeoPoint", true) != 0 && Operators.CompareString(left2, "LOD", true) != 0 && Operators.CompareString(left2, "VirtualLayer", true) != 0 && Operators.CompareString(left2, "MapLegend", true) != 0 && Operators.CompareString(left2, "MapLegendItem", true) != 0)
								{
									IL_599:
									num2 = 64;
									if (this.OoOo.0oo.)
									{
										IL_5A7:
										num2 = 65;
										if (objectValue != null && objectValue is ITypeResolverResult)
										{
											IL_5BD:
											num2 = 66;
											ITypeResolverResult typeResolverResult = (ITypeResolverResult)session.Items[i].Tag;
											IL_5D9:
											num2 = 67;
											if (typeResolverResult.Type != null)
											{
												IL_5E8:
												num2 = 68;
												if (!typeResolverResult.Type.AssemblyName.Name.StartsWith("Foxtable") && !this.OoOo.0oo..Contains(autoCompletePreText) && !this.o_0.O0__OO..Contains(autoCompletePreText))
												{
													IL_626:
													num2 = 69;
													if (i < 0 || i > session.Items.Count - 1)
													{
														break;
													}
													IL_645:
													num2 = 70;
													session.Items.RemoveAt(i);
												}
												else
												{
													IL_65A:
													num2 = 74;
													if (typeResolverResult.Name.EndsWith("Attribute") || typeResolverResult.Name.EndsWith("Enum"))
													{
														IL_686:
														num2 = 75;
														if (i < 0 || i > session.Items.Count - 1)
														{
															break;
														}
														IL_6A5:
														num2 = 76;
														session.Items.RemoveAt(i);
													}
												}
											}
										}
										else
										{
											IL_6BA:
											num2 = 80;
											if (objectValue != null && objectValue is INamespaceResolverResult)
											{
												IL_6CA:
												num2 = 81;
												INamespaceResolverResult namespaceResolverResult = (INamespaceResolverResult)session.Items[i].Tag;
												IL_6E6:
												num2 = 82;
												if (!namespaceResolverResult.FullName.StartsWith("Foxtable"))
												{
													IL_6FF:
													num2 = 83;
													if (i < 0 || i > session.Items.Count - 1)
													{
														break;
													}
													IL_71E:
													num2 = 84;
													session.Items.RemoveAt(i);
												}
											}
											else
											{
												IL_733:
												num2 = 88;
												if (objectValue != null && objectValue is ITypeMemberResolverResult)
												{
													IL_749:
													num2 = 89;
													string fullName = ((ITypeMemberResolverResult)session.Items[i].Tag).Member.DeclaringType.FullName;
													IL_774:
													num2 = 90;
													if (fullName.StartsWith("Microsoft.VisualBasic"))
													{
														IL_788:
														num2 = 91;
														if (!fullName.EndsWith(".Strings"))
														{
															IL_799:
															num2 = 92;
															if (i < 0 || i > session.Items.Count - 1)
															{
																break;
															}
															IL_7B8:
															num2 = 93;
															string left3 = autoCompletePreText;
															IL_7BF:
															num2 = 95;
															if (Operators.CompareString(left3, "vbcr", true) != 0 && Operators.CompareString(left3, "vblf", true) != 0 && Operators.CompareString(left3, "vbcrlf", true) != 0)
															{
																IL_7F8:
																num2 = 97;
																session.Items.RemoveAt(i);
															}
														}
														else
														{
															IL_80D:
															num2 = 101;
															if (autoCompletePreText.StartsWith("Format") && autoCompletePreText.Length != 6)
															{
																IL_828:
																num2 = 102;
																if (i < 0 || i > session.Items.Count - 1)
																{
																	break;
																}
																IL_841:
																num2 = 103;
																session.Items.RemoveAt(i);
															}
														}
													}
													else
													{
														IL_853:
														num2 = 107;
														if (!fullName.StartsWith("Foxtable") && Operators.CompareString(fullName, "UserCode", true) != 0)
														{
															IL_873:
															num2 = 108;
															if (i < 0 || i > session.Items.Count - 1)
															{
																break;
															}
															IL_88C:
															num2 = 109;
															session.Items.RemoveAt(i);
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					IL_89C:
					num2 = 112;
				}
				IL_8AD:
				num2 = 113;
				if (this.o_OO000.o_0oO. == null)
				{
					goto IL_FF6;
				}
				IL_8BB:
				num2 = 114;
				List<string>.Enumerator enumerator2 = this.o_OO000.o_0oO..GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string text = enumerator2.Current;
					IL_8D6:
					num2 = 115;
					session.Items.Add(new CompletionItem(text, new CommonImageSourceProvider(CommonImageKind.ClassPublic)));
					IL_8F1:
					num2 = 116;
				}
				IL_8FD:
				num2 = 117;
				((IDisposable)enumerator2).Dispose();
				goto IL_FF6;
				IL_912:
				num2 = 119;
				if (dotNetContext.TargetExpression == null || !this.OoOo.0oo.)
				{
					goto IL_FF6;
				}
				IL_92C:
				num2 = 120;
				if (Operators.CompareString(dotNetContext.TargetExpression.Value, "SimpleName: \"prt\"", true) != 0)
				{
					goto IL_A85;
				}
				IL_94B:
				num2 = 121;
				if (dotNetContext.TargetSnapshotOffset == null)
				{
					goto IL_FF6;
				}
				IL_963:
				num2 = 122;
				ITextSnapshotReader reader2 = dotNetContext.TargetSnapshotOffset.Value.Snapshot.GetReader(dotNetContext.TargetSnapshotOffset.Value.Offset);
				IToken token2;
				do
				{
					IL_9CA:
					num2 = 124;
					if (reader2.IsAtSnapshotLineStart)
					{
						goto IL_9D6;
					}
					IL_9A1:
					num2 = 125;
					token2 = reader2.ReadTokenReverse();
					IL_9AD:
					num2 = 126;
				}
				while (token2 == null || token2.Id != 11068);
				IL_9C2:
				num2 = 127;
				bool flag2 = true;
				IL_9D6:
				num2 = 130;
				if (!flag2)
				{
					goto IL_FF6;
				}
				IL_9E3:
				num2 = 131;
				for (int j = session.Items.Count - 1; j >= 0; j += -1)
				{
					IL_9FA:
					num2 = 132;
					string autoCompletePreText2 = session.Items[j].AutoCompletePreText;
					IL_A14:
					num2 = 133;
					if (!autoCompletePreText2.StartsWith("Render") && Operators.CompareString(autoCompletePreText2, "DataBinding", true) != 0)
					{
						IL_A37:
						num2 = 134;
						if (j < 0 || j > session.Items.Count - 1)
						{
							break;
						}
						IL_A59:
						num2 = 135;
						session.Items.RemoveAt(j);
					}
					IL_A6C:
					num2 = 138;
				}
				goto IL_FF6;
				IL_A85:
				num2 = 140;
				for (int k = session.Items.Count - 1; k >= 0; k += -1)
				{
					IL_A9F:
					num2 = 141;
					string autoCompletePreText3 = session.Items[k].AutoCompletePreText;
					IL_AB9:
					num2 = 142;
					if (session.Items[k].Tag is ITypeMemberResolverResult)
					{
						IL_ADB:
						num2 = 143;
						ITypeMemberResolverResult typeMemberResolverResult = (ITypeMemberResolverResult)session.Items[k].Tag;
						IL_AFA:
						num2 = 144;
						string fullName2 = typeMemberResolverResult.Member.DeclaringType.FullName;
						IL_B13:
						num2 = 145;
						if (fullName2.StartsWith("System.Linq"))
						{
							IL_B27:
							num2 = 146;
							if (k < 0 || k > session.Items.Count - 1)
							{
								break;
							}
							IL_B49:
							num2 = 147;
							session.Items.RemoveAt(k);
						}
						else
						{
							IL_B61:
							num2 = 151;
							if (Operators.CompareString(fullName2, "System.String", true) == 0 && k == 0)
							{
								IL_B7A:
								num2 = 152;
								CompletionItem completionItem = new CompletionItem("CompareTo", new CommonImageSourceProvider(CommonImageKind.FieldPublic));
								IL_B93:
								num2 = 153;
								completionItem.DescriptionProvider = new PlainTextContentProvider("和另一个字符串进行比较，可区分大小写");
								IL_BAA:
								num2 = 154;
								session.Items.Add(completionItem);
							}
							IL_BBD:
							num2 = 155;
							string left4 = autoCompletePreText3;
							IL_BC7:
							num2 = 157;
							if (Operators.CompareString(left4, "CompareTo", true) == 0 || Operators.CompareString(left4, "Equals", true) == 0 || Operators.CompareString(left4, "GetHashCode", true) == 0 || Operators.CompareString(left4, "GetTypeCode", true) == 0 || Operators.CompareString(left4, "GetType", true) == 0)
							{
								IL_C18:
								num2 = 158;
								if (k < 0 || k > session.Items.Count - 1)
								{
									break;
								}
								IL_C3A:
								num2 = 159;
								session.Items.RemoveAt(k);
							}
							else
							{
								IL_C52:
								num2 = 163;
								string left5 = fullName2;
								IL_C5C:
								num2 = 165;
								if (Operators.CompareString(left5, "System.Collections.Generic.List`1", true) == 0)
								{
									IL_C74:
									num2 = 166;
									string left6 = autoCompletePreText3;
									IL_C7E:
									num2 = 168;
									if (Operators.CompareString(left6, "Add", true) != 0 && Operators.CompareString(left6, "AddRange", true) != 0 && Operators.CompareString(left6, "Clear", true) != 0 && Operators.CompareString(left6, "Contains", true) != 0 && Operators.CompareString(left6, "Count", true) != 0 && Operators.CompareString(left6, "IndexOf", true) != 0 && Operators.CompareString(left6, "Insert", true) != 0 && Operators.CompareString(left6, "InsertRange", true) != 0 && Operators.CompareString(left6, "LastIndexOf", true) != 0 && Operators.CompareString(left6, "Remove", true) != 0 && Operators.CompareString(left6, "RemoveAt", true) != 0 && Operators.CompareString(left6, "RemoveRange", true) != 0 && Operators.CompareString(left6, "Sort", true) != 0 && Operators.CompareString(left6, "Reverse", true) != 0 && Operators.CompareString(left6, "ToArray", true) != 0)
									{
										IL_D92:
										num2 = 170;
										if (k < 0 || k > session.Items.Count - 1)
										{
											break;
										}
										IL_DB4:
										num2 = 171;
										session.Items.RemoveAt(k);
									}
								}
								else
								{
									IL_DCC:
									num2 = 175;
									if (Operators.CompareString(left5, "System.Collections.Generic.Dictionary`2", true) == 0)
									{
										IL_DE4:
										num2 = 176;
										string left7 = autoCompletePreText3;
										IL_DEE:
										num2 = 178;
										if (Operators.CompareString(left7, "Add", true) != 0 && Operators.CompareString(left7, "Clear", true) != 0 && Operators.CompareString(left7, "ContainsKey", true) != 0 && Operators.CompareString(left7, "ContainsValue", true) != 0 && Operators.CompareString(left7, "Count", true) != 0 && Operators.CompareString(left7, "Keys", true) != 0 && Operators.CompareString(left7, "Remove", true) != 0 && Operators.CompareString(left7, "TryGetValue", true) != 0 && Operators.CompareString(left7, "Values", true) != 0)
										{
											IL_E96:
											num2 = 180;
											if (k < 0 || k > session.Items.Count - 1)
											{
												break;
											}
											IL_EB8:
											num2 = 181;
											session.Items.RemoveAt(k);
										}
									}
									else
									{
										IL_ED0:
										num2 = 185;
										if (Operators.CompareString(left5, "System.Array", true) == 0)
										{
											IL_EE8:
											num2 = 186;
											string left8 = autoCompletePreText3;
											IL_EF2:
											num2 = 188;
											if (Operators.CompareString(left8, "Length", true) != 0 && Operators.CompareString(left8, "IndexOf", true) != 0 && Operators.CompareString(left8, "LastIndexOf", true) != 0 && Operators.CompareString(left8, "Reverse", true) != 0 && Operators.CompareString(left8, "Sort", true) != 0)
											{
												IL_F52:
												num2 = 190;
												if (k < 0 || k > session.Items.Count - 1)
												{
													break;
												}
												IL_F74:
												num2 = 191;
												session.Items.RemoveAt(k);
											}
										}
										else
										{
											IL_F89:
											num2 = 195;
											if (Operators.CompareString(left5, "System.Object", true) == 0)
											{
												IL_F9E:
												num2 = 196;
												if (Operators.CompareString(autoCompletePreText3, "ToString", true) != 0)
												{
													IL_FB3:
													num2 = 197;
													if (k < 0 || k > session.Items.Count - 1)
													{
														break;
													}
													IL_FCF:
													num2 = 198;
													session.Items.RemoveAt(k);
												}
											}
										}
									}
								}
							}
						}
					}
					IL_FE2:
					num2 = 201;
				}
				IL_FF6:
				num2 = 202;
				this.OoOo.0oo. = false;
				IL_1003:
				num2 = 203;
				if (session.Items.Count >= 10)
				{
					goto IL_1025;
				}
				IL_1018:
				num2 = 204;
				result = true;
				goto IL_12A7;
				IL_1025:
				num2 = 206;
				bool flag3 = base.OnSessionOpening(session);
				IL_1034:
				num2 = 207;
				if (!flag3)
				{
					goto IL_129E;
				}
				IL_1041:
				num2 = 208;
				ICompletionItem completionItem2 = null;
				IL_104A:
				num2 = 209;
				ICompletionItem completionItem3 = null;
				IL_1053:
				num2 = 210;
				for (int l = session.Items.Count - 1; l >= 0; l += -1)
				{
					IL_106D:
					num2 = 211;
					string text2 = session.Items[l].Text;
					IL_1087:
					num2 = 212;
					string left9 = text2;
					IL_1091:
					num2 = 214;
					if (Operators.CompareString(left9, "Tables", true) == 0)
					{
						IL_10A6:
						num2 = 215;
						completionItem2 = session.Items[l];
					}
					else
					{
						IL_10C0:
						num2 = 217;
						if (Operators.CompareString(left9, "DataTables", true) == 0)
						{
							IL_10D5:
							num2 = 218;
							completionItem3 = session.Items[l];
						}
						else
						{
							IL_10EF:
							num2 = 220;
							if (Operators.CompareString(left9, "Table", true) == 0 || Operators.CompareString(left9, "DataTable", true) == 0 || Operators.CompareString(left9, "DataRow", true) == 0 || Operators.CompareString(left9, "DataCol", true) == 0 || Operators.CompareString(left9, "DataTableBuilder", true) == 0)
							{
								IL_1140:
								num2 = 221;
								if (completionItem2 != null)
								{
									IL_114A:
									num2 = 222;
									session.Items.RemoveAt(l);
								}
								else
								{
									IL_1162:
									num2 = 224;
									if (Operators.CompareString(text2, "DataCol", true) == 0)
									{
										IL_117A:
										num2 = 225;
										ICompletionItem item = session.Items[l];
										IL_118F:
										num2 = 226;
										session.Items.RemoveAt(l);
										IL_11A2:
										num2 = 227;
										session.Items.Insert(l + 2, item);
									}
								}
							}
							else
							{
								IL_11BE:
								num2 = 229;
								if (Operators.CompareString(left9, "TableCaptionVisible", true) == 0)
								{
									IL_11D3:
									num2 = 230;
									session.Items.Remove(completionItem2);
									IL_11E7:
									num2 = 231;
									session.Items.Insert(l, completionItem2);
								}
								else
								{
									IL_1201:
									num2 = 233;
									if (Operators.CompareString(left9, "DataRowState", true) == 0)
									{
										IL_1216:
										num2 = 234;
										if (completionItem3 != null)
										{
											IL_1220:
											num2 = 235;
											session.Items.Remove(completionItem3);
											IL_1234:
											num2 = 236;
											session.Items.Insert(l, completionItem3);
										}
										else
										{
											IL_124B:
											num2 = 238;
											ICompletionItem item2 = session.Items[l];
											IL_1260:
											num2 = 239;
											session.Items.RemoveAt(l);
											IL_1273:
											num2 = 240;
											session.Items.Insert(l + 2, item2);
										}
									}
								}
							}
						}
					}
					IL_128A:
					num2 = 241;
				}
				IL_129E:
				num2 = 242;
				result = flag3;
				IL_12A7:
				goto IL_16C5;
				IL_12AC:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1686:
				goto IL_16BA;
				IL_1688:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1698:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_1688;
			}
			IL_16BA:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_16C5:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00015E1C File Offset: 0x0001401C
		public virtual bool <<EMPTY_NAME>>(IEditorView A_0, bool A_1)
		{
			if (this.OoOo.0oo. == null)
			{
				this.OoOo.0oo. = ((O_o00o_)A_0.SyntaxEditor).O0_.o0o.;
				this.o_0.O0__OO. = ((O_o00o_)A_0.SyntaxEditor).o.00oO0Oo.;
			}
			this.OoOo.0oo. = A_0.Properties.ContainsKey("OnlyCommonTypes");
			bool result;
			if (!A_0.Properties.ContainsKey("SystemReady"))
			{
				result = false;
			}
			else
			{
				ITextSnapshotReader reader = A_0.GetReader();
				IToken token = reader.ReadTokenReverse();
				if (token != null && token.Id == 11033)
				{
					token = reader.ReadTokenReverse();
				}
				ControlTypeEnum controlTypeEnum = ControlTypeEnum.None;
				RibbonItemTypeEnum ribbonItemTypeEnum = RibbonItemTypeEnum.None;
				int offset = reader.Offset;
				if (!O_ooO0.O__o.O000.(reader, token, ref controlTypeEnum))
				{
					reader.Offset = offset;
					O_ooO0.O__o.O000.(reader, token, ref ribbonItemTypeEnum);
				}
				if (controlTypeEnum != ControlTypeEnum.None)
				{
					if (oO0O_oO_0O_.OoOo.0oo..Count != 0)
					{
						goto IL_30F;
					}
					try
					{
						foreach (IProjectAssemblyReference projectAssemblyReference in A_0.SyntaxEditor.Document.Language.GetService<IProjectAssembly>().AssemblyReferences)
						{
							if (Operators.CompareString(projectAssemblyReference.Assembly.Name, "Foxtable", true) == 0)
							{
								ITypeDefinition typeDefinition = projectAssemblyReference.Assembly.Namespaces["Foxtable.WinForm", true].Types["Control", true];
								Type typeFromHandle = typeof(Foxtable.WinForm.Control);
								try
								{
									foreach (ITypeMemberDefinition typeMemberDefinition in typeDefinition.Members)
									{
										if (typeMemberDefinition.Access == TypeMemberAccess.Public && (typeMemberDefinition.Kind == TypeMemberDefinitionKind.Property || typeMemberDefinition.Kind == TypeMemberDefinitionKind.Method) && !typeMemberDefinition.IsHidden)
										{
											oO0O_oO_0O_.OoOo.0oo.[typeMemberDefinition.Name] = this.o_0.O0__OO.(typeMemberDefinition, typeFromHandle);
										}
									}
									break;
								}
								finally
								{
									IEnumerator<ITypeMemberDefinition> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
							}
						}
						goto IL_30F;
					}
					finally
					{
						IEnumerator<IProjectAssemblyReference> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				if (ribbonItemTypeEnum != RibbonItemTypeEnum.None && oO0O_oO_0O_.o0_o0O.0..Count == 0)
				{
					try
					{
						foreach (IProjectAssemblyReference projectAssemblyReference2 in A_0.SyntaxEditor.Document.Language.GetService<IProjectAssembly>().AssemblyReferences)
						{
							if (Operators.CompareString(projectAssemblyReference2.Assembly.Name, "Foxtable", true) == 0)
							{
								ITypeDefinition typeDefinition2 = projectAssemblyReference2.Assembly.Namespaces["Foxtable.RibbonMenu", true].Types["RibbonItem", true];
								Type typeFromHandle2 = typeof(Foxtable.WinForm.Control);
								try
								{
									foreach (ITypeMemberDefinition typeMemberDefinition2 in typeDefinition2.Members)
									{
										if (typeMemberDefinition2.Access == TypeMemberAccess.Public && (typeMemberDefinition2.Kind == TypeMemberDefinitionKind.Property || typeMemberDefinition2.Kind == TypeMemberDefinitionKind.Method) && !typeMemberDefinition2.IsHidden)
										{
											oO0O_oO_0O_.o0_o0O.0.[typeMemberDefinition2.Name] = this.o_0.O0__OO.(typeMemberDefinition2, typeFromHandle2);
										}
									}
									break;
								}
								finally
								{
									IEnumerator<ITypeMemberDefinition> enumerator4;
									if (enumerator4 != null)
									{
										enumerator4.Dispose();
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator<IProjectAssemblyReference> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
				}
				IL_30F:
				if (controlTypeEnum != ControlTypeEnum.None || ribbonItemTypeEnum != RibbonItemTypeEnum.None)
				{
					oO0O_oO_0O_.o_0.O0__OO.().Items.Clear();
					try
					{
						foreach (IProjectAssemblyReference projectAssemblyReference3 in A_0.SyntaxEditor.Document.Language.GetService<IProjectAssembly>().AssemblyReferences)
						{
							if (Operators.CompareString(projectAssemblyReference3.Assembly.Name, "Foxtable", true) == 0)
							{
								ITypeDefinition typeDefinition3;
								Type type;
								if (controlTypeEnum != ControlTypeEnum.None)
								{
									try
									{
										foreach (CompletionItem item in oO0O_oO_0O_.OoOo.0oo..Values)
										{
											oO0O_oO_0O_.o_0.O0__OO.().Items.Add(item);
										}
									}
									finally
									{
										Dictionary<string, CompletionItem>.ValueCollection.Enumerator enumerator6;
										((IDisposable)enumerator6).Dispose();
									}
									typeDefinition3 = projectAssemblyReference3.Assembly.Namespaces["Foxtable.WinForm", true].Types[controlTypeEnum.ToString(), true];
									type = Assembly.GetExecutingAssembly().GetType("Foxtable.WinForm." + controlTypeEnum.ToString());
								}
								else
								{
									try
									{
										foreach (CompletionItem item2 in oO0O_oO_0O_.o0_o0O.0..Values)
										{
											oO0O_oO_0O_.o_0.O0__OO.().Items.Add(item2);
										}
									}
									finally
									{
										Dictionary<string, CompletionItem>.ValueCollection.Enumerator enumerator7;
										((IDisposable)enumerator7).Dispose();
									}
									typeDefinition3 = projectAssemblyReference3.Assembly.Namespaces["Foxtable.RibbonMenu", true].Types[ribbonItemTypeEnum.ToString(), true];
									type = Assembly.GetExecutingAssembly().GetType("Foxtable.RibbonMenu." + ribbonItemTypeEnum.ToString());
								}
								if (typeDefinition3 == null)
								{
									break;
								}
								try
								{
									foreach (ITypeMemberDefinition typeMemberDefinition3 in typeDefinition3.Members)
									{
										if (!oO0O_oO_0O_.OoOo.0oo..ContainsKey(typeMemberDefinition3.Name) && typeMemberDefinition3.Access == TypeMemberAccess.Public && (typeMemberDefinition3.Kind == TypeMemberDefinitionKind.Property || typeMemberDefinition3.Kind == TypeMemberDefinitionKind.Method) && !typeMemberDefinition3.IsHidden)
										{
											oO0O_oO_0O_.o_0.O0__OO.().Items.Add(this.o_0.O0__OO.(typeMemberDefinition3, type));
										}
									}
									break;
								}
								finally
								{
									IEnumerator<ITypeMemberDefinition> enumerator8;
									if (enumerator8 != null)
									{
										enumerator8.Dispose();
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator<IProjectAssemblyReference> enumerator5;
						if (enumerator5 != null)
						{
							enumerator5.Dispose();
						}
					}
					oO0O_oO_0O_.o_0.O0__OO.().SortItems();
					oO0O_oO_0O_.o_0.O0__OO.().Open(A_0);
					result = true;
				}
				else
				{
					reader = A_0.GetReader();
					oO0O_oO_0O_.o_0.O0__OO.().Items.Clear();
					string left = O_ooO0.o.o__O_.(A_0.GetReader(), oO0O_oO_0O_.o_0.O0__OO.(), A_0);
					if (Operators.CompareString(left, "", true) > 0)
					{
						reader = A_0.GetReader();
						token = reader.ReadToken();
						if (Operators.CompareString(left, "Functions", true) == 0)
						{
							O_ooO0.O._OOo__.(oO0O_oO_0O_.o_0.O0__OO.(), token.Id == 11028);
						}
						else if (Operators.CompareString(left, "Tables", true) == 0)
						{
							try
							{
								foreach (Table table in OO_00oOO.Tables)
								{
									CompletionItem completionItem = new CompletionItem(table.Name, new CommonImageSourceProvider(CommonImageKind.FieldPublic));
									if (token.Id != 11028)
									{
										completionItem.AutoCompletePreText = "\"" + table.Name + "\"";
									}
									oO0O_oO_0O_.o_0.O0__OO.().Items.Add(completionItem);
								}
							}
							finally
							{
								IEnumerator<Table> enumerator9;
								if (enumerator9 != null)
								{
									enumerator9.Dispose();
								}
							}
							this.o_0.O0__OO.(token, true);
						}
						else if (Operators.CompareString(left, "DataTables", true) == 0)
						{
							try
							{
								foreach (DataTable dataTable in OO_00oOO.DataTables)
								{
									CompletionItem completionItem2 = new CompletionItem(dataTable.Name, new CommonImageSourceProvider(CommonImageKind.FieldPublic));
									if (token.Id != 11028)
									{
										completionItem2.AutoCompletePreText = "\"" + dataTable.Name + "\"";
									}
									oO0O_oO_0O_.o_0.O0__OO.().Items.Add(completionItem2);
								}
							}
							finally
							{
								IEnumerator<DataTable> enumerator10;
								if (enumerator10 != null)
								{
									enumerator10.Dispose();
								}
							}
							this.o_0.O0__OO.(token, false);
						}
						else
						{
							if (Operators.CompareString(left, "Forms", true) == 0)
							{
								try
								{
									foreach (object obj in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()].Rows)
									{
										DataRow dataRow = (DataRow)obj;
										if (Conversions.ToInteger(dataRow["Type"]) == 229)
										{
											CompletionItem completionItem3 = new CompletionItem(dataRow["Name"].ToString(), new CommonImageSourceProvider(CommonImageKind.FieldPublic));
											if (token.Id != 11028)
											{
												completionItem3.AutoCompletePreText = "\"" + dataRow["Name"].ToString() + "\"";
											}
											oO0O_oO_0O_.o_0.O0__OO.().Items.Add(completionItem3);
										}
									}
									goto IL_B53;
								}
								finally
								{
									IEnumerator enumerator11;
									if (enumerator11 is IDisposable)
									{
										(enumerator11 as IDisposable).Dispose();
									}
								}
							}
							if (Operators.CompareString(left, "Vars", true) == 0)
							{
								try
								{
									foreach (object obj2 in OO_00oOO.Vars.VariableTable.Columns)
									{
										DataColumn dataColumn = (DataColumn)obj2;
										if (!dataColumn.ColumnName.StartsWith("Sys", StringComparison.OrdinalIgnoreCase))
										{
											CompletionItem completionItem4 = new CompletionItem(dataColumn.ColumnName, new CommonImageSourceProvider(CommonImageKind.FieldPublic));
											if (token.Id != 11028)
											{
												completionItem4.AutoCompletePreText = "\"" + dataColumn.ColumnName + "\"";
											}
											completionItem4.InlineDescription = O_ooO0.O__o.O000.(dataColumn.DataType.Name);
											oO0O_oO_0O_.o_0.O0__OO.().Items.Add(completionItem4);
										}
									}
									goto IL_B53;
								}
								finally
								{
									IEnumerator enumerator12;
									if (enumerator12 is IDisposable)
									{
										(enumerator12 as IDisposable).Dispose();
									}
								}
							}
							if (Operators.CompareString(left, "Strips", true) == 0)
							{
								try
								{
									foreach (object obj3 in Application.OpenForms)
									{
										System.Windows.Forms.Form form = (System.Windows.Forms.Form)obj3;
										if (form is o\u3000\u3002)
										{
											Dictionary<string, ToolStrip> o0__O.Oo0__. = ((o\u3000\u3002)form).o0__O.Oo0__.;
											try
											{
												foreach (string text in o0__O.Oo0__..Keys)
												{
													CompletionItem completionItem5 = new CompletionItem(text, new CommonImageSourceProvider(CommonImageKind.FieldPublic));
													if (token.Id != 11028)
													{
														completionItem5.AutoCompletePreText = "\"" + text + "\"";
													}
													oO0O_oO_0O_.o_0.O0__OO.().Items.Add(completionItem5);
												}
											}
											finally
											{
												Dictionary<string, ToolStrip>.KeyCollection.Enumerator enumerator14;
												((IDisposable)enumerator14).Dispose();
											}
										}
									}
									goto IL_B53;
								}
								finally
								{
									IEnumerator enumerator13;
									if (enumerator13 is IDisposable)
									{
										(enumerator13 as IDisposable).Dispose();
									}
								}
							}
							if (Operators.CompareString(left, "MyTimers", true) == 0)
							{
								foreach (DataRow dataRow2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Select("[Type] = " + Conversions.ToString(3), "", DataViewRowState.CurrentRows))
								{
									CompletionItem completionItem6 = new CompletionItem(dataRow2["Name"].ToString(), new CommonImageSourceProvider(CommonImageKind.FieldPublic));
									if (token.Id != 11028)
									{
										completionItem6.AutoCompletePreText = "\"" + dataRow2["Name"].ToString() + "\"";
									}
									oO0O_oO_0O_.o_0.O0__OO.().Items.Add(completionItem6);
								}
							}
							else
							{
								if (Operators.CompareString(left, "Connections", true) == 0)
								{
									try
									{
										foreach (Connection connection in OO_00oOO.Connections)
										{
											CompletionItem completionItem7 = new CompletionItem(connection.Name, new CommonImageSourceProvider(CommonImageKind.FieldPublic));
											if (token.Id != 11028)
											{
												completionItem7.AutoCompletePreText = "\"" + connection.Name + "\"";
											}
											oO0O_oO_0O_.o_0.O0__OO.().Items.Add(completionItem7);
										}
										goto IL_B53;
									}
									finally
									{
										IEnumerator<Connection> enumerator15;
										if (enumerator15 != null)
										{
											enumerator15.Dispose();
										}
									}
								}
								if (Operators.CompareString(left, "StripItems", true) != 0)
								{
									Operators.CompareString(left, "Controls", true);
								}
							}
						}
						IL_B53:
						if (oO0O_oO_0O_.o_0.O0__OO.().Items.Count > 0)
						{
							if (Operators.CompareString(left, "Cols", true) == 0)
							{
								base.CanShowOnTypedWordStart = false;
							}
							if (Operators.CompareString(left, "StripItems", true) != 0 && Operators.CompareString(left, "Cols", true) != 0 && Operators.CompareString(left, "topiclinks", true) != 0 && Operators.CompareString(left, "Functions", true) != 0)
							{
								oO0O_oO_0O_.o_0.O0__OO.().SortItems();
							}
							oO0O_oO_0O_.o_0.O0__OO.().Open(A_0);
							return true;
						}
					}
					result = base.RequestSession(A_0, A_1);
				}
			}
			return result;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00016B70 File Offset: 0x00014D70
		private static void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (oO0O_oO_0O_.o_0.O0__OO.().View != null && oO0O_oO_0O_.o_0.O0__OO.().View.SyntaxEditor != null)
			{
				O_o00o_ o_o00o_ = (O_o00o_)oO0O_oO_0O_.o_0.O0__OO.().View.SyntaxEditor;
				((oO0O_oO_0O_)o_o00o_.Document.Language.GetService<VBCompletionProvider>()).CanShowOnTypedWordStart = o_o00o_.o.00oO0Oo.;
			}
			if (A_0 == oO0O_oO_0O_.o_0.O0__OO.() && oO0O_oO_0O_.o_0.O0__OO.().Selection != null && oO0O_oO_0O_.o_0.O0__OO.().Selection.Item.Tag != null)
			{
				string text = oO0O_oO_0O_.o_0.O0__OO.().Selection.Item.Tag.ToString();
				if (text.StartsWith("helpid_"))
				{
					text = text.Substring("helpid_".Length);
					O_o00o_ o_o00o_2 = (O_o00o_)oO0O_oO_0O_.o_0.O0__OO.().View.SyntaxEditor;
					if (Operators.CompareString(o_o00o_2.o_o_._000oO_o0., text, true) != 0 && Operators.CompareString(text, "", true) > 0)
					{
						o_o00o_2.o_o_._000oO_o0. = text;
						o_o00o_2.O.0_oOooO_000o.();
					}
					return;
				}
				if (text.StartsWith("fuction_"))
				{
					text = text.Substring("fuction_".Length);
					DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o.00_0o0__OoO.()];
					string filterExpression = string.Concat(new string[]
					{
						"[Type] = ",
						Conversions.ToString(9),
						"And [Name] ='",
						text,
						"'"
					});
					DataRow[] array = dataTable.Select(filterExpression);
					if (array.Length == 1)
					{
						OOo_o ooo_o;
						if (oO0O_oO_0O_.o_0.O0__OO.().View.SyntaxEditor.FindForm() is O\u3000\u3002\u3000\u3000)
						{
							ooo_o = ((O\u3000\u3002\u3000\u3000)oO0O_oO_0O_.o_0.O0__OO.().View.SyntaxEditor.FindForm()).O.O_0o_Oo_.();
						}
						else
						{
							if (!(oO0O_oO_0O_.o_0.O0__OO.().View.SyntaxEditor.FindForm() is oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000))
							{
								return;
							}
							ooo_o = ((oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000)oO0O_oO_0O_.o_0.O0__OO.().View.SyntaxEditor.FindForm()).oo._OoO.();
						}
						ooo_o.oo.O0ooOo00_0.("");
						ooo_o.o0_Oo0OO.O.(array[0]);
					}
				}
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00016D89 File Offset: 0x00014F89
		private static void <<EMPTY_NAME>>(object A_0, CancelEventArgs A_1)
		{
			oO0O_oO_0O_.o_0.O0__OO.().Items.Clear();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00016D9C File Offset: 0x00014F9C
		private CompletionItem <<EMPTY_NAME>>(ITypeMemberDefinition A_0, Type A_1)
		{
			if (oO0O_oO_0O_.OoOo.0oo. == null)
			{
				oO0O_oO_0O_.OoOo.0oo. = XDocument.Load(O_O0OO.o.00O_O.() + "foxtable.xml");
			}
			string text = "";
			string text2 = A_0.DeclaringType.FullName + "." + A_0.Name;
			if (A_0.Kind == TypeMemberDefinitionKind.Method)
			{
				text2 = "M:" + text2;
			}
			else if (A_0.Kind == TypeMemberDefinitionKind.Property)
			{
				text2 = "P:" + text2;
			}
			try
			{
				foreach (XElement xelement in oO0O_oO_0O_.OoOo.0oo..Root.Descendants("member"))
				{
					if (Operators.CompareString(xelement.Attribute("name").Value, text2, true) == 0)
					{
						text = xelement.Element("summary").Value.Trim();
					}
				}
			}
			finally
			{
				IEnumerator<XElement> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			CommonImageKind imageKind = CommonImageKind.PropertyPublic;
			if (A_0.Kind == TypeMemberDefinitionKind.Method)
			{
				imageKind = CommonImageKind.MethodPublic;
			}
			string text3 = "";
			if (A_1 != null)
			{
				MemberInfo[] member = A_1.GetMember(A_0.Name);
				if (member.Length > 0)
				{
					if (Operators.CompareString(text, "", true) == 0)
					{
						DescriptionAttribute descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(member[0], typeof(DescriptionAttribute));
						if (descriptionAttribute != null)
						{
							text = descriptionAttribute.Description;
						}
					}
					oO0oooo oO0oooo = (oO0oooo)Attribute.GetCustomAttribute(member[0], typeof(oO0oooo));
					if (oO0oooo != null)
					{
						text3 = oO0oooo.ooo_0.o.();
					}
				}
			}
			CompletionItem completionItem;
			if (Operators.CompareString(text, "", true) == 0)
			{
				completionItem = new CompletionItem(A_0.Name, new CommonImageSourceProvider(imageKind));
			}
			else
			{
				completionItem = new CompletionItem(A_0.Name, new CommonImageSourceProvider(imageKind), new PlainTextContentProvider(text));
			}
			if (Operators.CompareString(text3, "", true) > 0)
			{
				completionItem.Tag = "helpid_" + text3;
			}
			return completionItem;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00016F8C File Offset: 0x0001518C
		private void <<EMPTY_NAME>>(IToken A_0, bool A_1)
		{
			o\u3002\u3002\u3000\u3000\u3002 o_u3002_u3002_u3000_u3000_u = null;
			try
			{
				foreach (object obj in Application.OpenForms)
				{
					System.Windows.Forms.Form form = (System.Windows.Forms.Form)obj;
					if (form is o\u3002\u3002\u3000\u3000\u3002)
					{
						o_u3002_u3002_u3000_u3000_u = (o\u3002\u3002\u3000\u3000\u3002)form;
						break;
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
			if (o_u3002_u3002_u3000_u3000_u != null)
			{
				try
				{
					foreach (PropertyBase propertyBase in o_u3002_u3002_u3000_u3000_u.O0o._0..Values)
					{
						if (propertyBase is TableGridProperty)
						{
							TableGridProperty tableGridProperty = (TableGridProperty)propertyBase;
							if ((tableGridProperty.TableType == TableTypeEnum.Normal && tableGridProperty.IsCopy && A_1) || tableGridProperty.TableType == TableTypeEnum.SQLQuery || tableGridProperty.TableType == TableTypeEnum.SQLTable)
							{
								string text = o_u3002_u3002_u3000_u3000_u.o_0O.OO0_0_.["Name"].ToString() + "_" + tableGridProperty.Name;
								CompletionItem completionItem = new CompletionItem(text, new CommonImageSourceProvider(CommonImageKind.FieldPublic));
								if (A_0.Id != 11028)
								{
									completionItem.AutoCompletePreText = "\"" + text + "\"";
								}
								oO0O_oO_0O_.o_0.O0__OO.().Items.Add(completionItem);
							}
						}
					}
				}
				finally
				{
					Dictionary<string, PropertyBase>.ValueCollection.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
		}

		// Token: 0x040000F2 RID: 242
		private HashSet<string> <<EMPTY_NAME>>;

		// Token: 0x040000F3 RID: 243
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x040000F4 RID: 244
		private bool <<EMPTY_NAME>>;

		// Token: 0x040000F5 RID: 245
		[CompilerGenerated]
		private static CompletionSession <<EMPTY_NAME>>;

		// Token: 0x040000F6 RID: 246
		private static Dictionary<string, CompletionItem> <<EMPTY_NAME>>;

		// Token: 0x040000F7 RID: 247
		private static Dictionary<string, CompletionItem> <<EMPTY_NAME>>;

		// Token: 0x040000F8 RID: 248
		private static XDocument <<EMPTY_NAME>>;

		// Token: 0x040000F9 RID: 249
		internal List<string> <<EMPTY_NAME>>;

		// Token: 0x040000FA RID: 250
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040000FB RID: 251
		private static string <<EMPTY_NAME>>;
	}
}
