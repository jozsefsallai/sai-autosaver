# PaintTool SAI Autosaver

This applet allows you to automatically save your PaintTool SAI projects at a given interval. No installation required, just download the executable and use it!

## How To Use

1. Download the applet from the [Releases page](https://github.com/jozsefsallai/sai-autosaver/releases).

2. Make sure you have PaintTool SAI opened. The applet will not start unless PaintTool SAI is open.

3. Double click on the downloaded file and ignore any security warnings you might see. This is completely normal!

4. Select your preferred save interval (minutes) and click on the **Apply** button.

5. Click on the X to minimize the applet to the notification area.

To change the interval, just double-click on the app's icon in the notification area.

To close the autosaver, just right-click on the app's icon in the notificationara and select **Close**. *(Note: the applet will automatically close once you close PaintTool SAI).*

## Frequently Asked Questions

**Will this slow down my SAI?**

If you work with very large canvases, there could be a possibility that you will experience some very small lagging during the autosave. This isn't a problem with the applet itself, it's more of a SAI problem. This also heavily depends on how powerful your machine is. If you find it annoying, try choosing a bigger save interval.

**Why does it need to run as an administrator?**

The program sends a `CTRL+S` key combination to SAI when it's the active window. Unfortunately, due to the limitations of the .NET API, to do something like this in a program like SAI needs administrator permission (note that SAI itself also requires you to run it as administrator). So do not worry! The applet will not do anything else to your computer, and if you're in doubt, you can always check the source code of the program. 

**It doesn't save! Why?**

 * Although the applet is supposed to forcefully run as an administrator, make sure that is the case.
 * The applet only performs the save when SAI is the active window. If you're on another window while the applet is supposed to perform the save, it will not do anything until the next saving cycle.

**Found a bug! Where can I report it?**

The best way to report bugs is to use the [Issues](https://github.com/jozsefsallai/sai-autosaver/issues) section of this repository. In your bug report, make sure to:

 * Specify what exactly you did when the bug occured.
 * If there's an error message, provide a screenshot of the error.
 * If the error message says something about unhandled exceptions and/or contains some very large copiable text, make sure to provide that as well.

## Contribution

All kind of contribution is always welcome and encouraged!
