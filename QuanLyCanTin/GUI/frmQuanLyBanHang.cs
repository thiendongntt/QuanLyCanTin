using BUS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuanLyBanHang : Form
    {
        DataTable dtCTHD = new DataTable();

        public frmQuanLyBanHang()
        {
            InitializeComponent();

            ////CHITIETHOADON
            //DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
            //btnXoa.Text = "Xóa";
            //btnXoa.UseColumnTextForButtonValue = true;

            //dgvCTHD.Columns.Add(btnXoa);minimize-window.png

            btnClose.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\close-window.png");
            btnMinimize.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\minimize-window.png");
            ptbLogo.ImageLocation = "D:\\QuanLyCanTin\\Images\\utc2.png";

            dtCTHD.Columns.Add("ID");
            dtCTHD.Columns.Add("TENSP");
            dtCTHD.Columns.Add("GIA");
            dtCTHD.Columns.Add("SOLUONG");
            dtCTHD.Columns.Add("THANHTIEN");

            dgvCTHD.DataSource = dtCTHD;

            ArrayList listIdSP = new ArrayList();
            ArrayList listTenSP = new ArrayList();
            ArrayList listGia = new ArrayList();
            ArrayList listSLConLai = new ArrayList();
            ArrayList listHinhAnh = new ArrayList();

            for (int i = 0; i < SanPhamBUS.Instance.getSanPham().Rows.Count; i++)
            {
                listIdSP.Add(SanPhamBUS.Instance.getSanPham().Rows[i][0]);
                listTenSP.Add(SanPhamBUS.Instance.getSanPham().Rows[i][1]);
                listGia.Add(SanPhamBUS.Instance.getSanPham().Rows[i][2]);
                listSLConLai.Add(SanPhamBUS.Instance.getSanPham().Rows[i][3]);
                listHinhAnh.Add(SanPhamBUS.Instance.getSanPham().Rows[i][6]);
            }

            loadSanPham(listIdSP, listTenSP, listGia, listSLConLai, listHinhAnh);
        }

        private void loadSanPham(ArrayList listIdSP, ArrayList listTenSP, ArrayList listGia, ArrayList listSLConLai, ArrayList listHinhAnh)
        {
            for (int i = 0; i < listIdSP.Count; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Width = 250;
                pic.Height = 300;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.ImageLocation = listHinhAnh[i].ToString();

                Label lblId = new Label();
                lblId.Text = listIdSP[i].ToString();
                lblId.Hide();
                pic.Controls.Add(lblId);

                Label lblTen = new Label();
                lblTen.Text = listTenSP[i].ToString();
                lblTen.Font = new Font("Arial", 16);
                lblTen.BackColor = Color.DarkRed;
                lblTen.ForeColor = Color.White;
                lblTen.Width = 260;
                lblTen.TextAlign = ContentAlignment.MiddleCenter;

                Label lblGia = new Label();
                lblGia.Text = listGia[i].ToString();
                lblGia.Font = new Font("Arial", 16);
                lblGia.Width = 260;
                lblGia.TextAlign = ContentAlignment.MiddleCenter;

                int slConLai = Convert.ToInt32(listSLConLai[i]);
                Label lblSLConLai = new Label();
                lblSLConLai.Text = "SL: " + slConLai;
                lblSLConLai.Font = new Font("Arial", 12);
                lblSLConLai.Width = 260;
                lblSLConLai.TextAlign = ContentAlignment.MiddleCenter;

                TextBox txtSoLuong = new TextBox();
                txtSoLuong.Enabled = false;
                if (checkId(Convert.ToInt32(lblId.Text)) >= 0)
                {
                    int index = checkId(Convert.ToInt32(lblId.Text));
                    txtSoLuong.Text = dgvCTHD.Rows[index].Cells[3].Value.ToString();
                }
                else
                {
                    txtSoLuong.Text = "0";
                }
                txtSoLuong.Font = new Font("Arial", 13);
                txtSoLuong.TextAlign = HorizontalAlignment.Center;
                txtSoLuong.Width = 50;
                txtSoLuong.Margin = new Padding(0, 2, 0, 2);

                Button btnGiam = new Button();
                if (checkId(Convert.ToInt32(lblId.Text)) >= 0)
                {
                    int index = checkId(Convert.ToInt32(lblId.Text));
                    if (Convert.ToInt32(dgvCTHD.Rows[index].Cells[3].Value) > 0)
                    {
                        btnGiam.Enabled = true;
                    }
                }
                else
                {
                    btnGiam.Enabled = false;
                }
                btnGiam.Margin = new Padding(0, 0, 0, 0);
                btnGiam.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\minus.png");
                btnGiam.Size = new Size(100, 30);
                btnGiam.Click += (sender, args) =>
                {
                    int soLuong = Convert.ToInt32(txtSoLuong.Text);
                    soLuong--;
                    txtSoLuong.Text = soLuong.ToString();

                    if (checkId(Convert.ToInt32(lblId.Text)) >= 0)
                    {
                        int index = checkId(Convert.ToInt32(lblId.Text));
                        dtCTHD.Rows.RemoveAt(index);
                    }

                    if (Convert.ToInt32(txtSoLuong.Text) > 0)
                    {
                        int thanhTien = Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(lblGia.Text);
                        dtCTHD.Rows.Add(lblId.Text, lblTen.Text, lblGia.Text, txtSoLuong.Text, thanhTien.ToString());

                        btnGiam.Enabled = true;
                    }
                    else
                    {
                        btnGiam.Enabled = false;
                    }
                    
                    int tongTien = 0;
                    for (int h = 0; h < dgvCTHD.Rows.Count; h++)
                    {
                        tongTien += Convert.ToInt32(dgvCTHD.Rows[h].Cells[4].Value);
                    }
                    txtTongTien.Text = tongTien.ToString();
                };

                Button btnThem = new Button();
                btnThem.Margin = new Padding(0, 0, 0, 0);
                btnThem.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\plus.png");
                btnThem.Size = new Size(100, 30);
                btnThem.Click += (sender, args) =>
                {
                    if (Convert.ToInt32(txtSoLuong.Text) == slConLai)
                    {
                        MessageBox.Show("Không đủ số lượng");
                    }
                    else
                    {
                        int soLuong = Convert.ToInt32(txtSoLuong.Text);
                        soLuong++;
                        txtSoLuong.Text = soLuong.ToString();

                        btnGiam.Enabled = true;

                        if (checkId(Convert.ToInt32(lblId.Text)) >= 0)
                        {
                            int index = checkId(Convert.ToInt32(lblId.Text));
                            dtCTHD.Rows.RemoveAt(index);
                        }

                        int thanhTien = Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(lblGia.Text);
                        dtCTHD.Rows.Add(lblId.Text, lblTen.Text, lblGia.Text, txtSoLuong.Text, thanhTien.ToString());

                        int tongTien = 0;
                        for (int o = 0; o < dgvCTHD.Rows.Count; o++)
                        {
                            tongTien += Convert.ToInt32(dgvCTHD.Rows[o].Cells[4].Value);
                        }
                        txtTongTien.Text = tongTien.ToString();
                    }
                };

                FlowLayoutPanel flowLayoutPanel2 = new FlowLayoutPanel();
                flowLayoutPanel2.Width = 260;
                flowLayoutPanel2.Height = 500;
                flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel2.Controls.Add(lblTen);
                flowLayoutPanel2.Controls.Add(pic);
                flowLayoutPanel2.Controls.Add(lblGia);
                flowLayoutPanel2.Controls.Add(lblSLConLai);

                FlowLayoutPanel flowLayoutPanel3 = new FlowLayoutPanel();

                flowLayoutPanel3.Controls.Add(btnGiam);
                flowLayoutPanel3.Controls.Add(txtSoLuong);
                flowLayoutPanel3.Controls.Add(btnThem);
                flowLayoutPanel3.Dock = DockStyle.Bottom;
                flowLayoutPanel2.Controls.Add(flowLayoutPanel3);

                flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            btnTatCa.BackColor = Color.White;
            btnTatCa.ForeColor = Color.Black;

            btnDoAnSang.BackColor = Color.Navy;
            btnDoAnSang.ForeColor = Color.White;

            btnDoAnVat.BackColor = Color.Navy;
            btnDoAnVat.ForeColor = Color.White;
            
            btnDoUong.BackColor = Color.Navy;
            btnDoUong.ForeColor = Color.White;
            
            btnKhac.BackColor = Color.Navy;
            btnKhac.ForeColor = Color.White;

            flowLayoutPanel1.Controls.Clear();

            ArrayList listIdSP = new ArrayList();
            ArrayList listTenSP = new ArrayList();
            ArrayList listGia = new ArrayList();
            ArrayList listSLConLai = new ArrayList();
            ArrayList listHinhAnh = new ArrayList();

            for (int i = 0; i < SanPhamBUS.Instance.getSanPham().Rows.Count; i++)
            {
                listIdSP.Add(SanPhamBUS.Instance.getSanPham().Rows[i][0]);
                listTenSP.Add(SanPhamBUS.Instance.getSanPham().Rows[i][1]);
                listGia.Add(SanPhamBUS.Instance.getSanPham().Rows[i][2]);
                listSLConLai.Add(SanPhamBUS.Instance.getSanPham().Rows[i][3]);
                listHinhAnh.Add(SanPhamBUS.Instance.getSanPham().Rows[i][6]);
            }

            loadSanPham(listIdSP, listTenSP, listGia, listSLConLai, listHinhAnh);

        }

        private void btnDoAnSang_Click(object sender, EventArgs e)
        {
            btnTatCa.BackColor = Color.Navy;
            btnTatCa.ForeColor = Color.White;

            btnDoAnSang.BackColor = Color.White;
            btnDoAnSang.ForeColor = Color.Black;

            btnDoAnVat.BackColor = Color.Navy;
            btnDoAnVat.ForeColor = Color.White;

            btnDoUong.BackColor = Color.Navy;
            btnDoUong.ForeColor = Color.White;

            btnKhac.BackColor = Color.Navy;
            btnKhac.ForeColor = Color.White;


            flowLayoutPanel1.Controls.Clear();
            
            ArrayList listIdSP = new ArrayList();
            ArrayList listTenSP = new ArrayList();
            ArrayList listGia = new ArrayList();
            ArrayList listSLConLai = new ArrayList();
            ArrayList listHinhAnh = new ArrayList();

            for (int i = 0; i < SanPhamBUS.Instance.getSanPhamByLoai("DoAnSang").Rows.Count; i++)
            {
                listIdSP.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoAnSang").Rows[i][0]);
                listTenSP.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoAnSang").Rows[i][1]);
                listGia.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoAnSang").Rows[i][2]);
                listSLConLai.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoAnSang").Rows[i][3]);
                listHinhAnh.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoAnSang").Rows[i][6]);
            }

            loadSanPham(listIdSP, listTenSP, listGia, listSLConLai, listHinhAnh);
        }

        private void btnDoAnVat_Click(object sender, EventArgs e)
        {
            btnTatCa.BackColor = Color.Navy;
            btnTatCa.ForeColor = Color.White;

            btnDoAnSang.BackColor = Color.Navy;
            btnDoAnSang.ForeColor = Color.White;

            btnDoAnVat.BackColor = Color.White;
            btnDoAnVat.ForeColor = Color.Black;

            btnDoUong.BackColor = Color.Navy;
            btnDoUong.ForeColor = Color.White;

            btnKhac.BackColor = Color.Navy;
            btnKhac.ForeColor = Color.White;


            flowLayoutPanel1.Controls.Clear();

            ArrayList listIdSP = new ArrayList();
            ArrayList listTenSP = new ArrayList();
            ArrayList listGia = new ArrayList();
            ArrayList listSLConLai = new ArrayList();
            ArrayList listHinhAnh = new ArrayList();

            for (int i = 0; i < SanPhamBUS.Instance.getSanPhamByLoai("DoAnVat").Rows.Count; i++)
            {
                listIdSP.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoAnVat").Rows[i][0]);
                listTenSP.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoAnVat").Rows[i][1]);
                listGia.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoAnVat").Rows[i][2]);
                listSLConLai.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoAnVat").Rows[i][3]);
                listHinhAnh.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoAnVat").Rows[i][6]);
            }

            loadSanPham(listIdSP, listTenSP, listGia, listSLConLai, listHinhAnh);
        }

        private void btnDoUong_Click(object sender, EventArgs e)
        {
            btnTatCa.BackColor = Color.Navy;
            btnTatCa.ForeColor = Color.White;

            btnDoAnSang.BackColor = Color.Navy;
            btnDoAnSang.ForeColor = Color.White;

            btnDoAnVat.BackColor = Color.Navy;
            btnDoAnVat.ForeColor = Color.White;

            btnDoUong.BackColor = Color.White;
            btnDoUong.ForeColor = Color.Black;

            btnKhac.BackColor = Color.Navy;
            btnKhac.ForeColor = Color.White;


            flowLayoutPanel1.Controls.Clear(); 

            ArrayList listIdSP = new ArrayList();
            ArrayList listTenSP = new ArrayList();
            ArrayList listGia = new ArrayList();
            ArrayList listSLConLai = new ArrayList();
            ArrayList listHinhAnh = new ArrayList();

            for (int i = 0; i < SanPhamBUS.Instance.getSanPhamByLoai("DoUong").Rows.Count; i++)
            {
                listIdSP.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoUong").Rows[i][0]);
                listTenSP.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoUong").Rows[i][1]);
                listGia.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoUong").Rows[i][2]);
                listSLConLai.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoUong").Rows[i][3]);
                listHinhAnh.Add(SanPhamBUS.Instance.getSanPhamByLoai("DoUong").Rows[i][6]);
            }

            loadSanPham(listIdSP, listTenSP, listGia, listSLConLai, listHinhAnh);
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            btnTatCa.BackColor = Color.Navy;
            btnTatCa.ForeColor = Color.White;

            btnDoAnSang.BackColor = Color.Navy;
            btnDoAnSang.ForeColor = Color.White;

            btnDoAnVat.BackColor = Color.Navy;
            btnDoAnVat.ForeColor = Color.White;

            btnDoUong.BackColor = Color.Navy;
            btnDoUong.ForeColor = Color.White;

            btnKhac.BackColor = Color.White;
            btnKhac.ForeColor = Color.Black;


            flowLayoutPanel1.Controls.Clear(); 

            ArrayList listIdSP = new ArrayList();
            ArrayList listTenSP = new ArrayList();
            ArrayList listGia = new ArrayList();
            ArrayList listSLConLai = new ArrayList();
            ArrayList listHinhAnh = new ArrayList();

            for (int i = 0; i < SanPhamBUS.Instance.getSanPhamByLoai("Khac").Rows.Count; i++)
            {
                listIdSP.Add(SanPhamBUS.Instance.getSanPhamByLoai("Khac").Rows[i][0]);
                listTenSP.Add(SanPhamBUS.Instance.getSanPhamByLoai("Khac").Rows[i][1]);
                listGia.Add(SanPhamBUS.Instance.getSanPhamByLoai("Khac").Rows[i][2]);
                listSLConLai.Add(SanPhamBUS.Instance.getSanPhamByLoai("Khac").Rows[i][3]);
                listHinhAnh.Add(SanPhamBUS.Instance.getSanPhamByLoai("Khac").Rows[i][6]);
            }

            loadSanPham(listIdSP, listTenSP, listGia, listSLConLai, listHinhAnh);
        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            for (int j = 0; j < dgvCTHD.Rows.Count; j++)
            {
                tongTien += Convert.ToInt32(dgvCTHD.Rows[j].Cells[4].Value);
            }
            txtTongTien.Text = tongTien.ToString();
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvCTHD.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.Rows.Count > 1)
            {
                frmHoaDon frmHoaDon = new frmHoaDon(dtCTHD, Convert.ToInt32(txtTongTien.Text));
                frmHoaDon.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private int checkId(int id)
        {
            int index = -1;
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                if (id == Convert.ToInt32(dgvCTHD.Rows[i].Cells[0].Value))
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }
            return index;
        }
    }
}
