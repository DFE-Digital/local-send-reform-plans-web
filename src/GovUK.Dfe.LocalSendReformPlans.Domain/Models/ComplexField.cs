using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace GovUK.Dfe.LocalSendReformPlans.Domain.Models
{
    public class ComplexField
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
    }
}
