# Multiple Topics

This test case verifies support for multiple topics

## Testing process

1. Load _Architectural.ifc_ from the test cases root directory
2. Import _multiple_topics.bcfzip_
3. Verify the bcfzip was imported correctly:

> 1. Verify that three topics has been imported
> 2. Verify that each topic has a comment
> 3. Verify that each comment has a viewpoint with snapshot

4. Export the topic(s) you imported to _exported.bcfzip_
5. Verify that no information was lost during the export