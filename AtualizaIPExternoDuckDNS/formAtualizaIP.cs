using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace AtualizaIPExternoDuckDNS
{
    public partial class AtualizaIP : Form
    {
        int contador = 0;
        string IpAtual = "0.0.0.0";

        public AtualizaIP()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerVerificador.Interval = 300000; //força para 5 minutos logo após iniciar a primeira vez
            contador += 1;

            string IpOLD = IpAtual;


            //Efetua o Request para verificar IP ATUAL
            var requisicaoMeuIP = WebRequest.CreateHttp("http://meuip.com/api/meuip.php");
            requisicaoMeuIP.Method = "GET";
            requisicaoMeuIP.UserAgent = "Atualiza IP Externo DuckDNS";

            try
            {
                using (var resposta = requisicaoMeuIP.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);

                    IpAtual = reader.ReadToEnd();

                    streamDados.Close();
                    resposta.Close();
                }


                //Efetua o Request para ATUALIZAR IP NO DUCK, apenas se o IP atual diferente da ultima verificação
                string RetornoDuckDNS = "";
                bool MudouIP = IpAtual != IpOLD;

                if (MudouIP)
                {
                    string token = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"; //token atual cadastrado
                    string domain = "domain"; //dominio configurado

                    var requisicaoDUCK = WebRequest.CreateHttp("https://" + $"www.duckdns.org/update?domains={domain}&token={token}&ip={IpAtual}&verbose=true");
                    requisicaoDUCK.Method = "GET";
                    requisicaoDUCK.UserAgent = "Atualiza IP Externo DuckDNS";

                    using (var resposta = requisicaoDUCK.GetResponse())
                    {
                        var streamDados = resposta.GetResponseStream();
                        StreamReader reader = new StreamReader(streamDados);

                        RetornoDuckDNS = reader.ReadToEnd();
                        if (RetornoDuckDNS == "KO") //K.O. = bad response
                            RetornoDuckDNS += " (erro!)";

                        streamDados.Close();
                        resposta.Close();
                    }
                }


                //Atualiza informações na tela
                lbIPatual.Text = $"IP Atual [{IpAtual}]";
                lbTotVerificacoes.Text = $"Total verificações desde iniciado: {contador}";
                lbDataVerificacao.Text = $"Data ultima verificação {DateTime.Now}";

                if (MudouIP)
                {
                    txtRetornoDuckDNS.Text = RetornoDuckDNS + "\n\n veja detalhe em: https://www.duckdns.org/spec.jsp";
                    txtRetornoDuckDNS.Text = txtRetornoDuckDNS.Text.Replace("\n", System.Environment.NewLine);
                    lbDataRetornoDuck.Text = $"Data ultima atualização no DuckDNS   {DateTime.Now}";
                }
            }
            catch
            {
                lbOffLine.Visible = true;
                System.Threading.Thread.Sleep(5000); ; //aguardar 5 segundos
                timer1_Tick(sender, e);
                lbOffLine.Visible = false;
            }

        }

        private void AtualizaIP_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
        }

        private void AtualizaIP_Shown(object sender, EventArgs e)
        {
            lbVersao.Text = "versão " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btForcarAtualizcao_Click(object sender, EventArgs e)
        {
            IpAtual = "0.0.0.0";
            timer1_Tick(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
