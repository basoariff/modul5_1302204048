using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Class1
{
	internal class SayaTubeVideo
	{
		private int id;
		private string title;
		public int playCount;

		public SayaTubeVideo(string title)
		{
			Contract.Requires(title != null);
			Contract.Requires(title.Length < 100);

			this.title = title;
			Random random = new Random();
			id = random.Next(0, 100000);
			playCount = 0;
		}

		public void IncreasePlayCount(int count)
		{
			try
			{
				if (count >= 10000000) throw new Exception("Input Melebihi 10.000.000!");
				playCount = playCount + count;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			public void PrintVideoDetails()
			{
				Console.WriteLine("ID : " + id);
				Console.WriteLine("TITLE : " + title);
				Console.WriteLine("PLAYCOUNT : " + playCount);
			}
		}
	}
}
