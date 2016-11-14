namespace FernDB
{
    partial class vfDbMessages
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
            this.dbMessages = new System.Windows.Forms.TextBox();
            this.bDatabaseMessagesClose = new System.Windows.Forms.Button();
            this.bDatabaseMessages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbMessages
            // 
            this.dbMessages.BackColor = System.Drawing.SystemColors.Window;
            this.dbMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbMessages.CausesValidation = false;
            this.dbMessages.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbMessages.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dbMessages.Location = new System.Drawing.Point(4, 5);
            this.dbMessages.Multiline = true;
            this.dbMessages.Name = "dbMessages";
            this.dbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dbMessages.Size = new System.Drawing.Size(377, 314);
            this.dbMessages.TabIndex = 2;
            // 
            // bDatabaseMessagesClose
            // 
            this.bDatabaseMessagesClose.BackColor = System.Drawing.SystemColors.Window;
            this.bDatabaseMessagesClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDatabaseMessagesClose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDatabaseMessagesClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bDatabaseMessagesClose.Location = new System.Drawing.Point(297, 326);
            this.bDatabaseMessagesClose.Name = "bDatabaseMessagesClose";
            this.bDatabaseMessagesClose.Size = new System.Drawing.Size(75, 25);
            this.bDatabaseMessagesClose.TabIndex = 1;
            this.bDatabaseMessagesClose.Text = "Close";
            this.bDatabaseMessagesClose.UseVisualStyleBackColor = false;
            this.bDatabaseMessagesClose.Click += new System.EventHandler(this.bDatabaseMessagesClose_Click);
            // 
            // bDatabaseMessages
            // 
            this.bDatabaseMessages.BackColor = System.Drawing.SystemColors.Window;
            this.bDatabaseMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDatabaseMessages.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDatabaseMessages.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bDatabaseMessages.Location = new System.Drawing.Point(12, 326);
            this.bDatabaseMessages.Name = "bDatabaseMessages";
            this.bDatabaseMessages.Size = new System.Drawing.Size(75, 25);
            this.bDatabaseMessages.TabIndex = 0;
            this.bDatabaseMessages.Text = "Refersh";
            this.bDatabaseMessages.UseVisualStyleBackColor = false;
            this.bDatabaseMessages.Click += new System.EventHandler(this.bDatabaseMessagesRefresh_Click);
            // 
            // vfDbMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.bDatabaseMessages);
            this.Controls.Add(this.bDatabaseMessagesClose);
            this.Controls.Add(this.dbMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "vfDbMessages";
            this.Text = "Database Messages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dbMessages;
        private System.Windows.Forms.Button bDatabaseMessagesClose;
        private System.Windows.Forms.Button bDatabaseMessages;
    }
}