using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS;
using System.Security.Cryptography.X509Certificates;

namespace WHMS
{
    public partial class Add_WarehouseList_Area : Form
    {

        public Add_WarehouseList_Area()
        {
            InitializeComponent();
            LoadDefaultData();
            label_Err2.Visible = false;
        }

        private void LoadGirdView()
        {
            using (var context = new DatabaseContext())
            {
                if (comboBox_Name.Text != null && comboBox_Area1 != null && context.WarehouseLists.Any())
                {
                    dataGridView_WarehouseLists.DataSource = context.WarehouseLists;
                }
            }
        }

        private void LoadDefaultData()
        {
            using (var context = new DatabaseContext())
            {
                if (context.WarehouseLists.Any())
                {
                    var warehouselists = context.WarehouseLists.ToList();
                    comboBox_Name.DataSource = warehouselists;
                    comboBox_Name.DisplayMember = "_Name";
                    comboBox_Name.ValueMember = "_Id";
                }
                LoadImages();
            }
        }
        private void LoadImages()
        {
            if (comboBox_Name.SelectedValue != null)
            {
                using (var context = new DatabaseContext()) 
                {
                    string selectedWarehouseId = comboBox_Name.SelectedValue.ToString() ?? "wrongValue";
                    var targetWarehouseListsAreas = context.WarehouseList_Areas.Where(x => x.WarehouseList_Id == selectedWarehouseId).ToList();
                    comboBox_Area1.DataSource = targetWarehouseListsAreas;
                    comboBox_Area1.DisplayMember = "_Area";
                    comboBox_Area1.ValueMember = "_Id";
                    var selectedWarehouse = context.WarehouseLists.Find(selectedWarehouseId);
                    if (selectedWarehouse != null && selectedWarehouse._ImagePath != null)
                    {
                        try 
                        {
                            pictureBox_Image.Image = Image.FromFile(selectedWarehouse._ImagePath);
                            pictureBox_Image.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        catch
                        { 
                            pictureBox_Image.Image = null;
                        }

                    }
                }
            }
        }

        private void comboBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadImages();
        }
        private void comboBox_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void button_Apply_Click(object sender, EventArgs e)
        {

        }

        private void label_Name_Click(object sender, EventArgs e)
        {

        }


        private void button_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void label_Err1_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Warehouse_Click(object sender, EventArgs e)
        {
            OpenWL();
        }

        private void OpenWL()
        {
            Add_Warehouse_DefaultInfo wl = new Add_Warehouse_DefaultInfo();
            wl.FormClosed += (sender, e) => { LoadDefaultData(); };
            wl.ShowDialog();
        }

        private void pictureBox_Image_Click(object sender, EventArgs e)
        {

        }
    }
}
