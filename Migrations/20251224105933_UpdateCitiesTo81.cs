using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SEYRİ_ALA.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCitiesTo81 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "FoodScore", "HistoryScore", "Latitude", "Longitude", "Name" },
                values: new object[] { "Lezzet ve festivallerin şehri.", 10, 7, 36.991399999999999, 35.330800000000004, "Adana" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "FoodScore", "Latitude", "Longitude", "Name", "NatureScore" },
                values: new object[] { "Nemrut Dağı ve dev heykeller.", 7, 37.764800000000001, 38.278599999999997, "Adıyaman", 7 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "FoodScore", "HistoryScore", "Latitude", "Longitude", "Name", "NatureScore" },
                values: new object[] { "Termal başkent ve mermerin merkezi.", 9, 8, 38.750700000000002, 30.556699999999999, "Afyonkarahisar", 6 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "FoodScore", "HistoryScore", "Latitude", "Longitude", "Name", "NatureScore" },
                values: new object[] { "İshak Paşa Sarayı ve heybetli Ağrı Dağı.", 6, 9, 39.721699999999998, 43.056699999999999, "Ağrı", 10 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "FoodScore", "HistoryScore", "Latitude", "Longitude", "Name", "NatureScore" },
                values: new object[] { "Şehzadeler şehri ve Kralkaya mezarları.", 8, 10, 40.649900000000002, 35.835299999999997, "Amasya", 8 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "FoodScore", "HistoryScore", "Latitude", "Longitude", "Name", "NatureScore" },
                values: new object[,]
                {
                    { 6, "Türkiye'nin kalbi ve Cumhuriyet'in merkezi.", 8, 10, 39.933399999999999, 32.859699999999997, "Ankara", 6 },
                    { 7, "Masmavi deniz ve antik kentler.", 8, 9, 36.896900000000002, 30.7133, "Antalya", 10 },
                    { 8, "Yeryüzü cenneti karagöller ve yaylalar.", 7, 5, 41.1828, 41.818300000000001, "Artvin", 10 },
                    { 9, "Efeler diyarı ve incirin anavatanı.", 8, 9, 37.8444, 27.845800000000001, "Aydın", 8 },
                    { 10, "Ege ve Marmara'nın buluştuğu nokta.", 8, 7, 39.648400000000002, 27.8826, "Balıkesir", 9 },
                    { 11, "Osmanlı'nın kurulduğu topraklar.", 6, 10, 40.142600000000002, 29.979299999999999, "Bilecik", 7 },
                    { 12, "Yüzen adalar ve doğa harikaları.", 7, 4, 38.885399999999997, 40.497999999999998, "Bingöl", 9 },
                    { 13, "Beş minareli şehir ve Ahlat Selçuklu mezarları.", 7, 10, 38.400599999999997, 42.109499999999997, "Bitlis", 8 },
                    { 14, "Abant ve Yedigöller ile doğa tutkusu.", 9, 5, 40.731000000000002, 31.608000000000001, "Bolu", 10 },
                    { 15, "Türkiye'nin Maldivleri: Salda Gölü.", 6, 8, 37.720300000000002, 30.290800000000001, "Burdur", 9 },
                    { 16, "Osmanlı'nın ilk başkenti ve Uludağ.", 10, 10, 40.182400000000001, 29.066700000000001, "Bursa", 8 },
                    { 17, "Destanlar şehri ve Truva antik kenti.", 8, 10, 40.145099999999999, 26.406700000000001, "Çanakkale", 9 },
                    { 18, "Tuz mağaraları ve yarenler diyarı.", 7, 7, 40.601300000000002, 33.613399999999999, "Çankırı", 7 },
                    { 19, "Hattuşaş ile Hititlerin kadim başkenti.", 8, 10, 40.550600000000003, 34.955599999999997, "Çorum", 6 },
                    { 20, "Pamukkale travertenleri ve horozu.", 7, 9, 37.776499999999999, 29.086400000000001, "Denizli", 10 },
                    { 21, "Tarihi surlar ve Hevsel Bahçeleri.", 10, 10, 37.914400000000001, 40.210999999999999, "Diyarbakır", 7 },
                    { 22, "Selimiye Camii ve Kırkpınar güreşleri.", 9, 10, 41.6768, 26.556999999999999, "Edirne", 6 },
                    { 23, "Harput Kalesi ve Gakkoşlar diyarı.", 9, 9, 38.680999999999997, 39.226399999999998, "Elazığ", 7 },
                    { 24, "Doğa sporları ve tulum peyniri.", 8, 6, 39.75, 39.5, "Erzincan", 9 },
                    { 25, "Palandöken ve Çifte Minareli Medrese.", 9, 9, 39.904299999999999, 41.267899999999997, "Erzurum", 9 },
                    { 26, "Porsuk Çayı ve öğrenci kenti.", 8, 8, 39.776699999999998, 30.520600000000002, "Eskişehir", 7 },
                    { 27, "Dünya gastronomi şehri ve Zeugma.", 10, 10, 37.066200000000002, 37.383299999999998, "Gaziantep", 5 },
                    { 28, "Fındığın başkenti ve Giresun Adası.", 8, 6, 40.912799999999997, 38.389499999999998, "Giresun", 10 },
                    { 29, "Karaca Mağarası ve pestil-köme.", 7, 6, 40.460799999999999, 39.481400000000001, "Gümüşhane", 9 },
                    { 30, "Cilo Dağları ve el değmemiş doğa.", 6, 5, 37.574399999999997, 43.7408, "Hakkari", 10 },
                    { 31, "Medeniyetler sofrası ve mozaik müzesi.", 10, 10, 36.202300000000001, 36.160600000000002, "Hatay", 7 },
                    { 32, "Gül ve lavanta bahçeleri.", 7, 7, 37.764400000000002, 30.5519, "Isparta", 9 },
                    { 33, "Palmiyeler, liman ve Tantuni.", 9, 8, 36.812100000000001, 34.641500000000001, "Mersin", 8 },
                    { 34, "İki kıtanın birleştiği dünya mirası.", 10, 10, 41.008200000000002, 28.978400000000001, "İstanbul", 6 },
                    { 35, "Ege'nin incisi ve Efes antik kenti.", 9, 10, 38.419199999999996, 27.128699999999998, "İzmir", 9 },
                    { 36, "Ani Harabeleri ve kar altındaki tarih.", 9, 10, 40.601900000000001, 43.097499999999997, "Kars", 8 },
                    { 37, "Valla Kanyonu ve tarihi konaklar.", 8, 8, 41.378700000000002, 33.7744, "Kastamonu", 10 },
                    { 38, "Erciyes Dağı ve pastırmanın merkezi.", 10, 8, 38.720500000000001, 35.482599999999998, "Kayseri", 8 },
                    { 39, "Longoz ormanları ve sakinlik.", 7, 6, 41.735100000000003, 27.226099999999999, "Kırklareli", 10 },
                    { 40, "Ahi Evran diyarı ve ozanlar şehri.", 7, 8, 39.142499999999998, 34.170900000000003, "Kırşehir", 6 },
                    { 41, "Sanayi ve Kartepe kayak merkezi.", 7, 6, 40.853299999999997, 29.881499999999999, "Kocaeli", 8 },
                    { 42, "Mevlana ve hoşgörü şehri.", 9, 10, 37.871400000000001, 32.4846, "Konya", 7 },
                    { 43, "Çini ve porselen sanatı.", 7, 9, 39.419699999999999, 29.985700000000001, "Kütahya", 7 },
                    { 44, "Kayısının başkenti ve Aslantepe Höyüğü.", 9, 9, 38.355200000000004, 38.3095, "Malatya", 7 },
                    { 45, "Şehzadeler şehri ve Mesir Macunu.", 8, 9, 38.619100000000003, 27.428899999999999, "Manisa", 8 },
                    { 46, "Dondurma ve kurtuluş mücadelesi.", 10, 8, 37.575299999999999, 36.922800000000002, "Kahramanmaraş", 8 },
                    { 47, "Taş konaklar ve masalsı tarih.", 9, 10, 37.312899999999999, 40.733899999999998, "Mardin", 6 },
                    { 48, "Bodrum, Marmaris ve eşsiz koylar.", 8, 9, 37.215299999999999, 28.363600000000002, "Muğla", 10 },
                    { 49, "Malazgirt Ovası ve tarihi camiler.", 6, 8, 38.743200000000002, 41.506399999999999, "Muş", 7 },
                    { 50, "Kapadokya ve peri bacaları.", 7, 10, 38.624400000000001, 34.714399999999998, "Nevşehir", 10 },
                    { 51, "Aladağlar ve tarihi kiliseler.", 7, 8, 37.966700000000003, 34.683300000000003, "Niğde", 9 },
                    { 52, "Boztepe'den Karadeniz manzarası.", 8, 6, 40.983899999999998, 37.876399999999997, "Ordu", 10 },
                    { 53, "Çayın merkezi ve kaçkar yaylaları.", 8, 5, 41.020099999999999, 40.523400000000002, "Rize", 10 },
                    { 54, "Sapanca Gölü ve doğa tatili.", 8, 5, 40.756900000000002, 30.378900000000002, "Sakarya", 9 },
                    { 55, "Milli mücadelenin başladığı şehir.", 8, 9, 41.2928, 36.331299999999999, "Samsun", 8 },
                    { 56, "Tillo ve büryan kebabı.", 9, 8, 37.933300000000003, 41.933300000000003, "Siirt", 7 },
                    { 57, "Türkiye'nin en kuzey noktası ve mantı.", 9, 9, 42.023099999999999, 35.153100000000002, "Sinop", 10 },
                    { 58, "Selçuklu mimarisi ve Divriği Ulu Camii.", 8, 10, 39.747700000000002, 37.017899999999997, "Sivas", 7 },
                    { 59, "Köfte ve deniz havası.", 9, 6, 40.9833, 27.5167, "Tekirdağ", 8 },
                    { 60, "Ballıca Mağarası ve Tokat Kebabı.", 9, 9, 40.316699999999997, 36.549999999999997, "Tokat", 8 },
                    { 61, "Sümela Manastırı ve horon.", 9, 9, 41.002699999999997, 39.716799999999999, "Trabzon", 10 },
                    { 62, "Munzur Vadisi ve doğal yaşam.", 7, 5, 39.107900000000001, 39.540100000000002, "Tunceli", 10 },
                    { 63, "Göbeklitepe ve Balıklıgöl.", 10, 10, 37.159100000000002, 38.796900000000001, "Şanlıurfa", 6 },
                    { 64, "Karun Hazineleri ve kanyonlar.", 7, 9, 38.682299999999998, 29.408200000000001, "Uşak", 8 },
                    { 65, "Van Gölü ve Akdamar Adası.", 9, 9, 38.489100000000001, 43.408900000000003, "Van", 9 },
                    { 66, "Türkiye'nin ilk milli parkı.", 8, 7, 39.818100000000001, 34.814700000000002, "Yozgat", 8 },
                    { 67, "Emeğin başkenti ve mağaralar.", 7, 5, 41.456400000000002, 31.7987, "Zonguldak", 8 },
                    { 68, "Ihlara Vadisi ve kervansaraylar.", 7, 9, 38.368699999999997, 34.032200000000003, "Aksaray", 9 },
                    { 69, "Baksı Müzesi ve Çoruh Nehri.", 6, 7, 40.255200000000002, 40.224899999999998, "Bayburt", 8 },
                    { 70, "Türkçe'nin başkenti.", 7, 9, 37.175899999999999, 33.228700000000003, "Karaman", 6 },
                    { 71, "Silah sanayi ve MKE.", 6, 5, 39.846800000000002, 33.515300000000003, "Kırıkkale", 6 },
                    { 72, "Hasankeyf ve petrol şehri.", 7, 9, 37.8812, 41.135100000000001, "Batman", 7 },
                    { 73, "Cudi Dağı ve Nuh'un Gemisi izleri.", 6, 8, 37.516399999999997, 42.461100000000002, "Şırnak", 8 },
                    { 74, "Amasra ve tarihi evler.", 8, 8, 41.634399999999999, 32.337499999999999, "Bartın", 9 },
                    { 75, "Çıldır Gölü ve soğuk hava.", 7, 6, 41.110500000000002, 42.702199999999998, "Ardahan", 9 },
                    { 76, "Üç ülkeye komşu ve kayısı.", 7, 5, 39.923699999999997, 44.045000000000002, "Iğdır", 8 },
                    { 77, "Termal sular ve doğa.", 7, 6, 40.654899999999998, 29.273800000000001, "Yalova", 8 },
                    { 78, "Safranbolu evleri.", 8, 10, 41.206099999999999, 32.620399999999997, "Karabük", 8 },
                    { 79, "Üzüm bağları ve kebap.", 9, 7, 36.718400000000003, 37.121200000000002, "Kilis", 6 },
                    { 80, "Yer fıstığı ve kaleler şehri.", 8, 8, 37.074199999999998, 36.246699999999997, "Osmaniye", 7 },
                    { 81, "Şelaleler ve rafting merkezi.", 8, 5, 40.843800000000002, 31.156500000000001, "Düzce", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "FoodScore", "HistoryScore", "Latitude", "Longitude", "Name" },
                values: new object[] { "Türkiye'nin kalbi, Cumhuriyet'in başkenti ve Anıtkabir'in evi.", 8, 10, 39.933399999999999, 32.859699999999997, "Ankara" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "FoodScore", "Latitude", "Longitude", "Name", "NatureScore" },
                values: new object[] { "İki kıtanın buluştuğu, tarihin kalbi İstanbul.", 10, 41.008200000000002, 28.978400000000001, "İstanbul", 5 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "FoodScore", "HistoryScore", "Latitude", "Longitude", "Name", "NatureScore" },
                values: new object[] { "Peri bacaları ve sıcak hava balonlarıyla masalsı bir yolculuk.", 7, 9, 38.643099999999997, 34.828899999999997, "Kapadokya", 10 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "FoodScore", "HistoryScore", "Latitude", "Longitude", "Name", "NatureScore" },
                values: new object[] { "Masmavi deniz ve antik kentlerin buluşma noktası.", 8, 8, 36.884099999999997, 30.7056, "Antalya", 9 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "FoodScore", "HistoryScore", "Latitude", "Longitude", "Name", "NatureScore" },
                values: new object[] { "Sümela Manastırı ve Uzungöl ile doğanın yeşil tonları.", 9, 8, 41.002699999999997, 39.716799999999999, "Trabzon", 10 });
        }
    }
}
