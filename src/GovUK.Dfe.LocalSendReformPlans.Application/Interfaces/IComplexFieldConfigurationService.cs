using GovUK.Dfe.LocalSendReformPlans.Domain.Models;

namespace GovUK.Dfe.LocalSendReformPlans.Application.Interfaces
{
    public interface IComplexFieldConfigurationService
    {
        ComplexFieldConfiguration GetConfiguration(string complexFieldId);
        bool HasConfiguration(string complexFieldId);
    }
} 
