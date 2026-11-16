using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.C1Excel;
using Foxtable.My;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.XLS
{
	/// <summary>
	/// Excel工作簿
	/// </summary>
	// Token: 0x020004EC RID: 1260
	[oO0oooo("1150")]
	public class Book
	{
		// Token: 0x060052B7 RID: 21175 RVA: 0x0024E380 File Offset: 0x0024C580
		public Book()
		{
			this.O_0_o.Oo_oo0_O. = new Dictionary<string, object>();
			this.O_0_o.Oo_oo0_O. = false;
			this.oO.o_0o__. = new Dictionary<string, List<DataRow>>();
			this.OOO0_O0.O. = new Book.O0oOOoo_ooo_O();
			this.oOo_o0.o_0. = new Book.O0oOOoo_ooo_O();
			this.O_0_o.Oo_oo0_O. = new Dictionary<string, int>();
			this.OoO.o0. = new Dictionary<string, int>();
			this.O.o00O0___O. = new Dictionary<string, int>();
			this.O_0_o.Oo_oo0_O. = new Dictionary<string, string>();
			this.O_ooo.o0. = new Dictionary<string, string>();
			this.Ooo.00_O0_0_. = new Dictionary<string, int>();
			this.o._0_Oo0o. = new Dictionary<string, int>();
			this.OOO0_O0.O. = new List<int>();
			this.O_0_o.Oo_oo0_O. = new RichTextBox();
			this.oO.o_0o__. = new tempDataTableCollection();
			this.O_0_o.Oo_oo0_O. = new List<O_0OO>();
			this.O_0_o.Oo_oo0_O. = new List<o0__oo0OOo>();
			this.O_ooo.o0. = true;
			this.Ooo.00_O0_0_. = true;
			this.oO.o_0o__. = new C1XLBook();
			this.oO.o_0o__..DefaultFont = new System.Drawing.Font("宋体", 12f, FontStyle.Regular);
			if (Foxtable.My.b.O0o0oO00_.O.().Count > 61)
			{
				O_O0OO.O_O.OOO_o.(true);
			}
		}

		/// <summary>
		/// 根据现有的文件生成一个工作簿
		/// </summary>
		/// <param name="FileName">Excel文件，含路径</param>
		// Token: 0x060052B8 RID: 21176 RVA: 0x0024E494 File Offset: 0x0024C694
		public Book(string A_0)
		{
			this.O_0_o.Oo_oo0_O. = new Dictionary<string, object>();
			this.O_0_o.Oo_oo0_O. = false;
			this.oO.o_0o__. = new Dictionary<string, List<DataRow>>();
			this.OOO0_O0.O. = new Book.O0oOOoo_ooo_O();
			this.oOo_o0.o_0. = new Book.O0oOOoo_ooo_O();
			this.O_0_o.Oo_oo0_O. = new Dictionary<string, int>();
			this.OoO.o0. = new Dictionary<string, int>();
			this.O.o00O0___O. = new Dictionary<string, int>();
			this.O_0_o.Oo_oo0_O. = new Dictionary<string, string>();
			this.O_ooo.o0. = new Dictionary<string, string>();
			this.Ooo.00_O0_0_. = new Dictionary<string, int>();
			this.o._0_Oo0o. = new Dictionary<string, int>();
			this.OOO0_O0.O. = new List<int>();
			this.O_0_o.Oo_oo0_O. = new RichTextBox();
			this.oO.o_0o__. = new tempDataTableCollection();
			this.O_0_o.Oo_oo0_O. = new List<O_0OO>();
			this.O_0_o.Oo_oo0_O. = new List<o0__oo0OOo>();
			this.O_ooo.o0. = true;
			this.Ooo.00_O0_0_. = true;
			this.oO.o_0o__. = new C1XLBook();
			this.o_0Oo.0___OO0_. = A_0;
			if (A_0.ToLower().EndsWith(".xlsx"))
			{
				this.oO.o_0o__..CompatibilityMode = CompatibilityMode.Excel2007;
			}
			else
			{
				this.oO.o_0o__..CompatibilityMode = CompatibilityMode.Excel2003;
			}
			this.oO.o_0o__..Load(ooO.OoO0o_o___.O.(A_0));
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x060052B9 RID: 21177 RVA: 0x0024E5BB File Offset: 0x0024C7BB
		public static Assembly ExtendAsm
		{
			get
			{
				if (!Book.OOO._oOo.)
				{
					Book.OOO._oOo. = true;
					Book.o_0Oo.0___OO0_. = Book.ooo._O.();
				}
				return Book.o_0Oo.0___OO0_.;
			}
		}

		/// <summary>
		/// 在基于模板生成Excel报表时，此属性返回模板名称，不含路径和扩展名，
		/// </summary>
		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060052BA RID: 21178 RVA: 0x0024E5D9 File Offset: 0x0024C7D9
		[oO0oooo("1953")]
		public string TempLate
		{
			get
			{
				return Path.GetFileNameWithoutExtension(this.o_0Oo.0___OO0_.);
			}
		}

		/// <summary>
		/// 在基于模板生成Excel报表时，此属性返回正在生成的工作表的名称。
		/// </summary>
		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060052BB RID: 21179 RVA: 0x0024E5E6 File Offset: 0x0024C7E6
		[oO0oooo("1953")]
		public string CurrentSheetName
		{
			get
			{
				return this.o0OooO_.0.;
			}
		}

		/// <summary>
		/// 返回一个集合，包括模板文件中的所有标记
		/// </summary>
		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060052BC RID: 21180 RVA: 0x0024E5EE File Offset: 0x0024C7EE
		[oO0oooo("1954")]
		public Dictionary<string, object> Marks
		{
			get
			{
				return this.O_0_o.Oo_oo0_O.;
			}
		}

		/// <summary>
		/// 如果报表模板中设置了合并列，可以用此属性指定合并类型，默认为标准合并，如果需要自由合并，可以将此属性设为True
		/// </summary>
		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060052BD RID: 21181 RVA: 0x0024E5F6 File Offset: 0x0024C7F6
		// (set) Token: 0x060052BE RID: 21182 RVA: 0x0024E5FE File Offset: 0x0024C7FE
		public bool MergeFree
		{
			get
			{
				return this.O_0_o.Oo_oo0_O.;
			}
			set
			{
				this.O_0_o.Oo_oo0_O. = value;
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060052BF RID: 21183 RVA: 0x0024E607 File Offset: 0x0024C807
		// (set) Token: 0x060052C0 RID: 21184 RVA: 0x0024E60F File Offset: 0x0024C80F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool PreBuild
		{
			get
			{
				return this.O_ooo.o0.;
			}
			set
			{
				this.O_ooo.o0. = value;
			}
		}

		/// <summary>
		/// 根据模板生成报表
		/// </summary>
		/// <param name="Indexes">可选参数，指定Build方法跳过某些表，保持原样</param>
		// Token: 0x060052C1 RID: 21185 RVA: 0x0024E618 File Offset: 0x0024C818
		[oO0oooo("1151")]
		public bool Build(params int[] Indexes)
		{
			this.oOo_o0.o_0..o__0_.oO. = this.oO.o_0o__.;
			this.OOO0_O0.O..o__0_.oO. = this.oO.o_0o__.;
			return this.ooo._O.(Indexes);
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x0024E644 File Offset: 0x0024C844
		private bool <<EMPTY_NAME>>(params int[] A_0)
		{
			List<int> list = new List<int>();
			bool flag = false;
			list.AddRange(A_0);
			if (this.O_0_o.Oo_oo0_O..Count > 0)
			{
				this.ooo._O.();
			}
			bool result;
			try
			{
				BuildEventArgs buildEventArgs = new BuildEventArgs(this);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeBuild", new object[]
				{
					buildEventArgs
				}, false, "Excel报表", false);
				this.oO.o_0o__. = this.oO.o_0o__..Sheets.Count;
				int num = this.oO.o_0o__. - 1;
				for (int i = 0; i <= num; i++)
				{
					if (!list.Contains(i))
					{
						XLSheet xlsheet = this.oO.o_0o__..Sheets[i];
						XLSheet xlsheet2 = xlsheet.Clone();
						this.o0OooO_.0. = xlsheet.Name;
						xlsheet2.Name = "__" + xlsheet.Name;
						xlsheet2.Rows.Clear();
						xlsheet2.MergedCells.Clear();
						this.oO.o_0o__..Sheets.Add(xlsheet2);
						xlsheet2.DefaultRowHeight = xlsheet.DefaultRowHeight;
						xlsheet2.DefaultColumnWidth = xlsheet.DefaultColumnWidth;
						if (!this.o_0Oo.0___OO0_.(xlsheet))
						{
							return false;
						}
						int a_ = 0;
						int a_2 = -1;
						int num2;
						int num3;
						if (this.OoO.o0..ContainsKey("FooterRow".ToLower()))
						{
							num2 = this.OoO.o0.["FooterRow".ToLower()];
							num3 = num2;
							if (this.O.o00O0___O..ContainsKey("FooterRow".ToLower()))
							{
								num3 = this.O.o00O0___O.["FooterRow".ToLower()];
							}
						}
						int num4 = this.oOo_o0.o_0.;
						for (int j = 0; j <= num4; j++)
						{
							if (num2 <= 0 || j < num2 || j > num3)
							{
								string text = xlsheet[j, 0].Text.Trim(new char[]
								{
									' ',
									'\r',
									'\n'
								});
								if (Operators.CompareString(text, "", true) > 0)
								{
									if (Operators.CompareString(text, "<HeaderRow>", true) == 0 & !flag)
									{
										flag = true;
										PageHeaderEventArgs pageHeaderEventArgs = new PageHeaderEventArgs(this);
										O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildPageHeader", new object[]
										{
											pageHeaderEventArgs
										}, false, "Excel报表", false);
									}
									if (Operators.CompareString(text, "{Skip}", true) == 0)
									{
										goto IL_30F;
									}
									if (LikeOperator.LikeString(text, "<*>", CompareMethod.Text) && text.Length >= 3 && Operators.CompareString(text, "<HeaderRow>", true) != 0 && Operators.CompareString(text, "<FooterRow>", true) != 0)
									{
										text = text.Substring(1, text.Length - 2);
										text = text.Split(new char[]
										{
											','
										})[0];
										if (this.OoO.o0..ContainsKey(text))
										{
											this.ooo._O.(xlsheet, xlsheet2, a_, a_2);
											this.ooo._O.(text, null, xlsheet, xlsheet2, 0, null);
											if (this.O.o00O0___O..ContainsKey(text))
											{
												j = this.O.o00O0___O.[text];
											}
											a_ = j + 1;
											goto IL_30F;
										}
									}
								}
								this.ooo._O.(xlsheet, j, xlsheet2, xlsheet2.Rows.Count, null, 0, null, null);
								a_2 = j;
							}
							IL_30F:;
						}
						this.ooo._O.(xlsheet, xlsheet2, a_, a_2);
						if (this.OOO0_O0.O..Count > 0)
						{
							int[] array = new int[this.OOO0_O0.O..Count - 1 + 1];
							int[] array2 = new int[this.OOO0_O0.O..Count - 1 + 1];
							string[] array3 = new string[this.OOO0_O0.O..Count - 1 + 1];
							string[] array4 = new string[this.OOO0_O0.O..Count - 1 + 1];
							int num5 = this.OOO0_O0.O..Count - 1;
							for (int k = 0; k <= num5; k++)
							{
								int num6 = this.OOO0_O0.O.[k];
								array3[k] = xlsheet2[0, num6].Text;
							}
							int num7 = xlsheet2.Rows.Count - 1;
							for (int l = 1; l <= num7; l++)
							{
								int num8 = this.OOO0_O0.O..Count - 1;
								for (int m = 0; m <= num8; m++)
								{
									int num6 = this.OOO0_O0.O.[m];
									if (xlsheet2[l, num6].Value == DBNull.Value)
									{
										array4[m] = "";
									}
									else
									{
										array4[m] = xlsheet2[l, num6].Text;
									}
									if (Operators.CompareString(array4[m], "", true) > 0 && Operators.CompareString(array3[m], "", true) > 0 && Operators.CompareString(array4[m], array3[m], true) == 0)
									{
										array2[m] = l;
									}
									else
									{
										if (array2[m] > array[m])
										{
											xlsheet2.MergedCells.Add(array[m], num6 - 1, array2[m] - array[m] + 1, this.o_0Oo.0___OO0_.(xlsheet2, array[m], num6 - 1));
										}
										array[m] = l;
										array2[m] = l;
										array3[m] = array4[m];
										if (!this.MergeFree)
										{
											int num9 = m + 1;
											int num10 = this.OOO0_O0.O..Count - 1;
											for (int n = num9; n <= num10; n++)
											{
												if (array2[n] > array[n])
												{
													xlsheet2.MergedCells.Add(array[n], this.OOO0_O0.O.[n] - 1, array2[n] - array[n] + 1, this.o_0Oo.0___OO0_.(xlsheet2, array[n], this.OOO0_O0.O.[n] - 1));
												}
												array[n] = l;
												array2[n] = l;
												if (xlsheet2[l, this.OOO0_O0.O.[n]].Value == DBNull.Value)
												{
													array3[n] = "";
												}
												else
												{
													array3[n] = xlsheet2[l, this.OOO0_O0.O.[n]].Text;
												}
												array4[n] = array3[n];
											}
										}
									}
									if (array2[m] > array[m] && l == xlsheet2.Rows.Count - 1)
									{
										xlsheet2.MergedCells.Add(array[m], num6 - 1, array2[m] - array[m] + 1, this.o_0Oo.0___OO0_.(xlsheet2, array[m], num6 - 1));
									}
								}
							}
						}
					}
				}
				for (int num11 = this.oO.o_0o__. - 1; num11 >= 0; num11 += -1)
				{
					if (!list.Contains(num11))
					{
						this.oO.o_0o__..Sheets.RemoveAt(num11);
					}
				}
				try
				{
					foreach (object obj in ((IEnumerable)this.oO.o_0o__..Sheets))
					{
						XLSheet xlsheet3 = (XLSheet)obj;
						if (xlsheet3.Name.StartsWith("__"))
						{
							xlsheet3.Name = xlsheet3.Name.TrimStart(new char[]
							{
								'_'
							});
							if (xlsheet3.Columns.Count > 0)
							{
								List<XLCellRange> list2 = new List<XLCellRange>();
								try
								{
									foreach (object obj2 in ((IEnumerable)xlsheet3.MergedCells))
									{
										XLCellRange item = (XLCellRange)obj2;
										list2.Add(item);
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
								xlsheet3.Columns.RemoveAt(0);
								try
								{
									foreach (XLCellRange cr in list2)
									{
										xlsheet3.MergedCells.Add(cr);
									}
								}
								finally
								{
									List<XLCellRange>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
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
				if (O_O0OO.O00.00OO000___.())
				{
					try
					{
						foreach (object obj3 in ((IEnumerable)this.oO.o_0o__..Sheets))
						{
							((XLSheet)obj3).PrintSettings.Header = "www.foxtable.com";
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
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterBuild", new object[]
				{
					buildEventArgs
				}, false, "Excel报表", false);
				result = true;
			}
			catch (Exception a_3)
			{
				ooO.oOo0Oo.o.(a_3, "");
				result = false;
			}
			return result;
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x0024EF1C File Offset: 0x0024D11C
		private int <<EMPTY_NAME>>(XLSheet A_0, int A_1, int A_2)
		{
			try
			{
				foreach (object obj in ((IEnumerable)A_0.MergedCells))
				{
					XLCellRange xlcellRange = (XLCellRange)obj;
					if (xlcellRange.ColumnFrom == A_2 && xlcellRange.RowFrom == A_1)
					{
						return xlcellRange.ColumnCount;
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
			return 1;
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x0024EF90 File Offset: 0x0024D190
		private void <<EMPTY_NAME>>(XLSheet A_0, XLSheet A_1, int A_2, int A_3)
		{
			object[] a_ = new object[]
			{
				A_0,
				A_1,
				A_2,
				A_3,
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()]
			};
			O_O0OO.OoO_o.oO0o0O.(Book.ExtendAsm, "CopyMergeCells", a_, false, "", false);
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x0024EFF0 File Offset: 0x0024D1F0
		private void <<EMPTY_NAME>>(string A_0, DataRow A_1, XLSheet A_2, XLSheet A_3, int A_4, List<DataRow> A_5)
		{
			int num;
			int num48;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				int num3 = this.OoO.o0.[A_0];
				IL_17:
				num2 = 3;
				int num4 = num3;
				IL_1D:
				num2 = 4;
				List<DataRow> list = new List<DataRow>();
				IL_26:
				num2 = 5;
				List<DataRow> list2 = new List<DataRow>();
				IL_2F:
				num2 = 6;
				int a_ = num3;
				IL_35:
				num2 = 7;
				int a_2 = -1;
				IL_3A:
				num2 = 8;
				int num5 = 1;
				IL_3F:
				num2 = 9;
				if (!this.O.o00O0___O..ContainsKey(A_0))
				{
					goto IL_61;
				}
				IL_50:
				num2 = 10;
				num4 = this.O.o00O0___O.[A_0];
				IL_61:
				num2 = 11;
				if (!this.Ooo.00_O0_0_..ContainsKey(A_0))
				{
					goto IL_83;
				}
				IL_72:
				num2 = 12;
				int num6 = this.Ooo.00_O0_0_.[A_0];
				IL_83:
				num2 = 13;
				if (!this.OoO.o0..ContainsKey("FooterRow".ToLower()))
				{
					goto IL_F2;
				}
				IL_9D:
				num2 = 14;
				int num7 = this.OoO.o0.["FooterRow".ToLower()];
				IL_B7:
				num2 = 15;
				int num8 = num7;
				IL_BE:
				num2 = 16;
				if (!this.O.o00O0___O..ContainsKey("FooterRow".ToLower()))
				{
					goto IL_F2;
				}
				IL_D8:
				num2 = 17;
				num8 = this.O.o00O0___O.["FooterRow".ToLower()];
				IL_F2:
				num2 = 18;
				if (A_1 == null || A_1.Table.DataSet == null)
				{
					goto IL_275;
				}
				IL_10B:
				num2 = 19;
				IEnumerator enumerator = A_1.Table.DataSet.Relations.GetEnumerator();
				bool flag;
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRelation dataRelation = (DataRelation)obj;
					IL_138:
					num2 = 20;
					if (Operators.CompareString(dataRelation.ParentTable.TableName, A_1.Table.TableName, true) == 0 && Operators.CompareString(dataRelation.ChildTable.TableName, this.oO.o_0o__.[A_0].Name, true) == 0)
					{
						IL_185:
						num2 = 21;
						string sort = "";
						IL_18F:
						num2 = 22;
						string filterExpression = "";
						IL_199:
						num2 = 23;
						if (this.O_ooo.o0..ContainsKey(A_0))
						{
							IL_1AA:
							num2 = 24;
							sort = this.O_ooo.o0.[A_0];
						}
						IL_1BB:
						num2 = 25;
						if (this.O_0_o.Oo_oo0_O..ContainsKey(A_0))
						{
							IL_1CC:
							num2 = 26;
							filterExpression = Oo00.oo0o.O0O_0__.(A_1, this.oO.o_0o__.[A_0].Name) + " And " + this.O_0_o.Oo_oo0_O.[A_0];
						}
						else
						{
							IL_200:
							num2 = 28;
							filterExpression = Oo00.oo0o.O0O_0__.(A_1, this.oO.o_0o__.[A_0].Name);
						}
						IL_21C:
						num2 = 29;
						DataRow[] collection = this.oO.o_0o__.[A_0].BaseTable.Select(filterExpression, sort);
						IL_23B:
						num2 = 30;
						list.AddRange(collection);
						IL_247:
						num2 = 31;
						flag = true;
						break;
					}
					IL_24E:
					num2 = 33;
				}
				IL_25D:
				num2 = 34;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_275:
				num2 = 35;
				if (flag)
				{
					goto IL_630;
				}
				IL_27E:
				num2 = 36;
				string text = "";
				IL_288:
				num2 = 37;
				if (!this.O_0_o.Oo_oo0_O..ContainsKey(A_0))
				{
					goto IL_2AA;
				}
				IL_299:
				num2 = 38;
				text = this.O_0_o.Oo_oo0_O.[A_0];
				IL_2AA:
				num2 = 39;
				string text2 = "";
				IL_2B4:
				num2 = 40;
				if (!this.O_ooo.o0..ContainsKey(A_0))
				{
					goto IL_2D6;
				}
				IL_2C5:
				num2 = 41;
				text2 = this.O_ooo.o0.[A_0];
				IL_2D6:
				num2 = 42;
				if (this.oO.o_0o__.[A_0].BaseTable.DataSet != this.oO.o_0o__.)
				{
					goto IL_33C;
				}
				IL_2F7:
				num2 = 43;
				if (Operators.CompareString(text, "all", true) != 0)
				{
					goto IL_313;
				}
				IL_309:
				num2 = 44;
				text = "";
				IL_313:
				num2 = 45;
				list.AddRange(this.oO.o_0o__.[A_0].BaseTable.Select(text, text2));
				goto IL_613;
				IL_33C:
				num2 = 47;
				if (Operators.CompareString(OO_00oOO.CurrentTable.DataTable.Name, A_0, true) != 0)
				{
					goto IL_363;
				}
				IL_357:
				num2 = 48;
				Table table = OO_00oOO.CurrentTable;
				goto IL_373;
				IL_363:
				num2 = 50;
				table = OO_00oOO.Tables[A_0];
				IL_373:
				num2 = 51;
				if (this.O_0_o.Oo_oo0_O..ContainsKey(A_0))
				{
					goto IL_562;
				}
				IL_387:
				num2 = 52;
				int topRow = table.foxGrid.Selection.TopRow;
				int bottomRow = table.foxGrid.Selection.BottomRow;
				for (int i = topRow; i <= bottomRow; i++)
				{
					IL_3BA:
					num2 = 53;
					if (i < table.foxGrid.Rows.Fixed)
					{
						break;
					}
					IL_3D2:
					num2 = 55;
					if (table.foxGrid.Rows[i].DataIndex >= 0)
					{
						IL_3F0:
						num2 = 56;
						list.Add(table.View.O0O_0_0__.0O.(table.foxGrid.Rows[i].DataIndex).Row);
					}
					IL_423:
					num2 = 57;
				}
				IL_432:
				num2 = 58;
				if (Operators.CompareString(text2, "", true) <= 0 || list.Count <= 0)
				{
					goto IL_613;
				}
				IL_455:
				num2 = 59;
				System.Data.DataTable dataTable = this.ooo._O.(list[0].Table);
				IL_46D:
				num2 = 60;
				dataTable.Columns.Add("Column!@#()_ForRow", typeof(DataRow));
				IL_48C:
				num2 = 61;
				List<DataRow>.Enumerator enumerator2 = list.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow = enumerator2.Current;
					IL_4A3:
					num2 = 62;
					dataTable.ImportRow(dataRow);
					IL_4AF:
					num2 = 63;
					dataTable.Rows[dataTable.Rows.Count - 1]["Column!@#()_ForRow"] = dataRow;
					IL_4D8:
					num2 = 64;
				}
				IL_4E4:
				num2 = 65;
				((IDisposable)enumerator2).Dispose();
				IL_4F4:
				num2 = 66;
				list.Clear();
				IL_4FE:
				num2 = 67;
				foreach (DataRow dataRow2 in dataTable.Select("", text2))
				{
					IL_51D:
					num2 = 68;
					list.Add((DataRow)dataRow2["Column!@#()_ForRow"]);
					IL_538:
					num2 = 69;
				}
				IL_549:
				num2 = 70;
				dataTable.Reset();
				IL_553:
				num2 = 71;
				dataTable.Dispose();
				goto IL_613;
				IL_562:
				num2 = 73;
				if (Operators.CompareString(text2, "", true) != 0)
				{
					goto IL_585;
				}
				IL_574:
				num2 = 74;
				text2 = table.View.oO_O.o_OOO.();
				IL_585:
				num2 = 75;
				if (Operators.CompareString(text, "ALL", true) != 0)
				{
					goto IL_5AA;
				}
				IL_597:
				num2 = 76;
				text = table.View.oo_0._o.();
				goto IL_5E4;
				IL_5AA:
				num2 = 78;
				if (Operators.CompareString(table.View.oo_0._o.(), "", true) <= 0)
				{
					goto IL_5E4;
				}
				IL_5C7:
				num2 = 79;
				text = text + " And " + table.View.oo_0._o.();
				IL_5E4:
				num2 = 80;
				DataRow[] collection2 = OO_00oOO.Tables[A_0].DataTable.BaseTable.Select(text, text2);
				IL_607:
				num2 = 81;
				list.AddRange(collection2);
				IL_613:
				num2 = 82;
				if (Operators.CompareString(A_0, this.OOoOOo0.000., true) != 0)
				{
					goto IL_630;
				}
				IL_625:
				num2 = 83;
				this.OOO0_O0.O. = list;
				IL_630:
				num2 = 84;
				if (num6 >= 0)
				{
					goto IL_64B;
				}
				IL_638:
				num2 = 85;
				num6 = Math.Abs(num6);
				IL_644:
				num2 = 86;
				int num9 = num6;
				IL_64B:
				num2 = 87;
				int count = list.Count;
				IL_657:
				num2 = 88;
				if (!this.o._0_Oo0o..ContainsKey(A_0))
				{
					goto IL_67F;
				}
				IL_668:
				num2 = 89;
				num5 = Math.Max(1, this.o._0_Oo0o.[A_0]);
				IL_67F:
				num2 = 90;
				if (count != 0 || num9 <= 0)
				{
					goto IL_75E;
				}
				IL_691:
				num2 = 91;
				int num10 = num9 - 1;
				for (int k = 0; k <= num10; k++)
				{
					IL_6A2:
					num2 = 92;
					DetailEventArgs detailEventArgs = new DetailEventArgs(this, A_0, null);
					IL_6AF:
					num2 = 93;
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildDetail", new object[]
					{
						detailEventArgs
					}, false, "Excel报表", false);
					IL_6D4:
					num2 = 94;
					a_ = num3;
					IL_6DB:
					num2 = 95;
					int num11 = num3;
					int num12 = num4;
					int l = num11;
					while (l <= num12)
					{
						IL_6E8:
						num2 = 96;
						if (num7 <= 0)
						{
							goto IL_6FF;
						}
						IL_6F0:
						num2 = 97;
						if (l < num7 || l > num8)
						{
							goto IL_6FF;
						}
						IL_726:
						num2 = 101;
						l++;
						continue;
						IL_6FF:
						num2 = 99;
						this.ooo._O.(A_2, l, A_3, A_3.Rows.Count, null, k, null, list);
						IL_71F:
						num2 = 100;
						a_2 = l;
						goto IL_726;
					}
					IL_735:
					num2 = 102;
					this.ooo._O.(A_2, A_3, a_, a_2);
					IL_745:
					num2 = 103;
				}
				IL_757:
				num2 = 104;
				int num13 = num9;
				IL_75E:
				num2 = 105;
				int num14 = count - 1;
				int num15 = num5;
				int num16 = 0;
				while ((num15 >> 31 ^ num16) <= (num15 >> 31 ^ num14))
				{
					IL_773:
					num2 = 106;
					DataRow dataRow3;
					if (num16 < list.Count)
					{
						IL_781:
						num2 = 107;
						dataRow3 = list[num16];
						IL_78F:
						num2 = 108;
						list2.Add(dataRow3);
					}
					else
					{
						IL_79D:
						num2 = 110;
						dataRow3 = null;
					}
					IL_7A3:
					num2 = 111;
					if (dataRow3 != null)
					{
						IL_7AD:
						num2 = 112;
						this.OOO0_O0.O..O_0o_.O_0.(num16, num5, list);
						IL_7C1:
						num2 = 113;
						List<Book.Oo_0o>.Enumerator enumerator3 = this.OOO0_O0.O..o__0_.oO..GetEnumerator();
						while (enumerator3.MoveNext())
						{
							Book.Oo_0o oo_0o = enumerator3.Current;
							IL_7E4:
							num2 = 114;
							GroupHeaderEventArgs groupHeaderEventArgs = new GroupHeaderEventArgs(this, oo_0o.O_0o_.O_0., oo_0o.OoO.o0., new DataRow(dataRow3), false);
							IL_805:
							num2 = 115;
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildGroupHeader", new object[]
							{
								groupHeaderEventArgs
							}, false, "Excel报表", false);
							IL_82A:
							num2 = 116;
							int o_0o_.O_0. = oo_0o.O_0o_.O_0.;
							int oooo.0O__oo. = oo_0o.oooo.0O__oo.;
							for (int m = o_0o_.O_0.; m <= oooo.0O__oo.; m++)
							{
								IL_841:
								num2 = 117;
								this.ooo._O.(A_2, m, A_3, A_3.Rows.Count, dataRow3, 0, null, null);
								IL_860:
								num2 = 118;
							}
							IL_86F:
							num2 = 119;
							this.ooo._O.(A_2, A_3, oo_0o.O_0o_.O_0., oo_0o.oooo.0O__oo.);
							IL_889:
							num2 = 120;
						}
						IL_898:
						num2 = 121;
						((IDisposable)enumerator3).Dispose();
						IL_8A8:
						num2 = 122;
						this.OOO0_O0.O..o__0_.oO..Clear();
					}
					IL_8BB:
					num2 = 123;
					DetailEventArgs detailEventArgs2 = new DetailEventArgs(this, A_0, new DataRow(dataRow3));
					IL_8CE:
					num2 = 124;
					if (dataRow3 != null)
					{
						IL_8D5:
						num2 = 125;
						detailEventArgs2 = new DetailEventArgs(this, A_0, new DataRow(dataRow3));
					}
					else
					{
						IL_8EA:
						num2 = 127;
						detailEventArgs2 = new DetailEventArgs(this, A_0, null);
					}
					IL_8F7:
					num2 = 128;
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildDetail", new object[]
					{
						detailEventArgs2
					}, false, "Excel报表", false);
					IL_91F:
					num2 = 129;
					a_ = num3;
					IL_929:
					num2 = 130;
					int num17 = num3;
					int num18 = num4;
					int n = num17;
					while (n <= num18)
					{
						IL_93C:
						num2 = 131;
						if (num7 <= 0)
						{
							goto IL_95C;
						}
						IL_947:
						num2 = 132;
						if (n < num7 || n > num8)
						{
							goto IL_95C;
						}
						IL_AFC:
						num2 = 150;
						n++;
						continue;
						IL_95C:
						num2 = 134;
						string text3 = A_2[n, 0].Text.Trim(new char[]
						{
							' ',
							'\n',
							'\r'
						});
						IL_988:
						num2 = 135;
						if (n > num3 && n < num4 && dataRow3 != null && Operators.CompareString(text3, "", true) > 0)
						{
							IL_9BA:
							num2 = 136;
							if (LikeOperator.LikeString(text3, "<*>", CompareMethod.Text) && text3.Length >= 3 && Operators.CompareString(text3, "<HeaderRow>", true) != 0 && Operators.CompareString(text3, "<FooterRow>", true) != 0)
							{
								IL_A03:
								num2 = 137;
								text3 = text3.Substring(1, text3.Length - 2);
								IL_A1C:
								num2 = 138;
								string[] array2 = text3.Split(new char[]
								{
									','
								});
								IL_A36:
								num2 = 139;
								text3 = array2[0];
								IL_A42:
								num2 = 140;
								if (this.OoO.o0..ContainsKey(text3))
								{
									IL_A57:
									num2 = 141;
									this.ooo._O.(A_2, A_3, a_, a_2);
									IL_A6A:
									num2 = 142;
									this.ooo._O.(text3, dataRow3, A_2, A_3, num16, list);
									IL_A81:
									num2 = 143;
									if (this.O.o00O0___O..ContainsKey(text3))
									{
										IL_A96:
										num2 = 144;
										n = this.O.o00O0___O.[text3];
									}
									IL_AAB:
									num2 = 145;
									a_ = n + 1;
									goto IL_AFC;
								}
							}
						}
						IL_AB9:
						num2 = 147;
						if (Operators.CompareString(text3, "{Skip}", true) != 0)
						{
							IL_ACE:
							num2 = 148;
							this.ooo._O.(A_2, n, A_3, A_3.Rows.Count, dataRow3, num16, null, list);
						}
						IL_AF2:
						num2 = 149;
						a_2 = n;
						goto IL_AFC;
					}
					IL_B11:
					num2 = 151;
					this.ooo._O.(A_2, A_3, a_, a_2);
					IL_B24:
					num2 = 152;
					num13++;
					IL_B30:
					num2 = 153;
					if (dataRow3 != null)
					{
						IL_B3D:
						num2 = 154;
						if (dataRow3 != null)
						{
							IL_B4A:
							num2 = 155;
							this.oOo_o0.o_0..oooo.0O__oo.(num16, num5, list);
							IL_B61:
							num2 = 156;
							if (this.oOo_o0.o_0..o__0_.oO.)
							{
								IL_B77:
								num2 = 157;
								if (num13 < num9)
								{
									IL_B86:
									num2 = 158;
									int num19 = num13 + 1;
									int num20 = num9;
									for (int num21 = num19; num21 <= num20; num21++)
									{
										IL_B9B:
										num2 = 159;
										detailEventArgs2 = new DetailEventArgs(this, A_0, null);
										IL_BAB:
										num2 = 160;
										O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildDetail", new object[]
										{
											detailEventArgs2
										}, false, "Excel报表", false);
										IL_BD3:
										num2 = 161;
										a_ = num3;
										IL_BDD:
										num2 = 162;
										int num22 = num3;
										int num23 = num4;
										int num24 = num22;
										while (num24 <= num23)
										{
											IL_BED:
											num2 = 163;
											if (num7 <= 0)
											{
												goto IL_C0A;
											}
											IL_BF8:
											num2 = 164;
											if (num24 < num7 || num24 > num8)
											{
												goto IL_C0A;
											}
											IL_C37:
											num2 = 168;
											num24++;
											continue;
											IL_C0A:
											num2 = 166;
											this.ooo._O.(A_2, num24, A_3, A_3.Rows.Count, null, num16, null, list);
											IL_C2D:
											num2 = 167;
											a_2 = num24;
											goto IL_C37;
										}
										IL_C49:
										num2 = 169;
										this.ooo._O.(A_2, A_3, a_, a_2);
										IL_C5C:
										num2 = 170;
									}
									IL_C71:
									num2 = 171;
									num13 = num9;
								}
							}
							IL_C7B:
							num2 = 172;
							int num25 = this.oOo_o0.o_0..o0.o0O__0oo..Count - 1;
							for (int num26 = 0; num26 <= num25; num26++)
							{
								IL_C9D:
								num2 = 173;
								Book.Oo_0o oo_0o2 = this.oOo_o0.o_0..o0.o0O__0oo.[num26];
								IL_CB7:
								num2 = 174;
								GroupFooterEventArgs groupFooterEventArgs = new GroupFooterEventArgs(this, oo_0o2.O_0o_.O_0., oo_0o2.OoO.o0., oo_0o2.oO.o_0o__., this.oO.o_0o__.[this.oO.o_0o__.[oo_0o2.O_0o_.O_0.].Name]);
								IL_CFC:
								num2 = 175;
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildGroupFooter", new object[]
								{
									groupFooterEventArgs
								}, false, "Excel报表", false);
								IL_D24:
								num2 = 176;
								int o_0o_.O_0.2 = oo_0o2.O_0o_.O_0.;
								int oooo.0O__oo.2 = oo_0o2.oooo.0O__oo.;
								for (int num27 = o_0o_.O_0.2; num27 <= oooo.0O__oo.2; num27++)
								{
									IL_D3E:
									num2 = 177;
									this.ooo._O.(A_2, num27, A_3, A_3.Rows.Count, dataRow3, 0, oo_0o2.oO.o_0o__., null);
									IL_D66:
									num2 = 178;
								}
								IL_D78:
								num2 = 179;
								this.ooo._O.(A_2, A_3, oo_0o2.O_0o_.O_0., oo_0o2.oooo.0O__oo.);
								IL_D95:
								num2 = 180;
							}
							IL_DAA:
							num2 = 181;
							this.oOo_o0.o_0..O_0o_.O_0.();
						}
					}
					IL_DBB:
					num2 = 182;
					if (num16 == count - 1 || num16 + num5 >= count)
					{
						IL_DD5:
						num2 = 183;
						if (num13 < num9)
						{
							IL_DE4:
							num2 = 184;
							int num28 = num13 + 1;
							int num29 = num9;
							for (int num30 = num28; num30 <= num29; num30++)
							{
								IL_DF9:
								num2 = 185;
								detailEventArgs2 = new DetailEventArgs(this, A_0, null);
								IL_E09:
								num2 = 186;
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildDetail", new object[]
								{
									detailEventArgs2
								}, false, "Excel报表", false);
								IL_E31:
								num2 = 187;
								a_ = num3;
								IL_E3B:
								num2 = 188;
								int num31 = num3;
								int num32 = num4;
								int num33 = num31;
								while (num33 <= num32)
								{
									IL_E4B:
									num2 = 189;
									if (num7 <= 0)
									{
										goto IL_E68;
									}
									IL_E56:
									num2 = 190;
									if (num33 < num7 || num33 > num8)
									{
										goto IL_E68;
									}
									IL_E95:
									num2 = 194;
									num33++;
									continue;
									IL_E68:
									num2 = 192;
									this.ooo._O.(A_2, num33, A_3, A_3.Rows.Count, null, num16, null, list);
									IL_E8B:
									num2 = 193;
									a_2 = num33;
									goto IL_E95;
								}
								IL_EA7:
								num2 = 195;
								this.ooo._O.(A_2, A_3, a_, a_2);
								IL_EBA:
								num2 = 196;
							}
							IL_ECF:
							num2 = 197;
							num13 = num9;
						}
					}
					IL_ED9:
					num2 = 198;
					if (num13 == num6 || num16 + num5 >= count || this.oOo_o0.o_0..o__0_.oO.)
					{
						IL_EFE:
						num2 = 199;
						num13 = 0;
						IL_F07:
						num2 = 200;
						if (this.OoO.o0..ContainsKey("FooterRow".ToLower()))
						{
							IL_F27:
							num2 = 201;
							if (num7 > num4)
							{
								IL_F36:
								num2 = 202;
								PageFooterEventArgs pageFooterEventArgs = new PageFooterEventArgs(this, list2, this.oO.o_0o__.[list[0].Table.TableName]);
								IL_F63:
								num2 = 203;
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildPageFooter", new object[]
								{
									pageFooterEventArgs
								}, false, "Excel报表", false);
								IL_F8B:
								num2 = 204;
								int num34 = num7;
								int num35 = num8;
								for (int num36 = num34; num36 <= num35; num36++)
								{
									IL_F9B:
									num2 = 205;
									this.ooo._O.(A_2, num36, A_3, A_3.Rows.Count, A_1, A_4, list2, A_5);
									IL_FBF:
									num2 = 206;
								}
								IL_FD1:
								num2 = 207;
								this.ooo._O.(A_2, A_3, num7, num8);
							}
						}
						IL_FE4:
						num2 = 208;
						list2.Clear();
						IL_FF1:
						num2 = 209;
						if (num16 + num5 < count && dataRow3 != null)
						{
							IL_100A:
							num2 = 210;
							if (!this.O_0_o.Oo_oo0_O..ContainsKey(A_0))
							{
								IL_101E:
								num2 = 211;
								A_3.Rows[A_3.Rows.Count - 1].PageBreak = true;
							}
							else
							{
								IL_1046:
								num2 = 213;
								int num37;
								num37++;
								IL_1052:
								num2 = 214;
								if (num37 == this.O_0_o.Oo_oo0_O.[A_0])
								{
									IL_1068:
									num2 = 215;
									num37 = 0;
									IL_1071:
									num2 = 216;
									A_3.Rows[A_3.Rows.Count - 1].PageBreak = true;
								}
							}
							IL_1097:
							num2 = 217;
							if (this.OoO.o0..ContainsKey("HeaderRow".ToLower()))
							{
								IL_10B7:
								num2 = 218;
								int num38 = this.OoO.o0.["HeaderRow".ToLower()];
								IL_10D4:
								num2 = 219;
								int num39 = num38;
								IL_10DE:
								num2 = 220;
								if (this.O.o00O0___O..ContainsKey("HeaderRow".ToLower()))
								{
									IL_10FB:
									num2 = 221;
									num39 = this.O.o00O0___O.["HeaderRow".ToLower()];
								}
								IL_1118:
								num2 = 222;
								if (num39 < num3)
								{
									IL_1127:
									num2 = 223;
									PageHeaderEventArgs pageHeaderEventArgs = new PageHeaderEventArgs(this);
									IL_1135:
									num2 = 224;
									O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildPageHeader", new object[]
									{
										pageHeaderEventArgs
									}, false, "Excel报表", false);
									IL_115D:
									num2 = 225;
									int num40 = num38;
									int num41 = num39;
									for (int num42 = num40; num42 <= num41; num42++)
									{
										IL_116D:
										num2 = 226;
										this.ooo._O.(A_2, num42, A_3, A_3.Rows.Count, A_1, A_4, null, A_5);
										IL_1190:
										num2 = 227;
									}
									IL_11A2:
									num2 = 228;
									this.ooo._O.(A_2, A_3, num38, num39);
								}
							}
							IL_11B5:
							num2 = 229;
							this.OOO0_O0.O..o._0OOooOo_o00.(num16, num5, list);
							IL_11CC:
							num2 = 230;
							List<Book.Oo_0o>.Enumerator enumerator4 = this.OOO0_O0.O..O._0_o0O..GetEnumerator();
							while (enumerator4.MoveNext())
							{
								Book.Oo_0o oo_0o3 = enumerator4.Current;
								IL_11F2:
								num2 = 231;
								GroupHeaderEventArgs groupHeaderEventArgs2 = new GroupHeaderEventArgs(this, oo_0o3.O_0o_.O_0., oo_0o3.OoO.o0., new DataRow(dataRow3), true);
								IL_1216:
								num2 = 232;
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildGroupHeader", new object[]
								{
									groupHeaderEventArgs2
								}, false, "Excel报表", false);
								IL_123E:
								num2 = 233;
								int o_0o_.O_0.3 = oo_0o3.O_0o_.O_0.;
								int oooo.0O__oo.3 = oo_0o3.oooo.0O__oo.;
								for (int num43 = o_0o_.O_0.3; num43 <= oooo.0O__oo.3; num43++)
								{
									IL_1258:
									num2 = 234;
									this.ooo._O.(A_2, num43, A_3, A_3.Rows.Count, dataRow3, 0, null, null);
									IL_127A:
									num2 = 235;
								}
								IL_128C:
								num2 = 236;
								this.ooo._O.(A_2, A_3, oo_0o3.O_0o_.O_0., oo_0o3.oooo.0O__oo.);
								IL_12A9:
								num2 = 237;
							}
							IL_12BB:
							num2 = 238;
							((IDisposable)enumerator4).Dispose();
							IL_12CE:
							num2 = 239;
							this.OOO0_O0.O..O._0_o0O..Clear();
						}
					}
					IL_12E4:
					num2 = 240;
					if (num5 > 1)
					{
						IL_12EF:
						num2 = 241;
						int num44 = num16 + 1;
						int num45 = num16 + num5 - 1;
						for (int num46 = num44; num46 <= num45; num46++)
						{
							IL_1306:
							num2 = 242;
							if (num46 > list.Count - 1)
							{
								break;
							}
							IL_1319:
							num2 = 244;
							if (!this.OOO0_O0.O..o__0_.oO.(list[num16], list[num46]))
							{
								IL_133E:
								num2 = 245;
								num16 = num46 - num5;
								break;
							}
							IL_134D:
							num2 = 247;
						}
					}
					IL_135F:
					num2 = 248;
					num16 += num15;
				}
				IL_1381:
				goto IL_17B7;
				IL_1386:
				int num47 = num48 + 1;
				num48 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num47);
				IL_1778:
				goto IL_17AC;
				IL_177A:
				num48 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_178A:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num48 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_177A;
			}
			IL_17AC:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_17B7:
			if (num48 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x002507D8 File Offset: 0x0024E9D8
		private void <<EMPTY_NAME>>(XLSheet A_0, int A_1, XLSheet A_2, int A_3, DataRow A_4, int A_5, List<DataRow> A_6, List<DataRow> A_7)
		{
			int num;
			int num8;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				XLRow xlrow = A_0.Rows[A_1];
				IL_16:
				num2 = 3;
				XLRow xlrow2 = A_2.Rows[A_3];
				IL_27:
				num2 = 4;
				xlrow2.PageBreak = xlrow.PageBreak;
				IL_36:
				num2 = 5;
				if (xlrow.Height <= 0)
				{
					goto IL_52;
				}
				IL_41:
				num2 = 6;
				xlrow2.Height = xlrow.Height;
				goto IL_61;
				IL_52:
				num2 = 8;
				xlrow2.Height = A_0.DefaultRowHeight;
				IL_61:
				num2 = 9;
				xlrow2.Style = xlrow.Style;
				IL_71:
				num2 = 10;
				xlrow2.Visible = xlrow.Visible;
				IL_81:
				num2 = 11;
				if (A_4 == null)
				{
					goto IL_111;
				}
				IL_8B:
				num2 = 12;
				if (this.oO.o_0o__..ContainsKey(A_4.Table.TableName))
				{
					goto IL_CD;
				}
				IL_A7:
				num2 = 13;
				List<DataRow> value = new List<DataRow>();
				IL_B1:
				num2 = 14;
				this.oO.o_0o__..Add(A_4.Table.TableName, value);
				IL_CD:
				num2 = 15;
				if (this.oO.o_0o__.[A_4.Table.TableName].Contains(A_4))
				{
					goto IL_111;
				}
				IL_F0:
				num2 = 16;
				this.oO.o_0o__.[A_4.Table.TableName].Add(A_4);
				IL_111:
				num2 = 17;
				int oooOOo0.000. = this.OOoOOo0.000.;
				for (int i = 1; i <= oooOOo0.000.; i++)
				{
					IL_124:
					num2 = 18;
					A_2[A_3, i].Value = RuntimeHelpers.GetObjectValue(A_0[A_1, i].Value);
					IL_149:
					num2 = 19;
					A_2[A_3, i].Style = A_0[A_1, i].Style;
					IL_169:
					num2 = 20;
					A_2[A_3, i].Hyperlink = A_0[A_1, i].Hyperlink;
					IL_189:
					num2 = 21;
					A_2[A_3, i].Formula = A_0[A_1, i].Formula;
					IL_1A9:
					num2 = 22;
				}
				IL_1BB:
				num2 = 23;
				int oooOOo0.000.2 = this.OOoOOo0.000.;
				for (int j = 1; j <= oooOOo0.000.2; j++)
				{
					IL_1CE:
					num2 = 24;
					if (Operators.CompareString(A_2[A_2.Rows.Count - 1, j].Formula, "", true) <= 0)
					{
						IL_1FC:
						num2 = 26;
						if (A_2[A_2.Rows.Count - 1, j] != null && !(A_2[A_2.Rows.Count - 1, j].Value is XLPictureShape))
						{
							IL_23D:
							num2 = 28;
							string text = A_2[A_2.Rows.Count - 1, j].Text.Trim(new char[]
							{
								' ',
								'\n',
								'\r'
							});
							IL_272:
							num2 = 29;
							object obj = null;
							IL_278:
							num2 = 30;
							if (Operators.CompareString(text, "", true) > 0)
							{
								IL_28E:
								num2 = 31;
								if (text.StartsWith("<") && text.EndsWith(">") && text.Length >= 3)
								{
									IL_2C0:
									num2 = 32;
									A_2[A_2.Rows.Count - 1, j].Value = null;
									IL_2DE:
									num2 = 33;
									text = text.Substring(1, text.Length - 2);
									IL_2F4:
									num2 = 34;
									if (this.Marks.ContainsKey(text))
									{
										IL_306:
										num2 = 35;
										obj = RuntimeHelpers.GetObjectValue(this.Marks[text]);
									}
									else
									{
										IL_322:
										num2 = 37;
										if (Operators.CompareString(text, "index", true) == 0 && A_4 != null)
										{
											IL_338:
											num2 = 38;
											obj = A_5 + 1;
										}
										else
										{
											for (;;)
											{
												IL_34B:
												num2 = 41;
												int num3 = text.IndexOf("*[");
												IL_35C:
												num2 = 42;
												int num4 = text.IndexOf("]*");
												IL_36D:
												num2 = 43;
												if (num3 < 0 || num4 <= num3)
												{
													break;
												}
												IL_381:
												num2 = 44;
												string a_ = text.Substring(num3 + 1, num4 - num3);
												IL_396:
												num2 = 45;
												object objectValue = RuntimeHelpers.GetObjectValue(this.o_0Oo.0___OO0_.(a_, A_4, A_5, A_6, A_7));
												IL_3B0:
												num2 = 46;
												string text2;
												if (objectValue == null)
												{
													IL_3B7:
													num2 = 47;
													text2 = "";
												}
												else
												{
													IL_3C3:
													num2 = 49;
													text2 = objectValue.ToString();
													IL_3CF:
													num2 = 50;
													if (objectValue is string)
													{
														IL_3DB:
														num2 = 51;
														text2 = "\"" + text2 + "\"";
													}
													else
													{
														IL_3F3:
														num2 = 53;
														if (objectValue is DateTime)
														{
															IL_3FF:
															num2 = 54;
															text2 = "#" + text2 + "#";
														}
													}
												}
												IL_415:
												num2 = 55;
												text = text.Remove(num3, num4 - num3 + 2);
												IL_42A:
												num2 = 56;
												text = text.Insert(num3, text2);
												IL_43A:
												num2 = 57;
												num3 = text.IndexOf("*[");
												IL_44B:
												num2 = 58;
												num4 = text.IndexOf("]*");
											}
											IL_461:
											num2 = 62;
											if (A_4 != null)
											{
												IL_468:
												num2 = 63;
												obj = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval2(text, new DataRow(A_4)));
											}
											else
											{
												IL_485:
												num2 = 65;
												obj = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval2(text));
											}
										}
									}
								}
								else
								{
									IL_49B:
									num2 = 67;
									if (text.StartsWith("[") && text.EndsWith("]") && text.Length >= 3)
									{
										for (;;)
										{
											IL_4CD:
											num2 = 69;
											int num5 = text.IndexOf("<*");
											IL_4DE:
											num2 = 70;
											int num6 = text.IndexOf("*>");
											IL_4EF:
											num2 = 71;
											if (num5 < 0 || num6 <= num5)
											{
												break;
											}
											IL_503:
											num2 = 72;
											string expr = text.Substring(num5 + 2, num6 - num5 - 2);
											IL_51A:
											num2 = 73;
											object objectValue2;
											if (A_4 != null)
											{
												IL_521:
												num2 = 74;
												objectValue2 = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval2(expr, new DataRow(A_4)));
											}
											else
											{
												IL_53B:
												num2 = 76;
												objectValue2 = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval2(expr));
											}
											IL_54C:
											num2 = 77;
											text = text.Remove(num5, num6 - num5 + 2);
											IL_561:
											num2 = 78;
											if (objectValue2 != null)
											{
												IL_568:
												num2 = 79;
												text = text.Insert(num5, objectValue2.ToString());
											}
											IL_57D:
											num2 = 80;
											num5 = text.IndexOf("<*");
											IL_58E:
											num2 = 81;
											num6 = text.IndexOf("*>");
										}
										IL_5A4:
										num2 = 85;
										A_2[A_2.Rows.Count - 1, j].Value = null;
										IL_5C2:
										num2 = 86;
										obj = RuntimeHelpers.GetObjectValue(this.o_0Oo.0___OO0_.(text, A_4, A_5, A_6, A_7));
									}
								}
								IL_5DC:
								num2 = 87;
								if (obj != null)
								{
									IL_5E3:
									num2 = 88;
									A_2[A_2.Rows.Count - 1, j].Value = RuntimeHelpers.GetObjectValue(obj);
								}
							}
						}
					}
					IL_607:
					num2 = 89;
				}
				IL_619:
				goto IL_7D3;
				IL_61E:
				int num7 = num8 + 1;
				num8 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7);
				IL_794:
				goto IL_7C8;
				IL_796:
				num8 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_7A6:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num8 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_796;
			}
			IL_7C8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7D3:
			if (num8 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x00250FDC File Offset: 0x0024F1DC
		private object <<EMPTY_NAME>>(string A_0, DataRow A_1, int A_2, List<DataRow> A_3, List<DataRow> A_4)
		{
			int num;
			object result;
			int num15;
			object obj4;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				object obj = null;
				IL_0C:
				num2 = 3;
				A_0 = A_0.Substring(1, A_0.Length - 2);
				IL_1F:
				num2 = 4;
				if (!A_0.StartsWith("!"))
				{
					goto IL_6E;
				}
				IL_2E:
				num2 = 5;
				A_0 = A_0.Substring(1);
				IL_39:
				num2 = 6;
				if (!OO_00oOO.Vars.VariableTable.Columns.Contains(A_0))
				{
					goto IL_19B0;
				}
				IL_55:
				num2 = 7;
				obj = RuntimeHelpers.GetObjectValue(OO_00oOO.Vars[A_0]);
				goto IL_19B0;
				IL_6E:
				num2 = 9;
				if (!A_0.StartsWith("#"))
				{
					goto IL_274;
				}
				IL_81:
				num2 = 10;
				A_0 = A_0.Substring(1);
				IL_8D:
				num2 = 11;
				string[] array = A_0.Split(new char[]
				{
					','
				});
				IL_A3:
				num2 = 12;
				if (array.Length != 2 || !this.oO.o_0o__..ContainsKey(array[0]))
				{
					goto IL_19B0;
				}
				IL_C4:
				num2 = 13;
				string text = array[1].Trim();
				IL_D2:
				num2 = 14;
				string text2 = array[0];
				IL_DB:
				num2 = 15;
				array = text.Split(new char[]
				{
					'(',
					')'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_F8:
				num2 = 16;
				if (array.Length != 2 || !this.oO.o_0o__.[text2].BaseTable.Columns.Contains(array[1]))
				{
					goto IL_19B0;
				}
				IL_12A:
				num2 = 17;
				System.Data.DataTable dataTable = new System.Data.DataTable();
				IL_134:
				num2 = 18;
				dataTable.Columns.Add(array[1], this.oO.o_0o__.[text2].BaseTable.Columns[array[1]].DataType);
				IL_16D:
				num2 = 19;
				List<DataRow>.Enumerator enumerator = this.oO.o_0o__.[text2].GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = enumerator.Current;
					IL_18F:
					num2 = 20;
					dataTable.Rows.Add(dataTable.NewRow());
					IL_1A5:
					num2 = 21;
					dataTable.Rows[dataTable.Rows.Count - 1][0] = RuntimeHelpers.GetObjectValue(dataRow[array[1]]);
					IL_1D8:
					num2 = 22;
				}
				IL_1E4:
				num2 = 23;
				((IDisposable)enumerator).Dispose();
				IL_1F4:
				num2 = 24;
				if (!text.StartsWith(":"))
				{
					goto IL_257;
				}
				IL_205:
				num2 = 25;
				text = text.Substring(1);
				IL_212:
				num2 = 26;
				obj = RuntimeHelpers.GetObjectValue(dataTable.Compute(text, ""));
				IL_22A:
				num2 = 27;
				string text3 = "";
				IL_234:
				num2 = 28;
				O_O0OO.o.00O_O.(Conversion.Val(RuntimeHelpers.GetObjectValue(obj)), ref text3);
				IL_24B:
				num2 = 29;
				obj = text3;
				goto IL_19B0;
				IL_257:
				num2 = 31;
				obj = RuntimeHelpers.GetObjectValue(dataTable.Compute(text, ""));
				goto IL_19B0;
				IL_274:
				num2 = 33;
				if (!A_0.StartsWith("$"))
				{
					goto IL_3EB;
				}
				IL_287:
				num2 = 34;
				A_0 = A_0.Substring(1);
				IL_293:
				num2 = 35;
				string[] array2 = A_0.Split(new char[]
				{
					','
				});
				IL_2A9:
				num2 = 36;
				string text4 = array2[0];
				IL_2B2:
				num2 = 37;
				string text5 = array2[1].Trim();
				IL_2C0:
				num2 = 38;
				string filter = "";
				IL_2CA:
				num2 = 39;
				if (array2.Length != 3)
				{
					goto IL_2DD;
				}
				IL_2D4:
				num2 = 40;
				filter = array2[2];
				IL_2DD:
				num2 = 41;
				if (!text5.StartsWith(":"))
				{
					goto IL_301;
				}
				IL_2EE:
				num2 = 42;
				bool flag = true;
				IL_2F4:
				num2 = 43;
				text5 = text5.Substring(1);
				IL_301:
				num2 = 44;
				if (!this.oO.o_0o__..Contains(text4))
				{
					goto IL_335;
				}
				IL_313:
				num2 = 45;
				obj = RuntimeHelpers.GetObjectValue(this.oO.o_0o__.[text4].Compute(text5, filter));
				goto IL_399;
				IL_335:
				num2 = 47;
				if (!this.DataTables.Contains(text4))
				{
					goto IL_369;
				}
				IL_347:
				num2 = 48;
				obj = RuntimeHelpers.GetObjectValue(this.DataTables[text4].Compute(text5, filter));
				goto IL_399;
				IL_369:
				num2 = 50;
				if (!OO_00oOO.Tables.get_Contains(text4))
				{
					goto IL_399;
				}
				IL_37A:
				num2 = 51;
				obj = RuntimeHelpers.GetObjectValue(OO_00oOO.Tables[text4].Compute(text5, filter));
				IL_399:
				num2 = 52;
				if (obj != DBNull.Value && obj != null)
				{
					goto IL_3B4;
				}
				IL_3A9:
				num2 = 53;
				obj = 0;
				IL_3B4:
				num2 = 54;
				if (!flag)
				{
					goto IL_19B0;
				}
				IL_3BE:
				num2 = 55;
				string text6 = "";
				IL_3C8:
				num2 = 56;
				O_O0OO.o.00O_O.(Conversion.Val(RuntimeHelpers.GetObjectValue(obj)), ref text6);
				IL_3DF:
				num2 = 57;
				obj = text6;
				goto IL_19B0;
				IL_3EB:
				num2 = 59;
				if (!A_0.StartsWith("%"))
				{
					goto IL_891;
				}
				IL_3FE:
				num2 = 60;
				A_0 = A_0.Substring(1).Trim();
				IL_40F:
				num2 = 61;
				string text7 = "";
				IL_419:
				num2 = 62;
				string text8 = "";
				IL_423:
				num2 = 63;
				if (A_3 == null)
				{
					goto IL_59E;
				}
				IL_42D:
				num2 = 64;
				if (A_3.Count <= 0)
				{
					goto IL_83F;
				}
				IL_43D:
				num2 = 65;
				string[] array3 = A_0.Split(new char[]
				{
					'(',
					')'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_459:
				num2 = 66;
				array3[1] = array3[1].Trim(new char[]
				{
					'[',
					']'
				});
				IL_479:
				num2 = 67;
				if (array3.Length != 2 || !A_3[0].Table.Columns.Contains(array3[1]))
				{
					goto IL_83F;
				}
				IL_4A6:
				num2 = 68;
				System.Data.DataTable dataTable2 = new System.Data.DataTable();
				IL_4B0:
				num2 = 69;
				dataTable2.Columns.Add(array3[1], A_3[0].Table.Columns[array3[1]].DataType);
				IL_4E4:
				num2 = 70;
				List<DataRow>.Enumerator enumerator2 = A_3.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = enumerator2.Current;
					IL_4FB:
					num2 = 71;
					dataTable2.Rows.Add(dataTable2.NewRow());
					IL_511:
					num2 = 72;
					dataTable2.Rows[dataTable2.Rows.Count - 1][0] = RuntimeHelpers.GetObjectValue(dataRow2[array3[1]]);
					IL_544:
					num2 = 73;
				}
				IL_550:
				num2 = 74;
				((IDisposable)enumerator2).Dispose();
				IL_560:
				num2 = 75;
				if (!A_0.StartsWith(":"))
				{
					goto IL_582;
				}
				IL_570:
				num2 = 76;
				bool flag2 = true;
				IL_576:
				num2 = 77;
				A_0 = A_0.Substring(1);
				IL_582:
				num2 = 78;
				obj = RuntimeHelpers.GetObjectValue(dataTable2.Compute(A_0, ""));
				goto IL_83F;
				IL_59E:
				num2 = 80;
				if (A_1 == null)
				{
					goto IL_6B5;
				}
				IL_5A7:
				num2 = 81;
				string[] array4 = A_0.Split(new char[]
				{
					','
				});
				IL_5BD:
				num2 = 82;
				if (!A_1.Table.DataSet.Tables.Contains(array4[0]) || array4.Length < 2)
				{
					goto IL_83F;
				}
				IL_5E8:
				num2 = 83;
				text8 = Oo00.oo0o.O0O_0__.(A_1, array4[0]);
				IL_5F7:
				num2 = 84;
				if (array4.Length != 3)
				{
					goto IL_60A;
				}
				IL_601:
				num2 = 85;
				text7 = array4[2];
				IL_60A:
				num2 = 86;
				if (Operators.CompareString(text8, "", true) <= 0)
				{
					goto IL_83F;
				}
				IL_620:
				num2 = 87;
				if (Operators.CompareString(text7, "", true) <= 0)
				{
					goto IL_644;
				}
				IL_633:
				num2 = 88;
				text7 += " And ";
				IL_644:
				num2 = 89;
				text7 += text8;
				IL_652:
				num2 = 90;
				string text9 = array4[1].Trim();
				IL_660:
				num2 = 91;
				if (!text9.StartsWith(":"))
				{
					goto IL_684;
				}
				IL_671:
				num2 = 92;
				flag2 = true;
				IL_677:
				num2 = 93;
				text9 = text9.Substring(1);
				IL_684:
				num2 = 94;
				obj = RuntimeHelpers.GetObjectValue(A_1.Table.DataSet.Tables[array4[0]].Compute(text9, text7));
				goto IL_83F;
				IL_6B5:
				num2 = 96;
				if (this.OOO0_O0.O. == null)
				{
					goto IL_83F;
				}
				IL_6C3:
				num2 = 97;
				if (this.OOO0_O0.O..Count <= 0)
				{
					goto IL_83F;
				}
				IL_6D7:
				num2 = 98;
				string[] array5 = A_0.Split(new char[]
				{
					'(',
					')'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_6F3:
				num2 = 99;
				array5[1] = array5[1].Trim(new char[]
				{
					'[',
					']'
				});
				IL_713:
				num2 = 100;
				if (array5.Length != 2 || !this.OOO0_O0.O.[0].Table.Columns.Contains(array5[1]))
				{
					goto IL_83F;
				}
				IL_744:
				num2 = 101;
				System.Data.DataTable dataTable3 = new System.Data.DataTable();
				IL_74E:
				num2 = 102;
				dataTable3.Columns.Add(array5[1], this.OOO0_O0.O.[0].Table.Columns[array5[1]].DataType);
				IL_786:
				num2 = 103;
				List<DataRow>.Enumerator enumerator3 = this.OOO0_O0.O..GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow3 = enumerator3.Current;
					IL_7A1:
					num2 = 104;
					dataTable3.Rows.Add(dataTable3.NewRow());
					IL_7B7:
					num2 = 105;
					dataTable3.Rows[dataTable3.Rows.Count - 1][0] = RuntimeHelpers.GetObjectValue(dataRow3[array5[1]]);
					IL_7EA:
					num2 = 106;
				}
				IL_7F6:
				num2 = 107;
				((IDisposable)enumerator3).Dispose();
				IL_806:
				num2 = 108;
				if (!A_0.StartsWith(":"))
				{
					goto IL_828;
				}
				IL_816:
				num2 = 109;
				flag2 = true;
				IL_81C:
				num2 = 110;
				A_0 = A_0.Substring(1);
				IL_828:
				num2 = 111;
				obj = RuntimeHelpers.GetObjectValue(dataTable3.Compute(A_0, ""));
				IL_83F:
				num2 = 112;
				if (obj != DBNull.Value && obj != null)
				{
					goto IL_85A;
				}
				IL_84F:
				num2 = 113;
				obj = 0;
				IL_85A:
				num2 = 114;
				if (!flag2)
				{
					goto IL_19B0;
				}
				IL_864:
				num2 = 115;
				string text10 = "";
				IL_86E:
				num2 = 116;
				O_O0OO.o.00O_O.(Conversion.Val(RuntimeHelpers.GetObjectValue(obj)), ref text10);
				IL_885:
				num2 = 117;
				obj = text10;
				goto IL_19B0;
				IL_891:
				num2 = 119;
				if ((A_1 == null || !A_0.StartsWith("&")) && !A_0.StartsWith("&&"))
				{
					goto IL_D3D;
				}
				IL_8B4:
				num2 = 120;
				A_0 = A_0.Substring(1);
				IL_8C0:
				num2 = 121;
				string[] array6 = A_0.Split(new char[]
				{
					','
				});
				IL_8D6:
				num2 = 122;
				Image image = null;
				IL_8DC:
				num2 = 123;
				if (!array6[0].StartsWith("&"))
				{
					goto IL_913;
				}
				IL_8EF:
				num2 = 124;
				array6[0] = array6[0].Substring(1);
				IL_900:
				num2 = 125;
				image = OO_00oOO.GetImage(array6[0]);
				goto IL_BC5;
				IL_913:
				num2 = 127;
				if (array6[0].IndexOf("+") <= 0)
				{
					goto IL_AC4;
				}
				IL_92A:
				num2 = 128;
				int num3;
				if (!int.TryParse(array6[0].Substring(array6[0].IndexOf("+") + 1), out num3))
				{
					goto IL_BC5;
				}
				IL_955:
				num2 = 129;
				array6[0] = array6[0].Substring(0, array6[0].IndexOf("+"));
				IL_977:
				num2 = 130;
				if (array6[0].IndexOf("&") <= 0)
				{
					goto IL_9D7;
				}
				IL_98E:
				num2 = 131;
				int num4;
				int.TryParse(array6[0].Substring(array6[0].IndexOf("&") + 1), out num4);
				IL_9B5:
				num2 = 132;
				array6[0] = array6[0].Substring(0, array6[0].IndexOf("&"));
				IL_9D7:
				num2 = 133;
				if (A_2 + num3 > A_4.Count - 1)
				{
					goto IL_BC5;
				}
				IL_9EF:
				num2 = 134;
				if (!this.OOO0_O0.O..o__0_.oO.(A_1, A_4[A_2 + num3]))
				{
					goto IL_BC5;
				}
				IL_A11:
				num2 = 135;
				if (!A_1.Table.Columns.Contains(array6[0]))
				{
					goto IL_BC5;
				}
				IL_A30:
				num2 = 136;
				string[] array7 = A_4[A_2 + num3][array6[0]].ToString().Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_A67:
				num2 = 137;
				if (array7.Length - 1 < num4)
				{
					goto IL_BC5;
				}
				IL_A7A:
				num2 = 138;
				string remoteImageFile = Ooo_O.GetRemoteImageFile(array7[num4], this.oO.o_0o__.[A_1.Table.TableName].DataCols[array6[0]]);
				IL_AB0:
				num2 = 139;
				image = OO_00oOO.GetImage(remoteImageFile);
				goto IL_BC5;
				IL_AC4:
				num2 = 141;
				if (array6[0].IndexOf("&") <= 0)
				{
					goto IL_B24;
				}
				IL_ADB:
				num2 = 142;
				int.TryParse(array6[0].Substring(array6[0].IndexOf("&") + 1), out num4);
				IL_B02:
				num2 = 143;
				array6[0] = array6[0].Substring(0, array6[0].IndexOf("&"));
				IL_B24:
				num2 = 144;
				if (!A_1.Table.Columns.Contains(array6[0]))
				{
					goto IL_BC5;
				}
				IL_B43:
				num2 = 145;
				string[] array8 = A_1[array6[0]].ToString().Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_B70:
				num2 = 146;
				if (array8.Length - 1 < num4)
				{
					goto IL_BC5;
				}
				IL_B80:
				num2 = 147;
				string remoteImageFile2 = Ooo_O.GetRemoteImageFile(array8[num4], this.oO.o_0o__.[A_1.Table.TableName].DataCols[array6[0]]);
				IL_BB6:
				num2 = 148;
				image = OO_00oOO.GetImage(remoteImageFile2);
				IL_BC5:
				num2 = 149;
				if (image != null)
				{
					goto IL_BDC;
				}
				IL_BCF:
				num2 = 150;
				result = null;
				goto IL_19B9;
				IL_BDC:
				num2 = 151;
				if (array6.Length != 1)
				{
					goto IL_BF8;
				}
				IL_BE9:
				num2 = 152;
				obj = image;
				goto IL_19B0;
				IL_BF8:
				num2 = 154;
				if (array6.Length != 3)
				{
					goto IL_C4E;
				}
				IL_C05:
				num2 = 155;
				int a_;
				if (!int.TryParse(array6[1], out a_))
				{
					goto IL_19B0;
				}
				IL_C1B:
				num2 = 156;
				int a_2;
				if (!int.TryParse(array6[2], out a_2))
				{
					goto IL_19B0;
				}
				IL_C31:
				num2 = 157;
				obj = new Picture(image, a_, a_2).o0_.O_o.;
				goto IL_19B0;
				IL_C4E:
				num2 = 159;
				if (array6.Length != 5)
				{
					goto IL_19B0;
				}
				IL_C5E:
				num2 = 160;
				int a_3;
				if (!int.TryParse(array6[1], out a_3))
				{
					goto IL_19B0;
				}
				IL_C74:
				num2 = 161;
				int a_4;
				if (!int.TryParse(array6[2], out a_4))
				{
					goto IL_19B0;
				}
				IL_C8A:
				num2 = 162;
				int num5;
				if (!int.TryParse(array6[3], out num5))
				{
					goto IL_19B0;
				}
				IL_CA0:
				num2 = 163;
				int num6;
				if (!int.TryParse(array6[4], out num6))
				{
					goto IL_19B0;
				}
				IL_CB6:
				num2 = 164;
				if (num6 != -1 || num5 <= 0)
				{
					goto IL_CE9;
				}
				IL_CC6:
				num2 = 165;
				num6 = (int)Math.Round((double)image.Height / (double)image.Width * (double)num5);
				IL_CE9:
				num2 = 166;
				if (num5 != -1 || num6 <= 0)
				{
					goto IL_D1C;
				}
				IL_CF9:
				num2 = 167;
				num5 = (int)Math.Round((double)image.Width / (double)image.Height * (double)num6);
				IL_D1C:
				num2 = 168;
				obj = new Picture(image, a_3, a_4, num5, num6).o0_.O_o.;
				goto IL_19B0;
				IL_D3D:
				num2 = 170;
				if (!A_0.StartsWith("@") || A_0.IndexOf(",") <= 0)
				{
					goto IL_11F6;
				}
				IL_D64:
				num2 = 171;
				string[] array9 = A_0.Split(new char[]
				{
					','
				});
				IL_D7D:
				num2 = 172;
				string text11 = array9[0].Trim().Substring(1);
				IL_D94:
				num2 = 173;
				string text12 = array9[1].Trim();
				IL_DA5:
				num2 = 174;
				int num7 = -1;
				IL_DAE:
				num2 = 175;
				string text13 = null;
				IL_DB7:
				num2 = 176;
				object obj2 = null;
				IL_DC0:
				num2 = 177;
				if (!text12.StartsWith("&"))
				{
					goto IL_E43;
				}
				IL_DD4:
				num2 = 178;
				bool flag3 = true;
				IL_DDD:
				num2 = 179;
				text12 = text12.Substring(1);
				IL_DED:
				num2 = 180;
				if (text12.IndexOf("&") <= 0)
				{
					goto IL_E70;
				}
				IL_E02:
				num2 = 181;
				int num8;
				int.TryParse(text12.Substring(text12.IndexOf("&") + 1), out num8);
				IL_E25:
				num2 = 182;
				text12 = text12.Substring(0, text12.IndexOf("&"));
				goto IL_E70;
				IL_E43:
				num2 = 184;
				if (!text12.StartsWith(":"))
				{
					goto IL_E70;
				}
				IL_E57:
				num2 = 185;
				bool flag4 = true;
				IL_E60:
				num2 = 186;
				text12 = text12.Substring(1);
				IL_E70:
				num2 = 187;
				if (array9.Length < 3)
				{
					goto IL_E99;
				}
				IL_E7D:
				num2 = 188;
				if (int.TryParse(array9[2], out num7))
				{
					goto IL_E99;
				}
				IL_E90:
				num2 = 189;
				num7 = -1;
				IL_E99:
				num2 = 190;
				if (!OO_00oOO.Tables.get_Contains(text11) || !OO_00oOO.Tables[text11].Cols.Contains(text12))
				{
					goto IL_FEB;
				}
				IL_ECD:
				num2 = 191;
				if (num7 != -1)
				{
					goto IL_F41;
				}
				IL_ED8:
				num2 = 192;
				if (OO_00oOO.Tables[text11].Current == null)
				{
					goto IL_FEB;
				}
				IL_EF4:
				num2 = 193;
				if (OO_00oOO.Tables[text11].Current.get_IsNull(text12))
				{
					goto IL_FEB;
				}
				IL_F17:
				num2 = 194;
				obj2 = RuntimeHelpers.GetObjectValue(OO_00oOO.Tables[text11].Current[text12]);
				goto IL_FEB;
				IL_F41:
				num2 = 196;
				if (!array9[2].StartsWith("+"))
				{
					goto IL_F73;
				}
				IL_F57:
				num2 = 197;
				num7 = OO_00oOO.Tables[text11].Position + num7;
				IL_F73:
				num2 = 198;
				if (num7 < 0 || num7 >= OO_00oOO.Tables[text11].Rows.Count)
				{
					goto IL_FEB;
				}
				IL_F98:
				num2 = 199;
				if (OO_00oOO.Tables[text11].Rows[num7].get_IsNull(text12))
				{
					goto IL_FEB;
				}
				IL_FBF:
				num2 = 200;
				obj2 = RuntimeHelpers.GetObjectValue(OO_00oOO.Tables[text11].Rows[num7][text12]);
				IL_FEB:
				num2 = 201;
				if (obj2 == null)
				{
					goto IL_19B0;
				}
				IL_FF8:
				num2 = 202;
				if (flag3)
				{
					goto IL_105E;
				}
				IL_1002:
				num2 = 203;
				obj = RuntimeHelpers.GetObjectValue(obj2);
				IL_1011:
				num2 = 204;
				if (!flag4)
				{
					goto IL_19B0;
				}
				IL_101E:
				num2 = 205;
				string text14 = "";
				IL_102B:
				num2 = 206;
				double a_5 = Conversion.Val(RuntimeHelpers.GetObjectValue(obj));
				IL_103F:
				num2 = 207;
				O_O0OO.o.00O_O.(a_5, ref text14);
				IL_104F:
				num2 = 208;
				obj = text14;
				goto IL_19B0;
				IL_105E:
				num2 = 210;
				text13 = obj2.ToString();
				IL_106D:
				num2 = 211;
				Image image2 = null;
				IL_1076:
				num2 = 212;
				string[] array10 = text13.Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_1096:
				num2 = 213;
				if (array10.Length - 1 < num8)
				{
					goto IL_10E4;
				}
				IL_10A6:
				num2 = 214;
				string remoteImageFile3 = Ooo_O.GetRemoteImageFile(array10[num8], OO_00oOO.Tables[text11].DataTable.DataCols[text12]);
				IL_10D5:
				num2 = 215;
				image2 = OO_00oOO.GetImage(remoteImageFile3);
				IL_10E4:
				num2 = 216;
				if (image2 != null)
				{
					goto IL_10FB;
				}
				IL_10EE:
				num2 = 217;
				result = null;
				goto IL_19B9;
				IL_10FB:
				num2 = 218;
				if (array9.Length > 3)
				{
					goto IL_1117;
				}
				IL_1108:
				num2 = 219;
				obj = image2;
				goto IL_19B0;
				IL_1117:
				num2 = 221;
				if (array9.Length != 5)
				{
					goto IL_116D;
				}
				IL_1124:
				num2 = 222;
				int a_6;
				if (!int.TryParse(array9[3], out a_6))
				{
					goto IL_19B0;
				}
				IL_113A:
				num2 = 223;
				int a_7;
				if (!int.TryParse(array9[4], out a_7))
				{
					goto IL_19B0;
				}
				IL_1150:
				num2 = 224;
				obj = new Picture(image2, a_6, a_7).o0_.O_o.;
				goto IL_19B0;
				IL_116D:
				num2 = 226;
				if (array9.Length != 7)
				{
					goto IL_19B0;
				}
				IL_117D:
				num2 = 227;
				int a_8;
				if (!int.TryParse(array9[3], out a_8))
				{
					goto IL_19B0;
				}
				IL_1193:
				num2 = 228;
				int a_9;
				if (!int.TryParse(array9[4], out a_9))
				{
					goto IL_19B0;
				}
				IL_11A9:
				num2 = 229;
				int a_10;
				if (!int.TryParse(array9[5], out a_10))
				{
					goto IL_19B0;
				}
				IL_11BF:
				num2 = 230;
				int a_11;
				if (!int.TryParse(array9[6], out a_11))
				{
					goto IL_19B0;
				}
				IL_11D5:
				num2 = 231;
				obj = new Picture(image2, a_8, a_9, a_10, a_11).o0_.O_o.;
				goto IL_19B0;
				IL_11F6:
				num2 = 233;
				if (A_1 == null || A_0.IndexOf(",") <= 0)
				{
					goto IL_17D1;
				}
				IL_1213:
				num2 = 234;
				string[] array11 = A_0.Split(new char[]
				{
					','
				});
				IL_122C:
				num2 = 235;
				string text15 = array11[1].Trim();
				IL_123D:
				num2 = 236;
				string[] array12 = array11[0].Split(new char[]
				{
					'.'
				});
				IL_1259:
				num2 = 237;
				DataRow dataRow4 = A_1;
				IL_1262:
				num2 = 238;
				if (!text15.StartsWith("&"))
				{
					goto IL_1291;
				}
				IL_1276:
				num2 = 239;
				text15 = text15.Substring(1);
				IL_1286:
				num2 = 240;
				bool flag5 = true;
				goto IL_12BE;
				IL_1291:
				num2 = 242;
				if (!text15.StartsWith(":"))
				{
					goto IL_12BE;
				}
				IL_12A5:
				num2 = 243;
				text15 = text15.Substring(1);
				IL_12B5:
				num2 = 244;
				bool flag6 = true;
				IL_12BE:
				num2 = 245;
				int num9 = array12.Length - 1;
				bool flag7;
				for (int i = 0; i <= num9; i++)
				{
					IL_12D4:
					num2 = 246;
					string right = array12[i].Trim();
					IL_12E6:
					num2 = 247;
					flag7 = false;
					IL_12EF:
					num2 = 248;
					DataSet dataSet = dataRow4.Table.DataSet;
					IL_1303:
					num2 = 249;
					IEnumerator enumerator4 = dataSet.Relations.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						object obj3 = enumerator4.Current;
						DataRelation dataRelation = (DataRelation)obj3;
						IL_1327:
						num2 = 250;
						if (Operators.CompareString(dataRelation.ParentTable.TableName, right, true) == 0 && Operators.CompareString(dataRelation.ChildTable.TableName, dataRow4.Table.TableName, true) == 0)
						{
							IL_1363:
							num2 = 251;
							flag7 = true;
							IL_136C:
							num2 = 252;
							dataRow4 = dataRow4.GetParentRow(dataRelation.RelationName);
							IL_1382:
							num2 = 253;
							if (dataRow4 == null)
							{
								break;
							}
						}
						IL_138C:
						num2 = 255;
					}
					IL_139E:
					num2 = 256;
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
					IL_13B9:
					num2 = 257;
					if (!flag7)
					{
						break;
					}
					IL_13C3:
					num2 = 259;
				}
				IL_13D8:
				num2 = 260;
				if (!flag7 || dataRow4 == null || dataRow4 == A_1)
				{
					goto IL_19B0;
				}
				IL_13F4:
				num2 = 261;
				if (text15.IndexOf("&") <= 0)
				{
					goto IL_1448;
				}
				IL_1409:
				num2 = 262;
				int num10;
				int.TryParse(text15.Substring(text15.IndexOf("&") + 1), out num10);
				IL_142C:
				num2 = 263;
				text15 = text15.Substring(0, text15.IndexOf("&"));
				IL_1448:
				num2 = 264;
				if (dataRow4.Table.Columns.Contains(text15))
				{
					goto IL_1470;
				}
				IL_1463:
				num2 = 265;
				result = null;
				goto IL_19B9;
				IL_1470:
				num2 = 266;
				if (!flag5)
				{
					goto IL_175A;
				}
				IL_147D:
				num2 = 267;
				Image image3 = null;
				IL_1486:
				num2 = 268;
				string[] array13 = dataRow4[text15].ToString().Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_14B2:
				num2 = 269;
				if (array13.Length - 1 < num10)
				{
					goto IL_15E2;
				}
				IL_14C5:
				num2 = 270;
				string imageFile = "";
				IL_14D2:
				num2 = 271;
				if (!this.oO.o_0o__..Contains(dataRow4.Table.TableName))
				{
					goto IL_152B;
				}
				IL_14F1:
				num2 = 272;
				imageFile = Ooo_O.GetRemoteImageFile(array13[num10], this.oO.o_0o__.[dataRow4.Table.TableName].DataCols[text15]);
				goto IL_15D3;
				IL_152B:
				num2 = 274;
				if (!this.DataTables.Contains(dataRow4.Table.TableName))
				{
					goto IL_1581;
				}
				IL_154A:
				num2 = 275;
				imageFile = Ooo_O.GetRemoteImageFile(array13[num10], this.DataTables[dataRow4.Table.TableName].DataCols[text15]);
				goto IL_15D3;
				IL_1581:
				num2 = 277;
				if (!OO_00oOO.DataTables.Contains(dataRow4.Table.TableName))
				{
					goto IL_15D3;
				}
				IL_159F:
				num2 = 278;
				imageFile = Ooo_O.GetRemoteImageFile(array13[num10], OO_00oOO.DataTables[dataRow4.Table.TableName].DataCols[text15]);
				IL_15D3:
				num2 = 279;
				image3 = OO_00oOO.GetImage(imageFile);
				IL_15E2:
				num2 = 280;
				if (image3 != null)
				{
					goto IL_15F9;
				}
				IL_15EC:
				num2 = 281;
				result = null;
				goto IL_19B9;
				IL_15F9:
				num2 = 282;
				if (array11.Length != 2)
				{
					goto IL_1615;
				}
				IL_1606:
				num2 = 283;
				obj = image3;
				goto IL_19B0;
				IL_1615:
				num2 = 285;
				if (array11.Length != 4)
				{
					goto IL_166B;
				}
				IL_1622:
				num2 = 286;
				int a_12;
				if (!int.TryParse(array11[2], out a_12))
				{
					goto IL_19B0;
				}
				IL_1638:
				num2 = 287;
				int a_13;
				if (!int.TryParse(array11[3], out a_13))
				{
					goto IL_19B0;
				}
				IL_164E:
				num2 = 288;
				obj = new Picture(image3, a_12, a_13).o0_.O_o.;
				goto IL_19B0;
				IL_166B:
				num2 = 290;
				if (array11.Length != 6)
				{
					goto IL_19B0;
				}
				IL_167B:
				num2 = 291;
				int a_14;
				if (!int.TryParse(array11[2], out a_14))
				{
					goto IL_19B0;
				}
				IL_1691:
				num2 = 292;
				int a_15;
				if (!int.TryParse(array11[3], out a_15))
				{
					goto IL_19B0;
				}
				IL_16A7:
				num2 = 293;
				int num11;
				if (!int.TryParse(array11[4], out num11))
				{
					goto IL_19B0;
				}
				IL_16BD:
				num2 = 294;
				int num12;
				if (!int.TryParse(array11[5], out num12))
				{
					goto IL_19B0;
				}
				IL_16D3:
				num2 = 295;
				if (num12 != -1 || num11 <= 0)
				{
					goto IL_1706;
				}
				IL_16E3:
				num2 = 296;
				num12 = (int)Math.Round((double)image3.Height / (double)image3.Width * (double)num11);
				IL_1706:
				num2 = 297;
				if (num11 != -1 || num12 <= 0)
				{
					goto IL_1739;
				}
				IL_1716:
				num2 = 298;
				num11 = (int)Math.Round((double)image3.Width / (double)image3.Height * (double)num12);
				IL_1739:
				num2 = 299;
				obj = new Picture(image3, a_14, a_15, num11, num12).o0_.O_o.;
				goto IL_19B0;
				IL_175A:
				num2 = 301;
				if (dataRow4.IsNull(text15))
				{
					goto IL_19B0;
				}
				IL_176E:
				num2 = 302;
				obj = RuntimeHelpers.GetObjectValue(dataRow4[text15]);
				IL_1784:
				num2 = 303;
				if (!flag6)
				{
					goto IL_19B0;
				}
				IL_1791:
				num2 = 304;
				string text16 = "";
				IL_179E:
				num2 = 305;
				double a_16 = Conversion.Val(RuntimeHelpers.GetObjectValue(obj));
				IL_17B2:
				num2 = 306;
				O_O0OO.o.00O_O.(a_16, ref text16);
				IL_17C2:
				num2 = 307;
				obj = text16;
				goto IL_19B0;
				IL_17D1:
				num2 = 309;
				if (A_1 == null || !A_0.StartsWith(":"))
				{
					goto IL_1883;
				}
				IL_17ED:
				num2 = 310;
				A_0 = A_0.Substring(1).Trim();
				IL_1801:
				num2 = 311;
				if (!A_1.Table.Columns.Contains(A_0))
				{
					goto IL_19B0;
				}
				IL_181D:
				num2 = 312;
				if (A_1.IsNull(A_0))
				{
					goto IL_19B0;
				}
				IL_182F:
				num2 = 313;
				obj = RuntimeHelpers.GetObjectValue(A_1[A_0]);
				IL_1843:
				num2 = 314;
				string text17 = "";
				IL_1850:
				num2 = 315;
				double a_17 = Conversion.Val(RuntimeHelpers.GetObjectValue(obj));
				IL_1864:
				num2 = 316;
				O_O0OO.o.00O_O.(a_17, ref text17);
				IL_1874:
				num2 = 317;
				obj = text17;
				goto IL_19B0;
				IL_1883:
				num2 = 319;
				if (A_1 == null)
				{
					goto IL_19B0;
				}
				IL_188F:
				num2 = 320;
				if (!A_1.Table.Columns.Contains(A_0))
				{
					goto IL_18D3;
				}
				IL_18A8:
				num2 = 321;
				if (A_1.IsNull(A_0))
				{
					goto IL_19B0;
				}
				IL_18BA:
				num2 = 322;
				obj = RuntimeHelpers.GetObjectValue(A_1[A_0]);
				goto IL_19B0;
				IL_18D3:
				num2 = 324;
				if (A_0.IndexOf("+") <= 0)
				{
					goto IL_19B0;
				}
				IL_18EA:
				num2 = 325;
				int num13;
				if (!int.TryParse(A_0.Substring(A_0.IndexOf("+") + 1), out num13))
				{
					goto IL_19B0;
				}
				IL_190F:
				num2 = 326;
				if (A_2 + num13 > A_4.Count - 1)
				{
					goto IL_19B0;
				}
				IL_1927:
				num2 = 327;
				if (!this.OOO0_O0.O..o__0_.oO.(A_1, A_4[A_2 + num13]))
				{
					goto IL_19B0;
				}
				IL_1946:
				num2 = 328;
				A_0 = A_0.Substring(0, A_0.IndexOf("+"));
				IL_1960:
				num2 = 329;
				if (!A_1.Table.Columns.Contains(A_0))
				{
					goto IL_19B0;
				}
				IL_1979:
				num2 = 330;
				if (A_4[A_2 + num13].IsNull(A_0))
				{
					goto IL_19B0;
				}
				IL_1992:
				num2 = 331;
				obj = RuntimeHelpers.GetObjectValue(A_4[A_2 + num13][A_0]);
				IL_19B0:
				num2 = 332;
				result = obj;
				IL_19B9:
				goto IL_1F3F;
				IL_19BE:
				int num14 = num15 + 1;
				num15 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num14);
				IL_1F00:
				goto IL_1F34;
				IL_1F02:
				num15 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1F12:;
			}
			catch when (endfilter(obj4 is Exception & num != 0 & num15 == 0))
			{
				Exception ex = (Exception)obj5;
				goto IL_1F02;
			}
			IL_1F34:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1F3F:
			if (num15 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x00252F50 File Offset: 0x00251150
		private bool <<EMPTY_NAME>>(XLSheet A_0)
		{
			int num;
			bool result;
			int num9;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				IL_09:
				num2 = 3;
				List<string> list = new List<string>();
				IL_12:
				num2 = 4;
				this.OoO.o0..Clear();
				IL_1F:
				num2 = 5;
				this.O.o00O0___O..Clear();
				IL_2C:
				num2 = 6;
				this.O_0_o.Oo_oo0_O..Clear();
				IL_39:
				num2 = 7;
				this.O_ooo.o0..Clear();
				IL_46:
				num2 = 8;
				this.Ooo.00_O0_0_..Clear();
				IL_53:
				num2 = 9;
				this.o._0_Oo0o..Clear();
				IL_61:
				num2 = 10;
				this.OOO0_O0.O..Clear();
				IL_6F:
				num2 = 11;
				this.O_0_o.Oo_oo0_O..Clear();
				IL_7D:
				num2 = 12;
				this.OOO0_O0.O..Clear();
				IL_8B:
				num2 = 13;
				this.oOo_o0.o_0..Clear();
				IL_99:
				num2 = 14;
				this.oO.o_0o__..Clear();
				IL_A7:
				num2 = 15;
				this.oOo_o0.o_0. = A_0.Rows.Count - 1;
				IL_BD:
				num2 = 16;
				this.OOoOOo0.000. = A_0.Columns.Count - 1;
				IL_D3:
				num2 = 17;
				int num3 = A_0.Columns.Count - 1;
				for (int i = 2; i <= num3; i++)
				{
					IL_EA:
					num2 = 18;
					string text = A_0[0, i].Text.Trim(new char[]
					{
						' ',
						'\r',
						'\n'
					});
					IL_113:
					num2 = 19;
					if (Operators.CompareString(text, "<End>", true) == 0)
					{
						IL_125:
						num2 = 20;
						this.OOoOOo0.000. = i - 1;
						break;
					}
					IL_134:
					num2 = 22;
				}
				IL_143:
				num2 = 23;
				this.OOoOOo0.000. = "";
				IL_151:
				num2 = 24;
				int num4 = A_0.Rows.Count - 1;
				for (int j = 0; j <= num4; j++)
				{
					IL_16B:
					num2 = 25;
					string text = A_0[j, 0].Text.Trim(new char[]
					{
						' ',
						'\r',
						'\n'
					});
					IL_194:
					num2 = 26;
					if (Operators.CompareString(text, "", true) > 0)
					{
						IL_1AA:
						num2 = 27;
						if (LikeOperator.LikeString(text, "<*>", CompareMethod.Text) && text.Length >= 3)
						{
							IL_1CC:
							num2 = 28;
							text = text.Substring(1, text.Length - 2);
							IL_1E2:
							num2 = 29;
							string[] array = text.Split(new char[]
							{
								','
							});
							IL_1F9:
							num2 = 30;
							if (this.oO.o_0o__..Contains(array[0]) || OO_00oOO.Tables.get_Contains(array[0]))
							{
								IL_220:
								num2 = 31;
								if (!this.OoO.o0..ContainsKey(array[0]))
								{
									IL_237:
									num2 = 32;
									this.OoO.o0..Add(array[0], j);
									IL_24B:
									num2 = 33;
									if (this.OOoOOo0.000. < A_0.Columns.Count - 1)
									{
										IL_266:
										num2 = 34;
										string text2 = A_0[j, this.OOoOOo0.000. + 1].Text.Trim(new char[]
										{
											' ',
											'\n',
											'\r'
										});
										IL_296:
										num2 = 35;
										if (Operators.CompareString(text2, "", true) > 0)
										{
											IL_2A9:
											num2 = 36;
											if (!this.O_0_o.Oo_oo0_O..ContainsKey(array[0]))
											{
												IL_2BD:
												num2 = 37;
												this.O_0_o.Oo_oo0_O..Add(array[0], text2.Trim(new char[]
												{
													'<',
													'>'
												}));
											}
										}
									}
									IL_2E6:
									num2 = 38;
									int num5 = array.Length - 1;
									for (int k = 1; k <= num5; k++)
									{
										IL_2F9:
										num2 = 39;
										int value;
										if (int.TryParse(array[k], out value))
										{
											IL_30A:
											num2 = 40;
											if (!this.Ooo.00_O0_0_..ContainsKey(array[0]))
											{
												IL_321:
												num2 = 41;
												this.Ooo.00_O0_0_..Add(array[0], value);
											}
										}
										else
										{
											IL_33A:
											num2 = 43;
											if (array[k].StartsWith("(") && array[k].EndsWith(")"))
											{
												IL_365:
												num2 = 44;
												array[k] = array[k].Substring(1, array[k].Length - 2);
												IL_384:
												num2 = 45;
												string[] array2 = array[k].Split(new char[]
												{
													'|'
												});
												IL_39E:
												num2 = 46;
												if (int.TryParse(array2[0], out value))
												{
													IL_3AE:
													num2 = 47;
													if (!this.Ooo.00_O0_0_..ContainsKey(array[0]))
													{
														IL_3C2:
														num2 = 48;
														this.Ooo.00_O0_0_..Add(array[0], value);
													}
												}
												IL_3D6:
												num2 = 49;
												if (array2.Length == 2)
												{
													IL_3E3:
													num2 = 50;
													if (int.TryParse(array2[1], out value))
													{
														IL_3F6:
														num2 = 51;
														if (!this.O_0_o.Oo_oo0_O..ContainsKey(array[0]))
														{
															IL_40D:
															num2 = 52;
															this.O_0_o.Oo_oo0_O..Add(array[0], value);
														}
													}
												}
											}
											else
											{
												IL_426:
												num2 = 54;
												if ((array[k].StartsWith("{") && array[k].EndsWith("}")) || array[k].StartsWith("@"))
												{
													IL_45C:
													num2 = 55;
													array[k] = array[k].Trim(new char[]
													{
														'{',
														'}',
														'@'
													});
													IL_47F:
													num2 = 56;
													if (int.TryParse(array[k], out value))
													{
														IL_490:
														num2 = 57;
														if (!this.o._0_Oo0o..ContainsKey(array[0]))
														{
															IL_4A4:
															num2 = 58;
															this.o._0_Oo0o..Add(array[0], value);
														}
													}
												}
												else
												{
													IL_4BA:
													num2 = 60;
													if (!this.O_ooo.o0..ContainsKey(array[0]))
													{
														IL_4CE:
														num2 = 61;
														this.O_ooo.o0..Add(array[0], array[1].Replace("|", ","));
													}
												}
											}
										}
										IL_4F3:
										num2 = 62;
									}
									IL_505:
									num2 = 63;
									if (Operators.CompareString(this.OOoOOo0.000., "", true) == 0)
									{
										IL_51B:
										num2 = 64;
										this.OOoOOo0.000. = array[0];
									}
									IL_528:
									num2 = 65;
									list.Add(array[0]);
									goto IL_84A;
								}
								IL_53B:
								num2 = 67;
								if (!this.O.o00O0___O..ContainsKey(array[0]))
								{
									IL_54F:
									num2 = 68;
									this.O.o00O0___O..Add(array[0], j);
									goto IL_84A;
								}
								IL_568:
								num2 = 70;
								MessageBox.Show("细节区定义错误，每个表只能在报表中有一个细节区！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								IL_57E:
								num2 = 71;
								result = false;
							}
							else
							{
								IL_588:
								num2 = 73;
								if (Operators.CompareString(array[0], "HeaderRow", true) == 0 || Operators.CompareString(array[0], "FooterRow", true) == 0)
								{
									IL_5AD:
									num2 = 74;
									if (!this.OoO.o0..ContainsKey(array[0].ToLower()))
									{
										IL_5C6:
										num2 = 75;
										this.OoO.o0..Add(array[0].ToLower(), j);
										goto IL_84A;
									}
									IL_5E4:
									num2 = 77;
									if (!this.O.o00O0___O..ContainsKey(array[0].ToLower()))
									{
										IL_600:
										num2 = 78;
										this.O.o00O0___O..Add(array[0].ToLower(), j);
										goto IL_84A;
									}
									goto IL_84A;
								}
								else
								{
									IL_61E:
									num2 = 80;
									if (Operators.CompareString(array[0], "GroupHeader", true) == 0)
									{
										IL_635:
										num2 = 81;
										if (array.Length < 3)
										{
											goto IL_84A;
										}
										IL_642:
										num2 = 82;
										Book.Oo_0o oo_0o = this.OOO0_O0.O..o0.o0O__0oo.(array[1], array[2]);
										IL_65A:
										num2 = 83;
										if (oo_0o == null)
										{
											IL_661:
											num2 = 84;
											oo_0o = this.OOO0_O0.O..O_0o_.O_0.(array[1], array[2]);
											IL_679:
											num2 = 85;
											oo_0o.O_0o_.O_0. = j;
										}
										else
										{
											IL_687:
											num2 = 87;
											oo_0o.oooo.0O__oo. = j;
										}
										IL_693:
										num2 = 88;
										if (array.Length != 4)
										{
											goto IL_84A;
										}
										IL_6A0:
										num2 = 89;
										if (Operators.CompareString(array[3], "1", true) == 0)
										{
											IL_6B7:
											num2 = 90;
											oo_0o.oooo.0O__oo. = true;
											goto IL_84A;
										}
										goto IL_84A;
									}
									else
									{
										IL_6C7:
										num2 = 92;
										if (Operators.CompareString(array[0], "GroupFooter", true) == 0)
										{
											IL_6DE:
											num2 = 93;
											if (array.Length < 3)
											{
												goto IL_84A;
											}
											IL_6EB:
											num2 = 94;
											Book.Oo_0o oo_0o2 = this.oOo_o0.o_0..o0.o0O__0oo.(array[1], array[2]);
											IL_703:
											num2 = 95;
											if (oo_0o2 == null)
											{
												IL_70A:
												num2 = 96;
												oo_0o2 = this.oOo_o0.o_0..O_0o_.O_0.(array[1], array[2]);
												IL_722:
												num2 = 97;
												oo_0o2.O_0o_.O_0. = j;
											}
											else
											{
												IL_730:
												num2 = 99;
												oo_0o2.oooo.0O__oo. = j;
											}
											IL_73C:
											num2 = 100;
											if (array.Length != 4)
											{
												goto IL_84A;
											}
											IL_749:
											num2 = 101;
											if (Operators.CompareString(array[3], "1", true) == 0)
											{
												IL_760:
												num2 = 102;
												oo_0o2.oO.o_0o__. = true;
												goto IL_84A;
											}
											goto IL_84A;
										}
										else
										{
											IL_770:
											num2 = 104;
											if (Operators.CompareString(array[0], "End", true) == 0)
											{
												IL_787:
												num2 = 105;
												this.oOo_o0.o_0. = j - 1;
												IL_794:
												num2 = 106;
												int num6 = A_0.Columns.Count - 2;
												for (int l = 1; l <= num6; l++)
												{
													IL_7AB:
													num2 = 107;
													text = A_0[j, l].Text.Trim(new char[]
													{
														' ',
														'\r',
														'\n'
													});
													IL_7D5:
													num2 = 108;
													if (Operators.CompareString(text, "<M>", true) == 0)
													{
														IL_7E7:
														num2 = 109;
														this.OOO0_O0.O..Add(l);
													}
													else
													{
														IL_7F9:
														num2 = 111;
														if (Operators.CompareString(text, "<End>", true) == 0)
														{
															break;
														}
													}
													IL_80B:
													num2 = 113;
												}
												goto IL_84A;
											}
											IL_81C:
											num2 = 115;
											MessageBox.Show("细节区定义错误，表\"" + array[0] + "\"不存在，或已经被删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
											IL_840:
											num2 = 116;
											result = false;
										}
									}
								}
							}
							IL_CC7:
							goto IL_FC1;
						}
					}
					IL_84A:
					num2 = 117;
				}
				IL_85C:
				num2 = 118;
				if (this.oOo_o0.o_0. != 0)
				{
					goto IL_87D;
				}
				IL_867:
				num2 = 119;
				this.oOo_o0.o_0. = A_0.Rows.Count - 1;
				IL_87D:
				num2 = 120;
				if (this.OOoOOo0.000. != 0)
				{
					goto IL_89E;
				}
				IL_888:
				num2 = 121;
				this.OOoOOo0.000. = A_0.Columns.Count - 1;
				IL_89E:
				num2 = 122;
				Dictionary<string, int>.KeyCollection.Enumerator enumerator = this.O.o00O0___O..Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string key = enumerator.Current;
					IL_8BE:
					num2 = 123;
					this.oOo_o0.o_0. = Math.Max(this.oOo_o0.o_0., this.O.o00O0___O.[key]);
					IL_8DF:
					num2 = 124;
				}
				IL_8EB:
				num2 = 125;
				((IDisposable)enumerator).Dispose();
				IL_8FB:
				num2 = 126;
				Dictionary<string, int>.KeyCollection.Enumerator enumerator2 = this.OoO.o0..Keys.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string key2 = enumerator2.Current;
					IL_91B:
					num2 = 127;
					this.oOo_o0.o_0. = Math.Max(this.oOo_o0.o_0., this.OoO.o0.[key2]);
					IL_93C:
					num2 = 128;
				}
				IL_94B:
				num2 = 129;
				((IDisposable)enumerator2).Dispose();
				IL_95E:
				num2 = 130;
				List<string>.Enumerator enumerator3 = list.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					string text3 = enumerator3.Current;
					IL_978:
					num2 = 131;
					if (!this.oO.o_0o__..Contains(text3))
					{
						IL_98D:
						num2 = 132;
						if (OO_00oOO.Tables.get_Contains(text3))
						{
							IL_9A1:
							num2 = 133;
							this.oO.o_0o__..add(text3, OO_00oOO.Tables[text3].DataTable);
						}
					}
					IL_9C5:
					num2 = 134;
				}
				IL_9D4:
				num2 = 135;
				((IDisposable)enumerator3).Dispose();
				IL_9E7:
				num2 = 136;
				if (list.Count <= 0)
				{
					goto IL_C9B;
				}
				IL_9FA:
				num2 = 137;
				int num7 = list.Count - 1;
				for (int m = 1; m <= num7; m++)
				{
					IL_A13:
					num2 = 138;
					bool flag = false;
					IL_A1C:
					num2 = 139;
					int n = m - 1;
					while (n >= 0)
					{
						IL_A2D:
						num2 = 140;
						string text4 = list[n];
						IL_A3E:
						num2 = 141;
						string text5 = list[m];
						IL_A4F:
						num2 = 142;
						if (this.O.o00O0___O..ContainsKey(text4) && this.O.o00O0___O..ContainsKey(text5) && this.OoO.o0.[text4] < this.OoO.o0.[text5] && this.O.o00O0___O.[text4] > this.O.o00O0___O.[text5])
						{
							IL_AB1:
							num2 = 143;
							if (Oo00.O____0O._0.(text4, text5, this.oO.o_0o__.[text4].BaseTable.DataSet))
							{
								IL_AD9:
								num2 = 144;
								flag = true;
								break;
							}
							IL_AE7:
							num2 = 146;
							if (this.o_0Oo.0___OO0_.(text4, text5))
							{
								IL_AFC:
								num2 = 147;
								result = true;
								goto IL_CC7;
							}
							break;
						}
						else
						{
							IL_B09:
							num2 = 150;
							if (this.O.o00O0___O..ContainsKey(text4) && !this.O.o00O0___O..ContainsKey(text5) && this.OoO.o0.[text4] < this.OoO.o0.[text5] && this.O.o00O0___O.[text4] > this.OoO.o0.[text5])
							{
								IL_B6B:
								num2 = 151;
								if (Oo00.O____0O._0.(text4, text5, this.oO.o_0o__.[text4].BaseTable.DataSet))
								{
									IL_B93:
									num2 = 152;
									flag = true;
									break;
								}
								IL_BA1:
								num2 = 154;
								if (this.o_0Oo.0___OO0_.(text4, text5))
								{
									IL_BB6:
									num2 = 155;
									result = true;
									goto IL_CC7;
								}
								break;
							}
							else
							{
								IL_BC3:
								num2 = 158;
								if (this.O.o00O0___O..ContainsKey(text4) && this.O.o00O0___O..ContainsKey(text5) && this.OoO.o0.[text4] < this.OoO.o0.[text5] && this.O.o00O0___O.[text4] > this.OoO.o0.[text5])
								{
									IL_C1F:
									num2 = 159;
									MessageBox.Show("细节区之间错位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									IL_C38:
									num2 = 160;
									result = false;
									goto IL_CC7;
								}
								IL_C45:
								num2 = 162;
								n += -1;
							}
						}
					}
					IL_C59:
					num2 = 163;
					if (!flag)
					{
						IL_C63:
						num2 = 164;
						MessageBox.Show("子细节区必须嵌套在父表细节区之内。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						IL_C7C:
						num2 = 165;
						result = false;
						goto IL_CC7;
					}
					IL_C86:
					num2 = 166;
				}
				IL_C9B:
				num2 = 167;
				this.OOO0_O0.O..o__0_.oO.(A_0);
				IL_CAD:
				num2 = 168;
				this.oOo_o0.o_0..o__0_.oO.(A_0);
				IL_CBF:
				num2 = 169;
				result = true;
				goto IL_CC7;
				IL_CCC:
				int num8 = num9 + 1;
				num9 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8);
				IL_F82:
				goto IL_FB6;
				IL_F84:
				num9 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_F94:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num9 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_F84;
			}
			IL_FB6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_FC1:
			if (num9 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 返回或者设置工作簿的默认字体
		/// </summary>
		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060052C9 RID: 21193 RVA: 0x00253F44 File Offset: 0x00252144
		// (set) Token: 0x060052CA RID: 21194 RVA: 0x00253F51 File Offset: 0x00252151
		public System.Drawing.Font DefaultFont
		{
			get
			{
				return this.oO.o_0o__..DefaultFont;
			}
			set
			{
				this.oO.o_0o__..DefaultFont = value;
			}
		}

		/// <summary>
		/// 返回工作表集合
		/// </summary>
		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x060052CB RID: 21195 RVA: 0x00253F5F File Offset: 0x0025215F
		public SheetCollection Sheets
		{
			get
			{
				if (this.a == null)
				{
					this.a = new SheetCollection(this.oO.o_0o__..Sheets);
				}
				return this.a;
			}
		}

		/// <summary>
		/// 加载或保存Excel文件的时候，是否保留单元格公式
		/// </summary>
		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x060052CC RID: 21196 RVA: 0x00253F85 File Offset: 0x00252185
		// (set) Token: 0x060052CD RID: 21197 RVA: 0x00253F92 File Offset: 0x00252192
		public bool KeepFormulas
		{
			get
			{
				return this.oO.o_0o__..KeepFormulas;
			}
			set
			{
				this.oO.o_0o__..KeepFormulas = value;
			}
		}

		/// <summary>
		/// 将工作簿保存为一个文件
		/// </summary>
		/// <param name="FileName"> 文件名称，含路径</param>
		// Token: 0x060052CE RID: 21198 RVA: 0x00253FA0 File Offset: 0x002521A0
		[oO0oooo("1151")]
		public bool Save(string FileName)
		{
			if (Operators.CompareString(c.OOOOO.o.().FileSystem.GetParentPath(FileName), "", true) == 0)
			{
				FileName = OO_00oOO.AttachPath + FileName;
			}
			if (!c.OOOOO.o.().FileSystem.DirectoryExists(c.OOOOO.o.().FileSystem.GetParentPath(FileName)))
			{
				c.OOOOO.o.().FileSystem.CreateDirectory(c.OOOOO.o.().FileSystem.GetParentPath(FileName));
			}
			if (c.OOOOO.o.().FileSystem.FileExists(FileName))
			{
				try
				{
					c.OOOOO.o.().FileSystem.DeleteFile(FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show("文件\"" + FileName + "\"已经被打开，请先关闭之！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return false;
				}
			}
			if (FileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
			{
				this.oO.o_0o__..Save(FileName, FileFormat.OpenXml);
			}
			else
			{
				this.oO.o_0o__..Save(FileName, FileFormat.Biff8);
			}
			return true;
		}

		/// <summary>
		/// 创建并返回一个新的样式
		/// </summary>
		// Token: 0x060052CF RID: 21199 RVA: 0x002540A8 File Offset: 0x002522A8
		[oO0oooo("1146")]
		public Style NewStyle()
		{
			return new Style(new XLStyle(this.oO.o_0o__.));
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x002540BC File Offset: 0x002522BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Assembly <<EMPTY_NAME>>()
		{
			DataRow dataRow = O_O0OO.O0_00o.o0__o..Rows.Find("Foxtable");
			Assembly result;
			if (dataRow == null)
			{
				MessageBox.Show("无效配置文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ProjectData.EndApp();
			}
			else
			{
				result = o0_.Oo_0.OOo0oO0.(O00.oO_.0o_oo_0O_.(dataRow["Config"].ToString(), "datatable", "datarow"), "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", false);
			}
			return result;
		}

		/// <summary>
		/// 保存为PDF格式
		/// </summary>
		/// <param name="fileName">文件名称，含路径</param>
		// Token: 0x060052D1 RID: 21201 RVA: 0x00254144 File Offset: 0x00252344
		public void SaveToPdf(string fileName)
		{
			string text = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + Path.GetExtension(this.o_0Oo.0___OO0_.);
			this.Save(text);
			ApplicationClass applicationClass = new ApplicationClass();
			Workbook workbook = ((_Application)applicationClass).Workbooks.Open(text, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			workbook.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, fileName, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			workbook.Saved = true;
			workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			((_Application)applicationClass).Quit();
		}

		/// <summary>
		/// 添加后台数据表，用于打印后台数据
		/// </summary>
		/// <param name="TableName">临时表的名称，必须和报表模板中的表名保持一致</param>
		/// <param name="ConnectionName">数据源名</param>
		/// <param name="SelectString">Select语句</param>
		// Token: 0x060052D2 RID: 21202 RVA: 0x00254290 File Offset: 0x00252490
		[oO0oooo("3233")]
		public void AddDataTable(string TableName, string ConnectionName, string SelectString)
		{
			this.OOoOOo0.000. = true;
			o0__oo0OOo o0__oo0OOo = new o0__oo0OOo();
			o0__oo0OOo.O_0O00O0_.oOo. = ConnectionName;
			o0__oo0OOo.O_oo._o. = TableName;
			o0__oo0OOo.Oo.__0o0_. = SelectString;
			this.O_0_o.Oo_oo0_O..Add(o0__oo0OOo);
		}

		/// <summary>
		/// 指定一个临时DataTable作为报表的数据来源
		/// </summary>
		/// <param name="TableName">临时表的名称，必须和报表模板中的表名保持一致</param>
		/// <param name="DataTable">一个临时DataTable，此DataTable不能是DataTables中的一员</param>
		// Token: 0x060052D3 RID: 21203 RVA: 0x002542CC File Offset: 0x002524CC
		[oO0oooo("3233")]
		public void AddDataTable(string TableName, Foxtable.DataTable DataTable)
		{
			if (DataTable.BaseTable.DataSet == null)
			{
				this.OOoOOo0.000. = true;
				o0__oo0OOo o0__oo0OOo = new o0__oo0OOo();
				o0__oo0OOo.O_oo._o. = TableName;
				o0__oo0OOo.oo0_O0_000o.0o. = DataTable;
				this.O_0_o.Oo_oo0_O..Add(o0__oo0OOo);
				return;
			}
			OO_00oOO.PopMessage("添加表失败，此表已属于某DataSet", "提示", PopiconEnum.Infomation, -1);
		}

		/// <summary>
		/// 在通过AddDataTable增加的临时表之间创建关联
		/// </summary>
		/// <param name="ParentTable">父表</param>
		/// <param name="ParentColumn">父表关联列</param>
		/// <param name="ChildTable">子表</param>
		/// <param name="ChildColumn">子表关联列</param>
		// Token: 0x060052D4 RID: 21204 RVA: 0x0025431F File Offset: 0x0025251F
		[oO0oooo("3233")]
		public void AddRelation(string ParentTable, string ParentColumn, string ChildTable, string ChildColumn)
		{
			this.AddRelation(ParentTable, new string[]
			{
				ParentColumn
			}, ChildTable, new string[]
			{
				ChildColumn
			});
		}

		/// <summary>
		/// 在通过AddDataTable增加的临时表之间创建关联
		/// </summary>
		/// <param name="ParentTable">父表</param>
		/// <param name="ParentColumns">一个字符数组，指定多个父表关联列</param>
		/// <param name="ChildTable">子表</param>
		/// <param name="ChildColumns">一个字符数组，指定多个子表关联列</param>
		// Token: 0x060052D5 RID: 21205 RVA: 0x00254340 File Offset: 0x00252540
		[oO0oooo("3233")]
		public void AddRelation(string ParentTable, string[] ParentColumns, string ChildTable, string[] ChildColumns)
		{
			this.OOoOOo0.000. = true;
			O_0OO o_0OO = new O_0OO();
			o_0OO.O_oo._o. = ParentTable;
			o_0OO.O_oo._o. = ParentColumns;
			o_0OO.O000000o0.oO0o. = ChildTable;
			o_0OO.O000000o0.oO0o. = ChildColumns;
			this.O_0_o.Oo_oo0_O..Add(o_0OO);
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x00254384 File Offset: 0x00252584
		private bool <<EMPTY_NAME>>(string A_0, string A_1)
		{
			try
			{
				foreach (O_0OO o_0OO in this.O_0_o.Oo_oo0_O.)
				{
					if (Operators.CompareString(o_0OO.O_oo._o., A_0, true) == 0 && Operators.CompareString(o_0OO.O000000o0.oO0o., A_1, true) == 0)
					{
						return true;
					}
				}
			}
			finally
			{
				List<O_0OO>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return false;
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x002543F8 File Offset: 0x002525F8
		private void <<EMPTY_NAME>>()
		{
			if (this.OOoOOo0.000.)
			{
				this.OOoOOo0.000. = false;
				try
				{
					foreach (o0__oo0OOo o0__oo0OOo in this.O_0_o.Oo_oo0_O.)
					{
						if (this.oO.o_0o__. == null)
						{
							this.oO.o_0o__. = new DataSet();
							this.oO.o_0o__..EnforceConstraints = false;
						}
						if (Operators.CompareString(o0__oo0OOo.Oo.__0o0_., "", true) > 0)
						{
							Foxtable.DataTable dataTable = new SQLCommand(o0__oo0OOo.Oo.__0o0_., o0__oo0OOo.O_0O00O0_.oOo.).ExecuteReader(false);
							dataTable.BaseTable.TableName = o0__oo0OOo.O_oo._o.;
							this.oO.o_0o__..Tables.Add(dataTable.BaseTable);
							this.oO.o_0o__..add(o0__oo0OOo.O_oo._o., dataTable);
						}
						else if (o0__oo0OOo.oo0_O0_000o.0o. != null)
						{
							this.oO.o_0o__..Tables.Add(o0__oo0OOo.oo0_O0_000o.0o..BaseTable);
							o0__oo0OOo.oo0_O0_000o.0o..BaseTable.TableName = o0__oo0OOo.O_oo._o.;
							this.oO.o_0o__..add(o0__oo0OOo.O_oo._o., o0__oo0OOo.oo0_O0_000o.0o.);
						}
					}
				}
				finally
				{
					List<o0__oo0OOo>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.O_0_o.Oo_oo0_O..Count > 0)
				{
					try
					{
						foreach (O_0OO o_0OO in this.O_0_o.Oo_oo0_O.)
						{
							if (!this.oO.o_0o__..Tables.Contains(o_0OO.O_oo._o..ToLower()) || !this.oO.o_0o__..Tables.Contains(o_0OO.O000000o0.oO0o.) || o_0OO.O_oo._o..Length != o_0OO.O000000o0.oO0o..Length || o_0OO.O_oo._o..Length == 0)
							{
								OO_00oOO.PopMessage("创建关联失败!", "提示", PopiconEnum.Infomation, -1);
								this.oO.o_0o__..Reset();
								return;
							}
							List<DataColumn> list = new List<DataColumn>();
							List<DataColumn> list2 = new List<DataColumn>();
							int num = o_0OO.O_oo._o..Length - 1;
							for (int i = 0; i <= num; i++)
							{
								if (this.oO.o_0o__..Tables[o_0OO.O_oo._o.].Columns[o_0OO.O_oo._o.[i]].DataType != this.oO.o_0o__..Tables[o_0OO.O000000o0.oO0o.].Columns[o_0OO.O000000o0.oO0o.[i]].DataType)
								{
									OO_00oOO.PopMessage("关联列数据类型不匹配!", "提示", PopiconEnum.Infomation, -1);
									this.oO.o_0o__..Reset();
									return;
								}
								list.Add(this.oO.o_0o__..Tables[o_0OO.O_oo._o.].Columns[o_0OO.O_oo._o.[i]]);
								list2.Add(this.oO.o_0o__..Tables[o_0OO.O000000o0.oO0o.].Columns[o_0OO.O000000o0.oO0o.[i]]);
							}
							DataRelation dataRelation = new DataRelation(o_0OO.O000000o0.oO0o., list.ToArray(), list2.ToArray());
							dataRelation.RelationName = OoOo0O.OO_o.0o_O.(10);
							this.oO.o_0o__..Relations.Add(dataRelation);
						}
					}
					finally
					{
						List<O_0OO>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				try
				{
					foreach (Foxtable.DataTable dataTable2 in this.oO.o_0o__.._List.Values)
					{
						if (OO_00oOO.DataTables.Contains(dataTable2.BaseTable.TableName))
						{
							Foxtable.DataTable dataTable3 = OO_00oOO.DataTables[dataTable2.BaseTable.TableName];
							try
							{
								foreach (DataCol dataCol in dataTable2.DataCols)
								{
									if (dataTable3.DataCols.Contains(dataCol.Name))
									{
										dataCol.ExtendType = dataTable3.DataCols[dataCol.Name].ExtendType;
										dataCol.Remote = dataTable3.DataCols[dataCol.Name].Remote;
										if (dataCol.Remote & dataTable3.DataCols[dataCol.Name].FTPClient != null)
										{
											dataCol.FTPClient = dataTable3.DataCols[dataCol.Name].FTPClient.O_O_0_O0.oOO.();
										}
									}
								}
							}
							finally
							{
								IEnumerator<DataCol> enumerator4;
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
					Dictionary<string, Foxtable.DataTable>.ValueCollection.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060052D8 RID: 21208 RVA: 0x002548E4 File Offset: 0x00252AE4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public tempDataTableCollection DataTables
		{
			get
			{
				if (this.OOoOOo0.000.)
				{
					this.ooo._O.();
				}
				return this.oO.o_0o__.;
			}
		}

		/// <summary>
		/// 保存工作簿为HTML文件
		/// </summary>
		/// <param name="fileName">文件名，含路径</param>
		// Token: 0x060052D9 RID: 21209 RVA: 0x002548FC File Offset: 0x00252AFC
		public void SaveToHTML(string fileName)
		{
			if (OO_00oOO.FileSys.FileExists(fileName))
			{
				OO_00oOO.FileSys.DeleteFile(fileName);
			}
			string text = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + Path.GetExtension(this.o_0Oo.0___OO0_.);
			this.Save(text);
			ApplicationClass applicationClass = new ApplicationClass();
			Workbook workbook = ((_Application)applicationClass).Workbooks.Open(text, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			workbook.SaveAs(fileName, XlFileFormat.xlHtml, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), false, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			workbook.Saved = true;
			workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			((_Application)applicationClass).Quit();
		}

		/// <summary>
		/// 将工作簿保存为MHT文件
		/// </summary>
		/// <param name="fileName">文件名，含路径</param>
		// Token: 0x060052DA RID: 21210 RVA: 0x00254A78 File Offset: 0x00252C78
		public void SaveToMHT(string fileName)
		{
			if (OO_00oOO.FileSys.FileExists(fileName))
			{
				OO_00oOO.FileSys.DeleteFile(fileName);
			}
			string text = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + Path.GetExtension(this.o_0Oo.0___OO0_.);
			this.Save(text);
			ApplicationClass applicationClass = new ApplicationClass();
			Workbook workbook = ((_Application)applicationClass).Workbooks.Open(text, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			workbook.SaveAs(fileName, XlFileFormat.xlWebArchive, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), false, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			workbook.Saved = true;
			workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
			((_Application)applicationClass).Quit();
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00254BF4 File Offset: 0x00252DF4
		private System.Data.DataTable <<EMPTY_NAME>>(System.Data.DataTable A_0)
		{
			System.Data.DataTable dataTable = new System.Data.DataTable();
			try
			{
				foreach (object obj in A_0.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					DataColumn dataColumn2 = new DataColumn(dataColumn.ColumnName, dataColumn.DataType);
					dataColumn2.MaxLength = dataColumn.MaxLength;
					dataTable.Columns.Add(dataColumn2);
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
			return dataTable;
		}

		// Token: 0x04002247 RID: 8775
		internal C1XLBook <<EMPTY_NAME>>;

		// Token: 0x04002248 RID: 8776
		private int <<EMPTY_NAME>>;

		// Token: 0x04002249 RID: 8777
		private Dictionary<string, object> <<EMPTY_NAME>>;

		// Token: 0x0400224A RID: 8778
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400224B RID: 8779
		private string <<EMPTY_NAME>>;

		// Token: 0x0400224C RID: 8780
		private string <<EMPTY_NAME>>;

		// Token: 0x0400224D RID: 8781
		private Foxtable.DataTable <<EMPTY_NAME>>;

		// Token: 0x0400224E RID: 8782
		private int <<EMPTY_NAME>>;

		// Token: 0x0400224F RID: 8783
		private int <<EMPTY_NAME>>;

		// Token: 0x04002250 RID: 8784
		private string <<EMPTY_NAME>>;

		// Token: 0x04002251 RID: 8785
		private List<DataRow> <<EMPTY_NAME>>;

		// Token: 0x04002252 RID: 8786
		private Dictionary<string, List<DataRow>> <<EMPTY_NAME>>;

		// Token: 0x04002253 RID: 8787
		private Book.O0oOOoo_ooo_O <<EMPTY_NAME>>;

		// Token: 0x04002254 RID: 8788
		private Book.O0oOOoo_ooo_O <<EMPTY_NAME>>;

		// Token: 0x04002255 RID: 8789
		private Dictionary<string, int> <<EMPTY_NAME>>;

		// Token: 0x04002256 RID: 8790
		private Dictionary<string, int> <<EMPTY_NAME>>;

		// Token: 0x04002257 RID: 8791
		private Dictionary<string, int> <<EMPTY_NAME>>;

		// Token: 0x04002258 RID: 8792
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04002259 RID: 8793
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x0400225A RID: 8794
		private Dictionary<string, int> <<EMPTY_NAME>>;

		// Token: 0x0400225B RID: 8795
		private Dictionary<string, int> <<EMPTY_NAME>>;

		// Token: 0x0400225C RID: 8796
		private List<int> <<EMPTY_NAME>>;

		// Token: 0x0400225D RID: 8797
		private RichTextBox <<EMPTY_NAME>>;

		// Token: 0x0400225E RID: 8798
		internal DataSet <<EMPTY_NAME>>;

		// Token: 0x0400225F RID: 8799
		private tempDataTableCollection <<EMPTY_NAME>>;

		// Token: 0x04002260 RID: 8800
		private List<O_0OO> <<EMPTY_NAME>>;

		// Token: 0x04002261 RID: 8801
		private List<o0__oo0OOo> <<EMPTY_NAME>>;

		// Token: 0x04002262 RID: 8802
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002263 RID: 8803
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002264 RID: 8804
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002265 RID: 8805
		private static Assembly <<EMPTY_NAME>>;

		// Token: 0x04002266 RID: 8806
		private static bool <<EMPTY_NAME>>;

		// Token: 0x04002267 RID: 8807
		private SheetCollection a;

		// Token: 0x020004ED RID: 1261
		internal class Oo_0o
		{
			// Token: 0x060052DC RID: 21212 RVA: 0x00254C7C File Offset: 0x00252E7C
			public Oo_0o()
			{
				this.oO.o_0o__. = new List<DataRow>();
			}

			// Token: 0x04002268 RID: 8808
			internal string <<EMPTY_NAME>>;

			// Token: 0x04002269 RID: 8809
			internal string <<EMPTY_NAME>>;

			// Token: 0x0400226A RID: 8810
			internal int <<EMPTY_NAME>>;

			// Token: 0x0400226B RID: 8811
			internal int <<EMPTY_NAME>>;

			// Token: 0x0400226C RID: 8812
			internal List<DataRow> <<EMPTY_NAME>>;

			// Token: 0x0400226D RID: 8813
			internal bool <<EMPTY_NAME>>;

			// Token: 0x0400226E RID: 8814
			internal bool <<EMPTY_NAME>>;
		}

		// Token: 0x020004EE RID: 1262
		internal class O0oOOoo_ooo_O : List<Book.Oo_0o>
		{
			// Token: 0x060052DD RID: 21213 RVA: 0x00254C8F File Offset: 0x00252E8F
			public O0oOOoo_ooo_O()
			{
				this.o__0_.oO. = new List<Book.Oo_0o>();
				this.o0.o0O__0oo. = new List<Book.Oo_0o>();
				this.O._0_o0O. = new List<Book.Oo_0o>();
				this.o__0_.oO. = new tempDataTableCollection();
			}

			// Token: 0x060052DE RID: 21214 RVA: 0x00254CC4 File Offset: 0x00252EC4
			internal Book.Oo_0o <<EMPTY_NAME>>(string A_0, string A_1)
			{
				try
				{
					foreach (Book.Oo_0o oo_0o in this)
					{
						if (Operators.CompareString(oo_0o.O_0o_.O_0., A_0, true) == 0 && Operators.CompareString(oo_0o.OoO.o0., A_1, true) == 0)
						{
							return oo_0o;
						}
					}
				}
				finally
				{
					List<Book.Oo_0o>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return null;
			}

			// Token: 0x060052DF RID: 21215 RVA: 0x00254D30 File Offset: 0x00252F30
			internal Book.Oo_0o <<EMPTY_NAME>>(string A_0, string A_1)
			{
				Book.Oo_0o oo_0o = new Book.Oo_0o();
				oo_0o.O_0o_.O_0. = A_0;
				oo_0o.OoO.o0. = A_1;
				base.Add(oo_0o);
				return oo_0o;
			}

			// Token: 0x060052E0 RID: 21216 RVA: 0x00254D5C File Offset: 0x00252F5C
			internal void <<EMPTY_NAME>>(XLSheet A_0)
			{
				try
				{
					foreach (Book.Oo_0o oo_0o in this)
					{
						if (oo_0o.oooo.0O__oo. == 0)
						{
							oo_0o.oooo.0O__oo. = oo_0o.O_0o_.O_0.;
						}
						int o_0o_.O_0. = oo_0o.O_0o_.O_0.;
						int oooo.0O__oo. = oo_0o.oooo.0O__oo.;
						for (int i = o_0o_.O_0.; i <= oooo.0O__oo.; i++)
						{
							A_0[i, 0].Value = "{Skip}";
						}
					}
				}
				finally
				{
					List<Book.Oo_0o>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}

			// Token: 0x060052E1 RID: 21217 RVA: 0x00254DE4 File Offset: 0x00252FE4
			internal void <<EMPTY_NAME>>(int A_0, int A_1, List<DataRow> A_2)
			{
				this.o__0_.oO..Clear();
				DataRow dataRow = A_2[A_0];
				try
				{
					foreach (Book.Oo_0o oo_0o in this)
					{
						if (Operators.CompareString(oo_0o.O_0o_.O_0., dataRow.Table.TableName, true) == 0)
						{
							if (oo_0o.oO.o_0o__..Count == 0)
							{
								this.O_0o_.O_0.(oo_0o, A_0, A_1, A_2);
								this.o__0_.oO..Add(oo_0o);
							}
							else if (Operators.CompareString(oo_0o.oO.o_0o__.[oo_0o.oO.o_0o__..Count - 1][oo_0o.OoO.o0.].ToString(), dataRow[oo_0o.OoO.o0.].ToString(), true) != 0)
							{
								oo_0o.oO.o_0o__..Clear();
								this.O_0o_.O_0.(oo_0o, A_0, A_1, A_2);
								this.o__0_.oO..Add(oo_0o);
							}
							else
							{
								this.O_0o_.O_0.(oo_0o, A_0, A_1, A_2);
							}
						}
					}
				}
				finally
				{
					List<Book.Oo_0o>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}

			// Token: 0x060052E2 RID: 21218 RVA: 0x00254EF4 File Offset: 0x002530F4
			private void <<EMPTY_NAME>>(Book.Oo_0o A_0, int A_1, int A_2, List<DataRow> A_3)
			{
				A_0.oO.o_0o__..Add(A_3[A_1]);
				int num = A_1 + 1;
				int num2 = Math.Min(A_1 + A_2 - 1, A_3.Count - 1);
				int num3 = num;
				while (num3 <= num2 && Operators.CompareString(A_3[A_1][A_0.OoO.o0.].ToString(), A_3[num3][A_0.OoO.o0.].ToString(), true) == 0)
				{
					A_0.oO.o_0o__..Add(A_3[num3]);
					num3++;
				}
			}

			// Token: 0x060052E3 RID: 21219 RVA: 0x00254F84 File Offset: 0x00253184
			internal bool <<EMPTY_NAME>>(DataRow A_0, DataRow A_1)
			{
				try
				{
					foreach (Book.Oo_0o oo_0o in this)
					{
						if (Operators.CompareString(oo_0o.O_0o_.O_0., A_0.Table.TableName, true) == 0 && Operators.CompareString(A_0[oo_0o.OoO.o0.].ToString(), A_1[oo_0o.OoO.o0.].ToString(), true) != 0)
						{
							return false;
						}
					}
				}
				finally
				{
					List<Book.Oo_0o>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return true;
			}

			// Token: 0x060052E4 RID: 21220 RVA: 0x00255018 File Offset: 0x00253218
			internal void <<EMPTY_NAME>>(int A_0, int A_1, List<DataRow> A_2)
			{
				this.O._0_o0O..Clear();
				if (A_0 != A_2.Count - 1)
				{
					try
					{
						foreach (Book.Oo_0o oo_0o in this)
						{
							if (oo_0o.oooo.0O__oo. && (this.o__0_.oO..Contains(oo_0o.O_0o_.O_0.) || (OO_00oOO.Tables.get_Contains(oo_0o.O_0o_.O_0.) && Operators.CompareString(OO_00oOO.Tables[oo_0o.O_0o_.O_0.].DataTable.BaseTable.TableName, A_2[A_0].Table.TableName, true) == 0) || Operators.CompareString(oo_0o.O_0o_.O_0., A_2[A_0].Table.TableName, true) == 0))
							{
								int num = A_0;
								if (A_1 > 1)
								{
									int num2 = A_0 + 1;
									int num3 = Math.Min(A_0 + A_1 - 1, A_2.Count - 1);
									int num4 = num3;
									for (int i = num2; i <= num4; i++)
									{
										if (this.o__0_.oO.(A_2[i - 1], A_2[i]))
										{
											oo_0o.oO.o_0o__..Add(A_2[i - 1]);
											num = i;
										}
									}
								}
								if (num == A_2.Count - 1)
								{
									break;
								}
								DataRow dataRow = A_2[num];
								if (Operators.CompareString(A_2[num + 1][oo_0o.OoO.o0.].ToString(), dataRow[oo_0o.OoO.o0.].ToString(), true) == 0)
								{
									this.O._0_o0O..Add(oo_0o);
								}
							}
						}
					}
					finally
					{
						List<Book.Oo_0o>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}

			// Token: 0x060052E5 RID: 21221 RVA: 0x002551CC File Offset: 0x002533CC
			internal void <<EMPTY_NAME>>(int A_0, int A_1, List<DataRow> A_2)
			{
				this.o0.o0O__0oo..Clear();
				this.o__0_.oO. = false;
				if (A_0 == A_2.Count - 1)
				{
					try
					{
						foreach (Book.Oo_0o oo_0o in this)
						{
							if ((OO_00oOO.Tables.get_Contains(oo_0o.O_0o_.O_0.) && Operators.CompareString(OO_00oOO.Tables[oo_0o.O_0o_.O_0.].DataTable.BaseTable.TableName, A_2[A_0].Table.TableName, true) == 0) || Operators.CompareString(oo_0o.O_0o_.O_0., A_2[A_0].Table.TableName, true) == 0)
							{
								oo_0o.oO.o_0o__..Add(A_2[A_0]);
								if (oo_0o.oO.o_0o__.)
								{
									this.o__0_.oO. = true;
								}
								this.o0.o0O__0oo..Add(oo_0o);
							}
						}
						return;
					}
					finally
					{
						List<Book.Oo_0o>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				int num = base.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					Book.Oo_0o oo_0o2 = base[i];
					if ((OO_00oOO.Tables.get_Contains(oo_0o2.O_0o_.O_0.) && Operators.CompareString(OO_00oOO.Tables[oo_0o2.O_0o_.O_0.].DataTable.BaseTable.TableName, A_2[A_0].Table.TableName, true) == 0) || Operators.CompareString(oo_0o2.O_0o_.O_0., A_2[A_0].Table.TableName, true) == 0)
					{
						int num2 = A_0;
						oo_0o2.oO.o_0o__..Add(A_2[num2]);
						if (A_1 > 1)
						{
							int num3 = A_0 + 1;
							int num4 = Math.Min(A_0 + A_1 - 1, A_2.Count - 1);
							int num5 = num4;
							for (int j = num3; j <= num5; j++)
							{
								if (this.o__0_.oO.(A_2[j], A_2[A_0]))
								{
									oo_0o2.oO.o_0o__..Add(A_2[j]);
									num2 = j;
								}
							}
						}
						if (num2 == A_2.Count - 1)
						{
							if (oo_0o2.oO.o_0o__.)
							{
								this.o__0_.oO. = true;
							}
							this.o0.o0O__0oo..Add(oo_0o2);
						}
						else
						{
							DataRow dataRow = A_2[num2];
							DataRow dataRow2 = A_2[num2 + 1];
							int num6 = i;
							int num7 = base.Count - 1;
							int k = num6;
							while (k <= num7)
							{
								if (Operators.CompareString(dataRow2[base[k].OoO.o0.].ToString(), dataRow[base[k].OoO.o0.].ToString(), true) != 0)
								{
									this.o0.o0O__0oo..Add(oo_0o2);
									if (oo_0o2.oO.o_0o__.)
									{
										this.o__0_.oO. = true;
										break;
									}
									break;
								}
								else
								{
									k++;
								}
							}
						}
					}
				}
			}

			// Token: 0x060052E6 RID: 21222 RVA: 0x00255494 File Offset: 0x00253694
			internal void <<EMPTY_NAME>>()
			{
				try
				{
					foreach (Book.Oo_0o oo_0o in this.o0.o0O__0oo.)
					{
						oo_0o.oO.o_0o__..Clear();
					}
				}
				finally
				{
					List<Book.Oo_0o>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.o0.o0O__0oo..Clear();
			}

			// Token: 0x0400226F RID: 8815
			internal List<Book.Oo_0o> <<EMPTY_NAME>>;

			// Token: 0x04002270 RID: 8816
			internal List<Book.Oo_0o> <<EMPTY_NAME>>;

			// Token: 0x04002271 RID: 8817
			internal List<Book.Oo_0o> <<EMPTY_NAME>>;

			// Token: 0x04002272 RID: 8818
			internal bool <<EMPTY_NAME>>;

			// Token: 0x04002273 RID: 8819
			internal tempDataTableCollection <<EMPTY_NAME>>;
		}
	}
}
