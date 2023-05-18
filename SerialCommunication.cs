using System.IO.Ports;
using System;

namespace SerialCOM
{
	public class SerialCommunication
	{
		private SerialPort _serialPort;
		
		public SerialCommunication(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
		{
			_serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);
		}
		
		public void Open()
		{
			_serialPort.Open();
		}
		
		public void Close()
		{
			_serialPort.Close();
		}
		
		public void SendData(string data)
		{
			_serialPort.Write(data);
		}
		
		public void ReceiveData(string data)
		{
			_serialPort.ReadLine();
		}
	}
}