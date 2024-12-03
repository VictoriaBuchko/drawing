using System.Windows.Forms;

namespace drawing
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
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        //Освобождаем все ресурсы, связанные с компонентами формы
        //        if (components != null)
        //        {
        //            components.Dispose();
        //        }

        //        //Додаткове вивільнення вручну створених ресурсів
        //       colorDialog1?.Dispose();  // Освобождение ресурса для colorDialog1
        //    }
        //    base.Dispose(disposing);
        //}



        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            фигуриToolStripMenuItem = new ToolStripMenuItem();
            прямокутникToolStripMenuItem = new ToolStripMenuItem();
            еліпсToolStripMenuItem = new ToolStripMenuItem();
            лініяToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            колірToolStripMenuItem = new ToolStripMenuItem();
            очиститиToolStripMenuItem = new ToolStripMenuItem();
            текстToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // фигуриToolStripMenuItem
            // 
            фигуриToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { прямокутникToolStripMenuItem, еліпсToolStripMenuItem, лініяToolStripMenuItem });
            фигуриToolStripMenuItem.Name = "фигуриToolStripMenuItem";
            фигуриToolStripMenuItem.Size = new Size(74, 24);
            фигуриToolStripMenuItem.Text = "Фигури";
            // 
            // прямокутникToolStripMenuItem
            // 
            прямокутникToolStripMenuItem.Name = "прямокутникToolStripMenuItem";
            прямокутникToolStripMenuItem.Size = new Size(185, 26);
            прямокутникToolStripMenuItem.Text = "Прямокутник";
            прямокутникToolStripMenuItem.Click += прямокутникToolStripMenuItem_Click;
            // 
            // еліпсToolStripMenuItem
            // 
            еліпсToolStripMenuItem.Name = "еліпсToolStripMenuItem";
            еліпсToolStripMenuItem.Size = new Size(185, 26);
            еліпсToolStripMenuItem.Text = "Еліпс";
            еліпсToolStripMenuItem.Click += еліпсToolStripMenuItem_Click;
            // 
            // лініяToolStripMenuItem
            // 
            лініяToolStripMenuItem.Name = "лініяToolStripMenuItem";
            лініяToolStripMenuItem.Size = new Size(185, 26);
            лініяToolStripMenuItem.Text = "Лінія";
            лініяToolStripMenuItem.Click += лініяToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { фигуриToolStripMenuItem, колірToolStripMenuItem, очиститиToolStripMenuItem, текстToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1248, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // колірToolStripMenuItem
            // 
            колірToolStripMenuItem.Name = "колірToolStripMenuItem";
            колірToolStripMenuItem.Size = new Size(66, 24);
            колірToolStripMenuItem.Text = "Колір ";
            колірToolStripMenuItem.Click += колірToolStripMenuItem_Click;
            // 
            // очиститиToolStripMenuItem
            // 
            очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            очиститиToolStripMenuItem.Size = new Size(88, 24);
            очиститиToolStripMenuItem.Text = "Очистити";
            очиститиToolStripMenuItem.Click += очиститиToolStripMenuItem_Click;
            // 
            // текстToolStripMenuItem
            // 
            текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            текстToolStripMenuItem.Size = new Size(59, 24);
            текстToolStripMenuItem.Text = "Текст";
            текстToolStripMenuItem.Click += текстToolStripMenuItem_Click_1;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.RosyBrown;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 598);
            panel1.TabIndex = 1;
            panel1.Paint += DrawingPanel_Paint;
            panel1.MouseClick += DrawingPanel_MouseDown;
            panel1.MouseDown += DrawingPanel_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 681);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem фигуриToolStripMenuItem;
        private ToolStripMenuItem прямокутникToolStripMenuItem;
        private ToolStripMenuItem еліпсToolStripMenuItem;
        private ToolStripMenuItem лініяToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem колірToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem очиститиToolStripMenuItem;
        private ToolStripMenuItem текстToolStripMenuItem;
    }
}
