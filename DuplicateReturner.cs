using System;
using System.Collections.Generic;
using System.Linq;

class DuplicateReturner {
  static void Main() {
    Console.WriteLine(returnDuplicates("improper"));
  }
  
  public static string returnDuplicates(string my_input){
    
    Dictionary<char, int> dict = new Dictionary<char, int>();
    
    
    foreach (char c in my_input){
        if (!dict.ContainsKey(c)){
            dict.Add(c, 1);
        }
        else {
            dict[c] += 1; 
        }
    }
    
    string s = "";
    foreach (KeyValuePair<char,int> kvp in dict){
        if (kvp.Value > 1){
            s += kvp.Key;
        }
    }
    
    return s;
  }
}
