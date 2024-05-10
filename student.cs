using System;
namespace Weekend
{
class Student{
public static void Main(string[]args)
{
int a=0;
int sum=0;
int[] arr=new int[10];

do{
Console.WriteLine("enter the marks of 10 student {0}",a+1);
arr[a]=Convert.ToInt32(Console.ReadLine());
sum=sum+arr[a]

a++;

}
while(a<arr.Length);

Console.WriteLine("marks of 10 student: ");
for(int i=0;i<10,i++){
Console.WriteLine("Student {} and {}",);
}
sum=sum+arr[a];
a++;
}
while(a<arr.Length);
Console.WriteLine("the average marks of the student is {0}",sum/10);
}
}
}
