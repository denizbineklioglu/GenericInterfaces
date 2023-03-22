
<h1>Generic Interfacelerde Covariant ve Contravariant Kavramları</h1>

Örnek bir Interface
```
interface IGeneric<T>{

}
```
Bu Interface'imiz parametre olarak T entitysini geçiyor ve önüne herhangi bir ``` out ``` veya ``` in ``` anahtar kelimesi almamış.<br>
Bu şekildeyken T'yi hem parametre olarak hem de dönüş tipi olarak kullanabiliriz.

```
interface IGeneric<T>{

  T GetById(int id);
  void Insert(T t);

}
```

## Contravariant 
Eğer ki Generic Interface'imizin parametresinin önüne ``` in ``` anahtar kelimesi gelirse, bunun anlamı onu <br>
yazacağımız metotlarda sadece parametre olarak geçebileceğimiz anlamına gelir.

```
interface IContravariant<in T>{

  //T GetById(int id); Bu satır hata verir.
  void Insert(T t);

}
```
Sadece parametre olarak kullanabileceğimiz için ``` GetById ``` metotdu hata verecektir. <br>
Bu hatanın açıklaması ise, T'nin dönüş tipi olarak kullanılabilmesi için ``` covartiant ``` olması gerektiği ama T'nin şu anda ``` contravariant ``` olduğudur.

## Covariant 
Eğer ki Generic Interface'imizin parametresinin önüne ``` out ``` anahtar kelimesini yazarsak, bu parametreyi <br>
sadece yazacağımız metotlarda dönüş tipi olarak geçebileceğimiz anlamına gelir.

```
interface ICovariant<out T>{
  
  T GetById(int id);
  //void Insert(T t); Hata verir.
  
}
```
Sadece dönüş tipi olarak kullanabileceğimiz için ``` Insert ``` metotdunda hata alırız. <br>
Bu hatanın açıklaması ise, T'nin parametre olarak kullanılabilmesi için ``` contravariant ``` olması gerektiği ama T'nin şu anda ``` covariant ``` olduğudur.


## Farklı Örnekler

```
interface IGenericRepository<out T,in Z>{
   
  void Update(Z z);
  T GetSomething(Z z);
  
}
```

Bu örnekte Generic Interface'te iki farklı tür parametre geçilmiş. T sadece dönüş tipi olarak kullanılabilirken, Z sadece parametre olarak kullanılabilir.





