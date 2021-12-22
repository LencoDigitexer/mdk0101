using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pr12_13_v15_KVA
{
    public partial class Form1 : Form
    {
        Client[] clientDataBase = new Client[]
                {
                    new Contributor("Роблен", new DateTime(2020,5,7), 546312.597m, 20.15),
                    new Contributor("Лунио", new DateTime(2020,5,7), 875621.867m, 18.75),

                    new Creditor("Аполлинарий", new DateTime(2020, 8, 9), 45542.867m, 18.75, 578.89m),
                    new Creditor("Максимильян", new DateTime(2021, 7, 19), 98822.867m, 18.75, 578.89m),

                    new Organization("ООО 'ЗЕЛЕНОГЛАЗОЕ ТАКСИ'", DateTime.Now, 123456789, 75932.7834m),
                    new Organization("ООО 'КОТ ДА ВИНЧИ'", new DateTime(2010,3,8), 456456785, 321456.7834m)
                };
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (Client client in clientDataBase)
            {
                
                textBox1.Text += (client.Show().ToString() + "\n");

            }
            
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            DateTime db;
            db = Convert.ToDateTime(dateTimePicker1.Value.Date);
            foreach (Client client in clientDataBase)
            {
                textBox2.Text += (client.Search(db).ToString() + "\n");
                
            }
            
            label2.Text = String.Format(db + "");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
