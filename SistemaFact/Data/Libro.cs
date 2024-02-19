namespace SistemaFact.Data
{
    public class Libro
    {
        public int Id;
       
        public string Nombre { get; set; } = "";
        public string Autor { get; set; } = "";
        public string Genero { get; set; } = "";
        public int Estrellas { get; set; } = 0;
        public string Sinopsis { get; set; } = "";
        public double Precio { get; set; } = 0.00;

        public string Portada { get; set; } = "";
    }
}
