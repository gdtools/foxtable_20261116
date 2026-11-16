using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000105 RID: 261
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ClipBoardJs
	{
		// Token: 0x06000E63 RID: 3683 RVA: 0x00074651 File Offset: 0x00072851
		public void SetDataObject(object data)
		{
			Clipboard.SetDataObject(RuntimeHelpers.GetObjectValue(data));
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0007465E File Offset: 0x0007285E
		public void SetImage(Image image)
		{
			Clipboard.SetImage(image);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00074666 File Offset: 0x00072866
		public void SetData(string format, object data)
		{
			Clipboard.SetData(format, RuntimeHelpers.GetObjectValue(data));
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00074674 File Offset: 0x00072874
		public void SetAudio(Stream audioStream)
		{
			Clipboard.SetAudio(audioStream);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0007467C File Offset: 0x0007287C
		public void SetAudio(byte[] audioBytes)
		{
			Clipboard.SetAudio(audioBytes);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00074684 File Offset: 0x00072884
		public void SetText(string text)
		{
			Clipboard.SetText(text);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0007468C File Offset: 0x0007288C
		public void SetText(string text, TextDataFormat format)
		{
			Clipboard.SetText(text, format);
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00074695 File Offset: 0x00072895
		public void Clear()
		{
			Clipboard.Clear();
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0007469C File Offset: 0x0007289C
		public void SetDataObject(object data, bool copy, int retryTimes, int retryDelay)
		{
			Clipboard.SetDataObject(RuntimeHelpers.GetObjectValue(data), copy, retryTimes, retryDelay);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000746AD File Offset: 0x000728AD
		public void SetDataObject(object data, bool copy)
		{
			Clipboard.SetDataObject(RuntimeHelpers.GetObjectValue(data), copy);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x000746BB File Offset: 0x000728BB
		public bool ContainsImage()
		{
			return Clipboard.ContainsImage();
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x000746C2 File Offset: 0x000728C2
		public bool ContainsText()
		{
			return Clipboard.ContainsText();
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x000746C9 File Offset: 0x000728C9
		public bool ContainsText(TextDataFormat format)
		{
			return Clipboard.ContainsText(format);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x000746D1 File Offset: 0x000728D1
		public bool ContainsData(string format)
		{
			return Clipboard.ContainsData(format);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x000746D9 File Offset: 0x000728D9
		public object GetData(string format)
		{
			return Clipboard.GetData(format);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x000746E1 File Offset: 0x000728E1
		public Image GetImage()
		{
			return Clipboard.GetImage();
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x000746E8 File Offset: 0x000728E8
		public string GetText()
		{
			return Clipboard.GetText();
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x000746EF File Offset: 0x000728EF
		public string GetText(TextDataFormat format)
		{
			return Clipboard.GetText(format);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x000746F7 File Offset: 0x000728F7
		public bool ContainsAudio()
		{
			return Clipboard.ContainsAudio();
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x000746FE File Offset: 0x000728FE
		public IDataObject GetDataObject()
		{
			return Clipboard.GetDataObject();
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00074705 File Offset: 0x00072905
		public bool ContainsFileDropList()
		{
			return Clipboard.ContainsFileDropList();
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0007470C File Offset: 0x0007290C
		public Stream GetAudioStream()
		{
			return Clipboard.GetAudioStream();
		}
	}
}
