namespace _2014219581_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModels : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Asientoes", newName: "Asientos");
            RenameTable(name: "dbo.Cinturons", newName: "Cinturones");
            RenameTable(name: "dbo.Automovils", newName: "Automoviles");
            DropForeignKey("dbo.Asientoes", "Automovil_AutomovilId", "dbo.Automovils");
            DropForeignKey("dbo.Llantas", "Automovil_AutomovilId", "dbo.Automovils");
            DropForeignKey("dbo.Automovils", "PropietarioId", "dbo.Propietarios");
            DropForeignKey("dbo.Asientoes", "Bus_BusId", "dbo.Buses");
            DropForeignKey("dbo.Llantas", "Bus_BusId", "dbo.Buses");
            DropForeignKey("dbo.Buses", "PropietarioId", "dbo.Propietarios");
            DropForeignKey("dbo.Asientoes", "Cinturon_CinturonId", "dbo.Cinturons");
            DropIndex("dbo.Asientos", new[] { "Cinturon_CinturonId" });
            DropIndex("dbo.Asientos", new[] { "Automovil_AutomovilId" });
            DropIndex("dbo.Asientos", new[] { "Bus_BusId" });
            DropIndex("dbo.Automoviles", new[] { "PropietarioId" });
            DropIndex("dbo.Llantas", new[] { "Automovil_AutomovilId" });
            DropIndex("dbo.Llantas", new[] { "Bus_BusId" });
            DropIndex("dbo.Buses", new[] { "PropietarioId" });
            DropColumn("dbo.Cinturones", "CinturonId");
            RenameColumn(table: "dbo.Cinturones", name: "Cinturon_CinturonId", newName: "CinturonId");
            RenameColumn(table: "dbo.Asientos", name: "Automovil_AutomovilId", newName: "Carros_CarroId");
            RenameColumn(table: "dbo.Llantas", name: "Automovil_AutomovilId", newName: "Carros_CarroId");
            RenameColumn(table: "dbo.Asientos", name: "Bus_BusId", newName: "Carros_CarroId");
            RenameColumn(table: "dbo.Llantas", name: "Bus_BusId", newName: "Carros_CarroId");
            DropPrimaryKey("dbo.Cinturones");
            DropPrimaryKey("dbo.Automoviles");
            DropPrimaryKey("dbo.Propietarios");
            DropPrimaryKey("dbo.Buses");
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        CarroId = c.Int(nullable: false, identity: true),
                        VolanteId = c.Int(nullable: false),
                        ParabrisaId = c.Int(nullable: false),
                        PropietarioId = c.Int(nullable: false),
                        TipoCarro = c.Int(nullable: false),
                        NumSerieChasis = c.String(),
                        NumSerieMotor = c.String(),
                        Ensambladora_EnsambladoraId = c.Int(),
                    })
                .PrimaryKey(t => t.CarroId)
                .ForeignKey("dbo.Ensambladoras", t => t.Ensambladora_EnsambladoraId)
                .Index(t => t.Ensambladora_EnsambladoraId);
            
            CreateTable(
                "dbo.Parabrisas",
                c => new
                    {
                        ParabrisasId = c.Int(nullable: false),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.ParabrisasId)
                .ForeignKey("dbo.Carros", t => t.ParabrisasId)
                .Index(t => t.ParabrisasId);
            
            CreateTable(
                "dbo.Volantes",
                c => new
                    {
                        VolantesId = c.Int(nullable: false),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.VolantesId)
                .ForeignKey("dbo.Carros", t => t.VolantesId)
                .Index(t => t.VolantesId);
            
            CreateTable(
                "dbo.Ensambladoras",
                c => new
                    {
                        EnsambladoraId = c.Int(nullable: false, identity: true),
                        tipoCarro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnsambladoraId);
            
            AlterColumn("dbo.Asientos", "Carros_CarroId", c => c.Int(nullable: false));
            AlterColumn("dbo.Asientos", "Carros_CarroId", c => c.Int(nullable: false));
            AlterColumn("dbo.Cinturones", "CinturonId", c => c.Int(nullable: false));
            AlterColumn("dbo.Automoviles", "AutomovilId", c => c.Int(nullable: false));
            AlterColumn("dbo.Llantas", "Carros_CarroId", c => c.Int(nullable: false));
            AlterColumn("dbo.Llantas", "Carros_CarroId", c => c.Int(nullable: false));
            AlterColumn("dbo.Propietarios", "PropietarioId", c => c.Int(nullable: false));
            AlterColumn("dbo.Buses", "BusId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Cinturones", "CinturonId");
            AddPrimaryKey("dbo.Automoviles", "CarroId");
            AddPrimaryKey("dbo.Propietarios", "PropietarioId");
            AddPrimaryKey("dbo.Buses", "CarroId");
            CreateIndex("dbo.Asientos", "Carros_CarroId");
            CreateIndex("dbo.Llantas", "Carros_CarroId");
            CreateIndex("dbo.Propietarios", "PropietarioId");
            CreateIndex("dbo.Cinturones", "CinturonId");
            CreateIndex("dbo.Automoviles", "CarroId");
            CreateIndex("dbo.Buses", "CarroId");
            AddForeignKey("dbo.Automoviles", "CarroId", "dbo.Carros", "CarroId");
            AddForeignKey("dbo.Buses", "CarroId", "dbo.Carros", "CarroId");
            AddForeignKey("dbo.Asientos", "Carros_CarroId", "dbo.Carros", "CarroId", cascadeDelete: true);
            AddForeignKey("dbo.Llantas", "Carros_CarroId", "dbo.Carros", "CarroId", cascadeDelete: true);
            AddForeignKey("dbo.Propietarios", "PropietarioId", "dbo.Carros", "CarroId");
            DropColumn("dbo.Asientos", "Cinturon_CinturonId");
            DropColumn("dbo.Automoviles", "Volante_VolantesId");
            DropColumn("dbo.Automoviles", "Volante_NumSerie");
            DropColumn("dbo.Automoviles", "VolanteId");
            DropColumn("dbo.Automoviles", "Parabrisas_ParabrisasId");
            DropColumn("dbo.Automoviles", "Parabrisas_NumSerie");
            DropColumn("dbo.Automoviles", "ParabrisaId");
            DropColumn("dbo.Automoviles", "PropietarioId");
            DropColumn("dbo.Automoviles", "TipoCarro");
            DropColumn("dbo.Automoviles", "NumSerieChasis");
            DropColumn("dbo.Buses", "Volante_VolantesId");
            DropColumn("dbo.Buses", "Volante_NumSerie");
            DropColumn("dbo.Buses", "VolanteId");
            DropColumn("dbo.Buses", "Parabrisas_ParabrisasId");
            DropColumn("dbo.Buses", "Parabrisas_NumSerie");
            DropColumn("dbo.Buses", "ParabrisaId");
            DropColumn("dbo.Buses", "PropietarioId");
            DropColumn("dbo.Buses", "TipoCarro");
            DropColumn("dbo.Buses", "NumSerieChasis");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Buses", "NumSerieChasis", c => c.String());
            AddColumn("dbo.Buses", "TipoCarro", c => c.Int(nullable: false));
            AddColumn("dbo.Buses", "PropietarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Buses", "ParabrisaId", c => c.Int(nullable: false));
            AddColumn("dbo.Buses", "Parabrisas_NumSerie", c => c.String());
            AddColumn("dbo.Buses", "Parabrisas_ParabrisasId", c => c.Int(nullable: false));
            AddColumn("dbo.Buses", "VolanteId", c => c.Int(nullable: false));
            AddColumn("dbo.Buses", "Volante_NumSerie", c => c.String());
            AddColumn("dbo.Buses", "Volante_VolantesId", c => c.Int(nullable: false));
            AddColumn("dbo.Automoviles", "NumSerieChasis", c => c.String());
            AddColumn("dbo.Automoviles", "TipoCarro", c => c.Int(nullable: false));
            AddColumn("dbo.Automoviles", "PropietarioId", c => c.Int(nullable: false));
            AddColumn("dbo.Automoviles", "ParabrisaId", c => c.Int(nullable: false));
            AddColumn("dbo.Automoviles", "Parabrisas_NumSerie", c => c.String());
            AddColumn("dbo.Automoviles", "Parabrisas_ParabrisasId", c => c.Int(nullable: false));
            AddColumn("dbo.Automoviles", "VolanteId", c => c.Int(nullable: false));
            AddColumn("dbo.Automoviles", "Volante_NumSerie", c => c.String());
            AddColumn("dbo.Automoviles", "Volante_VolantesId", c => c.Int(nullable: false));
            AddColumn("dbo.Asientos", "Cinturon_CinturonId", c => c.Int());
            DropForeignKey("dbo.Propietarios", "PropietarioId", "dbo.Carros");
            DropForeignKey("dbo.Llantas", "Carros_CarroId", "dbo.Carros");
            DropForeignKey("dbo.Asientos", "Carros_CarroId", "dbo.Carros");
            DropForeignKey("dbo.Buses", "CarroId", "dbo.Carros");
            DropForeignKey("dbo.Automoviles", "CarroId", "dbo.Carros");
            DropForeignKey("dbo.Carros", "Ensambladora_EnsambladoraId", "dbo.Ensambladoras");
            DropForeignKey("dbo.Volantes", "VolantesId", "dbo.Carros");
            DropForeignKey("dbo.Parabrisas", "ParabrisasId", "dbo.Carros");
            DropIndex("dbo.Buses", new[] { "CarroId" });
            DropIndex("dbo.Automoviles", new[] { "CarroId" });
            DropIndex("dbo.Cinturones", new[] { "CinturonId" });
            DropIndex("dbo.Volantes", new[] { "VolantesId" });
            DropIndex("dbo.Propietarios", new[] { "PropietarioId" });
            DropIndex("dbo.Parabrisas", new[] { "ParabrisasId" });
            DropIndex("dbo.Llantas", new[] { "Carros_CarroId" });
            DropIndex("dbo.Carros", new[] { "Ensambladora_EnsambladoraId" });
            DropIndex("dbo.Asientos", new[] { "Carros_CarroId" });
            DropPrimaryKey("dbo.Buses");
            DropPrimaryKey("dbo.Propietarios");
            DropPrimaryKey("dbo.Automoviles");
            DropPrimaryKey("dbo.Cinturones");
            AlterColumn("dbo.Buses", "BusId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Propietarios", "PropietarioId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Llantas", "Carros_CarroId", c => c.Int());
            AlterColumn("dbo.Llantas", "Carros_CarroId", c => c.Int());
            AlterColumn("dbo.Automoviles", "AutomovilId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Cinturones", "CinturonId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Asientos", "Carros_CarroId", c => c.Int());
            AlterColumn("dbo.Asientos", "Carros_CarroId", c => c.Int());
            DropTable("dbo.Ensambladoras");
            DropTable("dbo.Volantes");
            DropTable("dbo.Parabrisas");
            DropTable("dbo.Carros");
            AddPrimaryKey("dbo.Buses", "BusId");
            AddPrimaryKey("dbo.Propietarios", "PropietarioId");
            AddPrimaryKey("dbo.Automoviles", "AutomovilId");
            AddPrimaryKey("dbo.Cinturones", "CinturonId");
            RenameColumn(table: "dbo.Llantas", name: "Carros_CarroId", newName: "Bus_BusId");
            RenameColumn(table: "dbo.Asientos", name: "Carros_CarroId", newName: "Bus_BusId");
            RenameColumn(table: "dbo.Llantas", name: "Carros_CarroId", newName: "Automovil_AutomovilId");
            RenameColumn(table: "dbo.Asientos", name: "Carros_CarroId", newName: "Automovil_AutomovilId");
            RenameColumn(table: "dbo.Cinturones", name: "CinturonId", newName: "Cinturon_CinturonId");
            AddColumn("dbo.Cinturones", "CinturonId", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.Buses", "PropietarioId");
            CreateIndex("dbo.Llantas", "Bus_BusId");
            CreateIndex("dbo.Llantas", "Automovil_AutomovilId");
            CreateIndex("dbo.Automoviles", "PropietarioId");
            CreateIndex("dbo.Asientoes", "Bus_BusId");
            CreateIndex("dbo.Asientoes", "Automovil_AutomovilId");
            CreateIndex("dbo.Asientoes", "Cinturon_CinturonId");
            AddForeignKey("dbo.Asientoes", "Cinturon_CinturonId", "dbo.Cinturons", "CinturonId");
            AddForeignKey("dbo.Buses", "PropietarioId", "dbo.Propietarios", "PropietarioId", cascadeDelete: true);
            AddForeignKey("dbo.Llantas", "Bus_BusId", "dbo.Buses", "BusId");
            AddForeignKey("dbo.Asientoes", "Bus_BusId", "dbo.Buses", "BusId");
            AddForeignKey("dbo.Automovils", "PropietarioId", "dbo.Propietarios", "PropietarioId", cascadeDelete: true);
            AddForeignKey("dbo.Llantas", "Automovil_AutomovilId", "dbo.Automovils", "AutomovilId");
            AddForeignKey("dbo.Asientoes", "Automovil_AutomovilId", "dbo.Automovils", "AutomovilId");
            RenameTable(name: "dbo.Automoviles", newName: "Automovils");
            RenameTable(name: "dbo.Cinturones", newName: "Cinturons");
            RenameTable(name: "dbo.Asientos", newName: "Asientoes");
        }
    }
}
