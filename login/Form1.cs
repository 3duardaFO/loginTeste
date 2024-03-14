namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "admin" && MtbSenha.Text == "ra2357082")
            {
                MessageBox.Show("Acesso permitido");
            }
            else
            {
                MessageBox.Show("Credenciais incorretas! Seja bem-vindo");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                MtbSenha.PasswordChar = '\0';
            }
            else
            {
                MtbSenha.PasswordChar = '*';
            }
        }
    }
}
