using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnockKnock.Models
{
    public class CreateGroupModel
    {
        FaceRecData facerec = new FaceRecData();
        public async void CreateKnownContactsGroup()
        {
            string personGroupId = "known_contacts";
            await facerec.faceClient.PersonGroup.CreateAsync(personGroupId, "Known Contacts");
            CreatePersonResult friend1 = await facerec.faceClient.PersonGroupPerson.CreateAsync(
                // Id of the PersonGroup that the person belonged to
                personGroupId,
                // Name of the person
                "Anna"
            );

        }

        //This is called at first start, creating the group of known contacts
        public static async void CreateKnownContactsGroupAPICall()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "b341f1bd643b4c93bc05165659922eef");

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/known_contacts?" + queryString;

            HttpResponseMessage response;

            // Request body
            byte[] byteData = Encoding.UTF8.GetBytes("{body}");

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PutAsync(uri, content);
            }
        }


    }
}
