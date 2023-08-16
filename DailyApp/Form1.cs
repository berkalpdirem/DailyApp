using System.Text.Json;

namespace DailyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filepath = "Daily.json";
        private void btnRegister_Click(object sender, EventArgs e)
        {
            List<Dailies> listDaily = new List<Dailies>();
            Dailies Daily = new Dailies();

            Daily.Title = tbTitle.Text;
            Daily.Contents = rtbDailyWriting.Text;
            listDaily.Add(Daily);



            string sendingJson = JsonSerializer.Serialize(listDaily);

            if (!File.Exists(filepath))
            {
                File.WriteAllText(filepath, sendingJson);
            }
            else
            {
                string oldData = File.ReadAllText(filepath);
                List<Dailies> oldJson = JsonSerializer.Deserialize<List<Dailies>>(oldData);
                foreach (Dailies item in oldJson)
                {
                    listDaily.Add(item);
                }
                string newJson = JsonSerializer.Serialize(listDaily);
                File.WriteAllText(filepath, newJson);
            }
            listBoxWriter();
            rtbDailyWriting.Clear();
            tbTitle.Clear();
        }

        public void listBoxWriter()
        {
            listDaily.Items.Clear();
            string gelenData = File.ReadAllText(filepath);
            List<Dailies> gelenList = JsonSerializer.Deserialize<List<Dailies>>(gelenData);

            gelenList.Sort((daily1, daily2) => daily2.CreatingTime.CompareTo(daily1.CreatingTime));
            foreach (Dailies item in gelenList)
            {
                listDaily.Items.Add(item.Title + "---" + item.CreatingTime);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(filepath))
            {
                listBoxWriter();
            }

        }

        private void listDaily_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnBack.Enabled = true;
            btnRegister.Enabled = false;
            int index = listDaily.SelectedIndex;


            string data = File.ReadAllText(filepath);
            List<Dailies> dataList = JsonSerializer.Deserialize<List<Dailies>>(data);
            dataList.Sort((daily1, daily2) => daily2.CreatingTime.CompareTo(daily1.CreatingTime));


            rtbDailyWriting.Text = dataList[index].Contents.ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            rtbDailyWriting.Clear();
            btnRegister.Enabled = true;
        }
    }

    public class Dailies
    {
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime CreatingTime { get; set; }
        public Dailies()
        {
            CreatingTime = DateTime.Now;
        }
    }
}