# External BIM Snippet

This test case verifies support of an external BIM Snippet reference within a BCFZip file.

## Testing process

1. Import _ExternalBIMSnippet.bcfzip_.
2. Verify the bcfzip was imported correctly:
> 1. Your application is aware of the relative reference to _http://bimfiles.example.com/JsonElement.json_ as given in the _Topic_s _BIMSnippet_ property in the _markup.bcf_ file. The reference is marked as external to indicate that the actual snippet data is not contained within the BCFZip.
3. Export the topic you imported to _exported.bcfzip_.
4. Verify that no information was lost during the export