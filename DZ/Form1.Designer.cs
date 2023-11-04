namespace DZ
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
            this.ProcessList = new System.Windows.Forms.ListBox();
            this.ShowInfo = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.CloseProcess = new System.Windows.Forms.Button();
            this.StartPaint = new System.Windows.Forms.Button();
            this.StartMyApp = new System.Windows.Forms.Button();
            this.StartNotepad = new System.Windows.Forms.Button();
            this.StartCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProcessList
            // 
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.Location = new System.Drawing.Point(12, 12);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(205, 368);
            this.ProcessList.TabIndex = 0;
            // 
            // ShowInfo
            // 
            this.ShowInfo.Location = new System.Drawing.Point(223, 12);
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.Size = new System.Drawing.Size(245, 35);
            this.ShowInfo.TabIndex = 1;
            this.ShowInfo.Text = "Показать информацию о процессе";
            this.ShowInfo.UseVisualStyleBackColor = true;
            this.ShowInfo.Click += new System.EventHandler(this.ShowInfo_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Info.Location = new System.Drawing.Point(223, 61);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(51, 20);
            this.Info.TabIndex = 2;
            this.Info.Text = "label1";
            // 
            // CloseProcess
            // 
            this.CloseProcess.Location = new System.Drawing.Point(226, 263);
            this.CloseProcess.Name = "CloseProcess";
            this.CloseProcess.Size = new System.Drawing.Size(242, 35);
            this.CloseProcess.TabIndex = 3;
            this.CloseProcess.Text = "Закрыть процесс";
            this.CloseProcess.UseVisualStyleBackColor = true;
            this.CloseProcess.Click += new System.EventHandler(this.CloseProcess_Click);
            // 
            // StartPaint
            // 
            this.StartPaint.Location = new System.Drawing.Point(223, 345);
            this.StartPaint.Name = "StartPaint";
            this.StartPaint.Size = new System.Drawing.Size(120, 35);
            this.StartPaint.TabIndex = 4;
            this.StartPaint.Text = "Paint";
            this.StartPaint.UseVisualStyleBackColor = true;
            this.StartPaint.Click += new System.EventHandler(this.StartPaint_Click);
            // 
            // StartMyApp
            // 
            this.StartMyApp.Location = new System.Drawing.Point(348, 345);
            this.StartMyApp.Name = "StartMyApp";
            this.StartMyApp.Size = new System.Drawing.Size(120, 35);
            this.StartMyApp.TabIndex = 5;
            this.StartMyApp.Text = "Эта прога";
            this.StartMyApp.UseVisualStyleBackColor = true;
            this.StartMyApp.Click += new System.EventHandler(this.StartMyApp_Click);
            // 
            // StartNotepad
            // 
            this.StartNotepad.Location = new System.Drawing.Point(223, 304);
            this.StartNotepad.Name = "StartNotepad";
            this.StartNotepad.Size = new System.Drawing.Size(120, 35);
            this.StartNotepad.TabIndex = 6;
            this.StartNotepad.Text = "Блокнот";
            this.StartNotepad.UseVisualStyleBackColor = true;
            this.StartNotepad.Click += new System.EventHandler(this.StartNotepad_Click);
            // 
            // StartCalc
            // 
            this.StartCalc.Location = new System.Drawing.Point(348, 304);
            this.StartCalc.Name = "StartCalc";
            this.StartCalc.Size = new System.Drawing.Size(120, 35);
            this.StartCalc.TabIndex = 7;
            this.StartCalc.Text = "Калькулятор";
            this.StartCalc.UseVisualStyleBackColor = true;
            this.StartCalc.Click += new System.EventHandler(this.StartCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 395);
            this.Controls.Add(this.StartCalc);
            this.Controls.Add(this.StartNotepad);
            this.Controls.Add(this.StartMyApp);
            this.Controls.Add(this.StartPaint);
            this.Controls.Add(this.CloseProcess);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.ShowInfo);
            this.Controls.Add(this.ProcessList);
            this.Name = "Form1";
            this.Text = "Processes Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProcessList;
        private System.Windows.Forms.Button ShowInfo;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button CloseProcess;
        private System.Windows.Forms.Button StartPaint;
        private System.Windows.Forms.Button StartMyApp;
        private System.Windows.Forms.Button StartNotepad;
        private System.Windows.Forms.Button StartCalc;
    }
}

