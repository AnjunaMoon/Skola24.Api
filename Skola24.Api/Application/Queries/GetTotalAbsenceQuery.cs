using Skola24.Api.DTO;

namespace Skola24.Api.Application
{
    public class GetTotalAbsenceQuery : IQuery<TotalAbsenceResponse>
    {
        public string SchoolName { get; set; }
    }
}
