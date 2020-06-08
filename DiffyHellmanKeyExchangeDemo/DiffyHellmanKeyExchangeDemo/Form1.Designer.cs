namespace DiffyHellmanKeyExchangeDemo {
    partial class Form1 {
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
            this.PKa = new System.Windows.Forms.TextBox();
            this.PKb = new System.Windows.Forms.TextBox();
            this.Encode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PuKB = new System.Windows.Forms.TextBox();
            this.PuKA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alice_private_key = new System.Windows.Forms.TextBox();
            this.bob_private_key = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PKa
            // 
            this.PKa.Location = new System.Drawing.Point(139, 33);
            this.PKa.Name = "PKa";
            this.PKa.Size = new System.Drawing.Size(628, 22);
            this.PKa.TabIndex = 0;
            // 
            // PKb
            // 
            this.PKb.Location = new System.Drawing.Point(139, 61);
            this.PKb.Name = "PKb";
            this.PKb.Size = new System.Drawing.Size(628, 22);
            this.PKb.TabIndex = 1;
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(15, 296);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(137, 38);
            this.Encode.TabIndex = 2;
            this.Encode.Text = "Calculate keys!";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bob";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bobs public key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alices public key";
            // 
            // PuKB
            // 
            this.PuKB.Location = new System.Drawing.Point(139, 117);
            this.PuKB.Name = "PuKB";
            this.PuKB.Size = new System.Drawing.Size(628, 22);
            this.PuKB.TabIndex = 8;
            // 
            // PuKA
            // 
            this.PuKA.Location = new System.Drawing.Point(139, 89);
            this.PuKA.Name = "PuKA";
            this.PuKA.Size = new System.Drawing.Size(628, 22);
            this.PuKA.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alice Private Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bob Private Key";
            // 
            // alice_private_key
            // 
            this.alice_private_key.Location = new System.Drawing.Point(139, 28);
            this.alice_private_key.Name = "alice_private_key";
            this.alice_private_key.Size = new System.Drawing.Size(628, 22);
            this.alice_private_key.TabIndex = 11;
            // 
            // bob_private_key
            // 
            this.bob_private_key.Location = new System.Drawing.Point(139, 56);
            this.bob_private_key.Name = "bob_private_key";
            this.bob_private_key.Size = new System.Drawing.Size(628, 22);
            this.bob_private_key.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bob_private_key);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.alice_private_key);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.PKa);
            this.groupBox2.Controls.Add(this.PuKB);
            this.groupBox2.Controls.Add(this.PKb);
            this.groupBox2.Controls.Add(this.PuKA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 172);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Encode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PKa;
        private System.Windows.Forms.TextBox PKb;
        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PuKB;
        private System.Windows.Forms.TextBox PuKA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox alice_private_key;
        private System.Windows.Forms.TextBox bob_private_key;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

