using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luigi_GUI
{
    public partial class LuigiGUI : Form
    {
        public LuigiGUI()
        {
            InitializeComponent();
            listBox1.Items.Clear();
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

        //POST request sending string to server
        private void POSTrequest(string uri, String order)
        {
            WebRequest request = WebRequest.Create(uri);
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = "Now it works";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        bool once = true;
        String oldText = "";
        String orderFromServer = "";
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (once)
            {
                orderFromServer = GETrequest("http://145.120.39.3:42069");
                oldText = orderFromServer;
                once = false;
            }

            orderFromServer = GETrequest("http://145.120.39.3:42069");
            bool checkIfNewOrder = oldText != orderFromServer;
            
            if (checkIfNewOrder)
            {
                oldText = orderFromServer;
                listBox1.Items.Add(oldText);
            }

        }
    }
}
