using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaces
{
    /*
        Covariant: Generic Interfacelerin parametresinde verilen
        entity tipi için önüne out anahtar kelimesini koyarsak,
        bu tipi sadece dönüş değeri olarak geçebileceğimiz anlamına gelir.
        Eğer ki 20. satırdaki gibi parametre olarak kullanmaya çalışırsak
        hata verecektir.
     */

    public interface ICovariant<out T>
    {
        T GetByID(int id);
        //void Insert(T t);
    }
}
