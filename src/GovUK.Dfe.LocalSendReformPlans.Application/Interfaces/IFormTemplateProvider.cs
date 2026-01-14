using GovUK.Dfe.LocalSendReformPlans.Domain.Models;

namespace GovUK.Dfe.LocalSendReformPlans.Application.Interfaces;

public interface IFormTemplateProvider
{
    Task<FormTemplate> GetTemplateAsync(string templateId, CancellationToken cancellationToken = default);
}
