
namespace medicord_v1.Forms
{
    public partial class PdfViewerForm : Form
    {
        private readonly byte[] data;
        private readonly string fileName, tempPath;

        public PdfViewerForm(string title, byte[] data, string fileName)
        {
            InitializeComponent();
            this.data = data; this.fileName = fileName;
            Text = title; BackColor = Theme.Page; StartPosition = FormStartPosition.CenterParent;
            Theme.Outline(btnSave);

            tempPath = Path.Combine(Path.GetTempPath(), $"medicord_{Guid.NewGuid():N}.pdf");
            File.WriteAllBytes(tempPath, data);
            Shown += async (_, _) => await ShowPdfAsync();
            FormClosed += (_, _) => { try { File.Delete(tempPath); } catch { } };  
        }

        private async Task ShowPdfAsync()
        {
            try
            {
                var env = await CoreWebView2Environment.CreateAsync(null, Path.Combine(Path.GetTempPath(), "MedicordWebView2"));
                await webView.EnsureCoreWebView2Async(env);
                webView.CoreWebView2.Navigate(new Uri(tempPath).AbsoluteUri);
            }
            catch (Exception ex)
            {
                Msg.Show("The PDF viewer could not start (is the WebView2 runtime installed?).\n" +
                                "You can still use \"Save a copy\".\n\n" + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var dlg = new SaveFileDialog { Filter = "PDF files (*.pdf)|*.pdf", FileName = fileName };
            if (dlg.ShowDialog(this) == DialogResult.OK) File.WriteAllBytes(dlg.FileName, data);
        }
    }
}
