using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_LambdaFunctionAss
{
    internal class Anynomous
    {
        public static void ValidateUserEntry(List<Person> listed)
        {
            listed.Add(new Person("Komal", "Vairagade", "divyavairagade@gmail.com", "8788252788", "Bridge@labz1"));
            listed.Add(new Person("Sneha", "Jawalekar", "snehajawalekar@gmail.com", "8999646999", "Bridge@labz2"));
            listed.Add(new Person("Nandini", "Ghormade", "nandughormade@gmail.com", "8788266068", "Bridge@labz3"));

            Console.WriteLine(listed.ToString());
            listed.ForEach(x => Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t", x.firstname.ToString() , x.lastname.ToString() , x.email.ToString() , x.mobile.ToString() ,x.password.ToString()));
        }
    }
}
