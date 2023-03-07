using MaterialSkin;
using MaterialSkin.Controls;
using ReestrClient.Service;
using ReestrClient.ServiceUseCases;

namespace ReestrClient
{
    public partial class FormLogin : MaterialForm
    {
        UserUseCases login = new UserImpl();
        Dictionary<string, Color> colors = new Dictionary<string, Color>()
            {
                { "dark", Color.FromArgb(51, 54, 41) },
                { "dark-low", Color.FromArgb(75, 79, 62) },
                { "medium", Color.FromArgb(129, 135, 109) },
                { "light", Color.FromArgb(181, 187, 164)},
                { "very-light", Color.FromArgb(226, 230, 215) },
            };
        public FormLogin()
        {
            InitializeComponent();
            InitMaterialSkin();
        }
        private void InitMaterialSkin()
        {
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
               colors["dark-low"], colors["dark"], colors["light"], colors["medium"], TextShade.WHITE
            );
        }

        private async void materialButtonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var info = await login.LogIn(materialTextBoxLogin.Text, materialTextBoxPassword.Text);
                var t = new Thread(() => Application.Run(new FormReestr(info.Item1)));
                t.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show("����� ��� ������ ������� �������", "������ �����������");
            }
        }

        private void materialLabelSignUp_Click(object sender, EventArgs e)
        {
            FormNewUser signUp = new FormNewUser();
            signUp.Show();
        }
    }
}