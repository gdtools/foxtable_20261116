using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Foxtable
{
	// Token: 0x020000CC RID: 204
	[StandardModule]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class oOO0oO000_0_0
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x0004AD40 File Offset: 0x00048F40
		internal static bool <<EMPTY_NAME>>(DataTable A_0, params DataRow[] A_1)
		{
			List<string> list = A_0.UpdateColumns;
			new bool[A_1.Length - 1 + 1];
			string text = null;
			string text2 = "\v\t";
			HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[A_0.ConnectionName].oO0_0.o.();
			string text3 = Oo00.o_OoO._0_00.(A_0.HttpSelect).Trim();
			if (text3.StartsWith("("))
			{
				text3 = Oo00.oo_0__0.o.(text3);
			}
			Dictionary<string, string> dictionary = httpClient.FormData;
			string key = "Action";
			int num = 4;
			dictionary.Add(key, num.ToString());
			httpClient.FormData["DataTable"] = text3;
			bool flag;
			if (A_0.BaseTable.PrimaryKey.Length == 1 && A_0.BaseTable.PrimaryKey[0].AutoIncrement)
			{
				flag = true;
				text = A_0.BaseTable.PrimaryKey[0].ColumnName;
				httpClient.FormData.Add("AutoIncrement", A_0.BaseTable.PrimaryKey[0].ColumnName);
			}
			num = A_1.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = A_1[i];
				string text4 = null;
				string text5 = "";
				try
				{
					foreach (object obj in dataRow.Table.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj;
						if ((!flag || Operators.CompareString(dataColumn.ColumnName, text, true) != 0) && list.Contains(dataColumn.ColumnName.ToLower()))
						{
							string text6 = oOO0oO000_0_0.OO.OoO0.(dataColumn.DataType);
							if (Operators.CompareString(text5, "", true) == 0)
							{
								text5 = dataColumn.ColumnName + text2 + text6 + "{{null}}";
							}
							if (!dataRow.IsNull(dataColumn))
							{
								string text7;
								if (dataColumn.DataType == typeof(DateTime))
								{
									text7 = text6 + Conversions.ToString(Conversions.ToDate(dataRow[dataColumn]).ToBinary());
								}
								else
								{
									text7 = text6 + dataRow[dataColumn].ToString();
								}
								text4 = string.Concat(new string[]
								{
									text4,
									Interaction.IIf(Operators.CompareString(text4, "", true) > 0, text2, "").ToString(),
									dataColumn.ColumnName,
									text2,
									text7.Replace(text2, "")
								});
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
				if (Operators.CompareString(text4, "", true) > 0)
				{
					httpClient.FormData.Add("[[Row" + Conversions.ToString(i) + "]]", O00.ooo000o_0.00o0.(text4, "fox", "table"));
				}
				else
				{
					httpClient.FormData.Add("[[Row" + Conversions.ToString(i) + "]]", O00.ooo000o_0.00o0.(text5, "fox", "table"));
				}
			}
			bool result;
			try
			{
				string data = httpClient.GetData(true);
				if (httpClient.RCookies.ContainsKey("Error"))
				{
					throw new Exception(httpClient.RCookies["Error"]);
				}
				if (Operators.CompareString(data, "", true) <= 0)
				{
					throw new Exception("未知HttpInsert错误");
				}
				string[] array = data.Split(new char[]
				{
					'|'
				});
				int num2 = array.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (!Versioned.IsNumeric(array[j]))
					{
						throw new Exception("HttpInsert错误(" + array[j] + ")");
					}
					if (flag)
					{
						A_1[j][text] = Conversions.ToInteger(array[j]);
					}
					else if (Conversions.ToInteger(array[j]) != 1)
					{
						throw new Exception("HttpInsert错误(" + array[j] + ")");
					}
					A_1[j].AcceptChanges();
					oOO0oO000_0_0.o.oOoO___o__oO.(A_0, A_1[j], 0, 1);
				}
				result = (array.Length == A_1.Length);
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			return result;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0004B1A4 File Offset: 0x000493A4
		internal static bool <<EMPTY_NAME>>(DataTable A_0, params DataRow[] A_1)
		{
			List<string> list = A_0.UpdateColumns;
			new bool[A_1.Length - 1 + 1];
			string text = "\v\t";
			string text2 = "\t\v";
			HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[A_0.ConnectionName].oO0_0.o.();
			string text3 = Oo00.o_OoO._0_00.(A_0.HttpSelect).Trim();
			if (text3.StartsWith("("))
			{
				text3 = Oo00.oo_0__0.o.(text3);
			}
			Dictionary<string, string> dictionary = httpClient.FormData;
			string key = "Action";
			int num = 3;
			dictionary.Add(key, num.ToString());
			httpClient.FormData["DataTable"] = text3;
			int num2 = 0;
			num = A_1.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = A_1[i];
				string text4 = null;
				string text5 = null;
				try
				{
					foreach (object obj in dataRow.Table.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj;
						if (list.Contains(dataColumn.ColumnName.ToLower()))
						{
							string str = oOO0oO000_0_0.OO.OoO0.(dataColumn.DataType);
							string text6 = "";
							if (dataRow.IsNull(dataColumn))
							{
								if (!dataRow.IsNull(dataColumn, DataRowVersion.Original))
								{
									text6 = str + "{{null}}";
								}
							}
							else if (Operators.CompareString(dataRow[dataColumn].ToString(), dataRow[dataColumn, DataRowVersion.Original].ToString(), true) != 0)
							{
								if (dataColumn.DataType == typeof(DateTime))
								{
									text6 = str + Conversions.ToDate(dataRow[dataColumn]).ToBinary().ToString();
								}
								else
								{
									text6 = str + dataRow[dataColumn].ToString();
								}
							}
							if (Operators.CompareString(text6, "", true) > 0)
							{
								text4 = string.Concat(new string[]
								{
									text4,
									Interaction.IIf(Operators.CompareString(text4, "", true) > 0, text, "").ToString(),
									dataColumn.ColumnName,
									text,
									text6.Replace(text, "").Replace(text2, "")
								});
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
				if (Operators.CompareString(text4, "", true) > 0)
				{
					num2++;
					foreach (DataColumn dataColumn2 in dataRow.Table.PrimaryKey)
					{
						if (list.Contains(dataColumn2.ColumnName.ToLower()))
						{
							string str2 = oOO0oO000_0_0.OO.OoO0.(dataColumn2.DataType);
							string text7;
							if (dataRow.IsNull(dataColumn2, DataRowVersion.Original))
							{
								text7 = str2 + "{{null}}";
							}
							else if (dataColumn2.DataType == typeof(DateTime))
							{
								text7 = str2 + Conversions.ToDate(dataRow[dataColumn2, DataRowVersion.Original]).ToBinary().ToString();
							}
							else
							{
								text7 = str2 + dataRow[dataColumn2, DataRowVersion.Original].ToString();
							}
							text5 = string.Concat(new string[]
							{
								text5,
								Interaction.IIf(Operators.CompareString(text5, "", true) > 0, text, "").ToString(),
								dataColumn2.ColumnName,
								text,
								text7.Replace(text, "").Replace(text2, "")
							});
						}
					}
					text4 = text4 + text2 + text5;
					httpClient.FormData.Add("[[Row" + Conversions.ToString(i) + "]]", O00.ooo000o_0.00o0.(text4, "fox", "table"));
				}
				else
				{
					dataRow.AcceptChanges();
				}
			}
			bool result;
			if (num2 == 0)
			{
				result = true;
			}
			else
			{
				try
				{
					string data = httpClient.GetData(true);
					if (httpClient.RCookies.ContainsKey("Error"))
					{
						throw new Exception(httpClient.RCookies["Error"]);
					}
					if (Operators.CompareString(data, "", true) <= 0)
					{
						throw new Exception("未知HttpUpdate错误");
					}
					string[] array = data.Split(new char[]
					{
						'|'
					});
					int num3 = array.Length - 1;
					for (int k = 0; k <= num3; k++)
					{
						if (Versioned.IsNumeric(array[k]) && Conversions.ToInteger(array[k]) >= 1)
						{
							A_1[k].AcceptChanges();
							oOO0oO000_0_0.o.oOoO___o__oO.(A_0, A_1[k], 1, 1);
						}
						else
						{
							if (Operators.CompareString(array[k], "0", true) != 0)
							{
								throw new Exception("HttpUpdate错误)" + array[k] + ")");
							}
							oOO0oO000_0_0.o.oOoO___o__oO.(A_0, A_1[k], 1, 0);
							A_1[k].Table.Rows.Remove(A_1[k]);
						}
					}
					result = (array.Length == A_1.Length);
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
			}
			return result;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0004B704 File Offset: 0x00049904
		private static void <<EMPTY_NAME>>(DataTable A_0, DataRow A_1, int A_2, int A_3)
		{
			UpdateRowEventArgs updateRowEventArgs = new UpdateRowEventArgs(A_0, new DataRow(A_1), A_2, A_3);
			if (A_0.O_000o_.O. != null && OO_00oOO.SystemReady)
			{
				try
				{
					A_0.O_000o_.O..Invoke(null, new object[]
					{
						updateRowEventArgs
					});
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "表，" + A_0.Name + "，AfterSaveDataRow");
				}
			}
			if (!updateRowEventArgs.Cancel && A_0.GlobalHandler.AfterSaveDataRow && OO_00oOO.SystemReady && O_O0OO.O0_00o.o0__o..Oo.o0_O. != null)
			{
				try
				{
					O_O0OO.O0_00o.o0__o..Oo.o0_O..Invoke(null, new object[]
					{
						updateRowEventArgs
					});
				}
				catch (Exception a_2)
				{
					ooO.oOo0Oo.o.(a_2, "全局表事件, AfterSaveDataRow");
				}
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0004B7EC File Offset: 0x000499EC
		internal static bool <<EMPTY_NAME>>(DataTable A_0, params DataRow[] A_1)
		{
			List<string> list = A_0.UpdateColumns;
			new bool[A_1.Length - 1 + 1];
			string text = "\v\t";
			string oldValue = "\t\v";
			HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[A_0.ConnectionName].oO0_0.o.();
			string text2 = Oo00.o_OoO._0_00.(A_0.HttpSelect).Trim();
			if (text2.StartsWith("("))
			{
				text2 = Oo00.oo_0__0.o.(text2);
			}
			httpClient.FormData.Add("Action", 5.ToString());
			httpClient.FormData["DataTable"] = text2;
			int num = A_1.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = A_1[i];
				string text3 = null;
				foreach (DataColumn dataColumn in dataRow.Table.PrimaryKey)
				{
					if (list.Contains(dataColumn.ColumnName.ToLower()))
					{
						string str = oOO0oO000_0_0.OO.OoO0.(dataColumn.DataType);
						string text4;
						if (dataRow.IsNull(dataColumn, DataRowVersion.Original))
						{
							text4 = str + "{{null}}";
						}
						else if (dataColumn.DataType == typeof(DateTime))
						{
							text4 = str + Conversions.ToDate(dataRow[dataColumn, DataRowVersion.Original]).ToBinary().ToString();
						}
						else
						{
							text4 = str + dataRow[dataColumn, DataRowVersion.Original].ToString();
						}
						text3 = string.Concat(new string[]
						{
							text3,
							Interaction.IIf(Operators.CompareString(text3, "", true) > 0, text, "").ToString(),
							dataColumn.ColumnName,
							text,
							text4.Replace(text, "").Replace(oldValue, "")
						});
					}
				}
				if (Operators.CompareString(text3, "", true) > 0)
				{
					httpClient.FormData.Add("[[Row" + Conversions.ToString(i) + "]]", O00.ooo000o_0.00o0.(text3, "fox", "table"));
				}
			}
			bool result;
			try
			{
				string data = httpClient.GetData(true);
				if (httpClient.RCookies.ContainsKey("Error"))
				{
					throw new Exception(httpClient.RCookies["Error"]);
				}
				if (Operators.CompareString(data, "", true) <= 0)
				{
					throw new Exception("未知HttpDelete错误");
				}
				string[] array = data.Split(new char[]
				{
					'|'
				});
				int num2 = array.Length - 1;
				for (int k = 0; k <= num2; k++)
				{
					if (Operators.CompareString(array[k], "1", true) != 0 && Operators.CompareString(array[k], "0", true) != 0)
					{
						throw new Exception("HttpDelete错误(" + array[k] + ")");
					}
					oOO0oO000_0_0.o.oOoO___o__oO.(A_0, A_1[k], 2, 1);
					A_1[k].AcceptChanges();
				}
				result = (array.Length == A_1.Length);
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			return result;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0004BB38 File Offset: 0x00049D38
		private static string <<EMPTY_NAME>>(Type A_0)
		{
			string result;
			if (A_0 == typeof(string))
			{
				result = "sr";
			}
			else if (A_0 == typeof(bool))
			{
				result = "bl";
			}
			else if (A_0 == typeof(DateTime))
			{
				result = "dt";
			}
			else if (A_0 == typeof(byte))
			{
				result = "bt";
			}
			else if (A_0 == typeof(short))
			{
				result = "st";
			}
			else if (A_0 == typeof(int))
			{
				result = "in";
			}
			else if (A_0 == typeof(long))
			{
				result = "lg";
			}
			else if (A_0 == typeof(float))
			{
				result = "sg";
			}
			else if (A_0 == typeof(double))
			{
				result = "db";
			}
			else if (A_0 == typeof(decimal))
			{
				result = "dm";
			}
			else
			{
				result = "sr";
			}
			return result;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0004BC2C File Offset: 0x00049E2C
		internal static object <<EMPTY_NAME>>(JObject A_0)
		{
			switch ((int)A_0["Type"])
			{
			case 2:
				return (short)A_0["Value"];
			case 3:
				return (int)A_0["Value"];
			case 4:
				return (float)A_0["Value"];
			case 5:
				return (double)A_0["Value"];
			case 7:
				return (DateTime)A_0["Value"];
			case 8:
				return A_0["Value"].ToString();
			case 11:
				return (bool)A_0["Value"];
			case 14:
				return (decimal)A_0["Value"];
			case 17:
				return (byte)A_0["Value"];
			case 18:
				return (char)A_0["Value"];
			case 20:
				return (long)A_0["Value"];
			}
			return A_0["Value"].ToString();
		}
	}
}
