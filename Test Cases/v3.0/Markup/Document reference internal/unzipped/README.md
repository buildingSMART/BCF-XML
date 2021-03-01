# Internal Document

This test case verifies support of internal documentreference within a BCF file.

## Testing process

1. Import the bcf file.
2. Verify the bcf was imported correctly:
> 1. Your application is aware of the document to _ThisIsADocument.txt_ as given in the _Topic_s _DocumentReferences_ property in the _markup.bcf_ file. The reference is marked as internal to indicate that the document is contained within the BCFZip.

3. Export the topic you imported.
4. Verify that no information was lost during the export.

