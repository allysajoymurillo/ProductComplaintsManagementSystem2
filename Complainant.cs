using System;

namespace ComplainantsDetails
{
   class Information : Program
   {
      static void Main(string[] args)
      {
          Complainant id = new Complainant("Joie Smith", "smith@gmail.com", "0856900212", "Businesswoman", 31);
          id.GetUserDetails();
          Console.WriteLine("Press Enter Key to Exit..");
          Console.ReadLine();
      }
   }
   public class Complainant
   {
       public string Name  { get; set; }
       public string Email  { get; set; }
       public string MobileNumber { get; set; }
       public string Occupation { get; set; }
       public int Age { get; set; }
       public Complainant(string name, string email, string mobilenumber, string occupation, int age)
       {
           Name = name;
           Email = email
           MobileNumber = mobilenumber;
           Occupation = occupation;
           Age = age;
       }
       public void GetUserDetails()
       {
           Console.WriteLine("Name: {0}, Email: {1}, MobileNumber: {2}, Occupation: {3}, Age: {4}",  Name, Email, Mobile Number, Occupation, Age);
       }
   }
}
