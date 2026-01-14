using GovUK.Dfe.LocalSendReformPlans.Domain.Models;

namespace GovUK.Dfe.LocalSendReformPlans.Application.Interfaces;

public interface IFormTemplateParser
{
    Task<FormTemplate> ParseAsync(Stream templateStream, CancellationToken cancellationToken = default);
}
