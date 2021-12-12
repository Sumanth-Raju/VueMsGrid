using System.Collections.Generic;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers{
    [ApiController]
   
    public class MedicineController : ControllerBase
    {
        public IMedicineRepository _repo = new MedicineRepository();
        public MedicineController(){
           
        }

        [HttpGet]
         [Route("api/Medicine")]
        public IEnumerable<Medicine> GetMedicine()
        {
         return  _repo.GetMedicine();
        }
    }
}