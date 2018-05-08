# External BIM Snippet

This test case verifies support of an external BIM Snippet reference within a BCF file.

## Testing process

1. Import _ExternalBIMSnippet.bcf_.
2. Verify the bcf was imported correctly:
> 1. Your application is aware of the relative reference to _http://bimfiles.example.com/JsonElement.json_ as given in the _Topic_s _BIMSnippet_ property in the _markup.bcf_ file. The reference is marked as external to indicate that the actual snippet data is not contained within the BCFZip.
3. Export the topic you imported to _exported.bcf_.
4. Verify that no information was lost during the export

---

Created by iabi at 22.05.2017 07:51 (UTC)