using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hubster.Abstractions.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PackageServiceType

    {
        Internal = 1,
        Evaluation = 2,
        Basic = 3,
        Professional = 4,
        Premium = 5,
        Ultima = 6,
    }
}
