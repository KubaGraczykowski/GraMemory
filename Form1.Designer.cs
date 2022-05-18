
namespace GraMemory
{
    partial class FormMemory
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
            this.components = new System.ComponentModel.Container();
            this.panelKart = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCzas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPunkty = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.timerShowTime = new System.Windows.Forms.Timer(this.components);
            this.timerGameTime = new System.Windows.Forms.Timer(this.components);
            this.timerHiding = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelKart
            // 
            this.panelKart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelKart.Location = new System.Drawing.Point(7, 56);
            this.panelKart.Name = "panelKart";
            this.panelKart.Size = new System.Drawing.Size(587, 74);
            this.panelKart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Czas:";
            // 
            // labelCzas
            // 
            this.labelCzas.AutoSize = true;
            this.labelCzas.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCzas.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelCzas.Location = new System.Drawing.Point(73, 14);
            this.labelCzas.Name = "labelCzas";
            this.labelCzas.Size = new System.Drawing.Size(34, 21);
            this.labelCzas.TabIndex = 2;
            this.labelCzas.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(130, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Punkty:";
            // 
            // labelPunkty
            // 
            this.labelPunkty.AutoSize = true;
            this.labelPunkty.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPunkty.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelPunkty.Location = new System.Drawing.Point(207, 13);
            this.labelPunkty.Name = "labelPunkty";
            this.labelPunkty.Size = new System.Drawing.Size(22, 21);
            this.labelPunkty.TabIndex = 4;
            this.labelPunkty.Text = "0";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelStart.Location = new System.Drawing.Point(377, 14);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(222, 21);
            this.labelStart.TabIndex = 5;
            this.labelStart.Text = "Gra rozpocznie sie za 5";
            // 
            // timerShowTime
            // 
            this.timerShowTime.Interval = 1000;
            this.timerShowTime.Tick += new System.EventHandler(this.timerShowTime_Tick);
            // 
            // timerGameTime
            // 
            this.timerGameTime.Interval = 1000;
            this.timerGameTime.Tick += new System.EventHandler(this.timerGameTime_Tick);
            // 
            // timerHiding
            // 
            this.timerHiding.Interval = 1000;
            this.timerHiding.Tick += new System.EventHandler(this.timerHiding_Tick);
            // 
            // FormMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 144);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelPunkty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCzas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelKart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMemory";
            this.Text = "GraMemory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCzas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPunkty;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Timer timerShowTime;
        private System.Windows.Forms.Timer timerGameTime;
        private System.Windows.Forms.Timer timerHiding;
    }
}

