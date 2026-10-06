using UniversityAcademicApi.DTOs;

namespace UniversityAcademicApi.Services;

public interface IStudentService
{

    public Task<ResponseModel<bool>> CreateStudentAsync(StudentCreateDto request);
    public Task<ResponseModel<bool>> DeleteStudentAsync(Guid id);

    public Task<ResponseModel<IEnumerable<StudentDto>>> GetAllStudentsAsync();  

    public Task<ResponseModel<StudentDto?>> GetStudentByIdAsync(Guid id);
    public Task<ResponseModel<StudentDto?>> GetStudentByMatricNumberAsync(string matricNumber);

    public Task<ResponseModel<bool>> UpdateStudentAsync(Guid id, StudentCreateDto request);
}
