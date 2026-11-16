using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace Foxtable
{
	// Token: 0x02000081 RID: 129
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class BuildInDropTree : C1DropDownControl
	{
		// Token: 0x060004D2 RID: 1234 RVA: 0x00020A6C File Offset: 0x0001EC6C
		public BuildInDropTree(string A_0, string A_1, bool A_2 = true)
		{
			base.DropDownClosed += this.Ooo._0oO.;
			base.DropDownOpened += this.Ooo._0oO.;
			base.KeyDown += this.Ooo._0oO.;
			base.KeyPress += this.Ooo._0oO.;
			base.BeforeDropDownOpen += this.Ooo._0oO.;
			this.Ooo._0oO. = true;
			this.ShowUpDownButtons = false;
			this.DataType = typeof(string);
			this.Ooo._0oO. = new O\u30020\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3002(A_0, A_1, A_2);
			this.DropDownForm = this.Ooo._0oO.;
			base.VisualStyle = VisualStyle.System;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00020B18 File Offset: 0x0001ED18
		internal BuildInDropTree(string A_0, string A_1, string A_2, string A_3, char A_4, string A_5, string A_6) : this(OO_00oOO.DataTables[A_0], A_1, A_2, A_3, A_4, A_5, A_6)
		{
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00020B38 File Offset: 0x0001ED38
		internal BuildInDropTree(DataTable A_0, string A_1, string A_2, string A_3, char A_4, string A_5, string A_6)
		{
			base.DropDownClosed += this.Ooo._0oO.;
			base.DropDownOpened += this.Ooo._0oO.;
			base.KeyDown += this.Ooo._0oO.;
			base.KeyPress += this.Ooo._0oO.;
			base.BeforeDropDownOpen += this.Ooo._0oO.;
			this.Ooo._0oO. = true;
			this.ShowUpDownButtons = false;
			this.DataType = typeof(string);
			this.Ooo._0oO. = new O\u30020\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3002(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
			this.DropDownForm = this.Ooo._0oO.;
			base.VisualStyle = VisualStyle.System;
		}

		// Token: 0x17000127 RID: 295
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00020BEC File Offset: 0x0001EDEC
		internal Row Row
		{
			set
			{
				this.Ooo._0oO..OooOoOo_.o. = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00020BFA File Offset: 0x0001EDFA
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00020C02 File Offset: 0x0001EE02
		public bool AllowEditValue
		{
			get
			{
				return this.Ooo._0oO.;
			}
			set
			{
				this.Ooo._0oO. = value;
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00020C0B File Offset: 0x0001EE0B
		private void <<EMPTY_NAME>>(object A_0, DropDownClosedEventArgs A_1)
		{
			this.Ooo._0oO..O0ooOO_o0.00. = false;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00020C19 File Offset: 0x0001EE19
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Ooo._0oO..o.00_O_.().SelectedNode = null;
			this.Ooo._0oO..O0ooOO_o0.00. = true;
			this.Ooo._0oO..Owner = null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00020C44 File Offset: 0x0001EE44
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (!this.AllowEditValue && A_1.KeyCode == Keys.Delete)
			{
				A_1.Handled = true;
				A_1.SuppressKeyPress = true;
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00020C66 File Offset: 0x0001EE66
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			if (!this.AllowEditValue)
			{
				A_1.Handled = true;
				A_1.KeyChar = '\0';
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00020C7E File Offset: 0x0001EE7E
		private void <<EMPTY_NAME>>(object A_0, CancelEventArgs A_1)
		{
			this.Ooo._0oO..o.00_O_.().Font = this.Font;
		}

		// Token: 0x04000144 RID: 324
		internal O\u30020\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3002 <<EMPTY_NAME>>;

		// Token: 0x04000145 RID: 325
		private bool <<EMPTY_NAME>>;
	}
}
