using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Create_Read_Write_Delete_a_Text_File
{
    public partial class Form1 : Form
    {
        string path = Environment.CurrentDirectory + "/" + "Data.txt";
        public Form1()
        {

            InitializeComponent();
            read();
          
        }

        public void read()
        {
            if (File.Exists(path))      //Check if file exist or not
            {
                StreamReader sr = new StreamReader(path);//create an instance of StreamReader
                string line = sr.ReadLine();             // Read line from text file
                txt_data.Text = line;
                sr.Close();                              //close StreamReader after writing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!File.Exists(path))     //check if file exist or not
            {
                // File.Create(path);      //create file if not exist

                var file = File.Create(path);  //create file if not exist
                file.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))      //Check if file exist or not
            {
                StreamWriter sw = new StreamWriter(path);//create an instance of StreamWriter
                sw.WriteLine(txt_data.Text);               //Write some data in opened file
                sw.Close();                              //close StreamWriter after writing

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            read();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))      //Check if file exist or not
            {
                File.Delete(path);      //if file exist then delete it           
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_data.Text = "";
        }
    }
}
