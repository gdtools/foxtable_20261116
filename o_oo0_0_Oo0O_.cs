using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200004A RID: 74
	internal class o_oo0_0_Oo0O_ : UITypeEditor
	{
		// Token: 0x060002BD RID: 701 RVA: 0x00006498 File Offset: 0x00004698
		public o_oo0_0_Oo0O_()
		{
			int a_ = 14;
			base..ctor();
			this.Oo.0OO_. = O00OOOo_O0_O.b("샰쏲쟴쏶", a_);
			this.oO__O.0o__0. = O00OOOo_O0_O.b("駰蟲致蟶", a_);
			this.O00o_0O._O. = "";
			this.o_.O. = "";
			this.Oo0O_0o.o_O. = "";
			this.O.o0o_o_oO. = "";
			this.oO0_O0O.___OO. = "";
			this.oO_.O0____. = "";
			this.O_O.___0_. = O00OOOo_O0_O.b("駰蟲飴", a_);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00006534 File Offset: 0x00004734
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			UITypeEditorEditStyle result;
			if (context != null && context.Instance != null)
			{
				result = UITypeEditorEditStyle.Modal;
			}
			else
			{
				result = base.GetEditStyle(context);
			}
			return result;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000655C File Offset: 0x0000475C
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			int num;
			object result;
			int num9;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (context == null || context.Instance == null || provider == null)
				{
					goto IL_1B5;
				}
				IL_20:
				num2 = 4;
				string text = Application.ProductVersion.Replace(".", "");
				IL_38:
				num2 = 5;
				char value2 = '0';
				IL_3E:
				num2 = 6;
				char[] array = new char[1];
				IL_48:
				num2 = 7;
				string text2 = "";
				IL_51:
				num2 = 8;
				array[0] = '.';
				IL_59:
				num2 = 9;
				string[] array2 = null;
				IL_5F:
				num2 = 10;
				array2 = text.Split(new char[]
				{
					array[0]
				});
				IL_78:
				num2 = 11;
				int num3;
				if (!(array2[0].Length > 0 & num3 >= 0))
				{
					goto IL_F2;
				}
				IL_92:
				num2 = 12;
				array2[0] = o_O_o_oOoo__.OOOO_OO._oo.(array2[0]);
				IL_A2:
				num2 = 13;
				if (array2[0].Length <= num3)
				{
					goto IL_CC;
				}
				IL_B2:
				num2 = 14;
				text2 = Conversions.ToString(array2[0][num3]);
				goto IL_15D;
				IL_CC:
				num2 = 16;
				if (array2[0].Length != num3)
				{
					goto IL_EA;
				}
				IL_DC:
				num2 = 17;
				text2 = Conversions.ToString(value2);
				goto IL_15D;
				IL_EA:
				num2 = 19;
				text2 = null;
				goto IL_15D;
				IL_F2:
				num2 = 21;
				if (!(array2.Length > 1 & num3 < 0))
				{
					goto IL_143;
				}
				IL_104:
				num2 = 22;
				if (array2[1].Length < Math.Abs(num3))
				{
					goto IL_137;
				}
				IL_119:
				num2 = 23;
				text2 = Conversions.ToString(array2[1][Math.Abs(num3) - 1]);
				goto IL_15D;
				IL_137:
				num2 = 25;
				text2 = "0";
				goto IL_15D;
				IL_143:
				num2 = 27;
				if (num3 >= 0)
				{
					goto IL_157;
				}
				IL_14B:
				num2 = 28;
				text2 = "0";
				goto IL_15D;
				IL_157:
				num2 = 30;
				text2 = null;
				IL_15D:
				num2 = 31;
				num3 = 0;
				IL_163:
				num2 = 32;
				if (Operators.CompareString(text2, "", true) <= 0)
				{
					goto IL_1B5;
				}
				IL_176:
				num2 = 33;
				string text3 = text2;
				for (int i = 0; i < text3.Length; i = checked(i + 1))
				{
					string @string = Conversions.ToString(text3[i]);
					IL_192:
					num2 = 34;
					num3 += Strings.Asc(@string);
					IL_1A1:
					num2 = 35;
				}
				IL_1B5:
				num2 = 36;
				oO0oooo oO0oooo = null;
				IL_1BB:
				num2 = 37;
				string o_o_.0. = "";
				IL_1C5:
				num2 = 38;
				if (context != null && context.Instance != null && provider != null)
				{
					goto IL_1E0;
				}
				IL_1D6:
				num2 = 39;
				result = value;
				goto IL_D34;
				IL_1E0:
				num2 = 40;
				if (!(context.Instance is o_0oooo_OO))
				{
					goto IL_25F;
				}
				IL_1F0:
				num2 = 41;
				OoO0___o ooO0___o = (OoO0___o)Attribute.GetCustomAttribute(((o_0oooo_OO)context.Instance).Oo._o.().GetType(), typeof(OoO0___o), true);
				IL_21F:
				num2 = 42;
				if (!(((o_0oooo_OO)context.Instance).Oo._o.() is DataTableProperty))
				{
					goto IL_284;
				}
				IL_239:
				num2 = 43;
				o_o_.0. = ((DataTableProperty)((o_0oooo_OO)context.Instance).Oo._o.()).o__.0ooOOoo0o..Name;
				goto IL_284;
				IL_25F:
				num2 = 45;
				ooO0___o = (OoO0___o)Attribute.GetCustomAttribute(context.Instance.GetType(), typeof(OoO0___o), true);
				IL_284:
				num2 = 46;
				if (context.PropertyDescriptor.Attributes[typeof(oO0oooo)] == null)
				{
					goto IL_2C7;
				}
				IL_2A3:
				num2 = 47;
				oO0oooo = (oO0oooo)context.PropertyDescriptor.Attributes[typeof(oO0oooo)];
				IL_2C7:
				num2 = 48;
				if (oO0oooo != null)
				{
					goto IL_334;
				}
				IL_2CE:
				num2 = 49;
				if (!(context.Instance is o_0oooo_OO))
				{
					goto IL_30F;
				}
				IL_2DE:
				num2 = 50;
				oO0oooo = (oO0oooo)Attribute.GetCustomAttribute(((o_0oooo_OO)context.Instance).Oo._o.().GetType(), typeof(oO0oooo), true);
				goto IL_334;
				IL_30F:
				num2 = 52;
				oO0oooo = (oO0oooo)Attribute.GetCustomAttribute(context.Instance.GetType(), typeof(oO0oooo), true);
				IL_334:
				num2 = 53;
				this.Oo.0OO_. = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				IL_352:
				num2 = 54;
				if (this.Oo.0OO_. != null)
				{
					goto IL_367;
				}
				IL_35D:
				num2 = 55;
				result = value;
				goto IL_D34;
				IL_367:
				num2 = 56;
				if (ooO0___o != null)
				{
					goto IL_392;
				}
				IL_36E:
				num2 = 57;
				this.oO0OOO.0O. = new O\u3000\u3002\u3000\u3000("", context.PropertyDescriptor.Name, null);
				goto IL_464;
				IL_392:
				num2 = 59;
				string text4 = "";
				IL_39C:
				num2 = 60;
				if (Operators.CompareString(ooO0___o.oO0OOO.0O.(), "Control", true) != 0)
				{
					goto IL_406;
				}
				IL_3B3:
				num2 = 61;
				text4 = ((o_0oooo_OO)context.Instance).Oo._o.().GetType().Name;
				IL_3D2:
				num2 = 62;
				if (!text4.EndsWith("Property", StringComparison.CurrentCultureIgnoreCase))
				{
					goto IL_442;
				}
				IL_3E4:
				num2 = 63;
				text4 = "WinForm." + text4.Substring(0, text4.Length - 8);
				goto IL_442;
				IL_406:
				num2 = 65;
				if (Operators.CompareString(ooO0___o.oO0OOO.0O.(), "Form", true) != 0)
				{
					goto IL_442;
				}
				IL_41D:
				num2 = 66;
				if (Operators.CompareString(context.PropertyDescriptor.Category, "全局事件", true) != 0)
				{
					goto IL_442;
				}
				IL_438:
				num2 = 67;
				text4 = "WinForm.Control";
				IL_442:
				num2 = 68;
				this.oO0OOO.0O. = new O\u3000\u3002\u3000\u3000(ooO0___o.oO0OOO.0O.(), context.PropertyDescriptor.Name, text4);
				IL_464:
				num2 = 69;
				if (value == null)
				{
					goto IL_93C;
				}
				IL_46D:
				num2 = 70;
				EventString eventString = (EventString)value;
				IL_478:
				num2 = 71;
				if (eventString.Count <= 0)
				{
					goto IL_93C;
				}
				IL_488:
				num2 = 72;
				if (eventString[0].Length >= 469 && Main.OO_O.o..oOO0.OOoo0oO. != BooleanEnum.True)
				{
					goto IL_4C7;
				}
				IL_4AC:
				num2 = 73;
				this.oO0OOO.0O..O0O0.0__o0.(eventString[0]);
				goto IL_93C;
				IL_4C7:
				num2 = 75;
				this.Oo.0OO_. = this.Oo.0OO_..TrimEnd(new char[]
				{
					'.'
				});
				IL_4E6:
				num2 = 76;
				if (Versioned.IsNumeric(this.Oo.0OO_.))
				{
					goto IL_504;
				}
				IL_4F6:
				num2 = 77;
				this.oO_.O0____. = "web";
				IL_504:
				num2 = 78;
				if (Conversion.Val(this.Oo.0OO_.) != 0.0)
				{
					goto IL_52B;
				}
				IL_51D:
				num2 = 79;
				this.oO_.O0____. = "http";
				IL_52B:
				num2 = 80;
				if (Operators.CompareString(this.oO_.O0____., "", true) != 0)
				{
					goto IL_86F;
				}
				IL_544:
				num2 = 81;
				this.oO0OOO.0O. = (long)((int)Math.Floor(Conversion.Val(this.Oo.0OO_.)));
				IL_55F:
				num2 = 82;
				if (this.Oo.0OO_..IndexOf(".") < 0)
				{
					goto IL_598;
				}
				IL_575:
				num2 = 83;
				this.O00o_0O._O. = this.Oo.0OO_..Substring(this.Oo.0OO_..IndexOf('.') + 1);
				IL_598:
				num2 = 84;
				if (this.oO0OOO.0O. <= 0L)
				{
					goto IL_78B;
				}
				IL_5A8:
				num2 = 85;
				if (this.oO0OOO.0O. != 0L)
				{
					goto IL_5C6;
				}
				IL_5B3:
				num2 = 86;
				this.oO_.O0____. = "ssl";
				goto IL_78B;
				IL_5C6:
				num2 = 88;
				this.Oo.0OO_. = this.oO0OOO.0O..ToString();
				IL_5DA:
				num2 = 89;
				int num4 = 1;
				do
				{
					IL_5E0:
					num2 = 90;
					this.o_.O. = Strings.Right(this.Oo.0OO_., 4);
					IL_5F5:
					num2 = 91;
					this.oO0OOO.0O. = long.Parse(this.o_.O.);
					IL_609:
					num2 = 92;
					this.o_.O. = this.oO0OOO.0O..ToString();
					IL_61D:
					num2 = 93;
					if (num4 == 1)
					{
						IL_625:
						num2 = 94;
						this.oO0_O0O.___OO. = this.o_.O.;
					}
					else
					{
						IL_639:
						num2 = 96;
						if (this.oO0OOO.0O. > 0L)
						{
							IL_646:
							num2 = 97;
							this.O.o0o_o_oO. = this.o_.O. + Conversions.ToString(this.O_O.___0_.[num4 - 2]);
						}
						IL_66E:
						num2 = 98;
						if (Operators.CompareString(this.oO0_O0O.___OO., "", true) > 0)
						{
							IL_685:
							num2 = 99;
							if (this.oO0OOO.0O. == 0L || this.Oo0O_0o.o_O..Length < 4 || this.o_.O..EndsWith("0"))
							{
								IL_6B0:
								num2 = 100;
								this.oO0_O0O.___OO. = this.O.o0o_o_oO. + "z" + this.oO0_O0O.___OO.;
							}
							else
							{
								IL_6D1:
								num2 = 102;
								this.oO0_O0O.___OO. = this.O.o0o_o_oO. + this.oO0_O0O.___OO.;
							}
						}
						else
						{
							IL_6ED:
							num2 = 104;
							this.oO0_O0O.___OO. = this.O.o0o_o_oO.;
						}
					}
					IL_6FC:
					num2 = 105;
					this.Oo0O_0o.o_O. = this.o_.O.;
					IL_70B:
					num2 = 106;
					if (this.Oo.0OO_..Length <= 4)
					{
						break;
					}
					IL_71C:
					num2 = 109;
					this.Oo.0OO_. = this.Oo.0OO_..Substring(0, this.Oo.0OO_..Length - 4);
					IL_73E:
					num2 = 110;
					num4++;
				}
				while (num4 <= 4);
				IL_74F:
				num2 = 111;
				this.oO0_O0O.___OO. = this.oO0_O0O.___OO..Replace("ftp", "");
				IL_76D:
				num2 = 112;
				this.oO0_O0O.___OO. = this.oO0_O0O.___OO..Replace("http", "d");
				IL_78B:
				num2 = 113;
				if (Operators.CompareString(this.O00o_0O._O., "", true) <= 0)
				{
					goto IL_85E;
				}
				IL_7A5:
				num2 = 114;
				if (Operators.CompareString(this.oO0_O0O.___OO., "", true) != 0)
				{
					goto IL_7CB;
				}
				IL_7BB:
				num2 = 115;
				this.oO0_O0O.___OO. = "https";
				goto IL_7E4;
				IL_7CB:
				num2 = 117;
				this.oO0_O0O.___OO. += "sll";
				IL_7E4:
				num2 = 118;
				int num5 = this.O00o_0O._O..Length - this.O00o_0O._O..TrimStart(new char[]
				{
					'0'
				}).Length;
				IL_810:
				num2 = 119;
				if (num5 <= 0)
				{
					goto IL_83A;
				}
				IL_818:
				num2 = 120;
				this.oO0_O0O.___OO. += "w".PadLeft(num5, 'w');
				IL_83A:
				num2 = 121;
				this.oO0_O0O.___OO. += Conversions.ToString(Conversions.ToInteger(this.O00o_0O._O.));
				IL_85E:
				num2 = 122;
				this.oO_.O0____. = this.oO0_O0O.___OO.;
				goto IL_87E;
				IL_86F:
				num2 = 124;
				this.oO_.O0____. = this.oO0_O0O.___OO.;
				IL_87E:
				num2 = 125;
				string[] array3 = eventString[0].Split(new char[]
				{
					'\r',
					'\n'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_8A1:
				num2 = 126;
				string text5 = "";
				IL_8AB:
				num2 = 127;
				int num6 = array3.Length - 1;
				for (int j = 0; j <= num6; j++)
				{
					IL_8BB:
					num2 = 128;
					if (j % (this.oO__O.0o__0..Length + this.O_O.___0_..Length) == this.O_O.___0_..Length)
					{
						IL_8E8:
						num2 = 129;
						text5 += "\r\n";
					}
					else
					{
						IL_8FE:
						num2 = 131;
						text5 = text5 + array3[j] + "\r\n";
					}
					IL_917:
					num2 = 132;
				}
				IL_929:
				num2 = 133;
				this.oO0OOO.0O..O0O0.0__o0.(text5);
				IL_93C:
				num2 = 134;
				if (oO0oooo == null)
				{
					goto IL_963;
				}
				IL_946:
				num2 = 135;
				this.oO0OOO.0O..O.O_0o_Oo_.().oo.O0ooOo00_0.(oO0oooo.ooo_0.o.());
				IL_963:
				num2 = 136;
				if (!(context.Instance is o_0oooo_OO))
				{
					goto IL_9BF;
				}
				IL_976:
				num2 = 137;
				o_0oooo_OO o_0oooo_OO = (o_0oooo_OO)context.Instance;
				IL_989:
				num2 = 138;
				if (!(o_0oooo_OO.Oo._o.() is TopicBarProperty))
				{
					goto IL_9BF;
				}
				IL_99D:
				num2 = 139;
				this.oO0OOO.0O..O0o__._oo0oo_. = ((TopicBarProperty)o_0oooo_OO.Oo._o.()).O._oooo0__.;
				IL_9BF:
				num2 = 140;
				string strB = "";
				IL_9CC:
				num2 = 141;
				if (value == null)
				{
					goto IL_A34;
				}
				IL_9D5:
				num2 = 142;
				eventString = (EventString)value;
				IL_9E3:
				num2 = 143;
				if (eventString.Count <= 0)
				{
					goto IL_A34;
				}
				IL_9F3:
				num2 = 144;
				if (!string.IsNullOrEmpty(this.oO0OOO.0O..O.O_0o_Oo_.()))
				{
					goto IL_A24;
				}
				IL_A0B:
				num2 = 145;
				this.oO0OOO.0O..O0O0.0__o0.(eventString[0]);
				IL_A24:
				num2 = 146;
				strB = eventString[0];
				IL_A34:
				num2 = 147;
				this.oO0OOO.0O..O_o_.0. = o_o_.0.;
				IL_A47:
				num2 = 148;
				if (this.oO0OOO.0O..ShowDialog() != DialogResult.OK)
				{
					goto IL_AEC;
				}
				IL_A5E:
				num2 = 149;
				if (Operators.CompareString(this.oO0OOO.0O..O.O_0o_Oo_.(), "", true) <= 0)
				{
					goto IL_AE2;
				}
				IL_A7D:
				num2 = 150;
				if (string.Compare(this.oO0OOO.0O..O.O_0o_Oo_.(), strB, false) != 0)
				{
					goto IL_AA7;
				}
				IL_A98:
				num2 = 151;
				result = RuntimeHelpers.GetObjectValue(value);
				goto IL_AF9;
				IL_AA7:
				num2 = 153;
				string value3 = this.oO0OOO.0O..O.O_0o_Oo_.();
				IL_ABA:
				num2 = 154;
				eventString = new EventString();
				IL_AC7:
				num2 = 155;
				eventString.Add(value3);
				IL_AD7:
				num2 = 156;
				result = eventString;
				goto IL_AF9;
				IL_AE2:
				num2 = 158;
				result = null;
				goto IL_AF9;
				IL_AEC:
				num2 = 160;
				result = RuntimeHelpers.GetObjectValue(value);
				IL_AF9:
				num2 = 161;
				this.oO0OOO.0O..O0o__._oo0oo_. = null;
				IL_B0B:
				num2 = 162;
				this.oO0OOO.0O..Dispose();
				IL_B1C:
				num2 = 163;
				this.oO0OOO.0O. = null;
				IL_B29:
				num2 = 164;
				if (context == null || context.Instance == null || provider == null)
				{
					goto IL_D34;
				}
				IL_B46:
				num2 = 166;
				string text6 = Application.ProductVersion.Replace(".", "");
				IL_B62:
				num2 = 167;
				char value4 = '0';
				IL_B6C:
				num2 = 168;
				char[] array4 = new char[1];
				IL_B7A:
				num2 = 169;
				string text7 = "";
				IL_B87:
				num2 = 170;
				array4[0] = '.';
				IL_B93:
				num2 = 171;
				string[] array5 = null;
				IL_B9C:
				num2 = 172;
				array5 = text6.Split(new char[]
				{
					array4[0]
				});
				IL_BB8:
				num2 = 173;
				int num7;
				if (!(array5[0].Length > 0 & num7 >= 0))
				{
					goto IL_C4D;
				}
				IL_BD5:
				num2 = 174;
				array5[0] = o_O_o_oOoo__.OOOO_OO._oo.(array5[0]);
				IL_BE8:
				num2 = 175;
				if (array5[0].Length <= num7)
				{
					goto IL_C18;
				}
				IL_BFB:
				num2 = 176;
				text7 = Conversions.ToString(array5[0][num7]);
				goto IL_CCD;
				IL_C18:
				num2 = 178;
				if (array5[0].Length != num7)
				{
					goto IL_C3F;
				}
				IL_C2B:
				num2 = 179;
				text7 = Conversions.ToString(value4);
				goto IL_CCD;
				IL_C3F:
				num2 = 181;
				text7 = null;
				goto IL_CCD;
				IL_C4D:
				num2 = 183;
				if (!(array5.Length > 1 & num7 < 0))
				{
					goto IL_CAA;
				}
				IL_C62:
				num2 = 184;
				if (array5[1].Length < Math.Abs(num7))
				{
					goto IL_C9B;
				}
				IL_C7A:
				num2 = 185;
				text7 = Conversions.ToString(array5[1][Math.Abs(num7) - 1]);
				goto IL_CCD;
				IL_C9B:
				num2 = 187;
				text7 = "0";
				goto IL_CCD;
				IL_CAA:
				num2 = 189;
				if (num7 >= 0)
				{
					goto IL_CC4;
				}
				IL_CB5:
				num2 = 190;
				text7 = "0";
				goto IL_CCD;
				IL_CC4:
				num2 = 192;
				text7 = null;
				IL_CCD:
				num2 = 193;
				num7 = 0;
				IL_CD6:
				num2 = 194;
				if (Operators.CompareString(text7, "", true) <= 0)
				{
					goto IL_D34;
				}
				IL_CEC:
				num2 = 195;
				string text8 = text7;
				for (int k = 0; k < text8.Length; k = checked(k + 1))
				{
					string string2 = Conversions.ToString(text8[k]);
					IL_D0B:
					num2 = 196;
					num7 += Strings.Asc(string2);
					IL_D1D:
					num2 = 197;
				}
				IL_D34:
				goto IL_109E;
				IL_D39:
				int num8 = num9 + 1;
				num9 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8);
				IL_105F:
				goto IL_1093;
				IL_1061:
				num9 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1071:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num9 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1061;
			}
			IL_1093:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_109E:
			if (num9 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0400006D RID: 109
		private IWindowsFormsEditorService <<EMPTY_NAME>>;

		// Token: 0x0400006E RID: 110
		private O\u3000\u3002\u3000\u3000 <<EMPTY_NAME>>;

		// Token: 0x0400006F RID: 111
		private string <<EMPTY_NAME>>;

		// Token: 0x04000070 RID: 112
		private readonly string <<EMPTY_NAME>>;

		// Token: 0x04000071 RID: 113
		private long <<EMPTY_NAME>>;

		// Token: 0x04000072 RID: 114
		private string <<EMPTY_NAME>>;

		// Token: 0x04000073 RID: 115
		private string <<EMPTY_NAME>>;

		// Token: 0x04000074 RID: 116
		private string <<EMPTY_NAME>>;

		// Token: 0x04000075 RID: 117
		private string <<EMPTY_NAME>>;

		// Token: 0x04000076 RID: 118
		private string <<EMPTY_NAME>>;

		// Token: 0x04000077 RID: 119
		private string <<EMPTY_NAME>>;

		// Token: 0x04000078 RID: 120
		private readonly string <<EMPTY_NAME>>;
	}
}
