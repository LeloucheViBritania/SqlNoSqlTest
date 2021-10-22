using SqlNoSql.Application.Config;
using SqlNoSql.Application.Dtos.Student;
using SqlNoSql.Application.Wrapper;
using SqlNoSql.Sql.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace SqlNoSql.Application.Commands.CreateStudent
{
    public class CreateStudentCommandHandler : IHandlerWrapper<CreateStudentCommand, StudentDto>
    {
        private readonly DbSqlContext _dbSqlContext;
        public CreateStudentCommandHandler(DbSqlContext dbSqlContext)
        {
            _dbSqlContext = dbSqlContext;
        }
        public async Task<Response<StudentDto>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _dbSqlContext.Students.AddAsync(new Core.Entities.Student()
            {
                Age = request.Age,
                Name = request.Name
            }, cancellationToken);

            return Response.Ok<StudentDto>(new StudentDto
            {
                Id = student.Entity.Id,
                Age = student.Entity.Age,
                Name = student.Entity.Name
            });
        }
    }
}
