using Microsoft.EntityFrameworkCore;
using SEYRİ_ALA.Models;

namespace SEYRİ_ALA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<City> Cities { get; set; }
        public DbSet<TravelRoute> Routes => Set<TravelRoute>();
        public DbSet<UserPreference> UserPreferences { get; set; }
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Favorite> Favorites => Set<Favorite>();

        public DbSet<Place> Places { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            // Bir kullanıcının aynı şehri birden fazla kez favorilere eklemesini engeller.
            modelBuilder.Entity<Favorite>()
                .HasIndex(f => new { f.UserId, f.CityId })
                .IsUnique();

            // Şehir Verileri
            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Adana", Latitude = 36.9914, Longitude = 35.3308, Description = "Lezzet ve festivallerin şehri.", HistoryScore = 7, NatureScore = 6, FoodScore = 10 },
                new City { Id = 2, Name = "Adıyaman", Latitude = 37.7648, Longitude = 38.2786, Description = "Nemrut Dağı ve dev heykeller.", HistoryScore = 10, NatureScore = 7, FoodScore = 7 },
                new City { Id = 3, Name = "Afyonkarahisar", Latitude = 38.7507, Longitude = 30.5567, Description = "Termal başkent ve mermerin merkezi.", HistoryScore = 8, NatureScore = 6, FoodScore = 9 },
                new City { Id = 4, Name = "Ağrı", Latitude = 39.7217, Longitude = 43.0567, Description = "İshak Paşa Sarayı ve heybetli Ağrı Dağı.", HistoryScore = 9, NatureScore = 10, FoodScore = 6 },
                new City { Id = 5, Name = "Amasya", Latitude = 40.6499, Longitude = 35.8353, Description = "Şehzadeler şehri ve Kralkaya mezarları.", HistoryScore = 10, NatureScore = 8, FoodScore = 8 },
                new City { Id = 6, Name = "Ankara", Latitude = 39.9334, Longitude = 32.8597, Description = "Türkiye'nin kalbi ve Cumhuriyet'in merkezi.", HistoryScore = 10, NatureScore = 6, FoodScore = 8 },
                new City { Id = 7, Name = "Antalya", Latitude = 36.8969, Longitude = 30.7133, Description = "Masmavi deniz ve antik kentler.", HistoryScore = 9, NatureScore = 10, FoodScore = 8 },
                new City { Id = 8, Name = "Artvin", Latitude = 41.1828, Longitude = 41.8183, Description = "Yeryüzü cenneti karagöller ve yaylalar.", HistoryScore = 5, NatureScore = 10, FoodScore = 7 },
                new City { Id = 9, Name = "Aydın", Latitude = 37.8444, Longitude = 27.8458, Description = "Efeler diyarı ve incirin anavatanı.", HistoryScore = 9, NatureScore = 8, FoodScore = 8 },
                new City { Id = 10, Name = "Balıkesir", Latitude = 39.6484, Longitude = 27.8826, Description = "Ege ve Marmara'nın buluştuğu nokta.", HistoryScore = 7, NatureScore = 9, FoodScore = 8 },
                new City { Id = 11, Name = "Bilecik", Latitude = 40.1426, Longitude = 29.9793, Description = "Osmanlı'nın kurulduğu topraklar.", HistoryScore = 10, NatureScore = 7, FoodScore = 6 },
                new City { Id = 12, Name = "Bingöl", Latitude = 38.8854, Longitude = 40.4980, Description = "Yüzen adalar ve doğa harikaları.", HistoryScore = 4, NatureScore = 9, FoodScore = 7 },
                new City { Id = 13, Name = "Bitlis", Latitude = 38.4006, Longitude = 42.1095, Description = "Beş minareli şehir ve Ahlat Selçuklu mezarları.", HistoryScore = 10, NatureScore = 8, FoodScore = 7 },
                new City { Id = 14, Name = "Bolu", Latitude = 40.7310, Longitude = 31.6080, Description = "Abant ve Yedigöller ile doğa tutkusu.", HistoryScore = 5, NatureScore = 10, FoodScore = 9 },
                new City { Id = 15, Name = "Burdur", Latitude = 37.7203, Longitude = 30.2908, Description = "Türkiye'nin Maldivleri: Salda Gölü.", HistoryScore = 8, NatureScore = 9, FoodScore = 6 },
                new City { Id = 16, Name = "Bursa", Latitude = 40.1824, Longitude = 29.0667, Description = "Osmanlı's ilk başkenti ve Uludağ.", HistoryScore = 10, NatureScore = 8, FoodScore = 10 },
                new City { Id = 17, Name = "Çanakkale", Latitude = 40.1451, Longitude = 26.4067, Description = "Destanlar şehri ve Truva antik kenti.", HistoryScore = 10, NatureScore = 9, FoodScore = 8 },
                new City { Id = 18, Name = "Çankırı", Latitude = 40.6013, Longitude = 33.6134, Description = "Tuz mağaraları ve yarenler diyarı.", HistoryScore = 7, NatureScore = 7, FoodScore = 7 },
                new City { Id = 19, Name = "Çorum", Latitude = 40.5506, Longitude = 34.9556, Description = "Hattuşaş ile Hititlerin kadim başkenti.", HistoryScore = 10, NatureScore = 6, FoodScore = 8 },
                new City { Id = 20, Name = "Denizli", Latitude = 37.7765, Longitude = 29.0864, Description = "Pamukkale travertenleri ve horozu.", HistoryScore = 9, NatureScore = 10, FoodScore = 7 },
                new City { Id = 21, Name = "Diyarbakır", Latitude = 37.9144, Longitude = 40.2110, Description = "Tarihi surlar ve Hevsel Bahçeleri.", HistoryScore = 10, NatureScore = 7, FoodScore = 10 },
                new City { Id = 22, Name = "Edirne", Latitude = 41.6768, Longitude = 26.5570, Description = "Selimiye Camii ve Kırkpınar güreşleri.", HistoryScore = 10, NatureScore = 6, FoodScore = 9 },
                new City { Id = 23, Name = "Elazığ", Latitude = 38.6810, Longitude = 39.2264, Description = "Harput Kalesi ve Gakkoşlar diyarı.", HistoryScore = 9, NatureScore = 7, FoodScore = 9 },
                new City { Id = 24, Name = "Erzincan", Latitude = 39.7500, Longitude = 39.5000, Description = "Doğa sporları ve tulum peyniri.", HistoryScore = 6, NatureScore = 9, FoodScore = 8 },
                new City { Id = 25, Name = "Erzurum", Latitude = 39.9043, Longitude = 41.2679, Description = "Palandöken ve Çifte Minareli Medrese.", HistoryScore = 9, NatureScore = 9, FoodScore = 9 },
                new City { Id = 26, Name = "Eskişehir", Latitude = 39.7767, Longitude = 30.5206, Description = "Porsuk Çayı ve öğrenci kenti.", HistoryScore = 8, NatureScore = 7, FoodScore = 8 },
                new City { Id = 27, Name = "Gaziantep", Latitude = 37.0662, Longitude = 37.3833, Description = "Dünya gastronomi şehri ve Zeugma.", HistoryScore = 10, NatureScore = 5, FoodScore = 10 },
                new City { Id = 28, Name = "Giresun", Latitude = 40.9128, Longitude = 38.3895, Description = "Fındığın başkenti ve Giresun Adası.", HistoryScore = 6, NatureScore = 10, FoodScore = 8 },
                new City { Id = 29, Name = "Gümüşhane", Latitude = 40.4608, Longitude = 39.4814, Description = "Karaca Mağarası ve pestil-köme.", HistoryScore = 6, NatureScore = 9, FoodScore = 7 },
                new City { Id = 30, Name = "Hakkari", Latitude = 37.5744, Longitude = 43.7408, Description = "Cilo Dağları ve el değmemiş doğa.", HistoryScore = 5, NatureScore = 10, FoodScore = 6 },
                new City { Id = 31, Name = "Hatay", Latitude = 36.2023, Longitude = 36.1606, Description = "Medeniyetler sofrası ve mozaik müzesi.", HistoryScore = 10, NatureScore = 7, FoodScore = 10 },
                new City { Id = 32, Name = "Isparta", Latitude = 37.7644, Longitude = 30.5519, Description = "Gül ve lavanta bahçeleri.", HistoryScore = 7, NatureScore = 9, FoodScore = 7 },
                new City { Id = 33, Name = "Mersin", Latitude = 36.8121, Longitude = 34.6415, Description = "Palmiyeler, liman ve Tantuni.", HistoryScore = 8, NatureScore = 8, FoodScore = 9 },
                new City { Id = 34, Name = "İstanbul", Latitude = 41.0082, Longitude = 28.9784, Description = "İki kıtanın birleştiği dünya mirası.", HistoryScore = 10, NatureScore = 6, FoodScore = 10 },
                new City { Id = 35, Name = "İzmir", Latitude = 38.4192, Longitude = 27.1287, Description = "Ege'nin incisi ve Efes antik kenti.", HistoryScore = 10, NatureScore = 9, FoodScore = 9 },
                new City { Id = 36, Name = "Kars", Latitude = 40.6019, Longitude = 43.0975, Description = "Ani Harabeleri ve kar altındaki tarih.", HistoryScore = 10, NatureScore = 8, FoodScore = 9 },
                new City { Id = 37, Name = "Kastamonu", Latitude = 41.3787, Longitude = 33.7744, Description = "Valla Kanyonu ve tarihi konaklar.", HistoryScore = 8, NatureScore = 10, FoodScore = 8 },
                new City { Id = 38, Name = "Kayseri", Latitude = 38.7205, Longitude = 35.4826, Description = "Erciyes Dağı ve pastırmanın merkezi.", HistoryScore = 8, NatureScore = 8, FoodScore = 10 },
                new City { Id = 39, Name = "Kırklareli", Latitude = 41.7351, Longitude = 27.2261, Description = "Longoz ormanları ve sakinlik.", HistoryScore = 6, NatureScore = 10, FoodScore = 7 },
                new City { Id = 40, Name = "Kırşehir", Latitude = 39.1425, Longitude = 34.1709, Description = "Ahi Evran diyarı ve ozanlar şehri.", HistoryScore = 8, NatureScore = 6, FoodScore = 7 },
                new City { Id = 41, Name = "Kocaeli", Latitude = 40.8533, Longitude = 29.8815, Description = "Sanayi ve Kartepe kayak merkezi.", HistoryScore = 6, NatureScore = 8, FoodScore = 7 },
                new City { Id = 42, Name = "Konya", Latitude = 37.8714, Longitude = 32.4846, Description = "Mevlana ve hoşgörü şehri.", HistoryScore = 10, NatureScore = 7, FoodScore = 9 },
                new City { Id = 43, Name = "Kütahya", Latitude = 39.4197, Longitude = 29.9857, Description = "Çini ve porselen sanatı.", HistoryScore = 9, NatureScore = 7, FoodScore = 7 },
                new City { Id = 44, Name = "Malatya", Latitude = 38.3552, Longitude = 38.3095, Description = "Kayısının başkenti ve Aslantepe Höyüğü.", HistoryScore = 9, NatureScore = 7, FoodScore = 9 },
                new City { Id = 45, Name = "Manisa", Latitude = 38.6191, Longitude = 27.4289, Description = "Şehzadeler şehri ve Mesir Macunu.", HistoryScore = 9, NatureScore = 8, FoodScore = 8 },
                new City { Id = 46, Name = "Kahramanmaraş", Latitude = 37.5753, Longitude = 36.9228, Description = "Dondurma ve kurtuluş mücadelesi.", HistoryScore = 8, NatureScore = 8, FoodScore = 10 },
                new City { Id = 47, Name = "Mardin", Latitude = 37.3129, Longitude = 40.7339, Description = "Taş konaklar ve masalsı tarih.", HistoryScore = 10, NatureScore = 6, FoodScore = 9 },
                new City { Id = 48, Name = "Muğla", Latitude = 37.2153, Longitude = 28.3636, Description = "Bodrum, Marmaris ve eşsiz koylar.", HistoryScore = 9, NatureScore = 10, FoodScore = 8 },
                new City { Id = 49, Name = "Muş", Latitude = 38.7432, Longitude = 41.5064, Description = "Malazgirt Ovası ve tarihi camiler.", HistoryScore = 8, NatureScore = 7, FoodScore = 6 },
                new City { Id = 50, Name = "Nevşehir", Latitude = 38.6244, Longitude = 34.7144, Description = "Kapadokya ve peri bacaları.", HistoryScore = 10, NatureScore = 10, FoodScore = 7 },
                new City { Id = 51, Name = "Niğde", Latitude = 37.9667, Longitude = 34.6833, Description = "Aladağlar ve tarihi kiliseler.", HistoryScore = 8, NatureScore = 9, FoodScore = 7 },
                new City { Id = 52, Name = "Ordu", Latitude = 40.9839, Longitude = 37.8764, Description = "Boztepe'den Karadeniz manzarası.", HistoryScore = 6, NatureScore = 10, FoodScore = 8 },
                new City { Id = 53, Name = "Rize", Latitude = 41.0201, Longitude = 40.5234, Description = "Çayın merkezi ve kaçkar yaylaları.", HistoryScore = 5, NatureScore = 10, FoodScore = 8 },
                new City { Id = 54, Name = "Sakarya", Latitude = 40.7569, Longitude = 30.3789, Description = "Sapanca Gölü ve doğa tatili.", HistoryScore = 5, NatureScore = 9, FoodScore = 8 },
                new City { Id = 55, Name = "Samsun", Latitude = 41.2928, Longitude = 36.3313, Description = "Milli mücadelenin başladığı şehir.", HistoryScore = 9, NatureScore = 8, FoodScore = 8 },
                new City { Id = 56, Name = "Siirt", Latitude = 37.9333, Longitude = 41.9333, Description = "Tillo ve büryan kebabı.", HistoryScore = 8, NatureScore = 7, FoodScore = 9 },
                new City { Id = 57, Name = "Sinop", Latitude = 42.0231, Longitude = 35.1531, Description = "Türkiye'nin en kuzey noktası ve mantı.", HistoryScore = 9, NatureScore = 10, FoodScore = 9 },
                new City { Id = 58, Name = "Sivas", Latitude = 39.7477, Longitude = 37.0179, Description = "Selçuklu mimarisi ve Divriği Ulu Camii.", HistoryScore = 10, NatureScore = 7, FoodScore = 8 },
                new City { Id = 59, Name = "Tekirdağ", Latitude = 40.9833, Longitude = 27.5167, Description = "Köfte ve deniz havası.", HistoryScore = 6, NatureScore = 8, FoodScore = 9 },
                new City { Id = 60, Name = "Tokat", Latitude = 40.3167, Longitude = 36.5500, Description = "Ballıca Mağarası ve Tokat Kebabı.", HistoryScore = 9, NatureScore = 8, FoodScore = 9 },
                new City { Id = 61, Name = "Trabzon", Latitude = 41.0027, Longitude = 39.7168, Description = "Sümela Manastırı ve horon.", HistoryScore = 9, NatureScore = 10, FoodScore = 9 },
                new City { Id = 62, Name = "Tunceli", Latitude = 39.1079, Longitude = 39.5401, Description = "Munzur Vadisi ve doğal yaşam.", HistoryScore = 5, NatureScore = 10, FoodScore = 7 },
                new City { Id = 63, Name = "Şanlıurfa", Latitude = 37.1591, Longitude = 38.7969, Description = "Göbeklitepe ve Balıklıgöl.", HistoryScore = 10, NatureScore = 6, FoodScore = 10 },
                new City { Id = 64, Name = "Uşak", Latitude = 38.6823, Longitude = 29.4082, Description = "Karun Hazineleri ve kanyonlar.", HistoryScore = 9, NatureScore = 8, FoodScore = 7 },
                new City { Id = 65, Name = "Van", Latitude = 38.4891, Longitude = 43.4089, Description = "Van Gölü ve Akdamar Adası.", HistoryScore = 9, NatureScore = 9, FoodScore = 9 },
                new City { Id = 66, Name = "Yozgat", Latitude = 39.8181, Longitude = 34.8147, Description = "Türkiye'nin ilk milli parkı.", HistoryScore = 7, NatureScore = 8, FoodScore = 8 },
                new City { Id = 67, Name = "Zonguldak", Latitude = 41.4564, Longitude = 31.7987, Description = "Emeğin başkenti ve mağaralar.", HistoryScore = 5, NatureScore = 8, FoodScore = 7 },
                new City { Id = 68, Name = "Aksaray", Latitude = 38.3687, Longitude = 34.0322, Description = "Ihlara Vadisi ve kervansaraylar.", HistoryScore = 9, NatureScore = 9, FoodScore = 7 },
                new City { Id = 69, Name = "Bayburt", Latitude = 40.2552, Longitude = 40.2249, Description = "Baksı Müzesi ve Çoruh Nehri.", HistoryScore = 7, NatureScore = 8, FoodScore = 6 },
                new City { Id = 70, Name = "Karaman", Latitude = 37.1759, Longitude = 33.2287, Description = "Türkçe'nin başkenti.", HistoryScore = 9, NatureScore = 6, FoodScore = 7 },
                new City { Id = 71, Name = "Kırıkkale", Latitude = 39.8468, Longitude = 33.5153, Description = "Silah sanayi ve MKE.", HistoryScore = 5, NatureScore = 6, FoodScore = 6 },
                new City { Id = 72, Name = "Batman", Latitude = 37.8812, Longitude = 41.1351, Description = "Hasankeyf ve petrol şehri.", HistoryScore = 9, NatureScore = 7, FoodScore = 7 },
                new City { Id = 73, Name = "Şırnak", Latitude = 37.5164, Longitude = 42.4611, Description = "Cudi Dağı ve Nuh'un Gemisi izleri.", HistoryScore = 8, NatureScore = 8, FoodScore = 6 },
                new City { Id = 74, Name = "Bartın", Latitude = 41.6344, Longitude = 32.3375, Description = "Amasra ve tarihi evler.", HistoryScore = 8, NatureScore = 9, FoodScore = 8 },
                new City { Id = 75, Name = "Ardahan", Latitude = 41.1105, Longitude = 42.7022, Description = "Çıldır Gölü ve soğuk hava.", HistoryScore = 6, NatureScore = 9, FoodScore = 7 },
                new City { Id = 76, Name = "Iğdır", Latitude = 39.9237, Longitude = 44.0450, Description = "Üç ülkeye komşu ve kayısı.", HistoryScore = 5, NatureScore = 8, FoodScore = 7 },
                new City { Id = 77, Name = "Yalova", Latitude = 40.6549, Longitude = 29.2738, Description = "Termal sular ve doğa.", HistoryScore = 6, NatureScore = 8, FoodScore = 7 },
                new City { Id = 78, Name = "Karabük", Latitude = 41.2061, Longitude = 32.6204, Description = "Safranbolu evleri.", HistoryScore = 10, NatureScore = 8, FoodScore = 8 },
                new City { Id = 79, Name = "Kilis", Latitude = 36.7184, Longitude = 37.1212, Description = "Üzüm bağları ve kebap.", HistoryScore = 7, NatureScore = 6, FoodScore = 9 },
                new City { Id = 80, Name = "Osmaniye", Latitude = 37.0742, Longitude = 36.2467, Description = "Yer fıstığı ve kaleler şehri.", HistoryScore = 8, NatureScore = 7, FoodScore = 8 },
                new City { Id = 81, Name = "Düzce", Latitude = 40.8438, Longitude = 31.1565, Description = "Şelaleler ve rafting merkezi.", HistoryScore = 5, NatureScore = 10, FoodScore = 8 }
            );
        }
    }
}