# Unity 3D Platform Oyunu

##  Oynanış    

Oyunun genel mantığı oyun başladığı zaman cisim içinden geçtiği topun rengine göre renk ve boyut değiştirmektedir.    
Başlangıçta oyunucunun 5 tane canı bulunmaktadır.    
Eğer kendisiyle aynı renkte bir topun içinden geçerse boyutu artmaktadır.     
Farklı renkte bir  topun içinden geçerse boyutu küçülmektedir, rengi de o topun rengi olmaktadır ve ayrıca canı bir azalmaktadır.  
Oyuncunun canı sadece farklı bir topun içinden geçince azalmaktadır.
Sahnede engel olarak bloklar da bulunmaktadır.  
Tüm canların bitmesiyle oyun sonlanmaktadır.    
Arrow tuşlarıyla cisim hareket etmektedir.

5 adet script bulunmaktadır.Bunlar:   
PlayerMovement.cs     
player_sc.cs    
manager_sc.cs    
gain_point_sc.cs    
PauseMenu.cs    

PlayerMovement isimli scripti ben yazdım. Start fonksiyonu içinde cisim belli bir hızla başlatıldı. Update fonksiyonundaysa oyundaki girdiler Input.GetAxis() ile alındı. Bu şekilde arrow tuşlarıyla cisim hareket ettirilebilmektedir. Cismin platformdan dışarı çıkması durumu da incelendi ve platformumuzun boyutuna göre transform.position.x değerleri incelendi sağdan ya da soldan çıkma durumunda cismin konumu başlangıçtaki konumu olarak ayarlandı. Bu scriptte yer alan OnCollisionEnter fonksiyonunda cismin bloğa çarptıktan sonra nasıl hareket etmesi gerektiği kodlandı. İlk olarak collision olan cismin tag'i kontrol edildi eğer tag'i blok ise çarpışma sonrasında cismin konumu bloktan bir miktar geride olacak şekilde ayarlandı ve hızı da 0.5f kat arttırıldı. Scriptte ayrıca jump isimli bir fonksiyon bulunmaktadır fakat cismin useGravity özelliği kapalı olduğu için kullanılmamaktadır.     

PauseMenu scriptinde unityde panel oluşturup butonlar ve gerekli yazılar eklendikten sonra devam etme, durma, escape tuşuyla menüyü açma kapama fonksiyonlarını ben yazdım. Ekip arkadaşım ise yeniden başlama fonksiyonunu yazdı ve bu scriptteki fonksiyonlar unityde oluşturulan paneldeki butonlara ataması yapıldı.     

player_sc scrriptini ekip arkadaşımla beraber yazdık. OnTriggerEnter fonksiyonunda eğer triggerlanan cismin tag'i untagged değilse ObstacleControl fonksiyonuna gönderiliyor ve cismin tag'i ball ise cismin rengi triggerlanan cisiminki ile değiştiriliyor. Triggerlandığı cismin tag'i ground1 ya da ground2 ise yol 1 defa daha öteleniyor.        
ObstacleControl fonksiyonundaysa bool isSameColor değişkeniyle de çarpışılan cisim ile oyuncunun rengi karşılaştırılmaktadır. Eğer çarpışılan cisim blok değilse ve aynı renkteyse konsola "Same Color" yazdırılır ve cismin boyutu 0.25f (Vector3.one/4) büyümektedir ve 10 puan artmaktadır. Triggerlanan cisim bu olaydan sonra ekrandan kaybolmaktadır. Eğer triggerlanan cisim bloksa ya da tag'i ball ve cisimle farklı renkteyse canı 1 azalmaktadır, 10 puan azalmaktadır, boyutu da 0.25f azalmaktadır. Tag'i ball ise triggerlanma sonucu yok olmaktadır. Eğer canı biterse ya da cismin boyutu .1f altına düşerse oyun biter ve GameOver() fonksiyonu çağrılır.      
GameOver() fonksiyonu ile game over paneli gelmektedir ve oyun bitmektedir.      


