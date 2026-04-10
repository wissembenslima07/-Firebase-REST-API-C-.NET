using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await Create();


    }
    static async Task Create()
    {
        var Api = new ApiHandler()
        {
            Url = "https://fir-2026-bf25f-default-rtdb.firebaseio.com/Info.json",
            Method = HttpMethod.Post,
            Body = """
            
            {
                "Anime":{
                        "Name":"Dragon Ball Z",
                         "Protagonist":"Goku"


                        }
            }
            
            """

        };
        var response = await Api.SendRequest();
        if (response.StatusCode == HttpStatusCode.OK) 
        {
            Console.WriteLine("Data  created succefuly");


         }
        else
            {
            Console.WriteLine($"Error:{response.StatusCode}");


        }

    }
}
