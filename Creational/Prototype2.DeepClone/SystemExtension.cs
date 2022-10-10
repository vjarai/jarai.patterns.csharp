using Newtonsoft.Json;

namespace Jarai.Patterns.Creational.Prototype.DeepClone
{
    public static class SystemExtension
    {
        public static T Clone<T>(this T source)
        {
            var serialized = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}