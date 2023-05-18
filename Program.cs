using System;
using System.IO.Ports;

namespace SerialCOM
{
	class Program
	{
		static void Main(string[] args)
		{
			SerialCommunication serialCommunication = new SerialCommunication("COM1", 9600, Parity.None, 8, StopBits.None);
			serialCommunication.Open();
			serialCommunication.SendData("Hello World");
			string ReceiveData = serialCommunication.ReceiveData();
			serialCommunication.Close();			
		}
	}
}