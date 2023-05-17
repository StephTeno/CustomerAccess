namespace WinEntity
{
    partial class frmEntity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntity));
            dgvDatos = new DataGridView();
            brTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            gbRegistrar = new GroupBox();
            label1 = new Label();
            txtIDCliente = new TextBox();
            btnELIMINAR = new Button();
            btnACTUALIZAR = new Button();
            label11 = new Label();
            txtFax = new TextBox();
            btnCREAR = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtPhone = new TextBox();
            txtCountry = new TextBox();
            txtPostalCode = new TextBox();
            txtRegion = new TextBox();
            txtCity = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtContactTitle = new TextBox();
            label3 = new Label();
            txtContactName = new TextBox();
            label2 = new Label();
            txtCompanyName = new TextBox();
            erpError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            brTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            gbRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDatos.BackgroundColor = Color.CornflowerBlue;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDatos.ColumnHeadersHeight = 45;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDatos.Dock = DockStyle.Bottom;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.GridColor = Color.SteelBlue;
            dgvDatos.Location = new Point(0, 440);
            dgvDatos.Margin = new Padding(2);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDatos.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvDatos.RowTemplate.Height = 33;
            dgvDatos.Size = new Size(1047, 333);
            dgvDatos.TabIndex = 19;
            dgvDatos.CellClick += dgvDatos_CellClick_1;
            // 
            // brTitulo
            // 
            brTitulo.BackColor = Color.Navy;
            brTitulo.Controls.Add(btnMinimizar);
            brTitulo.Controls.Add(btnCerrar);
            brTitulo.Dock = DockStyle.Top;
            brTitulo.Location = new Point(0, 0);
            brTitulo.Name = "brTitulo";
            brTitulo.Size = new Size(1047, 47);
            brTitulo.TabIndex = 23;
            brTitulo.MouseDown += brTitulo_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(969, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 52;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.ImageLocation = "";
            btnCerrar.Location = new Point(1010, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 53;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // gbRegistrar
            // 
            gbRegistrar.Controls.Add(label1);
            gbRegistrar.Controls.Add(txtIDCliente);
            gbRegistrar.Controls.Add(btnELIMINAR);
            gbRegistrar.Controls.Add(btnACTUALIZAR);
            gbRegistrar.Controls.Add(label11);
            gbRegistrar.Controls.Add(txtFax);
            gbRegistrar.Controls.Add(btnCREAR);
            gbRegistrar.Controls.Add(label6);
            gbRegistrar.Controls.Add(label7);
            gbRegistrar.Controls.Add(label8);
            gbRegistrar.Controls.Add(label9);
            gbRegistrar.Controls.Add(label10);
            gbRegistrar.Controls.Add(txtPhone);
            gbRegistrar.Controls.Add(txtCountry);
            gbRegistrar.Controls.Add(txtPostalCode);
            gbRegistrar.Controls.Add(txtRegion);
            gbRegistrar.Controls.Add(txtCity);
            gbRegistrar.Controls.Add(label5);
            gbRegistrar.Controls.Add(txtAddress);
            gbRegistrar.Controls.Add(label4);
            gbRegistrar.Controls.Add(txtContactTitle);
            gbRegistrar.Controls.Add(label3);
            gbRegistrar.Controls.Add(txtContactName);
            gbRegistrar.Controls.Add(label2);
            gbRegistrar.Controls.Add(txtCompanyName);
            gbRegistrar.Font = new Font("Century Gothic", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            gbRegistrar.ForeColor = Color.White;
            gbRegistrar.Location = new Point(0, 53);
            gbRegistrar.Name = "gbRegistrar";
            gbRegistrar.Size = new Size(1047, 378);
            gbRegistrar.TabIndex = 24;
            gbRegistrar.TabStop = false;
            gbRegistrar.Text = "REGISTRAR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 296);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 17);
            label1.TabIndex = 50;
            label1.Text = "Código de Cliente";
            // 
            // txtIDCliente
            // 
            txtIDCliente.BackColor = Color.CornflowerBlue;
            txtIDCliente.Font = new Font("Century Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtIDCliente.ForeColor = Color.White;
            txtIDCliente.Location = new Point(261, 287);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(115, 24);
            txtIDCliente.TabIndex = 51;
            txtIDCliente.KeyPress += SoloLetras;
            txtIDCliente.Validated += txtIDCliente_Validated;
            // 
            // btnELIMINAR
            // 
            btnELIMINAR.Cursor = Cursors.Hand;
            btnELIMINAR.FlatAppearance.BorderColor = Color.White;
            btnELIMINAR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnELIMINAR.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnELIMINAR.FlatStyle = FlatStyle.Flat;
            btnELIMINAR.Font = new Font("Century Gothic", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnELIMINAR.ForeColor = Color.White;
            btnELIMINAR.Location = new Point(916, 307);
            btnELIMINAR.Margin = new Padding(2);
            btnELIMINAR.Name = "btnELIMINAR";
            btnELIMINAR.Size = new Size(120, 50);
            btnELIMINAR.TabIndex = 47;
            btnELIMINAR.Text = "ELIMINAR";
            btnELIMINAR.UseVisualStyleBackColor = true;
            btnELIMINAR.Click += btnELIMINAR_Click;
            // 
            // btnACTUALIZAR
            // 
            btnACTUALIZAR.Cursor = Cursors.Hand;
            btnACTUALIZAR.FlatAppearance.BorderColor = Color.White;
            btnACTUALIZAR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnACTUALIZAR.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnACTUALIZAR.FlatStyle = FlatStyle.Flat;
            btnACTUALIZAR.Font = new Font("Century Gothic", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnACTUALIZAR.ForeColor = Color.White;
            btnACTUALIZAR.Location = new Point(732, 307);
            btnACTUALIZAR.Margin = new Padding(2);
            btnACTUALIZAR.Name = "btnACTUALIZAR";
            btnACTUALIZAR.Size = new Size(151, 50);
            btnACTUALIZAR.TabIndex = 46;
            btnACTUALIZAR.Text = "ACTUALIZAR";
            btnACTUALIZAR.UseVisualStyleBackColor = true;
            btnACTUALIZAR.Click += btnACTUALIZAR_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(577, 241);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(32, 17);
            label11.TabIndex = 44;
            label11.Text = "Fax";
            // 
            // txtFax
            // 
            txtFax.BackColor = Color.CornflowerBlue;
            txtFax.ForeColor = Color.White;
            txtFax.Location = new Point(723, 222);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(214, 30);
            txtFax.TabIndex = 43;
            txtFax.KeyPress += SoloNumeros;
            txtFax.Validated += txtFax_Validated;
            // 
            // btnCREAR
            // 
            btnCREAR.Cursor = Cursors.Hand;
            btnCREAR.FlatAppearance.BorderColor = Color.White;
            btnCREAR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCREAR.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCREAR.FlatStyle = FlatStyle.Flat;
            btnCREAR.Font = new Font("Century Gothic", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCREAR.ForeColor = Color.White;
            btnCREAR.Location = new Point(577, 307);
            btnCREAR.Margin = new Padding(2);
            btnCREAR.Name = "btnCREAR";
            btnCREAR.Size = new Size(120, 50);
            btnCREAR.TabIndex = 42;
            btnCREAR.Text = "CREAR";
            btnCREAR.UseVisualStyleBackColor = true;
            btnCREAR.Click += btnCREAR_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(577, 193);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 41;
            label6.Text = "Teléfono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(577, 145);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 17);
            label7.TabIndex = 40;
            label7.Text = "País";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(577, 97);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 17);
            label8.TabIndex = 39;
            label8.Text = "Código Postal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(577, 49);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 17);
            label9.TabIndex = 38;
            label9.Text = "Region";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(43, 241);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(58, 17);
            label10.TabIndex = 37;
            label10.Text = "Ciudad";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.CornflowerBlue;
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(723, 174);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(214, 30);
            txtPhone.TabIndex = 36;
            txtPhone.KeyPress += SoloNumeros;
            txtPhone.Validated += txtPhone_Validated;
            // 
            // txtCountry
            // 
            txtCountry.BackColor = Color.CornflowerBlue;
            txtCountry.ForeColor = Color.White;
            txtCountry.Location = new Point(723, 126);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(214, 30);
            txtCountry.TabIndex = 35;
            txtCountry.KeyPress += SoloLetras;
            txtCountry.Validated += txtCountry_Validated;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = Color.CornflowerBlue;
            txtPostalCode.ForeColor = Color.White;
            txtPostalCode.Location = new Point(723, 78);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(214, 30);
            txtPostalCode.TabIndex = 34;
            txtPostalCode.KeyPress += SoloNumeros;
            txtPostalCode.Validated += txtPostalCode_Validated;
            // 
            // txtRegion
            // 
            txtRegion.BackColor = Color.CornflowerBlue;
            txtRegion.ForeColor = Color.White;
            txtRegion.Location = new Point(723, 30);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(214, 30);
            txtRegion.TabIndex = 33;
            txtRegion.KeyPress += SoloLetras;
            txtRegion.Validated += txtRegion_Validated;
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.CornflowerBlue;
            txtCity.Font = new Font("Century Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtCity.ForeColor = Color.White;
            txtCity.Location = new Point(261, 229);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(214, 24);
            txtCity.TabIndex = 32;
            txtCity.KeyPress += SoloLetras;
            txtCity.Validated += txtCity_Validated;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 193);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 25;
            label5.Text = "Dirección";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.CornflowerBlue;
            txtAddress.Font = new Font("Century Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.White;
            txtAddress.Location = new Point(261, 181);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(214, 24);
            txtAddress.TabIndex = 26;
            txtAddress.Validated += txtAddress_Validated;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 145);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 17);
            label4.TabIndex = 23;
            label4.Text = "Título de contacto";
            // 
            // txtContactTitle
            // 
            txtContactTitle.BackColor = Color.CornflowerBlue;
            txtContactTitle.Font = new Font("Century Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtContactTitle.ForeColor = Color.White;
            txtContactTitle.Location = new Point(261, 133);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(214, 24);
            txtContactTitle.TabIndex = 24;
            txtContactTitle.KeyPress += SoloLetras;
            txtContactTitle.Validated += txtContactTitle_Validated;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 17);
            label3.TabIndex = 21;
            label3.Text = "Nombre de contacto";
            // 
            // txtContactName
            // 
            txtContactName.BackColor = Color.CornflowerBlue;
            txtContactName.Font = new Font("Century Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtContactName.ForeColor = Color.White;
            txtContactName.Location = new Point(261, 85);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(214, 24);
            txtContactName.TabIndex = 22;
            txtContactName.KeyPress += SoloLetras;
            txtContactName.Validated += txtContactName_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 49);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 17);
            label2.TabIndex = 19;
            label2.Text = "Nombre de empresa";
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = Color.CornflowerBlue;
            txtCompanyName.Font = new Font("Century Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtCompanyName.ForeColor = Color.White;
            txtCompanyName.Location = new Point(261, 39);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(214, 24);
            txtCompanyName.TabIndex = 20;
            txtCompanyName.KeyPress += SoloLetras;
            txtCompanyName.Validated += txtCompanyName_Validated;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // frmEntity
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1047, 773);
            Controls.Add(gbRegistrar);
            Controls.Add(brTitulo);
            Controls.Add(dgvDatos);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmEntity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEntity";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            brTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            gbRegistrar.ResumeLayout(false);
            gbRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private Panel brTitulo;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private GroupBox gbRegistrar;
        private Label label1;
        private TextBox txtIDCliente;
        private Button btnELIMINAR;
        private Button btnACTUALIZAR;
        private Label label11;
        private TextBox txtFax;
        private Button btnCREAR;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtPhone;
        private TextBox txtCountry;
        private TextBox txtPostalCode;
        private TextBox txtRegion;
        private TextBox txtCity;
        private Label label5;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtContactTitle;
        private Label label3;
        private TextBox txtContactName;
        private Label label2;
        private TextBox txtCompanyName;
        private ErrorProvider erpError;
    }
}