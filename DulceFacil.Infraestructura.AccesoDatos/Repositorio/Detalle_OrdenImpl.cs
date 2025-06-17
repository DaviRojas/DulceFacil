using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class Detalle_OrdenImpl : RepositorioImpl<Detalle_Orden>, IDetalle_OrdenRepositorio
    {
        public Detalle_OrdenImpl(DulceFacil2DBContext dBContext) : base(dBContext)
        {
        }
    }
}
