package JavaServerAttempt1;
import javax.net.ServerSocketFactory;
import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;
import java.net.*;
import java.nio.channels.ServerSocketChannel;



public class JavaServerAttempt1
{

    private static void SocketReceiveFromClient1()
    {
        boolean vals = true;
        //Receive Socket vars
        ServerSocket SocketJavaServer = null;
        Socket clientSocketReceive = null;
        InputStream textFromClient = null;
        OutputStream textToClient = null;
        String dataStreamAsString = "";
        String msgAsString = "";
        int contentLength = 0;
        String[] stringAsArray;
        int i = 0;
        //---------------------------------------------------------
        //Receive socket code
        try
        {
            SocketJavaServer = new ServerSocket(42069);
        }
        catch (IOException errorIO)
        {
            errorIO.printStackTrace();
        }
        byte[] buffer = new byte[1024];

        for(;;)
        {
            try
            {
                assert SocketJavaServer != null;
                clientSocketReceive = SocketJavaServer.accept();
            } catch (Exception errors)
            {
                errors.printStackTrace();
            }
            try
            {
                assert clientSocketReceive != null;
                textFromClient = clientSocketReceive.getInputStream();
            }
            catch (Exception errors)
            {
                errors.printStackTrace();
            }
            try
            {

                if(i != -1)
                {
                    assert textFromClient != null;
                    i = textFromClient.read(buffer);

                }
            }
            catch(Exception e)
            {
                e.printStackTrace();
            }
            try
            {

                dataStreamAsString = new String(buffer, "ASCII");
                stringAsArray = dataStreamAsString.split("\n");
                contentLength = Integer.parseInt(stringAsArray[3].substring(16).trim());
                dataStreamAsString = dataStreamAsString.trim();
                int h = 0;
                if(h == 0)
                {

                    msgAsString += "\n\nString sent from user:\n";
                    h++;
                }
                for (int j = 0; j < contentLength; j++)
                {
                    char charToBeAppended = (char) textFromClient.read();
                    msgAsString += charToBeAppended;
                }
            }
            catch (Exception errors)
            {
                errors.printStackTrace();
            }
            System.out.println(dataStreamAsString); //prints Header
            System.out.println(msgAsString);
            msgAsString = "";

            /*try {
                String vale = "vale";
                byte[] bufferOut = new byte[1024];
                char[] stringAsChars = vale.toCharArray();
                for (int j = 0; j < stringAsChars.length; j++) {

                    bufferOut[j] = (byte)stringAsChars[j];
                }
                OutputStream streamToClient = clientSocketReceive.getOutputStream();
                streamToClient.write(bufferOut);
            }
            catch(Exception errors)
            {
                errors.printStackTrace();
            }*/

                /*if(vals)   //attempt 1 to be executed once
                {
                    //Sending the response back to the client.
                    try {
                        OutputStream os = clientSocketReceive.getOutputStream();
                        OutputStreamWriter osw = new OutputStreamWriter(os);
                        BufferedWriter bw = new BufferedWriter(osw);
                        String returnMessage = "valee";
                        //osw.writeUTF(returnMessage);
                        System.out.println("Message sent to the client is " + returnMessage);
                        bw.flush();
                    } catch (Exception errors) {
                        errors.printStackTrace();
                    }
                    vals = false;
                }*/
        }
        //End of Receive socket code
    }


    public static void main(String[] args)
    {

        SocketReceiveFromClient1();









    }
}
