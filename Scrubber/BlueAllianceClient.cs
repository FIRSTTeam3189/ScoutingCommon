using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ScoutingModels.Data;
using ScoutingModels.Test;

namespace ScoutingModels.Scrubber
{
    public class BlueAllianceClient
    {
        HttpClient client;

        public BlueAllianceClient()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add(BlueAllianceConstants.HeaderKey, BlueAllianceConstants.HeaderValue);
        }

        public async Task<IEnumerable<Event>> GetEvents(int year)
        {
            var reqeustUri = string.Format(
                Path.Combine(BlueAllianceConstants.ApiPath, BlueAllianceConstants.EventsList), year);

            // Get the array from the client
            var array = (await client.GetStreamAsync(reqeustUri)).JArrayFromStream();

            return array.Select(x => x.GetEventFromJToken());
        }
    }
}
