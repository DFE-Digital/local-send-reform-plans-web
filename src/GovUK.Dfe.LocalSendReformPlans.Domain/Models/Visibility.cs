using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace GovUK.Dfe.LocalSendReformPlans.Domain.Models;

[ExcludeFromCodeCoverage]
public class Visibility
{
    [JsonPropertyName("default")]
    public bool Default { get; set; }
}
