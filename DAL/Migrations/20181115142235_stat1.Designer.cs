﻿// <auto-generated />
using Etherama.Common;
using Etherama.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Etherama.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181115142235_stat1")]
    partial class stat1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("Etherama.DAL.Models.BannedCountry", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnName("code")
                        .HasMaxLength(3);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnName("comment")
                        .HasMaxLength(512);

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnName("time_created");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("er_banned_country");
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp")
                        .HasMaxLength(64);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnName("normalized_name")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("er_role");
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type")
                        .HasMaxLength(256);

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value")
                        .HasMaxLength(256);

                    b.Property<long>("RoleId")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("er_role_claim");
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnName("access_failed_count");

                    b.Property<long>("AccessRights")
                        .HasColumnName("access_rights");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp")
                        .HasMaxLength(64);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnName("email_confirmed");

                    b.Property<string>("JwtSaltCabinet")
                        .IsRequired()
                        .HasColumnName("jwt_salt_cab")
                        .HasMaxLength(64);

                    b.Property<string>("JwtSaltDashboard")
                        .IsRequired()
                        .HasColumnName("jwt_salt_dbr")
                        .HasMaxLength(64);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnName("lockout_end");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnName("normalized_email")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnName("normalized_username")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnName("password_hash")
                        .HasMaxLength(512);

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasMaxLength(64);

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("SecurityStamp")
                        .HasColumnName("security_stamp")
                        .HasMaxLength(64);

                    b.Property<string>("TfaSecret")
                        .IsRequired()
                        .HasColumnName("tfa_secret")
                        .HasMaxLength(32);

                    b.Property<DateTime>("TimeRegistered")
                        .HasColumnName("time_registered");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnName("tfa_enabled");

                    b.Property<string>("UserName")
                        .HasColumnName("username")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("er_user");
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type")
                        .HasMaxLength(256);

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value")
                        .HasMaxLength(256);

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("er_user_claim");
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnName("provider_key")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnName("provider_display_name")
                        .HasMaxLength(64);

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("er_user_login");
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.UserRole", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.Property<long>("RoleId")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("er_user_role");
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.UserToken", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider")
                        .HasMaxLength(64);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasMaxLength(128);

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("er_user_token");
                });

            modelBuilder.Entity("Etherama.DAL.Models.KycTicket", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CallbackMessage")
                        .HasColumnName("callback_message")
                        .HasMaxLength(128);

                    b.Property<string>("CallbackStatusCode")
                        .HasColumnName("callback_status_code")
                        .HasMaxLength(32);

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnName("country_code")
                        .HasMaxLength(2);

                    b.Property<DateTime>("DoB")
                        .HasColumnName("dob");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasMaxLength(64);

                    b.Property<bool>("IsVerified")
                        .HasColumnName("is_verified");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasMaxLength(64);

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnName("method")
                        .HasMaxLength(32);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number")
                        .HasMaxLength(32);

                    b.Property<string>("ReferenceId")
                        .IsRequired()
                        .HasColumnName("reference_id")
                        .HasMaxLength(32);

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnName("time_created");

                    b.Property<DateTime?>("TimeResponded")
                        .HasColumnName("time_responed");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("er_kyc_shuftipro_ticket");
                });

            modelBuilder.Entity("Etherama.DAL.Models.Mutex", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasMaxLength(64);

                    b.Property<DateTime>("Expires")
                        .IsConcurrencyToken()
                        .HasColumnName("expires");

                    b.Property<string>("Locker")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnName("locker")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("er_mutex");
                });

            modelBuilder.Entity("Etherama.DAL.Models.Settings", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp")
                        .HasMaxLength(64);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnName("key")
                        .HasMaxLength(64);

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasMaxLength(16384);

                    b.HasKey("Id");

                    b.ToTable("er_settings");
                });

            modelBuilder.Entity("Etherama.DAL.Models.SignedDocument", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CallbackEvent")
                        .HasColumnName("callback_event_type")
                        .HasMaxLength(64);

                    b.Property<string>("CallbackStatus")
                        .HasColumnName("callback_status")
                        .HasMaxLength(16);

                    b.Property<bool>("IsSigned")
                        .HasColumnName("is_signed");

                    b.Property<string>("ReferenceId")
                        .IsRequired()
                        .HasColumnName("reference_id")
                        .HasMaxLength(64);

                    b.Property<string>("Secret")
                        .IsRequired()
                        .HasColumnName("secret")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("TimeCompleted")
                        .HasColumnName("time_completed");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnName("time_created");

                    b.Property<int>("Type")
                        .HasColumnName("type");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("er_signed_document");
                });

            modelBuilder.Entity("Etherama.DAL.Models.Token", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContractAddress")
                        .IsRequired()
                        .HasColumnName("contract_address")
                        .HasMaxLength(43);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasMaxLength(1024);

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("er_token");
                });

            modelBuilder.Entity("Etherama.DAL.Models.UserActivity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agent")
                        .IsRequired()
                        .HasColumnName("agent")
                        .HasMaxLength(128);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnName("comment")
                        .HasMaxLength(512);

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnName("ip")
                        .HasMaxLength(15);

                    b.Property<int?>("Locale")
                        .HasColumnName("locale");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnName("time_created");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(32);

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("er_user_activity");
                });

            modelBuilder.Entity("Etherama.DAL.Models.UserLimits", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("EthDeposited")
                        .HasColumnName("eth_deposited")
                        .HasColumnType("decimal(38, 18)");

                    b.Property<decimal>("EthWithdrawn")
                        .HasColumnName("eth_withdrawn")
                        .HasColumnType("decimal(38, 18)");

                    b.Property<long>("FiatDeposited")
                        .HasColumnName("fiat_deposited");

                    b.Property<long>("FiatWithdrawn")
                        .HasColumnName("fiat_withdrawn");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnName("time_created");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("er_user_limits");
                });

            modelBuilder.Entity("Etherama.DAL.Models.UserOpLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp")
                        .HasMaxLength(64);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnName("message")
                        .HasMaxLength(512);

                    b.Property<long?>("RefId")
                        .HasColumnName("ref_id");

                    b.Property<int>("Status")
                        .HasColumnName("status");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnName("time_created");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("RefId");

                    b.HasIndex("UserId");

                    b.ToTable("er_user_oplog");
                });

            modelBuilder.Entity("Etherama.DAL.Models.UserOptions", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("InitialTfaQuest")
                        .HasColumnName("init_tfa_quest");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("er_user_options");
                });

            modelBuilder.Entity("Etherama.DAL.Models.UserVerification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("AgreedWithTos")
                        .HasColumnName("tos_agreed");

                    b.Property<string>("Apartment")
                        .HasColumnName("apartment")
                        .HasMaxLength(128);

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasMaxLength(256);

                    b.Property<string>("Country")
                        .HasColumnName("country")
                        .HasMaxLength(64);

                    b.Property<string>("CountryCode")
                        .HasColumnName("country_code")
                        .HasMaxLength(2);

                    b.Property<DateTime?>("DoB")
                        .HasColumnName("dob");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasMaxLength(64);

                    b.Property<long?>("KycLastTicketId")
                        .HasColumnName("last_kyc_ticket_id");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasMaxLength(64);

                    b.Property<string>("MiddleName")
                        .HasColumnName("middle_name")
                        .HasMaxLength(64);

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasMaxLength(32);

                    b.Property<string>("PostalCode")
                        .HasColumnName("postal_code")
                        .HasMaxLength(16);

                    b.Property<bool?>("ProvedResidence")
                        .HasColumnName("proved_residence");

                    b.Property<string>("ProvedResidenceComment")
                        .HasColumnName("proved_residence_comment")
                        .HasMaxLength(512);

                    b.Property<string>("State")
                        .HasColumnName("state")
                        .HasMaxLength(256);

                    b.Property<string>("Street")
                        .HasColumnName("street")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("TimeUserChanged")
                        .HasColumnName("time_user_changed");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("KycLastTicketId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("er_user_verification");
                });

            modelBuilder.Entity("Etherama.DAL.Models.BannedCountry", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.RoleClaim", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.UserClaim", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.UserLogin", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.UserRole", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Etherama.DAL.Models.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.Identity.UserToken", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.KycTicket", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.SignedDocument", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.Token", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.UserActivity", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.UserLimits", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.UserOpLog", b =>
                {
                    b.HasOne("Etherama.DAL.Models.UserOpLog", "Ref")
                        .WithMany()
                        .HasForeignKey("RefId");

                    b.HasOne("Etherama.DAL.Models.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.UserOptions", b =>
                {
                    b.HasOne("Etherama.DAL.Models.Identity.User", "User")
                        .WithOne("UserOptions")
                        .HasForeignKey("Etherama.DAL.Models.UserOptions", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Etherama.DAL.Models.UserVerification", b =>
                {
                    b.HasOne("Etherama.DAL.Models.KycTicket", "LastKycTicket")
                        .WithMany()
                        .HasForeignKey("KycLastTicketId");

                    b.HasOne("Etherama.DAL.Models.Identity.User", "User")
                        .WithOne("UserVerification")
                        .HasForeignKey("Etherama.DAL.Models.UserVerification", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
