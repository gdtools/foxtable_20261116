using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200033A RID: 826
	internal class SubtotalModeProperty
	{
		// Token: 0x0600319A RID: 12698 RVA: 0x00154908 File Offset: 0x00152B08
		public SubtotalModeProperty(SubtotalGroupCollection A_0, bool A_1, bool A_2, bool A_3)
		{
			this.O._OOo__. = A_0;
			this.o0o_.O_0. = A_2;
			this.oO0O_0.ooo00. = A_1;
			this.o_OO.o0O. = A_3;
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x00154930 File Offset: 0x00152B30
		// (set) Token: 0x0600319C RID: 12700 RVA: 0x001549AC File Offset: 0x00152BAC
		public string SubtotalGroups
		{
			get
			{
				string text = "";
				try
				{
					foreach (SubtotalGroup a_ in this.O._OOo__.)
					{
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += "\r";
						}
						text += o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\n', false);
					}
				}
				finally
				{
					IEnumerator<SubtotalGroup> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				return text;
			}
			set
			{
				this.O._OOo__. = value;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x001549B5 File Offset: 0x00152BB5
		// (set) Token: 0x0600319E RID: 12702 RVA: 0x001549BD File Offset: 0x00152BBD
		public bool GroupAboveData
		{
			get
			{
				return this.oO0O_0.ooo00.;
			}
			set
			{
				this.oO0O_0.ooo00. = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x001549C6 File Offset: 0x00152BC6
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x001549CE File Offset: 0x00152BCE
		public bool TreeVisible
		{
			get
			{
				return this.o0o_.O_0.;
			}
			set
			{
				this.o0o_.O_0. = value;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x001549D7 File Offset: 0x00152BD7
		// (set) Token: 0x060031A2 RID: 12706 RVA: 0x001549DF File Offset: 0x00152BDF
		public bool SpillNode
		{
			get
			{
				return this.o_OO.o0O.;
			}
			set
			{
				this.o_OO.o0O. = value;
			}
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x001549E8 File Offset: 0x00152BE8
		internal void Restore()
		{
			string[] array = this.O._OOo__..Split(new char[]
			{
				'\r'
			}, StringSplitOptions.RemoveEmptyEntries);
			this.O._OOo__..Clear();
			foreach (string a_ in array)
			{
				SubtotalGroup subtotalGroup = new SubtotalGroup();
				o_O_o_oOoo__.OOOO_OO._oo.(subtotalGroup, a_, '\n');
				this.O._OOo__..Add(subtotalGroup);
			}
		}

		// Token: 0x0400140A RID: 5130
		private SubtotalGroupCollection <<EMPTY_NAME>>;

		// Token: 0x0400140B RID: 5131
		private string <<EMPTY_NAME>>;

		// Token: 0x0400140C RID: 5132
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400140D RID: 5133
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400140E RID: 5134
		private bool <<EMPTY_NAME>>;
	}
}
