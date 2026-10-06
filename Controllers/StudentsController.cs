using Microsoft.AspNetCore.Mvc;
using UniversityAcademicApi.DTOs;
using UniversityAcademicApi.Services;

namespace UniversityAcademicApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController(IStudentService studentService) : ControllerBase
{


    [HttpPost]
    [ProducesResponseType(typeof(ResponseModel<bool>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseModel<bool>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ResponseModel<bool>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateStudentAsync([FromBody]StudentCreateDto dto)
    {
        var result = await studentService.CreateStudentAsync(dto);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(typeof(ResponseModel<bool>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseModel<bool>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ResponseModel<bool>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateStudent([FromRoute] Guid id, [FromBody]StudentCreateDto dto)
    {
        var result = await studentService.UpdateStudentAsync(id, dto);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(ResponseModel<bool>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseModel<bool>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ResponseModel<bool>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeleteStudent([FromRoute] Guid id)
    {
        var result = await studentService.DeleteStudentAsync(id);
        return result.Success ? Ok(result) : NotFound(result);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseModel<IEnumerable<StudentDto>>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseModel<IEnumerable<StudentDto>>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ResponseModel<IEnumerable<StudentDto>>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllStudents()
    {
        var result = await studentService.GetAllStudentsAsync();
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpGet("get-by-matric-number")]
    [ProducesResponseType(typeof(ResponseModel<StudentDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseModel<StudentDto>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ResponseModel<StudentDto>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetStudentByMatricNumber([FromQuery] string matricNumber)
    {
        var result = await studentService.GetStudentByMatricNumberAsync(matricNumber);
        return result.Success ? Ok(result) : NotFound(result);
    }
}
