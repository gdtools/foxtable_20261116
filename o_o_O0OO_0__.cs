using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Foxtable.My;
using Foxtable.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200044D RID: 1101
	[StandardModule]
	internal sealed class o_o_O0OO_0__
	{
		// Token: 0x06004A3A RID: 19002
		[DllImport("Foxtable.IO.dll")]
		private static extern int MD5Encrypt(string A_0, StringBuilder A_1, int A_2);

		// Token: 0x06004A3B RID: 19003
		[DllImport("Foxtable.IO.dll")]
		private static extern int GetDllVersion(string A_0);

		// Token: 0x06004A3C RID: 19004 RVA: 0x0020D83F File Offset: 0x0020BA3F
		internal static string <<EMPTY_NAME>>()
		{
			return o_o_O0OO_0__.o000oOoo.0.;
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x0020D846 File Offset: 0x0020BA46
		internal static string <<EMPTY_NAME>>()
		{
			return o_o_O0OO_0__.O00_._o_O0_.;
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x0020D84D File Offset: 0x0020BA4D
		internal static string <<EMPTY_NAME>>()
		{
			return o_o_O0OO_0__.oOO.___0_0OO.;
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x0020D854 File Offset: 0x0020BA54
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			StringBuilder stringBuilder = new StringBuilder(100);
			int length = A_0.Length;
			string result;
			if (o_o_O0OO_0__.MD5Encrypt(A_0, stringBuilder, length) == 1)
			{
				result = stringBuilder.ToString().Trim();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x0020D88C File Offset: 0x0020BA8C
		internal static string <<EMPTY_NAME>>()
		{
			string[] array = new string[3];
			string result;
			if (Operators.CompareString(o_o_O0OO_0__.o_oOo_O_._., "", true) > 0)
			{
				result = o_o_O0OO_0__.o_oOo_O_._.;
			}
			else
			{
				if (!OO_00oOO.HardWareInfo.Ready)
				{
					OO_00oOO.HardWareInfo.initialize();
				}
				else
				{
					while (!OO_00oOO.HardWareInfo.ok)
					{
						Thread.Sleep(100);
					}
				}
				array[0] = OO_00oOO.HardWareInfo.CPU.Name + OO_00oOO.HardWareInfo.CPU.ProcessorId;
				array[1] = OO_00oOO.HardWareInfo.BaseBoard.Product + OO_00oOO.HardWareInfo.BaseBoard.SerialNumber;
				array[2] = OO_00oOO.HardWareInfo.Disk.Model + OO_00oOO.HardWareInfo.Disk.Signature;
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array[i] = O00.MD5Encrypt(array[i]);
					o_o_O0OO_0__.o_oOo_O_._. += array[i].Substring(0, 4).ToUpper();
				}
				o_o_O0OO_0__.o_oOo_O_._..Replace("O", "0");
				result = o_o_O0OO_0__.o_oOo_O_._.;
			}
			return result;
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x0020D9B4 File Offset: 0x0020BBB4
		internal static string <<EMPTY_NAME>>()
		{
			string o_0.o_0oo__0o.;
			if (Operators.CompareString(o_o_O0OO_0__.O_0.o_0oo__0o., "", true) > 0)
			{
				o_0.o_0oo__0o. = o_o_O0OO_0__.O_0.o_0oo__0o.;
			}
			else
			{
				string[] array = new string[7];
				string str = "";
				string str2 = "";
				o0OO__.oOO.o_.(ref str, ref str2);
				if (!OO_00oOO.HardWareInfo.Ready)
				{
					OO_00oOO.HardWareInfo.initialize();
				}
				else
				{
					while (!OO_00oOO.HardWareInfo.ok)
					{
						Thread.Sleep(100);
					}
				}
				array[0] = o_O_o_oOoo__.OOOO_OO._oo.(OO_00oOO.HardWareInfo.CPU.Name + OO_00oOO.HardWareInfo.CPU.ProcessorId);
				array[1] = OO_00oOO.HardWareInfo.BaseBoard.Product + OO_00oOO.HardWareInfo.BaseBoard.SerialNumber;
				array[2] = o_O_o_oOoo__.OOOO_OO._oo.(OO_00oOO.HardWareInfo.Bios.Manufacturer + OO_00oOO.HardWareInfo.Bios.SerialNumber);
				array[3] = Strings.Left(str, 4);
				array[4] = Strings.Right(str, 4);
				array[5] = Strings.Left(str2, 4);
				array[6] = Strings.Right(str2, 4);
				int num = 0;
				do
				{
					array[num] = O00.MD5Encrypt(O00.EncryptText(array[num], "dr", "xy"));
					int num2 = Math.Min(3, array[num].Length - 1);
					for (int i = 0; i <= num2; i++)
					{
						o_o_O0OO_0__.O_0.o_0oo__0o. += Conversions.ToString(Strings.Asc(array[num][i]) % 10);
					}
					num++;
				}
				while (num <= 2);
				if (!o0OO__.Oo_o.O_ooo.())
				{
					array[5] = "0000";
					array[6] = "0000";
				}
				int num3 = 3;
				do
				{
					o_o_O0OO_0__.O_0.o_0oo__0o. += array[num3];
					num3++;
				}
				while (num3 <= 6);
				o_0.o_0oo__0o. = o_o_O0OO_0__.O_0.o_0oo__0o.;
			}
			return o_0.o_0oo__0o.;
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x0020DB80 File Offset: 0x0020BD80
		internal static string <<EMPTY_NAME>>()
		{
			int num = Conversions.ToInteger(c.OOOOO.o.().Registry.GetValue("HKEY_CURRENT_USER\\Software\\FoxTable", "RegisterCode", 1));
			num = (Math.Min(Math.Max(1, num), 3) - 1) * 50;
			string result;
			if (Operators.CompareString(o0OO__.OO0oO.o.(num, 1, false), "Y", true) == 0)
			{
				result = o0OO__.OO0oO.o.(num + 1, 36, false);
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x0020DBEF File Offset: 0x0020BDEF
		internal static bool <<EMPTY_NAME>>()
		{
			o0OO__.O_0_O0_OO.0Ooo.();
			return new O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000().ShowDialog() == DialogResult.OK;
		}

		// Token: 0x04001E24 RID: 7716
		private static string <<EMPTY_NAME>> = O00.oO_.0o_oo_0O_.(Foxtable.My.Resources.a.Oo_.__Ooo.(), "microsoft", "egridsoft") + Strings.Left(O00.ooo000o_0.00o0.(o_o_O0OO_0__.oo00_.0oO_.(), "foxtable", o_o_O0OO_0__.oo00_.0oO_.()).Replace("/", ""), 12);

		// Token: 0x04001E25 RID: 7717
		private static string <<EMPTY_NAME>> = O00.ooo000o_0.00o0.(o_o_O0OO_0__.o000oOoo.0., "foxsoft", o_o_O0OO_0__.oo00_.0oO_.()).Substring(0, 12);

		// Token: 0x04001E26 RID: 7718
		private static string <<EMPTY_NAME>> = O00.ooo000o_0.00o0.(o_o_O0OO_0__.o000oOoo.0., "egridsoft", o_o_O0OO_0__.oo00_.0oO_.()).Substring(0, 12);

		// Token: 0x04001E27 RID: 7719
		private static string <<EMPTY_NAME>>;

		// Token: 0x04001E28 RID: 7720
		private static string <<EMPTY_NAME>>;
	}
}
