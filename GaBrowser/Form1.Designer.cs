namespace GaBrowser
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
            panel1 = new Panel();
            txtUrl = new TextBox();
            btnBuscar = new Button();
            btnRecargar = new Button();
            btnForward = new Button();
            btnAtras = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtUrl);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnForward);
            panel1.Controls.Add(btnAtras);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1299, 40);
            panel1.TabIndex = 0;
            // 
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUrl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUrl.Location = new Point(177, 7);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(1055, 29);
            txtUrl.TabIndex = 4;
            txtUrl.KeyDown += txtUrl_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Image = Properties.Resources.iconBuscar;
            btnBuscar.Location = new Point(1238, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(49, 38);
            btnBuscar.TabIndex = 3;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.FlatAppearance.BorderSize = 0;
            btnRecargar.FlatStyle = FlatStyle.Flat;
            btnRecargar.Image = Properties.Resources.iconRecargar;
            btnRecargar.Location = new Point(125, 4);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(46, 33);
            btnRecargar.TabIndex = 2;
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnForward
            // 
            btnForward.FlatAppearance.BorderSize = 0;
            btnForward.FlatStyle = FlatStyle.Flat;
            btnForward.Image = Properties.Resources.iconAdelante;
            btnForward.Location = new Point(66, 3);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(53, 33);
            btnForward.TabIndex = 1;
            btnForward.UseVisualStyleBackColor = true;
            btnForward.Click += btnForward_Click;
            // 
            // btnAtras
            // 
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = Properties.Resources.iconAtras;
            btnAtras.Location = new Point(10, 3);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(50, 33);
            btnAtras.TabIndex = 0;
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 40);
            webView.Name = "webView";
            webView.Size = new Size(1299, 667);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            webView.SourceChanged += webView_SourceChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 707);
            Controls.Add(webView);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "GaBrowser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtUrl;
        private Button btnBuscar;
        private Button btnRecargar;
        private Button btnForward;
        private Button btnAtras;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}
