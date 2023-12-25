using Domain.Models;
namespace Infrastructure.Servise;

public class Servise
{
   List<Employe> e1 = new List<Employe>() ;
   public List<Employe> GetEmployes(){
    return e1;
   }
   public void AddEmployes(Employe employe){
      e1.Add(employe);
   }
   public int CountEmployes(){
     int cnt = 0;
     foreach (var item in this.e1)
     {
        cnt ++;
        return cnt;
     }
     return cnt;
   }
   public string UpdateEmploye(Employe employe){
    foreach (var item in this.e1)
    {
        if(item.id == employe.id){
            item.firstName = employe.firstName;
            item.lastName = employe.lastName;
            item.age = employe.age;
            return "Employe succesefully updated";
        }
    }
    return "Employe not found";
   }
   public string DeleteEmploye(int id){
    foreach (var item in this.e1)
    {
        if(item.id == id){
           this.e1.Remove(item);
            return "Employe succesefully deleted";
        }
    }
    return "Employe not found";
   }
   
}
