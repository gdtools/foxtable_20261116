using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020002C3 RID: 707
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class SimpleNodeProperty
	{
		// Token: 0x060026B2 RID: 9906 RVA: 0x0011AFF8 File Offset: 0x001191F8
		internal SimpleNodeProperty(O_o__00Ooo A_0)
		{
			this.o0O_.00. = A_0;
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x0011B007 File Offset: 0x00119207
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x0011B014 File Offset: 0x00119214
		[DefaultValue("")]
		public string Name
		{
			get
			{
				return this.o0O_.00..Name;
			}
			set
			{
				this.o0O_.00..Name = value;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x0011B024 File Offset: 0x00119224
		// (set) Token: 0x060026B6 RID: 9910 RVA: 0x0011B04A File Offset: 0x0011924A
		[DefaultValue("")]
		public string Text
		{
			get
			{
				string result;
				if (this.o0O_.00. == null)
				{
					result = null;
				}
				else
				{
					result = this.o0O_.00..Text;
				}
				return result;
			}
			set
			{
				if (this.o0O_.00. != null)
				{
					this.o0O_.00..Text = value;
				}
			}
		}

		// Token: 0x04000FF2 RID: 4082
		internal O_o__00Ooo <<EMPTY_NAME>>;
	}
}
