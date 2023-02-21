using System.Numerics;
using System.Text;

void CenturyOutput()
{
    while (true)
    {
        // read an Short Integer
        var readBuf = Console.ReadLine();
        if (string.IsNullOrEmpty(readBuf))
            break;
        ushort century = ushort.Parse(readBuf);
        Console.WriteLine($"Input: {century}");

        StringBuilder sb = new StringBuilder();
        sb.Append($"{century} centuries");
        uint years = century * (uint)100;
        sb.Append($" = {years} years");
        uint days = (uint)(years * 365.2425);
        sb.Append($" = {days} days");
        ulong hours = days * (ulong)24;
        sb.Append($" = {hours} hours");
        ulong minutes = hours * 60;
        sb.Append($" = {minutes} minutes");
        ulong seconds = minutes * 60;
        sb.Append($" = {seconds} seconds");
        ulong milliseconds = seconds * 1000;
        sb.Append($" = {milliseconds} milliseconds");
        BigInteger nanoseconds = milliseconds * new BigInteger(1000);
        sb.Append($" = {nanoseconds} nanoseconds");

        Console.WriteLine($"Output: " + sb);
    }
}

void DataTypeOutput()
{
    Console.WriteLine($"sbyte use {sizeof(sbyte)} Bytes, range: {sbyte.MinValue} to {sbyte.MaxValue}");
    Console.WriteLine($"byte use {sizeof(byte)} Bytes, range: {byte.MinValue} to {byte.MaxValue}");
    Console.WriteLine($"short use {sizeof(short)} Bytes, range: {short.MinValue} to {short.MaxValue}");
    Console.WriteLine($"ushort use {sizeof(ushort)} Bytes, range: {ushort.MinValue} to {ushort.MaxValue}");
    Console.WriteLine($"int use {sizeof(int)} Bytes, range: {int.MinValue} to {int.MaxValue}");
    Console.WriteLine($"uint use {sizeof(uint)} Bytes, range: {uint.MinValue} to {uint.MaxValue}");
    Console.WriteLine($"long use {sizeof(long)} Bytes, range: {long.MinValue} to {long.MaxValue}");
    Console.WriteLine($"ulong use {sizeof(ulong)} Bytes, range: {ulong.MinValue} to {ulong.MaxValue}");
    Console.WriteLine($"float use {sizeof(float)} Bytes, range: {float.MinValue} to {float.MaxValue}");
    Console.WriteLine($"double use {sizeof(double)} Bytes, range: {double.MinValue} to {double.MaxValue}");
    Console.WriteLine($"decimal use {sizeof(decimal)} Bytes, range: {decimal.MinValue} to {decimal.MaxValue}");
}

DataTypeOutput();
//CenturyOutput();