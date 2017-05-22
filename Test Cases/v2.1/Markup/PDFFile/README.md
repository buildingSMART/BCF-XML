# PDF File

This test case verifies support of an embedded .pdf file attachment, referenced as document in the topic.

## Testing process

1. Import _PDFFile.bcf_.
2. Verify the bcf was imported correctly:
> 1. Your application is aware of the relative reference to _Requirements.pdf_ in the BCF root directory as given in the _DocumentReferences_ property in the _markup.bcf_ file.
> 2. The .pdf file attachment is present.

3. Export the topic you imported to _exported.bcf_.
4. Verify that no information was lost during the export

---

Created by iabi at 22.05.2017 07:51 (UTC)