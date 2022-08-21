using Microsoft.EntityFrameworkCore;
using DecisoesEmGrupo.Shared.Models;

namespace DecisoesEmGrupo.Server.Context
{
    public static class ModelBuilderExtensions
    {
        public static void SetRelations(this ModelBuilder modelBuilder)
        {
            #region SetRelations
            modelBuilder.Entity<Proposta>(entity =>
            {
                entity.HasKey(k => k.Id);
                //entity.HasOne(a => a.Virtual_Utilizador)
                //.WithMany(d => d.VirtualCollection_Veiculo)
                //.HasForeignKey(a => a.UtilizadorId).IsRequired()
                //.OnDelete(DeleteBehavior.Cascade);
                //entity.HasOne(a => a.Virtual_Motorizacao)
                //.WithMany(d => d.VirtualCollection_Veiculo)
                //.HasForeignKey(a => a.MotorizacaoId).IsRequired()
                //.OnDelete(DeleteBehavior.Cascade);
            });

            //modelBuilder.Entity<Intervencao>(entity =>
            //{
            //    entity.HasKey(k => k.Id);
            //    entity.HasOne(a => a.Virtual_Veiculo)
            //    .WithMany(d => d.VirtualCollection_Intervencao)
            //    .HasForeignKey(a => a.VeiculoId).IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);
            //    entity.HasOne(a => a.Virtual_Oficina)
            //    .WithMany(d => d.VirtualCollection_Intervencao)
            //    .HasForeignKey(a => a.OficinaId).IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);
            //    entity.HasOne(a => a.Virtual_ManutencaoProgramada)
            //    .WithMany(d => d.VirtualCollection_Intervencao)
            //    .HasForeignKey(a => a.ManutencaoProgramadaId).IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);
            //});

            //modelBuilder.Entity<Factura>(entity =>
            //{
            //    entity.HasKey(k => k.Id);
            //    entity.HasOne(a => a.Virtual_Intervencao)
            //    .WithMany(d => d.VirtualCollection_Factura)
            //    .HasForeignKey(a => a.IntervencaoId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //});

            //modelBuilder.Entity<Oficina>(entity =>
            //{
            //    entity.HasKey(k => k.Id);
            //    entity.HasOne(a => a.Virtual_Utilizador)
            //    .WithMany(d => d.VirtualCollection_Oficina)
            //    .HasForeignKey(a => a.UtilizadorId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //});

            //modelBuilder.Entity<LicencaOficina>(entity =>
            //{
            //    entity.HasKey(k => k.Id);
            //    entity.HasOne(a => a.Virtual_Oficina)
            //    .WithMany(d => d.VirtualCollection_LicencaOficina)
            //    .HasForeignKey(a => a.OficinaId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //});

            //modelBuilder.Entity<SubscricaoLicenca>(entity =>
            //{
            //    entity.HasKey(k => k.Id);
            //    entity.HasOne(a => a.Virtual_Oficina)
            //    .WithMany(d => d.VirtualCollection_SubscricaoLicenca)
            //    .HasForeignKey(a => a.OficinaId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //    entity.HasOne(a => a.Virtual_Licenca)
            //    .WithMany(d => d.VirtualCollection_SubscricaoLicenca)
            //    .HasForeignKey(a => a.LicencaId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //});


            //modelBuilder.Entity<ManutencaoProgramada>(entity =>
            //{
            //    entity.HasKey(k => k.Id);
            //    entity.HasOne(a => a.Virtual_Motorizacao)
            //    .WithMany(d => d.VirtualCollection_ManutencaoProgramada)
            //    .HasForeignKey(a => a.MotorizacaoId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //});

            //modelBuilder.Entity<Motorizacao>(entity =>
            //{
            //    entity.HasKey(k => k.Id);
            //    entity.HasOne(a => a.Virtual_Modelo)
            //    .WithMany(d => d.VirtualCollection_Motorizacao)
            //    .HasForeignKey(a => a.ModeloId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //});

            //modelBuilder.Entity<Modelo>(entity =>
            //{
            //    entity.HasKey(k => k.Id);
            //    entity.HasOne(a => a.Virtual_Marca)
            //    .WithMany(d => d.VirtualCollection_ModeloBase)
            //    .HasForeignKey(a => a.MarcaId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //});

            //modelBuilder.Entity<ImagemPlanoManutencao>(entity =>
            //{
            //    entity.HasKey(k => k.Id);
            //    entity.HasOne(a => a.Virtual_Modelo)
            //    .WithMany(d => d.VirtualCollection_ImagemPlanoManutencao)
            //    .HasForeignKey(a => a.ModeloId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //});

            //modelBuilder.Entity<AvisoManutencaoProgramadaAtrasada>(entity => {
            //    entity.HasKey(k => k.Id);
            //});
            #endregion
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilizador>().HasData(
                new Utilizador
                {
                    Id = 1,
                     NomeCompleto="Ricardo"
                    
                });

            //modelBuilder.Entity<Utilizador>().HasData(
            //    new Utilizador
            //    {
            //        Id = 1,
            //        Nome = "Ricardo Araújo",
            //        Username = "RicardoAraujo00",
            //        Email = "ricardoaraujo00@gmail.com",
            //        Contacto = "969290324",
            //        Contacto2 = "938247163",
            //        DataRegisto = DateTime.Now,
            //        Nif = "231043376",
            //        Morada = "",
            //        Allowed = true
            //    },
            //    new Utilizador
            //    {
            //        Id = 2,
            //        Nome = "Jose Araújo",
            //        Username = "JoseAraujo00",
            //        Email = "JoseAraujo00gmail.com",
            //        Contacto = "914445522",
            //        Contacto2 = "",
            //        DataRegisto = DateTime.Now,
            //        Nif = "534534534534",
            //        Morada = "",
            //        Allowed = true
            //    },
            //    new Utilizador
            //    {
            //        Id = 3,
            //        Nome = "Adelina Fonseca",
            //        Username = "AdelinaFonseca00",
            //        Email = "AdelinaFonseca00@gmail.com",
            //        Contacto = "938247163",
            //        Contacto2 = "",
            //        DataRegisto = DateTime.Now,
            //        Nif = "98798798798",
            //        Morada = "",
            //        Allowed = true
            //    }
            //    );

            //modelBuilder.Entity<Oficina>().HasData(
            //    new Oficina() { Id = 2, Nome = "OficinaDeAutomóveis", Email = "geral@oficinaauto.pt", Morada = "Rua dos carros", Contacto = "969290324", Contacto2 = "938247163", DataRegisto = DateTime.Now, Nif = "772992882", Activa = true, UtilizadorId = 1 }
            //    );

            //modelBuilder.Entity<Marca>().HasData(
            //    new Marca() { Id = 1, AdicionadoPor = 1, NomeMarca = "Seat" },
            //    new Marca() { Id = 2, AdicionadoPor = 1, NomeMarca = "Opel" },
            //    new Marca() { Id = 3, AdicionadoPor = 1, NomeMarca = "WW" },
            //    new Marca() { Id = 4, AdicionadoPor = 1, NomeMarca = "Fiat" },
            //    new Marca() { Id = 5, AdicionadoPor = 1, NomeMarca = "Mercedes" },
            //    new Marca() { Id = 9999, AdicionadoPor = 1, NomeMarca = "Geral" }
            //    );
            //modelBuilder.Entity<Modelo>().HasData(
            //    new Modelo() { Id = 1, AdicionadoPor = 1, MarcaId = 1, NomeModelo = "Leon", PeriododProducao = "2005/2013", CodigoModelo = "1P" },
            //    new Modelo() { Id = 2, AdicionadoPor = 1, MarcaId = 1, NomeModelo = "Ibiza", PeriododProducao = "2008/20115", CodigoModelo = "6j" },
            //    new Modelo() { Id = 3, AdicionadoPor = 1, MarcaId = 1, NomeModelo = "Mi", PeriododProducao = "2009/2017", CodigoModelo = "Mi" },
            //    new Modelo() { Id = 4, AdicionadoPor = 1, MarcaId = 2, NomeModelo = "Corsa", PeriododProducao = "1993/2001", CodigoModelo = "" },
            //    new Modelo() { Id = 9999, AdicionadoPor = 1, MarcaId = 9999, NomeModelo = "Geral", PeriododProducao = "", CodigoModelo = "" }
            //    );
            //modelBuilder.Entity<Motorizacao>().HasData(
            //    new Motorizacao() { Id = 1, AdicionadoPor = 1, VersaoMotorizacao = "1.6 102CV", Combustivel = "Gasolina", ModeloId = 1 },
            //    new Motorizacao() { Id = 2, AdicionadoPor = 1, VersaoMotorizacao = "1.9 105CV", Combustivel = "Gasoleo", ModeloId = 1 },
            //    new Motorizacao() { Id = 3, AdicionadoPor = 1, VersaoMotorizacao = "1.4 TSI 125CV", Combustivel = "Gasolina", ModeloId = 1 },
            //    new Motorizacao() { Id = 4, AdicionadoPor = 1, VersaoMotorizacao = "1.0 60CV", Combustivel = "Gasolina", ModeloId = 4 },
            //    new Motorizacao() { Id = 9999, AdicionadoPor = 1, VersaoMotorizacao = "Geral", Combustivel = "", ModeloId = 9999 }
            //    );
            //modelBuilder.Entity<Veiculo>().HasData(
            //    new Veiculo() { Id = 1, Versao = "SportUp", ExtraInfo = "Com kit estético interior", Matricula = "75-BG-69", DataMatricula = DateTime.Now, NumeroQuadro = "4734rh837h38h", NumeroMotor = "873h8783y78787", Kms = 234235, KmsRegisto = 130256, Cor = "Preto", Pneus = "Pirelli", PressaoPneus = "2.4/2.2", DataRegisto = DateTime.Now, ImagemVeiculo = "", MarcaModeloMotor = "Seat Leon 1.6 102Cv", MotorizacaoId = 1, UtilizadorId = 1 },
            //    new Veiculo() { Id = 2, Versao = "", ExtraInfo = "Com jantes especiais", Matricula = "35-21-FJ", DataMatricula = DateTime.Now, NumeroQuadro = "4734rh837h38h", NumeroMotor = "873h8783y78787", Kms = 199235, KmsRegisto = 130256, Cor = "Preto", Pneus = "", PressaoPneus = "2.0/1.8", DataRegisto = DateTime.Now, ImagemVeiculo = "", MarcaModeloMotor = "Opel Corsa 1.0 60CV", MotorizacaoId = 4, UtilizadorId = 1 }
            //    );
            //modelBuilder.Entity<ManutencaoProgramada>().HasData(
            //    new ManutencaoProgramada() { Id = 1, AdicionadoPor = 1, NomeManutencao = "Revisão 15.000", IntervaloKms = 15000, IntervaloTempoMeses = 12, MotorizacaoId = 1 },
            //    new ManutencaoProgramada() { Id = 2, AdicionadoPor = 1, NomeManutencao = "Mudança oleo travoes", IntervaloKms = 60000, IntervaloTempoMeses = 24, MotorizacaoId = 1 },
            //    new ManutencaoProgramada() { Id = 3, AdicionadoPor = 1, NomeManutencao = "Mudança correia de distribuição", IntervaloKms = 90000, IntervaloTempoMeses = 72, MotorizacaoId = 1 },
            //    new ManutencaoProgramada() { Id = 9999, AdicionadoPor = 1, NomeManutencao = "MockManutenção", IntervaloKms = 1, IntervaloTempoMeses = 1, MotorizacaoId = 9999 }
            //    );
            //modelBuilder.Entity<Oficina>().HasData(
            //    new Oficina() { Id = 1, UtilizadorId = 1, Nome = "Oficina Matias", Email = "ooficinamatias@gmail.com", Nif = "456789123", Contacto = "921356696", Activa = true, DataRegisto = DateTime.Now }
            //    );
            //modelBuilder.Entity<Intervencao>().HasData(
            //    new Intervencao() { Id = 1, VeiculoId = 1, OficinaId = 1, ManutencaoProgramadaBool = false, ManutencaoProgramadaId = 9999, TituloIntervencao = "Mudança de pastilhas dos travões", DescricaoIntervencao = "Mudança de pastilhas dos travões", FotoDestaque = "", Kms = 228999, DataIntervencao = DateTime.Now },
            //    new Intervencao() { Id = 2, VeiculoId = 1, OficinaId = 1, ManutencaoProgramadaBool = true, ManutencaoProgramadaId = 1, TituloIntervencao = "Revisão 15.000kms", DescricaoIntervencao = "Oleo utillizado 5-30w", FotoDestaque = "", Kms = 228999, DataIntervencao = DateTime.Now },
            //    new Intervencao() { Id = 3, VeiculoId = 1, OficinaId = 1, ManutencaoProgramadaBool = true, ManutencaoProgramadaId = 2, TituloIntervencao = "Mudança óleo travões", DescricaoIntervencao = "Marca oleo travoes dotpressure", FotoDestaque = "", Kms = 232456, DataIntervencao = DateTime.Now }
            //    );
        }
    }
}
