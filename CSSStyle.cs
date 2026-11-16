using System;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;

namespace Foxtable
{
	// Token: 0x020000F5 RID: 245
	public class CSSStyle : DynamicObject
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00072251 File Offset: 0x00070451
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x00072259 File Offset: 0x00070459
		internal HElement Element { get; set; }

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00072262 File Offset: 0x00070462
		public CSSStyle(HElement A_0)
		{
			this.Element = A_0;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00072274 File Offset: 0x00070474
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool TryGetMember(GetMemberBinder binder, ref object result)
		{
			WebViewer o___0o.00o0oO. = this.Element.o___0o.00o0oO.;
			string text;
			if (this.Element.o___0o.00o0oO.)
			{
				text = string.Format("var elements = {0};", this.Element.o___0o.00o0oO.);
				text = text + "\r\n" + string.Format(" elements[0]?.style.{0};", binder.Name);
			}
			else
			{
				text = string.Format("{0}.style.{1}", this.Element.o___0o.00o0oO., binder.Name);
			}
			result = o___0o.00o0oO..ExecuteScriptAsync(text);
			return true;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000722F4 File Offset: 0x000704F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			WebView2 o___0o.00o0oO. = this.Element.o___0o.00o0oO.;
			string text;
			if (value == null)
			{
				text = "null";
			}
			else if (value is string)
			{
				text = JsonConvert.ToString(value.ToString());
			}
			else if (value is bool)
			{
				text = value.ToString().ToLower();
			}
			else
			{
				text = value.ToString();
			}
			string text2;
			if (this.Element.o___0o.00o0oO.)
			{
				text2 = string.Format("var elements = {0};", this.Element.o___0o.00o0oO.);
				text2 += "\r\nfor (var el of elements) {";
				text2 = text2 + "\r\n" + string.Format("el.style.{0} = {1};", binder.Name, text);
				text2 += "\r\n}";
			}
			else
			{
				text2 = string.Format("{0}.style.{1} = {2}", this.Element.o___0o.00o0oO., binder.Name, text);
			}
			o___0o.00o0oO..ExecuteScriptAsync(text2);
			return true;
		}

		// Token: 0x0400055D RID: 1373
		[CompilerGenerated]
		private HElement <<EMPTY_NAME>>;
	}
}
