﻿namespace WinEntity
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntity));
            dgvDatos = new DataGridView();
            txtCompanyName = new TextBox();
            label2 = new Label();
            txtContactName = new TextBox();
            label3 = new Label();
            txtContactTitle = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            txtRegion = new TextBox();
            txtPostalCode = new TextBox();
            txtCountry = new TextBox();
            txtPhone = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnCREAR = new Button();
            txtFax = new TextBox();
            label11 = new Label();
            btnLEER = new Button();
            btnACTUALIZAR = new Button();
            btnELIMINAR = new Button();
            gbRegistrar = new GroupBox();
            panel1 = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            gbRegistrar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDatos.RowTemplate.Height = 33;
            dgvDatos.Size = new Size(1000, 333);
            dgvDatos.TabIndex = 19;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(229, 42);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(273, 30);
            txtCompanyName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 54);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 17);
            label2.TabIndex = 19;
            label2.Text = "Nombre de empresa";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(229, 90);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(273, 30);
            txtContactName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 99);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 17);
            label3.TabIndex = 21;
            label3.Text = "Nombre de contacto";
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(229, 138);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(273, 30);
            txtContactTitle.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 146);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 17);
            label4.TabIndex = 23;
            label4.Text = "Título de contacto";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(229, 186);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(273, 30);
            txtAddress.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 195);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 25;
            label5.Text = "Dirección";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(229, 234);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(273, 30);
            txtCity.TabIndex = 32;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(677, 42);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(301, 30);
            txtRegion.TabIndex = 33;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(677, 90);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(301, 30);
            txtPostalCode.TabIndex = 34;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(677, 138);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(301, 30);
            txtCountry.TabIndex = 35;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(677, 186);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(301, 30);
            txtPhone.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(11, 249);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(58, 17);
            label10.TabIndex = 37;
            label10.Text = "Ciudad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(520, 54);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 17);
            label9.TabIndex = 38;
            label9.Text = "Region";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(520, 99);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 17);
            label8.TabIndex = 39;
            label8.Text = "Código Postal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(520, 146);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 17);
            label7.TabIndex = 40;
            label7.Text = "País";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(520, 195);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 41;
            label6.Text = "Teléfono";
            // 
            // btnCREAR
            // 
            btnCREAR.Cursor = Cursors.Hand;
            btnCREAR.FlatAppearance.BorderColor = Color.White;
            btnCREAR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCREAR.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCREAR.FlatStyle = FlatStyle.Flat;
            btnCREAR.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCREAR.ForeColor = Color.White;
            btnCREAR.Location = new Point(81, 289);
            btnCREAR.Margin = new Padding(2);
            btnCREAR.Name = "btnCREAR";
            btnCREAR.Size = new Size(168, 50);
            btnCREAR.TabIndex = 42;
            btnCREAR.Text = "CREAR";
            btnCREAR.UseVisualStyleBackColor = true;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(677, 234);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(301, 30);
            txtFax.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(520, 243);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(32, 17);
            label11.TabIndex = 44;
            label11.Text = "Fax";
            // 
            // btnLEER
            // 
            btnLEER.Cursor = Cursors.Hand;
            btnLEER.FlatAppearance.BorderColor = Color.White;
            btnLEER.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLEER.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnLEER.FlatStyle = FlatStyle.Flat;
            btnLEER.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLEER.ForeColor = Color.White;
            btnLEER.Location = new Point(272, 289);
            btnLEER.Margin = new Padding(2);
            btnLEER.Name = "btnLEER";
            btnLEER.Size = new Size(168, 50);
            btnLEER.TabIndex = 45;
            btnLEER.Text = "LEER";
            btnLEER.UseVisualStyleBackColor = true;
            // 
            // btnACTUALIZAR
            // 
            btnACTUALIZAR.Cursor = Cursors.Hand;
            btnACTUALIZAR.FlatAppearance.BorderColor = Color.White;
            btnACTUALIZAR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnACTUALIZAR.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnACTUALIZAR.FlatStyle = FlatStyle.Flat;
            btnACTUALIZAR.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnACTUALIZAR.ForeColor = Color.White;
            btnACTUALIZAR.Location = new Point(461, 289);
            btnACTUALIZAR.Margin = new Padding(2);
            btnACTUALIZAR.Name = "btnACTUALIZAR";
            btnACTUALIZAR.Size = new Size(199, 50);
            btnACTUALIZAR.TabIndex = 46;
            btnACTUALIZAR.Text = "ACTUALIZAR";
            btnACTUALIZAR.UseVisualStyleBackColor = true;
            // 
            // btnELIMINAR
            // 
            btnELIMINAR.Cursor = Cursors.Hand;
            btnELIMINAR.FlatAppearance.BorderColor = Color.White;
            btnELIMINAR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnELIMINAR.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnELIMINAR.FlatStyle = FlatStyle.Flat;
            btnELIMINAR.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnELIMINAR.ForeColor = Color.White;
            btnELIMINAR.Location = new Point(675, 289);
            btnELIMINAR.Margin = new Padding(2);
            btnELIMINAR.Name = "btnELIMINAR";
            btnELIMINAR.Size = new Size(168, 50);
            btnELIMINAR.TabIndex = 47;
            btnELIMINAR.Text = "ELIMINAR";
            btnELIMINAR.UseVisualStyleBackColor = true;
            // 
            // gbRegistrar
            // 
            gbRegistrar.Controls.Add(btnELIMINAR);
            gbRegistrar.Controls.Add(btnACTUALIZAR);
            gbRegistrar.Controls.Add(btnLEER);
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
            gbRegistrar.Size = new Size(1000, 378);
            gbRegistrar.TabIndex = 22;
            gbRegistrar.TabStop = false;
            gbRegistrar.Text = "REGISTRAR";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 47);
            panel1.TabIndex = 23;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(922, 12);
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
            btnCerrar.Location = new Point(963, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 53;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmEntity
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1000, 773);
            Controls.Add(panel1);
            Controls.Add(gbRegistrar);
            Controls.Add(dgvDatos);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmEntity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEntity";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            gbRegistrar.ResumeLayout(false);
            gbRegistrar.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
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
        private Button btnLEER;
        private Button btnACTUALIZAR;
        private Button btnELIMINAR;
        private GroupBox gbRegistrar;
        private Panel panel1;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
    }
}