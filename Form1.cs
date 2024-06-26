﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoTest
{
    public partial class Form1 : Form
    {
        bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonConnect.Enabled = false;
            label1.Text = "0";
        }

        void btnStatus() {
            if (serialPort.IsOpen)
                this.buttonStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            else
                buttonStatus.BackColor = default;
        }
        
        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBoxCom.GetItemText(comboBoxCom.SelectedItem);
            serialPort.PortName = selectedPort;
            serialPort.Open();

            if (serialPort.IsOpen)
            {
                serialPort.Write("9");
            }
            btnStatus();
            buttonConnect.Text = "Disconnect";
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            if (serialPort.IsOpen)
            {
                serialPort.Write("8");
            }
            serialPort.Close();
            buttonConnect.Text = "Connect";
            btnStatus();

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnected)
                {
                    connectToArduino();
                    comboBoxCom.Enabled = false;
                }
                else
                {
                    disconnectFromArduino();
                    comboBoxCom.Enabled = true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "ERROR");  
            
            } 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen) serialPort.Close();
        }

        private void buttonOnLed_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialPort.Write("1");
            }
        }

        private void buttonOffLed_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialPort.Write("0");
            }
        }

        private void buttonGetComPort_Click(object sender, EventArgs e)
        {
            comboBoxCom.Items.Clear();
            // Получаем список COM портов доступных в системе
            string[] portnames = SerialPort.GetPortNames();
            // Проверяем есть ли доступные
            if (portnames.Length == 0)
            {
                buttonConnect.Enabled = false;
                MessageBox.Show("COM PORT not found");
            }
            foreach (string portName in portnames)
            {
                //добавляем доступные COM порты в список           
                comboBoxCom.Items.Add(portName);
                Console.WriteLine(portnames.Length);
                if (portnames[0] != null)
                {
                    comboBoxCom.SelectedItem = portnames[0];
                    buttonConnect.Enabled = true;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            //    var v=trackBar1.Value.ToString();
            //label1.Text = v;
            //serialPort.WriteLine(v);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialPort.Write("2");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialPort.Write("3");
            }
        }
    }
}
/*
 //Скетч для приёма сообщений.


char commandValue; // данные, поступаемые с последовательного порта
int ledPinA = 3; 
int ledPinB = 5; 
String data="";

void setup() {
  pinMode(ledPinA, OUTPUT); // режим на вывод данных
   pinMode(ledPinB, OUTPUT); // режим на вывод данных
   analogWrite(ledPinA,0);
   analogWrite(ledPinB,255);
  Serial.begin(9600);
}

void loop() {
  if (Serial.available()) {
    commandValue = (char)Serial.read();
    if(commandValue !='\n')
    data +=commandValue;
    else{
      
      analogWrite(ledPinA,data.toInt());
      analogWrite(ledPinB,255-data.toInt());
      data="";
      }
  }

//  if (commandValue == '1') {
//    digitalWrite(ledPin, HIGH); // включаем светодиод
//  }
//  else {
//    digitalWrite(ledPin, LOW); // в противном случае выключаем
//  }
//  delay(10); // задержка перед следующим чтением данных
}

 */
