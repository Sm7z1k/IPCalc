namespace IpCalc
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
            this.tbIP = new System.Windows.Forms.TextBox();
            this.lbAdressNetwork = new System.Windows.Forms.Label();
            this.lbLargeAdress = new System.Windows.Forms.Label();
            this.lbMaxCountIPAdresses = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbMask = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSubnetMask = new System.Windows.Forms.TextBox();
            this.tbNetworkAddress = new System.Windows.Forms.TextBox();
            this.tbMaxCountIP = new System.Windows.Forms.TextBox();
            this.tbBoardcast = new System.Windows.Forms.TextBox();
            this.tbFirstHost = new System.Windows.Forms.TextBox();
            this.tbLastHost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(30, 16);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(167, 20);
            this.tbIP.TabIndex = 1;
            this.tbIP.Text = "Введите IP";
            this.tbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIP.Enter += new System.EventHandler(this.tbIP_Enter);
            this.tbIP.Leave += new System.EventHandler(this.tbIP_Leave);
            // 
            // lbAdressNetwork
            // 
            this.lbAdressNetwork.AutoSize = true;
            this.lbAdressNetwork.Location = new System.Drawing.Point(76, 126);
            this.lbAdressNetwork.Name = "lbAdressNetwork";
            this.lbAdressNetwork.Size = new System.Drawing.Size(64, 13);
            this.lbAdressNetwork.TabIndex = 3;
            this.lbAdressNetwork.Text = "Адрес сети";
            // 
            // lbLargeAdress
            // 
            this.lbLargeAdress.AutoSize = true;
            this.lbLargeAdress.Location = new System.Drawing.Point(40, 204);
            this.lbLargeAdress.Name = "lbLargeAdress";
            this.lbLargeAdress.Size = new System.Drawing.Size(149, 13);
            this.lbLargeAdress.TabIndex = 4;
            this.lbLargeAdress.Text = "Широковещательный адрес";
            // 
            // lbMaxCountIPAdresses
            // 
            this.lbMaxCountIPAdresses.AutoSize = true;
            this.lbMaxCountIPAdresses.Location = new System.Drawing.Point(54, 165);
            this.lbMaxCountIPAdresses.Name = "lbMaxCountIPAdresses";
            this.lbMaxCountIPAdresses.Size = new System.Drawing.Size(131, 13);
            this.lbMaxCountIPAdresses.TabIndex = 5;
            this.lbMaxCountIPAdresses.Text = "Макс. кол-во IP-адресов";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(73, 42);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Посчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbMask
            // 
            this.lbMask.AutoSize = true;
            this.lbMask.Location = new System.Drawing.Point(91, 87);
            this.lbMask.Name = "lbMask";
            this.lbMask.Size = new System.Drawing.Size(40, 13);
            this.lbMask.TabIndex = 7;
            this.lbMask.Text = "Маска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Первый хост";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Последний хост";
            // 
            // tbSubnetMask
            // 
            this.tbSubnetMask.Enabled = false;
            this.tbSubnetMask.Location = new System.Drawing.Point(30, 103);
            this.tbSubnetMask.Name = "tbSubnetMask";
            this.tbSubnetMask.Size = new System.Drawing.Size(167, 20);
            this.tbSubnetMask.TabIndex = 10;
            // 
            // tbNetworkAddress
            // 
            this.tbNetworkAddress.Enabled = false;
            this.tbNetworkAddress.Location = new System.Drawing.Point(30, 142);
            this.tbNetworkAddress.Name = "tbNetworkAddress";
            this.tbNetworkAddress.Size = new System.Drawing.Size(167, 20);
            this.tbNetworkAddress.TabIndex = 11;
            // 
            // tbMaxCountIP
            // 
            this.tbMaxCountIP.Enabled = false;
            this.tbMaxCountIP.Location = new System.Drawing.Point(30, 181);
            this.tbMaxCountIP.Name = "tbMaxCountIP";
            this.tbMaxCountIP.Size = new System.Drawing.Size(167, 20);
            this.tbMaxCountIP.TabIndex = 12;
            // 
            // tbBoardcast
            // 
            this.tbBoardcast.Enabled = false;
            this.tbBoardcast.Location = new System.Drawing.Point(30, 220);
            this.tbBoardcast.Name = "tbBoardcast";
            this.tbBoardcast.Size = new System.Drawing.Size(167, 20);
            this.tbBoardcast.TabIndex = 13;
            // 
            // tbFirstHost
            // 
            this.tbFirstHost.Enabled = false;
            this.tbFirstHost.Location = new System.Drawing.Point(30, 259);
            this.tbFirstHost.Name = "tbFirstHost";
            this.tbFirstHost.Size = new System.Drawing.Size(167, 20);
            this.tbFirstHost.TabIndex = 14;
            // 
            // tbLastHost
            // 
            this.tbLastHost.Enabled = false;
            this.tbLastHost.Location = new System.Drawing.Point(30, 298);
            this.tbLastHost.Name = "tbLastHost";
            this.tbLastHost.Size = new System.Drawing.Size(167, 20);
            this.tbLastHost.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 335);
            this.Controls.Add(this.tbLastHost);
            this.Controls.Add(this.tbFirstHost);
            this.Controls.Add(this.tbBoardcast);
            this.Controls.Add(this.tbMaxCountIP);
            this.Controls.Add(this.tbNetworkAddress);
            this.Controls.Add(this.tbSubnetMask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMask);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbMaxCountIPAdresses);
            this.Controls.Add(this.lbLargeAdress);
            this.Controls.Add(this.lbAdressNetwork);
            this.Controls.Add(this.tbIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label lbAdressNetwork;
        private System.Windows.Forms.Label lbLargeAdress;
        private System.Windows.Forms.Label lbMaxCountIPAdresses;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbMask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSubnetMask;
        private System.Windows.Forms.TextBox tbNetworkAddress;
        private System.Windows.Forms.TextBox tbMaxCountIP;
        private System.Windows.Forms.TextBox tbBoardcast;
        private System.Windows.Forms.TextBox tbFirstHost;
        private System.Windows.Forms.TextBox tbLastHost;
    }
}

