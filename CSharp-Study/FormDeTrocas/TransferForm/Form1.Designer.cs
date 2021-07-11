namespace TransferForm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lista1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lista2 = new System.Windows.Forms.ListBox();
            this.lista1Passa1 = new System.Windows.Forms.Button();
            this.lista1PassaTudo = new System.Windows.Forms.Button();
            this.Lista1Apaga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lista1
            // 
            this.lista1.FormattingEnabled = true;
            this.lista1.Location = new System.Drawing.Point(12, 54);
            this.lista1.Name = "lista1";
            this.lista1.ScrollAlwaysVisible = true;
            this.lista1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lista1.Size = new System.Drawing.Size(120, 173);
            this.lista1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(789, 452);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 1;
            // 
            // lista2
            // 
            this.lista2.FormattingEnabled = true;
            this.lista2.Location = new System.Drawing.Point(261, 54);
            this.lista2.Name = "lista2";
            this.lista2.ScrollAlwaysVisible = true;
            this.lista2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lista2.Size = new System.Drawing.Size(120, 173);
            this.lista2.TabIndex = 2;
            // 
            // lista1Passa1
            // 
            this.lista1Passa1.Location = new System.Drawing.Point(138, 54);
            this.lista1Passa1.Name = "lista1Passa1";
            this.lista1Passa1.Size = new System.Drawing.Size(117, 23);
            this.lista1Passa1.TabIndex = 5;
            this.lista1Passa1.Text = ">";
            this.lista1Passa1.UseVisualStyleBackColor = true;
            this.lista1Passa1.Click += new System.EventHandler(this.Lista1Passa1_Click);
            // 
            // lista1PassaTudo
            // 
            this.lista1PassaTudo.Location = new System.Drawing.Point(138, 83);
            this.lista1PassaTudo.Name = "lista1PassaTudo";
            this.lista1PassaTudo.Size = new System.Drawing.Size(117, 23);
            this.lista1PassaTudo.TabIndex = 6;
            this.lista1PassaTudo.Text = ">>>";
            this.lista1PassaTudo.UseVisualStyleBackColor = true;
            this.lista1PassaTudo.Click += new System.EventHandler(this.lista1PassaTudo_Click);
            // 
            // Lista1Apaga
            // 
            this.Lista1Apaga.Location = new System.Drawing.Point(138, 112);
            this.Lista1Apaga.Name = "Lista1Apaga";
            this.Lista1Apaga.Size = new System.Drawing.Size(117, 23);
            this.Lista1Apaga.TabIndex = 7;
            this.Lista1Apaga.Text = "< X";
            this.Lista1Apaga.UseVisualStyleBackColor = true;
            this.Lista1Apaga.Click += new System.EventHandler(this.Lista1Apaga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Texto para a Lista 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Texto para a Lista 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "<<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "> X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(154, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Multi-Seleção";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.CheckBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Naruto",
            "Jiraya",
            "Sakura",
            "Sasuke"});
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox1_KeyDown);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Naruto",
            "Jiraya",
            "Sakura",
            "Sasuke"});
            this.comboBox2.Location = new System.Drawing.Point(261, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox2_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 236);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lista1Apaga);
            this.Controls.Add(this.lista1PassaTudo);
            this.Controls.Add(this.lista1Passa1);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lista1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox lista2;
        private System.Windows.Forms.Button lista1Passa1;
        private System.Windows.Forms.Button lista1PassaTudo;
        private System.Windows.Forms.Button Lista1Apaga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

