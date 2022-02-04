using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MRQ.CryptoBot.Repository.Migrations
{
    public partial class tres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Web3Url = table.Column<string>(type: "TEXT", nullable: true),
                    ContractABI = table.Column<string>(type: "TEXT", nullable: true),
                    ContractRouterForSwap = table.Column<string>(type: "TEXT", nullable: true),
                    DefaultGasPrice = table.Column<string>(type: "TEXT", nullable: false),
                    DefaultGas = table.Column<string>(type: "TEXT", nullable: false),
                    SlippageTolerance = table.Column<decimal>(type: "TEXT", nullable: false),
                    TokenDefaultContract = table.Column<string>(type: "TEXT", nullable: true),
                    KeyName = table.Column<string>(type: "TEXT", nullable: true),
                    ChainType = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeForPingConnectionWithInternet = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeForPingConnectionWithWeb3 = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeBetweenPriceUpdate = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeBetweenWalletBalanceUpdate = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Balance = table.Column<string>(type: "TEXT", nullable: true),
                    BalanceWei = table.Column<string>(type: "TEXT", nullable: true),
                    Decimals = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Adress = table.Column<string>(type: "TEXT", nullable: true),
                    PrivateKey = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoralisApiKey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Key = table.Column<string>(type: "TEXT", nullable: true),
                    ConfigurationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoralisApiKey", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoralisApiKey_Configurations_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "Configurations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoutersForSwap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ConfigurationId = table.Column<int>(type: "INTEGER", nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutersForSwap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoutersForSwap_Configurations_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "Configurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Router",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SwapOrder = table.Column<int>(type: "INTEGER", nullable: false),
                    Hash = table.Column<string>(type: "TEXT", nullable: false),
                    RoutersForSwapId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Router", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Router_RoutersForSwap_RoutersForSwapId",
                        column: x => x.RoutersForSwapId,
                        principalTable: "RoutersForSwap",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoralisApiKey_ConfigurationId",
                table: "MoralisApiKey",
                column: "ConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Router_RoutersForSwapId",
                table: "Router",
                column: "RoutersForSwapId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutersForSwap_ConfigurationId",
                table: "RoutersForSwap",
                column: "ConfigurationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoralisApiKey");

            migrationBuilder.DropTable(
                name: "Router");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "RoutersForSwap");

            migrationBuilder.DropTable(
                name: "Configurations");
        }
    }
}
