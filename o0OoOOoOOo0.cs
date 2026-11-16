using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ADODB;
using ADOX;
using Foxtable.My;
using Foxtable.Word;
using Foxtable.XLS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000456 RID: 1110
	[StandardModule]
	internal sealed class o0OoOOoOOo0
	{
		// Token: 0x06004A96 RID: 19094 RVA: 0x00214158 File Offset: 0x00212358
		static o0OoOOoOOo0()
		{
			// Note: this type is marked as 'beforefieldinit'.
			int a_ = 1;
			o0OoOOoOOo0.o0.ooO_o__O0OO. = "";
			o0OoOOoOOo0.o0_.O_. = O00OOOo_O0_O.b("ꗣ雥飧蛩藫跭釯蛱鷳駵雷", a_);
			o0OoOOoOOo0.o.00O_0o_. = "";
			o0OoOOoOOo0.Oo0.OooO00. = O00OOOo_O0_O.b("뛣ꫥ郧鋩藫ꛭ꟯ꗱ돳컵듷짹꯻製䫿嘁〃䐅稇䜉夋䌍匏☑搓刕戗怙䘛弝猟笡簣圥儧䠩瘫䈭䈯䄱ളᴵ伷ܹ", a_);
			o0OoOOoOOo0.O0.00o00__. = "";
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x002141B4 File Offset: 0x002123B4
		internal static string <<EMPTY_NAME>>()
		{
			int a_ = 8;
			if (Operators.CompareString(o0OoOOoOOo0.o.00O_0o_., "", true) == 0)
			{
				o0OoOOoOOo0.o.00O_0o_. = O00OOOo_O0_O.b("軪菬\udeee闰黲雴꛶꯸돺鯼럾最儂弄挆娈稊渌娎吐愒吔⨖␘", a_);
			}
			return o0OoOOoOOo0.o.00O_0o_.;
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x002141F4 File Offset: 0x002123F4
		private static string <<EMPTY_NAME>>()
		{
			int a_ = 1;
			return O00OOOo_O0_O.b("蛣ꏥꏧ뫩꣫跭臯뗱볳鋵闷ꏹ뷻軽盿䐁㰃戅儇戉㰋笍ℏ唑尓縕琗簙㌛弝ᐟ唡ᘣ椥䄧䜩渫簭夯嘱朳稵䴷ਹ䬻ऽిⵁ煃㽅၇ᵉ祋ཌྷ浏潑", a_);
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x00214218 File Offset: 0x00212418
		private static void <<EMPTY_NAME>>(OleDbConnection A_0, DataSet A_1, DataTableCollection A_2, UserInfo A_3, Assembly A_4, DataSet A_5)
		{
			int a_ = 16;
			A_0.Open();
			DataRow[] array = A_0.GetSchema(O00OOOo_O0_O.b("ꟲ铴闶闸黺軼", a_)).Select(O00OOOo_O0_O.b("ꣲꇴ뛶미럺룼ꃾ唀娂唄䈆合㘊⨌嬎倐儒夔刖㸘㬚", a_));
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text = Conversions.ToString(array[i][O00OOOo_O0_O.b("ꟲ듴뗶뗸뻺ꋼ뇾䀀丂䀄", a_)]);
					if (!o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text))
					{
						o0OoOOoOOo0.OO0._Oo0o.(A_0, A_2, A_1, text, false, A_3, A_4, A_5, true);
					}
				}
				A_0.Close();
			}
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x002142AC File Offset: 0x002124AC
		internal static void <<EMPTY_NAME>>(OleDbConnection A_0, DataTableCollection A_1, DataSet A_2, string A_3, bool A_4, UserInfo A_5, Assembly A_6, DataSet A_7, bool A_8 = true)
		{
			int a_ = 1;
			BeforeLoadInnerTableEventArgs beforeLoadInnerTableEventArgs = new BeforeLoadInnerTableEventArgs(A_3, O00OOOo_O0_O.b("쓣쳥죧", a_), "", A_5);
			O_O0OO.OoO_o.oO0o0O.(A_6, O00OOOo_O0_O.b("ꛣ菥軧藩黫语볯鷱闳鋵뇷铹鋻鯽狿嘁攃搅搇漉", a_), new object[]
			{
				beforeLoadInnerTableEventArgs
			}, true, O00OOOo_O0_O.b("鵻࢓", a_), true);
			if (!beforeLoadInnerTableEventArgs.Cancel || !A_8)
			{
				string text;
				if (Operators.CompareString(beforeLoadInnerTableEventArgs.SelectString, "", true) > 0)
				{
					text = beforeLoadInnerTableEventArgs.SelectString;
				}
				else
				{
					if (Operators.CompareString(beforeLoadInnerTableEventArgs.Fields.Trim(), O00OOOo_O0_O.b("쓣쳥죧", a_), true) != 0)
					{
						beforeLoadInnerTableEventArgs.Fields = ShareLibriay.ReplaceIgnoreCase(beforeLoadInnerTableEventArgs.Fields, O00OOOo_O0_O.b("믣꿥賧迩苫髭駯铱跳", a_), "");
						beforeLoadInnerTableEventArgs.Fields = beforeLoadInnerTableEventArgs.Fields.Replace(O00OOOo_O0_O.b("뿣믥", a_), "");
						beforeLoadInnerTableEventArgs.Fields = beforeLoadInnerTableEventArgs.Fields.Replace(O00OOOo_O0_O.b("죣쫥", a_), O00OOOo_O0_O.b("죣", a_));
						beforeLoadInnerTableEventArgs.Fields = beforeLoadInnerTableEventArgs.Fields.Replace(O00OOOo_O0_O.b("죣쫥", a_), O00OOOo_O0_O.b("죣", a_));
						beforeLoadInnerTableEventArgs.Fields = beforeLoadInnerTableEventArgs.Fields.Trim(new char[]
						{
							','
						});
						beforeLoadInnerTableEventArgs.Fields = O00OOOo_O0_O.b("뿣맥ꇧ軩觫胭蓯鯱鋳迵ꗷ훹", a_) + beforeLoadInnerTableEventArgs.Fields;
					}
					text = string.Concat(new string[]
					{
						O00OOOo_O0_O.b("럣菥蓧迩迫髭탯", a_),
						beforeLoadInnerTableEventArgs.Fields,
						O00OOOo_O0_O.b("쓣ꃥ髧藩臫컭꯯", a_),
						A_3,
						O00OOOo_O0_O.b("맣", a_)
					});
					if (Operators.CompareString(beforeLoadInnerTableEventArgs.Filter, "", true) > 0)
					{
						text = text + O00OOOo_O0_O.b("쓣뇥胧迩黫语탯", a_) + beforeLoadInnerTableEventArgs.Filter;
					}
				}
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text, A_0);
				DataTable dataTable = new DataTable();
				if (A_3.StartsWith(O00OOOo_O0_O.b("髣닥ꗧ뫩꿫ꋭꃯ", a_)))
				{
					dataTable.TableName = A_3.Substring(7);
				}
				else
				{
					dataTable.TableName = A_3;
				}
				if (!dataTable.TableName.StartsWith(O00OOOo_O0_O.b("韣鿥鯧뗩", a_), StringComparison.CurrentCultureIgnoreCase) && !dataTable.TableName.StartsWith(O00OOOo_O0_O.b("믣", a_)) && Operators.CompareString(o0OoOOoOOo0.o0.ooO_o__O0OO., "", true) > 0)
				{
					Main.ProcessForm.o0__.Oo0O_O0O_.(o0OoOOoOOo0.o0.ooO_o__O0OO..Replace(O00OOOo_O0_O.b("鿣훥闧", a_), dataTable.TableName));
					Application.DoEvents();
				}
				oleDbDataAdapter.FillLoadOption = LoadOption.PreserveChanges;
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				oleDbDataAdapter.Fill(dataTable);
				dataTable.Columns[O00OOOo_O0_O.b("믣꿥賧迩苫髭駯铱跳", a_)].AutoIncrement = true;
				dataTable.Columns[O00OOOo_O0_O.b("믣꿥賧迩苫髭駯铱跳", a_)].AutoIncrementStep = 1L;
				dataTable.Columns[O00OOOo_O0_O.b("믣꿥賧迩苫髭駯铱跳", a_)].AutoIncrementSeed = 1L;
				if (dataTable.Rows.Count > 0 && dataTable.Rows.Count > 0)
				{
					dataTable.Columns[O00OOOo_O0_O.b("믣꿥賧迩苫髭駯铱跳", a_)].AutoIncrementSeed = (long)(Conversions.ToInteger(dataTable.Compute(O00OOOo_O0_O.b("ꧣ蟥郧싩럫뇭맯雱釳飵賷鏹髻蟽巿⬁", a_), "")) + 1);
				}
				A_2.Tables.Add(dataTable);
				o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
				A_1.OO0o00.0O_0o.(new DataTable(dataTable, oleDbDataAdapter, A_0, A_3, A_7));
				if (A_4)
				{
					new O_0(O_O0OO.o__.O.(), dataTable);
				}
			}
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x00214670 File Offset: 0x00212870
		internal static bool <<EMPTY_NAME>>(string A_0)
		{
			int a_ = 17;
			bool flag;
			do
			{
				flag = false;
				try
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
						if (form is ef)
						{
							flag = true;
							form.Close();
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
			}
			while (flag);
			Application.DoEvents();
			OleDbConnection oleDbConnection = new OleDbConnection();
			DataSet dataSet = new DataSet();
			DataSet dataSet2 = new DataSet();
			Dictionary<string, O_0> a_2 = new Dictionary<string, O_0>();
			DataTableCollection dataTableCollection = new DataTableCollection();
			Dictionary<string, OleDbConnection> dictionary = new Dictionary<string, OleDbConnection>(StringComparer.OrdinalIgnoreCase);
			Dictionary<string, O0O> dictionary2 = new Dictionary<string, O0O>(StringComparer.OrdinalIgnoreCase);
			Dictionary<string, O_0oOo_OO> dictionary3 = new Dictionary<string, O_0oOo_OO>(StringComparer.OrdinalIgnoreCase);
			ProjectProperty projectProperty = new ProjectProperty();
			Assembly assembly = null;
			UserInfo userInfo = null;
			bool flag2 = false;
			bool flag3 = false;
			OO_00oOO.FileSys.GetParentPath(A_0);
			Main.o_0Oo0__.oooO0.(OO_00oOO.FileSys.GetParentPath(A_0) + O00OOOo_O0_O.b("ꣳ듵釷铹ꃻ", a_));
			bool result;
			if (!A_0.EndsWith(O00OOOo_O0_O.b("\udaf3냵韷苹飻鳽", a_), StringComparison.CurrentCultureIgnoreCase))
			{
				MessageBox.Show(O00OOOo_O0_O.b("尿୵ꮕ益ꉬﺢ톬䩳㡫ग़豱玑襨Ꮾ", a_), O00OOOo_O0_O.b("⒐첌", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				try
				{
					oleDbConnection.ConnectionString = Oo00.o_._0OOo.(A_0);
					oleDbConnection.Open();
					double num;
					double num2;
					try
					{
						foreach (string text in o_O_o_oOoo__.Oo_0.OOo0oO0.)
						{
							if (Operators.CompareString(text, ooO0__OO.O00.O__o.(), true) != 0)
							{
								OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(O00OOOo_O0_O.b("ꟳ鏵铷鿹鿻諽⃿⠁␃䀅稇攉愋⸍䬏", a_) + text + O00OOOo_O0_O.b("꧳", a_), oleDbConnection);
								DataTable dataTable = new DataTable();
								dataTable.TableName = text;
								dataTable.ExtendedProperties.Add(O00OOOo_O0_O.b("냳韵賷鯹뷻髽懿爁瀃挅稇", a_), oleDbDataAdapter);
								dataSet2.Tables.Add(dataTable);
								oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
								oleDbDataAdapter.Fill(dataTable);
								o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
								if (Operators.CompareString(text, ooO0__OO.o.00_0o0__OoO.(), true) == 0)
								{
									dataTable.Columns[O00OOOo_O0_O.b("鷳鋵", a_)].AutoIncrement = true;
									dataTable.Columns[O00OOOo_O0_O.b("鷳鋵", a_)].AutoIncrementStep = 1L;
									if (dataTable.Rows.Count > 0)
									{
										dataTable.Columns[O00OOOo_O0_O.b("鷳鋵", a_)].AutoIncrementSeed = Conversions.ToLong(dataTable.Compute(O00OOOo_O0_O.b("맳韵胷틹闻髽⧿", a_), "")) + 1L;
									}
								}
								if (Operators.CompareString(text, ooO0__OO.OOo0._00O_o00.(), true) == 0)
								{
									if (Operators.CompareString(O_O0OO.o0OoO00OO.00O., A_0, true) == 0 || o0OoOOoOOo0.O_00o0.O0OO_0.)
									{
										o0OoOOoOOo0.O0OoO_0o.O.(dataSet2);
										o0OoOOoOOo0.O_00o0.O0OO_0. = false;
									}
									DataRow dataRow;
									if (Control.ModifierKeys != System.Windows.Forms.Keys.Control)
									{
										dataRow = dataTable.Rows.Find(new object[]
										{
											O00OOOo_O0_O.b("ꇳ藵鷷裹", a_),
											o0_O.o.0_O_O.
										});
										if (dataRow != null && Operators.CompareString(dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].ToString(), O00OOOo_O0_O.b("엳", a_), true) == 0)
										{
											flag2 = true;
										}
									}
									dataRow = dataTable.Rows.Find(new object[]
									{
										O00OOOo_O0_O.b("닳鿵铷鿹꫻鿽泿欁怃", a_),
										o0_O.Oo0o.oO0_oo.
									});
									if (dataRow != null && !dataRow.IsNull(O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)) && Operators.CompareString(o0OO__.O.0ooOoO_0_.(O_O0OO.o0_OO.000.(dataSet2).Substring(0, 4)), dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].ToString(), true) != 0)
									{
										MessageBox.Show(o0OoOOoOOo0.ooO.ooOO__o0_.(), O00OOOo_O0_O.b("⒐첌", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
										return false;
									}
									dataRow = dataTable.Rows.Find(new object[]
									{
										O00OOOo_O0_O.b("닳鿵铷鿹꫻鯽狿瘁洃椅昇", a_),
										o0_O.o.O_O_OOo.
									});
									if (dataRow != null)
									{
										num = Conversions.ToDouble(dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)]);
										if (Conversions.ToDouble(dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)]) > 80.0)
										{
											MessageBox.Show(o0OoOOoOOo0.oo00o.0OoO.(), O00OOOo_O0_O.b("⒐첌", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
											return false;
										}
									}
									if (dataRow != null)
									{
										num2 = Conversions.ToDouble(dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)]);
										if (num2 < 55.0)
										{
											OO_00oOO.FileSys.CopyFile(A_0, A_0 + O00OOOo_O0_O.b("\udaf3駵铷黹", a_), true);
											o0OoOOoOOo0.O_0_Oo_00.O.(A_0);
											dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = 80.0;
											Oo00.O0Oo_O.0O_0O.(dataRow);
											oleDbConnection.Close();
											oleDbConnection.Open();
										}
									}
									if (dataRow != null && num2 < 6.0)
									{
										OleDbCommand oleDbCommand = new OleDbCommand();
										oleDbCommand.Connection = oleDbConnection;
										oleDbCommand.CommandText = O00OOOo_O0_O.b("뗳髵賷鿹軻\udefd哿持昃樅洇⨉國", a_) + ooO0__OO.oo._O.() + O00OOOo_O0_O.b("꧳훵맷黹飻\udefd䏿洁栃猅攇搉Ⰻ唍怏昑簓䬕㠗丙礛昝吟", a_);
										oleDbCommand.ExecuteNonQuery();
										oleDbCommand.CommandText = O00OOOo_O0_O.b("ꇳ蛵鳷鯹裻鯽⃿夁", a_) + ooO0__OO.oo._O.() + O00OOOo_O0_O.b("꧳훵꯷鿹裻\udefd寿爁瀃清唇⨉ㄋ⸍䬏䘑甓琕琗缙䄛㸝", a_);
										oleDbCommand.ExecuteNonQuery();
										oleDbCommand.CommandText = O00OOOo_O0_O.b("뗳髵賷鿹軻\udefd哿持昃樅洇⨉國", a_) + ooO0__OO.oo._O.() + O00OOOo_O0_O.b("꧳훵맷黹飻\udefd䏿洁栃猅攇搉Ⰻ唍挏怑怓䬕㠗匙创䨝攟攡愣琥", a_);
										oleDbCommand.ExecuteNonQuery();
										dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = 80.0;
										Oo00.O0Oo_O.0O_0O.(dataRow);
									}
									o0OoOOoOOo0.oOOo_O._o0. = false;
									if (dataRow != null && num2 < 13.0)
									{
										o0OoOOoOOo0.oOOo_O._o0. = true;
										dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = 80.0;
										Oo00.O0Oo_O.0O_0O.(dataRow);
									}
									string text2 = OO_00oOO.FileSys.GetParentPath(A_0) + O00OOOo_O0_O.b("ꣳ듵釷铹ꃻ", a_) + o0OoOOoOOo0.oo00o.0OoO.(A_0) + O00OOOo_O0_O.b("\udaf3꛵跷飹郻韽揿Ⰱ怃樅搇", a_);
									dataRow = dataTable.Rows.Find(new object[]
									{
										O00OOOo_O0_O.b("ꓳ蓵韷郹駻鷽瓿刁瘃椅砇漉縋稍椏", a_),
										o0_O.O_o000_O.0.
									});
									if ((dataRow == null && Operators.CompareString(A_0, O_O0OO.o0OoO00OO.00O., true) != 0) & !o0OoOOoOOo0.oO.0_0oOOo.)
									{
										return false;
									}
									if (dataRow != null && !dataRow.IsNull(O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)))
									{
										string text3 = Conversions.ToString(dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)]);
										if (!text3.StartsWith(O00OOOo_O0_O.b("迳", a_)))
										{
											num = 9.0;
										}
										text3 = O_O0OO.OoO_00._.(text3, dataSet2);
										o_O_o_oOoo__.OOOO_OO._oo.(projectProperty, text3, '\v');
										if (O_O0OO.o00.0.(projectProperty))
										{
											flag2 = false;
										}
										dataRow = dataTable.Rows.Find(new object[]
										{
											O00.MD5Encrypt(O_O0OO.o0_OO.000.(dataSet2)).Substring(0, 12),
											o0_O.O_o0.0_o0o_.
										});
										if (dataRow != null && !dataRow.IsNull(O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)))
										{
											string left = o0OO__.OO0oO.o.(1925, 75, false).Trim();
											string text4 = "";
											string text5 = "";
											o0OO__.oOO.o_.(ref text4, ref text5);
											string text6 = text4 + text5;
											text6 = O00.ooo000o_0.00o0.(text6, text5, text4);
											text6 = Strings.Left(O00.MD5Encrypt(text6), 75);
											DataRow dataRow2 = dataTable.Rows.Find(new object[]
											{
												O00OOOo_O0_O.b("鋳駵胷軹鷻鳽泿朁", a_),
												o0_O.Oo00.0.
											});
											bool flag4;
											if (dataRow2 != null && Operators.CompareString(dataRow2[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].ToString(), O00.MD5Encrypt(text4 + text5), true) == 0)
											{
												flag4 = true;
											}
											if (Operators.CompareString(left, text6, true) != 0 || !flag4)
											{
												string left2 = text4 + text5;
												string[] array = O00.oO_.0o_oo_0O_.(dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].ToString(), O00OOOo_O0_O.b("鋳駵胷", a_), O00OOOo_O0_O.b("鋳駵胷", a_)).ToString().Split(new char[]
												{
													'\r',
													'\n'
												}, StringSplitOptions.RemoveEmptyEntries);
												int num3 = array.Length - 1;
												for (int i = 0; i <= num3; i++)
												{
													if (Operators.CompareString(left2, array[i].Replace(O00OOOo_O0_O.b("\ud9f3", a_), ""), true) == 0)
													{
														left2 = "";
														break;
													}
												}
												if (Operators.CompareString(left2, "", true) > 0)
												{
													MessageBox.Show(O00.DecryptText(o0OoOOoOOo0.OoO0_.oOOOoo.(), O00OOOo_O0_O.b("엳", a_), O00OOOo_O0_O.b("웳", a_)), O00OOOo_O0_O.b("⒐첌", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
													return false;
												}
											}
										}
										else if (projectProperty.oO_._Ooo_0.)
										{
											MessageBox.Show(O00.DecryptText(o0OoOOoOOo0.OoO0_.oOOOoo.(), O00OOOo_O0_O.b("엳", a_), O00OOOo_O0_O.b("웳", a_)), O00OOOo_O0_O.b("⒐첌", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
											return false;
										}
										o0OoOOoOOo0.o0.ooO_o__O0OO. = projectProperty.LoadMessage;
										if (!OO_00oOO.FileSys.FileExists(text2) || Operators.CompareString(projectProperty.AsmAPICrcString, O00.CRCCheckFile(text2), true) != 0 || num2 < 33.0)
										{
											string a_3 = o0_.o_000Oo0O_.00o.(dataTable, "");
											if (OO_00oOO.FileSys.FileExists(text2))
											{
												OO_00oOO.FileSys.DeleteFile(text2);
											}
											o0_.Oo_0.OOo0oO0.(a_3, text2, dataTable, true, "", true);
											projectProperty.AsmAPICrcString = O00.CRCCheckFile(text2);
											projectProperty.o0Oo.Oo_0oO0o. = true;
										}
										dataRow = dataTable.Rows.Find(new object[]
										{
											O00OOOo_O0_O.b("닳菵雷駹裻韽濿氁眃㐅", a_),
											o0_O.Oo.Ooooo0O.
										});
										if (dataRow == null)
										{
											dataRow = dataTable.NewRow();
											dataRow[O00OOOo_O0_O.b("뫳韵闷鿹", a_)] = O00OOOo_O0_O.b("닳菵雷駹裻韽濿氁眃㐅", a_);
											dataRow[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)] = o0_O.Oo.Ooooo0O.;
											dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = OoOo0O.OO_o.0o_O.(8);
											dataTable.Rows.Add(dataRow);
										}
										if (!dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].ToString().StartsWith(O00OOOo_O0_O.b("\udcf3", a_) + OO_00oOO.ApplicationVertion() + O00OOOo_O0_O.b("\uddf3", a_)))
										{
											DataRow dataRow3 = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("ꓳ菵髷雹闻跽棿", a_));
											string text7 = o0OO__.O.0ooOoO_0_.(OO_00oOO.ApplicationVertion()).Substring(0, 8);
											string text8 = dataRow3[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].ToString();
											text8 = O00.oO_.0o_oo_0O_.(text8, text7, text7);
											text7 = o0OO__.O.0ooOoO_0_.(O_O0OO.o0_OO.000.(dataSet2).Substring(0, 8)).Substring(0, 5);
											text8 = O00.ooo000o_0.00o0.(text8, text7, text7);
											dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = O00OOOo_O0_O.b("\udcf3", a_) + OO_00oOO.ApplicationVertion() + O00OOOo_O0_O.b("\uddf3", a_) + text8;
											Oo00.o0_o._O_.(dataTable, true);
										}
										dataRow = dataTable.Rows.Find(new object[]
										{
											O00OOOo_O0_O.b("닳菵雷駹裻韽濿氁眃㐅", a_),
											o0_O.oOOo0o._0.
										});
										if (dataRow == null)
										{
											dataRow = dataTable.NewRow();
											dataRow[O00OOOo_O0_O.b("뫳韵闷鿹", a_)] = O00OOOo_O0_O.b("닳菵雷駹裻韽濿氁眃㐅", a_);
											dataRow[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)] = o0_O.oOOo0o._0.;
											dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = OoOo0O.OO_o.0o_O.(8);
											dataTable.Rows.Add(dataRow);
										}
										if (!dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].ToString().StartsWith(O00OOOo_O0_O.b("\udcf3", a_) + OO_00oOO.ApplicationVertion() + O00OOOo_O0_O.b("\uddf3", a_)))
										{
											DataRow dataRow4 = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("ꓳ菵髷雹闻跽棿、", a_));
											string text9 = o0OO__.O.0ooOoO_0_.(OO_00oOO.ApplicationVertion()).Substring(0, 8);
											string text10 = dataRow4[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].ToString();
											text10 = O00.oO_.0o_oo_0O_.(text10, text9, text9);
											text9 = o0OO__.O.0ooOoO_0_.(O_O0OO.o0_OO.000.(dataSet2).Substring(0, 8)).Substring(0, 5);
											text10 = O00.ooo000o_0.00o0.(text10, text9, text9);
											dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = O00OOOo_O0_O.b("\udcf3", a_) + OO_00oOO.ApplicationVertion() + O00OOOo_O0_O.b("\uddf3", a_) + text10;
											Oo00.o0_o._O_.(dataTable, true);
										}
										string text11 = OO_00oOO.FileSys.GetParentPath(A_0) + O00OOOo_O0_O.b("ꣳ듵釷铹ꃻ", a_) + o0OoOOoOOo0.oo00o.0OoO.(A_0) + O00OOOo_O0_O.b("\udaf3꛵諷闹電鯽揿瘁⨃戅搇昉", a_);
										if (OO_00oOO.FileSys.FileExists(text11) && (num <= 0.0 || num >= 10.0) && num2 >= 33.0)
										{
											assembly = Assembly.Load(File.ReadAllBytes(text11));
										}
										else
										{
											dataRow = dataTable.Rows.Find(new object[]
											{
												O00OOOo_O0_O.b("ꓳ蓵韷郹駻鷽瓿䄁欃戅洇", a_),
												o0_O.O_o000_O.0.
											});
											if (dataRow != null && !dataRow.IsNull(O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)))
											{
												string text12 = Conversions.ToString(dataRow[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)]);
												if (!text12.StartsWith(O00OOOo_O0_O.b("迳", a_)))
												{
													num = 9.0;
												}
												text12 = O_O0OO.OoO_00._.(text12, dataSet2);
												if (num2 > 0.0 && num2 < 33.0 && !string.IsNullOrEmpty(text12))
												{
													text12 = new Regex(O00OOOo_O0_O.b("\udcf3ꫵ髷폹퓻쇽㳿⌁圃缅笇縉椋挍㸏㬑㰓䄕焗琙砛焝土儡砣ࠥ渧䔩師䌭䌯渱ᨳἵ", a_), RegexOptions.IgnoreCase).Replace(text12, O00OOOo_O0_O.b("탳쟵꯷菹迻諽旿漁⨃∅㨇", a_));
													flag3 = true;
												}
												o_O_o_oOoo__.OOOO_OO._oo.(projectProperty, text12, '\v');
											}
											assembly = o0_.Oo_0.OOo0oO0.(projectProperty, dataTable, O_O0OO.o0_OO.000.(dataSet2), text11, dataTable);
											OO_00oOO.FileSys.FileExists(text11);
										}
										o0OoOOoOOo0.O.0_0ooo0O. = A_0;
										o0OoOOoOOo0.o___O0.O00. = O_O0OO.o0_OO.000.(dataSet2);
										BeforeOpenProjectEventArgs beforeOpenProjectEventArgs = new BeforeOpenProjectEventArgs(A_0);
										if (!O_O0OO.o00.0.(projectProperty))
										{
											O_O0OO.OoO_o.oO0o0O.(assembly, O00OOOo_O0_O.b("뛳鏵黷闹軻鯽俿爁愃栅堇砉挋損甏焑怓", a_), new object[]
											{
												beforeOpenProjectEventArgs
											}, true, O00OOOo_O0_O.b("赫ᢃ", a_), true);
										}
										if (beforeOpenProjectEventArgs.Cancel)
										{
											o0OoOOoOOo0.O.0_0ooo0O. = "";
											o0OoOOoOOo0.o___O0.O00. = "";
											return false;
										}
										OO_00oOO.MyTimers.Clear();
										foreach (DataRow dataRow5 in dataTable.Select(O00OOOo_O0_O.b("꿳ꋵ臷諹駻ꏽ⃿㼁␃", a_) + Conversions.ToString(3)))
										{
											TimerProperty timerProperty = new TimerProperty();
											Timer timer = new Timer();
											if (!dataRow5.IsNull(O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)))
											{
												o_O_o_oOoo__.OOOO_OO._oo.(timerProperty, O00.oO_.0o_oo_0O_.(Conversions.ToString(dataRow5[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)]), O00OOOo_O0_O.b("ꃳ鿵闷鿹軻", a_), O_O0OO.o0_OO.000.(dataSet2)), '\v');
											}
											timer.Name = Conversions.ToString(dataRow5[O00OOOo_O0_O.b("뫳韵闷鿹", a_)]);
											string a_4 = O00OOOo_O0_O.b("ꃳ鿵闷鿹軻ꇽ", a_) + timer.Name;
											timer.Tag = a_4;
											timer.Interval = timerProperty.Interval;
											timer.Enabled = timerProperty.Enabled;
											timer.CanPause = timerProperty.CanPause;
											OO_00oOO.MyTimers.Add(Conversions.ToString(dataRow5[O00OOOo_O0_O.b("뫳韵闷鿹", a_)]), timer);
										}
										O_O0OO.O_OO.OO. = true;
									}
								}
								if (Operators.CompareString(text, ooO0__OO.o.00_0o0__OoO.(), true) == 0 && num2 < 55.0)
								{
									DataTable dataTable2 = dataSet2.Tables[ooO0__OO.o.00_0o0__OoO.()];
									HashSet<string> hashSet = new HashSet<string>();
									int num4 = 0;
									foreach (DataRow dataRow6 in dataSet2.Tables[ooO0__OO.OOo0._00O_o00.()].Select(O00OOOo_O0_O.b("꿳ꋵ臷諹駻ꏽ⃿㼁␃", a_) + Conversions.ToString(9), "", DataViewRowState.CurrentRows))
									{
										DataRow dataRow7 = dataTable2.NewRow();
										string[] array4 = dataRow6[O00OOOo_O0_O.b("뫳韵闷鿹", a_)].ToString().Split(new char[]
										{
											'\t'
										});
										if (array4.Length == 2)
										{
											if (Operators.CompareString(array4[0], "", true) > 0)
											{
												dataRow7[O00OOOo_O0_O.b("ꓳ韵賷鋹", a_)] = array4[0];
											}
											dataRow7[O00OOOo_O0_O.b("뫳韵闷鿹", a_)] = array4[1];
										}
										else
										{
											dataRow7[O00OOOo_O0_O.b("뫳韵闷鿹", a_)] = RuntimeHelpers.GetObjectValue(dataRow6[O00OOOo_O0_O.b("뫳韵闷鿹", a_)]);
										}
										dataRow7[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)] = RuntimeHelpers.GetObjectValue(dataRow6[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)]);
										dataRow7[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = RuntimeHelpers.GetObjectValue(dataRow6[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)]);
										dataRow7[O00OOOo_O0_O.b("蟳蓵賷", a_)] = num4;
										num4++;
										dataRow6.Delete();
										dataTable2.Rows.Add(dataRow7);
										if (array4.Length == 2 && !hashSet.Contains(array4[0]))
										{
											hashSet.Add(array4[0]);
											dataRow7 = dataTable2.NewRow();
											dataRow7[O00OOOo_O0_O.b("뫳韵闷鿹", a_)] = array4[0];
											dataRow7[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)] = o0_O.O.00oOo0o.;
											dataRow7[O00OOOo_O0_O.b("蟳蓵賷", a_)] = num4;
											num4++;
											dataTable2.Rows.Add(dataRow7);
										}
									}
									Oo00.o0_o._O_.(dataTable2, true);
									Oo00.o0_o._O_.(dataSet2.Tables[ooO0__OO.OOo0._00O_o00.()], true);
								}
								if (Operators.CompareString(text, ooO0__OO.O0O.0o0.(), true) == 0 && dataTable.Rows.Find(new object[]
								{
									O00OOOo_O0_O.b("\udcf3꛵諷闹電鯽揿瘁䴃戅洇搉砋服瘏欑㴓", a_),
									O00OOOo_O0_O.b("\udcf3꛵諷闹電鯽揿瘁䴃戅洇搉砋服瘏欑㴓", a_)
								}) != null)
								{
									MessageBox.Show(O00OOOo_O0_O.b("尿୵ꮕ益຦ㆃ톬ş聵腠﹉௶", a_), O00OOOo_O0_O.b("⒐첌", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									o0OoOOoOOo0.O.0_0ooo0O. = "";
									o0OoOOoOOo0.o___O0.O00. = "";
									return false;
								}
								if (Operators.CompareString(text, ooO0__OO.O_O00.0_.(), true) == 0)
								{
									if ((dataTable.Rows.Count > 0 || projectProperty.HasUsers || flag2) && dataTable.Rows.Count == 0)
									{
										DataRow dataRow8 = dataTable.NewRow();
										UserProperty userProperty = new UserProperty();
										userProperty.Type = UserTypeEnum.Developer;
										userProperty.PassWord = O00.MD5Encrypt(O00.ooo000o_0.00o0.(ShareLibriay.GetRandString(8), ShareLibriay.GetRandString(8), ShareLibriay.GetRandString(8)));
										dataRow8[O00OOOo_O0_O.b("뫳韵闷鿹", a_)] = O00OOOo_O0_O.b("➦ﵷ", a_);
										dataRow8[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)] = UserTypeEnum.Developer;
										dataRow8[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = o_O_o_oOoo__.OOOO_OO._oo.(userProperty, false, '\v', false);
										dataTable.Rows.Add(dataRow8);
										dataRow8 = dataTable.NewRow();
										userProperty.PassWord = O00.MD5Encrypt(O00.ooo000o_0.00o0.(ShareLibriay.GetRandString(8), ShareLibriay.GetRandString(8), ShareLibriay.GetRandString(8)));
										userProperty.Type = UserTypeEnum.Administrator;
										dataRow8[O00OOOo_O0_O.b("뫳韵闷鿹", a_)] = O00OOOo_O0_O.b("喈ꂣ", a_);
										dataRow8[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)] = UserTypeEnum.Administrator;
										dataRow8[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = o_O_o_oOoo__.OOOO_OO._oo.(userProperty, false, '\v', false);
										dataTable.Rows.Add(dataRow8);
									}
									if (O_O0OO.o00.0.(projectProperty))
									{
										flag2 = false;
									}
									if (flag2)
									{
										o0OoOOoOOo0.OOOOO.o000.(dataSet2, dictionary, dictionary2, dictionary3, assembly, A_0, userInfo, projectProperty);
									}
									DataTable dataTable3;
									if (flag2 && !O_O0OO.o00.0.(projectProperty))
									{
										string text13 = "";
										string text14 = "";
										DataRow dataRow9 = dataSet2.Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
										{
											O00OOOo_O0_O.b("ꇳ藵鷷裹", a_),
											o0_O.Oo0_.o0.
										});
										if (dataRow9 != null)
										{
											text13 = dataRow9[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].ToString();
										}
										dataRow9 = dataSet2.Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
										{
											O00OOOo_O0_O.b("ꇳ藵鷷裹", a_),
											o0_O.OO_O.O0ooO0O.
										});
										if (dataRow9 != null)
										{
											text14 = dataRow9[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].ToString();
										}
										if (Operators.CompareString(text13, "", true) > 0 && Operators.CompareString(text14, "", true) > 0 && (dictionary.ContainsKey(text13) || dictionary2.ContainsKey(text13)))
										{
											dataTable3 = new DataTable();
											if (dictionary.ContainsKey(text13))
											{
												OleDbDataAdapter oleDbDataAdapter2;
												if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(dictionary[text13]))
												{
													oleDbDataAdapter2 = new OleDbDataAdapter(O00OOOo_O0_O.b("ꟳ鏵铷鿹鿻諽⃿⠁␃䀅稇攉愋⸍", a_) + text14, dictionary[text13]);
												}
												else
												{
													if (!text14.StartsWith(O00OOOo_O0_O.b("꿳", a_)))
													{
														text14 = O00OOOo_O0_O.b("꿳", a_) + text14 + O00OOOo_O0_O.b("꧳", a_);
													}
													oleDbDataAdapter2 = new OleDbDataAdapter(O00OOOo_O0_O.b("ꟳ鏵铷鿹鿻諽⃿⠁␃䀅稇攉愋⸍", a_) + text14, dictionary[text13]);
												}
												oleDbDataAdapter2.Fill(dataTable3);
												o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter2);
												dataTable3.ExtendedProperties.Add(O00OOOo_O0_O.b("냳韵賷鯹뷻髽懿爁瀃挅稇", a_), oleDbDataAdapter2);
											}
											else
											{
												O0O o0O = dictionary2[text13];
												HttpClient httpClient = o0O.oO0_0.o.();
												httpClient.FormData[O00OOOo_O0_O.b("뗳闵賷鏹鏻都", a_)] = 1.ToString();
												if (o0O.OO.OoO0. == DataServerTypeEnum.Oracle)
												{
													httpClient.Select = O00OOOo_O0_O.b("ꟳ鏵铷鿹鿻諽⃿⠁␃䀅稇攉愋⸍", a_) + text14;
												}
												else
												{
													if (!text14.StartsWith(O00OOOo_O0_O.b("꿳", a_)))
													{
														text14 = O00OOOo_O0_O.b("꿳", a_) + text14 + O00OOOo_O0_O.b("꧳", a_);
													}
													httpClient.Select = O00OOOo_O0_O.b("ꟳ鏵铷鿹鿻諽⃿⠁␃䀅稇攉愋⸍", a_) + text14;
												}
												dataTable3 = httpClient.GetBaseDataTable();
												DataTable dataTable4 = new DataTable(dataTable3, null, null, text14, null);
												dataTable4.ConnectionName = text13;
												dataTable4.DataServer = httpClient.Oo_0oO0Oo0_.O_.;
												dataTable4.UpdateServer = httpClient.Oo_0oO0Oo0_.O_.;
												dataTable4.UpdateColumns = (List<string>)dataTable3.ExtendedProperties[O00OOOo_O0_O.b("ꇳ蛵鳷鯹裻鯽䏿洁栃猅攇搉缋", a_)];
												dataTable3.ExtendedProperties.Clear();
												dataTable3.ExtendedProperties.Add(O00OOOo_O0_O.b("ꏳ鏵髷꿹賻髽懿瘁愃琅", a_), dataTable4);
											}
											foreach (DataRow dataRow10 in dataTable.Select(O00OOOo_O0_O.b("꿳ꋵ臷諹駻ꏽ⃿㼁␃", a_) + Conversions.ToString(0) + O00OOOo_O0_O.b("퓳맵諷\udaf9ꟻ꫽秿爁愃嬅⠇㜉Ⰻ", a_) + Conversions.ToString(1)))
											{
												DataRow dataRow11 = dataTable3.NewRow();
												dataRow11[O00OOOo_O0_O.b("뫳韵闷鿹", a_)] = RuntimeHelpers.GetObjectValue(dataRow10[O00OOOo_O0_O.b("뫳韵闷鿹", a_)]);
												dataRow11[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)] = RuntimeHelpers.GetObjectValue(dataRow10[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)]);
												dataRow11[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = RuntimeHelpers.GetObjectValue(dataRow10[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)]);
												dataTable3.Rows.Add(dataRow11);
											}
											dataTable3.AcceptChanges();
										}
										else
										{
											dataTable3 = dataTable;
										}
									}
									else
									{
										dataTable3 = dataTable;
									}
									if (dataTable3.Rows.Count > 0)
									{
										if (!O_O0OO.o00.0.(projectProperty) && !flag2)
										{
											try
											{
												foreach (object obj2 in dataTable3.Rows)
												{
													DataRow dataRow12 = (DataRow)obj2;
													if (Conversions.ToInteger(dataRow12[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)]) == 4)
													{
														userInfo = new UserInfo();
														userInfo.Type = UserTypeEnum.User;
														userInfo.Default = true;
														userInfo.Name = dataRow12[O00OOOo_O0_O.b("뫳韵闷鿹", a_)].ToString();
														if (!dataRow12.IsNull(O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)))
														{
															UserProperty userProperty2 = new UserProperty();
															o_O_o_oOoo__.OOOO_OO._oo.(userProperty2, dataRow12[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)].ToString(), '\v');
															userInfo.Group = userProperty2.Group;
															userInfo.Roles = userProperty2.Role;
															userInfo.Password = userProperty2.PassWord;
															userInfo.Tag = userProperty2.Tag;
														}
													}
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
										if (userInfo == null)
										{
											O\u3002\u3002\u3002\u3002\u3002\u3000\u3002 o_u3002_u3002_u3002_u3002_u3002_u3000_u = new O\u3002\u3002\u3002\u3002\u3002\u3000\u3002(dataTable3, dataSet2.Tables[ooO0__OO.OOo0._00O_o00.()], OO_00oOO.FileSys.GetParentPath(A_0), projectProperty.OoOO.O0OoOoOO0.);
											if (o_u3002_u3002_u3002_u3002_u3002_u3000_u.O.O0OOoOO.().Tag == null)
											{
												o_u3002_u3002_u3002_u3002_u3002_u3000_u.O.O0OOoOO.().Text = projectProperty.LogTip;
											}
											if (o_u3002_u3002_u3002_u3002_u3002_u3000_u.ShowDialog() != DialogResult.OK)
											{
												o0OoOOoOOo0.O.0_0ooo0O. = "";
												o0OoOOoOOo0.o___O0.O00. = "";
												return false;
											}
											userInfo = o_u3002_u3002_u3002_u3002_u3002_u3000_u.OooO.00o.;
										}
									}
									else
									{
										userInfo = new UserInfo();
										userInfo.Type = UserTypeEnum.Developer;
										userInfo.Name = O00OOOo_O0_O.b("➦ﵷ", a_);
									}
									if (userInfo.Type == UserTypeEnum.Developer && O_O0OO.o00.0.(projectProperty))
									{
										assembly = o0_.Oo_0.OOo0oO0.("", "", dataSet2.Tables[ooO0__OO.OOo0._00O_o00.()], false, "", true);
									}
								}
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					dataSet2.Tables[ooO0__OO.oo._O.()].Columns.Add(O00OOOo_O0_O.b("냳鏵铷鿹裻鯽", a_), typeof(bool));
					dataSet2.Relations.Add(O00OOOo_O0_O.b("믳菵賷鿹軻뫽懿瘁攃唅朇缉縋洍甏", a_), dataSet2.Tables[ooO0__OO.o0O._ooo_O_.()].Columns[O00OOOo_O0_O.b("뫳韵闷鿹", a_)], dataSet2.Tables[ooO0__OO.O0_.OOo0OO.()].Columns[O00OOOo_O0_O.b("냳韵賷鯹꿻釽痿瀁會挅", a_)]);
					dataSet2.Relations.Add(O00OOOo_O0_O.b("꛳鿵髷飹鏻都", a_), dataSet2.Tables[ooO0__OO.oo._o.()].Columns[O00OOOo_O0_O.b("뿳鏵臷", a_)], dataSet2.Tables[ooO0__OO.oo._o.()].Columns[O00OOOo_O0_O.b("ꓳ韵諷鿹鋻諽䯿朁紃", a_)]);
					dataSet2.Relations.Add(O00OOOo_O0_O.b("럳駵闷諹鏻都旿氁瀃", a_), dataSet2.Tables[ooO0__OO.oo._O.()].Columns[O00OOOo_O0_O.b("뿳鏵臷", a_)], dataSet2.Tables[ooO0__OO.oo._O.()].Columns[O00OOOo_O0_O.b("ꓳ韵諷鿹鋻諽䯿朁紃", a_)]);
					oleDbConnection.Close();
					if (!flag2)
					{
						o0OoOOoOOo0.OOOOO.o000.(dataSet2, dictionary, dictionary2, dictionary3, assembly, A_0, userInfo, projectProperty);
					}
					o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, dataSet, dataTableCollection, userInfo, assembly, O_O0OO.OoO.0OO__0ooo.());
					o0OoOOoOOo0.OOOOO.o000.(dictionary, dictionary2, dictionary3, dataSet2, dataSet, dataTableCollection, userInfo, assembly, oleDbConnection, projectProperty);
					o0OoOOoOOo0.o00__oo.O0Oo0o.(dataSet2, dataSet, dataTableCollection);
					o0OoOOoOOo0.OO0._Oo0o.(dataSet2, dataSet);
					o0OoOOoOOo0.OOoOO_o00_.o.(dataSet2, dataTableCollection, dataSet);
					typeof(ProjectProperty).GetProperty(O00OOOo_O0_O.b("닳鿵铷鿹뗻髽旿氁瀃漅渇猉", a_), BindingFlags.Instance | BindingFlags.Public).SetValue(projectProperty, ShareLibriay.FileIdentify(), null);
					if (userInfo == null || userInfo.Type != UserTypeEnum.Developer || !O_O0OO.o00.0.(projectProperty))
					{
						o0OoOOoOOo0.OOOOO.o000.(dataSet2, dataTableCollection, dataSet);
					}
					o0OoOOoOOo0.O_0_Oo_00.O.(a_2, dataSet);
					o0OoOOoOOo0.O.0_0ooo0O. = "";
					o0OoOOoOOo0.o___O0.O00. = "";
					try
					{
						Main.OO_O.o..o._oOO0..O0oo_0_.__0__.();
						if (O_O0OO.O._o_.() != null)
						{
							O_O0OO.O._o_.().Clear();
						}
						if (O_O0OO.OoO__.0oO0oo.() != null)
						{
							O_O0OO.OoO__.0oO0oo.().Clear();
						}
						OO_00oOO.User = userInfo;
						O_O0OO.O_O.OOO_o.(oleDbConnection);
						O_O0OO.O_O.OOO_o.(dataSet2);
						O_O0OO.oO.__0O0oooo.(dataSet);
						O_O0OO.O_O.OOO_o.(dictionary);
						O_O0OO.O_O.OOO_o.(dictionary2);
						O_O0OO.OoO_o.oO0o0O.(dictionary3);
						O_O0OO.o.00O_O.().Clear();
						if (assembly != null)
						{
							O_O0OO.oo0_o_.o. = assembly;
						}
						else
						{
							O_O0OO.oo0_o_.o. = o0_.Oo_0.OOo0oO0.("", "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", true);
						}
						O_O0OO.O0_00o.o0__o. = projectProperty;
						O_O0OO.O0_00o.o0__o..O_o0__O.o.();
						if (num2 > 0.0 && num2 < 33.0)
						{
							o0_.O__.0.(dataSet2.Tables[ooO0__OO.OOo0._00O_o00.()]);
							o0_.ooO.OOO_O_OO_0.(dataSet2.Tables[ooO0__OO.O0O.0o0.()]);
							flag3 = true;
						}
						if (flag3)
						{
							O_O0OO.O0_00o.o0__o..O_O_.o.(true, true);
						}
						O_O0OO.OOo_o.0o. = Foxtable.My.c.OOOOO.o.().FileSystem.GetParentPath(A_0) + O00OOOo_O0_O.b("ꣳ뿵闷鯹鯻鯽珿币", a_);
						OO_00oOO.DataTables = dataTableCollection;
						OO_00oOO.ProjectFile = A_0;
						O_O0OO.O_O.OOO_o.(a_2);
						o0OoOOoOOo0.OO_.o0O_o.();
						OO_00oOO.Tables = new TableCollection(O_O0OO.o__.O.());
						OO_00oOO.Forms.o_.O__O00OOO.();
						XLSFunctions.Reports.o0_.O_o.();
						WordFunctions.Reports.Load();
						OO_00oOO.Reports.o.0OoO.();
						Main.OO_O.o..o._oOO0. = false;
						if (O_O0OO.O0_00o.o0__o..o0Oo.Oo_0oO0o.)
						{
							O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
						}
						if (num2 > 0.0 && num2 < 33.0)
						{
							o0_.o_000Oo0O_.00o.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()]);
							o0_.o_000Oo0O_.00o.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()]);
						}
					}
					catch (Exception a_5)
					{
						ooO.oOo0Oo.o.(a_5, "");
						Application.Exit();
					}
					if (num > 0.0 && num < 10.0)
					{
						O_O0OO.O0_00o.o0__o..O_O_.o.(false, true);
						DataTable dataTable5 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O_O00.0_.()];
						DataRow dataRow13 = null;
						if (num == 9.0)
						{
							O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
						}
						DataRow dataRow14 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
						{
							O00OOOo_O0_O.b("ꇳ藵鷷裹믻賽濿省球甅", a_),
							o0_O.ooooO.oOo0O__O.
						});
						if (dataRow14 != null)
						{
							try
							{
								foreach (object obj3 in dataTable5.Rows)
								{
									DataRow dataRow15 = (DataRow)obj3;
									if (Conversions.ToInteger(dataRow15[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)]) == 5)
									{
										dataRow13 = dataRow15;
										break;
									}
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
							if (dataRow13 == null)
							{
								dataRow13 = dataTable5.NewRow();
								dataRow13[O00OOOo_O0_O.b("뫳韵闷鿹", a_)] = Enum.GetName(typeof(UserTypeEnum), UserTypeEnum.Groups);
								dataRow13[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)] = UserTypeEnum.Groups;
								dataTable5.Rows.Add(dataRow13);
							}
							dataRow13[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = RuntimeHelpers.GetObjectValue(dataRow14[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)]);
							dataRow14.Delete();
							Oo00.o0_o._O_.(dataTable5, true);
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
						}
						dataRow14 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
						{
							O00OOOo_O0_O.b("ꇳ藵鷷裹껻釽泿朁眃", a_),
							o0_O.ooooO.oOo0O__O.
						});
						dataRow13 = null;
						if (dataRow14 != null)
						{
							try
							{
								foreach (object obj4 in dataTable5.Rows)
								{
									DataRow dataRow16 = (DataRow)obj4;
									if (Conversions.ToInteger(dataRow16[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)]) == 6)
									{
										dataRow13 = dataRow16;
										break;
									}
								}
							}
							finally
							{
								IEnumerator enumerator5;
								if (enumerator5 is IDisposable)
								{
									(enumerator5 as IDisposable).Dispose();
								}
							}
							if (dataRow13 == null)
							{
								dataRow13 = dataTable5.NewRow();
								dataRow13[O00OOOo_O0_O.b("뫳韵闷鿹", a_)] = Enum.GetName(typeof(UserTypeEnum), UserTypeEnum.Roles);
								dataRow13[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)] = UserTypeEnum.Roles;
								dataTable5.Rows.Add(dataRow13);
							}
							dataRow13[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = RuntimeHelpers.GetObjectValue(dataRow14[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)]);
							dataRow14.Delete();
							Oo00.o0_o._O_.(dataTable5, true);
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
						}
						dataRow14 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
						{
							O00OOOo_O0_O.b("뗳苵賷鯹裻鷽棿䬁樃怅朇", a_),
							o0_O.o0OOo_O0_._O.
						});
						dataRow13 = null;
						if (dataRow14 != null)
						{
							try
							{
								foreach (object obj5 in dataTable5.Rows)
								{
									DataRow dataRow17 = (DataRow)obj5;
									if (Conversions.ToInteger(dataRow17[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)]) == 7)
									{
										dataRow13 = dataRow17;
										break;
									}
								}
							}
							finally
							{
								IEnumerator enumerator6;
								if (enumerator6 is IDisposable)
								{
									(enumerator6 as IDisposable).Dispose();
								}
							}
							if (dataRow13 == null)
							{
								dataRow13 = dataTable5.NewRow();
								dataRow13[O00OOOo_O0_O.b("뫳韵闷鿹", a_)] = Enum.GetName(typeof(UserTypeEnum), UserTypeEnum.AttatchInfo);
								dataRow13[O00OOOo_O0_O.b("ꃳ迵裷鿹", a_)] = UserTypeEnum.AttatchInfo;
								dataTable5.Rows.Add(dataRow13);
							}
							dataRow13[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)] = RuntimeHelpers.GetObjectValue(dataRow14[O00OOOo_O0_O.b("럳駵雷鳹闻駽", a_)]);
							dataRow14.Delete();
							Oo00.o0_o._O_.(dataTable5, true);
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
						}
					}
					if (O_O0OO.OoO.0OO__0ooo.().HasChanges())
					{
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
					}
					result = true;
				}
				catch (Exception a_6)
				{
					ooO.oOo0Oo.o.(a_6, "");
					result = false;
				}
				finally
				{
					if (oleDbConnection.State == ConnectionState.Open)
					{
						oleDbConnection.Close();
					}
				}
			}
			return result;
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x00216CA8 File Offset: 0x00214EA8
		private static void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					dataTable.o0O.ooO00.();
					try
					{
						foreach (DataCol dataCol in dataTable.DataCols)
						{
							dataCol.o_.Oo00_O_00_.();
						}
					}
					finally
					{
						IEnumerator<DataCol> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<DataTable> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x00216D2C File Offset: 0x00214F2C
		private static void <<EMPTY_NAME>>(DataSet A_0, Dictionary<string, OleDbConnection> A_1, Dictionary<string, O0O> A_2, Dictionary<string, O_0oOo_OO> A_3, Assembly A_4, string A_5, UserInfo A_6, ProjectProperty A_7)
		{
			try
			{
				foreach (object obj in A_0.Tables[ooO0__OO.o0O._ooo_O_.()].Rows)
				{
					DataRow a_ = (DataRow)obj;
					o0OoOOoOOo0.OOOOO.o000.(A_1, A_2, A_3, A_0, a_, A_4, A_5, A_6, A_7);
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

		// Token: 0x06004A9E RID: 19102 RVA: 0x00216DA4 File Offset: 0x00214FA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void <<EMPTY_NAME>>(Dictionary<string, OleDbConnection> A_0, Dictionary<string, O0O> A_1, Dictionary<string, O_0oOo_OO> A_2, DataSet A_3, DataRow A_4, Assembly A_5, string A_6, UserInfo A_7, ProjectProperty A_8)
		{
			int a_ = 15;
			O_0oOo_OO o_0oOo_OO = new O_0oOo_OO();
			string text = O00.oO_.0o_oo_0O_.(Conversions.ToString(A_4[O00OOOo_O0_O.b("뇱鯳飵雷鿹鿻諽槿洁樃唅簇砉攋怍眏", a_)]), O_O0OO.o0_OO.000.(A_3), ooO0__OO.o0O._ooo_O_.());
			BeforeConnectOuterDataSourceEventArgs beforeConnectOuterDataSourceEventArgs = new BeforeConnectOuterDataSourceEventArgs(Conversions.ToString(A_4[O00OOOo_O0_O.b("볱闳鯵鷷", a_)]), text, A_6, A_7);
			O_O0OO.OoO_o.oO0o0O.(A_5, O00OOOo_O0_O.b("냱釳郵韷裹駻뷽濿氁樃挅欇縉䌋笍搏眑易刕礗渙紛䴝伟圡嘣䔥䴧", a_), new object[]
			{
				beforeConnectOuterDataSourceEventArgs
			}, true, O00OOOo_O0_O.b("譩᪅", a_), true);
			text = beforeConnectOuterDataSourceEventArgs.ConnectionString;
			OleDbConnection oleDbConnection = null;
			O0O o0O = null;
			if (!text.StartsWith(O00OOOo_O0_O.b("髱胳苵裷샹폻퇽", a_), StringComparison.OrdinalIgnoreCase) && !text.StartsWith(O00OOOo_O0_O.b("髱胳苵裷觹웻퇽⿿", a_), StringComparison.OrdinalIgnoreCase))
			{
				oleDbConnection = new OleDbConnection(text);
			}
			else
			{
				o0O = new O0O(text);
			}
			try
			{
				if (oleDbConnection != null)
				{
					oleDbConnection.Open();
					o_0oOo_OO.oo.00O0__o.(true);
					oleDbConnection.Close();
					A_0.Add(Conversions.ToString(A_4[O00OOOo_O0_O.b("볱闳鯵鷷", a_)]), oleDbConnection);
					A_2.Add(Conversions.ToString(A_4[O00OOOo_O0_O.b("볱闳鯵鷷", a_)]), o_0oOo_OO);
				}
				else if (o0O.OO._o_OO.())
				{
					A_1.Add(Conversions.ToString(A_4[O00OOOo_O0_O.b("볱闳鯵鷷", a_)]), o0O);
				}
			}
			catch (Exception ex)
			{
				Main.OO_O.o. = SplashFormStateEnum.Hide;
				MessageBox.Show(O00OOOo_O0_O.b("ອၧ⑶妘\udcfd", a_) + Conversions.ToString(A_4[O00OOOo_O0_O.b("볱闳鯵鷷", a_)]) + O00OOOo_O0_O.b("탱얪퍸൲꡻ցꆄѵ屗ၧࡘ\udb5aঋ˲\udd9eꉴꪘ硪桲瑺뭾睄њ᙭⟚", a_), O00OOOo_O0_O.b("᭸", a_), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (((oleDbConnection != null && !o_0oOo_OO.oo.00O0__o.()) || (o0O != null && !o0O.OO.OoO0.)) && A_7 != null)
			{
				if (A_7.Type == UserTypeEnum.Developer || (A_7.Type == UserTypeEnum.Administrator & A_8.AllowEditConnection))
				{
					bool visible = Main.ProcessForm.Visible;
					O\u3002\u3000\u3000 o_u3002_u3000_u = new O\u3002\u3000\u3000();
					o_u3002_u3000_u.OO._000_O0o_.().Visible = true;
					o_u3002_u3000_u.OO._000_O0o_.().Text = text;
					Main.ProcessForm.Hide();
					Main.OO_O.o. = SplashFormStateEnum.Hide;
					if (o_u3002_u3000_u.ShowDialog() == DialogResult.OK)
					{
						text = o_u3002_u3000_u.OO._000_O0o_.().Text.Trim();
						if (!text.StartsWith(O00OOOo_O0_O.b("髱胳苵裷샹폻퇽", a_), StringComparison.OrdinalIgnoreCase) && !text.StartsWith(O00OOOo_O0_O.b("髱胳苵裷觹웻퇽⿿", a_), StringComparison.OrdinalIgnoreCase))
						{
							if (oleDbConnection == null)
							{
								oleDbConnection = new OleDbConnection(text);
							}
							else
							{
								oleDbConnection.ConnectionString = text;
							}
							o_0oOo_OO.oo.00O0__o.(true);
							A_0.Add(Conversions.ToString(A_4[O00OOOo_O0_O.b("볱闳鯵鷷", a_)]), oleDbConnection);
							A_2.Add(Conversions.ToString(A_4[O00OOOo_O0_O.b("볱闳鯵鷷", a_)]), o_0oOo_OO);
						}
						else
						{
							if (o0O == null)
							{
								o0O = new O0O(text);
							}
							else
							{
								o0O.OO._o_OO.(text);
							}
							o0O.OO.OoO0. = true;
							A_1.Add(Conversions.ToString(A_4[O00OOOo_O0_O.b("볱闳鯵鷷", a_)]), o0O);
						}
						if (o_u3002_u3000_u.OO._000_O0o_.().Checked)
						{
							A_4[O00OOOo_O0_O.b("뇱鯳飵雷鿹鿻諽槿洁樃唅簇砉攋怍眏", a_)] = O00.ooo000o_0.00o0.(text, O_O0OO.o0_OO.000.(A_3), ooO0__OO.o0O._ooo_O_.());
							Oo00.O0Oo_O.0O_0O.(A_4);
						}
					}
					if (visible)
					{
						Main.ProcessForm.Show();
						return;
					}
				}
				else
				{
					ProjectData.EndApp();
				}
			}
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x00217144 File Offset: 0x00215344
		private static void <<EMPTY_NAME>>(Dictionary<string, OleDbConnection> A_0, Dictionary<string, O0O> A_1, Dictionary<string, O_0oOo_OO> A_2, DataSet A_3, DataSet A_4, DataTableCollection A_5, UserInfo A_6, Assembly A_7, OleDbConnection A_8, ProjectProperty A_9)
		{
			if (A_9 == null)
			{
				A_9 = O_O0OO.O0_00o.o0__o.;
			}
			DataTable dataTable = A_3.Tables[ooO0__OO.O0_.OOo0OO.()];
			try
			{
				foreach (object obj in dataTable.Rows)
				{
					o0OoOOoOOo0.OOOOO.o000.((DataRow)obj, A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, false, true, A_9);
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

		// Token: 0x06004AA0 RID: 19104 RVA: 0x002171D0 File Offset: 0x002153D0
		internal static void <<EMPTY_NAME>>(DataRow A_0, Dictionary<string, OleDbConnection> A_1, Dictionary<string, O0O> A_2, Dictionary<string, O_0oOo_OO> A_3, DataSet A_4, DataSet A_5, DataTableCollection A_6, UserInfo A_7, Assembly A_8, OleDbConnection A_9, bool A_10, bool A_11 = true, ProjectProperty A_12 = null)
		{
			int a_ = 18;
			if (A_12 == null)
			{
				A_12 = O_O0OO.O0_00o.o0__o.;
			}
			OtherTableTypeEnum otherTableTypeEnum = (OtherTableTypeEnum)Conversions.ToInteger(A_0[O00OOOo_O0_O.b("ꇴ軶觸黺", a_)]);
			OleDbConnection oleDbConnection = null;
			O0O o0O = null;
			string a_2 = "";
			string a_3 = Conversions.ToString(A_0[O00OOOo_O0_O.b("믴零铸黺", a_)]);
			if (A_0.IsNull(O00OOOo_O0_O.b("뇴零跸髺껼郾琀焂昄戆", a_)) || Operators.CompareString(A_0[O00OOOo_O0_O.b("뇴零跸髺껼郾琀焂昄戆", a_)].ToString(), "", true) == 0)
			{
				oleDbConnection = A_9;
			}
			else
			{
				string key = Conversions.ToString(A_0[O00OOOo_O0_O.b("뇴零跸髺껼郾琀焂昄戆", a_)]);
				if (A_3.ContainsKey(key) && A_3[key].oo.00O0__o.())
				{
					oleDbConnection = A_1[key];
				}
				else
				{
					if (!A_2.ContainsKey(key) || !A_2[key].OO.OoO0.)
					{
						return;
					}
					o0O = A_2[key];
				}
			}
			DataServerTypeEnum a_4 = DataServerTypeEnum.Access;
			if (o0O != null)
			{
				a_4 = o0O.OO.OoO0.;
			}
			else if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection))
			{
				a_4 = DataServerTypeEnum.Oracle;
			}
			else if (o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection))
			{
				a_4 = DataServerTypeEnum.SqlServer;
			}
			string text;
			if (otherTableTypeEnum == OtherTableTypeEnum.Table)
			{
				OuterTableSetting outerTableSetting = new OuterTableSetting();
				o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, Conversions.ToString(A_0[O00OOOo_O0_O.b("ꗴ藶雸诺飼跾甀稂", a_)]), '\v');
				text = o_O_o_oOoo__.OO_O0oO0.oooO_.(outerTableSetting, a_4);
				a_2 = outerTableSetting.SourceTable;
			}
			else
			{
				text = Conversions.ToString(A_0[O00OOOo_O0_O.b("ꗴ藶雸诺飼跾甀稂", a_)]);
				if (text.StartsWith(O00OOOo_O0_O.b("軴", a_)) && text.EndsWith(O00OOOo_O0_O.b("裴", a_)))
				{
					text = text.Trim(new char[]
					{
						'{',
						'}'
					});
					JoinTableProperty a_5 = new JoinTableProperty();
					o_O_o_oOoo__.OOOO_OO._oo.(a_5, text, '\v');
					text = Oo00.OO.0O0o.(a_5);
				}
			}
			BeforeLoadOuterTableEventArgs beforeLoadOuterTableEventArgs = new BeforeLoadOuterTableEventArgs(Conversions.ToString(A_0[O00OOOo_O0_O.b("믴零铸黺", a_)]), text, A_7);
			O_O0OO.OoO_o.oO0o0O.(A_8, O00OOOo_O0_O.b("럴鋶鿸铺迼髾䴀氂搄挆䘈縊礌樎挐䜒琔甖甘縚", a_), new object[]
			{
				beforeLoadOuterTableEventArgs
			}, true, O00OOOo_O0_O.b("豬ᦀ", a_), true);
			if (!beforeLoadOuterTableEventArgs.Cancel || !A_11)
			{
				text = beforeLoadOuterTableEventArgs.SelectString;
				if (oleDbConnection != null)
				{
					text = Oo00.o0_o._O_.(oleDbConnection, text, Convert.ToBoolean(RuntimeHelpers.GetObjectValue(Interaction.IIf(oleDbConnection == A_9, true, false))));
				}
				else if (o0O != null)
				{
					text = Oo00.o0_o._O_.(o0O.OO.OoO0., text, Convert.ToBoolean(RuntimeHelpers.GetObjectValue(Interaction.IIf(oleDbConnection == A_9, true, false))));
				}
				HttpClient httpClient = null;
				if (o0O != null)
				{
					httpClient = o0O.oO0_0.o.();
					httpClient.Select = text;
					if (otherTableTypeEnum == OtherTableTypeEnum.Table)
					{
						httpClient.FormData[O00OOOo_O0_O.b("듴银跸鋺鋼釾", a_)] = 1.ToString();
					}
					else
					{
						httpClient.FormData[O00OOOo_O0_O.b("듴银跸鋺鋼釾", a_)] = 2.ToString();
					}
				}
				o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text, a_3, A_5, A_6, a_2, A_10, A_9, A_7, A_4, 30, A_12, A_0[O00OOOo_O0_O.b("뇴零跸髺껼郾琀焂昄戆", a_)].ToString(), httpClient);
			}
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x00217520 File Offset: 0x00215720
		internal static void <<EMPTY_NAME>>(OleDbConnection A_0, string A_1, string A_2, DataSet A_3, DataTableCollection A_4, string A_5, bool A_6, OleDbConnection A_7, UserInfo A_8, DataSet A_9, int A_10 = 30, ProjectProperty A_11 = null, string A_12 = "", HttpClient A_13 = null)
		{
			int a_ = 7;
			if (A_11 == null)
			{
				A_11 = O_O0OO.O0_00o.o0__o.;
			}
			DataTable dataTable = null;
			OleDbDataAdapter oleDbDataAdapter = null;
			if (Operators.CompareString(A_2, "", true) > 0 && !A_2.StartsWith(O00OOOo_O0_O.b("駩闫鷭꿯", a_), StringComparison.CurrentCultureIgnoreCase) && !A_2.StartsWith(O00OOOo_O0_O.b("뗩", a_)) && Operators.CompareString(o0OoOOoOOo0.o0.ooO_o__O0OO., "", true) > 0)
			{
				Main.ProcessForm.o0__.Oo0O_O0O_.(o0OoOOoOOo0.o0.ooO_o__O0OO..Replace(O00OOOo_O0_O.b("釩\udceb鏭", a_), A_2));
				Application.DoEvents();
			}
			try
			{
				if (A_13 == null)
				{
					dataTable = new DataTable();
					A_1 = Oo00.o0_o._O_.(A_0, A_1, false);
					oleDbDataAdapter = new OleDbDataAdapter(A_1, A_0);
					oleDbDataAdapter.SelectCommand.CommandTimeout = A_10;
					oleDbDataAdapter.FillLoadOption = LoadOption.PreserveChanges;
					dataTable.TableName = A_2;
					oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
					if (A_8 != null && A_8.Type == UserTypeEnum.Developer && O_O0OO.o00.0.(A_11))
					{
						if (Operators.CompareString(A_5, "", true) == 0)
						{
						}
					}
					else
					{
						oleDbDataAdapter.Fill(dataTable);
					}
					if (Operators.CompareString(A_5, "", true) > 0)
					{
						o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
						if (Operators.CompareString(A_5, O00OOOo_O0_O.b("헩", a_), true) == 0)
						{
							A_5 = oleDbDataAdapter.UpdateCommand.CommandText.Split(new char[]
							{
								' '
							}, StringSplitOptions.RemoveEmptyEntries)[1].Trim(new char[]
							{
								'[',
								']',
								'"'
							});
						}
					}
				}
				else
				{
					dataTable = A_13.GetBaseDataTable();
					dataTable.TableName = A_2;
					if (Operators.CompareString(A_5, O00OOOo_O0_O.b("헩", a_), true) == 0)
					{
						A_5 = Oo00.o_OoO._0_00.(A_1);
					}
				}
				if (dataTable.PrimaryKey.Length == 0 & Operators.CompareString(A_5, "", true) > 0)
				{
					try
					{
						foreach (object obj in dataTable.Columns)
						{
							DataColumn dataColumn = (DataColumn)obj;
							if (Operators.CompareString(dataColumn.ColumnName, O00OOOo_O0_O.b("뗩ꗫ諭闯鳱胳鿵黷菹", a_), true) == 0)
							{
								dataTable.PrimaryKey = new DataColumn[]
								{
									dataColumn
								};
								dataColumn.AutoIncrement = true;
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
				}
				if (dataTable.PrimaryKey.Length == 1 && dataTable.PrimaryKey[0].AutoIncrement)
				{
					dataTable.PrimaryKey[0].ReadOnly = false;
				}
				if (dataTable.PrimaryKey.Length == 1 && Operators.CompareString(dataTable.PrimaryKey[0].ColumnName, O00OOOo_O0_O.b("뗩ꗫ諭闯鳱胳鿵黷菹", a_), true) == 0 && !dataTable.PrimaryKey[0].AutoIncrement)
				{
					dataTable.Columns[O00OOOo_O0_O.b("뗩ꗫ諭闯鳱胳鿵黷菹", a_)].AutoIncrement = true;
					dataTable.Columns[O00OOOo_O0_O.b("뗩ꗫ諭闯鳱胳鿵黷菹", a_)].AutoIncrementStep = 1L;
					dataTable.Columns[O00OOOo_O0_O.b("뗩ꗫ諭闯鳱胳鿵黷菹", a_)].AutoIncrementSeed = 1L;
					if (dataTable.Rows.Count > 0 && dataTable.Rows.Count > 0)
					{
						dataTable.Columns[O00OOOo_O0_O.b("뗩ꗫ諭闯鳱胳鿵黷菹", a_)].AutoIncrementSeed = (long)(Conversions.ToInteger(dataTable.Compute(O00OOOo_O0_O.b("꟩跫雭\ud8ef꧱꯳뿵鳷鿹鋻諽槿搁紃嬅ℇ", a_), "")) + 1);
					}
				}
				try
				{
					foreach (object obj2 in dataTable.Columns)
					{
						DataColumn dataColumn2 = (DataColumn)obj2;
						if (dataColumn2.ColumnName.StartsWith(O00OOOo_O0_O.b("铩룫ꏭꃯ뇱룳꛵", a_)))
						{
							dataColumn2.Caption = dataColumn2.ColumnName.Substring(7);
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
				A_3.Tables.Add(dataTable);
				A_4.OO0o00.0O_0o.(new DataTable(dataTable, oleDbDataAdapter, A_0, A_5, A_9, A_13));
				A_4[A_2].ConnectionName = A_12;
				if (A_13 != null)
				{
					DataTable dataTable2 = A_4[A_2];
					dataTable2.DataServer = A_13.Oo_0oO0Oo0_.O_.;
					dataTable2.HttpSelect = A_1;
					if (Operators.CompareString(A_5, "", true) > 0)
					{
						dataTable2.UpdateServer = A_13.Oo_0oO0Oo0_.O_.;
						dataTable2.UpdateColumns = (List<string>)dataTable2.BaseTable.ExtendedProperties[O00OOOo_O0_O.b("뿩鳫諭釯蛱釳뗵韷雹觻鏽滿焁", a_)];
					}
					else
					{
						dataTable2.AllowEdit = false;
					}
					string a_2 = A_1;
					DataTable dataTable3;
					string a_3 = (dataTable3 = dataTable2).LoadFilter;
					DataTable dataTable4;
					string a_4 = (dataTable4 = dataTable2).LoadTop;
					DataTable dataTable5 = dataTable2;
					DataTable dataTable6 = dataTable2;
					DataTable dataTable7;
					string a_5 = (dataTable7 = dataTable2).LoadOrder;
					Oo00.ooO.ooo.(a_2, ref a_3, ref a_4, ref dataTable5.o0_oO00.0oO_., ref dataTable6.O0o0__o.0000__., ref a_5);
					dataTable7.LoadOrder = a_5;
					dataTable4.LoadTop = a_4;
					dataTable3.LoadFilter = a_3;
					dataTable2.ooO.oO0O0_oo. = false;
				}
				if (A_6)
				{
					new O_0(O_O0OO.o__.O.(), dataTable);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(O00OOOo_O0_O.b("䪻酤虥틯", a_) + A_2 + O00OOOo_O0_O.b("죩\uddb2쭠ﰐᑺ㊍᝼᮶鎛쓽෿ࠁ", a_) + ex.ToString(), O00OOOo_O0_O.b("͠", a_), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x00217AA4 File Offset: 0x00215CA4
		private static void <<EMPTY_NAME>>(DataSet A_0, DataSet A_1, DataTableCollection A_2)
		{
			try
			{
				foreach (object obj in A_0.Tables[ooO0__OO.o_0_000._O.()].Rows)
				{
					o0OoOOoOOo0.OOOOO.o000.((DataRow)obj, A_0, A_1, A_2, false);
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

		// Token: 0x06004AA3 RID: 19107 RVA: 0x00217B10 File Offset: 0x00215D10
		internal static string <<EMPTY_NAME>>(string A_0 = "")
		{
			if (Operators.CompareString(A_0, "", true) == 0)
			{
				A_0 = OO_00oOO.ProjectFile;
			}
			return Path.GetFileNameWithoutExtension(A_0);
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x00217B30 File Offset: 0x00215D30
		internal static void <<EMPTY_NAME>>(DataRow A_0, DataSet A_1, DataSet A_2, DataTableCollection A_3, bool A_4)
		{
			int a_ = 17;
			DataTable dataTable = new DataTable();
			dataTable.TableName = Conversions.ToString(A_0[O00OOOo_O0_O.b("뫳韵闷鿹", a_)]);
			dataTable.Columns.Add(O00OOOo_O0_O.b("꯳뿵鳷鿹鋻諽槿搁紃", a_), typeof(int), "");
			dataTable.Columns[O00OOOo_O0_O.b("꯳뿵鳷鿹鋻諽槿搁紃", a_)].AutoIncrement = true;
			dataTable.Columns[O00OOOo_O0_O.b("꯳뿵鳷鿹鋻諽槿搁紃", a_)].AutoIncrementStep = 1L;
			dataTable.PrimaryKey = new DataColumn[]
			{
				dataTable.Columns[O00OOOo_O0_O.b("꯳뿵鳷鿹鋻諽槿搁紃", a_)]
			};
			A_2.Tables.Add(dataTable);
			try
			{
				foreach (object obj in A_1.Tables[ooO0__OO.o0o.o.()].Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (Operators.CompareString(dataTable.TableName, Conversions.ToString(dataRow[O00OOOo_O0_O.b("ꃳ韵髷雹駻", a_)]), true) == 0)
					{
						string text = Conversions.ToString(dataRow[O00OOOo_O0_O.b("럳駵铷迹釻都", a_)]);
						ColumnDataTypeEnum columnDataTypeEnum = (ColumnDataTypeEnum)Conversions.ToInteger(dataRow[O00OOOo_O0_O.b("냳韵賷鯹ꣻ蟽烿朁", a_)]);
						int a_2;
						if (columnDataTypeEnum == ColumnDataTypeEnum.String && !dataRow.IsNull(O00OOOo_O0_O.b("맳韵胷雹駻都柿瘁氃", a_)))
						{
							a_2 = Conversions.ToInteger(dataRow[O00OOOo_O0_O.b("맳韵胷雹駻都柿瘁氃", a_)]);
						}
						else
						{
							a_2 = -1;
						}
						if (dataTable.Columns.Contains(text))
						{
							dataRow.Delete();
						}
						else
						{
							o0OoOOoOOo0.O0OoO_0o.O.(dataTable, text, columnDataTypeEnum, string.Empty, a_2);
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
			int num = 0;
			do
			{
				DataRow row = dataTable.NewRow();
				dataTable.Rows.Add(row);
				num++;
			}
			while (num <= 9);
			A_3.OO0o00.0O_0o.(new DataTable(dataTable, null, null, "", A_1));
			if (A_4)
			{
				new O_0(O_O0OO.o__.O.(), dataTable);
			}
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x00217D84 File Offset: 0x00215F84
		internal static void <<EMPTY_NAME>>(DataTable A_0, string A_1, ColumnDataTypeEnum A_2, string A_3, int A_4)
		{
			Type type = Oo00.OO.0O0o.(A_2);
			try
			{
				DataColumn dataColumn = new DataColumn(A_1, type);
				if (type == typeof(bool))
				{
					dataColumn.DefaultValue = false;
				}
				A_0.Columns.Add(dataColumn);
				if (Operators.CompareString(A_3, "", true) > 0)
				{
					dataColumn.Expression = A_3;
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			if (A_2 == ColumnDataTypeEnum.String)
			{
				A_0.Columns[A_1].MaxLength = A_4;
			}
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x00217E24 File Offset: 0x00216024
		private static void <<EMPTY_NAME>>(DataSet A_0, DataTableCollection A_1, DataSet A_2)
		{
			int a_ = 13;
			try
			{
				foreach (object obj in A_0.Tables[ooO0__OO.o0o.o.()].Rows)
				{
					DataRow dataRow = (DataRow)obj;
					string text = Conversions.ToString(dataRow[O00OOOo_O0_O.b("ꓯ鏱雳髵鷷", a_)]);
					if (A_1.Contains(text) && !A_1[text].frd_IsTemporary)
					{
						string text2 = Conversions.ToString(dataRow[O00OOOo_O0_O.b("돯鷱飳菵闷铹", a_)]);
						ColumnDataTypeEnum columnDataTypeEnum = (ColumnDataTypeEnum)Conversions.ToInteger(dataRow[O00OOOo_O0_O.b("듯鏱胳韵곷菹賻鯽", a_)]);
						int a_2;
						if (columnDataTypeEnum == ColumnDataTypeEnum.String && !dataRow.IsNull(O00OOOo_O0_O.b("뷯鏱賳髵鷷铹鯻諽棿", a_)))
						{
							a_2 = Conversions.ToInteger(dataRow[O00OOOo_O0_O.b("뷯鏱賳髵鷷铹鯻諽棿", a_)]);
						}
						else
						{
							a_2 = -1;
						}
						if (A_2.Tables[text].Columns.Contains(text2))
						{
							dataRow.Delete();
						}
						else if (A_2.Tables.Contains(text))
						{
							o0OoOOoOOo0.O0OoO_0o.O.(A_2.Tables[text], text2, columnDataTypeEnum, string.Empty, a_2);
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

		// Token: 0x06004AA7 RID: 19111 RVA: 0x00217FA0 File Offset: 0x002161A0
		private static void <<EMPTY_NAME>>(DataSet A_0, DataTableCollection A_1, DataSet A_2)
		{
			int a_ = 18;
			foreach (DataRow dataRow in A_0.Tables[ooO0__OO.o0o.o.()].Select("", "", DataViewRowState.CurrentRows))
			{
				string text = Conversions.ToString(dataRow[O00OOOo_O0_O.b("ꇴ零鯸韺飼", a_)]);
				if (A_1.Contains(text))
				{
					string text2 = Conversions.ToString(dataRow[O00OOOo_O0_O.b("뛴飶闸軺郼釾", a_)]);
					string text3 = Conversions.ToString(dataRow[O00OOOo_O0_O.b("냴迶觸觺飼賾爀樂樄椆", a_)]);
					if (Operators.CompareString(text3, "", true) == 0)
					{
						text3 = string.Empty;
					}
					if (A_1.Contains(text))
					{
						try
						{
							A_1[text].BaseTable.Columns[text2].Expression = text3;
						}
						catch (Exception a_2)
						{
							MessageBox.Show(string.Concat(new string[]
							{
								O00OOOo_O0_O.b("ᖑ⊚ﾤꃺ", a_),
								text,
								O00OOOo_O0_O.b("ꣴ齾綎ꃺ", a_),
								text2,
								O00OOOo_O0_O.b("ꣴ綎鍲䍳뾋浽㽊㴆ЈĊ", a_),
								text3,
								O00OOOo_O0_O.b("ﷶ管枝鎄斥榈붍ਜ਼\ude66ᒙᷯݜ흇ᥘ즗象饪ᭊ㙲Ꝕ⡰흟䕒쵉삥㷏邢絺삽縷\ude5d㥨⡬씶㌧⬧㰺숟搬欘Ⱕ㼨徭\ude1b픏댋刽ⴹ挎瘲⸀飤ꔵ朦쬸汜ꀿ灀⬼瑄Ꮰ〃ଟᬧ꿱᛻艽", a_)
							}), O00OOOo_O0_O.b("▗춏", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
							ooO.oOo0Oo.o.(a_2, "");
						}
					}
				}
			}
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x00218134 File Offset: 0x00216334
		private static void <<EMPTY_NAME>>(DataSet A_0, DataSet A_1)
		{
			try
			{
				foreach (object obj in A_0.Tables[ooO0__OO.O0.ooO0O.()].Rows)
				{
					o0OoOOoOOo0.OO0._Oo0o.((DataRow)obj, A_1);
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

		// Token: 0x06004AA9 RID: 19113 RVA: 0x002181A0 File Offset: 0x002163A0
		internal static void <<EMPTY_NAME>>(DataRow A_0, DataSet A_1)
		{
			int a_ = 4;
			string text = "";
			fxDataRelationProperty fxDataRelationProperty = new fxDataRelationProperty();
			if (A_1.Tables.Contains(Conversions.ToString(A_0[O00OOOo_O0_O.b("럦裨駪裬臮藰ꟲ铴闶闸黺", a_)])) && A_1.Tables.Contains(Conversions.ToString(A_0[O00OOOo_O0_O.b("ꓦ臨苪臬诮ꗰ鋲韴鯶鳸", a_)])))
			{
				try
				{
					if (A_1.Tables.Contains(Conversions.ToString(A_0[O00OOOo_O0_O.b("럦裨駪裬臮藰ꟲ铴闶闸黺", a_)])) && A_1.Tables.Contains(Conversions.ToString(A_0[O00OOOo_O0_O.b("ꓦ臨苪臬诮ꗰ鋲韴鯶鳸", a_)])))
					{
						o_O_o_oOoo__.OOOO_OO._oo.(fxDataRelationProperty, Conversions.ToString(A_0[O00OOOo_O0_O.b("럦鯨蓪鷬諮菰蟲賴", a_)]), '\v');
						text = Conversions.ToString(A_0[O00OOOo_O0_O.b("ꧦ裨蛪裬", a_)]);
						DataTable dataTable = A_1.Tables[Conversions.ToString(A_0[O00OOOo_O0_O.b("럦裨駪裬臮藰ꟲ铴闶闸黺", a_)])];
						DataTable dataTable2 = A_1.Tables[Conversions.ToString(A_0[O00OOOo_O0_O.b("ꓦ臨苪臬诮ꗰ鋲韴鯶鳸", a_)])];
						string[] array = Conversions.ToString(A_0[O00OOOo_O0_O.b("럦裨駪裬臮藰냲髴鯶諸", a_)]).Split(O00OOOo_O0_O.b("", a_).ToCharArray());
						string[] array2 = Conversions.ToString(A_0[O00OOOo_O0_O.b("ꓦ臨苪臬诮닰鳲駴蓶", a_)]).Split(O00OOOo_O0_O.b("", a_).ToCharArray());
						DataColumn[] array3 = new DataColumn[array.Length - 1 + 1];
						DataColumn[] array4 = new DataColumn[array2.Length - 1 + 1];
						int num = array.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							if (!dataTable.Columns.Contains(array[i]) || !dataTable2.Columns.Contains(array2[i]))
							{
								MessageBox.Show(O00OOOo_O0_O.b("쟦ᆴ麽뭮삩홿ퟴ", a_) + text + O00OOOo_O0_O.b("熱榚鲿ꕰ꾭톯ඣꪈ⍐憒۹", a_), O00OOOo_O0_O.b("㞅펑", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								return;
							}
							array3[i] = dataTable.Columns[array[i]];
							array4[i] = dataTable2.Columns[array2[i]];
						}
						O0Oo o0Oo = new O0Oo(text, array3, array4, A_0);
						A_1.Relations.Add(o0Oo);
						o0Oo.o.O0_o.(fxDataRelationProperty.CascadeDelete);
						o0Oo.oo0__.0Oo0o_.(fxDataRelationProperty.CascadeUpdate);
						o0Oo.oo0__.0Oo0o_.(fxDataRelationProperty.RelationTable);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(O00OOOo_O0_O.b("쟦ᆴ麽뭮삩홿ퟴ", a_) + text + O00OOOo_O0_O.b("엦璹ය", a_) + ex.Message, O00OOOo_O0_O.b("㞅펑", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x002184C8 File Offset: 0x002166C8
		internal static void <<EMPTY_NAME>>(Dictionary<string, O_0> A_0, DataSet A_1)
		{
			try
			{
				foreach (object obj in A_1.Tables)
				{
					DataTable dataTable = (DataTable)obj;
					O_0 a_ = new O_0(A_0, dataTable);
					try
					{
						foreach (object obj2 in A_1.Relations)
						{
							O0Oo o0Oo = (O0Oo)obj2;
							if (o0Oo.oo0__.0Oo0o_.() != RelationPathEnum.None)
							{
								if (o0Oo.ParentTable == dataTable)
								{
									o0OoOOoOOo0.o_OOo_0.0O.(A_0, a_, A_1, o0Oo, false);
								}
								else if (o0Oo.oo0__.0Oo0o_.() == RelationPathEnum.Both && o0Oo.ChildTable == dataTable)
								{
									o0OoOOoOOo0.O_0_Oo_00.O.(A_0, a_, A_1, o0Oo, false);
								}
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
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x002185B0 File Offset: 0x002167B0
		internal static void <<EMPTY_NAME>>(Dictionary<string, O_0> A_0, O_0 A_1, DataSet A_2, DataRelation A_3, bool A_4)
		{
			O_0 a_ = new O_0(A_0, A_1, A_3);
			if (A_3.ParentTable != A_3.ChildTable)
			{
				try
				{
					foreach (object obj in A_2.Relations)
					{
						O0Oo o0Oo = (O0Oo)obj;
						if (o0Oo != A_3 && o0Oo.ParentTable != o0Oo.ChildTable && o0Oo.oo0__.0Oo0o_.() != RelationPathEnum.None)
						{
							if (o0Oo.ParentTable == A_3.ChildTable)
							{
								o0OoOOoOOo0.o_OOo_0.0O.(A_0, a_, A_2, o0Oo, true);
							}
							else if (o0Oo.ChildTable == A_3.ChildTable && !A_4 && o0Oo.oo0__.0Oo0o_.() == RelationPathEnum.Both)
							{
								o0OoOOoOOo0.O_0_Oo_00.O.(A_0, a_, A_2, o0Oo, true);
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

		// Token: 0x06004AAC RID: 19116 RVA: 0x0021867C File Offset: 0x0021687C
		internal static void <<EMPTY_NAME>>(Dictionary<string, O_0> A_0, O_0 A_1, DataSet A_2, DataRelation A_3, bool A_4)
		{
			O_0 a_ = new O_0(A_0, A_1, A_3);
			try
			{
				foreach (object obj in A_2.Relations)
				{
					O0Oo o0Oo = (O0Oo)obj;
					if (o0Oo != A_3 && o0Oo.ParentTable != o0Oo.ChildTable && o0Oo.oo0__.0Oo0o_.() != RelationPathEnum.None)
					{
						if (o0Oo.ChildTable == A_3.ParentTable && o0Oo.oo0__.0Oo0o_.() == RelationPathEnum.Both)
						{
							o0OoOOoOOo0.O_0_Oo_00.O.(A_0, a_, A_2, o0Oo, true);
						}
						else if (o0Oo.ParentTable == A_3.ParentTable && !A_4)
						{
							o0OoOOoOOo0.o_OOo_0.0O.(A_0, a_, A_2, o0Oo, true);
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

		// Token: 0x06004AAD RID: 19117 RVA: 0x00218734 File Offset: 0x00216934
		internal static bool <<EMPTY_NAME>>(string A_0)
		{
			int a_ = 5;
			try
			{
				Catalog catalog = new CatalogClass();
				string text = Guid.NewGuid().ToString();
				if (Foxtable.My.c.OOOOO.o.().FileSystem.FileExists(A_0))
				{
					Foxtable.My.c.OOOOO.o.().FileSystem.DeleteFile(A_0);
				}
				catalog.Create(Oo00.o00.0OO.(A_0));
				Table table = new TableClass();
				Index index = new IndexClass();
				table.Name = ooO0__OO.O0.ooO0O.();
				table.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("룧诩黫语黯蛱ꃳ韵髷雹駻", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ苩藫苭铯꛱闳铵铷鿹", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("룧诩黫语黯蛱럳駵铷觹", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ苩藫苭铯뇱鯳髵请", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns.Append(O00OOOo_O0_O.b("룧飩菫黭闯胱胳迵", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns[O00OOOo_O0_O.b("룧诩黫语黯蛱ꃳ韵髷雹駻", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("ꯧ苩藫苭铯꛱闳铵铷鿹", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("룧诩黫语黯蛱럳駵铷觹", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("ꯧ苩藫苭铯뇱鯳髵请", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("룧飩菫黭闯胱胳迵", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.o0o.o.();
				table.Columns.Append(O00OOOo_O0_O.b("볧诩軫苭闯", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ藩胫鯭鷯鳱", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("곧诩飫迭ꓯ诱蓳鏵", a_), ADOX.DataTypeEnum.adInteger, 0);
				table.Columns.Append(O00OOOo_O0_O.b("ꗧ诩铫苭闯鳱鏳苵郷", a_), ADOX.DataTypeEnum.adInteger, 0);
				table.Columns.Append(O00OOOo_O0_O.b("귧鋩鳫鳭闯臱蟳鿵韷铹", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns[O00OOOo_O0_O.b("ꗧ诩铫苭闯鳱鏳苵郷", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("귧鋩鳫鳭闯臱蟳鿵韷铹", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("볧诩軫苭闯", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.Columns.Append(O00OOOo_O0_O.b("ꯧ藩胫鯭鷯鳱", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.OOo0._00O_o00.();
				table.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("볧鏩鳫语", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ藩苫裭駯闱", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns[O00OOOo_O0_O.b("ꯧ藩苫裭駯闱", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.Columns.Append(O00OOOo_O0_O.b("볧鏩鳫语", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.o.00_0o0__OoO.();
				table.Columns.Append(O00OOOo_O0_O.b("臧軩", a_), ADOX.DataTypeEnum.adInteger, 0);
				table.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("룧诩飫蛭", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("볧鏩鳫语", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ藩苫裭駯闱", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns.Append(O00OOOo_O0_O.b("鯧飩飫", a_), ADOX.DataTypeEnum.adInteger, 0);
				table.Columns[O00OOOo_O0_O.b("ꯧ藩苫裭駯闱", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("鯧飩飫", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("룧诩飫蛭", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("臧軩", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.O0O.0o0.();
				table.Columns.Append(O00OOOo_O0_O.b("볧诩軫苭闯", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ藩胫鯭鷯鳱", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ藩苫裭駯闱", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ藩裫语", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns[O00OOOo_O0_O.b("ꯧ藩苫裭駯闱", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("ꯧ藩裫语", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("볧诩軫苭闯", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.Columns.Append(O00OOOo_O0_O.b("ꯧ藩胫鯭鷯鳱", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.Oo0o0.oo_0.();
				table.Columns.Append(O00OOOo_O0_O.b("볧诩軫苭闯", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("볧鏩鳫语", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				table.Columns.Append(O00OOOo_O0_O.b("룧飩菫黭闯胱胳迵", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns[O00OOOo_O0_O.b("룧飩菫黭闯胱胳迵", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("볧诩軫苭闯", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.Columns.Append(O00OOOo_O0_O.b("볧鏩鳫语", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.O_O00.0_.();
				table.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("볧鏩鳫语", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ藩苫裭駯闱", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.oo._o.();
				table.Columns.Append(O00OOOo_O0_O.b("ꏧ迩闫", a_), ADOX.DataTypeEnum.adVarWChar, 8);
				table.Columns.Append(O00OOOo_O0_O.b("룧诩黫语黯蛱뿳鏵臷", a_), ADOX.DataTypeEnum.adVarWChar, 8);
				table.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 32);
				table.Columns.Append(O00OOOo_O0_O.b("ꇧ蓩裫语裯", a_), ADOX.DataTypeEnum.adInteger, 0);
				table.Columns.Append(O00OOOo_O0_O.b("볧鏩鳫语", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				table.Columns.Append(O00OOOo_O0_O.b("룧诩苫语", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				table.Columns.Append(O00OOOo_O0_O.b("룧飩菫黭闯胱胳迵", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ藩裫语", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns[O00OOOo_O0_O.b("룧诩黫语黯蛱뿳鏵臷", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("ꛧ诩臫语", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("ꇧ蓩裫语裯", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("룧诩苫语", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("룧飩菫黭闯胱胳迵", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("ꯧ藩裫语", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("ꏧ迩闫", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.O00.O__o.();
				table.Columns.Append(O00OOOo_O0_O.b("볧诩軫苭闯", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("ꇧ軩觫胭蓯鯱鋳迵", a_), ADOX.DataTypeEnum.adInteger, 0);
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("볧诩軫苭闯", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.o0O._ooo_O_.();
				table.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ藩苫胭闯釱胳鿵韷铹꿻諽狿欁樃愅", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns[O00OOOo_O0_O.b("ꯧ藩苫胭闯釱胳鿵韷铹꿻諽狿欁樃愅", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.O0_.OOo0OO.();
				table.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("볧鏩鳫语", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				table.Columns.Append(O00OOOo_O0_O.b("곧诩飫迭ꏯ鷱至蓵鯷鿹", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("룧飩菫黭闯胱胳迵", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns[O00OOOo_O0_O.b("곧诩飫迭ꏯ鷱至蓵鯷鿹", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("룧飩菫黭闯胱胳迵", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.o_0_000._O.();
				table.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				table = new TableClass();
				index = new IndexClass();
				table.Name = ooO0__OO.oo._O.();
				table.Columns.Append(O00OOOo_O0_O.b("ꛧ诩臫语", a_), ADOX.DataTypeEnum.adVarWChar, 32);
				table.Columns.Append(O00OOOo_O0_O.b("볧诩軫苭闯", a_), ADOX.DataTypeEnum.adVarWChar, 64);
				table.Columns.Append(O00OOOo_O0_O.b("ꧧ鿩飫臭뿯英釳飵", a_), ADOX.DataTypeEnum.adBoolean, 0);
				table.Columns.Append(O00OOOo_O0_O.b("ꏧ迩闫", a_), ADOX.DataTypeEnum.adVarWChar, 8);
				table.Columns.Append(O00OOOo_O0_O.b("룧诩黫语黯蛱뿳鏵臷", a_), ADOX.DataTypeEnum.adVarWChar, 8);
				table.Columns.Append(O00OOOo_O0_O.b("룧诩诫语", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				table.Columns.Append(O00OOOo_O0_O.b("볧鏩鳫语", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				table.Columns.Append(O00OOOo_O0_O.b("룧飩菫黭闯胱胳迵", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns.Append(O00OOOo_O0_O.b("ꯧ藩裫语", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns.Append(O00OOOo_O0_O.b("飧黩蓫", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
				table.Columns.Append(O00OOOo_O0_O.b("鯧飩飫", a_), ADOX.DataTypeEnum.adInteger, 0);
				table.Columns[O00OOOo_O0_O.b("볧诩軫苭闯", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("룧飩菫黭闯胱胳迵", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("ꯧ藩裫语", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("룧诩黫语黯蛱뿳鏵臷", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("룧诩诫语", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("飧黩蓫", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				table.Columns[O00OOOo_O0_O.b("鯧飩飫", a_)].Attributes = ColumnAttributesEnum.adColNullable;
				index.Name = O00OOOo_O0_O.b("룧飩藫菭釯胱跳뷵鷷菹", a_);
				index.Columns.Append(O00OOOo_O0_O.b("ꏧ迩闫", a_), ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				catalog.Tables.Append(table);
				_Connection connection = (Connection)catalog.ActiveConnection;
				string commandText = string.Concat(new string[]
				{
					O00OOOo_O0_O.b("ꇧ蓩鿫语苯蛱퓳鿵雷軹鏻\udefd寿", a_),
					ooO0__OO.OOo0._00O_o00.(),
					O00OOOo_O0_O.b("뗧쫩쓫뗭뻯鏱駳鏵ꗷ훹ꟻ꫽秿爁愃嬅␇儉伋愍縏琑紓焕䔗㌙㰛栝䄟両儣䌥嬧ȩଫ縭䈯崱帳匵嬷丹画娽┿ⱁぃ⽅⹇㍉歋才", a_),
					Conversions.ToString(0),
					O00OOOo_O0_O.b("쓧췩", a_),
					text,
					O00OOOo_O0_O.b("쿧쏩", a_)
				});
				object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
				connection.Execute(commandText, out objectValue, -1);
				((Connection)catalog.ActiveConnection).Close();
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
				return false;
			}
			return true;
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x00219A2C File Offset: 0x00217C2C
		internal static void <<EMPTY_NAME>>(string A_0)
		{
			int a_ = 11;
			OO_00oOO.FileSys.CopyFile(A_0, A_0 + O00OOOo_O0_O.b("샭鿯黱郳", a_), true);
			Table table = new TableClass();
			Index index = new IndexClass();
			CatalogClass catalogClass = new CatalogClass();
			Connection connection = new ConnectionClass();
			connection.ConnectionString = Oo00.o_._0OOo.(A_0);
			connection.Open("", "", "", -1);
			((_Catalog)catalogClass).ActiveConnection = connection;
			table = new TableClass();
			index = new IndexClass();
			table.Name = ooO0__OO.o.00_0o0__OoO.();
			table.Columns.Append(O00OOOo_O0_O.b("蟭铯", a_), ADOX.DataTypeEnum.adInteger, 0);
			table.Columns.Append(O00OOOo_O0_O.b("ꃭ釯鿱釳", a_), ADOX.DataTypeEnum.adVarWChar, 64);
			table.Columns.Append(O00OOOo_O0_O.b("뻭釯蛱鳳", a_), ADOX.DataTypeEnum.adVarWChar, 64);
			table.Columns.Append(O00OOOo_O0_O.b("뫭觯英釳", a_), ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
			table.Columns.Append(O00OOOo_O0_O.b("귭鿯鳱鋳鿵鿷", a_), ADOX.DataTypeEnum.adLongVarWChar, 0);
			table.Columns.Append(O00OOOo_O0_O.b("鷭苯蛱", a_), ADOX.DataTypeEnum.adInteger, 0);
			table.Columns[O00OOOo_O0_O.b("귭鿯鳱鋳鿵鿷", a_)].Attributes = ColumnAttributesEnum.adColNullable;
			table.Columns[O00OOOo_O0_O.b("鷭苯蛱", a_)].Attributes = ColumnAttributesEnum.adColNullable;
			table.Columns[O00OOOo_O0_O.b("뻭釯蛱鳳", a_)].Attributes = ColumnAttributesEnum.adColNullable;
			index.Name = O00OOOo_O0_O.b("뻭苯鯱駳韵諷菹럻鯽秿", a_);
			index.Columns.Append(O00OOOo_O0_O.b("蟭铯", a_), ADOX.DataTypeEnum.adVarWChar, 0);
			index.PrimaryKey = true;
			index.Unique = true;
			table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
			((_Catalog)catalogClass).Tables.Append(table);
			connection.Close();
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x00219C30 File Offset: 0x00217E30
		internal static void <<EMPTY_NAME>>(DataSet A_0)
		{
			int a_ = 16;
			int num2;
			int num4;
			object obj;
			try
			{
				IL_09:
				int num = 1;
				DataTable dataTable = A_0.Tables[ooO0__OO.OOo0._00O_o00.()];
				IL_1C:
				num = 2;
				string text = Guid.NewGuid().ToString();
				IL_34:
				num = 3;
				DataRow dataRow = dataTable.Rows.Find(new object[]
				{
					O00OOOo_O0_O.b("ꏲ蟴飶鏸黺黼课䠀朂怄椆紈戊欌瘎", a_),
					o0_O.O_oo00.o0.
				});
				IL_63:
				num = 4;
				dataRow[O00OOOo_O0_O.b("냲髴駶鿸鋺髼", a_)] = text;
				IL_7C:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_83:
				num = 6;
				string text2 = "";
				IL_8C:
				num = 7;
				string text3 = "";
				IL_95:
				num = 8;
				o0OO__.oOO.o_.(ref text2, ref text3);
				IL_A0:
				num = 9;
				dataRow = dataTable.NewRow();
				IL_AB:
				num = 10;
				dataRow[O00OOOo_O0_O.b("뷲铴髶鳸", a_)] = O00OOOo_O0_O.b("ꏲ蟴飶鏸黺黼课䠀朂怄椆紈戊欌瘎", a_);
				IL_D1:
				num = 11;
				dataRow[O00OOOo_O0_O.b("ꟲ賴蟶鳸", a_)] = o0_O.oO_0o__.O0_oo.;
				IL_F0:
				num = 12;
				dataRow[O00OOOo_O0_O.b("냲髴駶鿸鋺髼", a_)] = O00.ooo000o_0.00o0.(text, text2, text3);
				IL_113:
				num = 13;
				dataTable.Rows.Add(dataRow);
				IL_123:
				num = 14;
				dataRow = A_0.Tables[ooO0__OO.OOo0._00O_o00.()].NewRow();
				IL_13D:
				num = 15;
				dataRow[O00OOOo_O0_O.b("뷲铴髶鳸", a_)] = O00OOOo_O0_O.b("럲髴飶黸韺飼", a_);
				IL_163:
				num = 16;
				dataRow[O00OOOo_O0_O.b("ꟲ賴蟶鳸", a_)] = o0_O.o_.oooo0.;
				IL_182:
				num = 17;
				dataRow[O00OOOo_O0_O.b("냲髴駶鿸鋺髼", a_)] = text2 + text3;
				IL_1A3:
				num = 18;
				dataTable.Rows.Add(dataRow);
				IL_1B3:
				num = 19;
				Oo00.o0_o._O_.(dataTable, false);
				IL_1BD:
				goto IL_25F;
				IL_1C2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_220:
				goto IL_254;
				IL_222:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_232:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_222;
			}
			IL_254:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_25F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x00219EC0 File Offset: 0x002180C0
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			int num;
			string result;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = O00.MD5Encrypt(A_0);
				IL_11:
				num2 = 3;
				string text2 = "";
				IL_1A:
				num2 = 4;
				int num3 = 0;
				do
				{
					IL_1F:
					num2 = 5;
					text2 += Conversions.ToString((int)(text[num3] % '\t' + '\u0001'));
					IL_3D:
					num2 = 6;
					num3++;
				}
				while (num3 <= 3);
				IL_4A:
				num2 = 7;
				result = text2;
				IL_4F:
				goto IL_BE;
				IL_51:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_7F:
				goto IL_B3;
				IL_81:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_91:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_81;
			}
			IL_B3:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_BE:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x00219FA4 File Offset: 0x002181A4
		internal static string <<EMPTY_NAME>>(string A_0, string A_1)
		{
			int a_ = 12;
			int num;
			string result;
			int num8;
			object obj;
			try
			{
				IL_09:
				ProjectData.ClearProjectError();
				num = 1;
				IL_10:
				ProjectData.ClearProjectError();
				num = 1;
				IL_17:
				int num2 = 3;
				string text = O00OOOo_O0_O.b("\udeee쇰쇲쇴", a_);
				IL_29:
				num2 = 4;
				string text2 = "";
				IL_32:
				num2 = 5;
				string text3 = "";
				IL_3B:
				num2 = 6;
				string text4 = "";
				IL_44:
				num2 = 7;
				string text5 = "";
				IL_4D:
				num2 = 8;
				string text6 = "";
				IL_56:
				num2 = 9;
				string left = "";
				IL_60:
				num2 = 10;
				string text7 = O00OOOo_O0_O.b("룮듰뇲", a_);
				IL_73:
				num2 = 11;
				text = text.TrimEnd(new char[]
				{
					'.'
				});
				IL_8A:
				num2 = 12;
				if (Versioned.IsNumeric(text))
				{
					goto IL_A9;
				}
				IL_96:
				num2 = 13;
				left = O00OOOo_O0_O.b("\udeee", a_);
				IL_A9:
				num2 = 14;
				if (Conversion.Val(text) != 0.0)
				{
					goto IL_D1;
				}
				IL_BE:
				num2 = 15;
				left = O00OOOo_O0_O.b("问", a_);
				IL_D1:
				num2 = 16;
				if (Operators.CompareString(left, "", true) != 0)
				{
					goto IL_37C;
				}
				IL_E6:
				num2 = 17;
				long num3 = (long)Math.Floor(Conversion.Val(text));
				IL_F8:
				num2 = 18;
				if (text.IndexOf(O00OOOo_O0_O.b("쇮", a_)) < 0)
				{
					goto IL_12A;
				}
				IL_113:
				num2 = 19;
				text2 = text.Substring(text.IndexOf('.') + 1);
				IL_12A:
				num2 = 20;
				if (num3 <= 0L)
				{
					goto IL_2B7;
				}
				IL_136:
				num2 = 21;
				if (num3 != 0L)
				{
					goto IL_155;
				}
				IL_13D:
				num2 = 22;
				left = O00OOOo_O0_O.b("问", a_);
				goto IL_2B7;
				IL_155:
				num2 = 24;
				text = num3.ToString();
				IL_161:
				num2 = 25;
				int num4 = 1;
				do
				{
					IL_167:
					num2 = 26;
					text3 = Strings.Right(text, 4);
					IL_174:
					num2 = 27;
					num3 = long.Parse(text3);
					IL_180:
					num2 = 28;
					text3 = num3.ToString();
					IL_18C:
					num2 = 29;
					if (num4 == 1)
					{
						IL_194:
						num2 = 30;
						text6 = text3;
					}
					else
					{
						IL_1A0:
						num2 = 32;
						if (num3 > 0L)
						{
							IL_1A9:
							num2 = 33;
							text5 = text3 + Conversions.ToString(text7[num4 - 2]);
						}
						IL_1C5:
						num2 = 34;
						if (Operators.CompareString(text6, "", true) > 0)
						{
							IL_1D8:
							num2 = 35;
							if (num3 == 0L || text4.Length < 4 || text3.EndsWith(O00OOOo_O0_O.b("\udfee", a_)))
							{
								IL_200:
								num2 = 36;
								text6 = text5 + O00OOOo_O0_O.b("问", a_) + text6;
							}
							else
							{
								IL_21E:
								num2 = 38;
								text6 = text5 + text6;
							}
						}
						else
						{
							IL_22E:
							num2 = 40;
							text6 = text5;
						}
					}
					IL_235:
					num2 = 41;
					text4 = text3;
					IL_23C:
					num2 = 42;
					if (text.Length <= 4)
					{
						break;
					}
					IL_249:
					num2 = 45;
					text = text.Substring(0, text.Length - 4);
					IL_25F:
					num2 = 46;
					num4++;
				}
				while (num4 <= 4);
				IL_270:
				num2 = 47;
				text6 = text6.Replace(O00OOOo_O0_O.b("问诰", a_), "");
				IL_28F:
				num2 = 48;
				text6 = text6.Replace(O00OOOo_O0_O.b("问诰", a_), O00OOOo_O0_O.b("问", a_));
				IL_2B7:
				num2 = 49;
				if (Operators.CompareString(text2, "", true) <= 0)
				{
					goto IL_375;
				}
				IL_2CD:
				num2 = 50;
				if (Operators.CompareString(text6, "", true) != 0)
				{
					goto IL_2F4;
				}
				IL_2DF:
				num2 = 51;
				text6 = O00OOOo_O0_O.b("问\udff0", a_);
				goto IL_30E;
				IL_2F4:
				num2 = 53;
				text6 += O00OOOo_O0_O.b("鿮", a_);
				IL_30E:
				num2 = 54;
				int num5 = text2.Length - text2.TrimStart(new char[]
				{
					'0'
				}).Length;
				IL_332:
				num2 = 55;
				if (num5 <= 0)
				{
					goto IL_35D;
				}
				IL_33A:
				num2 = 56;
				text6 += O00OOOo_O0_O.b("问", a_).PadLeft(num5, 'z');
				IL_35D:
				num2 = 57;
				text6 += Conversions.ToString(Conversions.ToInteger(text2));
				IL_375:
				num2 = 58;
				left = text6;
				IL_37C:
				num2 = 59;
				string text8 = O00.ooo000o_0.00o0.(A_0, A_1, A_1);
				IL_389:
				num2 = 60;
				text8 = o_o_O0OO_0__.o000oOoo.0.(text8);
				IL_395:
				num2 = 61;
				string text9 = "";
				IL_39F:
				num2 = 62;
				int num6 = 5;
				do
				{
					IL_3A5:
					num2 = 63;
					text9 += Conversions.ToString((int)(text8[num6] % '\t' + '\u0001'));
					IL_3C4:
					num2 = 64;
					num6++;
				}
				while (num6 <= 8);
				IL_3D2:
				num2 = 65;
				result = text9;
				IL_3D8:
				goto IL_532;
				IL_3DD:
				int num7 = num8 + 1;
				num8 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7);
				IL_4F3:
				goto IL_527;
				IL_4F5:
				num8 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_505:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num8 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_4F5;
			}
			IL_527:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_532:
			if (num8 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x0021A508 File Offset: 0x00218708
		internal static bool <<EMPTY_NAME>>()
		{
			bool result;
			try
			{
				int count = PrinterSettings.InstalledPrinters.Count;
				result = true;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x0021A548 File Offset: 0x00218748
		internal static void <<EMPTY_NAME>>()
		{
			int num;
			int num3;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				goto IL_5E;
				IL_09:
				int num2 = num3 + 1;
				num3 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_1F:
				goto IL_53;
				IL_21:
				int num4;
				num3 = num4;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_31:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_21;
			}
			IL_53:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_5E:
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x0021A5CC File Offset: 0x002187CC
		internal static bool <<EMPTY_NAME>>()
		{
			short a_ = 0;
			string text = "";
			return Oo0OO_oo.o_o0oO000.0_.(a_, ref text) == 0;
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x0021A5F0 File Offset: 0x002187F0
		private static string <<EMPTY_NAME>>()
		{
			byte[] array = new byte[37];
			array[0] = 230;
			array[1] = 150;
			array[2] = 135;
			array[3] = 228;
			array[4] = 187;
			array[5] = 182;
			array[6] = 230;
			array[7] = 160;
			array[8] = 188;
			array[9] = 229;
			array[10] = 188;
			array[11] = 143;
			array[12] = 228;
			array[13] = 184;
			array[14] = 141;
			array[15] = 231;
			array[16] = 172;
			array[17] = 166;
			array[18] = 239;
			array[19] = 188;
			array[20] = 140;
			array[21] = 230;
			array[22] = 151;
			array[23] = 160;
			array[24] = 230;
			array[25] = 179;
			array[26] = 149;
			array[27] = 230;
			array[28] = 137;
			array[29] = 147;
			array[30] = 229;
			array[31] = 188;
			array[32] = 128;
			array[33] = 239;
			array[34] = 188;
			array[35] = 129;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x0021A74C File Offset: 0x0021894C
		private static string <<EMPTY_NAME>>()
		{
			byte[] array = new byte[69];
			array[0] = 230;
			array[1] = 150;
			array[2] = 135;
			array[3] = 228;
			array[4] = 187;
			array[5] = 182;
			array[6] = 231;
			array[7] = 137;
			array[8] = 136;
			array[9] = 230;
			array[10] = 156;
			array[11] = 172;
			array[12] = 232;
			array[13] = 191;
			array[14] = 135;
			array[15] = 233;
			array[16] = 171;
			array[17] = 152;
			array[18] = 239;
			array[19] = 188;
			array[20] = 140;
			array[21] = 230;
			array[22] = 151;
			array[23] = 160;
			array[24] = 230;
			array[25] = 179;
			array[26] = 149;
			array[27] = 230;
			array[28] = 173;
			array[29] = 163;
			array[30] = 229;
			array[31] = 184;
			array[32] = 184;
			array[33] = 230;
			array[34] = 137;
			array[35] = 147;
			array[36] = 229;
			array[37] = 188;
			array[38] = 128;
			array[39] = 239;
			array[40] = 188;
			array[41] = 140;
			array[42] = 232;
			array[43] = 175;
			array[44] = 183;
			array[45] = 229;
			array[46] = 141;
			array[47] = 135;
			array[48] = 231;
			array[49] = 186;
			array[50] = 167;
			array[51] = 230;
			array[52] = 130;
			array[53] = 168;
			array[54] = 231;
			array[55] = 154;
			array[56] = 132;
			array[57] = 70;
			array[58] = 111;
			array[59] = 120;
			array[60] = 116;
			array[61] = 97;
			array[62] = 98;
			array[63] = 108;
			array[64] = 101;
			array[65] = 239;
			array[66] = 188;
			array[67] = 129;
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x0021A9B0 File Offset: 0x00218BB0
		internal static string <<EMPTY_NAME>>()
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
				byte[] array = new byte[15];
				IL_12:
				num2 = 3;
				array[0] = 69;
				IL_1A:
				num2 = 4;
				array[1] = 120;
				IL_22:
				num2 = 5;
				array[2] = 101;
				IL_2A:
				num2 = 6;
				array[3] = 99;
				IL_32:
				num2 = 7;
				array[4] = 117;
				IL_3A:
				num2 = 8;
				array[5] = 116;
				IL_42:
				num2 = 9;
				array[6] = 97;
				IL_4B:
				num2 = 10;
				array[7] = 98;
				IL_54:
				num2 = 11;
				array[8] = 108;
				IL_5D:
				num2 = 12;
				array[9] = 101;
				IL_67:
				num2 = 13;
				array[10] = 80;
				IL_71:
				num2 = 14;
				array[11] = 97;
				IL_7B:
				num2 = 15;
				array[12] = 116;
				IL_85:
				num2 = 16;
				array[13] = 104;
				IL_8F:
				num2 = 17;
				string @string = Encoding.ASCII.GetString(array);
				IL_A0:
				num2 = 18;
				result = @string.Substring(0, 14);
				IL_AE:
				goto IL_14C;
				IL_B3:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_10D:
				goto IL_141;
				IL_10F:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_11F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_10F;
			}
			IL_141:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_14C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x0021AB30 File Offset: 0x00218D30
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			int a_ = 9;
			string text = "";
			A_0 = O00.MD5Encrypt(A_0.ToUpper());
			foreach (char c in A_0)
			{
				if (char.IsLetter(c) || char.IsDigit(c))
				{
					text += Conversions.ToString(c);
				}
			}
			return O00OOOo_O0_O.b("귫", a_) + Strings.Left(text, 16);
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x0021ABAC File Offset: 0x00218DAC
		internal static string <<EMPTY_NAME>>()
		{
			int a_ = 4;
			return O00.oO_.0o_oo_0O_.(O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("ꇦ蛨鏪駬軮鏰鿲郴ꓶ鳸迺觼雾漀搂瘄", a_))[O00OOOo_O0_O.b("ꓦ蛨藪诬蛮雰", a_)].ToString(), O00OOOo_O0_O.b("臦蛨鏪駬軮鏰鿲郴", a_), O00OOOo_O0_O.b("듦賨鿪駬蛮鿰铲蛴", a_)).Replace(O00OOOo_O0_O.b("꣦鳨鿪裬鷮뗰鋲致零그髺鿼鏾搀䴂搄樆氈", a_), O00OOOo_O0_O.b("엦", a_) + ooO0__OO.O0_.OOo0OO.() + O00OOOo_O0_O.b("엦", a_));
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x0021AC54 File Offset: 0x00218E54
		private static bool <<EMPTY_NAME>>(object A_0, string A_1)
		{
			int a_ = 7;
			if (A_0 == null)
			{
				throw new ArgumentNullException(O00OOOo_O0_O.b("藩軫蓭", a_));
			}
			if (string.IsNullOrEmpty(A_1))
			{
				throw new ArgumentNullException(O00OOOo_O0_O.b("迩髫语黯蛱뫳韵闷鿹", a_));
			}
			Type type = A_0.GetType();
			if (type.GetEvent(A_1, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic) == null)
			{
				throw new Exception();
			}
			FieldInfo fieldInfo = type.GetField(A_1, BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
			if (fieldInfo == null)
			{
				fieldInfo = type.GetField(string.Format(O00OOOo_O0_O.b("훩韫\udeed路쳱", a_), A_1), BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
				if (fieldInfo == null)
				{
					foreach (FieldInfo fieldInfo2 in type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic))
					{
						if (fieldInfo2.Name.Contains(A_1) && fieldInfo2.FieldType.IsSubclassOf(typeof(MulticastDelegate)))
						{
							fieldInfo = fieldInfo2;
							break;
						}
					}
					if (fieldInfo == null)
					{
						throw new Exception();
					}
				}
			}
			Delegate @delegate = fieldInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0)) as Delegate;
			if (@delegate != null)
			{
				foreach (Delegate delegate2 in @delegate.GetInvocationList())
				{
				}
			}
			return @delegate != null;
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x0021AD74 File Offset: 0x00218F74
		internal static void <<EMPTY_NAME>>()
		{
			int a_ = 19;
			if (o0OoOOoOOo0.o00__oo.O0Oo0o. != null)
			{
				if (o0OoOOoOOo0.O_0_Oo_00.O.(RuntimeHelpers.GetObjectValue(o0OoOOoOOo0.o00__oo.O0Oo0o.), O00.oO_.0o_oo_0O_.(o0OoOOoOOo0.Oo0.OooO00., O00OOOo_O0_O.b("꛵諷闹電鯽揿瘁", a_), O00OOOo_O0_O.b("ꏵ请鿹軻뷽濿昁愃", a_))))
				{
					SQLCommand sqlcommand = new SQLCommand();
					sqlcommand.CommandText = string.Concat(new string[]
					{
						O00OOOo_O0_O.b("뿵雷觹駻賽瓿∁䴃栅簇攉Ⰻ唍", a_),
						ooO0__OO.oo._O.(),
						O00OOOo_O0_O.b("꯵\ud8f7틹ꟻ냽懿漁愃嬅␇儉堋眍怏眑䤓㨕䌗儙礛朝紟ม缣瘥䤧堩䤫䀭䐯礱儳伵攷ጹ᰻栽ℿ⹁ㅃ⍅㭇扉歋͍ㅏ㭑㩓ၕ㝗⡙ㅛ祝䱟", a_),
						Conversions.ToString(228),
						O00OOOo_O0_O.b("\udaf5\udff7", a_),
						OoOo0O.OO_o.0o_O.(8),
						O00OOOo_O0_O.b("퇵퓷\uddf9", a_),
						OoOo0O.OO_o.0o_O.(8),
						O00OOOo_O0_O.b("퇵퇷", a_)
					});
					try
					{
						sqlcommand.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
					}
				}
				o0OoOOoOOo0.o00__oo.O0Oo0o. = null;
			}
		}

		// Token: 0x04001E3F RID: 7743
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x04001E40 RID: 7744
		internal const double <<EMPTY_NAME>> = 80.0;

		// Token: 0x04001E41 RID: 7745
		internal const string <<EMPTY_NAME>> = "_SortKey";

		// Token: 0x04001E42 RID: 7746
		internal const string <<EMPTY_NAME>> = "System_Sort_Temporary";

		// Token: 0x04001E43 RID: 7747
		internal const string <<EMPTY_NAME>> = "_Identify";

		// Token: 0x04001E44 RID: 7748
		internal const string <<EMPTY_NAME>> = "System_Filter_Unique";

		// Token: 0x04001E45 RID: 7749
		internal const string <<EMPTY_NAME>> = "_Locked";

		// Token: 0x04001E46 RID: 7750
		internal const string <<EMPTY_NAME>> = "System_Filter_Temporary";

		// Token: 0x04001E47 RID: 7751
		internal const string <<EMPTY_NAME>> = "sys_Hierarchy_Level";

		// Token: 0x04001E48 RID: 7752
		internal static string <<EMPTY_NAME>>;

		// Token: 0x04001E49 RID: 7753
		internal static string <<EMPTY_NAME>>;

		// Token: 0x04001E4A RID: 7754
		internal static string <<EMPTY_NAME>>;

		// Token: 0x04001E4B RID: 7755
		internal static string <<EMPTY_NAME>>;

		// Token: 0x04001E4C RID: 7756
		internal static string[] <<EMPTY_NAME>>;

		// Token: 0x04001E4D RID: 7757
		internal static string <<EMPTY_NAME>>;

		// Token: 0x04001E4E RID: 7758
		internal static object[] <<EMPTY_NAME>>;

		// Token: 0x04001E4F RID: 7759
		private static Assembly <<EMPTY_NAME>>;

		// Token: 0x04001E50 RID: 7760
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x04001E51 RID: 7761
		private static string <<EMPTY_NAME>>;

		// Token: 0x04001E52 RID: 7762
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x04001E53 RID: 7763
		private static string <<EMPTY_NAME>>;

		// Token: 0x04001E54 RID: 7764
		internal static string <<EMPTY_NAME>>;

		// Token: 0x04001E55 RID: 7765
		internal static object <<EMPTY_NAME>>;

		// Token: 0x02000457 RID: 1111
		internal class Oo000OOooOO0O
		{
			// Token: 0x06004ABC RID: 19132 RVA: 0x0021AE90 File Offset: 0x00219090
			public Oo000OOooOO0O()
			{
				this.O__0oO._. = Oo00.O_.0_0__o0.();
				this.O.O__0. = this.O__0oO._..Substring(12, 8);
				this.o.O_OOO_O0_o. = this.O__0oO._..Substring(8, 4);
				this.Oo_0o0.__000. = Oo00.O_00O_o.0o_.();
				this.O_0_o_O.O000. = "";
			}

			// Token: 0x06004ABD RID: 19133 RVA: 0x0021AEEC File Offset: 0x002190EC
			internal bool <<EMPTY_NAME>>()
			{
				int num;
				bool result;
				int num6;
				object obj;
				try
				{
					IL_00:
					ProjectData.ClearProjectError();
					num = 1;
					IL_07:
					int num2 = 2;
					if (Operators.CompareString(this.Oo_0o0.__000., "", true) != 0)
					{
						goto IL_25;
					}
					IL_1C:
					num2 = 3;
					result = false;
					goto IL_26C;
					IL_25:
					num2 = 4;
					string oo_0o0.__000. = this.Oo_0o0.__000.;
					IL_2F:
					num2 = 5;
					this.Oo_0o0.__000. = this.Oo_0o0.__000..Substring(12, 8);
					IL_45:
					num2 = 6;
					int.TryParse(this.O.O__0., out this.oOO_0.OO_0.);
					IL_59:
					num2 = 7;
					int.TryParse(this.o.O_OOO_O0_o., out this.o.O_OOO_O0_o.);
					IL_6D:
					num2 = 8;
					if (this.o.O_OOO_O0_o. != 0)
					{
						goto IL_82;
					}
					IL_77:
					num2 = 9;
					this.o.O_OOO_O0_o. = 17;
					IL_82:
					num2 = 10;
					this.O00O0o_o._o___. = this.O__0oO._.(this.oOO_0.OO_0., this.o.O_OOO_O0_o.);
					IL_9D:
					num2 = 11;
					this.O.O__0. = O00.EncryptText(this.O00O0o_o._o___., "my", "home");
					IL_BB:
					num2 = 12;
					this.OO_.000. = o0OO__.O.0ooOoO_0_.(this.O.O__0.);
					IL_CF:
					num2 = 13;
					this.O.O__0. = o_O_o_oOoo__.OOOO_OO._oo.(O00.MD5Encrypt(this.OO_.000.).Trim(new char[]
					{
						'='
					}));
					IL_F8:
					num2 = 14;
					this.O_0_o_O.O000. = "";
					IL_106:
					num2 = 15;
					int num3 = 0;
					do
					{
						IL_10C:
						num2 = 16;
						this.O_0_o_O.O000. += Conversions.ToString((int)(this.O.O__0.[num3] % '\t' + '\u0001'));
						IL_137:
						num2 = 17;
						num3++;
					}
					while (num3 <= 7);
					IL_145:
					num2 = 18;
					this.o00.0oooO_. = this.O__0oO._.(Conversions.ToInteger(this.O_0_o_O.O000.));
					IL_15F:
					num2 = 19;
					string a_ = O00.ooo000o_0.00o0.(this.o00.0oooO_., oo_0o0.__000..Substring(4, 4), oo_0o0.__000..Substring(8, 4));
					IL_181:
					num2 = 20;
					this.O.O__0. = o_o_O0OO_0__.o000oOoo.0.(a_);
					IL_191:
					num2 = 21;
					this.O_0_o_O.O000. = "";
					IL_19F:
					num2 = 22;
					int num4 = 0;
					do
					{
						IL_1A5:
						num2 = 23;
						this.O_0_o_O.O000. += Conversions.ToString((int)(this.O.O__0.[num4] % '\t' + '\u0001'));
						IL_1D0:
						num2 = 24;
						num4++;
					}
					while (num4 <= 7);
					IL_1DE:
					num2 = 25;
					int.TryParse(this.O_0_o_O.O000., out this.oOO_0.OO_0.);
					IL_1F3:
					num2 = 26;
					int.TryParse(this.Oo_0o0.__000., out this.O.O__0.);
					IL_208:
					num2 = 27;
					if (Operators.CompareString(O00.MD5Encrypt((this.oOO_0.OO_0. + this.O.O__0.).ToString()), o0OoOOoOOo0.O_00ooOo._.(), true) != 0 && Operators.CompareString(O00.MD5Encrypt(Math.Abs(this.oOO_0.OO_0. - this.O.O__0.).ToString()), o0OoOOoOOo0.O_00ooOo._.(), true) != 0)
					{
						goto IL_267;
					}
					IL_260:
					num2 = 28;
					result = true;
					goto IL_26C;
					IL_267:
					num2 = 30;
					result = false;
					IL_26C:
					goto IL_33A;
					IL_271:
					int num5 = num6 + 1;
					num6 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
					IL_2FB:
					goto IL_32F;
					IL_2FD:
					num6 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_30D:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_2FD;
				}
				IL_32F:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_33A:
				if (num6 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x06004ABE RID: 19134 RVA: 0x0021B258 File Offset: 0x00219458
			private string <<EMPTY_NAME>>(int A_0, int A_1)
			{
				int num;
				string result;
				int num6;
				object obj;
				try
				{
					IL_00:
					ProjectData.ClearProjectError();
					num = 1;
					IL_07:
					int num2 = 2;
					string text = "";
					IL_10:
					num2 = 3;
					A_0 += 1111;
					IL_1B:
					num2 = 4;
					if (A_0 % A_1 != 0)
					{
						goto IL_29;
					}
					IL_22:
					num2 = 5;
					A_0 += 7;
					IL_29:
					num2 = 6;
					int num3 = 1;
					do
					{
						IL_2E:
						num2 = 7;
						int num4 = A_0 / A_1;
						IL_35:
						num2 = 8;
						text += Conversions.ToString(num4);
						IL_47:
						num2 = 9;
						A_0 = (A_0 - A_1 * num4) * 10;
						IL_55:
						num2 = 10;
						num3++;
					}
					while (num3 <= 1000);
					IL_67:
					num2 = 11;
					text = text.Trim(new char[]
					{
						'0'
					});
					IL_7E:
					num2 = 12;
					if (text.Length > 8)
					{
						goto IL_94;
					}
					IL_8B:
					num2 = 13;
					string text2 = text;
					goto IL_AA;
					IL_94:
					num2 = 15;
					text2 = text.Substring(text.Length - 8, 8);
					IL_AA:
					num2 = 16;
					result = text2;
					IL_B0:
					goto IL_146;
					IL_B5:
					int num5 = num6 + 1;
					num6 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
					IL_107:
					goto IL_13B;
					IL_109:
					num6 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_119:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_109;
				}
				IL_13B:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_146:
				if (num6 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x06004ABF RID: 19135 RVA: 0x0021B3D0 File Offset: 0x002195D0
			private string <<EMPTY_NAME>>(int A_0)
			{
				int num;
				string result;
				int num5;
				object obj;
				try
				{
					IL_00:
					ProjectData.ClearProjectError();
					num = 1;
					IL_07:
					int num2 = 2;
					string text = "";
					IL_10:
					num2 = 3;
					string text2 = "lyeshwiqbjs";
					IL_19:
					num2 = 4;
					DateTime dateTime = new DateTime(598950720000000000L).AddDays((double)(A_0 % 9999));
					IL_3C:
					num2 = 5;
					int year = dateTime.Year;
					IL_47:
					num2 = 6;
					int month = dateTime.Month;
					IL_52:
					num2 = 7;
					int day = dateTime.Day;
					IL_5D:
					num2 = 8;
					string text3 = year.ToString();
					IL_68:
					num2 = 9;
					string text4 = "";
					IL_72:
					num2 = 10;
					string str = "";
					IL_7C:
					num2 = 11;
					string str2 = "";
					IL_86:
					num2 = 12;
					int num3 = text3.Length - 1;
					for (int i = 0; i <= num3; i++)
					{
						IL_99:
						num2 = 13;
						text4 += Conversions.ToString(text2[int.Parse(Conversions.ToString(text3[i]))]);
						IL_C4:
						num2 = 14;
					}
					IL_D3:
					num2 = 15;
					if (month >= 10)
					{
						goto IL_FB;
					}
					IL_DC:
					num2 = 16;
					str = "ling" + Conversions.ToString(text2[month]);
					goto IL_130;
					IL_FB:
					num2 = 18;
					if (month != 10)
					{
						goto IL_110;
					}
					IL_104:
					num2 = 19;
					str = "yishi";
					goto IL_130;
					IL_110:
					num2 = 21;
					str = "yishi" + Conversions.ToString(text2[month % 10]);
					IL_130:
					num2 = 22;
					if (day >= 10)
					{
						goto IL_158;
					}
					IL_139:
					num2 = 23;
					str2 = "ling" + Conversions.ToString(text2[day]);
					goto IL_1C4;
					IL_158:
					num2 = 25;
					if (day >= 10)
					{
						goto IL_180;
					}
					IL_161:
					num2 = 26;
					str2 = "ling" + Conversions.ToString(text2[10]);
					goto IL_1C4;
					IL_180:
					num2 = 28;
					str2 = Strings.Mid(text2, day / 10 + 1, 1) + "shi";
					IL_19E:
					num2 = 29;
					if (day % 10 <= 0)
					{
						goto IL_1C4;
					}
					IL_1A9:
					num2 = 30;
					str2 += Strings.Mid(text2, day % 10 + 1, 1);
					IL_1C4:
					num2 = 31;
					foreach (byte b in Encoding.Unicode.GetBytes(str2 + text4 + str))
					{
						IL_1EA:
						num2 = 32;
						text += b.ToString();
						IL_1FD:
						num2 = 33;
					}
					IL_20E:
					num2 = 34;
					result = text;
					IL_214:
					goto IL_2F2;
					IL_219:
					int num4 = num5 + 1;
					num5 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
					IL_2B3:
					goto IL_2E7;
					IL_2B5:
					num5 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_2C5:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_2B5;
				}
				IL_2E7:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_2F2:
				if (num5 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x04001E56 RID: 7766
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E57 RID: 7767
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E58 RID: 7768
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E59 RID: 7769
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E5A RID: 7770
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E5B RID: 7771
			private int <<EMPTY_NAME>>;

			// Token: 0x04001E5C RID: 7772
			private int <<EMPTY_NAME>>;

			// Token: 0x04001E5D RID: 7773
			private int <<EMPTY_NAME>>;

			// Token: 0x04001E5E RID: 7774
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E5F RID: 7775
			private string <<EMPTY_NAME>>;

			// Token: 0x04001E60 RID: 7776
			private string <<EMPTY_NAME>>;
		}
	}
}
