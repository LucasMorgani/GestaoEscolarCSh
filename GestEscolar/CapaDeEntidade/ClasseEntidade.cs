using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidade
{
    public class ClasseEntidade
    {
        public String usuario { get; set; }

        public String senha { get; set; }

        public DataTable N_Login(global::CapaDeNegocio.ClasseNegocio clsuser)
        {
            throw new NotImplementedException();
        }
    }
}
