# Abstraction Pratiği – Proje Yöneticisi Örneği

Bu proje, C# dilinde **abstraction (soyutlama)** konusunun pratik edilmesi amacıyla hazırlanmıştır. Amaç, bir çalışan (employee) soyut sınıfı üzerinden farklı çalışan türlerinin görevlerinin nasıl tanımlanacağını göstermektir.

## 🔧 Kullanılan Kavramlar

- `abstract class` (soyut sınıf)
- `abstract method` (soyut metot)
- `override` (ezme)
- Nesne oluşturma ve property set etme

## 🧱 Sınıflar

### 🔹 Employee (abstract)
- Ortak özellikler: `Name`, `Surname`, `Department`
- Soyut metot: `Gorev()`

### 🔹 ProjectManager (türetilmiş sınıf)
- `Gorev()` metodunu override eder.
- Konsola proje yöneticisinin kişisel bilgileriyle görev tanımı yazdırır.

## 🧪 Program.cs Kullanımı

```csharp
ProjectManager projectManager = new ProjectManager();
projectManager.Name = "Hasan";
projectManager.Surname = "Çıldırmış";

projectManager.Gorev();
