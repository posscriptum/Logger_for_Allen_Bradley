using libplctag;
using libplctag.DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Tag<RealPlcMapper, float> ply2TagSpeed;
        Tag<RealPlcMapper, float> ply3TagSpeed;
        Tag<RealPlcMapper, float> ply4TagSpeed;
        Tag<RealPlcMapper, float> ply5TagSpeed;
        Tag<RealPlcMapper, float> ply6TagSpeed;

        float tag1;
        float tag2;
        float tag3;
        float tag4;
        float tag5;

        private static char separator = ';';

        private DataTable tableCSV;
        private string path = Application.StartupPath + "\\";
        private DateTime dateTimeOld;
        private int innerCountAttempt = 0;

        private static string exuptionExecuted1;
        private static string exuptionExecuted2;
        private static string exuptionExecuted3;
        private static string exuptionExecuted4;
        private static string exuptionExecuted5;

        public Form1()
        {
            InitializeComponent();
            checkBoxPly2.Checked = true;
            checkBoxPly3.Checked = true;
            checkBoxPly4.Checked = true;
            checkBoxPly5.Checked = true;
            checkBoxPly6.Checked = true;
        }

        private void Logging(object sender, EventArgs e)
        {
            // show errors on form
            label8.Text = exuptionExecuted1 + "\n" + exuptionExecuted2 + "\n" + exuptionExecuted3 + "\n" + exuptionExecuted4 + "\n" + exuptionExecuted5;


            // create new file
            if (dateTimeOld.ToShortDateString() != DateTime.Now.ToShortDateString())
            {
                initializeTags(textBoxTag.Text);
            }
            dateTimeOld = DateTime.Now;

            // Read the value from the PLC
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                try
                {
                    ply2TagSpeed.Read();
                    ply3TagSpeed.Read();
                    ply4TagSpeed.Read();
                    ply5TagSpeed.Read();
                    ply6TagSpeed.Read();
                    exuptionExecuted1 = "";
                }
                catch (Exception ex)
                {
                    exuptionExecuted1 = ex.Message.ToString();
                    if (exuptionExecuted1.Contains("Timeout"))
                    {
                        exuptionExecuted1 = "Error timeout connection to PLC. Check connection.";
                    }
                }

            }).Start();

            if (exuptionExecuted1 != "" & exuptionExecuted1 != null & innerCountAttempt >= 1)
            {
                timerLog.Enabled = false;
                button3.Text = "Start";
                innerCountAttempt = 0;
            }
            else
            {
                innerCountAttempt++;
            }


            // Output on form for control values
            if (checkBoxPly2.Checked)
            {
                label2.Text = ply2TagSpeed.Value.ToString();
            }
            if (checkBoxPly3.Checked)
            {
                label3.Text = ply3TagSpeed.Value.ToString();
            }
            if (checkBoxPly4.Checked)
            {
                label4.Text = ply4TagSpeed.Value.ToString();
            }
            if (checkBoxPly5.Checked)
            {
                label5.Text = ply5TagSpeed.Value.ToString();
            }
            if (checkBoxPly6.Checked)
            {
                label6.Text = ply6TagSpeed.Value.ToString();
            }


            //Save old values of tags
            tag1 = ply2TagSpeed.Value;
            tag2 = ply3TagSpeed.Value;
            tag3 = ply4TagSpeed.Value;
            tag4 = ply5TagSpeed.Value;
            tag5 = ply6TagSpeed.Value;

            //write values to file
            object[] blocks = {DateTime.Now.ToLongTimeString(), tag1.ToString(), tag2.ToString(), tag3.ToString(), tag4.ToString(), tag5.ToString() };
            tableCSV.Rows.Add(blocks);
            ExportToCSV(path + Regex.Replace(DateTime.Now.ToShortDateString(), @"\D", ".") + "-" + textBoxTag.Text + ".csv", tableCSV);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create defoult values (on defoult monitor speed of PLY Cutter - teg VAL_SPUN_MACH_SPEED)
            dateTimeOld = DateTime.Now;
            textBoxTag.Text = "VAL_SPUN_MACH_SPEED";

            // Instantiate the tag with the tagname
            initializeTags("VAL_SPUN_MACH_SPEED");

            timerLog.Enabled = false;

        }

        private Tag<RealPlcMapper, float> CrateTag(string tagName, string ip)
        {
            return new Tag<RealPlcMapper, float>()
            {
                Name = tagName,
                Gateway = ip,
                Path = "1,0",
                PlcType = PlcType.ControlLogix,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
        }

        private void initializeTags(String tagName)
        {
            ply2TagSpeed = CrateTag(tagName, "192.168.135.15");               
            ply3TagSpeed = CrateTag(tagName, "192.168.140.15"); 
            ply4TagSpeed = CrateTag(tagName, "192.168.140.13"); 
            ply5TagSpeed = CrateTag(tagName, "192.168.140.98"); 
            ply6TagSpeed = CrateTag(tagName, "192.168.140.100");

            

            var date = DateTime.Now.ToString();
            date = Regex.Replace(date, @"\D", ".");
           
            tableCSV = ImportFromCSV(path + date + textBoxTag.Text + ".csv", true);

            if(tableCSV.Rows.Count == 0)
            {
                //create new table if table not exist
                tableCSV = new DataTable();
                tableCSV.Columns.Add(new DataColumn("Time"));
                tableCSV.Columns.Add(new DataColumn("Ply-2"));
                tableCSV.Columns.Add(new DataColumn("Ply-3"));
                tableCSV.Columns.Add(new DataColumn("Ply-4"));
                tableCSV.Columns.Add(new DataColumn("Ply-5"));
                tableCSV.Columns.Add(new DataColumn("Ply-6"));
            }
            
            label10.Text = path;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = comboBox1.SelectedItem.ToString();
            switch (combo)
            {
                case "1 sec":
                    timerLog.Interval = 1000;
                    break;

                case "2 sec":
                    timerLog.Interval = 2000;
                    break;

                case "5 sec":
                    timerLog.Interval = 5000;
                    break;

                case "10 sec":
                    timerLog.Interval = 10000;
                    break;

                case "30 sec":
                    timerLog.Interval = 30000;
                    break;

                case "1 min":
                    timerLog.Interval = 60000;
                    break;

                case "5 min":
                    timerLog.Interval = 300000;
                    break;

                case "10 min":
                    timerLog.Interval = 600000;
                    break;

                case "30 min":
                    timerLog.Interval = 1800000;
                    break;

                default: 
                    timerLog.Interval = 5000;
                    break;
            }
        }

        // Button start logging with new tag
        private void button2_Click(object sender, EventArgs e)
        {
            initializeTags(textBoxTag.Text);
        }

        // Button setting new path for saving log-file
        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                path = dialog.SelectedPath + "\\";
            }
            label10.Text = path;
        }

        /// <summary>
        /// Upload data from CSV file
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <param name="first_row_is_column_name">First string of table is column name</param>
        /// <returns></returns>
        public static DataTable ImportFromCSV(string fileName, bool first_row_is_column_name)
        {
            
            DataTable ret = new DataTable();
            TextReader tr;
            try
            {
                tr = new StreamReader(fileName, Encoding.GetEncoding(1251));
                exuptionExecuted2 = "Start attach data to an existing file";
            }
            catch
            {
                exuptionExecuted2 = "";
                return new DataTable();
            }

            string line = tr.ReadLine();
            if (line == null)
            {
                return new DataTable();
            }
            string[] columns = line.Split(separator);
            for (int i = 0; i < columns.Length; i++)
                if (first_row_is_column_name)
                    ret.Columns.Add(Regex.Replace(columns[i].ToString(), "\"", ""));
                else
                    ret.Columns.Add("column_" + i.ToString());
            if (first_row_is_column_name)
                line = tr.ReadLine();
            while (line != null)
            {
                string[] blocks = line.Split(separator);
                DataRow dr = ret.NewRow();
                int i = 0;
                foreach (var colName in ret.Columns)
                {
                    string t = "";
                    try
                    {
                        t = Regex.Replace(blocks[i].ToString(), "\"", "");
                        exuptionExecuted3 = "";
                    }
                    catch(Exception ex)
                    {
                        exuptionExecuted3 = ex.Message.ToString();
                        break;
                    }
                    
                    dr[colName.ToString()] = t;
                    i++;
                }
                ret.Rows.Add(dr);
                line = tr.ReadLine();
            }
            tr.Close();
            tr.Dispose();
            return ret;
        }

        /// <summary>
        /// Download to CSV file
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <param name="table">Table from witch will upload data for download to file</param>
        /// <returns></returns>
        public static bool ExportToCSV(string fileName, DataTable table)
        {
            
            if (table == null) {
                return false;
            }
            else{
                FileStream fs = null;
                try
                {
                    fs = File.OpenWrite(fileName);
                    exuptionExecuted4 = "";
                }
                catch (Exception ex)
                {
                    exuptionExecuted4 = ex.Message.ToString();
                    return false;
                }

                try
                {
                    TextWriter tw = new StreamWriter(fs, Encoding.GetEncoding(1251));

                    string line = "";
                    //Download table name
                    if (!String.IsNullOrEmpty(table.TableName))
                        tw.WriteLine(table.TableName);
                    //Download column name
                    foreach (DataColumn colName in table.Columns)
                    {
                        line += String.Format("\"{0}\"{1}", colName.ColumnName, separator);
                    }
                    tw.WriteLine(line.TrimEnd(separator));
                    //Download data
                    foreach (DataRow dr in table.Rows)
                    {
                        line = "";
                        Array.ForEach(dr.ItemArray, obj => line += String.Format("\"{0}\"{1}", obj, separator));
                        tw.WriteLine(line.TrimEnd(separator));
                    }

                    tw.Close();
                    tw.Dispose();
                    exuptionExecuted5 = "";
                }
                catch(Exception ex)
                {
                    exuptionExecuted5 = ex.Message.ToString();
                    return false;
                }
                fs.Close();
                fs.Dispose();
                return true;
            }

        }

        // Button Start/Stop
        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text == "Start")
            {
                button3.Text = "Stop";
                timerLog.Enabled = true;
                initializeTags(textBoxTag.Text);
            }
            else
            {
                button3.Text = "Start";
                timerLog.Enabled = false;
            }            
        }
    }
}
