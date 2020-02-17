using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aegis.Data.Migrations
{
    public partial class Allmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(nullable: false),
                    BankItemList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guild",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Picture = table.Column<string>(nullable: true),
                    PlayerList = table.Column<string>(nullable: true),
                    GuildTax = table.Column<int>(nullable: false),
                    GuildAttackAdd = table.Column<int>(nullable: false),
                    GuildDeffenseAdd = table.Column<int>(nullable: false),
                    AttackMultiplier = table.Column<int>(nullable: false),
                    DeffenseMultiplier = table.Column<int>(nullable: false),
                    GuildGold = table.Column<int>(nullable: false),
                    RaidMembersList = table.Column<string>(nullable: true),
                    GuildBankId = table.Column<string>(nullable: true),
                    rank1 = table.Column<string>(nullable: true),
                    rank2 = table.Column<string>(nullable: true),
                    rank3 = table.Column<string>(nullable: true),
                    rank4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guild", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(nullable: false),
                    InventoryItemList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Attack = table.Column<int>(nullable: false),
                    Deffense = table.Column<int>(nullable: false),
                    Gold = table.Column<int>(nullable: false),
                    Mana = table.Column<int>(nullable: false),
                    Crit = table.Column<int>(nullable: false),
                    Block = table.Column<int>(nullable: false),
                    Evasion = table.Column<int>(nullable: false),
                    GoldPerHour = table.Column<int>(nullable: false),
                    MaxMana = table.Column<int>(nullable: false),
                    HealthPoints = table.Column<int>(nullable: false),
                    LevelReq = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Hp = table.Column<int>(nullable: false),
                    MinAttack = table.Column<int>(nullable: false),
                    MaxAttack = table.Column<int>(nullable: false),
                    Block = table.Column<int>(nullable: false),
                    DropList = table.Column<string>(nullable: true),
                    Drop1Chance = table.Column<int>(nullable: false),
                    Drop2Chance = table.Column<int>(nullable: false),
                    Drop3Chance = table.Column<int>(nullable: false),
                    GoldPerKill = table.Column<int>(nullable: false),
                    Exp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerClass",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    LevelReq = table.Column<int>(nullable: false),
                    NpcName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MonsterList = table.Column<string>(nullable: true),
                    MonsterCountFirst = table.Column<int>(nullable: false),
                    MonsterCountSecond = table.Column<int>(nullable: false),
                    MonsterCountThird = table.Column<int>(nullable: false),
                    MonsterCountFourth = table.Column<int>(nullable: false),
                    MonsterCountFifth = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LevelReq = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ManaCost = table.Column<int>(nullable: false),
                    Picture = table.Column<string>(nullable: true),
                    AttackAdd = table.Column<int>(nullable: false),
                    DeffenseAdd = table.Column<int>(nullable: false),
                    CritAdd = table.Column<int>(nullable: false),
                    BlockAdd = table.Column<int>(nullable: false),
                    AttackMultiplier = table.Column<int>(nullable: false),
                    DeffenseMultiplier = table.Column<int>(nullable: false),
                    PlayerClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuildBank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GuildId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    GuildBankItemList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildBank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuildBank_Guild_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guild",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nickname = table.Column<string>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    Gold = table.Column<int>(nullable: false),
                    MobsK = table.Column<int>(nullable: false),
                    PlayerK = table.Column<int>(nullable: false),
                    PlayerD = table.Column<int>(nullable: false),
                    DateCreated = table.Column<string>(nullable: true),
                    GuildId = table.Column<int>(nullable: false),
                    GuildRank = table.Column<string>(nullable: true),
                    StatusMessage = table.Column<string>(nullable: true),
                    ProfilePicture = table.Column<string>(nullable: true),
                    InventoryId = table.Column<int>(nullable: false),
                    BankId = table.Column<int>(nullable: false),
                    EquipedItemsList = table.Column<string>(nullable: true),
                    QuestDone = table.Column<string>(nullable: true),
                    Skills = table.Column<string>(nullable: true),
                    TotalAttack = table.Column<int>(nullable: false),
                    TotalDeffense = table.Column<int>(nullable: false),
                    TotalCrit = table.Column<int>(nullable: false),
                    TotalBlock = table.Column<int>(nullable: false),
                    TotalGoldH = table.Column<int>(nullable: false),
                    TotalEvasion = table.Column<int>(nullable: false),
                    TotalManaH = table.Column<int>(nullable: false),
                    TotalMaxMana = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerModel_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerModel_PlayerClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "PlayerClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerModel_Guild_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guild",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerModel_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Location = table.Column<string>(nullable: true),
                    MonsterList = table.Column<string>(nullable: true),
                    MonsterCount = table.Column<string>(nullable: true),
                    RespawnTime = table.Column<string>(nullable: true),
                    RoomPicture = table.Column<string>(nullable: true),
                    QuestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_Quest_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Quest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GlobalChat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlayerId = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalChat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GlobalChat_PlayerModel_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "PlayerModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Attack = table.Column<int>(nullable: false),
                    Deffense = table.Column<int>(nullable: false),
                    Gold = table.Column<int>(nullable: false),
                    Mana = table.Column<int>(nullable: false),
                    Crit = table.Column<int>(nullable: false),
                    Block = table.Column<int>(nullable: false),
                    Evasion = table.Column<int>(nullable: false),
                    GoldPerHour = table.Column<int>(nullable: false),
                    MaxMana = table.Column<int>(nullable: false),
                    HealthPoints = table.Column<int>(nullable: false),
                    LevelReq = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_PlayerModel_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "PlayerModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestPlayer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlayerId = table.Column<int>(nullable: false),
                    QuestId = table.Column<int>(nullable: false),
                    Count1 = table.Column<int>(nullable: false),
                    Count2 = table.Column<int>(nullable: false),
                    Count3 = table.Column<int>(nullable: false),
                    Count4 = table.Column<int>(nullable: false),
                    Count5 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestPlayer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestPlayer_PlayerModel_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "PlayerModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestPlayer_Quest_QuestId",
                        column: x => x.QuestId,
                        principalTable: "Quest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GlobalChat_PlayerId",
                table: "GlobalChat",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildBank_GuildId",
                table: "GuildBank",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PlayerId",
                table: "Item",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerModel_BankId",
                table: "PlayerModel",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerModel_ClassId",
                table: "PlayerModel",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerModel_GuildId",
                table: "PlayerModel",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerModel_InventoryId",
                table: "PlayerModel",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestPlayer_PlayerId",
                table: "QuestPlayer",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestPlayer_QuestId",
                table: "QuestPlayer",
                column: "QuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_QuestId",
                table: "Room",
                column: "QuestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GlobalChat");

            migrationBuilder.DropTable(
                name: "GuildBank");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "ItemList");

            migrationBuilder.DropTable(
                name: "Monster");

            migrationBuilder.DropTable(
                name: "QuestPlayer");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "PlayerModel");

            migrationBuilder.DropTable(
                name: "Quest");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "PlayerClass");

            migrationBuilder.DropTable(
                name: "Guild");

            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}
