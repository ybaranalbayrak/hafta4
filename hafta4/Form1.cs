namespace hafta4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*

            listBox1.Items.Add("Ford");
            listBox1.Items.Add("Chevrolet");
            listBox1.Items.Add("Toyota");

            string[] cars = { "Honda", "Nissan", "BMW" };
            listBox1.Items.AddRange(cars);

            List<string> carList = new List<string>() { "Mercedes", "Audi", "Volkswagen" };

            listBox1.DataSource =carList;
            */

            Dictionary<int, string> cities = new Dictionary<int, string>();

            cities.Add(01, "Adana");
            cities.Add(02, "Adýyaman");
            cities.Add(03, "Afyonkarahisar");
            cities.Add(04, "Aðrý");
            cities.Add(05, "Amasya");
            cities.Add(06, "Ankara");
            cities.Add(07, "Antalya");
            cities.Add(08, "Artvin");
            cities.Add(09, "Aydýn");
            cities.Add(10, "Balýkesir");


            foreach (int i in cities.Keys)
            {
                listBox1.Items.Add(i + " - " + cities[i]);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
             listBox2.Items.Clear();
             listBox2.Items.Add(listBox1.SelectedItem);


            string selectedItem = listBox1.SelectedItem.ToString();

            switch(selectedItem)
                    {
                    case "1 - Adana":
                        listBox2.Items.Add("Adana is a city in southern Turkey.");
                        break;
                    case "2 - Adýyaman":
                        listBox2.Items.Add("Adýyaman is a city in southeastern Turkey.");
                        break;
                    case "3 - Afyonkarahisar":
                        listBox2.Items.Add("Afyonkarahisar is a city in western Turkey.");
                        break;
                    case "4 - Aðrý":
                        listBox2.Items.Add("Aðrý is a city in eastern Turkey.");
                        break;





















                }
            }
        }
    }
}
