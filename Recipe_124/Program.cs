using System;
using System.Linq;

var member = new Member("gihyo", "gihyo@example.com");
Console.WriteLine(member.UserName);
Console.WriteLine($"{member.EmailAddress.Length} {member.EmailAddress}");
// 以下のふたつの行は、コンパイルで警告がでる
// UserNameはnullを許容しない
// member.UserName = null;
// PhoneNumberはnullの可能性があるからLength参照で例外発生の可能性あり
// Console.WriteLine($"{member.PhoneNumber.Length}");

public class Member 
{
    public Member(string userName, string emailAddress) 
    {
        UserName = userName;
        EmailAddress = emailAddress;
        AdmissionDate = DateTime.Now;
    }
    public string UserName { get; set; }
    public string EmailAddress { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime AdmissionDate { get; set; }
}
