using System;
public class ThreadProgram { 
    public void Hello()
    {
        for(int i = 0; i < 5; i++)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Hello");   
        }

    }
    public void Hi()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Hi");
        }
    }
public static void Main(string[] args) { 
      
        ThreadProgram obj = new ThreadProgram();

        Thread thread = new Thread(obj.Hi);
        thread.Start();

        Thread t = new Thread(obj.Hello);
        t.Start();
        t.Join();

        Thread name = Thread.CurrentThread;
        name.Name = "MainThread";
        Console.WriteLine(name.Name);
       

        
    }
}