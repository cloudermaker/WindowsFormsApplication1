namespace WindowsFormsApplication1
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.RefreshButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ChercheButton = new System.Windows.Forms.Button();
            this.BienComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CommandeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaysComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonneComboBox = new System.Windows.Forms.ComboBox();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(6, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 39);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Ajouter";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(645, 12);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 39);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "Quitter";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshButton);
            this.groupBox1.Controls.Add(this.QuitButton);
            this.groupBox1.Location = new System.Drawing.Point(18, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ChercheButton);
            this.groupBox2.Controls.Add(this.BienComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CommandeComboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PaysComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.PersonneComboBox);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(678, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 39);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChercheButton
            // 
            this.ChercheButton.Location = new System.Drawing.Point(6, 40);
            this.ChercheButton.Name = "ChercheButton";
            this.ChercheButton.Size = new System.Drawing.Size(75, 23);
            this.ChercheButton.TabIndex = 2;
            this.ChercheButton.Text = "Chercher";
            this.ChercheButton.UseVisualStyleBackColor = true;
            this.ChercheButton.Click += new System.EventHandler(this.ChercheButton_Click);
            // 
            // BienComboBox
            // 
            this.BienComboBox.FormattingEnabled = true;
            this.BienComboBox.Location = new System.Drawing.Point(593, 13);
            this.BienComboBox.Name = "BienComboBox";
            this.BienComboBox.Size = new System.Drawing.Size(121, 21);
            this.BienComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bien:";
            // 
            // CommandeComboBox
            // 
            this.CommandeComboBox.FormattingEnabled = true;
            this.CommandeComboBox.Location = new System.Drawing.Point(429, 13);
            this.CommandeComboBox.Name = "CommandeComboBox";
            this.CommandeComboBox.Size = new System.Drawing.Size(121, 21);
            this.CommandeComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Commande:";
            // 
            // PaysComboBox
            // 
            this.PaysComboBox.FormattingEnabled = true;
            this.PaysComboBox.Location = new System.Drawing.Point(233, 13);
            this.PaysComboBox.Name = "PaysComboBox";
            this.PaysComboBox.Size = new System.Drawing.Size(121, 21);
            this.PaysComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pays:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personne:";
            // 
            // PersonneComboBox
            // 
            this.PersonneComboBox.FormattingEnabled = true;
            this.PersonneComboBox.Location = new System.Drawing.Point(67, 13);
            this.PersonneComboBox.Name = "PersonneComboBox";
            this.PersonneComboBox.Size = new System.Drawing.Size(121, 21);
            this.PersonneComboBox.TabIndex = 0;
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.Controls.Add(this.dataGridView);
            this.DataGroupBox.Location = new System.Drawing.Point(18, 98);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(725, 374);
            this.DataGroupBox.TabIndex = 4;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "Données";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 24);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(705, 349);
            this.dataGridView.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 542);
            this.Controls.Add(this.DataGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Shown += new System.EventHandler(this.Principal_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PersonneComboBox;
        private System.Windows.Forms.ComboBox PaysComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CommandeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BienComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChercheButton;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;


    }
}