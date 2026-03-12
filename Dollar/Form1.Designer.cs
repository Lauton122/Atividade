namespace Dollar
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
            label1 = new Label();
            txtCotacao = new TextBox();
            label2 = new Label();
            txtDolares = new TextBox();
            btnConverter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 103);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Cotação Dólar R$";
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(33, 151);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(100, 23);
            txtCotacao.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 103);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantidade Dólar US$";
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(209, 151);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(123, 23);
            txtDolares.TabIndex = 4;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(137, 224);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 6;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 342);
            Controls.Add(btnConverter);
            Controls.Add(txtDolares);
            Controls.Add(label2);
            Controls.Add(txtCotacao);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCotacao;
        private Label label2;
        private TextBox txtDolares;
        private Button btnConverter;
    }
}
