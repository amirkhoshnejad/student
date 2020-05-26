using System;
using System.Collections.Generic;

namespace student{
    class Program {
        static void Main(string[] args){
            string[] student =System.IO.File.ReadAllLines(@"E:\projects\C#_Project\csharp\student\studentProfile.txt");
            int num = Int32.Parse(student[0]),n =num*4;
            var array = new List<studentNames>();
            for (int i = 0,j=1; i <= num &&  j<=n; i++){
                array.Add(new studentNames());
                array[i].name=student[j++];
                array[i].age=student[j++];
                array[i].weight=student[j++];
                array[i].height=student[j++];
            }
        }
    }
}
