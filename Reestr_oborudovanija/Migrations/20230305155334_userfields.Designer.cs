// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reestr_oborudovanija;

#nullable disable

namespace Reestr_oborudovanija.Migrations
{
    [DbContext(typeof(ReestrContext))]
    [Migration("20230305155334_userfields")]
    partial class userfields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.14");

            modelBuilder.Entity("Reestr_oborudovanija.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Accounting")
                        .HasColumnType("INTEGER");

                    b.Property<float>("BalanceValue")
                        .HasColumnType("REAL");

                    b.Property<int>("CountFact")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountInList")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Depreciation")
                        .HasColumnType("REAL");

                    b.Property<string>("InventoryNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NameInList")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Required")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("ResidualValue")
                        .HasColumnType("REAL");

                    b.Property<int>("State_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Storage_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TransferTo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Usages")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("State_id");

                    b.HasIndex("Status_id");

                    b.HasIndex("Storage_id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("Reestr_oborudovanija.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Reestr_oborudovanija.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("Reestr_oborudovanija.Models.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Reestr_oborudovanija.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Reestr_oborudovanija.Models.Equipment", b =>
                {
                    b.HasOne("Reestr_oborudovanija.Models.State", "State")
                        .WithMany("Equipments")
                        .HasForeignKey("State_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reestr_oborudovanija.Models.Status", "Status")
                        .WithMany("Equipments")
                        .HasForeignKey("Status_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reestr_oborudovanija.Models.Storage", "Storage")
                        .WithMany("Equipments")
                        .HasForeignKey("Storage_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");

                    b.Navigation("Status");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("Reestr_oborudovanija.Models.State", b =>
                {
                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("Reestr_oborudovanija.Models.Status", b =>
                {
                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("Reestr_oborudovanija.Models.Storage", b =>
                {
                    b.Navigation("Equipments");
                });
#pragma warning restore 612, 618
        }
    }
}
