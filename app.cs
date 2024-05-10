using System;
namespace sunday
{
class app{
private int id;
private string info;
public  app()
{
id=102;
info="hiii";
}
internal app(int a,string b)
{
id=a;
info=b;
}
internal void display(){
Console.WriteLine(id);
Console.WriteLine(info);
}
}
class driver 
{
public static void Main(string[]args){
app obj=new app();
obj.display();
app obj1=new app(101,"this s");
obj1.display();
}
}
}