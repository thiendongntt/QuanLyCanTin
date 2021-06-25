using BUS;
using DTO;
using System;
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
    public partial class UserChamCongControl : UserControl
    {
        int idNV;
        public UserChamCongControl()
        {
            InitializeComponent();

            cbbCaTruc.Items.Add("Sáng");
            cbbCaTruc.Items.Add("Chiều");
            cbbCaTruc.Items.Add("Tối");

            load();
        }

        public void load()
        {
            dgvNhanVien.DataSource = ChamCongBUS.Instance.getNhanVien();
            dgvChamCong.DataSource = ChamCongBUS.Instance.getChamCong();

            dtpNgayLam.Value = DateTime.Now;
            cbbCaTruc.SelectedIndex = 0;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhanVien.CurrentRow.Index;
            idNV = Convert.ToInt32(dgvNhanVien.Rows[index].Cells[0].Value);
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (idNV > 0)
            {
                ChamCongDTO cc = new ChamCongDTO(idNV, dtpNgayLam.Value.Date, cbbCaTruc.SelectedItem.ToString());
                if (ChamCongBUS.Instance.createChamCong(cc))
                {
                    MessageBox.Show("Chấm công thành công");
                }
                else
                {
                    MessageBox.Show("Chấm công thất bại");
                }
                load();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }

        }
    }
}
