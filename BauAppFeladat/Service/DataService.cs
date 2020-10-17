using BauAppFeladat.Model;
using BauAppFeladat.WebReference;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BauAppFeladat.Service
{
    class DataService
    {
        static readonly HttpClient client = new HttpClient();
        public static Root data { get; set; }
        public static async Task getData()
        {
            var userName = "umanaccount";
            var passwd = "TesztFeladat1";

            client.BaseAddress = new Uri("https://sandbox.mobilengine.com");
            client.DefaultRequestHeaders.Add("User-Agent", "C# console program");
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

            var authToken = Encoding.ASCII.GetBytes($"{userName}:{passwd}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));

            var url = "services/comex/v2/uman/users";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();
            data = JsonConvert.DeserializeObject<Root>(resp);
        }

        public static void postData()
        {
            var service = new WebReference.Wdx { Url = "https://sandbox.mobilengine.com/Services/Wdx/Wdx.svc/apikey" };
            service.EnqueueDacs(createDacs());
        }

        public static Dacs createDacs()
        {
            Dacs dacs = new Dacs();
            Data data = new Data();
            DacsContent dacsContent = new DacsContent();
            List<DataUser> usersData = new List<DataUser>();
            DataUser dataUser = new DataUser();
            foreach (var item in DataService.data.result)
            {
                dataUser.UserId = item.userId;
                dataUser.UserName = item.usern;
                dataUser.EmailAddress = item.emailAddress;
                dataUser.DisplayName = item.displayName;
                dataUser.Created = item.created.ToString();
                usersData.Add(dataUser);
            }
            data.User = usersData.ToArray();
            dacsContent.Item = data;
            dacs.Key = "59db143cd0d4473a8f489ab6c986f6d6";
            dacs.Content = dacsContent;
            dacs.dacsid = "0";
            dacs.dtu = System.DateTime.Now;
            dacs.meta = new DacsMeta();
            return dacs;
        }
    }
}
