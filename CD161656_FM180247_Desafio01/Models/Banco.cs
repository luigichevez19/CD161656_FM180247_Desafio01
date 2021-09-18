using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace CD161656_FM180247_Desafio01.Models
{
    public class Banco : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Banco' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'CD161656_FM180247_Desafio01.Models.Banco' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Banco'  en el archivo de configuración de la aplicación.
        public Banco()
            : base("name=Banco")
        {
        }
        public virtual DbSet<cliente> Clientes { get; set; }
        public virtual DbSet<TipoCuentaBancaria> TipoCuentaBancarias{ get; set; }
        public virtual DbSet<CuentaBancaria> CuentaBancarias { get; set; }
        public virtual DbSet<TipoTransaccion> TipoTransaccions { get; set; }
        public virtual DbSet<transacciones> Transacciones { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

   
}