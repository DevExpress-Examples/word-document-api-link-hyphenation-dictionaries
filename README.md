
# How to Link Hyphenation Dictionaries

The following code sample enables the word hyphenation in RichEditDocumentServer. To accomplish the task, you must first add a hyphenation dictionary to the [RichEditDocumentServer.HyphenationDictionaries](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditDocumentServer.HyphenationDictionaries) collection. Once you link hyphenation dictionaries, you can enable or suppress automatic hyphenation in code or within the UI.

> [!note]
> Please note that DevExpress does not offer hyphenation dictionaries. In this example, we utilize an American hyphenation dictionary from this site: [LibreOffice.org - English Dictionaries][1]. You can download the dictionary source (including the license agreement) from [this link][2]. If you wish to use this dictionary in your application, please ensure the relevant license agreement permits it.


## Files to Review

* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb)

## Documentation

* [Hyphenation in Word Processing Document API](https://docs.devexpress.com/OfficeFileAPI/401149/word-processing-document-api/hyphenation?p=netframework)

[1]: https://extensions.libreoffice.org/en/extensions/show/english-dictionaries
[2]: https://extensions.libreoffice.org/assets/downloads/41/dict-en-20210101.oxt