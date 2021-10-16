# Jcd.DoWhenRun
A netstandard 1.0 set of extension methods, Do, DoWhen and Run, that give a `Fluent`
builder-pattern-like experience to operating on `IEnumerable` and `IEnumerable<T>` 
derived types.

## Do
`Do` sets up an operation to perform on every item it iterates across.

## DoWhen
`DoWhen` sets up an operation to perform on every item it iterates across that matches the predicate.

## Run
`Run` enumerates an IEnumerable and therefore causes execution of the the code configured in `Do` and `DoWhen` blocks.

## Example
```csharp
    (from x in Enumerable.Range(0, 4)
     from y in Enumerable.Range(0, 4)
     select (x, y))
        .DoWhen((i,_)=>i > 0 && i % 4 == 0, (_,_)=>Console.WriteLine())
        .Do(t=>Console.Write(t))
        .Run();

    Console.WriteLine();
    
    /* outputs:
        (0, 0)(0, 1)(0, 2)(0, 3)
        (1, 0)(1, 1)(1, 2)(1, 3)
        (2, 0)(2, 1)(2, 2)(2, 3)
        (3, 0)(3, 1)(3, 2)(3, 3)            
    */            
```

[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.DoWhenRun)](https://github.com/jason-c-daniels/Jcd.DoWhenRun/blob/main/LICENSE)
[![Build status](https://ci.appveyor.com/api/projects/status/sbmfvmr1jmcf1pic?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/jcd-dowhenrun)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.DoWhenRun)](https://www.codefactor.io/repository/github/jason-c-daniels/Jcd.DoWhenRun)

[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.DoWhenRun?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.DoWhenRun)
[![Nuget](https://img.shields.io/nuget/v/Jcd.DoWhenRun?logo=nuget)](https://www.nuget.org/packages/Jcd.DoWhenRun)

[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.DoWhenRun/blob/main/docs/Jcd_DoWhenRun.md)
