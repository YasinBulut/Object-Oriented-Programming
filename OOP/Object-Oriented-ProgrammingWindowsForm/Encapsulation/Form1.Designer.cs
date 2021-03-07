
namespace Encapsulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsemt = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.txtodasayisi = new System.Windows.Forms.TextBox();
            this.txtkatno = new System.Windows.Forms.TextBox();
            this.txtalan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kat No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alan:";
            // 
            // txtsemt
            // 
            this.txtsemt.Location = new System.Drawing.Point(160, 37);
            this.txtsemt.Name = "txtsemt";
            this.txtsemt.Size = new System.Drawing.Size(187, 34);
            this.txtsemt.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 317);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(481, 121);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Semt:";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oda Sayısı";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kat No:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Alan";
            // 
            // txtodasayisi
            // 
            this.txtodasayisi.Location = new System.Drawing.Point(160, 91);
            this.txtodasayisi.Name = "txtodasayisi";
            this.txtodasayisi.Size = new System.Drawing.Size(187, 34);
            this.txtodasayisi.TabIndex = 6;
            // 
            // txtkatno
            // 
            this.txtkatno.Location = new System.Drawing.Point(160, 146);
            this.txtkatno.Name = "txtkatno";
            this.txtkatno.Size = new System.Drawing.Size(187, 34);
            this.txtkatno.TabIndex = 7;
            // 
            // txtalan
            // 
            this.txtalan.Location = new System.Drawing.Point(160, 193);
            this.txtalan.Name = "txtalan";
            this.txtalan.Size = new System.Drawing.Size(187, 34);
            this.txtalan.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtalan);
            this.Controls.Add(this.txtkatno);
            this.Controls.Add(this.txtodasayisi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtsemt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsemt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtodasayisi;
        private System.Windows.Forms.TextBox txtkatno;
        private System.Windows.Forms.TextBox txtalan;
        private System.Windows.Forms.Button button1;
    }
}

