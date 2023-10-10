using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.CarwashServices.Queries.GetWorker;

public class GetService : IGetService
{
    private readonly IAppDbContext _context;
    public GetService(IAppDbContext context)
    {
        _context = context;
    }

    public ResultDto<List<ServiceDto>> Execute()
    {
        var service = _context.Services.Select(d => new ServiceDto
        {
            Name = d.Name,
            Price = d.Price,
        }).ToList();

        return new ResultDto<List<ServiceDto>>
        {
            IsSuccess = true,
            Message = "ok",
            StatusCode = 200,
            Data = service
        };
    }
}




