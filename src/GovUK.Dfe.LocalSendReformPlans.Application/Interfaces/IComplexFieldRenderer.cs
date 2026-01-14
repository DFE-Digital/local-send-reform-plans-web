using GovUK.Dfe.LocalSendReformPlans.Domain.Models;

namespace GovUK.Dfe.LocalSendReformPlans.Application.Interfaces
{
    public interface IComplexFieldRenderer
    {
        string FieldType { get; }
        string Render(ComplexFieldConfiguration configuration, string complexFieldId, string currentValue, string errorMessage, string label, string tooltip, bool isRequired);
    }
} 
