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
                MessageBox.Show("Arduino is not connected or port is not selected correctly");
            }
        }

        String textInPort;
        List<String> dataSentToServer = new List<String>();

        bool pizzaTypeCh, pizzaSizeCh, ifDataReceived, checkAllUnchecked = false;


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
            try
            {
                //First we create a Webrequest type variable with an absolute uri (htttp://ipaddress:port/)
                WebRequest request = WebRequest.Create(uri);
                //We specify that it will be a POST request, the WebRequest class enables us to do it that easily
                request.Method = "POST";
                //Order is a String which we convert to byte array and later upload to Stream.
                byte[] buffer = Encoding.UTF8.GetBytes(order);
                //We specify what is sending the request, again WebRequest class makes it easy for us
                request.ContentType = "Mario's Interface";
                //Here we tell the server how long our byte array is (string we are sending) (constructing the header)
                request.ContentLength = buffer.Length;
                //We create a Stream type variable and store the requestStream in it
                Stream dataStream = request.GetRequestStream();
                //Uploading the byte array to the requested stream
                dataStream.Write(buffer, 0, buffer.Length);
                //Stream is closed since we dont need it anymore
                dataStream.Close();
                //Here we wait for the server's response (if not received, we get an exception)         
                WebResponse response = request.GetResponse();
                //We print the status in console just for clarification
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                //We get the data from the response stream
                dataStream = response.GetResponseStream();
                //We use the StreamReader class to read the incoming Stream at ease
                StreamReader reader = new StreamReader(dataStream);
                //We save the stream's content data in a String
                string responseFromServer = reader.ReadToEnd();
                //We display the data in the Console for debugging, this helped me a lot when I was building the server on Java with Sockets (I left that code for clarification, we don't use it)
                Console.WriteLine(responseFromServer);
                //Closing the streams
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception errors)
            {
                MessageBox.Show("Client did not receive a response from server, please check connection with server, there is something wrong ! \n Possible errors: wrong IP, wrong Port, server not launched");
            }
        }

        public String DrinksOrdered()
        {
            String finalDrinks = "";
            String[] DrinksWithInts = new String[6];
            int[] vale = new int[6];
            vale[0] = Convert.ToInt32(lbCola.Text);
            DrinksWithInts[0] = "Coca-Colas to be served : " + vale[0];
            vale[1] = Convert.ToInt32(lbPepsi.Text);
            DrinksWithInts[1] = "Pepsis to be served : " + vale[1];
            vale[2] = Convert.ToInt32(lbFanta.Text);
            DrinksWithInts[2] = "Fantas to be served : " + vale[2];
            vale[3] = Convert.ToInt32(lbJuice.Text);
            DrinksWithInts[3] = "Juices to be served : " + vale[3];
            vale[4] = Convert.ToInt32(lbLipton.Text);
            DrinksWithInts[4] = "Liptons to be served : " + vale[4];
            vale[5] = Convert.ToInt32(lbSchweppes.Text);
            DrinksWithInts[5] = "Schweppes' to be served : " + vale[5];

            for (int i = 0; i < vale.Length; i ++)
            {
                
                if (vale[i] != 0)
                {
                    finalDrinks += DrinksWithInts[i] + "\n";
                }
            }
            lbCola.Text = "0";
            lbFanta.Text = "0";
            lbPepsi.Text = "0";
            lbJuice.Text = "0";
            lbSchweppes.Text = "0";
            lbLipton.Text = "0";
            return finalDrinks;   
        }

        //Get request returning string from server
        public string GETrequest(string uri) //We dont use get requests in this client (yet)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                return reader.ReadToEnd();
            }
            catch (Exception errors)
            {
                MessageBox.Show("Client did not receive a response from server, please check connection with server, there is something wrong ! \n Possible errors: wrong IP, wrong Port, server not launched");
                return "";
            }
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
            if (!pizzaTypeCh || !pizzaSizeCh)
            {
                MessageBox.Show("No Pizza selected.");
            }
            else
            {
                ordersForTheDay++;
                String order = "";
                for (int i = 0; i < dataSentToServer.Count; i++)
                {
                    if (i == 0)
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
                
                
            
                POSTrequest("http://192.168.1.70:42069/", order);
                
                lbPizzasOrderedToday.Text = "Pizzas ordered today: " + ordersForTheDay.ToString();
              
                pizzaTypeCh = false;
                pizzaSizeCh = false;
            }
            listBoxPizzas.Items.Clear();
            for (int i = 0; i < chlbExtra.Items.Count; i++)
            {
                chlbExtra.SetItemChecked(i, false);
                checkAllUnchecked = true;
            }
            dataSentToServer.Clear();
            String drinksToBeDisplayed = DrinksOrdered();
            if (drinksToBeDisplayed != "")
            MessageBox.Show(drinksToBeDisplayed);
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (pizzaTypeCh)
                {
                    if (listBoxPizzas.Items.Count == 1)
                    {
                        listBoxPizzas.Items.Add("Pizza size: Small");
                        dataSentToServer.Add("Small");
                        pizzaSizeCh = true;
                    }
                    else
                    {
                        listBoxPizzas.Items[1] = "Pizza size: Small";
                        dataSentToServer[1] = "Small";
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
            catch (Exception errors)
            {
                MessageBox.Show("Please follow the order!");
            }
        }



        private void ChlbExtra_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!checkAllUnchecked)
            {
                if (pizzaSizeCh)
                {
                    chlbExtra.BeginInvoke(new Action(() =>   //lambda function, like a foreach, inverts order of doing the check
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
                            if ((chlbExtra.Items[chlbExtra.SelectedIndex]).ToString().StartsWith("Extra"))
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
            else
            {
                checkAllUnchecked = false;
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
                pizzaNumber++;
                if (pizzaNumber > ordersForTheDay)
                {
                    pizzaNumber--;
                    ifDataReceived = false;
                }
                else
                {
                    System.Media.SoundPlayer notificationSound = new System.Media.SoundPlayer();  // bruh sound effect
                    notificationSound.Stream = Properties.Resources.bruh;
                    notificationSound.Play();

                    listViewReadyOrders.Items.Add("Pizza number " + pizzaNumber + " is ready for pick up!");
                    POSTrequest("http://192.168.1.70:42069", "ZPizza number " + pizzaNumber + " is ready for pick up!");
                    ifDataReceived = false;
                    //to add a sound to inform cashier an order is ready !
                }
                
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

            if (textInPort == "1")
            ifDataReceived = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
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
            try
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
            catch (Exception error)
            {
                MessageBox.Show("Please follow the order!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception errors)
            {
                MessageBox.Show("Please Follow the order");
                 
            }
           
        }
    }
}
