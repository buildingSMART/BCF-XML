# Internal BIM Snippet

This test case verifies support of an internal BIM Snippet reference within a BCF file.

## Testing process

1. Import _InternalBIMSnippet.bcf_.
2. Verify the bcfzip was imported correctly:
> 1. Your application is aware of the relative reference to _JsonElement.json_ as given in the _Topic_s _BIMSnippet_ property in the _markup.bcf_ file.
> 2. The _JsonElement.json_ file has been imported successfully.
3. Export the topic you imported to _exported.bcf_.
4. Verify that no information was lost during the export

---

Created by iabi at 22.05.2017 07:51 (UTC)