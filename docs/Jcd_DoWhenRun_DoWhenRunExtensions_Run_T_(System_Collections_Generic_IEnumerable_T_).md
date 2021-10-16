### [Jcd.DoWhenRun](Jcd_DoWhenRun.md 'Jcd.DoWhenRun').[DoWhenRunExtensions](Jcd_DoWhenRun_DoWhenRunExtensions.md 'Jcd.DoWhenRun.DoWhenRunExtensions')
## DoWhenRunExtensions.Run&lt;T&gt;(IEnumerable&lt;T&gt;) Method
Forces enumeration of an enumerable.   
```csharp
public static void Run<T>(this System.Collections.Generic.IEnumerable<T> enumerable);
```
#### Type parameters
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_Run_T_(System_Collections_Generic_IEnumerable_T_)_T'></a>
`T`  
The type of each element in the enumeration.
  
#### Parameters
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_Run_T_(System_Collections_Generic_IEnumerable_T_)_enumerable'></a>
`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Jcd_DoWhenRun_DoWhenRunExtensions_Run_T_(System_Collections_Generic_IEnumerable_T_).md#Jcd_DoWhenRun_DoWhenRunExtensions_Run_T_(System_Collections_Generic_IEnumerable_T_)_T 'Jcd.DoWhenRun.DoWhenRunExtensions.Run&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
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
