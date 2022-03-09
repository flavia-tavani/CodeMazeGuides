﻿namespace TypesOfInheritanceInCSharp;

public class ConvertibleNotebook : MobileDevice, Laptop
{
    public int UsbPortNumbers { get; set; }

    public override bool DeviceCanMakePhoneCall()
    {
        if (IsConnected)
        {
            return true;
        }

        return false;
    }

    public void WriteWithKeyboard(string message)
    {
        Console.WriteLine(message);
    }
}
