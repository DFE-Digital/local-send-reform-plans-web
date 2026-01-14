using GovUK.Dfe.LocalSendReformPlans.Application.Interfaces;
using GovUK.Dfe.LocalSendReformPlans.Domain.Models;

namespace GovUK.Dfe.LocalSendReformPlans.Infrastructure.Services
{
    public class ComplexFieldRendererFactory(IEnumerable<IComplexFieldRenderer> renderers)
        : IComplexFieldRendererFactory
    {
        public IComplexFieldRenderer GetRenderer(string fieldType)
        {
            var renderer = renderers.FirstOrDefault(r => r.FieldType.Equals(fieldType, StringComparison.OrdinalIgnoreCase));
            return renderer ?? renderers.FirstOrDefault(r => r.FieldType == "autocomplete" || r.FieldType == "upload"); // Default to autocomplete or upload
        }
    }
} 
