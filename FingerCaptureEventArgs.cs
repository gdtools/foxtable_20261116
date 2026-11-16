using System;
using System.ComponentModel;
using System.Drawing;
using DPFP;
using DPFP.Capture;

namespace Foxtable
{
	// Token: 0x02000251 RID: 593
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FingerCaptureEventArgs
	{
		// Token: 0x06001C4F RID: 7247 RVA: 0x000C4AA8 File Offset: 0x000C2CA8
		public FingerCaptureEventArgs(string A_0, Sample A_1)
		{
			this.OOO_.00. = A_0;
			this.OOO_.00. = A_1;
		}

		/// <summary>
		/// 字符型，返回捕获的指纹特征，用于和指纹模板进行比对
		/// </summary>
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x000C4ABE File Offset: 0x000C2CBE
		public string Features
		{
			get
			{
				return this.OOO_.00.;
			}
		}

		/// <summary>
		/// Image类型，返回捕获的指纹图片
		/// </summary>
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x000C4AC8 File Offset: 0x000C2CC8
		public Image Image
		{
			get
			{
				SampleConversion sampleConversion = new SampleConversion();
				Bitmap result = null;
				sampleConversion.ConvertToPicture(this.OOO_.00., ref result);
				return result;
			}
		}

		/// <summary>
		/// 将捕获的指纹图片保存为一个文件
		/// </summary>
		/// <param name="fileName"></param>
		// Token: 0x06001C52 RID: 7250 RVA: 0x000C4AEB File Offset: 0x000C2CEB
		public void SaveToFile(string fileName)
		{
			this.Image.Save(fileName, O_O0OO.OoO_00._.(fileName));
		}

		// Token: 0x04000BFD RID: 3069
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BFE RID: 3070
		private Sample <<EMPTY_NAME>>;
	}
}
