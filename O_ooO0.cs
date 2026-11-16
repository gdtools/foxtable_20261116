using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Languages.DotNet;
using ActiproSoftware.Text.Languages.DotNet.Ast.Implementation;
using ActiproSoftware.Text.Languages.DotNet.Reflection;
using ActiproSoftware.Text.Languages.DotNet.Resolution;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Text.Parsing;
using ActiproSoftware.Text.Searching;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.IntelliPrompt.Implementation;
using C1.Win.C1Command;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000076 RID: 118
	[StandardModule]
	internal sealed class O_ooO0
	{
		// Token: 0x06000450 RID: 1104 RVA: 0x0001A018 File Offset: 0x00018218
		static O_ooO0()
		{
			O_ooO0.O__o.O000..MatchCase = false;
			O_ooO0.O__o.O000..SearchUp = true;
			O_ooO0.O__o.O000..MaximumResultCount = 1;
			O_ooO0.O__o.O000..PatternProvider = SearchPatternProviders.RegularExpression;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0001A070 File Offset: 0x00018270
		internal static bool <<EMPTY_NAME>>(IToken A_0)
		{
			int id = A_0.Id;
			if (id <= 11067)
			{
				if (id != 11002 && id - 11066 > 1)
				{
					goto IL_37;
				}
			}
			else if (id != 11107 && id != 11165)
			{
				goto IL_37;
			}
			return true;
			IL_37:
			return false;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0001A0B7 File Offset: 0x000182B7
		internal static bool <<EMPTY_NAME>>(ITextSnapshotReader A_0, IToken A_1)
		{
			return A_0.SnapshotLine.FirstNonWhitespaceCharacterOffset == A_1.StartOffset;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0001A0CC File Offset: 0x000182CC
		internal static IToken <<EMPTY_NAME>>(ITextSnapshotReader A_0)
		{
			int offset = A_0.Offset;
			IToken token = null;
			while (!A_0.IsAtSnapshotLineStart)
			{
				token = A_0.ReadTokenReverse();
				if (token.Id != 11000)
				{
					break;
				}
			}
			A_0.Offset = offset;
			return token;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0001A108 File Offset: 0x00018308
		internal static IToken <<EMPTY_NAME>>(ITextSnapshotReader A_0)
		{
			int offset = A_0.Offset;
			A_0.Offset = A_0.SnapshotLine.FirstNonWhitespaceCharacterOffset;
			IToken result = A_0.ReadToken();
			A_0.Offset = offset;
			return result;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0001A13C File Offset: 0x0001833C
		internal static IToken <<EMPTY_NAME>>(ITextSnapshotReader A_0)
		{
			int offset = A_0.Offset;
			A_0.GoToCurrentSnapshotLineEnd();
			while (!A_0.IsAtSnapshotLineStart)
			{
				IToken token = A_0.ReadTokenReverse();
				if (token != null && token.Id != 11000 && token.Id != 11196 && !VBTokenId.IsCommentClassificationType(token.Id))
				{
					A_0.Offset = offset;
					return token;
				}
			}
			A_0.Offset = offset;
			return null;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0001A1A8 File Offset: 0x000183A8
		internal static IToken <<EMPTY_NAME>>(ITextSnapshotReader A_0)
		{
			int offset = A_0.Offset;
			A_0.GoToCurrentSnapshotLineStart();
			int index = A_0.SnapshotLine.Index;
			IToken result;
			if (!A_0.GoToNextTokenWithId(11196))
			{
				A_0.Offset = offset;
				result = null;
			}
			else if (A_0.SnapshotLine.Index != index)
			{
				A_0.Offset = offset;
				result = null;
			}
			else
			{
				A_0.GoToNextToken();
				while (!A_0.IsAtSnapshotLineEnd)
				{
					IToken token = A_0.ReadToken();
					if (token != null && token.Id != 11000 && !VBTokenId.IsCommentClassificationType(token.Id))
					{
						A_0.Offset = offset;
						return token;
					}
				}
				A_0.Offset = offset;
				result = null;
			}
			return result;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0001A24C File Offset: 0x0001844C
		internal static string <<EMPTY_NAME>>(ITextSnapshotReader A_0, int A_1, CompletionSession A_2)
		{
			string text = "";
			if (Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
			{
				text = ((O\u3000\u3002\u3000\u3000)Form.ActiveForm).O_o_.0.;
			}
			if (Operators.CompareString(text, "", true) == 0)
			{
				if (A_2 == null)
				{
					return "temp";
				}
				for (IAstNode parent = new VBContextFactory().CreateContext(new TextSnapshotOffset(A_0.Snapshot, A_1), DotNetContextKind.Self).ContainingAstNode.Parent; parent != null; parent = parent.Parent)
				{
					if (parent is IfStatement)
					{
						if (parent.Children.Count > 0 && parent.Children[0] is BinaryOperatorExpression)
						{
							BinaryOperatorExpression binaryOperatorExpression = (BinaryOperatorExpression)parent.Children[0];
							if (binaryOperatorExpression.LeftExpression.StartOffset != null)
							{
								string substring = A_0.Snapshot.GetSubstring(binaryOperatorExpression.LeftExpression.StartOffset.Value, binaryOperatorExpression.LeftExpression.Length);
								if ((Operators.CompareString(substring, "e.datatable.name", true) == 0 || Operators.CompareString(substring, "e.table.name", true) == 0) && binaryOperatorExpression.RightExpression is LiteralExpression)
								{
									return ((LiteralExpression)binaryOperatorExpression.RightExpression).StringValue.Trim(new char[]
									{
										'"'
									});
								}
							}
						}
					}
					else if (!(parent is SwitchStatement) && parent is SwitchSection && parent.Children.Count > 0 && parent.Children[0] is SwitchLabel && parent.Children[0].StartOffset != null)
					{
						string result = A_0.Snapshot.GetSubstring(parent.Children[0].StartOffset.Value, parent.Children[0].Length).Trim(new char[]
						{
							'"'
						});
						parent = parent.Parent;
						if (parent != null && parent is SwitchStatement && parent.Children.Count > 0 && parent.Children[0].StartOffset != null)
						{
							string substring2 = A_0.Snapshot.GetSubstring(parent.Children[0].StartOffset.Value, parent.Children[0].Length);
							if (Operators.CompareString(substring2, "e.datatable.name", true) == 0 || Operators.CompareString(substring2, "e.table.name", true) == 0)
							{
								return result;
							}
						}
					}
				}
			}
			return text;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0001A4FC File Offset: 0x000186FC
		internal static SwitchStatement <<EMPTY_NAME>>(ITextSnapshot A_0, int A_1)
		{
			IDotNetContext dotNetContext = new VBContextFactory().CreateContext(new TextSnapshotOffset(A_0, A_1), DotNetContextKind.Self);
			new List<WithStatement>();
			for (IAstNode parent = dotNetContext.ContainingAstNode.Parent; parent != null; parent = parent.Parent)
			{
				if (parent is SwitchStatement)
				{
					return (SwitchStatement)parent;
				}
				if (parent is MethodBody)
				{
					break;
				}
			}
			return null;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0001A554 File Offset: 0x00018754
		internal static bool <<EMPTY_NAME>>(DataRow A_0, string A_1, ref ControlTypeEnum A_2)
		{
			DataRow[] childRows = A_0.GetChildRows("Component");
			int i = 0;
			checked
			{
				while (i < childRows.Length)
				{
					DataRow dataRow = childRows[i];
					bool result;
					if (Operators.CompareString(dataRow["Name"].ToString(), A_1, true) == 0)
					{
						A_2 = (ControlTypeEnum)Conversions.ToInteger(dataRow["Type"]);
						result = false;
					}
					else
					{
						if (O_ooO0.o.o__O_.(dataRow, A_1, ref A_2))
						{
							i++;
							continue;
						}
						result = false;
					}
					return result;
				}
				return true;
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0001A5C0 File Offset: 0x000187C0
		internal static string <<EMPTY_NAME>>(ITextSnapshotReader A_0, IToken A_1, CompletionSession A_2, bool A_3)
		{
			string result;
			if (A_1 == null)
			{
				result = null;
			}
			else
			{
				ITextSnapshotLine snapshotLine = A_0.SnapshotLine;
				string text = A_0.Snapshot.GetSubstring(snapshotLine.StartOffset, A_1.StartOffset - snapshotLine.StartOffset).Trim();
				DataTable dataTable = null;
				try
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
						if (form is o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)
						{
							dataTable = ((o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)form).O.o0OO.;
						}
						else if (form is o_\u3002\u3002\u3000\u3000\u3002)
						{
							dataTable = ((o_\u3002\u3002\u3000\u3000\u3002)form).oOoo_0O.oo00oO..DataTable;
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
				if (dataTable == null)
				{
					dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()];
					if (dataTable.Rows.Count < 6)
					{
						dataTable = Main.OO_O.o..oO_0_.oO.;
						if (dataTable == null)
						{
							return null;
						}
					}
				}
				DataRow dataRow = null;
				int num = text.IndexOfAny(new char[]
				{
					'.',
					'('
				});
				if (num > 0)
				{
					string text2 = text.Substring(0, num);
					string left = text2;
					RibbonItemTypeEnum value;
					if ((Operators.CompareString(left, "ApplicationMenu", true) == 0 || Operators.CompareString(left, "QAT", true) == 0 || Operators.CompareString(left, "ConfigBar", true) == 0 || Operators.CompareString(left, "ToolBar", true) == 0 || Operators.CompareString(left, "TopToolBar", true) == 0 || Operators.CompareString(left, "BottomToolBar", true) == 0) && Enum.TryParse<RibbonItemTypeEnum>(text2, out value))
					{
						DataRow[] array = dataTable.Select("[Type] = " + Conversions.ToString((int)value));
						if (array.Length > 0)
						{
							dataRow = array[0];
						}
					}
				}
				if (text.StartsWith("RibbonTabs", StringComparison.OrdinalIgnoreCase) || text.StartsWith("ContextMenus", StringComparison.OrdinalIgnoreCase) || dataRow != null)
				{
					MatchCollection matchCollection = new Regex("(Groups|Items)?\\(\"([\\w\\u4e00-\\u9fa5]+)\"\\)", RegexOptions.IgnoreCase).Matches(text);
					if (matchCollection.Count > 0)
					{
						if (A_2 == null)
						{
							return "Menus";
						}
						DataRow dataRow2 = dataRow;
						int num2 = matchCollection.Count - 1;
						for (int i = 0; i <= num2; i++)
						{
							string text3 = "[Name] = '" + matchCollection[i].Groups[2].Value + "'";
							if (dataRow2 != null)
							{
								text3 = text3 + " And [ParentKey] = '" + dataRow2["key"].ToString() + "'";
							}
							else
							{
								text3 += " And [ParentKey] is null";
							}
							DataRow[] array2 = dataTable.Select(text3);
							if (array2.Length == 0)
							{
								return null;
							}
							dataRow2 = array2[0];
							if (i == matchCollection.Count - 1)
							{
								if (A_2 != null)
								{
									A_2.Items.Clear();
									text3 = "[ParentKey] = '" + dataRow2["key"].ToString() + "'";
									foreach (DataRow dataRow3 in dataTable.Select(text3))
									{
										CompletionItem completionItem = new CompletionItem(dataRow3["Name"].ToString(), new CommonImageSourceProvider(CommonImageKind.MethodPublic));
										if (!A_3)
										{
											completionItem.AutoCompletePreText = "\"" + dataRow3["Name"].ToString() + "\"";
										}
										A_2.Items.Add(completionItem);
									}
								}
								return "Menus";
							}
						}
					}
					else
					{
						string text4 = "";
						if (Operators.CompareString(text, "RibbonTabs", true) == 0)
						{
							text4 = "[type] = " + Conversions.ToString(5);
						}
						else if (Operators.CompareString(text, "ContextMenus", true) == 0)
						{
							text4 = "[type] = " + Conversions.ToString(128);
						}
						if (Operators.CompareString(text4, "", true) > 0)
						{
							if (A_2 != null)
							{
								foreach (DataRow dataRow4 in dataTable.Select(text4))
								{
									CompletionItem completionItem2 = new CompletionItem(dataRow4["Name"].ToString(), new CommonImageSourceProvider(CommonImageKind.MethodPublic));
									if (!A_3)
									{
										completionItem2.AutoCompletePreText = "\"" + dataRow4["Name"].ToString() + "\"";
									}
									A_2.Items.Add(completionItem2);
								}
							}
							return "Menus";
						}
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001AA28 File Offset: 0x00018C28
		internal static bool <<EMPTY_NAME>>(ITextSnapshotReader A_0, IToken A_1, ref RibbonItemTypeEnum A_2)
		{
			bool result;
			if (A_1 == null)
			{
				result = false;
			}
			else
			{
				ITextSnapshotLine snapshotLine = A_0.SnapshotLine;
				string text = A_0.Snapshot.GetSubstring(snapshotLine.StartOffset, A_1.StartOffset - snapshotLine.StartOffset);
				if (A_1 != null && A_1.Id == 11010)
				{
					if (O_ooO0.O__o.O000.(A_0, A_1))
					{
						A_0.GoToPreviousSnapshotLineEnd();
						snapshotLine = A_0.SnapshotLine;
						while (snapshotLine.Index > 0 && Operators.CompareString(A_0.Snapshot.GetSubstring(snapshotLine.FirstNonWhitespaceCharacterOffset, 1), ".", true) == 0)
						{
							A_0.GoToPreviousSnapshotLineEnd();
							snapshotLine = A_0.SnapshotLine;
						}
						text = A_0.SnapshotLine.Text;
					}
					text = text.Trim();
					DataTable dataTable = null;
					try
					{
						foreach (object obj in Application.OpenForms)
						{
							Form form = (Form)obj;
							if (form is o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)
							{
								dataTable = ((o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)form).O.o0OO.;
							}
							else if (form is o_\u3002\u3002\u3000\u3000\u3002)
							{
								dataTable = ((o_\u3002\u3002\u3000\u3000\u3002)form).oOoo_0O.oo00oO..DataTable;
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
					if (dataTable == null)
					{
						dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()];
						if (dataTable.Rows.Count < 6)
						{
							dataTable = Main.OO_O.o..oO_0_.oO.;
							if (dataTable == null)
							{
								return false;
							}
						}
					}
					DataRow dataRow = null;
					int num = text.IndexOfAny(new char[]
					{
						'.',
						'('
					});
					if (num > 0)
					{
						string text2 = text.Substring(0, num);
						string left = text2;
						RibbonItemTypeEnum value;
						if ((Operators.CompareString(left, "ApplicationMenu", true) == 0 || Operators.CompareString(left, "QAT", true) == 0 || Operators.CompareString(left, "ConfigBar", true) == 0 || Operators.CompareString(left, "ToolBar", true) == 0 || Operators.CompareString(left, "TopToolBar", true) == 0 || Operators.CompareString(left, "BottomToolBar", true) == 0) && Enum.TryParse<RibbonItemTypeEnum>(text2, out value))
						{
							DataRow[] array = dataTable.Select("[Type] = " + Conversions.ToString((int)value));
							if (array.Length > 0)
							{
								dataRow = array[0];
							}
						}
					}
					if (text.StartsWith("RibbonTabs(", StringComparison.OrdinalIgnoreCase) || text.StartsWith("ContextMenus(", StringComparison.OrdinalIgnoreCase) || dataRow != null)
					{
						MatchCollection matchCollection = new Regex("(Groups|Items)?\\(\"([\\w\\u4e00-\\u9fa5]+)\"\\)").Matches(text);
						if (matchCollection.Count > 0)
						{
							if (text.StartsWith("RibbonTabs(", StringComparison.OrdinalIgnoreCase) && matchCollection.Count <= 2)
							{
								return false;
							}
							if (text.StartsWith("ContextMenus(") && matchCollection.Count <= 1)
							{
								return false;
							}
							DataRow dataRow2 = dataRow;
							int num2 = matchCollection.Count - 1;
							for (int i = 0; i <= num2; i++)
							{
								string text3 = "[Name] = '" + matchCollection[i].Groups[2].Value + "'";
								if (dataRow2 != null)
								{
									text3 = text3 + " And [ParentKey] = '" + dataRow2["key"].ToString() + "'";
								}
								else
								{
									text3 += " And [ParentKey] is null";
								}
								DataRow[] array2 = dataTable.Select(text3);
								if (array2.Length == 0)
								{
									return false;
								}
								dataRow2 = array2[0];
								if (i == matchCollection.Count - 1)
								{
									A_2 = (RibbonItemTypeEnum)Conversions.ToInteger(dataRow2["Type"]);
									return true;
								}
							}
						}
					}
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001ADA0 File Offset: 0x00018FA0
		internal static bool <<EMPTY_NAME>>(ITextSnapshotReader A_0, IToken A_1, ref ControlTypeEnum A_2)
		{
			if (A_1 != null && A_1.Id == 11010)
			{
				if (O_ooO0.O__o.O000.(A_0, A_1))
				{
					A_0.GoToPreviousSnapshotLineEnd();
					ITextSnapshotLine snapshotLine = A_0.SnapshotLine;
					while (snapshotLine.Index > 0 && Operators.CompareString(A_0.Snapshot.GetSubstring(snapshotLine.FirstNonWhitespaceCharacterOffset, 1), ".", true) == 0)
					{
						A_0.GoToPreviousSnapshotLineEnd();
						snapshotLine = A_0.SnapshotLine;
					}
				}
				A_1 = A_0.ReadTokenReverse();
				string text = "";
				DataRow dataRow = null;
				if (A_1 != null && A_1.Id == 11004)
				{
					int startOffset = A_1.StartOffset;
					if (A_0.GoToPreviousMatchingTokenById(11004, 11003))
					{
						int offset = A_0.Offset;
						A_0.Offset++;
						IToken token = A_0.ReadToken();
						if (token.Id == 11028 && token.EndOffset == startOffset)
						{
							text = A_0.Snapshot.GetSubstring(token.TextRange).Trim().Trim(new char[]
							{
								'"'
							});
						}
						A_0.Offset = offset;
						A_1 = A_0.ReadTokenReverse();
						if (A_1 != null && A_1.Id == 11033 && Operators.CompareString(A_0.Snapshot.GetSubstring(A_1.TextRange), "Controls", true) == 0)
						{
							A_1 = A_0.ReadTokenReverse();
							if (A_1 != null && A_1.Id == 11010)
							{
								A_1 = A_0.ReadTokenReverse();
								if (A_1 != null && A_1.Id == 11033)
								{
									if (Operators.CompareString(A_0.Snapshot.GetSubstring(A_1.TextRange), "form", true) != 0)
									{
										goto IL_37B;
									}
									A_1 = A_0.ReadTokenReverse();
									if (A_1 == null || A_1.Id != 11010)
									{
										goto IL_37B;
									}
									A_1 = A_0.ReadTokenReverse();
									if (A_1 == null || A_1.Id != 11033 || Operators.CompareString(A_0.Snapshot.GetSubstring(A_1.TextRange), "e", true) != 0)
									{
										goto IL_37B;
									}
									try
									{
										foreach (object obj in Application.OpenForms)
										{
											Form form = (Form)obj;
											if (form is o\u3002\u3002\u3000\u3000\u3002)
											{
												dataRow = ((o\u3002\u3002\u3000\u3000\u3002)form).o_0O.OO0_0_.;
												break;
											}
										}
										goto IL_37B;
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
								if (A_1 != null && A_1.Id == 11004)
								{
									startOffset = A_1.StartOffset;
									if (A_0.GoToPreviousMatchingTokenById(11004, 11003))
									{
										A_0.Offset++;
										token = A_0.ReadToken();
										if (token.Id == 11028 && token.EndOffset == startOffset)
										{
											string right = A_0.Snapshot.GetSubstring(token.TextRange).Trim().Trim(new char[]
											{
												'"'
											});
											try
											{
												foreach (object obj2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()].Rows)
												{
													DataRow dataRow2 = (DataRow)obj2;
													if (Operators.CompareString(dataRow2["Name"].ToString(), right, true) == 0 && Conversions.ToInteger(dataRow2["Type"]) == 229)
													{
														dataRow = dataRow2;
														break;
													}
												}
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
									}
								}
							}
							IL_37B:
							if (Operators.CompareString(text, "", true) > 0 && dataRow != null)
							{
								O_ooO0.o.o__O_.(dataRow, text, ref A_2);
							}
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001B168 File Offset: 0x00019368
		internal static void <<EMPTY_NAME>>(CompletionSession A_0, bool A_1)
		{
			try
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					if (form is o\u3000\u3002)
					{
						Dictionary<string, ToolStrip> o0__O.Oo0__. = ((o\u3000\u3002)form).o0__O.Oo0__.;
						if (o0__O.Oo0__. == null)
						{
							break;
						}
						try
						{
							foreach (ToolStrip toolStrip in o0__O.Oo0__..Values)
							{
								try
								{
									foreach (object obj2 in toolStrip.Items)
									{
										ToolStripItem a_ = (ToolStripItem)obj2;
										O_ooO0.O._OOo__.(A_0, a_, A_1, 0);
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
							break;
						}
						finally
						{
							Dictionary<string, ToolStrip>.ValueCollection.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
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

		// Token: 0x0600045E RID: 1118 RVA: 0x0001B270 File Offset: 0x00019470
		private static void <<EMPTY_NAME>>(CompletionSession A_0, ToolStripItem A_1, bool A_2, int A_3)
		{
			if (!(A_1 is ToolStripSeparator))
			{
				CompletionItem completionItem = new CompletionItem(new string(' ', A_3 * 4) + A_1.Name, new CommonImageSourceProvider(CommonImageKind.ConstantPublic));
				if (!A_2)
				{
					completionItem.AutoCompletePreText = "\"" + A_1.Name + "\"";
				}
				else
				{
					completionItem.AutoCompletePreText = A_1.Name;
				}
				completionItem.InlineDescription = A_1.Text;
				A_0.Items.Add(completionItem);
				if (A_1 is ToolStripDropDownItem)
				{
					try
					{
						foreach (object obj in ((ToolStripDropDownItem)A_1).DropDownItems)
						{
							ToolStripItem a_ = (ToolStripItem)obj;
							O_ooO0.O._OOo__.(A_0, a_, A_2, A_3 + 1);
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
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001B350 File Offset: 0x00019550
		private static void <<EMPTY_NAME>>(CompletionSession A_0, bool A_1)
		{
			if (Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
			{
				O\u3000\u3002\u3000\u3000 o_u3000_u3002_u3000_u = (O\u3000\u3002\u3000\u3000)Form.ActiveForm;
				if (o_u3000_u3002_u3000_u.O0o__._oo0oo_. != null && o_u3000_u3002_u3000_u.O0o__._oo0oo_. is Oo_)
				{
					Oo_ oo_ = (Oo_)o_u3000_u3002_u3000_u.O0o__._oo0oo_.;
					try
					{
						foreach (object obj in oo_.Pages)
						{
							C1TopicPage c1TopicPage = (C1TopicPage)obj;
							CompletionItem completionItem = new CompletionItem(c1TopicPage.Tag.ToString(), new CommonImageSourceProvider(CommonImageKind.FieldPublic));
							if (!A_1)
							{
								completionItem.AutoCompletePreText = "\"" + c1TopicPage.Tag.ToString() + "\"";
							}
							completionItem.InlineDescription = c1TopicPage.Text;
							A_0.Items.Add(completionItem);
							try
							{
								foreach (object obj2 in c1TopicPage.Links)
								{
									C1TopicLink c1TopicLink = (C1TopicLink)obj2;
									completionItem = new CompletionItem("   " + c1TopicLink.Tag.ToString(), new CommonImageSourceProvider(CommonImageKind.FieldPublic));
									if (!A_1)
									{
										completionItem.AutoCompletePreText = "\"" + c1TopicLink.Tag.ToString() + "\"";
									}
									else
									{
										completionItem.AutoCompletePreText = c1TopicLink.Tag.ToString();
									}
									completionItem.InlineDescription = c1TopicLink.Text;
									A_0.Items.Add(completionItem);
								}
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
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001B530 File Offset: 0x00019730
		private static void <<EMPTY_NAME>>(CompletionSession A_0, bool A_1)
		{
			if (Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
			{
				O\u3000\u3002\u3000\u3000 o_u3000_u3002_u3000_u = (O\u3000\u3002\u3000\u3000)Form.ActiveForm;
				if (o_u3000_u3002_u3000_u.O0o__._oo0oo_. != null && o_u3000_u3002_u3000_u.O0o__._oo0oo_. is Oo_)
				{
					Oo_ oo_ = (Oo_)o_u3000_u3002_u3000_u.O0o__._oo0oo_.;
					try
					{
						foreach (object obj in oo_.Pages)
						{
							C1TopicPage c1TopicPage = (C1TopicPage)obj;
							CompletionItem completionItem = new CompletionItem(c1TopicPage.Tag.ToString(), new CommonImageSourceProvider(CommonImageKind.FieldPublic));
							if (!A_1)
							{
								completionItem.AutoCompletePreText = "\"" + c1TopicPage.Tag.ToString() + "\"";
							}
							completionItem.InlineDescription = c1TopicPage.Text;
							A_0.Items.Add(completionItem);
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
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0001B628 File Offset: 0x00019828
		internal static void <<EMPTY_NAME>>(string A_0, string A_1, CompletionSession A_2)
		{
			string text = "";
			bool flag;
			if (OO_00oOO.Tables.get_Contains(A_0))
			{
				DataTable dataTable = OO_00oOO.Tables[A_0].DataTable.BaseTable;
				if (dataTable.Columns.Contains(A_1))
				{
					Type dataType = dataTable.Columns[A_1].DataType;
					if (dataType == typeof(string))
					{
						text = SysInfo.StringMembers;
					}
					else if (dataType == typeof(DateTime))
					{
						text = SysInfo.DateMembers;
					}
					flag = true;
				}
			}
			else
			{
				o\u3002\u3002\u3000\u3000\u3002 o_u3002_u3002_u3000_u3000_u = null;
				try
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
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
								if (tableGridProperty.TableType == TableTypeEnum.Normal && tableGridProperty.IsCopy)
								{
									string relationTable = tableGridProperty.RelationTable;
									if (OO_00oOO.Tables.get_Contains(relationTable))
									{
										DataTable dataTable2 = OO_00oOO.Tables[relationTable].DataTable.BaseTable;
										if (dataTable2.Columns.Contains(A_1))
										{
											Type dataType2 = dataTable2.Columns[A_1].DataType;
											if (dataType2 == typeof(string))
											{
												text = SysInfo.StringMembers;
											}
											else if (dataType2 == typeof(DateTime))
											{
												text = SysInfo.DateMembers;
											}
											flag = true;
										}
									}
								}
								else if (tableGridProperty.TableType == TableTypeEnum.SQLQuery || tableGridProperty.TableType == TableTypeEnum.SQLTable)
								{
									string key = o_u3002_u3002_u3000_u3000_u.o_0O.OO0_0_.["Name"].ToString() + "_" + tableGridProperty.Name;
									O\u3000\u3002\u3000\u3000 o_u3000_u3002_u3000_u = null;
									List<string> list = null;
									if (Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
									{
										o_u3000_u3002_u3000_u = (O\u3000\u3002\u3000\u3000)Form.ActiveForm;
										if (o_u3000_u3002_u3000_u.O0oO0_O0.O..ContainsKey(key))
										{
											list = o_u3000_u3002_u3000_u.O0oO0_O0.O.[key];
										}
									}
									if (list == null)
									{
										list = new List<string>();
										SQLCommand sqlcommand = new SQLCommand();
										sqlcommand.CommandText = tableGridProperty.SelectString;
										sqlcommand.ConnectionName = tableGridProperty.Connection;
										try
										{
											DataTable dataTable3 = sqlcommand.OO__00.__.();
											try
											{
												foreach (DataCol dataCol in dataTable3.DataCols)
												{
													list.Add(dataCol.Name + "\t" + O_ooO0.O__o.O000.(dataCol.BaseColumn.DataType.Name));
												}
											}
											finally
											{
												IEnumerator<DataCol> enumerator3;
												if (enumerator3 != null)
												{
													enumerator3.Dispose();
												}
											}
										}
										catch (Exception ex)
										{
											return;
										}
										if (o_u3000_u3002_u3000_u != null)
										{
											o_u3000_u3002_u3000_u.O0oO0_O0.O.[key] = list;
										}
									}
									try
									{
										foreach (string text2 in list)
										{
											string[] array = text2.Split(new char[]
											{
												'\t'
											});
											if (array.Length == 2 && Operators.CompareString(array[0], A_1, true) == 0)
											{
												if (Operators.CompareString(array[1], "String", true) == 0)
												{
													text = SysInfo.StringMembers;
													break;
												}
												if (Operators.CompareString(array[1], "Date", true) == 0)
												{
													text = SysInfo.DateMembers;
													break;
												}
												break;
											}
										}
									}
									finally
									{
										List<string>.Enumerator enumerator4;
										((IDisposable)enumerator4).Dispose();
									}
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
			if (Operators.CompareString(text, "", true) > 0)
			{
				string[] array2 = text.Split(new char[]
				{
					'|'
				});
				int num = array2.Length - 3;
				for (int i = 0; i <= num; i += 3)
				{
					CompletionItem completionItem = new CompletionItem(array2[i], new CommonImageSourceProvider(CommonImageKind.FieldPublic));
					completionItem.DescriptionProvider = new PlainTextContentProvider(array2[i + 2]);
					completionItem.Tag = "helpid_" + array2[i + 1];
					A_2.Items.Add(completionItem);
				}
			}
			if (flag)
			{
				CompletionItem completionItem2 = new CompletionItem("ToString", new CommonImageSourceProvider(CommonImageKind.FieldPublic));
				completionItem2.DescriptionProvider = new PlainTextContentProvider("返回值的字符表示");
				A_2.Items.Add(completionItem2);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0001BB00 File Offset: 0x00019D00
		internal static void <<EMPTY_NAME>>(CompletionSession A_0, bool A_1)
		{
			TreeView treeView = new TreeView();
			o0\u3000\u3000\u3000\u3000\u3002\u3002.O0Oo_o_._O0o_O.(treeView, "", null);
			try
			{
				foreach (object obj in treeView.Nodes)
				{
					TreeNode a_ = (TreeNode)obj;
					O_ooO0.O._OOo__.(A_0, a_, A_1);
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

		// Token: 0x06000463 RID: 1123 RVA: 0x0001BB70 File Offset: 0x00019D70
		private static void <<EMPTY_NAME>>(CompletionSession A_0, TreeNode A_1, bool A_2)
		{
			CompletionItem completionItem = new CompletionItem(new string(' ', A_1.Level * 3) + A_1.Text, new CommonImageSourceProvider(CommonImageKind.MethodPublic));
			completionItem.AutoCompletePreText = A_1.Text;
			if (!A_2)
			{
				completionItem.AutoCompletePreText = "\"" + A_1.Text + "\"";
			}
			A_0.Items.Add(completionItem);
			if (A_1.Nodes.Count == 0)
			{
				DataRow dataRow = null;
				o0_O o0_O;
				if (A_1.Tag == null)
				{
					o0_O = o0_O.O.00oOo0o.;
				}
				else
				{
					dataRow = (DataRow)A_1.Tag;
					o0_O = (o0_O)Conversions.ToInteger(dataRow["Type"]);
				}
				if (o0_O == o0_O.ooooo0._OOOo_. && dataRow != null)
				{
					completionItem.Tag = "fuction_" + dataRow["Name"].ToString();
					return;
				}
			}
			else
			{
				completionItem.ImageSourceProvider = new CommonImageSourceProvider(CommonImageKind.FolderClosed);
				completionItem.AutoCompletePreText = "";
				try
				{
					foreach (object obj in A_1.Nodes)
					{
						TreeNode a_ = (TreeNode)obj;
						O_ooO0.O._OOo__.(A_0, a_, A_2);
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
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0001BCAC File Offset: 0x00019EAC
		internal static void <<EMPTY_NAME>>(string A_0, CompletionSession A_1, bool A_2)
		{
			if (OO_00oOO.Tables.get_Contains(A_0))
			{
				try
				{
					foreach (Col col in OO_00oOO.Tables[A_0].Cols)
					{
						CompletionItem completionItem = new CompletionItem(col.Name, new CommonImageSourceProvider(CommonImageKind.MethodPublic));
						if (Operators.CompareString(col.Caption, "", true) > 0 && Operators.CompareString(col.Caption, col.Name, true) != 0)
						{
							completionItem.DescriptionProvider = new PlainTextContentProvider(col.Caption);
						}
						if (!A_2)
						{
							completionItem.AutoCompletePreText = "\"" + col.Name + "\"";
						}
						completionItem.InlineDescription = O_ooO0.O__o.O000.(col.DataCol.BaseColumn.DataType.Name);
						A_1.Items.Add(completionItem);
					}
					return;
				}
				finally
				{
					IEnumerator<Col> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			o\u3002\u3002\u3000\u3000\u3002 o_u3002_u3002_u3000_u3000_u = null;
			try
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					if (form is o\u3002\u3002\u3000\u3000\u3002)
					{
						o_u3002_u3002_u3000_u3000_u = (o\u3002\u3002\u3000\u3000\u3002)form;
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
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
							if (tableGridProperty.TableType != TableTypeEnum.Normal || !tableGridProperty.IsCopy)
							{
								goto IL_286;
							}
							string relationTable = tableGridProperty.RelationTable;
							if (OO_00oOO.Tables.get_Contains(relationTable))
							{
								try
								{
									foreach (Col col2 in OO_00oOO.Tables[relationTable].Cols)
									{
										CompletionItem completionItem2 = new CompletionItem(col2.Name, new CommonImageSourceProvider(CommonImageKind.MethodPublic));
										if (Operators.CompareString(col2.Caption, "", true) > 0 && Operators.CompareString(col2.Caption, col2.Name, true) != 0)
										{
											completionItem2.DescriptionProvider = new PlainTextContentProvider(col2.Caption);
										}
										if (!A_2)
										{
											completionItem2.AutoCompletePreText = "\"" + col2.Name + "\"";
										}
										completionItem2.InlineDescription = O_ooO0.O__o.O000.(col2.DataCol.BaseColumn.DataType.Name);
										A_1.Items.Add(completionItem2);
									}
									continue;
								}
								finally
								{
									IEnumerator<Col> enumerator4;
									if (enumerator4 != null)
									{
										enumerator4.Dispose();
									}
								}
								goto IL_286;
							}
							continue;
							IL_286:
							if (tableGridProperty.TableType == TableTypeEnum.SQLQuery || tableGridProperty.TableType == TableTypeEnum.SQLTable)
							{
								string key = o_u3002_u3002_u3000_u3000_u.o_0O.OO0_0_.["Name"].ToString() + "_" + tableGridProperty.Name;
								O\u3000\u3002\u3000\u3000 o_u3000_u3002_u3000_u = null;
								List<string> list = null;
								if (Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
								{
									o_u3000_u3002_u3000_u = (O\u3000\u3002\u3000\u3000)Form.ActiveForm;
									if (o_u3000_u3002_u3000_u.O0oO0_O0.O..ContainsKey(key))
									{
										list = o_u3000_u3002_u3000_u.O0oO0_O0.O.[key];
									}
								}
								if (list == null)
								{
									list = new List<string>();
									SQLCommand sqlcommand = new SQLCommand();
									sqlcommand.CommandText = tableGridProperty.SelectString;
									sqlcommand.ConnectionName = tableGridProperty.Connection;
									try
									{
										DataTable dataTable = sqlcommand.OO__00.__.();
										try
										{
											foreach (DataCol dataCol in dataTable.DataCols)
											{
												list.Add(dataCol.Name + "\t" + O_ooO0.O__o.O000.(dataCol.BaseColumn.DataType.Name));
											}
										}
										finally
										{
											IEnumerator<DataCol> enumerator5;
											if (enumerator5 != null)
											{
												enumerator5.Dispose();
											}
										}
									}
									catch (Exception ex)
									{
										break;
									}
									if (o_u3000_u3002_u3000_u != null)
									{
										o_u3000_u3002_u3000_u.O0oO0_O0.O.[key] = list;
									}
								}
								try
								{
									foreach (string text in list)
									{
										string[] array = text.Split(new char[]
										{
											'\t'
										});
										if (array.Length == 2)
										{
											CompletionItem completionItem3 = new CompletionItem(array[0], new CommonImageSourceProvider(CommonImageKind.MethodPublic));
											if (!A_2)
											{
												completionItem3.AutoCompletePreText = "\"" + array[0] + "\"";
											}
											completionItem3.InlineDescription = array[1];
											A_1.Items.Add(completionItem3);
										}
									}
								}
								finally
								{
									List<string>.Enumerator enumerator6;
									((IDisposable)enumerator6).Dispose();
								}
							}
						}
					}
				}
				finally
				{
					Dictionary<string, PropertyBase>.ValueCollection.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0001C1DC File Offset: 0x0001A3DC
		internal static string <<EMPTY_NAME>>(ITextSnapshotReader A_0, CompletionSession A_1, IEditorView A_2)
		{
			int offset = A_0.Offset;
			int offset2 = A_0.Offset;
			ITextSnapshotLine textSnapshotLine = A_0.SnapshotLine;
			IToken token = A_0.PeekToken();
			string result;
			if (token != null)
			{
				if (token.StartOffset <= A_0.SnapshotLine.FirstNonWhitespaceCharacterOffset)
				{
					result = "";
				}
				else
				{
					bool flag = token.Id == 11028;
					A_0.Offset = textSnapshotLine.FirstNonWhitespaceCharacterOffset;
					IToken token2 = A_0.ReadToken();
					if (token2 != null && token2.Id == 11074 && token2.EndOffset < token.StartOffset)
					{
						SwitchStatement switchStatement = O_ooO0.O__o.O000.(A_0.Snapshot, offset);
						if (switchStatement != null && switchStatement.StartOffset != null)
						{
							A_0.Offset = switchStatement.StartOffset.Value;
							A_0.GoToCurrentSnapshotLineEnd();
							while (!A_0.IsAtSnapshotLineStart)
							{
								token2 = A_0.ReadTokenReverse();
								if (token2 == null)
								{
									return "";
								}
								if (token2.Id == 11033)
								{
									IDotNetContext dotNetContext = new VBContextFactory().CreateContext(new TextSnapshotOffset(A_0.Snapshot, token2.StartOffset + 1), DotNetContextKind.Self);
									dotNetContext.Resolve();
									if (dotNetContext.TargetExpression != null && dotNetContext.TargetExpression.StartOffset != null)
									{
										string substring = A_0.Snapshot.GetSubstring(dotNetContext.TargetExpression.StartOffset.Value, dotNetContext.TargetExpression.Length);
										if (Operators.CompareString(substring, "e.col.name", true) == 0 || Operators.CompareString(substring, "e.datacol.name", true) == 0)
										{
											if (Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
											{
												string text = O_ooO0.O__o.O000.(A_0, offset2, A_1);
												if (A_1 != null && Operators.CompareString(text, "", true) > 0)
												{
													O_ooO0.O._OOo__.(text, A_1, flag);
												}
												return "Cols";
											}
										}
										else
										{
											if (Operators.CompareString(substring, "e.table.name", true) == 0)
											{
												return "Tables";
											}
											if (Operators.CompareString(substring, "e.datatable.name", true) == 0)
											{
												return "DataTables";
											}
											if (Operators.CompareString(substring, "e.StripItem.Name", true) == 0)
											{
												if (A_1 != null)
												{
													O_ooO0.o_o_00oo._.(A_1, flag);
												}
												return "StripItems";
											}
											if (Operators.CompareString(substring, "e.Link.Name", true) == 0)
											{
												if (A_1 != null)
												{
													O_ooO0.OO.o_00O.(A_1, flag);
												}
												return "topiclinks";
											}
											if (Operators.CompareString(substring, "e.Page.Name", true) == 0)
											{
												if (A_1 != null)
												{
													O_ooO0.o00Ooo_0OO.0_.(A_1, flag);
												}
												return "topicpages";
											}
											if (Operators.CompareString(substring, "e.Strip.Name", true) == 0)
											{
												return "Strips";
											}
										}
									}
								}
							}
						}
					}
					A_0.Offset = offset;
					token2 = A_0.ReadTokenReverse();
					if (token2 != null && token2.Id == 11003)
					{
						int offset3 = A_0.Offset;
						string text2 = O_ooO0.O__o.O000.(A_0, token2, A_1, flag);
						if (Operators.CompareString(text2, "", true) > 0)
						{
							return text2;
						}
						A_0.Offset = offset3;
					}
					else
					{
						if (token2 != null && token2.Id == 11000)
						{
							token2 = A_0.ReadTokenReverse();
						}
						if (token2 != null && token2.Id == 11225)
						{
							IToken token3 = A_0.PeekTokenReverse();
							if (token3 != null && token3.Id == 11000)
							{
								token2 = A_0.ReadTokenReverse();
							}
							IDotNetContext dotNetContext2 = new VBContextFactory().CreateContext(new TextSnapshotOffset(A_0.Snapshot, token2.StartOffset), DotNetContextKind.Self);
							dotNetContext2.Resolve();
							if (dotNetContext2.TargetExpression != null && dotNetContext2.TargetExpression.StartOffset != null)
							{
								string substring2 = A_0.Snapshot.GetSubstring(dotNetContext2.TargetExpression.StartOffset.Value, dotNetContext2.TargetExpression.Length);
								if (Operators.CompareString(substring2, "e.datacol.name", true) == 0 || Operators.CompareString(substring2, "e.col.name", true) == 0)
								{
									if (Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
									{
										string text3 = O_ooO0.O__o.O000.(A_0, offset2, A_1);
										if (A_1 != null && Operators.CompareString(text3, "", true) > 0)
										{
											O_ooO0.O._OOo__.(text3, A_1, flag);
										}
										return "Cols";
									}
								}
								else
								{
									if (Operators.CompareString(substring2, "e.table.name", true) == 0)
									{
										return "Tables";
									}
									if (Operators.CompareString(substring2, "e.datatable.name", true) == 0)
									{
										return "DataTables";
									}
									if (Operators.CompareString(substring2, "e.StripItem.Name", true) == 0)
									{
										if (A_1 != null)
										{
											O_ooO0.o_o_00oo._.(A_1, flag);
										}
										return "StripItems";
									}
									if (Operators.CompareString(substring2, "e.Link.Name", true) == 0)
									{
										if (A_1 != null)
										{
											O_ooO0.OO.o_00O.(A_1, flag);
										}
										return "topiclinks";
									}
									if (Operators.CompareString(substring2, "e.Page.Name", true) == 0)
									{
										if (A_1 != null)
										{
											O_ooO0.o00Ooo_0OO.0_.(A_1, flag);
										}
										return "topicpages";
									}
									if (Operators.CompareString(substring2, "e.Strip.Name", true) == 0)
									{
										return "Strips";
									}
									if (substring2.EndsWith(".ConnectionName", StringComparison.OrdinalIgnoreCase))
									{
										return "Connections";
									}
								}
							}
						}
					}
					bool flag2 = false;
					string a_ = "";
					if (token2 != null && token2.Id == 11010)
					{
						int offset4 = A_0.Offset;
						IToken token4 = token2;
						token2 = A_0.ReadTokenReverse();
						if (token2 != null && token2.Id == 11004 && A_0.GoToPreviousMatchingTokenById(11004, 11003))
						{
							IToken token5 = A_0.PeekTokenReverse();
							token2 = A_0.ReadToken();
							IToken token6 = A_0.PeekToken();
							if (token6 != null && token6.Id == 11028)
							{
								IResolverResultSet resolverResultSet = new VBContextFactory().CreateContext(new TextSnapshotOffset(A_0.Snapshot, token5.EndOffset - 1), DotNetContextKind.Self).Resolve();
								if (resolverResultSet.Results.Count > 0)
								{
									string left = "";
									if (resolverResultSet.Results[0] is IVariableResolverResult)
									{
										if (((IVariableResolverResult)resolverResultSet.Results[0]).TypeIsInstance && ((IVariableResolverResult)resolverResultSet.Results[0]).Type != null && ((IVariableResolverResult)resolverResultSet.Results[0]).Type.IsTypeDefinition)
										{
											left = ((ITypeDefinition)((IVariableResolverResult)resolverResultSet.Results[0]).Type).FullName;
										}
									}
									else if (resolverResultSet.Results[0] is ITypeMemberResolverResult)
									{
										left = ((ITypeMemberResolverResult)resolverResultSet.Results[0]).Member.DeclaringType.FullName;
									}
									if (Operators.CompareString(left, "Foxtable.Row", true) == 0 || Operators.CompareString(left, "Foxtable.DataRow", true) == 0)
									{
										flag2 = true;
										a_ = A_0.Snapshot.GetSubstring(token6.TextRange).Trim(new char[]
										{
											'"'
										});
									}
								}
							}
						}
						if (!flag2)
						{
							A_0.Offset = offset4;
							token2 = token4;
						}
					}
					if (token2 != null && token2.Id == 11003)
					{
						token2 = A_0.ReadTokenReverse();
						if (token2 != null)
						{
							if (token2.Id == 11004)
							{
								if (A_0.GoToPreviousMatchingTokenById(11004, 11003))
								{
									token2 = A_0.ReadTokenReverse();
								}
							}
							else if (token2.Id == 11033)
							{
								string substring3 = A_0.Snapshot.GetSubstring(token2.TextRange);
								if (Operators.CompareString(substring3, "GetParentrow", true) == 0 || Operators.CompareString(substring3, "GetParentRows", true) == 0 || Operators.CompareString(substring3, "GetChildRows", true) == 0)
								{
									return "DataTables";
								}
								if (Operators.CompareString(substring3, "isnull", true) == 0 || Operators.CompareString(substring3, "lines", true) == 0)
								{
									token2 = A_0.ReadTokenReverse();
									if (token2 != null && token2.Id == 11010)
									{
										token2 = A_0.ReadTokenReverse();
									}
								}
							}
							else if (token2.Id == 11003)
							{
								token2 = A_0.ReadTokenReverse();
							}
						}
						if (token2 == null)
						{
							return "";
						}
						string substring4 = A_0.Snapshot.GetSubstring(token2.TextRange);
						if (Operators.CompareString(substring4, "GetParentRow", true) == 0)
						{
							token2 = A_0.ReadTokenReverse();
							if (token2 != null && token2.Id == 11010)
							{
								token2 = A_0.ReadTokenReverse();
								if (token2 != null)
								{
									substring4 = A_0.Snapshot.GetSubstring(token2.TextRange);
								}
							}
						}
						if (token2 != null && (Operators.CompareString(substring4, "Execute", true) == 0 || Operators.CompareString(substring4, "ExecuteAsync", true) == 0 || Operators.CompareString(substring4, "AsyncExecute", true) == 0 || Operators.CompareString(substring4, "SyncExecute", true) == 0 || Operators.CompareString(substring4, "BeginSyncExecute", true) == 0))
						{
							token2 = A_0.ReadTokenReverse();
							if (token2 != null && token2.Id == 11010)
							{
								token2 = A_0.ReadTokenReverse();
								if (token2 != null && Operators.CompareString(A_0.Snapshot.GetSubstring(token2.TextRange), "Functions", true) == 0)
								{
									return "Functions";
								}
							}
						}
						else
						{
							if (token2 != null && Operators.CompareString(substring4, "Tables", true) == 0)
							{
								return "Tables";
							}
							if (token2 != null && Operators.CompareString(substring4, "DataTables", true) == 0)
							{
								return "DataTables";
							}
							if (token2 != null && Operators.CompareString(substring4, "Forms", true) == 0)
							{
								return "Forms";
							}
							if (token2 != null && Operators.CompareString(substring4, "Vars", true) == 0)
							{
								return "Vars";
							}
							if (token2 != null && Operators.CompareString(substring4, "MyTimers", true) == 0)
							{
								return "MyTimers";
							}
							if (token2 != null && Operators.CompareString(substring4, "Connections", true) == 0)
							{
								return "Connections";
							}
							if (token2 != null && Operators.CompareString(substring4, "AddDef", true) == 0)
							{
								IToken token7 = O_ooO0.Oo_Oo0O._oOoO.(A_0);
								if (token7 != null && token7.Id == 11010)
								{
									A_0.ReadTokenReverse();
									token7 = O_ooO0.Oo_Oo0O._oOoO.(A_0);
									if (token7 != null && token7.Id == 11033)
									{
										string substring5 = A_0.Snapshot.GetSubstring(token7.TextRange);
										if (Operators.CompareString(substring5, "Groups", true) == 0 || Operators.CompareString(substring5, "Totals", true) == 0 || Operators.CompareString(substring5, "HGroups", true) == 0 || Operators.CompareString(substring5, "VGroups", true) == 0)
										{
											IToken token8 = O_ooO0.OO00_._00o.(A_0);
											if (token8 != null && token8.Id == 11033)
											{
												string substring6 = A_0.Snapshot.GetSubstring(token8.TextRange);
												O_ooO0.O__o.O000..FindText = substring6 + "[\\s]+(as|=)[\\s]+new[\\s]+(CrossTableBuilder|GroupTableBuilder)\\(\\\"[\\w\\u4e00-\\u9fa5]+\\\"\\s*\\,\\s*DaTaTables\\(\\\"([\\w\\u4e00-\\u9fa5]+)\\\"\\)\\)";
												ISearchResultSet searchResultSet = A_0.Snapshot.FindNext(O_ooO0.O__o.O000., A_0.Offset, false);
												if (searchResultSet.Results.Count > 0)
												{
													string text4 = searchResultSet.Results[0].Captures[3].Text;
													if (A_1 != null && Operators.CompareString(text4, "", true) > 0)
													{
														O_ooO0.O._OOo__.(text4, A_1, flag);
													}
													return "Cols";
												}
												O_ooO0.O__o.O000..FindText = substring6 + "[\\s]+(as|=)[\\s]+new[\\s]+(SQLCrossTableBuilder|SQLGroupTableBuilder)\\(\\\"[\\w\\u4e00-\\u9fa5]+\\\"\\s*\\,\\s*\\\"([\\w\\u4e00-\\u9fa5]+)\\\"\\)";
												searchResultSet = A_0.Snapshot.FindNext(O_ooO0.O__o.O000., A_0.Offset, false);
												if (searchResultSet.Results.Count > 0)
												{
													string text5 = searchResultSet.Results[0].Captures[3].Text;
													List<string> list = new List<string>();
													string text6 = "";
													if (!flag)
													{
														text6 = "\"";
													}
													if (A_1 != null && Operators.CompareString(text5, "", true) > 0)
													{
														list.Add(text5);
														O_ooO0.O__o.O000..FindText = "(?<=" + substring6 + "\\.AddTable\\()(\\\"[\\w\\u4e00-\\u9fa5]+\\\"\\s*,\\s*){2}(\\\"[\\w\\u4e00-\\u9fa5]+\\\"\\s*),";
														O_ooO0.O__o.O000..MaximumResultCount = 6;
														searchResultSet = A_0.Snapshot.FindAll(O_ooO0.O__o.O000., new TextRange(searchResultSet.Results[0].TextRange.EndOffset, A_0.Offset));
														if (searchResultSet.Results.Count > 0)
														{
															int num = searchResultSet.Results.Count - 1;
															for (int i = 0; i <= num; i++)
															{
																list.Add(searchResultSet.Results[i].Captures[2].Text.Trim(new char[]
																{
																	'"'
																}));
															}
														}
														if (list.Count == 1)
														{
															O_ooO0.O._OOo__.(text5, A_1, flag);
														}
														else
														{
															try
															{
																List<string>.Enumerator enumerator = list.GetEnumerator();
																while (enumerator.MoveNext())
																{
																	text5 = enumerator.Current;
																	CompletionSession completionSession = new CompletionSession();
																	O_ooO0.O._OOo__.(text5, completionSession, flag);
																	if (completionSession.Items.Count != 0)
																	{
																		try
																		{
																			foreach (ICompletionItem completionItem in completionSession.Items)
																			{
																				CompletionItem completionItem2 = (CompletionItem)completionItem;
																				completionItem2.Tag = text5;
																				completionItem2.Text = "   " + completionItem2.Text;
																				try
																				{
																					foreach (ICompletionItem completionItem3 in A_1.Items)
																					{
																						CompletionItem completionItem4 = (CompletionItem)completionItem3;
																						if (Operators.CompareString(completionItem2.Text.Trim(), completionItem4.Text.Trim(), true) == 0)
																						{
																							completionItem2.AutoCompletePreText = string.Concat(new string[]
																							{
																								text6,
																								"{",
																								text5,
																								"}.",
																								completionItem2.Text.Trim().Trim(new char[]
																								{
																									'"'
																								}),
																								text6
																							});
																							completionItem4.AutoCompletePreText = string.Concat(new string[]
																							{
																								text6,
																								"{",
																								completionItem4.Tag.ToString(),
																								"}.",
																								completionItem4.Text.Trim().Trim(new char[]
																								{
																									'"'
																								}),
																								text6
																							});
																						}
																					}
																				}
																				finally
																				{
																					IEnumerator<ICompletionItem> enumerator3;
																					if (enumerator3 != null)
																					{
																						enumerator3.Dispose();
																					}
																				}
																			}
																		}
																		finally
																		{
																			IEnumerator<ICompletionItem> enumerator2;
																			if (enumerator2 != null)
																			{
																				enumerator2.Dispose();
																			}
																		}
																		CompletionItem completionItem5 = new CompletionItem(text5, new CommonImageSourceProvider(CommonImageKind.MethodPublic));
																		completionItem5.AutoCompletePreText = text6 + text5 + text6;
																		A_1.Items.Add(completionItem5);
																		List<ICompletionItem> list2 = new List<ICompletionItem>();
																		list2.AddRange(completionSession.Items);
																		completionSession.Items.Clear();
																		try
																		{
																			foreach (ICompletionItem completionItem6 in list2)
																			{
																				CompletionItem item = (CompletionItem)completionItem6;
																				A_1.Items.Add(item);
																			}
																		}
																		finally
																		{
																			List<ICompletionItem>.Enumerator enumerator4;
																			((IDisposable)enumerator4).Dispose();
																		}
																	}
																}
															}
															finally
															{
																List<string>.Enumerator enumerator;
																((IDisposable)enumerator).Dispose();
															}
														}
													}
													return "Cols";
												}
											}
										}
									}
								}
							}
							else if (token2 != null && Operators.CompareString(substring4, "Controls", true) == 0)
							{
								if (A_1 == null)
								{
									return "Controls";
								}
								DataRow dataRow = null;
								token2 = A_0.ReadTokenReverse();
								if (token2 != null && token2.Id == 11010)
								{
									token2 = A_0.ReadTokenReverse();
									if (token2 != null && token2.Id == 11033)
									{
										if (Operators.CompareString(A_0.Snapshot.GetSubstring(token2.TextRange), "form", true) == 0)
										{
											token2 = A_0.ReadTokenReverse();
											if (token2 == null || token2.Id != 11010)
											{
												goto IL_12FB;
											}
											token2 = A_0.ReadTokenReverse();
											if (token2 == null || token2.Id != 11033 || Operators.CompareString(A_0.Snapshot.GetSubstring(token2.TextRange), "e", true) != 0)
											{
												goto IL_12FB;
											}
											try
											{
												foreach (object obj in Application.OpenForms)
												{
													Form form = (Form)obj;
													if (form is o\u3002\u3002\u3000\u3000\u3002)
													{
														dataRow = ((o\u3002\u3002\u3000\u3000\u3002)form).o_0O.OO0_0_.;
														break;
													}
												}
												goto IL_12FB;
											}
											finally
											{
												IEnumerator enumerator5;
												if (enumerator5 is IDisposable)
												{
													(enumerator5 as IDisposable).Dispose();
												}
											}
										}
										string substring7 = A_0.Snapshot.GetSubstring(token2.TextRange);
										string text7 = "";
										O_ooO0.O__o.O000..FindText = "dim[\\s]+" + substring7 + "[\\s]+As[\\s]+winform[.]form\\s*=\\s*forms\\(\\\"([\\w\\u4e00-\\u9fa5]+)\\\"\\)";
										ISearchResultSet searchResultSet2 = A_0.Snapshot.FindNext(O_ooO0.O__o.O000., A_0.Offset, false);
										if (searchResultSet2.Results.Count > 0)
										{
											text7 = searchResultSet2.Results[0].Captures[1].Text;
										}
										else
										{
											O_ooO0.O__o.O000..FindText = substring7 + "[\\s]*=[\\s]*forms\\(\\\"([\\w\\u4e00-\\u9fa5]+)\\\"\\)";
											searchResultSet2 = A_0.Snapshot.FindNext(O_ooO0.O__o.O000., A_0.Offset, false);
											if (searchResultSet2.Results.Count > 0)
											{
												text7 = searchResultSet2.Results[0].Captures[1].Text;
											}
										}
										if (Operators.CompareString(text7, "", true) <= 0)
										{
											goto IL_12FB;
										}
										try
										{
											foreach (object obj2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()].Rows)
											{
												DataRow dataRow2 = (DataRow)obj2;
												if (Operators.CompareString(dataRow2["Name"].ToString(), text7, true) == 0 && Conversions.ToInteger(dataRow2["Type"]) == 229)
												{
													dataRow = dataRow2;
													break;
												}
											}
											goto IL_12FB;
										}
										finally
										{
											IEnumerator enumerator6;
											if (enumerator6 is IDisposable)
											{
												(enumerator6 as IDisposable).Dispose();
											}
										}
									}
									if (token2 != null && token2.Id == 11004)
									{
										int startOffset = token2.StartOffset;
										if (A_0.GoToPreviousMatchingTokenById(11004, 11003))
										{
											offset = A_0.Offset;
											A_0.Offset++;
											IToken token9 = A_0.ReadToken();
											if (token9.Id == 11028 && token9.EndOffset == startOffset)
											{
												string right = A_0.Snapshot.GetSubstring(token9.TextRange).Trim().Trim(new char[]
												{
													'"'
												});
												A_0.Offset = offset;
												token2 = A_0.ReadTokenReverse();
												if (token2 != null && token2.Id == 11033 && Operators.CompareString(A_0.Snapshot.GetSubstring(token2.TextRange), "Forms", true) == 0)
												{
													try
													{
														foreach (object obj3 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()].Rows)
														{
															DataRow dataRow3 = (DataRow)obj3;
															if (Operators.CompareString(dataRow3["Name"].ToString(), right, true) == 0 && Conversions.ToInteger(dataRow3["Type"]) == 229)
															{
																dataRow = dataRow3;
																break;
															}
														}
													}
													finally
													{
														IEnumerator enumerator7;
														if (enumerator7 is IDisposable)
														{
															(enumerator7 as IDisposable).Dispose();
														}
													}
												}
											}
										}
									}
								}
								IL_12FB:
								if (dataRow != null && A_1 != null)
								{
									O_ooO0.o.o__O_.(dataRow, A_1, flag);
									return "Controls";
								}
							}
							else if (token2 != null && (Operators.CompareString(substring4, "Cols", true) == 0 || Operators.CompareString(substring4, "DataCols", true) == 0 || Operators.CompareString(substring4, "Rows", true) == 0 || Operators.CompareString(substring4, "DataRows", true) == 0 || Operators.CompareString(substring4, "Row", true) == 0 || Operators.CompareString(substring4, "DataRow", true) == 0 || Operators.CompareString(substring4, "current", true) == 0 || Operators.CompareString(substring4, "GetComboListString", true) == 0 || Operators.CompareString(substring4, "GetValues", true) == 0 || Operators.CompareString(substring4, "SQLGetComboListString", true) == 0 || Operators.CompareString(substring4, "SQLGetValues", true) == 0))
							{
								token2 = A_0.ReadTokenReverse();
								string text8 = "";
								if (token2 != null && token2.Id == 11010)
								{
									if (token2.StartOffset == A_0.SnapshotLine.FirstNonWhitespaceCharacterOffset)
									{
										WithStatement withStatement = O_ooO0.o.o__O_.(A_0.Snapshot, token2.StartOffset);
										if (withStatement != null)
										{
											string text9 = "";
											if (withStatement.Expression is SimpleName)
											{
												text9 = ((SimpleName)withStatement.Expression).Text.Trim();
											}
											else if (withStatement.Expression is InvocationExpression)
											{
												InvocationExpression invocationExpression = (InvocationExpression)withStatement.Expression;
												if (invocationExpression.StartOffset != null)
												{
													text9 = A_0.Snapshot.GetSubstring(invocationExpression.StartOffset.Value, invocationExpression.Length);
												}
											}
											if (Operators.CompareString(text9, "CurrentTable", true) == 0)
											{
												text8 = OO_00oOO.CurrentTable.DataTable.Name;
											}
											else if (Operators.CompareString(text9, "MainTable", true) == 0)
											{
												text8 = OO_00oOO.MainTable.DataTable.Name;
											}
											else if (text9.StartsWith("DataTables", StringComparison.OrdinalIgnoreCase) || text9.StartsWith("Tables", StringComparison.OrdinalIgnoreCase))
											{
												int num2 = text9.IndexOf("\"");
												int num3 = text9.LastIndexOf("\"");
												if (num2 > 0 && num3 > num2)
												{
													text8 = text9.Substring(num2 + 1, num3 - num2 - 1);
												}
											}
										}
									}
									else
									{
										token2 = A_0.ReadTokenReverse();
										if (token2 != null && token2.Id == 11033)
										{
											string substring8 = A_0.Snapshot.GetSubstring(token2.TextRange);
											if (Operators.CompareString(substring8, "Table", true) == 0 || Operators.CompareString(substring8, "DataTable", true) == 0)
											{
												token2 = A_0.ReadTokenReverse();
												if (token2 != null && token2.Id == 11010)
												{
													token2 = A_0.ReadTokenReverse();
													if (token2 != null && token2.Id == 11033 && Operators.CompareString(A_0.Snapshot.GetSubstring(token2.TextRange), "e", true) == 0 && Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
													{
														text8 = O_ooO0.O__o.O000.(A_0, offset2, A_1);
													}
												}
											}
											else if (Operators.CompareString(substring8, "CurrentTable", true) == 0)
											{
												text8 = OO_00oOO.CurrentTable.DataTable.Name;
											}
											else if (Operators.CompareString(substring8, "MainTable", true) == 0)
											{
												text8 = OO_00oOO.MainTable.DataTable.Name;
											}
											else if (Operators.CompareString(substring8, "e", true) == 0 && (Operators.CompareString(substring4, "Row", true) == 0 || Operators.CompareString(substring4, "DataRow", true) == 0))
											{
												if (Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
												{
													text8 = O_ooO0.O__o.O000.(A_0, offset2, A_1);
												}
											}
											else
											{
												string text10 = substring8;
												O_ooO0.O__o.O000..FindText = text10 + "[\\s]+=[\\s]*(Tables|DataTables|MainTable|CurrentTable|e\\.)";
												ISearchResultSet searchResultSet3 = A_0.Snapshot.FindNext(O_ooO0.O__o.O000., A_0.Offset, false);
												if (searchResultSet3.Results.Count == 0)
												{
													O_ooO0.O__o.O000..FindText = "dim[\\s]+" + text10 + "[\\s]+As[\\s]+[\\w]+[\\s]+=[\\s]*(Tables|DataTables|MainTable|CurrentTable|e\\.)";
													searchResultSet3 = A_0.Snapshot.FindNext(O_ooO0.O__o.O000., A_0.Offset, false);
												}
												if (searchResultSet3.Results.Count > 0 && searchResultSet3.Results[0].Captures.Count == 2)
												{
													ISearchCapture searchCapture = searchResultSet3.Results[0].Captures[1];
													if (Operators.CompareString(searchCapture.Text, "MainTable", true) == 0)
													{
														text8 = OO_00oOO.MainTable.DataTable.Name;
													}
													else if (Operators.CompareString(searchCapture.Text, "CurrentTable", true) == 0)
													{
														text8 = OO_00oOO.CurrentTable.DataTable.Name;
													}
													else if (Operators.CompareString(searchCapture.Text, "e.", true) == 0)
													{
														if (Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
														{
															text8 = O_ooO0.O__o.O000.(A_0, offset2, A_1);
														}
													}
													else
													{
														A_0.Offset = searchResultSet3.Results[0].FindSnapshotRange.EndOffset;
														token2 = A_0.ReadToken();
														if (token2 != null && token2.Id == 11003)
														{
															token2 = A_0.ReadToken();
															if (token2 != null && token2.Id == 11028)
															{
																text8 = A_0.Snapshot.GetSubstring(token2.TextRange).Trim(new char[]
																{
																	'"'
																});
															}
														}
													}
												}
											}
										}
										else if (token2 != null && token2.Id == 11004 && (Operators.CompareString(substring4, "Cols", true) == 0 || Operators.CompareString(substring4, "DataCols", true) == 0 || Operators.CompareString(substring4, "Rows", true) == 0 || Operators.CompareString(substring4, "DataRows", true) == 0 || Operators.CompareString(substring4, "current", true) == 0 || Operators.CompareString(substring4, "GetComboListString", true) == 0 || Operators.CompareString(substring4, "GetValues", true) == 0 || Operators.CompareString(substring4, "SQLGetComboListString", true) == 0 || Operators.CompareString(substring4, "SQLGetValues", true) == 0))
										{
											int startOffset2 = token2.StartOffset;
											if (A_0.GoToPreviousMatchingTokenById(11004, 11003))
											{
												offset = A_0.Offset;
												A_0.Offset++;
												IToken token10 = A_0.ReadToken();
												if (token10.Id == 11028 && token10.EndOffset == startOffset2)
												{
													string text11 = A_0.Snapshot.GetSubstring(token10.TextRange).Trim().Trim(new char[]
													{
														'"'
													});
													A_0.Offset = offset;
													token2 = A_0.ReadTokenReverse();
													if (token2 != null && token2.Id == 11033)
													{
														string substring9 = A_0.Snapshot.GetSubstring(token2.TextRange);
														if (Operators.CompareString(substring9, "Tables", true) == 0 || Operators.CompareString(substring9, "DataTables", true) == 0)
														{
															text8 = text11;
														}
													}
												}
											}
										}
									}
								}
								if (Operators.CompareString(text8, "", true) > 0)
								{
									if (A_1 != null)
									{
										text8 = O_ooO0.o.o__O_.(A_0, text8);
										if (flag2)
										{
											O_ooO0.O._OOo__.(text8, a_, A_1);
										}
										else
										{
											O_ooO0.O._OOo__.(text8, A_1, flag);
										}
									}
									return "Cols";
								}
							}
							else
							{
								IDotNetContext dotNetContext3 = new VBContextFactory().CreateContext(new TextSnapshotOffset(A_0.Snapshot, token2.StartOffset), DotNetContextKind.Self);
								IResolverResultSet resolverResultSet2 = dotNetContext3.Resolve();
								if (resolverResultSet2.Results.Count > 0)
								{
									string left2 = "";
									if (resolverResultSet2.Results[0] is IVariableResolverResult)
									{
										if (((IVariableResolverResult)resolverResultSet2.Results[0]).TypeIsInstance && ((IVariableResolverResult)resolverResultSet2.Results[0]).Type != null && ((IVariableResolverResult)resolverResultSet2.Results[0]).Type.IsTypeDefinition)
										{
											left2 = ((ITypeDefinition)((IVariableResolverResult)resolverResultSet2.Results[0]).Type).FullName;
										}
									}
									else if (resolverResultSet2.Results[0] is ITypeMemberResolverResult)
									{
										left2 = ((ITypeMemberResolverResult)resolverResultSet2.Results[0]).Member.DeclaringType.FullName;
									}
									if (Operators.CompareString(left2, "Foxtable.StripCollection", true) == 0)
									{
										if (A_0.Snapshot.GetSubstring(dotNetContext3.TargetExpression.StartOffset.Value, token2.StartOffset - dotNetContext3.TargetExpression.StartOffset.Value).StartsWith("e.form.", StringComparison.OrdinalIgnoreCase))
										{
											return "Strips";
										}
									}
									else if (Operators.CompareString(left2, "Foxtable.StripItemCollection", true) == 0)
									{
										string substring10 = A_0.Snapshot.GetSubstring(dotNetContext3.TargetExpression.StartOffset.Value, token2.StartOffset - dotNetContext3.TargetExpression.StartOffset.Value);
										if (substring10.StartsWith("e.form.", StringComparison.OrdinalIgnoreCase))
										{
											if (A_1 != null)
											{
												MatchCollection matchCollection = new Regex("(Strips|Items)\\(\"([\\w\\u4e00-\\u9fa5]+)\"\\)", RegexOptions.IgnoreCase).Matches(substring10);
												if (matchCollection.Count > 0)
												{
													try
													{
														foreach (object obj4 in Application.OpenForms)
														{
															Form form2 = (Form)obj4;
															if (form2 is o\u3000\u3002)
															{
																Dictionary<string, ToolStrip> o0__O.Oo0__. = ((o\u3000\u3002)form2).o0__O.Oo0__.;
																ToolStripItemCollection toolStripItemCollection = null;
																if (o0__O.Oo0__. != null)
																{
																	if (!o0__O.Oo0__..ContainsKey(matchCollection[0].Groups[2].Value))
																	{
																		return null;
																	}
																	toolStripItemCollection = o0__O.Oo0__.[matchCollection[0].Groups[2].Value].Items;
																	int num4 = matchCollection.Count - 1;
																	for (int j = 1; j <= num4; j++)
																	{
																		if (!toolStripItemCollection.ContainsKey(matchCollection[j].Groups[2].Value))
																		{
																			return null;
																		}
																		ToolStripItem toolStripItem = toolStripItemCollection[matchCollection[j].Groups[2].Value];
																		if (!(toolStripItem is ToolStripDropDownItem))
																		{
																			return null;
																		}
																		toolStripItemCollection = ((ToolStripDropDownItem)toolStripItem).DropDownItems;
																	}
																}
																if (toolStripItemCollection == null)
																{
																	break;
																}
																try
																{
																	foreach (object obj5 in toolStripItemCollection)
																	{
																		ToolStripItem toolStripItem2 = (ToolStripItem)obj5;
																		CompletionItem completionItem7 = new CompletionItem(toolStripItem2.Name, new CommonImageSourceProvider(CommonImageKind.FieldPublic));
																		if (!flag)
																		{
																			completionItem7.AutoCompletePreText = "\"" + toolStripItem2.Name + "\"";
																		}
																		A_1.Items.Add(completionItem7);
																	}
																	break;
																}
																finally
																{
																	IEnumerator enumerator9;
																	if (enumerator9 is IDisposable)
																	{
																		(enumerator9 as IDisposable).Dispose();
																	}
																}
															}
														}
													}
													finally
													{
														IEnumerator enumerator8;
														if (enumerator8 is IDisposable)
														{
															(enumerator8 as IDisposable).Dispose();
														}
													}
												}
											}
											return "StripItems";
										}
									}
									else if (Operators.CompareString(left2, "Foxtable.Row", true) == 0 || Operators.CompareString(left2, "Foxtable.DataRow", true) == 0)
									{
										int offset5 = A_0.Offset;
										A_0.SnapshotLine.Text.Trim();
										string text12 = "";
										string str = "";
										if (token2.Id == 11003)
										{
											token2 = A_0.PeekTokenReverse();
										}
										if (token2 != null && token2.Id == 11033)
										{
											str = A_0.Snapshot.GetSubstring(token2.TextRange);
										}
										O_ooO0.O__o.O000..FindText = "^[\\s]*" + str + "[\\s]+ =[\\s]*";
										ISearchResultSet searchResultSet4 = A_0.Snapshot.FindNext(O_ooO0.O__o.O000., A_0.Offset, false);
										if (searchResultSet4.Results.Count == 0)
										{
											O_ooO0.O__o.O000..FindText = "Dim[\\s]+" + str + "[\\s]+As[\\s]+[\\w]+[\\s]*=[\\s]*";
											searchResultSet4 = A_0.Snapshot.FindNext(O_ooO0.O__o.O000., A_0.Offset, false);
										}
										if (searchResultSet4.Results.Count == 0)
										{
											O_ooO0.O__o.O000..FindText = "for[\\s]+each[\\s]+" + str + "[\\s]+(as[\\s]+[\\w]+[\\s]+)?in[\\s+]";
											searchResultSet4 = A_0.Snapshot.FindNext(O_ooO0.O__o.O000., A_0.Offset, false);
										}
										if (searchResultSet4.Results.Count > 0)
										{
											ISearchResult searchResult = searchResultSet4.Results[0];
											TextSnapshotRange findSnapshotRange = searchResultSet4.Results[0].FindSnapshotRange;
											textSnapshotLine = findSnapshotRange.StartLine;
											A_0.Offset = searchResultSet4.Results[0].FindSnapshotRange.EndOffset;
											string substring11 = A_0.Snapshot.GetSubstring(findSnapshotRange.EndOffset, textSnapshotLine.EndOffset - findSnapshotRange.EndOffset);
											if (substring11.StartsWith("e.row", StringComparison.OrdinalIgnoreCase) || substring11.StartsWith("e.Datarow", StringComparison.OrdinalIgnoreCase))
											{
												if (Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
												{
													text12 = O_ooO0.O__o.O000.(A_0, offset2, A_1);
												}
											}
											else if (substring11.StartsWith("e.DataTable.", StringComparison.OrdinalIgnoreCase) || substring11.StartsWith("e.Table.", StringComparison.OrdinalIgnoreCase))
											{
												A_0.ReadToken();
												A_0.ReadToken();
												A_0.ReadToken();
												A_0.ReadToken();
												token2 = A_0.ReadToken();
												if (token2 != null && token2.Id == 11033)
												{
													string substring12 = A_0.Snapshot.GetSubstring(token2.TextRange);
													if ((Operators.CompareString(substring12, "Find", true) == 0 || Operators.CompareString(substring12, "FindRow", true) == 0 || Operators.CompareString(substring12, "Current", true) == 0 || Operators.CompareString(substring12, "Rows", true) == 0 || Operators.CompareString(substring12, "DataRows", true) == 0 || Operators.CompareString(substring12, "Select", true) == 0 || Operators.CompareString(substring12, "AddNew", true) == 0 || Operators.CompareString(substring12, "SQLFind", true) == 0 || Operators.CompareString(substring12, "SQLSelect", true) == 0) && Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
													{
														text12 = O_ooO0.O__o.O000.(A_0, offset2, A_1);
													}
												}
											}
											else if (substring11.StartsWith("MainTable.Current", StringComparison.OrdinalIgnoreCase) || substring11.StartsWith("MainTable.Rows(", StringComparison.OrdinalIgnoreCase))
											{
												text12 = OO_00oOO.MainTable.DataTable.Name;
											}
											else if (substring11.StartsWith("CurrentTable.Current", StringComparison.OrdinalIgnoreCase) || substring11.StartsWith("CurrentTable.Rows", StringComparison.OrdinalIgnoreCase))
											{
												text12 = OO_00oOO.CurrentTable.DataTable.Name;
											}
											else
											{
												token2 = A_0.ReadToken();
												if (token2 != null && token2.Id == 11033)
												{
													if (Operators.CompareString(A_0.Snapshot.GetSubstring(token2.TextRange), "DataTables", true) == 0 || Operators.CompareString(A_0.Snapshot.GetSubstring(token2.TextRange), "Tables", true) == 0)
													{
														token2 = A_0.ReadToken();
														if (token2 != null && token2.Id == 11003)
														{
															token2 = A_0.ReadToken();
															if (token2 != null && token2.Id == 11028)
															{
																string text13 = A_0.Snapshot.GetSubstring(token2.TextRange).Trim(new char[]
																{
																	'"'
																});
																token2 = A_0.ReadToken();
																if (token2 != null && token2.Id == 11004)
																{
																	token2 = A_0.ReadToken();
																	if (token2 != null && token2.Id == 11010)
																	{
																		token2 = A_0.ReadToken();
																		if (token2 != null && token2.Id == 11033)
																		{
																			string substring13 = A_0.Snapshot.GetSubstring(token2.TextRange);
																			if (Operators.CompareString(substring13, "Find", true) == 0 || Operators.CompareString(substring13, "FindRow", true) == 0 || Operators.CompareString(substring13, "Current", true) == 0 || Operators.CompareString(substring13, "Rows", true) == 0 || Operators.CompareString(substring13, "DataRows", true) == 0 || Operators.CompareString(substring13, "Select", true) == 0 || Operators.CompareString(substring13, "AddNew", true) == 0 || Operators.CompareString(substring13, "SQLFind", true) == 0 || Operators.CompareString(substring13, "SQLSelect", true) == 0)
																			{
																				text12 = text13;
																			}
																		}
																	}
																}
															}
														}
													}
													else
													{
														string substring14 = A_0.Snapshot.GetSubstring(token2.TextRange);
														O_ooO0.O__o.O000..FindText = substring14 + "[\\s]+=[\\s]*(Tables|DataTables|MainTable|CurrentTable|e\\.)";
														searchResultSet4 = A_0.Snapshot.FindNext(O_ooO0.O__o.O000., A_0.Offset, false);
														if (searchResultSet4.Results.Count == 0)
														{
															O_ooO0.O__o.O000..FindText = "dim[\\s]+" + substring14 + "[\\s]+As[\\s]+[\\w]+[\\s]+=[\\s]*(Tables|DataTables|MainTable|CurrentTable|e\\.)";
															searchResultSet4 = A_0.Snapshot.FindNext(O_ooO0.O__o.O000., A_0.Offset, false);
														}
														if (searchResultSet4.Results.Count > 0 && searchResultSet4.Results[0].Captures.Count == 2)
														{
															ISearchCapture searchCapture2 = searchResultSet4.Results[0].Captures[1];
															if (Operators.CompareString(searchCapture2.Text, "MainTable", true) == 0)
															{
																text12 = OO_00oOO.MainTable.DataTable.Name;
															}
															else if (Operators.CompareString(searchCapture2.Text, "CurrentTable", true) == 0)
															{
																text12 = OO_00oOO.CurrentTable.DataTable.Name;
															}
															else if (Operators.CompareString(searchCapture2.Text, "e.", true) == 0)
															{
																if (Form.ActiveForm != null && Form.ActiveForm is O\u3000\u3002\u3000\u3000)
																{
																	text12 = O_ooO0.O__o.O000.(A_0, offset2, A_1);
																}
															}
															else
															{
																A_0.Offset = searchResultSet4.Results[0].FindSnapshotRange.EndOffset;
																token2 = A_0.ReadToken();
																if (token2 != null && token2.Id == 11003)
																{
																	token2 = A_0.ReadToken();
																	if (token2 != null && token2.Id == 11028)
																	{
																		text12 = A_0.Snapshot.GetSubstring(token2.TextRange).Trim(new char[]
																		{
																			'"'
																		});
																	}
																}
															}
														}
													}
												}
											}
										}
										if (Operators.CompareString(text12, "", true) > 0)
										{
											if (A_1 != null)
											{
												if (flag2)
												{
													O_ooO0.O._OOo__.(text12, a_, A_1);
												}
												else
												{
													string left3 = text12;
													text12 = O_ooO0.o.o__O_.(A_0, text12);
													if (Operators.CompareString(left3, text12, true) == 0)
													{
														int index = A_0.SnapshotLine.Index;
														A_0.Offset = offset5;
														if (A_0.SnapshotLine.Index != index)
														{
															text12 = O_ooO0.o.o__O_.(A_0, text12);
														}
													}
													O_ooO0.O._OOo__.(text12, A_1, flag);
												}
											}
											return "Cols";
										}
									}
								}
							}
						}
					}
					result = "";
				}
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0001E864 File Offset: 0x0001CA64
		internal static void <<EMPTY_NAME>>(DataRow A_0, CompletionSession A_1, bool A_2)
		{
			foreach (DataRow dataRow in A_0.GetChildRows("Component"))
			{
				CompletionItem completionItem = new CompletionItem(dataRow["Name"].ToString(), new CommonImageSourceProvider(CommonImageKind.MethodPublic));
				if (!A_2)
				{
					completionItem.AutoCompletePreText = "\"" + dataRow["Name"].ToString() + "\"";
				}
				completionItem.InlineDescription = ((ControlTypeEnum)Conversions.ToInteger(dataRow["Type"])).ToString();
				A_1.Items.Add(completionItem);
				O_ooO0.o.o__O_.(dataRow, A_1, A_2);
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0001E914 File Offset: 0x0001CB14
		private static string <<EMPTY_NAME>>(ITextSnapshotReader A_0, string A_1)
		{
			A_0.GoToCurrentSnapshotLineStart();
			while (!A_0.IsAtSnapshotLineEnd)
			{
				IToken token = A_0.ReadToken();
				if (token != null && token.Id == 11033)
				{
					string substring = A_0.Snapshot.GetSubstring(token.TextRange);
					if (Operators.CompareString(substring, "GetParentrow", true) == 0 || Operators.CompareString(substring, "GetParentRows", true) == 0)
					{
						token = A_0.ReadToken();
						if (token != null && token.Id == 11003)
						{
							token = A_0.ReadToken();
							if (token != null && token.Id == 11028)
							{
								return A_0.Snapshot.GetSubstring(token.TextRange).Trim(new char[]
								{
									'"'
								});
							}
						}
						try
						{
							foreach (Relation relation in OO_00oOO.Relations)
							{
								if (Operators.CompareString(relation.ChildTable.Name, A_1, true) == 0)
								{
									return relation.ParentTable.Name;
								}
							}
							continue;
						}
						finally
						{
							IEnumerator<Relation> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
					}
					if (Operators.CompareString(substring, "GetChildRows", true) == 0)
					{
						token = A_0.ReadToken();
						if (token != null && token.Id == 11003)
						{
							token = A_0.ReadToken();
							if (token != null && token.Id == 11028)
							{
								return A_0.Snapshot.GetSubstring(token.TextRange).Trim(new char[]
								{
									'"'
								});
							}
						}
						try
						{
							foreach (Relation relation2 in OO_00oOO.Relations)
							{
								if (Operators.CompareString(relation2.ParentTable.Name, A_1, true) == 0)
								{
									return relation2.ChildTable.Name;
								}
							}
						}
						finally
						{
							IEnumerator<Relation> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						continue;
					}
					continue;
				}
			}
			return A_1;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0001EB04 File Offset: 0x0001CD04
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (Operators.CompareString(A_0, "int16", true) == 0)
			{
				result = "Short";
			}
			else if (Operators.CompareString(A_0, "int32", true) == 0)
			{
				result = "Integer";
			}
			else if (Operators.CompareString(A_0, "int64", true) == 0)
			{
				result = "Long";
			}
			else if (Operators.CompareString(A_0, "DateTime", true) == 0)
			{
				result = "Date";
			}
			else
			{
				result = A_0;
			}
			return result;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0001EB70 File Offset: 0x0001CD70
		internal static WithStatement <<EMPTY_NAME>>(ITextSnapshot A_0, int A_1)
		{
			for (IAstNode parent = new VBContextFactory().CreateContext(new TextSnapshotOffset(A_0, A_1), DotNetContextKind.Self).ContainingAstNode.Parent; parent != null; parent = parent.Parent)
			{
				if (parent is WithStatement)
				{
					return (WithStatement)parent;
				}
				if (parent is MethodBody)
				{
					break;
				}
			}
			return null;
		}

		// Token: 0x04000126 RID: 294
		internal static Regex <<EMPTY_NAME>> = new Regex("[\\s]+", RegexOptions.Compiled);

		// Token: 0x04000127 RID: 295
		private static EditorSearchOptions <<EMPTY_NAME>> = new EditorSearchOptions();
	}
}
