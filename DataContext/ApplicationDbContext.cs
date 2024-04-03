using Microsoft.EntityFrameworkCore;
using WebAPIFuncionarios.Models;

namespace WebAPIFuncionarios.DataContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<FuncionarioModel> Funcionarios { get; set; }
}