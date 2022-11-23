using System;
using System.Dynamic;
using System.Collections.Generic;

// 利用例
dynamic obj = new DynamicDataObject();
obj.Name = "出井";
obj.City = "宇都宮";
obj.HireDate = new DateTime(2020, 4, 1);
Console.WriteLine($"{obj.Name}: {obj.Name.GetType().Name}");
Console.WriteLine($"{obj.City}: {obj.City.GetType().Name}");
Console.WriteLine($"{obj.HireDate:D}: {obj.HireDate.GetType().Name}");
Console.WriteLine(obj.IsDefined("City"));

// 動的にプロパティを追加できるクラス
public class DynamicDataObject : DynamicObject 
{
    private Dictionary<string, object> _data
        = new Dictionary<string, object>();

    public override bool TryGetMember(GetMemberBinder binder, out object result) 
        => _data.TryGetValue(binder.Name, out result);

    public override bool TrySetMember(SetMemberBinder binder, object value) 
    {
        _data[binder.Name] = value;
        return true;
    }

    public bool IsDefined(string propertyName) 
        => _data.ContainsKey(propertyName);
}