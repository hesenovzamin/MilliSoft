using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilliSoft.Metod
{
    public interface MSInterface<T>
    {
        DataTable Select();
        bool Insert(T ms);
        bool Update(T ms);
        bool Delete(int Id);
            
    }
}
