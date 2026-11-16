using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Foxtable
{
	// Token: 0x020001ED RID: 493
	public class LLMCaller
	{
		// Token: 0x06001872 RID: 6258 RVA: 0x000ACED0 File Offset: 0x000AB0D0
		public LLMCaller()
		{
			this.KeepToolCallsInHistory = new bool?(true);
			this.MaxToolSteps = 10;
			this.PrefixKey = "prefix";
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x000ACEF7 File Offset: 0x000AB0F7
		public LLMCaller(string A_0)
		{
			this.KeepToolCallsInHistory = new bool?(true);
			this.MaxToolSteps = 10;
			this.PrefixKey = "prefix";
			this.BaseUrl = A_0;
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x000ACF25 File Offset: 0x000AB125
		public LLMCaller(string A_0, string A_1)
		{
			this.KeepToolCallsInHistory = new bool?(true);
			this.MaxToolSteps = 10;
			this.PrefixKey = "prefix";
			this.BaseUrl = A_0;
			this.model = A_1;
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000ACF5A File Offset: 0x000AB15A
		public LLMCaller(string A_0, string A_1, string A_2)
		{
			this.KeepToolCallsInHistory = new bool?(true);
			this.MaxToolSteps = 10;
			this.PrefixKey = "prefix";
			this.BaseUrl = A_0;
			this.model = A_1;
			this.ApiKey = A_2;
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x000ACF96 File Offset: 0x000AB196
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x000ACF9E File Offset: 0x000AB19E
		public string BaseUrl { get; set; }

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x000ACFA7 File Offset: 0x000AB1A7
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x000ACFAF File Offset: 0x000AB1AF
		public string ApiKey
		{
			get
			{
				return this.o.0o_.;
			}
			set
			{
				if (!string.IsNullOrEmpty(value) && !value.StartsWith("Bearer "))
				{
					value = "Bearer " + value;
				}
				this.o.0o_. = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x000ACFDA File Offset: 0x000AB1DA
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x000ACFE2 File Offset: 0x000AB1E2
		public JArray Messages { get; set; }

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x000ACFEB File Offset: 0x000AB1EB
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x000ACFF3 File Offset: 0x000AB1F3
		public object UserMessage
		{
			[CompilerGenerated]
			get
			{
				return this.a;
			}
			[CompilerGenerated]
			set
			{
				this.a = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x000AD001 File Offset: 0x000AB201
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x000AD009 File Offset: 0x000AB209
		public string SystemPrompt { get; set; }

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x000AD012 File Offset: 0x000AB212
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x000AD01A File Offset: 0x000AB21A
		public bool? KeepReasoningInHistory { get; set; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x000AD023 File Offset: 0x000AB223
		// (set) Token: 0x06001883 RID: 6275 RVA: 0x000AD02B File Offset: 0x000AB22B
		public bool? KeepToolCallsInHistory { get; set; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x000AD034 File Offset: 0x000AB234
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x000AD04F File Offset: 0x000AB24F
		public AIToolBuilder Tools
		{
			get
			{
				if (this.a == null)
				{
					this.a = new AIToolBuilder();
				}
				return this.a;
			}
			set
			{
				this.a = value;
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000AD058 File Offset: 0x000AB258
		public AITool AddTool(string name, string description)
		{
			return this.Tools.AddFunction(name, description);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x000AD068 File Offset: 0x000AB268
		public void AddJsonTool(JToken tooldef)
		{
			if (tooldef is JObject)
			{
				this.Tools.JsonTools.Add((JObject)tooldef);
				return;
			}
			if (tooldef is JArray)
			{
				try
				{
					foreach (JToken jtoken in ((JArray)tooldef))
					{
						this.Tools.JsonTools.Add((JObject)jtoken);
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
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x000AD0EC File Offset: 0x000AB2EC
		public void AddJsonTool(string tooldef)
		{
			JToken jtoken = JsonConvert.DeserializeObject<JToken>(tooldef);
			if (jtoken is JObject)
			{
				this.Tools.JsonTools.Add((JObject)jtoken);
				return;
			}
			if (jtoken is JArray)
			{
				try
				{
					foreach (JToken jtoken2 in ((JArray)jtoken))
					{
						this.Tools.JsonTools.Add((JObject)jtoken2);
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
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x000AD178 File Offset: 0x000AB378
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x000AD180 File Offset: 0x000AB380
		public Func<string, JObject, string> ToolExecutor { get; set; }

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x000AD189 File Offset: 0x000AB389
		// (set) Token: 0x0600188C RID: 6284 RVA: 0x000AD191 File Offset: 0x000AB391
		public Action<string, string> SSEStreamHandler { get; set; }

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x000AD19A File Offset: 0x000AB39A
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x000AD1A2 File Offset: 0x000AB3A2
		public int MaxToolSteps { get; set; }

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x000AD1AB File Offset: 0x000AB3AB
		public JObject Headers
		{
			get
			{
				if (this.a == null)
				{
					this.a = new JObject();
				}
				return this.a;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x000AD1C6 File Offset: 0x000AB3C6
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x000AD1CE File Offset: 0x000AB3CE
		public string model { get; set; }

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x000AD1D7 File Offset: 0x000AB3D7
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x000AD1DF File Offset: 0x000AB3DF
		public bool stream { get; set; }

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x000AD1E8 File Offset: 0x000AB3E8
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x000AD1F0 File Offset: 0x000AB3F0
		public double? temperature { get; set; }

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x000AD1F9 File Offset: 0x000AB3F9
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x000AD201 File Offset: 0x000AB401
		public double? top_p { get; set; }

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x000AD20A File Offset: 0x000AB40A
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x000AD212 File Offset: 0x000AB412
		public int? max_completion_tokens { get; set; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x000AD21B File Offset: 0x000AB41B
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x000AD223 File Offset: 0x000AB423
		public int? max_tokens { get; set; }

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x000AD22C File Offset: 0x000AB42C
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x000AD234 File Offset: 0x000AB434
		public int? n { get; set; }

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x000AD23D File Offset: 0x000AB43D
		// (set) Token: 0x0600189F RID: 6303 RVA: 0x000AD245 File Offset: 0x000AB445
		public int? seed { get; set; }

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x000AD24E File Offset: 0x000AB44E
		// (set) Token: 0x060018A1 RID: 6305 RVA: 0x000AD256 File Offset: 0x000AB456
		public JArray stop { get; set; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x000AD25F File Offset: 0x000AB45F
		// (set) Token: 0x060018A3 RID: 6307 RVA: 0x000AD267 File Offset: 0x000AB467
		public double? presence_penalty { get; set; }

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x000AD270 File Offset: 0x000AB470
		// (set) Token: 0x060018A5 RID: 6309 RVA: 0x000AD278 File Offset: 0x000AB478
		public double? frequency_penalty { get; set; }

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x000AD281 File Offset: 0x000AB481
		// (set) Token: 0x060018A7 RID: 6311 RVA: 0x000AD289 File Offset: 0x000AB489
		public bool? logprobs { get; set; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x000AD292 File Offset: 0x000AB492
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x000AD29A File Offset: 0x000AB49A
		public int? top_logprobs { get; set; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x000AD2A3 File Offset: 0x000AB4A3
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x000AD2AB File Offset: 0x000AB4AB
		public JObject logit_bias { get; set; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x000AD2B4 File Offset: 0x000AB4B4
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x000AD2BC File Offset: 0x000AB4BC
		public string user { get; set; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x000AD2C5 File Offset: 0x000AB4C5
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x000AD2CD File Offset: 0x000AB4CD
		public string tool_choice { get; set; }

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x000AD2D6 File Offset: 0x000AB4D6
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x000AD2DE File Offset: 0x000AB4DE
		public bool? parallel_tool_calls { get; set; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x000AD2E7 File Offset: 0x000AB4E7
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x000AD2EF File Offset: 0x000AB4EF
		public object response_format
		{
			[CompilerGenerated]
			get
			{
				return this.o_Ooo._OO0.;
			}
			[CompilerGenerated]
			set
			{
				this.o_Ooo._OO0. = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x000AD2FD File Offset: 0x000AB4FD
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x000AD305 File Offset: 0x000AB505
		public JObject stream_options { get; set; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x000AD30E File Offset: 0x000AB50E
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x000AD316 File Offset: 0x000AB516
		public string service_tier { get; set; }

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x000AD31F File Offset: 0x000AB51F
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x000AD327 File Offset: 0x000AB527
		public bool? store { get; set; }

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x000AD330 File Offset: 0x000AB530
		// (set) Token: 0x060018BB RID: 6331 RVA: 0x000AD338 File Offset: 0x000AB538
		public JObject metadata { get; set; }

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x000AD341 File Offset: 0x000AB541
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x000AD349 File Offset: 0x000AB549
		public string verbosity { get; set; }

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x000AD352 File Offset: 0x000AB552
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x000AD35A File Offset: 0x000AB55A
		public string reasoning_effort { get; set; }

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x000AD363 File Offset: 0x000AB563
		public object extra_body
		{
			get
			{
				if (this.OO_o0_0_0_O._. == null)
				{
					this.OO_o0_0_0_O._. = new ExpandoObject();
				}
				return this.OO_o0_0_0_O._.;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x000AD37E File Offset: 0x000AB57E
		public string Result
		{
			get
			{
				return this.O0O_.OoOo.;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x000AD386 File Offset: 0x000AB586
		public string Think
		{
			get
			{
				return this.a;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x000AD38E File Offset: 0x000AB58E
		public string Error
		{
			get
			{
				return this.O0o_.0.;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x000AD396 File Offset: 0x000AB596
		public JObject ResultJObject
		{
			get
			{
				return this.O0oo.OO00Oo_Oo.;
			}
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000AD3A0 File Offset: 0x000AB5A0
		private string <<EMPTY_NAME>>(bool A_0)
		{
			this.O0oo.OO00Oo_Oo. = null;
			this.O0o_.0. = null;
			this.O0O_.OoOo. = null;
			this.a = null;
			string result;
			if (string.IsNullOrEmpty(this.BaseUrl))
			{
				result = "BaseUrl 未设置";
			}
			else
			{
				string.IsNullOrEmpty(this.ApiKey);
				if (this.a != null && this.Tools.Count > 0 && this.ToolExecutor == null)
				{
					result = "Tools 非空但 ToolExecutor 未设置";
				}
				else
				{
					if (A_0)
					{
						if ((this.stream && this.SSEStreamHandler == null) || (!this.stream && this.SSEStreamHandler != null))
						{
							return "stream 和 SSEStreamHandler 需要同时设置才能使用流";
						}
					}
					else if (this.SSEStreamHandler != null || this.stream)
					{
						return "同步方法不支持流模式";
					}
					result = null;
				}
			}
			return result;
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x000AD456 File Offset: 0x000AB656
		// (set) Token: 0x060018C7 RID: 6343 RVA: 0x000AD45E File Offset: 0x000AB65E
		public bool RunOnServer { get; set; }

		// Token: 0x060018C8 RID: 6344 RVA: 0x000AD468 File Offset: 0x000AB668
		[return: TupleElementNames(new string[]
		{
			"bodyJo",
			"workingMsgs",
			"hc"
		})]
		private ValueTuple<JObject, JArray, HttpClient> <<EMPTY_NAME>>(bool A_0, bool A_1)
		{
			JArray jarray;
			if (A_1)
			{
				if (this.Messages.Count == 0 && !string.IsNullOrEmpty(this.SystemPrompt))
				{
					JObject jobject = new JObject();
					jobject["role"] = "system";
					jobject["content"] = this.SystemPrompt;
					this.Messages.Add(jobject);
				}
				if (this.UserMessage != null)
				{
					JObject jobject2 = new JObject();
					jobject2["role"] = "user";
					if (this.UserMessage is string)
					{
						jobject2["content"] = Conversions.ToString(this.UserMessage);
					}
					else if (this.UserMessage is JArray)
					{
						jobject2["content"] = (JArray)this.UserMessage;
					}
					this.Messages.Add(jobject2);
				}
				jarray = (JArray)this.Messages.DeepClone();
			}
			else
			{
				jarray = new JArray();
				if (!string.IsNullOrEmpty(this.SystemPrompt))
				{
					JObject jobject3 = new JObject();
					jobject3["role"] = "system";
					jobject3["content"] = this.SystemPrompt;
					jarray.Add(jobject3);
				}
				if (this.UserMessage != null)
				{
					JObject jobject4 = new JObject();
					jobject4["role"] = "user";
					if (this.UserMessage is string)
					{
						jobject4["content"] = Conversions.ToString(this.UserMessage);
					}
					else if (this.UserMessage is JArray)
					{
						jobject4["content"] = (JArray)this.UserMessage;
					}
					jarray.Add(jobject4);
				}
			}
			if (!string.IsNullOrEmpty(this.PrefixContent) && !string.IsNullOrWhiteSpace(this.PrefixContent))
			{
				jarray.Add(new JObject
				{
					{
						"role",
						"assistant"
					},
					{
						"content",
						this.PrefixContent
					},
					{
						this.PrefixKey,
						true
					}
				});
			}
			JObject jobject5 = new JObject();
			jobject5["model"] = this.model;
			if (this.a != null && (this.Tools.Count > 0 || this.a.JsonTools.Count > 0))
			{
				jobject5["tools"] = this.Tools.Build();
			}
			if (A_0)
			{
				jobject5["stream"] = A_0;
			}
			if (this.temperature != null)
			{
				jobject5["temperature"] = this.temperature.Value;
			}
			if (this.top_p != null)
			{
				jobject5["top_p"] = this.top_p.Value;
			}
			if (this.max_completion_tokens != null)
			{
				jobject5["max_completion_tokens"] = this.max_completion_tokens.Value;
			}
			if (this.max_tokens != null)
			{
				jobject5["max_tokens"] = this.max_tokens.Value;
			}
			if (this.n != null)
			{
				jobject5["n"] = this.n.Value;
			}
			if (this.seed != null)
			{
				jobject5["seed"] = this.seed.Value;
			}
			if (this.stop != null && this.stop.Count > 0)
			{
				jobject5["stop"] = this.stop;
			}
			if (this.presence_penalty != null)
			{
				jobject5["presence_penalty"] = this.presence_penalty.Value;
			}
			if (this.frequency_penalty != null)
			{
				jobject5["frequency_penalty"] = this.frequency_penalty.Value;
			}
			if (this.logprobs != null)
			{
				jobject5["logprobs"] = this.logprobs.Value;
			}
			if (this.top_logprobs != null)
			{
				jobject5["top_logprobs"] = this.top_logprobs.Value;
			}
			if (this.logit_bias != null && this.logit_bias.Count > 0)
			{
				jobject5["logit_bias"] = this.logit_bias;
			}
			if (!string.IsNullOrEmpty(this.user))
			{
				jobject5["user"] = this.user;
			}
			if (!string.IsNullOrEmpty(this.tool_choice))
			{
				jobject5["tool_choice"] = this.tool_choice;
			}
			if (this.parallel_tool_calls != null)
			{
				jobject5["parallel_tool_calls"] = this.parallel_tool_calls.Value;
			}
			if (this.response_format != null)
			{
				if (this.response_format is string)
				{
					jobject5["response_format"] = new JObject
					{
						{
							"type",
							this.response_format.ToString()
						}
					};
				}
				else if (this.response_format is JToken)
				{
					jobject5["response_format"] = (JToken)this.response_format;
				}
			}
			if (this.stream_options != null && this.stream_options.Count > 0)
			{
				jobject5["stream_options"] = this.stream_options;
			}
			if (!string.IsNullOrEmpty(this.service_tier))
			{
				jobject5["service_tier"] = this.service_tier;
			}
			if (this.store != null)
			{
				jobject5["store"] = this.store.Value;
			}
			if (this.metadata != null && this.metadata.Count > 0)
			{
				jobject5["metadata"] = this.metadata;
			}
			if (!string.IsNullOrEmpty(this.verbosity))
			{
				jobject5["verbosity"] = this.verbosity;
			}
			if (!string.IsNullOrEmpty(this.reasoning_effort))
			{
				jobject5["reasoning_effort"] = this.reasoning_effort;
			}
			if (this.OO_o0_0_0_O._. != null && ((ICollection<KeyValuePair<string, object>>)((ExpandoObject)this.OO_o0_0_0_O._.)).Count > 0)
			{
				JObject jobject6 = JObject.Parse(JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(this.OO_o0_0_0_O._.)));
				try
				{
					foreach (JProperty jproperty in jobject6.Properties())
					{
						jobject5[jproperty.Name] = jproperty.Value;
					}
				}
				finally
				{
					IEnumerator<JProperty> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			jobject5["messages"] = jarray;
			HttpClient httpClient = new HttpClient(this.BaseUrl);
			httpClient.SkipError = true;
			httpClient.ContentType = "application/json";
			if (!string.IsNullOrEmpty(this.ApiKey))
			{
				httpClient.Headers.Add("Authorization", this.ApiKey);
			}
			if (this.a != null)
			{
				try
				{
					foreach (JProperty jproperty2 in this.a.Properties())
					{
						httpClient.Headers.Add(jproperty2.Name, jproperty2.Value.ToString());
					}
				}
				finally
				{
					IEnumerator<JProperty> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
			httpClient.Content = jobject5.ToString();
			httpClient.RunOnServer = this.RunOnServer;
			return new ValueTuple<JObject, JArray, HttpClient>(jobject5, jarray, httpClient);
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x000ADC50 File Offset: 0x000ABE50
		public Task<bool> GetResultAsync()
		{
			LLMCaller.a a = default(LLMCaller.a);
			a.a = this;
			a.a = -1;
			a.a = AsyncTaskMethodBuilder<bool>.Create();
			a.a.Start<LLMCaller.a>(ref a);
			return a.a.Task;
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x000ADC9C File Offset: 0x000ABE9C
		private HttpClient <<EMPTY_NAME>>(JObject A_0, JObject A_1, bool A_2, JArray A_3, HttpClient A_4)
		{
			JObject jobject = (JObject)A_1["choices"][0]["message"];
			if (A_2)
			{
				if (jobject.ContainsKey("tool_calls") && ((JArray)jobject["tool_calls"]).Count > 0)
				{
					if (this.KeepToolCallsInHistory != null)
					{
						bool? flag = this.KeepToolCallsInHistory;
						if (((flag != null) ? new bool?(flag.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							JObject jobject2 = new JObject();
							jobject2["role"] = "assistant";
							if (jobject.ContainsKey("content"))
							{
								jobject2["content"] = jobject["content"];
							}
							bool? flag2;
							bool? flag3;
							if (this.KeepReasoningInHistory != null)
							{
								flag2 = this.KeepReasoningInHistory;
								flag3 = ((flag2 != null) ? new bool?(flag2.GetValueOrDefault()) : null);
							}
							else
							{
								flag3 = new bool?(true);
							}
							flag = (flag2 = flag3);
							if (((flag2 != null && !flag.GetValueOrDefault()) ? new bool?(false) : (flag & jobject.ContainsKey("reasoning_content"))).GetValueOrDefault())
							{
								jobject2["reasoning_content"] = jobject["reasoning_content"];
							}
							flag = (flag2 = this.KeepToolCallsInHistory);
							if (((flag2 != null && !flag.GetValueOrDefault()) ? new bool?(false) : (flag & jobject.ContainsKey("tool_calls"))).GetValueOrDefault())
							{
								jobject2["tool_calls"] = jobject["tool_calls"];
							}
							this.Messages.Add(jobject2);
						}
					}
				}
				else
				{
					JObject jobject3 = new JObject();
					jobject3["role"] = "assistant";
					if (jobject.ContainsKey("content"))
					{
						jobject3["content"] = jobject["content"];
					}
					if (jobject.ContainsKey("reasoning_content"))
					{
						if (this.a != null && this.Tools.Count > 0 && this.ToolExecutor != null)
						{
							if (this.KeepReasoningInHistory != null)
							{
								bool? flag = this.KeepReasoningInHistory;
								if (!((flag != null) ? new bool?(flag.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									goto IL_2F0;
								}
							}
							jobject3["reasoning_content"] = jobject["reasoning_content"];
						}
						else
						{
							bool? flag = this.KeepReasoningInHistory;
							if (((flag != null) ? new bool?(flag.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								jobject3["reasoning_content"] = jobject["reasoning_content"];
							}
						}
					}
					IL_2F0:
					this.Messages.Add(jobject3);
				}
			}
			HttpClient result;
			if (!jobject.ContainsKey("tool_calls") || ((JArray)jobject["tool_calls"]).Count == 0)
			{
				result = null;
			}
			else
			{
				A_3.Add(jobject);
				try
				{
					foreach (JToken jtoken in ((IEnumerable<JToken>)jobject["tool_calls"]))
					{
						JObject jobject4 = (JObject)jtoken;
						string text = jobject4["function"]["name"].ToString();
						string value = jobject4["id"].ToString();
						string json = jobject4["function"]["arguments"].ToString();
						string value2 = "";
						try
						{
							JObject arg = JObject.Parse(json);
							value2 = this.ToolExecutor(text, arg);
						}
						catch (Exception ex)
						{
							value2 = string.Format("工具(Name:{0})执行异常：", text) + ex.Message;
						}
						JObject jobject5 = new JObject();
						jobject5["role"] = "tool";
						jobject5["tool_call_id"] = value;
						jobject5["content"] = value2;
						A_3.Add(jobject5);
						bool? flag2;
						bool? flag = flag2 = this.KeepToolCallsInHistory;
						if (((flag2 != null && !flag.GetValueOrDefault()) ? new bool?(false) : (flag && A_2)).GetValueOrDefault())
						{
							this.Messages.Add(jobject5);
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
				A_4 = A_4.Clone();
				A_0["messages"] = A_3;
				A_4.Content = A_0.ToString();
				result = A_4;
			}
			return result;
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x000AE198 File Offset: 0x000AC398
		public bool GetResult()
		{
			JObject jobject = new JObject();
			string text = this.OO0.0OoO0.(false);
			bool result;
			if (!string.IsNullOrEmpty(text))
			{
				this.O0o_.0. = text;
				result = false;
			}
			else
			{
				bool flag = this.Messages != null;
				ValueTuple<JObject, JArray, HttpClient> valueTuple = this.O._OOOO0_.(false, flag);
				JObject item = valueTuple.Item1;
				JArray item2 = valueTuple.Item2;
				HttpClient httpClient = valueTuple.Item3;
				int num = 0;
				try
				{
					for (;;)
					{
						string data = httpClient.GetData();
						if (httpClient.StatusCode != 200)
						{
							break;
						}
						jobject = (JObject)JsonConvert.DeserializeObject(data);
						if (jobject["choices"][0]["message"]["reasoning_content"] != null)
						{
							if (!string.IsNullOrEmpty(this.a))
							{
								this.a += "\r\n";
							}
							this.a += jobject["choices"][0]["message"]["reasoning_content"].ToString();
						}
						HttpClient httpClient2 = this.o_oO.oO00.(item, jobject, flag, item2, httpClient);
						if (httpClient2 == null)
						{
							goto IL_171;
						}
						num++;
						if (num > this.MaxToolSteps)
						{
							goto Block_8;
						}
						httpClient = httpClient2;
					}
					this.O0o_.0. = "请求失败，状态码：" + Conversions.ToString(httpClient.StatusCode) + "，状态描述：" + httpClient.StatusDescription;
					return false;
					Block_8:
					this.O0o_.0. = "工具调用超过允许的最大步数";
					return false;
					IL_171:;
				}
				catch (Exception ex)
				{
					this.O0o_.0. = "请求发生异常：" + ex.Message;
					return false;
				}
				this.O0oo.OO00Oo_Oo. = jobject;
				this.O0O_.OoOo. = jobject["choices"][0]["message"]["content"].ToString();
				if (Operators.CompareString(this.a, "", true) > 0)
				{
					jobject["choices"][0]["message"]["reasoning_content"] = this.a.Trim(new char[]
					{
						'\r',
						'\n',
						' '
					});
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x000AE400 File Offset: 0x000AC600
		public string GetRequestBody()
		{
			new JObject();
			string text = this.OO0.0OoO0.(true);
			string result;
			if (!string.IsNullOrEmpty(text))
			{
				result = text;
			}
			else
			{
				bool a_;
				if (this.SSEStreamHandler != null && this.stream)
				{
					a_ = true;
				}
				bool a_2 = this.Messages != null;
				JArray jarray = null;
				if (this.Messages != null)
				{
					jarray = (JArray)this.Messages.DeepClone();
				}
				ValueTuple<JObject, JArray, HttpClient> valueTuple = this.O._OOOO0_.(a_, a_2);
				if (jarray != null && this.Messages != null)
				{
					this.Messages.Clear();
					try
					{
						foreach (JToken item in jarray)
						{
							this.Messages.Add(item);
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
				}
				result = valueTuple.Item3.Content;
			}
			return result;
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x000AE4DC File Offset: 0x000AC6DC
		public void Cancel()
		{
			if (this.ooO0oo.oO_. != null)
			{
				this.ooO0oo.oO_..Cancel();
				this.ooO0oo.oO_. = null;
			}
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x000AE4F8 File Offset: 0x000AC6F8
		public void TrimMessages(int n)
		{
			if (this.Messages != null)
			{
				JArray jarray = new JArray();
				int num = 0;
				for (int i = this.Messages.Count - 1; i >= 0; i += -1)
				{
					JToken jtoken = this.Messages[i];
					string left = (jtoken["role"] ?? "").ToString();
					bool flag;
					if (num < n || (Operators.CompareString(left, "system", true) == 0 && !flag))
					{
						jarray.Insert(0, jtoken);
						if (Operators.CompareString(left, "system", true) == 0)
						{
							flag = true;
						}
					}
					if (Operators.CompareString(left, "user", true) == 0)
					{
						num++;
					}
					if (num >= n && flag)
					{
						break;
					}
				}
				this.Messages.Clear();
				try
				{
					foreach (JToken item in jarray)
					{
						this.Messages.Add(item);
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
			}
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x000AE600 File Offset: 0x000AC800
		public int EstimateTokenCount(string text, double cnWeight = 0.6, double enWeight = 0.3)
		{
			int result;
			if (string.IsNullOrEmpty(text))
			{
				result = 0;
			}
			else
			{
				double num = 0.0;
				foreach (char a_ in text)
				{
					if (this.a(a_))
					{
						num += cnWeight;
					}
					else if (char.IsLetterOrDigit(a_))
					{
						num += enWeight;
					}
					else if (char.IsWhiteSpace(a_))
					{
						num += enWeight * 0.33;
					}
					else
					{
						num += enWeight;
					}
				}
				result = (int)Math.Ceiling(num);
			}
			return result;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x000AE684 File Offset: 0x000AC884
		private JObject a(JObject A_0, string A_1 = "")
		{
			JObject jobject;
			if (A_0["inputSchema"] != null)
			{
				jobject = (JObject)A_0["inputSchema"].DeepClone();
			}
			else
			{
				jobject = new JObject();
				jobject["type"] = "object";
				jobject["properties"] = new JObject();
			}
			JObject jobject2 = new JObject();
			jobject2["name"] = A_1 + A_0["name"].ToString();
			jobject2["description"] = ((A_0["description"] == null) ? "" : A_0["description"].ToString());
			jobject2["parameters"] = jobject;
			JObject jobject3 = new JObject();
			jobject3["type"] = "function";
			jobject3["function"] = jobject2;
			return jobject3;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x000AE774 File Offset: 0x000AC974
		public void AddMCPTools(JArray mcpTools, string prefix = "")
		{
			try
			{
				foreach (JToken jtoken in mcpTools)
				{
					if (jtoken is JObject)
					{
						this.AddJsonTool(this.a((JObject)jtoken, prefix));
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
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x000AE7D0 File Offset: 0x000AC9D0
		private bool a(char A_0)
		{
			return (A_0 >= '一' && A_0 <= '鿿') || (A_0 >= '㐀' && A_0 <= '䶿') || ((int)A_0 >= 131072 && (int)A_0 <= 173791) || (A_0 >= '豈' && A_0 <= '﫿') || (A_0 >= '\u3000' && A_0 <= '〿') || (A_0 >= '＀' && A_0 <= '￯') || (A_0 >= '\u2000' && A_0 <= '⁯');
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x000AE856 File Offset: 0x000ACA56
		// (set) Token: 0x060018D4 RID: 6356 RVA: 0x000AE85E File Offset: 0x000ACA5E
		public string PrefixKey { get; set; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x000AE867 File Offset: 0x000ACA67
		// (set) Token: 0x060018D6 RID: 6358 RVA: 0x000AE86F File Offset: 0x000ACA6F
		public string PrefixContent { get; set; }

		// Token: 0x040009D7 RID: 2519
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009D8 RID: 2520
		private string <<EMPTY_NAME>>;

		// Token: 0x040009D9 RID: 2521
		[CompilerGenerated]
		private JArray <<EMPTY_NAME>>;

		// Token: 0x040009DA RID: 2522
		[CompilerGenerated]
		private object a;

		// Token: 0x040009DB RID: 2523
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009DC RID: 2524
		[CompilerGenerated]
		private bool? a;

		// Token: 0x040009DD RID: 2525
		[CompilerGenerated]
		private bool? b;

		// Token: 0x040009DE RID: 2526
		private AIToolBuilder a;

		// Token: 0x040009DF RID: 2527
		[CompilerGenerated]
		private Func<string, JObject, string> <<EMPTY_NAME>>;

		// Token: 0x040009E0 RID: 2528
		[CompilerGenerated]
		private Action<string, string> <<EMPTY_NAME>>;

		// Token: 0x040009E1 RID: 2529
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;

		// Token: 0x040009E2 RID: 2530
		private JObject a;

		// Token: 0x040009E3 RID: 2531
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009E4 RID: 2532
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040009E5 RID: 2533
		[CompilerGenerated]
		private double? <<EMPTY_NAME>>;

		// Token: 0x040009E6 RID: 2534
		[CompilerGenerated]
		private double? <<EMPTY_NAME>>;

		// Token: 0x040009E7 RID: 2535
		[CompilerGenerated]
		private int? <<EMPTY_NAME>>;

		// Token: 0x040009E8 RID: 2536
		[CompilerGenerated]
		private int? <<EMPTY_NAME>>;

		// Token: 0x040009E9 RID: 2537
		[CompilerGenerated]
		private int? <<EMPTY_NAME>>;

		// Token: 0x040009EA RID: 2538
		[CompilerGenerated]
		private int? <<EMPTY_NAME>>;

		// Token: 0x040009EB RID: 2539
		[CompilerGenerated]
		private JArray <<EMPTY_NAME>>;

		// Token: 0x040009EC RID: 2540
		[CompilerGenerated]
		private double? <<EMPTY_NAME>>;

		// Token: 0x040009ED RID: 2541
		[CompilerGenerated]
		private double? <<EMPTY_NAME>>;

		// Token: 0x040009EE RID: 2542
		[CompilerGenerated]
		private bool? <<EMPTY_NAME>>;

		// Token: 0x040009EF RID: 2543
		[CompilerGenerated]
		private int? <<EMPTY_NAME>>;

		// Token: 0x040009F0 RID: 2544
		[CompilerGenerated]
		private JObject <<EMPTY_NAME>>;

		// Token: 0x040009F1 RID: 2545
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009F2 RID: 2546
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009F3 RID: 2547
		[CompilerGenerated]
		private bool? <<EMPTY_NAME>>;

		// Token: 0x040009F4 RID: 2548
		[CompilerGenerated]
		private object <<EMPTY_NAME>>;

		// Token: 0x040009F5 RID: 2549
		[CompilerGenerated]
		private JObject <<EMPTY_NAME>>;

		// Token: 0x040009F6 RID: 2550
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009F7 RID: 2551
		[CompilerGenerated]
		private bool? <<EMPTY_NAME>>;

		// Token: 0x040009F8 RID: 2552
		[CompilerGenerated]
		private JObject <<EMPTY_NAME>>;

		// Token: 0x040009F9 RID: 2553
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009FA RID: 2554
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009FB RID: 2555
		private object <<EMPTY_NAME>>;

		// Token: 0x040009FC RID: 2556
		private CancellationTokenSource <<EMPTY_NAME>>;

		// Token: 0x040009FD RID: 2557
		private string <<EMPTY_NAME>>;

		// Token: 0x040009FE RID: 2558
		private string a;

		// Token: 0x040009FF RID: 2559
		private string <<EMPTY_NAME>>;

		// Token: 0x04000A00 RID: 2560
		private JObject <<EMPTY_NAME>>;

		// Token: 0x04000A01 RID: 2561
		[CompilerGenerated]
		private bool a;

		// Token: 0x04000A02 RID: 2562
		[CompilerGenerated]
		private string b;

		// Token: 0x04000A03 RID: 2563
		[CompilerGenerated]
		private string c;
	}
}
