

using System.Collections.Generic;

namespace Api.Models{
    public interface IMedicineRepository{
        IEnumerable<Medicine> GetMedicine();
    }

}