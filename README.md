# ModBusTools

ModBusTools is a C# .Net meant to make  Modbus protocol more friendly to use, especialty if you need to make some experiments with a new Modbus device. It works with any Yoctopuce devices featuring Modbus protocol such as [Yocto-RS485](htpps://www.yoctopuce.com/EN/products/usb-electrical-interfaces/yocto-rs485-v2), [Yocto-RS232](htpps://www.yoctopuce.com/EN/products/usb-electrical-interfaces/yocto-rs232) and [Yocto-Serial](htpps://www.yoctopuce.com/EN/products/usb-electrical-interfaces/yocto-serial). Theses can act as Modbus masters and control both RTU and ASCII Modbus devices.

![Screenshot example](https://www.yoctopuce.com/pubarchive/2022-05/ModbusTool-UI_2.png)

Main features are:
- Scan bus for slave addresses
- Read/write coils
- Scan for available coils 
- Read input bits
- Scan for available input bits
- Read input registers
- Scan for available input registers
- Read/write holding registers
- Scan for available holding registers
- Modbus snopping and packet decoding


You will find more information about this application on [Yoctopuce website](https://www.yoctopuce.com/EN/article/a-debug-tool-for-modbus). If you are not much into programming and are only interested in installing ModbusTool, here is a page linking to [Windows and Linux  binaries](https://www.yoctopuce.com/EN/tools.php) .

The Linux version requires  [Mono](https://www.mono-project.com/download/stable/#download-lin).



