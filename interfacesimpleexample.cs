using System;

public  interface ilogger {
     void LogMessages(string message);
}

public class FileLogger : ilogger{
    public void LogMessages(string message){
     Console.WriteLine("File logger {0}",message);
    }
}

public class DBLogger: ilogger{
    public void LogMessages(string message){
         Console.WriteLine("Db logger {0}",message);
    }
}

public class ExceptionHandler {
    ilogger log;
   public  ExceptionHandler(ilogger log){
        this.log = log;
    }

public void handleExceptions(string messages){
log.LogMessages(messages);
}


   public static void Main(){
    ExceptionHandler ex = new ExceptionHandler(new DBLogger() );
    ex.handleExceptions("hello");
    
    ExceptionHandler fileex = new ExceptionHandler(new FileLogger() );
    fileex.handleExceptions("hello");
   } 
}

