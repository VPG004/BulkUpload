using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

namespace BulkUpload
{
    public partial class UploadForm : Form
    {
        public UploadForm()
        {
            InitializeComponent();
        }

        private void UploadForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Get Windows Login Details
                string APMID = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string[] words = APMID.Split('\\');
                APMID = words[1].ToUpper();
                lblAPMID.Text = APMID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TruncateTable()
        {
            string qry = "Delete from [QT_RateSheetExpiryDate]";
            Connect.ExecuteNonQuery(qry);

        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from QT_UploadUserAccess where APMID='" + lblAPMID.Text + "' and IsActive ='Yes'";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(qry, Connect.getConnection());
                da.Fill(ds, "User");
                int Count = ds.Tables[0].Rows.Count;
                if (Count != 0)
                {
                    if (txtFilePath.Text != "")
                    {
                        label2.Text = "Your Submission Is Processed - Please Wait";

                        this.Cursor = Cursors.WaitCursor;
                        this.Refresh();

                        TruncateTable();

                        //Create Folder if not exist
                        if (!Directory.Exists(@"C:\QuotesBulkUpload\"))
                        {
                            Directory.CreateDirectory(@"C:\QuotesBulkUpload\");
                        }

                        //Delete old files from Directory
                        clearFolder(@"C:\QuotesBulkUpload\");

                        try
                        {
                            string saveFolder = @"C:\QuotesBulkUpload\"; //Pick a folder on your machine to store the uploaded files
                            string filePath = Path.Combine(saveFolder, openFileDialog1.FileName);
                            saveFolder = saveFolder + openFileDialog1.SafeFileName.ToString();
                            File.Copy(filePath, saveFolder);

                            string connectionString = "";

                            string fileExtension = Path.GetExtension(filePath);

                            if (fileExtension == ".xls")
                            {
                                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel8.0;HDR=Yes;IMEX=2\"";
                            }
                            if (fileExtension == ".xlsx")
                            {
                                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1\"";
                            }
                            if (fileExtension == ".xlsm")
                            {
                                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1\"";
                            }
                            if (fileExtension == ".xlsb")
                            {
                                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1\"";
                            }

                            OleDbConnection con = new OleDbConnection(connectionString);
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.Connection = con;
                            OleDbDataAdapter dAdapter = new OleDbDataAdapter(cmd);
                            System.Data.DataTable dtExcelRecords = new System.Data.DataTable();
                            con.Open();
                            System.Data.DataTable dtExcelSheetName = new System.Data.DataTable();
                            dtExcelSheetName = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                            string getExcelSheetName = "";
                            int length = dtExcelSheetName.Rows.Count;
                            for (int i = 0; i < length; i++)
                            {
                                getExcelSheetName = dtExcelSheetName.Rows[i]["Table_Name"].ToString().Trim();

                                if (getExcelSheetName == "Sheet1$")
                                {

                                    try
                                    {
                                        DataSet dsdata = new DataSet();
                                        OleDbDataAdapter oleda = new OleDbDataAdapter("select * from [" + getExcelSheetName + "]", con);
                                        oleda.SelectCommand.CommandType = CommandType.Text;
                                        oleda.Fill(dsdata);

                                        SqlConnection Sqlcon = Connect.getConnection();
                                        Sqlcon.Open();

                                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(Sqlcon))
                                        {
                                            bulkCopy.DestinationTableName = "QT_RateSheetExpiryDate";
                                            bulkCopy.WriteToServer(dsdata.Tables[0]);
                                        }
                                        Sqlcon.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.ToString());
                                    }
                                }
                            }
                            con.Close();
                            txtFilePath.Text = "";
                            this.Cursor = Cursors.Default;
                            label2.Text = "Successfully uploaded...";
                            MessageBox.Show("successfully uploaded...");
                            label2.Text = "";
                            string Query = "insert into FileuploadedHistory values('" + openFileDialog1.SafeFileName.ToString() + "','" + lblAPMID.Text + "','" + DateTime.Now + "','" + System.Environment.MachineName + "','Successfully uploaded')";
                            Connect.ExecuteNonQuery(Query);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                    else
                    {
                        MessageBox.Show("Select File");
                    }
                }
                else
                {
                    MessageBox.Show("You are not authorize to upload file. Please contact to 'IDA Support and Maintenance' team for right access.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtFilePath.Text = openFileDialog1.FileName;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from QT_RateSheetExpiryDate";
                SqlConnection connection = Connect.getConnection();
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "RateSheetExpiryDate");
                connection.Close();
                grdDownload.DataSource = ds;
                grdDownload.DataMember = "RateSheetExpiryDate";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (grdDownload.RowCount != 0)
            {
                clsExcelIO.GenerateReports(new string[] { "select * from QT_RateSheetExpiryDate @RateSheetExpiryData" });
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from FileuploadedHistory";
                SqlConnection connection = Connect.getConnection();
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "History");
                connection.Close();
                grdHistory.DataSource = ds;
                grdHistory.DataMember = "History";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPullReport_Click(object sender, EventArgs e)
        {
            if (grdHistory.RowCount != 0)
            {
                clsExcelIO.GenerateReports(new string[] { "select * from FileuploadedHistory @UploadedHistory" });
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }
    }
}
