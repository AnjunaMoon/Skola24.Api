using Skola24.Api.DTO;
using Skola24.Infrasctructure.Repositories;
using System;
using System.Threading.Tasks;

namespace Skola24.Api.Application
{
    public class GetTotalAbsenceQueryHandler : IQueryHandlerAsync<GetTotalAbsenceQuery, TotalAbsenceResponse>
    {
        private readonly ISchoolRepository _repository;
        public GetTotalAbsenceQueryHandler(ISchoolRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<TotalAbsenceResponse> HandleAsync(GetTotalAbsenceQuery query)
        {
            var response = new TotalAbsenceResponse();
            try
            {
                response.Absence = await _repository.GetTotalAbsence(query.SchoolName);
            }
            catch
            {
                response.IsSuccess = false;
            }

            return response;
        }
    }
}