# Eloquent

Eloquent is a small collection of fluent (or fluent-like) expressions for C#.  The examples below are some but not all of the methods it provides.

### TimeSpan expressions
```c#
 var tenMillisecondsSpan = 10.Milliseconds();
 var tenSecondsSpan = 10.Seconds();
 var tenMinuteSpan = 10.Minutes();
 var tenHoursSpan = 10.Hours();
 var tenDaySpan = 10.Days(); 
 var tenYearSpan = 10.Years(); 
```

### DateTime expressions
```c#
// Local Times
 DateTime recentPast = 10.Minutes().Ago();
 DateTime distantFuture = 10.Years().FromNow();

// UTC Times
 DateTime recentPast = 10.Minutes().AgoUtc();
 DateTime distantFuture = 10.Years().FromNowUtc(); 
```

### String Expression
```c#
bool isEmpty = someString.IsEmpty();
bool isNullOrEmpty = someString.IsNullOrEmpty();
bool isNullOrWhiteSpace = someString.IsNullOrWhiteSpace();

bool isTrue = "true".ToBoolean();
byte myByte = "true".ToByte();
DateTime dateWritten = "23-Apr-2014 10:56:10.30".ToDateTime(); 
decimal myDecimal = "12.90".ToDecimal();
double myDouble = "12.90".ToDouble();
Int16 myInt16 = "10".ToInt16();
Int32 myInt32 = "10".ToInt32();
Int64 myInt64 = "10".ToInt64();


DateTime myDateTime = "23-Apr-2014 10:56:10.30".ParseDateTime();
DateTime myDateTime = "23-Apr-2014".ParseDateTime();
if("23-Apr-2014".TryParseDateTime(out myDateTime)){
// success ...}

var myString = "{0], {1} and {2}".Format("Tom", "Dick", "Harry");

MatchCollection matches = "This item costs $12".RegexMatches("\d*");
string myValue = "This item costs $12".RegexReplace("[^\d]");
string myLiteral = "STRING WITH TABS    AND Newlines
".ToLiteral();  

```

### Number Expression
```c#
 // Some Megabyte math.
 2.Exabytes() + 2.Petabytes() + 2.Terabytes() + 2.Gigabytes() + 2.Megabytes() + 2.Kilobytes() + 2.Bytes();
 
```

### Helper Expressions
```c#
 10.Times(()list.Add("Item")); // Do something 10 times.
 
```



