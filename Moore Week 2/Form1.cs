namespace Moore_Week_2
{
    public partial class Form1 : Form
    {
        //Counters
        public int firstClassSeatCounter = 0;
        public int economySeatCounter = 0;

        //First class seat array
        public bool[] firstClassSeatArray = new bool[5];
        int i = 0;
        //Economy seat array
        public bool[] econSeatArray = new bool[5];
        int j = 0;

        public Form1()
        {
            InitializeComponent();
        }
        //First Class button clicked
        private void button1_Click(object sender, EventArgs e)
        {
            //Adds +1 to firstClass seats when button is clicked
            firstClassSeatCounter++;

            //Output for all seats full
            if (firstClassSeatArray[4] == true && econSeatArray[4] == true)
            {
                MessageBox.Show("There are no seats left on the plane.\n" +
                    "The next flight leaves in 3 hours.");
            }

            //Output for First Class seating full
            if (firstClassSeatArray[4] == true && econSeatArray[4] == false)
            {
                MessageBox.Show("There are no seats left in first class.\n" +
                    "Please try booking an economy seat.");
            }
            //Last seat cannot increase iteration
            if (firstClassSeatArray[3] == true && firstClassSeatArray[4] == false)
            {
                //Changes value of the seat from false to true
                firstClassSeatArray[4] = true;
                MessageBox.Show("There are " + (5 - firstClassSeatCounter) + " first class seats left.");
            }
            //Output for firstClassSeats being filled
            if (firstClassSeatArray[3] == false)
            {
                //Changes value of the seat from false to true
                firstClassSeatArray[i] = true;
                i++;
                MessageBox.Show("There are " + (5 - firstClassSeatCounter) + " first class seats left.\n");
            }
        }
        //Economy button clicked
        private void button2_Click(object sender, EventArgs e)
        {
            //Adds +1 to economySeats when button is clicked
            economySeatCounter++;

            //Output all seats full
            if (econSeatArray[4] == true && firstClassSeatArray[4] == true)
            {
                MessageBox.Show("There are no seats left on the plane.\n" +
                    "The next flight leaves in 3 hours.");
            }
            //Output for economySeats full
            if (econSeatArray[4] == true && firstClassSeatArray[4] == false)
            {
                MessageBox.Show("There are no seats left for economy.\n" +
                    "Please try booking a first class seat.");
            }
            //Last seat cannot increase iteration
            if (econSeatArray[3] == true && econSeatArray[4] == false)
            {
                //Changes value of the seat from false to true
                econSeatArray[j] = true;
                MessageBox.Show("There are " + (5 - economySeatCounter) + " economy seats left.");
            }
            //Output for economySeats
            if (econSeatArray[3] == false)
            {
                //Changes value of the seat from false to true
                econSeatArray[j] = true;
                j++;
                MessageBox.Show("There are " + (5 - economySeatCounter) + " economy seats left.");
            }
        }
    }
}