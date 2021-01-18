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
			int i; int j=1;
			for (i=1 ; i<=s.Length; i++)
			{
				String m=s.Substring(s.Length-j);//A,MA,TMA,...
				String n=m.Remove(1, m.Length-1);//A,M,T,...
				Console.Write(n);
                j++;
			}
		}
	}
}