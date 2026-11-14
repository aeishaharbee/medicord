using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Helpers
{
    public static class PdfHelper
    {
        public const int MaxBytes = 10 * 1024 * 1024;

        public static bool IsPdf(byte[] b) =>
            b.Length > 5 && b[0] == 0x25 && b[1] == 0x50 && b[2] == 0x44 && b[3] == 0x46 && b[4] == 0x2D;   // "%PDF-"

        public static (byte[] Data, string Name)? Pick(IWin32Window owner)
        {
            using var dlg = new OpenFileDialog { Filter = "PDF files (*.pdf)|*.pdf", Title = "Choose a PDF" };
            if (dlg.ShowDialog(owner) != DialogResult.OK) return null;

            var info = new FileInfo(dlg.FileName);
            if (info.Length > MaxBytes) { Msg.Show("Please choose a PDF under 10 MB."); return null; }

            byte[] data;
            try { data = File.ReadAllBytes(dlg.FileName); }
            catch (IOException ex) { Msg.Show("Could not read that file:\n" + ex.Message); return null; }

            if (!IsPdf(data)) { Msg.Show("That file is not a valid PDF."); return null; }
            return (data, info.Name);
        }

        public static void Show(IWin32Window owner, string title, byte[] data, string fileName)
        {
            using var f = new PdfViewerForm(title, data, fileName);
            f.ShowDialog(owner);
        }
    }
}
