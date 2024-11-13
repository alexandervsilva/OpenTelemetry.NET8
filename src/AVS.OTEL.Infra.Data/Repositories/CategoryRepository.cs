using AVS.OTEL.Domain.Entities;
using AVS.OTEL.Infra.Data.Contexts;
using Dapper;
using System.Data;

namespace AVS.OTEL.Infra.Data.Repositories
{
    public class CategoryRepository
    {
        private readonly DapperContext _context;

        public CategoryRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            using var conn = _context.CreateConnection();
            var query = "SELECT * FROM Categories";
            var categories = await conn.QueryAsync<Category>(query, commandType: CommandType.Text);
            return categories;
        }
    }
}
