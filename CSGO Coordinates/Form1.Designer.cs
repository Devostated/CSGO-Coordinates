
namespace CSGO_Coordinates
{
    partial class CSGOCoords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSGOCoords));
            this.X1textbox = new System.Windows.Forms.TextBox();
            this.Y1textbox = new System.Windows.Forms.TextBox();
            this.Z1textbox = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.Label();
            this.Pfeil = new System.Windows.Forms.Label();
            this.Z2 = new System.Windows.Forms.Label();
            this.Y2 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.Label();
            this.Z2textbox = new System.Windows.Forms.TextBox();
            this.Y2textbox = new System.Windows.Forms.TextBox();
            this.X2textbox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // X1textbox
            // 
            this.X1textbox.Location = new System.Drawing.Point(28, 12);
            this.X1textbox.Name = "X1textbox";
            this.X1textbox.Size = new System.Drawing.Size(100, 20);
            this.X1textbox.TabIndex = 0;
            this.X1textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1textbox_KeyPress);
            // 
            // Y1textbox
            // 
            this.Y1textbox.Location = new System.Drawing.Point(28, 38);
            this.Y1textbox.Name = "Y1textbox";
            this.Y1textbox.Size = new System.Drawing.Size(100, 20);
            this.Y1textbox.TabIndex = 1;
            this.Y1textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1textbox_KeyPress);
            // 
            // Z1textbox
            // 
            this.Z1textbox.Location = new System.Drawing.Point(28, 64);
            this.Z1textbox.Name = "Z1textbox";
            this.Z1textbox.Size = new System.Drawing.Size(100, 20);
            this.Z1textbox.TabIndex = 2;
            this.Z1textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1textbox_KeyPress);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(8, 15);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(14, 13);
            this.X.TabIndex = 3;
            this.X.Text = "X";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(8, 41);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(14, 13);
            this.Y.TabIndex = 4;
            this.Y.Text = "Y";
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Location = new System.Drawing.Point(8, 67);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(14, 13);
            this.Z.TabIndex = 5;
            this.Z.Text = "Z";
            // 
            // Pfeil
            // 
            this.Pfeil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pfeil.AutoSize = true;
            this.Pfeil.Location = new System.Drawing.Point(133, 41);
            this.Pfeil.Name = "Pfeil";
            this.Pfeil.Size = new System.Drawing.Size(18, 13);
            this.Pfeil.TabIndex = 6;
            this.Pfeil.Text = "→";
            // 
            // Z2
            // 
            this.Z2.AutoSize = true;
            this.Z2.Location = new System.Drawing.Point(157, 67);
            this.Z2.Name = "Z2";
            this.Z2.Size = new System.Drawing.Size(14, 13);
            this.Z2.TabIndex = 12;
            this.Z2.Text = "Z";
            // 
            // Y2
            // 
            this.Y2.AutoSize = true;
            this.Y2.Location = new System.Drawing.Point(157, 41);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(14, 13);
            this.Y2.TabIndex = 11;
            this.Y2.Text = "Y";
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Location = new System.Drawing.Point(157, 15);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(14, 13);
            this.X2.TabIndex = 10;
            this.X2.Text = "X";
            // 
            // Z2textbox
            // 
            this.Z2textbox.Location = new System.Drawing.Point(177, 64);
            this.Z2textbox.Name = "Z2textbox";
            this.Z2textbox.ReadOnly = true;
            this.Z2textbox.Size = new System.Drawing.Size(100, 20);
            this.Z2textbox.TabIndex = 9;
            // 
            // Y2textbox
            // 
            this.Y2textbox.Location = new System.Drawing.Point(177, 38);
            this.Y2textbox.Name = "Y2textbox";
            this.Y2textbox.ReadOnly = true;
            this.Y2textbox.Size = new System.Drawing.Size(100, 20);
            this.Y2textbox.TabIndex = 8;
            // 
            // X2textbox
            // 
            this.X2textbox.Location = new System.Drawing.Point(177, 12);
            this.X2textbox.Name = "X2textbox";
            this.X2textbox.ReadOnly = true;
            this.X2textbox.Size = new System.Drawing.Size(100, 20);
            this.X2textbox.TabIndex = 7;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(11, 93);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(266, 23);
            this.ConvertButton.TabIndex = 13;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // CSGOCoords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 126);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.Z2);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.Z2textbox);
            this.Controls.Add(this.Y2textbox);
            this.Controls.Add(this.X2textbox);
            this.Controls.Add(this.Pfeil);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Z1textbox);
            this.Controls.Add(this.Y1textbox);
            this.Controls.Add(this.X1textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CSGOCoords";
            this.Text = "CSGO Coordinates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox X1textbox;
        private System.Windows.Forms.TextBox Y1textbox;
        private System.Windows.Forms.TextBox Z1textbox;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.Label Pfeil;
        private System.Windows.Forms.Label Z2;
        private System.Windows.Forms.Label Y2;
        private System.Windows.Forms.Label X2;
        private System.Windows.Forms.TextBox Z2textbox;
        private System.Windows.Forms.TextBox Y2textbox;
        private System.Windows.Forms.TextBox X2textbox;
        private System.Windows.Forms.Button ConvertButton;
    }
}

