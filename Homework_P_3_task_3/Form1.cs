using System.IO;
using System.IO.IsolatedStorage;

namespace Homework_P_3_task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStreem = new IsolatedStorageFileStream("UserSettings.txt", FileMode.Create, userStorage);

            StreamWriter userWriter = new StreamWriter(userStreem);
            userWriter.WriteLine(textBox1.Text);
            userWriter.Close();
        }
    }
}