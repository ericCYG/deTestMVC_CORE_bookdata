using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace deTestMVC_CORE_bookdata.Models;

public partial class GsswebContext : DbContext
{
    public GsswebContext()
    {
    }

    public GsswebContext(DbContextOptions<GsswebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookClass> BookClasses { get; set; }

    public virtual DbSet<BookCode> BookCodes { get; set; }

    public virtual DbSet<BookDatum> BookData { get; set; }

    public virtual DbSet<BookLendRecord> BookLendRecords { get; set; }

    public virtual DbSet<DeTestWebFormMember> DeTestWebFormMembers { get; set; }

    public virtual DbSet<Dep> Deps { get; set; }

    public virtual DbSet<EmpInfo> EmpInfos { get; set; }

    public virtual DbSet<EmpRel> EmpRels { get; set; }

    public virtual DbSet<Lon> Lons { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MemberM> MemberMs { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectProviderComponent> ProjectProviderComponents { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<SpanTable> SpanTables { get; set; }

    public virtual DbSet<TestTable2> TestTable2s { get; set; }

    public virtual DbSet<UseRecord> UseRecords { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }

    public virtual DbSet<員工> 員工s { get; set; }

    public virtual DbSet<部門> 部門s { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=GSSWEB;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookClass>(entity =>
        {
            entity.HasKey(e => e.BookClassId).IsClustered(false);

            entity.ToTable("BOOK_CLASS");

            entity.Property(e => e.BookClassId)
                .HasMaxLength(4)
                .HasColumnName("BOOK_CLASS_ID");
            entity.Property(e => e.BookClassName)
                .HasMaxLength(60)
                .HasColumnName("BOOK_CLASS_NAME");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(12)
                .HasColumnName("CREATE_USER");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ModifyUser)
                .HasMaxLength(12)
                .HasColumnName("MODIFY_USER");
        });

        modelBuilder.Entity<BookCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOOK_CODE");

            entity.Property(e => e.CodeId)
                .HasMaxLength(100)
                .HasColumnName("CODE_ID");
            entity.Property(e => e.CodeName)
                .HasMaxLength(200)
                .HasColumnName("CODE_NAME");
            entity.Property(e => e.CodeType)
                .HasMaxLength(50)
                .HasColumnName("CODE_TYPE");
            entity.Property(e => e.CodeTypeDesc)
                .HasMaxLength(200)
                .HasColumnName("CODE_TYPE_DESC");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(10)
                .HasColumnName("CREATE_USER");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ModifyUser)
                .HasMaxLength(10)
                .HasColumnName("MODIFY_USER");
        });

        modelBuilder.Entity<BookDatum>(entity =>
        {
            entity.HasKey(e => e.BookId).IsClustered(false);

            entity.ToTable("BOOK_DATA");

            entity.Property(e => e.BookId).HasColumnName("BOOK_ID");
            entity.Property(e => e.BookAmount).HasColumnName("BOOK_AMOUNT");
            entity.Property(e => e.BookAuthor)
                .HasMaxLength(30)
                .HasColumnName("BOOK_AUTHOR");
            entity.Property(e => e.BookBoughtDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOK_BOUGHT_DATE");
            entity.Property(e => e.BookClassId)
                .HasMaxLength(4)
                .HasColumnName("BOOK_CLASS_ID");
            entity.Property(e => e.BookKeeper)
                .HasMaxLength(12)
                .HasColumnName("BOOK_KEEPER");
            entity.Property(e => e.BookName)
                .HasMaxLength(200)
                .HasColumnName("BOOK_NAME");
            entity.Property(e => e.BookNote)
                .HasMaxLength(1200)
                .HasColumnName("BOOK_NOTE");
            entity.Property(e => e.BookPublisher)
                .HasMaxLength(20)
                .HasColumnName("BOOK_PUBLISHER");
            entity.Property(e => e.BookStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BOOK_STATUS");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(12)
                .HasColumnName("CREATE_USER");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ModifyUser)
                .HasMaxLength(12)
                .HasColumnName("MODIFY_USER");
        });

        modelBuilder.Entity<BookLendRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BOOK_LEND_RECORD");

            entity.Property(e => e.BookId).HasColumnName("BOOK_ID");
            entity.Property(e => e.CreDate)
                .HasColumnType("datetime")
                .HasColumnName("CRE_DATE");
            entity.Property(e => e.CreUsr)
                .HasMaxLength(12)
                .HasColumnName("CRE_USR");
            entity.Property(e => e.IdentityFiled)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDENTITY_FILED");
            entity.Property(e => e.KeeperId)
                .HasMaxLength(12)
                .HasColumnName("KEEPER_ID");
            entity.Property(e => e.LendDate)
                .HasColumnType("datetime")
                .HasColumnName("LEND_DATE");
            entity.Property(e => e.ModDate)
                .HasColumnType("datetime")
                .HasColumnName("MOD_DATE");
            entity.Property(e => e.ModUsr)
                .HasMaxLength(12)
                .HasColumnName("MOD_USR");
        });

        modelBuilder.Entity<DeTestWebFormMember>(entity =>
        {
            entity.ToTable("deTestWebFormMember");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .HasColumnName("address");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .HasColumnName("sex");
        });

        modelBuilder.Entity<Dep>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DEP");

            entity.Property(e => e.Amt)
                .HasColumnType("numeric(13, 2)")
                .HasColumnName("AMT");
            entity.Property(e => e.CloseDt)
                .HasColumnType("date")
                .HasColumnName("CLOSE_DT");
            entity.Property(e => e.CustId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CUST_ID");
            entity.Property(e => e.DepNo)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DEP_NO");
            entity.Property(e => e.OpenDt)
                .HasColumnType("date")
                .HasColumnName("OPEN_DT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Vip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VIP");
        });

        modelBuilder.Entity<EmpInfo>(entity =>
        {
            entity.HasKey(e => e.EmpNo);

            entity.ToTable("EMP_INFO");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMP_NO");
            entity.Property(e => e.BossEmpNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BOSS_EMP_NO");
            entity.Property(e => e.BranchNo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BRANCH_NO");
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .HasColumnName("EMP_NAME");
        });

        modelBuilder.Entity<EmpRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EMP_REL");

            entity.Property(e => e.EmpNo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMP_NO");
            entity.Property(e => e.Relation)
                .HasMaxLength(5)
                .HasColumnName("RELATION");
        });

        modelBuilder.Entity<Lon>(entity =>
        {
            entity.HasKey(e => e.LonNo);

            entity.ToTable("LON");

            entity.Property(e => e.LonNo)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LON_NO");
            entity.Property(e => e.Amt)
                .HasColumnType("numeric(13, 2)")
                .HasColumnName("AMT");
            entity.Property(e => e.CloseDt)
                .HasColumnType("date")
                .HasColumnName("CLOSE_DT");
            entity.Property(e => e.CustId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CUST_ID");
            entity.Property(e => e.OpenDt)
                .HasColumnType("date")
                .HasColumnName("OPEN_DT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.ToTable("Member");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Birthday).HasColumnType("datetime");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Phone).HasMaxLength(10);
            entity.Property(e => e.Tel)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MemberM>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("MEMBER_M");

            entity.Property(e => e.UserId)
                .HasMaxLength(12)
                .HasColumnName("USER_ID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(12)
                .HasColumnName("CREATE_USER");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ModifyUser)
                .HasMaxLength(12)
                .HasColumnName("MODIFY_USER");
            entity.Property(e => e.UserCname)
                .HasMaxLength(50)
                .HasColumnName("USER_CNAME");
            entity.Property(e => e.UserEname)
                .HasMaxLength(50)
                .HasColumnName("USER_ENAME");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROJECT");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("CITY");
            entity.Property(e => e.Jid)
                .HasMaxLength(50)
                .HasColumnName("JID");
            entity.Property(e => e.Jname)
                .HasMaxLength(50)
                .HasColumnName("JNAME");
        });

        modelBuilder.Entity<ProjectProviderComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROJECT_PROVIDER_COMPONENT");

            entity.Property(e => e.Cid)
                .HasMaxLength(50)
                .HasColumnName("CID");
            entity.Property(e => e.Cnt)
                .HasMaxLength(50)
                .HasColumnName("CNT");
            entity.Property(e => e.Jid)
                .HasMaxLength(50)
                .HasColumnName("JID");
            entity.Property(e => e.Pid)
                .HasMaxLength(50)
                .HasColumnName("PID");
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROVIDER");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("CITY");
            entity.Property(e => e.Pid)
                .HasMaxLength(50)
                .HasColumnName("PID");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .HasColumnName("PNAME");
        });

        modelBuilder.Entity<SpanTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SPAN_TABLE");

            entity.Property(e => e.CreDate)
                .HasColumnType("datetime")
                .HasColumnName("CRE_DATE");
            entity.Property(e => e.CreUsr)
                .HasMaxLength(12)
                .HasColumnName("CRE_USR");
            entity.Property(e => e.IdentityFiled)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDENTITY_FILED");
            entity.Property(e => e.ModDate)
                .HasColumnType("datetime")
                .HasColumnName("MOD_DATE");
            entity.Property(e => e.ModUsr)
                .HasMaxLength(12)
                .HasColumnName("MOD_USR");
            entity.Property(e => e.Note)
                .HasMaxLength(12)
                .HasColumnName("NOTE");
            entity.Property(e => e.SpanEnd)
                .HasMaxLength(12)
                .HasColumnName("SPAN_END");
            entity.Property(e => e.SpanStart)
                .HasMaxLength(12)
                .HasColumnName("SPAN_START");
            entity.Property(e => e.SpanYear)
                .HasMaxLength(12)
                .HasColumnName("SPAN_YEAR");
        });

        modelBuilder.Entity<TestTable2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TestTable2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Textval)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEXTVal");
        });

        modelBuilder.Entity<UseRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USE_RECORD");

            entity.Property(e => e.UseDateEnd)
                .HasMaxLength(50)
                .HasColumnName("USE_DATE_END");
            entity.Property(e => e.UseDateStart)
                .HasMaxLength(50)
                .HasColumnName("USE_DATE_START");
            entity.Property(e => e.UsePlace)
                .HasMaxLength(50)
                .HasColumnName("USE_PLACE");
            entity.Property(e => e.UseTimeEnd)
                .HasMaxLength(50)
                .HasColumnName("USE_TIME_END");
            entity.Property(e => e.UseTimeStart)
                .HasMaxLength(50)
                .HasColumnName("USE_TIME_START");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("USER_ID");
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_PROFILE");

            entity.Property(e => e.UserAddress)
                .HasMaxLength(50)
                .HasColumnName("USER_ADDRESS");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("USER_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.UserPhone)
                .HasMaxLength(50)
                .HasColumnName("USER_PHONE");
            entity.Property(e => e.UserSex)
                .HasMaxLength(50)
                .HasColumnName("USER_SEX");
        });

        modelBuilder.Entity<員工>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("員工");

            entity.Property(e => e.上班開始日).HasColumnType("date");
            entity.Property(e => e.員工姓名).HasMaxLength(50);
            entity.Property(e => e.員工編號).HasMaxLength(50);
            entity.Property(e => e.職稱編號).HasMaxLength(50);
            entity.Property(e => e.薪水).HasColumnType("money");
            entity.Property(e => e.部門編號).HasMaxLength(50);
        });

        modelBuilder.Entity<部門>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("部門");

            entity.Property(e => e.所在地編號).HasMaxLength(50);
            entity.Property(e => e.經理編號).HasMaxLength(50);
            entity.Property(e => e.部門名稱).HasMaxLength(50);
            entity.Property(e => e.部門編號).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
