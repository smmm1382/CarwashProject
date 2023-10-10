using CarwashProject.Common.Dto.Result;
using CarwashProject.Dto;

namespace CarwashProject.Application.Services.Workers.Queries.GetWorker;

public interface IGetWorkerService
{
    ResultDto<List<WorkerDto>> Execute();
}
