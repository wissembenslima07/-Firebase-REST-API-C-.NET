using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await Get();


    }
    static async Task Get()
    {
        var Api = new ApiHandler()
        {
            Url = "https://fir-2026-bf25f-default-rtdb.firebaseio.com/Info/Anime/2.json",
            Method = HttpMethod.Get,


        };
        var response = await Api.SendRequest();
        if (response.StatusCode == HttpStatusCode.OK)
        {
           string responsebody =await response.Content.ReadAsStringAsync();

            Console.WriteLine(responsebody);
        }
        else
        {
            Console.WriteLine($"Error:{response.StatusCode}");


        }
        Console.ReadKey();

    }
    static async Task Delete()
    {
        var Api = new ApiHandler()
        {
            Url = "https://fir-2026-bf25f-default-rtdb.firebaseio.com/Info/Anime/1.json",
            Method = HttpMethod.Delete,
            
           
        };
        var response = await Api.SendRequest();
        if (response.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Data  Deleted succefuly");


        }
        else
        {
            Console.WriteLine($"Error:{response.StatusCode}");


        }

    }
    static async Task Create()
    {
        var Api = new ApiHandler()
        {
            Url = "https://fir-2026-bf25f-default-rtdb.firebaseio.com/Info/Anime/2.json",
            Method = HttpMethod.Put,
            Body = """
            
            {
                
                        "Name":"wizou",
                         "Protagonist":"wizou"


                        
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
    static async Task CreateWithAutoId()
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
    static async Task Update()
    {
        var Api = new ApiHandler()
        {
            Url = "https://fir-2026-bf25f-default-rtdb.firebaseio.com/Info/Anime/1.json",
            Method = HttpMethod.Patch,
            Body = """
            
            {
                
                        "Name":"Dragon Ball Z",
                         "Protagonist":"sasuke"


                        
            }
            
            """

        };
        var response = await Api.SendRequest();
        if (response.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Data  updated succefuly");


        }
        else
        {
            Console.WriteLine($"Error:{response.StatusCode}");


        }

    }
}
