using System;
using System.Text;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes
using Crestron.SimplSharp.Net.Http;


namespace httptest
{
	public class WWWGo
	{
		public string ipa = "http://10.71.4.128";
		//public int port = 80;
		//private string baseUrl;
        HttpClient myClient = new HttpClient();
        HttpClientRequest myClientRequest = new HttpClientRequest();
        HttpClientResponse myClientResponse;
        
        public WWWGo()
	    {
	    }
    
        public string callToWeb()
        {
            string result = "";
            //myClient.Port = port;
            //result = myClient.Get(IPAddress);
            //Console.Write("this webpage said: {0}", result);
            try
            {
                myClientRequest.Url.Parse(ipa);
                myClientResponse = myClient.Dispatch(myClientRequest);

                result = myClientResponse.ContentString;
            }
            catch(Exception e)
            {
                CrestronConsole.PrintLine("Something went wrong = {0}", e);
            }
            return (result);
        }
    }
}