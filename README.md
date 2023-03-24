
## Generic Interfacelerde Covariant ve Contravariant

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
yazacağımız metotlarda sadece parametre olarak geçebileceğimizdir.

```
public interface IContravariant<in T>{

  //T GetById(int id); Bu satır hata verir.
  void Insert(T t);

}
```
Sadece parametre olarak kullanabileceğimiz için ``` GetById ``` metodu hata verecektir. <br>
Bu hatanın açıklaması ise, T'nin dönüş tipi olarak kullanılabilmesi için ``` covartiant ``` olması gerektiği ama T'nin şu anda ``` contravariant ``` olduğudur.

## Covariant 
Eğer ki Generic Interface'imizin parametresinin önüne ``` out ``` anahtar kelimesini yazarsak, bu parametreyi <br>
sadece yazacağımız metotlarda dönüş tipi olarak geçebileceğimiz anlamına gelir.

```
public interface ICovariant<out T>{
  
  T GetById(int id);
  //void Insert(T t); Hata verir.
  
}
```
Sadece dönüş tipi olarak kullanabileceğimiz için ``` Insert ``` metodunda hata alırız. <br>
Bu hatanın açıklaması ise, T'nin parametre olarak kullanılabilmesi için ``` contravariant ``` olması gerektiği ama T'nin şu anda ``` covariant ``` olduğudur.


## Farklı Örnekler

<li>İki Farklı parametre ile</li><br>

```
interface IGenericRepository<out T,in Z>{
   
  void Update(Z z);
  T GetSomething(Z z);
  
}
```
Bu örnekte Generic Interface'te iki farklı tür parametre geçilmiş. T sadece dönüş tipi olarak kullanılabilirken, Z sadece parametre olarak kullanılabilir.<br>
<br>

<li>Class Üzerinden</li><br>

```
  public class Computer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
```
Bir Computer class'ı oluşturduk ve bu class ile ilgili işlemleri yapacak bir ``` ComputerManager ``` class'ı oluşturalım.

```
public class ComputerManager : IContravariant<Computer>,ICovariant<Computer> 
    {
        public Computer GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Computer t)
        {
            throw new NotImplementedException();
        }
    }
```
Managera önceden oluşturduğumuz interfaceleri implement ettim. Böylelikle Computer class hem parametre hem de dönüş tipi olarak kullanıldı.

```
Computer computer = new()
{
    ID = 1,
    Name = "Monster"
};

ComputerManager cm = new();
cm.Insert(computer);
Computer c = cm.GetByID(computer.ID);
```



