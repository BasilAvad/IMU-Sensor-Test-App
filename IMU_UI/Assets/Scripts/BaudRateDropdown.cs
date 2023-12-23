using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaudRateDropdown : MonoBehaviour
{
    /// <summary>
    /// Standard baud rates include 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000 and 256000 bits per second. 
    /// </summary>
    /// <param name="index"></param>
    /// 
    public static int[] buadRateList = { 9600, 14400, 19200, 38400, 57600, 115200, 128000 };
    public  int buadRateSelected = 0;
    public void OnBaudRateChanged(int index)
    {
        switch (index)
        {
            case 0:

                buadRateSelected = buadRateList[0];
                Debug.Log("--------------------------- Selected Baud Rate: " + buadRateSelected);
                break;
            case 1:
                buadRateSelected = buadRateList[1];
                Debug.Log("--------------------------- Selected Baud Rate: " + buadRateSelected);
                break;
            case 2:
                buadRateSelected = buadRateList[2];
                Debug.Log("--------------------------- Selected Baud Rate: " + buadRateSelected);
                break;
            case 3:
                buadRateSelected = buadRateList[3];
                Debug.Log("--------------------------- Selected Baud Rate: " + buadRateSelected);
                break;
            case 4:
                buadRateSelected = buadRateList[4];
                Debug.Log("--------------------------- Selected Baud Rate: " + buadRateSelected);
                break;
            case 5:
                buadRateSelected = buadRateList[5];
                Debug.Log("--------------------------- Selected Baud Rate: " + buadRateSelected);
                break;
            default:
                break;
        }
        if (index == 0)
        {
            Debug.Log("--------------------------- Selected Baud Rate: " + 9600);
        }
        // You can use 'selectedBaudRate' in your serial port or communication setup
    }
}

