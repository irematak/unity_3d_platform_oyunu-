#  Unity 3D Platform Oyunu

Oyun simmer.io platformuna yüklenmiştir.     
Link : https://simmer.io/@irematak/degisen-top     

## Oynanış
Oyununun genel mantığı cisimin içinden geçtiği topun rengine göre renk ve boyut değiştirmesidir.    
Başlangıçta oyunucunun 5 tane canı bulunmaktadır.    
Eğer kendisiyle aynı renkte bir topun içinden geçerse boyutu artmaktadır.     
Farklı renkte bir topun içinden geçerse boyutu küçülmektedir, rengi de o topun rengi olmaktadır ve ayrıca canı bir azalmaktadır.    
Oyuncunun canı sadece farklı bir topun içinden geçince azalmaktadır. Sahnede engel olarak bloklar da bulunmaktadır.   
Tüm canların bitmesiyle oyun sonlanmaktadır.    
Arrow tuşlarıyla cisim hareket etmektedir.    

<img width="500" alt="oyun1" src="https://user-images.githubusercontent.com/75726319/204599717-4c5adeef-a80c-4bba-b55a-50a7b036c4cf.PNG">

5 adet script bulunmaktadır.Bunlar:      
PlayerMovement.cs      
player_sc.cs      
manager_sc.cs     
gain_point_sc.cs      
PauseMenu.cs       

PlayerMovement isimli script ben tarafından yazıldı. Start fonksiyonu içinde cisim belli bir hızla başlatıldı. Update fonksiyonundaysa oyundaki girdiler Input.GetAxis() ile alındı. Bu şekilde arrow tuşlarıyla cisim hareket ettirilebilmektedir. Cismin platformdan dışarı çıkması durumu da incelendi ve platformumuzun boyutuna göre transform.position.x değerlerine göre sağdan ya da soldan çıkma durumunda cismin konumu tam  olarak ortalandı. Bu scriptte yer alan OnCollisionEnter fonksiyonunda cismin bloğa çarptıktan sonra nasıl hareket etmesi gerektiği kodlandı. İlk olarak collision olan cismin tag'i kontrol edildi eğer tag'i blok ise çarpışma sonrasında cismin konumu önceki konumundan 3.0f geride olacak şekilde ayarlandı ve hızı da 0.5f kat arttırıldı. Scriptte ayrıca jump isimli bir fonksiyon bulunmaktadır fakat henüz kullanılmamaktadır.

Durdurma menüsü ben tarafından geliştirildi.  Durdurma menüsü için unityde panel,butonlar ve gerekli yazılar eklendi.
PauseMenu scriptindedevam etme, durma, escape tuşuyla menüyü açma kapama fonksiyonları da ben tarafından yazıldı. Ekip arkadaşım ise yeniden başlama fonksiyonunu yazdı ve bu scriptteki fonksiyonlar unityde oluşturulan paneldeki butonlara ataması yapıldı.

<img width="500" alt="oyun5" src="https://user-images.githubusercontent.com/75726319/204600054-ab215f71-4c0f-41fe-bbba-8d2174096520.PNG">


player_sc scriptinde OnTriggerEnter fonksiyonu ekip arkadaşım tarafından yazıldı. OnTriggerEnter fonksiyonunda eğer triggerlanan cismin tag'i untagged değilse ObstacleControl fonksiyonuna gönderiliyor ve cismin tag'i ball ise cismin rengi triggerlanan cisiminki ile değiştiriliyor. Triggerlandığı cismin tag'i ground1 ya da ground2 ise yol 1 defa daha ötelenmektedir.
ObstacleControl fonksiyonu ben tarafından yazıldı. Fonksiyondaki bool isSameColor değişkeniyle  çarpışılan cisim ile oyuncunun rengi karşılaştırılmaktadır. Eğer çarpışılan cisim blok değilse ve aynı renkteyse konsola "Same Color" yazdırılır ve cismin boyutu Vector3.one/4 kadar büyümektedir ve 10 puan artmaktadır. Triggerlanan cisim bu olaydan sonra ekrandan kaybolmaktadır. Eğer triggerlanan cisim bloksa ya da tag'i ball ve cisimle farklı renkteyse canı 1 azalmaktadır, 10 puan azalmaktadır, boyutu da Vector3.one/4 kadar azalmaktadır. Tag'i ball ise triggerlanma sonucu yok olmaktadır. Eğer canı biterse ya da cismin boyutu .1f altına düşerse oyun biter ve GameOver() fonksiyonu çağrılır.
GameOver() fonksiyonu ile  endPanel gelmektedir ve oyun bitmektedir. endPanel olarak pauseMenusu gelmektedir, bu kısmı ekip arkadaşım tarafından  bağlanmıştır. Oyun bittikten sonra Devam Et butonuna tıklanınca oyun devam etmemektedir. Bu kısım daha geliştirilmemiştir.     

<img width="500" alt="oyun6" src="https://user-images.githubusercontent.com/75726319/204600727-419a3142-09b0-4c3c-a842-9be155cf5db4.PNG">

manager_sc ve gain_point_sc scriptleri ekip arkadaşım tarafından yazılmıştır.    
manager_sc scripti random konum ve sürede random olarak ürtilen nesnelerin kontrolünün sağlandığı kısımdır.          
gain_point_sc scriptinde  yol kontrolü sağlanmaktadır.


























