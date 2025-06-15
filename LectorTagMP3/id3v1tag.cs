
namespace EspacioId3v1Tag
{

    public class Id3v1Tag
    {
        private string header;
        private string titulo;
        private string artista;
        private string album;
        private string anio;
        private string comentario;
        private byte genero;

        public Id3v1Tag(string header, string titulo, string artista, string album, string anio, string comentario, byte genero)
        {
            this.header = header;
            this.titulo = titulo;
            this.artista = artista;
            this.album = album;
            this.anio = anio;
            this.comentario = comentario;
            this.genero = genero;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Header: {header}");
            Console.WriteLine($"Titulo: {titulo}");
            Console.WriteLine($"Artista: {artista}");
            Console.WriteLine($"Album: {album}");
            Console.WriteLine($"Anio: {anio}");
            Console.WriteLine($"Comentario: {comentario}");
            Console.WriteLine($"Genero: {genero}");

        }

    }
}