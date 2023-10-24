```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
Intel Core i5-9300H CPU 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
| Method                     | Mean         | Error       | StdDev      | Rank | Gen0   | Allocated |
|--------------------------- |-------------:|------------:|------------:|-----:|-------:|----------:|
| TryCatchParseTestWithError | 9,347.793 ns | 170.8971 ns | 341.3000 ns |    6 | 0.1221 |     520 B |
| TryParseTestWithError      |    10.175 ns |   0.0528 ns |   0.0441 ns |    2 |      - |         - |
| TryPraseFixedTestWithError |     9.879 ns |   0.2231 ns |   0.4080 ns |    1 |      - |         - |
| TryCatchParseTest          |    13.164 ns |   0.2936 ns |   0.2602 ns |    5 |      - |         - |
| TryParseTest               |    10.913 ns |   0.1765 ns |   0.1564 ns |    4 |      - |         - |
| TryParseFixedTest          |    10.676 ns |   0.1669 ns |   0.1479 ns |    3 |      - |         - |
