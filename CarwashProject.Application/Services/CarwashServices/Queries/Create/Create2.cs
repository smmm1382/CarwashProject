using CarwashProject.Application.Interfaces;
using CarwashProject.Common.Dto.Result;
using CarwashProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.CarwashServices.Queries.Create;


public class Create2 : ICreate2
{
    private readonly IAppDbContext _context;
    public Create2(IAppDbContext context)
    {
        _context = context;
    }
    public ResultDto<CreateServiceDto> Execute(CreateServiceDto createService)
    {
        Service service1 = new Service()
        {
            Name = createService.Name,
            Price = createService.Price,
        };
        _context.Services.Add(service1);
        _context.SaveChanges();

        return new ResultDto<CreateServiceDto>()
        {
            IsSuccess = true,
            Message = "خدمات شما با موفقیت اضافه شد",
            StatusCode = 200,
            Data = createService
        };
    }
}
