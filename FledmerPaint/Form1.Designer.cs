
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figureBox = new System.Windows.Forms.ComboBox();
            this.figureBoxText = new System.Windows.Forms.Label();
            this.backpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_PositionBoxX
            // 
            this.textbox_PositionBoxX.BackColor = System.Drawing.SystemColors.Menu;
            this.textbox_PositionBoxX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_PositionBoxX.Location = new System.Drawing.Point(12, 752);
            this.textbox_PositionBoxX.Name = "textbox_PositionBoxX";
            this.textbox_PositionBoxX.Size = new System.Drawing.Size(56, 13);
            this.textbox_PositionBoxX.TabIndex = 1;
            // 
            // textbox_PositionBoxY
            // 
            this.textbox_PositionBoxY.BackColor = System.Drawing.SystemColors.Menu;
            this.textbox_PositionBoxY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_PositionBoxY.Location = new System.Drawing.Point(74, 752);
            this.textbox_PositionBoxY.Name = "textbox_PositionBoxY";
            this.textbox_PositionBoxY.Size = new System.Drawing.Size(56, 13);
            this.textbox_PositionBoxY.TabIndex = 2;
            // 
            // DrawTimer
            // 
            this.DrawTimer.Enabled = true;
            this.DrawTimer.Interval = 15;
            // 
            // backpanel
            // 
            this.backpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backpanel.Controls.Add(this.mainCanvas);
            this.backpanel.Controls.Add(this.menuStrip1);
            this.backpanel.Location = new System.Drawing.Point(1, 72);
            this.backpanel.Name = "backpanel";
            this.backpanel.Size = new System.Drawing.Size(1291, 674);
            this.backpanel.TabIndex = 3;
            // 
            // mainCanvas
            // 
            this.mainCanvas.BackColor = System.Drawing.Color.White;
            this.mainCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainCanvas.Location = new System.Drawing.Point(11, 27);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(1266, 635);
            this.mainCanvas.TabIndex = 1;
            this.mainCanvas.TabStop = false;
            this.mainCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseDown);
            this.mainCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseMove);
            this.mainCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1291, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figureBox
            // 
            this.figureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figureBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.figureBox.FormattingEnabled = true;
            this.figureBox.Items.AddRange(new object[] {
            "Линия",
            "Прямоугольник",
            "Элипс"});
            this.figureBox.Location = new System.Drawing.Point(12, 31);
            this.figureBox.Name = "figureBox";
            this.figureBox.Size = new System.Drawing.Size(118, 21);
            this.figureBox.TabIndex = 4;
            this.figureBox.SelectedValueChanged += new System.EventHandler(this.figureBox_SelectedValueChanged);
            // 
            // figureBoxText
            // 
            this.figureBoxText.AutoSize = true;
            this.figureBoxText.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figureBoxText.Location = new System.Drawing.Point(8, 9);
            this.figureBoxText.Name = "figureBoxText";
            this.figureBoxText.Size = new System.Drawing.Size(75, 19);
            this.figureBoxText.TabIndex = 5;
            this.figureBoxText.Text = "Фигуры:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 777);
            this.Controls.Add(this.figureBoxText);
            this.Controls.Add(this.figureBox);
            this.Controls.Add(this.backpanel);
            this.Controls.Add(this.textbox_PositionBoxY);
            this.Controls.Add(this.textbox_PositionBoxX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PAINT";
            this.backpanel.ResumeLayout(false);
            this.backpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textbox_PositionBoxX;
        private System.Windows.Forms.TextBox textbox_PositionBoxY;
        private System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.Panel backpanel;
        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox figureBox;
        private System.Windows.Forms.Label figureBoxText;
    }
}

