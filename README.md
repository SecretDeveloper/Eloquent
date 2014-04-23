Eloquent
========

Eloquent is a collection of fluent ruby like expressions for C#.  

Expressions:
```
 var recentPast = 10.Minutes().Ago();
 var distantFuture = 10.Years().FromNow();
 var dateWritten = "23-Apr-2014 10:56:10.30".ToDateTime();
 
 var list = new List<string>();
 10.Times(()list.Add("Item")); // Do something 10 times.
 
 // Some Megabyte math.
 1.Exabytes() + 1.Petabytes() + 1.Terabytes() + 1.Gigabytes() + 1.Megabytes() + 1.Kilobytes() + 1.Bytes();
 
 return "true".ToBoolean();
```

More to come.