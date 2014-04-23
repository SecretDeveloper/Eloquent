Eloquent
========

Eloquent is a collection of fluent ruby like expressions for C#.  

<<<<<<< HEAD
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
=======
Sample Expressions:
```
 10.Minutes().Ago()
 10.Years().FromNow()
 "23-Apr-2014 10:56:10.30".ToDateTime();
 DateTime dt = 10.Days().FromNow()
 10.Times(x=>x...)
 1.Exabytes() + 1.Petabytes() + 1.Terabytes() + 1.Gigabytes() + 1.Megabytes() + 1.Kilobytes() + 1.Bytes();
 "true".ToBoolean();
```
>>>>>>> 0b74324e91d849b82c55a6041efeca42dd8ed0b5
