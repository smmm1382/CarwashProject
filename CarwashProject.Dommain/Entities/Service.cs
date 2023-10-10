using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Domain.Entities
{
    public class Service
    {
        public int Id { get; set; }
        //public ServiceNameEnum Name { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        //RelationShips
        public ICollection<WorkerInService> WorkerInServices { get; set; }
    }

    //public enum ServiceNameEnum
    //{
    //    Roshoyee = 1,
    //    Broom, // جارو
    //    Wax,
    //    EngineWash, // موتور شویی
    //    Underwashing, // زیر شویی
    //    Door, // رودری
    //    Dashboard, // داشبورد
    //    Ceiling, // سقف
    //    Column, // ستون
    //    Chair, // صندلی
    //    Floor, // کف
    //    Trunk, // صندوق عقب
    //    Motorcycle, // موتور سیکلت
    //    zerowashing // صفر شویی
    //};
}
