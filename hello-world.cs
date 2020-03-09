using System;
using System.Collections;


namespace hello {
    
    struct books {
        private int price;
        private string author;
        
        public void getBook(int price_of_book, string author_of_book){
            price = price_of_book;
            author = author_of_book;
            Console.WriteLine("{0}{1}", price, author);
        }
    }
     
    enum daysofweek {sun, mon};
    
    public class Employee {
        
        private int emp_num;
        private int emp_salary;
        private string emp_name;
        public const int test = 100;
        internal int internal1;
        public int public1;
        protected string[] hobbies;
        books csharp = new books();
        
        public Employee(int num, int salary, string name){
            emp_name= name;
            emp_salary = salary;
            emp_num=num;
            csharp.getBook(20,"aks");
        }
        
        public void show_details(){
            Console.WriteLine("Employee name {0}",emp_name );
            Console.WriteLine("Employee Num {0}",emp_num );
            Console.WriteLine("Employee salary {0}",emp_salary );
        }
        
        
        public void swamNumber(ref int a, ref int b, out int sum){
            int temp = a;
            a = b;
            b = temp;
            sum = a+b;
        }
        
        public void addHobies(){
            hobbies = new string[3];
            hobbies[0] = "akshay";
            hobbies[1] = "ram";
            hobbies[2] = "kishore";
            
            Console.WriteLine("{0}{1}{2}", hobbies[0],hobbies[1],hobbies[2]);
            
            foreach (string element in hobbies) {
                Console.WriteLine(element);
            }
        }
        
        //params : if you dont know how many numbe of parametsrs you are oassing
        
        public int testparams(params int[] arr){
            int count =0;
            foreach (int elemens in arr){
                count = count+elemens;
            }
            return count;
        }
        public  static void Main(){
             
            Employee e1 = new Employee(10,10000,"akshay");
            e1.show_details();
            
            
            object obk = 10;
            Console.WriteLine("object {0}",obk );
            
            dynamic a1 =10;
            
            Console.WriteLine("object {0}",a1 );
            
            e1.internal1 = 100;
            e1.public1 = 100;
            
           Console.WriteLine("object {0}",e1.internal1 );
            Console.WriteLine("object {0}",e1.public1 );
            
            int a =10, b = 20, c;
            
            e1.swamNumber(ref a,ref b, out c);
              Console.WriteLine("object {0}",a );
              Console.WriteLine("object {0}",b );
                  Console.WriteLine("object {0}",c );
                  
                  e1.addHobies();
                  
            int sum  = e1. testparams(10,20,30,40);
            Console.WriteLine("{0}", sum);
            
        }
        
    }
    
    
}