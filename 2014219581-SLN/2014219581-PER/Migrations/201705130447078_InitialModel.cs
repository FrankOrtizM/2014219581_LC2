namespace _2014219581_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asientoes",
                c => new
                    {
                        AsientoId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Cinturon_CinturonId = c.Int(),
                        Automovil_AutomovilId = c.Int(),
                        Bus_BusId = c.Int(),
                    })
                .PrimaryKey(t => t.AsientoId)
                .ForeignKey("dbo.Cinturons", t => t.Cinturon_CinturonId)
                .ForeignKey("dbo.Automovils", t => t.Automovil_AutomovilId)
                .ForeignKey("dbo.Buses", t => t.Bus_BusId)
                .Index(t => t.Cinturon_CinturonId)
                .Index(t => t.Automovil_AutomovilId)
                .Index(t => t.Bus_BusId);
            
            CreateTable(
                "dbo.Cinturons",
                c => new
                    {
                        CinturonId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Metraje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinturonId);
            
            CreateTable(
                "dbo.Automovils",
                c => new
                    {
                        AutomovilId = c.Int(nullable: false, identity: true),
                        TipoAuto = c.Int(nullable: false),
                        Volante_VolantesId = c.Int(nullable: false),
                        Volante_NumSerie = c.String(),
                        VolanteId = c.Int(nullable: false),
                        Parabrisas_ParabrisasId = c.Int(nullable: false),
                        Parabrisas_NumSerie = c.String(),
                        ParabrisaId = c.Int(nullable: false),
                        PropietarioId = c.Int(nullable: false),
                        TipoCarro = c.Int(nullable: false),
                        CarroId = c.Int(nullable: false),
                        NumSerieChasis = c.String(),
                    })
                .PrimaryKey(t => t.AutomovilId)
                .ForeignKey("dbo.Propietarios", t => t.PropietarioId, cascadeDelete: true)
                .Index(t => t.PropietarioId);
            
            CreateTable(
                "dbo.Llantas",
                c => new
                    {
                        LlantaId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Automovil_AutomovilId = c.Int(),
                        Bus_BusId = c.Int(),
                    })
                .PrimaryKey(t => t.LlantaId)
                .ForeignKey("dbo.Automovils", t => t.Automovil_AutomovilId)
                .ForeignKey("dbo.Buses", t => t.Bus_BusId)
                .Index(t => t.Automovil_AutomovilId)
                .Index(t => t.Bus_BusId);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        PropietarioId = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        LicenciaConducir = c.String(),
                    })
                .PrimaryKey(t => t.PropietarioId);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        BusId = c.Int(nullable: false, identity: true),
                        TipoBus = c.Int(nullable: false),
                        Volante_VolantesId = c.Int(nullable: false),
                        Volante_NumSerie = c.String(),
                        VolanteId = c.Int(nullable: false),
                        Parabrisas_ParabrisasId = c.Int(nullable: false),
                        Parabrisas_NumSerie = c.String(),
                        ParabrisaId = c.Int(nullable: false),
                        PropietarioId = c.Int(nullable: false),
                        TipoCarro = c.Int(nullable: false),
                        CarroId = c.Int(nullable: false),
                        NumSerieChasis = c.String(),
                    })
                .PrimaryKey(t => t.BusId)
                .ForeignKey("dbo.Propietarios", t => t.PropietarioId, cascadeDelete: true)
                .Index(t => t.PropietarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buses", "PropietarioId", "dbo.Propietarios");
            DropForeignKey("dbo.Llantas", "Bus_BusId", "dbo.Buses");
            DropForeignKey("dbo.Asientoes", "Bus_BusId", "dbo.Buses");
            DropForeignKey("dbo.Automovils", "PropietarioId", "dbo.Propietarios");
            DropForeignKey("dbo.Llantas", "Automovil_AutomovilId", "dbo.Automovils");
            DropForeignKey("dbo.Asientoes", "Automovil_AutomovilId", "dbo.Automovils");
            DropForeignKey("dbo.Asientoes", "Cinturon_CinturonId", "dbo.Cinturons");
            DropIndex("dbo.Buses", new[] { "PropietarioId" });
            DropIndex("dbo.Llantas", new[] { "Bus_BusId" });
            DropIndex("dbo.Llantas", new[] { "Automovil_AutomovilId" });
            DropIndex("dbo.Automovils", new[] { "PropietarioId" });
            DropIndex("dbo.Asientoes", new[] { "Bus_BusId" });
            DropIndex("dbo.Asientoes", new[] { "Automovil_AutomovilId" });
            DropIndex("dbo.Asientoes", new[] { "Cinturon_CinturonId" });
            DropTable("dbo.Buses");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Llantas");
            DropTable("dbo.Automovils");
            DropTable("dbo.Cinturons");
            DropTable("dbo.Asientoes");
        }
    }
}
