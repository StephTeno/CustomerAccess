namespace VisualUI
{
    partial class CustomerUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gbRegistrar = new System.Windows.Forms.GroupBox();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnACTUALIZAR = new System.Windows.Forms.Button();
            this.btnLEER = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.btnCREAR = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gbRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeight = 45;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDatos.Location = new System.Drawing.Point(0, 410);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.RowTemplate.Height = 33;
            this.dgvDatos.Size = new System.Drawing.Size(1051, 363);
            this.dgvDatos.TabIndex = 18;
            // 
            // gbRegistrar
            // 
            this.gbRegistrar.Controls.Add(this.btnELIMINAR);
            this.gbRegistrar.Controls.Add(this.btnACTUALIZAR);
            this.gbRegistrar.Controls.Add(this.btnLEER);
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
            this.gbRegistrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRegistrar.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbRegistrar.ForeColor = System.Drawing.Color.White;
            this.gbRegistrar.Location = new System.Drawing.Point(0, 0);
            this.gbRegistrar.Name = "gbRegistrar";
            this.gbRegistrar.Size = new System.Drawing.Size(1051, 410);
            this.gbRegistrar.TabIndex = 20;
            this.gbRegistrar.TabStop = false;
            this.gbRegistrar.Text = "REGISTRAR";
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELIMINAR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnELIMINAR.ForeColor = System.Drawing.Color.White;
            this.btnELIMINAR.Location = new System.Drawing.Point(742, 314);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(168, 50);
            this.btnELIMINAR.TabIndex = 47;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            // 
            // btnACTUALIZAR
            // 
            this.btnACTUALIZAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnACTUALIZAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnACTUALIZAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnACTUALIZAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACTUALIZAR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnACTUALIZAR.ForeColor = System.Drawing.Color.White;
            this.btnACTUALIZAR.Location = new System.Drawing.Point(528, 314);
            this.btnACTUALIZAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnACTUALIZAR.Name = "btnACTUALIZAR";
            this.btnACTUALIZAR.Size = new System.Drawing.Size(199, 50);
            this.btnACTUALIZAR.TabIndex = 46;
            this.btnACTUALIZAR.Text = "ACTUALIZAR";
            this.btnACTUALIZAR.UseVisualStyleBackColor = true;
            // 
            // btnLEER
            // 
            this.btnLEER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLEER.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLEER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLEER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLEER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLEER.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLEER.ForeColor = System.Drawing.Color.White;
            this.btnLEER.Location = new System.Drawing.Point(339, 314);
            this.btnLEER.Margin = new System.Windows.Forms.Padding(2);
            this.btnLEER.Name = "btnLEER";
            this.btnLEER.Size = new System.Drawing.Size(168, 50);
            this.btnLEER.TabIndex = 45;
            this.btnLEER.Text = "LEER";
            this.btnLEER.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(540, 243);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 26);
            this.label11.TabIndex = 44;
            this.label11.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(713, 233);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(301, 42);
            this.txtFax.TabIndex = 43;
            // 
            // btnCREAR
            // 
            this.btnCREAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCREAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCREAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCREAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCREAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCREAR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCREAR.ForeColor = System.Drawing.Color.White;
            this.btnCREAR.Location = new System.Drawing.Point(148, 314);
            this.btnCREAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCREAR.Name = "btnCREAR";
            this.btnCREAR.Size = new System.Drawing.Size(168, 50);
            this.btnCREAR.TabIndex = 42;
            this.btnCREAR.Text = "CREAR";
            this.btnCREAR.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(540, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 41;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(540, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 26);
            this.label7.TabIndex = 40;
            this.label7.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(540, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 26);
            this.label8.TabIndex = 39;
            this.label8.Text = "PostalCode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(540, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 26);
            this.label9.TabIndex = 38;
            this.label9.Text = "Region";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 26);
            this.label10.TabIndex = 37;
            this.label10.Text = "City";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(713, 185);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(301, 42);
            this.txtPhone.TabIndex = 36;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(713, 137);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(301, 42);
            this.txtCountry.TabIndex = 35;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(713, 89);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(301, 42);
            this.txtPostalCode.TabIndex = 34;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(713, 41);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(301, 42);
            this.txtRegion.TabIndex = 33;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(220, 233);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(301, 42);
            this.txtCity.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(220, 185);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(301, 42);
            this.txtAddress.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "ContactTitle";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(220, 137);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(301, 42);
            this.txtContactTitle.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "ContactName";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(220, 89);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(301, 42);
            this.txtContactName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "CompanyName";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(220, 41);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(301, 42);
            this.txtCompanyName.TabIndex = 20;
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1051, 773);
            this.Controls.Add(this.gbRegistrar);
            this.Controls.Add(this.dgvDatos);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CustomerUI";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gbRegistrar.ResumeLayout(false);
            this.gbRegistrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDatos;
        private GroupBox gbRegistrar;
        private Button btnELIMINAR;
        private Button btnACTUALIZAR;
        private Button btnLEER;
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
    }
}