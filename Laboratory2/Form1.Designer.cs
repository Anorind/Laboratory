namespace Laboratory2
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
            productsListBox = new ListBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            clearListButton = new Button();
            SuspendLayout();
            // 
            // productsListBox
            // 
            productsListBox.FormattingEnabled = true;
            productsListBox.ItemHeight = 25;
            productsListBox.Location = new Point(-1, 14);
            productsListBox.Name = "productsListBox";
            productsListBox.Size = new Size(457, 329);
            productsListBox.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(-1, 349);
            addButton.Name = "addButton";
            addButton.Size = new Size(457, 34);
            addButton.TabIndex = 1;
            addButton.Text = "Додати товар";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(-1, 389);
            editButton.Name = "editButton";
            editButton.Size = new Size(457, 34);
            editButton.TabIndex = 2;
            editButton.Text = "Редагувати товар";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(-1, 429);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(457, 34);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Видалити товар";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // clearListButton
            // 
            clearListButton.Location = new Point(-1, 469);
            clearListButton.Name = "clearListButton";
            clearListButton.Size = new Size(457, 34);
            clearListButton.TabIndex = 4;
            clearListButton.Text = "Очистити список";
            clearListButton.UseVisualStyleBackColor = true;
            clearListButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 500);
            Controls.Add(clearListButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(productsListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox productsListBox;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button clearListButton;
    }
}