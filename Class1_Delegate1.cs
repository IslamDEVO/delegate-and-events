using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cSharb_console_apps
{
    /*
        CH : 3 event driven program
     */
    #region Model app
  
    //class Class1_Delegate1
    //{
    //    
    //    }
    //    static void Main(string[] args)
    //    {
    //        
    //    }
    //}
    #endregion

    #region app1
    //delegate void MyDelegate1(string str);
    //delegate void MyDelegate2(MyDelegate1 de1);

    //class Class1_Delegate1
    //{
    //    public void ShowMasseg1(string str)
    //    {
    //        Console.WriteLine("this is Delegate 1 : {0}",str);
    //    }
    //    public void ShowMasseg2(MyDelegate1 de2)
    //    {
    //        //de2 = new MyDelegate1(ShowMasseg1);
    //        Console.Write("this is Delegate 2 : "); de2("he he he");
    //        if (de2 != null)
    //            de2("process is begin");
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("test");
    //        Class1_Delegate1 c1 = new Class1_Delegate1();
    //        MyDelegate1 de1 = new MyDelegate1(c1.ShowMasseg1);
    //        MyDelegate2 de2 = new MyDelegate2(c1.ShowMasseg2);
    //        de2(de1);
    //    }
    //}
    #endregion

    #region app2
    //delegate void Calsulator(int n1, int n2);
    //class x
    //{
    //    public void sum(int x, int y)
    //    {
    //        Console.WriteLine(x + y);
    //    }
    //    public void sub(int x, int y)
    //    {
    //        Console.WriteLine(x - y);
    //    }
    //    public void mult(int x, int y)
    //    {
    //        Console.WriteLine(x * y);
    //    }
    //    public void div(int x, int y)
    //    {
    //        Console.WriteLine(x / y);
    //    }
    //}
    //class main
    //{
    //    static void Main()
    //    {
    //        //var v = 1;
    //        //v++;
    //        //Console.WriteLine("////// : {0} " ,v);
    //        x x1 = new x();
    //        Calsulator de1 = null;
    //        de1 += x1.sum;
    //        de1 += x1.sub;
    //        de1 += x1.mult;
    //        de1 += x1.div;
    //        //foreach (Delegate d in de1.GetInvocationList())
    //        Delegate[] d = new Delegate[4];
    //        d = de1.GetInvocationList();
            
    //        for(int i=3 ; i>=0 ; i--)
    //        {

    //            //string str = (string)d[i].Target;
    //            Console.WriteLine(d[i].Method);
    //            //Console.Write(d.Method);
    //            //Console.Write("\t" + d.Target + "\n");
    //        }

    //        //de1(5, 5);
    //        // Console.WriteLine("--------------------");
    //        //de1 -= x1.sum;
    //        //de1(5, 5);
    //    }
    //}

    #endregion

    #region app3

    //class test
    //{
    //    public int s = 10;
    //    public delegate int Change(int x);

    //    public void DoChange(int w, Change de)
    //    {
    //        int z = de(w);
    //        Console.WriteLine(z);
    //    }
    //    public int Add(int n)
    //    {
    //        return (s + n);
    //    }
    //    public int Mult(int n)
    //    {
    //        return (s * n);
    //    }
    //    static void Main(string[] args)
    //    {
    //        test t1 = new test();
    //        t1.DoChange(5, new Change(t1.Add));
    //        t1.DoChange(5, t1.Mult);
    //    }
    //}
    #endregion

    #region Anonymous methods

    //class Class1_Delegate1
    //{
    //    public delegate void showMassege();
    //    public delegate int showMassege2(int x);

    //    static void Main(string[] args)
    //    {
    //        showMassege de = delegate() { Console.WriteLine("Anonymous methods 1"); };
    //        de += delegate() { Console.WriteLine("Anonymous methods 2"); };
    //        showMassege2 de2 = delegate(int x) { return x; };
    //        de();
    //        Console.WriteLine(de2(5));
    //    }
    //}
    #endregion

    #region Lambda methods

    //class Class1_Delegate1
    //{
    //    public delegate void ShowMassege();
    //    public delegate int ShowMassege2(int x);
    //    public delegate int ShowMassege3(int x , int y);

    //    static void Main(string[] args)
    //    {
    //        //ShowMassege de1 = () => Console.WriteLine("Lambda methods 1");
    //        //de1 += () => Console.WriteLine("Lambda methods 2");
    //        //de1();
    //        //ShowMassege2 de2 = x => { return x; };
    //        //Console.WriteLine(de2(5));
    //        ShowMassege3 de3 = (x,y) => { return x*y; };
    //        Console.WriteLine(de3(5,5));
    //    }
    //}
    #endregion

    #region Func && Action (Delegate)

    //class Class1_Delegate1
    //{
    //    public Func<string, int> ConvertToInt = x => { return int.Parse(x); };
    //    public Func<int, string> ConvertToString = delegate(int x) { return "string "+x; };
    //    public Func<string> ShowString = FuncDelegate;
    //    public Action<int> ShowAction = x => { Console.WriteLine("Action Delegate : {0}",x); };
    //    public Action<int, int> ShowMult = delegate(int x, int y) { Console.WriteLine(x*y); };

    //    public static string FuncDelegate()
    //    {
    //        return " Func Delegate ";
    //        //Console.WriteLine(" Func Delegate ");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Class1_Delegate1 c1 = new Class1_Delegate1();
    //        Console.WriteLine(c1.ConvertToInt("3"));
    //        Console.WriteLine(c1.ConvertToString(4));
    //        Console.WriteLine(c1.ShowString());
    //        c1.ShowAction(5);
    //        c1.ShowMult(5, 6);
            
    //    }
    //}
    #endregion

    #region Extention Methods

    //static class Extention_methods
    //{
    //    public static void ToHex(this int x)
    //    {
    //        //return "";
    //        Console.WriteLine("Ox{0:X}", x);
    //    }

    //}

    //class Class1_Delegate1
    //{
        
    //    static void Main(string[] args)
    //    {
    //        int x = 5;
    //        x = 22;
    //        //ToHex();
    //        x.ToHex();
    //    }
    //}
    #endregion

    #region bubble sort algorithm

    //delegate bool MyComparable(object lhs , object rhs);

    //class Compare_employee_salary
    //{
    //    public bool RIsGraterDelegate(object lhs, object rhs)
    //    {
    //        Employee empLhs = (Employee)lhs;
    //        Employee empRhs = (Employee)rhs;
    //        return((empRhs.salary > empLhs.salary) ? true : false );
    //    }
    //}

    //class Employee
    //{
    //    public string name { get; set; }
    //    public int salary { get; set; }

    //    public Employee(string name, int salary)
    //    {
    //        this.name = name;
    //        this.salary = salary;
    //    }

    //    public void sort(object[] objs, MyComparable RIsGrater)
    //    {
    //        Employee empLhs;
    //        Employee empRhs;
    //        for (int i = 0; i < objs.Length; i++)
    //        {
    //            for (int j = i + 1; j < objs.Length; j++)
    //            {
    //                if(RIsGrater(objs[i],objs[j]))
    //                {
    //                    object temp = objs[i];
    //                    objs[i] = objs[j];
    //                    objs[j] = temp;
    //                }
    //            }
    //        }
    //    }

    //}

    //class Class1_Delegate1
    //{
       
     
    //    static void Main(string[] args)
    //    {
    //        Compare_employee_salary c1 = new Compare_employee_salary();
    //        MyComparable RIsGrater = c1.RIsGraterDelegate;
    //        object[] emps = { new Employee("ali", 500), new Employee("ahmed", 400), new Employee("omr", 600) };
    //        ((Employee)emps[1]).sort(emps, RIsGrater);
    //        for (int i = 0; i < emps.Length; i++)
    //            Console.WriteLine(((Employee)emps[i]).salary);
    //    }
    //}
    #endregion

    #region Events app

    //class Anothor_class
    //{
    //    public void ShowMassegEvent()
    //    {
    //        Console.WriteLine("--------event is fired from Anothor class---------");
    //    }
    //}

    //class Add_class
    //    {
    //        public delegate void MyDelegate();
    //        public event MyDelegate MyEvent;
    //        public void ShowMassegEvent()
    //        {
    //            Console.WriteLine("--------event is fired---------");
    //        }
    //        public void Add()
    //        {
    //            int result = 5 + 4;
    //            if (result % 2 != 0 && MyEvent != null)
    //            {
    //                MyEvent.Invoke();
    //            }
    //        }
    //    }
    //class Class1_Delegate1
    //{
       
    //    static void Main(string[] args)
    //    {
    //        Add_class c1 = new Add_class();
    //        Anothor_class c2 = new Anothor_class();
    //        //c1.MyDelegate de = c1.ShowMassegEvent;
    //        c1.MyEvent += new Add_class.MyDelegate(c1.ShowMassegEvent);
    //        c1.MyEvent += new Add_class.MyDelegate(c2.ShowMassegEvent);
    //        c1.Add();
          
    //    }
    //}
    #endregion

    #region TickHandler app

    
    //public class Asd
    //{
    //    delegate void MyDelegate(object sender, EventArgs e);
    //    public event MyDelegate MyEvent;
    //    EventArgs e = EventArgs.Empty;
    //    public void start()
    //    {
    //        while (true)
    //        {
    //            System.Threading.Thread.Sleep(1000);
    //            MyEvent.Invoke(this, e);
    //        }
    //    } 

    //}

    //class Class1_Delegate1
    //{
    //    public void TickHandler(object sender, EventArgs e)
    //    {
    //        Console.WriteLine("Heard it");
    //    }
        
    //    static void Main(string[] args)
    //    {
    //        Asd c1 = new Asd();
    //        c1.MyEvent += new c1.MyDelegate(Class1_Delegate1.Ti);
    //    }
    //}
  

    //class Class1_Delegate1
    //{
    //    delegate void MyDelegate(object sender, EventArgs e);
    //    event MyDelegate MyEvent;
    //    static int n = 1;
    //    public static void showMassegeEvent(object sender, EventArgs e)
    //    {
    //        Console.WriteLine("--------event is fired {0}------------", n++);
    //    }

    //    static void Main(string[] args)
    //    {
    //        EventArgs e = EventArgs.Empty;
    //        Class1_Delegate1 c1 = new Class1_Delegate1();
    //        c1.MyEvent +=new MyDelegate(showMassegeEvent);
    //        while (true)
    //        {
    //            System.Threading.Thread.Sleep(1000);
    //            if (c1.MyEvent != null)
    //            {
    //                c1.MyEvent.Invoke(c1, e);
    //            }
    //        }
    //    }
    //}
    #endregion

    #region Events with Anonmose methods && lambda app

    
    //class Class1_Delegate1
    //{
    //    public event EventHandler MyEvent;
    //    static void Main(string[] args)
    //    {
    //        Class1_Delegate1 c1 = new Class1_Delegate1();
    //        c1.MyEvent += (o, e) => { Console.WriteLine("---C# built in delegate-------"); };
    //        c1.MyEvent += delegate(object o, EventArgs e)
    //        { 
    //            Console.WriteLine("---C# built in delegate-------"); 
    //        };
    //        c1.MyEvent.Invoke(c1, new EventArgs());
    //    }
    //}
    #endregion

}