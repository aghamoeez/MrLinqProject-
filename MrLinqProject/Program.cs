using System;
using System.Collections.Generic;
using System.Linq;

List<int> data = new List<int>(){1,2,3,4,5,6,7,8,9,10 };




Console.WriteLine("************Query syntax**********");
var Querysyntax = from nextDoorCoder in data
                  where nextDoorCoder > 3
                  select nextDoorCoder;

foreach (var item  in Querysyntax)
{

    Console.WriteLine(item);
}

Console.WriteLine("***********method Syntax***********");
var methodSyntax = data.Where(methodData => methodData > 3);

foreach (var item in methodSyntax)
{

    Console.WriteLine(item);
}



Console.WriteLine("************Mixed syntax**********");
var mixedSyntax = (from nextDoorCoder in data
                  select nextDoorCoder).Where(c=> c > 3);

foreach (var item in mixedSyntax)
{

    Console.WriteLine(item);
}








