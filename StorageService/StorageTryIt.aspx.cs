using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StorageService
{
    public partial class StorageTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            string savePath = "";
             

            //Call the file Storage service

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
           
            if (FileUpload1.HasFile)
            {
               
                String fileName = FileUpload1.FileName;

               savePath = client.Storefile(fileName);

               // savePath += fileName;
                FileUpload1.SaveAs(savePath);

                lblmessage.Text = "Your file was store at: ";
                Label3.Text = savePath;
            }
            else
            {
                // Notify the user that a file was not uploaded.
                Label3.Text = "You did not specify a file to upload.";
            }
        }

    }
}