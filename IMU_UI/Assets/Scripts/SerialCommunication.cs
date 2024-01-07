using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;
using System;
using System.Collections;

public class SerialCommunication : MonoBehaviour
{
    SerialPort serialPort;
    public string recivedData = "Empty";
    public string [] comPortList = {"COM1","COM2","COM3","COM4" };
    BaudRateDropdown baudRateDropdown = new BaudRateDropdown();
    public void ConnectToSerialPort()
    {
        try
        {
            // Replace "COM3" with your specific port name
            serialPort = new SerialPort("COM3", 9600);
            serialPort.Open();
            serialPort.ReadTimeout = 5000;
            Debug.Log("Serial port connected.");
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error opening serial port: " + e.Message);
        }
    }

    public void DisconnectFromSerial()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            Debug.LogError("Serial Port is closed!!!");
            recivedData = "Empty";
            serialPort.Close();
        }
    }

    void Update()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            try
            {
                recivedData = serialPort.ReadLine();
                Debug.Log("Received: " + recivedData);
                StartCoroutine(ReadSerialDataAfterDelay(2.0f)); // Read again after delay
            }
            catch (TimeoutException) { }
        }
        else
        {
            Debug.LogWarning("Serial port is not initialized or closed.");
        }
    }

    IEnumerator ReadSerialDataAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (serialPort != null && serialPort.IsOpen)
        {
            try
            {
                recivedData = serialPort.ReadLine();
                Debug.Log("Received after delay: " + recivedData);
            }
            catch (TimeoutException) { }
        }
    }

    void OnDestroy()
    {
        try
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error closing serial port: " + e.Message);
        }
    }
}
