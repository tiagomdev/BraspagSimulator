using BraspagTest.Commands;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BraspagTest.Services
{
    public class BraspagService
    {
        const string EndpointCommand = @"https://apisandbox.braspag.com.br/";
        const string EndpointQuery = @"https://apiquerysandbox.braspag.com.br/";

        public async Task<dynamic> RequestPaymentCreditCard(CreditCardRequestCommand command)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(EndpointCommand + "v2/sales/");
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            httpWebRequest.Headers["MerchantId"] = "660c0fe6-5a6c-48b0-bfe9-46e9c83c5a36";
            httpWebRequest.Headers["MerchantKey"] = "IPEXNZEXUYRRYGTWTGHCGDKWKPJFPBSHSBZIKIIA";  
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(command);

                streamWriter.Write(json);
                streamWriter.Flush();
            }

            var response = await httpWebRequest.GetResponseAsync();

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var resultBody = streamReader.ReadToEnd();

                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(resultBody);

                return result;
            }
        }
    }
}
