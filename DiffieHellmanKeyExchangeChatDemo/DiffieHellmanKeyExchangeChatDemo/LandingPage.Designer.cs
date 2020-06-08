namespace DiffieHellmanKeyExchangeChatDemo {
    partial class LandingPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.host_server = new System.Windows.Forms.Button();
            this.gen_c = new System.Windows.Forms.Button();
            this.gen_b = new System.Windows.Forms.Button();
            this.private_key = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gen_a = new System.Windows.Forms.Button();
            this.public_prime_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.public_big_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bind_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bind_Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.connect_to_server = new System.Windows.Forms.Button();
            this.gen_d = new System.Windows.Forms.Button();
            this.local_private_key = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.server_port = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.server_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.host_server);
            this.groupBox1.Controls.Add(this.gen_c);
            this.groupBox1.Controls.Add(this.gen_b);
            this.groupBox1.Controls.Add(this.private_key);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gen_a);
            this.groupBox1.Controls.Add(this.public_prime_number);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.public_big_number);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bind_Port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bind_Address);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host Server";
            // 
            // host_server
            // 
            this.host_server.Location = new System.Drawing.Point(661, 174);
            this.host_server.Name = "host_server";
            this.host_server.Size = new System.Drawing.Size(87, 32);
            this.host_server.TabIndex = 13;
            this.host_server.Text = "Host";
            this.host_server.UseVisualStyleBackColor = true;
            this.host_server.Click += new System.EventHandler(this.host_server_Click);
            // 
            // gen_c
            // 
            this.gen_c.Location = new System.Drawing.Point(661, 145);
            this.gen_c.Name = "gen_c";
            this.gen_c.Size = new System.Drawing.Size(87, 23);
            this.gen_c.TabIndex = 12;
            this.gen_c.Text = "Generate";
            this.gen_c.UseVisualStyleBackColor = true;
            this.gen_c.Click += new System.EventHandler(this.gen_c_Click);
            // 
            // gen_b
            // 
            this.gen_b.Location = new System.Drawing.Point(661, 89);
            this.gen_b.Name = "gen_b";
            this.gen_b.Size = new System.Drawing.Size(87, 23);
            this.gen_b.TabIndex = 11;
            this.gen_b.Text = "Generate";
            this.gen_b.UseVisualStyleBackColor = true;
            this.gen_b.Click += new System.EventHandler(this.gen_b_Click);
            // 
            // private_key
            // 
            this.private_key.Location = new System.Drawing.Point(152, 145);
            this.private_key.Name = "private_key";
            this.private_key.ReadOnly = true;
            this.private_key.Size = new System.Drawing.Size(503, 22);
            this.private_key.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Private Key";
            // 
            // gen_a
            // 
            this.gen_a.Location = new System.Drawing.Point(661, 117);
            this.gen_a.Name = "gen_a";
            this.gen_a.Size = new System.Drawing.Size(87, 23);
            this.gen_a.TabIndex = 8;
            this.gen_a.Text = "Generate";
            this.gen_a.UseVisualStyleBackColor = true;
            this.gen_a.Click += new System.EventHandler(this.gen_a_Click);
            // 
            // public_prime_number
            // 
            this.public_prime_number.Location = new System.Drawing.Point(152, 89);
            this.public_prime_number.Name = "public_prime_number";
            this.public_prime_number.ReadOnly = true;
            this.public_prime_number.Size = new System.Drawing.Size(503, 22);
            this.public_prime_number.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Public Prime Number";
            // 
            // public_big_number
            // 
            this.public_big_number.Location = new System.Drawing.Point(152, 117);
            this.public_big_number.Name = "public_big_number";
            this.public_big_number.ReadOnly = true;
            this.public_big_number.Size = new System.Drawing.Size(503, 22);
            this.public_big_number.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Public Big Number";
            // 
            // bind_Port
            // 
            this.bind_Port.Location = new System.Drawing.Point(152, 61);
            this.bind_Port.Name = "bind_Port";
            this.bind_Port.Size = new System.Drawing.Size(255, 22);
            this.bind_Port.TabIndex = 3;
            this.bind_Port.Text = "5555";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bind Port";
            // 
            // bind_Address
            // 
            this.bind_Address.Location = new System.Drawing.Point(152, 32);
            this.bind_Address.Name = "bind_Address";
            this.bind_Address.Size = new System.Drawing.Size(255, 22);
            this.bind_Address.TabIndex = 1;
            this.bind_Address.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bind Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.connect_to_server);
            this.groupBox2.Controls.Add(this.gen_d);
            this.groupBox2.Controls.Add(this.local_private_key);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.server_port);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.server_address);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 170);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect";
            // 
            // connect_to_server
            // 
            this.connect_to_server.Location = new System.Drawing.Point(661, 118);
            this.connect_to_server.Name = "connect_to_server";
            this.connect_to_server.Size = new System.Drawing.Size(87, 32);
            this.connect_to_server.TabIndex = 13;
            this.connect_to_server.Text = "Connect";
            this.connect_to_server.UseVisualStyleBackColor = true;
            this.connect_to_server.Click += new System.EventHandler(this.connect_to_server_Click);
            // 
            // gen_d
            // 
            this.gen_d.Location = new System.Drawing.Point(661, 89);
            this.gen_d.Name = "gen_d";
            this.gen_d.Size = new System.Drawing.Size(87, 23);
            this.gen_d.TabIndex = 12;
            this.gen_d.Text = "Generate";
            this.gen_d.UseVisualStyleBackColor = true;
            this.gen_d.Click += new System.EventHandler(this.gen_d_Click);
            // 
            // local_private_key
            // 
            this.local_private_key.Location = new System.Drawing.Point(152, 89);
            this.local_private_key.Name = "local_private_key";
            this.local_private_key.ReadOnly = true;
            this.local_private_key.Size = new System.Drawing.Size(503, 22);
            this.local_private_key.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Private Key";
            // 
            // server_port
            // 
            this.server_port.Location = new System.Drawing.Point(152, 61);
            this.server_port.Name = "server_port";
            this.server_port.Size = new System.Drawing.Size(255, 22);
            this.server_port.TabIndex = 3;
            this.server_port.Text = "5555";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Server Port";
            // 
            // server_address
            // 
            this.server_address.Location = new System.Drawing.Point(152, 32);
            this.server_address.Name = "server_address";
            this.server_address.Size = new System.Drawing.Size(255, 22);
            this.server_address.TabIndex = 1;
            this.server_address.Text = "127.0.0.1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Server Address";
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LandingPage";
            this.Text = "Diffie Hellman Key Exchange Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button host_server;
        private System.Windows.Forms.Button gen_c;
        private System.Windows.Forms.Button gen_b;
        private System.Windows.Forms.TextBox private_key;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button gen_a;
        private System.Windows.Forms.TextBox public_prime_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox public_big_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bind_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bind_Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button connect_to_server;
        private System.Windows.Forms.Button gen_d;
        private System.Windows.Forms.TextBox local_private_key;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox server_port;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox server_address;
        private System.Windows.Forms.Label label10;
    }
}

