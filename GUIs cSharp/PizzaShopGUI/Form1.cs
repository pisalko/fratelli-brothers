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
            try
            {
                InitializeComponent();
                lbPizzasOrderedToday.Text = "Pizzas ordered today: " + ordersForTheDay.ToString();
                serialPort1.Open();
            }
            catch (Exception errors)
            {
                MessageBox.Show(errors.ToString());
            }
        }

        String textInPort;
        List<String> dataSentToServer = new List<String>();

        bool pizzaTypeCh, pizzaSizeCh, ifDataReceived = false;

        
        int ordersForTheDay, pizzaNumber = 0;

        private void DrinksCounter(Label lb, MouseEventArgs e)
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
        private void POSTrequest(string uri, String order)
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

            byte[] buffer = Encoding.UTF8.GetBytes(order);
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
            if (!pizzaTypeCh && !pizzaSizeCh)
            {
                MessageBox.Show("Why are you trying to send an empty order ?");
            }
            else
            {
                ordersForTheDay++;
            String order = "";
            for(int i = 0; i < dataSentToServer.Count; i++)
            {
                int lengthLineList = dataSentToServer[i].Length;

                if(i == 0)
                {
                    order += dataSentToServer[i].PadRight(16);
                }
                else if (i == 1)
                {
                    order += dataSentToServer[i].PadRight(12);
                }
                else if (i > 1 && i < dataSentToServer.Count)
                {
                    order += dataSentToServer[i];
                }
                
            }
            order = order.PadRight(137);
            order += ordersForTheDay.ToString();
            
                POSTrequest("http://192.168.88.250:42069", order);
                lbPizzasOrderedToday.Text = "Pizzas ordered today: " + ordersForTheDay.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            pizzaTypeCh = true;
            if (listBoxPizzas.Items.Count == 0)
            {
                listBoxPizzas.Items.Add("Pizza type: " + comboBoxPizza.Text);
                dataSentToServer.Add(comboBoxPizza.Text);// + "    "); //!!!
            }
            else
            {
                listBoxPizzas.Items[0] = "Pizza type: " + comboBoxPizza.Text;
                dataSentToServer[0] = comboBoxPizza.Text;// + "    ";
            }

            /*listBoxOrder.Items[0] = "Pizza type: " + comboBoxPizza.Text;
            //pizzaType = < pizzaName >; this to be passed to server*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pizzaTypeCh)
            {
                if (listBoxPizzas.Items.Count == 1)
                {
                    listBoxPizzas.Items.Add("Pizza size: Small");
                    dataSentToServer.Add("Small");//("/    Small    /    ");
                    pizzaSizeCh = true;
                }
                else
                {
                    listBoxPizzas.Items[1] = "Pizza size: Small";
                    dataSentToServer[1] = "Small";//"/    Small    /    ";
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
            
            if (pizzaSizeCh)
            {
                chlbExtra.BeginInvoke(new Action(() =>   //lambda function, like a foreach
                {

                    if (chlbExtra.CheckedItems.Count == 1 && !(listBoxPizzas.Items.Contains("Extras:")))
                    {
                        listBoxPizzas.Items.Add("Extras:");
                        dataSentToServer.Add("Extras: ");
                    }


                    if (e.NewValue == CheckState.Checked)
                    {
                        String addedToList = "";
                        listBoxPizzas.Items.Add(chlbExtra.Items[chlbExtra.SelectedIndex]);
                        if ((chlbExtra.Items[chlbExtra.SelectedIndex]).ToString().StartsWith("Extra"))
                        {
                            addedToList = (chlbExtra.Items[chlbExtra.SelectedIndex]).ToString().Substring(6, chlbExtra.Items[chlbExtra.SelectedIndex].ToString().Length - 10) + " ";
                                                 
                            dataSentToServer.Add(addedToList);

                        }
                        else
                            dataSentToServer.Add((chlbExtra.Items[chlbExtra.SelectedIndex]).ToString().Substring(0, chlbExtra.Items[chlbExtra.SelectedIndex].ToString().Length - 4) + " ");
                    }
                    if (e.NewValue == CheckState.Unchecked)
                    {
                        String addedToList = "";
                        listBoxPizzas.Items.Remove(chlbExtra.Items[chlbExtra.SelectedIndex]);
                        if((chlbExtra.Items[chlbExtra.SelectedIndex]).ToString().StartsWith("Extra"))
                        {
                            addedToList = (chlbExtra.Items[chlbExtra.SelectedIndex]).ToString().Substring(6, chlbExtra.Items[chlbExtra.SelectedIndex].ToString().Length - 10) + " ";
                            dataSentToServer.Remove(addedToList);

                        }
                        else
                        dataSentToServer.Remove((chlbExtra.Items[chlbExtra.SelectedIndex]).ToString().Substring(0, chlbExtra.Items[chlbExtra.SelectedIndex].ToString().Length - 4) + " ");

                        if (chlbExtra.CheckedItems.Count == 0 && listBoxPizzas.Items.Contains("Extras:"))
                        {
                            listBoxPizzas.Items.Remove("Extras:");
                            dataSentToServer.Remove("Extras: ");
                        }
                    }
                }));
            }
            else
            {
                MessageBox.Show("Please choose pizza type and size first!");
                e.NewValue = CheckState.Unchecked;
            }
        }

        private void textBoxPreferences_TextChanged(object sender, EventArgs e)
        {

        }

        private void constantChecks_Tick(object sender, EventArgs e)
        {
            //maybe check for changes with get request later
            if (ifDataReceived)
            {
                listViewReadyOrders.Items.Add("Pizza number " + pizzaNumber + " is ready for pick up!");
                ifDataReceived = false;
            }
        }

        private void listBoxDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           //MessageBox.Show("");
            textInPort = serialPort1.ReadLine();
            textInPort.Trim();
            textInPort = textInPort.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");

            pizzaNumber = Convert.ToInt32(textInPort);

            ifDataReceived = true;
        }

        private void btnServed_Click(object sender, EventArgs e)
        {
            try
            {
                listViewReadyOrders.SelectedItems[0].Remove();
            }
            catch (Exception errors)
            {
                MessageBox.Show("Please select an item !");
            }
        }

       // private void button1_Click_1(object sender, EventArgs e)
        //{
       //     listViewReadyOrders.Items.Add("1aaaaaaaaaaaaaaaaaaaaaa1");
       // }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pizzaTypeCh)
            {
                if (listBoxPizzas.Items.Count == 1)
                {
                    listBoxPizzas.Items.Add("Pizza size: Medium");
                    dataSentToServer.Add("Medium");
                    pizzaSizeCh = true;
                }
                else
                {
                    listBoxPizzas.Items[1] = "Pizza size: Medium";
                    dataSentToServer[1] = "Medium";
                    pizzaSizeCh = true;
                }
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
                if (listBoxPizzas.Items.Count == 1)
                {
                    listBoxPizzas.Items.Add("Pizza size: Large");
                    dataSentToServer.Add("Large");
                    pizzaSizeCh = true;
                }
                else
                {
                    listBoxPizzas.Items[1] = "Pizza size: Large";
                    dataSentToServer[1] = "Large";
                    pizzaSizeCh = true;
                }
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
