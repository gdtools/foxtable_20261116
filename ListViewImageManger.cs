using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001B5 RID: 437
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class ListViewImageManger
	{
		// Token: 0x06001548 RID: 5448 RVA: 0x000987F2 File Offset: 0x000969F2
		public ListViewImageManger(ListView A_0)
		{
			this.oOO_O_.OOO0o_. = A_0;
			this.oo.oO_. = A_0.LargeImageList;
			this.OO._0_o. = A_0.SmallImageList;
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x00098819 File Offset: 0x00096A19
		// (set) Token: 0x0600154A RID: 5450 RVA: 0x00098826 File Offset: 0x00096A26
		public Size LargeSize
		{
			get
			{
				return this.oo.oO_..ImageSize;
			}
			set
			{
				this.oo.oO_..ImageSize = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x00098834 File Offset: 0x00096A34
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x00098841 File Offset: 0x00096A41
		public Size SmallSize
		{
			get
			{
				return this.OO._0_o..ImageSize;
			}
			set
			{
				this.OO._0_o..ImageSize = value;
			}
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x0009884F File Offset: 0x00096A4F
		public void AddImage(string Key, string SmallImageFile, string LargeImageFile)
		{
			if (Operators.CompareString(LargeImageFile, "", true) > 0)
			{
				this.AddLargeImage(Key, LargeImageFile);
			}
			if (Operators.CompareString(SmallImageFile, "", true) > 0)
			{
				this.AddSmallImage(Key, SmallImageFile);
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00098880 File Offset: 0x00096A80
		public void AddLargeImage(string Key, string ImageFile)
		{
			if (!this.oo.oO_..Images.ContainsKey(Key))
			{
				Image image = OO_00oOO.GetImage(ImageFile);
				if (image != null)
				{
					this.oo.oO_..Images.Add(Key, image);
					return;
				}
				this.oo.oO_..Images.Add(Key, new Bitmap(this.LargeSize.Width, this.LargeSize.Height));
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x000988F0 File Offset: 0x00096AF0
		public void AddSmallImage(string Key, string ImageFile)
		{
			if (!this.OO._0_o..Images.ContainsKey(Key))
			{
				Image image = OO_00oOO.GetImage(ImageFile);
				if (image != null)
				{
					this.OO._0_o..Images.Add(Key, image);
					return;
				}
				this.OO._0_o..Images.Add(Key, new Bitmap(this.SmallSize.Width, this.SmallSize.Height));
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0009895F File Offset: 0x00096B5F
		public void RemoveImage(string Key)
		{
			this.RemoveLargeImage(Key);
			this.RemoveSmallImage(Key);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0009896F File Offset: 0x00096B6F
		public void RemoveLargeImage(string Key)
		{
			if (this.oo.oO_..Images.ContainsKey(Key))
			{
				this.oo.oO_..Images.RemoveByKey(Key);
			}
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00098995 File Offset: 0x00096B95
		public void RemoveSmallImage(string Key)
		{
			if (this.OO._0_o..Images.ContainsKey(Key))
			{
				this.oo.oO_..Images.RemoveByKey(Key);
			}
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x000989BB File Offset: 0x00096BBB
		public void Clear()
		{
			this.LargeImages.Clear();
			this.SmallImages.Clear();
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x000989D3 File Offset: 0x00096BD3
		public ImageList.ImageCollection LargeImages
		{
			get
			{
				return this.oo.oO_..Images;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x000989E0 File Offset: 0x00096BE0
		public ImageList.ImageCollection SmallImages
		{
			get
			{
				return this.OO._0_o..Images;
			}
		}

		// Token: 0x0400085B RID: 2139
		private ImageList <<EMPTY_NAME>>;

		// Token: 0x0400085C RID: 2140
		private ImageList <<EMPTY_NAME>>;

		// Token: 0x0400085D RID: 2141
		private ListView <<EMPTY_NAME>>;
	}
}
