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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ~~[IEntity.cs]~~ (Ortak Kod Olduğu İçin Core Katmanına Aktarıldı.)
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Car.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/Car.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Brand.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/Brand.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Color.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/Color.css)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [User.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/User.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Customer.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/Customer.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Rental.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/Concrete/Rental.cs)  
<br>:file_folder:`DTOs`  
<br>:file_folder:`Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: ~~[IDto.cs]~~ (Ortak Kod Olduğu İçin Core Katmanına Aktarıldı.)
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarDetailDto.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/DTOs/CarDetailDto.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [RentalDetailDto.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/Entities/DTOs/RentalDetailDto.cs)  



## DataAccess - Veri Erişim Katmanı
CRUD işlemleri yapılır. Context Class'ı barındırır.

<br>:file_folder:`Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IBrandDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/IBrandDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ICarDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/ICarDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IColorDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/IColorDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ICustomerDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/ICustomerDal.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IUserDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/IUserDal.cs)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [IRentalDal.cs](https://github.com/ferdikaya55/CarRentalProject/blob/main/DataAccess/Abstract/IRentalDal.cs)  

<br> <br> :file_folder:`Concrete`
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:file_folder: `EntityFramework` 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfCarDal.cs]
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfBranDal.cs]
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfColorDal.cs]
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfUserDal.cs]
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfCustomerDal.cs] 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EfRentalDal.cs] 

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


