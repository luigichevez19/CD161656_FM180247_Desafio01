namespace CD161656_FM180247_Desafio01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cuentabancaria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CuentaBancaria",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Moneda = c.String(maxLength: 100),
                        idCliente = c.Int(),
                        idTipo = c.Int(),
                        clientes_id = c.Int(),
                        Tipo_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.cliente", t => t.clientes_id)
                .ForeignKey("dbo.TipoCuentaBancaria", t => t.Tipo_id)
                .Index(t => t.clientes_id)
                .Index(t => t.Tipo_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CuentaBancaria", "Tipo_id", "dbo.TipoCuentaBancaria");
            DropForeignKey("dbo.CuentaBancaria", "clientes_id", "dbo.cliente");
            DropIndex("dbo.CuentaBancaria", new[] { "Tipo_id" });
            DropIndex("dbo.CuentaBancaria", new[] { "clientes_id" });
            DropTable("dbo.CuentaBancaria");
        }
    }
}
