using System;



public delegate void closeDBConnection();

public class testEventClass {

 event closeDBConnection closeEvent;

public testEventClass(){
    closeEvent += new closeDBConnection(closeConnection);
}

public  void closeConnection(){
    Console.WriteLine("Closing Connection ");
}
    public static void Main(){
testEventClass t1 = new testEventClass();
t1.closeEvent();
    }
}