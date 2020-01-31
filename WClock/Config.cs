using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WClock
{
    class Config
    {
        public static async Task<News.Rootobject> Deserialize(string URL)
        {
            var json = await HTTP.GetAsync(URL);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<News.Rootobject>(json);
        }
    }
}
