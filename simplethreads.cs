using System;
using System.Threading;

public class threadtest {

    public static void GetDataFromDB(){
        Console.WriteLine("Storing from DB ");
    }

    public static void Main(){
        //threadtest t1 = new threadtest();

        ThreadStart start = new ThreadStart(GetDataFromDB);
        Thread one = new Thread(start);
        Thread two = new Thread(start);
        one.Start();
        two.Start();
        //one.Abort();
        //two.Abort();
        
    }
}