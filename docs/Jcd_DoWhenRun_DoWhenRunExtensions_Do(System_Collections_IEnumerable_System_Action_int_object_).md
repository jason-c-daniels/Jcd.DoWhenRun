### [Jcd.DoWhenRun](Jcd_DoWhenRun.md 'Jcd.DoWhenRun').[DoWhenRunExtensions](Jcd_DoWhenRun_DoWhenRunExtensions.md 'Jcd.DoWhenRun.DoWhenRunExtensions')
## DoWhenRunExtensions.Do(IEnumerable, Action&lt;int,object&gt;) Method
Setup an action to run across the elements of a collection/enumerable.  
```csharp
public static System.Collections.IEnumerable Do(this System.Collections.IEnumerable enumerable, System.Action<int,object> action);
```
#### Parameters
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_Do(System_Collections_IEnumerable_System_Action_int_object_)_enumerable'></a>
`enumerable` [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
The collection to scan
  
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_Do(System_Collections_IEnumerable_System_Action_int_object_)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
The action to perform on each element.
  
#### Returns
[System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
The elements from the input sequence
### Remarks
This is a LINQ compatible visitor pattern
