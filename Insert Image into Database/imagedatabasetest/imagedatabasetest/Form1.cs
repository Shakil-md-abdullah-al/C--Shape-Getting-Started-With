using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace imagedatabasetest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("data source=DESKTOP-VBIV842\\SQLEXPRESS;database=CheckImageDatabase;integrated security=true");
        string imglocation = "";
        SqlCommand cmd;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "png files(*.png)|*. png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(Dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = Dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
            
        }

    }
}