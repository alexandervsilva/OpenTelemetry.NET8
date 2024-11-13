using AVS.OTEL.Domain.Entities;
using AVS.OTEL.Infra.Data.Contexts;
using Dapper;

namespace AVS.OTEL.Infra.Data.Repositories
{
    public class UserRepository
    {
        private readonly DapperContext _context;

        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        public User Authenticate(string username, string password)
        {
            using (var conn = _context.CreateConnection())
            {
                var query = "UsersGetByUserAndPassword";
                var parameters = new DynamicParameters();
                parameters.Add("username", username);
                parameters.Add("password", password);

                var user = conn.QuerySingleOrDefault<User>(
                    query, 
                    param: parameters, 
                    commandType: System.Data.CommandType.StoredProcedure
                ) ?? throw new InvalidOperationException("User not found.");
                
                return user;
            }
        }
    }
}
