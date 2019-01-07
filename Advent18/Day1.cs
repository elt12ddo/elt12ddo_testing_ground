using System;

namespace Day1{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Gitrepos\Testing_ground\elt12ddo_testing_ground\Advent18\data.txt");

            char add = '+';
            char subtract = '-';

            foreach(string line in lines){
                string[] temp = line.Split(',');
                double sum = 0;
                foreach(string temp2 in temp){
                    char sign = temp2.Trim()[0];
                    double val = Convert.ToDouble(temp2.Trim().Substring(1));
                    if(sign == add){
                        sum = sum + val;
                    }else if(sign == subtract){
                        sum = sum - val;
                    }else{
                        Console.WriteLine("ERROR!");
                    }

                }
                Console.WriteLine("Result: "+ sum);
                sum = 0;
            }
        }
    }
}