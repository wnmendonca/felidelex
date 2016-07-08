namespace ProjetoFidelidade.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        CPF = c.String(nullable: false, maxLength: 11),
                        Email = c.String(nullable: false, maxLength: 100),
                        DddCelular = c.String(nullable: false, maxLength: 2),
                        Celular = c.String(nullable: false, maxLength: 9),
                        DataCadastro = c.DateTime(),
                        DataInclusao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cliente");
        }
    }
}
