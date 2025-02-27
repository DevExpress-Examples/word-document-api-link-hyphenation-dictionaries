<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/939971199/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1279838)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=word-document-api-link-hyphenation-dictionaries&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=word-document-api-link-hyphenation-dictionaries&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
