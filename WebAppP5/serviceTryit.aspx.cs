using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppP5
{
    public partial class serviceTryit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            // Create a new directory in the server
            string path = @"c:\ServiceStorage";

            // Specify the path on the server to save the uploaded file to.

            //String savePath = @"c:\Downloads\";
            String savePath = @"c:\ServiceStorage\";
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    savePath = @"c:\ServiceStorage\";
                    Console.WriteLine("That path exists already.");
                    //return;
                }
                else {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    savePath = @"c:\ServiceStorage";
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                   
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }

            //verify if the FileUpload control contains a file.
            if (FileUpload1.HasFile)
            {
                // Get the name of the file to upload.
                String fileName = FileUpload1.FileName;

                // Append the name of the file to upload to the path.
                savePath += fileName;


                // Call the SaveAs method to save the uploaded file to the specified path.                  
                // If a file with the same name already exists in the specified path,  
                // the uploaded file overwrites it.
                FileUpload1.SaveAs(savePath);

                // Notify the user of the name of the file
                // was saved under.
                lblmessage.Text = "Your file was store at:";
                Label3.Text = savePath;
            }
            else
            {
                // Notify the user that a file was not uploaded.
                Label3.Text = "You did not specify a file to upload.";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}