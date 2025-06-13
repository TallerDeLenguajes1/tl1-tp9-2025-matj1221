using System.IO;

string directorioPath;
bool existe;
do
{
    System.Console.WriteLine("Ingrese path de directorio: ");

    directorioPath = Console.ReadLine(); //si uso .Trim() después de cw previene errores con espacios al final

    existe = Directory.Exists(directorioPath);

    if (!existe)
    {
        System.Console.WriteLine("No ingreso un path valido. Pruebe de nuevo.");
    }

} while (!existe);

if (existe) //redundante, si está acá es por qué si existe xD
{
    System.Console.WriteLine("Se ingreso un directorio valido.");

    System.Console.WriteLine("Listado de carpetas: ");

    string[] subcarpetas = Directory.GetDirectories(directorioPath);

    foreach (string dir in subcarpetas)
    {
        System.Console.WriteLine(dir);
    }

    System.Console.WriteLine("Listado de archivos: ");

    string[] archivos = Directory.GetFiles(directorioPath);

    var lineasCsv = new List<string>();
    lineasCsv.Add("Nombre del archivo, Tamanio (KB), Fecha de ultima modificacion");

    foreach (string arch in archivos)
    {
        System.Console.WriteLine(arch);

        var informacion = new FileInfo(arch);

        string nombre = informacion.Name;
        double tamanio = informacion.Length / 1024.0;
        DateTime fecha = informacion.LastWriteTime;

        //agrego la linea al csv

        lineasCsv.Add($"{nombre};{tamanio};{fecha}"); //; es el separador
    }

    //creo la ruta para el CSV

    string rutaCsv = Path.Combine(directorioPath, "reporte_archivos.csv");

    File.WriteAllLines(rutaCsv, lineasCsv);

    Console.WriteLine($"Archivo CSV generado en: {rutaCsv}");
}
else
{
    Console.WriteLine("No ingreso un directorio valido.");
}