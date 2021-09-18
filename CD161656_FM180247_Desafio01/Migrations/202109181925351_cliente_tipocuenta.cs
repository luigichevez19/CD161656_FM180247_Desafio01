namespace CD161656_FM180247_Desafio01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cliente_tipocuenta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cliente",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombres = c.String(nullable: false, maxLength: 150),
                        primerApellido = c.String(nullable: false, maxLength: 100),
                        segundoApellido = c.String(maxLength: 100),
                        telefono = c.String(nullable: false, maxLength: 9),
                        correo = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TipoCuentaBancaria",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TipoCuentaBan = c.String(maxLength: 100),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoCuentaBancaria");
            DropTable("dbo.cliente");
        }
    }
}
