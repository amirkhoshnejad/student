using System;
using System.Collections.Generic;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student =System.IO.File.ReadAllLines(@"E:\projects\C#_Project\csharp\student\studentProfile.txt");
            int num=0;
            int n=10;
            var array = new List<studentNames>();
            for (int i = 0; i < n; i++)
            {
                var w =new studentNames();
                w.name="amir";
                w.age="24";
                w.weight="80";
                w.height="190";
                array.Add(new studentNames());
            }
        }
    }
}
