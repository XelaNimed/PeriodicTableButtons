using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ButtonExample
{
    public static class NewtonsoftUtils
    {
        public static T DeserializeFileContent<T>(string path) where T : class
            => DeserializeFileContent<T>(path, Encoding.UTF8);

        public static T DeserializeFileContent<T>(string path,
            Encoding encoding,
            int bufferSize = 65536,
            bool detectEncodingFromBOM = true) where T : class
        {
            int bs = bufferSize is > 65536 or < 0
                ? 65536
                : bufferSize;

            using var sr = new StreamReader(path, encoding, detectEncodingFromBOM, bs);
            JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings()
            {
                FloatParseHandling = FloatParseHandling.Double,
                Formatting = Formatting.Indented,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Include
            });
            return serializer.Deserialize(sr, typeof(T)) as T;
        }
    }
}
