namespace SampleWinForm
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_product_id = new System.Windows.Forms.TextBox();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.txt_product_price = new System.Windows.Forms.TextBox();
            this.btn_binary_wr = new System.Windows.Forms.Button();
            this.btn_binary_rd = new System.Windows.Forms.Button();
            this.btn_json_wr = new System.Windows.Forms.Button();
            this.btn_json_rd = new System.Windows.Forms.Button();
            this.btn_soap_wr = new System.Windows.Forms.Button();
            this.btn_soap_rd = new System.Windows.Forms.Button();
            this.btn_xml_rd = new System.Windows.Forms.Button();
            this.btn_xml_wr = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product_Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product_Price";
            // 
            // txt_product_id
            // 
            this.txt_product_id.Location = new System.Drawing.Point(170, 37);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.Size = new System.Drawing.Size(100, 20);
            this.txt_product_id.TabIndex = 3;
            // 
            // txt_product_name
            // 
            this.txt_product_name.Location = new System.Drawing.Point(170, 77);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(100, 20);
            this.txt_product_name.TabIndex = 4;
            // 
            // txt_product_price
            // 
            this.txt_product_price.Location = new System.Drawing.Point(170, 112);
            this.txt_product_price.Name = "txt_product_price";
            this.txt_product_price.Size = new System.Drawing.Size(100, 20);
            this.txt_product_price.TabIndex = 5;
            // 
            // btn_binary_wr
            // 
            this.btn_binary_wr.Location = new System.Drawing.Point(318, 27);
            this.btn_binary_wr.Name = "btn_binary_wr";
            this.btn_binary_wr.Size = new System.Drawing.Size(75, 23);
            this.btn_binary_wr.TabIndex = 6;
            this.btn_binary_wr.Text = "Binary Write";
            this.btn_binary_wr.UseVisualStyleBackColor = true;
            this.btn_binary_wr.Click += new System.EventHandler(this.btn_binary_wr_Click);
            // 
            // btn_binary_rd
            // 
            this.btn_binary_rd.Location = new System.Drawing.Point(418, 27);
            this.btn_binary_rd.Name = "btn_binary_rd";
            this.btn_binary_rd.Size = new System.Drawing.Size(75, 23);
            this.btn_binary_rd.TabIndex = 7;
            this.btn_binary_rd.Text = "Binary Read";
            this.btn_binary_rd.UseVisualStyleBackColor = true;
            this.btn_binary_rd.Click += new System.EventHandler(this.btn_binary_rd_Click);
            // 
            // btn_json_wr
            // 
            this.btn_json_wr.Location = new System.Drawing.Point(318, 76);
            this.btn_json_wr.Name = "btn_json_wr";
            this.btn_json_wr.Size = new System.Drawing.Size(75, 23);
            this.btn_json_wr.TabIndex = 8;
            this.btn_json_wr.Text = "Json Write";
            this.btn_json_wr.UseVisualStyleBackColor = true;
            this.btn_json_wr.Click += new System.EventHandler(this.btn_json_wr_Click);
            // 
            // btn_json_rd
            // 
            this.btn_json_rd.Location = new System.Drawing.Point(418, 76);
            this.btn_json_rd.Name = "btn_json_rd";
            this.btn_json_rd.Size = new System.Drawing.Size(75, 23);
            this.btn_json_rd.TabIndex = 9;
            this.btn_json_rd.Text = "Json Read";
            this.btn_json_rd.UseVisualStyleBackColor = true;
            this.btn_json_rd.Click += new System.EventHandler(this.btn_json_rd_Click);
            // 
            // btn_soap_wr
            // 
            this.btn_soap_wr.Location = new System.Drawing.Point(318, 124);
            this.btn_soap_wr.Name = "btn_soap_wr";
            this.btn_soap_wr.Size = new System.Drawing.Size(75, 23);
            this.btn_soap_wr.TabIndex = 10;
            this.btn_soap_wr.Text = "Soap write";
            this.btn_soap_wr.UseVisualStyleBackColor = true;
            this.btn_soap_wr.Click += new System.EventHandler(this.btn_soap_wr_Click);
            // 
            // btn_soap_rd
            // 
            this.btn_soap_rd.Location = new System.Drawing.Point(418, 124);
            this.btn_soap_rd.Name = "btn_soap_rd";
            this.btn_soap_rd.Size = new System.Drawing.Size(75, 23);
            this.btn_soap_rd.TabIndex = 11;
            this.btn_soap_rd.Text = "Soap Read";
            this.btn_soap_rd.UseVisualStyleBackColor = true;
            this.btn_soap_rd.Click += new System.EventHandler(this.btn_soap_rd_Click);
            // 
            // btn_xml_rd
            // 
            this.btn_xml_rd.Location = new System.Drawing.Point(418, 171);
            this.btn_xml_rd.Name = "btn_xml_rd";
            this.btn_xml_rd.Size = new System.Drawing.Size(75, 23);
            this.btn_xml_rd.TabIndex = 13;
            this.btn_xml_rd.Text = "XML Read";
            this.btn_xml_rd.UseVisualStyleBackColor = true;
            this.btn_xml_rd.Click += new System.EventHandler(this.btn_xml_rd_Click);
            // 
            // btn_xml_wr
            // 
            this.btn_xml_wr.Location = new System.Drawing.Point(318, 171);
            this.btn_xml_wr.Name = "btn_xml_wr";
            this.btn_xml_wr.Size = new System.Drawing.Size(75, 23);
            this.btn_xml_wr.TabIndex = 12;
            this.btn_xml_wr.Text = "XML write";
            this.btn_xml_wr.UseVisualStyleBackColor = true;
            this.btn_xml_wr.Click += new System.EventHandler(this.btn_xml_wr_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(60, 171);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 394);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_xml_rd);
            this.Controls.Add(this.btn_xml_wr);
            this.Controls.Add(this.btn_soap_rd);
            this.Controls.Add(this.btn_soap_wr);
            this.Controls.Add(this.btn_json_rd);
            this.Controls.Add(this.btn_json_wr);
            this.Controls.Add(this.btn_binary_rd);
            this.Controls.Add(this.btn_binary_wr);
            this.Controls.Add(this.txt_product_price);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.txt_product_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_product_id;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.TextBox txt_product_price;
        private System.Windows.Forms.Button btn_binary_wr;
        private System.Windows.Forms.Button btn_binary_rd;
        private System.Windows.Forms.Button btn_json_wr;
        private System.Windows.Forms.Button btn_json_rd;
        private System.Windows.Forms.Button btn_soap_wr;
        private System.Windows.Forms.Button btn_soap_rd;
        private System.Windows.Forms.Button btn_xml_rd;
        private System.Windows.Forms.Button btn_xml_wr;
        private System.Windows.Forms.Button btn_reset;
    }
}