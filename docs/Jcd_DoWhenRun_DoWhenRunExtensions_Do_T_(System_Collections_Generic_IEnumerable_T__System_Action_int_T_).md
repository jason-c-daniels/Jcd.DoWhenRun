### [Jcd.DoWhenRun](Jcd_DoWhenRun.md 'Jcd.DoWhenRun').[DoWhenRunExtensions](Jcd_DoWhenRun_DoWhenRunExtensions.md 'Jcd.DoWhenRun.DoWhenRunExtensions')
## DoWhenRunExtensions.Do&lt;T&gt;(IEnumerable&lt;T&gt;, Action&lt;int,T&gt;) Method
Setup an action to run across the elements of a collection/enumerable.  
```csharp
public static System.Collections.Generic.IEnumerable<T> Do<T>(this System.Collections.Generic.IEnumerable<T> enumerable, System.Action<int,T> action);
```
#### Type parameters
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_Do_T_(System_Collections_Generic_IEnumerable_T__System_Action_int_T_)_T'></a>
`T`  
The type of each element
  
#### Parameters
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_Do_T_(System_Collections_Generic_IEnumerable_T__System_Action_int_T_)_enumerable'></a>
`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Jcd_DoWhenRun_DoWhenRunExtensions_Do_T_(System_Collections_Generic_IEnumerable_T__System_Action_int_T_).md#Jcd_DoWhenRun_DoWhenRunExtensions_Do_T_(System_Collections_Generic_IEnumerable_T__System_Action_int_T_)_T 'Jcd.DoWhenRun.DoWhenRunExtensions.Do&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Action&lt;int,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The collection to scan
  
<a name='Jcd_DoWhenRun_DoWhenRunExtensions_Do_T_(System_Collections_Generic_IEnumerable_T__System_Action_int_T_)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](Jcd_DoWhenRun_DoWhenRunExtensions_Do_T_(System_Collections_Generic_IEnumerable_T__System_Action_int_T_).md#Jcd_DoWhenRun_DoWhenRunExtensions_Do_T_(System_Collections_Generic_IEnumerable_T__System_Action_int_T_)_T 'Jcd.DoWhenRun.DoWhenRunExtensions.Do&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Action&lt;int,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
The action to perform on each element and index of the element.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Jcd_DoWhenRun_DoWhenRunExtensions_Do_T_(System_Collections_Generic_IEnumerable_T__System_Action_int_T_).md#Jcd_DoWhenRun_DoWhenRunExtensions_Do_T_(System_Collections_Generic_IEnumerable_T__System_Action_int_T_)_T 'Jcd.DoWhenRun.DoWhenRunExtensions.Do&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Action&lt;int,T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The elements from the input sequence
### Remarks
This is a LINQ compatible visitor pattern
