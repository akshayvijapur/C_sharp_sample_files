using System;


public abstract class shape {
    public int weight , height;

    public shape(int weight, int height){
        this.weight = weight;
        this.height = height;
    }

    public abstract int getArea();
}

public class  rectangle : shape {
   public rectangle(int weight, int height):base(weight,height){}

    public override int  getArea(){
        Console.WriteLine("{0}{1}",weight,height);
        return weight*height;    
    }

}

public class  triangle : shape {
   public  triangle(int weight, int height):base(weight,height){}

    public override int  getArea(){
        Console.WriteLine("{0}{1}",weight,height);
        return weight*height*2;    
    }

  

}

public class test{
    public static void Main(){
       rectangle r1 = new rectangle(10,20);
       r1.getArea();
       triangle t1 = new triangle(30,40); 
    }
}