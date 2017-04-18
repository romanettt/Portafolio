using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico.Negocio
{
    interface ICrud<Object>
    {
        bool Create(Object o);
        bool Update(Object o);
        bool Delete(int id);
        Object Read(int id);
        List<Object> ReadAll();

    }
}
