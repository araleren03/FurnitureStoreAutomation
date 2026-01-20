# 🪑 Mobilya Mağazası Otomasyon Sistemi

Bu proje, orta ölçekli bir mobilya mağazasının stok takibi, satış işlemleri ve personel yönetimini dijitalleştirmek amacıyla geliştirilmiş bir masaüstü otomasyon yazılımıdır. **C#** programlama dili ve **PostgreSQL** veritabanı yönetim sistemi kullanılarak, Nesne Yönelimli Programlama (OOP) prensiplerine uygun olarak tasarlanmıştır.

## 🚀 Projenin Amacı
Mağaza içerisindeki ürün giriş-çıkışlarının kayıt altına alınması, stok hatalarının minimize edilmesi ve satış raporlarının güvenli bir veritabanı üzerinde tutulmasını sağlamaktır.

## 🛠️ Kullanılan Teknolojiler
* **Programlama Dili:** C# (.NET Framework)
* **Veritabanı:** PostgreSQL
* **Arayüz:** Windows Forms (WinForms)
* **Veri Erişimi:** Npgsql Kütüphanesi / ADO.NET

## ⚙️ Temel Özellikler
### 1. Kullanıcı ve Yetki Yönetimi 🔐
* Sisteme güvenli giriş (Admin ve Personel girişi).
* Kullanıcı yetkilerine göre menü erişim kısıtlamaları.

### 2. Stok ve Ürün Yönetimi 📦
* Yeni ürün ekleme, güncelleme ve silme işlemleri.
* Kategori bazlı ürün filtreleme.
* Kritik stok seviyesi takibi.

### 3. Satış İşlemleri 💰
* Müşteri seçimi ve ürün satışı.
* Satış sonrası stok miktarının veritabanından otomatik düşülmesi.

## 💻 Kurulum
1.  Bu projeyi bilgisayarınıza klonlayın.
2.  PostgreSQL veritabanında gerekli tabloları oluşturun.
3.  Proje içerisindeki veritabanı bağlantı cümlesini (Connection String) güncelleyin.
4.  Visual Studio üzerinden çalıştırın.

---
**Geliştirici:** [Eren Aral]
