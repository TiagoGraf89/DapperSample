namespace DapperSample
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLinq = new System.Windows.Forms.Label();
            this.lblADO = new System.Windows.Forms.Label();
            this.lblDapper = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressLinq = new System.Windows.Forms.ProgressBar();
            this.progressADO = new System.Windows.Forms.ProgressBar();
            this.progressDapper = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTestOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLinq);
            this.panel1.Controls.Add(this.lblADO);
            this.panel1.Controls.Add(this.lblDapper);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.progressLinq);
            this.panel1.Controls.Add(this.progressADO);
            this.panel1.Controls.Add(this.progressDapper);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 446);
            this.panel1.TabIndex = 0;
            // 
            // lblLinq
            // 
            this.lblLinq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinq.AutoSize = true;
            this.lblLinq.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinq.Location = new System.Drawing.Point(415, 255);
            this.lblLinq.Name = "lblLinq";
            this.lblLinq.Size = new System.Drawing.Size(51, 55);
            this.lblLinq.TabIndex = 8;
            this.lblLinq.Text = "0";
            // 
            // lblADO
            // 
            this.lblADO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblADO.AutoSize = true;
            this.lblADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADO.Location = new System.Drawing.Point(415, 142);
            this.lblADO.Name = "lblADO";
            this.lblADO.Size = new System.Drawing.Size(51, 55);
            this.lblADO.TabIndex = 7;
            this.lblADO.Text = "0";
            // 
            // lblDapper
            // 
            this.lblDapper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDapper.AutoSize = true;
            this.lblDapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapper.Location = new System.Drawing.Point(415, 33);
            this.lblDapper.Name = "lblDapper";
            this.lblDapper.Size = new System.Drawing.Size(51, 55);
            this.lblDapper.TabIndex = 6;
            this.lblDapper.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 55);
            this.label4.TabIndex = 5;
            this.label4.Text = "Entity Framework";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADO.Net";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dapper";
            // 
            // progressLinq
            // 
            this.progressLinq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLinq.Location = new System.Drawing.Point(6, 313);
            this.progressLinq.Name = "progressLinq";
            this.progressLinq.Size = new System.Drawing.Size(626, 23);
            this.progressLinq.TabIndex = 2;
            // 
            // progressADO
            // 
            this.progressADO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressADO.Location = new System.Drawing.Point(6, 198);
            this.progressADO.Name = "progressADO";
            this.progressADO.Size = new System.Drawing.Size(626, 23);
            this.progressADO.TabIndex = 1;
            // 
            // progressDapper
            // 
            this.progressDapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressDapper.Location = new System.Drawing.Point(6, 91);
            this.progressDapper.Name = "progressDapper";
            this.progressDapper.Size = new System.Drawing.Size(626, 23);
            this.progressDapper.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 446);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTestOne);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Performance Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTestOne
            // 
            this.btnTestOne.Location = new System.Drawing.Point(7, 336);
            this.btnTestOne.Name = "btnTestOne";
            this.btnTestOne.Size = new System.Drawing.Size(179, 76);
            this.btnTestOne.TabIndex = 1;
            this.btnTestOne.Text = "RUN";
            this.btnTestOne.UseVisualStyleBackColor = true;
            this.btnTestOne.Click += new System.EventHandler(this.btnTestOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Operations for each Framework:\r\nRun 20x\r\n    Insert one row\r\n    Select one " +
    "row\r\n    Update one row\r\n";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmMain";
            this.Text = "Dapper vs ADO.Net vs Entity Framework";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblLinq;
        private System.Windows.Forms.Label lblADO;
        private System.Windows.Forms.Label lblDapper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressLinq;
        private System.Windows.Forms.ProgressBar progressADO;
        private System.Windows.Forms.ProgressBar progressDapper;
        private System.Windows.Forms.Button btnTestOne;
        private System.Windows.Forms.Label label1;
    }
}

