### [Jcd.DoWhenRun](Jcd_DoWhenRun.md 'Jcd.DoWhenRun').[DoWhenRunExtensions](Jcd_DoWhenRun_DoWhenRunExtensions.md 'Jcd.DoWhenRun.DoWhenRunExtensions')
## DoWhenRunExtensions.Run(IEnumerable) Method
Forces enumeration of an enumerable.   
```csharp
public static void Run(this System.Collections.IEnumerable enumerable);
```
#### Parameters
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_Run(System_Collections_IEnumerable)_enumerable'></a>
`enumerable` [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
The enumerable to force enumeration on
  
### Remarks
Called solely on the likes of a List or Array this is a useless method.  
But combined with LINQ extensions and Scan this enables setting  
up easier to read code that performs operations on the elements  
within a collection, possibly filtered, or otherwise altered via LINQ.  
Coercing the enumeration then executes all of the Scan blocks, as appropriate.  
This then causes execution of the visitor pattern configured by calls to Scan.  
CAUTION: Do not use on a LINQ-to-SQL or similar enumerable. Results are undefined,  
and probably undesirable.  
