
using T2203E_CSharp.ss1;
using T2203E_CSharp.ss2;

public class Program
{
    static void Main(string[] args)
    {
        Human h = new Human();
        h.run();
        Human hbt= new Human();
        hbt.run();
        h.Age = 22;
        h.Email = "hbt@gmail.com";
        Console.WriteLine(h.Age);
        Student st= new Student();
        st[0] = "0123456789";
        st[1] = "0123654789";
        List<string> list= new List<string>();
        list.Add("hi");
        list.Add("w");
        list.Add("night");

        for(int i=0; i<list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        foreach(string s in list)
        {
            Console.WriteLine(s);
        }
    }
}