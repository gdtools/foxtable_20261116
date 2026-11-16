using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002B1 RID: 689
	[oO0oooo("1963")]
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FileSystemWatcher
	{
		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x0010EE12 File Offset: 0x0010D012
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x0010EE1C File Offset: 0x0010D01C
		private virtual FileSystemWatcher fw
		{
			[CompilerGenerated]
			get
			{
				return this.oooOO.OO.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				FileSystemEventHandler value2 = new FileSystemEventHandler(this.oO.O_O0.);
				FileSystemEventHandler value3 = new FileSystemEventHandler(this.oO.o0_O_.);
				FileSystemEventHandler value4 = new FileSystemEventHandler(this.oooOO.OO.);
				FileSystemWatcher fileSystemWatcher = this.oooOO.OO.;
				if (fileSystemWatcher != null)
				{
					fileSystemWatcher.Changed -= value2;
					fileSystemWatcher.Created -= value3;
					fileSystemWatcher.Deleted -= value4;
				}
				this.oooOO.OO. = value;
				fileSystemWatcher = this.oooOO.OO.;
				if (fileSystemWatcher != null)
				{
					fileSystemWatcher.Changed += value2;
					fileSystemWatcher.Created += value3;
					fileSystemWatcher.Deleted += value4;
				}
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x0010EE95 File Offset: 0x0010D095
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x0010EEA0 File Offset: 0x0010D0A0
		private virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this.oooOO.OO.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ElapsedEventHandler value2 = new ElapsedEventHandler(this.oooOO.OO.);
				Timer timer = this.oooOO.OO.;
				if (timer != null)
				{
					timer.Elapsed -= value2;
				}
				this.oooOO.OO. = value;
				timer = this.oooOO.OO.;
				if (timer != null)
				{
					timer.Elapsed += value2;
				}
			}
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x0010EEE4 File Offset: 0x0010D0E4
		public FileSystemWatcher()
		{
			this.fw = new FileSystemWatcher();
			this.oooOO.OO. = new Dictionary<string, FileSystemEventArgs>();
			this.Timer1 = new Timer();
			this.fw.NotifyFilter = (NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.CreationTime);
			this.fw.IncludeSubdirectories = true;
			this.fw.EnableRaisingEvents = false;
			this.Timer1.Interval = 1000.0;
			this.Timer1.Enabled = false;
		}

		/// <summary>
		/// 是否启用文件监视器
		/// </summary>
		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x0010EF5D File Offset: 0x0010D15D
		// (set) Token: 0x060024E8 RID: 9448 RVA: 0x0010EF6A File Offset: 0x0010D16A
		public bool Enabled
		{
			get
			{
				return this.fw.EnableRaisingEvents;
			}
			set
			{
				if (Operators.CompareString(this.fw.Path, "", true) == 0)
				{
					value = false;
				}
				this.fw.EnableRaisingEvents = value;
			}
		}

		/// <summary>
		/// 监视目录的路径
		/// </summary>
		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x0010EF93 File Offset: 0x0010D193
		// (set) Token: 0x060024EA RID: 9450 RVA: 0x0010EFA0 File Offset: 0x0010D1A0
		public string Path
		{
			get
			{
				return this.fw.Path;
			}
			set
			{
				if (Operators.CompareString(value, "", true) > 0 && System.IO.Path.GetFullPath(value).EndsWith(":\\"))
				{
					value = "";
				}
				if (Operators.CompareString(value, "", true) > 0 && (OO_00oOO.FileSys.FileExists(value) || OO_00oOO.FileSys.DirectoryExists(value)))
				{
					this.fw.Path = value;
				}
			}
		}

		/// <summary>
		/// 监控的文件类型，例如要监控文本文件，可以设置为"*.txt"；
		/// </summary>
		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x0010F00A File Offset: 0x0010D20A
		// (set) Token: 0x060024EC RID: 9452 RVA: 0x0010F017 File Offset: 0x0010D217
		public string Filter
		{
			get
			{
				return this.fw.Filter;
			}
			set
			{
				this.fw.Filter = value;
			}
		}

		/// <summary>
		/// 设置事件延迟触发时间，默认为500毫秒
		/// </summary>
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x0010F025 File Offset: 0x0010D225
		// (set) Token: 0x060024EE RID: 9454 RVA: 0x0010F032 File Offset: 0x0010D232
		public double Delay
		{
			get
			{
				return this.Timer1.Interval;
			}
			set
			{
				this.Timer1.Interval = Math.Max(100.0, value);
			}
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x0010F050 File Offset: 0x0010D250
		private void <<EMPTY_NAME>>(object A_0, FileSystemEventArgs A_1)
		{
			if (this.oooOO.OO..ContainsKey(A_1.FullPath))
			{
				if (this.oooOO.OO.[A_1.FullPath].ChangeType == WatcherChangeTypes.Created)
				{
					return;
				}
				this.oooOO.OO..Remove(A_1.FullPath);
			}
			this.oooOO.OO..Add(A_1.FullPath, A_1);
			if (!this.Timer1.Enabled)
			{
				this.Timer1.Enabled = true;
			}
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x0010F0C8 File Offset: 0x0010D2C8
		private void <<EMPTY_NAME>>(object A_0, FileSystemEventArgs A_1)
		{
			if (this.oooOO.OO..ContainsKey(A_1.FullPath))
			{
				this.oooOO.OO..Remove(A_1.FullPath);
			}
			this.oooOO.OO..Add(A_1.FullPath, A_1);
			if (!this.Timer1.Enabled)
			{
				this.Timer1.Enabled = true;
			}
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x0010F128 File Offset: 0x0010D328
		private void <<EMPTY_NAME>>(object A_0, FileSystemEventArgs A_1)
		{
			if (this.oooOO.OO..ContainsKey(A_1.FullPath))
			{
				this.oooOO.OO..Remove(A_1.FullPath);
			}
			this.oooOO.OO..Add(A_1.FullPath, A_1);
			if (!this.Timer1.Enabled)
			{
				this.Timer1.Enabled = true;
			}
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x0010F188 File Offset: 0x0010D388
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void initialize()
		{
			this.Timer1.SynchronizingObject = Main.OO_O.o.;
			ProjectProperty o0_00o.o0__o. = O_O0OO.O0_00o.o0__o.;
			this.Enabled = false;
			this.Delay = (double)o0_00o.o0__o..FWDelay;
			if (Operators.CompareString(o0_00o.o0__o..FWPath, "", true) > 0 && (OO_00oOO.FileSys.FileExists(o0_00o.o0__o..FWPath) || OO_00oOO.FileSys.DirectoryExists(o0_00o.o0__o..FWPath)))
			{
				this.Path = o0_00o.o0__o..FWPath;
				this.Enabled = o0_00o.o0__o..FWEnabled;
			}
			this.Filter = o0_00o.o0__o..FWFilter;
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x0010F220 File Offset: 0x0010D420
		private void <<EMPTY_NAME>>(object A_0, ElapsedEventArgs A_1)
		{
			this.Timer1.Enabled = false;
			string text = "";
			try
			{
				Dictionary<string, FileSystemEventArgs>.KeyCollection.Enumerator enumerator = this.oooOO.OO..Keys.GetEnumerator();
				if (enumerator.MoveNext())
				{
					text = enumerator.Current;
				}
			}
			finally
			{
				Dictionary<string, FileSystemEventArgs>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (Operators.CompareString(text, "", true) > 0)
			{
				FileSystemEventArgs fileSystemEventArgs = this.oooOO.OO.[text];
				FileWatchEventArgs fileWatchEventArgs = new FileWatchEventArgs(fileSystemEventArgs);
				switch (fileSystemEventArgs.ChangeType)
				{
				case WatcherChangeTypes.Created:
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "FileCreated", new object[]
					{
						fileWatchEventArgs
					}, false, "文件监视器", false);
					break;
				case WatcherChangeTypes.Deleted:
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "FileDeleted", new object[]
					{
						fileWatchEventArgs
					}, false, "文件监视器", false);
					break;
				case WatcherChangeTypes.Changed:
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "FileChanged", new object[]
					{
						fileWatchEventArgs
					}, false, "文件监视器", false);
					break;
				}
				this.oooOO.OO..Remove(text);
				this.Timer1.Enabled = (this.oooOO.OO..Count > 0);
			}
		}

		// Token: 0x04000F3A RID: 3898
		[AccessedThroughProperty("fw")]
		[CompilerGenerated]
		private FileSystemWatcher <<EMPTY_NAME>>;

		// Token: 0x04000F3B RID: 3899
		private Dictionary<string, FileSystemEventArgs> <<EMPTY_NAME>>;

		// Token: 0x04000F3C RID: 3900
		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private Timer <<EMPTY_NAME>>;
	}
}
