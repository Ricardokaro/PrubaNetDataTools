using PrubaNetDataTools;
using System.Text.Json;

double leerResultadoJson()
{   
    string? rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\datos.json");

    string jsonString = File.ReadAllText(rutaArchivo);
    
    Cliente? cliente = JsonSerializer.Deserialize<Cliente>(jsonString);
    
    double rts = 0;
    
    if (cliente == null)
    {
        rts = 0;
    }
    else
    {
        rts = cliente.cantidad * cliente.valor;
    }

    return rts;
}

double rst = leerResultadoJson();

Console.WriteLine($"Valor: ${ rst }");






