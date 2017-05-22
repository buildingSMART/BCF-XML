# Single Visible Space

This test case verifies support for 
1. Displaying spaces 
2. The implementation agreement where is an element is marked as visible then all other elements should be invisible
3. The implementation agreement where spaces should be invisible unless otherwise specified

## Testing process

1. Load _Architectural.ifc_ from the test cases root directory
2. Import _single-visible-space.bcfzip_
3. Verify the bcfzip was imported correctly:

> 1. There should be a single viewpoint associated with a comment
> 2. When loading the viewpoint there should be a single space visible (see snapshot.png)  


4. Export the topic(s) you imported to _exported.bcfzip_
5. Verify that no information was lost during the export


