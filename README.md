# Serial-Communication-Test-Program
Program used to test the serial communication with an embedded device.
Can work both as a master or slave.
In master mode, the program sends a byte and expects the slave to send back the inverted byte.
In slave mode, the program receives the byte and sends the inverted value.
If read/write timeout occurs or a wrong value is received, this is logged to a file.
This kind of program can be helpful when testing the embedded device's UART driver.
