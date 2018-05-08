# Minimum Information

This test case verifies support of a minimal BCFzip file.

## Testing process

1. Import _MinimumInformation.bcfzip_.
2. Verify the bcfzip was imported correctly:
> 1. The imported topic does have the following properties:
>> * Guid: 9898DE65-C0CE-414B-857E-1DF97FFAED8D
>> * Title: Minimum information BCFZip topic.
>> * CreationDate: 2015-07-15T13:12:42Z (Z indicating an UTC timestamp)
>> * CreationAuthor: Developer@example.com
3. Export the topic you imported to _exported.bcfzip_.
4. Verify that no information was lost during the export