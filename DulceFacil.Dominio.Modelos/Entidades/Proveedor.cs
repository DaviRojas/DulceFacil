﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class Proveedor
{
    public int id_proveedor { get; set; }

    public string nombre { get; set; }

    public string contacto { get; set; }

    public string telefono { get; set; }

    public string direccion { get; set; }

    public virtual ICollection<Detalle_pedido> Detalle_pedido { get; set; } = new List<Detalle_pedido>();
}