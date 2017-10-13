namespace Crud_estoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PRODUTO",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        fornecedor = c.String(),
                        descricao = c.String(),
                        dataValidade = c.DateTime(nullable: false),
                        dataFabricacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PRODUTO");
        }
    }
}
