```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
Intel Core i5-9300H CPU 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
| Method          | Mean         | Error      | StdDev       | Gen0   | Gen1   | Allocated |
|---------------- |-------------:|-----------:|-------------:|-------:|-------:|----------:|
| StructArreyTest |     81.93 ns |   1.669 ns |     2.598 ns | 0.1969 |      - |     824 B |
| ClassArreyTest  | 16,904.93 ns | 509.439 ns | 1,502.092 ns | 0.7629 | 0.7324 |    3224 B |
