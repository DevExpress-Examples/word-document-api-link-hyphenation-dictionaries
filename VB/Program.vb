Imports System
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports Document = DevExpress.XtraRichEdit.API.Native.Document

Namespace XtraRichEdit
    Friend Module Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Using wordProcessor As New RichEditDocumentServer()
                wordProcessor.LoadDocument("Multimodal.docx")
                Dim document As Document = wordProcessor.Document
                HyphenateDocument(document, wordProcessor)

                Dim options As New PdfExportOptions()
                options.DocumentOptions.Author = "Mark Jones"
                options.Compressed = False
                options.ImageQuality = PdfJpegImageQuality.Highest
                wordProcessor.ExportToPdf("Modified.pdf", options)

                Dim p As New Process()
                p.StartInfo = New ProcessStartInfo("Modified.pdf") With {
                    .UseShellExecute = True
                }
                p.Start()
            End Using
        End Sub

        Private Sub HyphenateDocument(ByVal document As Document, ByVal wordProcessor As RichEditDocumentServer)
            ' Load embedded dictionaries
            Dim openOfficePatternStream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("XtraRichEdit.hyph_en_US.dic")
            Dim customDictionaryStream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("XtraRichEdit.hyphen_exc.dic")

            ' Create dictionary objects
            Dim hyphenationDictionary As New OpenOfficeHyphenationDictionary(openOfficePatternStream, New CultureInfo("EN-US"))
            Dim exceptionsDictionary As New CustomHyphenationDictionary(customDictionaryStream, New CultureInfo("EN-US"))

            ' Add them to the word processor's collection
            wordProcessor.HyphenationDictionaries.Add(hyphenationDictionary)
            wordProcessor.HyphenationDictionaries.Add(exceptionsDictionary)

            ' Enable automatic hyphenation
            document.Hyphenation = True
        End Sub
    End Module
End Namespace
