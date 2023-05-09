using System.Configuration;
using System.Data;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Metrics;
using System.Net;

namespace WinAdo
{
    public partial class frmAdo : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["WinAdo.Properties.Settings.Connection"].ConnectionString;
        public frmAdo()
        {
            InitializeComponent();
            GetClients();
        }
        //[ Esto es para que se pueda mover nuestro formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void brTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void GetClients()
        {
            string queryString = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax " +
                                 "FROM Customers ORDER BY CompanyName ASC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvDatos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDatos.Rows[e.RowIndex];
                txtIDCliente.Text = row.Cells["CustomerID"].Value.ToString();
                txtCompanyName.Text = row.Cells["CompanyName"].Value.ToString();
                txtContactName.Text = row.Cells["ContactName"].Value.ToString();
                txtContactTitle.Text = row.Cells["ContactTitle"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
                txtRegion.Text = row.Cells["Region"].Value.ToString();
                txtPostalCode.Text = row.Cells["PostalCode"].Value.ToString();
                txtCountry.Text = row.Cells["Country"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtFax.Text = row.Cells["Fax"].Value.ToString();
            }
        }

        private void btnCREAR_Click(object sender, EventArgs e)
        {
            InsertClientes();
        }
        private void InsertClientes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string queryString = "INSERT INTO Customers(CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)" +
                    "VALUES('" + txtIDCliente.Text + "', '" + txtCompanyName.Text + "', '" + txtContactName.Text + "', '" + txtContactTitle.Text + "', '"
                    + txtAddress.Text + "', '" + txtCity.Text + "', '" + txtRegion.Text + "', '" + txtPostalCode.Text + "', '" + txtCountry.Text + "', '"
                    + txtPhone.Text + "', '" + txtFax.Text + "')";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente guardado correctamente");
                    LimpiarTextBoxes(this);
                    GetClients();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            DeleteClients();
        }
        private void DeleteClients()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string queryString = "DELETE FROM Customers WHERE CustomerID = '" + txtIDCliente.Text + "'";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente eliminado correctamente");
                    LimpiarTextBoxes(this);
                    GetClients();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnACTUALIZAR_Click(object sender, EventArgs e)
        {
            UpdateClients();
        }
        private void UpdateClients()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string queryString = "UPDATE Customers SET CompanyName = '" + txtCompanyName.Text
                        + "', ContactName = '" + txtContactName.Text + "', ContactTitle = '" + txtContactTitle.Text + "', Address = '" + txtAddress.Text + "', " +
                        "City = '" + txtCity.Text + "', Region = '" + txtRegion.Text + "', PostalCode = '" + txtPostalCode.Text + "', Country = '" + txtCountry.Text + "', " +
                        "Phone = '" + txtPhone.Text + "', Fax = '" + txtFax.Text + "' WHERE CustomerID = '" + txtIDCliente.Text+"'";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente actualizado correctamente");
                    LimpiarTextBoxes(this);
                    GetClients();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LimpiarTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    LimpiarTextBoxes(c);
                }
            }
        }
    }
}