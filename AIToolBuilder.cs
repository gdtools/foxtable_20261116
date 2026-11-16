using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Foxtable
{
	// Token: 0x020001E5 RID: 485
	public class AIToolBuilder : Dictionary<string, AITool>
	{
		// Token: 0x0600183A RID: 6202 RVA: 0x000AC1C6 File Offset: 0x000AA3C6
		public AIToolBuilder()
		{
			this.JsonTools = new List<JObject>();
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x000AC1D9 File Offset: 0x000AA3D9
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x000AC1E1 File Offset: 0x000AA3E1
		internal List<JObject> JsonTools { get; set; }

		// Token: 0x0600183D RID: 6205 RVA: 0x000AC1EC File Offset: 0x000AA3EC
		public AITool AddFunction(string name, string description)
		{
			AITool aitool = new AITool
			{
				Name = name,
				Description = description
			};
			base[name] = aitool;
			return aitool;
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x000AC218 File Offset: 0x000AA418
		public JArray Build()
		{
			JArray jarray = new JArray();
			try
			{
				foreach (string key in base.Keys)
				{
					AITool aitool = base[key];
					JObject jobject = new JObject();
					jobject["type"] = "function";
					JObject jobject2 = new JObject();
					jobject2["name"] = aitool.Name;
					jobject2["description"] = aitool.Description;
					JObject jobject3 = new JObject();
					jobject3["type"] = "object";
					JObject jobject4 = new JObject();
					List<string> list = new List<string>();
					try
					{
						foreach (AIParameter aiparameter in aitool.Parameters)
						{
							string text = aiparameter.Name;
							JObject jobject5 = new JObject();
							jobject5["type"] = aiparameter.Type;
							if (!string.IsNullOrEmpty(aiparameter.Description))
							{
								jobject5["description"] = aiparameter.Description;
							}
							if (Operators.CompareString(aiparameter.Type, "array", true) == 0)
							{
								JObject jobject6 = new JObject();
								jobject6["type"] = aiparameter.ArrayItemType;
								jobject5["items"] = jobject6;
							}
							if (aiparameter.EnumValues != null)
							{
								JArray jarray2 = new JArray();
								string text2 = aiparameter.Type;
								if (Operators.CompareString(aiparameter.Type, "array", true) == 0)
								{
									text2 = aiparameter.ArrayItemType;
								}
								try
								{
									foreach (object obj in aiparameter.EnumValues)
									{
										object objectValue = RuntimeHelpers.GetObjectValue(obj);
										if (objectValue != null)
										{
											string left = text2;
											if (Operators.CompareString(left, "string", true) == 0)
											{
												jarray2.Add(objectValue.ToString());
											}
											else if (Operators.CompareString(left, "number", true) == 0)
											{
												double value;
												if (double.TryParse(objectValue.ToString(), out value))
												{
													jarray2.Add(value);
												}
											}
											else if (Operators.CompareString(left, "integer", true) == 0)
											{
												int value2;
												if (int.TryParse(objectValue.ToString(), out value2))
												{
													jarray2.Add(value2);
												}
											}
											else if (Operators.CompareString(left, "boolean", true) == 0)
											{
												bool value3;
												if (bool.TryParse(objectValue.ToString(), out value3))
												{
													jarray2.Add(value3);
												}
											}
											else
											{
												jarray2.Add(RuntimeHelpers.GetObjectValue(objectValue));
											}
										}
									}
								}
								finally
								{
									IEnumerator<object> enumerator3;
									if (enumerator3 != null)
									{
										enumerator3.Dispose();
									}
								}
								if (jarray2.Count > 0)
								{
									if (Operators.CompareString(aiparameter.Type, "array", true) == 0)
									{
										jobject5["items"]["enum"] = jarray2;
									}
									else
									{
										jobject5["enum"] = jarray2;
									}
								}
							}
							jobject4[text] = jobject5;
							if (aiparameter.IsRequired)
							{
								list.Add(text);
							}
						}
					}
					finally
					{
						List<AIParameter>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					jobject3["properties"] = jobject4;
					if (list.Count > 0)
					{
						JArray jarray3 = new JArray();
						try
						{
							foreach (string value4 in list)
							{
								jarray3.Add(value4);
							}
						}
						finally
						{
							List<string>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
						jobject3["required"] = jarray3;
					}
					else
					{
						jobject3["required"] = new JArray();
					}
					jobject2["parameters"] = jobject3;
					jobject["function"] = jobject2;
					jarray.Add(jobject);
				}
			}
			finally
			{
				Dictionary<string, AITool>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (JObject item in this.JsonTools)
				{
					jarray.Add(item);
				}
			}
			finally
			{
				List<JObject>.Enumerator enumerator5;
				((IDisposable)enumerator5).Dispose();
			}
			return jarray;
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x000AC6A8 File Offset: 0x000AA8A8
		public JArray BuildMCP()
		{
			JArray jarray = this.Build();
			JArray jarray2 = new JArray();
			try
			{
				foreach (JToken jtoken in jarray)
				{
					JObject jobject = jtoken["function"] as JObject;
					JObject jobject2 = new JObject();
					jobject2["name"] = jobject["name"];
					jobject2["description"] = ((jobject["description"] == null) ? "" : jobject["description"].ToString());
					JObject jobject3 = jobject2;
					string propertyName = "inputSchema";
					JToken value;
					if (jobject["parameters"] == null)
					{
						JObject jobject4 = new JObject();
						jobject4.Add("type", "object");
						value = jobject4;
						jobject4.Add("properties", new JObject());
					}
					else
					{
						value = jobject["parameters"].DeepClone();
					}
					jobject3[propertyName] = value;
					jarray2.Add(jobject2);
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
			return jarray2;
		}

		// Token: 0x040009AB RID: 2475
		[CompilerGenerated]
		private List<JObject> a;
	}
}
