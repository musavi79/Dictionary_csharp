namespace Farhang_Loqat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnVorood = new System.Windows.Forms.Button();
            this.btnKhorooj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVorood
            // 
            this.btnVorood.Image = ((System.Drawing.Image)(resources.GetObject("btnVorood.Image")));
            this.btnVorood.Location = new System.Drawing.Point(303, 171);
            this.btnVorood.Name = "btnVorood";
            this.btnVorood.Size = new System.Drawing.Size(243, 59);
            this.btnVorood.TabIndex = 0;
            this.btnVorood.Text = "ورود به برنامه";
            this.btnVorood.UseVisualStyleBackColor = true;
            this.btnVorood.Click += new System.EventHandler(this.btnVorood_Click);
            // 
            // btnKhorooj
            // 
            this.btnKhorooj.Image = ((System.Drawing.Image)(resources.GetObject("btnKhorooj.Image")));
            this.btnKhorooj.Location = new System.Drawing.Point(305, 251);
            this.btnKhorooj.Name = "btnKhorooj";
            this.btnKhorooj.Size = new System.Drawing.Size(243, 59);
            this.btnKhorooj.TabIndex = 1;
            this.btnKhorooj.Text = "خروج";
            this.btnKhorooj.UseVisualStyleBackColor = true;
            this.btnKhorooj.Click += new System.EventHandler(this.btnKhorooj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(852, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnKhorooj);
            this.Controls.Add(this.btnVorood);
            this.Font = new System.Drawing.Font("A Thuluth", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "فرهنگ لغت شکری";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnVorood;
        public System.Windows.Forms.Button btnKhorooj;
    }
}

