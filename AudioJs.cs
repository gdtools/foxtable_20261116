using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000104 RID: 260
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class AudioJs
	{
		// Token: 0x06000E5E RID: 3678 RVA: 0x000745EF File Offset: 0x000727EF
		public void Play(params object[] args)
		{
			if (args.Length == 1)
			{
				this.Play(Conversions.ToString(args[0]));
				return;
			}
			if (args.Length == 2)
			{
				this.Play(Conversions.ToString(args[0]), (AudioPlayMode)Conversions.ToInteger(args[1]));
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00074622 File Offset: 0x00072822
		public void Play(string file)
		{
			OO_00oOO.Audio.Play(file);
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0007462F File Offset: 0x0007282F
		public void Play(string file, AudioPlayMode mode)
		{
			OO_00oOO.Audio.Play(file, mode);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0007463D File Offset: 0x0007283D
		public void Stop()
		{
			OO_00oOO.Audio.Stop();
		}
	}
}
