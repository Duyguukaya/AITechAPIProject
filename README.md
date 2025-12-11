# 🚀 AITech - Kurumsal Web Yönetim Sistemi

![.NET Core](https://img.shields.io/badge/.NET%20Core-8.0-purple)
![ASP.NET Web API](https://img.shields.io/badge/ASP.NET-Web%20API-blue)
![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework-Core-green)
![ViewComponents](https://img.shields.io/badge/ASP.NET-ViewComponents-red)
![Status](https://img.shields.io/badge/Status-In%20Development-yellow)

Bu proje, **.NET 8.0** teknolojisi kullanılarak geliştirilmiş, **N-Katmanlı Mimari (N-Tier Architecture)** yapısına sahip kapsamlı bir kurumsal web uygulamasıdır. Proje, veritabanı işlemlerini yöneten bir **Web API** ve bu API'yi tüketen bir **WebUI (MVC)** katmanından oluşmaktadır.

---

## 🏗️ Mimari ve Proje Yapısı

Proje, **Sorumlulukların Ayrılığı (SoC)** prensibine uygun olarak modüler bir yapıda tasarlanmıştır:

* **📂 AITech.Entity:** Veritabanı tablolarına karşılık gelen POCO sınıfları (`AppUser`, `Category` vb.).
* **📂 AITech.DataAccess:** Entity Framework Core Context yapılandırması ve Repository desenleri.
* **📂 AITech.Business:** İş kuralları, Validasyonlar (FluentValidation) ve Service katmanı.
* **📂 AITech.DTO:** API ve UI arasında veri taşıyan nesneler (Data Transfer Objects).
* **📂 AITech.API:** Veritabanı ile konuşan ve dış dünyaya JSON formatında veri sunan Backend servisi.
* **📂 AITech.WebUI:** Kullanıcı arayüzü ve yönetim paneli.
  * **Areas:** Yönetim paneli (Admin) ve kullanıcı arayüzü birbirinden izole edilmiştir.
  * **ViewComponents:** Sidebar, Navbar gibi tekrar eden yapılar `ViewComponent` mimarisi ile modüler hale getirilmiştir.

---

## 💻 Kullanılan Teknolojiler

* **Framework:** .NET 8.0
* **Mimari:** N-Tier Architecture, MVC (Model-View-Controller)
* **ORM:** Entity Framework Core (Code First)
* **Veritabanı:** MS SQL Server
* **Kimlik Doğrulama:** ASP.NET Core Identity & Cookie Authentication
* **Frontend:** HTML5, CSS3, Bootstrap 5, Razor View Engine
* **UI Components:** **ASP.NET Core ViewComponents**
* **Validasyon:** FluentValidation
* **Admin Template:** Mazer Dashboard
* **API İletişimi:** HttpClient

---

## 🔥 Temel Özellikler

- **🔐 Gelişmiş Kimlik Doğrulama:**
  - Kullanıcı Kayıt (Register) ve Giriş (Login) işlemleri.
  - API üzerinden güvenli doğrulama ve Cookie tabanlı oturum yönetimi.
  
- **⚙️ Modüler Yönetim Paneli (Areas):**
  - Proje, `Admin` Area'sı altında izole edilmiş bir yönetim paneline sahiptir.
  - Sidebar ve menü yapıları **ViewComponent** kullanılarak dinamikleştirilmiştir.
  
- **📂 İçerik Yönetimi (CRUD):**
  - Kategori, Proje, Referans, Takım Arkadaşları gibi tüm içeriklerin yönetimi.
  - Ekleme, Silme, Güncelleme ve Listeleme işlemleri.
  
- **🌐 API Tabanlı İletişim:**
  - Web arayüzü veritabanına doğrudan erişmez; tüm işlemler API üzerinden güvenli bir şekilde gerçekleştirilir.

## 📷 Ekran Görüntüleri

Projenin çalışan haline ait bazı görüntüler aşağıdadır:

<div align="center">
<br>
<h3>📂 Anasayfa</h3>
  <p>
    <img width="1897" height="824" alt="Ekran görüntüsü 2025-12-11 032216" src="https://github.com/user-attachments/assets/3a443fa0-e7c6-4e26-9c07-e21266649991" />
<img width="1918" height="833" alt="Ekran görüntüsü 2025-12-11 032224" src="https://github.com/user-attachments/assets/e17da6ee-da14-4ca8-b923-9f2972d62e69" />
<img width="1897" height="829" alt="Ekran görüntüsü 2025-12-11 032236" src="https://github.com/user-attachments/assets/2b15bcb0-141b-4ce8-8c80-03d0c141c290" />
<img width="1897" height="828" alt="Ekran görüntüsü 2025-12-11 032249" src="https://github.com/user-attachments/assets/30a301fc-e5b8-4c8c-9089-c1a3fcd00a73" />
<img width="1897" height="827" alt="Ekran görüntüsü 2025-12-11 032301" src="https://github.com/user-attachments/assets/74dbd757-ae7b-4410-a434-d8b31da536ee" />
<img width="1895" height="823" alt="Ekran görüntüsü 2025-12-11 032311" src="https://github.com/user-attachments/assets/cf5ccd71-ccf5-475d-bc3a-0a00aad8eab7" />
<img width="1891" height="825" alt="Ekran görüntüsü 2025-12-11 032322" src="https://github.com/user-attachments/assets/2bf9e196-fa71-4383-a648-b90d6dd2dc3f" />
<img width="1894" height="826" alt="Ekran görüntüsü 2025-12-11 032335" src="https://github.com/user-attachments/assets/a5c97277-2db4-4569-a2d5-41dc6c58428b" />
<img width="1896" height="829" alt="Ekran görüntüsü 2025-12-11 032348" src="https://github.com/user-attachments/assets/eb375f0b-b016-4c47-82e0-9e266391012e" />
  </p>
<br>
<br>
<br>

  <h3>🔐 Giriş ve Kayıt Ekranları</h3>
  <p>
   <img width="1919" height="823" alt="Ekran görüntüsü 2025-12-11 032403" src="https://github.com/user-attachments/assets/fbc78943-8903-4787-bc1a-e69bdc9dec4f" />
   <img width="1915" height="827" alt="Ekran görüntüsü 2025-12-11 032504" src="https://github.com/user-attachments/assets/29f5f3fc-81e1-4a3f-87a8-de427518db99" />
   <img width="1919" height="829" alt="Ekran görüntüsü 2025-12-11 032436" src="https://github.com/user-attachments/assets/5f3d2ae0-555c-49d8-9b3b-ebe223d8aee5" />
  </p>

  <br>
  <br>
  <br>

  <h3>📊 Admin Yönetim Paneli (Dashboard)</h3>
  <p>
    <img width="1919" height="826" alt="Ekran görüntüsü 2025-12-11 032514" src="https://github.com/user-attachments/assets/a9036479-cc89-4df2-890a-60a9145fbdd7" />
    <img width="1917" height="823" alt="Ekran görüntüsü 2025-12-11 032522" src="https://github.com/user-attachments/assets/b2c015e1-e6e5-4d90-af55-b2d30f1add0c" />
    <img width="1919" height="825" alt="Ekran görüntüsü 2025-12-11 032528" src="https://github.com/user-attachments/assets/195dbe07-8eb7-4417-9569-0dc3b9c0084a" />
    <img width="1919" height="827" alt="Ekran görüntüsü 2025-12-11 032534" src="https://github.com/user-attachments/assets/fe5f3196-ad7d-4d20-9b21-c0fbeba56b52" />
    <img width="1919" height="828" alt="Ekran görüntüsü 2025-12-11 032541" src="https://github.com/user-attachments/assets/14ccb2ae-1508-44d3-a30f-c8a9ef60810d" />
    <img width="1919" height="823" alt="Ekran görüntüsü 2025-12-11 032547" src="https://github.com/user-attachments/assets/4f7fdbf1-12f2-48ef-8579-87aa27ee6d1c" />
    <img width="1919" height="822" alt="Ekran görüntüsü 2025-12-11 032554" src="https://github.com/user-attachments/assets/ebc5d372-3417-4d7c-8e71-e97698683368" />
    <img width="1919" height="820" alt="Ekran görüntüsü 2025-12-11 032604" src="https://github.com/user-attachments/assets/3203044a-f7fa-47db-acf2-3b8e879e2e75" />
    <img width="1897" height="826" alt="Ekran görüntüsü 2025-12-11 032616" src="https://github.com/user-attachments/assets/88525ed5-1250-4807-9535-ebcb1cd57836" />
    <img width="1915" height="832" alt="Ekran görüntüsü 2025-12-11 032622" src="https://github.com/user-attachments/assets/22935348-bd9e-4483-9948-16d52022e124" />
  </p>
  <br>

  
</div>
