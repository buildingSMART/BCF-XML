# Minimum Information
​
This test case verifies support of a minimal BCF file.
​
## Testing process
​
1. Import the bcf file.
2. Verify the bcf was imported correctly:
> 1. The imported topic does have the following properties:
>> * Guid: b0ddb128-a997-44c1-8ad8-59492daa5f6b
>> * Title: Minimum information BCF topic.
>> * CreationDate: 2021-02-17T09:16:36.674Z (Z indicating an UTC timestamp)
>> * CreationAuthor: Architect@example.com
3. Export the topic you imported to _exported.bcf_.
4. Verify that no information was lost during the export
