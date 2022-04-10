namespace imagedatabasetest
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vw = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(167, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(111, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upload Image On Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(205, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select An Image";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id.Location = new System.Drawing.Point(167, 576);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(150, 39);
            this.id.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(341, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(798, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Retrive Image";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(753, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 286);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // vw
            // 
            this.vw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vw.Location = new System.Drawing.Point(753, 526);
            this.vw.Name = "vw";
            this.vw.Size = new System.Drawing.Size(150, 39);
            this.vw.TabIndex = 7;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(949, 526);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(112, 39);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 747);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.vw);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox id;
        private Button btnSave;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox vw;
        private Button btnView;
    }
}