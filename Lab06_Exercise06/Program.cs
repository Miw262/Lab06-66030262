﻿var student = (firstname: "Panya", Lastname: "Siri", id: 65031234); 
// เปลี่ยน fname, lname และ id ให้เป็นข้อมูลของนักศึกษาเอง

System.Console.WriteLine(
@$"First name: {student.firstname} 
Last name: {student.Lastname} 
ID: {student.id}");

int x = 3;
int y = 4;
System.Console.WriteLine($"""Distance from origin to the point ({x},{y}) is {Math.Sqrt(x * x + y * y)}""");

System.Console.WriteLine("\n\nMethod to show { and } in string");
System.Console.WriteLine($"""Distance from origin to the point ({x},{y}) is {Math.Sqrt(x * x + y * y)}""");
