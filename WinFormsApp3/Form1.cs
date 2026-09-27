namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public static int seconds = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnValidar_Click(object sender, EventArgs e)
        {
            errorUsuario.Clear();
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorUsuario.SetError(txtNombre, "El campo usuario está vacío y debes rellenar un valor");
            }
            else
            {
                lbUsuario.Text = txtNombre.Text;
                lbUsuario.Font = new Font("Arial", 10, FontStyle.Bold);
                lbUsuario.Visible = true;
                listView1.Items.Add(txtNombre.Text);
                //Activamos el timer para que se muestre el reloj y se oculte a los 10 segundos
                timer1.Start();
            }
        }

        private void listView1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void listView1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            lbTimer.Text = DateTime.Now.ToString("HH:mm:ss");
            lbTimer.Visible = true;

            if (seconds == 5)
            {                
                timer1.Stop();
                lbTimer.Visible = false;
                seconds = 0;
            }
        }
    }
}
