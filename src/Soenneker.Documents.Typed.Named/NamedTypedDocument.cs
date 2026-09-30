using System.Text.Json.Serialization;
using Soenneker.Documents.Typed.Named.Abstract;

namespace Soenneker.Documents.Typed.Named;

/// <inheritdoc cref="INamedTypedDocument" />
public abstract class NamedTypedDocument : TypedDocument, INamedTypedDocument
{
    [JsonPropertyName("name")]
    public virtual string Name { get; set; } = null!;
}
