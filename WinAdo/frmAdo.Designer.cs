namespace WinAdo
{
    partial class frmAdo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdo));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCREAR = new System.Windows.Forms.Button();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnACTUALIZAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.gbRegistrar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.brTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gbRegistrar.SuspendLayout();
            this.brTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatos.ColumnHeadersHeight = 45;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDatos.Location = new System.Drawing.Point(0, 440);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatos.RowHeadersWidth = 62;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDatos.RowTemplate.Height = 33;
            this.dgvDatos.Size = new System.Drawing.Size(1047, 333);
            this.dgvDatos.TabIndex = 19;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCompanyName.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtCompanyName.ForeColor = System.Drawing.Color.White;
            this.txtCompanyName.Location = new System.Drawing.Point(261, 39);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(214, 32);
            this.txtCompanyName.TabIndex = 20;
            this.txtCompanyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            this.txtCompanyName.Validated += new System.EventHandler(this.txtCompanyName_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre de empresa";
            // 
            // txtContactName
            // 
            this.txtContactName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtContactName.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtContactName.ForeColor = System.Drawing.Color.White;
            this.txtContactName.Location = new System.Drawing.Point(261, 85);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(214, 32);
            this.txtContactName.TabIndex = 22;
            this.txtContactName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            this.txtContactName.Validated += new System.EventHandler(this.txtContactName_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre de contacto";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtContactTitle.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtContactTitle.ForeColor = System.Drawing.Color.White;
            this.txtContactTitle.Location = new System.Drawing.Point(261, 133);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(214, 32);
            this.txtContactTitle.TabIndex = 24;
            this.txtContactTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            this.txtContactTitle.Validated += new System.EventHandler(this.txtContactTitle_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Título de contacto";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(261, 181);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 32);
            this.txtAddress.TabIndex = 26;
            this.txtAddress.Validated += new System.EventHandler(this.txtAddress_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dirección";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(261, 229);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(214, 32);
            this.txtCity.TabIndex = 32;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            this.txtCity.Validated += new System.EventHandler(this.txtCity_Validated);
            // 
            // txtRegion
            // 
            this.txtRegion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtRegion.ForeColor = System.Drawing.Color.White;
            this.txtRegion.Location = new System.Drawing.Point(723, 30);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(214, 42);
            this.txtRegion.TabIndex = 33;
            this.txtRegion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            this.txtRegion.Validated += new System.EventHandler(this.txtRegion_Validated);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtPostalCode.ForeColor = System.Drawing.Color.White;
            this.txtPostalCode.Location = new System.Drawing.Point(723, 78);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(214, 42);
            this.txtPostalCode.TabIndex = 34;
            this.txtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            this.txtPostalCode.Validated += new System.EventHandler(this.txtPostalCode_Validated);
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCountry.ForeColor = System.Drawing.Color.White;
            this.txtCountry.Location = new System.Drawing.Point(723, 126);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(214, 42);
            this.txtCountry.TabIndex = 35;
            this.txtCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            this.txtCountry.Validated += new System.EventHandler(this.txtCountry_Validated);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(723, 174);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(214, 42);
            this.txtPhone.TabIndex = 36;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            this.txtPhone.Validated += new System.EventHandler(this.txtPhone_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(43, 241);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 23);
            this.label10.TabIndex = 37;
            this.label10.Text = "Ciudad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(577, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Region";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(577, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Código Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(577, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "País";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(577, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Teléfono";
            // 
            // btnCREAR
            // 
            this.btnCREAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCREAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCREAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCREAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCREAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCREAR.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCREAR.ForeColor = System.Drawing.Color.White;
            this.btnCREAR.Location = new System.Drawing.Point(577, 307);
            this.btnCREAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCREAR.Name = "btnCREAR";
            this.btnCREAR.Size = new System.Drawing.Size(120, 50);
            this.btnCREAR.TabIndex = 42;
            this.btnCREAR.Text = "CREAR";
            this.btnCREAR.UseVisualStyleBackColor = true;
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtFax.ForeColor = System.Drawing.Color.White;
            this.txtFax.Location = new System.Drawing.Point(723, 222);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(214, 42);
            this.txtFax.TabIndex = 43;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            this.txtFax.Validated += new System.EventHandler(this.txtFax_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(577, 241);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 23);
            this.label11.TabIndex = 44;
            this.label11.Text = "Fax";
            // 
            // btnACTUALIZAR
            // 
            this.btnACTUALIZAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnACTUALIZAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnACTUALIZAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnACTUALIZAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACTUALIZAR.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnACTUALIZAR.ForeColor = System.Drawing.Color.White;
            this.btnACTUALIZAR.Location = new System.Drawing.Point(732, 307);
            this.btnACTUALIZAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnACTUALIZAR.Name = "btnACTUALIZAR";
            this.btnACTUALIZAR.Size = new System.Drawing.Size(151, 50);
            this.btnACTUALIZAR.TabIndex = 46;
            this.btnACTUALIZAR.Text = "ACTUALIZAR";
            this.btnACTUALIZAR.UseVisualStyleBackColor = true;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELIMINAR.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnELIMINAR.ForeColor = System.Drawing.Color.White;
            this.btnELIMINAR.Location = new System.Drawing.Point(916, 307);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(120, 50);
            this.btnELIMINAR.TabIndex = 47;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            // 
            // gbRegistrar
            // 
            this.gbRegistrar.Controls.Add(this.label1);
            this.gbRegistrar.Controls.Add(this.txtIDCliente);
            this.gbRegistrar.Controls.Add(this.btnELIMINAR);
            this.gbRegistrar.Controls.Add(this.btnACTUALIZAR);
            this.gbRegistrar.Controls.Add(this.label11);
            this.gbRegistrar.Controls.Add(this.txtFax);
            this.gbRegistrar.Controls.Add(this.btnCREAR);
            this.gbRegistrar.Controls.Add(this.label6);
            this.gbRegistrar.Controls.Add(this.label7);
            this.gbRegistrar.Controls.Add(this.label8);
            this.gbRegistrar.Controls.Add(this.label9);
            this.gbRegistrar.Controls.Add(this.label10);
            this.gbRegistrar.Controls.Add(this.txtPhone);
            this.gbRegistrar.Controls.Add(this.txtCountry);
            this.gbRegistrar.Controls.Add(this.txtPostalCode);
            this.gbRegistrar.Controls.Add(this.txtRegion);
            this.gbRegistrar.Controls.Add(this.txtCity);
            this.gbRegistrar.Controls.Add(this.label5);
            this.gbRegistrar.Controls.Add(this.txtAddress);
            this.gbRegistrar.Controls.Add(this.label4);
            this.gbRegistrar.Controls.Add(this.txtContactTitle);
            this.gbRegistrar.Controls.Add(this.label3);
            this.gbRegistrar.Controls.Add(this.txtContactName);
            this.gbRegistrar.Controls.Add(this.label2);
            this.gbRegistrar.Controls.Add(this.txtCompanyName);
            this.gbRegistrar.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbRegistrar.ForeColor = System.Drawing.Color.White;
            this.gbRegistrar.Location = new System.Drawing.Point(0, 53);
            this.gbRegistrar.Name = "gbRegistrar";
            this.gbRegistrar.Size = new System.Drawing.Size(1047, 378);
            this.gbRegistrar.TabIndex = 22;
            this.gbRegistrar.TabStop = false;
            this.gbRegistrar.Text = "REGISTRAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Código de Cliente";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtIDCliente.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtIDCliente.ForeColor = System.Drawing.Color.White;
            this.txtIDCliente.Location = new System.Drawing.Point(261, 287);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(115, 32);
            this.txtIDCliente.TabIndex = 51;
            this.txtIDCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            this.txtIDCliente.Validated += new System.EventHandler(this.txtIDCliente_Validated);
            // 
            // brTitulo
            // 
            this.brTitulo.BackColor = System.Drawing.Color.Navy;
            this.brTitulo.Controls.Add(this.btnMinimizar);
            this.brTitulo.Controls.Add(this.btnCerrar);
            this.brTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.brTitulo.Location = new System.Drawing.Point(0, 0);
            this.brTitulo.Name = "brTitulo";
            this.brTitulo.Size = new System.Drawing.Size(1047, 47);
            this.brTitulo.TabIndex = 23;
            this.brTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.brTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(969, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 50;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageLocation = "";
            this.btnCerrar.Location = new System.Drawing.Point(1010, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 51;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // frmAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1047, 773);
            this.Controls.Add(this.brTitulo);
            this.Controls.Add(this.gbRegistrar);
            this.Controls.Add(this.dgvDatos);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gbRegistrar.ResumeLayout(false);
            this.gbRegistrar.PerformLayout();
            this.brTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDatos;
        private TextBox txtCompanyName;
        private Label label2;
        private TextBox txtContactName;
        private Label label3;
        private TextBox txtContactTitle;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtCity;
        private TextBox txtRegion;
        private TextBox txtPostalCode;
        private TextBox txtCountry;
        private TextBox txtPhone;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnCREAR;
        private TextBox txtFax;
        private Label label11;
        private Button btnACTUALIZAR;
        private Button btnELIMINAR;
        private GroupBox gbRegistrar;
        private Panel brTitulo;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Label label1;
        private TextBox txtIDCliente;
        private ErrorProvider erpError;
    }
}