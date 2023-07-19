using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EpicFood_API.Models;

public partial class EpicFoodDbContext : DbContext
{
    public EpicFoodDbContext()
    {
    }

    public EpicFoodDbContext(DbContextOptions<EpicFoodDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AudEmp> AudEmps { get; set; }

    public virtual DbSet<AudPer> AudPers { get; set; }

    public virtual DbSet<CabeceraFactura> CabeceraFacturas { get; set; }

    public virtual DbSet<Combo> Combos { get; set; }

    public virtual DbSet<DeliveryPerma> DeliveryPermas { get; set; }

    public virtual DbSet<Descuento> Descuentos { get; set; }

    public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<FormaPago> FormaPagos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Prod> Prods { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    public virtual DbSet<TblDelivery> TblDeliveries { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=EpicFoodDb;Trusted_Connection=False;User Id=sa;Password=Password01.;Encrypt=False;\n");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AudEmp>(entity =>
        {
            entity.HasKey(e => e.AudiEmpId).HasName("PK__AUD_EMP__180D0C7B0D394102");

            entity.ToTable("AUD_EMP");

            entity.Property(e => e.AudiEmpId).HasColumnName("AUDI_EMP_ID");
            entity.Property(e => e.AudiAccionModificador)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUDI_ACCION_MODIFICADOR");
            entity.Property(e => e.AudiEmpActividadComercial)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("AUDI_EMP_ACTIVIDAD_COMERCIAL");
            entity.Property(e => e.AudiEmpDireccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AUDI_EMP_DIRECCION");
            entity.Property(e => e.AudiEmpFechaRegistro)
                .HasColumnType("date")
                .HasColumnName("AUDI_EMP_FECHA_REGISTRO");
            entity.Property(e => e.AudiEmpNombreComercial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AUDI_EMP_NOMBRE_COMERCIAL");
            entity.Property(e => e.AudiEmpRazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AUDI_EMP_RAZON_SOCIAL");
            entity.Property(e => e.AudiEmpRepresentanteLegal)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AUDI_EMP_REPRESENTANTE_LEGAL");
            entity.Property(e => e.AudiEmpRuc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("AUDI_EMP_RUC");
            entity.Property(e => e.AudiEmpTelefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AUDI_EMP_TELEFONO");
            entity.Property(e => e.AudiIdModificador)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUDI_ID_MODIFICADOR");
            entity.Property(e => e.AudiNickModificador)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUDI_NICK_MODIFICADOR");
        });

        modelBuilder.Entity<AudPer>(entity =>
        {
            entity.HasKey(e => e.AudPerId).HasName("PK__AUD_PER__103437E469290F69");

            entity.ToTable("AUD_PER");

            entity.Property(e => e.AudPerId).HasColumnName("AUD_PER_ID");
            entity.Property(e => e.AduPerFechaNac)
                .HasColumnType("date")
                .HasColumnName("ADU_PER_FECHA_NAC");
            entity.Property(e => e.AudAccionModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUD_ACCION_MODIFICA");
            entity.Property(e => e.AudIdModifica)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AUD_ID_MODIFICA");
            entity.Property(e => e.AudNickModifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUD_NICK_MODIFICA");
            entity.Property(e => e.AudPerApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUD_PER_APELLIDO");
            entity.Property(e => e.AudPerClave)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AUD_PER_CLAVE");
            entity.Property(e => e.AudPerCorreo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AUD_PER_CORREO");
            entity.Property(e => e.AudPerDireccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AUD_PER_DIRECCION");
            entity.Property(e => e.AudPerFechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("AUD_PER_FECHA_INGRESO");
            entity.Property(e => e.AudPerFechaSalida)
                .HasColumnType("date")
                .HasColumnName("AUD_PER_FECHA_SALIDA");
            entity.Property(e => e.AudPerNick)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUD_PER_NICK");
            entity.Property(e => e.AudPerNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUD_PER_NOMBRE");
            entity.Property(e => e.AudPerNumDoc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("AUD_PER_NUM_DOC");
            entity.Property(e => e.AudPerPregSeg1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AUD_PER_PREG_SEG1");
            entity.Property(e => e.AudPerPregSeg2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AUD_PER_PREG_SEG2");
            entity.Property(e => e.AudPerTelefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AUD_PER_TELEFONO");
            entity.Property(e => e.AudPerTipoDoc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUD_PER_TIPO_DOC");
            entity.Property(e => e.AudPerTipoLic)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUD_PER_TIPO_LIC");
        });

        modelBuilder.Entity<CabeceraFactura>(entity =>
        {
            entity.HasKey(e => e.CabeceraId).HasName("PK__CABECERA__017FBBC27DC79B9D");

            entity.ToTable("CABECERA_FACTURA");

            entity.Property(e => e.CabeceraId).HasColumnName("CABECERA_ID");
            entity.Property(e => e.ComId).HasColumnName("COM_ID");
            entity.Property(e => e.DeliId).HasColumnName("DELI_ID");
            entity.Property(e => e.DesId).HasColumnName("DES_ID");
            entity.Property(e => e.FileId).HasColumnName("FILE_ID");
            entity.Property(e => e.FormaId).HasColumnName("FORMA_ID");
            entity.Property(e => e.PerId).HasColumnName("PER_ID");
            entity.Property(e => e.ProId).HasColumnName("PRO_ID");
            entity.Property(e => e.SucId).HasColumnName("SUC_ID");

            entity.HasOne(d => d.Com).WithMany(p => p.CabeceraFacturas)
                .HasForeignKey(d => d.ComId)
                .HasConstraintName("FK_REFERENCE_21");

            entity.HasOne(d => d.Deli).WithMany(p => p.CabeceraFacturas)
                .HasForeignKey(d => d.DeliId)
                .HasConstraintName("FK_REFERENCE_23");

            entity.HasOne(d => d.Des).WithMany(p => p.CabeceraFacturas)
                .HasForeignKey(d => d.DesId)
                .HasConstraintName("FK_REFERENCE_24");

            entity.HasOne(d => d.File).WithMany(p => p.CabeceraFacturas)
                .HasForeignKey(d => d.FileId)
                .HasConstraintName("FK_REFERENCE_25");

            entity.HasOne(d => d.Forma).WithMany(p => p.CabeceraFacturas)
                .HasForeignKey(d => d.FormaId)
                .HasConstraintName("FK_REFERENCE_26");

            entity.HasOne(d => d.Per).WithMany(p => p.CabeceraFacturas)
                .HasForeignKey(d => d.PerId)
                .HasConstraintName("FK_REFERENCE_19");

            entity.HasOne(d => d.Pro).WithMany(p => p.CabeceraFacturas)
                .HasForeignKey(d => d.ProId)
                .HasConstraintName("FK_REFERENCE_20");

            entity.HasOne(d => d.Suc).WithMany(p => p.CabeceraFacturas)
                .HasForeignKey(d => d.SucId)
                .HasConstraintName("FK_REFERENCE_22");
        });

        modelBuilder.Entity<Combo>(entity =>
        {
            entity.HasKey(e => e.ComId).HasName("PK__COMBO__FAFB252019265265");

            entity.ToTable("COMBO");

            entity.Property(e => e.ComId).HasColumnName("COM_ID");
            entity.Property(e => e.ComCantidad).HasColumnName("COM_CANTIDAD");
            entity.Property(e => e.ComDescripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COM_DESCRIPCION");
            entity.Property(e => e.ComFecha)
                .HasColumnType("date")
                .HasColumnName("COM_FECHA");
            entity.Property(e => e.ComNombre)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COM_NOMBRE");
            entity.Property(e => e.ComPrecio).HasColumnName("COM_PRECIO");
            entity.Property(e => e.EstId).HasColumnName("EST_ID");
            entity.Property(e => e.ProId).HasColumnName("PRO_ID");
            entity.Property(e => e.ProProId).HasColumnName("PRO_PRO_ID");

            entity.HasOne(d => d.Est).WithMany(p => p.Combos)
                .HasForeignKey(d => d.EstId)
                .HasConstraintName("FK_REFERENCE_12");

            entity.HasOne(d => d.Pro).WithMany(p => p.ComboPros)
                .HasForeignKey(d => d.ProId)
                .HasConstraintName("FK_REFERENCE_16");

            entity.HasOne(d => d.ProPro).WithMany(p => p.ComboProPros)
                .HasForeignKey(d => d.ProProId)
                .HasConstraintName("FK_REFERENCE_17");
        });

        modelBuilder.Entity<DeliveryPerma>(entity =>
        {
            entity.HasKey(e => e.AuDeliId).HasName("PK__DELIVERY__4EBE4C736EDAA674");

            entity.ToTable("DELIVERY_PERMA");

            entity.Property(e => e.AuDeliId).HasColumnName("AU_DELI_ID");
            entity.Property(e => e.AuDeliDateRegistro)
                .HasColumnType("date")
                .HasColumnName("AU_DELI_DATE_REGISTRO");
            entity.Property(e => e.AuDeliDatetiEntrega)
                .HasColumnType("datetime")
                .HasColumnName("AU_DELI_DATETI_ENTREGA");
            entity.Property(e => e.AuDeliDatetiPeticion)
                .HasColumnType("datetime")
                .HasColumnName("AU_DELI_DATETI_PETICION");
            entity.Property(e => e.AuDeliDeliLati)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AU_DELI_DELI_LATI");
            entity.Property(e => e.AuDeliDeliLongi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AU_DELI_DELI_LONGI");
            entity.Property(e => e.AuDeliEstado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AU_DELI_ESTADO");
            entity.Property(e => e.AuDeliUsuLati)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AU_DELI_USU_LATI");
            entity.Property(e => e.AuDeliUsuLongi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AU_DELI_USU_LONGI");
        });

        modelBuilder.Entity<Descuento>(entity =>
        {
            entity.HasKey(e => e.DesId).HasName("PK__DESCUENT__4D76102FAC4DC014");

            entity.ToTable("DESCUENTOS");

            entity.Property(e => e.DesId).HasColumnName("DES_ID");
            entity.Property(e => e.DesTipo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DES_TIPO");
            entity.Property(e => e.DesValor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DES_VALOR");
            entity.Property(e => e.DesValornum).HasColumnName("DES_VALORNUM");
            entity.Property(e => e.EstId).HasColumnName("EST_ID");

            entity.HasOne(d => d.Est).WithMany(p => p.Descuentos)
                .HasForeignKey(d => d.EstId)
                .HasConstraintName("FK_REFERENCE_14");
        });

        modelBuilder.Entity<DetalleFactura>(entity =>
        {
            entity.HasKey(e => e.DetId).HasName("PK__DETALLE___45161B98D1634C4C");

            entity.ToTable("DETALLE_FACTURA");

            entity.Property(e => e.DetId).HasColumnName("DET_ID");
            entity.Property(e => e.CabeceraId).HasColumnName("CABECERA_ID");
            entity.Property(e => e.DetSubtotal).HasColumnName("DET_SUBTOTAL");
            entity.Property(e => e.DetTotal).HasColumnName("DET_TOTAL");

            entity.HasOne(d => d.Cabecera).WithMany(p => p.DetalleFacturas)
                .HasForeignKey(d => d.CabeceraId)
                .HasConstraintName("FK_REFERENCE_27");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__EMP__16EBFA268FACC518");

            entity.ToTable("EMP");

            entity.Property(e => e.EmpId).HasColumnName("EMP_ID");
            entity.Property(e => e.EmpActividadComercial)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("EMP_ACTIVIDAD_COMERCIAL");
            entity.Property(e => e.EmpDireccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EMP_DIRECCION");
            entity.Property(e => e.EmpFechaRegistro)
                .HasColumnType("date")
                .HasColumnName("EMP_FECHA_REGISTRO");
            entity.Property(e => e.EmpNombreComercial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMP_NOMBRE_COMERCIAL");
            entity.Property(e => e.EmpRazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EMP_RAZON_SOCIAL");
            entity.Property(e => e.EmpRepresentanteLegal)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EMP_REPRESENTANTE_LEGAL");
            entity.Property(e => e.EmpRuc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("EMP_RUC");
            entity.Property(e => e.EmpTelefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMP_TELEFONO");
            entity.Property(e => e.EstId).HasColumnName("EST_ID");

            entity.HasOne(d => d.Est).WithMany(p => p.Emps)
                .HasForeignKey(d => d.EstId)
                .HasConstraintName("FK_REFERENCE_11");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.EstId).HasName("PK__ESTADO__0383928A93CD6E30");

            entity.ToTable("ESTADO");

            entity.Property(e => e.EstId).HasColumnName("EST_ID");
            entity.Property(e => e.EstNombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EST_NOMBRE");
            entity.Property(e => e.EstValor)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EST_VALOR");
        });

        modelBuilder.Entity<FormaPago>(entity =>
        {
            entity.HasKey(e => e.FormaId).HasName("PK__FORMA_PA__012D9A297690E4A8");

            entity.ToTable("FORMA_PAGO");

            entity.Property(e => e.FormaId).HasColumnName("FORMA_ID");
            entity.Property(e => e.EstId).HasColumnName("EST_ID");
            entity.Property(e => e.FormaApellido)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FORMA_APELLIDO");
            entity.Property(e => e.FormaCodSeg)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FORMA_COD_SEG");
            entity.Property(e => e.FormaFechaCad)
                .HasColumnType("date")
                .HasColumnName("FORMA_FECHA_CAD");
            entity.Property(e => e.FormaNom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FORMA_NOM");
            entity.Property(e => e.FormaNumT)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FORMA_NUM_T");
            entity.Property(e => e.FormaTipoT)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FORMA_TIPO_T");
            entity.Property(e => e.PerId).HasColumnName("PER_ID");

            entity.HasOne(d => d.Est).WithMany(p => p.FormaPagos)
                .HasForeignKey(d => d.EstId)
                .HasConstraintName("FK_REFERENCE_15");

            entity.HasOne(d => d.Per).WithMany(p => p.FormaPagos)
                .HasForeignKey(d => d.PerId)
                .HasConstraintName("FK_REFERENCE_28");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.PerId).HasName("PK__PERSONA__8FE383B3E9ED9C29");

            entity.ToTable("PERSONA");

            entity.Property(e => e.PerId).HasColumnName("PER_ID");
            entity.Property(e => e.EstId).HasColumnName("EST_ID");
            entity.Property(e => e.PerApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PER_APELLIDO");
            entity.Property(e => e.PerClave)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PER_CLAVE");
            entity.Property(e => e.PerCorreo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PER_CORREO");
            entity.Property(e => e.PerDireccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PER_DIRECCION");
            entity.Property(e => e.PerFechaIngre)
                .HasColumnType("datetime")
                .HasColumnName("PER_FECHA_INGRE");
            entity.Property(e => e.PerFechaNac)
                .HasColumnType("date")
                .HasColumnName("PER_FECHA_NAC");
            entity.Property(e => e.PerFechaSalida)
                .HasColumnType("date")
                .HasColumnName("PER_FECHA_SALIDA");
            entity.Property(e => e.PerNick)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PER_NICK");
            entity.Property(e => e.PerNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PER_NOMBRE");
            entity.Property(e => e.PerNumDoc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("PER_NUM_DOC");
            entity.Property(e => e.PerPregSeg1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PER_PREG_SEG1");
            entity.Property(e => e.PerPregSeg2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PER_PREG_SEG2");
            entity.Property(e => e.PerTelefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PER_TELEFONO");
            entity.Property(e => e.PerTipoDoc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PER_TIPO_DOC");
            entity.Property(e => e.PerTipoLic)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PER_TIPO_LIC");
            entity.Property(e => e.RolId).HasColumnName("ROL_ID");

            entity.HasOne(d => d.Est).WithMany(p => p.Personas)
                .HasForeignKey(d => d.EstId)
                .HasConstraintName("FK_REFERENCE_7");

            entity.HasOne(d => d.Rol).WithMany(p => p.Personas)
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("FK_REFERENCE_2");
        });

        modelBuilder.Entity<Prod>(entity =>
        {
            entity.HasKey(e => e.ProId).HasName("PK__PROD__0A464EEBF9D3D461");

            entity.ToTable("PROD");

            entity.Property(e => e.ProId).HasColumnName("PRO_ID");
            entity.Property(e => e.EstId).HasColumnName("EST_ID");
            entity.Property(e => e.ProCantidad).HasColumnName("PRO_CANTIDAD");
            entity.Property(e => e.ProDescripcionProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRO_DESCRIPCION_PRODUCTO");
            entity.Property(e => e.ProFecha)
                .HasColumnType("date")
                .HasColumnName("PRO_FECHA");
            entity.Property(e => e.ProPrecio).HasColumnName("PRO_PRECIO");
            entity.Property(e => e.ProProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRO_PRODUCTO");

            entity.HasOne(d => d.Est).WithMany(p => p.Prods)
                .HasForeignKey(d => d.EstId)
                .HasConstraintName("FK_REFERENCE_13");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.FileId).HasName("PK__PROFILE__49C04C7ADB126AB4");

            entity.ToTable("PROFILE");

            entity.Property(e => e.FileId).HasColumnName("FILE_ID");
            entity.Property(e => e.EstId).HasColumnName("EST_ID");
            entity.Property(e => e.FileCallep)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FILE_CALLEP");
            entity.Property(e => e.FileCalles)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FILE_CALLES");
            entity.Property(e => e.FileLati)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FILE_LATI");
            entity.Property(e => e.FileLongi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FILE_LONGI");
            entity.Property(e => e.FileNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FILE_NOMBRE");
            entity.Property(e => e.FileReferencia)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FILE_REFERENCIA");
            entity.Property(e => e.PerId).HasColumnName("PER_ID");

            entity.HasOne(d => d.Est).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.EstId)
                .HasConstraintName("FK_REFERENCE_10");

            entity.HasOne(d => d.Per).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.PerId)
                .HasConstraintName("FK_REFERENCE_1");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.RolId).HasName("PK__ROL__2A76B76A0EF151B6");

            entity.ToTable("ROL");

            entity.Property(e => e.RolId).HasColumnName("ROL_ID");
            entity.Property(e => e.EstId).HasColumnName("EST_ID");
            entity.Property(e => e.RolTipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ROL_TIPO");

            entity.HasOne(d => d.Est).WithMany(p => p.Rols)
                .HasForeignKey(d => d.EstId)
                .HasConstraintName("FK_REFERENCE_8");
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity.HasKey(e => e.SucId).HasName("PK__SUCURSAL__1B0397E357973AD9");

            entity.ToTable("SUCURSAL");

            entity.Property(e => e.SucId).HasColumnName("SUC_ID");
            entity.Property(e => e.EmpId).HasColumnName("EMP_ID");
            entity.Property(e => e.EstId).HasColumnName("EST_ID");
            entity.Property(e => e.SucCallep)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SUC_CALLEP");
            entity.Property(e => e.SucCalles)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SUC_CALLES");
            entity.Property(e => e.SucSector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUC_SECTOR");

            entity.HasOne(d => d.Emp).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_REFERENCE_18");

            entity.HasOne(d => d.Est).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.EstId)
                .HasConstraintName("FK_REFERENCE_6");
        });

        modelBuilder.Entity<TblDelivery>(entity =>
        {
            entity.HasKey(e => e.DeliId).HasName("PK__TBL_DELI__CB50775BB4FD2284");

            entity.ToTable("TBL_DELIVERY");

            entity.Property(e => e.DeliId).HasColumnName("DELI_ID");
            entity.Property(e => e.DeliDatetiEntrega)
                .HasColumnType("datetime")
                .HasColumnName("DELI_DATETI_ENTREGA");
            entity.Property(e => e.DeliDatetiPeticion)
                .HasColumnType("datetime")
                .HasColumnName("DELI_DATETI_PETICION");
            entity.Property(e => e.DeliDeliLati)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DELI_DELI_LATI");
            entity.Property(e => e.DeliDeliLongi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DELI_DELI_LONGI");
            entity.Property(e => e.DeliEstado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DELI_ESTADO");
            entity.Property(e => e.DeliUsuLati)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DELI_USU_LATI");
            entity.Property(e => e.DeliUsuLongi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DELI_USU_LONGI");
            entity.Property(e => e.PerId).HasColumnName("PER_ID");
            entity.Property(e => e.PerPerId).HasColumnName("PER_PER_ID");

            entity.HasOne(d => d.Per).WithMany(p => p.TblDeliveryPers)
                .HasForeignKey(d => d.PerId)
                .HasConstraintName("FK_REFERENCE_4");

            entity.HasOne(d => d.PerPer).WithMany(p => p.TblDeliveryPerPers)
                .HasForeignKey(d => d.PerPerId)
                .HasConstraintName("FK_REFERENCE_5");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.VhlId).HasName("PK__VEHICULO__6F7CBAA5E2BAF10D");

            entity.ToTable("VEHICULO");

            entity.Property(e => e.VhlId).HasColumnName("VHL_ID");
            entity.Property(e => e.EstId).HasColumnName("EST_ID");
            entity.Property(e => e.PerId).HasColumnName("PER_ID");
            entity.Property(e => e.VhlPlaca)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VHL_PLACA");
            entity.Property(e => e.VhlTipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VHL_TIPO");

            entity.HasOne(d => d.Est).WithMany(p => p.Vehiculos)
                .HasForeignKey(d => d.EstId)
                .HasConstraintName("FK_REFERENCE_9");

            entity.HasOne(d => d.Per).WithMany(p => p.Vehiculos)
                .HasForeignKey(d => d.PerId)
                .HasConstraintName("FK_REFERENCE_3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
