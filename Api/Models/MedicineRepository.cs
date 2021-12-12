using System.Collections.Generic;

namespace Api.Models{
    public class MedicineRepository : IMedicineRepository
    {
        private IList<Medicine> medicine = new List<Medicine>();
        public MedicineRepository(){
            medicine.Add(new Medicine{
                Id = 1,
                Name = "Dolo"

            });
             medicine.Add(new Medicine{
                Id = 2,
                Name = "covi"

            });
            
        }
        public IEnumerable<Medicine> GetMedicine()
        {
            return medicine;
        }
    }
}