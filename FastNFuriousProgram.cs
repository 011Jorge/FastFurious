using CommandDotNet;
using ConsoleTables;
using System.Linq;

namespace FastFurious
{
    [Command(
        Description = "Listar os filmes, persongens e carros"
    )]
    public class FastNFuriousProgram
    {
        [Command(
            Description = "Listar os filmes"
        )]
        public void Movies()
        {
            ConsoleTable
                .From(Films.GetFilms())
                .Write();
        }
    }
}
