using System;

namespace Foxtable
{
	// Token: 0x020000F4 RID: 244
	public class cssClassList
	{
		// Token: 0x06000DCF RID: 3535 RVA: 0x00071F13 File Offset: 0x00070113
		public cssClassList(HElement A_0)
		{
			this.o__.OOO_0Oo. = A_0;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00071F24 File Offset: 0x00070124
		public void add(params string[] classNames)
		{
			string text = "";
			foreach (string arg in classNames)
			{
				text += string.Format("'{0}',", arg);
			}
			text = text.Trim(new char[]
			{
				','
			});
			string text2;
			if (this.o__.OOO_0Oo..o___0o.00o0oO.)
			{
				text2 = string.Format("var elements = {0};", this.o__.OOO_0Oo..o___0o.00o0oO.);
				text2 += "\r\nfor (var el of elements) {";
				text2 = text2 + "\r\n" + string.Format("el.classList.add({0});", text);
				text2 += "\r\n}";
			}
			else
			{
				text2 = string.Format("{0}.classList.add({1})", this.o__.OOO_0Oo..o___0o.00o0oO., text);
			}
			this.o__.OOO_0Oo..o___0o.00o0oO..ExecuteScriptAsync(text2);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00071FF0 File Offset: 0x000701F0
		public void remove(params string[] classNames)
		{
			string text = "";
			foreach (string arg in classNames)
			{
				text += string.Format("'{0}',", arg);
			}
			text = text.Trim(new char[]
			{
				','
			});
			string text2;
			if (this.o__.OOO_0Oo..o___0o.00o0oO.)
			{
				text2 = string.Format("var elements = {0};", this.o__.OOO_0Oo..o___0o.00o0oO.);
				text2 += "\r\nfor (var el of elements) {";
				text2 = text2 + "\r\n" + string.Format("el.classList.remove({0});", text);
				text2 += "\r\n}";
			}
			else
			{
				text2 = string.Format("{0}.classList.remove({1})", this.o__.OOO_0Oo..o___0o.00o0oO., text);
			}
			this.o__.OOO_0Oo..o___0o.00o0oO..ExecuteScriptAsync(text2);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x000720BC File Offset: 0x000702BC
		public object contains(string className)
		{
			string text;
			if (this.o__.OOO_0Oo..o___0o.00o0oO.)
			{
				text = string.Format("var elements = {0};", this.o__.OOO_0Oo..o___0o.00o0oO.);
				text += "\r\nfor (var el of elements) {";
				text = text + "\r\n" + string.Format("return el.classList.contains('{0}');", className);
				text += "\r\n}";
			}
			else
			{
				text = string.Format("{0}.classList.contains('{1}')", this.o__.OOO_0Oo..o___0o.00o0oO., className);
			}
			return this.o__.OOO_0Oo..o___0o.00o0oO..ExecuteScriptAsync(text);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00072148 File Offset: 0x00070348
		public object toggle(string className)
		{
			string text;
			if (this.o__.OOO_0Oo..o___0o.00o0oO.)
			{
				text = string.Format("var elements = {0};", this.o__.OOO_0Oo..o___0o.00o0oO.);
				text += "\r\nfor (var el of elements) {";
				text = text + "\r\n" + string.Format("el.classList.toggle('{0}');", className);
				text += "\r\n}";
			}
			else
			{
				text = string.Format("{0}.classList.toggle('{1}')", this.o__.OOO_0Oo..o___0o.00o0oO., className);
			}
			return this.o__.OOO_0Oo..o___0o.00o0oO..ExecuteScriptAsync(text);
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x000721D4 File Offset: 0x000703D4
		public object length
		{
			get
			{
				string text;
				if (this.o__.OOO_0Oo..o___0o.00o0oO.)
				{
					text = string.Format("var elements = {0};", this.o__.OOO_0Oo..o___0o.00o0oO.);
					text += "\r\nfor (var el of elements) {";
					text += "\r\nreturn el.classList.length;";
					text += "\r\n}";
				}
				else
				{
					text = string.Format("{0}.classList.length)", this.o__.OOO_0Oo..o___0o.00o0oO.);
				}
				return this.o__.OOO_0Oo..o___0o.00o0oO..ExecuteScriptAsync(text);
			}
		}

		// Token: 0x0400055C RID: 1372
		internal HElement <<EMPTY_NAME>>;
	}
}
