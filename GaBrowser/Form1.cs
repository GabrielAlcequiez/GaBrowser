namespace GaBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarNavegador();
        }

        public async Task InicializarNavegador()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.Navigate("https://www.google.com");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            webView.Reload();
        }

        private void webView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            txtUrl.Text = webView.Source.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string entrada = txtUrl.Text.Trim(); 
            if (string.IsNullOrEmpty(entrada)) return;

            if (EsUrlValida(entrada))
            {
                // Protocolo por si no lo tiene, se asume https
                if (!entrada.StartsWith("http://") && !entrada.StartsWith("https://"))
                {
                    entrada = "https://" + entrada;
                }
                webView.CoreWebView2.Navigate(entrada);
            }
            else
            {
                string buscador = "https://www.google.com/search?q=";
                webView.CoreWebView2.Navigate(buscador + Uri.EscapeDataString(entrada));
            }
        }

        private bool EsUrlValida(string texto)
        {
            // Retorna falso porque si tiene espacios no es url
            if (texto.Contains(" ")) return false;

            // Si no tiene espacios pero si tiene puntos puede ser url
            if (texto.Contains(".")) return true;

            return false;
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
