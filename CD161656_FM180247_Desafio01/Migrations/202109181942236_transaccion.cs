namespace CD161656_FM180247_Desafio01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transaccion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.transacciones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Monto = c.Double(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        fechaTransaccion = c.DateTime(nullable: false),
                        fechaAplicacion = c.DateTime(nullable: false),
                        idCuentaBancaria = c.Int(),
                        TipoTransaccion = c.Int(),
                        cuenta_id = c.Int(),
                        TipoTran_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CuentaBancaria", t => t.cuenta_id)
                .ForeignKey("dbo.TipoTransaccion", t => t.TipoTran_id)
                .Index(t => t.cuenta_id)
                .Index(t => t.TipoTran_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.transacciones", "TipoTran_id", "dbo.TipoTransaccion");
            DropForeignKey("dbo.transacciones", "cuenta_id", "dbo.CuentaBancaria");
            DropIndex("dbo.transacciones", new[] { "TipoTran_id" });
            DropIndex("dbo.transacciones", new[] { "cuenta_id" });
            DropTable("dbo.transacciones");
        }
    }
}
