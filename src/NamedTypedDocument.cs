using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Documents.Typed.Named.Abstract;

namespace Soenneker.Documents.Typed.Named;

/// <summary>
/// A generic document type for containers that have multiple types of documents that have a name
/// </summary>
public abstract class NamedTypedDocument : TypedDocument, INamedTypedDocument
{
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public virtual string Name { get; set; } = null!;
}
