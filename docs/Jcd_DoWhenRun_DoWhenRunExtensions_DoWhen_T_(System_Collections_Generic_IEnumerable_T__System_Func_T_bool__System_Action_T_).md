### [Jcd.DoWhenRun](Jcd_DoWhenRun.md 'Jcd.DoWhenRun').[DoWhenRunExtensions](Jcd_DoWhenRun_DoWhenRunExtensions.md 'Jcd.DoWhenRun.DoWhenRunExtensions')
## DoWhenRunExtensions.DoWhen&lt;T&gt;(IEnumerable&lt;T&gt;, Func&lt;T,bool&gt;, Action&lt;T&gt;) Method
Setup an action to conditionally run across the elements of a collection/enumerable.  
```csharp
public static System.Collections.Generic.IEnumerable<T> DoWhen<T>(this System.Collections.Generic.IEnumerable<T> enumerable, System.Func<T,bool> predicate, System.Action<T> action);
```
#### Type parameters
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_)_T'></a>
`T`  
The type of each element
  
#### Parameters
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_)_enumerable'></a>
`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_).md#Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_)_T 'Jcd.DoWhenRun.DoWhenRunExtensions.DoWhen&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The collection to scan
  
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_)_predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_).md#Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_)_T 'Jcd.DoWhenRun.DoWhenRunExtensions.DoWhen&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, System.Action&lt;T&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The condition to check. If true, performs the action.
  
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_).md#Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_)_T 'Jcd.DoWhenRun.DoWhenRunExtensions.DoWhen&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to perform on each element and index of the element.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_).md#Jcd_DoWhenRun_DoWhenRunExtensions_DoWhen_T_(System_Collections_Generic_IEnumerable_T__System_Func_T_bool__System_Action_T_)_T 'Jcd.DoWhenRun.DoWhenRunExtensions.DoWhen&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,bool&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The elements from the input sequence
### Remarks
This is a LINQ compatible visitor pattern
