using Soenneker.Documents.Named.Abstract;
using Soenneker.Documents.Typed.Abstract;

namespace Soenneker.Documents.Typed.Named.Abstract;

/// <summary>
/// Defines a typed document that has a name.
/// </summary>
public interface INamedTypedDocument : INamedDocument, ITypedDocument;
