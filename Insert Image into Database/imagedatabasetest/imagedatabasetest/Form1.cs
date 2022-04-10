using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data;// To include DataSet in our Program
using System.Drawing;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream =new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs=new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            connection.Open();
            string sqlQuery = "insert into imageTbl(ID,image) Values('"+id.Text+"',@images)";
            cmd =new SqlCommand(sqlQuery,connection);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int N = cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(N.ToString()+" Data Saved........");
        }



        private void btnView_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString ="data source=DESKTOP-VBIV842\\SQLEXPRESS;database=CheckImageDatabase;integrated security=true";


            SqlCommand cmd= new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select image from imageTbl where ID='" + vw.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS =new DataSet();
            DA.Fill(DS);
            if(DS.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Image on this index");

            }
            else
            {
                MemoryStream ms= new MemoryStream((byte[])DS.Tables[0].Rows[0][0]);
                pictureBox2.Image=new Bitmap(ms);
            }




        }
    }
}