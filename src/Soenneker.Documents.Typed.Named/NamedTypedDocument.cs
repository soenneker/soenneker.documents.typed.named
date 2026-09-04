using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Documents.Typed.Named.Abstract;

namespace Soenneker.Documents.Typed.Named;

/// <inheritdoc cref="INamedTypedDocument" />
public abstract class NamedTypedDocument : TypedDocument, INamedTypedDocument
{
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public virtual string Name { get; set; } = null!;
}
