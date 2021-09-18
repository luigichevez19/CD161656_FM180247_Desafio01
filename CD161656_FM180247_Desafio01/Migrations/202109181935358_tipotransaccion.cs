namespace CD161656_FM180247_Desafio01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tipotransaccion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoTransaccion",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tipo_transaccion = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoTransaccion");
        }
    }
}
