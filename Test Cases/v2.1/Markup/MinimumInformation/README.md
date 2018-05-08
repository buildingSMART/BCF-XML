# Minimum Information

This test case verifies support of a minimal BCF file.

## Testing process

1. Import _MinimumInformation.bcf_.
2. Verify the bcf was imported correctly:
> 1. The imported topic does have the following properties:
>> * Guid: 9898DE65-C0CE-414B-857E-1DF97FFAED8D
>> * Title: Minimum information BCF topic.
>> * CreationDate: 2015-07-15T13:12:42Z (Z indicating an UTC timestamp)
>> * CreationAuthor: Developer@example.com
3. Export the topic you imported to _exported.bcf_.
4. Verify that no information was lost during the export

---

Created by iabi at 22.05.2017 07:51 (UTC)