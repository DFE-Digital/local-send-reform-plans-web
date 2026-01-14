namespace GovUK.Dfe.LocalSendReformPlans.Application.Interfaces;

public interface ITemplateStore
{
    Task<Stream> GetTemplateStreamAsync(string templateId, CancellationToken cancellationToken = default);
}
