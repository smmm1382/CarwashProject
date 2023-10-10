using CarwashProject.Application.Interfaces;
using CarwashProject.Application.Services.CarwashServices.Queries.GetWorker;
using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.CarwashServices.Queries.Update
{
    public class Update2 : IUpdate2
    {
        private readonly IAppDbContext _context;
        public Update2(IAppDbContext context)
        {
            _context = context;
        }
        public ResultDto<ServiceDto> Execute(ServiceDto serviceDto)
        {
            var service = _context.Services.Find(serviceDto.Id);

            if (service == null)
            {
                return new ResultDto<ServiceDto>
                {
                    IsSuccess = false,
                    Message = "error",
                    StatusCode = 404
                };
            }

            service.Name = serviceDto.Name;
            service.Price = serviceDto.Price;

            _context.SaveChanges();

            return new ResultDto<ServiceDto>
            {
                IsSuccess = true,
                Message = "ok",
                StatusCode = 200,
                Data = serviceDto
            };
        }
    }
}
