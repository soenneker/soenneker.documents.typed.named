[![](https://img.shields.io/nuget/v/soenneker.documents.typed.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.documents.typed.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.typed.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.documents.typed.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.documents.typed.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.documents.typed.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.typed.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.documents.typed.named/actions/workflows/codeql.yml)

# Soenneker.Documents.Typed.Named

Provides a typed document base with an additional serialized `Name` field.

## Installation

```bash
dotnet add package Soenneker.Documents.Typed.Named
```

## Usage

```csharp
using Soenneker.Documents.Typed.Named;

public sealed class WorkflowDocument : NamedTypedDocument
{
    public override string EntityType { get; set; } = "workflow";

    public bool Enabled { get; set; }
}

var workflow = new WorkflowDocument
{
    DocumentId = "onboarding",
    PartitionKey = "tenant-7",
    CreatedAt = DateTimeOffset.UtcNow,
    Name = "Customer onboarding",
    Enabled = true
};
```

The inherited fields serialize as `id`, `partitionKey`, `createdAt`, `modifiedAt`, `entityType`, and `name` with both System.Text.Json and Newtonsoft.Json attributes.

Derived classes must implement `EntityType`. `Name` is virtual and can be overridden when a specialized storage model needs different behavior. Neither property is initialized or validated by the package, and no polymorphic serializer is registered automatically.

`INamedTypedDocument` combines `INamedDocument` and `ITypedDocument` without adding members. Use it when persistence or routing code needs the complete identity, timestamp, name, and discriminator contract.
