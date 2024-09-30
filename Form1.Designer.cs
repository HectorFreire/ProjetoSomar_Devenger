namespace ProjetoSomar_Devenger
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
            btnIncluir = new Button();
            btnApagar = new Button();
            btnSomar = new Button();
            listNumeros = new ListBox();
            label1 = new Label();
            inputNumeros = new TextBox();
            campoResultados = new Label();
            campoSoma = new Label();
            btnApagarAll = new Button();
            campoContagem = new Label();
            SuspendLayout();
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = SystemColors.ActiveCaption;
            btnIncluir.FlatStyle = FlatStyle.Flat;
            btnIncluir.Location = new Point(301, 111);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(137, 29);
            btnIncluir.TabIndex = 0;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.LightCoral;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Location = new Point(301, 156);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(137, 29);
            btnApagar.TabIndex = 1;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnSomar
            // 
            btnSomar.BackColor = Color.FromArgb(192, 255, 192);
            btnSomar.FlatStyle = FlatStyle.Flat;
            btnSomar.Location = new Point(301, 201);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(137, 29);
            btnSomar.TabIndex = 2;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = false;
            btnSomar.Click += btnSomar_Click;
            // 
            // listNumeros
            // 
            listNumeros.FormattingEnabled = true;
            listNumeros.Location = new Point(55, 111);
            listNumeros.Name = "listNumeros";
            listNumeros.Size = new Size(214, 384);
            listNumeros.TabIndex = 3;
            listNumeros.SelectedIndexChanged += listNumeros_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 31);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 4;
            label1.Text = "Números: ";
            // 
            // inputNumeros
            // 
            inputNumeros.Location = new Point(137, 28);
            inputNumeros.Name = "inputNumeros";
            inputNumeros.Size = new Size(132, 27);
            inputNumeros.TabIndex = 5;
            inputNumeros.TextChanged += inputNumeros_TextChanged;
            // 
            // campoResultados
            // 
            campoResultados.AutoSize = true;
            campoResultados.Location = new Point(305, 268);
            campoResultados.Name = "campoResultados";
            campoResultados.Size = new Size(84, 20);
            campoResultados.TabIndex = 6;
            campoResultados.Text = "Resultados:";
            // 
            // campoSoma
            // 
            campoSoma.AutoSize = true;
            campoSoma.Location = new Point(339, 317);
            campoSoma.Name = "campoSoma";
            campoSoma.Size = new Size(47, 20);
            campoSoma.TabIndex = 7;
            campoSoma.Text = "Soma";
            campoSoma.Click += campoSoma_Click;
            // 
            // btnApagarAll
            // 
            btnApagarAll.BackColor = Color.OrangeRed;
            btnApagarAll.ForeColor = SystemColors.ButtonHighlight;
            btnApagarAll.Location = new Point(301, 388);
            btnApagarAll.Name = "btnApagarAll";
            btnApagarAll.Size = new Size(137, 41);
            btnApagarAll.TabIndex = 8;
            btnApagarAll.Text = "Apagar tudo";
            btnApagarAll.UseVisualStyleBackColor = false;
            btnApagarAll.Click += btnApagarAll_Click;
            // 
            // campoContagem
            // 
            campoContagem.AutoSize = true;
            campoContagem.Location = new Point(55, 510);
            campoContagem.Name = "campoContagem";
            campoContagem.Size = new Size(127, 20);
            campoContagem.TabIndex = 9;
            campoContagem.Text = "Total de números:";
            campoContagem.Click += campoContagem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 617);
            Controls.Add(campoContagem);
            Controls.Add(btnApagarAll);
            Controls.Add(campoSoma);
            Controls.Add(campoResultados);
            Controls.Add(inputNumeros);
            Controls.Add(label1);
            Controls.Add(listNumeros);
            Controls.Add(btnSomar);
            Controls.Add(btnApagar);
            Controls.Add(btnIncluir);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeto Somar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIncluir;
        private Button btnApagar;
        private Button btnSomar;
        private ListBox listNumeros;
        private Label label1;
        private TextBox inputNumeros;
        private Label campoResultados;
        private Label campoSoma;
        private Button btnApagarAll;
        private Label campoContagem;
    }
}
