﻿namespace Magellanic.Devices.Gpio.Abstractions
{
    public interface IGpioController
    {
        IGpioPin OpenPin(int pinNumber);
    }
}
