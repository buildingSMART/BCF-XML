# Header with no files
This test case verifies support for empty headers
## Testing process
1. Load _Architectural.ifc_ from the test cases root directory
2. Import _header-with-no-files.bcfzip_
3. Verify the bcfzip was imported correctly:

> 1. There should be a single viewpoint associated with a comment
> 2. When loading the viewpoint it should match the snapshot (see snapshot.png)  

4. Export the topic(s) you imported to _exported.bcfzip_
5. Verify that no information was lost during the export
