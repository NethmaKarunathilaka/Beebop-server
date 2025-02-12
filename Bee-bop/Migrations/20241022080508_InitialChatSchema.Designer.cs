﻿// <auto-generated />
using Bee_bop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bee_bop.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241022080508_InitialChatSchema")]
    partial class InitialChatSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Bee_bop.Models.Message", b =>
                {
                    b.Property<int>("mid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("user_id")
                        .HasColumnType("INTEGER");

                    b.HasKey("mid");

                    b.HasIndex("user_id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Bee_bop.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Bee_bop.Models.Message", b =>
                {
                    b.HasOne("Bee_bop.Models.User", "user")
                        .WithMany("messages")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Bee_bop.Models.User", b =>
                {
                    b.Navigation("messages");
                });
#pragma warning restore 612, 618
        }
    }
}
