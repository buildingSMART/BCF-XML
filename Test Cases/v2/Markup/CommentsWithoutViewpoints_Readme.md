# Comments without GUIDs

This test case verifies support comments that are not associated with a viewpoint 

## Testing process

1. Load _Architectural.ifc_ from the test cases root directory
2. Import _comments-without-viewpoints.bcfzip_
3. Verify the bcfzip was imported correctly:

> 1. There should be a single viewpoint not associated with any comment
> 2. There should be two comments not associated with any viewpoint  


4. Export the topic(s) you imported to _exported.bcfzip_
5. Verify that no information was lost during the export


