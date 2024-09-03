using System;
using System.Collections.Generic;
using AdminSideEcoFridge.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Data;

public partial class EcoFridgeDbContext : DbContext
{
    public EcoFridgeDbContext()
    {
    }

    public EcoFridgeDbContext(DbContextOptions<EcoFridgeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DonationTransaction> DonationTransactions { get; set; }

    public virtual DbSet<Donee> Donees { get; set; }

    public virtual DbSet<Donor> Donors { get; set; }

    public virtual DbSet<Food> Foods { get; set; }

    public virtual DbSet<FoodCategory> FoodCategories { get; set; }

    public virtual DbSet<FoodIngredient> FoodIngredients { get; set; }

    public virtual DbSet<PaymentTransaction> PaymentTransactions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<StoragePlan> StoragePlans { get; set; }

    public virtual DbSet<StorageTip> StorageTips { get; set; }

    public virtual DbSet<StorageTipForFoodCategory> StorageTipForFoodCategories { get; set; }

    public virtual DbSet<TempImg> TempImgs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserFood> UserFoods { get; set; }

    public virtual DbSet<UserPlan> UserPlans { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<VwUsersFoodItem> VwUsersFoodItems { get; set; }

    public virtual DbSet<VwUsersRoleView> VwUsersRoleViews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-FO9D3C2\\SQLEXPRESS;Initial Catalog=EcoFridgeDB;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DonationTransaction>(entity =>
        {
            entity.HasKey(e => e.DonationTransactionId).HasName("PK__Donation__24AA58DDB2663727");

            entity.HasOne(d => d.Donee).WithMany(p => p.DonationTransactions).HasConstraintName("FK__DonationT__Donee__03F0984C");

            entity.HasOne(d => d.Donor).WithMany(p => p.DonationTransactions).HasConstraintName("FK__DonationT__Donor__02FC7413");

            entity.HasOne(d => d.UserFood).WithMany(p => p.DonationTransactions).HasConstraintName("FK__DonationT__UserF__04E4BC85");
        });

        modelBuilder.Entity<Donee>(entity =>
        {
            entity.HasKey(e => e.DoneeId).HasName("PK__Donee__8E69438E404EA638");

            entity.HasOne(d => d.UserRole).WithMany(p => p.Donees).HasConstraintName("FK__Donee__UserRoleI__76969D2E");
        });

        modelBuilder.Entity<Donor>(entity =>
        {
            entity.HasKey(e => e.DonorId).HasName("PK__Donor__052E3F7838A607BC");

            entity.HasOne(d => d.UserRole).WithMany(p => p.Donors).HasConstraintName("FK__Donor__UserRoleI__73BA3083");
        });

        modelBuilder.Entity<Food>(entity =>
        {
            entity.HasKey(e => e.FoodId).HasName("PK__Food__856DB3EBF2F4140B");
        });

        modelBuilder.Entity<FoodCategory>(entity =>
        {
            entity.HasKey(e => e.FoodCategoryId).HasName("PK__FoodCate__5451B7EBF4B90333");
        });

        modelBuilder.Entity<FoodIngredient>(entity =>
        {
            entity.HasKey(e => e.FoodIngredientId).HasName("PK__FoodIngr__CB78CEA6B46AFB3F");

            entity.HasOne(d => d.Food).WithMany(p => p.FoodIngredients).HasConstraintName("FK__FoodIngre__FoodI__5812160E");
        });

        modelBuilder.Entity<PaymentTransaction>(entity =>
        {
            entity.HasKey(e => e.PaymentTransactionId).HasName("PK__PaymentT__C22AEFE01C2A3737");

            entity.HasOne(d => d.StoragePlan).WithMany(p => p.PaymentTransactions).HasConstraintName("FK__PaymentTr__Stora__70DDC3D8");

            entity.HasOne(d => d.User).WithMany(p => p.PaymentTransactions).HasConstraintName("FK__PaymentTr__UserI__6FE99F9F");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE1AA3B71A03");
        });

        modelBuilder.Entity<StoragePlan>(entity =>
        {
            entity.HasKey(e => e.StoragePlanId).HasName("PK__StorageP__4F8B77F4296B6E5D");
        });

        modelBuilder.Entity<StorageTip>(entity =>
        {
            entity.HasKey(e => e.StorageTipId).HasName("PK__StorageT__D0D77EBC9C4A7F48");
        });

        modelBuilder.Entity<StorageTipForFoodCategory>(entity =>
        {
            entity.HasKey(e => e.StorageTipFoFoodCategoryId).HasName("PK__StorageT__2602B46EBAEE01B8");

            entity.HasOne(d => d.FoodCategory).WithMany(p => p.StorageTipForFoodCategories).HasConstraintName("FK__StorageTi__FoodC__619B8048");

            entity.HasOne(d => d.StorageTip).WithMany(p => p.StorageTipForFoodCategories).HasConstraintName("FK__StorageTi__Stora__60A75C0F");
        });

        modelBuilder.Entity<TempImg>(entity =>
        {
            entity.HasKey(e => e.TempImgId).HasName("PK__TempImg__232A163F10F9354F");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CC4CECF201F5");

            entity.Property(e => e.Gender).IsFixedLength();
            entity.Property(e => e.StorageSize).HasDefaultValue(5);
        });

        modelBuilder.Entity<UserFood>(entity =>
        {
            entity.HasKey(e => e.UserFoodId).HasName("PK__UserFood__AA76FA87695A2980");

            entity.HasOne(d => d.Food).WithMany(p => p.UserFoods).HasConstraintName("FK_UserFood_Food");

            entity.HasOne(d => d.User).WithMany(p => p.UserFoods).HasConstraintName("FK__UserFood__UserId__7E37BEF6");
        });

        modelBuilder.Entity<UserPlan>(entity =>
        {
            entity.HasKey(e => e.UserPlanId).HasName("PK__UserPlan__B2231FE1EABE836D");

            entity.HasOne(d => d.StoragePlan).WithMany(p => p.UserPlans).HasConstraintName("FK__UserPlan__Storag__6754599E");

            entity.HasOne(d => d.User).WithMany(p => p.UserPlans).HasConstraintName("FK__UserPlan__Expiry__66603565");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.UserRoleId).HasName("PK__UserRole__3D978A355DF1379B");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles).HasConstraintName("FK__UserRole__RoleId__5070F446");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles).HasConstraintName("FK__UserRole__UserId__4F7CD00D");
        });

        modelBuilder.Entity<VwUsersFoodItem>(entity =>
        {
            entity.ToView("VwUsersFoodItem");

            entity.Property(e => e.Gender).IsFixedLength();
        });

        modelBuilder.Entity<VwUsersRoleView>(entity =>
        {
            entity.ToView("VwUsersRoleView");

            entity.Property(e => e.Gender).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
