using System.Text;

namespace MVVMLiveDemo23.Models;

public class DemoModel
{
    public string MyText { get; set; } = string.Empty;

    public string ReverseMyText()
    {
        var output = string.Empty;

        for (int i = MyText.Length -1; i >= 0 ; i--)
        {
            output += MyText[i];
        }
        return output;
    }
}