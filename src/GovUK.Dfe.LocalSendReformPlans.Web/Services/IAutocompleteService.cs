namespace GovUK.Dfe.LocalSendReformPlans.Web.Services
{
    public interface IAutocompleteService
    {
        Task<List<object>> SearchAsync(string complexFieldId, string query);
    }
} 
