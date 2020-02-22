﻿// <auto-generated />
using System;
using Aegis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aegis.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200222113831_Mana cost for monster added")]
    partial class Manacostformonsteradded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aegis.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankItemList");

                    b.Property<int>("Count");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("Aegis.Models.GlobalChat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message");

                    b.Property<int>("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("GlobalChat");
                });

            modelBuilder.Entity("Aegis.Models.Guild", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttackMultiplier");

                    b.Property<int>("DeffenseMultiplier");

                    b.Property<int>("GuildAttackAdd");

                    b.Property<string>("GuildBankId");

                    b.Property<int>("GuildDeffenseAdd");

                    b.Property<int>("GuildGold");

                    b.Property<int>("GuildTax");

                    b.Property<string>("InvitationList");

                    b.Property<string>("Leader");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Picture");

                    b.Property<string>("PlayerList");

                    b.Property<string>("RaidMembersList");

                    b.Property<string>("rank1");

                    b.Property<string>("rank2");

                    b.Property<string>("rank3");

                    b.Property<string>("rank4");

                    b.HasKey("Id");

                    b.ToTable("Guild");
                });

            modelBuilder.Entity("Aegis.Models.GuildBank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<string>("GuildBankItemList");

                    b.Property<int>("GuildId");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("GuildBank");
                });

            modelBuilder.Entity("Aegis.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<string>("InventoryItemList");

                    b.HasKey("Id");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("Aegis.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Attack");

                    b.Property<int>("Block");

                    b.Property<string>("ClassRequirement");

                    b.Property<int>("Crit");

                    b.Property<int>("Deffense");

                    b.Property<string>("Description");

                    b.Property<int>("Evasion");

                    b.Property<int>("Gold");

                    b.Property<int>("GoldPerHour");

                    b.Property<int>("HealthPoints");

                    b.Property<int>("ItemClass");

                    b.Property<int>("ItemType");

                    b.Property<int>("LevelReq");

                    b.Property<int>("Mana");

                    b.Property<int>("MaxMana");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Picture");

                    b.Property<int>("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Aegis.Models.ItemList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Attack");

                    b.Property<int>("Block");

                    b.Property<string>("ClassRequirement");

                    b.Property<int>("Crit");

                    b.Property<int>("Deffense");

                    b.Property<string>("Description");

                    b.Property<int>("Evasion");

                    b.Property<int>("Gold");

                    b.Property<int>("GoldPerHour");

                    b.Property<int>("HealthPoints");

                    b.Property<int>("ItemClass");

                    b.Property<int>("ItemType");

                    b.Property<int>("LevelReq");

                    b.Property<int>("Mana");

                    b.Property<int>("MaxMana");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Picture");

                    b.HasKey("Id");

                    b.ToTable("ItemList");
                });

            modelBuilder.Entity("Aegis.Models.Monster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Block");

                    b.Property<int>("Drop1Chance");

                    b.Property<int>("Drop2Chance");

                    b.Property<int>("Drop3Chance");

                    b.Property<string>("DropList");

                    b.Property<int>("Exp");

                    b.Property<int>("GoldPerKill");

                    b.Property<int>("Hp");

                    b.Property<int>("Level");

                    b.Property<int>("ManaCost");

                    b.Property<int>("MaxAttack");

                    b.Property<int>("MinAttack");

                    b.Property<string>("Name");

                    b.Property<string>("Picture");

                    b.HasKey("Id");

                    b.ToTable("Monster");
                });

            modelBuilder.Entity("Aegis.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("IntValue1");

                    b.Property<int>("IntValue2");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("Aegis.Models.PlayerClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("PlayerClass");
                });

            modelBuilder.Entity("Aegis.Models.PlayerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankId");

                    b.Property<string>("Class")
                        .IsRequired();

                    b.Property<int>("CurrentMana");

                    b.Property<string>("DateCreated");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EquipedItemsList");

                    b.Property<int>("Experience");

                    b.Property<int>("Gold");

                    b.Property<int>("GuildId");

                    b.Property<string>("GuildName");

                    b.Property<string>("GuildRank");

                    b.Property<int>("InventoryId");

                    b.Property<int>("Level");

                    b.Property<int>("MobsK");

                    b.Property<string>("Nickname")
                        .IsRequired();

                    b.Property<int>("PlayerD");

                    b.Property<int>("PlayerK");

                    b.Property<string>("ProfilePicture");

                    b.Property<string>("QuestDone");

                    b.Property<string>("Skills");

                    b.Property<string>("StatusMessage");

                    b.Property<int>("TotalAttack");

                    b.Property<int>("TotalBlock");

                    b.Property<int>("TotalCrit");

                    b.Property<int>("TotalDeffense");

                    b.Property<int>("TotalEvasion");

                    b.Property<int>("TotalGoldH");

                    b.Property<int>("TotalHp");

                    b.Property<int>("TotalManaH");

                    b.Property<int>("TotalMaxMana");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("InventoryId");

                    b.ToTable("PlayerModel");
                });

            modelBuilder.Entity("Aegis.Models.Quest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("LevelReq");

                    b.Property<int>("MonsterCountFifth");

                    b.Property<int>("MonsterCountFirst");

                    b.Property<int>("MonsterCountFourth");

                    b.Property<int>("MonsterCountSecond");

                    b.Property<int>("MonsterCountThird");

                    b.Property<string>("MonsterList");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NpcName");

                    b.HasKey("Id");

                    b.ToTable("Quest");
                });

            modelBuilder.Entity("Aegis.Models.QuestPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count1");

                    b.Property<int>("Count2");

                    b.Property<int>("Count3");

                    b.Property<int>("Count4");

                    b.Property<int>("Count5");

                    b.Property<int>("PlayerId");

                    b.Property<int>("QuestId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("QuestId");

                    b.ToTable("QuestPlayer");
                });

            modelBuilder.Entity("Aegis.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location");

                    b.Property<string>("MonsterCount");

                    b.Property<string>("MonsterList");

                    b.Property<int>("QuestId");

                    b.Property<string>("RespawnTime");

                    b.Property<string>("RoomPicture");

                    b.HasKey("Id");

                    b.HasIndex("QuestId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Aegis.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttackAdd");

                    b.Property<int>("AttackMultiplier");

                    b.Property<int>("BlockAdd");

                    b.Property<int>("CritAdd");

                    b.Property<int>("DeffenseAdd");

                    b.Property<int>("DeffenseMultiplier");

                    b.Property<string>("Description");

                    b.Property<int>("LevelReq");

                    b.Property<int>("ManaCost");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Picture");

                    b.Property<string>("PlayerClass");

                    b.HasKey("Id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Aegis.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Nickname");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Aegis.Models.GlobalChat", b =>
                {
                    b.HasOne("Aegis.Models.PlayerModel", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Aegis.Models.GuildBank", b =>
                {
                    b.HasOne("Aegis.Models.Guild", "Guild")
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Aegis.Models.Item", b =>
                {
                    b.HasOne("Aegis.Models.PlayerModel", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Aegis.Models.PlayerModel", b =>
                {
                    b.HasOne("Aegis.Models.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Aegis.Models.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Aegis.Models.QuestPlayer", b =>
                {
                    b.HasOne("Aegis.Models.PlayerModel", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Aegis.Models.Quest", "Quest")
                        .WithMany()
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Aegis.Models.Room", b =>
                {
                    b.HasOne("Aegis.Models.Quest", "Quest")
                        .WithMany()
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
