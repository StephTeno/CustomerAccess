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
        List<string> idcreados = new List<string>();
        bool propio = false;    
        string connectionString = ConfigurationManager.ConnectionStrings["WinAdo.Properties.Settings.Connection"].ConnectionString;
        public frmAdo()
        {
            InitializeComponent();
            LeerDatos();
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
            if (ValidarTextBoxes(this))
            {
                InsertarClientes();
            }
            else
            {
                MessageBox.Show("Llene todos los campos de forma correcta");
            }
        }
        
        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (idcreados.Count != 0)
            {
                for (int i = 0; i < idcreados.Count; i++)
                {
                    if (txtIDCliente.Text == idcreados[i])
                    {
                        propio = true;
                    }
                    else
                    {
                        propio = false;
                    }
                }
                if (propio)
                {
                    EliminarClients();
                }
                else
                {
                    MessageBox.Show("Elimine un registro que usted haya creado");
                }
            }
            else
            {
                MessageBox.Show("Ingrese por lo menos un registro propio");
            }
        }
        
        private void btnACTUALIZAR_Click(object sender, EventArgs e)
        {
            if (ValidarTextBoxes(this))
            {
                UpdateClients();
            }
            else
            {
                MessageBox.Show("Llene todos los campos de forma correcta");
            }
        }
        
        #region Funciones
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
        private void LeerDatos()
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
        private void InsertarClientes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string queryString = "INSERT INTO Customers(CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)" +
                    "VALUES('" + txtIDCliente.Text + "', '" + txtCompanyName.Text + "', '" + txtContactName.Text + "', '" + txtContactTitle.Text + "', '"
                    + txtAddress.Text + "', '" + txtCity.Text + "', '" + txtRegion.Text + "', '" + txtPostalCode.Text + "', '" + txtCountry.Text + "', '"
                    + txtPhone.Text + "', '" + txtFax.Text + "')";
                    idcreados.Add(txtIDCliente.Text);
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente guardado correctamente");
                    LimpiarTextBoxes(this);
                    LeerDatos();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void EliminarClients()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    if (txtIDCliente.Text != string.Empty)
                    {
                        string queryString = "DELETE FROM Customers WHERE CustomerID = '" + txtIDCliente.Text + "'";
                        SqlCommand cmd = new SqlCommand(queryString, connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente eliminado correctamente");
                        LimpiarTextBoxes(this);
                        LeerDatos();
                    }
                    else
                    {
                        MessageBox.Show("Selecione un registro");
                    }
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                        "Phone = '" + txtPhone.Text + "', Fax = '" + txtFax.Text + "' WHERE CustomerID = '" + txtIDCliente.Text + "'";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente actualizado correctamente");
                    LimpiarTextBoxes(this);
                    LeerDatos();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Validaciones
        //Aqui comienzan las Validaciones de campos vacios

        private void txtCompanyName_Validated(object sender, EventArgs e)
        {
            if (txtCompanyName.Text.Trim() == "")
            {
                erpError.SetError(txtCompanyName, "Campos Vacios, Ingrese los datos...");
                txtCompanyName.Focus();
            }
            else
            {
                erpError.Clear();
            }
        }

        private void txtContactName_Validated(object sender, EventArgs e)
        {
            if (txtContactName.Text.Trim() == "")
            {
                erpError.SetError(txtContactName, "Campos Vacios, Ingrese los datos...");
                txtContactName.Focus();
            }
            else { erpError.Clear(); }
        }

        private void txtContactTitle_Validated(object sender, EventArgs e)
        {
            if (txtContactTitle.Text.Trim() == "")
            {
                erpError.SetError(txtContactTitle, "Campos Vacios, Ingrese los datos...");
                txtContactTitle.Focus();
            }
            else { erpError.Clear(); }
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() == "")
            {
                erpError.SetError(txtAddress, "Campos Vacios, Ingrese los datos...");
                txtAddress.Focus();
            }
            else { erpError.Clear(); }
        }

        private void txtCity_Validated(object sender, EventArgs e)
        {
            if (txtCity.Text.Trim() == "")
            {
                erpError.SetError(txtCity, "Campos Vacios, Ingrese los datos...");
                txtCity.Focus();
            }
            else { erpError.Clear(); }
        }

        private void txtIDCliente_Validated(object sender, EventArgs e)
        {
            if (txtIDCliente.Text.Trim() == "")
            {
                erpError.SetError(txtIDCliente, "Campos Vacios, Ingrese los datos...");
                txtIDCliente.Focus();
            }
            else { erpError.Clear(); }
        }

        private void txtRegion_Validated(object sender, EventArgs e)
        {
            if (txtRegion.Text.Trim() == "")
            {
                erpError.SetError(txtRegion, "Campos Vacios, Ingrese los datos...");
                txtRegion.Focus();
            }
            else { erpError.Clear(); }
        }

        private void txtPostalCode_Validated(object sender, EventArgs e)
        {
            if (txtPostalCode.Text.Trim() == "")
            {
                erpError.SetError(txtPostalCode, "Campos Vacios, Ingrese los datos...");
                txtPostalCode.Focus();
            }
            else { erpError.Clear(); }
        }

        private void txtCountry_Validated(object sender, EventArgs e)
        {
            if (txtCountry.Text.Trim() == "")
            {
                erpError.SetError(txtCountry, "Campos Vacios, Ingrese los datos...");
                txtCountry.Focus();
            }
            else { erpError.Clear(); }
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            if (txtPhone.Text.Trim() == "")
            {
                erpError.SetError(txtPhone, "Campos Vacios, Ingrese los datos...");
                txtPhone.Focus();
            }
            else { erpError.Clear(); }
        }

        private void txtFax_Validated(object sender, EventArgs e)
        {
            if (txtFax.Text.Trim() == "")
            {
                erpError.SetError(txtFax, "Campos Vacios, Ingrese los datos...");
                txtFax.Focus();
            }
            else { erpError.Clear(); }
        }//Aqui terminan las Validaciones de campos vacios


        //Aqui comienzan las Validaciones de solo letras
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }//Aqui terminan las Validaciones de solo letras


        //Aqui comienzan las Validaciones de solo numeros
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }//Aqui terminan las Validaciones de solo numeros

        public bool ValidarTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)c).Text))
                    {
                        return false;
                    }
                }
                if (c.HasChildren)
                {
                    if (!ValidarTextBoxes(c))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region ComponentesVisualesLlamativos
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
        #endregion
    }
}