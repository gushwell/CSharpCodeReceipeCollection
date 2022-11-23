using System;
using System.Linq;

{
    // SequenceEqualでふたつのシーケンスが等しいかを調べる
    var nums1 = new int[] { 1, 2, 3, 4, 5, 6 };
    var nums2 = new int[] { 1, 2, 3, 4, 5, 6 };
    var equals = nums1.SequenceEqual(nums2);
    Console.WriteLine(equals);
}

// 以下、発展で示したコード
{
    // SequenceEqualでふたつのシーケンスが等しいかを調べる
    var persons1 = new Person[] 
    {
        new Person { Name = "文挾", Birthdate = new DateTime(2002, 12, 4) },
        new Person { Name = "町田", Birthdate = new DateTime(1999, 5, 12) }
    };
    var persons2 = new Person[] 
    {
        new Person { Name = "文挾", Birthdate = new DateTime(2002, 12, 4) },
        new Person { Name = "町田", Birthdate = new DateTime(1999, 5, 12) }
    };
    // これはfalseになる
    var equals = persons1.SequenceEqual(persons2);
    Console.WriteLine(equals);
    //  trueにしたければ、IEqualityComparer<T> ジェネリックインターフェイスをクラスに実装する必要があります。
}

public class Person 
{
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
}
