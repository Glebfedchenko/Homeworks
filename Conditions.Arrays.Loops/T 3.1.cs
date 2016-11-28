using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1_updated
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] _Roles = new String[3] { "Admin", "User", "Moderator" };
            String[] _Name = new String[3] { "C#", ".NET", "Java" };
            String[] _Pass = new String[3] { "Admin", "User", "Moderator" };

            Console.WriteLine("Please enter your login: ");
            String _Log = Console.ReadLine();

            for (int e = 3; e > 0; e--)
            {
                for (int i = 0; i < _Roles.Length; i++)
                {
                    if (_Roles[i] == _Log)
                    {
                        Console.WriteLine("Please enter your password: ");
                        String _Word = Console.ReadLine();

                        if (_Word == _Pass[0])
                        {
                            for (int a = 0; a < _Roles.Length; a++)
                            {
                                Console.WriteLine("User Role is: " + _Roles[a]);
                            }
                            for (int b = 0; b < _Name.Length; b++)
                            {
                                Console.WriteLine("Username of " + _Roles[b] + " is: " + _Name[b]);
                            }
                            for (int c = 0; c < _Pass.Length; c++)
                            {
                                Console.WriteLine("Password of " + _Name[c] + " is: " + _Pass[c]);
                            }
                        }
                        else if (_Word == _Pass[2])
                        {
                            Console.WriteLine("All users number is " + _Name.Length);
                        }
                        else if (_Word == _Pass[1])
                        {
                            Console.WriteLine("All users number is " + _Name.Length);
                            for (int b = 0; b < _Name.Length; b++)
                            {
                                Console.WriteLine("Username of " + _Roles[b] + " is: " + _Name[b]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong password " + (e - 1) + " attempts left");
                        }

                    }

                }
            }

            Console.ReadKey();
        }
    }
}
