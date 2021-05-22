
namespace WinDraw
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
            this.pnlParams = new System.Windows.Forms.Panel();
            this.dgvFigData = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btdDraw = new System.Windows.Forms.Button();
            this.lbLineColour = new System.Windows.Forms.Label();
            this.btnLineColour = new System.Windows.Forms.Button();
            this.lbLineWidth = new System.Windows.Forms.Label();
            this.edLineWidth = new System.Windows.Forms.NumericUpDown();
            this.lbFigures = new System.Windows.Forms.ListBox();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.dlgSetColour = new System.Windows.Forms.ColorDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.pnlParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFigData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlParams
            // 
            this.pnlParams.Controls.Add(this.dgvFigData);
            this.pnlParams.Controls.Add(this.btnLoad);
            this.pnlParams.Controls.Add(this.btnSave);
            this.pnlParams.Controls.Add(this.btdDraw);
            this.pnlParams.Controls.Add(this.lbLineColour);
            this.pnlParams.Controls.Add(this.btnLineColour);
            this.pnlParams.Controls.Add(this.lbLineWidth);
            this.pnlParams.Controls.Add(this.edLineWidth);
            this.pnlParams.Controls.Add(this.lbFigures);
            this.pnlParams.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlParams.Location = new System.Drawing.Point(621, 0);
            this.pnlParams.Name = "pnlParams";
            this.pnlParams.Size = new System.Drawing.Size(179, 450);
            this.pnlParams.TabIndex = 0;
            // 
            // dgvFigData
            // 
            this.dgvFigData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFigData.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFigData.Location = new System.Drawing.Point(0, 100);
            this.dgvFigData.Name = "dgvFigData";
            this.dgvFigData.Size = new System.Drawing.Size(179, 126);
            this.dgvFigData.TabIndex = 9;
            this.dgvFigData.Leave += new System.EventHandler(this.dgvFigData_Leave);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(15, 395);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(69, 30);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(102, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btdDraw
            // 
            this.btdDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdDraw.Location = new System.Drawing.Point(15, 332);
            this.btdDraw.Name = "btdDraw";
            this.btdDraw.Size = new System.Drawing.Size(152, 41);
            this.btdDraw.TabIndex = 6;
            this.btdDraw.Text = "Draw Figure";
            this.btdDraw.UseVisualStyleBackColor = true;
            this.btdDraw.Click += new System.EventHandler(this.btdDraw_Click);
            // 
            // lbLineColour
            // 
            this.lbLineColour.AutoSize = true;
            this.lbLineColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineColour.Location = new System.Drawing.Point(21, 291);
            this.lbLineColour.Name = "lbLineColour";
            this.lbLineColour.Size = new System.Drawing.Size(75, 16);
            this.lbLineColour.TabIndex = 5;
            this.lbLineColour.Text = "Line Colour";
            // 
            // btnLineColour
            // 
            this.btnLineColour.BackColor = System.Drawing.Color.Black;
            this.btnLineColour.Location = new System.Drawing.Point(102, 283);
            this.btnLineColour.Name = "btnLineColour";
            this.btnLineColour.Size = new System.Drawing.Size(65, 32);
            this.btnLineColour.TabIndex = 4;
            this.btnLineColour.UseVisualStyleBackColor = false;
            this.btnLineColour.Click += new System.EventHandler(this.btnLineColour_Click);
            // 
            // lbLineWidth
            // 
            this.lbLineWidth.AutoSize = true;
            this.lbLineWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineWidth.Location = new System.Drawing.Point(21, 253);
            this.lbLineWidth.Name = "lbLineWidth";
            this.lbLineWidth.Size = new System.Drawing.Size(70, 16);
            this.lbLineWidth.TabIndex = 3;
            this.lbLineWidth.Text = "Line Width";
            // 
            // edLineWidth
            // 
            this.edLineWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLineWidth.Location = new System.Drawing.Point(102, 251);
            this.edLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edLineWidth.Name = "edLineWidth";
            this.edLineWidth.Size = new System.Drawing.Size(65, 22);
            this.edLineWidth.TabIndex = 2;
            this.edLineWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbFigures
            // 
            this.lbFigures.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFigures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFigures.FormattingEnabled = true;
            this.lbFigures.ItemHeight = 16;
            this.lbFigures.Location = new System.Drawing.Point(0, 0);
            this.lbFigures.Name = "lbFigures";
            this.lbFigures.Size = new System.Drawing.Size(179, 100);
            this.lbFigures.TabIndex = 0;
            this.lbFigures.SelectedIndexChanged += new System.EventHandler(this.lbFigures_SelectedIndexChanged);
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.White;
            this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDraw.Location = new System.Drawing.Point(0, 0);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(621, 450);
            this.pnlDraw.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.pnlParams);
            this.Name = "frmMain";
            this.Text = "Draw";
            this.pnlParams.ResumeLayout(false);
            this.pnlParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFigData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLineWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlParams;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.ListBox lbFigures;
        private System.Windows.Forms.Label lbLineWidth;
        private System.Windows.Forms.NumericUpDown edLineWidth;
        private System.Windows.Forms.Button btnLineColour;
        private System.Windows.Forms.ColorDialog dlgSetColour;
        private System.Windows.Forms.Label lbLineColour;
        private System.Windows.Forms.Button btdDraw;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvFigData;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}

