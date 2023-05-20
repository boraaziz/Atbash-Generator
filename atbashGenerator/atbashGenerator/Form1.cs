using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace atbashGenerator
{
    public partial class atbashGenerator : Form
    {
        public atbashGenerator()
        {
            InitializeComponent();
        }

        private bool capslockAcikmi()
        {
            return Control.IsKeyLocked(Keys.CapsLock);
        }
        bool sec = true;

        private void atbashGenerator_Load(object sender, EventArgs e)
        {
            // Yuvarlaklaştırma
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int curveSize = 35; // kenar yumuşaklığı derecesi
            path.AddArc(new Rectangle(0, 0, curveSize, curveSize), 180, 90);
            path.AddLine(curveSize, 0, this.Width - curveSize, 0);
            path.AddArc(new Rectangle(this.Width - curveSize, 0, curveSize, curveSize), -90, 90);
            path.AddLine(this.Width, curveSize, this.Width, this.Height - curveSize);
            path.AddArc(new Rectangle(this.Width - curveSize, this.Height - curveSize, curveSize, curveSize), 0, 90);
            path.AddLine(this.Width - curveSize, this.Height, curveSize, this.Height);
            path.AddArc(new Rectangle(0, this.Height - curveSize, curveSize, curveSize), 90, 90);
            path.AddLine(0, this.Height - curveSize, 0, curveSize);
            this.Region = new System.Drawing.Region(path);

            // Kenar ekleme
            btnSifrele.FlatAppearance.BorderSize = 1;

            // Şifreleme başlat
            tmrSifrele.Start();
        }

        private void tmrSifrele_Tick(object sender, EventArgs e)
        {
            if (txtMetin.Text == "")
            {
                txtSonuc.Text = "";
            }
            if (!capslockAcikmi())
            {
                txtMetin.BackColor = Color.Red;
                txtMetin.Enabled = false;
                btnInfo.Visible = true;
            }
            else
            {
                txtMetin.BackColor = Color.FromArgb(36, 36, 36);
                txtMetin.Enabled = true;
                btnInfo.Visible = false;
            }
        }

        private void txtMetin_KeyDown(object sender, KeyEventArgs e)
        {

               switch (e.KeyCode)
            {
                case Keys.A:
                    txtSonuc.Text += Keys.Z.ToString();
                    break;
                case Keys.B:
                    txtSonuc.Text += Keys.Y.ToString();
                    break;
                case Keys.C:
                    txtSonuc.Text += Keys.X.ToString();
                    break;
                case Keys.D:
                    txtSonuc.Text += Keys.W.ToString();
                    break;
                case Keys.E:
                    txtSonuc.Text += Keys.V.ToString();
                    break;
                case Keys.F:
                    txtSonuc.Text += Keys.U.ToString();
                    break;
                case Keys.G:
                    txtSonuc.Text += Keys.T.ToString();
                    break;
                case Keys.H:
                    txtSonuc.Text += Keys.S.ToString();
                    break;
                case Keys.I:
                    txtSonuc.Text += Keys.R.ToString();
                    break;
                case Keys.J:
                    txtSonuc.Text += Keys.Q.ToString();
                    break;
                case Keys.K:
                    txtSonuc.Text += Keys.P.ToString();
                    break;
                case Keys.L:
                    txtSonuc.Text += Keys.O.ToString();
                    break;
                case Keys.M:
                    txtSonuc.Text += Keys.N.ToString();
                    break;
                case Keys.N:
                    txtSonuc.Text += Keys.M.ToString();
                    break;
                case Keys.O:
                    txtSonuc.Text += Keys.L.ToString();
                    break;
                case Keys.P:
                    txtSonuc.Text += Keys.K.ToString();
                    break;
                case Keys.Q:
                    txtSonuc.Text += Keys.J.ToString();
                    break;
                case Keys.R:
                    txtSonuc.Text += Keys.I.ToString();
                    break;
                case Keys.S:
                    txtSonuc.Text += Keys.H.ToString();
                    break;
                case Keys.T:
                    txtSonuc.Text += Keys.G.ToString();
                    break;
                case Keys.U:
                    txtSonuc.Text += Keys.F.ToString();
                    break;
                case Keys.V:
                    txtSonuc.Text += Keys.E.ToString();
                    break;
                case Keys.W:
                    txtSonuc.Text += Keys.D.ToString();
                    break;
                case Keys.X:
                    txtSonuc.Text += Keys.C.ToString();
                    break;
                case Keys.Y:
                    txtSonuc.Text += Keys.B.ToString();
                    break;
                case Keys.Z:
                    txtSonuc.Text += Keys.A.ToString();
                    break;
            }




            if (e.KeyCode == Keys.Space)
            {
                txtSonuc.Text = txtSonuc.Text + " ";
            }
            if (e.KeyCode == Keys.Back)
            {
                if (txtMetin.Text.Length > 0)
                {
                    txtSonuc.Text = txtSonuc.Text.Remove(txtSonuc.Text.Length - 1);
                }
            }
        }

        private void txtMetin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) && e.KeyChar > 127)
            {
                e.Handled = true;
            }
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program yalnızca Caps Lock tuşunun açık olduğu durumlarda kullanılabilir. Caps Lock tuşunu açmak veya kapatmak için lütfen klavyenizdeki ilgili tuşa basın. Devam etmek için 'Tamam' düğmesine tıklayın.", "Capslock Hatası");
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            txtMetin.Text = "";
            txtSonuc.Text = "";
            txtMetin.Focus();
        }

        private void btnKir_Click(object sender, EventArgs e)
        {
            btnSifrele.FlatAppearance.BorderSize = 0;
            txtMetin.Text = "";
            txtSonuc.Text = "";
            btnKir.FlatAppearance.BorderSize = 1;
            sec = false;
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            btnSifrele.FlatAppearance.BorderSize = 1;
            btnKir.FlatAppearance.BorderSize = 0;
            txtMetin.Text = "";
            txtSonuc.Text = "";
            sec = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
