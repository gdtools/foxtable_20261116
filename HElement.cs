using System;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace Foxtable
{
	// Token: 0x020000F6 RID: 246
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class HElement : DynamicObject
	{
		// Token: 0x06000DDA RID: 3546 RVA: 0x000723C9 File Offset: 0x000705C9
		internal HElement(WebViewer A_0, string A_1)
		{
			this.o___0o.00o0oO. = A_0;
			this.o___0o.00o0oO. = A_1;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x000723DF File Offset: 0x000705DF
		internal HElement(WebViewer A_0, string A_1, bool A_2)
		{
			this.o___0o.00o0oO. = A_0;
			this.o___0o.00o0oO. = A_1;
			this.o___0o.00o0oO. = A_2;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x000723FC File Offset: 0x000705FC
		public CSSStyle style
		{
			get
			{
				if (this.o___0o.00o0oO. == null)
				{
					this.o___0o.00o0oO. = new CSSStyle(this);
				}
				return this.o___0o.00o0oO.;
			}
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00072418 File Offset: 0x00070618
		private bool <<EMPTY_NAME>>(string A_0)
		{
			string left = A_0.ToLower();
			return Operators.CompareString(left, "attributes", true) == 0 || Operators.CompareString(left, "childNodes", true) == 0 || Operators.CompareString(left, "firstChild", true) == 0 || Operators.CompareString(left, "lastChild", true) == 0 || Operators.CompareString(left, "nextSibling", true) == 0 || Operators.CompareString(left, "ownerDocument", true) == 0 || Operators.CompareString(left, "parentNode", true) == 0 || Operators.CompareString(left, "previousSibling", true) == 0 || Operators.CompareString(left, "__proto__", true) == 0 || Operators.CompareString(left, "constructor", true) == 0 || Operators.CompareString(left, "prototype", true) == 0;
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x000724D0 File Offset: 0x000706D0
		public object localStorage
		{
			get
			{
				return new HStorage(this.o___0o.00o0oO., "localStorage");
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x000724E2 File Offset: 0x000706E2
		public object sessionStorage
		{
			get
			{
				return new HStorage(this.o___0o.00o0oO., "sessionStorage");
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x000724F4 File Offset: 0x000706F4
		public object length
		{
			get
			{
				string script = string.Format("{0}.length", this.o___0o.00o0oO.);
				return this.o___0o.00o0oO..ExecuteScriptAsync(script);
			}
		}

		// Token: 0x17000224 RID: 548
		public object this[int A_0]
		{
			get
			{
				string a_ = string.Format("{0}[{1}]", this.o___0o.00o0oO., A_0);
				return new HElement(this.o___0o.00o0oO., a_);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00072550 File Offset: 0x00070750
		public object caption
		{
			get
			{
				string a_ = string.Format("{0}.caption", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x0007257C File Offset: 0x0007077C
		public object rows
		{
			get
			{
				string a_ = string.Format("{0}.rows", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_, true);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x000725A8 File Offset: 0x000707A8
		public object cells
		{
			get
			{
				string a_ = string.Format("{0}.cells", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_, true);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x000725D4 File Offset: 0x000707D4
		public object tBodies
		{
			get
			{
				string a_ = string.Format("{0}.tBodies", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_, true);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00072600 File Offset: 0x00070800
		public object tHead
		{
			get
			{
				string a_ = string.Format("{0}.tHead", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x0007262C File Offset: 0x0007082C
		public object dataset
		{
			get
			{
				string a_ = string.Format("{0}.dataset", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00072658 File Offset: 0x00070858
		public object validity
		{
			get
			{
				string a_ = string.Format("{0}.validity", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x00072684 File Offset: 0x00070884
		public object tFoot
		{
			get
			{
				string a_ = string.Format("{0}.tFoot", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x000726B0 File Offset: 0x000708B0
		public object parentElement
		{
			get
			{
				string a_ = string.Format("{0}.parentElement", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x000726DC File Offset: 0x000708DC
		public object children
		{
			get
			{
				string a_ = string.Format("{0}.children", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_, true);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x00072708 File Offset: 0x00070908
		public object firstElementChild
		{
			get
			{
				string a_ = string.Format("{0}.firstElementChild", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x00072734 File Offset: 0x00070934
		public object lastElementChild
		{
			get
			{
				string a_ = string.Format("{0}.lastElementChild", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00072760 File Offset: 0x00070960
		public object previousElementSibling
		{
			get
			{
				string a_ = string.Format("{0}.previousElementSibling", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x0007278C File Offset: 0x0007098C
		public object nextElementSibling
		{
			get
			{
				string a_ = string.Format("{0}.nextElementSibling", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x000727B6 File Offset: 0x000709B6
		public cssClassList classList
		{
			get
			{
				if (this.o___0o.00o0oO. == null)
				{
					this.o___0o.00o0oO. = new cssClassList(this);
				}
				return this.o___0o.00o0oO.;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x000727D4 File Offset: 0x000709D4
		public object elements
		{
			get
			{
				string a_ = string.Format("{0}.elements", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., a_)
				{
					o0O.00_O. = true
				};
			}
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00072808 File Offset: 0x00070A08
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool TryGetMember(GetMemberBinder binder, ref object result)
		{
			bool result2;
			if (this.Ooo_.o_.(binder.Name))
			{
				result2 = false;
			}
			else
			{
				string text;
				if (this.o___0o.00o0oO.)
				{
					text = string.Format("var elements = {0};", this.o___0o.00o0oO.);
					text = text + "\r\n" + string.Format("elements[0]?.{0};", binder.Name);
				}
				else
				{
					text = string.Format("{0}.{1}", this.o___0o.00o0oO., binder.Name);
				}
				if (this.o0O.00_O.)
				{
					result = new HElement(this.o___0o.00o0oO., string.Format("{0}.{1}", this.o___0o.00o0oO., binder.Name));
				}
				else
				{
					result = this.o___0o.00o0oO..ExecuteScriptAsync(text);
				}
				result2 = true;
			}
			return result2;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000728B8 File Offset: 0x00070AB8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			bool result;
			if (this.Ooo_.o_.(binder.Name))
			{
				result = false;
			}
			else
			{
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
				if (this.o___0o.00o0oO.)
				{
					text2 = string.Format("var elements = {0};", this.o___0o.00o0oO.);
					text2 += "\r\nfor (var el of elements) {";
					text2 = text2 + "\r\n" + string.Format("el.{0}= {1};", binder.Name, text);
					text2 += "\r\n}";
				}
				else
				{
					text2 = string.Format("{0}.{1} = {2}", this.o___0o.00o0oO., binder.Name, text);
				}
				this.o___0o.00o0oO..ExecuteScriptAsync(text2);
				result = true;
			}
			return result;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00072990 File Offset: 0x00070B90
		public object getAttribute(string AttrName)
		{
			string text;
			if (this.o___0o.00o0oO.)
			{
				text = string.Format("var elements = {0};", this.o___0o.00o0oO.);
				text = text + "\r\n" + string.Format("elements[0]?.getAttribute(\"{0}\");", AttrName);
			}
			else
			{
				text = string.Format("{0}.getAttribute(\"{1}\")", this.o___0o.00o0oO., AttrName);
			}
			return this.o___0o.00o0oO..ExecuteScriptAsync(text);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000729F0 File Offset: 0x00070BF0
		public object hasAttribute(string attrName)
		{
			string text;
			if (this.o___0o.00o0oO.)
			{
				text = string.Format("var elements = {0};", this.o___0o.00o0oO.);
				text = text + "\r\n" + string.Format("elements[0]?.hasAttribute(\"{0}\");", attrName);
			}
			else
			{
				text = string.Format("{0}.hasAttribute(\"{1}\")", this.o___0o.00o0oO., attrName);
			}
			return this.o___0o.00o0oO..ExecuteScriptAsync(text);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00072A50 File Offset: 0x00070C50
		public object setAttribute(string AttrName, string Value)
		{
			string text;
			if (this.o___0o.00o0oO.)
			{
				text = string.Format("var elements = {0};", this.o___0o.00o0oO.);
				text += "\r\nfor (var el of elements) {";
				text = text + "\r\n" + string.Format("el.setAttribute(\"{0}\",\"{1}\");", AttrName, Value);
				text += "\r\n}";
			}
			else
			{
				text = string.Format("{0}.setAttribute(\"{1}\",\"{2}\")", this.o___0o.00o0oO., AttrName, Value);
			}
			return this.o___0o.00o0oO..ExecuteScriptAsync(text);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00072AC8 File Offset: 0x00070CC8
		public object removeAttribute(string AttrName)
		{
			string text;
			if (this.o___0o.00o0oO.)
			{
				text = string.Format("var elements = {0};", this.o___0o.00o0oO.);
				text += "\r\nfor (var el of elements) {";
				text = text + "\r\n" + string.Format("el.removeAttribute(\"{0}\");", AttrName);
				text += "\r\n}";
			}
			else
			{
				text = string.Format("{0}.removeAttribute(\"{1}\")", this.o___0o.00o0oO., AttrName);
			}
			return this.o___0o.00o0oO..ExecuteScriptAsync(text);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00072B40 File Offset: 0x00070D40
		public object Click()
		{
			string script = string.Format("{0}.click()", this.o___0o.00o0oO.);
			this.o___0o.00o0oO..ExecuteScriptAsync(script);
			object result;
			return result;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00072B6C File Offset: 0x00070D6C
		public object normalize()
		{
			string script = string.Format("{0}.normalize()", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00072B98 File Offset: 0x00070D98
		public object focus()
		{
			string script = string.Format("{0}.focus()", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00072BC4 File Offset: 0x00070DC4
		public object hasFocus()
		{
			string script = string.Format("{0}.hasFocus()", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00072BF0 File Offset: 0x00070DF0
		public object blur()
		{
			string script = string.Format("{0}.blur()", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00072C1C File Offset: 0x00070E1C
		public object select()
		{
			string script = string.Format("{0}.select()", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00072C48 File Offset: 0x00070E48
		public object prompt(params string[] args)
		{
			string script = "";
			if (args.Length == 0)
			{
				script = string.Format("{0}.prompt()", this.o___0o.00o0oO.);
			}
			else if (args.Length == 1)
			{
				script = string.Format("{0}.prompt({1})", this.o___0o.00o0oO., JsonConvert.ToString(args[0]));
			}
			else if (args.Length == 2)
			{
				script = string.Format("{0}.prompt({1},{2})", this.o___0o.00o0oO., JsonConvert.ToString(args[0]), JsonConvert.ToString(args[1]));
			}
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00072CC8 File Offset: 0x00070EC8
		public object print()
		{
			string script = string.Format("{0}.print()", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00072CF4 File Offset: 0x00070EF4
		public object alert(string message)
		{
			message = JsonConvert.ToString(message);
			string script = string.Format("{0}.alert({1})", this.o___0o.00o0oO., message);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00072D28 File Offset: 0x00070F28
		public object confirm(string message)
		{
			message = JsonConvert.ToString(message);
			string script = string.Format("{0}.confirm({1})", this.o___0o.00o0oO., message);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00072D5C File Offset: 0x00070F5C
		public object atob(string str)
		{
			str = JsonConvert.ToString(str);
			string script = string.Format("{0}.atob({1})", this.o___0o.00o0oO., str);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00072D90 File Offset: 0x00070F90
		public object btoa(string encodedStr)
		{
			encodedStr = JsonConvert.ToString(encodedStr);
			string script = string.Format("{0}.btoa({1})", this.o___0o.00o0oO., encodedStr);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00072DC4 File Offset: 0x00070FC4
		public object scrollIntoView(object arg = null)
		{
			string script;
			if (arg == null)
			{
				script = string.Format("{0}.scrollIntoView()", this.o___0o.00o0oO.);
			}
			else if (arg is bool)
			{
				string arg2 = "false";
				if (Conversions.ToBoolean(arg))
				{
					arg2 = "true";
				}
				script = string.Format("{0}.scrollIntoView({1})", this.o___0o.00o0oO., arg2);
			}
			else
			{
				string arg3 = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(arg));
				script = string.Format("{0}.scrollIntoView({1})", this.o___0o.00o0oO., arg3);
			}
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00072E44 File Offset: 0x00071044
		public Task<object> createCaption()
		{
			HElement.o__oOo00 o__oOo = default(HElement.o__oOo00);
			o__oOo.O00.Ooo0OO_O. = this;
			o__oOo.O00.Ooo0OO_O. = -1;
			o__oOo.o___0o.00o0oO. = AsyncTaskMethodBuilder<object>.Create();
			o__oOo.o___0o.00o0oO..Start<HElement.o__oOo00>(ref o__oOo);
			return o__oOo.o___0o.00o0oO..Task;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00072E90 File Offset: 0x00071090
		public Task<object> createTFoot()
		{
			HElement.O0_O o0_O = default(HElement.O0_O);
			o0_O.O00.Ooo0OO_O. = this;
			o0_O.O00.Ooo0OO_O. = -1;
			o0_O.O00.Ooo0OO_O. = AsyncTaskMethodBuilder<object>.Create();
			o0_O.O00.Ooo0OO_O..Start<HElement.O0_O>(ref o0_O);
			return o0_O.O00.Ooo0OO_O..Task;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00072EDC File Offset: 0x000710DC
		public Task<object> createTHead()
		{
			HElement.O0o00_O o0o00_O = default(HElement.O0o00_O);
			o0o00_O.o_O._o0Oo000. = this;
			o0o00_O.o_O._o0Oo000. = -1;
			o0o00_O.o_O._o0Oo000. = AsyncTaskMethodBuilder<object>.Create();
			o0o00_O.o_O._o0Oo000..Start<HElement.O0o00_O>(ref o0o00_O);
			return o0o00_O.o_O._o0Oo000..Task;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00072F28 File Offset: 0x00071128
		public object deleteCaption()
		{
			string script = string.Format("{0}.deleteCaption();", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00072F54 File Offset: 0x00071154
		public object deleteTFoot()
		{
			string script = string.Format("{0}.deleteTFoot();", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00072F80 File Offset: 0x00071180
		public object deleteTHead()
		{
			string script = string.Format("{0}.deleteTHead();", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00072FAC File Offset: 0x000711AC
		public object deleteRow(int index)
		{
			string script = string.Format("{0}.deleteRow({1});", this.o___0o.00o0oO., index);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00072FDC File Offset: 0x000711DC
		public Task<object> insertRow(int index)
		{
			HElement.OoO0 ooO = default(HElement.OoO0);
			ooO.O__0_0O_O.0. = this;
			ooO.o00O_.O. = index;
			ooO.o_O._o0Oo000. = -1;
			ooO.o_O._o0Oo000. = AsyncTaskMethodBuilder<object>.Create();
			ooO.o_O._o0Oo000..Start<HElement.OoO0>(ref ooO);
			return ooO.o_O._o0Oo000..Task;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00073030 File Offset: 0x00071230
		public object deleteCell(int index)
		{
			string script = string.Format("{0}.deleteCell({1});", this.o___0o.00o0oO., index);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00073060 File Offset: 0x00071260
		public Task<object> insertCell(int index)
		{
			HElement.O_o_ o_o_ = default(HElement.O_o_);
			o_o_.O__0_0O_O.0. = this;
			o_o_.o.Ooo_o. = index;
			o_o_.O__0_0O_O.0. = -1;
			o_o_.O__0_0O_O.0. = AsyncTaskMethodBuilder<object>.Create();
			o_o_.O__0_0O_O.0..Start<HElement.O_o_>(ref o_o_);
			return o_o_.O__0_0O_O.0..Task;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x000730B3 File Offset: 0x000712B3
		public object getElementsByClassName(string className)
		{
			return new HElement(this.o___0o.00o0oO., string.Format("{0}.getElementsByClassName(\"{1}\")", this.o___0o.00o0oO., className), true);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x000730D2 File Offset: 0x000712D2
		public object getElementsByTagName(string tagName)
		{
			return new HElement(this.o___0o.00o0oO., string.Format("{0}.getElementsByTagName(\"{1}\")", this.o___0o.00o0oO., tagName), true);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x000730F1 File Offset: 0x000712F1
		public object querySelector(string cssSelector)
		{
			return new HElement(this.o___0o.00o0oO., string.Format("{0}.querySelector(\"{1}\")", this.o___0o.00o0oO., cssSelector));
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0007310F File Offset: 0x0007130F
		public object querySelectorAll(string cssSelector)
		{
			return new HElement(this.o___0o.00o0oO., string.Format("{0}.querySelectorAll(\"{1}\")", this.o___0o.00o0oO., cssSelector));
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0007312D File Offset: 0x0007132D
		public object closest(string cssSelector)
		{
			return new HElement(this.o___0o.00o0oO., string.Format("{0}.closest(\"{1}\")", this.o___0o.00o0oO., cssSelector));
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0007314C File Offset: 0x0007134C
		public object matches(string selectors)
		{
			string script = string.Format("{0}.matches(\"{1}\")", this.o___0o.00o0oO., selectors);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00073178 File Offset: 0x00071378
		public object reset()
		{
			string script = string.Format("{0}.reset()", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000731A4 File Offset: 0x000713A4
		public Task<bool> IsNull()
		{
			HElement.Oo_O__oOo_o0o oo_O__oOo_o0o = default(HElement.Oo_O__oOo_o0o);
			oo_O__oOo_o0o.oo00o.__00__Oo. = this;
			oo_O__oOo_o0o.oo00o.__00__Oo. = -1;
			oo_O__oOo_o0o.oo00o.__00__Oo. = AsyncTaskMethodBuilder<bool>.Create();
			oo_O__oOo_o0o.oo00o.__00__Oo..Start<HElement.Oo_O__oOo_o0o>(ref oo_O__oOo_o0o);
			return oo_O__oOo_o0o.oo00o.__00__Oo..Task;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000731F0 File Offset: 0x000713F0
		public Task<bool> checkValidity()
		{
			HElement.OO_oO0o oo_oO0o = default(HElement.OO_oO0o);
			oo_oO0o.oo00o.__00__Oo. = this;
			oo_oO0o.oo00o.__00__Oo. = -1;
			oo_oO0o.oo00o.__00__Oo. = AsyncTaskMethodBuilder<bool>.Create();
			oo_oO0o.oo00o.__00__Oo..Start<HElement.OO_oO0o>(ref oo_oO0o);
			return oo_oO0o.oo00o.__00__Oo..Task;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0007323C File Offset: 0x0007143C
		public Task<bool> reportValidity()
		{
			HElement.o00000O00oo0 o00000O00oo = default(HElement.o00000O00oo0);
			o00000O00oo.O0.O0o. = this;
			o00000O00oo.O0.O0o. = -1;
			o00000O00oo.O0.O0o. = AsyncTaskMethodBuilder<bool>.Create();
			o00000O00oo.O0.O0o..Start<HElement.o00000O00oo0>(ref o00000O00oo);
			return o00000O00oo.O0.O0o..Task;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00073288 File Offset: 0x00071488
		public object setCustomValidity(string message)
		{
			object obj = JsonConvert.ToString(message);
			string script = string.Format("{0}.setCustomValidity({1})", this.o___0o.00o0oO., RuntimeHelpers.GetObjectValue(obj));
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000732C0 File Offset: 0x000714C0
		public Task<bool> hasOwnProperty(string propertyName)
		{
			HElement.O_0__0O_O0 o_0__0O_O = default(HElement.O_0__0O_O0);
			o_0__0O_O.ooo_0.o. = this;
			o_0__0O_O.ooo_0.o. = propertyName;
			o_0__0O_O.ooo_0.o. = -1;
			o_0__0O_O.O0.O0o. = AsyncTaskMethodBuilder<bool>.Create();
			o_0__0O_O.O0.O0o..Start<HElement.O_0__0O_O0>(ref o_0__0O_O);
			return o_0__0O_O.O0.O0o..Task;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00073314 File Offset: 0x00071514
		public object addEventListener(string eventName, string jsCodeorFunction)
		{
			string script;
			if (jsCodeorFunction.Contains("function") || jsCodeorFunction.Contains("=>") || jsCodeorFunction.Contains("{") || jsCodeorFunction.Contains("}"))
			{
				object obj = JsonConvert.ToString(jsCodeorFunction);
				script = string.Format("{0}.addEventListener(\"{1}\", {2})", this.o___0o.00o0oO., eventName, RuntimeHelpers.GetObjectValue(obj));
			}
			else
			{
				script = string.Format("{0}.addEventListener(\"{1}\", {2})", this.o___0o.00o0oO., eventName, jsCodeorFunction);
			}
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00073398 File Offset: 0x00071598
		public object removeEventListener(string eventName, string functionName)
		{
			string script = string.Format("{0}.removeEventListener(\"{1}\", {2})", this.o___0o.00o0oO., eventName, functionName);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x000733C4 File Offset: 0x000715C4
		public object ComputedStyle
		{
			get
			{
				object value = string.Format("getComputedStyle({0})", this.o___0o.00o0oO.);
				return new HElement(this.o___0o.00o0oO., Conversions.ToString(value));
			}
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000733F4 File Offset: 0x000715F4
		public object getBoundingClientRect()
		{
			string script = string.Format("JSON.parse(JSON.stringify({0}.getBoundingClientRect()))", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00073420 File Offset: 0x00071620
		public object scrollTo(int x, int y)
		{
			string script = string.Format("{0}.scrollTo({1},{2})", this.o___0o.00o0oO., x, y);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00073458 File Offset: 0x00071658
		public object scrollBy(int x, int y)
		{
			string script = string.Format("{0}.scrollBy({1},{2})", this.o___0o.00o0oO., x, y);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00073490 File Offset: 0x00071690
		public object insertAdjacentHTML(string position, string html)
		{
			object obj = JsonConvert.ToString(html);
			string script = string.Format("{0}.insertAdjacentHTML(\"{1}\", {2})", this.o___0o.00o0oO., position, RuntimeHelpers.GetObjectValue(obj));
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x000734C8 File Offset: 0x000716C8
		public object insertAdjacentText(string position, string text)
		{
			object obj = JsonConvert.ToString(text);
			string script = string.Format("{0}.insertAdjacentText(\"{1}\", {2})", this.o___0o.00o0oO., position, RuntimeHelpers.GetObjectValue(obj));
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00073500 File Offset: 0x00071700
		public object files
		{
			get
			{
				string script = new XCData("\nJSON.parse(JSON.stringify(Array.from(").Value + this.o___0o.00o0oO. + new XCData(".files).map(f => ({\n    name: f.name,\n    size: f.size,\n    type: f.type,\n    lastModified: f.lastModified,\n    lastModifiedDate: f.lastModifiedDate ? f.lastModifiedDate.toISOString() : null,\n    webkitRelativePath: f.webkitRelativePath || null\n}))))\n").Value;
				return this.o___0o.00o0oO..ExecuteScriptAsync(script);
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00073544 File Offset: 0x00071744
		public object submit()
		{
			string script = string.Format("{0}.submit()", this.o___0o.00o0oO.);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00073570 File Offset: 0x00071770
		public object requestSubmit(HElement button = null)
		{
			string script;
			if (button == null)
			{
				script = string.Format("{0}.requestSubmit()", this.o___0o.00o0oO.);
			}
			else
			{
				script = string.Format("{0}.requestSubmit({1})", this.o___0o.00o0oO., button.o___0o.00o0oO.);
			}
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x000735B8 File Offset: 0x000717B8
		public object stepUp(int step)
		{
			string script = string.Format("{0}.stepUp({1})", this.o___0o.00o0oO., step);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x000735E8 File Offset: 0x000717E8
		public object stepDown(int step)
		{
			string script = string.Format("{0}.stepDown({1})", this.o___0o.00o0oO., step);
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00073618 File Offset: 0x00071818
		public object setSelectionRange(int start, int end, string direction = null)
		{
			string script;
			if (direction != null)
			{
				script = string.Format("{0}.setSelectionRange({1}, {2}, '{3}')", new object[]
				{
					this.o___0o.00o0oO.,
					start,
					end,
					direction
				});
			}
			else
			{
				script = string.Format("{0}.setSelectionRange({1}, {2})", this.o___0o.00o0oO., start, end);
			}
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00073684 File Offset: 0x00071884
		public object setRangeText(string replacement)
		{
			object obj = JsonConvert.ToString(replacement);
			string script = string.Format("{0}.setRangeText({1})", this.o___0o.00o0oO., RuntimeHelpers.GetObjectValue(obj));
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000736BC File Offset: 0x000718BC
		public object setRangeText(string replacement, int start, int end)
		{
			object obj = JsonConvert.ToString(replacement);
			string script = string.Format("{0}.setRangeText({1}, {2}, {3})", new object[]
			{
				this.o___0o.00o0oO.,
				obj,
				start,
				end
			});
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0007370C File Offset: 0x0007190C
		public object setRangeText(string replacement, int start, int end, string selectMode)
		{
			object obj = JsonConvert.ToString(replacement);
			string script = string.Format("{0}.setRangeText({1}, {2}, {3}, '{4}')", new object[]
			{
				this.o___0o.00o0oO.,
				obj,
				start,
				end,
				selectMode
			});
			return this.o___0o.00o0oO..ExecuteScriptAsync(script);
		}

		// Token: 0x0400055E RID: 1374
		internal WebViewer <<EMPTY_NAME>>;

		// Token: 0x0400055F RID: 1375
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000560 RID: 1376
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000561 RID: 1377
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000562 RID: 1378
		private CSSStyle <<EMPTY_NAME>>;

		// Token: 0x04000563 RID: 1379
		private cssClassList <<EMPTY_NAME>>;
	}
}
