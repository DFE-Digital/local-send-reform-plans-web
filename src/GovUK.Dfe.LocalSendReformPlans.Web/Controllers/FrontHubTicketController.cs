using GovUK.Dfe.ExternalApplications.Api.Client.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GovUK.Dfe.LocalSendReformPlans.Web.Controllers
{
    [ApiController]
    [Route("internal/hub-ticket")]
    public class FrontHubTicketController(IHubAuthClient hubAuthClient) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var resp = await hubAuthClient.CreateHubTicketAsync();

            return Ok(resp);
        }
    }
}
