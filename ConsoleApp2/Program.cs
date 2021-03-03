using iText.IO.Source;
using iText.Kernel.Pdf;
using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {

                IronPdf.License.LicenseKey = "IRONPDF.DEVTEAM.IX3145-C34E80DCB2-ADJHRCSXUKPB-PKEVGHAWERN4-QR764J6FKUVF-C2SF2RA7BMOA-YFAVLMKNDRC5-7BDQGJ-LL4ZT5GOFJ2NEA-MINISTRYOFBUSINESS.IRO200810.4403.75155.ORG.5DEV.4YR-Q4SJ5M.RENEW.SUPPORT.10.AUG.2024";



                var pdf = new IronPdf.PdfDocument("response.pdf");
                int permissions = EncryptionConstants.ALLOW_SCREENREADERS;
                using (ByteArrayOutputStream memoryStream = new ByteArrayOutputStream(pdf.BinaryData.Length))
                {
                    using (MemoryStream inputStream = new MemoryStream(pdf.BinaryData))
                    {

                        iText.Kernel.Pdf.PdfDocument pdfDocument1 = new iText.Kernel.Pdf.PdfDocument(new PdfReader(inputStream), new PdfWriter(memoryStream));
                        pdfDocument1.Close();

                    }
                }
            }
            catch(Exception es)
            {
                var ass = es.Message;
            }

        }
    }
}
