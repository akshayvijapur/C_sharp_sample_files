using System;

public delegate void  printMesage(string message);


public class test {

    public  string message ;
    public void printStartMessage(string message){
       Console.WriteLine("hello  {0}",message);
      
    } 

    public void printEndMessages(string message){
       Console.WriteLine("END  {0}",message);
      
    }


 public void showmessage(){
       Console.WriteLine("{0}",message);
    }
    public static void Main(){

        test t1 = new test();
        printMesage start = new printMesage(t1.printStartMessage);
        printMesage end = new printMesage(t1.printEndMessages);
        start("Akshay");
        end("AKshay");
        t1.showmessage();
    }
}