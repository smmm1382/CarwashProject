using CarwashProject.Common.Dto.Result;
using CarwashProject.Dto;

namespace CarwashProject.Application.Services.Workers.Queries.Delete;

public interface IDelete
{
    ResultDto Execute(int id);
}
