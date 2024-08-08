namespace MVC_Proyecto.Models
{
    public class Ahorcado
    {
        public string PalabraSecreta { get; set; }

        public string Palabra { get; set; }
        public List<char> Alphabet { get; set; } = new List<char>
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
    }
}
