
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace ConsoleApp.TiendaMascotas
{
public class Mascotas
{
    private int id = 0;
    private string codMascota = "";
    private string nombre = "";
    private string tipoDeMascota = "";
    private string raza = "";
    private DateTime? edad = null;

    public int Id { get => this.id; set => this.id = value; }
    public string CodMascota { get => this.codMascota; set => this.codMascota = value; }
    public string Nombre { get => this.nombre; set => this.nombre = value; }
    public string TipoDeMascota { get => this.tipoDeMascota; set => this.tipoDeMascota = value; }
    public string Raza { get => this.raza; set => this.raza = value; }
    public DateTime? Edad { get => this.edad; set => this.edad = value; }


    public void RegistrarMascota()
    {
        //  registrar una nueva mascota
    }

    public void ActualizarInformacion()
    {
        //  actualizar la información de la mascota
    }

}
    public class Mascotas_Clientes
    {
        private int id = 0;
        private Clientes? cliente = null;
        private Mascotas? mascota = null;

        public int Id { get => this.id; set => this.id = value; }
        public Clientes? Cliente { get => this.cliente; set => this.cliente = value; }
        public Mascotas? Mascota { get => this.mascota; set => this.mascota = value; }



    }

    public class Clientes
    {
        private int id = 0;
        private string nombre = "";
        private string numero = "";
        private string cedula = "";
        private string email = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Numero { get => this.numero; set => this.numero = value; }
        public string Cedula { get => this.cedula; set => this.cedula = value; }
        public string Email { get => this.email; set => this.email = value; }

        public void RegistrarCliente()
        {
            // registrar un nuevo cliente
        }

        public void ActualizarInformacionCliente()
        {
            //  actualizar la información del cliente
        }

        
    }

    public class MetodoDePago
    {
        private int id = 0;
        private string tipoMetodoPago = "";

        public int Id { get => this.id; set => this.id = value; }
        public string TipoMetodoPago { get => this.tipoMetodoPago; set => this.tipoMetodoPago = value; }

        public void RegistrarMetodo()
        {
            //registrar un nuevo método de pago
        }

        public void ListarMetodosDisponibles()
        {
            // listar métodos de pago disponibles
        }
    }

    public class Servicios
    {
        private int id = 0;
        private double precio = 0.0;
        private string tipoDeServicio = "";
        private string descripcion = "";

        public int Id { get => this.id; set => this.id = value; }
        public double Precio { get => this.precio; set => this.precio = value; }
        public string TipoDeServicio{get => this.tipoDeServicio	; set => this.tipoDeServicio = value; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = value; }

        public void RegistrarServicio()
        {
            // registrar un nuevo servicio
        }

        public void ActualizarPrecioServicio()
        {
            // actualizar el precio del servicio
        }
       
    }

    public class Facturas
    {
        private int id = 0;
        private string numFactura = "";
        private double iva = 0.0;
        private double total = 0.0;
        private DateTime? fecha = null;
        private Clientes? cliente = null;
        private MetodoDePago? metodo = null;
        private List<DetalleFacturas> detallesFactura = new List<DetalleFacturas>();

        public int Id { get => this.id; set => this.id = value; }
        public string NumFactura { get => this.numFactura; set => this.numFactura = value; }
        public double Iva { get => this.iva; set => this.iva = value; }
        public double Total { get => this.total; set => this.total = value; }
        public DateTime? Fecha { get => this.fecha; set => this.fecha = value; }
        public Clientes? Cliente { get => this.cliente; set => this.cliente = value; }
        public MetodoDePago? Metodo { get => this.metodo; set => this.metodo = value; }
        public List<DetalleFacturas> DetallesFactura { get => this.detallesFactura; set => this.detallesFactura = value; }

        public void GenerarFactura()
        {
            // Generar la factura
        }

        public void CalcularTotal()
        {
            // calcular el total de la factura
        }

    }

    public class DetalleFacturas
    {
        private int id = 0;
        private Facturas? factura = null;
        private Servicios? servicio = null;
        private Mascotas? mascota = null;
        private double iva = 0.0;
        private double precioVenta = 0.0;
        private DateTime? fechaServicio = null;
        private string estado = "";

        public int Id { get => this.id; set => this.id = value; }
        public Facturas? Factura { get => this.factura; set => this.factura = value; }
        public Servicios? Servicio { get => this.servicio; set => this.servicio = value; }
        public Mascotas? Mascota { get => this.mascota; set => this.mascota = value; }
        public double Iva { get => this.iva; set => this.iva = value; }
        public double PrecioVenta { get => this.precioVenta; set => this.precioVenta = value; }
        public DateTime? FechaServicio { get => this.fechaServicio; set => this.fechaServicio = value; }
        public string Estado { get => this.estado; set => this.estado = value; }

        

        public void ActualizarDetalle()
        {
            // actualizar el detalle de la factura
        }
        

        public void ObtenerDetalle()
        {
            // eliminar un detalle de la factura
        }
    }
}