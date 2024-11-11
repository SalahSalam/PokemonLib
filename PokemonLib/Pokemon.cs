namespace PokemonLib
{
    public class Pokemon
    {
        public int Id { get; set; } 
        public string? Name { get; set; } 
        public int Level { get; set; }
        public int PokeDex { get; set; }

        public void ValidateName()
        {
            if (Name == null) throw new ArgumentNullException();
            if (Name.Length <= 2) throw new ArgumentOutOfRangeException("specifik besked");
        }

        public void Validate()
        {
            ValidateName();
        }
    }
}
