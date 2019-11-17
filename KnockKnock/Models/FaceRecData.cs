using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using Flurl;
using Flurl.Http;

namespace KnockKnock.Models
{
    
    public class FaceRecData
    {
        //Endpoint: https://westcentralus.api.cognitive.microsoft.com/face/v1.0
        //Key 1: b341f1bd643b4c93bc05165659922eef
        //Key 2: 3d502cae05d245e19411185a74df2b49



        public readonly Microsoft.Azure.CognitiveServices.Vision.Face.IFaceClient faceClient = new FaceClient(
            new ApiKeyServiceClientCredentials("b341f1bd643b4c93bc05165659922eef"),
            new System.Net.Http.DelegatingHandler[] { });





        //public async void CreatePersonGroup()
        //{
        //    //groupname = "family"
        //    var flurl = new FlurlClient();
        //    var response = await "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/persongroups/"
        //    .WithClient(flurl)
        //    .AppendPathSegment("family")
        //    //.SetQueryParams(new { a = 1, b = 2 })
        //    .WithOAuthBearerToken("b341f1bd643b4c93bc05165659922eef")
        //    .PostJsonAsync(new
        //    {
        //        first_name = "Claire",
        //        last_name = "Underwood"
        //    })
        //    .ReceiveJson();
        //} 



        //    private static async Task<string> CreatePersonGroup(string groupname)
        //    {
        //        var url = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + groupname;

        //        using (var client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri(url);

        //            HttpResponseMessage response = await client.GetAsync(url);

        //            if (response.IsSuccessStatusCode)
        //            {
        //                string strResult = await response.Content.ReadAsStringAsync();

        //                return strResult;
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //        }
        //    }

        //   // var result = 

    }




    
}
