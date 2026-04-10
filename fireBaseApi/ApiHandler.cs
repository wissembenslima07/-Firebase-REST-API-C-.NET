using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;



internal class ApiHandler
{
    static readonly HttpClient client = new HttpClient();
    public string Url { get; set; }
    public HttpMethod Method { get; set; }
    public string Body { get; set; }

    public async Task<HttpResponseMessage> SendRequest()
    {
        try
        {
            HttpRequestMessage request = new HttpRequestMessage(Method, Url);
            if (Method != HttpMethod.Get || Method != HttpMethod.Delete)
            {
                StringContent content = new StringContent(Body, Encoding.UTF8, "application/json");
                request.Content = content;
            }
            HttpResponseMessage response = await client.SendAsync(request);
            return response;

        }
        catch (Exception ex)
        {
            throw new Exception($"request failed: {ex.Message}");

        }
    }
}

