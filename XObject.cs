using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Foxtable
{
	// Token: 0x0200023C RID: 572
	[oO0oooo("A0171")]
	public class XObject : JObject
	{
		// Token: 0x06001B50 RID: 6992 RVA: 0x000C0158 File Offset: 0x000BE358
		public XObject()
		{
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x000C0160 File Offset: 0x000BE360
		private XObject(string A_0)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(A_0);
			JObject jobject = JObject.Parse(JsonConvert.SerializeXmlNode(xmlDocument.DocumentElement, Newtonsoft.Json.Formatting.None, true));
			try
			{
				foreach (JToken jtoken in jobject.Children())
				{
					JTokenType type = jtoken.Type;
					if (type - JTokenType.Object <= 1 || type == JTokenType.Property)
					{
						this.Ooo_O__.0.(jtoken);
					}
				}
			}
			finally
			{
				IEnumerator<JToken> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			base.Merge(jobject);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x000C01F0 File Offset: 0x000BE3F0
		private void <<EMPTY_NAME>>(JToken A_0)
		{
			if (A_0 is JArray || A_0 is JObject)
			{
				try
				{
					foreach (JToken a_ in A_0.Children())
					{
						this.Ooo_O__.0.(a_);
					}
					return;
				}
				finally
				{
					IEnumerator<JToken> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			if (A_0 is JProperty)
			{
				JProperty jproperty = (JProperty)A_0;
				if (jproperty.Value.Type == JTokenType.Object && jproperty.Value["#cdata-section"] != null)
				{
					jproperty.Parent[jproperty.Name] = jproperty.Value["#cdata-section"].ToString();
					return;
				}
				if (jproperty.Value.Type == JTokenType.Array || jproperty.Value.Type == JTokenType.Object)
				{
					try
					{
						foreach (JToken a_2 in jproperty.Value.Children())
						{
							this.Ooo_O__.0.(a_2);
						}
					}
					finally
					{
						IEnumerator<JToken> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
			}
		}

		/// <summary>
		/// 增加CDATA结点
		/// </summary>
		/// <param name="Key">结点名称</param>
		/// <param name="Value">结点值</param>
		/// <returns></returns>
		// Token: 0x06001B53 RID: 6995 RVA: 0x000C031C File Offset: 0x000BE51C
		[oO0oooo("A0173")]
		public JToken AddCData(string Key, string Value)
		{
			JObject jobject = new JObject();
			jobject["#cdata-section"] = Value;
			this[Key] = jobject;
			return jobject;
		}

		/// <summary>
		/// 生成XML
		/// </summary>
		/// <returns></returns>
		// Token: 0x06001B54 RID: 6996 RVA: 0x000C0349 File Offset: 0x000BE549
		[oO0oooo("A0172")]
		public string ToXML()
		{
			JObject jobject = new JObject();
			jobject["xml"] = this;
			return JsonConvert.DeserializeXmlNode(jobject.ToString()).InnerXml;
		}

		/// <summary>
		/// 解析XML
		/// </summary>
		/// <param name="XML"></param>
		/// <returns></returns>
		// Token: 0x06001B55 RID: 6997 RVA: 0x000C036B File Offset: 0x000BE56B
		[oO0oooo("A0171")]
		public new static XObject Parse(string XML)
		{
			return new XObject(XML);
		}

		// Token: 0x170005CF RID: 1487
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new JToken this[string key]
		{
			get
			{
				JToken jtoken = base[key];
				JToken result;
				if (jtoken is JObject && jtoken["#cdata-section"] != null)
				{
					result = jtoken["#cdata-section"];
				}
				else
				{
					result = jtoken;
				}
				return result;
			}
			set
			{
				JToken jtoken = base[key];
				if (!(jtoken is JObject))
				{
					base[key] = value;
					return;
				}
				if (jtoken["#cdata-section"] != null)
				{
					jtoken["#cdata-section"] = value;
					return;
				}
				base[key] = value;
			}
		}
	}
}
