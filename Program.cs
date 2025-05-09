#define DATA_TYPES

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
#if DATA_TYPES
            Console.WriteLine($"Byte:\n Name: {typeof(byte)}, Size: {sizeof(byte)}, Range: {byte.MinValue}...{byte.MaxValue}");
            Console.WriteLine($"SByte:\n Name: {typeof(sbyte)}, Size: {sizeof(sbyte)}, Range: {sbyte.MinValue}...{sbyte.MaxValue}");
            Console.WriteLine($"Short:\n Name: {typeof(short)}, Size: {sizeof(short)}, Range: {short.MinValue}...{short.MaxValue}");
            Console.WriteLine($"UShort:\n Name: {typeof(ushort)}, Size: {sizeof(ushort)}, Range: {ushort.MinValue}...{ushort.MaxValue}");
            Console.WriteLine($"Int:\n Name: {typeof(int)}, Size: {sizeof(int)}, Range: {int.MinValue}...{int.MaxValue}");
            Console.WriteLine($"UInt:\n Name: {typeof(uint)}, Size: {sizeof(uint)}, Range: {uint.MinValue}...{uint.MaxValue}");
            Console.WriteLine($"Long:\n Name: {typeof(long)}, Size: {sizeof(long)}, Range: {long.MinValue}...{long.MaxValue}");
            Console.WriteLine($"ULong:\n Name: {typeof(ulong)}, Size: {sizeof(ulong)}, Range: {ulong.MinValue}...{ulong.MaxValue}");
            Console.WriteLine($"Float:\n Name: {typeof(float)}, Size: {sizeof(float)}, Range: {float.MinValue}...{float.MaxValue}");
            Console.WriteLine($"Double:\n Name: {typeof(double)}, Size: {sizeof(double)}, Range: {double.MinValue}...{double.MaxValue}");
            Console.WriteLine($"Deciminal:\n Name: {typeof(decimal)}, Size: {sizeof(decimal)}, Range: {decimal.MinValue}...{decimal.MaxValue}");
            Console.WriteLine($"Bool:\n Name: {typeof(bool)}, Size: {sizeof(bool)}, Range: {bool.TrueString}...{bool.FalseString}");
            Console.WriteLine($"Char:\n Name: {typeof(char)}, Size: {sizeof(char)}, Range: {((ushort)char.MinValue)}...{((ushort)char.MaxValue)}"); 
#endif

        }
    }
}
