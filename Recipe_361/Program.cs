using System;
using Moq;

namespace Gihyo
{
    class Program
    {
        static void Main()
        {
            // readonly プロパティの定義
            var mock = new Mock<IProduct>();
            mock.SetupGet(m => m.ProductName).Returns("Pencil");
            Console.WriteLine(mock.Object.ProductName);

            // 読み書き可 プロパティの定義
            var mock2 = new Mock<IProduct>();
            mock2.SetupProperty(m => m.ProductName, "Ballpen");
            var product = mock2.Object;
            Console.WriteLine(product.ProductName);
            product.ProductName = "Notepad";
            Console.WriteLine(product.ProductName);
        }
    }

    public interface IProduct
    {
        string ProductName { get; set; }
    }
}
