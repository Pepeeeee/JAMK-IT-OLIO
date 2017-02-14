using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void TestPersonsClass()
        {//luodaan ns. henkilörekisteri
            Persons myFriends = new Persons();
            //lisätääs muutama kaveri rekisteriin
            Person friend1 = new Person();
            friend1.Firstname = "Kirsi";
            friend1.Lastname = "Kernell";
            friend1.SocialSecurityNumber = "121270-123A";
            //lyhyempi tapa luoda olio
            Person friend2 = new Person { Firstname = "jack", Lastname = "Russell", SocialSecurityNumber = "140217-1111" };
            Person friend3 = new Person { Firstname = "Hugh", Lastname = "Jackman", SocialSecurityNumber = "800085-1337" };
            Person friend4 = new Person { Firstname = "kake", Lastname = "Kuspäää", SocialSecurityNumber = "123456-1337" };
            //mehtodi
            //lisätään kaverit yksikerrallaan kaveri-rekisteriin
            myFriends.Add(friend1);
            myFriends.Add(friend2);
            myFriends.Add(friend3);
            myFriends.Add(friend4);
            // Console.WriteLine("Seuraavat murhattavat:\n{0}\n{1}\n{2}", friend1, friend2, friend3);
            Console.WriteLine("******MURHALISTA********");
            myFriends.ShowPersons();
            //testataan kaverin hakua
            Console.WriteLine("Anna kaverinumero: ");
            string retval = Console.ReadLine();
            int i = 0;
            if (int.TryParse(retval, out i))
            {
                //huom get.metodi palauttaa null jos indeksin osoittamaa kaveria ei ole   
                Person searchedFriend = myFriends.Get(int.Parse(retval));
                if (searchedFriend != null)
                {
                    Console.WriteLine(String.Format("Löytyi ystävä nimeltä {0}", searchedFriend.ToString()));
                }
                else
                {
                    Console.WriteLine("Annetulla numerolla ei löydy kaveria");
                }
            }
            //testataan kaverin hakemista HETU:lla
            Console.WriteLine("Kerro kaverisi henkilöturvatunnus");
            retval = Console.ReadLine();
           Person XD = myFriends.Find(retval);
            if (XD != null)
            {
                Console.WriteLine(string.Format("löytyi: {0}", XD.ToString()));

            }
            else
                Console.WriteLine(string.Format("Annetulla {0} HETU:lla ei löydy kaveria", retval));
                 
        }


        static void Main(string[] args)
        {
            TestPersonsClass();
        }
    }
}
