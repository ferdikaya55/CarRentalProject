## Araç Kiralama Projesi
Bu repo **Nitelikli Yazılım Geliştirici Yetiştirme Kampı**'nda yapılan çalışmaları kapsayan **Araç Kiralama Projesi**'ni içerir.
## :pushpin: Getting Started
N-Katmanlı Mimari yapısı ile hazırlanan projemizde **Entities,DataAccess,Business,Core,WebAPI,ConsoleUI** katmanları yer almaktadır.
### Proje içeriği
---
  + SOLID 
  + EntityFramework
  + LINQ
  + Generic Repository Design
  + Generic Constraint
  + Core Layer
  + Wep API
  + Autofac
  + Validation
  + AOP
## :books: Layers
**Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur.**
## Entities
Veritabanı nesneleri için oluşturulmuştur. Core katmanındaki IEntity interface'inden implemente edilmiştir.
<br>:file_folder:`Abstract`  
- ~~IEntity.cs~~ (Ortak Kod Olduğu İçin Core Katmanına Aktarıldı.)
<br> <br> :file_folder:`Concrete`  
    - [Car.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/Car.cs)  
    - [Brand.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/Brand.cs)
    - [Color.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/Color.css)
    - [User.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/User.cs)  
    - [Customer.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/Customer.cs)  
    - [Rental.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/Rental.cs)  
<br>:file_folder:`DTOs`  
<br>:file_folder:`Abstract`  
- ~~IDto.cs~~ (Ortak Kod Olduğu İçin Core Katmanına Aktarıldı.)
<br> <br> :file_folder:`Concrete`  
- [CarDetailDto.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/DTOs/CarDetailDto.cs)  
- [RentalDetailDto.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/DTOs/RentalDetailDto.cs)  



## DataAccess - Veri Erişim Katmanı
CRUD işlemleri yapılır. Context Class'ı barındırır.

<br>:file_folder:`Abstract`  
- [IBrandDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/IBrandDal.cs)
- [ICarDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/ICarDal.cs)
- [IColorDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/IColorDal.cs)
- [ICustomerDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/ICustomerDal.cs)
- [IRentalDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/IRentalDal.cs)
- [IUserDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Abstract/IUserDal.cs)
 
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `EntityFramework`    
    - [EfBrandDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)
    - [EfCarDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs)
    - [EfColorDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs)
    - [EfCustomerDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs)
    - [EfRentalDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfRentalDal.cs)
    - [EfUserDal.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs)
    - [MydbContext.cs](https://github.com/hsnbskn/ReCapProject/blob/master/DataAccess/Concrete/EntityFramework/MydbContext.cs)
## Business
İş kodlarının yer aldığı kısımdır. Validation yöntemi de bu katman altında yapılmaktadır.

## Core 
Evrensel katmandır. Bir kere yazılır ve tüm projelerde kullanabiliriz. Başka bir katmana bağımlı olamaz.
Diğer katmanlar Core katmanına bağlıdır ve referans alırlar.

## WebAPI
Proje servislerine farklı yazılımlar,uygulamalar ve cihazlar üzerinden erişim sağlar.
Controllers dosyasında yer alan class'ların amacı client tarafından server'a yapılan istekleri karşılamak ve çalıştıralacak olan servise karar vermektir.

## ConsoleUI
Programı test etmek amacıyla oluşturulmuştur.


