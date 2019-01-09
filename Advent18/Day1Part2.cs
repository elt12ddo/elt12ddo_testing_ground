using System;
using System.Collections.Generic;

namespace Advent{

    public class Day1Part2{

        public void findFreq(){
                string[] lines = System.IO.File.ReadAllLines(@"D:\Gitrepos\Testing_ground\elt12ddo_testing_ground\Advent18\data1.txt");

                char add = '+';
                char subtract = '-';
                string[] temp = lines[0].Split(',');
                double sum = 0;
                HashSet<double> set = new HashSet<double>();
                bool done = false;

                    while(!done){
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

                            if(!set.Add(sum)){
                                    done = true;
                                    break;
                                }

                        }
                    }
                    Console.WriteLine("First freq found twice: "+ sum);
        }

    }
}