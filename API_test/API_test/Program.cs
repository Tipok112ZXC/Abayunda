using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace API_test
{
    class user
    { 
    
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            string URL = "https://reqres.in/api/users/2";
            var request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.Proxy.Credentials = new NetworkCredential("student","student");
            var response = request.GetResponse();
            var respoonse = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            String Text = reader.ReadToEnd();
            var JsonText = JsonConvert.DeserializeObject<User>(Text);
            Console.WriteLine($"{JsonText.data.id}{JsonText.data.last_name}{JsonText.data.first_name}{JsonText.data.email}");
            Console.ReadLine();
            
            
        }
    }
}
