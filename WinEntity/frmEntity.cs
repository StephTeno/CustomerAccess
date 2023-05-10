using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinEntity.Data;
using WinEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace WinEntity
{
    public partial class frmEntity : Form
    {
        private static int id = 0;
        Customer? cus = null;
        public frmEntity()
        {
            InitializeComponent();
            Refrescar();
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
        private void Refrescar()
        {
            using (var context = new NorthwindContext())
            {
                var lst = context.Customers.OrderBy(c => c.CustomerId);
                dgvDatos.DataSource = lst.ToList();
            }
        }

        private void Guardar()
        {
            using (var context = new NorthwindContext())
            {
                cus = new Customer();
                cus.CustomerId = txtIDCliente.Text;
                cus.CompanyName = txtCompanyName.Text;
                cus.ContactName = txtContactName.Text;
                cus.ContactTitle = txtContactTitle.Text;
                cus.Address = txtAddress.Text;
                cus.City = txtCity.Text;
                cus.Region = txtRegion.Text;
                cus.PostalCode = txtPostalCode.Text;
                cus.Country = txtCountry.Text;
                cus.Phone = txtPhone.Text;
                cus.Fax = txtFax.Text;
                context.Customers.Add(cus);
                context.SaveChanges();
                LimpiarTextBoxes(this);
                MessageBox.Show("Cliente Agregado");
                Refrescar();
            }
        }
        private void ObtenerDatos(int key)
        {
            using (var context = new NorthwindContext())
            {
                cus = context.Customers.Find(key);
                txtIDCliente.Text = cus.CustomerId;
                txtCompanyName.Text = cus.CompanyName;
                txtContactName.Text = cus.ContactName;
                txtContactTitle.Text = cus.ContactTitle;
                txtAddress.Text = cus.Address;
                txtCity.Text = cus.City;
                txtRegion.Text = cus.Region;
                txtPostalCode.Text = cus.PostalCode;
                txtCountry.Text = cus.Country;
                txtPhone.Text = cus.Phone;
                txtFax.Text = cus.Fax;
            }
        }

        private void Actualizar()
        {
            if (id != 0)
            {
                using (var context = new NorthwindContext())
                {
                    cus.CustomerId = txtIDCliente.Text;
                    cus.CompanyName = txtCompanyName.Text;
                    cus.ContactName = txtContactName.Text;
                    cus.ContactTitle = txtContactTitle.Text;
                    cus.Address = txtAddress.Text;
                    cus.City = txtCity.Text;
                    cus.Region = txtRegion.Text;
                    cus.PostalCode = txtPostalCode.Text;
                    cus.Country = txtCountry.Text;
                    cus.Phone = txtPhone.Text;
                    cus.Fax = txtFax.Text;
                    context.Entry(cus).State = EntityState.Modified;
                    context.SaveChanges();
                }
                LimpiarTextBoxes(this);
                MessageBox.Show("Se ha actualizado correctamente");
                Refrescar();
            }
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

        private void btnCREAR_Click(object sender, EventArgs e)
        {
            if (ValidarTextBoxes(this))
            {
                Guardar();
            }
            else
            {
                MessageBox.Show("Llene todos los campos de forma correcta");
            }
        }

        private void dgvDatos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDatos.Rows)
            {
                if (r.Index == e.RowIndex)
                {
                    id = int.Parse(r.Cells[0].Value.ToString()!);
                    ObtenerDatos(id);
                }
            }
        }

        private void btnACTUALIZAR_Click(object sender, EventArgs e)
        {
            if (ValidarTextBoxes(this))
            {
                Actualizar();
            }
            else
            {
                MessageBox.Show("Llene todos los campos de forma correcta");
            }
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (var context = new NorthwindContext())
                {
                    Customer cu = context.Customers.Find(id);
                    context.Customers.Remove(cu);
                    context.SaveChanges();
                }
                LimpiarTextBoxes(this);
                MessageBox.Show("Se ha eliminado correctamente");
                Refrescar();
            }
        }
    }
}
