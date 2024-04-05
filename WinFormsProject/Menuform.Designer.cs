namespace WinFormsProject
{
    partial class Menuform
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
            dgv1 = new DataGridView();
            button_view_user = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(27, 104);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.RowTemplate.Height = 29;
            dgv1.Size = new Size(747, 319);
            dgv1.TabIndex = 0;
            // 
            // button_view_user
            // 
            button_view_user.Location = new Point(73, 31);
            button_view_user.Name = "button_view_user";
            button_view_user.Size = new Size(134, 29);
            button_view_user.TabIndex = 1;
            button_view_user.Text = "Xem DS User";
            button_view_user.UseVisualStyleBackColor = true;
            button_view_user.Click += button_view_user_Click;
            // 
            // Menuform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_view_user);
            Controls.Add(dgv1);
            Name = "Menuform";
            Text = "Menuform";
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv1;
        private Button button_view_user;
    }
}