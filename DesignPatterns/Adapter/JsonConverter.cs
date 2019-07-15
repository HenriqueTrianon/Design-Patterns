using System.Collections.Generic;
using Newtonsoft.Json;

namespace Adapter
{
    public class JsonConverter
    {
        private IEnumerable<Worker> _workers;

        public JsonConverter(IEnumerable<Worker> workers) => _workers = workers;

        public string ConvertToJson()
        {
            return JsonConvert.SerializeObject(_workers, Formatting.Indented);
        }
    }
}
