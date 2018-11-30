namespace TPL.Winforms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSites = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReadAsync = new System.Windows.Forms.Button();
            this.btnReadSync = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnReadAsyncParallal = new System.Windows.Forms.Button();
            this.btnReadAsyncParallalWithReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSites);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Site List";
            // 
            // lstSites
            // 
            this.lstSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSites.FormattingEnabled = true;
            this.lstSites.ItemHeight = 15;
            this.lstSites.Location = new System.Drawing.Point(6, 19);
            this.lstSites.Name = "lstSites";
            this.lstSites.Size = new System.Drawing.Size(431, 169);
            this.lstSites.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReadAsyncParallalWithReport);
            this.groupBox2.Controls.Add(this.btnReadAsyncParallal);
            this.groupBox2.Controls.Add(this.btnReadAsync);
            this.groupBox2.Controls.Add(this.btnReadSync);
            this.groupBox2.Location = new System.Drawing.Point(461, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 204);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // btnReadAsync
            // 
            this.btnReadAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAsync.Location = new System.Drawing.Point(11, 69);
            this.btnReadAsync.Name = "btnReadAsync";
            this.btnReadAsync.Size = new System.Drawing.Size(310, 31);
            this.btnReadAsync.TabIndex = 0;
            this.btnReadAsync.Text = "Read Async";
            this.btnReadAsync.UseVisualStyleBackColor = true;
            this.btnReadAsync.Click += new System.EventHandler(this.btnReadAsync_Click);
            // 
            // btnReadSync
            // 
            this.btnReadSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadSync.Location = new System.Drawing.Point(11, 32);
            this.btnReadSync.Name = "btnReadSync";
            this.btnReadSync.Size = new System.Drawing.Size(310, 31);
            this.btnReadSync.TabIndex = 0;
            this.btnReadSync.Text = "Read Sync";
            this.btnReadSync.UseVisualStyleBackColor = true;
            this.btnReadSync.Click += new System.EventHandler(this.btnReadSync_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstOutput);
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 222);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(6, 22);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(764, 186);
            this.lstOutput.TabIndex = 0;
            // 
            // btnReadAsyncParallal
            // 
            this.btnReadAsyncParallal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAsyncParallal.Location = new System.Drawing.Point(11, 106);
            this.btnReadAsyncParallal.Name = "btnReadAsyncParallal";
            this.btnReadAsyncParallal.Size = new System.Drawing.Size(310, 31);
            this.btnReadAsyncParallal.TabIndex = 0;
            this.btnReadAsyncParallal.Text = "Read Async Parallal";
            this.btnReadAsyncParallal.UseVisualStyleBackColor = true;
            this.btnReadAsyncParallal.Click += new System.EventHandler(this.btnReadAsyncParallal_Click);
            // 
            // btnReadAsyncParallalWithReport
            // 
            this.btnReadAsyncParallalWithReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAsyncParallalWithReport.Location = new System.Drawing.Point(11, 143);
            this.btnReadAsyncParallalWithReport.Name = "btnReadAsyncParallalWithReport";
            this.btnReadAsyncParallalWithReport.Size = new System.Drawing.Size(310, 31);
            this.btnReadAsyncParallalWithReport.TabIndex = 0;
            this.btnReadAsyncParallalWithReport.Text = "Read Async Parallal With Report";
            this.btnReadAsyncParallalWithReport.UseVisualStyleBackColor = true;
            this.btnReadAsyncParallalWithReport.Click += new System.EventHandler(this.btnReadAsyncParallalWithReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TPL Winforms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstSites;
        private System.Windows.Forms.Button btnReadSync;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnReadAsync;
        private System.Windows.Forms.Button btnReadAsyncParallal;
        private System.Windows.Forms.Button btnReadAsyncParallalWithReport;
    }
}

