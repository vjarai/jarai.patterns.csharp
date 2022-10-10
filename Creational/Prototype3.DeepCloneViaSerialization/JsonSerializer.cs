using Newtonsoft.Json;

namespace Jarai.Patterns.Creational.Prototype.DeepCloneViaSerialization
{
    public static class JsonSerializer
    {
        public static T Clone<T>(this T source)
        {
            var serialized = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}