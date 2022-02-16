# Serial-Communication-Test-Program
Program used to test the serial communication with an embedded device.

Description: In master mode, the program sends a byte and expects the slave to send back the inverted byte.
In slave mode, the program receives the byte and sends the inverted value. If read/write timeout occurs or 
a wrong value is received, this is logged to a file. This kind of program can be helpful when testing the 
embedded device's UART driver.

Tools: Visual Studio 2022

Note: This program has only been tested on the Windows 10 operating system
