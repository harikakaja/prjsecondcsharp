using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
    class Out_ParametersEg
    {
        void calculation(float n1,float n2,int l,out int c,out float s,out float p)
        {
            s = n1 + n2;
            p = n1 + n2;
            c = l + 2 * 4;
        }
        void studenrdetails(string name,params string[] hobbies)
        {
            Console.WriteLine("name:{0}",name);
            for (int i=0;i<hobbies.Length;i++)
            {
                Console.WriteLine(hobbies[i]);
            }
        }
        static void Main()
        {
            float num1 = 10, num2 = 60, sum = 0, product = 0;
            int length = 10, cal = 0;
            Out_ParametersEg obj = new Out_ParametersEg();
            obj.calculation(num1, num2, length,out cal,out sum, out product);
            if (sum>0 && product>0)
            {
                Console.WriteLine("sum:{0}||product:{1}||cal{2}",sum,product,cal);
            }
            Console.WriteLine("---------------------------");
            obj.studenrdetails("Ram","Singing","Playing","Reading");
            Console.ReadLine();
        }
    }
}
