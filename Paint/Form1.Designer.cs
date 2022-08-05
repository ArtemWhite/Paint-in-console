
namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTool = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnPen = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEllips = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBoxSize = new System.Windows.Forms.ToolStripComboBox();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnEraser = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.цвет2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTool.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.toolStrip1);
            this.panelTool.Controls.Add(this.menuStrip);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(893, 49);
            this.panelTool.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnPen,
            this.toolStripBtnLine,
            this.toolStripBtnRectangle,
            this.toolStripBtnEllips,
            this.toolStripSeparator1,
            this.toolStripBtnEraser,
            this.toolStripBtnClear,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(893, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnPen
            // 
            this.toolStripBtnPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPen.Image")));
            this.toolStripBtnPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPen.Name = "toolStripBtnPen";
            this.toolStripBtnPen.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnPen.Text = "toolStripButton1";
            this.toolStripBtnPen.Click += new System.EventHandler(this.toolStripBtnTool);
            // 
            // toolStripBtnLine
            // 
            this.toolStripBtnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLine.Image")));
            this.toolStripBtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLine.Name = "toolStripBtnLine";
            this.toolStripBtnLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnLine.Text = "toolStripButton2";
            this.toolStripBtnLine.Click += new System.EventHandler(this.toolStripBtnTool);
            // 
            // toolStripBtnRectangle
            // 
            this.toolStripBtnRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRectangle.Image")));
            this.toolStripBtnRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRectangle.Name = "toolStripBtnRectangle";
            this.toolStripBtnRectangle.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnRectangle.Text = "toolStripButton3";
            this.toolStripBtnRectangle.Click += new System.EventHandler(this.toolStripBtnTool);
            // 
            // toolStripBtnEllips
            // 
            this.toolStripBtnEllips.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnEllips.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEllips.Image")));
            this.toolStripBtnEllips.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEllips.Name = "toolStripBtnEllips";
            this.toolStripBtnEllips.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnEllips.Text = "toolStripButton4";
            this.toolStripBtnEllips.Click += new System.EventHandler(this.toolStripBtnTool);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментToolStripMenuItem,
            this.cBoxSize,
            this.цветToolStripMenuItem,
            this.цвет2ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(893, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // инструментToolStripMenuItem
            // 
            this.инструментToolStripMenuItem.Name = "инструментToolStripMenuItem";
            this.инструментToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.инструментToolStripMenuItem.Text = "Инструмент";
            // 
            // cBoxSize
            // 
            this.cBoxSize.Items.AddRange(new object[] {
            "2",
            "5",
            "10",
            "12",
            "15"});
            this.cBoxSize.Name = "cBoxSize";
            this.cBoxSize.Size = new System.Drawing.Size(75, 23);
            this.cBoxSize.Text = "5";
            this.cBoxSize.TextChanged += new System.EventHandler(this.cBoxSize_TextChanged);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
            // 
            // panelDrawing
            // 
            this.panelDrawing.BackColor = System.Drawing.SystemColors.Window;
            this.panelDrawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawing.Location = new System.Drawing.Point(0, 49);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(893, 401);
            this.panelDrawing.TabIndex = 1;
            this.panelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawing_Paint);
            this.panelDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseDown);
            this.panelDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseMove);
            this.panelDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseUp);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnEraser
            // 
            this.toolStripBtnEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnEraser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEraser.Image")));
            this.toolStripBtnEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEraser.Name = "toolStripBtnEraser";
            this.toolStripBtnEraser.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnEraser.Text = "toolStripButton1";
            this.toolStripBtnEraser.Click += new System.EventHandler(this.toolStripBtnTool);
            // 
            // toolStripBtnClear
            // 
            this.toolStripBtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnClear.Image")));
            this.toolStripBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnClear.Name = "toolStripBtnClear";
            this.toolStripBtnClear.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnClear.Text = "toolStripButton1";
            this.toolStripBtnClear.Click += new System.EventHandler(this.toolStripBtnTool);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // цвет2ToolStripMenuItem
            // 
            this.цвет2ToolStripMenuItem.Name = "цвет2ToolStripMenuItem";
            this.цвет2ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.цвет2ToolStripMenuItem.Text = "Цвет2";
            this.цвет2ToolStripMenuItem.Click += new System.EventHandler(this.цвет2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.panelTool);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnPen;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.ToolStripButton toolStripBtnLine;
        private System.Windows.Forms.ToolStripButton toolStripBtnRectangle;
        private System.Windows.Forms.ToolStripButton toolStripBtnEllips;
        private System.Windows.Forms.ToolStripMenuItem инструментToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cBoxSize;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnEraser;
        private System.Windows.Forms.ToolStripButton toolStripBtnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem цвет2ToolStripMenuItem;
    }
}

