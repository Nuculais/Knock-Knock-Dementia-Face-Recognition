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



        private readonly Microsoft.Azure.CognitiveServices.Vision.Face.IFaceClient faceClient = new FaceClient(
            new ApiKeyServiceClientCredentials("<subscription key>"),
            new System.Net.Http.DelegatingHandler[] { });


        public void createPersonGroup()
        {
            //string personGroupId = "myfriends";
            //await faceClient.PersonGroup.CreateAsync(personGroupId, "My Friends");
            //CreatePersonResult friend1 = await faceClient.PersonGroupPerson.CreateAsync(
            //    // Id of the PersonGroup that the person belonged to
            //    personGroupId,
            //    // Name of the person
            //    "Anna"
            //);

            HttpClient client = new HttpClient();
        }

        static async void MakeRequest()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "b341f1bd643b4c93bc05165659922eef");

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/family?" + queryString;

            HttpResponseMessage response;

            // Request body
            byte[] byteData = Encoding.UTF8.GetBytes("{body}");

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PutAsync(uri, content);
            }
        }



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
