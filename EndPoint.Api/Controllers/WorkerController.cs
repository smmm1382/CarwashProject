using CarwashProject.Application.Services.Workers.Queries.Create;
using CarwashProject.Application.Services.Workers.Queries.Delete;
using CarwashProject.Application.Services.Workers.Queries.GetWorker;
using CarwashProject.Application.Services.Workers.Queries.GetWorkerById;
using CarwashProject.Application.Services.Workers.Queries.Update;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace EndPoint.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class WorkerController : ControllerBase
{
    private readonly IGetWorkerService _getWorker;
    private readonly IGetWorkerByIdService _getWorkerById;
    private readonly ICreate _create;
    private readonly IDelete _delete;
    private readonly IUpdate _update;
    public WorkerController(IGetWorkerService getWorker, IGetWorkerByIdService getWorkerById, ICreate create, IDelete delete, IUpdate update)
    {
        getWorker = _getWorker;
        getWorkerById = _getWorkerById;
        create = _create;
        delete = _delete;
        update = _update;
    }

    [HttpGet]
    public IActionResult GetWorker()
    {
        var worker = _getWorker.Execute();
        return Ok(worker);
    }

    [HttpGet]
    public IActionResult Get(int id)
    {
        var worker = _getWorkerById.Execute(id);
        return Ok(worker);
    }

    [HttpPost]

    public IActionResult Create(CreateDto create)
    {
        var worker = _create.Execute(create);
        return Ok(worker);
    }

    [HttpDelete]

    public IActionResult Delete(int id)
    {
        var worker = _delete.Execute(id);
        return Ok(worker);
    }

    [HttpPut]

    public IActionResult Update(UpdateWorkerDto updateWorkerDto)
    {
        var worker = _update.Execute(updateWorkerDto);
        return Ok(worker);
    }
}

