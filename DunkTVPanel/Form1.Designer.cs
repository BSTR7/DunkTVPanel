namespace DunkTVPanel
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTeamName1 = new System.Windows.Forms.TextBox();
            this.txtTeamName2 = new System.Windows.Forms.TextBox();
            this.btnLoadLogo1 = new System.Windows.Forms.Button();
            this.btnLoadLogo2 = new System.Windows.Forms.Button();
            this.pictureBoxLogo1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo2 = new System.Windows.Forms.PictureBox();
            this.btnSelectColor1 = new System.Windows.Forms.Button();
            this.btnSelectColor2 = new System.Windows.Forms.Button();
            this.panelColor1 = new System.Windows.Forms.Panel();
            this.panelColor2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTeamName1
            // 
            this.txtTeamName1.Location = new System.Drawing.Point(209, 12);
            this.txtTeamName1.Name = "txtTeamName1";
            this.txtTeamName1.Size = new System.Drawing.Size(206, 20);
            this.txtTeamName1.TabIndex = 0;
            this.txtTeamName1.Text = "EQUIPO 1";
            // 
            // txtTeamName2
            // 
            this.txtTeamName2.Location = new System.Drawing.Point(209, 40);
            this.txtTeamName2.Name = "txtTeamName2";
            this.txtTeamName2.Size = new System.Drawing.Size(206, 20);
            this.txtTeamName2.TabIndex = 1;
            this.txtTeamName2.Text = "EQUIPO 2";
            // 
            // btnLoadLogo1
            // 
            this.btnLoadLogo1.Location = new System.Drawing.Point(209, 262);
            this.btnLoadLogo1.Name = "btnLoadLogo1";
            this.btnLoadLogo1.Size = new System.Drawing.Size(100, 23);
            this.btnLoadLogo1.TabIndex = 2;
            this.btnLoadLogo1.Text = "Cargar Logo 1";
            this.btnLoadLogo1.UseVisualStyleBackColor = true;
            this.btnLoadLogo1.Click += new System.EventHandler(this.btnLoadLogo1_Click);
            // 
            // btnLoadLogo2
            // 
            this.btnLoadLogo2.Location = new System.Drawing.Point(315, 262);
            this.btnLoadLogo2.Name = "btnLoadLogo2";
            this.btnLoadLogo2.Size = new System.Drawing.Size(100, 23);
            this.btnLoadLogo2.TabIndex = 3;
            this.btnLoadLogo2.Text = "Cargar Logo 2";
            this.btnLoadLogo2.UseVisualStyleBackColor = true;
            this.btnLoadLogo2.Click += new System.EventHandler(this.btnLoadLogo2_Click);
            // 
            // pictureBoxLogo1
            // 
            this.pictureBoxLogo1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo1.Location = new System.Drawing.Point(209, 141);
            this.pictureBoxLogo1.Name = "pictureBoxLogo1";
            this.pictureBoxLogo1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo1.TabIndex = 4;
            this.pictureBoxLogo1.TabStop = false;
            // 
            // pictureBoxLogo2
            // 
            this.pictureBoxLogo2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo2.Location = new System.Drawing.Point(315, 141);
            this.pictureBoxLogo2.Name = "pictureBoxLogo2";
            this.pictureBoxLogo2.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo2.TabIndex = 5;
            this.pictureBoxLogo2.TabStop = false;
            // 
            // btnSelectColor1
            // 
            this.btnSelectColor1.Location = new System.Drawing.Point(209, 68);
            this.btnSelectColor1.Name = "btnSelectColor1";
            this.btnSelectColor1.Size = new System.Drawing.Size(100, 23);
            this.btnSelectColor1.TabIndex = 6;
            this.btnSelectColor1.Text = "Color Equipo 1";
            this.btnSelectColor1.UseVisualStyleBackColor = true;
            this.btnSelectColor1.Click += new System.EventHandler(this.btnSelectColor1_Click);
            // 
            // btnSelectColor2
            // 
            this.btnSelectColor2.Location = new System.Drawing.Point(209, 97);
            this.btnSelectColor2.Name = "btnSelectColor2";
            this.btnSelectColor2.Size = new System.Drawing.Size(100, 23);
            this.btnSelectColor2.TabIndex = 7;
            this.btnSelectColor2.Text = "Color Equipo 2";
            this.btnSelectColor2.UseVisualStyleBackColor = true;
            this.btnSelectColor2.Click += new System.EventHandler(this.btnSelectColor2_Click);
            // 
            // panelColor1
            // 
            this.panelColor1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelColor1.Location = new System.Drawing.Point(315, 68);
            this.panelColor1.Name = "panelColor1";
            this.panelColor1.Size = new System.Drawing.Size(100, 23);
            this.panelColor1.TabIndex = 8;
            // 
            // panelColor2
            // 
            this.panelColor2.BackColor = System.Drawing.Color.Purple;
            this.panelColor2.Location = new System.Drawing.Point(315, 97);
            this.panelColor2.Name = "panelColor2";
            this.panelColor2.Size = new System.Drawing.Size(100, 23);
            this.panelColor2.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(215, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar Marcador";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DunkTVPanel.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 79);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackgroundImage = global::DunkTVPanel.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelColor2);
            this.Controls.Add(this.panelColor1);
            this.Controls.Add(this.btnSelectColor2);
            this.Controls.Add(this.btnSelectColor1);
            this.Controls.Add(this.pictureBoxLogo2);
            this.Controls.Add(this.pictureBoxLogo1);
            this.Controls.Add(this.btnLoadLogo2);
            this.Controls.Add(this.btnLoadLogo1);
            this.Controls.Add(this.txtTeamName2);
            this.Controls.Add(this.txtTeamName1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(676, 409);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(676, 409);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcador Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtTeamName1;
        private System.Windows.Forms.TextBox txtTeamName2;
        private System.Windows.Forms.Button btnLoadLogo1;
        private System.Windows.Forms.Button btnLoadLogo2;
        private System.Windows.Forms.PictureBox pictureBoxLogo1;
        private System.Windows.Forms.PictureBox pictureBoxLogo2;
        private System.Windows.Forms.Button btnSelectColor1;
        private System.Windows.Forms.Button btnSelectColor2;
        private System.Windows.Forms.Panel panelColor1;
        private System.Windows.Forms.Panel panelColor2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
