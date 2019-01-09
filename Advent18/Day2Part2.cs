using System;

namespace Advent{

    public class Day2Part2{

        public void findCommonText(){
            string[] lines = System.IO.File.ReadAllLines(@"D:\Gitrepos\Testing_ground\elt12ddo_testing_ground\Advent18\data2.txt");
            bool done = false;

            for(int i = 0; i < lines.Length; i++){
                string line = lines[i];
                for(int j = i+1; j < lines.Length; j++){
                    string testString = lines[j];
                    bool once = false;
                    bool Notcorrect = false;
                    int index = 0;
                    for(int k = 0; k < testString.Length; k++){
                        if(line[k] != testString[k] && !once){
                            index = k;
                            once = true;
                        }else if(once && line[k] != testString[k]){
                            Notcorrect = true;
                            break;
                        }

                    }
                    if(!Notcorrect){
                        Console.WriteLine("Found: " + line + " and " + testString);
                        Console.WriteLine("Without differing char: " + line.Substring(0,index) + line.Substring(index+1));
                        done = true;
                        break;
                    }

                }
                if(done){
                    break;
                }

            }

    }
}
}