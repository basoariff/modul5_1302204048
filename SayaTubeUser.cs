using System;

public class Clas
{
	public class SayaTubeUser()
	{
		private int id;
		private List<SayaTubeVideo> UploadVideos;
		private string Username;

	public SayaTubeUser(String)
    {
		
    }

	public int GetTotalVideoPlayCount()
    {

    }

	public void AddVideo(SayaTubeVideo uploadedVideos)
    {
		UploadVideos.Add(uploadedVideos);
    }

	public void PrintAllVideoPlaycount()
    {
		UploadVideos.Clear();
    }
	}
}
