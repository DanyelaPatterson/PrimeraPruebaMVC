using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrimeraPruebaMVC.Entities;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    /*<Nombre de la clase que creamos> Nombre de como quiero que se llame la tabla en la BD*/
    public DbSet <Degree> Degrees { get; set;}
}