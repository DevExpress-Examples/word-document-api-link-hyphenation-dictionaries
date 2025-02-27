using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using Document = DevExpress.XtraRichEdit.API.Native.Document;

namespace XtraRichEdit
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            using (RichEditDocumentServer wordProcessor = new RichEditDocumentServer())
            {
                wordProcessor.LoadDocument("Multimodal.docx");
                Document document = wordProcessor.Document;
                HyphenateDocument(document, wordProcessor);

                PdfExportOptions options = new PdfExportOptions();
                options.DocumentOptions.Author = "Mark Jones";
                options.Compressed = false;
                options.ImageQuality = PdfJpegImageQuality.Highest;
                wordProcessor.ExportToPdf("Modified.pdf", options);
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(@"Modified.pdf")
                {
                    UseShellExecute = true
                };
                p.Start();
            }
        }

        private static void HyphenateDocument(Document document, RichEditDocumentServer wordProcessor)
        {
            //Load embedded dictionaries
            var openOfficePatternStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("XtraRichEdit.hyph_en_US.dic");
            var customDictionaryStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("XtraRichEdit.hyphen_exc.dic");


            //Create dictionary objects
            OpenOfficeHyphenationDictionary hyphenationDictionary = new OpenOfficeHyphenationDictionary(openOfficePatternStream, new CultureInfo("EN-US"));
            CustomHyphenationDictionary exceptionsDictionary = new CustomHyphenationDictionary(customDictionaryStream, new CultureInfo("EN-US"));

            //Add them to the word processor's collection
            wordProcessor.HyphenationDictionaries.Add(hyphenationDictionary);
            wordProcessor.HyphenationDictionaries.Add(exceptionsDictionary);

            //Enable automatic hyphenation
            document.Hyphenation = true;
        }
    }
}