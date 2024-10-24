using PostmanCloneLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();
    public Dashboard()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void resultOutput_TextChanged(object sender, EventArgs e)
    {

    }

    private async void apiButton_Click(System.Object sender, EventArgs e)
    {

        resultOutput.Text = string.Empty;


        // check input url
        if (!api.IsValidUrl(apiText.Text))
        {
            currentStatus.Text = "Invalid URL";
            return;
        }
        try
        {
            currentStatus.Text = "Calling API ...";
            var res = await api.CallApiAsync(apiText.Text);
            resultOutput.Text = res;
            currentStatus.Text = "Ready ";
        }
        catch (Exception error)
        {
            resultOutput.Text = "Error: " + error.Message;
            currentStatus.Text = "Error";
        }
    }

    private void apiText_TextChanged(object sender, EventArgs e)
    {

    }
}
