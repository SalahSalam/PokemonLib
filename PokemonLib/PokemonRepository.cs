namespace PokemonLib
{
    public class PokemonsRepository
    {
        private int _nextID;
        private List<Pokemon> _pokemons;

        public PokemonsRepository()
        {
            _nextID = 1;
            _pokemons = new List<Pokemon>()
            {
                new Pokemon() {Id = _nextID++, Name="Pikachu", Level=9999, PokeDex=25},
                new Pokemon() {Id = _nextID++, Name="Charmander", Level=1000, PokeDex=12},
                new Pokemon() {Id = _nextID++, Name="Arbok", Level=20, PokeDex=80},
            };
        }

        public List<Pokemon> GetAll()
        {
            return new List<Pokemon>(_pokemons);
        }

        public Pokemon? GetByID(int id)
        {
            return _pokemons.Find(x => x.Id == id);
        }

        public Pokemon Add(Pokemon newPokemon)
        {
            newPokemon.ValidateName();
            newPokemon.Id = _nextID++;
            _pokemons.Add(newPokemon);
            return newPokemon;
        }

        public Pokemon? Delete(int id)
        {
            Pokemon? foundPokemon = GetByID(id);
            if (foundPokemon == null)
            {
                return null;
            }
            _pokemons.Remove(foundPokemon);
            return foundPokemon;
        }

        public Pokemon? Update(int id, Pokemon updates)
        {
            updates.Validate();
            Pokemon? foundPokemon = GetByID(id);
            if (foundPokemon == null)
            {
                return null;
            }
            foundPokemon.Name = updates.Name;
            foundPokemon.PokeDex = updates.PokeDex;
            foundPokemon.Level = updates.Level;
            return foundPokemon;
        }
    }
}
