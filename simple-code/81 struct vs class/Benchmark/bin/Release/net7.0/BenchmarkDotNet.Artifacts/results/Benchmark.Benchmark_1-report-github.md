```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
Intel Core i5-9300H CPU 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
| Method     | Mean        | Error     | StdDev    | Median      | Gen0   | Gen1   | Gen2   | Allocated |
|----------- |------------:|----------:|----------:|------------:|-------:|-------:|-------:|----------:|
| StructTest |   0.0004 ns | 0.0012 ns | 0.0010 ns |   0.0000 ns |      - |      - |      - |         - |
| ClassTest  | 137.1988 ns | 2.7465 ns | 6.5274 ns | 137.6908 ns | 0.0057 | 0.0052 | 0.0002 |      24 B |
