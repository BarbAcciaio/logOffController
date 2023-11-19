namespace LogOffController
{
    partial class LogOffForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOffForm));
            this.hideButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.keepAliveWorker = new System.ComponentModel.BackgroundWorker();
            this.counterLabel = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.awaiLabel = new System.Windows.Forms.Label();
            this.continuousLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.systemLabel = new System.Windows.Forms.Label();
            this.awayValue = new System.Windows.Forms.Label();
            this.continuousValue = new System.Windows.Forms.Label();
            this.displayValue = new System.Windows.Forms.Label();
            this.systemValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hideButton
            // 
            this.hideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.Location = new System.Drawing.Point(177, 196);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(205, 80);
            this.hideButton.TabIndex = 0;
            this.hideButton.Text = "Nascondi";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(12, 10);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(197, 25);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Keeping system alive";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Keeping system alive";
            this.notifyIcon.BalloonTipTitle = "LogOffController";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // keepAliveWorker
            // 
            this.keepAliveWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.keepAliveWorker_DoWork);
            this.keepAliveWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.keepAliveWorker_ProgressChanged);
            this.keepAliveWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.keepAliveWorker_WorkCompleted);
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.Location = new System.Drawing.Point(12, 41);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(100, 20);
            this.counterLabel.TabIndex = 2;
            this.counterLabel.Text = "Cicli eseguiti:";
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.Location = new System.Drawing.Point(118, 41);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(18, 20);
            this.counter.TabIndex = 3;
            this.counter.Text = "0";
            // 
            // awaiLabel
            // 
            this.awaiLabel.AutoSize = true;
            this.awaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awaiLabel.Location = new System.Drawing.Point(12, 83);
            this.awaiLabel.Name = "awaiLabel";
            this.awaiLabel.Size = new System.Drawing.Size(236, 24);
            this.awaiLabel.TabIndex = 4;
            this.awaiLabel.Text = "ES_AWAYMODE_REQUIRED:";
            this.awaiLabel.UseCompatibleTextRendering = true;
            // 
            // continuousLabel
            // 
            this.continuousLabel.AutoSize = true;
            this.continuousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuousLabel.Location = new System.Drawing.Point(10, 107);
            this.continuousLabel.Name = "continuousLabel";
            this.continuousLabel.Size = new System.Drawing.Size(150, 20);
            this.continuousLabel.TabIndex = 5;
            this.continuousLabel.Text = "ES_CONTINUOUS:";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(10, 131);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(209, 20);
            this.displayLabel.TabIndex = 6;
            this.displayLabel.Text = "ES_DISPLAY_REQUIRED:";
            // 
            // systemLabel
            // 
            this.systemLabel.AutoSize = true;
            this.systemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemLabel.Location = new System.Drawing.Point(10, 155);
            this.systemLabel.Name = "systemLabel";
            this.systemLabel.Size = new System.Drawing.Size(206, 20);
            this.systemLabel.TabIndex = 7;
            this.systemLabel.Text = "ES_SYSTEM_REQUIRED:";
            // 
            // awayValue
            // 
            this.awayValue.AutoSize = true;
            this.awayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayValue.Location = new System.Drawing.Point(255, 83);
            this.awayValue.Name = "awayValue";
            this.awayValue.Size = new System.Drawing.Size(48, 20);
            this.awayValue.TabIndex = 8;
            this.awayValue.Text = "False";
            // 
            // continuousValue
            // 
            this.continuousValue.AutoSize = true;
            this.continuousValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuousValue.Location = new System.Drawing.Point(255, 107);
            this.continuousValue.Name = "continuousValue";
            this.continuousValue.Size = new System.Drawing.Size(48, 20);
            this.continuousValue.TabIndex = 9;
            this.continuousValue.Text = "False";
            // 
            // displayValue
            // 
            this.displayValue.AutoSize = true;
            this.displayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayValue.Location = new System.Drawing.Point(255, 131);
            this.displayValue.Name = "displayValue";
            this.displayValue.Size = new System.Drawing.Size(48, 20);
            this.displayValue.TabIndex = 10;
            this.displayValue.Text = "False";
            // 
            // systemValue
            // 
            this.systemValue.AutoSize = true;
            this.systemValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemValue.Location = new System.Drawing.Point(255, 155);
            this.systemValue.Name = "systemValue";
            this.systemValue.Size = new System.Drawing.Size(48, 20);
            this.systemValue.TabIndex = 11;
            this.systemValue.Text = "False";
            // 
            // LogOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 283);
            this.Controls.Add(this.systemValue);
            this.Controls.Add(this.displayValue);
            this.Controls.Add(this.continuousValue);
            this.Controls.Add(this.awayValue);
            this.Controls.Add(this.systemLabel);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.continuousLabel);
            this.Controls.Add(this.awaiLabel);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.hideButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogOffForm";
            this.Text = "LogOff Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.ComponentModel.BackgroundWorker keepAliveWorker;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label awaiLabel;
        private System.Windows.Forms.Label continuousLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label systemLabel;
        private System.Windows.Forms.Label awayValue;
        private System.Windows.Forms.Label continuousValue;
        private System.Windows.Forms.Label displayValue;
        private System.Windows.Forms.Label systemValue;
    }
}

