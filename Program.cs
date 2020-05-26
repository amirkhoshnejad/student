using System;
using System.Collections.Generic;

namespace student{
    class Program {
        static void Main(string[] args){
            Dictionary<string,string> EmployeeList=new Dictionary<string, string>(){
            {"name",null},{"age",null},{"weight",null},{"height",null}};
            string[] student =System.IO.File.ReadAllLines(@"E:\projects\C#_Project\csharp\student\studentProfile.txt");
            int num = Int32.Parse(student[0]),n =num*4;
            var array = new List<studentNames>();
            for (int k = 1; k <=n; k++){
                string[] autherList=student[k].Split(":");
                if (autherList[0]=="name"){
                    student[k]=autherList[1];
                }
                if (autherList[0]=="age"){
                    student[k]=autherList[1];
                }
                if (autherList[0]=="weight"){
                    student[k]=autherList[1];
                }
                if (autherList[0]=="height"){
                    student[k]=autherList[1];
                }
            }
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
