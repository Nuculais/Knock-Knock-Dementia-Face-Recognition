using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using System.Net.Http;
using System.Net.Http.Headers;

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
            

            


        private static async Task<string> CreatePersonGroup(string groupname)
        {
            var url = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + groupname;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string strResult = await response.Content.ReadAsStringAsync();

                    return strResult;
                }
                else
                {
                    return null;
                }
            }
        }

       // var result = 

    }




    
}
