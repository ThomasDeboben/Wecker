namespace WeckerApp
{
    partial class UI
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
            this.restzeit = new System.Windows.Forms.TextBox();
            this.labelRestzeit = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.zeitwert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUhrzeit = new System.Windows.Forms.Label();
            this.uhrzeit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // restzeit
            // 
            this.restzeit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restzeit.Location = new System.Drawing.Point(79, 83);
            this.restzeit.Name = "restzeit";
            this.restzeit.ReadOnly = true;
            this.restzeit.Size = new System.Drawing.Size(194, 20);
            this.restzeit.TabIndex = 0;
            this.restzeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelRestzeit
            // 
            this.labelRestzeit.AutoSize = true;
            this.labelRestzeit.Location = new System.Drawing.Point(13, 86);
            this.labelRestzeit.Name = "labelRestzeit";
            this.labelRestzeit.Size = new System.Drawing.Size(48, 13);
            this.labelRestzeit.TabIndex = 1;
            this.labelRestzeit.Text = "Restzeit:";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartStop.Location = new System.Drawing.Point(200, 124);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 2;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStopClicked);
            // 
            // zeitwert
            // 
            this.zeitwert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zeitwert.Location = new System.Drawing.Point(79, 49);
            this.zeitwert.Name = "zeitwert";
            this.zeitwert.Size = new System.Drawing.Size(194, 20);
            this.zeitwert.TabIndex = 3;
            this.zeitwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zeitwert";
            // 
            // labelUhrzeit
            // 
            this.labelUhrzeit.AutoSize = true;
            this.labelUhrzeit.Location = new System.Drawing.Point(13, 24);
            this.labelUhrzeit.Name = "labelUhrzeit";
            this.labelUhrzeit.Size = new System.Drawing.Size(43, 13);
            this.labelUhrzeit.TabIndex = 5;
            this.labelUhrzeit.Text = "Uhrzeit:";
            // 
            // uhrzeit
            // 
            this.uhrzeit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uhrzeit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uhrzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uhrzeit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uhrzeit.Location = new System.Drawing.Point(79, 13);
            this.uhrzeit.Name = "uhrzeit";
            this.uhrzeit.ReadOnly = true;
            this.uhrzeit.Size = new System.Drawing.Size(194, 24);
            this.uhrzeit.TabIndex = 6;
            this.uhrzeit.Text = "00:00:00";
            this.uhrzeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 160);
            this.Controls.Add(this.uhrzeit);
            this.Controls.Add(this.labelUhrzeit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zeitwert);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.labelRestzeit);
            this.Controls.Add(this.restzeit);
            this.Name = "UI";
            this.Text = "Wecker App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox restzeit;
        private System.Windows.Forms.Label labelRestzeit;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.TextBox zeitwert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUhrzeit;
        private System.Windows.Forms.TextBox uhrzeit;
    }
}

