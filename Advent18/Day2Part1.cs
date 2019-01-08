using System;
using System.Collections.Generic;

namespace Advent{

    public class Day2Part1{

        public void findChecksum(){
            string[] lines = System.IO.File.ReadAllLines(@"D:\Gitrepos\Testing_ground\elt12ddo_testing_ground\Advent18\data2.txt");
            int twos = 0;
            int threes = 0;
            Dictionary<char, int> counter;

            foreach(string line in lines){
                counter = new Dictionary<char, int>();
                foreach(char character in line){
                    if(counter.ContainsKey(character)){
                        int currentVal;
                        counter.TryGetValue(character, out currentVal);
                        currentVal++;
                        counter.Remove(character);
                        counter.Add(character,currentVal);
                    }else{
                        counter.Add(character,1);
                    }

                }

                if(counter.ContainsValue(2)){
                    twos++;
                }
                if(counter.ContainsValue(3)){
                    threes++;
                }
            }
            int Csum = twos * threes;
            Console.WriteLine("The checksum is: " + Csum);

    }
}
}