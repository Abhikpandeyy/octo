using System;
using System.Collection.Generic;
public class Hello
{ 
     public Static void main(string[] args)
     {
         int i=0;
         list<string>AuthorList=newList<string>();
         string dataString="hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423d34234jh dfh";
         string[]=dataArray dataString.Split("");
         List<string>validDateList=new List<string>();
         foreach(string word in dataArray)
         {
             if(found && CheakValidDate(word))
             {
                 validDateList.Add(word);
             }
         }
     } Console.WriteLine("total Valid daet String are list bellow:");
     foreach(string word in validDateList)
     {
         Console.WriteLine(word);
     }
     static bool CheakValidDate(string date)
     {
         DateTime dt;
         date=date.Substring(0,2)+"-"+date.Substring(2,2)+"-"+daetSubstring(4);
         Console.WriteLine(date);
         string[] format=new string[]{"mm-dd-yyyy"};
         DateTime datetime;
         return DateTime.tryParesExact(date,format,System.Globalization.CultureInfo.InvariantCulture,System.Globalization.DatetimeStyle.NoCurrentDateDeault,outDatetime);
         
     }
     
     
}
