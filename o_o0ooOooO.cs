using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Foxtable.My.Resources;
using Foxtable.WinForm;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002B0 RID: 688
	internal class o_o0ooOooO : System.Windows.Forms.TreeView
	{
		// Token: 0x060024DA RID: 9434 RVA: 0x0010D1E2 File Offset: 0x0010B3E2
		[CompilerGenerated]
		internal virtual System.Windows.Forms.Button <<EMPTY_NAME>>()
		{
			return this.O0o.0oo0_.;
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x0010D1EC File Offset: 0x0010B3EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.Button A_0)
		{
			EventHandler value = new EventHandler(this.O0o.0oo0_.);
			System.Windows.Forms.Button o0o.0oo0_. = this.O0o.0oo0_.;
			if (o0o.0oo0_. != null)
			{
				o0o.0oo0_..Click -= value;
			}
			this.O0o.0oo0_. = A_0;
			o0o.0oo0_. = this.O0o.0oo0_.;
			if (o0o.0oo0_. != null)
			{
				o0o.0oo0_..Click += value;
			}
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x0010D230 File Offset: 0x0010B430
		internal o_o0ooOooO()
		{
			base.AfterSelect += this.O0o.0oo0_.;
			base.ParentChanged += this.oO._O_00__ooo.;
			this.O0o.0oo0_. = new List<string>();
			this.OOO_.00. = new List<System.Windows.Forms.TreeNode>();
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x0010D280 File Offset: 0x0010B480
		internal o_o0ooOooO(Table A_0, string A_1)
		{
			base.AfterSelect += this.O0o.0oo0_.;
			base.ParentChanged += this.oO._O_00__ooo.;
			this.O0o.0oo0_. = new List<string>();
			this.OOO_.00. = new List<System.Windows.Forms.TreeNode>();
			this.OOO_.00. = A_0;
			this.O0o.0oo0_.(A_1);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x0010D2DC File Offset: 0x0010B4DC
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
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
				if (System.Windows.Forms.Control.ModifierKeys == Keys.Control && A_1.Node != base.Nodes[0])
				{
					goto IL_87;
				}
				IL_29:
				num2 = 3;
				List<System.Windows.Forms.TreeNode>.Enumerator enumerator = this.OOO_.00..GetEnumerator();
				while (enumerator.MoveNext())
				{
					System.Windows.Forms.TreeNode treeNode = enumerator.Current;
					IL_42:
					num2 = 4;
					treeNode.BackColor = this.BackColor;
					IL_51:
					num2 = 5;
					treeNode.ForeColor = this.ForeColor;
					IL_60:
					num2 = 6;
				}
				IL_6B:
				num2 = 7;
				((IDisposable)enumerator).Dispose();
				IL_7A:
				num2 = 8;
				this.OOO_.00..Clear();
				IL_87:
				num2 = 9;
				if (A_1.Node != base.Nodes[0])
				{
					goto IL_B6;
				}
				IL_9E:
				num2 = 10;
				this.OOO_.00..Filter = "";
				goto IL_891;
				IL_B6:
				num2 = 12;
				A_1.Node.BackColor = Color.Blue;
				IL_C9:
				num2 = 13;
				A_1.Node.ForeColor = Color.White;
				IL_DC:
				num2 = 14;
				this.OOO_.00..Add(A_1.Node);
				IL_F0:
				num2 = 15;
				string text = "";
				IL_FA:
				num2 = 16;
				List<System.Windows.Forms.TreeNode>.Enumerator enumerator2 = this.OOO_.00..GetEnumerator();
				while (enumerator2.MoveNext())
				{
					System.Windows.Forms.TreeNode treeNode2 = enumerator2.Current;
					IL_118:
					num2 = 17;
					string text2 = "";
					IL_122:
					num2 = 18;
					int level = treeNode2.Level;
					IL_12E:
					num2 = 19;
					if (this.OOO_.00.)
					{
						IL_13C:
						num2 = 20;
						System.Windows.Forms.TreeNode[] array = new System.Windows.Forms.TreeNode[level + 1];
						IL_14A:
						num2 = 21;
						for (int i = level; i >= 0; i += -1)
						{
							IL_153:
							num2 = 22;
							array[i] = treeNode2;
							IL_15D:
							num2 = 23;
							treeNode2 = treeNode2.Parent;
							IL_169:
							num2 = 24;
						}
						IL_177:
						num2 = 25;
						for (int j = level; j >= 0; j += -1)
						{
							IL_183:
							num2 = 26;
							if (j < level)
							{
								IL_18C:
								num2 = 27;
								text2 += " And ";
							}
							IL_19D:
							num2 = 28;
							string text3 = this.O0o.0oo0_.[j];
							IL_1AF:
							num2 = 29;
							if (text3.EndsWith("_D_"))
							{
								IL_1C3:
								num2 = 30;
								text3 = text3.Substring(0, text3.Length - 3);
								IL_1D9:
								num2 = 31;
								int day = Conversions.ToInteger(array[j].Text);
								IL_1ED:
								num2 = 32;
								int month = Conversions.ToInteger(array[j - 1].Text);
								IL_203:
								num2 = 33;
								int year = Conversions.ToInteger(array[j - 2].Text);
								IL_219:
								num2 = 34;
								DateTime value = new DateTime(year, month, day);
								IL_229:
								num2 = 35;
								text2 = string.Concat(new string[]
								{
									text2,
									"[",
									text3,
									"] >= #",
									Conversions.ToString(value),
									"# And [",
									text3,
									"] < #",
									Conversions.ToString(value.AddDays(1.0)),
									"#"
								});
								IL_294:
								num2 = 36;
								j -= 2;
							}
							else
							{
								IL_2A2:
								num2 = 38;
								if (text3.EndsWith("_W_"))
								{
									IL_2B6:
									num2 = 39;
									text3 = text3.Substring(0, text3.Length - 3);
									IL_2CC:
									num2 = 40;
									int num3 = Conversions.ToInteger(array[j].Text);
									IL_2E0:
									num2 = 41;
									int year2 = Conversions.ToInteger(array[j - 1].Text);
									IL_2F6:
									num2 = 42;
									DateTime dateTime = new DateTime(year2, 1, 1);
									IL_304:
									num2 = 43;
									DateTime dateTime2 = dateTime.AddDays((double)(-(double)dateTime.DayOfWeek)).AddDays((double)((num3 - 1) * 7));
									IL_329:
									num2 = 44;
									DateTime dateTime3 = dateTime2.AddDays(6.0);
									IL_33E:
									num2 = 45;
									if (DateTime.Compare(dateTime2, dateTime) < 0)
									{
										IL_34D:
										num2 = 46;
										dateTime2 = dateTime;
									}
									IL_354:
									num2 = 47;
									text2 = string.Concat(new string[]
									{
										text2,
										"[",
										text3,
										"] >= #",
										Conversions.ToString(dateTime2),
										"# And [",
										text3,
										"] < #",
										Conversions.ToString(dateTime3.AddDays(1.0)),
										"#"
									});
									IL_3BF:
									num2 = 48;
									j--;
								}
								else
								{
									IL_3CD:
									num2 = 50;
									if (text3.EndsWith("_M_"))
									{
										IL_3E1:
										num2 = 51;
										text3 = text3.Substring(0, text3.Length - 3);
										IL_3F7:
										num2 = 52;
										int month2 = Conversions.ToInteger(array[j].Text);
										IL_40B:
										num2 = 53;
										int year3 = Conversions.ToInteger(array[j - 1].Text);
										IL_421:
										num2 = 54;
										DateTime value2 = new DateTime(year3, month2, 1);
										IL_430:
										num2 = 55;
										DateTime dateTime4 = new DateTime(year3, month2, DateTime.DaysInMonth(year3, month2));
										IL_447:
										num2 = 56;
										text2 = string.Concat(new string[]
										{
											text2,
											"[",
											text3,
											"] >= #",
											Conversions.ToString(value2),
											"# And [",
											text3,
											"] < #",
											Conversions.ToString(dateTime4.AddDays(1.0)),
											"#"
										});
										IL_4B2:
										num2 = 57;
										j--;
									}
									else
									{
										IL_4C0:
										num2 = 59;
										if (text3.EndsWith("_Q_"))
										{
											IL_4D4:
											num2 = 60;
											text3 = text3.Substring(0, text3.Length - 3);
											IL_4EA:
											num2 = 61;
											int num4 = Conversions.ToInteger(array[j].Text);
											IL_4FE:
											num2 = 62;
											int year4 = Conversions.ToInteger(array[j - 1].Text);
											IL_514:
											num2 = 63;
											DateTime value3 = new DateTime(year4, (num4 - 1) * 3 + 1, 1);
											IL_529:
											num2 = 64;
											DateTime dateTime5 = new DateTime(year4, (num4 - 1) * 3 + 3, DateTime.DaysInMonth(year4, (num4 - 1) * 3 + 3));
											IL_54C:
											num2 = 65;
											text2 = string.Concat(new string[]
											{
												text2,
												"[",
												text3,
												"] >= #",
												Conversions.ToString(value3),
												"# And [",
												text3,
												"] < #",
												Conversions.ToString(dateTime5.AddDays(1.0)),
												"#"
											});
											IL_5B7:
											num2 = 66;
											j--;
										}
										else
										{
											IL_5C5:
											num2 = 68;
											if (text3.EndsWith("_Y_"))
											{
												IL_5D9:
												num2 = 69;
												text3 = text3.Substring(0, text3.Length - 3);
												IL_5EF:
												num2 = 70;
												int year5 = Conversions.ToInteger(array[j].Text);
												IL_603:
												num2 = 71;
												DateTime value4 = new DateTime(year5, 1, 1);
												IL_611:
												num2 = 72;
												DateTime dateTime6 = new DateTime(year5, 12, 31);
												IL_621:
												num2 = 73;
												text2 = string.Concat(new string[]
												{
													text2,
													"[",
													text3,
													"] >= #",
													Conversions.ToString(value4),
													"# And [",
													text3,
													"] < #",
													Conversions.ToString(dateTime6.AddDays(1.0)),
													"#"
												});
											}
											else
											{
												IL_691:
												num2 = 75;
												text2 = text2 + "[" + text3 + "] = ";
												IL_6A9:
												num2 = 76;
												string text4 = "";
												IL_6B3:
												num2 = 77;
												if (this.OOO_.00..Cols[text3].IsString())
												{
													IL_6CF:
													num2 = 78;
													text4 = "'";
												}
												else
												{
													IL_6DB:
													num2 = 80;
													if (this.OOO_.00..Cols[text3].IsDate())
													{
														IL_6F7:
														num2 = 81;
														text4 = "#";
													}
												}
												IL_701:
												num2 = 82;
												text2 = text2 + text4 + array[j].Text + text4;
											}
										}
									}
								}
							}
							IL_71B:
							num2 = 83;
						}
					}
					else
					{
						IL_731:
						num2 = 85;
						for (int k = level; k >= 0; k += -1)
						{
							IL_73D:
							num2 = 86;
							if (k < level)
							{
								IL_746:
								num2 = 87;
								text2 += " And ";
							}
							IL_757:
							num2 = 88;
							text2 = text2 + "[" + this.OOO_.00.[k] + "] = ";
							IL_776:
							num2 = 89;
							string text5 = "";
							IL_780:
							num2 = 90;
							if (this.OOO_.00..Cols[this.OOO_.00.[k]].IsString())
							{
								IL_7A3:
								num2 = 91;
								text5 = "'";
							}
							else
							{
								IL_7AF:
								num2 = 93;
								if (this.OOO_.00..Cols[this.OOO_.00.[k]].IsDate())
								{
									IL_7D2:
									num2 = 94;
									text5 = "#";
								}
							}
							IL_7DC:
							num2 = 95;
							text2 = text2 + text5 + treeNode2.Text.Replace("'", "''") + text5;
							IL_802:
							num2 = 96;
							treeNode2 = treeNode2.Parent;
							IL_80E:
							num2 = 97;
						}
					}
					IL_81F:
					num2 = 98;
					if (Operators.CompareString(text, "", true) > 0)
					{
						IL_832:
						num2 = 99;
						text = text + " or (" + text2 + ")";
					}
					else
					{
						IL_84C:
						num2 = 101;
						text = "(" + text2 + ")";
					}
					IL_862:
					num2 = 102;
				}
				IL_871:
				num2 = 103;
				((IDisposable)enumerator2).Dispose();
				IL_881:
				num2 = 104;
				this.OOO_.00..Filter = text;
				IL_891:
				goto IL_A87;
				IL_896:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_A48:
				goto IL_A7C;
				IL_A4A:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_A5A:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_A4A;
			}
			IL_A7C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_A87:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x0010DD94 File Offset: 0x0010BF94
		internal bool <<EMPTY_NAME>>(string A_0)
		{
			int num;
			bool result;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (Operators.CompareString(this.OOO_.00..DataTable.DataServer, "", true) <= 0)
				{
					goto IL_40;
				}
				IL_27:
				num2 = 3;
				bool flag = this.OOO_.00..DataTable.DataServerType == DataServerTypeEnum.Oracle;
				goto IL_59;
				IL_40:
				num2 = 5;
				flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.OOO_.00..DataTable.frd_Connection);
				IL_59:
				num2 = 6;
				if (Operators.CompareString(this.OOO_.00..DataTable.DataServer, "", true) <= 0)
				{
					goto IL_92;
				}
				IL_79:
				num2 = 7;
				bool flag2 = this.OOO_.00..DataTable.DataServerType == DataServerTypeEnum.SqlServer;
				goto IL_AC;
				IL_92:
				num2 = 9;
				flag2 = o_O_o_oOoo__.OOOO_OO._oo.(this.OOO_.00..DataTable.frd_Connection);
				IL_AC:
				num2 = 10;
				this.OOO_.00. = A_0.Split(new char[]
				{
					'|'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_C7:
				num2 = 11;
				this.OOO_.00. = false;
				IL_D1:
				num2 = 12;
				this.O0o.0oo0_..Clear();
				IL_DF:
				num2 = 13;
				Dictionary<int, string> dictionary = new Dictionary<int, string>();
				IL_E9:
				num2 = 14;
				foreach (string text in this.OOO_.00.)
				{
					IL_103:
					num2 = 15;
					if (text.EndsWith(" Y", StringComparison.CurrentCultureIgnoreCase) || text.EndsWith(" YM", StringComparison.CurrentCultureIgnoreCase) || text.EndsWith(" YMD", StringComparison.CurrentCultureIgnoreCase) || text.EndsWith(" YQ", StringComparison.CurrentCultureIgnoreCase) || text.EndsWith(" YW", StringComparison.CurrentCultureIgnoreCase))
					{
						IL_151:
						num2 = 16;
						this.OOO_.00. = true;
					}
					IL_15B:
					num2 = 17;
					string[] array = text.Split(new char[]
					{
						' '
					}, StringSplitOptions.RemoveEmptyEntries);
					IL_173:
					num2 = 18;
					if (!this.OOO_.00..DataTable.DataCols.Contains(array[0]))
					{
						IL_1D6:
						num2 = 23;
						MessageBox.Show("生成目录树失败，无效列名：" + array[0], "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						IL_1F5:
						num2 = 24;
						result = false;
						IL_C25:
						goto IL_F0B;
					}
					IL_191:
					num2 = 19;
					int num3;
					if (this.OOO_.00..DataTable.DataCols[array[0]].IsDate && array.Length == 1)
					{
						IL_1BB:
						num2 = 20;
						dictionary.Add(num3, array[0]);
					}
					IL_1CB:
					num2 = 21;
					num3++;
					IL_1FF:
					num2 = 25;
				}
				IL_213:
				num2 = 26;
				if (!this.OOO_.00.)
				{
					goto IL_A0E;
				}
				IL_221:
				num2 = 27;
				DataTable dataTable = new DataTable();
				IL_22B:
				num2 = 28;
				List<string> list = new List<string>();
				IL_235:
				num2 = 29;
				string[] array2 = A_0.Split(new char[]
				{
					'|'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_24C:
				num2 = 30;
				string text2 = "SELECT DISTINCT ";
				IL_256:
				num2 = 31;
				foreach (string text3 in array2)
				{
					IL_26C:
					num2 = 32;
					string[] array4 = text3.Split(new char[]
					{
						' '
					}, StringSplitOptions.RemoveEmptyEntries);
					IL_284:
					num2 = 33;
					if (!this.OOO_.00..DataTable.DataCols.Contains(array4[0]))
					{
						IL_2A2:
						num2 = 34;
						MessageBox.Show("打开筛选树失败，找不到列\"" + array4[0] + "\"!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						IL_2C6:
						num2 = 35;
						result = false;
						goto IL_C25;
					}
					IL_2D0:
					num2 = 36;
					string text4 = array4[0];
					IL_2D9:
					num2 = 37;
					if (Operators.CompareString(text4, "", true) == 0)
					{
						IL_2EB:
						num2 = 38;
						MessageBox.Show("生成目录树失败，无效列名：" + array4[0], "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						IL_30A:
						num2 = 39;
						result = false;
						goto IL_C25;
					}
					IL_314:
					num2 = 40;
					if (this.OOO_.00..Cols[array4[0]].IsDate())
					{
						IL_335:
						num2 = 41;
						if (array4.Length == 1)
						{
							IL_33F:
							num2 = 42;
							list.Add(text4);
							IL_34B:
							num2 = 43;
							this.O0o.0oo0_..Add(array4[0]);
						}
						else
						{
							IL_362:
							num2 = 45;
							text4 = Oo00.OoOo_oo_.o_o.(array4[0], this.OOO_.00.);
							IL_376:
							num2 = 46;
							if (flag)
							{
								IL_37D:
								num2 = 47;
								list.Add("TO_CHAR(" + text4 + ",'YYYY')");
							}
							else
							{
								IL_39A:
								num2 = 49;
								if (flag2)
								{
									IL_3A1:
									num2 = 50;
									list.Add("DatePart(yyyy," + text4 + ")");
								}
								else
								{
									IL_3BE:
									num2 = 52;
									list.Add("DatePart('yyyy'," + text4 + ")");
								}
							}
							IL_3D9:
							num2 = 53;
							this.O0o.0oo0_..Add(array4[0] + "_Y_");
							IL_3F5:
							num2 = 54;
							if (Operators.CompareString(array4[1], "YM", true) == 0 || Operators.CompareString(array4[1], "YMD", true) == 0)
							{
								IL_41A:
								num2 = 55;
								if (flag)
								{
									IL_421:
									num2 = 56;
									list.Add("TO_CHAR(" + text4 + ",'MM')");
								}
								else
								{
									IL_43E:
									num2 = 58;
									if (flag2)
									{
										IL_445:
										num2 = 59;
										list.Add("DatePart(m," + text4 + ")");
									}
									else
									{
										IL_462:
										num2 = 61;
										list.Add("DatePart('m'," + text4 + ")");
									}
								}
								IL_47D:
								num2 = 62;
								this.O0o.0oo0_..Add(array4[0] + "_M_");
							}
							IL_499:
							num2 = 63;
							if (Operators.CompareString(array4[1], "YQ", true) == 0)
							{
								IL_4AD:
								num2 = 64;
								if (flag)
								{
									IL_4B4:
									num2 = 65;
									list.Add("TO_CHAR(" + text4 + ",'Q')");
								}
								else
								{
									IL_4D1:
									num2 = 67;
									if (flag2)
									{
										IL_4D8:
										num2 = 68;
										list.Add("DatePart(q," + text4 + ")");
									}
									else
									{
										IL_4F5:
										num2 = 70;
										list.Add("DatePart('q'," + text4 + ")");
									}
								}
								IL_510:
								num2 = 71;
								this.O0o.0oo0_..Add(array4[0] + "_Q_");
							}
							IL_52C:
							num2 = 72;
							if (Operators.CompareString(array4[1], "YW", true) == 0)
							{
								IL_540:
								num2 = 73;
								if (flag)
								{
									IL_547:
									num2 = 74;
									list.Add("TO_CHAR(" + text4 + ",'WW')");
								}
								else
								{
									IL_564:
									num2 = 76;
									if (flag2)
									{
										IL_56B:
										num2 = 77;
										list.Add("DatePart(ww," + text4 + ")");
									}
									else
									{
										IL_588:
										num2 = 79;
										list.Add("DatePart('ww'," + text4 + ")");
									}
								}
								IL_5A3:
								num2 = 80;
								this.O0o.0oo0_..Add(array4[0] + "_W_");
							}
							IL_5BF:
							num2 = 81;
							if (Operators.CompareString(array4[1], "YMD", true) == 0)
							{
								IL_5D6:
								num2 = 82;
								if (flag)
								{
									IL_5DD:
									num2 = 83;
									list.Add("TO_CHAR(" + text4 + ",'DD')");
								}
								else
								{
									IL_5FA:
									num2 = 85;
									if (flag2)
									{
										IL_601:
										num2 = 86;
										list.Add("DatePart(d," + text4 + ")");
									}
									else
									{
										IL_61E:
										num2 = 88;
										list.Add("DatePart('d'," + text4 + ")");
									}
								}
								IL_639:
								num2 = 89;
								this.O0o.0oo0_..Add(array4[0] + "_D_");
							}
						}
					}
					else
					{
						IL_657:
						num2 = 91;
						list.Add(text4);
						IL_663:
						num2 = 92;
						this.O0o.0oo0_..Add(array4[0]);
					}
					IL_675:
					num2 = 93;
				}
				IL_689:
				num2 = 94;
				int num4 = list.Count - 1;
				for (int k = 0; k <= num4; k++)
				{
					IL_69C:
					num2 = 95;
					text2 += list[k];
					IL_6B1:
					num2 = 96;
					if (k < list.Count - 1)
					{
						IL_6C1:
						num2 = 97;
						text2 += ",";
					}
					IL_6D2:
					num2 = 98;
				}
				IL_6E1:
				num2 = 99;
				if (Operators.CompareString(this.OOO_.00..DataTable.o._OOO0oOo0__., "", true) <= 0)
				{
					goto IL_76C;
				}
				IL_702:
				num2 = 100;
				if (!flag)
				{
					goto IL_72F;
				}
				IL_709:
				num2 = 101;
				text2 = text2 + " From " + this.OOO_.00..DataTable.o._OOO0oOo0__.;
				goto IL_7DB;
				IL_72F:
				num2 = 103;
				text2 = text2 + " From [" + this.OOO_.00..DataTable.o._OOO0oOo0__..Trim(new char[]
				{
					'[',
					']'
				}) + "]";
				goto IL_7DB;
				IL_76C:
				num2 = 105;
				if (Operators.CompareString(this.OOO_.00..DataTable.DataServer, "", true) <= 0)
				{
					goto IL_7B5;
				}
				IL_78D:
				num2 = 106;
				text2 = text2 + " From (" + this.OOO_.00..DataTable.HttpSelect + ") As fox_Temp";
				goto IL_7DB;
				IL_7B5:
				num2 = 108;
				text2 = text2 + " From (" + this.OOO_.00..DataTable.frd_SelectCommandString + ") As fox_Temp";
				IL_7DB:
				num2 = 109;
				if (Operators.CompareString(this.OOO_.00..DataTable.LoadFilter, "", true) <= 0)
				{
					goto IL_81D;
				}
				IL_7FC:
				num2 = 110;
				text2 = text2 + " where " + this.OOO_.00..DataTable.LoadFilter;
				IL_81D:
				num2 = 111;
				if (Operators.CompareString(this.OOO_.00..DataTable.DataServer, "", true) != 0)
				{
					goto IL_868;
				}
				IL_83D:
				num2 = 112;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text2, this.OOO_.00..DataTable.frd_Connection);
				IL_859:
				num2 = 113;
				oleDbDataAdapter.Fill(dataTable);
				goto IL_8DB;
				IL_868:
				num2 = 115;
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.OOO_.00..DataTable.ConnectionName].oO0_0.o.();
				IL_88C:
				num2 = 116;
				Dictionary<string, string> dictionary2 = httpClient.FormData;
				string key = "Action";
				int num5 = 2;
				dictionary2[key] = num5.ToString();
				IL_8AA:
				num2 = 117;
				httpClient.FormData.Add("IgnoreSchema", "True");
				IL_8C3:
				num2 = 118;
				httpClient.Select = text2;
				IL_8CF:
				num2 = 119;
				dataTable = httpClient.GetBaseDataTable();
				IL_8DB:
				num2 = 120;
				if (dataTable != null && dataTable.Columns.Count != 0)
				{
					goto IL_946;
				}
				IL_8F0:
				num2 = 121;
				if (Information.Err().Number == 0)
				{
					goto IL_926;
				}
				IL_8FF:
				num2 = 122;
				MessageBox.Show("打开筛选树失败，错误信息 :\r\n" + Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				goto IL_93C;
				IL_926:
				num2 = 124;
				MessageBox.Show("无法获取生成筛选树所需数据,打开删选树失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_93C:
				num2 = 125;
				result = false;
				goto IL_C25;
				IL_946:
				num2 = 126;
				array2 = new string[dataTable.Columns.Count - 1 + 1];
				IL_960:
				num2 = 127;
				num5 = dataTable.Columns.Count - 1;
				for (int l = 0; l <= num5; l++)
				{
					IL_978:
					num2 = 128;
					dataTable.Columns[l].ColumnName = "A" + Conversions.ToString(l);
					IL_9A2:
					num2 = 129;
					array2[l] = "A" + Conversions.ToString(l);
					IL_9BE:
					num2 = 130;
				}
				IL_9D0:
				num2 = 131;
				oOO0oo_o0.O.ooooo.(this, dataTable, "", "", "", string.Join("|", array2), false);
				IL_9FA:
				num2 = 132;
				dataTable.Rows.Clear();
				goto IL_A4A;
				IL_A0E:
				num2 = 134;
				oOO0oo_o0.O.ooooo.(this, this.OOO_.00..DataTable.BaseTable, "", "", "", string.Join("|", this.OOO_.00.), false);
				IL_A4A:
				num2 = 135;
				if (!this.O_.o__.)
				{
					goto IL_A70;
				}
				IL_A58:
				num2 = 136;
				base.Nodes.Insert(0, "显示所有行");
				IL_A70:
				num2 = 137;
				if (dictionary.Count <= 0)
				{
					goto IL_C1D;
				}
				IL_A83:
				num2 = 138;
				Foxtable.WinForm.TreeView treeView = new Foxtable.WinForm.TreeView(this);
				IL_A91:
				num2 = 139;
				Dictionary<int, string>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator();
				string style;
				while (enumerator.MoveNext())
				{
					int num3 = enumerator.Current;
					IL_AB3:
					num2 = 140;
					string a_ = dictionary[num3];
					IL_AC4:
					num2 = 141;
					style = "yyyy-MM-dd";
					IL_AD1:
					num2 = 142;
					switch (this.OOO_.00..Cols[a_].DataCol.DateTimeFormat)
					{
					case DateTimeFormatEnum.Date:
						IL_B12:
						num2 = 144;
						style = "yyyy-MM-dd";
						break;
					case DateTimeFormatEnum.Time:
						IL_B3F:
						num2 = 150;
						style = "HH:mm";
						break;
					case DateTimeFormatEnum.DateTime:
						IL_B21:
						num2 = 146;
						style = "yyyy-MM-dd HH:mm";
						break;
					case DateTimeFormatEnum.DateLongTime:
						IL_B30:
						num2 = 148;
						style = "yyyy-MM-dd HH:mm:ss";
						break;
					}
					IL_B5B:
					num2 = 154;
					treeView.StopRedraw();
					IL_B68:
					num2 = 155;
					List<Foxtable.WinForm.TreeNode>.Enumerator enumerator2 = treeView.AllNodes.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Foxtable.WinForm.TreeNode treeNode = enumerator2.Current;
						IL_B87:
						num2 = 156;
						if (treeNode.Level == num3)
						{
							IL_B98:
							num2 = 157;
							DateTime dateTime;
							if (DateTime.TryParse(treeNode.Text, out dateTime))
							{
								IL_BAE:
								num2 = 158;
								treeNode.Text = Strings.Format(dateTime, style);
							}
						}
						IL_BC9:
						num2 = 159;
					}
					IL_BD8:
					num2 = 160;
					((IDisposable)enumerator2).Dispose();
					IL_BEB:
					num2 = 161;
					treeView.ResumeRedraw();
					IL_BF8:
					num2 = 162;
				}
				IL_C0A:
				num2 = 163;
				((IDisposable)enumerator).Dispose();
				IL_C1D:
				num2 = 164;
				result = true;
				goto IL_C25;
				IL_B4E:
				num2 = 152;
				style = "HH:mm:ss";
				goto IL_B5B;
				IL_C2A:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_ECC:
				goto IL_F00;
				IL_ECE:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_EDE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_ECE;
			}
			IL_F00:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_F0B:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x0010ECD4 File Offset: 0x0010CED4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0o.0oo0_.() == null)
			{
				this.O0o.0oo0_.(new System.Windows.Forms.Button());
				this.O0o.0oo0_.().FlatStyle = FlatStyle.Flat;
				this.O0o.0oo0_.().FlatAppearance.BorderSize = 0;
				this.O0o.0oo0_.().Text = "";
				this.O0o.0oo0_.().Size = new Size(18, 18);
				this.O0o.0oo0_.().Location = new Point(base.Width - 30, base.Height - 30);
				this.O0o.0oo0_.().Image = a.Oo.OOO_o.().ToBitmap();
				this.O0o.0oo0_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
				base.Controls.Add(this.O0o.0oo0_.());
				Main.OO_O.o..O0o__0_OO.o.().SetToolTip(this.O0o.0oo0_.(), "刷新目录树");
				if (this.O_.o__.)
				{
					this.O0o.0oo0_.().Visible = false;
				}
			}
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x0010EDBC File Offset: 0x0010CFBC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.SuspendLayout();
			if (!this.O_.o__.)
			{
				this.OOO_.00..OpenFilterTree();
			}
			else if (Operators.CompareString(this.OOO_.00., "", true) > 0)
			{
				this.O0o.0oo0_.(this.OOO_.00.);
			}
			base.ResumeLayout();
			base.Focus();
		}

		// Token: 0x04000F32 RID: 3890
		internal Table <<EMPTY_NAME>>;

		// Token: 0x04000F33 RID: 3891
		private string[] <<EMPTY_NAME>>;

		// Token: 0x04000F34 RID: 3892
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000F35 RID: 3893
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000F36 RID: 3894
		[CompilerGenerated]
		private System.Windows.Forms.Button <<EMPTY_NAME>>;

		// Token: 0x04000F37 RID: 3895
		private List<System.Windows.Forms.TreeNode> <<EMPTY_NAME>>;

		// Token: 0x04000F38 RID: 3896
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000F39 RID: 3897
		internal string <<EMPTY_NAME>>;
	}
}
