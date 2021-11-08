using System;
using System.IO;
using Newtonsoft.Json;

namespace DesignPatternsTests
{
    public class JsonDataReader
    {
        public static T GetFromPath<T>(string path)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
        }
    }
}
