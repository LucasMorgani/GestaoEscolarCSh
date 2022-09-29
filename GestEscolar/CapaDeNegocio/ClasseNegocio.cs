using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDados;
using CapaDeEntidade;

namespace CapaDeNegocio
{
    public class ClasseNegocio
    {
        ClasseDados clsdados = new ClasseDados();

        public string senha { get; set; }
        public string usuario { get; set; }

        public DataTable N_Login(ClasseEntidade obje)
        {
            return clsdados.DLogin(obje);
        }
    }
}
