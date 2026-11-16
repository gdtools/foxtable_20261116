using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000441 RID: 1089
	[StandardModule]
	internal sealed class o_O_o_oOoo__
	{
		// Token: 0x06004953 RID: 18771 RVA: 0x001FC014 File Offset: 0x001FA214
		internal static void <<EMPTY_NAME>>(OleDbDataAdapter A_0)
		{
			OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder();
			oleDbCommandBuilder.ConflictOption = ConflictOption.OverwriteChanges;
			oleDbCommandBuilder.SetAllValues = false;
			oleDbCommandBuilder.QuotePrefix = "[";
			oleDbCommandBuilder.QuoteSuffix = "]";
			if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0.SelectCommand.Connection))
			{
				oleDbCommandBuilder.QuotePrefix = "\"";
				oleDbCommandBuilder.QuoteSuffix = "\"";
			}
			oleDbCommandBuilder.DataAdapter = A_0;
			oleDbCommandBuilder.RefreshSchema();
			A_0.InsertCommand = oleDbCommandBuilder.GetInsertCommand();
			A_0.UpdateCommand = oleDbCommandBuilder.GetUpdateCommand();
			A_0.DeleteCommand = oleDbCommandBuilder.GetDeleteCommand();
			A_0.ContinueUpdateOnError = true;
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x001FC0AB File Offset: 0x001FA2AB
		static o_O_o_oOoo__()
		{
			if (!o0OoOOoOOo0.OO0._Oo0o.())
			{
				o_O_o_oOoo__.Oo_0.OOo0oO0. = true;
			}
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x001FC0D0 File Offset: 0x001FA2D0
		internal static bool <<EMPTY_NAME>>(string A_0, string A_1, int A_2, bool A_3)
		{
			char[] anyOf = new char[]
			{
				'.',
				'[',
				']',
				'!',
				'`'
			};
			try
			{
				List<string>.Enumerator enumerator = o_O_o_oOoo__.oO.O_..GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.CompareString(enumerator.Current, A_0, true) == 0)
					{
						MessageBox.Show(string.Concat(new string[]
						{
							"\"",
							A_0,
							"\"为保留名称，不能作为",
							A_1,
							"使用！"
						}), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return false;
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			bool result;
			if (!A_3 & (A_0 == null || Operators.CompareString(A_0, "", true) == 0))
			{
				MessageBox.Show(A_1 + "不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			else if (A_0.Length > A_2)
			{
				MessageBox.Show("ValueName长度不能超过" + Conversions.ToString(A_2) + "个字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			else if (A_0.IndexOfAny(anyOf) > -1)
			{
				MessageBox.Show(A_1 + "不能包括小数点(.)、感叹号(!)、重音符号(`) 和方括号([ ])", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			else if (char.IsDigit(A_0[0]))
			{
				MessageBox.Show(A_1 + "不能以数字开头！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			else
			{
				foreach (char c in A_0)
				{
					if ((char.IsSymbol(c) || char.IsPunctuation(c)) && c != '_')
					{
						MessageBox.Show(A_1 + "不能包括除下划线(_)之外的符号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return false;
					}
					if (char.IsControl(c) | char.IsWhiteSpace(c) | char.IsSeparator(c))
					{
						MessageBox.Show(A_1 + "不能包含控制字符(从 0 到 31 的 ASCII 值)以及空格，如果是从其他应用程序中粘贴过来的，请删除后重新输入！ ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x001FC2C8 File Offset: 0x001FA4C8
		internal static bool <<EMPTY_NAME>>(string A_0)
		{
			bool result;
			if (Operators.CompareString(A_0, "", true) == 0)
			{
				MessageBox.Show("列名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (o_O_o_oOoo__.oO.O_..Contains("~TMPCLP" + A_0))
			{
				MessageBox.Show("无效的列名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = o_O_o_oOoo__.O_o_._o0.(A_0, "列名", 64, false);
			}
			return result;
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x001FC340 File Offset: 0x001FA540
		internal static bool <<EMPTY_NAME>>(string A_0, bool A_1)
		{
			bool result;
			if (o_O_o_oOoo__.oO.O_..Contains(A_0))
			{
				result = false;
			}
			else if (A_0.Length > 64)
			{
				result = false;
			}
			else
			{
				char[] anyOf = new char[]
				{
					'.',
					'[',
					']',
					'!',
					'`'
				};
				if (A_0.IndexOfAny(anyOf) > -1)
				{
					result = false;
				}
				else
				{
					foreach (char c in A_0)
					{
						if (char.IsControl(c) | char.IsWhiteSpace(c) | char.IsSeparator(c))
						{
							return false;
						}
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x001FC3CC File Offset: 0x001FA5CC
		internal static bool <<EMPTY_NAME>>(string A_0)
		{
			bool result;
			if (Operators.CompareString(A_0, "like", true) == 0 || Operators.CompareString(A_0, "where", true) == 0 || Operators.CompareString(A_0, "as", true) == 0 || Operators.CompareString(A_0, "select", true) == 0 || Operators.CompareString(A_0, "from", true) == 0 || Operators.CompareString(A_0, "variables", true) == 0 || Operators.CompareString(A_0, "全局变量", true) == 0)
			{
				MessageBox.Show("无效表名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (Operators.CompareString(A_0, "", true) == 0)
			{
				MessageBox.Show("表名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (char.IsDigit(A_0[0]))
			{
				MessageBox.Show("表名第一个字符不能为数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (Versioned.IsNumeric(A_0))
			{
				MessageBox.Show("表名不能是纯数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (o_O_o_oOoo__.Oo_0.OOo0oO0..Contains("~TMPCLP" + A_0))
			{
				MessageBox.Show("无效的表名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = o_O_o_oOoo__.O_o_._o0.(A_0, "表名", 57, false);
			}
			return result;
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x001FC508 File Offset: 0x001FA708
		internal static string <<EMPTY_NAME>>(DataTable A_0, DataColumn A_1, string A_2)
		{
			int num = 1;
			string text;
			for (;;)
			{
				text = A_2 + Conversions.ToString(num);
				if (A_0.Select(string.Concat(new string[]
				{
					"[",
					A_1.ColumnName,
					"] = '",
					text,
					"'"
				})).Length == 0)
				{
					break;
				}
				num++;
				if (num > 2147483647)
				{
					goto Block_2;
				}
			}
			return text;
			Block_2:
			return A_2 + Conversions.ToString(num);
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x001FC57C File Offset: 0x001FA77C
		internal static bool <<EMPTY_NAME>>(DataColumn A_0, string A_1)
		{
			foreach (DataRow dataRow in A_0.Table.Select("", "", DataViewRowState.CurrentRows))
			{
				if (!dataRow.IsNull(A_0) && Operators.CompareString(Conversions.ToString(dataRow[A_0]), A_1, true) == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x001FC5D8 File Offset: 0x001FA7D8
		internal static bool <<EMPTY_NAME>>(DataTable A_0, DataColumn[] A_1, string[] A_2)
		{
			foreach (DataRow dataRow in A_0.Select("", "", DataViewRowState.CurrentRows))
			{
				bool flag = true;
				int num = A_1.Length - 1;
				for (int j = 0; j <= num; j++)
				{
					DataColumn column = A_1[j];
					if (dataRow[column] == DBNull.Value)
					{
						if (Operators.CompareString(A_2[j], "", true) != 0)
						{
							flag = false;
						}
					}
					else if (Operators.CompareString(Conversions.ToString(dataRow[column]), A_2[j], true) != 0)
					{
						flag = false;
					}
				}
				if (flag)
				{
					return flag;
				}
			}
			return false;
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x001FC678 File Offset: 0x001FA878
		internal static string <<EMPTY_NAME>>(OuterTableSetting A_0, OleDbConnection A_1)
		{
			string result;
			if (o_O_o_oOoo__.OOOO_OO._oo.(A_1))
			{
				result = o_O_o_oOoo__.OO_O0oO0.oooO_.(A_0, DataServerTypeEnum.SqlServer);
			}
			else if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_1))
			{
				result = o_O_o_oOoo__.OO_O0oO0.oooO_.(A_0, DataServerTypeEnum.Oracle);
			}
			else
			{
				result = o_O_o_oOoo__.OO_O0oO0.oooO_.(A_0, DataServerTypeEnum.Access);
			}
			return result;
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x001FC6B4 File Offset: 0x001FA8B4
		internal static string <<EMPTY_NAME>>(OuterTableSetting A_0, DataServerTypeEnum A_1)
		{
			string fields = A_0.Fields;
			string text = A_0.SourceTable;
			if (A_1 != DataServerTypeEnum.Oracle && !text.StartsWith("["))
			{
				text = "[" + text + "]";
			}
			string text2;
			if (A_0.AllRows || A_1 == DataServerTypeEnum.Oracle)
			{
				text2 = "Select ";
			}
			else if (A_0.Percent)
			{
				A_0.Top = Math.Min(A_0.Top, 100);
				text2 = "Select Top " + Conversions.ToString(A_0.Top) + " PERCENT ";
			}
			else
			{
				text2 = "Select Top " + Conversions.ToString(A_0.Top) + " ";
			}
			if (Operators.CompareString(fields, "", true) > 0 && Operators.CompareString(fields.Trim(), "", true) > 0 && !A_0.AllFields && !A_0.Exclude)
			{
				text2 = text2 + fields + " ";
			}
			else
			{
				text2 += "* ";
			}
			text2 = text2 + "From " + text;
			string text3 = A_0.Filter;
			if (!A_0.AllRows && A_1 == DataServerTypeEnum.Oracle)
			{
				string text4 = "ROWNUM <= " + Conversions.ToString(A_0.Top);
				if (Operators.CompareString(text3, "", true) > 0)
				{
					text3 = text3 + " AND " + text4;
				}
				else
				{
					text3 = text4;
				}
			}
			if (Operators.CompareString(text3, "", true) > 0)
			{
				text2 = text2 + " Where " + text3 + " ";
			}
			if (Operators.CompareString(A_0.Order, " ", true) > 0)
			{
				text2 = text2 + " ORDER BY " + A_0.Order;
			}
			if (A_1 == DataServerTypeEnum.Oracle)
			{
				text2 = text2.Replace("[", "\"").Replace("]", "\"");
			}
			return text2;
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x001FC86B File Offset: 0x001FAA6B
		internal static void <<EMPTY_NAME>>(DataTable A_0)
		{
			((OleDbDataAdapter)A_0.ExtendedProperties["DataAdapter"]).Fill(A_0);
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x001FC88C File Offset: 0x001FAA8C
		internal static object[] <<EMPTY_NAME>>(DataRow A_0)
		{
			DataTable table = A_0.Table;
			object[] array = new object[table.PrimaryKey.Length - 1 + 1];
			int num = table.PrimaryKey.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = RuntimeHelpers.GetObjectValue(A_0[table.PrimaryKey[i]]);
			}
			return array;
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x001FC8E0 File Offset: 0x001FAAE0
		internal static string <<EMPTY_NAME>>(object A_0, bool A_1 = false, char A_2 = '\v', bool A_3 = false)
		{
			ArrayList arrayList = new ArrayList();
			StringBuilder stringBuilder = new StringBuilder();
			PropertyInfo[] properties = A_0.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
			PropertyDescriptorCollection properties2 = TypeDescriptor.GetProperties(RuntimeHelpers.GetObjectValue(A_0));
			foreach (PropertyInfo propertyInfo in properties)
			{
				PropertyInfo propertyInfo;
				if (propertyInfo.GetSetMethod() != null && !O00OOOo_O0_O.O.0o_0_o.(propertyInfo))
				{
					if (O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo) && A_1)
					{
						arrayList.Add(propertyInfo);
					}
					else if (!O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo) & !A_1)
					{
						arrayList.Add(propertyInfo);
					}
				}
			}
			int num = arrayList.Count - 1;
			int j = 0;
			while (j <= num)
			{
				PropertyInfo propertyInfo = (PropertyInfo)arrayList[j];
				PropertyDescriptor propertyDescriptor = properties2[propertyInfo.Name];
				if (propertyDescriptor == null)
				{
					if (A_3)
					{
						goto IL_CB;
					}
				}
				else if (ooO.OO_oOO0O.O00.(RuntimeHelpers.GetObjectValue(A_0), propertyDescriptor) || A_3)
				{
					goto IL_CB;
				}
				IL_736:
				j++;
				continue;
				IL_CB:
				DefaultValueAttribute defaultValueAttribute = (DefaultValueAttribute)propertyDescriptor.Attributes[typeof(DefaultValueAttribute)];
				object objectValue = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), null));
				string text = "";
				if (objectValue != null)
				{
					if (propertyInfo.PropertyType.IsEnum)
					{
						text = Conversions.ToInteger(objectValue).ToString();
					}
					else if (propertyInfo.PropertyType == typeof(Font))
					{
						Font font = (Font)objectValue;
						if (font.Style == FontStyle.Regular)
						{
							text = font.Name + "," + Conversions.ToString(font.Size);
						}
						else
						{
							text = string.Concat(new string[]
							{
								font.Name,
								",",
								Conversions.ToString(font.Size),
								",",
								font.Style.ToString()
							}).Trim(new char[]
							{
								','
							});
						}
					}
					else if (propertyInfo.PropertyType == typeof(Color))
					{
						object obj = objectValue;
						Color color = (obj != null) ? ((Color)obj) : default(Color);
						if (color.IsEmpty)
						{
							if (!A_3)
							{
								goto IL_736;
							}
						}
						else
						{
							text = color.ToArgb().ToString();
						}
						color = default(Color);
					}
					else if (propertyInfo.PropertyType == typeof(DateTime))
					{
						DateTime t;
						if (DateTime.Compare(t, Conversions.ToDate(objectValue)) == 0)
						{
							if (!A_3)
							{
								goto IL_736;
							}
						}
						else
						{
							text = objectValue.ToString();
						}
					}
					else if (propertyInfo.PropertyType == typeof(char))
					{
						if (Conversions.ToChar(objectValue) == '\0' && !A_3)
						{
							goto IL_736;
						}
						text = Conversions.ToString(Conversions.ToChar(objectValue));
					}
					else
					{
						text = objectValue.ToString();
					}
				}
				else if (!A_3)
				{
					goto IL_736;
				}
				if (defaultValueAttribute != null)
				{
					if (string.Compare(defaultValueAttribute.Value.ToString(), text, false) == 0 && !A_3)
					{
						goto IL_736;
					}
				}
				else if (Operators.CompareString(text, "", true) == 0 && !A_3)
				{
					goto IL_736;
				}
				stringBuilder.Append(propertyInfo.Name);
				stringBuilder.Append(A_2);
				if (propertyInfo.PropertyType == typeof(string) || propertyInfo.PropertyType == typeof(char))
				{
					stringBuilder.Append(text.Replace(Conversions.ToString(A_2), ""));
				}
				else if (propertyInfo.PropertyType == typeof(DateTime))
				{
					stringBuilder.Append(RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), null)));
				}
				else if (propertyInfo.PropertyType == typeof(int) || propertyInfo.PropertyType == typeof(byte) || propertyInfo.PropertyType == typeof(double) || propertyInfo.PropertyType == typeof(float) || propertyInfo.PropertyType == typeof(decimal) || propertyInfo.PropertyType == typeof(long))
				{
					stringBuilder.Append(text);
				}
				else if (propertyInfo.PropertyType == typeof(bool))
				{
					if (Conversions.ToBoolean(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), null)))
					{
						stringBuilder.Append("1");
					}
					else
					{
						stringBuilder.Append("0");
					}
				}
				else if (propertyInfo.PropertyType == typeof(EventString) || propertyInfo.PropertyType == typeof(StringCollection))
				{
					EventString eventString = (EventString)propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), null);
					if (eventString != null && eventString.Count > 0)
					{
						stringBuilder.Append(eventString[0]);
					}
					else
					{
						stringBuilder.Append("");
					}
				}
				else if (propertyInfo.PropertyType == typeof(Size))
				{
					object value = propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), null);
					Size size = (value != null) ? ((Size)value) : default(Size);
					stringBuilder.Append(Conversions.ToString(size.Width) + "," + Conversions.ToString(size.Height));
				}
				else if (propertyInfo.PropertyType == typeof(Point))
				{
					object value2 = propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), null);
					Point point = (value2 != null) ? ((Point)value2) : default(Point);
					stringBuilder.Append(Conversions.ToString(point.X) + "," + Conversions.ToString(point.Y));
				}
				else if (propertyInfo.PropertyType == typeof(PointF))
				{
					object value3 = propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), null);
					PointF pointF = (value3 != null) ? ((PointF)value3) : default(PointF);
					stringBuilder.Append(Conversions.ToString(pointF.X) + "," + Conversions.ToString(pointF.Y));
				}
				else if (propertyInfo.PropertyType == typeof(Font))
				{
					Font font2 = (Font)propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), null);
					if (font2 != null)
					{
						stringBuilder.Append(string.Concat(new string[]
						{
							font2.Name,
							",",
							Conversions.ToString(font2.Size),
							",",
							Conversions.ToString((int)font2.Style),
							",",
							Conversions.ToString((int)font2.Unit)
						}));
					}
					else
					{
						stringBuilder.Append("");
					}
				}
				else if (propertyInfo.PropertyType == typeof(Color))
				{
					object value4 = propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), null);
					Color color2 = (value4 != null) ? ((Color)value4) : default(Color);
					if (color2.IsEmpty)
					{
						stringBuilder.Append("");
					}
					else if (color2.ToKnownColor() > (KnownColor)0)
					{
						stringBuilder.Append((int)color2.ToKnownColor());
					}
					else
					{
						stringBuilder.Append(color2.ToArgb());
					}
				}
				else if (propertyInfo.PropertyType.IsEnum)
				{
					stringBuilder.Append(Conversions.ToInteger(propertyInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0), null)));
				}
				if (j < arrayList.Count - 1)
				{
					stringBuilder.Append(A_2);
				}
				if (o_O_o_oOoo__.O_o_._o0. != null && o_O_o_oOoo__.O_o_._o0..Value)
				{
					j++;
					goto IL_736;
				}
				goto IL_736;
			}
			return stringBuilder.ToString().Trim(new char[]
			{
				A_2
			});
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x001FD048 File Offset: 0x001FB248
		internal static void <<EMPTY_NAME>>(object A_0, DataRow A_1, bool A_2 = false)
		{
			if (!A_2 && !A_1.IsNull("Property"))
			{
				o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToString(A_1["Property"]), '\v');
			}
			if (!A_1.IsNull("Code"))
			{
				string text = Conversions.ToString(A_1["Code"]);
				string a_ = ooO0__OO.O_Oo00oO.Ooo.();
				if (text.StartsWith("{") && text.EndsWith("}"))
				{
					text = text.TrimStart(new char[]
					{
						'{'
					}).TrimEnd(new char[]
					{
						'}'
					});
					a_ = Oo00.ooO.ooo.();
				}
				o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(A_0), O00.oO_.0o_oo_0O_.(text, ooO0__OO.O_Oo00oO.Ooo.(), a_), '\v');
			}
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x001FD104 File Offset: 0x001FB304
		internal static void <<EMPTY_NAME>>(object A_0, string A_1, char A_2 = '\v')
		{
			string[] array = A_1.Split(new char[]
			{
				A_2
			});
			int num = array.Length - 2;
			for (int i = 0; i <= num; i += 2)
			{
				PropertyInfo property = A_0.GetType().GetProperty(array[i]);
				if (property != null && property.GetSetMethod() != null)
				{
					Operators.CompareString(array[i + 1], "", true);
					if (property != null)
					{
						if (property.PropertyType == typeof(string))
						{
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), array[i + 1], null);
						}
						else if (property.PropertyType == typeof(DateTime))
						{
							DateTime dateTime;
							if (DateTime.TryParse(array[i + 1], out dateTime))
							{
								property.SetValue(RuntimeHelpers.GetObjectValue(A_0), dateTime, null);
							}
						}
						else if (property.PropertyType == typeof(char))
						{
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), array[i + 1][0], null);
						}
						else if (property.PropertyType == typeof(int))
						{
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToInteger(array[i + 1]), null);
						}
						else if (property.PropertyType == typeof(long))
						{
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToInteger(array[i + 1]), null);
						}
						else if (property.PropertyType == typeof(byte))
						{
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToByte(array[i + 1]), null);
						}
						else if (property.PropertyType == typeof(double))
						{
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToDouble(array[i + 1]), null);
						}
						else if (property.PropertyType == typeof(decimal))
						{
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToDecimal(array[i + 1]), null);
						}
						else if (property.PropertyType == typeof(float))
						{
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), Conversions.ToSingle(array[i + 1]), null);
						}
						else if (property.PropertyType == typeof(bool))
						{
							if (Operators.CompareString(array[i + 1], "1", true) == 0)
							{
								property.SetValue(RuntimeHelpers.GetObjectValue(A_0), true, null);
							}
							else
							{
								property.SetValue(RuntimeHelpers.GetObjectValue(A_0), false, null);
							}
						}
						else if (property.PropertyType == typeof(EventString) || property.PropertyType == typeof(StringCollection))
						{
							EventString eventString = new EventString();
							if (Operators.CompareString(array[i + 1], "", true) > 0)
							{
								eventString.Add(array[i + 1]);
								property.SetValue(RuntimeHelpers.GetObjectValue(A_0), eventString, null);
							}
							else
							{
								property.SetValue(RuntimeHelpers.GetObjectValue(A_0), null, null);
							}
							if (o_O_o_oOoo__.Oo_0.OOo0oO0.)
							{
								i += 2;
							}
						}
						else if (property.PropertyType == typeof(Size))
						{
							int width = Conversions.ToInteger(array[i + 1].Substring(0, array[i + 1].IndexOf(",")));
							int height = Conversions.ToInteger(array[i + 1].Substring(array[i + 1].IndexOf(",") + 1));
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), new Size(width, height), null);
						}
						else if (property.PropertyType == typeof(Point))
						{
							int x = Conversions.ToInteger(array[i + 1].Substring(0, array[i + 1].IndexOf(",")));
							int y = Conversions.ToInteger(array[i + 1].Substring(array[i + 1].IndexOf(",") + 1));
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), new Point(x, y), null);
						}
						else if (property.PropertyType == typeof(PointF))
						{
							float x2 = Conversions.ToSingle(array[i + 1].Substring(0, array[i + 1].IndexOf(",")));
							float y2 = Conversions.ToSingle(array[i + 1].Substring(array[i + 1].IndexOf(",") + 1));
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), new PointF(x2, y2), null);
						}
						else if (property.PropertyType == typeof(Font))
						{
							if (Operators.CompareString(array[i + 1], "", true) == 0)
							{
								property.SetValue(RuntimeHelpers.GetObjectValue(A_0), null, null);
							}
							else
							{
								string[] array2 = array[i + 1].Split(new char[]
								{
									','
								});
								string familyName = array2[0];
								float emSize = Conversions.ToSingle(array2[1]);
								FontStyle style = (FontStyle)Conversions.ToInteger(array2[2]);
								GraphicsUnit unit = (GraphicsUnit)Conversions.ToInteger(array2[3]);
								Font value = new Font(familyName, emSize, style, unit);
								property.SetValue(RuntimeHelpers.GetObjectValue(A_0), value, null);
							}
						}
						else if (property.PropertyType == typeof(Color))
						{
							if (Operators.CompareString(array[i + 1], "", true) == 0)
							{
								property.SetValue(RuntimeHelpers.GetObjectValue(A_0), Color.Empty, null);
							}
							else if (Enum.GetName(typeof(KnownColor), Conversions.ToInteger(array[i + 1])) != null)
							{
								Color color = Color.FromKnownColor((KnownColor)Conversions.ToInteger(array[i + 1]));
								property.SetValue(RuntimeHelpers.GetObjectValue(A_0), color, null);
							}
							else
							{
								Color color2 = Color.FromArgb(Conversions.ToInteger(array[i + 1]));
								property.SetValue(RuntimeHelpers.GetObjectValue(A_0), color2, null);
							}
						}
						else if (property.PropertyType.IsEnum)
						{
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), RuntimeHelpers.GetObjectValue(Enum.Parse(property.PropertyType, array[i + 1])), null);
						}
						else if (Operators.CompareString(array[i + 1], "", true) > 0 && Operators.CompareString(property.PropertyType.Name, "Object", true) == 0)
						{
							property.SetValue(RuntimeHelpers.GetObjectValue(A_0), array[i + 1], null);
						}
					}
				}
			}
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x001FD724 File Offset: 0x001FB924
		internal static bool <<EMPTY_NAME>>(OleDbConnection A_0)
		{
			bool result;
			if (A_0 == null)
			{
				result = false;
			}
			else if (A_0.Provider == null)
			{
				result = false;
			}
			else
			{
				string provider = A_0.Provider;
				result = (provider.StartsWith("OraOLEDB", StringComparison.CurrentCultureIgnoreCase) || provider.StartsWith("MSDAORA", StringComparison.CurrentCultureIgnoreCase));
			}
			return result;
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x001FD770 File Offset: 0x001FB970
		internal static bool <<EMPTY_NAME>>(OleDbConnection A_0)
		{
			string provider = A_0.Provider;
			return provider.StartsWith("SQLOLEDB", StringComparison.CurrentCultureIgnoreCase) || provider.StartsWith("SQLNCLI", StringComparison.CurrentCultureIgnoreCase);
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x001FD7AC File Offset: 0x001FB9AC
		internal static bool <<EMPTY_NAME>>(Type A_0)
		{
			return A_0 == typeof(long) || A_0 == typeof(int) || A_0 == typeof(short) || A_0 == typeof(byte) || A_0 == typeof(decimal) || A_0 == typeof(double) || A_0 == typeof(float);
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x001FD81C File Offset: 0x001FBA1C
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			int num = A_0.IndexOf("USER ID", StringComparison.CurrentCultureIgnoreCase);
			string result;
			if (num > 0)
			{
				int num2 = A_0.IndexOf("=", num);
				int num3 = A_0.IndexOf(";", num2);
				result = A_0.Substring(num2 + 1, num3 - num2 - 1).Trim();
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x001FD874 File Offset: 0x001FBA74
		internal static string <<EMPTY_NAME>>(string A_0, string A_1, DateGroupEnum A_2, DataServerTypeEnum A_3)
		{
			string text = "";
			A_1 = A_1.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			if (A_3 == DataServerTypeEnum.Oracle)
			{
				text = "TO_CHAR(";
				if (Operators.CompareString(A_0, "", true) > 0)
				{
					text = text + A_0 + ".";
				}
				text = text + "\"" + A_1 + "\",";
				switch (A_2)
				{
				case DateGroupEnum.Year:
					text += "'YYYY')";
					break;
				case DateGroupEnum.Quarter:
					text += "'Q')";
					break;
				case DateGroupEnum.Month:
					text += "'MM')";
					break;
				case DateGroupEnum.Week:
					text += "'WW')";
					break;
				case DateGroupEnum.Day:
					text += "'DD')";
					break;
				case DateGroupEnum.Hour:
					text += "'HH24')";
					break;
				case DateGroupEnum.Minute:
					text += "'MI')";
					break;
				case DateGroupEnum.Second:
					text += "'SS')";
					break;
				case DateGroupEnum.DayOfYear:
					text += "'DDD')";
					break;
				case DateGroupEnum.DayOfWeek:
					text += "'D')";
					break;
				}
			}
			else
			{
				switch (A_2)
				{
				case DateGroupEnum.Year:
					text = "DatePart('yyyy',";
					break;
				case DateGroupEnum.Quarter:
					text = "DatePart('q',";
					break;
				case DateGroupEnum.Month:
					text = "DatePart('m',";
					break;
				case DateGroupEnum.Week:
					text = "DatePart('ww',";
					break;
				case DateGroupEnum.Day:
					text = "DatePart('d',";
					break;
				case DateGroupEnum.Hour:
					if (A_3 == DataServerTypeEnum.SqlServer)
					{
						text = "DatePart('hh',";
					}
					else
					{
						text = "DatePart('h',";
					}
					break;
				case DateGroupEnum.Minute:
					text = "DatePart('n',";
					break;
				case DateGroupEnum.Second:
					text = "DatePart('s',";
					break;
				case DateGroupEnum.DayOfYear:
					text = "DatePart('y',";
					break;
				case DateGroupEnum.DayOfWeek:
					text = "DatePart('w',";
					break;
				}
				if (A_3 == DataServerTypeEnum.SqlServer)
				{
					text = text.Replace("'", "");
				}
				if (Operators.CompareString(A_0, "", true) > 0)
				{
					text = text + "[" + A_0 + "].";
				}
				text = text + "[" + A_1 + "])";
			}
			return text;
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x001FDAA0 File Offset: 0x001FBCA0
		internal static bool <<EMPTY_NAME>>()
		{
			Version version = Environment.Version;
			return version.Build == 50727 && version.Revision < 1433;
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x001FDAD8 File Offset: 0x001FBCD8
		internal static void <<EMPTY_NAME>>(Table A_0)
		{
			O_oOooO_O o_oOooO_O = A_0.foxGrid;
			int @fixed = o_oOooO_O.Cols.Fixed;
			int num = o_oOooO_O.Cols.Count - 1;
			for (int i = @fixed; i <= num; i++)
			{
				Column column = o_oOooO_O.Cols[i];
				if (column.Editor != null && !column.Editor.Disposing && !column.Editor.IsDisposed)
				{
					if (column.Editor is BuildInDropTree)
					{
						BuildInDropTree buildInDropTree = (BuildInDropTree)column.Editor;
						buildInDropTree.Ooo._0oO..o.00_O_.().Nodes.Clear();
						buildInDropTree.Ooo._0oO..o_Oo.O0o__o0O. = null;
						buildInDropTree.Ooo._0oO..Dispose();
						buildInDropTree.Ooo._0oO. = null;
						buildInDropTree.Dispose();
					}
					column.Editor = null;
				}
			}
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x001FDB9C File Offset: 0x001FBD9C
		internal static List<TreeNode> <<EMPTY_NAME>>(TreeView A_0)
		{
			List<TreeNode> list = new List<TreeNode>();
			o_O_o_oOoo__.oo.O0o0o.(A_0.Nodes, list);
			return list;
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x001FDBBC File Offset: 0x001FBDBC
		internal static void <<EMPTY_NAME>>(TreeNodeCollection A_0, List<TreeNode> A_1)
		{
			try
			{
				foreach (object obj in A_0)
				{
					TreeNode treeNode = (TreeNode)obj;
					A_1.Add(treeNode);
					if (treeNode.Nodes.Count > 0)
					{
						o_O_o_oOoo__.oo.O0o0o.(treeNode.Nodes, A_1);
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

		// Token: 0x0600496C RID: 18796 RVA: 0x001FDC30 File Offset: 0x001FBE30
		internal static string <<EMPTY_NAME>>(this TreeNode A_0, char A_1)
		{
			string text = A_0.Name;
			for (TreeNode parent = A_0.Parent; parent != null; parent = parent.Parent)
			{
				text = parent.Name + Interaction.IIf(Operators.CompareString(Conversions.ToString(A_1), "\0", true) == 0, "", A_1).ToString() + text;
			}
			return text;
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x001FDC90 File Offset: 0x001FBE90
		internal static string <<EMPTY_NAME>>(this TreeNode A_0, char A_1, int A_2)
		{
			string text = A_0.Name;
			TreeNode parent = A_0.Parent;
			while (parent != null && parent.Level != A_2)
			{
				text = parent.Name + Interaction.IIf(Operators.CompareString(Conversions.ToString(A_1), "\0", true) == 0, "", A_1).ToString() + text;
				parent = parent.Parent;
			}
			return text;
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x001FDCF7 File Offset: 0x001FBEF7
		internal static int <<EMPTY_NAME>>(this TreeNode A_0)
		{
			return o_O_o_oOoo__.OOOO_OO._oo.(A_0.Nodes);
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x001FDD04 File Offset: 0x001FBF04
		internal static int <<EMPTY_NAME>>(this TreeView A_0)
		{
			return o_O_o_oOoo__.OOOO_OO._oo.(A_0.Nodes);
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x001FDD14 File Offset: 0x001FBF14
		internal static bool <<EMPTY_NAME>>(this TreeNodeCollection A_0, string A_1)
		{
			try
			{
				foreach (object obj in A_0)
				{
					string text = ((TreeNode)obj).Text;
					if (text.EndsWith(")") && text.IndexOf("(") > 0)
					{
						text = text.Substring(0, text.LastIndexOf("("));
					}
					if (Operators.CompareString(text, A_1, true) == 0)
					{
						return true;
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
			return false;
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x001FDDA8 File Offset: 0x001FBFA8
		internal static string <<EMPTY_NAME>>(this TreeNode A_0)
		{
			string text = A_0.Text;
			if (text.EndsWith(")") && text.IndexOf("(") > 0)
			{
				text = text.Substring(0, text.LastIndexOf("("));
			}
			return text;
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x001FDDEC File Offset: 0x001FBFEC
		internal static string <<EMPTY_NAME>>(this TreeNode A_0)
		{
			string text = A_0.Text;
			if (text.EndsWith(")") && text.IndexOf("(") > 0)
			{
				text = text.Substring(text.LastIndexOf("(") + 1).Trim(new char[]
				{
					')'
				});
				if (Versioned.IsNumeric(text))
				{
					return text;
				}
			}
			return "";
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x001FDE54 File Offset: 0x001FC054
		public static int <<EMPTY_NAME>>(TreeNodeCollection A_0)
		{
			SortedSet<int> sortedSet = new SortedSet<int>();
			try
			{
				foreach (object obj in A_0)
				{
					TreeNode treeNode = (TreeNode)obj;
					if (Versioned.IsNumeric(treeNode.Name))
					{
						sortedSet.Add(Conversions.ToInteger(treeNode.Name));
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
			int num = 1;
			while (sortedSet.Contains(num))
			{
				num++;
			}
			return num;
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x001FDEDC File Offset: 0x001FC0DC
		internal static string <<EMPTY_NAME>>(TreeView A_0)
		{
			o_O_o_oOoo__.o00OO0Oo_ o00OO0Oo_ = new o_O_o_oOoo__.o00OO0Oo_(o00OO0Oo_);
			List<TreeNode> source = o_O_o_oOoo__.OO_O0oO0.oooO_.(A_0);
			int num = 0;
			do
			{
				num++;
				o00OO0Oo_.Oo_0.OOo0oO0. = "新节点" + Conversions.ToString(num);
			}
			while (source.Any(new Func<TreeNode, bool>(o00OO0Oo_.Oo_0.OOo0oO0.)));
			return o00OO0Oo_.Oo_0.OOo0oO0.;
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x001FDF30 File Offset: 0x001FC130
		internal static bool <<EMPTY_NAME>>(TreeNode A_0, TreeNode A_1)
		{
			bool result;
			if (A_0.Nodes.Count != A_1.Nodes.Count)
			{
				result = true;
			}
			else
			{
				int num = A_0.Nodes.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(A_0.Nodes[i].Name, A_1.Nodes[i].Name, true) != 0)
					{
						return true;
					}
					if (Operators.CompareString(A_0.Nodes[i].Text, A_1.Nodes[i].Text, true) != 0)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x001FDFD4 File Offset: 0x001FC1D4
		internal static bool <<EMPTY_NAME>>(Type A_0)
		{
			return A_0 != typeof(DateTime) && A_0 != typeof(double) && A_0 != typeof(float) && A_0 != typeof(decimal) && A_0 != typeof(bool);
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x001FE02C File Offset: 0x001FC22C
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (A_0 == null || A_0.Length < 2)
			{
				result = A_0;
			}
			else
			{
				int length = A_0.Length;
				char[] array = new char[length - 1 + 1];
				int num = length / 2 - 1;
				for (int i = 0; i <= num; i++)
				{
					int num2 = length - 1 - i;
					char c = A_0[i];
					char c2 = A_0[num2];
					array[num2] = c;
					array[i] = c2;
				}
				if (length % 2 == 1)
				{
					array[length / 2] = A_0[length / 2];
				}
				result = new string(array);
			}
			return result;
		}

		// Token: 0x04001DCF RID: 7631
		internal static readonly List<string> <<EMPTY_NAME>> = new List<string>();

		// Token: 0x04001DD0 RID: 7632
		internal static readonly List<string> <<EMPTY_NAME>> = new List<string>();

		// Token: 0x04001DD1 RID: 7633
		private static bool <<EMPTY_NAME>>;

		// Token: 0x04001DD2 RID: 7634
		internal static bool? <<EMPTY_NAME>>;

		// Token: 0x02000442 RID: 1090
		[CompilerGenerated]
		internal sealed class o00OO0Oo_
		{
			// Token: 0x06004978 RID: 18808 RVA: 0x001FE0B5 File Offset: 0x001FC2B5
			public o00OO0Oo_(o_O_o_oOoo__.o00OO0Oo_ A_0)
			{
				if (A_0 != null)
				{
					this.Oo_0.OOo0oO0. = A_0.Oo_0.OOo0oO0.;
				}
			}

			// Token: 0x06004979 RID: 18809 RVA: 0x001FE0CC File Offset: 0x001FC2CC
			internal bool <<EMPTY_NAME>>(TreeNode A_0)
			{
				return Operators.CompareString(A_0.Name, this.Oo_0.OOo0oO0., true) == 0;
			}

			// Token: 0x04001DD3 RID: 7635
			public string <<EMPTY_NAME>>;
		}
	}
}
