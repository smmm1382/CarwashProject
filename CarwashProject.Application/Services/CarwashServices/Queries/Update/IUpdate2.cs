using CarwashProject.Application.Services.CarwashServices.Queries.GetWorker;
using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.CarwashServices.Queries.Update
{
    public interface IUpdate2
    {
        ResultDto<ServiceDto> Execute(ServiceDto serviceDto);
    }
}
