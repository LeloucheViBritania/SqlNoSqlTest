using SqlNoSql.Application.Dtos.Student;
using SqlNoSql.Application.Wrapper;
using System.Collections.Generic;

namespace SqlNoSql.Application.Commands.CreateStudent
{
    public class CreateStudentCommand : IRequestWrapper<StudentDto>
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
