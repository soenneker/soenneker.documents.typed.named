using Soenneker.Documents.Named.Abstract;
using Soenneker.Documents.Typed.Abstract;

namespace Soenneker.Documents.Typed.Named.Abstract;

/// <summary>
/// Essentially just adds Name to the document <para/>
/// <inheritdoc cref="ITypedDocument"/>
/// </summary>
public interface INamedTypedDocument : INamedDocument, ITypedDocument;