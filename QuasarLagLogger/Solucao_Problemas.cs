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

	public partial class Form1 : Form
	{
		public Form1()
		{

			InitializeComponent();

		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			//Inicialização dos arquivos de log
			File.WriteAllText(@".\logs\" + DateTime.Now.ToString("ddMyyyyHHmmss") + @"_solprob.txt", "");
			string last_log_sol = @".\logs\" + DateTime.Now.ToString("ddMyyyyHHmmss") + "_solprob.txt";
			
			TextWriter LogNet = new StreamWriter(last_log_sol);
			LogNet.WriteLine("# Quasar Netview [Alpha - Build 1] - Log de Análise (Solução de Problemas) - " + DateTime.Now);
			LogNet.WriteLine("#");
			progressBar1.Value = 10;
			//Inicialização da análise para solução de problemas
				int error_level = 0;	
		//Teste Cloudflare
		if (error_level == 0) {
		try {
				var ping1 = new System.Net.NetworkInformation.Ping();
				ping1.Send("232.231.221.111");
				LogNet.WriteLine("# Conexão com 1.1.1.1 realizada com sucesso");
				progressBar1.Value = 20;
			} catch {
				error_level = 1;
				LogNet.WriteLine("# Falha na conexão com a internet detectada [Tentativa com: 1.1.1.1]");
				LogNet.WriteLine("# Possíveis soluções:");
				LogNet.WriteLine("# 1: Verifique o cabeamento da conexão.");
				LogNet.WriteLine("# 2: Desligue o seu roteador ou modem por ~10 segundos e o ligue novamente.");
				LogNet.WriteLine("# 3: Entre em contato com a sua provedora.");
				progressBar1.Value = 100;
				System.Threading.Thread.Sleep(1000);
				progressBar1.Value = 0;
				LogNet.Close();
			}	}

			try {
			string netServer = "1.1.1.1";
              int PacoteNivel = 0;
              System.Net.NetworkInformation.PingReply oPing = new System.Net.NetworkInformation.Ping().Send(netServer);
              LogNet.WriteLine("# Enviando (5) pacotes para: " + netServer);
              if (oPing.Status == IPStatus.Success) {
              	PacoteNivel = 1;
              LogNet.WriteLine("# Pacote de retorno recebido com sucesso");
              progressBar1.Value = 30;
              progressBar2.Value = progressBar2.Value + 1;              
              } else {
              LogNet.WriteLine("# Falha no recebimento do pacote");		
              }
              System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
              System.Net.NetworkInformation.PingReply oPing2 = new System.Net.NetworkInformation.Ping().Send(netServer);
              if (oPing2.Status == IPStatus.Success) {
              	PacoteNivel = 2;
              LogNet.WriteLine("# Pacote de retorno recebido com sucesso");
              progressBar1.Value = 40;
              progressBar2.Value = progressBar2.Value + 1;              
              } else {
              LogNet.WriteLine("# Falha no recebimento do pacote");		
              }
              progressBar1.Value = 50;
              System.Net.NetworkInformation.PingReply oPing3 = new System.Net.NetworkInformation.Ping().Send(netServer);
              if (oPing3.Status == IPStatus.Success) {
              LogNet.WriteLine("# Pacote de retorno recebido com sucesso");
              progressBar1.Value = 60;
              progressBar2.Value = progressBar2.Value + 1;              
              	if (PacoteNivel == 2) {
              		PacoteNivel = 3;
              	} 
              	if (PacoteNivel == 1) {
              		PacoteNivel = 2;
              	}
              } else {
              LogNet.WriteLine("# Falha no recebimento do pacote");	
              }
              progressBar1.Value = 70;
              System.Net.NetworkInformation.PingReply oPing4 = new System.Net.NetworkInformation.Ping().Send(netServer);
              if (oPing4.Status == IPStatus.Success) {
              	LogNet.WriteLine("# Pacote de retorno recebido com sucesso");
                progressBar2.Value = progressBar2.Value + 1;              	
              	if (PacoteNivel == 3) {
              		PacoteNivel = 4;
              	}
              	if (PacoteNivel == 2) {
              		PacoteNivel = 3;
              	}
               System.Net.NetworkInformation.PingReply oPing5 = new System.Net.NetworkInformation.Ping().Send(netServer);
              if (oPing5.Status == IPStatus.Success) {
               	LogNet.WriteLine("# Pacote de retorno recebido com sucesso");
               	progressBar2.Value = progressBar2.Value + 1;
              	if (PacoteNivel == 4) {
              		PacoteNivel = 5;
              	}
              	if (PacoteNivel == 2) {
              		PacoteNivel = 3;
              	}
                if (PacoteNivel == 3) {
              		PacoteNivel = 4;
              	}
                if (PacoteNivel == 1) {
              		PacoteNivel = 2;
              	}	                	
              } else {
              LogNet.WriteLine("# Falha no recebimento do pacote");	
              }
          
			
    } else {
              LogNet.WriteLine("# Falha no recebimento do pacote");	
              }
              progressBar1.Value = 80;
               if (PacoteNivel == 5) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 0%");
              	Perdas_Pacote.Value = Perdas_Pacote.Value + 0;
              }
              if (PacoteNivel == 4) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 20%");
              	Perdas_Pacote.Value = Perdas_Pacote.Value + 20;
              }
              if (PacoteNivel == 3) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 40%");
              	Perdas_Pacote.Value = Perdas_Pacote.Value + 40;
              }
              if (PacoteNivel == 2) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 60%");
              	Perdas_Pacote.Value = Perdas_Pacote.Value + 60;
              }
              if (PacoteNivel == 1) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 80%");
              	Perdas_Pacote.Value = Perdas_Pacote.Value + 80;
              }
              if (PacoteNivel == 0) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 100%");
              	Perdas_Pacote.Value = Perdas_Pacote.Value + 100;
              }
			} catch {
				
			}
		//Teste Google
		if (error_level == 0) {
		try {
				var ping = new System.Net.NetworkInformation.Ping();
				ping.Send("www.google.com.br");
				LogNet.WriteLine("# Conexão com Google realizada com sucesso");
			} catch {
	            error_level = 1;
				LogNet.WriteLine("# Falha na conexão com a internet detectada [Tentativa com: Google]");
				LogNet.WriteLine("# Possíveis soluções:");
				LogNet.WriteLine("#");
				LogNet.WriteLine("#");
				LogNet.WriteLine("# 1: Verifique o cabeamento da conexão.");
				LogNet.WriteLine("# 2: Desligue o seu roteador/modem por ~10 segundos e o ligue novamente.");
				LogNet.WriteLine("# 3: Entre em contato com a sua provedora.");
				LogNet.Close();
			}
		}
		if (error_level == 0) {
		try {
			string netServer = "www.google.com.br";
              int PacoteNivel = 0;
              System.Net.NetworkInformation.PingReply oPing = new System.Net.NetworkInformation.Ping().Send(netServer);
              LogNet.WriteLine("# Enviando (5) pacotes para: " + netServer);
              if (oPing.Status == IPStatus.Success) {
              	PacoteNivel = 1;
              LogNet.WriteLine("# Pacote de retorno recebido com sucesso");
              progressBar1.Value = 81;
              progressBar2.Value = progressBar2.Value + 1;              
              } else {
              LogNet.WriteLine("# Falha no recebimento do pacote");		
              }
              System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
              System.Net.NetworkInformation.PingReply oPing2 = new System.Net.NetworkInformation.Ping().Send(netServer);
              if (oPing2.Status == IPStatus.Success) {
              	PacoteNivel = 2;
              LogNet.WriteLine("# Pacote de retorno recebido com sucesso");	
              progressBar2.Value = progressBar2.Value + 1;              
              } else {
              LogNet.WriteLine("# Falha no recebimento do pacote");		
              }
               progressBar1.Value = 82;
              System.Net.NetworkInformation.PingReply oPing3 = new System.Net.NetworkInformation.Ping().Send(netServer);
              if (oPing3.Status == IPStatus.Success) {
              LogNet.WriteLine("# Pacote de retorno recebido com sucesso");
              progressBar2.Value = progressBar2.Value + 1;              
              	if (PacoteNivel == 2) {
              		PacoteNivel = 3;
              	} 
              	if (PacoteNivel == 1) {
              		PacoteNivel = 2;
              	}
              } else {
              LogNet.WriteLine("# Falha no recebimento do pacote");	
              }
              progressBar1.Value = 83;
              System.Net.NetworkInformation.PingReply oPing4 = new System.Net.NetworkInformation.Ping().Send(netServer);
              if (oPing4.Status == IPStatus.Success) {
              	LogNet.WriteLine("# Pacote de retorno recebido com sucesso");
                progressBar2.Value = progressBar2.Value + 1;              	
              	if (PacoteNivel == 3) {
              		PacoteNivel = 4;
              	}
              	if (PacoteNivel == 2) {
              		PacoteNivel = 3;
              	}
               System.Net.NetworkInformation.PingReply oPing5 = new System.Net.NetworkInformation.Ping().Send(netServer);
              progressBar1.Value = 85;
               if (oPing5.Status == IPStatus.Success) {
               	LogNet.WriteLine("# Pacote de retorno recebido com sucesso");
               	progressBar2.Value = progressBar2.Value + 1;
              	if (PacoteNivel == 4) {
              		PacoteNivel = 5;
              	}
              	if (PacoteNivel == 2) {
              		PacoteNivel = 3;
              	}
                if (PacoteNivel == 3) {
              		PacoteNivel = 4;
              	}
                if (PacoteNivel == 1) {
              		PacoteNivel = 2;
              	}	                	
              } else {
              LogNet.WriteLine("# Falha no recebimento do pacote");	
              }
          
			
    } else {
              LogNet.WriteLine("# Falha no recebimento do pacote");	
              }
               if (PacoteNivel == 5) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 0%");
              	Perdas_Pacote.Value = 0;
              }
              if (PacoteNivel == 4) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 20%");
              	Perdas_Pacote.Value = 20;
              }
              if (PacoteNivel == 3) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 40%");
              	Perdas_Pacote.Value = 40;
              }
              if (PacoteNivel == 2) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 60%");
              	Perdas_Pacote.Value = 60;
              }
              if (PacoteNivel == 1) {
              	LogNet.WriteLine("# Perda de pacote com servidor " + netServer + ": 80%");
              	Perdas_Pacote.Value = 80;
              }
              if (PacoteNivel == 0) {
              	LogNet.WriteLine("# Perda de pacote com servidor" + netServer + ": 100%");
              	Perdas_Pacote.Value = 100;
              }
			} catch {
				
			} }
		 progressBar1.Value = 90;
		if (error_level == 0) {
		LogNet.WriteLine("# Média de perda de pacote: " + Perdas_Pacote.Value * 0.5 + "%");
		if (Perdas_Pacote.Value > 0) {
			 progressBar1.Value = 91;
		LogNet.WriteLine("#");
		LogNet.WriteLine("# Foram detectadas perdas de pacote, isso pode significar instabilidade de rede.");
		        LogNet.WriteLine("#");
				LogNet.WriteLine("# Possíveis soluções:");
				LogNet.WriteLine("# 1: Verifique o cabeamento da conexão.");
				LogNet.WriteLine("# 2: Desligue o seu roteador ou modem por ~10 segundos e o ligue novamente.");
				LogNet.WriteLine("# 3: Pressione o botão 'Limpar Cache DNS' nas soluções automáticas e tente novamente.");
				LogNet.WriteLine("# 4: Pressione o botão 'Reiniciar Winsock TCP/IP' nas soluções automáticas e tente novamente");
				if (progressBar2.Value < 6) {
					progressBar1.Value = 92;
				LogNet.WriteLine("#");
				LogNet.WriteLine("# Um erro de conexão foi detectado em sua rota, aguarde e caso você não consiga resolver por métodos comuns ou ele não se resolva em pouco tempo entre em contato com a sua provedora.");
				}
		}
		}	
		        progressBar1.Value = 100;
		        System.Threading.Thread.Sleep(1000);
                LogNet.Close();
				richTextBox1.Text = File.ReadAllText(last_log_sol);
				
		}
		
		void GroupBox1Enter(object sender, EventArgs e)
		{
			
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			try {
Process cmd = new Process();
cmd.StartInfo.FileName = "cmd.exe";
cmd.StartInfo.RedirectStandardInput = true;
cmd.StartInfo.RedirectStandardOutput = true;
cmd.StartInfo.CreateNoWindow = true;
cmd.StartInfo.UseShellExecute = false;
cmd.Start();
cmd.StandardInput.WriteLine("ipconfig /flushdns");
cmd.StandardInput.Flush();
cmd.StandardInput.Close();
cmd.WaitForExit();
Console.WriteLine(cmd.StandardOutput.ReadToEnd());
if (button2.Text == "Limpar Cache DNS novamente") {

} else {
	button2.Text = button2.Text + " novamente";
}
			} catch {
				MessageBox.Show("Ocorreu um erro inesperado: É possível que algo tenha acontecido para impedir a execução de um recurso externo.");
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			try {
Process cmd = new Process();
cmd.StartInfo.FileName = "cmd.exe";
cmd.StartInfo.RedirectStandardInput = true;
cmd.StartInfo.RedirectStandardOutput = true;
cmd.StartInfo.CreateNoWindow = true;
cmd.StartInfo.UseShellExecute = false;
cmd.Start();
cmd.StandardInput.WriteLine("netsh winsock reset");
cmd.StandardInput.Flush();
cmd.StandardInput.Close();
cmd.WaitForExit();
Console.WriteLine(cmd.StandardOutput.ReadToEnd());
if (button3.Text == "Reiniciar Winsock TCP/IP novamente") {

} else {
	button3.Text = button3.Text + " novamente";
}
			} catch {
			MessageBox.Show("Ocorreu um erro inesperado: É possível que algo tenha acontecido para impedir a execução de um recurso externo.");

			}
		}
		}
}

