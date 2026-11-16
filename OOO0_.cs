using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001A7 RID: 423
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OOO0_ : WebBrowser
	{
		// Token: 0x060014CE RID: 5326 RVA: 0x000970D6 File Offset: 0x000952D6
		public OOO0_()
		{
			base.DocumentCompleted += this.Ooo__.ooO_0.;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x000970F0 File Offset: 0x000952F0
		private void <<EMPTY_NAME>>()
		{
			object objectValue = RuntimeHelpers.GetObjectValue(base.ActiveXInstance);
			object value = Missing.Value;
			object[] args = new object[]
			{
				24,
				2,
				RuntimeHelpers.GetObjectValue(value),
				RuntimeHelpers.GetObjectValue(value)
			};
			objectValue.GetType().InvokeMember("ExecWB", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), args);
			this.OOoo.OOo0000_. = !this.OOoo.OOo0000_.;
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00097168 File Offset: 0x00095368
		internal bool <<EMPTY_NAME>>()
		{
			return this.OOOo_._oO0_O.;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00097170 File Offset: 0x00095370
		internal void <<EMPTY_NAME>>(bool A_0)
		{
			this.OOOo_._oO0_O. = A_0;
			if (this.O_000o_O0.00o.() && (this.OOOo_._oO0_O. ^ this.OOoo.OOo0000_.))
			{
				this.OOOo_._oO0_O.();
			}
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00097198 File Offset: 0x00095398
		public void <<EMPTY_NAME>>()
		{
			if (this.O_000o_O0.00o.())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(base.ActiveXInstance);
				object value = Missing.Value;
				object[] args = new object[]
				{
					3,
					2,
					RuntimeHelpers.GetObjectValue(value),
					RuntimeHelpers.GetObjectValue(value)
				};
				objectValue.GetType().InvokeMember("ExecWB", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), args);
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00097208 File Offset: 0x00095408
		public void <<EMPTY_NAME>>()
		{
			if (this.O_000o_O0.00o.())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(base.ActiveXInstance);
				object value = Missing.Value;
				object[] args = new object[]
				{
					6,
					6,
					RuntimeHelpers.GetObjectValue(value),
					RuntimeHelpers.GetObjectValue(value)
				};
				objectValue.GetType().InvokeMember("ExecWB", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), args);
			}
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00097278 File Offset: 0x00095478
		internal Workbook <<EMPTY_NAME>>()
		{
			if (this.O_000o_O0.00o.())
			{
				string text = base.DocumentTitle.ToLower();
				if (text.EndsWith(".xls") || text.EndsWith(".xlsx"))
				{
					return (Workbook)NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(base.ActiveXInstance), null, "Document", new object[0], null, null, null);
				}
				if (text.EndsWith(".doc") || text.EndsWith(".docx"))
				{
					return (Workbook)((Document)NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(base.ActiveXInstance), null, "Document", new object[0], null, null, null));
				}
			}
			return null;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00097326 File Offset: 0x00095526
		private void <<EMPTY_NAME>>(object A_0, WebBrowserDocumentCompletedEventArgs A_1)
		{
			if (this.O_000o_O0.00o.() && (this.OOOo_._oO0_O. ^ this.OOoo.OOo0000_.))
			{
				this.OOOo_._oO0_O.();
			}
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00097348 File Offset: 0x00095548
		internal bool <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(base.DocumentTitle, "", true) > 0)
			{
				string text = base.DocumentTitle.ToLower();
				if (text.EndsWith(".xls") || text.EndsWith(".xlsx") || text.EndsWith(".doc") || text.EndsWith(".docx"))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0400083C RID: 2108
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400083D RID: 2109
		private bool <<EMPTY_NAME>>;
	}
}
