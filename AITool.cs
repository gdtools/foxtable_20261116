using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001E6 RID: 486
	public class AITool
	{
		// Token: 0x06001840 RID: 6208 RVA: 0x000AC7BC File Offset: 0x000AA9BC
		public AITool()
		{
			this.Parameters = new List<AIParameter>();
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x000AC7CF File Offset: 0x000AA9CF
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x000AC7D7 File Offset: 0x000AA9D7
		public string Name { get; set; }

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x000AC7E0 File Offset: 0x000AA9E0
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x000AC7E8 File Offset: 0x000AA9E8
		public string Description { get; set; }

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x000AC7F1 File Offset: 0x000AA9F1
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x000AC7F9 File Offset: 0x000AA9F9
		public List<AIParameter> Parameters { get; set; }

		// Token: 0x06001847 RID: 6215 RVA: 0x000AC804 File Offset: 0x000AAA04
		public AIParameter AddParameter(string name, string type, string description, bool isRequired = false, string arrayItemType = "string", IEnumerable<object> enumValues = null)
		{
			AIParameter aiparameter = new AIParameter
			{
				Name = name,
				Type = type,
				Description = description,
				IsRequired = isRequired,
				ArrayItemType = arrayItemType,
				EnumValues = enumValues
			};
			this.Parameters.Add(aiparameter);
			return aiparameter;
		}

		// Token: 0x040009AC RID: 2476
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009AD RID: 2477
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009AE RID: 2478
		[CompilerGenerated]
		private List<AIParameter> <<EMPTY_NAME>>;
	}
}
