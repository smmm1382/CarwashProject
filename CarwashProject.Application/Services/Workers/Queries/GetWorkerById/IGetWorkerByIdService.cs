using CarwashProject.Common.Dto.Result;
using CarwashProject.Dto;

namespace CarwashProject.Application.Services.Workers.Queries.GetWorkerById;

public interface IGetWorkerByIdService
{
    ResultDto<WorkerDto> Execute(int id);
}
