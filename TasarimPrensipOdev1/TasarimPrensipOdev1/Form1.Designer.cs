namespace TasarimPrensipOdev1
{
    partial class Form1
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
            this.btnResimOynat = new System.Windows.Forms.Button();
            this.btnResimDurdur = new System.Windows.Forms.Button();
            this.btnVideoOynat = new System.Windows.Forms.Button();
            this.btnVideoDurdur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResimOynat
            // 
            this.btnResimOynat.Location = new System.Drawing.Point(48, 58);
            this.btnResimOynat.Name = "btnResimOynat";
            this.btnResimOynat.Size = new System.Drawing.Size(75, 23);
            this.btnResimOynat.TabIndex = 0;
            this.btnResimOynat.Text = "resim oynat";
            this.btnResimOynat.UseVisualStyleBackColor = true;
            this.btnResimOynat.Click += new System.EventHandler(this.btnResimOynat_Click);
            // 
            // btnResimDurdur
            // 
            this.btnResimDurdur.Location = new System.Drawing.Point(48, 103);
            this.btnResimDurdur.Name = "btnResimDurdur";
            this.btnResimDurdur.Size = new System.Drawing.Size(75, 23);
            this.btnResimDurdur.TabIndex = 0;
            this.btnResimDurdur.Text = "resim durdur";
            this.btnResimDurdur.UseVisualStyleBackColor = true;
            this.btnResimDurdur.Click += new System.EventHandler(this.btnResimDurdur_Click);
            // 
            // btnVideoOynat
            // 
            this.btnVideoOynat.Location = new System.Drawing.Point(148, 58);
            this.btnVideoOynat.Name = "btnVideoOynat";
            this.btnVideoOynat.Size = new System.Drawing.Size(75, 23);
            this.btnVideoOynat.TabIndex = 0;
            this.btnVideoOynat.Text = "video oynat";
            this.btnVideoOynat.UseVisualStyleBackColor = true;
            this.btnVideoOynat.Click += new System.EventHandler(this.btnVideoOynat_Click);
            // 
            // btnVideoDurdur
            // 
            this.btnVideoDurdur.Location = new System.Drawing.Point(148, 103);
            this.btnVideoDurdur.Name = "btnVideoDurdur";
            this.btnVideoDurdur.Size = new System.Drawing.Size(75, 23);
            this.btnVideoDurdur.TabIndex = 0;
            this.btnVideoDurdur.Text = "video durdur";
            this.btnVideoDurdur.UseVisualStyleBackColor = true;
            this.btnVideoDurdur.Click += new System.EventHandler(this.btnVideoDurdur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 210);
            this.Controls.Add(this.btnVideoDurdur);
            this.Controls.Add(this.btnVideoOynat);
            this.Controls.Add(this.btnResimDurdur);
            this.Controls.Add(this.btnResimOynat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResimOynat;
        private System.Windows.Forms.Button btnResimDurdur;
        private System.Windows.Forms.Button btnVideoOynat;
        private System.Windows.Forms.Button btnVideoDurdur;
    }
}

