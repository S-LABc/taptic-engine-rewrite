namespace Apple_Taptic_Engine_Rewrite
{
    partial class TapticEngineRewrite
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
            this.lblNumTESN = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbTapticEngineSN = new MetroFramework.Controls.MetroTextBox();
            this.cbModelType = new MetroFramework.Controls.MetroComboBox();
            this.cbPort = new MetroFramework.Controls.MetroComboBox();
            this.btnWrite = new MetroFramework.Controls.MetroButton();
            this.spTAPTIC = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // lblNumTESN
            // 
            this.lblNumTESN.Enabled = false;
            this.lblNumTESN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNumTESN.Location = new System.Drawing.Point(339, 80);
            this.lblNumTESN.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.lblNumTESN.Name = "lblNumTESN";
            this.lblNumTESN.Size = new System.Drawing.Size(55, 21);
            this.lblNumTESN.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblNumTESN.TabIndex = 15;
            this.lblNumTESN.Text = "-- / --";
            this.lblNumTESN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNumTESN.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Enabled = false;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(15, 80);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(185, 21);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Taptic Engine Serial Number";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbTapticEngineSN
            // 
            this.tbTapticEngineSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.tbTapticEngineSN.CustomButton.Image = null;
            this.tbTapticEngineSN.CustomButton.Location = new System.Drawing.Point(356, 1);
            this.tbTapticEngineSN.CustomButton.Name = "";
            this.tbTapticEngineSN.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbTapticEngineSN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTapticEngineSN.CustomButton.TabIndex = 1;
            this.tbTapticEngineSN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTapticEngineSN.CustomButton.UseSelectable = true;
            this.tbTapticEngineSN.CustomButton.Visible = false;
            this.tbTapticEngineSN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbTapticEngineSN.Lines = new string[0];
            this.tbTapticEngineSN.Location = new System.Drawing.Point(15, 103);
            this.tbTapticEngineSN.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tbTapticEngineSN.MaxLength = 0;
            this.tbTapticEngineSN.Name = "tbTapticEngineSN";
            this.tbTapticEngineSN.PasswordChar = '\0';
            this.tbTapticEngineSN.PromptText = "Taptic Engine SN";
            this.tbTapticEngineSN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTapticEngineSN.SelectedText = "";
            this.tbTapticEngineSN.SelectionLength = 0;
            this.tbTapticEngineSN.SelectionStart = 0;
            this.tbTapticEngineSN.ShortcutsEnabled = true;
            this.tbTapticEngineSN.Size = new System.Drawing.Size(380, 25);
            this.tbTapticEngineSN.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbTapticEngineSN.TabIndex = 13;
            this.tbTapticEngineSN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTapticEngineSN.UseSelectable = true;
            this.tbTapticEngineSN.WaterMark = "Taptic Engine SN";
            this.tbTapticEngineSN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTapticEngineSN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbTapticEngineSN.TextChanged += new System.EventHandler(this.tbTapticEngineSN_TextChanged);
            // 
            // cbModelType
            // 
            this.cbModelType.FormattingEnabled = true;
            this.cbModelType.ItemHeight = 23;
            this.cbModelType.Location = new System.Drawing.Point(15, 151);
            this.cbModelType.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.cbModelType.Name = "cbModelType";
            this.cbModelType.Size = new System.Drawing.Size(150, 29);
            this.cbModelType.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbModelType.TabIndex = 16;
            this.cbModelType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbModelType.UseSelectable = true;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.ItemHeight = 23;
            this.cbPort.Items.AddRange(new object[] {
            "COM32"});
            this.cbPort.Location = new System.Drawing.Point(175, 151);
            this.cbPort.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.cbPort.Name = "cbPort";
            this.cbPort.PromptText = "Порт";
            this.cbPort.Size = new System.Drawing.Size(95, 29);
            this.cbPort.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbPort.TabIndex = 17;
            this.cbPort.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbPort.UseSelectable = true;
            this.cbPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbPort_MouseClick);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(280, 151);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(115, 29);
            this.btnWrite.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnWrite.TabIndex = 18;
            this.btnWrite.Text = "Записать";
            this.btnWrite.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnWrite.UseSelectable = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // TapticEngineRewrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 195);
            this.Controls.Add(this.cbModelType);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.lblNumTESN);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbTapticEngineSN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TapticEngineRewrite";
            this.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Apple Taptic Engine Rewrite";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TapticEngineRewrite_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNumTESN;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbTapticEngineSN;
        private MetroFramework.Controls.MetroComboBox cbModelType;
        private MetroFramework.Controls.MetroComboBox cbPort;
        private MetroFramework.Controls.MetroButton btnWrite;
        private System.IO.Ports.SerialPort spTAPTIC;
    }
}

