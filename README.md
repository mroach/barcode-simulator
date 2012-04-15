Simple application to simulate usage of a barcode scanner.

A hardware barcode scanner is a relatively simple device. It appears to your system as a keyboard and every character in the scanned barcode is sent as a keypress. Most models can optionally be configured to send an EOF character to indicate it's done sending the barcode characters. This litte app does these things. You create a list of 'barcodes' and every time you press the hotkey Windows+Z, the next barcode on the list will be typed. This is useful if you want to test how an application responds to barcode scanner input.

## Screenshot

![Screenshot](/mroach/barcode-simulator/raw/master/docs/screenshot-1.0.5.0.png)