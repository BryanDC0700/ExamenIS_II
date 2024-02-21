using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIS_II
{
    internal class Class1
    {
        public void insertarUsuario(Clientes clientes)
        {
            using (var bd = new Clientes())
            {
                bd.clientes = clientes;
            }
        }
    }
}
