using System;

namespace ProductComplaintsManagementSystem
{
   class Program
   {
  
      static void Main(string[] args)
      {
  
            Console.WriteLine("==========WELCOME TO PRODUCT COMPLAINTS MANAGEMENT SYSTEM==========");

            Console.Write("Enter  your Full Name: ");
            string complainantName = Console.ReadLine();
            Console.WriteLine(complainantName);

            Console.Write("Enter  your Mobile Number: ");
            string cellphoneNumber = Console.ReadLine();
            Console.WriteLine(cellphoneNumber);
            Console.Write("Enter  your Email: ");

            string complainantEmail = Console.ReadLine();
            Console.WriteLine(complainantEmail);

            Console.Write("Enter  your Complain: ");
            string productComplaint = Console.ReadLine();
            Console.WriteLine("Complaint: " +productComplaint);
            
            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine();
            Console.WriteLine("Brand: " +productName);            
            
            Console.Write("Enter Product Scent: ");
            string productScent = Console.ReadLine();
            Console.WriteLine("Name: " +productScent);
            
            Console.Write("Enter Product Code: ");
            string productCode = Console.ReadLine();
            Console.WriteLine("Code: " +productCode);
            
            Console.Write("Enter Product Mass: ");
            string productMass = Console.ReadLine();
            Console.WriteLine("Mass: " +productMass);

            DateTime complainatDateAdded = new DateTime(2021, 06, 15);
            Console.WriteLine("Date Added: " + complainatDateAdded.ToShortDateString());
            Console.WriteLine("Your Complaint is Successfully added! ");
        }
     }  
}
     
                
