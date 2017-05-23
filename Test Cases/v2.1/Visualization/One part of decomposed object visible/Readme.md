# Decomposed objects

This test case verifies support for correct handling of decomposed objects, such as, curtain walls.

## Testing process

1. Load _Architectural.ifc_ from the test cases root directory
2. Import _One part visible.bcf_
3. Verify the bcfzip was imported correctly:

> Topic with guid 3146b55f-ac72-4490-bb06-60cc254b3d8e shows only one part of the decomposed wall. The guid of the visible plate is 32HeOfyn55zOiSkf6rlfHs 

4. Export the topic(s) you imported to _exported.bcfzip_
5. Verify that no information was lost during the export

## (Optional) special notes

No special notes 

