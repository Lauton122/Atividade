namespace Estrutura
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
            Label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            btnAdicionar = new Button();
            lstpessoas = new ListBox();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(102, 105);
            Label1.Name = "Label1";
            Label1.Size = new Size(43, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 105);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Idade:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(74, 138);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(293, 138);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(198, 199);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lstpessoas
            // 
            lstpessoas.FormattingEnabled = true;
            lstpessoas.ItemHeight = 15;
            lstpessoas.Location = new Point(102, 286);
            lstpessoas.Name = "lstpessoas";
            lstpessoas.Size = new Size(264, 94);
            lstpessoas.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 450);
            Controls.Add(lstpessoas);
            Controls.Add(btnAdicionar);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(Label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Button btnAdicionar;
        private ListBox lstpessoas;
    }
}
