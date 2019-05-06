using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        
        readonly DataBase _db = new DataBase();
        public string Id = null;
        
        public Form1()
        {
            InitializeComponent();
            _db.Showtable(registertable, "register");
        }
        public void Fillcombobox(string comboboxname, ComboBox cbx)
        {
            List<string> list = _db.SelectItem(comboboxname, comboboxname);
            for (int i = 0; i < list.Count; i++)
            {
                cbx.Items.Add(list[i]);

            }
        }
        public void FillAllComboboxes()
        {
            Fillcombobox("person", Name_ComboBox);
            Fillcombobox("target", target_comboBox);
            Fillcombobox("tia", tia_combobox);
            Fillcombobox("image", image_combobox);
            Fillcombobox("cpu", CPU_combobox);
            Fillcombobox("cpuversion", CPUVersion_combobox);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Id = null;
            Form4 f4 =  new Form4(this); 
            f4.Show();
            add_button.Enabled = false;
            
        }

      
    }
}
