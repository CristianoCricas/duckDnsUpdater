namespace AtualizaIPExternoDuckDNS
{
    partial class AtualizaIP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizaIP));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerVerificador = new System.Windows.Forms.Timer(this.components);
            this.lbIPatual = new System.Windows.Forms.Label();
            this.lbDataVerificacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRetornoDuckDNS = new System.Windows.Forms.TextBox();
            this.lbTotVerificacoes = new System.Windows.Forms.Label();
            this.lbDataRetornoDuck = new System.Windows.Forms.Label();
            this.lbVersao = new System.Windows.Forms.Label();
            this.btForcarAtualizacao = new System.Windows.Forms.Button();
            this.lbOffLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Atualizador IP Externo";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // TimerVerificador
            // 
            this.TimerVerificador.Enabled = true;
            this.TimerVerificador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbIPatual
            // 
            this.lbIPatual.AutoSize = true;
            this.lbIPatual.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIPatual.ForeColor = System.Drawing.Color.Blue;
            this.lbIPatual.Location = new System.Drawing.Point(148, 20);
            this.lbIPatual.Name = "lbIPatual";
            this.lbIPatual.Size = new System.Drawing.Size(186, 29);
            this.lbIPatual.TabIndex = 0;
            this.lbIPatual.Text = "IP Atual 0.0.0.0";
            // 
            // lbDataVerificacao
            // 
            this.lbDataVerificacao.AutoSize = true;
            this.lbDataVerificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataVerificacao.Location = new System.Drawing.Point(108, 49);
            this.lbDataVerificacao.Name = "lbDataVerificacao";
            this.lbDataVerificacao.Size = new System.Drawing.Size(297, 20);
            this.lbDataVerificacao.TabIndex = 1;
            this.lbDataVerificacao.Text = "Data ultima verificação 00/00/0000 00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(144, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Retorno atualização no DuckDNS:";
            // 
            // txtRetornoDuckDNS
            // 
            this.txtRetornoDuckDNS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRetornoDuckDNS.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtRetornoDuckDNS.Location = new System.Drawing.Point(12, 113);
            this.txtRetornoDuckDNS.Multiline = true;
            this.txtRetornoDuckDNS.Name = "txtRetornoDuckDNS";
            this.txtRetornoDuckDNS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRetornoDuckDNS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRetornoDuckDNS.Size = new System.Drawing.Size(474, 101);
            this.txtRetornoDuckDNS.TabIndex = 3;
            this.txtRetornoDuckDNS.Text = "nananna nannanan nananann an nanan nanannana\r\nnananan nannana\r\nnananna nannanan n" +
    "ananann an nanan nanannana\r\nnananan nannana\r\nnananna nannanan nananann an nanan " +
    "nanannana\r\nnananan nannana";
            // 
            // lbTotVerificacoes
            // 
            this.lbTotVerificacoes.AutoSize = true;
            this.lbTotVerificacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotVerificacoes.Location = new System.Drawing.Point(159, 69);
            this.lbTotVerificacoes.Name = "lbTotVerificacoes";
            this.lbTotVerificacoes.Size = new System.Drawing.Size(169, 13);
            this.lbTotVerificacoes.TabIndex = 4;
            this.lbTotVerificacoes.Text = "Total verificações desde iniciado: 0";
            // 
            // lbDataRetornoDuck
            // 
            this.lbDataRetornoDuck.AutoSize = true;
            this.lbDataRetornoDuck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataRetornoDuck.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbDataRetornoDuck.Location = new System.Drawing.Point(12, 217);
            this.lbDataRetornoDuck.Name = "lbDataRetornoDuck";
            this.lbDataRetornoDuck.Size = new System.Drawing.Size(278, 13);
            this.lbDataRetornoDuck.TabIndex = 5;
            this.lbDataRetornoDuck.Text = "Data ultima atualização no DuckDNS  00/00/0000 00:00";
            // 
            // lbVersao
            // 
            this.lbVersao.Location = new System.Drawing.Point(361, 227);
            this.lbVersao.Name = "lbVersao";
            this.lbVersao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbVersao.Size = new System.Drawing.Size(128, 23);
            this.lbVersao.TabIndex = 6;
            this.lbVersao.Text = "versão 0.0.0.0";
            // 
            // btForcarAtualizacao
            // 
            this.btForcarAtualizacao.AutoEllipsis = true;
            this.btForcarAtualizacao.FlatAppearance.BorderSize = 2;
            this.btForcarAtualizacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btForcarAtualizacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btForcarAtualizacao.Location = new System.Drawing.Point(15, 20);
            this.btForcarAtualizacao.Name = "btForcarAtualizacao";
            this.btForcarAtualizacao.Size = new System.Drawing.Size(75, 43);
            this.btForcarAtualizacao.TabIndex = 7;
            this.btForcarAtualizacao.Text = "Forçar Atualização";
            this.btForcarAtualizacao.UseVisualStyleBackColor = true;
            this.btForcarAtualizacao.Click += new System.EventHandler(this.btForcarAtualizcao_Click);
            // 
            // lbOffLine
            // 
            this.lbOffLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOffLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOffLine.ForeColor = System.Drawing.Color.Red;
            this.lbOffLine.Location = new System.Drawing.Point(6, 129);
            this.lbOffLine.Name = "lbOffLine";
            this.lbOffLine.Size = new System.Drawing.Size(486, 75);
            this.lbOffLine.TabIndex = 8;
            this.lbOffLine.Text = "Atualizador OFFLINE, aguardando reconexão com Internet...";
            this.lbOffLine.Visible = false;
            this.lbOffLine.Click += new System.EventHandler(this.label2_Click);
            // 
            // AtualizaIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 247);
            this.Controls.Add(this.lbOffLine);
            this.Controls.Add(this.btForcarAtualizacao);
            this.Controls.Add(this.lbVersao);
            this.Controls.Add(this.lbDataRetornoDuck);
            this.Controls.Add(this.lbTotVerificacoes);
            this.Controls.Add(this.txtRetornoDuckDNS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDataVerificacao);
            this.Controls.Add(this.lbIPatual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AtualizaIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizador IP Externo DuckDNS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AtualizaIP_FormClosing);
            this.Shown += new System.EventHandler(this.AtualizaIP_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer TimerVerificador;
        private System.Windows.Forms.Label lbIPatual;
        private System.Windows.Forms.Label lbDataVerificacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRetornoDuckDNS;
        private System.Windows.Forms.Label lbTotVerificacoes;
        private System.Windows.Forms.Label lbDataRetornoDuck;
        private System.Windows.Forms.Label lbVersao;
        private System.Windows.Forms.Button btForcarAtualizacao;
        private System.Windows.Forms.Label lbOffLine;
    }
}

