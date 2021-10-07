/*
 * Created by SharpDevelop.
 * User: User
 * Date: 24/02/2020
 * Time: 11:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuasarLagLogger
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.local_ip = new System.Windows.Forms.Label();
			this.consnet = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.statusnet = new System.Windows.Forms.Label();
			this.public_ip = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.outro_server = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.youtube_server = new System.Windows.Forms.RadioButton();
			this.rastrear_radio = new System.Windows.Forms.RadioButton();
			this.google_server = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(5, 63);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Verificar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(121, 63);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(100, 23);
			this.progressBar1.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.local_ip);
			this.groupBox1.Controls.Add(this.consnet);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.statusnet);
			this.groupBox1.Controls.Add(this.public_ip);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Location = new System.Drawing.Point(5, 224);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(216, 172);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Informações de Conexão";
			// 
			// local_ip
			// 
			this.local_ip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.local_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.local_ip.Location = new System.Drawing.Point(116, 132);
			this.local_ip.Name = "local_ip";
			this.local_ip.Size = new System.Drawing.Size(94, 23);
			this.local_ip.TabIndex = 31;
			this.local_ip.Text = "-";
			// 
			// consnet
			// 
			this.consnet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.consnet.Location = new System.Drawing.Point(116, 64);
			this.consnet.Name = "consnet";
			this.consnet.Size = new System.Drawing.Size(94, 23);
			this.consnet.TabIndex = 3;
			this.consnet.Text = "-";
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(10, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Consistência";
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(10, 132);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 30;
			this.label9.Text = "IP Local:";
			// 
			// statusnet
			// 
			this.statusnet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.statusnet.Location = new System.Drawing.Point(116, 27);
			this.statusnet.Name = "statusnet";
			this.statusnet.Size = new System.Drawing.Size(94, 23);
			this.statusnet.TabIndex = 1;
			this.statusnet.Text = "-";
			// 
			// public_ip
			// 
			this.public_ip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.public_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.public_ip.Location = new System.Drawing.Point(116, 96);
			this.public_ip.Name = "public_ip";
			this.public_ip.Size = new System.Drawing.Size(94, 23);
			this.public_ip.TabIndex = 29;
			this.public_ip.Text = "-";
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(10, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Status ";
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(10, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 28;
			this.label7.Text = "IP Público:";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton1,
									this.toolStripButton4,
									this.toolStripButton2,
									this.toolStripButton3});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(229, 57);
			this.toolStrip1.TabIndex = 22;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1ItemClicked);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(54, 54);
			this.toolStripButton1.Tag = "";
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.ToolTipText = "Solução de problemas";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(54, 54);
			this.toolStripButton4.Text = "Abrir pasta de logs";
			this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton4Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(54, 54);
			this.toolStripButton2.Text = "Visualizar Último Log";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(54, 54);
			this.toolStripButton3.Text = "Sobre";
			this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.linkLabel1);
			this.groupBox4.Controls.Add(this.outro_server);
			this.groupBox4.Controls.Add(this.radioButton1);
			this.groupBox4.Controls.Add(this.youtube_server);
			this.groupBox4.Controls.Add(this.rastrear_radio);
			this.groupBox4.Controls.Add(this.google_server);
			this.groupBox4.Location = new System.Drawing.Point(5, 158);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(216, 60);
			this.groupBox4.TabIndex = 25;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Rastreamento de Rota";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(116, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(14, 23);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "?";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// outro_server
			// 
			this.outro_server.Checked = true;
			this.outro_server.Location = new System.Drawing.Point(191, 36);
			this.outro_server.Name = "outro_server";
			this.outro_server.Size = new System.Drawing.Size(55, 24);
			this.outro_server.TabIndex = 2;
			this.outro_server.TabStop = true;
			this.outro_server.Text = "Outro:";
			this.outro_server.UseVisualStyleBackColor = true;
			this.outro_server.Visible = false;
			this.outro_server.CheckedChanged += new System.EventHandler(this.RadioButton3CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(73, 20);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(127, 24);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.Text = "Não Rastrear";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// youtube_server
			// 
			this.youtube_server.Location = new System.Drawing.Point(235, 20);
			this.youtube_server.Name = "youtube_server";
			this.youtube_server.Size = new System.Drawing.Size(66, 24);
			this.youtube_server.TabIndex = 1;
			this.youtube_server.Text = "Youtube";
			this.youtube_server.UseVisualStyleBackColor = true;
			this.youtube_server.Visible = false;
			// 
			// rastrear_radio
			// 
			this.rastrear_radio.Location = new System.Drawing.Point(6, 20);
			this.rastrear_radio.Name = "rastrear_radio";
			this.rastrear_radio.Size = new System.Drawing.Size(68, 24);
			this.rastrear_radio.TabIndex = 0;
			this.rastrear_radio.Text = "Rastrear";
			this.rastrear_radio.UseVisualStyleBackColor = true;
			this.rastrear_radio.CheckedChanged += new System.EventHandler(this.Rastrear_radioCheckedChanged);
			// 
			// google_server
			// 
			this.google_server.Location = new System.Drawing.Point(169, 20);
			this.google_server.Name = "google_server";
			this.google_server.Size = new System.Drawing.Size(61, 24);
			this.google_server.TabIndex = 0;
			this.google_server.Text = "Google";
			this.google_server.UseVisualStyleBackColor = true;
			this.google_server.Visible = false;
			this.google_server.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(204, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Location = new System.Drawing.Point(5, 92);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(216, 60);
			this.groupBox3.TabIndex = 24;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Servidor Base";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(229, 402);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "QuasarNetView";
			this.groupBox1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton rastrear_radio;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton google_server;
		private System.Windows.Forms.RadioButton youtube_server;
		private System.Windows.Forms.RadioButton outro_server;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label local_ip;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label public_ip;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label statusnet;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label consnet;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button1;
	}
}
