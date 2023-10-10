using CarwashProject.Common.Dto.Result;
using CarwashProject.Dto;

namespace CarwashProject.Application.Services.Workers.Queries.Create;

public interface ICreate
{
    ResultDto<CreateDto> Execute(CreateDto worker);
}

