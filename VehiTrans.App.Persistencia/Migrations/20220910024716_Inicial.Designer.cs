﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehiTrans.App.Persistencia;

#nullable disable

namespace VehiTrans.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220910024716_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VehiTrans.App.Dominio.Auxiliar", b =>
                {
                    b.Property<int>("AuxiliarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuxiliarId"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuxiliarId");

                    b.ToTable("Auxiliares");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.CompraRepuestos", b =>
                {
                    b.Property<int>("CompraRepuestosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompraRepuestosId"), 1L, 1);

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<string>("Justificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RepuestosId")
                        .HasColumnType("int");

                    b.Property<int>("RevisionId")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompraRepuestosId");

                    b.HasIndex("RepuestosId");

                    b.HasIndex("RevisionId");

                    b.ToTable("ComprasRepuestos");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.Conductor", b =>
                {
                    b.Property<int>("ConductorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConductorId"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Licencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelEstudio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConductorId");

                    b.ToTable("Conductores");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.JefeOperaciones", b =>
                {
                    b.Property<int>("JefeOperacionesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JefeOperacionesId"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JefeOperacionesId");

                    b.ToTable("JefeOperaciones");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.Mecanico", b =>
                {
                    b.Property<int>("MecanicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MecanicoId"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NivelEstudio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MecanicoId");

                    b.ToTable("Mecanicos");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.Propietario", b =>
                {
                    b.Property<int>("PropietarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropietarioId"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PropietarioId");

                    b.ToTable("Propietarios");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.Repuestos", b =>
                {
                    b.Property<int>("RepuestosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RepuestosId"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RepuestosId");

                    b.ToTable("Repuestos");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.Revision", b =>
                {
                    b.Property<int>("RevisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RevisionId"), 1L, 1);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("NivelDireccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelFrenos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NiveldeAceite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NiveldeRefrigerante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Repuestos")
                        .HasColumnType("int");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("RevisionId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Revisiones");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.Seguro", b =>
                {
                    b.Property<int>("SeguroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeguroId"), 1L, 1);

                    b.Property<string>("CodigoSeguro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoSeguroId")
                        .HasColumnType("int");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("SeguroId");

                    b.HasIndex("TipoSeguroId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Seguros");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.TipoSeguro", b =>
                {
                    b.Property<int>("TipoSeguroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoSeguroId"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TipoSeguroId");

                    b.ToTable("Tiposeguros");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehiculoId"), 1L, 1);

                    b.Property<int>("CantidadPasajeros")
                        .HasColumnType("int");

                    b.Property<int>("CilindrajeMotor")
                        .HasColumnType("int");

                    b.Property<int>("ConductorId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("MecanicoId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Placa")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<int>("PropietarioId")
                        .HasColumnType("int");

                    b.Property<int>("VehiculoTipoId")
                        .HasColumnType("int");

                    b.HasKey("VehiculoId");

                    b.HasIndex("ConductorId");

                    b.HasIndex("MecanicoId");

                    b.HasIndex("PropietarioId");

                    b.HasIndex("VehiculoTipoId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.VehiculoTipo", b =>
                {
                    b.Property<int>("VehiculoTipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehiculoTipoId"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("VehiculoTipoId");

                    b.ToTable("VehiculoTipos");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.CompraRepuestos", b =>
                {
                    b.HasOne("VehiTrans.App.Dominio.Repuestos", "Repuestos")
                        .WithMany()
                        .HasForeignKey("RepuestosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehiTrans.App.Dominio.Revision", "revision")
                        .WithMany()
                        .HasForeignKey("RevisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Repuestos");

                    b.Navigation("revision");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.Revision", b =>
                {
                    b.HasOne("VehiTrans.App.Dominio.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.Seguro", b =>
                {
                    b.HasOne("VehiTrans.App.Dominio.TipoSeguro", "TipoSeguro")
                        .WithMany()
                        .HasForeignKey("TipoSeguroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehiTrans.App.Dominio.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoSeguro");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("VehiTrans.App.Dominio.Vehiculo", b =>
                {
                    b.HasOne("VehiTrans.App.Dominio.Conductor", "Conductor")
                        .WithMany()
                        .HasForeignKey("ConductorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehiTrans.App.Dominio.Mecanico", "Mecanico")
                        .WithMany()
                        .HasForeignKey("MecanicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehiTrans.App.Dominio.Propietario", "Propietario")
                        .WithMany()
                        .HasForeignKey("PropietarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehiTrans.App.Dominio.VehiculoTipo", "VehiculoTipo")
                        .WithMany()
                        .HasForeignKey("VehiculoTipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conductor");

                    b.Navigation("Mecanico");

                    b.Navigation("Propietario");

                    b.Navigation("VehiculoTipo");
                });
#pragma warning restore 612, 618
        }
    }
}
