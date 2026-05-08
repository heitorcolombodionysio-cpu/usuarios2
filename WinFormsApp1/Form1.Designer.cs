namespace WinFormsApp1
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
            btn_submit = new Button();
            date = new DateTimePicker();
            cb_sexo = new ComboBox();
            mtxtb_cpf = new MaskedTextBox();
            txtb_rm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtb_name = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cb_nat = new ComboBox();
            btn_limpar = new Button();
            btn_fechar = new Button();
            btn_gt = new Button();
            btn_pc = new Button();
            btn_chrome = new Button();
            btn_notepad = new Button();
            btn_is = new Button();
            btn_calc = new Button();
            lb = new ListBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(22, 177);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(145, 55);
            btn_submit.TabIndex = 0;
            btn_submit.Text = "Enviar";
            btn_submit.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            date.Location = new Point(22, 108);
            date.Name = "date";
            date.Size = new Size(243, 23);
            date.TabIndex = 1;
            // 
            // cb_sexo
            // 
            cb_sexo.FormattingEnabled = true;
            cb_sexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Viado", "Viadão" });
            cb_sexo.Location = new Point(271, 108);
            cb_sexo.Name = "cb_sexo";
            cb_sexo.Size = new Size(114, 23);
            cb_sexo.TabIndex = 2;
            // 
            // mtxtb_cpf
            // 
            mtxtb_cpf.Location = new Point(129, 48);
            mtxtb_cpf.Mask = "###.###.###-##";
            mtxtb_cpf.Name = "mtxtb_cpf";
            mtxtb_cpf.Size = new Size(109, 23);
            mtxtb_cpf.TabIndex = 3;
            // 
            // txtb_rm
            // 
            txtb_rm.Location = new Point(22, 48);
            txtb_rm.Name = "txtb_rm";
            txtb_rm.Size = new Size(101, 23);
            txtb_rm.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 30);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 5;
            label1.Text = "RM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 30);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 6;
            label2.Text = "CPF";
            // 
            // txtb_name
            // 
            txtb_name.Location = new Point(244, 48);
            txtb_name.Name = "txtb_name";
            txtb_name.Size = new Size(298, 23);
            txtb_name.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 30);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 90);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // cb_nat
            // 
            cb_nat.FormattingEnabled = true;
            cb_nat.Items.AddRange(new object[] { "jaboticaal", "taquaritinga", "monte alto", "araraquara", "ribeirão preto", "cândido rodrigues", "santa ernestina", "fernando prestes" });
            cb_nat.Location = new Point(391, 108);
            cb_nat.Name = "cb_nat";
            cb_nat.Size = new Size(151, 23);
            cb_nat.TabIndex = 10;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(211, 177);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(145, 55);
            btn_limpar.TabIndex = 11;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(397, 177);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(145, 55);
            btn_fechar.TabIndex = 12;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            // 
            // btn_gt
            // 
            btn_gt.Location = new Point(397, 255);
            btn_gt.Name = "btn_gt";
            btn_gt.Size = new Size(145, 55);
            btn_gt.TabIndex = 15;
            btn_gt.Text = "Gerenciador de tarefas";
            btn_gt.UseVisualStyleBackColor = true;
            // 
            // btn_pc
            // 
            btn_pc.Location = new Point(211, 255);
            btn_pc.Name = "btn_pc";
            btn_pc.Size = new Size(145, 55);
            btn_pc.TabIndex = 14;
            btn_pc.Text = "painel de controle";
            btn_pc.UseVisualStyleBackColor = true;
            btn_pc.Click += btn_pc_Click;
            // 
            // btn_chrome
            // 
            btn_chrome.Location = new Point(22, 255);
            btn_chrome.Name = "btn_chrome";
            btn_chrome.Size = new Size(145, 55);
            btn_chrome.TabIndex = 13;
            btn_chrome.Text = "Chrome";
            btn_chrome.UseVisualStyleBackColor = true;
            // 
            // btn_notepad
            // 
            btn_notepad.Location = new Point(397, 338);
            btn_notepad.Name = "btn_notepad";
            btn_notepad.Size = new Size(145, 55);
            btn_notepad.TabIndex = 18;
            btn_notepad.Text = "Bloco de notas";
            btn_notepad.UseVisualStyleBackColor = true;
            btn_notepad.Click += btn_notepad_Click;
            // 
            // btn_is
            // 
            btn_is.Location = new Point(211, 338);
            btn_is.Name = "btn_is";
            btn_is.Size = new Size(145, 55);
            btn_is.TabIndex = 17;
            btn_is.Text = "informações do sistema";
            btn_is.UseVisualStyleBackColor = true;
            // 
            // btn_calc
            // 
            btn_calc.Location = new Point(22, 338);
            btn_calc.Name = "btn_calc";
            btn_calc.Size = new Size(145, 55);
            btn_calc.TabIndex = 16;
            btn_calc.Text = "Calculadora";
            btn_calc.UseVisualStyleBackColor = true;
            // 
            // lb
            // 
            lb.FormattingEnabled = true;
            lb.ItemHeight = 15;
            lb.Location = new Point(562, 179);
            lb.Name = "lb";
            lb.Size = new Size(210, 214);
            lb.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 90);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 20;
            label5.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(391, 90);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 21;
            label6.Text = "Naturalidade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lb);
            Controls.Add(btn_notepad);
            Controls.Add(btn_is);
            Controls.Add(btn_calc);
            Controls.Add(btn_gt);
            Controls.Add(btn_pc);
            Controls.Add(btn_chrome);
            Controls.Add(btn_fechar);
            Controls.Add(btn_limpar);
            Controls.Add(cb_nat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtb_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtb_rm);
            Controls.Add(mtxtb_cpf);
            Controls.Add(cb_sexo);
            Controls.Add(date);
            Controls.Add(btn_submit);
            Name = "Form1";
            Text = ",";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_submit;
        private DateTimePicker date;
        private ComboBox cb_sexo;
        private MaskedTextBox mtxtb_cpf;
        private TextBox txtb_rm;
        private Label label1;
        private Label label2;
        private TextBox txtb_name;
        private Label label3;
        private Label label4;
        private ComboBox cb_nat;
        private Button btn_limpar;
        private Button btn_fechar;
        private Button btn_gt;
        private Button btn_pc;
        private Button btn_chrome;
        private Button btn_notepad;
        private Button btn_is;
        private Button btn_calc;
        private ListBox lb;
        private Label label5;
        private Label label6;
    }
}
