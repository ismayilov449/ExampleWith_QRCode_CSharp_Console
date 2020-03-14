using System;
using System.Buffers.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Spire;
using Spire.Barcode;

namespace ExampleWith_QRCode
{
    class Program
    {


        static void Main(string[] args)
        {
            
          
            BarcodeSettings settings = new BarcodeSettings();
            settings.Type = BarCodeType.QRCode;
            settings.Unit = GraphicsUnit.Inch;
            settings.ShowText = false;
            settings.AutoResize = true;
            settings.QRCodeECL = QRCodeECL.M;

            settings.ResolutionType = ResolutionType.Printer;
            settings.Data = "https://github.com/ismayilov449";
            settings.Data2D = "https://github.com/ismayilov449";

            BarCodeGenerator generator = new BarCodeGenerator(settings);
            Image QRbarcode = generator.GenerateImage();
            

            QRbarcode.Save("../../../Images/"+ Guid.NewGuid().ToString() + ".jpeg", ImageFormat.Jpeg);

            Console.WriteLine("Your QR Code is saved in Images folder");

        }


    }
}
