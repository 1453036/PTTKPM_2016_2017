using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;


namespace QuanLyDaiLySach_1453014_1453036
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            DisplayData();
        }

        string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["LinqToSQLDBConnectionString"].ToString();

        LinqToSQLDataContext db = new LinqToSQLDataContext(connectString);

        //MaNV variable used in Updating and Deleting Record  
        string MaNv = "";
        


        //Insert Data  
        private void buttonThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = textBoxMaNhanVien.Text;
            nv.HoTen = textBoxHoTen.Text;
            nv.NgaySinh = comboBoxNgay.Text + "/" + comboBoxThang.Text + "/" + comboBoxNam.Text;
            nv.NoiSinh = textBoxNoiSinh.Text;
            nv.SoDienThoai = textBoxSoDienThoai.Text;
            nv.ChungMinhThu = textBoxChungMinhThu.Text;
            nv.DiaChi = textBoxDiaChi.Text;
            nv.LoaiNhanVien = comboBoxLoaiNhanVien.Text;
            nv.Luong = Convert.ToInt32(textBoxLuong.Text);
            nv.HinhThucLam = textBoxHinhThucLam.Text;
            nv.CaLam = textBoxCaLam.Text;

            

            MessageBox.Show("Record Inserted Successfully");
            DisplayData();
            ClearData();        
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
           
            DataTable dt = new DataTable();
            
          
            dataGridViewNhanVien.DataSource = dt;
           
        }

        //Clear Data  
        private void ClearData()
        {
         
        }
        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridViewNhanVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        //Update Record
        private void buttonCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }
    }


}

