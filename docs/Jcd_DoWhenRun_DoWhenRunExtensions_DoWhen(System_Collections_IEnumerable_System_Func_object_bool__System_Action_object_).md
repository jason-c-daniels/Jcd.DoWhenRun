### [Jcd.DoWhenRun](Jcd_DoWhenRun.md 'Jcd.DoWhenRun').[DoWhenRunExtensions](Jcd_DoWhenRun_DoWhenRunExtensions.md 'Jcd.DoWhenRun.DoWhenRunExtensions')
## DoWhenRunExtensions.DoWhen(IEnumerable, Func&lt;object,bool&gt;, Action&lt;object&gt;) Method
Setup an action to conditionally run across the elements of a collection/enumerable.  
```csharp
public static System.Collections.IEnumerable DoWhen(this System.Collections.IEnumerable enumerable, System.Func<object,bool> predicate, System.Action<object> action);
```
#### Parameters
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen(System_Collections_IEnumerable_System_Func_object_bool__System_Action_object_)_enumerable'></a>
`enumerable` [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
The collection to scan
  
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen(System_Collections_IEnumerable_System_Func_object_bool__System_Action_object_)_predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The condition to check. If true, performs the action.
  
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen(System_Collections_IEnumerable_System_Func_object_bool__System_Action_object_)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to perform on each element and index of the element.
  
#### Returns
[System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
The elements from the input sequence
### Remarks
This is a LINQ compatible visitor pattern
