using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.IO;
using System.Globalization;


namespace QuasarLagLogger
{
	public partial class MainForm : Form
	{
		public MainForm()
		{

			//Teste de conexão à internet para inicialização do aplicativo
			try {
				var ping = new System.Net.NetworkInformation.Ping();
				ping.Send("www.google.com");
			} catch {
				MessageBox.Show("Você precisa estar conectado à internet para usar esse aplicativo.", "Erro de Conexão");
				this.Close();
			}
			//Pastas importantes para o funcionamento do aplicativo
			if (Directory.Exists(@".\traces"))  
            {  
				
			} else {
				Directory.CreateDirectory(@".\traces\");
			}
			if (Directory.Exists(@".\logs"))  
            {  
				
			} else {
				Directory.CreateDirectory(@".\logs\");
			}
			
	
			InitializeComponent();
			
		
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label10Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "") {
				MessageBox.Show("O Endereço alvo não pode estar vazio!", "Erro");
			Application.Restart();
            Environment.Exit(0);
			}
			//Limpando possíveis arquivos de uma instância anterior
			string rootFolderPath = @".\";
            string filesToDelete = @"*Tr*.txt";
            string[] fileList = System.IO.Directory.GetFiles(rootFolderPath, filesToDelete);
            foreach(string file in fileList)
            {
            System.IO.File.Delete(file);
            }
			//Análise dos dados inseridos para evitar bugs e erros
			
			if (textBox1.Enabled == true) {
				if (textBox1.Text.Contains("http://")) {
					textBox1.Text = textBox1.Text.Replace("http://", "");
				}
				if (textBox1.Text.Contains("https://")) {
					textBox1.Text = textBox1.Text.Replace("https://", "");
				}
			}

			//Inicialização da função de análise e log a respeito da conexão com à internet
			File.WriteAllText(@".\logs\" + DateTime.Now.ToString("ddMyyyyHHmmss") + @".txt", "");
			string last_log = @".\logs\" + DateTime.Now.ToString("ddMyyyyHHmmss") + ".txt";
			
			TextWriter LogNet = new StreamWriter(last_log);
			LogNet.WriteLine("# Quasar Netview [Alpha - Build 1] - Log de Análise - " + DateTime.Now);
			LogNet.WriteLine("#");

			//Verificação do endereço IP Público da máquina a partir da API "ipfy"
			try {
			WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://api.ipify.org/");
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            public_ip.Text = content;
			}
			
			catch {
			public_ip.Text = "Erro desconhecido";	
			}
			
			LogNet.WriteLine("# Obtida informação do endereço de IP Público do usuário");

			progressBar1.Value = 10;
            //Verificação do endereço IP Local da máquina
             IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    local_ip.Text = ip.ToString();
                }
            }
            
            LogNet.WriteLine("# Obtida informação do endereço de IP Local do usuário");
            progressBar1.Value = 20;
            //Verificação de status e consistência de conexão
            try {
            	string netServer = "";
            	if (google_server.Checked == true) {
              	netServer = "www.google.com.br";
              }
            	if (youtube_server.Checked == true) {
              	netServer = "www.youtube.com.br";
              }
            	if (outro_server.Checked == true) {
              	netServer = textBox1.Text;
              }
            Ping pingSender = new Ping (); 
            PingReply reply = pingSender.Send (netServer);
            long latencia_net = reply.RoundtripTime;
            if (latencia_net > 300) {
            	LogNet.WriteLine("# Latência com servidor " + netServer + ": " + latencia_net + "ms");
            	statusnet.Text = "Ruim";
            }
            progressBar1.Value = 30;
            if (latencia_net < 300) {
            	if (latencia_net > 100) {
            	LogNet.WriteLine("# Latência com servidor " + netServer + ": " + latencia_net + "ms");	
            	statusnet.Text = "Razoável";	
            	}
            }
            if (latencia_net < 100) {
            	LogNet.WriteLine("# Latência com servidor " + netServer + ": " + latencia_net + "ms");
            	statusnet.Text = "Boa";
            }
            progressBar1.Value = 40;
				
            } catch {
            	
            	LogNet.WriteLine("# Latência com servidor indefinida");
                statusnet.Text = "Péssima";
            }
            if (statusnet.Text == "Boa") {

            	LogNet.WriteLine("# Status da conexão: Bom [Não apresenta sinais de interferência]");
            }
            if (statusnet.Text == "Razoável") {
   
            	LogNet.WriteLine("# Status da conexão: Razoável [Apresenta lentidão em alguns aspectos]");
            }
            if (statusnet.Text == "Péssima") {
            	LogNet.WriteLine("# Status da conexão: Péssima [Apresenta qualidade ruim]");
            }
            
            progressBar1.Value = 50;
            try {
            	string netServer = "";
            	if (google_server.Checked == true) {
              	netServer = "www.google.com.br";
              }
            	if (youtube_server.Checked == true) {
              	netServer = "www.youtube.com.br";
              }
            	if (outro_server.Checked == true) {
              	netServer = textBox1.Text;
              }
            Ping pingSender = new Ping (); 
            PingReply reply = pingSender.Send (netServer);
            long latencia_net = reply.RoundtripTime;
                consnet.Text = "Boa";
            } catch {
                consnet.Text = "Ruim";
            }
            progressBar1.Value = 60;

            try {
            	string netServer = "";
            	if (google_server.Checked == true) {
              	netServer = "www.google.com.br";
              }
            	if (youtube_server.Checked == true) {
              	netServer = "www.youtube.com.br";
              }
            	if (outro_server.Checked == true) {
              	netServer = textBox1.Text;
              }
              int PacoteNivel = 0;
              System.Net.NetworkInformation.PingReply oPing = new System.Net.NetworkInformation.Ping().Send(netServer);
              if (oPing.Status == IPStatus.Success) {
              	PacoteNivel = 1;
              }
              System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
              System.Net.NetworkInformation.PingReply oPing2 = new System.Net.NetworkInformation.Ping().Send(netServer);
              if (oPing2.Status == IPStatus.Success) {
              	PacoteNivel = 2;
              }
              System.Net.NetworkInformation.PingReply oPing3 = new System.Net.NetworkInformation.Ping().Send(netServer);
              if (oPing3.Status == IPStatus.Success) {
              	if (PacoteNivel == 2) {
              		PacoteNivel = 3;
              	}
              	if (PacoteNivel == 1) {
              		PacoteNivel = 2;
              	}
              }
              System.Net.NetworkInformation.PingReply oPing4 = new System.Net.NetworkInformation.Ping().Send(netServer);
              if (oPing4.Status == IPStatus.Success) {
              	if (PacoteNivel == 3) {
              		PacoteNivel = 4;
              	}
              	if (PacoteNivel == 2) {
              		PacoteNivel = 3;
              	}
              }
              if (PacoteNivel == 4) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 0%");
              }
              if (PacoteNivel == 3) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 25%");
              }
              if (PacoteNivel == 2) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 50%");
              }
              if (PacoteNivel == 1) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 75%");
              }
              if (PacoteNivel == 0) {
              	LogNet.WriteLine("# Perda de pacote com servidor" + netServer + ": 100%");
              }
              progressBar1.Value = 70;
            } catch {
            	
            }

            
            //Inicialização do Traceroute nos servidores padrão
            if (rastrear_radio.Checked == true) {
            if (google_server.Checked == true) {
              	 File.WriteAllText(@".\traces\Google.cmd", "");
			
			TextWriter GoogleTrace = new StreamWriter(@".\traces\Google.cmd");
			GoogleTrace.WriteLine("@echo off");
			GoogleTrace.WriteLine("tracert www.google.com.br > TrGoogle.txt");
			GoogleTrace.Close();
            try {
            Process process = new Process();
            process.StartInfo.FileName = @".\traces\Google.cmd";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            process.WaitForExit();
            progressBar1.Value = 80;
            } catch {
	
            }
              }
            	if (youtube_server.Checked == true) {
              	File.WriteAllText(@".\traces\Youtube.cmd", "");
			
			TextWriter GoogleTrace = new StreamWriter(@".\traces\Youtube.cmd");
			GoogleTrace.WriteLine("@echo off");
			GoogleTrace.WriteLine("tracert www.youtube.com.br > TrYoutube.txt");
			GoogleTrace.Close();
            try {
            Process process = new Process();
            process.StartInfo.FileName = @".\traces\Youtube.cmd";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            process.WaitForExit();
            } catch {
	
            }
              }
            	if (outro_server.Checked == true) {
              	File.WriteAllText(@".\traces\Outro.cmd", "");
			
			TextWriter GoogleTrace = new StreamWriter(@".\traces\Outro.cmd");
			GoogleTrace.WriteLine("@echo off");
			GoogleTrace.WriteLine("tracert " + textBox1.Text + " > TrOutro.txt");
			GoogleTrace.Close();
            try {
            Process process = new Process();
            process.StartInfo.FileName = @".\traces\Outro.cmd";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            process.WaitForExit();
            } catch {
	
            }
            	}
              
            	if (google_server.Checked == true) {
            	try {
string result = string.Empty;
    var lines = File.ReadAllLines("TrGoogle.txt");
    foreach (var line in lines)
    {
        if(line.Contains("*"))
        {
         LogNet.WriteLine("# Inconsistência localizada na rota de www.google.com.br");
        }
        if(line.Contains("resolver"))
        {
         LogNet.WriteLine("# Erro fatal de conexão com a rota de www.google.com.br");
        }
    }
} catch {
	
}
            }
            	if (youtube_server.Checked == true) {
            	try {
string result = string.Empty;
    var lines = File.ReadAllLines("TrYoutube.txt");
    foreach (var line in lines)
    {
        if(line.Contains("*"))
        {
         LogNet.WriteLine("# Inconsistência localizada na rota de www.youtube.com.br");
        }
         if(line.Contains("resolver"))
        {
         LogNet.WriteLine("# Erro fatal de conexão com a rota de www.youtube.com.br");
        }
    }
} catch {
	
}
            }
            	if (outro_server.Checked == true) {
            	try {
string result = string.Empty;
    var lines = File.ReadAllLines("TrOutro.txt");
    foreach (var line in lines)
    {
        if(line.Contains("*"))
        {
         LogNet.WriteLine("# Inconsistência localizada na rota de " + textBox1.Text);
        }
        if(line.Contains("resolver"))
        {
         LogNet.WriteLine("# Erro fatal de conexão com a rota de " + textBox1.Text);
        }
    }
} catch {
	
}
            		progressBar1.Value = 90;
            }
            }
           
            LogNet.WriteLine("# Informações de log da rota traçada (Via processador de comandos):");
            int tracerlevel = 0;
            if (File.Exists(@"TrOutro.txt")) {
            if (outro_server.Checked == true) {
            		string Outro_1 = File.ReadAllText(@"TrOutro.txt");
            		LogNet.WriteLine(Outro_1);
            		tracerlevel = 1;
              }
            }
            if (File.Exists(@"TrGoogle.txt")) {
            if (google_server.Checked == true) {
            		string Outro_1 = File.ReadAllText(@"TrGoogle.txt");
            		LogNet.WriteLine(Outro_1);
            		tracerlevel = 1;
              }
            }
            if (File.Exists(@"TrYoutube.txt")) {
            if (youtube_server.Checked == true) {
            		string Outro_1 = File.ReadAllText(@"TrYoutube.txt");
            		LogNet.WriteLine(Outro_1);
            		tracerlevel = 1;
              }
            }
            if (tracerlevel == 0) {
            	LogNet.WriteLine("# Sem Rota Traçada.");
            }
            
LogNet.Close();
File.WriteAllText(@".\logs\LastLog.txt", "");
TextWriter LastLog = new StreamWriter(@".\logs\LastLog.txt");
LastLog.WriteLine(File.ReadAllText(last_log));
LastLog.Close();
                    progressBar1.Value = 100;
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    progressBar1.Value = 0;
                    
		}
	
		
		
		void Label11Click(object sender, EventArgs e)
		{
			
		}
		
		void Label12Click(object sender, EventArgs e)
		{
			
		}
		
		void Label18Click(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Process.Start(@".\logs\");
		}
		
		void Button3Click(object sender, EventArgs e)
		{
 
	}
		
		void TreeView1AfterSelect(object sender, TreeViewEventArgs e)
		{
			
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
	    Form1 f2 = new Form1();
        f2.ShowDialog();
		}
		
		void Label2Click(object sender, EventArgs e)
		{
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void RadioButton3CheckedChanged(object sender, EventArgs e)
		{			
			
		}
		
		void Rastrear_radioCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Rastreamentos de rota realizam uma análise profunda de todos os fatores que resultam entre o envio e a chegada dos pacotes de internet e adicionam falhas detectadas ao log.\n\nEles não são recomendados caso você queira uma verificação rápida, pois pode demorar até ~30 minutos dependendo de sua conexão e do servidor alvo.", "Ajuda");		
		}
		
		void ToolStripButton2Click(object sender, EventArgs e)
		{
		}
		
		void ToolStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}

		
		void ToolStripButton3Click(object sender, EventArgs e)
		{
			MessageBox.Show("Quasar Netview [Alpha - Build 1]\nAplicativo desenvolvido por Kayky Vitor Cruz (Eternal Quasar)\nÍcones disponibilizados por Tango Icon Library (Contém Modificações) e licenciados para uso livre via: https://creativecommons.org/licenses/by-sa/3.0/ ");
		}
		
		void ToolStripButton4Click(object sender, EventArgs e)
		{
			Process.Start(@".\logs\");
		}
		
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("mailto:eternalquasar8486@gmail.com");
		}
		
		void ToolStripButton5Click(object sender, EventArgs e)
		{
			Process.Start("https://cosmusdev.blogspot.com/p/doe-para-o-desenvolvedor.html");
		}
		
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://cosmusdev.blogspot.com/p/quasarnetview.html");
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{			
			
		}
}
}

