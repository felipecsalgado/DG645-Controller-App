using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms;

namespace DG645_Control_App
{
    public partial class Form_MainScreen : Form
    {

        private IPAddress ipAddress = IPAddress.Parse("10.140.115.172");
        private IPEndPoint remoteEP;// = new IPEndPoint(ipAddress, 5025);

        // Create a TCP/IP  socket.
        private Socket sender;// = new Socket(ipAddress.AddressFamily,
                              //SocketType.Stream, ProtocolType.Tcp);

        public Form_MainScreen()
        {
            InitializeComponent();
            gbx_T0.Enabled = false;
            gbx_AB.Enabled = false;
            gbx_CD.Enabled = false;
            gbx_EF.Enabled = false;
            gbx_GH.Enabled = false;
            gbx_trigger.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            StartClient();
        }

        public void StartClient()
        {
            try
            {
                // Connect to a Remote server
                // Get Host IP Address that is used to establish a connection
                // In this case, we get one IP address of localhost that is IP : 127.0.0.1
                // If a host has multiple addresses, you will get a list of addresses
                //IPHostEntry host = Dns.GetHostEntry("10.140.115.172");
                //IPAddress ipAddress = host.AddressList[0];
                tooltxtbx_status_connection.Text = mtxtbx_IP.Text.Replace(',', '.');
                this.ipAddress = IPAddress.Parse(tooltxtbx_status_connection.Text);
                this.remoteEP = new IPEndPoint(ipAddress, int.Parse(mtxtbx_port.Text));

                // Create a TCP/IP  socket.
                this.sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);


                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    // Connect to Remote EndPoint
                    sender.Connect(remoteEP);

                    tooltxtbx_status_connection.Text = "Socket connected to "
                        + sender.RemoteEndPoint.ToString();

                    //send_command("*idn?\n", sender);

                    //read_config("DLAY?4\n", sender);

                    read_config_trigger(sender);
                    read_config_T0(sender);
                    read_config_AB(sender);
                    read_config_CD(sender);
                    read_config_EF(sender);
                    read_config_GH(sender);

                    gbx_T0.Enabled = true;
                    gbx_AB.Enabled = true;
                    gbx_CD.Enabled = true;
                    gbx_EF.Enabled = true;
                    gbx_GH.Enabled = true;
                    gbx_trigger.Enabled = true;


                    // Release the socket.
                    //sender.Shutdown(SocketShutdown.Both);
                    //sender.Close();

                }
                catch (ArgumentNullException ane)
                {

                    MessageBox.Show(ane.ToString(), "ArgumentNullException:");
                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.ToString(), "SocketException:");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Unexpected exception:");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error:");
            }
        }

        public void CloseClient(Socket sender)
        {

            // Connect the socket to the remote endpoint. Catch any errors.
            try
            {
                // Release the socket.
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                tooltxtbx_status_connection.Text = "Disconnected";
                

            }
            catch (ArgumentNullException ane)
            {

                MessageBox.Show(ane.ToString(), "ArgumentNullException:");
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.ToString(), "SocketException:");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Unexpected exception:");
            }
        }

        public void send_command(string command, Socket sender)
        {
            byte[] bytes = new byte[1024];

            // Encode the data string into a byte array.
            byte[] msg = Encoding.ASCII.GetBytes(command);

            // Send the data through the socket.
            int bytesSent = sender.Send(msg);

            // Receive the response from the remote device.
            int bytesRec = sender.Receive(bytes);
            MessageBox.Show(bytesRec.ToString());
            //Console.WriteLine("Echoed test = {0}",
            //    Encoding.ASCII.GetString(bytes, 0, bytesRec));
            MessageBox.Show(Encoding.ASCII.GetString(bytes, 0, bytesRec));
        }

        public static string read_config(string command, Socket sender)
        {
            byte[] bytes = new byte[1024];

            // Encode the data string into a byte array.
            byte[] msg = Encoding.ASCII.GetBytes(command);

            // Send the data through the socket.
            int bytesSent = sender.Send(msg);

            // Receive the response from the remote device.
            int bytesRec = sender.Receive(bytes);
            //MessageBox.Show(bytesRec.ToString());
            //Console.WriteLine("Echoed test = {0}",
            //    Encoding.ASCII.GetString(bytes, 0, bytesRec));
            string return_msg = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            //MessageBox.Show(return_msg);

            return return_msg;
        }

        public string write_config(string command, Socket sender, string scom)
        {

            try
            {
                byte[] bytes = new byte[1024];

                // Encode the data string into a byte array.
                byte[] msg = Encoding.ASCII.GetBytes(command);

                // Send the data through the socket.
                int bytesSent = sender.Send(msg);

                // Receive the response from the remote device.
                string return_msg  = "Command of " + scom + " executed successfully!";

                return return_msg;

            }
            catch (ArgumentNullException ane)
            {

                MessageBox.Show(ane.ToString(), "ArgumentNullException:");
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.ToString(), "SocketException:");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Unexpected exception:");
            }

            return "Error during executing the command!";
        }

        public void read_config_T0(Socket sender)
        {
            string msg_response;

            // Channel T0
            msg_response = read_config("DLAY?0\n", sender);
            mtxtbx_delay_T0.Text = msg_response.Split(",")[1];

            msg_response = read_config("DLAY?1\n", sender);
            mtxtbx_duration_T1.Text = msg_response.Split(",")[1];

            msg_response = read_config("LAMP?0\n", sender);
            mtxtbx_amplitude_T0.Text = msg_response;

            msg_response = read_config("LOFF?0\n", sender);
            mtxtbx_offset_T0.Text = msg_response;

            msg_response = read_config("LPOL?0\n", sender);
            if (int.Parse(msg_response) == 1)
            {
                rbtn_pos_T0.Checked = true;
                rbtn_neg_T0.Checked = false;
            }
            else
            {
                rbtn_pos_T0.Checked = false;
                rbtn_neg_T0.Checked = true;
            }
        }

        public void read_config_AB(Socket sender)
        {
            string msg_response;

            // Channel AB
            msg_response = read_config("DLAY?2\n", sender);
            mtxtbx_delay_A.Text = msg_response.Split(",")[1];
            cmbx_delay_A.Text = get_Channel_Cmb(int.Parse(msg_response.Split(",")[0]));

            msg_response = read_config("DLAY?3\n", sender);
            mtxtbx_duration_B.Text = msg_response.Split(",")[1];
            cmbx_delay_AB.Text = get_Channel_Cmb(int.Parse(msg_response.Split(",")[0]));
                

            msg_response = read_config("LAMP?1\n", sender);
            mtxtbx_amplitude_AB.Text = msg_response;

            msg_response = read_config("LOFF?1\n", sender);
            mtxtbx_offset_AB.Text = msg_response;

            msg_response = read_config("LPOL?1\n", sender);
            if (int.Parse(msg_response) == 1)
            {
                rbtn_pos_AB.Checked = true;
                rbtn_neg_AB.Checked = false;
            }
            else
            {
                rbtn_pos_AB.Checked = false;
                rbtn_neg_AB.Checked = true;
            }
        }

        public void read_config_CD(Socket sender)
        {
            string msg_response;

            // Channel CD
            msg_response = read_config("DLAY?4\n", sender);
            mtxtbx_delay_C.Text = msg_response.Split(",")[1];
            cmbx_delay_C.Text = get_Channel_Cmb(int.Parse(msg_response.Split(",")[0]));

            msg_response = read_config("DLAY?5\n", sender);
            mtxtbx_duration_D.Text = msg_response.Split(",")[1];
            cmbx_delay_CD.Text = get_Channel_Cmb(int.Parse(msg_response.Split(",")[0]));

            msg_response = read_config("LAMP?2\n", sender);
            mtxtbx_amplitude_CD.Text = msg_response;

            msg_response = read_config("LOFF?2\n", sender);
            mtxtbx_offset_CD.Text = msg_response;

            msg_response = read_config("LPOL?2\n", sender);
            if (int.Parse(msg_response) == 1)
            {
                rbtn_pos_CD.Checked = true;
                rbtn_neg_CD.Checked = false;
            }
            else
            {
                rbtn_pos_CD.Checked = false;
                rbtn_neg_CD.Checked = true;
            }
        }

        public void read_config_EF(Socket sender)
        {
            string msg_response;

            // Channel EF
            msg_response = read_config("DLAY?6\n", sender);
            mtxtbx_delay_E.Text = msg_response.Split(",")[1];
            cmbx_delay_E.Text = get_Channel_Cmb(int.Parse(msg_response.Split(",")[0]));

            msg_response = read_config("DLAY?7\n", sender);
            mtxtbx_duration_F.Text = msg_response.Split(",")[1];
            cmbx_delay_EF.Text = get_Channel_Cmb(int.Parse(msg_response.Split(",")[0]));

            msg_response = read_config("LAMP?3\n", sender);
            mtxtbx_amplitude_EF.Text = msg_response;

            msg_response = read_config("LOFF?3\n", sender);
            mtxtbx_offset_EF.Text = msg_response;

            msg_response = read_config("LPOL?3\n", sender);
            if (int.Parse(msg_response) == 1)
            {
                rbtn_pos_EF.Checked = true;
                rbtn_neg_EF.Checked = false;
            }
            else
            {
                rbtn_pos_EF.Checked = false;
                rbtn_neg_EF.Checked = true;
            }
        }

        public void read_config_GH(Socket sender)
        {
            string msg_response;

            // Channel GH
            msg_response = read_config("DLAY?8\n", sender);
            mtxtbx_delay_G.Text = msg_response.Split(",")[1];
            cmbx_delay_G.Text = get_Channel_Cmb(int.Parse(msg_response.Split(",")[0]));

            msg_response = read_config("DLAY?9\n", sender);
            mtxtbx_duration_H.Text = msg_response.Split(",")[1];
            cmbx_delay_GH.Text = get_Channel_Cmb(int.Parse(msg_response.Split(",")[0]));

            msg_response = read_config("LAMP?4\n", sender);
            mtxtbx_amplitude_GH.Text = msg_response;

            msg_response = read_config("LOFF?4\n", sender);
            mtxtbx_offset_GH.Text = msg_response;

            msg_response = read_config("LPOL?4\n", sender);
            if (int.Parse(msg_response) == 1)
            {
                rbtn_pos_GH.Checked = true;
                rbtn_neg_GH.Checked = false;
            }
            else
            {
                rbtn_pos_GH.Checked = false;
                rbtn_neg_GH.Checked = true;
            }
        }

        public void read_config_trigger(Socket sender)
        {
            string msg_response;

            // Trigger
            msg_response = read_config("TLVL?\n", sender);
            mtxtbx_trigger_level.Text = msg_response;

            msg_response = read_config("TRAT?\n", sender);
            mtxtbx_trigger_rate_hz.Text = msg_response.Split("+")[1].Replace('.', ',');

            msg_response = read_config("HOLD?\n", sender);
            mtxtbx_holdoff.Text = msg_response.Split("+")[1].Replace('.', ',');

            msg_response = read_config("INHB?\n", sender);
            cmbbx_trigger_inhibit.SelectedIndex = int.Parse(msg_response);


            msg_response = read_config("TSRC?\n", sender);
            cmbbx_trigger_mode.SelectedIndex = int.Parse(msg_response);

        }

        public static string parse_parameter_c_d(int parameter)
        {
            string channel;
            switch (parameter)
            {
                case 0:
                    channel = "T0";
                    break;
                case 1:
                    channel = "T1";
                    break;
                case 2:
                    channel = "A";
                    break;
                case 3:
                    channel = "B";
                    break;
                case 4:
                    channel = "C";
                    break;
                case 5:
                    channel = "D";
                    break;
                case 6:
                    channel = "E";
                    break;
                case 7:
                    channel = "F";
                    break;
                case 8:
                    channel = "G";
                    break;
                case 9:
                    channel = "H";
                    break;
                default:
                    channel = "-1";
                    break;
            }
            return channel;
        }



        private void button_disconnect_Click(object sender, EventArgs e)
        {
            CloseClient(this.sender);
            toolStripStatusCommand.Text = "";
            gbx_T0.Enabled = false;
            gbx_AB.Enabled = false;
            gbx_CD.Enabled = false;
            gbx_EF.Enabled = false;
            gbx_GH.Enabled = false;
            gbx_trigger.Enabled = false;
        }

        private void cmbbx_trigger_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbbx_trigger_mode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string msg_to_write = "TSRC " + cmbbx_trigger_mode.SelectedIndex.ToString() + "\n";
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "TRIGGER SOURCE");
        }

        private void cmbbx_trigger_inhibit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string msg_to_write = "INHB " + cmbbx_trigger_inhibit.SelectedIndex.ToString() + "\n";
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "TRIGGER INHIBIT");
        }

        private void mtxtbx_amplitude_T0_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "LAMP 0," + mtxtbx_amplitude_T0.Text.Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "AMPLITUDE T0");
        }

        private void mtxtbx_amplitude_AB_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "LAMP 1," + mtxtbx_amplitude_AB.Text.Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "AMPLITUDE AB");
        }

        private void mtxtbx_amplitude_CD_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "LAMP 2," + mtxtbx_amplitude_CD.Text.Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "AMPLITUDE CD");
        }

        private void mtxtbx_amplitude_EF_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "LAMP 3," + mtxtbx_amplitude_EF.Text.Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "AMPLITUDE EF");
        }

        private void mtxtbx_amplitude_GH_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "LAMP 4," + mtxtbx_amplitude_GH.Text.Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "AMPLITUDE GH");
        }

        private void mtxtbx_offset_T0_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "LOFF 0," + mtxtbx_offset_T0.Text.Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "OFFSET T0");
        }

        private void mtxtbx_offset_AB_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "LOFF 1," + mtxtbx_offset_AB.Text.Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "OFFSET AB");
        }

        private void mtxtbx_offset_CD_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "LOFF 2," + mtxtbx_offset_CD.Text.Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "OFFSET CD");
        }

        private void mtxtbx_offset_EF_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "LOFF 3," + mtxtbx_offset_EF.Text.Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "OFFSET EF");
        }

        private void mtxtbx_offset_GH_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "LOFF 4," + mtxtbx_offset_GH.Text.Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "OFFSET GH");
        }

        private void rbtn_pos_T0_CheckedChanged(object sender, EventArgs e)
        {
            string msg_to_write = null;

            if (rbtn_pos_T0.Checked == true && rbtn_neg_T0.Checked == false)
                msg_to_write = "LPOL 0,1\n";
            else if (rbtn_pos_T0.Checked == false && rbtn_neg_T0.Checked == true)
                msg_to_write = "LPOL 0,0\n";

            if (msg_to_write != null)
                toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "POLARITY T0");
        }

        private void rbtn_pos_AB_CheckedChanged(object sender, EventArgs e)
        {
            string msg_to_write = null;

            if (rbtn_pos_AB.Checked == true && rbtn_neg_AB.Checked == false)
                msg_to_write = "LPOL 1,1\n";
            else if (rbtn_pos_AB.Checked == false && rbtn_neg_AB.Checked == true)
                msg_to_write = "LPOL 1,0\n";

            if (msg_to_write != null)
                toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "POLARITY AB");
        }

        private void rbtn_pos_CD_CheckedChanged(object sender, EventArgs e)
        {
            string msg_to_write = null;

            if (rbtn_pos_CD.Checked == true && rbtn_neg_CD.Checked == false)
                msg_to_write = "LPOL 2,1\n";
            else if (rbtn_pos_CD.Checked == false && rbtn_neg_CD.Checked == true)
                msg_to_write = "LPOL 2,0\n";

            if (msg_to_write != null)
                toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "POLARITY CD");
        }

        private void rbtn_pos_EF_CheckedChanged(object sender, EventArgs e)
        {
            string msg_to_write = null;

            if (rbtn_pos_EF.Checked == true && rbtn_neg_EF.Checked == false)
                msg_to_write = "LPOL 3,1\n";
            else if (rbtn_pos_EF.Checked == false && rbtn_neg_EF.Checked == true)
                msg_to_write = "LPOL 3,0\n";

            if (msg_to_write != null)
                toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "POLARITY EF");
        }

        private void rbtn_pos_GH_CheckedChanged(object sender, EventArgs e)
        {
            string msg_to_write = null;

            if (rbtn_pos_GH.Checked == true && rbtn_neg_GH.Checked == false)
                msg_to_write = "LPOL 4,1\n";
            else if (rbtn_pos_GH.Checked == false && rbtn_neg_GH.Checked == true)
                msg_to_write = "LPOL 4,0\n";

            if (msg_to_write != null)
                toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "POLARITY GH");
        }

        private void Form_MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
             try
            {
                //if(this.sender != null)
                //    CloseClient(this.sender);
                toolStripStatusCommand.Text = "";
                gbx_T0.Enabled = false;
                gbx_AB.Enabled = false;
                gbx_CD.Enabled = false;
                gbx_EF.Enabled = false;
                gbx_GH.Enabled = false;
                gbx_trigger.Enabled = false;
            }
            catch 
            {
                this.Close();
            }
            */
        }

        private void mtxtbx_duration_T1_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "DLAY 1,0,"
                + mtxtbx_duration_T1.Text.Replace(".", "").Replace(',', '.') + "\n";
            toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "DELAY T1");
        }

        private void mtxtbx_delay_A_Leave(object sender, EventArgs e)
        {
            int channel = get_Index_Cmb(cmbx_delay_A.Text);
            string msg_to_write = "DLAY 2," + channel + ","
                + mtxtbx_delay_A.Text.Replace(".", "").Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "DELAY A");
        }

        private void mtxtbx_delay_C_Leave(object sender, EventArgs e)
        {
            int channel = get_Index_Cmb(cmbx_delay_C.Text);
            string msg_to_write = "DLAY 4," + channel + ","
                + mtxtbx_delay_C.Text.Replace(".", "").Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "DELAY C");
        }

        private void mtxtbx_delay_E_Leave(object sender, EventArgs e)
        {
            int channel = get_Index_Cmb(cmbx_delay_E.Text);
            string msg_to_write = "DLAY 6," + channel + ","
                + mtxtbx_delay_E.Text.Replace(".", "").Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "DELAY E");
        }

        private int get_Index_Cmb(string item)
        {
            int index = 0;

            if (item == "T0")
                index = 0;
            else if (item == "A")
                index = 2;
            else if (item == "B")
                index = 3;
            else if (item == "C")
                index = 4;
            else if (item == "D")
                index = 5;
            else if (item == "E")
                index = 6;
            else if (item == "F")
                index = 7;
            else if (item == "G")
                index = 8;
            else if (item == "H")
                index = 9;

            return index;
        }

        private string get_Channel_Cmb(int item)
        {
            string channel = "T0";

            if (item == 0)
                channel = "T0";
            else if (item == 1)
                channel = "T1";
            else if (item == 2)
                channel = "A";
            else if (item == 3)
                channel = "B";
            else if (item == 4)
                channel = "C";
            else if (item == 5)
                channel = "D";
            else if (item == 6)
                channel = "E";
            else if (item == 7)
                channel = "F";
            else if (item == 8)
                channel = "G";
            else if (item == 9)
                channel = "H";

            return channel;
        }

        private void mtxtbx_duration_B_Leave(object sender, EventArgs e)
        {
            int channel = get_Index_Cmb(cmbx_delay_AB.Text);
            string msg_to_write = "DLAY 3," + channel + ","
                + mtxtbx_duration_B.Text.Replace(".", "").Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "DELAY B");
        }

        private void mtxtbx_duration_D_Leave(object sender, EventArgs e)
        {
            int channel = get_Index_Cmb(cmbx_delay_CD.Text);
            string msg_to_write = "DLAY 5," + channel + ","
                + mtxtbx_duration_D.Text.Replace(".", "").Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "DELAY D");
        }

        private void mtxtbx_duration_F_Leave(object sender, EventArgs e)
        {
            int channel = get_Index_Cmb(cmbx_delay_EF.Text);
            string msg_to_write = "DLAY 7," + channel + ","
                + mtxtbx_duration_F.Text.Replace(".", "").Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "DELAY F");
        }

        private void mtxtbx_delay_G_Leave(object sender, EventArgs e)
        {
            int channel = get_Index_Cmb(cmbx_delay_G.Text);
            string msg_to_write = "DLAY 8," + channel + ","
                + mtxtbx_delay_G.Text.Replace(".", "").Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "DELAY G");
        }

        private void mtxtbx_duration_H_Leave(object sender, EventArgs e)
        {
            int channel = get_Index_Cmb(cmbx_delay_GH.Text);
            string msg_to_write = "DLAY 9," + channel + ","
                + mtxtbx_duration_H.Text.Replace(".", "").Replace(',', '.') + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "DELAY H");
        }

        private void mtxtbx_trigger_rate_hz_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "TRAT " + 
                mtxtbx_trigger_rate_hz.Text.Replace(",", ".") + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            //MessageBox.Show(msg_to_write);
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "TRIGGER RATE");
        }

        private void mtxtbx_trigger_level_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "TLVL " +
                mtxtbx_trigger_level.Text.Replace(",", ".") + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            //MessageBox.Show(msg_to_write);
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "TRIGGER LEVEL");
        }

        private void mtxtbx_holdoff_Leave(object sender, EventArgs e)
        {
            string msg_to_write = "HOLD " +
                mtxtbx_holdoff.Text.Replace(",", ".") + "\n";
            //toolStripStatusCommand.Text = msg_to_write;
            //MessageBox.Show(msg_to_write);
            toolStripStatusCommand.Text = write_config(msg_to_write, this.sender, "TRIGGER HOLD");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple application for controlling SRS Delay Generator DG 645.", 
                "About");
        }
    }
}