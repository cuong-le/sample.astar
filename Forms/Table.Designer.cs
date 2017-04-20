namespace CGS.Sample.AStar.Forms
{
    partial class Table
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
            this.pnl_Control = new System.Windows.Forms.Panel();
            this.btn_GenerateMap = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_FindWay = new System.Windows.Forms.Button();
            this.btn_ChangeSize = new System.Windows.Forms.Button();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.pnl_Map = new System.Windows.Forms.Panel();
            this.grid_Map = new System.Windows.Forms.DataGridView();
            this.btn_GenerateAll = new System.Windows.Forms.Button();
            this.pnl_Control.SuspendLayout();
            this.pnl_Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Control
            // 
            this.pnl_Control.Controls.Add(this.btn_GenerateAll);
            this.pnl_Control.Controls.Add(this.btn_GenerateMap);
            this.pnl_Control.Controls.Add(this.label10);
            this.pnl_Control.Controls.Add(this.label9);
            this.pnl_Control.Controls.Add(this.label8);
            this.pnl_Control.Controls.Add(this.label7);
            this.pnl_Control.Controls.Add(this.label6);
            this.pnl_Control.Controls.Add(this.label5);
            this.pnl_Control.Controls.Add(this.label4);
            this.pnl_Control.Controls.Add(this.label3);
            this.pnl_Control.Controls.Add(this.label2);
            this.pnl_Control.Controls.Add(this.label1);
            this.pnl_Control.Controls.Add(this.btn_FindWay);
            this.pnl_Control.Controls.Add(this.btn_ChangeSize);
            this.pnl_Control.Controls.Add(this.txt_Height);
            this.pnl_Control.Controls.Add(this.txt_Width);
            this.pnl_Control.Controls.Add(this.lbl_Height);
            this.pnl_Control.Controls.Add(this.lbl_Width);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Control.Location = new System.Drawing.Point(984, 0);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(200, 511);
            this.pnl_Control.TabIndex = 1;
            // 
            // btn_GenerateMap
            // 
            this.btn_GenerateMap.Location = new System.Drawing.Point(35, 98);
            this.btn_GenerateMap.Name = "btn_GenerateMap";
            this.btn_GenerateMap.Size = new System.Drawing.Size(128, 28);
            this.btn_GenerateMap.TabIndex = 4;
            this.btn_GenerateMap.Text = "Generate Map";
            this.btn_GenerateMap.UseVisualStyleBackColor = true;
            this.btn_GenerateMap.Click += new System.EventHandler(this.btn_GenerateMap_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 99;
            this.label10.Text = "way";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "O";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "end point";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "E";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "start point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "not walkable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "walkable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Empty";
            // 
            // btn_FindWay
            // 
            this.btn_FindWay.Location = new System.Drawing.Point(35, 166);
            this.btn_FindWay.Name = "btn_FindWay";
            this.btn_FindWay.Size = new System.Drawing.Size(128, 28);
            this.btn_FindWay.TabIndex = 6;
            this.btn_FindWay.Text = "Find Way";
            this.btn_FindWay.UseVisualStyleBackColor = true;
            this.btn_FindWay.Click += new System.EventHandler(this.btn_FindWay_Click);
            // 
            // btn_ChangeSize
            // 
            this.btn_ChangeSize.Location = new System.Drawing.Point(35, 64);
            this.btn_ChangeSize.Name = "btn_ChangeSize";
            this.btn_ChangeSize.Size = new System.Drawing.Size(128, 28);
            this.btn_ChangeSize.TabIndex = 3;
            this.btn_ChangeSize.Text = "Change Size";
            this.btn_ChangeSize.UseVisualStyleBackColor = true;
            this.btn_ChangeSize.Click += new System.EventHandler(this.btn_ChangeSize_Click);
            // 
            // txt_Height
            // 
            this.txt_Height.Location = new System.Drawing.Point(118, 38);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(45, 20);
            this.txt_Height.TabIndex = 2;
            this.txt_Height.Text = "5";
            this.txt_Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Height_KeyPress);
            // 
            // txt_Width
            // 
            this.txt_Width.Location = new System.Drawing.Point(118, 12);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(45, 20);
            this.txt_Width.TabIndex = 1;
            this.txt_Width.Text = "5";
            this.txt_Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Width_KeyPress);
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(32, 41);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(38, 13);
            this.lbl_Height.TabIndex = 0;
            this.lbl_Height.Text = "Height";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(32, 15);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(35, 13);
            this.lbl_Width.TabIndex = 0;
            this.lbl_Width.Text = "Width";
            // 
            // pnl_Map
            // 
            this.pnl_Map.Controls.Add(this.grid_Map);
            this.pnl_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Map.Location = new System.Drawing.Point(0, 0);
            this.pnl_Map.Name = "pnl_Map";
            this.pnl_Map.Size = new System.Drawing.Size(984, 511);
            this.pnl_Map.TabIndex = 2;
            // 
            // grid_Map
            // 
            this.grid_Map.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Map.Location = new System.Drawing.Point(3, 3);
            this.grid_Map.Name = "grid_Map";
            this.grid_Map.Size = new System.Drawing.Size(200, 200);
            this.grid_Map.TabIndex = 4;
            this.grid_Map.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Map_CellClick);
            // 
            // btn_GenerateAll
            // 
            this.btn_GenerateAll.Location = new System.Drawing.Point(35, 132);
            this.btn_GenerateAll.Name = "btn_GenerateAll";
            this.btn_GenerateAll.Size = new System.Drawing.Size(128, 28);
            this.btn_GenerateAll.TabIndex = 5;
            this.btn_GenerateAll.Text = "Generate Size and Map";
            this.btn_GenerateAll.UseVisualStyleBackColor = true;
            this.btn_GenerateAll.Click += new System.EventHandler(this.btn_GenerateAll_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.pnl_Map);
            this.Controls.Add(this.pnl_Control);
            this.Name = "Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGS - Sample - A*";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AStar_FormClosed);
            this.Load += new System.EventHandler(this.AStar_Load);
            this.pnl_Control.ResumeLayout(false);
            this.pnl_Control.PerformLayout();
            this.pnl_Map.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Control;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Button btn_ChangeSize;
        private System.Windows.Forms.Panel pnl_Map;
        private System.Windows.Forms.DataGridView grid_Map;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_FindWay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_GenerateMap;
        private System.Windows.Forms.Button btn_GenerateAll;
    }
}