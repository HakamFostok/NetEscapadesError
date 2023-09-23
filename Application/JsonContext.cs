using NetEscapadesError;
using System.Text.Json.Serialization;

namespace Application;

public class JsonModel
{
    public Enum1 Enum { get; set; }
}

[JsonSerializable(typeof(JsonModel))]
public partial class MyJsonContext : JsonSerializerContext { }