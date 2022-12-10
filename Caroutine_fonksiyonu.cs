using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caroutine_fonksiyonu : MonoBehaviour
{/*
    CAROUTİNE

    1-Bir fonksiyonu, belli bir saniye sonra 1 kez çalıştırabiliriz(Invoke() gibi)

    2-Bir fonksiyonu,belli saniyeler aralığında sürekli çalıştırabilir(InvokeRepeating() gibi)

    3-Belli bir saniye sonra 1 kez veya belli bir saniye aralığında sürekli çalışan "değer alabilen" bir fonksiyonu çalıştırabilir
    4-İnternetten,bir klasörden,veri tabanından veya dosyadan veri çekmek gibi bir iş yaparken, işin bitmesini bekleyebilir.ilgili fonksiyonun çalışmasını 
    ona göre düzenleyebilir


    not: caroutine fonksiyonları ;
    1- fonksiyonları tanımlanırken, IEnumarator türünden değer döndürdüklerinden, isimlerinde mutlaka IEnumarator ifadesi olmak zorundadır
    2- StartCaroutine (fonksiyonu()) koduyla çalıştırılır,StopCaroutine(fonksiyonu()) koduyla durdurulur
   


}
