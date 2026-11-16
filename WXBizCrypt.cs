using System;
using Tencent;

namespace Foxtable
{
	// Token: 0x02000206 RID: 518
	public class WXBizCrypt
	{
		// Token: 0x0600199C RID: 6556 RVA: 0x000B71F2 File Offset: 0x000B53F2
		public WXBizCrypt(string A_0, string A_1, string A_2)
		{
			this.o_.o_o_O000_0_. = A_0;
			this.OoOoo_o_.o_. = A_1;
			this.oO_0oo.0oo__0_. = A_2;
			this.O0O00.0Oo00. = new WXBizMsgCrypt(A_1, A_2, A_0);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000B7220 File Offset: 0x000B5420
		public string EncryptMsg(RequestEventArgs e, string sRespData)
		{
			string text = "";
			string sTimeStamp = e.GetValues["timestamp"];
			string sNonce = e.GetValues["nonce"];
			int num = this.O0O00.0Oo00..EncryptMsg(sRespData, sTimeStamp, sNonce, ref text);
			string result;
			if (num == 0)
			{
				result = text;
			}
			else
			{
				result = num.ToString();
			}
			return result;
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000B7278 File Offset: 0x000B5478
		public string DecryptMsg(RequestEventArgs e)
		{
			string text = "";
			string sMsgSignature = e.GetValues["msg_signature"];
			string sTimeStamp = e.GetValues["timestamp"];
			string sNonce = e.GetValues["nonce"];
			int num = this.O0O00.0Oo00..DecryptMsg(sMsgSignature, sTimeStamp, sNonce, e.PlainText, ref text);
			string result;
			if (num == 0)
			{
				result = text;
			}
			else
			{
				result = num.ToString();
			}
			return result;
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x000B72EC File Offset: 0x000B54EC
		public int CheckQYSignature(RequestEventArgs e)
		{
			string value = "";
			string sMsgSignature = e.GetValues["msg_signature"];
			string sTimeStamp = e.GetValues["timestamp"];
			string sNonce = e.GetValues["nonce"];
			string sEchoStr = e.GetValues["echostr"];
			int num = this.O0O00.0Oo00..VerifyURL(sMsgSignature, sTimeStamp, sNonce, sEchoStr, ref value);
			if (num == 0)
			{
				e.WriteString(value);
			}
			return num;
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x000B7360 File Offset: 0x000B5560
		public static string GetErorDesc(int value)
		{
			string result;
			switch (value)
			{
			case -40010:
				result = "base64解密异常";
				break;
			case -40009:
				result = "base64加密异常";
				break;
			case -40008:
				result = "解密后得到的buffer非法";
				break;
			case -40007:
				result = "AES 解密失败";
				break;
			case -40006:
				result = "AES 加密失败";
				break;
			case -40005:
				result = "corpid/appid 校验错误";
				break;
			case -40004:
				result = "AESKey 非法";
				break;
			case -40003:
				result = "sha加密生成签名失败";
				break;
			case -40002:
				result = "xml解析失败";
				break;
			default:
				if (value == 0)
				{
					result = "签名验证成功。";
				}
				else
				{
					result = "未知错误";
				}
				break;
			}
			return result;
		}

		// Token: 0x04000AA6 RID: 2726
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AA7 RID: 2727
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AA8 RID: 2728
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AA9 RID: 2729
		private WXBizMsgCrypt <<EMPTY_NAME>>;
	}
}
