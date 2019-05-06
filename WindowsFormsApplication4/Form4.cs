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
    public partial class Form4 : Form
    {
        readonly DataBase db = new DataBase();
        private readonly Form1 f1;
        string Id;
        string selected_person, selected_cpu, selected_cpuversion, selected_image;
        string selected_date, selected_tia, selected_target;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
            Id = f1.Id;
            editfillcombobox();

            FillAllComboboxes();

        }
        public void editfillcombobox()
        {
            if (f1.Id != null)
            {
                Name_ComboBox.Text = db.select_asArray("register", "person", "id", Id);
                target_comboBox.Text = db.select_asArray("register", "target", "id", Id);
                CPUVersion_combobox.Text = db.select_asArray("register", "cpuversion", "id", Id);
                CPU_combobox.Text = db.select_asArray("register", "cpu", "id", Id);
                image_combobox.Text = db.select_asArray("register", "image", "id", Id);
                tia_combobox.Text = db.select_asArray("register", "tia", "id", Id);
               
            }
        }
        public void FillAllComboboxes()
        {
            f1.Fillcombobox("person", Name_ComboBox);
            f1.Fillcombobox("target", target_comboBox);
            f1.Fillcombobox("tia", tia_combobox);
            f1.Fillcombobox("image", image_combobox);
            f1.Fillcombobox("cpu", CPU_combobox);
            f1.Fillcombobox("cpuversion", CPUVersion_combobox);
        }

        private void Name_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected_date = "2018-06-22";
            selected_person = Name_ComboBox.Text;
            selected_image = image_combobox.Text;
            selected_cpuversion = CPUVersion_combobox.Text;
            selected_cpu = CPU_combobox.Text;
            selected_tia = tia_combobox.Text;
            selected_target = target_comboBox.Text;
            db.insert_toDatabase("register", "date, person, target, tia, cpu, cpuversion, image"
                , "'" + selected_date + "', '" + selected_person + "', '" + selected_target + "', '" + selected_tia + "', '" + selected_cpu + "', '" + selected_cpuversion + "', '" + selected_image + "'");
            db.Showtable(f1.registertable, "register");
        }
    }
}
