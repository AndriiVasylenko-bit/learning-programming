```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
Intel Core i5-9300H CPU 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
| Method       | Mean     | Error     | StdDev    | Allocated |
|------------- |---------:|----------:|----------:|----------:|
| StructTestIn | 5.377 ns | 0.1005 ns | 0.0891 ns |         - |
| StructTest   | 9.288 ns | 0.0874 ns | 0.0774 ns |         - |
| ClassTest    | 4.780 ns | 0.0927 ns | 0.0822 ns |         - |
