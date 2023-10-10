using CarwashProject.Common.Dto.Result;
using CarwashProject.Dto;
namespace CarwashProject.Application.Services.Workers.Queries.Update;

public interface IUpdate
{
    ResultDto<UpdateWorkerDto> Execute(UpdateWorkerDto updateWorker);
}
