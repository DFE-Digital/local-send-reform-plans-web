using GovUK.Dfe.LocalSendReformPlans.Application.Interfaces;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using GovUK.Dfe.ExternalApplications.Api.Client.Contracts;

namespace GovUK.Dfe.LocalSendReformPlans.Infrastructure.Stores;

public class ApiTemplateStore(ITemplatesClient templateClient) : ITemplateStore
{
    [ExcludeFromCodeCoverage]
    public async Task<Stream> GetTemplateStreamAsync(string templateId, CancellationToken cancellationToken = default)
    {
        var response = await templateClient.GetLatestTemplateSchemaAsync(new Guid(templateId), cancellationToken);
        var utf8 = Encoding.UTF8.GetBytes(response.JsonSchema);
        return new MemoryStream(utf8);
    }
}
