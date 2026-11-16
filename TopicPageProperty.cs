using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000428 RID: 1064
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TopicPageProperty : TopicLinkProperty
	{
		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06004876 RID: 18550 RVA: 0x001F4622 File Offset: 0x001F2822
		// (set) Token: 0x06004877 RID: 18551 RVA: 0x001F462A File Offset: 0x001F282A
		[DisplayName("折叠")]
		[O_Oo00Oo000O0(5.0)]
		[Category("属性")]
		[DefaultValue(false)]
		public bool Collapsed
		{
			get
			{
				return this.O__.o__.;
			}
			set
			{
				this.O__.o__. = value;
			}
		}

		// Token: 0x04001D3B RID: 7483
		private bool <<EMPTY_NAME>>;
	}
}
