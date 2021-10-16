### [Jcd.DoWhenRun](Jcd_DoWhenRun.md 'Jcd.DoWhenRun').[DoWhenRunExtensions](Jcd_DoWhenRun_DoWhenRunExtensions.md 'Jcd.DoWhenRun.DoWhenRunExtensions')
## DoWhenRunExtensions.DoWhen(IEnumerable, Func&lt;int,object,bool&gt;, Action&lt;int,object&gt;) Method
Setup an action to conditionally run across the elements of a collection/enumerable.  
```csharp
public static System.Collections.IEnumerable DoWhen(this System.Collections.IEnumerable enumerable, System.Func<int,object,bool> predicate, System.Action<int,object> action);
```
#### Parameters
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen(System_Collections_IEnumerable_System_Func_int_object_bool__System_Action_int_object_)_enumerable'></a>
`enumerable` [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
The collection to scan
  
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen(System_Collections_IEnumerable_System_Func_int_object_bool__System_Action_int_object_)_predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
The condition to check. If true, performs the action.
  
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen(System_Collections_IEnumerable_System_Func_int_object_bool__System_Action_int_object_)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
The action to perform on each element and index of the element.
  
#### Returns
[System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
The elements from the input sequence
### Remarks
This is a LINQ compatible visitor pattern
