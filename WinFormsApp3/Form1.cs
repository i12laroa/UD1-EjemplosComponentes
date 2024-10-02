namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
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
                lbUsuario.Font = new Font(lbUsuario.Font, FontStyle.Bold);
                lbUsuario.Visible = true;
                listView1.Items.Add(txtNombre.Text);
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
    }
}
