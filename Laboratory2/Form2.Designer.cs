namespace Laboratory2
{
    partial class Form2
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
            nameTextBox = new TextBox();
            labelName = new Label();
            labelCountry = new Label();
            labelCost = new Label();
            countryTextBox = new TextBox();
            priceTextBox = new TextBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(27, 63);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(357, 31);
            nameTextBox.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(27, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(61, 25);
            labelName.TabIndex = 1;
            labelName.Text = "Назва";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(27, 121);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(155, 25);
            labelCountry.TabIndex = 2;
            labelCountry.Text = "Страна виробник";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(27, 238);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(48, 25);
            labelCost.TabIndex = 3;
            labelCost.Text = "Ціна";
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(27, 173);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(357, 31);
            countryTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(27, 293);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(357, 31);
            priceTextBox.TabIndex = 5;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(28, 373);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(113, 34);
            buttonOK.TabIndex = 6;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += saveButton_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(253, 373);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(priceTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(labelCost);
            Controls.Add(labelCountry);
            Controls.Add(labelName);
            Controls.Add(nameTextBox);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label labelName;
        private Label labelCountry;
        private Label labelCost;
        private TextBox countryTextBox;
        private TextBox priceTextBox;
        private Button buttonOK;
        private Button buttonCancel;
    }
}