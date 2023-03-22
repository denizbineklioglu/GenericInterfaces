using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaces
{
    /*
        Contravariant: Generic Interfacelerin parametresinde verilen
        entity tipi için önüne in anahtar kelimesini koyarsak,
        bu tipi sadece parametre olarak geçebileceğimiz anlamına gelir.
        
        Yani 20. satır burada hata verecektir.
     */

    interface IContravariant<in T>
    {
        void Insert(T t);
        //T GetById(int id);
    }
}
