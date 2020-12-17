
namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.textbox_PositionBoxX = new System.Windows.Forms.TextBox();
            this.textbox_PositionBoxY = new System.Windows.Forms.TextBox();
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.backpanel = new System.Windows.Forms.Panel();
            this.mainCanvas = new System.Windows.Forms.PictureBox();
            this.figureBoxText = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PenButton = new System.Windows.Forms.Button();
            this.PenBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BrushButton = new System.Windows.Forms.Button();
            this.BrushBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FigureBox1 = new System.Windows.Forms.CheckedListBox();
            this.ToolTextBox = new System.Windows.Forms.Label();
            this.ToolBox = new System.Windows.Forms.CheckedListBox();
            this.backpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_PositionBoxX
            // 
            this.textbox_PositionBoxX.BackColor = System.Drawing.SystemColors.Menu;
            this.textbox_PositionBoxX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_PositionBoxX.Location = new System.Drawing.Point(15, 694);
            this.textbox_PositionBoxX.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_PositionBoxX.Name = "textbox_PositionBoxX";
            this.textbox_PositionBoxX.Size = new System.Drawing.Size(75, 15);
            this.textbox_PositionBoxX.TabIndex = 1;
            // 
            // textbox_PositionBoxY
            // 
            this.textbox_PositionBoxY.BackColor = System.Drawing.SystemColors.Menu;
            this.textbox_PositionBoxY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_PositionBoxY.Location = new System.Drawing.Point(80, 694);
            this.textbox_PositionBoxY.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_PositionBoxY.Name = "textbox_PositionBoxY";
            this.textbox_PositionBoxY.Size = new System.Drawing.Size(75, 15);
            this.textbox_PositionBoxY.TabIndex = 2;
            // 
            // DrawTimer
            // 
            this.DrawTimer.Enabled = true;
            this.DrawTimer.Interval = 15;
            // 
            // backpanel
            // 
            this.backpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backpanel.Controls.Add(this.mainCanvas);
            this.backpanel.Location = new System.Drawing.Point(1, 137);
            this.backpanel.Margin = new System.Windows.Forms.Padding(4);
            this.backpanel.Name = "backpanel";
            this.backpanel.Size = new System.Drawing.Size(1323, 547);
            this.backpanel.TabIndex = 3;
            // 
            // mainCanvas
            // 
            this.mainCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainCanvas.BackColor = System.Drawing.Color.White;
            this.mainCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainCanvas.Location = new System.Drawing.Point(14, 4);
            this.mainCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(1290, 539);
            this.mainCanvas.TabIndex = 1;
            this.mainCanvas.TabStop = false;
            this.mainCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseDown);
            this.mainCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseMove);
            this.mainCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseUp);
            // 
            // figureBoxText
            // 
            this.figureBoxText.AutoSize = true;
            this.figureBoxText.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figureBoxText.Location = new System.Drawing.Point(11, 11);
            this.figureBoxText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.figureBoxText.Name = "figureBoxText";
            this.figureBoxText.Size = new System.Drawing.Size(94, 24);
            this.figureBoxText.TabIndex = 5;
            this.figureBoxText.Text = "Фигуры:";
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PenButton);
            this.panel1.Controls.Add(this.PenBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(601, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 117);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(71, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Размер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Цвет";
            // 
            // PenButton
            // 
            this.PenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PenButton.Location = new System.Drawing.Point(75, 34);
            this.PenButton.Margin = new System.Windows.Forms.Padding(4);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(59, 57);
            this.PenButton.TabIndex = 16;
            this.PenButton.Text = "1";
            this.PenButton.UseVisualStyleBackColor = true;
            this.PenButton.TextChanged += new System.EventHandler(this.PenButton_TextChanged);
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // PenBox
            // 
            this.PenBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PenBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PenBox.BackColor = System.Drawing.Color.Black;
            this.PenBox.Checked = true;
            this.PenBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PenBox.Location = new System.Drawing.Point(8, 32);
            this.PenBox.Margin = new System.Windows.Forms.Padding(4);
            this.PenBox.Name = "PenBox";
            this.PenBox.Size = new System.Drawing.Size(59, 57);
            this.PenBox.TabIndex = 9;
            this.PenBox.UseVisualStyleBackColor = false;
            this.PenBox.CheckedChanged += new System.EventHandler(this.PenBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Карандаш";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BrushButton);
            this.panel2.Controls.Add(this.BrushBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(756, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 117);
            this.panel2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(69, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Заливка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Цвет";
            // 
            // BrushButton
            // 
            this.BrushButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BrushButton.Location = new System.Drawing.Point(75, 34);
            this.BrushButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrushButton.Name = "BrushButton";
            this.BrushButton.Size = new System.Drawing.Size(59, 57);
            this.BrushButton.TabIndex = 17;
            this.BrushButton.Text = "1";
            this.BrushButton.UseVisualStyleBackColor = true;
            this.BrushButton.TextChanged += new System.EventHandler(this.BrushButton_TextChanged);
            this.BrushButton.Click += new System.EventHandler(this.BrushButton_Click);
            // 
            // BrushBox
            // 
            this.BrushBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BrushBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.BrushBox.BackColor = System.Drawing.Color.White;
            this.BrushBox.Checked = true;
            this.BrushBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BrushBox.Location = new System.Drawing.Point(8, 32);
            this.BrushBox.Margin = new System.Windows.Forms.Padding(4);
            this.BrushBox.Name = "BrushBox";
            this.BrushBox.Size = new System.Drawing.Size(59, 57);
            this.BrushBox.TabIndex = 9;
            this.BrushBox.UseVisualStyleBackColor = false;
            this.BrushBox.CheckedChanged += new System.EventHandler(this.BrushBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Кисть";
            // 
            // FigureBox1
            // 
            this.FigureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.FigureBox1.CheckOnClick = true;
            this.FigureBox1.FormattingEnabled = true;
            this.FigureBox1.Items.AddRange(new object[] {
            "Прямоугольник",
            "Овал",
            "Линия"});
            this.FigureBox1.Location = new System.Drawing.Point(12, 37);
            this.FigureBox1.Name = "FigureBox1";
            this.FigureBox1.Size = new System.Drawing.Size(143, 89);
            this.FigureBox1.TabIndex = 18;
            this.FigureBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FigureBox1_ItemCheck);
            // 
            // ToolTextBox
            // 
            this.ToolTextBox.AutoSize = true;
            this.ToolTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolTextBox.Location = new System.Drawing.Point(157, 9);
            this.ToolTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToolTextBox.Name = "ToolTextBox";
            this.ToolTextBox.Size = new System.Drawing.Size(94, 24);
            this.ToolTextBox.TabIndex = 19;
            this.ToolTextBox.Text = "Фигуры:";
            // 
            // ToolBox
            // 
            this.ToolBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ToolBox.CheckOnClick = true;
            this.ToolBox.FormattingEnabled = true;
            this.ToolBox.Items.AddRange(new object[] {
            "Выделение"});
            this.ToolBox.Location = new System.Drawing.Point(161, 37);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(143, 89);
            this.ToolBox.TabIndex = 20;
            this.ToolBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ToolBox_ItemCheck);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 722);
            this.Controls.Add(this.ToolBox);
            this.Controls.Add(this.ToolTextBox);
            this.Controls.Add(this.FigureBox1);
            this.Controls.Add(this.textbox_PositionBoxX);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.figureBoxText);
            this.Controls.Add(this.backpanel);
            this.Controls.Add(this.textbox_PositionBoxY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "PAINT";
            this.backpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textbox_PositionBoxX;
        private System.Windows.Forms.TextBox textbox_PositionBoxY;
        private System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.Panel backpanel;
        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.Label figureBoxText;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PenBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox BrushBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BrushButton;
        public System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.CheckedListBox FigureBox1;
        private System.Windows.Forms.Label ToolTextBox;
        private System.Windows.Forms.CheckedListBox ToolBox;
    }
}

