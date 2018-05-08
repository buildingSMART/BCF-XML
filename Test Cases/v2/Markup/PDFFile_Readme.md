# PDF File

This test case verifies support of an embedded .pdf file attachment, referenced as document in the topic.

## Testing process

1. Import _PDFFile.bcfzip_.
2. Verify the bcfzip was imported correctly:
> 1. Your application is aware of the relative reference to _Requirements.pdf_ in the BCFzip root directory as given in the _DocumentReferences_ property in the _markup.bcf_ file.
> 2. The .pdf file attachment is present.

3. Export the topic you imported to _exported.bcfzip_.
4. Verify that no information was lost during the export