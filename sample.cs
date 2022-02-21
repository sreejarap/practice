using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    //string h;
    string temp;
    string strOne = "java is the only lang";
    string[] strArrayOne = new string[] {""};

    strArrayOne = strOne.Split(' ');
   
    if((strArrayOne.Length) % 2 == 0){
       for (int k = 0; k < strArrayOne.Length / 2; k++) { // Here!
           temp = strArrayOne[k];
           strArrayOne[k]  = strArrayOne[strArrayOne.Length - 1 - k];
           strArrayOne[strArrayOne.Length - 1 - k] = temp;
     
        }
    }
    else{
        for (int m = 0; m < (strArrayOne.Length / 2) + 1; m++){
                 if(m == ((strArrayOne.Length)/2) ){
                    string str = strArrayOne[m];
                    char[] chars = str.ToCharArray();  
                    for (int i = 0, j = str.Length - 1; i < j; i++, j--) {  
                        chars[i] = str[j];  
                        chars[j] = str[i];
                        //Console.WriteLine(chars);
                        string s = new string(chars);
                       
                       strArrayOne[m] = s;
                        //Console.WriteLine(ar);
                       
                    }
                }
                else{
                    temp = strArrayOne[m];
                    strArrayOne[m]  = strArrayOne[strArrayOne.Length - 1 - m];
                    strArrayOne[strArrayOne.Length - 1 - m] = temp;
                }
                   
               
           
        }
       
       
       
    }
   
    if(strArrayOne.Length == 1){
        Console.WriteLine(strOne);
    }
    else{
    Console.WriteLine(string.Join(" ", strArrayOne));
    }
     
    }
   
   
   
}
