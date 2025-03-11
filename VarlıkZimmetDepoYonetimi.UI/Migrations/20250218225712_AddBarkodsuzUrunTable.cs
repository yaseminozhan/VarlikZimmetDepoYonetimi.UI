using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VarlıkZimmetDepoYonetimi.UI.Migrations
{
    /// <inheritdoc />
    public partial class AddBarkodsuzUrunTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BarkodsuzUrunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kategori = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarkodsuzUrunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ekip",
                columns: table => new
                {
                    EkipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EkipAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ekip", x => x.EkipID);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    ModelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UstModelID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.ModelID);
                    table.ForeignKey(
                        name: "FK_Model_Model_UstModelID",
                        column: x => x.UstModelID,
                        principalTable: "Model",
                        principalColumn: "ModelID");
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.MusteriID);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "Sayfa",
                columns: table => new
                {
                    SayfaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SayfaPath = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sayfa", x => x.SayfaID);
                });

            migrationBuilder.CreateTable(
                name: "Sirket",
                columns: table => new
                {
                    SirketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sirket", x => x.SirketID);
                });

            migrationBuilder.CreateTable(
                name: "Statu",
                columns: table => new
                {
                    StatuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatuAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statu", x => x.StatuID);
                });

            migrationBuilder.CreateTable(
                name: "Yetki",
                columns: table => new
                {
                    YetkiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YetkiAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetki", x => x.YetkiID);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    UrunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelID = table.Column<int>(type: "int", nullable: true),
                    GarantiliMi = table.Column<bool>(type: "bit", nullable: true),
                    UrunMaliyeti = table.Column<decimal>(type: "money", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BarkodluMu = table.Column<bool>(type: "bit", nullable: true),
                    UrunGuncelFiyat = table.Column<decimal>(type: "money", nullable: true),
                    UrunAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.UrunID);
                    table.ForeignKey(
                        name: "FK_Urun_Model_ModelID",
                        column: x => x.ModelID,
                        principalTable: "Model",
                        principalColumn: "ModelID");
                });

            migrationBuilder.CreateTable(
                name: "Calisan",
                columns: table => new
                {
                    CalisanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RolID = table.Column<int>(type: "int", nullable: true),
                    EkipID = table.Column<int>(type: "int", nullable: true),
                    AboneNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisan", x => x.CalisanID);
                    table.ForeignKey(
                        name: "FK_Calisan_Ekip_EkipID",
                        column: x => x.EkipID,
                        principalTable: "Ekip",
                        principalColumn: "EkipID");
                    table.ForeignKey(
                        name: "FK_Calisan_Rol_RolID",
                        column: x => x.RolID,
                        principalTable: "Rol",
                        principalColumn: "RolID");
                });

            migrationBuilder.CreateTable(
                name: "Depo",
                columns: table => new
                {
                    DepoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SirketID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depo", x => x.DepoID);
                    table.ForeignKey(
                        name: "FK_Depo_Sirket_SirketID",
                        column: x => x.SirketID,
                        principalTable: "Sirket",
                        principalColumn: "SirketID");
                });

            migrationBuilder.CreateTable(
                name: "EkipSirket",
                columns: table => new
                {
                    EkipId = table.Column<int>(type: "int", nullable: false),
                    SirketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkipSirket", x => new { x.EkipId, x.SirketId });
                    table.ForeignKey(
                        name: "FK_EkipSirket_Ekip_EkipId",
                        column: x => x.EkipId,
                        principalTable: "Ekip",
                        principalColumn: "EkipID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EkipSirket_Sirket_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirket",
                        principalColumn: "SirketID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SayfaYetki",
                columns: table => new
                {
                    SayfaID = table.Column<int>(type: "int", nullable: false),
                    YetkiID = table.Column<int>(type: "int", nullable: false),
                    RolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SayfaYetki", x => new { x.SayfaID, x.YetkiID, x.RolID });
                    table.ForeignKey(
                        name: "FK_SayfaYetki_Rol_RolID",
                        column: x => x.RolID,
                        principalTable: "Rol",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SayfaYetki_Sayfa_SayfaID",
                        column: x => x.SayfaID,
                        principalTable: "Sayfa",
                        principalColumn: "SayfaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SayfaYetki_Yetki_YetkiID",
                        column: x => x.YetkiID,
                        principalTable: "Yetki",
                        principalColumn: "YetkiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KayipCalinti",
                columns: table => new
                {
                    KayipCalintiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunID = table.Column<int>(type: "int", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tarih = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KayipCalinti", x => x.KayipCalintiID);
                    table.ForeignKey(
                        name: "FK_KayipCalinti_Urun_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urun",
                        principalColumn: "UrunID");
                });

            migrationBuilder.CreateTable(
                name: "UrunBarkod",
                columns: table => new
                {
                    UrunBarkodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarkodNo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UrunID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunBarkod", x => x.UrunBarkodID);
                    table.ForeignKey(
                        name: "FK_UrunBarkod_Urun_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urun",
                        principalColumn: "UrunID");
                });

            migrationBuilder.CreateTable(
                name: "UrunDetay",
                columns: table => new
                {
                    UrunDetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunID = table.Column<int>(type: "int", nullable: true),
                    Miktar = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunDetay", x => x.UrunDetayID);
                    table.ForeignKey(
                        name: "FK_UrunDetay_Urun_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urun",
                        principalColumn: "UrunID");
                });

            migrationBuilder.CreateTable(
                name: "UrunStatu",
                columns: table => new
                {
                    UrunStatuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    StatuID = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunStatu", x => x.UrunStatuID);
                    table.ForeignKey(
                        name: "FK_UrunStatu_Statu_StatuID",
                        column: x => x.StatuID,
                        principalTable: "Statu",
                        principalColumn: "StatuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UrunStatu_Urun_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urun",
                        principalColumn: "UrunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zimmet",
                columns: table => new
                {
                    ZimmetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunID = table.Column<int>(type: "int", nullable: true),
                    AtananCalisanID = table.Column<int>(type: "int", nullable: true),
                    AtayanCalisanID = table.Column<int>(type: "int", nullable: true),
                    ZimmetBaslangicTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    ZimmetBitisTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zimmet", x => x.ZimmetID);
                    table.ForeignKey(
                        name: "FK_Zimmet_Calisan_AtananCalisanID",
                        column: x => x.AtananCalisanID,
                        principalTable: "Calisan",
                        principalColumn: "CalisanID");
                    table.ForeignKey(
                        name: "FK_Zimmet_Calisan_AtayanCalisanID",
                        column: x => x.AtayanCalisanID,
                        principalTable: "Calisan",
                        principalColumn: "CalisanID");
                    table.ForeignKey(
                        name: "FK_Zimmet_Urun_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urun",
                        principalColumn: "UrunID");
                });

            migrationBuilder.CreateTable(
                name: "DepoUrun",
                columns: table => new
                {
                    DepoUrunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoID = table.Column<int>(type: "int", nullable: true),
                    UrunID = table.Column<int>(type: "int", nullable: true),
                    Miktar = table.Column<short>(type: "smallint", nullable: true),
                    Birim = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoUrun", x => x.DepoUrunID);
                    table.ForeignKey(
                        name: "FK_DepoUrun_Depo_DepoID",
                        column: x => x.DepoID,
                        principalTable: "Depo",
                        principalColumn: "DepoID");
                    table.ForeignKey(
                        name: "FK_DepoUrun_Urun_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urun",
                        principalColumn: "UrunID");
                });

            migrationBuilder.CreateTable(
                name: "MusteriZimmet",
                columns: table => new
                {
                    MusteriZimmetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZimmetID = table.Column<int>(type: "int", nullable: false),
                    MusteriID = table.Column<int>(type: "int", nullable: false),
                    TuketmeTarihi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriZimmet", x => x.MusteriZimmetID);
                    table.ForeignKey(
                        name: "FK_MusteriZimmet_Musteri_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteri",
                        principalColumn: "MusteriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusteriZimmet_Zimmet_ZimmetID",
                        column: x => x.ZimmetID,
                        principalTable: "Zimmet",
                        principalColumn: "ZimmetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusteriZimmetIptalIade",
                columns: table => new
                {
                    MusteriZimmetİptalIadeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriZimmetID = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IadeMi = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriZimmetIptalIade", x => x.MusteriZimmetİptalIadeID);
                    table.ForeignKey(
                        name: "FK_MusteriZimmetIptalIade_MusteriZimmet_MusteriZimmetID",
                        column: x => x.MusteriZimmetID,
                        principalTable: "MusteriZimmet",
                        principalColumn: "MusteriZimmetID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calisan_EkipID",
                table: "Calisan",
                column: "EkipID");

            migrationBuilder.CreateIndex(
                name: "IX_Calisan_RolID",
                table: "Calisan",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_Depo_SirketID",
                table: "Depo",
                column: "SirketID");

            migrationBuilder.CreateIndex(
                name: "IX_DepoUrun_DepoID",
                table: "DepoUrun",
                column: "DepoID");

            migrationBuilder.CreateIndex(
                name: "IX_DepoUrun_UrunID",
                table: "DepoUrun",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_EkipSirket_SirketId",
                table: "EkipSirket",
                column: "SirketId");

            migrationBuilder.CreateIndex(
                name: "IX_KayipCalinti_UrunID",
                table: "KayipCalinti",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_Model_UstModelID",
                table: "Model",
                column: "UstModelID");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriZimmet_MusteriID",
                table: "MusteriZimmet",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriZimmet_ZimmetID",
                table: "MusteriZimmet",
                column: "ZimmetID");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriZimmetIptalIade_MusteriZimmetID",
                table: "MusteriZimmetIptalIade",
                column: "MusteriZimmetID");

            migrationBuilder.CreateIndex(
                name: "IX_SayfaYetki_RolID",
                table: "SayfaYetki",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_SayfaYetki_YetkiID",
                table: "SayfaYetki",
                column: "YetkiID");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_ModelID",
                table: "Urun",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_UrunBarkod_UrunID",
                table: "UrunBarkod",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_UrunDetay_UrunID",
                table: "UrunDetay",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_UrunStatu_StatuID",
                table: "UrunStatu",
                column: "StatuID");

            migrationBuilder.CreateIndex(
                name: "IX_UrunStatu_UrunID",
                table: "UrunStatu",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_Zimmet_AtananCalisanID",
                table: "Zimmet",
                column: "AtananCalisanID");

            migrationBuilder.CreateIndex(
                name: "IX_Zimmet_AtayanCalisanID",
                table: "Zimmet",
                column: "AtayanCalisanID");

            migrationBuilder.CreateIndex(
                name: "IX_Zimmet_UrunID",
                table: "Zimmet",
                column: "UrunID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarkodsuzUrunler");

            migrationBuilder.DropTable(
                name: "DepoUrun");

            migrationBuilder.DropTable(
                name: "EkipSirket");

            migrationBuilder.DropTable(
                name: "KayipCalinti");

            migrationBuilder.DropTable(
                name: "MusteriZimmetIptalIade");

            migrationBuilder.DropTable(
                name: "SayfaYetki");

            migrationBuilder.DropTable(
                name: "UrunBarkod");

            migrationBuilder.DropTable(
                name: "UrunDetay");

            migrationBuilder.DropTable(
                name: "UrunStatu");

            migrationBuilder.DropTable(
                name: "Depo");

            migrationBuilder.DropTable(
                name: "MusteriZimmet");

            migrationBuilder.DropTable(
                name: "Sayfa");

            migrationBuilder.DropTable(
                name: "Yetki");

            migrationBuilder.DropTable(
                name: "Statu");

            migrationBuilder.DropTable(
                name: "Sirket");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "Zimmet");

            migrationBuilder.DropTable(
                name: "Calisan");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "Ekip");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Model");
        }
    }
}
