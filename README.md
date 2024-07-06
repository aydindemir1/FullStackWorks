2. Hafta Ödevleri


 📚 Ödev 1:  SOLID prensiplerinin her birini uygulamak için her prensibi ayrı bir sınıf içinde gerçekleştiriniz.

SOLID prensipleri, yazılım geliştirme sürecinde daha esnek, genişletilebilir ve bakım yapılabilir kodlar yazmak için beş temel prensibi içerir. Bu prensipler:

S - Single Responsibility Principle (Tek Sorumluluk Prensibi)
O - Open/Closed Principle (Açık/Kapalı Prensibi)
L - Liskov Substitution Principle (Liskov Yerine Geçme Prensibi)
I - Interface Segregation Principle (Arayüz Ayrımı Prensibi)
D - Dependency Inversion Principle (Bağımlılıkların Tersine Çevrilmesi Prensibi)

💻 Ödev 2:  Delegate ve Event Kullanımı ile ilgili 3 farklı örnek senaryo gerçekleştirin.

Senaryo 1: E-Ticaret Sistemi

Açıklama:
Bir e-ticaret sistemi, müşterilerin alışveriş yapmasına ve sipariş vermesine olanak tanır. Bu sistemde, sipariş tamamlandığında müşteriye ve ilgili departmanlara bilgi vermek için event ve delegate kullanılabilir.

Delegate ve Event Kullanımı:
Bir delegate tanımlanır ve sipariş tamamlandığında tetiklenecek event için kullanılır.
Müşteri hizmetleri departmanı, siparişin tamamlandığını bildiren bir e-posta göndermek için bu event'e abone olur.
Depo yönetim sistemi, stoktan düşülmesi gereken ürünleri güncellemek için aynı event'e abone olur.
Muhasebe departmanı, fatura oluşturmak için bu event'e abone olur.


Senaryo 2: Oyun Geliştirme
Açıklama:
Bir oyun geliştirme projesinde, oyun içerisindeki karakterlerin belirli olaylara tepki vermesi gerekmektedir. Örneğin, bir karakterin canı belirli bir seviyenin altına düştüğünde veya bir düşman öldüğünde bu olaylara tepki vermek için event ve delegate kullanılabilir.


Senaryo 3: Finansal Uygulama
Açıklama:
Bir finansal uygulama, kullanıcıların hesap hareketlerini izlemesine ve belirli finansal olaylardan haberdar olmasına olanak tanır. Örneğin, belirli bir tutarın üzerinde bir işlem gerçekleştirildiğinde veya bir hesapta belirli bir limitin altına düşüldüğünde bu olaylar için event ve delegate kullanılabilir.


📁 Tüm array/collection tipleri ile ilgili her biri ayrı bir class'ta olmak üzere örnek gerçekleştirin.

Array Tipleri

Array

System.Collections Namespace

ArrayList
Hashtable
Queue
Stack
System.Collections.Generic Namespace

List<T>
Dictionary<TKey, TValue>
SortedList<TKey, TValue>
Queue<T>
Stack<T>
HashSet<T>
LinkedList<T>

3. Hafta Ödevleri

Ödev: Generic Method ve Class'lar ile İlgili 3 Gerçek Dünya Örneği
Açıklama: Bu ödevde, generic method ve generic class kavramlarını gerçek dünya senaryolarında nasıl kullanabileceğinizi göstermeniz istenmektedir.

İstenilenler:

📂 Veri Depolama (Data Storage):

Bir generic sınıf oluşturarak, farklı veri tiplerinde elemanları depolayabilen bir yapı tasarlayın. Örneğin, bir DataStore<T> sınıfı oluşturun ve bu sınıf ile hem int hem string türünde verileri saklayın.
Örnek kod ve açıklama ile birlikte, bu yaklaşımın esnekliğini ve kod tekrarını nasıl azalttığını açıklayın.

🔢 Algoritmalar (Algorithms):

Generic method kullanarak, farklı veri tiplerinde çalışan bir sıralama algoritması (sorting algorithm) tasarlayın. Örneğin, bir Sort<T> methodu yazın ve bu methodun int[], string[] gibi farklı tiplerdeki dizileri sıralayabilmesini sağlayın.
Kod örneği ile birlikte, bu metodun tip güvenliği ve kod tekrarını nasıl önlediğini açıklayın.

🔄 Veri Dönüşümü (Data Transformation):

Generic method kullanarak, bir veri tipinden başka bir veri tipine dönüşüm yapan bir yapı tasarlayın. Örneğin, bir ConvertTo<T> methodu ile List<string> türündeki bir veriyi List<int> türüne dönüştürün.
Kod örneği ile birlikte, bu dönüşümün nasıl yapıldığını ve generic methodların bu süreçteki avantajlarını açıklayın.

Ödev: Extension Methodlar ile İlgili Örnekler
Açıklama: Bu ödevde, verilen sınıflar için çeşitli extension methodlar yazmanız istenmektedir. Extension methodlar, mevcut sınıflara yeni yetenekler eklemek için kullanılır ve mevcut kodu değiştirmeden yeni işlevsellikler sağlar.

İstenilenler:

📋 ICollection için Extension Method:

ICollection türündeki bir koleksiyona, eleman ekleme veya çıkarma işlemlerini daha kolay hale getiren bir extension method yazın. Örneğin, AddRange<T> adlı bir method ile birden fazla elemanı tek seferde ekleyin.

🔍 IEnumerable için Extension Method:

IEnumerable türündeki bir koleksiyondan, belirli bir koşula göre filtreleme yapabilen bir extension method yazın. Örneğin, WhereGreaterThan adlı bir method ile belirli bir değerden büyük olan elemanları filtreleyin.

📜 List için Extension Method:

List türündeki bir koleksiyona, elemanları tersine çeviren veya belirli bir sıraya göre sıralayan bir extension method yazın. Örneğin, ReverseOrder adlı bir method ile listeyi ters sıraya çevirin.

🔑 Dictionary için Extension Method:

Dictionary türündeki bir koleksiyona, belirli bir anahtar-değer çiftini arama veya çıkartma işlemlerini kolaylaştıran bir extension method yazın. Örneğin, GetOrDefault adlı bir method ile belirtilen anahtarın değerini bulun, yoksa varsayılan bir değer döndürün.


Ödev: MVC ve Razor Pages Projeleri için Veri Taşıma Örnekleri
Açıklama: Bu ödevde, hem MVC hem de Razor Pages projelerinde veri taşımak için kullanılan ViewBag, ViewData, TempData ve ViewModel yapılarını anlamanız ve kullanmanız istenmektedir. Her bir yapının nasıl kullanıldığını ve hangi durumlarda tercih edildiğini örneklerle açıklayın.

İstenilenler:

👜 ViewBag Kullanımı:
📦 ViewData Kullanımı:
⏳ TempData Kullanımı:
📊 ViewModel Kullanımı: 

