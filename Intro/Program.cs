// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

// C# da isimlendirme kurallarında variables (değişkenler) camelCase yazılırlar.

// CourseManager courseManager = new (); // CourseManager() ile aynı...

CourseManager courseManager = new(new CourseDal());

List<Course> courses = courseManager.GetAll();
// for (int i = 0; i < courses.Length; i++)
for (int i = 0; i < courses.Count; i++)
{

    Console.WriteLine(courses[i].Name);
}

IndividualCustomer customer1 = new IndividualCustomer() 
{ Id=1, NationalIdentity= "12345678912", FirstName= "Aslı", LastName= "Karayiğit", CustomerNumber= "123456" };

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "5678912";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

BaseCustomer[] customers = {customer1, customer2, customer3, customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}



