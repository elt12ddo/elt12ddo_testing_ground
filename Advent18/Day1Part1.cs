using System;

namespace Advent{

    public class Day1Part1{

        public void findValue(){
                string[] lines = System.IO.File.ReadAllLines(@"D:\Gitrepos\Testing_ground\elt12ddo_testing_ground\Advent18\data1.txt");

                char add = '+';
                char subtract = '-';

                    string[] temp = lines[0].Split(',');
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
        }

    }
}