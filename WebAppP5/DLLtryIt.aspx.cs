using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


//call the DLL Library created for Encryption and Descrytion
using LarissaDLL_ClassLibrary;

namespace WebAppP5
{
    public partial class DLLtryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string input = TextBox1.Text;
            
            //Calling the encrypt function of the StringEncryption class from the LarissaDLL_ClassLibrary created.

            string output = StringEncryption.EnryptString(input);
            Label3.Text = output;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string input = TextBox1.Text;

            string encrypted = StringEncryption.EnryptString(input);

            //Calling the decrypt function of the StringEncryption class from the LarissaDLL_ClassLibrary created.
            string decrypted = StringDecryption.DecryptString(encrypted);

            Label4.Text = decrypted;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}