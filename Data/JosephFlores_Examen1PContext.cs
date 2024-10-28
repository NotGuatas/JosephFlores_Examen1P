using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JosephFlores_Examen1P.Models;

namespace JosephFlores_Examen1P.Data
{
    public class JosephFlores_Examen1PContext : DbContext
    {
        public JosephFlores_Examen1PContext (DbContextOptions<JosephFlores_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<JosephFlores_Examen1P.Models.JF_Proteina> JF_Proteina { get; set; } = default!;
    }
}
