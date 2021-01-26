using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Massiv
{
    class Program
    {
        static void Main(string[] args)
        {
			string s="INTMA";
			for (int i=1 ; i<=s.Length; i++)
			{
				String n=s.Substring(s.Length-i, 1);
               			Console.Write(n);
			}
		}
	}
}
