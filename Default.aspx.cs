using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //no real need for any code or declarations on page load
    }

    void Application_Error(object sender, EventArgs e)
    {
        Exception exc = Server.GetLastError();

        if (exc is HttpUnhandledException)
        {
            // A way to inform the user that an error has occurred
            instruction.InnerText = "An error has occurred, please try again." + exc;

        }
        // Clear the error from the server.
        Server.ClearError();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += Button1.Text;//onClick make the textBox display the number
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += Button2.Text;//onClick make the textBox display the number
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += Button3.Text;//onClick make the textBox display the number
    }

    protected void addButton_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += addButton.Text;//onClick make the textBox display the addition symbol
    }

    protected void clearButton_Click(object sender, EventArgs e)
    {
        displayTextBox.Text = "";//clear the textBox
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += Button4.Text;//onClick make the textBox display the number
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += Button5.Text;//onClick make the textBox display the number
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += Button6.Text;//onClick make the textBox display the number
    }

    protected void subtractButton_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += subtractButton.Text;//onClick make the textBox display the subtraction symbol
    }

    protected void deleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            displayTextBox.Text = displayTextBox.Text.Remove(displayTextBox.Text.Length - 1, 1);//delete a number or backspace 
        }
        catch(Exception exc)//attempt to catch an exception that might occur and inform the user
        {
            instruction.InnerText = "An error has occurred, please try again." + exc;
        } 
        finally
        {
            // Clear the error from the server.
            Server.ClearError();
        }  
               
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += Button7.Text;//onClick make the textBox display the number
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += Button8.Text;//onClick make the textBox display the number
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += Button9.Text;//onClick make the textBox display the number
    }

    protected void multiplyButton_Click(object sender, EventArgs e)
    {
        int x;
        x = Convert.ToInt16(displayTextBox.Text);
        displayTextBox.Text += "*";     //onClick make the textBox display the multiplication symbol  
    }

    protected void equalsButton_Click(object sender, EventArgs e)
    {
        int total;//a variable for the operation's total
        string number = displayTextBox.Text;//a variable for the text in the textbox that the user has entered
        string[] numbers = number.Split('+', '*', '-', '/');//splits the text in number into an array to find which operator is present
        if (number.Contains("+"))
        {
            total = Convert.ToInt16(numbers[0]) + Convert.ToInt16(numbers[1]);//performs the addition operation
            displayTextBox.Text = total.ToString();//displays the total as a string in the textbox
        }
        if (number.Contains("*"))
        {
            total = Convert.ToInt16(numbers[0]) * Convert.ToInt16(numbers[1]);//performs the multiplication operation
            displayTextBox.Text = total.ToString();//displays the total as a string in the textbox
        }
        if (number.Contains("-"))
        {
            total = Convert.ToInt16(numbers[0]) - Convert.ToInt16(numbers[1]);//performs the subtraction operation
            displayTextBox.Text = total.ToString();//displays the total as a string in the textbox
        }
        if (number.Contains("/"))
        {
            total = Convert.ToInt16(numbers[0]) / Convert.ToInt16(numbers[1]);//performs the division operation
            displayTextBox.Text = total.ToString();//displays the total as a string in the textbox
        }
    }

    protected void Button0_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += Button0.Text;//onClick make the textBox display the number
    }

    protected void divideButton_Click(object sender, EventArgs e)
    {
        displayTextBox.Text += divideButton.Text;//onClick make the textBox display the division symbol
    }

    //protected void ptButton_Click(object sender, EventArgs e)
    //{
    //    displayTextBox.Text += ptButton.Text;
    //}
 
   
}