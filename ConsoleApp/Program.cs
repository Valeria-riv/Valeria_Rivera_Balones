// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var balon = new Balones();
var fac = new Facturas();

balon.Id = 1;
balon.Tamaño = 143.5m;
balon.Modelo = "nike";
balon.EstaInflado = false;
balon.Fecha = DateTime.Now;
balon.Estado = new Estados(){Id = 5, Est = "Disponible"};
balon.Deporte = new Deportivos(){Codigo= 1, Referencia = "M25-D69"};
fac.Cedula = 102254;
fac.Cantidad = 1;
fac.NombreComprador = "Valeriaaa";
fac.Fecha = DateTime.Now;


Console.WriteLine(balon.Id);
Console.WriteLine(balon.Tamaño);
Console.WriteLine(balon.Modelo);
Console.WriteLine(balon.EstaInflado);
Console.WriteLine(balon.Fecha);
Console.WriteLine(balon.Estado.Est);
Console.WriteLine(balon.Deporte.Codigo);
Console.WriteLine(balon.Deporte.Referencia);
Console.WriteLine(fac.Cedula);
Console.WriteLine(fac.Cantidad);
Console.WriteLine(fac.NombreComprador);

public class Balones{
    public int Id;
    public decimal Tamaño;
    public string? Modelo;
    public bool EstaInflado;
    public DateTime Fecha;
    public Estados? Estado;
    public Deportivos? Deporte;
}

public class Estados{
    public int Id;
    public string? Est;
    public List<Balones>? Balones;
}

public class Deportivos{
    public int Codigo;
    public string? Referencia;
    public List<Balones>? Balones;

}

public class Facturas{
    public int Cedula;
    public string? NombreComprador;
    public int Cantidad;
    public string? Compra;
    public DateTime Fecha;
    
}

