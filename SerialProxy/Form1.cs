using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace SerialProxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comportUpdate("Start");

            SerialPort1.PinChanged += new SerialPinChangedEventHandler(SerialPort1_PinChanged);
            SerialPort1.ReadTimeout = SerialPort1.WriteTimeout = 1000;

            SerialPort2.PinChanged += new SerialPinChangedEventHandler(SerialPort2_PinChanged);
            SerialPort2.ReadTimeout = SerialPort2.WriteTimeout = 1000;

            BackgroundWorker1.WorkerSupportsCancellation = true;
            BackgroundWorker1.WorkerReportsProgress = true;
            BackgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            BackgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;

            BackgroundWorker2.WorkerSupportsCancellation = true;
            BackgroundWorker2.WorkerReportsProgress = true;
            BackgroundWorker2.DoWork += BackgroundWorker2_DoWork;
            BackgroundWorker2.ProgressChanged += BackgroundWorker2_ProgressChanged;

            this.Text = Version.NameAndNumber;

            ComBaudRates1.Items.Clear();
            ComBaudRates1.Items.AddRange(SerialPort_value.baudRates.ToArray());
            ComBaudRates1.SelectedItem = "9600";
            ComBaudRates2.Items.Clear();
            ComBaudRates2.Items.AddRange(SerialPort_value.baudRates.ToArray());
            ComBaudRates2.SelectedItem = "9600";

            ComDataBit1.Items.Clear();
            ComDataBit1.Items.AddRange(SerialPort_value.dataBits.ToArray());
            ComDataBit1.SelectedItem = "8";
            ComDataBit2.Items.Clear();
            ComDataBit2.Items.AddRange(SerialPort_value.dataBits.ToArray());
            ComDataBit2.SelectedItem = "8";

            ComStopBit1.Items.Clear();
            ComStopBit1.Items.AddRange(SerialPort_value.stopBits.ToArray());
            ComStopBit1.SelectedItem = "1";
            ComStopBit2.Items.Clear();
            ComStopBit2.Items.AddRange(SerialPort_value.stopBits.ToArray());
            ComStopBit2.SelectedItem = "1";

            ComParity1.Items.Clear();
            ComParity1.Items.AddRange(SerialPort_value.parity.ToArray());
            ComParity1.SelectedItem = "None";
            ComParity2.Items.Clear();
            ComParity2.Items.AddRange(SerialPort_value.parity.ToArray());
            ComParity2.SelectedItem = "None";

            ComHandshake1.Items.Clear();
            ComHandshake1.Items.AddRange(SerialPort_value.Handshake.ToArray());
            ComHandshake1.SelectedItem = "None";
            ComHandshake2.Items.Clear();
            ComHandshake2.Items.AddRange(SerialPort_value.Handshake.ToArray());
            ComHandshake2.SelectedItem = "None";


            
        }

        public static SerialPort SerialPort1 = new SerialPort();
        public static BackgroundWorker BackgroundWorker1 = new BackgroundWorker();

        public static SerialPort SerialPort2 = new SerialPort();
        public static BackgroundWorker BackgroundWorker2 = new BackgroundWorker();

        static class SerialPort_value
        {
            public static string port_name1 = "Radio";
            public static string port_name2 = "Program";
 
            public static bool status_BreakState1 = false;
            public static bool status_CDHolding1 = false;
            public static bool status_CtsHolding1 = false;
            public static bool status_DsrHolding1 = false;

            public static bool status_BreakState2 = false;
            public static bool status_CDHolding2 = false;
            public static bool status_CtsHolding2 = false;
            public static bool status_DsrHolding2 = false;

            public static byte[] data_receiving1 = new byte[0];
            public static int[] data_receiving1int = new int[0];
            public static byte[] data_receiving2 = new byte[0];
            public static int[] data_receiving2int = new int[0];

            public static readonly List<string> baudRates = new List<string>
                                                    {"75"
                                                    ,"110"
                                                    ,"150"
                                                    ,"300"
                                                    ,"600"
                                                    ,"1200"
                                                    ,"1800"
                                                    ,"2400"
                                                    ,"4800"
                                                    ,"7200"
                                                    ,"9600"
                                                    ,"14400"
                                                    ,"19200"
                                                    ,"31250"
                                                    ,"38400"
                                                    ,"56000"
                                                    ,"57600"
                                                    ,"76800"
                                                    ,"115200"
                                                    ,"128000"
                                                    ,"230400"
                                                    ,"250000"
                                                    ,"256000"};
            public static readonly List<string> dataBits = new List<string>
                                                    {"5"
                                                    ,"6"
                                                    ,"7"
                                                    ,"8"
                                                    ,"9"};
            public static readonly List<string> stopBits = new List<string>
                                                    {"0"
                                                    ,"1"
                                                    ,"1.5"
                                                    ,"2"};
            public static readonly List<string> parity = new List<string>
                                                    {"None"
                                                    ,"Even"
                                                    ,"Odd"
                                                    ,"Mark"
                                                    ,"Space"};
            public static readonly List<string> Handshake = new List<string>
                                                    {"None"
                                                    ,"RTS"
                                                    ,"RTS/XOnXOff"
                                                    ,"XOnXOff"};
        }
        public class SerialPort_Data
        {
            public byte[] Data_sp1 { get; set; }
            public byte[] Data_sp2 { get; set; }
        }

        private void DebugLogTextInsert(string program, string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, string>(DebugLogTextInsert), new object[] { program, text });
                return;
            }

            textBox1.Text = textBox1.Text.Insert(0, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + program + " : " + text + "\r\n");
            DebugLogRemoveLines(500);
        }
        private void DebugLogRemoveLines(int rows)
        {

            if (textBox1.Lines.Length > rows)
            {
                textBox1.Lines = textBox1.Lines.Take(rows).ToArray();
            }
        }
        private void comportUpdate(string program)
        {

            ComPortNumber1.Items.Clear();
            ComPortNumber2.Items.Clear();

            ComPortNumber1.Sorted = true;
            ComPortNumber2.Sorted = true;

            ComPortNumber1.Items.AddRange(SerialPort.GetPortNames());
            ComPortNumber2.Items.AddRange(SerialPort.GetPortNames());


            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\cimv2",
                "SELECT * FROM Win32_PnPEntity where Caption is not null");

            foreach (ManagementObject CNCA in searcher.Get())
            {
                if (CNCA["DeviceID"].ToString().IndexOf("CNCA") > 0)
                {
                    foreach (ManagementObject CNCB in searcher.Get())
                    {
                        try
                        {
                            if (CNCB["DeviceID"].ToString().IndexOf("CNCB") > 0 && CNCA["DeviceID"].ToString().Substring(17) == CNCB["DeviceID"].ToString().Substring(17))
                            {
                                int startA = CNCA["Caption"].ToString().IndexOf("(COM") + 1;
                                int startB = CNCB["Caption"].ToString().IndexOf("(COM") + 1;
                                int endA = CNCA["Caption"].ToString().IndexOf(")", startA);
                                int endB = CNCB["Caption"].ToString().IndexOf(")", startB);
                                DebugLogTextInsert("com0com", CNCA["Caption"].ToString().Substring(startA, endA - startA) + " - " + CNCB["Caption"].ToString().Substring(startB, endB - startB));
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }


                    }
                }

            }

            foreach (ManagementObject queryObj in searcher.Get())
            {
                if ((queryObj["Caption"].ToString().IndexOf("(COM") > 0) && (queryObj["Caption"].ToString().IndexOf("com0com") < 0))
                {
                    DebugLogTextInsert("Serial interface", queryObj["Caption"].ToString());
                }
            }


            DebugLogTextInsert(program, "Check Comport");
        }

        private void ComPortConnect1_Click(object sender, EventArgs e)
        {
            try
            {

                SerialPort1.PortName = ComPortNumber1.Text;
                SerialPort1.BaudRate = Convert.ToInt32(ComBaudRates1.SelectedItem);
                SerialPort1.DataBits = Convert.ToInt32(ComDataBit1.SelectedItem);
                //SerialPort1.StopBits = System.IO.Ports.StopBits.One;
                //SerialPort1.Parity = System.IO.Ports.Parity.None;
                //SerialPort1.Handshake = Handshake.None;

                if (ComStopBit1.SelectedItem.ToString() == "1")
                    SerialPort1.StopBits = System.IO.Ports.StopBits.One;
                else if (ComStopBit1.SelectedItem.ToString() == "1.5")
                    SerialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                else if (ComStopBit1.SelectedItem.ToString() == "2")
                    SerialPort1.StopBits = System.IO.Ports.StopBits.Two;
                else
                    SerialPort1.StopBits = System.IO.Ports.StopBits.None;

                if (ComParity1.SelectedItem.ToString() == "Even")
                    SerialPort1.Parity = System.IO.Ports.Parity.Even;
                else if (ComParity1.SelectedItem.ToString() == "Odd")
                    SerialPort1.Parity = System.IO.Ports.Parity.Odd;
                else if (ComParity1.SelectedItem.ToString() == "Space")
                    SerialPort1.Parity = System.IO.Ports.Parity.Space;
                else if (ComParity1.SelectedItem.ToString() == "Mark")
                    SerialPort1.Parity = System.IO.Ports.Parity.Mark;
                else
                    SerialPort1.Parity = System.IO.Ports.Parity.None;

                if (ComHandshake1.SelectedItem.ToString() == "RTS")
                    SerialPort1.Handshake = System.IO.Ports.Handshake.RequestToSend;
                else if (ComHandshake1.SelectedItem.ToString() == "RTS/XOnXOff")
                    SerialPort1.Handshake = System.IO.Ports.Handshake.RequestToSendXOnXOff;
                else if (ComHandshake1.SelectedItem.ToString() == "XOnXOff")
                    SerialPort1.Handshake = System.IO.Ports.Handshake.XOnXOff;
                else
                    SerialPort1.Handshake = System.IO.Ports.Handshake.None;

                SerialPort1.Open();
                SerialPort1.DiscardInBuffer();
                SerialPort1.DiscardOutBuffer();

                if (ComHandshake1.SelectedItem.ToString().Substring(0, 3) != "RTS") 
                    SerialPort1.RtsEnable = false;
                
                SerialPort1.DtrEnable = false;

                RTS1.Checked = false;
                DTR1.Checked = false;

                BackgroundWorker1.RunWorkerAsync();

                ComPortConnect1.Enabled = false;
                ComPortDisconnect1.Enabled = true;
                ComPortNumber1.Enabled = false;
                
                ComBaudRates1.Enabled = false;
                ComDataBit1.Enabled = false;
                ComStopBit1.Enabled = false;
                ComParity1.Enabled = false;
                ComHandshake1.Enabled = false;

                ComPortStatus();

                DebugLogTextInsert("Open " + SerialPort1.PortName,  
                                                      "BaudRate " + SerialPort1.BaudRate.ToString() 
                                                   + ", DataBits " + SerialPort1.DataBits.ToString()
                                                   + ", StopBits " + SerialPort1.StopBits.ToString()
                                                   + ", Parity " + SerialPort1.Parity.ToString()
                                                   + ", Handshake " + SerialPort1.Handshake.ToString()
                                                              );

            }
            catch (Exception ex)
            {
                if (SerialPort1.IsOpen) SerialPort1.Close();

                ComPortConnect1.Enabled = true;
                ComPortDisconnect1.Enabled = false;
                ComPortNumber1.Enabled = true;

                ComBaudRates1.Enabled = true;
                ComDataBit1.Enabled = true;
                ComStopBit1.Enabled = true;
                ComParity1.Enabled = true;
                ComHandshake1.Enabled = true;

                //Debug.WriteLine("ComPortConnect1_Click: " + ex.Message);
                MessageBox.Show(ex.Message, "ComPortError " + SerialPort_value.port_name1);
            }
        }
        private void ComPortConnect2_Click(object sender, EventArgs e)
        {
            try
            {

                SerialPort2.PortName = ComPortNumber2.Text;
                SerialPort2.BaudRate = Convert.ToInt32(ComBaudRates2.SelectedItem);
                SerialPort2.DataBits = Convert.ToInt32(ComDataBit2.SelectedItem);
                //SerialPort2.StopBits = System.IO.Ports.StopBits.One;
                //SerialPort2.Parity = System.IO.Ports.Parity.None;
                SerialPort2.Handshake = Handshake.None;

                if (ComStopBit2.SelectedItem.ToString() == "1")
                    SerialPort2.StopBits = System.IO.Ports.StopBits.One;
                else if (ComStopBit2.SelectedItem.ToString() == "1.5")
                    SerialPort2.StopBits = System.IO.Ports.StopBits.OnePointFive;
                else if (ComStopBit2.SelectedItem.ToString() == "2")
                    SerialPort2.StopBits = System.IO.Ports.StopBits.Two;
                else
                    SerialPort2.StopBits = System.IO.Ports.StopBits.None;

                if (ComParity2.SelectedItem.ToString() == "Even")
                    SerialPort2.Parity = System.IO.Ports.Parity.Even;
                else if (ComParity2.SelectedItem.ToString() == "Odd")
                    SerialPort2.Parity = System.IO.Ports.Parity.Odd;
                else if (ComParity2.SelectedItem.ToString() == "Space")
                    SerialPort2.Parity = System.IO.Ports.Parity.Space;
                else if (ComParity2.SelectedItem.ToString() == "Mark")
                    SerialPort2.Parity = System.IO.Ports.Parity.Mark;
                else
                    SerialPort2.Parity = System.IO.Ports.Parity.None;


                if (ComHandshake2.SelectedItem.ToString() == "RTS")
                    SerialPort2.Handshake = System.IO.Ports.Handshake.RequestToSend;
                else if (ComHandshake2.SelectedItem.ToString() == "RTS/XOnXOff")
                    SerialPort2.Handshake = System.IO.Ports.Handshake.RequestToSendXOnXOff;
                else if (ComHandshake2.SelectedItem.ToString() == "XOnXOff")
                    SerialPort2.Handshake = System.IO.Ports.Handshake.XOnXOff;
                else
                    SerialPort2.Handshake = System.IO.Ports.Handshake.None;

                //SerialPort1.DtrEnable = true;
                SerialPort2.Open();
                SerialPort2.DiscardInBuffer();
                SerialPort2.DiscardOutBuffer();
                
                if (ComHandshake2.SelectedItem.ToString().Substring(0, 3) != "RTS")
                    SerialPort2.RtsEnable = false;

                SerialPort2.DtrEnable = false;

                RTS2.Checked = false;
                DTR2.Checked = false;

                BackgroundWorker2.RunWorkerAsync();

                ComPortConnect2.Enabled = false;
                ComPortDisconnect2.Enabled = true;
                ComPortNumber2.Enabled = false;

                ComBaudRates2.Enabled = false;
                ComDataBit2.Enabled = false;
                ComStopBit2.Enabled = false;
                ComParity2.Enabled = false;
                ComHandshake2.Enabled = false;

                ComPortStatus();

                DebugLogTextInsert("Open " + SerialPort2.PortName,
                                                      "BaudRate " + SerialPort2.BaudRate.ToString()
                                                   + ", DataBits " + SerialPort2.DataBits.ToString()
                                                   + ", StopBits " + SerialPort2.StopBits.ToString()
                                                   + ", Parity " + SerialPort2.Parity.ToString()
                                                   + ", Handshake " + SerialPort2.Handshake.ToString()
                                                              );

            }
            catch (Exception ex)
            {
                if (SerialPort2.IsOpen) SerialPort2.Close();

                ComPortConnect2.Enabled = true;
                ComPortDisconnect2.Enabled = false;
                ComPortNumber2.Enabled = true;

                ComBaudRates2.Enabled = true;
                ComDataBit2.Enabled = true;
                ComStopBit2.Enabled = true;
                ComParity2.Enabled = true;
                ComHandshake2.Enabled = true;

                //Debug.WriteLine("ComPortConnect1_Click: " + ex.Message);
                MessageBox.Show(ex.Message, "ComPortError " + SerialPort_value.port_name2);
            }
        }
        private void ComPortDisconnect1_Click(object sender, EventArgs e)
        {

            if (BackgroundWorker1.IsBusy)
            {
                BackgroundWorker1.CancelAsync();

                while (BackgroundWorker1.IsBusy)
                {
                    // BackgroundWorker1.Dispose();
                    //  BackgroundWorker1.Abort();
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(20);
                    //SerialPort1.Close();
                }

            }

            if (ComHandshake1.SelectedItem.ToString().Substring(0, 3) != "RTS")
                SerialPort1.RtsEnable = false;
            
            SerialPort1.DtrEnable = false;
            SerialPort1.Close();

            RTS1.Checked = false;
            DTR1.Checked = false;

            ComPortConnect1.Enabled = true;
            ComPortDisconnect1.Enabled = false;
            ComPortNumber1.Enabled = true;

            ComBaudRates1.Enabled = true;
            ComDataBit1.Enabled = true;
            ComStopBit1.Enabled = true;
            ComParity1.Enabled = true;
            ComHandshake1.Enabled = true;
        }
        private void ComPortDisconnect2_Click(object sender, EventArgs e)
        {

            if (BackgroundWorker2.IsBusy)
            {
                BackgroundWorker2.CancelAsync();

                while (BackgroundWorker2.IsBusy)
                {
                    // BackgroundWorker1.Dispose();
                    //  BackgroundWorker1.Abort();
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(20);
                    //SerialPort1.Close();
                }

            }

            if (ComHandshake2.SelectedItem.ToString().Substring(0, 3) != "RTS")
                SerialPort2.RtsEnable = false;
            
            SerialPort2.DtrEnable = false;
            SerialPort2.Close();

            RTS2.Checked = false;
            DTR2.Checked = false;

            ComPortConnect2.Enabled = true;
            ComPortDisconnect2.Enabled = false;
            ComPortNumber2.Enabled = true;

            ComBaudRates2.Enabled = true;
            ComDataBit2.Enabled = true;
            ComStopBit2.Enabled = true;
            ComParity2.Enabled = true;
            ComHandshake2.Enabled = true;
        }

        private void ComPortStatus()
        {

            if (SerialPort1.IsOpen)
            {
                SerialPort_value.status_BreakState1 = SerialPort1.BreakState;
                SerialPort_value.status_CDHolding1 = SerialPort1.CDHolding;
                SerialPort_value.status_CtsHolding1 = SerialPort1.CtsHolding;
                SerialPort_value.status_DsrHolding1 = SerialPort1.DsrHolding;

                BREAK1.Checked = SerialPort1.BreakState;
                CD1.Checked = SerialPort1.CDHolding;
                CTS1.Checked = SerialPort1.CtsHolding;
                DSR1.Checked = SerialPort1.DsrHolding;

            }

            if (SerialPort2.IsOpen)
            {
                SerialPort_value.status_BreakState2 = SerialPort2.BreakState;
                SerialPort_value.status_CDHolding2 = SerialPort2.CDHolding;
                SerialPort_value.status_CtsHolding2 = SerialPort2.CtsHolding;
                SerialPort_value.status_DsrHolding2 = SerialPort2.DsrHolding;

                BREAK2.Checked = SerialPort2.BreakState;
                CD2.Checked = SerialPort2.CDHolding;
                CTS2.Checked = SerialPort2.CtsHolding;
                DSR2.Checked = SerialPort2.DsrHolding;

            }

            if (SerialPort1.IsOpen && SerialPort2.IsOpen)
            {
                if (ComHandshake1.SelectedItem.ToString().Substring(0, 3) != "RTS")
                    SerialPort1.RtsEnable = SerialPort2.CtsHolding;

                SerialPort1.DtrEnable = SerialPort2.DsrHolding;

                if (ComHandshake2.SelectedItem.ToString().Substring(0, 3) != "RTS")
                    SerialPort2.RtsEnable = SerialPort1.CtsHolding;
                
                SerialPort2.DtrEnable = SerialPort1.DsrHolding;

                RTS1.Checked = SerialPort2.CtsHolding;
                DTR1.Checked = SerialPort2.DsrHolding;
                RTS2.Checked = SerialPort1.CtsHolding;
                DTR2.Checked = SerialPort1.DsrHolding;
            }

        }

        private void SerialPort1_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            string LogText = "";


            if (InvokeRequired)
            {
                this.Invoke(new Action<object, SerialPinChangedEventArgs>(SerialPort1_PinChanged), new object[] { sender, e });
                return;
            }

            if (e.EventType == SerialPinChange.Break && SerialPort_value.status_BreakState1 != SerialPort1.BreakState)
            {
                LogText = "BreakState:" + SerialPort1.BreakState.ToString();
                SerialPort_value.status_BreakState1 = SerialPort1.BreakState;
                BREAK1.Checked = SerialPort1.BreakState;
            }

            //if (e.EventType == SerialPinChange.CDChanged && SerialPort_value.status_CDHolding1 != SerialPort1.CDHolding)
            //{
            //    LogText = "CDHolding:" + SerialPort1.CDHolding.ToString();
            //    SerialPort_value.status_CDHolding1 = SerialPort1.CDHolding;
            //    CD1.Checked = SerialPort1.CDHolding;
            //}

            if (e.EventType == SerialPinChange.CtsChanged && SerialPort_value.status_CtsHolding1 != SerialPort1.CtsHolding)
            {
                LogText = "CtsHolding:" + SerialPort1.CtsHolding.ToString();
                SerialPort_value.status_CtsHolding1 = SerialPort1.CtsHolding;
                CTS1.Checked = SerialPort1.CtsHolding;

                


                    if (SerialPort2.IsOpen && ComHandshake2.SelectedItem.ToString().Substring(0, 3) != "RTS")
                {
                    SerialPort2.RtsEnable = SerialPort1.CtsHolding;
                    RTS2.Checked = SerialPort1.CtsHolding;
                }
            }

            if (e.EventType == SerialPinChange.DsrChanged && SerialPort_value.status_DsrHolding1 != SerialPort1.DsrHolding)
            {
                LogText = "DsrHolding:" + SerialPort1.DsrHolding.ToString();
                SerialPort_value.status_DsrHolding1 = SerialPort1.DsrHolding;
                DSR1.Checked = SerialPort1.DsrHolding;

                if (SerialPort2.IsOpen)
                {
                    SerialPort2.DtrEnable = SerialPort1.DsrHolding;
                    DTR2.Checked = SerialPort1.DsrHolding;
                }
            }

            if (e.EventType == SerialPinChange.Ring && PinChangeLog.Checked)
            {
                LogText = "Ring:?";
            }


            if (PinChangeLog.Checked && LogText.Length > 1)
            {
                this.DebugLogTextInsert(SerialPort_value.port_name1, LogText);
            }

        }
        private void SerialPort2_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            string LogText = "";


            if (InvokeRequired)
            {
                this.Invoke(new Action<object, SerialPinChangedEventArgs>(SerialPort2_PinChanged), new object[] { sender, e });
                return;
            }

            if (e.EventType == SerialPinChange.Break && SerialPort_value.status_BreakState2 != SerialPort2.BreakState)
            {
                LogText = "BreakState:" + SerialPort2.BreakState.ToString();
                SerialPort_value.status_BreakState2 = SerialPort2.BreakState;
                BREAK2.Checked = SerialPort2.BreakState;
            }

            //if (e.EventType == SerialPinChange.CDChanged && SerialPort_value.status_CDHolding2 != SerialPort2.CDHolding)
            //{
            //    LogText = "CDHolding:" + SerialPort2.CDHolding.ToString();
            //    SerialPort_value.status_CDHolding2 = SerialPort2.CDHolding;
            //    CD2.Checked = SerialPort2.CDHolding;
            //}

            if (e.EventType == SerialPinChange.CtsChanged && SerialPort_value.status_CtsHolding2 != SerialPort2.CtsHolding)
            {
                LogText = "CtsHolding:" + SerialPort2.CtsHolding.ToString();
                SerialPort_value.status_CtsHolding2 = SerialPort2.CtsHolding;
                CTS2.Checked = SerialPort2.CtsHolding;

                

               if (SerialPort1.IsOpen && ComHandshake1.SelectedItem.ToString().Substring(0, 3) != "RTS")
                {
                    SerialPort1.RtsEnable = SerialPort2.CtsHolding;
                    RTS1.Checked = SerialPort2.CtsHolding;
                }
            }

            if (e.EventType == SerialPinChange.DsrChanged && SerialPort_value.status_DsrHolding2 != SerialPort2.DsrHolding)
            {
                LogText = "DsrHolding:" + SerialPort2.DsrHolding.ToString();
                SerialPort_value.status_DsrHolding2 = SerialPort2.DsrHolding;
                DSR2.Checked = SerialPort2.DsrHolding;

                if (SerialPort1.IsOpen)
                {
                    SerialPort1.DtrEnable = SerialPort2.DsrHolding;
                    DTR1.Checked = SerialPort2.DsrHolding;
                }
            }

            if (e.EventType == SerialPinChange.Ring && PinChangeLog.Checked)
            {
                LogText = "Ring:?";
            }

       
            if (PinChangeLog.Checked && LogText.Length > 1)
            {
                this.DebugLogTextInsert(SerialPort_value.port_name2, LogText);
            }

        }


        private static void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var buffer = new byte[4096];

            while (!BackgroundWorker1.CancellationPending)
            {
                try
                {
                    if (SerialPort1.IsOpen)
                    //if (SerialPort1.IsOpen && SerialPort1.BytesToRead > 0)
                    {
                        var c = SerialPort1.Read(buffer, 0, buffer.Length);
                        BackgroundWorker1.ReportProgress(0, new SerialPort_Data() { Data_sp1 = buffer.Take(c).ToArray() });
                    }
                    //else
                    //{
                    //    Wait(10);
                    //}
                }
                catch (Exception ex)
                {
                    ;
                    //Debug.WriteLine("BackgroundWorker1_DoWork: " + ex.Message);
                }
            }

        }
        private static void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            var buffer = new byte[4096];
         
            while (!BackgroundWorker2.CancellationPending)
            {
                try
                {
                    if (SerialPort2.IsOpen)
                    //if (SerialPort2.IsOpen && SerialPort2.BytesToRead > 0)
                    {
                        var c = SerialPort2.Read(buffer, 0, buffer.Length);
                        BackgroundWorker2.ReportProgress(0, new SerialPort_Data() { Data_sp2 = buffer.Take(c).ToArray() });

                    }
                    //else
                    //{
                    //    Wait(10);
                    //}
                }
                catch (Exception ex)
                {
                    //Debug.WriteLine("BackgroundWorker2_DoWork: " + ex.Message);
                    ;
                    Wait(1);
                }

            }

        }
        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string LogText = "";
            var sp = e.UserState as SerialPort_Data;
            
            if (sp.Data_sp1.Length > 0)
            {
                if (SerialPort2.IsOpen)
                {
                    SerialPort2.Write(sp.Data_sp1, 0, sp.Data_sp1.Length);
                }
                
                LogText = "DumpData: " + BitConverter.ToString(sp.Data_sp1, 0, sp.Data_sp1.Length).Replace("-", " ");

            }

                    //Array.Clear(SerialPort_value.data_receiving1, 0, SerialPort_value.data_receiving1.Length);
                    //Array.Resize(ref SerialPort_value.data_receiving1, 0);
                    //Array.Clear(SerialPort_value.data_receiving1int, 0, SerialPort_value.data_receiving1int.Length);
                    //Array.Resize(ref SerialPort_value.data_receiving1int, 0);


            if (DumpDataLog.Checked && LogText.Length > 1)
            {
                this.DebugLogTextInsert(SerialPort_value.port_name1, LogText);
            }

        }
        private void BackgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string LogText = "";
            var sp = e.UserState as SerialPort_Data;

            if (sp.Data_sp2.Length > 0)
            {
                if (SerialPort1.IsOpen)
                {
                    SerialPort1.Write(sp.Data_sp2, 0, sp.Data_sp2.Length);
                }
                
                LogText = "DumpData: " + BitConverter.ToString(sp.Data_sp2, 0, sp.Data_sp2.Length).Replace("-", " ");

            }

            //Array.Clear(SerialPort_value.data_receiving1, 0, SerialPort_value.data_receiving1.Length);
            //Array.Resize(ref SerialPort_value.data_receiving1, 0);
            //Array.Clear(SerialPort_value.data_receiving1int, 0, SerialPort_value.data_receiving1int.Length);
            //Array.Resize(ref SerialPort_value.data_receiving1int, 0);


            if (DumpDataLog.Checked && LogText.Length > 1)
            {
                this.DebugLogTextInsert(SerialPort_value.port_name2, LogText);
            }
        }


        private void TrashButton_Click(object sender, EventArgs e)
        {
            DebugLogRemoveLines(0);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            comportUpdate("Button");
        }

        public static void Wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

    }
}
