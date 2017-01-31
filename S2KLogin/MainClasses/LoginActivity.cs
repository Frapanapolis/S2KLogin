using System;
using System.Net.Http;
using Xamarin.Forms;

namespace S2KLogin
{
	public class LoginActivity
	{

		protected void doInBackground()
		{
			try
			{
				
				 
				HttpClient client = new HttpClient();
				// String postURL = "http://192.168.0.129:8080/s2k-web-server-pc/deviceChange.do"; // 한국어 버전
				String postURL = "http://68.71.11.18:8080/s2k-web-server-pc/deviceChange.do"; // 캐나다 버전


				//				if (resEntity != null)
				//				{
				//					dialogSingle(EntityUtils.toString(resEntity));
				//				}

			}
			catch (Exception e)
			{
				e.GetBaseException();
			}

			return;
		}
	}
}
