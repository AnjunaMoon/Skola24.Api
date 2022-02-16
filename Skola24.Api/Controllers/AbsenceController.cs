using Microsoft.AspNetCore.Mvc;
using Skola24.Api.Application;
using Skola24.Api.DTO;
using System;
using System.Threading.Tasks;

namespace Skola24.Api.Controllers
{
    [ApiController]
    [Route("api/absence")]
    public class AbsenceController : ControllerBase
    {
        private readonly IQueryHandlerAsync<GetTotalAbsenceQuery, TotalAbsenceResponse> _getTotalAbsenceQueryHandler;

        public AbsenceController(IQueryHandlerAsync<GetTotalAbsenceQuery, TotalAbsenceResponse> getTotalAbsenceQueryHandler)
        {
            _getTotalAbsenceQueryHandler = getTotalAbsenceQueryHandler ?? throw new ArgumentNullException(nameof(getTotalAbsenceQueryHandler));
        }

        [HttpGet]
        public async Task<ActionResult> GetTotalAbsence([FromQuery]GetTotalAbsenceQuery query)
        {
            var average = await _getTotalAbsenceQueryHandler.HandleAsync(query);

            return Ok(average);
        }
    }
}