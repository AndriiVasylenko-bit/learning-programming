using System;

namespace Lesson_3
{
	class Program
	{
		static void Main(string[] args)
		{
			bool alive = true;
			bool isDead = false;
			byte bit1 = 1;
			byte bit2 = 102;
			sbyte bit3 = -101;
			sbyte bit4 = 102;
			short n1 = -1;
			short n2 = 102;
			ushort n3 = 1;
			ushort n4 = 102;
			int a = -10;
			int b = 0b101;  // бинарная форма b =5
			int c = 0xFF;   // шестнадцатеричная форма c = 255
			uint a1 = 10U;
			uint b2 = 0b101U;
			uint c3 = 0xFFU;
			long a4 = -10;
			long b5 = 0b101;
			long c6 = 0xFF;
			ulong a7 = 10U;
			ulong b8 = 0b101U;
			ulong c9 = 0xFFU;
			char a10 = 'A';
			char b11 = '\x5A';
			char c12 = '\u0420';
			string hello = "Hello";
			string word = "world";
			object a13 = 22;
			object b14 = 3.14;
			object c15 = "hello code";
			float a16 = 3.14F;
			float b17 = 30.6f;
			decimal c18 = 1005.8M;
			decimal d19 = 334.8m;
			var hello1 = "Hell to World";
			var c20 = 20;

			Console.WriteLine(alive);
			Console.WriteLine(isDead);
			Console.WriteLine(bit1);
			Console.WriteLine(bit2);
			Console.WriteLine(bit3);
			Console.WriteLine(bit4);
			Console.WriteLine(n1);
			Console.WriteLine(n2);
			Console.WriteLine(n3);
			Console.WriteLine(n4);
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			Console.WriteLine(a1);
			Console.WriteLine(b2);
			Console.WriteLine(c3);
			Console.WriteLine(a4);
			Console.WriteLine(b5);
			Console.WriteLine(c6);
			Console.WriteLine(a7);
			Console.WriteLine(b8);
			Console.WriteLine(c9);
			Console.WriteLine(a10);
			Console.WriteLine(b11);
			Console.WriteLine(c12);
			Console.WriteLine(hello);
			Console.WriteLine(word);
			Console.WriteLine(a13);
			Console.WriteLine(b14);
			Console.WriteLine(c15);
			Console.WriteLine(a16);
			Console.WriteLine(b17);
			Console.WriteLine(c18);
			Console.WriteLine(d19);
			Console.WriteLine(hello1.GetType().ToString());
			Console.WriteLine(c20.GetType().ToString());
			Console.WriteLine(hello1);
			Console.WriteLine(c20);
		}
	}
}
