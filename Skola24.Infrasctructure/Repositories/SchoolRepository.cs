using Microsoft.EntityFrameworkCore;
using Skola24.Infrasctructure.DAL;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Skola24.Infrasctructure.Repositories
{
    public interface ISchoolRepository
    {
        Task<int> GetTotalAbsence(string schoolName);
    }

    public class SchoolRepository : ISchoolRepository
    {
        private readonly SchoolContext _context = null;

        public SchoolRepository(SchoolContext context)
        {
            _context = context;
        }

        public async Task<int> GetTotalAbsence(string schoolName)
        {
            FormattableString query = @$"
            DECLARE @total int; 
            EXEC @total = fnGetTotalAbsenceForSchool @schoolName = {schoolName}; 
            SELECT @total AS GetTotalAbsence";

            var result = _context.GetTotalAbsence.FromSqlInterpolated(query);
            var list = await result.ToListAsync();
            return list.FirstOrDefault().GetTotalAbsence;
        }
    }
}
