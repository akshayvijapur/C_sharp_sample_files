// Interfaces are the methods which are defined in base class and implemented in derived class.
//They can be used as alternative soln to derived class.
// interfaces is like class. where you define like class,  does not have ny defination.
using System;

public class baseclass {
    protected int height,weight;

    protected baseclass(int w,int h){
        height=h;
        weight=w;
    }}

    public interface  Cost {
        int getCost(); //we cannot define
}


public class  rectangle:baseclass,Cost{
    rectangle(int w,int h): base(w,h) {}

   public  int getCost(){
       try{

       
       Console.WriteLine("{0}{1}",height,weight);
       }catch(Exception e){

       }finally{

       }
        return height*weight;
    }

    public static void Main(){
    rectangle r1  = new rectangle(10,20);
    r1.getCost();
    }
    

}

// This is the way to create a user defined exception.
public class myexception :Exception{
    myexception(string message):base (message){};
}