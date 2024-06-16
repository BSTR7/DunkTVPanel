using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DunkTVPanel
{
    public partial class Form1 : Form
    {
        private string logoPath1 = "";
        private string logoPath2 = "";
        private Color teamColor1 = Color.LightSkyBlue;
        private Color teamColor2 = Color.Purple;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadLogo1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                logoPath1 = openFileDialog.FileName;
                pictureBoxLogo1.Image = new Bitmap(logoPath1);
                pictureBoxLogo1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta el tamaño de la imagen al PictureBox
            }
        }

        private void btnLoadLogo2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                logoPath2 = openFileDialog.FileName;
                pictureBoxLogo2.Image = new Bitmap(logoPath2);
                pictureBoxLogo2.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta el tamaño de la imagen al PictureBox
            }
        }

        private void btnSelectColor1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                teamColor1 = colorDialog.Color;
                panelColor1.BackColor = teamColor1;
            }
        }

        private void btnSelectColor2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                teamColor2 = colorDialog.Color;
                panelColor2.BackColor = teamColor2;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newTeamName1 = txtTeamName1.Text;
            string newTeamName2 = txtTeamName2.Text;

            // Leer el contenido del archivo HTML desde los recursos incrustados
            string htmlContent = Properties.Resources.marcador;

            // Convertir los colores a formato hexadecimal
            string newColor1 = ColorTranslator.ToHtml(teamColor1);
            string newColor2 = ColorTranslator.ToHtml(teamColor2);

            // Reemplazar los colores utilizando expresiones regulares
            htmlContent = Regex.Replace(htmlContent, @"\.equipo-1::before\s*{\s*background:\s*linear-gradient\(to top, #[0-9A-Fa-f]{6}, transparent\);\s*}", $".equipo-1::before {{ background: linear-gradient(to top, {newColor1}, transparent); }}");
            htmlContent = Regex.Replace(htmlContent, @"\.equipo-2::before\s*{\s*background:\s*linear-gradient\(to top, #[0-9A-Fa-f]{6}, transparent\);\s*}", $".equipo-2::before {{ background: linear-gradient(to top, {newColor2}, transparent); }}");

            // Reemplazar los nombres de los equipos
            htmlContent = Regex.Replace(htmlContent, @"<span>PROV\. MAXI<\/span>", $"<span>{newTeamName1}</span>");
            htmlContent = Regex.Replace(htmlContent, @"<span>PATRIOTAS<\/span>", $"<span>{newTeamName2}</span>");

            // Crear una carpeta en el escritorio con el formato "Marcador (equipo1) vs (equipo2)"
            string folderName = $"Marcador {newTeamName1} vs {newTeamName2}";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newFolderPath = Path.Combine(desktopPath, folderName);
            Directory.CreateDirectory(newFolderPath);

            // Guardar el archivo HTML editado
            string newHtmlFilePath = Path.Combine(newFolderPath, "marcador.html");
            File.WriteAllText(newHtmlFilePath, htmlContent);

            // Copiar los logos a la nueva carpeta
            if (!string.IsNullOrEmpty(logoPath1))
            {
                string newLogoPath1 = Path.Combine(newFolderPath, "equipo1.png");
                File.Copy(logoPath1, newLogoPath1, true);
            }

            if (!string.IsNullOrEmpty(logoPath2))
            {
                string newLogoPath2 = Path.Combine(newFolderPath, "equipo2.png");
                File.Copy(logoPath2, newLogoPath2, true);
            }

            MessageBox.Show($"El marcador ha sido guardado en el escritorio en la carpeta '{folderName}'.");
        }
    }
}
