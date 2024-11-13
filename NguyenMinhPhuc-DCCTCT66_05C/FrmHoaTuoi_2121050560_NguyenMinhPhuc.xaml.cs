using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NguyenMinhPhuc_DCCTCT66_05C
{
    /// <summary>
    /// Interaction logic for FrmHoaTuoi_2121050560_NguyenMinhPhuc.xaml
    /// </summary>
    public partial class FrmHoaTuoi_2121050560_NguyenMinhPhuc : Window {
        private string connectionString = "Server=DESKTOP-U7LD9P5;Database=QLHoaTuoi;Trusted_Connection=True;";
        public FrmHoaTuoi_2121050560_NguyenMinhPhuc()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaTuoi", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDanhSach.ItemsSource = dt.DefaultView;
            }
        }


        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                string query = "SELECT * FROM HoaTuoi WHERE 1=1";

                if (!string.IsNullOrEmpty(txtMaHoaTuoi.Text)) query += $" AND MaHoaTuoi LIKE '%{txtMaHoaTuoi.Text}%'";

                if (!string.IsNullOrEmpty(txtTenHoaTuoi.Text)) query += $" AND TenHoaTuoi LIKE '%{txtTenHoaTuoi.Text}%'";


                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvDanhSach.ItemsSource = dt.DefaultView;

            }
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaHoaTuoi.Text))
            {
                btnSua_Click(sender, e); // Call btnSua_Click to save changes
            }
            else
            {
                btnThem_Click(sender, e); // Call btnThem_Click to insert new record
            }
        }


        private void dgvDanhSach_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgvDanhSach.SelectedItem != null)
            {
                DataRowView row = (DataRowView)dgvDanhSach.SelectedItem;
                txtMaHoaTuoi.Text = row["MaHoaTuoi"].ToString();
                txtTenHoaTuoi.Text = row["TenHoaTuoi"].ToString();
                dtpNgaySX.SelectedDate = DateTime.Parse(row["NgaySX"].ToString());
                dtpNgayHH.SelectedDate = DateTime.Parse(row["NgayHH"].ToString());
                txtDonVi.Text = row["DonVi"].ToString();
                txtDonGia.Text = row["DonGia"].ToString();
                txtGhiChu.Text = row["GhiChu"].ToString();
            }
        }


        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            txtMaHoaTuoi.Clear();
            txtTenHoaTuoi.Clear();
            dtpNgaySX.SelectedDate = null;
            dtpNgayHH.SelectedDate = null;
            txtDonVi.Clear();
            txtDonGia.Clear();
            txtGhiChu.Clear();
        }


        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO HoaTuoi (MaHoaTuoi, TenHoaTuoi, NgaySX, NgayHH, DonVi, DonGia, GhiChu) " +
                           "VALUES (@MaHoaTuoi, @TenHoaTuoi, @NgaySX, @NgayHH, @DonVi, @DonGia, @GhiChu)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHoaTuoi", txtMaHoaTuoi.Text);
                cmd.Parameters.AddWithValue("@TenHoaTuoi", txtTenHoaTuoi.Text);
                cmd.Parameters.AddWithValue("@NgaySX", dtpNgaySX.SelectedDate.Value);
                cmd.Parameters.AddWithValue("@NgayHH", dtpNgayHH.SelectedDate.Value);
                cmd.Parameters.AddWithValue("@DonVi", txtDonVi.Text);
                cmd.Parameters.AddWithValue("@DonGia", double.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadData(); // Reload the data after insert
        }


        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            string query = "UPDATE HoaTuoi SET TenHoaTuoi = @TenHoaTuoi, NgaySX = @NgaySX, NgayHH = @NgayHH, " +
                           "DonVi = @DonVi, DonGia = @DonGia, GhiChu = @GhiChu WHERE MaHoaTuoi = @MaHoaTuoi";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHoaTuoi", txtMaHoaTuoi.Text);
                cmd.Parameters.AddWithValue("@TenHoaTuoi", txtTenHoaTuoi.Text);
                cmd.Parameters.AddWithValue("@NgaySX", dtpNgaySX.SelectedDate.Value);
                cmd.Parameters.AddWithValue("@NgayHH", dtpNgayHH.SelectedDate.Value);
                cmd.Parameters.AddWithValue("@DonVi", txtDonVi.Text);
                cmd.Parameters.AddWithValue("@DonGia", double.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadData(); // Reload the data after update
        }


        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                string query = "DELETE FROM HoaTuoi WHERE MaHoaTuoi = @MaHoaTuoi";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHoaTuoi", txtMaHoaTuoi.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                LoadData(); // Reload the data after delete
            }
        }

    }
}
