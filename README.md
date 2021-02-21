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
<br> <br> :file_folder:`Abstract` 
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
- [IBrandDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/IBrandDal.cs)
- [ICarDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/ICarDal.cs)
- [IColorDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/IColorDal.cs)
- [ICustomerDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/ICustomerDal.cs)
- [IRentalDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/IRentalDal.cs)
- [IUserDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/IUserDal.cs)
 
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `EntityFramework`    
- [EfBrandDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)
- [EfCarDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Concrete/EntityFramework/EfCarDal.cs)
- [EfColorDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Concrete/EntityFramework/EfColorDal.cs)
- [EfCustomerDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs)
- [EfRentalDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Concrete/EntityFramework/EfRentalDal.cs)
- [EfUserDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Concrete/EntityFramework/EfUserDal.cs)
- [RentCarContext.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Concrete/EntityFramework/RentCarContext.cs)
## Business
İş kodlarının yer aldığı kısımdır. Validation yöntemi de bu katman altında yapılmaktadır.
<br>:file_folder:`Abstract` 
- [IBrandService.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Abstract/IBrandService.cs)
- [ICarService.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Abstract/ICarService.cs)
- [IColorService.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Abstract/IColorService.cs)
- [ICustomerService.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Abstract/ICustomerService.cs)
- [IRentalService.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Abstract/IRentalService.cs)
- [IUserService.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Abstract/IUserService.cs)
- 
<br> <br> :file_folder:`Concrete`
- [BrandManager.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Concrete/BrandManager.cs)
- [CarManager.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Concrete/CarManager.cs)
- [ColorManager.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Concrete/ColorManager.cs)
- [CustomerManager.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Concrete/CustomerManager.cs)
- [RentalManager.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Concrete/RentalManager.cs)
- [UserManager.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Concrete/UserManager.cs)
<br> <br> :file_folder:`Constants`
- [Messages.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Business/Constants/Messages.cs)
## Core 
Evrensel katmandır. Bir kere yazılır ve tüm projelerde kullanabiliriz. Başka bir katmana bağımlı olamaz.
Diğer katmanlar Core katmanına bağlıdır ve referans alırlar.

## WebAPI
Proje servislerine farklı yazılımlar,uygulamalar ve cihazlar üzerinden erişim sağlar.
Controllers dosyasında yer alan class'ların amacı client tarafından server'a yapılan istekleri karşılamak ve çalıştıralacak olan servise karar vermektir.

## ConsoleUI
Programı test etmek amacıyla oluşturulmuştur.


