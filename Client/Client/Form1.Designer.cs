namespace Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxListComm = new System.Windows.Forms.TextBox();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.textBoxParams = new System.Windows.Forms.TextBox();
            this.labelCommand = new System.Windows.Forms.Label();
            this.labelParams = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxListComm
            // 
            this.textBoxListComm.Location = new System.Drawing.Point(344, 12);
            this.textBoxListComm.Multiline = true;
            this.textBoxListComm.Name = "textBoxListComm";
            this.textBoxListComm.ReadOnly = true;
            this.textBoxListComm.Size = new System.Drawing.Size(334, 233);
            this.textBoxListComm.TabIndex = 0;
            this.textBoxListComm.Text = resources.GetString("textBoxListComm.Text");
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(40, 142);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(212, 23);
            this.textBoxCommand.TabIndex = 1;
            // 
            // textBoxParams
            // 
            this.textBoxParams.Location = new System.Drawing.Point(40, 228);
            this.textBoxParams.Name = "textBoxParams";
            this.textBoxParams.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxParams.Size = new System.Drawing.Size(212, 23);
            this.textBoxParams.TabIndex = 2;
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(40, 127);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(99, 15);
            this.labelCommand.TabIndex = 3;
            this.labelCommand.Text = "Введіть команду:";
            // 
            // labelParams
            // 
            this.labelParams.AutoSize = true;
            this.labelParams.Location = new System.Drawing.Point(40, 210);
            this.labelParams.Name = "labelParams";
            this.labelParams.Size = new System.Drawing.Size(112, 15);
            this.labelParams.TabIndex = 4;
            this.labelParams.Text = "Введіть параметри:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(95, 292);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(99, 23);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Відправити";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(95, 337);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(99, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(344, 250);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.ReadOnly = true;
            this.textBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSend.Size = new System.Drawing.Size(334, 188);
            this.textBoxSend.TabIndex = 7;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(40, 385);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelParams);
            this.Controls.Add(this.labelCommand);
            this.Controls.Add(this.textBoxParams);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.textBoxListComm);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxListComm;
        private TextBox textBoxCommand;
        private TextBox textBoxParams;
        private Label labelCommand;
        private Label labelParams;
        private Button buttonSend;
        private Button buttonStop;
        private TextBox textBoxSend;
        private Label labelError;
    }
}