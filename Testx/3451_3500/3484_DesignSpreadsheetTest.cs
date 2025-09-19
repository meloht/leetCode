using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._3451_3500._3484_DesignSpreadsheetAlg;

namespace Testx._3451_3500
{

    public class _3484_DesignSpreadsheetTest
    {

        [Fact]
        public void Test1()
        {
            Spreadsheet spreadsheet = new Spreadsheet(3); // 初始化一个具有 3 行和 26 列的电子表格
            Assert.Equal(12, spreadsheet.GetValue("=5+7")); // 返回 12 (5+7)
            spreadsheet.SetCell("A1", 10); // 设置 A1 为 10
            Assert.Equal(16, spreadsheet.GetValue("=A1+6")); // 返回 16 (10+6)
            spreadsheet.SetCell("B2", 15); // 设置 B2 为 15
            Assert.Equal(25, spreadsheet.GetValue("=A1+B2")); // 返回 25 (10+15)
            spreadsheet.ResetCell("A1"); // 重置 A1 为 0
            Assert.Equal(15, spreadsheet.GetValue("=A1+B2")); // 返回 15 (0+15)
        }
    }
}
