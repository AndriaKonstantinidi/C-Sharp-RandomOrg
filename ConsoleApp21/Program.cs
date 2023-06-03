var IntList = new List<int> { 1356,
1039,
1720,
72,
1433,
889,
100,
1331,
1870,
716,
1643,
1808,
1142,
602,
969,
319,
116,
1183,
725,
499,
139,
1069,
898,
349,
1002,
823,
1596,
592,
1243,
1916,
1936,
640,
789,
1197,
677,
1281,
1253,
301,
327,
1056,
1684,
670,
1018,
1913,
207,
357,
699,
449,
894,
1889};

Console.WriteLine("Enter Number:");

int ConEnter = Convert.ToInt32(Console.ReadLine());


var MoreThan = (from item in IntList
               where item > ConEnter
               orderby item
               select item).ToList();
MoreThan.ForEach(x=>Console.WriteLine(x));
