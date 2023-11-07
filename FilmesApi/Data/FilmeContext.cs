using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data;

public class FilmeContex : DbContext
{
    public FilmeContex(DbContextOptions<FilmeContex> opts)
        :base(opts) 
    {
          
    }

    public DbSet<Filme> Filmes { get; set; }

}
