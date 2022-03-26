using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SayaTubeVideo
{
	internal class SayaTubeVideo
	{
		private int id;
		private string title;
		public int playCount;

	public SayaTubeVideo(string)
		{
			Random random = new Random();
			id = random.Next(0, 100000);
			playCount = 0;
		}

	public void IncreasePlayCount(int count)
		{
			playCount = playCount + count;
		}

	public int GetPlayCount()
		{
			this.uploadedVideos =
		}

	public string GetTitle()
        {
			return title;
        }

	public void PrintAllVideoPlaycount()
		{
			Console.WriteLine("ID : " + id);
			Console.WriteLine("TITLE : " + title);
			Console.WriteLine("PLAYCOUNT : " + playCount);
		}

	}
}
