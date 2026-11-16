using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000067 RID: 103
	[TypeConverter(typeof(OoO0o0oo__Oo))]
	internal class o_0oooo_OO : ICustomTypeDescriptor
	{
		// Token: 0x0600038F RID: 911 RVA: 0x0000D890 File Offset: 0x0000BA90
		public o_0oooo_OO(object A_0, string[] A_1, bool A_2, bool A_3)
		{
			int a_ = 16;
			base..ctor();
			this.o0oO__._Oo0O. = "";
			this.o_0Oo_0.ooOo. = "";
			this.oo_O_o.O. = "";
			this.oO_____000O.oO. = "";
			this.o0oO__._Oo0O. = new object[]
			{
				this.oo_O_o.O.,
				this.oO_____000O.oO.,
				this.o0oO__._Oo0O.
			};
			this.O_oO__0.o. = RuntimeHelpers.GetObjectValue(A_0);
			this.O_oO__0.o. = A_1;
			this.o0oO__._Oo0O. = A_2;
			this.o_0Oo_0.ooOo. = A_3;
			if (o_0oooo_OO.O_oO__0.o. == null)
			{
				o_0oooo_OO.O_oO__0.o. = o0_.Oo_0.OOo0oO0.(O00.oO_.0o_oo_0O_.(SysInfo.SourceString10, O00OOOo_O0_O.b("飲郴軶", a_), O00OOOo_O0_O.b("飲郴軶", a_)), "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", false);
				o_0oooo_OO.O_oO__0.o. = o_0oooo_OO.O_oO__0.o..GetType(O00OOOo_O0_O.b("꛲蛴鋶诸룺鋼鯾搀", a_)).GetMethod(O00OOOo_O0_O.b("듲郴菶꧸髺迼黾爀", a_));
				this.O_oO__0.o.();
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000D9B2 File Offset: 0x0000BBB2
		public object <<EMPTY_NAME>>()
		{
			return this.O_oO__0.o.;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000D9BA File Offset: 0x0000BBBA
		public AttributeCollection <<EMPTY_NAME>>()
		{
			return TypeDescriptor.GetAttributes(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), true);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000D9CD File Offset: 0x0000BBCD
		public string <<EMPTY_NAME>>()
		{
			return TypeDescriptor.GetClassName(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), true);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		public string <<EMPTY_NAME>>()
		{
			return TypeDescriptor.GetComponentName(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), true);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000D9F3 File Offset: 0x0000BBF3
		public TypeConverter <<EMPTY_NAME>>()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000D9FC File Offset: 0x0000BBFC
		public EventDescriptor <<EMPTY_NAME>>()
		{
			return TypeDescriptor.GetDefaultEvent(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), true);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000DA0F File Offset: 0x0000BC0F
		public PropertyDescriptor <<EMPTY_NAME>>()
		{
			return TypeDescriptor.GetDefaultProperty(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), true);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000DA22 File Offset: 0x0000BC22
		public object <<EMPTY_NAME>>(Type A_0)
		{
			return TypeDescriptor.GetEditor(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), A_0, true);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000DA36 File Offset: 0x0000BC36
		public EventDescriptorCollection <<EMPTY_NAME>>()
		{
			return TypeDescriptor.GetEvents(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), true);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000DA49 File Offset: 0x0000BC49
		public EventDescriptorCollection <<EMPTY_NAME>>(Attribute[] A_0)
		{
			return TypeDescriptor.GetEvents(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), A_0, true);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000DA5D File Offset: 0x0000BC5D
		public PropertyDescriptorCollection <<EMPTY_NAME>>()
		{
			return this.OO00o0.o0___.(null);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000DA68 File Offset: 0x0000BC68
		public PropertyDescriptorCollection <<EMPTY_NAME>>(Attribute[] A_0)
		{
			if (this.O_oO__0.o. == null)
			{
				PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), A_0, true);
				this.O_oO__0.o. = new PropertyDescriptorCollection(null);
				try
				{
					foreach (object obj in properties)
					{
						PropertyDescriptor propertyDescriptor = (PropertyDescriptor)obj;
						if (ooO.OO_oOO0O.O00.(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), propertyDescriptor) && !(O00OOOo_O0_O.Oo_o_o.__oo.(propertyDescriptor) ^ this.o_0Oo_0.ooOo.) && this.O_oO__0.o.(propertyDescriptor))
						{
							this.O_oO__0.o..Add(propertyDescriptor);
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
			return this.O_oO__0.o.;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000DB20 File Offset: 0x0000BD20
		public object <<EMPTY_NAME>>(PropertyDescriptor A_0)
		{
			return this.O_oO__0.o.;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000DB28 File Offset: 0x0000BD28
		private bool <<EMPTY_NAME>>(PropertyDescriptor A_0)
		{
			bool result;
			if (this.O_oO__0.o..Length < 1)
			{
				result = true;
			}
			else
			{
				Attribute attribute = A_0.Attributes[typeof(CategoryAttribute)];
				if (attribute == null)
				{
					if (!this.o0oO__._Oo0O.)
					{
						result = true;
					}
				}
				else if (this.o0oO__._Oo0O. && Array.IndexOf<string>(this.O_oO__0.o., ((CategoryAttribute)attribute).Category) >= 0)
				{
					result = true;
				}
				else if (!this.o0oO__._Oo0O. && Array.IndexOf<string>(this.O_oO__0.o., ((CategoryAttribute)attribute).Category) < 0)
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000DBB4 File Offset: 0x0000BDB4
		private bool <<EMPTY_NAME>>()
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
				PropertyDescriptorCollection propertyDescriptorCollection = null;
				IL_0C:
				num2 = 3;
				Attribute[] attributes = new Attribute[0];
				IL_16:
				num2 = 4;
				if (propertyDescriptorCollection != null)
				{
					goto IL_119;
				}
				IL_1F:
				num2 = 5;
				PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), attributes, true);
				IL_36:
				num2 = 6;
				propertyDescriptorCollection = new PropertyDescriptorCollection(null);
				IL_40:
				num2 = 7;
				o_0oooo_OO.O_oO__0.o..Invoke(null, this.o0oO__._Oo0O.);
				IL_54:
				num2 = 8;
				this.oo_O_o.O. = this.o0oO__._Oo0O.[0].ToString();
				IL_69:
				num2 = 9;
				this.oO_____000O.oO. = this.o0oO__._Oo0O.[1].ToString();
				IL_7F:
				num2 = 10;
				this.o0oO__._Oo0O. = this.o0oO__._Oo0O.[2].ToString();
				IL_95:
				num2 = 11;
				IEnumerator enumerator = properties.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					PropertyDescriptor propertyDescriptor = (PropertyDescriptor)obj;
					IL_B1:
					num2 = 12;
					if (ooO.OO_oOO0O.O00.(RuntimeHelpers.GetObjectValue(this.O_oO__0.o.), propertyDescriptor))
					{
						IL_C8:
						num2 = 14;
						if (!(O00OOOo_O0_O.Oo_o_o.__oo.(propertyDescriptor) ^ this.o_0Oo_0.ooOo.))
						{
							IL_DB:
							num2 = 15;
							if (this.O_oO__0.o.(propertyDescriptor))
							{
								IL_E8:
								num2 = 16;
								propertyDescriptorCollection.Add(propertyDescriptor);
							}
						}
					}
					IL_F5:
					num2 = 17;
				}
				IL_101:
				num2 = 18;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_119:
				num2 = 19;
				if (Operators.CompareString(this.o0oO__._Oo0O., "", true) <= 0)
				{
					goto IL_150;
				}
				IL_130:
				num2 = 20;
				this.o0oO__._Oo0O. = O00.oO_.0o_oo_0O_.(this.o0oO__._Oo0O., this.oo_O_o.O., this.oO_____000O.oO.);
				IL_150:
				num2 = 21;
				this.o_0Oo_0.ooOo. = this.oo_O_o.O. + this.oO_____000O.oO.;
				IL_16A:
				num2 = 22;
				this.o_0Oo_0.ooOo. = O00.MD5Encrypt(this.o_0Oo_0.ooOo.).Substring(0, 16);
				IL_186:
				num2 = 23;
				O_O0OO.O0_00o.o0__o..PropertyIsValid = (Operators.CompareString(this.o0oO__._Oo0O., this.o_0Oo_0.ooOo., true) == 0);
				IL_1A8:
				num2 = 24;
				List<string> list = new List<string>();
				IL_1B2:
				num2 = 25;
				list.Add("");
				IL_1C1:
				num2 = 26;
				Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator2 = O_O0OO.O._o_.().Keys.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string item = enumerator2.Current;
					IL_1E0:
					num2 = 27;
					list.Add(item);
					IL_1EC:
					num2 = 28;
				}
				IL_1F8:
				num2 = 29;
				((IDisposable)enumerator2).Dispose();
				IL_208:
				num2 = 30;
				TypeConverter.StandardValuesCollection standardValuesCollection = new TypeConverter.StandardValuesCollection(list);
				IL_214:
				num2 = 31;
				result = (standardValuesCollection.Count > 0);
				IL_222:
				goto IL_2F4;
				IL_227:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2B5:
				goto IL_2E9;
				IL_2B7:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2C7:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_2B7;
			}
			IL_2E9:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2F4:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x040000BF RID: 191
		private PropertyDescriptorCollection <<EMPTY_NAME>>;

		// Token: 0x040000C0 RID: 192
		private object <<EMPTY_NAME>>;

		// Token: 0x040000C1 RID: 193
		private string[] <<EMPTY_NAME>>;

		// Token: 0x040000C2 RID: 194
		private bool <<EMPTY_NAME>>;

		// Token: 0x040000C3 RID: 195
		private bool <<EMPTY_NAME>>;

		// Token: 0x040000C4 RID: 196
		private static Assembly <<EMPTY_NAME>>;

		// Token: 0x040000C5 RID: 197
		private static MethodInfo <<EMPTY_NAME>>;

		// Token: 0x040000C6 RID: 198
		private static bool <<EMPTY_NAME>>;

		// Token: 0x040000C7 RID: 199
		private string <<EMPTY_NAME>>;

		// Token: 0x040000C8 RID: 200
		private string <<EMPTY_NAME>>;

		// Token: 0x040000C9 RID: 201
		private string <<EMPTY_NAME>>;

		// Token: 0x040000CA RID: 202
		private string <<EMPTY_NAME>>;

		// Token: 0x040000CB RID: 203
		private object[] <<EMPTY_NAME>>;
	}
}
