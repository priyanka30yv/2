using System;
namespace Weekened
{
class Customer
{
private string custname;
private string email;
private int age;

public Customer()
{
custname="priyanka";
email="peiyanak@gmail.com";
age=12;
}
internal Customer(string a,string b,int c)
{ 
custname=a;
email=b;
age=c;

}
internal void AcceptData()
{
Console.WriteLine("the customer name is {0} and email is {1} and age is {2}",custname,email,age);
}
internal void displayData()
{
Console.WriteLine("the customer name is {0} and email is {1} and age is {2}",custname,email,age);
}
}
public class Communication
{
public static void Main(string[] args)
{
Customer obj1=new Customer("priyanka","priyanka@gmail.com",14);
Customer obj2=new Customer();
obj1.displayData();
obj2.AcceptData();


}
}
}
