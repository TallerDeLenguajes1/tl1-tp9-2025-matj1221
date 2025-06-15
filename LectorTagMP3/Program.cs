using System.IO;
using System.Text;
using EspacioId3v1Tag;

string ruta = @"C:\Users\usuario\Desktop\TP9-Taller\tl1-tp9-2025-matj1221\LectorTagMP3\12 Al vacío.mp3";

var fileStream = new FileStream(ruta, FileMode.Open);

fileStream.Seek(-128, SeekOrigin.End);

var buffer = new byte[128];

fileStream.Read(buffer, 0, 128);
string header = Encoding.Latin1.GetString(buffer, 0, 3);
string titulo = Encoding.Latin1.GetString(buffer, 3, 30);
string artista = Encoding.Latin1.GetString(buffer, 33, 30);
string album = Encoding.Latin1.GetString(buffer, 63, 30);
string anio = Encoding.Latin1.GetString(buffer, 93, 4);
string comentario = Encoding.Latin1.GetString(buffer, 97, 30);
byte genero = buffer[127];

var nuevaCancion = new Id3v1Tag(header, titulo, artista, album, anio, comentario, genero);

nuevaCancion.Mostrar();

