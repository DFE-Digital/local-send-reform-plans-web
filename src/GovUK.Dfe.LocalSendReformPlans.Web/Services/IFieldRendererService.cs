using GovUK.Dfe.LocalSendReformPlans.Domain.Models;
using Microsoft.AspNetCore.Html;
using TaskModel = GovUK.Dfe.LocalSendReformPlans.Domain.Models.Task;

namespace GovUK.Dfe.LocalSendReformPlans.Web.Services
{
    public interface IFieldRendererService
    {
        Task<IHtmlContent> RenderFieldAsync(Field field, string prefix, string currentValue, string errorMessage, TaskModel currentTask, Page currentPage);
    }
}
