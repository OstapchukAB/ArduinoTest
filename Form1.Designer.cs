namespace ArduinoTest
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
            this.components = new System.ComponentModel.Container();
            this.buttonGetComPort = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonOnLed = new System.Windows.Forms.Button();
            this.buttonOffLed = new System.Windows.Forms.Button();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.buttonStatus = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetComPort
            // 
            this.buttonGetComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetComPort.Location = new System.Drawing.Point(12, 28);
            this.buttonGetComPort.Name = "buttonGetComPort";
            this.buttonGetComPort.Size = new System.Drawing.Size(216, 60);
            this.buttonGetComPort.TabIndex = 0;
            this.buttonGetComPort.Text = "Get Com-port";
            this.buttonGetComPort.UseVisualStyleBackColor = true;
            this.buttonGetComPort.Click += new System.EventHandler(this.buttonGetComPort_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnect.Location = new System.Drawing.Point(12, 183);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(216, 60);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonOnLed
            // 
            this.buttonOnLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOnLed.Location = new System.Drawing.Point(427, 378);
            this.buttonOnLed.Name = "buttonOnLed";
            this.buttonOnLed.Size = new System.Drawing.Size(216, 60);
            this.buttonOnLed.TabIndex = 2;
            this.buttonOnLed.Text = "ON LED";
            this.buttonOnLed.UseVisualStyleBackColor = true;
            this.buttonOnLed.Click += new System.EventHandler(this.buttonOnLed_Click);
            // 
            // buttonOffLed
            // 
            this.buttonOffLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOffLed.Location = new System.Drawing.Point(427, 462);
            this.buttonOffLed.Name = "buttonOffLed";
            this.buttonOffLed.Size = new System.Drawing.Size(216, 60);
            this.buttonOffLed.TabIndex = 3;
            this.buttonOffLed.Text = "OFF LED";
            this.buttonOffLed.UseVisualStyleBackColor = true;
            this.buttonOffLed.Click += new System.EventHandler(this.buttonOffLed_Click);
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(12, 113);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(216, 32);
            this.comboBoxCom.TabIndex = 4;
            // 
            // buttonStatus
            // 
            this.buttonStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatus.Location = new System.Drawing.Point(319, 12);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(324, 27);
            this.buttonStatus.TabIndex = 5;
            this.buttonStatus.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(319, 198);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(324, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(442, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.comboBoxCom);
            this.Controls.Add(this.buttonOffLed);
            this.Controls.Add(this.buttonOnLed);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonGetComPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetComPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonOnLed;
        private System.Windows.Forms.Button buttonOffLed;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}

