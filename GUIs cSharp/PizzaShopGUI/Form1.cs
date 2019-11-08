using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net;
using System.IO;

namespace SmallestFibonachiNumber
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            lbPreferences.Text = "Any special preferences/request,\r\n please enter here:";
            //this.BackgroundImage = Image.FromFile("C:\\");
            /*for(int i = 0; i<100; i++)
            {
                listBoxOrder.Items.Add("");
            }*/
        }
        String orderOnScreen;
        String orderBtwApps;

        bool pizzaTypeCh, pizzaSizeCh, pizzaExtraCh = false;
        
        int size = 1;
        int counterOrdersPerCustomers = 0;
        
        private void DrinksCounter (Label lb, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int counterDrink = Convert.ToInt32(lb.Text);
                counterDrink++;
                lb.Text = counterDrink.ToString();
            }
            if (e.Button == MouseButtons.Right)
            {
                int counterDrink = Convert.ToInt32(lb.Text);
                counterDrink--;
                if (counterDrink < 0)
                    counterDrink = 0;
                lb.Text = counterDrink.ToString();
            }
        }

        //POST request sending string to server
        private void POSTrequest(string uri)
        {
            WebRequest request = WebRequest.Create(uri);
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = "Now it works";
            /*string postData = textBox1.Text;
            if (textBox1.Text == "")
            {
                postData = "The user did not input any text.";
                textBox1.Text = null;
            }
            else
            {
                postData = textBox1.Text;
                textBox1.Text = null;
            }*/

            byte[] buffer = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "Mario's Interface";
            // Set the ContentLength property of the WebRequest. 
            request.ContentLength = buffer.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(buffer, 0, buffer.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.           
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();
        }

        //Get request returning string from server
        public string GETrequest(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            counterOrdersPerCustomers++;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void pbCola_MouseDown(object sender, MouseEventArgs e)
        {
            DrinksCounter(lbCola, e);
        }

        private void pbPepsi_MouseDown(object sender, MouseEventArgs e)
        {
            DrinksCounter(lbPepsi, e);
        }

        private void pbFanta_MouseDown(object sender, MouseEventArgs e)
        {
            DrinksCounter(lbFanta, e);
        }

        private void pbJuice_MouseDown(object sender, MouseEventArgs e)
        {
            DrinksCounter(lbJuice, e);
        }

        private void pbLipton_MouseDown(object sender, MouseEventArgs e)
        {
            DrinksCounter(lbLipton, e);
        }

        private void pbSchweppes_MouseDown(object sender, MouseEventArgs e)
        {
            DrinksCounter(lbSchweppes, e);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            POSTrequest("http://145.93.61.233:42069");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            pizzaTypeCh = true;
            if (listBoxOrder.Items.Count == 0)
                listBoxOrder.Items.Add("Pizza type: " + comboBoxPizza.Text);
            else
                listBoxOrder.Items[0] = "Pizza type: " + comboBoxPizza.Text;

            /*listBoxOrder.Items[0] = "Pizza type: " + comboBoxPizza.Text;
            //pizzaType = < pizzaName >; this to be passed to server*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(pizzaTypeCh)
            {
                if (listBoxOrder.Items.Count == 1)
                {
                    listBoxOrder.Items.Add("Pizza size: Small");
                    pizzaSizeCh = true;
                }
                else
                {
                    listBoxOrder.Items[1] = "Pizza size: Small";
                    pizzaSizeCh = true;
                }
            }
            else
            {
                MessageBox.Show("Please select pizza type first!");
            }
            /*listBoxOrder.Items[1] = "Pizza size: Small";
            //pizzaSize = <sizeString>; this to be passed to server*/
        }

        private void ChlbExtra_ItemCheck(object sender, ItemCheckEventArgs e)
        {

           if (e.NewValue == CheckState.Checked)
               listBoxOrder.Items.Add(chlbExtra.Items[chlbExtra.SelectedIndex]);
           if (e.NewValue == CheckState.Unchecked)
               listBoxOrder.Items.Remove(chlbExtra.Items[chlbExtra.SelectedIndex]);
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pizzaTypeCh)
            {
                if (listBoxOrder.Items.Count == 1)
                    listBoxOrder.Items.Add("Pizza size: Medium");
                else
                    listBoxOrder.Items[1] = "Pizza size: Medium";
            }
            else
            {
                MessageBox.Show("Please select pizza type first!");
            }
            /*listBoxOrder.Items[1] = "Pizza size: Medium";
            //pizzaSize = <sizeString>; this to be passed to server*/
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pizzaTypeCh)
            {
                if (listBoxOrder.Items.Count == 1)
                    listBoxOrder.Items.Add("Pizza size: Large");
                else
                    listBoxOrder.Items[1] = "Pizza size: Large";
            }
            else
            {
                MessageBox.Show("Please select pizza type first!");
            }
            /*listBoxOrder.Items[1] = "Pizza size: Large";
            //pizzaSize = <sizeString>; this to be passed to server*/
        }
    }
}
