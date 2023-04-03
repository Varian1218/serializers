using Newtonsoft.Json;

namespace Serializers
{
    public class JsonSerializer : ISerializer
    {
        private JsonConverter[] _converters;

        private JsonConverter[] Converters
        {
            set => _converters = value;
        }

        public T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value, _converters);
        }

        public string Serialize<T>(T value)
        {
            return JsonConvert.SerializeObject(value, _converters);
        }
    }
}