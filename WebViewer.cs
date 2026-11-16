using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;

namespace Foxtable
{
	// Token: 0x02000136 RID: 310
	public class WebViewer : WebView2
	{
		// Token: 0x06000F67 RID: 3943 RVA: 0x00076B00 File Offset: 0x00074D00
		public WebViewer()
		{
			base.NavigationCompleted += this.oO.oO_.;
			this.AreDevToolsEnabled = true;
			this.AreSaveAsEnabled = true;
			this.AreDefaultContextMenusEnabled = true;
			this.AreBrowserAcceleratorKeysEnabled = true;
			this.oo_.0oOOOoooo. = new ConcurrentDictionary<CoreWebView2DownloadOperation, TaskCompletionSource<int>>();
			this.oo_.0oOOOoooo. = new ConcurrentDictionary<CoreWebView2DownloadOperation, EventHandler<object>>();
			this.OoO.oOOoo. = new ConcurrentDictionary<CoreWebView2DownloadOperation, EventHandler<object>>();
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00076B62 File Offset: 0x00074D62
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x00076B6A File Offset: 0x00074D6A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AreDevToolsEnabled { get; set; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00076B73 File Offset: 0x00074D73
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x00076B7B File Offset: 0x00074D7B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AreSaveAsEnabled { get; set; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00076B84 File Offset: 0x00074D84
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00076B8C File Offset: 0x00074D8C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AreDefaultContextMenusEnabled { get; set; }

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x00076B95 File Offset: 0x00074D95
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x00076B9D File Offset: 0x00074D9D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AreBrowserAcceleratorKeysEnabled { get; set; }

		// Token: 0x06000F70 RID: 3952 RVA: 0x00076BA8 File Offset: 0x00074DA8
		public string ValidUrl(string url)
		{
			string result;
			if (string.IsNullOrWhiteSpace(url))
			{
				result = "";
			}
			else
			{
				url = url.Trim();
				Uri uri = null;
				if (Uri.TryCreate(url, UriKind.Absolute, out uri))
				{
					result = url;
				}
				else
				{
					if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
					{
						url = "http://" + url;
						if (Uri.TryCreate(url, UriKind.Absolute, out uri))
						{
							return url;
						}
					}
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00076C1D File Offset: 0x00074E1D
		public object getElementById(string id)
		{
			return new HElement(this, string.Format("document.getElementById(\"{0}\")", id));
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00076C30 File Offset: 0x00074E30
		public object getElementsByName(string name)
		{
			return new HElement(this, string.Format("document.getElementsByName(\"{0}\")", name), true);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00076C44 File Offset: 0x00074E44
		public object getElementsByTagName(string tagName)
		{
			return new HElement(this, string.Format("document.getElementsByTagName(\"{0}\")", tagName), true);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00076C58 File Offset: 0x00074E58
		public object getElementsByClassName(string className)
		{
			return new HElement(this, string.Format("document.getElementsByClassName(\"{0}\")", className), true);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00076C6C File Offset: 0x00074E6C
		public object querySelector(string cssSelector)
		{
			return new HElement(this, string.Format("document.querySelector(\"{0}\")", cssSelector));
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00076C7F File Offset: 0x00074E7F
		public object querySelectorAll(string cssSelector)
		{
			return new HElement(this, string.Format("document.querySelectorAll(\"{0}\")", cssSelector), true);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00076C94 File Offset: 0x00074E94
		public object xpathQuery(object xpath)
		{
			string text = new XCData("\nfunction xpathQuery(xpath) {\n    try {\n        if (typeof xpath !== 'string' || !xpath.trim()) {\n            return null;\n        }\n        const expr = xpath.trim();\n        const evaluator = document.evaluate(\n            expr,\n            document,\n            null,\n            XPathResult.FIRST_ORDERED_NODE_TYPE,\n            null\n        );\n        const node = evaluator.singleNodeValue;\n        return (node && node.nodeType === Node.ELEMENT_NODE) ? node : null;\n    } catch (err) {\n        console.error('[XPath Error]', err.message, '\\nExpression:', xpath);\n        return null;\n    }\n}\n").Value;
			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("(" + text + ")(\"", xpath), "\")"));
			return new HElement(this, text);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00076CE0 File Offset: 0x00074EE0
		public object xpathQueryAll(object xpath)
		{
			string text = new XCData("\nfunction xpathQueryAll(xpath) {\n    try {\n        if (typeof xpath !== 'string' || !xpath.trim()) {\n            return [];\n        }\n        const expr = xpath.trim();\n        const results = [];\n        const evaluator = document.evaluate(\n            expr,\n            document,\n            null,\n            XPathResult.ORDERED_NODE_ITERATOR_TYPE,\n            null\n        );\n        let node;\n        while ((node = evaluator.iterateNext())) {\n            if (node.nodeType === Node.ELEMENT_NODE) {\n                results.push(node);\n            }\n        }\n        return results;\n    } catch (err) {\n        console.error('[XPath Error]', err.message, '\\nExpression:', xpath);\n        return [];\n    }\n}\n").Value;
			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("(" + text + ")(\"", xpath), "\")"));
			return new HElement(this, text, true);
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00076D2B File Offset: 0x00074F2B
		public object activeElement
		{
			get
			{
				return new HElement(this, "document.activeElement");
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x00076D38 File Offset: 0x00074F38
		public object body
		{
			get
			{
				return new HElement(this, "document.body");
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00076D45 File Offset: 0x00074F45
		public object head
		{
			get
			{
				return new HElement(this, "document.head");
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00076D52 File Offset: 0x00074F52
		public object documentElement
		{
			get
			{
				return new HElement(this, "document.documentElement");
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00076D5F File Offset: 0x00074F5F
		public object window
		{
			get
			{
				return new HElement(this, "window");
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x00076D6C File Offset: 0x00074F6C
		public object document
		{
			get
			{
				return new HElement(this, "document");
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x00076D79 File Offset: 0x00074F79
		public object navigator
		{
			get
			{
				return new HElement(this, "navigator");
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x00076D86 File Offset: 0x00074F86
		public object localStorage
		{
			get
			{
				return new HStorage(this, "window.localStorage");
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00076D93 File Offset: 0x00074F93
		public object sessionStorage
		{
			get
			{
				return new HStorage(this, "window.sessionStorage");
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00076DA0 File Offset: 0x00074FA0
		public Task<ExpandoObject> GetElementInfoFromPoint(int x, int y)
		{
			WebViewer.OOoo0O__0o_o oooo0O__0o_o = default(WebViewer.OOoo0O__0o_o);
			oooo0O__0o_o.O__O0.o0O0. = this;
			oooo0O__0o_o.OO__.oO0_OoO_. = x;
			oooo0O__0o_o.o_.O_OOo___O_0. = y;
			oooo0O__0o_o.O__O0.o0O0. = -1;
			oooo0O__0o_o.O__O0.o0O0. = AsyncTaskMethodBuilder<ExpandoObject>.Create();
			oooo0O__0o_o.O__O0.o0O0..Start<WebViewer.OOoo0O__0o_o>(ref oooo0O__0o_o);
			return oooo0O__0o_o.O__O0.o0O0..Task;
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00076DFC File Offset: 0x00074FFC
		public Task<object> GetValueByID(string id)
		{
			WebViewer.OoO00OO0oOo0 ooO00OO0oOo = default(WebViewer.OoO00OO0oOo0);
			ooO00OO0oOo.OOO_._O__0OO. = this;
			ooO00OO0oOo.OOO_._O__0OO. = id;
			ooO00OO0oOo.OOO_._O__0OO. = -1;
			ooO00OO0oOo.OOO_._O__0OO. = AsyncTaskMethodBuilder<object>.Create();
			ooO00OO0oOo.OOO_._O__0OO..Start<WebViewer.OoO00OO0oOo0>(ref ooO00OO0oOo);
			return ooO00OO0oOo.OOO_._O__0OO..Task;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00076E4F File Offset: 0x0007504F
		public Task SetValueByID(string id, object value)
		{
			return this.SetValuesByID(new string[]
			{
				id
			}, new object[]
			{
				value
			});
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00076E6C File Offset: 0x0007506C
		public Task<ExpandoObject> GetValuesByID(IEnumerable<string> ids)
		{
			WebViewer.ooOO0_oo__OO ooOO0_oo__OO = default(WebViewer.ooOO0_oo__OO);
			ooOO0_oo__OO.oO._o0O_0OOo0o. = this;
			ooOO0_oo__OO.oO._o0O_0OOo0o. = ids;
			ooOO0_oo__OO.oO._o0O_0OOo0o. = -1;
			ooOO0_oo__OO.OOO_._O__0OO. = AsyncTaskMethodBuilder<ExpandoObject>.Create();
			ooOO0_oo__OO.OOO_._O__0OO..Start<WebViewer.ooOO0_oo__OO>(ref ooOO0_oo__OO);
			return ooOO0_oo__OO.OOO_._O__0OO..Task;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00076EC0 File Offset: 0x000750C0
		public Task SetValuesByID(IEnumerable<string> ids, IEnumerable<object> values)
		{
			List<string> list = ids.ToList<string>();
			List<object> list2 = values.ToList<object>();
			if (list.Count != list2.Count)
			{
				throw new ArgumentException(string.Format("ID 数量（{0}）与 Value 数量（{1}）不匹配！", list.Count, list2.Count));
			}
			Task result;
			if (list.Count == 0)
			{
				result = Task.CompletedTask;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("(function() {");
				stringBuilder.AppendLine("  function setElementValue(id, value) {");
				stringBuilder.AppendLine("    var elem = document.getElementById(id);");
				stringBuilder.AppendLine("    if (elem && 'value' in elem) {");
				stringBuilder.AppendLine("      elem.value = value ?? ''; // Value 为 Null 时设为空字符串");
				stringBuilder.AppendLine("    }");
				stringBuilder.AppendLine("  }");
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = list[i];
					object objectValue = RuntimeHelpers.GetObjectValue(list2[i]);
					string arg = text.Replace("'", "\\'");
					string arg2 = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(objectValue));
					stringBuilder.AppendLine(string.Format("  setElementValue('{0}', {1});", arg, arg2));
				}
				stringBuilder.AppendLine("})();");
				result = base.ExecuteScriptAsync(stringBuilder.ToString());
			}
			return result;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00076FFC File Offset: 0x000751FC
		public CoreWebView2WebResourceRequest CreateWebResourceRequest(string uri, string Method = "GET", Stream postData = null)
		{
			if (base.CoreWebView2 == null)
			{
				throw new InvalidOperationException("WebViewer未初始化!");
			}
			return base.CoreWebView2.Environment.CreateWebResourceRequest(uri, Method, postData, null);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00077025 File Offset: 0x00075225
		public void NavigateWithWebResourceRequest(CoreWebView2WebResourceRequest Request)
		{
			if (base.CoreWebView2 == null)
			{
				throw new InvalidOperationException("WebViewer未初始化!");
			}
			base.CoreWebView2.NavigateWithWebResourceRequest(Request);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00077048 File Offset: 0x00075248
		public Task<int> NavigateWithWebResourceRequestAsync(CoreWebView2WebResourceRequest request, int timeoutSeconds = 30)
		{
			WebViewer.OOOo_0_O_0_0 oooo_0_O_0_ = default(WebViewer.OOOo_0_O_0_0);
			oooo_0_O_0_.oo_oO_0o.oo00. = this;
			oooo_0_O_0_.oo_oO_0o.oo00. = request;
			oooo_0_O_0_.OOO.O00_00_o_0. = timeoutSeconds;
			oooo_0_O_0_.oo_oO_0o.oo00. = -1;
			oooo_0_O_0_.oO._o0O_0OOo0o. = AsyncTaskMethodBuilder<int>.Create();
			oooo_0_O_0_.oO._o0O_0OOo0o..Start<WebViewer.OOOo_0_O_0_0>(ref oooo_0_O_0_);
			return oooo_0_O_0_.oO._o0O_0OOo0o..Task;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000770A3 File Offset: 0x000752A3
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2NavigationCompletedEventArgs A_1)
		{
			if (this.oo_.0oOOOoooo. != null && !this.oo_.0oOOOoooo..Task.IsCompleted)
			{
				if (A_1.IsSuccess)
				{
					this.oo_.0oOOOoooo..TrySetResult(0);
					return;
				}
				this.oo_.0oOOOoooo..TrySetResult(-1);
			}
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000770E4 File Offset: 0x000752E4
		public Task<int> NavigationTaskAsync(int timeoutSeconds = 30)
		{
			WebViewer.oO__ oO__ = default(WebViewer.oO__);
			oO__.Ooo.0O__00O. = this;
			oO__.o__00o.0_oO_o_. = timeoutSeconds;
			oO__.Ooo.0O__00O. = -1;
			oO__.Ooo.0O__00O. = AsyncTaskMethodBuilder<int>.Create();
			oO__.Ooo.0O__00O..Start<WebViewer.oO__>(ref oO__);
			return oO__.Ooo.0O__00O..Task;
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00077137 File Offset: 0x00075337
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x00077149 File Offset: 0x00075349
		public string DefaultDownloadFolderPath
		{
			get
			{
				return base.CoreWebView2.Profile.DefaultDownloadFolderPath;
			}
			set
			{
				base.CoreWebView2.Profile.DefaultDownloadFolderPath = value;
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0007715C File Offset: 0x0007535C
		public void OpenDefaultDownloadDialog()
		{
			base.CoreWebView2.OpenDefaultDownloadDialog();
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00077169 File Offset: 0x00075369
		public void CloseDefaultDownloadDialog()
		{
			base.CoreWebView2.CloseDefaultDownloadDialog();
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00077176 File Offset: 0x00075376
		public object IsDefaultDownloadDialogOpen
		{
			get
			{
				return base.CoreWebView2.IsDefaultDownloadDialogOpen;
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00077188 File Offset: 0x00075388
		public void DownLoadFile(string url, string fileName)
		{
			if (Path.IsPathRooted(fileName))
			{
				this.DefaultDownloadFolderPath = OO_00oOO.FileSys.GetParentPath(fileName);
			}
			fileName = OO_00oOO.FileSys.GetName(fileName);
			string text = new XCData("\n(function(downloadUrl, fileName) {\n    var a = document.createElement('a');\n    a.style.display = 'none';\n    a.href = downloadUrl;\n    a.download = fileName;\n    document.body.appendChild(a);\n    a.click();\n    document.body.removeChild(a);\n})").Value;
			text = string.Concat(new string[]
			{
				text,
				"(\"",
				url,
				"\",\"",
				fileName.Replace("\\", "\\\\"),
				"\")"
			});
			base.ExecuteScriptAsync(text);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00077214 File Offset: 0x00075414
		public Task<CoreWebView2DownloadOperation> DownloadTaskAsync(int timeoutSeconds = 30)
		{
			WebViewer.oO__O00O oO__O00O = default(WebViewer.oO__O00O);
			oO__O00O.O00O.o_. = this;
			oO__O00O.O0oOo00O0o_.O. = timeoutSeconds;
			oO__O00O.Ooo.0O__00O. = -1;
			oO__O00O.Ooo.0O__00O. = AsyncTaskMethodBuilder<CoreWebView2DownloadOperation>.Create();
			oO__O00O.Ooo.0O__00O..Start<WebViewer.oO__O00O>(ref oO__O00O);
			return oO__O00O.Ooo.0O__00O..Task;
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00077268 File Offset: 0x00075468
		internal void <<EMPTY_NAME>>()
		{
			base.Stop();
			foreach (CoreWebView2DownloadOperation coreWebView2DownloadOperation in this.oo_.0oOOOoooo..Keys.ToArray<CoreWebView2DownloadOperation>())
			{
				EventHandler<object> value = null;
				if (this.oo_.0oOOOoooo..TryGetValue(coreWebView2DownloadOperation, out value))
				{
					coreWebView2DownloadOperation.StateChanged -= value;
				}
			}
			foreach (CoreWebView2DownloadOperation coreWebView2DownloadOperation2 in this.OoO.oOOoo..Keys.ToArray<CoreWebView2DownloadOperation>())
			{
				EventHandler<object> value2 = null;
				if (this.OoO.oOOoo..TryGetValue(coreWebView2DownloadOperation2, out value2))
				{
					coreWebView2DownloadOperation2.BytesReceivedChanged -= value2;
				}
			}
			foreach (CoreWebView2DownloadOperation coreWebView2DownloadOperation3 in this.oo_.0oOOOoooo..Keys.ToArray<CoreWebView2DownloadOperation>())
			{
				if (coreWebView2DownloadOperation3.State == CoreWebView2DownloadState.InProgress)
				{
					coreWebView2DownloadOperation3.Cancel();
				}
			}
			this.oo_.0oOOOoooo..Clear();
			this.OoO.oOOoo..Clear();
			this.oo_.0oOOOoooo..Clear();
		}

		// Token: 0x04000608 RID: 1544
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000609 RID: 1545
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400060A RID: 1546
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400060B RID: 1547
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400060C RID: 1548
		private TaskCompletionSource<int> <<EMPTY_NAME>>;

		// Token: 0x0400060D RID: 1549
		internal ConcurrentDictionary<CoreWebView2DownloadOperation, TaskCompletionSource<int>> <<EMPTY_NAME>>;

		// Token: 0x0400060E RID: 1550
		internal TaskCompletionSource<CoreWebView2DownloadOperation> <<EMPTY_NAME>>;

		// Token: 0x0400060F RID: 1551
		internal ConcurrentDictionary<CoreWebView2DownloadOperation, EventHandler<object>> <<EMPTY_NAME>>;

		// Token: 0x04000610 RID: 1552
		internal ConcurrentDictionary<CoreWebView2DownloadOperation, EventHandler<object>> <<EMPTY_NAME>>;

		// Token: 0x0200013A RID: 314
		[CompilerGenerated]
		internal sealed class OOO_
		{
			// Token: 0x06000F9B RID: 3995 RVA: 0x00077832 File Offset: 0x00075A32
			internal void <<EMPTY_NAME>>(object A_0, CoreWebView2NavigationCompletedEventArgs A_1)
			{
				if (A_1.IsSuccess)
				{
					this.oo_.0oOOOoooo..TrySetResult(0);
					return;
				}
				this.oo_.0oOOOoooo..TrySetResult(-1);
			}

			// Token: 0x04000624 RID: 1572
			public TaskCompletionSource<int> <<EMPTY_NAME>>;
		}
	}
}
